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
using System.Collections.ObjectModel;
using ExcelExporting;
using System.IO;

namespace ExcelExporting
{
    public class ProductInfoRepository
    {
        Northwind northWind;
        public ProductInfoRepository()
        {
            ProductInfo = this.GetProductInfo();
        }

        private List<Products> _productInfo;

        /// <summary>
        /// Gets or sets the product info.
        /// </summary>
        /// <value>The product info.</value>
        public List<Products> ProductInfo
        {
            get
            {
                return _productInfo;
            }
            set
            {
                _productInfo = value;

            }
        }

        /// <summary>
        /// Gets the product info.
        /// </summary>
        /// <returns></returns>
        public List<Products> GetProductInfo()
        {
            List<Products> productInfo = new List<Products>();
            {
                string connectionString = string.Format(@"Data Source = {0}", FindFile("Northwind.sdf"));
                northWind = new Northwind(connectionString);
                var ords = northWind.Products.Take(500);
                foreach (var em in ords)
                {
                    productInfo.Add(em);
                }
            }

            return productInfo;
        }

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
    }
}
