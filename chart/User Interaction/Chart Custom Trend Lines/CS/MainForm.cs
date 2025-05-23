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
using System.Collections;
using System.Drawing.Drawing2D;
using Syncfusion.Drawing;

namespace ClickPointDemo2
{
    public partial class MainForm : MetroForm
    {
        #region Form Constructor
        private Random rand = new Random();
        public MainForm()
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
        #endregion

        #region Form Load
        private TrendLineRenderer tlineRenderer;
        private void Form2_Load(object sender, EventArgs e)
        {
            this.tlineRenderer = new TrendLineRenderer(this.chartControl1);          
            this.InitializeChartData();
           
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
| System.Windows.Forms.AnchorStyles.Left)
| System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
| System.Windows.Forms.AnchorStyles.Left)
| System.Windows.Forms.AnchorStyles.Right)));
            ChartAppearance.ApplyChartStyles(this.chartControl1);
           
           
        }
        #endregion

        #region Helper Methods        
       
        #region InitializeChartData
        private void InitializeChartData()
        {
            DateTime d = DateTime.Now;
            ChartSeries series1 = new ChartSeries("Stock", ChartSeriesType.Line);
            series1.Text = series1.Name;

            foreach (string symbol in Enum.GetNames(typeof(Syncfusion.Windows.Forms.Chart.ChartSymbolShape)))
                this.cmbSymbolStyle.Items.Add(symbol);
            this.cmbSymbolStyle.SelectedIndex = 1;
            this.comboBox_LineStyle.SelectedIndex = 0;
            this.colorPickerButton3.SelectedColor = Color.Yellow;
            this.checkBox1.Checked = true;

            this.chartControl1.Series.Add(series1);
            for (int i = 0; i < 100; i++)
            {
                if (i <= 10)
                   series1.Points.Add(d.AddDays(i), rand.Next(25, 38));
                else if (i > 10 && i <= 12)
                    series1.Points.Add(d.AddDays(i), rand.Next(38, 45));
                else if (i > 12 && i <= 19)
                    series1.Points.Add(d.AddDays(i), rand.Next(42, 50));
                else if (i > 19 && i <= 23)
                    series1.Points.Add(d.AddDays(i), rand.Next(50, 60));
                else if (i > 23 && i <= 29)
                    series1.Points.Add(d.AddDays(i), rand.Next(58, 72));                                        
                else if (i > 29 && i <= 32)
                    series1.Points.Add(d.AddDays(i), rand.Next(62, 78));
                else if (i > 32 && i <= 49)
                    series1.Points.Add(d.AddDays(i), rand.Next(68, 85));
                else if (i > 49 && i <= 51)
                    series1.Points.Add(d.AddDays(i), rand.Next(58, 90));
                else if (i > 51 && i <=61)
                    series1.Points.Add(d.AddDays(i), rand.Next(86, 108));
               else if (i > 61 && i <= 71)
                    series1.Points.Add(d.AddDays(i), rand.Next(100, 118));
                else if (i > 71 && i <= 81)
                    series1.Points.Add(d.AddDays(i), rand.Next(110, 122));
                else if (i > 81 && i <= 91)
                    series1.Points.Add(d.AddDays(i), rand.Next(116, 129));
                else if (i > 91)
                    series1.Points.Add(d.AddDays(i), rand.Next(125, 138));
            }

            this.chartControl1.Series[0].Style.Border.Width = 2;
            this.chartControl1.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryYAxis.Range = new MinMaxInfo(0, 160, 20);
            this.chartControl1.PrimaryYAxis.Format = " 0";
            chartControl1.ShowLegend = false;

            this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime;
            this.chartControl1.PrimaryXAxis.DateTimeFormat = "M/d/yy";
            this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.MultipleRows;
           this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(d.AddDays(-1), d.AddDays(this.chartControl1.Series[0].Points.Count ), 8, ChartDateTimeIntervalType.Days);
        }
        #endregion
        #endregion

        #region Events
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.tlineRenderer.LineWidth = (int)this.numericUpDown1.Value;
        }
        private void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            this.tlineRenderer.LineUpColor = this.colorPickerButton1.SelectedColor;
        }
        private void colorPickerButton2_ColorSelected(object sender, EventArgs e)
        {
            this.tlineRenderer.LineDownColor = this.colorPickerButton2.SelectedColor;
        }        
        private void comboBox_LineStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tlineRenderer.LineStyle = (DashStyle)Enum.Parse(typeof(DashStyle), this.comboBox_LineStyle.SelectedItem.ToString(), true);
        }
        private void cmbSymbolStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tlineRenderer.LineSymbol = (ChartSymbolShape)Enum.Parse(typeof(ChartSymbolShape), this.cmbSymbolStyle.SelectedItem.ToString(), true);
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int x = (int)this.numericUpDown2.Value;
            this.tlineRenderer.LineSymbolSize = new Size(x, x);
        }
        private void colorPickerButton3_ColorSelected(object sender, EventArgs e)
        {
            this.tlineRenderer.LinesymbolColor = colorPickerButton3.SelectedColor;
        }       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.ShowToolTips = this.checkBox1.Checked;             
        }
        #endregion
    }

}