#region Copyright Syncfusion Inc. 2001-2022
//
//  Copyright Syncfusion Inc. 2001-2022. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Diagnostics;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms;
using System.IO;
using Syncfusion.Licensing;

namespace EssentialXlsIOSamples
{
    /// <summary>
    /// Summary description for Formulas.
    /// </summary>
    public class ExternalFormulas : MetroForm
    {
        #region Constants
#if NETCORE
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\common\Data\XlsIO\";
#else
        private const string DEFAULTPATH = @"..\..\..\..\..\..\common\Data\XlsIO\";
#endif
        #endregion

        #region Fields
        private System.Windows.Forms.Button btnWriteFormula;
        private System.Windows.Forms.Label label1;
        private Button btnReadFormula;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox txtFormula;
        private TextBox txtFomulaNumber;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        #endregion

        #region Initialize
        public ExternalFormulas()
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
            ////New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            ////The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;

            //Open the workbook
            IWorkbook workbook = application.Workbooks.Create(1);

            //The first worksheet object in the worksheets collection is accessed.
            IWorksheet worksheet = workbook.Worksheets[0];
            #endregion

            string fullPath = Path.GetFullPath(DEFAULTPATH);
 
            //External formula from another workboook
            worksheet.Range["A1"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$A$1";
            worksheet.Range["A2"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$A$2";
            worksheet.Range["A3"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$A$3";
            worksheet.Range["A4"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$A$4";
            worksheet.Range["A5"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$A$5";
            worksheet.Range["A6"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$A$6";
            worksheet.Range["A7"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$A$7";
            worksheet.Range["B1"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$B$1";
            worksheet.Range["B2"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$B$2";
            worksheet.Range["B3"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$B$3";
            worksheet.Range["B4"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$B$4";
            worksheet.Range["B5"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$B$5";
            worksheet.Range["B6"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$B$6";
            worksheet.Range["C1"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$C$1";
            worksheet.Range["C2"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$C$2";
            worksheet.Range["C3"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$C$3";
            worksheet.Range["C4"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$C$4";
            worksheet.Range["C5"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$C$5";
            worksheet.Range["C6"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$C$6";
            worksheet.Range["D1"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$D$1";
            worksheet.Range["D2"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$D$2";
            worksheet.Range["D3"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$D$3";
            worksheet.Range["D4"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$D$4";
            worksheet.Range["D5"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$D$5";
            worksheet.Range["D6"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$D$6";
            worksheet.Range["E1"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$E$1";
            worksheet.Range["E2"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$E$2";
            worksheet.Range["E3"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$E$3";
            worksheet.Range["E4"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$E$4";
            worksheet.Range["E5"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$E$5";
            worksheet.Range["E6"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$E$6";
            worksheet.Range["F1"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$F$1";
            worksheet.Range["B7"].Formula = "=SUM(B2:B6)";
            worksheet.Range["C7"].Formula = "=SUM(C2:C6)";
            worksheet.Range["D7"].Formula = "=SUM(D2:D6)";
            worksheet.Range["E7"].Formula = "=SUM(E2:E6)";
            worksheet.Range["F7"].Formula = "=SUM(F2:F6)";
            worksheet.Range["F2"].Formula = "=B2*C2+D2-E2";
            worksheet.Range["F3"].Formula = "=B3*C3+D3-E3";
            worksheet.Range["F4"].Formula = "=B4*C4+D4-E4";
            worksheet.Range["F5"].Formula = "=B5*C5+D5-E5";
            worksheet.Range["F6"].Formula = "=B6*C6+D6-E6";
            worksheet.Range["A1:F7"].CellStyle.Font.FontName = "Verdana";
            worksheet.Range["C2:F7"].NumberFormat = "_($* #,##0.00_)";
            worksheet.Range["A1:F1"].CellStyle.Color = System.Drawing.Color.FromArgb(0, 0, 112, 192);
            worksheet.Range["A7:F7"].CellStyle.Color = System.Drawing.Color.FromArgb(0, 0, 112, 192);
            worksheet.Range["A1:F1"].CellStyle.Font.Bold = true;
            worksheet.Range["A1:F1"].CellStyle.Font.Size = 11;
            worksheet.Columns[0].ColumnWidth = 17;
            worksheet.Columns[1].ColumnWidth = 13;
            worksheet.Columns[2].ColumnWidth = 11;
            worksheet.Columns[3].ColumnWidth = 11;
            worksheet.Columns[4].ColumnWidth = 13;
            worksheet.Columns[5].ColumnWidth = 13;
                        
            worksheet.Calculate();
            #region Workbook Save
            //Saving the workbook to disk.
            workbook.SaveAs("ExternalFormula.xlsx");
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
#if NETCORE
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo = new System.Diagnostics.ProcessStartInfo("ExternalFormula.xlsx")
                {
                    UseShellExecute = true
                };
                process.Start();
#else
                Process.Start("ExternalFormula.xlsx");
#endif

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

            //Open the workbook
            IWorkbook workbook = application.Workbooks.Create(1);

            //The first worksheet object in the worksheets collection is accessed.
            IWorksheet worksheet = workbook.Worksheets[0];
            #endregion

            string fullPath = Path.GetFullPath(DEFAULTPATH);

            //External formula from another workboook
            worksheet.Range["A1"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$A$1";

            worksheet.EnableSheetCalculations();

            #region Formula and Computed value
            //Read computed Formula Value. 
            this.txtFomulaNumber.Text = worksheet.Range["A1"].CalculatedValue;

            //Read Formula
            this.txtFormula.Text = worksheet.Range["A1"].Formula;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExternalFormulas));
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
            this.btnWriteFormula.Location = new System.Drawing.Point(426, 123);
            this.btnWriteFormula.Name = "btnWriteFormula";
            this.btnWriteFormula.Size = new System.Drawing.Size(159, 33);
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
            this.label1.Size = new System.Drawing.Size(633, 82);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btnReadFormula
            // 
            this.btnReadFormula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReadFormula.BackColor = System.Drawing.Color.Transparent;
            this.btnReadFormula.Image = ((System.Drawing.Image)(resources.GetObject("btnReadFormula.Image")));
            this.btnReadFormula.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReadFormula.Location = new System.Drawing.Point(427, 74);
            this.btnReadFormula.Name = "btnReadFormula";
            this.btnReadFormula.Size = new System.Drawing.Size(159, 33);
            this.btnReadFormula.TabIndex = 2;
            this.btnReadFormula.Text = "Read Formula";
            this.btnReadFormula.UseVisualStyleBackColor = false;
            this.btnReadFormula.Click += new System.EventHandler(this.btnReadFormula_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Computed value";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFomulaNumber);
            this.groupBox1.Controls.Add(this.txtFormula);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnWriteFormula);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnReadFormula);
            this.groupBox1.Location = new System.Drawing.Point(18, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 171);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Read External Formula from the template document";
            // 
            // txtFomulaNumber
            // 
            this.txtFomulaNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFomulaNumber.Location = new System.Drawing.Point(147, 124);
            this.txtFomulaNumber.Multiline = true;
            this.txtFomulaNumber.Name = "txtFomulaNumber";
            this.txtFomulaNumber.ReadOnly = true;
            this.txtFomulaNumber.Size = new System.Drawing.Size(258, 30);
            this.txtFomulaNumber.TabIndex = 7;
            // 
            // txtFormula
            // 
            this.txtFormula.Location = new System.Drawing.Point(147, 29);
            this.txtFormula.Multiline = true;
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.ReadOnly = true;
            this.txtFormula.Size = new System.Drawing.Size(258, 78);
            this.txtFormula.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Formula String";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(633, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // ExternalFormulas
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(633, 329);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ExternalFormulas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "External Formula";
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
            Application.Run(new ExternalFormulas());
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
