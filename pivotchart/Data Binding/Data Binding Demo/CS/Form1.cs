#region Copyright Syncfusion Inc. 2001 - 2018.
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.Windows.Forms;
using Syncfusion.PivotAnalysis.Base;

namespace DataBindingDemo
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
            this.pivotChart1.ItemSource = new DataCollection();

            // Adding PivotAxis to the Control
            this.pivotChart1.PivotAxis.Add(new PivotItem { FieldMappingName = "Sex" });
            this.pivotChart1.PivotAxis.Add(new PivotItem { FieldMappingName = "Profession" });

            // Adding PivotLegend to the Control
            this.pivotChart1.PivotLegend.Add(new PivotItem { FieldMappingName = "City", TotalHeader = "Total" });

            // Adding PivotCalculations to the Control
            this.pivotChart1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Salary", Format = "#,##0", SummaryType = SummaryType.DoubleTotalSum });
            this.pivotChart1.EnableXZooming = true;
            this.pivotChart1.PrimaryXAxis.ZoomFactor = .7;
            this.pivotChart1.AllowDrillDown = true;
        }
        
        #endregion        
    }
}
