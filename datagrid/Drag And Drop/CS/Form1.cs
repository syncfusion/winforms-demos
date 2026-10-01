using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;

namespace DragAndDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Bind sample order data to the grid
            OrderInfoCollection collection = new OrderInfoCollection();
            this.sfDataGrid1.DataSource = collection.OrdersListDetails;

        }
    }
}
