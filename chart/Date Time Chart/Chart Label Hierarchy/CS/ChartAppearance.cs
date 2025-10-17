#region Copyright Syncfusion Inc. 2001 - 2011
// Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
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

namespace ChartLabelHierarchy
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            #region ApplyCustomPalette
            chart.Skins = Skins.Metro;
            #endregion

            #region chart appearance customization
            chart.ShowLegend = false;
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.None;           
            chart.BorderAppearance.FrameThickness = new ChartThickness(-2, -2, 2, 2);
            chart.PrimaryXAxis.DrawGrid = false;
            #endregion

            #region Chart axes customization
            chart.PrimaryXAxis.TickSize = new System.Drawing.Size(1, 5);
            chart.PrimaryYAxis.TickSize = new System.Drawing.Size(5, 1);
            chart.LegendsPlacement = ChartPlacement.Outside;
            #endregion

            #region Legend Customization
            //Adds Custom legend to chart control
            ChartLegend legend1 = new ChartLegend(chart);
            legend1.Name = "legend1";
            legend1.RepresentationType = ChartLegendRepresentationType.None;
            legend1.Position = ChartDock.Bottom;
            legend1.Alignment = ChartAlignment.Center;
            ChartLegendItem[] customItems = new ChartLegendItem[0];
            ChartLegendItemsCollection clic = new ChartLegendItemsCollection();
            ChartLegendItem cli1 = new ChartLegendItem("Press Esc to Cancel Zooming");
            clic.Add(cli1);
            legend1.CustomItems = clic.ToArray();
            chart.Legends.Add(legend1);
            #endregion
        }
    }
}
