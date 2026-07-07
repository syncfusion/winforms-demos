#region Copyright Syncfusion Inc. 2001 - 2018.
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.PivotAnalysis.Base;
using System.Diagnostics;
using Syncfusion.PivotConverter;

namespace ExportingDemo
{
    public partial class Form1 : MetroForm
    {
        #region Constructor

        public Form1()
        {
            InitializeComponent();
            this.InitializePivotChart();
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
            this.pivotChart1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Quantity", Format = "#,##0", SummaryType = SummaryType.DoubleTotalSum });

            this.pivotChart1.CustomPalette = new Color[]{
                Color.FromArgb(68, 114, 196),
                Color.FromArgb(56, 83, 164),
                Color.FromArgb(112, 173, 71),
                Color.FromArgb(243, 236, 25),
                Color.FromArgb(165,165,165),
            };
        }

        #endregion

        #region Event Handlers

        void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.AddExtension = true;
            savedialog.FileName = "Sample";
            savedialog.DefaultExt = "xlsx";
            savedialog.Filter = "Excel file (.xlsx)|*.xlsx";
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                ExcelExport excelExport = new ExcelExport(this.pivotChart1, Syncfusion.XlsIO.ExcelVersion.Excel2010, Syncfusion.XlsIO.ExcelChartType.Column_Clustered);
                excelExport.Export(savedialog.FileName);
                if (MessageBox.Show("Export Success! Do you want to open the exported file?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
#if !NETCORE
                    Process.Start(savedialog.FileName);
#else
                    var p = new Process();
                    p.StartInfo = new ProcessStartInfo(savedialog.FileName)
                    {
                        UseShellExecute = true
                    };
                    p.Start();
#endif
                }
            }
        }

        #endregion
    }
}