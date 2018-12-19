using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Styling
{
    class CountriesList : INotifyPropertyChanged
    {
        #region Properties

        private string serialNumber;
        [Display(Name = "Serial Number")]
        public string SerialNumber
        {
            get
            {
                return serialNumber;
            }
            set
            {
                serialNumber = value;
                OnPropertyChanged("SerialNumber");
            }
        }

        private string countryName;
        public string Country
        {
            get
            {
                return countryName;
            }
            set
            {
                countryName = value;
                OnPropertyChanged("Country");
            }
        }

        private string countryCapital;
        public string Capital
        {
            get
            {
                return countryCapital;
            }
            set
            {
                countryCapital = value;
                OnPropertyChanged("Capital");
            }
        }

        private string officialName;
        [Display(Name = "Oficail Name")]
        public string OfficialName
        {
            get
            {
                return officialName;
            }
            set
            {
                officialName = value;
                OnPropertyChanged("OfficialName");
            }
        }

        private string location;
        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
                OnPropertyChanged("Location");
            }
        }

        private string language;
        public string Language
        {
            get
            {
                return language;
            }
            set
            {
                language = value;
                OnPropertyChanged("Language");
            }
        }

        private string currency;
        public string Currency
        {
            get
            {
                return currency;
            }
            set
            {
                currency = value;
                OnPropertyChanged("Currency");
            }
        }

        private long population;
        public long Population
        {
            get
            {
                return population;
            }
            set
            {
                population = value;
                OnPropertyChanged("Population");
            }
        }

        private double literacyRate;
        [Display(Name = "Literacy Rate")]
        public double LiteracyRate
        {
            get
            {
                return literacyRate;
            }
            set
            {
                literacyRate = value;
                OnPropertyChanged("LiteracyRate");
            }
        }

        #endregion

        #region Ctor

        public CountriesList()
        {

        }

        public CountriesList(string _serialNumber, string _countryName, string _countryCapital, string _officialName, string _location, string _language, string _currency, long _Population, double _LiteracyRate)
        {
            this.SerialNumber = _serialNumber;
            this.Country = _countryName;
            this.Capital = _countryCapital;
            this.OfficialName = _officialName;
            this.Location = _location;
            this.Language = _language;
            this.Currency = _currency;
            this.Population = _Population;
            this.LiteracyRate = _LiteracyRate;
        }

        #endregion

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
