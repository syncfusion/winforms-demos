#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.ExcelToPdfConverter;
using Syncfusion.Pdf;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.PdfViewer;
using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;
using System.IO;
using System.Timers;
namespace PrintingDemo
{
    partial class PrintPreviewForm
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.pdfDocumentView1 = new Syncfusion.Windows.Forms.PdfViewer.PdfDocumentView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGoToFirstPage = new System.Windows.Forms.ToolStripButton();
            this.btnGoToPreviousPage = new System.Windows.Forms.ToolStripButton();
            this.txtCurrentPageIndex = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblTotalPageCount = new System.Windows.Forms.ToolStripLabel();
            this.btnGoToNextPage = new System.Windows.Forms.ToolStripButton();
            this.btnGoToLastPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnZoomIn = new System.Windows.Forms.ToolStripButton();
            this.btnZoomOut = new System.Windows.Forms.ToolStripButton();
            this.cmbCurrentZoomLevel = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.FitPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.FitWidth = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();

            // 
            // pdfViewerControl1
            // 
            this.pdfDocumentView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfDocumentView1.Location = new System.Drawing.Point(0, 62);
            this.pdfDocumentView1.Name = "pdfDocumentView1";
            this.pdfDocumentView1.Size = new System.Drawing.Size(284, 200);
            this.pdfDocumentView1.TabIndex = 3;
            this.pdfDocumentView1.Text = "pdfDocumentView1";
            
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPrint,
            this.toolStripSeparator1,
            this.btnGoToFirstPage,
            this.btnGoToPreviousPage,
            this.txtCurrentPageIndex,
            this.toolStripLabel1,
            this.lblTotalPageCount,
            this.btnGoToNextPage,
            this.btnGoToLastPage,
            this.toolStripButton3,
            this.btnZoomIn,
            this.btnZoomOut,
            this.cmbCurrentZoomLevel,
            this.toolStripSeparator3,
            this.FitPage,
            this.toolStripSeparator5,
            this.FitWidth});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(633, (int)DpiAware.LogicalToDeviceUnits(25));
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
           
            // 
            // btnPrint
            // 
            this.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(23, (int)DpiAware.LogicalToDeviceUnits(22));
            this.btnPrint.Text = "Click to Print this PDF file or pages from it.";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);

            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, (int)DpiAware.LogicalToDeviceUnits(25));

            // 
            // btnGoToFirstPage
            // 
            this.btnGoToFirstPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGoToFirstPage.Image = ((System.Drawing.Image)(resources.GetObject("btnGoToFirstPage.Image")));
            this.btnGoToFirstPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoToFirstPage.Name = "btnGoToFirstPage";
            this.btnGoToFirstPage.Size = new System.Drawing.Size(23, (int)DpiAware.LogicalToDeviceUnits(22));
            this.btnGoToFirstPage.Text = "toolStripButton2";
            this.btnGoToFirstPage.ToolTipText = "Click to go to first page in the document.";
            this.btnGoToFirstPage.Click += new System.EventHandler(this.btnGoToFirstPage_Click);
            // 
            // btnGoToPreviousPage
            // 
            this.btnGoToPreviousPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGoToPreviousPage.Image = ((System.Drawing.Image)(resources.GetObject("btnGoToPreviousPage.Image")));
            this.btnGoToPreviousPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoToPreviousPage.Name = "btnGoToPreviousPage";
            this.btnGoToPreviousPage.Size = new System.Drawing.Size(23, (int)DpiAware.LogicalToDeviceUnits(22));
            this.btnGoToPreviousPage.Text = "toolStripButton3";
            this.btnGoToPreviousPage.ToolTipText = "Click to go to previous page in the document.";
            this.btnGoToPreviousPage.Click += new System.EventHandler(this.btnGoToPreviousPage_Click);

            // 
            // txtCurrentPageIndex
            // 
            this.txtCurrentPageIndex.Name = "txtCurrentPageIndex";
            this.txtCurrentPageIndex.Size = new System.Drawing.Size(30, (int)DpiAware.LogicalToDeviceUnits(25));
            this.txtCurrentPageIndex.Text = "1";
            this.txtCurrentPageIndex.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCurrentPageIndex.KeyDown += new System.Windows.Forms.KeyEventHandler(txtCurrentPageIndex_KeyDown);
            this.txtCurrentPageIndex.Click += new System.EventHandler(txtCurrentPageIndex_Click);

            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.toolStripLabel1.Size = new System.Drawing.Size(17, (int)DpiAware.LogicalToDeviceUnits(22));
            this.toolStripLabel1.Text = "/";

            // 
            // lblTotalPageCount
            // 
            this.lblTotalPageCount.Name = "lblTotalPageCount";
            this.lblTotalPageCount.Size = new System.Drawing.Size(25, (int)DpiAware.LogicalToDeviceUnits(22));
            this.lblTotalPageCount.Text = "100";

            // 
            // btnGoToNextPage
            // 
            this.btnGoToNextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGoToNextPage.Image = ((System.Drawing.Image)(resources.GetObject("btnGoToNextPage.Image")));
            this.btnGoToNextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoToNextPage.Name = "btnGoToNextPage";
            this.btnGoToNextPage.Size = new System.Drawing.Size(23, (int)DpiAware.LogicalToDeviceUnits(22));
            this.btnGoToNextPage.Text = "toolStripButton4";
            this.btnGoToNextPage.ToolTipText = "Click to go to next page in the document.";
            this.btnGoToNextPage.Click += new System.EventHandler(this.btnGoToNextPage_Click);

            // 
            // btnGoToLastPage
            // 
            this.btnGoToLastPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGoToLastPage.Image = ((System.Drawing.Image)(resources.GetObject("btnGoToLastPage.Image")));
            this.btnGoToLastPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoToLastPage.Name = "btnGoToLastPage";
            this.btnGoToLastPage.Size = new System.Drawing.Size(23, (int)DpiAware.LogicalToDeviceUnits(22));
            this.btnGoToLastPage.Text = "toolStripButton5";
            this.btnGoToLastPage.ToolTipText = "Click to go to last page in the document.";
            this.btnGoToLastPage.Click += new System.EventHandler(this.btnGoToLastPage_Click);

            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(6, 25);

            // 
            // btnZoomIn
            // 
            this.btnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomIn.Image")));
            this.btnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(23, (int)DpiAware.LogicalToDeviceUnits(22));
            this.btnZoomIn.Text = "toolStripButton4";
            this.btnZoomIn.ToolTipText = "Click to decrease the magnification of the entire page.";
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);

            // 
            // btnZoomOut
            // 
            this.btnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomOut.Image")));
            this.btnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(23, (int)DpiAware.LogicalToDeviceUnits(22));
            this.btnZoomOut.ToolTipText = "Click to increase the magnification of the entire page.";
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);

            // 
            // cmbCurrentZoomLevel
            // 
            this.cmbCurrentZoomLevel.Items.AddRange(new object[] {
            "50%",
            "75%",
            "100%",
            "125%",
            "150%",
            "200%",
            "400%"});
            this.cmbCurrentZoomLevel.Name = "cmbCurrentZoomLevel";
            this.cmbCurrentZoomLevel.Size = new System.Drawing.Size(75, (int)DpiAware.LogicalToDeviceUnits(25));
            this.cmbCurrentZoomLevel.Text = "100%";
            this.cmbCurrentZoomLevel.SelectedIndexChanged += new System.EventHandler(this.cmbCurrentZoomLevel_SelectedIndexChanged);

            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, (int)DpiAware.LogicalToDeviceUnits(25));

            // 
            // FitPage
            // 
            this.FitPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FitPage.Image = ((System.Drawing.Image)(resources.GetObject("FitPage.Image")));
            this.FitPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FitPage.Name = "FitPage";
            this.FitPage.Size = new System.Drawing.Size(23, (int)DpiAware.LogicalToDeviceUnits(22));
            this.FitPage.Text = "Fit Page";
            this.FitPage.Click += new System.EventHandler(this.FitPage_Click);

            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, (int)DpiAware.LogicalToDeviceUnits(25));

            // 
            // FitWidth
            // 
            this.FitWidth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FitWidth.Image = ((System.Drawing.Image)(resources.GetObject("FitWidth.Image")));
            this.FitWidth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FitWidth.Name = "FitWidth";
            this.FitWidth.Size = new System.Drawing.Size(23, (int)DpiAware.LogicalToDeviceUnits(22));
            this.FitWidth.Text = "Fit Width";
            this.FitWidth.Click += new System.EventHandler(this.FitWidth_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.pdfDocumentView1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Print Preview Dialog";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ShowIcon = false;
            this.Load += PrintPreviewForm_Load;
            this.Load += new System.EventHandler(this.PrintPreviewForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       private void LoadDocumentToPdfViewer()
        {

            //Create Memory Stream to save pdfdocument.
            MemoryStream pdfstream = new MemoryStream();
            IWorksheet worksheet = this.sfspreadsheet.Workbook.Worksheets[0];
            worksheet.EnableSheetCalculations();
            worksheet.CalcEngine.UseFormulaValues = true;
            ExcelToPdfConverter converter = new ExcelToPdfConverter(this.sfspreadsheet.Workbook);
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
            pdfDocumentView1.ReferencePath = @"..\..\..\..\..\..\Common\Data\PDF";

            //Load the pdfstream to pdfDocumentView
            pdfDocumentView1.Load(pdfstream);


            lblTotalPageCount.Text = pdfDocumentView1.PageCount.ToString();
            EnablePagination();
            pageTimer.Tick += pageTimer_Tick;
            pageTimer.Start();

        }

        #endregion
        private System.Windows.Forms.ToolTip Tooltip;
        private Syncfusion.Windows.Forms.PdfViewer.PdfDocumentView pdfDocumentView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnGoToFirstPage;
        private System.Windows.Forms.ToolStripButton btnGoToPreviousPage;
        private System.Windows.Forms.ToolStripTextBox txtCurrentPageIndex;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel lblTotalPageCount;
        private System.Windows.Forms.ToolStripButton btnGoToNextPage;
        private System.Windows.Forms.ToolStripButton btnGoToLastPage;
        private System.Windows.Forms.ToolStripComboBox cmbCurrentZoomLevel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripButton3;
        private System.Windows.Forms.ToolStripButton btnZoomIn;
        private System.Windows.Forms.ToolStripButton btnZoomOut;
        private System.Windows.Forms.ToolStripButton FitPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton FitWidth;
        internal Spreadsheet sfspreadsheet;
    }
}