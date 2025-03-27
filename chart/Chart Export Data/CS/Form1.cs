#region Copyright Syncfusion Inc. 2001 - 2019
//
//  Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Syncfusion.Windows.Forms.Chart;
using Syncfusion.XlsIO;
using Syncfusion.Pdf;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Drawing;
using Syncfusion.Pdf.Graphics;

namespace ChartExportData
{
	
	public class Form1 : Syncfusion.Windows.Forms.MetroForm
    {
        #region Private Members
        public Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
		private string fileName;
		private string exportFileName = null;
        private Form2 gridForm;
        private Syncfusion.Windows.Forms.ButtonAdv buttonDocIO;
        private Syncfusion.Windows.Forms.ButtonAdv buttonPdf;
        private Syncfusion.Windows.Forms.ButtonAdv buttonXLsIO;
        private Syncfusion.Windows.Forms.ButtonAdv buttonImage;
        private Syncfusion.Windows.Forms.ButtonAdv buttonSVG;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv2;
        private Syncfusion.Windows.Forms.ButtonAdv buttonGrid;
        private Syncfusion.Windows.Forms.ButtonAdv buttonPrint;
        private ToolTip toolTip1;
        private Panel panel1;
        private Syncfusion.Windows.Forms.ButtonAdv buttonEmf;
        private Label label1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private StatusStrip statusStrip1;
        private IContainer components;
        #endregion

        #region Form's Constructor, Main and Dispose
        public Form1()
		{
			InitializeComponent();
            BorderColor = Color.FromArgb(0xFF, 0xCD, 0xCD, 0xCD);
            BorderThickness = 3;
            CaptionBarHeight = 75;
            CaptionBarColor = Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2);
            CaptionFont = new Font("Segow UI", 22.0f);
            CaptionForeColor = Color.White;
            CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            ShowIcon = false;
            CaptionButtonColor = Color.White;
            CaptionButtonHoverColor = Color.White;
		}
        /// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.Run(new Form1());
		}
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
        }
         #endregion    

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.buttonDocIO = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonPdf = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonXLsIO = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonImage = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonSVG = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonGrid = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonPrint = new Syncfusion.Windows.Forms.ButtonAdv();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEmf = new Syncfusion.Windows.Forms.ButtonAdv();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.ChartArea.BorderWidth = 2;
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10);
            this.chartControl1.DataSourceName = "";
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(59, 501);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom;
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.Size = new System.Drawing.Size(700, 579);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "chartControl1";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ChartFormatAxisLabel += new Syncfusion.Windows.Forms.Chart.ChartFormatAxisLabelEventHandler(this.chartControl1_ChartFormatAxisLabel);
            // 
            // buttonDocIO
            // 
            this.buttonDocIO.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonDocIO.BackColor = System.Drawing.Color.White;
            this.buttonDocIO.BeforeTouchSize = new System.Drawing.Size(75, 75);
            this.buttonDocIO.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDocIO.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonDocIO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonDocIO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonDocIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDocIO.Image = ((System.Drawing.Image)(resources.GetObject("buttonDocIO.Image")));
            this.buttonDocIO.IsBackStageButton = false;
            this.buttonDocIO.KeepFocusRectangle = false;
            this.buttonDocIO.Location = new System.Drawing.Point(142, 163);
            this.buttonDocIO.Name = "buttonDocIO";
            this.buttonDocIO.Size = new System.Drawing.Size(75, 75);
            this.buttonDocIO.TabIndex = 4;
            this.buttonDocIO.Tag = "Check";
            this.buttonDocIO.UseVisualStyle = false;
            this.buttonDocIO.Click += new System.EventHandler(this.buttonDocIO_Click);
            // 
            // buttonPdf
            // 
            this.buttonPdf.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonPdf.BackColor = System.Drawing.Color.White;
            this.buttonPdf.BeforeTouchSize = new System.Drawing.Size(75, 75);
            this.buttonPdf.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPdf.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonPdf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonPdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPdf.Image = ((System.Drawing.Image)(resources.GetObject("buttonPdf.Image")));
            this.buttonPdf.IsBackStageButton = false;
            this.buttonPdf.KeepFocusRectangle = false;
            this.buttonPdf.Location = new System.Drawing.Point(142, 255);
            this.buttonPdf.Name = "buttonPdf";
            this.buttonPdf.Size = new System.Drawing.Size(75, 75);
            this.buttonPdf.TabIndex = 5;
            this.buttonPdf.Tag = "Check";
            this.buttonPdf.UseVisualStyle = false;
            this.buttonPdf.Click += new System.EventHandler(this.buttonPdf_Click);
            // 
            // buttonXLsIO
            // 
            this.buttonXLsIO.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonXLsIO.BackColor = System.Drawing.Color.White;
            this.buttonXLsIO.BeforeTouchSize = new System.Drawing.Size(75, 75);
            this.buttonXLsIO.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonXLsIO.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonXLsIO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonXLsIO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonXLsIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXLsIO.Image = ((System.Drawing.Image)(resources.GetObject("buttonXLsIO.Image")));
            this.buttonXLsIO.IsBackStageButton = false;
            this.buttonXLsIO.KeepFocusRectangle = false;
            this.buttonXLsIO.Location = new System.Drawing.Point(46, 255);
            this.buttonXLsIO.Name = "buttonXLsIO";
            this.buttonXLsIO.Size = new System.Drawing.Size(75, 75);
            this.buttonXLsIO.TabIndex = 6;
            this.buttonXLsIO.Tag = "Check";
            this.buttonXLsIO.UseVisualStyle = false;
            this.buttonXLsIO.Click += new System.EventHandler(this.buttonXLsIO_Click);
            // 
            // buttonImage
            // 
            this.buttonImage.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonImage.BackColor = System.Drawing.Color.White;
            this.buttonImage.BeforeTouchSize = new System.Drawing.Size(75, 75);
            this.buttonImage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonImage.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImage.Image = ((System.Drawing.Image)(resources.GetObject("buttonImage.Image")));
            this.buttonImage.IsBackStageButton = false;
            this.buttonImage.KeepFocusRectangle = false;
            this.buttonImage.Location = new System.Drawing.Point(142, 72);
            this.buttonImage.Name = "buttonImage";
            this.buttonImage.Size = new System.Drawing.Size(75, 75);
            this.buttonImage.TabIndex = 7;
            this.buttonImage.UseVisualStyle = false;
            this.buttonImage.Click += new System.EventHandler(this.buttonImage_Click);
            // 
            // buttonSVG
            // 
            this.buttonSVG.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonSVG.BackColor = System.Drawing.Color.White;
            this.buttonSVG.BeforeTouchSize = new System.Drawing.Size(75, 75);
            this.buttonSVG.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSVG.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonSVG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonSVG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonSVG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSVG.Image = ((System.Drawing.Image)(resources.GetObject("buttonSVG.Image")));
            this.buttonSVG.IsBackStageButton = false;
            this.buttonSVG.KeepFocusRectangle = false;
            this.buttonSVG.Location = new System.Drawing.Point(46, 163);
            this.buttonSVG.Name = "buttonSVG";
            this.buttonSVG.Size = new System.Drawing.Size(75, 75);
            this.buttonSVG.TabIndex = 8;
            this.buttonSVG.UseVisualStyle = false;
            this.buttonSVG.Click += new System.EventHandler(this.buttonSVG_Click);
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv2.BackColor = System.Drawing.Color.White;
            this.buttonAdv2.BeforeTouchSize = new System.Drawing.Size(75, 75);
            this.buttonAdv2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAdv2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonAdv2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonAdv2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonAdv2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdv2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv2.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdv2.Image")));
            this.buttonAdv2.IsBackStageButton = false;
            this.buttonAdv2.KeepFocusRectangle = false;
            this.buttonAdv2.Location = new System.Drawing.Point(46, 345);
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Size = new System.Drawing.Size(75, 75);
            this.buttonAdv2.TabIndex = 15;
            this.buttonAdv2.UseVisualStyle = false;
            this.buttonAdv2.Click += new System.EventHandler(this.buttonAdv2_Click);
            // 
            // buttonGrid
            // 
            this.buttonGrid.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonGrid.BackColor = System.Drawing.Color.White;
            this.buttonGrid.BeforeTouchSize = new System.Drawing.Size(75, 75);
            this.buttonGrid.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonGrid.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonGrid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonGrid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGrid.Image = ((System.Drawing.Image)(resources.GetObject("buttonGrid.Image")));
            this.buttonGrid.IsBackStageButton = false;
            this.buttonGrid.KeepFocusRectangle = false;
            this.buttonGrid.Location = new System.Drawing.Point(142, 345);
            this.buttonGrid.Name = "buttonGrid";
            this.buttonGrid.Size = new System.Drawing.Size(75, 75);
            this.buttonGrid.TabIndex = 11;
            this.buttonGrid.UseVisualStyle = false;
            this.buttonGrid.Click += new System.EventHandler(this.buttonGrid_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonPrint.BackColor = System.Drawing.Color.White;
            this.buttonPrint.BeforeTouchSize = new System.Drawing.Size(75, 75);
            this.buttonPrint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPrint.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrint.Image")));
            this.buttonPrint.IsBackStageButton = false;
            this.buttonPrint.KeepFocusRectangle = false;
            this.buttonPrint.Location = new System.Drawing.Point(46, 435);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 75);
            this.buttonPrint.TabIndex = 13;
            this.toolTip1.SetToolTip(this.buttonPrint, "Print Chart");
            this.buttonPrint.UseVisualStyle = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = DockStyle.Right;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonPrint);
            this.panel1.Controls.Add(this.buttonGrid);
            this.panel1.Controls.Add(this.buttonAdv2);
            this.panel1.Controls.Add(this.buttonEmf);
            this.panel1.Controls.Add(this.buttonSVG);
            this.panel1.Controls.Add(this.buttonImage);
            this.panel1.Controls.Add(this.buttonXLsIO);
            this.panel1.Controls.Add(this.buttonPdf);
            this.panel1.Controls.Add(this.buttonDocIO);
            this.panel1.Location = new System.Drawing.Point(700, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 585);
            this.panel1.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Chart Export";
            // 
            // buttonEmf
            // 
            this.buttonEmf.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonEmf.BackColor = System.Drawing.Color.White;
            this.buttonEmf.BeforeTouchSize = new System.Drawing.Size(75, 75);
            this.buttonEmf.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonEmf.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonEmf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonEmf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonEmf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmf.Image = ((System.Drawing.Image)(resources.GetObject("buttonEmf.Image")));
            this.buttonEmf.IsBackStageButton = false;
            this.buttonEmf.KeepFocusRectangle = false;
            this.buttonEmf.Location = new System.Drawing.Point(46, 72);
            this.buttonEmf.Name = "buttonEmf";
            this.buttonEmf.Size = new System.Drawing.Size(75, 75);
            this.buttonEmf.TabIndex = 9;
            this.buttonEmf.UseVisualStyle = false;
            this.buttonEmf.Click += new System.EventHandler(this.buttonEmf_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 598);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(17, 22);
            this.statusStrip1.TabIndex = 44;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 584);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(494, 456);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exporting";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        #region FormLoad

        private void Form1_Load(object sender, System.EventArgs e)
		{
			InitializeChartData();         
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            this.chartControl1.Dock = DockStyle.Fill;

        }
            #endregion

        #region Helper Methods
        #region InitializeChartData
        /// <summary>
		/// Initializes Chart Data.
		/// </summary>
        protected void InitializeChartData()
        {
            ChartSeries series1 = new ChartSeries("Clothes", ChartSeriesType.Line);
            series1.Name = "Clothes";
            series1.Text = "Clothes";
            series1.Points.Add(1, 960);
            series1.Points.Add(2, 4300);
            series1.Points.Add(3, 5750);
            series1.Points.Add(4, 4500);
            series1.Points.Add(5, 3750);
            series1.Points.Add(6, 1800);
            series1.Points.Add(7, 500);
            series1.Points.Add(8, 200);
            series1.Points.Add(9, 100);
            this.chartControl1.Series.Add(series1);         
            
            ChartSeries series = new ChartSeries("Clothes", ChartSeriesType.Column);
            series.Name = "Clothes";
            series.Text = "Clothes";
            series.Points.Add(1, 960);
            series.Points.Add(2, 4300);
            series.Points.Add(3, 5750);
            series.Points.Add(4, 4500);
            series.Points.Add(5, 3750);
            series.Points.Add(6, 1800);
            series.Points.Add(7, 500);
            series.Points.Add(8, 200);
            series.Points.Add(9, 100);
            this.chartControl1.Series.Add(series);

            fileName = Application.StartupPath + "\\chartexport";
            gridForm = new Form2();

        }
        #endregion       
            #endregion
       
        #region Events
        //Exports and saves the chart as Word document.
        #region DocIO
        private void buttonDocIO_Click(object sender, EventArgs e)
        {
            try
            {
                exportFileName = fileName + ".doc";
                string file = fileName + ".gif";

                if (!System.IO.File.Exists(file))
                    this.chartControl1.SaveImage(file);

                //Create a new document
                WordDocument document = new WordDocument();
                //Adding a new section to the document.
                IWSection section = document.AddSection();
                //Adding a paragraph to the section
                IWParagraph paragraph = section.AddParagraph();
                //Writing text.
                paragraph.AppendText("Essential Chart");
                //Adding a new paragraph		
                paragraph = section.AddParagraph();
                paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
                //Inserting chart.
                paragraph.AppendPicture(Image.FromFile(file));
                //Save the Document to disk.
                document.Save(exportFileName, Syncfusion.DocIO.FormatType.Doc);
                OpenFile("DocIO", exportFileName);
                
            }
            catch (Exception ex)
            {
                this.toolStripStatusLabel1.Text = "Chart Export failed.";
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        //Exports and saves the chart in Pdf.
        #region Pdf
        private void buttonPdf_Click(object sender, EventArgs e)
        {
            try
            {
                exportFileName = fileName + ".pdf";
                string file = fileName + ".gif";

                if (!System.IO.File.Exists(file))
                    this.chartControl1.SaveImage(file);

                //Create a new PDF Document. The pdfDoc object represents the PDF document.
                //This document has one page by default and additional pages have to be added.
                PdfDocument pdfDoc = new PdfDocument();

                pdfDoc.Pages.Add();

                pdfDoc.Pages[0].Graphics.DrawImage(PdfImage.FromFile(file), new PointF(10, 30));

                //Save the PDF Document to disk.
                pdfDoc.Save(exportFileName);
                OpenFile("Pdf", exportFileName);
               
            }
            catch (Exception ex)
            {
                this.toolStripStatusLabel1.Text = "Chart Export failed.";
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        //Export and saves the chart in Excel Sheet
        #region XLsIO
        private void buttonXLsIO_Click(object sender, EventArgs e)
        {
            try
            {
                //Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();

                //Instantiate the excel application object.
                IApplication application = excelEngine.Excel;

                //Set the default version as Excel 2007;
                application.DefaultVersion = ExcelVersion.Excel2007;
                exportFileName = fileName + ".xlsx";

                //A new workbook with a worksheet is created.
                IWorkbook chartBook = application.Workbooks.Create(1);
                IWorksheet sheet = chartBook.Worksheets[0];
                
                //Fill the worksheet by chart data.
                for (int i = 1; i <= 4; i++)
                {
                    sheet.Range[i, 1].Number = this.chartControl1.Series[0].Points[i - 1].X;
                    sheet.Range[i, 2].Number = this.chartControl1.Series[0].Points[i - 1].YValues[0];
                }
                for (int i = 1; i <= 4; i++)
                {
                    sheet.Range[i + 5, 1].Number = this.chartControl1.Series[1].Points[i - 1].X;
                    sheet.Range[i + 5, 2].Number = this.chartControl1.Series[1].Points[i - 1].YValues[0];
                }

                //Create a chart worksheet.
                IChart chart = chartBook.Charts.Add("Essential Chart");

                //Specifies the title of the Chart.
                chart.ChartTitle = "Essential Chart";

                //Initializes a new series instance and adds it to the series collection of the chart.
                IChartSerie series1 = chart.Series.Add();
                //Specify the chart type of the series.
                series1.SerieType = ExcelChartType.Column_Clustered;
                //Specify the name of the series. This will be displayed as the text of the legend.
                series1.Name = "Sample Series";
                //Specify the value ranges for the series.
                series1.Values = sheet.Range["B1:B5"];
                //Specify the Category labels for the series.
                series1.CategoryLabels = sheet.Range["A1:A5"];


                IChartSerie series2 = chart.Series.Add();
                //Specify the chart type of the series.
                series2.SerieType = ExcelChartType.Column_Clustered;
                //Specify the name of the series. This will be displayed as the text of the legend.
                series2.Name = "Sample Series";
                //Specify the value ranges for the series.
                series2.Values = sheet.Range["B6:B10"];
                //Specify the Category labels for the series.
                series2.CategoryLabels = sheet.Range["A6:A10"];


                //Makes the chart as active sheet.
                chart.Activate();
                //Save the Chart book.
                chartBook.SaveAs(exportFileName);
                chartBook.Close();
                ExcelUtils.Close();
                OpenFile("XLsIO", exportFileName);
                System.Diagnostics.Process.Start(exportFileName);
               
            }
            catch (Exception ex)
            {
                this.toolStripStatusLabel1.Text = "Chart Export failed.";
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        //Exports and saves chart as Image.
        #region Image
        private void buttonImage_Click(object sender, EventArgs e)
        {
            try
            {
                exportFileName = fileName + ".gif";

                this.chartControl1.SaveImage(exportFileName);
                OpenFile("Image", exportFileName);
               
            }
            catch (Exception ex)
            {
                this.toolStripStatusLabel1.Text = "Chart Export failed.";
                Console.WriteLine(ex.ToString());
                }
            }
        #endregion

        //Export and saves chart as Svg.        
        #region SVG
            //If no application is associated with this file type, need to install an SVG plug-in. 
            //The Adobe plug-in, SVG viewer, could be downloaded for free from the link: 
            //http://www.adobe.com/svg/viewer/install/
            //Once the viewer is installed on your machine, IE will become automatically SVG-enabled. 
        private void buttonSVG_Click(object sender, EventArgs e)
        {
            try
            {
                exportFileName = fileName + ".svg";
                this.chartControl1.SaveImage(exportFileName);
                OpenFile("Svg", exportFileName);
            }
            catch (Exception ex)
            {
                this.toolStripStatusLabel1.Text = "Chart Export failed.";
                Console.WriteLine(ex.ToString());
            }
        }
            #endregion

        //Exports and saves the Image in vector format.
        #region Emf
        private void buttonEmf_Click(object sender, EventArgs e)
        {
            try
            {
                exportFileName = fileName + ".emf";
                this.chartControl1.SaveImage(exportFileName);

                OpenFile("Emf", exportFileName);
            }
            catch (Exception ex)
            {
                this.toolStripStatusLabel1.Text = "Chart Export failed.";
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        //Export and saves chart as csv.
        #region CSV
        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            string csvContent = String.Empty, csvLine = String.Empty;
            string comma = ",";
            exportFileName = fileName + ".csv";

            try
            {
                foreach (ChartSeries series in this.chartControl1.Series)
                {
                    string seriesName = series.Name;
                    int pointCount = series.Points.Count;
                    string seriesType = series.Type.ToString();

                    for (int p = 0; p < pointCount; p++)
                    {
                        ChartPoint point = series.Points[p];

                        string yvaluescsv = String.Empty;
                        int count = point.YValues.Length;
                        for (int i = 0; i < count; i++)
                        {
                            yvaluescsv += point.YValues[i];
                            if (i != count - 1)
                                yvaluescsv += comma;
                        }

                        //The format of the csv can be given here.
                        //csvLine = seriesName + "-" + seriesType + comma + point.X + comma + yvaluescsv;

                        csvLine = point.X + comma + yvaluescsv;
                        csvContent += csvLine + "\n";
                    }
                }

                //Initializes the stream to write the contents in a file.
                System.IO.StreamWriter file = new System.IO.StreamWriter(exportFileName);
                file.WriteLine(csvContent);
                file.Close();

                OpenFile("CSV", exportFileName);
            }
            catch (Exception ex)
            {
                this.toolStripStatusLabel1.Text = "Chart Export failed.";
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        //Exports and displays the chart using Essential Grid.
        #region Grid
        private void buttonGrid_Click(object sender, EventArgs e)
        {
            try
            {
                string file = fileName + ".gif";

                if (!System.IO.File.Exists(file))
                    this.chartControl1.SaveImage(file);

                //Specify the filename as the name of the form.
                gridForm.Name = file;
                OpenFile("Grid", exportFileName);

            }
            catch (Exception ex)
            {
                this.toolStripStatusLabel1.Text = "Chart Export failed.";
                Console.WriteLine(ex.ToString());
            }
        }

            
        #endregion

        #region OpenFile
        protected void OpenFile(string filetype, string exportFileName)
        {
            this.toolStripStatusLabel1.Text = "Chart Exported to " + filetype + " Successfully.";
            try
            {
                if (filetype == "Grid")
                    gridForm.ShowDialog();
                else
                    // System.Diagnostics.Process.Start(exportFileName);
                    MessageBox.Show("The chart has been exported successfully");
            }
            catch (Exception ex)
            {                
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion   

        #region Print
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = this.chartControl1.PrintDocument;
            printPreviewDialog1.ShowDialog();
        }
        #endregion

        private void chartControl1_ChartFormatAxisLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            if (e.AxisOrientation == ChartOrientation.Horizontal)
            {
                if (e.Value == 1)
                    e.Label = "10-19";
                else if (e.Value == 2)
                    e.Label = "20-29";
                else if (e.Value == 3)
                    e.Label = "30-39";
                else if (e.Value == 4)
                    e.Label = "40-49";
                else if (e.Value == 5)
                    e.Label = "50-59";
                else if (e.Value == 6)
                    e.Label = "60-69";
                else if (e.Value == 7)
                    e.Label = "70-79";
                else if (e.Value == 8)
                    e.Label = "80-89";
                else if (e.Value == 9)
                    e.Label = "90-99";
                else
                    e.Label = "";

                e.Handled = true;
            }
        }
        #endregion

       
        


    }
    /// <summary>
    /// Represents a class that is used to find the licensing file for Syncfusion controls.
    /// </summary>
    internal class DemoCommon
    {

        /// <summary>
        /// Finds the license key from the Common folder.
        /// </summary>
        /// <returns>Returns the license key.</returns>
        public static string FindLicenseKey()
        {
            string licenseKeyFile = "..\\Common\\SyncfusionLicense.txt";
            for (int n = 0; n < 20; n++)
            {
                if (!System.IO.File.Exists(licenseKeyFile))
                {
                    licenseKeyFile = @"..\" + licenseKeyFile;
                    continue;
                }
                return System.IO.File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }

}
