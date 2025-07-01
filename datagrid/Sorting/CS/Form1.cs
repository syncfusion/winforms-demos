#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Styles;
using Syncfusion.WinForms.DataGrid.Enums;

namespace Sorting
{
    public partial class Form1 : Form
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();

            data = new OrderInfoCollection();
            this.sfDataGrid.DataSource = data.OrdersListDetails;
            this.comboBoxAdv1.SelectedIndex = 0;
            this.comboBoxAdv1.SelectedIndexChanged += ComboBoxAdv1_SelectedIndexChanged;
            this.sfDataGrid.Columns["OrderID"].AllowSorting = true;
            this.sfDataGrid.Columns["CustomerID"].AllowSorting = true;

        }

        private void ComboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.sfDataGrid.SortClickAction = this.comboBoxAdv1.SelectedIndex == 0 ? SortClickAction.SingleClick :
                                              SortClickAction.DoubleClick;
        }

        #endregion

        /// <summary>
        /// Set the value for AllowSorting for CustomerID when the checkbox value is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCustomerIdCheckBoxChanged(object sender, EventArgs e)
        {
            this.sfDataGrid.Columns["CustomerID"].AllowSorting = customerIdCheckBox.Checked;
        }

        /// <summary>
        /// Set the value for AllowSorting for OrderID when the checkbox value is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnOrderIdCheckBoxChanged(object sender, EventArgs e)
        {
            this.sfDataGrid.Columns["OrderID"].AllowSorting = orderIdCheckBox.Checked;
        }

        /// <summary>
        /// Set the value for SortClickAction for OrderID when ComboBox Selected item is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Set the value for AllowTriStateSorting for SfDataGrid when the checkbox value is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnTriStateCheckBoxChanged(object sender, EventArgs e)
        {
            this.sfDataGrid.AllowTriStateSorting = this.triStateCheckBox.Checked;
        }

        /// <summary>
        /// Set the value for ShowSortNumbers for SfDataGrid when the checkbox value is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnSortNumberCheckBoxChanged(object sender, EventArgs e)
        {
            this.sfDataGrid.ShowSortNumbers = this.sortNumberCheckBox.Checked;
        }

        /// <summary>
        /// Set the value for AllowSorting for SfDataGrid when the checkbox value is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCheckBoxChanged(object sender, EventArgs e)
        {
            this.sfDataGrid.AllowSorting = this.sortCheckBox.Checked;
        }
    }
}
