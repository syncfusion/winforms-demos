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
using DemoCommon.Grid;
using Syncfusion.Windows.Forms;

namespace ErrorProvider
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : GridDemoForm
    {
        #region "Constructor"

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.GridSettings();
            this.SampleCustomization();
        }

        #endregion

        #region "Sample Grid Settings"

        /// <summary>
        /// GridGrouping control getting started customization.
        /// </summary>
        private void GridSettings()
        {

            //used to set multiextended selection mode in gridgrouping control. 
            this.GridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
			this.GridGroupingControl1.TableControl.DpiAware = true;

            //used to set GridCaptionRowHeight.
            this.GridGroupingControl1.Table.DefaultCaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.GridGroupingControl1.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30.0f);
            this.GridGroupingControl1.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            this.GridGroupingControl1.AllowProportionalColumnSizing = true;

            //Events
            this.GridGroupingControl1.TableControl.CurrentCellValidating += new CancelEventHandler(GridGroupingControl1_CurrentCellValidating);
            this.chkSetError.CheckStateChanged += new System.EventHandler(this.checkBox5_CheckedChanged_1);
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox2.CheckStateChanged += new System.EventHandler(this.checkBox2_CheckedChanged_1);
            this.checkBox3.CheckStateChanged += new System.EventHandler(this.checkBox3_CheckedChanged_1);
            this.checkBox4.CheckStateChanged += new System.EventHandler(this.checkBox4_CheckedChanged_1);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);

            //Navigate to other control using tabkey navigation
            this.GridGroupingControl1.WantTabKey = false;
        }

        #endregion

        #region "Sample Customized"
        /// <summary>
        /// ErrorProvider Sample Customizations.
        /// </summary>
        private void SampleCustomization()
        {
            this.GridGroupingControl1.DataSource = GetTable();
            this.GridGroupingControl1.ThemesEnabled = true;
            //Error provider Properties
            this.GridGroupingControl1.TableControl.ShowRowHeaderErroricon = false;
            this.GridGroupingControl1.TableControl.CurrentCell.ShowErrorIcon = false;
            this.GridGroupingControl1.TableControl.CurrentCell.ShowErrorMessageBox = false;
            this.GridGroupingControl1.TableControl.CurrentCell.ValidationErrorText = string.Empty;
            this.GridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.GridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            //
            //textbox1
            //
            this.textBox1.Enabled = false;
            this.textBox2.Enabled = false;
        }

        #region Event Handlers

        #region GridGroupingControl1_CurrentCellValidating 
        /// <summary>
        /// Validating the Current cell
        /// </summary>
        void GridGroupingControl1_CurrentCellValidating(object sender, CancelEventArgs e)
        {
            long output;
            if (chkSetError.Checked)
            {
                long.TryParse(this.GridGroupingControl1.TableControl.CurrentCell.Renderer.ControlText, out output);
                if (this.GridGroupingControl1.TableControl.CurrentCell.ColIndex == 1 && output > 5)
                {
                    //Display the user's Error Text
                    if (string.IsNullOrEmpty(textBox2.Text))
                        this.GridGroupingControl1.TableControl.CurrentCell.SetError("Please enter valid number");
                    else
                        this.GridGroupingControl1.TableControl.CurrentCell.SetError(textBox2.Text);
                }
            }
        }
        #endregion

        #region Change Validation Error Text
        /// <summary>
        /// Set the Error Text
        /// </summary>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
                this.GridGroupingControl1.TableControl.CurrentCell.ValidationErrorText = textBox1.Text;
            else
                this.GridGroupingControl1.TableControl.CurrentCell.ValidationErrorText = string.Empty;
        }
        #endregion 

        #region ShowRowHeaderErroricon
        /// <summary>
        /// Display/Hide Error Icons in the RowHeaders
        /// </summary>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                this.GridGroupingControl1.TableControl.ShowRowHeaderErroricon = true;
            else
                this.GridGroupingControl1.TableControl.ShowRowHeaderErroricon = false;
        }
        #endregion

        #region ShowErrorMessageBox
        /// <summary>
        /// Enable/Disable Error Message Box
        /// </summary>
        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                this.GridGroupingControl1.TableControl.CurrentCell.ShowErrorMessageBox = true;
            else
                this.GridGroupingControl1.TableControl.CurrentCell.ShowErrorMessageBox = false;
        }

        #region ShowErrorIcon
        /// <summary>
        /// Set ShowErrorIcon visibility 
        /// </summary>
        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                this.GridGroupingControl1.TableControl.CurrentCell.ShowErrorIcon = true;
            else
                this.GridGroupingControl1.TableControl.CurrentCell.ShowErrorIcon = false;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            this.GridGroupingControl1.TableControl.CurrentCell.ValidationErrorText = textBox1.Text;
        }

        #endregion

        #endregion

        #region ChecBox Options Settings

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

        /// <summary>
        /// Handling the error text
        /// </summary>
        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox3.Checked = true;
                this.textBox1.Enabled = true;
            }
            else
            {
                this.GridGroupingControl1.TableControl.CurrentCell.ValidationErrorText = string.Empty;
                this.textBox1.Clear();
                checkBox3.Checked = false;
                this.textBox1.Enabled = false;
            }
        }

        #endregion

        #endregion

        #endregion

        #region "DataTable"

        /// <summary>
        /// Generete a data
        /// </summary>
        private DataTable GetTable()
        {
            DataTable dt = new DataTable("MyTable");

            dt.Columns.Add(new DataColumn("S.NO", typeof(int)));
            dt.Columns.Add(new DataColumn("Date", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("History", typeof(string)));
            for (int i = 1; i <= 30; i++)
                dt.Rows.Add(new object[] { i, DateTime.Today.AddDays(i), "Trader " + i });

            return dt;
        }

        #endregion
    }
}
