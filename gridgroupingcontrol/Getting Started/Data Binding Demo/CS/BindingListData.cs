#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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
using System.IO;

namespace DataBinding
{
    public class BindingListData
    {

        #region Public Property
        public BindingList<OrderDetails> Data
        {
            get;
            set;
        }
        #endregion

        #region Constructor
        public BindingListData()
        {
            Data = this.PopulateOrders(30);
        }
        #endregion

        #region PopulateOrders
        internal BindingList<OrderDetails> PopulateOrders(int count)
        {
            Northwind northWind;
            BindingList<OrderDetails> orderCollection = new BindingList<OrderDetails>();
            string connectionString = string.Format(@"Data Source = {0}", FindFile("Northwind.sdf"));
            northWind = new Northwind(connectionString);
            var orders = northWind.OrderDetails.Skip(0).Take(count).ToList();
            foreach (var o in orders)
            {
                orderCollection.Add(o);
            }
            return orderCollection;
        }
        #endregion

        #region "FindFile"
        private static string FindFile(string fileName)
        {
            string dataFileName = fileName;
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
