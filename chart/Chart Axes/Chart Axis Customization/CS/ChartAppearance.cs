using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace ChartAxisCustomization_2005
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

            chart.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryXAxis.Range = new MinMaxInfo(0, 4, 1);
            chart.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            chart.PrimaryXAxis.SmallTicksPerInterval = 4;
            chart.PrimaryYAxis.SmallTicksPerInterval = 4;
            #endregion

            #region Legen Customization
            chart.ShowLegend = false;
            #endregion
        }
    }
}
