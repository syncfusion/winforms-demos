#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.PivotAnalysis.Base;
using Syncfusion.Windows.Forms.PivotChart;
using Syncfusion.Windows.Forms;
using System.Reflection;
using Syncfusion.Windows.Forms.PivotAnalysis;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.WinForms.Controls;

namespace PivotChartTypes_Demo
{
    public partial class FieldList : SfForm
    {
        public FieldList()
        {
            InitializeComponent(); 
            
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }

            this.pivotChart1 = new PivotChart();
            this.pivotChart1.Dock = DockStyle.Top;
            this.chart.Controls.Add(this.pivotChart1);

            // Adding ItemSource to the Control
            this.pivotChart1.ItemSource = ProductSales.GetSalesData();
            // Adding PivotAxis to the Control
            this.pivotChart1.PivotAxis.Add(new PivotItem { FieldMappingName = "Product", TotalHeader="Total" });
            this.pivotChart1.PivotAxis.Add(new PivotItem { FieldMappingName = "Country", TotalHeader="Total"  });
            this.pivotChart1.PivotAxis.Add(new PivotItem { FieldMappingName = "State", TotalHeader="Total" });

            // Adding PivotLegend to the Control
            this.pivotChart1.PivotLegend.Add(new PivotItem { FieldMappingName = "Date", TotalHeader = "Total" });

            // Adding PivotCalculations to the Control
            this.pivotChart1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Quantity", Format = "#,##0" });
            this.pivotChart1.Skins = Syncfusion.Windows.Forms.Chart.Skins.Metro;
            this.pivotChart1.PivotEngine.PivotSchemaChanged += PivotEngine_PivotSchemaChanged;

            this.pivotGrid1.PivotEngine = this.pivotChart1.PivotEngine;
            this.pivotGrid1.Dock = DockStyle.Bottom;           
            this.pivotGrid1.GridVisualStyles = GridVisualStyles.Metro;
           
            this.pivotChart1.ShowPivotTableFieldList = true;
            this.pivotChart1.ShowLegend = true;
            this.pivotChart1.AllowDrillDown = true;
            this.chart.BorderStyle = BorderStyle.FixedSingle;
            this.grid.Padding = new Padding(1);

            this.MinimumSize = new Size(800, 650);
        }

        private void PivotEngine_PivotSchemaChanged(object sender, PivotSchemaChangedArgs e)
        {
            if (this.pivotGrid1.TableControl.Model != null && this.pivotGrid1.TableControl.Model.CoveredRanges != null)
            {
                this.pivotGrid1.TableControl.Model.CoveredRanges.Clear();
                foreach (var range in this.pivotGrid1.PivotEngine.CoveredRanges)
                    this.pivotGrid1.TableControl.Model.CoveredRanges.Add(GridRangeInfo.Cells(range.Top + 1, range.Left + 1,range.Bottom + 1, range.Right + 1));
               
            }
            this.pivotGrid1.TableControl.InvalidateCells();
        }

        #region "ICON FILE"

        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
        }

        #endregion

        #region "DATASOURCE"

        public class ProductSales
        {
            public string Product { get; set; }

            public string Date { get; set; }

            public string Country { get; set; }

            public string State { get; set; }

            public int Quantity { get; set; }

            public double Amount { get; set; }

            public double UnitPrice { get; set; }

            public double TotalPrice { get; set; }

            public static ProductSalesCollection GetSalesData()
            {
                /// Geography
                string[] countries = new string[] { "Australia","Canada", "Germany", "United States" };
                string[] ausStates = new string[] { "New South Wales", "Queensland", };
                string[] canadaStates = new string[] { "Saskatchewan", "Quebec" };
                string[] germanyStates = new string[] { "Bayern", "Brandenburg" };
                string[] ussStates = new string[] {"New Mexico" };

                /// Time
                string[] dates = new string[] { "FY 2008", "FY 2009", "FY 2010", "FY 2011", "FY 2012" };

                /// Products
                string[] products = new string[] { "Bike" };
                Random r = new Random(123345);

                int numberOfRecords = 2000;
                ProductSalesCollection listOfProductSales = new ProductSalesCollection();
                for (int i = 0; i < numberOfRecords; i++)
                {
                    ProductSales sales = new ProductSales();
                    sales.Country = countries[r.Next(1, countries.GetLength(0))];
                    sales.Quantity = r.Next(1, 12);
                    /// 1 percent discount for 1 quantity
                    double discount = (30000 * sales.Quantity) * (double.Parse(sales.Quantity.ToString()) / 100);
                    sales.Amount = (30000 * sales.Quantity) - discount;
                    sales.TotalPrice = sales.Amount * sales.Quantity;
                    sales.UnitPrice = sales.Amount / sales.Quantity;
                    sales.Date = dates[r.Next(r.Next(dates.GetLength(0) + 1))];
                    sales.Product = products[r.Next(r.Next(products.GetLength(0) + 1))];
                    switch (sales.Country)
                    {
                        case "Australia":
                            {
                                sales.State = ausStates[r.Next(ausStates.GetLength(0))];
                                break;
                            }
                        case "Canada":
                            {
                                sales.State = canadaStates[r.Next(canadaStates.GetLength(0))];
                                break;
                            }
                        case "Germany":
                            {
                                sales.State = germanyStates[r.Next(germanyStates.GetLength(0))];
                                break;
                            }
                        case "United States":
                            {
                                sales.State = ussStates[r.Next(ussStates.GetLength(0))];
                                break;
                            }
                    }
                    listOfProductSales.Add(sales);
                }

                return listOfProductSales;
            }

            public override string ToString()
            {
                return string.Format("{0}-{1}-{2}", this.Country, this.State, this.Product);
            }

            public class ProductSalesCollection : List<ProductSales>
            {
            }
        }
        #endregion

        private PivotChart pivotChart1;
    }
}
