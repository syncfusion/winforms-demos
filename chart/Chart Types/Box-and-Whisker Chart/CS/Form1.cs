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

namespace BoxAndWhisker_2005
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
            CaptionButtonColor = Color.White;
            CaptionButtonHoverColor = Color.White;
            CaptionAlign = HorizontalAlignment.Left;
            ShowIcon = false;
            CaptionButtonColor = Color.White;
            CaptionButtonHoverColor = Color.White;
            InitializeComponent();         
            InitializeChartData();         
            comboBox1.SelectedIndex = 2;
            this.comboBox1.Enabled = false;
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }

        # endregion

        # region Helper Methods

        # region Initialize Control Settings
        /// <summary>
        //Initialize Control Settings
        /// </summary>      
        # endregion

        # region Initialize Chart Data
        /// <summary>
        // Initialize Chart Data
        /// </summary>
        protected void InitializeChartData()
        {
            ChartSeries BoxPlot = new ChartSeries("Analysis 1", ChartSeriesType.BoxAndWhisker);

            BoxPlot.Points.Add(0, 60, 70, 80, 90, 100, 110, 120, 130,140,150);
            BoxPlot.Points.Add(1, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140);
            BoxPlot.Points.Add(2, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130);
            BoxPlot.Points.Add(3, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120);
            BoxPlot.Points.Add(4, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110);
            BoxPlot.Points.Add(5, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100);
         
            this.chartControl1.Series.Add(BoxPlot);

            ChartCustomPoint ccp = new ChartCustomPoint();
            ccp.XValue = this.chartControl1.Series[0].Points[5].X + 0.66;
            ccp.YValue = this.chartControl1.Series[0].Points[5].YValues[5];
            ccp.CustomType = ChartCustomPointType.ChartCoordinates;
            ccp.Text = "Median";
            ccp.Font.Size = 8f;
            ccp.Font.Facename = "Segoe UI";
            ccp.Color = Color.Black;
            this.chartControl1.CustomPoints.Add(ccp);

            ChartCustomPoint ccp1 = new ChartCustomPoint();
            ccp1.XValue = this.chartControl1.Series[0].Points[5].X + 0.6;
            ccp1.YValue = this.chartControl1.Series[0].Points[5].YValues[0];
            ccp1.CustomType = ChartCustomPointType.ChartCoordinates;
            ccp1.Text = "Min";
            ccp1.Font.Size = 8f;
            ccp1.Font.Facename = "Segoe UI";
            ccp1.Color = Color.Black;
            this.chartControl1.CustomPoints.Add(ccp1);

            ChartCustomPoint ccp2 = new ChartCustomPoint();
            ccp2.XValue = this.chartControl1.Series[0].Points[5].X + 0.6;
            ccp2.YValue = this.chartControl1.Series[0].Points[5].YValues[9];
            ccp2.CustomType = ChartCustomPointType.ChartCoordinates;
            ccp2.Text = "Max";
            ccp2.Font.Size = 8f;
            ccp2.Font.Facename = "Segoe UI";
            ccp2.Color = Color.Black;
            this.chartControl1.CustomPoints.Add(ccp2);
        }

        # endregion        

        # endregion

        #region Events

        string[] labels = new string[] { "A", "B", "C", "D", "E", "F" };

        private void chartControl1_ChartFormatAxisLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            if (e.AxisOrientation == ChartOrientation.Horizontal)
            {
                int index = (int)e.Value;
                if (index >= 0 && index < labels.Length)
                {
                    //Applying custom label text for X Axis
                    e.Label = labels[index];
                }
                else
                {
                    e.Label = "";
                }
            }
            e.Handled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series3D = this.checkBox1.Checked;
        }
        #endregion

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series[0].ConfigItems.BoxAndWhiskerItem.PercentileMode = this.checkBox2.Checked;
            if (checkBox2.Checked)
            {
                this.comboBox1.Enabled = true;
                this.label1.Enabled = true;
                this.chartControl1.Series[0].ConfigItems.BoxAndWhiskerItem.Percentile = 0.15;
                this.chartControl1.Series[0].ConfigItems.BoxAndWhiskerItem.OutLierWidth = 25;

            }
            else
            {
                this.comboBox1.Enabled = false;
                this.label1.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series[0].ConfigItems.BoxAndWhiskerItem.PercentileMode = this.checkBox2.Checked;
            if (checkBox2.Checked && comboBox1.SelectedIndex==0)
            {
                this.comboBox1.Enabled = true;
                this.chartControl1.Series[0].ConfigItems.BoxAndWhiskerItem.Percentile = 0;
                this.chartControl1.Series[0].ConfigItems.BoxAndWhiskerItem.OutLierWidth = 15;
            }
            else if (checkBox2.Checked && comboBox1.SelectedIndex == 1)
            {
                this.comboBox1.Enabled = true;
                this.chartControl1.Series[0].ConfigItems.BoxAndWhiskerItem.Percentile = 0.10;
                this.chartControl1.Series[0].ConfigItems.BoxAndWhiskerItem.OutLierWidth = 15;
            }
            else if (checkBox2.Checked && comboBox1.SelectedIndex == 2)
            {
                this.comboBox1.Enabled = true;
                this.chartControl1.Series[0].ConfigItems.BoxAndWhiskerItem.Percentile = 0.15;
                this.chartControl1.Series[0].ConfigItems.BoxAndWhiskerItem.OutLierWidth = 15;
            }
            else
            {
                this.comboBox1.Enabled = false;
            }
        }
    }
}