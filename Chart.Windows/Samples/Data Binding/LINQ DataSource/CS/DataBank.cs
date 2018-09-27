using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ChartDataBinding
{
    #region Populating DataBase
    public class PopulationDataService
    {
        private static PopulationData[] populationData;
        
        //Populate Database
        public static void PopulateDataBase()
        {
            //We can use the Database to have these details 
            populationData = new PopulationData[6];
            populationData[0] = new PopulationData("New York", 13);
            populationData[1] = new PopulationData("Houston", 6);
            populationData[2] = new PopulationData("Tokyo", 15);
            populationData[3] = new PopulationData("London", 12);
            populationData[4] = new PopulationData("Chicago", 18);
            populationData[5] = new PopulationData("Los Angeles", 11);
        }

        public static PopulationData[] GetCompleteList()
        {
            return populationData;
        }

        //LINQ statement to fetch top 3 cities by their population.
        public static object GetFilteredData()
        {
            var data =

                (from e in populationData

                orderby e.Population descending
                
                select new PopulationData(e.City.ToString(), e.Population)).Take(3);
            
            return data.ToList();
        }
    }
    #endregion

    #region Designing Database
    public class PopulationData
    {
        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        private double population;

        public double Population
        {
            get { return population; }
            set { population = value; }
        }

        public PopulationData(string city, double population)
        {
            this.city = city;
            this.population = population;
        }
    }
    #endregion
}
