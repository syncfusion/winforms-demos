using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxColumn
{
    public static class CountryDetailsRepository
    {
        public static Dictionary<string, ObservableCollection<ShipCityDetails>> GetShipCities()
        {
            ObservableCollection<ShipCityDetails> argentina = new ObservableCollection<ShipCityDetails>();
            argentina.Add(new ShipCityDetails() { ShipCityName = "Bergamo", ShipCityID = 101 });
            argentina.Add(new ShipCityDetails() { ShipCityName = "Graz", ShipCityID = 102 });
            argentina.Add(new ShipCityDetails() { ShipCityName = "Campinas", ShipCityID = 103 });
            argentina.Add(new ShipCityDetails() { ShipCityName = "Montréal", ShipCityID = 104 });
            argentina.Add(new ShipCityDetails() { ShipCityName = "Buenos Aires", ShipCityID = 105 });

            ObservableCollection<ShipCityDetails> austria = new ObservableCollection<ShipCityDetails>();
            austria.Add(new ShipCityDetails() { ShipCityName = "austriaAachen", ShipCityID = 106 });
            austria.Add(new ShipCityDetails() { ShipCityName = "Cork", ShipCityID = 107 });
            austria.Add(new ShipCityDetails() { ShipCityName = "Århus", ShipCityID = 108 });
            austria.Add(new ShipCityDetails() { ShipCityName = "Montréal", ShipCityID = 109 });
            austria.Add(new ShipCityDetails() { ShipCityName = "Graz", ShipCityID = 110 });

            ObservableCollection<ShipCityDetails> belgium = new ObservableCollection<ShipCityDetails>();
            belgium.Add(new ShipCityDetails() { ShipCityName = "Bruxelles", ShipCityID = 111 });
            belgium.Add(new ShipCityDetails() { ShipCityName = "Campinas", ShipCityID = 112 });
            belgium.Add(new ShipCityDetails() { ShipCityName = "Lille", ShipCityID = 113 });
            belgium.Add(new ShipCityDetails() { ShipCityName = "Bergamo", ShipCityID = 114 });

            ObservableCollection<ShipCityDetails> brazil = new ObservableCollection<ShipCityDetails>();
            brazil.Add(new ShipCityDetails() { ShipCityName = "Montréal", ShipCityID = 115 });
            brazil.Add(new ShipCityDetails() { ShipCityName = "Aachen", ShipCityID = 116 });
            brazil.Add(new ShipCityDetails() { ShipCityName = "Graz", ShipCityID = 117 });
            brazil.Add(new ShipCityDetails() { ShipCityName = "Bergamo", ShipCityID = 118 });
            brazil.Add(new ShipCityDetails() { ShipCityName = "Campinas", ShipCityID = 119 });

            ObservableCollection<ShipCityDetails> canada = new ObservableCollection<ShipCityDetails>();
            canada.Add(new ShipCityDetails() { ShipCityName = "Montréal", ShipCityID = 120 });
            canada.Add(new ShipCityDetails() { ShipCityName = "Århus", ShipCityID = 121 });
            canada.Add(new ShipCityDetails() { ShipCityName = "Bergamo", ShipCityID = 122 });
            canada.Add(new ShipCityDetails() { ShipCityName = "Lille", ShipCityID = 123 });
            canada.Add(new ShipCityDetails() { ShipCityName = "Montréal", ShipCityID = 124 });

            ObservableCollection<ShipCityDetails> denmark = new ObservableCollection<ShipCityDetails>();
            denmark.Add(new ShipCityDetails() { ShipCityName = "Campinas", ShipCityID = 125 });
            denmark.Add(new ShipCityDetails() { ShipCityName = "Bruxelles", ShipCityID = 126 });
            denmark.Add(new ShipCityDetails() { ShipCityName = "Bergamo", ShipCityID = 127 });
            denmark.Add(new ShipCityDetails() { ShipCityName = "Graz", ShipCityID = 128 });
            denmark.Add(new ShipCityDetails() { ShipCityName = "Århus", ShipCityID = 129 });

            ObservableCollection<ShipCityDetails> finland = new ObservableCollection<ShipCityDetails>();
            finland.Add(new ShipCityDetails() { ShipCityName = "Bruxelles", ShipCityID = 130 });
            finland.Add(new ShipCityDetails() { ShipCityName = "Montréal", ShipCityID = 131 });
            finland.Add(new ShipCityDetails() { ShipCityName = "Cork", ShipCityID = 132 });
            finland.Add(new ShipCityDetails() { ShipCityName = "Helsinki", ShipCityID = 133 });

            ObservableCollection<ShipCityDetails> italy = new ObservableCollection<ShipCityDetails>();
            italy.Add(new ShipCityDetails() { ShipCityName = "Bruxelles", ShipCityID = 134 });
            italy.Add(new ShipCityDetails() { ShipCityName = "Montréal", ShipCityID = 135 });
            italy.Add(new ShipCityDetails() { ShipCityName = "Cork", ShipCityID = 136 });
            italy.Add(new ShipCityDetails() { ShipCityName = "Helsinki", ShipCityID = 137 });

            ObservableCollection<ShipCityDetails> us = new ObservableCollection<ShipCityDetails>();
            us.Add(new ShipCityDetails() { ShipCityName = "Campinas", ShipCityID = 138 });
            us.Add(new ShipCityDetails() { ShipCityName = "Bruxelles", ShipCityID = 139 });
            us.Add(new ShipCityDetails() { ShipCityName = "Bergamo", ShipCityID = 140 });
            us.Add(new ShipCityDetails() { ShipCityName = "Graz", ShipCityID = 141 });
            us.Add(new ShipCityDetails() { ShipCityName = "Århus", ShipCityID = 142 });

            ObservableCollection<ShipCityDetails> uk = new ObservableCollection<ShipCityDetails>();
            uk.Add(new ShipCityDetails() { ShipCityName = "Bruxelles", ShipCityID = 143 });
            uk.Add(new ShipCityDetails() { ShipCityName = "Montréal", ShipCityID = 145 });
            uk.Add(new ShipCityDetails() { ShipCityName = "Cork", ShipCityID = 146 });
            uk.Add(new ShipCityDetails() { ShipCityName = "Helsinki", ShipCityID = 147 });


            Dictionary<string, ObservableCollection<ShipCityDetails>> shipDictionary =
                new Dictionary<string, ObservableCollection<ShipCityDetails>>();
            shipDictionary.Add("Argentina", argentina);
            shipDictionary.Add("Austria", austria);
            shipDictionary.Add("Belgium", belgium);
            shipDictionary.Add("Brazil", brazil);
            shipDictionary.Add("Canada", canada);
            shipDictionary.Add("Denmark", denmark);
            shipDictionary.Add("Finland", finland);
            shipDictionary.Add("Italy", italy);
            shipDictionary.Add("US", us);
            shipDictionary.Add("UK", uk);
            return shipDictionary;
        }
    }

    public class OrderDetails : INotifyPropertyChanged
    {
        private System.Nullable<int> _OrderID;

        /// <summary>
        /// Gets or sets the order ID.
        /// </summary>
        /// <value>The order ID.</value>
        public System.Nullable<int> OrderID
        {
            get
            {
                return this._OrderID;
            }
            set
            {
                this._OrderID = value;
                RaisePropertyChanged("OrderID");
            }
        }

        private int _shipCityID;
        /// <summary>
        /// Gets or sets the shipCityID.
        /// </summary>
        /// <value>The ship city ID.</value>
        public int ShipCityID
        {
            get
            {
                return _shipCityID;
            }
            set
            {
                _shipCityID = value;
                RaisePropertyChanged("ShipCityID");
            }
        }
        /// <summary>
        /// Gets or sets the noOfOrders.
        /// </summary>
        /// <value>The no of orders.</value>
        private int _noOfOrders;
        public int NoOfOrders
        {
            get
            {
                return _noOfOrders;
            }
            set
            {
                _noOfOrders = value;
                RaisePropertyChanged("NoOfOrders");
            }
        }
        /// <summary>
        /// Gets or sets the customerID.
        /// </summary>
        /// <value>The customer ID.</value>
        private string _customerID;
        public string CustomerID
        {
            get
            {
                return _customerID;
            }
            set
            {
                _customerID = value;
                RaisePropertyChanged("CustomerID");
            }
        }

        private string _productName;

        /// <summary>
        /// Gets or sets the productName.
        /// </summary>
        /// <value>The product name.</value>
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

        private string _shipCountry;

        /// <summary>
        /// Gets or sets the shipCounry.
        /// </summary>
        /// <value>The ship counry.</value>
        public string ShipCountry
        {
            get
            {
                return _shipCountry;
            }
            set
            {
                _shipCountry = value;
                RaisePropertyChanged("ShipCountry");
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDetails"/> class.
        /// </summary>
        /// <param name="ord">The ord.</param>
        /// <param name="cusid">The custmer iD.</param>
        /// <param name="productName">The product name.</param>
        /// <param name="NoOfOrders">The no of orders.</param>
        /// <param name="country">The country.</param>
        /// <param name="ShipCity">The ship city ID.</param>
        public OrderDetails(int ord, string cusid, string productName, int NoOfOrders, string country, int shipCityID)
        {
            this._OrderID = ord;
            this._customerID = cusid;
            this._shipCountry = country;
            this._shipCityID = shipCityID;
            this._productName = productName;
            this._noOfOrders = NoOfOrders;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }

    public class ShipCityDetails : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        private int _shipCityID;
        /// <summary>
        /// Gets or sets the shipCityID.
        /// </summary>
        /// <value>The ship city ID.</value>
        public int ShipCityID
        {
            get
            {
                return _shipCityID;
            }
            set
            {
                _shipCityID = value;
                RaisePropertyChanged("ShipCityID");
            }
        }

        private string _shipCityName;
        /// <summary>
        /// Gets or sets the shipCityName.
        /// </summary>
        /// <value>The ship city name.</value>
        public string ShipCityName
        {
            get
            {
                return _shipCityName;
            }
            set
            {
                _shipCityName = value;
                RaisePropertyChanged("ShipCityName");
            }
        }

    }
}
