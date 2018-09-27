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
using DemoCommon.Grid;
using Syncfusion.WinForms.DataGrid.Enums;

namespace Selection
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
        /// Occurs when the AutoSizeColumnsMode is selected.
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
