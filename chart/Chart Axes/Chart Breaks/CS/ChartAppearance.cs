#region Copyright Syncfusion Inc. 2001 - 2014
// Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace EssentialChartSample
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
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            chart.ElementsSpacing = 5;

            #endregion

            #region Axes Customization

            chart.PrimaryXAxis.HidePartialLabels = true;
            chart.PrimaryYAxis.HidePartialLabels = true;
            chart.Indexed = true;
            chart.Legend.Visible = false;
            chart.ShowToolTips = true;
            chart.Series[0].Style.Border.Color = Color.Transparent;

            // Set the Chart and axes titles.
            chart.Titles[0].Text = "Most Populated Countries in the World \n Mid-Year 2008";
            chart.PrimaryXAxis.Title = "Countries";
            chart.PrimaryYAxis.Title = "Population in Millions";
            chart.Titles[0].Font = new Font("Segoe UI", 14.0f, FontStyle.Regular);

            // Set primary X-Axis range.
            chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryYAxis.Range = new MinMaxInfo(0, 1400, 100);

            // Rotate the primary axis labels.
            chart.PrimaryXAxis.LabelRotate = true;
            chart.PrimaryXAxis.LabelRotateAngle = 60;

            // Set breaks for the chart
            chart.PrimaryYAxis.MakeBreaks = true;

            #endregion
        }
    }
}
