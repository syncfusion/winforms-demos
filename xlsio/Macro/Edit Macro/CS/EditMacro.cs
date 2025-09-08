#region Copyright Syncfusion Inc. 2001 - 2019
//
//  Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
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
using System.Diagnostics;
using System.Globalization;
using System.IO;
using Syncfusion.Licensing;
using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms;
using Syncfusion.Office;
namespace EssentialXlsIOSamples
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class EditMacro : MetroForm
    {
        #region Constants
#if NETCORE
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\common\Data\XlsIO\{0}";
#else
        private const string DEFAULTPATH = @"..\..\..\..\..\..\common\Data\XlsIO\{0}";
#endif
        #endregion

        #region Fields
        private System.Windows.Forms.Button btnCreate;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton rdbXLS;
        private RadioButton rdbXLSM;
        private RadioButton rdbXLTM;
        private PictureBox pictureBox3;
        private Button btnTemplate;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
#endregion

        #region Initialize
        public EditMacro()
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
        #region View Input Template
        private void btnTemplate_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = GetFullTemplatePath("EditMacroTemplate.xltm");
                #region View the Workbook
                try
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
                    System.Diagnostics.Process.Start(fileName);
#endif
                }
                catch (Win32Exception ex)
                {
                    MessageBox.Show("MS Excel is not installed in this system");
                    Console.WriteLine(ex.ToString());
                }
                #endregion
            }
            catch
            {
                MessageBox.Show("Sorry, Excel can't open two workbooks with the same name at the same time.\nPlease close the workbook and try again.", "File is already open", MessageBoxButtons.OK);
            }
        }
        #endregion
        #region Create Spreadsheet
        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            #region Workbook Intialization
            //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;

            //An existing macro-enabled workbook is opened.[Equivalent to the workbook in MS Excel]
            IWorkbook workbook;
            string inputPath = GetFullTemplatePath("EditMacroTemplate.xltm");
            workbook = application.Workbooks.Open(inputPath, ExcelOpenType.Automatic);

            //The first worksheet object in the worksheets collection is accessed.
            IWorksheet worksheet = workbook.Worksheets[0];
            #endregion
            #region Edit Macro
            IVbaProject vbaProject = workbook.VbaProject;
            IVbaModule vbaModule = vbaProject.Modules["Module1"];
            vbaModule.Code = vbaModule.Code.Replace("xlAreaStacked", "xlLine");
            #endregion

            try
            {
                #region Workbook Save
                string fileName = "";
                if (rdbXLS.Checked)
                {
                    fileName = "EditMacro.xls";
                    workbook.Version = ExcelVersion.Excel97to2003;
                    workbook.SaveAs(fileName);
                }
                else if (rdbXLTM.Checked)
                {
                    fileName = "EditMacro.xltm";
                    workbook.SaveAs(fileName);
                }
                else if (rdbXLSM.Checked)
                {
                    fileName = "EditMacro.xlsm";
                    workbook.SaveAs(fileName);
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
                    catch (Win32Exception ex)
                    {
                        MessageBox.Show("Ms Excel is not installed in this system");
                        Console.WriteLine(ex.ToString());
                    }
                }
                #endregion
            }
            catch
            {
                MessageBox.Show("Sorry, Excel can't open two workbooks with the same name at the same time.\nPlease close the workbook and try again.", "File is already open", MessageBoxButtons.OK);
            }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMacro));
            this.btnCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbXLTM = new System.Windows.Forms.RadioButton();
            this.rdbXLS = new System.Windows.Forms.RadioButton();
            this.rdbXLSM = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnTemplate = new System.Windows.Forms.Button();
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
            this.btnCreate.Location = new System.Drawing.Point(217, 240);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(98, 26);
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
            this.label2.Size = new System.Drawing.Size(335, 48);
            this.label2.TabIndex = 64;
            this.label2.Text = "Click the button to view an Excel spreadsheet generated by Essential XlsIO. Pleas" +
    "e note that MS Excel Viewer or MS Excel is required to view the resultant docume" +
    "nt.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbXLTM);
            this.groupBox1.Controls.Add(this.rdbXLS);
            this.groupBox1.Controls.Add(this.rdbXLSM);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 118);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save As";
            // 
            // rdbXLTM
            // 
            this.rdbXLTM.AutoSize = true;
            this.rdbXLTM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbXLTM.Location = new System.Drawing.Point(22, 53);
            this.rdbXLTM.Name = "rdbXLTM";
            this.rdbXLTM.Size = new System.Drawing.Size(54, 17);
            this.rdbXLTM.TabIndex = 5;
            this.rdbXLTM.Text = "XLTM";
            this.rdbXLTM.UseVisualStyleBackColor = true;
            // 
            // rdbXLS
            // 
            this.rdbXLS.AutoSize = true;
            this.rdbXLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbXLS.Location = new System.Drawing.Point(22, 30);
            this.rdbXLS.Name = "rdbXLS";
            this.rdbXLS.Size = new System.Drawing.Size(45, 17);
            this.rdbXLS.TabIndex = 3;
            this.rdbXLS.Text = "XLS";
            this.rdbXLS.UseVisualStyleBackColor = true;
            // 
            // rdbXLSM
            // 
            this.rdbXLSM.AutoSize = true;
            this.rdbXLSM.Checked = true;
            this.rdbXLSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbXLSM.Location = new System.Drawing.Point(22, 76);
            this.rdbXLSM.Name = "rdbXLSM";
            this.rdbXLSM.Size = new System.Drawing.Size(54, 17);
            this.rdbXLSM.TabIndex = 2;
            this.rdbXLSM.TabStop = true;
            this.rdbXLSM.Text = "XLSM";
            this.rdbXLSM.UseVisualStyleBackColor = true;
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
            // btnTemplate
            // 
            this.btnTemplate.Location = new System.Drawing.Point(217, 159);
            this.btnTemplate.Name = "btnTemplate";
            this.btnTemplate.Size = new System.Drawing.Size(98, 26);
            this.btnTemplate.TabIndex = 76;
            this.btnTemplate.Text = "Input Template";
            this.btnTemplate.UseVisualStyleBackColor = true;
            this.btnTemplate.Click += new System.EventHandler(this.btnTemplate_Click);
            // 
            // EditMacro
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(327, 277);
            this.Controls.Add(this.btnTemplate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditMacro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Macro";
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
            Application.Run(new EditMacro());
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