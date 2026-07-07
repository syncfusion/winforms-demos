using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrollingPerfomance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StocksInfoCollection collection = new StocksInfoCollection();
            int columcount = this.sfDataGrid1.ColumnCount;
            sfDataGrid1.DataSource = collection.GenerateDataSource(1000);        
        }
    }
}
