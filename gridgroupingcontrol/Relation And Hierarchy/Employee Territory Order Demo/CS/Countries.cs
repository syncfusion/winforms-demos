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

namespace EmployeeTerritoryOrder
{

	/// <summary>
	///		A strongly-typed collection of <see cref="Country"/> objects.
	/// </summary>
	[Serializable]
	public class CountriesCollection : ArrayList
	{
		public new Country this[int index]
		{
			get
			{
				return (Country) base[index];
			}
			set
			{
				base[index] = value;
			}
		}

		public static CountriesCollection CreateDefaultCollection()
		{
			CountriesCollection countries = new CountriesCollection();
			countries.Add(new Country("USA", "United States"));
			countries.Add(new Country("CA", "Canada"));
			countries.Add(new Country("UK", "United Kingdom"));

			return countries;
		}

		public override bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		public override bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

	}


	[Serializable]
	public class Country
	{
		private string _code;
		private string _name;

		public  Country()
		{
		}

		public  Country(string strCode, string strName)
		{
			this._code = strCode;
			this._name = strName;
		}

		[Browsable(true)]
		public string CountryCode
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
}
