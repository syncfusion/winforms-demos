#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.PivotAnalysis.Base;
using Syncfusion.Windows.Forms;

namespace AsyncLoading
{
    public partial class Form1 : MetroForm
    {
        #region Fields

        public static int recordCount = 200000;
        LoadData form1 = new LoadData();

        #endregion

        #region Constructor

        public Form1()
        {
            InitializeComponent();
            PivotGridSettings();
            Shown += Form1_Shown;
        }

        #endregion

        #region Pivot Grid Settings

        /// <summary>
        /// The grid settings can be customized
        /// </summary>
        private void PivotGridSettings()
        {
            //enables to display the group bar
            pivotGridControl1.ShowGroupBar = true;

            pivotGridControl1.AllowFiltering = true;
            pivotGridControl1.AllowSorting = true;

            //tab key navigation set as false to move the next control
            //this.pivotGridControl1.TableControl.WantTabKey = false;

            pivotGridControl1.ShowPivotTableFieldList = true;

            pivotGridControl1.EnableAsyncLoading = true;
            
            pivotGridControl1.AsyncLoadStarted += pivotGridControl1_AsyncLoadStarted;
            pivotGridControl1.AsyncLoadCompleted += pivotGridControl1_AsyncLoadCompleted;
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Creating the DataSource
        /// </summary>
        void Form1_Shown(object sender, EventArgs e)
        {
            if (form1.ShowDialog(this) == DialogResult.Cancel)
            {
                Close();
                return;
            }
            form1.Close();
            pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Product", TotalHeader = "Total" });
            pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Year", TotalHeader = "Total", Format = "#,##0" });
            pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "Country", TotalHeader = "Total" });
            pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "State", TotalHeader = "Total" });
            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Quantity", Format = "#,##0" });
            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Amount", Format = "$ #,##0.00" });
            pivotGridControl1.ItemSource = ProductSalesData.GetSalesData(recordCount);
        }

        void pivotGridControl1_AsyncLoadStarted(object sender, CancelEventArgs e)
        {
            pivotGridControl1.Enabled = false;
        }

        void pivotGridControl1_AsyncLoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            pivotGridControl1.Enabled = true;
        }

        #endregion
    }
}