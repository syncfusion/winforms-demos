using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Syncfusion.Presentation;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;
using Syncfusion.OfficeChart;
using Syncfusion.Licensing;
using System.Reflection;

namespace Images
{
    public partial class Form1 : MetroForm
    {
        #region Private Members
        private System.Windows.Forms.Button btnCreatePresn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;

        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        #endregion

        # region Constructor
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //            
            InitializeComponent();
            this.MinimizeBox = true;
            Application.EnableVisualStyles();
        }
        /// <summary>
        /// Helper method to find a syncfusion license key from the Common folder
        /// </summary>
        /// <param name="fileName">File name of the syncfusion license key</param>
        /// <returns></returns>
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCreatePresn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreatePresn
            // 
            this.btnCreatePresn.Location = new System.Drawing.Point(254, 153);
            this.btnCreatePresn.Name = "btnCreatePresn";
            this.btnCreatePresn.Size = new System.Drawing.Size(127, 26);
            this.btnCreatePresn.TabIndex = 0;
            this.btnCreatePresn.Text = "Customize Chart";
            this.btnCreatePresn.UseVisualStyleBackColor = true;
            this.btnCreatePresn.Click += new System.EventHandler(this.btnCreatePresn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 97);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 42);
            this.label1.TabIndex = 27;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 180);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCreatePresn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customizing Appearance";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        [STAThread]
        static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(FindLicenseKey());
            Application.Run(new Form1());
        }

        #endregion

        private void btnCreatePresn_Click(object sender, EventArgs e)
        {
            try
            {
                string input = @"..\..\..\..\..\..\..\Common\Data\Presentation\ChartInput.pptx";
                IPresentation presentation = Presentation.Open(input);
                //New Instance of PowerPoint is Created.[Equivalent to launching MS PowerPoint with no slides].

                //Method call to edit slides
                CreateSlide1(presentation);
                CreateSlide2(presentation);
                CreateSlide3(presentation);
                CreateSlide4(presentation);
                    //Saves the presentation as pptx format.
                    presentation.Save("ModifyChartSample.pptx");

                    if (MessageBox.Show("Do you want to view the generated PowerPoint Presentation?", "PowerPoint Presentation Created",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {

                        System.Diagnostics.Process.Start("ModifyChartSample.pptx");
                        this.Close();
                    }
            }
            catch (Exception exp)
            {
                MessageBox.Show("This file could not be created , please contact Syncfusion Direct-Trac system at http://www.syncfusion.com/support/default.aspx for any queries. ", "OOPS..Sorry!",
                        MessageBoxButtons.OK);

            }
        }
        # region Slide1
        private void CreateSlide1(IPresentation presentation)
        {
            ISlide slide1 = presentation.Slides[0];
            IPresentationChart chart = slide1.Charts[0] as IPresentationChart;
            chart.Legend.Position = OfficeLegendPosition.Top;
            chart.ChartArea.Fill.FillType = OfficeFillType.SolidColor;
            chart.ChartArea.Fill.ForeColor = Color.FromArgb(251, 229, 214);
            chart.ChartArea.Border.AutoFormat = false;
            chart.ChartArea.Border.IsAutoLineColor = false;
            chart.ChartArea.Border.LinePattern = OfficeChartLinePattern.Solid;
            chart.ChartArea.Border.LineColor = Color.FromArgb(32, 56, 100);
            chart.ChartArea.Border.LineWeight = OfficeChartLineWeight.Wide;
            chart.Series[0].DataPoints.DefaultDataPoint.DataLabels.IsValue = true;
            chart.Series[1].DataPoints.DefaultDataPoint.DataLabels.IsValue = true;
            chart.Series[2].DataPoints.DefaultDataPoint.DataLabels.IsValue = true;
        }
        #endregion

        #region Slide2
        private void CreateSlide2(IPresentation presentation)
        {
            ISlide slide2 = presentation.Slides[1];
            IPresentationChart chart = slide2.Shapes[0] as IPresentationChart;
            chart.HasDataTable = true;
            chart.DataTable.HasBorders = true;
            chart.DataTable.HasHorzBorder = true;
            chart.DataTable.HasVertBorder = true;
            chart.DataTable.ShowSeriesKeys = true;
            chart.DataTable.TextArea.FrameFormat.Border.AutoFormat = false;
            chart.DataTable.TextArea.FrameFormat.Border.IsAutoLineColor = false;
            chart.DataTable.TextArea.FrameFormat.Border.LineColor = Color.FromArgb(143, 170, 220);
            chart.DataTable.TextArea.FrameFormat.Border.LinePattern = OfficeChartLinePattern.Solid;
            chart.DataTable.TextArea.FrameFormat.Border.LineWeight = OfficeChartLineWeight.Medium;


            chart.PlotArea.Fill.FillType = OfficeFillType.SolidColor;
            chart.PlotArea.Fill.ForeColor = Color.FromArgb(112, 48, 160);
            chart.PlotArea.Fill.Transparency = 0.75;

            chart.PlotArea.Border.AutoFormat = false;
            chart.PlotArea.Border.IsAutoLineColor = false;
            chart.PlotArea.Border.LinePattern = OfficeChartLinePattern.Solid;
            chart.PlotArea.Border.LineWeight = OfficeChartLineWeight.Wide;
            chart.PlotArea.Border.LineColor = Color.FromArgb(132, 151, 176);




        }

        #endregion

        # region Slide3
        private void CreateSlide3(IPresentation presentation)
        {
            ISlide slide2 = presentation.Slides[2];
            IPresentationChart chart = slide2.Charts[0] as IPresentationChart;
            chart.PlotArea.Fill.FillType = OfficeFillType.SolidColor;
            chart.PlotArea.Fill.ForeColor = Color.FromArgb(251, 229, 214);
            chart.Series[0].DataPoints[0].DataFormat.Fill.FillType = OfficeFillType.SolidColor;
            chart.Series[0].DataPoints[0].DataFormat.Fill.ForeColor = Color.FromArgb(244, 177, 131);
            chart.Series[0].DataPoints[1].DataFormat.Fill.FillType = OfficeFillType.SolidColor;
            chart.Series[0].DataPoints[1].DataFormat.Fill.ForeColor = Color.FromArgb(255, 230, 153);
            chart.Series[0].DataPoints[2].DataFormat.Fill.FillType = OfficeFillType.SolidColor;
            chart.Series[0].DataPoints[2].DataFormat.Fill.ForeColor = Color.FromArgb(132, 151, 176);
            chart.Series[0].DataPoints[3].DataFormat.Fill.FillType = OfficeFillType.SolidColor;
            chart.Series[0].DataPoints[3].DataFormat.Fill.ForeColor = Color.FromArgb(157, 195, 230);

        }

        #endregion

        #region Slide4
        private void CreateSlide4(IPresentation presentation)
        {
            ISlide slide4 = presentation.Slides[3];
            IPresentationChart chart = slide4.Charts[0] as IPresentationChart;
            chart.Series[0].SerieFormat.CommonSerieOptions.GapWidth = 81;
            chart.PlotArea.Border.AutoFormat = false;
            chart.PlotArea.Border.IsAutoLineColor = false;
            chart.PlotArea.Border.LinePattern = OfficeChartLinePattern.Solid;
            chart.PlotArea.Border.LineWeight = OfficeChartLineWeight.Wide;
            chart.PlotArea.Border.LineColor = Color.FromArgb(143, 173, 220);
        }
        #endregion

    }
}
