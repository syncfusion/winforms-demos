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

namespace ChartMultiLevelLabel_2005
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
            chart.PrimaryXAxis.LabelPlacement = ChartAxisLabelPlacement.BetweenTicks;
            chart.PrimaryXAxis.DrawTickLabelGrid = true;
            chart.PrimaryYAxis.DrawTickLabelGrid = true;
            chart.PrimaryXAxis.ValueType = ChartValueType.Category;            

            ChartAxisGroupingLabel xAxisgroupingLabel = new ChartAxisGroupingLabel(new DoubleRange(-0.5, 2.5), "Quarter1");
            xAxisgroupingLabel.Row = 1;

            ChartAxisGroupingLabel xAxisgroupingLabel1 = new ChartAxisGroupingLabel(new DoubleRange(2.5, 5.5), "Quarter2");
            xAxisgroupingLabel1.Row = 1;

            ChartAxisGroupingLabel xAxisgroupingLabel2 = new ChartAxisGroupingLabel(new DoubleRange(5.5, 8.5), "Quarter3");
            xAxisgroupingLabel2.Row = 1;

            ChartAxisGroupingLabel xAxisgroupingLabel3 = new ChartAxisGroupingLabel(new DoubleRange(8.5, 11.5), "Quarter4");
            xAxisgroupingLabel3.Row = 1;

            ChartAxisGroupingLabel xAxisgroupingLabel4 = new ChartAxisGroupingLabel(new DoubleRange(-0.5, 5.5), "Half Yearly 1");
            xAxisgroupingLabel4.Row = 2;

            ChartAxisGroupingLabel xAxisgroupingLabel5 = new ChartAxisGroupingLabel(new DoubleRange(5.5, 11.5), "Half Yearly 2");
            xAxisgroupingLabel5.Row = 2;

            ChartAxisGroupingLabel xAxisgroupingLabel6 = new ChartAxisGroupingLabel(new DoubleRange(-0.5, 11.5), "2015");
            xAxisgroupingLabel6.Row = 3;

            chart.PrimaryXAxis.GroupingLabels.Add(xAxisgroupingLabel);
            chart.PrimaryXAxis.GroupingLabels.Add(xAxisgroupingLabel1);
            chart.PrimaryXAxis.GroupingLabels.Add(xAxisgroupingLabel2);
            chart.PrimaryXAxis.GroupingLabels.Add(xAxisgroupingLabel3);
            chart.PrimaryXAxis.GroupingLabels.Add(xAxisgroupingLabel4);
            chart.PrimaryXAxis.GroupingLabels.Add(xAxisgroupingLabel5);
            chart.PrimaryXAxis.GroupingLabels.Add(xAxisgroupingLabel6);

            ChartAxisGroupingLabel yAxisgroupingLabel = new ChartAxisGroupingLabel(new DoubleRange(0, 13), "Low");

            ChartAxisGroupingLabel yAxisgroupingLabel1 = new ChartAxisGroupingLabel(new DoubleRange(13, 26), "Medium");

            ChartAxisGroupingLabel yAxisgroupingLabel2 = new ChartAxisGroupingLabel(new DoubleRange(26, 40), "High");

            chart.PrimaryYAxis.GroupingLabels.Add(yAxisgroupingLabel);
            chart.PrimaryYAxis.GroupingLabels.Add(yAxisgroupingLabel1);
            chart.PrimaryYAxis.GroupingLabels.Add(yAxisgroupingLabel2);

            chart.ElementsSpacing = 0;

            #endregion
        }
    }
}
