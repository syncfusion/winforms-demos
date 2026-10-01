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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Styles;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace HideRowCols
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : GridDemoForm
    {
        int visibleColCount, visibleRowCount;

        #region Constructor
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            this.GridSettings();
            this.SampleCustomization();
            GridControlBase.UseOldHiddenScrollLogic = true;
        }
        #endregion

        #region "Sample Grid Settings"

        /// <summary>
        /// Setting Grid control Properties
        /// </summary>
        private void GridSettings()
        {
            this.gridControl1.BeginUpdate();
            // 2500 x 2500 grid
            visibleColCount = this.gridControl1.ColCount = 2500;
            visibleRowCount = this.gridControl1.RowCount = 2500;

            // Fill the grid
            for (int n = 0; n < gridControl1.ColCount; n++)
            {
                GridStyleInfo style = new GridStyleInfo();
                style.CellValue = n + 1;
                for (int i = 0; i < gridControl1.RowCount; i++)
                {
                    this.gridControl1.SetCellInfo(i + 1, n + 1, style, StyleModifyType.Copy, true, true);
                }
            }

            this.gridControl1.ListBoxSelectionMode = SelectionMode.One;
            gridControl1.CurrentCell.MoveTo(1, 1);
            this.gridControl1.EndUpdate();
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);

            //tab key navigation set as false to move the next control
            this.gridControl1.WantTabKey = false;
            this.gridRecordNavigationControl1.PaneCreated += gridRecordNavigationControl1_PaneCreated;
        }

        void gridRecordNavigationControl1_PaneCreated(object sender, SplitterPaneEventArgs e)
        {
            GridControl grid = (GridControl)e.Control;
            grid.WantTabKey = false;
        }
        #endregion

        #region "Sample Customizations"

        /// <summary>
        /// Grouping sample Customizations 
        /// </summary>
        private void SampleCustomization()
        {
            //Set Lable text as Row and Col count
            this.label1.Text = "      Row Count: " + (this.gridControl1.RowCount) + "\nColumn Count: " + (this.gridControl1.ColCount);
        }

        #endregion

        #region Event Handlers

        bool flag = true;
        /// <summary>
        /// Hide the Row or Columns
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                if (upDownCol.Value == gridControl1.ColCount && upDownRow.Value == gridControl1.RowCount)
                {
                    MessageBox.Show("The values for row count and column count should be less than grid row count and column count","Info");
                    return;
                }
                this.gridControl1.HideCols.SetRange(1, (int)upDownCol.Value, true);
                this.gridControl1.HideRows.SetRange(1, (int)upDownRow.Value, true);
                this.gridControl1.CurrentCell.MoveTo((int)upDownRow.Value + 1, (int)upDownCol.Value + 1);
                flag = false;
                this.upDownRow.Enabled = false;
                this.upDownCol.Enabled = false;

                btnHide.Text = "Show Hidden Rows and Columns";
                this.label1.Text = "       Row Count: " + (gridControl1.RowCount - upDownRow.Value) + "\n  Column Count: " + (gridControl1.ColCount - upDownCol.Value);
            }
            else
            {
                this.gridControl1.HideCols.SetRange(1, (int)upDownCol.Value, false);
                this.gridControl1.HideRows.SetRange(1, (int)upDownRow.Value, false);
                this.gridControl1.CurrentCell.MoveTo(1, 1);
                this.gridControl1.ScrollCellInView(1, 1, GridScrollCurrentCellReason.MoveTo);
                this.upDownCol.Value = 0;
                this.upDownRow.Value = 0;
                flag = true;
                this.upDownRow.Enabled = true;
                this.upDownCol.Enabled = true;
                btnHide.Text = "Hide Rows and Columns";
                this.label1.Text = "       Row Count: " + (gridControl1.RowCount - upDownRow.Value) + "\n  Column Count: " + (gridControl1.ColCount - upDownCol.Value);
            }
            this.gridControl1.Refresh();
        }

        #endregion
    }
}