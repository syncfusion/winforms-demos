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
            chart.PrimaryXAxis.LabelRotate = true;
            chart.PrimaryXAxis.LabelRotateAngle = 90;             
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            //Turns off the legend.
            chart.ShowLegend = false;
            chart.PrimaryYAxis.Title = "Y Values";
            chart.PrimaryXAxis.Title = "X Values";                               
            chart.ChartAreaMargins = new ChartMargins(10, 4, 10, 1);
            chart.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            chart.PrimaryXAxis.HidePartialLabels = true;
            chart.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.MultipleRows;

            #endregion
        }
    }
}
