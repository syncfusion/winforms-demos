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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding
{
    public class Country : NotifyPropertyChanged
    {
        #region Properties

        /// <summary>
        /// Represents the name of Country.
        /// </summary>
        private string _Name;

        /// <summary>
        /// Represents the Name of Country.
        /// </summary>
        public string CountryName
        {
            get { return _Name; }
            set { _Name = value;
                RaisePropertyChanged("CountryName");
            }
        }

        /// <summary>
        /// Represents the collection of states in Country.
        /// </summary>
        private ObservableCollection<State>  state;

        /// <summary>
        /// Represents the collection of states in Country.
        /// </summary>
        public ObservableCollection<State>  State
        {
            get { return state; }
            set { state = value;
                RaisePropertyChanged("State");
            }
        }

        /// <summary>
        /// Represents the id of Country.
        /// </summary>
        private int countryId;

        /// <summary>
        /// Represents the id of Country.
        /// </summary>
        public int CountryId
        {
            get { return countryId; }
            set { countryId = value;
                RaisePropertyChanged("CountryId");
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Represents the constructor of Country class.
        /// </summary>
        public Country(string name, int countryid, ObservableCollection<State> states)
        {
            CountryName = name;
            this.CountryId = countryid;
            this.State = states;
        }

        #endregion

    }

}
