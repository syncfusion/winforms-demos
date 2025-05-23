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
using System.Diagnostics;
using System.ComponentModel;

using Syncfusion.Windows.Forms.Chart;

namespace ChartImportData
{
	/// <summary>
	/// Summary description for SimpleModel.
	/// </summary>
	public class StringIndexedModel : IChartSeriesIndexedModel
	{
		private double[] y;
		public StringIndexedModel(ChartSeries series, double[] y)
		{
			this.y = y;
		}
        public int Count 
		{ 
			get
			{
				return this.y.GetLength(0);
			}
		}
        public double[] GetY(int xIndex)
		{
			return new double[]{y[xIndex]};
		}
        public bool GetEmpty(int index)
		{
			return false;			
		}

		public event ListChangedEventHandler Changed;
	}
}
