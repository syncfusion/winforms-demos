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
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            chart.ElementsSpacing = 0;

            #endregion

            #region Axes Customization
            chart.ColumnWidthMode = ChartColumnWidthMode.FixedWidthMode;
            chart.ColumnFixedWidth = 30;
            chart.Series[0].ConfigItems.ColumnItem.CornerRadius = new SizeF(7, 7);
            chart.Titles[0].Font = new Font("Segoe UI", 12, FontStyle.Regular);
            chart.Text="Daily performance";
            chart.PrimaryXAxis.Title="Day";
            chart.PrimaryYAxis.Title="Task finished(%)"; 
            chart.PrimaryYAxis.Range.Min = 0;
            chart.PrimaryYAxis.Range.Max = 100;        
            #endregion

            #region Legend Customization

            chart.ShowLegend = false;

            #endregion
        }
    }
}
