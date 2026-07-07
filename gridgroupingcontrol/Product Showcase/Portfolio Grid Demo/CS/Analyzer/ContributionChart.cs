#region Copyright Syncfusion Inc. 2001 - 2015
// Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
# region Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Queries = PortfolioManager.LINQqueries;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
#endregion

namespace PortfolioManager.Analyzer
{
    #region "Enum"

    public enum ContributionsChartType
    {
        Sector = 1,
        StockExchange = 2
    }

    #endregion

    #region "Contribution Chart class"

    public class ContributionsChart
    {
        # region "API Definition"

        int accountID;
        ChartControl chart;
        ChartSeries contributionSeries;
        ContributionsChartType type = ContributionsChartType.Sector;
        List<Queries.SectorAndValue> SectorList = null;
        List<Queries.ExchangeAndValue> ExchangeList = null;
        Color[] color1 = new Color[] { Color.FromArgb(202, 149, 197), Color.FromArgb(180, 108, 168), Color.FromArgb(163, 69, 157) };
        Color[] color2 = new Color[] { Color.FromArgb(255, 215, 222), Color.FromArgb(255, 190, 222), Color.FromArgb(255, 215, 222) };
        Color[] color3 = new Color[] { Color.FromArgb(234, 147, 147), Color.FromArgb(216, 85, 97), Color.FromArgb(234, 147, 147) };
        Color[] color4 = new Color[] { Color.FromArgb(133, 208, 232), Color.FromArgb(96, 190, 227), Color.FromArgb(78, 163, 249) };
        Color[] color5 = new Color[] { Color.FromArgb(255, 235, 148), Color.FromArgb(247, 219, 33), Color.FromArgb(255, 235, 148) };
        Color[] color6 = new Color[] { Color.FromArgb(156, 160, 216), Color.FromArgb(183, 160, 216), Color.FromArgb(183, 160, 216) };
        Color[] color7 = new Color[] { Color.FromArgb(200, 209, 110), Color.FromArgb(166, 183, 2), Color.FromArgb(74, 118, 11) };
        Color[] color8 = new Color[] { Color.FromArgb(200, 209, 110), Color.FromArgb(166, 183, 2), Color.FromArgb(200, 209, 110) };
       
        #endregion

        # region "Constructor"

        public ContributionsChart(ChartControl Chart, int AccountID, ContributionsChartType Type)
        {
            this.chart = Chart;
            InitializeLookAndFeel();
            this.AccountID = AccountID;
            this.Type = Type;
        }

        #endregion

        #region "Customization Property and Methods"

        public int AccountID
        {
            get { return accountID; }
            set
            {
                if (value != AccountID)
                {
                    accountID = value;

                    if (SectorList != null)
                        SectorList.Clear();
                    if (ExchangeList != null)
                        ExchangeList.Clear();

                    this.RefreshChart();
                }
            }
        }

        public ContributionsChartType Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
                this.RefreshChart();
            }
        }

        void UpdateSectorExchangeLists()
        {
            switch (Type)
            {
                case ContributionsChartType.Sector:
                    SectorList = Queries.GetSectorNames(AccountID);
                    break;

                case ContributionsChartType.StockExchange:
                    ExchangeList = Queries.GetExchangeNamesAndValues(AccountID);
                    break;
            }
        }

        void InitializeLookAndFeel()
        {
            this.chart.Series.Clear();
            contributionSeries = new ChartSeries("Contributions", ChartSeriesType.Pie);

            this.chart.ShowLegend = false;

            //Set series properties
            contributionSeries.Style.DisplayText = true;
           // contributionSeries.ConfigItems.PieItem.PieType = ChartPieType.OutSide;
            //contributionSeries.ConfigItems.PieItem.FillMode = ChartPieFillMode.AllPie;
            //contributionSeries.ConfigItems.PieItem.HeightByAreaDepth = false;
           // contributionSeries.ConfigItems.PieItem.HeightCoeficient = 0.1f;
            
            this.chart.Series.Add(contributionSeries);

            chart.PrimaryXAxis.LabelAlignment = StringAlignment.Center;
            chart.PrimaryXAxis.ValueType = ChartValueType.Custom;

           // this.chart.ColumnDrawMode = ChartColumnDrawMode.ClusteredMode;
           // this.chart.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.None;
           // this.chart.PrimaryXAxis.LabelRotate = true;
           // chart.PrimaryXAxis.LabelRotateAngle = 90;
            //this.chart.PrimaryXAxis.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.ClippingProtection;  // shifts the Label to minimum distance required to display the label fully.
            //this.chart.PrimaryXAxis.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.Shift;
            //this.chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            this.chart.Series3D = false; ;
            //this.chart.Series[0].PrepareStyle += new ChartPrepareStyleInfoHandler(ContributionsChart_PrepareStyle);
            this.chart.Skins= Skins.Metro;
            Color[] palette = new Color[] {  Color.FromArgb(12,189,244),
                Color.FromArgb(162,206,54),
                Color.FromArgb(249,65,104),            

                Color.FromArgb(119,119,247),
                Color.FromArgb(239,187,20),
                Color.FromArgb(244,127,49),
                Color.FromArgb(217,0,115)   };
            for (int i = 0; i < palette.Length; i++)
                this.chart.Series[0].Styles[i].Interior = new Syncfusion.Drawing.BrushInfo(palette[i]);
        }       

        void ContributionsChart_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
        {
            ChartSeries series = sender as ChartSeries;
            if (series != null)
            {
                args.Style.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(134)))), ((int)(((byte)(173)))));
                if (args.Index == 0)
                {
                    //args.Style.Interior = new BrushInfo(Color.FromArgb(112, 173, 71));
                    args.Style.Border.Color = Color.FromArgb(74, 118, 11);
                }
                else if (args.Index == 1)
                {
                   // args.Style.Interior = new BrushInfo(Color.FromArgb(68, 114, 196));
                    args.Style.Border.Color = Color.FromArgb(216, 85, 97);
                }
                else if (args.Index == 2)
                {
                    //args.Style.Interior = new BrushInfo(Color.FromArgb(165, 165, 165));
                    args.Style.Border.Color = Color.FromArgb(78, 163, 249);
                }
                else if (args.Index == 3)
                {
                    //args.Style.Interior = new BrushInfo(Color.FromArgb(112, 173, 71));
                    args.Style.Border.Color = Color.FromArgb(255, 235, 148);
                }
                else if (args.Index == 4)
                {
                   // args.Style.Interior = new BrushInfo(Color.FromArgb(68, 114, 196));
                    args.Style.Border.Color = Color.FromArgb(183, 160, 216);
                }
                else if (args.Index == 5)
                {
                    //args.Style.Interior = new BrushInfo(Color.FromArgb(165, 165, 165));
                    args.Style.Border.Color = Color.FromArgb(166, 183, 2);
                }
                else if (args.Index == 6)
                {
                   // args.Style.Interior = new BrushInfo(Color.FromArgb(112, 173, 71));
                    args.Style.Border.Color = Color.FromArgb(163, 69, 157);
                }
                else
                {
                   // args.Style.Interior = new BrushInfo(Color.FromArgb(68, 114, 196));
                    args.Style.Border.Color = Color.FromArgb(255, 190, 222);
                }
            }
        }

        void RefreshChart()
        {
            this.contributionSeries.Points.Clear();

            switch (Type)
            {
                case ContributionsChartType.Sector:

                    if (SectorList == null || SectorList.Count == 0)
                        UpdateSectorExchangeLists();

                    foreach (Queries.SectorAndValue sector in SectorList)
                    {
                        int pointIndex = SectorList.IndexOf(sector);
                        contributionSeries.Points.Add(pointIndex + 1, Convert.ToDouble(sector.Value));
                        contributionSeries.Styles[pointIndex].Text = string.Format("{0} \n (${1})", sector.SectorName, contributionSeries.Points[pointIndex].YValues[0]);
                    }
                    this.chart.Titles[0].Text = "AssetValues by Sectors";
                    break;

                case ContributionsChartType.StockExchange:
                    if (ExchangeList == null || ExchangeList.Count == 0)
                        UpdateSectorExchangeLists();
                    foreach (Queries.ExchangeAndValue exchange in this.ExchangeList)
                    {
                        int pointIndex = ExchangeList.IndexOf(exchange);
                        contributionSeries.Points.Add(ExchangeList.IndexOf(exchange) + 1, Convert.ToDouble(exchange.Value));
                        contributionSeries.Styles[pointIndex].Text = string.Format("{0} \n (${1})", exchange.ExchangeName.Trim(), contributionSeries.Points[pointIndex].YValues[0]);
                    }
                    this.chart.Titles[0].Text = "AssetValues by StockExchange";                    
                    break;
            }
        }
        #endregion
    }

    #endregion
}
