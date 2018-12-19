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
    /// Summary description for WorksheetProtection.
    /// </summary>
    public class WorksheetProtection : MetroForm
    {
        #region Fields
        private System.Windows.Forms.Button btnWorksheetLock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWorksheetUnlock;
        private PictureBox pictureBox1;
        private Label label2;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        #endregion

        #region Initialize
        public WorksheetProtection()
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

        #region Worksheet Lock
        private void btnWorksheetLock_Click(object sender, System.EventArgs e)
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

            #region Insert Data
            worksheet.Range["C5"].Text = "Worksheet protected with password 'syncfusion'";
            worksheet.Range["C6"].Text = "You can't edit any cells other than A1 and A2";
            worksheet.Range["C5"].CellStyle.Font.Bold = true;
            worksheet.Range["C5"].CellStyle.Font.Size = 12;

            worksheet.Range["C6"].CellStyle.Font.Bold = true;
            worksheet.Range["C6"].CellStyle.Font.Size = 12;

            worksheet.Range["C8"].Text = "For Excel 2003: Click 'Tools->Protection' to Unprotect the sheet.";
            worksheet.Range["C8"].CellStyle.Font.Bold = true;
            worksheet.Range["C8"].CellStyle.Font.Size = 12;

            worksheet.Range["C10"].Text = "For Excel 2007 and above: Click 'Review Tab->Unprotect Sheet' to Unprotect the sheet.";
            worksheet.Range["C10"].CellStyle.Font.Bold = true;
            worksheet.Range["C10"].CellStyle.Font.Size = 12;

            worksheet.Range["A1:A2"].Text = "You can edit this cell";
            worksheet.Range["A1:A2"].CellStyle.Font.Bold = true;
            #endregion

            #region Protect Sheet
            //Protecting Worksheet using Password
            worksheet.Protect("syncfusion");

            //Unlocking the cells which are needed to be edited
            worksheet.Range["A1"].CellStyle.Locked = false;
            worksheet.Range["A2"].CellStyle.Locked = false;
            #endregion

            #region Save the Workbook
            //Saving the workbook to disk.
            workbook.SaveAs("ProtectedSheet.xls");

            btnWorksheetLock.Enabled = false;
            btnWorksheetUnlock.Enabled = true;
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
                System.Diagnostics.Process.Start("ProtectedSheet.xls");
            }
            #endregion
        }
        #endregion

        #region Worksheet Unlock
        private void btnWorksheetUnlock_Click(object sender, System.EventArgs e)
        {
            #region Workbook Initialize
            //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;

            // Opening a Existing(Protected) Worksheet from a Workbook
            IWorkbook workbook = application.Workbooks.Open(@"ProtectedSheet.xls");
            //The first worksheet object in the worksheets collection is accessed.
            IWorksheet worksheet = workbook.Worksheets[0];
            #endregion

            #region Unprotect the Worksheet
            //Unprotecting( unlocking) Worksheet using the Password
            worksheet.Unprotect("syncfusion");
            #endregion

            #region Insert Data
            worksheet.Range["C5"].Text = "Worksheet is Unprotected with password 'syncfusion' and changes are done";
            worksheet.Range["C6"].Text = "You can edit any cell";
            worksheet.Range["A1:A2"].Text = " ";

            worksheet.Range["C5"].CellStyle.Font.Bold = true;
            worksheet.Range["C5"].CellStyle.Font.Size = 12;

            worksheet.Range["C8"].Text = "For Excel 2003: Click 'Tools->Protection' to view the Protection settings.";
            worksheet.Range["C8"].CellStyle.Font.Bold = true;
            worksheet.Range["C8"].CellStyle.Font.Size = 12;

            worksheet.Range["C10"].Text = "For Excel 2007 and above: Click 'Review Tab->Protect Sheet' to view the Protection settings.";
            worksheet.Range["C10"].CellStyle.Font.Bold = true;
            worksheet.Range["C10"].CellStyle.Font.Size = 12;
            #endregion

            #region Save the Workbook
            //Saving the workbook to disk.
            workbook.SaveAs("UnlockedWorksheet.xls");
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
                System.Diagnostics.Process.Start("UnlockedWorksheet.xls");
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorksheetProtection));
            this.btnWorksheetLock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWorksheetUnlock = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWorksheetLock
            // 
            this.btnWorksheetLock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWorksheetLock.BackColor = System.Drawing.Color.Transparent;
            this.btnWorksheetLock.Image = ((System.Drawing.Image)(resources.GetObject("btnWorksheetLock.Image")));
            this.btnWorksheetLock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWorksheetLock.Location = new System.Drawing.Point(26, 188);
            this.btnWorksheetLock.Name = "btnWorksheetLock";
            this.btnWorksheetLock.Size = new System.Drawing.Size(144, 26);
            this.btnWorksheetLock.TabIndex = 0;
            this.btnWorksheetLock.Text = "Worksheet Locking";
            this.btnWorksheetLock.UseVisualStyleBackColor = false;
            this.btnWorksheetLock.Click += new System.EventHandler(this.btnWorksheetLock_Click);
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
            // btnWorksheetUnlock
            // 
            this.btnWorksheetUnlock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWorksheetUnlock.BackColor = System.Drawing.Color.Transparent;
            this.btnWorksheetUnlock.Enabled = false;
            this.btnWorksheetUnlock.Image = ((System.Drawing.Image)(resources.GetObject("btnWorksheetUnlock.Image")));
            this.btnWorksheetUnlock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWorksheetUnlock.Location = new System.Drawing.Point(176, 188);
            this.btnWorksheetUnlock.Name = "btnWorksheetUnlock";
            this.btnWorksheetUnlock.Size = new System.Drawing.Size(152, 26);
            this.btnWorksheetUnlock.TabIndex = 2;
            this.btnWorksheetUnlock.Text = "Worksheet Unlocking";
            this.btnWorksheetUnlock.UseVisualStyleBackColor = false;
            this.btnWorksheetUnlock.Click += new System.EventHandler(this.btnWorksheetUnlock_Click);
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
            this.label2.Location = new System.Drawing.Point(0, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 48);
            this.label2.TabIndex = 63;
            this.label2.Text = "Click the button to view an Excel spreadsheet generated by Essential XlsIO. Pleas" +
                "e note that MS Excel Viewer or MS Excel is required to view the resultant docume" +
                "nt.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WorksheetProtection
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 226);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnWorksheetUnlock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWorksheetLock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WorksheetProtection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Worksheet Protection";
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
            Application.Run(new WorksheetProtection());
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
