using Syncfusion.WinForms.DataGrid;
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

namespace DetailsView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            SampleCustomization();
        }

        /// <summary>
        /// Sets the sample customization settings.
        /// </summary>
        private void SampleCustomization()
        {            
            OrderInfoRepository order = new OrderInfoRepository();
            List<OrderInfo> orderDetails = order.GetOrdersDetails(100);
            this.sfDataGrid1.DataSource = orderDetails;

            GridViewDefinition orderDetailsView = new GridViewDefinition();
            orderDetailsView.RelationalColumn = "OrderDetails";

            SfDataGrid childGrid = new SfDataGrid();
            childGrid.AutoGenerateColumns = false;
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalDigits = 0;
            nfi.NumberGroupSizes = new int[] { };
            childGrid.Columns.Add(new GridNumericColumn() { MappingName = "OrderID", HeaderText = "Order ID", NumberFormatInfo = nfi });
            childGrid.Columns.Add(new GridNumericColumn() { MappingName = "ProductID", HeaderText = "Product ID", NumberFormatInfo = nfi });
            childGrid.Columns.Add(new GridNumericColumn() { MappingName = "UnitPrice", HeaderText = "Unit Price", FormatMode = FormatMode.Currency });
            childGrid.Columns.Add(new GridNumericColumn() { MappingName = "Quantity" });
            childGrid.Columns.Add(new GridNumericColumn() { MappingName = "Discount", FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Percent });
            childGrid.Columns.Add(new GridTextColumn() { MappingName = "CustomerID", HeaderText = "Customer ID"});
            childGrid.Columns.Add(new GridDateTimeColumn() { MappingName = "OrderDate", HeaderText = "Order Date" });
            orderDetailsView.DataGrid = childGrid;
            this.sfDataGrid1.DetailsViewDefinitions.Add(orderDetailsView);
        }
    }
}
