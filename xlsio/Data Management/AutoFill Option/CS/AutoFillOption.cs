#region Copyright Syncfusion Inc. 2001 - 2019
//
//  Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Drawing;

namespace EssentialXlsIOSamples
{
    public partial class AutoFillOption : MetroForm
    {
        #region Constants
#if NETCORE
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\common\Data\XlsIO\{0}";
#else
        private const string DEFAULTPATH = @"..\..\..\..\..\..\common\Data\XlsIO\{0}";
#endif
        #endregion
        
        #region Initialize
        public AutoFillOption()
        {
            InitializeComponent();
            GetList(false);
        }
        #endregion

        #region Create Excel document
        private void btnCreate_Click(object sender, EventArgs e)
        {


            IWorkbook workbook;
            string option = this.comboBox1.Text;

            if (this.radioButton1.Checked)
            {

                workbook = AutoFill(GetAutoFillEnum(option));
            }
            else
            {

                workbook = AutoFill(GetFillSeriesEnum( option),this.comboBox2.Text == "Rows"? ExcelSeriesBy.Rows: ExcelSeriesBy.Columns, this.textBox1.Text, this.textBox2.Text, this.checkBox.Checked);
            }

                string fileName = this.comboBox1.Text+".xlsx";
                workbook.SaveAs(fileName);


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


        public IWorkbook AutoFill(ExcelAutoFillType autoFillOption)
        {

            //Instantiate the spreadsheet creation engine
            ExcelEngine excelEngine = new ExcelEngine();
            
            //Instantiate the excel application object
            IApplication application = excelEngine.Excel;
            application.DefaultVersion = ExcelVersion.Xlsx;
            IWorkbook workbook = application.Workbooks.Create(1);

            IWorksheet sheet = workbook.Worksheets[0];
            sheet["A1"].Number = 2;
            sheet["A2"].Number = 4;
            sheet["A3"].Number = 6;

            switch (autoFillOption)
            {
                case ExcelAutoFillType.FillDefault:
                case ExcelAutoFillType.FillCopy:
                case ExcelAutoFillType.FillValues:
                case ExcelAutoFillType.FillSeries:
                case ExcelAutoFillType.GrowthTrend:
                case ExcelAutoFillType.LinearTrend:
                    {
                        sheet["A1:A3"].AutoFill(sheet["A4:A1000"], autoFillOption);
                        break;
                    }
                case ExcelAutoFillType.FillFormats:
                    {
                        sheet["A1"].CellStyle.Color = Color.Blue;
                        sheet["A2"].CellStyle.Color = Color.Red;
                        sheet["A3"].CellStyle.Color = Color.Chocolate;
                        sheet["A1:A3"].NumberFormat = "$0.00";
                        sheet["A1:A3"].AutoFill(sheet["A4:A1000"], autoFillOption);
                        break;
                    }
                case ExcelAutoFillType.FillMonths:
                case ExcelAutoFillType.FillDays:
                case ExcelAutoFillType.FillWeekdays:
                case ExcelAutoFillType.FillYears:
                    {
                        DateTime dateTime = new DateTime(2025, 1, 1);
                        sheet["A1"].Value2 = dateTime;
                        sheet["A2"].Value2 = dateTime.AddDays(1);
                        sheet["A3"].Value2 = dateTime.AddDays(2);
                        sheet["A1:A3"].NumberFormat = "m/d/yyyy";
                        sheet["A1:A3"].AutoFill(sheet["A4:A1000"], autoFillOption);
                        break;
                    }

            }
            sheet.UsedRange.ColumnWidth = 10;

            return workbook;
            

        }

        /// <summary>
        /// Table Slicer
        /// </summary>
        /// <returns>Return the created excel document as stream</returns>
        public IWorkbook AutoFill(ExcelFillSeries fillSeries, ExcelSeriesBy seriesBy, object stepValue, object stopValue, bool enableTrend)
        {
            ExcelEngine excelEngine = new ExcelEngine();
            
            //Step 2 : Instantiate the excel application object
            IApplication application = excelEngine.Excel;
            application.DefaultVersion = ExcelVersion.Excel2016;

            IWorkbook workbook = application.Workbooks.Create(1);
            IWorksheet sheet = workbook.Worksheets[0];
            if (seriesBy == ExcelSeriesBy.Columns)
            {
                sheet["A1"].Number = 2;
                sheet["A2"].Number = 4;
                sheet["A3"].Number = 6;
            }
            else
            {
                sheet["A1"].Number = 2;
                sheet["B1"].Number = 4;
                sheet["C1"].Number = 6;
            }

            stepValue = stepValue != null ? ConvertObject(stepValue.ToString()) : stepValue;
            stopValue = stopValue != null ? ConvertObject(stopValue.ToString()) : stopValue;
            
            
            switch (fillSeries)
            {
                case ExcelFillSeries.AutoFill:
                case ExcelFillSeries.Linear:
                case ExcelFillSeries.Growth:
                    break;
                case ExcelFillSeries.Years:
                case ExcelFillSeries.Days:
                case ExcelFillSeries.Weekdays:
                case ExcelFillSeries.Months:
                    {
                        if (seriesBy == ExcelSeriesBy.Columns)
                        {
                            DateTime dateTime = new DateTime(2025, 1, 1);
                            sheet["A1"].Value2 = dateTime;
                            sheet["A2"].Value2 = dateTime.AddDays(1);
                            sheet["A3"].Value2 = dateTime.AddDays(2);
                            sheet["A1:A3"].NumberFormat = "m/d/yyyy";
                        }
                        else
                        {
                            DateTime dateTime = new DateTime(2025, 1, 1);
                            sheet["A1"].Value2 = dateTime;
                            sheet["B1"].Value2 = dateTime.AddDays(1);
                            sheet["C1"].Value2 = dateTime.AddDays(2);
                            sheet["A1:C1"].NumberFormat = "m/d/yyyy";
                        }

                        break;
                    }

            }
            if (seriesBy == ExcelSeriesBy.Columns)
            {
                if (enableTrend)
                    sheet[1, 1, 1000, 1].FillSeries(seriesBy, fillSeries, enableTrend);
                else if (stepValue is string && stopValue is string)
                {
                    if (fillSeries == ExcelFillSeries.AutoFill)
                    {
                        sheet[1, 1, 1000, 1].FillSeries(seriesBy, fillSeries, enableTrend);
                    }
                }
                else if ((stepValue is string && !(stopValue is string)) || (!(stepValue is string) && (stopValue is string)))
                {
                    bool isStepValue = !(stepValue is string);
                    if (isStepValue)
                    {
                        if (stepValue is DateTime)
                            sheet[1, 1, 1000, 1].FillSeries(seriesBy, fillSeries, (DateTime)stepValue, isStepValue);
                        else if (stepValue is double)
                            sheet[1, 1, 1000, 1].FillSeries(seriesBy, fillSeries, (double)stepValue, isStepValue);
                    }
                    else
                    {
                        if (stopValue is DateTime)
                            sheet[1, 1, 1000, 1].FillSeries(seriesBy, fillSeries, (DateTime)stopValue, isStepValue);
                        else if (stopValue is double)
                            sheet[1, 1, 1000, 1].FillSeries(seriesBy, fillSeries, (double)stopValue, isStepValue);
                    }
                }
                else
                {
                    if (stepValue is DateTime && stopValue is DateTime)
                        sheet[1, 1, 1000, 1].FillSeries(seriesBy, fillSeries, (DateTime)stepValue, (DateTime)stopValue);
                    else if (stepValue is DateTime && stopValue is double)
                        sheet[1, 1, 1000, 1].FillSeries(seriesBy, fillSeries, (DateTime)stepValue, (double)stopValue);
                    else if (stepValue is double && stopValue is double)
                        sheet[1, 1, 1000, 1].FillSeries(seriesBy, fillSeries, (double)stepValue, (double)stopValue);
                    else if (stepValue is double && stopValue is DateTime)
                        sheet[1, 1, 1000, 1].FillSeries(seriesBy, fillSeries, (double)stepValue, (DateTime)stopValue);
                }
            }
            else
            {
                if (enableTrend)
                    sheet[1, 1, 1, 1000].FillSeries(seriesBy, fillSeries, enableTrend);
                else if (stepValue is string && stopValue is string)
                {
                    if (fillSeries == ExcelFillSeries.AutoFill)
                    {
                        sheet[1, 1, 1, 1000].FillSeries(seriesBy, fillSeries, enableTrend);
                    }
                }
                else if ((stepValue is string && !(stopValue is string)) || (!(stepValue is string) && (stopValue is string)))
                {
                    bool isStepValue = !(stepValue is string);
                    if (isStepValue)
                    {
                        if (stepValue is DateTime)
                            sheet[1, 1, 1, 1000].FillSeries(seriesBy, fillSeries, (DateTime)stepValue, isStepValue);
                        else if (stepValue is double)
                            sheet[1, 1, 1, 1000].FillSeries(seriesBy, fillSeries, (double)stepValue, isStepValue);
                    }
                    else
                    {
                        if (stopValue is DateTime)
                            sheet[1, 1, 1, 1000].FillSeries(seriesBy, fillSeries, (DateTime)stopValue, isStepValue);
                        else if (stopValue is double)
                            sheet[1, 1, 1, 1000].FillSeries(seriesBy, fillSeries, (double)stopValue, isStepValue);
                    }
                }
                else
                {
                    if (stepValue is DateTime && stopValue is DateTime)
                        sheet[1, 1, 1, 1000].FillSeries(seriesBy, fillSeries, (DateTime)stepValue, (DateTime)stopValue);
                    else if (stepValue is DateTime && stopValue is double)
                        sheet[1, 1, 1, 1000].FillSeries(seriesBy, fillSeries, (DateTime)stepValue, (double)stopValue);
                    else if (stepValue is double && stopValue is double)
                        sheet[1, 1, 1, 1000].FillSeries(seriesBy, fillSeries, (double)stepValue, (double)stopValue);
                    else if (stepValue is double && stopValue is DateTime)
                        sheet[1, 1, 1, 1000].FillSeries(seriesBy, fillSeries, (double)stepValue, (DateTime)stopValue);
                }
            }

            sheet.UsedRange.ColumnWidth = 10;
            return workbook;
            
        }
        #endregion

        #region HelperMethods
        public object ConvertObject(string value)
        {
            double d;
            DateTime dt;
            if (string.IsNullOrEmpty(value)) return string.Empty;
            if (double.TryParse(value, out d)) return d;
            if (DateTime.TryParse(value, out dt)) return dt;
            return value;
        }
        private ExcelAutoFillType GetAutoFillEnum(string type)
        {
            switch (type)
            {
                case "Default":
                    return ExcelAutoFillType.FillDefault;
                case "Copy":
                    return ExcelAutoFillType.FillCopy;
                case "Series":
                    return ExcelAutoFillType.FillSeries;
                case "Formats":
                    return ExcelAutoFillType.FillFormats;
                case "Values":
                    return ExcelAutoFillType.FillValues;
                case "Days":
                    return ExcelAutoFillType.FillDays;
                case "Weekdays":
                    return ExcelAutoFillType.FillWeekdays;
                case "Months":
                    return ExcelAutoFillType.FillMonths;
                case "Years":
                    return ExcelAutoFillType.FillYears;
                case "Linear Trend":
                    return ExcelAutoFillType.LinearTrend;
                case "Growth Trend":
                    return ExcelAutoFillType.GrowthTrend;
                default:
                    return ExcelAutoFillType.FillDefault;
            }
        }
        private ExcelFillSeries GetFillSeriesEnum(string type)
        {
            switch (type)
            {
                case "Linear":
                    return ExcelFillSeries.Linear;
                case "Growth":
                    return ExcelFillSeries.Growth;
                case "Days":
                    return ExcelFillSeries.Days;
                case "Weekdays":
                    return ExcelFillSeries.Weekdays;
                case "Months":
                    return ExcelFillSeries.Months;
                case "Years":
                    return ExcelFillSeries.Years;
                case "Auto Fill":
                    return ExcelFillSeries.AutoFill;
                default:
                    return ExcelFillSeries.AutoFill;
            }
        }
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

        
        private List<string> Sample()
        {
            if (radioButton1.Checked)
            {
                return new List<string> { "Default", "Copy", "Series", "Formats", "Values", "Days", "Weekdays", "Months", "Years", "Linear Trend", "Growth Trend" };
            }
            else
            {
                return new List<string> { "Linear", "Growth", "Days", "Weekdays", "Months", "Years", "Auto Fill" };
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox1.Text = string.Empty;
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            if (this.checkBox.Checked)
            {
                this.comboBox1.DataSource = Sample();
                this.textBox1.Enabled = false;
                this.textBox2.Enabled = false;

            }
            else
            {
                this.comboBox1.DataSource = Sample();
                this.textBox2.Enabled = true;
                this.textBox2.Enabled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                this.comboBox2.Enabled = false;
                this.textBox1.Enabled = false;
                this.textBox2.Enabled = false;
                this.checkBox.Enabled = false;
            }
            else
            {
                this.comboBox2.Enabled = true;

                string option = this.comboBox1.Text;
                bool isAutoFillOption = option == "Auto Fill";
                bool isTrend = option == "Linear" || option == "Growth";

                // Enable checkbox only for trend options
                this.checkBox.Enabled = isTrend;
                this.checkBox.Checked = isTrend && this.checkBox.Checked; // Uncheck if no longer a trend
                // Enable/disable text boxes
                bool enableTextBoxes = !this.checkBox.Checked && !isAutoFillOption;
                if (!enableTextBoxes)
                {
                    this.textBox1.Text = "";
                    this.textBox2.Text = "";
                }
                this.textBox1.Enabled = enableTextBoxes;
                this.textBox2.Enabled = enableTextBoxes;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(this.radioButton1.Checked)
            {
                this.comboBox1.DataSource = Sample();
                this.comboBox2.Enabled = false;
                this.checkBox.Checked = false;
                this.checkBox.Enabled = false;
                this.textBox1.Text = "";
                this.textBox2.Text = "";
                this.textBox1.Enabled = false;
                this.textBox2.Enabled = false;
                this.comboBox2.SelectedItem = ExcelSeriesBy.Rows;
            }
            else
            {
                this.comboBox1.DataSource = Sample();
                this.comboBox2.Enabled = true;
                this.checkBox.Enabled = true;
                if (checkBox.Checked)
                {
                    this.textBox1.Enabled = false;
                    this.textBox2.Enabled = false;
                }
                else
                {
                    this.textBox1.Enabled = true;
                    this.textBox2.Enabled = true;
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                this.comboBox1.DataSource = Sample();
                this.comboBox2.Enabled = false;
                this.checkBox.Enabled = false;
                this.textBox1.Enabled = false;
                this.textBox2.Enabled = false;
            }
            else
            {
                this.comboBox1.DataSource = Sample();
                string option = this.comboBox1.Text;
                bool IsTrendSeries = option != "Linear" || option != "Growth";
                bool isAutoFill = option == "Auto Fill";
                this.comboBox2.Enabled = !isAutoFill;
                this.checkBox.Enabled = true;
                
                if (checkBox.Checked)
                {
                    this.textBox1.Enabled = false;
                    this.textBox2.Enabled = false;
                }
                else
                {
                    this.textBox1.Enabled = true;
                    this.textBox2.Enabled = true;
                }
                if (IsTrendSeries || isAutoFill)
                    this.checkBox.Checked = false;
            }
        }

    }
}