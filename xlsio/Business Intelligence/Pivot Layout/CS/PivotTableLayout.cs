#region Copyright Syncfusion Inc. 2001 - 2022
//
//  Copyright Syncfusion Inc. 2001 - 2022. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms;
using Syncfusion.ExcelToPdfConverter;
using Syncfusion.Pdf;
using System.Drawing;
using Syncfusion.XlsIO.Implementation.PivotTables;

namespace EssentialXlsIOSamples
{
    public partial class PivotTable : MetroForm
    {
        #region Constants
#if NETCORE
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\common\Data\XlsIO\{0}";
#else
        private const string DEFAULTPATH = @"..\..\..\..\..\..\common\Data\XlsIO\{0}";
#endif
        #endregion

        #region Initialize
        public PivotTable()
        {
            InitializeComponent();
        }
        #endregion

        #region Create Pivot Table
        /// <summary>
        /// Create Pivot Table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;
            application.DefaultVersion = ExcelVersion.Excel2016;
            // Accessing workbook
            string inputPath = GetFullTemplatePath("PivotLayout.xlsx");
            IWorkbook workbook = application.Workbooks.Open(inputPath);

            CreatePivotTable(workbook);
            IPivotTable pivotTable = workbook.Worksheets[1].PivotTables[0];
            pivotTable.Layout();

            //To view the pivot table inline formatting in MS Excel, we have to set the IsRefreshOnLoad property as true.             
            (workbook.PivotCaches[pivotTable.CacheIndex] as PivotCacheImpl).IsRefreshOnLoad = true;

            //Save the document as Excel
            string outputFileName = "PivotLayoutCompact.xlsx";

            if (rdBtnOutline.Checked)
                outputFileName = "PivotLayoutOutline.xlsx";
            else if (rdBtnTabular.Checked)
                outputFileName = "PivotLayoutTabular.xlsx";
            try
            {
                workbook.SaveAs(outputFileName);

                //Close the workbook.
                workbook.Close();

                //No exception will be thrown if there are unsaved workbooks.
                excelEngine.ThrowNotSavedOnDestroy = false;
                excelEngine.Dispose();

                //Message box confirmation to view the created spreadsheet.
                if (MessageBox.Show("Do you want to view the workbook?", "Workbook has been created",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
#if NETCORE
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        process.StartInfo = new System.Diagnostics.ProcessStartInfo(outputFileName)
                        {
                            UseShellExecute = true
                        };
                        process.Start();
#else
                        Process.Start(outputFileName);
#endif
                    }
                    catch (Win32Exception ex)
                    {
                        MessageBox.Show("Excel 2007 is not installed in this system");
                        Console.WriteLine(ex.ToString());
                    }
                }
                else
                    // Exit
                    this.Close();
            }
            catch
            {
                MessageBox.Show("Sorry, Excel can't open two workbooks with the same name at the same time.\nPlease close the workbook and try again.", "File is already open", MessageBoxButtons.OK);
            }
        }
        #endregion

        #region Convert Pivot Table
        /// <summary>
        /// Convert To PDF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvert_Click(object sender, EventArgs e)
        {
            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;
            application.DefaultVersion = ExcelVersion.Excel2016;
            // Accessing workbook
            string inputPath = GetFullTemplatePath("PivotLayout.xlsx");
            IWorkbook workbook = application.Workbooks.Open(inputPath);

            CreatePivotTable(workbook);
            //Intialize the ExcelToPdfConverter class
            ExcelToPdfConverter converter = new ExcelToPdfConverter(workbook);
            //Intialize the ExcelToPdfConverterSettings class
            ExcelToPdfConverterSettings settings = new ExcelToPdfConverterSettings();
            //Set the Layout Options for the output Pdf page.
            settings.LayoutOptions = LayoutOptions.FitSheetOnOnePage;
            //Convert the Excel document to PDF
            PdfDocument pdfDoc = converter.Convert(settings);
            //Save the document as PDF
            string outputFileName = "PivotLayoutCompact.pdf";

            if (rdBtnOutline.Checked)
                outputFileName = "PivotLayoutOutline.pdf";
            else if (rdBtnTabular.Checked)
                outputFileName = "PivotLayoutTabular.pdf";
            try
            {
                pdfDoc.Save(outputFileName);

                pdfDoc.Close();
                converter.Dispose();
                //Close the workbook.
                workbook.Close();

                //No exception will be thrown if there are unsaved workbooks.
                excelEngine.ThrowNotSavedOnDestroy = false;
                excelEngine.Dispose();

                //Message box confirmation to view the created spreadsheet.
                if (MessageBox.Show("Do you want to view the PDF?", "PDF has been created",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        //Launching the PDF file using the default Application.
#if NETCORE
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        process.StartInfo = new System.Diagnostics.ProcessStartInfo(outputFileName)
                        {
                            UseShellExecute = true
                        };
                        process.Start();
#else
                        Process.Start(outputFileName);
#endif
                    }
                    catch (Win32Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
                else
                    // Exit
                    this.Close();
            }
            catch
            {
                MessageBox.Show("Sorry, PDF can't opened", "File is already open", MessageBoxButtons.OK);
            }

            workbook.Close();
            excelEngine.Dispose();
        }
        #endregion

        /// <summary>
        /// Create pivot table with the workbook
        /// </summary>
        /// <param name="workbook"></param>
        protected void CreatePivotTable(IWorkbook workbook)
        {
            // The first worksheet object in the worksheets collection is accessed.
            IWorksheet sheet = workbook.Worksheets[0];
            //Access the sheet to draw pivot table.
            IWorksheet pivotSheet = workbook.Worksheets[1];
            pivotSheet.Activate();
            //Select the data to add in cache
            IPivotCache cache = workbook.PivotCaches.Add(sheet["A1:G20"]);
            //Insert the pivot table. 
            IPivotTable pivotTable = pivotSheet.PivotTables.Add("PivotTable1", pivotSheet["A1"], cache);
            pivotTable.Fields[0].Axis = PivotAxisTypes.Row;
            pivotTable.Fields[1].Axis = PivotAxisTypes.Row;
            pivotTable.Fields[2].Axis = PivotAxisTypes.Row;
            IPivotField field1 = pivotSheet.PivotTables[0].Fields[5];
            pivotTable.DataFields.Add(field1, "Sum of Land Area", PivotSubtotalTypes.Sum);
            IPivotField field2 = pivotSheet.PivotTables[0].Fields[6];
            pivotTable.DataFields.Add(field2, "Sum of Water Area", PivotSubtotalTypes.Sum);
            if (rdBtnOutline.Checked)
            {
                pivotTable.Options.RowLayout = PivotTableRowLayout.Outline;
                pivotTable.Location = pivotSheet.Range[1, 1, 51, 5];
                //Apply Inline formatting to pivot table
                IPivotCellFormat cellFormat1 = pivotTable.GetCellFormat("B3:E4");
                cellFormat1.BackColorRGB = Color.FromArgb(255, 169, 208, 142);
                IPivotCellFormat cellFormat2 = pivotTable.GetCellFormat("B31:E32");
                cellFormat2.BackColorRGB = Color.FromArgb(255, 244, 176, 132);
            }
            else if (rdBtnTabular.Checked)
            {
                pivotTable.Location = pivotSheet.Range[1, 1, 51, 5];
                pivotTable.Options.RowLayout = PivotTableRowLayout.Tabular;
                //Apply Inline formatting to pivot table
                IPivotCellFormat cellFormat1 = pivotTable.GetCellFormat("B2:E2");
                cellFormat1.BackColorRGB = Color.FromArgb(255, 169, 208, 142);
                IPivotCellFormat cellFormat2 = pivotTable.GetCellFormat("B30:E30");
                cellFormat2.BackColorRGB = Color.FromArgb(255, 244, 176, 132);
            }
            else
            {
                pivotTable.Location = pivotSheet.Range[1, 1, 51, 3];
                //Apply Inline formatting to pivot table
                IPivotCellFormat cellFormat1 = pivotTable.GetCellFormat("A3:C4");
                cellFormat1.BackColorRGB = Color.FromArgb(255, 169, 208, 142);
                IPivotCellFormat cellFormat2 = pivotTable.GetCellFormat("A31:C32");
                cellFormat2.BackColorRGB = Color.FromArgb(255, 244, 176, 132);
            }
            //Apply built in style.
            pivotTable.BuiltInStyle = PivotBuiltInStyles.PivotStyleMedium9;
            pivotSheet.Range[1, 1, 1, 14].ColumnWidth = 11;
            pivotSheet.SetColumnWidth(1, 15.29);
            pivotSheet.SetColumnWidth(2, 15.29);
            if (pivotTable.Options.RowLayout == PivotTableRowLayout.Compact)
            {
                pivotSheet.SetColumnWidth(4, 1.0);
                pivotSheet.SetColumnWidth(5, 2.0);
                pivotSheet.SetColumnWidth(6, 0.5);
                pivotSheet.Range[2, 5, 2, 5].CellStyle.Color = Color.FromArgb(255, 169, 208, 142);
                pivotSheet.Range[4, 5, 4, 5].CellStyle.Color = Color.FromArgb(255, 244, 176, 132);
                pivotSheet.Range[2, 7, 2, 7].Text = "County with largest land area";
                pivotSheet.Range[4, 7, 4, 7].Text = "County with smallest land area";
            }
            else
            {
                pivotSheet.SetColumnWidth(6, 1.0);
                pivotSheet.SetColumnWidth(7, 2.0);
                pivotSheet.SetColumnWidth(8, 0.5);
                pivotSheet.Range[2, 7, 2, 7].CellStyle.Color = Color.FromArgb(255, 169, 208, 142);
                pivotSheet.Range[4, 7, 4, 7].CellStyle.Color = Color.FromArgb(255, 244, 176, 132);
                pivotSheet.Range[2, 9, 2, 9].Text = "County with largest land area";
                pivotSheet.Range[4, 9, 4, 9].Text = "County with smallest land area";
            }

            //Activate the pivot sheet.
            pivotSheet.Activate();
        }

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