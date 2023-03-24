#region Copyright Syncfusion Inc. 2001 - 2023
// Copyright Syncfusion Inc. 2001 - 2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ExpenseAnalysis
{
   public class ExpenseData
    {
        public DateTime DateTime { get; set; }
        public string CategoryName { get; set; }
        public string SubCategory { get; set; }
        public double Amount { get; set; }
        public AccountType AccountType { get; set; }
        public string Description { get; set; }

        public List<ExpenseData> GenerateExpenseData(DateTime start, DateTime end, int recordCount)
        {
            var expenses = new List<ExpenseData>();
            var categories = new ExpenseCategory().GetCategories();
            var totCategory = categories.Count;
            var catCount = 0;
            int incomeMonth = 0;
            while (start < end)
            {
                var count = 0;
                while (count < recordCount)
                {
                    if (catCount > totCategory - 1)
                        catCount = 0;
                    var category = categories[catCount];
                    var expense = new ExpenseData
                    {
                        DateTime = start,
                        AccountType = category.AccountType,
                        Amount = (new Random(catCount + start.Month).Next(category.Start, category.End)),
                        CategoryName = category.Name,
                        SubCategory = category.SubCategory,
                        Description = category.Description
                    };
                    if (expense.AccountType == AccountType.Positve && CheckIncome(expenses, expense.CategoryName))
                    {
                        incomeMonth = expense.DateTime.Month;
                    }
                    if (expense.AccountType == AccountType.Positve &&
                        CheckDataExists(expenses, expense.CategoryName, expense.SubCategory, expense.AccountType, incomeMonth))
                    {
                        catCount++;
                        continue;
                    }

                    if (expense.AccountType == AccountType.Negative &&
                        expense.SubCategory == "Mortgage/rent" && CheckNegativeDataExists(expenses, "Home", "Mortgage/rent", expense.AccountType))
                    {

                        catCount++;
                        continue;
                    }

                    expenses.Add(expense);
                    count++;
                    catCount++;



                }
                start = start.AddDays(1);

            }

            return expenses;
        }

        public bool CheckDataExists(List<ExpenseData> expenses, string category, string subCategory, AccountType type, int incomeMonth)
        {

            return expenses.Any(expense => expense.CategoryName == category && expense.SubCategory == subCategory && incomeMonth == expense.DateTime.Month);
        }
        public bool CheckNegativeDataExists(List<ExpenseData> expenses, string category, string subCategory, AccountType type)
        {

            return expenses.Any(expense => expense.CategoryName == category && expense.SubCategory == subCategory);
        }
        public bool CheckIncome(List<ExpenseData> expenses, string category)
        {
            return expenses.Any(expense => expense.CategoryName == category);
        }
    }



    public enum AccountType
    {
        Positve,
        Negative
    }
    class ExpenseCategory
    {
        public string Name { get; set; }
        public string SubCategory { get; set; }
        public int Start { get; set; }
        public int End { get; set; }
        public AccountType AccountType { get; set; }
        public string Description { get; set; }
        public List<ExpenseCategory> GetCategories()
        {
            var categories = new List<ExpenseCategory>
                {
                    new ExpenseCategory
                        {
                            Name = "Home",
                            SubCategory = "Mortgage/rent",
                            Start = 350,
                            End = 700,
                            AccountType = AccountType.Negative,
                            Description = "Bank of America"
                        },
                         new ExpenseCategory
                        {
                            Name = "Home",
                            SubCategory = "Home repairs",
                            Start = 50,
                            End = 300,
                            AccountType = AccountType.Negative,
                            Description = "Lowes"
                        },
                         new ExpenseCategory
                        {
                            Name = "Home",
                            SubCategory = "Mobile telephone",
                            Start = 400,
                            End = 600,
                            AccountType = AccountType.Negative,
                            Description = "Verizon Wireless"
                        },
                         new ExpenseCategory
                        {
                            Name = "Home",
                            SubCategory = "Utilities",
                            Start = 100,
                            End = 200,
                            AccountType = AccountType.Negative,
                              Description = "Duke energy"
                        },
                         new ExpenseCategory
                        {
                            Name = "Home",
                            SubCategory = "Home improvement",
                            Start = 1000,
                            End = 2000,
                            AccountType = AccountType.Negative,
                          Description = "Home depot"
                        },
                         new ExpenseCategory
                        {
                            Name = "Home",
                            SubCategory = "Home security",
                            Start = 220,
                            End = 300,
                            AccountType = AccountType.Negative,
                            Description = "ADT"
                        },
                         new ExpenseCategory
                        {
                            Name = "Daily Living",
                            SubCategory = "Dry cleaning",
                            Start = 200,
                            End = 300,
                            AccountType = AccountType.Negative,
                            Description = "ABC Cleaners"
                        },
                         new ExpenseCategory
                        {
                            Name = "Daily Living",
                            SubCategory = "Dining out",
                            Start = 50,
                            End = 100,
                            AccountType = AccountType.Negative,
                            Description = "Olive Garden"
                        },
                         new ExpenseCategory
                        {
                            Name = "Daily Living",
                            SubCategory = "Groceries",
                            Start = 120,
                            End = 200,
                            AccountType = AccountType.Negative,
                            Description = "Kroger"
                        },
                         new ExpenseCategory
                        {
                            Name = "Dues/subscriptions",
                            SubCategory = "Internet connection",
                            Start = 300,
                            End = 500,
                            AccountType = AccountType.Negative,
                            Description = "Time warner cable"
                        },
                         new ExpenseCategory
                        {
                            Name = "Dues/subscriptions",
                            SubCategory = "Newspapers",
                            Start = 12,
                            End = 20,
                            AccountType = AccountType.Negative,
                            Description = "Wall Street Journal"
                        },
                         new ExpenseCategory
                        {
                            Name = "Entertainment",
                            SubCategory = "Movies/plays",
                            Start = 5,
                            End = 10,
                            AccountType = AccountType.Negative,
                            Description = "Weekend Movies"
                        },
                         new ExpenseCategory
                        {
                            Name = "Entertainment",
                            SubCategory = "Concerts/clubs",
                            Start = 1000,
                            End = 2000,
                            AccountType = AccountType.Negative,
                            Description = "Comedy drama show"
                        },
                         new ExpenseCategory
                        {
                            Name = "Financial obligations",
                            SubCategory = "Retirement (401k, Roth IRA)",
                            Start = 200,
                            End = 400,
                            AccountType = AccountType.Negative,
                            Description = "Retirement"
                        },
                         new ExpenseCategory
                        {
                              Name = "Financial obligations",
                            SubCategory = "Income tax (additional)",
                            Start = 200,
                            End = 300,
                            AccountType = AccountType.Negative,
                            Description = "Income tax"
                        },
                         new ExpenseCategory
                        {
                            Name = "Health",
                            SubCategory = "Insurance (H)",
                            Start = 300,
                            End = 500,
                            AccountType = AccountType.Negative,
                            Description = "United Healthcare"
                        },
                         new ExpenseCategory
                        {
                            Name = "Health",
                            SubCategory = "Prescriptions",
                            Start = 300,
                            End = 500,
                            AccountType = AccountType.Negative,
                            Description = "Rite Aid"
                        },
                         new ExpenseCategory
                        {
                            Name = "Personal",
                            SubCategory = "Clothing",
                            Start = 300,
                            End = 500,
                            AccountType = AccountType.Negative,
                            Description = "Kohls"
                        },
                         new ExpenseCategory
                        {
                            Name = "Personal",
                            SubCategory = "Gifts",
                            Start = 100,
                            End = 500,
                            AccountType = AccountType.Negative,
                            Description = "Amazon.com"
                        },
                         new ExpenseCategory
                        {
                            Name = "Personal",
                            SubCategory = "Books",
                            Start = 100,
                            End = 500,
                            AccountType = AccountType.Negative,
                            Description = "Purchased novels and technology books"
                        },
                         new ExpenseCategory
                        {
                            Name = "Transportation",
                            SubCategory = "Gas/fuel",
                            Start = 200,
                            End = 400,
                            AccountType = AccountType.Negative
                        },
                         new ExpenseCategory
                        {
                            Name = "Transportation",
                            SubCategory = "Repairs",
                            Start = 50,
                            End = 100,
                            AccountType = AccountType.Negative,
                            Description = "AAA"
                        },
                         new ExpenseCategory
                        {
                            Name = "Transportation",
                            SubCategory = "Parking",
                            Start = 10,
                            End = 50,
                            AccountType = AccountType.Negative,
                            Description = "1 hr parking charge"
                        },
                         new ExpenseCategory
                        {
                            Name = "Income",
                            SubCategory = "Salary",
                            Start = 15000,
                            End = 20000,
                            AccountType = AccountType.Positve,
                            Description = "Salary credited"
                        },
                         new ExpenseCategory
                        {
                            Name = "Income",
                            SubCategory = "Interest/dividends",
                            Start = 500,
                            End = 700,
                            AccountType = AccountType.Positve
                        },
                         new ExpenseCategory
                        {
                            Name = "Income",
                            SubCategory = "Miscellaneous",
                            Start = 4000,
                            End = 5000,
                            AccountType = AccountType.Positve
                        }
                };

            return categories;
        }
    }

    class ProcessedExpenseData
    {
        private double _homeAmount;
        private double _securityAmount;
        private double _entertainmentAmount;
        private double _healthAmount;
        private double _transportAmount;
        private double _mortgage;
        private double _homerepair;
        private double _utilities;
        private double _homeImprovement;
        private double _mobileTelephone;
        private double _drycleaing;
        private double _dininout;
        private double _groceries;
        private double _movies;
        private double _clubs;
        private double _insurance;
        private double _prescriptions;
        private double _gas;
        private double _repairs;
        private double _parking;
        private double _clothing;
        private double _gifts;
        private double _books;

        public string MonthName
        {
            get;
            set;
        }
        public ProcessedExpenseData(string months)
        {
            this.MonthName = months;
            TotalExpenses = (new ExpenseData()).GenerateExpenseData(new DateTime(2013, 1, 1), new DateTime(2013, 12, 31),
                                                                    2);
            this.Update();
        }
        

        private void Update()
        {
            var month = this.MonthName;
            if (month.Equals("All"))
            {
                Expenses = TotalExpenses;

                var max = TotalExpenses.Where(x => x.AccountType == AccountType.Negative).Max(x => x.Amount);
                var maxExpense = TotalExpenses.First(x => x.Amount.Equals(max));
                MostSpent = max.ToString("c") + " in " +
                            CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(maxExpense.DateTime.Month) + " " +
                            maxExpense.DateTime.Year;

                var min = TotalExpenses.Where(x => x.AccountType == AccountType.Negative).Min(x => x.Amount);
                var minExpense = TotalExpenses.First(x => x.Amount.Equals(min));
                LeastSpent = min.ToString("c") + " in " +
                             CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(minExpense.DateTime.Month) + " " +
                             minExpense.DateTime.Year;

                var avg = TotalExpenses.Where(x => x.AccountType == AccountType.Negative).Average(x => x.Amount);
                AverageSpent = avg.ToString("c") + "/month";

            }
            else
            {
                Expenses = TotalExpenses.Where(ed =>
                {
                    var m = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(ed.DateTime.Month);
                    return m.ToLower().Equals(month.ToString().ToLower());
                }).ToList();
                if (Expenses.Count > 0)
                {
                    var max = Expenses.Where(x => x.AccountType == AccountType.Negative).Max(x => x.Amount);
                    var maxExpense = Expenses.First(x => x.Amount.Equals(max));
                    MostSpent = max.ToString("c") + " on " +
                                CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(maxExpense.DateTime.Month) + " " +
                                maxExpense.DateTime.Day;

                    var min = Expenses.Where(x => x.AccountType == AccountType.Negative).Min(x => x.Amount);
                    var minExpense = Expenses.First(x => x.Amount.Equals(max));
                    LeastSpent = min.ToString("c") + " on " +
                                 CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(minExpense.DateTime.Month) + " " +
                                 minExpense.DateTime.Day;

                    var avg = Expenses.Where(x => x.AccountType == AccountType.Negative).Average(x => x.Amount);
                    AverageSpent = avg.ToString("c") + "/month";
                }
            }
            if (Expenses.Count > 0)
            {
                PositiveAmount = Expenses.Where(x => x.AccountType == AccountType.Positve).Sum(x => x.Amount);
                NegativeAmount = Expenses.Where(x => x.AccountType == AccountType.Negative).Sum(x => x.Amount);
                BalanceAmount = PositiveAmount - NegativeAmount;

                NoPositiveTransactions = Expenses.Count(x => x.AccountType == AccountType.Positve);
                NoNegativeTransactions = Expenses.Count(x => x.AccountType == AccountType.Negative);
                NoTotalTransactions = NoPositiveTransactions + NoNegativeTransactions;
            }
            #region PieData

            _homeAmount = Expenses.Where(x => x.CategoryName == "Home").Sum(x => x.Amount);
            _securityAmount = Expenses.Where(x => x.CategoryName == "Daily Living").Sum(x => x.Amount);
            _entertainmentAmount = Expenses.Where(x => x.CategoryName == "Entertainment").Sum(x => x.Amount);
            _healthAmount = Expenses.Where(x => x.CategoryName == "Health").Sum(x => x.Amount);
            _transportAmount = Expenses.Where(x => x.CategoryName == "Transportation").Sum(x => x.Amount);
            _mortgage = Expenses.Where(x => x.SubCategory == "Mortgage/rent").Sum(x => x.Amount);
            _homerepair = Expenses.Where(x => x.SubCategory == "Home repairs").Sum(x => x.Amount);
            _utilities = Expenses.Where(x => x.SubCategory == "Utilities").Sum(x => x.Amount);
            _homeImprovement = Expenses.Where(x => x.SubCategory == "Home improvement").Sum(x => x.Amount);
            _mobileTelephone = Expenses.Where(x => x.SubCategory == "Mobile telephone").Sum(x => x.Amount);
            _drycleaing = Expenses.Where(x => x.SubCategory == "Dry cleaning").Sum(x => x.Amount);
            _dininout = Expenses.Where(x => x.SubCategory == "Dining out").Sum(x => x.Amount);
            _groceries = Expenses.Where(x => x.SubCategory == "Groceries").Sum(x => x.Amount);
            _movies = Expenses.Where(x => x.SubCategory == "Movies/plays").Sum(x => x.Amount);
            _clubs = Expenses.Where(x => x.SubCategory == "Concerts/clubs").Sum(x => x.Amount);
            _insurance = Expenses.Where(x => x.SubCategory == "Insurance (H)").Sum(x => x.Amount);
            _prescriptions = Expenses.Where(x => x.SubCategory == "Prescriptions").Sum(x => x.Amount);
            _gas = Expenses.Where(x => x.SubCategory == "Gas/fuel").Sum(x => x.Amount);
            _repairs = Expenses.Where(x => x.SubCategory == "Repairs").Sum(x => x.Amount);
            _parking = Expenses.Where(x => x.SubCategory == "Parking").Sum(x => x.Amount);
            _clothing = Expenses.Where(x => x.SubCategory == "Clothing").Sum(x => x.Amount);
            _gifts = Expenses.Where(x => x.SubCategory == "Gifts").Sum(x => x.Amount);
            _books = Expenses.Where(x => x.SubCategory == "Books").Sum(x => x.Amount);

            PieExpense = new List<CompanyExpense>
                {
                    new CompanyExpense {ExpenseCategory = "Home", Amount = _homeAmount},
                    new CompanyExpense {ExpenseCategory = "Daily Living", Amount = _securityAmount},
                    new CompanyExpense {ExpenseCategory = "Entertainment", Amount = _entertainmentAmount},
                    new CompanyExpense {ExpenseCategory = "Health", Amount = _healthAmount},
                    new CompanyExpense {ExpenseCategory = "Transportation", Amount = _transportAmount},
                    new CompanyExpense {ExpenseCategory = "Personal", Amount = _transportAmount}
                };

            Home = new List<CompanyExpense>
                {
                    new CompanyExpense {ExpenseCategory = "Mortgage/rent", Amount = _mortgage},
                    new CompanyExpense {ExpenseCategory = "Home repairs", Amount = _homerepair},
                    new CompanyExpense {ExpenseCategory = "Utilities", Amount = _utilities},
                    new CompanyExpense {ExpenseCategory = "Home improvement", Amount = _homeImprovement},
                    new CompanyExpense {ExpenseCategory = "Mobile telephone", Amount = _mobileTelephone}
                };

            DailyLiving = new List<CompanyExpense>
                {
                    new CompanyExpense {ExpenseCategory = "Dry cleaning", Amount = _drycleaing},
                    new CompanyExpense {ExpenseCategory = "Dining out", Amount = _dininout},
                    new CompanyExpense {ExpenseCategory = "Groceries", Amount = _groceries}
                };

            Entertainment = new List<CompanyExpense>
                {
                    new CompanyExpense {ExpenseCategory = "Movies/plays", Amount = _movies},
                    new CompanyExpense {ExpenseCategory = "Concerts/clubs", Amount = _clubs}
                };

            Health = new List<CompanyExpense>
                {
                    new CompanyExpense {ExpenseCategory = "Insurance (H)", Amount = _insurance},
                    new CompanyExpense {ExpenseCategory = "Prescriptions", Amount = _prescriptions}
                };

            Transportation = new List<CompanyExpense>
                {
                    new CompanyExpense {ExpenseCategory = "Gas/fuel", Amount = _gas},
                    new CompanyExpense {ExpenseCategory = "Repairs", Amount = _repairs},
                    new CompanyExpense {ExpenseCategory = "Parking", Amount = _parking}
                };

            Personal = new List<CompanyExpense>
                {
                    new CompanyExpense {ExpenseCategory = "Clothing", Amount = _clothing},
                    new CompanyExpense {ExpenseCategory = "Gifts", Amount = _gifts},
                    new CompanyExpense {ExpenseCategory = "Books", Amount = _books}
                };

            PieConverter = new List<CompanyExpense>();
            PieConverter = PieExpense;

            #endregion
        }

        public string MostSpent { get; set; }

        public string LeastSpent { get; set; }

        public string AverageSpent { get; set; }

        public List<CompanyExpense> Personal { get; set; }

        public List<CompanyExpense> Transportation { get; set; }

        public List<CompanyExpense> Health { get; set; }

        public List<CompanyExpense> Entertainment { get; set; }

        public List<CompanyExpense> DailyLiving { get; set; }

        public List<CompanyExpense> Home { get; set; }

        public List<CompanyExpense> PieExpense { get; set; }

        public List<CompanyExpense> PieConverter { get; set; }

        public List<ExpenseData> TotalExpenses { get; set; }

        public List<ExpenseData> Expenses { get; set; }

        public double PositiveAmount { get; set; }

        public double NegativeAmount { get; set; }

        public double BalanceAmount { get; set; }

        public int NoPositiveTransactions { get; set; }

        public int NoNegativeTransactions { get; set; }

        public int NoTotalTransactions { get; set; }
    }

    public class CompanyExpense
    {
        public string ExpenseCategory { get; set; }
        public double Amount { get; set; }
    }
}
