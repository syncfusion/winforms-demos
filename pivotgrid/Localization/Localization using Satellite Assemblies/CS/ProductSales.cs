#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Collections.Generic;

namespace LocalizationDemo
{
    #region Product Sales

    public class ProductSales
    {
        #region "API Definition"

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
        /// return the string format 
        /// </summary>
        public override string ToString()
        {
            return string.Format("{0}-{1}-{2}", Country, State, Product);
        }

    }
    #endregion

    #region Product Sales Collection

    public class ProductSalesCollection : List<ProductSales>
    {

    }

    #endregion

    #region Product Sales Data

    class ProductSalesData
    {
        /// <summary>
        /// Data collections for Data Source
        /// </summary>
        /// <returns></returns>
        public static ProductSalesCollection GetSalesData()
        {
            // Geography
            string[] countries = { "Australien", "Kanada", "Frankreich", "Deutschland", "Vereinigtes Königreich", "Vereinigte Staaten" };
            string[] ausStates = { "New South Wales", "Queensland", "South Australia", "Tasmania", "Victoria" };
            string[] canadaStates = { "Albertaien", "Britisch-Kolumbien", "Braunschweig", "Manitoba", "Ontario", "Quebec" };
            string[] franceStates = { "Charente Maritime", "Essonne", "Garonne (Haute)", "Gers" };
            string[] germanyStates = { "Bayern", "Brandenburg", "Hamburg", "Hessen", "Nordrhein Westfalen", "Saarland" };
            string[] ukStates = { "England" };
            string[] ussStates = { "New York", "North Carolina", "Alabama", "California", "Colorado", "New Mexico", "South Carolina" };

            // Time
            string[] dates = { "Geschäf 2005", "Geschäf  2006", "Geschäf  2007", "Geschäf  2008", "Geschäf  2009" };

            // Products
            string[] products = { "Fahrrad", "Auto" };

            Random r = new Random(123345345);

            int numberOfRecords = 2000;

            ProductSalesCollection listOfProductSales = new ProductSalesCollection();

            for (int i = 0; i < numberOfRecords; i++)
            {
                ProductSales sales = new ProductSales();
                sales.Country = countries[r.Next(1, countries.GetLength(0))];
                sales.Quantity = r.Next(1, 12);

                // 1 percent discount for 1 quantity
                double discount = (300 * sales.Quantity) * (double.Parse(sales.Quantity.ToString()) / 100);
                sales.Amount = (300 * sales.Quantity) - discount;
                sales.TotalPrice = sales.Amount * sales.Quantity;
                sales.UnitPrice = sales.Amount / sales.Quantity;
                sales.Date = dates[r.Next(r.Next(dates.GetLength(0) + 1))];
                sales.Product = products[r.Next(r.Next(products.GetLength(0) + 1))];
                switch (sales.Country)
                {
                    case "Australien":
                        {
                            sales.State = ausStates[r.Next(ausStates.GetLength(0))];
                            break;
                        }
                    case "Kanada":
                        {
                            sales.State = canadaStates[r.Next(canadaStates.GetLength(0))];
                            break;
                        }
                    case "Frankreich":
                        {
                            sales.State = franceStates[r.Next(franceStates.GetLength(0))];
                            break;
                        }
                    case "Deutschland":
                        {
                            sales.State = germanyStates[r.Next(germanyStates.GetLength(0))];
                            break;
                        }
                    case "Vereinigtes Königreich":
                        {
                            sales.State = ukStates[r.Next(ukStates.GetLength(0))];
                            break;
                        }
                    case "Vereinigte Staaten":
                        {
                            sales.State = ussStates[r.Next(ussStates.GetLength(0))];
                            break;
                        }
                }
                listOfProductSales.Add(sales);
            }
            return listOfProductSales;
        }
    }

    #endregion
}