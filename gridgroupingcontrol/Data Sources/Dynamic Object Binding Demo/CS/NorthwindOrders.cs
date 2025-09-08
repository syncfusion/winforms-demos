#region Copyright Syncfusion Inc. 2001 - 2015
// Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace DynamicObjectBinding_Demo
{
    using System;
    using System.Net;
    using System.Windows;
    using System.Collections.Generic;
    using System.Linq;
    using System.ComponentModel;

    public class NorthwindOrders : List<Orders>
    {
        public static NorthwindOrders Model
        {
            get
            {
                return new NorthwindOrders(1000);
            }
        }

        public NorthwindOrders()
        {
        }

        public NorthwindOrders(int count)
        {
            SetShipCity();
            for (int i = 10000; i < count + 10000; i++)
            {
                this.Add(GetOrder(i));
            }
        }

        public List<string> Customers
        {
            get
            {
                return this.CustomerID.ToList();
            }
        }

        public List<string> ShipCountries
        {
            get
            {
                return this.ShipCountry.ToList();
            }
        }

        Random r = new Random();
        private Orders GetOrder(int i)
        {
            var shipcountry = ShipCountry[r.Next(5)];
            var shipcitycoll = ShipCity[shipcountry];
            return new Orders()
            {
                OrderID = i,
                CustomerID = CustomerID[r.Next(15)],
                EmployeeID = r.Next(9),
                Freight = Math.Round(r.Next(1000) + r.NextDouble(), 2),
                ShipCountry = shipcountry,
                ShipCity = shipcitycoll[r.Next(shipcitycoll.Length - 1)],
            };
        }

        string[] ShipCountry = new string[]
        {
            
            "Argentina",
            "Austria",
            "Belgium",
            "Brazil",            
            "Canada",
            "Denmark",
            "Finland",
            "France",
            "Germany",
            "Ireland",
            "Italy",
            "Mexico",
            "Norway",
            "Poland",
            "Portugal",
            "Spain",
            "Sweden",
            "Switzerland",
            "UK",
            "USA",
            "Venezuela"
        };

        Dictionary<string, string[]> ShipCity = new Dictionary<string, string[]>();

        private void SetShipCity()
        {
            string[] argentina = new string[] { "Buenos Aires" };

            string[] austria = new string[] { "Graz", "Salzburg" };

            string[] belgium = new string[] { "Bruxelles", "Charleroi" };

            string[] brazil = new string[] { "Campinas", "Resende", "Rio de Janeiro", "São Paulo" };

            string[] canada = new string[] { "Montréal", "Tsawassen", "Vancouver" };

            string[] denmark = new string[] { "Århus", "København" };

            string[] finland = new string[] { "Helsinki", "Oulu" };

            string[] france = new string[] { "Lille", "Lyon", "Marseille", "Nantes", "Paris", "Reims", "Strasbourg", "Toulouse", "Versailles" };

            string[] germany = new string[] { "Aachen", "Berlin", "Brandenburg", "Cunewalde", "Frankfurt a.M.", "Köln", "Leipzig", "Mannheim", "München", "Münster", "Stuttgart" };

            string[] ireland = new string[] { "Cork" };

            string[] italy = new string[] { "Bergamo", "Reggio Emilia", "Torino" };

            string[] mexico = new string[] { "México D.F." };

            string[] norway = new string[] { "Stavern" };

            string[] poland = new string[] { "Warszawa" };

            string[] portugal = new string[] { "Lisboa" };

            string[] spain = new string[] { "Barcelona", "Madrid", "Sevilla" };

            string[] sweden = new string[] { "Bräcke", "Luleå" };

            string[] switzerland = new string[] { "Bern", "Genève" };

            string[] uk = new string[] { "Colchester", "Hedge End", "London" };

            string[] usa = new string[] { "Albuquerque", "Anchorage", "Boise", "Butte", "Elgin", "Eugene", "Kirkland", "Lander", "Portland", "San Francisco", "Seattle", "Walla Walla" };

            string[] venezuela = new string[] { "Barquisimeto", "Caracas", "I. de Margarita", "San Cristóbal" };

            ShipCity.Add("Argentina", argentina);
            ShipCity.Add("Austria", austria);
            ShipCity.Add("Belgium", belgium);
            ShipCity.Add("Brazil", brazil);
            ShipCity.Add("Canada", canada);
            ShipCity.Add("Denmark", denmark);
            ShipCity.Add("Finland", finland);
            ShipCity.Add("France", france);
            ShipCity.Add("Germany", germany);
            ShipCity.Add("Ireland", ireland);
            ShipCity.Add("Italy", italy);
            ShipCity.Add("Mexico", mexico);
            ShipCity.Add("Norway", norway);
            ShipCity.Add("Poland", poland);
            ShipCity.Add("Portugal", portugal);
            ShipCity.Add("Spain", spain);
            ShipCity.Add("Sweden", sweden);
            ShipCity.Add("Switzerland", switzerland);
            ShipCity.Add("UK", uk);
            ShipCity.Add("USA", usa);
            ShipCity.Add("Venezuela", venezuela);

        }

        string[] CustomerID = new string[]
        {
            "ALFKI",
            "FRANS",
            "MEREP",
            "FOLKO",
            "SIMOB",
            "WARTH",
            "VAFFE",
            "FURIB",
            "SEVES",
            "LINOD",
            "RISCU",
            "PICCO",
            "BLONP",
            "WELLI",
            "FOLIG"
        };
    }

    public class Orders : INotifyPropertyChanged
    {

        private int _OrderID;

        private string _CustomerID;

        private System.Nullable<int> _EmployeeID;

        private string _ShipCity;

        private string _ShipCountry;

        private double _Freight;

        private bool _isClosed;

        public Orders()
        {

        }

        public int OrderID
        {
            get
            {
                return this._OrderID;
            }
            set
            {
                this._OrderID = value;
                this.RaisePropertyChanged("OrderID");
            }
        }

        public string CustomerID
        {
            get
            {
                return this._CustomerID;
            }
            set
            {
                this._CustomerID = value;
                this.RaisePropertyChanged("CustomerID");
            }
        }

        public System.Nullable<int> EmployeeID
        {
            get
            {
                return this._EmployeeID;
            }
            set
            {
                this._EmployeeID = value;
                this.RaisePropertyChanged("EmployeeID");
            }
        }

        public string ShipCity
        {
            get
            {
                return this._ShipCity;
            }
            set
            {
                this._ShipCity = value;
                this.RaisePropertyChanged("ShipCity");
            }
        }

        public string ShipCountry
        {
            get
            {
                return this._ShipCountry;
            }
            set
            {
                this._ShipCountry = value;
                this.RaisePropertyChanged("ShipCountry");
            }
        }

        public double Freight
        {
            get
            {
                return this._Freight;
            }
            set
            {
                this._Freight = value;
                this.RaisePropertyChanged("Freight");
            }
        }

        public bool IsClosed
        {
            get
            {
                return this._isClosed;
            }

            set
            {
                this._isClosed = value;
                this.RaisePropertyChanged("IsClosed");
            }
        }

        #region INotifyPropertyChanged Members

        private void RaisePropertyChanged(string propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
