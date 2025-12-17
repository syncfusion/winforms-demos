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
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using System.Collections;
using System.IO;
using Syncfusion.Windows.Forms.Tools.MultiColumnTreeView;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Controls;

namespace MultiColumnTreeViewDemo
{
    public partial class Form1 : SfForm
    {
        Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv treeColumnAdv1;
        Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv treeColumnAdv2;
        Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv treeColumnAdv3;

        public Form1()
        {
            InitializeComponent();

            Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdv root = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdv();
            DriveInfo drive = new DriveInfo(Environment.SystemDirectory);
            root.Text = drive.ToString();
            this.multiColumnTreeView1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdv[] {
            root});

            treeColumnAdv1 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv();
            treeColumnAdv2 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv();
            treeColumnAdv3 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv();

            treeColumnAdv1.HelpText = "Name";
            treeColumnAdv1.Highlighted = false;
            treeColumnAdv1.Text = "Name";
            treeColumnAdv1.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Highlight);
            treeColumnAdv1.AreaBackground = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, System.Drawing.Color.White, System.Drawing.Color.Snow);
            treeColumnAdv1.BorderStyle = BorderStyle.FixedSingle;

            treeColumnAdv2.HelpText = "Full Path";
            treeColumnAdv2.Highlighted = false;
            treeColumnAdv2.Text = "Full Path";
            treeColumnAdv2.Background = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.SystemColors.Highlight, System.Drawing.SystemColors.Highlight);
            treeColumnAdv2.BorderStyle = BorderStyle.FixedSingle;

            treeColumnAdv3.HelpText = "Date Modified";
            treeColumnAdv3.Highlighted = false;
            treeColumnAdv3.Text = "Date Modified";
            treeColumnAdv3.Background = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.SystemColors.Highlight, System.Drawing.SystemColors.Highlight);
            treeColumnAdv3.BorderStyle = BorderStyle.FixedSingle;

            this.multiColumnTreeView1.Columns.AddRange(new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv[]{
                treeColumnAdv1,treeColumnAdv2,treeColumnAdv3});
            this.multiColumnTreeView1.AutoSizeMode = Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.AutoSizeMode.Fill;
            this.Load += new EventHandler(MultiColumnTreeViewDemo_Load);
            this.multiColumnTreeView1.BeforeExpand += new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeViewAdvCancelableNodeEventHandler(multiColumnTreeView1_BeforeExpand);
            //this.MinimumSize = this.Size;
            this.treeColumnAdv1.BaseStyle = (this.multiColumnTreeView1.BaseStylePairs[2] as Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.StyleNamePair).Name;
            this.treeColumnAdv1.BorderStyle = BorderStyle.FixedSingle;
            this.treeColumnAdv2.BorderStyle = BorderStyle.FixedSingle;
            this.treeColumnAdv3.BorderStyle = BorderStyle.FixedSingle;
            visualStyleComboBox.Items.AddRange(new string[] { "Office2019Colorful", "Office2016Colorful", "Office2016DarkGray", "Office2016Black", "Office2016White" });
            visualStyleComboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            this.visualStyleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.visualStyleComboBox.SelectedIndex = 0;
            this.multiColumnTreeView1.FullRowSelect = true;
            this.singleSelectioncheckBox.Checked = true;
        }
       
        void MultiColumnTreeViewDemo_Load(object sender, EventArgs e)
        {
            this.multiColumnTreeView1.Nodes[0].Expanded = true;
            this.multiColumnTreeView1.SelectedNode = this.multiColumnTreeView1.Nodes[0];
            this.multiColumnTreeView1.Focus();
        }

        void multiColumnTreeView1_BeforeExpand(object sender, Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeViewAdvCancelableNodeEventArgs e)
        {
            try
            {
                //Checking whether the Node has been  expanded atleast once
                if (e.Node.ExpandedOnce) return;

                DirectoryInfo dir = null;
                DirectoryInfo[] subDir = null;
                if (this.multiColumnTreeView1.Nodes[0].Nodes.Count == 0) //Root directory
                {
                    DriveInfo drive = new DriveInfo(e.Node.Text);
                    dir = drive.RootDirectory;

                    subDir = dir.GetDirectories();
                }

                else
                {
                    //Get the Path of the node and AddSeparatorAtEnd Property set to true
                    string path = e.Node.GetPath("\\");

                    dir = new DirectoryInfo(path);
                    subDir = dir.GetDirectories();
                }

                if (subDir != null)
                {
                    foreach (DirectoryInfo dirinfo in subDir)
                    {
                        Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvSubItem subitem1 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvSubItem();
                        Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvSubItem subitem2 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvSubItem();

                        subitem1.Text = dirinfo.FullName;
                        subitem1.HelpText = subitem1.Text;

                        subitem2.Text = dirinfo.LastWriteTime.ToString();
                        subitem2.HelpText = subitem2.Text;

                        Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdv node = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdv(dirinfo.Name);

                        node.SubItems.AddRange(new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvSubItem[]{
                            subitem1,subitem2});
                        e.Node.Nodes.Add(node);
                    }
                }
            }
            catch { }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectionModeGroupBox.ForeColor = Color.Black;
            if (this.visualStyleComboBox.SelectedIndex == 0)
            {
                this.Style.TitleBar.BackColor = Color.FromArgb(242, 242, 242);
                this.panel2.BorderColor= Color.FromArgb(210, 210, 210);
                this.Style.TitleBar.ForeColor = Color.Black;
                this.Style.TitleBar.MaximizeButtonForeColor = Color.Black;
                this.Style.TitleBar.CloseButtonForeColor = Color.Black;
                this.Style.TitleBar.MinimizeButtonForeColor = Color.Black;
                this.visualStylelabel.ForeColor = Color.Black;
                this.multiSelectAllCheckBox.ThemeName = this.multiSelectSameCheckBoxAdv.ThemeName = this.singleSelectioncheckBox.ThemeName = "Office2019Colorful";
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.multiColumnTreeView1.ThemeName = "Office2019Colorful";
                this.visualStyleComboBox.ThemeName = "Office2019Colorful";
            }
            else if (this.visualStyleComboBox.SelectedIndex == 1)
            {
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.Style.TitleBar.BackColor = this.panel2.BorderColor = Color.FromArgb(210, 210, 210);
                this.Style.TitleBar.ForeColor = Color.Black;
                this.Style.TitleBar.MaximizeButtonForeColor = Color.Black;
                this.Style.TitleBar.CloseButtonForeColor = Color.Black;
                this.Style.TitleBar.MinimizeButtonForeColor = Color.Black;
                this.visualStylelabel.ForeColor = Color.Black;
                this.visualStyleComboBox.Style = VisualStyle.Office2016Colorful;
                this.multiSelectAllCheckBox.Style = this.multiSelectSameCheckBoxAdv.Style =
                    this.singleSelectioncheckBox.Style = RadioButtonAdvStyle.Office2016Colorful;
                this.multiColumnTreeView1.Style = MultiColumnVisualStyle.Office2016Colorful;
            }
            else if (this.visualStyleComboBox.SelectedIndex == 3)
            {
                this.selectionModeGroupBox.ForeColor = Color.White;
                this.BackColor = ColorTranslator.FromHtml("#262626");
                this.Style.TitleBar.BackColor = this.panel2.BorderColor = ColorTranslator.FromHtml("#363636");
                this.Style.TitleBar.ForeColor = Color.White;
                this.Style.TitleBar.MaximizeButtonForeColor = Color.White;
                this.Style.TitleBar.CloseButtonForeColor = Color.White;
                this.Style.TitleBar.MinimizeButtonForeColor = Color.White;
                this.visualStylelabel.ForeColor = Color.White;
                this.visualStyleComboBox.Style = VisualStyle.Office2016Black;
                this.multiColumnTreeView1.Style = MultiColumnVisualStyle.Office2016Black;
                this.multiSelectAllCheckBox.Style = this.multiSelectSameCheckBoxAdv.Style =
                    this.singleSelectioncheckBox.Style = RadioButtonAdvStyle.Office2016Black;
                this.visualStylelabel.ForeColor = Color.White;
            }
            else if (this.visualStyleComboBox.SelectedIndex == 4)
            {
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.Style.TitleBar.BackColor = this.panel2.BorderColor = Color.FromArgb(210, 210, 210);
                this.Style.TitleBar.ForeColor = Color.Black;
                this.Style.TitleBar.MaximizeButtonForeColor = Color.Black;
                this.Style.TitleBar.CloseButtonForeColor = Color.Black;
                this.Style.TitleBar.MinimizeButtonForeColor = Color.Black;
                this.visualStylelabel.ForeColor = Color.Black;
                this.visualStyleComboBox.Style = VisualStyle.Office2016White;
                this.multiColumnTreeView1.Style = MultiColumnVisualStyle.Office2016White;
                this.multiSelectAllCheckBox.Style = this.multiSelectSameCheckBoxAdv.Style =
                    this.singleSelectioncheckBox.Style = RadioButtonAdvStyle.Office2016White;
            }
            else if (this.visualStyleComboBox.SelectedIndex == 2)
            {
                this.BackColor = ColorTranslator.FromHtml("#666666");
                this.Style.TitleBar.BackColor = this.panel2.BorderColor = ColorTranslator.FromHtml("#505050");
                this.Style.TitleBar.ForeColor = Color.White;
                this.Style.TitleBar.MaximizeButtonForeColor = Color.White;
                this.Style.TitleBar.CloseButtonForeColor = Color.White;
                this.Style.TitleBar.MinimizeButtonForeColor = Color.White;
                this.visualStylelabel.ForeColor = Color.White;
                this.visualStyleComboBox.Style = VisualStyle.Office2016DarkGray;
                this.multiColumnTreeView1.Style = MultiColumnVisualStyle.Office2016DarkGray;
                this.multiSelectAllCheckBox.Style = this.multiSelectSameCheckBoxAdv.Style =
                     this.singleSelectioncheckBox.Style = RadioButtonAdvStyle.Office2016DarkGray;
                this.selectionModeGroupBox.ForeColor = Color.White;
                this.visualStylelabel.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.multiColumnTreeView1.Style = MultiColumnVisualStyle.Metro;
                this.multiSelectAllCheckBox.Style = this.multiSelectSameCheckBoxAdv.Style =
                    this.singleSelectioncheckBox.Style = RadioButtonAdvStyle.Metro;
                this.Style.TitleBar.BackColor = this.panel2.BorderColor = Color.White;
                this.Style.TitleBar.ForeColor = Color.Black;
                this.Style.TitleBar.MaximizeButtonForeColor = Color.Black;
                this.Style.TitleBar.CloseButtonForeColor = Color.Black;
                this.Style.TitleBar.MinimizeButtonForeColor = Color.Black;
                this.visualStylelabel.ForeColor = Color.Black;
                this.multiColumnTreeView1.BorderColor = Color.FromArgb(210, 210, 201);
            }
        }

        private void singleSelectioncheckBox_CheckChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButtonAdv).Name.Equals("singleSelectioncheckBox"))
            {
                this.multiColumnTreeView1.SelectionMode = Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeSelectionMode.Single;
            }
            else if ((sender as RadioButtonAdv).Name.Equals("multiSelectSameCheckBoxAdv"))
            {
                this.multiColumnTreeView1.SelectionMode = Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeSelectionMode.MultiSelectSameLevel;
            }
            else if ((sender as RadioButtonAdv).Name.Equals("multiSelectAllCheckBox"))
            {
                this.multiColumnTreeView1.SelectionMode = Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeSelectionMode.MultiSelectAll;
            }
        }

    }
}
