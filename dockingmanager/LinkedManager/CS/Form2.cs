#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;

namespace LinkedManager
{
    public partial class Form2 : SfForm
    {
        public Form2()
        {
            InitializeComponent();
            #region TreeNavigator menu items
            TreeMenuExt menu1 = new TreeMenuExt();
            menu1.Text = "Elementum";
            menu1.Height = 20;
            menu1.BackColor = Color.White;
            TreeMenuExt menu2 = new TreeMenuExt();
            menu2.Text = "Duis ";
            menu2.Height = 20;
            menu2.BackColor = Color.White;
            TreeMenuExt menu3 = new TreeMenuExt();
            menu3.Text = "Pulvinar ";
            menu3.Height = 20;
            menu3.BackColor = Color.White;
            TreeMenuExt menu4 = new TreeMenuExt();
            menu4.Text = "Quis";
            menu4.Height = 20;
            menu4.BackColor = Color.White;
            TreeMenuExt menu5 = new TreeMenuExt();
            menu5.Text = "Rerum ";
            menu5.Height = 20;
            menu5.BackColor = Color.White;
            TreeMenuExt menu6 = new TreeMenuExt();
            menu6.Text = "Lobortis ";
            menu6.Height = 20;
            menu6.BackColor = Color.White;
            this.treeNavigator1.Items.Add(menu1);
            this.treeNavigator1.Items.Add(menu2);
            this.treeNavigator1.Items.Add(menu3);
            this.treeNavigator1.Items.Add(menu4);
            this.treeNavigator1.Items.Add(menu5);
            this.treeNavigator1.Items.Add(menu6);
            TreeMenuExt meu1 = new TreeMenuExt();
            meu1.Text = "Suscipit ";
            meu1.Height = 20;
            meu1.BackColor = Color.White;
            TreeMenuExt meu2 = new TreeMenuExt();
            meu2.Text = "Nulla";
            meu2.Height = 20;
            meu2.BackColor = Color.White;
            TreeMenuExt meu3 = new TreeMenuExt();
            meu3.Text = "Condimentum ";
            meu3.Height = 20;
            meu3.BackColor = Color.White;
            TreeMenuExt meu4 = new TreeMenuExt();
            meu4.Text = "Habitasse ";
            meu4.Height = 20;
            meu4.BackColor = Color.White;
            TreeMenuExt meu5 = new TreeMenuExt();
            meu5.Text = "Voluptates ";
            meu5.Height = 20;
            meu5.BackColor = Color.White;
            TreeMenuExt meu6 = new TreeMenuExt();
            meu6.Text = "Feugiat ";
            meu6.Height = 20;
            meu6.BackColor = Color.White;
            this.treeNavigator2.Items.Add(meu1);
            this.treeNavigator2.Items.Add(meu2);
            this.treeNavigator2.Items.Add(meu3);
            this.treeNavigator2.Items.Add(meu4);
            this.treeNavigator2.Items.Add(meu5);
            this.treeNavigator2.Items.Add(meu6);

            TreeMenuExt me1 = new TreeMenuExt();
            me1.Text = "Rutrum ";
            me1.BackColor = Color.White;
            me1.Height = 20;
            TreeMenuExt me2 = new TreeMenuExt();
            me2.Text = "Dolor";
            me2.Height = 20;
            me2.BackColor = Color.White;
            TreeMenuExt me3 = new TreeMenuExt();
            me3.Text = "Luctus ";
            me3.Height = 20;
            me3.BackColor = Color.White;
            TreeMenuExt me4 = new TreeMenuExt();
            me4.Text = "Diam ";
            me4.Height = 20;
            me4.BackColor = Color.White;
            TreeMenuExt me5 = new TreeMenuExt();
            me5.Text = "Felis";
            me5.Height = 20;
            me5.BackColor = Color.White;
            this.treeNavigator3.Items.Add(me1);
            this.treeNavigator3.Items.Add(me2);
            this.treeNavigator3.Items.Add(me3);
            this.treeNavigator3.Items.Add(me4);
            this.treeNavigator3.Items.Add(me5);
            TreeMenuExt m1 = new TreeMenuExt();
            m1.Text = "Nunc";
            m1.Height = 20;
            m1.BackColor = Color.White;
            TreeMenuExt m2 = new TreeMenuExt();
            m2.Text = "Feugiat ";
            m2.Height = 20;
            m2.BackColor = Color.White;
            TreeMenuExt m3 = new TreeMenuExt();
            m3.Text = "Nullam ";
            m3.Height = 20;
            m3.BackColor = Color.White;
            TreeMenuExt m4 = new TreeMenuExt();
            m4.Text = "Mollis ";
            m4.Height = 20;
            m4.BackColor = Color.White;
            TreeMenuExt m5 = new TreeMenuExt();
            m5.Text = "Amet ";
            m5.Height = 20;
            m5.BackColor = Color.White;
            TreeMenuExt m6 = new TreeMenuExt();
            m6.Text = "Venenatis ";
            m6.Height = 20;
            m6.BackColor = Color.White;
            TreeMenuExt m7 = new TreeMenuExt();
            m7.Text = "Quisque";
            m7.Height = 20;
            m7.BackColor = Color.White;
            this.treeNavigator4.Items.Add(m1);
            this.treeNavigator4.Items.Add(m2);
            this.treeNavigator4.Items.Add(m3);
            this.treeNavigator4.Items.Add(m4);
            this.treeNavigator4.Items.Add(m5);
            this.treeNavigator4.Items.Add(m6);
            this.treeNavigator4.Items.Add(m7);
            m1.BackColor = Color.White;
            this.treeNavigator1.ItemBackColor = Color.White;
            this.treeNavigator2.ItemBackColor = Color.White;
            this.treeNavigator3.ItemBackColor = Color.White;
            this.treeNavigator4.ItemBackColor = Color.White;

            #endregion
            this.StartPosition = FormStartPosition.CenterParent;
            this.barItem1.Click += new EventHandler(barItem1_Click);
            this.barItem2.Click += new EventHandler(barItem2_Click);
            this.treeNavigator1.ParentPanel.AutoScroll = false;
            this.treeNavigator2.ParentPanel.AutoScroll = false;
            this.treeNavigator3.ParentPanel.AutoScroll = false;
            this.treeNavigator4.ParentPanel.AutoScroll = false;
#if NETCORE
            UpdatLayout();
#endif
            this.dockingManager1.DragProviderStyle = DragProviderStyle.VS2012;

        }
        int count = 1;
        public List<Form2> FormList = new List<Form2>();
        Form2 frm1;

        private void barItem1_Click(object sender, EventArgs e)
        {
            frm1 = new Form2();
            frm1.Text = "Docking Manager" + count.ToString();
            this.dockingManager1.AddToTargetManagersList(frm1.dockingManager1);
            frm1.dockingManager1.AddToTargetManagersList(this.dockingManager1);
            frm1.Show();
        }

        /// <summary>
        /// Update the dock layout
        /// </summary>
        private void UpdatLayout()
        {
            this.dockingManager1.DockControl(this.panel1, this, DockingStyle.Left, 161);
            this.dockingManager1.DockControl(this.panel2, this, DockingStyle.Left, 162);
            this.dockingManager1.DockControl(this.panel5, this, DockingStyle.Left, 310);
            this.dockingManager1.DockControl(this.panel4, this.panel5, DockingStyle.Bottom, 310);
            this.dockingManager1.DockControl(this.panel3, this, DockingStyle.Right, 150);

        }

        void frm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 frm = sender as Form2;
            this.FormList.Remove(frm);
        }

        private void barItem2_Click(object sender, EventArgs e)
        {
            if (this.barItem2.Checked)
                this.barItem2.Checked = false;
            else
                this.barItem2.Checked = true;
            if (frm1 != null)
            {
                if (barItem2.Checked)
                {
                    this.dockingManager1.AddToTargetManagersList(frm1.dockingManager1);
                    frm1.dockingManager1.AddToTargetManagersList(this.dockingManager1);
                }
                else
                {
                    this.dockingManager1.RemoveFromTargetManagersList(frm1.dockingManager1);
                    frm1.dockingManager1.RemoveFromTargetManagersList(this.dockingManager1);
                }
            }
        }
    }
}
