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

namespace MDIDemo
{    
	using System;
	using System.ComponentModel;
	using System.Drawing;
	using System.Windows.Forms;
	using System.Reflection;
	using System.Diagnostics;
	using System.Runtime.InteropServices;
    using Microsoft.Win32;

	using Syncfusion.Runtime.Serialization;
    using Syncfusion.Windows.Forms.Tools.XPMenus;
    using Syncfusion.Windows.Forms.Tools;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Licensing;
    using Syncfusion.WinForms.Controls;
    using Syncfusion.WinForms.Themes;
    using Syncfusion.HighContrastTheme.WinForms;

    public class MainForm : SfForm
	{
        # region Members declaration
        ToolStripControlHost host;
        private Syncfusion.Windows.Forms.Tools.DockingManager dockingManager1;
        private System.ComponentModel.IContainer components;

        private int windowCount = 0;
        private System.Windows.Forms.ImageList ilCommon;
		private System.Windows.Forms.ListBox dwCurrent;
        private Syncfusion.Windows.Forms.Tools.TreeViewAdv dwDocumentBrowser;

		// Used during CommandBar dockstate changes.
        private Size szToolBarPanel;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem5;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem6;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem7;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem8;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem9;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem10;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem11;
        private CommandBar cbToolBar;
        private Bar bar4;
        private ComboBoxAdv comboBoxAdv1;
        private Label label1;
        private Panel panel2;
        private CheckBoxAdv checkBoxAdv1;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Size szToolBarCommandBarPanel;
# endregion

        # region Initialization
		public MainForm()
		{
			//
			// Required for Windows Form Designer support.
			//
			
			InitializeComponent();

			//Set up MDI stuff.
			this.IsMdiContainer = true;
			// Get the toolbar and CommandBar panel sizes.
			this.szToolBarPanel = new Size(80,24);
			this.szToolBarCommandBarPanel = new Size(273,24);
            Customization();

            
            //Status Bar
            this.bar4 = new Bar();
            this.bar4.BarName = "Status Bar";
            this.bar4.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsStatusBar)));
            this.bar4.Caption = "Status Bar";
            
            this.dockingManager1.NewDockStateEndLoad += new EventHandler(dockingManager1_NewDockStateEndLoad);
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
            this.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            this.dockingManager1.LoadDockState();
            //this.dockingManager1.LoadDesignerDockState();
            //CreateNewDocument();

            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
            this.comboBoxAdv1.Text = this.dockingManager1.VisualStyle.ToString();

		}

        // Gets the size and position of MDI child windows.
        private Size mdiSize= new Size();
        private Size mdiSize1 = new Size();
        Point documentLocation;
        Point document1Location;

        void dockingManager1_NewDockStateEndLoad(object sender, EventArgs e)
        {
            CreateNewDocument();
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
        #endregion
        void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.dockingManager1.UnlockDockPanelsUpdate();
        }

        void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.dockingManager1.LockDockPanelsUpdate();
            this.dockingManager1.SaveDockState();
        }

        #region Customization
        public void Customization()
        {

        }
        #endregion

        /// <summary>
        ///    Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

       
		
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main(string[] args)
		{
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            SkinManager.LoadAssembly(typeof(Office2019Theme).Assembly);
            SkinManager.LoadAssembly(typeof(HighContrastTheme).Assembly);
            // Modify this version, whenever changes are made such that the persisted state cannot be loaded anymore.
            MainForm mainForm = new MainForm();
			Application.Run(mainForm);
		}
		
		/// <summary>
		///    Required method for Designer support - do not modify
		///    the contents of this method with the code editor.
		/// </summary>
		protected void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            this.dockingManager1 = new Syncfusion.Windows.Forms.Tools.DockingManager(this.components);
            this.ilCommon = new System.Windows.Forms.ImageList(this.components);
            this.dwDocumentBrowser = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.dwCurrent = new System.Windows.Forms.ListBox();
            this.parentBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem9 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem10 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem11 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.cbToolBar = new Syncfusion.Windows.Forms.Tools.CommandBar();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dwDocumentBrowser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockingManager1
            // 
            this.dockingManager1.ActiveCaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dockingManager1.AnimateAutoHiddenWindow = true;
            this.dockingManager1.AutoHideTabForeColor = System.Drawing.Color.Empty;
            this.dockingManager1.CloseTabOnMiddleClick = false;
#if !NETCORE
            this.dockingManager1.DockLayoutStream = ((System.IO.MemoryStream)(resources.GetObject("dockingManager1.DockLayoutStream")));
#endif
            this.dockingManager1.DragProviderStyle = Syncfusion.Windows.Forms.Tools.DragProviderStyle.VS2012;
            this.dockingManager1.ForwardMenuShortcuts = false;
            this.dockingManager1.HostControl = this;
            this.dockingManager1.ImageList = this.ilCommon;
            this.dockingManager1.InActiveCaptionBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212))))));
            this.dockingManager1.MetroButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dockingManager1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.dockingManager1.MetroSplitterBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(159)))), ((int)(((byte)(183)))));
            this.dockingManager1.Office2007MdiColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue;
            this.dockingManager1.ReduceFlickeringInRtl = false;
            this.dockingManager1.ThemeName = "Metro";
            this.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"));
            // 
            // ilCommon
            // 
            this.ilCommon.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilCommon.ImageSize = new System.Drawing.Size(16, 16);
            this.ilCommon.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dwDocumentBrowser
            // 
            treeNodeAdvStyleInfo1.CheckBoxTickThickness = 1;
            treeNodeAdvStyleInfo1.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.dwDocumentBrowser.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this.dwDocumentBrowser.BeforeTouchSize = new System.Drawing.Size(312, 368);
            // 
            // 
            // 
            this.dwDocumentBrowser.HelpTextControl.BaseThemeName = null;
            this.dwDocumentBrowser.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.dwDocumentBrowser.HelpTextControl.Name = "";
            this.dwDocumentBrowser.HelpTextControl.TabIndex = 0;
            this.dwDocumentBrowser.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.dwDocumentBrowser.Location = new System.Drawing.Point(0, 0);
            this.dwDocumentBrowser.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dwDocumentBrowser.Name = "dwDocumentBrowser";
            this.dwDocumentBrowser.SelectedNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this.dwDocumentBrowser.Size = new System.Drawing.Size(312, 368);
            this.dwDocumentBrowser.ThemeStyle.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.dwDocumentBrowser.ThemeStyle.TreeNodeAdvStyle.CheckBoxTickThickness = 1;
            this.dwDocumentBrowser.ThemeStyle.TreeNodeAdvStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dwDocumentBrowser.ThemeStyle.TreeNodeAdvStyle.EnsureDefaultOptionedChild = true;
            this.dwDocumentBrowser.ThemeStyle.TreeNodeAdvStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dwDocumentBrowser.ThemeStyle.TreeNodeAdvStyle.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dwDocumentBrowser.ThemeStyle.TreeNodeAdvStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            // 
            // 
            // 
            this.dwDocumentBrowser.ToolTipControl.BaseThemeName = null;
            this.dwDocumentBrowser.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.dwDocumentBrowser.ToolTipControl.Name = "";
            this.dwDocumentBrowser.ToolTipControl.TabIndex = 0;
            // 
            // dwCurrent
            // 
            this.dwCurrent.Location = new System.Drawing.Point(0, 0);
            this.dwCurrent.Name = "dwCurrent";
            this.dwCurrent.Size = new System.Drawing.Size(120, 96);
            this.dwCurrent.TabIndex = 0;
            // 
            // parentBarItem3
            // 
            this.parentBarItem3.BarName = "parentBarItem3";
            this.parentBarItem3.CategoryIndex = 1;
            this.parentBarItem3.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem3.ID = "FontFace";
            this.parentBarItem3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem5,
            this.barItem6,
            this.barItem7,
            this.barItem8});
            this.parentBarItem3.MetroColor = System.Drawing.Color.Red;
            this.parentBarItem3.ShowToolTipInPopUp = false;
            this.parentBarItem3.SizeToFit = true;
            this.parentBarItem3.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItem3.Text = "FontFace";
            this.parentBarItem3.WrapLength = 20;
            // 
            // barItem5
            // 
            this.barItem5.BarName = "barItem5";
            this.barItem5.CategoryIndex = 1;
            this.barItem5.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem5.ID = "1.Microsoft Sans Seriff";
            this.barItem5.ShowToolTipInPopUp = false;
            this.barItem5.SizeToFit = true;
            this.barItem5.Text = "1. Microsoft Sans Seriff";
            // 
            // barItem6
            // 
            this.barItem6.BarName = "barItem6";
            this.barItem6.CategoryIndex = 1;
            this.barItem6.Checked = true;
            this.barItem6.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem6.ID = "2. Calibri";
            this.barItem6.ShowToolTipInPopUp = false;
            this.barItem6.SizeToFit = true;
            this.barItem6.Text = "2. Calibri";
            // 
            // barItem7
            // 
            this.barItem7.BarName = "barItem7";
            this.barItem7.CategoryIndex = 1;
            this.barItem7.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem7.ID = "3. Courier New";
            this.barItem7.ShowToolTipInPopUp = false;
            this.barItem7.SizeToFit = true;
            this.barItem7.Text = "3. Courier New";
            // 
            // barItem8
            // 
            this.barItem8.BarName = "barItem8";
            this.barItem8.CategoryIndex = 1;
            this.barItem8.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem8.ID = "4. Times New Roman";
            this.barItem8.ShowToolTipInPopUp = false;
            this.barItem8.SizeToFit = true;
            this.barItem8.Text = "4. Times New Roman";
            // 
            // parentBarItem4
            // 
            this.parentBarItem4.BarName = "parentBarItem4";
            this.parentBarItem4.CategoryIndex = 1;
            this.parentBarItem4.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem4.ID = "FontSize";
            this.parentBarItem4.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem9});
            this.parentBarItem4.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem4.ShowToolTipInPopUp = false;
            this.parentBarItem4.SizeToFit = true;
            this.parentBarItem4.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItem4.Text = "FontSize";
            this.parentBarItem4.WrapLength = 20;
            // 
            // barItem9
            // 
            this.barItem9.BarName = "barItem9";
            this.barItem9.CategoryIndex = 1;
            this.barItem9.Checked = true;
            this.barItem9.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem9.ID = "Small";
            this.barItem9.ShowToolTipInPopUp = false;
            this.barItem9.SizeToFit = true;
            this.barItem9.Text = "Small";
            // 
            // barItem10
            // 
            this.barItem10.BarName = "barItem10";
            this.barItem10.CategoryIndex = 1;
            this.barItem10.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem10.ID = "Medium";
            this.barItem10.ShowToolTipInPopUp = false;
            this.barItem10.SizeToFit = true;
            this.barItem10.Text = "Medium";
            // 
            // barItem11
            // 
            this.barItem11.BarName = "barItem11";
            this.barItem11.CategoryIndex = 1;
            this.barItem11.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem11.ID = "Large";
            this.barItem11.ShowToolTipInPopUp = false;
            this.barItem11.SizeToFit = true;
            this.barItem11.Text = "Large";
            // 
            // cbToolBar
            // 
            this.cbToolBar.ChevronColor = System.Drawing.SystemColors.ControlText;
            this.cbToolBar.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Top;
            this.cbToolBar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.cbToolBar.MaxLength = 200;
            this.cbToolBar.MinHeight = 64;
            this.cbToolBar.MinLength = 50;
            this.cbToolBar.Name = "cbToolBar";
            this.cbToolBar.RowIndex = -1;
            this.cbToolBar.RowOffset = -1;
            this.cbToolBar.TabIndex = 0;
            this.cbToolBar.TabStop = false;
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(165, 31);
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Metro",
            "Office2016White",
            "Office2016Colorful",
            "Office2016Black",
            "Office2016DarkGray",
            "Office2019Colorful",
            "HighContrastBlack"});
            this.comboBoxAdv1.Location = new System.Drawing.Point(3, 3);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.comboBoxAdv1.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.comboBoxAdv1.Size = new System.Drawing.Size(165, 31);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.TabIndex = 1;
            this.comboBoxAdv1.Text = "Metro";
            this.comboBoxAdv1.ThemeName = "Metro";
            this.comboBoxAdv1.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(665, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 690);
            this.panel2.TabIndex = 10042;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 110);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.BeforeTouchSize = new System.Drawing.Size(165, 30);
            this.checkBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv1.ImageCheckBoxSize = new System.Drawing.Size(22, 22);
            this.checkBoxAdv1.Location = new System.Drawing.Point(3, 40);
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(165, 30);
            this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv1.TabIndex = 0;
            this.checkBoxAdv1.Text = "Float Window ";
            this.checkBoxAdv1.ThemeName = this.comboBoxAdv1.ThemeName;
            this.checkBoxAdv1.ThemesEnabled = true;
            this.checkBoxAdv1.CheckStateChanged += new System.EventHandler(this.checkBoxAdv1_CheckStateChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.comboBoxAdv1);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxAdv1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 34);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(171, 73);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 694);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(866, 680);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "MDI";
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dwDocumentBrowser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        #region Helper methods
        internal Document doc;
        internal Document doc1;

        private void CreateNewDocument()
		{
            this.SuspendLayout();
            this.dockingManager1.Office2007MdiChildForm = true;
            this.dockingManager1.LockHostFormUpdate();
            this.dockingManager1.LockDockPanelsUpdate();
            windowCount++;
            doc = new Document("Window1");
            doc.FormBorderStyle = FormBorderStyle.None;
            this.dockingManager1.SetEnableDocking(doc, true);
            this.dockingManager1.SetDockIcon(doc, 0);
            this.dockingManager1.SetDockLabel(doc, "Document2");
            this.dockingManager1.SetAsMDIChild(doc, true);
            doc1 = new Document("Window2");
            doc1.FormBorderStyle = FormBorderStyle.None;
            this.dockingManager1.SetEnableDocking(doc1, true);
            this.dockingManager1.SetDockLabel(doc1, "Document1");
            this.dockingManager1.SetDockIcon(doc1, 0);
            this.dockingManager1.SetAsMDIChild(doc1, true);
            this.dockingManager1.UnlockHostFormUpdate();
            this.dockingManager1.UnlockDockPanelsUpdate();

            this.ResumeLayout();
        }
        #endregion
        
        private void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2016DarkGray"))
            {
                this.comboBoxAdv1.Style = VisualStyle.Office2016DarkGray;
                this.dockingManager1.VisualStyle = VisualStyle.Office2016DarkGray;
                this.dwDocumentBrowser.Style = TreeStyle.Office2016DarkGray;
                this.dockingManager1.Office2007MdiColorScheme = Office2007Theme.Black;
                this.dwCurrent.BackColor = ColorTranslator.FromHtml("#666666");
                groupBox1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.panel2.BackColor = ColorTranslator.FromHtml("#666666");
                this.BackColor = ColorTranslator.FromHtml("#666666");
                foreach (Control control in this.Controls)
                {
                    // #2
                    MdiClient client = control as MdiClient;
                    if (!(client == null))
                    {
                        // #3
                        client.BackColor = ColorTranslator.FromHtml("#666666");
                        // 4#
                        break;
                    }
                }
                doc1.richTextBox1.BackColor = ColorTranslator.FromHtml("#666666");
                doc1.BackColor = ColorTranslator.FromHtml("#666666");
                doc1.richTextBox1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                doc.richTextBox1.BackColor = ColorTranslator.FromHtml("#666666");
                doc.BackColor = ColorTranslator.FromHtml("#666666");
                doc.richTextBox1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                checkBoxAdv1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2016Black"))
            {
                this.comboBoxAdv1.Style = VisualStyle.Office2016Black;
                this.dockingManager1.VisualStyle = VisualStyle.Office2016Black;
                this.dwDocumentBrowser.Style = TreeStyle.Office2016Black;
                this.dockingManager1.Office2007MdiColorScheme = Office2007Theme.Black;
                this.panel2.BackColor = ColorTranslator.FromHtml("#262626");
                this.dwCurrent.BackColor = ColorTranslator.FromHtml("#262626");
                foreach (Control control in this.Controls)
                {
                    // #2
                    MdiClient client = control as MdiClient;
                    if (!(client == null))
                    {
                        // #3
                        client.BackColor = ColorTranslator.FromHtml("#262626");
                        // 4#
                        break;
                    }
                }
                groupBox1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.BackColor = ColorTranslator.FromHtml("#262626");
                doc1.richTextBox1.BackColor = ColorTranslator.FromHtml("#262626");
                doc1.BackColor = ColorTranslator.FromHtml("#262626");
                doc1.richTextBox1.ForeColor = ColorTranslator.FromHtml("#ffffff");
                doc.richTextBox1.BackColor = ColorTranslator.FromHtml("#262626");
                doc.BackColor = ColorTranslator.FromHtml("#262626");
                doc.richTextBox1.ForeColor = ColorTranslator.FromHtml("#ffffff");
                checkBoxAdv1.ForeColor = ColorTranslator.FromHtml("#ffffff");

            }
            else if (this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2016Colorful"))
            {
                this.comboBoxAdv1.Style = VisualStyle.Office2016White;
                this.dockingManager1.VisualStyle = VisualStyle.Office2016White;
                this.dwDocumentBrowser.Style = TreeStyle.Office2016White;
                this.dockingManager1.Office2007MdiColorScheme = Office2007Theme.Blue;
                this.panel2.BackColor = ColorTranslator.FromHtml("#ffffff");
                foreach (Control control in this.Controls)
                {
                    // #2
                    MdiClient client = control as MdiClient;
                    if (!(client == null))
                    {
                        // #3
                        client.BackColor = ColorTranslator.FromHtml("#ffffff");
                        // 4#
                        break;
                    }
                }
                this.dwCurrent.BackColor = ColorTranslator.FromHtml("#ffffff");
                groupBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc1.richTextBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc1.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc1.richTextBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                doc.richTextBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc.richTextBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                checkBoxAdv1.ForeColor = ColorTranslator.FromHtml("#262626");

            }
            else if (this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2016White"))
            {
                this.comboBoxAdv1.Style = VisualStyle.Office2016White;
                this.dockingManager1.VisualStyle = VisualStyle.Office2016White;
                this.dwDocumentBrowser.Style = TreeStyle.Office2016White;
                this.dockingManager1.Office2007MdiColorScheme = Office2007Theme.Blue;
                this.panel2.BackColor = ColorTranslator.FromHtml("#ffffff");
                foreach (Control control in this.Controls)
                {
                    // #2
                    MdiClient client = control as MdiClient;
                    if (!(client == null))
                    {
                        // #3
                        client.BackColor = ColorTranslator.FromHtml("#ffffff");
                        // 4#
                        break;
                    }
                }
                this.dwCurrent.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc1.richTextBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc1.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc1.richTextBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                doc.richTextBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc.richTextBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                checkBoxAdv1.ForeColor = ColorTranslator.FromHtml("#262626");
                groupBox1.ForeColor = ColorTranslator.FromHtml("#262626");
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString().Equals("Metro"))
            {
                this.comboBoxAdv1.Style = VisualStyle.Metro;
                this.dockingManager1.VisualStyle = VisualStyle.Metro;
                this.dwDocumentBrowser.Style = TreeStyle.Metro;
                this.dockingManager1.Office2007MdiColorScheme = Office2007Theme.Blue;
                this.panel2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.dwCurrent.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                foreach (Control control in this.Controls)
                {
                    // #2
                    MdiClient client = control as MdiClient;
                    if (!(client == null))
                    {
                        // #3
                        client.BackColor = ColorTranslator.FromHtml("#ffffff");
                        // 4#
                        break;
                    }
                }
                doc1.richTextBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc1.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc1.richTextBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                doc.richTextBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc.richTextBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                checkBoxAdv1.ForeColor= ColorTranslator.FromHtml("#262626");
                groupBox1.ForeColor = ColorTranslator.FromHtml("#262626");
            }
            else if(this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2019Colorful"))
            {
                this.comboBoxAdv1.ThemeName = "Office2019Colorful";
                this.dockingManager1.ThemeName = "Office2019Colorful";
                this.dwDocumentBrowser.ThemeName = "Office2019Colorful";
                this.dockingManager1.Office2007MdiColorScheme = Office2007Theme.Blue;
                this.panel2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.dwCurrent.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                foreach (Control control in this.Controls)
                {
                    // #2
                    MdiClient client = control as MdiClient;
                    if (!(client == null))
                    {
                        // #3
                        client.BackColor = ColorTranslator.FromHtml("#ffffff");
                        // 4#
                        break;
                    }
                }
                doc1.richTextBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc1.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc1.richTextBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                doc.richTextBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc.richTextBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                checkBoxAdv1.ForeColor= ColorTranslator.FromHtml("#262626");
                groupBox1.ForeColor = ColorTranslator.FromHtml("#262626");
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString().Equals("HighContrastBlack"))
            {
                this.comboBoxAdv1.ThemeName = "HighContrastBlack";
                this.dockingManager1.ThemeName = "HighContrastBlack";
                this.dwDocumentBrowser.ThemeName = "HighContrastBlack";
                this.dockingManager1.Office2007MdiColorScheme = Office2007Theme.Black;
                this.panel2.BackColor = ColorTranslator.FromHtml("#262626");
                this.dwCurrent.BackColor = ColorTranslator.FromHtml("#262626");
                this.BackColor = ColorTranslator.FromHtml("#444444");
                foreach (Control control in this.Controls)
                {
                    // #2
                    MdiClient client = control as MdiClient;
                    if (!(client == null))
                    {
                        // #3
                        client.BackColor = ColorTranslator.FromHtml("#444444");
                        // 4#
                        break;
                    }
                }
                doc1.richTextBox1.BackColor = ColorTranslator.FromHtml("#262626");
                doc1.BackColor = ColorTranslator.FromHtml("#262626");
                doc1.richTextBox1.ForeColor = ColorTranslator.FromHtml("#ffffff");
                doc.richTextBox1.BackColor = ColorTranslator.FromHtml("#262626");
                doc.BackColor = ColorTranslator.FromHtml("#262626");
                doc.richTextBox1.ForeColor = ColorTranslator.FromHtml("#ffffff");
                checkBoxAdv1.ForeColor = ColorTranslator.FromHtml("#ffffff");
                groupBox1.ForeColor = ColorTranslator.FromHtml("#ffffff");

            }

        }

        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.MdiChildren != null)
            {
                documentLocation = this.doc.PointToScreen(this.doc.Location);
                mdiSize = this.doc.Bounds.Size;
                document1Location = this.doc1.PointToScreen(this.doc1.Location);
                mdiSize1 = this.doc1.Bounds.Size;
                if (this.checkBoxAdv1.Checked)
                {

                    Rectangle rectangle = this.Bounds;
                    this.dockingManager1.SetAsMDIChild(doc, false);
                    this.dockingManager1.SetAsMDIChild(doc1, false);
                    this.IsMdiContainer = false;
                    this.dockingManager1.SetAllowFloating(panel2, true);
                    this.dockingManager1.FloatControl(this.doc, new Rectangle(new Point(documentLocation.X, documentLocation.Y - 30), mdiSize));
                    this.dockingManager1.FloatControl(this.doc1, new Rectangle(new Point(document1Location.X, document1Location.Y - 30), mdiSize1));
                }
                else
                {
                    this.IsMdiContainer = true;
                    this.dockingManager1.SetAsMDIChild(doc, true);
                    this.dockingManager1.SetAsMDIChild(doc1, true);
                }
            }
        }
    }
}
