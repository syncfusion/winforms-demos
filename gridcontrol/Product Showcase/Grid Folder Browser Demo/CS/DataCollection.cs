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
using System.Collections;
using System.ComponentModel;
using System.Data;
using Syncfusion.Diagnostics;


namespace FolderBrowser
{
	/// <summary>
	/// Summary description for DataCollection.
	/// </summary>
	public class DataCollection : IBindingList
	{
		private ArrayList list;

		public DataCollection()
		{
			list = new ArrayList();
		}

		public SampleData this[int index]
		{
			get
			{
				return (SampleData)list[index];
			}
			set
			{
				list[index] = value;
			}
		}

		#region IBindingList Members

		public void AddIndex(PropertyDescriptor property)
		{
		}

		public bool AllowNew
		{
			get
			{
				return true;
			}
		}

		public void ApplySort(PropertyDescriptor property, System.ComponentModel.ListSortDirection direction)
		{
		}

		public PropertyDescriptor SortProperty
		{
			get
			{
				return null;
			}
		}

		public int Find(PropertyDescriptor property, object key)
		{
			return 0;
		}

		public bool SupportsSorting
		{
			get
			{
				return false;
			}
		}

		public bool IsSorted
		{
			get
			{
				return false;
			}
		}

		public bool AllowRemove
		{
			get
			{
				return false;
			}
		}

		public bool SupportsSearching
		{
			get
			{
				return false;
			}
		}

		public System.ComponentModel.ListSortDirection SortDirection
		{
			get
			{
				return new System.ComponentModel.ListSortDirection ();
			}
		}
		public event System.ComponentModel.ListChangedEventHandler ListChanged;


		public bool SupportsChangeNotification
		{
			get
			{
				return false;
			}
		}

        void OnListChanged(ListChangedEventArgs e)
        {
            if (ListChanged != null)
                ListChanged(this, e);
        }
		public void RemoveSort()
		{
		}

		public object AddNew()
		{
			SampleData info = new SampleData();
			this.list.Add(info);
			return info;
		}

		public bool AllowEdit
		{
			get
			{
				return true;
			}
		}

		public void RemoveIndex(PropertyDescriptor property)
		{
		}

		#endregion

		#region IList Members

		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		object IList.this[int index]
		{
			get
			{
				return list[index];
			}
			set
			{
				list[index] = value;
			}
		}

		public void RemoveAt(int index)
		{
		}

		public void Insert(int index, object value)
		{
			list.Insert(index, value);
		}

		
		void IList.RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		void IList.Insert(int index, object value)
		{
			list.Insert(index, value);
		}

		public void Remove(object value)
		{
			list.Remove(value);
		}

		public bool Contains(object value)
		{
			return list.Contains(value);
		}

		public void Clear()
		{
			list.Clear();
		}

		public int IndexOf(object value)
		{
			return list.IndexOf(value);
		}

		public int Add(object value)
		{
			return list.Add(value);
		}

		public bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		#endregion

		#region ICollection Members

		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		public int Count
		{
			get
			{
				return list.Count;
			}
		}

		public void CopyTo(Array array, int index)
		{
			list.CopyTo(array, index);
		}

		public object SyncRoot
		{
			get
			{
				return list.SyncRoot;
			}
		}

		#endregion

		#region IEnumerable Members

		public IEnumerator GetEnumerator()
		{
			return list.GetEnumerator();
		}

		#endregion
	}
}
