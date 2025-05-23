#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.PivotAnalysis.Base;
using Syncfusion.PivotConverter;
using Syncfusion.Windows.Forms;
using Syncfusion.XlsIO;

namespace PivotGridExportDemo
{
    public partial class Form1 : MetroForm
    {
        #region Constructor

        public Form1()
        {
            InitializeComponent();
            PivotGridSettings();           
        }

        #endregion

        #region Pivot Grid Settings

        /// <summary>
        /// PivotGrid settings customization
        /// </summary>
        private void PivotGridSettings()
        {
            pivotGridControl1.GridVisualStyles = GridVisualStyles.Metro;

            pivotGridControl1.ItemSource = ProductSalesData.GetSalesData();
            pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Product", TotalHeader = "Total" });
            pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Year", TotalHeader = "Total" });

            pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "Country", TotalHeader = "Total" });
            pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "State", TotalHeader = "Total" });

            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Amount", Format = "$ #,##0.00" });
            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Quantity", Format = "#,##0" });

            pivotGridControl1.ShowGroupBar = true;
            pivotGridControl1.AllowFiltering = true;
            pivotGridControl1.AllowSorting = true;

            StringCollection ar = new StringCollection();
            ar.Add("Pivot Table");
            ar.Add("Cell");
            comboBoxAdv1.DataSource = ar;

            //tab key navigation set as false to move the next control
            pivotGridControl1.TableControl.WantTabKey = false;
        }

        #endregion

        #region Event Handlers
   
        // To handle the PDF file 
        private void buttonAdv3_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.AddExtension = true;
            savedialog.FileName = "Sample";
            savedialog.DefaultExt = "pdf";
            savedialog.Filter = @"Pdf file (.pdf)|*.pdf";
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                PivotPdfExport pdfExport = new PivotPdfExport(pivotGridControl1);
                pdfExport.Export(savedialog.FileName);

                if (MessageBox.Show(@"Export Success! Do you want to open the exported file?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
#if !NETCORE
                Process.Start(savedialog.FileName);
#else
                {
                    var p = new Process();
                    p.StartInfo = new ProcessStartInfo(savedialog.FileName)
                    {
                        UseShellExecute = true
                    };
                    p.Start();
                }
#endif
            }
        }

        // To handle the word file 
        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.AddExtension = true;
            savedialog.FileName = "Sample";
            savedialog.DefaultExt = "Doc";
            savedialog.Filter = @"Word file (.Doc)|*.Doc";
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                PivotWordExport wordExport = new PivotWordExport(pivotGridControl1);
                wordExport.pivotGridToWord(savedialog.FileName);

                if (MessageBox.Show(@"Export Success! Do you want to open the exported file?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
#if !NETCORE
                Process.Start(savedialog.FileName);
#else
                {
                    var p = new Process();
                    p.StartInfo = new ProcessStartInfo(savedialog.FileName)
                    {
                        UseShellExecute = true
                    };
                    p.Start();
                }
#endif
            }
        }

        // To handle the excel file 
        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            var ExportAsPivotTable = (comboBoxAdv1.SelectedIndex == 0);

            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.AddExtension = true;
            savedialog.FileName = "Sample";
            savedialog.DefaultExt = "xlsx";
            savedialog.Filter = @"Excel file (.xlsx)|*.xlsx";

            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                ExcelExport excelExport = new ExcelExport(pivotGridControl1, ExcelVersion.Excel2010);
                excelExport.ExportMode = (ExportAsPivotTable) ? ExportModes.PivotTable : ExportModes.Cell;
                excelExport.Export(savedialog.FileName);

                if (MessageBox.Show(@"Export Success! Do you want to open the exported file?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
#if !NETCORE
                Process.Start(savedialog.FileName);
#else
                {
                    var p = new Process();
                    p.StartInfo = new ProcessStartInfo(savedialog.FileName)
                    {
                        UseShellExecute = true
                    };
                    p.Start();
                }
#endif
            }
        }

        #endregion
    }
}