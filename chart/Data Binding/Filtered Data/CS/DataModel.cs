#region Copyright Syncfusion Inc. 2001 - 2006
//
//  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Collections;
using System.ComponentModel;

using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Grouping;

namespace Syncfusion.Windows.Forms.Chart.Samples
{
    /// <summary>
    /// Filtering of data is done in this class using the Grouping Engine.
    /// </summary>
    public class DataModel : IChartSeriesModel
    {
        private ArrayList DataList = new ArrayList();
        private Engine group = new Engine();
        private ListChangedEventArgs listChanged;
        private double value = 150;
        Random r = new Random();

        /// <summary>
        /// Constructor. Initializes a new instance of the DataModel class.
        /// </summary>
        public DataModel()
        {
            // Minimum requirement for Grouping Engine - DataSource should be a IList collection
            DataList.Add(new Data(DateTime.Now.ToOADate(), value));// This is needed - otherwise grouping does not work
            group.SetSourceList(DataList);

            ExpressionFieldDescriptor exp = new ExpressionFieldDescriptor();
            exp.Expression = "[X] > " + DateTime.Now.AddMinutes(-5).ToOADate();

            RecordFilterDescriptor rfd = new RecordFilterDescriptor(exp.Expression);
            group.TableDescriptor.RecordFilters.Add(rfd);
        }

        public int Count
        {
            get
            {
                return group.Table.FilteredRecords.Count;
            }
        }

        public double[] GetY(int index)
        {
            return new double[] { ((Data)group.Table.FilteredRecords[index].GetData()).Y };
        }

        public double GetX(int index)
        {
            return ((Data)group.Table.FilteredRecords[index].GetData()).X;
        }

        public void RaiseListChanged()
        {
            if (this.Changed != null)
            {
                listChanged = new ListChangedEventArgs(ListChangedType.Reset, -1);
                this.Changed(this, listChanged);
            }
        }

        public bool GetEmpty(int i)
        {
            return false;
        }

        private Data GetDataUsage()
        {
            DateTime time = DateTime.Now;
            if (r.NextDouble() > .5)
            {
                value += r.NextDouble();
            }
            else
            {
                value -= r.NextDouble();
            }
            return new Data(time.ToOADate(), value);
        }

        public void Refresh()
        {
            this.DataList.Add(GetDataUsage());
            GetFilteredRecords();
        }

        /// <summary>
        /// Filters the data added before 15 minutes.
        /// </summary>
        private void GetFilteredRecords()
        {
            double t = DateTime.Now.AddMinutes(-5).ToOADate();
            group.TableDescriptor.RecordFilters[0].Expression = "[X] > " + t;
            group.Table.TableDirty = true;

            this.RaiseListChanged();

        }

        public event ListChangedEventHandler Changed;
    }
}
