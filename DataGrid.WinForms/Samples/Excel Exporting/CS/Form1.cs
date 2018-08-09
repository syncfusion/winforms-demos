#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.XlsIO;
using System.IO;
using Syncfusion.WinForms.DataGridConverter;
using Syncfusion.WinForms.DataGridConverter.Events;

namespace ExcelExporting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sfDataGrid1.AutoGenerateColumns = false;
            ProductInfoRepository pro = new ProductInfoRepository();
            sfDataGrid1.DataSource = pro.ProductInfo;
            GridSettings();
            this.gridExportButton.Style.Border = Pens.Black;
            gridSelectedItemsExportButton.Style.Border = Pens.Black;
            this.gridExportButton.Click += GridExcelExportButton;
            this.gridSelectedItemsExportButton.Click += SelectedItemsExcelExportButton;
        }

        private void GridSettings()
        {
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "SupplierID", HeaderText = "Supplier ID" });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "ProductID", HeaderText = "Product ID" });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "ProductName", HeaderText = "Product Name" });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "QuantityPerUnit", HeaderText = "Quantity Per Unit" });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "UnitPrice", HeaderText = "Price" });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "UnitsInStock", HeaderText = "Units In Stock" });

            // Adding GroupColumnDescriptions
            sfDataGrid1.GroupColumnDescriptions.Add(new GroupColumnDescription() { ColumnName = "UnitsInStock" });
        }

        ExcelExportingOptions GridExcelExportingOptions = new ExcelExportingOptions();

        private ExcelExportingOptions ExcelExportingOptions1()
        {
            GridExcelExportingOptions.Exporting += GridExcelExportingOptions_Exporting1;
            GridExcelExportingOptions.CellExporting += GridExcelExportingOptions_CellExporting1;
            GridExcelExportingOptions.AllowOutlining = this.allowGroupOutlining.Checked;
            return GridExcelExportingOptions;
        }

        private void GridExcelExportingOptions_CellExporting1(object sender, DataGridCellExcelExportingEventArgs e)
        {
            e.Range.CellStyle.Font.Size = 12;
            e.Range.CellStyle.Font.FontName = "Segoe UI";

            if (e.CellType == ExportCellType.RecordCell)
            {
                if (e.ColumnName == "UnitPrice" || e.ColumnName == "UnitsInStock")
                {
                    double value = 0;
                    if (double.TryParse(e.CellValue.ToString(), out value))
                        e.Range.Number = value;
                    e.Handled = true;
                }
            }

            if (customStyleColumn.Checked && e.ColumnName == "ProductName")
            {
                e.Range.CellStyle.ColorIndex = ExcelKnownColors.Pale_blue;
            }

            if (customSelectedItemsStyle.Checked && e.CellType == ExportCellType.RecordCell)
            {
                e.Range.CellStyle.ColorIndex = ExcelKnownColors.Pale_blue;
            }
        }

        private void GridExcelExportingOptions_Exporting1(object sender, DataGridExcelExportingEventArgs e)
        {
            if (e.CellType == ExportCellType.HeaderCell)
            {
                e.CellStyle.FontInfo.Size = 12;
                e.CellStyle.FontInfo.FontName = "Segoe UI";
                e.CellStyle.BackGroundColor = Color.LightGray;
                e.CellStyle.ForeGroundColor = Color.Black;
                e.CellStyle.FontInfo.Bold = true;
                e.Handled = true;
            }
            else if (e.CellType == ExportCellType.GroupCaptionCell)
            {
                e.CellStyle.FontInfo.Size = 12;
                e.CellStyle.FontInfo.FontName = "Segoe UI";
                e.CellStyle.FontInfo.Bold = true;
                e.CellStyle.BackGroundColor = Color.LightSeaGreen;
                e.CellStyle.ForeGroundColor = Color.Black;
                e.Handled = true;
            }
        }

        /// <summary>
        /// Export the SelectedItems to Excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SelectedItemsExcelExportButton(object sender, System.EventArgs e)
        {
            if (sfDataGrid1.SelectedItems.Count > 0)
            {
                var excelEngine = sfDataGrid1.ExportToExcel(sfDataGrid1.SelectedItems, ExcelExportingOptions1());

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
        }

        /// <summary>
        /// Export SfDataGrid to Excel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GridExcelExportButton(object sender, System.EventArgs e)
        {
            var excelEngine = sfDataGrid1.ExportToExcel(sfDataGrid1.View, ExcelExportingOptions1());
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
    }
}
