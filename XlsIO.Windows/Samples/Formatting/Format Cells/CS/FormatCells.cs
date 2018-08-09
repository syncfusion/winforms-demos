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
using System.Globalization;
using Syncfusion.Licensing;
using System.IO;
namespace EssentialXlsIOSamples
{
    /// <summary>
    /// Summary description for FormatCells.
    /// </summary>
    public class FormatCells : MetroForm
    {
        #region Constants
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\Common\Images\XlsIO\{0}";
        #endregion

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
        public FormatCells()
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

        #region Format Cells
        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;
            //Set the Default Version as Excel 97to2003
            if (this.rdbExcel97.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel97to2003;
                fileName = "FormatCells.xls";
            }
            //Set the Default Version as Excel 2007
            else if (this.rdbExcel2007.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel2007;
                fileName = "FormatCells.xlsx";
            }
            //Set the Default Version as Excel 2010
            else if (this.rdbExcel2010.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel2010;
                fileName = "FormatCells.xlsx";
            }
            else if (this.rdbExcel2013.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel2013;
                fileName = "FormatCells13.xlsx";
            }

            //A new workbook is created.[Equivalent to creating a new workbook in MS Excel]
            //The new workbook will have 3 worksheets
            IWorkbook workbook = application.Workbooks.Create(3);
            //The first worksheet object in the worksheets collection is accessed.
            IWorksheet worksheet = workbook.Worksheets[0];
            worksheet.IsGridLinesVisible = false;

            # region RTF
            //Insert Rich Text
            IRange range = worksheet.Range["D3"];
            range.Text = "Employee Report";
            IRichTextString rtf = range.RichText;

            //Formatting the text
            IFont redFont = workbook.CreateFont();
            redFont.Size = 16;
            redFont.Bold = true;
            redFont.Italic = true;
            redFont.RGBColor = Color.FromArgb(0x82, 0x2e, 0x1b);
            rtf.SetFont(0, 14, redFont);


            #endregion

            #region Number Formatting

            worksheet.Range["H24"].Number = 5000;
            worksheet.Range["H24"].NumberFormat = "$#,##0.00";
            worksheet.Range["H14"].NumberFormat = "dd/mm/yyyy";
            worksheet.Range["H14"].DateTime = DateTime.Parse(" 8/3/1963", CultureInfo.InvariantCulture);
            worksheet.Range["H16"].NumberFormat = "mm/dd/yyyy";
            worksheet.Range["H16"].DateTime = DateTime.Parse(" 4/1/1992", CultureInfo.InvariantCulture);

            #endregion

            # region Alignment settings

            # region Text alignment
            worksheet.Range["F10:F24"].HorizontalAlignment = ExcelHAlign.HAlignRight;
            worksheet.Range["D3"].HorizontalAlignment = ExcelHAlign.HAlignCenter;
            worksheet.Range["H10:H24"].HorizontalAlignment = ExcelHAlign.HAlignLeft;
            worksheet.Range["F10:F24"].VerticalAlignment = ExcelVAlign.VAlignCenter;

            #endregion

            #region Text Control
            worksheet.Range["F27"].WrapText = true;
            worksheet.Range["F27"].Text = "Antony Jose graduated from St. Andrews University, Scotland, with a BSC degree in 1976.  Upon joining the company as a sales representative in 1992, he spent 6 months in an orientation program at the Seattle office and then returned to his permanent post in London.  He was promoted to sales manager in March 1993.";

            #endregion

            #region Cell merging
            worksheet.Range["F27:H28"].Merge();
            worksheet.Range["D3:F3"].Merge();
            worksheet.Range["B7:J8"].Merge();
            worksheet.Range["F27"].RowHeight = 68;
            worksheet.Range["H10:H24"].ColumnWidth = 25;
            worksheet.Range["C10:D28"].Merge();
            worksheet.Range["B10:C28"].ColumnWidth = 1;
            worksheet.Range["E10:E28"].ColumnWidth = 5;
            worksheet.Range["D10:D28"].ColumnWidth = 15;
            #endregion

            #region Text Direction
            worksheet.Range["B7"].Text = "Antony Jose";
            worksheet.Range["B7"].CellStyle.ReadingOrder = Syncfusion.XlsIO.ExcelReadingOrderType.LeftToRight;
            worksheet.Range["B7"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignLeft;
            worksheet.Range["B7"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
            #endregion

            #region Text Indent

            worksheet.Range["D7"].CellStyle.IndentLevel = 6;

            #endregion


            #endregion

            #region Font settings

            // Setting Font Type
            worksheet.Range["F10:F24"].CellStyle.Font.FontName = "Arial";
            worksheet.Range["D3"].CellStyle.Font.FontName = "Arial";
            worksheet.Range["B7"].CellStyle.Font.FontName = "Arial";
            worksheet.Range["B7"].CellStyle.Font.Size = 12f;
            worksheet.Range["B7"].CellStyle.Font.Bold = true;

            // Setting Font Styles
            worksheet.Range["F10:F24"].CellStyle.Font.Bold = true;
            worksheet.Range["D3"].CellStyle.Font.Bold = true;

            // Setting Font Size
            worksheet.Range["F10:F24"].CellStyle.Font.Size = 10;
            worksheet.Range["D3"].CellStyle.Font.Size = 14;
            worksheet.Range["F27:H28"].CellStyle.Font.Size = 9f;

            // Setting Font Color
            worksheet.Range["B7"].CellStyle.Font.RGBColor = Color.White;
            worksheet.Range["D28"].CellStyle.Font.RGBColor = Color.White;


            // Setting UnderLine 
            worksheet.Range["D3"].CellStyle.Font.Underline = ExcelUnderline.Double;

            worksheet.Range["F10"].Text = "Name";
            worksheet.Range["F12"].Text = "Title";
            worksheet.Range["F14"].Text = "Birth Date";
            worksheet.Range["F16"].Text = "Hire date";
            worksheet.Range["F18"].Text = "Home phone";
            worksheet.Range["F20"].Text = "Extension";
            worksheet.Range["F22"].Text = "Home address";
            worksheet.Range["F24"].Text = "Salary";

            worksheet.Range["H10"].Text = "Antony Jose";
            worksheet.Range["H12"].Text = "Sales Manager";
            worksheet.Range["H18"].Text = "(206) 555-3412";
            worksheet.Range["H20"].Number = 3355;
            worksheet.Range["H22"].Text = "722 Moss Bay Blvd";


            #endregion

            #region Insert Image
            //Get the Path of the Image
            string imagePath = GetFullImagePath("EMPID1.png");
            worksheet.Pictures.AddPicture(11, 4, imagePath, 55, 65);
            #endregion

            #region Border setting

            worksheet.Range["H10"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
            worksheet.Range["H10"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
            worksheet.Range["H10"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;

            worksheet.Range["H12"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
            worksheet.Range["H12"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
            worksheet.Range["H12"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;

            worksheet.Range["H14"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
            worksheet.Range["H14"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
            worksheet.Range["H14"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;

            worksheet.Range["H16"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
            worksheet.Range["H16"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
            worksheet.Range["H16"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;

            worksheet.Range["H18"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
            worksheet.Range["H18"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
            worksheet.Range["H18"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;

            worksheet.Range["H20"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
            worksheet.Range["H20"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
            worksheet.Range["H20"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;

            worksheet.Range["H22"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
            worksheet.Range["H22"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
            worksheet.Range["H22"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;

            worksheet.Range["H24"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
            worksheet.Range["H24"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
            worksheet.Range["H24"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;

            worksheet.Range["F27:H28"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
            worksheet.Range["F27:H28"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
            worksheet.Range["F27:H28"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;

            worksheet.Range["C10:D28"].CellStyle.Borders.LineStyle = ExcelLineStyle.Thin;
            worksheet.Range["C10:D28"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
            worksheet.Range["C10:D28"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;

            #endregion

            #region Pattern settings
            worksheet.Range["B9:I29"].CellStyle.Color = Color.FromArgb(198, 215, 239);
            worksheet.Range["A7:J8"].CellStyle.Color = Color.FromArgb(57, 93, 148);

            worksheet.Range["A7:A30"].CellStyle.Color = Color.FromArgb(57, 93, 148);
            worksheet.Range["A7:A30"].ColumnWidth = 2.29;

            worksheet.Range["J7:J30"].CellStyle.Color = Color.FromArgb(57, 93, 148);
            worksheet.Range["J7:J30"].ColumnWidth = 2.29;

            worksheet.Range["A30:J30"].CellStyle.Color = Color.FromArgb(57, 93, 148);

            worksheet.Range["C10:D28"].CellStyle.Color = Color.FromArgb(231, 235, 247);
            worksheet.Range["F27:H28"].CellStyle.Color = Color.FromArgb(231, 235, 247);
            worksheet.Range["F27:H28"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
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
        private string GetFullImagePath(string inputFile)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormatCells));
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
            this.label2.Location = new System.Drawing.Point(9, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 48);
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
            this.groupBox1.Size = new System.Drawing.Size(334, 37);
            this.groupBox1.TabIndex = 66;
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
            // rdbExcel2007
            // 
            this.rdbExcel2007.AutoSize = true;
            this.rdbExcel2007.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExcel2007.Location = new System.Drawing.Point(85, 13);
            this.rdbExcel2007.Name = "rdbExcel2007";
            this.rdbExcel2007.Size = new System.Drawing.Size(78, 17);
            this.rdbExcel2007.TabIndex = 1;
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
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            // 
            // FormatCells
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
            this.Name = "FormatCells";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Format Cells";
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
            Application.Run(new FormatCells());
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
