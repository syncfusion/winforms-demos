#region Copyright Syncfusion Inc. 2001-2016.
// Copyright Syncfusion Inc. 2001-2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms;

namespace EssentialXlsIOSample
{
    public partial class TableFormula : MetroForm
    {
        #region Initialize
        public TableFormula()
        {
            InitializeComponent();
        }
        #endregion

        # region CreateTableFormula
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
            
            //Set the default version as Excel 2013
            application.DefaultVersion = ExcelVersion.Excel2013;

            IWorkbook workbook = application.Workbooks.Create(1);
            IWorksheet sheet = workbook.Worksheets[0];
            #endregion

            #region Create Table
            // Create table
            IListObject table1 = sheet.ListObjects.Create("Table1", sheet["A1:F6"]);

            # region Table data
            // Fill table data
            sheet[1, 1].Text = "Product ID";
            sheet[1, 2].Text = "Quantity";
            sheet[1, 3].Text = "Rate";
            sheet[1, 4].Text = "Tax";
            sheet[1, 5].Text = "Discount";
            sheet[1, 6].Text = "Amount";

            sheet[2, 1].Text = "ProductA";
            sheet[2, 2].Number = 2;
            sheet[2, 3].Number = 16.80;
            sheet[2, 4].Number = 9.83;
            sheet[2, 5].Number = 10;

            sheet[3, 1].Text = "ProductB";
            sheet[3, 2].Number = 3;
            sheet[3, 3].Number = 15.60;
            sheet[3, 4].Number = 9.83;
            sheet[3, 5].Number = 5;

            sheet[4, 1].Text = "ProductC";
            sheet[4, 2].Number = 2;
            sheet[4, 3].Number = 20.10;
            sheet[4, 4].Number = 9.83;
            sheet[4, 5].Number = 8;

            sheet[5, 1].Text = "ProductD";
            sheet[5, 2].Number = 1;
            sheet[5, 3].Number = 40.50;
            sheet[5, 4].Number = 9.83;
            sheet[5, 5].Number = 20;

            sheet[6, 1].Text = "ProductE";
            sheet[6, 2].Number = 2;
            sheet[6, 3].Number = 30.70;
            sheet[6, 4].Number = 9.83;
            sheet[6, 5].Number = 15;
            # endregion

            // Create style for table number format
            IStyle style1 = workbook.Styles.Add("CurrencyFormat");
            style1.NumberFormat = "_($* #,##0.00_);_($* (#,##0.00);_($* \" - \"??_);_(@_)";

            // Apply number format
            sheet["C2:F6"].CellStyleName = "CurrencyFormat";            

            // Apply builtin table style
            table1.BuiltInTableStyle = TableBuiltInStyles.TableStyleMedium9;

            //Set table column calculated formula
            table1.Columns[5].CalculatedFormula = "[@Quantity]*[@Rate]+[@Tax]-[@Discount]";

            //Show Total row and set total calculation
            table1.ShowTotals = true;
            table1.Columns[0].TotalsRowLabel = "Total";
            table1.Columns[1].TotalsCalculation = ExcelTotalsCalculation.Sum;
            table1.Columns[2].TotalsCalculation = ExcelTotalsCalculation.Sum;
            table1.Columns[3].TotalsCalculation = ExcelTotalsCalculation.Sum;
            table1.Columns[4].TotalsCalculation = ExcelTotalsCalculation.Sum;
            table1.Columns[5].TotalsCalculation = ExcelTotalsCalculation.Sum;

            sheet.SetColumnWidth(1, 11.71);
            sheet.SetColumnWidth(2, 10.29);
            sheet.SetColumnWidth(3, 8.29);
            sheet.SetColumnWidth(4, 7.29);
            sheet.SetColumnWidth(5, 10.29);
            sheet.SetColumnWidth(6, 9.71);

            #endregion

            #region Workbook save
            // Save and close the document
            workbook.SaveAs("TableFormula.xlsx");
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
                System.Diagnostics.Process.Start("TableFormula.xlsx");
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