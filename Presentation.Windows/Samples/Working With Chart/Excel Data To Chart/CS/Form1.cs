using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Syncfusion.Presentation;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;
using Syncfusion.OfficeChart;
using Syncfusion.Licensing;
using System.Reflection;

namespace Images
{
    public partial class Form1 : MetroForm
    {
        #region Private Members
        private System.Windows.Forms.Button btnCreatePresn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;

        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        #endregion

        # region Constructor
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //            
            InitializeComponent();
            this.MinimizeBox = true;
            Application.EnableVisualStyles();
        }
        /// <summary>
        /// Helper method to find a syncfusion license key from the Common folder
        /// </summary>
        /// <param name="fileName">File name of the syncfusion license key</param>
        /// <returns></returns>
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
                return File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCreatePresn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreatePresn
            // 
            this.btnCreatePresn.Location = new System.Drawing.Point(200, 152);
            this.btnCreatePresn.Name = "btnCreatePresn";
            this.btnCreatePresn.Size = new System.Drawing.Size(180, 22);
            this.btnCreatePresn.TabIndex = 0;
            this.btnCreatePresn.Text = "Create Chart With Excel Data";
            this.btnCreatePresn.UseVisualStyleBackColor = true;
            this.btnCreatePresn.Click += new System.EventHandler(this.btnCreatePresn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 97);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "Click the button to view a created Chart in PowerPoint Presentation. This\nsample " +
    "demonstrates how to create a chart from Excel data in Presentation.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 180);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCreatePresn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel Data To Chart";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        [STAThread]
        static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(FindLicenseKey());
            Application.Run(new Form1());
        }

        #endregion

        private void btnCreatePresn_Click(object sender, EventArgs e)
        {
            try
            {
                //Getting data from file
                string dataPath = @"..\..\..\..\..\..\..\Common\Data\Presentation\";
                IPresentation presentation = Presentation.Create();
                //New Instance of PowerPoint is Created.[Equivalent to launching MS PowerPoint with no slides].

                //Method call to edit slides
                CreateSlide1(presentation,dataPath);
                presentation.Save("ExcelDataToChart.pptx");
                if (MessageBox.Show("Do you want to view the created PowerPoint Presentation?", "PowerPoint Presentation Created",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    System.Diagnostics.Process.Start("ExcelDataToChart.pptx");
                    this.Close();

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("This file could not be created , please contact Syncfusion Direct-Trac system at http://www.syncfusion.com/support/default.aspx for any queries. ", "OOPS..Sorry!",
                        MessageBoxButtons.OK);

            }
        }
        # region Slide1
        private void CreateSlide1(IPresentation presentation,string dataPath)
        {
            ISlide slide1 = presentation.Slides.Add(SlideLayoutType.TitleOnly);
            IShape titleShape = slide1.Shapes[0] as IShape;
            titleShape.Height = 1.45 * 72;
            titleShape.Width = 11.5 * 72;
            titleShape.Left = 0.92 * 72;
            titleShape.Top = 0.4 * 72;

            IParagraph titleParagarph = titleShape.TextBody.AddParagraph();
            ITextPart titleTextPart=titleParagarph.TextParts.Add();
            titleTextPart.Text = "Northwind Management Report";
            titleTextPart.Font.FontSize = 44;
            titleTextPart.Font.FontName = "Calibri Light (Headings)";
            titleParagarph.HorizontalAlignment = HorizontalAlignmentType.Center;
            titleTextPart.Font.Color = ColorObject.FromArgb(0, 112, 48, 160);

            //Load the excel template as stream
            Stream excelStream = File.OpenRead(dataPath + "Excel_Template.xlsx");
            RectangleF chartSize = new RectangleF();
            chartSize.Width = (float)9.66 * 72;
            chartSize.Height = (float)5.57 * 72;
            
            IPresentationChart excelChart = slide1.Shapes.AddChart(excelStream, 1, "B2:C6", chartSize);
            //Set chart data
            excelChart.ChartType = OfficeChartType.Bar_Clustered;
            excelChart.ChartTitle = "Purchase Details";
            excelChart.ChartTitleArea.FontName = "Calibri (Body)";
            excelChart.ChartTitleArea.Size = 14;
            //Set name to chart series            
            excelChart.Series[0].Name = "Sum of Purchases";
            excelChart.Series[1].Name = "Sum of Future Expenses";
            //Set Chart Data table
            excelChart.HasDataTable = true;
            excelChart.DataTable.HasBorders = true;
            excelChart.DataTable.HasHorzBorder = true;
            excelChart.DataTable.HasVertBorder = true;
            excelChart.DataTable.ShowSeriesKeys = true;
            excelChart.HasLegend = false;
            //Setting background color
            excelChart.ChartArea.Fill.ForeColor = Color.FromArgb(208, 206, 206);
            excelChart.PlotArea.Fill.ForeColor = Color.FromArgb(208, 206, 206);
            //Setting line pattern to the chart area
            excelChart.PrimaryCategoryAxis.Border.LinePattern = OfficeChartLinePattern.None;
            excelChart.PrimaryValueAxis.Border.LinePattern = OfficeChartLinePattern.None;
            excelChart.ChartArea.Border.LinePattern = OfficeChartLinePattern.None;
            excelChart.PrimaryValueAxis.MajorGridLines.Border.LineColor = Color.FromArgb(175, 171, 171);
            //Set label for primary catagory axis
            excelChart.PrimaryCategoryAxis.CategoryLabels = excelChart.ChartData[2, 1, 6, 1];
            excelChart.CategoryLabelLevel = OfficeCategoriesLabelLevel.CategoriesLabelLevelNone;
            //excelChart.XPos = (float)1.6 * 72;
            //excelChart.YPos = (float)1.8 * 72;
            slide1.Shapes[1].Left = (float)1.8 * 72;
            slide1.Shapes[1].Top = (float)1.6 * 72;
        }
          #endregion

    }
}
