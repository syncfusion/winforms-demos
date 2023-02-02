#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
# region  Directives
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;

using Queries = PortfolioManager.LINQqueries;
#endregion

namespace PortfolioManager.Analyzer
{
    public partial class Contribution : UserControl
    {
        # region Variable Declaration
        ContributionsChart contribution;
        Color[] color1 = new Color[] { Color.FromArgb(173, 93, 156), Color.FromArgb(156, 81, 148), Color.FromArgb(181, 113, 173), Color.FromArgb(206, 146, 189), Color.FromArgb(214, 154, 206), Color.FromArgb(222, 186, 222), Color.FromArgb(247, 239, 247) };
        Color[] color2 = new Color[] { Color.FromArgb(214, 109, 165), Color.FromArgb(214, 109, 165), Color.FromArgb(231, 125, 173), Color.FromArgb(231, 125, 181), Color.FromArgb(239, 166, 206), Color.FromArgb(255, 227, 239) };
        Color[] color3 = new Color[] { Color.FromArgb(189, 32, 41), Color.FromArgb(173, 28, 49), Color.FromArgb(214, 60, 66), Color.FromArgb(222, 97, 99), Color.FromArgb(231, 117, 123), Color.FromArgb(231, 130, 132), Color.FromArgb(239, 146, 156), Color.FromArgb(247, 186, 189), Color.FromArgb(247, 211, 214) };
        Color[] color4 = new Color[] { Color.FromArgb(115, 207, 231), Color.FromArgb(74, 182, 214), Color.FromArgb(123, 207, 231), Color.FromArgb(156, 215, 231), Color.FromArgb(181, 219, 231), Color.FromArgb(231, 243, 247) };
        Color[] color5 = new Color[] { Color.FromArgb(239, 211, 24), Color.FromArgb(231, 199, 33), Color.FromArgb(247, 215, 16), Color.FromArgb(247, 219, 57), Color.FromArgb(255, 227, 115), Color.FromArgb(255, 239, 173), Color.FromArgb(255, 247, 214) };
        Color[] color6 = new Color[] { Color.FromArgb(82, 182, 231), Color.FromArgb(24, 146, 189), Color.FromArgb(74, 178, 222), Color.FromArgb(90, 190, 231), Color.FromArgb(107, 195, 239), Color.FromArgb(123, 203, 231), Color.FromArgb(140, 207, 239), Color.FromArgb(198, 231, 247), Color.FromArgb(239, 251, 255) };
        Color[] color7 = new Color[] { Color.FromArgb(123, 182, 74), Color.FromArgb(107, 158, 66), Color.FromArgb(132, 182, 74), Color.FromArgb(148, 190, 66), Color.FromArgb(156, 190, 57), Color.FromArgb(206, 223, 148), Color.FromArgb(231, 239, 206) };
        int accountID = 1;
        #endregion

        # region Method
        public Contribution()
        {

            InitializeComponent();

            InitializeAccountsChart();

            this.contribution = new ContributionsChart(this.contributionChart, 1, ContributionsChartType.Sector);
            this.sectorRadioButton.Checked = true; 
        }

        public void InitializeAccountsChart()
        {
            //Events
            this.accountsChart.ChartRegionClick += new ChartRegionMouseEventHandler(accountsChart_ChartRegionClick);

            this.accountsChart.Series.Clear();
            ChartSeries series = new ChartSeries("AssetBalance");
            series.Type = ChartSeriesType.Column;

            //Clear the Labels.
            this.accountsChart.PrimaryXAxis.Labels.Clear();
            this.accountsChart.PrimaryXAxis.Labels.Add(new ChartAxisLabel(""));

            int pointIndex = 0;
            foreach (Queries.AcountNameAndValue value in Queries.GetAcountNameAndValue())
            {
                series.Points.Add(new ChartPoint(pointIndex + 1, Convert.ToDouble(value.AssetValue)));
                Console.WriteLine(value.AccountName);
                this.accountsChart.PrimaryXAxis.Labels.Add(new ChartAxisLabel(value.AccountName, series.Points[pointIndex].YValues[0]));
                pointIndex++;
            }

            //Customizing axis            
            accountsChart.PrimaryXAxis.ValueType = ChartValueType.Custom;

            //Add series to Chart
            this.accountsChart.Series.Add(series);

            accountsChart.PrimaryXAxis.LabelAlignment = StringAlignment.Center;
            accountsChart.PrimaryXAxis.ValueType = ChartValueType.Custom;
            this.accountsChart.ColumnDrawMode = ChartColumnDrawMode.ClusteredMode;

            this.accountsChart.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.None;
            this.accountsChart.PrimaryXAxis.LabelRotate = true;
            accountsChart.PrimaryXAxis.LabelRotateAngle = 90;
            this.accountsChart.PrimaryXAxis.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.ClippingProtection;  // shifts the Label to minimum distance required to display the label fully.
            this.accountsChart.PrimaryXAxis.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.Shift;
            this.accountsChart.Titles[0].Text = "AssetValues by Portfolios";
            this.accountsChart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            this.accountsChart.PrimaryXAxis.HidePartialLabels = false;
            this.accountsChart.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            this.accountsChart.PrimaryXAxis.Range = new Syncfusion.Windows.Forms.Chart.MinMaxInfo(0, 8, 1);
            this.accountsChart.Series[0].PrepareStyle += new ChartPrepareStyleInfoHandler(Contribution_PrepareStyle);
            
        }
    
        void Contribution_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
        {
            ChartSeries series = sender as ChartSeries;
            if (series != null)
            {
                if (args.Index == 3)
                {
                    args.Style.Interior = new BrushInfo(GradientStyle.Horizontal, color7);
                    args.Style.Border.Color = Color.FromArgb(198, 215, 107);
                }
                else if (args.Index == 1)
                {
                    args.Style.Interior = new BrushInfo(GradientStyle.Horizontal, color3);
                    args.Style.Border.Color = Color.FromArgb(255, 219, 222);
                }
                else if (args.Index == 0)
                {
                    args.Style.Interior = new BrushInfo(GradientStyle.Horizontal, color4);
                    args.Style.Border.Color = Color.FromArgb(206, 239, 247);
                }
                else if (args.Index == 6)
                {
                    args.Style.Interior = new BrushInfo(GradientStyle.Horizontal, color5);
                    args.Style.Border.Color = Color.FromArgb(255, 235, 148);
                }
                else if (args.Index == 5)
                {
                    args.Style.Interior = new BrushInfo(GradientStyle.Horizontal, color6);
                    args.Style.Border.Color = Color.FromArgb(222, 243, 255);
                }
                else if (args.Index == 2)
                {
                    args.Style.Interior = new BrushInfo(GradientStyle.Horizontal, color1);
                    args.Style.Border.Color = Color.FromArgb(247, 219, 239);
                }
                else
                {
                    args.Style.Interior = new BrushInfo(GradientStyle.Horizontal, color2);
                    args.Style.Border.Color = Color.FromArgb(247, 203, 231);
                }
            }
        }       

        void accountsChart_ChartRegionClick(object sender, ChartRegionMouseEventArgs e)
        {
            if (e.Region.IsChartPoint)
            {
                this.accountID = e.Region.PointIndex + 1;
                this.contribution.AccountID = accountID;
            }
        }

        private void InitializeControlSettings()
        {
            this.accountsChart.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(232, 246, 254), System.Drawing.Color.LightSkyBlue);
            this.accountsChart.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.accountsChart.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.accountsChart.PrimaryXAxis.DrawGrid = false;
            this.accountsChart.ShowLegend = false;
        }
        #endregion

        # region Event Handler

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //By Sector
            if (this.sectorRadioButton.Checked)
                this.contribution.Type = ContributionsChartType.Sector;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //By StockExchanges
            if (this.countryRadioButton.Checked)
                this.contribution.Type = ContributionsChartType.StockExchange;
        }
        #endregion
    }
}
