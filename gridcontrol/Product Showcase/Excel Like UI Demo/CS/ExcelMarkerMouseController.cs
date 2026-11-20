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
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using Syncfusion.Diagnostics;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;

namespace ExcelLikeUI
{
	public class ExcelMarkerMouseController : IMouseController
	{
		GridControlBase grid;
		GridRangeInfo activeRange;
		int lastHitTestCode = GridHitTestContext.None;
		const int HitExcelMarker = 101;
		const int delta = 3;
		private DragWindow dragWindow;
		Cursor cursor1;

		public ExcelMarkerMouseController(GridControlBase grid)
		{
			this.grid = grid;
			this.grid.Model.Options.SelectCellsMouseButtonsMask = MouseButtons.Left;
		}

		public string Name 
		{ 
			get
			{
				return "ExcelMarker"; 
			}
		}

		public Cursor Cursor
        {
            get
            {
                if (cursor1 == null)
                {
                    System.IO.Stream stream = GetType().Module.Assembly.GetManifestResourceStream("ExcelLikeUI.cross.CUR");
                    if (stream != null)
                        cursor1 = new Cursor(stream);
                    else
                        cursor1 = Cursors.Cross;

                }
                return cursor1;
            }
        }

        public void MouseHoverEnter()
        {
        }

        public void MouseHover(MouseEventArgs e)
        {
        }
        public void MouseHoverLeave(EventArgs e)
        {
        }

        GridCurrentCell cc;
		public void MouseDown(MouseEventArgs e)
		{
			cc = this.grid.CurrentCell;
			if (e.Button == MouseButtons.Left)
			{
				if (e.Clicks == 1)
				{
					// Start automatic scrolling when user drags mouse out of window
					grid.AutoScrolling = ScrollBars.Both;

					// 
					int rowIndex, colIndex;
					Point point = new Point(e.X, e.Y);
					grid.PointToRowCol(point, out rowIndex, out colIndex);
					activeRange = grid.Selections.Ranges.ActiveRange;

					dragWindow = new DragWindow();
					dragWindow.Opacity = .2f;
                    dragWindow.BackColor = SystemColors.Highlight;
					dragWindow.Bounds = GetBounds(activeRange);
					dragWindow.ShowWindowTopMost();
					val = this.grid.CurrentCell.Renderer.ControlValue;
				}
			}
		}

		Rectangle GetBounds(GridRangeInfo range)
		{
			Rectangle bounds = grid.RangeInfoToRectangle(range, GridRangeOptions.None);
			bounds.Intersect(grid.ClientRectangle);
			bounds = grid.RectangleToScreen(bounds);
			return bounds;
		}
        
		public void MouseMove(MouseEventArgs e)
		{
			int rowIndex, colIndex;
			Point point = new Point(e.X-delta, e.Y-delta);
            try
            {
                grid.PointToRowCol(point, out rowIndex, out colIndex, 0);
                rowIndex = Math.Max(grid.TopRowIndex, rowIndex);
                colIndex = Math.Max(grid.LeftColIndex, colIndex);
                if (colIndex <= activeRange.Right && colIndex >= activeRange.Left)
                {
                    range = GridRangeInfo.Cells(activeRange.Top, activeRange.Left, rowIndex, activeRange.Right);
                }
                else if (rowIndex <= activeRange.Bottom && rowIndex >= activeRange.Top)
                {
                    range = GridRangeInfo.Cells(activeRange.Top, activeRange.Left, activeRange.Bottom, colIndex);
                }
                dragWindow.Bounds = GetBounds(range);
                dragWindow.ShowWindowTopMost();
            }
            catch
            {
            }
		}

		public void MouseUp(MouseEventArgs e)
		{
			// Stop automatic scrolling 
			grid.AutoScrolling = ScrollBars.None;

			int rowIndex, colIndex;
			Point point = new Point(e.X, e.Y);
			grid.PointToRowCol(point, out rowIndex, out colIndex);

			dragWindow.Visible = false;
			dragWindow = null;
            
			GetDraggedRangesFilled();			
		}

		GridRangeInfo range;
		object val;		
		bool flag=true;
        // Checks the value that is to be updated in the drag window is an integer value.
		bool IsNumber(string Val)
		{
			if (Val.Length<=0)
				return false;
			for(int i =0;i< Val.Length;i++)
				if(!Char.IsDigit(Val[i]))
					return false;		
			return true;
		}

        // Updates the value accordingly in the drag window.
		private void GetDraggedRangesFilled()
		{
			int v=0;
			flag= IsNumber(val.ToString());
				
			if(flag)
				v= Int32.Parse(val.ToString()); 
			if(range != null)
				for(int top = range.Top; top <= range.Bottom; top++)
					for(int left = range.Left; left <= range.Right; left++)
					{
						if(flag)
							this.grid.Model[top,left].CellValue =v++;
						else
							this.grid.Model[top,left].CellValue = val;	
					}
			this.grid.Selections.Add(GridRangeInfo.Cells(range.Top, range.Left, range.Bottom, range.Right));
		}		

		public void CancelMode()
		{
			grid.AutoScrolling = ScrollBars.None;
			dragWindow.Visible = false;
			dragWindow = null;
		}

		public int HitTest(MouseEventArgs e, IMouseController controller)
		{
			lastHitTestCode = GridHitTestContext.None;
			if (e.Button == MouseButtons.Left)
			{
				GridRangeInfo range = grid.Selections.Ranges.ActiveRange;
				if (!range.IsEmpty)
				{
					Point point = new Point(e.X, e.Y);
					point.Offset(-delta, -delta);
					int rowIndex, colIndex;
					grid.PointToRowCol(point, out rowIndex, out colIndex);

					if (rowIndex == range.Bottom && colIndex == range.Right)
					{
						point.Offset(delta*2+1, delta*2+1);
						int rowIndex2, colIndex2;
						grid.PointToRowCol(point, out rowIndex2, out colIndex2);
                        if (rowIndex2 != rowIndex && colIndex2 != colIndex)
                            lastHitTestCode = HitExcelMarker;
                    }
				}
			}
			return lastHitTestCode;
		}
	}
}