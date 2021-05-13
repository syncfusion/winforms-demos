#region Copyright Syncfusion Inc. 2001 - 2009
//
//  Copyright Syncfusion Inc. 2001 - 2009. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;

namespace StockAndVolumeChart
{
    public class Form1 : MetroForm
    {
        #region Private Members

        private ChartAxis secaxis = new ChartAxis();
        private ChartAxis yaxis = new ChartAxis();
        private DateTime d;
        private Random rand = new Random();
        private Label label1;
        private IContainer components = null;
        private ChartControl chartControl1;

        #endregion

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
            //
            // Required for Windows Form Designer support
            //
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
            this.label1 = new System.Windows.Forms.Label();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = DockStyle.None ;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(120, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 20);
            this.label1.TabIndex = 1;
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.DataSourceName = "";
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Location = new System.Drawing.Point(539, 75);
            this.chartControl1.Legend.Visible = false;
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(12, 12);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.PrimaryYAxis.ForceZero = true;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.Size = new System.Drawing.Size(924, 557);
            this.chartControl1.TabIndex = 2;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 581);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(711, 530);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock and Volume";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }
        #endregion

        #region Form Load

        private void Form1_Load(object sender, System.EventArgs e)
        {
            InitializeChartData();
            CalculateVolume();
            SetAxesRanges();
            CreateStripLine();

            this.label1.BringToFront();
            chartControl1.ChartRegionMouseHover += new ChartRegionMouseEventHandler(chartControl1_ChartRegionMouseHover);
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }

        #endregion

        #region Helper Methods

        #region GetPointIndex
        //Binary Search to get the corresponding point index.
        int GetPointIndex(DateTime x, int seriesIndex)
        {
            int low = 0, high = chartControl1.Series[seriesIndex].Points.Count;
            int mid = 0;
            try
            {
                while (low <= high)
                {
                    mid = (low + high) / 2;
                    if (chartControl1.Series[seriesIndex].Points[mid].DateX.Date > x.Date)
                        high = mid - 1;
                    else if (chartControl1.Series[seriesIndex].Points[mid].DateX.Date < x.Date)
                        low = mid + 1;
                    else
                        return mid; //found
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return -1; //not found
        }
        #endregion

        #region CreateStripLine
        /// <summary>
        /// Draws a strip line that acts as a separator between two chart areas.
        /// </summary>
        private void CreateStripLine()
        {
            ChartStripLine sLine = new ChartStripLine();
            sLine.Enabled = true;
            sLine.StartAtAxisPosition = false;
            sLine.Vertical = false;
            sLine.Start = 112;
            sLine.Width = 4;
            sLine.End = sLine.Start + sLine.Width + 1;
            sLine.Font = new Font("Segoe UI", 8f);
            sLine.Text = " ";
            sLine.TextAlignment = ContentAlignment.MiddleCenter;
            sLine.TextColor = Color.Maroon;
            sLine.Interior = new BrushInfo(GradientStyle.Vertical, Color.DarkOliveGreen, Color.Olive);
            chartControl1.PrimaryYAxis.StripLines.Add(sLine);
        }

        #endregion

        #region InitializeChartData
        /// <summary>
        /// Initializes the chart data for Stock Series
        /// </summary>
        ChartSeries series1;
        private void InitializeChartData()
        {
            d = DateTime.Now;

            series1 = new ChartSeries();
            series1.Name = "Stock1";
            series1.Type = ChartSeriesType.Candle;

            series1.Text = series1.Name;

            this.chartControl1.Series.Add(series1);
            //Date, High, Low, Close, Open values.
            for (int i = 0; i < 60; i++)
            {
                if (i <= 10)
                {
                    series1.Points.Add(d.AddDays(i), rand.Next(32, 38), rand.Next(20, 24),
                rand.Next(28, 32), rand.Next(24, 32));
                }

                // small one
                else if (i > 10 && i <= 12)
                    series1.Points.Add(d.AddDays(i), rand.Next(42, 45), rand.Next(30, 34),
                rand.Next(36, 42), rand.Next(38, 42));

                else if (i > 12 && i <= 19)
                    series1.Points.Add(d.AddDays(i), rand.Next(48, 50), rand.Next(40, 42),
                rand.Next(42, 48), rand.Next(44, 48));

                // small
                else if (i > 19 && i <= 23)
                    series1.Points.Add(d.AddDays(i), rand.Next(54, 60), rand.Next(45, 49),
                rand.Next(49, 54), rand.Next(50, 52));

                else if (i > 23 && i <= 29)
                    series1.Points.Add(d.AddDays(i), rand.Next(54, 60), rand.Next(45, 49),
                rand.Next(49, 54), rand.Next(50, 54));

                //small
                else if (i > 29 && i <= 32)
                    series1.Points.Add(d.AddDays(i), rand.Next(62, 65), rand.Next(55, 57),
                rand.Next(57, 62), rand.Next(60, 62));

                else if (i > 32 && i <= 49)
                    series1.Points.Add(d.AddDays(i), rand.Next(68, 72), rand.Next(60, 64),
                rand.Next(62, 68), rand.Next(64, 68));

                else if (i > 49 && i <= 51)
                    series1.Points.Add(d.AddDays(i), rand.Next(58, 60), rand.Next(55, 58),
                rand.Next(58, 64), rand.Next(63, 64));

                else if (i > 51)
                    series1.Points.Add(d.AddDays(i), rand.Next(60, 65), rand.Next(52, 54),
                rand.Next(54, 58), rand.Next(56, 58));
            }

            this.chartControl1.Series[0].YAxis = this.yaxis;
            series1.PrepareStyle += new ChartPrepareStyleInfoHandler(series_PrepareStyle);
            this.chartControl1.PrimaryYAxis.Title = "Trade volume (M)";
            this.chartControl1.Text = "Price History";
        }

        #endregion

        #region CalculateVolume

        /// <summary>
        /// Initializes the chart data for Volume series.
        /// </summary>
        protected void CalculateVolume()
        {
            d = DateTime.Now;

            ChartSeries series = new ChartSeries();
            series.Name = "Volume";
            series.Type = ChartSeriesType.Column;
            series.Text = series.Name;

            for (int i = 0; i < 60; i++)
                series.Points.Add(d.AddDays(i), (rand.Next(10, 100)));

            this.chartControl1.Series.Add(series);
            this.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.Rotate;
        }

        #endregion

        #region SetAxesRanges
        protected void SetAxesRanges()
        {
            d = DateTime.Now;
            yaxis.LineType.ForeColor = Color.Olive;
            yaxis.GridLineType.ForeColor = Color.Olive;
            yaxis.Font = new Font("Segoe UI", 8f);

            this.yaxis.Orientation = ChartOrientation.Vertical;
            this.yaxis.RangeType = ChartAxisRangeType.Set;
            this.yaxis.Range = new MinMaxInfo(20, 80, 10);
            this.yaxis.Title = "Stock Price ($)";
            this.yaxis.Format = "   0";
            this.yaxis.TickColor = Color.Transparent;
            this.yaxis.Font = new Font("Verdana", 8.25F, FontStyle.Bold);
            this.yaxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.chartControl1.Axes.Add(yaxis);

            this.chartControl1.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryYAxis.Range = new MinMaxInfo(0, 120, 20);
            this.chartControl1.PrimaryYAxis.Format = " 0";
            this.chartControl1.PrimaryYAxis.HidePartialLabels = true;
            this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime;
            this.chartControl1.PrimaryXAxis.DateTimeFormat = "MMM-dd-yy";
            this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(d.AddDays(-1), d.AddDays(this.chartControl1.Series[1].Points.Count), 10, ChartDateTimeIntervalType.Days);
            this.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.Rotate;
            this.chartControl1.ChartArea.YAxesLayoutMode = ChartAxesLayoutMode.SideBySide;
            this.chartControl1.Redraw(true);
        }

        #endregion

        #endregion

        #region Events
        /// <summary>
        /// Paints the stock series with up and down colors.
        /// </summary>
        private void series_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
        {
            ChartSeries series = sender as ChartSeries;
            if (series != null)
            {
                //Up Series - Open value < Close value - Painted with Green.
                // Down Series - Open value > Close value - Painted with Red.
                if (args.Index >= 0)
                {
                    if (series.Points[args.Index].YValues[3] > series.Points[args.Index].YValues[2])
                    {

                        args.Style.Interior = new BrushInfo(GradientStyle.Horizontal, Color.Red, Color.Red);
                        args.Style.Border.Color = Color.Red;
                    }
                    else
                    {
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(GradientStyle.Horizontal, Color.Green, Color.Green);
                        args.Style.Border.Color = Color.Green;
                    }
                }
            }
        }
        int stockPointIndex;
        void chartControl1_ChartRegionMouseHover(object sender, ChartRegionMouseEventArgs e)
        {
            ChartPoint cpt = chartControl1.ChartArea.GetValueByPoint(e.Point);

            for (int i = 0; i < chartControl1.Series[0].Points.Count; i++)
                chartControl1.Series[0].Styles[i].ResetSymbol();
            if (cpt != null && chartControl1.ChartArea.RenderBounds.Contains(e.Point))
            {
                chartControl1.CustomPoints.Clear();
                ChartPoint cpStock = null, cpVolume = null;
                Point clientPoint = Point.Empty;

                //Chart points for stock and volume series.
                stockPointIndex = GetPointIndex(cpt.DateX, 0);
                if (stockPointIndex != -1)
                    cpStock = this.chartControl1.Series[0].Points[stockPointIndex];
                int volumePointIndex = GetPointIndex(cpt.DateX, 1);
                if (volumePointIndex != -1)
                    cpVolume = this.chartControl1.Series[1].Points[volumePointIndex];

                if (cpStock != null && cpVolume != null)
                {
                    //Display Date, High, Low, Open, Close and Volume values.
                    this.label1.Text = "Date = " + cpt.DateX.ToShortDateString() + " Open = " + cpStock.YValues[3] + ", High = " + cpStock.YValues[0] + ", Low = " + cpStock.YValues[1] + ", Close = " + cpStock.YValues[2] + ", Volume = " + cpVolume.YValues[0];

                    //Custom Symbol at the active stock series point
                    this.chartControl1.Series[0].Styles[stockPointIndex].Symbol.Shape = ChartSymbolShape.Square;
                    this.chartControl1.Series[0].Styles[stockPointIndex].Symbol.Color = Color.Blue;
                    this.chartControl1.Series[0].Styles[stockPointIndex].Symbol.Size = new Size(7, 7);

                    //Custom Point at the active volume series point
                    ChartCustomPoint ptVolume = new ChartCustomPoint();
                    ptVolume.Symbol.Color = Color.Blue;
                    ptVolume.Symbol.Shape = ChartSymbolShape.Circle;
                    ptVolume.Symbol.Size = new Size(7, 7);
                    ptVolume.SeriesIndex = 1;
                    ptVolume.PointIndex = volumePointIndex;
                    ptVolume.CustomType = ChartCustomPointType.PointFollow;
                    chartControl1.CustomPoints.Add(ptVolume);
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
