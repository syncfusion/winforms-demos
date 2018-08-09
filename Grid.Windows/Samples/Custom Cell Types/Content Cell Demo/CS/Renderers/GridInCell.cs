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

namespace ContentCellDemo
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;
	using System.Runtime.Serialization;

	using Syncfusion.Diagnostics;
	using Syncfusion.Windows.Forms;
	using Syncfusion.Windows.Forms.Grid;

	/// <summary>
	/// Summary description for GridInCell.
	/// </summary>
	public class GridInCellModel : GridGenericControlCellModel
	{
		protected GridInCellModel(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		public GridInCellModel(GridModel grid)
			: base(grid)
		{
			AllowFloating = false;
		}
	
		public override GridCellRendererBase CreateRenderer(GridControlBase control)
		{
			return new GridInCellRenderer(control, this);
		}

	}

	
	public class GridInCellRenderer: GridGenericControlCellRenderer
	{
		private CellEmbeddedGrid activeGrid;
		
		public GridInCellRenderer(GridControlBase grid, GridCellModelBase cellModel)
			: base(grid, cellModel)
		{
			this.SupportsFocusControl = true;
		}

		protected override void OnDraw(System.Drawing.Graphics g, System.Drawing.Rectangle clientRectangle, int rowIndex, int colIndex, Syncfusion.Windows.Forms.Grid.GridStyleInfo style)
		{
			if (this.ShouldDrawFocused(rowIndex, colIndex))
			{
				if (style.Control is CellEmbeddedGrid)				
					activeGrid = (CellEmbeddedGrid) style.Control;
					
				base.OnDraw(g, clientRectangle, rowIndex, colIndex, style);
			}
			else
			{
				// Draw a static grid
				if (style.Control is CellEmbeddedGrid)
				{
					CellEmbeddedGrid grid = (CellEmbeddedGrid) style.Control;
					grid.DrawGrid(g, clientRectangle, true);
				}
			}
		}

		protected override bool ProcessKeyEventArgs(ref Message m)  
		{
			TraceUtil.TraceCurrentMethodInfo(m.ToString());

			// forward keyboard events to child grid that would otherwise 
			// be handled by parent grid (right arrow, page down etc.)
			if (activeGrid != null && activeGrid.Focused)
				return activeGrid.InitiateProcessKeyEventArgs(ref m);

			return base.ProcessKeyEventArgs(ref m);
		}
	}

	public class CellEmbeddedGrid : GridControl
	{
		public CellEmbeddedGrid(GridControl parent)
		{
			this.RowHeights[0] = this.RowHeights[1];
			this.DefaultColWidth = 50;
			
			this.FloatCellsMode = GridFloatCellsMode.OnDemandCalculation;
			this.VScrollBehavior = GridScrollbarMode.Automatic;
			this.HScrollBehavior = GridScrollbarMode.Automatic;
			this.BorderStyle = BorderStyle.None;
			this.Location = new Point(-10000, -10000);
			this.ActivateCurrentCellBehavior = GridCellActivateAction.PositionCaret;
			this.ShowCurrentCellBorderBehavior = GridShowCurrentCellBorder.GrayWhenLostFocus;
			this.VerticalThumbTrack = true;
			this.HorizontalThumbTrack = true;
			this.FillSplitterPane = false;
			this.Properties.GridLineColor = System.Drawing.Color.Silver;
			this.DefaultGridBorderStyle = GridBorderStyle.Solid;
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfo(e.KeyCode);
			base.OnKeyDown(e);
		}

		internal bool InitiateProcessKeyEventArgs(ref Message m)  
		{
			return base.ProcessKeyEventArgs(ref m);
		}
	}
}
