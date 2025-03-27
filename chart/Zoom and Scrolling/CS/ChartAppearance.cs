#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace KeyAndMouseZoomingSample
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {

            #region chart Skin
            chart.Skins = Skins.Metro;
            #endregion

            #region Chart Appearance Customization
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.None;
            chart.BorderAppearance.BaseColor = Color.DarkOliveGreen;
            chart.BorderAppearance.FrameThickness = new ChartThickness(-2, -2, 2, 2);
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            chart.ElementsSpacing = 5;

            #endregion

            #region Axes Customization

            chart.PrimaryXAxis.HidePartialLabels = true;
            chart.PrimaryYAxis.HidePartialLabels = true;
             chart.Zooming.ShowBorder = true;
            chart.Zooming.Opacity = 0.6f;
            chart.GetVScrollBar(chart.PrimaryYAxis).ZoomButton.Size = new Size(0, 0);
            chart.GetHScrollBar(chart.PrimaryXAxis).ZoomButton.Size = new Size(0, 0);
            chart.EnableXZooming = true;
            chart.EnableYZooming = true;
            chart.ZoomFactorX = 1;
            chart.ZoomFactorX = 1;
            chart.ShowScrollBars = true;
            chart.ResetOnDoubleClick = true;
            chart.ZoomType = ZoomType.Selection | ZoomType.PinchZooming;
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			chart.PrimaryXAxis.Title = "Year";
			chart.PrimaryYAxis.Title = "Temperature";
            chart.PrimaryXAxis.Range = new Syncfusion.Windows.Forms.Chart.MinMaxInfo(1850, 2007, 40);
            chart.PrimaryXAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set;
            chart.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.MultipleRows;
            chart.PrimaryXAxis.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.Shift;

            #endregion

            #region Legend Customization
            for (int i = 0; i < chart.Legend.Items.Length; i++)
            {
                chart.Legend.Items[i].Spacing = 4;
                chart.Legend.ItemsSize = new Size(13, 13);
                chart.Legend.Items[i].TextAligment = VerticalAlignment.Bottom;
                chart.Legend.BackColor = Color.Transparent;
                chart.LegendsPlacement = ChartPlacement.Outside;
                chart.LegendAlignment = ChartAlignment.Center;
                chart.LegendPosition = ChartDock.Bottom;
                chart.Legend.Font = new Font("Segoe UI", 10.25f);
            }

            //Adds Custom legend to chart control

            ChartLegendItem[] customItems = new ChartLegendItem[0];
            ChartLegendItemsCollection clic = new ChartLegendItemsCollection();
            ChartLegendItem cli1 = new ChartLegendItem("Press Esc to Cancel Zooming");
            clic.Add(cli1);

            
            #endregion
        }
    }
}
