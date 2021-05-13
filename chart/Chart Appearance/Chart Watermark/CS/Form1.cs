#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
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
using Syncfusion.Drawing;

namespace ChartWaterMarker
{
    public partial class Form1 : MetroForm
    {

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

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            this.label4.Enabled = false;
            chartControl1.Legend.Visible = true;
            for (int i = 0; i < chartControl1.Legend.Items.Length; i++)
            {
                chartControl1.Legend.Items[i].Spacing = 10;
                chartControl1.Legend.BackColor = Color.Transparent;
                chartControl1.LegendsPlacement = ChartPlacement.Outside;
                chartControl1.LegendAlignment = ChartAlignment.Center;
                chartControl1.LegendPosition = ChartDock.Bottom;
                chartControl1.Legend.Font = new Font("Segoe UI", 12f);
            }
            this.comboBox3.Enabled = false;
        }
        #region InitializeData
        protected void InitializeData()
        {
            this.comboBox1.SelectedIndex = 1;
            this.comboBox2.SelectedIndex = 1;
            this.comboBox3.SelectedIndex = 1;

            this.chartControl1.Dock = DockStyle.Fill; 
#if NETCORE
            this.chartControl1.ChartArea.Watermark.Image = System.Drawing.Image.FromFile(@"..\..\..\..\..\..\..\Common\images\Chart\carsales.png");
#else
             this.chartControl1.ChartArea.Watermark.Image = System.Drawing.Image.FromFile(@"..\..\..\..\..\..\Common\images\Chart\carsales.png");
#endif

            this.panel1.Dock = System.Windows.Forms.DockStyle.None;

            this.chartControl1.Depth = 75;
            this.chartControl1.Series.Clear();
            this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.None;


            ChartSeries series1 = new ChartSeries();
            series1.Name = "Model1_Blue";
            series1.Text = "Honda";
            series1.Points.Add(1996, 40);
            series1.Points.Add(1998, 60);
            series1.Points.Add(2000, 75);
            series1.Points.Add(2002, 60);
            series1.Points.Add(2004, 55);
            series1.Points.Add(2006, 85);
            series1.Type = ChartSeriesType.Spline;
            series1.Style.Border.Width = 3;
            series1.Style.ImageIndex = 0;
            series1.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            series1.Style.Border.Color = Color.FromArgb(49, 73, 102);
            chartControl1.Series.Add(series1);

            ChartSeries series2 = new ChartSeries();
            series2.Name = "Model1_Green";
            series2.Text = "Toyato";
            series2.Points.Add(1996, 35);
            series2.Points.Add(1998, 70);
            series2.Points.Add(2000, 45);
            series2.Points.Add(2002, 20);
            series2.Points.Add(2004, 35);
            series2.Points.Add(2006, 65);
            series2.Type = ChartSeriesType.Spline;
            series2.Style.Border.Width = 3;
            series2.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            series2.Style.ImageIndex = 1;
            series2.Style.Border.Color = Color.FromArgb(151, 188, 75);
            chartControl1.Series.Add(series2);

            ChartSeries series3 = new ChartSeries();
            series3.Name = "Model2_Blue";
            series3.Text = "Benz";
            series3.Points.Add(1996, 60);
            series3.Points.Add(1998, 35);
            series3.Points.Add(2000, 55);
            series3.Points.Add(2002, 30);
            series3.Points.Add(2004, 65);
            series3.Points.Add(2006, 45);
            series3.Type = ChartSeriesType.Spline;
            series3.Style.Border.Width = 3;
            series3.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            series3.Style.ImageIndex = 2;
            series3.Style.Border.Color = Color.FromArgb(110, 68, 67);
            chartControl1.Series.Add(series3);

            ChartSeries series4 = new ChartSeries();
            series4.Name = "Model2_Green";
            series4.Text = "Audi";
            series4.Points.Add(1996, 45);
            series4.Points.Add(1998, 50);
            series4.Points.Add(2000, 35);
            series4.Points.Add(2002, 60);
            series4.Points.Add(2004, 35);
            series4.Points.Add(2006, 55);
            series4.Type = ChartSeriesType.Spline;
            series4.Style.Border.Width = 3;
            series4.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            series4.Style.ImageIndex = 3;
            series4.Style.Border.Color = Color.FromArgb(169, 119, 118);
            chartControl1.Series.Add(series4);
        }

#region Event

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.ChartArea.Watermark.HorizontalAlignment = (ChartAlignment)Enum.Parse(typeof(ChartAlignment), this.comboBox1.SelectedItem.ToString(), true);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.ChartArea.Watermark.VerticalAlignment = (ChartAlignment)Enum.Parse(typeof(ChartAlignment), this.comboBox2.SelectedItem.ToString(), true);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                this.chartControl1.ChartArea.Watermark.Image = null;
                this.chartControl1.ChartArea.Watermark.Font = new Font("Segoe UI", 20f);
                this.chartControl1.ChartArea.Watermark.Text = "Car Sales";

                this.label3.Enabled = true;
                this.numericUpDown1.Enabled = true;
            }
            else if (radioButton2.Checked == false)
            {
                this.label3.Enabled = false;
                this.numericUpDown1.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.chartControl1.ChartArea.Watermark.Text = null;
#if NETCORE
                this.chartControl1.ChartArea.Watermark.Image = System.Drawing.Image.FromFile(@"..\..\..\..\..\..\..\..\Common\images\Chart\carsales.png");
#else
                this.chartControl1.ChartArea.Watermark.Image = System.Drawing.Image.FromFile(@"..\..\..\..\..\..\..\Common\images\Chart\carsales.png");
#endif            
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.ChartArea.Watermark.Opacity = Convert.ToSingle(this.numericUpDown1.Value);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series3D = checkBox1.Checked;

            if (checkBox1.Checked)
            {
                this.label4.Enabled = true;
                this.comboBox3.Enabled = true;
                for (int i = 0; i < this.chartControl1.Series.Count; i++)
                {
                    this.chartControl1.Series[i].Style.Border.Width = 2f;
                }

            }
            else if (checkBox1.Checked == false)
            {
                this.label4.Enabled = false;
                this.comboBox3.Enabled = false;
                for (int i = 0; i < this.chartControl1.Series.Count; i++)
                {
                    this.chartControl1.Series[i].Style.Border.Width = 3f;
                }

            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.ChartArea.Watermark.ZOrder = (ChartWaterMarkOrder)Enum.Parse(typeof(ChartWaterMarkOrder), this.comboBox3.SelectedItem.ToString(), true);
        }
#endregion

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}