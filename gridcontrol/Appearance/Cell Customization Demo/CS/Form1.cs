#region Copyright Syncfusion Inc. 2001 - 2015
//
//  Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace CellCustomization
{
    public partial class Form1 : GridDemoForm
    {      
        #region "Constructor"
        /// <summary>
        /// Summary description for Form1.
        /// </summary>
        public Form1()
        {
            //
            //Required for Windows Form Designer Support
            //
            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            this.GridSettings();
            initializeGrid();
        }
        #endregion

        #region "Image Loading Methods"
        //Get and Load the images
#if NET9_0_OR_GREATER
        private  Image GetImages(string path)
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            if (asm != null && !string.IsNullOrEmpty(path))
                return Image.FromStream(asm.GetManifestResourceStream(path));
            return null;
        }

        private void LoadImages(ImageList imageList, string folder, int count)
        {
            for (int i = 1; i <= count; i++)
            {
                string imagePath = ($"CellCustomization.Images.{folder}.Image_{i}.png");
                imageList.Images.Add(GetImages(imagePath));
            }
        }
#endif
        #endregion

        #region "Grid Settings"
        /// <summary>
        /// Grid Settings for better look and feel
        /// </summary>
        private void GridSettings()
        {
            //Used to set default row height
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            //Used to set selection mode in grid
            this.gridControl1.Model.Options.DisplayEmptyColumns = true;
            this.gridControl1.Model.Options.DisplayEmptyRows = true;
        }
        #endregion 

        #region "Grid Customization"

        /// <summary>
        /// Customizing Grid cells
        /// </summary>
        private void initializeGrid()
        {
            #region Style declaration
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(18.0f);
            GridStyleInfo headerstyle = new GridStyleInfo();
            headerstyle.Font.Size = 12;
            headerstyle.Font.Bold = true;
            headerstyle.TextColor = Color.Black;
            headerstyle.VerticalAlignment = GridVerticalAlignment.Middle;
            headerstyle.HorizontalAlignment = GridHorizontalAlignment.Center;
            headerstyle.CellType = GridCellTypeName.Static;

            GridStyleInfo subheaderstyle = new GridStyleInfo();
            subheaderstyle.Font.Bold = true;
            subheaderstyle.VerticalAlignment = GridVerticalAlignment.Middle;
            subheaderstyle.HorizontalAlignment = GridHorizontalAlignment.Center;
            subheaderstyle.CellType = GridCellTypeName.Static;

            GridStyleInfo valuestyle = new GridStyleInfo();
            valuestyle.BackColor = SystemColors.Menu;
            valuestyle.TextColor = Color.Black;
            valuestyle.VerticalAlignment = GridVerticalAlignment.Middle;
            valuestyle.HorizontalAlignment = GridHorizontalAlignment.Center;

            gridControl1.FloatCellsMode = GridFloatCellsMode.BeforeDisplayCalculation;
            int rowIndex = 1, colIndex = 2;
            #endregion

            #region Float Cells
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex,1,rowIndex+1,gridControl1.ColCount));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "FloatingCells";

            rowIndex += 3;
            gridControl1[rowIndex, colIndex] = valuestyle;
            gridControl1[rowIndex, colIndex].Text = "Control Overview";
            rowIndex++;
            gridControl1.Model.TextDataExchange.PasteTextFromBuffer(
                String.Concat(
                "Public Properties\r\n",
                "BackColor\tGets or sets the background color for the control. \r\n",
                "Controls\tGets the collection of controls contained within the control. \r\n",
                "Cursor\tGets or sets the cursor that is displayed when the mouse pointer is over the control. \r\n",
                "DefaultBackColor\tGets the default background color of the control. \r\n",
                "DefaultForeColor\tGets the default foreground color of the control. \r\n",
                "Dock\tGets or sets which edge of the parent container a control is docked to. \r\n",
                "Enabled\tGets or sets a value indicating whether the control can respond to user interaction. \r\n",
                "Font\tGets or sets the font of the text displayed by the control. \r\n",
                "ForeColor\tGets or sets the foreground color of the control. \r\n",
                ""),
                GridRangeInfo.Cell(rowIndex, colIndex),
                int.MaxValue);
            gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Cells(1, 1, gridControl1.RowCount, gridControl1.ColCount));
            #endregion

            #region CoveredCell
            rowIndex = 16;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "Covered Cells";

            rowIndex += 3;

            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex + 2, colIndex+1));
            gridControl1[rowIndex, colIndex].BackColor = Color.Orange;
            gridControl1[rowIndex, colIndex].Text = "Covered in rows & cols";
            gridControl1[rowIndex, colIndex].TextColor = Color.Black;
            gridControl1[rowIndex, colIndex].Font.Bold = true;
            gridControl1[rowIndex, colIndex].VerticalAlignment = GridVerticalAlignment.Middle;
            gridControl1[rowIndex, colIndex].HorizontalAlignment = GridHorizontalAlignment.Center;

            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex+3, rowIndex, colIndex + 5));
            gridControl1[rowIndex, colIndex + 3].BackColor = Color.Orange;
            gridControl1[rowIndex, colIndex + 3].Text = "Covered in cols";
            gridControl1[rowIndex, colIndex + 3].TextColor = Color.Black;
            gridControl1[rowIndex, colIndex + 3].Font.Bold = true;
            gridControl1[rowIndex, colIndex + 3].VerticalAlignment = GridVerticalAlignment.Middle;
            gridControl1[rowIndex, colIndex + 3].HorizontalAlignment = GridHorizontalAlignment.Center;

            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex + 7, rowIndex + 5, colIndex + 7));
            gridControl1[rowIndex, colIndex + 7].BackColor = Color.Orange;
            gridControl1[rowIndex, colIndex + 7].Text = "Cov. in rows";
            gridControl1[rowIndex, colIndex + 7].TextColor = Color.Black;
            gridControl1[rowIndex, colIndex + 7].Font.Bold = true;
            gridControl1[rowIndex, colIndex + 7].VerticalAlignment = GridVerticalAlignment.Middle;
            gridControl1[rowIndex, colIndex + 7].HorizontalAlignment = GridHorizontalAlignment.Center;

            #endregion

            #region Banner Cells
            rowIndex = 26;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "Banner Cells";

            rowIndex += 3;

            GridStyleInfo style;
            style = gridControl1[rowIndex, colIndex];
            gridControl1.BanneredRanges.Add(GridRangeInfo.FromTlhw(rowIndex, colIndex, 8, colIndex + 1));
            style.BackgroundImage = GetImage(@"cloud2.png");
            style.Text = "cloud2.png";
            style.TextColor = Color.Red;
            style.BackgroundImageMode = GridBackgroundImageMode.StretchImage;


            style = gridControl1[rowIndex, colIndex + 5];
            gridControl1.BanneredRanges.Add(GridRangeInfo.FromTlhw(rowIndex, colIndex + 5, 8, colIndex + 1));
            style.Interior = new BrushInfo(GradientStyle.PathEllipse, SystemColors.Highlight, Color.White);
            style.Text = "GradientStyle.PathEllipse";
            style.TextColor = Color.Blue;
            #endregion

            #region Custom Borders 
            rowIndex = 39;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "Custom Borders Cells";
          
            gridControl1.DrawCellFrameAppearance += new GridDrawCellBackgroundEventHandler(gridControl1_DrawCellFrameAppearance);
            gridControl1.BeginUpdate();
            rowIndex += 3;
            rindex = rowIndex; cindex = colIndex;
            for (int i = rowIndex; i <= rindex + 5; i++)
            {
                for (int j = colIndex; j <= cindex + 7; j++)
                {
                    GridStyleInfo newstyle = gridControl1[i, j];
                    newstyle.BorderMargins = new GridMarginsInfo(5, 5, 5, 5);
                    newstyle.Borders.All = GridBorder.Empty;
                    newstyle.CellAppearance = GridCellAppearance.Flat;
                }
            }
            gridControl1.EndUpdate(true);
           
            #endregion

            #region CustomDraw
            gridControl1.ActivateCurrentCellBehavior = GridCellActivateAction.DblClickOnCell;
            rowIndex = 49;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "Custom Drawing in  GridCells";
            //creating the datatable for the datasource
            DataTable dt = new DataTable();
            dt.Columns.Add("BookID");
            dt.Columns.Add("BookName");
            dt.Columns.Add("Author");
            dt.Columns.Add("Price");
            dt.Rows.Add(new object[] { "BookID", "BookName", "Author", "Price" });
            dt.Rows.Add(new object[] { "1001", "Computer Networks", "Tanenbaum", "75.00" });
            dt.Rows.Add(new object[] { "1002", "DBMS", "Navbathe",  "85.00" });
            dt.Rows.Add(new object[] { "1003", "Let us C", "Leland Beck",  "50.00" });
            dt.Rows.Add(new object[] { "1004", "System Software", "Hamacher",  "78.00" });
            dt.Rows.Add(new object[] { "1005", "Computer Organization", "Carl",  "50.00" });
            dt.Rows.Add(new object[] { "1006", "Test your c skills", "Ivan",  "75.00" });
            dt.Rows.Add(new object[] { "1007", "C#.Net", "Alexis",  "50.00" });
            dt.Rows.Add(new object[] { "1008", "Multimedia", "Leon",  "75.00" });
            dt.AcceptChanges();

            rowIndex += 3;
            gridControl1[rowIndex, 6].Text = "Cart";
            gridControl1[rowIndex, 7].Text = "BookStatus";
            for (int i = rowIndex + 1; i <= 60; i++)
                this.gridControl1[i, 6].CellValue = 0;

            gridControl1.PopulateValues(GridRangeInfo.Cells(52, 2, 60, 5), dt);

            for (int k = 53; k <= 60; k++)
            {
                for (int l = 2; l <= 7; l++)
                {
                    //set the background of the cell
                    gridControl1[k, l].Interior = new BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(255, 187, 111), Color.White);
                }
            }


            for (int l = 2; l <= 7; l++)
            {
                //set the celltype as header
                gridControl1[52, l].CellType = GridCellTypeName.Header;

            }
            this.gridControl1.CellClick += new GridCellClickEventHandler(HandleAClick);
            //Handle the following events to do custom painting
            this.gridControl1.CellDrawn += new GridDrawCellEventHandler(gridControl1_CellDrawn);
            this.gridControl1.DrawCell += new GridDrawCellEventHandler(gridControl1_DrawCell);
            #endregion
        }

        #endregion

        #region "Event Handlers"

        //sets back color and text color.
        private void HandleAClick(object sender, GridCellClickEventArgs e)
        {
            if (e.RowIndex > 52 && e.ColIndex == 6 && e.RowIndex <= 60)
            {
                GridStyleInfo style = this.gridControl1[e.RowIndex, e.ColIndex];
                if (style.CellValue.ToString() == "0")
                {
                    style.CellValue = 1;

                    for (int l = 2; l <= 7; l++)
                    {
                        //set the backcolor of the cell
                        gridControl1[e.RowIndex, l].BackColor = Color.FromArgb(206, 213, 231);
                    }
                    //set the textcolor of the cell
                    this.gridControl1.RowStyles[e.RowIndex].TextColor = Color.RoyalBlue;
                }
                else
                {
                    style.CellValue = 0;
                    this.gridControl1.RowStyles[e.RowIndex].TextColor = Color.Black;
                }
            }
            this.gridControl1.RefreshRange(GridRangeInfo.Row(e.RowIndex));
        }

        //draw the cell
        private void gridControl1_CellDrawn(object sender, GridDrawCellEventArgs e)
        {
            if (e.ColIndex == 6 && e.RowIndex > 52 && e.RowIndex<=60)
            {
                Rectangle rec = e.Bounds, rect = e.Bounds;
                rec.X = (e.Bounds.Left + e.Bounds.Right) / 2;
                if (e.Style.CellValue.ToString() == "1")
                {
                    e.Graphics.FillEllipse(Brushes.Gray, rect);
                    GridImageCellRenderer.DrawImage(e.Graphics, this.imageList1, 1, rec, false);
                }
                else
                {
                    e.Graphics.FillEllipse(Brushes.LightGray, rect);
                    GridImageCellRenderer.DrawImage(e.Graphics, this.imageList1, 0, rec, false);
                }
            }
            if (e.ColIndex == 7 && e.RowIndex > 52 && e.RowIndex <= 60)
            {

                Rectangle rec = e.Bounds;
                rec.X = (e.Bounds.Left + e.Bounds.Right) / 2;
                if (this.gridControl1[e.RowIndex, 6].CellValue.ToString() == "1")
                {
                    Rectangle rect = e.Bounds;
                    GridImageCellRenderer.DrawImage(e.Graphics, this.imageList1, 3, rec, false);
                    e.Graphics.DrawLine(Pens.Red, rect.X, rect.Y, rect.X + rect.Width, rect.Y + rect.Height);
                    e.Graphics.DrawLine(Pens.Red, rect.X, rect.Y + rect.Height, rect.X + rect.Width, rect.Y);
                }
                else
                    GridImageCellRenderer.DrawImage(e.Graphics, this.imageList1, 2, rec, false);
            }
        }
        //sets cell interior 
        private void gridControl1_DrawCell(object sender, GridDrawCellEventArgs e)
        {
            if (e.RowIndex >52 &&  e.RowIndex % 2 == 0 && e.ColIndex>=2 && e.ColIndex<=7)
            {
                //set the background of the cell
                e.Style.Interior = new BrushInfo(GradientStyle.BackwardDiagonal, Color.FromArgb(51, 51, 101), Color.White);
            }
        }

        int rindex, cindex;
        TextureBrush tb = null;
        // sets cell appearance
        void gridControl1_DrawCellFrameAppearance(object sender, GridDrawCellBackgroundEventArgs e)
        {
            int rowIndex = e.Style.CellIdentity.RowIndex;
            int colIndex = e.Style.CellIdentity.ColIndex;

            if (rowIndex >= rindex && colIndex>=cindex && rowIndex <=rindex+5 && colIndex<=cindex+7)
            {
                Brush brush;
                Graphics g = e.Graphics;              
                // Use TextureBrush for upper left cells
                if (colIndex < 6 && rowIndex < 12)
                    brush = tb;
                else
                    // Otherwise use a gradient brush
                    brush = new System.Drawing.Drawing2D.LinearGradientBrush(e.TargetBounds, Color.FromArgb(204, 212, 230), Color.FromArgb(252, 172, 38), 45f);

                // Draw custom border for the cell. Space has been reserved for this
                // area with the TableStyle.BorderMargins property.
                Rectangle rect = e.TargetBounds;
                rect.Inflate(-2, -2);
                Rectangle[] rects = new Rectangle[] 
                    {
                        new Rectangle(rect.X, rect.Y, rect.Width, 4),
                        new Rectangle(rect.X, rect.Y, 4, rect.Height),
                        new Rectangle(rect.Right-4, rect.Y, 4, rect.Height),
                        new Rectangle(rect.X, rect.Bottom-4, rect.Width, 4),
                    };
                g.FillRectangles(brush, rects);

                // Disallow grids default drawing of cell frame for this cell
                e.Cancel = true;
            }
        }

        //used to get image.
        private Image GetImage(string bitmapName)
        {
            Image bitmap = null;
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    bitmap = new Bitmap(bitmapName);
                bitmapName = @"..\" + bitmapName;
            }
            return bitmap;
        }

        #endregion

    }
}