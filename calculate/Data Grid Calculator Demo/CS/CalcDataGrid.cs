#region Copyright Syncfusion Inc. 2001 - 2006
//
//  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
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
using Syncfusion.Calculate;

namespace DataGridCalculator
{
	/// <summary>
	/// Summary description for CalcDataGrid.
	/// </summary>
	public class CalcDataGrid : DataGrid, Syncfusion.Calculate.ICalcData
	{
		public CalcDataGrid() : base()
		{
			//Avoid the complexity of sorting:
			this.AllowSorting = false;
		}

//		private CalcEngine engine = null;
//
//		public void SetEngine(CalcEngine engine)
//		{
//			if(this.engine == null)
//				this.engine = engine;
//			else
//				throw new ArgumentException("Call SetEngine only once.");
//		}
//		

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
			if(e.ListChangedType == ListChangedType.ItemChanged && changeCol > -1)
			{
				int row  = e.NewIndex;
				int col = this.changeCol;
			
				string val = this[row, col].ToString();
				Syncfusion.Calculate.ValueChangedEventArgs e1 = new Syncfusion.Calculate.ValueChangedEventArgs(row+1, col+1, val);
				ValueChanged(this, e1);
			}
		}

		private void dt_ColumnChanged(object sender, DataColumnChangeEventArgs e)
		{
			DataTable dt = this.DataSource as DataTable;
			this.changeCol = dt.Columns.IndexOf(e.Column);
			CurrencyManager cm = this.BindingContext[this.DataSource, this.DataMember] as CurrencyManager;
			if(cm != null)
			{
				cm.EndCurrentEdit();
			}
		}

		//One based:
		public object GetValueRowCol(int row, int col)
		{
			return this[row-1, col-1];
		}

		//One based:
		public void SetValueRowCol(object value, int row, int col)
		{
			DataTable dt = this.DataSource as DataTable;
			dt.Rows[row-1][col-1] = value;
		}
		
		public event Syncfusion.Calculate.ValueChangedEventHandler ValueChanged;
		#endregion

	}
}
