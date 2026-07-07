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
using System.Windows.Forms;
using System.Data;
using System.Threading;

using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Styles;
using Syncfusion.Drawing;
using Syncfusion.ComponentModel;

namespace RefreshGrid
{
	public class PerformanceGridModel : GridModel
	{
		public PerformanceGridModel()
		{
			CommandStack.Enabled = false;
			Rows.DefaultSize = 17;
			Cols.DefaultSize = 65;
			RowHeights[0] = 21;
			ColWidths[0] = 35;
			RowHeights.ResetModified();
			ColWidths.ResetModified();
			Options.ExcelLikeCurrentCell = false;
			Options.ExcelLikeSelectionFrame = false;
			Options.AllowDragSelectedCols = false;
			Options.AllowDragSelectedRows = false;
			CommandStack.Enabled = false;
			Options.FloatCellsMode = GridFloatCellsMode.None;

			BaseStylesMap.RegisterStandardStyles();
		}

		private bool _useGridNonVirtualDataCache;
		
		/// <summary>
		/// Property UseGridNonVirtualDataCache (bool)
		/// </summary>
		public bool UseGridNonVirtualDataCache
		{
			get
			{
				return this._useGridNonVirtualDataCache;
			}
			set
			{
				if (this._useGridNonVirtualDataCache != value)
				{
					this.ResetVolatileData();

					// Replace volatile data cache with a permanent array of objects that stays in memory 
					// (but also eliminates support for QueryCellInfo and SaveCellInfo in gridModel)
					this._useGridNonVirtualDataCache = value;
					if (value)
						VolatileData = new GridNonVirtualDataCache(this.Model);
					else
						VolatileData = new GridVolatileData(this.Model);
				}
			}
		}
	}

	public class PerformanceGrid : GridControl
	{
		public PerformanceGrid()
			: base(new PerformanceGridModel())
		{
			UseGDI = true;
			UseDoubleBuffer = false;
			Model.UseGridNonVirtualDataCache = true;
			this.OptimizeDrawBackground = true;
			this.OptimizeInsertRemoveCells = true;
			this.SupportsPrepareViewStyleInfo = false;

			bool drawBorder = true;
			if (drawBorder)
			{
				Model.TableStyle.Borders.Right = new GridBorder(GridBorderStyle.Solid, SystemColors.Control, GridBorderWeight.Thin);
				Model.TableStyle.Borders.Bottom = new GridBorder(GridBorderStyle.Solid, SystemColors.Control, GridBorderWeight.Thin);
				// Use solid line - faster than dotted line
			}			
			else
				// No border at all is of course faster.
				Model.TableStyle.Borders.All = GridBorder.Empty;

		}

		public new PerformanceGridModel Model
		{
			get
			{
				return (PerformanceGridModel) base.Model;
			}
			set
			{
				base.Model = value;
			}
		}

		private bool _useGDI;
		
		/// <summary>
		/// Property UseGDI (bool)
		/// </summary>
		public bool UseGDI
		{
			get
			{
				return this._useGDI;
			}
			set
			{
				if (this._useGDI != value)
				{
					this._useGDI = value;
					Invalidate();
				}
			}
		}

		private bool _useDoubleBuffer = true;
		
		/// <summary>
		/// Property UseDoubleBuffer (bool)
		/// </summary>
		public bool UseDoubleBuffer
		{
			get
			{
				return this._useDoubleBuffer;
			}
			set
			{
				if (this._useDoubleBuffer != value)
				{
					this._useDoubleBuffer = value;
				}
			}
		}

		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
			if (UseDoubleBuffer)
				base.OnPaintBackground (pevent);
		}

		protected override void OnDrawCellDisplayText(GridDrawCellDisplayTextEventArgs e)
		{
			base.OnDrawCellDisplayText (e);

			if (!UseGDI || e.Cancel)
				return;

			e.Cancel = GridGdiPaint.Instance.DrawText(e.Graphics, e.DisplayText, e.TextRectangle, e.Style);
		}

		protected override void OnFillRectangleHook(GridFillRectangleHookEventArgs e)
		{
			base.OnFillRectangleHook (e);

			if (!UseGDI || e.Cancel)
				return;

			e.Cancel = GridGdiPaint.Instance.FillRectangle(e.Graphics, e.Bounds, e.Brush);
		}


	}


}
