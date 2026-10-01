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
