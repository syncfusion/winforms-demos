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
using Syncfusion.Windows.Forms.PivotAnalysis;

namespace EditingDemo
{
    public partial class Form1 : MetroForm
    {
        #region Fields

        private ProductSalesCollection productSalesData = ProductSalesData.GetSalesData();

        #endregion;

        #region Constructor

        public Form1()
        {
            InitializeComponent();
            PivotGridSettings();
            SampleCustomization();
        }

        #endregion

        #region Pivot Grid Settings

        /// <summary>
        /// Pivot Grid Settings for populating the Pivot Rows and Columns
        /// </summary>
        private void PivotGridSettings()
        {
            pivotGridControl1.ItemSource = productSalesData;// ProductSales.GetSalesData();

            pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Product", TotalHeader = "Total" });

            pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Date", TotalHeader = "Total" });

            pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "Country", TotalHeader = "Total" });

            pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "State", TotalHeader = "Total" });

            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Amount", Format = "C", SummaryType = SummaryType.DoubleTotalSum });

            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Quantity", Format = "#,##0" });

            //tab key navigation set as false to move the next control
            pivotGridControl1.TableControl.WantTabKey = false;
        }

        #endregion

        #region Sample Customization

        /// <summary>
        /// The Grid Settings can be Customized
        /// </summary>        
        private void SampleCustomization()
        {
            pivotGridControl1.ShowGroupBar = true;
            pivotGridControl1.EnableValueEditing = true;
            pivotGridControl1.EditManager.AllowEditingOfTotalCells = true;
        }

        #endregion

        #region Event Handlers

        //Enabling and Disabling the Editing mode of Pivot grid
        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            pivotGridControl1.EnableValueEditing = checkBoxAdv1.Checked;
            if (checkBoxAdv1.Checked)
                pivotGridControl1.EditManager.AllowEditingOfTotalCells = checkBoxAdv2.Checked;
            else
                checkBoxAdv3.Checked = true;
            checkBoxAdv2.Enabled = checkBoxAdv1.Checked;
            radioButtonAdv1.Enabled = checkBoxAdv1.Checked;
            radioButtonAdv2.Enabled = checkBoxAdv1.Checked;
            pivotGridControl1.TableControl.Refresh();
        }

        //allows the edit manager to editing the total cells
        private void checkBoxAdv2_CheckStateChanged(object sender, EventArgs e)
        {
            pivotGridControl1.EditManager.AllowEditingOfTotalCells = checkBoxAdv2.Checked;
            pivotGridControl1.TableControl.Refresh();
        }

        //enables the editing values
        private void checkBoxAdv3_CheckStateChanged(object sender, EventArgs e)
        {
            if (pivotGridControl1.EditManager == null)
            {
                pivotGridControl1.EditManager = new PivotEditingManager(pivotGridControl1.TableControl);
            }
            pivotGridControl1.EditManager.HideExpanders = !checkBoxAdv3.Checked;
            pivotGridControl1.TableControl.Refresh();
        }

        private void radioButtonAdv1_CheckChanged(object sender, EventArgs e)
        {
            this.pivotGridControl1.EditManager.Dispose(); //dispose the current one...
            this.pivotGridControl1.EditManager = radioButtonAdv1.Checked ?
                new PivotEditingManager(this.pivotGridControl1.TableControl) :
                new CustomEditingManager(this.pivotGridControl1.TableControl);
            this.pivotGridControl1.EditManager.HideExpanders = !this.checkBoxAdv3.Checked;
            this.pivotGridControl1.EditManager.AllowEditingOfTotalCells = checkBoxAdv2.Checked;
        }

        #endregion
    }
}