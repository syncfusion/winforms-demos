#region Copyright Syncfusion Inc. 2001 - 2014
// Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;

namespace SalesAnalysisDemo
{
    public class SalesDetail
    {

        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string Country { get; set; }
        public double OrderTotal { get; set; }
        public string Continent { get; set; }
        public DateTime OrderDate { get; set; }
        public float SalesPercent { get; set; }

        //Generates the sales details for each products, countries and for every day.
        public static ObservableCollection<SalesDetail> GenerateSalesDetails(DateTime startDate, DateTime endDate)
        {
            string[] products = new string[] { "Tablet", "Desktop", "Hybrid", "Laptop", "Smartphone" };
            ObservableCollection<SalesDetail> details = new ObservableCollection<SalesDetail>();
            ObservableCollection<Countries> countryList = Countries.GetCountries();
            double value = 1000;
            double nextvalue = 10000;
            Random rand = new Random();

            while (startDate < endDate)
            {
                if (rand.NextDouble() > .5)
                {
                    value += rand.Next(100, 1000);
                    nextvalue += rand.NextDouble();
                }
                else
                {
                    value -= rand.NextDouble();
                    nextvalue -= rand.NextDouble();
                }
                Countries country = new Countries();

                float salespercent = 0;
                for (int i = 0; i < products.Length; i++)
                    salespercent = rand.Next(100,300);
                foreach(string product in products)
                {
                    country = countryList[rand.Next(0, (countryList.Count) - 1)];
                    details.Add(new SalesDetail
                    {
                        ProductName = product,
                        Quantity = (int)value,
                        Country = country.Country,
                        Continent = country.Continent,
                        OrderTotal = (int)nextvalue,
                        OrderDate = startDate,
                        SalesPercent=salespercent

                    });
                }
                startDate = startDate.AddDays(1);
            }
            return details;
        }
        public static ObservableCollection<ProductVsCountry> GenerateProductVsCountry(ObservableCollection<SalesDetail> salesDetails)//,ObservableCollection<SalesVsTarget> sale)
        {
            Random rand = new Random();
            ObservableCollection<ProductVsCountry> productVscountry = new ObservableCollection<ProductVsCountry>();
            ObservableCollection<Countries> countryList = Countries.GetCountries();
            ObservableCollection<SalesVsTarget> sales=GenerateTotalSalesVsTargetList(salesDetails);
            string[] labels = { "Tablet", "Desktop", "Hybrid", "Laptop", "Smartphone" };
            var query = from saleD in salesDetails group saleD by saleD.Country into grouping select grouping;
            Countries countries = new Countries();
            List<ProductVsCountry> data = new List<ProductVsCountry>();
            SalesVsTarget salesVsTargets = new SalesVsTarget();
            Random r=new Random();
            float salespercent=0;
            for (int i = 0; i < labels.Length; i++)
                salespercent = r.Next(10, 95);
                
            foreach (IGrouping<string, SalesDetail> groupedRecord in query)
            {
                double market = r.NextDouble();
                market = Math.Round(market, 2);
                //SalesByContinet salesVsTarget = new SalesByContinet();
                sales = SalesDetail.GenerateTotalSalesVsTargetList(salesDetails);
                countries = countryList[rand.Next(0, (countryList.Count) - 1)];
                productVscountry.Add(new ProductVsCountry
                {
                    country = countries.Country,
                    continent = countries.Continent,
                    MarketingVsRevenue = market,
                    SalesPercent=salespercent
                });
            }
            return productVscountry;

        }
        //Generates the total(entire world) sales vs target list for given period and grouped by Month.
        public static ObservableCollection<SalesVsTarget> GenerateTotalSalesVsTargetList(ObservableCollection<SalesDetail> salesDetails)
        {
            ObservableCollection<SalesVsTarget> salesVsTargetList = new ObservableCollection<SalesVsTarget>();
            var query = from sales in salesDetails group sales by sales.OrderDate.Month into grouping select grouping;
            Random rand = new Random();
            double value = 20;
            double nextvalue = 40;
            foreach (SalesDetail groupedRecord in salesDetails)
            {
                if (rand.NextDouble() > .5)
                {
                    value += rand.NextDouble();
                    nextvalue += rand.NextDouble();
                }
                else
                {
                    value -= rand.NextDouble();
                    nextvalue -= rand.NextDouble();
                }
                SalesVsTarget salesVsTarget = new SalesVsTarget();

                salesVsTarget.Month = groupedRecord.OrderDate.Month;
                salesVsTarget.Date = groupedRecord.OrderDate;
                salesVsTarget.Sales = groupedRecord.OrderTotal * nextvalue;
                salesVsTarget.Target = ((salesVsTarget.Sales * value) / 100) + salesVsTarget.Sales;
                salesVsTarget.SalesPercent = (salesVsTarget.Sales / salesVsTarget.Target) * 100;
                salesVsTargetList.Add(salesVsTarget);
            }

            return salesVsTargetList;
        }

        //Generates the total sales vs target list of given continent for given period and grouped by month.
        public static ObservableCollection<SalesVsTarget> GenerateTotalSalesVsTargetListByContinent(ObservableCollection<SalesDetail> salesDetails, string continent)
        {
            ObservableCollection<SalesVsTarget> salesVsTargetList = new ObservableCollection<SalesVsTarget>();
            var query = from sales in salesDetails where sales.Continent == continent group sales by sales.OrderDate.Month into grouping select grouping;
            Random rand = new Random();
            foreach (IGrouping<int, SalesDetail> groupedRecord in query)
            {
                SalesVsTarget salesVsTarget = new SalesVsTarget();

                salesVsTarget.Month = groupedRecord.Key;
                salesVsTarget.Date = groupedRecord.ElementAt(groupedRecord.Key).OrderDate;
                salesVsTarget.Sales = groupedRecord.Sum(s => s.OrderTotal);
                salesVsTarget.Target = ((salesVsTarget.Sales * rand.Next(-10, 30)) / 100) + salesVsTarget.Sales;
                salesVsTarget.SalesPercent = (salesVsTarget.Sales / salesVsTarget.Target) * 100;
                salesVsTargetList.Add(salesVsTarget);
            }

            return salesVsTargetList;
        }
        public static ObservableCollection<SalesByContinet> GenerateTotalSalesVsTargetListByContinent(ObservableCollection<SalesDetail> salesDetails)
        {
            ObservableCollection<SalesByContinet> salesVsTargetList = new ObservableCollection<SalesByContinet>();
            var query = from sales in salesDetails group sales by sales.Continent into grouping select grouping;
            Random rand = new Random();
            foreach (IGrouping<string, SalesDetail> groupedRecord in query)
            {
                SalesByContinet salesVsTarget = new SalesByContinet();
                salesVsTarget.Continent = groupedRecord.Key;
                salesVsTarget.Sales = groupedRecord.Sum(s => s.OrderTotal);
               
                salesVsTarget.Target = ((salesVsTarget.Sales * rand.Next(-10, 30)) / 100) + salesVsTarget.Sales;
                salesVsTarget.SalesPercent = (salesVsTarget.Sales / salesVsTarget.Target) * 100;
                salesVsTargetList.Add(salesVsTarget);
            }

            return salesVsTargetList;
        }
        
        public static ObservableCollection<SalesByCountry> GenerateTotalSalesVsTargetListByCountry(ObservableCollection<SalesDetail> salesDetails)
        {
            ObservableCollection<SalesByCountry> salesVsTargetList = new ObservableCollection<SalesByCountry>();
            var query = from sales in salesDetails group sales by sales.Country into grouping select grouping;
            Random rand = new Random();
            string[] products = new string[] { "Tablet", "Desktop", "Hybrid", "Laptop", "Smartphone" };
            foreach (IGrouping<string, SalesDetail> groupedRecord in query)
            {
                SalesDetail sal = new SalesDetail();
                SalesByCountry salesVsTarget = new SalesByCountry();
                ObservableCollection<SalesByProductInCountry> productsCollection = new ObservableCollection<SalesByProductInCountry>();
                salesVsTarget.Country = groupedRecord.Key;
                salesVsTarget.Sales = groupedRecord.Sum(s => s.OrderTotal);
                foreach (string product in products)
                {
                    SalesByProductInCountry productSales = new SalesByProductInCountry();
                    productSales.Name = product;
                    foreach (SalesDetail salesDetail in salesDetails)
                    {
                        if (salesDetail.ProductName == product && salesDetail.Country == salesVsTarget.Country)
                            productSales.Sales += salesDetail.OrderTotal;
                    }
                    productsCollection.Add(productSales);
                }
                salesVsTarget.Quantity = sal.Quantity ;
                salesVsTarget.product = sal.ProductName;
                salesVsTarget.Target = ((salesVsTarget.Sales * rand.Next(-10, 30)) / 100) + salesVsTarget.Sales;
                salesVsTarget.SalesPercent =(float) (salesVsTarget.Sales / salesVsTarget.Target) * 100;
                salesVsTargetList.Add(salesVsTarget);
            }

            return salesVsTargetList;
        }
    }

    public class SalesByProductInCountry
    {
        public string Name { get; set; }
        public double Sales { get; set; }
    }

    public class SalesByContinet
    {
        public string Continent { get; set; }
        public int Month { get; set; }
        public double Sales { get; set; }
        public double Target { get; set; }
        public double SalesPercent { get; set; }
        public string DisplaySalesValue { get; set; }
    }
    public class SalesByCountry
    {
        public string Country { get; set; }
        public int Month { get; set; }
        public double Sales { get; set; }
        public double Target { get; set; }
        public float SalesPercent { get; set; }
        public int Quantity { get; set; }
        public string product { get; set; }
        public ObservableCollection<SalesByProductInCountry> Products { get; set; }
    }

    public class SalesVsTarget
    {
        public int Month { get; set; }
        public DateTime Date { get; set; }
        public double Sales { get; set; }
        public double Target { get; set; }
        public double SalesPercent { get; set; }
        public string MonthName { get { return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Month).Substring(0, 3); } }

    }
    public class ProductVsCountry
    {
        public string country { get; set; }
        public string continent { get; set;}
        public double MarketingVsRevenue { get; set; }
        public float SalesPercent { get; set; }
    }
}

