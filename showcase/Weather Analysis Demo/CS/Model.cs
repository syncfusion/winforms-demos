#region Copyright Syncfusion Inc. 2001 - 2014
// Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WeatherAnalysis
{
    class WeatherData:INotifyPropertyChanged
    {
        private DateTime _Time;
        public DateTime Time
        {
            get { return _Time; }
            set { _Time = value; OnPropertyChanged("Time"); }
        }

        private string _weatherCondition;
        public string WeatherCondition
        {
            get { return _weatherCondition; }
            set { _weatherCondition = value; OnPropertyChanged("FeelsLike"); }
        }
        private string _Condition;
        public string SkyCondition
        {
            get { return _Condition; }
            set { _Condition = value; OnPropertyChanged("SkyCondition"); }
        }

        private Double _Temperature;
        public Double Temperature
        {
            get { return _Temperature; }
            set { _Temperature = value; OnPropertyChanged("Temperature"); }
        }

        private Double _Humidity;
        public Double Humidity
        {
            get { return _Humidity; }
            set { _Humidity = value; OnPropertyChanged("Humidity"); }
        }

        private string _DewPoint;
        public string DewPoint
        {
            get { return _DewPoint; }
            set { _DewPoint = value; OnPropertyChanged("DewPoint"); }
        }

        private Double _Wind;
        public Double Wind
        {
            get { return _Wind; }
            set { _Wind = value; OnPropertyChanged("Wind"); }
        }
       
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }
    }
}
