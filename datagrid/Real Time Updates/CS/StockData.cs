#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RealTimeUpdates
{
    public class StockData : INotifyPropertyChanged
    {
        #region Private Members

        private string symbol;
        private string account;
        private double lastTrade;
        private double change;
        private double previousClose;
        private double open;

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        /// <value>The symbol.</value>
        public string Symbol
        {
            get
            {
                return symbol;
            }
            set
            {

                symbol = value;
                OnProertyChanged("Symbol");
            }
        }

        private void OnProertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Gets or sets the account.
        /// </summary>
        /// <value>The account.</value>
        public string Account
        {
            get
            {
                return account;
            }
            set
            {
                account = value;
                OnProertyChanged("Account");
            }
        }

        /// <summary>
        /// Gets or sets the last trade.
        /// </summary>
        /// <value>The last trade.</value>
        [Display(Name = "Last Trade")]
        public double LastTrade
        {
            get
            {
                return lastTrade;
            }
            set
            {
                lastTrade = value;
                OnProertyChanged("LastTrade");
            }
        }

        /// <summary>
        /// Gets or sets the change.
        /// </summary>
        /// <value>The change.</value>
        public double Change
        {
            get
            {
                return change;
            }
            set
            {
                change = value;
                OnProertyChanged("Change");
            }
        }

        /// <summary>
        /// Gets or sets the previous close.
        /// </summary>
        /// <value>The previous close.</value>
        [Display(Name = "Previous Close")]
        public double PreviousClose
        {
            get
            {
                return previousClose;
            }
            set
            {
                previousClose = value;
                OnProertyChanged("PreviousClose");
            }
        }

        /// <summary>
        /// Gets or sets the open.
        /// </summary>
        /// <value>The open.</value>
        public double Open
        {
            get
            {
                return open;
            }
            set
            {
                open = value;
                OnProertyChanged("Open");
            }
        }
    }
}
