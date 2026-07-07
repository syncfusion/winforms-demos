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
using Syncfusion.Windows.Forms.Grid;

namespace InteractiveCellDemo
{
	public class CellDragButton : GridCellButton
	{
		BrushInfo interiorBrush;
		GridRangeInfo _mouseOverRange = GridRangeInfo.Empty;
		BrushInfo savedInterior = BrushInfo.Empty;
		bool _mouseDown = false;

		public CellDragButton(GridCellRendererBase control)
			: base(control)
		{
			interiorBrush = new BrushInfo(GradientStyle.PathRectangle, Color.FromArgb( 0x3a, 0x86, 0x7e ),Color.FromArgb( 204, 212, 230 ));
		}

		public BrushInfo Interior
		{
			get
			{
				return this.interiorBrush;
			}
			set
			{
				interiorBrush = value;
			}
		}

		GridRangeInfo MouseOverRange
		{
			get
			{
				return _mouseOverRange;
			}
			set
			{
				if (!_mouseOverRange.Equals(value))
				{
					// TODO: Provide option to enable/disable undo generation
					Grid.Model.BeginInit();
					if (!_mouseOverRange.IsEmpty)
					{
						if (savedInterior.IsEmpty)
							Grid.Model[_mouseOverRange.Top, _mouseOverRange.Left].ResetInterior();
						else
							Grid.Model[_mouseOverRange.Top, _mouseOverRange.Left].Interior = savedInterior;
					}
					savedInterior = BrushInfo.Empty;
					_mouseOverRange = value;
					if (!_mouseOverRange.IsEmpty)
					{
						if (Grid.Model[_mouseOverRange.Top, _mouseOverRange.Left].HasInterior)
							savedInterior = Grid.Model[_mouseOverRange.Top, _mouseOverRange.Left].Interior;
						Grid.Model[_mouseOverRange.Top, _mouseOverRange.Left].Interior = interiorBrush;
					}
					Grid.Model.EndInit();
				}
			}
		}

		public override void MouseDown(MouseEventArgs e, GridCellHitTestInfo ht)
		{
			base.MouseDown(e, ht);
			Grid.AutoScrolling = ScrollBars.Both;
			Rectangle bounds = Grid.RangeInfoToRectangle(Grid.ScrollableGridRangeInfo);
			bounds.Intersect(Grid.GridBounds);
			Grid.AutoScrollBounds = bounds;
			_mouseDown = true;
		}

		public override void MouseMove(MouseEventArgs e, GridCellHitTestInfo ht)
		{
			if (ht.CellButtonBounds.Contains(new Point(e.X, e.Y)))
			{
				// Set_mouseDown(ht, true);
			}
			else 
			{
				// Set_mouseDown(ht, false);
				GridRangeInfo range = Grid.PointToRangeInfo(new Point(e.X, e.Y), -1);
				MouseOverRange = range;
			}
		}

		public override void MouseUp(MouseEventArgs e, GridCellHitTestInfo ht)
		{
			if (!MouseOverRange.IsEmpty)
				MessageBox.Show("You dragged onto cell " + MouseOverRange.ToString());
			else
				MessageBox.Show("Press this button and then drag over another cell " + MouseOverRange.ToString());

			base.MouseUp(e, ht);
			MouseOverRange = GridRangeInfo.Empty;
			Grid.AutoScrolling = ScrollBars.None;
			Grid.ScrollCellInView(ht.RowIndex, ht.ColIndex);
			_mouseDown = false;
		}

		public override void CancelMode(GridCellHitTestInfo ht)
		{
			base.CancelMode(ht);
			MouseOverRange = GridRangeInfo.Empty;
			Grid.AutoScrolling = ScrollBars.None;
			_mouseDown = false;
		}

		public override Cursor GetCursor(GridCellHitTestInfo ht)
		{ 
			return _mouseDown && MouseOverRange.Equals(GridRangeInfo.Cell(ht.RowIndex, ht.ColIndex))
				? Cursors.No : Cursors.Hand;
		}

	}

	[Serializable]
	public class DragButtonCellModel : GridStaticCellModel
	{
		protected DragButtonCellModel(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		public DragButtonCellModel(GridModel grid)
			: base(grid)
		{
			AllowFloating = false;
			ButtonBarSize = new Size(12*3, 12);
		}
	
		public override GridCellRendererBase CreateRenderer(GridControlBase control)
		{
			return new DragButtonCellRenderer(control, this);
		}

	}

	public class DragButtonCellRenderer: GridStaticCellRenderer
	{
		CellDragButton[] mybuttons;

		public DragButtonCellRenderer(GridControlBase grid, GridCellModelBase cellModel)
			: base(grid, cellModel)
		{
			mybuttons = new CellDragButton[3];
			for (int n = 0; n < 3; n++)
			{
				mybuttons[n] = new CellDragButton(this);
				AddButton(mybuttons[n]);
			}
			mybuttons[1].Interior = new BrushInfo(GradientStyle.PathEllipse, Color.FromArgb( 0xde, 0x64, 0x13 ), Color.White);
			mybuttons[2].Interior = new BrushInfo(PatternStyle.SmallCheckerBoard, Color.FromArgb( 255, 187, 111 ), Color.White);//.FromArgb( 0xff, 0xbf, 0x34 ));
		}
	}
	
}
