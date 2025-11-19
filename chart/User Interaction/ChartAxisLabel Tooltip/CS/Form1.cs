#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms;
using ColumnChart2005;
using System.Collections.Generic;
using System;

namespace ChartAxisLabelTooltip_2005
{
    public partial class Form1 : MetroForm
    {
        List<string> arrLabel = new List<string>();
        List<string> arrTooltip = new List<string>();
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
         
            this.chartControl1.ChartFormatAxisLabel += new ChartFormatAxisLabelEventHandler(chartControl1_ChartFormatAxisLabel);
            ChartSeries series = new ChartSeries("Series");
            this.chartControl1.Indexed = true;
            series.Points.Add(1, 20);
            series.Points.Add(2, 40);
            series.Points.Add(3, 50);
            series.Points.Add(4, 30);

            this.chartControl1.Series.Add(series);
           
        
            this.chartControl1.ShowToolTips = true;
            this.chartControl1.Series3D = true;
            chartControl1.Skins = Skins.Metro;
            this.chartControl1.Dock = DockStyle.Fill;       
      


        }



        void chartControl1_ChartFormatAxisLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            int index = (int)e.Value;
            if (e.AxisOrientation == ChartOrientation.Horizontal)
            {
                if (index >= 0 && index < arrLabel.Count)
                {
                    e.Label = arrLabel[index].ToString();
                    e.ToolTip = arrTooltip[index].ToString();
                }
            }
            e.Handled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.ShowToolTips = this.checkBox1.Checked;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }
    }
}