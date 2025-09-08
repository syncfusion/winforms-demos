#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Data;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBinding
{
    public partial class Form1 : Form
    {
        #region Fields
        OrderInfoCollection orderInfo;
        EmployeeCollection employeeCollection;
        DynamicObjectCollection dynamicCollection;
        #endregion

        #region Constructor
        public Form1()
        {
            InitializeComponent();
            orderInfo = new OrderInfoCollection();
            employeeCollection = new EmployeeCollection();
            dynamicCollection = new DynamicObjectCollection();
            this.dataSourceComboBox.SelectedIndex = 0;
        }
        #endregion

        #region Change DataSource event.
        /// <summary>
        /// Occurs when the DataSource is selected.
        /// </summary>
        /// <param name="sender">The sender that contains the ComboBox.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> that contains the event data.</param>
        private void dataSourceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = this.dataSourceComboBox.GetItemText(this.dataSourceComboBox.SelectedItem);
            switch (selectedValue)
            {
                case "ObservableCollection":
                    this.sfDataGrid1.DataSource = employeeCollection.GetEmployeesDetails(200);
                    break;

                case "DataTable":
                    this.sfDataGrid1.DataSource = this.GetDataTable();
                    break;

                case "BindingList":
                    this.sfDataGrid1.DataSource = orderInfo.OrdersListDetails;
                    break;
            }
        }
        #endregion

        #region DataTable
        public DataTable GetDataTable()
        {
            DataTable employeeCollection = new DataTable();
            Random r = new Random();

            employeeCollection.Columns.Add("EmployeeID", typeof(int));
            employeeCollection.Columns[0].ColumnName = "Employee ID";
            employeeCollection.Columns.Add("EmployeeName", typeof(string));
            employeeCollection.Columns["EmployeeName"].ColumnName = "Employee Name";
            employeeCollection.Columns.Add("CustomerID", typeof(string));
            employeeCollection.Columns["CustomerID"].ColumnName = "Customer ID";
            employeeCollection.Columns.Add("Country", typeof(string));
            employeeCollection.Columns.Add("Date", typeof(DateTime));

            employeeCollection.Rows.Add(1001, "Belgim", "Yhgtr", "US", new DateTime(r.Next(2011, 2019), r.Next(1, 12), r.Next(1, 28)));
            employeeCollection.Rows.Add(1002, "Oliver", "Johanesberg", "UK", new DateTime(r.Next(2011, 2019), r.Next(1, 12), r.Next(1, 28)));
            employeeCollection.Rows.Add(1003, "Bernald", "Alfki", "US", new DateTime(r.Next(2011, 2019), r.Next(1, 12), r.Next(1, 28)));
            employeeCollection.Rows.Add(1004, "James", "Yhgtr", "Chicago", new DateTime(r.Next(2011, 2019), r.Next(1, 12), r.Next(1, 28)));
            employeeCollection.Rows.Add(1005, "Beverton", "Bergs", "Spain", new DateTime(r.Next(2011, 2019), r.Next(1, 12), r.Next(1, 28)));
            employeeCollection.Rows.Add(1005, "Berlin", "Johanesberg", "Spain", new DateTime(r.Next(2011, 2019), r.Next(1, 12), r.Next(1, 28)));
            employeeCollection.Rows.Add(1006, "Fransis", "Alfki", "US", new DateTime(r.Next(2011, 2019), r.Next(1, 12), r.Next(1, 28)));
            employeeCollection.Rows.Add(1006, "Fred", "Oregon", "US", new DateTime(r.Next(2011, 2019), r.Next(1, 12), r.Next(1, 28)));
            employeeCollection.Rows.Add(1009, "Dintin", "Britain", "Britain", new DateTime(r.Next(2011, 2019), r.Next(1, 12), r.Next(1, 28)));
            employeeCollection.Rows.Add(1009, "Diano", "Alfki", "Britain", new DateTime(r.Next(2011, 2019), r.Next(1, 12), r.Next(1, 28)));
            employeeCollection.Rows.Add(1010, "Joysie", "Oregon", "China", new DateTime(r.Next(2011, 2019), r.Next(1, 12), r.Next(1, 28)));
            employeeCollection.Rows.Add(1016, "Friedo", "Bergs", "US", new DateTime(r.Next(2011, 2019), r.Next(1, 12), r.Next(1, 28)));
            employeeCollection.Rows.Add(1017, "George", "Oregon", "SwitzerLand", new DateTime(r.Next(2011, 2019), r.Next(1, 12), r.Next(1, 28)));
            employeeCollection.Rows.Add(1011, "DintinAmam", "Alfki", "Britain", new DateTime(r.Next(2011, 2019), r.Next(1, 12), r.Next(1, 28)));
            employeeCollection.Rows.Add(1012, "JohnAmam", "Johanesberg", "China", new DateTime(r.Next(2011, 2019), r.Next(1, 12), r.Next(1, 28)));
            employeeCollection.Rows.Add(1012, "PaulPaulPaul", "Bergs", "China", new DateTime(r.Next(2011, 2019), r.Next(1, 12), r.Next(1, 28)));

            return employeeCollection;
        }

        #endregion
    }
}
