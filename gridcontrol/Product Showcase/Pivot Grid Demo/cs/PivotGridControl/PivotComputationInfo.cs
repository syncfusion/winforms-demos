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
using System.Collections.Generic;
using System.Text;
using Syncfusion.Grouping;
using System.ComponentModel;
using System.Windows.Forms;

using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Xml;

using ISummary = Syncfusion.Collections.BinaryTree.ITreeTableSummary;

namespace PivotGridLibrary
{
    #region PivotComputationInfo class

    public class PivotComputationInfo
    {

        #region properties
        private string fieldName;

        public string FieldName
        {
            get { return fieldName; }
            set { fieldName = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private string calculationName;

        public string CalculationName
        {
            get { return calculationName; }
            set{ calculationName = value;}
        }

        private SummaryBase summary;
        
        [XmlIgnore]
        public SummaryBase Summary
        {
            get { return summary; }
            set { summary = value; }
        }


        private PropertyDescriptor pd;

        [XmlIgnore]
        public PropertyDescriptor Pd
        {
            get { return pd; }
            set { pd = value; }
        }

        private string format = "#.##";

        public string Format
        {
            get { return format; }
            set { format = value; }
        }

        #endregion

        #region constructors 

        public PivotComputationInfo()
        {
        }

        public PivotComputationInfo(SummaryBase summary, string calculationName, string description, string fieldName)
        {
            Initialize(summary, calculationName, description, fieldName);
        }

        /// <summary>
        /// Initializes the computation definition. This method must be called to define the computation.
        /// </summary>
        /// <param name="summary">The SummaryBa</param>
        /// <param name="displayPropertyName"></param>
        /// <param name="description"></param>
        /// <param name="name"></param>
        public void Initialize(SummaryBase summary, string calculationName, string description, string fieldName)
        {
            this.summary = summary;

            this.calculationName = calculationName;
            this.description = description;
            this.fieldName = fieldName;
            this.pd = null;


            if (summary != null)
            {
                PropertyDescriptorCollection pdc = TypeDescriptor.GetProperties(summary, new Attribute[] { new BrowsableAttribute(true) });
                try
                {
                    pd = pdc[calculationName];
                }
                catch 
                {
                    MessageBox.Show(string.Format("{0} not a valid summary property (case matters)", calculationName));
                }
            }
        }
        #endregion

        public override string ToString()
        {
            return this.CalculationName;
        }

    }
    #endregion

    #region Computation choices

    public class PivotComputationInfoList : ArrayList
    {
        public PivotComputationInfoList()
        {
         }

        public new PivotComputationInfo this[int i]
        {
            get { return (PivotComputationInfo)base[i]; }
            set { base[i] = value; }
        }

        public virtual void PopulateWithListChoices()
        {
            this.Clear();

            //xxx is a dummy fieldname just to satisfy the constructor 
            DoubleAggregateSummary sum = DoubleAggregateSummary.Empty;// new DoubleAggregateSummary(0, double.MaxValue, double.MinValue, 0d);
            this.Add(new PivotComputationInfo(sum, "Sum", "Sum of {*}", "xxx"));  
            this.Add(new PivotComputationInfo(sum, "Average", "Average of {*}", "xxx"));  

            DoubleVectorSummary v = DoubleVectorSummary.Empty;// new DoubleVectorSummary(new double[] { 1, 2, 3 }, 3);// any will do
             this.Add(new PivotComputationInfo(v, "Median", "Median of {*}", "xxx"));
             this.Add(new PivotComputationInfo(v, "Percentile25", "25 Percentile of {*}", "xxx"));
             this.Add(new PivotComputationInfo(v, "Percentile75", "75 Percentile of {*}", "xxx")); 

            CountSummary c = CountSummary.Empty;// new VectorSummary(null, 0);
            this.Add(new PivotComputationInfo(c, "Count", "Count of {*}", "xxx"));

            DoubleStdDevSummary sd = DoubleStdDevSummary.Empty;
            this.Add(new PivotComputationInfo(sd, "StdDev", "StDev of {*}", "xxx"));
            this.Add(new PivotComputationInfo(sd, "StdDevP", "StDevP of {*}", "xxx"));
            this.Add(new PivotComputationInfo(sd, "Var", "Var of {*}", "xxx"));
            this.Add(new PivotComputationInfo(sd, "VarP", "VarP of {*}", "xxx")); 

            

        }

        
        public PivotComputationInfo Find(string fieldName)
        {
            foreach (PivotComputationInfo info in this)
            {
                if (info.FieldName == fieldName)
                {
                    return info;
                }
            }
            return null;
        }

        public PivotComputationInfo Find(string calculationName, out int location)
        {
            location = 0;
            foreach (PivotComputationInfo info in this)
            {
                if (info.CalculationName == calculationName)
                {
                    return info;
                }
                location++;
            }
            location = -1;
            return null;
        }

        public static SummaryBase CreateSummary(string computationName)
        {
            SummaryBase summary = null;
            switch (computationName)
            {
                case "Average":
                case "Minimum":
                case "Maximum":
                case "Sum":
                    summary = DoubleAggregateSummary.Empty;
                    break;
                case "Median":
                case "Percentile25":
                case "Percentile75":
                    summary = DoubleVectorSummary.Empty;
                    break;
                case "Count":
                    summary = CountSummary.Empty;
                    break;
                case "StdDev":
                case "StdDevP":
                case "Var":
                case "VarP":
                    summary = DoubleStdDevSummary.Empty;
                    break;
                default:
                    break;
            }
            return summary;
        }
        
    }

    #endregion
}
