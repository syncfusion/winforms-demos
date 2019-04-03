#region Copyright Syncfusion Inc. 2001-2015.
// Copyright Syncfusion Inc. 2001-2015. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
using Syncfusion.XlsIO.Implementation;
using System.IO;

namespace PrintExcel
{
    public partial class Form : MetroForm
    {
        public Form()
        {
            InitializeComponent();
            this.groupBox1.Enabled = false;
        }
        private void browseExcelFileBtnClick(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + @"..\..\..\..\..\..\..\..\Common\Data\XlsIO\";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Excel|*.xls;*.xlsx";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.textBox1.Text = openFileDialog1.SafeFileName;
                this.textBox1.Tag = openFileDialog1.FileName;
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = "ExceltoPDF.xlsx";
            this.textBox1.Tag = @"..\..\..\..\..\..\..\Common\Data\XlsIO\ExcelToPDF.xlsx";
        }

        #region View Input File
        private void inputTemplate_Click(object sender, EventArgs e)
        {
            if(File.Exists((string)textBox1.Tag))
            {
                System.Diagnostics.Process.Start((string)textBox1.Tag);
            }
        }
        #endregion

        private void PrintExcelbtn_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != String.Empty)
            {
                ExcelEngine engine = new ExcelEngine();
                IApplication application = engine.Excel;
                IWorkbook book = application.Workbooks.Open((string)textBox1.Tag);

                //Open the Excel Document to Convert
                ExcelToPdfConverter converter = new ExcelToPdfConverter(book);

                //Intialize the ExcelToPdfconverterSettings
                ExcelToPdfConverterSettings converterSettings = new ExcelToPdfConverterSettings();

                if (noScaleRadioBtn.Checked)
                    converterSettings.LayoutOptions = LayoutOptions.NoScaling;
                else if (allRowsRadioBtn.Checked)
                    converterSettings.LayoutOptions = LayoutOptions.FitAllRowsOnOnePage;
                else if (allColumnRadioBtn.Checked)
                    converterSettings.LayoutOptions = LayoutOptions.FitAllColumnsOnOnePage;
                else
                    converterSettings.LayoutOptions = LayoutOptions.FitSheetOnOnePage;

                if (printWithPrinterBtn.Checked || printWithConverterAndPrinterBtn.Checked)
                {
                    //Create new printdialog instance.
                    PrintDialog printDialog = new PrintDialog();
                    printDialog.AllowSomePages = true;
                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                        if (printWithConverterAndPrinterBtn.Checked)
                        {
                            //Print excel document with specified printer settings and converter settings.
                            converter.Print(printDialog.PrinterSettings, GetConverterSettings());
							this.Close();
                        }
                        else
                        {
                            //Print excel document with specified printer settings.
                            converter.Print(printDialog.PrinterSettings);
							this.Close();
                        }
                    }
                }
                else if (printWithConverterBtn.Checked)
                {
                    //Print excel document with specified and converter settings.
                    converter.Print(GetConverterSettings());
					this.Close();
                }
                else if (defaultPrintBtn.Checked)
                {
                    //print excel document with default printer settings.
                    converter.Print();
					this.Close();
                }

            }
            else
            {
                MessageBox.Show("Browse a word document and click the button to convert as a PDF.");
            }
        }

        private ExcelToPdfConverterSettings GetConverterSettings()
        {
            //Intialize the ExcelToPdfconverterSettings
            ExcelToPdfConverterSettings converterSettings = new ExcelToPdfConverterSettings();

            if (noScaleRadioBtn.Checked)
                converterSettings.LayoutOptions = LayoutOptions.NoScaling;
            else if (allRowsRadioBtn.Checked)
                converterSettings.LayoutOptions = LayoutOptions.FitAllRowsOnOnePage;
            else if (allColumnRadioBtn.Checked)
                converterSettings.LayoutOptions = LayoutOptions.FitAllColumnsOnOnePage;
            else
                converterSettings.LayoutOptions = LayoutOptions.FitSheetOnOnePage;

            return converterSettings;
        }
        private void option_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.printWithConverterBtn.Checked == true || this.printWithConverterAndPrinterBtn.Checked == true)
            {
                this.groupBox1.Enabled = true;
            }
            else
                this.groupBox1.Enabled = false;
        }
    }
}