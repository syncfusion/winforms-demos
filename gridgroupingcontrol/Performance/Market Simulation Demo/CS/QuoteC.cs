#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketSimulation
{
    class QuoteC
    {
        private QuoteC() { }

        public QuoteC(string symbol)
        {
            this.symbol = symbol;
        }
       
        private string symbol;
        private decimal bid;
        private decimal ask;
        private decimal last;
        private decimal open;

        public string Symbol { get { return symbol; } }
        public decimal Bid { get { return bid; } set { bid = value; } }
        public decimal Ask { get { return ask; } set { ask = value; } }
        public decimal Last { get { return last; } set { last = value; } }
        public decimal Open { get { return open; } set { open = value; } }
    }
}
