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

namespace CategoricalAxis_2005
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
            ChartSeries series1 = new ChartSeries(" Machine 1");
            series1.Type = ChartSeriesType.Column;
            series1.Text = series1.Name;

            series1.Points.Add("Server 1", 256);
            series1.Points.Add("Server 2", 351);
            series1.Points.Add("Server 3", 210);
            series1.Points.Add("Server 4", 200);
            series1.Points.Add("Server 5", 240);
            
            series1.Style.DisplayText = true;
            series1.Style.TextColor = Color.White;
            series1.Style.TextOrientation = ChartTextOrientation.RegionUp;
            series1.PrepareStyle += series1_PrepareStyle;
            series1.Style.Font.Facename = "Segoe UI";
            series1.Style.Font.Size = 10;
            this.chartControl1.Series.Add(series1);

            this.chartControl1.PrimaryXAxis.TickSize = new Size(1, 1);
            this.chartControl1.PrimaryYAxis.TickSize = new Size(1, 1);
            this.chartControl1.PrimaryXAxis.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            

            this.chartControl1.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryYAxis.Range = new MinMaxInfo(0, 400, 100);

            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));

            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;

            this.comboBox1.DataSource = Enum.GetValues(typeof(ChartSeriesSortingType));
            this.comboBox2.DataSource = Enum.GetValues(typeof(ChartSeriesSortingOrder));
            this.checkBox1.Checked = true;           

        }

        void series1_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
        {
            ChartSeries series = sender as ChartSeries;
            args.Style.Text = series.Points[args.Index].YValues[0].ToString() + " MB";
        }
        #endregion

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ChartSeries series in this.chartControl1.Series)
                series.SortPoints = this.checkBox1.Checked;
            this.chartControl1.Refresh();
        }
                
        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ChartSeries series in this.chartControl1.Series)
                series.SortBy = (ChartSeriesSortingType)this.comboBox1.SelectedItem;
            this.chartControl1.Refresh();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ChartSeries series in this.chartControl1.Series)
                series.SortOrder = (ChartSeriesSortingOrder)this.comboBox2.SelectedItem;
            this.chartControl1.Refresh();
        }


    }
}