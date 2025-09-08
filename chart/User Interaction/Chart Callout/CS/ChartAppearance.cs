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

namespace ChartCallout
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

            #region Styles Customization

           

            chart.Series[0].Style.Callout.Enable = true;
            chart.Series[0].Style.Callout.DisplayTextAndFormat = "{1},{2}";
            chart.Series[0].Style.Callout.Position = LabelPosition.Top;
            chart.Series[0].Style.Callout.Border.Width = 1.5f;
            chart.Series[0].Style.Callout.Border.Color = Color.Black;
            
            #endregion

            #region Legend Customization

            chart.ShowLegend = false;

            #endregion
        }
    }
}
