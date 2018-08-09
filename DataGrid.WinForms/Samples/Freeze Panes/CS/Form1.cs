using System.Windows.Forms;
using DemoCommon.Grid;
using Syncfusion.WinForms.DataGrid.Enums;

namespace FreezePanes
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : Form
    {
        #region constructor
        public Form1()
        {
            // Required for Windows Form Designer support
            InitializeComponent();
            SalesInfoCollection collection = new SalesInfoCollection();
            sfDataGrid.DataSource = collection.YearlySalesDetails;            
        }

        #endregion       
    }
}
