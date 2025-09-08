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
            chart.BorderAppearance.FrameThickness = new ChartThickness(-2, -2, 2, 2);
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            chart.ShowToolTips = true;           

            #endregion

            #region Axes Customization
            chart.PrimaryYAxis.DrawGrid = false;
           chart.PrimaryXAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;         
            chart.EnableXZooming = true;            
            chart.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.None;
            chart.PrimaryXAxis.LabelRotate = true;
            chart.PrimaryXAxis.LabelRotateAngle = 90;
            chart.ShowToolTips = true;
            chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryYAxis.Range = new MinMaxInfo(0, 600, 100);
           
            //Turns off the legend.
            chart.Legend.Visible = false;
            chart.Text = "100000 Original Data Points";           
            chart.PrimaryXAxis.Title = "X Values";
            chart.PrimaryYAxis.Title = "Server Load (MBytes)";
             chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            #endregion
        }
    }
}
