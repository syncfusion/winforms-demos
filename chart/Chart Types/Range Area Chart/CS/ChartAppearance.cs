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

namespace RangeAreaChart_Sample
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
            chart.PrimaryXAxis.DrawGrid = false;
            chart.PrimaryYAxis.DrawGrid = false;
            chart.ElementsSpacing = 0;
            chart.PrimaryXAxis.GridLineType.ForeColor = Color.Transparent;
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.Transparent;
           
           
           chart.ShowToolTips = true;
           
            #endregion

            #region Legend Customization

            chart.Legend.RepresentationType = ChartLegendRepresentationType.SeriesType;
            chart.LegendPosition = ChartDock.Bottom;
            chart.LegendsPlacement = ChartPlacement.Outside;
            chart.LegendAlignment = ChartAlignment.Center;
            chart.ShowLegend = false;  
            chart.EnableMouseRotation = true;

            ChartCustomPoint ccp = new ChartCustomPoint();
            ccp.XValue = chart.Series[1].Points[40].X;
            ccp.YValue = chart.Series[1].Points[40].YValues[1];
            ccp.CustomType = ChartCustomPointType.ChartCoordinates;
            ccp.Text = "Upper Band";           
            ccp.Symbol.Shape = ChartSymbolShape.Circle;
            ccp.Symbol.Color = Color.White;            
            ccp.Symbol.Size = new Size(12, 12);
            ccp.Alignment = ChartTextOrientation.RegionUp;
          
            ccp.Color = Color.Black;
            ccp.Font.Facename = "Segoe UI";
            ccp.Font.Size = 10f;
            chart.CustomPoints.Add(ccp);

            ChartCustomPoint ccp1 = new ChartCustomPoint();
            ccp1.XValue = chart.Series[1].Points[40].X;
            ccp1.YValue = chart.Series[1].Points[40].YValues[0];
            ccp1.CustomType = ChartCustomPointType.ChartCoordinates;
            ccp1.Text = "Lower Band";
            ccp1.Symbol.Shape = ChartSymbolShape.Circle;
            ccp1.Symbol.Color = Color.White;
            ccp1.Images = new ChartImageCollection();
            ccp1.Symbol.Size = new Size(12, 12);
            ccp1.Alignment = ChartTextOrientation.RegionDown;
            ccp1.Color = Color.Black;
            ccp1.Font.Facename = "Segoe UI";
            ccp1.Font.Size = 10f;
            chart.CustomPoints.Add(ccp1);
            #endregion
        }
    }
}
