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
using System.Windows.Forms;

namespace Syncfusion.Windows.Forms.Chart.Samples
{
	/// <summary>
	/// This class replaces data provider (behaves like external data source).
	/// </summary>
	public class DataProvider
	{
		public Timer timer1 = new Timer();
			
		public DataProvider()
		{
			this.timer1.Enabled = false;
			this.timer1.Interval = 800;
		}
	}
}