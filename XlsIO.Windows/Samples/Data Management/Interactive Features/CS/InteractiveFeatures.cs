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
using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;
using System.IO;
namespace EssentialXlsIOSamples
{
    /// <summary>
    /// Summary description for InteractiveFeatures.
    /// </summary>
    public class InteractiveFeatures : MetroForm
    {
        #region Fields
        private System.Windows.Forms.Button btnCreate;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton rdbExcel2010;
        private RadioButton rdbExcel2007;
        private RadioButton rdbExcel97;
        private string fileName;
        private RadioButton rdbExcel2013;
        private PictureBox pictureBox2;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        #endregion

        #region Initialize
        public InteractiveFeatures()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.rdbExcel2013.Checked = true; 
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        #endregion

        #region Interactive Features
        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            #region Workbook Initialize
            //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;
            //Set the Default version as Excel 97to2003
            if (this.rdbExcel97.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel97to2003;
                fileName = "InteractiveFeatures.xls";
            }
            //Set the Default version as Excel 2007
            else if (this.rdbExcel2007.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel2007;
                fileName = "InteractiveFeatures.xlsx";
            }
            //Set the Default version as Excel 2010
            else if (this.rdbExcel2010.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel2010;
                fileName = "InteractiveFeatures.xlsx";
            }
            //Set the Default version as Excel 2013
            else if (this.rdbExcel2013.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel2013;
                fileName = "InteractiveFeatures.xlsx";
            }
            //A new workbook is created.[Equivalent to creating a new workbook in MS Excel]
            //The new workbook will have 3 worksheets
            IWorkbook workbook = application.Workbooks.Create(3);
            //The first worksheet object in the worksheets collection is accessed.
            IWorksheet sheet = workbook.Worksheets[0];
            #endregion

            sheet.IsGridLinesVisible = false;

            sheet.Range["B2"].Text = "Interactive features";
            sheet.Range["B2"].CellStyle.Font.Bold = true;
            sheet.Range["B2"].CellStyle.Font.Size = 14;

            sheet.Range["A4"].Text = "Some Useful links";
            sheet.Range["A4"].CellStyle.Font.Bold = true;
            sheet.Range["A4"].CellStyle.Font.Size = 12;

            sheet.Range["A20"].Text = "Comments";
            sheet.Range["A20"].CellStyle.Font.Bold = true;
            sheet.Range["A20"].CellStyle.Font.Size = 12;

            sheet.Range["B5"].Text = "Feature page";
            sheet.Range["B7"].Text = "Support Email Id";
            sheet.Range["B9"].Text = "Samples";
            sheet.Range["B11"].Text = "Read the comment about XlsIO";
            sheet.Range["B13"].Text = "Read the Comment about Interactive features";
            sheet.Range["B20"].Text = "XlsIO";
            sheet.Range["B22"].Text = "Interactive features";

            #region Hyperlink
            //Creating Hyperlink for a Website
            IHyperLink hyperlink = sheet.HyperLinks.Add(sheet.Range["C5"]);
            hyperlink.Type = ExcelHyperLinkType.Url;
            hyperlink.Address = "http://www.syncfusion.com/products/windows-forms/xlsio";
            hyperlink.ScreenTip = "To know more About XlsIO go through this link";

            //Creating Hyperlink for e-mail
            IHyperLink hyperlink1 = sheet.HyperLinks.Add(sheet.Range["C7"]);
            hyperlink1.Type = ExcelHyperLinkType.Url;
            hyperlink1.Address = "mailto:support@syncfusion.com";
            hyperlink1.ScreenTip = "Send Mail to this id for your queries";

            //Creating Hyperlink for Opening Files using type as  File
            IHyperLink hyperlink2 = sheet.HyperLinks.Add(sheet.Range["C9"]);
            hyperlink2.Type = ExcelHyperLinkType.File;

            hyperlink2.Address = "../../../";
            hyperlink2.ScreenTip = "File path";
            hyperlink2.TextToDisplay = "Hyperlink for files using File as type";

            //Creating Hyperlink to another cell using type as Workbook
            IHyperLink hyperlink4 = sheet.HyperLinks.Add(sheet.Range["C11"]);
            hyperlink4.Type = ExcelHyperLinkType.Workbook;
            hyperlink4.Address = "Sheet1!B20";
            hyperlink4.ScreenTip = "Click here";
            hyperlink4.TextToDisplay = "Click here to move to the cell with Comments about XlsIO";

            IHyperLink hyperlink5 = sheet.HyperLinks.Add(sheet.Range["C13"]);
            hyperlink5.Type = ExcelHyperLinkType.Workbook;
            hyperlink5.Address = "Sheet1!B22";
            hyperlink5.ScreenTip = "Click here";
            hyperlink5.TextToDisplay = "Click here to move to the cell with Comments about this sample";

            #endregion

            #region Comments

            //Insert Comments
            //Adding comments to a cell.
            sheet.Range["B20"].AddComment().Text = "XlsIO is a Backoffice product with high performance!";

            //Add RichText Comments
            IRange range = sheet.Range["B22"];
            range.AddComment().RichText.Text = "Great Sample!";
            IRichTextString rtf = range.Comment.RichText;

            //Formatting first 4 characters
            IFont greyFont = workbook.CreateFont();
            greyFont.Bold = true;
            greyFont.Italic = true;
            greyFont.RGBColor = Color.FromArgb(333365);
            rtf.SetFont(0, 3, greyFont);

            //Formatting last 4 characters
            IFont greenFont = workbook.CreateFont();
            greenFont.Bold = true;
            greenFont.Italic = true;
            greenFont.RGBColor = Color.Green;
            rtf.SetFont(4, 7, greenFont);

            //Set column width
            sheet.Columns[0].ColumnWidth = 30;

            #endregion

            #region Autofit the UsedRanges
			sheet.UsedRange.AutofitRows();
            sheet.UsedRange.AutofitColumns();
            #endregion

            #region Save the Workbook
            //Saving the workbook to disk.
            workbook.SaveAs(fileName);
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

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InteractiveFeatures));
            this.btnCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbExcel2013 = new System.Windows.Forms.RadioButton();
            this.rdbExcel2010 = new System.Windows.Forms.RadioButton();
            this.rdbExcel2007 = new System.Windows.Forms.RadioButton();
            this.rdbExcel97 = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.Location = new System.Drawing.Point(352, 166);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(85, 26);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(9, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 48);
            this.label2.TabIndex = 63;
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
            this.groupBox1.Size = new System.Drawing.Size(334, 37);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save As";
            // 
            // rdbExcel2013
            // 
            this.rdbExcel2013.AutoSize = true;
            this.rdbExcel2013.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExcel2013.Location = new System.Drawing.Point(248, 13);
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
            this.rdbExcel2010.Location = new System.Drawing.Point(164, 13);
            this.rdbExcel2010.Name = "rdbExcel2010";
            this.rdbExcel2010.Size = new System.Drawing.Size(78, 17);
            this.rdbExcel2010.TabIndex = 2;
            this.rdbExcel2010.TabStop = true;
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
            this.rdbExcel2007.TabStop = true;
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
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(639, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 65;
            this.pictureBox2.TabStop = false;
            // 
            // InteractiveFeatures
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(449, 208);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InteractiveFeatures";
            this.Text = "Interactive Features";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
            Application.Run(new InteractiveFeatures());
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
