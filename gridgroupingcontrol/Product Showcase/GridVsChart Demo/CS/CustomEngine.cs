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
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;

namespace SummaryInCaption
{
	public class GroupingEngineFactory : GridEngineFactoryBase
	{
		// Add this line in your forms ctor:
		// GroupingEngineFactory provides a modified GridChildTable that adds an extra section
		// GridEngineFactory.Factory = new GroupingEngineFactory();

		public override GridEngine CreateEngine()
		{
			return new GroupingEngine();
		}
	}

	public class GroupingEngine : GridEngine
    {
        public GroupingEngine()
        {
        }

        public override Table CreateTable(TableDescriptor tableDescriptor, Table parentRelationTable)
        {
            return new GroupingTable(tableDescriptor, parentRelationTable);
        }

        public override Record CreateRecord(Table parentTable)
        {
            return new GroupingRecord(parentTable);
        }
	}

    /// <summary>
    /// Table that overrides ListChanged event handler and determines which columns were changed
    /// and also if changes affect the sort order, summaries or group captions.
    /// </summary>
    public class GroupingTable : GridTable
    {
        public GroupingTable(TableDescriptor tableDescriptor, Table parentRelationTable)
            : base((GridTableDescriptor) tableDescriptor, (GridTable) parentRelationTable)
        {
        }

        ArrayList diffs;

        public ArrayList ModifiedFields
        {
            get { return diffs; }
            set { diffs = value; }
        }

        protected override void bindingList_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemChanged)
            {
                GroupingRecord r = (GroupingRecord) UnsortedRecords[e.NewIndex];
                ModifiedFields = r.CompareAndUpdateValues();
            }
            base.bindingList_ListChanged(sender, e);
            ModifiedFields = null;
        }
    }

    /// <summary>
    /// Record that shadows values in table and can gives hints which values were changed in ListChanged event.
    /// </summary>
    public class GroupingRecord : GridRecord
    {
        ArrayList fieldValues;
        object data;

        public GroupingRecord(Table parentTable)
            : base(parentTable)
        {
        }

        public override object GetData()
        {
            object baseData = base.GetData();
            if (data == null || data != baseData)
            {
                ResetFieldValues();
                data = baseData;
            }
            return data;
        }

        public void ResetFieldValues()
        {
            data = null;
        }

        bool inGetValue = false;

        public override object GetValue(FieldDescriptor fieldDescriptor)
        {
            if (!inGetValue && (fieldValues == null || fieldValues.Count != ParentTableDescriptor.Fields.Count))
            {
                fieldValues = new ArrayList();
                inGetValue = true;
                try
                {
                    foreach (FieldDescriptor fd in ParentTableDescriptor.Fields)
                        fieldValues.Add(base.GetValue(fd));
                }
                finally
                {
                    inGetValue = false;
                }
            }

            int index = ParentTableDescriptor.Fields.IndexOf(fieldDescriptor);
            if (index != -1)
                return fieldValues[index];

            return null;
        }

        public void UpdateValue(FieldDescriptor fieldDescriptor, object value)
        {
            if (fieldValues != null)
            {
                int index = ParentTableDescriptor.Fields.IndexOf(fieldDescriptor);
                if (index != -1)
                    fieldValues[index] = value;
            }
        }

        public ArrayList CompareAndUpdateValues()
        {
            if (fieldValues != null)
            {
                ArrayList diffs = new ArrayList();
                ArrayList newValues = new ArrayList();
                FieldDescriptorCollection fields = ParentTableDescriptor.Fields;
                for (int n = 0; n < fieldValues.Count; n++)
                {
                    object value = base.GetValue(fields[n]);
                    bool isEqual = Object.ReferenceEquals(fieldValues[n], value);
                    if (!isEqual && fieldValues[n] != null && value != null)
                        isEqual |= fieldValues[n].Equals(value);

                    if (!isEqual)
                        diffs.Add(n);

                    newValues.Add(value);
                }
                fieldValues = newValues;
                return diffs;
            }
            return null;
        }


    }

}

