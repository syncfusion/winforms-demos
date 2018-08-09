#region Copyright Syncfusion Inc. 2001 - 2009
//
//  Copyright Syncfusion Inc. 2001 - 2009. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using Syncfusion.XlsIO.Implementation;
using Syncfusion.Windows.Forms;

namespace EssentialXlsIOSamples
{
    public partial class WorksheetToHTML : MetroForm
    {
        #region Constants
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\Common\Data\XlsIO\{0}";
        #endregion

        #region Initialize
        public WorksheetToHTML()
        {
            InitializeComponent();
        }
        #endregion

        #region Convert Worksheet or Workbook to HTML
        private void btnConvert_Click(object sender, EventArgs e)
        {
            string fileName = "";

            #region Workbook Initialization
            //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;

            //Get the path of the Input file
            string inputPath = GetFullTemplatePath("NorthwindTemplate.xls");
            
            // Existing workbook is opened
            IWorkbook workbook = application.Workbooks.Open(inputPath);

            // The first worksheet object in the worksheets collection is accessed.
            IWorksheet worksheet = workbook.Worksheets[0];
            #endregion

            #region Save Workbook or Worksheet

            if (rdbWkSheet.Checked)
            {
                // Save the sheet as HTML
                fileName = "WorksheetToHTML.html";
                worksheet.SaveAsHtml(fileName);
            }
            else
            {
                //Save the book as HTML
                fileName = "WorkbookToHTML.html";
                workbook.SaveAsHtml(fileName, HtmlSaveOptions.Default);
            }
            #endregion

            #region Workbook Close and Dispose
            //Close the workbook and excelEngine
            workbook.Close();
            excelEngine.Dispose();
            #endregion

            #region View the Workbook
            //Message box confirmation to view the created spreadsheet.
            if (MessageBox.Show("Do you want to view the HTML?", "Conversion successful",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                //Launching the HTMl file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start(fileName);
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
            //Get the path of the input file
            string inputPath = GetFullTemplatePath("NorthwindTemplate.xls");
            //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
            System.Diagnostics.Process.Start(inputPath);
        }
        #endregion
    }
}