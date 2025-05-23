#region Copyright Syncfusion Inc. 2001 - 2011
// Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
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

namespace ChartLabelHierarchy
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : MetroForm
    {
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl;
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Timer timer1;
        private Label label6;
        private Label label40;
        private Panel panel1;
        private ChartAxis secYAxis = new ChartAxis();

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
            ChartAppearance.ApplyChartStyles(chartControl);           
            this.BackColor = Color.White;
            this.chartControl.Dock = DockStyle.Fill;


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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chartControl = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl
            // 
            this.chartControl.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl.ChartArea.CursorReDraw = false;
            this.chartControl.DataSourceName = "";
            this.chartControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.chartControl.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl.Legend.Location = new System.Drawing.Point(845, 31);
            this.chartControl.Localize = null;
            this.chartControl.Location = new System.Drawing.Point(0, 0);
            this.chartControl.Name = "chartControl";
            this.chartControl.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl.PrimaryXAxis.Margin = true;
            this.chartControl.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl.PrimaryYAxis.Margin = true;
            this.chartControl.Size = new System.Drawing.Size(954, 440);
            this.chartControl.TabIndex = 0;
            // 
            // 
            // 
            this.chartControl.Title.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl.Title.Name = "Def_title";
            this.chartControl.Title.Text = "";
            this.chartControl.Titles.Add(this.chartControl.Title);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(10, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(688, 45);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sample Description";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label40
            // 
            this.label40.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label40.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label40.Location = new System.Drawing.Point(3, 45);
            this.label40.Location = new System.Drawing.Point(10, 45);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(948, 81);
            this.label40.TabIndex = 8;
            this.label40.Text = resources.GetString("label40.Text");
            // 
            // panel1
            // 
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label40);
            this.panel1.Location = new System.Drawing.Point(0, 443);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 126);
            this.panel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(954, 581);
            this.Controls.Add(this.chartControl);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(714, 527);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DateTime Axis";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

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
        ChartSeries series;
        private void Form1_Load(object sender, System.EventArgs e)
        {
         InitializeChartData();
        }

        #region InitializeChartData
        void InitializeChartData()
        {
            this.chartControl.Text = "Yearly view for Stock";
            this.chartControl.PrimaryXAxis.Title = "Date";
            this.chartControl.PrimaryYAxis.Title = "Stock Price";
            this.chartControl.ShowLegend = false;
            this.chartControl.PrimaryXAxis.Zooming += new ChartAxisZoomingEventHandler(PrimaryXAxis_Zooming);

            DateTime dt = new DateTime(1998, 05, 05, 4, 47, 33);
            this.chartControl.PrimaryXAxis.ValueType = ChartValueType.DateTime;
            this.chartControl.PrimaryXAxis.DateTimeFormat = "yyyy";
            this.chartControl.PrimaryXAxis.LabelRotate = true;
            this.chartControl.PrimaryXAxis.LabelRotateAngle = 90;
            series = new ChartSeries("Market");
            series.Type = ChartSeriesType.Spline;
            Random ran = new Random();
            this.chartControl.BeginUpdate();
            for (int i = 1; i < 4380; i++)
            {
                series.Points.Add(dt.AddDays(i), i + ran.Next(2, 100));
            }
            this.chartControl.EndUpdate();
            this.chartControl.Series.Add(series);

            this.chartControl.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(series.Points[0].DateX, series.Points[series.Points.Count - 1].DateX, 1, ChartDateTimeIntervalType.Years);
            this.chartControl.EnableXZooming = true;

            this.chartControl.GetHScrollBar(this.chartControl.PrimaryXAxis).ZoomButton.Size = new Size(0, 0);
        }
        #endregion

        #region SetHierarchy Label
        void PrimaryXAxis_Zooming(object sender, ChartAxisZoomingArgs args)
        {
            if (args.ZoomFactor <= 0.5 && Cursors.Equals(this.chartControl.Cursor, Cursors.Cross))
            {
                ChartDateTimeIntervalType type = this.chartControl.PrimaryXAxis.DateTimeRange.DefaultInterval.Type;
                switch (type)
                {
                    case ChartDateTimeIntervalType.Years:
                        this.chartControl.PrimaryXAxis.DateTimeFormat = "MMM-yy";
                        this.chartControl.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(series.Points[0].DateX, series.Points[series.Points.Count - 1].DateX, 2, ChartDateTimeIntervalType.Months);
                        this.chartControl.Text = "Monthly View for Stock";
                        break;
                    case ChartDateTimeIntervalType.Months:
                        this.chartControl.PrimaryXAxis.DateTimeFormat = "ddd,d,MMM-yy";
                        this.chartControl.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(series.Points[0].DateX, series.Points[series.Points.Count - 1].DateX, 5, ChartDateTimeIntervalType.Weeks);
                        this.chartControl.Text = "Weekly View for Stock";

                        break;
                    case ChartDateTimeIntervalType.Weeks:
                        this.chartControl.PrimaryXAxis.DateTimeFormat = "dd-MM-yy";
                        this.chartControl.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(series.Points[0].DateX, series.Points[series.Points.Count - 1].DateX, 20, ChartDateTimeIntervalType.Days);
                        this.chartControl.Text = "Day View for Stock";

                        break;
                    case ChartDateTimeIntervalType.Days:
                        this.chartControl.PrimaryXAxis.DateTimeFormat = "HH:mm";
                        this.chartControl.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(series.Points[0].DateX, series.Points[series.Points.Count - 1].DateX, 125, ChartDateTimeIntervalType.Hours);
                        this.chartControl.Text = "Hour View for Stock";
                        break;
                }
            }
            else
            {
                if (args.ZoomFactor == 1)
                {
                    this.chartControl.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(series.Points[0].DateX, series.Points[series.Points.Count - 1].DateX, 1, ChartDateTimeIntervalType.Years);
                    this.chartControl.PrimaryXAxis.DateTimeFormat = "yyyy";
                    this.chartControl.Text = "Yearly view for Stock";

                }
            }
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