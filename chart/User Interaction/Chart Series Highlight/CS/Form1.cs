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
using System.Drawing.Drawing2D;

namespace HighlightingSeries
{
    public partial class Form1 : MetroForm
    {
        #region Private Members
        ChartSeries series1;
        ChartSeries series2;
        ChartSeries series3;
        Color[] color1 = new Color[] { Color.FromArgb(117, 142, 172), Color.FromArgb(205, 217, 231), Color.FromArgb(117, 142, 172) };
        Color[] color2 = new Color[] { Color.FromArgb(150, 172, 90), Color.FromArgb(197, 229, 92), Color.FromArgb(150, 172, 90) };
        Color[] color3 = new Color[] { Color.FromArgb(223, 111, 39), Color.FromArgb(251, 169, 113), Color.FromArgb(223, 111, 39) };
        #endregion

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
            InitializeChartData();
            this.chartControl1.Dock = DockStyle.Fill;
            this.colorPickerButton2.Enabled = this.radioButton2.Checked;
            this.colorPickerButton1.Enabled = this.radioButton2.Checked;
        }

        #region InitializeChartData
        /// <summary>
        /// Initializes the ChartControl's data and sets the Chart type
        /// </summary>
        protected void InitializeChartData()
        {
            series1 = new ChartSeries();
            series1.Name = "Product A";
            series1.Text = series1.Name;
            series1.Points.Add(500, 16);
            series1.Points.Add(1000, 10);
            series1.Points.Add(1500, 13);
            series1.Points.Add(2000, 17);
            series1.Points.Add(2500, 11);
            series1.Points.Add(3000, 18);
            series1.Type = ChartSeriesType.SplineArea;
            this.chartControl1.Series.Add(series1);

            series2 = new ChartSeries();
            series2.Name = "Product B";
            series2.Text = series2.Name;
            series2.Points.Add(500, 6);
            series2.Points.Add(1000, 2);
            series2.Points.Add(1500, 3);
            series2.Points.Add(2000, 7);
            series2.Points.Add(2500, 1);
            series2.Points.Add(3000, 8);
            series2.Type = ChartSeriesType.SplineArea;
            this.chartControl1.Series.Add(series2);

            series3 = new ChartSeries();
            series3.Name = "Product C";
            series3.Text = series3.Name;
            series3.Points.Add(500, 26);
            series3.Points.Add(1000, 20);
            series3.Points.Add(1500, 23);
            series3.Points.Add(2000, 27);
            series3.Points.Add(2500, 21);
            series3.Points.Add(3000, 28);
            series3.Type = ChartSeriesType.SplineArea;
            this.chartControl1.Series.Add(series3);
          
            this.chartControl1.Series3D = this.checkBox1.Checked;
            this.cmbChartType.SelectedIndex = 0;
            this.ColumnDrawMode.SelectedIndex = 0;
            this.chartControl1.SeriesHighlight = false;          
            this.colorPickerButton2.ColorSelected += new EventHandler(colorPickerButton2_ColorSelected);
            this.colorPickerButton1.ColorSelected += new EventHandler(colorPickerButton1_ColorSelected);
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            this.chartControl1.Cursor = Cursors.Hand;
            this.chartControl1.Depth = 100;
        }

        void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            if (Hidden_Specific.Checked)
            {
                BrushInfo bi = new BrushInfo(GradientStyle.Vertical, this.colorPickerButton1.SelectedColor, this.colorPickerButton1.SelectedColor);
                this.chartControl1.Series[0].Style.DimmedInterior = new BrushInfo(Convert.ToInt16(this.numericUpDown1.Value), bi);
                BrushInfo bi1 = new BrushInfo(GradientStyle.Vertical, this.colorPickerButton1.SelectedColor, this.colorPickerButton1.SelectedColor);
                this.chartControl1.Series[1].Style.DimmedInterior = new BrushInfo(Convert.ToInt16(this.numericUpDown1.Value), bi1);
                BrushInfo bi2 = new BrushInfo(GradientStyle.Vertical, this.colorPickerButton1.SelectedColor, this.colorPickerButton1.SelectedColor);
                this.chartControl1.Series[2].Style.DimmedInterior = new BrushInfo(Convert.ToInt16(this.numericUpDown1.Value), bi2);

            }
        }
        void colorPickerButton2_ColorSelected(object sender, EventArgs e)
        {
            BrushInfo interior = this.chartControl1.Series[0].Style.HighlightInterior;
            if (interior == null)
                interior = new BrushInfo();
            if (this.radioButton2.Checked)
            {
                Color foreColor = interior.ForeColor;
                BrushInfo bi = new BrushInfo(GradientStyle.None, foreColor, this.colorPickerButton2.SelectedColor);
                BrushInfo bi1 = new BrushInfo(GradientStyle.None, foreColor, this.colorPickerButton2.SelectedColor);
                BrushInfo bi2 = new BrushInfo(GradientStyle.None, foreColor, this.colorPickerButton2.SelectedColor);

                this.chartControl1.Series[0].Style.HighlightInterior = new BrushInfo(Convert.ToInt16(this.numericUpDown1.Value), bi);
                this.chartControl1.Series[1].Style.HighlightInterior = new BrushInfo(Convert.ToInt16(this.numericUpDown1.Value), bi1);
                this.chartControl1.Series[2].Style.HighlightInterior = new BrushInfo(Convert.ToInt16(this.numericUpDown1.Value), bi2);
                this.chartControl1.Refresh();
            }
        }
        #endregion

        #region Event

        private void cmbChartType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (this.cmbChartType.Text == "SplineArea")
            {
                for (int i = 0; i < this.chartControl1.Series.Count; i++)
                {
                    this.chartControl1.Series[i].Type = ChartSeriesType.SplineArea;
                }               
                this.ColumnDrawMode.Enabled = false;
                this.label2.Enabled = false;
            }
            else if (this.cmbChartType.Text == "Column")
            {
                for (int i = 0; i < this.chartControl1.Series.Count; i++)
                {
                    this.chartControl1.Series[i].Type = ChartSeriesType.Column;
                } 
                this.ColumnDrawMode.Enabled = true;
                this.label2.Enabled = true;
            }
        }
        private void ColumnDrawMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.ColumnDrawMode = (ChartColumnDrawMode)Enum.Parse(typeof(ChartColumnDrawMode), this.ColumnDrawMode.SelectedItem.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series3D = this.checkBox1.Checked;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                this.chartControl1.Series[0].Style.HighlightInterior = null;
                this.chartControl1.Series[1].Style.HighlightInterior = null;
                this.chartControl1.Series[2].Style.HighlightInterior = null;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                BrushInfo interior = this.chartControl1.Series[0].Style.HighlightInterior;
                if (interior == null)
                    interior = new BrushInfo();
                Color foreColor = interior.ForeColor;
                BrushInfo bi = new BrushInfo(GradientStyle.None, foreColor, this.colorPickerButton2.SelectedColor);
                this.chartControl1.Series[0].Style.HighlightInterior = new BrushInfo(Convert.ToInt16(this.numericUpDown1.Value), bi);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series[0].Style.DimmedInterior = null;
            this.chartControl1.Series[1].Style.DimmedInterior = null;
            this.chartControl1.Series[2].Style.DimmedInterior = null;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (Hidden_Specific.Checked)
            {
                BrushInfo bi = new BrushInfo(GradientStyle.Vertical, this.colorPickerButton1.SelectedColor, this.colorPickerButton1.SelectedColor);
                this.chartControl1.Series[0].Style.DimmedInterior = new BrushInfo(Convert.ToInt16(this.numericUpDown1.Value), bi);
                BrushInfo bi1 = new BrushInfo(GradientStyle.Vertical, this.colorPickerButton1.SelectedColor, this.colorPickerButton1.SelectedColor);
                this.chartControl1.Series[1].Style.DimmedInterior = new BrushInfo(Convert.ToInt16(this.numericUpDown1.Value), bi1);
                BrushInfo bi2 = new BrushInfo(GradientStyle.Vertical, this.colorPickerButton1.SelectedColor, this.colorPickerButton1.SelectedColor);
                this.chartControl1.Series[2].Style.DimmedInterior = new BrushInfo(Convert.ToInt16(this.numericUpDown1.Value), bi2);
            }
        }       

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                this.chartControl1.SeriesHighlight = this.checkBox2.Checked;
                this.panel1.Enabled = this.checkBox2.Checked;
                this.panel2.Enabled = this.checkBox2.Checked;
            }
            else
            {
                this.chartControl1.SeriesHighlight = this.checkBox2.Checked;
                this.panel1.Enabled = this.checkBox2.Checked;
                this.panel2.Enabled = this.checkBox2.Checked;
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                this.chartControl1.Series[0].Style.HighlightInterior = null;
                this.chartControl1.Series[1].Style.HighlightInterior = null;
                this.chartControl1.Series[2].Style.HighlightInterior = null;
            }
            if (radioButton2.Checked)
            {
                BrushInfo interior = this.chartControl1.Series[0].Style.HighlightInterior;
                if (interior == null)
                    interior = new BrushInfo();
                Color foreColor = interior.ForeColor;
                BrushInfo bi = new BrushInfo(GradientStyle.None, foreColor, this.colorPickerButton2.SelectedColor);
                this.chartControl1.Series[0].Style.HighlightInterior = new BrushInfo(Convert.ToInt16(this.numericUpDown1.Value), bi);
            }
            if (Hidden_Specific.Checked)
            {
                BrushInfo bi = new BrushInfo(GradientStyle.Vertical, this.colorPickerButton1.SelectedColor, this.colorPickerButton1.SelectedColor);
                this.chartControl1.Series[0].Style.DimmedInterior = new BrushInfo(Convert.ToInt16(this.numericUpDown1.Value), bi);
                BrushInfo bi1 = new BrushInfo(GradientStyle.Vertical, this.colorPickerButton1.SelectedColor, this.colorPickerButton1.SelectedColor);
                this.chartControl1.Series[1].Style.DimmedInterior = new BrushInfo(Convert.ToInt16(this.numericUpDown1.Value), bi1);
                BrushInfo bi2 = new BrushInfo(GradientStyle.Vertical, this.colorPickerButton1.SelectedColor, this.colorPickerButton1.SelectedColor);
                this.chartControl1.Series[2].Style.DimmedInterior = new BrushInfo(Convert.ToInt16(this.numericUpDown1.Value), bi2);
            }

            if (Hidden_Auto.Checked)
            {
                this.chartControl1.Series[0].Style.DimmedInterior = null;
                this.chartControl1.Series[1].Style.DimmedInterior = null;
                this.chartControl1.Series[2].Style.DimmedInterior = null;
            }

        }
        
        #endregion

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            this.colorPickerButton2.Enabled = this.radioButton2.Checked;
        }

        private void Hidden_Specific_CheckedChanged(object sender, EventArgs e)
        {
            this.colorPickerButton1.Enabled = this.radioButton2.Checked;
        }
    }
}
