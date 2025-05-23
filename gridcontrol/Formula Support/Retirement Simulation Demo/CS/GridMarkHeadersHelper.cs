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
using System.Drawing;
using System.Windows.Forms;

using Syncfusion.Windows.Forms.Grid;

namespace RetirementSimulation
{
    /// <summary>
    /// Summary description for GridMarkHeadersHelper.
    /// </summary>
    public class GridMarkHeadersHelper : IDisposable
    {
        #region "API Definition"

        private GridControlBase grid;
        private Color mColor = Color.Orange;
        private ContextMenu menu;
        private ArrayList hookGrids = new ArrayList();

        #endregion

        #region "Properties"
        /// <summary>
        /// base color used to mark header cells and current row
        /// </summary>
        public Color MarkColor
        {
            get { return mColor; }
            set { mColor = value; }
        }

        public ContextMenu ContextMenu
        {
            get { return menu; }
            set { menu = value; }
        }

        #endregion

        #region "Constructor"
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="grid">The GridControl or GridDataBoundGrid object being used.</param>
        public GridMarkHeadersHelper(GridControlBase grid)
        {
            this.grid = grid;

            this.menu = new ContextMenu();

            this.menu.MenuItems.Add("Named Range Editor", new EventHandler(namedRangeEditor_Click));


            this.grid.CurrentCellMoved += new GridCurrentCellMovedEventHandler(grid_CurrentCellMoved);
            this.grid.MouseDown += new MouseEventHandler(grid_MouseDown);

            this.grid.Model.Options.SelectCellsMouseButtonsMask = MouseButtons.Left;

        }

        #endregion 

        #region "Events"

        public void RegisterGridForContextMenu(GridControlBase grid)
        {
            grid.MouseDown += new MouseEventHandler(grid_MouseDown);
            hookGrids.Add(grid);
        }

        private void grid_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.menu.Show(sender as GridControlBase, new Point(e.X, e.Y));
            }
        }


        private void namedRangeEditor_Click(object sender, EventArgs e)
        {
            GridFormulaEngine engine = ((GridFormulaCellModel)grid.Model.CellModels["FormulaCell"]).Engine;
            GridFormulaNamedRangesEditerHelper.ShowNamedRangesDialog(engine);
        }

        private void grid_CurrentCellMoved(object sender, GridCurrentCellMovedEventArgs e)
        {
            GridCurrentCell cc = this.grid.CurrentCell;
            this.grid.RefreshRange(GridRangeInfo.Cell(0, cc.MoveFromColIndex));
            this.grid.RefreshRange(GridRangeInfo.Cell(0, cc.MoveToColIndex));
            this.grid.RefreshRange(GridRangeInfo.Row(cc.MoveToRowIndex));
            this.grid.RefreshRange(GridRangeInfo.Row(cc.MoveFromRowIndex));
        }
        #endregion

        #region "Dispose"
        /// <summary>
        /// call to unsubscribe to grid events used in this helper class
        /// </summary>
        public void Dispose()
        {
            if (!grid.IsDisposed)
            {
                this.grid.CurrentCellMoved -= new GridCurrentCellMovedEventHandler(grid_CurrentCellMoved);
                this.grid.MouseDown -= new MouseEventHandler(grid_MouseDown);
                foreach (GridControlBase g in hookGrids)
                    g.MouseDown -= new MouseEventHandler(grid_MouseDown);
            }
        }
        #endregion
    }
}
