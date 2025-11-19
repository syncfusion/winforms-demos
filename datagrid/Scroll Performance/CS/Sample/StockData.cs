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
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrollingPerfomance
{
    public class StockData : INotifyPropertyChanged
    {
        #region Private Members

        private string symbol;
        private double trade1;
        private double trade2;
        private double trade3;
        private double trade4;
        private double trade5;
        private double trade6;
        private double trade7;
        private double trade8;
        private double trade9;
        private double trade10;
        private double trade11;
        private double trade12;
        private double trade13;
        private double trade14;
        private double trade15;
        private double trade16;
        private double trade17;
        private double trade18;
        private double trade19;
        private double trade20;
        private double trade21;
        private double trade22;
        private double trade23;
        private double trade24;
        private double trade25;
        private double trade26;
        private double trade27;
        private double trade28;
        private double trade29;

        #endregion

        /// <summary>
        /// Gets or sets the Symbol.
        /// </summary>
        [Display(Name = "1")]
        public string Symbol
        {
            get
            {
                return symbol;
            }
            set
            {
                symbol = value;
                OnPropertyChanged("Symbol");
            }
        }

        /// <summary>
        /// Gets or sets the Trade1.
        /// </summary>
        [Display(Name = "2")]
        public double Trade1
        {
            get
            {
                return trade1;
            }
            set
            {
                trade1 = value;
                OnPropertyChanged("Trade1");
            }
        }

        /// <summary>
        /// Gets or sets the Trade2.
        /// </summary>
        [Display(Name = "3")]
        public double Trade2
        {
            get
            {
                return trade2;
            }
            set
            {
                trade2 = value;
                OnPropertyChanged("Trade2");
            }
        }

        /// <summary>
        /// Gets or sets the Trade3.
        /// </summary>
        [Display(Name = "4")]
        public double Trade3
        {
            get
            {
                return trade3;
            }
            set
            {
                trade3 = value;
                OnPropertyChanged("Trade3");
            }
        }

        /// <summary>
        /// Gets or sets the Trade4.
        /// </summary>
        [Display(Name = "5")]
        public double Trade4
        {
            get
            {
                return trade4;
            }
            set
            {
                trade4 = value;
                OnPropertyChanged("Trade4");
            }
        }

        /// <summary>
        /// Gets or sets the Trade5.
        /// </summary>
        [Display(Name = "6")]
        public double Trade5
        {
            get
            {
                return trade5;
            }
            set
            {
                trade5 = value;
                OnPropertyChanged("Trade5");
            }
        }

        /// <summary>
        /// Gets or sets the Trade6.
        /// </summary>
        [Display(Name = "7")]
        public double Trade6
        {
            get
            {
                return trade6;
            }
            set
            {
                trade6 = value;
                OnPropertyChanged("Trade6");
            }
        }

        /// <summary>
        /// Gets or sets the Trade7.
        /// </summary>
        [Display(Name = "8")]
        public double Trade7
        {
            get
            {
                return trade7;
            }
            set
            {
                trade7 = value;
                OnPropertyChanged("Trade7");
            }
        }

        /// <summary>
        /// Gets or sets the Trade8
        /// </summary>
        [Display(Name = "9")]
        public double Trade8
        {
            get
            {
                return trade8;
            }
            set
            {
                trade8 = value;
                OnPropertyChanged("Trade8");
            }
        }

        /// <summary>
        /// Gets or sets the Trade9
        /// </summary>
        [Display(Name = "10")]
        public double Trade9
        {
            get
            {
                return trade9;
            }
            set
            {
                trade9 = value;
                OnPropertyChanged("Trade9");
            }
        }

        /// <summary>
        /// Gets or sets the Trade10.
        /// </summary>
        [Display(Name = "11")]
        public double Trade10
        {
            get
            {
                return trade10;
            }
            set
            {
                trade10 = value;
                OnPropertyChanged("Trade10");
            }
        }

        /// <summary>
        /// Gets or sets the Trade11.
        /// </summary>
        [Display(Name = "12")]
        public double Trade11
        {
            get
            {
                return trade11;
            }
            set
            {
                trade11 = value;
                OnPropertyChanged("Trade11");
            }
        }

        /// <summary>
        /// Gets or sets the Trade12.
        /// </summary>
        [Display(Name = "13")]
        public double Trade12
        {
            get
            {
                return trade12;
            }
            set
            {
                trade12 = value;
                OnPropertyChanged("Trade12");
            }
        }

        /// <summary>
        /// Gets or sets the Trade13
        /// </summary>
        [Display(Name = "14")]
        public double Trade13
        {
            get
            {
                return trade13;
            }
            set
            {
                trade13 = value;
                OnPropertyChanged("Trade13");
            }
        }

        /// <summary>
        /// Gets or sets the Trade14
        /// </summary>
        [Display(Name = "15")]
        public double Trade14
        {
            get
            {
                return trade14;
            }
            set
            {
                trade14 = value;
                OnPropertyChanged("Trade14");
            }
        }

        /// <summary>
        /// Gets or sets the Trade15
        /// </summary>
        [Display(Name = "16")]
        public double Trade15
        {
            get
            {
                return trade15;
            }
            set
            {
                trade15 = value;
                OnPropertyChanged("Trade15");
            }
        }

        /// <summary>
        /// Gets or sets the Trade16
        /// </summary>
        [Display(Name = "17")]
        public double Trade16
        {
            get
            {
                return trade16;
            }
            set
            {
                trade16 = value;
                OnPropertyChanged("Trade16");
            }
        }

        /// <summary>
        /// Gets or sets the Trade17
        /// </summary>
        [Display(Name = "18")]
        public double Trade17
        {
            get
            {
                return trade17;
            }
            set
            {
                trade17 = value;
                OnPropertyChanged("Trade17");
            }
        }

        /// <summary>
        /// Gets or sets the Trade18
        /// </summary>
        [Display(Name = "19")]
        public double Trade18
        {
            get
            {
                return trade18;
            }
            set
            {
                trade18 = value;
                OnPropertyChanged("Trade18");
            }
        }

        /// <summary>
        /// Gets or sets the Trade19.
        /// </summary>
        [Display(Name = "20")]
        public double Trade19
        {
            get
            {
                return trade19;
            }
            set
            {
                trade19 = value;
                OnPropertyChanged("Trade19");
            }
        }

        /// <summary>
        /// Gets or sets the Trade20
        /// </summary>
        [Display(Name = "21")]
        public double Trade20
        {
            get
            {
                return trade20;
            }
            set
            {
                trade20 = value;
                OnPropertyChanged("Trade20");
            }
        }

        /// <summary>
        /// Gets or sets the Trade21
        /// </summary>
        [Display(Name = "22")]
        public double Trade21
        {
            get
            {
                return trade21;
            }
            set
            {
                trade21 = value;
                OnPropertyChanged("Trade21");
            }
        }

        /// <summary>
        /// Gets or sets the Trade22
        /// </summary>
        [Display(Name = "23")]
        public double Trade22
        {
            get
            {
                return trade22;
            }
            set
            {
                trade22 = value;
                OnPropertyChanged("Trade22");
            }
        }

        /// <summary>
        /// Gets or sets the Trade23
        /// </summary>
        [Display(Name = "24")]
        public double Trade23
        {
            get
            {
                return trade23;
            }
            set
            {
                trade23 = value;
                OnPropertyChanged("Trade23");
            }
        }

        /// <summary>
        /// Gets or sets the Trade24
        /// </summary>
        [Display(Name = "25")]
        public double Trade24
        {
            get
            {
                return trade24;
            }
            set
            {
                trade24 = value;
                OnPropertyChanged("Trade24");
            }
        }

        /// <summary>
        /// Gets or sets the Trade25
        /// </summary>
        [Display(Name = "26")]
        public double Trade25
        {
            get
            {
                return trade25;
            }
            set
            {
                trade25 = value;
                OnPropertyChanged("Trade25");
            }
        }

        /// <summary>
        /// Gets or sets the Trade26
        /// </summary>
        [Display(Name = "27")]
        public double Trade26
        {
            get
            {
                return trade26;
            }
            set
            {
                trade26 = value;
                OnPropertyChanged("Trade26");
            }
        }

        /// <summary>
        /// Gets or sets the Trade27
        /// </summary>
        [Display(Name = "28")]
        public double Trade27
        {
            get
            {
                return trade27;
            }
            set
            {
                trade27 = value;
                OnPropertyChanged("Trade27");
            }
        }

        /// <summary>
        /// Gets or sets the Trade28
        /// </summary>
        [Display(Name = "29")]
        public double Trade28
        {
            get
            {
                return trade28;
            }
            set
            {
                trade28 = value;
                OnPropertyChanged("Trade28");
            }
        }

        /// <summary>
        /// Gets or sets the Trade29
        /// </summary>
        [Display(Name = "30")]
        public double Trade29
        {
            get
            {
                return trade29;
            }
            set
            {
                trade29 = value;
                OnPropertyChanged("Trade29");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    public class StocksInfoCollection : INotifyPropertyChanged
    {
        #region Members

        ObservableCollection<StockData> data;
        Random r = new Random(123345345);
        List<string> StockSymbols = new List<string>();
        private bool isBusy = true;

        #endregion

        /// <summary>
        /// Gets the IsBusy whether to show the busy indicator.
        /// </summary>
        public bool IsBusy
        {
            get { return isBusy; }
            set { isBusy = value; OnPropertyChanged("IsBusy"); }
        }

        /// <summary>
        /// Gets the stocks.
        /// </summary>
        /// <value>The stocks.</value>
        public ObservableCollection<StockData> Stocks
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
                OnPropertyChanged("Stocks");
            }
        }

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="StocksInfoCollection"/> class.
        /// </summary>
        public StocksInfoCollection()
        {
            this.data = new ObservableCollection<StockData>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        /// <summary>
        /// Adds the rows.
        /// </summary>
        /// <param name="count">The count.</param>
        internal ObservableCollection<StockData> GenerateDataSource(int count)
        {
            var stocks = new ObservableCollection<StockData>();
            for (int i = 0; i < count; ++i)
            {
                var newRec = new StockData();
                newRec.Symbol = ChangeSymbol();
                newRec.Trade1 = Math.Round(r.NextDouble() * 30, 2);
                newRec.Trade2 = Math.Round(r.NextDouble() * 12, 2);
                newRec.Trade3 = Math.Round(r.NextDouble() * 34, 2);
                newRec.Trade4 = Math.Round(r.NextDouble() * 56, 2);
                newRec.Trade5 = Math.Round(r.NextDouble() * 76, 2);
                newRec.Trade6 = Math.Round(r.NextDouble() * 33, 2);
                newRec.Trade7 = Math.Round(r.NextDouble() * 76, 2);
                newRec.Trade8 = Math.Round(r.NextDouble() * 26, 2);
                newRec.Trade9 = Math.Round(r.NextDouble() * 25, 2);
                newRec.Trade10 = Math.Round(r.NextDouble() * 32, 2);
                newRec.Trade11 = Math.Round(r.NextDouble() * 46, 2);
                newRec.Trade12 = Math.Round(r.NextDouble() * 52, 2);
                newRec.Trade13 = Math.Round(r.NextDouble() * 76, 2);
                newRec.Trade14 = Math.Round(r.NextDouble() * 21, 2);
                newRec.Trade15 = Math.Round(r.NextDouble() * 32, 2);
                newRec.Trade16 = Math.Round(r.NextDouble() * 31, 2);
                newRec.Trade17 = Math.Round(r.NextDouble() * 23, 2);
                newRec.Trade18 = Math.Round(r.NextDouble() * 51, 2);
                newRec.Trade19 = Math.Round(r.NextDouble() * 20, 2);
                newRec.Trade20 = Math.Round(r.NextDouble() * 30, 2);
                newRec.Trade21 = Math.Round(r.NextDouble() * 26, 2);
                newRec.Trade22 = Math.Round(r.NextDouble() * 42, 2);
                newRec.Trade23 = Math.Round(r.NextDouble() * 43, 2);
                newRec.Trade24 = Math.Round(r.NextDouble() * 12, 2);
                newRec.Trade25 = Math.Round(r.NextDouble() * 16, 2);
                newRec.Trade26 = Math.Round(r.NextDouble() * 19, 2);
                newRec.Trade27 = Math.Round(r.NextDouble() * 49, 2);
                newRec.Trade28 = Math.Round(r.NextDouble() * 64, 2);
                newRec.Trade29 = Math.Round(r.NextDouble() * 13, 2);
                stocks.Add(newRec);
            }

            return stocks;
        }

        /// <summary>
        /// Changes the symbol.
        /// </summary>
        /// <returns></returns>
        private String ChangeSymbol()
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;

            do
            {
                builder = new StringBuilder();
                for (int i = 0; i < 4; i++)
                {
                    ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                    builder.Append(ch);
                }
            } while (StockSymbols.Contains(builder.ToString()));

            StockSymbols.Add(builder.ToString());
            return builder.ToString();
        }
    }
}
