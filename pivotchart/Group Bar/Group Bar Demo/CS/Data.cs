#region Copyright Syncfusion Inc. 2001 - 2018.
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Collections.Generic;

namespace GroupBarDemo
{
    #region Data

    /// <summary>
    /// Custom Data class
    /// </summary>
    public class Data
    {
        #region Constructor
        public Data()
        {
        }
        #endregion

        #region Properties
        public string City { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public string Profession { get; set; }

        public int Salary { get; set; }

        public string State { get; set; }

        public bool Married { get; set; }

        public int Children { get; set; }

        public int Siblings { get; set; }

        public double CCDebt { get; set; }
        #endregion
    }

    #endregion

    #region Data Collection

    /// <summary>
    /// Custom DataCollection
    /// </summary>
    public class DataCollection : List<Data>
    {
        #region Constructor
        public DataCollection()
        {
            this.GetDataObjects(2000);
        }
        #endregion

        #region GetDataObject
        private void GetDataObjects(int items)
        {
            #region Get the DataSource
            int nRows = items;
            Random r = new Random(123345345);

            string[] sexes = new string[] { "Male", "Female" };
            string[] jobs = new string[] { "Doctor", "Teacher", "Engineer" };
            string[] states = new string[] { "New York", "Virginia", "Alaska", "Texas" };
            string[] NCcities = new string[] { "Raleigh", "Charlotte" };
            string[] GAcities = new string[] { "Augusta" };
            string[] VAcities = new string[] { "Norfolk" };
            string[] SCcities = new string[] { "Clemson" };

            for (int i = 0; i < nRows; ++i)
            {
                Data dataObj = new Data();
                dataObj.City = sexes[r.Next(sexes.GetLength(0))];
                dataObj.Gender = sexes[r.Next(sexes.GetLength(0))];
                dataObj.Age = r.Next(45) + 20;
                dataObj.Profession = jobs[r.Next(jobs.GetLength(0))];
                dataObj.Salary = 15000 + (int)(r.NextDouble() * 1000);
                dataObj.State = states[r.Next(states.GetLength(0))];
                int k = "NCSCVAGA".IndexOf(dataObj.State);
                switch (k)
                {
                    case 0:
                        dataObj.City = NCcities[r.Next(NCcities.GetLength(0))];
                        break;
                    case 2:
                        dataObj.City = SCcities[r.Next(SCcities.GetLength(0))]; ;
                        break;
                    case 6:
                        dataObj.City = GAcities[r.Next(GAcities.GetLength(0))];
                        break;
                    case 4:
                        dataObj.City = VAcities[r.Next(VAcities.GetLength(0))];
                        break;
                }
                dataObj.Married = r.Next(3) == 1;

                dataObj.Children = (bool)dataObj.Married ? r.Next(6) : 0;

                dataObj.Siblings = r.Next(7); ;

                dataObj.CCDebt = ((int)(r.NextDouble() * 2000000)) / 100d;

                this.Add(dataObj);
            }
            #endregion
        }
        #endregion
    }

    #endregion
}
