#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Windows.Forms;
using Syncfusion.Data;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;

namespace CustomGrouping
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : Form
    {
        #region constructor
        public Form1()
        {
            InitializeComponent();
            SalesInfoCollection sales = new SalesInfoCollection();
            sfDataGrid.DataSource = sales.DailySalesDetails;
            this.GridSettings();
        }
        #endregion

        #region Grid Settings

        /// <summary>
        /// Grid Settings for better Look and Feel.
        /// </summary>
        private void GridSettings()
        {
            //Applying SortComparer
            SortComparer sortcomparer = new SortComparer() { PropertyName = "Date", Comparer = new CustomSortComparer() };
            this.sfDataGrid.SortComparers.Add(sortcomparer);

            //Apply the CustomGrouping for DateColumn by using KeySelector.
            this.sfDataGrid.GroupColumnDescriptions.Add(new GroupColumnDescription()
            {
                ColumnName = "Date",
                KeySelector = (string ColumnName, object o) =>
                {
                    var dt = DateTime.Now;
                    var item = (o as SalesByDate).Date;
                    var days = (int)Math.Floor((dt - item).TotalDays);
                    var dayofweek = (int)dt.DayOfWeek;
                    var diff = days - dayofweek;
                    if (days <= dayofweek)
                    {
                        if (days == 0)
                            return "TODAY";
                        if (days == 1)
                            return "YESTERDAY";
                        return item.Date.DayOfWeek.ToString().ToUpper();
                    }
                    if (diff > 0 && diff <= 7)
                        return "LAST WEEK";
                    if (diff > 7 && diff <= 14)
                        return "TWO WEEKS AGO";
                    if (diff > 14 && diff <= 21)
                        return "THREE WEEKS AGO";
                    if (dt.Year == item.Date.Year && dt.Month == item.Date.Month)
                        return "EARLIER THIS MONTH";
                    if (DateTime.Now.AddMonths(-1).Month == item.Date.Month)
                        return "LAST MONTH";
                    return "OLDER";
                }
            });

            this.sfDataGrid.ExpandGroup(this.sfDataGrid.View.TopLevelGroup.Groups[0]);
        }
        
        #endregion
    }
}
