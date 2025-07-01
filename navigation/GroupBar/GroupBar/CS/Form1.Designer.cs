#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.WinForms.ListView;
using System.Drawing;
using System.Windows.Forms;

namespace GroupBarDemo_2005
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
                string imagePath = ($"GroupBarDemo_2005.Images.{folder}.Image_{i}.png");
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
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.gbVisualStudio = new Syncfusion.Windows.Forms.Tools.GroupBar();
            this.WinFormsGroupView = new Syncfusion.Windows.Forms.Tools.GroupView();
            this.ilGroupBarLarge = new System.Windows.Forms.ImageList(this.components);
            this.ilGroupBarSmall = new System.Windows.Forms.ImageList(this.components);
            this.GeneralGroupView = new Syncfusion.Windows.Forms.Tools.GroupView();
            this.ComponentsGroupView = new Syncfusion.Windows.Forms.Tools.GroupView();
            this.WinFormsGroupBarItem = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.ComponentsGroupBarItem = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.GeneralGroupBarItem = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.numericUpDown1 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxAdv7 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv3 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxAdv9 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTextAlignment = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGBBorder = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cmbGBVisualStyle = new Syncfusion.WinForms.ListView.SfComboBox();
            this.smallImageList = new System.Windows.Forms.ImageList(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.comboBoxAdv1 = new Syncfusion.WinForms.ListView.SfComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbVisualStudio)).BeginInit();
            this.gbVisualStudio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTextAlignment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGBBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGBVisualStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.BeforeTouchSize = 9;
            this.splitContainerAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAdv1.IsSplitterFixed = true;
            this.splitContainerAdv1.Location = new System.Drawing.Point(10, 10);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.Controls.Add(this.gbVisualStudio);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.Controls.Add(this.gradientPanel1);
            this.splitContainerAdv1.Size = new System.Drawing.Size(915, 531);
            this.splitContainerAdv1.SplitterDistance = 588;
            this.splitContainerAdv1.SplitterWidth = 9;
            this.splitContainerAdv1.TabIndex = 197;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            this.splitContainerAdv1.ThemeName = "None";
            // 
            // gbVisualStudio
            // 
            this.gbVisualStudio.AllowCollapse = true;
            this.gbVisualStudio.AllowDrop = true;
            this.gbVisualStudio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbVisualStudio.AnimatedSelection = false;
            this.gbVisualStudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.gbVisualStudio.BeforeTouchSize = new System.Drawing.Size(586, 530);
            this.gbVisualStudio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.gbVisualStudio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gbVisualStudio.CollapseImage = ((System.Drawing.Image)(resources.GetObject("gbVisualStudio.CollapseImage")));
            this.gbVisualStudio.Controls.Add(this.WinFormsGroupView);
            this.gbVisualStudio.Controls.Add(this.GeneralGroupView);
            this.gbVisualStudio.Controls.Add(this.ComponentsGroupView);
            this.gbVisualStudio.ExpandButtonToolTip = null;
            this.gbVisualStudio.ExpandedWidth = 773;
            this.gbVisualStudio.ExpandImage = ((System.Drawing.Image)(resources.GetObject("gbVisualStudio.ExpandImage")));
            this.gbVisualStudio.FlatLook = true;
            this.gbVisualStudio.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVisualStudio.ForeColor = System.Drawing.Color.White;
            this.gbVisualStudio.GroupBarDropDownToolTip = null;
            this.gbVisualStudio.GroupBarItemHeight = 25;
            this.gbVisualStudio.GroupBarItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupBarItem[] {
            this.WinFormsGroupBarItem,
            this.ComponentsGroupBarItem,
            this.GeneralGroupBarItem});
            this.gbVisualStudio.HeaderBackColor = System.Drawing.SystemColors.ControlDark;
            this.gbVisualStudio.IndexOnVisibleItems = true;
            this.gbVisualStudio.Location = new System.Drawing.Point(0, 0);
            this.gbVisualStudio.MinimizeButtonToolTip = null;
            this.gbVisualStudio.Name = "gbVisualStudio";
            this.gbVisualStudio.NavigationPaneTooltip = null;
            this.gbVisualStudio.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.gbVisualStudio.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.gbVisualStudio.PopupClientSize = new System.Drawing.Size(0, 0);
            this.gbVisualStudio.SelectedItem = 0;
            this.gbVisualStudio.Size = new System.Drawing.Size(586, 530);
            this.gbVisualStudio.SmartSizeBox = false;
            this.gbVisualStudio.Splittercolor = System.Drawing.SystemColors.ControlDark;
            this.gbVisualStudio.StackedMode = true;
            this.gbVisualStudio.TabIndex = 135;
            this.gbVisualStudio.Text = "groupBar4";
            this.gbVisualStudio.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left;
            // 
            // WinFormsGroupView
            // 
            this.WinFormsGroupView.AllowDragAnyObject = true;
            this.WinFormsGroupView.AllowDragDrop = true;
            this.WinFormsGroupView.BackColor = System.Drawing.Color.White;
            this.WinFormsGroupView.BeforeTouchSize = new System.Drawing.Size(584, 389);
            this.WinFormsGroupView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WinFormsGroupView.ButtonView = true;
            this.WinFormsGroupView.FlatLook = true;
            this.WinFormsGroupView.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinFormsGroupView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WinFormsGroupView.GroupViewItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupViewItem[] {
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Pointer", 11, true, null, "Pointer"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Label", 12, true, null, "Label"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("LinkLabel", 13, true, null, "LinkLabel"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Button", 14, true, null, "Button"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("TextBox", 15, true, null, "TextBox"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("MainMenu", 16, true, null, "MainMenu"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("CheckBox", 17, true, null, "CheckBox"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("RadioButton", 18, true, null, "RadioButton"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("GroupBox", 19, true, null, "GroupBox"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("PictureBox", 20, true, null, "PictureBox"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("DataGrid", 21, true, null, "DataGrid"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Chart", 9, true, null, "Chart"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Color Picker", 10, true, null, "Color Picker"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("MessageQueue", 26, true, null, "MessageQueue")});
            this.WinFormsGroupView.IntegratedScrolling = true;
            this.WinFormsGroupView.ItemYSpacing = 1;
            this.WinFormsGroupView.LargeImageList = this.ilGroupBarLarge;
            this.WinFormsGroupView.Location = new System.Drawing.Point(1, 27);
            this.WinFormsGroupView.Name = "WinFormsGroupView";
            this.WinFormsGroupView.SelectedItem = 0;
            this.WinFormsGroupView.Size = new System.Drawing.Size(584, 389);
            this.WinFormsGroupView.SmallImageList = this.ilGroupBarSmall;
            this.WinFormsGroupView.SmallImageView = true;
            this.WinFormsGroupView.TabIndex = 4;
            this.WinFormsGroupView.Text = "groupViewControl3";
            // 
            // ilGroupBarLarge
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.ilGroupBarLarge, "IlGroupBarLarge", 28);
#else
            this.ilGroupBarLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilGroupBarLarge.ImageStream")));
#endif
            this.ilGroupBarLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.ilGroupBarLarge.Images.SetKeyName(0, "");
            this.ilGroupBarLarge.Images.SetKeyName(1, "");
            this.ilGroupBarLarge.Images.SetKeyName(2, "");
            this.ilGroupBarLarge.Images.SetKeyName(3, "");
            this.ilGroupBarLarge.Images.SetKeyName(4, "");
            this.ilGroupBarLarge.Images.SetKeyName(5, "");
            this.ilGroupBarLarge.Images.SetKeyName(6, "");
            this.ilGroupBarLarge.Images.SetKeyName(7, "");
            this.ilGroupBarLarge.Images.SetKeyName(8, "");
            this.ilGroupBarLarge.Images.SetKeyName(9, "");
            this.ilGroupBarLarge.Images.SetKeyName(10, "");
            this.ilGroupBarLarge.Images.SetKeyName(11, "");
            this.ilGroupBarLarge.Images.SetKeyName(12, "");
            this.ilGroupBarLarge.Images.SetKeyName(13, "");
            this.ilGroupBarLarge.Images.SetKeyName(14, "");
            this.ilGroupBarLarge.Images.SetKeyName(15, "");
            this.ilGroupBarLarge.Images.SetKeyName(16, "");
            this.ilGroupBarLarge.Images.SetKeyName(17, "");
            this.ilGroupBarLarge.Images.SetKeyName(18, "");
            this.ilGroupBarLarge.Images.SetKeyName(19, "");
            this.ilGroupBarLarge.Images.SetKeyName(20, "");
            this.ilGroupBarLarge.Images.SetKeyName(21, "");
            this.ilGroupBarLarge.Images.SetKeyName(22, "");
            this.ilGroupBarLarge.Images.SetKeyName(23, "");
            this.ilGroupBarLarge.Images.SetKeyName(24, "");
            this.ilGroupBarLarge.Images.SetKeyName(25, "");
            this.ilGroupBarLarge.Images.SetKeyName(26, "");
            this.ilGroupBarLarge.Images.SetKeyName(27, "");
            // 
            // ilGroupBarSmall
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.ilGroupBarSmall, "IlGroupBarSmall", 32);
#else
            this.ilGroupBarSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilGroupBarSmall.ImageStream")));
#endif
            this.ilGroupBarSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.ilGroupBarSmall.Images.SetKeyName(0, "");
            this.ilGroupBarSmall.Images.SetKeyName(1, "");
            this.ilGroupBarSmall.Images.SetKeyName(2, "");
            this.ilGroupBarSmall.Images.SetKeyName(3, "");
            this.ilGroupBarSmall.Images.SetKeyName(4, "");
            this.ilGroupBarSmall.Images.SetKeyName(5, "");
            this.ilGroupBarSmall.Images.SetKeyName(6, "");
            this.ilGroupBarSmall.Images.SetKeyName(7, "");
            this.ilGroupBarSmall.Images.SetKeyName(8, "");
            this.ilGroupBarSmall.Images.SetKeyName(9, "");
            this.ilGroupBarSmall.Images.SetKeyName(10, "");
            this.ilGroupBarSmall.Images.SetKeyName(11, "");
            this.ilGroupBarSmall.Images.SetKeyName(12, "");
            this.ilGroupBarSmall.Images.SetKeyName(13, "");
            this.ilGroupBarSmall.Images.SetKeyName(14, "");
            this.ilGroupBarSmall.Images.SetKeyName(15, "");
            this.ilGroupBarSmall.Images.SetKeyName(16, "");
            this.ilGroupBarSmall.Images.SetKeyName(17, "");
            this.ilGroupBarSmall.Images.SetKeyName(18, "");
            this.ilGroupBarSmall.Images.SetKeyName(19, "");
            this.ilGroupBarSmall.Images.SetKeyName(20, "");
            this.ilGroupBarSmall.Images.SetKeyName(21, "");
            this.ilGroupBarSmall.Images.SetKeyName(22, "");
            this.ilGroupBarSmall.Images.SetKeyName(23, "");
            this.ilGroupBarSmall.Images.SetKeyName(24, "");
            this.ilGroupBarSmall.Images.SetKeyName(25, "");
            this.ilGroupBarSmall.Images.SetKeyName(26, "");
            this.ilGroupBarSmall.Images.SetKeyName(27, "");
            this.ilGroupBarSmall.Images.SetKeyName(28, "");
            this.ilGroupBarSmall.Images.SetKeyName(29, "");
            this.ilGroupBarSmall.Images.SetKeyName(30, "");
            this.ilGroupBarSmall.Images.SetKeyName(31, "");
            // 
            // GeneralGroupView
            // 
            this.GeneralGroupView.AllowDragDrop = true;
            this.GeneralGroupView.BackColor = System.Drawing.Color.White;
            this.GeneralGroupView.BeforeTouchSize = new System.Drawing.Size(218, 223);
            this.GeneralGroupView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GeneralGroupView.FlatLook = true;
            this.GeneralGroupView.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneralGroupView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GeneralGroupView.GroupViewItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupViewItem[] {
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Pointer", 11, true, null, "Pointer"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Label", 12, true, null, "Label"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("LinkLabel", 13, true, null, "LinkLabel"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Button", 14, true, null, "Button"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("TextBox", 15, true, null, "TextBox"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("MainMenu", 16, true, null, "MainMenu"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("CheckBox", 17, true, null, "CheckBox"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("RadioButton", 18, true, null, "RadioButton")});
            this.GeneralGroupView.ImageSpacing = 5;
            this.GeneralGroupView.IntegratedScrolling = true;
            this.GeneralGroupView.ItemXSpacing = 0;
            this.GeneralGroupView.ItemYSpacing = 0;
            this.GeneralGroupView.LargeImageList = this.ilGroupBarLarge;
            this.GeneralGroupView.Location = new System.Drawing.Point(1, 76);
            this.GeneralGroupView.Name = "GeneralGroupView";
            this.GeneralGroupView.Size = new System.Drawing.Size(218, 223);
            this.GeneralGroupView.SmallImageList = this.ilGroupBarSmall;
            this.GeneralGroupView.SmallImageView = true;
            this.GeneralGroupView.TabIndex = 6;
            this.GeneralGroupView.Text = "groupViewControl5";
            // 
            // ComponentsGroupView
            // 
            this.ComponentsGroupView.AllowDragDrop = true;
            this.ComponentsGroupView.BackColor = System.Drawing.Color.White;
            this.ComponentsGroupView.BeforeTouchSize = new System.Drawing.Size(586, 454);
            this.ComponentsGroupView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ComponentsGroupView.ButtonView = true;
            this.ComponentsGroupView.FlatLook = true;
            this.ComponentsGroupView.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComponentsGroupView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ComponentsGroupView.GroupViewItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupViewItem[] {
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Pointer", 11, true, null, "Pointer"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("FileSystemWatcher", 22, true, null, "FileSystemWatcher"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("EventLog", 23, true, null, "EventLog"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("DirectoryEntry", 24, true, null, "DirectoryEntry"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("DirectorySearcher", 25, true, null, "DirectorySearcher"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("MessageQueue", 26, true, null, "MessageQueue")});
            this.ComponentsGroupView.HighlightItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(194)))));
            this.ComponentsGroupView.IntegratedScrolling = true;
            this.ComponentsGroupView.ItemYSpacing = 1;
            this.ComponentsGroupView.LargeImageList = this.ilGroupBarLarge;
            this.ComponentsGroupView.Location = new System.Drawing.Point(1, 51);
            this.ComponentsGroupView.Name = "ComponentsGroupView";
            this.ComponentsGroupView.SelectedHighlightItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(62)))));
            this.ComponentsGroupView.SelectedItem = 0;
            this.ComponentsGroupView.SelectedItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(111)))));
            this.ComponentsGroupView.SelectingItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(111)))));
            this.ComponentsGroupView.Size = new System.Drawing.Size(586, 454);
            this.ComponentsGroupView.SmallImageList = this.ilGroupBarSmall;
            this.ComponentsGroupView.SmallImageView = true;
            this.ComponentsGroupView.TabIndex = 4;
            this.ComponentsGroupView.Text = "groupViewControl4";
            // 
            // WinFormsGroupBarItem
            // 
            this.WinFormsGroupBarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.WinFormsGroupBarItem.Client = this.WinFormsGroupView;
            this.WinFormsGroupBarItem.Text = "All Windows Forms";
            // 
            // ComponentsGroupBarItem
            // 
            this.ComponentsGroupBarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ComponentsGroupBarItem.Client = this.ComponentsGroupView;
            this.ComponentsGroupBarItem.Text = "Components";
            // 
            // GeneralGroupBarItem
            // 
            this.GeneralGroupBarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.GeneralGroupBarItem.Client = this.GeneralGroupView;
            this.GeneralGroupBarItem.Text = "General";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.checkBoxAdv1);
            this.gradientPanel1.Controls.Add(this.numericUpDown1);
            this.gradientPanel1.Controls.Add(this.label4);
            this.gradientPanel1.Controls.Add(this.checkBoxAdv7);
            this.gradientPanel1.Controls.Add(this.checkBoxAdv3);
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.checkBoxAdv9);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.cmbTextAlignment);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.cmbGBBorder);
            this.gradientPanel1.Controls.Add(this.cmbGBVisualStyle);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(318, 531);
            this.gradientPanel1.TabIndex = 198;
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.AutoHeight = true;
            this.checkBoxAdv1.BeforeTouchSize = new System.Drawing.Size(162, 20);
            this.checkBoxAdv1.DrawFocusRectangle = false;
            this.checkBoxAdv1.Location = new System.Drawing.Point(27, 355);
            this.checkBoxAdv1.MetroColor = System.Drawing.Color.Gray;
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(162, 20);
            this.checkBoxAdv1.TabIndex = 145;
            this.checkBoxAdv1.Text = "Integrated Scrollbar";
            this.checkBoxAdv1.ThemeName = "Default";
            this.checkBoxAdv1.ThemesEnabled = false;
            this.checkBoxAdv1.CheckStateChanged += new System.EventHandler(this.IntegratedScrollingCheckBox_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BeforeTouchSize = new System.Drawing.Size(136, 22);
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Location = new System.Drawing.Point(159, 180);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(136, 22);
            this.numericUpDown1.TabIndex = 144;
            this.numericUpDown1.ThemeStyle.HoverUpDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.numericUpDown1.ThemeStyle.PressedUpDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 143;
            this.label4.Text = "GroupBar Item Height";
            // 
            // checkBoxAdv7
            // 
            this.checkBoxAdv7.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxAdv7.Checked = true;
            this.checkBoxAdv7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv7.DrawFocusRectangle = false;
            this.checkBoxAdv7.Location = new System.Drawing.Point(27, 272);
            this.checkBoxAdv7.MetroColor = System.Drawing.Color.Gray;
            this.checkBoxAdv7.Name = "checkBoxAdv7";
            this.checkBoxAdv7.Size = new System.Drawing.Size(102, 17);
            this.checkBoxAdv7.TabIndex = 134;
            this.checkBoxAdv7.Text = "Show Chevron";
            this.checkBoxAdv7.ThemeName = "Default";
            this.checkBoxAdv7.ThemesEnabled = false;
            this.checkBoxAdv7.CheckStateChanged += new System.EventHandler(this.ChevronCheckBox_CheckedChanged);
            // 
            // checkBoxAdv3
            // 
            this.checkBoxAdv3.AutoHeight = true;
            this.checkBoxAdv3.BeforeTouchSize = new System.Drawing.Size(68, 20);
            this.checkBoxAdv3.DrawFocusRectangle = false;
            this.checkBoxAdv3.Location = new System.Drawing.Point(27, 314);
            this.checkBoxAdv3.MetroColor = System.Drawing.Color.Gray;
            this.checkBoxAdv3.Name = "checkBoxAdv3";
            this.checkBoxAdv3.Size = new System.Drawing.Size(68, 20);
            this.checkBoxAdv3.TabIndex = 0;
            this.checkBoxAdv3.Text = "Collapse";
            this.checkBoxAdv3.ThemeName = "Default";
            this.checkBoxAdv3.ThemesEnabled = false;
            this.checkBoxAdv3.CheckStateChanged += new System.EventHandler(this.cbAllowCollapse_CheckStateChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 141;
            this.label3.Text = "Header Text Alignment";
            // 
            // checkBoxAdv9
            // 
            this.checkBoxAdv9.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxAdv9.Checked = true;
            this.checkBoxAdv9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv9.DrawFocusRectangle = false;
            this.checkBoxAdv9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv9.Location = new System.Drawing.Point(27, 230);
            this.checkBoxAdv9.MetroColor = System.Drawing.Color.Gray;
            this.checkBoxAdv9.Name = "checkBoxAdv9";
            this.checkBoxAdv9.Size = new System.Drawing.Size(140, 17);
            this.checkBoxAdv9.TabIndex = 137;
            this.checkBoxAdv9.Text = "Enable Stacked Mode";
            this.checkBoxAdv9.ThemeName = "Default";
            this.checkBoxAdv9.ThemesEnabled = false;
            this.checkBoxAdv9.CheckStateChanged += new System.EventHandler(this.StackedModeCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 139;
            this.label2.Text = "Visual Styles";
            // 
            // cmbTextAlignment
            // 
            this.cmbTextAlignment.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cmbTextAlignment.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbTextAlignment.Location = new System.Drawing.Point(159, 106);
            this.cmbTextAlignment.Name = "cmbTextAlignment";
            this.cmbTextAlignment.Size = new System.Drawing.Size(135, 21);
            this.cmbTextAlignment.TabIndex = 142;
            this.cmbTextAlignment.Text = "Left";
            this.cmbTextAlignment.ThemeName = "Default";
            this.cmbTextAlignment.SelectedIndexChanged += new System.EventHandler(this.GBTextAlignmentComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 136;
            this.label1.Text = "GroupBar Border Style";
            // 
            // cmbGBBorder
            // 
            this.cmbGBBorder.BackColor = System.Drawing.Color.White;
            this.cmbGBBorder.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cmbGBBorder.Location = new System.Drawing.Point(159, 143);
            this.cmbGBBorder.Name = "cmbGBBorder";
            this.cmbGBBorder.Size = new System.Drawing.Size(135, 21);
            this.cmbGBBorder.TabIndex = 137;
            this.cmbGBBorder.Text = "None";
            this.cmbGBBorder.SelectedIndexChanged += new System.EventHandler(this.GBBorderComboBox_SelectedIndexChanged);
            // 
            // cmbGBVisualStyle
            // 
            this.cmbGBVisualStyle.BackColor = System.Drawing.Color.White;
            this.cmbGBVisualStyle.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cmbGBVisualStyle.Location = new System.Drawing.Point(159, 69);
            this.cmbGBVisualStyle.Name = "cmbGBVisualStyle";
            this.cmbGBVisualStyle.Size = new System.Drawing.Size(135, 21);
            this.cmbGBVisualStyle.TabIndex = 140;
            this.cmbGBVisualStyle.Text = "Office2019Colorful";
            this.cmbGBVisualStyle.SelectedIndexChanged += new System.EventHandler(this.GBVisualStyleComboBox_SelectedIndexChanged);
            // 
            // smallImageList
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.smallImageList, "SmallImageList", 15);
#else
            this.smallImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallImageList.ImageStream")));
#endif
            this.smallImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.smallImageList.Images.SetKeyName(0, "");
            this.smallImageList.Images.SetKeyName(1, "");
            this.smallImageList.Images.SetKeyName(2, "");
            this.smallImageList.Images.SetKeyName(3, "");
            this.smallImageList.Images.SetKeyName(4, "");
            this.smallImageList.Images.SetKeyName(5, "");
            this.smallImageList.Images.SetKeyName(6, "");
            this.smallImageList.Images.SetKeyName(7, "");
            this.smallImageList.Images.SetKeyName(8, "");
            this.smallImageList.Images.SetKeyName(9, "");
            this.smallImageList.Images.SetKeyName(10, "");
            this.smallImageList.Images.SetKeyName(11, "");
            this.smallImageList.Images.SetKeyName(12, "");
            this.smallImageList.Images.SetKeyName(13, "");
            this.smallImageList.Images.SetKeyName(14, "");
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(50, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Tasks";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Left;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.ImageIndex = 10;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 30);
            this.label13.TabIndex = 4;
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.comboBoxAdv1.Location = new System.Drawing.Point(112, 184);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(82, 21);
            this.comboBoxAdv1.TabIndex = 16;
            this.comboBoxAdv1.ThemeName = "Metro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 551);
            this.Controls.Add(this.splitContainerAdv1);
#if NET6_0_OR_GREATER
            float scaleFactor = this.DeviceDpi / 96f; 
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F / scaleFactor, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
#else
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
#endif
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(740, 545);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Getting Started";
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbVisualStudio)).EndInit();
            this.gbVisualStudio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTextAlignment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGBBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGBVisualStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.GroupView GeneralGroupView;
        private System.Windows.Forms.ImageList ilGroupBarLarge;
        private System.Windows.Forms.ImageList ilGroupBarSmall;
        private Syncfusion.Windows.Forms.Tools.GroupView WinFormsGroupView;
        private Syncfusion.Windows.Forms.Tools.GroupView ComponentsGroupView;
        private Syncfusion.Windows.Forms.Tools.GroupBar gbVisualStudio;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem WinFormsGroupBarItem;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem ComponentsGroupBarItem;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem GeneralGroupBarItem;
        private System.Windows.Forms.Label label1;
        private SfComboBox cmbGBBorder;
        private System.Windows.Forms.Label label2;
        private SfComboBox cmbGBVisualStyle;
        private SfComboBox cmbTextAlignment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ImageList smallImageList;
        private System.Windows.Forms.ToolTip toolTip1;
        private Syncfusion.Windows.Forms.Tools.SplitContainerAdv splitContainerAdv1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private SfComboBox comboBoxAdv1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv7;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv9;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv3;
        private System.Windows.Forms.Label label4;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDown1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv1;
    }
}

