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
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Grouping;
using ComboboxCells;

namespace GroupingEngineEventsTracer
{
    public class Tracer
    {
        GridEngine groupingEngine;
        EventTracer etracer;
        public int count = 1;
        public Tracer(GridEngine groupingEngine, EventTracer Output)
        {
            this.etracer = Output;
            this.etracer.Enabled = true;
            this.groupingEngine = groupingEngine;
        }

        # region Hook and Unhook Events

        public void HookEngEvents()
        {
            this.groupingEngine.BindingContextChanged += new EventHandler(groupingEngine_BindingContextChanged);
            this.groupingEngine.CategorizedRecords += new TableEventHandler(groupingEngine_CategorizedRecords);
            this.groupingEngine.CategorizingRecords += new TableEventHandler(groupingEngine_CategorizingRecords);
            this.groupingEngine.DataMemberChanged += new EventHandler(groupingEngine_DataMemberChanged);
            this.groupingEngine.DataSourceChanged += new EventHandler(groupingEngine_DataSourceChanged);
            this.groupingEngine.ExceptionRaised += new ExceptionRaisedEventHandler(groupingEngine_ExceptionRaised);

            this.groupingEngine.GroupAdded += new GroupEventHandler(groupingEngine_GroupAdded);
            this.groupingEngine.GroupCollapsed += new GroupEventHandler(groupingEngine_GroupCollapsed);
            this.groupingEngine.GroupCollapsing += new GroupEventHandler(groupingEngine_GroupCollapsing);
            this.groupingEngine.GroupExpanded += new GroupEventHandler(groupingEngine_GroupExpanded);
            this.groupingEngine.GroupExpanding += new GroupEventHandler(groupingEngine_GroupExpanding);
            this.groupingEngine.GroupRemoving += new GroupEventHandler(groupingEngine_GroupRemoving);
            this.groupingEngine.GroupSummaryInvalidated += new GroupEventHandler(groupingEngine_GroupSummaryInvalidated);
            this.groupingEngine.InvalidatingCounters += new TableEventHandler(groupingEngine_InvalidatingCounters);
            this.groupingEngine.InvalidatingSummaries += new TableEventHandler(groupingEngine_InvalidatingSummaries);

            this.groupingEngine.PropertyChanged += new DescriptorPropertyChangedEventHandler(groupingEngine_PropertyChanged);
            this.groupingEngine.PropertyChanging += new DescriptorPropertyChangedEventHandler(groupingEngine_PropertyChanging);
            this.groupingEngine.ParseCommonFormats += new Syncfusion.Windows.Forms.Grid.GridCellTextEventHandler(groupingEngine_ParseCommonFormats);

            this.groupingEngine.QueryAddColumn += new GridQueryAddColumnEventHandler(groupingEngine_QueryAddColumn);
            this.groupingEngine.QueryAddRelation += new QueryAddRelationEventHandler(groupingEngine_QueryAddRelation);
            this.groupingEngine.QueryAddVisibleColumn += new GridQueryAddVisibleColumnEventHandler(groupingEngine_QueryAddVisibleColumn);
            //this.groupingEngine.QueryCellFormattedText += new GridCellTextEventHandler(groupingEngine_QueryCellFormattedText);
            //this.groupingEngine.QueryCellStyleInfo += new GridTableCellStyleInfoEventHandler(groupingEngine_QueryCellStyleInfo);
            this.groupingEngine.QueryCellText += new GridCellTextEventHandler(groupingEngine_QueryCellText);
            //this.groupingEngine.QueryCoveredRange += new GridTableQueryCoveredRangeEventHandler(groupingEngine_QueryCoveredRange);
            this.groupingEngine.QueryCustomSummary += new GridQueryCustomSummaryEventHandler(groupingEngine_QueryCustomSummary);
            //this.groupingEngine.QueryRecordMeetsFilterCriteria += new QueryRecordMeetsFilterCriteriaEventHandler(groupingEngine_QueryRecordMeetsFilterCriteria);
            this.groupingEngine.QueryShowField += new QueryShowFieldEventHandler(groupingEngine_QueryShowField);
            this.groupingEngine.QueryShowNestedPropertiesFields += new QueryShowNestedPropertiesFieldsEventHandler(groupingEngine_QueryShowNestedPropertiesFields);
            this.groupingEngine.QueryShowRelationDisplayFields += new QueryShowRelationFieldsEventHandler(groupingEngine_QueryShowRelationDisplayFields);
            this.groupingEngine.QueryValue += new FieldValueEventHandler(groupingEngine_QueryValue);
            this.groupingEngine.RecordCollapsed += new RecordEventHandler(groupingEngine_RecordCollapsed);
            this.groupingEngine.RecordCollapsing += new RecordEventHandler(groupingEngine_RecordCollapsing);
            this.groupingEngine.RecordDeleted += new RecordEventHandler(groupingEngine_RecordDeleted);
            this.groupingEngine.RecordDeleting += new RecordEventHandler(groupingEngine_RecordDeleting);
            this.groupingEngine.RecordExpanded += new RecordEventHandler(groupingEngine_RecordExpanded);
            this.groupingEngine.RecordExpanding += new RecordEventHandler(groupingEngine_RecordExpanding);
            this.groupingEngine.RecordValueChanged += new RecordValueChangedEventHandler(groupingEngine_RecordValueChanged);
            this.groupingEngine.RecordValueChanging += new RecordValueChangingEventHandler(groupingEngine_RecordValueChanging);
            this.groupingEngine.SaveCellFormattedText += new GridCellTextEventHandler(groupingEngine_SaveCellFormattedText);
            this.groupingEngine.SaveCellText += new GridCellTextEventHandler(groupingEngine_SaveCellText);
            this.groupingEngine.SaveValue += new FieldValueEventHandler(groupingEngine_SaveValue);
            this.groupingEngine.SelectedRecordsChanged += new SelectedRecordsChangedEventHandler(groupingEngine_SelectedRecordsChanged);
            this.groupingEngine.SelectedRecordsChanging += new SelectedRecordsChangedEventHandler(groupingEngine_SelectedRecordsChanging);
            this.groupingEngine.SortedItemsInGroup += new GroupEventHandler(groupingEngine_SortedItemsInGroup);
            this.groupingEngine.SortingItemsInGroup += new GroupEventHandler(groupingEngine_SortingItemsInGroup);
            this.groupingEngine.SourceListChanged += new EventHandler(groupingEngine_SourceListChanged);
            this.groupingEngine.SourceListListChanged += new TableListChangedEventHandler(groupingEngine_SourceListListChanged);
            this.groupingEngine.SourceListListChangedCompleted += new TableListChangedEventHandler(groupingEngine_SourceListListChangedCompleted);
            this.groupingEngine.SourceListRecordChanged += new RecordChangedEventHandler(groupingEngine_SourceListRecordChanged);
            this.groupingEngine.SourceListRecordChanging += new RecordChangedEventHandler(groupingEngine_SourceListRecordChanging);
            this.groupingEngine.TableCreated += new EventHandler(groupingEngine_TableCreated);
            this.groupingEngine.TableDescriptorCreated += new EventHandler(groupingEngine_TableDescriptorCreated);
            this.groupingEngine.TableSourceListChanged += new TableEventHandler(groupingEngine_TableSourceListChanged);
        }

        public void HookEngTableEvents()
        {
            this.groupingEngine.Table.AddedRelatedTable += new TableEventHandler(Table_AddedRelatedTable);
            this.groupingEngine.Table.BindingContextChanged += new EventHandler(Table_BindingContextChanged);
            this.groupingEngine.Table.CurrentRecordManagerReset += new EventHandler(Table_CurrentRecordManagerReset);
            this.groupingEngine.Table.DefaultYAmountChanged += new EventHandler(Table_DefaultYAmountChanged);
            this.groupingEngine.Table.Disposed += new EventHandler(Table_Disposed);
            this.groupingEngine.Table.ExceptionRaised += new ExceptionRaisedEventHandler(Table_ExceptionRaised);
            this.groupingEngine.Table.GroupAdded += new GroupEventHandler(Table_GroupAdded);
            this.groupingEngine.Table.GroupCollapsed += new GroupEventHandler(Table_GroupCollapsed);
            this.groupingEngine.Table.GroupCollapsing += new GroupEventHandler(Table_GroupCollapsing);
            this.groupingEngine.Table.GroupExpanded += new GroupEventHandler(Table_GroupExpanded);
            this.groupingEngine.Table.GroupExpanding += new GroupEventHandler(Table_GroupExpanding);
            this.groupingEngine.Table.GroupRemoving += new GroupEventHandler(Table_GroupRemoving);
            this.groupingEngine.Table.GroupSummaryInvalidated += new GroupEventHandler(Table_GroupSummaryInvalidated);
            this.groupingEngine.Table.InvalidatingCounters += new TableEventHandler(Table_InvalidatingCounters);
            this.groupingEngine.Table.InvalidatingSummaries += new TableEventHandler(Table_InvalidatingSummaries);
            //this.groupingEngine.Table.QueryCellStyleInfo += new GridTableCellStyleInfoEventHandler(Table_QueryCellStyleInfo);
            //this.groupingEngine.Table.QueryCoveredRange += new GridTableQueryCoveredRangeEventHandler(Table_QueryCoveredRange);
            //this.groupingEngine.Table.QueryCustomCount += new CustomCountEventHandler(Table_QueryCustomCount);
            //this.groupingEngine.Table.QueryVisibleCustomCount+=new CustomCountEventHandler(Table_QueryVisibleCustomCount);
            this.groupingEngine.Table.RecordCollapsed += new RecordEventHandler(Table_RecordCollapsed);
            this.groupingEngine.Table.RecordCollapsing += new RecordEventHandler(Table_RecordCollapsing);
            this.groupingEngine.Table.RecordDeleted += new RecordEventHandler(Table_RecordDeleted);
            this.groupingEngine.Table.RecordDeleting += new RecordEventHandler(Table_RecordDeleting);
            this.groupingEngine.Table.RecordExpanded += new RecordEventHandler(Table_RecordExpanded);
            this.groupingEngine.Table.RecordExpanding += new RecordEventHandler(Table_RecordExpanding);
            this.groupingEngine.Table.RecordValueChanged += new RecordValueChangedEventHandler(Table_RecordValueChanged);
            this.groupingEngine.Table.RecordValueChanging += new RecordValueChangingEventHandler(Table_RecordValueChanging);
            this.groupingEngine.Table.RemovingRelatedTable += new TableEventHandler(Table_RemovingRelatedTable);
            this.groupingEngine.Table.SelectedRecordsChanged += new SelectedRecordsChangedEventHandler(Table_SelectedRecordsChanged);
            this.groupingEngine.Table.SelectedRecordsChanging += new SelectedRecordsChangedEventHandler(Table_SelectedRecordsChanging);
            this.groupingEngine.Table.SettingTableDirty += new EventHandler(Table_SettingTableDirty);
            this.groupingEngine.Table.SortedItemsInGroup += new GroupEventHandler(Table_SortedItemsInGroup);
            this.groupingEngine.Table.SortingItemsInGroup += new GroupEventHandler(Table_SortingItemsInGroup);
            this.groupingEngine.Table.SourceListChanged += new TableEventHandler(Table_SourceListChanged);
            this.groupingEngine.Table.SourceListListChanged += new TableListChangedEventHandler(Table_SourceListListChanged);
            this.groupingEngine.Table.SourceListListChangedCompleted += new TableListChangedEventHandler(Table_SourceListListChangedCompleted);
            this.groupingEngine.Table.SourceListRecordChanging += new RecordChangedEventHandler(Table_SourceListRecordChanging);
            this.groupingEngine.Table.SourceListRecordChanged += new RecordChangedEventHandler(Table_SourceListRecordChanged);
        }

        public void UnhookEngEvents()
        {
            this.groupingEngine.BindingContextChanged -= new EventHandler(groupingEngine_BindingContextChanged);
            this.groupingEngine.CategorizedRecords -= new TableEventHandler(groupingEngine_CategorizedRecords);
            this.groupingEngine.CategorizingRecords -= new TableEventHandler(groupingEngine_CategorizingRecords);
            this.groupingEngine.CurrentRecordContextChange -= new CurrentRecordContextChangeEventHandler(groupingEngine_CurrentRecordContextChange);
            this.groupingEngine.CurrentRecordManagerReset -= new TableEventHandler(groupingEngine_CurrentRecordManagerReset);
            this.groupingEngine.ExceptionRaised -= new ExceptionRaisedEventHandler(groupingEngine_ExceptionRaised);
            this.groupingEngine.GroupAdded -= new GroupEventHandler(groupingEngine_GroupAdded);
            this.groupingEngine.GroupCollapsed -= new GroupEventHandler(groupingEngine_GroupCollapsed);
            this.groupingEngine.GroupCollapsing -= new GroupEventHandler(groupingEngine_GroupCollapsing);
            this.groupingEngine.GroupExpanded -= new GroupEventHandler(groupingEngine_GroupExpanded);
            this.groupingEngine.GroupExpanding -= new GroupEventHandler(groupingEngine_GroupExpanding);
            this.groupingEngine.GroupRemoving -= new GroupEventHandler(groupingEngine_GroupRemoving);
            this.groupingEngine.GroupSummaryInvalidated -= new GroupEventHandler(groupingEngine_GroupSummaryInvalidated);
            this.groupingEngine.InvalidatingCounters -= new TableEventHandler(groupingEngine_InvalidatingCounters);
            this.groupingEngine.InvalidatingSummaries -= new TableEventHandler(groupingEngine_InvalidatingSummaries);
            this.groupingEngine.PropertyChanged -= new DescriptorPropertyChangedEventHandler(groupingEngine_PropertyChanged);
            this.groupingEngine.PropertyChanging -= new DescriptorPropertyChangedEventHandler(groupingEngine_PropertyChanging);
            this.groupingEngine.QueryAddColumn -= new GridQueryAddColumnEventHandler(groupingEngine_QueryAddColumn);
            this.groupingEngine.QueryAddRelation -= new QueryAddRelationEventHandler(groupingEngine_QueryAddRelation);
            this.groupingEngine.QueryAddVisibleColumn -= new GridQueryAddVisibleColumnEventHandler(groupingEngine_QueryAddVisibleColumn);
            this.groupingEngine.QueryCellFormattedText -= new GridCellTextEventHandler(groupingEngine_QueryCellFormattedText);
            this.groupingEngine.QueryCellStyleInfo -= new GridTableCellStyleInfoEventHandler(groupingEngine_QueryCellStyleInfo);
            this.groupingEngine.QueryCellText -= new GridCellTextEventHandler(groupingEngine_QueryCellText);
            this.groupingEngine.QueryCoveredRange -= new GridTableQueryCoveredRangeEventHandler(groupingEngine_QueryCoveredRange);
            this.groupingEngine.QueryCustomSummary -= new GridQueryCustomSummaryEventHandler(groupingEngine_QueryCustomSummary);
            this.groupingEngine.QueryRecordMeetsFilterCriteria -= new QueryRecordMeetsFilterCriteriaEventHandler(groupingEngine_QueryRecordMeetsFilterCriteria);
            this.groupingEngine.QueryShowField -= new QueryShowFieldEventHandler(groupingEngine_QueryShowField);
            this.groupingEngine.QueryShowNestedPropertiesFields -= new QueryShowNestedPropertiesFieldsEventHandler(groupingEngine_QueryShowNestedPropertiesFields);
            this.groupingEngine.QueryShowRelationDisplayFields -= new QueryShowRelationFieldsEventHandler(groupingEngine_QueryShowRelationDisplayFields);
            this.groupingEngine.QueryValue -= new FieldValueEventHandler(groupingEngine_QueryValue);
            this.groupingEngine.RecordCollapsed -= new RecordEventHandler(groupingEngine_RecordCollapsed);
            this.groupingEngine.RecordCollapsing -= new RecordEventHandler(groupingEngine_RecordCollapsing);
            this.groupingEngine.RecordDeleted -= new RecordEventHandler(groupingEngine_RecordDeleted);
            this.groupingEngine.RecordDeleting -= new RecordEventHandler(groupingEngine_RecordDeleting);
            this.groupingEngine.RecordExpanded -= new RecordEventHandler(groupingEngine_RecordExpanded);
            this.groupingEngine.RecordExpanding -= new RecordEventHandler(groupingEngine_RecordExpanding);
            this.groupingEngine.RecordValueChanged -= new RecordValueChangedEventHandler(groupingEngine_RecordValueChanged);
            this.groupingEngine.RecordValueChanging -= new RecordValueChangingEventHandler(groupingEngine_RecordValueChanging);
            this.groupingEngine.SaveCellFormattedText -= new GridCellTextEventHandler(groupingEngine_SaveCellFormattedText);
            this.groupingEngine.SaveCellText -= new GridCellTextEventHandler(groupingEngine_SaveCellText);
            this.groupingEngine.SaveValue -= new FieldValueEventHandler(groupingEngine_SaveValue);
            this.groupingEngine.SelectedRecordsChanged -= new SelectedRecordsChangedEventHandler(groupingEngine_SelectedRecordsChanged);
            this.groupingEngine.SelectedRecordsChanging -= new SelectedRecordsChangedEventHandler(groupingEngine_SelectedRecordsChanging);
            this.groupingEngine.SortedItemsInGroup -= new GroupEventHandler(groupingEngine_SortedItemsInGroup);
            this.groupingEngine.SortingItemsInGroup -= new GroupEventHandler(groupingEngine_SortingItemsInGroup);
            this.groupingEngine.SourceListChanged -= new EventHandler(groupingEngine_SourceListChanged);
            this.groupingEngine.SourceListListChanged -= new TableListChangedEventHandler(groupingEngine_SourceListListChanged);
            this.groupingEngine.SourceListListChangedCompleted -= new TableListChangedEventHandler(groupingEngine_SourceListListChangedCompleted);
            this.groupingEngine.SourceListRecordChanged -= new RecordChangedEventHandler(groupingEngine_SourceListRecordChanged);
            this.groupingEngine.SourceListRecordChanging -= new RecordChangedEventHandler(groupingEngine_SourceListRecordChanging);
            this.groupingEngine.TableCreated -= new EventHandler(groupingEngine_TableCreated);
            this.groupingEngine.TableDescriptorCreated -= new EventHandler(groupingEngine_TableDescriptorCreated);
            this.groupingEngine.TableSourceListChanged -= new TableEventHandler(groupingEngine_TableSourceListChanged);
        }

        public void UnhookEngTableEvents()
        {
            this.groupingEngine.Table.AddedRelatedTable -= new TableEventHandler(Table_AddedRelatedTable);
            this.groupingEngine.Table.BindingContextChanged -= new EventHandler(Table_BindingContextChanged);
            this.groupingEngine.Table.CurrentRecordContextChange -= new CurrentRecordContextChangeEventHandler(Table_CurrentRecordContextChange);
            this.groupingEngine.Table.DefaultYAmountChanged -= new EventHandler(Table_DefaultYAmountChanged);
            this.groupingEngine.Table.Disposed -= new EventHandler(Table_Disposed);
            this.groupingEngine.Table.ExceptionRaised -= new ExceptionRaisedEventHandler(Table_ExceptionRaised);
            this.groupingEngine.Table.GroupAdded -= new GroupEventHandler(Table_GroupAdded);
            this.groupingEngine.Table.GroupCollapsed -= new GroupEventHandler(Table_GroupCollapsed);
            this.groupingEngine.Table.GroupCollapsing -= new GroupEventHandler(Table_GroupCollapsing);
            this.groupingEngine.Table.GroupExpanded -= new GroupEventHandler(Table_GroupExpanded);
            this.groupingEngine.Table.GroupExpanding -= new GroupEventHandler(Table_GroupExpanding);
            this.groupingEngine.Table.GroupRemoving -= new GroupEventHandler(Table_GroupRemoving);
            this.groupingEngine.Table.GroupSummaryInvalidated -= new GroupEventHandler(Table_GroupSummaryInvalidated);
            this.groupingEngine.Table.InvalidatingCounters -= new TableEventHandler(Table_InvalidatingCounters);
            this.groupingEngine.Table.InvalidatingSummaries -= new TableEventHandler(Table_InvalidatingSummaries);
            this.groupingEngine.Table.QueryCellStyleInfo -= new GridTableCellStyleInfoEventHandler(Table_QueryCellStyleInfo);
            this.groupingEngine.Table.QueryCustomCount -= new CustomCountEventHandler(Table_QueryCustomCount);
            this.groupingEngine.Table.QueryCoveredRange -= new GridTableQueryCoveredRangeEventHandler(Table_QueryCoveredRange);
            this.groupingEngine.Table.QueryVisibleCustomCount -= new CustomCountEventHandler(Table_QueryVisibleCustomCount);
            this.groupingEngine.Table.RecordCollapsed -= new RecordEventHandler(Table_RecordCollapsed);
            this.groupingEngine.Table.RecordCollapsing -= new RecordEventHandler(Table_RecordCollapsing);
            this.groupingEngine.Table.RecordDeleted -= new RecordEventHandler(Table_RecordDeleted);
            this.groupingEngine.Table.RecordDeleting -= new RecordEventHandler(Table_RecordDeleting);
            this.groupingEngine.Table.RecordExpanded -= new RecordEventHandler(Table_RecordExpanded);
            this.groupingEngine.Table.RecordExpanding -= new RecordEventHandler(Table_RecordExpanding);
            this.groupingEngine.Table.RecordValueChanged -= new RecordValueChangedEventHandler(Table_RecordValueChanged);
            this.groupingEngine.Table.RecordValueChanging -= new RecordValueChangingEventHandler(Table_RecordValueChanging);
            this.groupingEngine.Table.RemovingRelatedTable -= new TableEventHandler(Table_RemovingRelatedTable);
            this.groupingEngine.Table.SelectedRecordsChanged -= new SelectedRecordsChangedEventHandler(Table_SelectedRecordsChanged);
            this.groupingEngine.Table.SelectedRecordsChanging -= new SelectedRecordsChangedEventHandler(Table_SelectedRecordsChanging);
            this.groupingEngine.Table.SettingTableDirty -= new EventHandler(Table_SettingTableDirty);
            this.groupingEngine.Table.SortedItemsInGroup -= new GroupEventHandler(Table_SortedItemsInGroup);
            this.groupingEngine.Table.SortingItemsInGroup -= new GroupEventHandler(Table_SortingItemsInGroup);
            this.groupingEngine.Table.SourceListChanged -= new TableEventHandler(Table_SourceListChanged);
            this.groupingEngine.Table.SourceListListChanged -= new TableListChangedEventHandler(Table_SourceListListChanged);
            this.groupingEngine.Table.SourceListListChangedCompleted -= new TableListChangedEventHandler(Table_SourceListListChangedCompleted);
            this.groupingEngine.Table.SourceListRecordChanged -= new RecordChangedEventHandler(Table_SourceListRecordChanged);
        }
        # endregion

        private void groupingEngine_BindingContextChanged(object sender, EventArgs e)
        {
            etracer.AppendOutput("BindingContextChanged", e);
        }

        private void groupingEngine_CategorizedRecords(object sender, TableEventArgs e)
        {

            etracer.AppendOutput("CategorizedRecords", e);
        }

        private void groupingEngine_CategorizingRecords(object sender, TableEventArgs e)
        {
            etracer.AppendOutput("CategorizingRecords", e);
        }

        private void groupingEngine_CurrentRecordContextChange(object sender, CurrentRecordContextChangeEventArgs e)
        {
            etracer.AppendOutput("CurrentRecordContextChange", e);
        }

        private void groupingEngine_CurrentRecordManagerReset(object sender, TableEventArgs e)
        {
            etracer.AppendOutput("CurrentRecordManagerReset", e);
        }

        private void groupingEngine_ExceptionRaised(object sender, ExceptionRaisedEventArgs e)
        {
            etracer.AppendOutput("ExceptionRaised", e);

        }

        private void groupingEngine_GroupAdded(object sender, GroupEventArgs e)
        {
            etracer.AppendOutput("GroupAdded", e);
        }

        private void groupingEngine_GroupCollapsed(object sender, GroupEventArgs e)
        {
            etracer.AppendOutput("GroupCollapsed", e);

        }

        private void groupingEngine_GroupCollapsing(object sender, GroupEventArgs e)
        {
            etracer.AppendOutput("GroupCollapsing", e);

        }

        private void groupingEngine_GroupExpanded(object sender, GroupEventArgs e)
        {
            etracer.AppendOutput("GroupExpanded", e);

        }

        private void groupingEngine_GroupExpanding(object sender, GroupEventArgs e)
        {
            etracer.AppendOutput("GroupExpanding", e);

        }

        private void groupingEngine_GroupRemoving(object sender, GroupEventArgs e)
        {
            etracer.AppendOutput("GroupRemoving", e);

        }

        private void groupingEngine_GroupSummaryInvalidated(object sender, GroupEventArgs e)
        {
            etracer.AppendOutput("GroupSummaryInvalidated", e);

        }

        private void groupingEngine_InvalidatingCounters(object sender, TableEventArgs e)
        {
            etracer.AppendOutput("InvalidatingCounters", e);

        }

        private void groupingEngine_InvalidatingSummaries(object sender, TableEventArgs e)
        {
            etracer.AppendOutput("InvalidatingSummaries", e);

        }

        private void groupingEngine_PropertyChanged(object sender, DescriptorPropertyChangedEventArgs e)
        {
            etracer.AppendOutput("PropertyChanged", e);

        }

        private void groupingEngine_PropertyChanging(object sender, DescriptorPropertyChangedEventArgs e)
        {
            etracer.AppendOutput("PropertyChanging", e);

        }

        void groupingEngine_QueryAddColumn(object sender, GridQueryAddColumnEventArgs e)
        {
            etracer.AppendOutput("QueryAddColumn", e);
        }

        private void groupingEngine_QueryAddRelation(object sender, QueryAddRelationEventArgs e)
        {
            etracer.AppendOutput("QueryAddRelation", e);

        }
        void groupingEngine_QueryAddVisibleColumn(object sender, GridQueryAddVisibleColumnEventArgs e)
        {
            etracer.AppendOutput("QueryAddVisibleColumn", e);
        }

        private void groupingEngine_QueryRecordMeetsFilterCriteria(object sender, QueryRecordMeetsFilterCriteriaEventArgs e)
        {
            etracer.AppendOutput("QueryRecordMeetsFilterCriteria", e);

        }
        void groupingEngine_QueryCellFormattedText(object sender, GridCellTextEventArgs e)
        {
            etracer.AppendOutput("QueryCellFormattedText", e);
        }

        void groupingEngine_QueryCellStyleInfo(object sender, GridTableCellStyleInfoEventArgs e)
        {
            etracer.AppendOutput("QueryCellStyleInfo", e);
        }

        void groupingEngine_QueryCellText(object sender, GridCellTextEventArgs e)
        {
            etracer.AppendOutput("QueryCellText", e);
        }

        void groupingEngine_QueryCoveredRange(object sender, GridTableQueryCoveredRangeEventArgs e)
        {
            etracer.AppendOutput("QueryCoveredRange", e);
        }

        void groupingEngine_QueryCustomSummary(object sender, GridQueryCustomSummaryEventArgs e)
        {
            etracer.AppendOutput("QueryCustomSummary", e);
        }

        private void groupingEngine_QueryShowField(object sender, QueryShowFieldEventArgs e)
        {
            etracer.AppendOutput("QueryShowField", e);

        }

        private void groupingEngine_QueryShowNestedPropertiesFields(object sender, QueryShowNestedPropertiesFieldsEventArgs e)
        {
            etracer.AppendOutput("QueryShowNestedPropertiesFields", e);

        }

        private void groupingEngine_QueryShowRelationDisplayFields(object sender, QueryShowRelationFieldsEventArgs e)
        {
            etracer.AppendOutput("QueryShowRelationDisplayFields", e);

        }

        private void groupingEngine_QueryValue(object sender, FieldValueEventArgs e)
        {
            etracer.AppendOutput("QueryValue", e);

        }

        private void groupingEngine_RecordCollapsed(object sender, RecordEventArgs e)
        {
            etracer.AppendOutput("RecordCollapsed", e);

        }

        private void groupingEngine_RecordCollapsing(object sender, RecordEventArgs e)
        {
            etracer.AppendOutput("RecordCollapsing", e);

        }

        private void groupingEngine_RecordDeleted(object sender, RecordEventArgs e)
        {
            etracer.AppendOutput("RecordDeleted", e);

        }

        private void groupingEngine_RecordDeleting(object sender, RecordEventArgs e)
        {
            etracer.AppendOutput("RecordDeleting", e);

        }

        private void groupingEngine_RecordExpanded(object sender, RecordEventArgs e)
        {
            etracer.AppendOutput("RecordExpanded", e);

        }

        private void groupingEngine_RecordExpanding(object sender, RecordEventArgs e)
        {
            etracer.AppendOutput("RecordExpanding", e);

        }

        private void groupingEngine_RecordValueChanged(object sender, RecordValueChangedEventArgs e)
        {
            etracer.AppendOutput("RecordValueChanged", e);

        }

        private void groupingEngine_RecordValueChanging(object sender, RecordValueChangingEventArgs e)
        {
            etracer.AppendOutput("RecordValueChanging", e);

        }

        void groupingEngine_SaveCellFormattedText(object sender, GridCellTextEventArgs e)
        {
            etracer.AppendOutput("SaveCellFormattedText", e);
        }

        void groupingEngine_SaveCellText(object sender, GridCellTextEventArgs e)
        {
            etracer.AppendOutput("SaveCellText", e);
        }

        private void groupingEngine_SaveValue(object sender, FieldValueEventArgs e)
        {
            etracer.AppendOutput("SaveValue", e);

        }

        private void groupingEngine_SelectedRecordsChanged(object sender, SelectedRecordsChangedEventArgs e)
        {
            etracer.AppendOutput("SelectedRecordsChanged", e);

        }

        private void groupingEngine_SelectedRecordsChanging(object sender, SelectedRecordsChangedEventArgs e)
        {
            etracer.AppendOutput("SelectedRecordsChanging", e);

        }

        private void groupingEngine_SortedItemsInGroup(object sender, GroupEventArgs e)
        {
            etracer.AppendOutput("SortedItemsInGroup", e);

        }

        private void groupingEngine_SortingItemsInGroup(object sender, GroupEventArgs e)
        {
            etracer.AppendOutput("SortingItemsInGroup", e);

        }

        private void groupingEngine_SourceListChanged(object sender, EventArgs e)
        {
            etracer.AppendOutput("SourceListChanged", e);

        }

        private void groupingEngine_SourceListListChanged(object sender, TableListChangedEventArgs e)
        {
            etracer.AppendOutput("SourceListListChanged", e);

        }

        private void groupingEngine_SourceListListChangedCompleted(object sender, TableListChangedEventArgs e)
        {
            etracer.AppendOutput("SourceListListChangedCompleted", e);

        }

        private void groupingEngine_SourceListRecordChanged(object sender, RecordChangedEventArgs e)
        {
            etracer.AppendOutput("SourceListRecordChanged", e);

        }

        private void groupingEngine_SourceListRecordChanging(object sender, RecordChangedEventArgs e)
        {
            etracer.AppendOutput("SourceListRecordChanging", e);

        }

        private void groupingEngine_TableCreated(object sender, EventArgs e)
        {
            etracer.AppendOutput("TableCreated", e);

        }

        private void groupingEngine_TableDescriptorCreated(object sender, EventArgs e)
        {
            etracer.AppendOutput("TableDescriptorCreated", e);

        }

        private void groupingEngine_TableSourceListChanged(object sender, TableEventArgs e)
        {
            etracer.AppendOutput("TableSourceListChanged", e);

        }

        private void groupingEngine_DataMemberChanged(object sender, EventArgs e)
        {
            etracer.AppendOutput("DataMemberChanged", e);
        }

        private void groupingEngine_Disposed(object sender, EventArgs e)
        {
            etracer.AppendOutput("Disposed", e);
        }

        private void groupingEngine_ParseCommonFormats(object sender, Syncfusion.Windows.Forms.Grid.GridCellTextEventArgs e)
        {
            etracer.AppendOutput("ParseCommonFormats", e);
        }

        private void groupingEngine_DataSourceChanged(object sender, EventArgs e)
        {
            etracer.AppendOutput("DataSourceChanged", e);
        }

        private void Table_AddedRelatedTable(object sender, TableEventArgs e)
        {
            etracer.AppendOutput("Table:AddedRelatedTable", e);
        }

        private void Table_BindingContextChanged(object sender, EventArgs e)
        {
            etracer.AppendOutput("Table:BindingContextChanged", e);
        }

        private void Table_CurrentRecordContextChange(object sender, CurrentRecordContextChangeEventArgs e)
        {
            etracer.AppendOutput("Table:CurrentRecordContextChange", e);
        }

        void Table_CurrentRecordManagerReset(object sender, EventArgs e)
        {
            etracer.AppendOutput("Table:CurrentRecordManagerReset", e);
        }

        private void Table_DisplayElementChanged(object sender, DisplayElementChangedEventArgs e)
        {
            etracer.AppendOutput("Table:DisplayElementChanged", e);
        }

        void Table_DefaultYAmountChanged(object sender, EventArgs e)
        {
            etracer.AppendOutput("Table:DefaultYAmountChanged", e);
        }

        private void Table_Disposed(object sender, EventArgs e)
        {
            etracer.AppendOutput("Table:Disposed", e);
        }

        private void Table_ExceptionRaised(object sender, ExceptionRaisedEventArgs e)
        {
            etracer.AppendOutput("Table:ExceptionRaised", e);
        }

        private void Table_GroupAdded(object sender, GroupEventArgs e)
        {
            etracer.AppendOutput("Table:GroupAdded", e);
        }

        private void Table_GroupCollapsed(object sender, GroupEventArgs e)
        {
            etracer.AppendOutput("Table:GroupCollapsed", e);
        }

        private void Table_GroupCollapsing(object sender, GroupEventArgs e)
        {
            etracer.AppendOutput("Table:GroupCollapsing", e);
        }

        private void Table_GroupExpanded(object sender, GroupEventArgs e)
        {
            etracer.AppendOutput("Table:GroupExpanded", e);
        }

        private void Table_GroupExpanding(object sender, GroupEventArgs e)
        {
            etracer.AppendOutput("Table:GroupExpanding", e);
        }

        private void Table_GroupRemoving(object sender, GroupEventArgs e)
        {
            etracer.AppendOutput("Table:GroupRemoving", e);
        }

        private void Table_GroupSummaryInvalidated(object sender, GroupEventArgs e)
        {
            etracer.AppendOutput("Table:GroupSummaryInvalidated", e);
        }

        void Table_InvalidatingCounters(object sender, TableEventArgs e)
        {
            etracer.AppendOutput("Table:InvalidatingCounters", e);
        }

        private void Table_InvalidatingSummaries(object sender, TableEventArgs e)
        {
            etracer.AppendOutput("Table:InvalidatingSummaries", e);
        }

        void Table_QueryCellStyleInfo(object sender, GridTableCellStyleInfoEventArgs e)
        {
            etracer.AppendOutput("Table:QueryCellStyleInfo", e);
        }

        private void Table_QueryCustomCount(object sender, CustomCountEventArgs e)
        {
            etracer.AppendOutput("Table:QueryCustomCount", e);
        }

        void Table_QueryCoveredRange(object sender, GridTableQueryCoveredRangeEventArgs e)
        {
            etracer.AppendOutput("Table:QueryCoveredRange", e);
        }

        private void Table_QueryVisibleCustomCount(object sender, CustomCountEventArgs e)
        {
            etracer.AppendOutput("Table:QueryVisibleCustomCount", e);
        }

        private void Table_RecordCollapsed(object sender, RecordEventArgs e)
        {
            etracer.AppendOutput("Table:RecordCollapsed", e);
        }

        private void Table_RecordCollapsing(object sender, RecordEventArgs e)
        {
            etracer.AppendOutput("Table:RecordCollapsing", e);
        }

        private void Table_RecordDeleted(object sender, RecordEventArgs e)
        {
            etracer.AppendOutput("Table:GroupDeleted", e);
        }

        private void Table_RecordDeleting(object sender, RecordEventArgs e)
        {
            etracer.AppendOutput("Table:GroupDeleting", e);
        }

        private void Table_RecordExpanded(object sender, RecordEventArgs e)
        {
            etracer.AppendOutput("Table:RecordExpanded", e);
        }

        private void Table_RecordExpanding(object sender, RecordEventArgs e)
        {
            etracer.AppendOutput("Table:RecordExpanding", e);
        }

        private void Table_RecordValueChanged(object sender, RecordValueChangedEventArgs e)
        {
            etracer.AppendOutput("Table:RecordValueChanged", e);
        }

        private void Table_RecordValueChanging(object sender, RecordValueChangingEventArgs e)
        {
            etracer.AppendOutput("Table:RecordValueChanging", e);
        }

        private void Table_RemovingRelatedTable(object sender, TableEventArgs e)
        {
            etracer.AppendOutput("Table:RemovingRelatedTable", e);
        }

        private void Table_SelectedRecordsChanged(object sender, SelectedRecordsChangedEventArgs e)
        {
            etracer.AppendOutput("Table:SelectedRecordsChanged", e);
        }

        private void Table_SelectedRecordsChanging(object sender, SelectedRecordsChangedEventArgs e)
        {
            etracer.AppendOutput("Table:SelectedRecordsChanging", e);
        }

        private void Table_SettingTableDirty(object sender, EventArgs e)
        {
            etracer.AppendOutput("Table:SettingTableDirty", e);
        }

        private void Table_SortedItemsInGroup(object sender, GroupEventArgs e)
        {
            etracer.AppendOutput("Table:SortedItemsInGroup", e);
        }

        private void Table_SortingItemsInGroup(object sender, GroupEventArgs e)
        {
            etracer.AppendOutput("Table:SortingItemsInGroup", e);
        }

        private void Table_SourceListChanged(object sender, TableEventArgs e)
        {
            etracer.AppendOutput("Table:SourceListChanged", e);
        }

        private void Table_SourceListListChanged(object sender, TableListChangedEventArgs e)
        {
            etracer.AppendOutput("Table:SourceListListChanged", e);
        }

        void Table_SourceListListChangedCompleted(object sender, TableListChangedEventArgs e)
        {
            etracer.AppendOutput("Table:SourceListListChangedCompleted", e);
        }

        void Table_SourceListRecordChanging(object sender, RecordChangedEventArgs e)
        {
            etracer.AppendOutput("Table:SourceListRecordChanging", e);
        }

        private void Table_SourceListRecordChanged(object sender, RecordChangedEventArgs e)
        {
            etracer.AppendOutput("Table:SourceListRecordChanged", e);
        }
    }
}
