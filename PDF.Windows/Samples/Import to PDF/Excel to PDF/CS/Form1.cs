using System;
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

namespace ExceltoPDF
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
			this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(GetFullTemplatePath("syncfusion.ico", true));
            this.MinimizeBox = true;
        }
        private void browseExcelFileBtnClick(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + @"..\..\..\..\..\..\..\..\Common\Data\XlsIO\";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Excel File(*.Xlsx)|*.xlsx";

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
                //Open the Excel Document to Convert
                ExcelToPdfConverter converter = new ExcelToPdfConverter((string)textBox1.Tag);
				
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
                //Convert Excel Document into PDF document
                pdfDoc = converter.Convert(settings);
				
                //Save the pdf file
                pdfDoc.Save("ExceltoPDF.pdf");
				
                //Message box confirmation to view the created document.
                if (MessageBox.Show("Do you want to view the PDF file?", "File has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        System.Diagnostics.Process.Start(@"ExceltoPDF.pdf");
                        //Exit
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Browse a word document and click the button to convert as a PDF.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = "ExceltoPDF.xlsx";
            this.textBox1.Tag = Application.StartupPath + @"..\..\..\..\..\..\..\..\Common\Data\XlsIO\ExcelToPDF.xlsx";
        }
		 /// <summary>
        /// Gets the full path of the PDF template or image.
        /// </summary>
        /// <param name="fileName">Name of the file</param>
        /// <param name="image">True if image</param>
        /// <returns>Path of the file</returns>
        private string GetFullTemplatePath(string fileName, bool image)
        {
            string fullPath = @"..\..\..\..\..\..\..\Common\";
            string folder = image ? "Images" : "Data";

            return string.Format(@"{0}{1}\PDF\{2}", fullPath, folder, fileName);
        }
    }
}