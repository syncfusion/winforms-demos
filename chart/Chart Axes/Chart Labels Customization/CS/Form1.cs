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

namespace ChartLabels_2005
{
    public partial class Form1 : MetroForm
    {
        #region Form constructor
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
            InitialControlSettings();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
           
        }
        #endregion

        #region Helper Methods
        #region InitialControlSettings
        protected void InitialControlSettings()
        {
            foreach (string fontstyle in Enum.GetNames(typeof(System.Drawing.FontStyle)))
                this.comboBox_FontStyle.Items.Add(fontstyle);

            foreach (string valueType in Enum.GetNames(typeof(Syncfusion.Windows.Forms.Chart.ChartLabelIntersectAction)))
                this.comboBox_LabelIntersectAction.Items.Add(valueType);
            
            this.comboBox_LabelIntersectAction.SelectedIndex = 0;
            this.comboBox_EdgeDrawingMode.SelectedIndex = 0;
            
            this.comboBox_FontStyle.SelectedIndex = 0;
            this.comboBox_Fontfamily.SelectedIndex = 20;
            this.comboBox_DoubleFormat.SelectedIndex = 0;
            this.comboBox_DateFormat.SelectedIndex = 16;
            this.comboBox_StringAlign.SelectedIndex = 0;
            this.numericUpDown1.Enabled = false;      

        }
         #endregion

        #region InitializeChartData
        /// <summary>
        /// Initializes the ChartControl's data and sets the Chart type
        /// </summary>
        
        protected void InitializeChartData()
        {
            this.chartControl1.Series.Clear();
            ChartSeries series1 = new ChartSeries();
            series1.Name = "Electronics";
                series1.Text = series1.Name;

                series1.Points.Add(0, 6200);
                series1.Points.Add(1, 7500);
                series1.Points.Add(2, 4000);
                series1.Points.Add(3, 4900);
                series1.Points.Add(4, 3500);
                series1.Points.Add(5, 1100);
                series1.Points.Add(6, 950);

                series1.Type = ChartSeriesType.Column;
                this.chartControl1.Series.Add(series1);

                ChartSeries series2 = new ChartSeries();
                series2.Name = "Home Improvement";
                series2.Text = series2.Name;

                series2.Points.Add(0, 6550);
                series2.Points.Add(1, 7300);
                series2.Points.Add(2, 4750);
                series2.Points.Add(3, 5100);
                series2.Points.Add(4, 3750);
                series2.Points.Add(5, 1500);
                series2.Points.Add(6, 1050);

                series2.Type = ChartSeriesType.Column;
                this.chartControl1.Series.Add(series2);

                this.chartControl1.Dock = DockStyle.Fill;
            
        }
        #endregion

        #region  SetFont
        protected void SetFont()
        {
            if(this.comboBox_Fontfamily.SelectedIndex > 0)
            {
            FontStyle fs = (FontStyle)Enum.Parse(typeof(FontStyle), this.comboBox_FontStyle.SelectedItem.ToString(), true);
            this.chartControl1.PrimaryXAxis.Font = new Font(this.comboBox_Fontfamily.SelectedItem.ToString(), (float)this.numericUpDown_FontSize.Value, fs);
            }
        }
         #endregion
         #endregion

        #region Events
        private void comboBox_DateFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryXAxis.TickLabelsDrawingMode = ChartAxisTickLabelDrawingMode.AutomaticMode;
            this.chartControl1.PrimaryXAxis.DateTimeFormat = this.comboBox_datesHidden.Items[this.comboBox_DateFormat.SelectedIndex].ToString();
             //Sets the customization of default interval
            radioButton_ChartFormatAxisLabel.Checked = false;
        }

        private void font_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFont();
        }

        private void numericUpDown_FontSize_ValueChanged(object sender, EventArgs e)
        {
            SetFont();
        }

        private void colorPicker_TextColor_ColorSelected(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryXAxis.ForeColor = this.colorPicker_TextColor.SelectedColor;
        }

        bool CustomText_ChartFormat = false;
        private void radioButton_ChartFormatAxisLabel_CheckedChanged(object sender, EventArgs e)
        {           
            this.chartControl1.PrimaryXAxis.TickLabelsDrawingMode = ChartAxisTickLabelDrawingMode.AutomaticMode;
           CustomText_ChartFormat = this.radioButton_ChartFormatAxisLabel.Checked;
            this.chartControl1.Refresh();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.chartControl1.PrimaryXAxis.TickLabelsDrawingMode = ChartAxisTickLabelDrawingMode.UserMode;
                this.chartControl1.PrimaryXAxis.Labels.Clear();
                this.chartControl1.PrimaryXAxis.Labels.Add(new ChartAxisLabel("Mon", Color.MidnightBlue, new Font("Verdana", 11), 2, "", ChartValueType.Custom));
                this.chartControl1.PrimaryXAxis.Labels.Add(new ChartAxisLabel("Wed", Color.MidnightBlue, new Font("Verdana", 11), 4, "", ChartValueType.Custom));
                this.chartControl1.PrimaryXAxis.Labels.Add(new ChartAxisLabel("Fri", Color.MidnightBlue, new Font("Verdana", 11), 6, "", ChartValueType.Custom));
             
            }
            else
            {
                this.chartControl1.PrimaryXAxis.TickLabelsDrawingMode = ChartAxisTickLabelDrawingMode.AutomaticMode;
            }
        }

        private void comboBox_LabelIntersectAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryXAxis.LabelIntersectAction = (ChartLabelIntersectAction)Enum.Parse(typeof(ChartLabelIntersectAction), this.comboBox_LabelIntersectAction.SelectedItem.ToString(), true);                     
        }

        private void comboBox_EdgeDrawingMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryXAxis.EdgeLabelsDrawingMode = (ChartAxisEdgeLabelsDrawingMode)Enum.Parse(typeof(ChartAxisEdgeLabelsDrawingMode), this.comboBox_EdgeDrawingMode.SelectedItem.ToString(), true);            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryXAxis.HidePartialLabels = this.checkBox2.Checked;
            if (checkBox2.Checked == true)
            {
                this.checkBox2.Text = "Hide";
            }
            else
            {
                this.checkBox2.Text = "Visible";
            }
        }

        private void comboBox_StringAlign_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryXAxis.LabelAlignment = (StringAlignment)Enum.Parse(typeof(StringAlignment), this.comboBox_StringAlign.SelectedItem.ToString(), true);
              
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryXAxis.LabelRotate = this.checkBox1.Checked;
            this.numericUpDown1.Enabled = this.checkBox1.Checked;
            this.label4.ForeColor = this.checkBox1.Checked ? System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66))))) : System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryXAxis.LabelRotateAngle = (int)this.numericUpDown1.Value;
        }

        private void comboBox_DoubleFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBox_DoubleFormat.SelectedIndex)
            {
                case 0:
                    this.chartControl1.PrimaryYAxis.Format = "0";
                    break;
                case 1:
                    this.chartControl1.PrimaryYAxis.Format = "0.00";
                    break;
               case 2:
                    this.chartControl1.PrimaryYAxis.Format = "$#,##0.00";
                    break;
                case 3:
                    this.chartControl1.PrimaryYAxis.Format = "0.000";
                    break;
                case 4:
                    this.chartControl1.PrimaryYAxis.Format = "$#,##0.000";
                    break;
            }

        }
        
    #region ChartFormatAxisLabel
        string[] arr = new string[8];
        private void chartControl1_ChartFormatAxisLabel(object sender, Syncfusion.Windows.Forms.Chart.ChartFormatAxisLabelEventArgs e)
        {           
            int index = (int)e.Value+1;
            if (e.AxisOrientation == ChartOrientation.Horizontal)
            {
                if (CustomText_ChartFormat)
                {
                        string CustomText = this.textBox1.Text;
                        arr = CustomText.Split(new char[] { '\n' });
                        if (index < arr.Length)
                        {
                            e.Label = arr[index].ToString();
                        }
                        }
                }                
            e.Handled = true;          
        }
         #endregion     

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

         #endregion

       
    }
}