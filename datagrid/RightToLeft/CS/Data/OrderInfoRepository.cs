#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace RightToLeft
{
    public class OrderInfoRepository : INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderInfoRepository"/> class.
        /// </summary>
        public OrderInfoRepository()
        {

        }

        /// <summary>
        /// Gets the orders details.
        /// </summary>
        /// <param name="count">The count.</param>
        /// <returns></returns>
        public ObservableCollection<OrderInfo> GetOrdersDetails(int count)
        {
            ObservableCollection<OrderInfo> ordersDetails = new ObservableCollection<OrderInfo>();
            this.OrderedDates = GetDateBetween(2008, 2012, count);
            OrdersAdd(count);
            SetShipCity();
            for (int i = 10000; i < count + 10000; i++)
            {
                ordersDetails.Add(GetOrder(i));
            }
            return ordersDetails;
        }

        /// <summary>
        /// Orderses the add.
        /// </summary>
        private void OrdersAdd(int count)
        {
            ord.Add(new OrderDetails(10000, 239800, 12, 5, "سيارة نقل", 10, this.OrderedDates[r.Next(count - 1)], "نيويورك"));
            ord.Add(new OrderDetails(10000, 587929, 14, 10, "سيارة", 2, this.OrderedDates[r.Next(count - 1)], "واشنطن"));
            ord.Add(new OrderDetails(10000, 299913, 18, 5, "حافلة", 10,this.OrderedDates[r.Next(count - 1)], "لندن"));
            ord.Add(new OrderDetails(10000, 545569, 34, 10, "شاحنة نقل", 2,this.OrderedDates[r.Next(count - 1)], "سيدني"));
            ord.Add(new OrderDetails(10000, 523456, 14, 10, "دراجة", 2,this.OrderedDates[r.Next(count - 1)], "ملبورن"));
            ord.Add(new OrderDetails(10000, 239654, 18, 5, "جيب", 10,this.OrderedDates[r.Next(count - 1)], "مانشستر"));
            ord.Add(new OrderDetails(10000, 598870, 34, 10, "سيارة نقل", 2, this.OrderedDates[r.Next(count - 1)], "بيرث"));
            ord.Add(new OrderDetails(10001, 445654, 23, 76, "سيارة", 0, this.OrderedDates[r.Next(count - 1)], "بريسبان"));
            ord.Add(new OrderDetails(10001, 690871, 45, 23, "حافلة", 5, this.OrderedDates[r.Next(count - 1)], "ديربان"));
            ord.Add(new OrderDetails(10001, 434762, 45, 16, "شاحنة نقل", 3, this.OrderedDates[r.Next(count - 1)], "أوكلاند"));
            ord.Add(new OrderDetails(10001, 989875, 23, 15, "دراجة", 2, this.OrderedDates[r.Next(count - 1)], "ولينغتون"));
            ord.Add(new OrderDetails(10002, 723480, 7, 6, "جيب", 4, this.OrderedDates[r.Next(count - 1)], "نيويورك"));
            ord.Add(new OrderDetails(10002, 245683, 30, 5, "سيارة نقل", 2,this.OrderedDates[r.Next(count - 1)], "ملبورن"));
            ord.Add(new OrderDetails(10003, 213463, 73, 9, "سيارة", 3,this.OrderedDates[r.Next(count - 1)], "بريسبان"));
            ord.Add(new OrderDetails(10003, 890898, 11, 8, "حافلة", 7,this.OrderedDates[r.Next(count - 1)], "بيرث"));
            ord.Add(new OrderDetails(10003, 167590, 150, 1, "شاحنة نقل", 0, this.OrderedDates[r.Next(count - 1)], "ديربان"));
            ord.Add(new OrderDetails(10009, 469879, 35, 4, "دراجة", 0,this.OrderedDates[r.Next(count - 1)], "بريسبان"));
            ord.Add(new OrderDetails(10009, 254389, 31, 7, "جيب", 0,this.OrderedDates[r.Next(count - 1)], "بيرث"));
            ord.Add(new OrderDetails(10010, 790859, 23, 3, "سيارة نقل", 0,this.OrderedDates[r.Next(count - 1)], "أوكلاند"));
            ord.Add(new OrderDetails(10010, 565560, 65, 4, "سيارة", 0,this.OrderedDates[r.Next(count - 1)], "ولينغتون"));
            ord.Add(new OrderDetails(10010, 345767, 15, 5, "حافلة", 0,this.OrderedDates[r.Next(count - 1)], "مانشستر"));
            ord.Add(new OrderDetails(10010, 290898, 31, 1, "شاحنة نقل", 0,this.OrderedDates[r.Next(count - 1)], "ديربان"));
            ord.Add(new OrderDetails(10011, 667876, 46, 2, "دراجة", 0,this.OrderedDates[r.Next(count - 1)], "لندن"));
            ord.Add(new OrderDetails(10011, 345676, 45, 4, "جيب", 0,this.OrderedDates[r.Next(count - 1)], "ملبورن"));
            ord.Add(new OrderDetails(10011, 289780, 41, 7, "سيارة نقل", 0,this.OrderedDates[r.Next(count - 1)], "واشنطن"));
            ord.Add(new OrderDetails(10013, 195678, 80, 2, "سيارة", 0,this.OrderedDates[r.Next(count - 1)], "ملبورن"));
            ord.Add(new OrderDetails(10013, 204345, 111, 1, "حافلة", 7, this.OrderedDates[r.Next(count - 1)], "أوكلاند"));
            ord.Add(new OrderDetails(10021, 548908, 35, 2, "شاحنة نقل", 0, this.OrderedDates[r.Next(count - 1)], "بريسبان"));
            ord.Add(new OrderDetails(10021, 634567, 46, 7, "دراجة", 0,this.OrderedDates[r.Next(count - 1)], "بيرث"));
            ord.Add(new OrderDetails(10021, 275467, 99, 5, "جيب", 0, this.OrderedDates[r.Next(count - 1)], "أوكلاند"));
            ord.Add(new OrderDetails(10022, 598907, 80, 3, "سيارة نقل", 0,this.OrderedDates[r.Next(count - 1)], "ولينغتون"));
            ord.Add(new OrderDetails(10022, 605678, 111, 1, "سيارة", 7, this.OrderedDates[r.Next(count - 1)], "مانشستر"));
            ord.Add(new OrderDetails(10022, 472345, 35, 9, "حافلة", 0, this.OrderedDates[r.Next(count - 1)], "ديربان"));
            ord.Add(new OrderDetails(10032, 445678, 35, 6, "شاحنة نقل", 0, this.OrderedDates[r.Next(count - 1)], "لندن"));
            ord.Add(new OrderDetails(10032, 690909, 46, 8, "دراجة", 0, this.OrderedDates[r.Next(count - 1)], "ملبورن"));
            ord.Add(new OrderDetails(10034, 174356, 99, 1, "جيب", 0, this.OrderedDates[r.Next(count - 1)], "واشنطن"));
            ord.Add(new OrderDetails(10034, 196789, 80, 5, "سيارة نقل", 0, this.OrderedDates[r.Next(count - 1)], "ملبورن"));
            ord.Add(new OrderDetails(10034, 206578, 111, 3, "سيارة", 7,this.OrderedDates[r.Next(count - 1)], "لندن"));
            ord.Add(new OrderDetails(10042, 454578, 35, 1, "حافلة", 0, this.OrderedDates[r.Next(count - 1)], "ملبورن"));
            ord.Add(new OrderDetails(10042, 489076, 35, 9, "شاحنة نقل", 0, this.OrderedDates[r.Next(count - 1)], "واشنطن"));
            ord.Add(new OrderDetails(10045, 667890, 46, 7, "دراجة", 0, this.OrderedDates[r.Next(count - 1)], "ملبورن"));
            ord.Add(new OrderDetails(10045, 174356, 99, 3, "جيب", 0, this.OrderedDates[r.Next(count - 1)], "لندن"));
            ord.Add(new OrderDetails(10045, 199890, 80, 6, "سيارة نقل", 0, this.OrderedDates[r.Next(count - 1)], "ملبورن"));
            ord.Add(new OrderDetails(10045, 204356, 111, 1, "سيارة", 7,this.OrderedDates[r.Next(count - 1)], "بيرث"));
            ord.Add(new OrderDetails(10056, 489087, 35, 2, "حافلة", 0, this.OrderedDates[r.Next(count - 1)], "بريسبان"));
            ord.Add(new OrderDetails(10056, 443567, 35, 7, "شاحنة نقل", 0, this.OrderedDates[r.Next(count - 1)], "بيرث"));
            ord.Add(new OrderDetails(10056, 612367, 46, 4, "دراجة", 0, this.OrderedDates[r.Next(count - 1)], "أوكلاند"));
            ord.Add(new OrderDetails(10067, 178796, 99, 4, "جيب", 0, this.OrderedDates[r.Next(count - 1)], "ولينغتون"));
            ord.Add(new OrderDetails(10067, 195468, 80, 2, "سيارة نقل", 0, this.OrderedDates[r.Next(count - 1)], "مانشستر"));
            ord.Add(new OrderDetails(10067, 207657, 111, 1, "سيارة", 7,this.OrderedDates[r.Next(count - 1)], "ديربان"));
        }

        private List<DateTime> OrderedDates;
        Random r = new Random();
        List<OrderDetails> ord = new List<OrderDetails>();
        List<string> CustomerCities;

        public List<string> ComboBoxItemsSource
        {
            get { PopulateCountries(); return CustomerCities; }
            set
            {
                CustomerCities = value;
                RaisePropertyChanged("ComboBoxItemsSource");
            }
        }

        /// <summary>
        /// Gets the order.
        /// </summary>
        /// <param name="i">The i.</param>
        /// <returns></returns>
        private OrderInfo GetOrder(int i)
        {
            var shipcountry = ShipCountry[r.Next(5)];
            var shipcitycoll = ShipCity[shipcountry];
            return new OrderInfo()
            {
                OrderID = i,                
                EmployeeID = r.Next(1, 10),
                Freight = Math.Round(r.Next(1000) + r.NextDouble(), 2),
                ShipCountry = shipcountry,
                ShippingDate = this.OrderedDates[i - 10000],
                IsClosed = i % 2 == 0 ? true : false,
                ShipCity = shipcitycoll[r.Next(shipcitycoll.Length - 1)],
                OrderDetails = GetOrderDetails(i)
            };
        }

        /// <summary>
        /// Getors the specified i.
        /// </summary>
        /// <param name="i">The i.</param>
        /// <returns></returns>
        public List<OrderDetails> GetOrderDetails(int i)
        {
            PopulateCountries();
            List<OrderDetails> order = new List<OrderDetails>();
            foreach (var or in ord)
                if (or.OrderID == i)
                    order.Add(or);
            return order;
        }

        private void PopulateCountries()
        {
            CustomerCities = new List<string>();
            CustomerCities.Add("نيويورك");
            CustomerCities.Add("واشنطن");
            CustomerCities.Add("لندن");
            CustomerCities.Add("سيدني");
            CustomerCities.Add("ملبورن");
            CustomerCities.Add("مانشستر");
            CustomerCities.Add("بيرث");
            CustomerCities.Add("بريسبان");
            CustomerCities.Add("ديربان");
            CustomerCities.Add("أوكلاند");
            CustomerCities.Add("ولينغتون");
        }

        string[] ShipCountry = new string[]
        {

            "الأرجنتين",
            "النمسا",
            "بلجيكا",
            "البرازيل",
            "كندا",
            "الدنمارك",
            "فنلندا",
            "فرنسا",
            "ألمانيا",
            "أيرلندا",
            "إيطاليا",
            "المكسيك",
            "النرويج",
            "بولندا",
            "البرتغال",
            "إسبانيا",
            "السويد",
            "سويسرا",
            " يو ك",
            "الولايات المتحدة الأمريكية",
            "فنزويلا"
        };

        Dictionary<string, string[]> ShipCity = new Dictionary<string, string[]>();

        /// Products
        string[] products = new string[] { "Bike", "سيارة", "شاحنة نقل", "سيارة نقل", "دراجة", "جيب" };
        Random ra = new Random(0);

        /// <summary>
        /// Sets the ship city.
        /// </summary>
        private void SetShipCity()
        {
            string[] الأرجنتين = new string[] {" بوينس آيرس" };

            string[] النمسا = new string[] { "غراتس", "Salzburg" };

            string[] بلجيكا = new string[] { "بروكسل", "Charleroi" };

            string[] البرازيل = new string[] { "كامبيناس", "ريزندي", "ريو دي جانيرو", "São Paulo" };

            string[] كندا = new string[] { "مونتريال", "ريزندي", "Vancouver" };

            string[] الدنمارك = new string[] { "آرهوس", "København" };

            string[] فنلندا = new string[] { "Helsinki", "Oulu" };

            string[] فرنسا = new string[] { "Lille", "Lyon", "Marseille", "Nantes", "Paris", "Reims", "Strasbourg", "Toulouse", "Versailles" };

            string[] ألمانيا = new string[] { "Aachen", "Berlin", "Brandenburg", "Cunewalde", "Frankfurt a.M.", "Köln", "Leipzig", "Mannheim", "München", "Münster", "Stuttgart" };

            string[] أيرلندا = new string[] { "Cork" };

            string[] إيطاليا = new string[] { "Bergamo", "Reggio Emilia", "Torino" };

            string[] المكسيك = new string[] { "México D.F." };

            string[] النرويج = new string[] { "Stavern" };

            string[] بولندا = new string[] { "Warszawa" };

            string[] البرتغال = new string[] { "Lisboa" };

            string[] إسبانيا = new string[] { "Barcelona", "Madrid", "Sevilla" };

            string[] السويد = new string[] { "Bräcke", "Luleå" };

            string[] سويسرا = new string[] { "Bern", "Genève" };

            string[] UK  = new string[] { "Colchester", "Hedge End", "London" };

            string[] USA   = new string[] { "Albuquerque", "Anchorage", "Boise", "Butte", "Elgin", "Eugene", "Kirkland", "Lander", "Portland", "San Francisco", "Seattle", "Walla Walla" };

            string[] فنزويلا = new string[] { "Barquisimeto", "Caracas", "I. de Margarita", "San Cristóbal" };

            ShipCity.Add("الأرجنتين", الأرجنتين);
            ShipCity.Add("النمسا", النمسا);
            ShipCity.Add("بلجيكا", بلجيكا);
            ShipCity.Add("البرازيل", البرازيل);
            ShipCity.Add("كندا", كندا);
            ShipCity.Add("الدنمارك", الدنمارك);
            ShipCity.Add("فنلندا", فنلندا);
            ShipCity.Add("فرنسا", فرنسا);
            ShipCity.Add("ألمانيا", ألمانيا);
            ShipCity.Add("أيرلندا", أيرلندا);
            ShipCity.Add("إيطاليا", إيطاليا);
            ShipCity.Add("المكسيك", المكسيك);
            ShipCity.Add("النرويج", النرويج);
            ShipCity.Add("بولندا", بولندا);
            ShipCity.Add("البرتغال", البرتغال);
            ShipCity.Add("إسبانيا", إسبانيا);
            ShipCity.Add("السويد", السويد);
            ShipCity.Add("سويسرا", سويسرا);
            ShipCity.Add("يو ك", UK);
            ShipCity.Add("الولايات المتحدة الأمريكية", USA  );
            ShipCity.Add("فنزويلا", فنزويلا);
        }

        string[] Product = new string[]
        {
            "سيارة نقل",
            "سيارة",
            "حافلة",
            "شاحنة نقل",
            "جيب",
            "دراجة",
        };

        /// <summary>
        /// Gets the date between.
        /// </summary>
        /// <param name="startYear">The start year.</param>
        /// <param name="EndYear">The end year.</param>
        /// <param name="Count">The count.</param>
        /// <returns></returns>
        private List<DateTime> GetDateBetween(int startYear, int EndYear, int Count)
        {
            List<DateTime> date = new List<DateTime>();
            Random d = new Random(1);
            Random m = new Random(2);
            Random y = new Random(startYear);
            for (int i = 0; i < Count; i++)
            {
                int year = y.Next(startYear, EndYear);
                int month = m.Next(3, 13);
                int day = d.Next(1, 31);

                date.Add(new DateTime(year, month, day));
            }

            return date;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
