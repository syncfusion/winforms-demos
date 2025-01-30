#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.ObjectModel;

namespace FreezePanes
{
    /// <summary>
    /// Class contains sales details collection.
    /// </summary>
    public class SalesInfoCollection
    {
        public SalesInfoCollection()
        {
            _SalesDetails = GetSalesInfo();
        }

        private ObservableCollection<Salesinfo> _SalesDetails = null;

        public ObservableCollection<Salesinfo> YearlySalesDetails
        {
            get { return _SalesDetails; }
        }

        /// <summary>
        /// Gets the supplier info.
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<Salesinfo> GetSalesInfo()
        {
            var sales = new ObservableCollection<Salesinfo>();
            int i = 0;
            /// <summary>
            /// Collection of ProductNames
            /// </summary>
            string[] productName = new string[]
            {
            "Alice Mutton",
            "NuNuCa Nuß-Nougat-Creme",
            "Boston Crab Meat",
            "Raclette Courdavault",
            "Wimmers gute",
            "Gorgonzola Telino",
            "Chartreuse verte",
            "Fløtemysost",
            "Carnarvon Tigers",
            "Thüringer",
            "Vegie-spread",
            "Tarte au sucre",
            "Konbu",
            "Valkoinen suklaa",
            "Queso Manchego",
            "Perth Pasties",
            "Vegie-spread",
            "Tofu",
            "Sir Rodney's",
            "Manjimup Dried Apples"
            };

            var r = new Random();
            while (i < 60)
            {
                var salesByYear = new Salesinfo()
                {
                    Name = productName[r.Next(0, 11)],
                    January = r.Next(10000, 100000) * 0.01,
                    February = r.Next(10000, 100000) * 0.01,
                    March = r.Next(10000, 100000) * 0.01,
                    April = r.Next(10000, 100000) * 0.01,
                    May = r.Next(10000, 100000) * 0.01,
                    June = r.Next(10000, 100000) * 0.01,
                    July = r.Next(10000, 100000) * 0.01,
                    Auguest = r.Next(10000, 100000) * 0.01,
                    September = r.Next(10000, 100000) * 0.01,
                    October = r.Next(10000, 100000) * 0.01,
                    November = r.Next(10000, 100000) * 0.01,
                    December = r.Next(10000, 100000) * 0.01,
                    Year = r.Next(2000, 2010)
                };

                salesByYear.Total = salesByYear.January + salesByYear.February + salesByYear.March + salesByYear.April + salesByYear.May + salesByYear.June + salesByYear.July + salesByYear.Auguest + salesByYear.September + salesByYear.October + salesByYear.November + salesByYear.December;
                sales.Add(salesByYear);
                i++;
            }

            return sales;
        }
    }
}
