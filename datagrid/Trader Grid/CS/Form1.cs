#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Drawing;
using System.Windows.Forms;
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

