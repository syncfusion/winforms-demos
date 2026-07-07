 #region Copyright Syncfusion Inc. 2001 - 2019
//
//  Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

namespace XPToolbars_2005
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;

	using Syncfusion.Windows.Forms.Tools;
	using Syncfusion.Windows.Forms.Tools.XPMenus;
	using Syncfusion.Windows.Forms;

	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : MetroForm
    {
        #region Members
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar xpToolBar1;
        private System.Windows.Forms.ImageList imageList1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem5;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem copyItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem cutItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem pasteItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem undoItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem redoItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem fontColorItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem aboutItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem6;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem7;
        private Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar xpToolBar2;
        private BarItem barItem8;

        private Panel panel1;
        private DockingManager dockingManager1;
        private Panel panel2;
        private XPToolBar xpToolBar3;
        private BarItem barItem9;
        private ComboBoxBarItem comboBoxBarItem1;
        private BarItem barItem10;
        private BarItem barItem11;
        private BarItem barItem12;
        private BarItem barItem13;
        private BarItem barItem14;
        private XPToolBar xpToolBar4;
        private BarItem barItem15;
        private BarItem barItem16;
        private BarItem barItem17;
        private ComboBoxBarItem comboBoxBarItem2;
        private BarItem barItem18;
        private ParentBarItem parentBarItem3;
        private DropDownBarItem dropDownBarItem1;
        private ParentBarItem parentBarItem4;
        private BarItem barItem19;
        private ParentBarItem parentBarItem5;
        private BarItem barItem20;
        private ParentBarItem parentBarItem6;
        private Panel panel3;
        private Panel panel4;
        private XPToolBar xpToolBar5;
        private GroupBox groupBox1;
        private GradientLabel gradientLabel3;
        private CheckBoxAdv checkBoxAdv2;
        private ComboBoxAdv comboBoxAdv1;
        private XPToolBar xpToolBar6;
        private BarItem barItem21;
        private BarItem barItem22;
        private BarItem barItem23;
        private BarItem barItem24;
        private BarItem barItem25;
        private BarItem barItem26;
        private BarItem barItem27;
        private Label label13;
        private Label label26;
        private BarItem barItem28;
        private BarItem barItem29;
        private BarItem barItem30;
        private BarItem barItem31;
        private ParentBarItem parentBarItem7;
        private BarItem barItem32;
        private DropDownBarItem dropDownBarItem2;
        private ComboBoxBarItem comboBoxBarItem3;
        private StaticBarItem staticBarItem1;
        private BarItem barItem33;
        private BarItem barItem34;
        private PopupControlContainer popupControlContainer2;
        private ColorPickerUIAdv colorPickerUIAdv1;
        private BarItem barItem35;
        private BarItem barItem36;
        private BarItem barItem37;
        private System.ComponentModel.IContainer components;
        #endregion

        #region Form Load and Constructor
        public Form1()
        {
            InitializeComponent();                       
            this.MinimumSize = this.Size;                        
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            this.comboBoxAdv1.SelectedIndex = 0;
            UpdateToolBarStyleforOffice2016Themes();
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

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.propertyGrid1.SelectedObject = this.xpToolBar1;
        }
        #endregion

        #region Dispose
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

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbpanel1 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbpanel2 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            this.dockingManager1 = new Syncfusion.Windows.Forms.Tools.DockingManager(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.xpToolBar4 = new Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar();
            this.barItem15 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem16 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem17 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.xpToolBar3 = new Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar();
            this.barItem9 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.comboBoxBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem();
            this.barItem11 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem12 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem13 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem14 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.copyItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.cutItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.pasteItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.undoItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.redoItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.fontColorItem = new Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem();
            this.aboutItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.xpToolBar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.popupControlContainer2 = new Syncfusion.Windows.Forms.PopupControlContainer();
            this.colorPickerUIAdv1 = new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv();
            this.xpToolBar2 = new Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar();
            this.barItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.comboBoxBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem();
            this.barItem18 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem33 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem34 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.dropDownBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem();
            this.parentBarItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem35 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem19 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem36 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem20 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem37 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem10 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.xpToolBar6 = new Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar();
            this.barItem21 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem22 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem23 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem24 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem25 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem26 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem27 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.checkBoxAdv2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.gradientLabel3 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.xpToolBar5 = new Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar();
            this.barItem31 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem32 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.dropDownBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem();
            this.comboBoxBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem();
            this.staticBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.StaticBarItem();
            this.barItem28 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem29 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem30 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.popupControlContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // dockingManager1
            // 
            this.dockingManager1.ActiveCaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockingManager1.AnimateAutoHiddenWindow = true;
            this.dockingManager1.AutoHideTabForeColor = System.Drawing.Color.Empty;
#if !NETCORE
            this.dockingManager1.DockLayoutStream = ((System.IO.MemoryStream)(resources.GetObject("dockingManager1.DockLayoutStream")));
#endif
            this.dockingManager1.DockToFill = true;
            this.dockingManager1.HostControl = this;
            this.dockingManager1.ImageList = this.imageList1;
            this.dockingManager1.InActiveCaptionBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212))))));
            this.dockingManager1.InActiveCaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockingManager1.MetroButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dockingManager1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.dockingManager1.MetroSplitterBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(159)))), ((int)(((byte)(183)))));
            this.dockingManager1.ReduceFlickeringInRtl = false;
            this.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Restore, "RestoreButton"));
            this.dockingManager1.SetDockLabel(this.panel1, "panel1");
            this.dockingManager1.SetEnableDocking(this.panel1, true);
            ccbpanel1.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.panel1, ccbpanel1);
            this.dockingManager1.SetDockLabel(this.panel2, "panel2");
            this.dockingManager1.SetEnableDocking(this.panel2, true);
            ccbpanel2.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.panel2, ccbpanel2);
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
            this.imageList1.Images.SetKeyName(14, "document_out.png");
            this.imageList1.Images.SetKeyName(15, "document_down.png");
            this.imageList1.Images.SetKeyName(16, "document_up.png");
            this.imageList1.Images.SetKeyName(17, "document_error.png");
            this.imageList1.Images.SetKeyName(18, "window_preferences.png");
            this.imageList1.Images.SetKeyName(19, "window.png");
            this.imageList1.Images.SetKeyName(20, "window_delete.png");
            this.imageList1.Images.SetKeyName(21, "delete.png");
            this.imageList1.Images.SetKeyName(22, "warning.png");
            this.imageList1.Images.SetKeyName(23, "about.png");
            this.imageList1.Images.SetKeyName(24, "Office.ico");
            this.imageList1.Images.SetKeyName(25, "book_red.png");
            this.imageList1.Images.SetKeyName(26, "cubes.png");
            this.imageList1.Images.SetKeyName(27, "star_blue.png");
            this.imageList1.Images.SetKeyName(28, "document_stop.png");
            this.imageList1.Images.SetKeyName(29, "checks.png");
            this.imageList1.Images.SetKeyName(30, "document_edit.png");
            this.imageList1.Images.SetKeyName(31, "document_into.png");
            this.imageList1.Images.SetKeyName(32, "earth_find.png");
            this.imageList1.Images.SetKeyName(33, "save_icon.png");
            this.imageList1.Images.SetKeyName(34, "new_icon.png");
            this.imageList1.Images.SetKeyName(35, "open_icon.png");
            this.imageList1.Images.SetKeyName(36, "syncfusion.ico");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.xpToolBar4);
            this.panel1.Location = new System.Drawing.Point(1, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 86);
            this.panel1.TabIndex = 5;
            // 
            // xpToolBar4
            // 
            // 
            // 
            // 
            this.xpToolBar4.Bar.BarName = "";
            this.xpToolBar4.Bar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem15,
            this.barItem16,
            this.barItem17});
            this.xpToolBar4.Bar.Manager = null;
            this.xpToolBar4.Bar.SeparatorIndices.AddRange(new int[] {
            1,
            2});
            this.xpToolBar4.Dock = System.Windows.Forms.DockStyle.Top;
            this.xpToolBar4.Location = new System.Drawing.Point(0, 0);
            this.xpToolBar4.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xpToolBar4.Name = "xpToolBar4";
            this.xpToolBar4.SeparatorIndices.AddRange(new int[] {
            1,
            2});
            this.xpToolBar4.Size = new System.Drawing.Size(225, 53);
            this.xpToolBar4.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.xpToolBar4.TabIndex = 0;
            this.xpToolBar4.Text = "xpToolBar4";
            // 
            // barItem15
            // 
            this.barItem15.BarName = "barItem15";
            this.barItem15.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem15.ID = "0 Errors";
            this.barItem15.ImageIndex = 21;
            this.barItem15.ImageList = this.imageList1;
            this.barItem15.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.barItem15.ShowToolTipInPopUp = false;
            this.barItem15.SizeToFit = true;
            this.barItem15.Text = "0 Errors";
            this.barItem15.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // barItem16
            // 
            this.barItem16.BarName = "barItem16";
            this.barItem16.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem16.ID = "0 Warnings";
            this.barItem16.ImageIndex = 22;
            this.barItem16.ImageList = this.imageList1;
            this.barItem16.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.barItem16.ShowToolTipInPopUp = false;
            this.barItem16.SizeToFit = true;
            this.barItem16.Text = "0 Warnings";
            this.barItem16.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // barItem17
            // 
            this.barItem17.BarName = "barItem17";
            this.barItem17.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem17.ID = "0 Messages";
            this.barItem17.ImageIndex = 23;
            this.barItem17.ImageList = this.imageList1;
            this.barItem17.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.barItem17.ShowToolTipInPopUp = false;
            this.barItem17.SizeToFit = true;
            this.barItem17.Text = "0 Messages";
            this.barItem17.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.xpToolBar3);
            this.panel2.Location = new System.Drawing.Point(1, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 86);
            this.panel2.TabIndex = 8;
            // 
            // xpToolBar3
            // 
            // 
            // 
            // 
            this.xpToolBar3.Bar.BarName = "";
            this.xpToolBar3.Bar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem9,
            this.comboBoxBarItem1,
            this.barItem11,
            this.barItem12,
            this.barItem13,
            this.barItem14});
            this.xpToolBar3.Bar.Manager = null;
            this.xpToolBar3.Bar.SeparatorIndices.AddRange(new int[] {
            2,
            3,
            5});
            this.xpToolBar3.Dock = System.Windows.Forms.DockStyle.Top;
            this.xpToolBar3.Location = new System.Drawing.Point(0, 0);
            this.xpToolBar3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xpToolBar3.Name = "xpToolBar3";
            this.xpToolBar3.SeparatorIndices.AddRange(new int[] {
            2,
            3,
            5});
            this.xpToolBar3.Size = new System.Drawing.Size(222, 53);
            this.xpToolBar3.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.xpToolBar3.TabIndex = 0;
            this.xpToolBar3.Text = "xpToolBar3";
            // 
            // barItem9
            // 
            this.barItem9.BarName = "barItem9";
            this.barItem9.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem9.ID = "Show output from:";
            this.barItem9.ImageList = this.imageList1;
            this.barItem9.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.barItem9.ShowToolTipInPopUp = false;
            this.barItem9.SizeToFit = true;
            this.barItem9.Text = "Show output from:";
            // 
            // comboBoxBarItem1
            // 
            this.comboBoxBarItem1.BarName = "comboBoxBarItem1";
            this.comboBoxBarItem1.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.comboBoxBarItem1.ID = "Debug";
            this.comboBoxBarItem1.ShowToolTipInPopUp = false;
            this.comboBoxBarItem1.SizeToFit = true;
            this.comboBoxBarItem1.TextBoxValue = "Debug";
            // 
            // barItem11
            // 
            this.barItem11.BarName = "barItem11";
            this.barItem11.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem11.ImageIndex = 15;
            this.barItem11.ImageList = this.imageList1;
            this.barItem11.ShowToolTipInPopUp = false;
            this.barItem11.SizeToFit = true;
            this.barItem11.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // barItem12
            // 
            this.barItem12.BarName = "barItem12";
            this.barItem12.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem12.ImageIndex = 16;
            this.barItem12.ImageList = this.imageList1;
            this.barItem12.ShowToolTipInPopUp = false;
            this.barItem12.SizeToFit = true;
            this.barItem12.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // barItem13
            // 
            this.barItem13.BarName = "barItem13";
            this.barItem13.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem13.ImageIndex = 17;
            this.barItem13.ImageList = this.imageList1;
            this.barItem13.ShowToolTipInPopUp = false;
            this.barItem13.SizeToFit = true;
            this.barItem13.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // barItem14
            // 
            this.barItem14.BarName = "barItem14";
            this.barItem14.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem14.ImageIndex = 18;
            this.barItem14.ImageList = this.imageList1;
            this.barItem14.ShowToolTipInPopUp = false;
            this.barItem14.SizeToFit = true;
            this.barItem14.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.BarName = "parentBarItem1";
            this.parentBarItem1.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.WrapLength = 20;
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.BarName = "parentBarItem2";
            this.parentBarItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.copyItem,
            this.cutItem,
            this.pasteItem,
            this.undoItem,
            this.redoItem,
            this.fontColorItem,
            this.aboutItem});
            this.parentBarItem2.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem2.SeparatorIndices.AddRange(new int[] {
            3,
            5,
            6});
            this.parentBarItem2.ShowToolTipInPopUp = false;
            this.parentBarItem2.SizeToFit = true;
            this.parentBarItem2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItem2.WrapLength = 20;
            // 
            // copyItem
            // 
            this.copyItem.BarName = "copyItem";
            this.copyItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyItem.ID = "&Copy";
            this.copyItem.ImageIndex = 8;
            this.copyItem.ImageList = this.imageList1;
            this.copyItem.ShowToolTipInPopUp = false;
            this.copyItem.SizeToFit = true;
            this.copyItem.Text = "&Copy";
            // 
            // cutItem
            // 
            this.cutItem.BarName = "cutItem";
            this.cutItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cutItem.ID = "Cu&t";
            this.cutItem.ImageIndex = 9;
            this.cutItem.ImageList = this.imageList1;
            this.cutItem.ShowToolTipInPopUp = false;
            this.cutItem.SizeToFit = true;
            this.cutItem.Text = "Cu&t";
            // 
            // pasteItem
            // 
            this.pasteItem.BarName = "pasteItem";
            this.pasteItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pasteItem.ID = "&Paste";
            this.pasteItem.ImageIndex = 8;
            this.pasteItem.ImageList = this.imageList1;
            this.pasteItem.ShowToolTipInPopUp = false;
            this.pasteItem.SizeToFit = true;
            this.pasteItem.Text = "&Paste";
            // 
            // undoItem
            // 
            this.undoItem.BarName = "undoItem";
            this.undoItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.undoItem.ID = "&Undo";
            this.undoItem.ImageIndex = 12;
            this.undoItem.ImageList = this.imageList1;
            this.undoItem.ShowToolTipInPopUp = false;
            this.undoItem.SizeToFit = true;
            this.undoItem.Text = "&Undo";
            // 
            // redoItem
            // 
            this.redoItem.BarName = "redoItem";
            this.redoItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.redoItem.ID = "&Redo";
            this.redoItem.ImageIndex = 13;
            this.redoItem.ImageList = this.imageList1;
            this.redoItem.ShowToolTipInPopUp = false;
            this.redoItem.SizeToFit = true;
            this.redoItem.Text = "&Redo";
            // 
            // fontColorItem
            // 
            this.fontColorItem.BarName = "fontColorItem";
            this.fontColorItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fontColorItem.ID = "Font Color";
            this.fontColorItem.ImageIndex = 10;
            this.fontColorItem.ImageList = this.imageList1;
            this.fontColorItem.ShowToolTipInPopUp = false;
            this.fontColorItem.SizeToFit = true;
            this.fontColorItem.Text = "Font Color";
            // 
            // aboutItem
            // 
            this.aboutItem.BarName = "aboutItem";
            this.aboutItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.aboutItem.ID = "&About Syncfusion";
            this.aboutItem.ImageIndex = 14;
            this.aboutItem.ImageList = this.imageList1;
            this.aboutItem.ShowToolTipInPopUp = false;
            this.aboutItem.SizeToFit = true;
            this.aboutItem.Text = "&About Syncfusion...";
            this.aboutItem.Click += new System.EventHandler(this.aboutItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.propertyGrid1);
            this.groupBox2.Controls.Add(this.xpToolBar1);
            this.groupBox2.Controls.Add(this.popupControlContainer2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(465, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 404);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "XPToolBar (Used outside the menus)";
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.CommandsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(212)))), ((int)(((byte)(230)))));
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyGrid1.HelpVisible = false;
            this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
            this.propertyGrid1.Location = new System.Drawing.Point(3, 42);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(227, 359);
            this.propertyGrid1.TabIndex = 1;
            this.propertyGrid1.ToolbarVisible = false;
            // 
            // xpToolBar1
            // 
            // 
            // 
            // 
            this.xpToolBar1.Bar.BarName = "";
            this.xpToolBar1.Bar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem2,
            this.barItem1,
            this.barItem3,
            this.barItem5,
            this.barItem4,
            this.barItem6,
            this.barItem7});
            this.xpToolBar1.Bar.Manager = null;
            this.xpToolBar1.Bar.SeparatorIndices.AddRange(new int[] {
            2,
            4,
            5});
            this.xpToolBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xpToolBar1.Font = new System.Drawing.Font("Calibri", 12F);
            this.xpToolBar1.Location = new System.Drawing.Point(3, 17);
            this.xpToolBar1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xpToolBar1.Name = "xpToolBar1";
            this.xpToolBar1.SeparatorIndices.AddRange(new int[] {
            2,
            4,
            5});
            this.xpToolBar1.Size = new System.Drawing.Size(227, 25);
            this.xpToolBar1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.xpToolBar1.TabIndex = 0;
            this.xpToolBar1.Text = "xpToolBar1";
            // 
            // barItem2
            // 
            this.barItem2.BarName = "barItem2";
            this.barItem2.CustomTextFont = new System.Drawing.Font("Calibri", 12F);
            this.barItem2.ID = "Categorized";
            this.barItem2.ImageIndex = 1;
            this.barItem2.ImageList = this.imageList1;
            this.barItem2.Shortcut = System.Windows.Forms.Shortcut.Ctrl1;
            this.barItem2.ShowToolTipInPopUp = false;
            this.barItem2.SizeToFit = true;
            this.barItem2.Text = "Categorized";
            this.barItem2.Click += new System.EventHandler(this.barItem2_Click);
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.CustomTextFont = new System.Drawing.Font("Calibri", 12F);
            this.barItem1.ID = "Alphabetic";
            this.barItem1.ImageIndex = 0;
            this.barItem1.ImageList = this.imageList1;
            this.barItem1.Shortcut = System.Windows.Forms.Shortcut.Ctrl2;
            this.barItem1.ShowToolTipInPopUp = false;
            this.barItem1.SizeToFit = true;
            this.barItem1.Text = "Alphabetic";
            this.barItem1.Click += new System.EventHandler(this.barItem1_Click);
            // 
            // barItem3
            // 
            this.barItem3.BarName = "barItem3";
            this.barItem3.CustomTextFont = new System.Drawing.Font("Calibri", 12F);
            this.barItem3.ID = "Properties";
            this.barItem3.ImageIndex = 2;
            this.barItem3.ImageList = this.imageList1;
            this.barItem3.Shortcut = System.Windows.Forms.Shortcut.Ctrl3;
            this.barItem3.ShowToolTipInPopUp = false;
            this.barItem3.SizeToFit = true;
            this.barItem3.Text = "Properties";
            this.barItem3.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // barItem5
            // 
            this.barItem5.BarName = "barItem5";
            this.barItem5.CustomTextFont = new System.Drawing.Font("Calibri", 12F);
            this.barItem5.ID = "Events";
            this.barItem5.ImageIndex = 4;
            this.barItem5.ImageList = this.imageList1;
            this.barItem5.Shortcut = System.Windows.Forms.Shortcut.Ctrl4;
            this.barItem5.ShowToolTipInPopUp = false;
            this.barItem5.SizeToFit = true;
            this.barItem5.Text = "Events";
            this.barItem5.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // barItem4
            // 
            this.barItem4.BarName = "barItem4";
            this.barItem4.CustomTextFont = new System.Drawing.Font("Calibri", 12F);
            this.barItem4.ID = "Property Pages";
            this.barItem4.ImageIndex = 3;
            this.barItem4.ImageList = this.imageList1;
            this.barItem4.Shortcut = System.Windows.Forms.Shortcut.Ctrl5;
            this.barItem4.ShowToolTipInPopUp = false;
            this.barItem4.SizeToFit = true;
            this.barItem4.Text = "Show All";
            this.barItem4.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // barItem6
            // 
            this.barItem6.BarName = "barItem6";
            this.barItem6.CustomTextFont = new System.Drawing.Font("Calibri", 12F);
            this.barItem6.ID = "Run";
            this.barItem6.ImageIndex = 5;
            this.barItem6.ImageList = this.imageList1;
            this.barItem6.Shortcut = System.Windows.Forms.Shortcut.Ctrl6;
            this.barItem6.ShowToolTipInPopUp = false;
            this.barItem6.SizeToFit = true;
            this.barItem6.Text = "Run Button";
            this.barItem6.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // barItem7
            // 
            this.barItem7.BarName = "barItem7";
            this.barItem7.Checked = true;
            this.barItem7.CustomTextFont = new System.Drawing.Font("Calibri", 12F);
            this.barItem7.ID = "Style";
            this.barItem7.ImageIndex = 6;
            this.barItem7.ImageList = this.imageList1;
            this.barItem7.Shortcut = System.Windows.Forms.Shortcut.Ctrl7;
            this.barItem7.ShowToolTipInPopUp = false;
            this.barItem7.SizeToFit = true;
            this.barItem7.Text = "Style Toggled";
            this.barItem7.Click += new System.EventHandler(this.barItem7_Click);
            // 
            // popupControlContainer2
            // 
            this.popupControlContainer2.Controls.Add(this.colorPickerUIAdv1);
            this.popupControlContainer2.Location = new System.Drawing.Point(6, 95);
            this.popupControlContainer2.Name = "popupControlContainer2";
            this.popupControlContainer2.Size = new System.Drawing.Size(164, 239);
            this.popupControlContainer2.TabIndex = 3;
            // 
            // colorPickerUIAdv1.RecentGroup
            // 
            this.colorPickerUIAdv1.RecentGroup.Name = "RecentColors";
            this.colorPickerUIAdv1.RecentGroup.Visible = false;
            // 
            // colorPickerUIAdv1.StandardGroup
            // 
            this.colorPickerUIAdv1.StandardGroup.Name = "StandardColors";
            // 
            // colorPickerUIAdv1.ThemeGroup
            // 
            this.colorPickerUIAdv1.ThemeGroup.IsSubItemsVisible = true;
            this.colorPickerUIAdv1.ThemeGroup.Name = "ThemeColors";
            // 
            // colorPickerUIAdv1
            // 
            this.colorPickerUIAdv1.BeforeTouchSize = new System.Drawing.Size(13, 13);
            this.colorPickerUIAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPickerUIAdv1.ColorItemSize = new System.Drawing.Size(15, 16);
            this.colorPickerUIAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorPickerUIAdv1.HorizontalItemsSpacing = 0;
            this.colorPickerUIAdv1.Location = new System.Drawing.Point(0, 0);
            this.colorPickerUIAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.colorPickerUIAdv1.MinimumSize = new System.Drawing.Size(136, 195);
            this.colorPickerUIAdv1.Name = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.SelectedColor = System.Drawing.Color.Empty;
            this.colorPickerUIAdv1.Size = new System.Drawing.Size(164, 239);
            this.colorPickerUIAdv1.Style = Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.visualstyle.Metro;
            this.colorPickerUIAdv1.TabIndex = 0;
            this.colorPickerUIAdv1.Text = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.UseOffice2007Style = false;
            this.colorPickerUIAdv1.Picked += new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventHandler(this.colorPickerUIAdv1_Picked);
            // 
            // xpToolBar2
            // 
            // 
            // 
            // 
            this.xpToolBar2.Bar.BarName = "";
            this.xpToolBar2.Bar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem8,
            this.comboBoxBarItem2,
            this.barItem18,
            this.parentBarItem3,
            this.dropDownBarItem1,
            this.parentBarItem4,
            this.barItem19,
            this.parentBarItem5,
            this.barItem20,
            this.parentBarItem6});
            this.xpToolBar2.Bar.Manager = null;
            this.xpToolBar2.Bar.SeparatorIndices.AddRange(new int[] {
            3,
            5,
            7});
            this.xpToolBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.xpToolBar2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.xpToolBar2.Location = new System.Drawing.Point(10, 10);
            this.xpToolBar2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xpToolBar2.Name = "xpToolBar2";
            this.xpToolBar2.SeparatorIndices.AddRange(new int[] {
            3,
            5,
            7});
            this.xpToolBar2.Size = new System.Drawing.Size(688, 25);
            this.xpToolBar2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.xpToolBar2.TabIndex = 4;
            this.xpToolBar2.Text = "xpToolBar2";
            // 
            // barItem8
            // 
            this.barItem8.BarName = "barItem8";
            this.barItem8.CustomActiveTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(125)))));
            this.barItem8.CustomNormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(125)))));
            this.barItem8.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem8.ID = "New";
            this.barItem8.ImageIndex = 36;
            this.barItem8.ImageList = this.imageList1;
            this.barItem8.ImageSize = new System.Drawing.Size(32, 32);
            this.barItem8.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.barItem8.ShowToolTipInPopUp = false;
            this.barItem8.SizeToFit = true;
            this.barItem8.Text = "Syncfusion ";
            this.barItem8.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // comboBoxBarItem2
            // 
            this.comboBoxBarItem2.BarName = "comboBoxBarItem2";
            this.comboBoxBarItem2.ChoiceList.AddRange(new string[] {
            "Http:",
            "www"});
            this.comboBoxBarItem2.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.comboBoxBarItem2.ImageIndex = 24;
            this.comboBoxBarItem2.ImageList = this.imageList1;
            this.comboBoxBarItem2.MinWidth = 60;
            this.comboBoxBarItem2.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.comboBoxBarItem2.ShowToolTipInPopUp = false;
            this.comboBoxBarItem2.SizeToFit = true;
            // 
            // barItem18
            // 
            this.barItem18.BarName = "barItem18";
            this.barItem18.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem18.ID = "Go";
            this.barItem18.ShowToolTipInPopUp = false;
            this.barItem18.SizeToFit = true;
            this.barItem18.Text = "Go";
            this.barItem18.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // parentBarItem3
            // 
            this.parentBarItem3.BarName = "parentBarItem3";
            this.parentBarItem3.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.parentBarItem3.ImageIndex = 25;
            this.parentBarItem3.ImageList = this.imageList1;
            this.parentBarItem3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem33,
            this.barItem34});
            this.parentBarItem3.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem3.ShowToolTipInPopUp = false;
            this.parentBarItem3.SizeToFit = true;
            this.parentBarItem3.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem3.WrapLength = 20;
            // 
            // barItem33
            // 
            this.barItem33.BarName = "barItem33";
            this.barItem33.ID = "Item1";
            this.barItem33.ShowToolTipInPopUp = false;
            this.barItem33.SizeToFit = true;
            this.barItem33.Text = "Item1";
            this.barItem33.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // barItem34
            // 
            this.barItem34.BarName = "barItem34";
            this.barItem34.ID = "Item2";
            this.barItem34.ShowToolTipInPopUp = false;
            this.barItem34.SizeToFit = true;
            this.barItem34.Text = "Item2";
            this.barItem34.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // dropDownBarItem1
            // 
            this.dropDownBarItem1.BarName = "dropDownBarItem1";
            this.dropDownBarItem1.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dropDownBarItem1.ImageIndex = 26;
            this.dropDownBarItem1.ImageList = this.imageList1;
            this.dropDownBarItem1.PopupControlContainer = this.popupControlContainer2;
            this.dropDownBarItem1.ShowToolTipInPopUp = false;
            this.dropDownBarItem1.SizeToFit = true;
            // 
            // parentBarItem4
            // 
            this.parentBarItem4.BarName = "parentBarItem4";
            this.parentBarItem4.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.parentBarItem4.ID = "BookMArks";
            this.parentBarItem4.ImageIndex = 27;
            this.parentBarItem4.ImageList = this.imageList1;
            this.parentBarItem4.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem35});
            this.parentBarItem4.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem4.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.parentBarItem4.ShowToolTipInPopUp = false;
            this.parentBarItem4.SizeToFit = true;
            this.parentBarItem4.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem4.Text = "Bookmarks";
            this.parentBarItem4.WrapLength = 20;
            // 
            // barItem35
            // 
            this.barItem35.BarName = "barItem35";
            this.barItem35.ID = "Item1";
            this.barItem35.ShowToolTipInPopUp = false;
            this.barItem35.SizeToFit = true;
            this.barItem35.Text = "Item1";
            this.barItem35.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // barItem19
            // 
            this.barItem19.BarName = "barItem19";
            this.barItem19.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem19.ID = "12 Blocked";
            this.barItem19.ImageIndex = 28;
            this.barItem19.ImageList = this.imageList1;
            this.barItem19.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.barItem19.ShowToolTipInPopUp = false;
            this.barItem19.SizeToFit = true;
            this.barItem19.Text = "14 Blocked";
            this.barItem19.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // parentBarItem5
            // 
            this.parentBarItem5.BarName = "parentBarItem5";
            this.parentBarItem5.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.parentBarItem5.ID = "Check";
            this.parentBarItem5.ImageIndex = 29;
            this.parentBarItem5.ImageList = this.imageList1;
            this.parentBarItem5.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem36});
            this.parentBarItem5.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem5.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.parentBarItem5.ShowToolTipInPopUp = false;
            this.parentBarItem5.SizeToFit = true;
            this.parentBarItem5.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem5.Text = "Check";
            this.parentBarItem5.WrapLength = 20;
            // 
            // barItem36
            // 
            this.barItem36.BarName = "barItem36";
            this.barItem36.ID = "Item1";
            this.barItem36.ShowToolTipInPopUp = false;
            this.barItem36.SizeToFit = true;
            this.barItem36.Text = "Item";
            this.barItem36.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // barItem20
            // 
            this.barItem20.BarName = "barItem20";
            this.barItem20.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem20.ID = "Autofill";
            this.barItem20.ImageIndex = 30;
            this.barItem20.ImageList = this.imageList1;
            this.barItem20.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.barItem20.ShowToolTipInPopUp = false;
            this.barItem20.SizeToFit = true;
            this.barItem20.Text = "AutoFill";
            this.barItem20.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // parentBarItem6
            // 
            this.parentBarItem6.BarName = "parentBarItem6";
            this.parentBarItem6.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.parentBarItem6.ID = "SendTo";
            this.parentBarItem6.ImageIndex = 31;
            this.parentBarItem6.ImageList = this.imageList1;
            this.parentBarItem6.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem37});
            this.parentBarItem6.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem6.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.parentBarItem6.ShowToolTipInPopUp = false;
            this.parentBarItem6.SizeToFit = true;
            this.parentBarItem6.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem6.Text = "Send to";
            this.parentBarItem6.WrapLength = 20;
            // 
            // barItem37
            // 
            this.barItem37.BarName = "barItem37";
            this.barItem37.ID = "Item";
            this.barItem37.ShowToolTipInPopUp = false;
            this.barItem37.SizeToFit = true;
            this.barItem37.Text = "Item";
            this.barItem37.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // barItem10
            // 
            this.barItem10.BarName = "barItem10";
            this.barItem10.CustomTextFont = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem10.ShowToolTipInPopUp = false;
            this.barItem10.SizeToFit = true;
            this.barItem10.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(455, 293);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.xpToolBar6);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.xpToolBar5);
            this.panel4.Location = new System.Drawing.Point(9, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(458, 276);
            this.panel4.TabIndex = 0;
            // 
            // xpToolBar6
            // 
            // 
            // 
            // 
            this.xpToolBar6.Bar.BarName = "";
            this.xpToolBar6.Bar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem21,
            this.barItem22,
            this.barItem23,
            this.barItem24,
            this.barItem25,
            this.barItem26,
            this.barItem27});
            this.xpToolBar6.Bar.Manager = null;
            this.xpToolBar6.Bar.SeparatorIndices.AddRange(new int[] {
            3,
            6});
            this.xpToolBar6.Dock = System.Windows.Forms.DockStyle.Left;
            this.xpToolBar6.Location = new System.Drawing.Point(0, 25);
            this.xpToolBar6.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xpToolBar6.Name = "xpToolBar6";
            this.xpToolBar6.SeparatorIndices.AddRange(new int[] {
            3,
            6});
            this.xpToolBar6.ShowChevron = true;
            this.xpToolBar6.Size = new System.Drawing.Size(25, 249);
            this.xpToolBar6.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.xpToolBar6.TabIndex = 2;
            this.xpToolBar6.Text = "xpToolBar6";
            // 
            // barItem21
            // 
            this.barItem21.BarName = "barItem21";
            this.barItem21.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem21.ImageIndex = 34;
            this.barItem21.ImageList = this.imageList1;
            this.barItem21.ShowToolTipInPopUp = false;
            this.barItem21.SizeToFit = true;
            this.barItem21.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // barItem22
            // 
            this.barItem22.BarName = "barItem22";
            this.barItem22.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem22.ImageIndex = 35;
            this.barItem22.ImageList = this.imageList1;
            this.barItem22.ShowToolTipInPopUp = false;
            this.barItem22.SizeToFit = true;
            this.barItem22.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // barItem23
            // 
            this.barItem23.BarName = "barItem23";
            this.barItem23.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem23.ImageIndex = 33;
            this.barItem23.ImageList = this.imageList1;
            this.barItem23.ShowToolTipInPopUp = false;
            this.barItem23.SizeToFit = true;
            this.barItem23.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // barItem24
            // 
            this.barItem24.BarName = "barItem24";
            this.barItem24.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem24.ImageIndex = 9;
            this.barItem24.ImageList = this.imageList1;
            this.barItem24.ShowToolTipInPopUp = false;
            this.barItem24.SizeToFit = true;
            this.barItem24.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // barItem25
            // 
            this.barItem25.BarName = "barItem25";
            this.barItem25.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem25.ImageIndex = 8;
            this.barItem25.ImageList = this.imageList1;
            this.barItem25.ShowToolTipInPopUp = false;
            this.barItem25.SizeToFit = true;
            this.barItem25.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // barItem26
            // 
            this.barItem26.BarName = "barItem26";
            this.barItem26.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem26.ImageIndex = 11;
            this.barItem26.ImageList = this.imageList1;
            this.barItem26.ShowToolTipInPopUp = false;
            this.barItem26.SizeToFit = true;
            this.barItem26.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // barItem27
            // 
            this.barItem27.BarName = "barItem27";
            this.barItem27.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem27.ImageIndex = 17;
            this.barItem27.ImageList = this.imageList1;
            this.barItem27.ShowToolTipInPopUp = false;
            this.barItem27.SizeToFit = true;
            this.barItem27.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.comboBoxAdv1);
            this.groupBox1.Controls.Add(this.checkBoxAdv2);
            this.groupBox1.Controls.Add(this.gradientLabel3);
            this.groupBox1.Location = new System.Drawing.Point(79, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 161);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label13.Location = new System.Drawing.Point(13, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(170, 1);
            this.label13.TabIndex = 18;
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label26.Location = new System.Drawing.Point(7, 17);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(154, 24);
            this.label26.TabIndex = 17;
            this.label26.Text = "XPToolBar Appearance";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(148, 21);
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Metro",
            "Office2016Colorful",
            "Office2016White",
            "Office2016DarkGray",
            "Office2016Black"});
            this.comboBoxAdv1.Location = new System.Drawing.Point(89, 65);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(148, 21);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.TabIndex = 14;
            this.comboBoxAdv1.Text = "Metro";
            this.comboBoxAdv1.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv1_SelectedIndexChanged);
            // 
            // checkBoxAdv2
            // 
            this.checkBoxAdv2.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxAdv2.DrawFocusRectangle = false;
            this.checkBoxAdv2.Location = new System.Drawing.Point(9, 122);
            this.checkBoxAdv2.MetroColor = System.Drawing.Color.DarkGray;
            this.checkBoxAdv2.Name = "checkBoxAdv2";
            this.checkBoxAdv2.Size = new System.Drawing.Size(151, 23);
            this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv2.TabIndex = 10;
            this.checkBoxAdv2.Text = "HighLightRectangle";
            this.checkBoxAdv2.ThemesEnabled = false;
            this.checkBoxAdv2.CheckStateChanged += new System.EventHandler(this.checkBoxAdv2_CheckStateChanged);
            // 
            // gradientLabel3
            // 
            this.gradientLabel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
            this.gradientLabel3.BeforeTouchSize = new System.Drawing.Size(40, 19);
            this.gradientLabel3.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.gradientLabel3.Location = new System.Drawing.Point(7, 65);
            this.gradientLabel3.Name = "gradientLabel3";
            this.gradientLabel3.Size = new System.Drawing.Size(40, 19);
            this.gradientLabel3.TabIndex = 2;
            this.gradientLabel3.Text = "Styles";
            this.gradientLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xpToolBar5
            // 
            // 
            // 
            // 
            this.xpToolBar5.Bar.BarName = "";
            this.xpToolBar5.Bar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem31,
            this.parentBarItem7,
            this.dropDownBarItem2,
            this.comboBoxBarItem3,
            this.staticBarItem1});
            this.xpToolBar5.Bar.Manager = null;
            this.xpToolBar5.Dock = System.Windows.Forms.DockStyle.Top;
            this.xpToolBar5.Location = new System.Drawing.Point(0, 0);
            this.xpToolBar5.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xpToolBar5.Name = "xpToolBar5";
            this.xpToolBar5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.xpToolBar5.Size = new System.Drawing.Size(456, 25);
            this.xpToolBar5.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.xpToolBar5.TabIndex = 0;
            this.xpToolBar5.Text = "xpToolBar5";
            // 
            // barItem31
            // 
            this.barItem31.BarName = "barItem31";
            this.barItem31.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem31.ID = "BarITem";
            this.barItem31.ShowToolTipInPopUp = false;
            this.barItem31.SizeToFit = true;
            this.barItem31.Text = "BarItem";
            this.barItem31.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // parentBarItem7
            // 
            this.parentBarItem7.BarName = "parentBarItem7";
            this.parentBarItem7.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.parentBarItem7.ID = "ParentItem";
            this.parentBarItem7.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem32});
            this.parentBarItem7.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem7.ShowToolTipInPopUp = false;
            this.parentBarItem7.SizeToFit = true;
            this.parentBarItem7.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem7.Text = "ParentItem";
            this.parentBarItem7.WrapLength = 20;
            // 
            // barItem32
            // 
            this.barItem32.BarName = "barItem32";
            this.barItem32.ID = "Item1";
            this.barItem32.ShowToolTipInPopUp = false;
            this.barItem32.SizeToFit = true;
            this.barItem32.Text = "Item1";
            this.barItem32.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // dropDownBarItem2
            // 
            this.dropDownBarItem2.BarName = "dropDownBarItem2";
            this.dropDownBarItem2.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dropDownBarItem2.ID = "DropDownItem";
            this.dropDownBarItem2.PopupControlContainer = this.popupControlContainer2;
            this.dropDownBarItem2.ShowToolTipInPopUp = false;
            this.dropDownBarItem2.SizeToFit = true;
            this.dropDownBarItem2.Text = "DropDownItem";
            // 
            // comboBoxBarItem3
            // 
            this.comboBoxBarItem3.BarName = "comboBoxBarItem3";
            this.comboBoxBarItem3.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.comboBoxBarItem3.ID = "ComboBox";
            this.comboBoxBarItem3.ShowToolTipInPopUp = false;
            this.comboBoxBarItem3.SizeToFit = true;
            this.comboBoxBarItem3.Text = "ComboBox";
            // 
            // staticBarItem1
            // 
            this.staticBarItem1.BarName = "staticBarItem1";
            this.staticBarItem1.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.staticBarItem1.ID = "StaticItem";
            this.staticBarItem1.ShowToolTipInPopUp = false;
            this.staticBarItem1.SizeToFit = true;
            this.staticBarItem1.Text = "StaticItem";
            // 
            // barItem28
            // 
            this.barItem28.BarName = "barItem28";
            this.barItem28.ID = "Item1";
            this.barItem28.ShowToolTipInPopUp = false;
            this.barItem28.SizeToFit = true;
            this.barItem28.Text = "Item1";
            this.barItem28.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // barItem29
            // 
            this.barItem29.BarName = "barItem29";
            this.barItem29.ID = "Item2";
            this.barItem29.ShowToolTipInPopUp = false;
            this.barItem29.SizeToFit = true;
            this.barItem29.Text = "Item2";
            this.barItem29.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // barItem30
            // 
            this.barItem30.BarName = "barItem30";
            this.barItem30.ID = "Item3";
            this.barItem30.ShowToolTipInPopUp = false;
            this.barItem30.SizeToFit = true;
            this.barItem30.Text = "Item3";
            this.barItem30.Click += new System.EventHandler(this.barItem_Clicked);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(708, 449);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.xpToolBar2);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toolbars";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.popupControlContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem3)).EndInit();
            this.ResumeLayout(false);

        }

        private void PropertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            this.UpdateToolBarStyleforOffice2016Themes();
        }




        #endregion

        #region Main
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
        #endregion

        #region Events
        private void barItem_Clicked(object sender, System.EventArgs e)
        {
            BarItem item = sender as BarItem;
            MessageBox.Show(item.Text + " Clicked");
        }


        private void barItem7_Click(object sender, System.EventArgs e)
        {
            this.barItem7.Checked = !this.barItem7.Checked;
            if (this.barItem7.Checked)
                this.xpToolBar1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            else
                this.xpToolBar1.Style = Syncfusion.Windows.Forms.VisualStyle.Default;
        }
        private void barItem2_Click(object sender, System.EventArgs e)
        {
            this.propertyGrid1.PropertySort = PropertySort.Categorized;
        }

        private void barItem1_Click(object sender, System.EventArgs e)
        {
            this.propertyGrid1.PropertySort = PropertySort.Alphabetical;
        }
       private void  colorPickerUIAdv1_Picked(object sender, ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            ColorPickerUIAdv cc = sender as ColorPickerUIAdv;
            Syncfusion.Windows.Forms.PopupControlContainer pcc = cc.Parent as Syncfusion.Windows.Forms.PopupControlContainer;
            pcc.HidePopup(Syncfusion.Windows.Forms.PopupCloseType.Done);
           
        }
        #endregion

        # region AboutForm_Logic
        DemoCommon.AboutForm aboutForm = null;
        private void aboutItem_Click(object sender, System.EventArgs e)
        {
            aboutForm = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            aboutForm.ShowDialog();
        }

        private void AboutFormCloseBtnClicked(object sender, EventArgs e)
        {
            aboutForm.Close();
        }
        #endregion

        #region Styles
        private void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxAdv1.SelectedIndex == 0)
            {
                this.xpToolBar1.Style = VisualStyle.Metro;
                this.xpToolBar2.Style = VisualStyle.Metro;
                this.xpToolBar3.Style = VisualStyle.Metro;
                this.xpToolBar4.Style = VisualStyle.Metro;
                this.xpToolBar5.Style = VisualStyle.Metro;
                this.xpToolBar6.Style = VisualStyle.Metro;
            }
            if (this.comboBoxAdv1.SelectedIndex == 1)
            {
                this.xpToolBar1.Style = VisualStyle.Office2016Colorful;
                this.xpToolBar2.Style = VisualStyle.Office2016Colorful;
                this.xpToolBar3.Style = VisualStyle.Office2016Colorful;
                this.xpToolBar4.Style = VisualStyle.Office2016Colorful;
                this.xpToolBar5.Style = VisualStyle.Office2016Colorful;
                this.xpToolBar6.Style = VisualStyle.Office2016Colorful;
            }
            if (this.comboBoxAdv1.SelectedIndex == 2)
            {
                this.xpToolBar1.Style = VisualStyle.Office2016White;
                this.xpToolBar2.Style = VisualStyle.Office2016White;
                this.xpToolBar3.Style = VisualStyle.Office2016White;
                this.xpToolBar4.Style = VisualStyle.Office2016White;
                this.xpToolBar5.Style = VisualStyle.Office2016White;
                this.xpToolBar6.Style = VisualStyle.Office2016White;
            }
            if (this.comboBoxAdv1.SelectedIndex == 3)
            {
                this.xpToolBar1.Style = VisualStyle.Office2016DarkGray;
                this.xpToolBar2.Style = VisualStyle.Office2016DarkGray;
                this.xpToolBar3.Style = VisualStyle.Office2016DarkGray;
                this.xpToolBar4.Style = VisualStyle.Office2016DarkGray;
                this.xpToolBar5.Style = VisualStyle.Office2016DarkGray;
                this.xpToolBar6.Style = VisualStyle.Office2016DarkGray;
            }
            if (this.comboBoxAdv1.SelectedIndex == 4)
            {
                this.xpToolBar1.Style = VisualStyle.Office2016Black;
                this.xpToolBar2.Style = VisualStyle.Office2016Black;
                this.xpToolBar3.Style = VisualStyle.Office2016Black;
                this.xpToolBar4.Style = VisualStyle.Office2016Black;
                this.xpToolBar5.Style = VisualStyle.Office2016Black;
                this.xpToolBar6.Style = VisualStyle.Office2016Black;
            }

            UpdateToolBarStyleforOffice2016Themes();

        }

        private void UpdateToolBarStyleforOffice2016Themes()
        {
            if (this.xpToolBar6.Style == VisualStyle.Office2016Colorful || this.xpToolBar5.Style == VisualStyle.Office2016Colorful)
            {
                //this.propertyGrid1.BackColor = ColorTranslator.FromHtml("#ffffff");
                //this.propertyGrid1.ViewBackColor = ColorTranslator.FromHtml("#ffffff");
                //this.propertyGrid1.ViewForeColor = ColorTranslator.FromHtml("#262626");
                //this.propertyGrid1.ViewBorderColor = ColorTranslator.FromHtml("#c5c5c5");
                //this.propertyGrid1.HelpBackColor = ColorTranslator.FromHtml("#ffffff");
                //this.propertyGrid1.HelpForeColor = ColorTranslator.FromHtml("#262626");
                //this.propertyGrid1.HelpBorderColor = ColorTranslator.FromHtml("#c5c5c5");
                //this.propertyGrid1.LineColor = ColorTranslator.FromHtml("#c5c5c5");
                //this.propertyGrid1.CategoryForeColor = ColorTranslator.FromHtml("#262626");
                //this.propertyGrid1.CategorySplitterColor = ColorTranslator.FromHtml("#c5c5c5");
                //this.propertyGrid1.CommandsBorderColor = ColorTranslator.FromHtml("#c5c5c5");
                //this.propertyGrid1.CommandsActiveLinkColor = ColorTranslator.FromHtml("#ffffff");                

                if(this.xpToolBar5.Style == VisualStyle.Office2016Colorful)
                {
                    this.xpToolBar6.Style = VisualStyle.Office2016Colorful;
                }
                else
                {
                    this.xpToolBar5.Style = VisualStyle.Office2016Colorful;
                }

                this.dockingManager1.VisualStyle = VisualStyle.Office2016Colorful;
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.CaptionBarColor = ColorTranslator.FromHtml("#0173c7");
                this.CaptionForeColor = ColorTranslator.FromHtml("#ffffff");
                this.MetroColor = ColorTranslator.FromHtml("#0173c7");
                this.comboBoxAdv1.Style = VisualStyle.Office2016Colorful;                
                this.groupBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.groupBox2.ForeColor = ColorTranslator.FromHtml("#262626");
                this.groupBox2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.label26.ForeColor = ColorTranslator.FromHtml("#262626");
                this.gradientLabel3.ForeColor = ColorTranslator.FromHtml("#262626");                
                this.checkBoxAdv2.Style = CheckBoxAdvStyle.Office2016Colorful;                 
                this.panel1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel3.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel4.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.BorderColor = ColorTranslator.FromHtml("#c5c5c5");                
                this.ShowIcon = false;
            }
            else if (this.xpToolBar6.Style == VisualStyle.Office2016White || this.xpToolBar5.Style == VisualStyle.Office2016White)
            {
                //this.propertyGrid1.BackColor = ColorTranslator.FromHtml("#ffffff");
                //this.propertyGrid1.ViewBackColor = ColorTranslator.FromHtml("#ffffff");
                //this.propertyGrid1.ViewForeColor = ColorTranslator.FromHtml("#262626");
                //this.propertyGrid1.ViewBorderColor = ColorTranslator.FromHtml("#c5c5c5");
                //this.propertyGrid1.HelpBackColor = ColorTranslator.FromHtml("#ffffff");
                //this.propertyGrid1.HelpForeColor = ColorTranslator.FromHtml("#262626");
                //this.propertyGrid1.HelpBorderColor = ColorTranslator.FromHtml("#c5c5c5");
                //this.propertyGrid1.LineColor = ColorTranslator.FromHtml("#c5c5c5");
                //this.propertyGrid1.CategoryForeColor = ColorTranslator.FromHtml("#262626");
                //this.propertyGrid1.CategorySplitterColor = ColorTranslator.FromHtml("#c5c5c5");
                //this.propertyGrid1.CommandsBorderColor = ColorTranslator.FromHtml("#c5c5c5");
                //this.propertyGrid1.CommandsActiveLinkColor = ColorTranslator.FromHtml("#ffffff");

                if (this.xpToolBar5.Style == VisualStyle.Office2016White)
                {
                    this.xpToolBar6.Style = VisualStyle.Office2016White;
                }
                else
                {
                    this.xpToolBar5.Style = VisualStyle.Office2016White;
                }

                this.dockingManager1.VisualStyle = VisualStyle.Office2016White;
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.CaptionBarColor = ColorTranslator.FromHtml("#ffffff");
                this.CaptionForeColor = ColorTranslator.FromHtml("#262626");
                this.MetroColor = ColorTranslator.FromHtml("#ffffff");
                this.comboBoxAdv1.Style = VisualStyle.Office2016White;                
                this.groupBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.groupBox2.ForeColor = ColorTranslator.FromHtml("#262626");
                this.groupBox2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.label26.ForeColor = ColorTranslator.FromHtml("#262626");
                this.gradientLabel3.ForeColor = ColorTranslator.FromHtml("#262626");                
                this.checkBoxAdv2.Style = CheckBoxAdvStyle.Office2016White;
                this.panel1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel3.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel4.BackColor = ColorTranslator.FromHtml("#ffffff");                
                this.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.ShowIcon = false;
            }
            else if (this.xpToolBar6.Style == VisualStyle.Office2016DarkGray || this.xpToolBar5.Style == VisualStyle.Office2016DarkGray)
            {
                //this.propertyGrid1.BackColor = ColorTranslator.FromHtml("#666666");
                //this.propertyGrid1.ViewBackColor = ColorTranslator.FromHtml("#666666");
                //this.propertyGrid1.ViewForeColor = ColorTranslator.FromHtml("#f0f0f0");
                //this.propertyGrid1.ViewBorderColor = ColorTranslator.FromHtml("#444444");
                //this.propertyGrid1.HelpBackColor = ColorTranslator.FromHtml("#666666");
                //this.propertyGrid1.HelpForeColor = ColorTranslator.FromHtml("#f0f0f0");
                //this.propertyGrid1.HelpBorderColor = ColorTranslator.FromHtml("#444444");
                //this.propertyGrid1.LineColor = ColorTranslator.FromHtml("#444444");
                //this.propertyGrid1.CategoryForeColor = ColorTranslator.FromHtml("#f0f0f0");
                //this.propertyGrid1.CategorySplitterColor = ColorTranslator.FromHtml("#444444");
                //this.propertyGrid1.CommandsBorderColor = ColorTranslator.FromHtml("#444444");
                //this.propertyGrid1.CommandsActiveLinkColor = ColorTranslator.FromHtml("#666666");

                if (this.xpToolBar5.Style == VisualStyle.Office2016DarkGray)
                {
                    this.xpToolBar6.Style = VisualStyle.Office2016DarkGray;
                }
                else
                {
                    this.xpToolBar5.Style = VisualStyle.Office2016DarkGray;
                }

                this.dockingManager1.VisualStyle = VisualStyle.Office2016DarkGray;
                this.BackColor = ColorTranslator.FromHtml("#666666");
                this.CaptionBarColor = ColorTranslator.FromHtml("#505050");
                this.MetroColor = ColorTranslator.FromHtml("#505050");
                this.CaptionForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.comboBoxAdv1.Style = VisualStyle.Office2016DarkGray;                
                this.groupBox1.BackColor = ColorTranslator.FromHtml("#666666");
                this.groupBox2.BackColor = ColorTranslator.FromHtml("#666666");
                this.groupBox2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label26.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.gradientLabel3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");                
                this.checkBoxAdv2.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.panel3.BackColor = ColorTranslator.FromHtml("#666666");
                this.panel4.BackColor = ColorTranslator.FromHtml("#666666");
                this.panel1.BackColor = ColorTranslator.FromHtml("#666666");
                this.panel2.BackColor = ColorTranslator.FromHtml("#666666");               
                this.BorderColor = ColorTranslator.FromHtml("#444444");
                this.gradientLabel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.Transparent);                
                this.ShowIcon = false;
            }
            else if (this.xpToolBar6.Style == VisualStyle.Office2016Black || this.xpToolBar5.Style == VisualStyle.Office2016Black)
            {
                //this.propertyGrid1.BackColor = ColorTranslator.FromHtml("#262626");
                //this.propertyGrid1.ViewBackColor = ColorTranslator.FromHtml("#262626");
                //this.propertyGrid1.ViewForeColor = ColorTranslator.FromHtml("#f0f0f0");
                //this.propertyGrid1.ViewBorderColor = ColorTranslator.FromHtml("#363636");
                //this.propertyGrid1.HelpBackColor = ColorTranslator.FromHtml("#262626");
                //this.propertyGrid1.HelpForeColor = ColorTranslator.FromHtml("#f0f0f0");
                //this.propertyGrid1.HelpBorderColor = ColorTranslator.FromHtml("#363636");
                //this.propertyGrid1.LineColor = ColorTranslator.FromHtml("#363636");
                //this.propertyGrid1.CategoryForeColor = ColorTranslator.FromHtml("#f0f0f0");
                //this.propertyGrid1.CategorySplitterColor = ColorTranslator.FromHtml("#363636");
                //this.propertyGrid1.CommandsBorderColor = ColorTranslator.FromHtml("#363636");
                //this.propertyGrid1.CommandsActiveLinkColor = ColorTranslator.FromHtml("#262626");

                if (this.xpToolBar5.Style == VisualStyle.Office2016Black)
                {
                    this.xpToolBar6.Style = VisualStyle.Office2016Black;
                }
                else
                {
                    this.xpToolBar5.Style = VisualStyle.Office2016Black;
                }

                this.dockingManager1.VisualStyle = VisualStyle.Office2016Black;
                this.BackColor = ColorTranslator.FromHtml("#262626");
                this.CaptionBarColor = ColorTranslator.FromHtml("#363636");
                this.CaptionForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.CaptionBarColor = ColorTranslator.FromHtml("#363636");
                this.MetroColor = ColorTranslator.FromHtml("#363636");
                this.comboBoxAdv1.Style = VisualStyle.Office2016Black;                
                this.groupBox1.BackColor = ColorTranslator.FromHtml("#262626");
                this.groupBox2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.groupBox2.BackColor = ColorTranslator.FromHtml("#262626");
                this.label26.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.gradientLabel3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.gradientLabel3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.checkBoxAdv2.Style = CheckBoxAdvStyle.Office2016Black;
                this.panel3.BackColor = ColorTranslator.FromHtml("#262626");
                this.panel4.BackColor = ColorTranslator.FromHtml("#262626");
                this.panel1.BackColor = ColorTranslator.FromHtml("#262626");
                this.panel2.BackColor = ColorTranslator.FromHtml("#262626");
                this.BorderColor = ColorTranslator.FromHtml("#363636");
                this.gradientLabel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.Transparent);                
                this.ShowIcon = false;
                 
            }
            else
            {
                //this.propertyGrid1.BackColor = Color.White;
                //this.propertyGrid1.ViewBackColor = SystemColors.Window;
                //this.propertyGrid1.ViewForeColor = SystemColors.WindowText;
                //this.propertyGrid1.ViewBorderColor = SystemColors.ControlDark;
                //this.propertyGrid1.HelpBackColor = Color.White;
                //this.propertyGrid1.HelpForeColor = SystemColors.ControlText;
                //this.propertyGrid1.HelpBorderColor = SystemColors.ControlDark;
                //this.propertyGrid1.LineColor = SystemColors.InactiveBorder;
                //this.propertyGrid1.CategoryForeColor = SystemColors.ControlText;
                //this.propertyGrid1.CategorySplitterColor = SystemColors.Control;
                //this.propertyGrid1.CommandsBorderColor = SystemColors.ControlDark;
                this.xpToolBar1.Style = VisualStyle.Metro;
                this.xpToolBar2.Style = VisualStyle.Metro;
                this.xpToolBar3.Style = VisualStyle.Metro;
                this.xpToolBar4.Style = VisualStyle.Metro;
                this.xpToolBar5.Style = VisualStyle.Metro;
                this.xpToolBar6.Style = VisualStyle.Metro;
                this.dockingManager1.VisualStyle = VisualStyle.Metro;
                this.BackColor = System.Drawing.Color.White;
                this.MetroColor = ColorTranslator.FromHtml("#119EDA");
                this.CaptionForeColor = ColorTranslator.FromHtml("#343434");
                this.CaptionBarColor = Color.White;
                this.comboBoxAdv1.Style = VisualStyle.Metro;                
                this.groupBox1.BackColor = Color.White;
                this.groupBox2.ForeColor = SystemColors.ControlText;
                this.groupBox2.BackColor = Color.White;
                this.label26.ForeColor = SystemColors.ControlText;
                this.gradientLabel3.ForeColor = SystemColors.ControlText;                
                this.checkBoxAdv2.Style = CheckBoxAdvStyle.Metro;                
                this.panel1.BackColor = Color.White;
                this.panel2.BackColor = Color.White;
                this.panel3.BackColor = Color.White;
                this.panel4.BackColor = Color.White;
                this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
                this.ShowIcon = true;
            }
        }
        #endregion

       
        #region ShowHighLightRectangle
        private void checkBoxAdv2_CheckStateChanged(object sender, EventArgs e)
        {

            if (this.checkBoxAdv2.Checked)
            {
                this.xpToolBar5.ShowHighlightRectangle = true;
                this.xpToolBar6.ShowHighlightRectangle = true;
            }
            else
            {
                this.xpToolBar5.ShowHighlightRectangle = false;
                this.xpToolBar6.ShowHighlightRectangle = false;
            }
        }
        #endregion

    }
}

