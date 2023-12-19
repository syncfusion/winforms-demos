#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
# region Directives
using System;
using System.Collections;
using System.Text;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Grouping;

using ISummary = Syncfusion.Collections.BinaryTree.ITreeTableSummary;
#endregion

namespace PortfolioManager
{
    public sealed class DayChangeSummary : SummaryBase
    {
        # region Variable Declaration
        double dayChangeTotal;
        public static readonly DayChangeSummary Empty = new DayChangeSummary(0);
        #endregion

        #region Property
        public double DayChangeTotal
        {
            get
            {
                return dayChangeTotal;
            }
        }
        #endregion

        # region Method
        public DayChangeSummary(double DayChangeTotal)
        {
            this.dayChangeTotal = DayChangeTotal;
        }

        public static ISummary CreateSummaryMethod(SummaryDescriptor sd, Record record)
        {
            object obj = sd.GetValue(record);

            bool isNull = (obj == null || obj is DBNull);
            if (isNull)
                return Empty;
            else
            {

                Double qouteChange = Convert.ToDouble(obj);
                Double quantity = Convert.ToDouble(record.GetValue("Quantity"));

                return new DayChangeSummary(qouteChange * quantity);
            }
        }

        /// <summary>
        /// Combines this summary information with another objects summary and returns a new object.  
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        /// <remarks>
        /// This method must honor the immutable characteristics of summary objects and return 
        /// a new summary object instead of modifying an existing summary object.
        /// </remarks>
        public DayChangeSummary Combine(DayChangeSummary other)
        {
            // Summary objects are immutable. That means properties cannot be modified for an 
            // existing object. Instead every time a change is made a new object must be created (just like 
            // System.String). 
            //
            // This allows following optimization: return existing summary object if either one of the values is 0. -->
            if (other.DayChangeTotal == 0)
                return this;
            else if (DayChangeTotal == 0)
                return other;
            // <-- end of optimization
            else
                return new DayChangeSummary(this.DayChangeTotal + other.DayChangeTotal);
        }

        /// <summary>
        /// Combines this summary information with another objects summary and returns a new object.  
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        /// <remarks>
        /// This method must honor the immutable characteristics of summary objects and return 
        /// a new summary object instead of modifying an existing summary object.
        /// </remarks>
        public override SummaryBase Combine(SummaryBase other)
        {
            return Combine((DayChangeSummary)other);
        }
       
        #endregion
    }
}
