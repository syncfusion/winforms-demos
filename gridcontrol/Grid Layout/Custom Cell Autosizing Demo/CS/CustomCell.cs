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
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.IO;

using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms;
using Syncfusion.Styles;


namespace CustomCellAutoSizing
{

	# region "CellModel Class"

	public class CustomControlCellModel : GridGenericControlCellModel
	{
		public CustomControlCellModel(GridModel grid)
			: base(grid)
		{
		}
	
		protected CustomControlCellModel(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		public override GridCellRendererBase CreateRenderer(GridControlBase control)
		{
			return new CustomControlCellRenderer(control, this);
		}
		
		//Override this method to calculate proper control size and return the same.
		protected override Size OnQueryPrefferedClientSize(Graphics g, int rowIndex, int colIndex, GridStyleInfo style, GridQueryBounds queryBounds)
		{
				if(Grid[rowIndex,colIndex].Tag == null)
					throw new Exception("No User Control is tagged");
				else
				{
					//Get the type of the control from Style.Tag
					Control userControl = Grid[rowIndex,colIndex].Tag as Control;

					//Calculate the size of the control
					Size size = userControl.Size;
					size.Height += 2;
					//return the size
					return size;
				}
		}
	}

	# endregion

	# region "Cell Renderer Class"

	public class CustomControlCellRenderer: GridGenericControlCellRenderer
	{
		CustomControlCellModel cm;
		Control activeControl;
		public CustomControlCellRenderer(GridControlBase grid, GridCellModelBase cellModel)
			: base(grid, cellModel)
		{
			cm = (CustomControlCellModel) cellModel;
				SupportsFocusControl = true;
		}
		
		#region Usual Renderer Overrides
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				activeControl.Dispose();
				activeControl = null;
				cm=null;
			}

			base.Dispose (disposing);
		}
		protected /*internal*/ override bool OnSaveChanges()
		{
			return true;
		}
	

		protected override void OnDraw(Graphics g, Rectangle clientRectangle, int rowIndex, int colIndex, GridStyleInfo style)
		{
				activeControl = Grid.Model[rowIndex,colIndex].Tag as Control;
				clientRectangle.Size = GridUtil.Max(clientRectangle.Size, activeControl.Size);
				style.Control = activeControl;				
				base.OnDraw (g, clientRectangle, rowIndex, colIndex, style);
		}
		protected override void OnInitialize(int rowIndex, int colIndex)
		{
			activeControl = Grid.Model[rowIndex,colIndex].Tag as Control;
		}

		protected override Rectangle OnLayout(int rowIndex, int colIndex, GridStyleInfo style, Rectangle innerBounds, Rectangle[] buttonsBounds)
		{
			Rectangle r = base.OnLayout (rowIndex, colIndex, style, innerBounds, buttonsBounds);
			r.Inflate(-1, -1);
			return r;
		}
		#endregion
	}

	#endregion
	
}
