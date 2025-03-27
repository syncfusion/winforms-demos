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

namespace ChartMultiLevelLabel_2005
{
    public partial class Form1 : MetroForm
    {
        #region Constructor
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
            InitializeControlSettings();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }
        #endregion

        #region InitializeControlSettings()
        /// <summary>
        /// Initial setting of chart control.
        /// </summary>
        private void InitializeControlSettings()
        {           
            this.chartControl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            foreach (string fontstyle in Enum.GetNames(typeof(System.Drawing.FontStyle))) ;
        }
        #endregion

        #region InitializeChartData()
        /// <summary>
        /// Initializes the ChartControl's data and sets the Chart type.
        /// </summary>
        protected void InitializeChartData()
        {
            chartControl1.Legend.Visible = false;
                        
            ChartSeries series1 = new ChartSeries();
            series1.Type = ChartSeriesType.Spline;
            series1.SortPoints = false;
            series1.Style.Symbol.Shape = ChartSymbolShape.Circle;
            series1.Style.Symbol.Border.Color = Color.White;
            series1.Style.Interior = new BrushInfo(Color.FromArgb(232, 190, 51));
            series1.Style.Symbol.Color = series1.Style.Interior.BackColor;            
            series1.Text = series1.Name;

            series1.Points.Add("Jan", 1);
            series1.Points.Add("Feb", 5);
            series1.Points.Add("Mar", 2);
            series1.Points.Add("Apr", 8);
            series1.Points.Add("May", 30);
            series1.Points.Add("Jun", 18);
            series1.Points.Add("July", 32);
            series1.Points.Add("Aug", 20);
            series1.Points.Add("Sep", 16);
            series1.Points.Add("Oct", 10);
            series1.Points.Add("Nov", 4);
            series1.Points.Add("Dec", 5);
            
            this.chartControl1.Series.Add(series1);

            this.chartControl1.Dock = DockStyle.Fill;

            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
        }
        #endregion
    }
}

