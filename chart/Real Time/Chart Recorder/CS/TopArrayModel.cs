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
using System.Data;
using System.Windows.Forms;
using System.Collections;

using Syncfusion.Windows.Forms.Chart;

namespace Syncfusion.Windows.Forms.Chart.Samples
{	
	/// <summary>
	/// Summary description for SimpleModel.
	/// </summary>
	public class TopArrayModel : IChartSeriesModel
	{
		private ArrayList xdata = new ArrayList();
		private ArrayList ydata = new ArrayList();

		private int topCount;

		public TopArrayModel()
		{
		}

		public int Count 
		{ 
			get
			{
				try
				{
					int count = 0;
					if(topCount > 0)
						count = Math.Min(topCount, this.xdata.Count);
					else
						count = this.xdata.Count;
					return count;
				}
				catch(Exception e)
				{
					Console.WriteLine(e.Message);
				}

				return 0;
			}
		}
		
		public int TopCount 
		{ 
			get
			{
				return topCount;
			}

			set
			{
				topCount = value;
			}
		}

		public double[] GetY(int index)
		{
			int topIndex =0;
			try
			{
				if(topCount == 0)
					topIndex = index;
				else
                    topIndex = Math.Max(0,this.xdata.Count - topCount + index -1);
				return (double[])ydata[topIndex];
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message + " " + topIndex.ToString() + " " +  this.xdata.Count.ToString());
			}

			return new double[]{0};
		}

		public double GetX(int index)
		{
			int topIndex = 0;
			try
			{
				if(topCount == 0)
					topIndex = index;
				else
					topIndex = Math.Max(0,this.xdata.Count - topCount + index -1);
				return (double) xdata[topIndex];
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message + " " + topIndex.ToString() + " " +  this.xdata.Count.ToString());
			}

			return 0;
		}

		public void RaiseListChanged()
		{
			if(this.Changed != null)
				this.Changed(this,new ListChangedEventArgs(ListChangedType.Reset,-1));
		}

		public void AddXY(double xval, double[] yvalues)
		{
			xdata.Add(xval);
			ydata.Add(yvalues);
			this.RaiseListChanged();
		}

		public bool GetEmpty(int index)
		{
			return false;
		}

		public event ListChangedEventHandler Changed;
	}
}