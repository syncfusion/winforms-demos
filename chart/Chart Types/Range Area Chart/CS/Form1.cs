#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms;
using Syncfusion.Drawing;


namespace RangeAreaChart_Sample
{
    public partial class Form1 : MetroForm
    {
        #region Constructor
        
        DateTime d = DateTime.Now;
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            BorderColor = Color.FromArgb(0xFF, 0xCD, 0xCD, 0xCD);
            BorderThickness = 3;
            CaptionBarHeight = 75;
            CaptionBarColor = Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2);
            CaptionFont = new Font("Segoe UI", 22.0f);
            CaptionForeColor = Color.White;
            CaptionAlign = HorizontalAlignment.Left;
            ShowIcon = false;
            CaptionButtonColor = Color.White;
            CaptionButtonHoverColor = Color.White;
            InitializeChartData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            
        }
        #endregion

        #region Helper Methods        

        #region InitializeChartData
        protected void InitializeChartData()
        {
            this.chartControl1.Series.Clear();
           
            Random rand = new Random();

            ChartSeries series2 = new ChartSeries();
            series2.Type = ChartSeriesType.RangeArea;           
           
            ChartSeries series1 = new ChartSeries();
            series1.Name = "Stock1";
            series1.Type = ChartSeriesType.Candle;

            series1.Text = series1.Name;           
            this.chartControl1.Series.Add(series1);
            series1.PrepareStyle += new ChartPrepareStyleInfoHandler(series1_PrepareStyle);
            this.chartControl1.Series.Add(series2);
            //Date, High, Low, Close, Open values.
            for (int i = 0; i < 70; i++)
            {
                if (i <= 10)
                {
                    series1.Points.Add(d.AddDays(i), rand.Next(32, 38), rand.Next(20, 24),
                rand.Next(28, 32), rand.Next(24, 32));
                    series2.Points.Add(d.AddDays(i), rand.Next(13, 15), rand.Next(37, 40));
                }

                // small one
                else if (i > 10 && i <= 12)
                {
                    series1.Points.Add(d.AddDays(i), rand.Next(42, 45), rand.Next(30, 34),
                rand.Next(36, 42), rand.Next(38, 42));
                    series2.Points.Add(d.AddDays(i), rand.Next(20, 21), rand.Next(49,50));
                }

                else if (i > 12 && i <= 19)
                {
                    series1.Points.Add(d.AddDays(i), rand.Next(48, 50), rand.Next(40, 42),
                rand.Next(42, 48), rand.Next(44, 48));
                    series2.Points.Add(d.AddDays(i), rand.Next(31, 33), rand.Next(58, 60));
                }

                // small
                else if (i > 19 && i <= 23)
                {
                    series1.Points.Add(d.AddDays(i), rand.Next(54, 60), rand.Next(45, 49),
                rand.Next(49, 54), rand.Next(50, 52));
                    series2.Points.Add(d.AddDays(i), rand.Next(40, 45), rand.Next(60, 65));
                }

                else if (i > 23 && i <= 29)
                {
                    series1.Points.Add(d.AddDays(i), rand.Next(54, 60), rand.Next(45, 49),
                rand.Next(49, 54), rand.Next(50, 54));
                    series2.Points.Add(d.AddDays(i), rand.Next(40, 45), rand.Next(60, 65));
                }
                //small
                else if (i > 29 && i <= 32)
                {
                    series1.Points.Add(d.AddDays(i), rand.Next(62, 65), rand.Next(55, 57),
                rand.Next(57, 62), rand.Next(60, 62));
                    series2.Points.Add(d.AddDays(i), rand.Next(45,50), rand.Next(65, 70));
                }

                else if (i > 32 && i <= 49)
                {
                    series1.Points.Add(d.AddDays(i), rand.Next(68, 72), rand.Next(60, 64),
                rand.Next(62, 68), rand.Next(64, 68));
                    series2.Points.Add(d.AddDays(i), rand.Next(50, 55), rand.Next(75, 78));
                }

                else if (i > 49 && i <= 51)
                {
                    series1.Points.Add(d.AddDays(i), rand.Next(58, 60), rand.Next(55, 58),
                rand.Next(58, 64), rand.Next(63, 64));
                    series2.Points.Add(d.AddDays(i), rand.Next(50, 55), rand.Next(65,75));
                }

                else if (i > 51)
                {
                    series1.Points.Add(d.AddDays(i), rand.Next(60, 65), rand.Next(52, 54),
                rand.Next(54, 58), rand.Next(56, 58));
                    series2.Points.Add(d.AddDays(i), rand.Next(40, 45), rand.Next(60, 70));
                }
            }
            this.chartControl1.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryYAxis.Range = new MinMaxInfo(0, 100, 20);           
            this.chartControl1.PrimaryYAxis.Title = "Stock Price";
            this.chartControl1.Text = "Bollinger Bands";
            this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime;
            this.chartControl1.PrimaryXAxis.DateTimeFormat = "MMM-dd-yy";
            this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(d.AddDays(-1), d.AddDays(60), 10, ChartDateTimeIntervalType.Days);
            this.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.Rotate;
            

        }

        void series1_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
        {
            ChartSeries series = this.chartControl1.Series[0];
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
        #endregion
        #endregion

        #region Events       

      
        #endregion
    }
}