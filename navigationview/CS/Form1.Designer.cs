#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Tools;
using System.Drawing;
using Syncfusion.Windows.Forms;
namespace NavigationViewDemo_2005 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Tools.Navigation.Bar bar1 = new Syncfusion.Windows.Forms.Tools.Navigation.Bar();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo1 = new Syncfusion.Windows.Forms.BannerTextInfo();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Desktop", 9, 9);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Downloads", 12, 12);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Recent places", 19, 19);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Favorites", 13, 13, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("", 23, 23);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Documents", 11, 11);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Pictures", 18, 18);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Public", 24, 24);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("OneDrive", 17, 17, new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Desktop", 10, 10);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Documents", 11, 11);
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Downloads", 12, 12);
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Music", 14, 14);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Pictures", 18, 18);
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Videos", 21, 21);
            System.IO.DriveInfo di = new System.IO.DriveInfo(@"C:\");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode(di.VolumeLabel.ToString(), 22, 22);
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("New Volume(G:)", 16, 16);
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("ThisPC", 20, 20, new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Network", 15, 15);
            this.navigationView1 = new Syncfusion.Windows.Forms.Tools.NavigationView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.popupControlContainer2 = new Syncfusion.Windows.Forms.PopupControlContainer();
            this.panel9 = new System.Windows.Forms.Panel();
            this.toolStrip5 = new System.Windows.Forms.ToolStrip();
            this.toolStripPanelItem2 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripPanelItem3 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripPanelItem4 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripPanelItem5 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripPanelItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.popupControlContainer1 = new Syncfusion.Windows.Forms.PopupControlContainer();
            this.panel7 = new System.Windows.Forms.Panel();
            this.gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.HistorycheckBox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.RTLChkBox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.BarImgChkBox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.HisbtnChkBox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.Popup = new Syncfusion.Windows.Forms.PopupControlContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.BannerText = new Syncfusion.Windows.Forms.BannerTextProvider(this.components);
            this.customButton1 = new Syncfusion.Windows.Forms.Tools.Navigation.CustomButton();
            this.explorerTreeView1 = new NavigationViewDemo_2005.ExplorerTreeView();
            ((System.ComponentModel.ISupportInitialize)(this.navigationView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            this.popupControlContainer2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.toolStrip5.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.toolStrip4.SuspendLayout();
            this.popupControlContainer1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).BeginInit();
            this.gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HistorycheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTLChkBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarImgChkBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HisbtnChkBox)).BeginInit();
            this.Popup.SuspendLayout();
            this.panel4.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationView1
            // 
            this.navigationView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            bar1.ImageIndex = 2;
            bar1.Text = "My Computer";
            this.navigationView1.Bars.AddRange(new Syncfusion.Windows.Forms.Tools.Navigation.Bar[] {
            bar1});
            this.navigationView1.BeforeTouchSize = new System.Drawing.Size(818, 21);
            this.navigationView1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationView1.ImageList = this.imageList1;
            this.navigationView1.Location = new System.Drawing.Point(3, 26);
            this.navigationView1.Name = "navigationView1";
            this.navigationView1.SelectedBar = bar1;
            this.navigationView1.ShowHistoryButtons = true;
            this.navigationView1.ShowRootBarText = true;
            this.navigationView1.Size = new System.Drawing.Size(818, 21);
            this.navigationView1.TabIndex = 0;
            this.navigationView1.Text = "navigationView1";
            this.navigationView1.VisualStyle = Syncfusion.Windows.Forms.Tools.Navigation.VisualStyles.Metro;
            this.navigationView1.BarSelectionChanging += new System.EventHandler<Syncfusion.Windows.Forms.Tools.Navigation.BarSelectionChangingEventArgs>(this.navigationView1_BarSelectionChanging);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "floppydrive2.ico");
            this.imageList1.Images.SetKeyName(1, "cddrive2.ico");
            this.imageList1.Images.SetKeyName(2, "this-pc.png");
            this.imageList1.Images.SetKeyName(3, "SEARCH.gif");
            this.imageList1.Images.SetKeyName(4, "open_icon.png");
            this.imageList1.Images.SetKeyName(5, "file.ico");
            this.imageList1.Images.SetKeyName(6, "foldericonn.ico");
            this.imageList1.Images.SetKeyName(7, "New.ico");
            this.imageList1.Images.SetKeyName(8, "foldericonn.ico");
            this.imageList1.Images.SetKeyName(9, "desktop.png");
            this.imageList1.Images.SetKeyName(10, "desktop1.png");
            this.imageList1.Images.SetKeyName(11, "documents.png");
            this.imageList1.Images.SetKeyName(12, "downloads.png");
            this.imageList1.Images.SetKeyName(13, "favourites.png");
            this.imageList1.Images.SetKeyName(14, "music.png");
            this.imageList1.Images.SetKeyName(15, "network.png");
            this.imageList1.Images.SetKeyName(16, "new-volume.png");
            this.imageList1.Images.SetKeyName(17, "onedrive.png");
            this.imageList1.Images.SetKeyName(18, "pictures.png");
            this.imageList1.Images.SetKeyName(19, "recent-places.png");
            this.imageList1.Images.SetKeyName(20, "this-pc.png");
            this.imageList1.Images.SetKeyName(21, "video.png");
            this.imageList1.Images.SetKeyName(22, "windows-os-C.png");
            this.imageList1.Images.SetKeyName(23, "Shape-Square2.png");
            this.imageList1.Images.SetKeyName(24, "foldericonn.ico");
            this.imageList1.Images.SetKeyName(25, "COMPUTER.ico");
            this.imageList1.Images.SetKeyName(26, "folder.ico");
            this.imageList1.Images.SetKeyName(27, "folder.bmp");
            this.imageList1.Images.SetKeyName(28, "file.ico");
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            this.gradientPanel2.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.gradientPanel2.BorderColor = System.Drawing.Color.Gray;
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            //this.gradientPanel2.Controls.Add(this.popupControlContainer2);
            //this.gradientPanel2.Controls.Add(this.popupControlContainer1);
            //this.gradientPanel2.Controls.Add(this.Popup);
            this.gradientPanel2.Controls.Add(this.listView1);
            this.gradientPanel2.Location = new System.Drawing.Point(244, 50);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Padding = new System.Windows.Forms.Padding(25);
            this.gradientPanel2.Size = new System.Drawing.Size(732, 376);
            this.gradientPanel2.TabIndex = 37;
            // 
            // popupControlContainer2
            // 
            this.popupControlContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.popupControlContainer2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.popupControlContainer2.Controls.Add(this.panel9);
            this.popupControlContainer2.Location = new System.Drawing.Point(3, 238);
            this.popupControlContainer2.Name = "popupControlContainer2";
            this.popupControlContainer2.Padding = new System.Windows.Forms.Padding(1);
            this.popupControlContainer2.ParentControl = this;
            this.popupControlContainer2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.popupControlContainer2.Size = new System.Drawing.Size(712, 98);
            this.popupControlContainer2.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.panel9.Controls.Add(this.toolStrip5);
            this.panel9.Controls.Add(this.toolStrip3);
            this.panel9.Controls.Add(this.toolStrip4);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(1, 1);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(1);
            this.panel9.Size = new System.Drawing.Size(710, 96);
            this.panel9.TabIndex = 1;
            // 
            // toolStrip5
            // 
            this.toolStrip5.AutoSize = false;
            this.toolStrip5.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip5.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPanelItem2});
            this.toolStrip5.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip5.Location = new System.Drawing.Point(263, 1);
            this.toolStrip5.Name = "toolStrip5";
            this.toolStrip5.Padding = new System.Windows.Forms.Padding(1);
            this.toolStrip5.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip5.Size = new System.Drawing.Size(333, 94);
            this.toolStrip5.TabIndex = 3;
            this.toolStrip5.Text = "toolStrip5";
            // 
            // toolStripPanelItem2
            // 
            this.toolStripPanelItem2.CausesValidation = false;
            this.toolStripPanelItem2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPanelItem3,
            this.toolStripPanelItem4,
            this.toolStripPanelItem5});
            this.toolStripPanelItem2.Name = "toolStripPanelItem2";
            this.toolStripPanelItem2.RowCount = 1;
            this.toolStripPanelItem2.Size = new System.Drawing.Size(327, 92);
            this.toolStripPanelItem2.Text = "toolStripPanelItem2";
            this.toolStripPanelItem2.Transparent = false;
            // 
            // toolStripPanelItem3
            // 
            this.toolStripPanelItem3.CausesValidation = false;
            this.toolStripPanelItem3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripButton9});
            this.toolStripPanelItem3.Name = "toolStripPanelItem3";
            this.toolStripPanelItem3.Size = new System.Drawing.Size(119, 73);
            this.toolStripPanelItem3.Text = "toolStripPanelItem3";
            this.toolStripPanelItem3.Transparent = true;
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = global::NavigationViewDemo_2005.Properties.Resources.Extralargeicon;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(115, 20);
            this.toolStripButton7.Text = "Extra Large Icons";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.Image = global::NavigationViewDemo_2005.Properties.Resources.smalicon;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(84, 20);
            this.toolStripButton8.Text = "Smal Icons";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.Image = global::NavigationViewDemo_2005.Properties.Resources.Tiles1;
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(51, 20);
            this.toolStripButton9.Text = "Tiles";
            // 
            // toolStripPanelItem4
            // 
            this.toolStripPanelItem4.CausesValidation = false;
            this.toolStripPanelItem4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStripButton12});
            this.toolStripPanelItem4.Name = "toolStripPanelItem4";
            this.toolStripPanelItem4.Size = new System.Drawing.Size(91, 73);
            this.toolStripPanelItem4.Text = "toolStripPanelItem4";
            this.toolStripPanelItem4.Transparent = true;
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.Image = global::NavigationViewDemo_2005.Properties.Resources.largeicon;
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(87, 20);
            this.toolStripButton10.Text = "Large Icons";
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.Image = global::NavigationViewDemo_2005.Properties.Resources.List;
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(45, 20);
            this.toolStripButton11.Text = "List";
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.Image = global::NavigationViewDemo_2005.Properties.Resources.Content1;
            this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Size = new System.Drawing.Size(70, 20);
            this.toolStripButton12.Text = "Content";
            // 
            // toolStripPanelItem5
            // 
            this.toolStripPanelItem5.CausesValidation = false;
            this.toolStripPanelItem5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton13,
            this.toolStripButton14});
            this.toolStripPanelItem5.Name = "toolStripPanelItem5";
            this.toolStripPanelItem5.Size = new System.Drawing.Size(107, 50);
            this.toolStripPanelItem5.Text = "toolStripPanelItem5";
            this.toolStripPanelItem5.Transparent = true;
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.Image = global::NavigationViewDemo_2005.Properties.Resources.MediumIcon;
            this.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.Size = new System.Drawing.Size(103, 20);
            this.toolStripButton13.Text = "Medium Icons";
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.Image = global::NavigationViewDemo_2005.Properties.Resources.Details;
            this.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(62, 20);
            this.toolStripButton14.Text = "Details";
            // 
            // toolStrip3
            // 
            this.toolStrip3.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPanelItem1,
            this.toolStripSeparator3});
            this.toolStrip3.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip3.Location = new System.Drawing.Point(119, 1);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Padding = new System.Windows.Forms.Padding(1);
            this.toolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip3.Size = new System.Drawing.Size(144, 94);
            this.toolStrip3.TabIndex = 2;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripPanelItem1
            // 
            this.toolStripPanelItem1.CausesValidation = false;
            this.toolStripPanelItem1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStripPanelItem1.Name = "toolStripPanelItem1";
            this.toolStripPanelItem1.Padding = new System.Windows.Forms.Padding(2, 9, 2, 2);
            this.toolStripPanelItem1.Size = new System.Drawing.Size(101, 92);
            this.toolStripPanelItem1.Text = "toolStripPanelItem1";
            this.toolStripPanelItem1.Transparent = false;
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = global::NavigationViewDemo_2005.Properties.Resources.PreviewPane;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(97, 20);
            this.toolStripButton5.Text = "Preview Pane";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = global::NavigationViewDemo_2005.Properties.Resources.DetailPane;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(91, 20);
            this.toolStripButton6.Text = "Details Pane";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 92);
            // 
            // toolStrip4
            // 
            this.toolStrip4.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip4.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip4.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip4.Location = new System.Drawing.Point(1, 1);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Padding = new System.Windows.Forms.Padding(1);
            this.toolStrip4.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip4.Size = new System.Drawing.Size(118, 94);
            this.toolStrip4.TabIndex = 1;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownButtonWidth = 18;
            this.toolStripSplitButton1.Image = global::NavigationViewDemo_2005.Properties.Resources.NavigationPane;
            this.toolStripSplitButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(114, 89);
            this.toolStripSplitButton1.Text = "NavigationPane";
            this.toolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.popupControlContainer1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.popupControlContainer1.Controls.Add(this.panel7);
            this.popupControlContainer1.Location = new System.Drawing.Point(13, 127);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.popupControlContainer1.Size = new System.Drawing.Size(601, 98);
            this.popupControlContainer1.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(220)))));
            this.panel7.Controls.Add(this.gradientPanel4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(1);
            this.panel7.Size = new System.Drawing.Size(601, 98);
            this.panel7.TabIndex = 1;
            // 
            // gradientPanel4
            // 
            this.gradientPanel4.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247))))));
            this.gradientPanel4.BorderColor = System.Drawing.Color.Gray;
            this.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel4.Controls.Add(this.HistorycheckBox);
            this.gradientPanel4.Controls.Add(this.RTLChkBox);
            this.gradientPanel4.Controls.Add(this.BarImgChkBox);
            this.gradientPanel4.Controls.Add(this.HisbtnChkBox);
            this.gradientPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel4.Location = new System.Drawing.Point(1, 1);
            this.gradientPanel4.Name = "gradientPanel4";
            this.gradientPanel4.Size = new System.Drawing.Size(599, 96);
            this.gradientPanel4.TabIndex = 32;
            this.gradientPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel4_Paint);
            // 
            // HistorycheckBox
            // 
            this.HistorycheckBox.BeforeTouchSize = new System.Drawing.Size(111, 26);
            this.HistorycheckBox.Checked = true;
            this.HistorycheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HistorycheckBox.DrawFocusRectangle = false;
            this.HistorycheckBox.Location = new System.Drawing.Point(7, 3);
            this.HistorycheckBox.MetroColor = System.Drawing.Color.Gray;
            this.HistorycheckBox.Name = "HistorycheckBox";
            this.HistorycheckBox.Size = new System.Drawing.Size(111, 26);
            this.HistorycheckBox.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.HistorycheckBox.TabIndex = 1;
            this.HistorycheckBox.Text = "History Enabled";
            this.HistorycheckBox.ThemesEnabled = false;
            this.HistorycheckBox.CheckedChanged += new System.EventHandler(this.HistorycheckBox_CheckedChanged);
            // 
            // RTLChkBox
            // 
            this.RTLChkBox.BeforeTouchSize = new System.Drawing.Size(106, 33);
            this.RTLChkBox.DrawFocusRectangle = false;
            this.RTLChkBox.Location = new System.Drawing.Point(212, 28);
            this.RTLChkBox.MetroColor = System.Drawing.Color.Gray;
            this.RTLChkBox.Name = "RTLChkBox";
            this.RTLChkBox.Size = new System.Drawing.Size(106, 33);
            this.RTLChkBox.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.RTLChkBox.TabIndex = 4;
            this.RTLChkBox.Text = "RightToLeft";
            this.RTLChkBox.ThemesEnabled = false;
            this.RTLChkBox.CheckedChanged += new System.EventHandler(this.RTLChkBox_CheckedChanged);
            // 
            // BarImgChkBox
            // 
            this.BarImgChkBox.BeforeTouchSize = new System.Drawing.Size(106, 18);
            this.BarImgChkBox.Checked = true;
            this.BarImgChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BarImgChkBox.DrawFocusRectangle = false;
            this.BarImgChkBox.Location = new System.Drawing.Point(212, 7);
            this.BarImgChkBox.MetroColor = System.Drawing.Color.Gray;
            this.BarImgChkBox.Name = "BarImgChkBox";
            this.BarImgChkBox.Size = new System.Drawing.Size(106, 18);
            this.BarImgChkBox.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.BarImgChkBox.TabIndex = 3;
            this.BarImgChkBox.Text = "Show BarImages";
            this.BarImgChkBox.ThemesEnabled = false;
            this.BarImgChkBox.CheckedChanged += new System.EventHandler(this.BarImgChkBox_CheckedChanged);
            // 
            // HisbtnChkBox
            // 
            this.HisbtnChkBox.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.HisbtnChkBox.Checked = true;
            this.HisbtnChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HisbtnChkBox.DrawFocusRectangle = false;
            this.HisbtnChkBox.Location = new System.Drawing.Point(7, 36);
            this.HisbtnChkBox.MetroColor = System.Drawing.Color.Gray;
            this.HisbtnChkBox.Name = "HisbtnChkBox";
            this.HisbtnChkBox.Size = new System.Drawing.Size(127, 17);
            this.HisbtnChkBox.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.HisbtnChkBox.TabIndex = 0;
            this.HisbtnChkBox.Text = "Show History Buttons";
            this.HisbtnChkBox.ThemesEnabled = false;
            this.HisbtnChkBox.CheckedChanged += new System.EventHandler(this.HisbtnChkBox_CheckedChanged);
            // 
            // Popup
            // 
            this.Popup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Popup.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Popup.Controls.Add(this.panel4);
            this.Popup.Location = new System.Drawing.Point(11, 3);
            this.Popup.Name = "Popup";
            this.Popup.Padding = new System.Windows.Forms.Padding(1);
            this.Popup.ParentControl = this;
            this.Popup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Popup.Size = new System.Drawing.Size(599, 98);
            this.Popup.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.panel4.Controls.Add(this.toolStrip2);
            this.panel4.Controls.Add(this.toolStrip1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(1, 1);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(1);
            this.panel4.Size = new System.Drawing.Size(597, 96);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripSeparator2});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip2.Location = new System.Drawing.Point(169, 1);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(1);
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(74, 94);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::NavigationViewDemo_2005.Properties.Resources.ControlPanel;
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(64, 89);
            this.toolStripButton4.Text = "Properties";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 92);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton1,
            this.toolStripSeparator1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(1, 1);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(1);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(168, 94);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::NavigationViewDemo_2005.Properties.Resources.properties;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(64, 89);
            this.toolStripButton2.Text = "Properties";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::NavigationViewDemo_2005.Properties.Resources.OpenHome;
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(40, 89);
            this.toolStripButton3.Text = "Open";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::NavigationViewDemo_2005.Properties.Resources.Rename;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(54, 89);
            this.toolStripButton1.Text = "Rename";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 92);
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(25, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(682, 326);
            this.listView1.TabIndex = 33;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Customization";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.White;
            this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            this.gradientPanel1.BorderColor = System.Drawing.Color.Gray;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel1.Controls.Add(this.explorerTreeView1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel1.Location = new System.Drawing.Point(0, 50);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.gradientPanel1.Size = new System.Drawing.Size(243, 376);
            this.gradientPanel1.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(917, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.navigationView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(976, 50);
            this.panel2.TabIndex = 37;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(226, -1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(119, 24);
            this.panel8.TabIndex = 3;
            this.panel8.Click += new System.EventHandler(this.label5_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = global::NavigationViewDemo_2005.Properties.Resources.Refresh;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(826, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 22);
            this.button2.TabIndex = 39;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::NavigationViewDemo_2005.Properties.Resources.Search;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(947, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 18);
            this.button1.TabIndex = 38;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            bannerTextInfo1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bannerTextInfo1.Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode;
            bannerTextInfo1.Text = "Search Th...";
            bannerTextInfo1.Visible = true;
            this.BannerText.SetBannerText(this.textBox1, bannerTextInfo1);
            this.textBox1.Location = new System.Drawing.Point(871, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 22);
            this.textBox1.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(65, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(95, 24);
            this.panel5.TabIndex = 1;
            this.panel5.Click += new System.EventHandler(this.label2_Click);
            this.panel5.MouseEnter += new System.EventHandler(this.panel5_MouseEnter);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Computer";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(159, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(67, 24);
            this.panel6.TabIndex = 2;
            this.panel6.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "View";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(121)))), ((int)(((byte)(202)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(-1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(67, 24);
            this.panel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "File";
            // 
            // customButton1
            // 
            this.customButton1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.customButton1.BackColor = System.Drawing.Color.DarkGray;
            this.customButton1.BeforeTouchSize = new System.Drawing.Size(26, 21);
            this.customButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.ImageIndex = 3;
            this.customButton1.ImageList = this.imageList1;
            this.customButton1.IsBackStageButton = false;
            this.customButton1.KeepFocusRectangle = false;
            this.customButton1.Location = new System.Drawing.Point(915, 0);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(26, 21);
            this.customButton1.TabIndex = 5;
            this.customButton1.UseVisualStyle = true;
            // 
            // explorerTreeView1
            // 
            this.explorerTreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.explorerTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explorerTreeView1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explorerTreeView1.FullRowSelect = true;
            this.explorerTreeView1.HideSelection = false;
            this.explorerTreeView1.HotTracking = true;
            this.explorerTreeView1.ImageIndex = 23;
            this.explorerTreeView1.ImageList = this.imageList1;
            this.explorerTreeView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.explorerTreeView1.Indent = 20;
            this.explorerTreeView1.ItemHeight = 20;
            this.explorerTreeView1.Location = new System.Drawing.Point(0, 25);
            this.explorerTreeView1.Name = "explorerTreeView1";
            treeNode1.ImageIndex = 9;
            treeNode1.Name = "Node1";
            treeNode1.SelectedImageIndex = 9;
            treeNode1.Text = "Desktop";
            treeNode2.ImageIndex = 12;
            treeNode2.Name = "Node2";
            treeNode2.SelectedImageIndex = 12;
            treeNode2.Text = "Downloads";
            treeNode3.ImageIndex = 19;
            treeNode3.Name = "Node3";
            treeNode3.SelectedImageIndex = 19;
            treeNode3.Text = "Recent places";
            treeNode4.ImageIndex = 13;
            treeNode4.Name = "Node0";
            treeNode4.SelectedImageIndex = 13;
            treeNode4.Text = "Favorites";
            treeNode5.ImageIndex = 23;
            treeNode5.Name = "Node0";
            treeNode5.SelectedImageIndex = 23;
            treeNode5.Text = "";
            treeNode6.ImageIndex = 11;
            treeNode6.Name = "Node9";
            treeNode6.SelectedImageIndex = 11;
            treeNode6.Text = "Documents";
            treeNode7.ImageIndex = 18;
            treeNode7.Name = "Node10";
            treeNode7.SelectedImageIndex = 18;
            treeNode7.Text = "Pictures";
            treeNode8.ImageIndex = 24;
            treeNode8.Name = "Node0";
            treeNode8.SelectedImageIndex = 24;
            treeNode8.Text = "Public";
            treeNode9.ImageIndex = 17;
            treeNode9.Name = "Node8";
            treeNode9.SelectedImageIndex = 17;
            treeNode9.Text = "OneDrive";
            treeNode10.Name = "Node1";
            treeNode10.Text = "";
            treeNode11.ImageIndex = 10;
            treeNode11.Name = "Node1";
            treeNode11.SelectedImageIndex = 10;
            treeNode11.Text = "Desktop";
            treeNode12.ImageIndex = 11;
            treeNode12.Name = "Node2";
            treeNode12.SelectedImageIndex = 11;
            treeNode12.Text = "Documents";
            treeNode13.ImageIndex = 12;
            treeNode13.Name = "Node3";
            treeNode13.SelectedImageIndex = 12;
            treeNode13.Text = "Downloads";
            treeNode14.ImageIndex = 14;
            treeNode14.Name = "Node4";
            treeNode14.SelectedImageIndex = 14;
            treeNode14.Text = "Music";
            treeNode15.ImageIndex = 18;
            treeNode15.Name = "Node7";
            treeNode15.SelectedImageIndex = 18;
            treeNode15.Text = "Pictures";
            treeNode16.ImageIndex = 21;
            treeNode16.Name = "Node8";
            treeNode16.SelectedImageIndex = 21;
                ////treeNode16.Text = "Videos";
            treeNode17.ImageIndex = 22;
            treeNode17.Name = "Node9";
            treeNode17.SelectedImageIndex = 22;
            treeNode17.Text = di.VolumeLabel.ToString();
            treeNode18.ImageIndex = 16;
            treeNode18.Name = "Node10";
            treeNode18.SelectedImageIndex = 16;
            treeNode18.Text = "New Volume(G:)";
            treeNode19.ImageIndex = 20;
            treeNode19.Name = "Node2";
            treeNode19.SelectedImageIndex = 20;
            treeNode19.Text = "ThisPC";
            treeNode20.Name = "Node11";
            treeNode20.Text = "";
            treeNode21.ImageIndex = 15;
            treeNode21.Name = "Node13";
            treeNode21.SelectedImageIndex = 15;
            treeNode21.Text = "Network";
            this.explorerTreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode9,
            treeNode10,
            treeNode19,
            treeNode20,
            treeNode21});
            this.explorerTreeView1.SelectedImageIndex = 0;
            this.explorerTreeView1.ShowLines = false;
            this.explorerTreeView1.Size = new System.Drawing.Size(243, 351);
            this.explorerTreeView1.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 426);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gradientPanel2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(579, 433);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Navigation View";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.popupControlContainer2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.toolStrip5.ResumeLayout(false);
            this.toolStrip5.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.popupControlContainer1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).EndInit();
            this.gradientPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HistorycheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTLChkBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarImgChkBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HisbtnChkBox)).EndInit();
            this.Popup.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.NavigationView navigationView1;
        private System.Windows.Forms.ImageList imageList1;
        private Syncfusion.Windows.Forms.Tools.Navigation.CustomButton customButton1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private System.Windows.Forms.ListView listView1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel4;
        private CheckBoxAdv HistorycheckBox;
        private CheckBoxAdv RTLChkBox;
        private CheckBoxAdv BarImgChkBox;
        private CheckBoxAdv HisbtnChkBox;
        private ExplorerTreeView explorerTreeView1;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private BannerTextProvider BannerText;
        private PopupControlContainer Popup;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel4;
        private PopupControlContainer popupControlContainer1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private PopupControlContainer popupControlContainer2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStrip toolStrip5;
        private ToolStripPanelItem toolStripPanelItem2;
        private ToolStripPanelItem toolStripPanelItem3;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private ToolStripPanelItem toolStripPanelItem4;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private ToolStripPanelItem toolStripPanelItem5;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private ToolStripPanelItem toolStripPanelItem1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

    }
}

