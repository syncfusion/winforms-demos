#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.GridCommon;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdvancedFiltering
{
    public partial class Form1 : Form
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance for Form1.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            SampleCustomization();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Contains the sample level customization.
        /// </summary>
        private void SampleCustomization()
        {
            OrderInfoCollection collection = new OrderInfoCollection();
            sfDataGrid1.DataSource = collection.GetListOrdersDetails(1000);
            StringCollection advancedFilterTypes = new StringCollection();
            advancedFilterTypes.AddRange(new string[] { "Both", "AdvancedFilter", "CheckBoxFilter" });
            cmbFilterPopupModeCustomerID.DataSource = advancedFilterTypes;
            cmbFilterPopupModeOrderDate.DataSource = advancedFilterTypes;
            cmbFilterPopupModeCustomerID.BindingContext = new BindingContext();
            sfDataGrid1.Columns["OrderID"].ImmediateUpdateColumnFilter = true;          
            sfDataGrid1.Columns["OrderID"].AllowBlankFilters = false;
        }

        /// <summary>
        /// Sets the overall filtering for SfDataGrid.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void chkAllowFilters_CheckedChanged(object sender, EventArgs e)
        {
            sfDataGrid1.AllowFiltering = chkAllowFilters.Checked;
            sfDataGrid1.Columns["OrderID"].AllowFiltering = chkAllowFilterOrderID.Checked;
            sfDataGrid1.Columns["CustomerID"].AllowFiltering = chkAllowFilterCustomerID.Checked;
            sfDataGrid1.Columns["OrderDate"].AllowFiltering = chkAllowFilterOrderDate.Checked;
        }

        /// <summary>
        /// Sets the AllowFiltering for the OrderID column.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void chkAllowFilterOrderID_CheckedChanged(object sender, EventArgs e)
        {
            sfDataGrid1.Columns["OrderID"].AllowFiltering = chkAllowFilterOrderID.Checked;
        }

        /// <summary>
        /// Sets the ImmediateUpdateColumnFilter for the OrderID column.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void chkImmediateUpdateColumnFilterOrderID_CheckedChanged(object sender, EventArgs e)
        {
            sfDataGrid1.Columns["OrderID"].ImmediateUpdateColumnFilter = chkImmediateUpdateColumnFilterOrderID.Checked;
        }

        /// <summary>
        /// Sets the AllowBlankFilters for the OrderID column.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void chkAllowBlankFilterOrderID_CheckedChanged(object sender, EventArgs e)
        {
            sfDataGrid1.Columns["OrderID"].AllowBlankFilters = chkAllowBlankFilterOrderID.Checked;
        }

        /// <summary>
        /// Sets the AllowFiltering for the CustomerID column.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void chkAllowFilterColumnID_CheckedChanged(object sender, EventArgs e)
        {
            sfDataGrid1.Columns["CustomerID"].AllowFiltering = chkAllowFilterCustomerID.Checked;
        }

        /// <summary>
        /// Sets the ImmediateUpdateColumnFilter for the CustomerID column.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void chkImmediateUpdateColumnFilterCustomerID_CheckedChanged(object sender, EventArgs e)
        {
            sfDataGrid1.Columns["CustomerID"].ImmediateUpdateColumnFilter = chkImmediateUpdateColumnFilterCustomerID.Checked;
        }

        /// <summary>
        /// Sets the AllowBlankFilters for the CustomerID column.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void chkAllowBlankFilterCustomerID_CheckedChanged(object sender, EventArgs e)
        {
            sfDataGrid1.Columns["CustomerID"].AllowBlankFilters = chkAllowBlankFilterCustomerID.Checked;
        }

        /// <summary>
        /// Sets the AllowFiltering for the OrderDate column.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void chkAllowFilterOrderDate_CheckedChanged(object sender, EventArgs e)
        {
            sfDataGrid1.Columns["OrderDate"].AllowFiltering = chkAllowFilterOrderDate.Checked;
        }

        /// <summary>
        /// Sets the ImmediateUpdateColumnFilter for the OrderDate column.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void chkImmediateUpdateColumnFilterOrderDate_CheckedChanged(object sender, EventArgs e)
        {
            sfDataGrid1.Columns["OrderDate"].ImmediateUpdateColumnFilter = chkImmediateUpdateColumnFilterOrderDate.Checked;
        }

        /// <summary>
        /// Sets the AllowBlankFilters for the OrderDate column.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void chkAllowBlankFilterOrderDate_CheckedChanged(object sender, EventArgs e)
        {
            sfDataGrid1.Columns["OrderDate"].AllowBlankFilters = chkAllowBlankFilterOrderDate.Checked;
        }

        /// <summary>
        /// Sets the FilterPopupMode for the CustomerID column.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void cmbFilterPopupModeCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterPopupMode filterPopupMode = FilterPopupMode.Both;
            switch (cmbFilterPopupModeCustomerID.SelectedItem.ToString())
            {
                case "AdvancedFilter":
                    filterPopupMode = FilterPopupMode.AdvancedFilter;
                    break;
                case "CheckBoxFilter":
                    filterPopupMode = FilterPopupMode.CheckBoxFilter;
                    break;
                case "Both":
                    filterPopupMode = FilterPopupMode.Both;
                    break;
            }

            sfDataGrid1.Columns["CustomerID"].FilterPopupMode = filterPopupMode;
        }

        /// <summary>
        /// Sets the FilterPopupMode for the OrderDate column.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void cmbFilterPopupModeOrderDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterPopupMode filterPopupMode = FilterPopupMode.Both;
            switch (cmbFilterPopupModeOrderDate.SelectedItem.ToString())
            {
                case "AdvancedFilter":
                    filterPopupMode = FilterPopupMode.AdvancedFilter;
                    break;
                case "CheckBoxFilter":
                    filterPopupMode = FilterPopupMode.CheckBoxFilter;
                    break;
                case "Both":
                    filterPopupMode = FilterPopupMode.Both;
                    break;
            }

            sfDataGrid1.Columns["OrderDate"].FilterPopupMode = filterPopupMode;
        }

        #endregion
    }
}
