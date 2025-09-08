#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using CustomFilterRow;
using Syncfusion.Data;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomFilterRow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OrderInfoCollection orderInfoCollection = new OrderInfoCollection();
            this.sfDataGrid1.AutoGenerateColumns = false;
            this.sfDataGrid1.DataSource = orderInfoCollection.OrderList;

            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalDigits = 0;
            nfi.NumberGroupSizes = new int[] { };

            this.sfDataGrid1.Columns.Add(new GridNumericColumn() { MappingName = "OrderID", HeaderText = "Order ID", NumberFormatInfo = nfi });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "CustomerID", HeaderText = "Customer ID"});
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "ProductName", HeaderText = "Product Name" });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "ShipName", HeaderText = "Ship Name" });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "ShipAddress", HeaderText = "Ship Address" });
            this.sfDataGrid1.Columns.Add(new GridDateTimeColumn() { MappingName = "OrderDate", HeaderText = "Order Date"});
            this.sfDataGrid1.Columns.Add(new GridCheckBoxColumn() { MappingName = "IsShipped", HeaderText = "Is Shipped", CheckBoxSize = new Size((int)DpiAware.LogicalToDeviceUnits(14.0f), (int)DpiAware.LogicalToDeviceUnits(14.0f)) });
            
            foreach (GridColumn column in this.sfDataGrid1.Columns)
            {
                column.AllowTextWrapping = false;
            }

            sfDataGrid1.FilterRowCellRenderers.Add("DateFilterExt", new GridDateTimeComboBoxRendererExt());
            sfDataGrid1.FilterRowCellRenderers.Add("NumericFilterExt", new GridNumericFilterComboBoxRendererExt());
            sfDataGrid1.FilterRowCellRenderers.Add("TextBoxFilterExt", new GridTextFilterComboBoxRendererExt());

            sfDataGrid1.Columns["OrderID"].FilterRowEditorType = "NumericFilterExt";
            sfDataGrid1.Columns["OrderDate"].FilterRowEditorType = "DateFilterExt";
            sfDataGrid1.Columns["CustomerID"].FilterRowEditorType = "TextBoxFilterExt";
            sfDataGrid1.Columns["ProductName"].ShowFilterRowOptions = false ;
            sfDataGrid1.Columns["ShipName"].FilterRowEditorType = "MultiSelectComboBox";
        }
    }
}
