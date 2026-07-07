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
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.Runtime.Serialization;

using Syncfusion.Diagnostics;

using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;

namespace DropDownCellDemo
{
	/// <summary>
	/// Summary description for DropDownGridCell.
	/// </summary>
	public class DropDownGridCellModel
		: GridDropDownGridCellModel
	{
		private GridControlBase _embbeddedGrid;

		public GridControlBase EmbeddedGrid
		{
			get
			{ 
				if(_embbeddedGrid == null)
					_embbeddedGrid = new GridControlBaseImp();
				return _embbeddedGrid;
			}
			set
			{
				_embbeddedGrid = value;
			}
		}

		protected DropDownGridCellModel(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		public DropDownGridCellModel(GridModel grid)
			: base(grid)
		{
				
		}
	
		public override GridCellRendererBase CreateRenderer(GridControlBase control)
		{
			return new DropDownGridCellRenderer(control, this);
		}
	}

	public class DropDownGridCellRenderer: GridDropDownGridCellRenderer 
	{
		GridControlBase grid;
		
		public DropDownGridCellRenderer(GridControlBase grid, GridCellModelBase cellModel)
			: base(grid, cellModel)
		{
			this.DisableTextBox = true;
			DropDownButton = new GridCellComboBoxButton(this);
			this.grid = null;		
		}

		protected override void OnInitialize(int rowIndex, int colIndex)
		{
			this.grid  = ((DropDownGridCellModel)this.Model).EmbeddedGrid;
			this.grid.Dock = DockStyle.Fill;			
			base.OnInitialize(rowIndex, colIndex);
		}

		protected override void InitializeDropDownContainer()
		{
			base.InitializeDropDownContainer();

			//this.DropDownContainer.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			this.DropDownContainer.IgnoreDialogKey = true;
		}

		protected override Control CreateInnerControl(out GridControlBase grid)
		{
			grid = this.grid;
			grid.Dock = DockStyle.Fill;
			grid.CausesValidation = false;
	
			return grid;
		}


	}

}
