#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;

namespace OutlookDemo
{
	/// <summary>
	/// Summary description for CustomSizeComparer.
	/// </summary>
	public class CustomSizeComparer : System.Collections.IComparer
	{
		public int Compare(object x, object y)
		{
			if (x == null)
				return -1;
			else if (y == null)
				return GetCategory(double.MaxValue);
			else
			{
				return GetCategory((double)x) - GetCategory((double)y);
			}
		}
		public static int GetCategory(double d)
		{
			if(d<10240)
				return 1;
			else if(d<25600)
				return 2;
			else if(d<102400)
				return 3;
			else if(d<512000)
				return 4;
			else if(d<1048576)
				return 5;
			else if(d<5242880)
				return 6;
			else 
				return 7;
		}
	}

	
	public class CustomDateComparer : System.Collections.IComparer
	{
		public int Compare(object x, object y)
		{
			if (x == null)
				return -1;
			else if (y == null)
				return (int)x;
			else
			{
				return (int)x - (int)y;
			}
		}
	}
}
