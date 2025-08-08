#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Controls;

namespace MultiColumnComboBox
{
    /// <summary>
    /// Summary description for Filtering.
    /// </summary>
    public partial class Filtering : SfForm
    {
        /// <summary>
        /// Initializes the new instance for the Form.
        /// </summary>
        public Filtering()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.label2.Text = "Custom filtering is supported in MultiColumnComboBox, which can be applied to all columns or a specific column.";
            this.richTextBox1.Multiline = true;
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Dock = DockStyle.Fill;

            this.multiColumnComboBox1.DataSource = null;
            this.multiColumnComboBox1.DataSource = new OrderInfoCollection().OrdersListDetails;
            this.multiColumnComboBox1.DisplayMember = "ProductName";
            //Allowing filter
            this.multiColumnComboBox1.AllowFiltering = true;
            this.multiColumnComboBox1.SelectedIndexChanged += MultiColumnComboBox1_SelectedIndexChanged;
            this.multiColumnComboBox1.TextChanged += TextBox_TextChanged;
            this.FilterConditioncombobox.SelectedIndexChanged += FilterConditioncombobox_SelectedIndexChanged;
            this.ColumnComboBox.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            this.GridSettings();
        }


        /// <summary>
        /// Event triggered while MultiColumnCombobox's  SelectedIndex changed
        /// </summary>
        /// <param name="sender">Sender of this event</param>
        /// <param name="e">Event parameter</param>
        private void MultiColumnComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.richTextBox1.AppendText("SelectedIndex is : " + this.multiColumnComboBox1.SelectedIndex.ToString() + "\n");
        }

        #region Collection
        ArrayList textFilter = new ArrayList();

        /// <summary>
        /// Grid Settings for better Look and Feel of DataSource.
        /// </summary>
        private void GridSettings()
        {
            FilterText = this.multiColumnComboBox1.TextBox.Text;
            ArrayList list = new ArrayList();
            list.Add("All Columns");
            list.Add("OrderID");
            list.Add("CustomerID");
            list.Add("ProductName");
            list.Add("OrderDate");
            list.Add("Quantity");
            list.Add("UnitPrice");
            list.Add("ContactNumber");
            list.Add("ShipCountry");
            lbl_FilterOption.Hide();
            FilterConditioncombobox.Hide();
            this.ColumnComboBox.DataSource = list;
            textFilter.Add("Contains");
            textFilter.Add("StartsWith");
            textFilter.Add("EndsWith");
        }
        #endregion

        #region Events

        /// <summary>
        /// Event triggered while Column combobox's SelectedIndex changed
        /// </summary>
        /// <param name="sender">Sender of this event</param>
        /// <param name="e">Event parameter</param>
        private void ComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            FilterProperty = ColumnComboBox.SelectedValue.ToString();
            if (ColumnComboBox.SelectedValue.ToString() == "All Columns")
            {
                lbl_FilterOption.Enabled = false;
                FilterConditioncombobox.Enabled = false;
                lbl_FilterOption.Visible = true;
                FilterConditioncombobox.Visible = true;
            }
            else
            {
                lbl_FilterOption.Visible = true;
                lbl_FilterOption.Enabled = true;
                FilterConditioncombobox.Visible = true;
                FilterConditioncombobox.Enabled = true;
                FilterConditioncombobox.DataSource = textFilter;
            }

            OnFilterChanged();
        }

        /// <summary>
        /// Event triggered while MultiColumnCombobox's Text changed
        /// </summary>
        /// <param name="sender">Sender of this event</param>
        /// <param name="e">Event parameter</param>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            FilterText = this.multiColumnComboBox1.TextBox.Text;
            OnFilterChanged();
        }

        /// <summary>
        /// Event triggered while Filter condtion changed
        /// </summary>
        /// <param name="sender">Sender of this event</param>
        /// <param name="e">Event parameter</param>
        private void FilterConditioncombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterColumn = FilterConditioncombobox.SelectedValue.ToString();
            OnFilterChanged();
        }

        #endregion

        #region Filter 
        /// <summary>
        /// Gets or sets the filter text
        /// </summary>
        string FilterText
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the property in which filtering will be performed
        /// </summary>
        public string FilterColumn
        {
            get;
            set;
        }

        private string filterOption = "All Columns";
        /// <summary>
        /// Gets or sets the Filter option it determines how to filter the items
        /// </summary>
        public string FilterProperty
        {
            get { return filterOption; }
            set
            {
                filterOption = value;
            }
        }

        /// <summary>
        /// Assigning the customized filter format to Filter
        /// </summary>
        private void OnFilterChanged()
        {
            this.multiColumnComboBox1.Filter = FilterRecords;
        }

        /// <summary>
        /// Filter the items based on the filter option
        /// </summary>
        /// <param name="o">Item to check for filter</param>
        /// <returns>Wheter the item can comes under filtered items or not</returns>
        public bool FilterRecords(object o)
        {
            var item = o as OrderInfo;
            if (item != null && FilterText.Equals(""))
            {
                return true;
            }
            else
            {
                if (item != null)
                {
                    if (FilterProperty.Equals("All Columns"))
                    {
                        if (item.OrderID.ToString().Contains(FilterText) ||
                            item.CustomerID.ToLower().Contains(FilterText.ToLower()) || item.ContactNumber.ToString().Contains(FilterText.ToLower()) ||
                            item.ProductName.ToString().ToLower().Contains(FilterText.ToLower()) || item.Quantity.ToString().ToLower().Contains(FilterText.ToLower()) ||
                            item.ShipCountry.ToString().ToLower().Contains(FilterText.ToLower()) ||
                            item.OrderDate.ToString().ToLower().Contains(FilterText.ToLower()))
                            return true;
                        return false;
                    }
                    else
                    {
                        if (FilterColumn == null || FilterColumn.Equals("Contains"))
                            FilterColumn = "Contains";
                        else if (FilterColumn.Equals("StartsWith"))
                            FilterColumn = "StartsWith";
                        else if (FilterColumn.Equals("EndsWith"))
                            FilterColumn = "EndsWith";
                        bool result = MakeStringFilter(item, FilterProperty, FilterColumn);
                        return result;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Perform filter with filteroption for particular column
        /// </summary>
        /// <param name="item">Item to check for filter</param>
        /// <param name="filterOption">Filter option </param>
        /// <param name="filterProperty">Filter property</param>
        /// <returns></returns>
        private bool MakeStringFilter(OrderInfo item, string filterOption, string filterProperty)
        {
            var value = item.GetType().GetProperty(filterOption);
            var exactValue = value.GetValue(item, null).ToString().ToLower();
            string text = FilterText.ToLower();
            var methods = typeof(string).GetMethods();
            if (methods.Count() != 0)
            {
                var methodInfo = methods.FirstOrDefault(method => method.Name == filterProperty);
                bool result = (bool)methodInfo.Invoke(exactValue, new object[] { text });
                return result;
            }
            else
                return false;
        }
        #endregion 
    }
}
