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
using Syncfusion.WinForms.Input.Enums;
using System.Globalization;
using Syncfusion.Windows.Forms;

namespace CheckBoxSelectorColumnDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();                    
            GridSetting();
            this.selectionModeComboBox.SelectedIndex = 1;            
        }

        #region Grid Settings

        /// <summary>
        /// Grid Settings for better Look and Feel.
        /// </summary>
        private void GridSetting()
        {
            OrderInfoCollection collection = new OrderInfoCollection();
            sfDataGrid1.DataSource = collection.OrdersListDetails;

            NumberFormatInfo numberFormat = Application.CurrentCulture.NumberFormat.Clone() as NumberFormatInfo;
            numberFormat.NumberDecimalDigits = 0;            
            numberFormat.NumberGroupSizes = new int[] { };

            
            this.sfDataGrid1.Columns.Add(new GridCheckBoxSelectorColumn() { MappingName = "SelectorColumn", HeaderText = string.Empty, AllowCheckBoxOnHeader = true, Width = 34, CheckBoxSize = new Size((int)DpiAware.LogicalToDeviceUnits(14.0f), (int)DpiAware.LogicalToDeviceUnits(14.0f)) });
            this.sfDataGrid1.Columns.Add(new GridNumericColumn() { MappingName = "OrderID", HeaderText = "Order ID", NumberFormatInfo = numberFormat });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "CustomerID", HeaderText = "Customer ID" });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "ProductName", HeaderText = "Product Name" });
            this.sfDataGrid1.Columns.Add(new GridDateTimeColumn() { MappingName = "OrderDate", HeaderText = "Order Date" });
            this.sfDataGrid1.Columns.Add(new GridNumericColumn() { MappingName = "Quantity", HeaderText = "Quantity", NumberFormatInfo = numberFormat });
            this.sfDataGrid1.Columns.Add(new GridNumericColumn() { MappingName = "UnitPrice", HeaderText = "Unit Price", FormatMode = FormatMode.Currency });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "ContactNumber", HeaderText = "Contact Number" });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "ShipCountry", HeaderText = "Ship Country" });

            var item = collection.OrdersListDetails;
            this.sfDataGrid1.SelectedItems.Add(item[4]);
            this.sfDataGrid1.SelectedItems.Add(item[6]);
            this.sfDataGrid1.SelectedItems.Add(item[10]);
            this.sfDataGrid1.SelectedItems.Add(item[15]);
            this.sfDataGrid1.SelectedItems.Add(item[16]);
        }      

        #endregion

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

                case "Multiple":
                    this.sfDataGrid1.SelectionMode = GridSelectionMode.Multiple;
                    break;

                case "Extended":
                    this.sfDataGrid1.SelectionMode = GridSelectionMode.Extended;
                    break;
            }
        }        
    }
}
