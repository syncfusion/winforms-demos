#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.Data;

namespace CustomSummarries
{
    public class CustomAggregate : ISummaryAggregate
    {
        public CustomAggregate()
        {

        }

        public double Median { get; set; }

        public double StdDev { get; set; }

        Action<System.Collections.IEnumerable, string, System.ComponentModel.PropertyDescriptor> ISummaryAggregate.CalculateAggregateFunc()
        {
            return (items, property, pd) =>
            {
                var enumerableItems = items as IEnumerable<SalesByYear>;
                if (pd.Name == "Median")
                    this.Median = enumerableItems.Median<SalesByYear>(q => q.Total);
                else
                    this.StdDev = enumerableItems.StdDev<SalesByYear>(q => q.Total);
            };
        }
    }

    public static class LinqExtensions
    {
        public static double Median<T>(this IEnumerable<T> values, Func<T, double?> selector)
        {
            double ret = 0;
            var count = values.Count();
            if (count > 0)
            {
                ret = (count + 1) / 2;
            }

            return ret;
        }

        public static double StdDev<T>(this IEnumerable<T> values, Func<T, double?> selector)
        {
            double ret = 0;
            var count = values.Count();
            if (count > 0)
            {
                double? avg = values.Average(selector);

                double sum = values.Select(selector).Sum(d =>
                {
                    if (d.HasValue)
                    {
                        return Math.Pow(d.Value - avg.Value, 2);
                    }
                    return 0;
                });
                ret = Math.Sqrt((sum) / (count - 1));
                ret = (int)(ret * 100.0) / 100.0;
            }

            return ret;
        }
    }
}
