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

namespace Syncfusion.Windows.Forms.Chart.Samples
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
            chart.BorderAppearance.FrameThickness = new ChartThickness(-2, -2, 2, 2);
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            chart.PrimaryXAxis.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.Shift;
            chart.ElementsSpacing = 5;

            #endregion

            #region Axes and Legend Customization

             chart.PrimaryXAxis.DrawGrid = false;
            chart.PrimaryXAxis.Title = "Date";
            chart.PrimaryYAxis.Title = "Average Load";
            chart.Text = "Peak Average Network Load";
            chart.Titles[0].Font = new Font("Segoe UI", 14.0f, FontStyle.Regular);
            chart.Font = new Font("Segoe UI", 7.0f, FontStyle.Regular);
           
            chart.Legend.BackColor = Color.Transparent;
            chart.LegendsPlacement = ChartPlacement.Outside;
            chart.LegendAlignment = ChartAlignment.Center;
            chart.LegendPosition = ChartDock.Bottom;
            chart.Legend.ItemsSize= new Size(15, 15);
           
            #endregion
        }
    }
}
