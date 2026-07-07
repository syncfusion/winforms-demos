using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Styling
{
    class CountryInfoCollection : INotifyPropertyChanged
    {
        public CountryInfoCollection()
        {
            CountryDetails = new Countries();
        }

        private ObservableCollection<CountriesList> countryDetails;

        public ObservableCollection<CountriesList> CountryDetails
        {
            get
            {
                return countryDetails;
            }
            set
            {
                countryDetails = value;
                OnPropertyChanged("CountryDetails");
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool isdisposable)
        {
            if (this.countryDetails != null)
            {
                this.countryDetails.Clear();
            }
        }

        #region INotifyEventChanged

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

        #endregion
    }
}
