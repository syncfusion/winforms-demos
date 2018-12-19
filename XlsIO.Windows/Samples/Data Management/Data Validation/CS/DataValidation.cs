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
	/// Summary description for DataValidation.
	/// </summary>
	public class DataValidation : MetroForm
    {
        #region Fields
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton excel2010RadioBtn;
        private RadioButton excel2007RadioBtn;
        private RadioButton excel2003RadioBtn;
        private string fileName;
        private PictureBox pictureBox3;
        private RadioButton excel2013RadioBtn;
		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
        #endregion

        #region Initialize
        public DataValidation()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;            
            this.StartPosition = FormStartPosition.CenterScreen;
            this.excel2013RadioBtn.Checked = true;
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
        #endregion

        #region Using DataValidation
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
            if (this.excel2003RadioBtn.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel97to2003;
                fileName = "DataValidation.xls";
            }
            //Set the Default version as Excel 2007
            else if (this.excel2007RadioBtn.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel2007;
                fileName = "DataValidation.xlsx";
            }
            //Set the Default version as Excel 2010
            else if (this.excel2010RadioBtn.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel2010;
                fileName = "DataValidation.xlsx";
            }
            //Set the Default version as Excel 2013
            else if (this.excel2013RadioBtn.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel2013;
                fileName = "DataValidation.xlsx";
            }
            //Set the Default version as Xml
            //A new workbook is created.[Equivalent to creating a new workbook in MS Excel]
			//The new workbook will have 3 worksheets
			IWorkbook workbook = application.Workbooks.Create(3); 
			//The first worksheet object in the worksheets collection is accessed.
			IWorksheet worksheet = workbook.Worksheets[0];
            #endregion

            #region DataValidation 
            
            #region DataValidation List
            //Data validation to list the values in the first cell
			IDataValidation validation = worksheet.Range["C7"].DataValidation;
			worksheet.Range["B7"].Text = "Select an item from the validation list";
			validation.ListOfValues = new string[] {"PDF","XlsIO","DocIO"};
			validation.PromptBoxText = "Data Validation list";
			validation.IsPromptBoxVisible = true;
			validation.ShowPromptBox = true;

            worksheet.Range["C7"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
            worksheet.Range["C7"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
            worksheet.Range["C7"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;
            #endregion

            #region DataValidation For Numbers
            // Data Validation for Numbers
			IDataValidation validation1 = worksheet.Range["C9"].DataValidation;
			worksheet.Range["B9"].Text = "Enter a Number to validate";
			validation1.AllowType = ExcelDataType.Integer;
			validation1.CompareOperator = ExcelDataValidationComparisonOperator.Between;
			validation1.FirstFormula = "0";
			validation1.SecondFormula = "10";
			validation1.ShowErrorBox = true;
			validation1.ErrorBoxText = "Enter Value between 0 to 10";
			validation1.ErrorBoxTitle = "ERROR";
			validation1.PromptBoxText = "Data Validation using Condition for Numbers";
			validation1.ShowPromptBox = true;
            worksheet.Range["C9"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
            worksheet.Range["C9"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
            worksheet.Range["C9"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;
            #endregion

            #region DataValidation for Date
            // Data Validation for Date
			IDataValidation validation2 = worksheet.Range["C11"].DataValidation;
			worksheet.Range["B11"].Text = "Enter the Date to validate";
			validation2.AllowType = ExcelDataType.Date;
			validation2.CompareOperator = ExcelDataValidationComparisonOperator.Between;
			validation2.FirstDateTime = new DateTime(2003,5,10);
			validation2.SecondDateTime = new DateTime(2004,5,10);
			validation2.ShowErrorBox = true;
			validation2.ErrorBoxText = "Enter Value between 10/5/2003 to 10/5/2004";
			validation2.ErrorBoxTitle = "ERROR";
			validation2.PromptBoxText = "Data Validation using Condition for Date";
			validation2.ShowPromptBox = true;
            worksheet.Range["C11"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
            worksheet.Range["C11"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
            worksheet.Range["C11"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;
            #endregion

            #region DataValidation For Text
            // Data Validation for TextLength
			IDataValidation validation3 = worksheet.Range["C13"].DataValidation;
			worksheet.Range["B13"].Text = "Enter the Text to validate";
			validation3.AllowType = ExcelDataType.TextLength;
			validation3.CompareOperator = ExcelDataValidationComparisonOperator.Between;
			validation3.FirstFormula = "1";
			validation3.SecondFormula = "6";
			validation3.ShowErrorBox = true;
			validation3.ErrorBoxText = "Retype text length to 6 character";
			validation3.ErrorBoxTitle = "ERROR";
			validation3.PromptBoxText = "Data Validation using Condition for TextLength";
			validation3.ShowPromptBox = true;
            worksheet.Range["C13"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
            worksheet.Range["C13"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
            worksheet.Range["C13"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;
            #endregion

            #region DataValidation For Time
            // Data Validation for Time
			IDataValidation validation4 = worksheet.Range["C15"].DataValidation;
			worksheet.Range["B15"].Text = "Enter the Time to validate";
			validation4.AllowType = ExcelDataType.Time;
			validation4.CompareOperator = ExcelDataValidationComparisonOperator.Between;
			 validation4.FirstFormula = "10";
            validation4.SecondFormula = "12";
			validation4.ShowErrorBox = true;
			validation4.ErrorBoxText = "Enter the Correct time between 10 to 12 ";
			validation4.ErrorBoxTitle = "ERROR";
			validation4.PromptBoxText = "Data Validation using Condition for Time";
			validation4.ShowPromptBox = true;
            worksheet.Range["C15"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
            worksheet.Range["C15"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
            worksheet.Range["C15"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;
            worksheet.Range["B2:C2"].Merge();
            worksheet.Range["B2"].Text = "Simple Data validation";
            worksheet.Range["B5"].Text = "Validation criteria";
            worksheet.Range["C5"].Text = "Validation";
            worksheet.Range["B5"].CellStyle.Font.Bold = true;
            worksheet.Range["C5"].CellStyle.Font.Bold = true;
            worksheet.Range["B2"].CellStyle.Font.Bold = true;
            worksheet.Range["B2"].CellStyle.Font.Size = 16;
            worksheet.Range["B2"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
            #endregion

            worksheet.AutofitColumn(2);
			worksheet.UsedRange.AutofitRows();
            #endregion

            #region Workbook Save and Close

            workbook.SaveAs(fileName);
            

           
			//Close the workbook.
			workbook.Close();

			//No exception will be thrown if there are unsaved workbooks.
			excelEngine.ThrowNotSavedOnDestroy = false;
			excelEngine.Dispose();
            #endregion

            #region View the Workbook
            //Message box confirmation to view the created spreadsheet.
			if (MessageBox.Show ("Do you want to view the workbook?", "Workbook has been created",
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataValidation));
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.excel2013RadioBtn = new System.Windows.Forms.RadioButton();
            this.excel2010RadioBtn = new System.Windows.Forms.RadioButton();
            this.excel2007RadioBtn = new System.Windows.Forms.RadioButton();
            this.excel2003RadioBtn = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.Location = new System.Drawing.Point(388, 166);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(85, 26);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 56);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(9, 89);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(464, 48);
            this.label2.TabIndex = 63;
            this.label2.Text = "Click the button to view an Excel spreadsheet generated by Essential XlsIO. Pleas" +
                "e note that MS Excel Viewer or MS Excel is required to view the resultant docume" +
                "nt.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.excel2013RadioBtn);
            this.groupBox1.Controls.Add(this.excel2010RadioBtn);
            this.groupBox1.Controls.Add(this.excel2007RadioBtn);
            this.groupBox1.Controls.Add(this.excel2003RadioBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 37);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save As";
            // 
            // excel2013RadioBtn
            // 
            this.excel2013RadioBtn.AutoSize = true;
            this.excel2013RadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excel2013RadioBtn.Location = new System.Drawing.Point(244, 13);
            this.excel2013RadioBtn.Name = "excel2013RadioBtn";
            this.excel2013RadioBtn.Size = new System.Drawing.Size(78, 17);
            this.excel2013RadioBtn.TabIndex = 4;
            this.excel2013RadioBtn.Text = "Excel 2013";
            this.excel2013RadioBtn.UseVisualStyleBackColor = true;
            // 
            // excel2010RadioBtn
            // 
            this.excel2010RadioBtn.AutoSize = true;
            this.excel2010RadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excel2010RadioBtn.Location = new System.Drawing.Point(164, 13);
            this.excel2010RadioBtn.Name = "excel2010RadioBtn";
            this.excel2010RadioBtn.Size = new System.Drawing.Size(78, 17);
            this.excel2010RadioBtn.TabIndex = 2;
            this.excel2010RadioBtn.Text = "Excel 2010";
            this.excel2010RadioBtn.UseVisualStyleBackColor = true;
            // 
            // excel2007RadioBtn
            // 
            this.excel2007RadioBtn.AutoSize = true;
            this.excel2007RadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excel2007RadioBtn.Location = new System.Drawing.Point(85, 13);
            this.excel2007RadioBtn.Name = "excel2007RadioBtn";
            this.excel2007RadioBtn.Size = new System.Drawing.Size(78, 17);
            this.excel2007RadioBtn.TabIndex = 1;
            this.excel2007RadioBtn.Text = "Excel 2007";
            this.excel2007RadioBtn.UseVisualStyleBackColor = true;
            // 
            // excel2003RadioBtn
            // 
            this.excel2003RadioBtn.AutoSize = true;
            this.excel2003RadioBtn.Checked = true;
            this.excel2003RadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excel2003RadioBtn.Location = new System.Drawing.Point(6, 13);
            this.excel2003RadioBtn.Name = "excel2003RadioBtn";
            this.excel2003RadioBtn.Size = new System.Drawing.Size(78, 17);
            this.excel2003RadioBtn.TabIndex = 0;
            this.excel2003RadioBtn.TabStop = true;
            this.excel2003RadioBtn.Text = "Excel 2003";
            this.excel2003RadioBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(639, 71);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 76;
            this.pictureBox3.TabStop = false;
            // 
            // DataValidation
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(476, 208);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DataValidation";
            this.Text = "Data Validation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
            Application.Run(new DataValidation());
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
