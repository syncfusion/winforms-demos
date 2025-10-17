#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace HeatMap
{
    public class Country : INotifyPropertyChanged
    {
        public string NAME { get; set; }

        private double weather { get; set; }
        public double Weather
        {
            get
            {
                return weather;
            }
            set
            {
                weather = value;
            }
        }

        private double population { get; set; }
        public double Population
        {
            get
            {
                return population;
            }
            set
            {
                population = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Population"));
            }

        }
        public string PopulationFormat { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            this.PopulationFormat = (String.Format("{0:0,0}", this.Population).Trim('$'));
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }
    }

    public class Model
    {
        public string Name { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public ObservableCollection<string> Tasks { get; set; }
        public string Address { get; set; }
    }

    public class Countries
    {
        public Countries()
        {
        }
        #region Properties
        public string Continent { get; set; }
        public string Country { get; set; }

        public ShapeProperty ShapeCollection { get; set; }
        #endregion
    }

    public class Continents
    {
        public string NAME { get; set; }
    }

    public class ShapeProperty
    {
        public ShapeProperty()
        {
        }

        public String Country { get; set; }
        public String Uri { get; set; }
        public String ShapeFill { get; set; }
    }

    public class Population
    {
        public string Name { get; set; }
        public double Populations { get; set; }
    }
}
