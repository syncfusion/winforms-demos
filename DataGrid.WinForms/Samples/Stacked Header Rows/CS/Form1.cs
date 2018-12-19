using Syncfusion.WinForms.DataGrid;
using System.Windows.Forms;
using DemoCommon.Grid;
using Syncfusion.WinForms.DataGrid.Enums;

namespace StackedHeaderRows
{
    public partial class Form1 : Form
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();
            OrderInfoCollection collection = new OrderInfoCollection();
            sfDataGrid.DataSource = collection.OrdersListDetails;
            GridSettings();
        }

        #endregion

        #region Grid Settings

        /// <summary>
        /// Grid Settings for better Look and Feel.
        /// </summary>
        private void GridSettings()
        {
            var stackedHeaderRow = new StackedHeaderRow();
            stackedHeaderRow.StackedColumns.Add(new StackedColumn() { ChildColumns = "OrderID,CustomerID,ProductName,OrderDate,Quantity,UnitPrice,ContactNumber,ShipCountry", HeaderText = "Order Shipment Details" });
            sfDataGrid.StackedHeaderRows.Add(stackedHeaderRow);

            var stackedHeaderRow1 = new StackedHeaderRow();
            stackedHeaderRow1.StackedColumns.Add(new StackedColumn() { ChildColumns = "OrderID,OrderDate", HeaderText = "Order Details" });
            stackedHeaderRow1.StackedColumns.Add(new StackedColumn() { ChildColumns = "CustomerID,ContactNumber,", HeaderText = "Customer Details" });
            stackedHeaderRow1.StackedColumns.Add(new StackedColumn() { ChildColumns = "ProductName,Quantity,UnitPrice,ShipCountry", HeaderText = "Product Details" });

            sfDataGrid.StackedHeaderRows.Add(stackedHeaderRow1);
        }

        #endregion
    }
}
