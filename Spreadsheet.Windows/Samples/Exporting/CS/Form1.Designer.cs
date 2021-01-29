#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
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

namespace ExportingDemo
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
        private RadioButton htmlradiobtn;
        private RadioButton imageradiobtn;
        private RadioButton pdfradiobtn;
        private Button exportbtn;
        private System.Windows.Forms.Panel panel1;
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.WindowState = FormWindowState.Maximized;
            export_groupbox = new GroupBox();
            htmlradiobtn = new RadioButton();
            imageradiobtn = new RadioButton();
            pdfradiobtn = new RadioButton();
            exportbtn = new Button();
            spreadsheet = new Spreadsheet();
            this.panel1 = new System.Windows.Forms.Panel();
        
            this.export_groupbox.SuspendLayout();
            this.SuspendLayout();
            this.panel1.SuspendLayout();
            #region Spreadsheet
            this.spreadsheet.AllowCellContextMenu = true;
            this.spreadsheet.AllowExtendRowColumnCount = true;
            this.spreadsheet.AllowFormulaRangeSelection = true;
            this.spreadsheet.AllowTabItemContextMenu = true;
            this.spreadsheet.AllowZooming = true;
            spreadsheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                       | System.Windows.Forms.AnchorStyles.Left)
                       | System.Windows.Forms.AnchorStyles.Right)));
            this.spreadsheet.DefaultColumnCount = 101;
            this.spreadsheet.DefaultRowCount = 101;
            spreadsheet.Location = new System.Drawing.Point(0, 0);
            spreadsheet.Size = new System.Drawing.Size(572, 376);
            spreadsheet.FormulaBarVisibility = false;
            spreadsheet.TabIndex = 0;
#if !NETCORE
            spreadsheet.Open(@"..\..\..\..\..\..\Common\Data\Spreadsheet\Export.xlsx");
#else
            spreadsheet.Open(@"..\..\..\..\..\..\..\Common\Data\Spreadsheet\Export.xlsx");
#endif


            //
            //html checkbox
            //
            htmlradiobtn.Location = new Point(10, 35);
            htmlradiobtn.Size = new System.Drawing.Size(150, 35);
            htmlradiobtn.Text = "Export to HTML";

            //
            //image checkbox
            //
            imageradiobtn.Location = new Point(10, 70);
            imageradiobtn.Size = new System.Drawing.Size(150, 35);
            imageradiobtn.Text = "Export to Image";

            //
            //pdf checkbox
            pdfradiobtn.Location = new Point(10, 105);
            pdfradiobtn.Size = new System.Drawing.Size(150, 35);
            pdfradiobtn.Text = "Export to PDF";

            //
            //Export button
            //
            this.exportbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exportbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.exportbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportbtn.ForeColor = System.Drawing.Color.White;
            exportbtn.Location = new Point(50, 140);
            exportbtn.Size = new System.Drawing.Size(100, 35);
            exportbtn.Text = "Export";
            exportbtn.Click += exportbtn_Click;

            // 
            // groupBox1
            // 
            export_groupbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                   | System.Windows.Forms.AnchorStyles.Right)));
            export_groupbox.Controls.Add(htmlradiobtn);
            export_groupbox.Controls.Add(imageradiobtn);
            export_groupbox.Controls.Add(pdfradiobtn);
            export_groupbox.Controls.Add(exportbtn);
            export_groupbox.Location = new System.Drawing.Point(595, 1);
            export_groupbox.Size = new System.Drawing.Size(180, 360);
            export_groupbox.TabIndex = 3;
            export_groupbox.Font = new System.Drawing.Font(export_groupbox.Font, FontStyle.Bold);
            export_groupbox.TabStop = false;
            export_groupbox.Text = "Export Options";
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
            this.panel1.Size = new System.Drawing.Size(572, 376);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            ClientSize = new System.Drawing.Size(793, 403);
            Controls.Add(export_groupbox);
            Controls.Add(panel1);
            MinimumSize = new System.Drawing.Size(600, 350);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Exporting";
            this.panel1.ResumeLayout(false);
            this.export_groupbox.ResumeLayout(false);
            this.ResumeLayout(false);

            #endregion
        }

        /// <summary>
        /// Export the spreadsheet based on the selected options.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void exportbtn_Click(object sender, EventArgs e)
        {
            if (pdfradiobtn.Checked)
                ExportToPDF(this.spreadsheet);
            else if (htmlradiobtn.Checked)
                ExportWorkBookToHTML(this.spreadsheet);
            else if (imageradiobtn.Checked)
                ExportWorksheetToBitmap(this.spreadsheet);
        }

        #region PDF
        private static void ExportToPDF(Spreadsheet spreadsheetControl)
        {

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
            pdfDoc.Save("Sample.pdf");

            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo("Sample.pdf");
            info.UseShellExecute = true;
            System.Diagnostics.Process.Start(info);

        }
        #endregion

        #region Image

        private static void ExportWorksheetToBitmap(Spreadsheet spreadsheetControl)
        {

            IWorksheet sheet = spreadsheetControl.Workbook.ActiveSheet;
            sheet.UsedRangeIncludesFormatting = false;
            int lastRow = sheet.UsedRange.LastRow + 1;
            int lastColumn = sheet.UsedRange.LastColumn + 1;
            System.Drawing.Image img = sheet.ConvertToImage(1, 1, lastRow, lastColumn, ImageType.Bitmap, null);
            img.Save("Sample.png", ImageFormat.Png);
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo("Sample.png");
            info.UseShellExecute = true;
            System.Diagnostics.Process.Start(info);

        }

        #endregion

        #region HTML

        private static void ExportWorkBookToHTML(Spreadsheet spreadsheetControl)
        {
            spreadsheetControl.Workbook.SaveAsHtml("Sample.html", HtmlSaveOptions.Default);
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo("Sample.html");
            info.UseShellExecute = true;
            System.Diagnostics.Process.Start(info);
        }
        #endregion

        #endregion
    }
}

