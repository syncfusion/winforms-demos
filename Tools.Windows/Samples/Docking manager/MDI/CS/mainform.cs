#region Copyright Syncfusion Inc. 2001 - 2016
//
//  Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
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

	public class MainForm : MetroForm
	{       
        # region Members declaration
        ToolStripControlHost host;
        private Syncfusion.Windows.Forms.Tools.DockingManager dockingManager1;
        private System.ComponentModel.IContainer components;

        private int windowCount = 0;
        private System.Windows.Forms.ImageList ilCommon;
		private System.Windows.Forms.ListBox dwCurrent;
        private Syncfusion.Windows.Forms.Tools.TreeViewAdv dwDocumentBrowser;
		private TextBox dwNotes2;
        private TextBoxExt dwNotes1;
		private System.Windows.Forms.Panel dwNetwork;

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
        private ColorPickerUIAdv colorPickerUIAdv1;
        private Panel panel1;
        private ComboBoxAdv comboBoxAdv1;
        private Label label1;
        private Panel panel2;
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
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            this.comboBoxAdv1.Text = this.dockingManager1.VisualStyle.ToString();

		}

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
            this.MetroColor = Color.White;
            this.BorderColor = ColorTranslator.FromHtml("#0aa2e6");
            this.BorderThickness = 2;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.CaptionVerticalAlignment = Syncfusion.Windows.Forms.VerticalAlignment.Bottom;
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
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbdwNotes2 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbdwNotes1 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbdwNetwork = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbdwCurrent = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbpanel2 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
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
            this.dockingManager1 = new Syncfusion.Windows.Forms.Tools.DockingManager(this.components);
            this.ilCommon = new System.Windows.Forms.ImageList(this.components);
            this.dwNotes2 = new System.Windows.Forms.TextBox();
            this.dwNotes1 = new TextBoxExt();
            this.dwNetwork = new System.Windows.Forms.Panel();
            this.dwCurrent = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dwDocumentBrowser = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
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
            this.colorPickerUIAdv1 = new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dwDocumentBrowser)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dockingManager1
            // 
            this.dockingManager1.ActiveCaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dockingManager1.AutoHideTabForeColor = System.Drawing.Color.Empty;
            this.dockingManager1.DockLayoutStream = ((System.IO.MemoryStream)(resources.GetObject("dockingManager1.DockLayoutStream")));
            this.dockingManager1.DockTabForeColor = System.Drawing.Color.Empty;
            this.dockingManager1.DragProviderStyle = Syncfusion.Windows.Forms.Tools.DragProviderStyle.VS2012;
            this.dockingManager1.ForwardMenuShortcuts = false;
            this.dockingManager1.HostControl = this;
            this.dockingManager1.ImageList = this.ilCommon;
            this.dockingManager1.InActiveCaptionBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212))))));
            this.dockingManager1.InActiveCaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockingManager1.MetroButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dockingManager1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.dockingManager1.MetroSplitterBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(159)))), ((int)(((byte)(183)))));
            this.dockingManager1.Office2007MdiColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue;
            this.dockingManager1.ReduceFlickeringInRtl = false;
            this.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"));
            this.dockingManager1.SetDockLabel(this.dwNotes2, "Event Log");
            this.dockingManager1.SetDockIcon(this.dwNotes2, 3);
            this.dockingManager1.SetEnableDocking(this.dwNotes2, true);
            ccbdwNotes2.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.dwNotes2, ccbdwNotes2);
            this.dockingManager1.SetDockLabel(this.dwNotes1, "Find Results");
            this.dockingManager1.SetDockIcon(this.dwNotes1, 2);
            this.dockingManager1.SetEnableDocking(this.dwNotes1, true);
            ccbdwNotes1.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.dwNotes1, ccbdwNotes1);
            this.dockingManager1.SetDockLabel(this.dwNetwork, "Properties");
            this.dockingManager1.SetDockIcon(this.dwNetwork, 0);
            this.dockingManager1.SetEnableDocking(this.dwNetwork, true);
            ccbdwNetwork.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.dwNetwork, ccbdwNetwork);
            this.dockingManager1.SetDockLabel(this.panel2, "Solution Explorer");
            this.dockingManager1.SetEnableDocking(this.panel2, true);
            ccbpanel2.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.panel2, ccbpanel2);
            // 
            // ilCommon
            // 
            this.ilCommon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilCommon.ImageStream")));
            this.ilCommon.TransparentColor = System.Drawing.Color.Transparent;
            this.ilCommon.Images.SetKeyName(0, "DocIO.gif");
            this.ilCommon.Images.SetKeyName(1, "Grid.gif");
            this.ilCommon.Images.SetKeyName(2, "Sample.gif");
            this.ilCommon.Images.SetKeyName(3, "XlsIO.gif");
            // 
            // dwNotes2
            // 
            this.dwNotes2.BackColor = System.Drawing.Color.White;
            this.dwNotes2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dwNotes2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dwNotes2.Location = new System.Drawing.Point(1, 24);
            this.dwNotes2.Multiline = true;
            this.dwNotes2.Name = "dwNotes2";
            this.dwNotes2.Size = new System.Drawing.Size(860, 118);
            this.dwNotes2.TabIndex = 13;
            this.dwNotes2.Text = "\r\n    DockState Changing\r\n\r\n    DockState Changed\r\n";
            // 
            // dwNotes1
            // 
            this.dwNotes1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dwNotes1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dwNotes1.Location = new System.Drawing.Point(1, 24);
            this.dwNotes1.Multiline = true;
            this.dwNotes1.Name = "dwNotes1";
            this.dwNotes1.Size = new System.Drawing.Size(860, 118);
            this.dwNotes1.TabIndex = 17;
            this.dwNotes1.Text = "   Find Results 0,   Not Found";
            // 
            // dwNetwork
            // 
            this.dwNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dwNetwork.Location = new System.Drawing.Point(1, 24);
            this.dwNetwork.Name = "dwNetwork";
            this.dwNetwork.Size = new System.Drawing.Size(253, 393);
            this.dwNetwork.TabIndex = 16;
            // 
            // dwCurrent
            // 
            this.dwCurrent.BackColor = System.Drawing.Color.White;
            this.dwCurrent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dwCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dwCurrent.IntegralHeight = false;
            this.dwCurrent.Items.AddRange(new object[] {
            ""});
            this.dwCurrent.Location = new System.Drawing.Point(1, 24);
            this.dwCurrent.Name = "dwCurrent";
            this.dwCurrent.Size = new System.Drawing.Size(163, 418);
            this.dwCurrent.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dwDocumentBrowser);
            this.panel2.Location = new System.Drawing.Point(1, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 393);
            this.panel2.TabIndex = 10056;
            // 
            // dwDocumentBrowser
            // 
            this.dwDocumentBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dwDocumentBrowser.BackColor = System.Drawing.Color.White;
            this.dwDocumentBrowser.BeforeTouchSize = new System.Drawing.Size(236, 378);
            this.dwDocumentBrowser.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.dwDocumentBrowser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dwDocumentBrowser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dwDocumentBrowser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            // 
            // 
            // 
            this.dwDocumentBrowser.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dwDocumentBrowser.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.dwDocumentBrowser.HelpTextControl.Name = "helpText";
            this.dwDocumentBrowser.HelpTextControl.Size = new System.Drawing.Size(49, 15);
            this.dwDocumentBrowser.HelpTextControl.TabIndex = 0;
            this.dwDocumentBrowser.HelpTextControl.Text = "help text";
            this.dwDocumentBrowser.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.dwDocumentBrowser.LeftImageList = this.ilCommon;
            this.dwDocumentBrowser.Location = new System.Drawing.Point(9, 7);
            this.dwDocumentBrowser.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.dwDocumentBrowser.Name = "dwDocumentBrowser";
            treeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.Expanded = true;
            treeNodeAdv1.MultiLine = true;
            treeNodeAdv2.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.Expanded = true;
            treeNodeAdv2.MultiLine = true;
            treeNodeAdv3.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.Expanded = true;
            treeNodeAdv3.MultiLine = true;
            treeNodeAdv4.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.Expanded = true;
            treeNodeAdv4.MultiLine = true;
            treeNodeAdv4.Optioned = true;
            treeNodeAdv4.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv4.ShowLine = true;
            treeNodeAdv4.Text = "AssemblyInfo.cs";
            treeNodeAdv5.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.Expanded = true;
            treeNodeAdv5.MultiLine = true;
            treeNodeAdv6.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.MultiLine = true;
            treeNodeAdv6.Optioned = true;
            treeNodeAdv6.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv6.ShowLine = true;
            treeNodeAdv6.Text = "Resources.Designer.cs";
            treeNodeAdv5.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv6});
            treeNodeAdv5.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv5.ShowLine = true;
            treeNodeAdv5.Text = "Resources.resx";
            treeNodeAdv7.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.Expanded = true;
            treeNodeAdv7.MultiLine = true;
            treeNodeAdv8.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.MultiLine = true;
            treeNodeAdv8.Optioned = true;
            treeNodeAdv8.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv8.ShowLine = true;
            treeNodeAdv8.Text = "Settings.Designer.cs";
            treeNodeAdv7.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv8});
            treeNodeAdv7.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv7.ShowLine = true;
            treeNodeAdv7.Text = "Settings.settings";
            treeNodeAdv3.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv4,
            treeNodeAdv5,
            treeNodeAdv7});
            treeNodeAdv3.Optioned = true;
            treeNodeAdv3.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv3.ShowLine = true;
            treeNodeAdv3.Text = "Properties";
            treeNodeAdv9.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.Expanded = true;
            treeNodeAdv9.MultiLine = true;
            treeNodeAdv10.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv10.EnsureDefaultOptionedChild = true;
            treeNodeAdv10.MultiLine = true;
            treeNodeAdv10.Optioned = true;
            treeNodeAdv10.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv10.ShowLine = true;
            treeNodeAdv10.Text = "Microsoft.CSharp";
            treeNodeAdv9.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv10});
            treeNodeAdv9.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv9.ShowLine = true;
            treeNodeAdv9.Text = "References";
            treeNodeAdv11.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv11.EnsureDefaultOptionedChild = true;
            treeNodeAdv11.Expanded = true;
            treeNodeAdv11.MultiLine = true;
            treeNodeAdv12.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv12.EnsureDefaultOptionedChild = true;
            treeNodeAdv12.Expanded = true;
            treeNodeAdv12.MultiLine = true;
            treeNodeAdv12.Optioned = true;
            treeNodeAdv12.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv12.ShowLine = true;
            treeNodeAdv12.Text = "Form1.Designer.cs";
            treeNodeAdv13.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv13.EnsureDefaultOptionedChild = true;
            treeNodeAdv13.Expanded = true;
            treeNodeAdv13.MultiLine = true;
            treeNodeAdv13.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv13.ShowLine = true;
            treeNodeAdv13.Text = "Form1.resx";
            treeNodeAdv11.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv12,
            treeNodeAdv13});
            treeNodeAdv11.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv11.ShowLine = true;
            treeNodeAdv11.Text = "Form1.cs";
            treeNodeAdv14.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv14.EnsureDefaultOptionedChild = true;
            treeNodeAdv14.Expanded = true;
            treeNodeAdv14.MultiLine = true;
            treeNodeAdv14.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv14.ShowLine = true;
            treeNodeAdv14.Text = "Program.cs";
            treeNodeAdv2.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv3,
            treeNodeAdv9,
            treeNodeAdv11,
            treeNodeAdv14});
            treeNodeAdv2.Optioned = true;
            treeNodeAdv2.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv2.ShowLine = true;
            treeNodeAdv2.Text = "Docking_Demo";
            treeNodeAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv2});
            treeNodeAdv1.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv1.ShowLine = true;
            treeNodeAdv1.Text = "Solution \'Docking_Demo\'(1 project)";
            this.dwDocumentBrowser.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv1});
            this.dwDocumentBrowser.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.dwDocumentBrowser.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.dwDocumentBrowser.SelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))));
            this.dwDocumentBrowser.SelectedNodeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.dwDocumentBrowser.ShowFocusRect = false;
            this.dwDocumentBrowser.Size = new System.Drawing.Size(236, 378);
            this.dwDocumentBrowser.Style = Syncfusion.Windows.Forms.Tools.TreeStyle.Metro;
            this.dwDocumentBrowser.TabIndex = 11;
            this.dwDocumentBrowser.Text = "Solution Explorer";
            // 
            // 
            // 
            this.dwDocumentBrowser.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.dwDocumentBrowser.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dwDocumentBrowser.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.dwDocumentBrowser.ToolTipControl.Name = "toolTip";
            this.dwDocumentBrowser.ToolTipControl.Size = new System.Drawing.Size(41, 15);
            this.dwDocumentBrowser.ToolTipControl.TabIndex = 1;
            this.dwDocumentBrowser.ToolTipControl.Text = "toolTip";
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
            this.parentBarItem3.MetroColor = System.Drawing.Color.LightSkyBlue;
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
            this.cbToolBar.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.cbToolBar.MaxLength = 200;
            this.cbToolBar.MinHeight = 32;
            this.cbToolBar.MinLength = 50;
            this.cbToolBar.Name = "cbToolBar";
            this.cbToolBar.RowIndex = -1;
            this.cbToolBar.RowOffset = -1;
            this.cbToolBar.TabIndex = 0;
            this.cbToolBar.TabStop = false;
            // 
            // colorPickerUIAdv1.RecentGroup
            // 
            this.colorPickerUIAdv1.RecentGroup.Name = "Recent Colors";
            this.colorPickerUIAdv1.RecentGroup.Visible = false;
            // 
            // colorPickerUIAdv1.StandardGroup
            // 
            this.colorPickerUIAdv1.StandardGroup.Name = "Standard Colors";
            // 
            // colorPickerUIAdv1.ThemeGroup
            // 
            this.colorPickerUIAdv1.ThemeGroup.IsSubItemsVisible = true;
            this.colorPickerUIAdv1.ThemeGroup.Name = "Theme Colors";
            // 
            // colorPickerUIAdv1
            // 
            this.colorPickerUIAdv1.BeforeTouchSize = new System.Drawing.Size(13, 13);
            this.colorPickerUIAdv1.ColorItemSize = new System.Drawing.Size(13, 13);
            this.colorPickerUIAdv1.HorizontalItemsSpacing = 0;
            this.colorPickerUIAdv1.Location = new System.Drawing.Point(-1106, 204);
            this.colorPickerUIAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.colorPickerUIAdv1.MinimumSize = new System.Drawing.Size(136, 195);
            this.colorPickerUIAdv1.Name = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.colorPickerUIAdv1.Office2010Theme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.colorPickerUIAdv1.SelectedColor = System.Drawing.Color.Empty;
            this.colorPickerUIAdv1.Size = new System.Drawing.Size(136, 195);
            this.colorPickerUIAdv1.Style = Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.visualstyle.Default;
            this.colorPickerUIAdv1.TabIndex = 10018;
            this.colorPickerUIAdv1.Text = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.UseOffice2007Style = false;
            this.colorPickerUIAdv1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxAdv1);
          //  this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 29);
            this.panel1.TabIndex = 10039;
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(207, 21);
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Metro",
            "Office2016White",
            "Office2016Colorful",
            "Office2016Black",
            "Office2016DarkGray",
            });
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Default"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Metro"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Office2007Blue"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Office2007Black"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Office2007Silver"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Office2010Blue"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Office2010Black"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Office2010Silver"));
            this.comboBoxAdv1.Location = new System.Drawing.Point(651, 3);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.comboBoxAdv1.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.comboBoxAdv1.Size = new System.Drawing.Size(207, 21);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.TabIndex = 1;
            this.comboBoxAdv1.Text = "Default";
            this.comboBoxAdv1.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "MDI Demo";
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.ClientSize = new System.Drawing.Size(862, 644);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.colorPickerUIAdv1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(866, 680);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI Demo";
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dwDocumentBrowser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
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
            doc = new Document("Vestibulum");
            doc.FormBorderStyle = FormBorderStyle.None;
            this.dockingManager1.SetEnableDocking(doc, true);
            this.dockingManager1.SetDockIcon(doc, 0);
            this.dockingManager1.SetDockLabel(doc, "Vestibulum");
            this.dockingManager1.SetAsMDIChild(doc, true);
            doc1 = new Document("Lorem ipsum");
            doc1.FormBorderStyle = FormBorderStyle.None;
            this.dockingManager1.SetEnableDocking(doc1, true);
            this.dockingManager1.SetDockLabel(doc1, "Lorem ipsum");
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
                this.dwNotes1.BackColor = ColorTranslator.FromHtml("#666666");
                this.dwNotes1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.dwCurrent.BackColor = ColorTranslator.FromHtml("#666666");
                this.panel1.BackColor = ColorTranslator.FromHtml("#666666");
                this.panel2.BackColor = ColorTranslator.FromHtml("#666666");
                this.CaptionBarColor= ColorTranslator.FromHtml("#666666");
                this.CaptionForeColor= ColorTranslator.FromHtml("#f0f0f0");
                this.MetroColor = ColorTranslator.FromHtml("#666666");
                this.BackColor = ColorTranslator.FromHtml("#666666");
                doc1.richTextBox1.BackColor = ColorTranslator.FromHtml("#666666");
                doc1.BackColor = ColorTranslator.FromHtml("#666666");
                doc1.richTextBox1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                doc.richTextBox1.BackColor = ColorTranslator.FromHtml("#666666");
                doc.BackColor = ColorTranslator.FromHtml("#666666");
                doc.richTextBox1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2016Black"))
            {
                this.comboBoxAdv1.Style = VisualStyle.Office2016Black;
                this.dockingManager1.VisualStyle = VisualStyle.Office2016Black;
                this.dwDocumentBrowser.Style = TreeStyle.Office2016Black;
                this.dockingManager1.Office2007MdiColorScheme = Office2007Theme.Black;
                this.dwNotes1.BackColor = ColorTranslator.FromHtml("#262626");
                this.dwNotes1.ForeColor = ColorTranslator.FromHtml("#ffffff");
                this.panel2.BackColor = ColorTranslator.FromHtml("#262626");
                this.dwCurrent.BackColor = ColorTranslator.FromHtml("#262626");
                this.panel1.BackColor = ColorTranslator.FromHtml("#262626");
                this.CaptionBarColor = ColorTranslator.FromHtml("#262626");
                this.CaptionForeColor = ColorTranslator.FromHtml("#ffffff");
                this.MetroColor = ColorTranslator.FromHtml("#262626");
                this.BackColor = ColorTranslator.FromHtml("#262626");
                doc1.richTextBox1.BackColor = ColorTranslator.FromHtml("#262626");
                doc1.BackColor = ColorTranslator.FromHtml("#262626");
                doc1.richTextBox1.ForeColor = ColorTranslator.FromHtml("#ffffff");
                doc.richTextBox1.BackColor = ColorTranslator.FromHtml("#262626");
                doc.BackColor = ColorTranslator.FromHtml("#262626");
                doc.richTextBox1.ForeColor = ColorTranslator.FromHtml("#ffffff");


            }
            else if (this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2016Colorful"))
            {
                this.comboBoxAdv1.Style = VisualStyle.Office2016White;
                this.dockingManager1.VisualStyle = VisualStyle.Office2016White;
                this.dwDocumentBrowser.Style = TreeStyle.Office2016White;
                this.dockingManager1.Office2007MdiColorScheme = Office2007Theme.Blue;
                this.dwNotes1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.dwNotes1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.panel2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.dwCurrent.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.CaptionBarColor = ColorTranslator.FromHtml("#ffffff");
                this.CaptionForeColor = ColorTranslator.FromHtml("#262626");
                this.MetroColor= ColorTranslator.FromHtml("#ffffff");
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc1.richTextBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc1.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc1.richTextBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                doc.richTextBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc.richTextBox1.ForeColor = ColorTranslator.FromHtml("#262626");


            }
            else if (this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2016White"))
            {
                this.comboBoxAdv1.Style = VisualStyle.Office2016White;
                this.dockingManager1.VisualStyle = VisualStyle.Office2016White;
                this.dwDocumentBrowser.Style = TreeStyle.Office2016White;
                this.dockingManager1.Office2007MdiColorScheme = Office2007Theme.Blue;
                this.dwNotes1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.dwNotes1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.panel2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.dwCurrent.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.CaptionBarColor = ColorTranslator.FromHtml("#ffffff");
                this.CaptionForeColor = ColorTranslator.FromHtml("#262626");
                this.MetroColor = ColorTranslator.FromHtml("#ffffff");
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc1.richTextBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc1.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc1.richTextBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                doc.richTextBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc.richTextBox1.ForeColor = ColorTranslator.FromHtml("#262626");

            }
            else if (this.comboBoxAdv1.SelectedItem.ToString().Equals("Metro"))
            {
                this.comboBoxAdv1.Style = VisualStyle.Metro;
                this.dockingManager1.VisualStyle = VisualStyle.Metro;
                this.dwDocumentBrowser.Style = TreeStyle.Metro;
                this.dockingManager1.Office2007MdiColorScheme = Office2007Theme.Blue;
                this.dwNotes1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.dwNotes1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.panel2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.dwCurrent.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.CaptionBarColor = ColorTranslator.FromHtml("#ffffff");
                this.MetroColor = ColorTranslator.FromHtml("#ffffff");
                this.CaptionForeColor = ColorTranslator.FromHtml("#262626");
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc1.richTextBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc1.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc1.richTextBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                doc.richTextBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc.BackColor = ColorTranslator.FromHtml("#ffffff");
                doc.richTextBox1.ForeColor = ColorTranslator.FromHtml("#262626");

            }
        }
    }
}
