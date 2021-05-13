using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using System.Drawing.Printing;

namespace PrintPageLayout
{
    class LayoutSupportHelper : GridPrintDocument, IDisposable
    {
        private Color textColor = Color.FromArgb(128, Color.Blue);

        /// <summary>
        /// Gets or sets the color of teh overlaid text.
        /// </summary>
        public Color TextColor
        {
            get { return textColor; }
            set { textColor = value; }
        }

        private Color lineColor = Color.FromArgb(128, Color.Blue);

        /// <summary>
        /// Gets or sets the color of the overlaid lines.
        /// </summary>
        public Color LineColor
        {
            get { return lineColor; }
            set { lineColor = value; }
        }

        private int lineWidth = 3;

        /// <summary>
        /// Gets or sets the width of the overlaid lines.
        /// </summary>
        public int LineWidth
        {
            get { return lineWidth; }
            set { lineWidth = value; }
        }


        bool showLayoutLines = false;

        /// <summary>
        /// Gets or sets whether print page layout borders are displayed.
        /// </summary>
        public bool ShowLayoutLines
        {
            get { return showLayoutLines; }
            set 
            {
                if (showLayoutLines != value)
                {
                    showLayoutLines = value;
                    grid.Refresh();
                }
            }
        }


        string pageTextFormat = "page {0}";

        /// <summary>
        /// Gets or sets the content of the displayed text string.
        /// </summary>
        /// <remarks> This string is used as a format in string.Format(PageTextFormat, pageNumber)
        /// to provide the string that is overlaid on each page. The default value is "page {0}".
        /// </remarks>
        public string PageTextFormat
        {
            get { return pageTextFormat; }
            set { pageTextFormat = value; }
        }

        PageFlowDirection pageFlow = PageFlowDirection.Horizontal;//PageFlowDirection.Vertical;

        /// <summary>
        /// Gets or sets whether the page numbers are counted horizontally or vertically.
        /// </summary>
        public PageFlowDirection PageFlow
        {
            get { return pageFlow; }
            set { pageFlow = value; }
        }

        List<int> pageBreakCols;

        /// <summary>
        /// The list of page break column numbers.
        /// </summary>
        public List<int> PageBreakCols
        {
            get 
            {
                if (pageBreakCols == null)
                    pageBreakCols = new List<int>();
                return pageBreakCols; 
            }
            set { pageBreakCols = value; }
        }

        List<int> pageBreakRows;

        /// <summary>
        /// The list of page break row numbers.
        /// </summary>
        public List<int> PageBreakRows
        {
            get
            {
                if (pageBreakRows == null)
                    pageBreakRows = new List<int>();
                return pageBreakRows;
            }
            set { pageBreakRows = value; }
        }

        private GridControlBase grid;

       /// <summary>
       /// Constuctor.
       /// </summary>
       /// <param name="grid">The GridControlBase whose displayed is being overlaid.</param>
        public LayoutSupportHelper(GridControlBase grid) : base(grid)
        {
            this.grid = grid;
            grid.DisableScrollWindow = true;

            grid.Paint += new PaintEventHandler(grid_Paint);
            grid.TopRowChanged += new GridRowColIndexChangedEventHandler(grid_TopRowChanged);
            grid.LeftColChanged += new GridRowColIndexChangedEventHandler(grid_LeftColChanged);
            grid.ResizingRows += new GridResizingRowsEventHandler(grid_ResizingRows);
            grid.ResizingColumns += new GridResizingColumnsEventHandler(grid_ResizingColumns);
            

            SetBreaks();
        }

        private void SetBreaks()
        {
            //DateTime dt = DateTime.Now;
            //while (DateTime.Now.Subtract(dt).TotalMilliseconds < SystemInformation.DoubleClickTime)
            //{
            //    wait..
            //}
            PageBreakCols.Clear();
            PageBreakRows.Clear();

            PrintEventArgs ev = new PrintEventArgs();
            OnBeginPrint(ev);
            foreach (int i in grid.PrintInfo.m_awPageFirstCol)
            {
                PageBreakCols.Add(i - 1);
            }
            PageBreakCols.RemoveAt(0);
            foreach (int i in grid.PrintInfo.m_awPageFirstRow)
            {
                PageBreakRows.Add(i - 1);
            }
            PageBreakRows.RemoveAt(0);
            OnEndPrint(ev);
            if (grid.Updating)
                grid.EndUpdate();
            grid.Refresh();
        }

         void grid_ResizingColumns(object sender, GridResizingColumnsEventArgs e)
        {
            if (e.Reason == GridResizeCellsReason.MouseUp || e.Reason == GridResizeCellsReason.ResetDefault || e.Reason == GridResizeCellsReason.ResetHide)
            {
                grid.BeginUpdate();
                //use BeginInvoke to reset the breaks after the event handling completes...
                grid.BeginInvoke(new MethodInvoker(SetBreaks));
            }
            
        }

        void grid_ResizingRows(object sender, GridResizingRowsEventArgs e)
        {
            if (e.Reason == GridResizeCellsReason.MouseUp || e.Reason == GridResizeCellsReason.ResetDefault || e.Reason == GridResizeCellsReason.ResetHide)
            {
                 grid.BeginUpdate();
                //use BeginInvoke to reset the breaks after the event handling completes...
                grid.BeginInvoke(new MethodInvoker(SetBreaks));
            }
             
        }

           void grid_Paint(object sender, PaintEventArgs e)
        {
            if (ShowLayoutLines)
            {
                DrawColumnLines(e);
                DrawRowLines(e);
                DrawPageNumbers(e);
            }
        }

        void grid_TopRowChanged(object sender, GridRowColIndexChangedEventArgs e)
        {
            if (ShowLayoutLines)
            {
                grid.Invalidate();
            }
        }

        void grid_LeftColChanged(object sender, GridRowColIndexChangedEventArgs e)
        {
            if (ShowLayoutLines)
            {
                grid.Invalidate();
            }
        }

        private void DrawPageNumbers(PaintEventArgs pe)
        {
            if (PageFlow == PageFlowDirection.Horizontal)
            {
                DrawHorizontalPageNumbers(pe);
            }
            else
            {
                DrawVerticalPageNumbers(pe);
            }
        }

        private void DrawVerticalPageNumbers(PaintEventArgs pe)
        {
            int pageNo = 1;
            int leftCol = 1;
            int topRow = 1;

            if (PageBreakCols.Count > 0)
            {
                
                foreach (int col in PageBreakCols)
                {
                    topRow = 1;
                    Rectangle rect = grid.RangeInfoToRectangle(GridRangeInfo.Cells(topRow, leftCol, grid.ViewLayout.LastVisibleRow, col));

                    if (PageBreakRows.Count > 0)
                    {
                        foreach (int row in PageBreakRows)
                        {
                           
                            rect = grid.RangeInfoToRectangle(GridRangeInfo.Cells(topRow, leftCol, row, col));
                           
                            DrawPageNumberinRect(rect, pageNo, pe);
                            pageNo++;
                            topRow = row;
                        }
                    }
                    else
                    {
                        DrawPageNumberinRect(rect, pageNo, pe);
                        pageNo++;
                    }

                    leftCol = col;
                }
            }
            else
            {
                Rectangle rect = grid.RangeInfoToRectangle(GridRangeInfo.Cells(topRow, leftCol, grid.ViewLayout.LastVisibleRow, grid.ViewLayout.LastVisibleCol));

                if (PageBreakRows.Count > 0)
                {
                    foreach (int row in PageBreakRows)
                    {
                       
                        rect = grid.RangeInfoToRectangle(GridRangeInfo.Cells(topRow, leftCol, row, grid.ViewLayout.LastVisibleCol));
                        DrawPageNumberinRect(rect, pageNo, pe);
                        pageNo++;
                        topRow = row;
                    }
                }
                else
                {
                    DrawPageNumberinRect(rect, pageNo, pe);
                    pageNo++;
                }
            }

        }

        public event DrawPageNumberEventHandler DrawPageNumber;
        protected virtual void OnDrawPageNumber(DrawPageNumberEventArgs e)
        {
            if (DrawPageNumber != null)
                DrawPageNumber(grid, e);
        }
        private void DrawPageNumberinRect(Rectangle rect, int pageNo, PaintEventArgs pe)
        {
            if (rect.Width > 100 && rect.Height > 100)
            {
                string s = string.Format("page {0}", pageNo);
                using (Font f = new Font(grid.Font.FontFamily, 40))
                {
                    Size sz = TextRenderer.MeasureText(s, f);
                    Rectangle r = GridUtil.CenterInRect(rect, sz);

                    DrawPageNumberEventArgs e = new DrawPageNumberEventArgs(pe, r, s);
                    OnDrawPageNumber(e);
                    if (!e.Cancel)
                    {
                        using (Brush b = new SolidBrush(TextColor))
                        {
                            Region region = pe.Graphics.Clip;
                            pe.Graphics.Clip = new Region(grid.RangeInfoToRectangle(grid.ViewLayout.VisibleCellsRange));
                            pe.Graphics.DrawString(s, f, b, r);
                            pe.Graphics.Clip = region;
                        }
                    }
                }
            }
        }

        private void DrawHorizontalPageNumbers(PaintEventArgs pe)
        {
            int pageNo = 1;
            int leftCol = 1;
            int topRow = 1;

            if (PageBreakRows.Count > 0)
            {

                foreach (int row in PageBreakRows)
                {
                    leftCol = 1;


                    Rectangle rect = grid.RangeInfoToRectangle(GridRangeInfo.Cells(topRow, leftCol, row, grid.ViewLayout.LastVisibleCol));

                    if (PageBreakCols.Count > 0)
                    {
                        foreach (int col in PageBreakCols)
                        {

                            rect = grid.RangeInfoToRectangle(GridRangeInfo.Cells(topRow, leftCol, row, col));

                            DrawPageNumberinRect(rect, pageNo, pe);
                            pageNo++;
                            leftCol = col;
                        }
                    }
                    else
                    {
                        DrawPageNumberinRect(rect, pageNo, pe);
                        pageNo++;
                    }

                    topRow = row;
                }
            }
            else
            {
                Rectangle rect = grid.RangeInfoToRectangle(GridRangeInfo.Cells(topRow, leftCol, grid.ViewLayout.LastVisibleRow, grid.ViewLayout.LastVisibleCol));

                if (PageBreakCols.Count > 0)
                {
                    foreach (int col in PageBreakCols)
                    {

                        rect = grid.RangeInfoToRectangle(GridRangeInfo.Cells(topRow, leftCol, grid.ViewLayout.LastVisibleRow, col));
                        DrawPageNumberinRect(rect, pageNo, pe);
                        pageNo++;
                        leftCol = col;
                    }
                }
                else
                {
                    DrawPageNumberinRect(rect, pageNo, pe);
                    pageNo++;
                }
            }

        }

        private void DrawRowLines(PaintEventArgs pe)
        {
            if (PageBreakRows.Count > 0)
            {
                foreach (int row in PageBreakRows)
                {
                    if (row > grid.ViewLayout.LastVisibleRow ||
                         (row == grid.ViewLayout.LastVisibleRow && grid.ViewLayout.HasPartialVisibleRows))
                    {
                        break;
                    }
                    if (row < grid.TopRowIndex)
                    {
                        continue;
                    }

                    Rectangle rect = grid.RangeInfoToRectangle(GridRangeInfo.Row(row));

                    using (Pen p = new Pen(LineColor, LineWidth))
                    {
                        Region region = pe.Graphics.Clip;
                        pe.Graphics.Clip = new Region(grid.RangeInfoToRectangle(grid.ViewLayout.VisibleCellsRange));
                        pe.Graphics.DrawLine(p, rect.Left, rect.Bottom, rect.Right, rect.Bottom);
                        pe.Graphics.Clip = region;
                    }
                }
            }
        }

        private void DrawColumnLines(PaintEventArgs pe)
        {
            if (PageBreakCols.Count > 0)
            {
                foreach (int col in PageBreakCols)
                {
                    if (col > grid.ViewLayout.LastVisibleCol ||
                         (col == grid.ViewLayout.LastVisibleCol && grid.ViewLayout.HasPartialVisibleCols))
                    {
                        break;
                    }
                    if (col < grid.LeftColIndex)
                    {
                        continue;
                    }

                    Rectangle rect = grid.RangeInfoToRectangle(GridRangeInfo.Col(col));
                     
                    using (Pen p = new Pen(LineColor, LineWidth))
                    {
                        Region region = pe.Graphics.Clip;
                        pe.Graphics.Clip = new Region(grid.RangeInfoToRectangle(grid.ViewLayout.VisibleCellsRange));
                        pe.Graphics.DrawLine(p, rect.Right, rect.Top, rect.Right, rect.Bottom);
                        pe.Graphics.Clip = region;
                    }
                }
            }
        }

        #region IDisposable Members

        void IDisposable.Dispose()
        {
            if (grid != null && !grid.IsDisposed)
            {
                grid.Paint -= new PaintEventHandler(grid_Paint);
                grid.TopRowChanged -= new GridRowColIndexChangedEventHandler(grid_TopRowChanged);
                grid.LeftColChanged -= new GridRowColIndexChangedEventHandler(grid_LeftColChanged);
                grid.ResizingRows -= new GridResizingRowsEventHandler(grid_ResizingRows);
                grid.ResizingColumns -= new GridResizingColumnsEventHandler(grid_ResizingColumns);
            
            }
        }

        #endregion
    }

/// <summary>
    /// Event that is raised just prior to the page number being drawn.
/// </summary>
/// <param name="grid">The GridControlBase</param>
/// <param name="e">The event arguments.</param>
    public delegate void DrawPageNumberEventHandler(GridControlBase grid, DrawPageNumberEventArgs e);


    /// <summary>
    /// Event arguments for an event that is raised just prior to the page number being drawn. You can cancel this event
    /// to avoid the default drawing and instead do your own drawing to provide a customized look.
    /// </summary>
    public class DrawPageNumberEventArgs : CancelEventArgs
    {

        public DrawPageNumberEventArgs(PaintEventArgs pe, Rectangle rect, string text)
        {
            this.pe = pe;
            this.rect = rect;
            this.text = text;
        }

        PaintEventArgs pe;

        /// <summary>
        /// The PaintEventArgs that is drawing the text.
        /// </summary>
        public PaintEventArgs Pe
        {
            get { return pe; }
        }
        Rectangle rect;

        /// <summary>
        /// Gets or sets the Rectangle where the text is drawn.
        /// </summary>
        public Rectangle Rect
        {
            get { return rect; }
            set { rect = value; }
        }
        string text;

        /// <summary>
        /// Gets or sets the text to be drawn.
        /// </summary>
        public string Text
        {
            get { return text; }
            set { text = value; }
        }

    }

    enum PageFlowDirection
    {
        Vertical,
        Horizontal
    }
}
