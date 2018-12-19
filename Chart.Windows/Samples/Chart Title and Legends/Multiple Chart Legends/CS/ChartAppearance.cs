using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace MultiplyLegendsSample
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            #region Skin 
            chart.Skins = Skins.Metro;
            #endregion
            
            #region Chart Appearance Customization

            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.None;
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            chart.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            chart.ChartAreaMargins = new ChartMargins(1, 5, 1, 1);
            chart.ElementsSpacing = 5;
            #endregion

            #region Legend Customization
             chart.LegendsPlacement = ChartPlacement.Outside;
             chart.LegendPosition = ChartDock.Top;
            chart.LegendAlignment = ChartAlignment.Center;

            #endregion
        }
    }
}
