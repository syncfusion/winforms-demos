#region Copyright Syncfusion Inc. 2001-2021
//
//  Copyright Syncfusion Inc. 2001-2021. All rights reserved.
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
using System.Data;
using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;
using System.IO;
using Syncfusion.XlsIO.Implementation;

namespace EssentialXlsIOSamples
{
    /// <summary>
    /// Summary description for ImportExportDataTable.
    /// </summary>
    public class ImportExportDataTable : MetroForm
    {
        #region Constants
#if NETCORE
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\common\Data\XlsIO\{0}";
#else
        private const string DEFAULTPATH = @"..\..\..\..\..\..\common\Data\XlsIO\{0}";
#endif
        #endregion

        #region Fields
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnInput;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private RadioButton rdbSaveXls;
        private RadioButton rdbSaveXlsx;
        private string fileName;
        private RadioButton rdbSkipRow;
        private RadioButton rdbReplaceValue;
        private RadioButton rdbStop;
        private GroupBox groupBox2;
        private Label label;

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

            this.rdbSaveXlsx.Checked = true;
            this.rdbSkipRow.Checked = true;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        #endregion

        private void btnInput_Click(object sender, System.EventArgs e)
        {
            string inputfile = GetTemplatePath("NorthwindDataTemplate.xls");
#if NETCORE
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo = new System.Diagnostics.ProcessStartInfo(inputfile)
                {
                    UseShellExecute = true
                };
                process.Start();
#else
            Process.Start(inputfile);
#endif

        }

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

            worksheet.ExportDataTableEvent += ExportDataTableEventActions;
            #region Import Data From Excel to DataGrid
            //Read data from spreadsheet.
            DataTable customersTable = worksheet.ExportDataTable(worksheet.UsedRange, ExcelExportDataTableOptions.ColumnNames);
            this.dataGridView1.DataSource = customersTable;
            if (dataGridView1.Columns.Count > 0)
            {
                
                this.dataGridView1.Columns[1].Width = 145;
                this.dataGridView1.Columns[2].Width = 100;
                this.dataGridView1.Columns[3].Width = 118;
                this.dataGridView1.Columns[4].Width = 142;
                this.dataGridView1.Columns[5].Width = 72;
            }
            this.dataGridView1.CurrentCell.Selected = false;

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
            if (this.rdbSaveXls.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel97to2003;
                fileName = "ExportToExcel.xls";
            }
            //Set the Workbook version as Excel 2007
            else if (this.rdbSaveXlsx.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel2007;
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
            if (this.dataGridView1.DataSource != null)
            {
                worksheet.ImportDataTable((DataTable)this.dataGridView1.DataSource, true, 3, 1, -1, -1);
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
            workbook.Close();
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
            }
            #endregion
        }
        #endregion

        /// <summary>
        /// Export dataTable required actions.
        /// </summary>
        /// <param name="e"></param>
        private void ExportDataTableEventActions(ExportDataTableEventArgs e)
        {
            if(this.rdbSkipRow.Checked)
            {
                if ( e.ExcelValue != null && e.ExcelValue.ToString() == "Owner")
                    e.ExportDataTableAction = ExportDataTableActions.SkipRow;
            }
            if(this.rdbStop.Checked)
            {
                if (e.ExcelValue != null && e.ExcelValue.ToString() == "CACTU")
                    e.ExportDataTableAction = ExportDataTableActions.StopExporting;
            }
            if(this.rdbReplaceValue.Checked)
            {
                if (e.ExcelValue != null && e.ExcelValue.ToString() == "Mexico D.F.")
                    e.DataTableValue = "Mexico";
            }
        }

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
        void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.Width = 80;
        }
        #endregion
        private void OnEnabledChanged(object sender, EventArgs e)
        {
            this.btnExport.Enabled = false;
        }
        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportExportDataTable));
            this.btnInput = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbSaveXls = new System.Windows.Forms.RadioButton();
            this.rdbSaveXlsx = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbSkipRow = new System.Windows.Forms.RadioButton();
            this.rdbStop = new System.Windows.Forms.RadioButton();
            this.rdbReplaceValue = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout(); 
            this.SuspendLayout();

            // 
            // btnInput
            // 
            this.btnInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInput.BackColor = System.Drawing.Color.Transparent;
            this.btnInput.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
            this.btnInput.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInput.Location = new System.Drawing.Point(560, 495);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(130, 25);
            this.btnInput.TabIndex = 0;
            this.btnInput.TextAlign = ContentAlignment.MiddleCenter;
            this.btnInput.Text = "Input Template";
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.BackColor = System.Drawing.Color.Transparent;
            this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImport.Location = new System.Drawing.Point(560, 533);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(130, 25);
            this.btnImport.TabIndex = 0;
            this.btnImport.TextAlign = ContentAlignment.MiddleCenter;
            this.btnImport.Text = "Import from Excel";
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
            this.btnExport.Location = new System.Drawing.Point(560, 570);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(130, 25);
            this.btnExport.TabIndex = 2;
            this.btnExport.TextAlign = ContentAlignment.MiddleCenter;
            this.btnExport.Text = "Export to Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dataGrid1
            // 
            this.dataGridView1.DataMember = "";
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnAdded += new DataGridViewColumnEventHandler(dataGridView1_ColumnAdded);
            this.dataGridView1.Location = new System.Drawing.Point(15, 190);
            this.dataGridView1.Name = "dataGrid1";
            this.dataGridView1.RowHeadersVisible = false;

            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;

            this.dataGridView1.Size = new System.Drawing.Size(676, 285);
            this.dataGridView1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            //
            // groupBox2
            //
            this.groupBox2.Controls.Add(this.rdbSkipRow);
            this.groupBox2.Controls.Add(this.rdbReplaceValue);
            this.groupBox2.Controls.Add(this.rdbStop);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 495);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 102);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Import Options";
            //
            // rdbSkipRow
            //
            this.rdbSkipRow.AutoSize = true;
            this.rdbSkipRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSkipRow.Location = new System.Drawing.Point(15, 18);
            this.rdbSkipRow.Name = "rdbSkipRow";
            this.rdbSkipRow.Size = new System.Drawing.Size(150, 17);
            this.rdbSkipRow.CheckedChanged += new System.EventHandler(this.OnEnabledChanged);
            this.rdbSkipRow.TabIndex = 0;
            this.rdbSkipRow.Text = "Skip rows if \"ContactTitle\" is \"Owner\"";
            this.rdbSkipRow.UseVisualStyleBackColor = true;
            //
            //rdbReplaceValue
            //
            this.rdbReplaceValue.AutoSize = true;
            this.rdbReplaceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbReplaceValue.Location = new System.Drawing.Point(15, 44);
            this.rdbReplaceValue.Name = "rdbReplaceValue";
            this.rdbReplaceValue.Size = new System.Drawing.Size(150, 17);
            this.rdbReplaceValue.CheckedChanged += new System.EventHandler(this.OnEnabledChanged);
            this.rdbReplaceValue.TabIndex = 1;
            this.rdbReplaceValue.Text = "Replace \"Mexico D.F.\" to \"Mexico\"";
            this.rdbReplaceValue.UseVisualStyleBackColor = true;
            //
            //rdbStop
            //
            this.rdbStop.AutoSize = true;
            this.rdbStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbStop.Location = new System.Drawing.Point(15, 71);
            this.rdbStop.Name = "rdbStop";
            this.rdbStop.Size = new System.Drawing.Size(150, 17);
            this.rdbStop.CheckedChanged += new System.EventHandler(this.OnEnabledChanged);
            this.rdbStop.TabIndex = 2;
            this.rdbStop.Text = "Stop importing if \"CustomerID\" is \"CACTU\"";
            this.rdbStop.UseVisualStyleBackColor = true;
            // 
            //groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbSaveXls);
            this.groupBox1.Controls.Add(this.rdbSaveXlsx);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(359, 495);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 102);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save As";
            // 
            // rdbXls
            // 
            this.rdbSaveXls.AutoSize = true;
            this.rdbSaveXls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSaveXls.Location = new System.Drawing.Point(6, 28);
            this.rdbSaveXls.Name = "rdbExcel2013";
            this.rdbSaveXls.Size = new System.Drawing.Size(20, 17);
            this.rdbSaveXls.TabIndex = 0;
            this.rdbSaveXls.Text = "XLS";
            this.rdbSaveXls.UseVisualStyleBackColor = true;
            // 
            // rdbXlsx
            // 
            this.rdbSaveXlsx.AutoSize = true;
            this.rdbSaveXlsx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSaveXlsx.Location = new System.Drawing.Point(6, 63);
            this.rdbSaveXlsx.Name = "rdbExcel2010";
            this.rdbSaveXlsx.Size = new System.Drawing.Size(6, 17);
            this.rdbSaveXlsx.TabIndex = 1;
            this.rdbSaveXlsx.Text = "XLSX";
            this.rdbSaveXlsx.UseVisualStyleBackColor = true;

            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label.Location = new System.Drawing.Point(14, 81);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label1";
            this.label.Size = new System.Drawing.Size(670, 95);
            this.label.TabIndex = 78;
            this.label.Text = resources.GetString("label.Text");
            // 
            // ImportExportDataTable
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(705, 612);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ImportExportDataTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import-Export Data Table";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
