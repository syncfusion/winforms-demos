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
using System.Collections.ObjectModel;
using System.IO;

namespace DataBinding
{
    public class Customer : ObservableCollection<Orders>
    {
        Northwind northWind;

        #region "Constructor"
        public Customer()
        {
            string connectionString = string.Format(@"Data Source = {0}", FindFile("Northwind.sdf"));
            northWind = new Northwind(connectionString);
            var customer = northWind.Orders.Skip(0).Take(30).ToList();
            foreach (var o in customer)
            {
                this.Add(o);
            }
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
