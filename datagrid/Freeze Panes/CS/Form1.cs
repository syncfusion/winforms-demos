#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Windows.Forms;
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
