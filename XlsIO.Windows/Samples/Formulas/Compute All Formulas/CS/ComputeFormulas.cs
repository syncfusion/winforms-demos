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
using System.Drawing.Imaging;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;
using System.IO;
namespace EssentialXlsIOSample
{
	/// <summary>
	/// A CalcWorkbook-derived object that uses XlsIO to read / compute Excel XLS files.
	/// </summary>
	/// 
	public class ComputeFormulas : MetroForm
    {
        #region Fields

        private System.Windows.Forms.Button btnCreate;
        private Label label2;
        private GroupBox groupBox1;
        private string fileName;
        private RadioButton rdbExcel2010;
        private RadioButton rdbExcek2007;
        private RadioButton rdbExcel97;
        private RadioButton rdbExcel2013;
        private PictureBox pictureBox2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
        #endregion

        #region Constants
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\Common\Data\XlsIO\{0}";
        #endregion

        #region Initialize
        public ComputeFormulas()
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

        #region Compute Formulas
        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            #region Workbook Initialize
            //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
			//The instantiation process consists of two steps.

			//Step 1 : Instantiate the spreadsheet creation engine.
			ExcelEngine excelEngine = new ExcelEngine();
			//Step 2 : Instantiate the excel application object.
			IApplication application = excelEngine.Excel;

            //Get the path of the input file.
            string inputPath = GetFullTemplatePath("TimelogTemplate.xls");
            IWorkbook myWorkbook = excelEngine.Excel.Workbooks.Open(inputPath, ExcelOpenType.Automatic);
            IWorksheet worksheet = myWorkbook.Worksheets[0];

			//Set the Default version as Excel 97to2003
            if (this.rdbExcel97.Checked)
            {                
                myWorkbook.Version = ExcelVersion.Excel97to2003;
                fileName = "ComputeFormulas.xls";
            }
			//Set the Default version as Excel 2007
            else if (this.rdbExcek2007.Checked)
            {
                myWorkbook.Version = ExcelVersion.Excel2007;
                fileName = "ComputeFormulas.xlsx";
            }
			//Set the Default version as Excel 2010
            else if (this.rdbExcel2010.Checked)
            {
                myWorkbook.Version = ExcelVersion.Excel2010;
                fileName = "ComputeFormulas.xlsx";
            }
            //Set the Default version as Excel 2013
            else if (this.rdbExcel2013.Checked)
            {
                myWorkbook.Version = ExcelVersion.Excel2013;
                fileName = "ComputeFormulas.xlsx";
            }			
            #endregion

            #region Compute Formulas
            //Enable to calculate formulas in the worksheet.
            worksheet.EnableSheetCalculations();

            //hourly rate
            worksheet["G7"].Number = 11;

			//overtime rate.
            worksheet["J7"].Formula = "=SUM(G7*1.5)";

            //Regular hours
            worksheet["F10"].Formula = "=IF((((C10-B10)+(E10-D10))*24)>8,8,((C10-B10)+(E10-D10))*24)";
            worksheet["F11"].Formula = "=IF((((C11-B11)+(E11-D11))*24)>8,8,((C11-B11)+(E11-D11))*24)";
            worksheet["F12"].Formula = "=IF((((C12-B12)+(E12-D12))*24)>8,8,((C12-B12)+(E12-D12))*24)";
            worksheet["F13"].Formula = "=IF((((C13-B13)+(E13-D13))*24)>8,8,((C13-B13)+(E13-D13))*24)";
            worksheet["F14"].Formula = "=IF((((C14-B14)+(E14-D14))*24)>8,8,((C14-B14)+(E14-D14))*24)";
            worksheet["F15"].Formula = "=IF((((C15-B15)+(E15-D15))*24)>8,8,((C15-B15)+(E15-D15))*24)";

            //overtime hours
            worksheet["G10"].Formula = "=IF(((C10-B10)+(E10-D10))*24>8, ((C10-B10)+(E10-D10))*24-8,0)";
            worksheet["G11"].Formula = "=IF(((C11-B11)+(E11-D11))*24>8, ((C11-B11)+(E11-D11))*24-8,0)";
            worksheet["G12"].Formula = "=IF(((C12-B12)+(E12-D12))*24>8, ((C12-B12)+(E12-D12))*24-8,0)";
            worksheet["G13"].Formula = "=IF(((C13-B13)+(E13-D13))*24>8, ((C13-B13)+(E13-D13))*24-8,0)";
            worksheet["G14"].Formula = "=IF(((C14-B14)+(E14-D14))*24>8, ((C14-B14)+(E14-D14))*24-8,0)";
            worksheet["G15"].Formula = "=IF(((C15-B15)+(E15-D15))*24>8, ((C15-B15)+(E15-D15))*24-8,0)";

            //regular pay
            worksheet["H10"].Formula = "=SUM(F10*G7)";
            worksheet["H11"].Formula = "=SUM(F11*G7)";
            worksheet["H12"].Formula = "=SUM(F12*G7)";
            worksheet["H13"].Formula = "=SUM(F13*G7)";
            worksheet["H14"].Formula = "=SUM(F14*G7)";
            worksheet["H15"].Formula = "=SUM(F15*G7)";

            //overtime pay
            worksheet["I10"].Formula = "=SUM(G10*J7)";
            worksheet["I11"].Formula = "=SUM(G11*J7)";
            worksheet["I12"].Formula = "=SUM(G12*J7)";
            worksheet["I13"].Formula = "=SUM(G13*J7)";
            worksheet["I14"].Formula = "=SUM(G14*J7)";
            worksheet["I15"].Formula = "=SUM(G15*J7)";

            //total pay
            worksheet["J10"].Formula = "=SUM(H10+I10)";
            worksheet["J11"].Formula = "=SUM(H11+I11)";
            worksheet["J12"].Formula = "=SUM(H12+I12)";
            worksheet["J13"].Formula = "=SUM(H13+I13)";
            worksheet["J14"].Formula = "=SUM(H14+I14)";
            worksheet["J15"].Formula = "=SUM(H15+I15)";

            //total regular hours
            worksheet["F17"].Formula = "=SUM(F10:F15)";

            //total overtime hours
            worksheet["G17"].Formula = "=SUM(G10:G15)";

            //total regular pay
            worksheet["H17"].Formula = "=SUM(H10:H15)";

            //total overtime pay
            worksheet["I17"].Formula = "=SUM(I10:I15)";

            //total pay
            worksheet["J17"].Formula = "=SUM(J10:J15)";

            //consolidated pay
            worksheet["C20"].Formula = "=J17";
            //allowance
            worksheet["C21"].Number = 20;
            //PF
            worksheet["C22"].Number = 38;

            //Net pay
            worksheet["C24"].Formula = "=SUM(C20:C21)-C22";
            #endregion

            #region Workbook Save and Close
            //Saving the workbook to disk.
            myWorkbook.SaveAs(fileName);

			//Close the workbook.
            myWorkbook.Close();

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
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComputeFormulas));
            this.btnCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbExcel2013 = new System.Windows.Forms.RadioButton();
            this.rdbExcel2010 = new System.Windows.Forms.RadioButton();
            this.rdbExcek2007 = new System.Windows.Forms.RadioButton();
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
            this.btnCreate.Location = new System.Drawing.Point(336, 165);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(85, 26);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(1, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 48);
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
            this.groupBox1.Controls.Add(this.rdbExcek2007);
            this.groupBox1.Controls.Add(this.rdbExcel97);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 37);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save As";
            // 
            // rdbExcel2013
            // 
            this.rdbExcel2013.AutoSize = true;
            this.rdbExcel2013.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExcel2013.Location = new System.Drawing.Point(243, 13);
            this.rdbExcel2013.Name = "rdbExcel2013";
            this.rdbExcel2013.Size = new System.Drawing.Size(78, 17);
            this.rdbExcel2013.TabIndex = 3;
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
            this.rdbExcel2010.Text = "Excel 2010";
            this.rdbExcel2010.UseVisualStyleBackColor = true;
            // 
            // rdbExcek2007
            // 
            this.rdbExcek2007.AutoSize = true;
            this.rdbExcek2007.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExcek2007.Location = new System.Drawing.Point(85, 13);
            this.rdbExcek2007.Name = "rdbExcek2007";
            this.rdbExcek2007.Size = new System.Drawing.Size(78, 17);
            this.rdbExcek2007.TabIndex = 1;
            this.rdbExcek2007.Text = "Excel 2007";
            this.rdbExcek2007.UseVisualStyleBackColor = true;
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
            // ComputeFormulas
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(430, 208);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ComputeFormulas";
            this.Text = "Compute All Formulas";
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



        static void Main()
        {
			SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.EnableVisualStyles();
            Application.Run(new ComputeFormulas());
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

		

		

	