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

namespace VirtualGridTutorial
{
	/// <summary>
	/// Summary description for ExternalData.
	/// </summary>
	public class ExternalData
	{
		private int _rowCount;
		private int _colCount;

		private int[,] _data;
		public ExternalData(int rows, int cols)
		{
			_rowCount = rows;
			_colCount = cols;

			_data = new int[_rowCount, _colCount];

			for(int i = 0; i < RowCount; ++i)
				for(int j = 0; j < ColCount; ++j)
					_data[i,j] = 100 * i + j;
		}

		public virtual int this[int row, int col]
		{
			get{ return _data[row, col];}
			set{ _data[row, col] = value;}
		}

		public virtual int RowCount
		{
			get{return _rowCount;}
		}

		public virtual int ColCount
		{
			get{ return _colCount;}
		}
	}
}
