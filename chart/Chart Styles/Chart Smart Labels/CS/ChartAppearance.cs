using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ChartSmartLabel_2005
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

            chart.PrimaryYAxis.Range = new MinMaxInfo(0, 40, 10);
            chart.PrimaryXAxis.Range = new MinMaxInfo(20, 60, 10);
            chart.PrimaryXAxis.TitleColor = Color.Black;
            chart.PrimaryYAxis.TitleColor = Color.Black;
            chart.PrimaryXAxis.Title = "Pressure";
            chart.PrimaryYAxis.Title = "Temperature(Celsius)";
            chart.Text = "Reaction Path";
            chart.Legend.RepresentationType = ChartLegendRepresentationType.None;
            chart.LegendPosition = ChartDock.Bottom;
            chart.LegendsPlacement = ChartPlacement.Outside;
            chart.LegendAlignment = ChartAlignment.Center;


            #endregion
        }
    }
}
