#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Data;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilterRow
{
    public partial class Form1 : Form
    {
        private Northwind northWind;
        private List<ProductDetails> _productInfo;
        public Form1()
        {
            InitializeComponent();
            ProductInfo = this.GetProductInfo();
            this.sfDataGrid1.DataSource = ProductInfo;
            foreach (GridColumn column in this.sfDataGrid1.Columns)
            {
                column.AllowTextWrapping = false;
            }

            sfDataGrid1.Columns["ContactNumber"].CellStyle.HorizontalAlignment = HorizontalAlignment.Right;
            sfDataGrid1.Columns["ProductName"].FilterRowEditorType = "MultiSelectComboBox";
            sfDataGrid1.Columns["Quantity"].FilterRowEditorType = "ComboBox";
        }

        /// <summary>
        /// Gets or sets the product info.
        /// </summary>
        /// <value>The product info.</value>
        public List<ProductDetails> ProductInfo
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
        public List<ProductDetails> GetProductInfo()
        {
            var productInfo = new List<ProductDetails>();

            Random r = new Random();
            string fileName = this.FindFile(@"Northwind.sdf");
            northWind = new Northwind(fileName);
            var ords = northWind.Products.Take(500);
            foreach (OrderDetails orderDet in northWind.OrderDetails.Take(200))
            {
                var product = new ProductDetails();

                product.OrderID = orderDet.OrderID;
                product.CustomerID = orderDet.Orders.CustomerID;
                product.ProductName = orderDet.Products.ProductName;
                product.UnitPrice = (double)orderDet.UnitPrice;
                product.OrderDate = (DateTime)orderDet.Orders.OrderDate;
                product.Quantity = orderDet.Quantity;
                product.ContactNumber = r.Next(999111234, 999111239).ToString();
                product.ShipAddress = orderDet.Orders.ShipAddress;
                product.IsAvailable = product.UnitPrice % 2 == 0;

                productInfo.Add(product);

            }

            return productInfo;
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
