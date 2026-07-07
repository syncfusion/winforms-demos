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
using Syncfusion.Windows.Forms;


namespace InteractiveCellDemo
{
	public class LinkLabelCellModel : GridStaticCellModel
	{
		protected LinkLabelCellModel(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		public LinkLabelCellModel(GridModel grid)
			: base(grid)
		{
			AllowFloating = false;
		}
	
		public override GridCellRendererBase CreateRenderer(GridControlBase control)
		{
			return new LinkLabelCellRenderer(control, this);
		}

	}

	
	public class LinkLabelCellRenderer: GridStaticCellRenderer
	{
		private bool _isMouseDown;
		private bool _drawHotLink;
		private Color _hotColor;
		private Color _visitedColor;
		private string _EXEname;
	
		public LinkLabelCellRenderer(GridControlBase grid, GridCellModelBase cellModel)
			: base(grid, cellModel)
		{
			_isMouseDown = false;
			_drawHotLink = false;
			
			_hotColor = Color.Red;
			_visitedColor = Color.Purple;

			_EXEname = "iexplore.exe";
		}

		public Color VisitedLinkColor
		{
			get{return _visitedColor;}
			set{_visitedColor = value;}
		}

		public Color ActiveLinkColor
		{
			get{return _hotColor;}
			set{_hotColor = value;}
		}

		public string EXEname
		{
			get{return _EXEname;}
			set{_EXEname = value;}
		}

		protected virtual void LaunchBrowser(GridStyleInfo style)
		{
			try
			{
				System.Diagnostics.Process process = new System.Diagnostics.Process();
				process.StartInfo.FileName = EXEname;
				process.StartInfo.Arguments = (string) style.Tag;
				process.Start();
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error: " + ex.ToString());
			}

		}

		private void DrawLink(bool useHotColor, int rowIndex, int colIndex)
		{
			if(useHotColor)
				_drawHotLink = true;

			this.Grid.RefreshRange(GridRangeInfo.Cell(rowIndex, colIndex), GridRangeOptions.None);

			_drawHotLink = false;
		}

		protected override void OnMouseDown(int rowIndex, int colIndex, System.Windows.Forms.MouseEventArgs e)
		{
			base.OnMouseDown(rowIndex, colIndex, e);
			DrawLink(true, rowIndex, colIndex);
			_isMouseDown = true;
		}

		protected override void OnMouseUp(int rowIndex, int colIndex, System.Windows.Forms.MouseEventArgs e)
		{
			base.OnMouseUp(rowIndex, colIndex, e);
			int row, col;
			this.Grid.PointToRowCol(new Point(e.X, e.Y), out row, out col);
			if(row == rowIndex && col == colIndex)
			{
				GridStyleInfo style = this.Grid.Model[row, col];
				LaunchBrowser(style);
				style.TextColor = VisitedLinkColor;
			}
			DrawLink(false, rowIndex, colIndex);
			_isMouseDown = false;
		}

		protected override void OnCancelMode(int rowIndex, int colIndex)
		{
			base.OnCancelMode(rowIndex, colIndex);
			_isMouseDown = false;
			_drawHotLink = false;
		}

		protected override System.Windows.Forms.Cursor OnGetCursor(int rowIndex, int colIndex)
		{
			//if over cell, return HandPointerCursor otherwise NoCursor...
			Point pt = this.Grid.PointToClient(Cursor.Position);
			int row, col;
			this.Grid.PointToRowCol(pt, out row, out col);

			return (row == rowIndex && col == colIndex ) ? Cursors.Hand : (this._isMouseDown) ? Cursors.No : base.OnGetCursor(rowIndex, colIndex);
		}

		protected override int OnHitTest(int rowIndex, int colIndex, MouseEventArgs e, IMouseController controller)
		{
			//return a nonzero so the mouse messages will be forwarded to the cell render
			//but don't include the cell borders so D&D can be handled
			if (controller != null && controller.Name == "OleDataSource")
				// other controllers have higher priority than me
				return 0;

			return 1;
            
		}

		protected override void OnDraw(System.Drawing.Graphics g, System.Drawing.Rectangle clientRectangle, int rowIndex, int colIndex, Syncfusion.Windows.Forms.Grid.GridStyleInfo style)
		{
			style.Font.Underline = true;
			
			if(_drawHotLink)
			{
				style.TextColor = ActiveLinkColor;
			}
			base.OnDraw(g, clientRectangle, rowIndex, colIndex, style);

		}

		protected override void OnMouseHoverEnter(int rowIndex, int colIndex)
		{
			base.OnMouseHoverEnter(rowIndex, colIndex);
			DrawLink(true, rowIndex, colIndex);
		}

		protected override void OnMouseHoverLeave(int rowIndex, int colIndex, System.EventArgs e)
		{
			base.OnMouseHoverLeave(rowIndex, colIndex, e);
			DrawLink(false, rowIndex, colIndex);
		}

	}
	
}
