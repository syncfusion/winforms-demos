#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.Input.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetailsViewConditionalFormatting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SampleCustomization();
            this.Load += Form1_Load;
            this.sfDataGrid1.QueryCellStyle += FirstLevelSourceDataGrid_QueryCellStyle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.sfDataGrid1.ExpandAllDetailsView();
        }

        /// <summary>
        /// Sets the sample customization settings.
        /// </summary>
        private void SampleCustomization()
        {
            this.sfDataGrid1.AllowEditing = true;
            this.sfDataGrid1.AllowGrouping = true;
            this.sfDataGrid1.AutoGenerateColumns = false;
            this.sfDataGrid1.AllowResizingColumns = true;
            this.sfDataGrid1.SelectionMode = GridSelectionMode.Single;

            OrderInfoRepository orderInfo = new OrderInfoRepository();
            this.sfDataGrid1.DataSource = orderInfo.GetOrdersDetails(30);

            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalDigits = 0;
            nfi.NumberGroupSizes = new int[] { };

            this.sfDataGrid1.Columns.Add(new GridNumericColumn() { MappingName = "OrderID", HeaderText = "Order ID", NumberFormatInfo = nfi });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "CustomerID", HeaderText = "Customer ID" });
            this.sfDataGrid1.Columns.Add(new GridDateTimeColumn() { MappingName = "ShippingDate", HeaderText = "Shipping Date" });
            this.sfDataGrid1.Columns.Add(new GridNumericColumn() { MappingName = "EmployeeID", HeaderText = "Employee ID", NumberFormatInfo = nfi });


            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "ShipCity", HeaderText = "Ship City" });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "ShipCountry", HeaderText = "Ship Country" });
            this.sfDataGrid1.Columns.Add(new GridNumericColumn() { MappingName = "Freight", HeaderText = "Freight", FormatMode = FormatMode.Currency });
            this.sfDataGrid1.Columns.Add(new GridCheckBoxColumn() { MappingName = "IsClosed", HeaderText = "Is Closed", CheckBoxSize = new Size((int)DpiAware.LogicalToDeviceUnits(14.0f), (int)DpiAware.LogicalToDeviceUnits(14.0f)) });

            #region Relation Creation
            GridViewDefinition viewDefinition = new GridViewDefinition();
            viewDefinition.RelationalColumn = "OrderDetails";
            SfDataGrid firstLevelSourceDataGrid = new SfDataGrid();
            firstLevelSourceDataGrid.AutoGenerateColumns = false;
            firstLevelSourceDataGrid.RowHeight = (int)DpiAware.LogicalToDeviceUnits(21.0f);
            firstLevelSourceDataGrid.AutoSizeColumnsMode = AutoSizeColumnsMode.Fill;
            firstLevelSourceDataGrid.Columns.Add(new GridNumericColumn() { MappingName = "OrderID", HeaderText = "Order ID", NumberFormatInfo = nfi });
            firstLevelSourceDataGrid.Columns.Add(new GridNumericColumn() { MappingName = "ProductID", HeaderText = "Product ID", NumberFormatInfo = nfi });
            firstLevelSourceDataGrid.Columns.Add(new GridNumericColumn() { MappingName = "UnitPrice", HeaderText = "Unit Price", NumberFormatInfo = nfi});
            firstLevelSourceDataGrid.Columns.Add(new GridNumericColumn() { MappingName = "Quantity", HeaderText = "Quantity", NumberFormatInfo = nfi });
            firstLevelSourceDataGrid.Columns.Add(new GridNumericColumn() { MappingName = "Discount", HeaderText = "Discount" });
            firstLevelSourceDataGrid.Columns.Add(new GridTextColumn() { MappingName = "CustomerID", HeaderText = "Customer ID" });
            firstLevelSourceDataGrid.Columns.Add(new GridDateTimeColumn() { MappingName = "OrderDate", HeaderText = "Order Date" });
            viewDefinition.DataGrid = firstLevelSourceDataGrid;
            firstLevelSourceDataGrid.QueryCellStyle += FirstLevelSourceDataGrid_QueryCellStyle;
            this.sfDataGrid1.DetailsViewDefinitions.Add(viewDefinition);
            #endregion

            this.sfDataGrid1.HideEmptyGridViewDefinition = true;
        }

        private void FirstLevelSourceDataGrid_QueryCellStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryCellStyleEventArgs e)
        {
            if (e.Column == null) return;

            var cellValue = e.DisplayText == null ? string.Empty : e.DisplayText.ToString();
            float value;
            
            if (e.Column.MappingName == "Discount")
            {
                double discount;
                if (double.TryParse(cellValue, out discount) && discount < 10)
                {
                    e.Style.BackColor = Color.Maroon;
                    e.Style.TextColor = Color.White;
                }
            }
            else if (e.Column.MappingName == "UnitPrice")
            {
                value = float.Parse(cellValue);
                if (value > 50)
                    e.Style.BackColor = Color.Aquamarine;
            }
            else if (e.Column.MappingName == "Quantity")
            {
                value = float.Parse(cellValue);
                if (value < 6)
                    e.Style.BackColor = Color.OrangeRed;
            }
        }
    }
}
