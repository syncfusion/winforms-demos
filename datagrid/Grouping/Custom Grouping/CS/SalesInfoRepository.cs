#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CustomGrouping
{
    public class SalesInfoRepository
    {
        private readonly List<string> _salesParsonNames = new List<string>()
            {
                "Gary Drury",
                "Maciej Dusza",
                "Shelley Dyck",
                "Linda Ecoffey",
                "Carla Eldridge",
                "Carol Elliott",
                "Shannon Elliott",
                "Jauna Elson",
                "Michael Emanuel",
                "Terry Eminhizer",
                "John Emory",
                "Gail Erickson",
                "Mark Erickson",
                "Martha Espinoza",
                "Julie Estes",
                "Janeth Esteves",
                "Twanna Evans"
            };

        public ObservableCollection<SalesByDate> GetSalesDetailsByDay(int days)
        {
            var collection = new ObservableCollection<SalesByDate>();
            var r = new Random();
            for (var i = 0; i < days; i++)
            {
                var dt = DateTime.Now;
                foreach (var person in _salesParsonNames)
                {
                    if (r.Next(0, 3) == 0) continue;
                    var s = new SalesByDate
                        {
                            Name = person,
                            QS1 = r.Next(100000, 1000000) * 0.01,
                            QS2 = r.Next(100000, 1000000) * 0.01,
                            QS3 = r.Next(100000, 1000000) * 0.01,
                            QS4 = r.Next(100000, 1000000) * 0.01,
                            QS5 = r.Next(100000, 1000000) * 0.01,
                            QS6 = r.Next(100000, 1000000) * 0.01,
                        };

                    s.Total = s.QS1 + s.QS2 + s.QS3 + s.QS4 + s.QS5 + s.QS6;
                    s.Date = dt.AddDays(-1 * i);
                    collection.Add(s);
                }
            }
            return collection;
        }
    }

    public class SalesByDate : INotifyPropertyChanged
    {
        private string _name;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        private double _qS1;

        /// <summary>
        /// Gets or sets the Q s1.
        /// </summary>
        /// <value>The Q s1.</value>
        [DataType(DataType.Currency)]
        public double QS1
        {
            get
            {
                return _qS1;
            }
            set
            {
                _qS1 = value;
                OnPropertyChanged("QS1");
            }
        }

        private double _qS2;

        /// <summary>
        /// Gets or sets the Q s2.
        /// </summary>
        /// <value>The Q s2.</value>
        [DataType(DataType.Currency)]
        public double QS2
        {
            get
            {
                return _qS2;
            }
            set
            {
                _qS2 = value;
                OnPropertyChanged("QS2");
            }
        }

        private double _qS3;

        /// <summary>
        /// Gets or sets the Q s3.
        /// </summary>
        /// <value>The Q s3.</value>
        [DataType(DataType.Currency)]
        public double QS3
        {
            get
            {
                return _qS3;
            }
            set
            {
                _qS3 = value;
                OnPropertyChanged("QS3");
            }
        }

        private double _qS4;

        /// <summary>
        /// Gets or sets the Q s4.
        /// </summary>
        /// <value>The Q s4.</value>
        [DataType(DataType.Currency)]
        public double QS4
        {
            get
            {
                return _qS4;
            }
            set
            {
                _qS4 = value;
                OnPropertyChanged("QS4");
            }
        }

        private double _qS5;

        /// <summary>
        /// Gets or sets the Q s5.
        /// </summary>
        /// <value>The Q s5.</value>
        [DataType(DataType.Currency)]
        public double QS5
        {
            get
            {
                return _qS5;
            }
            set
            {
                _qS5 = value;
                OnPropertyChanged("QS5");
            }
        }

        private double _qS6;

        /// <summary>
        /// Gets or sets the Q s6.
        /// </summary>
        /// <value>The Q s6.</value>
        [DataType(DataType.Currency)]
        public double QS6
        {
            get
            {
                return _qS6;
            }
            set
            {
                _qS6 = value;
                OnPropertyChanged("QS6");
            }
        }

        private double _total;

        /// <summary>
        /// Gets or sets the total.
        /// </summary>
        /// <value>The total.</value>
        [DataType(DataType.Currency)]
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

        private DateTime _year;

        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        /// <value>The year.</value>
        public DateTime Date
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
                OnPropertyChanged("Date");
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
