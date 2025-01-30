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

namespace GridLabelsChartSample_2002
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
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            chart.ElementsSpacing = 0;

            #endregion

            #region Axes and Legend Customization


            for (int i = 0; i < chart.Legend.Items.Length; i++)
            {
                chart.Legend.Items[i].Spacing = 2;
                chart.Legend.ItemsSize = new Size(13, 13);
                chart.Legend.Items[i].TextAligment = VerticalAlignment.Bottom;
                chart.Legend.BackColor = Color.Transparent;
                chart.LegendsPlacement = ChartPlacement.Outside;
                chart.LegendAlignment = ChartAlignment.Center;
                chart.LegendPosition = ChartDock.Bottom;
                chart.Legend.Font = new Font("Segoe UI", 10f);
            }

            chart.Series[0].Style.Symbol.Color = Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2);
            chart.Series[1].Style.Symbol.Color = Color.FromArgb(0xFF, 0xA0, 0x50, 0x00);
            chart.Series[2].Style.Symbol.Color = Color.FromArgb(0xFF, 0x33, 0x99, 0x33);
            chart.Series[0].Style.Symbol.Border.Color = Color.Transparent;
            chart.Series[1].Style.Symbol.Border.Color = Color.Transparent;
            chart.Series[2].Style.Symbol.Border.Color = Color.Transparent;
            chart.Series[0].Style.Symbol.Shape = ChartSymbolShape.Star;
            chart.Series[1].Style.Symbol.Shape = ChartSymbolShape.InvertedTriangle;
            chart.Series[2].Style.Symbol.Shape = ChartSymbolShape.Diamond;
          
            chart.Text = "Speed-Torque Variation";
            chart.PrimaryXAxis.Title = "Speed (rpm)";
            chart.PrimaryYAxis.Title = "Torque(Nm)";
            chart.Series[0].Style.Symbol.Size = new Size(15, 15);
            chart.Series[1].Style.Symbol.Size = new Size(15, 15);
            chart.Series[2].Style.Symbol.Size = new Size(15, 15);

            #endregion
        }
    }
}
