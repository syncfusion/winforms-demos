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

namespace AutoCellMerging
{
    public class OrderInfo : INotifyPropertyChanged
    {
        #region Private members

        private int _orderId;
        private string _customerId;
        private string _productName;
        private double _unitPrice;
        private DateTime _orderedDate;
        private TimeSpan _deliveryDelay;
        private int _contactNumber;
        private int _quantity;
        private string _shipaddress;

        #endregion

        #region Public properties

        /// <summary>
        /// Gets or sets the order ID.
        /// </summary>
        /// <value>The order ID.</value>
        [Display(Name = "Order ID", Order = 1)]
        public int OrderID
        {
            get
            {
                return _orderId;
            }
            set
            {
                _orderId = value;
                RaisePropertyChanged("OrderID");
            }
        }

        /// <summary>
        /// Gets or sets the customer ID.
        /// </summary>
        /// <value>The customer ID.</value>
        [Display(Name = "Customer ID", Order = 9)]
        public string CustomerID
        {
            get
            {
                return _customerId;
            }
            set
            {
                _customerId = value;
                RaisePropertyChanged("CustomerID");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        /// <value>The name of the product.</value>
        [Display(Name = "Product Name", Order = 3)]
        public string ProductName
        {
            get
            {
                return _productName;
            }
            set
            {
                _productName = value;
                RaisePropertyChanged("ProductName");
            }
        }

        /// <summary>
        /// Gets or sets the OrderDate.
        /// </summary>
        /// <value>The OrderDate.</value>
        [Display(Name = "Order Date", Order = 4)]
        public DateTime OrderDate
        {
            get
            {
                return _orderedDate;
            }
            set
            {
                _orderedDate = value;
                RaisePropertyChanged("OrderDate");
            }
        }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>The quantity.</value>
        [Display(Name = "Quantity", Order = 5)]
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
                RaisePropertyChanged("Quantity");
            }
        }

        /// <summary>
        /// Gets or sets the unit price.
        /// </summary>
        /// <value>The unit price.</value>
        [Display(Name = "Unit Price", Order = 6)]
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
            }
        }

        /// <summary>
        /// Gets or sets the contact number.
        /// </summary>
        /// <value>
        /// The contact number.
        /// </value>
        [Display(Name = "Contact Number", Order = 8)]
        public int ContactNumber
        {
            get
            {
                return _contactNumber;
            }
            set
            {
                _contactNumber = value;
                RaisePropertyChanged("ContactNumber");
            }
        }


        /// <summary>
        /// Gets or sets the ShipAddress.
        /// </summary>
        /// <value>
        /// The ShipAddress.
        /// </value>
        [Display(Name = "Ship Address", Order = 7)]
        public string ShipAddress
        {
            get
            {
                return _shipaddress;
            }
            set
            {
                _shipaddress = value;
                RaisePropertyChanged("ShipAddress");
            }
        }
        #endregion
    }
}
