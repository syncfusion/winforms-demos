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

namespace FilterRow
{
    public class ProductDetails : INotifyPropertyChanged
    {
        #region Private fields
        private int _orderId;
        private string _customerId;
        private string _productName;
        private double _unitPrice;
        private DateTime _orderedDate;
        private string _contactNumber;
        private int _quantity;
        private string _shipaddress;
        private bool isAvailable;
        #endregion

        #region Public properties

        /// <summary>
        /// Gets or sets the order ID.
        /// </summary>
        /// <value>The order ID.</value>
        [Display(Name = "Order ID")]
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
        [Display(Name = "Customer ID")]
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

        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        /// <value>The name of the product.</value>
        [Display(Name = "Product Name")]
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
        [Display(Name = "Order Date")]
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

        [Display(Name = "Is Available")]
        public bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
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
            }
        }

        /// <summary>
        /// Gets or sets the contact number.
        /// </summary>
        /// <value>
        /// The contact number.
        /// </value>
        [Display(Name = "Contact Number")]
        public string ContactNumber
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
        [Display(Name = "Ship Address")]
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

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
