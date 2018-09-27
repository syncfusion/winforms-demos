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
    /// Summary description for DocumentSettings.
    /// </summary>
    public class DocumentSettings : MetroForm
    {
        #region Constants
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\Common\Data\XlsIO\{0}";
        private const string DEFAULTIMAGEPATH = @"..\..\..\..\..\..\..\Common\Images\XlsIO\{0}";
        #endregion

        #region Fields
        private System.Windows.Forms.Button btnCreate;
        private PictureBox pictureBox1;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton btnExcel2010;
        private RadioButton btnExcel2007;
        private RadioButton btnExcel97;
        private string fileName;
        private RadioButton btnExcel2013;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        #endregion

        #region Initialize
        public DocumentSettings()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = true;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.btnExcel2013.Checked = true;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        #endregion

        #region Document Setting
        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            #region Workbook Initialize
            //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;
            //Set the default version as Excel 97to2003
            if (this.btnExcel97.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel97to2003;
                fileName = "DocumentSettingSample.xls";
            }
            //Set the default version as Excel 2007
            else if (this.btnExcel2007.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel2007;
                fileName = "DocumentSettingSample.xlsx";
            }
            //Set the default version as Excel 2010
            else if (this.btnExcel2010.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel2010;
                fileName = "DocumentSettingSample.xlsx";
            }
            //Set the default version as Excel 2010
            else if (this.btnExcel2013.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel2013;
                fileName = "DocumentSettingSample.xlsx";
            }

            //A new workbook is created.[Equivalent to creating a new workbook in MS Excel]
            //The new workbook will have 3 worksheets
            IWorkbook workbook = application.Workbooks.Create(3);
            //The first worksheet object in the worksheets collection is accessed.
            IWorksheet worksheet = workbook.Worksheets[0];
            #endregion

            #region Import Data From XML
            //Get order details 
            DataSet northwindData = new DataSet();
            //Get the path of XML file
            string xmlFilePath = GetFullTemplatePath("Orders.xml");
            northwindData.ReadXml(xmlFilePath, XmlReadMode.Auto);
            worksheet.ImportDataTable(northwindData.Tables["Orders"], true, 6, 1, -1, 9, false);
            #endregion

            # region Document Properties

            //Setting Builtin document Properties     
            workbook.Author = "Essential XlsIO";
            workbook.BuiltInDocumentProperties.ApplicationName = "Essential XlsIO";
            workbook.BuiltInDocumentProperties.Category = "Excel Generator";
            workbook.BuiltInDocumentProperties.Comments = "This document was generated using Essential XlsIO";
            workbook.BuiltInDocumentProperties.Company = "Syncfusion Inc.";
            workbook.BuiltInDocumentProperties.Subject = "Native Excel Generator";
            workbook.BuiltInDocumentProperties.Keywords = "Syncfusion";
            workbook.BuiltInDocumentProperties.Manager = "Sync Manager";
            workbook.BuiltInDocumentProperties.Title = "Essential XlsIO";

            //Setting Custom document Properties.
            ICustomDocumentProperties customProperites = workbook.CustomDocumentProperties;
            customProperites["Author"].Text = "Test Author";
            customProperites["Comments"].Text = "XlsIO support Custom document properties";
            customProperites["Double"].Double = 120.2;
            customProperites["Choice"].Boolean = true;
            customProperites["Today"].DateTime = DateTime.Today;
            customProperites["Integer"].Int32 = 1234;
            #endregion

            # region Header and Footer

            // Setting the Page number in the Center Header
            worksheet.PageSetup.CenterHeader = "&P";

            // Setting the Date in the Right Header
            worksheet.PageSetup.LeftHeader = "&D";
            // Setting the file name in the Center Footer
            worksheet.PageSetup.CenterFooter = "&F";
            // Setting the Sheet Name in the Left Footer
            worksheet.PageSetup.LeftFooter = "&A";

            //Get the path of the Image
            string imagePath = GetFullImagePath("logo.jpg");
            Image img = Image.FromFile(imagePath);
            // Right Header Image
            worksheet.PageSetup.RightHeaderImage = img;
            worksheet.PageSetup.RightHeader = "&G";

            worksheet.PageSetup.AutoFirstPageNumber = false;
            worksheet.PageSetup.FirstPageNumber = 2;

            #endregion

            # region Margin

            //Setting page Margins
            worksheet.PageSetup.LeftMargin = 2;
            worksheet.PageSetup.RightMargin = 2;
            worksheet.PageSetup.TopMargin = 2;
            worksheet.PageSetup.BottomMargin = 2;

            #endregion

            #region Page setup

            // Setting the Page Orientation as Portrait or Landscape	
            worksheet.PageSetup.Orientation = ExcelPageOrientation.Landscape;

            // Setting the Paper Type
            worksheet.PageSetup.PaperSize = ExcelPaperSize.PaperA4;

            #endregion

            # region Page break

            // Giving Horizontal pagebreaks 
            worksheet.HPageBreaks.Add(worksheet.Range["A105"]);
            worksheet.HPageBreaks.Add(worksheet.Range["A200"]);

            // Giving Vertical pagebreaks
            worksheet.VPageBreaks.Add(worksheet.Range["H100"]);

            #endregion

            #region Format Header rows
            worksheet.Range["D2"].Text = "Order Details";
            worksheet.Range["D2:E2"].Merge();
            worksheet.Range["D2"].CellStyle.Font.Size = 10;
            worksheet.Range["D2"].CellStyle.Font.Bold = true;
            worksheet.Range["D2"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;

            worksheet.Rows[4].CellStyle.Color = Color.FromArgb(182, 189, 218);
            worksheet.Rows[4].CellStyle.Font.Size = 10;
            worksheet.Rows[4].CellStyle.Font.Bold = true;

            worksheet.UsedRange.AutofitColumns();
            worksheet.IsGridLinesVisible = false;

            worksheet.Range["A4"].Text = "Note: Please check File->Properties for document properties and File->PageSetUp for page set up options";
            worksheet.Range["A4"].CellStyle.Font.Bold = true;

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

        /// <summary>
        /// Get the file path of image file and return the same
        /// </summary>
        /// <param name="inputPath">Image file</param>
        /// <returns>path of the image file</returns>
        private string GetFullImagePath(string inputFile)
        {
            return string.Format(DEFAULTIMAGEPATH, inputFile);
        }
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentSettings));
            this.btnCreate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcel2013 = new System.Windows.Forms.RadioButton();
            this.btnExcel2010 = new System.Windows.Forms.RadioButton();
            this.btnExcel2007 = new System.Windows.Forms.RadioButton();
            this.btnExcel97 = new System.Windows.Forms.RadioButton();
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
            this.btnCreate.Location = new System.Drawing.Point(344, 166);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(85, 26);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(639, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 48);
            this.label2.TabIndex = 63;
            this.label2.Text = "Click the button to view an Excel spreadsheet generated by Essential XlsIO. Pleas" +
                "e note that MS Excel Viewer or MS Excel is required to view the resultant docume" +
                "nt.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcel2013);
            this.groupBox1.Controls.Add(this.btnExcel2010);
            this.groupBox1.Controls.Add(this.btnExcel2007);
            this.groupBox1.Controls.Add(this.btnExcel97);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 37);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save As";
            // 
            // btnExcel2013
            // 
            this.btnExcel2013.AutoSize = true;
            this.btnExcel2013.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel2013.Location = new System.Drawing.Point(241, 13);
            this.btnExcel2013.Name = "btnExcel2013";
            this.btnExcel2013.Size = new System.Drawing.Size(78, 17);
            this.btnExcel2013.TabIndex = 3;
            this.btnExcel2013.Text = "Excel 2013";
            this.btnExcel2013.UseVisualStyleBackColor = true;
            // 
            // btnExcel2010
            // 
            this.btnExcel2010.AutoSize = true;
            this.btnExcel2010.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel2010.Location = new System.Drawing.Point(164, 13);
            this.btnExcel2010.Name = "btnExcel2010";
            this.btnExcel2010.Size = new System.Drawing.Size(78, 17);
            this.btnExcel2010.TabIndex = 2;
            this.btnExcel2010.Text = "Excel 2010";
            this.btnExcel2010.UseVisualStyleBackColor = true;
            // 
            // btnExcel2007
            // 
            this.btnExcel2007.AutoSize = true;
            this.btnExcel2007.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel2007.Location = new System.Drawing.Point(85, 13);
            this.btnExcel2007.Name = "btnExcel2007";
            this.btnExcel2007.Size = new System.Drawing.Size(78, 17);
            this.btnExcel2007.TabIndex = 1;
            this.btnExcel2007.Text = "Excel 2007";
            this.btnExcel2007.UseVisualStyleBackColor = true;
            // 
            // btnExcel97
            // 
            this.btnExcel97.AutoSize = true;
            this.btnExcel97.Checked = true;
            this.btnExcel97.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel97.Location = new System.Drawing.Point(6, 13);
            this.btnExcel97.Name = "btnExcel97";
            this.btnExcel97.Size = new System.Drawing.Size(78, 17);
            this.btnExcel97.TabIndex = 0;
            this.btnExcel97.TabStop = true;
            this.btnExcel97.Text = "Excel 2003";
            this.btnExcel97.UseVisualStyleBackColor = true;
            // 
            // DocumentSettings
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(436, 208);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DocumentSettings";
            this.Text = "Document Settings";
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
            Application.Run(new DocumentSettings());
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
