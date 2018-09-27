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
using Syncfusion.Licensing;
using System.IO;
namespace EssentialXlsIOSamples
{
    /// <summary>
    /// Summary description for Form Sparkline.
    /// </summary>
    public class Sparklines : MetroForm
    {
        #region Constants
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\Common\Data\XlsIO\{0}";
        #endregion

        #region Fields
        private System.Windows.Forms.Button btnCreate;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private Label label2;


        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        #endregion

        #region Initialize
        public Sparklines()
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
        
        #region Create Sparklines
        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            
            #region Workbook Initialize
            //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();

            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;

            //Set the default version as Excel 2010.
            application.DefaultVersion = ExcelVersion.Excel2010;

            string inputPath = GetTemplatePath("Sparkline.xlsx");
            //A new workbook is created.[Equivalent to creating a new workbook in MS Excel]
            //The new workbook will have 1 worksheet.
            IWorkbook workbook = application.Workbooks.Open(inputPath );

            //The first worksheet object in the worksheets collection is accessed.
            IWorksheet worksheet = workbook.Worksheets[0];
            #endregion

            #region WholeSale Report

            //A new Sparkline group is added to the sheet sparklinegroups
            ISparklineGroup sparklineGroup = worksheet.SparklineGroups.Add();

            //Set the Sparkline group type as line
            sparklineGroup.SparklineType = SparklineType.Line;

            //Set to display the empty cell as line
            sparklineGroup.DisplayEmptyCellsAs = SparklineEmptyCells.Line;

            #region Sparkline Group Style Properties
            //Sparkline group style properties
            sparklineGroup.ShowFirstPoint = true;
            sparklineGroup.FirstPointColor = Color.Green;
            sparklineGroup.ShowLastPoint = true;
            sparklineGroup.LastPointColor = Color.DarkOrange;
            sparklineGroup.ShowHighPoint = true;
            sparklineGroup.HighPointColor = Color.DarkBlue;
            sparklineGroup.ShowLowPoint = true;
            sparklineGroup.LowPointColor = Color.DarkViolet;
            sparklineGroup.ShowMarkers = true;
            sparklineGroup.MarkersColor = Color.Black;
            sparklineGroup.ShowNegativePoint = true;
            sparklineGroup.NegativePointColor = Color.Red;
            #endregion

            //set the line weight
            sparklineGroup.LineWeight = 0.3;

            //The sparklines are added to the sparklinegroup.
            ISparklines sparklines = sparklineGroup.Add();

            //Set the Sparkline Datarange .
            IRange dataRange = worksheet.Range["D6:G17"];
            //Set the Sparkline Reference range.
            IRange referenceRange = worksheet.Range["H6:H17"];

            //Create a sparkline with the datarange and reference range.
            sparklines.Add(dataRange, referenceRange);



            #endregion

            #region Retail Trade

            //A new Sparkline group is added to the sheet sparklinegroups
            sparklineGroup = worksheet.SparklineGroups.Add();

            //Set the Sparkline group type as column
            sparklineGroup.SparklineType = SparklineType.Column;

            //Set to display the empty cell as zero
            sparklineGroup.DisplayEmptyCellsAs = SparklineEmptyCells.Zero;

            #region Sparkline Group Style Properties
            //Sparkline group style properties
            sparklineGroup.ShowHighPoint = true;
            sparklineGroup.HighPointColor = Color.Green;
            sparklineGroup.ShowLowPoint = true;
            sparklineGroup.LowPointColor = Color.Red;
            sparklineGroup.ShowNegativePoint = true;
            sparklineGroup.NegativePointColor = Color.Black;
            #endregion

            //The sparklines are added to the sparklinegroup.
            sparklines = sparklineGroup.Add();

            //Set the Sparkline Datarange .
            dataRange = worksheet.Range["D21:G32"];
            //Set the Sparkline Reference range.
            referenceRange = worksheet.Range["H21:H32"];

            //Create a sparkline with the datarange and reference range.
            sparklines.Add(dataRange, referenceRange);

            #endregion

            #region Manufacturing Trade

            //A new Sparkline group is added to the sheet sparklinegroups
            sparklineGroup = worksheet.SparklineGroups.Add();

            //Set the Sparkline group type as win/loss
            sparklineGroup.SparklineType = SparklineType.ColumnStacked100;

            sparklineGroup.DisplayEmptyCellsAs = SparklineEmptyCells.Zero;

            #region Sparkline Group Style Properties
            sparklineGroup.DisplayAxis = true;
            sparklineGroup.AxisColor = Color.Black;
            sparklineGroup.ShowFirstPoint = true;
            sparklineGroup.FirstPointColor = Color.Green;
            sparklineGroup.ShowLastPoint = true;
            sparklineGroup.LastPointColor = Color.Orange;
            sparklineGroup.ShowNegativePoint = true;
            sparklineGroup.NegativePointColor = Color.Red;
            #endregion

            sparklines = sparklineGroup.Add();

            dataRange = worksheet.Range["D36:G46"];
            referenceRange = worksheet.Range["H36:H46"];

            sparklines.Add(dataRange, referenceRange);

            #endregion

            #region Workbook Save and Close
            //Saving the workbook to disk.
            workbook.SaveAs("Sparklines.xlsx");
                        
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
                System.Diagnostics.Process.Start("Sparklines.xlsx");
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
        private string GetTemplatePath(string inputFile)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sparklines));
            this.btnCreate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.Location = new System.Drawing.Point(275, 152);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(85, 26);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(372, 71);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 70;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 48);
            this.label2.TabIndex = 71;
            this.label2.Text = "Click the button to view an Excel spreadsheet generated by Essential XlsIO. Pleas" +
                "e note that MS Excel Viewer or MS Excel is required to view the resultant docume" +
                "nt.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sparklines
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 181);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCreate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Sparklines";
            this.Text = "Sparklines";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
            Application.Run(new Sparklines());
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
