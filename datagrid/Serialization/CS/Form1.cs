#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Data;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Serialization;
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

namespace Serialization
{
    public partial class Form1 : Form
    {
        SerializationOptions serializationOptions = new SerializationOptions();
        DeserializationOptions deserializationOptions = new DeserializationOptions();
        Northwind northWind;
        public Form1()
        {
            InitializeComponent();
            this.sfDataGrid2.Columns.Add(new GridNumericColumn() { MappingName = "SupplierID", HeaderText = "Supplier ID", NumberFormatInfo = new System.Globalization.NumberFormatInfo() { NumberDecimalDigits = 0, NumberGroupSeparator = "" } });
            this.sfDataGrid2.Columns.Add(new GridNumericColumn() { MappingName = "ProductID", HeaderText = "Product ID", NumberFormatInfo = new System.Globalization.NumberFormatInfo() { NumberDecimalDigits = 0, NumberGroupSeparator = "" } });
            this.sfDataGrid2.Columns.Add(new GridTextColumn() { MappingName = "ProductName", HeaderText = "Product Name" });
            this.sfDataGrid2.Columns.Add(new GridTextColumn() { MappingName = "QuantityPerUnit", HeaderText = "Quantity Per Unit" });
            this.sfDataGrid2.Columns.Add(new GridNumericColumn() { MappingName = "UnitPrice", HeaderText = "Unit Price ", FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency });
            this.sfDataGrid2.Columns.Add(new GridNumericColumn() { MappingName = "UnitsInStock", HeaderText = "Units In Stock", NumberFormatInfo = new System.Globalization.NumberFormatInfo() { NumberDecimalDigits = 0, } });
            ProductInfo = this.GetProductInfo();
            this.sfDataGrid2.DataSource = ProductInfo;

            ///Table Summaries
            sfDataGrid2.TableSummaryRows.Add(new GridTableSummaryRow()
            {
                ShowSummaryInRow = true,
                Title = "TotalPrice: {UnitPrice}",
                SummaryColumns = new ObservableCollection<ISummaryColumn>()
                            {
                                new GridSummaryColumn()
                                {
                                    Name = "UnitPrice",
                                    MappingName = "UnitPrice",
                                    Format ="{Sum:c}",
                                    SummaryType = SummaryType.DoubleAggregate
                                },
                            }
            });

            //Stacked header
            StackedHeaderRow stackedHeaderRow = new StackedHeaderRow();
            stackedHeaderRow.StackedColumns.Add(new StackedColumn() { ChildColumns = "ProductID,ProductName,QuantityPerUnit,UnitPrice", HeaderText = "Product Details" });
            sfDataGrid2.StackedHeaderRows.Add(stackedHeaderRow);
        }

        private SerializationOptions serialization()
        {
            serializationOptions.SerializeStyle = this.s_style.Checked;
            serializationOptions.SerializeCaptionSummaries = this.s_captionsummary.Checked;
            serializationOptions.SerializeColumns = this.s_columns.Checked;
            serializationOptions.SerializeFiltering = this.s_filtering.Checked;
            serializationOptions.SerializeGrouping = this.s_grouping.Checked;
            serializationOptions.SerializeGroupSummaries = this.s_groupsummary.Checked;
            serializationOptions.SerializeSorting = this.s_sorting.Checked;
            serializationOptions.SerializeStackedHeaders = this.s_stackedheaders.Checked;
            serializationOptions.SerializeTableSummaries = this.s_tablesummary.Checked;
            serializationOptions.SerializeUnboundRows = this.s_unboundrows.Checked;
            return serializationOptions;
        }

        private DeserializationOptions deseralization()
        {
            deserializationOptions.DeserializeCaptionSummary = this.de_captionsummary.Checked;
            deserializationOptions.DeserializeColumns = this.de_columns.Checked;
            deserializationOptions.DeserializeFiltering = this.de_filtering.Checked;
            deserializationOptions.DeserializeGrouping = this.de_grouping.Checked;
            deserializationOptions.DeserializeGroupSummaries = this.de_groupsummary.Checked;
            deserializationOptions.DeserializeSorting = this.de_sorting.Checked;
            deserializationOptions.DeserializeStackedHeaders = this.de_stackedheaders.Checked;
            deserializationOptions.DeserializeStyle = this.de_styles.Checked;
            deserializationOptions.DeserializeTableSummaries = this.de_tablesummaries.Checked;
            deserializationOptions.DeserializeUnboundRows = this.de_unboundrows.Checked;
            return deserializationOptions;
        }

        private void btn_serialize_Click(object sender, EventArgs e)
        {
            using (FileStream fileStream = File.Create("grid.xml"))
            {
                this.sfDataGrid2.Serialize(fileStream, serialization());
            }
        }

        private void btn_deserialize_Click(object sender, EventArgs e)
        {
            if (File.Exists("grid.xml"))
            {
                using (FileStream fileStream = File.OpenRead("grid.xml"))
                {
                    this.sfDataGrid2.Deserialize(fileStream, deseralization());
                }
            }
        }

        private List<ProductDetails> _productInfo;

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
            northWind = new Northwind(FindFile(@"Common\Data\Northwind.sdf"));
            var ords = northWind.Products.Take(500);
            foreach (var em in ords)
            {
                var product = new ProductDetails();
                em.SupplierID += 1000;
                em.ProductID += 10000;

                product.CategoryID = (int)em.CategoryID;
                product.Discontinued = em.Discontinued;
                product.EnglishName = em.EnglishName;
                product.ProductID = em.ProductID;
                product.ProductName = em.ProductName;
                product.QuantityPerUnit = em.QuantityPerUnit;
                product.ReorderLevel = (short)em.ReorderLevel;
                product.SupplierID = (int)em.SupplierID;
                product.UnitPrice = (decimal)em.UnitPrice;
                product.UnitsInStock = (short)em.UnitsInStock;
                product.UnitsOnOrder = (short)em.UnitsOnOrder;
                productInfo.Add(product);
            }

            return productInfo;
        }

        private static string FindFile(string fileName)
        {
            // Check both in parent folder and Parent\Data folders.
            string dataFileName = @"Windows\Common\Data\" + fileName;
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
