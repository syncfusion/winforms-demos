using System;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms;

namespace EssentialXlsIOSamples
{
    public partial class PivotTable : MetroForm
    {
        #region Constants
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\Common\Data\XlsIO\{0}";
        #endregion

        #region Initialize
        public PivotTable()
        {
            InitializeComponent();
            rdbExcel2013.Checked = true; 
        }
        #endregion

        #region Creating Pivot Table
        /// <summary>
        /// Creates Spreadsheet with Styles and Formatting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            #region Worksheet Initialize
            //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;

            //Set the default version as Excel 2007;
            if (rdbExcel2007.Checked)
                application.DefaultVersion = ExcelVersion.Excel2007;
            //Set the default version as Excel 2010;
            if (rdbExcel2010.Checked)
                application.DefaultVersion = ExcelVersion.Excel2010;
            //Set the default version as Excel 2013;
            if (rdbExcel2013.Checked)
                application.DefaultVersion = ExcelVersion.Excel2013;

            //Get the Path of Input file
            string inputPath = GetFullTemplatePath("PivotCodeDate.xlsx");
            IWorkbook workbook = application.Workbooks.Open(inputPath);

            // The first worksheet object in the worksheets collection is accessed.
            IWorksheet worksheet = workbook.Worksheets[0];
            #endregion

            #region Create Pivot Table
            //Access the worksheet to draw pivot table.
            IWorksheet pivotSheet = workbook.Worksheets[1];
            pivotSheet.Activate();
            //Select the data to add in cache
            IPivotCache cache = workbook.PivotCaches.Add(worksheet["A1:H50"]);

            //Insert the pivot table. 
            IPivotTable pivotTable = pivotSheet.PivotTables.Add("PivotTable1", pivotSheet["A1"], cache);
            pivotTable.Fields[4].Axis = PivotAxisTypes.Page;

            pivotTable.Fields[2].Axis = PivotAxisTypes.Row;
            pivotTable.Fields[6].Axis = PivotAxisTypes.Row;
            pivotTable.Fields[3].Axis = PivotAxisTypes.Column;

            IPivotField field = pivotSheet.PivotTables[0].Fields[5];
            pivotTable.DataFields.Add(field, "Sum of Units", PivotSubtotalTypes.Sum);
#if !SyncfusionFramework2_0
            #region Apply RowField Filter
            if (ckbRowFieldFilter.Checked)
            {
                if (rdbRCLabelFilter.Checked)
                {
                    pivotTable.Fields[2].PivotFilters.Add(PivotFilterType.CaptionEqual, null, "East", null);
                }
                else if (rdbRCValueFilter.Checked)
                {
                    pivotTable.Fields[2].PivotFilters.Add(PivotFilterType.ValueEqual, field, "1341", null);
                }
                else
                {
                    pivotTable.Fields[2].Items[0].Visible = false;
                    pivotTable.Fields[2].Items[1].Visible = false;
                }
            }
            #endregion

            #region Column Field Filter
            if (ckbColumnFieldFilter.Checked)
            {
                if (rdbRCLabelFilter.Checked)
                {
                    pivotTable.Fields[3].PivotFilters.Add(PivotFilterType.CaptionNotEqual, null, "Jones", null);
                }
                else if (rdbRCValueFilter.Checked)
                {
                    pivotTable.Fields[3].PivotFilters.Add(PivotFilterType.ValueEqual, field, "398", null);
                }
                else
                {
                    pivotTable.Fields[3].Items[0].Visible = false;
                    pivotTable.Fields[3].Items[1].Visible = false;
                }
            }
            #endregion

            #region PageField Filter
            if (ckbPageFilter.Checked)
            {

                //'Create Pivot Filter object to apply filter to page Fields
                IPivotFilter filterValue = pivotTable.Fields[4].PivotFilters.Add();
                //Page Field would be filtered with value 'Binder'
                filterValue.Value1 = "Binder";
                //XlsIO layout the Pivot table like MS Excel
                if (!rdbRCValueFilter.Checked)
                    pivotTable.Layout();
            }
            else if (ckbMultiplePageFilter.Checked)
            {

                pivotTable.Fields[4].Items[1].Visible = false;
                pivotTable.Fields[4].Items[2].Visible = false;
                if (!rdbRCValueFilter.Checked)
                    pivotTable.Layout();
            }

            #endregion
#endif
            
            //Apply built in style.
            pivotTable.BuiltInStyle = PivotBuiltInStyles.PivotStyleMedium2;

            //Activate the pivot worksheet.
            pivotSheet.Activate();
            pivotSheet.Range[1, 1, 1, 14].ColumnWidth = 11;
            pivotSheet.SetColumnWidth(1, 15.29);
            pivotSheet.SetColumnWidth(2, 15.29);
            #endregion

            #region Save the Workbook
            //Saving the workbook to disk.
            workbook.SaveAs("PivotTable.xlsx");
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
                    System.Diagnostics.Process.Start("PivotTable.xlsx");
                    //Exit
                    //this.Close();
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

        #region Customizing Pivot Table
        private void btnCustomize_Click(object sender, EventArgs e)
        {
            #region Workbook Initialize
            ExcelEngine excelEngine = new ExcelEngine();

            IApplication application = excelEngine.Excel;

            //Set the default version as Excel 2007;
            if (rdbExcel2007.Checked)
                application.DefaultVersion = ExcelVersion.Excel2007;
            //Set the default version as Excel 2010;
            if (rdbExcel2010.Checked)
                application.DefaultVersion = ExcelVersion.Excel2010;
            //Set the default version as Excel 2013;
            if (rdbExcel2013.Checked)
                application.DefaultVersion = ExcelVersion.Excel2013;
            //Get the Path of the Input File
            string inputPath = GetFullTemplatePath("PivotTable.xlsx");
            IWorkbook workbook = application.Workbooks.Open(inputPath);

            // The first worksheet object in the worksheets collection is accessed.
            IWorksheet worksheet = workbook.Worksheets[1];
            worksheet.Activate();
            #endregion

            #region Customize the Pivot Table
            //Access the collection of Pivot Table in the worksheet.
            IPivotTables pivotTables = worksheet.PivotTables;

            //Access the Single pivot table from the collection.
            IPivotTable pivotTable = pivotTables[0];

            //Access collection of pivot fields from the pivot table.
            IPivotFields fields = pivotTable.Fields;

            //Access a Pivot field from the collection.
            IPivotField field = fields[2];
            //Add the field to page axis
            field.Axis = PivotAxisTypes.Page;

            fields[1].Axis = PivotAxisTypes.None;
            fields[0].Axis = PivotAxisTypes.None;
            fields[3].Axis = PivotAxisTypes.Row;
            fields[4].Axis = PivotAxisTypes.Column;

            //Accessing the Calculated fields from the pivot table .
            IPivotCalculatedFields calculatedfields = pivotTable.CalculatedFields;
            IPivotField dataField = fields[5];
            //Adding Calculatd field to the pivot table.
            //  IPivotField calculatedField = calculatedfields.Add("Percent", "Units/3000*100");
#if !SyncfusionFramework2_0
            if (ckbRowFieldFilter.Checked)
            {
                if (rdbRCLabelFilter.Checked)
                {
                    pivotTable.Fields[3].PivotFilters.Add(PivotFilterType.CaptionNotEqual, null, "Parent", null);
                }
                else if (rdbRCValueFilter.Checked)
                {
                    pivotTable.Fields[3].PivotFilters.Add(PivotFilterType.ValueGreaterThan, dataField, "100", null);
                }
                else
                {
                    pivotTable.Fields[3].Items[0].Visible = false;
                }

            }
            if (ckbColumnFieldFilter.Checked)
            {
                if (rdbRCLabelFilter.Checked)
                {
                    pivotTable.Fields[4].PivotFilters.Add(PivotFilterType.CaptionNotEqual, null, "Binder", null);
                }
                else if (rdbRCValueFilter.Checked)
                {
                    pivotTable.Fields[4].PivotFilters.Add(PivotFilterType.ValueGreaterThan, dataField, "100", null);
                }
                else
                {
                    pivotTable.Fields[4].Items[0].Visible = false;
                }

            }
            if (ckbPageFilter.Checked)
            {
                //'Create Pivot Filter object to apply filter to page Fields
                IPivotFilter filterValue = pivotTable.Fields[2].PivotFilters.Add();
                //Page Field would be filtered with value 'East'
                filterValue.Value1 = "East";
                //XlsIO layout the Pivot table like MS Excel
                if (!rdbRCValueFilter.Checked)
                    pivotTable.Layout();
            }
            else if (ckbMultiplePageFilter.Checked)
            {
                pivotTable.Fields[2].Items[0].Visible = false;
            }
#endif
      
            #endregion

            #region Workbook Save
            //Saving the workbook to disk.
            worksheet.Range[1, 1, 1, 14].ColumnWidth = 11;
            worksheet.SetColumnWidth(1, 15.29);
            worksheet.SetColumnWidth(2, 15.29);
            workbook.SaveAs("CustomizedPivotTable.xlsx");
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
                    System.Diagnostics.Process.Start("CustomizedPivotTable.xlsx");
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
        #endregion

        private void PivotTable_Load(object sender, EventArgs e)
        {
            rdbRCLabelFilter.Checked = true;
            rdbRCLabelFilter.Enabled = false;
            rdbRCValueFilter.Enabled = false;
            multipleFilter.Enabled = false;
        }

        private void ckbPageFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPageFilter.Checked)
            {
                ckbMultiplePageFilter.Checked = false;
            }
        }

        private void ckbRowFieldFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbRowFieldFilter.Checked)
            {
                rdbRCLabelFilter.Enabled = true;
                rdbRCValueFilter.Enabled = true;
                multipleFilter.Enabled = true;
            }
            else if (!(ckbRowFieldFilter.Checked ))
            {
                if (!ckbColumnFieldFilter.Checked)
                {
                    rdbRCLabelFilter.Enabled = false;
                    rdbRCValueFilter.Enabled = false;
                    multipleFilter.Enabled = false;
                }
            }
        }

        private void ckbColumnFieldFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbColumnFieldFilter.Checked)
            {
                rdbRCLabelFilter.Enabled = true;
                rdbRCValueFilter.Enabled = true;
                multipleFilter.Enabled = true;
            }
            else if (!( ckbColumnFieldFilter.Checked ))
            {
                if (!ckbRowFieldFilter.Checked)
                {
                    rdbRCLabelFilter.Enabled = false;
                    rdbRCValueFilter.Enabled = false;
                    multipleFilter.Enabled = false;
                }
            }
        }

        private void ckbMultiplePageFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMultiplePageFilter.Checked)
            {
                ckbPageFilter.Checked = false;
            }
        }
    }
}