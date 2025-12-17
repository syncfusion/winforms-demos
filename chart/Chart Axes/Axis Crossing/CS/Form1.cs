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
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;

namespace Crossing_Demo_2008
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



        private void InitChart()
        {
            this.chartControl1.PrimaryXAxis.DrawGrid = false;
            this.chartControl1.PrimaryYAxis.DrawGrid = false;

        }
        private void Appearanceset()
        {
            chartControl1.Skins = Skins.Metro;

            #region Chart Appearance Customization

            chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.None;
            chartControl1.BorderAppearance.BaseColor = Color.DarkOliveGreen;
            chartControl1.BorderAppearance.FrameThickness = new ChartThickness(-2, -2, 2, 2);
            chartControl1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            chartControl1.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            chartControl1.ElementsSpacing = 5;

            #endregion

            #region Axes Customization

            chartControl1.PrimaryXAxis.HidePartialLabels = true;
            chartControl1.PrimaryYAxis.HidePartialLabels = true;
                chartControl1.Legend.Visible = false;
             chartControl1.Titles[0].Font = new Font("Segoe UI", 16.0f, FontStyle.Regular);

            #endregion
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            InitChart();
            this.chartControl1.Text = "Peak Average Network loads";
            ChartSeries ser = new ChartSeries("Area");
            ChartSeries ser1 = new ChartSeries("Spline");

            ser.Points.Add(2, 45);
            ser.Points.Add(5, 100);
            ser.Points.Add(7, 210);
            ser.Points.Add(9, 110);
            ser.Points.Add(10, 150);
            ser.Points.Add(11, 180);
            ser1.Points.Add(2, 45);
            ser1.Points.Add(5, 100);
            ser1.Points.Add(7, 210);
            ser1.Points.Add(9, 110);
            ser1.Points.Add(10, 150);
            ser1.Points.Add(11, 180);
            ser.Type = ChartSeriesType.Spline;
            ser1.Type = ChartSeriesType.Area;
            this.chartControl1.Series.Add(ser);
            this.chartControl1.Series.Add(ser1);
            this.comboBox1.SelectedIndex = 0;
			 this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox2.SelectedIndex = 0;
			 this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.chartControl1.Skins = Skins.Metro;

            Appearanceset();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)this.comboBox1.SelectedItem == "Min")
                this.chartControl1.PrimaryXAxis.Crossing = double.MinValue;
            else if ((string)this.comboBox1.SelectedItem == "Max")
                this.chartControl1.PrimaryXAxis.Crossing = double.MaxValue;
            else
                this.chartControl1.PrimaryXAxis.Crossing = Convert.ToDouble(this.comboBox1.SelectedItem);
            this.chartControl1.Redraw(true);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)this.comboBox2.SelectedItem == "Min")
                this.chartControl1.PrimaryYAxis.Crossing = double.MinValue;
            else if ((string)this.comboBox2.SelectedItem == "Max")
                this.chartControl1.PrimaryYAxis.Crossing = double.MaxValue;
            else
                this.chartControl1.PrimaryYAxis.Crossing = Convert.ToDouble(this.comboBox2.SelectedItem);
            this.chartControl1.Redraw(true);
        }

        

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                this.chartControl1.EnableXZooming = true;
                this.chartControl1.EnableYZooming = true;
            }
            else
            {
                this.chartControl1.EnableXZooming = false;
                this.chartControl1.EnableYZooming = false;
            }

        }

     


    }
}
