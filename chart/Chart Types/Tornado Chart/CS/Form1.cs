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

namespace TornadoChart_2005
{
    public partial class Form1 : MetroForm
    {
        # region Form Load
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
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }

        #endregion

        # region Helper Methods

        #region InitializeChartData
        ChartCustomPoint ccp;
        ChartCustomPoint ccp1;
        protected void InitializeChartData()
        {
            ChartSeries Task1 = new ChartSeries("Male", ChartSeriesType.Tornado);

            Task1.Points.Add(1, -50, -12);
            Task1.Points.Add(2, -50, -91);
            Task1.Points.Add(3, -50, -397);
            Task1.Points.Add(4, -50, -1072);
            Task1.Points.Add(5, -50, -2117);
            Task1.Points.Add(6, -50, -3094);
            Task1.Points.Add(7, -50, -3804);
            Task1.Points.Add(8, -50, -4712);
            Task1.Points.Add(9, -50, -6203);
            Task1.Points.Add(10, -50, -8415);
            Task1.Points.Add(11, -50, -9771);
            Task1.Points.Add(12, -50, -11076);
            Task1.Points.Add(13, -50, -11282);
            Task1.Points.Add(14, -50, -10449);
            Task1.Points.Add(15, -50, -9987);
            Task1.Points.Add(16, -50, -10016);
            Task1.Points.Add(17, -50, -10657);
            Task1.Points.Add(18, -50, -10862);
            Task1.Points.Add(19, -50, -10670);
            Task1.Points.Add(20, -50, -9954);
            Task1.Points.Add(21, -50, -10471);
            this.chartControl1.Series.Add(Task1);

            ChartSeries Task2 = new ChartSeries("Female", ChartSeriesType.Tornado);

            Task2.Points.Add(1, 50, 58);
            Task2.Points.Add(2, 50, 321);
            Task2.Points.Add(3, 50, 1034);
            Task2.Points.Add(4, 50, 2135);
            Task2.Points.Add(5, 50, 3459);
            Task2.Points.Add(6, 50, 4282);
            Task2.Points.Add(7, 50, 4697);
            Task2.Points.Add(8, 50, 5412);
            Task2.Points.Add(9, 50, 6814);
            Task2.Points.Add(10, 50, 8944);
            Task2.Points.Add(11, 50, 10212);
            Task2.Points.Add(12, 50, 11377);
            Task2.Points.Add(13, 50, 11452);
            Task2.Points.Add(14, 50, 10420);
            Task2.Points.Add(15, 50, 9860);
            Task2.Points.Add(16, 50, 9737);
            Task2.Points.Add(17, 50, 10166);
            Task2.Points.Add(18, 50, 10310);
            Task2.Points.Add(19, 50, 10167);
            Task2.Points.Add(20, 50, 9512);
            Task2.Points.Add(21, 50, 10024);
            this.chartControl1.Series.Add(Task2);
            this.chartControl1.Titles[0].Text = "Resident Population Projections \n by Sex and Age: 2005";
           
            for (int i = 0; i < this.chartControl1.Series[0].Points.Count; i++)
            {
                ccp = new ChartCustomPoint();
                ccp.XValue = this.chartControl1.Series[0].Points[i].X;
                ccp.YValue = this.chartControl1.Series[0].Points[i].YValues[1] - 1000;
                ccp.CustomType = ChartCustomPointType.ChartCoordinates;
                Char[] ch = new Char[] { '-' };
                ccp.Text = this.chartControl1.Series[0].Points[i].YValues[1].ToString().TrimStart(ch);
                ccp.Color = Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2);
                ccp.Font.Facename = "Segoe UI";
                ccp.Font.Size = 8f;
                this.chartControl1.CustomPoints.Add(ccp);

                ccp1 = new ChartCustomPoint();
                ccp1.XValue = this.chartControl1.Series[1].Points[i].X;
                ccp1.YValue = this.chartControl1.Series[1].Points[i].YValues[1] + 1000;
                ccp1.CustomType = ChartCustomPointType.ChartCoordinates;
                ccp1.Text = this.chartControl1.Series[1].Points[i].YValues[1].ToString();
                ccp1.Color = Color.FromArgb(0xFF, 0xA0, 0x50, 0x00);
                ccp1.Font.Facename = "Segoe UI";
                ccp1.Font.Size = 8f;

                this.chartControl1.CustomPoints.Add(ccp1);
            }
        }
        #endregion

        # endregion

        #region Events
        string[] labels = new string[] { "", "100 + ", "95 to 99", "90 to 94", "85 to 89", "80 to 84", "75 to 79", "70 to 74", "65 to 69", "60 to 64", "55 to 59", "50 to 54", "45 to 49", "40 to 44", "35 to 39", "30 to 34", "25 to 29", "20 to 24", "15 to 19", "10 to 14", "5 to 9", "Under 5" };
        private void chartControl1_ChartFormatAxisLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            if (e.AxisOrientation == ChartOrientation.Vertical)
            {
                int index = (int)e.Value;

                if (index >= 0 && index < labels.Length)
                {
                    //Applying custom label text for X Axis
                    e.Label = labels[index];
                }
                else
                {
                    e.Label = "";
                }
            }
            else
            {
                e.Label = "";
            }
            e.Handled = true;
        }
        #endregion       
    }
}