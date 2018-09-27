using System.ComponentModel;

namespace Summaries
{
    /// <summary>
    /// Sales details for an year. 
    /// </summary>
    public class SalesByYear : INotifyPropertyChanged
    {
        #region Fields

        private string name;
        private double q1;
        private double q2;
        private double q3;
        private double q4;
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
        /// Gets or sets the Q1.
        /// </summary>
        /// <value>The Q1.</value>
        public double Q1
        {
            get
            {
                return q1;
            }
            set
            {
                q1 = value;
                OnPropertyChanged("Q1");
            }
        }

        /// <summary>
        /// Gets or sets the Q2.
        /// </summary>
        /// <value>The Q2.</value>
        public double Q2
        {
            get
            {
                return q2;
            }
            set
            {
                q2 = value;
                OnPropertyChanged("Q2");
            }
        }

        /// <summary>
        /// Gets or sets the Q3.
        /// </summary>
        /// <value>The Q3.</value>
        public double Q3
        {
            get
            {
                return q3;
            }
            set
            {
                q3 = value;
                OnPropertyChanged("Q3");
            }
        }

        /// <summary>
        /// Gets or sets the Q4.
        /// </summary>
        /// <value>The Q4.</value>
        public double Q4
        {
            get
            {
                return q4;
            }
            set
            {
                q4 = value;
                OnPropertyChanged("Q4");
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
