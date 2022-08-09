#region Copyright Syncfusion Inc. 2001-2022
//
//  Copyright Syncfusion Inc. 2001-2022. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using Syncfusion.Licensing;
using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms;

namespace EssentialXlsIOSamples
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class ExcelToJSON : MetroForm
    {
        #region Constants
#if NETCORE
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\common\Data\XlsIO\{0}";
#else
        private const string DEFAULTPATH = @"..\..\..\..\..\..\common\Data\XlsIO\{0}";
#endif
        #endregion

        #region Fields
        string[] jsonOptions = { "Workbook", "Worksheet", "Range" };
        ExcelEngine excelEngine;
        private GroupBox groupBox1;
        private PictureBox pictureBox3;
        private Button btnConvertToJSON;
        private Button btnViewTemplate;
        private ComboBox combo1;
        private Label label1;
        private Label label2;
        private CheckBox check1;
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        #endregion

        #region Initialize
        public ExcelToJSON()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            
            excelEngine = new ExcelEngine();
            
            foreach (string options in jsonOptions)
            {
                combo1.Items.Add(options);
            }
            combo1.SelectedIndex = 0;
            check1.Checked = true;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        #endregion

        #region Excel To JSON

        private void btnViewTemplate_Click(object sender, EventArgs e)
        {
            string inputPath = GetFullTemplatePath("ExcelToJSON.xlsx");
            //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
#if NETCORE
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo(inputPath)
            {
                UseShellExecute = true
            };
            process.Start();
#else
            Process.Start(inputPath);
#endif
        }

        private void btnConvertToJSON_Click(object sender, EventArgs e)
        {
            string inputPath = GetFullTemplatePath("ExcelToJSON.xlsx");
            IWorkbook workbook = excelEngine.Excel.Workbooks.Open(inputPath, ExcelOpenType.Automatic);
            IWorksheet sheet = workbook.Worksheets[0];

            IRange range = sheet.Range["A2:A5"];
            bool isSchema = check1.Checked;

            string fileName = "ExcelToJSON.json";

            if (combo1.SelectedIndex == 0)
                workbook.SaveAsJson(fileName, isSchema);
            else if (combo1.SelectedIndex == 1)
                workbook.SaveAsJson(fileName, sheet, isSchema);
            else if (combo1.SelectedIndex == 2)
                workbook.SaveAsJson(fileName, range, isSchema);

            OpenOutput(fileName);
        }
        #endregion

        #region HelperMethods
        /// <summary>
        /// Get the file path of input file and return the same
        /// </summary>
        /// <param name="inputPath">Input file</param>
        /// <returns>path of the input file</returns>
        private string GetFullTemplatePath(string inputFile)
        {
            return string.Format(DEFAULTPATH, inputFile);
        }

        #region Open the Output File
        private void OpenOutput(string fileName)
        {
            // Message box confirmation to view the created document.
            if (MessageBox.Show("Do you want to view the JSON?", "JSON has been created",
            MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            == DialogResult.Yes)
            {
                try
                {
#if NETCORE
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo = new System.Diagnostics.ProcessStartInfo(fileName)
                    {
                        UseShellExecute = true
                    };
                    process.Start();
#else
                    Process.Start(fileName);
#endif

                    //Exit
                    this.Close();
                }
                catch (Win32Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            else
                this.Close();
        }
        #endregion
        
        #endregion

        #region Dispose the Excel Engine
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            excelEngine.Dispose();
        }
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelToJSON));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.check1 = new System.Windows.Forms.CheckBox();
            this.combo1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvertToJSON = new System.Windows.Forms.Button();
            this.btnViewTemplate = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(1, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(600, 100);
            this.label2.TabIndex = 64;
            this.label2.Text = "Click the \"Input Template\" button to view the input Excel document. Please note that the Microsoft Excel viewer or Microsoft Excel is required to view the Excel documnet.\n\nClick the \"Convert To JSON\" button to view the coverted JSON file.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.check1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.combo1);
            this.groupBox1.Controls.Add(this.btnConvertToJSON);
            this.groupBox1.Controls.Add(this.btnViewTemplate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 148);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Excel To JSON";
            // 
            // check1
            // 
            this.check1.Location = new System.Drawing.Point(388, 40);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(136, 35);
            this.check1.TabIndex = 19;
            this.check1.Text = "As Schema";
            this.check1.UseVisualStyleBackColor = true;
            // 
            // combo1
            // 
            this.combo1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo1.FormattingEnabled = true;
            this.combo1.Location = new System.Drawing.Point(192, 42);
            this.combo1.Name = "combo1";
            this.combo1.Size = new System.Drawing.Size(173, 29);
            this.combo1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(100, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Convert";
            // 
            // btnConvertToJSON
            // 
            this.btnConvertToJSON.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertToJSON.Location = new System.Drawing.Point(325, 97);
            this.btnConvertToJSON.Name = "btnConvertToJSON";
            this.btnConvertToJSON.Size = new System.Drawing.Size(186, 39);
            this.btnConvertToJSON.TabIndex = 13;
            this.btnConvertToJSON.Text = "Convert To JSON";
            this.btnConvertToJSON.UseVisualStyleBackColor = true;
            this.btnConvertToJSON.Click += new System.EventHandler(this.btnConvertToJSON_Click);
            // 
            // btnViewTemplate
            // 
            this.btnViewTemplate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTemplate.Location = new System.Drawing.Point(104, 99);
            this.btnViewTemplate.Name = "btnViewTemplate";
            this.btnViewTemplate.Size = new System.Drawing.Size(186, 37);
            this.btnViewTemplate.TabIndex = 12;
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
            this.pictureBox3.TabIndex = 75;
            this.pictureBox3.TabStop = false;
            // 
            // ReplaceOptions
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(643, 365);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Excel To JSON";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel To JSON";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Dispose methods
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
            Application.Run(new ExcelToJSON());
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
            string licenseKeyFile = "common\\SyncfusionLicense.txt";
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