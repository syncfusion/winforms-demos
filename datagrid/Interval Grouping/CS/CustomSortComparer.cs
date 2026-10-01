#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Syncfusion.Data;
using System.Linq;

namespace IntervalGrouping
{
    public class GroupDateComparer : IComparer<object>, ISortDirection
    {
        public ListSortDirection SortDirection { get; set; }
        public Comparer _comparer;
        public GroupDateComparer()
        {
            this._comparer = Comparer.Default;
        }

        public int Compare(object x, object y)
        {
            DateTime namX;
            DateTime namY;
            if (x.GetType() == typeof(OrderInfo))
            {
                namX = ((OrderInfo)x).ShippedDate;
                namY = ((OrderInfo)y).ShippedDate;
            }
            else if (x.GetType() == typeof(Group))
            {
                var group1 = x as Group;
                if (group1.Source == null || group1.Source.Count == 0)
                    return 0;

                var group2 = y as Group;
                if (group2.Source.Count == 0)
                    return 0;

                namX = ((OrderInfo)group1.Source[0]).ShippedDate;
                namY = ((OrderInfo)group2.Source[0]).ShippedDate;
            }
            else
            {
                namX = (DateTime)x;
                namY = (DateTime)y;
            }

            var num = this._comparer.Compare(namX, namY);
            if (this.SortDirection == ListSortDirection.Descending)
            {
                num = -num;
            }

            return num;
        }
    }

    public class GroupNumericComparer : IComparer<object>, ISortDirection
    {
        public ListSortDirection SortDirection { get; set; }
        public Comparer _comparer;

        public GroupNumericComparer()
        {
            this._comparer = Comparer.Default;
        }

        public int Compare(object x, object y)
        {
            int value1;
            int value2;
            if (x.GetType() == typeof(OrderInfo))
            {
                value1 = ((OrderInfo)x).OrderID;
                value2 = ((OrderInfo)y).OrderID;
            }

            else if (x.GetType() == typeof(Group))
            {
                var group1 = x as Group;
                if (group1.Source == null || group1.Source.Count == 0)
                    return 0;

                var group2 = y as Group;
                if (group2.Source.Count == 0)
                    return 0;

                value1 = ((OrderInfo)group1.Source[0]).OrderID;
                value2 = ((OrderInfo)group2.Source[0]).OrderID;
            }
            else
            {
                value1 = (int)x;
                value2 = (int)y;
            }

            var diff = value1.CompareTo(value2);
            if (diff > 0)
                return SortDirection == ListSortDirection.Ascending ? 1 : -1;
            if (diff == -1)
                return SortDirection == ListSortDirection.Ascending ? -1 : 1;
            return 0;
        }
    }
}