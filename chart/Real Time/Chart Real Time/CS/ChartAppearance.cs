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

namespace Syncfusion.Windows.Forms.Chart.Samples
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
            #endregion

            #region Axes and Legend Customization
         
        
            chart.PrimaryXAxis.SmallTicksPerInterval = 2;
            chart.PrimaryXAxis.DrawMinorGrid = true;
            chart.PrimaryXAxis.DrawGrid = false;
            chart.PrimaryYAxis.DrawGrid = false;
            chart.PrimaryXAxis.MinorGridLineType.ForeColor = Color.LightGreen;
            chart.PrimaryYAxis.SmallTicksPerInterval = 3;
            chart.PrimaryYAxis.DrawMinorGrid = true;
            chart.PrimaryYAxis.MinorGridLineType.ForeColor = Color.LightGreen;
            chart.PrimaryXAxis.MinorGridLineType.DashStyle = DashStyle.Dot;
            chart.PrimaryYAxis.MinorGridLineType.DashStyle = DashStyle.Dot;            
           
            chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryYAxis.Range.Min = 0;
            chart.PrimaryYAxis.Range.Max = 60;
            chart.PrimaryYAxis.Range.Interval = 10;
            chart.Text = "Network Load";
            chart.PrimaryYAxis.Title = "Server Load (MBytes)";
            chart.PrimaryXAxis.Title = "Date";       
            chart.PrimaryXAxis.LabelRotate = true;
            chart.PrimaryXAxis.LabelRotateAngle = 270;  
            chart.Series[0].Style.Border.Width = 2;

            #endregion
        }
    }
}
