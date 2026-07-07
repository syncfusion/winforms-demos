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

namespace GridOneTimeOnlyQueryCellInfo
{
	public class OneTimeOnlyQueryCellInfoGridModel : GridModel
	{
		public OneTimeOnlyQueryCellInfoGridModel()
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
			this.UseGridOneTimeOnlyQueryCellInfoCache = true;

			BaseStylesMap.RegisterStandardStyles();
		}

		private bool _useGridOneTimeOnlyQueryCellInfoCache;
		
		/// <summary>
		/// Property UseGridOneTimeOnlyQueryCellInfoCache (bool)
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool UseGridOneTimeOnlyQueryCellInfoCache
		{
			get
			{
				return this._useGridOneTimeOnlyQueryCellInfoCache;
			}
			set
			{
				if (this._useGridOneTimeOnlyQueryCellInfoCache != value)
				{
					this.ResetVolatileData();

					// Replace volatile data cache with a permanent array of objects that stays in memory 
					// (but also eliminates support for QueryCellInfo and SaveCellInfo in gridModel)
					this._useGridOneTimeOnlyQueryCellInfoCache = value;
					if (value)
						VolatileData = new GridOneTimeOnlyQueryCellInfoCache(this.Model);
					else
						VolatileData = new GridVolatileData(this.Model);
				}
			}
		}
	}

	public class OneTimeOnlyQueryCellInfoGrid : GridControl
	{
		public OneTimeOnlyQueryCellInfoGrid()
			: base(new OneTimeOnlyQueryCellInfoGridModel())
		{
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new OneTimeOnlyQueryCellInfoGridModel Model
		{
			get
			{
				return (OneTimeOnlyQueryCellInfoGridModel) base.Model;
			}
			set
			{
				base.Model = value;
			}
		}
	}


}
