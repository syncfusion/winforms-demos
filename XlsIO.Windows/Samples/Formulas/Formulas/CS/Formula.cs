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
    /// Summary description for Formulas.
    /// </summary>
    public class Formulas : MetroForm
    {
        #region Constants
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\Common\Data\XlsIO\{0}";
        #endregion

        #region Fields
        private System.Windows.Forms.Button btnWriteFormula;
        private System.Windows.Forms.Label label1;
        private Button btnReadFormula;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txtFormula;
        private Label label3;
        private TextBox txtFomulaNumber;
        private PictureBox pictureBox1;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        #endregion

        #region Initialize
        public Formulas()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;            
            this.StartPosition = FormStartPosition.CenterScreen;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        #endregion

        #region Write Formula
        private void btnWriteFormual_Click(object sender, System.EventArgs e)
        {
            #region Workbook Initialize
            //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;

            //A new workbook is created.[Equivalent to creating a new workbook in MS Excel]
            //The new workbook will have 3 worksheets
            IWorkbook workbook = application.Workbooks.Create(3);
            //The first worksheet object in the worksheets collection is accessed.
            IWorksheet worksheet = workbook.Worksheets[0];
            #endregion

            #region Insert Array Formula

            worksheet.Range["A2"].Text = "Array formulas";
            worksheet.Range["B2:E2"].FormulaArray = "{10,20,30,40}";
            worksheet.Names.Add("ArrayRange", worksheet.Range["B2:E2"]);
            worksheet.Range["B3:E3"].FormulaArray = "ArrayRange+100";
            worksheet.Range["A2"].CellStyle.Font.Bold = true;
            worksheet.Range["A2"].CellStyle.Font.Size = 14;

            #endregion

            #region Excel functions

            worksheet.Range["A5"].Text = "Formula";
            worksheet.Range["B5"].Text = "Result";

            worksheet.Range["A7"].Text = "ABS(ABS(-B3))";
            worksheet.Range["B7"].Formula = "ABS(ABS(-B3))";

            worksheet.Range["A9"].Text = "SUM(B3,C3)";
            worksheet.Range["B9"].Formula = "SUM(B3,C3)";

            worksheet.Range["A11"].Text = "MIN({10,20,30;5,15,35;6,16,36})";
            worksheet.Range["B11"].Formula = "MIN({10,20,30;5,15,35;6,16,36})";

            worksheet.Range["A13"].Text = "LOOKUP(B3,B3:E8)";
            worksheet.Range["B13"].Formula = "LOOKUP(B3,B3:E3)";

            worksheet.Range["A5:B5"].CellStyle.Font.Bold = true;
            worksheet.Range["A5:B5"].CellStyle.Font.Size = 14;

            #endregion

            #region Simple formulas
            worksheet.Range["C7"].Number = 10;
            worksheet.Range["C9"].Number = 10;
            worksheet.Range["A15"].Text = "C7+C9";
            worksheet.Range["B15"].Formula = "C7+C9";

            #endregion

            worksheet.Range["B1"].Text = "Excel formula support";
            worksheet.Range["B1"].CellStyle.Font.Bold = true;
            worksheet.Range["B1"].CellStyle.Font.Size = 14;
            worksheet.Range["B1:E1"].Merge();
            worksheet.Range["A1:A15"].AutofitColumns();

            #region Workbook Save
            //Saving the workbook to disk.
            workbook.SaveAs("WriteFormula.xls");
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
                System.Diagnostics.Process.Start("WriteFormula.xls");

            }
            #endregion


        }
        #endregion

        #region ReadFormula
        private void btnReadFormula_Click(object sender, EventArgs e)
        {
            #region Workbook Initialize
            //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;

            //Get the Path of the input File
            string inputPath = GetFullTemplatePath("FormulaTemplate.xls");
            //Open the workbook
            IWorkbook workbook = application.Workbooks.Open(inputPath);

            //The first worksheet object in the worksheets collection is accessed.
            IWorksheet worksheet = workbook.Worksheets[0];
            #endregion

            #region Formula and Computed value
            //Read computed Formula Value. 
            this.txtFomulaNumber.Text = worksheet.Range["C1"].FormulaNumberValue.ToString();

            //Read Formula
            this.txtFormula.Text = worksheet.Range["C1"].Formula;
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

        #region HelperMethods
        /// <summary>
        /// Get the path of the passed inputfile and return the same
        /// </summary>
        /// <param name="inputPath">Input file</param>
        /// <returns> Path of the input file</returns>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulas));
            this.btnWriteFormula = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReadFormula = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFomulaNumber = new System.Windows.Forms.TextBox();
            this.txtFormula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWriteFormula
            // 
            this.btnWriteFormula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWriteFormula.BackColor = System.Drawing.Color.Transparent;
            this.btnWriteFormula.Image = ((System.Drawing.Image)(resources.GetObject("btnWriteFormula.Image")));
            this.btnWriteFormula.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWriteFormula.Location = new System.Drawing.Point(244, 209);
            this.btnWriteFormula.Name = "btnWriteFormula";
            this.btnWriteFormula.Size = new System.Drawing.Size(99, 26);
            this.btnWriteFormula.TabIndex = 0;
            this.btnWriteFormula.Text = "Write Formula";
            this.btnWriteFormula.UseVisualStyleBackColor = false;
            this.btnWriteFormula.Click += new System.EventHandler(this.btnWriteFormual_Click);
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
            // btnReadFormula
            // 
            this.btnReadFormula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReadFormula.BackColor = System.Drawing.Color.Transparent;
            this.btnReadFormula.Image = ((System.Drawing.Image)(resources.GetObject("btnReadFormula.Image")));
            this.btnReadFormula.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReadFormula.Location = new System.Drawing.Point(227, 46);
            this.btnReadFormula.Name = "btnReadFormula";
            this.btnReadFormula.Size = new System.Drawing.Size(99, 26);
            this.btnReadFormula.TabIndex = 2;
            this.btnReadFormula.Text = "Read Formula";
            this.btnReadFormula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReadFormula.UseVisualStyleBackColor = false;
            this.btnReadFormula.Click += new System.EventHandler(this.btnReadFormula_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Computed value";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFomulaNumber);
            this.groupBox1.Controls.Add(this.txtFormula);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnReadFormula);
            this.groupBox1.Location = new System.Drawing.Point(17, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 80);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Read Formula from the template document";
            // 
            // txtFomulaNumber
            // 
            this.txtFomulaNumber.Location = new System.Drawing.Point(96, 19);
            this.txtFomulaNumber.Name = "txtFomulaNumber";
            this.txtFomulaNumber.ReadOnly = true;
            this.txtFomulaNumber.Size = new System.Drawing.Size(122, 20);
            this.txtFomulaNumber.TabIndex = 7;
            // 
            // txtFormula
            // 
            this.txtFormula.Location = new System.Drawing.Point(96, 49);
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.ReadOnly = true;
            this.txtFormula.Size = new System.Drawing.Size(122, 20);
            this.txtFormula.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Formula String";
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
            // Formulas
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 244);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWriteFormula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Formulas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
            Application.Run(new Formulas());
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
