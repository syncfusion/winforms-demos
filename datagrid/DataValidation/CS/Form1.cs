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

namespace DataValidationDemo
{
    public partial class Form1 : Form
    {
        #region Fields
        OrderInfoCollection orderInfo;
        #endregion

        #region Constuctor
        public Form1()
        {
            InitializeComponent();
            orderInfo = new OrderInfoCollection();
            this.sfDataGrid1.DataSource = orderInfo.OrdersListDetails;
            this.selectedColumnComboBox.SelectedIndex = 1;
            this.validationModeComboBox.SelectedIndex = 1;
            this.colValidationModeComboBox.SelectedIndex = 0;
        }

        #endregion

        private void selectedColumnComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = this.selectedColumnComboBox.GetItemText(this.selectedColumnComboBox.SelectedItem);
            if (string.IsNullOrEmpty(selectedValue) || this.sfDataGrid1.Columns[selectedValue] == null)
                return;
            this.colValidationModeComboBox.Text = this.sfDataGrid1.Columns[selectedValue].ValidationMode.ToString();
        }

        private void validationModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = this.validationModeComboBox.GetItemText(this.validationModeComboBox.SelectedItem);
            switch (selectedValue)
            {
                case "None":
                    this.sfDataGrid1.ValidationMode = GridValidationMode.None;
                    break;

                case "InEdit":
                    this.sfDataGrid1.ValidationMode = GridValidationMode.InEdit;
                    break;

                case "InView":
                    this.sfDataGrid1.ValidationMode = GridValidationMode.InView;
                    break;
            }

            string selectedColumn = this.selectedColumnComboBox.GetItemText(this.selectedColumnComboBox.SelectedItem);
            if (string.IsNullOrEmpty(selectedColumn) || this.sfDataGrid1.Columns[selectedColumn] == null)
                return;
            this.colValidationModeComboBox.Text = this.sfDataGrid1.Columns[selectedColumn].ValidationMode.ToString();
        }

        private void colValidationModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColumn = this.selectedColumnComboBox.GetItemText(this.selectedColumnComboBox.SelectedItem);
            if (string.IsNullOrEmpty(selectedColumn) || this.sfDataGrid1.Columns[selectedColumn] == null)
                return;

            string selectedValue = this.colValidationModeComboBox.GetItemText(this.colValidationModeComboBox.SelectedItem);

            switch (selectedValue)
            {
                case "None":
                    this.sfDataGrid1.Columns[selectedColumn].ValidationMode = GridValidationMode.None;
                    break;

                case "InEdit":
                    this.sfDataGrid1.Columns[selectedColumn].ValidationMode = GridValidationMode.InEdit;
                    break;

                case "InView":
                    this.sfDataGrid1.Columns[selectedColumn].ValidationMode = GridValidationMode.InView;
                    break;
            }
        }

        private void toolTipCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.sfDataGrid1.ShowValidationErrorToolTip = toolTipCheckBox.Checked;
        }

        private void showRowError_CheckedChanged(object sender, EventArgs e)
        {
            this.sfDataGrid1.ShowRowHeaderErrorIcon = showRowError.Checked;
        }

        private void showErrorIcon_CheckedChanged(object sender, EventArgs e)
        {
            this.sfDataGrid1.ShowErrorIcon = showErrorIcon.Checked;
        }
    }
}
