#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.ComponentModel;

using Syncfusion.Windows.Forms.Chart;


namespace ChartLegendSample
{
	/// <summary>
	/// Summary description for ArrayModel.
	/// </summary>
	public class LabelModel : IChartAxisLabelModel
	{
		private string[] labels;

		public LabelModel(string[] labels)
		{
			this.labels = labels;
		}

		public ChartAxisLabel GetLabelAt(int index)
		{
			return new ChartAxisLabel(this.labels[index]);
		}

		public int Count 
		{
			get
			{
				return this.labels.GetLength(0);
			}
		}
	}
	
	/// <summary>
	/// Summary description for SimpleModel.
	/// </summary>
	public class ArrayModel : IChartSeriesIndexedModel
	{
		private double[] data;

		public ArrayModel(double[] data)
		{
			this.data = data;
		}

		public int Count 
		{ 
			get
			{
				return this.data.GetLength(0);
			}
		}
		
		public double[] GetY(int xIndex)
		{
			return new double[]{data[xIndex]};
		}

		public bool GetEmpty(int index)
		{
			return false;
		}

		public event ListChangedEventHandler Changed;
	}
}
