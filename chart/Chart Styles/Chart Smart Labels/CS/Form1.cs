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

namespace ChartSmartLabel_2005
{
    public partial class Form1 : MetroForm
    {
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
        }
        #region Private Member
        private int _Id = 1;
        #endregion

        #region FormLoad
        private void Form1_Load(object sender, EventArgs e)
        {
            this.InitializeChartData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            this.chartControl1.Dock = DockStyle.Fill;
        }
        #endregion

        #region Helper Methods
        protected void InitializeChartData()
        {
            ChartSeries series1 = new ChartSeries("Compound AA", ChartSeriesType.Scatter);
            series1.Style.Symbol.Color = Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2);
            series1.Style.Symbol.Shape = ChartSymbolShape.Square;
            series1.Style.TextOffset = 15;
            series1.SmartLabelsBorderColor = Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2);
            series1.SmartLabelsBorderWidth = 1;
            series1.PrepareStyle += new ChartPrepareStyleInfoHandler(series_PrepareStyle);

            ChartSeries series4 = new ChartSeries("Compound BB", ChartSeriesType.Scatter);
            series4.Style.Symbol.Color = Color.FromArgb(0xFF, 0xA0, 0x50, 0x00);
            series4.Style.TextOffset = -30;
            series4.Style.Symbol.Shape = ChartSymbolShape.Star;
            series4.PrepareStyle += new ChartPrepareStyleInfoHandler(series_PrepareStyle);
            series4.SmartLabelsBorderColor = Color.FromArgb(0xFF, 0xA0, 0x50, 0x00);
            series4.SmartLabelsBorderWidth = 1;

            ChartSeries series5 = new ChartSeries("Compound CC", ChartSeriesType.Scatter);
            series5.Style.Symbol.Color = Color.FromArgb(0xFF, 0x33, 0x99, 0x33);
            series5.Style.Symbol.Shape = ChartSymbolShape.Triangle;
            series5.Style.TextOffset = 15;
            series5.PrepareStyle += new ChartPrepareStyleInfoHandler(series_PrepareStyle);
            series5.SmartLabelsBorderColor = Color.FromArgb(0xFF, 0x33, 0x99, 0x33);
            series5.SmartLabelsBorderWidth = 1;

            ChartSeries series6 = new ChartSeries("Compound DD", ChartSeriesType.Scatter);
            series6.Style.Symbol.Color = Color.FromArgb(0xFF, 0xD8, 0x00, 0x73);
            series6.Style.Symbol.Shape = ChartSymbolShape.Hexagon;
            series6.PrepareStyle += new ChartPrepareStyleInfoHandler(series_PrepareStyle);
            series6.SmartLabelsBorderColor = Color.FromArgb(0xFF, 0xD8, 0x00, 0x73);
            series6.SmartLabelsBorderWidth = 1;

            series1.Points.Add(34.5745413, 20.3282866);
            series1.Points.Add(45.1144818, 22.2510141);
            series1.Points.Add(56.7960707, 30.6485916);
            series1.Points.Add(39.3946526, 29.6503113);
            series1.Points.Add(36.9149847, 12.036468);

            series4.Points.Add(33.6240289, 20.4293169);
            series4.Points.Add(25.959018, 15.0305531);
            series4.Points.Add(26.1158617, 22.2780683);
            series4.Points.Add(24.5590223, 11.1255066);
            series4.Points.Add(39.9605541, 17.2306935);
            series4.Points.Add(38.220167, 10.7499491);

            series5.Points.Add(49.9140424, 12.8742868);
            series5.Points.Add(53.8453009, 18.630743);
            series5.Points.Add(28.2494757, 22.3310421);
            series5.Points.Add(50.8416839, 01.9014331);

            series6.Points.Add(58.1815097, 18.1211902);
            series6.Points.Add(30.6000954, 20.3468524);
            series6.Points.Add(50.8396695, 18.8712833);
            series6.Points.Add(47.3161036, 01.6289029);
            series6.Points.Add(41.3283884, 10.5059598);

            this.chartControl1.Series.Add(series1);
            this.chartControl1.Series.Add(series4);
            this.chartControl1.Series.Add(series5);
            this.chartControl1.Series.Add(series6);

            for (int i = 0; i < this.chartControl1.Series.Count; i++)
            {
                this.chartControl1.Series[i].SmartLabels = true;
                this.chartControl1.Legend.ShowSymbol = true;
            }
        }

        void series_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
        {
            ChartSeries series = sender as ChartSeries;
            args.Style.DisplayText = true;
            args.Style.TextOrientation = ChartTextOrientation.Smart;
            args.Style.Text = "T" + this._Id.ToString();
            this._Id++;
            series.Style.Font.Facename = "Segoe UI";
            series.Style.Font.Size = 7;
        }
        #endregion
    }
}