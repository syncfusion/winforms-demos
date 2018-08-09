using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Styles;
using Syncfusion.WinForms.DataGrid;
using System.Drawing;
using DemoCommon.Grid;
using Syncfusion.WinForms.DataGrid.Enums;

namespace UnboundColumns
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();
            ProductSalesDetailsCollection data = new ProductSalesDetailsCollection();
            sfDataGrid.DataSource = data.SalesInfo;
            GridSettings();
        }

        #endregion

        #region GridSettings
        /// <summary>
        /// Grid Settings for better Look and Feel.
        /// </summary>
        private void GridSettings()
        {
            //Initialize the unbound column
            GridUnboundColumn column = new GridUnboundColumn();
            column.CaseSensitive = false;
            column.AllowEditing = false;
            column.MappingName = "GrandTotal";
            column.HeaderText = "Grand Total";
            column.Expression = "Quantity*Amount";
            column.Format = "{0:C}";
            column.CellStyle = new CellStyleInfo() { BackColor = Color.LightGray, TextColor = Color.DarkBlue, HorizontalAlignment = HorizontalAlignment.Right };
            sfDataGrid.Columns.Add(column);

            //Initialize the unbound column
            GridUnboundColumn column1 = new GridUnboundColumn();
            column1.CaseSensitive = false;
            column1.AllowEditing = false;
            column1.MappingName = "DiscountAmount";
            column1.HeaderText = "Discount  Amount";
            column1.Expression = "Amount*Discount/100";
            column1.Format = "{0:C}";
            column1.CellStyle = new CellStyleInfo() { BackColor = Color.LightGray, TextColor = Color.DarkBlue, HorizontalAlignment = HorizontalAlignment.Right };
            sfDataGrid.Columns.Add(column1);

            //Initialize the unbound column
            GridUnboundColumn column2 = new GridUnboundColumn();
            column2.CaseSensitive = false;
            column2.AllowEditing = false;
            column2.HeaderText = "Product  Amount";
            column2.MappingName = "AmountForProduct";
            column2.Format = "{Amount} for {Product}";
            column2.CellStyle = new CellStyleInfo() { BackColor = Color.LightGray, TextColor = Color.DarkBlue, HorizontalAlignment = HorizontalAlignment.Right };
            sfDataGrid.Columns.Add(column2);
        }

        #endregion
    }
}
