#region Copyright Syncfusion Inc. 2001 - 2018.
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Windows.Forms;
using Syncfusion.PivotAnalysis.Base;
using Syncfusion.Windows.Forms;

namespace ZoomingScrollingDemo
{
    public partial class Form1 : MetroForm
    {
        #region Constructor

        public Form1()
        {
            InitializeComponent();
            InitializePivotChart();
            comboBox1.SelectedItem = "0.3";
            comboBox2.SelectedItem = "0.5";
            pivotChart1.EnableYZooming = this.checkBox2.Checked;
        }

        #endregion

        #region PivotChart Settings

        private void InitializePivotChart()
        {
            // Adding ItemSource to the Control
            pivotChart1.ItemSource = ProductSalesData.GetSalesData();

            // Adding PivotAxis to the Control
            pivotChart1.PivotAxis.Add(new PivotItem { FieldMappingName = "Product", TotalHeader = "Total" });
            pivotChart1.PivotAxis.Add(new PivotItem { FieldMappingName = "Date", TotalHeader = "Total" });

            // Adding PivotLegend to the Control
            pivotChart1.PivotLegend.Add(new PivotItem { FieldMappingName = "Country", TotalHeader = "Total" });
            pivotChart1.PivotLegend.Add(new PivotItem { FieldMappingName = "State", TotalHeader = "Total" });

            // Adding PivotCalculations to the Control
            pivotChart1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Amount", Format = "#,##0", SummaryType = SummaryType.DoubleTotalSum });
            pivotChart1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Quantity", Format = "#,##0" });            
        }

        #endregion

        #region Event Handlers

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pivotChart1.EnableXZooming = checkBox1.Checked;
            if (pivotChart1.EnableXZooming)
                this.comboBox2.Enabled = true;
            else
                this.comboBox2.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            pivotChart1.EnableYZooming = checkBox2.Checked;
            if (pivotChart1.EnableYZooming)
                this.comboBox1.Enabled = true;
            else
                this.comboBox1.Enabled = false;
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            if (combo != null && combo.SelectedItem != null)
            {               
                if (pivotChart1.EnableXZooming)
                {
                    if (combo == comboBox2)
                    {
                        double result;
                        double.TryParse(combo.SelectedItem.ToString(), out result);
                        pivotChart1.PrimaryXAxis.ZoomFactor = result;
                    }
                }
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            if (combo != null && combo.SelectedItem != null)
            {
                if (pivotChart1.EnableYZooming)
                {
                    if (combo == comboBox1)
                    {
                        double result;
                        double.TryParse(combo.SelectedItem.ToString(), out result);
                        //zoom factor level customization for respective axis
                        pivotChart1.PrimaryYAxis.ZoomFactor = result;
                    }
                }
            }
        }

        #endregion
    }
}