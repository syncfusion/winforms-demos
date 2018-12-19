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

    public class GroupViewDemoForm : MetroForm
    {
        #region Private Members
        private System.Windows.Forms.ImageList ilGroupBarSmall;
        private System.Windows.Forms.ImageList ilGroupBarLarge;
        private Syncfusion.Windows.Forms.Tools.GroupView gvModes;
        public Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbLargeIcons;
        public Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbSmallIcons;
        public Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbVSNETList;
        public Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbVSNETFlow;
        public Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbOXPFolderBrowser;
        public Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbO2KFolderBrowser;
        public Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbMessengerList;
        public Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbXPTaskBar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ImageList imageList;
        private TabControlAdv tabControlAdv1;
        private TabPageAdv tabPageAdv1;
        private TabPageAdv tabPageAdv2;
        private GroupView gvMain;
        private GradientPanel gpVSBehavior;
        private Label label5;
        private ColorPickerButton cpBackColor;
        private Panel panel15;
        private Label label35;
        private CheckBoxAdv cbButtonView;
        private Label label2;
        private ComboBoxAdv cmbGVBorder;
        private CheckBoxAdv cbHighightText;
        private GradientPanel gradientPanel3;
        private Panel panel2;
        private Label label6;
        private NumericUpDownExt nUDHighlightOffset;
        private Label label11;
        private Label label10;
        private Label label9;
        private NumericUpDownExt nUDSelectedOffset;
        private NumericUpDownExt nUDSelectingOffset;
        private NumericUpDownExt nUDSelectedHighlightOffset;
        private Label label3;
        private CheckBoxAdv cbFlowView;
        private NumericUpDownExt nUDTextSpacing;
        private Label label12;
        private CheckBoxAdv cbTextUnderline;
        private CheckBoxAdv cbTextWrap;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private ColorPickerButton cpHighlightItem;
        private ColorPickerButton cpHighlightText;
        private Splitter splitter1;
        private ColorPickerButton cpselectedHlItem;
        private ColorPickerButton cpSelectedTextColor;
        private ColorPickerButton cpSelectedItemColor;
        private Label label17;
        private Label label18;
        private CheckBoxAdv cbToolTips;
        private CheckBoxAdv cbFlowViewItemText;
        private NumericUpDownExt numericUpDownExt1;
        private Label label19;
        private CheckBoxAdv cbIntegratedScrolling;
        private Label label20;
        private ComboBoxAdv cmbOrientation;
        private ComboBoxAdv cmbStyle;
        private CheckBoxAdv cbThemesEnabled;
        private TabPageAdv tabPageAdv3;
        private CustomGroupView gvFeatures;
        private Label label1;
        private GradientPanel gradientPanel5;
        private Panel panel3;
        private Label label22;
        private Label label41;
        private CheckBoxAdv cbHighlightImage;
        private GradientPanel gradientPanel6;
        private ButtonAdv button1;
        private GradientPanel gradientPanel2;
        private GradientPanelExt gradientPanelExt1;
        private Timer timer1;
        private RichTextBox richTextBox1;
        private Panel panel1;
        private ColorPickerButton cpSelectedHlText;
        private GradientPanel gradientPanel1;
        private Label label40;
        private Label label7;
        private ScrollersFrame scrollersFrame1;
        private Panel panel4;
        private Panel panel6;
        private Panel panel5;
        private Panel panel7;
        private Panel panel8;
        private GradientPanel gradientPanel4;
        private GradientPanel gradientPanel7;
        private System.ComponentModel.IContainer components = null;
        [DllImport("user32.dll")]
        static extern bool LockWindowUpdate(IntPtr hWndLock);

        #endregion

        #region Form's Constructor, Main And Dispose
        public GroupViewDemoForm()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            this.cmbOrientation.SelectedIndex = 1;
            this.cmbGVBorder.SelectedIndex = 2;
            this.rbO2KFolderBrowser.Checked = true;
            this.cbHighightText.Checked = true;
            this.cbHighlightImage.Checked = true;
            this.cbButtonView.Checked = true;
            this.cbIntegratedScrolling.Checked = true;
         
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }


            this.richTextBox1.Text = "";
            string path = Application.StartupPath.ToString() + @"..\..\..\GroupView_Features.rtf";
            if (File.Exists(path))
                this.richTextBox1.LoadFile(path, RichTextBoxStreamType.RichText);
            UpdateGroupViewStylesforOffice2016Themes();
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

        public GroupView GroupView
        {
            get { return this.gvModes; }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
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

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupViewDemoForm));
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable1 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable2 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable3 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable4 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable5 = new Syncfusion.Windows.Forms.MetroColorTable();
            this.ilGroupBarLarge = new System.Windows.Forms.ImageList(this.components);
            this.ilGroupBarSmall = new System.Windows.Forms.ImageList(this.components);
            this.gvModes = new Syncfusion.Windows.Forms.Tools.GroupView();
            this.rbXPTaskBar = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.rbMessengerList = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.rbOXPFolderBrowser = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.rbO2KFolderBrowser = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.rbVSNETFlow = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.rbVSNETList = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.rbSmallIcons = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.rbLargeIcons = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.gvMain = new Syncfusion.Windows.Forms.Tools.GroupView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gpVSBehavior = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbIntegratedScrolling = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.cbFlowViewItemText = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.cbToolTips = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.cbFlowView = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label35 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gradientPanel5 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.cpSelectedHlText = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.cbHighlightImage = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.cpSelectedTextColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label20 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cpBackColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.cbTextUnderline = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.cmbOrientation = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cmbStyle = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label41 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbTextWrap = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label12 = new System.Windows.Forms.Label();
            this.cbThemesEnabled = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.nUDTextSpacing = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.cbButtonView = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.nUDSelectedHighlightOffset = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.cbHighightText = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGVBorder = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.nUDSelectedOffset = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.numericUpDownExt1 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.nUDSelectingOffset = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.nUDHighlightOffset = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.cpHighlightText = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label11 = new System.Windows.Forms.Label();
            this.cpselectedHlItem = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cpSelectedItemColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label17 = new System.Windows.Forms.Label();
            this.cpHighlightItem = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.tabPageAdv3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.gradientPanelExt1 = new Syncfusion.Windows.Forms.Tools.GradientPanelExt();
            this.gvFeatures = new GroupViewDemo.CustomGroupView();
            this.gradientPanel6 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scrollersFrame1 = new Syncfusion.Windows.Forms.ScrollersFrame(this.components);
            this.gradientPanel7 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.rbXPTaskBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbMessengerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbOXPFolderBrowser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbO2KFolderBrowser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbVSNETFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbVSNETList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbSmallIcons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbLargeIcons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).BeginInit();
            this.gradientPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpVSBehavior)).BeginInit();
            this.gpVSBehavior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbIntegratedScrolling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFlowViewItemText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbToolTips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFlowView)).BeginInit();
            this.panel15.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel5)).BeginInit();
            this.gradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbHighlightImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTextUnderline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOrientation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTextWrap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbThemesEnabled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDTextSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbButtonView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSelectedHighlightOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHighightText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGVBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSelectedOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSelectingOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDHighlightOffset)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPageAdv2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            this.tabPageAdv3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanelExt1)).BeginInit();
            this.gradientPanelExt1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel6)).BeginInit();
            this.gradientPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).BeginInit();
            this.gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel7)).BeginInit();
            this.gradientPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // ilGroupBarLarge
            // 
            this.ilGroupBarLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilGroupBarLarge.ImageStream")));
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
            this.ilGroupBarSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilGroupBarSmall.ImageStream")));
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
            // gvModes
            // 
            this.gvModes.AllowDragDrop = true;
            this.gvModes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvModes.BeforeTouchSize = new System.Drawing.Size(168, 517);
            this.gvModes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvModes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gvModes.GroupViewItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupViewItem[] {
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
            this.gvModes.HighlightImage = false;
            this.gvModes.HighlightImageOffset = new System.Drawing.Point(-2, -2);
            this.gvModes.HighlightText = false;
            this.gvModes.LargeImageList = this.ilGroupBarLarge;
            this.gvModes.Location = new System.Drawing.Point(9, 10);
            this.gvModes.Name = "gvModes";
            this.gvModes.Size = new System.Drawing.Size(168, 517);
            this.gvModes.SmallImageList = this.ilGroupBarSmall;
            this.gvModes.SmallImageView = true;
            this.gvModes.Style = Syncfusion.Windows.Forms.Appearance.Office2016;
            this.gvModes.TabIndex = 4;
            // 
            // rbXPTaskBar
            // 
            this.rbXPTaskBar.BeforeTouchSize = new System.Drawing.Size(126, 17);
            this.rbXPTaskBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.rbXPTaskBar.DrawFocusRectangle = false;
            this.rbXPTaskBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.rbXPTaskBar.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.rbXPTaskBar.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.rbXPTaskBar.Location = new System.Drawing.Point(20, 279);
            this.rbXPTaskBar.MetroColor = System.Drawing.Color.Gray;
            this.rbXPTaskBar.Name = "rbXPTaskBar";
            this.rbXPTaskBar.Size = new System.Drawing.Size(126, 17);
            this.rbXPTaskBar.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
            this.rbXPTaskBar.TabIndex = 8;
            this.rbXPTaskBar.Text = "XP TaskBar List";
            this.rbXPTaskBar.ThemesEnabled = false;
            this.rbXPTaskBar.CheckChanged += new System.EventHandler(this.rbXPTaskBar_CheckedChanged);
            // 
            // rbMessengerList
            // 
            this.rbMessengerList.BeforeTouchSize = new System.Drawing.Size(188, 17);
            this.rbMessengerList.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.rbMessengerList.DrawFocusRectangle = false;
            this.rbMessengerList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.rbMessengerList.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.rbMessengerList.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.rbMessengerList.Location = new System.Drawing.Point(20, 240);
            this.rbMessengerList.MetroColor = System.Drawing.Color.Gray;
            this.rbMessengerList.Name = "rbMessengerList";
            this.rbMessengerList.Size = new System.Drawing.Size(188, 17);
            this.rbMessengerList.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
            this.rbMessengerList.TabIndex = 7;
            this.rbMessengerList.Text = "MSN Messenger SideBar List";
            this.rbMessengerList.ThemesEnabled = false;
            this.rbMessengerList.CheckChanged += new System.EventHandler(this.rbMessengerList_CheckedChanged);
            // 
            // rbOXPFolderBrowser
            // 
            this.rbOXPFolderBrowser.BeforeTouchSize = new System.Drawing.Size(168, 17);
            this.rbOXPFolderBrowser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.rbOXPFolderBrowser.DrawFocusRectangle = false;
            this.rbOXPFolderBrowser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.rbOXPFolderBrowser.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.rbOXPFolderBrowser.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.rbOXPFolderBrowser.Location = new System.Drawing.Point(20, 201);
            this.rbOXPFolderBrowser.MetroColor = System.Drawing.Color.Gray;
            this.rbOXPFolderBrowser.Name = "rbOXPFolderBrowser";
            this.rbOXPFolderBrowser.Size = new System.Drawing.Size(168, 17);
            this.rbOXPFolderBrowser.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
            this.rbOXPFolderBrowser.TabIndex = 6;
            this.rbOXPFolderBrowser.Text = "Office XP Folder Browser";
            this.rbOXPFolderBrowser.ThemesEnabled = false;
            this.rbOXPFolderBrowser.CheckChanged += new System.EventHandler(this.rbOXPFolderBrowser_CheckedChanged);
            // 
            // rbO2KFolderBrowser
            // 
            this.rbO2KFolderBrowser.BeforeTouchSize = new System.Drawing.Size(178, 17);
            this.rbO2KFolderBrowser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.rbO2KFolderBrowser.DrawFocusRectangle = false;
            this.rbO2KFolderBrowser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.rbO2KFolderBrowser.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.rbO2KFolderBrowser.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.rbO2KFolderBrowser.Location = new System.Drawing.Point(20, 162);
            this.rbO2KFolderBrowser.MetroColor = System.Drawing.Color.Gray;
            this.rbO2KFolderBrowser.Name = "rbO2KFolderBrowser";
            this.rbO2KFolderBrowser.Size = new System.Drawing.Size(178, 17);
            this.rbO2KFolderBrowser.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
            this.rbO2KFolderBrowser.TabIndex = 5;
            this.rbO2KFolderBrowser.Text = "Office 2000 Folder Browser";
            this.rbO2KFolderBrowser.ThemesEnabled = false;
            this.rbO2KFolderBrowser.CheckChanged += new System.EventHandler(this.rbO2KFolderBrowser_CheckedChanged);
            // 
            // rbVSNETFlow
            // 
            this.rbVSNETFlow.BeforeTouchSize = new System.Drawing.Size(181, 17);
            this.rbVSNETFlow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.rbVSNETFlow.DrawFocusRectangle = false;
            this.rbVSNETFlow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.rbVSNETFlow.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.rbVSNETFlow.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.rbVSNETFlow.Location = new System.Drawing.Point(20, 123);
            this.rbVSNETFlow.MetroColor = System.Drawing.Color.Gray;
            this.rbVSNETFlow.Name = "rbVSNETFlow";
            this.rbVSNETFlow.Size = new System.Drawing.Size(181, 17);
            this.rbVSNETFlow.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
            this.rbVSNETFlow.TabIndex = 3;
            this.rbVSNETFlow.Text = "VS.NET Toolbox Flow View";
            this.rbVSNETFlow.ThemesEnabled = false;
            this.rbVSNETFlow.CheckChanged += new System.EventHandler(this.rbVSNETFlow_CheckedChanged);
            // 
            // rbVSNETList
            // 
            this.rbVSNETList.BeforeTouchSize = new System.Drawing.Size(175, 17);
            this.rbVSNETList.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.rbVSNETList.DrawFocusRectangle = false;
            this.rbVSNETList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.rbVSNETList.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.rbVSNETList.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.rbVSNETList.Location = new System.Drawing.Point(20, 84);
            this.rbVSNETList.MetroColor = System.Drawing.Color.Gray;
            this.rbVSNETList.Name = "rbVSNETList";
            this.rbVSNETList.Size = new System.Drawing.Size(175, 17);
            this.rbVSNETList.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
            this.rbVSNETList.TabIndex = 2;
            this.rbVSNETList.Text = "VS.NET Toolbox List View";
            this.rbVSNETList.ThemesEnabled = false;
            this.rbVSNETList.CheckChanged += new System.EventHandler(this.rbVSNETList_CheckedChanged);
            // 
            // rbSmallIcons
            // 
            this.rbSmallIcons.BeforeTouchSize = new System.Drawing.Size(181, 17);
            this.rbSmallIcons.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.rbSmallIcons.DrawFocusRectangle = false;
            this.rbSmallIcons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.rbSmallIcons.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.rbSmallIcons.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.rbSmallIcons.Location = new System.Drawing.Point(20, 45);
            this.rbSmallIcons.MetroColor = System.Drawing.Color.Gray;
            this.rbSmallIcons.Name = "rbSmallIcons";
            this.rbSmallIcons.Size = new System.Drawing.Size(181, 17);
            this.rbSmallIcons.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
            this.rbSmallIcons.TabIndex = 1;
            this.rbSmallIcons.Text = "OutlookBar Small Icon View";
            this.rbSmallIcons.ThemesEnabled = false;
            this.rbSmallIcons.CheckChanged += new System.EventHandler(this.rbSmallIcons_CheckedChanged);
            // 
            // rbLargeIcons
            // 
            this.rbLargeIcons.BeforeTouchSize = new System.Drawing.Size(183, 17);
            this.rbLargeIcons.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.rbLargeIcons.DrawFocusRectangle = false;
            this.rbLargeIcons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.rbLargeIcons.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.rbLargeIcons.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.rbLargeIcons.Location = new System.Drawing.Point(20, 6);
            this.rbLargeIcons.MetroColor = System.Drawing.Color.Gray;
            this.rbLargeIcons.Name = "rbLargeIcons";
            this.rbLargeIcons.Size = new System.Drawing.Size(183, 17);
            this.rbLargeIcons.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
            this.rbLargeIcons.TabIndex = 0;
            this.rbLargeIcons.Text = "OutlookBar Large Icon View";
            this.rbLargeIcons.ThemesEnabled = false;
            this.rbLargeIcons.CheckChanged += new System.EventHandler(this.rbLargeIcons_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(4, 1);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(333, 173);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Events";
            this.columnHeader1.Width = 121;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Object";
            this.columnHeader2.Width = 145;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
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
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(1926, 1062);
            this.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabControlAdv1.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv3);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv1.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Padding = new System.Drawing.Point(15, 5);
            this.tabControlAdv1.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.tabControlAdv1.ShowSeparator = false;
            this.tabControlAdv1.Size = new System.Drawing.Size(1926, 1062);
            this.tabControlAdv1.TabIndex = 11;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Colorful);
            this.tabControlAdv1.ThemesEnabled = true;
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv1.Controls.Add(this.panel1);
            this.tabPageAdv1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(2, 27);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(918, 557);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "GroupView Properties";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.gvMain);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 535);
            this.panel1.TabIndex = 203;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(216)))), ((int)(((byte)(237)))));
            this.splitter1.Location = new System.Drawing.Point(168, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 535);
            this.splitter1.TabIndex = 200;
            this.splitter1.TabStop = false;
            // 
            // gvMain
            // 
            this.gvMain.AllowDragDrop = true;
            this.gvMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvMain.BeforeTouchSize = new System.Drawing.Size(168, 535);
            this.gvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvMain.Dock = System.Windows.Forms.DockStyle.Left;
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
            this.gvMain.Location = new System.Drawing.Point(0, 0);
            this.gvMain.Name = "gvMain";
            this.gvMain.SelectedTextColor = System.Drawing.Color.SaddleBrown;
            this.gvMain.Size = new System.Drawing.Size(168, 535);
            this.gvMain.SmallImageList = this.ilGroupBarSmall;
            this.gvMain.SmallImageView = true;
            this.gvMain.Style = Syncfusion.Windows.Forms.Appearance.Office2016;
            this.gvMain.TabIndex = 8;
            this.gvMain.GroupViewItemSelected += new System.EventHandler(this.gvcWinForms_GroupViewItemSelected);
            this.gvMain.GroupViewItemsReordered += new System.EventHandler(this.gvcWinForms_GroupViewItemsReordered);
            this.gvMain.GroupViewItemRenamed += new Syncfusion.Windows.Forms.Tools.GroupItemRenamedEventHandler(this.gvcWinForms_GroupViewItemRenamed);
            this.gvMain.ShowContextMenu += new System.EventHandler(this.gvc_ShowContextMenu);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel6.Controls.Add(this.gradientPanel3);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Location = new System.Drawing.Point(566, 298);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(342, 210);
            this.panel6.TabIndex = 205;
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gradientPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(227)))), ((int)(((byte)(246)))));
            this.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel3.Controls.Add(this.listView1);
            this.gradientPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel3.Location = new System.Drawing.Point(0, 30);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(342, 180);
            this.gradientPanel3.TabIndex = 199;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 30);
            this.panel2.TabIndex = 157;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(10, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 170;
            this.label6.Text = "Event Log";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.gpVSBehavior);
            this.panel5.Controls.Add(this.panel15);
            this.panel5.Location = new System.Drawing.Point(184, 297);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(321, 210);
            this.panel5.TabIndex = 204;
            // 
            // gpVSBehavior
            // 
            this.gpVSBehavior.BackColor = System.Drawing.Color.White;
            this.gpVSBehavior.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(227)))), ((int)(((byte)(246)))));
            this.gpVSBehavior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gpVSBehavior.Controls.Add(this.label1);
            this.gpVSBehavior.Controls.Add(this.cbIntegratedScrolling);
            this.gpVSBehavior.Controls.Add(this.cbFlowViewItemText);
            this.gpVSBehavior.Controls.Add(this.cbToolTips);
            this.gpVSBehavior.Controls.Add(this.cbFlowView);
            this.gpVSBehavior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpVSBehavior.Location = new System.Drawing.Point(0, 30);
            this.gpVSBehavior.Name = "gpVSBehavior";
            this.gpVSBehavior.Size = new System.Drawing.Size(321, 180);
            this.gpVSBehavior.TabIndex = 196;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 38);
            this.label1.TabIndex = 172;
            this.label1.Text = "Use the GroupView\'s context menu for more options...";
            // 
            // cbIntegratedScrolling
            // 
            this.cbIntegratedScrolling.BeforeTouchSize = new System.Drawing.Size(134, 20);
            this.cbIntegratedScrolling.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.cbIntegratedScrolling.DrawFocusRectangle = false;
            this.cbIntegratedScrolling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cbIntegratedScrolling.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbIntegratedScrolling.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.cbIntegratedScrolling.Location = new System.Drawing.Point(30, 95);
            this.cbIntegratedScrolling.MetroColor = System.Drawing.Color.Gray;
            this.cbIntegratedScrolling.Name = "cbIntegratedScrolling";
            this.cbIntegratedScrolling.Size = new System.Drawing.Size(134, 20);
            this.cbIntegratedScrolling.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.cbIntegratedScrolling.TabIndex = 165;
            this.cbIntegratedScrolling.Text = "Integrated Scrolling";
            this.cbIntegratedScrolling.ThemesEnabled = false;
            this.cbIntegratedScrolling.CheckedChanged += new System.EventHandler(this.cbIntegratedScrolling_CheckedChanged);
            // 
            // cbFlowViewItemText
            // 
            this.cbFlowViewItemText.BeforeTouchSize = new System.Drawing.Size(135, 17);
            this.cbFlowViewItemText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.cbFlowViewItemText.DrawFocusRectangle = false;
            this.cbFlowViewItemText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cbFlowViewItemText.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbFlowViewItemText.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.cbFlowViewItemText.Location = new System.Drawing.Point(30, 39);
            this.cbFlowViewItemText.MetroColor = System.Drawing.Color.Gray;
            this.cbFlowViewItemText.Name = "cbFlowViewItemText";
            this.cbFlowViewItemText.Size = new System.Drawing.Size(135, 17);
            this.cbFlowViewItemText.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.cbFlowViewItemText.TabIndex = 164;
            this.cbFlowViewItemText.Text = "FlowView Item Text";
            this.cbFlowViewItemText.ThemesEnabled = false;
            this.cbFlowViewItemText.CheckedChanged += new System.EventHandler(this.cbFlowViewItemText_CheckedChanged);
            // 
            // cbToolTips
            // 
            this.cbToolTips.BeforeTouchSize = new System.Drawing.Size(111, 17);
            this.cbToolTips.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.cbToolTips.DrawFocusRectangle = false;
            this.cbToolTips.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cbToolTips.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbToolTips.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.cbToolTips.Location = new System.Drawing.Point(30, 67);
            this.cbToolTips.MetroColor = System.Drawing.Color.Gray;
            this.cbToolTips.Name = "cbToolTips";
            this.cbToolTips.Size = new System.Drawing.Size(111, 17);
            this.cbToolTips.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.cbToolTips.TabIndex = 163;
            this.cbToolTips.Text = "ShowToolTips";
            this.cbToolTips.ThemesEnabled = false;
            this.cbToolTips.CheckedChanged += new System.EventHandler(this.cbToolTips_CheckedChanged);
            // 
            // cbFlowView
            // 
            this.cbFlowView.BeforeTouchSize = new System.Drawing.Size(88, 17);
            this.cbFlowView.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.cbFlowView.DrawFocusRectangle = false;
            this.cbFlowView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cbFlowView.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbFlowView.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.cbFlowView.Location = new System.Drawing.Point(30, 11);
            this.cbFlowView.MetroColor = System.Drawing.Color.Gray;
            this.cbFlowView.Name = "cbFlowView";
            this.cbFlowView.Size = new System.Drawing.Size(88, 17);
            this.cbFlowView.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.cbFlowView.TabIndex = 162;
            this.cbFlowView.Text = "FlowView";
            this.cbFlowView.ThemesEnabled = false;
            this.cbFlowView.CheckedChanged += new System.EventHandler(this.cbFlowView_CheckedChanged);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel15.Controls.Add(this.label35);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(321, 30);
            this.panel15.TabIndex = 157;
            // 
            // label35
            // 
            this.label35.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.Black;
            this.label35.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label35.Location = new System.Drawing.Point(10, 6);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(77, 19);
            this.label35.TabIndex = 170;
            this.label35.Text = "Behavior";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.gradientPanel5);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Location = new System.Drawing.Point(182, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(727, 275);
            this.panel4.TabIndex = 203;
            // 
            // gradientPanel5
            // 
            this.gradientPanel5.BackColor = System.Drawing.Color.White;
            this.gradientPanel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(227)))), ((int)(((byte)(246)))));
            this.gradientPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel5.Controls.Add(this.cpSelectedHlText);
            this.gradientPanel5.Controls.Add(this.cbHighlightImage);
            this.gradientPanel5.Controls.Add(this.cpSelectedTextColor);
            this.gradientPanel5.Controls.Add(this.label20);
            this.gradientPanel5.Controls.Add(this.label5);
            this.gradientPanel5.Controls.Add(this.cpBackColor);
            this.gradientPanel5.Controls.Add(this.cbTextUnderline);
            this.gradientPanel5.Controls.Add(this.cmbOrientation);
            this.gradientPanel5.Controls.Add(this.cmbStyle);
            this.gradientPanel5.Controls.Add(this.label41);
            this.gradientPanel5.Controls.Add(this.label14);
            this.gradientPanel5.Controls.Add(this.cbTextWrap);
            this.gradientPanel5.Controls.Add(this.label12);
            this.gradientPanel5.Controls.Add(this.cbThemesEnabled);
            this.gradientPanel5.Controls.Add(this.nUDTextSpacing);
            this.gradientPanel5.Controls.Add(this.cbButtonView);
            this.gradientPanel5.Controls.Add(this.nUDSelectedHighlightOffset);
            this.gradientPanel5.Controls.Add(this.cbHighightText);
            this.gradientPanel5.Controls.Add(this.label3);
            this.gradientPanel5.Controls.Add(this.cmbGVBorder);
            this.gradientPanel5.Controls.Add(this.nUDSelectedOffset);
            this.gradientPanel5.Controls.Add(this.numericUpDownExt1);
            this.gradientPanel5.Controls.Add(this.nUDSelectingOffset);
            this.gradientPanel5.Controls.Add(this.label2);
            this.gradientPanel5.Controls.Add(this.label16);
            this.gradientPanel5.Controls.Add(this.label19);
            this.gradientPanel5.Controls.Add(this.nUDHighlightOffset);
            this.gradientPanel5.Controls.Add(this.cpHighlightText);
            this.gradientPanel5.Controls.Add(this.label11);
            this.gradientPanel5.Controls.Add(this.cpselectedHlItem);
            this.gradientPanel5.Controls.Add(this.label10);
            this.gradientPanel5.Controls.Add(this.label9);
            this.gradientPanel5.Controls.Add(this.label18);
            this.gradientPanel5.Controls.Add(this.cpSelectedItemColor);
            this.gradientPanel5.Controls.Add(this.label17);
            this.gradientPanel5.Controls.Add(this.cpHighlightItem);
            this.gradientPanel5.Controls.Add(this.label13);
            this.gradientPanel5.Controls.Add(this.label15);
            this.gradientPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel5.Location = new System.Drawing.Point(0, 30);
            this.gradientPanel5.Name = "gradientPanel5";
            this.gradientPanel5.Size = new System.Drawing.Size(727, 245);
            this.gradientPanel5.TabIndex = 201;
            // 
            // cpSelectedHlText
            // 
            this.cpSelectedHlText.BackColor = System.Drawing.Color.Black;
            this.cpSelectedHlText.BeforeTouchSize = new System.Drawing.Size(20, 20);
            this.cpSelectedHlText.ColorUISize = new System.Drawing.Size(208, 230);
            this.cpSelectedHlText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cpSelectedHlText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cpSelectedHlText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpSelectedHlText.ForeColor = System.Drawing.Color.Black;
            this.cpSelectedHlText.IsBackStageButton = false;
            this.cpSelectedHlText.Location = new System.Drawing.Point(320, 137);
            this.cpSelectedHlText.MetroColor = System.Drawing.Color.Black;
            this.cpSelectedHlText.Name = "cpSelectedHlText";
            this.cpSelectedHlText.SelectedAsBackcolor = true;
            this.cpSelectedHlText.SelectedColor = System.Drawing.Color.Black;
            this.cpSelectedHlText.Size = new System.Drawing.Size(20, 20);
            this.cpSelectedHlText.TabIndex = 189;
            this.cpSelectedHlText.UseVisualStyleBackColor = false;
            this.cpSelectedHlText.ColorSelected += new System.EventHandler(this.cpSelectedHlText_ColorSelected_1);
            // 
            // cbHighlightImage
            // 
            this.cbHighlightImage.BeforeTouchSize = new System.Drawing.Size(107, 22);
            this.cbHighlightImage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.cbHighlightImage.DrawFocusRectangle = false;
            this.cbHighlightImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cbHighlightImage.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbHighlightImage.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.cbHighlightImage.Location = new System.Drawing.Point(3, 12);
            this.cbHighlightImage.MetroColor = System.Drawing.Color.Gray;
            this.cbHighlightImage.Name = "cbHighlightImage";
            this.cbHighlightImage.Size = new System.Drawing.Size(107, 22);
            this.cbHighlightImage.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.cbHighlightImage.TabIndex = 188;
            this.cbHighlightImage.Text = "Highlight Image";
            this.cbHighlightImage.ThemesEnabled = false;
            this.cbHighlightImage.CheckedChanged += new System.EventHandler(this.cbHighlightImage_CheckedChanged);
            // 
            // cpSelectedTextColor
            // 
            this.cpSelectedTextColor.BackColor = System.Drawing.Color.SaddleBrown;
            this.cpSelectedTextColor.BeforeTouchSize = new System.Drawing.Size(20, 20);
            this.cpSelectedTextColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.cpSelectedTextColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cpSelectedTextColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cpSelectedTextColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpSelectedTextColor.ForeColor = System.Drawing.Color.Black;
            this.cpSelectedTextColor.IsBackStageButton = false;
            this.cpSelectedTextColor.Location = new System.Drawing.Point(320, 87);
            this.cpSelectedTextColor.MetroColor = System.Drawing.Color.SaddleBrown;
            this.cpSelectedTextColor.Name = "cpSelectedTextColor";
            this.cpSelectedTextColor.SelectedAsBackcolor = true;
            this.cpSelectedTextColor.SelectedColor = System.Drawing.Color.SaddleBrown;
            this.cpSelectedTextColor.Size = new System.Drawing.Size(20, 20);
            this.cpSelectedTextColor.TabIndex = 187;
            this.cpSelectedTextColor.UseVisualStyleBackColor = false;
            this.cpSelectedTextColor.ColorSelected += new System.EventHandler(this.cpSelectedTextColor_ColorSelected);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(356, 187);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 13);
            this.label20.TabIndex = 169;
            this.label20.Text = "Orientation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(158, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 159;
            this.label5.Text = "BackColor";
            // 
            // cpBackColor
            // 
            this.cpBackColor.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.cpBackColor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cpBackColor.BeforeTouchSize = new System.Drawing.Size(20, 20);
            this.cpBackColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.cpBackColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cpBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cpBackColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpBackColor.IsBackStageButton = false;
            this.cpBackColor.Location = new System.Drawing.Point(320, 12);
            this.cpBackColor.MetroColor = System.Drawing.SystemColors.ControlLight;
            this.cpBackColor.Name = "cpBackColor";
            this.cpBackColor.SelectedAsBackcolor = true;
            this.cpBackColor.SelectedColor = System.Drawing.SystemColors.ControlLight;
            this.cpBackColor.Size = new System.Drawing.Size(20, 20);
            this.cpBackColor.TabIndex = 158;
            this.cpBackColor.UseVisualStyleBackColor = true;
            this.cpBackColor.ColorSelected += new System.EventHandler(this.cpBackColor_ColorSelected);
            // 
            // cbTextUnderline
            // 
            this.cbTextUnderline.BeforeTouchSize = new System.Drawing.Size(107, 22);
            this.cbTextUnderline.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.cbTextUnderline.DrawFocusRectangle = false;
            this.cbTextUnderline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cbTextUnderline.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbTextUnderline.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.cbTextUnderline.Location = new System.Drawing.Point(3, 137);
            this.cbTextUnderline.MetroColor = System.Drawing.Color.Gray;
            this.cbTextUnderline.Name = "cbTextUnderline";
            this.cbTextUnderline.Size = new System.Drawing.Size(107, 22);
            this.cbTextUnderline.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.cbTextUnderline.TabIndex = 173;
            this.cbTextUnderline.Text = "Text Underline";
            this.cbTextUnderline.ThemesEnabled = false;
            this.cbTextUnderline.CheckedChanged += new System.EventHandler(this.cbTextUnderline_CheckedChanged);
            // 
            // cmbOrientation
            // 
            this.cmbOrientation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbOrientation.BeforeTouchSize = new System.Drawing.Size(130, 21);
            this.cmbOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrientation.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrientation.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical"});
            this.cmbOrientation.Location = new System.Drawing.Point(525, 187);
            this.cmbOrientation.Name = "cmbOrientation";
            this.cmbOrientation.Size = new System.Drawing.Size(130, 21);
            this.cmbOrientation.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.cmbOrientation.TabIndex = 170;
            this.cmbOrientation.Text = "Horizontal";
            this.cmbOrientation.SelectedIndexChanged += new System.EventHandler(this.cmbOrientation_SelectedIndexChanged);
            // 
            // cmbStyle
            // 
            this.cmbStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbStyle.BeforeTouchSize = new System.Drawing.Size(130, 21);
            this.cmbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStyle.Items.AddRange(new object[] {
            "Default",
            "Metro",
            "Office2016Colorful",
            "Office2016White",
            "Office2016DarkGray",
            "Office2016Black"});
            this.cmbStyle.Location = new System.Drawing.Point(525, 212);
            this.cmbStyle.Name = "cmbStyle";
            this.cmbStyle.Size = new System.Drawing.Size(130, 21);
            this.cmbStyle.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.cmbStyle.TabIndex = 190;
            this.cmbStyle.Text = "Office2016Colorful";
            this.cmbStyle.SelectedIndexChanged += new System.EventHandler(this.cmbStyle_SelectedIndexChanged);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.ForeColor = System.Drawing.Color.Black;
            this.label41.Location = new System.Drawing.Point(357, 212);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(31, 13);
            this.label41.TabIndex = 191;
            this.label41.Text = "Style";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(158, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 13);
            this.label14.TabIndex = 177;
            this.label14.Text = "SelectedHighlight Text Color";
            // 
            // cbTextWrap
            // 
            this.cbTextWrap.BeforeTouchSize = new System.Drawing.Size(84, 22);
            this.cbTextWrap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.cbTextWrap.DrawFocusRectangle = false;
            this.cbTextWrap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cbTextWrap.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbTextWrap.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.cbTextWrap.Location = new System.Drawing.Point(3, 112);
            this.cbTextWrap.MetroColor = System.Drawing.Color.Gray;
            this.cbTextWrap.Name = "cbTextWrap";
            this.cbTextWrap.Size = new System.Drawing.Size(84, 22);
            this.cbTextWrap.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.cbTextWrap.TabIndex = 174;
            this.cbTextWrap.Text = "Text Wrap";
            this.cbTextWrap.ThemesEnabled = false;
            this.cbTextWrap.CheckedChanged += new System.EventHandler(this.cbTextWrap_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(356, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 171;
            this.label12.Text = "Text Spacing";
            // 
            // cbThemesEnabled
            // 
            this.cbThemesEnabled.BeforeTouchSize = new System.Drawing.Size(113, 22);
            this.cbThemesEnabled.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.cbThemesEnabled.DrawFocusRectangle = false;
            this.cbThemesEnabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cbThemesEnabled.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbThemesEnabled.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.cbThemesEnabled.Location = new System.Drawing.Point(3, 87);
            this.cbThemesEnabled.MetroColor = System.Drawing.Color.Gray;
            this.cbThemesEnabled.Name = "cbThemesEnabled";
            this.cbThemesEnabled.Size = new System.Drawing.Size(113, 22);
            this.cbThemesEnabled.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.cbThemesEnabled.TabIndex = 171;
            this.cbThemesEnabled.Text = "Themes enabled";
            this.cbThemesEnabled.ThemesEnabled = false;
            this.cbThemesEnabled.CheckedChanged += new System.EventHandler(this.cbThemesEnabled_CheckedChanged);
            // 
            // nUDTextSpacing
            // 
            this.nUDTextSpacing.BackColor = System.Drawing.Color.White;
            this.nUDTextSpacing.BeforeTouchSize = new System.Drawing.Size(52, 22);
            this.nUDTextSpacing.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.nUDTextSpacing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nUDTextSpacing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.nUDTextSpacing.Location = new System.Drawing.Point(527, 112);
            this.nUDTextSpacing.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nUDTextSpacing.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nUDTextSpacing.Name = "nUDTextSpacing";
            this.nUDTextSpacing.Size = new System.Drawing.Size(52, 22);
            this.nUDTextSpacing.TabIndex = 172;
            this.nUDTextSpacing.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.nUDTextSpacing.ValueChanged += new System.EventHandler(this.nUDTextSpacing_ValueChanged);
            // 
            // cbButtonView
            // 
            this.cbButtonView.BeforeTouchSize = new System.Drawing.Size(93, 22);
            this.cbButtonView.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.cbButtonView.DrawFocusRectangle = false;
            this.cbButtonView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cbButtonView.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbButtonView.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.cbButtonView.Location = new System.Drawing.Point(3, 62);
            this.cbButtonView.MetroColor = System.Drawing.Color.Gray;
            this.cbButtonView.Name = "cbButtonView";
            this.cbButtonView.Size = new System.Drawing.Size(93, 22);
            this.cbButtonView.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.cbButtonView.TabIndex = 143;
            this.cbButtonView.Text = "ButtonView";
            this.cbButtonView.ThemesEnabled = false;
            this.cbButtonView.CheckedChanged += new System.EventHandler(this.cbButtonView_CheckedChanged);
            // 
            // nUDSelectedHighlightOffset
            // 
            this.nUDSelectedHighlightOffset.BackColor = System.Drawing.Color.White;
            this.nUDSelectedHighlightOffset.BeforeTouchSize = new System.Drawing.Size(52, 22);
            this.nUDSelectedHighlightOffset.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.nUDSelectedHighlightOffset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nUDSelectedHighlightOffset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.nUDSelectedHighlightOffset.Location = new System.Drawing.Point(527, 87);
            this.nUDSelectedHighlightOffset.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nUDSelectedHighlightOffset.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nUDSelectedHighlightOffset.Name = "nUDSelectedHighlightOffset";
            this.nUDSelectedHighlightOffset.Size = new System.Drawing.Size(52, 22);
            this.nUDSelectedHighlightOffset.TabIndex = 170;
            this.nUDSelectedHighlightOffset.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.nUDSelectedHighlightOffset.ValueChanged += new System.EventHandler(this.nUDSelectedHighlightOffset_ValueChanged);
            // 
            // cbHighightText
            // 
            this.cbHighightText.BeforeTouchSize = new System.Drawing.Size(107, 22);
            this.cbHighightText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.cbHighightText.DrawFocusRectangle = false;
            this.cbHighightText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cbHighightText.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbHighightText.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.cbHighightText.Location = new System.Drawing.Point(3, 37);
            this.cbHighightText.MetroColor = System.Drawing.Color.Gray;
            this.cbHighightText.Name = "cbHighightText";
            this.cbHighightText.Size = new System.Drawing.Size(107, 22);
            this.cbHighightText.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.cbHighightText.TabIndex = 162;
            this.cbHighightText.Text = "Highight Text";
            this.cbHighightText.ThemesEnabled = false;
            this.cbHighightText.CheckStateChanged += new System.EventHandler(this.cbHighightText_CheckStateChanged);
            this.cbHighightText.CheckedChanged += new System.EventHandler(this.cbHighightText_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(356, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 169;
            this.label3.Text = "SelectedHighlightText Offset";
            // 
            // cmbGVBorder
            // 
            this.cmbGVBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbGVBorder.BeforeTouchSize = new System.Drawing.Size(130, 21);
            this.cmbGVBorder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGVBorder.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGVBorder.Items.AddRange(new object[] {
            "None",
            "FixedSingle",
            "Fixed3D"});
            this.cmbGVBorder.Location = new System.Drawing.Point(525, 162);
            this.cmbGVBorder.Name = "cmbGVBorder";
            this.cmbGVBorder.Size = new System.Drawing.Size(130, 21);
            this.cmbGVBorder.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.cmbGVBorder.TabIndex = 161;
            this.cmbGVBorder.Text = "None";
            this.cmbGVBorder.SelectedIndexChanged += new System.EventHandler(this.cmbGVBorder_SelectedIndexChanged);
            // 
            // nUDSelectedOffset
            // 
            this.nUDSelectedOffset.BackColor = System.Drawing.Color.White;
            this.nUDSelectedOffset.BeforeTouchSize = new System.Drawing.Size(52, 22);
            this.nUDSelectedOffset.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.nUDSelectedOffset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nUDSelectedOffset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.nUDSelectedOffset.Location = new System.Drawing.Point(527, 62);
            this.nUDSelectedOffset.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nUDSelectedOffset.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nUDSelectedOffset.Name = "nUDSelectedOffset";
            this.nUDSelectedOffset.Size = new System.Drawing.Size(52, 22);
            this.nUDSelectedOffset.TabIndex = 168;
            this.nUDSelectedOffset.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.nUDSelectedOffset.ValueChanged += new System.EventHandler(this.nUDSelectedOffset_ValueChanged);
            // 
            // numericUpDownExt1
            // 
            this.numericUpDownExt1.BackColor = System.Drawing.Color.White;
            this.numericUpDownExt1.BeforeTouchSize = new System.Drawing.Size(52, 22);
            this.numericUpDownExt1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.numericUpDownExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.numericUpDownExt1.Location = new System.Drawing.Point(527, 137);
            this.numericUpDownExt1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownExt1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.numericUpDownExt1.Name = "numericUpDownExt1";
            this.numericUpDownExt1.Size = new System.Drawing.Size(52, 22);
            this.numericUpDownExt1.TabIndex = 168;
            this.numericUpDownExt1.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownExt1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.numericUpDownExt1.ValueChanged += new System.EventHandler(this.numericUpDownExt1_ValueChanged);
            // 
            // nUDSelectingOffset
            // 
            this.nUDSelectingOffset.BackColor = System.Drawing.Color.White;
            this.nUDSelectingOffset.BeforeTouchSize = new System.Drawing.Size(52, 22);
            this.nUDSelectingOffset.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.nUDSelectingOffset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nUDSelectingOffset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.nUDSelectingOffset.Location = new System.Drawing.Point(527, 37);
            this.nUDSelectingOffset.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nUDSelectingOffset.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nUDSelectingOffset.Name = "nUDSelectingOffset";
            this.nUDSelectingOffset.Size = new System.Drawing.Size(52, 22);
            this.nUDSelectingOffset.TabIndex = 167;
            this.nUDSelectingOffset.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.nUDSelectingOffset.ValueChanged += new System.EventHandler(this.nUDSelectingOffset_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(356, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 160;
            this.label2.Text = "BorderStyle";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(158, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 13);
            this.label16.TabIndex = 175;
            this.label16.Text = "HighlightText Color";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(356, 137);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 13);
            this.label19.TabIndex = 167;
            this.label19.Text = "ImageSpacing";
            // 
            // nUDHighlightOffset
            // 
            this.nUDHighlightOffset.BackColor = System.Drawing.Color.White;
            this.nUDHighlightOffset.BeforeTouchSize = new System.Drawing.Size(52, 22);
            this.nUDHighlightOffset.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.nUDHighlightOffset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nUDHighlightOffset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.nUDHighlightOffset.Location = new System.Drawing.Point(527, 12);
            this.nUDHighlightOffset.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nUDHighlightOffset.MetroColor = System.Drawing.Color.Gray;
            this.nUDHighlightOffset.Name = "nUDHighlightOffset";
            this.nUDHighlightOffset.Size = new System.Drawing.Size(52, 22);
            this.nUDHighlightOffset.TabIndex = 166;
            this.nUDHighlightOffset.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.nUDHighlightOffset.ValueChanged += new System.EventHandler(this.nUDHighlightOffset_ValueChanged);
            // 
            // cpHighlightText
            // 
            this.cpHighlightText.BackColor = System.Drawing.Color.Brown;
            this.cpHighlightText.BeforeTouchSize = new System.Drawing.Size(20, 20);
            this.cpHighlightText.ColorUISize = new System.Drawing.Size(208, 230);
            this.cpHighlightText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cpHighlightText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cpHighlightText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpHighlightText.ForeColor = System.Drawing.Color.Black;
            this.cpHighlightText.IsBackStageButton = false;
            this.cpHighlightText.Location = new System.Drawing.Point(320, 37);
            this.cpHighlightText.MetroColor = System.Drawing.Color.Brown;
            this.cpHighlightText.Name = "cpHighlightText";
            this.cpHighlightText.SelectedAsBackcolor = true;
            this.cpHighlightText.SelectedColor = System.Drawing.Color.Brown;
            this.cpHighlightText.Size = new System.Drawing.Size(20, 20);
            this.cpHighlightText.TabIndex = 181;
            this.cpHighlightText.UseVisualStyleBackColor = false;
            this.cpHighlightText.ColorSelected += new System.EventHandler(this.cpHighlightText_ColorSelected);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(356, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 165;
            this.label11.Text = "SelectedText Offset";
            // 
            // cpselectedHlItem
            // 
            this.cpselectedHlItem.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.cpselectedHlItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cpselectedHlItem.BeforeTouchSize = new System.Drawing.Size(20, 20);
            this.cpselectedHlItem.ColorUISize = new System.Drawing.Size(208, 230);
            this.cpselectedHlItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cpselectedHlItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cpselectedHlItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpselectedHlItem.ForeColor = System.Drawing.Color.Black;
            this.cpselectedHlItem.IsBackStageButton = false;
            this.cpselectedHlItem.Location = new System.Drawing.Point(320, 162);
            this.cpselectedHlItem.MetroColor = System.Drawing.SystemColors.ControlLight;
            this.cpselectedHlItem.Name = "cpselectedHlItem";
            this.cpselectedHlItem.SelectedAsBackcolor = true;
            this.cpselectedHlItem.SelectedColor = System.Drawing.SystemColors.ControlLight;
            this.cpselectedHlItem.Size = new System.Drawing.Size(20, 20);
            this.cpselectedHlItem.TabIndex = 182;
            this.cpselectedHlItem.UseVisualStyleBackColor = false;
            this.cpselectedHlItem.ColorSelected += new System.EventHandler(this.cpselectedHlItem_ColorSelected);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(356, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 13);
            this.label10.TabIndex = 164;
            this.label10.Text = "SelectingText Offset";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(356, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 163;
            this.label9.Text = "HighlightText Offset";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(158, 87);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(103, 13);
            this.label18.TabIndex = 184;
            this.label18.Text = "Selected Text Color";
            // 
            // cpSelectedItemColor
            // 
            this.cpSelectedItemColor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cpSelectedItemColor.BeforeTouchSize = new System.Drawing.Size(20, 20);
            this.cpSelectedItemColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.cpSelectedItemColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cpSelectedItemColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cpSelectedItemColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpSelectedItemColor.ForeColor = System.Drawing.Color.Black;
            this.cpSelectedItemColor.IsBackStageButton = false;
            this.cpSelectedItemColor.Location = new System.Drawing.Point(320, 112);
            this.cpSelectedItemColor.MetroColor = System.Drawing.SystemColors.ControlLight;
            this.cpSelectedItemColor.Name = "cpSelectedItemColor";
            this.cpSelectedItemColor.SelectedAsBackcolor = true;
            this.cpSelectedItemColor.SelectedColor = System.Drawing.SystemColors.ControlLight;
            this.cpSelectedItemColor.Size = new System.Drawing.Size(20, 20);
            this.cpSelectedItemColor.TabIndex = 186;
            this.cpSelectedItemColor.UseVisualStyleBackColor = false;
            this.cpSelectedItemColor.ColorSelected += new System.EventHandler(this.cpSelectedItemColor_ColorSelected);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(158, 112);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 13);
            this.label17.TabIndex = 185;
            this.label17.Text = "Selected Item Color";
            // 
            // cpHighlightItem
            // 
            this.cpHighlightItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cpHighlightItem.BeforeTouchSize = new System.Drawing.Size(20, 20);
            this.cpHighlightItem.ColorUISize = new System.Drawing.Size(208, 230);
            this.cpHighlightItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cpHighlightItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cpHighlightItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpHighlightItem.ForeColor = System.Drawing.Color.Black;
            this.cpHighlightItem.IsBackStageButton = false;
            this.cpHighlightItem.Location = new System.Drawing.Point(320, 62);
            this.cpHighlightItem.MetroColor = System.Drawing.SystemColors.ControlLight;
            this.cpHighlightItem.Name = "cpHighlightItem";
            this.cpHighlightItem.SelectedAsBackcolor = true;
            this.cpHighlightItem.SelectedColor = System.Drawing.SystemColors.ControlLight;
            this.cpHighlightItem.Size = new System.Drawing.Size(20, 20);
            this.cpHighlightItem.TabIndex = 180;
            this.cpHighlightItem.UseVisualStyleBackColor = false;
            this.cpHighlightItem.ColorSelected += new System.EventHandler(this.cpHighlightItem_ColorSelected);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(158, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 13);
            this.label13.TabIndex = 178;
            this.label13.Text = "SelectedHighlightItem Color";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(158, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 13);
            this.label15.TabIndex = 176;
            this.label15.Text = "HighlightItem Color";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.label22);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(727, 30);
            this.panel3.TabIndex = 157;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label22.Location = new System.Drawing.Point(11, 4);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(97, 19);
            this.label22.TabIndex = 170;
            this.label22.Text = "Appearance";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(74, 24);
            this.button1.IsBackStageButton = false;
            this.button1.Location = new System.Drawing.Point(834, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 24);
            this.button1.TabIndex = 202;
            this.button1.Text = "Clear log";
            this.button1.UseVisualStyle = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv2.Controls.Add(this.panel7);
            this.tabPageAdv2.Controls.Add(this.gvModes);
            this.tabPageAdv2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv2.Location = new System.Drawing.Point(2, 27);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(1200, 695);
            this.tabPageAdv2.TabIndex = 2;
            this.tabPageAdv2.Text = "GroupView Modes";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.gradientPanel2);
            this.panel7.Location = new System.Drawing.Point(186, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(744, 514);
            this.panel7.TabIndex = 206;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel8.Controls.Add(this.gradientPanel1);
            this.panel8.Location = new System.Drawing.Point(8, 9);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(719, 121);
            this.panel8.TabIndex = 206;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.label7);
            this.gradientPanel1.Controls.Add(this.label40);
            this.gradientPanel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel1.Location = new System.Drawing.Point(6, 6);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(705, 109);
            this.gradientPanel1.TabIndex = 205;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(651, 107);
            this.label7.TabIndex = 2;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // label40
            // 
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.Dock = System.Windows.Forms.DockStyle.Right;
            this.label40.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label40.Image = ((System.Drawing.Image)(resources.GetObject("label40.Image")));
            this.label40.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label40.Location = new System.Drawing.Point(651, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(52, 107);
            this.label40.TabIndex = 1;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel2.Controls.Add(this.rbOXPFolderBrowser);
            this.gradientPanel2.Controls.Add(this.rbXPTaskBar);
            this.gradientPanel2.Controls.Add(this.rbLargeIcons);
            this.gradientPanel2.Controls.Add(this.rbO2KFolderBrowser);
            this.gradientPanel2.Controls.Add(this.rbMessengerList);
            this.gradientPanel2.Controls.Add(this.rbVSNETFlow);
            this.gradientPanel2.Controls.Add(this.rbVSNETList);
            this.gradientPanel2.Controls.Add(this.rbSmallIcons);
            this.gradientPanel2.Location = new System.Drawing.Point(131, 170);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(455, 306);
            this.gradientPanel2.TabIndex = 204;
            // 
            // tabPageAdv3
            // 
            this.tabPageAdv3.BackColor = System.Drawing.Color.White;
            this.tabPageAdv3.Controls.Add(this.gradientPanelExt1);
            this.tabPageAdv3.Controls.Add(this.gradientPanel6);
            this.tabPageAdv3.Image = null;
            this.tabPageAdv3.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv3.Location = new System.Drawing.Point(2, 27);
            this.tabPageAdv3.Name = "tabPageAdv3";
            this.tabPageAdv3.ShowCloseButton = true;
            this.tabPageAdv3.Size = new System.Drawing.Size(1200, 695);
            this.tabPageAdv3.TabIndex = 3;
            this.tabPageAdv3.Text = "Custom GroupView";
            this.tabPageAdv3.ThemesEnabled = false;
            // 
            // gradientPanelExt1
            // 
            this.gradientPanelExt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gradientPanelExt1.Border = new System.Windows.Forms.Padding(2);
            this.gradientPanelExt1.BorderGap = 2;
            this.gradientPanelExt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanelExt1.Controls.Add(this.gvFeatures);
            this.gradientPanelExt1.Location = new System.Drawing.Point(9, 12);
            this.gradientPanelExt1.Name = "gradientPanelExt1";
            this.gradientPanelExt1.Size = new System.Drawing.Size(192, 506);
            this.gradientPanelExt1.TabIndex = 159;
            // 
            // gvFeatures
            // 
            this.gvFeatures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvFeatures.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gvFeatures.BeforeTouchSize = new System.Drawing.Size(169, 489);
            this.gvFeatures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvFeatures.FlatLook = true;
            this.gvFeatures.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gvFeatures.GroupViewItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupViewItem[] {
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Custom Colors", 0, true, null, "Custom Colors"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Text Customization", 1, true, null, "Text Customization"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Image Settings", 2, true, null, "Image Settings"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Orientation", 3, true, null, "Orientation"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("ContextMenu", 4, true, null, "ContextMenu"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("ToolTip Support", 5, true, null, "ToolTip Support"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("InPlace Rename", 6, true, null, "InPlace Rename"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Various Modes", 7, true, null, "Various Modes"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Events Support", 8, true, null, "Events Support"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Localization", 9, true, null, "Localization")});
            this.gvFeatures.HighlightImageOffset = new System.Drawing.Point(1, 1);
            this.gvFeatures.IntegratedScrolling = true;
            this.gvFeatures.ItemXSpacing = -10;
            this.gvFeatures.ItemYSpacing = 10;
            this.gvFeatures.LargeImageList = this.imageList;
            this.gvFeatures.Location = new System.Drawing.Point(10, 8);
            this.gvFeatures.Name = "gvFeatures";
            this.gvFeatures.Size = new System.Drawing.Size(169, 489);
            this.gvFeatures.Style = Syncfusion.Windows.Forms.Appearance.Office2016;
            this.gvFeatures.TabIndex = 174;
            this.gvFeatures.Text = "groupView1";
            this.gvFeatures.TextSpacing = 22;
            this.gvFeatures.TextWrap = true;
            this.gvFeatures.GroupViewItemHighlighted += new System.EventHandler(this.groupView1_GroupViewItemHighlighted);
            this.gvFeatures.MouseLeave += new System.EventHandler(this.groupView1_MouseLeave);
            // 
            // gradientPanel6
            // 
            this.gradientPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gradientPanel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(137)))), ((int)(((byte)(243)))));
            this.gradientPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel6.Controls.Add(this.gradientPanel4);
            this.gradientPanel6.Location = new System.Drawing.Point(210, 19);
            this.gradientPanel6.Name = "gradientPanel6";
            this.gradientPanel6.Size = new System.Drawing.Size(701, 497);
            this.gradientPanel6.TabIndex = 203;
            // 
            // gradientPanel4
            // 
            this.gradientPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gradientPanel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(137)))), ((int)(((byte)(243)))));
            this.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel4.Controls.Add(this.richTextBox1);
            this.gradientPanel4.Location = new System.Drawing.Point(10, 12);
            this.gradientPanel4.Name = "gradientPanel4";
            this.gradientPanel4.Size = new System.Drawing.Size(665, 472);
            this.gradientPanel4.TabIndex = 204;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(62, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(533, 467);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // scrollersFrame1
            // 
            this.scrollersFrame1.AttachedTo = this.richTextBox1;
            this.scrollersFrame1.CustomRender = null;
            this.scrollersFrame1.MetroColorScheme = Syncfusion.Windows.Forms.MetroColorScheme.Managed;
            this.scrollersFrame1.MetroThumbSize = new System.Drawing.Size(0, 0);
            this.scrollersFrame1.Office2016ColorScheme = Syncfusion.Windows.Forms.ScrollBarOffice2016ColorScheme.Colorful;
            metroColorTable1.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            metroColorTable1.ArrowCheckedBorderColor = System.Drawing.Color.Empty;
            metroColorTable1.ArrowInActive = System.Drawing.Color.White;
            metroColorTable1.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            metroColorTable1.ArrowNormalBackGround = System.Drawing.Color.Empty;
            metroColorTable1.ArrowNormalBorderColor = System.Drawing.Color.Empty;
            metroColorTable1.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            metroColorTable1.ArrowPushedBackGround = System.Drawing.Color.Empty;
            metroColorTable1.ArrowPushedBorderColor = System.Drawing.Color.Empty;
            metroColorTable1.ScrollerBackground = System.Drawing.Color.White;
            metroColorTable1.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            metroColorTable1.ThumbCheckedBorderColor = System.Drawing.Color.Empty;
            metroColorTable1.ThumbInActive = System.Drawing.Color.White;
            metroColorTable1.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            metroColorTable1.ThumbNormalBorderColor = System.Drawing.Color.Empty;
            metroColorTable1.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            metroColorTable1.ThumbPushedBorder = System.Drawing.Color.Empty;
            metroColorTable1.ThumbPushedBorderColor = System.Drawing.Color.Empty;
            this.scrollersFrame1.ScrollMetroColorTable = metroColorTable1;
            metroColorTable2.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            metroColorTable2.ArrowCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable2.ArrowInActive = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            metroColorTable2.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            metroColorTable2.ArrowNormalBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable2.ArrowNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            metroColorTable2.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            metroColorTable2.ArrowPushedBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            metroColorTable2.ArrowPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            metroColorTable2.ScrollerBackground = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            metroColorTable2.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            metroColorTable2.ThumbCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable2.ThumbInActive = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            metroColorTable2.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable2.ThumbNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            metroColorTable2.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            metroColorTable2.ThumbPushedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            metroColorTable2.ThumbPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.scrollersFrame1.ScrollOffice2016BlackColorTable = metroColorTable2;
            metroColorTable3.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable3.ArrowCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable3.ArrowInActive = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable3.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable3.ArrowNormalBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            metroColorTable3.ArrowNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable3.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable3.ArrowPushedBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable3.ArrowPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            metroColorTable3.ScrollerBackground = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable3.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            metroColorTable3.ThumbCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            metroColorTable3.ThumbInActive = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable3.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable3.ThumbNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            metroColorTable3.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            metroColorTable3.ThumbPushedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            metroColorTable3.ThumbPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.scrollersFrame1.ScrollOffice2016ColorfulColorTable = metroColorTable3;
            metroColorTable4.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            metroColorTable4.ArrowCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable4.ArrowInActive = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            metroColorTable4.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable4.ArrowNormalBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            metroColorTable4.ArrowNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            metroColorTable4.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable4.ArrowPushedBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            metroColorTable4.ArrowPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            metroColorTable4.ScrollerBackground = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            metroColorTable4.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            metroColorTable4.ThumbCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            metroColorTable4.ThumbInActive = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            metroColorTable4.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            metroColorTable4.ThumbNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable4.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            metroColorTable4.ThumbPushedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            metroColorTable4.ThumbPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.scrollersFrame1.ScrollOffice2016DarkGrayColorTable = metroColorTable4;
            metroColorTable5.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable5.ArrowCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable5.ArrowInActive = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable5.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable5.ArrowNormalBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            metroColorTable5.ArrowNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable5.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable5.ArrowPushedBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable5.ArrowPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            metroColorTable5.ScrollerBackground = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable5.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            metroColorTable5.ThumbCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            metroColorTable5.ThumbInActive = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable5.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable5.ThumbNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            metroColorTable5.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            metroColorTable5.ThumbPushedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            metroColorTable5.ThumbPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.scrollersFrame1.ScrollOffice2016WhiteColorTable = metroColorTable5;
            this.scrollersFrame1.ShowMetroArrowButton = true;
            this.scrollersFrame1.SizeGripperVisibility = Syncfusion.Windows.Forms.SizeGripperVisibility.Auto;
            this.scrollersFrame1.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Office2016;
            // 
            // gradientPanel7
            // 
            this.gradientPanel7.BorderColor = System.Drawing.Color.Silver;
            this.gradientPanel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel7.Controls.Add(this.tabControlAdv1);
            this.gradientPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel7.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel7.Name = "gradientPanel7";
            this.gradientPanel7.Size = new System.Drawing.Size(1928, 1064);
            this.gradientPanel7.TabIndex = 12;
            // 
            // GroupViewDemoForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1928, 1064);
            this.Controls.Add(this.gradientPanel7);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 708);
            this.Size= new System.Drawing.Size(1000, 708);
            this.Name = "GroupViewDemoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GroupView Demo ";
            ((System.ComponentModel.ISupportInitialize)(this.rbXPTaskBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbMessengerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbOXPFolderBrowser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbO2KFolderBrowser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbVSNETFlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbVSNETList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbSmallIcons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbLargeIcons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).EndInit();
            this.gradientPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gpVSBehavior)).EndInit();
            this.gpVSBehavior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbIntegratedScrolling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFlowViewItemText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbToolTips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFlowView)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel5)).EndInit();
            this.gradientPanel5.ResumeLayout(false);
            this.gradientPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbHighlightImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTextUnderline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOrientation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTextWrap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbThemesEnabled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDTextSpacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbButtonView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSelectedHighlightOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHighightText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGVBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSelectedOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSelectingOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDHighlightOffset)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabPageAdv2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.tabPageAdv3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanelExt1)).EndInit();
            this.gradientPanelExt1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel6)).EndInit();
            this.gradientPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).EndInit();
            this.gradientPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel7)).EndInit();
            this.gradientPanel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

    
        #endregion

        #region GroupView

        #region Various modes of groupView


        private void rbLargeIcons_CheckedChanged(object sender, System.EventArgs e)
        {
            // Set the GroupView attributes for the OutlookBar type interface with large icons
            if (this.rbLargeIcons.Checked == true)
            {
                this.gvModes.SmallImageView = false;
                this.gvModes.ButtonView = false;
                this.gvModes.FlowView = false;
                this.gvModes.FlatLook = false;

                this.gvModes.BackColor = SystemColors.ControlDark;
                this.gvModes.ForeColor = SystemColors.HighlightText;
                this.gvModes.HighlightItemColor = SystemColors.ControlDark;
                this.gvModes.HighlightTextColor = SystemColors.HighlightText;
                this.gvModes.SelectingItemColor = SystemColors.ControlDark;
                this.gvModes.SelectingTextColor = SystemColors.HighlightText;
                this.gvModes.SelectedItemColor = SystemColors.ControlDark;
                this.gvModes.SelectedTextColor = SystemColors.HighlightText;
                this.gvModes.SelectedHighlightItemColor = SystemColors.ControlDark;
                this.gvModes.SelectedHighlightTextColor = SystemColors.HighlightText;

                this.gvModes.ImageSpacing = 8;
                this.gvModes.ItemXSpacing = 8;
                this.gvModes.ItemYSpacing = 8;

                this.gvModes.ClipSelectionBounds = true;
                this.gvModes.HighlightImage = true;
                this.gvModes.HighlightText = false;
                this.gvModes.TextUnderline = false;
                this.gvModes.TextWrap = false;

                this.gvModes.HighlightImageOffset = Point.Empty;
                this.gvModes.SelectingImageOffset = Point.Empty;
                this.gvModes.SelectingTextOffset = Point.Empty;
            }
        }

        private void rbSmallIcons_CheckedChanged(object sender, System.EventArgs e)
        {
            // Set the GroupView attributes for the OutlookBar type interface with small icons
            if (this.rbSmallIcons.Checked == true)
            {
                this.gvModes.SmallImageView = true;
                this.gvModes.ButtonView = false;
                this.gvModes.FlowView = false;
                this.gvModes.FlatLook = false;

                this.gvModes.BackColor = SystemColors.ControlDark;
                this.gvModes.ForeColor = SystemColors.HighlightText;
                this.gvModes.HighlightItemColor = SystemColors.ControlDark;
                this.gvModes.HighlightTextColor = SystemColors.HighlightText;
                this.gvModes.SelectingItemColor = SystemColors.ControlDark;
                this.gvModes.SelectingTextColor = SystemColors.HighlightText;
                this.gvModes.SelectedItemColor = SystemColors.ControlDark;
                this.gvModes.SelectedTextColor = SystemColors.HighlightText;
                this.gvModes.SelectedHighlightItemColor = SystemColors.ControlDark;
                this.gvModes.SelectedHighlightTextColor = SystemColors.HighlightText;

                this.gvModes.ImageSpacing = 3;
                this.gvModes.ItemXSpacing = 8;
                this.gvModes.ItemYSpacing = 8;

                this.gvModes.ClipSelectionBounds = true;
                this.gvModes.HighlightImage = true;
                this.gvModes.HighlightText = false;
                this.gvModes.TextUnderline = false;
                this.gvModes.TextWrap = false;

                this.gvModes.HighlightImageOffset = Point.Empty;
                this.gvModes.SelectingImageOffset = Point.Empty;
                this.gvModes.SelectingTextOffset = Point.Empty;
            }
        }

        private void rbVSNETList_CheckedChanged(object sender, System.EventArgs e)
        {
            // Set the GroupView attributes for the VS.NET Toolbox type interface with ListView (non-flow) mode
            if (this.rbVSNETList.Checked == true)
            {

                this.gvModes.SmallImageView = true;
                this.gvModes.ButtonView = true;
                this.gvModes.FlowView = false;
                this.gvModes.FlatLook = false;

                this.gvModes.BackColor = SystemColors.Control;
                this.gvModes.ForeColor = SystemColors.ControlText;
                this.gvModes.HighlightItemColor = SystemColors.Control;
                this.gvModes.HighlightTextColor = SystemColors.ControlText;
                this.gvModes.SelectingItemColor = ControlPaint.Light(SystemColors.ControlLight);
                this.gvModes.SelectingTextColor = SystemColors.ControlText;
                this.gvModes.SelectedHighlightItemColor = SystemColors.Control;
                this.gvModes.SelectedHighlightTextColor = SystemColors.ControlText;
                this.gvModes.SelectedItemColor = ControlPaint.Light(SystemColors.ControlLight);
                this.gvModes.SelectedTextColor = SystemColors.ControlText;



                this.gvModes.ImageSpacing = 2;
                this.gvModes.ItemXSpacing = 8;
                this.gvModes.ItemYSpacing = 1;

                this.gvModes.ClipSelectionBounds = false;
                this.gvModes.HighlightImage = true;
                this.gvModes.HighlightText = true;
                this.gvModes.TextUnderline = false;
                this.gvModes.TextWrap = false;

                this.gvModes.HighlightImageOffset = Point.Empty;
                this.gvModes.SelectingImageOffset = Point.Empty;
                this.gvModes.SelectingTextOffset = Point.Empty;
            }
        }

        private void rbVSNETFlow_CheckedChanged(object sender, System.EventArgs e)
        {
            // Set the GroupView attributes for the VS.NET Toolbox type interface with non-listview (flow) mode
            if (this.rbVSNETFlow.Checked == true)
            {
                this.gvModes.SmallImageView = true;
                this.gvModes.ButtonView = true;
                this.gvModes.FlowView = true;
                this.gvModes.FlatLook = false;

                this.gvModes.BackColor = SystemColors.Control;
                this.gvModes.ForeColor = SystemColors.ControlText;
                this.gvModes.HighlightItemColor = SystemColors.Control;
                this.gvModes.HighlightTextColor = SystemColors.ControlText;
                this.gvModes.SelectingItemColor = ControlPaint.Light(SystemColors.ControlLight);
                this.gvModes.SelectingTextColor = SystemColors.ControlText;
                this.gvModes.SelectedItemColor = ControlPaint.Light(SystemColors.ControlLight);
                this.gvModes.SelectedTextColor = SystemColors.ControlText;
                this.gvModes.SelectedHighlightItemColor = SystemColors.Control;
                this.gvModes.SelectedHighlightTextColor = SystemColors.ControlText;

                this.gvModes.ImageSpacing = 5;
                this.gvModes.ItemXSpacing = 0;
                this.gvModes.ItemYSpacing = 0;

                this.gvModes.ClipSelectionBounds = false;
                this.gvModes.HighlightImage = true;
                this.gvModes.HighlightText = true;
                this.gvModes.TextUnderline = false;
                this.gvModes.TextWrap = false;

                this.gvModes.HighlightImageOffset = Point.Empty;
                this.gvModes.SelectingImageOffset = Point.Empty;
                this.gvModes.SelectingTextOffset = Point.Empty;
            }
        }

        private void rbOXPFolderBrowser_CheckedChanged(object sender, System.EventArgs e)
        {
            // Set the GroupView attributes for the Office XP folder browser type interface.
            if (this.rbOXPFolderBrowser.Checked == true)
            {
                this.gvModes.SmallImageView = false;
                this.gvModes.ButtonView = true;
                this.gvModes.FlowView = false;
                this.gvModes.FlatLook = true;

                this.gvModes.BackColor = ControlPaint.Light(SystemColors.Control, 0.25f);
                this.gvModes.ForeColor = SystemColors.ControlText;
                this.gvModes.HighlightItemColor = Color.FromArgb(236, 235, 240);
                this.gvModes.HighlightTextColor = SystemColors.ControlText;
                this.gvModes.SelectingItemColor = Color.FromArgb(133, 146, 181);
                this.gvModes.SelectedItemColor = Color.FromArgb(212, 213, 216);
                this.gvModes.SelectedTextColor = SystemColors.ControlText;
                this.gvModes.SelectedHighlightItemColor = Color.FromArgb(133, 146, 181);
                if (this.gvModes.ThemesEnabled == false)
                {
                    this.gvModes.SelectingTextColor = SystemColors.HighlightText;
                    this.gvModes.SelectedHighlightTextColor = SystemColors.HighlightText;
                }
                else
                {
                    this.gvModes.SelectingTextColor = SystemColors.ControlText;
                    this.gvModes.SelectedHighlightTextColor = SystemColors.ControlText;
                }

                this.gvModes.ImageSpacing = 5;
                this.gvModes.ItemXSpacing = 8;
                this.gvModes.ItemYSpacing = 1;

                this.gvModes.ClipSelectionBounds = false;
                this.gvModes.HighlightImage = true;
                this.gvModes.HighlightText = true;
                this.gvModes.TextUnderline = false;
                this.gvModes.TextWrap = true;

                this.gvModes.HighlightImageOffset = new Point(-2, -2);
                this.gvModes.SelectingImageOffset = Point.Empty;
                this.gvModes.SelectingTextOffset = Point.Empty;
            }
        }

        private void rbO2KFolderBrowser_CheckedChanged(object sender, System.EventArgs e)
        {
            // Set the GroupView attributes for the Office 2000 folder browser type interface.
            if (this.rbO2KFolderBrowser.Checked == true)
            {
                this.gvModes.SmallImageView = false;
                this.gvModes.ButtonView = true;
                this.gvModes.FlowView = false;
                this.gvModes.FlatLook = false;

                this.gvModes.BackColor = SystemColors.ControlDark;
                if (this.gvModes.ThemesEnabled == false)
                {
                    this.gvModes.ForeColor = SystemColors.HighlightText;
                    this.gvModes.HighlightTextColor = SystemColors.HighlightText;
                    this.gvModes.SelectingTextColor = SystemColors.HighlightText;
                    this.gvModes.SelectedTextColor = SystemColors.HighlightText;
                    this.gvModes.SelectedHighlightTextColor = SystemColors.HighlightText;
                }
                else
                {
                    this.gvModes.ForeColor = SystemColors.ControlText;
                    this.gvModes.HighlightTextColor = SystemColors.ControlText;
                    this.gvModes.SelectingTextColor = SystemColors.ControlText;
                    this.gvModes.SelectedTextColor = SystemColors.ControlText;
                    this.gvModes.SelectedHighlightTextColor = SystemColors.ControlText;
                }
                this.gvModes.HighlightItemColor = SystemColors.ControlDark;
                this.gvModes.SelectingItemColor = SystemColors.ControlDark;
                this.gvModes.SelectedItemColor = SystemColors.ControlDark;
                this.gvModes.SelectedHighlightItemColor = SystemColors.ControlDark;

                this.gvModes.ImageSpacing = 5;
                this.gvModes.ItemXSpacing = 8;
                this.gvModes.ItemYSpacing = 1;

                this.gvModes.ClipSelectionBounds = false;
                this.gvModes.HighlightText = true;
                this.gvModes.HighlightImage = true;
                this.gvModes.TextUnderline = false;
                this.gvModes.TextWrap = true;

                this.gvModes.HighlightImageOffset = Point.Empty;
                this.gvModes.SelectingImageOffset = Point.Empty;
                this.gvModes.SelectingTextOffset = Point.Empty;
            }
        }

        private void rbMessengerList_CheckedChanged(object sender, System.EventArgs e)
        {
            // Set the GroupView attributes for the MSN Messenger list type interface.
            if (this.rbMessengerList.Checked == true)
            {
                this.gvModes.SmallImageView = true;
                this.gvModes.ButtonView = true;
                this.gvModes.FlowView = false;
                this.gvModes.FlatLook = false;

                this.gvModes.BackColor = System.Drawing.Color.Beige;
                this.gvModes.ForeColor = SystemColors.ControlText;
                this.gvModes.HighlightItemColor = System.Drawing.Color.Beige;
                this.gvModes.HighlightTextColor = System.Drawing.Color.Coral;
                this.gvModes.SelectingItemColor = System.Drawing.Color.Beige;
                this.gvModes.SelectingTextColor = System.Drawing.Color.Coral;
                this.gvModes.SelectedItemColor = System.Drawing.Color.Beige;
                this.gvModes.SelectedTextColor = System.Drawing.Color.Coral;
                this.gvModes.SelectedHighlightItemColor = System.Drawing.Color.Beige;
                this.gvModes.SelectedHighlightTextColor = System.Drawing.Color.Coral;

                this.gvModes.ImageSpacing = 2;
                this.gvModes.ItemXSpacing = 8;
                this.gvModes.ItemYSpacing = 5;

                this.gvModes.ClipSelectionBounds = false;
                this.gvModes.HighlightImage = false;
                this.gvModes.HighlightText = false;
                this.gvModes.TextUnderline = false;
                this.gvModes.TextWrap = true;

                this.gvModes.HighlightImageOffset = Point.Empty;
                this.gvModes.SelectingImageOffset = new System.Drawing.Point(1, 1);
                this.gvModes.SelectingTextOffset = new System.Drawing.Point(1, 1);
            }
        }

        private void rbXPTaskBar_CheckedChanged(object sender, System.EventArgs e)
        {
            // Set the GroupView attributes for the XP TaskBar list type interface.
            if (this.rbXPTaskBar.Checked == true)
            {
                this.gvModes.SmallImageView = true;
                this.gvModes.ButtonView = false;
                this.gvModes.FlowView = false;
                this.gvModes.FlatLook = false;

                this.gvModes.BackColor = ControlPaint.LightLight(System.Drawing.Color.LightSteelBlue);
                this.gvModes.ForeColor = System.Drawing.Color.RoyalBlue;
                this.gvModes.HighlightItemColor = ControlPaint.LightLight(System.Drawing.Color.LightSteelBlue);
                this.gvModes.HighlightTextColor = System.Drawing.Color.DeepSkyBlue;
                this.gvModes.SelectingItemColor = ControlPaint.LightLight(System.Drawing.Color.LightSteelBlue);
                this.gvModes.SelectingTextColor = System.Drawing.Color.DeepSkyBlue;
                this.gvModes.SelectedItemColor = ControlPaint.LightLight(System.Drawing.Color.LightSteelBlue);
                this.gvModes.SelectedTextColor = System.Drawing.Color.DeepSkyBlue;
                this.gvModes.SelectedHighlightItemColor = ControlPaint.LightLight(System.Drawing.Color.LightSteelBlue);
                this.gvModes.SelectedHighlightTextColor = System.Drawing.Color.DeepSkyBlue;

                this.gvModes.ImageSpacing = 2;
                this.gvModes.ItemXSpacing = 8;
                this.gvModes.ItemYSpacing = 5;

                this.gvModes.ClipSelectionBounds = false;
                this.gvModes.HighlightImage = false;
                this.gvModes.HighlightText = false;
                this.gvModes.TextUnderline = true;
                this.gvModes.TextWrap = true;

                this.gvModes.HighlightImageOffset = Point.Empty;
                this.gvModes.SelectingImageOffset = Point.Empty;
                this.gvModes.SelectingTextOffset = Point.Empty;
            }
        }

        #endregion

        # region sample code block
        /*
		// This method is not used anywhere and is provided only to show how to 
		// programmatically create and initialize a GroupView control
		// <samplecodeblock name="GroupView">
		private void InitializeGroupView()
		{
			// Create the GroupView control
			this.gvcWinForms = new Syncfusion.Windows.Forms.Tools.GroupView();

			// Set the large and small ImageLists
			this.gvcWinForms.LargeImageList = this.ilGroupBarLarge;
			this.gvcWinForms.SmallImageList = this.ilGroupBarSmall;
	
			// Set the GroupView properties to display as a VS.NET Toolbox type window
			this.gvcWinForms.SmallImageView = true;
			this.gvcWinForms.ButtonView = true;
			this.gvcWinForms.FlowView = false;
			this.gvcWinForms.FlatLook = false;

			this.gvcWinForms.BackColor = SystemColors.Control;
			this.gvcWinForms.ForeColor = SystemColors.ControlText;
			this.gvcWinForms.HighlightItemColor = SystemColors.Control;
			this.gvcWinForms.HighlightTextColor = SystemColors.ControlText;
			this.gvcWinForms.SelectingItemColor = ControlPaint.Light(SystemColors.ControlLight);
			this.gvcWinForms.SelectingTextColor = SystemColors.ControlText;
			this.gvcWinForms.SelectedItemColor = ControlPaint.Light(SystemColors.ControlLight);
			this.gvcWinForms.SelectedTextColor = SystemColors.ControlText;
			this.gvcWinForms.SelectedHighlightItemColor = SystemColors.Control;
			this.gvcWinForms.SelectedHighlightTextColor = SystemColors.ControlText;	

			this.gvcWinForms.ImageSpacing = 2;
			this.gvcWinForms.ItemXSpacing = 8;
			this.gvcWinForms.ItemYSpacing = 1;

			this.gvcWinForms.ClipSelectionBounds = false;
			this.gvcWinForms.HighlightImage = true;
			this.gvcWinForms.HighlightText = true;
			this.gvcWinForms.TextUnderline = false;
			this.gvcWinForms.TextWrap = false;																			 
		
			// Create and add the GroupViewItem objects
			this.gvcWinForms.GroupViewItems.AddRange(
			new Syncfusion.Windows.Forms.Tools.GroupViewItem[] {
																   new Syncfusion.Windows.Forms.Tools.GroupViewItem("Pointer", 11),
																   new Syncfusion.Windows.Forms.Tools.GroupViewItem("Label", 12),
																   new Syncfusion.Windows.Forms.Tools.GroupViewItem("LinkLabel", 13)});
																	   
			// Provide a handler for the GroupView.GroupViewItemSelected event.
			this.gvcWinForms.GroupViewItemSelected += new System.EventHandler(this.gvcWinForms_GroupViewItemSelected);																	   
		}
		
		// GroupView.GroupViewItemSelected event handler.
		private void gvcWinForms_GroupViewItemSelected(object sender, System.EventArgs e)
		{
			MessageBox.Show(String.Concat("Selected Item Index = ", this.gvcWinForms.SelectedItem.ToString())); 
		}
		// </samplecodeblock>		
		*/
        #endregion

        #region GroupView Events 
        // GroupView.GroupViewItemSelected event handler.
        private void gvcWinForms_GroupViewItemSelected(object sender, System.EventArgs e)
        {
            GroupView gview = sender as GroupView;
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] { "GroupViewItemSelected", "Selected Item : " + gview.GroupViewItems[gview.SelectedItem].Text });
            this.listView1.Items.Add(listViewItem1);
        }


        private void gvcWinForms_GroupViewItemsReordered(object sender, System.EventArgs e)
        {
            ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] { "GroupViewItemsReordered" });
            this.listView1.Items.Add(listViewItem1);
        }

        private void gvcWinForms_GroupViewItemRenamed(object obj, Syncfusion.Windows.Forms.Tools.GroupItemRenamedEventArgs arg)
        {
            ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] { "GroupViewItemRenamed", "Old Label: " + arg.OldLabel + " New Label: " + arg.NewLabel });
            this.listView1.Items.Add(listViewItem1);
        }

        #region ContextMenu
        // Handler for the GroupView.ShowContextMenu event.
        private void gvc_ShowContextMenu(object sender, System.EventArgs e)
        {
            ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] { "ContextMenu Shown" });
            this.listView1.Items.Add(listViewItem1);

            Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu menu = new Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu();

            menu.ParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            menu.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003;

            BarItem additem = new BarItem("Add New Item", new EventHandler(this.gvc_MenuAddNewItem));
            additem.ImageList = this.ilGroupBarSmall;
            additem.ImageIndex = 17;
            menu.ParentBarItem.Items.Add(additem);

            BarItem removeitem = new BarItem("Remove Item", new EventHandler(this.gvc_MenuRemoveItem));
            removeitem.ImageList = this.ilGroupBarSmall;
            removeitem.ImageIndex = 18;
            menu.ParentBarItem.Items.Add(removeitem);

            BarItem renameitem = new BarItem("Rename Item", new EventHandler(this.gvc_MenuRenameItem));
            menu.ParentBarItem.Items.Add(renameitem);

            if (this.gvMain.ButtonView == true)
            {
                BarItem listviewitem = null;
                listviewitem = new BarItem("List View", new EventHandler(this.gvc_MenuListView));
                if (this.gvMain.FlowView == false)
                    listviewitem.Checked = true;
                else
                    listviewitem.Checked = false;
                menu.ParentBarItem.Items.Add(listviewitem);

                BarItem moveupitem = new BarItem("Move &Up", new EventHandler(this.gvc_MenuMoveUpDown));
                moveupitem.ImageList = this.ilGroupBarSmall;
                moveupitem.ImageIndex = 19;
                menu.ParentBarItem.Items.Add(moveupitem);
                if (this.gvMain.SelectedItem <= 0)
                    moveupitem.Enabled = false;

                BarItem movedownitem = new BarItem("Move &Down", new EventHandler(this.gvc_MenuMoveUpDown));
                movedownitem.ImageList = this.ilGroupBarSmall;
                movedownitem.ImageIndex = 20;
                menu.ParentBarItem.Items.Add(movedownitem);
                if (this.gvMain.SelectedItem >= this.gvMain.GroupViewItems.Count - 1)
                    movedownitem.Enabled = false;

                if (listviewitem != null)
                    menu.ParentBarItem.BeginGroupAt(listviewitem);
                menu.ParentBarItem.BeginGroupAt(moveupitem);
            }

            if (this.gvMain.HighlightedItem == -1)
            {
                removeitem.Enabled = false;
                renameitem.Enabled = false;
            }

            if (Syncfusion.Windows.Forms.XPThemes.IsThemedOS && Syncfusion.Windows.Forms.XPThemes.IsThemeActive)
            {
                BarItem themedrawingitem = new BarItem("Theme &Drawing", new EventHandler(this.gvc_ThemeDrawing));
                if (this.gvMain.ThemesEnabled == true)
                    themedrawingitem.Checked = true;
                else
                    themedrawingitem.Checked = false;
                menu.ParentBarItem.Items.Add(themedrawingitem);
                menu.ParentBarItem.BeginGroupAt(themedrawingitem);
            }

            menu.Show(this.gvMain, this.gvMain.PointToClient(Cursor.Position));
        }

        public void gvc_MenuAddNewItem(object sender, EventArgs e)
        {

            Syncfusion.Windows.Forms.Tools.GroupViewItem grpvwitem = new Syncfusion.Windows.Forms.Tools.GroupViewItem();
            grpvwitem.Text = "New Item";
            grpvwitem.ImageIndex = 0;
            this.gvMain.GroupViewItems.Add(grpvwitem);

            ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] { "GroupViewItemAdded", "Newly Added Item :" + this.gvModes.GroupViewItems[this.gvModes.GroupViewItems.Count - 1].Text });
            this.listView1.Items.Add(listViewItem1);
        }

        private void gvc_MenuRemoveItem(object sender, EventArgs e)
        {
            int nitem = this.gvMain.ContextMenuItem;
            if ((nitem >= 0) && (nitem < this.gvMain.GroupViewItems.Count))
            {
                Syncfusion.Windows.Forms.Tools.GroupViewItem grpvwitem = this.gvMain.GroupViewItems[nitem];
                this.gvMain.GroupViewItems.Remove(grpvwitem);
                ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] { "GroupViewItemRemoved", "Deleted Item :" + grpvwitem.Text });
                this.listView1.Items.Add(listViewItem1);
            }
        }

        private void gvc_MenuRenameItem(object sender, EventArgs e)
        {
            int nitem = this.gvMain.ContextMenuItem;
            if ((nitem >= 0) && (nitem < this.gvMain.GroupViewItems.Count))
                this.gvMain.InplaceRenameItem(nitem);
            ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] { "GroupViewItemRenaming" });
            this.listView1.Items.Add(listViewItem1);
        }
        private void gvc_MenuListView(object sender, EventArgs e)
        {
            this.cbFlowView.Checked = !this.cbFlowView.Checked;
        }

        private void gvc_MenuMoveUpDown(object sender, EventArgs e)
        {
            BarItem item = sender as BarItem;
            if (item.Text == "Move &Up")
                this.gvMain.SelectedItem = this.gvMain.SelectedItem - 1;
            else
                this.gvMain.SelectedItem = this.gvMain.SelectedItem + 1;
        }

        private void gvc_ThemeDrawing(object sender, EventArgs e)
        {
            BarItem item = sender as BarItem;
            if (item.Checked == false)
            {
                this.gvMain.ThemesEnabled = true;
                this.cbThemesEnabled.Checked = true;
            }
            else
            {
                this.gvMain.ThemesEnabled = false;
                this.cbThemesEnabled.Checked = false;
            }
        }
        #endregion
        #endregion

        #region Groupview properties

        /// <summary>
        /// GroupView Style
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbStyle.SelectedIndex == 0)
                this.gvMain.Style = Syncfusion.Windows.Forms.Appearance.Default;
            else if (this.cmbStyle.SelectedIndex == 1)
                this.gvMain.Style = Syncfusion.Windows.Forms.Appearance.Metro;
            else if (this.cmbStyle.SelectedIndex == 2)
            {
                this.gvMain.Style = Syncfusion.Windows.Forms.Appearance.Office2016;
                this.gvMain.Office2016ColorScheme = Syncfusion.Windows.Forms.Tools.GroupViewOffice2016ColorScheme.Colorful;
            }
            else if (this.cmbStyle.SelectedIndex == 3)
            {
                this.gvMain.Style = Syncfusion.Windows.Forms.Appearance.Office2016;
                this.gvMain.Office2016ColorScheme = Syncfusion.Windows.Forms.Tools.GroupViewOffice2016ColorScheme.White;
            }
            else if (this.cmbStyle.SelectedIndex == 4)
            {
                this.gvMain.Style = Syncfusion.Windows.Forms.Appearance.Office2016;
                this.gvMain.Office2016ColorScheme = Syncfusion.Windows.Forms.Tools.GroupViewOffice2016ColorScheme.DarkGray;
            }
            else if (this.cmbStyle.SelectedIndex == 5)
            {
                this.gvMain.Style = Syncfusion.Windows.Forms.Appearance.Office2016;
                this.gvMain.Office2016ColorScheme = Syncfusion.Windows.Forms.Tools.GroupViewOffice2016ColorScheme.Black;
            }
            UpdateGroupViewStylesforOffice2016Themes();
        }



        private void cpBackColor_ColorSelected(object sender, EventArgs e)
        {
            this.gvMain.BackColor = cpBackColor.SelectedColor;
        }



        private void cmbGVBorder_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.gvMain.BorderStyle = (BorderStyle)Enum.Parse(typeof(BorderStyle), this.cmbGVBorder.SelectedItem.ToString(), true);
        }

        private void cbButtonView_CheckedChanged(object sender, EventArgs e)
        {
            this.gvMain.ButtonView = cbButtonView.Checked;
        }

        private void cbHighightText_CheckedChanged(object sender, EventArgs e)
        {
            this.gvMain.HighlightText = cbHighightText.Checked;
            this.cbButtonView.Enabled = cbHighightText.Checked;
        }

        private void nUDHighlightOffset_ValueChanged(object sender, EventArgs e)
        {
            this.gvMain.HighlightTextOffset = new Point((int)this.nUDHighlightOffset.Value);
        }

        private void nUDSelectingOffset_ValueChanged(object sender, EventArgs e)
        {
            this.gvMain.SelectingTextOffset = new Point((int)this.nUDSelectingOffset.Value);
        }

        private void nUDSelectedOffset_ValueChanged(object sender, EventArgs e)
        {
            this.gvMain.SelectedTextOffset = new Point((int)this.nUDSelectedOffset.Value);
        }

        private void nUDSelectedHighlightOffset_ValueChanged(object sender, EventArgs e)
        {
            this.gvMain.SelectedHighlightTextOffset = new Point((int)this.nUDSelectedHighlightOffset.Value);
        }

        private void cbFlowView_CheckedChanged(object sender, EventArgs e)
        {
            this.gvMain.FlowView = this.cbFlowView.Checked;
        }

        private void nUDTextSpacing_ValueChanged(object sender, EventArgs e)
        {
            this.gvMain.TextSpacing = (int)this.nUDTextSpacing.Value;
        }

        private void cbTextUnderline_CheckedChanged(object sender, EventArgs e)
        {
            this.gvMain.TextUnderline = cbTextUnderline.Checked;
        }

        private void cbTextWrap_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTextWrap.Checked)
            {
                this.gvMain.TextWrap = true;
                this.gvMain.Width = 125;
            }
            else
            {
                this.gvMain.TextWrap = false;
                this.gvMain.Width = 168;
            }
        }
        private void cpHighlightText_ColorSelected(object sender, EventArgs e)
        {
            this.gvMain.HighlightTextColor = cpHighlightText.SelectedColor;
        }

        private void cpHighlightItem_ColorSelected(object sender, EventArgs e)
        {
            this.gvMain.HighlightItemColor = cpHighlightItem.SelectedColor;
        }

        private void cpSelectedHlText_ColorSelected_1(object sender, EventArgs e)
        {
            this.gvMain.SelectedHighlightTextColor = cpSelectedHlText.SelectedColor;
        }

        private void cpselectedHlItem_ColorSelected(object sender, EventArgs e)
        {
            this.gvMain.SelectedHighlightItemColor = cpselectedHlItem.SelectedColor;
        }
        private void cpSelectedTextColor_ColorSelected(object sender, EventArgs e)
        {
            this.gvMain.SelectedTextColor = cpSelectedTextColor.SelectedColor;
        }
        private void cpSelectedItemColor_ColorSelected(object sender, EventArgs e)
        {
            this.gvMain.SelectedItemColor = this.cpSelectedItemColor.SelectedColor;
        }
        private void cbToolTips_CheckedChanged(object sender, EventArgs e)
        {
            this.gvMain.ShowToolTips = cbToolTips.Checked;
        }
        private void cbFlowViewItemText_CheckedChanged(object sender, EventArgs e)
        {
            this.gvMain.ShowFlowViewItemText = cbFlowViewItemText.Checked;
        }

        private void numericUpDownExt1_ValueChanged(object sender, EventArgs e)
        {
            this.gvMain.ImageSpacing = (int)this.numericUpDownExt1.Value;
        }

        private void cbIntegratedScrolling_CheckedChanged(object sender, EventArgs e)
        {
            this.gvMain.IntegratedScrolling = !this.cbIntegratedScrolling.Checked;
        }

        private void cmbOrientation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbOrientation.SelectedIndex == 0)
                this.gvMain.Orientation = GroupViewOrientation.Horizontal;
            else
                this.gvMain.Orientation = GroupViewOrientation.Vertical;
        }

        private void cbThemesEnabled_CheckedChanged(object sender, EventArgs e)
        {
            this.gvMain.ThemesEnabled = cbThemesEnabled.Checked;
        }


        //Code to make the Custom GroupView scroll up and down.
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval >= 100 && timer1.Interval <= 1100)
            {
                this.timer1.Interval = timer1.Interval + 50;
            }
            if (timer1.Interval >= 100 && timer1.Interval < 600)
            {
                this.gvFeatures.ScrollGroupView(true);

            }
            if (timer1.Interval > 600 && timer1.Interval < 1200)
            {
                this.gvFeatures.ScrollGroupView(false);

            }
            if (timer1.Interval >= 1100)
            {
                this.timer1.Interval = 100;
            }

        }

        private void cbHighlightImage_CheckedChanged(object sender, EventArgs e)
        {
            this.gvMain.HighlightImage = cbHighlightImage.Checked;
        }

        private void groupView1_GroupViewItemHighlighted(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
        }

        private void groupView1_MouseLeave(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            this.listView1.Items.Clear();
        }

        #endregion

        private void cbHighightText_CheckStateChanged(object sender, EventArgs e)
        {

        }
        private void UpdateGroupViewStylesforOffice2016Themes()
        {
            LockWindowUpdate(this.Handle);

            if (this.gvMain.Style == Syncfusion.Windows.Forms.Appearance.Default || this.gvMain.Style == Syncfusion.Windows.Forms.Appearance.Metro)
            {
                this.BackColor = System.Drawing.Color.White;
                this.ForeColor = ColorTranslator.FromHtml("#262626");
                this.CaptionBarColor = System.Drawing.Color.White;
                this.CaptionForeColor = ColorTranslator.FromHtml("#343434");
                this.label1.ForeColor = System.Drawing.Color.Black;
                this.label2.ForeColor = System.Drawing.Color.Black;
                this.label3.ForeColor = System.Drawing.Color.Black;
                this.label5.ForeColor = System.Drawing.Color.Black;
                this.label6.ForeColor = System.Drawing.Color.Black;
                this.label7.ForeColor = System.Drawing.Color.Black;
                this.label9.ForeColor = System.Drawing.Color.Black;
                this.label10.ForeColor = System.Drawing.Color.Black;
                this.label11.ForeColor = System.Drawing.Color.Black;
                this.label12.ForeColor = System.Drawing.Color.Black;
                this.label13.ForeColor = System.Drawing.Color.Black;
                this.label14.ForeColor = System.Drawing.Color.Black;
                this.label15.ForeColor = System.Drawing.Color.Black;
                this.label16.ForeColor = System.Drawing.Color.Black;
                this.label17.ForeColor = System.Drawing.Color.Black;
                this.label18.ForeColor = System.Drawing.Color.Black;
                this.label19.ForeColor = System.Drawing.Color.Black;
                this.label20.ForeColor = System.Drawing.Color.Black;
                this.label22.ForeColor = System.Drawing.Color.Black;
                this.label41.ForeColor = System.Drawing.Color.Black;
                this.label35.ForeColor = System.Drawing.Color.Black;
                this.label40.ForeColor = System.Drawing.Color.Black;
                this.richTextBox1.ForeColor = System.Drawing.Color.Black;
                this.listView1.ForeColor = System.Drawing.Color.Black;

                this.panel1.BackColor = System.Drawing.Color.White;
                this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
                this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
                this.panel4.BackColor = System.Drawing.Color.White;
                this.panel5.BackColor = System.Drawing.Color.White;
                this.panel6.BackColor = System.Drawing.Color.White;
                this.panel7.BackColor = System.Drawing.Color.White;
                this.panel8.BackColor = System.Drawing.Color.White;
                this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
                this.richTextBox1.BackColor = System.Drawing.Color.White;
                this.listView1.BackColor = System.Drawing.Color.White;

                this.gradientPanel1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.gradientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
                this.gradientPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(253)))));
                this.gradientPanel4.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.gradientPanel5.BackColor = System.Drawing.Color.White;
                this.gradientPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(253)))));
                this.gradientPanel7.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.gradientPanelExt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(254)))));
                this.gpVSBehavior.BackColor = System.Drawing.Color.White;
                this.tabPageAdv1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.tabPageAdv2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.tabPageAdv3.BackColor = ColorTranslator.FromHtml("#ffffff");

                this.cbButtonView.Style = CheckBoxAdvStyle.Metro;
                this.cbFlowView.Style = CheckBoxAdvStyle.Metro;
                this.cbHighightText.Style = CheckBoxAdvStyle.Metro;
                this.cbHighlightImage.Style = CheckBoxAdvStyle.Metro;
                this.cbIntegratedScrolling.Style = CheckBoxAdvStyle.Metro;
                this.cbTextUnderline.Style = CheckBoxAdvStyle.Metro;
                this.cbTextWrap.Style = CheckBoxAdvStyle.Metro;
                this.cbThemesEnabled.Style = CheckBoxAdvStyle.Metro;
                this.cbToolTips.Style = CheckBoxAdvStyle.Metro;
                this.cbFlowViewItemText.Style = CheckBoxAdvStyle.Metro;

                this.cmbGVBorder.Style = VisualStyle.Metro;
                this.cmbOrientation.Style = VisualStyle.Metro;
                this.cmbStyle.Style = VisualStyle.Metro;

                this.nUDHighlightOffset.VisualStyle = VisualStyle.OfficeXP;
                this.nUDSelectedHighlightOffset.VisualStyle = VisualStyle.OfficeXP;
                this.nUDSelectedOffset.VisualStyle = VisualStyle.OfficeXP;
                this.nUDSelectingOffset.VisualStyle = VisualStyle.OfficeXP;
                this.nUDTextSpacing.VisualStyle = VisualStyle.OfficeXP;
                this.numericUpDownExt1.VisualStyle = VisualStyle.OfficeXP;

                this.button1.Appearance = ButtonAppearance.Metro;
                this.rbLargeIcons.Style = RadioButtonAdvStyle.Metro;
                this.rbMessengerList.Style = RadioButtonAdvStyle.Metro;
                this.rbO2KFolderBrowser.Style = RadioButtonAdvStyle.Metro;
                this.rbOXPFolderBrowser.Style = RadioButtonAdvStyle.Metro;
                this.rbSmallIcons.Style = RadioButtonAdvStyle.Metro;
                this.rbVSNETFlow.Style = RadioButtonAdvStyle.Metro;
                this.rbVSNETList.Style = RadioButtonAdvStyle.Metro;
                this.rbXPTaskBar.Style = RadioButtonAdvStyle.Metro;

                this.cpBackColor.Appearance = ButtonAppearance.Metro;
                this.cpHighlightItem.Appearance = ButtonAppearance.Metro;
                this.cpHighlightText.Appearance = ButtonAppearance.Metro;
                this.cpselectedHlItem.Appearance = ButtonAppearance.Metro;
                this.cpSelectedHlText.Appearance = ButtonAppearance.Metro;
                this.cpSelectedItemColor.Appearance = ButtonAppearance.Metro;
                this.cpSelectedTextColor.Appearance = ButtonAppearance.Metro;
                this.scrollersFrame1.VisualStyle = ScrollBarCustomDrawStyles.Metro;

                this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
                if (gvMain.Style == Syncfusion.Windows.Forms.Appearance.Default)
                {
                    this.gvModes.Style = Syncfusion.Windows.Forms.Appearance.Default;
                    this.gvFeatures.Style = Syncfusion.Windows.Forms.Appearance.Default;
                }
                else
                {
                    this.gvModes.Style = Syncfusion.Windows.Forms.Appearance.Metro;
                    this.gvFeatures.Style = Syncfusion.Windows.Forms.Appearance.Metro;
                }

                this.ShowIcon = true;
                this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
                this.gradientPanel1.BorderColor = Color.Silver;
                this.gradientPanel2.BorderColor = Color.Silver;
                this.gradientPanel3.BorderColor = Color.Silver;
                this.gradientPanel4.BorderColor = Color.Silver;
                this.gradientPanel5.BorderColor = Color.Silver;
                this.gradientPanel6.BorderColor = Color.Silver;
                this.gradientPanel7.BorderColor = Color.Silver;
                this.gpVSBehavior.BorderColor = Color.Silver;

            }
            else if (this.gvMain.Style == Syncfusion.Windows.Forms.Appearance.Office2016)
            {
                if (this.gvMain.Office2016ColorScheme == GroupViewOffice2016ColorScheme.Colorful)
                {
                    this.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.CaptionBarColor = ColorTranslator.FromHtml("#0173c7");
                    this.CaptionForeColor = ColorTranslator.FromHtml("#ffffff");
                    this.label1.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label2.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label3.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label5.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label6.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label7.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label9.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label10.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label11.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label12.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label13.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label14.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label15.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label16.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label17.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label18.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label19.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label20.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label22.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label41.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label35.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label40.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.richTextBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.listView1.ForeColor = ColorTranslator.FromHtml("#262626");

                    this.panel1.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel2.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel3.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel4.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel5.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel6.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel7.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel8.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel15.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.richTextBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.listView1.BackColor = ColorTranslator.FromHtml("#ffffff");

                    this.gradientPanel1.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.gradientPanel2.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.gradientPanel3.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.gradientPanel4.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.gradientPanel5.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.gradientPanel6.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.gradientPanel7.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.gradientPanelExt1.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.gpVSBehavior.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.tabPageAdv1.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.tabPageAdv2.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.tabPageAdv3.BackColor = ColorTranslator.FromHtml("#ffffff");


                    this.cbButtonView.Style = CheckBoxAdvStyle.Office2016Colorful;
                    this.cbFlowView.Style = CheckBoxAdvStyle.Office2016Colorful;
                    this.cbHighightText.Style = CheckBoxAdvStyle.Office2016Colorful;
                    this.cbHighlightImage.Style = CheckBoxAdvStyle.Office2016Colorful;
                    this.cbIntegratedScrolling.Style = CheckBoxAdvStyle.Office2016Colorful;
                    this.cbTextUnderline.Style = CheckBoxAdvStyle.Office2016Colorful;
                    this.cbTextWrap.Style = CheckBoxAdvStyle.Office2016Colorful;
                    this.cbThemesEnabled.Style = CheckBoxAdvStyle.Office2016Colorful;
                    this.cbToolTips.Style = CheckBoxAdvStyle.Office2016Colorful;

                    this.cmbGVBorder.Style = VisualStyle.Office2016Colorful;
                    this.cmbOrientation.Style = VisualStyle.Office2016Colorful;
                    this.cmbStyle.Style = VisualStyle.Office2016Colorful;
                    this.nUDHighlightOffset.VisualStyle = VisualStyle.Office2016Colorful;
                    this.nUDSelectedHighlightOffset.VisualStyle = VisualStyle.Office2016Colorful;
                    this.nUDSelectedOffset.VisualStyle = VisualStyle.Office2016Colorful;
                    this.nUDSelectingOffset.VisualStyle = VisualStyle.Office2016Colorful;
                    this.nUDTextSpacing.VisualStyle = VisualStyle.Office2016Colorful;
                    this.numericUpDownExt1.VisualStyle = VisualStyle.Office2016Colorful;
                    this.button1.Appearance = ButtonAppearance.Office2016Colorful;
                    this.gvModes.Style = Syncfusion.Windows.Forms.Appearance.Office2016;
                    this.gvModes.Office2016ColorScheme = GroupViewOffice2016ColorScheme.Colorful;
                    this.gvFeatures.Style = Syncfusion.Windows.Forms.Appearance.Office2016;
                    this.gvModes.Office2016ColorScheme = GroupViewOffice2016ColorScheme.Colorful;
                    this.scrollersFrame1.VisualStyle = ScrollBarCustomDrawStyles.Office2016;
                    this.scrollersFrame1.Office2016ColorScheme = ScrollBarOffice2016ColorScheme.Colorful;

                    this.rbLargeIcons.Style = RadioButtonAdvStyle.Office2016Colorful;
                    this.rbMessengerList.Style = RadioButtonAdvStyle.Office2016Colorful;
                    this.rbO2KFolderBrowser.Style = RadioButtonAdvStyle.Office2016Colorful;
                    this.rbOXPFolderBrowser.Style = RadioButtonAdvStyle.Office2016Colorful;
                    this.rbSmallIcons.Style = RadioButtonAdvStyle.Office2016Colorful;
                    this.rbVSNETFlow.Style = RadioButtonAdvStyle.Office2016Colorful;
                    this.rbVSNETList.Style = RadioButtonAdvStyle.Office2016Colorful;
                    this.rbXPTaskBar.Style = RadioButtonAdvStyle.Office2016Colorful;

                    this.cpBackColor.Appearance = ButtonAppearance.Office2016Colorful;
                    this.cpHighlightItem.Appearance = ButtonAppearance.Office2016Colorful;
                    this.cpHighlightText.Appearance = ButtonAppearance.Office2016Colorful;
                    this.cpselectedHlItem.Appearance = ButtonAppearance.Office2016Colorful;
                    this.cpSelectedHlText.Appearance = ButtonAppearance.Office2016Colorful;
                    this.cpSelectedItemColor.Appearance = ButtonAppearance.Office2016Colorful;
                    this.cpSelectedTextColor.Appearance = ButtonAppearance.Office2016Colorful;
                    this.cbFlowViewItemText.Style = CheckBoxAdvStyle.Office2016Colorful;

                    this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Colorful);
                    this.ShowIcon = false;
                    this.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                    this.gradientPanel1.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                    this.gradientPanel2.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                    this.gradientPanel3.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                    this.gradientPanel4.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                    this.gradientPanel5.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                    this.gradientPanel6.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                    this.gradientPanel7.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                    this.gpVSBehavior.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                }

                if (this.gvMain.Office2016ColorScheme == GroupViewOffice2016ColorScheme.White)
                {
                    this.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.CaptionBarColor = ColorTranslator.FromHtml("#ffffff");
                    this.CaptionForeColor = ColorTranslator.FromHtml("#262626");
                    this.label1.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label2.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label3.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label5.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label6.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label7.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label9.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label10.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label11.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label12.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label13.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label14.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label15.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label16.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label17.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label18.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label19.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label20.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label22.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label41.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label35.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label40.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.richTextBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.listView1.ForeColor = ColorTranslator.FromHtml("#262626");


                    this.panel1.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel2.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel3.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel4.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel5.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel6.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel7.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel8.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel15.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.richTextBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.listView1.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.gradientPanel1.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.gradientPanel2.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.gradientPanel3.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.gradientPanel4.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.gradientPanel5.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.gradientPanel6.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.gradientPanel7.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.gradientPanelExt1.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.gpVSBehavior.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.tabPageAdv1.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.tabPageAdv2.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.tabPageAdv3.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.cbButtonView.Style = CheckBoxAdvStyle.Office2016White;
                    this.cbFlowView.Style = CheckBoxAdvStyle.Office2016White;
                    this.cbHighightText.Style = CheckBoxAdvStyle.Office2016White;
                    this.cbHighlightImage.Style = CheckBoxAdvStyle.Office2016White;
                    this.cbIntegratedScrolling.Style = CheckBoxAdvStyle.Office2016White;
                    this.cbTextUnderline.Style = CheckBoxAdvStyle.Office2016White;
                    this.cbTextWrap.Style = CheckBoxAdvStyle.Office2016White;
                    this.cbThemesEnabled.Style = CheckBoxAdvStyle.Office2016White;
                    this.cbToolTips.Style = CheckBoxAdvStyle.Office2016White;

                    this.cmbGVBorder.Style = VisualStyle.Office2016White;
                    this.cmbOrientation.Style = VisualStyle.Office2016White;
                    this.cmbStyle.Style = VisualStyle.Office2016White;
                    this.nUDHighlightOffset.VisualStyle = VisualStyle.Office2016White;
                    this.nUDSelectedHighlightOffset.VisualStyle = VisualStyle.Office2016White;
                    this.nUDSelectedOffset.VisualStyle = VisualStyle.Office2016White;
                    this.nUDSelectingOffset.VisualStyle = VisualStyle.Office2016White;
                    this.nUDTextSpacing.VisualStyle = VisualStyle.Office2016White;
                    this.numericUpDownExt1.VisualStyle = VisualStyle.Office2016White;
                    this.button1.Appearance = ButtonAppearance.Office2016White;
                    this.gvModes.Style = Syncfusion.Windows.Forms.Appearance.Office2016;
                    this.gvModes.Office2016ColorScheme = GroupViewOffice2016ColorScheme.White;
                    this.gvFeatures.Style = Syncfusion.Windows.Forms.Appearance.Office2016;
                    this.gvFeatures.Office2016ColorScheme = GroupViewOffice2016ColorScheme.White;
                    this.rbLargeIcons.Style = RadioButtonAdvStyle.Office2016White;
                    this.rbMessengerList.Style = RadioButtonAdvStyle.Office2016White;
                    this.rbO2KFolderBrowser.Style = RadioButtonAdvStyle.Office2016White;
                    this.rbOXPFolderBrowser.Style = RadioButtonAdvStyle.Office2016White;
                    this.rbSmallIcons.Style = RadioButtonAdvStyle.Office2016White;
                    this.rbVSNETFlow.Style = RadioButtonAdvStyle.Office2016White;
                    this.rbVSNETList.Style = RadioButtonAdvStyle.Office2016White;
                    this.rbXPTaskBar.Style = RadioButtonAdvStyle.Office2016White;
                    this.cpBackColor.Appearance = ButtonAppearance.Office2016White;
                    this.cpHighlightItem.Appearance = ButtonAppearance.Office2016White;
                    this.cpHighlightText.Appearance = ButtonAppearance.Office2016White;
                    this.cpselectedHlItem.Appearance = ButtonAppearance.Office2016White;
                    this.cpSelectedHlText.Appearance = ButtonAppearance.Office2016White;
                    this.cpSelectedItemColor.Appearance = ButtonAppearance.Office2016White;
                    this.cpSelectedTextColor.Appearance = ButtonAppearance.Office2016White;
                    this.cbFlowViewItemText.Style = CheckBoxAdvStyle.Office2016White;
                    this.scrollersFrame1.VisualStyle = ScrollBarCustomDrawStyles.Office2016;
                    this.scrollersFrame1.Office2016ColorScheme = ScrollBarOffice2016ColorScheme.White;
                    this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016White);
                    this.ShowIcon = false;
                    this.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                    this.gradientPanel1.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                    this.gradientPanel2.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                    this.gradientPanel3.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                    this.gradientPanel4.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                    this.gradientPanel5.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                    this.gradientPanel6.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                    this.gradientPanel7.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                    this.gpVSBehavior.BorderColor = ColorTranslator.FromHtml("#c5c5c5");

                }
                else if (this.gvMain.Office2016ColorScheme == GroupViewOffice2016ColorScheme.Black)
                {
                    this.BackColor = ColorTranslator.FromHtml("#262626");
                    this.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.CaptionBarColor = ColorTranslator.FromHtml("#363636");
                    this.CaptionForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label5.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label6.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label7.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label9.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label10.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label11.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label12.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label13.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label14.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label15.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label16.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label17.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label18.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label19.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label20.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label22.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label41.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label40.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label35.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.richTextBox1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.listView1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");

                    this.panel1.BackColor = ColorTranslator.FromHtml("#262626");
                    this.panel2.BackColor = ColorTranslator.FromHtml("#262626");
                    this.panel3.BackColor = ColorTranslator.FromHtml("#262626");
                    this.panel4.BackColor = ColorTranslator.FromHtml("#262626");
                    this.panel5.BackColor = ColorTranslator.FromHtml("#262626");
                    this.panel6.BackColor = ColorTranslator.FromHtml("#262626");
                    this.panel7.BackColor = ColorTranslator.FromHtml("#262626");
                    this.panel8.BackColor = ColorTranslator.FromHtml("#262626");
                    this.panel15.BackColor = ColorTranslator.FromHtml("#262626");
                    this.richTextBox1.BackColor = ColorTranslator.FromHtml("#262626");
                    this.listView1.BackColor = ColorTranslator.FromHtml("#262626");

                    this.gradientPanel1.BackColor = ColorTranslator.FromHtml("#262626");
                    this.gradientPanel2.BackColor = ColorTranslator.FromHtml("#262626");
                    this.gradientPanel3.BackColor = ColorTranslator.FromHtml("#262626");
                    this.gradientPanel4.BackColor = ColorTranslator.FromHtml("#262626");
                    this.gradientPanel5.BackColor = ColorTranslator.FromHtml("#262626");
                    this.gradientPanel6.BackColor = ColorTranslator.FromHtml("#262626");
                    this.gradientPanel7.BackColor = ColorTranslator.FromHtml("#262626");
                    this.gradientPanelExt1.BackColor = ColorTranslator.FromHtml("#262626");
                    this.gpVSBehavior.BackColor = ColorTranslator.FromHtml("#262626");
                    this.tabPageAdv1.BackColor = ColorTranslator.FromHtml("#262626");
                    this.tabPageAdv2.BackColor = ColorTranslator.FromHtml("#262626");
                    this.tabPageAdv3.BackColor = ColorTranslator.FromHtml("#262626");


                    this.cbButtonView.Style = CheckBoxAdvStyle.Office2016Black;
                    this.cbFlowView.Style = CheckBoxAdvStyle.Office2016Black;
                    this.cbHighightText.Style = CheckBoxAdvStyle.Office2016Black;
                    this.cbHighlightImage.Style = CheckBoxAdvStyle.Office2016Black;
                    this.cbIntegratedScrolling.Style = CheckBoxAdvStyle.Office2016Black;
                    this.cbTextUnderline.Style = CheckBoxAdvStyle.Office2016Black;
                    this.cbTextWrap.Style = CheckBoxAdvStyle.Office2016Black;
                    this.cbThemesEnabled.Style = CheckBoxAdvStyle.Office2016Black;
                    this.cbToolTips.Style = CheckBoxAdvStyle.Office2016Black;

                    this.cmbGVBorder.Style = VisualStyle.Office2016Black;
                    this.cmbOrientation.Style = VisualStyle.Office2016Black;
                    this.cmbStyle.Style = VisualStyle.Office2016Black;
                    this.nUDHighlightOffset.VisualStyle = VisualStyle.Office2016Black;
                    this.nUDSelectedHighlightOffset.VisualStyle = VisualStyle.Office2016Black;
                    this.nUDSelectedOffset.VisualStyle = VisualStyle.Office2016Black;
                    this.nUDSelectingOffset.VisualStyle = VisualStyle.Office2016Black;
                    this.nUDTextSpacing.VisualStyle = VisualStyle.Office2016Black;
                    this.numericUpDownExt1.VisualStyle = VisualStyle.Office2016Black;
                    this.button1.Appearance = ButtonAppearance.Office2016Black;
                    this.gvModes.Style = Syncfusion.Windows.Forms.Appearance.Office2016;
                    this.gvModes.Office2016ColorScheme = GroupViewOffice2016ColorScheme.Black;
                    this.rbLargeIcons.Style = RadioButtonAdvStyle.Office2016Black;
                    this.rbMessengerList.Style = RadioButtonAdvStyle.Office2016Black;
                    this.rbO2KFolderBrowser.Style = RadioButtonAdvStyle.Office2016Black;
                    this.rbOXPFolderBrowser.Style = RadioButtonAdvStyle.Office2016Black;
                    this.rbSmallIcons.Style = RadioButtonAdvStyle.Office2016Black;
                    this.rbVSNETFlow.Style = RadioButtonAdvStyle.Office2016Black;
                    this.rbVSNETList.Style = RadioButtonAdvStyle.Office2016Black;
                    this.rbXPTaskBar.Style = RadioButtonAdvStyle.Office2016Black;
                    this.gvFeatures.Style = Syncfusion.Windows.Forms.Appearance.Office2016;
                    this.gvFeatures.Office2016ColorScheme = GroupViewOffice2016ColorScheme.Black;
                    this.cpBackColor.Appearance = ButtonAppearance.Office2016Black;
                    this.cpHighlightItem.Appearance = ButtonAppearance.Office2016Black;
                    this.cpHighlightText.Appearance = ButtonAppearance.Office2016Black;
                    this.cpselectedHlItem.Appearance = ButtonAppearance.Office2016Black;
                    this.cpSelectedHlText.Appearance = ButtonAppearance.Office2016Black;
                    this.cpSelectedItemColor.Appearance = ButtonAppearance.Office2016Black;
                    this.cpSelectedTextColor.Appearance = ButtonAppearance.Office2016Black;
                    this.cbFlowViewItemText.Style = CheckBoxAdvStyle.Office2016Black;
                    this.scrollersFrame1.VisualStyle = ScrollBarCustomDrawStyles.Office2016;
                    this.scrollersFrame1.Office2016ColorScheme = ScrollBarOffice2016ColorScheme.Black;
                    this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Black);
                    this.ShowIcon = false;
                    this.BorderColor = ColorTranslator.FromHtml("#363636");
                    this.gradientPanel1.BorderColor = ColorTranslator.FromHtml("#363636");
                    this.gradientPanel2.BorderColor = ColorTranslator.FromHtml("#363636");
                    this.gradientPanel3.BorderColor = ColorTranslator.FromHtml("#363636");
                    this.gradientPanel4.BorderColor = ColorTranslator.FromHtml("#363636");
                    this.gradientPanel5.BorderColor = ColorTranslator.FromHtml("#363636");
                    this.gradientPanel6.BorderColor = ColorTranslator.FromHtml("#363636");
                    this.gradientPanel7.BorderColor = ColorTranslator.FromHtml("#363636");
                    this.gpVSBehavior.BorderColor = ColorTranslator.FromHtml("#363636");
                }
                else if (this.gvMain.Office2016ColorScheme == GroupViewOffice2016ColorScheme.DarkGray)
                {
                    this.BackColor = ColorTranslator.FromHtml("#666666");
                    this.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.CaptionBarColor = ColorTranslator.FromHtml("#505050");
                    this.CaptionForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label5.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label6.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label7.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label9.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label10.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label11.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label12.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label13.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label14.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label15.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label16.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label17.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label18.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label19.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label20.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label22.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label41.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label40.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label35.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.richTextBox1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.listView1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");

                    this.panel1.BackColor = ColorTranslator.FromHtml("#666666");
                    this.panel2.BackColor = ColorTranslator.FromHtml("#666666");
                    this.panel3.BackColor = ColorTranslator.FromHtml("#666666");
                    this.panel4.BackColor = ColorTranslator.FromHtml("#666666");
                    this.panel5.BackColor = ColorTranslator.FromHtml("#666666");
                    this.panel6.BackColor = ColorTranslator.FromHtml("#666666");
                    this.panel7.BackColor = ColorTranslator.FromHtml("#666666");
                    this.panel8.BackColor = ColorTranslator.FromHtml("#666666");
                    this.panel15.BackColor = ColorTranslator.FromHtml("#666666");
                    this.richTextBox1.BackColor = ColorTranslator.FromHtml("#666666");
                    this.listView1.BackColor = ColorTranslator.FromHtml("#666666");

                    this.gradientPanel1.BackColor = ColorTranslator.FromHtml("#666666");
                    this.gradientPanel2.BackColor = ColorTranslator.FromHtml("#666666");
                    this.gradientPanel3.BackColor = ColorTranslator.FromHtml("#666666");
                    this.gradientPanel4.BackColor = ColorTranslator.FromHtml("#666666");
                    this.gradientPanel5.BackColor = ColorTranslator.FromHtml("#666666");
                    this.gradientPanel6.BackColor = ColorTranslator.FromHtml("#666666");
                    this.gradientPanel7.BackColor = ColorTranslator.FromHtml("#666666");
                    this.gradientPanelExt1.BackColor = ColorTranslator.FromHtml("#666666");
                    this.gpVSBehavior.BackColor = ColorTranslator.FromHtml("#666666");
                    this.tabPageAdv1.BackColor = ColorTranslator.FromHtml("#666666");
                    this.tabPageAdv2.BackColor = ColorTranslator.FromHtml("#666666");
                    this.tabPageAdv3.BackColor = ColorTranslator.FromHtml("#666666");
                    this.cbButtonView.Style = CheckBoxAdvStyle.Office2016DarkGray;
                    this.cbFlowView.Style = CheckBoxAdvStyle.Office2016DarkGray;
                    this.cbHighightText.Style = CheckBoxAdvStyle.Office2016DarkGray;
                    this.cbHighlightImage.Style = CheckBoxAdvStyle.Office2016DarkGray;
                    this.cbIntegratedScrolling.Style = CheckBoxAdvStyle.Office2016DarkGray;
                    this.cbTextUnderline.Style = CheckBoxAdvStyle.Office2016DarkGray;
                    this.cbTextWrap.Style = CheckBoxAdvStyle.Office2016DarkGray;
                    this.cbThemesEnabled.Style = CheckBoxAdvStyle.Office2016DarkGray;
                    this.cbToolTips.Style = CheckBoxAdvStyle.Office2016DarkGray;

                    this.cmbGVBorder.Style = VisualStyle.Office2016DarkGray;
                    this.cmbOrientation.Style = VisualStyle.Office2016DarkGray;
                    this.cmbStyle.Style = VisualStyle.Office2016DarkGray;
                    this.nUDHighlightOffset.VisualStyle = VisualStyle.Office2016DarkGray;
                    this.nUDSelectedHighlightOffset.VisualStyle = VisualStyle.Office2016DarkGray;
                    this.nUDSelectedOffset.VisualStyle = VisualStyle.Office2016DarkGray;
                    this.nUDSelectingOffset.VisualStyle = VisualStyle.Office2016DarkGray;
                    this.nUDTextSpacing.VisualStyle = VisualStyle.Office2016DarkGray;
                    this.numericUpDownExt1.VisualStyle = VisualStyle.Office2016DarkGray;
                    this.button1.Appearance = ButtonAppearance.Office2016DarkGray;
                    this.gvModes.Style = Syncfusion.Windows.Forms.Appearance.Office2016;
                    this.gvModes.Office2016ColorScheme = GroupViewOffice2016ColorScheme.DarkGray;
                    this.gvFeatures.Style = Syncfusion.Windows.Forms.Appearance.Office2016;
                    this.gvFeatures.Office2016ColorScheme = GroupViewOffice2016ColorScheme.DarkGray;
                    this.rbLargeIcons.Style = RadioButtonAdvStyle.Office2016DarkGray;
                    this.rbMessengerList.Style = RadioButtonAdvStyle.Office2016DarkGray;
                    this.rbO2KFolderBrowser.Style = RadioButtonAdvStyle.Office2016DarkGray;
                    this.rbOXPFolderBrowser.Style = RadioButtonAdvStyle.Office2016DarkGray;
                    this.rbSmallIcons.Style = RadioButtonAdvStyle.Office2016DarkGray;
                    this.rbVSNETFlow.Style = RadioButtonAdvStyle.Office2016DarkGray;
                    this.rbVSNETList.Style = RadioButtonAdvStyle.Office2016DarkGray;
                    this.rbXPTaskBar.Style = RadioButtonAdvStyle.Office2016DarkGray;
                    this.cpBackColor.Appearance = ButtonAppearance.Office2016DarkGray;
                    this.cpHighlightItem.Appearance = ButtonAppearance.Office2016DarkGray;
                    this.cpHighlightText.Appearance = ButtonAppearance.Office2016DarkGray;
                    this.cpselectedHlItem.Appearance = ButtonAppearance.Office2016DarkGray;
                    this.cpSelectedHlText.Appearance = ButtonAppearance.Office2016DarkGray;
                    this.cpSelectedItemColor.Appearance = ButtonAppearance.Office2016DarkGray;
                    this.cpSelectedTextColor.Appearance = ButtonAppearance.Office2016DarkGray;
                    this.cbFlowViewItemText.Style = CheckBoxAdvStyle.Office2016DarkGray;
                    this.scrollersFrame1.VisualStyle = ScrollBarCustomDrawStyles.Office2016;
                    this.scrollersFrame1.Office2016ColorScheme = ScrollBarOffice2016ColorScheme.DarkGray;
                    this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016DarkGray);
                    this.ShowIcon = false;
                    this.BorderColor = ColorTranslator.FromHtml("#444444");
                    this.gradientPanel1.BorderColor = ColorTranslator.FromHtml("#444444");
                    this.gradientPanel2.BorderColor = ColorTranslator.FromHtml("#444444");
                    this.gradientPanel3.BorderColor = ColorTranslator.FromHtml("#444444");
                    this.gradientPanel4.BorderColor = ColorTranslator.FromHtml("#444444");
                    this.gradientPanel5.BorderColor = ColorTranslator.FromHtml("#444444");
                    this.gradientPanel6.BorderColor = ColorTranslator.FromHtml("#444444");
                    this.gradientPanel7.BorderColor = ColorTranslator.FromHtml("#444444");
                    this.gpVSBehavior.BorderColor = ColorTranslator.FromHtml("#444444");
                }
            }
            LockWindowUpdate(IntPtr.Zero);
        }
        #endregion
    }

    #region CustomGroupView
    public class CustomGroupView : GroupView
    {
                   
        public void ScrollGroupView(bool x)
        {
           this.DoScroll(x, false);           
     
        }
    }
    #endregion

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
