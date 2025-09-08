#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
# region Directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PortfolioManager.DataModel;
#endregion

namespace PortfolioManager
{
    public class LINQqueries
    {
        # region "API Definition"

        public static PortfolioManagerDB DB = new PortfolioManagerDB(Program.connString);

        #endregion

        #region "Helper Class"
        public class CurrentHoldings
        {
            # region Property
            public int HoldingID { get; set; }
            public bool? Open { get; set; }
            public string Quotes_Symbol { get; set; }
            public string Quote_CompanyName { get; set; }
            public decimal? PricePaid { get; set; }
            public decimal? Quantity { get; set; }
            public double? Quote_Change { get; set; }
            public double? Quote___Change { get; set; }
            public string Account_AccountName { get; set; }
            public string Quote_Industry_Sector_SectorName { get; set; }
            public string Quote_Industry_IndusrtyName { get; set; }
            public string StockExchange_StockExchangeName { get; set; }
            public decimal? Quote_Price { get; set; }
            #endregion
        }
        #endregion

        # region Method
        /// <summary>
        /// used for gets data to the list.
        /// </summary>
        /// <returns></returns>
        public static List<CurrentHoldings> GetHoldingsList()
        {
            DB.ObjectTrackingEnabled = false;

            var holding = from holdings in DB.Holdings
                          select new CurrentHoldings
                          {
                              HoldingID = holdings.HoldingID,
                              Open = holdings.Open,
                              Quotes_Symbol = holdings.Quotes_Symbol,
                              Quote_CompanyName = holdings.Quotes.CompanyName,
                              PricePaid = holdings.PricePaid,
                              Quantity = holdings.Quantity,
                              Quote_Change = holdings.Quotes.Change,
                              Quote___Change = holdings.Quotes.PertChange,
                              Account_AccountName = holdings.Accounts.AccountName,
                              Quote_Industry_Sector_SectorName = holdings.Quotes.Industries.Sectors.SectorName,
                              Quote_Industry_IndusrtyName = holdings.Quotes.Industries.IndusrtyName,
                              StockExchange_StockExchangeName = holdings.StockExchanges.StockExchangeName,
                              Quote_Price = holdings.Quotes.Price
                          };

            return holding.ToList<CurrentHoldings>();
        }     
        /// <summary>
        /// used for Getting symbol.
        /// </summary>
        /// <returns></returns>
        public static List<SymbolAndCompanyName> GetSymbolAndCompanyNamefromQuotes()
        {
            var Query = from quotes in DB.Quotes
                        select new SymbolAndCompanyName
                        {
                            Symbol = quotes.Symbol,
                            CompanyName = quotes.CompanyName
                        };

            return Query.ToList<SymbolAndCompanyName>();
        }
        /// <summary>
        /// used for getting quote .
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        public static Quotes GetQuote(string symbol)
        {
            var r = DB.GetTable<Quotes>().Where((s => (s.Symbol == symbol)));
            Quotes qt = r.SingleOrDefault();
            return qt;
        }

        /// <summary>
        /// Used for getting industry name.
        /// </summary>
        /// <param name="industryID"></param>
        /// <returns></returns>
        public static string GetIndustryName(int? industryID)
        {
            var r = DB.GetTable<Industries>().Where((i => (i.IndustryID == industryID)));
            Industries industry = r.SingleOrDefault();

            return industry.IndusrtyName;
        }
        /// <summary>
        /// used for getting sector name.
        /// </summary>
        /// <param name="industryID"></param>
        /// <returns></returns>
        public static string GetSectorName(int? industryID)
        {
            var r = DB.GetTable<Industries>().Where((i => (i.IndustryID == industryID)));
            Industries industry = r.SingleOrDefault();

            var s = DB.GetTable<Sectors>().Where((i => (i.SectorID == industry.SectorID)));
            Sectors sector = s.SingleOrDefault();

            return sector.SectorName;
        }
        /// <summary>
        /// Used for getting AccountNumber
        /// </summary>
        /// <returns></returns>
        public static List<AcountNameAndValue> GetAcountNameAndValue()
        {
            var acctValue = from acct in DB.Accounts
                            select new AcountNameAndValue
                            {
                                AccountName = acct.AccountName,
                                AssetValue = acct.AssetBalance
                            };

            return acctValue.ToList<AcountNameAndValue>();
        }
        /// <summary>
        /// Used for getting price symbol.
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        public static decimal? GetPriceforSymbol(string symbol)
        {
            var r = DB.GetTable<Quotes>().Where((s => (s.Symbol == symbol)));

            Quotes qt = r.SingleOrDefault();

            if (qt == null)
                return 0;

            return qt.Price;
        }
        /// <summary>
        /// Used for Getting Accounts.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetAccounts()
        {
            var accountNames = from accounts in DB.Accounts
                               orderby accounts.AccountName ascending
                               select accounts.AccountName;

            return accountNames as IEnumerable<string>;
        }
        /// <summary>
        /// Used for getting exchange names.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetExchangeNames()
        {
            var exchangeNames = from exchanges in DB.StockExchanges
                                orderby exchanges.StockExchangeName ascending
                                select exchanges.StockExchangeName;

            return exchangeNames as IEnumerable<string>;
        }
        /// <summary>
        /// Used for getting Account number.
        /// </summary>
        /// <param name="accountName"></param>
        /// <returns></returns>
        public static int GetAccountID(string accountName)
        {
            var account = DB.Accounts.Where(acct => (acct.AccountName == accountName));
            if (account.Count() > 0)
            {
                return account.SingleOrDefault().AccountID;
            }
            return -1;
        }
        /// <summary>
        /// used for getting exchangeId.
        /// </summary>
        /// <param name="exchangeName"></param>
        /// <returns></returns>
        public static int GetExchangeID(string exchangeName)
        {
            var exchange = DB.StockExchanges.Where(exch => (exch.StockExchangeName == exchangeName));
            if (exchange.Count() > 0)
            {
                return exchange.SingleOrDefault().StockExchangeID;
            }
            return -1;
        }
        /// <summary>
        /// Used for GetAccountBalance
        /// </summary>
        /// <param name="accountName"></param>
        /// <param name="CashBalance"></param>
        /// <returns></returns>
        public static Decimal? GetAccountBalance(string accountName, bool CashBalance)
        {
            var account = DB.Accounts.Where(acct => (acct.AccountName == accountName));

            Decimal? balance = -1;
            if (account.Count() > 0)
            {
                if (CashBalance)
                    balance = account.SingleOrDefault().CashBalance;
                else
                    balance = account.SingleOrDefault().AssetBalance;
            }
            return balance;
        }
        /// <summary>
        /// Used for creating new account
        /// </summary>
        public static Accounts CreateNewAccount(string accountName, decimal openCashBalance)
        {      
            Accounts newAccount = new Accounts();
            newAccount.Users_UserID = 1;
            newAccount.AccountName = accountName;
            newAccount.OpenBalance = openCashBalance;
            newAccount.CashBalance = openCashBalance;
            newAccount.AssetBalance = 0;
            newAccount.CreationDate = DateTime.Now;

            DB.Accounts.InsertOnSubmit(newAccount);

            DB.SubmitChanges();

            return newAccount;
        }
        /// <summary>
        /// Used for inserting holding value.
        /// </summary>
        public static Holdings InsertHolding(int accountID, int exchangeID, string Symbol, decimal Quantity, decimal price)
        {
            Holdings holding = new Holdings();
            holding.Accounts_AccountID = accountID;
            holding.StockExchangeID = exchangeID;
            holding.Quantity = Quantity;
            holding.Quotes_Symbol = Symbol;
            holding.PurchaseDate = DateTime.Now;
            holding.PricePaid = price;
            holding.Open = true;

            //Add it to the DB
            DB.Holdings.InsertOnSubmit(holding);

            //Adjust the AccountBalances in Accounts
            Accounts account = DB.GetTable<Accounts>().Where(acct => (acct.AccountID == accountID)).SingleOrDefault();

            decimal? cashBalance = account.CashBalance;
            account.CashBalance = cashBalance - (Quantity * price);

            decimal? assetBalance = account.AssetBalance;

            //need to use the Current Market price
            decimal? currentPrice = GetPriceforSymbol(Symbol);
            account.AssetBalance = assetBalance + (Quantity * currentPrice);

            DB.SubmitChanges();

            //Get the added one from DB
            Holdings hold = (from h in DB.Holdings
                            where h == holding
                            select h).SingleOrDefault();

            //Check it with the current object
            if (hold == holding)
            {
                return holding;
            }

            return null;
        }

        /// <summary>
        /// Used for getting Date and asset value.
        /// </summary>
        public static List<DateAssetValue> GetDateAndAssetValue(string AccoutName, DateTime MinDate, DateTime MaxDate)
        {
            using (PortfolioManagerDB DB = new PortfolioManagerDB(Program.connString))
            {
                DB.ObjectTrackingEnabled = false;

                List<DateAssetValue> list = new List<DateAssetValue>();

                var Dates = from hist in DB.HistoricalQuotes
                            where hist.Date > MinDate
                            where hist.Date <= MaxDate
                            group hist by hist.Date into date
                            orderby date.Key descending
                            select new { date.Key };

                foreach (var Date in Dates)
                {
                    DateTime date = DateTime.Parse(Date.Key.ToString());

                    var w = from holdings in DB.Holdings.Where(acct => acct.Accounts.AccountName == AccoutName)
                            join histQuotes in DB.HistoricalQuotes.Where(histQuotes => histQuotes.Date == date)
                            on holdings.Quotes_Symbol equals histQuotes.Symbol
                            group (holdings.Quantity * histQuotes.Close) by AccoutName into AssetValueAtDate
                            select new
                            {
                                Value = AssetValueAtDate.Sum()
                            };

                    Decimal? AssetValue = 0;
                    AssetValue = w.SingleOrDefault().Value;

                    DateAssetValue value = new DateAssetValue() { Date = date, AssetValue = AssetValue };
                    list.Add(value);
                }

                return list;
            }
        }

        public static List<SectorAndValue> GetSectorNames(int accountID)
        {
            var Sectors = from holdings in DB.Holdings
                          where holdings.Accounts_AccountID == accountID
                          group (holdings.PricePaid * holdings.Quantity) by holdings.Quotes.Industries.Sectors.SectorName into sectors
                          select new SectorAndValue
                          {
                              SectorName = sectors.Key,
                              Value = sectors.Sum()
                          };

            return Sectors.ToList<SectorAndValue>();
        }

        public static List<ExchangeAndValue> GetExchangeNamesAndValues(int accountID)
        {
            var Exchanges = from holdings in DB.Holdings
                            where holdings.Accounts_AccountID == accountID
                            group (holdings.PricePaid * holdings.Quantity) by holdings.StockExchanges.Country into exchanges
                            select new ExchangeAndValue
                            {
                                ExchangeName = exchanges.Key,
                                Value = exchanges.Sum()
                            };

            return Exchanges.ToList<ExchangeAndValue>();
        }
        #endregion

        #region Helper Class 
        public class AcountNameAndValue
        {
            public string AccountName { get; set; }
            public Decimal? AssetValue { get; set; }
        }

        public class SymbolAndCompanyName
        {
            public string Symbol { get; set; }
            public string CompanyName { get; set; }
        }

        public class SectorAndValue
        {
            public string SectorName { get; set; }
            public Decimal? Value { get; set; }
        }

        public class ExchangeAndValue
        {
            public string ExchangeName { get; set; }
            public Decimal? Value { get; set; }
        }       

        [Serializable]
        public class DateAssetValue
        {
            public DateTime Date { get; set; }
            public Decimal? AssetValue { get; set; }
        }
        #endregion

    }
}