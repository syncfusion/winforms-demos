using System;
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
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            chart.ElementsSpacing = 5;

            #endregion

            #region Axes Customization

            chart.PrimaryXAxis.HidePartialLabels = true;
            chart.PrimaryYAxis.HidePartialLabels = true;
           
            chart.Legend.Visible = false;        
            chart.ShowToolTips = true;
            chart.Series3D = true;          
          
            chart.Text = "Chart Data From XML";
			chart.PrimaryXAxis.Title = "Date";
            chart.PrimaryYAxis.Title = "Quantity";
            chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryYAxis.Range = new MinMaxInfo(0, 70, 20);
            chart.Indexed = true;
            #endregion
        }
    }
}
