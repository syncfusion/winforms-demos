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
using System.Threading;

namespace ChartLocalization_2005
{
    public partial class Form1 : MetroForm
    {
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
            SeriesData();
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            this.chartControl1.Dock = DockStyle.Fill;


            this.comboBox1.SelectedIndex = 0;       
        }
        public void SeriesData()
        {
            chartControl1.Series.Clear();

            ChartSeries Gold = new ChartSeries("Gold");
            Gold.Points.Add(1992, 37, 20, 30, 40, 15);
            Gold.Points.Add(1996, 44, 20, 30, 40, 15);
            Gold.Points.Add(2000, 40, 20, 30, 40, 15);
            Gold.Points.Add(2004, 35, 20, 30, 40, 15);
            Gold.Points.Add(2008, 36, 20, 30, 40, 15);
            chartControl1.Series.Add(Gold);

            ChartSeries Silver = new ChartSeries("Silver");
            Silver.Points.Add(1992, 34, 20, 30, 40, 15);
            Silver.Points.Add(1996, 32, 20, 30, 40, 15);
            Silver.Points.Add(2000, 24, 20, 30, 40, 15);
            Silver.Points.Add(2004, 31, 20, 30, 40, 15);
            Silver.Points.Add(2008, 38, 20, 30, 40, 15);
            chartControl1.Series.Add(Silver);

            ChartSeries Bronze = new ChartSeries("Bronze");
            Bronze.Points.Add(1992, 37, 20, 30, 40, 15);
            Bronze.Points.Add(1996, 25, 20, 30, 40, 15);
            Bronze.Points.Add(2000, 33, 20, 30, 40, 15);
            Bronze.Points.Add(2004, 29, 20, 30, 40, 15);
            Bronze.Points.Add(2008, 36, 20, 30, 40, 15);
            Bronze.Type = ChartSeriesType.Spline;
            Bronze.Style.Symbol.Shape = ChartSymbolShape.Circle;
            Bronze.Style.Symbol.Color = Color.White;
            Bronze.Style.Symbol.Border.Color = Color.Green;
            Bronze.Style.Symbol.Border.Width = 2;
            Bronze.ZOrder = 0;
            chartControl1.Series.Add(Bronze);

            this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryXAxis.Range = new MinMaxInfo(1988, 2012, 4);
            this.chartControl1.Series.Changed += Series_Changed;

        }

        void Series_Changed(object sender, ChartSeriesCollectionChangedEventArgs e)
        {
            if (this.chartControl1.RequireInvertedAxes)
            {
                this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Auto;
            }
            else
            {
                this.chartControl1.PrimaryXAxis.Range = new MinMaxInfo(1988, 2012, 4);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            this.chartControl1.Localize = this.comboBox1.Text;
            switch (this.comboBox1.Text)
            {
                case "de-DE":
                    this.chartControl1.Text = "US-Rekorde in Olympia";
                    this.chartControl1.PrimaryXAxis.Title = "Year";
                    this.chartControl1.PrimaryYAxis.Title = "Anzahl der Medaillen gewonnen";
                    this.Text = "Chart-Lokalisierung";
                    break;
                case "fr-FR":
                    this.chartControl1.Text = "US records aux Jeux Olympiques";
                    this.chartControl1.PrimaryXAxis.Title = "Year";
                    this.chartControl1.PrimaryYAxis.Title = "Nombre de m�dailles remport�es";
                    this.Text = "Chart Localisation";
                    break;
                default:
                    this.chartControl1.Text = "US Records in Olympics";
                    this.chartControl1.PrimaryXAxis.Title = "Year";
                    this.chartControl1.PrimaryYAxis.Title = "Number of Medals Won";
                    break;
            }
            
        }     
    }
}