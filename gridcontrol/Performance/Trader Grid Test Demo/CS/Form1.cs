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
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace TraderGridTest
{

    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : GridDemoForm
    {
        #region "API Definition
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private System.Windows.Forms.Timer m_timer;
        private ArrayList m_set;
        private GridControl m_syncGrid;
        private System.Random rand;
        private int m_numUpdatesPerTick = 20;
        bool shouldInsert = false;

        private int toggleInsertRemove = 20;// toggle between inserting and removing after n inserts/n removals.
        private int insertRemoveModulus = 2; // frequency of insert / remove : every n timer ticks
        int initialRowCount = 50;
        // Alter this integer to change the type of test


        bool drawDirectToDC = true;						// Draw text directly to graphics context instead of Invalidate / Update messages
        bool drawTextUsingGDI = true;					// Enable GDI drawing instead of GDI+
        bool disableAlphaBlendForHeaderCells = true;	// Don't use alphablending for header cells.
        bool disableDottedGridLines = true;				// Do not use dotted grid lines - use solid lines instead.
        bool disablePrepareViewStyleInfo = true;		// Disable PrepareViewStyleInfo events if not needed.
        bool useGDIExtTextOutInsteadOfDrawText = true;  // When text does not need to be clipped and wrapped use faster ExtTextOut routine.
        bool showNumberedRowHeaders = false;             // Show numbered row headers
        bool allowChangeTopRowWhenInsertBeforeView = true; // Set this true if you want to increase/decrease the TopRowIndex when the grid is scrolled down 
        // and rows are inserted or removed before the first visible row
        int insertRemoveCount = 1;                      // use 1 if you want to check out inserting and removing rows

        #endregion

        #region "Constructor"
        public Form1()
        {
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            this.GridSettings();
            this.SampleCustomization();
        }
        #endregion

        #region "Sample Grid Settings"

        /// <summary>
        /// Grid control customization.
        /// </summary>
        private void GridSettings()
        {
            m_syncGrid = new GridControl();
            m_syncGrid.DpiAware = true;
            // Don't use alphablending for header cells.
            if (disableAlphaBlendForHeaderCells)
            {
                this.m_syncGrid.BaseStylesMap["Column Header"].StyleInfo.BackColor = SystemColors.Control;
                this.m_syncGrid.BaseStylesMap["Row Header"].StyleInfo.BackColor = SystemColors.Control;
                this.m_syncGrid.BaseStylesMap["Header"].StyleInfo.BackColor = SystemColors.Control;
            }

            // Do not use dotted grid lines - use solid lines instead.
            if (this.disableDottedGridLines)
            {
                this.m_syncGrid.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
                this.m_syncGrid.Model.Properties.GridLineColor = SystemColors.ControlLight;
            }

            // Disable PrepareViewStyleInfo events if not needed.
            this.m_syncGrid.SupportsPrepareViewStyleInfo = !disablePrepareViewStyleInfo;

            // Enable GDI drawing instead of GDI+
            if (drawTextUsingGDI)
            {
                this.m_syncGrid.DrawCellDisplayText += new GridDrawCellDisplayTextEventHandler(m_syncGrid_DrawCellDisplayText);

                if (useGDIExtTextOutInsteadOfDrawText)
                {
                    this.m_syncGrid.BaseStylesMap["Standard"].StyleInfo.WrapText = false;
                    this.m_syncGrid.BaseStylesMap["Standard"].StyleInfo.Trimming = StringTrimming.None;
                }
            }

            this.m_syncGrid.VerticalThumbTrack = true;
            this.m_syncGrid.HorizontalThumbTrack = true;
            this.m_syncGrid.HScrollPixel = true;

            this.Size = new Size(1324, 710);
            m_syncGrid.Location = new Point(this.Location.X + 10, this.Location.Y + 10);
            m_syncGrid.Size = new Size(this.Size.Width - 30, 430);
            m_syncGrid.BorderStyle = BorderStyle.FixedSingle;
            m_syncGrid.VScrollBehavior = GridScrollbarMode.Disabled;
            this.DropShadow = true;
            GridStyleInfo style = m_syncGrid.BaseStylesMap["Header"].StyleInfo;
            style.TextColor = Color.MidnightBlue;
            style.Font.Facename = "Verdana";
            style.Borders.All = new GridBorder(GridBorderStyle.Solid, Color.LightGray, GridBorderWeight.Thin);
            m_syncGrid.ThemesEnabled = true;
            m_syncGrid.Dock = DockStyle.Fill;
            m_syncGrid.GridVisualStyles = GridVisualStyles.Metro;
            this.m_syncGrid.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            this.m_syncGrid.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(70.0f);
        }

        #endregion

        #region "Sample Customizations"

        /// <summary>
        /// TraderGrid sample Customizations 
        /// </summary>
        private void SampleCustomization()
        {
            rand = new Random(DateTime.Now.Second);

            // Every 10 milliseconds 5 updates.

            m_syncGrid.QueryCellInfo += new GridQueryCellInfoEventHandler(m_syncGrid_QueryCellInfo);
            m_syncGrid.SaveCellInfo += new GridSaveCellInfoEventHandler(m_syncGrid_SaveCellInfo);
            m_syncGrid.QueryRowCount += new GridRowColCountEventHandler(m_syncGrid_QueryRowCount);
            m_syncGrid.QueryColCount += new GridRowColCountEventHandler(m_syncGrid_QueryColCount);
            m_syncGrid.SmoothControlResize = false;
            m_syncGrid.BaseStylesMap["Standard"].StyleInfo.Enabled = false;
            m_syncGrid.BaseStylesMap["Standard"].StyleInfo.CellType = "Static";
            m_syncGrid.AllowDragSelectedRows = false;
            m_syncGrid.AllowSelection = GridSelectionFlags.None;
            m_syncGrid.ResizeRowsBehavior = GridResizeCellsBehavior.None;
            m_set = new ArrayList();
            rand = new Random(DateTime.Now.Second);
            for (int i = 0; i < initialRowCount; i++)
            {
                int next = rand.Next(100);
                m_set.Add(new object[]{"Hello world",next+1,next+2,
										  next+3,next+4,next+5,next+6,
										  next+7,next+8,next+9,next+10,
										  next+11,next+12,next+13,next+14,
										  next+15,next+16,next+17,
										  next+18,next+19,next+20});
            }
            this.Controls.Add(m_syncGrid);

            m_timer = new System.Windows.Forms.Timer();
            m_timer.Interval = 30;
            m_timer.Tick += new EventHandler(m_timer_Tick);
            m_timer.Start();
        }

        #region Event Handlers

        #region SaveCellInfo
        /// <summary>
        /// Save the cell information once it updated
        /// </summary>
        void m_syncGrid_SaveCellInfo(object sender, GridSaveCellInfoEventArgs e)
        {
            // Don't save changes.
            e.Handled = true;
        }
        #endregion

        #region "Decleration"
        Graphics g = null;
        Size oldSize = Size.Empty;

        int icount = 0;
        int timerCount = 0;
        Color[] colors = new Color[] {
										 
										 Color.FromArgb( 0x85, 0xbf, 0x75 ),
										 Color.FromArgb( 0xde, 0x64, 0x13 ),
										 Color.FromArgb( 0xb4, 0xe7, 0xf2 ),
										 Color.FromArgb( 0xff, 0xbf, 0x34 ),
										 Color.FromArgb( 0x82, 0x2e, 0x1b ),
										 Color.FromArgb( 0x3a, 0x86, 0x7e ),
		};

        Random rnd = new Random();
        #endregion

        #region Timer_Tick
        /// <summary>
        /// Set timer clok to notify the changes
        /// </summary>
        private void m_timer_Tick(object sender, EventArgs e)
        {
            timerCount++;
            GridRangeInfo gCells = GridRangeInfo.EmptyRange();

            if (oldSize != m_syncGrid.ClientSize)
            {
                // Dispose graphics context if size was changed.
                if (g != null)
                    g.Dispose();
                g = null;
                oldSize = m_syncGrid.ClientSize;
            }

            if (drawDirectToDC && g == null)
                g = m_syncGrid.CreateGridGraphics();

            try
            {
                for (int i = 0; i < m_numUpdatesPerTick; i++)
                {
                    int recNum = rand.Next(m_set.Count - 1);
                    int rowNum = recNum + 1;
                    int col = rand.Next(18) + 1;
                    int colNum = col + 1;
                    object[] drow = (object[])m_set[recNum];
                    drow[col] = rand.Next(100);
                    GridRangeInfo g1 = GridRangeInfo.Cell(rowNum, colNum);

                    gCells = GridRangeInfo.UnionRange(gCells, g1);

                    // Clear our volatile cache
                    m_syncGrid.ResetVolatileData();

                    // Handle case when values is change for current cell.
                    if (g1 == m_syncGrid.CurrentCell.RangeInfo)
                    {
                        m_syncGrid.CurrentCell.Model.ResetActiveText(rowNum, colNum);
                    }
                    else
                    {

                        // Draw direct to dc
                        if (drawDirectToDC)
                        {
                            Rectangle bounds = m_syncGrid.RangeInfoToRectangle(g1);
                            if (!bounds.IsEmpty)
                            {
                                // DrawClippedGrid method lets you simply draw the cells at the specified bounds directly to the graphics context.
                                m_syncGrid.DrawClippedGrid(g, bounds);
                            }
                        }
                    }
                }

                if (!drawDirectToDC)
                {
                    m_syncGrid.ResetVolatileData();
                    m_syncGrid.ViewLayout.Lock();  // Prevent subsequent calls to ViewLayout.Reset method from clearing the layout information. Method was added in 3.1.0.x
                    Rectangle bounds = m_syncGrid.RangeInfoToRectangle(gCells);
                    if (!bounds.IsEmpty)
                    {
                        m_syncGrid.Invalidate(bounds);
                        m_syncGrid.Update();
                    }
                    m_syncGrid.ViewLayout.Unlock();
                }

                // Insert or remove a row
                if (insertRemoveCount == 0)
                    return;

                if (toggleInsertRemove > 0 && (timerCount % insertRemoveModulus) == 0)
                {
                    icount = ++icount % (toggleInsertRemove * 2);
                    shouldInsert = icount <= toggleInsertRemove;

                    Console.WriteLine(m_syncGrid.RowCount);
                    if (shouldInsert)
                    {
                        for (int ri = 0; ri < insertRemoveCount; ri++)
                        {
                            int recNum = rand.Next(m_set.Count - 1);
                            int rowNum = recNum + 1;

                            // Underlying data structure (this could be a datatable or whatever structure
                            // you use behind a virtual grid).
                            // 
                            // In this case it is a ArrayList

                            int next = rand.Next(100);
                            object[] row = new object[]{"Hello world",next+1,next+2,
														   next+3,next+4,next+5,next+6,
														   next+7,next+8,next+9,next+10,
														   next+11,next+12,next+13,next+14,
														   next+15,next+16,next+17,
														   next+18,next+19,next+20};
                            m_set.Insert(recNum, row);

                            // Now that the change was done in the underlying datasource we need
                            // to tell the grid to reflect those changes:

                            m_syncGrid.Model.ResetVolatileData();

                            // Old way:
                            if (!drawDirectToDC)
                            {
                                m_syncGrid.Rows.OnRangeInserting(new GridRangeInsertingEventArgs(rowNum, 1, null));
                                m_syncGrid.Rows.OnRangeInserted(new GridRangeInsertedEventArgs(rowNum, 1, null, true));
                                m_syncGrid.Update();
                            }
                            else
                            {
                                // Optimized way: Directly calling ScrollWindows, don't let ScrollWindow call Invalidate. 

                                if (rowNum < m_syncGrid.TopRowIndex)
                                {

                                    if (!allowChangeTopRowWhenInsertBeforeView || !m_syncGrid.ViewLayout.HasPartialVisibleRows) // checks whether the last row is shown and fully visible
                                    {
                                        // in this case we need to insert at top 
                                        rowNum = m_syncGrid.TopRowIndex;
                                    }
                                    else
                                    {
                                        // If record is inserted before viewable area, simply increase
                                        // the top row so that the viewable area stays the same. No
                                        // drawing of the screen is needed.
                                        m_syncGrid.InternalSetTopRow(m_syncGrid.TopRowIndex + 1);

                                        m_syncGrid.UpdateScrollBars();
                                        rowNum = -1; // mark it as handled.

                                        if (showNumberedRowHeaders)
                                        {
                                            // Repaint only row headers - they all change
                                            Rectangle rowHeaderBounds = m_syncGrid.RangeInfoToRectangle(GridRangeInfo.Col(0));
                                            m_syncGrid.DrawClippedGrid(g, rowHeaderBounds);
                                        }

                                    }
                                }

                                if (rowNum != -1)
                                {
                                    GridRangeInfo rg = GridRangeInfo.Row(rowNum);
                                    Rectangle bounds = m_syncGrid.RangeInfoToRectangle(rg);

                                    if (!bounds.IsEmpty)
                                    {
                                        if (showNumberedRowHeaders)
                                        {
                                            // don't scroll row header area - leave it as is (only works if all rows have same height ...)
                                            bounds.X += m_syncGrid.ColWidths[0];

                                            if (!m_syncGrid.ViewLayout.HasPartialVisibleRows)
                                            {
                                                // Repaint row headers below last row
                                                Rectangle rowHeaderBounds = m_syncGrid.RangeInfoToRectangle(GridRangeInfo.Cells(m_syncGrid.RowCount, 0, m_syncGrid.RowCount, 0));
                                                m_syncGrid.DrawClippedGrid(g, rowHeaderBounds);
                                            }
                                        }

                                        // If rows can have different heights:
                                        // m_syncGrid.ViewLayout.Reset();

                                        Rectangle scrollBounds = new Rectangle(bounds.Left, bounds.Top, bounds.Right, m_syncGrid.ClientRectangle.Bottom);
                                        m_syncGrid.ScrollWindow(0, bounds.Height, scrollBounds, scrollBounds, false);  // don't cause Invalidate being called.
                                        m_syncGrid.Model.ResetVolatileData();

                                        //									System.Threading.Thread.Sleep(1000);

                                        // DrawClippedGrid method lets you simply draw the cells at the specified bounds directly to the graphics context.
                                        m_syncGrid.DrawClippedGrid(g, bounds);
                                    }

                                    m_syncGrid.UpdateScrollBars();
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int ri = 0; ri < insertRemoveCount; ri++)
                        {
                            int recNum = 5; //rand.Next(m_set.Count - 1);
                            int rowNum = recNum + 1;

                            // Underlying data structure (this could be a datatable or whatever structure
                            // you use behind a virtual grid).
                            // 
                            // In this case it is a ArrayList

                            m_set.RemoveAt(recNum);

                            // Now that the change was done in the underlying datasource we need
                            // to tell the grid to reflect those changes:

                            // Old way:
                            if (!drawDirectToDC)
                            {
                                m_syncGrid.Rows.OnRangeRemoving(new GridRangeRemovingEventArgs(rowNum, rowNum + 1));
                                GridModelInsertRangeOptions iro = new GridModelInsertRangeOptions();
                                iro.RowColSizes = new int[m_syncGrid.Rows.DefaultSize];
                                m_syncGrid.Rows.OnRangeRemoved(new GridRangeRemovedEventArgs(rowNum, rowNum + 1, iro, true));
                                m_syncGrid.Update();
                            }
                            else
                            {
                                // Optimized way: Directly calling ScrollWindows, don't let ScrollWindow call Invalidate. 

                                if (rowNum < m_syncGrid.TopRowIndex)
                                {
                                    if (!allowChangeTopRowWhenInsertBeforeView || !m_syncGrid.ViewLayout.HasPartialVisibleRows) // checks whether the last row is shown and fully visible
                                    {
                                        // in this case we need to insert at top 
                                        rowNum = m_syncGrid.TopRowIndex;
                                    }
                                    else
                                    {
                                        // If record is inserted before viewable area, simply increase
                                        // the top row so that the viewable area stays the same. No
                                        // drawing of the screen is needed.
                                        m_syncGrid.InternalSetTopRow(m_syncGrid.TopRowIndex - 1);

                                        m_syncGrid.UpdateScrollBars();
                                        if (showNumberedRowHeaders)
                                        {
                                            // Repaint only row headers - they all change
                                            Rectangle rowHeaderBounds = m_syncGrid.RangeInfoToRectangle(GridRangeInfo.Col(0));
                                            m_syncGrid.DrawClippedGrid(g, rowHeaderBounds);
                                        }
                                        rowNum = -1; // mark it as handled.
                                    }
                                }

                                if (rowNum != -1)
                                {
                                    GridRangeInfo rg = GridRangeInfo.Row(rowNum);
                                    Rectangle bounds = m_syncGrid.RangeInfoToRectangle(rg);

                                    if (!bounds.IsEmpty)
                                    {
                                        if (showNumberedRowHeaders)
                                        {
                                            // don't scroll row header area - leave it as is (only works if all rows have same height ...)
                                            bounds.X += m_syncGrid.ColWidths[0];
                                        }

                                        // If rows can have different heights:
                                        // m_syncGrid.ViewLayout.Reset();

                                        Rectangle scrollBounds = new Rectangle(bounds.Left, bounds.Top, bounds.Right, m_syncGrid.ClientRectangle.Bottom);
                                        Rectangle scrolledInViewBounds = m_syncGrid.ScrollWindow(0, -bounds.Height, scrollBounds, scrollBounds, false);  // don't cause Invalidate being called.
                                        m_syncGrid.Model.ResetVolatileData();



                                        // DrawClippedGrid method lets you simply draw the cells at the specified bounds directly to the graphics context.
                                        if (!m_syncGrid.ViewLayout.HasPartialVisibleRows)
                                        {
                                            scrolledInViewBounds = new Rectangle(0, m_syncGrid.ViewLayout.Corner.Y, bounds.Right, bounds.Height);
                                        }

                                        m_syncGrid.DrawClippedGrid(g, scrolledInViewBounds);
                                    }

                                    m_syncGrid.UpdateScrollBars();
                                }
                            }

                        }
                    }
                }
            }
            finally
            {

            }
        }
        #endregion

        #region Syncfusion Virtual Grid Overriders
        /// <summary>
        /// Used to update the values at the runtime
        /// </summary>m>
        private void m_syncGrid_QueryCellInfo(object sender, GridQueryCellInfoEventArgs e)
        {

            try
            {
                e.Handled = false;

                // Do we have a table yet? 			
                if (m_set == null)
                    return;

                // We don't care about row headers
                if (e.ColIndex == 0)
                {
                    if (!showNumberedRowHeaders)
                        e.Style.CellValue = " ";
                    return;
                }

                // Column headers
                if (e.RowIndex == 0)
                {

                    e.Handled = true;
                }

                    // Actual rows
                else if ((e.ColIndex > 0) && (e.RowIndex > 0))
                {
                    // Retrieve the cell value
                    object[] row = (object[])m_set[e.RowIndex - 1];
                    e.Style.CellValue = row[e.ColIndex - 1];
                    e.Handled = true;

                    if (e.ColIndex > 1)
                    {
                        int v = ((int)e.Style.CellValue) % colors.Length;
                        e.Style.BackColor = colors[v];
                    }
                }
            }
            catch (Exception)
            { }
        }

        #endregion

        #region QueryRowCount
        /// <summary>
        /// Set Row Count for Grid
        /// </summary>
        private void m_syncGrid_QueryRowCount(object sender, GridRowColCountEventArgs e)
        {
            if (m_set == null)
            {
                e.Count = 0;
                e.Handled = false;
                return;
            }

            e.Handled = true;
            e.Count = m_set.Count;
        }
        #endregion

        #region QueryColCount
        /// <summary>
        /// Set Col Count for the Grid
        /// </summary>
        private void m_syncGrid_QueryColCount(object sender, GridRowColCountEventArgs e)
        {
            if (m_set == null)
            {
                e.Count = 0;
                e.Handled = false;
                return;
            }
            e.Handled = true;
            e.Count = ((object[])m_set[0]).Length;
        }
        #endregion

        #region DrawCellDisplayText
        /// <summary>
        /// Display Text at runtime
        /// </summary>
        private void m_syncGrid_DrawCellDisplayText(object sender, GridDrawCellDisplayTextEventArgs e)
        {
            e.Cancel = GridGdiPaint.Instance.DrawText(e.Graphics, e.DisplayText, e.TextRectangle, e.Style);
        }
        #endregion

        #endregion

        #endregion

        #region "Designer Stuffs"

        #region Dispose
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
                if (g != null)
                    g.Dispose();
                g = null;
            }
            base.Dispose(disposing);
        }
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 656);
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trader Grid Test";
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
# if SyncfusionFramework1_1 || SyncfusionFramework2_0
            Application.EnableVisualStyles();
# endif
            Application.Run(new Form1());
        }

        #endregion
    }
}
