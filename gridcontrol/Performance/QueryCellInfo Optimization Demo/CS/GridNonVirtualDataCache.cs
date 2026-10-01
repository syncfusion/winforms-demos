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
using Syncfusion.Collections;
using Syncfusion.Diagnostics;

namespace GridOneTimeOnlyQueryCellInfo
{

	/// <summary>
	/// Provides a volatile data container that is optimized for non-virtual grids with
	/// a smaller number of rows where QueryCellInfo event is only
	/// wanted to be called once for a cell and not multiple times .
	/// <para/> PrepareViewStyleInfo is still supported and
	/// can be enabled/disabled with <see cref="GridControlBase.SupportsPrepareViewStyleInfo"/>
	/// </summary>
	public class GridOneTimeOnlyQueryCellInfoCache : IGridVolatileData
    {
        #region "API Definition"
        /// <summary>
		/// Specifies whether base styles (see <see cref="GridStyleInfo.BaseStyle"/> in <see cref="GridStyleInfo"/> class)
		/// should be supported.
		/// </summary>
		public static bool SupportBaseStyles = true;

		OneTimeOnlyQueryCellInfoGridModel _gridModel;
		GridStyleInfoCache _dataCache;

        #endregion

        #region GridOneTimeOnlyQueryCellInfoCache
        /// <summary>
        /// Used to get GridModel and GridStyleInfoCahe
        /// </summary>
        public GridOneTimeOnlyQueryCellInfoCache(GridModel gridModel)
		{
			_gridModel = (OneTimeOnlyQueryCellInfoGridModel) gridModel;
			_dataCache = new GridStyleInfoCache();
		}

        #endregion

        #region IGridData Members

        public GridStyleInfo this[int rowIndex, int colIndex]
		{
			get
			{
				GridStyleInfo style = _dataCache[rowIndex, colIndex];
				if (style == null)
				{
					if (rowIndex > _gridModel.Data.RowCount)
						_gridModel.Data.RowCount = this.RowCount;
					
					if (colIndex > _gridModel.Data.ColCount)
						_gridModel.Data.ColCount = this.ColCount;

					GridStyleInfoStore store = _gridModel.Data[rowIndex, colIndex];
					if (store == null)
					{
						store = new GridStyleInfoStore();
						_gridModel.Data[rowIndex, colIndex] = store;
					}
					style = new GridStyleInfo(new GridStyleInfoIdentity(this, rowIndex, colIndex), store);
					style.BeginInit();
					GC.SuppressFinalize(style.Identity);
					GridQueryCellInfoEventArgs e = new GridQueryCellInfoEventArgs(rowIndex, colIndex, style);
					this._gridModel.RaiseQueryCellInfo(e);
					_dataCache.RowCount = _gridModel.Data.RowCount;
					_dataCache.ColCount = _gridModel.Data.ColCount;
					_dataCache[rowIndex, colIndex] = e.Style;
					style.EndInit();
				}
				return style;
			}
			set
			{
				GridStyleInfo style = _dataCache[rowIndex, colIndex];
				if (!Object.ReferenceEquals(style, value))
					this[rowIndex, colIndex].ModifyStyle(value, StyleModifyType.Changes);
				_gridModel.Data[rowIndex, colIndex] = value.Store;
			}
		}

		public GridCellModelBase LookupCellModel(string id)
		{
			return _gridModel.CellModels[id];
		}

		public GridBaseStylesMap BaseStylesMap
		{
			get
			{
				return _gridModel.BaseStylesMap;
			}
		}

		public GridStyleInfo[] GetBaseStyles(GridStyleInfo styleInfo, int rowIndex, int colIndex)
		{ 
			if (SupportBaseStyles)
			  return _GetBaseStyles(styleInfo, rowIndex, colIndex);
			else
			  return _GetSimpleBaseStyles(styleInfo, rowIndex, colIndex);
		}

		GridStyleInfo[] cachedBaseStyles = null;
		GridStyleInfo[] headerBaseStyles = null;

		GridStyleInfo[] _GetBaseStyles(GridStyleInfo styleInfo, int rowIndex, int colIndex)
		{
			GridStyleInfo[] cellStyles;
			int cellStyleCount = 0;

			// Row, Column and Table style
			int headerRowCount = _gridModel.Rows.HeaderCount;
			int headerColCount = _gridModel.Cols.HeaderCount;
			if (colIndex > headerColCount && rowIndex > headerRowCount)
			{
				if (rowIndex == 0)
					cellStyles = new GridStyleInfo[] 
						{
							RowStyles[rowIndex],
							TableStyle
						};
				else if (colIndex == 0)
					cellStyles = new GridStyleInfo[] 
						{
							ColStyles[colIndex],
							TableStyle
						};
				else
					cellStyles = new GridStyleInfo[] 
						{
							RowStyles[rowIndex],
							ColStyles[colIndex],
							TableStyle
						};
				cellStyleCount = cellStyles.Length;
			}
			else if (colIndex >= 0 && rowIndex < 0 || rowIndex >= 0 && colIndex < 0)
			{
				cellStyles = new GridStyleInfo[] 
					{
						TableStyle
					};
				cellStyleCount = cellStyles.Length;
			}
			else
				cellStyles = null;

			// base style
			GridStyleInfo item = styleInfo; 
			if (styleInfo == null)
				item = this[rowIndex, colIndex];
			string baseStyleName = "";
			if (item.HasBaseStyle)
				baseStyleName = item.BaseStyle; 
			
			if (baseStyleName.Length == 0 && cellStyles != null)
			{
				foreach (GridStyleInfo si in cellStyles)
				{
					if (si.HasBaseStyle)
					{
						baseStyleName = si.BaseStyle;
						if (baseStyleName.Length > 0)
							break;
					}
				}
			}

			// row or column header
			if (baseStyleName.Length == 0)
			{
				if (rowIndex >= 0 && colIndex >= 0)
				{
					if (rowIndex <= headerRowCount && colIndex <= headerColCount)
						baseStyleName = "Header";
					else if (rowIndex <= headerRowCount)
						baseStyleName = "Column Header";
					else if (colIndex <= headerColCount)
						baseStyleName = "Row Header";
				}
			}

			// load all parent base styles (including standard style)
			int level;
			GridStyleInfo[] infoMapStyles = this.BaseStylesMap.GetBaseStylesMapStyles(baseStyleName, out level);
			
			// combine the two arrays.
			GridStyleInfo[] baseStyles = new GridStyleInfo[cellStyleCount + level];
			if (cellStyles != null)
				Array.Copy(cellStyles, 0, baseStyles, 0, cellStyleCount);
			if (infoMapStyles != null)
				Array.Copy(infoMapStyles, 0, baseStyles, cellStyleCount, level);

			// each GridStyleInfoIdentity will cache the baseStyles.
			return baseStyles;		
		}
		
		GridStyleInfo[] _GetSimpleBaseStyles(GridStyleInfo styleInfo, int rowIndex, int colIndex)
		{
			if (rowIndex < 0 || colIndex < 0)
				return null;

			else if (rowIndex == 0 || colIndex == 0)
			{
				if (headerBaseStyles == null)
				{
					int cellStyleCount = 0;

					// Row, Column and Table style
					cellStyleCount = 0;

					// base style
					string baseStyleName = "Header";

					// load all parent base styles (including standard style)
					int level;
					GridStyleInfo[] infoMapStyles = this.BaseStylesMap.GetBaseStylesMapStyles(baseStyleName, out level);
			
					// combine the two arrays.
					GridStyleInfo[] baseStyles = new GridStyleInfo[cellStyleCount + level];
					if (infoMapStyles != null)
						Array.Copy(infoMapStyles, 0, baseStyles, cellStyleCount, level);

					// each GridStyleInfoIdentity will cache the baseStyles.
					headerBaseStyles = baseStyles;		
				}
				return headerBaseStyles;
			}
			else
			{
				//return new GridStyleInfo[] { TableStyle };
				if (cachedBaseStyles == null)
				{
					GridStyleInfo[] cellStyles = new GridStyleInfo[] 
					{
						TableStyle
					};
					int cellStyleCount = 1;
					
					GridStyleInfo item = styleInfo; 
					if (styleInfo == null)
						item = this[rowIndex, colIndex];

					string baseStyleName = "";
					if (item.HasBaseStyle)
						baseStyleName = item.BaseStyle; 
			
					// load standard style
					int level;
					GridStyleInfo[] infoMapStyles = this.BaseStylesMap.GetBaseStylesMapStyles("Standard", out level);
			
					// combine the two arrays.
					GridStyleInfo[] baseStyles = new GridStyleInfo[cellStyleCount + level];
					if (cellStyles != null)
						Array.Copy(cellStyles, 0, baseStyles, 0, cellStyleCount);
					if (infoMapStyles != null)
						Array.Copy(infoMapStyles, 0, baseStyles, cellStyleCount, level);

					// each GridStyleInfoIdentity will cache the baseStyles.
					cachedBaseStyles = baseStyles;		
				}
				return cachedBaseStyles;
			}
		}

		#endregion
	
		#region IGridVolatileData Members

		public void ResetRowCount()
		{
		}

		public int ColCount
		{
			get
			{
				GridRowColCountEventArgs e = new GridRowColCountEventArgs(_gridModel.Data.ColCount);
				_gridModel.RaiseQueryColCount(e);
				return e.Count; 
			}
			set
			{
				_gridModel.Data.ColCount = value;
			}
		}

		public int RowCount
		{
			get
			{
				GridRowColCountEventArgs e = new GridRowColCountEventArgs(_gridModel.Data.RowCount);
				_gridModel.RaiseQueryRowCount(e);
				return e.Count; 
			}
			set
			{
				_gridModel.Data.RowCount = value;
			}
		}

		public bool HasRowCount
		{
			get
			{
				return true;
			}
		}

		public void Clear()
		{
			// Called from ResetVolatileData, e.g. when Insert, Remove or Sorted data
			this._dataCache.Clear();
		}

		public bool HasColCount
		{
			get
			{
				return true;
			}
		}

		public void ResetColCount()
		{
		}

		public void ResetItem(GridCellPos cell)
		{
			if (cell.RowNumber <= _dataCache.RowCount && cell.ColumnNumber <= _dataCache.ColCount)
				_dataCache[cell.RowNumber, cell.ColumnNumber] = null;
		}

		#endregion

        #region RowStyleIndexer
        /// <summary>
        /// Get/Set the Row Styles using indexer
        /// </summary>
        public class RowStylesIndexer
		{
			GridOneTimeOnlyQueryCellInfoCache _dataCacheParent;
			internal RowStylesIndexer(GridOneTimeOnlyQueryCellInfoCache _dataCache)
			{
				_dataCacheParent = _dataCache;
			}
			public GridStyleInfo this[int rowIndex]
			{
				get
				{
					return _dataCacheParent[rowIndex, -1];
				}
				set
				{
					_dataCacheParent[rowIndex, -1] = value;
				}
			}
		}

		private RowStylesIndexer _rowStyles = null;

		public RowStylesIndexer RowStyles
		{
			get
			{
				if (_rowStyles == null)
					_rowStyles = new RowStylesIndexer(this);
				return _rowStyles;
			}
		}
        #endregion

        #region ColStylesIndexer
        /// <summary>
        /// Get/Set colStyle using Indexer
        /// </summary>
        public class ColStylesIndexer
		{
			GridOneTimeOnlyQueryCellInfoCache _dataCacheParent;
			internal ColStylesIndexer(GridOneTimeOnlyQueryCellInfoCache _dataCache)
			{
				_dataCacheParent = _dataCache;
			}
			public GridStyleInfo this[int colIndex]
			{
				get
				{
					return _dataCacheParent[-1, colIndex];
				}
				set
				{
					_dataCacheParent[-1, colIndex] = value;
				}
			}
		}

        private ColStylesIndexer _colStyles = null;

		public ColStylesIndexer ColStyles
		{
			get
			{
				if (_colStyles == null)
					_colStyles = new ColStylesIndexer(this);
				return _colStyles;
			}
		}

		public GridStyleInfo TableStyle
		{
			get
			{
				return this[-1, -1];
			}
			set
			{
				this[-1, -1] = value;
			}
		}
        #endregion

        #region GridStyleInfoCache
        /// <summary>
        /// Get Cache information
        /// </summary>
        public class GridStyleInfoCache
		{
			private SFTable sfTable;
			private const int delta = 1;

			/// <summary>
			/// Initializes a new instance of the GridStyleInfoCache class.
			/// </summary>
			public GridStyleInfoCache()
			{
				sfTable = new GridRowCollection();
				sfTable.RowCount = delta+1;
				sfTable.ColCount = delta+1;
			}

			/// <summary>
			/// Resets the row and column count to zero and clears all cells.
			/// </summary>
			public virtual void Clear()
			{
				sfTable.Clear();
				sfTable.RowCount = delta+1;
				sfTable.ColCount = delta+1;
			}  
        
			/// <summary>
			/// Gets or sets the row count in the <see cref="GridStyleInfoCache"/> table.
			/// </summary>
			/// <remarks>
			/// The row count does not include headers and column styles. If you set the row count to be 2 there will
			/// be one column header, one column style and two grid rows with cells.
			/// </remarks>
			public virtual int RowCount
			{
				get
				{
					// There is a delta of two (or delta) rows because GridStyleInfoCache has 
					// one first header row (row 0) that is not counted with RowCount
					// and one column styles row (row -1) that is not counted.
					return Math.Max(0, sfTable.RowCount-delta-1);
				}
				set
				{
					sfTable.RowCount = value+delta+1;
				}
			}

			/// <summary>
			/// Gets or sets the column count in the <see cref="GridStyleInfoCache"/> table.
			/// </summary>
			/// <remarks>
			/// The column count does not include headers and row styles. If you set the column count to be 2 there will
			/// be one row header, one row style and two grid columns with cells.
			/// </remarks>
			public virtual int ColCount
			{
				get
				{
					// There is a delta of two (or delta) columns because GridStyleInfoCache has 
					// one first header column (column 0) that is not counted with ColCount
					// and one row styles column (column -1) that is not counted.
					return Math.Max(0, sfTable.ColCount-delta-1);
				}
				set
				{
					sfTable.ColCount = value+delta+1;
				}
			}

			/// <summary>
			/// Tests if the cell at the specified row and column index has been initialized.
			/// </summary>
			/// <param name="rowIndex">The row index. Can be 0 for column headers and -1 for column styles.</param>
			/// <param name="colIndex">The column index. Can be 0 for row headers and -1 for row styles.</param>
			/// <returns></returns>
			public bool Contains(int rowIndex, int colIndex)
			{
				return sfTable.Contains(rowIndex+1, colIndex+1);
			}
                
			/// <summary>
			/// The cell contents at the specified row and column index.
			/// </summary>
			/// <param name="rowIndex">The row index. Can be 0 for column headers and -1 for column styles.</param>
			/// <param name="colIndex">The column index. Can be 0 for row headers and -1 for row styles.</param>
			/// <returns>A <see cref="GridStyleInfo"/> with the specified cells _dataCache. Can be null if cell has not been intialized
			/// for the specified position.</returns>
			public GridStyleInfo this[int rowIndex, int colIndex]
			{
				get
				{
					return sfTable[rowIndex+1, colIndex+1] as GridStyleInfo;
				}
				set
				{
					sfTable[rowIndex+1, colIndex+1] = value;
				}
			}
        }
        #endregion
    }
}
