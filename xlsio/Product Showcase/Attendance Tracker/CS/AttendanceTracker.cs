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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;
using System.Collections.Generic;
using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms;

namespace EssentialXlsIOSamples
{
    public partial class AttendanceTracker : MetroForm
    {
        #region Constants
#if NETCORE
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\common\Data\XlsIO\{0}";
#else
        private const string DEFAULTPATH = @"..\..\..\..\..\..\common\Data\XlsIO\{0}";
#endif
        string[] _columnNames;
        private List<EmployeeDetails> _employeeAttendanceList;
        #endregion

        # region Initialize
        public AttendanceTracker()
        {
            InitializeComponent();
            _columnNames = new string[] { "Employee Name", "Supervisor", "Present Count", "Leave Count", "Absent Count", "Unplanned %", "Planned %" };
        }
        # endregion

        # region Attendance Tracker Report in Spreadsheet
        /// <summary>
        /// Creates spreadsheet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            AttendanceDetailsGenerator attendanceDetailsGenerator = new AttendanceDetailsGenerator();
            _employeeAttendanceList = attendanceDetailsGenerator.GetEmployeeAttendanceDetails(2019, 01);
            string OutputFileName = "AttendanceTracker.xlsx";

            #region Workbook Initialize
            ExcelEngine excelEngine = new ExcelEngine();
            IApplication application = excelEngine.Excel;
            application.EnableIncrementalFormula = true;
            application.DefaultVersion = ExcelVersion.Excel2016;
            IWorkbook workbook = application.Workbooks.Create(1);
            IWorksheet worksheet = workbook.Worksheets[0];

            DateTime dateTime = DateTime.Now;
            string monthName = dateTime.ToString("MMM", CultureInfo.InvariantCulture);
            worksheet.Name = monthName + "-" + dateTime.Year;

            CreateHeaderRow(worksheet);//Format header row
            FillAttendanceDetails(worksheet);
            ApplyConditionFormatting(worksheet);
           
            #region Apply Styles
            worksheet.Range["A1:AL1"].RowHeight = 24;
            worksheet.Range["A2:AL31"].RowHeight = 20;
            worksheet.Range["A1:B1"].ColumnWidth = 20;
            worksheet.Range["C1:G1"].ColumnWidth = 16;
            worksheet.Range["H1:AL31"].ColumnWidth = 4;

            worksheet.Range["A1:AL31"].CellStyle.Font.Bold = true;
            worksheet.Range["A1:AL31"].CellStyle.Font.Size = 12;
            worksheet.Range["A2:AL31"].CellStyle.Font.RGBColor = Color.FromArgb(64, 64, 64);            
            worksheet.Range["A1:AL31"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;

            worksheet.Range["A1:AL1"].CellStyle.Font.Color = ExcelKnownColors.White;
            worksheet.Range["A1:AL1"].CellStyle.FillBackgroundRGB = Color.FromArgb(58, 56, 56);

            worksheet.Range["A1:B31"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignLeft;
            worksheet.Range["C2:G31"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;            
            worksheet.Range["H1:AL31"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;

            worksheet.Range["A2:B31"].CellStyle.IndentLevel = 1;
            worksheet.Range["A1:G1"].CellStyle.IndentLevel = 1;

            worksheet.Range["A1:AL1"].BorderAround(ExcelLineStyle.Medium, Color.LightGray);
            worksheet.Range["A1:AL1"].BorderInside(ExcelLineStyle.Medium, Color.LightGray);

            worksheet.Range["A2:G31"].BorderAround(ExcelLineStyle.Medium, Color.LightGray);
            worksheet.Range["A2:G31"].BorderInside(ExcelLineStyle.Medium, Color.LightGray);

            worksheet.Range["H2:AL31"].BorderInside(ExcelLineStyle.Medium, ExcelKnownColors.White);
            #endregion 

            workbook.SaveAs(OutputFileName);
            #endregion

            excelEngine.Dispose();

            #region View the Workbook
            //Message box confirmation to view the created spreadsheet.
            if (MessageBox.Show("Do you want to view the workbook?", "Workbook has been created",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                try
                {
                    //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
#if NETCORE
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo = new System.Diagnostics.ProcessStartInfo(OutputFileName)
                    {
                        UseShellExecute = true
                    };
                    process.Start();
#else
                    Process.Start(OutputFileName);
#endif
                    //Exit
                    this.Close();
                }
                catch (Win32Exception)
                {
                    MessageBox.Show("MS Excel is not installed in this system");
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
        /// <summary>
        /// Apply the conditonal format using workbook
        /// </summary>
        /// <param name="worksheet">worksheet used to get the range and set the conditional formats</param>
        private void ApplyConditionFormatting(IWorksheet worksheet)
        {
            IConditionalFormats statusCondition = worksheet["H2:AL31"].ConditionalFormats;

            IConditionalFormat leaveCondition = statusCondition.AddCondition();
            leaveCondition.FormatType = ExcelCFType.CellValue;
            leaveCondition.Operator = ExcelComparisonOperator.Equal;
            leaveCondition.FirstFormula = "\"L\"";
            leaveCondition.BackColorRGB = Color.FromArgb(253,167,92);

            IConditionalFormat absentCondition = statusCondition.AddCondition(); 
            absentCondition.FormatType = ExcelCFType.CellValue;
            absentCondition.Operator = ExcelComparisonOperator.Equal;
            absentCondition.FirstFormula = "\"A\"";
            absentCondition.BackColorRGB = Color.FromArgb(255, 105, 124);

            IConditionalFormat presentCondition = statusCondition.AddCondition();
            presentCondition.FormatType = ExcelCFType.CellValue;
            presentCondition.Operator = ExcelComparisonOperator.Equal;
            presentCondition.FirstFormula = "\"P\"";
            presentCondition.BackColorRGB = Color.FromArgb(67,233,123);

            IConditionalFormat weekendCondition = statusCondition.AddCondition();
            weekendCondition.FormatType = ExcelCFType.CellValue;
            weekendCondition.Operator = ExcelComparisonOperator.Equal;
            weekendCondition.FirstFormula = "\"WE\"";
            weekendCondition.BackColorRGB = Color.FromArgb(240, 240, 240);

            IConditionalFormats presentSummaryCF = worksheet["C2:C31"].ConditionalFormats;
            IConditionalFormat presentCountCF = presentSummaryCF.AddCondition();
            presentCountCF.FormatType = ExcelCFType.DataBar;
            IDataBar dataBar = presentCountCF.DataBar;
            dataBar.BarColor = Color.FromArgb(61, 242, 142);

            IConditionalFormats leaveSummaryCF = worksheet["D2:D31"].ConditionalFormats;
            IConditionalFormat leaveCountCF = leaveSummaryCF.AddCondition();
            leaveCountCF.FormatType = ExcelCFType.DataBar;
            dataBar = leaveCountCF.DataBar;
            dataBar.BarColor = Color.FromArgb(242,71,23);

            IConditionalFormats absentSummaryCF = worksheet["E2:E31"].ConditionalFormats;
            IConditionalFormat absentCountCF = absentSummaryCF.AddCondition();
            absentCountCF.FormatType = ExcelCFType.DataBar;
            dataBar = absentCountCF.DataBar;
            dataBar.BarColor = Color.FromArgb(255, 10, 69);

            IConditionalFormats unplannedSummaryCF = worksheet["F2:F31"].ConditionalFormats;
            IConditionalFormat unplannedCountCF = unplannedSummaryCF.AddCondition();
            unplannedCountCF.FormatType = ExcelCFType.DataBar;
            dataBar = unplannedCountCF.DataBar;
            dataBar.MaxPoint.Type = ConditionValueType.HighestValue;
            dataBar.BarColor = Color.FromArgb(142, 142, 142);

            IConditionalFormats plannedSummaryCF = worksheet["G2:G31"].ConditionalFormats;
            IConditionalFormat plannedCountCF = plannedSummaryCF.AddCondition();
            plannedCountCF.FormatType = ExcelCFType.DataBar;
            dataBar = plannedCountCF.DataBar;
            dataBar.MaxPoint.Type = ConditionValueType.HighestValue;
            dataBar.BarColor = Color.FromArgb(56, 136, 254);

        }
        /// <summary>
        /// Used to fill the attendance details
        /// </summary>
        /// <param name="worksheet">worksheet used to get the range and fill attendance details</param>
        private void FillAttendanceDetails(IWorksheet worksheet)
        {
            int rowIndex = 2;
            foreach (EmployeeDetails empDetails in _employeeAttendanceList)
            {

                worksheet["A" + rowIndex].Text = empDetails.Name;
                worksheet["B" + rowIndex].Text = empDetails.Supervisor;
                for (int colIndex = 0; colIndex < empDetails.Attendances.Count; colIndex++)
                {
                    worksheet[rowIndex, colIndex + 8].Text = empDetails.Attendances[colIndex];
                }
                rowIndex++;
            }
            //Data validation for list
            IDataValidation validation = worksheet.Range["H2:AL31"].DataValidation;
            validation.ListOfValues = new string[] { "P", "A", "L", "WE" };


            worksheet["C2:C31"].Formula = "=CountIf('H2:AL2',\"P\")";
            worksheet["D2:D31"].Formula = "=CountIf('H2:AL2',\"L\")";
            worksheet["E2:E31"].Formula = "=CountIf('H2:AL2',\"A\")";
            worksheet["F2:F31"].Formula = "=E2/(C2+D2+E2)";
            worksheet["G2:G31"].Formula = "=D2/(C2+D2+E2)";
            worksheet["F2:G31"].NumberFormat = ".00 %";
        }

        private void CreateHeaderRow(IWorksheet worksheet)
        {
            for (int i = 0; i < _columnNames.Length; i++)
            {
                worksheet[1, i + 1].Text = _columnNames[i];
            }
            worksheet["H1"].DateTime = new DateTime(2019, 1, 1);

            worksheet["I1:AL1"].Formula = "=H1+1";
            worksheet["H1:AL1"].NumberFormat = "d";
        }
        #endregion
    }
    #region HelperClasses
    /// <summary>
    /// Returrn the list of employee details
    /// </summary>
    public class EmployeeDetails
    {
        public string Name { get; set; }
        public string Supervisor { get; set; }
        public List<string> Attendances { get; set; }

        public EmployeeDetails()
        {
            Attendances = new List<string>();
        }

    }
    /// <summary>
    /// Get the attendance details and return the list
    /// </summary>
    public class AttendanceDetailsGenerator
    {
        private List<EmployeeDetails> _employeeAttendanceList;
        string[] _dayStatus;
        string[] _supervisor;
        string[] _employeeNames;

        public AttendanceDetailsGenerator()
        {
            _employeeAttendanceList = new List<EmployeeDetails>();
            _dayStatus = new string[] { "P", "L", "P", "A", "P" };
            _supervisor = new string[] { "Mary Saveley", "Liz Nixon", "Liu Wong", "Michael Holz" };
            _employeeNames = new string[] { "Maria Anders", "Ana Trujillo", "Antonio Moreno", "Thomas Hardy", "Christina Berglund", "Hanna Moos",
                                            "Frederique Citeaux", "Martin Sommer", "Laurence Lebihan", "Elizabeth Lincoln", "Victoria Ashworth", "Patricio Simpson",
                                            "Francisco Chang", "Yang Wang", "Pedro Afonso", "Elizabeth Brown", "Steve Rogers", "Ann Devon",
                                            "Philip Cramer", "Daniel Tonini", "Annette Roulet", "John Smith", "Maria Larsson", "Howard Stark",
                                            "Peter Franken", "Aria Cruz", "Philip Gary", "Fran Willamson", "Howard Snyde", "Mario Pontes"};
        }

        public List<EmployeeDetails> GetEmployeeAttendanceDetails(int year, int month)
        {
            Random rnd = new Random();
            for (int i = 0; i < 30; i++)
            {
                EmployeeDetails details = new EmployeeDetails();
                details.Name = _employeeNames[i];
                details.Supervisor = _supervisor[rnd.Next(_supervisor.Length)];
                int numberOfDays = DateTime.DaysInMonth(year, month);
                for (int j = 0; j < numberOfDays; j++)
                {
                    DateTime date = new DateTime(year, month, j + 1);
                    if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                        details.Attendances.Add("WE");
                    else
                        details.Attendances.Add(_dayStatus[rnd.Next(_dayStatus.Length)]);
                }
                _employeeAttendanceList.Add(details);
            }
            return _employeeAttendanceList;
        }
    }
    #endregion
    
}