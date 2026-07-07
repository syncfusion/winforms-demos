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
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Calculate;

namespace GridDataBoundGridCalculator
{
    /// <summary>
    /// Summary description for CalcGridDataBoundGrid.
    /// </summary>
    public class CalcGridDataBoundGrid : GridDataBoundGrid, Syncfusion.Calculate.ICalcData, ISheetData
    {
        public CalcGridDataBoundGrid()
            : base()
        {
            //Avoid the complexity of sorting:
            this.SortBehavior = GridSortBehavior.None;
            this.AllowDragSelectedCols = false;
            this.ActivateCurrentCellBehavior = GridCellActivateAction.DblClickOnCell;

            //Do this to force the values to be saved when leaving cell
            //as opposed to being saved when leaving row.
            this.Binder.DirectSaveCellInfo = true;
        }

        //Used to avoid focus problem on disabled grid.
        private bool locked = false;
        public bool Locked
        {
            get { return locked; }
            set { locked = value; }
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (this.locked)
                return;
            base.OnMouseDown(e);
        }

        #region ICalcData Members

        public void WireParentObject()
        {
            //Use this event to get cell changes:
            DataTable dt = this.DataSource as DataTable;
            dt.DefaultView.ListChanged += new ListChangedEventHandler(defaultView_ListChanged);
            dt.ColumnChanged += new DataColumnChangeEventHandler(dt_ColumnChanged);

            //Avoid the complexity of new row:
            dt.DefaultView.AllowNew = false;
        }

        private int changeCol = -1;
        private void defaultView_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemChanged && changeCol > -1)
            {
                int row = e.NewIndex;
                int col = this.changeCol;

                string val = this[row + 1, col + 1].Text;
                Syncfusion.Calculate.ValueChangedEventArgs e1 = new Syncfusion.Calculate.ValueChangedEventArgs(row + 1, col + 1, val);
                ValueChanged(this, e1);
            }
        }

        private void dt_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            DataTable dt = this.DataSource as DataTable;
            this.changeCol = dt.Columns.IndexOf(e.Column);
        }

        //One based:
        public object GetValueRowCol(int row, int col)
        {
            return this[row, col].Text;
        }

        //One based:
        public void SetValueRowCol(object value, int row, int col)
        {
            DataTable dt = this.DataSource as DataTable;
            dt.Rows[row - 1][col - 1] = value;
        }

        public event Syncfusion.Calculate.ValueChangedEventHandler ValueChanged;

        #endregion

        /// <summary>
        /// Includes the different methods of ISheetData interface.
        /// </summary>
        /// <returns></returns>
        #region ISheetData Members


        public int GetFirstRow()
        {
            DataTable dt = this.DataSource as DataTable;
            return 1;
        }
        public int GetLastRow()
        {
            DataTable dt = this.DataSource as DataTable;
            return dt.Rows.Count;
        }


        public int GetRowCount()
        {
            DataTable dt = this.DataSource as DataTable;
            return dt.Rows.Count;
        }

        public int GetFirstColumn()
        {
            DataTable dt = this.DataSource as DataTable;
            return 1;
        }

        public int GetLastColumn()
        {
            DataTable dt = this.DataSource as DataTable;
            return dt.Columns.Count;
        }


        public int GetColumnCount()
        {
            DataTable dt = this.DataSource as DataTable;
            return dt.Columns.Count;
        }
        #endregion
    }
}
