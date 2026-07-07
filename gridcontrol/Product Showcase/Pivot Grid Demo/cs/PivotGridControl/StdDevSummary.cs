#region Copyright Syncfusion Inc. 2001 - 2015
//
//  Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
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
using System.Text;

using Syncfusion.Collections;
using Syncfusion.Collections.BinaryTree;
using Syncfusion.Diagnostics;
using Syncfusion.Grouping;

namespace PivotGridLibrary
{
    /// <summary>
    /// Summarizes System.Double fields. Provides StdDev, StdDevp, Var, and Varp.
    /// </summary>
    public sealed class DoubleStdDevSummary : SummaryBase
    {
        int count;
        double sum;
        double sumX2;

        /// <summary>
        /// The initial summary object for empty records or tables.
        /// </summary>
        public static readonly DoubleStdDevSummary Empty = new DoubleStdDevSummary(0, 0.0, 0.0);

        /// <summary>
        /// Creates a summary object for the specified SummaryDescriptor and Record.
        /// </summary>
        /// <param name="sd">The summary descriptor.</param>
        /// <param name="record">The record with data.</param>
        /// <returns>A new summary object.</returns>
        public static ITreeTableSummary CreateSummaryMethod(SummaryDescriptor sd, Record record)
        {
            object obj = sd.GetValue(record);
            bool isNull = (obj == null || obj is DBNull);
            if (isNull)
                return Empty;
            else
            {
                double val = Convert.ToDouble(obj);
                return new DoubleStdDevSummary(1, val, val * val);
            }
        }

        /// <summary>
        /// Initializes a new summary object with the specified values.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="sum"></param>
        /// <param name="sumX2"></param>
        public DoubleStdDevSummary(int count, double sum, double sumX2)
        {
            this.count = count;
            this.sum = sum;
            this.sumX2 = sumX2;
        }


        

        /// <summary>
        /// Gets the Standard Deviation. (ie, divides by n-1)
        /// </summary>
        public double StdDev
        {
            get
            {
                if (count <= 1)
                    return double.NaN;
                return Math.Sqrt(Var);
            }
        }

        /// <summary>
        /// Gets the population Standard Deviation.  (ie, divides by n)
        /// </summary>
        public double StdDevP
        {
            get
            {
                if (count <= 1)
                    return double.NaN;
                return Math.Sqrt(VarP);
            }
        }

        /// <summary>
        /// Gets the Variance. (ie, divides by n-1)
        /// </summary>
        public double Var
        {
            get
            {
                if (count <= 1)
                    return double.NaN;
                return (count * sumX2 - sum * sum) / (count * (count-1));
            }
        }

        /// <summary>
        /// Gets the population Variance.  (ie, divides by n)
        /// </summary>
        public double VarP
        {
            get
            {
                if (count <= 1)
                    return double.NaN;
                return (count * sumX2 - sum * sum) / (count * count);
            }
        }


        /// <override/>
        public override SummaryBase Combine(SummaryBase other)
        {
            return Combine((DoubleStdDevSummary)other);
        }

        /// <summary>
        /// Combines the values of this summary with another summary and returns
        /// a new summary object.
        /// </summary>
        /// <param name="other">Another summary object (of the same type).</param>
        /// <returns>A new summary object with combined values of both summaries.</returns>
        public DoubleStdDevSummary Combine(DoubleStdDevSummary other)
        {
            if (other.count == 0)
                return this;
            else if (this.count == 0)
                return other;
            else
                return new DoubleStdDevSummary(
                    this.count + other.count,
                    this.sum + other.sum,
                    this.sumX2 + other.sumX2
                    );
        }

        /// <override/>
        public override string ToString()
        {
            return String.Concat(
                "StdDev = " + this.StdDev.ToString(),
                ", StdDevP = " + this.StdDevP.ToString(),
                ", Var = " + this.Var.ToString(),
                ", VarP = " + this.VarP.ToString()
                );
        }
    }



}
