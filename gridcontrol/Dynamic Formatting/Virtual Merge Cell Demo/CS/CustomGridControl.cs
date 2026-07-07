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
using System.Drawing.Text;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Runtime.Serialization;

using Syncfusion.Diagnostics;
using Syncfusion.Drawing;
using Syncfusion.Styles;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;

namespace VirtualMergeCell
{
    /// <summary>
    /// Grid View 
    /// </summary>
    public class CustomGridControl : GridControlBaseImp
    {
        public CustomGridControl()
            : base(new CustomGridModel())
        {
        }

        bool centerTextInVisibleCellPart = false;

        /// <summary>
        /// Set this true if you want the text in the merged cells of the first few
        /// columns to be centered in visible part of the cell and not scroll with
        /// the cell if the cell is only partially visible.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool CenterTextInVisibleCellPart
        {
            get
            {
                return this.centerTextInVisibleCellPart;
            }
            set
            {
                this.centerTextInVisibleCellPart = value;
                Refresh();
            }
        }




        //bool inTopRowChanging = false;
        int savedTopRow = -1;
        bool savedTopVisible = false;
        int savedBottomRow = -1;
        bool savedBottomVisible = false;


        /// <summary>
        /// Called before rows are scrolled.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnTopRowChanging(GridRowColIndexChangingEventArgs e)
        {
            //inTopRowChanging = true;

            if (centerTextInVisibleCellPart)
            {
                savedTopRow = TopRowIndex;
                savedTopVisible = ViewLayout.IsRowVisible(savedTopRow);
                savedBottomRow = ViewLayout.LastVisibleRow;
                savedBottomVisible = !ViewLayout.HasPartialVisibleRows;
            }

            base.OnTopRowChanging(e);
        }


        /// <summary>
        /// After rows were scrolled.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnTopRowChanged(GridRowColIndexChangedEventArgs e)
        {
            base.OnTopRowChanged(e);
            //inTopRowChanging = false;

            if (centerTextInVisibleCellPart && e.Success)
            {
                int rowIndex1 = TopRowIndex - 1;
                bool visRow1 = false;//ViewLayout.IsRowVisible(rowIndex1) && savedTopVisible;

                int rowIndex2 = savedBottomRow;
                bool visRow2 = !ViewLayout.HasPartialVisibleRows;

                int clientCols = ViewLayout.VisibleCols;

                if (!visRow1 || !visRow2)
                {
                    GridRangeInfoList ranges = new GridRangeInfoList();

                    for (int n = 0; n < clientCols; n++)
                    {
                        int colIndex = GetCol(n);
                        GridRangeInfo mergeRange;

                        if (!visRow1)
                        {
                            int r = Math.Max(rowIndex1, savedTopRow);
                            if (Model.MergeCells.Find(GridMergeCellDirection.RowsInColumn,
                                r, colIndex, out mergeRange)
                                && !ranges.Contains(mergeRange))
                            {
                                if (mergeRange.Bottom >= TopRowIndex)
                                {
                                    // found a merged range that is only partially visible and this
                                    // needs to be fully repainted (since we do want to center text
                                    // within the visible boundaries of the cell only and not scroll
                                    // centered text out of view).
                                    Update();
                                    RefreshRange(mergeRange);
                                    ranges.Add(mergeRange);
                                }

                            }
                        }
                        if (!visRow2)
                        {
                            if (Model.MergeCells.Find(GridMergeCellDirection.RowsInColumn,
                                rowIndex2, colIndex, out mergeRange)
                                && !ranges.Contains(mergeRange))
                            {
                                if (mergeRange.Top <= rowIndex2)
                                {
                                    // found a merged range that is only partially visible and this
                                    // needs to be fully repainted (since we do want to center text
                                    // within the visible boundaries of the cell only and not scroll
                                    // centered text out of view).
                                    Update();
                                    RefreshRange(mergeRange);
                                }

                            }
                        }
                    }
                }
            }
        }

    }

    [Serializable]
    public class CustomCellModel : GridStaticCellModel
    {
        public CustomCellModel(GridModel grid)
            : base(grid)
        {
            this.AllowMerging = true;
        }

        protected CustomCellModel(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        /// <override/>
        public override GridCellRendererBase CreateRenderer(GridControlBase grid)
        {
            return new CustomCellRenderer(grid, this);
        }
    }

    public class CustomCellRenderer : GridStaticCellRenderer
    {
        public CustomCellRenderer(GridControlBase grid, GridCellModelBase cellModel)
            : base(grid, cellModel)
        {
        }

        /// <override/>
        protected override void OnDraw(Graphics g, Rectangle clientRectangle, int rowIndex, int colIndex, GridStyleInfo style)
        {

            if (clientRectangle.IsEmpty)
                return;

            CustomGridControl grid = this.Grid as CustomGridControl;
            if (grid != null && grid.CenterTextInVisibleCellPart && colIndex < 3 && rowIndex > 0)
            {
                Rectangle bounds = clientRectangle;
                bounds.Intersect(grid.ViewLayout.RangeInfoToRectangle(GridRangeInfo.Cells(grid.TopRowIndex, 0, grid.ViewLayout.LastVisibleRow, grid.ViewLayout.LastVisibleCol), true, GridCellSizeKind.VisibleSize));
                bounds.Intersect(grid.ClientRectangle);

                string displayText = String.Empty;

                Rectangle textRectangle = RemoveMargins(bounds, style);
                if (textRectangle.IsEmpty)
                    return;

                displayText = style.Text;

                if (displayText.Length > 0)
                {
                    Font font = style.GdipFont;
                    Color textColor = Grid.PrintingMode && Grid.Model.Properties.BlackWhite ? Color.Black : style.TextColor;
                    DrawText(g, displayText, font, textRectangle, style, textColor, false);
                }
                return;
            }
            base.OnDraw(g, clientRectangle, rowIndex, colIndex, style);
        }
    }

    /// <summary>
    /// Grid Model
    /// </summary>
    public class CustomGridModel : GridModel
    {
        public CustomGridModel()
        {
            // Initial dimension
            RowCount = 1000;
            ColCount = 13;

            // initial row and column sizes
            Rows.DefaultSize = 18;
            Cols.DefaultSize = 70;

            Properties.GridLineColor = System.Drawing.Color.FromArgb(208, 215, 229);
            RowHeights[0] = 21;
            ColWidths[0] = 35;
            RowHeights.ResetModified();
            ColWidths.ResetModified();

            // fixed columns
            Cols.HeaderCount = 1;
            Cols.FrozenCount = 2;

            // standard base styles
            BaseStylesMap.RegisterStandardStyles();

            GridStyleInfo standardStyle = BaseStylesMap["Standard"].StyleInfo;
            standardStyle.MergeCell = GridMergeCellDirection.RowsInColumn;

            GridStyleInfo rowHeaderStyle = BaseStylesMap["Row Header"].StyleInfo;
            //rowHeaderStyle.CellType = "Static";
            rowHeaderStyle.MergeCell = GridMergeCellDirection.RowsInColumn;

            BaseStylesMap.Modified = false;

            CellModels.Add("CustomCell", new CustomCellModel(this));

            // Other options
            Options.MergeCellsMode = GridMergeCellsMode.OnDemandCalculation | GridMergeCellsMode.MergeRowsInColumn;
            Options.SmoothControlResize = false;

            // At the momemnt the Excel-like selection feature is broken when using merge cells.
            Options.ExcelLikeCurrentCell = false;
            Options.ExcelLikeSelectionFrame = false;
            Options.GridVisualStyles = GridVisualStyles.Office2007Blue;
            Options.DefaultGridBorderStyle = GridBorderStyle.Solid;

        }

        /// <summary>
        /// Provide cell types on demand
        /// </summary>
        /// <param name="e"></param>
        protected override void OnQueryCellModel(GridQueryCellModelEventArgs e)
        {
            base.OnQueryCellModel(e);

            if (e.CellModel == null)
            {
                IGridCellModelFactory pGridCellObjectFactory = GridFactoryProvider.CellModelFactory;

                if (pGridCellObjectFactory != null)
                    e.CellModel = pGridCellObjectFactory.CreateCellModel(e.CellType, this);
            }
        }


        public bool CanMergeCells(GridStyleInfo style1, GridStyleInfo style2)
        {
            GridStyleInfoIdentity id1 = style1.CellIdentity;
            GridStyleInfoIdentity id2 = style2.CellIdentity;

            if (id1.RowIndex < 1 || id2.RowIndex < 1)
                return false;

            //			if (id1.ColIndex > 0 && id2.ColIndex > 0
            //				&& !CanMergeCells(this[id1.RowIndex, id1.ColIndex-1], this[id2.RowIndex, id2.ColIndex-1]))
            //				return false;

            return style1.Text != "" && style1.Text == style2.Text;
        }

        /// <summary>
        /// Here you can can compare cells if they meet the criteria for 
        /// automatic merging. You could also consider neighbouring columns
        /// as part of the criteria if necessary.
        /// </summary>
        /// <param name="style1"></param>
        /// <param name="style2"></param>
        /// <returns></returns>
        protected override void OnQueryCanMergeCells(GridQueryCanMergeCellsEventArgs e)
        {
            base.OnQueryCanMergeCells(e);

            if (!e.Handled)
            {
                GridStyleInfoIdentity id1 = e.Style1.CellIdentity;
                GridStyleInfoIdentity id2 = e.Style2.CellIdentity;

                if (id1.ColIndex <= 3)
                {
                    e.Result = CanMergeCells(e.Style1, e.Style2);
                    e.Handled = true;
                }
                // for other cells (Col 4 and higher) we just do default handling 
            }
        }

        /// <summary>
        /// First 3 columns are filled virtually - changes are ignored. The other columns
        /// are saved and loaded from GridData object.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnQueryCellInfo(GridQueryCellInfoEventArgs e)
        {
            base.OnQueryCellInfo(e);

            if (!e.Handled)
            {
                if (e.ColIndex >= 0 && e.RowIndex > 0)
                {
                    if (e.ColIndex < 3)
                    {
                        int part = (4 - e.ColIndex) * 5 ^ 2;
                        int num = e.RowIndex / part;
                        e.Style.CellValue = num;
                        e.Style.CellType = "CustomCell";
                        e.Style.CellAppearance = GridCellAppearance.Raised;
                        e.Handled = true;
                    }
                    else if (e.ColIndex == 3)
                    {
                        e.Style.CellValue = e.RowIndex / 30;
                        e.Handled = true;
                    }
                }
            }
        }
    }
}
