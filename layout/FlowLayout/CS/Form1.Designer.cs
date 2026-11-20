#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Drawing;
using System.Windows.Forms;

namespace FlowLayoutExample
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
            for (int i = 1; i <= count; i++)
            {
                string imagePath = ($"FlowLayoutExample.Images.{folder}.Image_{i}.png");
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv2 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv3 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem toolStripGalleryItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem();
            Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem toolStripGalleryItem2 = new Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem();
            Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem toolStripGalleryItem3 = new Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem();
            Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem toolStripGalleryItem4 = new Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.FlowLayoutpanel = new System.Windows.Forms.Panel();
            this.panelC = new System.Windows.Forms.Panel();
            this.panelD = new System.Windows.Forms.Panel();
            this.panelPC = new System.Windows.Forms.Panel();
            this.folderWithName6 = new FlowLayoutExample.FolderWithName();
            this.folderWithName5 = new FlowLayoutExample.FolderWithName();
            this.folderWithName4 = new FlowLayoutExample.FolderWithName();
            this.folderWithName3 = new FlowLayoutExample.FolderWithName();
            this.folderWithName2 = new FlowLayoutExample.FolderWithName();
            this.folderWithName1 = new FlowLayoutExample.FolderWithName();
            this.treeViewpanel = new System.Windows.Forms.Panel();
            this.treeViewAdv1 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.ribbonControlAdv1 = new Syncfusion.Windows.Forms.Tools.RibbonControlAdv();
            this.toolStripTabItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripEx2 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripGallery2 = new Syncfusion.Windows.Forms.Tools.ToolStripGallery();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.flowLayout2 = new Syncfusion.Windows.Forms.Tools.FlowLayout(this.components);
            this.flowLayout1 = new Syncfusion.Windows.Forms.Tools.FlowLayout(this.components);
            this.flowLayout3 = new Syncfusion.Windows.Forms.Tools.FlowLayout(this.components);
            this.folderWithName12 = new FlowLayoutExample.FolderWithName();
            this.folderWithName11 = new FlowLayoutExample.FolderWithName();
            this.folderWithName10 = new FlowLayoutExample.FolderWithName();
            this.folderWithName9 = new FlowLayoutExample.FolderWithName();
            this.folderWithName8 = new FlowLayoutExample.FolderWithName();
            this.folderWithName7 = new FlowLayoutExample.FolderWithName();
            this.panelMain.SuspendLayout();
            this.FlowLayoutpanel.SuspendLayout();
            this.panelPC.SuspendLayout();
            this.treeViewpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).BeginInit();
            this.ribbonControlAdv1.SuspendLayout();
            this.toolStripTabItem1.Panel.SuspendLayout();
            this.toolStripEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flowLayout2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowLayout1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowLayout3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.FlowLayoutpanel);
            this.panelMain.Controls.Add(this.treeViewpanel);
            this.panelMain.Controls.Add(this.ribbonControlAdv1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(6, 1);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(876, 590);
            this.panelMain.TabIndex = 0;
            // 
            // FlowLayoutpanel
            // 
            this.FlowLayoutpanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FlowLayoutpanel.Controls.Add(this.panelC);
            this.FlowLayoutpanel.Controls.Add(this.panelD);
            this.FlowLayoutpanel.Controls.Add(this.panelPC);
            this.FlowLayoutpanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.FlowLayoutpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutpanel.Location = new System.Drawing.Point(133, 130);
            this.FlowLayoutpanel.Margin = new System.Windows.Forms.Padding(2);
            this.FlowLayoutpanel.Name = "FlowLayoutpanel";
            this.FlowLayoutpanel.Size = new System.Drawing.Size(743, 460);
            this.FlowLayoutpanel.TabIndex = 2;
            // 
            // panelC
            // 
            this.panelC.AutoScroll = true;
            this.panelC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelC.Location = new System.Drawing.Point(0, 0);
            this.panelC.Margin = new System.Windows.Forms.Padding(2);
            this.panelC.Name = "panelC";
            this.panelC.Size = new System.Drawing.Size(743, 460);
            this.panelC.TabIndex = 0;
            // 
            // panelD
            // 
            this.panelD.AutoScroll = true;
            this.panelD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelD.Location = new System.Drawing.Point(0, 0);
            this.panelD.Margin = new System.Windows.Forms.Padding(2);
            this.panelD.Name = "panelD";
            this.panelD.Size = new System.Drawing.Size(743, 460);
            this.panelD.TabIndex = 7;
            // 
            // panelPC
            // 
            this.panelPC.AutoScroll = true;
            this.panelPC.Controls.Add(this.folderWithName6);
            this.panelPC.Controls.Add(this.folderWithName5);
            this.panelPC.Controls.Add(this.folderWithName4);
            this.panelPC.Controls.Add(this.folderWithName3);
            this.panelPC.Controls.Add(this.folderWithName2);
            this.panelPC.Controls.Add(this.folderWithName1);
            this.panelPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPC.Location = new System.Drawing.Point(0, 0);
            this.panelPC.Name = "panelPC";
            this.panelPC.Size = new System.Drawing.Size(743, 460);
            this.panelPC.TabIndex = 6;
            // 
            // folderWithName6
            // 
            this.folderWithName6.BackColor = System.Drawing.Color.White;
            this.folderWithName6.FolderImage = ((System.Drawing.Image)(resources.GetObject("folderWithName6.FolderImage")));
            this.folderWithName6.FolderName = "Videos";
            this.folderWithName6.Location = new System.Drawing.Point(20, 20);
            this.folderWithName6.Margin = new System.Windows.Forms.Padding(1);
            this.folderWithName6.Name = "folderWithName6";
            this.folderWithName6.Size = new System.Drawing.Size(100, 97);
            this.folderWithName6.TabIndex = 5;
            // 
            // folderWithName5
            // 
            this.folderWithName5.BackColor = System.Drawing.Color.White;
            this.folderWithName5.FolderImage = ((System.Drawing.Image)(resources.GetObject("folderWithName5.FolderImage")));
            this.folderWithName5.FolderName = "Pictures";
            this.folderWithName5.Location = new System.Drawing.Point(140, 20);
            this.folderWithName5.Margin = new System.Windows.Forms.Padding(1);
            this.folderWithName5.Name = "folderWithName5";
            this.folderWithName5.Size = new System.Drawing.Size(100, 97);
            this.folderWithName5.TabIndex = 4;
            // 
            // folderWithName4
            // 
            this.folderWithName4.BackColor = System.Drawing.Color.White;
            this.folderWithName4.FolderImage = ((System.Drawing.Image)(resources.GetObject("folderWithName4.FolderImage")));
            this.folderWithName4.FolderName = "Music";
            this.folderWithName4.Location = new System.Drawing.Point(260, 20);
            this.folderWithName4.Margin = new System.Windows.Forms.Padding(1);
            this.folderWithName4.Name = "folderWithName4";
            this.folderWithName4.Size = new System.Drawing.Size(100, 97);
            this.folderWithName4.TabIndex = 3;
            // 
            // folderWithName3
            // 
            this.folderWithName3.BackColor = System.Drawing.Color.White;
            this.folderWithName3.FolderImage = ((System.Drawing.Image)(resources.GetObject("folderWithName3.FolderImage")));
            this.folderWithName3.FolderName = "Download";
            this.folderWithName3.Location = new System.Drawing.Point(380, 20);
            this.folderWithName3.Margin = new System.Windows.Forms.Padding(1);
            this.folderWithName3.Name = "folderWithName3";
            this.folderWithName3.Size = new System.Drawing.Size(100, 97);
            this.folderWithName3.TabIndex = 2;
            // 
            // folderWithName2
            // 
            this.folderWithName2.BackColor = System.Drawing.Color.White;
            this.folderWithName2.FolderImage = ((System.Drawing.Image)(resources.GetObject("folderWithName2.FolderImage")));
            this.folderWithName2.FolderName = "Document";
            this.folderWithName2.Location = new System.Drawing.Point(500, 20);
            this.folderWithName2.Margin = new System.Windows.Forms.Padding(1);
            this.folderWithName2.Name = "folderWithName2";
            this.folderWithName2.Size = new System.Drawing.Size(100, 97);
            this.folderWithName2.TabIndex = 1;
            // 
            // folderWithName1
            // 
            this.folderWithName1.BackColor = System.Drawing.Color.White;
            this.folderWithName1.FolderImage = ((System.Drawing.Image)(resources.GetObject("folderWithName1.FolderImage")));
            this.folderWithName1.FolderName = "Desktop";
            this.folderWithName1.Location = new System.Drawing.Point(620, 20);
            this.folderWithName1.Margin = new System.Windows.Forms.Padding(1);
            this.folderWithName1.Name = "folderWithName1";
            this.folderWithName1.Size = new System.Drawing.Size(100, 97);
            this.folderWithName1.TabIndex = 0;
            // 
            // treeViewpanel
            // 
            this.treeViewpanel.Controls.Add(this.treeViewAdv1);
            this.treeViewpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewpanel.Location = new System.Drawing.Point(0, 130);
            this.treeViewpanel.Margin = new System.Windows.Forms.Padding(2);
            this.treeViewpanel.Name = "treeViewpanel";
            this.treeViewpanel.Size = new System.Drawing.Size(133, 460);
            this.treeViewpanel.TabIndex = 1;
            // 
            // treeViewAdv1
            // 
            this.treeViewAdv1.AccelerateScrolling = Syncfusion.Windows.Forms.AccelerateScrollingBehavior.Immediate;
            this.treeViewAdv1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.ShowPlusMinus = false;
            treeNodeAdvStyleInfo1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.treeViewAdv1.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this.treeViewAdv1.BeforeTouchSize = new System.Drawing.Size(133, 460);
            this.treeViewAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.treeViewAdv1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.treeViewAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewAdv1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.treeViewAdv1.GutterSpace = 10;
            // 
            // 
            // 
            this.treeViewAdv1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv1.HelpTextControl.Name = "helpText";
            this.treeViewAdv1.HelpTextControl.Size = new System.Drawing.Size(49, 15);
            this.treeViewAdv1.HelpTextControl.TabIndex = 0;
            this.treeViewAdv1.HelpTextControl.Text = "help text";
            this.treeViewAdv1.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.treeViewAdv1.ItemHeight = 22;
            this.treeViewAdv1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.treeViewAdv1.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv1.Margin = new System.Windows.Forms.Padding(2, 13, 2, 2);
            this.treeViewAdv1.MetroColor = System.Drawing.Color.White;
            this.treeViewAdv1.Name = "treeViewAdv1";
            treeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.Expanded = true;
            treeNodeAdv1.LeftImageIndices = new int[] {
        0};
            treeNodeAdv1.MultiLine = true;
            treeNodeAdv2.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.LeftImageIndices = new int[] {
        1};
            treeNodeAdv2.MultiLine = true;
            treeNodeAdv2.Optioned = true;
            treeNodeAdv2.ShowLine = true;
            treeNodeAdv2.Text = "Local Disk (C:)";
            treeNodeAdv3.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.LeftImageIndices = new int[] {
        2};
            treeNodeAdv3.MultiLine = true;
            treeNodeAdv3.ShowLine = true;
            treeNodeAdv3.Text = "Local Disk (D:)";
            treeNodeAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv2,
            treeNodeAdv3});
            treeNodeAdv1.ShowLine = true;
            treeNodeAdv1.Text = "This PC";
            this.treeViewAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv1});
            this.treeViewAdv1.SelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197))))));
            this.treeViewAdv1.SelectedNodeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.treeViewAdv1.ShowFocusRect = false;
            this.treeViewAdv1.ShowLines = false;
            this.treeViewAdv1.ShowPlusMinus = false;
            this.treeViewAdv1.Size = new System.Drawing.Size(133, 460);
            this.treeViewAdv1.Style = Syncfusion.Windows.Forms.Tools.TreeStyle.Office2016Colorful;
            this.treeViewAdv1.TabIndex = 6;
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
            this.treeViewAdv1.TransparentControls = true;
            // 
            // ribbonControlAdv1
            // 
            this.ribbonControlAdv1.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Top;
            this.ribbonControlAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ribbonControlAdv1.Header.AddMainItem(toolStripTabItem1);
            this.ribbonControlAdv1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControlAdv1.MenuButtonFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ribbonControlAdv1.MenuButtonText = "";
            this.ribbonControlAdv1.MenuButtonVisible = false;
            this.ribbonControlAdv1.MenuButtonWidth = 56;
            this.ribbonControlAdv1.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.ribbonControlAdv1.Name = "ribbonControlAdv1";
            this.ribbonControlAdv1.Office2016ColorScheme = Syncfusion.Windows.Forms.Tools.Office2016ColorScheme.White;
            this.ribbonControlAdv1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Managed;
            // 
            // ribbonControlAdv1.OfficeMenu
            // 
            this.ribbonControlAdv1.OfficeMenu.Name = "OfficeMenu";
            this.ribbonControlAdv1.OfficeMenu.ShowItemToolTips = true;
            this.ribbonControlAdv1.OfficeMenu.Size = new System.Drawing.Size(12, 65);
            this.ribbonControlAdv1.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ribbonControlAdv1.QuickPanelVisible = false;
            this.ribbonControlAdv1.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            this.ribbonControlAdv1.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2016;
            this.ribbonControlAdv1.SelectedTab = this.toolStripTabItem1;
            this.ribbonControlAdv1.ShowRibbonDisplayOptionButton = false;
            this.ribbonControlAdv1.Size = new System.Drawing.Size(876, 130);
            this.ribbonControlAdv1.SystemText.QuickAccessDialogDropDownName = "Start menu";
            this.ribbonControlAdv1.SystemText.RenameDisplayLabelText = "&Display Name:";
            this.ribbonControlAdv1.TabIndex = 0;
            this.ribbonControlAdv1.Text = "ribbonControlAdv1";
            this.ribbonControlAdv1.TitleColor = System.Drawing.Color.Black;
            this.ribbonControlAdv1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // toolStripTabItem1
            // 
            this.toolStripTabItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTabItem1.Name = "toolStripTabItem1";
            // 
            // ribbonControlAdv1.ribbonPanel1
            // 
            this.toolStripTabItem1.Panel.Controls.Add(this.toolStripEx2);
            this.toolStripTabItem1.Panel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.toolStripTabItem1.Panel.Name = "ribbonPanel1";
            this.toolStripTabItem1.Panel.Padding = new System.Windows.Forms.Padding(0, 1, 23, 0);
            this.toolStripTabItem1.Panel.ScrollPosition = 0;
            this.toolStripTabItem1.Panel.TabIndex = 2;
            this.toolStripTabItem1.Panel.Text = "View";
            this.toolStripTabItem1.Position = 0;
            this.toolStripTabItem1.Size = new System.Drawing.Size(48, 25);
            this.toolStripTabItem1.Tag = "1";
            this.toolStripTabItem1.Text = "View";
            // 
            // toolStripEx2
            // 
            this.toolStripEx2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx2.Image = null;
            this.toolStripEx2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripGallery2});
            this.toolStripEx2.Location = new System.Drawing.Point(0, 1);
            this.toolStripEx2.Name = "toolStripEx2";
            this.toolStripEx2.Office12Mode = false;
            this.toolStripEx2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripEx2.Size = new System.Drawing.Size(323, 69);
            this.toolStripEx2.TabIndex = 1;
            // 
            // toolStripGallery2
            // 
            this.toolStripGallery2.BorderStyle = Syncfusion.Windows.Forms.Tools.ToolstripGalleryBorderStyle.None;
            this.toolStripGallery2.CaptionText = "";
            this.toolStripGallery2.CheckOnClick = true;
            this.toolStripGallery2.Dimensions = new System.Drawing.Size(2, 2);
            this.toolStripGallery2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripGallery2.ItemBackColor = System.Drawing.Color.Empty;
            this.toolStripGallery2.ItemImageSize = new System.Drawing.Size(15, 15);
            toolStripGalleryItem1.Image = global::FlowLayoutExample.Properties.Resources.ExtraLargeIcons;
            toolStripGalleryItem1.Text = "Extra large icons   ";
            toolStripGalleryItem1.ToolTipText = "";
            toolStripGalleryItem2.Image = global::FlowLayoutExample.Properties.Resources.LargeIcons;
            toolStripGalleryItem2.Text = "Large icons             ";
            toolStripGalleryItem2.ToolTipText = "";
            toolStripGalleryItem3.Image = global::FlowLayoutExample.Properties.Resources.MediumIcons;
            toolStripGalleryItem3.Text = "Medium icons       ";
            toolStripGalleryItem3.ToolTipText = "";
            toolStripGalleryItem4.Image = global::FlowLayoutExample.Properties.Resources.SmallIcons;
            toolStripGalleryItem4.Text = "Small icons             ";
            toolStripGalleryItem4.ToolTipText = "";
            this.toolStripGallery2.Items.Add(toolStripGalleryItem1);
            this.toolStripGallery2.Items.Add(toolStripGalleryItem2);
            this.toolStripGallery2.Items.Add(toolStripGalleryItem3);
            this.toolStripGallery2.Items.Add(toolStripGalleryItem4);
            this.toolStripGallery2.ItemSize = new System.Drawing.Size(155, 25);
            this.toolStripGallery2.ItemTextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolStripGallery2.Name = "toolStripGallery2";
            this.toolStripGallery2.ShowToolTip = true;
            this.toolStripGallery2.Size = new System.Drawing.Size(314, 52);
            this.toolStripGallery2.Text = "toolStripGallery2";
            // 
            // imageList1
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.imageList1, "ImageList1", 3);
#else
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
#endif
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ThisPC.png");
            this.imageList1.Images.SetKeyName(1, "__Local Disk(c).png");
            this.imageList1.Images.SetKeyName(2, "__Local Disk(d).png");
            
            // 
            // flowLayout2
            // 
            this.flowLayout2.Alignment = Syncfusion.Windows.Forms.Tools.FlowAlignment.Near;
            this.flowLayout2.BottomMargin = 20;
            this.flowLayout2.ContainerControl = this.panelC;
            this.flowLayout2.HGap = 20;
            this.flowLayout2.HorzFarMargin = 20;
            this.flowLayout2.HorzNearMargin = 20;
            this.flowLayout2.TopMargin = 20;
            this.flowLayout2.VGap = 20;
            // 
            // flowLayout1
            // 
            this.flowLayout1.Alignment = Syncfusion.Windows.Forms.Tools.FlowAlignment.Near;
            this.flowLayout1.BottomMargin = 20;
            this.flowLayout1.ContainerControl = this.panelD;
            this.flowLayout1.HGap = 20;
            this.flowLayout1.HorzFarMargin = 20;
            this.flowLayout1.HorzNearMargin = 20;
            this.flowLayout1.TopMargin = 20;
            this.flowLayout1.VGap = 20;
            // 
            // flowLayout3
            // 
            this.flowLayout3.Alignment = Syncfusion.Windows.Forms.Tools.FlowAlignment.Near;
            this.flowLayout3.BottomMargin = 20;
            this.flowLayout3.ContainerControl = this.panelPC;
            this.flowLayout3.HGap = 20;
            this.flowLayout3.HorzFarMargin = 20;
            this.flowLayout3.HorzNearMargin = 20;
            this.flowLayout3.TopMargin = 20;
            this.flowLayout3.VGap = 20;
            // 
            // folderWithName12
            // 
            this.folderWithName12.BackColor = System.Drawing.Color.White;
            this.folderWithName12.FolderImage = ((System.Drawing.Image)(resources.GetObject("folderWithName12.FolderImage")));
            this.folderWithName12.FolderName = "Ribbon Folder";
            this.folderWithName12.Location = new System.Drawing.Point(20, 20);
            this.folderWithName12.Margin = new System.Windows.Forms.Padding(1);
            this.folderWithName12.Name = "folderWithName12";
            this.folderWithName12.Size = new System.Drawing.Size(100, 97);
            this.folderWithName12.TabIndex = 6;
            // 
            // folderWithName11
            // 
            this.folderWithName11.BackColor = System.Drawing.Color.White;
            this.folderWithName11.FolderImage = ((System.Drawing.Image)(resources.GetObject("folderWithName11.FolderImage")));
            this.folderWithName11.FolderName = "Grids";
            this.folderWithName11.Location = new System.Drawing.Point(20, 137);
            this.folderWithName11.Margin = new System.Windows.Forms.Padding(1);
            this.folderWithName11.Name = "folderWithName11";
            this.folderWithName11.Size = new System.Drawing.Size(100, 97);
            this.folderWithName11.TabIndex = 5;
            // 
            // folderWithName10
            // 
            this.folderWithName10.BackColor = System.Drawing.Color.White;
            this.folderWithName10.FolderImage = ((System.Drawing.Image)(resources.GetObject("folderWithName10.FolderImage")));
            this.folderWithName10.FolderName = "Browser files";
            this.folderWithName10.Location = new System.Drawing.Point(20, 254);
            this.folderWithName10.Margin = new System.Windows.Forms.Padding(1);
            this.folderWithName10.Name = "folderWithName10";
            this.folderWithName10.Size = new System.Drawing.Size(100, 97);
            this.folderWithName10.TabIndex = 4;
            // 
            // folderWithName9
            // 
            this.folderWithName9.BackColor = System.Drawing.Color.White;
            this.folderWithName9.FolderImage = ((System.Drawing.Image)(resources.GetObject("folderWithName9.FolderImage")));
            this.folderWithName9.FolderName = "VSFiles";
            this.folderWithName9.Location = new System.Drawing.Point(140, 20);
            this.folderWithName9.Margin = new System.Windows.Forms.Padding(1);
            this.folderWithName9.Name = "folderWithName9";
            this.folderWithName9.Size = new System.Drawing.Size(100, 97);
            this.folderWithName9.TabIndex = 3;
            // 
            // folderWithName8
            // 
            this.folderWithName8.BackColor = System.Drawing.Color.White;
            this.folderWithName8.FolderImage = ((System.Drawing.Image)(resources.GetObject("folderWithName8.FolderImage")));
            this.folderWithName8.FolderName = "Files";
            this.folderWithName8.Location = new System.Drawing.Point(140, 137);
            this.folderWithName8.Margin = new System.Windows.Forms.Padding(1);
            this.folderWithName8.Name = "folderWithName8";
            this.folderWithName8.Size = new System.Drawing.Size(100, 97);
            this.folderWithName8.TabIndex = 2;
            // 
            // folderWithName7
            // 
            this.folderWithName7.BackColor = System.Drawing.Color.White;
            this.folderWithName7.FolderImage = ((System.Drawing.Image)(resources.GetObject("folderWithName7.FolderImage")));
            this.folderWithName7.FolderName = "New folder";
            this.folderWithName7.Location = new System.Drawing.Point(140, 254);
            this.folderWithName7.Margin = new System.Windows.Forms.Padding(1);
            this.folderWithName7.Name = "folderWithName7";
            this.folderWithName7.Size = new System.Drawing.Size(100, 97);
            this.folderWithName7.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 597);
            this.Controls.Add(this.panelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "FlowLayout Example";
            this.panelMain.ResumeLayout(false);
            this.FlowLayoutpanel.ResumeLayout(false);
            this.panelPC.ResumeLayout(false);
            this.treeViewpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).EndInit();
            this.ribbonControlAdv1.ResumeLayout(false);
            this.ribbonControlAdv1.PerformLayout();
            this.toolStripTabItem1.Panel.ResumeLayout(false);
            this.toolStripTabItem1.Panel.PerformLayout();
            this.toolStripEx2.ResumeLayout(false);
            this.toolStripEx2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flowLayout2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowLayout1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowLayout3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private Syncfusion.Windows.Forms.Tools.RibbonControlAdv ribbonControlAdv1;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem1;
        private System.Windows.Forms.Panel treeViewpanel;
        private Syncfusion.Windows.Forms.Tools.TreeViewAdv treeViewAdv1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel FlowLayoutpanel;
        private System.Windows.Forms.Panel panelC;
        private System.Windows.Forms.Panel panelD;
        private FlowLayoutExample.FolderWithName folderWithName6;
        private FlowLayoutExample.FolderWithName folderWithName5;
        private FlowLayoutExample.FolderWithName folderWithName4;
        private FlowLayoutExample.FolderWithName folderWithName3;
        private FlowLayoutExample.FolderWithName folderWithName2;
        private FlowLayoutExample.FolderWithName folderWithName1;
        private Syncfusion.Windows.Forms.Tools.FlowLayout flowLayout2;
        private FolderWithName folderWithName12;
        private FolderWithName folderWithName11;
        private FolderWithName folderWithName10;
        private FolderWithName folderWithName9;
        private FolderWithName folderWithName8;
        private FolderWithName folderWithName7;
        private Syncfusion.Windows.Forms.Tools.FlowLayout flowLayout1;
        private System.Windows.Forms.Panel panelPC;
        private Syncfusion.Windows.Forms.Tools.FlowLayout flowLayout3;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx2;
        private Syncfusion.Windows.Forms.Tools.ToolStripGallery toolStripGallery2;
    }
}