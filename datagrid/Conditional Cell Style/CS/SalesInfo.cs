#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;

namespace ConditionalCellStyle
{
    public class SalesInfo
    {
        Random r = new Random();
        public SalesInfo()
        {
            this._SalesDetails = this.GetSalesInfo(100);
        }

        private ObservableCollection<SalesByYear> _SalesDetails = null;

        public ObservableCollection<SalesByYear> YearlySalesDetails
        {
            get { return _SalesDetails; }

        }

        /// <summary>
        /// Gets the supplier info.
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<SalesByYear> GetSalesInfo(int count)
        {
            var sales = new ObservableCollection<SalesByYear>();

            for (int i = 1; i <= count; i++)
            {
                sales.Add(GetSales(i));
            }

            return sales;
        }

        private SalesByYear GetSales(int i)
        {
            return new SalesByYear()
            {
                Name = employeeName[r.Next(employeeName.Count() - 1)],
                QS1 = qs1[r.Next(qs1.Count() - 2)],
                QS2 = qs2[r.Next(qs2.Count() - 5)],
                QS3 = qs3[r.Next(qs3.Count() - 3)],
                QS4 = qs4[r.Next(qs4.Count() - 1)],
                Total = total[r.Next(total.Count() - 5)],
                Year = year[r.Next(year.Count() - 2)],
            };
        }

        private double[] qs1 = new double[]
        {
            197483.8,
            456783.3,
            256869.5,
            1608979.2,
            786557.9,
            852476.1,
            109843.3,
            244359.5,
            474333.4,
            1398643.4,
            1593464.1,
            4535300.2,
        };

        private double[] qs2 = new double[]
        {
            197483.8,
            456783.3,
            256869.5,
            1608979.2,
            786557.9,
            852476.1,
            109843.3,
            244359.5,
            474333.4,
            1398643.4,
            1593464.1,
            4535300.2,
        };

        private double[] qs3 = new double[]
        {
            197483.8,
            456783.3,
            256869.5,
            1608979.2,
            786557.9,
            852476.1,
            109843.3,
            244359.5,
            474333.4,
            1398643.4,
            1593464.1,
            4535300.2,
        };

        private double[] qs4 = new double[]
        {
            197483.8,
            456783.3,
            256869.5,
            1608979.2,
            786557.9,
            852476.1,
            109843.3,
            244359.5,
            474333.4,
            1398643.4,
            1593464.1,
            4535300.2,
        };

        private double[] total = new double[]
        {
            11397483.8,
            3256783.3,
            2156869.5,
            14608979.2,
            7386557.9,
            8562476.1,
            1098743.3,
            2524359.5,
            4154333.4,
            13958643.4,
            155493464.1,
            450325300.2,
        };


        private int[] year = new int[]
        {
            2000,
            2001,
            2002,
            2003,
            2004,
            2005,
            2006,
            2007,
            2008,
            2009,
            2010
        };

        private string[] employeeName = new string[]
            {
                "Sean Jacobson",
                "Phyllis Allen",
                "Marvin Allen",
                "Michael Allen",
                "Cecil Allison",
                "Oscar Alpuerto",
                "Sandra Altamirano",
                "Selena Alvarad",
                "Emilio Alvaro",
                "Maxwell Amland",
                "Mae Anderson",
                "Ramona Antrim",
                "Sabria Appelbaum",
                "Hannah Arakawa",
                "Kyley Arbelaez",
                "Tom Johnston",
                "Thomas Armstrong",
                "John Arthur",
                "Chris Ashton",
                "Teresa Atkinson",
                "John Ault",
                "Robert Avalos",
                "Stephen Ayers",
                "Phillip Bacalzo",
                "Gustavo Achong",                
            };
    }
}
