using DemoCommon.Grid;
using Syncfusion.Pdf.Graphics;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGridConverter;
using Syncfusion.WinForms.DataGridConverter.Events;
using Syncfusion.WinForms.Input.Enums;
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

namespace DetailsViewPDFExporting
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
            firstLevelSourceDataGrid.Columns.Add(new GridNumericColumn() { MappingName = "UnitPrice", HeaderText = "Unit Price", NumberFormatInfo = nfi, FormatMode = FormatMode.Currency });
            firstLevelSourceDataGrid.Columns.Add(new GridNumericColumn() { MappingName = "Quantity", HeaderText = "Quantity", NumberFormatInfo = nfi });
            firstLevelSourceDataGrid.Columns.Add(new GridNumericColumn() { MappingName = "Discount", HeaderText = "Discount", NumberFormatInfo = nfi });
            firstLevelSourceDataGrid.Columns.Add(new GridTextColumn() { MappingName = "CustomerID", HeaderText = "Customer ID" });
            firstLevelSourceDataGrid.Columns.Add(new GridDateTimeColumn() { MappingName = "OrderDate", HeaderText = "Order Date" });
            viewDefinition.DataGrid = firstLevelSourceDataGrid;
            this.sfDataGrid1.DetailsViewDefinitions.Add(viewDefinition);
            #endregion

            this.sfDataGrid1.HideEmptyGridViewDefinition = true;

            this.exportWholeGrid.Checked = true;
        }

        /// <summary>
        /// Exports the SfDataGrid to PDF.
        /// </summary>
        private void ExportToPDF(object sender, EventArgs e)
        {
            PdfExportingOptions exportingOptions = new PdfExportingOptions();
            exportingOptions.ExportAllDetails = true;
            exportingOptions.ExportDetailsView = true;
            exportingOptions.Exporting += OnExporting;
            if (shouldCustomizeStyle.Checked)
                exportingOptions.CellExporting += OnCustomizedCellExporting;
            else
                exportingOptions.CellExporting += OnCellExporting;
            var document = sfDataGrid1.ExportToPdf(exportingOptions);
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PDF Files(*.pdf)|*.pdf",
                FileName = "Sample"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = sfd.OpenFile())
                {
                    document.Save(stream);
                }

                //Message box confirmation to view the created Pdf file.
                if (MessageBox.Show("Do you want to view the workbook?", "Workbook has been created", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                    System.Diagnostics.Process.Start(sfd.FileName);
                }
            }
        }

        /// <summary>
        /// Occurs when the PdfExportingOptions.CellExporting event occurs.
        /// </summary>
        /// <param name="sender">The PdfExportingOptions object.</param>
        /// <param name="e">The DataGridCellPdfExportingEventArgs that contains the event data.</param>
        private void OnCustomizedCellExporting(object sender, DataGridCellPdfExportingEventArgs e)
        {
            if (e.ColumnName == "Discount")
            {
                e.PdfGridCell.Style.BackgroundBrush = PdfBrushes.Violet;
            }
        }

        /// <summary>
        /// Occurs when the PdfExportingOptions.CellExporting event occurs.
        /// </summary>
        /// <param name="sender">The PdfExportingOptions object.</param>
        /// <param name="e">The DataGridCellPdfExportingEventArgs that contains the event data.</param>
        private void OnCellExporting(object sender, DataGridCellPdfExportingEventArgs e)
        {
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 12);
            e.PdfGridCell.Style.Font = font;
        }

        /// <summary>
        /// Exports the Selected rows of SfDataGrid to PDF.
        /// </summary>
        private void ExportSelectedItemToPdf(object sender, EventArgs e)
        {
            PdfExportingOptions exportingOptions = new PdfExportingOptions();
            exportingOptions.ExportDetailsView = true;
            exportingOptions.ExportAllDetails = true;
            exportingOptions.CellExporting += OnSelectedItemsCellExporting;
            if (shouldCustomizeSelectedItems.Checked)
                exportingOptions.Exporting += CustomizeSelectedItemsExporting;
            else
                exportingOptions.Exporting += OnExporting;
            var document = sfDataGrid1.ExportToPdf(sfDataGrid1.SelectedItems, exportingOptions);
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PDF Files(*.pdf)|*.pdf",
                FileName = "Sample"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = sfd.OpenFile())
                {
                    document.Save(stream);
                }

                //Message box confirmation to view the created Pdf file.
                if (MessageBox.Show("Do you want to view the workbook?", "Workbook has been created", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                    System.Diagnostics.Process.Start(sfd.FileName);
                }
            }
        }

        private void CustomizeSelectedItemsExporting(object sender, DataGridPdfExportingEventArgs e)
        {
            if (e.CellType == ExportCellType.RecordCell)
            {
                e.CellStyle.BackgroundBrush = PdfBrushes.Violet;
            }
        }

        /// <summary>
        /// Occurs when the PdfExportingOptions.CellExporting event occurs.
        /// </summary>
        /// <param name="sender">The PdfExportingOptions object.</param>
        /// <param name="e">The DataGridCellPdfExportingEventArgs that contains the event data.</param>
        private void OnSelectedItemsCellExporting(object sender, DataGridCellPdfExportingEventArgs e)
        {
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 12);
            e.PdfGridCell.Style.Font = font;
        }

        /// <summary>
        /// Occurs when the PdfExportingOptions.Exporting event occurs.
        /// </summary>
        /// <param name="sender">The PdfExportingOptions object.</param>
        /// <param name="e">The DataGridPdfExportingEventArgs that contains the event data.</param>
        private void OnExporting(object sender, DataGridPdfExportingEventArgs e)
        {
            if (e.CellType == ExportCellType.HeaderCell)
            {
                if (e.Level == 0)
                    e.CellStyle.BackgroundBrush = PdfBrushes.DarkBlue;
                else
                    e.CellStyle.BackgroundBrush = PdfBrushes.OrangeRed;
                PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 12);
                e.CellStyle.Font = font;
                e.CellStyle.TextBrush = PdfBrushes.White;
            }
        }

        private void exportWholeGrid_CheckedChanged(object sender, EventArgs e)
        {
            if (exportWholeGrid.Checked)
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

        private void exportToPDF_Click(object sender, EventArgs e)
        {
            if (exportWholeGrid.Checked)
                ExportToPDF(sender, e);
            else
                ExportSelectedItemToPdf(sender, e);
        }
    }
}
