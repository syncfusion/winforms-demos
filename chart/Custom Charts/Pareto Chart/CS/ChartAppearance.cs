using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace Pareto
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            chart.Skins = Skins.Metro;
            chart.ShowLegend = false;
            
            chart.PrimaryXAxis.DrawGrid = false;
           
            chart.PrimaryXAxis.TickSize = new System.Drawing.Size(1, 5);
            chart.PrimaryYAxis.TickSize = new System.Drawing.Size(5, 1);
        }
    }
}
