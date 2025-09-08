#region Copyright Syncfusion Inc. 2001 - 2014
// Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
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

namespace WindowsApplication1
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            #region ApplyCustomPalette
            chart.Skins = Skins.Metro;
            #endregion

            #region Chart Appearance Customization

            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            chart.ElementsSpacing = 5;

            #endregion

            #region Axes and Legend Customization

            // Customizing primary axes line and grid line.
          
            chart.PrimaryXAxis.HidePartialLabels = true;
            chart.PrimaryXAxis.DrawGrid = true;            
            chart.PrimaryYAxis.Range.Min = 0;

            // Enable Interlaced grid for X-Axis
            chart.PrimaryXAxis.InterlacedGrid = true;



            // The below code illustrate how to set the axes range.
            chart.PrimaryXAxis.Title = "Date";
            chart.PrimaryYAxis.Title = "Shares (%)";
            chart.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set;
            chart.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 10, 10);
            chart.PrimaryXAxis.ValueType = ChartValueType.DateTime;
            chart.PrimaryXAxis.RangeType = ChartAxisRangeType.Auto;
            chart.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(new DateTime(2007, 1, 1), new DateTime(2007, 6, 1), 0, ChartDateTimeIntervalType.Months);
            chart.PrimaryXAxis.DateTimeFormat = "MMM yy";
             chart.PrimaryYAxis.Range = new Syncfusion.Windows.Forms.Chart.MinMaxInfo(0, 40, 5);
            chart.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set;


            // Customizing the legend appearance.
            for (int i = 0; i < chart.Legend.Items.Length; i++)
            {
                chart.Legend.Items[i].Spacing = 6;
                chart.Legend.ItemsSize = new Size(13, 13);
                chart.Legend.Items[i].TextAligment = VerticalAlignment.Bottom;
                chart.Legend.BackColor = Color.Transparent;
                chart.LegendsPlacement = ChartPlacement.Outside;
                chart.LegendAlignment = ChartAlignment.Center;
                chart.LegendPosition = ChartDock.Bottom;
                chart.Legend.Font = new Font("Segoe UI", 10f);
            }
            #endregion
        }
    }
}
