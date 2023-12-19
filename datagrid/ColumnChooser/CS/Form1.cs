#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid.Styles;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Enums;
using System.Drawing;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.Data;
using System.Collections.ObjectModel;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System;
using System.IO;
using Syncfusion.Windows.Forms;

namespace ColumnChooser
{   
    public partial class Form1 : Form
    {
        #region 

        /// <summary>
        /// Specifies the ColumnChooser control.
        /// </summary>
        private Syncfusion.WinForms.DataGrid.Interactivity.ColumnChooser columnChooser;

        /// <summary>
        /// Specifies the column chooser pop up.
        /// </summary>
        private Syncfusion.WinForms.DataGrid.Interactivity.ColumnChooserPopup columnChooserPopup;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes the new instance of the Form1 class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            var data = new OrderInfoCollection();
            sfDataGrid.DataSource = data.OrdersListDetails;
            sfDataGrid.AutoSizeColumnsMode = AutoSizeColumnsMode.AllCells;
            columnChooser = new Syncfusion.WinForms.DataGrid.Interactivity.ColumnChooser(this.sfDataGrid);
            columnChooser.Location = new Point((int)DpiAware.LogicalToDeviceUnits(40), (int)DpiAware.LogicalToDeviceUnits(140));
            this.panel1.Controls.Add(columnChooser);
            columnChooserPopup = new Syncfusion.WinForms.DataGrid.Interactivity.ColumnChooserPopup(sfDataGrid);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Displays the CoumnChooserPopup control.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">An <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void OnShowColumnChooserPopupClick(object sender, System.EventArgs e)
        {
            columnChooserPopup.Show();
        }

        /// <summary>
        /// Updates the visibility of the column chooser control.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">An <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void OnShowColumnChooserCheckedChanged(object sender, EventArgs e)
        {
            columnChooser.Visible = chkShowColumnChooser.Checked;
        }

        #endregion
    }
}
