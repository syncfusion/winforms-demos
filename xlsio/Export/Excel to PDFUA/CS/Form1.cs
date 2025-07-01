#region Copyright Syncfusion Inc. 2001 - 2019
//
//  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using Syncfusion.ExcelToPdfConverter;
using Syncfusion.Pdf;
using Syncfusion.Windows.Forms;
using Syncfusion.XlsIO.Implementation;
using Syncfusion.ExcelChartToImageConverter;
using System.IO;
using System.Reflection;

namespace ExceltoPDF
{
    public partial class Form1 : MetroForm
    {
        private bool isBrowsed = false;
        #region Constants
#if NETCORE
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\common\Data\XlsIO\{0}";
#else
        private const string DEFAULTPATH = @"..\..\..\..\..\..\common\Data\XlsIO\{0}";
#endif
        #endregion

        #region Initialize
        public Form1()
        {
            InitializeComponent();
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
                application.ChartToImageConverter = new ChartToImageConverter();
                //Set the Quality of chart Image
                application.ChartToImageConverter.ScalingMode = ScalingMode.Best;
                IWorkbook workbook = null;
                if (isBrowsed)
                {
                    //Load the Excel template into IWorkbook and get the worksheet into IWorksheet
                    workbook = application.Workbooks.Open((string)this.fileName.Tag);
                }
                else
                {
                    //Load the Excel template into IWorkbook and get the worksheet into IWorksheet
                    workbook = application.Workbooks.Open(GetFullTemplatePath("ExcelToPDFUA.xlsx"));
                }
                //Intialize the ExcelToPdfConverterSettings class
                ExcelToPdfConverter converter = new ExcelToPdfConverter(workbook);

                //Intialize the PdfDocument Class
                PdfDocument pdfDoc = new PdfDocument();

                //Intialize the ExcelToPdfConverterSettings class
                ExcelToPdfConverterSettings settings = new ExcelToPdfConverterSettings();

                //Enable the tagged PDF convertion settings.
                settings.AutoTag = true;

                //Convert the Excel document to PDf
                pdfDoc = converter.Convert(settings);

                string fileName = "ExcelToPDF.pdf";
                pdfDoc.Save(fileName);

                #region Workbook Close and Dispose
                //Close the excelEngine
                excelEngine.Dispose();
                #endregion

                #region View the Workbook
                //Message box confirmation to view the created spreadsheet.
                if (MessageBox.Show("Do you want to view the PDF?", "Creation successful",
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
        private void btnBrowse_Click(object sender, EventArgs e)
        {
#if NETCORE
            openFileDialog1.InitialDirectory = Application.StartupPath + @"..\..\..\..\..\..\..\..\common\Data\XlsIO\";
#else
            openFileDialog1.InitialDirectory = Application.StartupPath + @"..\..\..\..\..\..\..\common\Data\XlsIO\";
#endif
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Excel|*.xls;*.xlsx;*.csv;*.tsv;*.xml;*.xlsm;*.xlst;*.xlsb";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.fileName.Text = openFileDialog1.SafeFileName;
                this.fileName.Tag = openFileDialog1.FileName;
                isBrowsed = true;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = "ExcelToPDF.xlsx";
#if NETCORE
            this.textBox1.Tag = @"..\..\..\..\..\..\..\common\Data\XlsIO\ExcelToPDFUA.xlsx";
#else
            this.textBox1.Tag = @"..\..\..\..\..\..\common\Data\XlsIO\ExcelToPDFUA.xlsx";
#endif
        }
        #region View the Input file
        private void btnInput_Click(object sender, EventArgs e)
        {
            string inputPath = GetFullTemplatePath("ExcelToPDFUA.xlsx");

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