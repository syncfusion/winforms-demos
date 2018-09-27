using System.Drawing;
using System.Windows.Forms;
using DemoCommon.Grid;
using Syncfusion.WinForms.DataGrid.Styles;

namespace TraderGrid
{
    public partial class Form1 : Form
    {
        #region Constructor

        public Form1()
        {
            InitializeComponent();
            sfDataGrid.DataSource = new StocksDataCollection().Stocks;
        }

        #endregion
    }
}

