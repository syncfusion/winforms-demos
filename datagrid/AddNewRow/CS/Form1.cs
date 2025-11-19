#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Windows.Forms;

namespace AddNewRow
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();
            ProductSalesDetailsCollection data = new ProductSalesDetailsCollection();
            sfDataGrid.DataSource = data.SalesInfo;
            GridSettings();
        }

        #endregion

        #region GridSettings
        /// <summary>
        /// Grid Settings for better Look and Feel.
        /// </summary>
        private void GridSettings()
        {
            comboBox1.DataSource = Enum.GetValues(typeof(RowPosition));
            comboBox1.SelectedIndex = 1;
        }

        #endregion

        /// <summary>
        /// Occurs when changing the AddNewRow position in SfDataGrid.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event data.</param>
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            sfDataGrid.AddNewRowPosition = (RowPosition)comboBox1.SelectedItem;
        }

    }
}
