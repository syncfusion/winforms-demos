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

namespace ToolBarSample
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
            chart.ElementsSpacing = 5;
            #endregion

            #region Axes Customization           
         
            chart.Legend.Visible = false;
            chart.Text = "Sales Volume Comparison";
            chart.PrimaryXAxis.Title = "Year";       
			chart.PrimaryYAxis.Title = "Sales Price";       			
            chart.ShowToolTips = true;
           
            chart.ToolBar.Spacing = 1;
            chart.ToolBar.ButtonSize = new Size(25, 25);
            chart.ShowLegend = false;
            chart.ToolBar.BackColor = Color.Transparent;
            #endregion
        }
    }
}
