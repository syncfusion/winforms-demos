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
using Syncfusion.Pdf;
using Syncfusion.ExcelToPdfConverter;
using System.Collections.Generic;
using System.IO;

namespace EssentialXlsIOSamples
{
    public partial class Comments : MetroForm
    {
        #region Constants
#if NETCORE
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\common\Data\XlsIO\{0}";
#else
        private const string DEFAULTPATH = @"..\..\..\..\..\..\common\Data\XlsIO\{0}";
#endif
        #endregion
        
        #region Initialize
        public Comments()
        {
            InitializeComponent();
        }
        #endregion

        #region Create Excel document
        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Initialize ExcelEngine
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                //Initialize IApplication and set the default application version
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Xlsx;

                //Load the Excel template into IWorkbook and get the worksheet into IWorksheet
                IWorkbook workbook = application.Workbooks.Open(GetFullTemplatePath("CommentsTemplate.xlsx"));
                IWorksheet worksheet = workbook.Worksheets[0];

                //Add Comments
                AddComments(worksheet);

                string fileName = "ExcelComments.xlsx";
                workbook.SaveAs(fileName);

                #region Workbook Close and Dispose
                //Close the excelEngine
                excelEngine.Dispose();
                #endregion

                #region View the Workbook
                //Message box confirmation to view the created spreadsheet.
                if (MessageBox.Show("Do you want to view the Workbook?", "Creation successful",
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
                }
                #endregion
            }
        }
        #endregion

        #region Convert Excel document to PDF
        private void btnConvert_Click(object sender, EventArgs e)
        {
            //Initialize ExcelEngine
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                //Initialize IApplication and set the default application version
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Xlsx;

                //Load the Excel template into IWorkbook and get the worksheet into IWorksheet
                IWorkbook workbook = application.Workbooks.Open(GetFullTemplatePath("CommentsTemplate.xlsx"));
                IWorksheet worksheet = workbook.Worksheets[0];

                //Add Comments
                AddComments(worksheet);

                //Set print location of comments
                worksheet.PageSetup.PrintComments = ExcelPrintLocation.PrintSheetEnd;

                //Initialize ExcelToPdfConverter and PdfDocument
                ExcelToPdfConverter converter = new ExcelToPdfConverter(workbook);
                PdfDocument pdfDocument = new PdfDocument();

                //Convert Excel document to PDF
                pdfDocument = converter.Convert();

                string fileName = "ExcelComments.pdf";
                pdfDocument.Save(fileName);

                #region Workbook Close and Dispose
                //Close the excelEngine
                excelEngine.Dispose();
                #endregion

                #region View the Workbook
                //Message box confirmation to view the created PDF.
                if (MessageBox.Show("Do you want to view the PDF document?", "Conversion successful",
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
                }
                #endregion
            }
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

        #region Add comments
        private void AddComments(IWorksheet worksheet)
        {
            //Add Comments (Notes)
            IComment comment = worksheet.Range["H1"].AddComment();
            comment.Text = "This Total column comment will be printed at the end of sheet.";
            comment.IsVisible = true;

            //Add Threaded Comments
            IThreadedComment threadedComment = worksheet.Range["H16"].AddThreadedComment("What is the reason for the higher total amount of \"desk\"  in the west region?", "User1", DateTime.Now);
            threadedComment.AddReply("The unit cost of desk is higher compared to other items in the west region. As a result, the total amount is elevated.", "User2", DateTime.Now);
            threadedComment.AddReply("Additionally, Wilson sold 31 desks in the west region, which is also a contributing factor to the increased total amount.", "User3", DateTime.Now);
        }
        #endregion

        #region View the Input file
        private void btnInput_Click(object sender, EventArgs e)
        {
            string inputPath = GetFullTemplatePath("CommentsTemplate.xlsx");
            
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