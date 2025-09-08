#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace LineChart2002
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            #region ApplyCustomPalette
            chart.Skins = Skins.Metro;
            #endregion

            #region Chart Appearance Customization

            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.None;   
            chart.PrimaryXAxis.RangePaddingType = ChartAxisRangePaddingType.Calculate;
            chart.PrimaryYAxis.RangePaddingType = ChartAxisRangePaddingType.Calculate;
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            
            chart.ElementsSpacing = 0;
            chart.Text = "National football team ranking(1985-2000)";
            chart.PrimaryXAxis.Title = "Year";
            chart.PrimaryYAxis.Title = "Rank";
            chart.Series[1].Style.Border.Width = 2;
            chart.Series[0].Style.Border.Width = 2;
            chart.Series[2].Style.Border.Width = 2;
            chart.Series[0].Style.Symbol.Border.Color = Color.White;
            chart.Series[1].Style.Symbol.Border.Color = Color.White;
            chart.Series[2].Style.Symbol.Border.Color = Color.White;
            chart.Series[1].Style.Symbol.Shape = ChartSymbolShape.Square;
            chart.Series[1].Style.Symbol.Color = Color.FromArgb(200, 199, 23, 33);
            chart.Series[1].Style.Symbol.Size = new Size(10, 10);
            chart.Series[0].Style.Symbol.Shape = ChartSymbolShape.Circle;
            chart.Series[0].Style.Symbol.Color = Color.FromArgb(200, 9, 116, 210);
            chart.Series[0].Style.Symbol.Size = new Size(10, 10);
            chart.Series[2].Style.Symbol.Shape = ChartSymbolShape.Diamond;            
            chart.Series[2].Style.Symbol.Color = Color.FromArgb(200, 36, 119, 51); 
            chart.Series[2].Style.Symbol.Size = new Size(10, 10);
            chart.ShowToolTips = true;          

            #endregion

            #region Axes Customization

           
            chart.PrimaryYAxis.Inversed = true;
            chart.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryXAxis.Range = new MinMaxInfo(1985, 2000, 1);
            chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryYAxis.Range = new MinMaxInfo(0, 16, 2);
            chart.PrimaryXAxis.LabelRotate = true;
            chart.PrimaryXAxis.LabelRotateAngle = 90;
            chart.EnableMouseRotation = true; 
            #endregion

            #region Legend Customization
            for (int i = 0; i < chart.Legend.Items.Length; i++)
            {
                chart.Legend.Items[i].Spacing = 2;
                chart.Legend.ItemsSize = new Size(13, 13);
                chart.Legend.Items[i].TextAligment = VerticalAlignment.Bottom;
                chart.Legend.BackColor = Color.Transparent;
                chart.LegendsPlacement = ChartPlacement.Outside;
                chart.LegendAlignment = ChartAlignment.Center;
                chart.LegendPosition = ChartDock.Bottom;
                chart.Legend.Font = new Font("Segoe UI", 10.25f);
            }
            #endregion
        }


    }
}
