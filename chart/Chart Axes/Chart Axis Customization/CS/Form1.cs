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

namespace ChartAxisCustomization_2005
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
            InitializeControlSettings();           
            FillControlPanel();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }

        void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.checkBoxXAxis.Checked)
            {
                this.chartControl1.PrimaryXAxis.TitleRotationAngle = (AxisTitleRotationAngle)Enum.Parse(typeof(AxisTitleRotationAngle), (sender as ComboBox).SelectedItem.ToString());
            }
            if (this.checkBoxYAxis.Checked)
            {
                this.chartControl1.PrimaryYAxis.TitleRotationAngle = (AxisTitleRotationAngle)Enum.Parse(typeof(AxisTitleRotationAngle), (sender as ComboBox).SelectedItem.ToString());
            }
        }
        #endregion

        #region Helper Methods

        #region InitializeControlSettings()
        /// <summary>
        /// Initial setting of chart control.
        /// </summary>
        private void InitializeControlSettings()
        {
            this.chartControl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));            
            foreach (string fontstyle in Enum.GetNames(typeof(System.Drawing.FontStyle)))
                this.comboBox_FontStyle.Items.Add(fontstyle);
            this.comboBox_FontStyle.SelectedIndex = 0;
            this.comboBox_Fontfamily.SelectedIndex = 20;
        }
        #endregion

        #region InitializeChartData()
        /// <summary>
        /// Initializes the ChartControl's data and sets the Chart type.
        /// </summary>
        protected void InitializeChartData()
        {
            ChartSeries series1 = new ChartSeries(" Machine 1");
            series1.Type = ChartSeriesType.Column;
            series1.Text = series1.Name;

            series1.Points.Add(1, 256);
            series1.Points.Add(2, 351);
            series1.Points.Add(3, 210);

            series1.Style.Font.Bold = true;

            ChartSeries series2 = new ChartSeries(" Machine 2");
            series2.Type = ChartSeriesType.Column;
            series2.Text = series2.Name;

            series2.Points.Add(1, 345);
            series2.Points.Add(2, 275);
            series2.Points.Add(3, 320);

            series2.Style.Font.Bold = true;

            ChartSeries series3 = new ChartSeries(" Machine 3");
            series3.Type = ChartSeriesType.Column;
            series3.Text = series3.Name;

            series3.Points.Add(1, 290);
            series3.Points.Add(2, 260);
            series3.Points.Add(3, 300);

            series3.Style.Font.Bold = true;
            this.chartControl1.Series.Add(series1);
            this.chartControl1.Series.Add(series2);
            this.chartControl1.Series.Add(series3);

            this.chartControl1.PrimaryXAxis.TickSize = new Size(1, 1);
            this.chartControl1.PrimaryYAxis.TickSize = new Size(1, 1);

            this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryXAxis.Range = new MinMaxInfo(0, 4, 1);

            this.chartControl1.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryYAxis.Range = new MinMaxInfo(0, 400, 100);

            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill; ;

            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;

            

        }
        #endregion

        #region FillControlPanel
        private void FillControlPanel()
        {
            this.comboBox5.SelectedIndex = 1;
            this.comboBox6.SelectedIndex = 0;
            this.comboBox1.SelectedIndex = 0;
            this.comboBox2.SelectedIndex = 0;
            this.comboBox3.SelectedIndex = 0;
            this.comboBox4.SelectedIndex = 1;
            this.comboBox7.SelectedIndex = 0;
        }
        #endregion

        private void SetAxisPosition()
        {
            this.chartControl1.PrimaryXAxis.Inversed = this.checkBox2.Checked;
            this.chartControl1.PrimaryYAxis.OpposedPosition = this.checkBox4.Checked;
            this.chartControl1.PrimaryYAxis.Inversed = this.checkBox3.Checked;
            this.chartControl1.PrimaryXAxis.OpposedPosition = this.checkBox5.Checked;
            if (checkBox8.Checked)
                this.chartControl1.PrimaryXAxis.AxisLabelPlacement = ChartPlacement.Inside;
            else
                this.chartControl1.PrimaryXAxis.AxisLabelPlacement = ChartPlacement.Outside;
            if (checkBox7.Checked)
                this.chartControl1.PrimaryYAxis.AxisLabelPlacement = ChartPlacement.Inside;
            else
                this.chartControl1.PrimaryYAxis.AxisLabelPlacement = ChartPlacement.Outside;
        }

        private void SetLineDashStyle()
        {
            if (this.checkBoxXAxis.Checked)
                this.chartControl1.PrimaryXAxis.LineType.DashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), this.comboBox1.SelectedItem.ToString(), true);
            if (this.checkBoxYAxis.Checked)
                this.chartControl1.PrimaryYAxis.LineType.DashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), this.comboBox1.SelectedItem.ToString(), true);
            this.chartControl1.Refresh();
        }

        private void SetGridLineDashStyle()
        {
            if (this.checkBoxXAxis.Checked)
                this.chartControl1.PrimaryXAxis.GridLineType.DashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), this.comboBox6.SelectedItem.ToString(), true);
            if (this.checkBoxYAxis.Checked)
                this.chartControl1.PrimaryYAxis.GridLineType.DashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), this.comboBox6.SelectedItem.ToString(), true);
            this.chartControl1.Refresh();
        }

        private void SetMinorGridLineDashStyle()
        {
            if (this.checkBoxXAxis.Checked && checkBox1.Checked)
                this.chartControl1.PrimaryXAxis.MinorGridLineType.DashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), this.comboBox4.SelectedItem.ToString(), true);
            if (this.checkBoxYAxis.Checked && checkBox6.Checked)
                this.chartControl1.PrimaryYAxis.MinorGridLineType.DashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), this.comboBox4.SelectedItem.ToString(), true);
            this.chartControl1.Refresh();
        }

        private void SetLineWidthSize()
        {
            if (this.checkBoxXAxis.Checked)
                this.chartControl1.PrimaryXAxis.LineType.Width = Convert.ToSingle(this.comboBox2.SelectedItem.ToString());
            if (this.checkBoxYAxis.Checked)
                this.chartControl1.PrimaryYAxis.LineType.Width = Convert.ToSingle(this.comboBox2.SelectedItem.ToString());
            this.chartControl1.Refresh();
        }

        private void SetGridLineWidthSize()
        {
            if (this.checkBoxXAxis.Checked)
                this.chartControl1.PrimaryXAxis.GridLineType.Width = Convert.ToSingle(this.comboBox5.SelectedItem.ToString());
            if (this.checkBoxYAxis.Checked)
                this.chartControl1.PrimaryYAxis.GridLineType.Width = Convert.ToSingle(this.comboBox5.SelectedItem.ToString());
            this.chartControl1.Refresh();
        }

        private void SetMinorGridLineWidthSize()
        {
            if (this.checkBoxXAxis.Checked && checkBox1.Checked)
                this.chartControl1.PrimaryXAxis.MinorGridLineType.Width = Convert.ToSingle(this.comboBox7.SelectedItem.ToString());
            if (this.checkBoxYAxis.Checked && checkBox6.Checked)
                this.chartControl1.PrimaryYAxis.MinorGridLineType.Width = Convert.ToSingle(this.comboBox7.SelectedItem.ToString());
            this.chartControl1.Refresh();
        }

        private void SetLineTickSize()
        {
            if (this.checkBoxXAxis.Checked)
                this.chartControl1.PrimaryXAxis.TickSize = new Size(Int32.Parse(this.comboBox2.SelectedItem.ToString()), Int32.Parse(this.comboBox3.SelectedItem.ToString()));
            if (this.checkBoxYAxis.Checked)
                this.chartControl1.PrimaryYAxis.TickSize = new Size(Int32.Parse(this.comboBox2.SelectedItem.ToString()), Int32.Parse(this.comboBox3.SelectedItem.ToString()));
            this.chartControl1.Refresh();
        }

        private void SetLineForeColor()
        {
            
            if (this.checkBoxXAxis.Checked)
                this.chartControl1.PrimaryXAxis.LineType.ForeColor = colorPickerButton3.SelectedColor;
            if (this.checkBoxYAxis.Checked)
                this.chartControl1.PrimaryYAxis.LineType.ForeColor = colorPickerButton3.SelectedColor;

            this.chartControl1.Refresh();
        }

        private void SetGridForeColor()
        {
            
            if (this.checkBoxXAxis.Checked)
                this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = colorPickerButton2.SelectedColor;
            if (this.checkBoxYAxis.Checked)
                this.chartControl1.PrimaryYAxis.GridLineType.ForeColor = colorPickerButton2.SelectedColor;

            this.chartControl1.Refresh();
        }

        private void SetMinorGridForeColor()
        {
           
            if (this.checkBoxXAxis.Checked && checkBox1.Checked)
                this.chartControl1.PrimaryXAxis.MinorGridLineType.ForeColor = colorPickerButton1.SelectedColor;
            if (this.checkBoxYAxis.Checked && checkBox6.Checked)
                this.chartControl1.PrimaryYAxis.MinorGridLineType.ForeColor = colorPickerButton1.SelectedColor;

            this.chartControl1.Refresh();
        }

        #endregion

        #region Events

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            SetAxisPosition();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            SetAxisPosition();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            SetAxisPosition();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            SetAxisPosition();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetLineDashStyle();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetGridLineDashStyle();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetLineWidthSize();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetGridLineWidthSize();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetLineTickSize();
        }

        private void colorPickerButton3_ColorSelected(object sender, EventArgs e)
        {
            this.colorPickerButton3.BackColor = this.colorPickerButton3.SelectedColor;
            SetLineForeColor();
            this.Refresh();
        }

        private void colorPickerButton2_ColorSelected(object sender, EventArgs e)
        {
            this.colorPickerButton2.BackColor = this.colorPickerButton2.SelectedColor;
            SetGridForeColor();
            this.Refresh();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            SetAxisPosition();
            SetLineDashStyle();
            SetGridLineDashStyle();
            SetLineWidthSize();
            SetGridLineWidthSize();
            SetLineTickSize();
            SetLineForeColor();
            SetGridForeColor();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetMinorGridLineDashStyle();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryXAxis.DrawMinorGrid = this.checkBox1.Checked;

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryYAxis.DrawMinorGrid = this.checkBox6.Checked;
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetMinorGridLineWidthSize();
        }

        private void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            this.colorPickerButton1.BackColor = this.colorPickerButton1.SelectedColor;
            SetMinorGridForeColor();
            this.Refresh();
        }
        private void comboBox_Fontfamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFont();
        }

        private void comboBox_FontStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFont();
        }

        private void numericUpDown_FontSize_ValueChanged(object sender, EventArgs e)
        {
            SetFont();
        }

        private void colorPicker_TextColor_ColorSelected(object sender, EventArgs e)
        {
            this.colorPicker_TextColor.BackColor = this.colorPicker_TextColor.SelectedColor;
           
            if (this.checkBoxXAxis.Checked)
                this.chartControl1.PrimaryXAxis.TitleColor = colorPicker_TextColor.SelectedColor;
            if (this.checkBoxYAxis.Checked)
                this.chartControl1.PrimaryYAxis.TitleColor = colorPicker_TextColor.SelectedColor;

            this.chartControl1.Refresh();
        }
        #endregion

        #region  SetFont

        protected void SetFont()
        {
            if (this.comboBox_Fontfamily.SelectedIndex > 0)
            {
                FontStyle fs = (FontStyle)Enum.Parse(typeof(FontStyle), this.comboBox_FontStyle.SelectedItem.ToString(), true);
                if (this.checkBoxXAxis.Checked)
                    this.chartControl1.PrimaryXAxis.TitleFont = new Font(this.comboBox_Fontfamily.SelectedItem.ToString(), (float)this.numericUpDown_FontSize.Value, fs);
                if (this.checkBoxYAxis.Checked)
                    this.chartControl1.PrimaryYAxis.TitleFont = new Font(this.comboBox_Fontfamily.SelectedItem.ToString(), (float)this.numericUpDown_FontSize.Value, fs);

            }
        }
        #endregion

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            SetAxisPosition();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            SetAxisPosition();
        }

       
    }
}