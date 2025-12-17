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
using System.Drawing.Drawing2D;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;

namespace ChartTrendline
{
    public partial class Form1 : MetroForm
    {

        #region Constructor
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
                

        #region InitializeChartData()
        /// <summary>
        /// Initializes the ChartControl's data and sets the Chart type.
        /// </summary>
        protected void InitializeChartData()
        {
            ChartSeries series1 = new ChartSeries(" Rupees ");
            series1.Type = ChartSeriesType.Scatter;
            series1.Text = series1.Name;

            double[] yValue = new double[]{7.66, 8.03, 8.41,8.97,8.77,8.20,8.16,7.89,8.68,9.48,10.11,11.36,12.34,12.60,12.95,13.91,16.21,17.50,22.72,28.14,31.26,31.39,32.43,35.52,36.36,
            41.33,43.12,45.00,47.23,48.62,46.60,45.28,44.01,45.17,41.20,43.41,48.32,45.65,46.61,53.34,58.53};
            int j = 0;
            for (int i = 1973; i <= 2013; i++)
            {
                series1.Points.Add(i, yValue[j]);
                
                j += 1;
            }
            
                   
            series1.Style.Font.Facename = "Segoe UI";
            series1.Style.Font.Size = 10;

            Trendline trendline = new Trendline();
            trendline.Name = "Linear";
            trendline.Style = DashStyle.Solid;
            series1.Trendlines.Add(trendline);
            this.chartControl1.Series.Add(series1);

            this.chartControl1.PrimaryXAxis.TickSize = new Size(1, 1);
            this.chartControl1.PrimaryYAxis.TickSize = new Size(1, 1);
            this.chartControl1.PrimaryXAxis.Font = new Font("Segoe UI", 10, FontStyle.Regular);
        
       

            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));

            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;

            this.comboBox1.DataSource = Enum.GetValues(typeof(TrendlineType));
            this.comboBox2.Items.AddRange(new object[] {"2","3","4","5","6" });
            foreach (string line in Enum.GetNames(typeof(DashStyle)))
                this.comboBox3.Items.Add(line);
            this.checkBox1.Checked = true;           

        }

      
        #endregion

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            this.chartControl1.Series[0].Trendlines[0].Visible = this.checkBox1.Checked;
            this.chartControl1.Refresh();

        }
                
        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = Convert.ToString(this.comboBox1.SelectedItem);
            this.chartControl1.Series[0].Trendlines[0].Type = (TrendlineType)this.comboBox1.SelectedItem;
            this.chartControl1.Series[0].Trendlines[0].Name = select;
          
            switch (select)
            {
                case "Polynomial":
                    {
                        this.comboBox2.Visible = true;
                        this.label5.Visible = true;
                        break;
                    }
                case "MovingAverage":
                    {
                        this.comboBox2.Visible = false;
                        this.label5.Visible = false;
                        this.trackBar1.Visible = false;
                        this.label2.Visible = false;
                        this.trackBar2.Visible = false;
                        this.label3.Visible = false;
                        this.trackBar3.Visible = true;
                        this.label4.Visible = true;

                        break;
                    }
                default:
                    {
                        this.comboBox2.Visible = false;
                        this.label5.Visible = false;
                        this.trackBar3.Visible = false;
                        this.label4.Visible = false;
                        this.trackBar1.Visible = true;
                        this.label2.Visible = true;
                        this.trackBar2.Visible = true;
                        this.label3.Visible = true;
                        break;

                    }
            }
            this.chartControl1.Refresh();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.chartControl1.Series[0].Trendlines[0].PolynomialOrder = Convert.ToDouble(this.comboBox2.SelectedItem);
           
            this.chartControl1.Refresh();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            this.chartControl1.Series[0].Trendlines[0].ForwardForecast = this.trackBar2.Value;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.chartControl1.Series[0].Trendlines[0].BackwardForecast = this.trackBar1.Value;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            this.chartControl1.Series[0].Trendlines[0].Period = this.trackBar3.Value;
        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series[0].Trendlines[0].Style = (DashStyle)Enum.Parse(typeof(DashStyle), this.comboBox3.SelectedItem.ToString());
            this.chartControl1.Refresh();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series[0].Trendlines[0].Width = (float)(this.numericUpDown1.Value);
        }

        
        private void colorPickerButton2_ColorSelected(object sender, EventArgs e)
        {
            this.colorPickerButton2.BackColor = this.colorPickerButton2.SelectedColor;
            this.chartControl1.Series[0].Trendlines[0].Color = this.colorPickerButton2.SelectedColor;
            this.chartControl1.Refresh();
        }

       

    }
}