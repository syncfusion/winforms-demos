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
using System.IO;
using Syncfusion.Pdf.Grid;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGridConverter;
using Syncfusion.WinForms.DataGridConverter.Events;
using Syncfusion.Windows.Forms.PdfViewer;
using System.Drawing.Printing;

namespace Printing
{
    public partial class Form1 : Form
    {
        PdfGridCellStyle cellstyle;
        PdfViewerControl pdfviewer = new PdfViewerControl();
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
            this.sfButton2.Click += new System.EventHandler(this.PrintButton_Click);
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
        }

        void PrintButton_Click(object sender, System.EventArgs e)
        {
            PdfDocumentView pdfDocumentView1 = new PdfDocumentView();

            //Create Memory Stream to save pdfdocument.
            MemoryStream pdfstream = new MemoryStream();

            PdfDocument pdfDoc = new PdfDocument();
            pdfDoc = sfDataGrid1.ExportToPdf();

            //Save the PDF file
            pdfDoc.Save(pdfstream);

            //Load the pdfstream to pdfDocumentView
            pdfDocumentView1.Load(pdfstream);

            PrintDialog printdialog = new PrintDialog();
            int pageCount = pdfDocumentView1.PageCount;
            printdialog.AllowPrintToFile = true;
            printdialog.AllowSomePages = true;
            printdialog.PrinterSettings.FromPage = 1;
            printdialog.PrinterSettings.ToPage = pageCount;
            printdialog.PrinterSettings.MaximumPage = pageCount;
            printdialog.PrinterSettings.MinimumPage = 1;

            if (printdialog.ShowDialog() == DialogResult.OK)
            {
                printdialog.Document = pdfDocumentView1.PrintDocument;
                printdialog.Document.Print();
            }
        }

        private void sfButton1_Click(object sender, EventArgs e)
        {
            PrintPreviewForm previewform = new PrintPreviewForm() { dataGrid = this.sfDataGrid1 };
            previewform.Show();
        }

        private void Document_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (e.PrintAction == PrintAction.PrintToPrinter)
            {
                sender = pdfviewer.PrintDocument;
            }
        }
    }
}
