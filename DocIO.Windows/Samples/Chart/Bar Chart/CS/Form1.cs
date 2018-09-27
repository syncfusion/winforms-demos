#region Copyright Syncfusion Inc. 2001 - 2017
//
//  Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Windows.Forms;
using Syncfusion.OfficeChart;
using Syncfusion.Licensing;
using System.Reflection;
using System.Text;

namespace BarChart
{

    public class Form1 : MetroForm
    {
        #region Private Members

        private ToolTip toolTip1;
        private ButtonAdv buttonAdv1;
        private PictureBox pictureBox1;
        private Label label2;
        private IContainer components;

        #endregion

        #region Constructor, Main and Dispose
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            Application.EnableVisualStyles();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        /// <summary>
        /// Helper method to find a syncfusion license key from the Common folder
        /// </summary>
        /// <param name="fileName">File name of the syncfusion license key</param>
        /// <returns></returns>
        public static string FindLicenseKey()
        {
            int levelsToCheck = 12;
            string filePath = @"Common\SyncfusionLicense.txt";

            string rootPath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().CodeBase.Replace(@"file:///", ""));

            for (int n = 0; n < levelsToCheck; n++)
            {
                string fileDataPath = System.IO.Path.Combine(rootPath, filePath);
                if (System.IO.File.Exists(fileDataPath))
                    return File.ReadAllText(fileDataPath, Encoding.UTF8);
                DirectoryInfo rootDirectory = Directory.GetParent(rootPath);
                if (rootDirectory == null)
                    break;
                rootPath = rootDirectory.FullName;
            }
            return string.Empty;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
		    SyncfusionLicenseProvider.RegisterLicense(FindLicenseKey());
            Application.Run(new Form1());
        }
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
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(108, 23);
            this.buttonAdv1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv1.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.KeepFocusRectangle = false;
            this.buttonAdv1.Location = new System.Drawing.Point(110, 152);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.buttonAdv1.Size = new System.Drawing.Size(108, 23);
            this.buttonAdv1.TabIndex = 62;
            this.buttonAdv1.Text = "Generate";
            this.buttonAdv1.UseVisualStyle = true;
            this.buttonAdv1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 64);
            this.label2.TabIndex = 68;
            this.label2.Text = "Click the button to view the generated Word document. Please note that Microsoft Word Viewer or Microsoft Word is required to view the resultant Word document.";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(328, 188);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAdv1);
            this.Controls.Add(this.pictureBox1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bar Chart";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Button_Click Event
        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                //Getting data from file
                string dataPath = @"..\..\..\..\..\..\..\Common\Data\DocIO\";
                //A new document is created.
                WordDocument document = new WordDocument();
                //Add new section to the Word document
                IWSection section = document.AddSection();
                //Set page margins of the section
                section.PageSetup.Margins.All = 72;
                //Add new paragraph to the section
                IWParagraph paragraph = section.AddParagraph();
                //Apply heading style to the title paragraph
                paragraph.ApplyStyle(BuiltinStyle.Heading1);
                //Apply center alignment to the paragraph
                paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
                //Append text to the paragraph
                paragraph.AppendText("Northwind Management Report").CharacterFormat.TextColor = Color.FromArgb(46, 116, 181);
                //Add new paragraph
                paragraph = section.AddParagraph();
                //Set before spacing to the paragraph
                paragraph.ParagraphFormat.BeforeSpacing = 20;

                //Load the excel template as stream
                Stream excelStream = File.OpenRead(dataPath + "Excel_Template.xlsx");

                //Create and Append chart to the paragraph with excel stream as parameter
                WChart BarChart = paragraph.AppendChart(excelStream, 1, "B2:C6", 470, 300);
                //Set chart data
                BarChart.ChartType = OfficeChartType.Bar_Clustered;
                BarChart.ChartTitle = "Purchase Details";
                BarChart.ChartTitleArea.FontName = "Calibri (Body)";
                BarChart.ChartTitleArea.Size = 14;
                //Set name to chart series            
                BarChart.Series[0].Name = "Sum of Purchases";
                BarChart.Series[1].Name = "Sum of Future Expenses";
                //Set Chart Data table
                BarChart.HasDataTable = true;
                BarChart.DataTable.HasBorders = true;
                BarChart.DataTable.HasHorzBorder = true;
                BarChart.DataTable.HasVertBorder = true;
                BarChart.DataTable.ShowSeriesKeys = true;
                BarChart.HasLegend = false;
                //Setting background color
                BarChart.ChartArea.Fill.ForeColor = Color.FromArgb(208, 206, 206);
                BarChart.PlotArea.Fill.ForeColor = Color.FromArgb(208, 206, 206);
                //Setting line pattern to the chart area
                BarChart.PrimaryCategoryAxis.Border.LinePattern = OfficeChartLinePattern.None;
                BarChart.PrimaryValueAxis.Border.LinePattern = OfficeChartLinePattern.None;
                BarChart.ChartArea.Border.LinePattern = OfficeChartLinePattern.None;
                BarChart.PrimaryValueAxis.MajorGridLines.Border.LineColor = Color.FromArgb(175, 171, 171);
                //Set label for primary catagory axis
                BarChart.PrimaryCategoryAxis.CategoryLabels = BarChart.ChartData[2, 1, 6, 1];

                //Saving the document as .docx
                document.Save("Sample.docx", FormatType.Docx);
                //Message box confirmation to view the created document.
                if (MessageBoxAdv.Show("Do you want to view the generated Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                        System.Diagnostics.Process.Start("Sample.docx");
                        //Exit
                        this.Close();
                    }
                    catch (Win32Exception ex)
                    {
                        MessageBoxAdv.Show("Microsoft Word Viewer or Microsoft Word is not installed in this system");
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        #endregion
    }
}

