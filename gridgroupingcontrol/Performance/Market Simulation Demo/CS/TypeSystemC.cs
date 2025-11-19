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

namespace MarketSimulation
{
    internal class TypeSystemC
    {
        public static String[] Symbols = { "MSFT", "ORCL", "GE", "GM", "CSCO", "A", "C", "D", "E", "F", "VOD",
                                            "IBM"};

        internal enum FidEnum 
        {
            NONE = 0,

            // Order Agreements
            OC_ID = 3000,
            OC_SYMBOL,
            OC_BAG_NAME,
            OC_SIDE,
            OC_QUANTITY,
            OC_VALUE,
            OC_WORKING,
            OC_REMAINING,
            OC_PCT_EXECUTED,
            OC_OPEN,
            OC_BID,
            OC_ASK,
            OC_LAST
        }

#if SyncfusionFramework2_0
		static Dictionary<FidEnum, string> fidNameMap   = new Dictionary<FidEnum, string>();
        static Dictionary<FidEnum, Type>   fidTypeMap   = new Dictionary<FidEnum, Type>();
#else
		static Hashtable fidNameMap   = new Hashtable ();
		static Hashtable fidTypeMap   = new Hashtable ();
#endif
        public static string FidName(FidEnum fid)
        {
            return (string) fidNameMap[fid];
        }

        public static Type FidType(FidEnum fid)
        {
            return (Type) fidTypeMap[fid];
        }

        static TypeSystemC()

        {
            // FID Names
            fidNameMap[FidEnum.NONE] = "Null";

            fidNameMap[FidEnum.OC_ID] = "ID";
            fidNameMap[FidEnum.OC_BAG_NAME] = "Bag";
            fidNameMap[FidEnum.OC_SYMBOL] = "Symbol";
            fidNameMap[FidEnum.OC_SIDE] = "Side";
            fidNameMap[FidEnum.OC_QUANTITY] = "Quantity";
            fidNameMap[FidEnum.OC_VALUE] = "$Value";
            fidNameMap[FidEnum.OC_WORKING] = "Working";
            fidNameMap[FidEnum.OC_REMAINING] = "Remaining";
            fidNameMap[FidEnum.OC_PCT_EXECUTED] = "Executed%";
            fidNameMap[FidEnum.OC_OPEN] = "Opn";
            fidNameMap[FidEnum.OC_BID] = "Bid";
            fidNameMap[FidEnum.OC_ASK] = "Ask";
            fidNameMap[FidEnum.OC_LAST] = "Last";


            // FID Types 
            fidTypeMap[FidEnum.NONE] = null;

            fidTypeMap[FidEnum.OC_ID] = typeof(long);
            fidTypeMap[FidEnum.OC_SYMBOL] = typeof(string);
            fidTypeMap[FidEnum.OC_BAG_NAME] = typeof(string);
            fidTypeMap[FidEnum.OC_SIDE] = typeof(string);
            fidTypeMap[FidEnum.OC_QUANTITY] = typeof(long);
            fidTypeMap[FidEnum.OC_VALUE] = typeof(double);
            fidTypeMap[FidEnum.OC_WORKING] = typeof(long);
            fidTypeMap[FidEnum.OC_REMAINING] = typeof(long);
            fidTypeMap[FidEnum.OC_PCT_EXECUTED] = typeof(double);
            fidTypeMap[FidEnum.OC_OPEN] = typeof(decimal);
            fidTypeMap[FidEnum.OC_BID] = typeof(decimal);
            fidTypeMap[FidEnum.OC_ASK] = typeof(decimal);
            fidTypeMap[FidEnum.OC_LAST] = typeof(decimal);  
        }                
    }
}
