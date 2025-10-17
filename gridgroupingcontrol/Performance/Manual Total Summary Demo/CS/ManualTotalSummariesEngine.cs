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
using System.Drawing;
using System.Collections;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Text;

using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid.Grouping;


namespace Syncfusion.Grouping.ManualSummaries
{
    public class ManualTotalSummaryEngineFactory : GridEngineFactoryBase
    {
        // Add these static ctor to your form:
        /*
        static Form1()
        {
            // Enable ManualTotalSummaryEngineFactory with optimized ListChanged handler. Must
            // be set before InitializeComponent in Form ctor.
            GridEngineFactory.Factory = new ManualTotalSummaryEngineFactory();
        }
        */

        public override GridEngine CreateEngine()
        {
            return new ManualTotalSummaryEngine();
        }
    }

    public class ManualTotalSummaryEngine : GridEngine
    {
        public ManualTotalSummaryEngine()
        {
        }

        public override Table CreateTable(TableDescriptor tableDescriptor, Table parentRelationTable)
        {
            return new ManualTotalSummaryTable(tableDescriptor, parentRelationTable);
        }

        public override Group CreateGroup(Section parent)
        {
            return new ManualTotalSummaryGroup(parent);
        }

        public override ChildTable CreateChildTable(Element parent)
        {
            return new ManualTotalSummaryChildTable(parent);
        }
    }

    /// <summary>
    /// Grouping child table with support for manual total summaries.
    /// </summary>
    public class ManualTotalSummaryChildTable : GridChildTable, IManualTotalSummaryArraySource
    {
        ManualTotalSummary[] ManualTotalSummaryArray;

        public ManualTotalSummaryChildTable(Element parent)
            : base(parent)
        {
            ManualTotalSummaryArray = new ManualTotalSummary[parent.ParentTableDescriptor.Fields.Count];

            ManualTotalSummaryTable td = (parent is Table ? parent : parent.ParentTable) as ManualTotalSummaryTable;

            if (td != null)
            {
                foreach (string field in td.TotalSummaries)
                    new ManualTotalSummary(this, field);
            }
        }

        #region IManualTotalSummaryArraySource Members

        public ManualTotalSummary[] GetManualTotalSummaryArray()
        {
            return ManualTotalSummaryArray;
        }

        #endregion
    }

    /// <summary>
    /// Grouping group with support for manual total summaries.
    /// </summary>
    public class ManualTotalSummaryGroup : GridGroup, IManualTotalSummaryArraySource, IGridGroupOptionsSource
    {
        ManualTotalSummary[] ManualTotalSummaryArray;

        public ManualTotalSummaryGroup(Section parent)
            : base(parent)
        {
            ManualTotalSummaryArray = new ManualTotalSummary[parent.ParentTableDescriptor.Fields.Count];

            ManualTotalSummaryTable td = parent.ParentTable as ManualTotalSummaryTable;

            if (td != null)
            {
                foreach (string field in td.TotalSummaries)
                    new ManualTotalSummary(this, field);
            }
        }

        IGridGroupOptionsSource IGridGroupOptionsSource.GetParentGroupOptionsSource()
        {
            // this method is overriden to avoid looking up Appearance from GridColumnDescriptor
            // which costs a few ticks performance.

            return (IGridGroupOptionsSource)this.ParentTableDescriptor;
        }

        #region IManualTotalSummaryArraySource Members

        public ManualTotalSummary[] GetManualTotalSummaryArray()
        {
            return ManualTotalSummaryArray;
        }

        #endregion
    }


    /// <summary>
    /// Table with ManualTotalSummaries.
    /// </summary>
    public class ManualTotalSummaryTable : GridTable
    {
        public ManualTotalSummaryTable(TableDescriptor tableDescriptor, Table parentRelationTable)
            : base((GridTableDescriptor)tableDescriptor, (GridTable)parentRelationTable)
        {
        }

        #region TotalSummaries Support
        ArrayList totalSummaries = new ArrayList();

        /// <exclude/>
        /// <summary>
        /// TODO: Move this to TableDescriptor.
        /// </summary>
        public ArrayList TotalSummaries
        {
            get
            {
                return this.totalSummaries;
            }
            set
            {
                this.totalSummaries = value;
            }
        }

        protected override void OnPrepareRemoving(object row)
        {
            // Save values for all fields where we need to be able to access the
            // old value (e.g. Delta for TotalSummaries).
            TableDescriptor td = TableDescriptor;
            IManualTotalSummaryArraySource tsa = this.TopLevelGroup as IManualTotalSummaryArraySource;
            if (tsa != null)
            {
                foreach (string name in this.totalSummaries)
                {
                    FieldDescriptor fd = td.Fields[name];
                    if (fd.IsPropertyField())
                    {
                        PropertyDescriptor pd = fd.GetPropertyDescriptor();
                        object value = GetValue(row, pd);

                        ChangedFieldInfo ci = new ChangedFieldInfo(td, pd.Name, value, null);
                        this.AddChangedField(ci);
                    }
                }
            }

            base.OnPrepareRemoving(row);
        }

        protected override void OnPrepareItemAdded(object row)
        {
            // Get new values for which delta information is needed
            IManualTotalSummaryArraySource tsa = this.TopLevelGroup as IManualTotalSummaryArraySource;
            if (tsa != null)
            {
                TableDescriptor td = TableDescriptor;

                foreach (string name in this.totalSummaries)
                {
                    FieldDescriptor fd = td.Fields[name];
                    if (fd.IsPropertyField())
                    {
                        PropertyDescriptor pd = fd.GetPropertyDescriptor();
                        object value = GetValue(row, pd);

                        ChangedFieldInfo ci = new ChangedFieldInfo(td, pd.Name, null, value);
                        this.AddChangedField(ci);
                    }
                }
            }

            base.OnPrepareItemAdded(row);
        }

        protected override void OnRecordChanged(Element r, bool isObsoleteRecord, bool isAddedRecord)
        {
            TableDescriptor td = TableDescriptor;
            Group g = r.ParentGroup;
            while (g is IManualTotalSummaryArraySource)
            {
                OnGroupSummaryInvalidated(new GroupEventArgs(g));

                IManualTotalSummaryArraySource tsa = g as IManualTotalSummaryArraySource;
                foreach (ChangedFieldInfo ci in this.ChangedFieldsArray)
                {
                    ManualTotalSummary mt = tsa.GetManualTotalSummaryArray()[ci.FieldIndex];
                    if (mt != null)
                        mt.ApplyDelta(r, isObsoleteRecord, isAddedRecord, ci);
                }

                g = g.ParentGroup;
            }
        } // Fix ManualTotalSummary of parent groups.
        #endregion
    }




    /// <summary>
    /// Implement this interface in GridGroup and GridChildTable so that others have access to ManualTotalSummary array
    /// </summary>
    public interface IManualTotalSummaryArraySource
    {
        ManualTotalSummary[] GetManualTotalSummaryArray();
    }

    /// <summary>
    /// This is a manual summary class which can be updated immediately using the difference between old and
    /// new value in a ListChanged event. For each entry in ManualTotalSummaryTable.TotalSummaries a ManualTotalSummary
    /// will be created. In gridGroupingControl1_QueryCellStyleInfo the ManualTotalSummary.Total value will 
    /// be retrieved and displayed in a summary or caption cell.
    /// </summary>
    public class ManualTotalSummary 
    {
        double total;
        bool dirty = true;
        Group group;
        int fieldIndex = -1;

        public ManualTotalSummary(Group g, string field)
            : this(g, g.ParentTableDescriptor.Fields[field])
        {
        }

        public ManualTotalSummary(Group g, FieldDescriptor field)
        {
            this.Field = field;
            this.Group = g;
        }

        public int FieldIndex
        {
            set
            {
                fieldIndex = value;
            }
            get
            {
                if (fieldIndex == -1)
                    fieldIndex = field.Collection.IndexOf(Field);
                return this.fieldIndex;
            }
        }


        public Group Group
        {
            get
            {
                return this.group;
            }
            set
            {
                this.group = value;
                IManualTotalSummaryArraySource tsa = group as IManualTotalSummaryArraySource;
                tsa.GetManualTotalSummaryArray()[FieldIndex] = this;
            }
        }

        FieldDescriptor field;

        public FieldDescriptor Field
        {
            get
            {
                return this.field;
            }
            set
            {
                this.field = value;
            }
        }

        public bool Dirty
        {
            get
            {
                return this.dirty;
            }
            set
            {
                this.dirty = value;
            }
        }

        public double Total
        {
            get
            {
                if (dirty)
                {
                    CalculateTotal();
                    this.dirty = false;
                }


                return this.total;
            }
            set
            {
                this.total = value;
            }
        }

        void CalculateTotal()
        {
            total = 0;

            if (group.Details is RecordsDetails)
            {
                foreach (Record r in group.Records)
                {
                    object obj = r.GetValue(field);
                    if (obj != null && !(obj is DBNull))
                    {
                        double d = Convert.ToDouble(obj);
                        total += d;
                    }
                }
            }
            else
            {
                foreach (Group g in group.Groups)
                {
                    IManualTotalSummaryArraySource tsa = g as IManualTotalSummaryArraySource;
                    ManualTotalSummary mt = tsa.GetManualTotalSummaryArray()[this.FieldIndex];
                    if (mt == null)
                        mt = new ManualTotalSummary(g, field);
                    double d = mt.Total;
                    total += d;
                }
            }
        }

        public void ApplyDelta(Element r, bool isObsoleteRecord, bool isAddedRecord, ChangedFieldInfo ci)
        {
            if (Dirty)
                return;

            ManualTotalSummary mt = this;

            if (isObsoleteRecord)
            {
                if (ci.OldValue != null && !(ci.OldValue is DBNull))
                    mt.Total -= Convert.ToDouble(ci.OldValue);
            }
            else if (isAddedRecord)
            {
                if (ci.NewValue != null && !(ci.NewValue is DBNull))
                    mt.Total += Convert.ToDouble(ci.NewValue);
            }
            else
                mt.Total += ci.Delta;
        }

    }
}

