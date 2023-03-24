#region Copyright Syncfusion Inc. 2001 - 2023
//
//  Copyright Syncfusion Inc. 2001 - 2023. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Diagnostics;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using Syncfusion.XlsIO.Implementation;
using Syncfusion.Windows.Forms;

namespace EssentialXlsIOSamples
{
    public partial class HTMLToWorksheet : MetroForm
    {
        #region Constants
#if NETCORE
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\common\Data\XlsIO\{0}";
#else
        private const string DEFAULTPATH = @"..\..\..\..\..\..\common\Data\XlsIO\{0}";
#endif
        #endregion
        
        #region Initialize
        public HTMLToWorksheet()
        {
            InitializeComponent();
        }
        #endregion

        #region Convert HTML table to worksheet.
        private void btnConvert_Click(object sender, EventArgs e)
        {
            // New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            // The instantiation process consists of two steps.

            // Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();

            // Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;

            // Workbook is created.
            IWorkbook workbook = application.Workbooks.Create(1);

            workbook.Version = ExcelVersion.Excel2016;

            // The first worksheet object in the worksheets collection is accessed.
            IWorksheet sheet = workbook.Worksheets[0];

            if (checkBox1.Checked)
            {
                sheet.ImportHtmlTable(GetFullTemplatePath("HTMLwithFormulaToExcel.html"), 1, 1, HtmlImportOptions.DetectFormulas);
                sheet.Range["E2:F25"].NumberFormat = "_($* #,##0.00_);_($* (#,##0.00)";
                sheet.Range["H2:I25"].NumberFormat = "_($* #,##0.00_);_($* (#,##0.00)";
            }
            else
            {
                sheet.ImportHtmlTable(GetFullTemplatePath("HTMLToExcel.html"), 1, 1);
            }

            sheet.UsedRange.AutofitColumns();
			sheet.UsedRange.AutofitRows();

            string fileName = "Import-HTML-Table.xlsx";

            workbook.SaveAs(fileName);

            #region Workbook Close and Dispose
            //Close the excelEngine
            excelEngine.Dispose();
            #endregion

            #region View the Workbook
            //Message box confirmation to view the created spreadsheet.
            if (MessageBox.Show("Do you want to view the Workbook?", "Conversion successful",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                //Launching the Excels file using the default Application.[MS Excel Or Free ExcelViewer]
#if NETCORE
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo = new System.Diagnostics.ProcessStartInfo(fileName)
                {
                    UseShellExecute = true
                };
                process.Start();
#else
                Process.Start(fileName);
#endif
                //Exit
                this.Close();
            }
            else
            {
                // Exit
                this.Close();
            }
            #endregion
        }
        #endregion

        #region HelperMethods
        /// <summary>
        /// Get the file path of input file and return the same
        /// </summary>
        /// <param name="inputPath">Input file</param>
        /// <returns>File path of the Input file</returns>
        private string GetFullTemplatePath(string inputFile)
        {
            return string.Format(DEFAULTPATH, inputFile);
        }
        #endregion       

        #region View the Input file
        private void viewInputTemplate_Click(object sender, EventArgs e)
        {
            string inputPath;
            //Get the path of the input file
            if (checkBox1.Checked)
            {
                inputPath = GetFullTemplatePath("HTMLwithFormulaToExcel.html");
            }
            else
            {
                inputPath = GetFullTemplatePath("HTMLToExcel.html");
            }
            //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
#if NETCORE
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo(inputPath)
            {
                UseShellExecute = true
            };
            process.Start();
#else
            Process.Start(inputPath);
#endif
        }
        #endregion

       
    }
}