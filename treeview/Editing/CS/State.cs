#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editing
{
    public class State: NotifyPropertyChanged
    {
        #region Properties

        /// <summary>
        /// Represents the name of state.
        /// </summary>
        private string _Name;

        /// <summary>
        /// Represents the name of state.
        /// </summary>
        public string StateName
        {
            get { return _Name; }
            set { _Name = value;
                RaisePropertyChanged("StateName");
            }
        }

        /// <summary>
        /// Represents the id of state.
        /// </summary>
        private int stateId;

        /// <summary>
        /// /// <summary>
        /// Represents the name of state.
        /// </summary>
        /// </summary>
        public int StateID
        {
            get { return stateId; }
            set { stateId = value;
                RaisePropertyChanged("StateID");
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Represents the constructor of State class.
        /// </summary>
        public State(string name, int stateId)
        {
            this.StateName = name;
            this.StateID = stateId;
        }

        #endregion
    }
}
