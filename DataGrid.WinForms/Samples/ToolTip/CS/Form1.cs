using Syncfusion.Data;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;

namespace Tooltip
{
    public partial class Form1 : Form
    {
        #region Fields
        OrderInfoCollection orderInfo;
        #endregion

        #region Constuctor
        public Form1()
        {
            InitializeComponent();
            orderInfo = new OrderInfoCollection();
            this.sfDataGrid1.DataSource = orderInfo.OrdersListDetails;
            this.sfDataGrid1.ToolTipOpening += SfDataGrid1_ToolTipOpening;
        }

        #region ToolTipOpeningEvent
        private void SfDataGrid1_ToolTipOpening(object sender, ToolTipOpeningEventArgs e)
        {
            switch (e.DisplayText)
            {
                case "FRANS":
                    e.ToolTipInfo.Items[0].Text = String.Empty;
                    e.ToolTipInfo.Items[0].Image = Image.FromFile(@"../../Images/FRANS.png");
                    break;
                case "FOLKO":
                    e.ToolTipInfo.Items[0].Text = String.Empty;
                    e.ToolTipInfo.Items[0].Image = Image.FromFile(@"../../Images/FOLKO.png");
                    break;
                case "MEREP":
                    e.ToolTipInfo.Items[0].Text = String.Empty;
                    e.ToolTipInfo.Items[0].Image = Image.FromFile(@"../../Images/MEREP.png");
                    break;
                case "ALFKI":
                    e.ToolTipInfo.Items[0].Text = String.Empty;
                    e.ToolTipInfo.Items[0].Image = Image.FromFile(@"../../Images/ALFKI.png");
                    break;
                case "FURIB":
                    e.ToolTipInfo.Items[0].Text = String.Empty;
                    e.ToolTipInfo.Items[0].Image = Image.FromFile(@"../../Images/FURIB.png");
                    break;
                case "SEVES":
                    e.ToolTipInfo.Items[0].Text = String.Empty;
                    e.ToolTipInfo.Items[0].Image = Image.FromFile(@"../../Images/SEVES.png");
                    break;
                case "SIMOB":
                    e.ToolTipInfo.Items[0].Text = String.Empty;
                    e.ToolTipInfo.Items[0].Image = Image.FromFile(@"../../Images/SIMOB.png");
                    break;
                case "VAFFE":
                    e.ToolTipInfo.Items[0].Text = String.Empty;
                    e.ToolTipInfo.Items[0].Image = Image.FromFile(@"../../Images/VAFFE.png");
                    break;
                case "WARTH":
                    e.ToolTipInfo.Items[0].Text = String.Empty;
                    e.ToolTipInfo.Items[0].Image = Image.FromFile(@"../../Images/WARTH.png");
                    break;

            }
        }
        #endregion
        #endregion
    }
}
