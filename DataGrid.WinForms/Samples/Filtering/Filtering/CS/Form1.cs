using Filtering;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Enums;

namespace Filtering
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor

        /// <summary>
        /// Initializes the new instance for the Form.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            sfDataGrid1.DataSource = new OrderInfoCollection().OrdersListDetails;
            this.GridSettings();
        }

        #endregion

        #region Grid Settings

        /// <summary>
        /// Grid Settings for better Look and Feel.
        /// </summary>
        private void GridSettings()
        {
            FilterText = txtFilterValue.Text;
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
            lblFilterCondition.Hide();
            cmbFilterCondition.Hide();

            cmbFilterColumn.DataSource = list;

            textFilter.Add("Contains");
            textFilter.Add("StartsWith");
            textFilter.Add("EndsWith");

            numberFilter.Add("Equals");
            numberFilter.Add("LessThan");
            numberFilter.Add("GreaterThan");
            numberFilter.Add("NotEquals");

            textColumns.Add("CustomerID");
            textColumns.Add("ProductName");
            textColumns.Add("ShipCountry");
        }

        #endregion

        ArrayList numberFilter = new ArrayList();
        ArrayList textFilter = new ArrayList();
        ArrayList textColumns = new ArrayList();

        private void cmbFilterColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterOption = cmbFilterColumn.SelectedValue.ToString();
            if (cmbFilterColumn.SelectedValue.ToString() == "All Columns")
            {
                lblFilterCondition.Visible = false;
                cmbFilterCondition.Visible = false;
            }
            else
            {
                lblFilterCondition.Visible = true;
                cmbFilterCondition.Visible = true;

                if (textColumns.Contains(cmbFilterColumn.SelectedValue))
                {
                    cmbFilterCondition.DataSource = textFilter;
                }
                else
                    cmbFilterCondition.DataSource = numberFilter;
            }

            OnFilterChanged();
        }

        string FilterText
        {
            get;
            set;
        }

        public string FilterCondition
        {
            get;
            set;
        }

        private string filterOption = "All Columns";

        public string FilterOption
        {
            get { return filterOption; }
            set
            {
                filterOption = value;
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            FilterText = txtFilterValue.Text;
            OnFilterChanged();
        }

        private void OnFilterChanged()
        {
            if (sfDataGrid1.View != null)
            {
                sfDataGrid1.View.Filter = FilerRecords;
                sfDataGrid1.View.RefreshFilter();
            }
        }

        public bool FilerRecords(object o)
        {
            double res;
            bool checkNumeric = double.TryParse(FilterText, out res);
            var item = o as OrderInfo;
            if (item != null && FilterText.Equals(""))
            {
                return true;
            }
            else
            {
                if (item != null)
                {
                    if (checkNumeric && !FilterOption.Equals("All Columns"))
                    {
                        if (FilterCondition == null || FilterCondition.Equals("Contains") || FilterCondition.Equals("StartsWith") || FilterCondition.Equals("EndsWith"))
                            FilterCondition = "Equals";
                        bool result = MakeNumericFilter(item, FilterOption, FilterCondition);
                        return result;
                    }
                    else if (FilterOption.Equals("All Columns"))
                    {
                        if (item.OrderID.ToString().Contains(FilterText) ||
                            item.CustomerID.ToLower().Contains(FilterText.ToLower()) ||
                            item.ProductName.ToString().ToLower().Contains(FilterText.ToLower()) || item.Quantity.ToString().ToLower().Contains(FilterText.ToLower()) ||
                            item.ShipCountry.Contains(FilterText) ||
                            item.OrderDate.ToString().Contains(FilterText.ToLower()))
                            return true;
                        return false;
                    }
                    else
                    {
                        if (FilterCondition == null || FilterCondition.Equals("Equals") || FilterCondition.Equals("LessThan") || FilterCondition.Equals("GreaterThan") || FilterCondition.Equals("NotEquals"))
                            FilterCondition = "Contains";
                        bool result = MakeStringFilter(item, FilterOption, FilterCondition);
                        return result;
                    }
                }
            }

            return false;
        }

        private bool MakeStringFilter(OrderInfo o, string option, string condition)
        {
            var value = o.GetType().GetProperty(option);
            var exactValue = value.GetValue(o, null);
            exactValue = exactValue.ToString().ToLower();
            string text = FilterText.ToLower();
            var methods = typeof(string).GetMethods();
            if (methods.Count() != 0)
            {
                var methodInfo = methods.FirstOrDefault(method => method.Name == condition);
                bool result1 = (bool)methodInfo.Invoke(exactValue, new object[] { text });
                return result1;
            }
            else
                return false;
        }

        private bool MakeNumericFilter(OrderInfo o, string option, string condition)
        {
            var value = o.GetType().GetProperty(option);
            var exactValue = value.GetValue(o, null);
            double res;
            bool checkNumeric = double.TryParse(exactValue.ToString(), out res);
            if (checkNumeric)
            {
                switch (condition)
                {
                    case "Equals":
                        if (Convert.ToDouble(exactValue) == (Convert.ToDouble(FilterText)))
                            return true;
                        break;
                    case "GreaterThan":
                        if (Convert.ToDouble(exactValue) > Convert.ToDouble(FilterText))
                            return true;
                        break;
                    case "LessThan":
                        if (Convert.ToDouble(exactValue) < Convert.ToDouble(FilterText))
                            return true;
                        break;
                    case "NotEquals":
                        if (Convert.ToDouble(FilterText) != Convert.ToDouble(exactValue))
                            return true;
                        break;
                }
            }

            return false;
        }

        private void cmbFilterCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterCondition = cmbFilterCondition.SelectedValue.ToString();
            OnFilterChanged();
        }
    }
}
