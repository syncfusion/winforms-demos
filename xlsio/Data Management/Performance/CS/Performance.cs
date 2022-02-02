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
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;
using System.IO;
using System.Data;

namespace EssentialXlsIOSamples
{
    /// <summary>
    /// Summary description for Performance.
    /// </summary>
    public class Performance : MetroForm
    {
        #region Fields
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;

        //Measurement variables.
        DateTime startTime;
        TimeSpan endTime;
        int rowCount;
        int colCount;
        private string fileName;
        private System.Windows.Forms.CheckBox chbColumnStyle;
        private TextBox Log;
        private GroupBox groupBox2;
        private RadioButton rdbExcel2010;
        private RadioButton rdbExcel2007;
        private RadioButton rdbExcel97;
        private RadioButton rdbExcel2013;
        private PictureBox pictureBox2;
        private TextBox numColCount;
        private TextBox numRowCount;
        private CheckBox chkImportOnSave;
        private TextBox textBox1;
        private TextBox textBox2;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        #endregion

        #region Initialize
        public Performance()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.rdbExcel2013.Checked = true;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        #endregion

        #region Performance Checking
        private void btnCreate_Click(object sender, System.EventArgs e)
        {

            if (!(int.TryParse(numRowCount.Text, out rowCount) && int.TryParse(numColCount.Text, out colCount)))
            {
                MessageBox.Show("Enter Numerical Value");
                return;
            }

            if (rowCount <= 0)
            {
                MessageBox.Show("Invalid row count");
                return;
            }

            if (colCount <= 0)
            {
                MessageBox.Show("Invalid column count");
                return;
            }
            if (rdbExcel97.Checked)
            {
                if (colCount > 256)
                {
                    MessageBox.Show("Column count must be less than or equal to 256 for Excel 2003 format.");
                    return;
                }
                if (rowCount > 65536)
                {
                    MessageBox.Show("Row count must be less than or equal to 65,536 for Excel 2003 format.");
                    return;
                }
            }
            if (rdbExcel2007.Checked || rdbExcel2010.Checked || rdbExcel2013.Checked)
            {
                if (rowCount > 100001)
                {
                    MessageBox.Show("Row count must be less than or equal to 100,000.");
                    return;
                }
                if (colCount > 151)
                {
                    MessageBox.Show("Column count must be less than or equal to 151.");
                    return;
                }
            }           
                
                #region Starttime
                //Start Time

                #endregion

                #region Initialize Workbook
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
                    fileName = "PerformanceChecking.xls";
                }
                //Set the Default version as Excel 2007
                else if (this.rdbExcel2007.Checked)
                {
                    application.DefaultVersion = ExcelVersion.Excel2007;
                    fileName = "PerformanceChecking.xlsx";
                }
                //Set the Default version as Excel 2010
                else if (this.rdbExcel2010.Checked)
                {
                    application.DefaultVersion = ExcelVersion.Excel2010;
                    fileName = "PerformanceChecking.xlsx";
                }
                //Set the Default version as Excel 2013
                else if (this.rdbExcel2013.Checked)
                {
                    application.DefaultVersion = ExcelVersion.Excel2013;
                    fileName = "PerformanceChecking.xlsx";
                }
                //A new workbook is created.[Equivalent to creating a new workbook in MS Excel]
                //The new workbook will have 3 worksheets
                IWorkbook workbook = application.Workbooks.Create(3);

                //The first worksheet object in the worksheets collection is accessed.
                IWorksheet worksheet = workbook.Worksheets[0];

                startTime = DateTime.Now;
                workbook.DetectDateTimeInValue = false;                
                #endregion

                
                if (chbColumnStyle.Checked)
                {
                    //Body Style
                    IStyle bodyStyle = workbook.Styles.Add("BodyStyle");
                    bodyStyle.BeginUpdate();

                    //Add custom colors to the palette.
                    workbook.SetPaletteColor(9, Color.FromArgb(239, 243, 247));
                    bodyStyle.Color = Color.FromArgb(239, 243, 247);
                    bodyStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                    bodyStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                    bodyStyle.EndUpdate();

                    worksheet.SetDefaultColumnStyle(1, colCount, bodyStyle);

                }
                if (this.chkImportOnSave.Checked)
                {
                    DataTable dataTable = new DataTable();
                    for (int column = 1; column <= colCount; column++)
                    {
                        dataTable.Columns.Add("Column: " + column.ToString(), typeof(int));
                    }
                    //Adding data into data table
                    for (int row = 1; row < rowCount; row++)
                    {
                        dataTable.Rows.Add();
                        for (int column = 1; column <= colCount; column++)
                        {
                            dataTable.Rows[row - 1][column - 1] = row * column;
                        }
                    }
                    startTime = DateTime.Now;
                    worksheet.ImportDataTable(dataTable, 1, 1, true, true);
                }
                else
                {
                    #region Apply Style
                    //Header Style
                    IStyle headerStyle = workbook.Styles.Add("HeaderStyle");

                    headerStyle.BeginUpdate();
                    //Add custom colors to the palette.
                    workbook.SetPaletteColor(8, Color.FromArgb(255, 174, 33));
                    headerStyle.Color = Color.FromArgb(255, 174, 33);
                    headerStyle.Font.Bold = true;
                    headerStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                    headerStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                    headerStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                    headerStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                    headerStyle.EndUpdate();
                    #endregion
                    IMigrantRange migrantRange = worksheet.MigrantRange;
                    for (int column = 1; column <= colCount; column++)
                    {
                        migrantRange.ResetRowColumn(1, column);
                        migrantRange.Text = "Column: " + column.ToString();
                        migrantRange.CellStyle = headerStyle;
                    }                  

                    #region Insert Data
                    //Writing Data using normal interface
                    for (int row = 2; row <= rowCount; row++)
                    {
                        //double columnSum = 0.0; 
                        for (int column = 1; column <= colCount; column++)
                        {
                            //Writing number
                            migrantRange.ResetRowColumn(row, column);
                            migrantRange.Number = row * column;
                        }
                    }
                }
                #endregion

                #region Workook Save
                workbook.SaveAs(fileName);
                #endregion

                #region Workbook Save and Dispose
                //Close the workbook
                workbook.Close();
                //Dispose the Excel Engine
                excelEngine.Dispose();
                #endregion

                #region Set EndTime and get LogDetails
                //End Time
                endTime = DateTime.Now - startTime;
                LogDetails(endTime);
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
                process.StartInfo = new System.Diagnostics.ProcessStartInfo(fileName)
                {
                    UseShellExecute = true
                };
                process.Start();
#else
                Process.Start(fileName);
#endif
            }
            #endregion


        }
        #endregion

        #region Get LogDetails
        void LogDetails(TimeSpan endtime)
        {
            // Force garbage collection and get used memory size
            GC.Collect();
            System.Threading.Thread.Sleep(10);
            GC.Collect();
            System.Threading.Thread.Sleep(100);
            GC.Collect();
            //Log.Text ="Optimizations for {0}: ";

            Process myProcess = Process.GetCurrentProcess();

            double workingSetSizeinKiloBytes = myProcess.WorkingSet64 / 1000;

            string s = "Number of rows : " + numRowCount.Text + "\r\n" + "Number of columns: " + numColCount.Text + "\r\n" + "Process' physical memory usage: " + workingSetSizeinKiloBytes.ToString() + " kb \r\n";
            Log.Text = s + "\r\n" + "Time taken : " + endTime.Minutes + "Mins : " + endTime.Seconds + "secs : " + endTime.Milliseconds + "msec";
        }
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Performance));
            this.btnCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numColCount = new System.Windows.Forms.TextBox();
            this.numRowCount = new System.Windows.Forms.TextBox();
            this.chbColumnStyle = new System.Windows.Forms.CheckBox();
            this.Log = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkImportOnSave = new System.Windows.Forms.CheckBox();
            this.rdbExcel2013 = new System.Windows.Forms.RadioButton();
            this.rdbExcel2010 = new System.Windows.Forms.RadioButton();
            this.rdbExcel2007 = new System.Windows.Forms.RadioButton();
            this.rdbExcel97 = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCreate.Location = new System.Drawing.Point(271, 33);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 26);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter the number of Rows";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter the number of columns";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numColCount);
            this.groupBox1.Controls.Add(this.numRowCount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chbColumnStyle);
            this.groupBox1.Location = new System.Drawing.Point(7, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 83);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // numColCount
            // 
            this.numColCount.Location = new System.Drawing.Point(164, 52);
            this.numColCount.Name = "numColCount";
            this.numColCount.Size = new System.Drawing.Size(94, 20);
            this.numColCount.TabIndex = 68;
            this.numColCount.Text = "50";
            // 
            // numRowCount
            // 
            this.numRowCount.Location = new System.Drawing.Point(164, 19);
            this.numRowCount.Name = "numRowCount";
            this.numRowCount.Size = new System.Drawing.Size(94, 20);
            this.numRowCount.TabIndex = 67;
            this.numRowCount.Text = "50000";
            // 
            // chbColumnStyle
            // 
            this.chbColumnStyle.Checked = true;
            this.chbColumnStyle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbColumnStyle.CheckedChanged += ChbColumnStyle_CheckedChanged;
            this.chbColumnStyle.Location = new System.Drawing.Point(271, 52);
            this.chbColumnStyle.Name = "chbColumnStyle";
            this.chbColumnStyle.Size = new System.Drawing.Size(96, 20);
            this.chbColumnStyle.TabIndex = 9;
            this.chbColumnStyle.Text = "Column style";
            // 
            // Log
            // 
            this.Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.Log.Location = new System.Drawing.Point(7, 335);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            this.Log.Size = new System.Drawing.Size(388, 82);
            this.Log.TabIndex = 64;
            this.Log.Text = "Number of rows : \r\nNumber of columns: \r\nProcess\' physical memory usage:  kb \r\n\r\nT" +
    "ime taken : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkImportOnSave);
            this.groupBox2.Controls.Add(this.rdbExcel2013);
            this.groupBox2.Controls.Add(this.rdbExcel2010);
            this.groupBox2.Controls.Add(this.rdbExcel2007);
            this.groupBox2.Controls.Add(this.rdbExcel97);
            this.groupBox2.Controls.Add(this.btnCreate);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 65);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Save As";
            // 
            // chkImportOnSave
            // 
            this.chkImportOnSave.AutoSize = true;
            this.chkImportOnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkImportOnSave.Location = new System.Drawing.Point(271, 10);
            this.chkImportOnSave.Name = "checkBox1";
            this.chkImportOnSave.Size = new System.Drawing.Size(98, 17);
            this.chkImportOnSave.TabIndex = 4;
            this.chkImportOnSave.Text = "Import on Save";
            this.chkImportOnSave.CheckedChanged += ChkImportOnSave_CheckedChanged;
            this.chkImportOnSave.UseVisualStyleBackColor = true;
            // 
            // rdbExcel2013
            // 
            this.rdbExcel2013.AutoSize = true;
            this.rdbExcel2013.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExcel2013.Location = new System.Drawing.Point(125, 42);
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
            this.rdbExcel2010.Location = new System.Drawing.Point(125, 13);
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
            this.rdbExcel2007.Location = new System.Drawing.Point(6, 42);
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
            this.rdbExcel97.CheckedChanged += RdbExcel97_CheckedChanged;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(639, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 66;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(7, 77);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(388, 50);
            this.textBox1.TabIndex = 69;
            this.textBox1.Text = "Click the button to view the Excel document generated by Essential XlsIO. Please " +
    "note that Microsoft Excel is required to view the resultant document.";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(7, 134);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(388, 35);
            this.textBox2.TabIndex = 70;
            this.textBox2.Text = "Import on Save option directly serialize data while saving the workbook. Cell    " +
    "formatting cannot be applied.";
            // 
            // Performance
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(403, 424);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Performance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Performance";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ChbColumnStyle_CheckedChanged(object sender, EventArgs e)
        {
            if(chbColumnStyle.Checked)
              chkImportOnSave.Checked = false;
        }

        private void RdbExcel97_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbExcel97.Checked)
            {
                chkImportOnSave.Checked = false;
                chkImportOnSave.Enabled = false;
            }
            else
                chkImportOnSave.Enabled = true;
        }

        private void ChkImportOnSave_CheckedChanged(object sender, EventArgs e)
        {
            if (chkImportOnSave.Checked)
            {
                if(chbColumnStyle.Checked)
                  this.chbColumnStyle.Checked = false;
            }           
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
            Application.Run(new Performance());
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
