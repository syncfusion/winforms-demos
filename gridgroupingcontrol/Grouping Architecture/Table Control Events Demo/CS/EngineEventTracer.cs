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
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid.Grouping;

namespace TableControlEvents
{
    public class EngineEventTracer
    {
        GridEngine groupingEngine;
        ListBox output;

        public EngineEventTracer(GridEngine groupingEngine, ListBox output)
        {
            this.output = output;
            this.groupingEngine = groupingEngine;
        }
        string lastLine = "";
        void AppendOutput(string name, EventArgs e)
        {
            string s = name;
            try
            {
                s += "  " + e.ToString();
            }
            catch (Exception ex)
            {

                s += "  " + "Record deleted: " + ex.InnerException.ToString();
            }
            if (s.Length > 0)
            {
                if (s != lastLine)
                {
                    lastLine = s;
                    output.SelectedIndex = -1;
                    output.Items.Add(s);
                    output.TopIndex = Math.Max(0, output.Items.Count - (output.Height / output.ItemHeight));
                }
            }
        }

        # region Hook and Unhook Events
        public void HookTableStyleEvents()
        {
            this.groupingEngine.TableControl.BackColorChanged += new EventHandler(TableControl_BackColorChanged);
            this.groupingEngine.TableControl.BackgroundImageChanged += new EventHandler(TableControl_BackgroundImageChanged);
            this.groupingEngine.TableControl.BindingContextChanged += new EventHandler(TableControl_BindingContextChanged);
            this.groupingEngine.TableControl.QueryAllowDragColumn += new GridQueryAllowDragColumnEventHandler(TableControl_QueryAllowDragColumn);
            this.groupingEngine.TableControl.QueryAllowGroupByColumn += new GridQueryAllowGroupByColumnEventHandler(TableControl_QueryAllowGroupByColumn);
            this.groupingEngine.TableControl.QueryAllowSortColumn += new GridQueryAllowSortColumnEventHandler(TableControl_QueryAllowSortColumn);
            this.groupingEngine.TableControl.Resize += new EventHandler(TableControl_Resize);
            this.groupingEngine.TableControl.ResizingColumns += new Syncfusion.Windows.Forms.Grid.GridResizingColumnsEventHandler(TableControl_ResizingColumns);
            this.groupingEngine.TableControl.ResizingRows += new Syncfusion.Windows.Forms.Grid.GridResizingRowsEventHandler(TableControl_ResizingRows);
            this.groupingEngine.TableControl.TextChanged += new EventHandler(TableControl_TextChanged);
            this.groupingEngine.TableControl.TopRowChanged += new Syncfusion.Windows.Forms.Grid.GridRowColIndexChangedEventHandler(TableControl_TopRowChanged);
        }

        public void HookCellEvents()
        {
            this.groupingEngine.TableControl.CellButtonClicked += new Syncfusion.Windows.Forms.Grid.GridCellButtonClickedEventHandler(TableControl_CellButtonClicked);
            this.groupingEngine.TableControl.CellClick += new Syncfusion.Windows.Forms.Grid.GridCellClickEventHandler(TableControl_CellClick);
            this.groupingEngine.TableControl.CellDoubleClick += new Syncfusion.Windows.Forms.Grid.GridCellClickEventHandler(TableControl_CellDoubleClick);
            this.groupingEngine.TableControl.CellDrawn += new Syncfusion.Windows.Forms.Grid.GridDrawCellEventHandler(TableControl_CellDrawn);
        }

        public void HookCurrentCellEvents()
        {
            this.groupingEngine.TableControl.CurrentCellActivated += new EventHandler(TableControl_CurrentCellActivated);
            this.groupingEngine.TableControl.CurrentCellChanged += new EventHandler(TableControl_CurrentCellChanged);
            this.groupingEngine.TableControl.CurrentCellControlGotFocus += new ControlEventHandler(TableControl_CurrentCellControlGotFocus);
            this.groupingEngine.TableControl.CurrentCellControlLostFocus += new ControlEventHandler(TableControl_CurrentCellControlLostFocus);
            this.groupingEngine.TableControl.CurrentCellDeactivated += new Syncfusion.Windows.Forms.Grid.GridCurrentCellDeactivatedEventHandler(TableControl_CurrentCellDeactivated);
            this.groupingEngine.TableControl.CurrentCellKeyPress += new KeyPressEventHandler(TableControl_CurrentCellKeyPress);
            this.groupingEngine.TableControl.CurrentCellStartEditing += new CancelEventHandler(TableControl_CurrentCellStartEditing);
            this.groupingEngine.TableControl.CurrentCellValidated += new EventHandler(TableControl_CurrentCellValidated);
        }

        public void HookGridControlEvents()
        {
            this.groupingEngine.TableControl.Click += new EventHandler(TableControl_Click);
            this.groupingEngine.TableControl.DoubleClick += new EventHandler(TableControl_DoubleClick);
            this.groupingEngine.TableControl.DragDrop += new DragEventHandler(TableControl_DragDrop);
            this.groupingEngine.TableControl.GotFocus += new EventHandler(TableControl_GotFocus);
            this.groupingEngine.TableControl.GridControlMouseDown += new Syncfusion.Windows.Forms.CancelMouseEventHandler(TableControl_GridControlMouseDown);
            this.groupingEngine.TableControl.GridControlMouseUp += new Syncfusion.Windows.Forms.CancelMouseEventHandler(TableControl_GridControlMouseUp);
            this.groupingEngine.TableControl.HorizontalScroll += new ScrollEventHandler(TableControl_HorizontalScroll);
        }

        public void HookKeyEvents()
        {
            this.groupingEngine.TableControl.KeyDown += new KeyEventHandler(TableControl_KeyDown);
            this.groupingEngine.TableControl.KeyPress += new KeyPressEventHandler(TableControl_KeyPress);
            this.groupingEngine.TableControl.KeyUp += new KeyEventHandler(TableControl_KeyUp);
        }

        public void HookMouseEvents()
        {
            this.groupingEngine.TableControl.MouseDown += new MouseEventHandler(TableControl_MouseDown);
            this.groupingEngine.TableControl.MouseLeave += new EventHandler(TableControl_MouseLeave);
            this.groupingEngine.TableControl.MouseUp += new MouseEventHandler(TableControl_MouseUp);
        }

        public void UnHookEvents()
        {
            this.groupingEngine.TableControl.BackColorChanged -= new EventHandler(TableControl_BackColorChanged);
            this.groupingEngine.TableControl.BackgroundImageChanged -= new EventHandler(TableControl_BackgroundImageChanged);
            this.groupingEngine.TableControl.BindingContextChanged -= new EventHandler(TableControl_BindingContextChanged);
            this.groupingEngine.TableControl.CellButtonClicked -= new Syncfusion.Windows.Forms.Grid.GridCellButtonClickedEventHandler(TableControl_CellButtonClicked);
            this.groupingEngine.TableControl.CellClick -= new Syncfusion.Windows.Forms.Grid.GridCellClickEventHandler(TableControl_CellClick);
            this.groupingEngine.TableControl.CellDoubleClick -= new Syncfusion.Windows.Forms.Grid.GridCellClickEventHandler(TableControl_CellDoubleClick);
            this.groupingEngine.TableControl.CellDrawn -= new Syncfusion.Windows.Forms.Grid.GridDrawCellEventHandler(TableControl_CellDrawn);
            this.groupingEngine.TableControl.Click -= new EventHandler(TableControl_Click);
            this.groupingEngine.TableControl.CurrentCellActivated -= new EventHandler(TableControl_CurrentCellActivated);
            this.groupingEngine.TableControl.CurrentCellChanged -= new EventHandler(TableControl_CurrentCellChanged);
            this.groupingEngine.TableControl.CurrentCellControlGotFocus -= new ControlEventHandler(TableControl_CurrentCellControlGotFocus);
            this.groupingEngine.TableControl.CurrentCellControlLostFocus -= new ControlEventHandler(TableControl_CurrentCellControlLostFocus);
            this.groupingEngine.TableControl.CurrentCellDeactivated -= new Syncfusion.Windows.Forms.Grid.GridCurrentCellDeactivatedEventHandler(TableControl_CurrentCellDeactivated);
            this.groupingEngine.TableControl.CurrentCellKeyPress -= new KeyPressEventHandler(TableControl_CurrentCellKeyPress);
            this.groupingEngine.TableControl.CurrentCellStartEditing -= new CancelEventHandler(TableControl_CurrentCellStartEditing);
            this.groupingEngine.TableControl.CurrentCellValidated -= new EventHandler(TableControl_CurrentCellValidated);
            this.groupingEngine.TableControl.DoubleClick -= new EventHandler(TableControl_DoubleClick);
            this.groupingEngine.TableControl.DragDrop -= new DragEventHandler(TableControl_DragDrop);
            this.groupingEngine.TableControl.GotFocus -= new EventHandler(TableControl_GotFocus);
            this.groupingEngine.TableControl.GridControlMouseDown -= new Syncfusion.Windows.Forms.CancelMouseEventHandler(TableControl_GridControlMouseDown);
            this.groupingEngine.TableControl.GridControlMouseUp -= new Syncfusion.Windows.Forms.CancelMouseEventHandler(TableControl_GridControlMouseUp);
            this.groupingEngine.TableControl.HorizontalScroll -= new ScrollEventHandler(TableControl_HorizontalScroll);
            this.groupingEngine.TableControl.KeyDown -= new KeyEventHandler(TableControl_KeyDown);
            this.groupingEngine.TableControl.KeyPress -= new KeyPressEventHandler(TableControl_KeyPress);
            this.groupingEngine.TableControl.KeyUp -= new KeyEventHandler(TableControl_KeyUp);
            this.groupingEngine.TableControl.MouseDown -= new MouseEventHandler(TableControl_MouseDown);
            this.groupingEngine.TableControl.MouseLeave -= new EventHandler(TableControl_MouseLeave);
            this.groupingEngine.TableControl.MouseUp -= new MouseEventHandler(TableControl_MouseUp);
            this.groupingEngine.TableControl.QueryAllowDragColumn -= new GridQueryAllowDragColumnEventHandler(TableControl_QueryAllowDragColumn);
            this.groupingEngine.TableControl.QueryAllowGroupByColumn -= new GridQueryAllowGroupByColumnEventHandler(TableControl_QueryAllowGroupByColumn);
            this.groupingEngine.TableControl.QueryAllowSortColumn -= new GridQueryAllowSortColumnEventHandler(TableControl_QueryAllowSortColumn);
            this.groupingEngine.TableControl.Resize -= new EventHandler(TableControl_Resize);
            this.groupingEngine.TableControl.ResizingColumns -= new Syncfusion.Windows.Forms.Grid.GridResizingColumnsEventHandler(TableControl_ResizingColumns);
            this.groupingEngine.TableControl.ResizingRows -= new Syncfusion.Windows.Forms.Grid.GridResizingRowsEventHandler(TableControl_ResizingRows);
            this.groupingEngine.TableControl.TextChanged -= new EventHandler(TableControl_TextChanged);
            this.groupingEngine.TableControl.TopRowChanged -= new Syncfusion.Windows.Forms.Grid.GridRowColIndexChangedEventHandler(TableControl_TopRowChanged);
        }
        # endregion

        private void TableControl_BackColorChanged(object sender, EventArgs e)
        {
            AppendOutput("BackColorChanged", e);
        }

        private void TableControl_BackgroundImageChanged(object sender, EventArgs e)
        {
            AppendOutput("BackgroundImageChanged", e);
        }

        private void TableControl_BindingContextChanged(object sender, EventArgs e)
        {
            AppendOutput("BindingContextChanged", e);
        }

        private void TableControl_CellButtonClicked(object sender, Syncfusion.Windows.Forms.Grid.GridCellButtonClickedEventArgs e)
        {
            AppendOutput("CellButtonClicked", e);
        }

        private void TableControl_CellClick(object sender, Syncfusion.Windows.Forms.Grid.GridCellClickEventArgs e)
        {
            AppendOutput("CellClick", e);
        }

        private void TableControl_CellDoubleClick(object sender, Syncfusion.Windows.Forms.Grid.GridCellClickEventArgs e)
        {
            AppendOutput("CellDoubleClick", e);
        }

        private void TableControl_CellDrawn(object sender, Syncfusion.Windows.Forms.Grid.GridDrawCellEventArgs e)
        {
            AppendOutput("CellDrawn", e);
        }

        private void TableControl_Click(object sender, EventArgs e)
        {
            AppendOutput("Click", e);
        }

        private void TableControl_CurrentCellActivated(object sender, EventArgs e)
        {
            AppendOutput("CurrentCellActivated", e);
        }

        private void TableControl_CurrentCellChanged(object sender, EventArgs e)
        {
            AppendOutput("CurrentCellChanged", e);
        }

        private void TableControl_CurrentCellControlGotFocus(object sender, ControlEventArgs e)
        {
            AppendOutput("CurrentCellGotFocus", e);
        }

        private void TableControl_CurrentCellControlLostFocus(object sender, ControlEventArgs e)
        {
            AppendOutput("CurrentCellLostFocus", e);
        }

        private void TableControl_CurrentCellDeactivated(object sender, Syncfusion.Windows.Forms.Grid.GridCurrentCellDeactivatedEventArgs e)
        {
            AppendOutput("CurrentCellDeactivated", e);
        }

        private void TableControl_CurrentCellKeyPress(object sender, KeyPressEventArgs e)
        {
            AppendOutput("CurrentCellKeyPress", e);
        }

        private void TableControl_CurrentCellStartEditing(object sender, CancelEventArgs e)
        {
            AppendOutput("CurrentCellStartEditing", e);
        }

        private void TableControl_CurrentCellValidated(object sender, EventArgs e)
        {
            AppendOutput("CurrentCellValidated", e);
        }

        private void TableControl_DoubleClick(object sender, EventArgs e)
        {
            AppendOutput("DoubleClick", e);
        }

        private void TableControl_DragDrop(object sender, DragEventArgs e)
        {
            AppendOutput("DragDrop", e);

        }

        private void TableControl_GotFocus(object sender, EventArgs e)
        {
            AppendOutput("GotFocus", e);
        }

        private void TableControl_GridControlMouseDown(object sender, Syncfusion.Windows.Forms.CancelMouseEventArgs e)
        {
            AppendOutput("GridControlMouseDown", e);
        }

        private void TableControl_GridControlMouseUp(object sender, Syncfusion.Windows.Forms.CancelMouseEventArgs e)
        {
            AppendOutput("GridControlMouseUp", e);
        }

        private void TableControl_HorizontalScroll(object sender, ScrollEventArgs e)
        {
            AppendOutput("HorizontalScroll", e);
        }

        private void TableControl_KeyDown(object sender, KeyEventArgs e)
        {
            AppendOutput("KeyDown", e);
        }

        private void TableControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            AppendOutput("KeyPress", e);
        }

        private void TableControl_KeyUp(object sender, KeyEventArgs e)
        {
            AppendOutput("KeyUp", e);
        }

        private void TableControl_MouseDown(object sender, MouseEventArgs e)
        {
            AppendOutput("MouseDown", e);
        }

        private void TableControl_MouseLeave(object sender, EventArgs e)
        {
            AppendOutput("MouseLeave", e);
        }

        private void TableControl_MouseUp(object sender, MouseEventArgs e)
        {
            AppendOutput("MouseUp", e);
        }

        private void TableControl_QueryAllowDragColumn(object sender, GridQueryAllowDragColumnEventArgs e)
        {
            AppendOutput("QueryAllowDragColumn", e);
        }

        private void TableControl_QueryAllowGroupByColumn(object sender, GridQueryAllowGroupByColumnEventArgs e)
        {
            AppendOutput("QueryAllowGroupByColumn", e);
        }

        private void TableControl_QueryAllowSortColumn(object sender, GridQueryAllowSortColumnEventArgs e)
        {
            AppendOutput("QueryAllowSortColumn", e);
        }

        private void TableControl_Resize(object sender, EventArgs e)
        {
            AppendOutput("Resize", e);
        }

        private void TableControl_ResizingColumns(object sender, Syncfusion.Windows.Forms.Grid.GridResizingColumnsEventArgs e)
        {
            AppendOutput("ResizingColumns", e);
        }

        private void TableControl_ResizingRows(object sender, Syncfusion.Windows.Forms.Grid.GridResizingRowsEventArgs e)
        {
            AppendOutput("ResizingRows", e);
        }

        private void TableControl_TextChanged(object sender, EventArgs e)
        {
            AppendOutput("TextChanged", e);
        }

        private void TableControl_TopRowChanged(object sender, Syncfusion.Windows.Forms.Grid.GridRowColIndexChangedEventArgs e)
        {
            AppendOutput("TopRowChanged", e);
        }
    }
}
