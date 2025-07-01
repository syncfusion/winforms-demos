#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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
using System.IO;
using Syncfusion.Pdf.Grid;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGridConverter;
using Syncfusion.WinForms.DataGridConverter.Events;

namespace PdfExporting
{
    public partial class Form1 : Form
    {
        PdfGridCellStyle cellstyle;
        public Form1()
        {
            InitializeComponent();
            ProductInfoRepository pro = new ProductInfoRepository();
            sfDataGrid1.DataSource = pro.ProductInfo;
            GridSettings();
            cellstyle = new PdfGridCellStyle();
            cellstyle.StringFormat = new PdfStringFormat() { Alignment = PdfTextAlignment.Right };
            var font = new Font("Segoe UI", 9f, System.Drawing.FontStyle.Regular);
            cellstyle.Font = new PdfTrueTypeFont(font, true);
            this.sfButton1.Click += new System.EventHandler(this.ExportDataGrid);
            this.sfButton2.Click += new System.EventHandler(this.ExportSelectedItems);
            this.sfButton1.Style.Border = Pens.Black;
            this.sfButton2.Style.Border = Pens.Black;
        }

        /// <summary>
        /// Grid Settings for better Look and Feel.
        /// </summary>    
        private void GridSettings()
        {
            this.sfDataGrid1.Columns.Add(new GridNumericColumn() { MappingName = "SupplierID", HeaderText = "Supplier ID", NumberFormatInfo = new System.Globalization.NumberFormatInfo() { NumberDecimalDigits = 0, NumberGroupSeparator = "" } });
            this.sfDataGrid1.Columns.Add(new GridNumericColumn() { MappingName = "ProductID", HeaderText = "Product ID", NumberFormatInfo = new System.Globalization.NumberFormatInfo() { NumberDecimalDigits = 0, NumberGroupSeparator = "" } });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "ProductName", HeaderText = "Product Name" });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "QuantityPerUnit", HeaderText = "Quantity Per Unit" });
            this.sfDataGrid1.Columns.Add(new GridNumericColumn() { MappingName = "UnitPrice", HeaderText = "Unit Price ", FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency });
            this.sfDataGrid1.Columns.Add(new GridNumericColumn() { MappingName = "UnitsInStock", HeaderText = "Units In Stock", NumberFormatInfo = new System.Globalization.NumberFormatInfo() { NumberDecimalDigits = 0, } });

            // Adding GroupColumnDescriptions
            sfDataGrid1.GroupColumnDescriptions.Add(new GroupColumnDescription() { ColumnName = "UnitsInStock" });

            //Add the GroupSummary TableSummaryRows true.
            this.sfDataGrid1.TableSummaryRows.Add(new GridTableSummaryRow()
            {
                Name = "tableSumamryTrue",
                ShowSummaryInRow = true,
                Title = "Total Price : {TotalSales}",
                SummaryColumns = new System.Collections.ObjectModel.ObservableCollection<Syncfusion.Data.ISummaryColumn>()
                {
                    new GridSummaryColumn()
                    {
                        Name = "TotalSales",
                        SummaryType = Syncfusion.Data.SummaryType.DoubleAggregate,
                        Format="{Sum:c}",
                        MappingName="UnitPrice",
                    },
                }
            });

            //Add the GroupSummary ShowInSumamryRow true.
            this.sfDataGrid1.GroupSummaryRows.Add(new GridSummaryRow()
            {
                Name = "groupSumamryTrue",
                ShowSummaryInRow = true,
                Title = "Total unit price in Year for {ProductCount} Products : {YearSales}",
                SummaryColumns = new System.Collections.ObjectModel.ObservableCollection<Syncfusion.Data.ISummaryColumn>()
                {
                    new GridSummaryColumn()
                    {
                        Name = "YearSales",
                        SummaryType = Syncfusion.Data.SummaryType.DoubleAggregate,
                        Format="{Sum:c}",
                        MappingName="UnitPrice",
                    },
                    new GridSummaryColumn()
                    {
                        Name = "ProductCount",
                        SummaryType = Syncfusion.Data.SummaryType.CountAggregate,
                        Format="{Count:d}",
                        MappingName="UnitPrice",
                    },
                }
            });
        }

        PdfExportingOptions ExportOptions = new PdfExportingOptions();
        private PdfExportingOptions GetPdfExportOption()
        {
            ExportOptions.AutoColumnWidth = this.autoColumnWidth.Checked;
            ExportOptions.AutoRowHeight = this.autoRowHeight.Checked;
            ExportOptions.ExportGroupSummary = this.exportGroupSummaries.Checked;
            ExportOptions.HeaderFooterExporting += ExportOptions_HeaderFooterExporting;
            ExportOptions.ExportTableSummary = this.exportTableSummaries.Checked;
            ExportOptions.RepeatHeaders = this.repeatHeaders.Checked;
            ExportOptions.FitAllColumnsInOnePage = this.fitAllColumnsInPage.Checked;
            ExportOptions.AutoRowHeight = this.autoRowHeight.Checked;
            ExportOptions.Exporting += ExportOptions_Exporting;
            ExportOptions.CellExporting += ExportOptions_CellExporting;
            return ExportOptions;
        }

        private void ExportOptions_CellExporting(object sender, DataGridCellPdfExportingEventArgs e)
        {
            if ((e.ColumnName == "OrderID" || e.ColumnName == "EmployeeID" || e.ColumnName == "OrderDate" || e.ColumnName == "Freight")
               && e.CellType == ExportCellType.RecordCell)
                e.PdfGridCell.Style = cellstyle;
            e.PdfGridCell.Style.Borders.All = new PdfPen(PdfBrushes.Black, 1.0f);
        }

        /// <summary>
        /// Customizied the PDF documnet while exporting DataGrid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportOptions_Exporting(object sender, DataGridPdfExportingEventArgs e)
        {
            if (e.CellType == ExportCellType.HeaderCell)
                e.CellStyle.BackgroundBrush = PdfBrushes.LightGray;
            else if (e.CellType == ExportCellType.GroupCaptionCell)
                e.CellStyle.BackgroundBrush = PdfBrushes.LightGray;
            else if (e.CellType == ExportCellType.GroupSummaryCell)
                e.CellStyle.BackgroundBrush = PdfBrushes.Azure;
            else if (e.CellType == ExportCellType.TableSummaryCell)
            {
                e.CellStyle.BackgroundBrush = PdfBrushes.LightSlateGray;
                e.CellStyle.TextBrush = PdfBrushes.White;
            }
        }

        private void ExportOptions_HeaderFooterExporting(object sender, PdfHeaderFooterEventArgs e)
        {
            var width = e.PdfPage.GetClientSize().Width;
            PdfPageTemplateElement header = new PdfPageTemplateElement(width, 38);
            header.Graphics.DrawImage(PdfImage.FromFile(@"..\..\Resources\Header.jpg"), 155, 5, width / 3f, 34);
            e.PdfDocumentTemplate.Top = header;
            PdfPageTemplateElement footer = new PdfPageTemplateElement(width, 30);
            footer.Graphics.DrawImage(PdfImage.FromFile(@"..\..\Resources\Footer.jpg"), 0, 0);
            e.PdfDocumentTemplate.Bottom = footer;
        }

        /// <summary>
        /// Export the DataGrid in to Pdf document.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ExportDataGrid(object sender, System.EventArgs e)
        {
            var document = sfDataGrid1.ExportToPdf(GetPdfExportOption());

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PDF Files(*.pdf)|*.pdf",
                FileName = "document1"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = sfd.OpenFile())
                    document.Save(stream);

                if (MessageBox.Show("Do you want to view the created Pdf file?", "Pdf has been created", MessageBoxButtons.OKCancel) == DialogResult.OK)
                     Open(sfd.FileName);
            }
        }
        private void Open(string fileName)
        {
#if !NETCORE
                System.Diagnostics.Process.Start(fileName);
#else
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "cmd",
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                UseShellExecute = false,
                CreateNoWindow = true,
                Arguments = "/c start " + fileName
            };
            System.Diagnostics.Process.Start(psi);
#endif
        }

        /// <summary>
        /// Export the SelectedItems of DataGrid in to Pdf document.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ExportSelectedItems(object sender, System.EventArgs e)
        {
            if (sfDataGrid1.SelectedItems.Count > 0)
            {
                var document = sfDataGrid1.ExportToPdf(sfDataGrid1.SelectedItems, GetPdfExportOption());

                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "PDF Files(*.pdf)|*.pdf",
                    FileName = "document1"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (Stream stream = sfd.OpenFile())
                        document.Save(stream);

                    if (MessageBox.Show("Do you want to view the created Pdf file?", "Pdf has been created", MessageBoxButtons.OKCancel) == DialogResult.OK)
                         Open(sfd.FileName);
                }
            }
            else
            {
                MessageBox.Show("No items has been selected");
            }
        }
    }
}
