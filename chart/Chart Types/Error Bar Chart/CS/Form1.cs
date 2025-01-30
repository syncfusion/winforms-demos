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
using Syncfusion.Drawing;

namespace ErrorBarsChart_2005
{
    public partial class Form1 : MetroForm
    {
        # region Constructor and Form Load

        /// <summary>
        /// Form Constructor
        /// </summary>
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

        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeErrorChart();
            foreach (string errorBarShape in Enum.GetNames(typeof(Syncfusion.Windows.Forms.Chart.ChartSymbolShape)))
                this.comboBox1.Items.Add(errorBarShape);
            this.comboBox1.SelectedIndex = 3;
            foreach (string symbolShape in Enum.GetNames(typeof(Syncfusion.Windows.Forms.Chart.ChartSymbolShape)))
                this.comboBox2.Items.Add(symbolShape);
            this.comboBox2.SelectedIndex = 8;
            this.checkBox1.Checked = true;
        
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }

        # endregion

        # region Helpher Methods
                
        /// <summary>
        /// Initializes Chart and error values
        /// </summary>
        public void InitializeErrorChart()
        {
            // Initialize chart series.            
            ChartSeries series1 = new ChartSeries("Home", ChartSeriesType.Line);

            series1.Points.Add(1, new double[] { 8, 3 });
            series1.Points.Add(2, new double[] { 10, 2 });
            series1.Points.Add(3, new double[] { 16, 2 });
            series1.Points.Add(4, new double[] { 7, 3 });
            series1.Points.Add(5, new double[] { 12, 3 });
            series1.Style.Images = new ChartImageCollection(this.imageList1.Images);
            series1.Style.Symbol.Color = Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2);
            series1.Style.Symbol.Border.Color = Color.White;
            this.chartControl1.Series.Add(series1);

            // Enable the property to draw errorBars to the series.
            series1.ConfigItems.ErrorBars.Enabled = false;        
           
        }

        # endregion

        # region Events
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ErrorBarSymbol shape can be set here.
            this.chartControl1.Series[0].ConfigItems.ErrorBars.SymbolShape = (ChartSymbolShape)Enum.Parse(typeof(ChartSymbolShape), this.comboBox1.SelectedItem.ToString());
                        
            if (this.comboBox1.SelectedItem.ToString().Equals("Image"))
            {
                this.chartControl1.Series[0].Style.ImageIndex = 1;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Series Symbol shapes can be set here.
            this.chartControl1.Series[0].Style.Symbol.Shape = (ChartSymbolShape)Enum.Parse(typeof(ChartSymbolShape), this.comboBox2.SelectedItem.ToString());
            this.chartControl1.Redraw(true);

            if (this.comboBox2.SelectedItem.ToString().Equals("Image"))
            {
                this.chartControl1.Series[0].Style.Symbol.ImageIndex = 1;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series[0].ConfigItems.ErrorBars.Enabled = this.checkBox1.Checked;
            this.comboBox1.Enabled = this.checkBox1.Checked;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series3D = checkBox2.Checked;
            this.chartControl1.Depth = 30;
        }
        private void chartControl1_ChartFormatAxisLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            if (e.AxisOrientation == ChartOrientation.Horizontal)
            {
                if (e.Value == 1)
                    e.Label = "Microwave" + "\n" +"Oven";
                else if (e.Value == 2)
                    e.Label = "Water" + "\n" + "Purifier";
                else if (e.Value == 3)
                    e.Label = "Refrigerator";
                else if (e.Value == 4)
                    e.Label = "Vacuum " + "\n" + "Cleaner";
                else if (e.Value == 5)
                    e.Label = "Coffee" + "\n" + "Maker";
                else
                    e.Label = "";

                e.Handled = true;
            }
        }
        #endregion
    }
}