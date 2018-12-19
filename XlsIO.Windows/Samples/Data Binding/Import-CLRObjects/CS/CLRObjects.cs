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
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;
using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms;
using System.Diagnostics;
using Syncfusion.Licensing;
using System.IO;
namespace EssentialXlsIOSamples
{
    /// <summary>
    /// Summary description for CLRObjects.
    /// </summary>
    public class CLRObjects : MetroForm
    {

        #region Constants
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\Common\Data\XlsIO\{0}";
        #endregion

        #region Fields

        private PictureBox pictureBox1;
        private String fileName;
        private GroupBox groupBox2;
        private RadioButton rdbExcel2007;
        private RadioButton rdbExcel97;
        private Button button1;
        private RadioButton rdbExcel2013;
        private RadioButton rdbExcel2010;
        private Button btnExport;
        private Button btnInput;
        private DataGridView dataGridView1;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        #endregion

        #region Initialize
        public CLRObjects()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "CLR Objects";
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        #endregion

        #region CLRObjects
        private void btnExport_Click(object sender, EventArgs e)
        {
            #region Initialize Workbook
            //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            //The instantiation process consists of two steps.
            //Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;
            //Set the Default version as Excel 97to2003
            if (this.rdbExcel97.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel97to2003;
                fileName = "CLRObject.xls";
            }
            //Set the Default version as Excel 2007
            else if (this.rdbExcel2007.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel2007;
                fileName = "CLRObject.xlsx";
            }
            else if(this.rdbExcel2010.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel2010;
                fileName = "CLRObject.xlsx";
            }
            else if (this.rdbExcel2013.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel2013;
                fileName = "CLRObject.xlsx";
            }
            //Create a new spreadsheet.
            IWorkbook workbook = excelEngine.Excel.Workbooks.Create(1);
            //The first worksheet object in the worksheets collection is accessed.
            IWorksheet sheet = workbook.Worksheets[0];
            
            sheet.ImportData((List<Customer>)this.dataGridView1.DataSource, 5, 1, false);

            #region Define Styles
            IStyle pageHeader = workbook.Styles.Add("PageHeaderStyle");
            IStyle tableHeader = workbook.Styles.Add("TableHeaderStyle");

            pageHeader.Font.RGBColor = Color.FromArgb(0, 83, 141, 213);
            pageHeader.Font.FontName = "Calibri";
            pageHeader.Font.Size = 18;
            pageHeader.Font.Bold = true;
            pageHeader.HorizontalAlignment = ExcelHAlign.HAlignCenter;
            pageHeader.VerticalAlignment = ExcelVAlign.VAlignCenter;

            tableHeader.Font.Color = ExcelKnownColors.White;
            tableHeader.Font.Bold = true;
            tableHeader.Font.Size = 11;
            tableHeader.Font.FontName = "Calibri";
            tableHeader.HorizontalAlignment = ExcelHAlign.HAlignCenter;
            tableHeader.VerticalAlignment = ExcelVAlign.VAlignCenter;
            tableHeader.Color = Color.FromArgb(0, 118, 147, 60);
            tableHeader.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
            tableHeader.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
            tableHeader.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
            tableHeader.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
            #endregion

            #region Apply Styles
            // Apply style for header
            sheet["A1:D1"].Merge();
            sheet["A1"].Text = "Yearly Sales Report";
            sheet["A1"].CellStyle = pageHeader;

            sheet["A2:D2"].Merge();
            sheet["A2"].Text = "Namewise Sales Comparison Report";
            sheet["A2"].CellStyle = pageHeader;
            sheet["A2"].CellStyle.Font.Bold = false;
            sheet["A2"].CellStyle.Font.Size = 16;

            sheet["A3:A4"].Merge();
            sheet["D3:D4"].Merge();
            sheet["B3:C3"].Merge();
            sheet["B3"].Text = "Sales";
            sheet["A3:D4"].CellStyle = tableHeader;

            sheet["A3"].Text = "Sales Person";
            sheet["B4"].Text = "January - June";
            sheet["C4"].Text = "July - December";
            sheet["D3"].Text = "Change(%)";

            sheet.UsedRange.AutofitColumns();
            sheet.Columns[0].ColumnWidth = 24;
            sheet.Columns[1].ColumnWidth = 21;
            sheet.Columns[2].ColumnWidth = 21;
            sheet.Columns[3].ColumnWidth = 16;
            #endregion

            #endregion

            #region Save the Workbook
            //Saving the workbook to disk. This spreadsheet is the result of opening and modifying
            //an existing spreadsheet and then saving the result to a new workbook.
            workbook.SaveAs(fileName);
            #endregion

            #region Workbook Close and Dispose
            //Close the workbook.
            workbook.Close();

            excelEngine.Dispose();
            #endregion

            #region View the Workbook
            //Message box confirmation to view the created spreadsheet.
            if (MessageBox.Show("Do you want to view the workbook?", "Workbook has been created",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start(fileName);
            }
            // Exit
            //this.Close();
            #endregion

        }
        #endregion

        #region View the Input Template
        private void btnInput_Click(object sender, EventArgs e)
        {
            //Get the path of the input file
            string inputPath = GetFullTemplatePath("ExportSales.xlsx");
            //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
            System.Diagnostics.Process.Start(inputPath);
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
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CLRObjects));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbExcel2013 = new System.Windows.Forms.RadioButton();
            this.rdbExcel2010 = new System.Windows.Forms.RadioButton();
            this.rdbExcel2007 = new System.Windows.Forms.RadioButton();
            this.rdbExcel97 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(681, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbExcel2013);
            this.groupBox2.Controls.Add(this.rdbExcel2010);
            this.groupBox2.Controls.Add(this.rdbExcel2007);
            this.groupBox2.Controls.Add(this.rdbExcel97);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(25, 483);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(631, 54);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Save As";
            // 
            // rdbExcel2013
            // 
            this.rdbExcel2013.AutoSize = true;
            this.rdbExcel2013.Checked = true;
            this.rdbExcel2013.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExcel2013.Location = new System.Drawing.Point(498, 20);
            this.rdbExcel2013.Name = "rdbExcel2013";
            this.rdbExcel2013.Size = new System.Drawing.Size(116, 24);
            this.rdbExcel2013.TabIndex = 3;
            this.rdbExcel2013.TabStop = true;
            this.rdbExcel2013.Text = "Excel 2013";
            this.rdbExcel2013.UseVisualStyleBackColor = true;
            // 
            // rdbExcel2010
            // 
            this.rdbExcel2010.AutoSize = true;
            this.rdbExcel2010.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExcel2010.Location = new System.Drawing.Point(338, 20);
            this.rdbExcel2010.Name = "rdbExcel2010";
            this.rdbExcel2010.Size = new System.Drawing.Size(116, 24);
            this.rdbExcel2010.TabIndex = 2;
            this.rdbExcel2010.Text = "Excel 2010";
            this.rdbExcel2010.UseVisualStyleBackColor = true;
            // 
            // rdbExcel2007
            // 
            this.rdbExcel2007.AutoSize = true;
            this.rdbExcel2007.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExcel2007.Location = new System.Drawing.Point(178, 20);
            this.rdbExcel2007.Name = "rdbExcel2007";
            this.rdbExcel2007.Size = new System.Drawing.Size(116, 24);
            this.rdbExcel2007.TabIndex = 1;
            this.rdbExcel2007.Text = "Excel 2007";
            this.rdbExcel2007.UseVisualStyleBackColor = true;
            // 
            // rdbExcel97
            // 
            this.rdbExcel97.AutoSize = true;
            this.rdbExcel97.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExcel97.Location = new System.Drawing.Point(18, 20);
            this.rdbExcel97.Name = "rdbExcel97";
            this.rdbExcel97.Size = new System.Drawing.Size(116, 24);
            this.rdbExcel97.TabIndex = 0;
            this.rdbExcel97.Text = "Excel 2003";
            this.rdbExcel97.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(246, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 36);
            this.button1.TabIndex = 70;
            this.button1.Text = "Import From Excel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.Enabled = false;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.Location = new System.Drawing.Point(468, 543);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(188, 36);
            this.btnExport.TabIndex = 71;
            this.btnExport.Text = "Export To Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnInput
            // 
            this.btnInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInput.BackColor = System.Drawing.Color.Transparent;
            this.btnInput.Image = ((System.Drawing.Image)(resources.GetObject("btnInput.Image")));
            this.btnInput.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInput.Location = new System.Drawing.Point(25, 543);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(188, 36);
            this.btnInput.TabIndex = 73;
            this.btnInput.Text = "Input Template";
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(25, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 20;
            this.dataGridView1.Size = new System.Drawing.Size(630, 368);
            this.dataGridView1.TabIndex = 77;
            // 
            // CLRObjects
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 588);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CLRObjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLRObjects";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Dispose
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
            Application.Run(new CLRObjects());
        }
        #endregion

        #region HelperMethods
        /// <summary>
        /// Get the file path of input file and return the same
        /// </summary>
        /// <param name="inputPath">Input file</param>
        /// <returns>path of the input file</returns>
        private string GetTemplatePath(string inputFile)
        {
            return string.Format(DEFAULTPATH, inputFile);
        }
        #endregion

        #region Export CLRObjects
        private void button1_Click(object sender, EventArgs e)
        {
            //Imports Data from the Template spreadsheet into the Grid.

            #region Workbook Initialize
            //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;

            //Get path of the Input file
            string inputPath = GetTemplatePath("ExportSales.xlsx");

            //After opening, the workbook object represents the complete in-memory object model of the template spreadsheet.
            IWorkbook workbook = application.Workbooks.Open(inputPath);
            //The first worksheet object in the worksheets collection is accessed.
            IWorksheet worksheet = workbook.Worksheets[0];
            #endregion

            #region Export CLR Object from Workbook
            //Read data from spreadsheet.
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            List<Customer> CLRObjects = worksheet.ExportData<Customer>(1, 1, 41, 4);

            this.dataGridView1.DataSource = CLRObjects;

            btnExport.Enabled = true;
            #endregion

            #region Workbook Close and Dispose
            //Close the workbook.
            workbook.Close();

            //No exception will be thrown if there are unsaved workbooks.
            excelEngine.ThrowNotSavedOnDestroy = false;
            excelEngine.Dispose();
            #endregion
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
