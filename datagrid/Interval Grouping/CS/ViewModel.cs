#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace IntervalGrouping
{
    public class NotificationObject : INotifyPropertyChanged
    {
        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
    public class ViewModel : NotificationObject
    {
        Random r = new Random();
        int customerIdCount = 0;
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModel"/> class.
        /// </summary>
        public ViewModel()
        {
            OrdersDetail = this.GetOrdersDetail(100);
        }

        private ObservableCollection<OrderInfo> _ordersDetail;
        /// <summary>
        /// Gets or sets the orders details.
        /// </summary>
        /// <value>The orders details.</value>
        public ObservableCollection<OrderInfo> OrdersDetail
        {
            get
            {
                return _ordersDetail;
            }
            set
            {
                _ordersDetail = value;
            }
        }

        /// <summary>
        /// Gets the orders details.
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<OrderInfo> GetOrdersDetail(int count)
        {
            ObservableCollection<OrderInfo> ordersDetail = new ObservableCollection<OrderInfo>();
            for (int i = 10000; i <= count+10000; i++)
            {
                ordersDetail.Add(GetOrder(i));
            }
            return ordersDetail;
        }

        private OrderInfo GetOrder(int i)
        {
            return new OrderInfo()
            {
                OrderID = i,
                CustomerID = GetCustomerID(i),
                OrderDate = new DateTime(r.Next(2011, 2013), r.Next(1, 12), r.Next(1, 28)),               
                ShippedDate = new DateTime(r.Next(2005, 2006), r.Next(1, 12), r.Next(1, 29)),               
                ShipCountry = ShipCountry[r.Next(8)],
                Freight = r.Next(20, 60),
            };
        }

        string GetCustomerID(int i)
        {
            if (i % 4 != 0 || i == 0)
            {
                return CustomerID[customerIdCount];
            }
            else
            {
                if (i % 4 == 0)
                    customerIdCount++;

                if (customerIdCount > 20)
                    customerIdCount = 0;

                return CustomerID[customerIdCount];
            }
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
            "FOLIG",
            "SHIWL",
            "ASDFI",
            "YIWOL",
            "SIEPZ",
            "UIKOC",
            "BNUTQ",
            "FDKIO",
            "UJIKW",
            "QOLPX",
            "WJXKO",
            "SXEWD",
            "ZXSOL",
            "KKMJU",
            "QMICP",
            "SJWII",
            "WDOPO",
            "SAIOP",
            "SSOLE",
            "CUEMC",
            "HWIMQ"
        };
    }
}
