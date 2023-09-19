#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
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
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
#endregion

namespace PortfolioManager.Analyzer
{
    #region Enum
    public enum ChartPeriod
    {
        Last3Months = 1,

        Last6Months = 2,

        LastYear = 3
    }
    #endregion

    #region HelperClass
    public class PerformanceChart
    {
        # region Variable Declaration
        ChartControl chart;
        ChartPeriod period;
        List<string> accountNames = new List<string>();
        public static DateTime MonthsMax = DateTime.Parse("12/19/2008");
        public static DateTime MonthsMin = DateTime.Parse("12/27/2007");
        public static DateTime ThreeMonthsCutOff = DateTime.Parse("10/02/2008");
        public static DateTime SixMonthsCutOff = DateTime.Parse("07/02/2008");

        public static Dictionary<string, List<LINQqueries.DateAssetValue>> namesValuesDictionary;

        Color[] color1 = new Color[] { Color.FromArgb(198, 142, 198), Color.FromArgb(189, 113, 173), Color.FromArgb(173, 93, 156) };
        Color[] color2 = new Color[] { Color.FromArgb(239, 223, 132), Color.FromArgb(247, 227, 90), Color.FromArgb(247, 215, 8) };
        Color[] color3 = new Color[] { Color.FromArgb(214, 219, 132), Color.FromArgb(181, 195, 49), Color.FromArgb(165, 182, 0) };
        #endregion

        # region Method
        public PerformanceChart(ChartControl Chart, ChartPeriod Period)
        {
            this.chart = Chart;
            this.period = Period;

            InitializeChartSettings();
        }

        public ChartPeriod Period
        {
            get
            {
                return period;
            }
            set
            {
                period = value;
                RefreshChartSeries();
                UpdateChartLabels();
            }
        }

        void RefreshChartSeries()
        {
            foreach (string Name in accountNames)
                AddSeriesToChart(Name, Period);
        }

        void UpdateChartLabels()
        {
            switch (Period)
            {
                case ChartPeriod.Last3Months:
                    UpdateChartLabels(ChartDateTimeIntervalType.Weeks, ThreeMonthsCutOff.AddDays(1), MonthsMax, "MM/dd");
                    break;

                case ChartPeriod.Last6Months:
                    UpdateChartLabels(ChartDateTimeIntervalType.Months, SixMonthsCutOff.AddDays(1), MonthsMax, "MMM");
                    break;

                case ChartPeriod.LastYear:
                    UpdateChartLabels(ChartDateTimeIntervalType.Months, MonthsMin.AddDays(1), MonthsMax, "MMM");
                    break;

                default:
                    break;
            }
        }

        void UpdateChartLabels(ChartDateTimeIntervalType intervalType, DateTime originDate, DateTime endDate, string format)
        {
            chart.PrimaryXAxis.IntervalType = intervalType;
            chart.PrimaryXAxis.OriginDate = originDate;
            chart.PrimaryXAxis.DateTimeInterval.OffsetType = intervalType;
            chart.PrimaryXAxis.DateTimeFormat = format;
            chart.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(originDate, endDate, 1, intervalType);
        }

        void InitializeChartSettings()
        {
            chart.Series.Clear();

            //Other settings
            chart.PrimaryXAxis.LabelAlignment = StringAlignment.Center;
            this.chart.ColumnDrawMode = ChartColumnDrawMode.ClusteredMode;
            this.chart.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.None;
            this.chart.PrimaryXAxis.LabelRotate = true;
            chart.PrimaryXAxis.LabelRotateAngle = 90;
            this.chart.PrimaryXAxis.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.ClippingProtection;  // shifts the Label to minimum distance required to display the label fully.
            this.chart.PrimaryXAxis.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.Shift;
            this.chart.Titles[0].Text = "Performance of Large Cap Portfolio Accounts";
            this.chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;

            //Customize X-axis (Initial settings)
            this.chart.PrimaryXAxis.ValueType = ChartValueType.DateTime;
            this.chart.PrimaryXAxis.DesiredIntervals = 12;
            this.chart.PrimaryXAxis.CustomOrigin = true;
            this.chart.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
        }

        public void AddAccount(string Name)
        {
            if (accountNames.Contains(Name))
            {
                //Find the ChartSeries and set the visibility
                chart.Series[Name].Visible = true;
            }
            else
            {
                //Create new series
                this.accountNames.Add(Name);
                this.AddSeriesToChart(Name, Period);
                UpdateChartLabels();
            }
            UpdateChartLookandFeel();
        }

        public void RemoveAccount(string Name)
        {
            if (accountNames.Contains(Name))
            {
                //Find the ChartSeries and set the visibility
                chart.Series[Name].Visible = false;
            }
        }       

        private void UpdateChartLookandFeel()
        {
            this.chart.Series[0].Style.Interior = new BrushInfo(GradientStyle.Vertical, color1);
            this.chart.Series[0].Style.Border.Color = Color.FromArgb(173, 77, 165);
            if (chart.Series.Count > 1)
            {
                this.chart.Series[1].Style.Interior = new BrushInfo(GradientStyle.Vertical, color2);
                this.chart.Series[1].Style.Border.Color = Color.FromArgb(173, 121, 90);
                if (chart.Series.Count > 2)
                {
                    this.chart.Series[2].Style.Interior = new BrushInfo(GradientStyle.Vertical, color3);
                    this.chart.Series[2].Style.Border.Color = Color.FromArgb(148, 158, 16);
                }
            }
        }       

        public static void LoadData(object state)
        {
            namesValuesDictionary = new Dictionary<string, List<LINQqueries.DateAssetValue>>();

            List<LINQqueries.DateAssetValue> AmericanFunds = new List<LINQqueries.DateAssetValue>();
            AmericanFunds = LINQqueries.GetDateAndAssetValue("AmericanFunds", MonthsMin, MonthsMax);
            namesValuesDictionary.Add("AmericanFunds", AmericanFunds);

            List<LINQqueries.DateAssetValue> SchwabFunds = new List<LINQqueries.DateAssetValue>();
            SchwabFunds = LINQqueries.GetDateAndAssetValue("SchwabFunds", MonthsMin, MonthsMax);
            namesValuesDictionary.Add("SchwabFunds", SchwabFunds);

            List<LINQqueries.DateAssetValue> VanguardFunds = new List<LINQqueries.DateAssetValue>();
            VanguardFunds = LINQqueries.GetDateAndAssetValue("VanguardFunds", MonthsMin, MonthsMax);
            namesValuesDictionary.Add("VanguardFunds", VanguardFunds);
        }

        List<LINQqueries.DateAssetValue> GetDateAndAssetValue(string AccoutName, DateTime MinDate, DateTime MaxDate)
        {
            Predicate<LINQqueries.DateAssetValue> filterValues = delegate(LINQqueries.DateAssetValue dateAssetValue)
            {
                return (dateAssetValue.Date > MinDate && MaxDate >= dateAssetValue.Date);
            };

            return namesValuesDictionary[AccoutName].FindAll(filterValues);
        }

        void AddSeriesToChart(string Name, ChartPeriod chartPeriod)
        {
            DateTime minDate = ThreeMonthsCutOff;
            DateTime maxDate = MonthsMax;

            switch (chartPeriod)
            {
                case ChartPeriod.Last3Months:
                    minDate = ThreeMonthsCutOff;
                    maxDate = MonthsMax;
                    break;

                case ChartPeriod.Last6Months:
                    minDate = SixMonthsCutOff;
                    maxDate = ThreeMonthsCutOff;
                    break;

                case ChartPeriod.LastYear:
                    minDate = MonthsMin;
                    maxDate = SixMonthsCutOff;
                    break;
            }

            bool seriesFound = false;

            for (int index = 0; index < this.chart.Series.Count; index++)
            {
                ChartSeries series = this.chart.Series[index];

                //Series already in the Chart
                if (series.Name == Name)
                {
                    seriesFound = true;

                    if (series.Points.Count < 50)
                    {
                        if (this.chart.Series[Name].Points.Count < 10)
                        {
                            if (chartPeriod == ChartPeriod.LastYear || chartPeriod == ChartPeriod.Last6Months)
                                AddSeriesToChart(Name, ChartPeriod.Last3Months);
                        }

                        if (this.chart.Series[Name].Points.Count < 20)
                        {
                            if (chartPeriod == ChartPeriod.LastYear)
                                AddSeriesToChart(Name, ChartPeriod.Last6Months);
                        }

                        //Don't do anything
                        if (chartPeriod == ChartPeriod.Last3Months && this.chart.Series[Name].Points.Count > 0)
                            return;

                        if (chartPeriod == ChartPeriod.Last6Months && this.chart.Series[Name].Points.Count > 20)
                            return;

                        this.chart.SuspendLayout();
                        this.chart.BeginUpdate();

                        foreach (LINQqueries.DateAssetValue value in GetDateAndAssetValue(Name, minDate, maxDate))
                            this.chart.Series[Name].Points.Add(new ChartPoint(value.Date, Convert.ToDouble(value.AssetValue)));

                        this.chart.EndUpdate();
                        this.chart.ResumeLayout();
                    }
                }
            }

            //Add a new series
            if (!seriesFound)
            {
                ChartSeries chartSeries = new ChartSeries(Name);
                chartSeries.Type = ChartSeriesType.SplineArea;

                this.chart.Series.Add(chartSeries);

                AddSeriesToChart(Name, chartPeriod);
            }
        }
        #endregion
    }
    #endregion
}