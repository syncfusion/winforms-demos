#region Copyright Syncfusion Inc. 2001 - 2014
// Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
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

namespace WindowsApplication1
{
    public partial class Form1 : MetroForm
    {
        #region Form's Constructor
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

        #region Helper Methods
        #region InitializeChartData
        public void InitializeChartData()
        {
            ChartSeries series = new ChartSeries();
            series.Type = ChartSeriesType.Spline;
            series.Name = "Series 0";
            series.Text = "News and Media";
            series.Points.Add(new DateTime(2007, 1, 1), 13);
            series.Points.Add(new DateTime(2007, 2, 1), 8);
            series.Points.Add(new DateTime(2007, 3, 1), 21);
            series.Points.Add(new DateTime(2007, 4, 1), 13);
            series.Points.Add(new DateTime(2007, 5, 1), 15);
            series.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            //series.Style.DisplayShadow = true;
            series.Style.ImageIndex = 0;
            this.chartControl1.Series.Add(series);

            ChartSeries series1 = new ChartSeries();
            series1.Type = ChartSeriesType.Spline;
            series1.Name = "Series 1";
            series1.Text = "Finance Sector";
            series1.Points.Add(new DateTime(2007, 1, 1), 18);
            series1.Points.Add(new DateTime(2007, 2, 1), 5);
            series1.Points.Add(new DateTime(2007, 3, 1), 26);
            series1.Points.Add(new DateTime(2007, 4, 1), 32);
            series1.Points.Add(new DateTime(2007, 5, 1), 20);
            series1.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            //series1.Style.DisplayShadow = true;
            series1.Style.ImageIndex = 1;
            this.chartControl1.Series.Add(series1);

            ChartSeries series2 = new ChartSeries();
            series2.Type = ChartSeriesType.Spline;
            series2.Name = "Series 2";
            series2.Text = "Imports And Exports";
            series2.Points.Add(new DateTime(2007, 1, 1), 0);
            series2.Points.Add(new DateTime(2007, 2, 1), 12);
            series2.Points.Add(new DateTime(2007, 3, 1), 20);
            series2.Points.Add(new DateTime(2007, 4, 1), 16);
            series2.Points.Add(new DateTime(2007, 5, 1), 35);
            series2.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            //series2.Style.DisplayShadow = true;
            series2.Style.ImageIndex = 2;
            this.chartControl1.Series.Add(series2);

            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;

            this.chartControl1.Series[0].Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(246, 100, 15));
            this.chartControl1.Series[0].Style.Border.Color = Color.Transparent;
            this.chartControl1.Series[0].Style.Border.Width = 2;
            this.chartControl1.Series[1].Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(36, 119, 51));
            this.chartControl1.Series[1].Style.Border.Color = Color.Transparent;
            this.chartControl1.Series[1].Style.Border.Width = 2;
            this.chartControl1.Series[2].Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(9, 116, 210));
            this.chartControl1.Series[2].Style.Border.Color = Color.Transparent;
            this.chartControl1.Series[2].Style.Border.Width = 2;

            this.chartControl1.Series[0].PrepareStyle += new ChartPrepareStyleInfoHandler(ChartControlSeries_PrepareStyle);
            this.chartControl1.Series[1].PrepareStyle += new ChartPrepareStyleInfoHandler(ChartControlSeries_PrepareStyle);
            this.chartControl1.Series[2].PrepareStyle += new ChartPrepareStyleInfoHandler(ChartControlSeries_PrepareStyle);
            this.chartControl1.PrimaryXAxis.InterlacedGridInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.WhiteSmoke);
            this.chartControl1.PrimaryYAxis.InterlacedGridInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.WhiteSmoke);  
        }
        #endregion

        #endregion

        #region Events

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Enable InterlacedGrid for Primary X Axis

           
            this.chartControl1.PrimaryXAxis.InterlacedGrid = this.cbInterlacedGridXAxis.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //Enable InterlacedGrid for Primary Y Axis
            this.chartControl1.PrimaryYAxis.InterlacedGrid = this.cbInterlacedGridYAxis.Checked;
        }

        protected void ChartControlSeries_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
        {
            ChartSeries series = sender as ChartSeries;
            if (args.Index == 17 && series.Name == "Series 0")
            {
                args.Style.Symbol.Shape = ChartSymbolShape.InvertedTriangle;
                args.Style.Symbol.Size = new Size(20, 20);
                args.Style.Symbol.Offset = new Size(0, -4);
                args.Style.Symbol.Color = Color.FromArgb(141, 188, 74);
            }

            if (args.Index == 17 && series.Name == "Series 2")
            {
                args.Style.Symbol.Shape = ChartSymbolShape.InvertedTriangle;
                args.Style.Symbol.Size = new Size(20, 20);
                args.Style.Symbol.Color = Color.FromArgb(236, 100, 24);
            }

            if (args.Index == 17 && series.Name == "Series 1")
            {
                args.Style.Symbol.Shape = ChartSymbolShape.Triangle;
                args.Style.Symbol.Size = new Size(20, 20);
                args.Style.Symbol.Offset = new Size(0, -6);
                args.Style.Symbol.Color = Color.FromArgb(255, 246, 0);
            }
        }

        private void chartControl1_ChartFormatAxisLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            if (e.AxisOrientation == ChartOrientation.Vertical)
            {
                //Applying Formatted Axis label values.
                e.Label = string.Format("{0}%", e.Value);
            }

            e.Handled = true;
        }
        #endregion
    }
}
