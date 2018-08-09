using System;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms;

namespace EssentailXlsIOSamples
{
    public partial class BudgetPlanner : MetroForm
    {
        #region Fields
        private string fileName;
        #endregion

        #region Constants
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\Common\Data\XlsIO\{0}";
        #endregion

        #region Initialize
        public BudgetPlanner()
        {
            InitializeComponent();
        }
        #endregion

        #region Create Spreadsheet
        /// <summary>
        /// Creates Spreadsheet with Styles and Formatting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            #region Workbook Initialize
            //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;

            //Get the path of the input file
            string inputPath = GetFullTemplatePath("BudgetPlanner.xls");
            //A new workbook is created.[Equivalent to creating a new workbook in MS Excel]
            //The new workbook will have 12 worksheets
            IWorkbook workbook = application.Workbooks.Open(inputPath);

            IWorksheet worksheet = workbook.Worksheets[1];
            worksheet.FirstVisibleRow = 3;
            //Set the Default version as Excel 97to2003
            if (this.rdbExcel97.Checked)
            {
                workbook.Version = ExcelVersion.Excel97to2003;
                fileName = "BudgetPlannerOutput.xls";
            }
            //Set the Default version as Excel 2007
            else if (this.rdbExcek2007.Checked)
            {
                workbook.Version = ExcelVersion.Excel2007;
                fileName = "BudgetPlannerOutput.xlsx";
            }
            //Set the Default version as Excel 2010
            else if (this.rdbExcel2010.Checked)
            {
                workbook.Version = ExcelVersion.Excel2010;
                fileName = "BudgetPlannerOutput.xlsx";
            }
            //Set the Default version as Excel 2013
            else if (this.rdbExcel2013.Checked)
            {
                workbook.Version = ExcelVersion.Excel2013;
                fileName = "BudgetPlannerOutput.xlsx";
            }			
            IFont font = workbook.CreateFont();
            font.Bold = true;
            #endregion

            #region TextBox
            ITextBoxShape textbox = worksheet.TextBoxes.AddTextBox(5, 2, 40, 140);
            textbox.Text = "Quick Budget";
            textbox.RichText.SetFont(0, 11, font);
            textbox.VAlignment = ExcelCommentVAlign.Center;
            textbox.HAlignment = ExcelCommentHAlign.Center;
            textbox.Fill.FillType = ExcelFillType.Gradient;
            textbox.Fill.GradientColorType = ExcelGradientColor.TwoColor;
            textbox.Fill.TwoColorGradient(ExcelGradientStyle.Vertical, ExcelGradientVariants.ShadingVariants_2);
            textbox.Fill.BackColor = Color.FromArgb(204, 204, 255);

            textbox = worksheet.TextBoxes.AddTextBox(7, 2, 25, 140);
            textbox.Text = "Income";
            textbox.RichText.SetFont(0, 5, font);
            textbox.VAlignment = ExcelCommentVAlign.Center;
            textbox.HAlignment = ExcelCommentHAlign.Center;
            textbox.Fill.FillType = ExcelFillType.Gradient;
            textbox.Fill.GradientColorType = ExcelGradientColor.TwoColor;
            textbox.Fill.TwoColorGradient(ExcelGradientStyle.Vertical, ExcelGradientVariants.ShadingVariants_2);
            textbox.Fill.BackColor = Color.FromArgb(0, 0, 128);

            textbox = worksheet.TextBoxes.AddTextBox(16, 2, 25, 140);
            textbox.Text = "Spending";
            textbox.RichText.SetFont(0, 7, font);
            textbox.VAlignment = ExcelCommentVAlign.Center;
            textbox.HAlignment = ExcelCommentHAlign.Center;
            textbox.Fill.FillType = ExcelFillType.Gradient;
            textbox.Fill.GradientColorType = ExcelGradientColor.TwoColor;
            textbox.Fill.TwoColorGradient(ExcelGradientStyle.Vertical, ExcelGradientVariants.ShadingVariants_2);
            textbox.Fill.BackColor = Color.FromArgb(0, 0, 128);

            #endregion

            #region Write Text and Numbers
            worksheet.Range["O6"].Text = "Weekly";
            worksheet.Range["E7"].Text = "Frequency";
            worksheet.Range["F7"].Text = "Amount";
            worksheet.Range["G7"].Text = "Monthly";
            worksheet.Range["H7"].Text = "Yearly";

            worksheet.Range["B8"].Text = "Total Income";
            worksheet.Range["C9"].Text = "Salary/Wages";
            worksheet.Range["C10"].Text = "Salary/Wages(Spouse)";
            worksheet.Range["C11"].Text = "Other";
            worksheet.Range["C12"].Text = "Other";
            worksheet.Range["C13"].Text = "Other";
            worksheet.Range["B17"].Text = "Transportation";

            worksheet.Range["F25"].Number = 3000;
            worksheet.Range["F9"].Number = 55000;
            worksheet.Range["F10"].Number = 35000;


            worksheet.Range["C18"].Text = "Auto Loan/Lease";
            worksheet.Range["C19"].Text = "Insurance";
            worksheet.Range["C20"].Text = "Gas ";
            worksheet.Range["C21"].Text = "Maintenance ";
            worksheet.Range["C22"].Text = "Registration/Inspection";
            worksheet.Range["C23"].Text = "Bill's train pass";
            worksheet.Range["C24"].Text = "Jane's bus pass";
            worksheet.Range["C25"].Text = "Other";

            worksheet.Range["E16"].Text = "Total";

            worksheet.Range["N6"].Text = "Chart";

            worksheet.Range["B27"].Text = "Home";

            worksheet.Range["F28"].Number = 20000;
            worksheet.Range["F29"].Number = 5000;
            worksheet.Range["F33"].Number = 5000;

            worksheet.Range["C28"].Text = "EMI";
            worksheet.Range["C29"].Text = "Rent";
            worksheet.Range["C30"].Text = "Maintanence";
            worksheet.Range["C31"].Text = "Insurance";
            worksheet.Range["C32"].Text = "Furniture";
            worksheet.Range["C33"].Text = "Household Supplies";
            worksheet.Range["C34"].Text = "Groceries";
            worksheet.Range["C35"].Text = "Real Estate Tax";
            worksheet.Range["C36"].Text = "Other";

            worksheet.Range["B39"].Text = "Utilities";

            worksheet.Range["F41"].Number = 1000;
            worksheet.Range["F42"].Number = 250;
            worksheet.Range["F43"].Number = 150;
            worksheet.Range["F45"].Number = 175;

            worksheet.Range["C40"].Text = "Phone - Home";
            worksheet.Range["C41"].Text = "Phone - Cell";
            worksheet.Range["C42"].Text = "Cable";
            worksheet.Range["C43"].Text = "Gas";
            worksheet.Range["C44"].Text = "Water";
            worksheet.Range["C45"].Text = "Electricity";
            worksheet.Range["C46"].Text = "Internet";
            worksheet.Range["C47"].Text = "Other";

            worksheet.Range["B50"].Text = "Health";

            worksheet.Range["F53"].Number = 500;


            worksheet.Range["C51"].Text = "Dental";
            worksheet.Range["C52"].Text = "Medical";
            worksheet.Range["C53"].Text = "Medication";
            worksheet.Range["C54"].Text = "Vision/contacts";
            worksheet.Range["C55"].Text = "Life Insurance";
            worksheet.Range["C56"].Text = "Electricity";
            worksheet.Range["C57"].Text = "Other";

            #endregion

            #region Cell styles

            IStyle tableStyle = workbook.Styles.Add("TableStyle");

            tableStyle.BeginUpdate();
            tableStyle.Color = Color.White;
            tableStyle.Borders[ExcelBordersIndex.EdgeBottom].ColorRGB = Color.FromArgb(150, 150, 150);
            tableStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
            tableStyle.Borders[ExcelBordersIndex.EdgeLeft].ColorRGB = Color.FromArgb(150, 150, 150);
            tableStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
            tableStyle.Borders[ExcelBordersIndex.EdgeRight].ColorRGB = Color.FromArgb(150, 150, 150);
            tableStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
            tableStyle.Borders[ExcelBordersIndex.EdgeTop].ColorRGB = Color.FromArgb(150, 150, 150);
            tableStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
            tableStyle.EndUpdate();

            worksheet.Range["E7:H7"].CellStyle.Font.Bold = true;
            worksheet.Range["B17"].CellStyle.Font.Bold = true;
            worksheet.Range["B27"].CellStyle.Font.Bold = true;
            worksheet.Range["B39"].CellStyle.Font.Bold = true;
            worksheet.Range["B50"].CellStyle.Font.Bold = true;

            worksheet.Range["E7:H7"].CellStyle.Font.Underline = ExcelUnderline.Single;


            worksheet.Range["B7:H14"].CellStyle.Color = Color.FromArgb(223, 223, 223);
            worksheet.Range["C9:C13"].CellStyle = tableStyle;
            worksheet.Range["E9:F13"].CellStyle = tableStyle;


            worksheet.Range["B16:H26"].CellStyle.Color = Color.FromArgb(223, 223, 223);
            worksheet.Range["B17:C17"].CellStyle.Color = Color.White;

            worksheet.Range["C18:C25"].CellStyle = tableStyle;
            worksheet.Range["O6"].CellStyle = tableStyle;
            worksheet.Range["E18:F25"].CellStyle = tableStyle;

            worksheet.Range["B27:H38"].CellStyle.Color = Color.FromArgb(223, 223, 223);
            worksheet.Range["C28:C36"].CellStyle = tableStyle;
            worksheet.Range["B27:C27"].CellStyle.Color = Color.White;
            worksheet.Range["E28:F36"].CellStyle = tableStyle;

            worksheet.Range["B39:H49"].CellStyle.Color = Color.FromArgb(223, 223, 223);
            worksheet.Range["C40:C47"].CellStyle = tableStyle;
            worksheet.Range["B39:C39"].CellStyle.Color = Color.White;
            worksheet.Range["E40:F47"].CellStyle = tableStyle;

            worksheet.Range["B50:H58"].CellStyle.Color = Color.FromArgb(223, 223, 223);
            worksheet.Range["C51:C57"].CellStyle = tableStyle;
            worksheet.Range["B50:C50"].CellStyle.Color = Color.White;
            worksheet.Range["E51:F57"].CellStyle = tableStyle;


            #endregion

            #region Data Validation
            IDataValidation validation = worksheet.Range["E9:E13"].DataValidation;
            worksheet.Range["E9:E13"].Text = "Monthly";
            validation.ListOfValues = new string[] { "Daily", "Weekly", "Monthly", "Semi-Annually", "Quarterly", "Yearly" };

            IDataValidation validation1 = worksheet.Range["E18:E25"].DataValidation;
            worksheet.Range["E18:E25"].Text = "Monthly";
            validation1.ListOfValues = new string[] { "Daily", "Weekly", "Monthly", "Semi-Annually", "Quarterly", "Yearly" };

            IDataValidation validation2 = worksheet.Range["O6"].DataValidation;
            validation2.ListOfValues = new string[] { "Weekly", "Monthly", "Yearly" };

            IDataValidation validation3 = worksheet.Range["E28:E37"].DataValidation;
            worksheet.Range["E28:E36"].Text = "Monthly";
            validation3.ListOfValues = new string[] { "Daily", "Weekly", "Monthly", "Semi-Annually", "Quarterly", "Yearly" };


            IDataValidation validation4 = worksheet.Range["E40:E47"].DataValidation;
            worksheet.Range["E40:E47"].Text = "Monthly";
            validation4.ListOfValues = new string[] { "Daily", "Weekly", "Monthly", "Semi-Annually", "Quarterly", "Yearly" };

            IDataValidation validation5 = worksheet.Range["E51:E57"].DataValidation;
            worksheet.Range["E51:E57"].Text = "Monthly";
            validation5.ListOfValues = new string[] { "Daily", "Weekly", "Monthly", "Semi-Annually", "Quarterly", "Yearly" };

            #endregion

            #region Formulas
            worksheet.Range["G8"].Formula = "SUM(G9:G13)";
            worksheet.Range["H8"].Formula = "SUM(H9:H13)";

            worksheet.Range["G17"].Formula = "SUM(G18:G25)";
            worksheet.Range["H17"].Formula = "SUM(H18:H25)";
            worksheet.Range["G16"].Formula = "G17+G27+G39+G50+G59+G71";
            worksheet.Range["h16"].Formula = "H17+H27+H39+H50+H59+H71";

            for (int i = 9; i <= 13; i++)
            {
                worksheet.Range["G" + i].Formula = "F" + i + "*A" + i;
                worksheet.Range["H" + i].Formula = "G" + i + "*12";
            }

            for (int i = 18; i <= 25; i++)
            {
                worksheet.Range["G" + i].Formula = "F" + i + "*A" + i;
                worksheet.Range["H" + i].Formula = "G" + i + "*12";
            }

            worksheet.Range["G27"].Formula = "SUM(G28:G36)";
            worksheet.Range["H27"].Formula = "SUM(H28:H37)";
            for (int i = 28; i <= 36; i++)
            {
                worksheet.Range["G" + i].Formula = "F" + i + "*A" + i;
                worksheet.Range["H" + i].Formula = "G" + i + "*12";
            }

            worksheet.Range["G39"].Formula = "SUM(G40:G47)";
            worksheet.Range["H39"].Formula = "SUM(H40:H47)";
            for (int i = 40; i <= 47; i++)
            {
                worksheet.Range["G" + i].Formula = "F" + i + "*A" + i;
                worksheet.Range["H" + i].Formula = "G" + i + "*12";
            }

            worksheet.Range["G50"].Formula = "SUM(G51:G57)";
            worksheet.Range["H50"].Formula = "SUM(H51:H57)";
            for (int i = 51; i <= 57; i++)
            {
                worksheet.Range["G" + i].Formula = "F" + i + "*A" + i;
                worksheet.Range["H" + i].Formula = "G" + i + "*12";
            }

            #endregion

            #region SummaryChart
            //Clustered Column Chart
            IChartShape chart = worksheet.Charts.Add();

            //Set Chart Type
            chart.ChartType = ExcelChartType.Bar_Clustered;

            //Set DataRange. 

            chart.Series.Add("Expense");
            chart.Series[0].Values = workbook.Worksheets["Sheet1"].Range["N10"];
            chart.Series[0].DataPoints[0].DataLabels.IsValue = true;
            chart.Series[0].DataPoints[0].DataLabels.Size = 7f;

            chart.Series.Add("Income");
            chart.Series[1].Values = workbook.Worksheets["Sheet1"].Range["N9"];
            chart.Series[1].DataPoints[0].DataLabels.IsValue = true;
            chart.Series[1].DataPoints[0].DataLabels.Size = 7f;

            chart.Series.Add("Balance");
            chart.Series[2].Values = workbook.Worksheets["Sheet1"].Range["N8"];
            chart.Series[2].DataPoints[0].DataLabels.IsValue = true;
            chart.Series[2].DataPoints[0].DataLabels.Size = 7f;

            chart.PrimaryValueAxis.NumberFormat = "$#,##0";
            chart.PrimaryCategoryAxis.Visible = false;

            //Format Chart Area
            IChartFrameFormat chartArea = chart.ChartArea;

            //Style
            chartArea.Border.LinePattern = ExcelChartLinePattern.Solid;
            chartArea.Border.LineColor = Color.Gray;
            chartArea.Border.LineWeight = ExcelChartLineWeight.Medium;

            //Plot Area
            IChartFrameFormat chartPlotArea = chart.PlotArea;
            chartPlotArea.Border.LinePattern = ExcelChartLinePattern.Solid;
            chart.PlotArea.Border.LineColor = Color.Gray;

            chart.Legend.Position = ExcelLegendPosition.Bottom;

            //Embedded chart position.
            chart.TopRow = 7;
            chart.BottomRow = 22;
            chart.LeftColumn = 9;
            chart.RightColumn = 16;

            chart.ChartTitle = "Budget Summary";
            chart.ChartTitleArea.Bold = true;
            #endregion

            #region SpendingChart

            chart = worksheet.Charts.Add();
            chart.ChartTitle = "Spending Summary";
            chart.ChartTitleArea.Bold = true;
            //Set Chart Type
            chart.ChartType = ExcelChartType.Pie_3D;

            //Set DataRange. 
            chart.DataRange = workbook.Worksheets["Sheet1"].Range["J9:K12"];
            chart.IsSeriesInRows = false;
            chart.Series[0].Values = workbook.Worksheets["Sheet1"].Range["K9:K12"];
            chart.Series[0].CategoryLabels = workbook.Worksheets["Sheet1"].Range["J9:J12"];
            chart.Series[0].Name = "Spending summary";

            chart.Series[0].DataPoints[0].DataLabels.IsValue = true;
            chart.Series[0].DataPoints[0].DataLabels.Size = 7f;

            chart.Series[0].DataPoints[1].DataLabels.IsValue = true;
            chart.Series[0].DataPoints[1].DataLabels.Size = 7f;

            chart.Series[0].DataPoints[2].DataLabels.IsValue = true;
            chart.Series[0].DataPoints[2].DataLabels.Size = 7f;

            chart.Series[0].DataPoints[3].DataLabels.IsValue = true;
            chart.Series[0].DataPoints[3].DataLabels.Size = 7f;

            chart.PrimaryValueAxis.NumberFormat = "$#,##0";

            //Format Chart Area
            chartArea = chart.ChartArea;

            //Style
            chartArea.Border.LinePattern = ExcelChartLinePattern.Solid;
            chartArea.Border.LineColor = Color.Gray;
            chartArea.Border.LineWeight = ExcelChartLineWeight.Medium;

            //Plot Area
            chartPlotArea = chart.PlotArea;
            chartPlotArea.Border.LinePattern = ExcelChartLinePattern.Solid;
            chart.PlotArea.Border.LineColor = Color.Gray;
            chartPlotArea.Fill.ForeColor = Color.FromArgb(223, 223, 223);

            chart.Legend.Position = ExcelLegendPosition.Bottom;

            //Embedded chart position.
            chart.TopRow = 25;
            chart.BottomRow = 42;
            chart.LeftColumn = 9;
            chart.RightColumn = 16;
            #endregion

            #region Sheet View
            workbook.Worksheets["Sheet1"].Visibility = WorksheetVisibility.Hidden;
            workbook.Worksheets[0].Activate();
            workbook.TabSheets[0].TabColor = ExcelKnownColors.Blue;
            workbook.TabSheets[1].TabColor = ExcelKnownColors.Blue;
            workbook.Worksheets[1].IsRowColumnHeadersVisible = false;

            worksheet.InsertColumn(9);
            #endregion

            #region Save the Workbook
            //Saving the workbook to disk.
            workbook.SaveAs(fileName);
            #endregion

            #region Workbook Close and Dispose
            workbook.Close();
            excelEngine.Dispose();
            #endregion

            #region View the Workbook
            //Message box confirmation to view the created spreadsheet.
            if (MessageBox.Show("Do you want to view the workbook?", "Workbook has been created",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
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
        /// <returns>path of the input file</returns>
        private string GetFullTemplatePath(string inputFile)
        {
            return string.Format(DEFAULTPATH, inputFile);
        }
        #endregion

        #region View input file
        private void viewInputTemplate_Click(object sender, EventArgs e)
        {
            //Get the path of the input file
            string inputPath = GetFullTemplatePath("BudgetPlanner.xls");
            //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
            System.Diagnostics.Process.Start(inputPath);
        }
        #endregion
    }
}