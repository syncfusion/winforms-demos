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

        private int _frieght;

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
                this.OnPropertyChanged("ProductName");
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
                OnPropertyChanged("UnitPrice");
            }
        }

        [DataType(DataType.Currency)]
        public int Frieght
        {
            get
            {
                return this._frieght;
            }
            set
            {
                _frieght = value;
                OnPropertyChanged("ContactNumber");
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
