#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;


namespace LineChart2002
{
    public class Form1 : MetroForm
    {
        #region Private Members
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;

        int count = 0;

        #endregion

        private ChartControl chartControl2;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private IContainer components;

        #region Constructor, Main And Dispose
        public Form1()
        {
            BorderColor = Color.FromArgb(0xFF, 0xCD, 0xCD, 0xCD);
            BorderThickness = 3;
            CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(75.0f);
            CaptionBarColor = Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2);
            CaptionFont = new Font("Segoe UI", 22.0f);
            CaptionForeColor = Color.White;
            CaptionAlign = HorizontalAlignment.Left;
            ShowIcon = false;
            CaptionButtonColor = Color.White;
            CaptionButtonHoverColor = Color.White; 
            InitializeComponent();
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.EnableVisualStyles();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.chartControl2 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254))))), System.Drawing.Color.White);
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(194)))), ((int)(((byte)(229))))), System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(250))))));
            this.chartControl1.DataSourceName = "";
            this.chartControl1.ElementsSpacing = 1;
            this.chartControl1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.Legend.Border.ForeColor = System.Drawing.Color.Transparent;
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.Legend.ItemsSize = new System.Drawing.Size(15, 15);
            this.chartControl1.Legend.Location = new System.Drawing.Point(41, 48);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top;
            this.chartControl1.Legend.ShowSymbol = true;
            this.chartControl1.Legend.Spacing = 3;
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(10, 10);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.Silver;
            this.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.DarkGray;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.Silver;
            this.chartControl1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.DarkGray;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.Rotation = 90F;
            this.chartControl1.Size = new System.Drawing.Size(492, 420);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "EssentialChart";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "EssentialChart";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // chartControl2
            // 
            this.chartControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl2.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl2.ChartArea.CursorReDraw = false;
            this.chartControl2.DataSourceName = "";
            this.chartControl2.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl2.Legend.Location = new System.Drawing.Point(299, 75);
            this.chartControl2.Localize = null;
            this.chartControl2.Location = new System.Drawing.Point(508, 10);
            this.chartControl2.Name = "chartControl2";
            this.chartControl2.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl2.PrimaryXAxis.Margin = true;
            this.chartControl2.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl2.PrimaryYAxis.Margin = true;
            this.chartControl2.Size = new System.Drawing.Size(408, 420);
            this.chartControl2.TabIndex = 4;
            this.chartControl2.Text = "chartControl2";
            // 
            // 
            // 
            this.chartControl2.Title.Name = "Default";
            this.chartControl2.Titles.Add(this.chartControl2.Title);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(144, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "SAVE TEMPLATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(659, 526);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "LOAD TEMPLATE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chartControl2);
            this.panel1.Controls.Add(this.chartControl1);
            this.panel1.Location = new System.Drawing.Point(2, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 430);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 581);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(856, 496);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serialization";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            InitializeChartData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);

            this.panel1.Dock = DockStyle.Top;

        }

        #endregion

        #region Helper Methods

        #region InitializeChartData
        protected void InitializeChartData()
        {
            ChartSeries series1 = new ChartSeries("IND");
            series1.Text = series1.Name;
            series1.Type = ChartSeriesType.Line;
            // 4, 3, 3, 3, 5, 4, 5, 6, 8, 9,10, 9, 12, 11, 5,

            double[] points1 =  {2, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1,2 };
            int i = 0;
            for (int j = 1985; j < 2003 && i < 16; j++, i++)
            {
                series1.Points.Add(j, points1[i]);
            }
            this.chartControl1.Series.Add(series1);

            ChartSeries series2 = new ChartSeries("RSA");
            series2.Text = series2.Name;
            series2.Type = ChartSeriesType.Line;
            //6,9,10,10,12,8,10,5,6,5,4,3,4,2,3,
            i = 0;
            double[] points2 = {8,5,4,4,3,3,3,3,4,5,4,3,2,3,2,1};

            for (int k = 1985; k < 2003 && i < 16; k++, i++)
            {
                series2.Points.Add(k, points2[i]);
            }
            this.chartControl1.Series.Add(series2);


            ChartSeries series3 = new ChartSeries("PAK");
            series3.Text = series3.Name;
            series3.Type = ChartSeriesType.Line;
            // 19,17,18,23,21,18,16,14,9,10,8,6,6,8,10,
            i = 0;
            double[] points3 = {11,15,14,10,11,6,4,6,2,2,2,2,3,4,4,4};

            for (int l = 1985; l < 2003 && i < 16; l++, i++)
            {
                series3.Points.Add(l, points3[i]);
            }

            this.chartControl1.Series.Add(series3);

         
            
        }

        #endregion

       
        #endregion

        #region Events
        private void button1_Click(object sender, EventArgs e)
        {
            ChartTemplate.Save(this.chartControl1, "Chart.xml");
            this.button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChartTemplate.Load(this.chartControl2, "Chart.xml");
        }

        #endregion

    }
    /// <summary>
    /// Represents a class that is used to find the licensing file for Syncfusion controls.
    /// </summary>
    internal class DemoCommon
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
                return System.IO.File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }
}
