using System.Windows.Forms;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Styles;

namespace Paging
{   
    public partial class Form1 : Form
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the Form.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            var data = new OrderInfoCollection();

            // Set the data source for the SfDataPager.
            sfDataPager1.DataSource = data.OrdersListDetails;
            sfDataPager1.PageSize = 50;
            sfDataGrid.DataSource = sfDataPager1.PagedSource;
        }

        #endregion 
    }
}
