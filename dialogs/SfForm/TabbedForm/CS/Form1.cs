#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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
using System.Collections.ObjectModel;
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
        TabPageAdv clickedTab;
        SfTabbedFormControl tabbedFormControl;
        #region Constructor
        public Form1()
        {
            InitializeComponent();

            tabbedFormControl = new SfTabbedFormControl();
            tabbedFormControl.TabPrimitiveMode = TabPrimitiveMode.DropDown | TabPrimitiveMode.FirstTab |
                TabPrimitiveMode.LastTab | TabPrimitiveMode.NextPage | TabPrimitiveMode.NextTab |
                TabPrimitiveMode.PreviousPage | TabPrimitiveMode.PreviousTab;

            var tabPage1 = new TabPageAdv() { Text = "DataGrid" };
            tabbedFormControl.Tabs.Add(tabPage1);

            for (int i = 2; i <= 15; i++)
                tabbedFormControl.Tabs.Add(new TabPageAdv() { Text = "Tab" + i });

            SfDataGrid dataGrid = new SfDataGrid();
            dataGrid.Dock = DockStyle.Fill;
            dataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            var orderInfo = new OrderInfoCollection();
            dataGrid.DataSource = orderInfo.OrdersListDetails;

            tabPage1.Controls.Add(dataGrid);

            this.Controls.Add(tabbedFormControl);

            this.TabbedFormControl = tabbedFormControl;
			this.BackColor = this.Style.TitleBar.BackColor;

            #region Context Menu Customization
            ContextMenuStrip tabContextMenu = new ContextMenuStrip();
            tabContextMenu.Items.Add("Close", null, OnCloseMenuClicked);
            tabContextMenu.Items.Add("Close all but this", null, OnCloseAllMenuClicked);
            tabContextMenu.Items.Add("Close tabs to the right", null, OnCloseTabsToRightMenuClicked);
            tabbedFormControl.TabContextMenu = tabContextMenu;
            tabbedFormControl.ContextMenuOpening += TabbedFormControl_ContextMenuOpening;
            tabbedFormControl.AllowDraggingTabs = true;
            #endregion
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

        #region ContextMenu events

        /// <summary>
        /// Occurs when context menu on the tab is opening.
        /// </summary>
        private void TabbedFormControl_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
        {
            clickedTab = e.Tab;
            var tabs = tabbedFormControl.Tabs.OfType<TabPageAdv>();
            var tabsExistsInRight = tabs.Any(tab => tab.TabIndex > e.Tab.TabIndex);

            if (tabs.Count() == 1)
            {
                e.ContextMenu.Items[1].Enabled = false;
                e.ContextMenu.Items[2].Enabled = false;
            }
            else if (!tabsExistsInRight)
                e.ContextMenu.Items[2].Enabled = false;
            else
            {
                e.ContextMenu.Items[0].Enabled = true;
                e.ContextMenu.Items[1].Enabled = true;
                e.ContextMenu.Items[2].Enabled = true;
            }
        }

        /// <summary>
        /// Occurs when Close menu item is clicked.
        /// </summary>
        private void OnCloseMenuClicked(object sender, EventArgs e)
        {
            if (clickedTab != null)
            {
                if (this.TabbedFormControl.Tabs.OfType<TabPageAdv>().Count() == 1)
                    this.Close();
                else
                    clickedTab.Close();
            }
        }

        /// <summary>
        /// /// <summary>
        /// Occurs when Close all but this menu item is clicked.
        /// </summary>
        private void OnCloseAllMenuClicked(object sender, EventArgs e)
        {
            var tabs = tabbedFormControl.Tabs.OfType<TabPageAdv>();
            var removedTabs = new ObservableCollection<TabPageAdv>();
            foreach (var tab in tabs)
            {
                if (clickedTab != null && tab != clickedTab)
                    removedTabs.Add(tab);
            }

            foreach (var tab in removedTabs)
            {
                tab.Close();
            }
        }

        /// <summary>
        /// /// <summary>
        /// Occurs when Close right to this menu item is clicked.
        /// </summary>
        private void OnCloseTabsToRightMenuClicked(object sender, EventArgs e)
        {
            var tabs = tabbedFormControl.Tabs.OfType<TabPageAdv>();
            var removedTabs = new ObservableCollection<TabPageAdv>();
            foreach (var tab in tabs)
            {
                if (clickedTab != null && tab.TabIndex > clickedTab.TabIndex)
                    removedTabs.Add(tab);
            }

            foreach (var tab in removedTabs)
            {
                tab.Close();
            }
        }
        #endregion
    }
}
