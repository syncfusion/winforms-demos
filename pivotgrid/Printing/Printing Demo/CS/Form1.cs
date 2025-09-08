#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Syncfusion.GridHelperClasses;
using Syncfusion.PivotAnalysis.Base;
using Syncfusion.Windows.Forms;

namespace PivotGridDemo
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
        /// Grid Settings for better look and feel
        /// </summary>
        private void InitializePivotGrid()
        {
            pivotGridControl1.TableControl.ThemesEnabled = true;
            pivotGridControl1.GridVisualStyles = GridVisualStyles.Metro;

            // Adding ItemSource to the Control
            pivotGridControl1.ItemSource = ProductSalesData.GetSalesData();

            // Adding PivotRows to the Control
            pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Product", TotalHeader = "Total" });

            pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Date", TotalHeader = "Total" });

            // Adding PivotColumns to the Control
            pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "Country", TotalHeader = "Total" });

            pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "State", TotalHeader = "Total" });

            // Adding PivotCalculations to the Control
            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Amount", Format = "$ #,##0.00", SummaryType = SummaryType.DoubleTotalSum });

            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Quantity", Format = "#,##0" });

            //tab key navigation set as false to move the next control
            pivotGridControl1.TableControl.WantTabKey = false;

        }

        #endregion

        #region Event Handlers

        void previewDialog_MouseWheel(object sender, MouseEventArgs e)
        {
            SendKeys.Send(e.Delta > 0 ? "{UP}" : "{DOWN}");
        }

        /// <summary>
        /// preview the pivotGrid for print
        /// </summary>
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                PrintPreviewDialog previewDialog = new PrintPreviewDialog();
                previewDialog.MouseWheel += previewDialog_MouseWheel;
                previewDialog.StartPosition = FormStartPosition.CenterScreen;
                previewDialog.Size = new Size(700, 450);
                PivotGridPrintDocumentAdv pd = new PivotGridPrintDocumentAdv(pivotGridControl1);
                pd.DefaultPageSettings.Margins = new Margins(25, 25, 25, 25);
                previewDialog.Document = pd;
                previewDialog.Icon = ((Icon)(resources.GetObject("$this.Icon1")));
                previewDialog.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error while printing preview\n" + ex.Message);
            }
        }

        #endregion
    }
}