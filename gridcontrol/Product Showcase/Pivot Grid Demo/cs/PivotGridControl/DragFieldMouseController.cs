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
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using Syncfusion.ComponentModel;
using Syncfusion.Diagnostics;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;


namespace PivotGridLibrary
{

    /// <summary>
    /// This is an abstract base class used by <see cref="GridDragColumnHeaderMouseController"/>.
    /// It implements the IMouseController interface to be used with MouseControllerDispatcher and provides common functions for 
    /// hit-testing and drag and drop functionality used by the derived class.
    /// </summary>
    public abstract class DragFieldMouseControllerBase : IMouseController, IGridFocusHelper
    {
        #region Fields
        internal GridControlBaseImp _grid;
        internal bool wasDragged = false;  // otherwise raise click event.
        internal Rectangle originBounds = Rectangle.Empty;

        private GridDragColumnHeaderHelper fieldDragHelper = null;

        internal Bitmap dragFieldBitmap = null;

        internal Point origin = Point.Empty;
        bool dragFieldVisible = false;

        internal Cursor cursor = null;
        internal int _rowIndex, _colIndex;
        internal int fieldIndex;

        Point hiddenPoint = new Point(10000, 10000);
        DragFieldHelper redArrowIndicatorDragHelper = null;

        internal const int firstGridListRowIndex = 2;
        internal const int gridListColIndex = 0;

        protected GridControlBase _dropOnGrid = null;
        internal GridClickCellsMouseController clickCellsController;
        int clickCellsControllerHitTest = 0;

        #endregion

        /// <summary>
        /// Gets the <see cref="GridClickCellsMouseController"/> which is used to forward mouse events
        /// to cell renderers.
        /// </summary>
        public GridClickCellsMouseController ClickCellsController
        {
            get
            {
                return clickCellsController;
            }
        }

        /// <summary>
        /// Clears out pending state of ClickCellsController, possibly sending MouseHoverLeave or CancelMode
        /// notification to cell renderer.
        /// </summary>
        /// <internalonly/>
        public void ResetClickCellsController()
        {
            if (this.entered)
                clickCellsController.MouseHoverLeave(EventArgs.Empty);
            else if (clickCellsControllerHitTest != 0)
                clickCellsController.CancelMode();
            entered = false;
            clickCellsControllerHitTest = 0;
        }

        /// <overload>
        /// Initializes the object
        /// </overload>
        /// <summary>
        /// Initializes the object
        /// </summary>
        public DragFieldMouseControllerBase()
        {
        }

        /// <summary>
        /// Initializes the object with the grid it is bound to.
        /// </summary>
        public DragFieldMouseControllerBase(GridControlBaseImp grid)
        {
            this._grid = grid;
        }

        /// <summary>
        /// Returns the grid it is bound to.
        /// </summary>
        /// <returns>The GridControlBase</returns>
        protected virtual GridControlBaseImp GetGridControl()
        {
            return _grid;
        }

        internal GridControlBaseImp grid
        {
            get
            {
                return GetGridControl();
            }
        }

        internal GridList Grid
        {
            get
            {
                return grid as GridList;
            }
        }

        internal GridList DropOnGrid
        {
            get { return _dropOnGrid as GridList; }
        }

        #region Helper Methods

        /// <summary>
        /// Determines based on mouse position what cursor must be shown
        /// </summary>
        /// <returns></returns>
        /// <internalonly/>
        internal int GetCursorInfo()
        {
            if (grid == null)
                return -1;
            
            Point pt = Control.MousePosition;
            pt = grid.GridPointToClient(pt);
            return grid.GridBounds.Contains(pt) ? (Grid.isFieldsGrid ? 0 : 1) : -1;
        }

        internal bool CheckMouseButtons(MouseEventArgs e)
        {
            return e.Button == MouseButtons.Left;
        }

        /// <summary>
        /// Determines based on mouse position if remove cursor should be shown
        /// </summary>
        /// <returns></returns>
        /// <internalonly/>
        public bool ShouldShowRemoveCursor()
        {
            if (grid == null)
                return false;

            Point pt = Control.MousePosition;
            pt = grid.GridPointToClient(pt);
            return !grid.GridBounds.Contains(pt);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected bool IsMouseOverOtherGridList()
        {
            //if (_dropOnGrid == null || !(_dropOnGrid is GridList) || this.grid.Equals(_dropOnGrid))
            //    return false;

            QueryCanDropFieldEventArgs e = new QueryCanDropFieldEventArgs(Control.MousePosition, Grid[fieldIndex]);
            Grid.RaiseQueryCanDropField(e);
            _dropOnGrid = e.DropOnGrid;
            if(e.CanDrop && e.DropOnGrid != null)
                return true;

            return false;
        }

        #endregion

        #region Red Arrow Indicator

        internal static bool SupportsTransparentForm()
        {
            // Check if this is 2000 (NT 5.0) or XP (NT 5.1)
            if (Environment.OSVersion.Platform != PlatformID.Win32NT
                || Environment.OSVersion.Version.Major < 5)
                return false;

            return true;
        }

        /// <summary>
        /// Determines based of GridList(!Field Grid) whether the RedArrow should open
        /// </summary>
        /// <returns></returns>
        protected bool ShouldOpenArrow(bool forceOpenRedArrow)
        {
            if (Grid.isFieldsGrid && _dropOnGrid == null)
                return false;
            if (!redArrowOpend)
            {
                if (forceOpenRedArrow)
                {
                    OpenRedArrowIndicator();
                    return false;
                }
                return true;
            }

            return false;
        }

        bool redArrowOpend = false;
        internal void OpenRedArrowIndicator()
        {
            if (!ShouldOpenArrow(false))
                return;
            redArrowOpend = true;

            Bitmap bm = CreateRedArrowIndicatorBitmap();
            redArrowIndicatorDragHelper = new DragFieldHelper();
            redArrowIndicatorDragHelper.StartDrag(bm, hiddenPoint, DragDropEffects.Move);
            // There is always a small black rectangle at the lower right-corner. Drawing
            // over the previously painted BackgroundImage resolves this issue.
            redArrowIndicatorDragHelper.DragWindow.Paint += new PaintEventHandler(DragWindow_Paint);
            if (!DragFieldMouseControllerBase.SupportsTransparentForm())
            {
                //GridRangeInfo rows = GetRangeOfColumnHeaderSection();
                int rowIndex = grid.Model.RowCount > 1 ? 2 : 0;//rows.Top;
                GridStyleInfo style = grid.Model[rowIndex, 0];
                Color backColor = Color.FromArgb(255, style.Interior.BackColor);
                redArrowIndicatorDragHelper.DragWindow.BackColor = backColor;
            }
        }

        internal void CloseRedArrowIndicator()
        {
            if (redArrowIndicatorDragHelper != null)
            {
                redArrowIndicatorDragHelper.EndDrag();
                redArrowIndicatorDragHelper.DragWindow.Paint -= new PaintEventHandler(DragWindow_Paint);
                redArrowIndicatorDragHelper = null;
            }
            redArrowOpend = false;
        }

        int colWidthOnRedArrowCreate = -1;
        int rowHeightOnRedArrowCreate = -1;

        private Bitmap CreateRedArrowIndicatorBitmap()
        {
            Bitmap bm = null;
            Graphics g = null;
            Bitmap leftBitmap = IconDrawingSupport.RedLeftBitmap;
            Bitmap rightBitmap = IconDrawingSupport.RedRightBitmap;
            GridControlBase gridForRedArrow = (Grid.isFieldsGrid && _dropOnGrid != null) ? _dropOnGrid : grid;
            colWidthOnRedArrowCreate = gridForRedArrow.GetColWidth(gridListColIndex);
            rowHeightOnRedArrowCreate = gridForRedArrow.DefaultRowHeight;// gridForRedArrow.GetRowHeight(rowIndex);

            Size size = new Size(leftBitmap.Width * 2 + colWidthOnRedArrowCreate - 1, rowHeightOnRedArrowCreate);

            Rectangle bounds = new Rectangle(Point.Empty, size);

            try
            {
                bm = new Bitmap(size.Width, size.Height);
                g = Graphics.FromImage(bm);
                g.FillRectangle(new SolidBrush(Color.Red), new Rectangle(Point.Empty, size));
                g.DrawImageUnscaled(leftBitmap, bm.Width - leftBitmap.Width, 0);
                g.DrawImageUnscaled(rightBitmap, 0, 1);
                //bm.Save(@"C:\redarrow.bmp");
            }
            finally
            {
                if (g != null)
                    g.Dispose();
            }

            bm.MakeTransparent(Color.Red);
            return bm;
        }

        private void DrawRedArrowIndicator(Graphics g)
        {
            // There is always a small black rectangle at the lower right-corner. Drawing
            // over the previously painted BackgroundImage resolves this issue.
            //GridRangeInfo rows = GetRangeOfColumnHeaderSection();
            int rowIndex = grid.Model.RowCount > 1 ? 2 : 0; //rows.Top;
            Bitmap leftBitmap = IconDrawingSupport.RedLeftBitmap;
            Bitmap rightBitmap = IconDrawingSupport.RedRightBitmap;

            Size size = new Size(leftBitmap.Width * 2 + colWidthOnRedArrowCreate - 1, rowHeightOnRedArrowCreate);
            Rectangle bounds = new Rectangle(Point.Empty, size);

            Color backColor = Color.Red;

            if (!DragFieldMouseControllerBase.SupportsTransparentForm())
            {
                GridStyleInfo style = grid.Model[rowIndex, 0];
                backColor = Color.FromArgb(255, style.Interior.BackColor);
            }

            try
            {
                g.FillRectangle(new SolidBrush(backColor), new Rectangle(Point.Empty, size));
                g.DrawImageUnscaled(leftBitmap, size.Width - leftBitmap.Width, 0);
                g.DrawImageUnscaled(rightBitmap, 0, 0);
            }
            finally
            {
            }
        }


        private void DragWindow_Paint(object sender, PaintEventArgs e)
        {
            this.DrawRedArrowIndicator(e.Graphics);
        }


        static bool firstShowRedArrowIndicator = true;

        /// <summary>
        /// Determines based on mouse position and fields if red arrow indicator should be shown
        /// </summary>
        /// <returns></returns>
        /// <internalonly/>
        public bool ShouldShowRedArrowIndicator()
        {
            if (ShouldShowRemoveCursor() || Grid.isFieldsGrid /*|| IsMouseOverOtherGridList()*/)
                return false;

            return targetRowIndex > 1 && this.fieldIndex != targetRowIndex && (this.fieldIndex + 1) != targetRowIndex;
        }

        /// <internalonly/>
        public Point GetRedArrowIndicatorLocation(int rowIndex)
        {
            if (rowIndex > 0)
            {
                Rectangle r = grid.RangeInfoToRectangle(GridRangeInfo.Cell(rowIndex, 0));
                Point pt = grid.IsRightToLeft() ? new Point(r.Right, r.Top) : r.Location;
                return grid.GridPointToScreen(pt);
            }
            return Point.Empty;
        }

        internal int redArrowFieldNum = 0;
        internal int targetRowIndex = 0;
        /// <summary>
        /// 
        /// </summary>
        protected bool dropAtRowCount = false;
        /// <internalonly/>
        public void UpdateRedArrowIndicator()
        {
            Point pt = Control.MousePosition;
            if (!IsMouseOverOtherGridList())
            {
                QueryCanDropFieldEventArgs ea = new QueryCanDropFieldEventArgs(pt, Grid[fieldIndex]);
                Grid.RaiseQueryCanDropField(ea);
                if (!ea.CanDrop)
                    goto noArrow;
            pt = grid.GridPointToClient(pt);
            GridControlBase gridWindow = grid.GetGridWindow();
            if (pt.Y < gridWindow.GridBounds.Top || pt.Y > gridWindow.GridBounds.Bottom)
            {
                goto noArrow;
            }

            targetRowIndex = grid.GetRow(grid.ViewLayout.PointToClientRow(pt, GridCellSizeKind.ActualSize));
                targetRowIndex = Math.Min(Grid.RowCount, targetRowIndex);
            if (this.ShouldShowRedArrowIndicator())
            {
                Bitmap leftBitmap = IconDrawingSupport.RedLeftBitmap;
                Bitmap rightBitmap = IconDrawingSupport.RedRightBitmap;

                Point p = Point.Empty;
                PivotGridQueryDragFieldEventArgs ae = new PivotGridQueryDragFieldEventArgs(this.grid, _rowIndex, targetRowIndex, QueryDragFieldReason.ShowRedArrowIndicator);
                //this.grid.RaiseQueryAllowDragRow(ae);
                //if (!ae.AllowDrag)
                //{
                //    pt = hiddenPoint;
                //}
                //else
                {
                    p = GetRedArrowIndicatorLocation(targetRowIndex);

                    p.X -= rightBitmap.Width;
                    p.Y -= rightBitmap.Height / 2;

                    pt = grid.GridPointToClient(p);
                }

                if (redArrowIndicatorDragHelper != null)
                {
                    if (pt.Y < gridWindow.GridBounds.Top - leftBitmap.Height / 2 || pt.Y > gridWindow.GridBounds.Bottom)
                        redArrowIndicatorDragHelper.DoDrag(hiddenPoint, DragDropEffects.Copy);
                    else
                    {
                        redArrowIndicatorDragHelper.DoDrag(p, DragDropEffects.Copy);
                        redArrowIndicatorDragHelper.DragWindow.ShowWindowTopMost();

                        // Fixes an issue with transparency that occurs occasionally when shown
                        // for the first time.
                        if (firstShowRedArrowIndicator)
                        {
                            firstShowRedArrowIndicator = false;
                            redArrowIndicatorDragHelper.DoDrag(hiddenPoint, DragDropEffects.Copy);
                            UpdateRedArrowIndicator();
                        }
                    }
                }
                return;
            }
        noArrow:
            if (redArrowIndicatorDragHelper != null)
                redArrowIndicatorDragHelper.DoDrag(hiddenPoint, DragDropEffects.Copy);
            }
            else if(!DropOnGrid.isFieldsGrid)
            {
                Bitmap leftBitmap = IconDrawingSupport.RedLeftBitmap;
                Bitmap rightBitmap = IconDrawingSupport.RedRightBitmap;

                int fieldNum;

                Rectangle screenBounds = _dropOnGrid.Parent.RectangleToScreen(_dropOnGrid.Bounds);
                if (!screenBounds.Contains(pt))
                {
                    fieldNum = _dropOnGrid.Model.RowCount;
                    dropAtRowCount = true;
                }
                else
                {
                    pt = _dropOnGrid.GridPointToClient(pt);
                    GridRangeInfo cell = _dropOnGrid.PointToRangeInfo(pt);
                    fieldNum = Math.Max(cell.Top, 1);
                    dropAtRowCount = false;
                }
                int fnum = _rowIndex;
                if (redArrowIndicatorDragHelper != null)
                {
                    if (!this.ShouldShowDragBitmap() )
                        redArrowIndicatorDragHelper.DoDrag(hiddenPoint, DragDropEffects.Copy);
                    else
                    {
                        redArrowFieldNum = fieldNum;

                        string insertBeforeField = "";
                        if (redArrowFieldNum < grid.Model.RowCount)
                        {
                            insertBeforeField = Grid[redArrowFieldNum];
                        }

                        //GridQueryAllowGroupByColumnEventArgs ae = new GridQueryAllowGroupByColumnEventArgs(this.grid, column.Name, insertBeforeColumnName, GridQueryAllowDragColumnReason.ShowRedArrowIndicator, column.AllowGroupByColumn);
                        //this.grid.RaiseQueryAllowGroupByColumn(ae);
                        //if (ae.AllowGroupByColumn)
                        {

                            int rowIndex = fieldNum;
                            Rectangle r = _dropOnGrid.RangeInfoToRectangle(GridRangeInfo.Cell(rowIndex, gridListColIndex));
                            pt = grid.IsRightToLeft() ? new Point(r.Right, r.Top) : r.Location;
                            pt = _dropOnGrid.GridPointToScreen(pt);
                            pt.X -= leftBitmap.Width;
                            pt.Y -= leftBitmap.Height / 2;
                            redArrowIndicatorDragHelper.DoDrag(pt, DragDropEffects.Copy);
                            redArrowIndicatorDragHelper.DragWindow.ShowWindowTopMost();
                        }
                    }
                }
            }
        }
        #endregion

        #region Drag Field

        internal Point GetMovementDelta()
        {
            Point pt = Control.MousePosition;
            return new Point(pt.X - origin.X, pt.Y - origin.Y);
        }

        /// <internalonly/>
        public bool ShouldShowDragBitmap()
        {
            return !originBounds.Contains(Control.MousePosition);
        }

        internal Point GetDragWindowLocation(Point srcLocation)
        {
            Point pt = Control.MousePosition;
            return new Point(srcLocation.X + pt.X - origin.X, srcLocation.Y + pt.Y - origin.Y);
        }

        /// <internalonly/>
        public bool DragFieldVisible
        {
            get
            {
                return dragFieldVisible;
            }
            set
            {
                if (dragFieldVisible != value)
                {
                    dragFieldVisible = value;
                    if (value)
                        OpenDragField();
                    else
                        CloseDragField();
                }
            }
        }

        internal void OpenDragField()
        {
            Bitmap bm;
            bm = CreateFieldBitmap(grid, _rowIndex, _colIndex);

            fieldDragHelper = new GridDragColumnHeaderHelper();
            cursor = Cursors.Default;
            fieldDragHelper.StartDrag(bm, hiddenPoint, DragDropEffects.Move);
        }

        internal void CloseDragField()
        {
            if (fieldDragHelper != null)
            {
                fieldDragHelper.EndDrag();
                fieldDragHelper = null;
            }
        }

        internal void UpdateDragField()
        {
            Point mousePos = Control.MousePosition;
            DragFieldVisible = !this.originBounds.Contains(mousePos);

            if (!DragFieldVisible)
                return;

            this.fieldDragHelper.DragWindow.WindowCursor = Cursor;
            Point pt = GetDragWindowLocation(originBounds.Location);
            this.fieldDragHelper.DoDrag(pt, DragDropEffects.Move);
        }

        private Bitmap CreateFieldBitmap(GridControlBase grid, int rowIndex, int colIndex)
        {
            string fieldName = Grid[rowIndex];
            GridStyleInfo style = new GridStyleInfo();
            style.CellIdentity = new GridStyleInfoIdentity(grid.Model[rowIndex, colIndex].CellIdentity.Data, new GridCellPos(rowIndex, colIndex), true);
            style.CellType = GridCellTypeName.Header;
            style.HorizontalAlignment = GridHorizontalAlignment.Center;
            style.VerticalAlignment = GridVerticalAlignment.Middle;
            style.WrapText = false;
            style.Trimming = StringTrimming.EllipsisCharacter;
            style.Text = fieldName;
            
            Graphics g = null;
            Size size = new Size(120, 22);
            Rectangle bounds = new Rectangle(Point.Empty, size);
            GridCellRendererBase headerCellRenderer = grid.CellRenderers[GridCellTypeName.Header];
            Bitmap bm = new Bitmap(Math.Max(1, size.Width), Math.Max(1, size.Height));

            try
            {
                g = Graphics.FromImage(bm);
                BrushPaint.FillRectangle(g, bounds, style.Interior);
                headerCellRenderer.Draw(g, bounds, rowIndex, colIndex, style);
            }
            finally
            {
                if (g != null)
                    g.Dispose();
            }

            return bm;
        }


        #endregion

        #region IGridFocusHelper Implementation

        /// <implement/>
        public virtual bool GetAllowFixFocus()
        {
            return false;
        }

        #endregion

        #region IMouseController implementation

        /// <implement/>
        public virtual string Name
        {
            get
            {
                return "PivotGridDragField";
            }
        }

        /// <implement/>
        public virtual Cursor Cursor
        {
            get
            {
                if (cursor != null)
                    return cursor;
                return clickCellsController.Cursor;
            }
        }

        bool entered = false;

        /// <implement/>
        public virtual void MouseHoverEnter()
        {
            if (clickCellsControllerHitTest != 0)
            {
                entered = true;
                clickCellsController.MouseHoverEnter();
            }
        }

        /// <implement/>
        public virtual void MouseHover(MouseEventArgs e)
        {
            if (clickCellsControllerHitTest != 0)
                clickCellsController.MouseHover(e);
        }

        /// <implement/>
        public virtual void MouseHoverLeave(EventArgs e)
        {
            if (entered)
            {
                clickCellsController.MouseHoverLeave(e);
                entered = false;
            }
        }

        /// <implement/>
        public virtual void MouseDown(MouseEventArgs e)
        {
            if (clickCellsControllerHitTest != 0)
                clickCellsController.MouseDown(e);
        }

        /// <implement/>
        public virtual void MouseMove(MouseEventArgs e)
        {
            if (clickCellsControllerHitTest != 0)
                clickCellsController.MouseMove(e);
        }

        /// <implement/>
        public virtual void MouseUp(MouseEventArgs e)
        {
            if (clickCellsControllerHitTest != 0)
                clickCellsController.MouseUp(e);
        }

        /// <implement/>
        public virtual void CancelMode()
        {
            if (clickCellsControllerHitTest != 0)
                clickCellsController.CancelMode();
        }

        /// <implement/>
        public virtual int HitTest(MouseEventArgs e, IMouseController controller)
        {
            clickCellsControllerHitTest = clickCellsController.HitTest(e, controller);
            return clickCellsControllerHitTest;
        }

        #endregion
    }

    /// <summary>
    /// Mouse controller that provides support for dragging field with in/out of 
    /// grid.
    /// </summary>
    public class DragFieldMouseController : DragFieldMouseControllerBase
    {
        DragFieldHitTestInfo hitTestInfo = null;
        GridRangeInfo _cellRange;

        /// <summary>
        /// Initializes the mouse controller with grid it operates on
        /// </summary>
        /// <param name="grid"></param>
        public DragFieldMouseController(GridControlBaseImp grid)
            : base(grid)
        {
            clickCellsController = new GridClickCellsMouseController(grid);
        }

        #region MouseController Implementation

        bool doubleClick = false;

        /// <override/>
        public override void MouseDown(MouseEventArgs e)
        {
            if (this.hitTestInfo == null)
            {
                base.MouseDown(e);
                return;
            }

            this.ResetClickCellsController();

            if (e.Clicks == 2)
            {
                int rowIndex, colIndex;
                grid.PointToRowCol(new Point(e.X, e.Y), out rowIndex, out colIndex);
                grid.RaiseCellDoubleClick(rowIndex, colIndex, e);
                doubleClick = true;
                return;
            }

            doubleClick = false;
            this.OpenDragField();
            this.OpenRedArrowIndicator();
            
            grid.PrepareViewStyleInfo += new GridPrepareViewStyleInfoEventHandler(grid_PrepareViewStyleInfo);
            grid.InvalidateRange(this._cellRange);
            grid.GetGridWindow().AutoScrolling = ScrollBars.Horizontal;
            grid.GetGridWindow().AutoScrollBounds = Rectangle.Empty;
        }

        /// <override/>
        public override void MouseMove(MouseEventArgs e)
        {
            if (this.hitTestInfo == null)
            {
                base.MouseMove(e);
                return;
            }

            this.ResetClickCellsController();
            QueryCanDropFieldEventArgs ea = new QueryCanDropFieldEventArgs(new Point(e.X, e.Y), Grid[fieldIndex]);
            Grid.RaiseQueryCanDropField(ea);
            _dropOnGrid = ea.DropOnGrid;
            ShouldOpenArrow(true);
            switch (GetCursorInfo())
            {
                case -1: //Drop not allowed
                    if (ea.CanDrop)
                        cursor = Cursors.Hand;
                    else
                        cursor = Cursors.No;
                    break;
                case 1: //Drop allowed
                        cursor = Cursors.Hand;
                    break;
                case 0: //Only drag allowed not drop
                default:
                    cursor = Cursors.Default;
                    break;
            }

            this.UpdateDragField();
            this.UpdateRedArrowIndicator();

            this.wasDragged |= DragFieldVisible;
        }

        /// <override/>
        public override void MouseUp(MouseEventArgs e)
        {
            if (this.hitTestInfo == null)
            {
                base.MouseUp(e);
                return;
            }

            this.ResetClickCellsController();

            //Set Default Cursor
            cursor = null;
            bool bv = DragFieldVisible;

            DragFieldVisible = false;
            this.CloseDragField();
            this.CloseRedArrowIndicator();

            grid.GetGridWindow().AutoScrolling = ScrollBars.None;
            grid.GetGridWindow().Capture = false;
            grid.PrepareViewStyleInfo -= new GridPrepareViewStyleInfoEventHandler(grid_PrepareViewStyleInfo);
            grid.InvalidateRange(this._cellRange);

            if (!wasDragged)
            {
                if (!doubleClick)
                    grid.RaiseCellClick(_rowIndex, _colIndex, e);
            }
            else if (bv)
            {
                int cursorInfo = GetCursorInfo();
                if (cursorInfo == 1) //between same gridlist and drag & drop is possible 
                {
                    //GridQueryDragColumnHeaderEventArgs ae = new GridQueryDragColumnHeaderEventArgs(this.grid, column, targetColIndex, GridQueryDragColumnHeaderReason.MouseUp);
                    //this.grid.RaiseQueryAllowDragColumn(ae);
                    //if (ae.AllowDrag)
                    if(ShouldShowRedArrowIndicator())
                    {
                        if (targetRowIndex > fieldIndex)
                            targetRowIndex--;

                        grid.Model.Rows.MoveRange(fieldIndex, 1, targetRowIndex);
                    }

                    Cursor.Current = Cursors.Default;
                }
                else if (cursorInfo == -1) //out of current grid bounds
                {
                    QueryCanDropFieldEventArgs ea = new QueryCanDropFieldEventArgs(new Point(e.X, e.Y), Grid[fieldIndex]);
                    Grid.RaiseQueryCanDropField(ea);
                    if (ea.CanDrop)
                    {
                        Point pt = _dropOnGrid.GridPointToClient(Control.MousePosition);
                        GridRangeInfo cell = _dropOnGrid.PointToRangeInfo(pt);
                        int dropAt = dropAtRowCount ? _dropOnGrid.Model.RowCount : Math.Max(Math.Min(cell.Top, _dropOnGrid.Model.RowCount), 2);
                        FieldDropEventArgs fdea = new FieldDropEventArgs(Grid[fieldIndex], fieldIndex, new Point(e.X, e.Y), dropAt);
                        Grid.RaiseFieldDrop(fdea);
                    }
                }
            }
        }

        /// <override/>
        public override void CancelMode()
        {
            base.CancelMode();

            if (this.hitTestInfo == null)
                return;

            cursor = null;
            DragFieldVisible = false;
            this.CloseDragField();
            this.CloseRedArrowIndicator();

            grid.GetGridWindow().AutoScrolling = ScrollBars.None;
            grid.GetGridWindow().Capture = false;
            grid.GetGridWindow().AutoScrolling = ScrollBars.None;
            grid.GetGridWindow().Capture = false;
            grid.PrepareViewStyleInfo -= new GridPrepareViewStyleInfoEventHandler(grid_PrepareViewStyleInfo);
            grid.InvalidateRange(this._cellRange);
        }

        /// <override/>
        public override int HitTest(MouseEventArgs e, IMouseController controller)
        {
            // This HitTest code has higher priority than "SelectCells"
            Point pt = new Point(e.X, e.Y);
            hitTestInfo = null;


            if (CheckMouseButtons(e)
                //&& e.Clicks < 2
                && (controller == null || controller.Name != "ResizeCells")
                )
            {
                hitTestInfo = new DragFieldHitTestInfo(grid, pt);
                if (hitTestInfo.hitTestResult == GridHitTestContext.None)
                    hitTestInfo = null;
                else if (!IsOverCheckBox(hitTestInfo.rowIndex, hitTestInfo.colIndex, e))
                {
                    this._rowIndex = hitTestInfo.rowIndex;
                    this._colIndex = hitTestInfo.colIndex;
                    this._cellRange = hitTestInfo.cellRange;
                    this.originBounds = grid.GridRectangleToScreen(grid.RangeInfoToRectangle(_cellRange));
                    this.origin = this.grid.GetGridWindow().LastMousePosition;
                    this.fieldIndex = hitTestInfo.rowIndex;
                    wasDragged = false;

                }
                else
                    hitTestInfo = null;
            }

            if (hitTestInfo != null)
            {
                base.HitTest(e, controller);
                return hitTestInfo.hitTestResult;
            }
            return 0;
        }

        bool IsOverCheckBox(int r, int c, MouseEventArgs e)
        {
            GridStyleInfo style = grid.Model[r, c];
            GridCellRendererBase renderer = grid.CellRenderers[style.CellType];
            renderer.PerformLayout(r, c, style, grid.RangeInfoToRectangle(GridRangeInfo.Cell(r, c)));
            if (renderer.RaiseHitTest(r, c, e, null) == GridHitTestContext.CheckBoxChecker)
                return true;

            return false;
        }


        internal sealed class DragFieldHitTestInfo
        {
            internal GridRangeInfo cellRange;
            internal int rowIndex;
            internal int colIndex;
            internal int hitTestResult = GridHitTestContext.None;
            internal Point point;

            internal DragFieldHitTestInfo(GridControlBase grid, Point point)
            {
                if (grid.GridBounds.Contains(point))
                {
                    cellRange = grid.PointToRangeInfo(point, -1);
                    rowIndex = cellRange.Top;
                    colIndex = cellRange.Left;
                    if (rowIndex > 1 && rowIndex < grid.Model.RowCount)
                    {
                        this.point = point;
                            hitTestResult = GridHitTestContext.Header;
                    }
                }
            }
        }

        #endregion

        #region Grid Event Handlers

        private void grid_PrepareViewStyleInfo(object sender, GridPrepareViewStyleInfoEventArgs e)
        {

            if (e.ColIndex == this._colIndex && e.RowIndex == this._rowIndex)
            {
                e.Style.CellAppearance = GridCellAppearance.Sunken;
            }
        }

        #endregion
    }


    /// <internalonly/>
    public class DragFieldHelper
    {
        // Fields
        private bool isDragging = false;
        internal DragDropEffects lastDragDropEffect = DragDropEffects.None;

        internal GridDragColumnHeaderWindow dragWindow = new GridDragColumnHeaderWindow();

        /// <internalonly/>
        public GridDragColumnHeaderWindow DragWindow
        {
            get
            {
                return dragWindow;
            }
        }

        // Constructors
        /// <internalonly/>
        public DragFieldHelper()
        {
        }

        // Methods
        /// <internalonly/>
        public void StartDrag(Bitmap bmp, Point startPoint, DragDropEffects effects)
        {
            this.StopDrag();
            this.isDragging = true;
            this.lastDragDropEffect = effects;

            this.dragWindow.DragBitmap = bmp;
            this.dragWindow.Invalidate();
            this.dragWindow.StartDrag(startPoint);
            this.CheckDragCursor(effects);
        }

        /// <internalonly/>
        protected void CheckDragCursor(DragDropEffects e)
        {
            return;
        }


        /// <internalonly/>
        protected void StopDrag()
        {
            this.isDragging = false;
            this.lastDragDropEffect = DragDropEffects.None;
            this.dragWindow.StopDrag();
        }


        /// <internalonly/>
        public void DoDrag(Point p, DragDropEffects e)
        {
            if (!this.isDragging)
                return;

            this.lastDragDropEffect = e;
            this.CheckDragCursor(e);
            this.dragWindow.MoveTo(p);
        }


        /// <internalonly/>
        public void CancelDrag()
        {
            if (!this.isDragging)
                return;

            this.StopDrag();
        }


        /// <internalonly/>
        public void EndDrag()
        {
            if (!this.isDragging)
                return;

            this.StopDrag();
        }



        // Properties
        /// <internalonly/>
        public DragDropEffects LastDragDropEffect
        {
            get
            {
                return this.lastDragDropEffect;
            }
        }

        /// <internalonly/>
        public bool IsDragging
        {
            get
            {
                return this.isDragging;
            }
        }
    }


    /// <summary>
    /// not implemented....
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void PivotGridQueryDragFieldEventHandler(object sender, PivotGridQueryDragFieldEventArgs e);

    /// <summary>
    /// not implemented...
    /// </summary>
    public sealed class PivotGridQueryDragFieldEventArgs : SyncfusionEventArgs
    {
        GridControlBase grid;
        int fieldIndex;
        bool allowDrag = true;

        private int insertBeforeField;
        private QueryDragFieldReason reason;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="fieldIndex"></param>
        /// <param name="insertBeforeField"></param>
        /// <param name="reason"></param>
        public PivotGridQueryDragFieldEventArgs(GridControlBase grid, int fieldIndex, int insertBeforeField, QueryDragFieldReason reason)
        {
            this.grid = grid;
            this.fieldIndex = fieldIndex;
            this.insertBeforeField = insertBeforeField;
            this.reason = reason;
        }

        /// <summary>
        /// 
        /// </summary>
        [TraceProperty(true)]
        public GridList Grid
        {
            get
            {
                return grid as GridList;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [TraceProperty(true)]
        public string Field
        {
            get
            {
                return Grid[fieldIndex];
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [TraceProperty(true)]
        public int InsertBeforeField
        {
            get
            {
                return this.insertBeforeField;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [TraceProperty(true)]
        public bool AllowDrag
        {
            get
            {
                return allowDrag;
            }
            set
            {
                allowDrag = value;
            }
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public enum QueryDragFieldReason
    {
        /// <summary>
        /// HitTest is occuring
        /// </summary>
        HitTest,
        /// <summary>
        /// ShowRedArrowIndicator
        /// </summary>
        ShowRedArrowIndicator,
        /// <summary>
        /// MouseDown
        /// </summary>
        MouseDown,
        /// <summary>
        /// MouseUp
        /// </summary>
        MouseUp,
        /// <summary>
        /// MouseMove
        /// </summary>
        MouseMove
    }

}