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
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms;

namespace HistogramChart
{
    public partial class Form1 : MetroForm
    {
        # region Form Load
        public Form1()
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
            InitializeComponent();
            InitializeChartData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }
        #endregion       

        #region InitializeChartData
        protected void InitializeChartData()
        {
            Random r = new Random();
            double[] points = {   5.250,7.750,9.000,8.275,9.750,7.750,8.275,6.250,5.750,5.250};

            double[] points1 = {  23.000,26.500,27.750,25.025,26.500,26.500,28.025,29.250,26.750,27.250,
                                  26.250,25.250,34.500,25.625,25.500,26.625,36.275,36.250,26.875,40.000
                               };

            double[] points2 = {  43.000,46.500,47.750,45.025,56.500,56.500,58.025,59.250,56.750,57.250,
                                  46.250,55.250,44.500,45.525,55.500,46.625,46.275,56.250,46.875,43.000,
                                  46.250,55.250,44.500,45.425,55.500,56.625,46.275,56.250,46.875,43.000,
                                  46.250,55.250,44.500,45.425,55.500,46.625,56.275,46.250,56.875,41.000
                               };

            double[] points3 = {  63.000,66.500,67.750,65.025,66.500,76.500,78.025,79.250,76.750,77.250,
                                  66.250,75.250,74.500,65.625,75.500,76.625,76.275,66.250,66.875,80.000
                               };

            double[] points4 = { 85.250, 87.750, 89.000, 88.275, 89.750, 97.750, 98.275, 96.250, 95.750, 95.250 };


            for (int i = 1; i <= 1; i++)
            {
                ChartSeries Histogram = new ChartSeries("Students Result", ChartSeriesType.Histogram);
                for (int j = 0; j < 10; j++)
                {
                    Histogram.Points.Add(points[j], 10);
                }

                for (int j = 0; j < 20; j++)
                {
                    Histogram.Points.Add(points1[j], 10);
                }

                for (int j = 0; j < 40; j++)
                {
                    Histogram.Points.Add(points2[j], 10);
                }

                for (int j = 0; j < 20; j++)
                {
                    Histogram.Points.Add(points3[j], 10);
                }

                for (int j = 0; j < 10; j++)
                {
                    Histogram.Points.Add(points4[j], 10);
                }
                Histogram.Text = Histogram.Name;
                Histogram.ConfigItems.HistogramItem.NumberOfIntervals = 5;
                Histogram.ConfigItems.HistogramItem.ShowNormalDistribution = true;
                this.chartControl1.Series.Add(Histogram);
            }
            this.chartControl1.DropSeriesPoints = true;
            this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryXAxis.Range = new MinMaxInfo(0, 100, 10);

            this.chartControl1.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryYAxis.Range = new MinMaxInfo(0, 50, 10);

        }

        #endregion

        # region Events

          private void chartControl1_ChartRegionMouseHover(object sender, ChartRegionMouseEventArgs e)
        {
            if (e.Region.IsChartPoint)
            {
                e.Region.ToolTip = e.Region.ToolTip.ToString();
            }
        }
        #endregion
      
    }
}