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
            chart.Skins = Skins.Metro;

            #region Chart Appearance Customization
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.None;            
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            chart.ElementsSpacing = 5;

            #endregion

            #region Axes Customization
            chart.PrimaryXAxis.DrawGrid = false;
            chart.Depth = 100;
            chart.Tilt = 15;
            chart.Series3D = true;
            chart.Rotation = 15;
            chart.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryXAxis.Range = new MinMaxInfo(0, 13, 1);
            chart.PrimaryYAxis.Range = new MinMaxInfo(0, 100, 20);
            chart.Spacing = 0;
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
