#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace ChartImportData
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
            chart.PrimaryXAxis.FormatLabel += PrimaryXAxis_FormatLabel;
            chart.ElementsSpacing = 15;

            #endregion

            #region Axes Customization

            chart.PrimaryXAxis.HidePartialLabels = true;
            chart.PrimaryYAxis.HidePartialLabels = true;
            chart.Legend.Visible = false;
            chart.Text = "Rainfall Analysis mid 2009";
            chart.PrimaryXAxis.Title = "Month";
            chart.PrimaryYAxis.Title = "Rainfall Rate";
            chart.ShowToolTips = true;
            chart.Series3D = true;

            #endregion
        }

        private static void PrimaryXAxis_FormatLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            e.Handled = true;
            e.Label = (e.Value + 1).ToString();
        }
    }
}

