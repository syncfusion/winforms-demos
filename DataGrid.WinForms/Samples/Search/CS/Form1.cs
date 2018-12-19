using Syncfusion.Data;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Search
{
    public partial class Form1 : Form
    {
        #region Fields
        OrderInfoCollection orderInfo;
        SearchPanel panel;
        #endregion

        #region Constructor
        public Form1()
        {
            InitializeComponent();
            orderInfo = new OrderInfoCollection();
            this.sfDataGrid1.DataSource = orderInfo.OrdersListDetails;
            panel = new SearchPanel(this.sfDataGrid1);
            sfDataGrid1.Controls.Add(panel);
            panel.BringToFront();
            panel.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            panel.Location = sfDataGrid1.TableControl.PointToClient(new Point(sfDataGrid1.Width - (panel.Width) - 8, 63));
            panel.Show();
            sfDataGrid1.TableControl.KeyDown += TableControl_KeyDown;
        }

        void TableControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                panel.Visible = true;
            }
        }
        #endregion
    }
}
