using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using System.Data.OleDb;
using Syncfusion.Windows.Forms;
using System.Globalization;

namespace EssentialXlsIOSample
{
    public partial class StockReport : MetroForm
    {
        #region Constants
        /// <summary>
        /// Specifies database connection string
        /// </summary>
        private string conString;
        /// <summary>
        /// Specifies number of the first row in data grid in first worksheet.
        /// </summary>
        private const int DEF_FST_ROW_NUM_FS = 38;
        /// <summary>
        /// Specifies number of the first row in data grid in first worksheet.
        /// </summary>
        private const int DEF_FST_ROW_NUM_SC = 25;

        /// <summary>
        /// Default path of the input file
        /// </summary>
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\Common\Data\XlsIO\";
        #endregion

        #region Fields
        /// <summary>
        /// DataSet.
        /// </summary>
        private DataSet ds;
        /// <summary>
        /// Specifies workbook.
        /// </summary>
        private IWorkbook myWorkbook;
        /// <summary>
        /// Image for ChartArea background.
        /// </summary>
        private string userImage;
        /// <summary>
        /// Data directory
        /// </summary>
        private DirectoryInfo dataDirectory;
        /// <summary>
        /// Report's directory.
        /// </summary>
        private string reportDirectory;
        /// <summary>
        /// File Name
        /// </summary>
        private string fileName;
        #endregion

        #region Initialize
        public StockReport()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        #region CreateReport
        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            #region Initialize Workbook
            ExcelEngine excelEngine = new ExcelEngine();
            IApplication application = excelEngine.Excel;
            // A new workbook is created.[Equivalent to creating a new workbook in MS Excel]
            // The number of default worksheets is the application setting in MS Excel.
            myWorkbook = excelEngine.Excel.Workbooks.Add(dataDirectory.FullName + "Template.xls");

            //Set the Default version as Excel 97to2003
            if (this.rdbExcel97.Checked)
            {
                myWorkbook.Version = ExcelVersion.Excel97to2003;
                fileName = "StockPortfolioOutput.xls";
            }
            //Set the Default version as Excel 2007
            else if (this.rdbExcek2007.Checked)
            {
                myWorkbook.Version = ExcelVersion.Excel2007;
                fileName = "StockPortfolioOutput.xlsx";
            }
            //Set the Default version as Excel 2010
            else if (this.rdbExcel2010.Checked)
            {
                myWorkbook.Version = ExcelVersion.Excel2010;
                fileName = "StockPortfolioOutput.xlsx";
            }
            //Set the Default version as Excel 2013
            else if (this.rdbExcel2013.Checked)
            {
                myWorkbook.Version = ExcelVersion.Excel2013;
                fileName = "StockPortfolioOutput.xlsx";
            }

            IChart chart = myWorkbook.Worksheets[1].Charts[0];
            chart.PrimaryCategoryAxis.NumberFormat = "m/d/yyyy";
            chart.PrimaryValueAxis.NumberFormat = "\"$\"#,##0.00";
            chart.SecondaryValueAxis.NumberFormat = "\"$\"#,##0.00";
            chart.SecondaryValueAxis.TickLabelPosition = ExcelTickLabelPosition.TickLabelPosition_High;

            // Adding new worksheets in workbook's sheets collection
            for (int count = 1; count < StockList.SelectedItems.Count; count++)
            {
                myWorkbook.Worksheets.AddCopyAfter(myWorkbook.Worksheets[1], myWorkbook.Worksheets[0]);
            }

            // Adding hyperlinks to menu sheet 
            IWorksheet menu_sheet = myWorkbook.Worksheets[0];
            #endregion

            int InsertIndex = DEF_FST_ROW_NUM_SC - 3;

            menu_sheet.HyperLinks.RemoveAt(0);
            menu_sheet.Range["G21"].Text = "";

            #region Insert Hyperlinks for Stock items
            for (int count = 0; count < StockList.SelectedItems.Count; count++)
            {
                menu_sheet.InsertRow(InsertIndex, 2, ExcelInsertOptions.FormatAsBefore);
                IHyperLink report_hyperlink = menu_sheet.HyperLinks.Add(menu_sheet.Range["G" + InsertIndex + ":I" + InsertIndex]);
                report_hyperlink.Type = ExcelHyperLinkType.Workbook;
                report_hyperlink.Address = StockList.SelectedItems[count].ToString() + "!A1";
                report_hyperlink.TextToDisplay = StockList.SelectedItems[count].ToString();

                InsertIndex += 2;
            }
            #endregion

            #region Creating Stock report

            int itemIndex = 1;

            foreach (Object StockListItem in StockList.SelectedItems)
            {
                CreateStockReport(StockListItem.ToString(), itemIndex);
                FillAnalysisPortfolioSheet(StockListItem.ToString());
                itemIndex += 1;
            }
            #endregion

            #region Save the Workbook
            myWorkbook.Worksheets[0].Activate();
            // Saving the workbook to disk.
            myWorkbook.SaveAs(reportDirectory + "\\" + fileName);
            #endregion

            #region Dispose the Excel Engine
            // No exception will be thrown if there are unsaved workbooks. No use here since we are
            // saving the workbook.
            excelEngine.ThrowNotSavedOnDestroy = false;
            excelEngine.Dispose();
            #endregion

            #region View the Workbook
            //Message box confirmation to view the created spreadsheet.
            if (MessageBox.Show("Do you want to view the workbook?", "Workbook has been created",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start(reportDirectory + "\\" + fileName);
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

        #region Form Load
        private void StockReport_Load(object sender, EventArgs e)
        {
            #region Create and Fill Dataset
            // Create the DataSet
            ds = new DataSet();

            StockList.SelectedIndex = 0;
            dataDirectory = new DirectoryInfo(DEFAULTPATH);
            reportDirectory = Application.StartupPath;
            conString = @"Provider=Microsoft.JET.OLEDB.4.0;" + @"data source=" + dataDirectory.FullName + "DataBase.mdb";

            // Create an open the connection
            OleDbConnection conn = new OleDbConnection(conString);
            conn.Open();

            // Create the adapter and fill the DataSet
            OleDbCommand command = new OleDbCommand(@"SELECT Min(Date) as MinDate, Max(Date) as MaxDate FROM StockData", conn);

            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            adapter.Fill(ds);
            #endregion

            #region Set min and max date for Start and end time picker
            DateTime minDate = DateTime.Parse(ds.Tables[0].Rows[0]["MinDate"].ToString().Trim(), CultureInfo.InvariantCulture);
            DateTime maxDate = DateTime.Parse(ds.Tables[0].Rows[0]["MaxDate"].ToString().Trim(), CultureInfo.InvariantCulture);

            //Set minimum and maximum Date for StartDataTimePicker
            StartDateTimePicker.MinDate = minDate;
            StartDateTimePicker.MaxDate = maxDate;

            //Set minimum and maximum date for EndDateTimePicker
            EndDateTimePicker.MinDate = minDate;
            EndDateTimePicker.MaxDate = maxDate;
            #endregion

            // Close the connection
            conn.Close();
        }
        #endregion

        #region Browse Image
        private void bacgrimage_Click(object sender, EventArgs e)
        {
            ImageChDialog.Title = "Insert Image";
            ImageChDialog.Filter = "JPG|*.jpg;*.jpeg|PNG|*.png";
            if (ImageChDialog.ShowDialog() == DialogResult.OK)
            {
                userImage = ImageChDialog.FileName;
            }
        }
        #endregion

        #region Browse Report Directory
        private void reportdir_Click_1(object sender, EventArgs e)
        {
            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                reportDirectory = FolderBrowserDialog.SelectedPath;
            }
        }
        #endregion
        #endregion

        #region Helper Methods

        #region FillAnalysisPortfolioSheet
        private void FillAnalysisPortfolioSheet(string StockSymbol)
        {
            // Fill Portfolio Analysis sheet
            int AnalysisPortfolioSheetNum = myWorkbook.Worksheets.Count - 1;

            IWorksheet portf_analysis_sheet = myWorkbook.Worksheets[AnalysisPortfolioSheetNum];

            OleDbConnection conn = new OleDbConnection(conString);
            conn.Open();

            // Fill StockStyle
            ds.Tables.Clear();

            // Create the adapter and fill the DataSet
            OleDbCommand command = new OleDbCommand(@"select * from StockStyles", conn);

            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            adapter.Fill(ds);

            for (int count = 0; count < ds.Tables[0].Rows.Count; count++)
            {
                portf_analysis_sheet.Range["D" + (DEF_FST_ROW_NUM_SC + count)].Value = ds.Tables[0].Rows[count]["StockStyle"].ToString();
            }

            ds.Tables.Clear();

            command = new OleDbCommand(@"select * from StockTypes", conn);

            adapter = new OleDbDataAdapter(command);
            adapter.Fill(ds);

            for (int count = 0; count < ds.Tables[0].Rows.Count; count++)
            {
                portf_analysis_sheet.Range["I" + (DEF_FST_ROW_NUM_SC + count)].Value = ds.Tables[0].Rows[count]["StockType"].ToString();
            }

            // Clear all tables in dataset
            ds.Tables.Clear();

            command = new OleDbCommand(@"select * from StockInfo where StockName = '" + StockSymbol + "'", conn);

            adapter = new OleDbDataAdapter(command);
            adapter.Fill(ds);

            int cell_num = DEF_FST_ROW_NUM_SC + Int32.Parse(ds.Tables[0].Rows[0]["StockStyle"].ToString()) - 1;

            int cell_value = 0;

            if (portf_analysis_sheet.Range["E" + cell_num.ToString()].Value.Length > 0)
                cell_value = Int32.Parse(portf_analysis_sheet.Range["E" + cell_num.ToString()].Value);

            cell_value += 1;
            portf_analysis_sheet.Range["E" + cell_num.ToString()].Value2 = cell_value;

            cell_num = DEF_FST_ROW_NUM_SC + Int32.Parse(ds.Tables[0].Rows[0]["StockType"].ToString()) - 1;

            cell_value = 0;

            if (portf_analysis_sheet.Range["E" + cell_num.ToString()].Value.Length > 0)
                cell_value = Int32.Parse(portf_analysis_sheet.Range["E" + cell_num.ToString()].Value);

            cell_value += 1;

            portf_analysis_sheet.Range["J" + cell_num.ToString()].Value2 = cell_value;

            // Close the connection
            conn.Close();
        }
        #endregion

        #region CreateStockReport
        private void CreateStockReport(string StockSymbol, int itemIndex)
        {
            // Clear all tables in dataset
            ds.Tables.Clear();

            // Create an open the connection
            OleDbConnection conn = new OleDbConnection(conString);
            conn.Open();

            // Create the adapter and fill the DataSet
            OleDbCommand command = new OleDbCommand(@"select Date, Volume, OpenPrice, HighPrice, LowPrice, ClosePrice from StockData where symbol = '"
               + StockSymbol + "' and Date between @FromDate and @ToDate order by Date", conn);

            command.Parameters.Add("@FromDate", OleDbType.Date).Value = StartDateTimePicker.Value;
            command.Parameters.Add("@ToDate", OleDbType.Date).Value = EndDateTimePicker.Value;

            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            adapter.Fill(ds);
            // Close the connection
            conn.Close();

            DataTable table = ds.Tables[0];

            if (table.Rows.Count > 0)
            {
                if (itemIndex > 1)
                    FillReport(itemIndex, table, StockSymbol, false);
                else
                    FillReport(1, table, StockSymbol, false);
            }
        }
        #endregion

        #region FillReport
        private void FillReport(int report, DataTable table, string StockSymbol, bool hasLegend)
        {
            IWorksheet reportSheet = myWorkbook.Worksheets[report];

            reportSheet.Name = StockSymbol;

            if (table.Rows.Count > 1)
                reportSheet.InsertRow(DEF_FST_ROW_NUM_FS + 1, table.Rows.Count - 1, ExcelInsertOptions.FormatAsBefore);
            // Inserting data into the spreadsheet.
            reportSheet.ImportDataTable(table, true, (DEF_FST_ROW_NUM_FS - 1), 3);

            int rownum = DEF_FST_ROW_NUM_FS - 1;

            reportSheet.Range["I3"].Text = StockSymbol;
            reportSheet.Range["C" + rownum.ToString()].Text = "Date";
            reportSheet.Range["D" + rownum.ToString()].Text = "Volume";
            reportSheet.Range["E" + rownum.ToString()].Text = "Open Price";
            reportSheet.Range["F" + rownum.ToString()].Text = "High Price";
            reportSheet.Range["G" + rownum.ToString()].Text = "Low Price";
            reportSheet.Range["H" + rownum.ToString()].Text = "Close Price";

            for (int count = 0; count < table.Rows.Count; count++)
            {
                string cellNum = (count + DEF_FST_ROW_NUM_FS).ToString();
                reportSheet.Range["I" + cellNum].Formula = "$H" + cellNum + "-$E" + cellNum;
            }

            IChartShapes charts = reportSheet.Charts;
            foreach (IChartShape chart in charts)
            {
                chart.DataRange = reportSheet.Range["C" + DEF_FST_ROW_NUM_FS + ":H" + (table.Rows.Count + (DEF_FST_ROW_NUM_FS - 1))];
                chart.ChartType = ExcelChartType.Stock_VolumeOpenHighLowClose;

                chart.ChartArea.IsBorderCornersRound = isCornersRound.Checked;

                if (userImage != null && userImage.Length > 0)
                    chart.ChartArea.Fill.UserPicture(userImage);

                chart.Series[0].SerieFormat.LineProperties.LinePattern = ExcelChartLinePattern.Solid;
                chart.Series[0].SerieFormat.LineProperties.LineWeight = ExcelChartLineWeight.Narrow;
                chart.Series[0].SerieFormat.LineProperties.LineColor = Color.Blue;

                chart.Series[1].SerieFormat.LineProperties.LinePattern = ExcelChartLinePattern.Solid;
                chart.Series[1].SerieFormat.LineProperties.LineWeight = ExcelChartLineWeight.Narrow;
                chart.Series[1].SerieFormat.LineProperties.LineColor = Color.Blue;

                chart.HasLegend = hasLegend;
            }
        }
        #endregion

        #region View the Input File
        private void viewInputTemplate_Click(object sender, EventArgs e)
        {
            //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
            System.Diagnostics.Process.Start(dataDirectory.FullName + "Template.xls");
        }
        #endregion

       

        #endregion
    }
}