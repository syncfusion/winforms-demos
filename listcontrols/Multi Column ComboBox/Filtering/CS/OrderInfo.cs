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

namespace MultiColumnComboBox
{
    /// <summary>
    /// Class contains all the properties used in DataSource
    /// </summary>
    class OrderInfo : INotifyPropertyChanged
    {
        private int _OrderID;

        private DateTime _orderDate;

        private string _CustomerID;

        private double _unitPrice;

        private int _Quantity;

        private int _contactNumber;

        private string _product;

        private string _shipaddress;

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

        /// <summary>
        /// Gets or sets the customer ID.
        /// </summary>
        /// <value>The customer ID.</value>
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

        /// <summary>
        /// Gets or sets the Product.
        /// </summary>
        /// <value>The Product.</value>
        [Display(Name = "Product Name")]
        public string ProductName
        {
            get
            {
                return this._product;
            }
            set
            {
                this._product = value;
                this.OnPropertyChanged("ProductName");
            }
        }

        /// <summary>
        /// Gets or Sets the OrderDate
        /// </summary>
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
            }
        }

        /// <summary>
        /// Gets or sets quantity
        /// </summary>
        /// <value>the quantity</value>     
        public int Quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                _Quantity = value;
                OnPropertyChanged("Quantity");
            }
        }

        /// <summary>
        /// Gets or sets the unit price.
        /// </summary>
        /// <value>The unit price.</value>
        [Display(Name = "Unit Price")]
        [DataType(DataType.Currency)]
        public double UnitPrice
        {
            get
            {
                return _unitPrice;
            }
            set
            {
                _unitPrice = value;
                OnPropertyChanged("UnitPrice");
            }
        }

        /// <summary>
        /// Gets or sets quantity
        /// </summary>
        /// <value>the quantity</value>     
        [Display(Name = "Contact Number")]
        public int ContactNumber
        {
            get
            {
                return this._contactNumber;
            }
            set
            {
                _contactNumber = value;
                OnPropertyChanged("ContactNumber");
            }
        }

        /// <summary>
        /// Gets or sets the ShipAddress.
        /// </summary>
        /// <value>The ShipAddress.</value>
        [Display(Name = "Ship Country")]
        public string ShipCountry
        {
            get
            {
                return this._shipaddress;
            }
            set
            {
                this._shipaddress = value;
                this.OnPropertyChanged("ShipCountry");

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Called while property value changed
        /// </summary>
        /// <param name="propertyName">Name of the property</param>
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
