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
            #region ApplyCustomPalette
            chart.Skins = Skins.Metro;
            #endregion

            #region Chart Appearance Customization


            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.None;
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;           
            chart.ElementsSpacing = 0;

            #endregion

            

            #region Legend Customization

            chart.Legend.RepresentationType = ChartLegendRepresentationType.SeriesType;
            chart.LegendPosition = ChartDock.Bottom;
            chart.LegendsPlacement = ChartPlacement.Outside;
            chart.LegendAlignment = ChartAlignment.Near;
            chart.Legend.Visible = false;

            #endregion
        }
    }
}
