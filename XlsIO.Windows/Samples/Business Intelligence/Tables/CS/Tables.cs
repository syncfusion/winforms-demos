using System;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms;

namespace EssentialXlsIOSample
{
    public partial class Tables : MetroForm
    {
        #region Initialize
        public Tables()
        {
            InitializeComponent();

            rdbExcel2013.Checked = true;
        }
        #endregion

        # region CreateTable
        /// <summary>
        /// Create spreadsheet with table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            #region Workbook Initialize
            ExcelEngine excelEngine = new ExcelEngine();
            IApplication application = excelEngine.Excel;
            //Set the default version as Excel 2007
            if (rdbExcel2007.Checked)
                application.DefaultVersion = ExcelVersion.Excel2007;
            //Set the default version as Excel 2010
            if (rdbExcel2010.Checked)
                application.DefaultVersion = ExcelVersion.Excel2010;
            //Set the default version as Excel 2013
            if (rdbExcel2013.Checked)
                application.DefaultVersion = ExcelVersion.Excel2013;

            IWorkbook workbook = application.Workbooks.Create(1);
            IWorksheet worksheet = workbook.Worksheets[0];
            #endregion

            # region Table data
            // Create data
            worksheet[1, 1].Text = "Products";
            worksheet[1, 2].Text = "Qtr1";
            worksheet[1, 3].Text = "Qtr2";

            worksheet[2, 1].Text = "Alfreds Futterkiste";
            worksheet[2, 2].Number = 744.6;
            worksheet[2, 3].Number = 162.56;

            worksheet[3, 1].Text = "Antonio Moreno Taqueria";
            worksheet[3, 2].Number = 5079.6;
            worksheet[3, 3].Number = 1249.2;

            worksheet[4, 1].Text = "Around the Horn";
            worksheet[4, 2].Number = 1267.5;
            worksheet[4, 3].Number = 1062.5;

            worksheet[5, 1].Text = "Bon app";
            worksheet[5, 2].Number = 1418;
            worksheet[5, 3].Number = 756;

            worksheet[6, 1].Text = "Eastern Connection";
            worksheet[6, 2].Number = 4728;
            worksheet[6, 3].Number = 4547.92;

            worksheet[7, 1].Text = "Ernst Handel";
            worksheet[7, 2].Number = 943.89;
            worksheet[7, 3].Number = 349.6;
            # endregion

            #region Create Table
            // Create style for table number format
            IStyle style1 = workbook.Styles.Add("CurrencyFormat");
            style1.NumberFormat = "_($* #,##0.00_);_($* (#,##0.00);_($* \" - \"??_);_(@_)";

            // Apply number format
            worksheet["B2:C8"].CellStyleName = "CurrencyFormat";

            // Create table
            IListObject table1 = worksheet.ListObjects.Create("Table1", worksheet["A1:C7"]);

            // Apply builtin style
            table1.BuiltInTableStyle = TableBuiltInStyles.TableStyleMedium9;

            // Total row
            table1.ShowTotals = true;
            table1.Columns[0].TotalsRowLabel = "Total";
            table1.Columns[1].TotalsCalculation = ExcelTotalsCalculation.Sum;
            table1.Columns[2].TotalsCalculation = ExcelTotalsCalculation.Sum;
            #endregion

            #region Save the Workbook
            worksheet.UsedRange.AutofitColumns();
            worksheet.SetColumnWidth(2, 12.43);

            // Save and close the document
            workbook.SaveAs("CreateTable.xlsx");
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
                System.Diagnostics.Process.Start("CreateTable.xlsx");
                this.Close();
            }
            else
            {
                // Exit
                this.Close();
            }
            #endregion
        }
        # endregion

       
    }
}