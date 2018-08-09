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

namespace ColumnSizing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OrderInfoCollection collection = new OrderInfoCollection();
            sfDataGrid1.DataSource = collection.OrdersListDetails;
            this.autoSizeColumnsModeComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Occurs when the AutoSizeColumnsMode is selected.
        /// </summary>
        /// <param name="sender">The sender that contains the ComboBox.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> that contains the event data.</param>
        private void autoSizeColumnsModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = this.autoSizeColumnsModeComboBox.GetItemText(this.autoSizeColumnsModeComboBox.SelectedItem);
            switch (selectedValue)
            {
                case "ColumnHeader":
                    this.sfDataGrid1.AutoSizeColumnsMode = AutoSizeColumnsMode.ColumnHeader;
                    break;

                case "AllCells":
                    this.sfDataGrid1.AutoSizeColumnsMode = AutoSizeColumnsMode.AllCells;
                    break;

                case "AllCellsWithLastColumnFill":
                    this.sfDataGrid1.AutoSizeColumnsMode = AutoSizeColumnsMode.AllCellsWithLastColumnFill;
                    break;

                case "LastColumnFill":
                    this.sfDataGrid1.AutoSizeColumnsMode = AutoSizeColumnsMode.LastColumnFill;
                    break;

                case "None":
                    this.sfDataGrid1.AutoSizeColumnsMode = AutoSizeColumnsMode.None;
                    break;

                case "AllCellsExceptHeader":
                    this.sfDataGrid1.AutoSizeColumnsMode = AutoSizeColumnsMode.AllCellsExceptHeader;
                    break;

                case "Fill":
                    this.sfDataGrid1.AutoSizeColumnsMode = AutoSizeColumnsMode.Fill;
                    break;
            }
        }
    }
}
