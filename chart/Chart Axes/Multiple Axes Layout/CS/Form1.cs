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
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using System.Drawing.Drawing2D;
using Syncfusion.Drawing;

namespace MultipleAxesLayout
{
    public partial class Form1 : MetroForm
    {
       
        public Form1()
        {
            InitializeComponent();
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
        }

        #region Chart control Data.
        private void ChartControlData()
        {
            this.chartControl1.Series.Clear();
            this.chartControl1.Dock = DockStyle.Fill;
            ChartAxis axis = this.chartControl1.PrimaryYAxis;
            ChartAxis axis0 = new ChartAxis(ChartOrientation.Vertical);
            ChartAxis axis1 = new ChartAxis(ChartOrientation.Vertical);
            ChartAxis axis2 = new ChartAxis(ChartOrientation.Vertical);
            ChartAxis axis3 = new ChartAxis(ChartOrientation.Vertical);
            ChartAxis axis4 = new ChartAxis(ChartOrientation.Vertical);

            ChartAxisLayout layout1 = new ChartAxisLayout();
            ChartAxisLayout layout2 = new ChartAxisLayout();
            chartControl1.Axes.Add(axis0);
            chartControl1.Axes.Add(axis1);
            chartControl1.Axes.Add(axis2);
            chartControl1.Axes.Add(axis3);
            chartControl1.Axes.Add(axis4);

            layout1.Spacing = 12;
            layout2.Spacing = 12;
            layout2.Axes.Add(axis);
            layout2.Axes.Add(axis0);
            layout2.Axes.Add(axis1);
            layout1.Axes.Add(axis2);
            layout1.Axes.Add(axis3);
            layout1.Axes.Add(axis4);
            chartControl1.ChartArea.YLayouts.Add(layout1);
            chartControl1.ChartArea.YLayouts.Add(layout2);

            ChartSeries population = new ChartSeries("Population", ChartSeriesType.Column);
            population.Points.Add(0, 1.3);
            population.Points.Add(1, 1);
            population.Points.Add(2, 0.5);
            population.Points.Add(3, 0.3);

            ChartSeries Growth = new ChartSeries("Growth[%]", ChartSeriesType.Column);
            Growth.Points.Add(0, 0.7);
            Growth.Points.Add(1, 1.6);
            Growth.Points.Add(2, 0.7);
            Growth.Points.Add(3, 0.4);

            ChartSeries Birthrate = new ChartSeries("BirthRate", ChartSeriesType.Column);
            Birthrate.Points.Add(0, 15);
            Birthrate.Points.Add(1, 27);
            Birthrate.Points.Add(2, 17);
            Birthrate.Points.Add(3, 24);

            population.YAxis = axis;
            Growth.YAxis = axis0;
            Birthrate.YAxis = axis1;
            axis.Title = "Population (Million)";
            axis.TitleFont = new Font("Segeo UI", 12F);
            axis0.Title = "Growth [%]";
            axis0.TitleFont = new Font("Segeo UI", 12F);
            axis1.Title = "Birthrate";
            axis1.TitleFont = new Font("Segeo UI", 12F);
            ChartSeries GDP = new ChartSeries("GDP in 2000 ", ChartSeriesType.Line);
            GDP.Points.Add(0, 10);
            GDP.Points.Add(1, 5);
            GDP.Points.Add(2, 85);
            GDP.Points.Add(3, 5);
            GDP.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(0xFF, 0xA2, 0xC1, 0x39));
            GDP.Style.Border.Width = 2;

            ChartSeries Lifeexpect = new ChartSeries("Life Expect", ChartSeriesType.Spline);
            Lifeexpect.Points.Add(0, 70);
            Lifeexpect.Points.Add(1, 65);
            Lifeexpect.Points.Add(2, 85);
            Lifeexpect.Points.Add(3, 65);
            Lifeexpect.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(0xFF, 0xA0, 0x50, 0x00));
            Lifeexpect.Style.Border.Width = 2;

            ChartSeries Literacy = new ChartSeries("Literacy", ChartSeriesType.SplineArea);
            Literacy.Points.Add(0, 85);
            Literacy.Points.Add(1, 55);
            Literacy.Points.Add(2, 35);
            Literacy.Points.Add(3, 95);
            Literacy.Style.Border.Color = Color.Transparent;
            Literacy.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(0xFF, 0xE6, 0x71, 0xB8));

            this.chartControl1.Title.Visible = false;

            ChartAxis Xaxis = new ChartAxis();
            Xaxis.Orientation = ChartOrientation.Horizontal;
            Xaxis.OpposedPosition = true;
            Xaxis.Range = new MinMaxInfo(-1, 4, 1);
            Xaxis.DrawGrid = false;
            Xaxis.LineType.Width = 1F;
            Xaxis.LineType.ForeColor = Color.Black;
            this.chartControl1.Axes.Add(Xaxis);

            GDP.YAxis = axis2;
            GDP.XAxis = Xaxis;
            Lifeexpect.YAxis = axis3;
            Lifeexpect.XAxis = Xaxis;
            Literacy.YAxis = axis4;
            Literacy.XAxis = Xaxis;
            axis2.Title = "GDP pc in 1000";
            axis2.TitleFont = new Font("Segeo UI", 12F);
            axis3.Title = "Lifeexpect";
            axis3.TitleFont = new Font("Segeo UI", 12F);
            axis4.Title = "Literacy";
            axis4.TitleFont = new Font("Segeo UI", 12F);

            this.chartControl1.Series.Add(population);
            this.chartControl1.Series.Add(Growth);
            this.chartControl1.Series.Add(Birthrate);
            this.chartControl1.Series.Add(GDP);
            this.chartControl1.Series.Add(Lifeexpect);
            this.chartControl1.Series.Add(Literacy);
            this.chartControl1.Skins = Skins.Metro;

            axis1.OpposedPosition = true;
            axis1.DrawGrid = false;
            axis.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.Shift;
            axis0.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.Shift;
            axis1.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.Shift;
            axis2.OpposedPosition = true;
            axis0.DrawGrid = true;
            axis.DrawGrid = false;
            axis2.DrawGrid = false;
            axis2.DrawGrid = true;
            axis3.DrawGrid = false;
            axis4.DrawGrid = false;
            axis2.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.Shift;
            axis3.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.Shift;
            axis4.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.Shift;


        }
        #endregion

        #region Forn_Load

        private void Form1_Load(object sender, EventArgs e)
        {
            ChartControlData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            this.chartControl1.Dock = DockStyle.Fill;
            this.chartControl1.Skins = Skins.Metro;
        }
        #endregion

    }
}