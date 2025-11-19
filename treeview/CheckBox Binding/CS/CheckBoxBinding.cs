#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;
using Syncfusion.Windows.Forms.Tools;
using System.Collections.ObjectModel;

namespace TreeViewAdvSearchDemo
{
    public partial class CheckBoxBinding : SfForm
    {
        ObservableCollection<TreeNodeAdv> checkedNode;
        ListView list = new ListView();
        public CheckBoxBinding()
        {
            InitializeComponent();
            this.treeViewAdv1.ItemHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Padding = new System.Windows.Forms.Padding(10,0,10,10);
            this.MinimumSize = this.Size;
            this.treeViewAdv1.SelectionMode = Syncfusion.Windows.Forms.Tools.TreeSelectionMode.MultiSelectAll;
            checkedNode = new ObservableCollection<TreeNodeAdv>();
            PopulateListView();
            listView1.DisplayMember = "Text";
            this.listView1.DataSource = checkedNode;
            this.treeViewAdv1.AfterCheck += TreeViewAdv1_AfterCheck;
            this.checkedNode.CollectionChanged += CheckedNode_CollectionChanged;
            this.treeViewAdv1.ThemeName = "Office2019Colorful";
        }

        private void CheckedNode_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.listView1.DataSource = this.checkedNode;
        }

        private void TreeViewAdv1_AfterCheck(object sender, TreeNodeAdvEventArgs e)
        {
           if(e.Node.Checked)
            {
                this.checkedNode.Add(e.Node);
                this.richTextBox1.AppendText("\"" + e.Node.Text + "\" node is added.\n");
            }
           else
            {
                this.checkedNode.Remove(e.Node);
                this.richTextBox1.AppendText("\"" + e.Node.Text + "\" node is removed.\n");
            }
        }

        private void PopulateListView()
        {
            foreach(TreeNodeAdv node in this.treeViewAdv1.CheckedNodes)
            {
                this.checkedNode.Add(node);
            }
        }

    }
}
