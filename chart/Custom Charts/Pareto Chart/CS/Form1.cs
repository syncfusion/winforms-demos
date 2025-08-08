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

namespace Pareto
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
        private ChartAxis secYAxis = new ChartAxis();

        public Form1()
        {
            BorderColor = Color.FromArgb(0xFF, 0xCD, 0xCD, 0xCD);
            BorderThickness = 3;
            CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(75.0f);
            CaptionBarColor = Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2);
            CaptionFont = new Font("Segow UI", 22.0f);
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
            this.SuspendLayout();
            // 
            // chartControl
            // 
            this.chartControl.Dock = DockStyle.Fill;
            this.chartControl.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl.ChartArea.CursorReDraw = false;
            this.chartControl.DataSourceName = "";
            this.chartControl.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl.Legend.Location = new System.Drawing.Point(802, 31);
            this.chartControl.Localize = null;
            this.chartControl.Location = new System.Drawing.Point(22, 22);
            this.chartControl.Name = "chartControl";
            this.chartControl.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl.PrimaryXAxis.Margin = true;
            this.chartControl.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl.PrimaryYAxis.Margin = true;
            this.chartControl.Size = new System.Drawing.Size(911, 540);
            this.chartControl.TabIndex = 0;
            // 
            // 
            // 
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
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(958, 584);
            this.Controls.Add(this.chartControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(570, 414);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pareto";
            this.Load += new System.EventHandler(this.Form1_Load);
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

        private void Form1_Load(object sender, System.EventArgs e)
        {
            CreateParetoChart();
        }

        protected void CreateParetoChart()
        {
            this.chartControl.Title.Text = "Pareto Chart";
            this.chartControl.Series.Clear();

            ChartSeries series1 = new ChartSeries("Defects");
            series1.Type = ChartSeriesType.Column;
            series1.Points.Add(1, 120);
            series1.Points.Add(2, 60);
            series1.Points.Add(3, 50);
            series1.Points.Add(4, 40);
            series1.Points.Add(5, 20);
            series1.Points.Add(6, 10);
            //series1.Style.Interior = new BrushInfo(Color.FromArgb(200, 140, 198, 62));
            //series1.Style.Border.Color = Color.Transparent;
            this.chartControl.Series.Add(series1);
            this.chartControl.PrimaryXAxis.FormatLabel += new ChartFormatAxisLabelEventHandler(PrimaryXAxis_FormatLabel);
            this.chartControl.PrimaryXAxis.HidePartialLabels = true;
            this.chartControl.PrimaryXAxis.Title = "Defects";
            this.chartControl.Skins = Skins.Metro;

            ChartSeries ser = new ChartSeries("Frequency", ChartSeriesType.Line);
            ser.Style.Border.Width = 3;
            //ser.Style.Interior = new BrushInfo(Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2));
            ser.Points.Add(0, 0);

            double val = 0;
            // To get the Total of all points.
            for (int j = 0; j < this.chartControl.Series[0].Points.Count; j++)
            {
                val += this.chartControl.Series[0].Points[j].YValues[0];
            }

            int i = 0;
            // To get the cumulative points [ Y Values ] for line series.
            for (; i < this.chartControl.Series[0].Points.Count; i++)
            {
                double val1 = 0;
                for (int k = 0; k <= i; k++)
                {
                    val1 += this.chartControl.Series[0].Points[k].YValues[0];
                }

                ser.Points.Add(i + 1, (val1 / val) * 100); // calculates percentage of cumulative values
            }

            this.chartControl.PrimaryYAxis.Range.Max = val;
            this.chartControl.PrimaryYAxis.Title = "Frequency";
            
            ser.Style.Symbol.Shape = ChartSymbolShape.Diamond;
            ser.Style.Symbol.Color = Color.Yellow;
            ser.Style.Symbol.Size = new Size(7, 7);
            this.chartControl.Series.Add(ser);
            this.chartControl.PrimaryYAxis.Range.Max = val;

            secYAxis.DrawGrid = false;
            secYAxis.HidePartialLabels = false;

            secYAxis.OpposedPosition = true;
            secYAxis.Title = "Cumulative Frequency";
            secYAxis.ForeColor = Color.Black;
            secYAxis.TitleFont = new Font("Segoe UI", 13F, FontStyle.Regular);
            secYAxis.ValueType = ChartValueType.Double;
            secYAxis.Orientation = ChartOrientation.Vertical;
            secYAxis.TickSize = new Size(5, 1);

            this.chartControl.Series[1].YAxis = secYAxis;
            this.chartControl.ChartArea.YAxesLayoutMode = ChartAxesLayoutMode.Stacking;
            this.chartControl.Axes.Add(secYAxis);

            // Set ranges
            secYAxis.Range = new MinMaxInfo(0, 100, 20);
            this.chartControl.PrimaryXAxis.Range = new MinMaxInfo(0, 7, 1);
            this.chartControl.PrimaryYAxis.Range.Min = 0;
            secYAxis.FormatLabel += new ChartFormatAxisLabelEventHandler(secYAxis_FormatLabel);
        }

        void PrimaryXAxis_FormatLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            e.Label = "D" + e.Label;
            e.Handled = true;
        }

        void secYAxis_FormatLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            e.Label += " %";
            e.Handled = true;
        }
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