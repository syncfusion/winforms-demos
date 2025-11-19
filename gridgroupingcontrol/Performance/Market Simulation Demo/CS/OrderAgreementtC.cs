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

using Fids = MarketSimulation.TypeSystemC.FidEnum;
    
namespace MarketSimulation
{
#if SyncfusionFramework2_0
    class OrderAgreementC : Dictionary<TypeSystemC.FidEnum, object>
    {
#else
    class OrderAgreementC : System.Collections.Hashtable
    {
#endif

        public OrderAgreementC()
        {
            this.Add(Fids.OC_ID, null);
            this.Add(Fids.OC_SYMBOL, null);
            this.Add(Fids.OC_BAG_NAME, null);
            this.Add(Fids.OC_SIDE, null);
            this.Add(Fids.OC_QUANTITY, null);
            this.Add(Fids.OC_VALUE, null);
            this.Add(Fids.OC_WORKING, null);
            this.Add(Fids.OC_PCT_EXECUTED, null);
            this.Add(Fids.OC_REMAINING, null);
            this.Add(Fids.OC_OPEN, null);
            this.Add(Fids.OC_BID, null);
            this.Add(Fids.OC_ASK, null);
            this.Add(Fids.OC_LAST, null);
        }        

        public OrderAgreementC(
            long iD,
            string symbol,
            string bagName,
            string side,
            long quantity,
            double value,
            long working,
            long remaining,
            double executed,
            decimal open,
            decimal bid,
            decimal ask,
            decimal last
        )
        {
            this.Add(Fids.OC_ID, iD);
            this.Add(Fids.OC_SYMBOL, symbol);
            this.Add(Fids.OC_BAG_NAME, bagName);
            this.Add(Fids.OC_SIDE, side);
            this.Add(Fids.OC_QUANTITY, quantity);
            this.Add(Fids.OC_VALUE, value);
            this.Add(Fids.OC_WORKING, working);
            this.Add(Fids.OC_PCT_EXECUTED, executed);
            this.Add(Fids.OC_REMAINING, remaining);
            this.Add(Fids.OC_OPEN, open);
            this.Add(Fids.OC_BID, bid);
            this.Add(Fids.OC_ASK, ask);
            this.Add(Fids.OC_LAST, last);
        }

        static int nextId = 1;
        static Random rand = new Random();

        public static OrderAgreementC GenerateRandom()
        {
            string symbol = TypeSystemC.Symbols[(int)(rand.NextDouble() * TypeSystemC.Symbols.Length)];
            string bag_name = "Bag " + (char)('A' + (short)(rand.NextDouble() * 4));
            string side = (rand.NextDouble() > 0.5) ? "B" : "S";
            long quantity = (int)(rand.NextDouble() * 10 + 1) * 100;
            double value = (double)(int)(rand.NextDouble() * 1000000);
            long working = (int)(rand.NextDouble() * quantity);
            long remaining = quantity - working;
            double executed = (double)(int)((double)working / quantity * 1000.0) / 10.0;

            return new OrderAgreementC(
                nextId++,
                symbol,
                bag_name,
                side,
                quantity,
                value,
                working,
                remaining,
                executed,
                new decimal(0.0),
                new decimal(0.0),
                new decimal(0.0),
                new decimal(0.0)
            );
        }
    }
}
