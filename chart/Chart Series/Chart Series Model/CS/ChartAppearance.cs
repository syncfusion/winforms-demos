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

namespace ChartSeriesModel
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
            chart.ElementsSpacing = 5;

            #endregion

            #region Axes Customization

            chart.PrimaryXAxis.HidePartialLabels = true;
         
            chart.PrimaryXAxis.ValueType = ChartValueType.DateTime;
            
            chart.Legend.Visible = false;
            chart.ShowToolTips = true;
           
            chart.StyleDialogOptions.ShowBorderTab = true;
            chart.StyleDialogOptions.ShowTextTab = false;
            chart.StyleDialogOptions.ShowFancyToolTipsTab = false;
            chart.StyleDialogOptions.ShowInteriorTab = false;
            chart.StyleDialogOptions.ShowShadowTab = false;
            chart.StyleDialogOptions.ShowSymbolTab = false;
            chart.ShowLegend = false;
            #endregion
        }
    }
}
