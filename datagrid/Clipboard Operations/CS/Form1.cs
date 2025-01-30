#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipBoardsOperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OrderInfoCollection collection = new OrderInfoCollection();
            sfDataGrid1.DataSource = collection.GetListOrdersDetails(1000);
            this.selectionModeComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectionModeComboBox_SelectedIndexChanged);
            this.checkedListBox1.SelectedValueChanged += new System.EventHandler(this.GridCopyOption_SelectedValueChanged);
            this.checkListBox2.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            this.editTrigger.SelectedIndexChanged += new System.EventHandler(this.editTrigger_SelectedValueChanged);
            this.selectionModeComboBox.SelectedIndex = 1;
            this.editTrigger.SelectedIndex = 1;
            this.checkedListBox1.SelectedIndex = 1;
            this.checkListBox2.SelectedIndex = 1;
        }

        /// <summary>
        /// Occurs when the SelectionModeIndex is changed.
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

                case "Single Deselect":
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
        /// Occurs when the CopyOption is changed.
        /// </summary>
        /// <param name="sender">The sender that contains the ListBox.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> that contains the event data.</param>
        void GridCopyOption_SelectedValueChanged(object sender, System.EventArgs e)
        {
            var data = (sender as System.Windows.Forms.ListBox);
            if (data.SelectedItems != null)
            {
                for (int i = 0; i < data.SelectedItems.Count; i++)
                {
                    if (i == 0)
                        this.sfDataGrid1.CopyOption = CopyOptionConverter(data.SelectedItems[i].ToString());
                    else
                        this.sfDataGrid1.CopyOption = this.sfDataGrid1.CopyOption | CopyOptionConverter(data.SelectedItems[i].ToString());
                }
            }
        }

        /// <summary>
        /// Occurs when the PasteOption is changed.
        /// </summary>
        /// <param name="sender">The sender that contains the ListBox.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> that contains the event data.</param>
        void listBox1_SelectedValueChanged(object sender, System.EventArgs e)
        {
            var data = (sender as System.Windows.Forms.ListBox);
            if (data.SelectedItems != null)
            {
                for (int i = 0; i < data.SelectedItems.Count; i++)
                {
                    if (i == 0)
                        this.sfDataGrid1.PasteOption = PasteOptionConverter(data.SelectedItems[i].ToString());
                    else
                        this.sfDataGrid1.PasteOption = this.sfDataGrid1.PasteOption | PasteOptionConverter(data.SelectedItems[i].ToString());
                }
            }
        }

        /// <summary>
        /// CopyOptionConverter for set the value for copy option.
        /// </summary>
        /// <param name="option">Option for copying</param>
        /// <returns>returns GridCopyOption</returns>
        private CopyOptions CopyOptionConverter(string option)
        {
            if (option.Equals("Cut Data"))
                return CopyOptions.CutData;
            else if (option.Equals("Copy Data"))
                return CopyOptions.CopyData;
            else if (option.Equals("Include Hidden Column"))
                return CopyOptions.IncludeHiddenColumn;
            else if (option.Equals("Include Headers"))
                return CopyOptions.IncludeHeaders;
            else if (option.Equals("Include Format"))
                return CopyOptions.IncludeFormat;
            return CopyOptions.None;
        }

        /// <summary>
        /// PasteOptionConverter for set the value for paste option.
        /// </summary>
        /// <param name="option">Option for paste</param>
        /// <returns>returns GridPasteOption</returns>
        private PasteOptions PasteOptionConverter(string option)
        {
            if (option.Equals("Paste Data"))
                return PasteOptions.PasteData;
            else if (option.Equals("Include Hidden Column"))
                return PasteOptions.IncludeHiddenColumn;
            else if (option.Equals("Exclude First Line"))
                return PasteOptions.ExcludeFirstLine;
            return PasteOptions.None;
        }

        /// <summary>
        /// Occurs when the EditTrigger is changed.
        /// </summary>
        /// <param name="sender">The sender that contains the ComboBox.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> that contains the event data.</param>
        void editTrigger_SelectedValueChanged(object sender, System.EventArgs e)
        {
            string selectedValue = this.editTrigger.GetItemText(this.editTrigger.SelectedItem);
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
    }
}
