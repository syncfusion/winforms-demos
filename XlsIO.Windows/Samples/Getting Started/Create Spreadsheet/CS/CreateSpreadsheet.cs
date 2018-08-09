#region Copyright Syncfusion Inc. 2001 - 2014
//
//  Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
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
using Syncfusion.Windows.Forms;
using System.Globalization;
using Syncfusion.Licensing;
using System.IO;
namespace EssentialXlsIOSamples
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class CreateSpreadsheet : MetroForm
    {
        #region Constants
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\Common\Data\XlsIO\{0}";
        #endregion

        #region Fields
        private System.Windows.Forms.Button btnCreate;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton rdbXml;
        private RadioButton rdbCsv;
        private RadioButton rdbExcel2007;
        private RadioButton rdbExcel97;
        private RadioButton rdbXltm;
        private RadioButton rdbXltx;
        private RadioButton rdbExcel2010;
        private PictureBox pictureBox3;
        private RadioButton rdbExcel2013;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        #endregion

        #region Initialize
        public CreateSpreadsheet()
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

        #region CreateSpreadsheet
        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            #region Workbook Intialization
            //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;

            //A new workbook is created.[Equivalent to creating a new workbook in MS Excel]
            //The new workbook will have 1 worksheets
            IWorkbook workbook;

            string inputPath = GetFullTemplatePath("MacroTemplate.xltm");

            if (rdbXltm.Checked)
                workbook = application.Workbooks.Open(inputPath, ExcelOpenType.Automatic);
            else
                workbook = application.Workbooks.Create(1);

            //The first worksheet object in the worksheets collection is accessed.
            IWorksheet worksheet = workbook.Worksheets[0];
            #endregion

            #region Workbook Save
            if (rdbXltm.Checked)
            {
                worksheet.IsGridLinesVisible = false;
                worksheet[1, 1].Text = "Essential XlsIO supports opening of XLTM (Excel 2007 Macro Enabled Template) file and save it in either XLTM or XLSM formats.";
                worksheet[3, 1].Text = "You can run the macro by triggering the click event of the button placed in this worksheet.";
            }
            else if (rdbCsv.Checked)
            {
                //Inserting sample text into the cells of the first worksheet.
                worksheet.Range["A1:N30"].Text = "Hello World";
            }
            else
            {
                #region Generate Excel
                worksheet.Range["A2"].ColumnWidth = 30;
                worksheet.Range["B2"].ColumnWidth = 30;
                worksheet.Range["C2"].ColumnWidth = 30;
                worksheet.Range["D2"].ColumnWidth = 30;

                worksheet.Range["A2:D2"].Merge(true);

                //Inserting sample text into the first cell of the first workworksheet.
                worksheet.Range["A2"].Text = "EXPENSE REPORT";
                worksheet.Range["A2"].CellStyle.Font.FontName = "Verdana";
                worksheet.Range["A2"].CellStyle.Font.Bold = true;
                worksheet.Range["A2"].CellStyle.Font.Size = 28;
                worksheet.Range["A2"].CellStyle.Font.RGBColor = System.Drawing.Color.FromArgb(0, 0, 112, 192);
                worksheet.Range["A2"].HorizontalAlignment = ExcelHAlign.HAlignCenter;

                worksheet.Range["A4"].Text = "Employee";
                worksheet.Range["B4"].Text = "Roger Federer";
                worksheet.Range["A4:B7"].CellStyle.Font.FontName = "Verdana";
                worksheet.Range["A4:B7"].CellStyle.Font.Bold = true;
                worksheet.Range["A4:B7"].CellStyle.Font.Size = 11;
                worksheet.Range["A4:A7"].CellStyle.Font.RGBColor = System.Drawing.Color.FromArgb(0, 128, 128, 128);
                worksheet.Range["A4:A7"].HorizontalAlignment = ExcelHAlign.HAlignLeft;
                worksheet.Range["B4:B7"].CellStyle.Font.RGBColor = System.Drawing.Color.FromArgb(0, 174, 170, 170);
                worksheet.Range["B4:B7"].HorizontalAlignment = ExcelHAlign.HAlignRight;

                worksheet.Range["A9:D20"].CellStyle.Font.FontName = "Verdana";
                worksheet.Range["A9:D20"].CellStyle.Font.Size = 11;

                worksheet.Range["A5"].Text = "Department";
                worksheet.Range["B5"].Text = "Administration";

                worksheet.Range["A6"].Text = "Week Ending";
                worksheet.Range["B6"].NumberFormat = "m/d/yyyy";
                worksheet.Range["B6"].DateTime = DateTime.Parse("10/20/2012",CultureInfo.InvariantCulture);

                worksheet.Range["A7"].Text = "Mileage Rate";
                worksheet.Range["B7"].NumberFormat = "$#,##0.00";
                worksheet.Range["B7"].Number = 0.70;
               
                worksheet.Range["A10"].Text = "Miles Driven";
                worksheet.Range["A11"].Text = "Miles Reimbursement";
                worksheet.Range["A12"].Text = "Parking and Tolls";
                worksheet.Range["A13"].Text = "Auto Rental";
                worksheet.Range["A14"].Text = "Lodging";
                worksheet.Range["A15"].Text = "Breakfast";
                worksheet.Range["A16"].Text = "Lunch";
                worksheet.Range["A17"].Text = "Dinner";
                worksheet.Range["A18"].Text = "Snacks";
                worksheet.Range["A19"].Text = "Others";
                worksheet.Range["A20"].Text = "Total";
                worksheet.Range["A20:D20"].CellStyle.Color = System.Drawing.Color.FromArgb(0, 0, 112, 192);
                worksheet.Range["A20:D20"].CellStyle.Font.Color = ExcelKnownColors.White;
                worksheet.Range["A20:D20"].CellStyle.Font.Bold = true;
             
                IStyle style=worksheet["B9:D9"].CellStyle;
                style.VerticalAlignment = ExcelVAlign.VAlignCenter;
                style.HorizontalAlignment = ExcelHAlign.HAlignRight;
                style.Color = System.Drawing.Color.FromArgb(0, 0, 112, 192);
                style.Font.Bold = true;
                style.Font.Color = ExcelKnownColors.White;

                worksheet.Range["A9"].Text = "Expenses";
                worksheet.Range["A9"].CellStyle.Color = System.Drawing.Color.FromArgb(0, 0, 112, 192);
                worksheet.Range["A9"].CellStyle.Font.Color = ExcelKnownColors.White;
                worksheet.Range["A9"].CellStyle.Font.Bold = true;
                worksheet.Range["B9"].Text = "Day 1";
                worksheet.Range["B10"].Number = 100;
                worksheet.Range["B11"].NumberFormat = "$#,##0.00";
                worksheet.Range["B11"].Formula = "=(B7*B10)";
                worksheet.Range["B12"].NumberFormat = "$#,##0.00";
                worksheet.Range["B12"].Number = 0;
                worksheet.Range["B13"].NumberFormat = "$#,##0.00";
                worksheet.Range["B13"].Number = 0;
                worksheet.Range["B14"].NumberFormat = "$#,##0.00";
                worksheet.Range["B14"].Number = 0;
                worksheet.Range["B15"].NumberFormat = "$#,##0.00";
                worksheet.Range["B15"].Number = 9;
                worksheet.Range["B16"].NumberFormat = "$#,##0.00";
                worksheet.Range["B16"].Number = 12;
                worksheet.Range["B17"].NumberFormat = "$#,##0.00";
                worksheet.Range["B17"].Number = 13;
                worksheet.Range["B18"].NumberFormat = "$#,##0.00";
                worksheet.Range["B18"].Number = 9.5;
                worksheet.Range["B19"].NumberFormat = "$#,##0.00";
                worksheet.Range["B19"].Number = 0;
                worksheet.Range["B20"].NumberFormat = "$#,##0.00";
                worksheet.Range["B20"].Formula = "=SUM(B11:B19)";

                worksheet.Range["C9"].Text = "Day 2";
                worksheet.Range["C10"].Number = 145;
                worksheet.Range["C11"].NumberFormat = "$#,##0.00";
                worksheet.Range["C11"].Formula = "=(B7*C10)";
                worksheet.Range["C12"].NumberFormat = "$#,##0.00";
                worksheet.Range["C12"].Number = 15;
                worksheet.Range["C13"].NumberFormat = "$#,##0.00";
                worksheet.Range["C13"].Number = 0;
                worksheet.Range["C14"].NumberFormat = "$#,##0.00";
                worksheet.Range["C14"].Number = 45;
                worksheet.Range["C15"].NumberFormat = "$#,##0.00";
                worksheet.Range["C15"].Number = 9;
                worksheet.Range["C16"].NumberFormat = "$#,##0.00";
                worksheet.Range["C16"].Number = 12;
                worksheet.Range["C17"].NumberFormat = "$#,##0.00";
                worksheet.Range["C17"].Number = 15;
                worksheet.Range["C18"].NumberFormat = "$#,##0.00";
                worksheet.Range["C18"].Number = 7;
                worksheet.Range["C19"].NumberFormat = "$#,##0.00";
                worksheet.Range["C19"].Number = 0;
                worksheet.Range["C20"].NumberFormat = "$#,##0.00";
                worksheet.Range["C20"].Formula = "=SUM(C11:C19)";

                worksheet.Range["D9"].Text = "Day 3";
                worksheet.Range["D10"].Number = 113;
                worksheet.Range["D11"].NumberFormat = "$#,##0.00";
                worksheet.Range["D11"].Formula = "=(B7*D10)";
                worksheet.Range["D12"].NumberFormat = "$#,##0.00";
                worksheet.Range["D12"].Number = 17;
                worksheet.Range["D13"].NumberFormat = "$#,##0.00";
                worksheet.Range["D13"].Number = 8;
                worksheet.Range["D14"].NumberFormat = "$#,##0.00";
                worksheet.Range["D14"].Number = 45;
                worksheet.Range["D15"].NumberFormat = "$#,##0.00";
                worksheet.Range["D15"].Number = 7;
                worksheet.Range["D16"].NumberFormat = "$#,##0.00";
                worksheet.Range["D16"].Number = 11;
                worksheet.Range["D17"].NumberFormat = "$#,##0.00";
                worksheet.Range["D17"].Number = 16;
                worksheet.Range["D18"].NumberFormat = "$#,##0.00";
                worksheet.Range["D18"].Number = 7;
                worksheet.Range["D19"].NumberFormat = "$#,##0.00";
                worksheet.Range["D19"].Number = 5;
                worksheet.Range["D20"].NumberFormat = "$#,##0.00";
                worksheet.Range["D20"].Formula = "=SUM(D11:D19)";

                worksheet.UsedRange.AutofitRows();
                #endregion
            }

            string fileName = "";
            if (rdbExcel97.Checked)
            {
                fileName = "CreateSpreadsheet.xls";
                workbook.SaveAs(fileName);
            }
            else if (rdbExcel2007.Checked)
            {
                fileName = "CreateSpreadsheet.xlsx";
                workbook.Version = ExcelVersion.Excel2007;
                workbook.SaveAs(fileName);
            }
            else if (rdbExcel2010.Checked)
            {
                fileName = "CreateSpreadsheet.xlsx";
                workbook.Version = ExcelVersion.Excel2010;
                workbook.SaveAs(fileName);
            }
            else if (rdbExcel2013 .Checked)
            {
                fileName = "CreateSpreadsheet.xlsx";
                workbook.Version = ExcelVersion.Excel2013;
                workbook.SaveAs(fileName);
            }
            else if (rdbCsv.Checked)
            {
                fileName = "CreateSpreadsheet.csv";
                worksheet.SaveAs(fileName, ",");
            }
            else if (rdbXml.Checked)
            {
                fileName = "CreateSpreadsheet.xml";
                workbook.SaveAsXml(fileName, ExcelXmlSaveType.MSExcel);
            }
            else if (rdbXltx.Checked)
            {
                fileName = "CreateSpreadsheet.xltx";
                workbook.Version = ExcelVersion.Excel2007;
                workbook.SaveAs(fileName, ExcelSaveType.SaveAsTemplate);
            }
            else if (rdbXltm.Checked)
            {
                fileName = "CreateSpreadsheet.xltm";
                workbook.Version = ExcelVersion.Excel2007;
                workbook.SaveAs(fileName, ExcelSaveType.SaveAsTemplate);
            }
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
                    System.Diagnostics.Process.Start(fileName);

                    //Exit
                    this.Close();
                }
                catch (Win32Exception ex)
                {
                    MessageBox.Show("Ms Excel is not installed in this system");
                    Console.WriteLine(ex.ToString());
                }
            }
            else
                this.Close();
            #endregion
        }
        #endregion

        #region HelperMethods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateSpreadsheet));
            this.btnCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbExcel2013 = new System.Windows.Forms.RadioButton();
            this.rdbExcel2010 = new System.Windows.Forms.RadioButton();
            this.rdbXltx = new System.Windows.Forms.RadioButton();
            this.rdbXltm = new System.Windows.Forms.RadioButton();
            this.rdbXml = new System.Windows.Forms.RadioButton();
            this.rdbCsv = new System.Windows.Forms.RadioButton();
            this.rdbExcel2007 = new System.Windows.Forms.RadioButton();
            this.rdbExcel97 = new System.Windows.Forms.RadioButton();
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
            this.btnCreate.Location = new System.Drawing.Point(355, 192);
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
            this.label2.Location = new System.Drawing.Point(0, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(440, 48);
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
            this.groupBox1.Controls.Add(this.rdbXltx);
            this.groupBox1.Controls.Add(this.rdbXltm);
            this.groupBox1.Controls.Add(this.rdbXml);
            this.groupBox1.Controls.Add(this.rdbCsv);
            this.groupBox1.Controls.Add(this.rdbExcel2007);
            this.groupBox1.Controls.Add(this.rdbExcel97);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 70);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save As";
            // 
            // rdbExcel2013
            // 
            this.rdbExcel2013.AutoSize = true;
            this.rdbExcel2013.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExcel2013.Location = new System.Drawing.Point(256, 48);
            this.rdbExcel2013.Name = "rdbExcel2013";
            this.rdbExcel2013.Size = new System.Drawing.Size(78, 17);
            this.rdbExcel2013.TabIndex = 7;
            this.rdbExcel2013.Text = "Excel 2013";
            this.rdbExcel2013.UseVisualStyleBackColor = true;
            // 
            // rdbExcel2010
            // 
            this.rdbExcel2010.AutoSize = true;
            this.rdbExcel2010.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExcel2010.Location = new System.Drawing.Point(172, 48);
            this.rdbExcel2010.Name = "rdbExcel2010";
            this.rdbExcel2010.Size = new System.Drawing.Size(78, 17);
            this.rdbExcel2010.TabIndex = 6;
            this.rdbExcel2010.Text = "Excel 2010";
            this.rdbExcel2010.UseVisualStyleBackColor = true;
            // 
            // rdbXltx
            // 
            this.rdbXltx.AutoSize = true;
            this.rdbXltx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbXltx.Location = new System.Drawing.Point(172, 19);
            this.rdbXltx.Name = "rdbXltx";
            this.rdbXltx.Size = new System.Drawing.Size(42, 17);
            this.rdbXltx.TabIndex = 5;
            this.rdbXltx.Text = "Xltx";
            this.rdbXltx.UseVisualStyleBackColor = true;
            // 
            // rdbXltm
            // 
            this.rdbXltm.AutoSize = true;
            this.rdbXltm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbXltm.Location = new System.Drawing.Point(257, 19);
            this.rdbXltm.Name = "rdbXltm";
            this.rdbXltm.Size = new System.Drawing.Size(45, 17);
            this.rdbXltm.TabIndex = 4;
            this.rdbXltm.Text = "Xltm";
            this.rdbXltm.UseVisualStyleBackColor = true;
            // 
            // rdbXml
            // 
            this.rdbXml.AutoSize = true;
            this.rdbXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbXml.Location = new System.Drawing.Point(88, 19);
            this.rdbXml.Name = "rdbXml";
            this.rdbXml.Size = new System.Drawing.Size(42, 17);
            this.rdbXml.TabIndex = 3;
            this.rdbXml.Text = "Xml";
            this.rdbXml.UseVisualStyleBackColor = true;
            // 
            // rdbCsv
            // 
            this.rdbCsv.AutoSize = true;
            this.rdbCsv.Checked = true;
            this.rdbCsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCsv.Location = new System.Drawing.Point(6, 19);
            this.rdbCsv.Name = "rdbCsv";
            this.rdbCsv.Size = new System.Drawing.Size(46, 17);
            this.rdbCsv.TabIndex = 2;
            this.rdbCsv.TabStop = true;
            this.rdbCsv.Text = "CSV";
            this.rdbCsv.UseVisualStyleBackColor = true;
            // 
            // rdbExcel2007
            // 
            this.rdbExcel2007.AutoSize = true;
            this.rdbExcel2007.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExcel2007.Location = new System.Drawing.Point(88, 47);
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
            this.rdbExcel97.Location = new System.Drawing.Point(6, 47);
            this.rdbExcel97.Name = "rdbExcel97";
            this.rdbExcel97.Size = new System.Drawing.Size(78, 17);
            this.rdbExcel97.TabIndex = 0;
            this.rdbExcel97.Text = "Excel 2003";
            this.rdbExcel97.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(639, 71);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 75;
            this.pictureBox3.TabStop = false;
            // 
            // CreateSpreadsheet
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(452, 230);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateSpreadsheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Spreadsheet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
            Application.Run(new CreateSpreadsheet());
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