#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.ComponentModel;

namespace FreezePanes
{
    /// <summary>
    /// Sales details for an year. 
    /// </summary>
    public class Salesinfo : INotifyPropertyChanged
    {
        #region Fields

        private string name;
        private double january;
        private double february;
        private double march;
        private double april;
        private double may;
        private double june;
        private double july;
        private double auguest;
        private double september;
        private double october;
        private double november;
        private double december;
        private double _total;
        private int _year;

        #endregion

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Gets or sets the January.
        /// </summary>
        /// <value>The January.</value>
        public double January
        {
            get
            {
                return january;
            }
            set
            {
                january = value;
                OnPropertyChanged("January");
            }
        }

        /// <summary>
        /// Gets or sets the February.
        /// </summary>
        /// <value>The February.</value>
        public double February
        {
            get
            {
                return february;
            }
            set
            {
                february = value;
                OnPropertyChanged("February");
            }
        }

        /// <summary>
        /// Gets or sets the March.
        /// </summary>
        /// <value>The March.</value>
        public double March
        {
            get
            {
                return march;
            }
            set
            {
                march = value;
                OnPropertyChanged("March");
            }
        }

        /// <summary>
        /// Gets or sets the April.
        /// </summary>
        /// <value>The April.</value>
        public double April
        {
            get
            {
                return april;
            }
            set
            {
                april = value;
                OnPropertyChanged("April");
            }
        }

        /// <summary>
        /// Gets or sets the May.
        /// </summary>
        /// <value>The May.</value>
        public double May
        {
            get
            {
                return may;
            }
            set
            {
                may = value;
                OnPropertyChanged("May");
            }
        }

        /// <summary>
        /// Gets or sets the June.
        /// </summary>
        /// <value>The June.</value>
        public double June
        {
            get
            {
                return june;
            }
            set
            {
                june = value;
                OnPropertyChanged("June");
            }
        }

        /// <summary>
        /// Gets or sets the July.
        /// </summary>
        /// <value>The July.</value>
        public double July
        {
            get
            {
                return july;
            }
            set
            {
                july = value;
                OnPropertyChanged("July");
            }
        }

        /// <summary>
        /// Gets or sets the Auguest.
        /// </summary>
        /// <value>The Auguest.</value>
        public double Auguest
        {
            get
            {
                return auguest;
            }
            set
            {
                auguest = value;
                OnPropertyChanged("Auguest");
            }
        }

        /// <summary>
        /// Gets or sets the September.
        /// </summary>
        /// <value>The September.</value>
        public double September
        {
            get
            {
                return september;
            }
            set
            {
                september = value;
                OnPropertyChanged("September");
            }
        }

        /// <summary>
        /// Gets or sets the October.
        /// </summary>
        /// <value>The October.</value>
        public double October
        {
            get
            {
                return october;
            }
            set
            {
                october = value;
                OnPropertyChanged("October");
            }
        }

        /// <summary>
        /// Gets or sets the November.
        /// </summary>
        /// <value>The November.</value>
        public double November
        {
            get
            {
                return november;
            }
            set
            {
                november = value;
                OnPropertyChanged("November");
            }
        }

        /// <summary>
        /// Gets or sets the December.
        /// </summary>
        /// <value>The Q s6.</value>
        public double December
        {
            get
            {
                return december;
            }
            set
            {
                december = value;
                OnPropertyChanged("December");
            }
        }

        /// <summary>
        /// Gets or sets the total.
        /// </summary>
        /// <value>The total.</value>
        public double Total
        {
            get
            {
                return _total;
            }
            set
            {
                _total = value;
                OnPropertyChanged("Total");
            }
        }

        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        /// <value>The year.</value>
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
                OnPropertyChanged("Year");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
