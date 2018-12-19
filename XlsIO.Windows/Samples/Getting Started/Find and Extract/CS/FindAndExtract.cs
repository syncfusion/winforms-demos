#region Copyright Syncfusion Inc. 2001 - 2007
//
//  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms;
using System.Globalization;
using Syncfusion.Licensing;
using System.IO;
namespace EssentialXlsIOSamples
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class FindAndExtract : MetroForm
    {
        #region Constants
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\Common\Data\XlsIO\{0}";
        #endregion

        #region Fields
        private System.Windows.Forms.Button btnExtractData;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstFormat;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Label txtValue;
        private System.Windows.Forms.Label txtDisplay;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        #endregion

        #region Initialize
        public FindAndExtract()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        #endregion

        #region Form Load
        private void FindAndExtract_Load(object sender, EventArgs e)
        {
            lstFormat.SelectedIndex = 0;
        }
        #endregion

        #region Find and Extract Data Method
        private void btnExtractData_Click(object sender, System.EventArgs e)
        {
            #region Workbook Initialization
            //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();

            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;

            //Get the input file path
            string inputPath = GetFullTemplatePath("FindAndExtract.xls");

            //Open an existing spreadsheet which will be used as a template for getting data from input file.
            //After opening, the workbook object represents the complete in-memory object model of the template spreadsheet.

            IWorkbook workbook = application.Workbooks.Open(inputPath, ExcelOpenType.Automatic);

            //The first worksheet object in the worksheets collection is accessed.
            IWorksheet worksheet = workbook.Worksheets[0];
            #endregion

            #region Find and Extract Data
            IRange result;

                #region Find and Extract Numbers
                if (lstFormat.SelectedItem.ToString() == "Number with format 0.00")
                {
                    result = worksheet.FindFirst(1000000.00075, ExcelFindType.Number);

                    //Gets the cell display text
                    txtDisplay.Text = result.DisplayText.ToString();

                    //Gets the cell value
                    txtValue.Text = result.Value2.ToString();

                }

                if (lstFormat.SelectedItem.ToString() == "Number with format $#,##0.00")
                {

                    result = worksheet.FindFirst(3.2, ExcelFindType.Number);

                    //Gets the cell display text
                    txtDisplay.Text = result.DisplayText.ToString();

                    //Gets the cell value
                    txtValue.Text = result.Value2.ToString();

                }

                #endregion

                #region Find and Extract DateTime
                if (lstFormat.SelectedItem.ToString() == "DateTime with format m/d/yy h:mm")
                {

                    result = worksheet.FindFirst(DateTime.Parse("12/1/2007  1:23:00 AM", CultureInfo.InvariantCulture));

                    //Gets the cell display text
                    txtDisplay.Text = result.DisplayText.ToString();

                    //Gets the cell value
                    txtValue.Text = result.Value2.ToString();

                }

                if (lstFormat.SelectedItem.ToString() == "Time with format h:mm:ss AM/PM")
                {

                    result = worksheet.FindFirst(DateTime.Parse("1/1/2007  2:23:00 AM", CultureInfo.InvariantCulture));

                    //Gets the cell display text
                    txtDisplay.Text = result.DisplayText.ToString();

                    //Gets the cell value
                    txtValue.Text = result.DateTime.ToString();

                }
                if (lstFormat.SelectedItem.ToString() == "Date with format d-mmm-yy")
                {

                    result = worksheet.FindFirst(DateTime.Parse("12/4/2007  1:23:00 AM", CultureInfo.InvariantCulture));

                    //Gets the cell display text
                    txtDisplay.Text = result.DisplayText.ToString();

                    //Gets the cell value
                    txtValue.Text = result.Value2.ToString();

                }
                if (lstFormat.SelectedItem.ToString() == "Date with format Saturday, December 01, 2007")
                {

                    result = worksheet.FindFirst(DateTime.Parse("8/1/2007  3:23:00 AM", CultureInfo.InvariantCulture));

                    //Gets the cell display text
                    txtDisplay.Text = result.DisplayText.ToString();

                    //Gets the cell value
                    txtValue.Text = result.Value2.ToString();

                }
                #endregion

                #region Find and Extract Text

                if (lstFormat.SelectedItem.ToString() == "Text")
                {

                    result = worksheet.FindFirst("Simple text", ExcelFindType.Text);

                    //Gets the cell display text
                    txtDisplay.Text = result.DisplayText.ToString();

                    //Gets the cell value
                    txtValue.Text = result.Value2.ToString();

                }
                if (lstFormat.SelectedItem.ToString() == "Text With Styles and Patterns")
                {

                    result = worksheet.FindFirst("Text with Styles and patterns", ExcelFindType.Text);

                    //Gets the cell display text
                    txtDisplay.Text = result.DisplayText.ToString();

                    //Gets the cell value
                    txtValue.Text = result.Value2.ToString();

                }
                if (lstFormat.SelectedItem.ToString() == "Number with Text Format")
                {

                    result = worksheet.FindFirst("$8.200", ExcelFindType.Text);

                    //Gets the cell display text
                    txtDisplay.Text = result.DisplayText.ToString();

                    //Gets the cell value
                    txtValue.Text = result.Value2.ToString();

                }

                #endregion

            #endregion

            #region Workbook Close and Dispose
            //close the workbook
            workbook.Close();
            excelEngine.Dispose();
            #endregion
        }
        #endregion

        #region HelperMethods
        /// <summary>
        /// Get the path of the passed inputfile and return the same
        /// </summary>
        /// <param name="inputPath">Input file</param>
        /// <returns> Path of the input file</returns>
        private string GetFullTemplatePath(string inputFile)
        {
            return string.Format(DEFAULTPATH, inputFile);
        }
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindAndExtract));
            this.btnExtractData = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstFormat = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtValue = new System.Windows.Forms.Label();
            this.txtDisplay = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExtractData
            // 
            this.btnExtractData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExtractData.Image = ((System.Drawing.Image)(resources.GetObject("btnExtractData.Image")));
            this.btnExtractData.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExtractData.Location = new System.Drawing.Point(239, 266);
            this.btnExtractData.Name = "btnExtractData";
            this.btnExtractData.Size = new System.Drawing.Size(92, 26);
            this.btnExtractData.TabIndex = 0;
            this.btnExtractData.Text = "ExtractData";
            this.btnExtractData.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExtractData.Click += new System.EventHandler(this.btnExtractData_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(16, 44);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(65, 13);
            this.lblDisplay.TabIndex = 3;
            this.lblDisplay.Text = "Display Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Value in the Cell";
            // 
            // lstFormat
            // 
            this.lstFormat.Items.AddRange(new object[] {
            "Number with format 0.00",
            "Number with format $#,##0.00",
            "-------------------------------------------",
            "DateTime with format m/d/yy h:mm",
            "Time with format h:mm:ss AM/PM",
            "Date with format d-mmm-yy",
            "Date with format Saturday, December 01, 2007",
            "-----------------------------------------------",
            "Text",
            "Text With Styles and Patterns",
            "Number with Text Format"});
            this.lstFormat.Location = new System.Drawing.Point(19, 119);
            this.lstFormat.Name = "lstFormat";
            this.lstFormat.Size = new System.Drawing.Size(208, 173);
            this.lstFormat.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtValue);
            this.groupBox1.Controls.Add(this.txtDisplay);
            this.groupBox1.Controls.Add(this.lblDisplay);
            this.groupBox1.Controls.Add(this.lstFormat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnExtractData);
            this.groupBox1.Location = new System.Drawing.Point(11, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 312);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FindAndExtract";
            // 
            // txtValue
            // 
            this.txtValue.AutoSize = true;
            this.txtValue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValue.Location = new System.Drawing.Point(109, 79);
            this.txtValue.MinimumSize = new System.Drawing.Size(160, 17);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(160, 17);
            this.txtValue.TabIndex = 8;
            // 
            // txtDisplay
            // 
            this.txtDisplay.AutoSize = true;
            this.txtDisplay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDisplay.Location = new System.Drawing.Point(109, 44);
            this.txtDisplay.MinimumSize = new System.Drawing.Size(160, 17);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(160, 17);
            this.txtDisplay.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // FindAndExtract
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 427);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FindAndExtract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find and Extract";
            this.Load += new System.EventHandler(this.FindAndExtract_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Dispose Methods
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



        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.EnableVisualStyles();
            Application.Run(new FindAndExtract());
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
