using DemoCommon.Grid;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGridConverter;
using Syncfusion.WinForms.DataGridConverter.Events;
using Syncfusion.WinForms.Input.Enums;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetailsViewExcelExporting
{
    public partial class Form1 : GridDemoForm
    {
        public Form1()
        {
            InitializeComponent();
            SampleCustomization();
        }

        /// <summary>
        /// Sets the sample customization settings.
        /// </summary>
        private void SampleCustomization()
        {
            this.sfDataGrid1.AllowEditing = true;
            this.sfDataGrid1.AllowGrouping = true;
            this.sfDataGrid1.ShowGroupDropArea = true;
            this.sfDataGrid1.AutoGenerateColumns = false;
            this.sfDataGrid1.AllowResizingColumns = true;
            this.sfDataGrid1.SelectionMode = GridSelectionMode.Multiple;
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalDigits = 0;
            nfi.NumberGroupSizes = new int[] { };

            OrderInfoRepository orderInfo = new OrderInfoRepository();
            this.sfDataGrid1.DataSource = orderInfo.GetOrdersDetails(30);
            this.sfDataGrid1.Columns.Add(new GridNumericColumn() { MappingName = "OrderID", HeaderText = "Order ID", NumberFormatInfo = nfi });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "CustomerID", HeaderText = "Customer ID" });
            this.sfDataGrid1.Columns.Add(new GridDateTimeColumn() { MappingName = "ShippingDate", HeaderText = "Shipping Date" });
            this.sfDataGrid1.Columns.Add(new GridNumericColumn() { MappingName = "EmployeeID", HeaderText = "Employee ID", NumberFormatInfo = nfi });

            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "ShipCity", HeaderText = "Ship City" });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "ShipCountry", HeaderText = "Ship Country" });
            this.sfDataGrid1.Columns.Add(new GridNumericColumn() { MappingName = "Freight", HeaderText = "Freight", FormatMode = FormatMode.Currency });
            this.sfDataGrid1.Columns.Add(new GridCheckBoxColumn() { MappingName = "IsClosed", HeaderText = "Is Closed" });

            #region Relation Creation
            GridViewDefinition viewDefinition = new GridViewDefinition();
            viewDefinition.RelationalColumn = "OrderDetails";
            SfDataGrid firstLevelSourceDataGrid = new SfDataGrid();
            firstLevelSourceDataGrid.AutoGenerateColumns = false;
            firstLevelSourceDataGrid.Columns.Add(new GridNumericColumn() { MappingName = "OrderID", HeaderText = "Order ID", NumberFormatInfo = nfi });
            firstLevelSourceDataGrid.Columns.Add(new GridNumericColumn() { MappingName = "ProductID", HeaderText = "Product ID", NumberFormatInfo = nfi });
            firstLevelSourceDataGrid.Columns.Add(new GridNumericColumn() { MappingName = "UnitPrice", HeaderText = "Unit Price", FormatMode = FormatMode.Currency });
            firstLevelSourceDataGrid.Columns.Add(new GridNumericColumn() { MappingName = "Quantity", HeaderText = "Quantity", NumberFormatInfo = nfi });
            firstLevelSourceDataGrid.Columns.Add(new GridNumericColumn() { MappingName = "Discount", HeaderText = "Discount", NumberFormatInfo = nfi });
            firstLevelSourceDataGrid.Columns.Add(new GridTextColumn() { MappingName = "CustomerID", HeaderText = "Customer ID" });
            firstLevelSourceDataGrid.Columns.Add(new GridDateTimeColumn() { MappingName = "OrderDate", HeaderText = "Order Date" });
            viewDefinition.DataGrid = firstLevelSourceDataGrid;
            this.sfDataGrid1.DetailsViewDefinitions.Add(viewDefinition);
            #endregion

            this.sfDataGrid1.HideEmptyGridViewDefinition = true;

            this.exportAllRecords.Checked = true;
        }

        /// <summary>
        /// Exports the SfDataGrid to Excel.
        /// </summary>
        private void ExportAllRecordsToExcel(object sender, EventArgs e)
        {
            ExcelExportingOptions exportingOptions = new ExcelExportingOptions();
            exportingOptions.ExcelVersion = ExcelVersion.Excel2016;
            exportingOptions.Exporting += OnExporting;
            if (shouldCustomizeStyle.Checked)
                exportingOptions.CellExporting += OnCustomizedCellExporting;
            else
                exportingOptions.CellExporting += OnCellExporting;
            var excelEngine = sfDataGrid1.ExportToExcel(sfDataGrid1.View, exportingOptions);
            var workBook = excelEngine.Excel.Workbooks[0];
            SaveFileDialog sfd = new SaveFileDialog
            {
                FilterIndex = 2,
                Filter = "Excel 97 to 2003 Files(*.xls)|*.xls|Excel 2007 to 2010 Files(*.xlsx)|*.xlsx",
                FileName = "Book1"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = sfd.OpenFile())
                {
                    if (sfd.FilterIndex == 1)
                        workBook.Version = ExcelVersion.Excel97to2003;
                    else
                        workBook.Version = ExcelVersion.Excel2010;
                    workBook.SaveAs(stream);
                }

                //Message box confirmation to view the created spreadsheet.
                if (MessageBox.Show("Do you want to view the workbook?", "Workbook has been created", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                    System.Diagnostics.Process.Start(sfd.FileName);
                }
            }
        }

        /// <summary>
        /// Occurs when the ExcelExportingOptions.CellExporting event occurs.
        /// </summary>
        /// <param name="sender">The ExcelExportingOptions object.</param>
        /// <param name="e">The DataGridCellExcelExportingEventArgs that contains the event data.</param>
        private void OnCustomizedCellExporting(object sender, DataGridCellExcelExportingEventArgs e)
        {
            if (e.ColumnName == "Discount")
            {
                e.Range.CellStyle.ColorIndex = ExcelKnownColors.Violet;
            }
        }

        /// <summary>
        /// Occurs when the ExcelExportingOptions.CellExporting event occurs.
        /// </summary>
        /// <param name="sender">The ExcelExportingOptions object.</param>
        /// <param name="e">The DataGridCellExcelExportingEventArgs that contains the event data.</param>
        private void OnCellExporting(object sender, DataGridCellExcelExportingEventArgs e)
        {
            e.Range.CellStyle.Font.Size = 12;
            e.Range.CellStyle.Font.FontName = "Segoe UI";
        }

        /// <summary>
        /// Occurs when the ExcelExportingOptions.Exporting event occurs.
        /// </summary>
        /// <param name="sender">The ExcelExportingOptions object.</param>
        /// <param name="e">The DataGridExcelExportingEventArgs that contains the event data.</param>
        private void OnExporting(object sender, DataGridExcelExportingEventArgs e)
        {
            if (e.CellType == ExportCellType.HeaderCell)
            {
                if (e.Level == 0)
                    e.CellStyle.BackGroundColor = Color.FromArgb(255, 155, 194, 230);
                else
                    e.CellStyle.BackGroundColor = Color.FromArgb(255, 146, 208, 80);

                e.CellStyle.ForeGroundColor = Color.White;
                e.CellStyle.FontInfo.Bold = true;
                e.Handled = true;
            }
        }

        /// <summary>
        /// Exports the Selected rows of SfDataGrid to Excel.
        /// </summary>
        private void ExportSelectedRecordsToExcel(object sender, EventArgs e)
        {
            ExcelExportingOptions exportingOptions = new ExcelExportingOptions();

            exportingOptions.CellExporting += OnSelectedItemsCellExporting;
            if (shouldCustomizeSelectedItems.Checked)
                exportingOptions.Exporting += CustomizeSelectedItemsExporting;
            else
                exportingOptions.Exporting += OnExporting;

            var excelEngine = sfDataGrid1.ExportToExcel(sfDataGrid1.SelectedItems, exportingOptions);
            var workBook = excelEngine.Excel.Workbooks[0];
            SaveFileDialog sfd = new SaveFileDialog
            {
                FilterIndex = 2,
                Filter = "Excel 97 to 2003 Files(*.xls)|*.xls|Excel 2007 to 2010 Files(*.xlsx)|*.xlsx",
                FileName = "Book1"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = sfd.OpenFile())
                {
                    if (sfd.FilterIndex == 1)
                        workBook.Version = ExcelVersion.Excel97to2003;
                    else
                        workBook.Version = ExcelVersion.Excel2010;
                    workBook.SaveAs(stream);
                }

                //Message box confirmation to view the created spreadsheet.
                if (MessageBox.Show("Do you want to view the workbook?", "Workbook has been created", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                    System.Diagnostics.Process.Start(sfd.FileName);
                }
            }
        }

        private void CustomizeSelectedItemsExporting(object sender, DataGridExcelExportingEventArgs e)
        {
            if (e.CellType == ExportCellType.RecordCell)
            {
                e.CellStyle.BackGroundColor = Color.Violet;
                e.Handled = true;
            }
        }

        /// <summary>
        /// Occurs when the ExcelExportingOptions.CellExporting event occurs.
        /// </summary>
        /// <param name="sender">The ExcelExportingOptions object.</param>
        /// <param name="e">The DataGridCellExcelExportingEventArgs that contains the event data.</param>
        private void OnSelectedItemsCellExporting(object sender, DataGridCellExcelExportingEventArgs e)
        {
            e.Range.CellStyle.Font.Size = 12;
            e.Range.CellStyle.Font.FontName = "Segoe UI";
        }

        private void exportAllRecords_CheckedChanged(object sender, EventArgs e)
        {
            if (exportAllRecords.Checked)
            {
                shouldCustomizeStyle.Enabled = true;
                label3.Enabled = true;
                shouldCustomizeSelectedItems.Enabled = false;
                label4.Enabled = false;
            }
        }

        private void exportSelectedRecords_CheckedChanged(object sender, EventArgs e)
        {
            if (exportSelectedRecords.Checked)
            {
                shouldCustomizeStyle.Enabled = false;
                label3.Enabled = false;
                shouldCustomizeSelectedItems.Enabled = true;
                label4.Enabled = true;
            }
        }

        private void exportToExcel_Click(object sender, EventArgs e)
        {
            if (exportAllRecords.Checked)
                ExportAllRecordsToExcel(sender, e);
            else
                ExportSelectedRecordsToExcel(sender, e);
        }
    }
}
