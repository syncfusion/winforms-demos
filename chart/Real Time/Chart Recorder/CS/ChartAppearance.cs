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

            chart.ElementsSpacing = 0;                        
            chart.PrimaryXAxis.SmallTicksPerInterval = 2;
            chart.PrimaryXAxis.DrawMinorGrid = true;
            chart.PrimaryXAxis.DrawGrid = false;
            chart.PrimaryYAxis.DrawGrid = false;
            chart.PrimaryYAxis.SmallTicksPerInterval = 3;
            chart.PrimaryYAxis.DrawMinorGrid = true;
            chart.PrimaryXAxis.MinorGridLineType.DashStyle = DashStyle.Dot;
            chart.PrimaryYAxis.MinorGridLineType.DashStyle = DashStyle.Dot;       
            
            chart.PrimaryXAxis.LabelRotate = true;
            chart.PrimaryXAxis.LabelRotateAngle = 270;   
            chart.Legend.Visible = false;
            chart.PrimaryYAxis.Title = "Memory Usage (MB)";
            chart.PrimaryXAxis.Title = "Time";
            chart.Text = "Memory Usage History";
            

            #endregion
        }
    }
}
