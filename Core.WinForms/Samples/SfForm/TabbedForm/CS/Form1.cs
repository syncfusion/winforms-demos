#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabbedForm
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : SfTabbedForm
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();

            SfTabbedFormControl tabbedFormControl = new SfTabbedFormControl();

            var tabPage1 = new TabPageAdv() { Text = "DataGrid" };
            var tabPage2 = new TabPageAdv() { Text = "Tab2" };
            var tabPage3 = new TabPageAdv() { Text = "Tab3" };
            var tabPage4 = new TabPageAdv() { Text = "Tab4" };
            var tabPage5 = new TabPageAdv() { Text = "Tab5" };

            tabbedFormControl.Tabs.Add(tabPage1);
            tabbedFormControl.Tabs.Add(tabPage2);
            tabbedFormControl.Tabs.Add(tabPage3);
            tabbedFormControl.Tabs.Add(tabPage4);
            tabbedFormControl.Tabs.Add(tabPage5);

            SfDataGrid dataGrid = new SfDataGrid();
            dataGrid.Dock = DockStyle.Fill;
            dataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            var orderInfo = new OrderInfoCollection();
            dataGrid.DataSource = orderInfo.OrdersListDetails;

            tabPage1.Controls.Add(dataGrid);

            this.Controls.Add(tabbedFormControl);

            this.TabbedFormControl = tabbedFormControl;
			this.BackColor = this.Style.TitleBar.BackColor;
        }
        #endregion

        #region Icon Handlers
        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
        }

        #endregion

    }
}
