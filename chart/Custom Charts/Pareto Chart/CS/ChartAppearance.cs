#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
