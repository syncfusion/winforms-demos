using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Styles;
using System;
using System.Windows.Forms;
using DemoCommon.Grid;
using Syncfusion.WinForms.DataGrid.Enums;

namespace Grouping
{
    public partial class Form1 : Form
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();
            OrderInfoCollection data = new OrderInfoCollection();
            sfDataGrid.DataSource = data.OrdersListDetails;
            GridSettings();
        }

        #endregion

        /// <summary>
        /// Set the value for AllowTriStateSorting for SfDataGrid when the checkbox value is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnTriStateCheckBoxChanged(object sender, EventArgs e)
        {
            this.sfDataGrid.Columns["OrderID"].AllowGrouping = this.allowColumnCheckBox.Checked;
        }

        /// <summary>
        /// Set the value for AllowGrouping for SfDataGrid when the checkbox value is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCheckBoxChanged(object sender, EventArgs e)
        {
            this.sfDataGrid.AllowGrouping = this.groupingCheckBox.Checked;
        }

        /// <summary>
        /// Grid Settings for better Look and Feel.
        /// </summary>
        private void GridSettings()
        {
            sfDataGrid.GroupColumnDescriptions.Add(new GroupColumnDescription() { ColumnName = "ProductName" });
            sfDataGrid.GroupColumnDescriptions.Add(new GroupColumnDescription() { ColumnName = "ShipCountry" });
            sfDataGrid.GroupColumnDescriptions.Add(new GroupColumnDescription() { ColumnName = "CustomerID" });
            sfDataGrid.ExpandAllGroup();
        }

        private void groupingCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            sfDataGrid.AllowGrouping = groupingCheckBox.Checked;
        }

        private void allowColumnCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            sfDataGrid.Columns["OrderID"].AllowGrouping = allowColumnCheckBox.Checked;
        }
    }
}
