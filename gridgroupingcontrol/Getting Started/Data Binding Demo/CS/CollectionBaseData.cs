#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections;
using System.ComponentModel;
using DataBinding;

namespace DataBinding
{
	/// <summary>
	/// Summary description for DataCollection.
	/// </summary>
	public class CollectionBaseData : System.Collections.CollectionBase
	{
		public CollectionBaseData()
		{
		}

		public void Add(Data info)
		{
			this.List.Add(info);
		}
		public void Remove(Data info)
		{
			
		}
		public Data this[int index]
		{
			get
			{
				return (Data)base.List[index];
			}
		}
	}
}




