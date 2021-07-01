#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Collections.ObjectModel;
using System.IO;

namespace CustomFilterRow
{
    public class OrderInfoCollection : INotifyPropertyChanged
    {
        Random r = new Random();
        private ObservableCollection<OrderInfo> _orderList = new ObservableCollection<OrderInfo>();

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Gets or sets the order list.
        /// </summary>
        /// <value>The order list.</value>
        public ObservableCollection<OrderInfo> OrderList
        {
            get
            {
                return _orderList;
            }
            set
            {
                _orderList = value;
                RaisePropertyChanged("OrderList");
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderInfoCollection"/> class.
        /// </summary>
        public OrderInfoCollection()
        {
            this.PopulateData();
        }

        /// <summary>
        /// Populates the data.
        /// </summary>
        private void PopulateData()
        {
            Northwind north = new Northwind(string.Format(@"Data Source= {0}", this.FindFile("Northwind.sdf")));

                foreach (OrderDetails orderDet in north.OrderDetails.Take(600))
                {
                    OrderInfo orderInfo = new OrderInfo();
                    orderInfo.OrderID = orderDet.OrderID;
                    orderInfo.CustomerID = orderDet.Orders.CustomerID;
                    orderInfo.ProductName = orderDet.Products.ProductName;
                    orderInfo.OrderDate = DateTime.Today.AddDays(r.Next(-100,1));
                    if (orderInfo.OrderID % 2 == 0)
                        orderInfo.IsShipped = true;
                    else
                        orderInfo.IsShipped = false;
                    orderInfo.ShipName = orderDet.Orders.ShipName;
                    orderInfo.ShipAddress = orderDet.Orders.ShipAddress;
                    _orderList.Add(orderInfo);
                }
        }

        #region Find Data File

        private string FindFile(string fileName)
        {
            // Check both in parent folder and Parent\Data folders.
            string dataFileName = @"Common\Data\" + fileName;
            for (int n = 0; n < 12; n++)
            {
                if (System.IO.File.Exists(fileName))
                {
                    return new FileInfo(fileName).FullName;
                }
                if (System.IO.File.Exists(dataFileName))
                {
                    return new FileInfo(dataFileName).FullName;
                }
                fileName = @"..\" + fileName;
                dataFileName = @"..\" + dataFileName;
            }

            return fileName;
        }

        #endregion
    }
}
