#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections;
using System.Text;

using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Grouping;

using ISummary = Syncfusion.Collections.BinaryTree.ITreeTableSummary;

namespace WeightedSummary
{
	/// <summary>
	/// Syncfusion Custom Summary class that computes the weighted average of the of entries 
	/// where the weights come in from a column passed in through a naming convention. 
	/// </summary>
	public sealed class WeightedSummary : SummaryBase
    {
        #region "API Definition"

        double _valTotal;
		double _wgtTotal;
        public static readonly WeightedSummary Empty = new WeightedSummary(0, 0);

        #endregion
       
        #region Constructor
        public WeightedSummary()
		{

		}

        /// <summary>
        /// Initializes a new summary object.
        /// </summary>
        /// <param name="valTotal"></param>
        /// <param name="wgtTotal"></param>
        public WeightedSummary(double valTotal, double wgtTotal)
        {
            _wgtTotal = wgtTotal;
            _valTotal = valTotal;
        }

        #endregion
        
        #region CreateSummaryMethod

        /// <summary>
		/// Assign this CreateSummaryDelegate handler method to SummaryDescriptor.CreateSummaryMethod 
		/// </summary>
		/// <param name="sd"></param>
		/// <param name="record"></param>
		/// <returns></returns>
		public static ISummary CreateSummaryMethod(SummaryDescriptor sd, Record record)
		{
			object obj = sd.GetValue(record);
			bool isNull = (obj == null || obj is DBNull);
			if (isNull)
			{
				return Empty;
			}
			else
			{
				int i = sd.Name.LastIndexOf('_') + 1;
				string weightsCol = sd.Name.Substring(i);
				object obj1 = record.GetValue(weightsCol);
				if (obj1 == null)
				{
					throw new ArgumentException(string.Format("[{0}] not a column.", weightsCol));
				}
               
				double wgt = Convert.ToDouble(obj1);
				double val = Convert.ToDouble(obj) * wgt;

				return new WeightedSummary(val, wgt);
			}
		}

        #endregion

        #region "Weighted Summary Calculation"
        
        /// <summary>
		/// The running weighted sum of this summary
		/// </summary>
		public double WeightedAverage
		{
			get
			{
				if (_wgtTotal == 0)
					return _wgtTotal;
				return _valTotal / _wgtTotal;
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
		public override SummaryBase Combine(SummaryBase other)
		{
			return Combine((WeightedSummary)other);
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
		public WeightedSummary Combine(WeightedSummary other)
		{
			// Summary objects are immutable. That means properties cannot be modified for an 
			// existing object. Instead every time a change is made a new object must be created (just like 
			// System.String). 
			//
			return new WeightedSummary(this._valTotal + other._valTotal, this._wgtTotal + other._wgtTotal);
		}

		/// <override/>
		public override string ToString()
		{
			return String.Format("WeightedAverage = {0:0.00}", WeightedAverage);
        }
        #endregion
    }
}
