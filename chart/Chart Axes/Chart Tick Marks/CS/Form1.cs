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
using System.Reflection;
using System.IO;

namespace TickMarksDemo_2005
{
    public partial class Form1 : MetroForm
    {
        #region Form's Constructor

        public Form1()
        {
            InitializeComponent();
            InitializeChartData();
            InitializeControlSettings();

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
        }
        #endregion

        #region Helper Methods
        #region InitializeChartData

        private void InitializeChartData()
        {
            ChartSeries series = new ChartSeries();
            series.Name = "Series 1";
            series.Points.Add(175, 7);
            series.Points.Add(200, 6);
            series.Points.Add(225, 5);
            series.Points.Add(250, 4);
            series.Points.Add(275, 3);
            series.Points.Add(300, 2);
            series.Points.Add(325, 1);
            series.Type = ChartSeriesType.Bar;
            series.Text = series.Name;
            this.chartControl1.Series.Add(series);
            
            this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryXAxis.Range = new MinMaxInfo(-1, 8, 1);            
            this.chartControl1.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryYAxis.Range = new MinMaxInfo(150, 350, 50);
           // this.chartControl1.Skins = Skins.Metro;

            this.chartControl1.Dock = DockStyle.Fill;

        }
        #endregion

        #region InitializeControlSettings

   
        private void InitializeControlSettings()
        {
           this.chartControl1.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.None;
               this.chartControl1.PrimaryYAxis.DrawGrid = false;
            this.chartControl1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.chartControl1.Series[0].Style.Interior = new BrushInfo(Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2));
            this.chartControl1.Series[0].Style.Border.Color = Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2);           
             
            ChartStripLine thermoStripLine = new ChartStripLine();
            //thermoStripLine.Enabled = true;
            //thermoStripLine.Vertical = true;                 
            //thermoStripLine.StartAtAxisPosition = true;
            //thermoStripLine.Start = 0;          
            //thermoStripLine.Text = "Transmission Oil Temperature ";
            Assembly asem = this.GetType().Assembly;
            Stream str = asem.GetManifestResourceStream("TickMarksDemo_2005.Thermometer.png");
            Image img = Image.FromStream(str);
            thermoStripLine.BackImage = img;
            thermoStripLine.Font = new System.Drawing.Font("Segeo UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            thermoStripLine.Period = 9;
            thermoStripLine.Width =.5;          
            this.chartControl1.PrimaryXAxis.StripLines.Add(thermoStripLine);
  this.chartControl1.ShowLegend = false;
          
           
            ChartCustomPoint cp1 = new ChartCustomPoint();
            cp1.Text = "LOW HEAT : LONG MILEAGE";
            cp1.CustomType = ChartCustomPointType.ChartCoordinates;
            cp1.Font.Facename = "Segeo UI";
            cp1.Font.FontStyle = FontStyle.Bold;
            cp1.Font.Size = 7;
            cp1.XValue = 158;
            cp1.YValue = 4;
            this.chartControl1.CustomPoints.Add(cp1);

            ChartCustomPoint cp2 = new ChartCustomPoint();
            cp2.Text = "HIGH HEAT : SHORT MILEAGE";
            cp2.Font.Facename = "Segeo UI";
            cp2.Font.FontStyle = FontStyle.Bold;
            cp2.Font.Size = 7;
            cp2.CustomType = ChartCustomPointType.ChartCoordinates;
            cp2.XValue = 335;
            cp2.YValue = 4;
            this.chartControl1.CustomPoints.Add(cp2);

            this.chartControl1.Refresh();
        }
        #endregion
        #endregion

        #region Events
        #region ChartFormatAxisLabel
        string[] labels = new string[] { "",  "800 ml", "5000 ml", "10,000 ml", "20,000 ml", "50,000 ml", "100,000 ml", "", ""};
         private void chartControl1_ChartFormatAxisLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            if (e.AxisOrientation == ChartOrientation.Vertical)
            {
                //Applying Formatted Y Axis label values.
                e.Label = string.Format("{0}'F", e.Value);
            }
            else
            {
                if ((int)e.Value >= 0 && (int)e.Value < 8)
                {
                    e.Label = labels[(int)e.Value];
                }
            }
            e.Handled = true;
        }
        #endregion

        #endregion

        #region X Axis Ticks

        private void cbXAxisDrawLabelGrid_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryXAxis.DrawTickLabelGrid = cbXAxisDrawLabelGrid.Checked;
            this.nUDXAxisTickGridPadding.Enabled = cbXAxisDrawLabelGrid.Checked;
        }

        private void cpXAxisTickColor_ColorSelected(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryXAxis.TickColor = cpXAxisTickColor.SelectedColor;
        }

        private void nUDXAxisTicksPerInterval_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryXAxis.SmallTicksPerInterval = (int)nUDXAxisTicksPerInterval.Value;
        }

        private void nUDXAxisTickGridPadding_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryXAxis.TickLabelGridPadding = (int)nUDXAxisTickGridPadding.Value;
        }

        private void nUDXAxisTickHeight_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryXAxis.TickSize = new Size((int)nUDXAxisTickWidth.Value, (int)nUDXAxisTickHeight.Value);
        }

        private void nUDXAxisTickWidth_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryXAxis.TickSize = new Size((int)nUDXAxisTickWidth.Value, (int)nUDXAxisTickHeight.Value);
        }

        private void nUDXAxisSmallTickHeight_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryXAxis.SmallTickSize = new Size((int)nUDXAxisSmallTickWidth.Value, (int)nUDXAxisSmallTickHeight.Value);
        }

        private void nUDXAxisSmallTickWidth_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryXAxis.SmallTickSize = new Size((int)nUDXAxisSmallTickWidth.Value, (int)nUDXAxisSmallTickHeight.Value);
        }
      
        #endregion

        #region Y Axis Ticks

        private void cpYAxisTickColor_ColorSelected(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryYAxis.TickColor = cpYAxisTickColor.SelectedColor;
        }
        private void cbYAxisDrawLabelGrid_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryYAxis.DrawTickLabelGrid = cbYAxisDrawLabelGrid.Checked;
            this.nUDYAxisTickGridPadding.Enabled = cbYAxisDrawLabelGrid.Checked;
            this.label7.ForeColor = cbYAxisDrawLabelGrid.Checked ? System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66))))) : System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));

        }

        private void nUDYAxisTicksPerInterval_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryYAxis.SmallTicksPerInterval = (int)nUDYAxisTicksPerInterval.Value;
        }

        private void nUDYAxisTickGridPadding_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryYAxis.TickLabelGridPadding = (int)nUDYAxisTickGridPadding.Value;
        }

        private void nUDYAxisTickHeight_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryYAxis.TickSize = new Size((int)nUDYAxisTickWidth.Value, (int)nUDYAxisTickHeight.Value);
        }

        private void nUDYAxisTickWidth_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryYAxis.TickSize = new Size((int)nUDYAxisTickWidth.Value, (int)nUDYAxisTickHeight.Value);
        }

        private void nUDYAxisSmallTickHeight_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryYAxis.SmallTickSize = new Size((int)nUDYAxisSmallTickWidth.Value, (int)nUDYAxisSmallTickHeight.Value);
        }

        private void nUDYAxisSmallTickWidth_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryYAxis.SmallTickSize = new Size((int)nUDYAxisSmallTickWidth.Value, (int)nUDYAxisSmallTickHeight.Value);
        }

        #endregion
      
    }
}
