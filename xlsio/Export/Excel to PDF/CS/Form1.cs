#region Copyright Syncfusion Inc. 2001-2022
//
//  Copyright Syncfusion Inc. 2001-2022. All rights reserved.
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
        public Form1()
        {
            InitializeComponent();
        }
        private void browseExcelFileBtnClick(object sender, EventArgs e)
        {
#if NETCORE
            openFileDialog1.InitialDirectory = Application.StartupPath + @"..\..\..\..\..\..\..\..\common\Data\XlsIO\";
#else
            openFileDialog1.InitialDirectory = Application.StartupPath + @"..\..\..\..\..\..\..\common\Data\XlsIO\";
#endif
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Excel|*.xls;*.xlsx";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.textBox1.Text = openFileDialog1.SafeFileName;
                this.textBox1.Tag = openFileDialog1.FileName;
            }
        }
        private void excelToPdfConvertBtnClick(object sender, EventArgs e)
        {
            if (this.textBox1.Text != String.Empty)
            {
                ExcelEngine engine = new ExcelEngine();
                IApplication application = engine.Excel;
                if (checkfontName.Checked || checkfontStream.Checked)
                {
                    application.SubstituteFont += new SubstituteFontEventHandler(SubstituteFont);
                }
                IWorkbook book = application.Workbooks.Open((string)textBox1.Tag);
                application.ChartToImageConverter = new ChartToImageConverter();
                //Set the Quality of chart Image
                application.ChartToImageConverter.ScalingMode = ScalingMode.Best;
                //Open the Excel Document to Convert
                ExcelToPdfConverter converter = new ExcelToPdfConverter(book);
                
                //Intialize the PDFDocument
                PdfDocument pdfDoc = new PdfDocument();			
           
				
                //Intialize the ExcelToPdfconverterSettings
                ExcelToPdfConverterSettings settings = new ExcelToPdfConverterSettings();

                //Set the Layout Options for the output Pdf page.
                if (noScaleRadioBtn.Checked)
                    settings.LayoutOptions = LayoutOptions.NoScaling;
                else if (allRowsRadioBtn.Checked)
                    settings.LayoutOptions = LayoutOptions.FitAllRowsOnOnePage;
                else if (allColumnRadioBtn.Checked)
                    settings.LayoutOptions = LayoutOptions.FitAllColumnsOnOnePage;
                else
                    settings.LayoutOptions = LayoutOptions.FitSheetOnOnePage;

                //Assign the PDFDocument to the TemplateDocument property of ExcelToPdfConverterSettings
                settings.TemplateDocument = pdfDoc;
				settings.DisplayGridLines = GridLinesDisplayStyle.Invisible;
                settings.EnableFormFields = true;
                //Convert Excel Document into PDF document
                pdfDoc = converter.Convert(settings);
				
                //Save the pdf file
                pdfDoc.Save("ExceltoPDF.pdf");
				
                //Message box confirmation to view the created document.
                if (MessageBox.Show("Do you want to view the PDF file?", "File has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
#if NETCORE
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        process.StartInfo = new System.Diagnostics.ProcessStartInfo("ExceltoPDF.pdf")
                        {
                            UseShellExecute = true
                        };
                        process.Start();
#else
                        Process.Start("ExceltoPDF.pdf");
#endif
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Browse an Excel document and click the button to convert as a PDF.");
            }
        }
        private void SubstituteFont(object sender, SubstituteFontEventArgs args)
        {
            if (checkfontName.Checked && (args.OriginalFontName == "Bahnschrift Pro SemiBold" || args.OriginalFontName == "Georgia Pro Semibold"))
            {
                args.AlternateFontName = "Calibri";
            }
            if (checkfontStream.Checked)
            {
                if (args.OriginalFontName == "Georgia Pro Semibold")
                {
                    var assembly = Assembly.GetExecutingAssembly();
                    var resourceName = "ExceltoPDF.Fonts.georgiab.ttf";
                    Stream fileStream = assembly.GetManifestResourceStream(resourceName);
                    MemoryStream memoryStream = new MemoryStream();
                    fileStream.CopyTo(memoryStream);
                    fileStream.Close();
                    args.AlternateFontStream = memoryStream;
                }
                else if (args.OriginalFontName == "Bahnschrift Pro SemiBold")
                {
                    var assembly = Assembly.GetExecutingAssembly();
                    var resourceName = "ExceltoPDF.Fonts.bahnschrift.ttf";
                    Stream fileStream = assembly.GetManifestResourceStream(resourceName);
                    MemoryStream memoryStream = new MemoryStream();
                    fileStream.CopyTo(memoryStream);
                    fileStream.Close();
                    args.AlternateFontStream = memoryStream;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = "ExcelTopdfwithChart.xlsx";
#if NETCORE
            this.textBox1.Tag = @"..\..\..\..\..\..\..\common\Data\XlsIO\ExcelTopdfwithChart.xlsx";
#else
            this.textBox1.Tag = @"..\..\..\..\..\..\common\Data\XlsIO\ExcelTopdfwithChart.xlsx";
#endif
        }

        private void checkfontName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkfontName.Checked || checkfontStream.Checked)
            {
                this.textBox1.Text = "InvoiceTemplate.xlsx";
#if NETCORE
                this.textBox1.Tag = @"..\..\..\..\..\..\..\common\Data\XlsIO\InvoiceTemplate.xlsx";
#else
                this.textBox1.Tag = @"..\..\..\..\..\..\common\Data\XlsIO\InvoiceTemplate.xlsx";
#endif
            }
            else
            {
                this.textBox1.Text = "ExcelTopdfwithChart.xlsx";
#if NETCORE
                this.textBox1.Tag = @"..\..\..\..\..\..\..\common\Data\XlsIO\ExcelTopdfwithChart.xlsx";
#else
                this.textBox1.Tag = @"..\..\..\..\..\..\common\Data\XlsIO\ExcelTopdfwithChart.xlsx";
#endif
            }
        }

        private void checkfontStream_CheckedChanged(object sender, EventArgs e)
        {
            if (checkfontName.Checked || checkfontStream.Checked)
            {
                this.textBox1.Text = "InvoiceTemplate.xlsx";
#if NETCORE
                this.textBox1.Tag = @"..\..\..\..\..\..\..\common\Data\XlsIO\InvoiceTemplate.xlsx";
#else
                this.textBox1.Tag = @"..\..\..\..\..\..\common\Data\XlsIO\InvoiceTemplate.xlsx";
#endif
            }
            else
            {
                this.textBox1.Text = "ExcelTopdfwithChart.xlsx";
#if NETCORE
                this.textBox1.Tag = @"..\..\..\..\..\..\..\common\Data\XlsIO\ExcelTopdfwithChart.xlsx";
#else
                this.textBox1.Tag = @"..\..\..\..\..\..\common\Data\XlsIO\ExcelTopdfwithChart.xlsx";
#endif
            }
        }

        private void Input_Click(object sender, EventArgs e)
        {
            //Get the path of the input file
            string inputPath = this.textBox1.Tag.ToString();
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
    }
}