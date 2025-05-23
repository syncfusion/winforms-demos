#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Data;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Enums;

namespace Editing
{
    public partial class Form1 : Form
    {
        #region Fields
        OrderInfoCollection orderInfo;
        #endregion

        #region Constructor
        public Form1()
        {
            InitializeComponent();
            orderInfo = new OrderInfoCollection();
            this.sfDataGrid1.Columns.CollectionChanged += Columns_CollectionChanged;
            this.colAllowEditingCheckBox.CheckedChanged += new System.EventHandler(this.colAllowEditingCheckBox_CheckedChanged);
            this.allowEditingCheckBox.CheckedChanged += new System.EventHandler(this.allowEditingCheckBox_CheckedChanged);
            this.allowEditingCheckBox.Checked = this.sfDataGrid1.AllowEditing;
            this.editModeComboBox.SelectedIndex = 0;
            this.selectionBehaviorComBox.SelectedIndex = 0;
            this.sfDataGrid1.DataSource = orderInfo.OrdersListDetails;
            this.selectedColumnComboBox.SelectedIndex = 0;
        }

        #endregion

        private void allowEditingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.sfDataGrid1.AllowEditing = allowEditingCheckBox.Checked;
        }

        private void editModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = this.editModeComboBox.GetItemText(this.editModeComboBox.SelectedItem);
            switch (selectedValue)
            {
                case "SingleClick":
                    this.sfDataGrid1.EditMode = EditMode.SingleClick;
                    break;

                case "DoubleClick":
                    this.sfDataGrid1.EditMode = EditMode.DoubleClick;
                    break;
            }
        }

        private void selectionBehaviorComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = this.selectionBehaviorComBox.GetItemText(this.selectionBehaviorComBox.SelectedItem);
            switch (selectedValue)
            {
                case "Default":
                    this.sfDataGrid1.EditorSelectionBehavior = EditorSelectionBehavior.Default;
                    break;

                case "MoveLast":
                    this.sfDataGrid1.EditorSelectionBehavior = EditorSelectionBehavior.MoveLast;
                    break;

                case "SelectAll":
                    this.sfDataGrid1.EditorSelectionBehavior = EditorSelectionBehavior.SelectAll;
                    break;
            }
        }

        private void Columns_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                if (e.NewItems.Count > 0)
                {
                    var column = e.NewItems[0] as GridColumn;
                    selectedColumnComboBox.Items.Add(column.MappingName);
                }
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                var column = e.OldItems[0] as GridColumn;
                selectedColumnComboBox.Items.Remove(column.MappingName);
            }
            else if (e.Action == NotifyCollectionChangedAction.Reset)
            {
                if (this.sfDataGrid1.Columns.Count == 0)
                {
                    selectedColumnComboBox.Items.Clear();
                }
            }
        }

        private void colAllowEditingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string selectedValue = this.selectedColumnComboBox.GetItemText(this.selectedColumnComboBox.SelectedItem);

            if (string.IsNullOrEmpty(selectedValue) || this.sfDataGrid1.Columns[selectedValue] == null)
                return;

            sfDataGrid1.Columns[selectedValue].AllowEditing = colAllowEditingCheckBox.Checked;
        }

        private void selectedColumnComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = this.selectedColumnComboBox.GetItemText(this.selectedColumnComboBox.SelectedItem);
            if (string.IsNullOrEmpty(selectedValue) || this.sfDataGrid1.Columns[selectedValue] == null)
                return;

            GridTextColumn textColumn = sfDataGrid1.Columns[selectedValue] as GridTextColumn;

            if (textColumn != null)
            {
                this.colAllowEditingCheckBox.Checked = textColumn.AllowEditing;
                this.allowMultilineCheckBox.Checked = textColumn.AllowMultiline;
                this.wordWrapCheckBox.Checked = textColumn.AllowTextWrapping;
                this.verticalScrollBarCheckBox.Checked = textColumn.AllowVerticalScrollbar;
            }
            else
            {
                this.colAllowEditingCheckBox.Checked =
                    this.wordWrapCheckBox.Checked = this.verticalScrollBarCheckBox.Checked = false;
                this.allowEditingCheckBox.Checked = true;
            }
        }

        private void allowMultilineCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string selectedValue = this.selectedColumnComboBox.GetItemText(this.selectedColumnComboBox.SelectedItem);

            if (string.IsNullOrEmpty(selectedValue) || this.sfDataGrid1.Columns[selectedValue] == null)
                return;

            GridTextColumn textColumn = sfDataGrid1.Columns[selectedValue] as GridTextColumn;

            if (textColumn != null)
            {
                textColumn.AllowMultiline = allowMultilineCheckBox.Checked;
            }
        }

        private void wordWrapCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string selectedValue = this.selectedColumnComboBox.GetItemText(this.selectedColumnComboBox.SelectedItem);

            if (string.IsNullOrEmpty(selectedValue) || this.sfDataGrid1.Columns[selectedValue] == null)
                return;

            GridTextColumn textColumn = sfDataGrid1.Columns[selectedValue] as GridTextColumn;

            if (textColumn != null)
            {
                textColumn.AllowTextWrapping = wordWrapCheckBox.Checked;
            }
        }

        private void verticalScrollBarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string selectedValue = this.selectedColumnComboBox.GetItemText(this.selectedColumnComboBox.SelectedItem);

            if (string.IsNullOrEmpty(selectedValue) || this.sfDataGrid1.Columns[selectedValue] == null)
                return;

            GridTextColumn textColumn = sfDataGrid1.Columns[selectedValue] as GridTextColumn;

            if (textColumn != null)
            {
                textColumn.AllowVerticalScrollbar = verticalScrollBarCheckBox.Checked;
            }
        }
    }
}
