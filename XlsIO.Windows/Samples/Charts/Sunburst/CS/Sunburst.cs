#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using System.ComponentModel;
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;
using System.IO;
namespace EssentialXlsIOSample
{
    public class Sunburst : MetroForm
    {
        #region Constants
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\Common\Data\XlsIO\{0}";
        #endregion

        #region Fields       
        ExcelEngine excelEngine;
        private PictureBox pictureBox3;
        private Button btnViewTemplate;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn2016Charts;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton rdbChartSheet;
        private RadioButton rdbEmbeddedChart;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        #endregion

        #region Initialize
        public Sunburst()
        {
            InitializeComponent();
            this.rdbEmbeddedChart.Checked = true;
            excelEngine = new ExcelEngine();
            excelEngine.Excel.DefaultVersion = ExcelVersion.Excel2016;            
        }
        #endregion

        #region View the Input file
        private void btnViewTemplate_Click(object sender, EventArgs e)
        {
            //Get the path of the input file
            string inputPath = GetFullTemplatePath("SunburstTemplate.xlsx");
            //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
            System.Diagnostics.Process.Start(inputPath);
        }
        #endregion

        #region Creating 2016 Charts
        private void btn2016Charts_Click(object sender, EventArgs e)
        {
            string fileName = "SunburstTemplate.xlsx";
            #region Workbook Initialize
            //Get the path of the input file
            string inputPath = GetFullTemplatePath(fileName);
            IWorkbook workbook = excelEngine.Excel.Workbooks.Open(inputPath, ExcelOpenType.Automatic);
            #endregion           
            IWorksheet sheet = workbook.Worksheets[0];
            IChart chart = null;

            if (this.rdbChartSheet.Checked)
                chart = workbook.Charts.Add();
            else
                chart = workbook.Worksheets[0].Charts.Add();

            #region Sunburst Chart Settings
            chart.ChartType = ExcelChartType.SunBurst;
            chart.DataRange = sheet["A1:D29"];
            chart.ChartTitle = "Breakdown of Bookstore Revenue";
            #endregion
                        
            chart.Legend.Position = ExcelLegendPosition.Right;            
            if (this.rdbChartSheet.Checked)
                chart.Activate();               
            else
            {
                workbook.Worksheets[0].Activate();
                IChartShape chartShape = chart as IChartShape;
                chartShape.TopRow = 1;
                chartShape.BottomRow = 23;
                chartShape.LeftColumn = 6;
                chartShape.RightColumn = 15;
            }
            #region Workbook Save and Close                    
            workbook.SaveAs("Sunburst_Chart.xlsx");
            workbook.Close();
            #endregion
            OpenOutput("Sunburst_Chart.xlsx");
        }

        #region Dispose the Excel Engine
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            excelEngine.Dispose();
        }
        #endregion

        #region Open the Output File
        private void OpenOutput(string fileName)
        {
            // Message box confirmation to view the created document.
            if (MessageBox.Show("Do you want to view the workbook?", "Workbook has been created",
            MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            == DialogResult.Yes)
            {
                try
                {
                    //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                    System.Diagnostics.Process.Start(fileName);
                    this.Close();
                }
                catch (Win32Exception ex)
                {
                    MessageBox.Show("Microsoft Excel is not installed in this machine.");
                    Console.WriteLine(ex.ToString());                    
                }
            }
            else
                this.Close();
        }
        #endregion
        #endregion

        #region HelperMethods
        #region Get File Path
        /// <summary>
        /// Get the file path of input file and return the same
        /// </summary>
        /// <param name="inputPath">Input file</param>
        /// <returns>path of the input file</returns>
        private string GetFullTemplatePath(string inputFile)
        {
            return string.Format(DEFAULTPATH, inputFile);
        }
        #endregion    
        #endregion

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sunburst));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbChartSheet = new System.Windows.Forms.RadioButton();
            this.rdbEmbeddedChart = new System.Windows.Forms.RadioButton();
            this.btn2016Charts = new System.Windows.Forms.Button();
            this.btnViewTemplate = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btn2016Charts);
            this.groupBox1.Controls.Add(this.btnViewTemplate);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sunburst";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbChartSheet);
            this.groupBox2.Controls.Add(this.rdbEmbeddedChart);
            this.groupBox2.Location = new System.Drawing.Point(23, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 46);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Location";
            // 
            // rdbChartSheet
            // 
            this.rdbChartSheet.AutoSize = true;
            this.rdbChartSheet.Location = new System.Drawing.Point(181, 20);
            this.rdbChartSheet.Name = "rdbChartSheet";
            this.rdbChartSheet.Size = new System.Drawing.Size(92, 17);
            this.rdbChartSheet.TabIndex = 1;
            this.rdbChartSheet.TabStop = true;
            this.rdbChartSheet.Text = "Chart Sheet";
            this.rdbChartSheet.UseVisualStyleBackColor = true;
            // 
            // rdbEmbeddedChart
            // 
            this.rdbEmbeddedChart.AutoSize = true;
            this.rdbEmbeddedChart.Location = new System.Drawing.Point(22, 20);
            this.rdbEmbeddedChart.Name = "rdbEmbeddedChart";
            this.rdbEmbeddedChart.Size = new System.Drawing.Size(118, 17);
            this.rdbEmbeddedChart.TabIndex = 0;
            this.rdbEmbeddedChart.TabStop = true;
            this.rdbEmbeddedChart.Text = "Embedded Chart";
            this.rdbEmbeddedChart.UseVisualStyleBackColor = true;
            // 
            // btn2016Charts
            // 
            this.btn2016Charts.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2016Charts.Location = new System.Drawing.Point(203, 72);
            this.btn2016Charts.Name = "btn2016Charts";
            this.btn2016Charts.Size = new System.Drawing.Size(129, 25);
            this.btn2016Charts.TabIndex = 2;
            this.btn2016Charts.Text = "Generate Excel";
            this.btn2016Charts.UseVisualStyleBackColor = true;
            this.btn2016Charts.Click += new System.EventHandler(this.btn2016Charts_Click);
            // 
            // btnViewTemplate
            // 
            this.btnViewTemplate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTemplate.Location = new System.Drawing.Point(33, 72);
            this.btnViewTemplate.Name = "btnViewTemplate";
            this.btnViewTemplate.Size = new System.Drawing.Size(129, 25);
            this.btnViewTemplate.TabIndex = 4;
            this.btnViewTemplate.Text = "Input Template";
            this.btnViewTemplate.UseVisualStyleBackColor = true;
            this.btnViewTemplate.Click += new System.EventHandler(this.btnViewTemplate_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(639, 71);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 74;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(0, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 48);
            this.label1.TabIndex = 64;
            this.label1.Text = "Click the button to view an Excel spreadsheet generated by Essential XlsIO. Pleas" +
    "e note that MS Excel Viewer or MS Excel is required to view the resultant docume" +
    "nt.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sunburst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(377, 236);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Sunburst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sunburst Chart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region Dispose
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

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Sunburst());
        }
        #endregion    
    }
	
	/// <summary>
    /// Represents a class that is used to find the licensing file for Syncfusion controls.
    /// </summary>
    public class DemoCommon
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
                return File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }
}
