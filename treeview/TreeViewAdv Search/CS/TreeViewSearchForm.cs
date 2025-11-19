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
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Tools.Controls;
using System.Collections;
using Syncfusion.Windows.Forms;

namespace TreeViewAdvSearchDemo
{
     
    public partial class TreeViewSearchForm : MetroForm
    {
        TreeViewAdvFindReplaceDialog dialog = null;
        public TreeViewSearchForm(TreeViewAdv tree)
        {
            InitializeComponent();
            TreeView = tree;
            this.replaceTextbox.KeyDown += new KeyEventHandler(TreeViewSearchForm_KeyDown);
            this.findTextBox.KeyDown += new KeyEventHandler(TreeViewSearchForm_KeyDown);
            this.comboBox3.KeyDown += new KeyEventHandler(TreeViewSearchForm_KeyDown);
            this.SearchOptionCombo.KeyDown += new KeyEventHandler(TreeViewSearchForm_KeyDown);
            this.SearchRangeCombo.KeyDown += new KeyEventHandler(TreeViewSearchForm_KeyDown);
            this.KeyDown += new KeyEventHandler(TreeViewSearchForm_KeyDown);
            this.TreeView.InactiveSelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))));
            dialog = new TreeViewAdvFindReplaceDialog(this.TreeView);
            dialog.Find("india", TreeViewSearchOption.MatchWholeText, TreeViewSearchRange.TreeView);
            Array searchRange = Enum.GetValues(typeof(TreeViewSearchRange));
            for (int i = 0; i < searchRange.Length; i++)
            {
                this.SearchRangeCombo.Items.Add(searchRange.GetValue(i));
            }
            Array SearchOptions = Enum.GetValues(typeof(TreeViewSearchOption));
            for (int i = 0; i < SearchOptions.Length; i++)
            {
                this.SearchOptionCombo.Items.Add(SearchOptions.GetValue(i));
            }
            this.button1.ThemeName = this.button2.ThemeName = 
                this.button3.ThemeName = this.button4.ThemeName = this.button5.ThemeName = "Office2019Colorful";
            this.comboBox3.ThemeName= this.SearchOptionCombo.ThemeName=this.SearchRangeCombo.ThemeName= "Office2019Colorful";
            this.findTextBox.ThemeName = this.replaceTextbox.ThemeName = "Office2019Colorful";
            Array NodeSearchType = Enum.GetValues(typeof(TreeViewSearchNavigation));
            for (int i = 0; i < NodeSearchType.Length; i++)
            {
                this.comboBox3.Items.Add(NodeSearchType.GetValue(i));
            }
            this.comboBox3.SelectedIndexChanged += new EventHandler(comboBox3_SelectedIndexChanged);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.SearchOptionCombo.SelectedIndex = 0;
            this.SearchRangeCombo.SelectedIndex = 0;
            this.comboBox3.SelectedIndex = 1;
            this.findTextBox.Select();
        }

        void TreeViewSearchForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                this.Close();
        }

        void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            dialog.TreeViewSearchNavigation = (TreeViewSearchNavigation)this.SearchRangeCombo.Items[this.comboBox3.Items.IndexOf(this.comboBox3.SelectedItem)];
        }

        private void SearchRangeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dialog.TreeViewSearchRange = (TreeViewSearchRange)this.SearchRangeCombo.Items[this.SearchRangeCombo.Items.IndexOf(this.SearchRangeCombo.SelectedItem)];
        }

        private void SearchOptionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dialog.TreeViewSearchOption = (TreeViewSearchOption)this.SearchOptionCombo.Items[this.SearchOptionCombo.Items.IndexOf(this.SearchOptionCombo.SelectedItem)];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private TreeViewAdv m_treeview;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TreeViewAdv TreeView
        {
            get { return m_treeview; }
            set 
            { 
                if(m_treeview != value)
                m_treeview = value; 
            }
        }

        //Find 
        private void button1_Click(object sender, EventArgs e)
        {
            dialog.Find(this.findTextBox.Text);
        }

        //Find All
        private void button2_Click(object sender, EventArgs e)
        {
            dialog.FindAll(this.findTextBox.Text);
        }

        //Replace
        private void button3_Click(object sender, EventArgs e)
        {
            this.TreeView.SelectedNodes.Clear();
            if(dialog.Find(this.findTextBox.Text))
                dialog.Replace(this.replaceTextbox.Text);
        }

        //Replace All
        private void button4_Click(object sender, EventArgs e)
        {
            this.TreeView.SelectedNodes.Clear();
            if (dialog.FindAll(this.findTextBox.Text))
                dialog.ReplaceAll(this.replaceTextbox.Text);
        }
    }
}
