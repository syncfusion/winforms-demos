#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
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
    public partial class MainForm : SfForm
    {
        Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv treeColumnAdv1;
        Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv treeColumnAdv2;
        Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv treeColumnAdv3;

        public MainForm()
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

            this.Load += new EventHandler(MultiColumnTreeViewDemo_Load);
            this.multiColumnTreeView1.BeforeExpand += new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeViewAdvCancelableNodeEventHandler(multiColumnTreeView1_BeforeExpand);
            this.MinimumSize = this.Size;
            this.treeColumnAdv1.BaseStyle = (this.multiColumnTreeView1.BaseStylePairs[2] as Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.StyleNamePair).Name;
            this.treeColumnAdv1.BorderStyle = BorderStyle.FixedSingle;
            this.treeColumnAdv2.BorderStyle = BorderStyle.FixedSingle;
            this.treeColumnAdv3.BorderStyle = BorderStyle.FixedSingle;
            this.multiColumnTreeView1.ThemeName = "Office2019Colorful";
            this.multiColumnTreeView1.LabelEdit = false;
            comboBoxAdv1.Items.AddRange(new string[] { "None", "AllCellsExceptHeader", "AllCells", "ColumnHeader", "AllCellsWithLastColumnFill", "Fill", "LastColumnFill" });
            comboBoxAdv1.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            comboBoxAdv1.ThemeName = "Office2019Colorful";
            this.splitContainer1.BorderStyle = BorderStyle.None;
            this.comboBoxAdv1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.SelectedIndex = 5;
            this.multiColumnTreeView1.FullRowSelect = true;
        }

        #region "Image Loading Methods"
        //Get and Load the images
#if NET9_0_OR_GREATER
        private Image GetImage(string path)
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            if (asm != null && !string.IsNullOrEmpty(path))
                return Image.FromStream(asm.GetManifestResourceStream(path));
            return null;
        }

        private void LoadImages(ImageList imageList, string folder, int count)
        {
            for (int i = 1; i <= count; i++)
            {
                string imagePath = ($"MultiColumnTreeViewDemo.Images.{folder}.Image_{i}.png");
                imageList.Images.Add(GetImage(imagePath));
            }
        }
#endif
        #endregion

        void MultiColumnTreeViewDemo_Load(object sender, EventArgs e)
        {
            this.multiColumnTreeView1.Nodes[0].Expanded = true;
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            //this.label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.multiColumnTreeView1.Focus();
            this.multiColumnTreeView1.SelectedNode = this.multiColumnTreeView1.Nodes[0];
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxAdv1.SelectedIndex == 0)
            {
                this.multiColumnTreeView1.AutoSizeMode = Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.AutoSizeMode.None;
            }
            else if (this.comboBoxAdv1.SelectedIndex == 1)
            {
                this.multiColumnTreeView1.AutoSizeMode = Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.AutoSizeMode.AllCellsExceptHeader;
            }
            else if (this.comboBoxAdv1.SelectedIndex == 2)
            {
                this.multiColumnTreeView1.AutoSizeMode = Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.AutoSizeMode.AllCells;
            }
            else if (this.comboBoxAdv1.SelectedIndex == 3)
            {
                this.multiColumnTreeView1.AutoSizeMode = Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.AutoSizeMode.ColumnHeader;
            }
            else if (this.comboBoxAdv1.SelectedIndex == 4)
            {
                this.multiColumnTreeView1.AutoSizeMode = Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.AutoSizeMode.AllCellsWithLastColumnFill;
            }
            else if (this.comboBoxAdv1.SelectedIndex == 5)
            {
                this.multiColumnTreeView1.AutoSizeMode = Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.AutoSizeMode.Fill;
            }
            else if (this.comboBoxAdv1.SelectedIndex == 6)
            {
                this.multiColumnTreeView1.AutoSizeMode = Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.AutoSizeMode.LastColumnFill;
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
            {
                this.splitContainer1.SplitterDistance = 55;
            }
        }
    }
}