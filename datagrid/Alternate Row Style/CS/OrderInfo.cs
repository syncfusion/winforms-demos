#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AlternateRowStyle
{
    public partial class OrderInfo : INotifyPropertyChanged
    {
        private int _OrderID;

        private string _CustomerID;

        private DateTime _orderDate;

        private string _shipName;

        private DateTime _shippedDate;

        private string _shipAddress;

        private string _shipCountry;

        private int _freight;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderInfo"/> class.
        /// </summary>
        public OrderInfo()
        {

        }

        [Display(Name = "Order ID")]
        public int OrderID
        {
            get
            {
                return this._OrderID;
            }
            set
            {
                this._OrderID = value;
                this.OnPropertyChanged("OrderID");
            }
        }

        [Display(Name = "Customer ID")]
        public string CustomerID
        {
            get
            {
                return this._CustomerID;
            }
            set
            {
                this._CustomerID = value;
                this.OnPropertyChanged("CustomerID");
            }
        }

        [Display(Name = "Order Date")]
        public DateTime OrderDate
        {
            get
            {
                return _orderDate;
            }
            set
            {
                _orderDate = value;
                this.OnPropertyChanged("OrderDate");
            }
        }

        [Display(Name = "Ship Name")]
        public string ShipName
        {
            get
            {
                return this._shipName;
            }
            set
            {
                this._shipName = value;
                this.OnPropertyChanged("ShipName");
            }
        }

        [Display(Name = "Shipped Date")]
        public DateTime ShippedDate
        {
            get
            {
                return this._shippedDate;
            }
            set
            {
                _shippedDate = value;
                OnPropertyChanged("ShippedDate");
            }
        }

        [Display(Name = "Ship Address")]
        public string ShipAddress
        {
            get
            {
                return _shipAddress;
            }
            set
            {
                _shipAddress = value;
                OnPropertyChanged("ShipAddress");
            }
        }

        [Display(Name = "Ship Country")]
        public string ShipCountry
        {
            get
            {
                return this._shipCountry;
            }
            set
            {
                _shipCountry = value;
                OnPropertyChanged("ShipCountry");
            }
        }

        [DataType(DataType.Currency)]
        public int Freight
        {
            get
            {
                return this._freight;
            }
            set
            {
                this._freight = value;
                this.OnPropertyChanged("Freight");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
