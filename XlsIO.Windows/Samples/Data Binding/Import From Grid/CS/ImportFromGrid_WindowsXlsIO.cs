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
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using System.Globalization;
using System.IO;
using System.Data;
using System.Drawing;
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;
namespace ImportFromGrid_WindowsXlsIO
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class ImportFromGrid : MetroForm
    {
        #region Constants
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\Common\Data\XlsIO\{0}";
        
        private const string OUTPUTPATH = @"..\..\Output\{0}";
        #endregion

        #region Fields
        private System.Windows.Forms.Button btnCreate;
        private Label label2;
        private PictureBox pictureBox3;
        private DataGridView dataGridView;
        private GroupBox ImportStyles;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private RadioButton rdbXls;
        private RadioButton rdbXlsx;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        #endregion

        #region Initialize
        public ImportFromGrid()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;

            //
            // Loaded data source with dataGridView
            //

            dataGridView.DataSource = GetDataTable();
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dataGridView.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold)));
            dataGridView.ForeColor = Color.Black;
            dataGridView.BorderStyle = BorderStyle.None;
        }
        #endregion

        #region Methods
        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            #region Workbook Intialization
            //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;
            string fileName = "";
            if (this.rdbXls.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel97to2003;
                fileName = "ImportGrid.xls";
            }
            //Set the Workbook version as Excel 2007-2016
            else if(this.rdbXlsx.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel2013;
                fileName = "ImportGrid.xlsx";
            }

            //Create a workbook with single worksheet
            IWorkbook workbook = application.Workbooks.Create(1);
                        
            IWorksheet worksheet = workbook.Worksheets[0];
            #endregion

            // Import from DataGridView to worksheet.
            worksheet.ImportDataGridView(dataGridView, 1 , 1 , checkBox1.Checked, checkBox2.Checked);

            worksheet.UsedRange.AutofitColumns();

            #region Workbook Save

            string outputPath = "Output.xlsx";
                           
            outputPath = GetFullOutputPath(fileName);
            workbook.SaveAs(outputPath);
            #endregion

            #region Workbook Close and Dispose

            //Close the workbook.
            workbook.Close();
            excelEngine.Dispose();
            #endregion

            #region View the Workbook
            //Message box confirmation to view the created document.
            if (MessageBox.Show("Do you want to view the workbook?", "Workbook has been created",
            MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            == DialogResult.Yes)
            {
                try
                {
                    //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                    System.Diagnostics.Process.Start(outputPath);
                }
                catch (Win32Exception ex)
                {
                    MessageBox.Show("Ms Excel is not installed in this system");
                    Console.WriteLine(ex.ToString());
                }
            }
            #endregion
        }
        #endregion

        #region HelperMethods
        private string GetFullTemplatePath(string inputFile)
        {
            return string.Format(DEFAULTPATH, inputFile);
        }
        
        private string GetFullOutputPath(string outputFile)
        {
            return string.Format(OUTPUTPATH, outputFile);
        }
        
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportFromGrid));
            this.btnCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ImportStyles = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbXls = new System.Windows.Forms.RadioButton();
            this.rdbXlsx = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.ImportStyles.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.Location = new System.Drawing.Point(555, 536);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(205, 45);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Import";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(3, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(757, 84);
            this.label2.TabIndex = 64;
            this.label2.Text = "Click the button to view an Excel spreadsheet generated by Essential XlsIO. Pleas" +
    "e note that MS Excel Viewer or MS Excel is required to view the resultant docume" +
    "nt.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(870, 109);
            this.pictureBox3.TabIndex = 75;
            this.pictureBox3.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(7, 213);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 20;
            this.dataGridView.Size = new System.Drawing.Size(537, 368);
            this.dataGridView.TabIndex = 76;
            // 
            // ImportStyles
            // 
            this.ImportStyles.Controls.Add(this.checkBox2);
            this.ImportStyles.Controls.Add(this.checkBox1);
            this.ImportStyles.Location = new System.Drawing.Point(555, 213);
            this.ImportStyles.Name = "ImportStyles";
            this.ImportStyles.Size = new System.Drawing.Size(205, 145);
            this.ImportStyles.TabIndex = 77;
            this.ImportStyles.TabStop = false;
            this.ImportStyles.Text = "Import Options";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(35, 94);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(120, 24);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Import Style";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(35, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Import Header";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbXls);
            this.groupBox1.Controls.Add(this.rdbXlsx);
            this.groupBox1.Location = new System.Drawing.Point(556, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 131);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save As";
            // 
            // rdbXls
            // 
            this.rdbXls.AutoSize = true;
            this.rdbXls.Location = new System.Drawing.Point(34, 40);
            this.rdbXls.Name = "rdbXls";
            this.rdbXls.Size = new System.Drawing.Size(65, 24);
            this.rdbXls.TabIndex = 1;
            this.rdbXls.TabStop = true;
            this.rdbXls.Text = "XLS";
            this.rdbXls.UseVisualStyleBackColor = true;
            // 
            // rdbXlsx
            // 
            this.rdbXlsx.AutoSize = true;
            this.rdbXlsx.Checked = true;
            this.rdbXlsx.Location = new System.Drawing.Point(34, 86);
            this.rdbXlsx.Name = "rdbXlsx";
            this.rdbXlsx.Size = new System.Drawing.Size(76, 24);
            this.rdbXlsx.TabIndex = 0;
            this.rdbXlsx.TabStop = true;
            this.rdbXlsx.Text = "XLSX";
            this.rdbXlsx.UseVisualStyleBackColor = true;
            // 
            // ImportFromGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 590);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ImportStyles);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ImportFromGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import From Grid";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ImportStyles.ResumeLayout(false);
            this.ImportStyles.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
            Application.Run(new ImportFromGrid());
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Path.GetFullPath("../../Data/MSExcelResaved.xlsx"));
        }


        private DataTable GetDataTable()
        {
            DataSet customersDataSet = new DataSet();
            //Get the path of the input file
            string inputXmlPath =GetFullTemplatePath("Customers.xml");
            customersDataSet.ReadXml(inputXmlPath);
            DataTable dataTable = new DataTable();
            dataTable = customersDataSet.Tables[0];
            dataTable.Columns.RemoveAt(4);
            return dataTable;
        }
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