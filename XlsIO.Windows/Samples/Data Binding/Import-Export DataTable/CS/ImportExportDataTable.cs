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
using System.Windows.Forms;
using System.Data;
using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;
using System.IO;
namespace EssentialXlsIOSamples
{
    /// <summary>
    /// Summary description for ImportExportDataTable.
    /// </summary>
    public class ImportExportDataTable : MetroForm
    {
        #region Constants
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\Common\Data\XlsIO\{0}";
        #endregion

        #region Fields
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private RadioButton rdbExcel2010;
        private RadioButton rdbExcel2007;
        private RadioButton rdbExcel97;
        private string fileName;
        private RadioButton rdbExcel2013;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        #endregion

        #region Initialize
        public ImportExportDataTable()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            this.rdbExcel2013.Checked = true; 
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        #endregion

        #region Import Data from Excel to DataGrid
        private void btnImport_Click(object sender, System.EventArgs e)
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
			string inputPath = GetTemplatePath("NorthwindDataTemplate.xls");
			
            //Open an existing spreadsheet which will be used as a template for generating the new spreadsheet.
            //After opening, the workbook object represents the complete in-memory object model of the template spreadsheet.
            IWorkbook workbook = application.Workbooks.Open(inputPath );
            //The first worksheet object in the worksheets collection is accessed.
            IWorksheet worksheet = workbook.Worksheets[0];
            #endregion

            #region Import Data From Excel to DataGrid
            //Read data from spreadsheet.
            DataTable customersTable = worksheet.ExportDataTable(worksheet.UsedRange, ExcelExportDataTableOptions.ColumnNames);
            this.dataGrid1.DataSource = customersTable;

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

        #region Export Data From DataGrid to Excel
        private void btnExport_Click(object sender, System.EventArgs e)
        {
            //Exports the DataTable to a spreadsheet.

            #region Workbook Initialize
            //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();

            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;
            //Set the Workbook version as Excel 97to2003
            if (this.rdbExcel97.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel97to2003;
                fileName = "ExportToExcel.xls";
            }
            //Set the Workbook version as Excel 2007
            else if (this.rdbExcel2007.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel2007;
                fileName = "ExportToExcel.xlsx";
            }
            //Set the Workbook version as Excel 2010
            else if (this.rdbExcel2010.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel2010;
                fileName = "ExportToExcel.xlsx";
            }
            //Set the Workbook version as Excel 2010
            else if (this.rdbExcel2013.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel2013;
                fileName = "ExportToExcel.xlsx";
            }
            //A new workbook is created.[Equivalent to creating a new workbook in MS Excel]
            //The new workbook will have 3 worksheets
            IWorkbook workbook = application.Workbooks.Create(1);

            //The first worksheet object in the worksheets collection is accessed.
            IWorksheet worksheet = workbook.Worksheets[0];
            #endregion

            #region Export DataTable to Excel
            //Export DataTable.
            if (this.dataGrid1.DataSource != null)
            {
                worksheet.ImportDataTable((DataTable)this.dataGrid1.DataSource, true, 3, 1, -1, -1);
            }
            else
            {
                MessageBox.Show("There is no datatable to export, Please import a datatable first", "Error");

                //Close the workbook.
                workbook.Close();
                return;
            }
            #endregion

            #region Formatting the Report
            //Formatting the Report

            #region Applying Body Stlye
            //Body Style
            IStyle bodyStyle = workbook.Styles.Add("BodyStyle");
            bodyStyle.BeginUpdate();

            //Add custom colors to the palette.
            workbook.SetPaletteColor(9, Color.FromArgb(239, 242, 247));
            bodyStyle.Color = Color.FromArgb(239, 243, 247);
            bodyStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
            bodyStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;

            //Apply Style
            worksheet.UsedRange.CellStyleName = "BodyStyle";
            bodyStyle.EndUpdate();
            #endregion

            #region Applying Header Style
            //Header Style
            IStyle headerStyle = workbook.Styles.Add("HeaderStyle");
            headerStyle.BeginUpdate();

            //Add custom colors to the palette.
            workbook.SetPaletteColor(8, Color.FromArgb(182, 189, 218));
            headerStyle.Color = Color.FromArgb(182, 189, 218);
            headerStyle.Font.Bold = true;
            headerStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
            headerStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
            headerStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
            headerStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;

            //Apply Style
            worksheet.Range["A1:K3"].CellStyleName = "HeaderStyle";
            headerStyle.EndUpdate();
            #endregion

            //Remove grid lines in the worksheet.
            worksheet.IsGridLinesVisible = false;

            //Autofit Rows and Columns
            worksheet.UsedRange.AutofitRows();
            worksheet.UsedRange.AutofitColumns();

            //Adjust Row Height.
            worksheet.Rows[1].RowHeight = 25;

            //Freeze header row.
            worksheet.Range["A4"].FreezePanes();

            worksheet.Range["C2"].Text = "Customer Details";
            worksheet.Range["C2:D2"].Merge();
            worksheet.Range["C2"].CellStyle.Font.Size = 14;
            worksheet.Range["C2"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
            #endregion

            #region Workbook Save and Close
            //Saving the workbook to disk.
            workbook.SaveAs(fileName);

            //No exception will be thrown if there are unsaved workbooks.
            excelEngine.ThrowNotSavedOnDestroy = false;
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
                //Exit
                this.Close();
            }
            else
            {
                // Exit
                this.Close();
            }
            #endregion
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

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportExportDataTable));
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbExcel2013 = new System.Windows.Forms.RadioButton();
            this.rdbExcel2010 = new System.Windows.Forms.RadioButton();
            this.rdbExcel2007 = new System.Windows.Forms.RadioButton();
            this.rdbExcel97 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.BackColor = System.Drawing.Color.Transparent;
            this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImport.Location = new System.Drawing.Point(48, 435);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(80, 23);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.Enabled = false;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.Location = new System.Drawing.Point(240, 435);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(80, 23);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGrid1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(29, 96);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.PreferredRowHeight = 19;
            this.dataGrid1.RowHeadersVisible = false;
            this.dataGrid1.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGrid1.Size = new System.Drawing.Size(312, 292);
            this.dataGrid1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbExcel2013);
            this.groupBox1.Controls.Add(this.rdbExcel2010);
            this.groupBox1.Controls.Add(this.rdbExcel2007);
            this.groupBox1.Controls.Add(this.rdbExcel97);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 396);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 33);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export As";
            // 
            // rdbExcel2013
            // 
            this.rdbExcel2013.AutoSize = true;
            this.rdbExcel2013.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExcel2013.Location = new System.Drawing.Point(248, 13);
            this.rdbExcel2013.Name = "rdbExcel2013";
            this.rdbExcel2013.Size = new System.Drawing.Size(78, 17);
            this.rdbExcel2013.TabIndex = 3;
            this.rdbExcel2013.Text = "Excel 2013";
            this.rdbExcel2013.UseVisualStyleBackColor = true;
            // 
            // rdbExcel2010
            // 
            this.rdbExcel2010.AutoSize = true;
            this.rdbExcel2010.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExcel2010.Location = new System.Drawing.Point(164, 13);
            this.rdbExcel2010.Name = "rdbExcel2010";
            this.rdbExcel2010.Size = new System.Drawing.Size(78, 17);
            this.rdbExcel2010.TabIndex = 2;
            this.rdbExcel2010.Text = "Excel 2010";
            this.rdbExcel2010.UseVisualStyleBackColor = true;
            // 
            // rdbExcel2007
            // 
            this.rdbExcel2007.AutoSize = true;
            this.rdbExcel2007.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExcel2007.Location = new System.Drawing.Point(85, 13);
            this.rdbExcel2007.Name = "rdbExcel2007";
            this.rdbExcel2007.Size = new System.Drawing.Size(78, 17);
            this.rdbExcel2007.TabIndex = 1;
            this.rdbExcel2007.Text = "Excel 2007";
            this.rdbExcel2007.UseVisualStyleBackColor = true;
            // 
            // rdbExcel97
            // 
            this.rdbExcel97.AutoSize = true;
            this.rdbExcel97.Checked = true;
            this.rdbExcel97.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExcel97.Location = new System.Drawing.Point(6, 13);
            this.rdbExcel97.Name = "rdbExcel97";
            this.rdbExcel97.Size = new System.Drawing.Size(78, 17);
            this.rdbExcel97.TabIndex = 0;
            this.rdbExcel97.TabStop = true;
            this.rdbExcel97.Text = "Excel 2003";
            this.rdbExcel97.UseVisualStyleBackColor = true;
            // 
            // ImportExportDataTable
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 470);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ImportExportDataTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import-Export Data Table";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
            Application.Run(new ImportExportDataTable());
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
