#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using Syncfusion.PivotAnalysis.Base;
using Syncfusion.Windows.Forms;

namespace PivotGridGroupBarDemo
{
    public partial class Form1 : MetroForm
    {
        #region Constructor

        public Form1()
        {
            InitializeComponent();
            InitializePivotGrid();
        }

        #endregion

        #region Pivot Grid Settings

        /// <summary>
        /// The grid settings can be customized
        /// </summary>
        private void InitializePivotGrid()
        {
            pivotGridControl1.ItemSource = ProductSalesData.GetSalesData();

            pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Product", TotalHeader = "Total" });
            pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Year", TotalHeader = "Total" });

            pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "Country", TotalHeader = "Total" });
            pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "State", TotalHeader = "Total" });

            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Amount", Format = "$ #,##0.00" });
            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Quantity", Format = "#,##0" });

            //enables to display the group bar
            pivotGridControl1.ShowGroupBar = true;

            pivotGridControl1.AllowFiltering = true;
            pivotGridControl1.AllowSorting = true;

            //tab key navigation set as false to move the next control
            pivotGridControl1.TableControl.WantTabKey = false;
        }

        #region Event Handlers

        // To enable sorting
        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            pivotGridControl1.AllowSorting = !pivotGridControl1.AllowSorting;
            pivotGridControl1.Refresh();
            Refresh();
        }

        // To enable filtering
        private void checkBoxAdv2_CheckStateChanged(object sender, EventArgs e)
        {
            pivotGridControl1.AllowFiltering = !pivotGridControl1.AllowFiltering;
            pivotGridControl1.Refresh();
            Refresh();
        }

        //To show or hide group bar
        private void checkBoxAdv3_CheckStateChanged(object sender, EventArgs e)
        {
            pivotGridControl1.ShowGroupBar = !pivotGridControl1.ShowGroupBar;
            checkBoxAdv1.Enabled = pivotGridControl1.ShowGroupBar;
            checkBoxAdv2.Enabled = pivotGridControl1.ShowGroupBar;
        }

        #endregion

        #endregion
    }
}