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

namespace HyperlinkDemo
{
    public partial class Form1 : MetroForm
    {
        #region Constructor

        public Form1()
        {
            InitializeComponent();
            InitializePivotGrid();
            this.checkBox1.Checked = false;
        }

        #endregion      

        #region Pivot Grid Settings

        /// <summary>
        /// The Pivot Grid settings for populating the Pivot Rows and Pivot Columns
        /// </summary>
        private void InitializePivotGrid()
        {
            // Adding ItemSource to the Control
            pivotGridControl1.ItemSource = ProductSalesData.GetSalesData();

            // Adding PivotRows to the Control
            pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Product", TotalHeader = "Total" });

            pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Date", TotalHeader = "Total" });

            // Adding PivotColumns to the Control
            pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "Country", TotalHeader = "Total" });

            // Adding PivotCalculations to the Control
            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Amount", Format = "$ #,##0.00", SummaryType = SummaryType.DoubleTotalSum });

            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Quantity", Format = "#,##0" });

            this.pivotGridControl1.TableModel.QueryCellInfo += TableModel_QueryCellInfo;

            //tab key navigation set as false to move the next control
            pivotGridControl1.TableControl.WantTabKey = false;
        }
        #endregion

        #region Event Handlers

        //set the cell style settings customization
        void TableModel_QueryCellInfo(object sender, Syncfusion.Windows.Forms.Grid.GridQueryCellInfoEventArgs e)
        {
            if (e.RowIndex > this.pivotGridControl1.PivotColumns.Count + (this.pivotGridControl1.PivotCalculations.Count > 1 && this.pivotGridControl1.PivotEngine.ShowCalculationsAsColumns ? 1 : 0) && e.ColIndex > this.pivotGridControl1.PivotRows.Count + (this.pivotGridControl1.PivotEngine.ShowCalculationsAsColumns ? 0 : 1) && e.Style.CellValue != null)
            {
                e.Style.CellType = this.checkBox1.Checked ? "HyperlinkCell" : "TextBox";
                e.Style.Tag = null;
            }
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            pivotGridControl1.TableModel.Refresh();
            pivotGridControl1.Refresh();
        }

        #endregion
    }
}