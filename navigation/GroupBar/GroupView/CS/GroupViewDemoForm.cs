#region Copyright Syncfusion Inc. 2001 - 2014
//
//  Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

namespace GroupViewDemo
{
    using System;
    using System.Drawing;
    using System.Collections;
    using System.ComponentModel;
    using System.Windows.Forms;
    using System.Data;
    using System.Diagnostics;
    using Syncfusion.Windows.Forms.Tools;
    using Syncfusion.Windows.Forms.Tools.XPMenus;
    using Syncfusion.Windows.Forms;
    using System.IO;
    using System.Runtime.InteropServices;
    using Syncfusion.Licensing;
    using Syncfusion.WinForms.Controls;
    using Syncfusion.WinForms.ListView;
    using System.Collections.Generic;

    public class GroupViewDemoForm : SfForm
    {
        #region Private Members
        private System.Windows.Forms.ImageList ilGroupBarSmall;
        private System.Windows.Forms.ImageList ilGroupBarLarge;
        private System.Windows.Forms.ImageList imageList;
        private GroupView gvMain;
        private CheckBoxAdv cbHighightText;
        private NumericUpDownExt nUDTextSpacing;
        private Label label12;
        private NumericUpDownExt numericUpDownExt1;
        private Label label19;
        private CheckBoxAdv cbIntegratedScrolling;
        private Label label20;
        private SfComboBox cmbOrientation;
        private SfComboBox cmbStyle;
        private Label label41;
        private CheckBoxAdv cbHighlightImage;
        private SplitContainerAdv splitContainerAdv1;
        private GradientPanel gradientPanel1;
        private GradientPanel gradientPanel3;
        private GroupBar groupBar1;
        private GroupView groupView1;
        private GroupView groupView4;
        private GroupView groupView3;
        private GroupView groupView2;
        private GroupBarItem groupBarItem1;
        private GroupBarItem groupBarItem2;
        private GroupBarItem groupBarItem3;
        private GroupBarItem groupBarItem4;
        private GroupBarItem groupBarItem5;
        private System.ComponentModel.IContainer components = null;
        [DllImport("user32.dll")]
        static extern bool LockWindowUpdate(IntPtr hWndLock);

        #endregion

        #region Form's Constructor, Main And Dispose
        public GroupViewDemoForm()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            this.cbHighightText.Checked = true;
            this.cbHighlightImage.Checked = true;
            this.cbIntegratedScrolling.Checked = !gvMain.IntegratedScrolling;
            this.numericUpDownExt1.Value = this.gvMain.ImageSpacing;
            this.nUDTextSpacing.Value = this.gvMain.TextSpacing;
            SkinManager.SetVisualStyle(this, "Office2019Colorful");
            this.numericUpDownExt1.ThemeStyle.Font = new Font("Microsoft San serif", 8.25F);
            this.nUDTextSpacing.ThemeStyle.Font = new Font("Microsoft San serif", 8.25F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            this.label19.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            this.label20.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            this.label41.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            this.splitContainerAdv1.ThemeName = "None";
            this.gradientPanel3.ThemeStyle.BackColor = Color.White;
            InitialSettingForGroupBar();
            PopulateComboBox();
            this.cmbOrientation.SelectedIndex = 1;
            this.cmbStyle.SelectedIndex = 0;
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.nUDTextSpacing.Location = new Point((this.label12.Width + this.label12.Location.X + 20), this.label12.Location.Y);
                this.numericUpDownExt1.Location = new Point((this.label12.Width + this.label12.Location.X + 20), this.label19.Location.Y);
                this.cmbOrientation.Location = new Point((this.label12.Width + this.label12.Location.X + 20), this.label20.Location.Y);
                this.cmbOrientation.Height = this.label20.Height;
                this.cmbStyle.Location = new Point((this.label12.Width + this.label12.Location.X + 20), this.label41.Location.Y);
                this.cmbStyle.Height = this.label41.Height;
                this.groupBar1.GroupBarItemHeight = (int)DpiAware.LogicalToDeviceUnits(this.groupBar1.GroupBarItemHeight);
            }
        }
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            SkinManager.LoadAssembly(typeof(Syncfusion.WinForms.Themes.Office2019Theme).Assembly);
            SkinManager.LoadAssembly(typeof(Syncfusion.WinForms.Themes.Office2016Theme).Assembly);
            SkinManager.LoadAssembly(typeof(Syncfusion.HighContrastTheme.WinForms.HighContrastTheme).Assembly);
            Application.EnableVisualStyles();
            Application.Run(new GroupViewDemoForm());
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        #endregion

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
                string imagePath = ($"GroupViewDemo.Images.{folder}.Image_{i}.png");
                imageList.Images.Add(GetImage(imagePath));
            }
        }
#endif

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupViewDemoForm));
            this.ilGroupBarLarge = new System.Windows.Forms.ImageList(this.components);
            this.ilGroupBarSmall = new System.Windows.Forms.ImageList(this.components);
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.gvMain = new Syncfusion.Windows.Forms.Tools.GroupView();
            this.cbIntegratedScrolling = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.cbHighlightImage = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbOrientation = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cmbStyle = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nUDTextSpacing = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.cbHighightText = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.numericUpDownExt1 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.label19 = new System.Windows.Forms.Label();
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.groupBar1 = new Syncfusion.Windows.Forms.Tools.GroupBar();
            this.groupView1 = new Syncfusion.Windows.Forms.Tools.GroupView();
            this.groupView4 = new Syncfusion.Windows.Forms.Tools.GroupView();
            this.groupView2 = new Syncfusion.Windows.Forms.Tools.GroupView();
            this.groupView3 = new Syncfusion.Windows.Forms.Tools.GroupView();
            this.groupBarItem1 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem2 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem3 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem4 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem5 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.cbIntegratedScrolling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHighlightImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOrientation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDTextSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHighightText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).BeginInit();
            this.groupBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).BeginInit();
            this.gradientPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ilGroupBarLarge
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.ilGroupBarLarge, "IlGroupBarLarge", 19);
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
            // 
            // ilGroupBarSmall
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.ilGroupBarSmall, "IlGroupBarSmall", 21);
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
            // 
            // imageList
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.imageList, "ImageList", 10);
#else
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
#endif
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "palette.png");
            this.imageList.Images.SetKeyName(1, "font.png");
            this.imageList.Images.SetKeyName(2, "photo_scenery.png");
            this.imageList.Images.SetKeyName(3, "windows.png");
            this.imageList.Images.SetKeyName(4, "note_pinned.png");
            this.imageList.Images.SetKeyName(5, "about.png");
            this.imageList.Images.SetKeyName(6, "element_into_input.png");
            this.imageList.Images.SetKeyName(7, "window_sidebar.png");
            this.imageList.Images.SetKeyName(8, "transform2.png");
            this.imageList.Images.SetKeyName(9, "modem_earth.png");
            // 
            // gvMain
            // 
            this.gvMain.AllowDragDrop = true;
            this.gvMain.BeforeTouchSize = new System.Drawing.Size(419, 0);
            this.gvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvMain.ForeColor = System.Drawing.Color.Black;
            this.gvMain.GroupViewItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupViewItem[] {
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("3 Floppy Drive", 0, true, null, "3 Floppy Drive"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("5 Floppy Drive", 1, true, null, "5 Floppy Drive"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Audio Disc", 2, true, null, "Audio Disc"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("CD Drive", 3, true, null, "CD Drive"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Closed Folders", 4, true, null, "Closed Folders"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Control Panel", 5, true, null, "Control Panel"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Desktop", 6, true, null, "Desktop"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Disconnected Drives", 7, true, null, "Disconnected Drives"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Network Drives", 8, true, null, "Network Drives"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Entire Network", 9, true, null, "Entire Network"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Explorer", 10, true, null, "Explorer"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("My Computer", 11, true, null, "My Computer"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Net Hood", 12, true, null, "Net Hood"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Open Folders", 13, true, null, "Open Folders"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Shared Folders", 14, true, null, "Shared Folders"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Recycle Full", 15, true, null, "Recycle Full"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Recycle Bin", 16, true, null, "Recycle Bin")});
            this.gvMain.HighlightImageOffset = new System.Drawing.Point(-2, -2);
            this.gvMain.HighlightText = false;
            this.gvMain.HighlightTextColor = System.Drawing.Color.Brown;
            this.gvMain.ImageSpacing = 6;
            this.gvMain.IntegratedScrolling = true;
            this.gvMain.LargeImageList = this.ilGroupBarLarge;
            this.gvMain.Location = new System.Drawing.Point(2, 24);
            this.gvMain.Name = "gvMain";
            this.gvMain.SelectedTextColor = System.Drawing.Color.SaddleBrown;
            this.gvMain.Size = new System.Drawing.Size(411, 0);
            this.gvMain.SmallImageList = this.ilGroupBarSmall;
            this.gvMain.SmallImageView = true;
            this.gvMain.TabIndex = 8;
            // 
            // cbIntegratedScrolling
            // 
            this.cbIntegratedScrolling.AutoSize = true;
            this.cbIntegratedScrolling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbIntegratedScrolling.BeforeTouchSize = new System.Drawing.Size(113, 16);
            this.cbIntegratedScrolling.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.cbIntegratedScrolling.DrawFocusRectangle = false;
            this.cbIntegratedScrolling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cbIntegratedScrolling.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbIntegratedScrolling.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.cbIntegratedScrolling.Location = new System.Drawing.Point(73, 245);
            this.cbIntegratedScrolling.MetroColor = System.Drawing.Color.Gray;
            this.cbIntegratedScrolling.Name = "cbIntegratedScrolling";
            this.cbIntegratedScrolling.Size = new System.Drawing.Size(113, 16);
            this.cbIntegratedScrolling.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.cbIntegratedScrolling.TabIndex = 165;
            this.cbIntegratedScrolling.Text = "Integrated Scrolling";
            this.cbIntegratedScrolling.ThemeName = "Office2016Colorful";
            this.cbIntegratedScrolling.CheckedChanged += new System.EventHandler(this.cbIntegratedScrolling_CheckedChanged);
            // 
            // cbHighlightImage
            // 
            this.cbHighlightImage.AutoSize = true;
            this.cbHighlightImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbHighlightImage.BeforeTouchSize = new System.Drawing.Size(95, 16);
            this.cbHighlightImage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.cbHighlightImage.DrawFocusRectangle = false;
            this.cbHighlightImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cbHighlightImage.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbHighlightImage.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.cbHighlightImage.Location = new System.Drawing.Point(73, 284);
            this.cbHighlightImage.MetroColor = System.Drawing.Color.Gray;
            this.cbHighlightImage.Name = "cbHighlightImage";
            this.cbHighlightImage.Size = new System.Drawing.Size(95, 16);
            this.cbHighlightImage.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.cbHighlightImage.TabIndex = 188;
            this.cbHighlightImage.Text = "Highlight Image";
            this.cbHighlightImage.ThemeName = "Office2016Colorful";
            this.cbHighlightImage.CheckedChanged += new System.EventHandler(this.cbHighlightImage_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(73, 167);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 13);
            this.label20.TabIndex = 169;
            this.label20.Text = "Orientation";
            // 
            // cmbOrientation
            // 
            this.cmbOrientation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbOrientation.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrientation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.cmbOrientation.Location = new System.Drawing.Point(170, 161);
            this.cmbOrientation.Name = "cmbOrientation";
            this.cmbOrientation.Size = new System.Drawing.Size(143, 21);
            this.cmbOrientation.Style.EditorStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbOrientation.Style.EditorStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrientation.Style.EditorStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.cmbOrientation.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrientation.TabIndex = 170;
            this.cmbOrientation.Text = "Horizontal";
            this.cmbOrientation.ThemeName = "Office2016Colorful";
            this.cmbOrientation.SelectedIndexChanged += new System.EventHandler(this.cmbOrientation_SelectedIndexChanged);
            // 
            // cmbStyle
            // 
            this.cmbStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.cmbStyle.Location = new System.Drawing.Point(170, 198);
            this.cmbStyle.Name = "cmbStyle";
            this.cmbStyle.Size = new System.Drawing.Size(143, 21);
            this.cmbStyle.Style.EditorStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbStyle.Style.EditorStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStyle.Style.EditorStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.cmbStyle.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStyle.TabIndex = 190;
            this.cmbStyle.Text = "Office2019Colorful";
            this.cmbStyle.ThemeName = "Office2016Colorful";
            this.cmbStyle.SelectedIndexChanged += new System.EventHandler(this.cmbStyle_SelectedIndexChanged);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.ForeColor = System.Drawing.Color.Black;
            this.label41.Location = new System.Drawing.Point(73, 201);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(30, 13);
            this.label41.TabIndex = 191;
            this.label41.Text = "Style";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label12.Location = new System.Drawing.Point(73, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 171;
            this.label12.Text = "Text Spacing";
            // 
            // nUDTextSpacing
            // 
            this.nUDTextSpacing.BeforeTouchSize = new System.Drawing.Size(143, 20);
            this.nUDTextSpacing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nUDTextSpacing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.nUDTextSpacing.Location = new System.Drawing.Point(170, 91);
            this.nUDTextSpacing.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nUDTextSpacing.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nUDTextSpacing.Name = "nUDTextSpacing";
            this.nUDTextSpacing.Size = new System.Drawing.Size(143, 20);
            this.nUDTextSpacing.TabIndex = 172;
            this.nUDTextSpacing.ThemeName = "Office2016Colorful";
            this.nUDTextSpacing.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nUDTextSpacing.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.nUDTextSpacing.ValueChanged += new System.EventHandler(this.nUDTextSpacing_ValueChanged);
            // 
            // cbHighightText
            // 
            this.cbHighightText.AutoSize = true;
            this.cbHighightText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbHighightText.BeforeTouchSize = new System.Drawing.Size(85, 16);
            this.cbHighightText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.cbHighightText.DrawFocusRectangle = false;
            this.cbHighightText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cbHighightText.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbHighightText.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.cbHighightText.Location = new System.Drawing.Point(73, 323);
            this.cbHighightText.MetroColor = System.Drawing.Color.Gray;
            this.cbHighightText.Name = "cbHighightText";
            this.cbHighightText.Size = new System.Drawing.Size(85, 16);
            this.cbHighightText.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.cbHighightText.TabIndex = 162;
            this.cbHighightText.Text = "Highlight Text";
            this.cbHighightText.ThemeName = "Office2016Colorful";
            this.cbHighightText.CheckedChanged += new System.EventHandler(this.cbHighightText_CheckedChanged);
            // 
            // numericUpDownExt1
            // 
            this.numericUpDownExt1.BeforeTouchSize = new System.Drawing.Size(143, 20);
            this.numericUpDownExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.numericUpDownExt1.Location = new System.Drawing.Point(170, 126);
            this.numericUpDownExt1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownExt1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.numericUpDownExt1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownExt1.Name = "numericUpDownExt1";
            this.numericUpDownExt1.Size = new System.Drawing.Size(143, 20);
            this.numericUpDownExt1.TabIndex = 168;
            this.numericUpDownExt1.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownExt1.ValueChanged += new System.EventHandler(this.numericUpDownExt1_ValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(73, 131);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 13);
            this.label19.TabIndex = 167;
            this.label19.Text = "Image Spacing";
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.BeforeTouchSize = 8;
            this.splitContainerAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAdv1.IsSplitterFixed = true;
            this.splitContainerAdv1.Location = new System.Drawing.Point(10, 10);
            this.splitContainerAdv1.Margin = new System.Windows.Forms.Padding(10);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.Controls.Add(this.gradientPanel1);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            this.splitContainerAdv1.Panel2.Controls.Add(this.gradientPanel3);
            this.splitContainerAdv1.Size = new System.Drawing.Size(848, 494);
            this.splitContainerAdv1.SplitterDistance = 421;
            this.splitContainerAdv1.SplitterWidth = 8;
            this.splitContainerAdv1.TabIndex = 205;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            this.splitContainerAdv1.ThemeName = "None";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel1.Controls.Add(this.groupBar1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(421, 494);
            this.gradientPanel1.TabIndex = 0;
            // 
            // groupBar1
            // 
            this.groupBar1.AllowDrop = true;
            this.groupBar1.BeforeTouchSize = new System.Drawing.Size(421, 494);
            this.groupBar1.BorderColor = System.Drawing.Color.White;
            this.groupBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupBar1.Controls.Add(this.groupView1);
            this.groupBar1.Controls.Add(this.groupView4);
            this.groupBar1.Controls.Add(this.groupView2);
            this.groupBar1.Controls.Add(this.groupView3);
            this.groupBar1.Controls.Add(this.gvMain);
            this.groupBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBar1.ExpandButtonToolTip = null;
            this.groupBar1.FlatLook = true;
            this.groupBar1.GroupBarDropDownToolTip = null;
            this.groupBar1.GroupBarItemHeight = 26;
            this.groupBar1.GroupBarItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupBarItem[] {
            this.groupBarItem1,
            this.groupBarItem2,
            this.groupBarItem3,
            this.groupBarItem4,
            this.groupBarItem5});
            this.groupBar1.IndexOnVisibleItems = true;
            this.groupBar1.Location = new System.Drawing.Point(0, 0);
            this.groupBar1.MinimizeButtonToolTip = null;
            this.groupBar1.Name = "groupBar1";
            this.groupBar1.NavigationPaneTooltip = null;
            this.groupBar1.PopupClientSize = new System.Drawing.Size(0, 0);
            this.groupBar1.SelectedItem = 1;
            this.groupBar1.Size = new System.Drawing.Size(421, 494);
            this.groupBar1.SmartSizeBox = false;
            this.groupBar1.Splittercolor = System.Drawing.SystemColors.ControlDark;
            this.groupBar1.TabIndex = 9;
            this.groupBar1.Text = "groupBar1";
            // 
            // groupView1
            // 
            this.groupView1.AllowDragDrop = true;
            this.groupView1.BeforeTouchSize = new System.Drawing.Size(419, 362);
            this.groupView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupView1.ForeColor = System.Drawing.Color.Black;
            this.groupView1.GroupViewItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupViewItem[] {
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("3 Floppy Drive", 0, true, null, "3 Floppy Drive"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("5 Floppy Drive", 1, true, null, "5 Floppy Drive"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Audio Disc", 2, true, null, "Audio Disc"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("CD Drive", 3, true, null, "CD Drive"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Closed Folders", 4, true, null, "Closed Folders"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Control Panel", 5, true, null, "Control Panel"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Desktop", 6, true, null, "Desktop"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Disconnected Drives", 7, true, null, "Disconnected Drives"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Network Drives", 8, true, null, "Network Drives"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Entire Network", 9, true, null, "Entire Network"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Explorer", 10, true, null, "Explorer"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("My Computer", 11, true, null, "My Computer"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Net Hood", 12, true, null, "Net Hood"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Open Folders", 13, true, null, "Open Folders"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Shared Folders", 14, true, null, "Shared Folders"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Recycle Full", 15, true, null, "Recycle Full"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Recycle Bin", 16, true, null, "Recycle Bin")});
            this.groupView1.HighlightImageOffset = new System.Drawing.Point(-2, -2);
            this.groupView1.HighlightTextColor = System.Drawing.Color.Brown;
            this.groupView1.ImageSpacing = 6;
            this.groupView1.IntegratedScrolling = true;
            this.groupView1.LargeImageList = this.ilGroupBarLarge;
            this.groupView1.Location = new System.Drawing.Point(1, 45);
            this.groupView1.Name = "groupView1";
            this.groupView1.SelectedItem = 3;
            this.groupView1.SelectedTextColor = System.Drawing.Color.SaddleBrown;
            this.groupView1.Size = new System.Drawing.Size(419, 382);
            this.groupView1.SmallImageList = this.ilGroupBarSmall;
            this.groupView1.SmallImageView = true;
            this.groupView1.TabIndex = 9;
            // 
            // groupView4
            // 
            this.groupView4.AllowDragDrop = true;
            this.groupView4.BeforeTouchSize = new System.Drawing.Size(218, 1);
            this.groupView4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupView4.ForeColor = System.Drawing.Color.Black;
            this.groupView4.GroupViewItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupViewItem[] {
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("3 Floppy Drive", 0, true, null, "3 Floppy Drive"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("5 Floppy Drive", 1, true, null, "5 Floppy Drive"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Audio Disc", 2, true, null, "Audio Disc"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("CD Drive", 3, true, null, "CD Drive"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Closed Folders", 4, true, null, "Closed Folders"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Control Panel", 5, true, null, "Control Panel"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Desktop", 6, true, null, "Desktop"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Disconnected Drives", 7, true, null, "Disconnected Drives"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Network Drives", 8, true, null, "Network Drives"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Entire Network", 9, true, null, "Entire Network"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Explorer", 10, true, null, "Explorer"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("My Computer", 11, true, null, "My Computer"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Net Hood", 12, true, null, "Net Hood"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Open Folders", 13, true, null, "Open Folders"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Shared Folders", 14, true, null, "Shared Folders"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Recycle Full", 15, true, null, "Recycle Full"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Recycle Bin", 16, true, null, "Recycle Bin")});
            this.groupView4.HighlightImageOffset = new System.Drawing.Point(-2, -2);
            this.groupView4.HighlightTextColor = System.Drawing.Color.Brown;
            this.groupView4.ImageSpacing = 6;
            this.groupView4.IntegratedScrolling = true;
            this.groupView4.LargeImageList = this.ilGroupBarLarge;
            this.groupView4.Location = new System.Drawing.Point(1, 299);
            this.groupView4.Name = "groupView4";
            this.groupView4.SelectedTextColor = System.Drawing.Color.SaddleBrown;
            this.groupView4.Size = new System.Drawing.Size(218, 1);
            this.groupView4.SmallImageList = this.ilGroupBarSmall;
            this.groupView4.SmallImageView = true;
            this.groupView4.TabIndex = 12;
            // 
            // groupView2
            // 
            this.groupView2.AllowDragDrop = true;
            this.groupView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupView2.BeforeTouchSize = new System.Drawing.Size(413, 0);
            this.groupView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupView2.ForeColor = System.Drawing.Color.Black;
            this.groupView2.GroupViewItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupViewItem[] {
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("3 Floppy Drive", 0, true, null, "3 Floppy Drive"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("5 Floppy Drive", 1, true, null, "5 Floppy Drive"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Audio Disc", 2, true, null, "Audio Disc"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("CD Drive", 3, true, null, "CD Drive"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Closed Folders", 4, true, null, "Closed Folders"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Control Panel", 5, true, null, "Control Panel"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Desktop", 6, true, null, "Desktop"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Disconnected Drives", 7, true, null, "Disconnected Drives"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Network Drives", 8, true, null, "Network Drives"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Entire Network", 9, true, null, "Entire Network"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Explorer", 10, true, null, "Explorer"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("My Computer", 11, true, null, "My Computer"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Net Hood", 12, true, null, "Net Hood"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Open Folders", 13, true, null, "Open Folders"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Shared Folders", 14, true, null, "Shared Folders"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Recycle Full", 15, true, null, "Recycle Full"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Recycle Bin", 16, true, null, "Recycle Bin")});
            this.groupView2.HighlightImageOffset = new System.Drawing.Point(-2, -2);
            this.groupView2.HighlightText = false;
            this.groupView2.HighlightTextColor = System.Drawing.Color.Brown;
            this.groupView2.ImageSpacing = 6;
            this.groupView2.IntegratedScrolling = true;
            this.groupView2.LargeImageList = this.ilGroupBarLarge;
            this.groupView2.Location = new System.Drawing.Point(1, 411);
            this.groupView2.Name = "groupView2";
            this.groupView2.SelectedTextColor = System.Drawing.Color.SaddleBrown;
            this.groupView2.Size = new System.Drawing.Size(413, 0);
            this.groupView2.SmallImageList = this.ilGroupBarSmall;
            this.groupView2.SmallImageView = true;
            this.groupView2.TabIndex = 10;
            // 
            // groupView3
            // 
            this.groupView3.AllowDragDrop = true;
            this.groupView3.BeforeTouchSize = new System.Drawing.Size(413, 0);
            this.groupView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupView3.ForeColor = System.Drawing.Color.Black;
            this.groupView3.GroupViewItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupViewItem[] {
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("3 Floppy Drive", 0, true, null, "3 Floppy Drive"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("5 Floppy Drive", 1, true, null, "5 Floppy Drive"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Audio Disc", 2, true, null, "Audio Disc"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("CD Drive", 3, true, null, "CD Drive"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Closed Folders", 4, true, null, "Closed Folders"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Control Panel", 5, true, null, "Control Panel"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Desktop", 6, true, null, "Desktop"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Disconnected Drives", 7, true, null, "Disconnected Drives"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Network Drives", 8, true, null, "Network Drives"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Entire Network", 9, true, null, "Entire Network"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Explorer", 10, true, null, "Explorer"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("My Computer", 11, true, null, "My Computer"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Net Hood", 12, true, null, "Net Hood"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Open Folders", 13, true, null, "Open Folders"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Shared Folders", 14, true, null, "Shared Folders"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Recycle Full", 15, true, null, "Recycle Full"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Recycle Bin", 16, true, null, "Recycle Bin")});
            this.groupView3.HighlightImageOffset = new System.Drawing.Point(-2, -2);
            this.groupView3.HighlightTextColor = System.Drawing.Color.Brown;
            this.groupView3.ImageSpacing = 6;
            this.groupView3.IntegratedScrolling = true;
            this.groupView3.LargeImageList = this.ilGroupBarLarge;
            this.groupView3.Location = new System.Drawing.Point(1, 433);
            this.groupView3.Name = "groupView3";
            this.groupView3.SelectedTextColor = System.Drawing.Color.SaddleBrown;
            this.groupView3.Size = new System.Drawing.Size(413, 0);
            this.groupView3.SmallImageList = this.ilGroupBarSmall;
            this.groupView3.SmallImageView = true;
            this.groupView3.TabIndex = 11;
            // 
            // groupBarItem1
            // 
            this.groupBarItem1.Client = this.gvMain;
            this.groupBarItem1.Text = "Button View";
            // 
            // groupBarItem2
            // 
            this.groupBarItem2.Client = this.groupView1;
            this.groupBarItem2.Text = "List View";
            // 
            // groupBarItem3
            // 
            this.groupBarItem3.Client = this.groupView2;
            this.groupBarItem3.Text = "Large Icon View";
            // 
            // groupBarItem4
            // 
            this.groupBarItem4.Client = this.groupView3;
            this.groupBarItem4.Text = "Small Icon View";
            // 
            // groupBarItem5
            // 
            this.groupBarItem5.Client = this.groupView4;
            this.groupBarItem5.Text = "Flow View";
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel3.Controls.Add(this.numericUpDownExt1);
            this.gradientPanel3.Controls.Add(this.cbIntegratedScrolling);
            this.gradientPanel3.Controls.Add(this.cbHighlightImage);
            this.gradientPanel3.Controls.Add(this.label20);
            this.gradientPanel3.Controls.Add(this.label12);
            this.gradientPanel3.Controls.Add(this.cbHighightText);
            this.gradientPanel3.Controls.Add(this.label41);
            this.gradientPanel3.Controls.Add(this.cmbStyle);
            this.gradientPanel3.Controls.Add(this.nUDTextSpacing);
            this.gradientPanel3.Controls.Add(this.label19);
            this.gradientPanel3.Controls.Add(this.cmbOrientation);
            this.gradientPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel3.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(419, 494);
            this.gradientPanel3.TabIndex = 0;
            // 
            // GroupViewDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(868, 514);
            this.Controls.Add(this.splitContainerAdv1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GroupViewDemoForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Style.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Text = "GroupView";
            ((System.ComponentModel.ISupportInitialize)(this.cbIntegratedScrolling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHighlightImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOrientation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDTextSpacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHighightText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt1)).EndInit();
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).EndInit();
            this.groupBar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).EndInit();
            this.gradientPanel3.ResumeLayout(false);
            this.gradientPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

    
        #endregion

        #region GroupView

        #region Groupview properties

        /// <summary>
        /// GroupView Style
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.gradientPanel3.BorderStyle = BorderStyle.FixedSingle;

            if (this.cmbStyle.SelectedIndex == 0)
            {
                SkinManager.SetVisualStyle(this, "Office2019Colorful");
                this.BackColor = System.Drawing.Color.White;
                this.ForeColor = ColorTranslator.FromHtml("#262626");
                this.Style.TitleBar.BackColor = System.Drawing.Color.FromArgb(242, 242, 242);
                this.Style.TitleBar.ForeColor = ColorTranslator.FromHtml("#343434");
                this.Style.TitleBar.CloseButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.MinimizeButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.MaximizeButtonForeColor = Color.FromArgb(51, 51, 51);
                this.label12.ForeColor = System.Drawing.Color.FromArgb(68,68,68);
                this.label19.ForeColor = System.Drawing.Color.FromArgb(68,68,68);
                this.label20.ForeColor = System.Drawing.Color.FromArgb(68,68,68);
                this.label41.ForeColor = System.Drawing.Color.FromArgb(68,68,68);
                this.gradientPanel3.BorderStyle = BorderStyle.None;
                this.gradientPanel3.ThemeStyle.BorderColor = Color.FromArgb(210, 210, 210);
                this.gradientPanel3.ThemeStyle.BackColor = ColorTranslator.FromHtml("#ffffff");
            }
            else if (this.cmbStyle.SelectedIndex == 1)
            {
                SkinManager.SetVisualStyle(this, "HighContrastBlack");
                this.BackColor = ColorTranslator.FromHtml("#262626");
                this.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Style.TitleBar.BackColor = ColorTranslator.FromHtml("#363636");
                this.Style.TitleBar.CloseButtonForeColor = Color.White;
                this.Style.TitleBar.MinimizeButtonForeColor = Color.White;
                this.Style.TitleBar.MaximizeButtonForeColor = Color.White;
                this.Style.TitleBar.ForeColor = Color.White;
                this.label12.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label19.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label20.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label41.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.gradientPanel3.ThemeStyle.BackColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel3.ThemeStyle.BorderColor = Color.White;
            }
            else if (this.cmbStyle.SelectedIndex == 2)
            {
                SkinManager.SetVisualStyle(this, "Office2016Colorful");
                this.Style.TitleBar.BackColor = System.Drawing.Color.FromArgb(242, 242, 242);
                this.Style.TitleBar.ForeColor = ColorTranslator.FromHtml("#343434");
                this.Style.TitleBar.CloseButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.MinimizeButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.MaximizeButtonForeColor = Color.FromArgb(51, 51, 51);
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label12.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label19.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label20.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label41.ForeColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel3.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.gradientPanel3.BorderColor = ColorTranslator.FromHtml("#c5c5c5");

            }
            else if (this.cmbStyle.SelectedIndex == 3)
            {
                SkinManager.SetVisualStyle(this, "Office2016White");
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.ForeColor = ColorTranslator.FromHtml("#262626");
                this.Style.TitleBar.BackColor = System.Drawing.Color.FromArgb(242, 242, 242);
                this.Style.TitleBar.ForeColor = ColorTranslator.FromHtml("#343434");
                this.label12.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label19.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label20.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label41.ForeColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel3.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.gradientPanel3.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
            }
            else if (this.cmbStyle.SelectedIndex == 4)
            {
                SkinManager.SetVisualStyle(this, "Office2016DarkGray");
                this.BackColor = ColorTranslator.FromHtml("#666666");
                this.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Style.TitleBar.BackColor = ColorTranslator.FromHtml("#505050");
                this.Style.TitleBar.CloseButtonForeColor = Color.White;
                this.Style.TitleBar.MinimizeButtonForeColor = Color.White;
                this.Style.TitleBar.MaximizeButtonForeColor = Color.White;
                this.Style.TitleBar.ForeColor = Color.White;
                this.label12.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label19.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label20.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label41.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.gradientPanel3.BackColor = ColorTranslator.FromHtml("#666666");
                this.gradientPanel3.BorderColor = ColorTranslator.FromHtml("#444444");
            }
            else if (this.cmbStyle.SelectedIndex == 5)
            {
                SkinManager.SetVisualStyle(this, "Office2016Black");
                this.BackColor = ColorTranslator.FromHtml("#262626");
                this.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Style.TitleBar.BackColor = ColorTranslator.FromHtml("#363636");
                this.Style.TitleBar.CloseButtonForeColor = Color.White;
                this.Style.TitleBar.MinimizeButtonForeColor = Color.White;
                this.Style.TitleBar.MaximizeButtonForeColor = Color.White;
                this.Style.TitleBar.ForeColor = Color.White;
                this.label12.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label19.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label20.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label41.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.gradientPanel3.BackColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel3.BorderColor = ColorTranslator.FromHtml("#363636");
            }
            this.splitContainerAdv1.ThemeName = "None";
            this.groupBar1.Refresh();
        }

        private void cbHighightText_CheckedChanged(object sender, EventArgs e)
        {
            this.gvMain.HighlightText = cbHighightText.Checked;
            this.groupView4.HighlightText = cbHighightText.Checked;
            this.groupView3.HighlightText = cbHighightText.Checked;
            this.groupView2.HighlightText = cbHighightText.Checked;
            this.groupView1.HighlightText = cbHighightText.Checked;
        }

        private void nUDTextSpacing_ValueChanged(object sender, EventArgs e)
        {
            this.gvMain.TextSpacing = (int)this.nUDTextSpacing.Value;
            this.groupView1.TextSpacing = (int)this.nUDTextSpacing.Value;
            this.groupView2.TextSpacing = (int)this.nUDTextSpacing.Value;
            this.groupView3.TextSpacing = (int)this.nUDTextSpacing.Value;
            this.groupView4.TextSpacing = (int)this.nUDTextSpacing.Value;
        }

        private void numericUpDownExt1_ValueChanged(object sender, EventArgs e)
        {
            this.gvMain.ImageSpacing = (int)this.numericUpDownExt1.Value;
            this.groupView1.ImageSpacing = (int)this.numericUpDownExt1.Value;
            this.groupView2.ImageSpacing = (int)this.numericUpDownExt1.Value;
            this.groupView3.ImageSpacing = (int)this.numericUpDownExt1.Value;
            this.groupView4.ImageSpacing = (int)this.numericUpDownExt1.Value;
        }

        private void cbIntegratedScrolling_CheckedChanged(object sender, EventArgs e)
        {
            this.gvMain.IntegratedScrolling = !this.cbIntegratedScrolling.Checked;
            this.groupView1.IntegratedScrolling = !this.cbIntegratedScrolling.Checked;
            this.groupView2.IntegratedScrolling = !this.cbIntegratedScrolling.Checked;
            this.groupView3.IntegratedScrolling = !this.cbIntegratedScrolling.Checked;
            this.groupView4.IntegratedScrolling = !this.cbIntegratedScrolling.Checked;
        }

        private void cmbOrientation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbOrientation.SelectedIndex == 0)
            {
                this.gvMain.Orientation = GroupViewOrientation.Horizontal;
                this.groupView1.Orientation = GroupViewOrientation.Horizontal;
                this.groupView2.Orientation = GroupViewOrientation.Horizontal;
                this.groupView3.Orientation = GroupViewOrientation.Horizontal;
                this.groupView4.Orientation = GroupViewOrientation.Horizontal;
            }
            else
            {
                this.gvMain.Orientation = GroupViewOrientation.Vertical;
                this.groupView1.Orientation = GroupViewOrientation.Vertical;
                this.groupView2.Orientation = GroupViewOrientation.Vertical;
                this.groupView3.Orientation = GroupViewOrientation.Vertical;
                this.groupView4.Orientation = GroupViewOrientation.Vertical;
            }
        }

        private void cbHighlightImage_CheckedChanged(object sender, EventArgs e)
        {
            this.gvMain.HighlightImage = cbHighlightImage.Checked;
            this.groupView1.HighlightImage = cbHighlightImage.Checked;
            this.groupView2.HighlightImage = cbHighlightImage.Checked;
            this.groupView3.HighlightImage = cbHighlightImage.Checked;
            this.groupView4.HighlightImage = cbHighlightImage.Checked;
        }
        
        #endregion

        private void InitialSettingForGroupBar()
        {
            this.gvMain.SmallImageView = false;
            this.gvMain.ButtonView = true;
            this.gvMain.FlowView = false;
            this.gvMain.FlatLook = false;
            this.gvMain.ClipSelectionBounds = false;
            this.gvMain.TextWrap = true;
            this.gvMain.HighlightImageOffset = new Point(-2, -2);
            this.gvMain.SelectingImageOffset = Point.Empty;
            this.gvMain.SelectingTextOffset = Point.Empty;
            this.groupView1.SmallImageView = true;
            this.groupView1.ButtonView = true;
            this.groupView1.FlowView = false;
            this.groupView1.FlatLook = false;
            this.groupView1.ClipSelectionBounds = false;
            this.groupView1.TextWrap = false;
            this.groupView1.HighlightImageOffset = Point.Empty;
            this.groupView1.SelectingImageOffset = Point.Empty;
            this.groupView1.SelectingTextOffset = Point.Empty;
            this.groupView2.SmallImageView = false;
            this.groupView2.ButtonView = true;
            this.groupView2.FlowView = false;
            this.groupView2.FlatLook = false;
            this.groupView2.ClipSelectionBounds = true;
            this.groupView2.TextWrap = false;
            this.groupView3.SmallImageView = true;
            this.groupView3.ButtonView = true;
            this.groupView3.FlowView = false;
            this.groupView3.FlatLook = false;
            this.groupView3.ClipSelectionBounds = true;
            this.groupView3.TextWrap = false;
            this.groupView4.SmallImageView = true;
            this.groupView4.ButtonView = true;
            this.groupView4.FlowView = true;
            this.groupView4.FlatLook = false;
            this.groupView4.ClipSelectionBounds = false;
            this.groupView4.TextWrap = false;
            this.groupView4.HighlightImageOffset = Point.Empty;
            this.groupView4.SelectingImageOffset = Point.Empty;
            this.groupView4.SelectingTextOffset = Point.Empty;
        }

        private void PopulateComboBox()
        {
            List<string> orientationList = new List<string>();
            orientationList.AddRange(new string[]{ 
            "Horizontal",
            "Vertical"});
            this.cmbOrientation.DataSource = orientationList;
            this.cmbOrientation.AllowDropDownResize = false;
            this.cmbStyle.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cmbOrientation.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            List<string> styleList = new List<string> { 
            "Office2019Colorful",
            "HighContrastTheme",
            "Office2016Colorful",
            "Office2016White",
            "Office2016DarkGray",
            "Office2016Black"};
            this.cmbStyle.DataSource = styleList;
            this.cmbStyle.AllowDropDownResize = false;
        }

        #endregion

    }

    /// <summary>
    /// Represents a class that is used to find the licensing file for Syncfusion controls.
    /// </summary>
    public class DemoCommon
    {
        /// <summary>
        /// Finds the license key from the Common folder.
        /// </summary>
        /// <returns>Returns the license key.</returns>
        public static string FindLicenseKey()
        {
            string licenseKeyFile = "..\\Common\\SyncfusionLicense.txt";
            for (int n = 0; n < 20; n++)
            {
                if (!System.IO.File.Exists(licenseKeyFile))
                {
                    licenseKeyFile = @"..\" + licenseKeyFile;
                    continue;
                }
                return File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }

}
