#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace MarketSimulation
{
#if SyncfusionFramework2_0
    class QuoteCDictionoary : Dictionary<string, QuoteC>
    {
    }
    class QuoteCList : List<QuoteC>
    {
    }
#else
    class QuoteCDictionoary : Hashtable
    {
        public QuoteC this[string key]
        {
            get
            {
                return (QuoteC) base[key];
            }
            set
            {
                base[key] = value;
            }
        }
    }

    class QuoteCList : ArrayList
    {
        public new QuoteC this[int index]
        {
            get
            {
                return (QuoteC) base[index];
            }
            set
            {
                base[index] = value;
            }
        }
    }
#endif

    class QuoteManagerC : IDisposable
    {
        private System.Timers.Timer throttleTimer;
        private QuoteCDictionoary quotesMap = new QuoteCDictionoary();
        private QuoteCList changedQuotes = new QuoteCList();
        public delegate void QuotesUpdatedDelegate(QuoteC[] quoteList);
        public event QuotesUpdatedDelegate QuotesUpdate;

        private static QuoteManagerC manager = new QuoteManagerC();
        public static QuoteManagerC Manager
        {
            get { return manager; }
        }

        public QuoteManagerC()
        {
            throttleTimer = new System.Timers.Timer(Program.TimerUpdate);
            throttleTimer.Elapsed += new ElapsedEventHandler(throttleTimer_Elapsed);
            throttleTimer.Start();
        }

        // Market data simulator
        static bool gotFirstQuote = false;
        private Random rand = new Random();
        void throttleTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            QuoteC[] changedQuoteArray = null;

            bool update = false;

            int ticks = Environment.TickCount;

            #region Temporary market data simulator
			QuoteCList list = new QuoteCList();

            foreach (string symbol in TypeSystemC.Symbols)
            {
                QuoteC quote = quotesMap[symbol];

                if (gotFirstQuote)
                {
                    if (rand.NextDouble() > 0.9)
                    {
                        update = true;
                        if (rand.NextDouble() > 0.5)
                            quote.Ask += new decimal(0.01);
                        else
                            quote.Ask -= new decimal(0.01);

                        if (rand.NextDouble() > 0.5)
                            quote.Bid = quote.Ask - new decimal(0.05);
                        else
                            quote.Bid = quote.Ask - new decimal(0.10);

                        if (rand.NextDouble() > 0.5)
                        {
                            if (rand.NextDouble() > 0.5)
                                quote.Last = quote.Bid;
                            else
                                quote.Last = quote.Ask;
                        }

                        list.Add(quote);
                    }
                }
                else
                    list.Add(quote);
            }

            if (!gotFirstQuote && QuotesUpdate != null)
            {
                gotFirstQuote = true;
                update = true;
            }
            changedQuoteArray = new QuoteC[list.Count];
			list.CopyTo(changedQuoteArray, 0);
            #endregion

            if (update && QuotesUpdate != null)
                QuotesUpdate(changedQuoteArray);

            count++;
            tickCounter += Environment.TickCount - ticks;

            if (count > 10)
            {
                if (tickCounter / count > throttleTimer.Interval)
                {
                    // if painting is too slow avoid locking up computer with backlog of timer events
                    throttleTimer.Interval = tickCounter / count + 10;
                    Console.WriteLine("Changed interval to {0}", throttleTimer.Interval);
                }
                count = 0;
                tickCounter = 0;
            }
        }

        int tickCounter;
        int count;

        public void Subscribe(string[] symbols)
        {
            foreach (string symbol in symbols)
            {
                Subscribe(symbol);
            }
        }

        private void Subscribe(string symbol)
        {
            if (quotesMap.ContainsKey(symbol))
                return;

            quotesMap[symbol] = new QuoteC(symbol);

            // Market data simluator.... put some random price info in
            QuoteC quote = quotesMap[symbol];

            int quoteTimesHundred = (int) (2000 + (rand.NextDouble() * 8000));
            quote.Ask = new decimal(quoteTimesHundred) / new decimal(100.0);
            quote.Bid = quote.Ask - new decimal(0.05);
            quote.Last = quote.Ask;
            quote.Open = quote.Ask;
        }

        #region IDisposable Members

        public void Dispose()
        {
            this.throttleTimer.Dispose();
        }

        #endregion
    }
}
