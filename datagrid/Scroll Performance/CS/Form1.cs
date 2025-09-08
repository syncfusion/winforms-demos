#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
