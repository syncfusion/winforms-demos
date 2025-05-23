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

namespace IntervalGrouping
{
    public partial class OrderInfo : INotifyPropertyChanged
    {
        private int _OrderID;

        private string _CustomerID;

        private DateTime _orderDate;

        private DateTime _ShippedDate;

        private string _ShipCountry;

        private int _freight;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderInfo"/> class.
        /// </summary>
        public OrderInfo()
        {

        }

        /// <summary>
        /// Gets or sets the order ID.
        /// </summary>
        /// <value>The order ID.</value>        

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

        [Display(Name = "Shipped Date")]
        public DateTime ShippedDate
        {
            get
            {
                return this._ShippedDate;
            }
            set
            {
                this._ShippedDate = value;
                this.OnPropertyChanged("ShippedDate");
            }
        }

        [Display(Name = "Ship Country")]
        public string ShipCountry
        {
            get
            {
                return _ShipCountry;
            }
            set
            {
                _ShipCountry = value;
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
                _freight = value;
                OnPropertyChanged("Freight");
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
