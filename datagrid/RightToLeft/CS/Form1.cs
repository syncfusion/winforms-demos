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

namespace RightToLeft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.sfDataGrid1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            SampleCustomization();
            ///this.sfDataGrid1.AutoSizeColumnsMode = AutoSizeColumnsMode.AllCells;
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
            this.sfDataGrid1.Columns.Add(new GridNumericColumn() { MappingName = "OrderID", HeaderText = "رقم التعريف الخاص بالطلب", NumberFormatInfo = nfi });            
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "ShipCity", HeaderText = "مدينة السفن" });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "ShipCountry", HeaderText = "السفينة البلد" });
            this.sfDataGrid1.Columns.Add(new GridDateTimeColumn() { MappingName = "ShippingDate", HeaderText = "السفينة البلد" });
            this.sfDataGrid1.Columns.Add(new GridNumericColumn() { MappingName = "Freight", HeaderText = "شحن", FormatMode = FormatMode.Currency });
            this.sfDataGrid1.Columns.Add(new GridCheckBoxColumn() { MappingName = "IsClosed", HeaderText = "مغلق", CheckBoxSize = new Size((int)DpiAware.LogicalToDeviceUnits(14.0f), (int)DpiAware.LogicalToDeviceUnits(14.0f)) });

            #region Relation Creation
            GridViewDefinition viewDefinition = new GridViewDefinition();
            viewDefinition.RelationalColumn = "OrderDetails";
            SfDataGrid firstLevelSourceDataGrid = new SfDataGrid();
            firstLevelSourceDataGrid.AutoGenerateColumns = false;
            firstLevelSourceDataGrid.Columns.Add(new GridNumericColumn() { MappingName = "OrderID", HeaderText = "رقم التعريف الخاص بالطلب", NumberFormatInfo = nfi });
            firstLevelSourceDataGrid.Columns.Add(new GridTextColumn() { MappingName = "Product", HeaderText = "المنتج" });
            firstLevelSourceDataGrid.Columns.Add(new GridTextColumn() { MappingName = "CustomerCity", HeaderText = "مدينة العملاء" });
            firstLevelSourceDataGrid.Columns.Add(new GridNumericColumn() { MappingName = "ProductID", HeaderText = "معرف المنتج", FormatMode = FormatMode.Numeric, NumberFormatInfo = nfi });
            //firstLevelSourceDataGrid.Columns.Add(new GridHyperlinkColumn() { MappingName = "HyperLink", HeaderText = "الارتباط التشعبي" });
            firstLevelSourceDataGrid.Columns.Add(new GridDateTimeColumn() { MappingName = "OrderDate", HeaderText = "تاريخ الطلب" });
            firstLevelSourceDataGrid.Columns.Add(new GridNumericColumn() { MappingName = "UnitPrice", HeaderText = "سعر الوحدة", FormatMode = FormatMode.Currency });
            CellStyleInfo cellStyle = new CellStyleInfo();
            cellStyle.HorizontalAlignment = HorizontalAlignment.Right;
            firstLevelSourceDataGrid.Columns.Add(new GridUnboundColumn() { MappingName = "QuantitiesPrice", HeaderText = "المجموع الكلي", Expression = "UnitPrice * Quantity", CellStyle = cellStyle });
            firstLevelSourceDataGrid.Columns.Add(new GridNumericColumn() { MappingName = "Discount", HeaderText = "خصم", FormatMode = FormatMode.Percent });
            firstLevelSourceDataGrid.Columns.Add(new GridImageColumn() { MappingName = "ImageLink", HeaderText = "بلد", ImageLayout = ImageLayout.Center });
            (firstLevelSourceDataGrid.Columns["ImageLink"] as GridImageColumn).CellStyle.VerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            (firstLevelSourceDataGrid.Columns["ImageLink"] as GridImageColumn).CellStyle.HorizontalAlignment = HorizontalAlignment.Center;
            viewDefinition.DataGrid = firstLevelSourceDataGrid;
            this.sfDataGrid1.DetailsViewDefinitions.Add(viewDefinition);

            firstLevelSourceDataGrid.AutoSizeColumnsMode = AutoSizeColumnsMode.Fill;
            this.sfDataGrid1.AutoSizeColumnsMode = AutoSizeColumnsMode.Fill;

            #endregion

            this.sfDataGrid1.HideEmptyGridViewDefinition = true;
        }
    }
}
