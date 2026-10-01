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

namespace RefreshGrid
{
	/// <summary>
	/// Summary description for Model.
	/// </summary>
	public class Model
	{
		private int[,] data;

		public Model(int rows, int cols)
		{
			this.data = new int[rows, cols];
			Random random = new Random(DateTime.Now.Millisecond);
			for(int i = 0; i < rows; i++)
				for(int j = 0; j < cols; j++)
				{
					this.data[i,j] = random.Next(1000);
				}
		}

		public int this[int row, int col]
		{
			get
			{
				return this.data[row, col];
			}
		}

		public int Rows
		{
			get
			{
				return this.data.GetLength(0);
			}
		}

		public int Cols
		{
			get
			{
				return this.data.GetLength(1);
			}
		}
	}
}
