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
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace ErrorProvider
{
    public partial class Form1 : GridDemoForm
    {
        #region "Constructor"

        public Form1()
        {
            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            this.GridSettings();
        }

        #endregion

        #region "Grid Settings"
        /// <summary>
        /// Grid Settings for better look and feel
        /// </summary>
        private void GridSettings()
        {

            this.gridControl1.GridVisualStyles = GridVisualStyles.Office2007Blue;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.gridControl1.GridVisualStyles = GridVisualStyles.Metro;

            //Used to set default row height
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);

            this.gridControl1.Model.Options.DisplayEmptyColumns = true;
            this.gridControl1.Model.Options.DisplayEmptyRows = true;

            //tab key navigation set as false to move the next control
            this.gridControl1.WantTabKey = false;

        }
        #endregion

        #region EventHandlers
        private void Form1_Load(object sender, EventArgs e)
        {
            this.gridControl1.Model.PopulateValues(GridRangeInfo.Cells(1, 1, 15, 15), GetTable());
            this.gridControl1.ColStyles[1].CellValueType = typeof(Int32);
            this.gridControl1.ColStyles[2].CellValueType = typeof(DateTime);
            this.gridControl1.ColCount = 3;
            this.gridControl1.RowCount = 16;
            //Error provider Properties
            this.gridControl1.ShowRowHeaderErroricon = false;
            this.gridControl1.CurrentCell.ShowErrorIcon = false;
            this.gridControl1.CurrentCell.ShowErrorMessageBox = false;
            this.gridControl1.CurrentCell.ValidationErrorText = string.Empty;
            textBox2.Enabled = false;
            textBox1.Enabled = false;
            this.gridControl1.CurrentCellValidating += new CancelEventHandler(gridControl1_CurrentCellValidating);
            this.gridControl1.CurrentCellErrorMessage += new GridCurrentCellErrorMessageEventHandler(gridControl1_CurrentCellErrorMessage);
            this.gridControl1.RefreshCurrentCellBehavior = GridRefreshCurrentCellBehavior.RefreshRow;
            this.gridControl1.KeyUp += new KeyEventHandler(gridControl1_KeyUp);
        }

        void gridControl1_KeyUp(object sender, KeyEventArgs e)
        {
            this.gridControl1.RefreshRange(GridRangeInfo.Row(this.gridControl1.CurrentCell.RowIndex));
        }

        void gridControl1_CurrentCellErrorMessage(object sender, GridCurrentCellErrorMessageEventArgs e)
        {
            this.gridControl1.RefreshRange(GridRangeInfo.Row(this.gridControl1.CurrentCell.RowIndex));
        }

        void gridControl1_CurrentCellValidating(object sender, CancelEventArgs e)
        {
            long output;
            if (chkSetError.Checked)
            {
                long.TryParse(this.gridControl1.CurrentCell.Renderer.ControlText, out output);
                if (this.gridControl1.CurrentCell.ColIndex == 1 && output > 5)
                {
                    if (string.IsNullOrEmpty(textBox2.Text))
                        this.gridControl1.CurrentCell.SetError("Please enter valid number");
                    else
                        this.gridControl1.CurrentCell.SetError(textBox2.Text);

                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                this.gridControl1.ShowRowHeaderErroricon = true;
            else
                this.gridControl1.ShowRowHeaderErroricon = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (chkValidate.Checked)
                this.gridControl1.CurrentCell.ValidationErrorText = textBox1.Text;
            else
                this.gridControl1.CurrentCell.ValidationErrorText = string.Empty;
        }

        private void checkBox5_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkSetError.Checked)
            {
                checkBox3.Checked = true;
                textBox2.Enabled = true;
            }
            else
            {
                checkBox3.Checked = false;
                textBox2.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkValidate.Checked)
            {
                checkBox3.Checked = true;
                textBox1.Enabled = true;
            }
            else
            {
                this.gridControl1.CurrentCell.ValidationErrorText = string.Empty;
                checkBox3.Checked = false;
                textBox1.Enabled = false;
                textBox1.Clear();
            }
        }

        private void checkBox1_CheckedChanged_2(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                this.gridControl1.ShowRowHeaderErroricon = true;
            else
                this.gridControl1.ShowRowHeaderErroricon = false;
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                this.gridControl1.CurrentCell.ShowErrorMessageBox = true;
            else
                this.gridControl1.CurrentCell.ShowErrorMessageBox = false;
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                this.gridControl1.CurrentCell.ShowErrorIcon = true;
            else
                this.gridControl1.CurrentCell.ShowErrorIcon = false;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            this.gridControl1.CurrentCell.ValidationErrorText = textBox1.Text;
        }
        # endregion

        #region Form Handlers
        
        private DataTable GetTable()
        {
            this.gridControl1.RowCount = 20;
            DataTable dt = new DataTable("MyTable");

            dt.Columns.Add(new DataColumn("S.NO"));
            dt.Columns.Add(new DataColumn("Date"));
            dt.Columns.Add(new DataColumn("History"));
            for (int i = 0; i < 10; i++)
                dt.Rows.Add(new object[] { i, DateTime.Today, "Trader" });

            return dt;
        }
        #endregion

      
    }
}
