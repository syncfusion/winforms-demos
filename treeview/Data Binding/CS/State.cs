using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding
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
