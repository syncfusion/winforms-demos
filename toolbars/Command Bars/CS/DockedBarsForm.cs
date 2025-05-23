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

using Syncfusion.Windows.Forms.Tools;
#if NETCORE
using ToolBarButton = System.Windows.Forms.ToolStripButton;
using ToolBar = System.Windows.Forms.ToolStrip;
#else
using ToolBarButton = System.Windows.Forms.ToolBarButton;
using ToolBar = System.Windows.Forms.ToolBar;
#endif

namespace CommandBars
{
    using System;
    using System.Drawing;
    using System.Collections;
    using System.ComponentModel;
    using System.Windows.Forms;
    using System.Data;
    using System.Drawing.Drawing2D;
    using Syncfusion.Windows.Forms;

    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class DockedBarsForm : MetroForm
    {
        private System.Windows.Forms.RichTextBox richTextBox1;
        public Syncfusion.Windows.Forms.Tools.CommandBarController commandBarController1;
        private ComboBoxAdv fontComboBox;
        private ComboBoxAdv fontSizeComboBox;
        private ToolBarButton boldButton;
        private ToolBarButton italicButton;
        private ToolBarButton underLineButton;
        private ToolBarButton laButton;
        private ToolBarButton centerButton;
        private ToolBarButton raButton;
        private System.Windows.Forms.ImageList imageList1;
        private ToolBarButton separator;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Panel panel2;
        private ComboBoxAdv comboBox1;
        private ToolBarButton toolBarButton1;
        private ToolBarButton toolBarButton2;
        private ToolBarButton toolBarButton3;
        private ToolBarButton toolBarButton5;
        private ToolBarButton toolBarButton6;
        private ToolBarButton toolBarButton7;
        private System.Windows.Forms.Panel panel3;
        public Syncfusion.Windows.Forms.Tools.CommandBar commandBarFonts;
        private ToolBar tbFont;
        public Syncfusion.Windows.Forms.Tools.CommandBar commandBarAlign;
        private ToolBar tbAlign;
        public Syncfusion.Windows.Forms.Tools.CommandBar commandBarStandard;
        public Syncfusion.Windows.Forms.Tools.CommandBar commandBarAddress;
        private ToolBar tbStandard;
        private ToolBarButton toolBarButton8;
        private System.Windows.Forms.Panel pnlFonts;
        private System.Windows.Forms.Panel pnlFontsTB;
        private bool initDone = false;
        private Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu popupMenuAddress;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biAddressHome;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biAddressFAQ;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biAddressSales;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biAddressProducts;

        private Size szFontToolBarPanel;
#if !NETCORE
        private System.Windows.Forms.StatusBar statusBar1;
#else
        private System.Windows.Forms.StatusStrip statusBar1;
#endif
        private Syncfusion.Windows.Forms.Tools.XPTaskPane xpTaskPane1;
        private Syncfusion.Windows.Forms.Tools.WizardContainer wizardContainer1;
        private Syncfusion.Windows.Forms.Tools.XPTaskPage xpTaskPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.XPTaskPage xpTaskPage2;
        private CheckBoxAdv checkBox1;
        private ComboBoxAdv styleComboBox;
        private System.Windows.Forms.Label label3;
        private CheckBoxAdv checkBox2;
        private System.Windows.Forms.Panel panel1;
        private RadioButtonAdv AllowFloating;
        private RadioButtonAdv AllowDocking;
        private Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem5;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem6;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem7;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem8;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem9;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem10;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem11;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem5;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem12;
        private Size szFontCommandBarPanelSize;


        public DockedBarsForm()
        {
            // Cache the fully extended sizes of the toolbar and panel controls in the fonts CommandBar.
            // These sizes are used for calculating the toolbar dimensions in the CommandBar.CommandBarStateChanging 
            // and CommandBar.CommandBarStateChanged event handlers
            this.szFontToolBarPanel = new Size(72, 23);
            this.szFontCommandBarPanelSize = new Size(288, 24);

            //
            // Required for Windows Form Designer support.
            //
            InitializeComponent();
#if NETCORE
            ToolStripStatusLabel toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel1.Text = "Ready";
            toolStripStatusLabel1.BackColor = Color.Transparent;
            this.statusBar1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
#endif
            this.MinimumSize = this.Size;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }


            this.commandBarAddress.AllowedDockBorders = Syncfusion.Windows.Forms.Tools.CommandBarDockBorder.Top | Syncfusion.Windows.Forms.Tools.CommandBarDockBorder.Bottom;
            #region Office2003Colors
            Office2003Colors.UpdateMenuColors();
           #endregion
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

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DockedBarsForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.commandBarController1 = new Syncfusion.Windows.Forms.Tools.CommandBarController(this.components);
            this.commandBarFonts = new Syncfusion.Windows.Forms.Tools.CommandBar();
            this.pnlFonts = new System.Windows.Forms.Panel();
            this.fontComboBox = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.fontSizeComboBox = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.pnlFontsTB = new System.Windows.Forms.Panel();
            this.tbFont = new ToolBar();
            this.boldButton = new ToolBarButton();
            this.italicButton = new ToolBarButton();
            this.underLineButton = new ToolBarButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.commandBarAlign = new Syncfusion.Windows.Forms.Tools.CommandBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbAlign = new ToolBar();
            this.laButton = new ToolBarButton();
            this.centerButton = new ToolBarButton();
            this.raButton = new ToolBarButton();
            this.commandBarStandard = new Syncfusion.Windows.Forms.Tools.CommandBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbStandard = new ToolBar();
            this.toolBarButton1 = new ToolBarButton();
            this.toolBarButton2 = new ToolBarButton();
            this.toolBarButton3 = new ToolBarButton();
            this.toolBarButton5 = new ToolBarButton();
            this.toolBarButton6 = new ToolBarButton();
            this.toolBarButton7 = new ToolBarButton();
            this.toolBarButton8 = new ToolBarButton();
            this.commandBarAddress = new Syncfusion.Windows.Forms.Tools.CommandBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.popupMenuAddress = new Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(this.components);
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.biAddressHome = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biAddressFAQ = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biAddressSales = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biAddressProducts = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.separator = new ToolBarButton();
#if !NETCORE
            this.statusBar1 = new System.Windows.Forms.StatusBar();
#else
            this.statusBar1 = new System.Windows.Forms.StatusStrip();
#endif
            this.wizardContainer1 = new Syncfusion.Windows.Forms.Tools.WizardContainer();
            this.AllowFloating = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.AllowDocking = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.checkBox2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.styleComboBox = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.checkBox1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "Menu");
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem9 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem10 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem11 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem12 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarController1)).BeginInit();
            this.commandBarFonts.SuspendLayout();
            this.pnlFonts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeComboBox)).BeginInit();
            this.pnlFontsTB.SuspendLayout();
            this.commandBarAlign.SuspendLayout();
            this.panel3.SuspendLayout();
            this.commandBarStandard.SuspendLayout();
            this.panel2.SuspendLayout();
            this.commandBarAddress.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllowFloating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllowDocking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.SandyBrown;
            this.richTextBox1.HideSelection = false;
            this.richTextBox1.Location = new System.Drawing.Point(0, 81);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(532, 283);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // commandBarController1
            // 
            this.commandBarController1.CommandBars.Add(this.commandBarFonts);
            this.commandBarController1.CommandBars.Add(this.commandBarAlign);
            this.commandBarController1.CommandBars.Add(this.commandBarStandard);
            this.commandBarController1.CommandBars.Add(this.commandBarAddress);
            this.commandBarController1.HostForm = this;
            this.commandBarController1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // commandBarFonts
            // 
            this.commandBarFonts.ChevronColor = System.Drawing.SystemColors.ControlText;
            this.commandBarFonts.Controls.Add(this.pnlFonts);
            this.commandBarFonts.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Top;
            this.commandBarFonts.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.commandBarFonts.HideDropDownButton = true;
            this.commandBarFonts.MaxLength = 300;
            this.commandBarFonts.MinHeight = 26;
            this.commandBarFonts.MinLength = 50;
            this.commandBarFonts.Name = "commandBarFonts";
            this.commandBarFonts.RowIndex = 0;
            this.commandBarFonts.RowOffset = 169;
            this.commandBarFonts.ShowDockModeText = false;
            this.commandBarFonts.TabIndex = 0;
            this.commandBarFonts.TabStop = false;
            this.commandBarFonts.Text = "Fonts";
            this.commandBarFonts.CommandBarStateChanging += new Syncfusion.Windows.Forms.Tools.CommandBarStateChangingEventHandler(this.cbFonts_CommandBarStateChanging);
            this.commandBarFonts.CommandBarStateChanged += new System.EventHandler(this.cbFonts_CommandBarStateChanging);
            // 
            // pnlFonts
            // 
            this.pnlFonts.Controls.Add(this.fontComboBox);
            this.pnlFonts.Controls.Add(this.fontSizeComboBox);
            this.pnlFonts.Controls.Add(this.pnlFontsTB);
            this.pnlFonts.Location = new System.Drawing.Point(10, 1);
            this.pnlFonts.Name = "pnlFonts";
            this.pnlFonts.Size = new System.Drawing.Size(288, 30);
            this.pnlFonts.TabIndex = 6;
            // 
            // fontComboBox
            // 
            this.fontComboBox.BackColor = System.Drawing.Color.White;
            this.fontComboBox.DisplayMember = "Name";
            this.fontComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontComboBox.Location = new System.Drawing.Point(7, 7);
            this.fontComboBox.Name = "fontComboBox";
            this.fontComboBox.Size = new System.Drawing.Size(54, 21);
            this.fontComboBox.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.fontComboBox.TabIndex = 5;
            this.fontComboBox.ValueMember = "Name";
            this.fontComboBox.SelectedIndexChanged += new System.EventHandler(this.fontComboBox_SelectedIndexChanged);
            // 
            // fontSizeComboBox
            // 
            this.fontSizeComboBox.BackColor = System.Drawing.Color.White;
            this.fontSizeComboBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "15"});
			this.fontSizeComboBox.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.fontSizeComboBox, "8"));
            this.fontSizeComboBox.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.fontSizeComboBox, "9"));
            this.fontSizeComboBox.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.fontSizeComboBox, "10"));
            this.fontSizeComboBox.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.fontSizeComboBox, "11"));
            this.fontSizeComboBox.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.fontSizeComboBox, "12"));
            this.fontSizeComboBox.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.fontSizeComboBox, "14"));
            this.fontSizeComboBox.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.fontSizeComboBox, "15"));
            this.fontSizeComboBox.Location = new System.Drawing.Point(68, 7);
            this.fontSizeComboBox.Name = "fontSizeComboBox";
            this.fontSizeComboBox.Size = new System.Drawing.Size(36, 21);
            this.fontSizeComboBox.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.fontSizeComboBox.TabIndex = 4;
            this.fontSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.fontComboBox_SelectedIndexChanged);
            // 
            // pnlFontsTB
            // 
            this.pnlFontsTB.Controls.Add(this.tbFont);
            this.pnlFontsTB.Location = new System.Drawing.Point(110, 3);
            this.pnlFontsTB.Name = "pnlFontsTB";
            this.pnlFontsTB.Size = new System.Drawing.Size(72, 23);
            this.pnlFontsTB.TabIndex = 5;
            // 
            // tbFont
            //
#if !NETCORE
            this.tbFont.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.tbFont.Divider = false;
            this.tbFont.DropDownArrows = true;
            this.tbFont.ShowToolTips = true;
            this.tbFont.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);

#endif
#if NETCORE
            this.tbFont.ItemClicked += TbFont_ItemClicked;
            this.tbFont.GripStyle = ToolStripGripStyle.Hidden;
            this.tbFont.CanOverflow = false;
            this.tbFont.Items.AddRange(new ToolBarButton[] {
#else
            this.tbFont.Buttons.AddRange(new ToolBarButton[] {
#endif
            this.boldButton,
            this.italicButton,
            this.underLineButton});
            this.tbFont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFont.ImageList = this.imageList1;
            this.tbFont.Location = new System.Drawing.Point(0, 0);
            this.tbFont.Name = "tbFont";
            this.tbFont.Size = new System.Drawing.Size(72, 26);
            this.tbFont.TabIndex = 4;
            this.tbFont.BackColor = System.Drawing.Color.White;

            // 
            // boldButton
            // 
            this.boldButton.ImageIndex = 3;
            this.boldButton.Name = "boldButton";
#if !NETCORE
            this.boldButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
#endif
            this.boldButton.ToolTipText = "Bold";
            // 
            // italicButton
            // 
            this.italicButton.ImageIndex = 4;
            this.italicButton.Name = "italicButton";
#if !NETCORE
            this.italicButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
#endif
            this.italicButton.ToolTipText = "Italic";
            // 
            // underLineButton
            // 
            this.underLineButton.ImageIndex = 5;
            this.underLineButton.Name = "underLineButton";
#if !NETCORE
            this.underLineButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
#endif
            this.underLineButton.ToolTipText = "Underline";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            this.imageList1.Images.SetKeyName(12, "");
            this.imageList1.Images.SetKeyName(13, "");
            this.imageList1.Images.SetKeyName(14, "");
            // 
            // commandBarAlign
            // 
            this.commandBarAlign.ChevronColor = System.Drawing.SystemColors.ControlText;
            this.commandBarAlign.Controls.Add(this.panel3);
            this.commandBarAlign.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Top;
            this.commandBarAlign.FloatModeWrapping = true;
            this.commandBarAlign.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.commandBarAlign.HideDropDownButton = true;
            this.commandBarAlign.MaxLength = 84;
            this.commandBarAlign.MinHeight = 26;
            this.commandBarAlign.MinLength = 50;
            this.commandBarAlign.Name = "commandBarAlign";
            this.commandBarAlign.RowIndex = 1;
            this.commandBarAlign.RowOffset = 402;
            this.commandBarAlign.ShowDockModeText = false;
            this.commandBarAlign.TabIndex = 2;
            this.commandBarAlign.TabStop = false;
            this.commandBarAlign.Text = "Align";
            this.commandBarAlign.CommandBarWrapping += new Syncfusion.Windows.Forms.Tools.CommandBarWrappingEventHandler(this.commandBarAlign_CommandBarWrapping);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbAlign);
            this.panel3.Location = new System.Drawing.Point(10, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(72, 30);
            this.panel3.TabIndex = 5;
            // 
            // tbAlign
            // 
#if !NETCORE
            this.tbAlign.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.tbAlign.ButtonSize = new System.Drawing.Size(23, 22);
            this.tbAlign.Divider = false;
            this.tbAlign.DropDownArrows = true;
            this.tbAlign.ShowToolTips = true;
            this.tbAlign.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
#endif
#if NETCORE
            this.tbAlign.GripStyle = ToolStripGripStyle.Hidden;
            this.tbAlign.ItemClicked+=TbFont_ItemClicked;
            this.tbAlign.Items.AddRange(new ToolBarButton[] {
#else
            this.tbAlign.Buttons.AddRange(new ToolBarButton[] {
#endif
            this.laButton,
            this.centerButton,
            this.raButton});
            this.tbAlign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAlign.ImageList = this.imageList1;
            this.tbAlign.Location = new System.Drawing.Point(0, 0);
            this.tbAlign.Name = "tbAlign";
            this.tbAlign.Size = new System.Drawing.Size(72, 26);
            this.tbAlign.TabIndex = 4;
            this.tbAlign.BackColor = Color.White;
            // 
            // laButton
            // 
            this.laButton.ImageIndex = 1;
            this.laButton.Name = "laButton";
#if NETCORE
            this.laButton.Checked = true;
#else
            this.laButton.Pushed = true;
            this.laButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
#endif
            this.laButton.ToolTipText = "Left Aligned";
            // 
            // centerButton
            // 
            this.centerButton.ImageIndex = 0;
            this.centerButton.Name = "centerButton";
#if !NETCORE
            this.centerButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
#endif
            this.centerButton.ToolTipText = "Center Aligned";
            // 
            // raButton
            // 
            this.raButton.ImageIndex = 2;
            this.raButton.Name = "raButton";
#if !NETCORE
            this.raButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
#endif
            this.raButton.ToolTipText = "Right Aligned";
            // 
            // commandBarStandard
            // 
            this.commandBarStandard.ChevronColor = System.Drawing.SystemColors.ControlText;
            this.commandBarStandard.Controls.Add(this.panel2);
            this.commandBarStandard.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Top;
            this.commandBarStandard.FloatModeWrapping = true;
            this.commandBarStandard.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.commandBarStandard.HideDropDownButton = true;
            this.commandBarStandard.MaxLength = 167;
            this.commandBarStandard.MinHeight = 26;
            this.commandBarStandard.MinLength = 50;
            this.commandBarStandard.Name = "commandBarStandard";
            this.commandBarStandard.RowIndex = 0;
            this.commandBarStandard.RowOffset = 0;
            this.commandBarStandard.ShowDockModeText = false;
            this.commandBarStandard.TabIndex = 1;
            this.commandBarStandard.TabStop = false;
            this.commandBarStandard.Text = "Standard";
            this.commandBarStandard.CommandBarWrapping += new Syncfusion.Windows.Forms.Tools.CommandBarWrappingEventHandler(this.commandBarStandard_Wrapping);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbStandard);
            this.panel2.Location = new System.Drawing.Point(10, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 30);
            this.panel2.TabIndex = 5;
            // 
            // tbStandard
            //
#if !NETCORE
            this.tbStandard.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.tbStandard.Divider = false;
            this.tbStandard.DropDownArrows = true;
            this.tbStandard.ShowToolTips = true;
            this.tbStandard.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.toolBarButton1,
            this.toolBarButton2,
            this.toolBarButton3,
            this.toolBarButton5,
            this.toolBarButton6,
            this.toolBarButton7,
            this.toolBarButton8});
#else
            this.tbStandard.GripStyle = ToolStripGripStyle.Hidden;
            this.tbStandard.CanOverflow = false;
            this.tbStandard.Items.AddRange(new ToolBarButton[] {
            this.toolBarButton1,
            this.toolBarButton2,
            this.toolBarButton3,
            this.toolBarButton6,
            this.toolBarButton7,
            this.toolBarButton8});
#endif
            this.tbStandard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbStandard.ImageList = this.imageList1;
            this.tbStandard.Location = new System.Drawing.Point(0, 0);
            this.tbStandard.Name = "tbStandard";
            this.tbStandard.Size = new System.Drawing.Size(155, 26);
            this.tbStandard.TabIndex = 4;
            this.tbStandard.BackColor = Color.White;
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.ImageIndex = 6;
            this.toolBarButton1.Name = "toolBarButton1";
            this.toolBarButton1.ToolTipText = "New";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.ImageIndex = 7;
            this.toolBarButton2.Name = "toolBarButton2";
            this.toolBarButton2.ToolTipText = "Open";
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.ImageIndex = 8;
            this.toolBarButton3.Name = "toolBarButton3";
            this.toolBarButton3.ToolTipText = "Save";
            // 
            // toolBarButton5
            // 
            this.toolBarButton5.Name = "toolBarButton5";
#if !NETCORE
            this.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
#endif
            // 
            // toolBarButton6
            // 
            this.toolBarButton6.ImageIndex = 10;
            this.toolBarButton6.Name = "toolBarButton6";
            this.toolBarButton6.ToolTipText = "Cut";
            // 
            // toolBarButton7
            // 
            this.toolBarButton7.ImageIndex = 11;
            this.toolBarButton7.Name = "toolBarButton7";
            this.toolBarButton7.ToolTipText = "Copy";
            // 
            // toolBarButton8
            // 
            this.toolBarButton8.ImageIndex = 12;
            this.toolBarButton8.Name = "toolBarButton8";
            this.toolBarButton8.ToolTipText = "Paste";
            // 
            // commandBarAddress
            // 
            this.commandBarAddress.ChevronColor = System.Drawing.SystemColors.ControlText;
            this.commandBarAddress.Controls.Add(this.panel1);
            this.commandBarAddress.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Top;
            this.commandBarAddress.FloatModeWrapping = true;
            this.commandBarAddress.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.commandBarAddress.HideDropDownButton = true;
            this.commandBarAddress.MaxLength = 400;
            this.commandBarAddress.MinHeight = 26;
            this.commandBarAddress.MinLength = 50;
            this.commandBarAddress.Name = "commandBarAddress";
            this.commandBarAddress.PopupMenu = this.popupMenuAddress;
            this.commandBarAddress.RowIndex = 1;
            this.commandBarAddress.RowOffset = 0;
            this.commandBarAddress.TabIndex = 3;
            this.commandBarAddress.TabStop = false;
            this.commandBarAddress.Text = "Address";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(55, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 30);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.BeforeTouchSize = new System.Drawing.Size(263, 19);
            this.comboBox1.Items.AddRange(new object[] {
            "www.syncfusion.com",
            "www.syncfusion.com/faq/winforms",
            "msdn.microsoft.com"});
            this.comboBox1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox1, "www.syncfusion.com"));
            this.comboBox1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox1, "www.syncfusion.com/faq/winforms"));
            this.comboBox1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox1, "msdn.microsoft.com"));
            this.comboBox1.Location = new System.Drawing.Point(4, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(263, 19);
            this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "www.syncfusion.com";
            // 
            // popupMenuAddress
            // 
            this.popupMenuAddress.ParentBarItem = this.parentBarItem1;
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.BarName = "parentBarItem1";
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.biAddressHome,
            this.biAddressFAQ,
            this.biAddressSales,
            this.biAddressProducts});
            this.parentBarItem1.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // biAddressHome
            // 
            this.biAddressHome.BarName = "biAddressHome";
            this.biAddressHome.ID = "Syncfusion Home";
            this.biAddressHome.ImageIndex = 13;
            this.biAddressHome.ImageList = this.imageList1;
            this.biAddressHome.ShowToolTipInPopUp = false;
            this.biAddressHome.SizeToFit = true;
            this.biAddressHome.Text = "Syncfusion Home";
            this.biAddressHome.Click += new System.EventHandler(this.biAddress_Click);
            // 
            // biAddressFAQ
            // 
            this.biAddressFAQ.BarName = "biAddressFAQ";
            this.biAddressFAQ.ID = "Windows Forms FAQ";
            this.biAddressFAQ.ImageIndex = 13;
            this.biAddressFAQ.ImageList = this.imageList1;
            this.biAddressFAQ.ShowToolTipInPopUp = false;
            this.biAddressFAQ.SizeToFit = true;
            this.biAddressFAQ.Text = "Windows Forms FAQ";
            this.biAddressFAQ.Click += new System.EventHandler(this.biAddress_Click);
            // 
            // biAddressSales
            // 
            this.biAddressSales.BarName = "biAddressSales";
            this.biAddressSales.ID = "Syncfusion Sales";
            this.biAddressSales.ImageIndex = 13;
            this.biAddressSales.ImageList = this.imageList1;
            this.biAddressSales.ShowToolTipInPopUp = false;
            this.biAddressSales.SizeToFit = true;
            this.biAddressSales.Text = "Syncfusion Sales";
            this.biAddressSales.Click += new System.EventHandler(this.biAddress_Click);
            // 
            // biAddressProducts
            // 
            this.biAddressProducts.BarName = "biAddressProducts";
            this.biAddressProducts.ID = "Syncfusion Products Page";
            this.biAddressProducts.ImageIndex = 13;
            this.biAddressProducts.ImageList = this.imageList1;
            this.biAddressProducts.ShowToolTipInPopUp = false;
            this.biAddressProducts.SizeToFit = true;
            this.biAddressProducts.Text = "Syncfusion Products Page";
            this.biAddressProducts.Click += new System.EventHandler(this.biAddress_Click);
            // 
            // separator
            // 
            this.separator.Name = "separator";
#if !NETCORE
            this.separator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
#endif
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 364);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(532, 24);
            this.statusBar1.TabIndex = 4;
            this.statusBar1.Text = "Ready";
            // 
            // wizardContainer1
            // 
            this.wizardContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardContainer1.Location = new System.Drawing.Point(0, 22);
            this.wizardContainer1.Name = "wizardContainer1";
            this.wizardContainer1.Size = new System.Drawing.Size(192, 263);
            this.wizardContainer1.TabIndex = 3;
            // 
            // AllowFloating
            // 
            this.AllowFloating.BackColor = System.Drawing.Color.Transparent;
            this.AllowFloating.DrawFocusRectangle = false;
            this.AllowFloating.Location = new System.Drawing.Point(16, 183);
            this.AllowFloating.MetroColor = System.Drawing.Color.DarkGray;
            this.AllowFloating.Name = "AllowFloating";
            this.AllowFloating.Size = new System.Drawing.Size(105, 20);
            this.AllowFloating.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.AllowFloating.TabIndex = 13;
            this.AllowFloating.Text = "Allow Floating";
            this.AllowFloating.ThemesEnabled = false;
            this.AllowFloating.CheckChanged += new System.EventHandler(this.AllowFloating_CheckedChanged);
            // 
            // AllowDocking
            // 
            this.AllowDocking.BackColor = System.Drawing.Color.Transparent;
            this.AllowDocking.Checked = true;
            this.AllowDocking.DrawFocusRectangle = false;
            this.AllowDocking.Location = new System.Drawing.Point(16, 160);
            this.AllowDocking.MetroColor = System.Drawing.Color.DarkGray;
            this.AllowDocking.Name = "AllowDocking";
            this.AllowDocking.Size = new System.Drawing.Size(107, 20);
            this.AllowDocking.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.AllowDocking.TabIndex = 12;
            this.AllowDocking.Text = "Allow Docking";
            this.AllowDocking.ThemesEnabled = false;
            this.AllowDocking.CheckChanged += new System.EventHandler(this.AllowDocking_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.DrawFocusRectangle = false;
            this.checkBox2.Location = new System.Drawing.Point(16, 137);
            this.checkBox2.MetroColor = System.Drawing.Color.DarkGray;
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(160, 17);
            this.checkBox2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Show Drop Down Button";
            this.checkBox2.ThemesEnabled = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(16, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Style";
            // 
            // styleComboBox
            // 
            this.styleComboBox.BackColor = System.Drawing.Color.White;
            this.styleComboBox.DisplayMember = "Name";
            this.styleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.styleComboBox.Items.AddRange(new object[] {
            "Default",
            "OfficeXP",
            "Office2003"});
            this.styleComboBox.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.styleComboBox, "Default"));
            this.styleComboBox.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.styleComboBox, "OfficeXP"));
            this.styleComboBox.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.styleComboBox, "Office2003"));
            this.styleComboBox.Location = new System.Drawing.Point(16, 86);
            this.styleComboBox.Name = "styleComboBox";
            this.styleComboBox.Size = new System.Drawing.Size(160, 21);
            this.styleComboBox.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.styleComboBox.TabIndex = 7;
            this.styleComboBox.Text = "Default";
            this.styleComboBox.ValueMember = "Name";
            this.styleComboBox.SelectedIndexChanged += new System.EventHandler(this.styleComboBox_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.DrawFocusRectangle = false;
            this.checkBox1.Location = new System.Drawing.Point(16, 115);
            this.checkBox1.MetroColor = System.Drawing.Color.DarkGray;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 17);
            this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Show Chevron";
            this.checkBox1.ThemesEnabled = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 160);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(32, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 96);
            this.label2.TabIndex = 2;
            this.label2.Text = "The Essential Tools Menus Package uses the CommandBars framework for creating the" +
    " XP menus and toolbars. ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "CommandBars implement the framework support that is required for creating Visual " +
    "Studio.NET type dockable/floatable menus and toolbars.";
            // 
            // mainFrameBarManager1
            // 
#if !NETCORE
             this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
#endif
            this.mainFrameBarManager1.Bars.Add(this.bar1);
            this.mainFrameBarManager1.Categories.Add("File");
            this.mainFrameBarManager1.Categories.Add("Edit");
            this.mainFrameBarManager1.Categories.Add("View");
            this.mainFrameBarManager1.Categories.Add("help");
            this.mainFrameBarManager1.CategoriesToIgnoreInCustDialog.AddRange(new int[] {
            3});
            this.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.MetroForm";
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem2,
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem4,
            this.parentBarItem3,
            this.barItem5,
            this.barItem6,
            this.barItem7,
            this.parentBarItem4,
            this.barItem8,
            this.barItem9,
            this.barItem10,
            this.barItem11,
            this.parentBarItem5,
            this.barItem12});
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // bar1
            // 
            this.bar1.BarName = "Menu";
            this.bar1.Caption = "Menu";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem2,
            this.parentBarItem3,
            this.parentBarItem4,
            this.parentBarItem5});
            this.bar1.Manager = this.mainFrameBarManager1;
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.BarName = "parentBarItem2";
            this.parentBarItem2.CategoryIndex = 0;
            this.parentBarItem2.ID = "&File";
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem4});
            this.parentBarItem2.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem2.ShowToolTipInPopUp = false;
            this.parentBarItem2.SizeToFit = true;
            this.parentBarItem2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem2.Text = "&File";
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.CategoryIndex = 0;
            this.barItem1.ID = "&New";
            this.barItem1.ShowToolTipInPopUp = false;
            this.barItem1.SizeToFit = true;
            this.barItem1.Text = "&New";
            this.barItem1.Click += new System.EventHandler(this.barItem1_Click);
            // 
            // barItem2
            // 
            this.barItem2.BarName = "barItem2";
            this.barItem2.CategoryIndex = 0;
            this.barItem2.ID = "&Open";
            this.barItem2.ShowToolTipInPopUp = false;
            this.barItem2.SizeToFit = true;
            this.barItem2.Text = "&Open";
            this.barItem2.Click += new System.EventHandler(this.barItem2_Click);
            // 
            // barItem3
            // 
            this.barItem3.BarName = "barItem3";
            this.barItem3.CategoryIndex = 0;
            this.barItem3.ID = "&Save";
            this.barItem3.ShowToolTipInPopUp = false;
            this.barItem3.SizeToFit = true;
            this.barItem3.Text = "&Save";
            this.barItem3.Click += new System.EventHandler(this.barItem3_Click);
            // 
            // barItem4
            // 
            this.barItem4.BarName = "barItem4";
            this.barItem4.CategoryIndex = 0;
            this.barItem4.ID = "&Exit";
            this.barItem4.ShowToolTipInPopUp = false;
            this.barItem4.SizeToFit = true;
            this.barItem4.Text = "&Exit";
            this.barItem4.Click += new System.EventHandler(this.barItem4_Click);
            // 
            // parentBarItem3
            // 
            this.parentBarItem3.BarName = "parentBarItem3";
            this.parentBarItem3.CategoryIndex = 1;
            this.parentBarItem3.ID = "&Edit";
            this.parentBarItem3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem5,
            this.barItem6,
            this.barItem7});
            this.parentBarItem3.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem3.ShowToolTipInPopUp = false;
            this.parentBarItem3.SizeToFit = true;
            this.parentBarItem3.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem3.Text = "&Edit";
            // 
            // barItem5
            // 
            this.barItem5.BarName = "barItem5";
            this.barItem5.CategoryIndex = 1;
            this.barItem5.ID = "&Cut";
            this.barItem5.ShowToolTipInPopUp = false;
            this.barItem5.SizeToFit = true;
            this.barItem5.Text = "&Cut";
            this.barItem5.Click += new System.EventHandler(this.barItem5_Click);
            // 
            // barItem6
            // 
            this.barItem6.BarName = "barItem6";
            this.barItem6.CategoryIndex = 1;
            this.barItem6.ID = "C&opy";
            this.barItem6.ShowToolTipInPopUp = false;
            this.barItem6.SizeToFit = true;
            this.barItem6.Text = "C&opy";
            this.barItem6.Click += new System.EventHandler(this.barItem6_Click);
            // 
            // barItem7
            // 
            this.barItem7.BarName = "barItem7";
            this.barItem7.CategoryIndex = 1;
            this.barItem7.ID = "&Paste";
            this.barItem7.ShowToolTipInPopUp = false;
            this.barItem7.SizeToFit = true;
            this.barItem7.Text = "&Paste";
            this.barItem7.Click += new System.EventHandler(this.barItem7_Click);
            // 
            // parentBarItem4
            // 
            this.parentBarItem4.BarName = "parentBarItem4";
            this.parentBarItem4.CategoryIndex = 2;
            this.parentBarItem4.ID = "&View";
            this.parentBarItem4.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem8,
            this.barItem9,
            this.barItem10,
            this.barItem11});
            this.parentBarItem4.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem4.ShowToolTipInPopUp = false;
            this.parentBarItem4.SizeToFit = true;
            this.parentBarItem4.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem4.Text = "&View";
            // 
            // barItem8
            // 
            this.barItem8.BarName = "barItem8";
            this.barItem8.CategoryIndex = 2;
            this.barItem8.Checked = true;
            this.barItem8.ID = "&Standard";
            this.barItem8.ShowToolTipInPopUp = false;
            this.barItem8.SizeToFit = true;
            this.barItem8.Text = "&Standard";
            this.barItem8.Click += new System.EventHandler(this.barItem8_Click);
            // 
            // barItem9
            // 
            this.barItem9.BarName = "barItem9";
            this.barItem9.CategoryIndex = 2;
            this.barItem9.Checked = true;
            this.barItem9.ID = "&Fonts";
            this.barItem9.ShowToolTipInPopUp = false;
            this.barItem9.SizeToFit = true;
            this.barItem9.Text = "&Fonts";
            this.barItem9.Click += new System.EventHandler(this.barItem9_Click);
            // 
            // barItem10
            // 
            this.barItem10.BarName = "barItem10";
            this.barItem10.CategoryIndex = 2;
            this.barItem10.Checked = true;
            this.barItem10.ID = "&Align";
            this.barItem10.ShowToolTipInPopUp = false;
            this.barItem10.SizeToFit = true;
            this.barItem10.Text = "&Align";
            this.barItem10.Click += new System.EventHandler(this.barItem10_Click);
            // 
            // barItem11
            // 
            this.barItem11.BarName = "barItem11";
            this.barItem11.CategoryIndex = 2;
            this.barItem11.Checked = true;
            this.barItem11.ID = "A&ddress";
            this.barItem11.ShowToolTipInPopUp = false;
            this.barItem11.SizeToFit = true;
            this.barItem11.Text = "A&ddress";
            this.barItem11.Click += new System.EventHandler(this.barItem11_Click);
            // 
            // parentBarItem5
            // 
            this.parentBarItem5.BarName = "parentBarItem5";
            this.parentBarItem5.CategoryIndex = 3;
            this.parentBarItem5.ID = "&Help";
            this.parentBarItem5.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem12});
            this.parentBarItem5.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem5.ShowToolTipInPopUp = false;
            this.parentBarItem5.SizeToFit = true;
            this.parentBarItem5.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem5.Text = "&Help";
            // 
            // barItem12
            // 
            this.barItem12.BarName = "barItem12";
            this.barItem12.CategoryIndex = 3;
            this.barItem12.ID = "&About";
            this.barItem12.ShowToolTipInPopUp = false;
            this.barItem12.SizeToFit = true;
            this.barItem12.Text = "&About";
            this.barItem12.Click += new System.EventHandler(this.barItem12_Click);
            // 
            // DockedBarsForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientSize = new System.Drawing.Size(532, 388);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.statusBar1);
            this.DropShadow = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MetroColor = System.Drawing.Color.White;
            this.Name = "DockedBarsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Command Bars ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.commandBarController1)).EndInit();
            this.commandBarFonts.ResumeLayout(false);
            this.pnlFonts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fontComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeComboBox)).EndInit();
            this.pnlFontsTB.ResumeLayout(false);
            this.pnlFontsTB.PerformLayout();
            this.commandBarAlign.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.commandBarStandard.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.commandBarAddress.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllowFloating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllowDocking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).EndInit();
            this.ResumeLayout(false);

        }
#if NETCORE
        private void TbFont_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (!this.initDone)
                return;

            //this.curStyle = FontStyle.Regular;
            if (e.ClickedItem == this.boldButton)
            {
                if (this.boldButton.Checked)
                    this.curStyle = this.curStyle | FontStyle.Bold;
                else
                    this.curStyle -= FontStyle.Bold;
            }
            else if (e.ClickedItem == this.italicButton)
            {
                if (this.italicButton.Checked)
                    this.curStyle = this.curStyle | FontStyle.Italic;
                else
                    this.curStyle -= FontStyle.Italic;
            }
            else if (e.ClickedItem == this.underLineButton)
            {
                if (this.underLineButton.Checked)
                    this.curStyle = this.curStyle | FontStyle.Underline;
                else
                    this.curStyle -= FontStyle.Underline;
            }
            else if (e.ClickedItem == this.laButton)
            {
                if (this.laButton.Checked)
                {
                    this.curAlignment = HorizontalAlignment.Left;
                    this.centerButton.Checked = false;
                    this.raButton.Checked = false;
                }
            }
            else if (e.ClickedItem == this.centerButton)
            {
                if (this.centerButton.Checked)
                {
                    this.curAlignment = HorizontalAlignment.Center;
                    this.laButton.Checked = false;
                    this.raButton.Checked = false;
                }
            }
            else if (e.ClickedItem == this.raButton)
            {
                if (this.raButton.Checked)
                {
                    this.curAlignment = HorizontalAlignment.Right;
                    this.laButton.Checked = false;
                    this.centerButton.Checked = false;
                }
            }
            this.richTextBox1.Focus();
            this.UpdateFont();
        }
#endif
#endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
            Application.Run(new DockedBarsForm());
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.fontComboBox.DisplayMember = "Name";
            this.fontComboBox.ValueMember = "Name";
            this.fontComboBox.Items.AddRange(FontFamily.Families);
            this.fontComboBox.SelectedIndex = 2;

            this.fontSizeComboBox.SelectedIndex = 2;
            this.styleComboBox.Items.Clear();
            this.styleComboBox.DataSource = Enum.GetNames(typeof(VisualStyle));
            //this.styleComboBox.SelectedIndex = 2;

            this.initDone = true;
            this.UpdateFont();

            this.xpTaskPane1 = new Syncfusion.Windows.Forms.Tools.XPTaskPane();
            this.xpTaskPage2 = new Syncfusion.Windows.Forms.Tools.XPTaskPage();
            this.xpTaskPage1 = new Syncfusion.Windows.Forms.Tools.XPTaskPage();
            // 
            // xpTaskPane1
            // 
            this.xpTaskPane1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.xpTaskPane1.Controls.Add(this.wizardContainer1);
            this.xpTaskPane1.Dock = System.Windows.Forms.DockStyle.Right;
            // 
            // xpTaskPage2
            // 
            this.xpTaskPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.xpTaskPage2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(230))))), System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(206))))));
            this.xpTaskPage2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(146)))), ((int)(((byte)(206)))));
            this.xpTaskPage2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xpTaskPage2.Controls.Add(this.AllowFloating);
            this.xpTaskPage2.Controls.Add(this.AllowDocking);
            this.xpTaskPage2.Controls.Add(this.checkBox2);
            this.xpTaskPage2.Controls.Add(this.label3);
            this.xpTaskPage2.Controls.Add(this.styleComboBox);
            this.xpTaskPage2.Controls.Add(this.checkBox1);
            this.xpTaskPage2.LayoutName = "Card1";
            this.xpTaskPage2.Location = new System.Drawing.Point(0, 0);
            this.xpTaskPage2.Name = "xpTaskPage2";
            this.xpTaskPage2.NextPage = null;
            this.xpTaskPage2.PreviousPage = null;
            this.xpTaskPage2.Size = new System.Drawing.Size(192, 263);
            this.xpTaskPage2.TabIndex = 1;
            this.xpTaskPage2.Title = "Properties";

            // 
            // xpTaskPage1
            // 
            this.xpTaskPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.xpTaskPage1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.xpTaskPage1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(146)))), ((int)(((byte)(206)))));
            this.xpTaskPage1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xpTaskPage1.Controls.Add(this.pictureBox2);
            this.xpTaskPage1.Controls.Add(this.label2);
            this.xpTaskPage1.Controls.Add(this.pictureBox1);
            this.xpTaskPage1.Controls.Add(this.label1);
            this.xpTaskPage1.LayoutName = "Card2";
            this.xpTaskPage1.Location = new System.Drawing.Point(0, 0);
            this.xpTaskPage1.Name = "xpTaskPage1";
            this.xpTaskPage1.NextPage = null;
            this.xpTaskPage1.PreviousPage = null;
            this.xpTaskPage1.Size = new System.Drawing.Size(192, 263);
            this.xpTaskPage1.TabIndex = 0;
            this.xpTaskPage1.Title = "Info";

            this.xpTaskPane1.HeaderMenuItem.ImageIndex = 2;
            this.xpTaskPane1.HeaderMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.xpTaskPane1.Location = new System.Drawing.Point(352, 52);
            this.xpTaskPane1.Name = "xpTaskPane1";
            this.xpTaskPane1.SelectedPage = this.xpTaskPage2;
            this.xpTaskPane1.Size = new System.Drawing.Size(192, 285);
            this.xpTaskPane1.TabIndex = 5;
            this.xpTaskPane1.TaskPages = new Syncfusion.Windows.Forms.Tools.XPTaskPage[] {
        this.xpTaskPage2,
        this.xpTaskPage1};
            this.xpTaskPane1.TaskPanePageContainer = this.wizardContainer1;
            this.wizardContainer1.Controls.Add(this.xpTaskPage2);
            this.wizardContainer1.Controls.Add(this.xpTaskPage1);
            this.Controls.Add(this.xpTaskPane1);
            this.xpTaskPane1.VisualStyle = VisualStyle.Metro;
            this.xpTaskPane1.Header.BackColor = Office2003Colors.MenuMarginColorDark;
            this.xpTaskPage1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, Color.White, Color.White);
            this.xpTaskPage2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, Color.White, Color.White);
        }

        private FontStyle curStyle = FontStyle.Regular;
        private HorizontalAlignment curAlignment = HorizontalAlignment.Left;
        private void fontComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (!this.initDone)
                return;

            this.richTextBox1.Focus();
            this.UpdateFont();
        }
#if !NETCORE
        private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
        {
            if (!this.initDone)
                return;

            //this.curStyle = FontStyle.Regular;
            if (e.Button == this.boldButton)
            {
                if (this.boldButton.Pushed)
                    this.curStyle = this.curStyle | FontStyle.Bold;
                else
                    this.curStyle -= FontStyle.Bold;
            }
            else if (e.Button == this.italicButton)
            {
                if (this.italicButton.Pushed)
                    this.curStyle = this.curStyle | FontStyle.Italic;
                else
                    this.curStyle -= FontStyle.Italic;
            }
            else if (e.Button == this.underLineButton)
            {
                if (this.underLineButton.Pushed)
                    this.curStyle = this.curStyle | FontStyle.Underline;
                else
                    this.curStyle -= FontStyle.Underline;
            }
            else if (e.Button == this.laButton)
            {
                if (this.laButton.Pushed)
                {
                    this.curAlignment = HorizontalAlignment.Left;
                    this.centerButton.Pushed = false;
                    this.raButton.Pushed = false;
                }
            }
            else if (e.Button == this.centerButton)
            {
                if (this.centerButton.Pushed)
                {
                    this.curAlignment = HorizontalAlignment.Center;
                    this.laButton.Pushed = false;
                    this.raButton.Pushed = false;
                }
            }
            else if (e.Button == this.raButton)
            {
                if (this.raButton.Pushed)
                {
                    this.curAlignment = HorizontalAlignment.Right;
                    this.laButton.Pushed = false;
                    this.centerButton.Pushed = false;
                }
            }
            this.richTextBox1.Focus();
            this.UpdateFont();
        }
#endif
        private void UpdateFont()
        {
            try
            {
                string family = this.fontComboBox.SelectedItem.ToString();
                family = family.Substring(family.IndexOf("=") + 1, family.IndexOf("]") - family.IndexOf("=") - 1);
                this.richTextBox1.SelectionFont = new Font(family, Int32.Parse(this.fontSizeComboBox.Text), this.curStyle);
                this.richTextBox1.SelectionAlignment = this.curAlignment;
            }
            catch { }
        }

        private void menuItemFile_Click(object sender, System.EventArgs e)
        {
            
        }

        private void OpenDocument()
        {
            // Create an OpenFileDialog to request a file to open.
            OpenFileDialog openFile1 = new OpenFileDialog();

            // Initialize the OpenFileDialog to look for RTF files.
            openFile1.DefaultExt = "*.rtf";
            openFile1.Filter = "RTF Files|*.rtf";

            // Determine whether the user selected a file from the OpenFileDialog.
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile1.FileName.Length > 0)
            {
                this.richTextBox1.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void SaveDocument()
        {
            // Create a SaveFileDialog to request a path and file name to save to.
            SaveFileDialog saveFile1 = new SaveFileDialog();

            // Initialize the SaveFileDialog to specify the RTF extension for the file.
            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            // Determine if the user selected a file name from the saveFileDialog.
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                saveFile1.FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.
                this.richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }
        // Handler for the CommandBar.CommandBarStateChanging event.
        private void cbFonts_CommandBarStateChanging(object obj, Syncfusion.Windows.Forms.Tools.CommandBarStateChangingEventArgs arg)
        {
            // If the fonts CommandBar is being docked to a vertical dock position, ie., left or right, 
            // then hide the two combo boxes and set the commandbar maxlength to be equal to 
            // the length of the fonts toolbar.
            // NOTE - The CommandBar's dockstate will be set to CommandBarDockState.None when the CommandBar 
            // is in an indeterminate state. This happens only during loading and deserialization.
            Syncfusion.Windows.Forms.Tools.CommandBarDockState currentborder = this.commandBarFonts.DockState;
            Syncfusion.Windows.Forms.Tools.CommandBarDockState newborder = arg.NewDockState;
            if (((currentborder == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Top) ||
                (currentborder == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Bottom) ||
                (currentborder == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Float) ||
                (currentborder == Syncfusion.Windows.Forms.Tools.CommandBarDockState.None)) &&
                ((newborder == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Left) ||
                (newborder == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Right)))
            {
                this.fontComboBox.Visible = false;
                this.fontSizeComboBox.Visible = false;
                this.commandBarFonts.MaxLength = this.commandBarFonts.CalcCommandBarMaxLength(this.szFontToolBarPanel.Width);
                // Move the panel containing the fonts toolbar to the (0,0) position of the commandbar panel.
                this.pnlFontsTB.Location = new Point(0, 0);
            }
            // If the Fonts CommandBar is being redocked / floated from the left or right borders, then 
            // increase the max length and restore combo box visibility.
            if (((currentborder == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Left) ||
                (currentborder == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Right)) &&
                ((newborder == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Top) ||
                (newborder == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Bottom) ||
                (newborder == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Float) ||
                (newborder == Syncfusion.Windows.Forms.Tools.CommandBarDockState.None)))
            {
                this.commandBarFonts.MaxLength = this.commandBarFonts.CalcCommandBarMaxLength(this.szFontCommandBarPanelSize.Width);
                // Move the fonts toolbar panel to its original position ie., after the two combo boxes.
                this.pnlFontsTB.Location = new Point(this.fontSizeComboBox.Right + 6, 0);
                this.fontComboBox.Visible = true;
                this.fontSizeComboBox.Visible = true;
            }
        }

        // Handler for the CommandBar.CommandBarStateChanged event.
        private void cbFonts_CommandBarStateChanging(object sender, System.EventArgs e)
        {
            // The Fonts CommandBar client dimensions may have been changed by the redocking. 
            // Size the panel containing the Fonts toolbar to fit the new CommandBar panel dimensions.
            if (((this.commandBarFonts.DockState == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Left) ||
                (this.commandBarFonts.DockState == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Right))
                && (this.pnlFontsTB.Width > this.commandBarFonts.Width))
            {
                this.pnlFontsTB.Size = this.pnlFonts.Size;
            }
            else
            {
                // The CommandBar has been moved out of a left / right dock position.
                if (this.pnlFontsTB.Height > this.commandBarFonts.Height)
                {
                    this.pnlFontsTB.Size = this.szFontToolBarPanel;
                }
            }
        }

        private void biAddress_Click(object sender, System.EventArgs e)
        {
            Syncfusion.Windows.Forms.Tools.XPMenus.BarItem item = sender as Syncfusion.Windows.Forms.Tools.XPMenus.BarItem;
            this.comboBox1.Text = item.Tag as String;
        }

        private void commandBarStandard_Wrapping(object obj, Syncfusion.Windows.Forms.Tools.CommandBarWrappingEventArgs arg)
        {
            // Apply the wrapping algorithm only when the CommandBar is floating.
            if (this.commandBarStandard.DockState == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Float)
            {
                // szmaxwrap represents the tbStandard toolbar's dimensions in the maximum wrapped state. 
                // szwinwrap represents the tbStandard toolbar's dimensions in the minimum wrapped state.
                // These dimensions are determined at design time.
                Size szmaxwrap = new Size(40, 155);
                Size szminwrap = new Size(150, 23);
                this.DoToolBarWrapping(this.tbStandard, szmaxwrap, szminwrap, arg);
            }
            else if ((this.commandBarStandard.DockState == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Left) ||
                (this.commandBarStandard.DockState == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Right))
            {
                Size szmaxwrap = new Size(24, 155);
                arg.ClientSize = szmaxwrap;
            }
        }

        private void commandBarAlign_CommandBarWrapping(object obj, Syncfusion.Windows.Forms.Tools.CommandBarWrappingEventArgs arg)
        {
            // Apply the wrapping algorithm only when the CommandBar is floating.
            if (this.commandBarAlign.DockState == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Float)
            {
                Size szmaxwrap = new Size(40, 67);
                Size szminwrap = new Size(72, 23);
                this.DoToolBarWrapping(this.tbAlign, szmaxwrap, szminwrap, arg);
            }
            else if ((this.commandBarAlign.DockState == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Left) ||
                (this.commandBarAlign.DockState == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Right))
            {
                Size szmaxwrap = new Size(24, 67);
                arg.ClientSize = szmaxwrap;
            }
        }

        private void DoToolBarWrapping(ToolBar toolbar, Size szmaxwrap, Size szminwrap, Syncfusion.Windows.Forms.Tools.CommandBarWrappingEventArgs arg)
        {
            Size szcurrent = arg.ClientSize;
            Size sztemp = toolbar.Size;
#if NETCORE
            int nbtncount = toolbar.Items.Count;
            Size szbtn = toolBarButton1.Size;
#else
            int nbtncount = toolbar.Buttons.Count;
            Size szbtn = toolbar.ButtonSize;
#endif

            if ((arg.CommandBarResizeType == Syncfusion.Windows.Forms.Tools.CommandBarResizeType.Right) || (arg.CommandBarResizeType == Syncfusion.Windows.Forms.Tools.CommandBarResizeType.Left))
            {
                int nfactor = (int)Math.Ceiling((float)szminwrap.Width / (float)szcurrent.Width);
                float ffactor = (float)szminwrap.Width / (float)szcurrent.Width;

                if (szcurrent.Width < szmaxwrap.Width)
                {
                    arg.ClientSize = szmaxwrap;
                }
                else if ((nfactor > 1) && (nfactor == ffactor))
                {
                    int nnewwidth = (int)Math.Ceiling((float)nbtncount / (float)nfactor) * szbtn.Width;

                    Size sznew = Size.Empty;
                    if (nnewwidth > szmaxwrap.Width)
                    {
                        // Set this width to be the toolbar's parent panel width and allow the toolbar to 
                        // layout itself for this width. We then get the toolbar's height and assign this as 
                        // the CommandBar client size.
                        sznew.Width = nnewwidth;
                        toolbar.Parent.Width = sznew.Width;
                        sznew.Height = toolbar.Height;
                        toolbar.Parent.Width = sztemp.Width;
                    }
                    else
                        sznew = szmaxwrap;

                    // Set the CommandBar's client size to be equal to this new size.
                    arg.ClientSize = sznew;
                }
                else if (ffactor <= 1)
                {
                    // The CommandBar is extended to the maximum width.
                    arg.ClientSize = szminwrap;
                }
                else
                {
                    arg.ClientSize = toolbar.Size;
                }
            }
            else if ((arg.CommandBarResizeType == Syncfusion.Windows.Forms.Tools.CommandBarResizeType.Bottom) || (arg.CommandBarResizeType == Syncfusion.Windows.Forms.Tools.CommandBarResizeType.Top))
            {
                int nfactor = (int)Math.Floor((float)szcurrent.Height / (float)szbtn.Height);
                float ffactor = (float)szcurrent.Height / (float)szbtn.Height;

                if (szcurrent.Height > szmaxwrap.Height)
                {
                    arg.ClientSize = szmaxwrap;
                }
                else if ((nfactor > 1) && (nfactor == ffactor))
                {
                    // The toolbar width is estimated to be equal to the buttonwidth + the number of button columns reqd.
                    int nnewwidth = (int)Math.Ceiling((float)nbtncount / (float)nfactor) * szbtn.Width;

                    Size sznew = Size.Empty;
                    if (nnewwidth > szmaxwrap.Width)
                    {
                        // Assign the new width to the toolbar parent panel and get the corresponding 
                        // toolbar height.
                        sznew.Width = nnewwidth;
                        toolbar.Parent.Width = sznew.Width;
                        sznew.Height = toolbar.Height;
                        toolbar.Parent.Width = sztemp.Width;
                    }
                    else
                        sznew = szmaxwrap;

                    // Set the CommandBar's client size to be equal to this new size.
                    arg.ClientSize = sznew;
                }
                else if (ffactor <= 1)
                {
                    arg.ClientSize = szminwrap;
                }
                else
                {
                    arg.ClientSize = toolbar.Size;
                }
            }
        }

#region AboutForm_Logic

        DemoCommon.AboutForm aboutForm = null;
        private void menuItem13_Click(object sender, System.EventArgs e)
        {
            
        }

#endregion AboutForm_Logic

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            foreach (CommandBar bar in this.commandBarController1.CommandBars)
                bar.HideChevron = !this.checkBox1.Checked;
        }

        private void styleComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        { 
            if ((sender as ComboBoxAdv).SelectedIndex == 2)
            {
                this.tbFont.BackColor = Color.FromArgb(168, 198, 239);
                this.tbAlign.BackColor = Color.FromArgb(168, 198, 239);
                this.tbStandard.BackColor = Color.FromArgb(168, 198, 239);
                this.comboBox1.Style = VisualStyle.Office2003;
            }
            else if ((sender as ComboBoxAdv).SelectedIndex == 3)
            {
                this.tbFont.BackColor = Color.FromArgb(245, 245, 245);
                this.tbAlign.BackColor = Color.FromArgb(245, 245, 245);
                this.tbStandard.BackColor = Color.FromArgb(245, 245, 245);
                this.comboBox1.Style = VisualStyle.VS2005;
            }
            else if ((sender as ComboBoxAdv).SelectedIndex == 4)
            {
                this.tbFont.BackColor = Color.FromArgb(186, 216, 255);
                this.tbAlign.BackColor = Color.FromArgb(186, 216, 255);
                this.tbStandard.BackColor = Color.FromArgb(186, 216, 255);
                this.comboBox1.Style = VisualStyle.Office2007;
            }
            else if ((sender as ComboBoxAdv).SelectedIndex == 5)
            {
                this.tbFont.BackColor = Color.FromArgb(186, 216, 255);
                this.tbAlign.BackColor = Color.FromArgb(186, 216, 255);
                this.tbStandard.BackColor = Color.FromArgb(186, 216, 255);
                this.comboBox1.Style = VisualStyle.Office2007Outlook;
            }
            else if ((sender as ComboBoxAdv).SelectedIndex == 6)
            {
                this.tbFont.BackColor = Color.FromArgb(176, 201, 229);
                this.tbAlign.BackColor = Color.FromArgb(176, 201, 229);
                this.tbStandard.BackColor = Color.FromArgb(176, 201, 229);
                this.comboBox1.Style = VisualStyle.Office2010;
            }
            else if ((sender as ComboBoxAdv).SelectedIndex == 7)
            {
                this.tbFont.BackColor = Color.White;
                this.tbAlign.BackColor = Color.White;
                this.tbStandard.BackColor = Color.White;
                this.comboBox1.Style = VisualStyle.VS2010;
            }
            else if ((sender as ComboBoxAdv).SelectedIndex == 8)
            {
                this.tbFont.BackColor = Color.White;
                this.tbAlign.BackColor = Color.White;
                this.tbStandard.BackColor = Color.White;
                this.comboBox1.Style = VisualStyle.Metro;
            }
            else if ((sender as ComboBoxAdv).SelectedIndex == 9)
            {
                this.tbFont.BackColor = Color.FromArgb(1, 115, 199);
                this.tbAlign.BackColor = Color.FromArgb(1, 115, 199);
                this.tbStandard.BackColor = Color.FromArgb(1, 115, 199);
                this.comboBox1.Style = VisualStyle.Office2016Colorful;
            }
            else if ((sender as ComboBoxAdv).SelectedIndex == 10)
            {
                this.tbFont.BackColor = Color.White;
                this.tbAlign.BackColor = Color.White;
                this.tbStandard.BackColor = Color.White;
                this.comboBox1.Style = VisualStyle.Office2016White;
            }
            else if ((sender as ComboBoxAdv).SelectedIndex == 11)
            {
                this.tbFont.BackColor = Color.FromArgb(10, 10, 10);
                this.tbAlign.BackColor = Color.FromArgb(10, 10, 10);
                this.tbStandard.BackColor = Color.FromArgb(10, 10, 10);
                this.comboBox1.Style = VisualStyle.Office2016Black;
            }
            else if ((sender as ComboBoxAdv).SelectedIndex == 12)
            {
                this.tbFont.BackColor = Color.FromArgb(68, 68, 68);
                this.tbAlign.BackColor = Color.FromArgb(68, 68, 68);
                this.tbStandard.BackColor = Color.FromArgb(68, 68, 68);
                this.comboBox1.Style = VisualStyle.Office2016DarkGray;
            }
            Syncfusion.Windows.Forms.VisualStyle vstyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            try
            {
                vstyle = (Syncfusion.Windows.Forms.VisualStyle)Enum.Parse(typeof(Syncfusion.Windows.Forms.VisualStyle), this.styleComboBox.Text);
            }
            catch
            {

            }
            this.commandBarController1.Style = vstyle;
            this.mainFrameBarManager1.Style = vstyle;
            foreach (CommandBar bar in this.commandBarController1.CommandBars)
                bar.Refresh();

        }

        private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
        {
            foreach (CommandBar bar in this.commandBarController1.CommandBars)
            {
                if (bar.Name != "commandBarStandard")
                {
                    bar.HideDropDownButton = !this.checkBox2.Checked;
                    this.commandBarController1.RecalcLayout(bar);
                }
            }

        }

        private void AllowFloating_CheckedChanged(object sender, EventArgs e)
        {
            foreach (CommandBar bar in this.commandBarController1.CommandBars)
            {
                if (bar.Visible)
                bar.DisableDocking = !this.AllowDocking.Checked;
            }
        }

        private void AllowDocking_CheckedChanged(object sender, EventArgs e)
        {
            foreach (CommandBar bar in this.commandBarController1.CommandBars)
            {
                bar.DisableFloating = !this.AllowFloating.Checked;
            }

        }

        private void barItem1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
        }

        private void barItem2_Click(object sender, EventArgs e)
        {
            this.OpenDocument();
        }

        private void barItem3_Click(object sender, EventArgs e)
        {
            this.SaveDocument();
        }

        private void barItem4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void barItem5_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Cut();
        }

        private void barItem6_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Copy();
        }

        private void barItem7_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Paste();
        }

        private void barItem8_Click(object sender, EventArgs e)
        {
            this.commandBarStandard.Visible = !this.barItem8.Checked;
            this.barItem8.Checked = !this.barItem8.Checked;
        }

        private void barItem9_Click(object sender, EventArgs e)
        {
            this.commandBarFonts.Visible = !this.barItem9.Checked;
            this.barItem9.Checked = !this.barItem9.Checked;
        }

        private void barItem10_Click(object sender, EventArgs e)
        {
            this.commandBarAlign.Visible = !this.barItem10.Checked;
            this.barItem10.Checked = !this.barItem10.Checked;
        }

        private void barItem11_Click(object sender, EventArgs e)
        {
            this.commandBarAddress.Visible = !this.barItem11.Checked;
            this.barItem11.Checked = !this.barItem11.Checked;
        }

        private void barItem12_Click(object sender, EventArgs e)
        {
            aboutForm = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            aboutForm.ShowDialog();
        }

        /*
        // This method is not used anywhere and is provided only to show how to 
        // programmatically initialize the CommandBars.
        // <samplecodeblock name="CommandBars">
        private void InitializeCommandBars()
        {	
            // Create the CommandBarController.
            this.commandBarController1 = new Syncfusion.Windows.Forms.Tools.CommandBarController();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarController1)).BeginInit();

            // Set the CommandBarController's host form.
            this.commandBarController1.HostForm = this;
            this.commandBarController1.PersistState = true;

            // Create the CommandBar control.
            this.commandBarAddress = new Syncfusion.Windows.Forms.Tools.CommandBar();

            // Set the CommandBar Layout/Behavior/Appearance attributes.
            this.commandBarAddress.DockBorder = Syncfusion.Windows.Forms.Tools.DockBorder.Top;
            this.commandBarAddress.HideDropDownButton = true;
            this.commandBarAddress.MaxLength = 400;
            this.commandBarAddress.MinHeight = 26;
            this.commandBarAddress.MinLength = 50;
            this.commandBarAddress.Name = "commandBarAddress";
            this.commandBarAddress.RowIndex = 1;
            this.commandBarAddress.RowOffset = 1;
            this.commandBarAddress.Text = "Address";

            // Create the Combo Box control and add it to the CommandBar's Controls collection.
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.commandBarAddress.Controls.AddRange(new System.Windows.Forms.Control[] {this.comboBox1});

            // Add the CommandBar to the CommandBarController.CommandBars collection.
            this.commandBarController1.CommandBars.Add(this.commandBarAddress);

            ((System.ComponentModel.ISupportInitialize)(this.commandBarController1)).EndInit();
        }
        //</samplecodeblock>
        */

    }
}