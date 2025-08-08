#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Windows.Forms;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Styles;

namespace Paging
{   
    public partial class Form1 : Form
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the Form.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            var data = new OrderInfoCollection();

            // Set the data source for the SfDataPager.
            sfDataPager1.DataSource = data.OrdersListDetails;
            sfDataPager1.PageSize = 50;
            sfDataGrid.DataSource = sfDataPager1.PagedSource;
        }

        #endregion 
    }
}
