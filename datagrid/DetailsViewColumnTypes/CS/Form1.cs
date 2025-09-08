#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using DemoCommon.Grid;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Styles;
using Syncfusion.WinForms.Input.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DetailsViewColumnTypes
{
    public partial class Form1 : GridDemoForm
    {
        public Form1()
        {
            InitializeComponent();
            SampleCustomization();
            this.Load += Form1_Load;
        }

        /// <summary>
        /// Occurs when the form is loading.
        /// </summary>
        /// <param name="sender">The sender of event.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
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

            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalDigits = 0;
            nfi.NumberGroupSizes = new int[] { };

            OrderInfoRepository orderInfo = new OrderInfoRepository();
            this.sfDataGrid1.DataSource = orderInfo.GetOrdersDetails(30);
            this.sfDataGrid1.Columns.Add(new GridNumericColumn() { MappingName = "OrderID", HeaderText = "Order ID", NumberFormatInfo = nfi });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "CustomerID", HeaderText = "Customer ID" });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "ShipCity", HeaderText = "Ship City" });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "ShipCountry", HeaderText = "Ship Country" });
            this.sfDataGrid1.Columns.Add(new GridDateTimeColumn() { MappingName = "ShippingDate", HeaderText = "Shipping Date" });
            this.sfDataGrid1.Columns.Add(new GridNumericColumn() { MappingName = "Freight", HeaderText = "Freight", FormatMode = FormatMode.Currency });
            this.sfDataGrid1.Columns.Add(new GridCheckBoxColumn() { MappingName = "IsClosed", HeaderText = "Is Closed", CheckBoxSize = new Size((int)DpiAware.LogicalToDeviceUnits(14.0f), (int)DpiAware.LogicalToDeviceUnits(14.0f))});

            #region Relation Creation
            GridViewDefinition viewDefinition = new GridViewDefinition();
            viewDefinition.RelationalColumn = "OrderDetails";
            SfDataGrid firstLevelSourceDataGrid = new SfDataGrid();
            firstLevelSourceDataGrid.AutoGenerateColumns = false;
            firstLevelSourceDataGrid.RowHeight = (int)DpiAware.LogicalToDeviceUnits(21.0f);
            firstLevelSourceDataGrid.Columns.Add(new GridNumericColumn() { MappingName = "OrderID", HeaderText = "Order ID", NumberFormatInfo = nfi });
            firstLevelSourceDataGrid.Columns.Add(new GridTextColumn() { MappingName = "CustomerID", HeaderText = "Customer ID" });
            firstLevelSourceDataGrid.Columns.Add(new GridTextColumn() { MappingName = "CustomerCity", HeaderText = "Customer City" });
            firstLevelSourceDataGrid.Columns.Add(new GridNumericColumn() { MappingName = "ProductID", HeaderText = "Product ID", FormatMode = FormatMode.Numeric, NumberFormatInfo = nfi });
            firstLevelSourceDataGrid.Columns.Add(new GridHyperlinkColumn() { MappingName = "HyperLink", HeaderText = "HyperLink" });
            firstLevelSourceDataGrid.Columns.Add(new GridDateTimeColumn() { MappingName = "OrderDate", HeaderText = "Order Date" });
            firstLevelSourceDataGrid.Columns.Add(new GridNumericColumn() { MappingName = "UnitPrice", HeaderText = "Unit Price", FormatMode = FormatMode.Currency });
            CellStyleInfo cellStyle = new CellStyleInfo();
            cellStyle.HorizontalAlignment = HorizontalAlignment.Right;
            firstLevelSourceDataGrid.Columns.Add(new GridUnboundColumn() { MappingName = "QuantitiesPrice", HeaderText = "Grand Total", Expression = "UnitPrice * Quantity", CellStyle = cellStyle });
            firstLevelSourceDataGrid.Columns.Add(new GridNumericColumn() { MappingName = "Discount", HeaderText = "Discount", FormatMode = FormatMode.Percent });
            firstLevelSourceDataGrid.Columns.Add(new GridImageColumn() { MappingName = "ImageLink", HeaderText = "Country", ImageLayout = ImageLayout.Center });
            (firstLevelSourceDataGrid.Columns["ImageLink"] as GridImageColumn).CellStyle.VerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            (firstLevelSourceDataGrid.Columns["ImageLink"] as GridImageColumn).CellStyle.HorizontalAlignment = HorizontalAlignment.Center;
            viewDefinition.DataGrid = firstLevelSourceDataGrid;            
            this.sfDataGrid1.DetailsViewDefinitions.Add(viewDefinition);
            #endregion

            this.sfDataGrid1.HideEmptyGridViewDefinition = true;
        }
    }
}
