#region Copyright Syncfusion Inc. 2001 - 2015.
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

namespace EmployeeTerritoryOrder
{

	/// <summary>
	///		A strongly-typed read-only collection of <see cref="USState"/> objects using 
	///		ITypedList implementation and a custom "Description" PropertyDescriptor 
	///		that returns state in format "NC - North Carolina"
	/// </summary>
	[Serializable]
	public class USStatesCollection : ArrayList, ITypedList
	{
		public new USState this[int index]
		{
			get
			{
				return (USState) base[index];
			}
			set
			{
				base[index] = value;
			}
		}

        //Adding values to the collection 
		public static USStatesCollection CreateDefaultCollection()
		{
			USStatesCollection states = new USStatesCollection();
			states.Add(new USState("AL", "Alabama"));
			states.Add(new USState("AK", "Alaska"));
			states.Add(new USState("AZ", "Arizona"));
			states.Add(new USState("AR", "Arkansas"));
			states.Add(new USState("CA", "California"));
			states.Add(new USState("CO", "Colorado"));
			states.Add(new USState("CT", "Connecticut"));
			states.Add(new USState("DC", "D.C."));
			states.Add(new USState("DE", "Delaware"));
			states.Add(new USState("FL", "Florida"));
			states.Add(new USState("GA", "Georgia"));
			states.Add(new USState("HI", "Hawaii"));
			states.Add(new USState("ID", "Idaho"));
			states.Add(new USState("IL", "Illinois"));
			states.Add(new USState("IN", "Indiana"));
			states.Add(new USState("IA", "Iowa"));
			states.Add(new USState("KS", "Kansas"));
			states.Add(new USState("KY", "Kentucky"));
			states.Add(new USState("LA", "Louisiana"));
			states.Add(new USState("ME", "Maine"));
			states.Add(new USState("MD", "Maryland"));
			states.Add(new USState("MA", "Massachusetts"));
			states.Add(new USState("MI", "Michigan"));
			states.Add(new USState("MN", "Minnesota"));
			states.Add(new USState("MS", "Mississippi"));
			states.Add(new USState("MO", "Missouri"));
			states.Add(new USState("MT", "Montana"));
			states.Add(new USState("NE", "Nebraska"));
			states.Add(new USState("NV", "Nevada"));
			states.Add(new USState("NH", "New Hampshire"));
			states.Add(new USState("NJ", "New Jersey"));
			states.Add(new USState("NM", "New Mexico"));
			states.Add(new USState("NY", "New York"));
			states.Add(new USState("NC", "North Carolina"));
			states.Add(new USState("ND", "North Dakota"));
			states.Add(new USState("OH", "Ohio"));
			states.Add(new USState("OK", "Oklahoma"));
			states.Add(new USState("OR", "Oregon"));
			states.Add(new USState("PA", "Pennsylvania"));
			states.Add(new USState("RI", "Rhode Island"));
			states.Add(new USState("SC", "South Carolina"));
			states.Add(new USState("SD", "South Dakota"));
			states.Add(new USState("TN", "Tennessee"));
			states.Add(new USState("TX", "Texas"));
			states.Add(new USState("UT", "Utah"));
			states.Add(new USState("VT", "Vermont"));
			states.Add(new USState("VA", "Virginia"));
			states.Add(new USState("WA", "Washington"));
			states.Add(new USState("WV", "West Virginia"));
			states.Add(new USState("WI", "Wisconsin"));
			states.Add(new USState("WY", "Wyoming"));
			states.Add(new USState("BC", "British Columbia"));
			states.Add(new USState("MB", "Manitoba"));
			states.Add(new USState("NB", "New Brunswick"));
			states.Add(new USState("NL", "Newfoundland and Labrador"));
			states.Add(new USState("NT", "Northwest Territories"));
			states.Add(new USState("NS", "Nova Scotia"));
			states.Add(new USState("NU", "Nunavut"));
			states.Add(new USState("ON", "Ontario"));
			states.Add(new USState("PE", "Prince Edward Island"));
			states.Add(new USState("QC", "Quebec"));
			states.Add(new USState("SK", "Saskatchewan"));
			states.Add(new USState("YT", "Yukon Territories"));

			return states;
		}

		public override bool IsReadOnly
		{
			get
			{
				// when both IsReadOnly and IsFixedSize return true the collection 
				// is not editable and no pencil will show up in foreign key dropdown list
				return true;   
			}
		}

		public override bool IsFixedSize
		{
			get
			{
				return true;
			}
		}

		#region ITypedList Members

		public PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors)
		{
			ArrayList al = new ArrayList();
			PropertyDescriptorCollection pdc = TypeDescriptor.GetProperties(typeof(USState));
			al.AddRange(pdc);
			al.Add(new USStatePropertyDescriptor("Description"));

			return new PropertyDescriptorCollection(((PropertyDescriptor[]) al.ToArray(typeof(PropertyDescriptor))));
		}

		public string GetListName(PropertyDescriptor[] listAccessors)
		{
			return "USStates";
		}

		#endregion
	}


	[Serializable]
	public class USState
	{
		private string _code;
		private string _name;

		public  USState()
		{
		}

		public  USState(string key, string name)
		{
			this._code = key;
			this._name = name;
		}

		[Browsable(true)]
		public string Key
		{
			get
			{
				return _code;
			}
			set
			{
				_code = value;
			}
		}

		[Browsable(true)]
		public string Name
		{
      
			get
			{
				return _name ;
			}
			set
			{
				_name = value;
			}
		}

		public override string ToString()
		{
			return this._name + "(" + this._code + ")";
		}
	}


	/// <summary>
	/// Readonly property descriptor. Returns state in format "NC - North Carolina"
	/// </summary>
	public class USStatePropertyDescriptor : PropertyDescriptor
	{
		public USStatePropertyDescriptor(string name)
			: base(name, null)
		{
		}

		/// <override/>
		public override bool ShouldSerializeValue(object component)
		{
			return false;
		}


		/// <override/>
		public override void SetValue(object component, object value)
		{
		}


		/// <override/>
		public override void ResetValue(object component)
		{
		}


		/// <override/>
		public override object GetValue(object component)
		{
			USState state = (USState) component;
			return String.Format(state.Key + " - " + state.Name);
		}


		/// <override/>
		public override bool CanResetValue(object component)
		{
			return false;
		}


		/// <override/>
		public override Type PropertyType
		{
			get
			{
				return typeof(string);
			}
		}

		/// <override/>
		public override bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		/// <override/>
		public override Type ComponentType
		{
			get
			{
				return typeof(USState);
			}
		}

		/// <override/>
		public override bool IsBrowsable
		{
			get
			{
				return true;
			}
		}

		/// <override/>
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}


		/// <override/>
		public override bool Equals(object other)
		{
			if ((other is USStatePropertyDescriptor))
			{
				return ((USStatePropertyDescriptor) other).Name == this.Name;
			}
			return false;
		}

	}
}
