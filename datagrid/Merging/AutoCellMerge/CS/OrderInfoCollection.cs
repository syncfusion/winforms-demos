#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AutoCellMerging
{
    public class OrderInfoCollection : IDisposable
    {
        public OrderInfoCollection()
        {
            OrdersListDetails = new OrderInfoRepository().GetListOrdersDetails(150);
        }

        /// <summary>
        /// Gets or sets the orders details.
        /// </summary>
        /// <value>The orders details.</value>
        public List<OrderInfo> OrdersListDetails { get; set; }

        /// <summary>
        /// Disposes the object.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Disposes the collection. 
        /// </summary>
        /// <param name="isdisposable"></param>
        protected virtual void Dispose(bool isdisposable)
        {
            if (this.OrdersListDetails != null)
            {
                this.OrdersListDetails.Clear();
            }
        }
    }

    public class OrderInfoRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderInfoRepository"/> class.
        /// </summary>
        public OrderInfoRepository()
        { }

        internal List<OrderInfo> GetListOrdersDetails(int count)
        {
            var orderInfoCollection = new List<OrderInfo>();
            Random r = new Random();
            string fileName = this.FindFile(@"Common\Data\Northwind.sdf");
            Northwind northWind = new Northwind(fileName);
            var ords = northWind.Products.Take(500);
            foreach (OrderDetails orderDet in northWind.OrderDetails.Take(count))
            {
                OrderInfo orderInfo = new OrderInfo();
                orderInfo.OrderID = orderDet.OrderID;
                orderInfo.CustomerID = orderDet.Orders.CustomerID;
                orderInfo.ProductName = orderDet.Products.ProductName;
                orderInfo.UnitPrice = (double)orderDet.UnitPrice;
                orderInfo.OrderDate = (DateTime)orderDet.Orders.OrderDate;
                orderInfo.Quantity = orderDet.Quantity;
                orderInfo.ContactNumber = r.Next(999111234, 999111239);
                orderInfo.ShipAddress = orderDet.Orders.ShipAddress;
                orderInfoCollection.Add(orderInfo);
            }

            return orderInfoCollection;
        }

        /// <summary>
        /// Gets the path of the given file name.
        /// </summary>
        /// <param name="fileName">The file which needs to return the path.</param>
        /// <returns>The path of the given file name.</returns>
        private string FindFile(string fileName)
        {
            // Check both in parent folder and Parent\Data folders.
            string dataFileName = @"Windows\Common\Data\" + fileName;
            for (int n = 0; n < 12; n++)
            {
                if (System.IO.File.Exists(fileName))
                    return new FileInfo(fileName).FullName;
                if (System.IO.File.Exists(dataFileName))
                    return new FileInfo(dataFileName).FullName;

                fileName = @"..\" + fileName;
                dataFileName = @"..\" + dataFileName;
            }

            return fileName;
        }
    }
}
