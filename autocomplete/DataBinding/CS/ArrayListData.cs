#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections;
using System.ComponentModel;

namespace DataBindingDemo
{
	/// <summary>
	/// Summary description for Data.
	/// </summary>
	public class ArrayListData
	{
		public ArrayListData() 
		{
		}

		public ArrayListData(int cat_Id, string cat_Name, string desc, string other)
		{
			this.cat_Id = cat_Id;
			this.cat_Name = cat_Name;
			this.desc = desc;
			this.other = other;
		}
        private int cat_Id;
        public int CategoryID
        {
            get
            {
                return this.cat_Id;
            }
            set
            {
                this.cat_Id = value;
            }
        }
		private string cat_Name;
		public string CategoryName
		{
			get
			{
				return this.cat_Name;
			}
			set
			{
				this.cat_Name = value;
			}
		}
		private string desc;
		public string Description
		{
			get
			{
				return this.desc;
			}
			set
			{
				this.desc = value;
			}
		}
		
		private string other;
		public string OtherInfo
		{
			get
			{
				return this.other;
			}
			set
			{
				this.other = value;
			}
		}
	}

    public class ProductDetails
    {
        string name;
        int id;

        public int SNo
        {
            get { return id; }
            set { id = value; }
        }
        public string ProductName
        {
            get { return name; }
            set { name = value; }
        }
        public ProductDetails(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }

    public class ParentItem
    {
        string name, supplier_name, company_name;
        int id;

        public int SNo
        {
            get { return id; }
            set { id = value; }
        }
        public string CategoryName
        {
            get { return name; }
            set { name = value; }
        }
        public string SupplierName
        {
            get { return supplier_name; }
            set { supplier_name = value; }
        }
        public string CompanyName
        {
            get { return company_name; }
            set { company_name = value; }
        }
        public ParentItem()
            : this(0, "", "", "")
        {
        }
        public ParentItem(string name)
        {
            this.name = name;
        }
        public ParentItem(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public ParentItem(int id, string name, string sname, string cname)
        {
            this.id = id;
            this.name = name;
            this.supplier_name = sname;
            this.company_name = cname;
        }
    }
}
