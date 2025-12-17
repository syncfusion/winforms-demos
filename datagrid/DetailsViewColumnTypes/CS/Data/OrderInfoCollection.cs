#region Copyright Syncfusion Inc. 2001 - 2015
// Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using DetailsViewColumnTypes;
using DetailsViewColumnTypes.Data;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;

namespace DetailsViewColumnTypes
{
    public class OrderInfoCollection : INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderInfoCollection"/> class.
        /// </summary>
        public OrderInfoCollection()
        {
            OrderInfoRepository order = new OrderInfoRepository();
            OrdersDetails = order.GetOrdersDetails(100);
            Suppliers = PopulateDataForShip(30);
        }

        public ObservableCollection<OrderInfo> _ordersDetails;

        /// <summary>
        /// Gets or sets the orders details.
        /// </summary>
        /// <value>The orders details.</value>
        public ObservableCollection<OrderInfo> OrdersDetails
        {
            get{ return _ordersDetails; }
            set { _ordersDetails = value; RaisePropertyChanged("OrdersDetails"); }
        }

        private ObservableCollection<SupplierDetails> suppliers;

        public ObservableCollection<SupplierDetails> Suppliers
        {
            get
            {
                return suppliers;
            }
            set
            {
                suppliers = value;
                RaisePropertyChanged("Suppliers");
            }
        }

        /// <summary>
        /// Finds the datasource file.
        /// </summary>
        /// <param name="fileName">Name of the file</param>
        /// <returns>Location string.</returns>
        private static string FindFile(string fileName)
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


        private ObservableCollection<SupplierDetails> PopulateDataForShip(int i)
        {
            ObservableCollection<SupplierDetails> SupplierInfo = new ObservableCollection<SupplierDetails>();
            string connectionString = FindFile("Northwind.sdf");
            Northwind northWind = new Northwind(connectionString);
            var suppliers = northWind.Suppliers.Take(40);

            foreach (var supplier in suppliers)
            {
                SupplierDetails s = new SupplierDetails();
                s.SupplierCity = supplier.City;
                s.SupplierID = supplier.SupplierID;
                s.SupplierName = supplier.CompanyName;
                SupplierInfo.Add(s);
            }

            return SupplierInfo;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
