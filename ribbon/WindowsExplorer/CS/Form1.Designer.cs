#region Copyright Syncfusion Inc. 2001-2016.
// Copyright Syncfusion Inc. 2001-2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
using System.Windows.Forms;
namespace WindowsExplorerDemo_2013
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        //Get and Load the images
#if NET9_0_OR_GREATER
        private static Image GetImage(string path)
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            if (asm != null && !string.IsNullOrEmpty(path))
                return Image.FromStream(asm.GetManifestResourceStream(path));
            return null;
        }

        private void LoadImages(ImageList imageList, string folder, int count)
        {
            if (folder == "ImageList2")
            {
                imageList.ImageSize = new System.Drawing.Size(49, 49);
            }
            for (int i = 1; i <= count; i++)
            {
                string imagePath = ($"WindowsExplorerDemo_2013.Images.{folder}.Image_{i}.png");
                imageList.Images.Add(GetImage(imagePath));
            }
        }
#endif

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo1 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo2 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo3 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo4 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo5 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo6 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo7 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo8 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo9 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo10 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo11 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem toolStripGalleryItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem();
            Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem toolStripGalleryItem2 = new Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem();
            Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem toolStripGalleryItem3 = new Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem();
            Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem toolStripGalleryItem4 = new Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem();
            Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem toolStripGalleryItem5 = new Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem();
            Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem toolStripGalleryItem6 = new Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem();
            Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem toolStripGalleryItem7 = new Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem();
            Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem toolStripGalleryItem8 = new Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo12 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.Navigation.Bar bar1 = new Syncfusion.Windows.Forms.Tools.Navigation.Bar();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv2 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv3 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv4 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv5 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv6 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv7 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv8 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv9 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv10 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv11 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv12 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv13 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv14 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv15 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv16 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Folders (6)", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Devices and Drivers (3)", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Desktop",
            "asdas"}, 3);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Documents", 4);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Downloads", 5);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Music", 6);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Pictures", 7);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Videos", 8);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("DVD RW Drive(E:)", 0);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Local Disc (C:)", 1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Local Disk(D:)", 2);
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo1 = new Syncfusion.Windows.Forms.BannerTextInfo();
            this.ribbonControlAdv1 = new Syncfusion.Windows.Forms.Tools.RibbonControlAdv();
            this.toolStripTabItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripEx2 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.fsfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fsfToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButtonEx1 = new System.Windows.Forms.ToolStripSplitButton();
            this.mapNetworkDriveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discconectNetworkDriveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripEx3 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripPanelItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTabItem2 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripEx4 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.navigationPaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandToOpenFoldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllFoldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLibrariesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPanelItem2 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripEx5 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripGallery1 = new Syncfusion.Windows.Forms.Tools.ToolStripGallery();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.navigationView2 = new Syncfusion.Windows.Forms.Tools.NavigationView();
            this.treeViewAdv1 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.TreeViewImageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.popupControlContainer1 = new Syncfusion.Windows.Forms.PopupControlContainer();
            this.buttonAdv6 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv5 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv4 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.listView2 = new System.Windows.Forms.ListView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.superAccelerator1 = new Syncfusion.Windows.Forms.Tools.SuperAccelerator(this);
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonEdit1 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton1 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(this.components);
            this.superToolTip1 = new Syncfusion.Windows.Forms.Tools.SuperToolTip(this);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).BeginInit();
            this.ribbonControlAdv1.SuspendLayout();
            this.toolStripTabItem1.Panel.SuspendLayout();
            this.toolStripEx1.SuspendLayout();
            this.toolStripEx2.SuspendLayout();
            this.toolStripEx3.SuspendLayout();
            this.toolStripTabItem2.Panel.SuspendLayout();
            this.toolStripEx4.SuspendLayout();
            this.toolStripEx5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).BeginInit();
            this.panel1.SuspendLayout();
            this.popupControlContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1)).BeginInit();
            this.buttonEdit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControlAdv1
            // 
            this.ribbonControlAdv1.ActivateOnFirstClick = true;
            this.ribbonControlAdv1.AutoLayoutToolStrip = true;
            this.ribbonControlAdv1.CaptionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControlAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ribbonControlAdv1.Header.AddMainItem(toolStripTabItem1);
            this.ribbonControlAdv1.Header.AddMainItem(toolStripTabItem2);
            this.ribbonControlAdv1.Header.AddQuickItem(new Syncfusion.Windows.Forms.Tools.QuickButtonReflectable(toolStripButton1));
            this.ribbonControlAdv1.Header.AddQuickItem(new Syncfusion.Windows.Forms.Tools.QuickButtonReflectable(toolStripButton2));
            this.ribbonControlAdv1.Header.AddQuickItem(new Syncfusion.Windows.Forms.Tools.QuickButtonReflectable(toolStripButton3));
            this.ribbonControlAdv1.Location = new System.Drawing.Point(1, 1);
            this.ribbonControlAdv1.MenuButtonFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ribbonControlAdv1.MenuButtonText = "FILE";
            this.ribbonControlAdv1.MenuButtonWidth = 56;
            this.ribbonControlAdv1.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.ribbonControlAdv1.Name = "ribbonControlAdv1";
            this.ribbonControlAdv1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Managed;
            // 
            // ribbonControlAdv1.OfficeMenu
            // 
            this.ribbonControlAdv1.OfficeMenu.Name = "OfficeMenu";
            this.ribbonControlAdv1.OfficeMenu.ShowItemToolTips = true;
            this.ribbonControlAdv1.OfficeMenu.Size = new System.Drawing.Size(12, 65);
            this.ribbonControlAdv1.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ribbonControlAdv1.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            this.ribbonControlAdv1.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2013;
            this.ribbonControlAdv1.SelectedTab = this.toolStripTabItem1;
            this.ribbonControlAdv1.ShowRibbonDisplayOptionButton = false;
            this.ribbonControlAdv1.Size = new System.Drawing.Size(871, 158);
            this.ribbonControlAdv1.SystemText.QuickAccessDialogDropDownName = "Start menu";
            this.ribbonControlAdv1.SystemText.RenameDisplayLabelText = "&Display Name:";
            this.ribbonControlAdv1.TabIndex = 0;
            this.ribbonControlAdv1.Text = "Windows Explorer Demo";
            this.ribbonControlAdv1.TitleColor = System.Drawing.Color.Black;
            // 
            // toolStripTabItem1
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripTabItem1, "C");
            this.toolStripTabItem1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTabItem1.Name = "toolStripTabItem1";
            // 
            // ribbonControlAdv1.ribbonPanel1
            // 
            this.toolStripTabItem1.Panel.Controls.Add(this.toolStripEx1);
            this.toolStripTabItem1.Panel.Controls.Add(this.toolStripEx2);
            this.toolStripTabItem1.Panel.Controls.Add(this.toolStripEx3);
            this.toolStripTabItem1.Panel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.toolStripTabItem1.Panel.Name = "ribbonPanel1";
            this.toolStripTabItem1.Panel.Padding = new System.Windows.Forms.Padding(0, 1, 26, 0);
            this.toolStripTabItem1.Panel.ScrollPosition = 0;
            this.toolStripTabItem1.Panel.TabIndex = 2;
            this.toolStripTabItem1.Panel.Text = "Computer";
            this.toolStripTabItem1.Position = 0;
            this.toolStripTabItem1.Size = new System.Drawing.Size(78, 25);
            this.toolStripTabItem1.Tag = "1";
            this.toolStripTabItem1.Text = "Computer";
            // 
            // toolStripEx1
            // 
            this.superAccelerator1.SetCollapsedDropDownAccelerator(this.toolStripEx1, null);
            this.toolStripEx1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStripEx1.Location = new System.Drawing.Point(0, 1);
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.Office12Mode = false;
            this.toolStripEx1.Size = new System.Drawing.Size(158, 99);
            this.toolStripEx1.TabIndex = 0;
            this.toolStripEx1.Text = "Lcation";
            // 
            // toolStripButton1
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripButton1, "P");
            this.toolStripButton1.AutoToolTip = false;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(63, 96);
            this.toolStripButton1.Text = "Properties";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            toolTipInfo1.BackColor = System.Drawing.Color.White;
            toolTipInfo1.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo1.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo1.Body.Text = "\r\nShow the properties of the selected item.\r\n";
            toolTipInfo1.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo1.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo1.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo1.Header.Text = "Properties (Alt + Enter)";
            this.superToolTip1.SetToolTip(this.toolStripButton1, toolTipInfo1);
            // 
            // toolStripButton2
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripButton2, "O");
            this.toolStripButton2.AutoToolTip = false;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(40, 96);
            this.toolStripButton2.Text = "Open";
            this.toolStripButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            toolTipInfo2.BackColor = System.Drawing.Color.White;
            toolTipInfo2.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo2.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo2.Body.Text = "\r\nOpen the selected file with default program.";
            toolTipInfo2.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo2.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo2.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo2.Header.Text = "Open";
            this.superToolTip1.SetToolTip(this.toolStripButton2, toolTipInfo2);
            // 
            // toolStripButton3
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripButton3, "R");
            this.toolStripButton3.AutoToolTip = false;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(52, 96);
            this.toolStripButton3.Text = "Rename";
            this.toolStripButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            toolTipInfo3.BackColor = System.Drawing.Color.White;
            toolTipInfo3.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo3.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo3.Body.Text = "\r\nRename the selected item.\r\n";
            toolTipInfo3.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo3.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo3.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo3.Header.Text = "Rename (F2)";
            this.superToolTip1.SetToolTip(this.toolStripButton3, toolTipInfo3);
            // 
            // toolStripEx2
            // 
            this.superAccelerator1.SetCollapsedDropDownAccelerator(this.toolStripEx2, null);
            this.toolStripEx2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx2.Image = null;
            this.toolStripEx2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSplitButtonEx1,
            this.toolStripButton10});
            this.toolStripEx2.Location = new System.Drawing.Point(160, 1);
            this.toolStripEx2.Name = "toolStripEx2";
            this.toolStripEx2.Office12Mode = false;
            this.toolStripEx2.Size = new System.Drawing.Size(244, 99);
            this.toolStripEx2.TabIndex = 1;
            this.toolStripEx2.Text = "Network";
            // 
            // toolStripDropDownButton1
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripDropDownButton1, "A");
            this.toolStripDropDownButton1.AutoToolTip = false;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fsfToolStripMenuItem,
            this.fsfToolStripMenuItem1});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(56, 96);
            this.toolStripDropDownButton1.Text = "Access \r\nMedia";
            this.toolStripDropDownButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            toolTipInfo4.BackColor = System.Drawing.Color.White;
            toolTipInfo4.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo4.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo4.Body.Text = "\r\nConnect to or disconnect from media server.\r\n";
            toolTipInfo4.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo4.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo4.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo4.Header.Text = "Access Media\r\n";
            this.superToolTip1.SetToolTip(this.toolStripDropDownButton1, toolTipInfo4);
            // 
            // fsfToolStripMenuItem
            // 
            this.fsfToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fsfToolStripMenuItem.Image")));
            this.fsfToolStripMenuItem.Name = "fsfToolStripMenuItem";
            this.fsfToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.fsfToolStripMenuItem.Text = "Connect to a media server";
            // 
            // fsfToolStripMenuItem1
            // 
            this.fsfToolStripMenuItem1.Enabled = false;
            this.fsfToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("fsfToolStripMenuItem1.Image")));
            this.fsfToolStripMenuItem1.Name = "fsfToolStripMenuItem1";
            this.fsfToolStripMenuItem1.Size = new System.Drawing.Size(232, 22);
            this.fsfToolStripMenuItem1.Text = "Discconect from a media server";
            // 
            // toolStripSplitButtonEx1
            // 
            this.toolStripSplitButtonEx1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripSplitButtonEx1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mapNetworkDriveToolStripMenuItem,
            this.discconectNetworkDriveToolStripMenuItem});
            this.toolStripSplitButtonEx1.Image = global::WindowsExplorerDemo_2013.Properties.Resources.Map_Network_Drive;
            this.toolStripSplitButtonEx1.Name = "toolStripSplitButtonEx1";
            this.toolStripSplitButtonEx1.Size = new System.Drawing.Size(98, 96);
            this.toolStripSplitButtonEx1.Text = " Map network \r\n     drive";
            this.toolStripSplitButtonEx1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripSplitButtonEx1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mapNetworkDriveToolStripMenuItem
            // 
            this.mapNetworkDriveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mapNetworkDriveToolStripMenuItem.Image")));
            this.mapNetworkDriveToolStripMenuItem.Name = "mapNetworkDriveToolStripMenuItem";
            this.mapNetworkDriveToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.mapNetworkDriveToolStripMenuItem.Text = "Map network drive";
            // 
            // discconectNetworkDriveToolStripMenuItem
            // 
            this.discconectNetworkDriveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("discconectNetworkDriveToolStripMenuItem.Image")));
            this.discconectNetworkDriveToolStripMenuItem.Name = "discconectNetworkDriveToolStripMenuItem";
            this.discconectNetworkDriveToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.discconectNetworkDriveToolStripMenuItem.Text = "Disconnect network drive";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(87, 96);
            this.toolStripButton10.Text = "Add a network\r\n drive";
            this.toolStripButton10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripEx3
            // 
            this.superAccelerator1.SetCollapsedDropDownAccelerator(this.toolStripEx3, null);
            this.toolStripEx3.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx3.Image = null;
            this.toolStripEx3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripEx3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripPanelItem1});
            this.toolStripEx3.Location = new System.Drawing.Point(406, 1);
            this.toolStripEx3.Name = "toolStripEx3";
            this.toolStripEx3.Office12Mode = false;
            this.toolStripEx3.Size = new System.Drawing.Size(249, 99);
            this.toolStripEx3.TabIndex = 2;
            this.toolStripEx3.Text = "System";
            // 
            // toolStripButton4
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripButton4, "CP");
            this.toolStripButton4.AutoToolTip = false;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(53, 96);
            this.toolStripButton4.Text = "Open \r\nSettings";
            this.toolStripButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            toolTipInfo5.BackColor = System.Drawing.Color.White;
            toolTipInfo5.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo5.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo5.Body.Text = "\r\nChange settings and customized the functionality of your computer.\r\n";
            toolTipInfo5.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo5.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo5.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo5.Header.Text = "Open Settings\r\n";
            this.superToolTip1.SetToolTip(this.toolStripButton4, toolTipInfo5);
            // 
            // toolStripPanelItem1
            // 
            this.toolStripPanelItem1.CausesValidation = false;
            this.toolStripPanelItem1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7});
            this.toolStripPanelItem1.Name = "toolStripPanelItem1";
            this.toolStripPanelItem1.Size = new System.Drawing.Size(191, 99);
            this.toolStripPanelItem1.Text = "toolStripPanelItem1";
            this.toolStripPanelItem1.Transparent = true;
            // 
            // toolStripButton5
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripButton5, "U");
            this.toolStripButton5.AutoToolTip = false;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(187, 24);
            this.toolStripButton5.Text = "Uninstall or change a program";
            toolTipInfo6.BackColor = System.Drawing.Color.White;
            toolTipInfo6.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo6.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo6.Body.Text = "\r\nUninstalled a program, change installed features or repair an installation.";
            toolTipInfo6.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo6.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo6.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo6.Header.Text = "Uninstall or change a program";
            this.superToolTip1.SetToolTip(this.toolStripButton5, toolTipInfo6);
            // 
            // toolStripButton6
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripButton6, "S");
            this.toolStripButton6.AutoToolTip = false;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(121, 24);
            this.toolStripButton6.Text = "System Properties";
            toolTipInfo7.BackColor = System.Drawing.Color.White;
            toolTipInfo7.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo7.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo7.Body.Text = "\r\nShow information about your computer, such as processor speed or amount of inst" +
    "alled memory.\r\n";
            toolTipInfo7.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo7.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo7.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo7.Header.Text = "System Properties";
            this.superToolTip1.SetToolTip(this.toolStripButton6, toolTipInfo7);
            // 
            // toolStripButton7
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripButton7, "FC");
            this.toolStripButton7.AutoToolTip = false;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(70, 24);
            this.toolStripButton7.Text = "Manage";
            toolTipInfo8.BackColor = System.Drawing.Color.White;
            toolTipInfo8.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo8.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo8.Body.Text = "\r\nManage storage,events, Task scheduling, services and more..";
            toolTipInfo8.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo8.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo8.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo8.Header.Text = "Manage";
            this.superToolTip1.SetToolTip(this.toolStripButton7, toolTipInfo8);
            // 
            // toolStripTabItem2
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripTabItem2, "V");
            this.toolStripTabItem2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTabItem2.Name = "toolStripTabItem2";
            // 
            // ribbonControlAdv1.ribbonPanel2
            // 
            this.toolStripTabItem2.Panel.Controls.Add(this.toolStripEx4);
            this.toolStripTabItem2.Panel.Controls.Add(this.toolStripEx5);
            this.toolStripTabItem2.Panel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.toolStripTabItem2.Panel.Name = "ribbonPanel2";
            this.toolStripTabItem2.Panel.Padding = new System.Windows.Forms.Padding(0, 1, 26, 0);
            this.toolStripTabItem2.Panel.ScrollPosition = 0;
            this.toolStripTabItem2.Panel.TabIndex = 3;
            this.toolStripTabItem2.Panel.Text = "View";
            this.toolStripTabItem2.Position = 1;
            this.toolStripTabItem2.Size = new System.Drawing.Size(52, 25);
            this.toolStripTabItem2.Tag = "2";
            this.toolStripTabItem2.Text = "View";
            // 
            // toolStripEx4
            // 
            this.superAccelerator1.SetCollapsedDropDownAccelerator(this.toolStripEx4, null);
            this.toolStripEx4.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx4.Image = null;
            this.toolStripEx4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton4,
            this.toolStripPanelItem2});
            this.toolStripEx4.Location = new System.Drawing.Point(0, 1);
            this.toolStripEx4.Name = "toolStripEx4";
            this.toolStripEx4.Office12Mode = false;
            this.toolStripEx4.Size = new System.Drawing.Size(206, 99);
            this.toolStripEx4.TabIndex = 0;
            this.toolStripEx4.Text = "Panes";
            // 
            // toolStripDropDownButton4
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripDropDownButton4, "NP");
            this.toolStripDropDownButton4.AutoToolTip = false;
            this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navigationPaneToolStripMenuItem,
            this.expandToOpenFoldersToolStripMenuItem,
            this.showAllFoldersToolStripMenuItem,
            this.showLibrariesToolStripMenuItem});
            this.toolStripDropDownButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton4.Image")));
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(80, 96);
            this.toolStripDropDownButton4.Text = "Navigation\r\nPane";
            this.toolStripDropDownButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripDropDownButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            toolTipInfo9.BackColor = System.Drawing.Color.White;
            toolTipInfo9.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo9.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo9.Body.Text = "\r\nChoose what to display in the navigation pane.\r\n";
            toolTipInfo9.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo9.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo9.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo9.Header.Text = "Navigation Pane";
            this.superToolTip1.SetToolTip(this.toolStripDropDownButton4, toolTipInfo9);
            // 
            // navigationPaneToolStripMenuItem
            // 
            this.navigationPaneToolStripMenuItem.Checked = true;
            this.navigationPaneToolStripMenuItem.CheckOnClick = true;
            this.navigationPaneToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.navigationPaneToolStripMenuItem.Name = "navigationPaneToolStripMenuItem";
            this.navigationPaneToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.navigationPaneToolStripMenuItem.Text = "Navigation Pane";
            // 
            // expandToOpenFoldersToolStripMenuItem
            // 
            this.expandToOpenFoldersToolStripMenuItem.Name = "expandToOpenFoldersToolStripMenuItem";
            this.expandToOpenFoldersToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.expandToOpenFoldersToolStripMenuItem.Text = "Expand to Open folders";
            // 
            // showAllFoldersToolStripMenuItem
            // 
            this.showAllFoldersToolStripMenuItem.Name = "showAllFoldersToolStripMenuItem";
            this.showAllFoldersToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.showAllFoldersToolStripMenuItem.Text = "show all folders";
            // 
            // showLibrariesToolStripMenuItem
            // 
            this.showLibrariesToolStripMenuItem.Name = "showLibrariesToolStripMenuItem";
            this.showLibrariesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.showLibrariesToolStripMenuItem.Text = "shoow libraries";
            // 
            // toolStripPanelItem2
            // 
            this.toolStripPanelItem2.CausesValidation = false;
            this.toolStripPanelItem2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton8,
            this.toolStripButton9});
            this.toolStripPanelItem2.Name = "toolStripPanelItem2";
            this.toolStripPanelItem2.Padding = new System.Windows.Forms.Padding(8);
            this.toolStripPanelItem2.Size = new System.Drawing.Size(121, 99);
            this.toolStripPanelItem2.Text = "toolStripPanelItem2";
            this.toolStripPanelItem2.Transparent = true;
            // 
            // toolStripButton8
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripButton8, "PP");
            this.toolStripButton8.AutoToolTip = false;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Padding = new System.Windows.Forms.Padding(4);
            this.toolStripButton8.Size = new System.Drawing.Size(105, 28);
            this.toolStripButton8.Text = "Preview pane";
            toolTipInfo10.BackColor = System.Drawing.Color.White;
            toolTipInfo10.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo10.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo10.Body.Text = "\r\nShow or hide the preview pane.\r\n";
            toolTipInfo10.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo10.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo10.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo10.Header.Text = "Preview Pane(Alt + P)";
            this.superToolTip1.SetToolTip(this.toolStripButton8, toolTipInfo10);
            // 
            // toolStripButton9
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripButton9, "DP");
            this.toolStripButton9.AutoToolTip = false;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Padding = new System.Windows.Forms.Padding(6);
            this.toolStripButton9.Size = new System.Drawing.Size(103, 32);
            this.toolStripButton9.Text = "Details pane";
            toolTipInfo11.BackColor = System.Drawing.Color.White;
            toolTipInfo11.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo11.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo11.Body.Text = "\r\nShow or hide the details pane.\r\n";
            toolTipInfo11.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo11.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo11.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo11.Header.Text = "Details Pane (Alt + Shift + P)";
            this.superToolTip1.SetToolTip(this.toolStripButton9, toolTipInfo11);
            // 
            // toolStripEx5
            // 
            this.superAccelerator1.SetCollapsedDropDownAccelerator(this.toolStripEx5, null);
            this.toolStripEx5.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx5.Image = null;
            this.toolStripEx5.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStripEx5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripGallery1});
            this.toolStripEx5.Location = new System.Drawing.Point(208, 1);
            this.toolStripEx5.Name = "toolStripEx5";
            this.toolStripEx5.Office12Mode = false;
            this.toolStripEx5.Size = new System.Drawing.Size(324, 99);
            this.toolStripEx5.TabIndex = 1;
            this.toolStripEx5.Text = "Layout";
            // 
            // toolStripGallery1
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripGallery1, "L");
            this.toolStripGallery1.AutoSize = false;
            this.toolStripGallery1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripGallery1.BorderStyle = Syncfusion.Windows.Forms.Tools.ToolstripGalleryBorderStyle.None;
            this.toolStripGallery1.CaptionText = "";
            this.toolStripGallery1.CheckOnClick = true;
            this.toolStripGallery1.Dimensions = new System.Drawing.Size(3, 3);
            this.toolStripGallery1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripGallery1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.toolStripGallery1.ImageList = this.imageList1;
            this.toolStripGallery1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripGallery1.ItemBackColor = System.Drawing.Color.Empty;
            this.toolStripGallery1.ItemImageSize = new System.Drawing.Size(10, 10);
            this.toolStripGallery1.ItemPadding = new System.Windows.Forms.Padding(0);
            toolStripGalleryItem1.ImageIndex = 0;
            toolStripGalleryItem1.Text = "Extra large icons";
            toolStripGalleryItem1.ToolTipText = "";
            toolStripGalleryItem2.ImageIndex = 3;
            toolStripGalleryItem2.Text = "Large icons";
            toolStripGalleryItem2.ToolTipText = "";
            toolStripGalleryItem3.ImageIndex = 6;
            toolStripGalleryItem3.Text = "Medium icons";
            toolStripGalleryItem3.ToolTipText = "";
            toolStripGalleryItem4.ImageIndex = 1;
            toolStripGalleryItem4.Text = "Small icons";
            toolStripGalleryItem4.ToolTipText = "";
            toolStripGalleryItem5.ImageIndex = 4;
            toolStripGalleryItem5.Text = "List";
            toolStripGalleryItem5.ToolTipText = "";
            toolStripGalleryItem6.ImageIndex = 7;
            toolStripGalleryItem6.Text = "Details";
            toolStripGalleryItem6.ToolTipText = "";
            toolStripGalleryItem7.ImageIndex = 2;
            toolStripGalleryItem7.Text = "Tiles";
            toolStripGalleryItem7.ToolTipText = "";
            toolStripGalleryItem8.ImageIndex = 5;
            toolStripGalleryItem8.Text = "Content";
            toolStripGalleryItem8.ToolTipText = "";
            this.toolStripGallery1.Items.Add(toolStripGalleryItem1);
            this.toolStripGallery1.Items.Add(toolStripGalleryItem2);
            this.toolStripGallery1.Items.Add(toolStripGalleryItem3);
            this.toolStripGallery1.Items.Add(toolStripGalleryItem4);
            this.toolStripGallery1.Items.Add(toolStripGalleryItem5);
            this.toolStripGallery1.Items.Add(toolStripGalleryItem6);
            this.toolStripGallery1.Items.Add(toolStripGalleryItem7);
            this.toolStripGallery1.Items.Add(toolStripGalleryItem8);
            this.toolStripGallery1.ItemSize = new System.Drawing.Size(100, 17);
            this.toolStripGallery1.ItemTextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolStripGallery1.Margin = new System.Windows.Forms.Padding(0, 4, 0, 1);
            this.toolStripGallery1.Name = "toolStripGallery1";
            this.toolStripGallery1.ScrollerType = Syncfusion.Windows.Forms.Tools.ToolStripGalleryScrollerType.Compact;
            this.toolStripGallery1.ShowToolTip = true;
            this.toolStripGallery1.Size = new System.Drawing.Size(321, 64);
            this.toolStripGallery1.Text = "toolStripGallery1";
            this.toolStripGallery1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            toolTipInfo12.BackColor = System.Drawing.Color.White;
            toolTipInfo12.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo12.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo12.Body.Text = "\r\nChange your view.\r\n";
            toolTipInfo12.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo12.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo12.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo12.Header.Text = "More";
            this.superToolTip1.SetToolTip(this.toolStripGallery1, toolTipInfo12);
            // 
            // imageList1
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.imageList1, "ImageList1", 8);
#else
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
#endif
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Icon-3.png");
            this.imageList1.Images.SetKeyName(1, "Icon-4.png");
            this.imageList1.Images.SetKeyName(2, "Icon-5.png");
            this.imageList1.Images.SetKeyName(3, "Icon-6.png");
            this.imageList1.Images.SetKeyName(4, "Icon-7.png");
            this.imageList1.Images.SetKeyName(5, "Icon-8.png");
            this.imageList1.Images.SetKeyName(6, "Icon-9.png");
            this.imageList1.Images.SetKeyName(7, "Icon-10.png");
            // 
            // navigationView2
            // 
            bar1.ImageIndex = 2;
            bar1.Text = "My Computer";
            this.navigationView2.Bars.AddRange(new Syncfusion.Windows.Forms.Tools.Navigation.Bar[] {
            bar1});
            this.navigationView2.BeforeTouchSize = new System.Drawing.Size(517, 21);
            this.navigationView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationView2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationView2.Location = new System.Drawing.Point(0, 5);
            this.navigationView2.Name = "navigationView2";
            this.navigationView2.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.navigationView2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.navigationView2.SelectedBar = bar1;
            this.navigationView2.ShowHistoryButtons = true;
            this.navigationView2.ShowRootBarText = true;
            this.navigationView2.Size = new System.Drawing.Size(517, 21);
            this.navigationView2.TabIndex = 2;
            this.navigationView2.Text = "navigationView2";
            this.navigationView2.VisualStyle = Syncfusion.Windows.Forms.Tools.Navigation.VisualStyles.Custom;
            this.navigationView2.BarSelectionChanging += new System.EventHandler<Syncfusion.Windows.Forms.Tools.Navigation.BarSelectionChangingEventArgs>(this.navigationView2_BarSelectionChanging);
            // 
            // treeViewAdv1
            // 
            this.treeViewAdv1.AccelerateScrolling = Syncfusion.Windows.Forms.AccelerateScrollingBehavior.Immediate;
            this.treeViewAdv1.BackColor = System.Drawing.Color.White;
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewAdv1.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this.treeViewAdv1.BeforeTouchSize = new System.Drawing.Size(219, 244);
            this.treeViewAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.treeViewAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewAdv1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // 
            // 
            this.treeViewAdv1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv1.HelpTextControl.Name = "helpText";
            this.treeViewAdv1.HelpTextControl.Size = new System.Drawing.Size(49, 15);
            this.treeViewAdv1.HelpTextControl.TabIndex = 0;
            this.treeViewAdv1.HelpTextControl.Text = "help text";
            this.treeViewAdv1.InactiveSelectedNodeForeColor = System.Drawing.Color.Transparent;
            this.treeViewAdv1.LeftImageList = this.TreeViewImageList;
            this.treeViewAdv1.Location = new System.Drawing.Point(2, 0);
            this.treeViewAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.treeViewAdv1.Name = "treeViewAdv1";
            treeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.Expanded = true;
            treeNodeAdv1.LeftImageIndices = new int[] {
        14};
            treeNodeAdv1.MultiLine = true;
            treeNodeAdv2.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.LeftImageIndices = new int[] {
        8};
            treeNodeAdv2.MultiLine = true;
            treeNodeAdv2.Optioned = true;
            treeNodeAdv2.ShowLine = true;
            treeNodeAdv2.Text = "Desktop";
            treeNodeAdv3.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.Expanded = true;
            treeNodeAdv3.LeftImageIndices = new int[] {
        10};
            treeNodeAdv3.MultiLine = true;
            treeNodeAdv3.ShowLine = true;
            treeNodeAdv3.Text = "Downloads";
            treeNodeAdv4.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.LeftImageIndices = new int[] {
        9};
            treeNodeAdv4.MultiLine = true;
            treeNodeAdv4.ShowLine = true;
            treeNodeAdv4.Text = "Documents";
            treeNodeAdv5.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.LeftImageIndices = new int[] {
        12};
            treeNodeAdv5.MultiLine = true;
            treeNodeAdv5.ShowLine = true;
            treeNodeAdv5.Text = "Pictures";
            treeNodeAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv2,
            treeNodeAdv3,
            treeNodeAdv4,
            treeNodeAdv5});
            treeNodeAdv1.ShowLine = true;
            treeNodeAdv1.Text = "Quick access";
            treeNodeAdv6.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.Expanded = true;
            treeNodeAdv6.LeftImageIndices = new int[] {
        3};
            treeNodeAdv6.MultiLine = true;
            treeNodeAdv6.ShowLine = true;
            treeNodeAdv6.Text = "OneDrive";
            treeNodeAdv7.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.Expanded = true;
            treeNodeAdv7.LeftImageIndices = new int[] {
        4};
            treeNodeAdv7.MultiLine = true;
            treeNodeAdv8.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.Expanded = true;
            treeNodeAdv8.LeftImageIndices = new int[] {
        1};
            treeNodeAdv8.MultiLine = true;
            treeNodeAdv8.Optioned = true;
            treeNodeAdv8.ShowLine = true;
            treeNodeAdv8.Text = "Desktop";
            treeNodeAdv9.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.LeftImageIndices = new int[] {
        9};
            treeNodeAdv9.MultiLine = true;
            treeNodeAdv9.ShowLine = true;
            treeNodeAdv9.Text = "Documents";
            treeNodeAdv10.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv10.EnsureDefaultOptionedChild = true;
            treeNodeAdv10.LeftImageIndices = new int[] {
        2};
            treeNodeAdv10.MultiLine = true;
            treeNodeAdv10.ShowLine = true;
            treeNodeAdv10.Text = "Downloads";
            treeNodeAdv11.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv11.EnsureDefaultOptionedChild = true;
            treeNodeAdv11.LeftImageIndices = new int[] {
        5};
            treeNodeAdv11.MultiLine = true;
            treeNodeAdv11.ShowLine = true;
            treeNodeAdv11.Text = "Music";
            treeNodeAdv12.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv12.EnsureDefaultOptionedChild = true;
            treeNodeAdv12.LeftImageIndices = new int[] {
        4};
            treeNodeAdv12.MultiLine = true;
            treeNodeAdv12.ShowLine = true;
            treeNodeAdv12.Text = "Pictures";
            treeNodeAdv13.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv13.EnsureDefaultOptionedChild = true;
            treeNodeAdv13.LeftImageIndices = new int[] {
        6};
            treeNodeAdv13.MultiLine = true;
            treeNodeAdv13.ShowLine = true;
            treeNodeAdv13.Text = "Videos";
            treeNodeAdv14.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv14.EnsureDefaultOptionedChild = true;
            treeNodeAdv14.LeftImageIndices = new int[] {
        13};
            treeNodeAdv14.MultiLine = true;
            treeNodeAdv14.ShowLine = true;
            treeNodeAdv14.Text = "Local Disk (C:)";
            treeNodeAdv15.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv15.EnsureDefaultOptionedChild = true;
            treeNodeAdv15.LeftImageIndices = new int[] {
        13};
            treeNodeAdv15.MultiLine = true;
            treeNodeAdv15.ShowLine = true;
            treeNodeAdv15.Text = "Local Disk (D:)";
            treeNodeAdv7.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv8,
            treeNodeAdv9,
            treeNodeAdv10,
            treeNodeAdv11,
            treeNodeAdv12,
            treeNodeAdv13,
            treeNodeAdv14,
            treeNodeAdv15});
            treeNodeAdv7.ShowLine = true;
            treeNodeAdv7.Text = "This PC";
            treeNodeAdv16.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv16.EnsureDefaultOptionedChild = true;
            treeNodeAdv16.LeftImageIndices = new int[] {
        7};
            treeNodeAdv16.MultiLine = true;
            treeNodeAdv16.ShowLine = true;
            treeNodeAdv16.Text = "Network";
            this.treeViewAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv1,
            treeNodeAdv6,
            treeNodeAdv7,
            treeNodeAdv16});
            this.treeViewAdv1.SelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220))))));
            this.treeViewAdv1.SelectedNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this.treeViewAdv1.ShowFocusRect = false;
            this.treeViewAdv1.ShowLines = false;
            this.treeViewAdv1.Size = new System.Drawing.Size(219, 244);
            this.treeViewAdv1.Style = Syncfusion.Windows.Forms.Tools.TreeStyle.Metro;
            this.treeViewAdv1.TabIndex = 3;
            this.treeViewAdv1.Text = "treeViewAdv1";
            // 
            // 
            // 
            this.treeViewAdv1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.treeViewAdv1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv1.ToolTipControl.Name = "toolTip";
            this.treeViewAdv1.ToolTipControl.Size = new System.Drawing.Size(41, 15);
            this.treeViewAdv1.ToolTipControl.TabIndex = 1;
            this.treeViewAdv1.ToolTipControl.Text = "toolTip";
            // 
            // TreeViewImageList
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.TreeViewImageList, "TreeViewImageList", 15);
#else
            this.TreeViewImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TreeViewImageList.ImageStream")));
#endif  
            this.TreeViewImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.TreeViewImageList.Images.SetKeyName(0, "Icon-1.png");
            this.TreeViewImageList.Images.SetKeyName(1, "Icon-2.png");
            this.TreeViewImageList.Images.SetKeyName(2, "Icon-6.png");
            this.TreeViewImageList.Images.SetKeyName(3, "Icon-7.png");
            this.TreeViewImageList.Images.SetKeyName(4, "Icon-8.png");
            this.TreeViewImageList.Images.SetKeyName(5, "Icon-9.png");
            this.TreeViewImageList.Images.SetKeyName(6, "Icon-10.png");
            this.TreeViewImageList.Images.SetKeyName(7, "Icon-13.png");
            this.TreeViewImageList.Images.SetKeyName(8, "small desktop.png");
            this.TreeViewImageList.Images.SetKeyName(9, "Small document.png");
            this.TreeViewImageList.Images.SetKeyName(10, "Small download.png");
            this.TreeViewImageList.Images.SetKeyName(11, "Small folder.png");
            this.TreeViewImageList.Images.SetKeyName(12, "Small pictures.png");
            this.TreeViewImageList.Images.SetKeyName(13, "Local Disk(c).png");
            this.TreeViewImageList.Images.SetKeyName(14, "Quick Access.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.treeViewAdv1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.popupControlContainer1);
            this.panel1.Controls.Add(this.listView2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 244);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 244);
            this.panel2.TabIndex = 7;
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.Controls.Add(this.buttonAdv6);
            this.popupControlContainer1.Controls.Add(this.buttonAdv5);
            this.popupControlContainer1.Controls.Add(this.buttonAdv4);
            this.popupControlContainer1.Controls.Add(this.buttonAdv3);
            this.popupControlContainer1.Controls.Add(this.buttonAdv2);
            this.popupControlContainer1.Controls.Add(this.buttonAdv1);
            this.popupControlContainer1.Location = new System.Drawing.Point(414, 237);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Size = new System.Drawing.Size(200, 232);
            this.popupControlContainer1.TabIndex = 6;
            // 
            // buttonAdv6
            // 
            this.buttonAdv6.BeforeTouchSize = new System.Drawing.Size(200, 30);
            this.buttonAdv6.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAdv6.FlatAppearance.BorderSize = 0;
            this.buttonAdv6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdv6.IsBackStageButton = false;
            this.buttonAdv6.Location = new System.Drawing.Point(0, 150);
            this.buttonAdv6.Name = "buttonAdv6";
            this.buttonAdv6.Size = new System.Drawing.Size(200, 30);
            this.buttonAdv6.TabIndex = 5;
            this.buttonAdv6.Text = "Close";
            this.buttonAdv6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // buttonAdv5
            // 
            this.buttonAdv5.BeforeTouchSize = new System.Drawing.Size(200, 30);
            this.buttonAdv5.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAdv5.FlatAppearance.BorderSize = 0;
            this.buttonAdv5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdv5.IsBackStageButton = false;
            this.buttonAdv5.Location = new System.Drawing.Point(0, 120);
            this.buttonAdv5.Name = "buttonAdv5";
            this.buttonAdv5.Size = new System.Drawing.Size(200, 30);
            this.buttonAdv5.TabIndex = 4;
            this.buttonAdv5.Text = "Help";
            this.buttonAdv5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // buttonAdv4
            // 
            this.buttonAdv4.BeforeTouchSize = new System.Drawing.Size(200, 30);
            this.buttonAdv4.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAdv4.FlatAppearance.BorderSize = 0;
            this.buttonAdv4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdv4.IsBackStageButton = false;
            this.buttonAdv4.Location = new System.Drawing.Point(0, 90);
            this.buttonAdv4.Name = "buttonAdv4";
            this.buttonAdv4.Size = new System.Drawing.Size(200, 30);
            this.buttonAdv4.TabIndex = 3;
            this.buttonAdv4.Text = "DeleteHistory";
            this.buttonAdv4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // buttonAdv3
            // 
            this.buttonAdv3.BeforeTouchSize = new System.Drawing.Size(200, 30);
            this.buttonAdv3.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAdv3.FlatAppearance.BorderSize = 0;
            this.buttonAdv3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdv3.IsBackStageButton = false;
            this.buttonAdv3.Location = new System.Drawing.Point(0, 60);
            this.buttonAdv3.Name = "buttonAdv3";
            this.buttonAdv3.Size = new System.Drawing.Size(200, 30);
            this.buttonAdv3.TabIndex = 2;
            this.buttonAdv3.Text = "Open Window Powershell";
            this.buttonAdv3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.BeforeTouchSize = new System.Drawing.Size(200, 30);
            this.buttonAdv2.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAdv2.FlatAppearance.BorderSize = 0;
            this.buttonAdv2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdv2.IsBackStageButton = false;
            this.buttonAdv2.Location = new System.Drawing.Point(0, 30);
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Size = new System.Drawing.Size(200, 30);
            this.buttonAdv2.TabIndex = 1;
            this.buttonAdv2.Text = "Open Command Prompt";
            this.buttonAdv2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(200, 30);
            this.buttonAdv1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAdv1.FlatAppearance.BorderSize = 0;
            this.buttonAdv1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdv1.Image = global::WindowsExplorerDemo_2013.Properties.Resources.NavigationPane;
            this.buttonAdv1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.Location = new System.Drawing.Point(0, 0);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(200, 30);
            this.buttonAdv1.TabIndex = 0;
            this.buttonAdv1.Text = "Open &new Window";
            this.buttonAdv1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // listView2
            // 
            this.listView2.BackgroundImageTiled = true;
            listViewGroup1.Header = "Folders (6)";
            listViewGroup1.Name = "Folders (6)";
            listViewGroup2.Header = "Devices and Drivers (3)";
            listViewGroup2.Name = "Devices and Drivers (3)";
            this.listView2.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.listView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView2.ImeMode = System.Windows.Forms.ImeMode.On;
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup1;
            listViewItem3.Group = listViewGroup1;
            listViewItem4.Group = listViewGroup1;
            listViewItem5.Group = listViewGroup1;
            listViewItem6.Group = listViewGroup1;
            listViewItem7.Group = listViewGroup2;
            listViewItem8.Group = listViewGroup2;
            listViewItem9.Group = listViewGroup2;
            this.listView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.listView2.LargeImageList = this.imageList2;
            this.listView2.Location = new System.Drawing.Point(227, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(632, 244);
            this.listView2.TabIndex = 5;
            this.listView2.TileSize = new System.Drawing.Size(20, 30);
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // imageList2
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.imageList2, "ImageList2", 9);
#else
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
#endif
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "__DVD RW drive.png");
            this.imageList2.Images.SetKeyName(1, "__Local Disk(c).png");
            this.imageList2.Images.SetKeyName(2, "__Local Disk(d).png");
            this.imageList2.Images.SetKeyName(3, "__Desktop.png");
            this.imageList2.Images.SetKeyName(4, "__Document.png");
            this.imageList2.Images.SetKeyName(5, "__Download.png");
            this.imageList2.Images.SetKeyName(6, "__Music.png");
            this.imageList2.Images.SetKeyName(7, "__Pictures.png");
            this.imageList2.Images.SetKeyName(8, "__Video.png");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonEdit1);
            this.panel3.Controls.Add(this.navigationView2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(1, 163);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.panel3.Size = new System.Drawing.Size(867, 31);
            this.panel3.TabIndex = 5;
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.BeforeTouchSize = new System.Drawing.Size(121, 21);
            this.buttonEdit1.Buttons.Add(this.buttonEditChildButton1);
            this.buttonEdit1.Controls.Add(this.buttonEditChildButton1);
            this.buttonEdit1.Controls.Add(this.textBoxExt1);
            this.buttonEdit1.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonEdit1.Location = new System.Drawing.Point(741, 5);
            this.buttonEdit1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Size = new System.Drawing.Size(121, 21);
            this.buttonEdit1.TabIndex = 3;
            this.buttonEdit1.TextBox = this.textBoxExt1;
            // 
            // buttonEditChildButton1
            // 
            this.buttonEditChildButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton1.BeforeTouchSize = new System.Drawing.Size(18, 17);
            this.buttonEditChildButton1.FlatAppearance.BorderSize = 0;
            this.buttonEditChildButton1.Image = null;
            this.buttonEditChildButton1.IsBackStageButton = false;
            this.buttonEditChildButton1.Name = "buttonEditChildButton1";
            this.buttonEditChildButton1.PreferredWidth = 18;
            this.buttonEditChildButton1.TabIndex = 1;
            this.buttonEditChildButton1.Text = "buttonEditChildButton1";
            // 
            // textBoxExt1
            // 
            bannerTextInfo1.Text = "Search";
            bannerTextInfo1.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.textBoxExt1, bannerTextInfo1);
            this.textBoxExt1.BeforeTouchSize = new System.Drawing.Size(97, 13);
            this.textBoxExt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxExt1.Location = new System.Drawing.Point(3, 4);
            this.textBoxExt1.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textBoxExt1.Name = "textBoxExt1";
            this.textBoxExt1.Size = new System.Drawing.Size(97, 13);
            this.textBoxExt1.TabIndex = 0;
            this.textBoxExt1.Text = "buttonEdit1";
            // 
            // imageList3
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.imageList3, "ImageList3", 7);
#else
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
#endif
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "Search.png");
            this.imageList3.Images.SetKeyName(1, "1.png");
            this.imageList3.Images.SetKeyName(2, "2.png");
            this.imageList3.Images.SetKeyName(3, "3.png");
            this.imageList3.Images.SetKeyName(4, "4.png");
            this.imageList3.Images.SetKeyName(5, "5.png");
            this.imageList3.Images.SetKeyName(6, "6.png");
            // 
            // superToolTip1
            // 
            this.superToolTip1.MaxWidth = 200;
            this.superToolTip1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(869, 439);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbonControlAdv1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(1, 5, 1, 1);
            this.Text = "Windows Explorer Demo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).EndInit();
            this.ribbonControlAdv1.ResumeLayout(false);
            this.ribbonControlAdv1.PerformLayout();
            this.toolStripTabItem1.Panel.ResumeLayout(false);
            this.toolStripTabItem1.Panel.PerformLayout();
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            this.toolStripEx2.ResumeLayout(false);
            this.toolStripEx2.PerformLayout();
            this.toolStripEx3.ResumeLayout(false);
            this.toolStripEx3.PerformLayout();
            this.toolStripTabItem2.Panel.ResumeLayout(false);
            this.toolStripTabItem2.Panel.PerformLayout();
            this.toolStripEx4.ResumeLayout(false);
            this.toolStripEx4.PerformLayout();
            this.toolStripEx5.ResumeLayout(false);
            this.toolStripEx5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.popupControlContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1)).EndInit();
            this.buttonEdit1.ResumeLayout(false);
            this.buttonEdit1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.RibbonControlAdv ribbonControlAdv1;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem1;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem2;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx4;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem2;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx5;
        private Syncfusion.Windows.Forms.Tools.NavigationView navigationView2;     
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private Syncfusion.Windows.Forms.Tools.TreeViewAdv treeViewAdv1;
        private System.Windows.Forms.ImageList TreeViewImageList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ImageList imageList2;
        private Syncfusion.Windows.Forms.Tools.SuperAccelerator superAccelerator1;
        private Syncfusion.Windows.Forms.PopupControlContainer popupControlContainer1;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv6;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv5;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv4;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Syncfusion.Windows.Forms.Tools.ButtonEdit buttonEdit1;
        private Syncfusion.Windows.Forms.Tools.ButtonEditChildButton buttonEditChildButton1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
        private System.Windows.Forms.ImageList imageList3;
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
        private Syncfusion.Windows.Forms.Tools.SuperToolTip superToolTip1;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv2;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
        private Syncfusion.Windows.Forms.Tools.ToolStripGallery toolStripGallery1;
        private System.Windows.Forms.ToolStripMenuItem fsfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fsfToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonEx1;
        private System.Windows.Forms.ToolStripMenuItem mapNetworkDriveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discconectNetworkDriveToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripMenuItem navigationPaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandToOpenFoldersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllFoldersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLibrariesToolStripMenuItem;
    }
}