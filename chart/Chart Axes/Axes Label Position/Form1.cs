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

namespace AxesLabelPosition_2008
{
    public partial class Form1 : Office2007Form
    {


        public Form1()
        {
            InitializeComponent();

        }



        private void InitChart()
        {
            this.chartControl1.PrimaryXAxis.DrawGrid = false;
            this.chartControl1.PrimaryYAxis.DrawGrid = false;

        }
        private void Appearanceset()
        {
          //  chartControl1.Palette = ChartColorPalette.Custom;
            //chartControl1.CustomPalette = new System.Drawing.Color[] 
            //{              
            //    Color.FromArgb(200, 41,122,139),
            //    Color.FromArgb(200, 140,198,62),
            //    Color.FromArgb(200,247,148,29),
            //    Color.FromArgb(200, 163,48,45)                     
            //};

            #region Chart Appearance Customization

            chartControl1.BackInterior = new BrushInfo(GradientStyle.PathRectangle, new Color[] { Color.FromArgb(214, 231, 247), Color.White });
            chartControl1.ChartArea.BackInterior = new BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent);
            chartControl1.ChartInterior = new BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent);
            chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame;
            chartControl1.BorderAppearance.BaseColor = Color.SkyBlue;
            chartControl1.BorderAppearance.FrameThickness = new ChartThickness(-2, -2, 2, 2);
            chartControl1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            chartControl1.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            chartControl1.ElementsSpacing = 5;

            #endregion

            #region Axes Customization

            chartControl1.PrimaryXAxis.HidePartialLabels = true;
            chartControl1.PrimaryYAxis.HidePartialLabels = true;
            chartControl1.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(175, 129, 115, 27);
            chartControl1.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(175, 129, 115, 27);
            chartControl1.PrimaryXAxis.LineType.Width = 2;
            chartControl1.PrimaryYAxis.LineType.Width = 2;
            chartControl1.PrimaryXAxis.TickColor = Color.Transparent;
            chartControl1.PrimaryYAxis.TickColor = Color.Transparent;
            chartControl1.PrimaryXAxis.GridLineType.ForeColor = Color.LightGray;
            chartControl1.PrimaryYAxis.GridLineType.ForeColor = Color.LightGray;
            chartControl1.Legend.Visible = false;
            chartControl1.Series[0].Style.Symbol.Border.Color = Color.FromArgb(200, 129, 115, 27);
            chartControl1.Titles[0].Font = new Font("Verdana", 12.0f, FontStyle.Bold);

            #endregion
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            InitChart();
            Appearanceset();
            this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryXAxis.Range = new MinMaxInfo(-150, 150, 50);
            this.chartControl1.Text = "Net Export of Selected Nation";
            ChartSeries ser = new ChartSeries("Area");
 
            ser.Points.Add(1, -45);
            ser.Points.Add(2, -80);
            ser.Points.Add(3, 90);
            ser.Points.Add(4, 10);
            ser.Points.Add(5, 50);
            ser.Points.Add(6, 80);
 
            ser.Type = ChartSeriesType.Bar;
            this.chartControl1.Series.Add(ser);
            for (int i = 0; i < ser.Points.Count; i++)
            {
                if (ser.Points[i].YValues[0] < 0)
                    ser.Styles[i].Interior = new BrushInfo(Color.OrangeRed);
                else
                    ser.Styles[i].Interior = new BrushInfo(Color.LightGreen);

            }
            this.chartControl1.PrimaryYAxis.AxisLabelPlacement = ChartPlacement.Inside;
            this.chartControl1.PrimaryYAxis.Crossing = 0;  


        }

        private void chartControl1_ChartFormatAxisLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            
            if (e.AxisOrientation == ChartOrientation.Vertical)
            {
                if (e.Label == "1")
                {
                  
                    e.Label = "Canada";
                    
                }
                else if (e.Label == "2")
                {
                     e.Label = "France";

                }
                else if (e.Label == "3")
                {
                    e.AxisLabelPlacement = ChartPlacement.Outside;
                    e.Label = "Italy";

                }
                else if (e.Label == "4")
                {
                    e.AxisLabelPlacement = ChartPlacement.Outside;
                    e.Label = "Japan";

                }
                else if (e.Label == "5")
                {
                    e.AxisLabelPlacement = ChartPlacement.Outside;
                    e.Label = "Britain";

                }
                else if (e.Label == "6")
                {
                    e.AxisLabelPlacement = ChartPlacement.Outside;
                    e.Label = "United States";

                }
                e.Handled = true;
            }
        }

    }
}
