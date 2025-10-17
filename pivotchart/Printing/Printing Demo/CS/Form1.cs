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
using System.Drawing.Printing;

namespace PrintingDemo
{
    public partial class Form1 : MetroForm
    {
        #region Private Variables

        private PrintPreviewDialog printPreviewDialog1;
        private PrintDocument printPreviewDocument;
        private PrintDialog printDialog1;

        #endregion

        #region Constructor

        public Form1()
        {
            InitializeComponent();
            InitializePivotChart();
            InitializePrintPreviewDialog();
        }

        #endregion

        #region PivotChart Settings

        private void InitializePivotChart()
        {
            // Adding ItemSource to the Control
            pivotChart1.ItemSource = ProductSalesData.GetSalesData();

            // Adding PivotAxis to the Control
            pivotChart1.PivotAxis.Add(new PivotItem { FieldMappingName = "Date", TotalHeader = "Total" });
            pivotChart1.PivotAxis.Add(new PivotItem { FieldMappingName = "Product", TotalHeader = "Total" });

            // Adding PivotLegend to the Control
            pivotChart1.PivotLegend.Add(new PivotItem { FieldMappingName = "Country", TotalHeader = "Total" });

            // Adding PivotCalculations to the Control
            pivotChart1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Amount", Format = "#,##0", SummaryType = SummaryType.DoubleTotalSum });
        }

        #endregion
        
        #region Print Preview Settings

        private void InitializePrintPreviewDialog()
        {
            printDialog1 = new PrintDialog();
            //print review dialog
            printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(700, 450);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Icon = ((Icon)(this.resources.GetObject("$this.Icon1")));
            printPreviewDialog1.Visible = false;
            printPreviewDialog1.MouseWheel += new MouseEventHandler(printPreviewDialog1_MouseWheel);
            printPreviewDialog1.StartPosition = FormStartPosition.CenterScreen;
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// used to preview the pivotchart.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDocument = pivotChart1.PrintDocument;
                printPreviewDialog1.Document = printPreviewDocument;
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// used to print the pivotchart.
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            printDialog1.Document = pivotChart1.PrintDocument;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                pivotChart1.PrintDocument.Print();
            }
        }

        private void printPreviewDialog1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                SendKeys.Send("{UP}");
            }
            else
            {
                SendKeys.Send("{DOWN}");
            }
        }

        #endregion        
    }
}