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
using Syncfusion.Licensing;
using System.IO;
namespace EssentialXlsIOSamples
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class WorksheetManagement : MetroForm
    {
        #region Constants
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\Common\Data\XlsIO\{0}";
        #endregion

        #region Fields
        private System.Windows.Forms.Button btnCreate;
        private PictureBox pictureBox1;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton rdbExcel2010;
        private RadioButton rdbExcel2007;
        private RadioButton rdbExcel97;
        private string fileName;
        private Button viewInputTemplate;
        private RadioButton rdbExcel2013;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        #endregion

        #region Initialize
        public WorksheetManagement()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = true;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        #endregion

        #region Worksheet Management
        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            #region Workbook Initialization
            //New instance of Excel is created.[Equivalent to launching MS Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel object.
            IApplication application = excelEngine.Excel;
            application.DefaultVersion = ExcelVersion.Excel2013;
            //Get the file path of the Input file
            string inputPath = GetFullTemplatePath("SourceWorkbookTemplate.xlsx");

            //Open the Source WorkBook	
            IWorkbook sourceWorkbook = application.Workbooks.Open(inputPath);

            //Add a WorkBook	
            IWorkbook destinationWorkbook = application.Workbooks.Add();
            #endregion

            #region Workbook Management
            //Copy the first worksheet from Source workbook to destination workbook.
            destinationWorkbook.Worksheets.AddCopy(sourceWorkbook.Worksheets[0], ExcelWorksheetCopyFlags.CopyAll);

            //Copy the first worksheet from Source workbook to destination workbook. This will copy only shapes[images and comments]in the source worksheet
            destinationWorkbook.Worksheets.AddCopy(sourceWorkbook.Worksheets[0], ExcelWorksheetCopyFlags.CopyShapes | ExcelWorksheetCopyFlags.CopyConditionlFormats | ExcelWorksheetCopyFlags.CopyColumnHeight | ExcelWorksheetCopyFlags.CopyDataValidations);

            //Rename the copied worksheet.
            destinationWorkbook.Worksheets[3].Name = "Copied_Worksheet";
            destinationWorkbook.Worksheets[4].Name = "Copied_Shapes_ConditionalFormats_Datavalidation";
            destinationWorkbook.Worksheets[4].Range["B3"].Text = "This worksheet contains shapes[comments and images],Conditional formats and data validations[No Number format/styles will be copied]";
            destinationWorkbook.Worksheets[4].Range["B3"].CellStyle.Font.Bold = true;

            //Move the copied worksheet to specified index.
            destinationWorkbook.Worksheets[3].Move(0);
            destinationWorkbook.Worksheets[4].Move(0);

            //Remove unwanted worksheets
            destinationWorkbook.Worksheets[3].Remove();
            destinationWorkbook.Worksheets[3].Remove();
            destinationWorkbook.Worksheets[2].Remove();

            //Activate the moved worksheet in the destination workbook.
            destinationWorkbook.ActiveSheetIndex = 1;
            #endregion

            #region Save Workbook

            //Set the default version as Excel 97to2003
            if (this.rdbExcel97.Checked)
            {
                destinationWorkbook.Version = ExcelVersion.Excel97to2003;
                fileName = "WorksheetManagement.xls";
            }
            //Set the default version as Excel 2007
            else if (this.rdbExcel2007.Checked)
            {
                destinationWorkbook.Version = ExcelVersion.Excel2007;
                fileName = "WorksheetManagement.xlsx";
            }
            //Set the default version as Excel 2010
            else if (this.rdbExcel2010.Checked)
            {
                destinationWorkbook.Version = ExcelVersion.Excel2010;
                fileName = "WorksheetManagement.xlsx";
            }
            else if (this.rdbExcel2013.Checked)
            {
                destinationWorkbook.Version = ExcelVersion.Excel2013;
                fileName = "WorksheetManagement.xlsx";
            }
            //Saving the workbook to disk.
            destinationWorkbook.SaveAs(fileName);
            #endregion

            #region Workbook Close and Dispose
            //Close the workbook.
            sourceWorkbook.Close();
            destinationWorkbook.Close();

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

        #region View the Input file
        private void viewInputTemplate_Click(object sender, EventArgs e)
        {
            //Get the path of the input file
            string inputPath = GetFullTemplatePath("SourceWorkbookTemplate.xls");
            //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
            System.Diagnostics.Process.Start(inputPath);
        }
        #endregion

        #region HelperMethods
        /// <summary>
        /// Get the input file and return the file path of the input
        /// </summary>
        /// <param name="inputPath">Input file</param>
        /// <returns>Path of the input file</returns>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorksheetManagement));
            this.btnCreate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbExcel2013 = new System.Windows.Forms.RadioButton();
            this.rdbExcel2010 = new System.Windows.Forms.RadioButton();
            this.rdbExcel2007 = new System.Windows.Forms.RadioButton();
            this.rdbExcel97 = new System.Windows.Forms.RadioButton();
            this.viewInputTemplate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.Location = new System.Drawing.Point(266, 206);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(90, 26);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
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
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 48);
            this.label2.TabIndex = 64;
            this.label2.Text = "Click the button to view an Excel spreadsheet generated by Essential XlsIO. Pleas" +
                "e note that MS Excel Viewer or MS Excel is required to view the resultant docume" +
                "nt.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbExcel2013);
            this.groupBox1.Controls.Add(this.rdbExcel2010);
            this.groupBox1.Controls.Add(this.rdbExcel2007);
            this.groupBox1.Controls.Add(this.rdbExcel97);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 38);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save As";
            // 
            // rdbExcel2013
            // 
            this.rdbExcel2013.AutoSize = true;
            this.rdbExcel2013.Checked = true;
            this.rdbExcel2013.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExcel2013.Location = new System.Drawing.Point(260, 13);
            this.rdbExcel2013.Name = "rdbExcel2013";
            this.rdbExcel2013.Size = new System.Drawing.Size(78, 17);
            this.rdbExcel2013.TabIndex = 3;
            this.rdbExcel2013.TabStop = true;
            this.rdbExcel2013.Text = "Excel 2013";
            this.rdbExcel2013.UseVisualStyleBackColor = true;
            // 
            // rdbExcel2010
            // 
            this.rdbExcel2010.AutoSize = true;
            this.rdbExcel2010.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExcel2010.Location = new System.Drawing.Point(176, 15);
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
            this.rdbExcel2007.Location = new System.Drawing.Point(92, 15);
            this.rdbExcel2007.Name = "rdbExcel2007";
            this.rdbExcel2007.Size = new System.Drawing.Size(78, 17);
            this.rdbExcel2007.TabIndex = 1;
            this.rdbExcel2007.Text = "Excel 2007";
            this.rdbExcel2007.UseVisualStyleBackColor = true;
            // 
            // rdbExcel97
            // 
            this.rdbExcel97.AutoSize = true;
            this.rdbExcel97.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExcel97.Location = new System.Drawing.Point(9, 15);
            this.rdbExcel97.Name = "rdbExcel97";
            this.rdbExcel97.Size = new System.Drawing.Size(78, 17);
            this.rdbExcel97.TabIndex = 0;
            this.rdbExcel97.Text = "Excel 2003";
            this.rdbExcel97.UseVisualStyleBackColor = true;
            // 
            // viewInputTemplate
            // 
            this.viewInputTemplate.Location = new System.Drawing.Point(159, 206);
            this.viewInputTemplate.Name = "viewInputTemplate";
            this.viewInputTemplate.Size = new System.Drawing.Size(90, 26);
            this.viewInputTemplate.TabIndex = 68;
            this.viewInputTemplate.Text = "Input Template";
            this.viewInputTemplate.UseVisualStyleBackColor = true;
            this.viewInputTemplate.Click += new System.EventHandler(this.viewInputTemplate_Click);
            // 
            // WorksheetManagement
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 238);
            this.Controls.Add(this.viewInputTemplate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCreate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "WorksheetManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Worksheet Management";
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
            Application.EnableVisualStyles();
            Application.Run(new WorksheetManagement());
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
