#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
#if NETCORE
                    e.ToolTipInfo.Items[0].Image = Image.FromFile("../../../Images/FRANS.png");
#else
                    e.ToolTipInfo.Items[0].Image = Image.FromFile(@"../../Images/FRANS.png");
#endif
                    break;
                case "FOLKO":
                    e.ToolTipInfo.Items[0].Text = String.Empty;
#if NETCORE
                    e.ToolTipInfo.Items[0].Image = Image.FromFile("../../../Images/FOLKO.png");
#else
                    e.ToolTipInfo.Items[0].Image = Image.FromFile(@"../../Images/FOLKO.png");
#endif
                    break;
                case "MEREP":
                    e.ToolTipInfo.Items[0].Text = String.Empty;
#if NETCORE
                    e.ToolTipInfo.Items[0].Image = Image.FromFile("../../../Images/MEREP.png");
#else
                    e.ToolTipInfo.Items[0].Image = Image.FromFile(@"../../Images/MEREP.png");
#endif
                    break;
                case "ALFKI":
                    e.ToolTipInfo.Items[0].Text = String.Empty;
#if NETCORE
                    e.ToolTipInfo.Items[0].Image = Image.FromFile("../../../Images/ALFKI.png");
#else
                    e.ToolTipInfo.Items[0].Image = Image.FromFile(@"../../Images/ALFKI.png");
#endif
                    break;
                case "FURIB":
                    e.ToolTipInfo.Items[0].Text = String.Empty;
#if NETCORE
                    e.ToolTipInfo.Items[0].Image = Image.FromFile("../../../Images/FURIB.png");
#else
                    e.ToolTipInfo.Items[0].Image = Image.FromFile(@"../../Images/FURIB.png");
#endif
                    break;
                case "SEVES":
                    e.ToolTipInfo.Items[0].Text = String.Empty;
#if NETCORE
                    e.ToolTipInfo.Items[0].Image = Image.FromFile("../../../Images/SEVES.png");
#else
                    e.ToolTipInfo.Items[0].Image = Image.FromFile(@"../../Images/SEVES.png");
#endif
                    break;
                case "SIMOB":
                    e.ToolTipInfo.Items[0].Text = String.Empty;
#if NETCORE
                    e.ToolTipInfo.Items[0].Image = Image.FromFile("../../../Images/SIMOB.png");
#else
                    e.ToolTipInfo.Items[0].Image = Image.FromFile(@"../../Images/SIMOB.png");
#endif
                    break;
                case "VAFFE":
                    e.ToolTipInfo.Items[0].Text = String.Empty;
#if NETCORE
                    e.ToolTipInfo.Items[0].Image = Image.FromFile("../../../Images/VAFFE.png");
#else
                    e.ToolTipInfo.Items[0].Image = Image.FromFile(@"../../Images/VAFFE.png");
#endif
                    break;
                case "WARTH":
                    e.ToolTipInfo.Items[0].Text = String.Empty;
#if NETCORE
                    e.ToolTipInfo.Items[0].Image = Image.FromFile("../../../Images/WARTH.png");
#else
                    e.ToolTipInfo.Items[0].Image = Image.FromFile(@"../../Images/WARTH.png");
#endif
                    break;

            }
        }
        #endregion
        #endregion
    }
}
