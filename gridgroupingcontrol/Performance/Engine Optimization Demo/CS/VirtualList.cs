#region Copyright Syncfusion Inc. 2001 - 2005
//
//  Copyright Syncfusion Inc. 2001 - 2005. All rights reserved.
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

namespace TestEngineOptimizations
{
	/// <summary>
	/// Summary description for VirtualList.
	/// </summary>
	public class VirtualList : IList, ITypedList
	{
		int virtualCount;

		public VirtualList(int count)
		{
			virtualCount = count;
		}

		#region IList Members

		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		public object this[int index]
		{
			get
			{
				VirtualItem item = new VirtualItem();
				item.Index = index;
				item.Name = "Name" + index.ToString("000000000");
				item.SomeValue = index*0.873332f;
				item.OtherValue = (293023033-index)/8;

				return item;
			}
			set
			{
			}
		}

		public void RemoveAt(int index)
		{
		}

		public void Insert(int index, object value)
		{
		}

		public void Remove(object value)
		{
		}

		public bool Contains(object value)
		{
			return false;
		}

		public void Clear()
		{
		}

		public int IndexOf(object value)
		{
			return 0;
		}

		public int Add(object value)
		{
			return 0;
		}

		public bool IsFixedSize
		{
			get
			{
				return true;
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
				return virtualCount;
			}
		}

		public void CopyTo(Array array, int index)
		{
		}

		public object SyncRoot
		{
			get
			{
				return null;
			}
		}

		#endregion

		#region IEnumerable Members

		public IEnumerator GetEnumerator()
		{
			return null;
		}

		#endregion

		#region ITypedList Members

		public PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors)
		{
			System.ComponentModel.PropertyDescriptorCollection pds
				= TypeDescriptor.GetProperties(typeof(VirtualItem));

			string[] atts = new string[]
			{
				"Index",
				"Name",
				"SomeValue",
				"OtherValue",
			};

			return pds.Sort(atts);
		}

		public string GetListName(PropertyDescriptor[] listAccessors)
		{
			return "VirtualList";
		}

		#endregion
	}

	[TypeConverter(typeof(VirtualItemConverter))]
	public class VirtualItem
	{
		int index;
		string name;
		double someValue;
		double otherValue;

		public int Index
		{
			get
			{
				return index;
			}
			set
			{
				index = value;
			}
		}
		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}
		public double SomeValue
		{
			get
			{
				return someValue;
			}
			set
			{
				someValue = value;
			}
		}
		public double OtherValue
		{
			get
			{
				return otherValue;
			}
			set
			{
				otherValue = value;
			}
		}

	}

	public class VirtualItemConverter : TypeConverter
	{
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			System.ComponentModel.PropertyDescriptorCollection pds
				= TypeDescriptor.GetProperties(value.GetType(), attributes);

			string[] atts = new string[]
			{
				"Index",
				"Name",
				"SomeValue",
				"OtherValue",
			};

			return pds.Sort(atts);
		}

	}
}
