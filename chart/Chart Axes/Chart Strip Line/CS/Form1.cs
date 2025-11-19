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
using System.Reflection;
using System.IO;

namespace Chart_StripLine
{
    public partial class Form1 : MetroForm
    {
        # region Members
        string str;
        int position = 3;
        bool highTempStripLine = false;
        Color[] stripLineColor = new Color[] { Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2), Color.White, Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2) };
        string[] labels = new string[] { "", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
        ChartStripLine newStripLine = new ChartStripLine();
        ChartStripLine stripLine1 = new ChartStripLine();
        # endregion

        #region Form Constructor
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
            InitializeChartData();
            this.domainUpDown1.SelectedIndex = 3;
            InitializeControlSettings();
            this.panel2.Visible = false;
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }
        #endregion

        # region Helper Methods

        #region InitializeControlSettings

        /// <summary>
        /// Initialize Control Settings.
        /// </summary>
        private void InitializeControlSettings()
        {
            foreach (string text in Enum.GetNames(typeof(System.Drawing.ContentAlignment)))
                this.comboBox1.Items.Add(text);
            this.comboBox1.SelectedIndex = 4;
        }

        #endregion

        #region InitializeChartData
        /// <summary>
        /// Initialize Chart Data
        /// </summary>
        protected void InitializeChartData()
        {
            ChartSeries weather = new ChartSeries("Weather", ChartSeriesType.Spline);
            weather.Points.Add(1, 78);
            weather.Points.Add(2, 82);
            weather.Points.Add(3, 84);
            weather.Points.Add(4, 82);
            weather.Points.Add(5, 79);
            weather.Points.Add(6, 81);
            weather.Points.Add(7, 86);
            weather.Style.PointWidth = 0.3f;
            weather.Style.Border.Width = 2;
            this.chartControl1.Series.Add(weather);
            weather.PrepareStyle += new ChartPrepareStyleInfoHandler(Series1_PrepareStyle);
            SetStripLine();

            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
        }

        #endregion

        # region Stripline
        /// <summary>
        /// Creates and draw stripline
        /// </summary>
        protected void SetStripLine()
        {
            // Creates horizontal stripline
            if (highTempStripLine)
            {
                // Chart Strip Lines               
                stripLine1.Enabled = true;
                stripLine1.Vertical = false;
                stripLine1.Start = 93;
                stripLine1.End = 94;
                stripLine1.Text = "Historical High: 93'F";
                stripLine1.Font = new System.Drawing.Font("Arial", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
                stripLine1.Period = 50;
                stripLine1.Width = 2.3;
                stripLine1.Interior = new BrushInfo(GradientStyle.Vertical, stripLineColor);
                // Adds the stripline to the collection
                this.chartControl1.PrimaryYAxis.StripLines.Add(stripLine1);
            }

            // Creates vertical stripline
            ChartStripLine thermoStripLine = new ChartStripLine();
            thermoStripLine.Enabled = true;
            thermoStripLine.Vertical = false;

            thermoStripLine.Start = position + 1;
            thermoStripLine.End = position + 2;

            thermoStripLine.Text = " ";
            Assembly asem = this.GetType().Assembly;
            Stream str = asem.GetManifestResourceStream("ChartStripLine_2005.thermometer.png");
            Image img = Image.FromStream(str);
            thermoStripLine.BackImage = img;
            thermoStripLine.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            thermoStripLine.Period = 50;
            thermoStripLine.Width = 0.4;
            thermoStripLine.Interior = new BrushInfo(GradientStyle.Vertical, stripLineColor);
            this.chartControl1.PrimaryXAxis.StripLines.Add(thermoStripLine);
        }

        # endregion

        # endregion

        # region Events

        #region ChartFormatAxisLabel

        /// <summary>
        /// Sets the axis label values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chartControl1_ChartFormatAxisLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            if (e.AxisOrientation == ChartOrientation.Vertical)
            {
                if (e.Value == 0)
                    e.Label = "";
                else
                {
                    //Applying Formatted Y Axis label values.
                    e.Label = string.Format("{0}'F ", e.Value);
                }
            }
            else
            {
                int index = (int)e.Value;

                //if (index >= 0 && index < labels.Length)
                //{
                if (index < labels.Length)
                {
                    //Applying custom label text for X Axis
                    e.Label = labels[index];
                }
                else
                    e.Label = "";
            }
            e.Handled = true;

        }
        #endregion

        # region Series Prepare Style

        /// <summary>
        /// Sets the display text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void Series1_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
        {
            ChartSeries series = sender as ChartSeries;
            if (series != null)
            {
                if (args.Index == position)
                    args.Style.DisplayText = true;
            }
        }
        # endregion

        private void button2_Click(object sender, EventArgs e)
        {
            this.panel3.Visible = true;
            this.chartControl1.PrimaryXAxis.StripLines.Clear();
            this.chartControl1.PrimaryYAxis.StripLines.Clear();
            SetStripLine();
            newStripLine.Enabled = true;

            switch (str)
            {
                case "Default":
                    {
                        newStripLine.StartAtAxisPosition = false;
                        newStripLine.Start = Convert.ToDouble(this.numericUpDown1.Value);
                        newStripLine.End = newStripLine.Start + 1;
                        newStripLine.Width = Convert.ToDouble(this.numericUpDown3.Value);
                    }
                    break;
                case "DateTime":
                    {
                        this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime;
                        this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
                        newStripLine.StartAtAxisPosition = true;
                        newStripLine.WidthDate = new TimeSpan((int)(this.numericUpDown3.Value), 0, 0, 0, 0);
                        newStripLine.DateOffset = new TimeSpan((int)(this.numericUpDown2.Value), 0, 0, 0, 0);
                        newStripLine.PeriodDate = new TimeSpan((int)(this.numericUpDown4.Value), 0, 0, 0, 0);
                    }
                    break;
            }
            newStripLine.Text = this.textBox1.Text;
            newStripLine.TextColor = this.colorPickerButton1.SelectedColor;
            newStripLine.Interior = new BrushInfo(GradientStyle.Horizontal, Color.FromArgb(0xF0, 0xA0, 0x50, 0x00), Color.White);
            if (radioButton1.Checked)
            {
                newStripLine.Vertical = true;
                this.chartControl1.PrimaryXAxis.StripLines.Add(newStripLine);
                if (highTempStripLine)
                    this.chartControl1.PrimaryXAxis.StripLines[1].TextAlignment = (ContentAlignment)Enum.Parse(typeof(ContentAlignment), this.comboBox1.SelectedItem.ToString(), true);
                else
                    this.chartControl1.PrimaryXAxis.StripLines[0].TextAlignment = (ContentAlignment)Enum.Parse(typeof(ContentAlignment), this.comboBox1.SelectedItem.ToString(), true);
            }
            else
            {
                newStripLine.Vertical = false;
                this.chartControl1.PrimaryYAxis.StripLines.Add(newStripLine);
                this.chartControl1.PrimaryYAxis.StripLines[0].TextAlignment = (ContentAlignment)Enum.Parse(typeof(ContentAlignment), this.comboBox1.SelectedItem.ToString(), true);
            }
            this.panel2.Visible = false;
            this.buttonAdv2.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.numericUpDown1.Minimum = 0;
                this.numericUpDown1.Maximum = 10;
                this.numericUpDown2.Minimum = 0;
                this.numericUpDown2.Maximum = 10;
                this.numericUpDown4.Minimum = 1;
                this.numericUpDown4.Maximum = 11;
                this.numericUpDown1.Value = 5;
                this.numericUpDown2.Value = 3;
                this.numericUpDown3.Value = 1;
                this.numericUpDown4.Value = 4;
            }
            else
            {
                this.numericUpDown1.Minimum = 50;
                this.numericUpDown1.Maximum = 100;
                this.numericUpDown2.Minimum = 10;
                this.numericUpDown2.Maximum = 100;
                this.numericUpDown4.Minimum = 15;
                this.numericUpDown4.Maximum = 35;

                this.numericUpDown1.Value = 60;
                this.numericUpDown2.Value = 20;
                this.numericUpDown3.Value = 5;
                this.numericUpDown4.Value = 20;
            }
        }

        private void buttonAdv3_Click(object sender, EventArgs e)
        {
            highTempStripLine = true;
            SetStripLine();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            position = this.domainUpDown1.SelectedIndex;
            this.chartControl1.PrimaryXAxis.StripLines.Clear();
            this.chartControl1.PrimaryYAxis.StripLines.Clear();
            this.chartControl1.Series.Clear();
            InitializeChartData();
            SetStripLine();
        }

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            this.panel3.Visible = false;
            this.comboBox2.SelectedIndex = 0;
            this.radioButton1.Checked = true;
            str = "Default";
            this.numericUpDown2.Enabled = false;
            this.numericUpDown4.Enabled = false;
            this.numericUpDown1.Enabled = true;
            this.numericUpDown3.Enabled = true;
            this.buttonAdv2.Enabled = false;
            this.panel2.Visible = true;
            this.panel2.Location = new Point(700, 0);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox2.SelectedIndex == 0)
            {
                str = "Default";
                this.numericUpDown2.Enabled = false;
                this.numericUpDown4.Enabled = false;
                this.numericUpDown1.Enabled = true;
                this.numericUpDown3.Enabled = true;
            }
            else
            {
                str = "DateTime";
                this.numericUpDown1.Enabled = false;
                this.numericUpDown3.Enabled = false;
                this.numericUpDown2.Enabled = true;
                this.numericUpDown4.Enabled = true;
            }
        }
       
        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                stripLine1.FixedWidth = Convert.ToDouble(numericUpDown5.Value);
            }
            else
            {
                stripLine1.FixedWidth = 0;
                stripLine1.Width = 2.3;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                stripLine1.FixedWidth = Convert.ToDouble(numericUpDown5.Value);                
            }
            else
            {
                stripLine1.FixedWidth = 0;
                stripLine1.Width = 2.3;
            }
        }

        # endregion

    }
}