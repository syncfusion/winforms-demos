using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace DateDataBinding
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
           
            #endregion

            #region Axes Customization
            chart.PrimaryXAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            chart.PrimaryYAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            chart.Text = "Product Review";
            chart.PrimaryXAxis.Title = "Expiry Date";
            chart.PrimaryYAxis.Title = "Quantity";
            chart.Legend.Visible = false;
            chart.PrimaryXAxis.ValueType = ChartValueType.DateTime;
            chart.PrimaryXAxis.DateTimeFormat = "MM/dd/yy";      
            chart.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.MultipleRows;
            chart.PrimaryXAxis.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.Shift;
            #endregion
        }
    }
}
