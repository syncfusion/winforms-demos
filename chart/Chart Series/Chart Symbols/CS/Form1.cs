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

namespace ChartPoints_2005
{
    public partial class Form1 : MetroForm
    {
        #region Form Load
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
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            this.chartControl1.Dock = DockStyle.Fill;
        }
        #endregion

        #region  InitializeChartData
        protected void InitializeChartData()
        {
            ChartSeries Wheat = new ChartSeries("Wheat", ChartSeriesType.Line);
            Wheat.Points.Add(1997, 250 );
            Wheat.Points.Add(1998, 235);
            Wheat.Points.Add(1999, 290);
            Wheat.Points.Add(2000, 400);
            Wheat.Points.Add(2001, 480);
            Wheat.Points.Add(2002, 490);
            Wheat.Points.Add(2003, 480);
            Wheat.Points.Add(2004, 500);
            Wheat.Points.Add(2005, 590);
            Wheat.Points.Add(2006, 660);
            Wheat.Points.Add(2007, 600);
            this.chartControl1.Series.Add(Wheat);
            Wheat.Style.Border.Width = 3;
            Wheat.Style.Symbol.Shape = ChartSymbolShape.Circle;
            Wheat.Style.Symbol.Color = Color.White;
            Wheat.Style.Symbol.Border.Color = Color.White;
            Wheat.Style.Symbol.Border.Width = 3;
            Wheat.Style.Symbol.Size = new Size(8, 8);
            Wheat.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            Wheat.Style.ImageIndex = 0;
            Wheat.Style.Symbol.Shape = ChartSymbolShape.Image;
            Wheat.Style.Symbol.ImageIndex = 1;

        }
        #endregion

        #region InitializeControlSettings
        protected void InitializeControlSettings()
        {
            foreach (string symbol in Enum.GetNames(typeof(Syncfusion.Windows.Forms.Chart.ChartSymbolShape)))
                this.cmbSymbolStyle.Items.Add(symbol);

            this.cmbSymbolStyle.SelectedIndex = 3;
        }
        #endregion

        #region Events
        private void cmbSymbolStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSymbol();
        }

        private void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            SetSymbol();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            SetSymbol();
        }

        #region Set Symbols

        protected void SetSymbol()
        {
            // Symbol to points
            if (radioButton1.Checked)
                this.chartControl1.Series[0].PrepareStyle += new ChartPrepareStyleInfoHandler(ChartControlSeries_PrepareStyle);
            else
                this.chartControl1.Series[0].PrepareStyle -= new ChartPrepareStyleInfoHandler(ChartControlSeries_PrepareStyle);

            // Symbol to series
            if (this.radioButton2.Checked)
            {
                this.chartControl1.Series[0].Style.Symbol.Color = colorPickerButton1.SelectedColor;          

                this.chartControl1.Series[0].Style.Symbol.Size = new Size((int)this.numericUpDown1.Value, (int)this.numericUpDown1.Value);
                this.chartControl1.Series[0].Style.Symbol.Shape = (ChartSymbolShape)Enum.Parse(typeof(ChartSymbolShape), this.cmbSymbolStyle.SelectedItem.ToString(), true);
                if (this.chartControl1.Series[0].Style.Symbol.Shape == ChartSymbolShape.Image)
                {
                    this.chartControl1.Series[0].Style.Symbol.Size = new Size(25, 25);
                    this.numericUpDown1.Value = 25;
                }
            }
            this.chartControl1.Refresh();
        }
        #endregion

        #region Symbols to Points
        protected void ChartControlSeries_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
        {
            ChartSeries series = sender as ChartSeries;
            Random rand = new Random();

            if (args.Index == 4)
            {
                args.Style.Symbol.Shape = (ChartSymbolShape)Enum.Parse(typeof(ChartSymbolShape), this.cmbSymbolStyle.SelectedItem.ToString(), true);
                args.Style.Symbol.Size = new Size((int)this.numericUpDown1.Value, (int)this.numericUpDown1.Value);
                args.Style.Symbol.Color = colorPickerButton1.SelectedColor;
            }
        }
        #endregion
        #endregion
    }
}