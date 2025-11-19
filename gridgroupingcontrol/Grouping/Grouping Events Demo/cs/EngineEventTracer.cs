#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;

using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid.Grouping;

namespace GroupingEvents
{
	public class EngineEventTracer
	{
		GridEngine groupingEngine;
		ListView output;
		public EngineEventTracer(GridEngine groupingEngine, ListView output)
		{
			this.output = output;
			this.groupingEngine = groupingEngine;
		}

		void AppendOutput(string name, string e)
		{
			ListViewItem item;
			try
			{
				item=new ListViewItem(new string[]{name,e});
			}
			catch(Exception ex)
			{
				item=new ListViewItem(new string[]{"Record deleted:",ex.InnerException.Message});
			}
			this.output.Items.Add(item);
		}

		# region Hook and Unhook Events

        public void HookEvents()
        {
            this.groupingEngine.Table.GroupAdded += new GroupEventHandler(groupingEngine_GroupAdded);
            this.groupingEngine.Table.GroupCollapsed += new GroupEventHandler(groupingEngine_GroupCollapsed);
            this.groupingEngine.Table.GroupCollapsing += new GroupEventHandler(groupingEngine_GroupCollapsing);
            this.groupingEngine.Table.GroupExpanded += new GroupEventHandler(groupingEngine_GroupExpanded);
            this.groupingEngine.Table.GroupExpanding += new GroupEventHandler(groupingEngine_GroupExpanding);
            this.groupingEngine.Table.GroupRemoving += new GroupEventHandler(groupingEngine_GroupRemoving);
            this.groupingEngine.Table.SortedItemsInGroup += new GroupEventHandler(groupingEngine_SortedItemsInGroup);
            this.groupingEngine.Table.SortingItemsInGroup += new GroupEventHandler(groupingEngine_SortingItemsInGroup);
            this.groupingEngine.Table.SourceListRecordChanged += new RecordChangedEventHandler(groupingEngine_SourceListRecordChanged);
            this.groupingEngine.QueryCustomSummary += new GridQueryCustomSummaryEventHandler(groupingEngine_QueryCustomSummary);
            this.groupingEngine.CurrentRecordContextChange += new CurrentRecordContextChangeEventHandler(groupingEngine_CurrentRecordContextChange);
            this.groupingEngine.DisplayElementChanged += new DisplayElementChangedEventHandler(groupingEngine_DisplayElementChanged);
            this.groupingEngine.PropertyChanged += new DescriptorPropertyChangedEventHandler(groupingEngine_PropertyChanged);
            this.groupingEngine.QueryShowNestedPropertiesFields += new QueryShowNestedPropertiesFieldsEventHandler(groupingEngine_QueryShowNestedPropertiesFields);
            this.groupingEngine.QueryShowRelationDisplayFields += new QueryShowRelationFieldsEventHandler(groupingEngine_QueryShowRelationDisplayFields);
            this.groupingEngine.QueryValue += new FieldValueEventHandler(groupingEngine_QueryValue);
            this.groupingEngine.TableDescriptorCreated += new EventHandler(groupingEngine_TableDescriptorCreated);
            this.groupingEngine.GroupingControl.FieldChooserShowing += new Syncfusion.Windows.Forms.Grid.FieldChooserShowingEventHandler(GroupingControl_FieldChooserShowing);
            this.groupingEngine.GroupingControl.FieldChooserShown += new Syncfusion.Windows.Forms.Grid.FieldChooserShownEventHandler(GroupingControl_FieldChooserShown);
            this.groupingEngine.GroupingControl.FieldChooserClosing += new Syncfusion.Windows.Forms.Grid.FieldChooserClosingEventHandler(GroupingControl_FieldChooserClosing);
            this.groupingEngine.GroupingControl.FieldChooserClosed += new Syncfusion.Windows.Forms.Grid.FieldChooserClosedEventHandler(GroupingControl_FieldChooserClosed);
            this.groupingEngine.TableDescriptor.GroupedColumns.Changing += new Syncfusion.Collections.ListPropertyChangedEventHandler(GroupedColumns_Changing);
            this.groupingEngine.TableDescriptor.GroupedColumns.Changed += new Syncfusion.Collections.ListPropertyChangedEventHandler(GroupedColumns_Changed);
        }
		public void UnhookEvents()
		{
			this.groupingEngine.Table.GroupAdded-=new GroupEventHandler(groupingEngine_GroupAdded);
			this.groupingEngine.Table.GroupCollapsed-=new GroupEventHandler(groupingEngine_GroupCollapsed);
			this.groupingEngine.Table.GroupCollapsing-=new GroupEventHandler(groupingEngine_GroupCollapsing);
			this.groupingEngine.Table.GroupExpanded-=new GroupEventHandler(groupingEngine_GroupExpanded);
			this.groupingEngine.Table.GroupExpanding-=new GroupEventHandler(groupingEngine_GroupExpanding);
			this.groupingEngine.Table.GroupRemoving-=new GroupEventHandler(groupingEngine_GroupRemoving);
			this.groupingEngine.Table.SortedItemsInGroup-=new GroupEventHandler(groupingEngine_SortedItemsInGroup);
			this.groupingEngine.Table.SortingItemsInGroup-=new GroupEventHandler(groupingEngine_SortingItemsInGroup);
			this.groupingEngine.Table.SourceListRecordChanged-=new RecordChangedEventHandler(groupingEngine_SourceListRecordChanged);
			this.groupingEngine.QueryCustomSummary-=new GridQueryCustomSummaryEventHandler(groupingEngine_QueryCustomSummary);
			this.groupingEngine.CurrentRecordContextChange-=new CurrentRecordContextChangeEventHandler(groupingEngine_CurrentRecordContextChange);
			this.groupingEngine.DisplayElementChanged-=new DisplayElementChangedEventHandler(groupingEngine_DisplayElementChanged);
			this.groupingEngine.PropertyChanged-=new DescriptorPropertyChangedEventHandler(groupingEngine_PropertyChanged);
			this.groupingEngine.QueryShowNestedPropertiesFields-=new QueryShowNestedPropertiesFieldsEventHandler(groupingEngine_QueryShowNestedPropertiesFields);
			this.groupingEngine.QueryShowRelationDisplayFields-=new QueryShowRelationFieldsEventHandler(groupingEngine_QueryShowRelationDisplayFields);
			this.groupingEngine.QueryValue-=new FieldValueEventHandler(groupingEngine_QueryValue);
			this.groupingEngine.TableDescriptorCreated-=new EventHandler(groupingEngine_TableDescriptorCreated);
            this.groupingEngine.GroupingControl.FieldChooserShowing -= new Syncfusion.Windows.Forms.Grid.FieldChooserShowingEventHandler(GroupingControl_FieldChooserShowing);
            this.groupingEngine.GroupingControl.FieldChooserShown -= new Syncfusion.Windows.Forms.Grid.FieldChooserShownEventHandler(GroupingControl_FieldChooserShown);
            this.groupingEngine.GroupingControl.FieldChooserClosing -= new Syncfusion.Windows.Forms.Grid.FieldChooserClosingEventHandler(GroupingControl_FieldChooserClosing);
            this.groupingEngine.GroupingControl.FieldChooserClosed -= new Syncfusion.Windows.Forms.Grid.FieldChooserClosedEventHandler(GroupingControl_FieldChooserClosed);
            this.groupingEngine.TableDescriptor.GroupedColumns.Changing -= new Syncfusion.Collections.ListPropertyChangedEventHandler(GroupedColumns_Changing);
            this.groupingEngine.TableDescriptor.GroupedColumns.Changed -= new Syncfusion.Collections.ListPropertyChangedEventHandler(GroupedColumns_Changed);
		}

		# endregion

		private void groupingEngine_GroupAdded(object sender, GroupEventArgs e)
		{
			AppendOutput("GroupAdded: ","Grouped Column:"+e.Group.Name+" By Category: "+e.Group.Category.ToString()+" No. of items in this category:"+e.Group.GetRecordCount().ToString());
		}

		private void groupingEngine_GroupCollapsed(object sender, GroupEventArgs e)
		{
			AppendOutput("GroupCollapsed: ","Grouped Column:"+e.Group.Name+" By Category: "+e.Group.Category.ToString()+" No. of items in this category:"+e.Group.GetRecordCount().ToString());
		}

		private void groupingEngine_GroupExpanded(object sender, GroupEventArgs e)
		{
			AppendOutput("GroupExpanded: ","Grouped Column:"+e.Group.Name+" By Category: "+e.Group.Category.ToString()+" No. of items in this category:"+e.Group.GetRecordCount().ToString());
		}

		private void groupingEngine_GroupExpanding(object sender, GroupEventArgs e)
		{
			AppendOutput("GroupExpanding: ","Grouped Column:"+e.Group.Name+" By Category: "+e.Group.Category.ToString()+" No. of items in this category:"+e.Group.GetRecordCount().ToString());
		}

		private void groupingEngine_GroupCollapsing(object sender, GroupEventArgs e)
		{
			AppendOutput("GroupCollapsing:","Grouped Column:"+e.Group.Name+" By Category: "+e.Group.Category.ToString()+" No. of items in this category:"+e.Group.GetRecordCount().ToString());
		}

		private void groupingEngine_GroupRemoving(object sender, GroupEventArgs e)
		{
			AppendOutput("GroupRemoving: ","Grouped Column:"+e.Group.Name+" By Category: "+e.Group.Category.ToString()+" No. of items in this category:"+e.Group.GetRecordCount().ToString());
		}

		private void groupingEngine_SortedItemsInGroup(object sender, GroupEventArgs e)
		{
            if (e.Group.Category != null)
			AppendOutput("SortedItemsInGroup: ","Sorted Column:"+e.Group.Name+" By: "+e.Group.Category.ToString()+" No. of items:"+e.Group.GetRecordCount().ToString());
		}

		private void groupingEngine_SortingItemsInGroup(object sender, GroupEventArgs e)
		{
            if (e.Group.Category != null)
                AppendOutput("SortingItemsInGroup: ", "Sorted Column:" + e.Group.Name + " By: " + e.Group.Category.ToString() + " No. of items:" + e.Group.GetRecordCount().ToString());
		}

		private void groupingEngine_SourceListRecordChanged(object sender, RecordChangedEventArgs e)
		{
			AppendOutput("SourceListRecordChanged: ","Affected Record:"+e.Record.ToString());
		}

		private void groupingEngine_QueryCustomSummary(object sender, GridQueryCustomSummaryEventArgs e)
		{
			AppendOutput("QueryCustomSummary: ",e.SummaryColumn.Name+" "+e.SummaryDescriptor.SummaryType.ToString());
		}

		private void groupingEngine_CurrentRecordContextChange(object sender, CurrentRecordContextChangeEventArgs e)
		{
			AppendOutput("CurrentRecordContextChanged: ",e.Record.ToString());
		}

		private void groupingEngine_DisplayElementChanged(object sender, DisplayElementChangedEventArgs e)
		{
			AppendOutput("DisplayElementChanged: ",e.Element.ToString());
		}

		private void groupingEngine_PropertyChanged(object sender, DescriptorPropertyChangedEventArgs e)
		{
			AppendOutput("PropertyChanged: ",e.PropertyName);
		}

		private void groupingEngine_QueryShowNestedPropertiesFields(object sender, QueryShowNestedPropertiesFieldsEventArgs e)
		{
			AppendOutput("QueryShowNestedPropertiesFields: ",e.ToString());
		}

		private void groupingEngine_QueryShowRelationDisplayFields(object sender, QueryShowRelationFieldsEventArgs e)
		{
			AppendOutput("QueryShowRelationDisplayFields: ","ParentTable:"+e.Relation.ParentTableDescriptor.Name+" ChildTable:"+e.Relation.ChildTableName);
		}

		private void groupingEngine_QueryValue(object sender, FieldValueEventArgs e)
		{
			AppendOutput("QueryValue: ","Field:"+e.Field.Name+" Value:"+e.Value.ToString());
		}

		private void groupingEngine_TableDescriptorCreated(object sender, EventArgs e)
		{
			AppendOutput("TableDescriptorCreated: ",e.ToString());
		}
        void GroupingControl_FieldChooserClosed(object sender, Syncfusion.Windows.Forms.Grid.FieldChooserClosedEventArgs e)
        {
            AppendOutput("FieldChooserClosed: ", "caption Name:" + e.Caption + " In : " + e.FieldList.ToString());
        }

        void GroupingControl_FieldChooserClosing(object sender, Syncfusion.Windows.Forms.Grid.FieldChooserClosingEventArgs e)
        {
            AppendOutput("FieldChooserClosing: ", "caption Name:" + e.Caption + " In : " + e.FieldList.ToString());
        }

        void GroupingControl_FieldChooserShown(object sender, Syncfusion.Windows.Forms.Grid.FieldChooserShownEventArgs e)
        {
            AppendOutput("FieldChooserShown: ", "caption Name:" + e.Caption + " In : " + e.FieldList.ToString());
        }

        void GroupingControl_FieldChooserShowing(object sender, Syncfusion.Windows.Forms.Grid.FieldChooserShowingEventArgs e)
        {
            AppendOutput("FieldChooserShowing: ", "caption Name:" + e.Caption + " In : " + e.FieldList.ToString());
        }

        void GroupedColumns_Changed(object sender, Syncfusion.Collections.ListPropertyChangedEventArgs e)
        {
            if (e.Action == Syncfusion.Collections.ListPropertyChangedType.Insert)
            {
                AppendOutput("Group Inserted: ", "Inserted Column:" + e.Item.ToString());
            }
            if (e.Action == Syncfusion.Collections.ListPropertyChangedType.Remove)
            {
                AppendOutput("Group Removed: ", "Removed Column:" + e.Item.ToString());
            }
        }

        void GroupedColumns_Changing(object sender, Syncfusion.Collections.ListPropertyChangedEventArgs e)
        {
            if (e.Action == Syncfusion.Collections.ListPropertyChangedType.Insert)
            {
                AppendOutput("Group Inserting: ", "Insert Column:" + e.Item.ToString());
            }
            if (e.Action == Syncfusion.Collections.ListPropertyChangedType.Remove)
            {
                AppendOutput("Group Removing: ", "Removed Column:" + e.Item.ToString());
            }
        }
	}
}
