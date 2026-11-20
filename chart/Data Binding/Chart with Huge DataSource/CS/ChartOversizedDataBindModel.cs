using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Grouping;
using System.Collections;
using System.Data;
using Syncfusion.Collections.BinaryTree;

namespace ChartImportData
{
    /// <summary>
    /// A custom model that can compress (group) a huge data source (with a lot of points) into something smaller that can be 
    /// displayed in a Chart. The compression is done by combining the values in a set of points into 1 (we use averaging here
    /// but can be changed to Max, etc.)
    /// This sample works only with indexed data or with evenly spaced data.
    /// </summary>
    class ChartOversizedDataBindModel : ChartBaseDataBindList, IChartSeriesModel
    {
        DataTable dataSource;
        // Grouping engine that groups a set of points togather finds their average and retunrs that average 
        // as the data point.
        Engine engine = new Engine();
        ChartControl chart;
        string xName, yName;
        int dilutionFactor = 1;
        double lastKnownZoomFactor = 1;

        public ChartOversizedDataBindModel(ChartControl chart, DataTable dataSource, string xName, string yName)
            : this(chart, dataSource, xName, yName, true)
        {
        }

        public ChartOversizedDataBindModel(ChartControl chart, DataTable dataSource, string xName, string yName, bool recaliberateOnZoom)
            : base(dataSource.DefaultView, String.Empty, null)
        {
            this.dataSource = dataSource;
            engine.SetSourceList((IEnumerable)dataSource.DefaultView);

            this.yName = yName;
            this.xName = xName;

            // Create a summary in the engine so that the averages, min and max are calculated for the groups (and the table).
            SummaryDescriptor sd = new SummaryDescriptor();
            sd.Name = "YAverage";
            sd.MappingName = yName;
            sd.SummaryType = SummaryType.DoubleAggregate;
            engine.TableDescriptor.Summaries.Add(sd);

            this.chart = chart;
            
            this.chart.Resize += new EventHandler(chart_RequiresRecalculation);
            

            this.UpdateCategorizer();
        }
        public void RangeChanged(double totalXValues)
        {
            if (this.lastKnownZoomFactor != this.chart.PrimaryXAxis.ZoomFactor && totalXValues == this.dataSource.Rows.Count)
                this.Recaliberate();
        }
        void chart_RequiresRecalculation(object sender, EventArgs e)
        {
            this.Recaliberate();   
        }

        public void Recaliberate()
        {
            this.UpdateCategorizer();
            // This is a bit of a hack to make the chart redraw the chart with the new set of points.
            this.chart.Series[0].SeriesModel = null;
            this.chart.Series[0].SeriesModel = this;
        }

        private void UpdateCategorizer()
        {
            // Approximate width in pixels available to render the x-axis. The margins around the axes are ignored for now.
            int width = this.chart.Width;

            if (width != 0)
            {
                // For example, if dilutionFactor is 100, then 100 points will be averaged into 1.
                this.dilutionFactor = (int)this.dataSource.Rows.Count / width;

                this.lastKnownZoomFactor = this.chart.PrimaryXAxis.ZoomFactor;

                dilutionFactor = (int)Math.Floor(((double)dilutionFactor) * this.chart.PrimaryXAxis.ZoomFactor);
                if (dilutionFactor < 1)
                    dilutionFactor = 1;

                // Clear any existing groups
                this.engine.TableDescriptor.GroupedColumns.Clear();

                if (dilutionFactor > 1)
                {
                    // Add a new group to group by x values...
                    this.engine.TableDescriptor.GroupedColumns.Add(this.xName);
                    // ... with a custom categorizer that helps group the first N number of points into 1 groups, the 2nd N into
                    // another group, and so on.

                    CustomCategorizer categorizer = new CustomCategorizer();
                    categorizer.Factor = dilutionFactor;
                    this.engine.TableDescriptor.GroupedColumns[this.xName].Categorizer = categorizer;
                }
                this.OnDilutionFactorChanged();
            }
        }
        /// <summary>
        /// Returns the number of "grouped" points available. If the DilutionFacotr is 20, then 20 points are grouped into 1.
        /// </summary>
        public override int Count
        {
            get
            {
                if (this.DilutionFactor > 1)
                    // Return the number of groups rather than the actual number of points.
                    return this.engine.Table.TopLevelGroup.Groups.Count;
                else
                    return this.engine.Table.Records.Count;
            }
        }
        /// <summary>
        /// The calculated dilution factor. If this is 20, for example, then 20 points are grouped into 1.
        /// </summary>
        public int DilutionFactor
        {
            get 
            {
                return this.dilutionFactor;
            }
        }
        /// <summary>
        /// Raised whenever DilutionFactor changes.
        /// </summary>
        public event EventHandler DilutionFactorChanged;

        private void OnDilutionFactorChanged()
        {
            if (this.DilutionFactorChanged != null)
                this.DilutionFactorChanged(this, EventArgs.Empty);
        }
        #region IChartSeriesModel Members

        /// <summary>
        /// X is simply the index of the group in this implementation. Note that the X values could be DateTime for example in the
        /// actual data source, but it's always just an index in this implementation.
        /// </summary>
        public double GetX(int xIndex)
        {
            return xIndex;
        }

        /// <summary>
        /// Returns the actual data corresponding to this grouped index. The specified index points to a group of points and the first
        /// point in that group is returned.
        /// </summary>
        public object GetXData(int xIndex)
        {
            if (this.DilutionFactor > 1)
            {
                // We simply use the 1st X point in the group to render the average (see GetY)
                return this.engine.Table.TopLevelGroup.Groups[xIndex].Records[0].GetValue(this.xName);
            }
            else
            {
                return this.engine.Table.Records[xIndex].GetValue(this.xName);
            }
        }
        /// <summary>
        /// Returns the averaged Y of the group of points at the specified grouped index.
        /// </summary>
        public double[] GetY(int xIndex)
        {
            if (this.DilutionFactor > 1)
            {
                // Return the average of the point values that were grouped into 1.
                DoubleAggregateSummary summary = this.engine.Table.TopLevelGroup.Groups[xIndex].GetSummary(0) as DoubleAggregateSummary;
                return new double[] { summary.Average };
            }
            else
            {
                return new double[] { Double.Parse(this.engine.Table.Records[xIndex].GetValue(this.yName).ToString()) };
            }
        }

        /// <summary>
        /// Returns the Max Y value in the data source.
        /// </summary>
        public double GetMaxY()
        {
            DoubleAggregateSummary summary = this.engine.Table.TopLevelGroup.GetSummary(0) as DoubleAggregateSummary;
            return summary.Maximum;
        }
        /// <summary>
        /// Returns whether the specified index has empty point. This is never true in this implementation.
        /// </summary>
        public bool GetEmpty(int xIndex)
        {
            return false;
        }
        #endregion
    }

    // This custom categorizer helps categorize the first N points (specified by Factor) into 1 group, the 2nd N points into a new group, and so on.
    class CustomCategorizer : Syncfusion.Grouping.IGroupByColumnCategorizer
    {
        private int factor;

        public int Factor
        {
            get { return factor; }
            set { factor = value; }
        }

        // Returns the key for a particular value. All values with the same key will be grouped togather.
        private int GetCategory(int val)
        {
            // Since both are integers, only the abs of the division will be returned.
            return val / factor;
        }

        public object GetGroupByCategoryKey(SortColumnDescriptor column, bool isForeignKey, Record record)
        {
            // Here the position of the record is used to determine it's key rather than any specific value in the record.
            return GetCategory(record.GetSourceIndex());
        }

        public int CompareCategoryKey(SortColumnDescriptor column, bool isForeignKey, object category, Record record)
        {
            // Here the position of the record is used to determine it's key rather than any specific value in the record.
            return GetCategory(record.GetSourceIndex()) - (int)category;
        }
    } 
}
