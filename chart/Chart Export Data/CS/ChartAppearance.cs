#region Copyright Syncfusion Inc. 2001 - 2014
// Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
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

namespace ChartExportData
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            #region ApplyCustomPalette

            chart.Skins = Skins.Metro;

            #endregion

            #region Chart Appearance Customization

           chart.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            chart.ElementsSpacing = 0;

            #endregion

            #region Axes Customization

             chart.PrimaryXAxis.DrawGrid = false;
            chart.PrimaryYAxis.Range.Min = 0;

            chart.Text = "Product orders count by age group";
            chart.PrimaryXAxis.Title = "Age";
            chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryYAxis.Range = new MinMaxInfo(0, 6000, 1000);
            chart.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryXAxis.Range = new MinMaxInfo(0, 10, 1);
            chart.Series[0].Style.Border.Width = 2;
            chart.Series[0].Style.Symbol.Shape = ChartSymbolShape.Circle;

            for (int i = 0; i < 2; i++)
            {
                chart.Series[0].Styles[i].Interior = new BrushInfo(Color.Green);
                chart.Series[0].Styles[i].Symbol.Color = Color.White;
                chart.Series[0].Styles[i].Symbol.Border.Color = Color.Green;
                chart.Series[0].Styles[i].Symbol.Border.Width = 2;
            }
            for (int i = 2; i < chart.Series[0].Points.Count; i++)
            {
                chart.Series[0].Styles[i].Interior = new BrushInfo(Color.FromArgb(199, 23, 33));
                chart.Series[0].Styles[i].Symbol.Color = Color.White;
                chart.Series[0].Styles[i].Symbol.Border.Color = Color.FromArgb(199, 23, 33);
                chart.Series[0].Styles[i].Symbol.Border.Width = 2;
            }                

            
            #endregion

            #region Legend Customization
            for (int i = 0; i < chart.Legend.Items.Length; i++)
            {
                chart.Legend.Items[i].Spacing = 2;
                chart.Legend.ItemsSize = new Size(13, 13);
                chart.Legend.Items[i].TextAligment = VerticalAlignment.Bottom;
                chart.Legend.BackColor = Color.Transparent;
                chart.LegendsPlacement = ChartPlacement.Outside;
                chart.LegendAlignment = ChartAlignment.Center;
                chart.LegendPosition = ChartDock.Bottom;
                chart.Legend.Font = new Font("Segoe UI", 10.25f);
            }
            chart.Legend.Items[0].Visible = false;
            #endregion
        }
    }
}
