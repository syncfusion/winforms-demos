using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms;

namespace EssentialXlsIOSamples
{
    public partial class AdvancedCF : MetroForm
    {
        #region Constants
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\Common\Data\XlsIO\{0}";
        #endregion

        # region Initialize
        public AdvancedCF()
        {
            InitializeComponent();
            this.rdbExcel2013.Checked = true;
        }
        # endregion

        # region Conditional Format in Spreadsheet
        /// <summary>
        /// Creates spreadsheet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            #region Workbook Initialize
            ExcelEngine excelEngine = new ExcelEngine();
            IApplication application = excelEngine.Excel;
            string OutputFileName = "";            

            //Get the path of the input file.
            string inputPath = GetFullTemplatePath("CFTemplate.xlsx");
            IWorkbook myWorkbook = null;
            IWorksheet worksheet = null;

            //Set the Default Version as Excel 97to2003
            if (this.rdbExcel97.Checked)
            {
                myWorkbook=application.Workbooks.Create(3);
                worksheet = myWorkbook.Worksheets[0];
                myWorkbook.Version = ExcelVersion.Excel97to2003;
                OutputFileName = "AdvancedCF.xls";
            }
            //Set the Default Version as Excel 2007
            else if (this.rdbExcel2007.Checked)
            {
                myWorkbook = excelEngine.Excel.Workbooks.Open(inputPath, ExcelOpenType.Automatic);
                worksheet = myWorkbook.Worksheets[0];
                myWorkbook.Version = ExcelVersion.Excel2007;
                OutputFileName = "AdvancedCF.xlsx";
            }
            //Set the Default Version as Excel 2010
            else if (this.rdbExcel2010.Checked)
            {
                myWorkbook = excelEngine.Excel.Workbooks.Open(inputPath, ExcelOpenType.Automatic);
                worksheet = myWorkbook.Worksheets[0];
                myWorkbook.Version = ExcelVersion.Excel2010;
                OutputFileName = "AdvancedCF.xlsx";
            }
            //Set the Default Version as Excel 2010
            else if(this.rdbExcel2013.Checked)
            {
                myWorkbook = excelEngine.Excel.Workbooks.Open(inputPath, ExcelOpenType.Automatic);
                worksheet = myWorkbook.Worksheets[0];
                myWorkbook.Version = ExcelVersion.Excel2013;
                OutputFileName = "AdvancedCF.xlsx";
            }
            #endregion
            if (!this.rdbExcel97.Checked)
            {
                #region Databar
                //Add condition for the range
                IConditionalFormats conditionalFormats = worksheet.Range["C7:C46"].ConditionalFormats;
                IConditionalFormat conditionalFormat = conditionalFormats.AddCondition();

                //Set Data bar and icon set for the same cell
                //Set the conditionalFormat type
                conditionalFormat.FormatType = ExcelCFType.DataBar;
                IDataBar dataBar = conditionalFormat.DataBar;

                //Set the constraint
                dataBar.MinPoint.Type = ConditionValueType.LowestValue;
                dataBar.MinPoint.Value = "0";
                dataBar.MaxPoint.Type = ConditionValueType.HighestValue;
                dataBar.MaxPoint.Value = "0";
                
                //Set color for Bar
                dataBar.BarColor = Color.FromArgb(156, 208, 243);

                //Hide the value in data bar
                dataBar.ShowValue = false;
                #endregion             

                #region Iconset
                //Add another condition in the same range
                conditionalFormat = conditionalFormats.AddCondition();

                //Set Icon conditionalFormat type
                conditionalFormat.FormatType = ExcelCFType.IconSet;
                IIconSet iconSet = conditionalFormat.IconSet;
                iconSet.IconSet = ExcelIconSetType.FourRating;
                iconSet.IconCriteria[0].Type = ConditionValueType.LowestValue;
                iconSet.IconCriteria[0].Value = "0";
                iconSet.IconCriteria[1].Type = ConditionValueType.HighestValue;
                iconSet.IconCriteria[1].Value = "0";
                iconSet.ShowIconOnly = true;

                //Sets Icon sets for another range
                conditionalFormats = worksheet.Range["E7:E46"].ConditionalFormats;
                conditionalFormat = conditionalFormats.AddCondition();
                conditionalFormat.FormatType = ExcelCFType.IconSet;
                iconSet = conditionalFormat.IconSet;
                iconSet.IconSet = ExcelIconSetType.ThreeSymbols;
                iconSet.IconCriteria[0].Type = ConditionValueType.LowestValue;
                iconSet.IconCriteria[0].Value = "0";
                iconSet.IconCriteria[1].Type = ConditionValueType.HighestValue;
                iconSet.IconCriteria[1].Value = "0";
                iconSet.ShowIconOnly = true;
                #endregion

                #region Databar Negative value settings
                //Add condition for the range
                IConditionalFormats conditionalFormats1 = worksheet.Range["E7:E46"].ConditionalFormats;
                IConditionalFormat conditionalFormat1 = conditionalFormats1.AddCondition();

                //Set Data bar and icon set for the same cell
                //Set the conditionalFormat type
                conditionalFormat1.FormatType = ExcelCFType.DataBar;
                IDataBar dataBar1 = conditionalFormat1.DataBar;

                //Set the constraint
                dataBar1.BarColor = Color.YellowGreen;
                dataBar1.NegativeFillColor = Color.Pink;
                dataBar1.NegativeBorderColor = Color.WhiteSmoke;
                dataBar1.BarAxisColor = Color.Yellow;
                dataBar1.BorderColor = Color.WhiteSmoke;
                dataBar1.DataBarDirection = DataBarDirection.context;
                dataBar1.DataBarAxisPosition = DataBarAxisPosition.middle;
                dataBar1.HasGradientFill = true;

                //Hide the value in data bar
                dataBar1.ShowValue = false;

                #endregion

                #region Color Scale
                conditionalFormats = worksheet.Range["D7:D46"].ConditionalFormats;
                conditionalFormat = conditionalFormats.AddCondition();
                conditionalFormat.FormatType = ExcelCFType.ColorScale;
                IColorScale colorScale = conditionalFormat.ColorScale;

                //Sets 3 - color scale.
                colorScale.SetConditionCount(3);

                colorScale.Criteria[0].FormatColorRGB = Color.FromArgb(230, 197, 218);
                colorScale.Criteria[0].Type = ConditionValueType.LowestValue;
                colorScale.Criteria[0].Value = "0";

                colorScale.Criteria[1].FormatColorRGB = Color.FromArgb(244, 210, 178);
                colorScale.Criteria[1].Type = ConditionValueType.Percentile;
                colorScale.Criteria[1].Value = "50";

                colorScale.Criteria[2].FormatColorRGB = Color.FromArgb(245, 247, 171);
                colorScale.Criteria[2].Type = ConditionValueType.HighestValue;
                colorScale.Criteria[2].Value = "0";
                #endregion
            }
            else
            {                 
            //The first worksheet object in the worksheets collection is accessed.
            worksheet = myWorkbook.Worksheets[0];
            worksheet.IsGridLinesVisible = false;
            worksheet.Range["D2"].Text = "Conditional Formatting";
            worksheet.Range["D2:E2"].Merge();
            worksheet.Range["D2"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
            worksheet.Range["D2"].CellStyle.Font.Bold = true;
            worksheet.Range["D2"].CellStyle.Font.Size = 14;
           

            #region Conditional Format with CellValue(Between)
            //Applying conditional formatting to "E5" for format type as CellValue( Between)
            IConditionalFormats condition = worksheet.Range["E5"].ConditionalFormats;
            worksheet.Range["E5"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
            worksheet.Range["E5"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
            worksheet.Range["E5"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;

            //Adding formats to IConditionalFormats collection
            IConditionalFormat condition1 = condition.AddCondition();
            worksheet.Range["D5"].Text = "Enter a Number between 10 to 20";
            condition1.FirstFormula = "10";
            condition1.SecondFormula = "20";
            //Setting format properties.
            condition1.Operator = ExcelComparisonOperator.Between;
            condition1.FormatType = ExcelCFType.CellValue;
            condition1.BackColorRGB = Color.FromArgb(238, 122, 3);
            condition1.IsBold = true;
            condition1.IsItalic = true;
            #endregion

            #region Conditional Format with CellValue(Equal)
            //Applying conditional formatting to "E8" for format type as CellValue( Equal)
            IConditionalFormats condition2 = worksheet.Range["E8"].ConditionalFormats;
            worksheet.Range["E8"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
            worksheet.Range["E8"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
            worksheet.Range["E8"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;

            //Adding formats to IConditionalFormats collection
            IConditionalFormat condition3 = condition2.AddCondition();
            worksheet.Range["D8"].Text = "Enter the Number as 1000";

            //Setting format properties.
            condition3.FormatType = ExcelCFType.CellValue;
            condition3.Operator = ExcelComparisonOperator.Equal;
            condition3.FirstFormula = "1000";
            condition3.FontColorRGB = Color.FromArgb(0xde, 0x64, 0x13);
            #endregion

            #region Conditional Format with CellValue(Not Between)
            //Applying conditional formatting to "E11" for format type as CellValue( Not between)
            IConditionalFormats condition4 = worksheet.Range["E11"].ConditionalFormats;
            worksheet.Range["E11"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
            worksheet.Range["E11"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
            worksheet.Range["E11"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;

            //Adding formats to IConditionalFormats collection
            IConditionalFormat condition5 = condition4.AddCondition();
            worksheet.Range["D11"].Text = "Enter a Number not between 100 to 200";
            //Setting format properties
            condition5.FormatType = ExcelCFType.CellValue;
            condition5.Operator = ExcelComparisonOperator.NotBetween;
            condition5.FirstFormula = "100";
            condition5.SecondFormula = "200";
            condition5.FillPattern = ExcelPattern.DarkVertical;
            #endregion

            #region Conditional Format with CellValue(Less or Equal)
            //Applying conditional formatting to "E14" for format type as CellValue( LessOrEqual)
            IConditionalFormats condition6 = worksheet.Range["E14"].ConditionalFormats;
            worksheet.Range["E14"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
            worksheet.Range["E14"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
            worksheet.Range["E14"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;

            //Adding formats to IConditionalFormats collection
            IConditionalFormat condition7 = condition6.AddCondition();
            worksheet.Range["D14"].Text = "Enter a Number which is less than or equal to 1000";
            //Setting format properties.
            condition7.FormatType = ExcelCFType.CellValue;
            condition7.Operator = ExcelComparisonOperator.LessOrEqual;
            condition7.FirstFormula = "1000";
            condition7.BackColorRGB = Color.FromArgb(204, 212, 230);
            #endregion

            #region Conditional Format with CellValue(Not Equal)
            //Applying conditional formatting to "E17" for format type as CellValue( NotEqual)
            IConditionalFormats condition8 = worksheet.Range["E17"].ConditionalFormats;
            worksheet.Range["E17"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
            worksheet.Range["E17"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
            worksheet.Range["E17"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;

            //Adding formats to IConditionalFormats collection
            IConditionalFormat condition9 = condition8.AddCondition();
            worksheet.Range["D17"].Text = "Enter a Number which is not equal to 1000";
            //Setting format properties.
            condition9.FormatType = ExcelCFType.CellValue;
            condition9.Operator = ExcelComparisonOperator.NotEqual;
            condition9.FirstFormula = "1000";
            condition9.BackColorRGB = Color.ForestGreen;
            worksheet.UsedRange.AutofitColumns();
            worksheet.UsedRange.AutofitRows();
            #endregion
            }

            #region Save the Workbook
            myWorkbook.SaveAs(OutputFileName);
            #endregion

            #region Workbook Close and Dispose
            //Close the workbook.
            myWorkbook.Close();

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
                    System.Diagnostics.Process.Start(OutputFileName);
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

        # endregion

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
    }
}