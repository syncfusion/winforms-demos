using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms;

namespace EssentialXlsIOSamples
{
    public partial class StylesAndFormatting : MetroForm
    {

        #region Constants
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\Common\Data\XlsIO\{0}";
        #endregion

        #region Initialize
        public StylesAndFormatting()
        {
            InitializeComponent();
            this.rdbExcel2013.Checked = true;
        }
        #endregion

        #region StylesAndFormatting
        /// <summary>
        /// Creates Spreadsheet with Styles and Formatting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            #region Workbook Initailze
            //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;

            //Set the default version as Excel 2007;
            if(rdbExcel2007.Checked)
            application.DefaultVersion = ExcelVersion.Excel2007;
			//Set the default version as Excel 2010
            else if (rdbExcel2010.Checked)
                application.DefaultVersion = ExcelVersion.Excel2010;
            else if (rdbExcel2013.Checked)
                application.DefaultVersion = ExcelVersion.Excel2013;
            //A new workbook is created.[Equivalent to creating a new workbook in MS Excel]
            //The new workbook will have 12 worksheets
            IWorkbook workbook = application.Workbooks.Create(12);
            //Get the path of the Input File
            string inputPath = GetFullTemplatePath("CalendarTemplate.xlsx");
            IWorkbook tempWorkbook = application.Workbooks.Open(inputPath );
            workbook.Worksheets.AddCopyAfter(tempWorkbook.Worksheets[0], workbook.Worksheets[11]);

            //The first worksheet object in the worksheets collection is accessed.
            IWorksheet worksheet;
            #endregion

            # region Calendar

            # region Draw Calendar
            String[] monthArray = new String[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            String[] dateArray = new String[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            Color[] colorArray = new Color[] { Color.FromArgb(149, 55, 53), Color.FromArgb(146, 208, 80), Color.FromArgb(0, 32, 96), Color.FromArgb(0, 176, 80), Color.FromArgb(255, 255, 0), Color.FromArgb(128, 128, 128), Color.FromArgb(255, 0, 0), Color.FromArgb(96, 73, 123), Color.FromArgb(169, 161, 117), Color.FromArgb(0, 176, 240), Color.FromArgb(192, 0, 0), Color.FromArgb(63, 49, 81), Color.FromArgb(192, 0, 0) };

            int currentMonth = DateTime.Today.Month - 1;

            for (int monIndex = 1; monIndex < 13; monIndex++)
            {
                worksheet = workbook.Worksheets[monIndex - 1];
                worksheet.Name = monthArray[monIndex - 1];
                worksheet.Range["B3:H3"].Merge();
                worksheet.Range["B4:H4"].Merge();
                worksheet.IsGridLinesVisible = false;

                //Write the month as the heading
                worksheet.Range["B3"].Text = monthArray[monIndex - 1];

                //Apply styles for the month title
                worksheet.Range["B3:H3"].HorizontalAlignment = ExcelHAlign.HAlignCenter;
                worksheet.Range["B3:H3"].VerticalAlignment = ExcelVAlign.VAlignCenter;
                worksheet.Range["B3:H3"].BorderAround(ExcelLineStyle.Thin, Color.Brown);
                worksheet.Range["B3:H3"].RowHeight = 30;

                IStyle style = worksheet.Range["B3"].CellStyle;
                style.HorizontalAlignment = ExcelHAlign.HAlignCenter;

                style.Interior.FillPattern = ExcelPattern.Gradient;
                style.Interior.Gradient.TwoColorGradient(ExcelGradientStyle.Diagonl_Up, ExcelGradientVariants.ShadingVariants_3);
                style.Interior.Gradient.ForeColorIndex = ExcelKnownColors.White;
                style.Interior.Gradient.BackColor = colorArray[monIndex - 1];

                IFont font = style.Font;
                font.FontName = "Segoe UI";
                font.Size = 22;
                font.Italic = true;

                //Write the weekdays
                for (int i = 2, j = 0; i < 9; i++, j++)
                {
                    worksheet.SetValue(5, i, dateArray[j]);
                    worksheet.Range[5, i].HorizontalAlignment = ExcelHAlign.HAlignCenter;
                }

                //Get the number of days in the month
                int days = DateTime.DaysInMonth(DateTime.Today.Year, monIndex);

                //Write the calendar
                DateTime firstDay = new DateTime(DateTime.Today.Year, monIndex, 1);
                IRange range = worksheet.FindFirst(firstDay.Date.DayOfWeek.ToString(), ExcelFindType.Text);

                int row = range.End.Row + 1;
                int column = range.End.Column;
                int date = 1;

                while (date < days + 1)
                {
                    for (; column < 9; column++)
                    {
                        worksheet.Range[row, column].Number = date;
                        date++;
                        if (date == days + 1)
                            break;
                    }
                    column = 2;
                    row++;
                }

                //Format Sunday
                worksheet.Range["B5:B11"].BuiltInStyle = BuiltInStyles.WarningText;
                worksheet.Range["B5"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;

                //Format day title
                worksheet.Range["B5:H5"].BuiltInStyle = BuiltInStyles.Heading4;
                worksheet.Range["B5:H5"].CellStyle.Font.Size = 10;

                //Border around the entire calendar
                worksheet.UsedRange.BorderAround(ExcelLineStyle.Double, Color.Black);
                worksheet.UsedRange.BorderInside(ExcelLineStyle.Hair, Color.Black);

                worksheet.Range["B3"].RowHeight = 35;
                worksheet.Range["B5:H11"].RowHeight = 60;
                worksheet.UsedRange.ColumnWidth = 15;

                //Set Legend
                worksheet["K7"].BuiltInStyle = BuiltInStyles.Accent2_20;
                worksheet["K8"].BuiltInStyle = BuiltInStyles.Accent4_20;

                worksheet.Range["L7"].Text = "Holidays";
                worksheet.Range["L8"].Text = "Today";
                worksheet.Range["L7:L8"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
            }
            # endregion

            # region Styles for today
            foreach (IWorksheet currentSheet in workbook.Worksheets)
            {
                if (currentSheet.Name == monthArray[currentMonth])
                {
                    //Apply styles for today
                    IRange tRange = currentSheet.FindFirst(DateTime.Today.Day, ExcelFindType.Number);
                    tRange.BuiltInStyle = BuiltInStyles.Accent4_20;
                    tRange.CellStyle.Font.RGBColor = Color.Purple;

                    tRange.AddComment().Text = "Today";
                    tRange.Comment.Width = 100;
                    tRange.Comment.Height = 40;
                    currentSheet.Activate();
                }
                else if (currentSheet.Name == "Holidays")
                {
                    currentSheet.Range["B3"].BuiltInStyle = BuiltInStyles.Accent2_20;
                    currentSheet.Range["B3"].CellStyle.Font.FontName = "Calibri";
                    currentSheet.Range["B3"].CellStyle.Font.Size = 11;
                    currentSheet.Range["B3"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                }
            }

            # endregion

            # region Update Holidays
            workbook.Worksheets[12].EnableSheetCalculations();
            //Highlight holidays
            for (int i = 8; i <= 18; i++)
            {
                IRange range = workbook.Worksheets[12].Range["D" + i.ToString()];
                range.Value = range.CalculatedValue;
                int sheetIndex = range.DateTime.Month;
                IRange holiday = workbook.Worksheets[sheetIndex - 1].FindFirst(range.DateTime.Day, ExcelFindType.Number);
                holiday.AddComment().Text = workbook.Worksheets[12].Range["B" + i.ToString()].Text;
                holiday.Comment.Width = 100;
                holiday.Comment.Height = 40;
                holiday.BuiltInStyle = BuiltInStyles.Accent2_20;
                holiday.CellStyle.Font.RGBColor = Color.Red;
            }

            # endregion

            # endregion

            #region Save the Workbook
            //Saving the workbook to disk.
            workbook.SaveAs("StylesAndFormatting.xlsx");
            #endregion

            #region Workbook Close and Dispose
            //Close the workbook.
            workbook.Close();

            //No exception will be thrown if there are unsaved workbooks.
            excelEngine.ThrowNotSavedOnDestroy = false;
            excelEngine.Dispose();
            #endregion

            #region View the Workbook
            //Message box confirmation to view the created spreadsheet.
            if (MessageBox.Show("Do you want to view the workbook?", "Workbook has been created",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                try
                {
                    //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                    System.Diagnostics.Process.Start("StylesAndFormatting.xlsx");
                    //Exit
                    this.Close();
                }
                catch (Win32Exception)
                {
                    MessageBox.Show("Excel 2007 is not installed in this system");
                }
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
        /// <returns>path of the input file</returns>
        private string GetFullTemplatePath(string inputFile)
        {
            return string.Format(DEFAULTPATH, inputFile);
        }
        #endregion    

        #region View the Input File
        private void viewInputTemplate_Click(object sender, EventArgs e)
        {
            //Get the path of the input file
            string inputPath = GetFullTemplatePath("CalendarTemplate.xlsx");
            //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
            System.Diagnostics.Process.Start(inputPath);
        }
        #endregion
    }
}