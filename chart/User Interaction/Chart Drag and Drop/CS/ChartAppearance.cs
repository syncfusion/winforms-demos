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

namespace ChartDragDrop
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

            #region Axes Customization

           chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryYAxis.Range = new MinMaxInfo(0, 100, 25);
            chart.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryXAxis.Range = new MinMaxInfo(0, 7, 1);

            chart.Series[0].Style.Symbol.Shape = ChartSymbolShape.Circle;
            chart.Series[0].Style.Symbol.Size = new Size(8, 8);
            chart.Series[0].Style.DisplayText = true;
            chart.Series[0].Style.TextFormat = "{0}";
            chart.Series[0].Style.TextOrientation = ChartTextOrientation.Up;
           chart.Series[0].Style.Border.Width = 2;
            chart.Text = "Daily Performance ";
            chart.PrimaryYAxis.Title = "Task finished(%)";
            chart.PrimaryXAxis.Title = "Days";

            #endregion

            #region Legend Customization

            chart.ShowLegend = false;

            #endregion
        }
    }
}
