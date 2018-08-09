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
    /// Summary description for WorkbookProtection.
    /// </summary>
    public class WorkbookProtection : MetroForm
    {
        #region Fields
        private System.Windows.Forms.Button btnProtectWorkbook;
        private System.Windows.Forms.Label label1;
        private Button btnUnprotectWorkbook;
        private PictureBox pictureBox1;
        private Label label2;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        #endregion

        #region Initialize
        public WorkbookProtection()
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

        #region Workbook Protection and UnProtection
        private void btnProtectWorkbook_Click(object sender, System.EventArgs e)
        {
            #region Workbook Initialize
            //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;

            // Opening the Existing Worksheet from a Workbook
            IWorkbook workbook = application.Workbooks.Create(1);

            //The first worksheet object in the worksheets collection is accessed.
            IWorksheet worksheet = workbook.Worksheets[0];
            #endregion

            #region Protect Workbook
            worksheet.Range["C5"].Text = "Workbook is protected with password 'syncfusion'";
            worksheet.Range["C6"].Text = "You can't make changes to structure and window of the workbook.";
            worksheet.Range["C5"].CellStyle.Font.Bold = true;
            worksheet.Range["C5"].CellStyle.Font.Size = 12;

            worksheet.Range["C6"].CellStyle.Font.Bold = true;
            worksheet.Range["C6"].CellStyle.Font.Size = 12;

            worksheet.Range["C8"].Text = "For Excel 2003: Click 'Tools->Protection' to Unprotect the workbook.";
            worksheet.Range["C8"].CellStyle.Font.Bold = true;
            worksheet.Range["C8"].CellStyle.Font.Size = 12;

            worksheet.Range["C10"].Text = "For Excel 2007 and above: Click 'Review Tab->Protect Workbook' to Unprotect the workbook.";
            worksheet.Range["C10"].CellStyle.Font.Bold = true;
            worksheet.Range["C10"].CellStyle.Font.Size = 12;

            workbook.Protect(true, true, "syncfusion");
            #endregion

            #region Save the Workbook
            //Saving the workbook to disk.
            workbook.SaveAs("ProtectedWorkbook.xls");

            btnProtectWorkbook.Enabled = false;
            btnUnprotectWorkbook.Enabled = true;
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
                System.Diagnostics.Process.Start("ProtectedWorkbook.xls");

            }
            #endregion

        }

        private void btnUnprotect_Click(object sender, EventArgs e)
        {
            #region Workbook Initialize
            //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;

            // Opening a Existing(Protected) Worksheet from a Workbook
            IWorkbook workbook = application.Workbooks.Open(@"ProtectedWorkbook.xls");
            #endregion

            #region Unprotect the workbook
            //Unprotecting( unlocking) Workbook using the Password
            workbook.Unprotect("syncfusion");
            #endregion

            #region Modify the Datas
            //The first worksheet object in the worksheets collection is accessed.
            IWorksheet sheet = workbook.Worksheets[0];

            sheet.Range["C5"].Text = "Workbook is Unprotected with password 'syncfusion' and changes are done";
            sheet.Range["C6"].Text = "You can now edit the structure and window of this workbook.";

            sheet.Range["C5"].CellStyle.Font.Bold = true;
            sheet.Range["C5"].CellStyle.Font.Size = 12;

            sheet.Range["C8"].Text = "For Excel 2003: Click 'Tools->Protection' to view the Protection settings.";
            sheet.Range["C8"].CellStyle.Font.Bold = true;
            sheet.Range["C8"].CellStyle.Font.Size = 12;

            sheet.Range["C10"].Text = "For Excel 2007 and above: Click 'Review Tab->Protect Workbook' to view the Protection settings.";
            sheet.Range["C10"].CellStyle.Font.Bold = true;
            sheet.Range["C10"].CellStyle.Font.Size = 12;
            #endregion

            #region Save the Workbook
            //Saving the workbook to disk.
            workbook.SaveAs("UnProtectedWorkbook.xls");
            #endregion

            #region Workbook Close and Dispose
            //Close the workbook.
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
                System.Diagnostics.Process.Start("UnProtectedWorkbook.xls");
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

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkbookProtection));
            this.btnProtectWorkbook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUnprotectWorkbook = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProtectWorkbook
            // 
            this.btnProtectWorkbook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProtectWorkbook.BackColor = System.Drawing.Color.Transparent;
            this.btnProtectWorkbook.Image = ((System.Drawing.Image)(resources.GetObject("btnProtectWorkbook.Image")));
            this.btnProtectWorkbook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProtectWorkbook.Location = new System.Drawing.Point(47, 188);
            this.btnProtectWorkbook.Name = "btnProtectWorkbook";
            this.btnProtectWorkbook.Size = new System.Drawing.Size(126, 26);
            this.btnProtectWorkbook.TabIndex = 0;
            this.btnProtectWorkbook.Text = "Protect Workbook";
            this.btnProtectWorkbook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProtectWorkbook.UseVisualStyleBackColor = false;
            this.btnProtectWorkbook.Click += new System.EventHandler(this.btnProtectWorkbook_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btnUnprotectWorkbook
            // 
            this.btnUnprotectWorkbook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnprotectWorkbook.BackColor = System.Drawing.Color.Transparent;
            this.btnUnprotectWorkbook.Enabled = false;
            this.btnUnprotectWorkbook.Image = ((System.Drawing.Image)(resources.GetObject("btnUnprotectWorkbook.Image")));
            this.btnUnprotectWorkbook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUnprotectWorkbook.Location = new System.Drawing.Point(188, 188);
            this.btnUnprotectWorkbook.Name = "btnUnprotectWorkbook";
            this.btnUnprotectWorkbook.Size = new System.Drawing.Size(126, 26);
            this.btnUnprotectWorkbook.TabIndex = 2;
            this.btnUnprotectWorkbook.Text = "Unprotect Workbook";
            this.btnUnprotectWorkbook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnprotectWorkbook.UseVisualStyleBackColor = false;
            this.btnUnprotectWorkbook.Click += new System.EventHandler(this.btnUnprotect_Click);
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
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 48);
            this.label2.TabIndex = 63;
            this.label2.Text = "Click the button to view an Excel spreadsheet generated by Essential XlsIO. Pleas" +
                "e note that MS Excel Viewer or MS Excel is required to view the resultant docume" +
                "nt.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WorkbookProtection
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 226);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUnprotectWorkbook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProtectWorkbook);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorkbookProtection";
            this.Text = "Workbook Protection";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
            Application.Run(new WorkbookProtection());
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
