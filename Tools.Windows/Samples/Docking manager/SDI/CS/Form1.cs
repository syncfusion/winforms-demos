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

namespace SDIDemo
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;
	using Microsoft.Win32;
	using System.Drawing.Drawing2D;
    using Syncfusion.Licensing;

	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : Syncfusion.Windows.Forms.MetroForm

    {

# region Members declaration
		private Syncfusion.Windows.Forms.Tools.DockingManager dockingManager1;
		private Syncfusion.Windows.Forms.Tools.DockingClientPanel dockingClientPanel1;
		private System.Windows.Forms.ListBox listBox1;
		private TextBox textBox1;
		private Syncfusion.Windows.Forms.Tools.TreeViewAdv treeView1;
		private System.Windows.Forms.Label label1;
		private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboDockLabel;
		private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBox1;
		private System.Windows.Forms.Label label4;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboDrag;
		private System.Windows.Forms.Label label5;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboBrowsingKey;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.CheckedListBox checkedListBox2;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbPaint;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbClose;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbAuto;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbContextMenu;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.ToolTip toolTip1;
		private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv3;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv4;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBox2;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbTreeView;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbListBox;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButton1;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbLBMF;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbTVTB;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbLBTB;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbLBTV;
		private System.Windows.Forms.ListBox listBox2;
		private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboVisualStyle;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ImageList ilDocking;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbTextBox;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbAutoHide;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbcheckedlist;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox1;
        private ComboBoxBase comboBoxBase1;
        private CheckedListBox checkedListBox3;
        private Label label2;
        private SplitContainer splitContainer1;
        private ComboBoxAdv comboBoxAdv1;
        private Label label12;
		private int selectedIndex=0;
		#endregion

# region Initialization
		public Form1()
		{
			//
			// Required for Windows Form Designer support.
			//
			
            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(GetIconFile(@"..\\..\\\App.ico")));
                this.Icon = ico;
            }
            catch { }
            InitEvents(this.dockingManager1);
            this.toolTip1.SetToolTip(this.listBox2, "Press Ctrl+Delete to clear the event logs");
            this.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            AddDockControlsToList();
            this.splitContainer1.SplitterWidth = 3;
            this.tabControlAdv1.BorderStyle = BorderStyle.None;
            this.textBox2.BorderStyle = BorderStyle.None;
            Customization();
            //
            // TODO: Add any  constructor code after InitializeComponent call.
            //
        }
     
        #region Icon
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


        #endregion

        /// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}


		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccblistBox1 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbtextBox1 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbcheckedListBox1 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbcheckedListBox2 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbtreeView1 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
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
            this.dockingManager1 = new Syncfusion.Windows.Forms.Tools.DockingManager(this.components);
            this.ilDocking = new System.Windows.Forms.ImageList(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.treeView1 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.dockingClientPanel1 = new Syncfusion.Windows.Forms.Tools.DockingClientPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.textBox2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.cbAutoHide = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label7 = new System.Windows.Forms.Label();
            this.cbPaint = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.cbClose = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.cbContextMenu = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.cbAuto = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.rbLBMF = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.rbTVTB = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.rbLBTB = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.rbLBTV = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.tabPageAdv3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbcheckedlist = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.cbTextBox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label9 = new System.Windows.Forms.Label();
            this.cbTreeView = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.cbListBox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxBase1 = new Syncfusion.Windows.Forms.Tools.ComboBoxBase();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboVisualStyle = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboBrowsingKey = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label5 = new System.Windows.Forms.Label();
            this.cboDrag = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cboDockLabel = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageAdv4 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeView1)).BeginInit();
            this.dockingClientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).BeginInit();
            this.tabPageAdv2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAutoHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPaint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbContextMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAuto)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbLBMF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbTVTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbLBTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbLBTV)).BeginInit();
            this.tabPageAdv3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbcheckedlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTreeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbListBox)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBase1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboVisualStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBrowsingKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDrag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDockLabel)).BeginInit();
            this.tabPageAdv4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockingManager1
            // 
            this.dockingManager1.ActiveCaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockingManager1.AnimateAutoHiddenWindow = true;
            this.dockingManager1.AutoHideTabFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dockingManager1.AutoHideTabForeColor = System.Drawing.Color.Empty;
            this.dockingManager1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dockingManager1.BrowsingKey = System.Windows.Forms.Keys.Delete;
            this.dockingManager1.DockLayoutStream = ((System.IO.MemoryStream)(resources.GetObject("dockingManager1.DockLayoutStream")));
            this.dockingManager1.DockTabFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dockingManager1.ForwardMenuShortcuts = false;
            this.dockingManager1.HostControl = this;
            this.dockingManager1.ImageList = this.ilDocking;
            this.dockingManager1.InActiveCaptionBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212))))));
            this.dockingManager1.InActiveCaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockingManager1.MetroButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dockingManager1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.dockingManager1.MetroSplitterBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(159)))), ((int)(((byte)(183)))));
            this.dockingManager1.ReduceFlickeringInRtl = false;
            this.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.dockingManager1.DockAllow += new Syncfusion.Windows.Forms.Tools.DockAllowEventHandler(this.dockingManager1_DockAllow);
            this.dockingManager1.DockVisibilityChanged += new Syncfusion.Windows.Forms.Tools.DockVisibilityChangedEventHandler(this.dockingManager1_DockVisibilityChanged);
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"));
            this.dockingManager1.SetDockLabel(this.listBox1, "Docking features");
            this.dockingManager1.SetDockIcon(this.listBox1, 1);
            this.dockingManager1.SetEnableDocking(this.listBox1, true);
            ccblistBox1.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.listBox1, ccblistBox1);
            this.dockingManager1.SetDockLabel(this.textBox1, "Description");
            this.dockingManager1.SetDockIcon(this.textBox1, 2);
            this.dockingManager1.SetEnableDocking(this.textBox1, true);
            ccbtextBox1.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.textBox1, ccbtextBox1);
            this.dockingManager1.SetDockLabel(this.checkedListBox1, "DockController Classes");
            this.dockingManager1.SetDockIcon(this.checkedListBox1, 3);
            this.dockingManager1.SetEnableDocking(this.checkedListBox1, true);
            ccbcheckedListBox1.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.checkedListBox1, ccbcheckedListBox1);
            this.dockingManager1.SetDockLabel(this.checkedListBox2, "Docking classes");
            this.dockingManager1.SetDockIcon(this.checkedListBox2, 5);
            this.dockingManager1.SetEnableDocking(this.checkedListBox2, true);
            ccbcheckedListBox2.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.checkedListBox2, ccbcheckedListBox2);
            this.dockingManager1.SetDockLabel(this.treeView1, "Docking Manager ");
            this.dockingManager1.SetDockIcon(this.treeView1, 4);
            this.dockingManager1.SetEnableDocking(this.treeView1, true);
            ccbtreeView1.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.treeView1, ccbtreeView1);
            this.dockingManager1.SetControlSize(this.checkedListBox1, new Size(300, 200));
            // 
            // ilDocking
            // 
            this.ilDocking.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilDocking.ImageStream")));
            this.ilDocking.TransparentColor = System.Drawing.Color.Transparent;
            this.ilDocking.Images.SetKeyName(0, "");
            this.ilDocking.Images.SetKeyName(1, "");
            this.ilDocking.Images.SetKeyName(2, "");
            this.ilDocking.Images.SetKeyName(3, "");
            this.ilDocking.Images.SetKeyName(4, "");
            this.ilDocking.Images.SetKeyName(5, "");
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "VS.Net Type Docking windows",
            "Tabbed Docking",
            "Nested docking",
            "Floating windows",
            "Floating  with tabbed controls.",
            "Nested Docking in a Floating window.",
            "AutoHideMode",
            "Docking Diamonds",
            "State persistence",
            "Customization",
            "And much more..."});
            this.listBox1.Location = new System.Drawing.Point(1, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(127, 388);
            this.listBox1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(1, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(361, 87);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Docking manager";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkedListBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.ForeColor = System.Drawing.Color.Black;
            this.checkedListBox1.IntegralHeight = false;
            this.checkedListBox1.Items.AddRange(new object[] {
            "DockHostController",
            "DockTabController",
            "FloatingFormController",
            "MainFormController",
            "DockControllerBase"});
            this.checkedListBox1.Location = new System.Drawing.Point(1, 24);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(700, 62);
            this.checkedListBox1.TabIndex = 13;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkedListBox2.Font = new System.Drawing.Font("Arial", 9F);
            this.checkedListBox2.ForeColor = System.Drawing.Color.Black;
            this.checkedListBox2.IntegralHeight = false;
            this.checkedListBox2.Items.AddRange(new object[] {
            "DockingManager",
            "DockHost",
            "DockTabControl",
            "DockTabPage",
            "FloatingForm",
            "AHTabControl",
            "AHTabPage",
            "FloatingForm",
            "DockingWrapperForm"});
            this.checkedListBox2.Location = new System.Drawing.Point(1, 24);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(700, 87);
            this.checkedListBox2.TabIndex = 15;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.White;
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdvStyleInfo1.TextColor = System.Drawing.Color.Black;
            treeNodeAdvStyleInfo1.ThemesEnabled = false;
            this.treeView1.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this.treeView1.BeforeTouchSize = new System.Drawing.Size(115, 367);
            this.treeView1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.treeView1.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.treeView1.HelpTextControl.Name = "helpText";
            this.treeView1.HelpTextControl.TabIndex = 0;
            this.treeView1.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.treeView1.Location = new System.Drawing.Point(1, 24);
            this.treeView1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.treeView1.Name = "treeView1";
            treeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.MultiLine = true;
            treeNodeAdv2.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.MultiLine = true;
            treeNodeAdv3.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.MultiLine = true;
            treeNodeAdv3.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv3.ShowLine = true;
            treeNodeAdv3.Text = "Enable docking";
            treeNodeAdv4.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.MultiLine = true;
            treeNodeAdv4.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv4.ShowLine = true;
            treeNodeAdv4.Text = "Setting dock edge";
            treeNodeAdv5.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.MultiLine = true;
            treeNodeAdv5.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv5.ShowLine = true;
            treeNodeAdv5.Text = "Making tabbed windows ";
            treeNodeAdv6.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.MultiLine = true;
            treeNodeAdv6.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv6.ShowLine = true;
            treeNodeAdv6.Text = "Setting as floaing";
            treeNodeAdv2.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv3,
            treeNodeAdv4,
            treeNodeAdv5,
            treeNodeAdv6});
            treeNodeAdv2.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv2.ShowLine = true;
            treeNodeAdv2.Text = "DesignTimeSupport";
            treeNodeAdv7.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.MultiLine = true;
            treeNodeAdv8.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.MultiLine = true;
            treeNodeAdv8.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv8.ShowLine = true;
            treeNodeAdv8.Text = "DockAllow event";
            treeNodeAdv9.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.MultiLine = true;
            treeNodeAdv9.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv9.ShowLine = true;
            treeNodeAdv9.Text = "Dragallow event";
            treeNodeAdv10.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv10.EnsureDefaultOptionedChild = true;
            treeNodeAdv10.MultiLine = true;
            treeNodeAdv10.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv10.ShowLine = true;
            treeNodeAdv10.Text = "DockVisibilityChanging event";
            treeNodeAdv7.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv8,
            treeNodeAdv9,
            treeNodeAdv10});
            treeNodeAdv7.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv7.ShowLine = true;
            treeNodeAdv7.Text = "Events architecture";
            treeNodeAdv11.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv11.EnsureDefaultOptionedChild = true;
            treeNodeAdv11.MultiLine = true;
            treeNodeAdv12.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv12.EnsureDefaultOptionedChild = true;
            treeNodeAdv12.MultiLine = true;
            treeNodeAdv12.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv12.ShowLine = true;
            treeNodeAdv12.Text = "DockToFill mode";
            treeNodeAdv13.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv13.EnsureDefaultOptionedChild = true;
            treeNodeAdv13.MultiLine = true;
            treeNodeAdv13.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv13.ShowLine = true;
            treeNodeAdv13.Text = "Dissallow Floating";
            treeNodeAdv14.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv14.EnsureDefaultOptionedChild = true;
            treeNodeAdv14.MultiLine = true;
            treeNodeAdv14.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv14.ShowLine = true;
            treeNodeAdv14.Text = "Docking diamond";
            treeNodeAdv15.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv15.EnsureDefaultOptionedChild = true;
            treeNodeAdv15.MultiLine = true;
            treeNodeAdv15.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv15.ShowLine = true;
            treeNodeAdv15.Text = "DockTab settings";
            treeNodeAdv11.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv12,
            treeNodeAdv13,
            treeNodeAdv14,
            treeNodeAdv15});
            treeNodeAdv11.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv11.ShowLine = true;
            treeNodeAdv11.Text = "Customization options";
            treeNodeAdv16.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv16.EnsureDefaultOptionedChild = true;
            treeNodeAdv16.MultiLine = true;
            treeNodeAdv16.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv16.ShowLine = true;
            treeNodeAdv16.Text = "Extensible ";
            treeNodeAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv2,
            treeNodeAdv7,
            treeNodeAdv11,
            treeNodeAdv16});
            treeNodeAdv1.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv1.ShowLine = true;
            treeNodeAdv1.Text = "DockingManager";
            this.treeView1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv1});
            this.treeView1.SelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))));
            this.treeView1.SelectedNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this.treeView1.ShowFocusRect = false;
            this.treeView1.Size = new System.Drawing.Size(115, 367);
            this.treeView1.Style = Syncfusion.Windows.Forms.Tools.TreeStyle.Metro;
            this.treeView1.TabIndex = 11;
            this.treeView1.ThemesEnabled = false;
            // 
            // 
            // 
            this.treeView1.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.treeView1.ToolTipControl.Name = "toolTip";
            this.treeView1.ToolTipControl.TabIndex = 1;
            this.treeView1.AfterSelect += new System.EventHandler(this.treeView1_AfterSelect);
            // 
            // dockingClientPanel1
            // 
            this.dockingClientPanel1.Controls.Add(this.splitContainer1);
            this.dockingClientPanel1.Location = new System.Drawing.Point(20, 20);
            this.dockingClientPanel1.Name = "dockingClientPanel1";
            this.dockingClientPanel1.Size = new System.Drawing.Size(702, 529);
            this.dockingClientPanel1.SizeToFit = true;
            this.dockingClientPanel1.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControlAdv1);
            this.splitContainer1.Size = new System.Drawing.Size(702, 529);
            this.splitContainer1.SplitterDistance = 47;
            this.splitContainer1.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(700, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Syncfusion Docking Windows";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(700, 476);
            this.tabControlAdv1.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv3);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv4);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv1.FixedSingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tabControlAdv1.FocusOnTabClick = false;
            this.tabControlAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlAdv1.InactiveTabColor = System.Drawing.Color.SeaShell;
            this.tabControlAdv1.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.ItemSize = new System.Drawing.Size(25, 22);
            this.tabControlAdv1.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Padding = new System.Drawing.Point(6, 1);
            this.tabControlAdv1.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.tabControlAdv1.ShowSeparator = false;
            this.tabControlAdv1.Size = new System.Drawing.Size(700, 476);
            this.tabControlAdv1.TabIndex = 2;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPageAdv1.Controls.Add(this.textBox2);
            this.tabPageAdv1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(1, 22);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(697, 452);
            this.tabPageAdv1.TabFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "Introduction";
            this.tabPageAdv1.ThemesEnabled = false;
            this.toolTip1.SetToolTip(this.tabPageAdv1, "Gives a brief introduction about the usage of DockingClientPanel");
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BeforeTouchSize = new System.Drawing.Size(697, 452);
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(69)))), ((int)(((byte)(113)))));
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Metrocolor = System.Drawing.Color.Empty;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(697, 452);
            this.textBox2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(139)))), ((int)(((byte)(177)))));
            this.tabPageAdv2.Controls.Add(this.gradientPanel1);
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv2.Location = new System.Drawing.Point(1, 22);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(697, 452);
            this.tabPageAdv2.TabIndex = 1;
            this.tabPageAdv2.Text = "Behavior";
            this.tabPageAdv2.ThemesEnabled = false;
            this.toolTip1.SetToolTip(this.tabPageAdv2, "Contain options to change the behaviour of docking");
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(139)))), ((int)(((byte)(177)))));
            this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            this.gradientPanel1.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None;
            this.gradientPanel1.Controls.Add(this.panel2);
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(697, 452);
            this.gradientPanel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.cbAutoHide);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbPaint);
            this.panel2.Controls.Add(this.cbClose);
            this.panel2.Controls.Add(this.cbContextMenu);
            this.panel2.Controls.Add(this.cbAuto);
            this.panel2.Location = new System.Drawing.Point(505, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 413);
            this.panel2.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox1.DrawFocusRectangle = false;
            this.checkBox1.Location = new System.Drawing.Point(24, 234);
            this.checkBox1.MetroColor = System.Drawing.Color.DimGray;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 21);
            this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Freeze resizing";
            this.checkBox1.ThemesEnabled = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbAutoHide
            // 
            this.cbAutoHide.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.cbAutoHide.DrawFocusRectangle = false;
            this.cbAutoHide.Location = new System.Drawing.Point(24, 43);
            this.cbAutoHide.MetroColor = System.Drawing.Color.DimGray;
            this.cbAutoHide.Name = "cbAutoHide";
            this.cbAutoHide.Size = new System.Drawing.Size(144, 21);
            this.cbAutoHide.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbAutoHide.TabIndex = 12;
            this.cbAutoHide.Text = "Disable AutoHide";
            this.cbAutoHide.ThemesEnabled = false;
            this.cbAutoHide.CheckedChanged += new System.EventHandler(this.cbAutoHide_CheckedChanged_1);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "State Attributes";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbPaint
            // 
            this.cbPaint.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.cbPaint.Checked = true;
            this.cbPaint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPaint.DrawFocusRectangle = false;
            this.cbPaint.Location = new System.Drawing.Point(24, 115);
            this.cbPaint.MetroColor = System.Drawing.Color.DimGray;
            this.cbPaint.Name = "cbPaint";
            this.cbPaint.Size = new System.Drawing.Size(120, 22);
            this.cbPaint.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbPaint.TabIndex = 8;
            this.cbPaint.Text = "Paint Border";
            this.cbPaint.ThemesEnabled = false;
            this.cbPaint.CheckedChanged += new System.EventHandler(this.cbPaint_CheckedChanged);
            // 
            // cbClose
            // 
            this.cbClose.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.cbClose.Checked = true;
            this.cbClose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbClose.DrawFocusRectangle = false;
            this.cbClose.Location = new System.Drawing.Point(24, 156);
            this.cbClose.MetroColor = System.Drawing.Color.DimGray;
            this.cbClose.Name = "cbClose";
            this.cbClose.Size = new System.Drawing.Size(120, 22);
            this.cbClose.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbClose.TabIndex = 9;
            this.cbClose.Text = "Close Enabled";
            this.cbClose.ThemesEnabled = false;
            this.cbClose.CheckedChanged += new System.EventHandler(this.cbClose_CheckedChanged);
            // 
            // cbContextMenu
            // 
            this.cbContextMenu.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.cbContextMenu.Checked = true;
            this.cbContextMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbContextMenu.DrawFocusRectangle = false;
            this.cbContextMenu.Location = new System.Drawing.Point(24, 195);
            this.cbContextMenu.MetroColor = System.Drawing.Color.DimGray;
            this.cbContextMenu.Name = "cbContextMenu";
            this.cbContextMenu.Size = new System.Drawing.Size(120, 21);
            this.cbContextMenu.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbContextMenu.TabIndex = 11;
            this.cbContextMenu.Text = "Context Menu";
            this.cbContextMenu.ThemesEnabled = false;
            this.cbContextMenu.CheckedChanged += new System.EventHandler(this.cbContextMenu_CheckedChanged);
            // 
            // cbAuto
            // 
            this.cbAuto.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.cbAuto.DrawFocusRectangle = false;
            this.cbAuto.Location = new System.Drawing.Point(24, 77);
            this.cbAuto.MetroColor = System.Drawing.Color.DimGray;
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Size = new System.Drawing.Size(136, 21);
            this.cbAuto.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbAuto.TabIndex = 10;
            this.cbAuto.Text = "Themes Enabled";
            this.cbAuto.ThemesEnabled = false;
            this.cbAuto.CheckedChanged += new System.EventHandler(this.cbAuto_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.rbLBMF);
            this.panel1.Controls.Add(this.rbTVTB);
            this.panel1.Controls.Add(this.rbLBTB);
            this.panel1.Controls.Add(this.rbLBTV);
            this.panel1.Location = new System.Drawing.Point(5, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 413);
            this.panel1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-20, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Docking Customization";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton1
            // 
            this.radioButton1.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.radioButton1.Checked = true;
            this.radioButton1.DrawFocusRectangle = false;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton1.Location = new System.Drawing.Point(4, 219);
            this.radioButton1.MetroColor = System.Drawing.Color.DimGray;
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(168, 21);
            this.radioButton1.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton1.TabIndex = 4;
            this.radioButton1.Text = "Allow All";
            this.radioButton1.ThemesEnabled = false;
            // 
            // rbLBMF
            // 
            this.rbLBMF.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.rbLBMF.DrawFocusRectangle = false;
            this.rbLBMF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbLBMF.Location = new System.Drawing.Point(4, 179);
            this.rbLBMF.MetroColor = System.Drawing.Color.DimGray;
            this.rbLBMF.Name = "rbLBMF";
            this.rbLBMF.Size = new System.Drawing.Size(190, 21);
            this.rbLBMF.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.rbLBMF.TabIndex = 3;
            this.rbLBMF.Text = "Disallow ListBox-MainForm";
            this.rbLBMF.ThemesEnabled = false;
            // 
            // rbTVTB
            // 
            this.rbTVTB.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.rbTVTB.DrawFocusRectangle = false;
            this.rbTVTB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbTVTB.Location = new System.Drawing.Point(4, 136);
            this.rbTVTB.MetroColor = System.Drawing.Color.DimGray;
            this.rbTVTB.Name = "rbTVTB";
            this.rbTVTB.Size = new System.Drawing.Size(190, 21);
            this.rbTVTB.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.rbTVTB.TabIndex = 2;
            this.rbTVTB.Text = "Disallow TreeView-TextBox";
            this.rbTVTB.ThemesEnabled = false;
            // 
            // rbLBTB
            // 
            this.rbLBTB.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.rbLBTB.DrawFocusRectangle = false;
            this.rbLBTB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbLBTB.Location = new System.Drawing.Point(4, 86);
            this.rbLBTB.MetroColor = System.Drawing.Color.DimGray;
            this.rbLBTB.Name = "rbLBTB";
            this.rbLBTB.Size = new System.Drawing.Size(168, 33);
            this.rbLBTB.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.rbLBTB.TabIndex = 1;
            this.rbLBTB.Text = "Disallow ListBox-TextBox";
            this.rbLBTB.ThemesEnabled = false;
            // 
            // rbLBTV
            // 
            this.rbLBTV.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.rbLBTV.DrawFocusRectangle = false;
            this.rbLBTV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbLBTV.Location = new System.Drawing.Point(5, 38);
            this.rbLBTV.MetroColor = System.Drawing.Color.DimGray;
            this.rbLBTV.Name = "rbLBTV";
            this.rbLBTV.Size = new System.Drawing.Size(168, 34);
            this.rbLBTV.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.rbLBTV.TabIndex = 0;
            this.rbLBTV.Text = "Disallow ListBox-TreeView";
            this.rbLBTV.ThemesEnabled = false;
            // 
            // tabPageAdv3
            // 
            this.tabPageAdv3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPageAdv3.Controls.Add(this.panel4);
            this.tabPageAdv3.Controls.Add(this.panel3);
            this.tabPageAdv3.Image = null;
            this.tabPageAdv3.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv3.Location = new System.Drawing.Point(1, 22);
            this.tabPageAdv3.Name = "tabPageAdv3";
            this.tabPageAdv3.ShowCloseButton = true;
            this.tabPageAdv3.Size = new System.Drawing.Size(697, 452);
            this.tabPageAdv3.TabIndex = 2;
            this.tabPageAdv3.Text = "Miscellaneous";
            this.tabPageAdv3.ThemesEnabled = false;
            this.toolTip1.SetToolTip(this.tabPageAdv3, "Contain customization options");
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cbcheckedlist);
            this.panel4.Controls.Add(this.cbTextBox);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.cbTreeView);
            this.panel4.Controls.Add(this.cbListBox);
            this.panel4.Location = new System.Drawing.Point(8, 266);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(680, 73);
            this.panel4.TabIndex = 17;
            // 
            // cbcheckedlist
            // 
            this.cbcheckedlist.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.cbcheckedlist.DrawFocusRectangle = false;
            this.cbcheckedlist.Location = new System.Drawing.Point(39, 47);
            this.cbcheckedlist.MetroColor = System.Drawing.Color.DimGray;
            this.cbcheckedlist.Name = "cbcheckedlist";
            this.cbcheckedlist.Size = new System.Drawing.Size(168, 22);
            this.cbcheckedlist.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbcheckedlist.TabIndex = 11;
            this.cbcheckedlist.Text = "Hide CheckedListBoxes";
            this.cbcheckedlist.ThemesEnabled = false;
            this.cbcheckedlist.CheckStateChanged += new System.EventHandler(this.cbcheckedlist_CheckStateChanged);
            // 
            // cbTextBox
            // 
            this.cbTextBox.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.cbTextBox.DrawFocusRectangle = false;
            this.cbTextBox.Location = new System.Drawing.Point(223, 20);
            this.cbTextBox.MetroColor = System.Drawing.Color.DimGray;
            this.cbTextBox.Name = "cbTextBox";
            this.cbTextBox.Size = new System.Drawing.Size(144, 21);
            this.cbTextBox.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbTextBox.TabIndex = 10;
            this.cbTextBox.Text = "Hide TextBox";
            this.cbTextBox.ThemesEnabled = false;
            this.cbTextBox.CheckedChanged += new System.EventHandler(this.cbTextBox_CheckedChanged_1);
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(678, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Visibility";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbTreeView
            // 
            this.cbTreeView.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.cbTreeView.DrawFocusRectangle = false;
            this.cbTreeView.Location = new System.Drawing.Point(223, 47);
            this.cbTreeView.MetroColor = System.Drawing.Color.DimGray;
            this.cbTreeView.Name = "cbTreeView";
            this.cbTreeView.Size = new System.Drawing.Size(144, 22);
            this.cbTreeView.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbTreeView.TabIndex = 1;
            this.cbTreeView.Text = "Hide TreeView";
            this.cbTreeView.ThemesEnabled = false;
            this.cbTreeView.CheckedChanged += new System.EventHandler(this.cbTreeView_CheckedChanged);
            // 
            // cbListBox
            // 
            this.cbListBox.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.cbListBox.DrawFocusRectangle = false;
            this.cbListBox.Location = new System.Drawing.Point(39, 20);
            this.cbListBox.MetroColor = System.Drawing.Color.DimGray;
            this.cbListBox.Name = "cbListBox";
            this.cbListBox.Size = new System.Drawing.Size(144, 22);
            this.cbListBox.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbListBox.TabIndex = 0;
            this.cbListBox.Text = "Hide ListBox";
            this.cbListBox.ThemesEnabled = false;
            this.cbListBox.CheckedChanged += new System.EventHandler(this.cbListBox_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.comboBoxAdv1);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.comboBoxBase1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cboVisualStyle);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.cboBrowsingKey);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cboDrag);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.cboDockLabel);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.checkedListBox3);
            this.panel3.Location = new System.Drawing.Point(8, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(680, 251);
            this.panel3.TabIndex = 16;
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(160, 21);
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "VS2008",
            "VS2010"});
            this.comboBoxAdv1.Location = new System.Drawing.Point(193, 211);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(160, 21);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.TabIndex = 16;
            this.comboBoxAdv1.Text = "VS2008";
            this.comboBoxAdv1.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv1_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(37, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 21);
            this.label12.TabIndex = 15;
            this.label12.Text = "Dock Behavior";
            // 
            // comboBoxBase1
            // 
            this.comboBoxBase1.BackColor = System.Drawing.Color.White;
            this.comboBoxBase1.BeforeTouchSize = new System.Drawing.Size(160, 21);
            this.comboBoxBase1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBase1.ListControl = this.checkedListBox3;
            this.comboBoxBase1.Location = new System.Drawing.Point(193, 174);
            this.comboBoxBase1.Name = "comboBoxBase1";
            this.comboBoxBase1.Size = new System.Drawing.Size(160, 21);
            this.comboBoxBase1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxBase1.TabIndex = 14;
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.BackColor = System.Drawing.Color.White;
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Location = new System.Drawing.Point(277, -68);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(160, 72);
            this.checkedListBox3.TabIndex = 12;
            this.checkedListBox3.SelectedIndexChanged += new System.EventHandler(this.checkedListBox3_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Set Freeze/UnFreeze \r\nto DockedControls";
            // 
            // cboVisualStyle
            // 
            this.cboVisualStyle.BackColor = System.Drawing.Color.White;
            this.cboVisualStyle.BeforeTouchSize = new System.Drawing.Size(160, 21);
            this.cboVisualStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVisualStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVisualStyle.Items.AddRange(new object[] {
            "Metro",
            "Office2016White",
            "Office2016Colorful",
            "Office2016Black",
            "Office2016DarkGray"});
            this.cboVisualStyle.Location = new System.Drawing.Point(193, 139);
            this.cboVisualStyle.Name = "cboVisualStyle";
            this.cboVisualStyle.Size = new System.Drawing.Size(160, 21);
            this.cboVisualStyle.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cboVisualStyle.TabIndex = 10;
            this.cboVisualStyle.Text = "Metro";
            this.cboVisualStyle.SelectedIndexChanged += new System.EventHandler(this.cboVisualStyle_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(37, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 21);
            this.label10.TabIndex = 9;
            this.label10.Text = "Visual Style";
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(678, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "General Properties";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboBrowsingKey
            // 
            this.cboBrowsingKey.BackColor = System.Drawing.Color.White;
            this.cboBrowsingKey.BeforeTouchSize = new System.Drawing.Size(160, 21);
            this.cboBrowsingKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBrowsingKey.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBrowsingKey.Items.AddRange(new object[] {
            "Back",
            "Del",
            "End",
            "Enter",
            "F1",
            "F10",
            "F11",
            "F12",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "Home",
            "Insert",
            "PgDn",
            "PgUp"});
            this.cboBrowsingKey.Location = new System.Drawing.Point(193, 110);
            this.cboBrowsingKey.Name = "cboBrowsingKey";
            this.cboBrowsingKey.Size = new System.Drawing.Size(160, 21);
            this.cboBrowsingKey.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cboBrowsingKey.TabIndex = 7;
            this.cboBrowsingKey.Text = "Back";
            this.cboBrowsingKey.SelectedIndexChanged += new System.EventHandler(this.cboBrowsingKey_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(37, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "BrowsingKey";
            // 
            // cboDrag
            // 
            this.cboDrag.BackColor = System.Drawing.Color.White;
            this.cboDrag.BeforeTouchSize = new System.Drawing.Size(160, 21);
            this.cboDrag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDrag.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDrag.Items.AddRange(new object[] {
            "Standard",
            "VS2005",
            "Whidbey",
            "VS2008",
            "VS2010",
            "VS2012",
            "Office2016Colorful",
            "Office2016Black",
            "Office2016White"});
            this.cboDrag.Location = new System.Drawing.Point(193, 81);
            this.cboDrag.Name = "cboDrag";
            this.cboDrag.Size = new System.Drawing.Size(160, 21);
            this.cboDrag.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cboDrag.TabIndex = 5;
            this.cboDrag.Text = "Standard";
            this.cboDrag.SelectedIndexChanged += new System.EventHandler(this.cboDrag_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(37, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Drag Provider Style";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.BeforeTouchSize = new System.Drawing.Size(160, 21);
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.Items.AddRange(new object[] {
            "Top",
            "Bottom",
            "Left",
            "Right"});
            this.comboBox1.Location = new System.Drawing.Point(193, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 21);
            this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Top";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cboDockLabel
            // 
            this.cboDockLabel.BackColor = System.Drawing.Color.White;
            this.cboDockLabel.BeforeTouchSize = new System.Drawing.Size(160, 21);
            this.cboDockLabel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDockLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDockLabel.Items.AddRange(new object[] {
            "Center",
            "Default",
            "Left",
            "Right"});
            this.cboDockLabel.Location = new System.Drawing.Point(193, 24);
            this.cboDockLabel.Name = "cboDockLabel";
            this.cboDockLabel.Size = new System.Drawing.Size(160, 21);
            this.cboDockLabel.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cboDockLabel.TabIndex = 1;
            this.cboDockLabel.Text = "Center";
            this.cboDockLabel.SelectedIndexChanged += new System.EventHandler(this.cboDockLabel_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(37, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "DockTab Alignment";
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "DockLabel Alignment";
            // 
            // tabPageAdv4
            // 
            this.tabPageAdv4.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPageAdv4.Controls.Add(this.listBox2);
            this.tabPageAdv4.Image = null;
            this.tabPageAdv4.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv4.Location = new System.Drawing.Point(1, 22);
            this.tabPageAdv4.Name = "tabPageAdv4";
            this.tabPageAdv4.ShowCloseButton = true;
            this.tabPageAdv4.Size = new System.Drawing.Size(697, 452);
            this.tabPageAdv4.TabIndex = 3;
            this.tabPageAdv4.Text = "Events Log";
            this.tabPageAdv4.ThemesEnabled = false;
            this.toolTip1.SetToolTip(this.tabPageAdv4, "Displays the information about the events fired");
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.BackColor = System.Drawing.Color.White;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.IntegralHeight = false;
            this.listBox2.Location = new System.Drawing.Point(9, 7);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(680, 439);
            this.listBox2.TabIndex = 1;
            this.listBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox2_KeyDown);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            this.toolTip1.ShowAlways = true;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.ClientSize = new System.Drawing.Size(742, 569);
            this.Controls.Add(this.dockingClientPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(714, 545);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SDI Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeView1)).EndInit();
            this.dockingClientPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.tabPageAdv1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).EndInit();
            this.tabPageAdv2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAutoHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPaint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbContextMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAuto)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbLBMF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbTVTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbLBTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbLBTV)).EndInit();
            this.tabPageAdv3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbcheckedlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTreeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbListBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBase1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboVisualStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBrowsingKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDrag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDockLabel)).EndInit();
            this.tabPageAdv4.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        void treeView1_AfterSelect(object sender, EventArgs e)
        {
            switch (this.treeView1.SelectedNode.Text)
            {
                case "DockingManager": textBox1.Text = "At the most basic level a docking window may be defined as a control that attaches itself to a host form's border. Windows Forms provides basic support for docking capapbilities through the Dock property of the control class."; break;
                case "DesignTimeSupport": textBox1.Text = "Docking architecture offers a true design time support"; break;
                case "Events architecture": textBox1.Text = "Dockingmanager has numerous events which help to interact the docking operations"; break;
                case "Customization options": textBox1.Text = "Docking manager has so much properties to make the docking customization"; break;
                case "Extensible ": textBox1.Text = "Docking architecture is extensible too by using inheritance.For example if you want to change the autohide tab font and color you can inherit the DockingManager class"; break;
                case "Enable docking": textBox1.Text = "The docking for an control can be easily enabled by just setting a property 'EnableDocking On DockingManager'"; break;
                case "Setting dock edge": textBox1.Text = "Drag a docked window to the edge of the form that will then stick to that edge"; break;
                case "Making tabbed windows ": textBox1.Text = "Drag a docked window to the title bar of another docked window, they will then became tabbed"; break;
                case "Setting as floaing": textBox1.Text = "Just drag out the window ,it then will be free from form ie floating"; break;
                case "DockAllow event": textBox1.Text = "A powerful event which will fire each time before a docking operation.It also allows to cancel the operation"; break;
                case "Dragallow event": textBox1.Text = "The event which will fire before any drag opeation takes place"; break;
                case "DockVisibilityChanging event": textBox1.Text = "Fires before we close any of the docked window.It offers the facility to cancel the closing."; break;
                case "DockToFill mode": textBox1.Text = "Specifies whether the docked windows should resize to the empty space in the host form"; break;
                case "Dissallow Floating": textBox1.Text = "If it is set to true,DockingManager wont allow any window to be floated"; break;
                case "Docking diamond": textBox1.Text = "Allows to set the style of dock prediction bands"; break;
                case "DockTab settings": textBox1.Text = "There are 3 properties DockTabAllignment,DockTabHeight,DockTabFont which help to customize the docktab"; break;
            }
        }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main() 
		{
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.Run(new Form1());
		}
# endregion

# region Event handlers-DockingManager
		private void dockingManager1_DockAllow(object sender, Syncfusion.Windows.Forms.Tools.DockAllowEventArgs arg)
		{
			if(this.rbLBTB.Checked == true)
			{
				// Disallow docking the list box to the text box. 
				// If the list box or the text box are either of the dock event's 
				// DragControl or the TargetControl, then cancel the dock operation.
				if( ((arg.DragControl == this.listBox1) || (arg.TargetControl == this.listBox1))
					&& ((arg.DragControl == this.textBox1) || (arg.TargetControl == this.textBox1)) )
					arg.Cancel = true;
				
			}

			if(this.rbLBTV.Checked == true)
			{
				if( ((arg.DragControl == this.listBox1) || (arg.TargetControl == this.listBox1))
					&& ((arg.DragControl == this.treeView1) || (arg.TargetControl == this.treeView1)) )
					arg.Cancel = true;
			}

			if(this.rbTVTB.Checked == true)
			{
				if( ((arg.DragControl == this.treeView1) || (arg.TargetControl == this.treeView1))
					&& ((arg.DragControl == this.textBox1) || (arg.TargetControl == this.textBox1)) )
					arg.Cancel = true;
			}

			if(this.rbLBMF.Checked == true)
			{
				// Disallow docking the list box to the application's main form. 
				// In this case, the list box will be the DragControl and the main form 
				// will be TargetControl. If this is True, then cancel the operation.
				if( (arg.DragControl == this.listBox1) && (arg.TargetControl == this) )
					arg.Cancel = true;
			}
		}
		private void dockingManager1_DockVisibilityChanged(object sender, Syncfusion.Windows.Forms.Tools.DockVisibilityChangedEventArgs arg)
		{
			// Based on the control dockvisibility state and sets the state for the check boxes.
			if(arg.Control == this.listBox1)
				this.cbListBox.Checked = !this.dockingManager1.GetDockVisibility(this.listBox1);
			if(arg.Control == this.treeView1)
				this.cbTreeView.Checked = !this.dockingManager1.GetDockVisibility(this.treeView1);
			if(arg.Control == this.textBox1)
				this.cbTextBox.Checked = !this.dockingManager1.GetDockVisibility(this.textBox1);
		}		

		#endregion	

        private bool flag = false;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                if (flag)
                    cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        public void Customization()
        {
            this.tabControlAdv1.ActiveTabForeColor = Color.White;
            this.MetroColor = Color.White;
            this.BorderColor = ColorTranslator.FromHtml("#0aa2e6");
            this.BorderThickness = 2;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.CaptionVerticalAlignment = Syncfusion.Windows.Forms.VerticalAlignment.Bottom;
            this.treeView1.HScroll = false;

        }

        #region Setting Dock Label property
        private void cboDockLabel_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			
			//Sets the DockLabelAlignment Property
			switch((string)this.cboDockLabel.SelectedItem)
			{
				case "Left":
					this.dockingManager1.DockLabelAlignment=Syncfusion.Windows.Forms.Tools.DockLabelAlignmentStyle.Left;
					break;
				case "Right":
					this.dockingManager1.DockLabelAlignment=Syncfusion.Windows.Forms.Tools.DockLabelAlignmentStyle.Right;
					break;
				case "Center":
					this.dockingManager1.DockLabelAlignment=Syncfusion.Windows.Forms.Tools.DockLabelAlignmentStyle.Center;
					break;
				case "Default":
					this.dockingManager1.DockLabelAlignment=Syncfusion.Windows.Forms.Tools.DockLabelAlignmentStyle.Default;
					break;
			}

		}
		#endregion

		#region Setting Dock Tab Alignment property
		
		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			//Sets Dock Tab Alignment Property
			switch((string)this.comboBox1.SelectedItem)
				
			{
				case "Left":
					this.dockingManager1.DockTabAlignment=Syncfusion.Windows.Forms.Tools.DockTabAlignmentStyle.Left;
					break;
				case "Right":
					this.dockingManager1.DockTabAlignment=Syncfusion.Windows.Forms.Tools.DockTabAlignmentStyle.Right;
					break;
				case "Top":
					this.dockingManager1.DockTabAlignment=Syncfusion.Windows.Forms.Tools.DockTabAlignmentStyle.Top;
					break;
				case "Bottom":
					this.dockingManager1.DockTabAlignment=Syncfusion.Windows.Forms.Tools.DockTabAlignmentStyle.Bottom;
					break;
			}

		}
		#endregion

		#region Setting DragProvider Style for Docking Manager
		private void cboDrag_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			//Sets Dragprovider Style Property
			switch((string)this.cboDrag.SelectedItem)
				
			{
				case "Standard":
					this.dockingManager1.DragProviderStyle=Syncfusion.Windows.Forms.Tools.DragProviderStyle.Standard;
					break;
				case "VS2005":
					this.dockingManager1.DragProviderStyle=Syncfusion.Windows.Forms.Tools.DragProviderStyle.VS2005;
					break;
				case "Whidbey":
					this.dockingManager1.DragProviderStyle=Syncfusion.Windows.Forms.Tools.DragProviderStyle.Whidbey;
					break;
                case "VS2008":
                    this.dockingManager1.DragProviderStyle = Syncfusion.Windows.Forms.Tools.DragProviderStyle.VS2008;
                    break;
                case "VS2010":
                    this.dockingManager1.DragProviderStyle = Syncfusion.Windows.Forms.Tools.DragProviderStyle.VS2010;
                    break;
                case "VS2012":
                    this.dockingManager1.DragProviderStyle = Syncfusion.Windows.Forms.Tools.DragProviderStyle.VS2012;
                    break;
                case "Office2016Colorful":
                    this.dockingManager1.DragProviderStyle = Syncfusion.Windows.Forms.Tools.DragProviderStyle.Office2016Colorful;
                    break;
                case "Office2016Black":
                    this.dockingManager1.DragProviderStyle = Syncfusion.Windows.Forms.Tools.DragProviderStyle.Office2016Black;
                    break;
                case "Office2016DarkGray":
                    this.dockingManager1.DragProviderStyle = Syncfusion.Windows.Forms.Tools.DragProviderStyle.Office2016DarkGray;
                    break;

				
			}
		}
		#endregion

		#region Setting Browsing key for Docking windows
		private void cboBrowsingKey_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			//Sets Docking windows Browsing Key property
			switch((string)this.cboBrowsingKey.SelectedItem)
				
			{		
				case "PgDn":
					this.dockingManager1.BrowsingKey = ((System.Windows.Forms.Keys)(Enum.Parse(typeof(Keys),"Next")));
					break;
				case "PgUp":
					this.dockingManager1.BrowsingKey = ((System.Windows.Forms.Keys)(Enum.Parse(typeof(Keys),"Prior")));
					break;
				case "Del":
					this.dockingManager1.BrowsingKey = ((System.Windows.Forms.Keys)(Enum.Parse(typeof(Keys),"Delete")));
					break;

				default:
					this.dockingManager1.BrowsingKey = ((System.Windows.Forms.Keys)(Enum.Parse(typeof(Keys),(string)this.cboBrowsingKey.SelectedItem )));
					break;
			}
			
				
			
		}
		#endregion

		#region State Attributes changed events
		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.dockingManager1.FreezeResizing=checkBox1.Checked;
		}
		private void cbPaint_CheckedChanged(object sender, System.EventArgs e)
		{
			// Show/Hides the Border of the docking window
			this.dockingManager1.PaintBorders=this.cbPaint.Checked;
			
		}

		private void cbClose_CheckedChanged(object sender, System.EventArgs e)
		{
			this.dockingManager1.CloseEnabled=this.cbClose.Checked;

		}

		private void cbAuto_CheckedChanged(object sender, System.EventArgs e)
		{
			this.dockingManager1.ThemesEnabled=this.cbAuto.Checked;
		}

		private void cbContextMenu_CheckedChanged(object sender, System.EventArgs e)
		{
			this.dockingManager1.EnableContextMenu=this.cbContextMenu.Checked;
		}
		#endregion 

		#region Initialize Docking Manager Events
		public void InitEvents(DockingManager dm)
		{
			dm.AutoHideAnimationStart+=new AutoHideAnimationEventHandler(dm_AutoHideAnimationStart);
			dm.AutoHideAnimationStop+=new AutoHideAnimationEventHandler(dm_AutoHideAnimationStop);
			dm.DockAllow+=new DockAllowEventHandler(dm_DockAllow);
			dm.DockContextMenu+=new DockContextMenuEventHandler(dm_DockContextMenu);
			dm.DockControlActivated+=new DockActivationChangedEventHandler(dm_DockControlActivated);
			dm.DockControlDeactivated+=new DockActivationChangedEventHandler(dm_DockControlDeactivated);
			dm.DockMenuClick+=new DockMenuClickEventHandler(dm_DockMenuClick);
			dm.DockStateChanged+=new DockStateChangeEventHandler(dm_DockStateChanged);
			dm.DockStateChanging+=new DockStateChangeEventHandler(dm_DockStateChanging);
			dm.DockStateUnavailable+=new DockStateUnavailableEventHandler(dm_DockStateUnavailable);
			dm.DockVisibilityChanged+=new DockVisibilityChangedEventHandler(dm_DockVisibilityChanged);
			dm.DockVisibilityChanging+=new DockVisibilityChangingEventHandler(dm_DockVisibilityChanging);
			dm.DragAllow+=new DragAllowEventHandler(dm_DragAllow);
			dm.DragFeedbackStart+=new EventHandler(dm_DragFeedbackStart);
			dm.DragFeedbackStop+=new EventHandler(dm_DragFeedbackStop);
			dm.ImageListChanged+=new EventHandler(dm_ImageListChanged);
			dm.InitializeControlOnLoad+=new InitializeControlOnLoadEventHandler(dm_InitializeControlOnLoad);
			dm.NewDockStateBeginLoad+=new EventHandler(dm_NewDockStateBeginLoad);
			dm.NewDockStateEndLoad+=new EventHandler(dm_NewDockStateEndLoad);
			dm.ProvideGraphicsItems+=new ProvideGraphicsItemsEventHandler(dm_ProvideGraphicsItems);
			dm.ProvidePersistenceID+=new Syncfusion.Windows.Forms.ProvidePersistenceIDEventHandler(dm_ProvidePersistenceID);
			dm.TransferredToManager+=new TransferManagerEventHandler(dm_TransferredToManager);
			dm.TransferringFromManager+=new TransferManagerEventHandler(dm_TransferringFromManager);
		}
		#endregion //Initialize Events

		#region Standard Docking Manager Events
		
		//The AutoHideAnimationStart event occurs just before the start of an autohide animation.
		private void dm_AutoHideAnimationStart(object sender, AutoHideAnimationEventArgs arg)
		{
			selectedIndex=this.listBox2.Items.Add("AutoHide Animation Start - "+arg.Control.Name);
			SetIndex(selectedIndex);
			
		}

		//The AutoHideAnimationStop event occurs immediately after the end of an autohide animation.
		private void dm_AutoHideAnimationStop(object sender, AutoHideAnimationEventArgs arg)
		{
			selectedIndex=listBox2.Items.Add("AutoHide Animation Stop - "+arg.Control.Name);	
			SetIndex(selectedIndex);
		}

		//The DockAllow event occurs when a docking window is dragged over a potential dock target.
		private void dm_DockAllow(object sender, DockAllowEventArgs arg)
		{
			selectedIndex=listBox2.Items.Add("Dock Allow Event - "+"Drag Control - ["+arg.DragControl.Name+"], Target Control - ["+arg.TargetControl.Name+"], Docking Style  - ["+arg.DockStyle.ToString()+"]");	
			SetIndex(selectedIndex);
		}

		//The DockContextMenu event occurs when the right mouse button is clicked over a docking window's caption.
		private void dm_DockContextMenu(object sender, DockContextMenuEventArgs arg)
		{
			selectedIndex=listBox2.Items.Add("Dock Context Menu - Owner control ["+arg.Owner.Name+"]");	
			SetIndex(selectedIndex);
		}

		//The DockControlActivated event occurs when a dockable control gets activated.
		private void dm_DockControlActivated(object sender, DockActivationChangedEventArgs arg)
		{
			selectedIndex=listBox2.Items.Add("Dock Control Activated - [" +arg.Control.Name+"]");	
			SetIndex(selectedIndex);
			
		}

		//The DockControlDeactivated event occurs when a dockable control gets deactivated.
		private void dm_DockControlDeactivated(object sender, DockActivationChangedEventArgs arg)
		{
			selectedIndex=listBox2.Items.Add("Dock Control Deactivated - ["+arg.Control.Name+"]");	
			SetIndex(selectedIndex);
		}

		//
		private void dm_DockMenuClick(object sender, DockMenuClickEventArgs arg)
		{
			selectedIndex=listBox2.Items.Add("Dock Menu Click Event - ["+arg.Control.Name+"]" +" Docking Style ["+arg.DockingStyle.ToString()+"]");	
			SetIndex(selectedIndex);
		}

		//The DockStateChanged event occurs immediately after a dock operation.
		private void dm_DockStateChanged(object sender, DockStateChangeEventArgs arg)
		{
			selectedIndex=listBox2.Items.Add("Dock State Changed - ["+arg.Controls[0].Name+"]");	
			SetIndex(selectedIndex);
		}

		//The DockStateChanging event occurs just before a dock operation takes place.
		private void dm_DockStateChanging(object sender, DockStateChangeEventArgs arg)
		{
			selectedIndex=listBox2.Items.Add("Dock State Changing - ["+ arg.Controls[0].Name+"]");	
			SetIndex(selectedIndex);
		}

		//The DockStateUnavailable event occurs if serialized information is not available for a dockable control when loading a persisted dock state.
		private void dm_DockStateUnavailable(object sender, DockStateUnavailableEventArgs arg)
		{
			selectedIndex=listBox2.Items.Add("Dock State Unavailable - ["+arg.Control.Name+"]");	
			SetIndex(selectedIndex);
		}

		//The DockVisibilityChanged event occurs after a control's DockVisibility state has changed.
		private void dm_DockVisibilityChanged(object sender, DockVisibilityChangedEventArgs arg)
		{
			selectedIndex=listBox2.Items.Add("Dock Visibility Changed - ["+arg.Control.Name+"],Action -"+arg.Action.ToString() );	
			SetIndex(selectedIndex);
		}

		//The DockVisibilityChanging event occurs during a control's DockVisibility state is changing.
		private void dm_DockVisibilityChanging(object sender, DockVisibilityChangingEventArgs arg)
		{
			selectedIndex=listBox2.Items.Add("Dock Visibility Changing - ["+arg.Control.Name+"],Action -"+arg.Action.ToString());	
			SetIndex(selectedIndex);
		}

		//The DragAllow event occurs when a docking window is about to be dragged.
		private void dm_DragAllow(object sender, DragAllowEventArgs arg)
		{
			selectedIndex=listBox2.Items.Add("Drag Allow Event - ["+arg.Control.Name+"]");	
			SetIndex(selectedIndex);
		}

		//The DragFeedbackStart event occurs just before the start of feedback of a drag operation.
		private void dm_DragFeedbackStart(object sender, EventArgs e)
		{
			selectedIndex=listBox2.Items.Add("Drag Feedback Start");	
			SetIndex(selectedIndex);
		}

		//The DragFeedbackStop event occurs immediately after the end of feedback of a drag operation.
		private void dm_DragFeedbackStop(object sender, EventArgs e)
		{
			selectedIndex=listBox2.Items.Add("Drag Feedback Stop");	
			SetIndex(selectedIndex);
		}

		// Occurs when the ImageList property changes.
		private void dm_ImageListChanged(object sender, EventArgs e)
		{
			selectedIndex=listBox2.Items.Add("Image List Changed");	
			SetIndex(selectedIndex);
		}

		//The InitializeControlOnLoad event occurs when the DockingManager is not able to locate a control during a LoadDockState call.
		private void dm_InitializeControlOnLoad(object sender, InitializeControlOnLoadEventArgs arg)
		{
			selectedIndex=listBox2.Items.Add("Initialize Control On Load - ["+arg.ControlName+"]");	
			SetIndex(selectedIndex);
		}

		//The NewDockStateBeginLoad event occurs just before a new dock state is loaded.
		private void dm_NewDockStateBeginLoad(object sender, EventArgs e)
		{
			selectedIndex=listBox2.Items.Add("New Dock State Begin Load");	
			SetIndex(selectedIndex);
		}

		//The NewDockStateEndLoad event occurs immediately after a new dock state has been loaded.
		private void dm_NewDockStateEndLoad(object sender, EventArgs e)
		{
			selectedIndex=listBox2.Items.Add("New Dock State End Load");	
			SetIndex(selectedIndex);
		}

		//The ProvideGraphicsItems event occurs whenever a dockable control's caption needs to be painted.
		private void dm_ProvideGraphicsItems(object sender, ProvideGraphicsItemsEventArgs arg)
		{

		}

		//Lets you specify a unique ID used to distinguish the persistence information of different instances of the Form type.
		private void dm_ProvidePersistenceID(object sender, Syncfusion.Windows.Forms.ProvidePersistenceIDEventArgs e)
		{
			selectedIndex=listBox2.Items.Add("Provide Persistence ID");	
			SetIndex(selectedIndex);
		}

		//The TransferredToManager event occurs after a dockable control that previously belonged to some other DockingManager has been transferred to the docking layout hosted by this DockingManager.
		private void dm_TransferredToManager(object sender, TransferManagerEventArgs arg)
		{
			selectedIndex=listBox2.Items.Add("Transferred To Manager - ["+arg.Control.Name+"]");	
			SetIndex(selectedIndex);
		}

		//The TransferringFromManager event occurs when a dockable control hosted by this DockingManager is about to be transferred to the docking layout hosted by some other DockingManager.
		private void dm_TransferringFromManager(object sender, TransferManagerEventArgs arg)
		{
			selectedIndex=listBox2.Items.Add("Transferring From Manager - ["+arg.Control.Name+"]");	
			SetIndex(selectedIndex);
		}
		#endregion //Standard Events
		
		#region Selects the currently added item
		private void SetIndex(int i)
		{
			this.listBox2.SelectedIndex=i;
		}
		#endregion

		#region Setting Tooltip and Delete all listbox item in KeyDown Event
		private void listBox2_MouseHover(object sender, System.EventArgs e)
		{
			this.toolTip1.SetToolTip(this.listBox2,"Press Ctrl+Delete to clear the event logs");
		}

		private void listBox2_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==System.Windows.Forms.Keys.Delete|e.KeyCode==System.Windows.Forms.Keys.Control)
				this.listBox2.Items.Clear();
		}
		#endregion
       
        # region Event handlers
		    private void cbListBox_CheckedChanged(object sender, System.EventArgs e)
		    {
    			
			    this.dockingManager1.SetDockVisibility(this.listBox1, !cbListBox.Checked );
    			
		    } 

		    private void cbTreeView_CheckedChanged(object sender, System.EventArgs e)
		    {
			    // Shows / hides the treeview.
			    if(this.cbTreeView.Checked == true)
				    this.dockingManager1.SetDockVisibility(this.treeView1, false);
			    else
				    this.dockingManager1.SetDockVisibility(this.treeView1, true);			
		    }

		    private void cbTextBox_CheckedChanged(object sender, System.EventArgs e)
		    {
			    // Shows / hides the text box.
			    if(this.cbTextBox.Checked == true)
				    this.dockingManager1.SetDockVisibility(this.textBox1, false);
			    else
				    this.dockingManager1.SetDockVisibility(this.textBox1, true);			

		    }

		    private void cbAutoHide_CheckedChanged(object sender, System.EventArgs e)
		    {
			    // Enables / disables the autohide mode for the DockingManager.
			    if(this.cbAutoHide.Checked == true)
				    this.dockingManager1.AutoHideEnabled = false;
			    else
				    this.dockingManager1.AutoHideEnabled = true;		
		    }

		    private void cboVisualStyle_SelectedIndexChanged(object sender, System.EventArgs e)
		    {
				    //Sets Visual Style Property
                switch ((string)this.cboVisualStyle.SelectedItem)
                {
                    case "Office2016White":
                        this.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016White;
                    this.checkedListBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.checkedListBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.checkedListBox3.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.checkedListBox3.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.checkedListBox2.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.checkedListBox2.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.textBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.textBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.textBox2.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.textBox2.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.CaptionForeColor = ColorTranslator.FromHtml("#262626");
                    this.CaptionBarColor = ColorTranslator.FromHtml("#ffffff");
                    this.MetroColor = ColorTranslator.FromHtml("#ffffff");
                    this.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.listBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.listBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.listBox2.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.listBox2.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.treeView1.Style = TreeStyle.Office2016White;
                    this.label11.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label11.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel1.BackColor= ColorTranslator.FromHtml("#ffffff");
                    this.panel1.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.panel3.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel4.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel4.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.panel2.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel2.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.panel3.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.panel1.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.tabPageAdv3.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#ffffff"));
                    this.comboBox1.Style = VisualStyle.Office2016White;
                    this.cboDockLabel.Style = VisualStyle.Office2016White;
                    this.cboVisualStyle.Style = VisualStyle.Office2016White;
                    this.cboBrowsingKey.Style = VisualStyle.Office2016White;
                    this.cboDrag.Style = VisualStyle.Office2016White;
                    this.cboDockLabel.Style = VisualStyle.Office2016White;
                    this.comboBoxBase1.Style = VisualStyle.Office2016White;
                    this.comboBoxAdv1.Style = VisualStyle.Office2016White;
                    this.radioButton1.Style = RadioButtonAdvStyle.Office2016White;
                    this.rbLBMF.Style = RadioButtonAdvStyle.Office2016White;
                    this.rbTVTB.Style = RadioButtonAdvStyle.Office2016White;
                    this.rbLBTB.Style = RadioButtonAdvStyle.Office2016White;
                    this.rbLBTV.Style = RadioButtonAdvStyle.Office2016White;
                    this.cbTreeView.Style = CheckBoxAdvStyle.Office2016White;
                    this.cbListBox.Style = CheckBoxAdvStyle.Office2016White;
                    this.cbTreeView.Style = CheckBoxAdvStyle.Office2016White;
                    this.cbTextBox.Style = CheckBoxAdvStyle.Office2016White;
                    this.cbPaint.Style = CheckBoxAdvStyle.Office2016White;
                    this.checkBox1.Style = CheckBoxAdvStyle.Office2016White;
                    this.cbcheckedlist.Style = CheckBoxAdvStyle.Office2016White;
                    this.tabControlAdv1.TabStyle = typeof(TabRendererOffice2016White);

                    break;
                    case "Office2016Colorful":
                        this.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
                    this.checkedListBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.checkedListBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.checkedListBox3.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.checkedListBox3.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.checkedListBox2.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.checkedListBox2.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.textBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.textBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.textBox2.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.textBox2.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.CaptionForeColor = ColorTranslator.FromHtml("#262626");
                    this.CaptionBarColor = ColorTranslator.FromHtml("#ffffff");
                    this.MetroColor = ColorTranslator.FromHtml("#ffffff");
                    this.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.listBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.listBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.listBox2.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.listBox2.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.treeView1.Style = TreeStyle.Office2016Colorful;
                    this.label11.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label11.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel1.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel1.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.panel3.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel4.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel4.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.panel2.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel2.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.panel3.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.panel1.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.tabPageAdv3.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.gradientPanel1.BackgroundColor =new Syncfusion.Drawing.BrushInfo( ColorTranslator.FromHtml("#ffffff"));
                    this.comboBox1.Style = VisualStyle.Office2016Colorful;
                    this.cboDockLabel.Style = VisualStyle.Office2016Colorful;
                    this.cboVisualStyle.Style = VisualStyle.Office2016Colorful;
                    this.cboBrowsingKey.Style = VisualStyle.Office2016Colorful;
                    this.cboDrag.Style = VisualStyle.Office2016Colorful;
                    this.cboDockLabel.Style = VisualStyle.Office2016Colorful;
                    this.comboBoxBase1.Style = VisualStyle.Office2016Colorful;
                    this.comboBoxAdv1.Style = VisualStyle.Office2016Colorful;
                    this.radioButton1.Style = RadioButtonAdvStyle.Office2016Colorful;
                    this.rbLBMF.Style = RadioButtonAdvStyle.Office2016Colorful;
                    this.rbTVTB.Style = RadioButtonAdvStyle.Office2016Colorful;
                    this.rbLBTB.Style = RadioButtonAdvStyle.Office2016Colorful;
                    this.rbLBTV.Style = RadioButtonAdvStyle.Office2016Colorful;
                    this.cbTreeView.Style = CheckBoxAdvStyle.Office2016Colorful;
                    this.cbListBox.Style = CheckBoxAdvStyle.Office2016Colorful;
                    this.cbTreeView.Style = CheckBoxAdvStyle.Office2016Colorful;
                    this.cbTextBox.Style = CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBox1.Style = CheckBoxAdvStyle.Office2016Colorful;
                    this.cbPaint.Style = CheckBoxAdvStyle.Office2016Colorful;
                    this.cbcheckedlist.Style = CheckBoxAdvStyle.Office2016Colorful;
                    this.tabControlAdv1.TabStyle = typeof(TabRendererOffice2016Colorful);



                    break;

                    case "Office2016Black":
                        this.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016Black;
                    this.textBox1.BackColor = ColorTranslator.FromHtml("#262626");
                    this.textBox1.ForeColor = ColorTranslator.FromHtml("#ffffff");
                    this.textBox2.BackColor = ColorTranslator.FromHtml("#262626");
                    this.textBox2.ForeColor = ColorTranslator.FromHtml("#ffffff");
                    this.listBox1.BackColor = ColorTranslator.FromHtml("#262626");
                    this.listBox1.ForeColor = ColorTranslator.FromHtml("#ffffff");
                    this.checkedListBox1.BackColor = ColorTranslator.FromHtml("#262626");
                    this.checkedListBox1.ForeColor = ColorTranslator.FromHtml("#ffffff");
                    this.checkedListBox3.BackColor = ColorTranslator.FromHtml("#262626");
                    this.checkedListBox3.ForeColor = ColorTranslator.FromHtml("#ffffff");
                    this.checkedListBox2.BackColor = ColorTranslator.FromHtml("#262626");
                    this.checkedListBox2.ForeColor = ColorTranslator.FromHtml("#ffffff");
                    this.CaptionForeColor = ColorTranslator.FromHtml("#ffffff");
                    this.CaptionBarColor = ColorTranslator.FromHtml("#262626");
                    this.MetroColor = ColorTranslator.FromHtml("#262626");
                    this.BackColor = ColorTranslator.FromHtml("#262626");
                    this.listBox2.BackColor = ColorTranslator.FromHtml("#262626");
                    this.listBox2.ForeColor = ColorTranslator.FromHtml("#ffffff");
                    this.treeView1.Style = TreeStyle.Office2016Black;
                    this.label11.ForeColor = ColorTranslator.FromHtml("#ffffff");
                    this.label11.BackColor = ColorTranslator.FromHtml("#262626");
                    this.panel1.BackColor = ColorTranslator.FromHtml("#262626");
                    this.panel1.ForeColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel3.BackColor = ColorTranslator.FromHtml("#262626");
                    this.panel3.ForeColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel4.BackColor = ColorTranslator.FromHtml("#262626");
                    this.panel4.ForeColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel2.BackColor = ColorTranslator.FromHtml("#262626");
                    this.tabPageAdv3.BackColor= ColorTranslator.FromHtml("#262626");
                    this.panel2.ForeColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel3.ForeColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel1.ForeColor = ColorTranslator.FromHtml("#ffffff");
                    this.gradientPanel1.BackgroundColor =new Syncfusion.Drawing.BrushInfo( ColorTranslator.FromHtml("#262626"));
                    this.comboBox1.Style = VisualStyle.Office2016Black;
                    this.cboDockLabel.Style = VisualStyle.Office2016Black;
                    this.cboVisualStyle.Style = VisualStyle.Office2016Black;
                    this.cboBrowsingKey.Style = VisualStyle.Office2016Black;
                    this.cboDrag.Style = VisualStyle.Office2016Black;
                    this.cboDockLabel.Style = VisualStyle.Office2016Black;
                    this.comboBoxBase1.Style = VisualStyle.Office2016Black;
                    this.comboBoxAdv1.Style = VisualStyle.Office2016Black;
                    this.radioButton1.Style = RadioButtonAdvStyle.Office2016Black;
                    this.rbLBMF.Style = RadioButtonAdvStyle.Office2016Black;
                    this.rbTVTB.Style =RadioButtonAdvStyle.Office2016Black;
                    this.rbLBTB.Style =RadioButtonAdvStyle.Office2016Black;
                    this.rbLBTV.Style =RadioButtonAdvStyle.Office2016Black;
                    this.cbTreeView.Style = CheckBoxAdvStyle.Office2016Black;
                    this.cbListBox.Style = CheckBoxAdvStyle.Office2016Black;
                    this.cbTreeView.Style = CheckBoxAdvStyle.Office2016Black;
                    this.cbTextBox.Style = CheckBoxAdvStyle.Office2016Black;
                    this.cbPaint.Style = CheckBoxAdvStyle.Office2016Black;
                    this.checkBox1.Style = CheckBoxAdvStyle.Office2016Black;
                    this.cbcheckedlist.Style = CheckBoxAdvStyle.Office2016Black;
                    this.tabControlAdv1.TabStyle = typeof(TabRendererOffice2016Black);


                    break;
                    case "Office2016DarkGray":
                        this.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016DarkGray;
                    this.textBox1.BackColor = ColorTranslator.FromHtml("#666666");
                    this.textBox1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.textBox2.BackColor = ColorTranslator.FromHtml("#666666");
                    this.textBox2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.checkedListBox1.BackColor = ColorTranslator.FromHtml("#666666");
                    this.checkedListBox1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.checkedListBox3.BackColor = ColorTranslator.FromHtml("#666666");
                    this.checkedListBox3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.checkedListBox2.BackColor = ColorTranslator.FromHtml("#666666");
                    this.checkedListBox2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.CaptionForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.CaptionBarColor = ColorTranslator.FromHtml("#666666");
                    this.MetroColor = ColorTranslator.FromHtml("#666666");
                    this.BackColor = ColorTranslator.FromHtml("#666666");
                    this.listBox1.BackColor = ColorTranslator.FromHtml("#666666");
                    this.listBox1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.listBox2.BackColor = ColorTranslator.FromHtml("#666666");
                    this.listBox2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.treeView1.Style = TreeStyle.Office2016DarkGray;
                    this.label11.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label11.BackColor = ColorTranslator.FromHtml("#666666");
                    this.panel1.BackColor = ColorTranslator.FromHtml("#666666");
                    this.panel3.BackColor = ColorTranslator.FromHtml("#666666");
                    this.panel3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.panel1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.panel4.BackColor = ColorTranslator.FromHtml("#666666");
                    this.panel4.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.panel2.BackColor = ColorTranslator.FromHtml("#666666");
                    this.panel2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.panel3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.panel1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.tabPageAdv3.BackColor = ColorTranslator.FromHtml("#666666");
                    this.gradientPanel1.BackgroundColor =new Syncfusion.Drawing.BrushInfo( ColorTranslator.FromHtml("#666666"));
                    this.comboBoxAdv1.Style = VisualStyle.Office2016DarkGray;
                    this.comboBox1.Style = VisualStyle.Office2016DarkGray;
                    this.cboDockLabel.Style = VisualStyle.Office2016DarkGray;
                    this.cboVisualStyle.Style = VisualStyle.Office2016DarkGray;
                    this.cboBrowsingKey.Style = VisualStyle.Office2016DarkGray;
                    this.cboDrag.Style = VisualStyle.Office2016DarkGray;
                    this.cboDockLabel.Style = VisualStyle.Office2016DarkGray;
                    this.comboBoxBase1.Style = VisualStyle.Office2016DarkGray;
                    this.checkBox1.Style = CheckBoxAdvStyle.Office2016DarkGray;
                    this.cbListBox.Style = CheckBoxAdvStyle.Office2016DarkGray;
                    this.cbTreeView.Style = CheckBoxAdvStyle.Office2016DarkGray;
                    this.cbTextBox.Style = CheckBoxAdvStyle.Office2016DarkGray;
                    this.cbPaint.Style = CheckBoxAdvStyle.Office2016DarkGray;
                    this.radioButton1.Style = RadioButtonAdvStyle.Office2016DarkGray;
                    this.rbLBMF.Style = RadioButtonAdvStyle.Office2016DarkGray;
                    this.rbTVTB.Style = RadioButtonAdvStyle.Office2016DarkGray;
                    this.rbLBTB.Style = RadioButtonAdvStyle.Office2016DarkGray;
                    this.rbLBTV.Style = RadioButtonAdvStyle.Office2016DarkGray;
                    this.cbcheckedlist.Style = CheckBoxAdvStyle.Office2016DarkGray;
                    this.tabControlAdv1.TabStyle = typeof(TabRendererOffice2016DarkGray);

                    break;

                    case "Metro":
                        this.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
                    this.checkedListBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.checkedListBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.checkedListBox3.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.checkedListBox3.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.checkedListBox2.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.checkedListBox2.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.CaptionForeColor = ColorTranslator.FromHtml("#262626");
                    this.CaptionBarColor = ColorTranslator.FromHtml("#ffffff");
                    this.MetroColor= ColorTranslator.FromHtml("#ffffff");
                    this.textBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.textBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.textBox2.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.textBox2.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.listBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.listBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.listBox2.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.listBox2.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.label11.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label11.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel1.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel3.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel1.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.panel4.BackColor= ColorTranslator.FromHtml("#ffffff");
                    this.panel4.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.panel2.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.panel2.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.panel3.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.tabPageAdv3.BackColor = ColorTranslator.FromHtml("#262626");
                    this.panel1.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#ffffff"));
                    this.comboBox1.Style = VisualStyle.Metro;
                    this.cboDockLabel.Style = VisualStyle.Metro;
                    this.cboVisualStyle.Style = VisualStyle.Metro;
                    this.cboBrowsingKey.Style = VisualStyle.Metro;
                    this.checkBox1.Style = CheckBoxAdvStyle.Metro;
                    this.cboDrag.Style = VisualStyle.Metro;
                    this.cboDockLabel.Style = VisualStyle.Metro;
                    this.comboBoxBase1.Style = VisualStyle.Metro;
                    this.treeView1.Style = TreeStyle.Metro;
                    this.comboBoxAdv1.Style = VisualStyle.Metro;
                    this.radioButton1.Style = RadioButtonAdvStyle.Metro;
                    this.rbLBMF.Style = RadioButtonAdvStyle.Metro;
                    this.rbTVTB.Style = RadioButtonAdvStyle.Metro;
                    this.rbLBTB.Style = RadioButtonAdvStyle.Metro;
                    this.rbLBTV.Style = RadioButtonAdvStyle.Metro;
                    this.cbTreeView.Style = CheckBoxAdvStyle.Metro;
                    this.cbListBox.Style = CheckBoxAdvStyle.Metro;
                    this.cbTreeView.Style = CheckBoxAdvStyle.Metro;
                    this.cbTextBox.Style = CheckBoxAdvStyle.Metro;
                    this.cbPaint.Style = CheckBoxAdvStyle.Metro;
                    this.cbcheckedlist.Style = CheckBoxAdvStyle.Metro;
                    this.tabControlAdv1.TabStyle = typeof(TabRendererMetro);
                    break;
                }
		    }
		   
		    private void Form1_Load(object sender, System.EventArgs e)
		    {
			    cboDockLabel.SelectedIndex=2;
			    comboBox1.SelectedIndex=1;
			    cboDrag.SelectedIndex=1;
			    cboBrowsingKey.SelectedIndex=1;
                cboVisualStyle.SelectedIndex=1;
                comboBoxBase1.Text = this.dockingManager1.GetDockLabel(this.treeView1);
                this.dockingManager1.SetFreezeResize(this.treeView1,true);
                this.checkedListBox3.SetItemChecked(4, true);
                this.flag = true;
                this.MaximizeBox = true;
		    }
		    private void cbcheckedlist_CheckStateChanged(object sender, System.EventArgs e)
		    {
			    dockingManager1.SetDockVisibility(checkedListBox1,!cbcheckedlist.Checked );
			    dockingManager1.SetDockVisibility(checkedListBox2,!cbcheckedlist.Checked );
		    }
		    private void cbTextBox_CheckedChanged_1(object sender, System.EventArgs e)
		    {
			    dockingManager1.SetDockVisibility(textBox1,!cbTextBox.Checked);
		    }
		    private void cbAutoHide_CheckedChanged_1(object sender, System.EventArgs e)
		    {
			    dockingManager1.AutoHideEnabled=! cbAutoHide.Checked ;
		    }
    # endregion

        #region Freeze/Unfreeze

            private void AddDockControlsToList()
            {
                this.checkedListBox3.Items.Clear();
                foreach (Control c in this.dockingManager1.ControlsArray)
                {
                    //this.checkedListBox3.Items.Add(c.Name, this.dockingManager1.GetFreezeResize(c));
                    this.checkedListBox3.Items.Add(this.dockingManager1.GetDockLabel(c).ToString(), this.dockingManager1.GetFreezeResize(c));
                }
            }

            private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
            {
              Control ctrl = GetDockedControl(this.checkedListBox3.SelectedItem.ToString());
                if (ctrl != null)
                {
                    if (this.checkedListBox3.GetItemChecked(this.checkedListBox3.SelectedIndex))
                        this.dockingManager1.SetFreezeResize(ctrl, true);
                    else
                        this.dockingManager1.SetFreezeResize(ctrl, false);

                }
            }

            private Control GetDockedControl(string name)
            {
                foreach (Control c in this.dockingManager1.ControlsArray)
                {
                    if (this.dockingManager1.GetDockLabel(c).ToString() == name)
                        return c;
                }
                return null;
            }

            #endregion		

        private void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxAdv1.Text == "VS2008")
            {
                this.dockingManager1.DockBehavior = DockBehavior.VS2008;
            }
            else if (this.comboBoxAdv1.Text == "VS2010")
            {
                this.dockingManager1.DockBehavior = DockBehavior.VS2010;
            }
        }

	}
}
