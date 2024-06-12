#region Copyright Syncfusion Inc. 2001 - 2024
//
//  Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using System.ComponentModel;
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;
using System.IO;
namespace EssentialXlsIOSample
{
    public class Slicer : MetroForm
    {
        #region Constants
#if NETCORE
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\common\Data\XlsIO\{0}";
#else
        private const string DEFAULTPATH = @"..\..\..\..\..\..\common\Data\XlsIO\{0}";
#endif
        #endregion

        #region Fields
        string[] columnNames = { "Requester", "Assignee", "Status" };
        ExcelEngine excelEngine;
        private PictureBox pictureBox3;
        OrderBy orderBy;
        private GroupBox groupBox2;
        private ComboBox cmbSecond;
        private Button btnViewTemplate;
        private Label label3;
        private ComboBox cmbFirst;
        private Button btnSliceValue;
        private Label label2;
        private Label label1;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        #endregion

        #region Initialize
        public Slicer()
        {
            InitializeComponent();
            excelEngine = new ExcelEngine();
            orderBy = OrderBy.Ascending;
            cmbFirst.Items.AddRange(columnNames);
            cmbSecond.Items.AddRange(columnNames);
            cmbFirst.SelectedIndex = 0;
            cmbSecond.SelectedIndex = 2;
        }
        #endregion

        #region Slicer
        private void btnSliceValues_Click(object sender, EventArgs e)
        {
            SliceTable("SlicerOutput.xlsx");
            OpenOutput("SlicerOutput.xlsx");
        }
        #endregion

        #region View the Input file
        private void btnViewTemplate_Click(object sender, EventArgs e)
        {
            //Get the path of the input file
            string inputPath = GetFullTemplatePath("TableSlicer.xlsx");
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
        #endregion


        #region Dispose the Excel Engine
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            excelEngine.Dispose();
        }
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

        #region Method for Slicer
        private void SliceTable(string outFileName)
        {
            #region Workbook Initialize
            //Get the path of the input file
            string inputPath = GetFullTemplatePath("TableSlicer.xlsx");
            IWorkbook workbook = excelEngine.Excel.Workbooks.Open(inputPath, ExcelOpenType.Automatic);
            IWorksheet sheet = workbook.Worksheets[0];
            #endregion

            IListObject table = sheet.ListObjects[0];

            int colId1 = GetColumnId(cmbFirst.SelectedItem.ToString(), table);
            int colId2 = GetColumnId(cmbSecond.SelectedItem.ToString(), table);
            // Add slicer for the table
            sheet.Slicers.Add(table, colId1, 11, 2);
            sheet.Slicers.Add(table, colId2, 11, 4);

            #region Workbook Save and Close
            workbook.SaveAs(outFileName);
            workbook.Close();
            #endregion
        }
        private int GetColumnId(String columnName, IListObject table)
        {
            int colId = 0;
            for (int i = 0; i < table.Columns.Count; i++)
            {
                if (table.Columns[i].Name == columnName)
                {
                    colId = i + 1;
                    break;
                }
            }
            return colId;
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
                    MessageBox.Show("Excel 2007 is not installed in this system");
                    Console.WriteLine(ex.ToString());
                }
            }
            else
                this.Close();
        }
        #endregion

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Slicer));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbSecond = new System.Windows.Forms.ComboBox();
            this.btnViewTemplate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFirst = new System.Windows.Forms.ComboBox();
            this.btnSliceValue = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbSecond);
            this.groupBox2.Controls.Add(this.btnViewTemplate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbFirst);
            this.groupBox2.Controls.Add(this.btnSliceValue);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 142);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose the columns to create slicers.";
            // 
            // cmbSecond
            // 
            this.cmbSecond.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.cmbSecond.FormattingEnabled = true;
            this.cmbSecond.Location = new System.Drawing.Point(150, 63);
            this.cmbSecond.Name = "cmbSecond";
            this.cmbSecond.Size = new System.Drawing.Size(111, 31);
            this.cmbSecond.TabIndex = 5;
            // 
            // btnViewTemplate
            // 
            this.btnViewTemplate.AutoSize = true;
            this.btnViewTemplate.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnViewTemplate.Location = new System.Drawing.Point(7, 100);
            this.btnViewTemplate.Name = "btnViewTemplate";
            this.btnViewTemplate.Size = new System.Drawing.Size(151, 30);
            this.btnViewTemplate.TabIndex = 4;
            this.btnViewTemplate.Text = "Input Template";
            this.btnViewTemplate.UseVisualStyleBackColor = true;
            this.btnViewTemplate.Click += new System.EventHandler(this.btnViewTemplate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select the column";
            // 
            // cmbFirst
            // 
            this.cmbFirst.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.cmbFirst.FormattingEnabled = true;
            this.cmbFirst.Location = new System.Drawing.Point(150, 26);
            this.cmbFirst.Name = "cmbFirst";
            this.cmbFirst.Size = new System.Drawing.Size(111, 31);
            this.cmbFirst.TabIndex = 10;
            // 
            // btnSliceValue
            // 
            this.btnSliceValue.AutoSize = true;
            this.btnSliceValue.Font = new System.Drawing.Font("Verdana", 7.25F);
            this.btnSliceValue.Location = new System.Drawing.Point(164, 100);
            this.btnSliceValue.Name = "btnSliceValue";
            this.btnSliceValue.Size = new System.Drawing.Size(150, 30);
            this.btnSliceValue.TabIndex = 2;
            this.btnSliceValue.Text = "Create Document";
            this.btnSliceValue.UseVisualStyleBackColor = true;
            this.btnSliceValue.Click += new System.EventHandler(this.btnSliceValues_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select the column";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 84);
            this.label1.TabIndex = 76;
            this.label1.Text = "Click the button to view an Excel spreadsheet generated by Essential XlsIO. Pleas" +
    "e note that MS Excel Viewer or MS Excel is required to view the resultant docume" +
    "nt.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Slicer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(337, 318);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Slicer";
            this.Text = "Slicer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
            Application.Run(new Slicer());
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
