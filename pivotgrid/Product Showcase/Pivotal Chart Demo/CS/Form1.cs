#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Collections.Generic;
using System.Drawing;
using Syncfusion.PivotAnalysis.Base;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.GridHelperClasses;
using Syncfusion.Windows.Forms;

namespace PivotalChartDemo
{
    public partial class Form1 : MetroForm
    {
        #region Constructor

        public Form1()
        {
            InitializeComponent();
            GridSetting();
        }

        #endregion

        #region Pivot Grid Settings

        private void GridSetting()
        {
            // Adding ItemSource to the Control
            this.pivotGridControl1.ItemSource = ProductSales.GetSalesData();

            // Adding PivotRows to the Control
            this.pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Product", TotalHeader = "Total" });

            this.pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Date", TotalHeader = "Total" });

            // Adding PivotColumns to the Control
            this.pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "Country", TotalHeader = "Total" });

            this.pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "State", TotalHeader = "Total" });

            // Adding PivotCalculations to the Control
            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Quantity", Format = "#,##0" });
            this.pivotGridControl1.TableModel.Options.AllowSelection = GridSelectionFlags.Any;
            this.chartControl1.Text = "ProductSales";

            //PivotChartHelper class acts as an interface to bind the datafrom grid to chart.
            PivotGridChartHelper helper = new PivotGridChartHelper();
            helper.WireGrid(this.pivotGridControl1, this.chartControl1);

            //Appearance of the Chart Control.
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            this.chartControl1.Series[0].PrepareStyle += new ChartPrepareStyleInfoHandler(Form1_PrepareStyle);

            //PivotGrid control selection customization
            GridRangeInfo selRange = GridRangeInfo.Cells(4, 4, 5, 5);
            this.pivotGridControl1.TableModel.Selections.Add(selRange);
            GridSelectionChangedEventArgs e = new GridSelectionChangedEventArgs(selRange, null, GridSelectionReason.MouseUp);
            this.pivotGridControl1.TableModel.RaiseSelectionChanged(e);
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Set the Style based on Index
        /// </summary>
        void Form1_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
        {
            ChartSeries series = this.chartControl1.Series[0];
            if (series != null)
            {
                if (args.Index == 0)
                    args.Style.Interior = new BrushInfo(Color.FromArgb(175, 41, 158, 214));
                else if (args.Index == 1)
                    args.Style.Interior = new BrushInfo(Color.FromArgb(175, 206, 215, 41));
                else if (args.Index == 2)
                    args.Style.Interior = new BrushInfo(Color.FromArgb(175, 255, 186, 0));
                else if (args.Index == 3)
                    args.Style.Interior = new BrushInfo(Color.FromArgb(175, 247, 125, 16));
                else if (args.Index == 4)
                    args.Style.Interior = new BrushInfo(Color.FromArgb(175, 129, 115, 27));
                else if (args.Index == 5)
                    args.Style.Interior = new BrushInfo(Color.FromArgb(175, 255, 136, 23));
                else if (args.Index == 6)
                    args.Style.Interior = new BrushInfo(Color.FromArgb(175, 246, 100, 15));
                else if (args.Index == 7)
                    args.Style.Interior = new BrushInfo(Color.FromArgb(175, 188, 200, 6));
                else if (args.Index == 8)
                    args.Style.Interior = new BrushInfo(Color.FromArgb(175, 234, 90, 81));
                else if (args.Index == 9)
                    args.Style.Interior = new BrushInfo(Color.FromArgb(175, 191, 192, 98));
            }
        }

        #endregion

        #region Data Source

        public class ProductSales
        {
            #region API Definition

            public string Product { get; set; }

            public string Date { get; set; }

            public string Country { get; set; }

            public string State { get; set; }

            public int Quantity { get; set; }

            public double Amount { get; set; }

            public double UnitPrice { get; set; }

            public double TotalPrice { get; set; }

            #endregion

            /// <summary>
            /// Generate a data for Grid
            /// </summary>
            public static ProductSalesCollection GetSalesData()
            {
                // Geography
                string[] countries = new string[] { "Australia", "Canada", "France"/*, "Germany", "United Kingdom", "United States"*/ };
                string[] ausStates = new string[] { "New South Wales", "Queensland", "South Australia", "Tasmania", "Victoria" };
                string[] canadaStates = new string[] { "Alberta", "British Columbia", "Brunswick", "Manitoba", "Ontario", "Quebec" };
                string[] franceStates = new string[] { "Charente Maritime", "Essonne", "Garonne (Haute)", "Gers", };
                string[] germanyStates = new string[] { "Bayern", "Brandenburg", "Hamburg", "Hessen", "Nordrhein Westfalen", "Saarland" };
                string[] ukStates = new string[] { "England" };
                string[] ussStates = new string[] { "New York", "North Carolina", "Alabama", "California", "Colorado", "New Mexico", "South Carolina" };

                // Time
                string[] dates = new string[] { "FY 2005", "FY 2006", "FY 2007", "FY 2008", "FY 2009" };

                // Products
                string[] products = new string[] { "Bike", "Car" };
                Random r = new Random(123345345);

                int numberOfRecords = 2000;
                ProductSalesCollection listOfProductSales = new ProductSalesCollection();
                for (int i = 0; i < numberOfRecords; i++)
                {
                    ProductSales sales = new ProductSales();
                    sales.Country = countries[r.Next(1, countries.GetLength(0))];
                    sales.Quantity = r.Next(1, 12);
                    // 1 percent discount for 1 quantity
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
                        case "France":
                            {
                                sales.State = franceStates[r.Next(franceStates.GetLength(0))];
                                break;
                            }
                        case "Germany":
                            {
                                sales.State = germanyStates[r.Next(germanyStates.GetLength(0))];
                                break;
                            }
                        case "United Kingdom":
                            {
                                sales.State = ukStates[r.Next(ukStates.GetLength(0))];
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
    }
}