using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace MultipleAxesLayout
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            #region ApplyCustomPalette

            chart.Skins = Skins.Metro;

            #endregion

            #region Chart Appearance Customization

            chart.PrimaryYAxis.TitleFont = new Font("Segoe UI", 12F);
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = true;

            #endregion

            #region Legend Customization

            for (int i = 0; i < chart.Legend.Items.Length; i++)
            {
                chart.Legend.RepresentationType = ChartLegendRepresentationType.Rectangle;
                chart.Legend.Items[i].Spacing = 2;
                chart.Legend.ItemsSize = new Size(13, 13);
                chart.Legend.Items[i].TextAligment = VerticalAlignment.Bottom;
                chart.LegendsPlacement = ChartPlacement.Outside;
                chart.LegendAlignment = ChartAlignment.Center;
                chart.LegendPosition = ChartDock.Bottom;
                chart.Legend.Font = new Font("Segoe UI", 10f);
            }
            #endregion
        }
    }
}
