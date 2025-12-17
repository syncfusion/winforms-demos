#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public class ProductDetails : INotifyPropertyChanged
    {
        private int _ProductID;

        private int _SupplierID;

        private int _CategoryID;

        private string _ProductName;

        private string _EnglishName;

        private string _QuantityPerUnit;

        private decimal _UnitPrice;

        private short _UnitsInStock;

        private short _UnitsOnOrder;

        private short _ReorderLevel;

        private bool _Discontinued;

        public bool Discontinued
        {
            get
            {
                return this._Discontinued;
            }
            set
            {
                this._Discontinued = value;
                this.RaisePropertyChanged("Discontinued");
            }
        }

        public short UnitsOnOrder
        {
            get
            {
                return this._UnitsOnOrder;
            }
            set
            {
                this._UnitsOnOrder = value;
                this.RaisePropertyChanged("UnitsOnOrder");
            }
        }

        public short ReorderLevel
        {
            get
            {
                return this._ReorderLevel;
            }
            set
            {
                this._ReorderLevel = value;
                this.RaisePropertyChanged("ReorderLevel");
            }
        }

        [Display(Name = "Units In Stock")]
        public short UnitsInStock
        {
            get
            {
                return this._UnitsInStock;
            }
            set
            {
                this._UnitsInStock = value;
                this.RaisePropertyChanged("UnitsInStock");
            }
        }

        [Display(Name = "Unit Price")]
        public decimal UnitPrice
        {
            get
            {
                return this._UnitPrice;
            }
            set
            {
                this._UnitPrice = value;
                this.RaisePropertyChanged("UnitPrice");
            }
        }

        [Display(Name = "Quantity Per Unit")]
        public string QuantityPerUnit
        {
            get
            {
                return this._QuantityPerUnit;
            }
            set
            {
                this._QuantityPerUnit = value;
                this.RaisePropertyChanged("QuantityPerUnit");
            }
        }

        public string EnglishName
        {
            get
            {
                return this._EnglishName;
            }
            set
            {
                this._EnglishName = value;
                this.RaisePropertyChanged("EnglishName");
            }
        }

        [Display(Name = "Product Name")]
        public string ProductName
        {
            get
            {
                return this._ProductName;
            }
            set
            {
                this._ProductName = value;
                this.RaisePropertyChanged("ProductName");
            }
        }

        [Display(Name = "Product ID")]
        public int ProductID
        {
            get
            {
                return this._ProductID;
            }
            set
            {
                this._ProductID = value;
                this.RaisePropertyChanged("ProductID");
            }
        }

        [Display(Name = "Supplier ID")]
        public int SupplierID
        {
            get
            {
                return this._SupplierID;
            }
            set
            {
                this._SupplierID = value;
                this.RaisePropertyChanged("SupplierID");
            }
        }

        public int CategoryID
        {
            get
            {
                return this._CategoryID;
            }
            set
            {
                this._CategoryID = value;
                this.RaisePropertyChanged("CategoryID");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
