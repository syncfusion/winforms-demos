#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.WinForms.DataGrid;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.Input.Enums;
using System.Globalization;
using System;

namespace DataVirtualization
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Summary description for Form1.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.sfDataGrid1.Columns.Add(new GridNumericColumn() { MappingName = "OrderID", HeaderText = "Order ID", NumberFormatInfo = new System.Globalization.NumberFormatInfo { NumberGroupSeparator = "", NumberDecimalDigits = 0 } });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "CustomerID", HeaderText = "Customer ID" });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "ProductName", HeaderText = "Product Name" });
            var numberfomat = CultureInfo.CurrentUICulture.NumberFormat.Clone() as NumberFormatInfo;
            numberfomat.NumberDecimalDigits = 0;
            this.sfDataGrid1.Columns.Add(new GridNumericColumn() { MappingName = "Quantity", HeaderText = "Quantity", NumberFormatInfo = numberfomat });
            numberfomat = CultureInfo.CurrentUICulture.NumberFormat.Clone() as NumberFormatInfo;
            numberfomat.NumberDecimalDigits = 0;
            this.sfDataGrid1.Columns.Add(new GridNumericColumn() { MappingName = "UnitPrice", HeaderText = "Unit Price", NumberFormatInfo = numberfomat, FormatMode = FormatMode.Currency });
            numberfomat = CultureInfo.CurrentUICulture.NumberFormat.Clone() as NumberFormatInfo;
            numberfomat.NumberDecimalDigits = 0;

            this.sfDataGrid1.Columns.Add(new GridNumericColumn() { MappingName = "ContactNumber", HeaderText = "Contact Number", NumberFormatInfo = new System.Globalization.NumberFormatInfo { NumberGroupSeparator = "", NumberDecimalDigits = 0 } });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "ShipCountry", HeaderText = "Ship Country" });
            this.sfDataGrid1.Columns.Add(new GridDateTimeColumn() { MappingName = "OrderDate", HeaderText = "Order Date" });
            button1.Click += Button1_Click;
            comboBox1.SelectedIndex = 2;
            comboBox1.SelectedValueChanged += ComboBox1_SelectedValueChanged;
        }

        int count = 300000;
        DateTime startTime;
        private void ComboBox1_SelectedValueChanged(object sender, System.EventArgs e)
        {
            if ((sender as ComboBox).SelectedItem.ToString() == "200K")
            {
                count = 200000;
            }
            else if ((sender as ComboBox).SelectedItem.ToString() == "300K")
            {
                count = 300000;
            }
            else if ((sender as ComboBox).SelectedItem.ToString() == "100K")
            {
                count = 100000;
            }
            else if ((sender as ComboBox).SelectedItem.ToString() == "500K")
            {
                count = 500000;
            }
            else if ((sender as ComboBox).SelectedItem.ToString() == "1 Million")
            {
                count = 1000000;
            }
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            var collection = new OrderInfoCollection(count);
            startTime = DateTime.Now;
            sfDataGrid1.DataSource = collection.OrdersListDetails;
            MessageBox.Show("Loaded in " + (DateTime.Now - startTime).TotalMilliseconds + " Milli seconds");
        }
    }
}
