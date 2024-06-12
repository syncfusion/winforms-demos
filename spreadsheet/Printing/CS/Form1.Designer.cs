#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Syncfusion.Windows.Forms.CellGrid;
using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.Windows.Forms.Spreadsheet.Helpers;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools.Win32API;
using Syncfusion.XlsIO;
using Syncfusion.ExcelToPdfConverter;
using Syncfusion.Pdf;
using System.Drawing.Imaging;
using Syncfusion.XlsIO.Implementation;
using Syncfusion.Windows.Forms.PdfViewer;

namespace PrintingDemo  
{
    partial class Form1 
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private Spreadsheet spreadsheet;
        private GroupBox export_groupbox;
        private ButtonAdv printbtn;
        private ButtonAdv printpreviewbtn;
        private System.Windows.Forms.Panel panel1;
       
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.WindowState = FormWindowState.Maximized;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.export_groupbox = new System.Windows.Forms.GroupBox();
            this.printbtn = new Syncfusion.Windows.Forms.ButtonAdv();
            this.printpreviewbtn = new Syncfusion.Windows.Forms.ButtonAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            this.spreadsheet = new Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet();
            this.export_groupbox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            #region Spreadsheet
            //
            //html checkbox
            //
            printbtn.Location = new Point((int)DpiAware.LogicalToDeviceUnits(15), 50);
            printbtn.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(150), 35);
            printbtn.Text = "Print";
            printbtn.Click += printbtn_Click;

            //
            //image checkbox
            //
            printpreviewbtn.Location = new Point((int)DpiAware.LogicalToDeviceUnits(15), 110);
            printpreviewbtn.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(150), 35);
            printpreviewbtn.Text = "Print Preview";
            printpreviewbtn.Click += printpreviewbtn_Click;
            // 
            // export_groupbox
            // 
            this.export_groupbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.export_groupbox.Controls.Add(this.printbtn);
            this.export_groupbox.Controls.Add(this.printpreviewbtn);
            this.export_groupbox.Font = new System.Drawing.Font(export_groupbox.Font, FontStyle.Bold);
            this.export_groupbox.Location = new System.Drawing.Point(670, 4);
            this.export_groupbox.Name = "export_groupbox";
            this.export_groupbox.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(180), 400);
            this.export_groupbox.TabIndex = 3;
            this.export_groupbox.TabStop = false;
            this.export_groupbox.Text = "Printing Options";
            // 
            // printbtn
            // 
            this.printbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printbtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.printbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.printbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbtn.ForeColor = System.Drawing.Color.White;
            //this.printbtn.Location = new System.Drawing.Point(50, 90);
            this.printbtn.Name = "printbtn";
            //this.printbtn.Size = new System.Drawing.Size(150, 35);
            this.printbtn.TabIndex = 5;
            this.printbtn.Text = "Print";
            // 
            // printpreviewbtn
            // 
            this.printpreviewbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printpreviewbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.printpreviewbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printpreviewbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printpreviewbtn.ForeColor = System.Drawing.Color.White;
            //this.printpreviewbtn.Location = new System.Drawing.Point(10, 100);
            this.printpreviewbtn.Name = "printpreviewbtn";
            //this.printpreviewbtn.Size = new System.Drawing.Size(150, 35);
            this.printpreviewbtn.TabIndex = 5;
            this.printpreviewbtn.Text = "Print Preview";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.spreadsheet);
            this.panel1.ForeColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 640);
            this.panel1.TabIndex = 4;
            // 
            // spreadsheet
            // 
            this.spreadsheet.AllowCellContextMenu = true;
            this.spreadsheet.AllowExtendRowColumnCount = true;
            this.spreadsheet.AllowFormulaRangeSelection = true;
            this.spreadsheet.AllowTabItemContextMenu = true;
            this.spreadsheet.AllowZooming = true;
            this.spreadsheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spreadsheet.DefaultColumnCount = 101;
            this.spreadsheet.DefaultRowCount = 101;
            this.spreadsheet.Location = new System.Drawing.Point(0, 0);
            this.spreadsheet.Name = "spreadsheet";
            this.spreadsheet.SelectedTabIndex = 0;
            this.spreadsheet.SelectedTabItem = null;
            this.spreadsheet.Size = new System.Drawing.Size(650, 640);
            this.spreadsheet.TabIndex = 0;
            this.spreadsheet.TabItemContextMenu = null;
#if !NETCORE
            spreadsheet.Open(@"..\..\..\..\..\Common\Data\Spreadsheet\Printing.xlsx");
#else
            spreadsheet.Open(@"..\..\..\..\..\..\Common\Data\Spreadsheet\Printing.xlsx");
#endif
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 656);
            this.Controls.Add(this.export_groupbox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Printing ";
            this.export_groupbox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

            #endregion
        }

        void printpreviewbtn_Click(object sender, EventArgs e)
        {
            PrintPreviewForm previewform = new PrintPreviewForm() { sfspreadsheet = this.spreadsheet };
            previewform.Show();
        }

        void printbtn_Click(object sender, EventArgs e)
        {
            PrintFromPdfViewer(this.spreadsheet);
        }



        #region Direct print through PdfViewer

        private static void PrintFromPdfViewer(Spreadsheet spreadsheetControl)
        {
            //Create the previewdialog for print the document.
            PrintPreviewDialog printdialog = new PrintPreviewDialog();

            //Create the pdfviewer for load the document.
            PdfViewerControl pdfviewer = new PdfViewerControl();

            // PdfDocumentViewer
            MemoryStream pdfstream = new MemoryStream();
            IWorksheet worksheet = spreadsheetControl.Workbook.Worksheets[0];
            worksheet.EnableSheetCalculations();
            worksheet.CalcEngine.UseFormulaValues = true;
            ExcelToPdfConverter converter = new ExcelToPdfConverter(spreadsheetControl.Workbook);
            //Intialize the PdfDocument
            PdfDocument pdfDoc = new PdfDocument();

            //Intialize the ExcelToPdfConverter Settings
            ExcelToPdfConverterSettings settings = new ExcelToPdfConverterSettings();
            settings.LayoutOptions = LayoutOptions.NoScaling;

            //Assign the PdfDocument to the templateDocument property of ExcelToPdfConverterSettings
            settings.TemplateDocument = pdfDoc;
            settings.DisplayGridLines = GridLinesDisplayStyle.Invisible;

            //Convert Excel Document into PDF document
            pdfDoc = converter.Convert(settings);

            //Save the PDF file
            pdfDoc.Save(pdfstream);

            //Load the document to pdfviewer
            pdfviewer.ReferencePath = @"..\..\..\..\..\..\Common\Data\PDF";

            pdfviewer.Load(pdfstream);

            printdialog.Document = pdfviewer.PrintDocument;

            printdialog.ShowDialog();           

        }
        #endregion
               
        #endregion

        #region "GetIconFile"
        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
        }
        #endregion
    }
}

