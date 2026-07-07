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

namespace Syncfusion.Windows.Forms.Chart.Samples
{
	/// <summary>
	/// Summary description for Data.
	/// </summary>
	public class Data
	{
		public Data(double x,double y)
		{
			this.x = x;
			this.y = y;
		}

		private double x;
		private double y = 0;

		public double X
		{
			get
			{
				return this.x;
			}
		}

		public double Y
		{
			get
			{
				return this.y;
			}
		}
	}
}
