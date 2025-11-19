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
using System.Drawing.Drawing2D;

namespace ChartPoints_2005
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
            chart.ElementsSpacing = 2;

            #endregion

            #region Axes and Legend Customization

          
            chart.LegendsPlacement = ChartPlacement.Outside;
            chart.Legend.Position = ChartDock.Bottom;
            chart.LegendAlignment = ChartAlignment.Center;

            for (int i = 0; i < chart.Legend.Items.Length; i++)
            {

                chart.Legend.Items[i].TextAligment = VerticalAlignment.Center;
                chart.Legend.ItemsSize = new Size(30, 30);
            }

            chart.Legend.Font = new Font("Segoe UI", 10f);
            chart.Legend.RepresentationType = ChartLegendRepresentationType.None;
            chart.Legend.ShowSymbol = true;
            chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryYAxis.Range = new MinMaxInfo(0, 700, 100);
            chart.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryXAxis.Range = new MinMaxInfo(1996, 2008, 1);
            chart.PrimaryXAxis.LabelRotate = true;
            chart.PrimaryXAxis.LabelRotateAngle = 270;        
            chart.Text = "World Production of Wheat, Corn and Rice";
            
            chart.PrimaryXAxis.Title = "Year";
            chart.PrimaryYAxis.Title = "Production (Million tonnes)";          

            #endregion
        }
    }
}
