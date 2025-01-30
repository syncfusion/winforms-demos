#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Collections.Generic;

namespace PivotGridGroupBarDemo
{
    #region Product Sales

    public class ProductSales
    {
        public string Product { get; set; }

        public string Year { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public int Quantity { get; set; }

        public double Amount { get; set; }

        public override string ToString()
        {
            return string.Format("{0}-{1}-{2}", Country, State, Product);
        }
    }
    #endregion

    #region Product Sales Collection

    //Retrieve the item source from the ProductSalesCollection
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
            string[] countries = { "Canada" };

            string[] canadaStates = { "Alberta", "British Columbia", "Ontario" };

            // Time
            string[] dates = { "FY 2005", "FY 2006", "FY 2007" };

            // Products
            string[] products = { "Bike", "Car" };

            Random r = new Random(123345345);

            int numberOfRecords = 2000;

            ProductSalesCollection listOfProductSales = new ProductSalesCollection();

            for (int i = 0; i < numberOfRecords; i++)
            {
                ProductSales sales = new ProductSales();

                sales.Country = countries[r.Next(0, countries.GetLength(0))];

                sales.Quantity = r.Next(1, 12);

                // 1 percent discount for 1 quantity

                double discount = (30000 * sales.Quantity) * (double.Parse(sales.Quantity.ToString()) / 100);

                sales.Amount = (30000 * sales.Quantity) - discount;

                sales.Year = dates[r.Next(r.Next(dates.GetLength(0) + 1))];

                sales.Product = products[r.Next(r.Next(products.GetLength(0) + 1))];

                sales.State = canadaStates[r.Next(canadaStates.GetLength(0))];

                listOfProductSales.Add(sales);

            }
            return listOfProductSales;
        }
    }
    
    #endregion
}