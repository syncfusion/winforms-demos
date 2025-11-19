#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Enums;

namespace CellSelection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            OrderInfoCollection collection = new OrderInfoCollection();
            sfDataGrid1.DataSource = collection.OrdersListDetails;
            this.selectionModeComboBox.SelectedIndex = 1;
        }

        /// <summary>
        /// Occurs when the SelectionMode is selected.
        /// </summary>
        /// <param name="sender">The sender that contains the ComboBox.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> that contains the event data.</param>
        private void SelectionModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = this.selectionModeComboBox.GetItemText(this.selectionModeComboBox.SelectedItem);
            switch (selectedValue)
            {
                case "None":
                    this.sfDataGrid1.SelectionMode = GridSelectionMode.None;
                    break;

                case "Single":
                    this.sfDataGrid1.SelectionMode = GridSelectionMode.Single;
                    break;

                case "SingleDeselect":
                    this.sfDataGrid1.SelectionMode = GridSelectionMode.SingleDeselect;
                    break;

                case "Multiple":
                    this.sfDataGrid1.SelectionMode = GridSelectionMode.Multiple;
                    break;

                case "Extended":
                    this.sfDataGrid1.SelectionMode = GridSelectionMode.Extended;
                    break;
            }
        }

        /// <summary>
        ///  Occurs when the AllowSelectionPointerPressed is selected.
        /// </summary>
        /// <param name="sender">The sender that contains the ComboBox.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> that contains the event data.</param>
        private void allowSelectionPointerPressed_CheckedChanged(object sender, EventArgs e)
        {
            this.sfDataGrid1.AllowSelectionOnMouseDown = (sender as CheckBox).Checked;
        }
    }
}
