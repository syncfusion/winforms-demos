#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections;
using System.ComponentModel;
using System.Reflection;
using Syncfusion.Grouping;

namespace LinqGroupBy
{

    public delegate IEnumerable NestedQueryResultsDelegate(object[] keys, out object totals);

    public class PassThroughGroupingResult : IPassThroughGroupingResult
    {
        #region Fields
        IEnumerable results;
        PropertyDescriptorCollection properties;
        string name;
        string[] groupByColumns;
        object totals;
        NestedQueryResultsDelegate nestedQueryHandler;
        IEnumerable sampleQuery;
        string keyProperty = "Key";
        string countProperty = "Count";
        string detailsProperty = "Details";
        #endregion

        #region Ctor
        public PassThroughGroupingResult(string name, IEnumerable results, Type itemType, object totals, params string[] groupByColumns)
        {
            this.name = name;
            this.results = results;
            this.properties = TypeDescriptor.GetProperties(itemType);
            this.groupByColumns = groupByColumns;
            this.totals = totals;
        }

        public PassThroughGroupingResult(string name, NestedQueryResultsDelegate nestedQueryHandler, Type itemType, params string[] groupByColumns)
        {
            this.name = name;
            this.nestedQueryHandler = nestedQueryHandler;
            this.properties = TypeDescriptor.GetProperties(itemType);
            this.groupByColumns = groupByColumns;
            this.totals = null;
        }

        public PassThroughGroupingResult(string name, IEnumerable results, Type itemType, object totals, IEnumerable sampleResults, params string[] groupByColumns)
            : this(name, results, itemType, totals, groupByColumns)
        {
            this.sampleQuery = sampleResults;
        }

        public PassThroughGroupingResult(string name, NestedQueryResultsDelegate nestedQueryHandler, Type itemType, IEnumerable sampleResults, params string[] groupByColumns)
            : this(name, nestedQueryHandler, itemType, groupByColumns)
        {
            this.sampleQuery = sampleResults;
        }
        #endregion

        public void Refresh()
        {
            if (ItemsReset != null)
                ItemsReset(this, EventArgs.Empty);
        }

        #region Properties
        public string KeyProperty
        {
            get { return keyProperty; }
            set { keyProperty = value; }
        }

        public string CountProperty
        {
            get { return countProperty; }
            set { countProperty = value; }
        }

        public string DetailsProperty
        {
            get { return detailsProperty; }
            set { detailsProperty = value; }
        }

        public NestedQueryResultsDelegate NestedQueryHandler
        {
            get { return nestedQueryHandler; }
            set { nestedQueryHandler = value; }
        }
        #endregion

        #region IEnumerable Members

        public IEnumerator GetEnumerator()
        {
            return results.GetEnumerator();
        }

        #endregion

        #region ITypedList Members

        public PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors)
        {
            return properties;
        }

        public string GetListName(PropertyDescriptor[] listAccessors)
        {
            return name;
        }

        #endregion

        #region IPassThroughGroupingResult Members

        public string[] GroupByColumns
        {
            get { return groupByColumns; }
        }

        public IEnumerable GetItems(Group group, object item)
        {
            PropertyInfo pi = item.GetType().GetProperty(DetailsProperty, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
            if (pi != null)
            {
                IEnumerable items = pi.GetValue(item, null) as IEnumerable;
                if (items != null)
                    return items;
            }

            // Try known Fields and Methods for IGrouping<T,K> type.

            FieldInfo fi = item.GetType().GetField("items", BindingFlags.Instance | BindingFlags.NonPublic);
            if (fi != null)
            {
                IEnumerable items = fi.GetValue(item) as IEnumerable;
                if (items != null)
                    return items;
            }

            if (item is IEnumerable)
                return (IEnumerable)item;

            throw new NotSupportedException();
        }

        public int GetItemCount(Group group, object item)
        {
            if (item == null)
                return 0;

            // when GetNestedItems returned Totals as out parameter, the Tables RaiseRecordExpanding
            // method sets the Count as item in the child table. This is the count that gets displayed
            // in the caption bar.
            if (item is int)
                return (int)item;

            PropertyInfo pi = item.GetType().GetProperty(CountProperty, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
            if (pi != null)
                return (int)pi.GetValue(item, null);

            // Try known Fields and Methods for IGrouping<T,K> type.

            MethodInfo mi = item.GetType().GetMethod("Count", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (mi != null)
                return (int)mi.Invoke(item, null);

            FieldInfo fi = item.GetType().GetField("items", BindingFlags.Instance | BindingFlags.NonPublic);
            if (fi != null)
            {
                IList items = fi.GetValue(item) as IList;
                if (items != null)
                    return items.Count;
            }

            throw new InvalidOperationException("Could not find Count property");
        }

        public object GetGroupByKey(string column, object item)
        {
            PropertyInfo pi = item.GetType().GetProperty(KeyProperty, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
            if (pi != null)
                return pi.GetValue(item, null);

            // Try known Fields and Methods for IGrouping<T,K> type.

            FieldInfo fi = item.GetType().GetField("key", BindingFlags.Instance | BindingFlags.NonPublic);
            if (fi != null)
                return fi.GetValue(item);

            throw new InvalidOperationException("Could not find Key property");
        }

        public object GetTotals()
        {
            return totals;
        }

        public IEnumerable GetNestedItems(RelationDescriptor rd, ChildTable childTable, object[] keys, out object totals)
        {
            if (NestedQueryHandler == null)
            {
                totals = null;
                return null;
            }

            return NestedQueryHandler(keys, out totals);
        }

        public IEnumerable GetSampleItems()
        {
            return sampleQuery;
        }


        /// <summary>
        /// TODO: The Engine is not listening yet to this event. In the meantime you have to simply
        /// assign a new PassThroughGroupingResult as datasource ...
        /// </summary>
        public event EventHandler ItemsReset;

        #endregion
    }


}
