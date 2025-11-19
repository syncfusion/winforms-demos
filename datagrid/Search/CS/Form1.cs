#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Data;
using Syncfusion.Windows.Forms;
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
            panel.Location = sfDataGrid1.TableControl.PointToClient(new Point(sfDataGrid1.Width - (panel.Width) - (int)DpiAware.LogicalToDeviceUnits(8f), (int)DpiAware.LogicalToDeviceUnits(63f)));
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
