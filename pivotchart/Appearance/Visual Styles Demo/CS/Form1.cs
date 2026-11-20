#region Copyright Syncfusion Inc. 2001 - 2018.
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using Syncfusion.Windows.Forms;
using Syncfusion.PivotAnalysis.Base;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Chart;

namespace VisualStylesDemo
{
    public partial class Form1 : MetroForm
    {
        #region Constructor

        public Form1()
        {
            InitializeComponent();
            InitializePivotChart();
        }

        #endregion

        #region PivotChart Settings

        private void InitializePivotChart()
        {
            // Adding ItemSource to the Control
            this.pivotChart1.ItemSource = ProductSalesData.GetSalesData();

            // Adding PivotAxis to the Control
            this.pivotChart1.PivotAxis.Add(new PivotItem { FieldMappingName = "Product", TotalHeader = "Total" });
            this.pivotChart1.PivotAxis.Add(new PivotItem { FieldMappingName = "Date", TotalHeader = "Total" });

            // Adding PivotLegend to the Control
            this.pivotChart1.PivotLegend.Add(new PivotItem { FieldMappingName = "Country", TotalHeader = "Total" });

            // Adding PivotCalculations to the Control
            this.pivotChart1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Quantity", Format = "#,##0" });
            this.pivotChart1.Skins = Skins.Metro;
            this.pivotChart1.ShowLegend = true;
            this.pivotChart1.AllowDrillDown = true;
            this.pivotChart1.AxisFieldSection.Visible = true;
            this.pivotChart1.LegendFieldSection.Visible = true;
            this.pivotChart1.FilterFieldSection.Visible = true;
            this.pivotChart1.ValueFieldSection.Visible = true;
            this.pivotChart1.ShowPivotTableFieldList = true;
        }

        #endregion

        #region Event Handlers

        private void VisualStyle_CheckChanged(object sender, EventArgs e)
        {
            var radioButtonAdv = (sender as RadioButtonAdv);
            if (radioButtonAdv.Checked)
            {
                this.pivotChart1.ApplyVisualStyle(radioButtonAdv.Tag.ToString());
            }
        }

        #endregion
    }
}