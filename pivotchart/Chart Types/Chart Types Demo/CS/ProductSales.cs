#region Copyright Syncfusion Inc. 2001 - 2018.
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Collections.Generic;

namespace ChartTypesDemo
{
    #region Product Sales

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

        public override string ToString()
        {
            return string.Format("{0}-{1}-{2}", this.Country, this.State, this.Product);
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
        public static ProductSalesCollection GetSalesData()
        {
            // Geography
            string[] countries = new string[] { "Australia", "Germany", "Canada", "United States" };
            string[] ausStates = new string[] { "New South Wales", "Queensland", };
            string[] canadaStates = new string[] { "Saskatchewan", "Quebec" };
            string[] germanyStates = new string[] { "Bayern", "Brandenburg" };
            string[] ussStates = new string[] { "New York", "Colorado", "New Mexico" };

            // Time
            string[] dates = new string[] { "FY 2008", "FY 2009", "FY 2010", "FY 2011", "FY 20012" };

            // Products
            string[] products = new string[] { "Bike" };
            Random r = new Random(123345);

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

    }

    #endregion
}
