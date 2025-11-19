#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace UpdatingDemo
{
    public class ProductSales : INotifyPropertyChanged, INotifyPropertyChanging
    {
        private string product = "";

        private string date = "";

        private string country = "";

        private string state = "";

        private int quantity;

        private double amount;

        private int extra;

        private DateTime date2;

        public string Product
        {
            get
            {
                return product;
            }
            set
            {
                if (product != value)
                {
                    OnPropertyChanging("Product");
                    product = value;
                    OnPropertyChanged("Product");
                }
            }
        }

        public string Date 
        {
            get
            {
                return date;
            }
            set
            {
                if (date != value)
                {
                    OnPropertyChanging("Date");
                    date = value;
                    OnPropertyChanged("Date");
                }
            }
        }

        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                if (country != value)
                {
                    OnPropertyChanging("Country");
                    country = value;
                    OnPropertyChanged("Country");
                }
            }
        }

        public string State
        {
            get
            {
                return state;
            }
            set
            {
                if (state != value)
                {
                    OnPropertyChanging("State");
                    state = value;
                    OnPropertyChanged("State");
                }
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (quantity != value)
                {
                    OnPropertyChanging("Quantity");
                    quantity = value;
                    OnPropertyChanged("Quantity");
                }
            }
        }

        public double Amount
        {
            get
            {
                return amount;
            }
            set
            {
                if (amount != value)
                {
                    OnPropertyChanging("Amount");
                    amount = value;
                    OnPropertyChanged("Amount");
                }
            }
        }

        public int Extra
        {
            get
            {
                return extra;
            }
            set
            {
                if (extra != value)
                {
                    OnPropertyChanging("Extra");
                    extra = value;
                    OnPropertyChanged("Extra");
                }
            }
        }

         public DateTime Date2
        {
            get
            {
                return date2;
            }
            set
            {
                if (date2 != value)
                {
                    OnPropertyChanging("Date2");
                    date2 = value;
                    OnPropertyChanged("Date2");
                }
            }
        }

        public override string ToString()
        {
            return string.Format("{0}-{1}-{2}", Country, State, Product);
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        #endregion

        #region INotifyPropertyChanging Members

        public event PropertyChangingEventHandler PropertyChanging;

        protected virtual void OnPropertyChanging(string name)
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, new PropertyChangingEventArgs(name));
            }
        }
        #endregion
    }

    public class ProductSalesCollection : ObservableCollection<ProductSales>
    {
    }

    public class ProductSalesData
    {
        #region Properties

        public static int count = 2000;

        #endregion

        public static ProductSalesCollection GetSalesData()
        {
            // Geography
            string[] countries = { "Australia", "Canada", "France", "Germany", "United Kingdom", "United States" };
            string[] ausStates = { "New South Wales", "Queensland", "South Australia", "Tasmania", "Victoria" };
            string[] canadaStates = { "Alberta", "British Columbia", "Brunswick", "Manitoba", "Ontario", "Quebec" };
            string[] franceStates = { "Charente-Maritime", "Essonne", "Garonne (Haute)", "Gers" };
            string[] germanyStates = { "Bayern", "Brandenburg", "Hamburg", "Hessen", "Nordrhein-Westfalen", "Saarland" };
            string[] ukStates = { "England" };
            string[] ussStates = { "New York", "North Carolina", "Alabama", "California", "Colorado", "New Mexico", "South Carolina" };

            // Time
            string[] dates = { "FY 2005", "FY 2006", "FY 2008", "FY 2009" };
            DateTime date0 = new DateTime(2005, 1, 1);

            // Products
            string[] products = { "Bike", "Car", "Truck", "Scooters" };
            products = new[] { "Bike", "Car" };
            Random r = new Random(123345345);

            int numberOfRecords = count;
            ProductSalesCollection listOfProductSales = new ProductSalesCollection();
            for (int i = 0; i < numberOfRecords; i++)
            {
                ProductSales sales = new ProductSales();
                sales.Country = countries[r.Next(1, countries.GetLength(0))];
                sales.Quantity = r.Next(1, 12);
                // 1 percent discount for 1 quantity
                double discount = (3000 * sales.Quantity) * (double.Parse(sales.Quantity.ToString()) / 100);
                sales.Amount = (3000 * sales.Quantity) - discount;
                sales.Date = dates[r.Next(r.Next(dates.GetLength(0) + 1))];
                sales.Product = products[r.Next(r.Next(products.GetLength(0) + 1))];
                sales.Extra = i % 2;
                sales.Date2 = date0.AddDays(r.Next(1500));
                switch (sales.Country)
                {
                    case "Australia":
                        {
                            sales.State = ausStates[r.Next(ausStates.GetLength(0))];
                            break;
                        }
                    case "Canada":
                        {
                            sales.State = canadaStates[r.Next(canadaStates.GetLength(0))];
                            break;
                        }
                    case "France":
                        {
                            sales.State = franceStates[r.Next(franceStates.GetLength(0))];
                            break;
                        }
                    case "Germany":
                        {
                            sales.State = germanyStates[r.Next(germanyStates.GetLength(0))];
                            break;
                        }
                    case "United Kingdom":
                        {
                            sales.State = ukStates[r.Next(ukStates.GetLength(0))];
                            break;
                        }
                    case "United States":
                        {
                            sales.State = ussStates[r.Next(ussStates.GetLength(0))];
                            break;
                        }
                }
                listOfProductSales.Add(sales);
            }
            return listOfProductSales;
        }
    }
}