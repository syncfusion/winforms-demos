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

namespace CustomizationDemo
{
    public partial class Form1 : MetroForm
    {
        #region Private Members

        private bool isExpanded = true;

        #endregion

        #region Constructor

        public Form1()
        {
            InitializeComponent();
            InitializeGrid();
        }

        #endregion

        #region Grid Setting

        private void InitializeGrid()
        {
            pivotGridControl1.GridVisualStyles = GridVisualStyles.Metro;
            pivotGridControl1.ItemSource = ProductSalesData.GetSalesData();

            //used to add PivotRows.
            pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Product", TotalHeader = "Total" });
            pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Date", TotalHeader = "Total" });

            //used to add PivotColumns.
            pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "Country", TotalHeader = "Total" });
            pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "State", TotalHeader = "Total" });

            //used to add PivotCalculations.
            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Amount", Format = "C", SummaryType = SummaryType.DoubleTotalSum });
            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Quantity", Format = "#,##0" });

            //shows the pivot table field list.
            pivotGridControl1.ShowPivotTableFieldList = true;

            pivotGridControl1.ShowGroupBar = true;
            pivotGridControl1.TableControl.FreezeHeaders = true;
        }

        #endregion

        #region "Events"

        /// <summary>
        /// Set the GroupBar
        /// </summary>
        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            pivotGridControl1.ShowGroupBar = checkBox1.Checked;
        }

        /// <summary>
        /// Handling the SubTotals
        /// </summary>
        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            pivotGridControl1.ShowSubTotals = checkBox2.Checked;
        }

        /// <summary>
        /// Handling the Grand totals
        /// </summary>
        private void checkBox3_CheckStateChanged(object sender, EventArgs e)
        {
            pivotGridControl1.ShowGrandTotals = checkBox3.Checked;
        }

        /// <summary>
        /// Handling the pivot field table list
        /// </summary>
        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            pivotGridControl1.ShowPivotTableFieldList = checkBoxAdv1.Checked;
        }

        /// <summary>
        /// Freeze headers in the Grid.
        /// </summary>
        private void checkBoxAdv2_CheckStateChanged(object sender, EventArgs e)
        {
            pivotGridControl1.TableControl.FreezeHeaders = checkBoxAdv2.Checked;
        }

        /// <summary>
        /// Handles the expand collapse of the headers
        /// </summary>
        private void buttonAdv1_Clicked(object sender, EventArgs e)
        {
            if (this.isExpanded)
            {
                this.pivotGridControl1.TableControl.CollapseAllGroups();
                this.isExpanded = false;
            }
            else
            {
                this.pivotGridControl1.TableControl.ExpandAllGroups();
                this.isExpanded = true;
            }
            this.buttonAdv1.Text = this.isExpanded ? "Collapse Headers" : "Expand Headers";
        }

        #endregion
    }
}