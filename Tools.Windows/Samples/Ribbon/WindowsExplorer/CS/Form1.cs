#region Copyright Syncfusion Inc. 2001-2016.
// Copyright Syncfusion Inc. 2001-2016. All rights reserved.
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
using System.Runtime.InteropServices;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using System.IO;
using Syncfusion.Windows.Forms.Tools.Navigation;

namespace WindowsExplorerDemo_2013
{
    public partial class Form1 : Syncfusion.Windows.Forms.Tools.RibbonForm
    {
        TouchStyleColorTable touch = new TouchStyleColorTable();
        bool isPopupVisible = false;

        public Form1()
        {
            InitializeComponent();
            this.ribbonControlAdv1.RibbonStyle = RibbonStyle.Office2013;
            touch.HeaderColor = Color.White;//ColorTranslator.FromHtml("#f5f6f7");
            touch.ActiveToolStripTabItemBackColor = ColorTranslator.FromHtml("#f5f6f7");
            touch.RibbonPanelBackColor = ColorTranslator.FromHtml("#f5f6f7");
            touch.BackStageNavigationButtonBackColor = ColorTranslator.FromHtml("#1979ca");
            touch.ToolStripBorderColor = ColorTranslator.FromHtml("#dadbdc");
            touch.ToolstripSelectedTabItemBorder = ColorTranslator.FromHtml("#dadbdc");
            touch.ToolstripTabItemBorder = Color.Transparent;
            touch.ToolstripTabItemForeColor = ColorTranslator.FromHtml("#3c3c3c");
            touch.HoverTabBackColor = ColorTranslator.FromHtml("#f5f6f7");
            touch.BottomToolStripBackColor = ColorTranslator.FromHtml("#f5f6f7");
            touch.ToolstripActiveTabItemForeColor = Color.Black;
            touch.HoverTabForeColor = Color.Black;
            touch.MinimizeButtonForeColor = Color.Black;
            touch.MaximizeButtonForeColor = Color.Black;
            //touch.CloseButtonHoverForeColor = ColorTranslator.FromHtml("#e04343");
            //touch.CloseButtonBackground = ColorTranslator.FromHtml("#c75050");
            this.ribbonControlAdv1.ApplyTouchStyleColorTable(touch);
            this.treeViewAdv1.FullRowSelect = true;
            this.treeViewAdv1.HideSelection = false;
            this.treeViewAdv1.SelectedNode = null;
            this.popupControlContainer1.Visible = false;
            this.Load += new EventHandler(Form1_Load);
            this.ribbonControlAdv1.MenuButtonClick += new EventHandler(ribbonControlAdv1_MenuButtonClick);
            
            this.treeViewAdv1.SelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#d1e8ff"));
            this.treeViewAdv1.SelectedNodeForeColor = Color.Black;
            this.treeViewAdv1.MouseMove += new MouseEventHandler(treeViewAdv1_MouseMove);
            this.treeViewAdv1.MouseLeave += new EventHandler(treeViewAdv1_MouseLeave);
            this.popupControlContainer1.VisibleChanged += new EventHandler(popupControlContainer1_VisibleChanged);
            this.popupControlContainer1.BeforeCloseUp += new CancelEventHandler(popupControlContainer1_BeforeCloseUp);
            this.buttonEdit1.TextBox.Text = "";
            this.buttonEditChildButton1.Image = this.imageList3.Images[0];
            this.buttonEditChildButton1.FlatStyle = FlatStyle.Flat;
            this.buttonEdit1.FlatStyle = FlatStyle.Flat;
            this.buttonEditChildButton1.Text = "";
            this.listView2.BorderStyle = BorderStyle.None;
            this.treeViewAdv1.BorderStyle = BorderStyle.None;

            this.panel2.Width = 2;
            this.panel2.BorderStyle = BorderStyle.None;
            this.panel2.BackColor = ColorTranslator.FromHtml("#f7f7f7");
            listView2.Groups[0].HeaderAlignment = HorizontalAlignment.Right;
            int i = 6;
            foreach(Control ctrl in this.popupControlContainer1.Controls)
            {
                if(ctrl is ButtonAdv)
                {
                    ctrl.Height = 45;
                    ctrl.Text = "     " + ctrl.Text;
                    (ctrl as ButtonAdv).ImageAlign = ContentAlignment.MiddleLeft;
                    (ctrl as ButtonAdv).Image = this.imageList3.Images[i];
                    (ctrl as ButtonAdv).BeforeTouchSize = new System.Drawing.Size(297, 38);
                    (ctrl as ButtonAdv).Dock = System.Windows.Forms.DockStyle.Top;
                    (ctrl as ButtonAdv).FlatAppearance.BorderSize = 0;
                    (ctrl as ButtonAdv).FlatStyle = System.Windows.Forms.FlatStyle.Flat;                   
                    (ctrl as ButtonAdv).ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    (ctrl as ButtonAdv).IsBackStageButton = false;
                    (ctrl as ButtonAdv).Location = new System.Drawing.Point(0, 0);
                    (ctrl as ButtonAdv).Name = "buttonAdv1";
                    (ctrl as ButtonAdv).Size = new System.Drawing.Size(297, 38);          
                    
                    (ctrl as ButtonAdv).TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    (ctrl as ButtonAdv).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                    i--;
                }

            }
            this.buttonAdv6.Click += new EventHandler(buttonAdv6_Click);
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x001C:
                    this.popupControlContainer1.HidePopup();
                    break;
            }
            base.WndProc(ref m);
        }
      
        void buttonAdv6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Form1_Resize(object sender, EventArgs e)
        {
            this.navigationView2.Width = this.buttonEdit1.Left;
        }

        void popupControlContainer1_BeforeCloseUp(object sender, CancelEventArgs e)
        {
            this.superAccelerator1.Active = true;
        }

        void popupControlContainer1_VisibleChanged(object sender, EventArgs e)
        {
            if (this.popupControlContainer1.Visible)
                this.superAccelerator1.Active = false;
            else
                this.superAccelerator1.Active = true;
        }

        void treeViewAdv1_MouseLeave(object sender, EventArgs e)
        {
            if ((sender as TreeViewAdv) == this.treeViewAdv1)
            {
                //this.treeViewAdv1.Nodes[0].Background = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(0, 255, 255, 255));
                for (int i = 0; i < this.treeViewAdv1.Nodes.Count; i++)
                {
                    foreach (TreeNodeAdv item in this.treeViewAdv1.Nodes[i].Nodes)
                    {
                        item.Background = new Syncfusion.Drawing.BrushInfo(Color.White);

                        foreach (TreeNodeAdv node in item.Nodes)
                        {
                            node.Background = new Syncfusion.Drawing.BrushInfo(Color.White);
                        }
                    }
                }
              
            }
        }

        void treeViewAdv1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((sender as TreeViewAdv) == this.treeViewAdv1)
            {               
                for (int i = 0; i < this.treeViewAdv1.Nodes.Count; i++)
                {
                    this.treeViewAdv1.Nodes[i].Background = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(0, 255, 255, 255));
                    foreach (TreeNodeAdv item in this.treeViewAdv1.Nodes[i].Nodes)
                    {
                        item.Background = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(0, 255, 255, 255));
                    }
                }
                if (this.treeViewAdv1.GetNodeAtPoint(new Point(e.X, e.Y)) != null)
                {
                    TreeNodeAdv node = this.treeViewAdv1.GetNodeAtPoint(new Point(e.X, e.Y));
                    node.Background = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#e5f3fb"));
                }
            }
        }


        void ribbonControlAdv1_MenuButtonClick(object sender, EventArgs e)
        {
            if (!isPopupVisible)
            {
                if (sender is ToolStripDropDownButton)
                {
                    isPopupVisible = true;
                    this.popupControlContainer1.ShowPopup(PointToScreen(new Point((int)((sender as ToolStripDropDownButton).Bounds.X), (int)((sender as ToolStripDropDownButton).Bounds.Y + (sender as ToolStripDropDownButton).Bounds.Height))));
                }
            }
            else
            {
                isPopupVisible = false;
                this.popupControlContainer1.HidePopup();
            }
        }
        string substringDirectory;
        void Form1_Load(object sender, EventArgs e)
        {
            this.ribbonControlAdv1.MenuButtonText = "FILE";
            this.ribbonControlAdv1.BackStageNavigationButtonStyle = BackStageNavigationButtonStyles.Office2013;
            this.ribbonControlAdv1.QuickPanelAlignment = QuickPanelAlignment.Top;
            touch.CloseButtonForeColor = Color.Black;
            touch.RestoreButtonForeColor = Color.Black;
            touch.BottomToolStripBackColor = ColorTranslator.FromHtml("#ffffff");
            touch.QATDownArrowColor = Color.Black;
            touch.ToolStripSpliterColor = ColorTranslator.FromHtml("#e2e3e4");
            this.superAccelerator1.BackColor = ColorTranslator.FromHtml("#eaf0f8");
            this.popupControlContainer1.BorderStyle = BorderStyle.FixedSingle;
            this.popupControlContainer1.BackColor = ColorTranslator.FromHtml("#fbfcfd");
            this.treeViewAdv1.BorderStyle = BorderStyle.None;
            this.superAccelerator1.SetMenuButtonAccelerator(this.ribbonControlAdv1, "F");
            this.navigationView2.Focus();
            this.treeViewAdv1.AfterSelect += new EventHandler(treeViewAdv1_AfterSelect);
            
            
        }

        void treeViewAdv1_AfterSelect(object sender, EventArgs e)
        {
            try
            {
                listView2.Items.Clear();
                
                TreeNodeAdv selectednode = this.treeViewAdv1.SelectedNode;
                selectednode.Expand();
                this.treeViewAdv1.Text = selectednode.FullPath;
                navigationView2.Refresh();
                Bar bar = new Bar(selectednode.Text);
                //bar.ImageIndex = selectednode.image;
                this.navigationView2.Bars.Add(bar);
                this.navigationView2.SelectedBar = bar;
                string[] splitedText = this.treeViewAdv1.Text.Split('\\');
                int count = 0;
                if (selectednode.Nodes.Count == 0)
                    count = 1;
                else
                    count = selectednode.Nodes.Count;
                if (selectednode.Nodes.Count > 0)
                {                  
                    ListViewGroup Group = new ListViewGroup("selectednode.Text", HorizontalAlignment.Left);
                    Group.Header = selectednode.Text + " (" + count + ")";
                    listView2.Groups.Add(Group);
                    foreach (TreeNodeAdv n in selectednode.Nodes)
                    {

                        ListViewItem lst = new ListViewItem(n.Text, 5);                        
                        listView2.Items.Add(lst);
                        lst.Group = Group;
                        
                        
                    }
                }
                else
                {
                    ListViewGroup Group = new ListViewGroup("selectednode.Text", HorizontalAlignment.Left);
                    Group.Header = selectednode.Text + " (" + count + ")";
                    listView2.Groups.Add(Group);
                    if (selectednode.Text == "New Volume(D:)")
                    {
                        DirectoryInfo di = new DirectoryInfo("D:\\");
                        try
                        {
                            foreach (FileInfo fi in di.GetFiles())
                            {
                                ListViewItem lst = new ListViewItem(fi.Name, 5);
                                listView2.Items.Add(lst);
                                lst.Group = Group;
                            }
                            try
                            {
                                foreach (DirectoryInfo listd in di.GetDirectories())
                                {
                                    ListViewItem lst = new ListViewItem(listd.Name, 10);
                                    listView2.Items.Add(lst);
                                    lst.Group = Group;
                                }
                            }
                            catch (Exception)
                            {
                            }
                        }
                        catch (Exception)
                        {
                        }
                    }                   
                    else
                    {
                        ListViewItem lst = new ListViewItem(selectednode.Text, 1);
                        listView2.Items.Add(lst);
                        lst.Group = Group;
                        //listView2.Items.Add(selectednode.FullPath, selectednode.Text, 1);
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        public void PopulateTreeView(string directoryValue, TreeNodeAdv parentNode)
        {
            try
            {
                if (directoryValue.Contains("C:\\Users\\Default\\AppData"))
                {
                    string[] directoryArray =
     Directory.GetDirectories(directoryValue);
                    if (directoryArray.Length != 0)
                    {
                        foreach (string directory in directoryArray)
                        {
                            substringDirectory = directory.Substring(
                            directory.LastIndexOf('\\') + 1,
                            directory.Length - directory.LastIndexOf('\\') - 1);

                            TreeNodeAdv myNode = new TreeNodeAdv(substringDirectory);
                            if (myNode.Text != "TreeNodeAdv")
                            {
                                parentNode.Nodes.Add(myNode);
                                PopulateTreeView(directory, myNode);
                            }
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                // parentNode.Nodes.Add("Access denied");
            } // end catch
        }

        private void navigationView2_BarSelectionChanging(object sender, Syncfusion.Windows.Forms.Tools.Navigation.BarSelectionChangingEventArgs e)
        {
            this.listView2.Items.Clear();
            bool needToAdd = true;
            Syncfusion.Windows.Forms.Tools.Navigation.Bar parent = e.Bar;
            if (parent == null) return;
            if (parent.Bars.Count > 0)
            {
                needToAdd = false;
            }
            DirectoryInfo dirInfo = null;
            if (parent.Tag is DriveInfo)
            {
                DriveInfo driveInfo = (DriveInfo)parent.Tag;
                dirInfo = driveInfo.RootDirectory;

            }
            else if (parent.Tag is DirectoryInfo)
            {
                dirInfo = (DirectoryInfo)parent.Tag;
            }
            if (dirInfo != null)
            {
                try
                {
                    DirectoryInfo[] subDirectories = dirInfo.GetDirectories();
                    FileInfo[] files = dirInfo.GetFiles();
                    foreach (DirectoryInfo directoryInfo in subDirectories)
                    {
                        Syncfusion.Windows.Forms.Tools.Navigation.Bar node = new Syncfusion.Windows.Forms.Tools.Navigation.Bar();
                        node.Tag = directoryInfo;
                        node.Text = directoryInfo.FullName;
                        node.ImageIndex = 8;
                        if (needToAdd)
                            parent.Bars.Add(node);
                        this.listView2.Items.Add(node.Text, 5);
                    }
                    foreach (FileInfo file in files)
                    {
                        this.listView2.Items.Add(file.FullName, 5);
                    }
                }
                catch (Exception ex)
                {
                    MessageBoxAdv.Show(this, ex.Message, "Info");
                }
            }
            else if (parent.Text == "MyComputer")
            {
                this.listView1.Items.Add("Local Disk(C:)", 8);
            }
        }
    }    
}
