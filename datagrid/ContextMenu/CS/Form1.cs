#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Data;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Interactivity;

namespace ContextMenu
{
    public partial class Form1 : Form
    {
        #region Fields
        OrderInfoCollection orderInfo;
        SfDataGrid grid = null;
        SummaryRecordEntry summary = null;
        GridColumn column = null;
        int row = -1;
        int columnIndex = -1;
        object record = null;
        Group group = null;

        ContextMenuStrip groupCaptionContextMenu;
        ContextMenuStrip tableSummaryContextMenu;
        ContextMenuStrip groupSummaryContextMenu;
        ContextMenuStrip columnHeaderContextMenu;
        ContextMenuStrip rowHeaderContextMenu;
        ContextMenuStrip recordContextMenu;
        ContextMenuStrip groupDropAreaContextMenu;
        ContextMenuStrip groupDropItemContextMenu;
       
        #endregion

        #region Constructor
        public Form1()
        {
            InitializeComponent();
            orderInfo = new OrderInfoCollection();

            #region DataGrid Customizations

            this.sfDataGrid1.DataSource = orderInfo.OrdersListDetails;
            GroupColumnDescription groupColumnDescription = new GroupColumnDescription();
            groupColumnDescription.ColumnName = "ProductName";
            this.sfDataGrid1.GroupColumnDescriptions.Add(groupColumnDescription);
            this.sfDataGrid1.CopyOption = CopyOptions.CopyData | CopyOptions.CutData;
            this.sfDataGrid1.GroupColumnDescriptions.CollectionChanged += GroupColumnDescriptions_CollectionChanged;

            //Table Summary
            this.sfDataGrid1.TableSummaryRows.Add(new GridTableSummaryRow()
            {
                Position = VerticalPosition.Bottom,
                ShowSummaryInRow = false,
                SummaryColumns = new ObservableCollection<ISummaryColumn>()
                    {
                        new GridSummaryColumn()
                        {
                            Name = "UnitPrice",
                            MappingName = "UnitPrice",
                            Format ="Count : {Count}",
                            SummaryType = SummaryType.Int32Aggregate
                        },
                    }
            });


            //Group Summary
            sfDataGrid1.GroupSummaryRows.Clear();
            sfDataGrid1.GroupSummaryRows.Add(new GridSummaryRow()
            {
                ShowSummaryInRow = false,
                SummaryColumns = new ObservableCollection<ISummaryColumn>()
                {
                    new GridSummaryColumn() { MappingName = "UnitPrice",
                        SummaryType = SummaryType.Int32Aggregate,
                        Format = "Sum : {Sum}",
                        Name = "FirstColumn",
            }}
            });

            #endregion

            #region GroupDropAreaContextMenu
            groupDropAreaContextMenu = new ContextMenuStrip();
            groupDropAreaContextMenu.Items.Add("Hide GroupDropArea", null, OnHideGroupDropAreaClick);
            groupDropAreaContextMenu.Items.Add("Expand All", null, OnExpandAllClick);
            groupDropAreaContextMenu.Items.Add("Collapse All", null, OnCollapseAllClick);
            groupDropAreaContextMenu.Items.Add("Clear Groups", null, OnClearGroupsClick);
            groupDropAreaContextMenu.Items[1].Enabled = false;
            groupDropAreaContextMenu.Opening += GroupDropAreaContextMenu_Opening;
            this.sfDataGrid1.GroupDropAreaContextMenu = groupDropAreaContextMenu;
            #endregion

            #region GroupDropAreaItemContextMenu
            groupDropItemContextMenu = new ContextMenuStrip();
            groupDropItemContextMenu.Items.Add("Expand All", null, OnItemExpandAllClick);
            groupDropItemContextMenu.Items.Add("Collapse All", null, OnItemCollapseAllClick);
            groupDropItemContextMenu.Items.Add("Clear Group", null, OnGroupClearClick);
            groupDropItemContextMenu.Items[0].Enabled = false;
            this.sfDataGrid1.GroupDropAreaItemContextMenu = groupDropItemContextMenu;
            #endregion

            #region ColumnHeaderContextMenu
            columnHeaderContextMenu = new ContextMenuStrip();
#if !NETCORE
            columnHeaderContextMenu.Items.Add("Sort Ascending", Image.FromFile(@"../../Images/sortasc.png"), OnSortAscendingClick);
            columnHeaderContextMenu.Items.Add("Sort Descending", Image.FromFile(@"../../Images/sortdesc.png"), OnSortDescendingClick);
#else
            columnHeaderContextMenu.Items.Add("Sort Ascending", Image.FromFile("../../../Images/sortasc.png"), OnSortAscendingClick);
            columnHeaderContextMenu.Items.Add("Sort Descending", Image.FromFile("../../../Images/sortdesc.png"), OnSortDescendingClick);
#endif
            columnHeaderContextMenu.Items.Add("Clear Sorting", null, OnClearSortingClick);
            columnHeaderContextMenu.Items.Add("Show GroupDropArea", null, OnShowGroupDropAreaClick);
            columnHeaderContextMenu.Opening += ColumnHeaderContextMenu_Opening;
            this.sfDataGrid1.ColumnHeaderContextMenu = columnHeaderContextMenu;
            #endregion

            #region GroupCaptionContextMenu
            groupCaptionContextMenu = new ContextMenuStrip();
            groupCaptionContextMenu.Items.Add("Expand", null, OnExpandClick);
            groupCaptionContextMenu.Items.Add("Collapse", null, OnCollapseClick);
            groupCaptionContextMenu.Opening += GroupCaptionContextMenu_Opening;
            this.sfDataGrid1.GroupCaptionContextMenu = groupCaptionContextMenu;
            #endregion

            #region GroupSummaryContextMenu
            groupSummaryContextMenu = new ContextMenuStrip();
            groupSummaryContextMenu.Items.Add("Sum", null, OnGroupSummarySumClick);
            groupSummaryContextMenu.Items.Add("Count", null, OnGroupSummaryCountClick);
            groupSummaryContextMenu.Items[0].Enabled = false;
            this.sfDataGrid1.GroupSummaryContextMenu = groupSummaryContextMenu;
            #endregion

            #region RecordContextMenu
            recordContextMenu = new ContextMenuStrip();
            recordContextMenu.Items.Add("Cut", null, Cut_Click);
            recordContextMenu.Items.Add("Copy", null, Copy_Click);
            recordContextMenu.Items.Add("Paste", null, Paste_Click);
            recordContextMenu.Items[2].Enabled = false;
            this.sfDataGrid1.RecordContextMenu = recordContextMenu;

            #endregion

            #region TableSummaryContextMenu
            tableSummaryContextMenu = new ContextMenuStrip();
            tableSummaryContextMenu.Items.Add("Sum", null, OnTableSummarySumClick);
            tableSummaryContextMenu.Items.Add("Count", null, OnTableSummaryCountClick);
            tableSummaryContextMenu.Items[1].Enabled = false;
            this.sfDataGrid1.TableSummaryContextMenu = tableSummaryContextMenu;

            #endregion

            #region RowHeaderContextMenu

            rowHeaderContextMenu = new ContextMenuStrip();
            rowHeaderContextMenu.Items.Add("Delete", null, OnDeleteClick);
            this.sfDataGrid1.RowHeaderContextMenu = rowHeaderContextMenu;
            #endregion

            this.sfDataGrid1.ContextMenuOpening += SfDataGrid1_ContextMenuOpening;
            this.sfDataGrid1.ContextMenuOpened += SfDataGrid1_ContextMenuOpened;
        }

        #endregion

        #region ContextMenuOptions
        void OnDeleteClick(object sender, EventArgs e)
        {
            if (grid != null)
            {
                if (grid.GroupColumnDescriptions.Count > 0)
                    row -= grid.GroupColumnDescriptions.Count;
                if (!(record is SummaryRecordEntry) && !(record is Group) && row > 0)
                {
                    orderInfo.OrdersListDetails.RemoveAt(grid.TableControl.ResolveToRecordIndex(row));
                    grid.TableControl.Invalidate();
                }
            }
        }

        void OnGroupSummarySumClick(object sender, EventArgs e)
        {
            if (grid != null && summary != null)
            {
                sfDataGrid1.GroupSummaryRows.Clear();
                sfDataGrid1.GroupSummaryRows.Add(new GridSummaryRow()
                {
                    ShowSummaryInRow = false,
                    SummaryColumns = new ObservableCollection<ISummaryColumn>() { new GridSummaryColumn()
                    {
                        MappingName = "UnitPrice",
                        SummaryType = SummaryType.Int32Aggregate,
                        Format = "Sum : {Sum}",
                        Name = "FirstColumn",
                    } }
                });

                groupSummaryContextMenu.Items[0].Enabled = false;
                groupSummaryContextMenu.Items[1].Enabled = true;
            }
        }

        void OnGroupSummaryCountClick(object sender, EventArgs e)
        {
            if (grid != null && summary != null)
            {
                sfDataGrid1.GroupSummaryRows.Clear();
                sfDataGrid1.GroupSummaryRows.Add(new GridSummaryRow()
                {
                    ShowSummaryInRow = false,
                    SummaryColumns = new ObservableCollection<ISummaryColumn>() { new GridSummaryColumn()
                    {
                        MappingName = "UnitPrice",
                        SummaryType = SummaryType.Int32Aggregate,
                        Format = "Count : {Count}",
                        Name = "FirstColumn",
                    }}
                });

                groupSummaryContextMenu.Items[1].Enabled = false;
                groupSummaryContextMenu.Items[0].Enabled = true;
            }
        }

        void OnTableSummarySumClick(object sender, EventArgs e)
        {
            if (grid != null && summary != null)
            {
                this.sfDataGrid1.TableSummaryRows.Clear();
                this.sfDataGrid1.TableSummaryRows.Add(new GridTableSummaryRow()
                {
                    Position = VerticalPosition.Bottom,
                    ShowSummaryInRow = false,
                    SummaryColumns = new ObservableCollection<ISummaryColumn>()
                    {
                        new GridSummaryColumn()
                        {
                            Name = "UnitPrice",
                            MappingName = "UnitPrice",
                            Format ="Sum : {Sum}",
                            SummaryType = SummaryType.Int32Aggregate
                        },
                    }
                });

                tableSummaryContextMenu.Items[0].Enabled = false;
                tableSummaryContextMenu.Items[1].Enabled = true;
            }
        }


        void OnTableSummaryCountClick(object sender, EventArgs e)
        {
            if (grid != null && summary != null)
            {
                this.sfDataGrid1.TableSummaryRows.Clear();
                this.sfDataGrid1.TableSummaryRows.Add(new GridTableSummaryRow()
                {
                    Position = VerticalPosition.Bottom,
                    ShowSummaryInRow = false,
                    SummaryColumns = new ObservableCollection<ISummaryColumn>()
                    {
                        new GridSummaryColumn()
                        {
                            Name = "UnitPrice",
                            MappingName = "UnitPrice",
                            Format ="Count : {Count}",
                            SummaryType = SummaryType.Int32Aggregate
                        },
                    }
                });

                tableSummaryContextMenu.Items[1].Enabled = false;
                tableSummaryContextMenu.Items[0].Enabled = true;

            }
        }

        void OnExpandClick(object sender, EventArgs e)
        {
            if (grid != null && group != null)
            {
                grid.ExpandGroup(group);
            }
        }

        void OnCollapseClick(object sender, EventArgs e)
        {
            if (grid != null && group != null)
            {
                grid.CollapseGroup(group);
            }
        }

        void OnExpandAllClick(object sender, EventArgs e)
        {
            if (grid != null)
            {
                grid.ExpandAllGroup();
                groupDropAreaContextMenu.Items[1].Enabled = false;
                groupDropAreaContextMenu.Items[2].Enabled = true;
            }
        }

        void OnItemExpandAllClick(object sender, EventArgs e)
        {
            if (grid != null)
            {
                grid.ExpandAllGroup();
                groupDropItemContextMenu.Items[0].Enabled = false;
                groupDropItemContextMenu.Items[1].Enabled = true;
            }
        }

        void OnClearGroupsClick(object sender, EventArgs e)
        {
            if (grid != null)
            {
                grid.ClearGrouping();
                groupDropAreaContextMenu.Items[3].Enabled = false;
            }
        }
        void OnCollapseAllClick(object sender, EventArgs e)
        {
            if (grid != null)
            {
                grid.CollapseAllGroup();
                groupDropAreaContextMenu.Items[2].Enabled = false;
                groupDropAreaContextMenu.Items[1].Enabled = true;
            }
        }

        void OnItemCollapseAllClick(object sender, EventArgs e)
        {
            if (grid != null)
            {
                grid.CollapseAllGroup();
                groupDropItemContextMenu.Items[1].Enabled = false;
                groupDropItemContextMenu.Items[0].Enabled = true;
            }
        }

        void OnHideGroupDropAreaClick(object sender, EventArgs e)
        {
            if (grid != null)
            {
                grid.ShowGroupDropArea = false;
            }
        }

        void OnShowGroupDropAreaClick(object sender, EventArgs e)
        {
            if(grid!=null)
            {
                grid.ShowGroupDropArea = true;
            }
        }

        void OnSortAscendingClick(object sender, EventArgs e)
        {
            if (grid != null && column != null)
            {
                grid.SortColumnDescriptions.Clear();
                grid.SortColumnDescriptions.Add(new SortColumnDescription() { ColumnName = column.MappingName, SortDirection = System.ComponentModel.ListSortDirection.Ascending });
            }
        }

        void OnClearSortingClick(object sender, EventArgs e)
        {
            if (grid != null && column != null)
            {
                grid.SortColumnDescriptions.Remove(grid.SortColumnDescriptions.FirstOrDefault(x => x.ColumnName == column.MappingName));
            }
        }

        void OnSortDescendingClick(object sender, EventArgs e)
        {
            if (grid != null && column != null)
            {
                grid.SortColumnDescriptions.Clear();
                grid.SortColumnDescriptions.Add(new SortColumnDescription() { ColumnName = column.MappingName, SortDirection = System.ComponentModel.ListSortDirection.Descending });
            }
        }

        void OnGroupClearClick(object sender, EventArgs e)
        {
            if (grid != null && column != null)
            {
               grid.GroupColumnDescriptions.Remove(grid.GroupColumnDescriptions.FirstOrDefault(x => x.ColumnName == column.MappingName));
            }
        }

        #endregion

        #region ContextMenuEvents

        private void GroupDropAreaContextMenu_Opening(object sender, CancelEventArgs e)
        {
            if (this.sfDataGrid1.GroupColumnDescriptions.Count == 0)
            {
                groupDropAreaContextMenu.Items[1].Enabled = false;
                groupDropAreaContextMenu.Items[2].Enabled = false;
                groupDropAreaContextMenu.Items[3].Enabled = false;

            }
        }

        private void GroupCaptionContextMenu_Opening(object sender, CancelEventArgs e)
        {
            groupCaptionContextMenu.Items[0].Enabled = true;
            groupCaptionContextMenu.Items[1].Enabled = true;

            if (group.IsExpanded)
            {
                groupCaptionContextMenu.Items[0].Enabled = false;
            }
            else
            {
                groupCaptionContextMenu.Items[1].Enabled = false;
            }
        }

        private void GroupColumnDescriptions_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (this.sfDataGrid1.GroupColumnDescriptions.Count > 0)
                groupDropAreaContextMenu.Items[3].Enabled = true;
            else if (this.sfDataGrid1.GroupColumnDescriptions.Count == 0)
                groupDropAreaContextMenu.Items[3].Enabled = false;
        }

        private void ColumnHeaderContextMenu_Opening(object sender, CancelEventArgs e)
        {
            columnHeaderContextMenu.Items[0].Enabled = true;
            columnHeaderContextMenu.Items[1].Enabled = true;
            columnHeaderContextMenu.Items[2].Enabled = false;
            columnHeaderContextMenu.Items[3].Enabled = true;

            if (this.sfDataGrid1.ShowGroupDropArea)
                columnHeaderContextMenu.Items[3].Enabled = false;

            foreach (SortColumnDescription x in this.sfDataGrid1.SortColumnDescriptions)
            {
                if (x.ColumnName == column.MappingName)
                {

                    if (x.SortDirection == ListSortDirection.Ascending)
                    {
                        columnHeaderContextMenu.Items[0].Enabled = false;
                        columnHeaderContextMenu.Items[1].Enabled = true;
                    }
                    else
                    {
                        columnHeaderContextMenu.Items[1].Enabled = false;
                        columnHeaderContextMenu.Items[0].Enabled = true;
                    }
                    columnHeaderContextMenu.Items[2].Enabled = true;
                }
            }
        }

        private void Cut_Click(Object sender, EventArgs e)
        {
            this.sfDataGrid1.ClipboardController.Cut();
            recordContextMenu.Items[2].Enabled = true;
        }

        private void Copy_Click(Object sender, EventArgs e)
        {
            this.sfDataGrid1.ClipboardController.Copy();
            recordContextMenu.Items[2].Enabled = true;
        }

        private void Paste_Click(Object sender, EventArgs e)
        {
            this.sfDataGrid1.ClipboardController.Paste();
        }

        private void SfDataGrid1_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
        {
            if (e.ContextMenutype == ContextMenuType.GroupCaption)
            {
                grid = (e.ContextMenuInfo as RowContextMenuInfo).DataGrid;
                group = (e.ContextMenuInfo as RowContextMenuInfo).Row as Group;
            }
            if (e.ContextMenutype == ContextMenuType.GroupDropAreaItem || e.ContextMenutype == ContextMenuType.ColumnHeader)
            {
                grid = (e.ContextMenuInfo as ColumnContextMenuInfo).DataGrid;
                column = (e.ContextMenuInfo as ColumnContextMenuInfo).Column;
            }
            if (e.ContextMenutype == ContextMenuType.GroupDropArea)
            {
                grid = (e.ContextMenuInfo as GroupDropAreaContextMenuInfo).DataGrid;
            }

            if (e.ContextMenutype == ContextMenuType.GroupSummary || e.ContextMenutype == ContextMenuType.TableSummary)
            {
                grid = (e.ContextMenuInfo as RowContextMenuInfo).DataGrid;
                summary = (e.ContextMenuInfo as RowContextMenuInfo).Row as SummaryRecordEntry;
            }

            if (e.ContextMenutype == ContextMenuType.Record || e.ContextMenutype == ContextMenuType.RowHeader)
            {
                grid = (e.ContextMenuInfo as RowContextMenuInfo).DataGrid;
                row = e.RowIndex;
                columnIndex = e.ColumnIndex;
                record = (e.ContextMenuInfo as RowContextMenuInfo).Row;
            }
        }

        private void SfDataGrid1_ContextMenuOpened(object sender, ContextMenuOpenedEventArgs e)
        {
        }

        #endregion

    }


}
