#region Copyright Syncfusion Inc. 2001 - 2023
// Copyright Syncfusion Inc. 2001 - 2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace Syncfusion.Windows.Forms.Chart.Samples
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            #region ApplyCustomPalette
            chart.Palette = ChartColorPalette.Custom;
           
            chart.CustomPalette = new System.Drawing.Color[] 
            {  
                
                
                 Color.FromArgb(12,189,244),
                Color.FromArgb(162,206,54),
                Color.FromArgb(249,65,104),
               

                Color.FromArgb(119,119,247),
                Color.FromArgb(239,187,20),
                Color.FromArgb(244,127,49),
                Color.FromArgb(217,0,115)              
            };

            #endregion

            #region Chart Appearance Customization

            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            chart.ElementsSpacing = 0;
            chart.Series[0].Style.TextColor = Color.Gray;
            chart.Series[0].Style.Font.Facename = "Sego UI";
            chart.Series[0].Style.Font.Size = 10f;
            chart.Series[0].Style.Border.Color = Color.Empty;
            chart.Series[0].ConfigItems.PieItem.FillMode = ChartPieFillMode.AllPie;
            chart.Series[0].ConfigItems.PieItem.HeightByAreaDepth = false;
            chart.Series[0].ConfigItems.PieItem.HeightCoeficient = 0.1f;
            
            #endregion
        }
    }
}
