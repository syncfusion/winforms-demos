using DemoCommon.Grid;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Windows.Forms;

namespace AddNewRow
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
            comboBox1.DataSource = Enum.GetValues(typeof(RowPosition));
            comboBox1.SelectedIndex = 1;
        }

        #endregion

        /// <summary>
        /// Occurs when changing the AddNewRow position in SfDataGrid.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event data.</param>
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            sfDataGrid.AddNewRowPosition = (RowPosition)comboBox1.SelectedItem;
        }

    }
}
