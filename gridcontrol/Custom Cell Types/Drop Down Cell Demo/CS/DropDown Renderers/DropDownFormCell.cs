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
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Runtime.Serialization;

using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;

namespace DropDownCellDemo
{

	// The model class is mainly derived to make
	// CreateRenderer return our derived renderer class.
	// Here we add an internal member, ddForm, to hold our Form
	// that we want to show in our popup. We set this member
	// in the constructor call. We also override OnQueryPrefferedClientSize
	// to allow for the button during optimal sizing calls.

	public class DropDownFormCellModel : GridStaticCellModel
	{
		internal DropDownForm ddForm;

		protected DropDownFormCellModel(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		// sets ddForm and also reserves space for our button...
		public DropDownFormCellModel(GridModel grid, DropDownForm ddForm)
			: base(grid)
		{
			this.ddForm = ddForm;
			ButtonBarSize = new Size(14, 18);
		}
	
		//note that this method create our new derived renderer
		public override GridCellRendererBase CreateRenderer(GridControlBase control)
		{
			return new DropDownFormCellRenderer(control, this);
		}

		//used to provide optimal height and width for cell (as in grid.ColWidths.ResizeToFit calls)
		protected override Size OnQueryPrefferedClientSize(Graphics g, int rowIndex, int colIndex, GridStyleInfo style, GridQueryBounds queryBounds)
		{
			Size sz = base.OnQueryPrefferedClientSize(g, rowIndex, colIndex, style, queryBounds);

			//adjust to allow for button width
			sz.Width = sz.Width + ButtonBarSize.Width;

			return sz;
		}

	}


	// The renderer class handles the UI part of the cell
	// functionality. We use the constructor add the button,
	// cashe a reference to the cell model's form member.
	// The only method overridden is the OnButtonClicked which
	// is hit when the user clicks the button we added. In this 
	// method, we drop the form using ShowDialog. Upon return,
	// based on DialogResult, the changed values may be saved.

	public class DropDownFormCellRenderer: GridStaticCellRenderer
	{
		internal DropDownForm ddForm;

		public DropDownFormCellRenderer(GridControlBase grid, GridCellModelBase cellModel)
			: base(grid, cellModel)
		{
			this.ddForm = ((DropDownFormCellModel)this.Model).ddForm;

			this.AddButton(new GridCellComboBoxButton(this));

		}
		
		protected override void OnButtonClicked(int rowIndex, int colIndex, int button)
		{
			this.Grid.CurrentCell.MoveTo(rowIndex, colIndex);
			//Console.WriteLine("clicked ({0},{1})", rowIndex, colIndex);

			this.ddForm.SetValuesFromString(this.Grid.Model[rowIndex, colIndex].Text);
			Rectangle rect = this.Grid.RangeInfoToRectangle(GridRangeInfo.Cell(rowIndex, colIndex));

			this.ddForm.Location = this.Grid.PointToScreen(new Point(rect.Left, rect.Bottom));

			if(this.ddForm.ShowDialog() == DialogResult.OK)
			{
				this.Grid.Model[rowIndex, colIndex].Text = this.ddForm.GetValuesToString();
			}
			//base.OnButtonClicked (rowIndex, colIndex, button);
		}

		
	}
}