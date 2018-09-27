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
namespace EssentialXlsIOSamples
{
    /// <summary>
    /// Summary description for AutoShapes.
    /// </summary>
    public class AutoShapes : MetroForm
    {

        #region Fields
        private System.Windows.Forms.Button btnCreate;
        private PictureBox pictureBox4;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton rdbExcel2010;
        private RadioButton rdbExcel2007;
        private string fileName;
        private RadioButton rdbExcel2013;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        #endregion

        #region Initialize
        public AutoShapes()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = true;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.rdbExcel2013.Checked = true;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        #endregion

        #region Create AutoShapes
        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            #region Workbook Initialize
            //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            
            //Set the default version as Excel97to2003
            IApplication application = excelEngine.Excel;
            if (this.rdbExcel2007.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel2007;
                fileName = "AutoShapes.xlsx";
            }
            //Set the default version as Excel 2010;
            else if (this.rdbExcel2010.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel2010;
                fileName = "AutoShapes.xlsx";
            }
            //Set the default version as Excel 2010;
            else if (this.rdbExcel2013.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel2013;
                fileName = "AutoShapes.xlsx";
            }
            //A new workbook is created.[Equivalent to creating a new workbook in MS Excel]
            //The new workbook will have 1 worksheet.
            IWorkbook workbook = application.Workbooks.Create(1);
            //The first worksheet object in the worksheets collection is accessed.
            IWorksheet worksheet = workbook.Worksheets[0];
            #endregion

            #region AddAutoShapes
            IShape shape;
            string text;

            IFont font = workbook.CreateFont();
            font.Color = ExcelKnownColors.White;
            font.Italic = true;
            font.Size = 12;


            IFont font2 = workbook.CreateFont();
            font2.Color = ExcelKnownColors.Black;
            font2.Size = 15;
            font2.Italic = true;
            font2.Bold = true;

            text = "Requirement";
            shape = worksheet.Shapes.AddAutoShapes(AutoShapeType.RoundedRectangle, 2, 7, 60, 192);
            shape.TextFrame.TextRange.Text = text;
            shape.TextFrame.TextRange.RichText.SetFont(0, text.Length - 1, font);
            shape.TextFrame.TextRange.RichText.SetFont(0, 0, font2);
            shape.Fill.ForeColorIndex = ExcelKnownColors.Light_blue;
            shape.Line.Visible = false;
            shape.TextFrame.VerticalAlignment = ExcelVerticalAlignment.MiddleCentered;

            shape = worksheet.Shapes.AddAutoShapes(AutoShapeType.DownArrow, 5, 8, 40, 64);
            shape.Fill.ForeColorIndex = ExcelKnownColors.White;
            shape.Line.ForeColorIndex = ExcelKnownColors.Blue;
            shape.Line.Weight = 1;

            text = "Design";
            shape = worksheet.Shapes.AddAutoShapes(AutoShapeType.RoundedRectangle, 7, 7, 60, 192);
            shape.TextFrame.TextRange.Text = text;
            shape.TextFrame.TextRange.RichText.SetFont(0, text.Length - 1, font);
            shape.TextFrame.TextRange.RichText.SetFont(0, 0, font2);
            shape.Line.Visible = false;
            shape.Fill.ForeColorIndex = ExcelKnownColors.Light_orange;
            shape.TextFrame.VerticalAlignment = ExcelVerticalAlignment.MiddleCentered;


            shape = worksheet.Shapes.AddAutoShapes(AutoShapeType.DownArrow, 10, 8, 40, 64);
            shape.Fill.ForeColorIndex = ExcelKnownColors.White;
            shape.Line.ForeColorIndex = ExcelKnownColors.Blue;
            shape.Line.Weight = 1;

            text = "Execution";
            shape = worksheet.Shapes.AddAutoShapes(AutoShapeType.RoundedRectangle, 12, 7, 60, 192);
            shape.TextFrame.TextRange.Text = text;
            shape.TextFrame.TextRange.RichText.SetFont(0, text.Length - 1, font);
            shape.TextFrame.TextRange.RichText.SetFont(0, 0, font2);
            shape.Line.Visible = false;
            shape.Fill.ForeColorIndex = ExcelKnownColors.Blue;
            shape.TextFrame.VerticalAlignment = ExcelVerticalAlignment.MiddleCentered;

            shape = worksheet.Shapes.AddAutoShapes(AutoShapeType.DownArrow, 15, 8, 40, 64);
            shape.Fill.ForeColorIndex = ExcelKnownColors.White;
            shape.Line.ForeColorIndex = ExcelKnownColors.Blue;
            shape.Line.Weight = 1;

            text = "Testing";
            shape = worksheet.Shapes.AddAutoShapes(AutoShapeType.RoundedRectangle, 17, 7, 60, 192);
            shape.TextFrame.TextRange.Text = text;
            shape.TextFrame.TextRange.RichText.SetFont(0, text.Length - 1, font);
            shape.TextFrame.TextRange.RichText.SetFont(0, 0, font2);
            shape.Line.Visible = false;
            shape.Fill.ForeColorIndex = ExcelKnownColors.Green;
            shape.TextFrame.VerticalAlignment = ExcelVerticalAlignment.MiddleCentered;

            shape = worksheet.Shapes.AddAutoShapes(AutoShapeType.DownArrow, 20, 8, 40, 64);
            shape.Fill.ForeColorIndex = ExcelKnownColors.White;
            shape.Line.ForeColorIndex = ExcelKnownColors.Blue;
            shape.Line.Weight = 1;

            text = "Release";
            shape = worksheet.Shapes.AddAutoShapes(AutoShapeType.RoundedRectangle, 22, 7, 60, 192);
            shape.TextFrame.TextRange.Text = text;
            shape.TextFrame.TextRange.RichText.SetFont(0, text.Length - 1, font);
            shape.TextFrame.TextRange.RichText.SetFont(0, 0, font2);
            shape.Line.Visible = false;
            shape.Fill.ForeColorIndex = ExcelKnownColors.Lavender;
            shape.TextFrame.VerticalAlignment = ExcelVerticalAlignment.MiddleCentered;
            #endregion           

            #region Save Workbook
            
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoShapes));
            this.btnCreate = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbExcel2013 = new System.Windows.Forms.RadioButton();
            this.rdbExcel2010 = new System.Windows.Forms.RadioButton();
            this.rdbExcel2007 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.Location = new System.Drawing.Point(303, 166);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(85, 26);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(639, 71);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 70;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(-3, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 48);
            this.label2.TabIndex = 71;
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 37);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save As";
            // 
            // rdbExcel2013
            // 
            this.rdbExcel2013.AutoSize = true;
            this.rdbExcel2013.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExcel2013.Location = new System.Drawing.Point(188, 13);
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
            this.rdbExcel2010.Location = new System.Drawing.Point(104, 13);
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
            this.rdbExcel2007.Location = new System.Drawing.Point(20, 13);
            this.rdbExcel2007.Name = "rdbExcel2007";
            this.rdbExcel2007.Size = new System.Drawing.Size(78, 17);
            this.rdbExcel2007.TabIndex = 1;
            this.rdbExcel2007.Text = "Excel 2007";
            this.rdbExcel2007.UseVisualStyleBackColor = true;
            // 
            // AutoShapes
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 208);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutoShapes";
            this.Text = "AutoShapes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
            Application.Run(new AutoShapes());
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
