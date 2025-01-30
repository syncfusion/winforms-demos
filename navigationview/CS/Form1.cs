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
using System.IO;
using Syncfusion.Windows.Forms.Tools.Navigation;
using System.Runtime.InteropServices;

namespace NavigationViewDemo_2005 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            this.explorerTreeView1.MouseMove += new MouseEventHandler(explorerTreeView1_MouseMove);
            this.explorerTreeView1.BeforeSelect += new TreeViewCancelEventHandler(explorerTreeView1_BeforeSelect);
            this.explorerTreeView1.MouseDown += new MouseEventHandler(explorerTreeView1_MouseDown);
            this.explorerTreeView1.MouseUp += new MouseEventHandler(explorerTreeView1_MouseUp);
            this.explorerTreeView1.AfterSelect += new TreeViewEventHandler(explorerTreeView1_AfterSelect);
            this.listView1.MouseDoubleClick += new MouseEventHandler(listView1_MouseDoubleClick);
            this.panel5.Paint += new PaintEventHandler(panel5_Paint);
            this.panel5.MouseLeave += new EventHandler(panel5_MouseLeave);
            this.label2.MouseEnter += new EventHandler(label2_MouseEnter);
            this.panel6.Paint += new PaintEventHandler(panel6_Paint);
            this.label3.MouseEnter += new EventHandler(label3_MouseEnter);
            this.panel6.MouseLeave += new EventHandler(panel6_MouseLeave);
            this.panel6.MouseEnter += new EventHandler(panel6_MouseEnter);
            this.explorerTreeView1.HotTracking = false;
            this.explorerTreeView1.Nodes[4].Expand();
            this.explorerTreeView1.Nodes[2].Expand();
            this.navigationView1.VisualStyle = VisualStyles.Custom;
            this.SizeChanged += new EventHandler(Form1_SizeChanged);
            this.Popup.Width = this.ClientSize.Width;
            this.popupControlContainer1.Width = this.ClientSize.Width;
            this.popupControlContainer2.Width = this.ClientSize.Width;
        }

        void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.Popup.Width = this.popupControlContainer1.Width = this.popupControlContainer2.Width = this.ClientSize.Width;
        }

        void panel6_MouseEnter(object sender, EventArgs e)
        {
            color1 = ColorTranslator.FromHtml("#dadbdc");
            this.panel6.Invalidate();
        }

        void panel6_MouseLeave(object sender, EventArgs e)
        {
            color1 = Color.White;
            this.panel6.Invalidate();
        }

        void label3_MouseEnter(object sender, EventArgs e)
        {
            color1 = ColorTranslator.FromHtml("#dadbdc");
            this.panel6.Invalidate();
        }

        void panel6_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = panel6.ClientRectangle;
            rect.Inflate(-1, -1);
            using (Pen pen = new Pen(color1))
                e.Graphics.DrawRectangle(pen, rect);
        }

        void label2_MouseEnter(object sender, EventArgs e)
        {
            color = ColorTranslator.FromHtml("#dadbdc");
            this.panel5.Invalidate();
        }

        void panel5_MouseLeave(object sender, EventArgs e)
        {
            color = Color.White;
            this.panel5.Invalidate();
        }
        Color color = Color.White;
        Color color1 = Color.White;
        void panel5_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = panel5.ClientRectangle;
            rect.Inflate(-1, -1);
            using (Pen pen = new Pen(color))
                e.Graphics.DrawRectangle(pen, rect);
        }

        void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Selected == true)
                    {
                        string path = listView1.Items[i].Text;
                        listView1.Items.Clear();
                        LoadFilesAndDir(path);
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        private void LoadFilesAndDir(string address)
        {
            DirectoryInfo di = new DirectoryInfo(address);
            try
            {
                foreach (FileInfo fi in di.GetFiles())
                {
                    listView1.Items.Add(fi.Name);
                }
                try
                {
                    foreach (DirectoryInfo listd in di.GetDirectories())
                    {
                        listView1.Items.Add(listd.FullName, listd.Name, 20);
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

        bool isMouseClick;
        void explorerTreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            isMouseClick = true;
            try
            {
                listView1.Items.Clear();
                TreeNode selectednode = e.Node;
                selectednode.Expand();
                explorerTreeView1.Text = selectednode.FullPath;
                navigationView1.Refresh();
                Bar bar = new Bar(selectednode.Text);
                bar.ImageIndex = selectednode.ImageIndex;
                this.navigationView1.Bars.Add(bar);
                this.navigationView1.SelectedBar = bar;
                string[] splitedText = explorerTreeView1.Text.Split('\\');

                if (selectednode.Nodes.Count > 0)
                {
                    foreach (TreeNode n in selectednode.Nodes)
                    {
                        ListViewItem lst = new ListViewItem(n.Text, 24);
                        lst.Name = n.FullPath.Substring(13);
                        listView1.Items.Add(lst);
                    }
                }
                else
                {
                    if (selectednode.Text == "Videos")
                    {
                        DirectoryInfo di = new DirectoryInfo("Videos");
                        try
                        {
                            foreach (FileInfo fi in di.GetFiles())
                            {
                                listView1.Items.Add(fi.Name, 5);
                            }
                            try
                            {
                                foreach (DirectoryInfo listd in di.GetDirectories())
                                {
                                    listView1.Items.Add(listd.FullName, listd.Name, 24);
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
                    else if (selectednode.Text == "New Volume(G:)")
                    {
                        DirectoryInfo di = new DirectoryInfo("G:\\");
                        try
                        {
                            foreach (FileInfo fi in di.GetFiles())
                            {
                                listView1.Items.Add(fi.Name, 5);
                            }
                            try
                            {
                                foreach (DirectoryInfo listd in di.GetDirectories())
                                {
                                    listView1.Items.Add(listd.FullName, listd.Name, 24);
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
                    else if (selectednode.Text.Contains("(C:)") || selectednode.Text.Contains("(c:)"))
                    {
                        DirectoryInfo di = new DirectoryInfo("C:\\");
                        try
                        {
                            foreach (FileInfo fi in di.GetFiles())
                            {
                                listView1.Items.Add(fi.Name, 5);
                            }
                            try
                            {
                                foreach (DirectoryInfo listd in di.GetDirectories())
                                {
                                    listView1.Items.Add(listd.FullName, listd.Name, 24);
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
                        listView1.Items.Add(selectednode.FullPath, selectednode.Text, selectednode.ImageIndex);
                }
            }
            catch (Exception)
            {
            }
        }

        void explorerTreeView1_MouseUp(object sender, MouseEventArgs e)
        {
            this.explorerTreeView1.EndUpdate();
        }
        void explorerTreeView1_MouseDown(object sender, MouseEventArgs e)
        {
            this.explorerTreeView1.BeginUpdate();
        }

        void explorerTreeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node == this.explorerTreeView1.Nodes[1] || e.Node == this.explorerTreeView1.Nodes[3] || e.Node == this.explorerTreeView1.Nodes[5])
            {
                e.Cancel = true;
            }
            else
            {
            }
        }

        void explorerTreeView1_MouseMove(object sender, MouseEventArgs e)
        {
            this.explorerTreeView1.EndUpdate();
            if (this.explorerTreeView1.GetNodeAt(e.Location) == this.explorerTreeView1.Nodes[1] || this.explorerTreeView1.GetNodeAt(e.Location) == this.explorerTreeView1.Nodes[3] || this.explorerTreeView1.GetNodeAt(e.Location) == this.explorerTreeView1.Nodes[5])
            {
                this.explorerTreeView1.HotTracking = false;

            }
            else
            {
                this.explorerTreeView1.HotTracking = true;
            }
        }

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
        public void PopulateTreeView(string directoryValue, TreeNode parentNode)
        {
            string[] directoryArray =
             Directory.GetDirectories(directoryValue);

            try
            {
                if (directoryArray.Length != 0)
                {
                    foreach (string directory in directoryArray)
                    {
                        substringDirectory = directory.Substring(
                        directory.LastIndexOf('\\') + 1,
                        directory.Length - directory.LastIndexOf('\\') - 1);

                        TreeNode myNode = new TreeNode(substringDirectory, 24, 24);

                        parentNode.Nodes.Add(myNode);

                        PopulateTreeView(directory, myNode);
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                // parentNode.Nodes.Add("Access denied");
            } // end catch
        }
        string substringDirectory;
        private void Form1_Load(object sender, EventArgs e)
        {
            String path = @"..\..\";
            PopulateTreeView(path, this.explorerTreeView1.Nodes[2].Nodes[1]);
            path = @"C:\Users\Default";
            PopulateTreeView(path, this.explorerTreeView1.Nodes[2].Nodes[1]);
            this.listView1.Items.Clear();
            this.listView1.BringToFront();
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo driveInfo in drives)
            {
                if (driveInfo.DriveType != DriveType.Fixed) continue;
                Bar node = new Bar();
                node.Tag = driveInfo;
                node.Text = "Local Disk " + driveInfo.Name.Replace(@"\", "");
                node.ImageIndex = 8;
                this.listView1.Items.Add(node.Text, 8);
                navigationView1.Bars.Add(node);
            }
            //navigationView1.SelectedBar = navigationView1.Bars[1];
            this.navigationView1.HistoryManager = new Syncfusion.Windows.Forms.Tools.Navigation.HistoryManager();
            this.navigationView1.HistoryEnabled = true;
            this.navigationView1.Refresh();
        }

        private void HistorycheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.HisbtnChkBox.Enabled = HistorycheckBox.Checked;
            this.navigationView1.HistoryEnabled = HistorycheckBox.Checked;

            this.navigationView1.ShowHistoryButtons = HistorycheckBox.Checked;
            this.HisbtnChkBox.Checked = HistorycheckBox.Checked;
        }

        private void HisbtnChkBox_CheckedChanged(object sender, EventArgs e)
        {
            this.navigationView1.ShowHistoryButtons = HisbtnChkBox.Checked;
        }

        private void BarImgChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.BarImgChkBox.Checked)
                this.navigationView1.ImageList = this.imageList1;
            else
                this.navigationView1.ImageList = null;
        }
        Point textboxlocation;
        Point navigationlocation;
        Point buttonlocation;
        Point button2location;
        private void RTLChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RTLChkBox.Checked)
            {
                this.navigationView1.RightToLeft = RightToLeft.Yes;
                textboxlocation = this.textBox1.Location;
                this.textBox1.Location = new Point(2, this.textBox1.Top);
                this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                navigationlocation = this.navigationView1.Location;
                buttonlocation = this.button1.Location;
                button2location = this.button2.Location;
                this.button1.Location = new Point(this.textBox1.Left + 2, this.button1.Location.Y);
                this.button2.Location = new Point(this.textBox1.Right + 15, this.button2.Location.Y);
                this.navigationView1.Location = new Point(this.button2.Location.X + 30, this.textBox1.Top);
                this.button1.Anchor = this.textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                this.button1.RightToLeft = this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            }
            else
            {
                this.navigationView1.Location = navigationlocation;
                this.textBox1.Location = textboxlocation;
                this.button1.Location = buttonlocation;
                this.button2.Location = button2location;
                this.navigationView1.RightToLeft = RightToLeft.No;
                this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No; ;
                this.button1.Anchor = this.textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                this.button1.RightToLeft = this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            }
            //this.popupControlContainer1.HidePopup();
        }

        private void VisStyleCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (this.VisStyleCmbBox.SelectedIndex == 0) 
            //    this.navigationView1.VisualStyle = Syncfusion.Windows.Forms.Tools.Navigation.VisualStyles.Vista;
            //else if (this.VisStyleCmbBox.SelectedIndex == 2)
            //    this.navigationView1.VisualStyle = Syncfusion.Windows.Forms.Tools.Navigation.VisualStyles.Metro;
            //else
            //{
            //    this.navigationView1.VisualStyle = Syncfusion.Windows.Forms.Tools.Navigation.VisualStyles.Office2007;
            //    this.navigationView1.Office2007ColorTheme = Office2007Theme.Blue;
            //    this.customButton1.Office2007ColorScheme = Office2007Theme.Blue;
            //}
        }

        private void navigationView1_BarSelectionChanging(object sender, Syncfusion.Windows.Forms.Tools.Navigation.BarSelectionChangingEventArgs e)
        {
            this.listView1.Items.Clear();
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
                        this.listView1.Items.Add(node.Text, 8);
                    }
                    foreach (FileInfo file in files)
                    {
                        this.listView1.Items.Add(file.FullName, 5);
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

            if (!isMouseClick)
            {
                foreach (TreeNode nodes in explorerTreeView1.Nodes)
                {
                    if (nodes.Text == parent.Text)
                    {
                        explorerTreeView1.SelectedNode = nodes;
                    }
                    else
                    {
                        for (int i = 0; i < nodes.Nodes.Count; i++)
                        {
                            if (nodes.Nodes[i].Text == parent.Text)
                            {
                                explorerTreeView1.SelectedNode = nodes.Nodes[i];
                            }
                        }
                    }
                }
            }
            isMouseClick = false;
        }
        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            color = ColorTranslator.FromHtml("#dadbdc");
            this.panel5.Invalidate();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Popup.ShowPopup(new Point(this.Location.X + 8, this.Location.Y + 30 + this.panel3.Bottom));
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.popupControlContainer1.ShowPopup(new Point(this.Location.X + 8, this.Location.Y + 30 + this.panel3.Bottom));
        }

        private void gradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Text == "Custom")
                this.navigationView1.VisualStyle = Syncfusion.Windows.Forms.Tools.Navigation.VisualStyles.Custom;
            else if ((sender as RadioButton).Text == "Vista")
                this.navigationView1.VisualStyle = Syncfusion.Windows.Forms.Tools.Navigation.VisualStyles.Vista;
            else if ((sender as RadioButton).Text == "Office 2007")
            {
                this.navigationView1.VisualStyle = Syncfusion.Windows.Forms.Tools.Navigation.VisualStyles.Office2007;
                this.navigationView1.Office2007ColorTheme = Office2007Theme.Blue;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.popupControlContainer2.ShowPopup(new Point(this.Location.X + 8, this.Location.Y + 30 + this.panel3.Bottom));
        }
    }
    public class ExplorerTreeView : TreeView
    {
        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        private extern static int SetWindowTheme(IntPtr hWnd, string pszSubAppName,
                                                string pszSubIdList);
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
                return cp;
            }
        } 
        protected override void CreateHandle()
        {
            base.CreateHandle();

            SetWindowTheme(this.Handle, "explorer", null);
        }
    }
}