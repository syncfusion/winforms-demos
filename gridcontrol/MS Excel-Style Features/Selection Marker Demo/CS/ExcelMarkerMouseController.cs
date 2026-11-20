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
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;

namespace ExcelMarker
{

	/// <summary>
	/// Summary description for ExcelMarkerMouseController.
	/// </summary>
	public class ExcelMarkerMouseController : IMouseController
    {
        #region "API Definition"

        GridControlBase owner;
		GridRangeInfo activeRange;
		int lastHitTestCode = GridHitTestContext.None;
		const int HitExcelMarker = 101;
		const int delta = 3;
		private DragWindow dragWindow;
		Cursor cursor1;

        #endregion

        #region Constructor
        public ExcelMarkerMouseController(GridControlBase owner)
		{
			this.owner = owner;
		}
        #endregion

        #region Properties

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
					System.IO.Stream stream = GetType().Module.Assembly.GetManifestResourceStream("ExcelMarker.cross.CUR");
					if (stream != null)
						cursor1 = new Cursor(stream);
					else
						cursor1 = Cursors.Cross;

				}
				// could check latestHitTestCode here if this controller has
				// different HitTest states. Cursor will only be called if 
				// previous call to HitTest was successfull.
				return cursor1;
			}
		}

        #endregion

        #region IMouseController Members

        public void MouseHoverEnter()
		{
		}

		/// <summary>
		/// User is moving the mouse over the hot-test area
		/// </summary>
		/// <param name="e"></param>
		public void MouseHover(MouseEventArgs e)
		{
		}

		/// <summary>
		/// Called when the hovering ends, either when user has moved mouse away from hittest area
		/// or when the user has pressed a mouse button.
		/// </summary>
		public void MouseHoverLeave(EventArgs e)
		{
		}

		public void MouseDown(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (e.Clicks == 1)
				{
					// Start automatic scrolling when user drags mouse out of window
					owner.AutoScrolling = ScrollBars.Both;

					// 
					int rowIndex, colIndex;
					Point point = new Point(e.X, e.Y);
					owner.PointToRowCol(point, out rowIndex, out colIndex);
					activeRange = owner.Selections.Ranges.ActiveRange;

					dragWindow = new DragWindow();
					dragWindow.Opacity = .4f;
					dragWindow.BackColor = SystemColors.Menu;
					dragWindow.Bounds = GetBounds(activeRange);
					dragWindow.ShowWindowTopMost();
				}
			}
			
		}

		Rectangle GetBounds(GridRangeInfo range)
		{
			Rectangle bounds = owner.RangeInfoToRectangle(range, GridRangeOptions.None);
			bounds.Intersect(owner.ClientRectangle);
			bounds = owner.RectangleToScreen(bounds);
			return bounds;
		}

		/// <summary>
		/// User has dragged mouse. If mouse is down, set current position.
		/// </summary>
		/// <param name="e"></param>
		public void MouseMove(MouseEventArgs e)
		{
			// Set current position
			int rowIndex, colIndex;
			Point point = new Point(e.X-delta, e.Y-delta);
			try
			{
				owner.PointToRowCol(point, out rowIndex, out colIndex, 0);
				rowIndex = Math.Max(owner.TopRowIndex, rowIndex);
				colIndex = Math.Max(owner.LeftColIndex, colIndex);
				GridRangeInfo range = GridRangeInfo.Cells(activeRange.Top, activeRange.Left, rowIndex, colIndex);
				dragWindow.Bounds = GetBounds(range);
				dragWindow.ShowWindowTopMost();
			}
			catch
			{
			}
		}

		/// <summary>
		/// User has release mouse button. Stop automatic scrolling.
		/// </summary>
		/// <param name="e"></param>
		public void MouseUp(MouseEventArgs e)
		{
			// Stop automatic scrolling 
			owner.AutoScrolling = ScrollBars.None;

			int rowIndex, colIndex;
			Point point = new Point(e.X, e.Y);
			owner.PointToRowCol(point, out rowIndex, out colIndex);

			dragWindow.Visible = false;
			dragWindow = null;

			GridRangeInfo range = GridRangeInfo.Cells(activeRange.Top, activeRange.Left, rowIndex, colIndex);
			MessageBox.Show(owner.Selections.Ranges.ActiveRange.ToString() + " expanded to " +range.ToString());
		}

		public void CancelMode()
		{
			owner.AutoScrolling = ScrollBars.None;
			dragWindow.Visible = false;
			dragWindow = null;
		}

		public int HitTest(MouseEventArgs e, IMouseController controller)
		{
			lastHitTestCode = GridHitTestContext.None;

			// Our vote has higher priority than other controllers
			if (e.Button == MouseButtons.Left
				
				)
			{
				GridRangeInfo range = owner.Selections.Ranges.ActiveRange;
				if (!range.IsEmpty)
				{
					Point point = new Point(e.X, e.Y);
					point.Offset(-delta, -delta);
					int rowIndex, colIndex;
					owner.PointToRowCol(point, out rowIndex, out colIndex);

					if (rowIndex == range.Bottom && colIndex == range.Right)
					{
						point.Offset(delta*2+1, delta*2+1);
						int rowIndex2, colIndex2;
						owner.PointToRowCol(point, out rowIndex2, out colIndex2);
						if (rowIndex2 != rowIndex && colIndex2 != colIndex)
							lastHitTestCode = HitExcelMarker;
					}
				}
			}
			return lastHitTestCode;
        }
        #endregion
    }
}