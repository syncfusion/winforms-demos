#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System.Drawing;
using System.Windows.Forms;

namespace VisualStudioDemo
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

        public static void LoadImages(ImageList imageList, string folder, int count)
        {
            for (int i = 1; i <= count; i++)
            {
                string imagePath = ($"VisualStudioDemo.Images.{folder}.Image_{i}.png");
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
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbpanel1 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbpanel2 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbpanel3 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbpanel4 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbpanel5 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
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
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv17 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv18 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv19 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv20 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv21 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv22 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv23 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv24 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv25 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv26 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv27 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv28 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv29 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv30 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv31 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv32 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "",
            "TODO: Add any constructor code after InitializeComponent call"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            Syncfusion.Windows.Forms.Edit.Implementation.Config.Config config1 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config();
            Syncfusion.Windows.Forms.Edit.Implementation.Config.Config config2 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config();
            this.dockingManager1 = new Syncfusion.Windows.Forms.Tools.DockingManager(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeViewAdv1 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.dwTaskListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorlistToolBar = new Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar();
            this.barItem14 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem15 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem16 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.outputTypeComboBox = new System.Windows.Forms.ComboBox();
            this.panel5 = new VisualStudioDemo.SolutionExplorerView();
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "File");
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem9 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem10 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.comboBoxBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem();
            this.editControl1 = new Syncfusion.Windows.Forms.Edit.EditControl();
            this.editControl2 = new Syncfusion.Windows.Forms.Edit.EditControl();
            this.dockingImageList = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.imageList4 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // dockingManager1
            // 
            this.dockingManager1.ActiveCaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockingManager1.ActiveCaptionForeGround = System.Drawing.Color.RosyBrown;
            this.dockingManager1.AnimateAutoHiddenWindow = true;
            this.dockingManager1.AutoHideTabForeColor = System.Drawing.Color.Empty;
            this.dockingManager1.AutoHideTabHeight = 25;
            this.dockingManager1.BorderColor = System.Drawing.SystemColors.ActiveCaption;
#if !NETCORE
            this.dockingManager1.DockLayoutStream = ((System.IO.MemoryStream)(resources.GetObject("dockingManager1.DockLayoutStream")));
#endif
            this.dockingManager1.DockTabPadX = 0F;
            this.dockingManager1.DragProviderStyle = Syncfusion.Windows.Forms.Tools.DragProviderStyle.VS2012;
            this.dockingManager1.HostControl = this;
            this.dockingManager1.InActiveCaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockingManager1.MetroButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dockingManager1.MetroCaptionColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.dockingManager1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.dockingManager1.MetroInactiveCaptionColor = System.Drawing.Color.White;
            this.dockingManager1.MetroSplitterBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(159)))), ((int)(((byte)(183)))));
            this.dockingManager1.ReduceFlickeringInRtl = false;
            this.dockingManager1.ShowMetroCaptionDottedLines = false;
            this.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.VS2010;
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Restore, "RestoreButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"));
            this.dockingManager1.SetDockLabel(this.panel1, "Toolbox");
            this.dockingManager1.SetEnableDocking(this.panel1, true);
            ccbpanel1.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.panel1, ccbpanel1);
            this.dockingManager1.SetDockLabel(this.panel2, "Immediate Window");
            this.dockingManager1.SetEnableDocking(this.panel2, true);
            ccbpanel2.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.panel2, ccbpanel2);
            this.dockingManager1.SetDockLabel(this.panel3, "Find Symbol Results");
            this.dockingManager1.SetEnableDocking(this.panel3, true);
            ccbpanel3.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.panel3, ccbpanel3);
            this.dockingManager1.SetDockLabel(this.panel4, "Output");
            this.dockingManager1.SetEnableDocking(this.panel4, true);
            ccbpanel4.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.panel4, ccbpanel4);
            this.dockingManager1.SetDockLabel(this.panel5, "Solution Explorer");
            this.dockingManager1.SetEnableDocking(this.panel5, true);
            ccbpanel5.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.panel5, ccbpanel5);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeViewAdv1);
            this.panel1.Location = new System.Drawing.Point(1, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 331);
            this.panel1.TabIndex = 5;
            // 
            // treeViewAdv1
            // 
            this.treeViewAdv1.BackColor = System.Drawing.Color.White;
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdvStyleInfo1.TextColor = System.Drawing.SystemColors.ControlText;
            this.treeViewAdv1.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this.treeViewAdv1.BeforeTouchSize = new System.Drawing.Size(281, 331);
            this.treeViewAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.treeViewAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewAdv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.treeViewAdv1.LeftImageList = this.imageList1;
            this.treeViewAdv1.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.treeViewAdv1.MetroScrollBars = true;
            this.treeViewAdv1.Name = "treeViewAdv1";
            treeNodeAdv1.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246))))));
            treeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.Expanded = true;
            treeNodeAdv1.MultiLine = true;
            treeNodeAdv2.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.LeftImageIndices = new int[] {
        0};
            treeNodeAdv2.MultiLine = true;
            treeNodeAdv2.Optioned = true;
            treeNodeAdv2.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv2.ShowLine = true;
            treeNodeAdv2.Text = "  Pointer";
            treeNodeAdv3.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.LeftImageIndices = new int[] {
        1};
            treeNodeAdv3.MultiLine = true;
            treeNodeAdv3.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv3.ShowLine = true;
            treeNodeAdv3.Text = "  BackgroundWorker";
            treeNodeAdv4.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.LeftImageIndices = new int[] {
        2};
            treeNodeAdv4.MultiLine = true;
            treeNodeAdv4.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv4.ShowLine = true;
            treeNodeAdv4.Text = "  BindingNavigator";
            treeNodeAdv5.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.LeftImageIndices = new int[] {
        3};
            treeNodeAdv5.MultiLine = true;
            treeNodeAdv5.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv5.ShowLine = true;
            treeNodeAdv5.Text = "  BindingSource";
            treeNodeAdv6.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.LeftImageIndices = new int[] {
        4};
            treeNodeAdv6.MultiLine = true;
            treeNodeAdv6.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv6.ShowLine = true;
            treeNodeAdv6.Text = "  Button";
            treeNodeAdv7.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.LeftImageIndices = new int[] {
        5};
            treeNodeAdv7.MultiLine = true;
            treeNodeAdv7.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv7.ShowLine = true;
            treeNodeAdv7.Text = "  CheckBox";
            treeNodeAdv8.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.LeftImageIndices = new int[] {
        6};
            treeNodeAdv8.MultiLine = true;
            treeNodeAdv8.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv8.ShowLine = true;
            treeNodeAdv8.Text = "  ColorDialog";
            treeNodeAdv9.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.LeftImageIndices = new int[] {
        7};
            treeNodeAdv9.MultiLine = true;
            treeNodeAdv9.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv9.ShowLine = true;
            treeNodeAdv9.Text = "  ComboBox";
            treeNodeAdv10.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv10.EnsureDefaultOptionedChild = true;
            treeNodeAdv10.LeftImageIndices = new int[] {
        9};
            treeNodeAdv10.MultiLine = true;
            treeNodeAdv10.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv10.ShowLine = true;
            treeNodeAdv10.Text = "  DataGridView";
            treeNodeAdv11.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv11.EnsureDefaultOptionedChild = true;
            treeNodeAdv11.LeftImageIndices = new int[] {
        10};
            treeNodeAdv11.MultiLine = true;
            treeNodeAdv11.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv11.ShowLine = true;
            treeNodeAdv11.Text = "  DataSet";
            treeNodeAdv12.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv12.EnsureDefaultOptionedChild = true;
            treeNodeAdv12.LeftImageIndices = new int[] {
        12};
            treeNodeAdv12.MultiLine = true;
            treeNodeAdv12.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv12.ShowLine = true;
            treeNodeAdv12.Text = "  ErrorProvider";
            treeNodeAdv13.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv13.EnsureDefaultOptionedChild = true;
            treeNodeAdv13.LeftImageIndices = new int[] {
        13};
            treeNodeAdv13.MultiLine = true;
            treeNodeAdv13.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv13.ShowLine = true;
            treeNodeAdv13.Text = "  EventLog";
            treeNodeAdv14.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv14.EnsureDefaultOptionedChild = true;
            treeNodeAdv14.LeftImageIndices = new int[] {
        2};
            treeNodeAdv14.MultiLine = true;
            treeNodeAdv14.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv14.ShowLine = true;
            treeNodeAdv14.Text = "  FlowlayoutPanel";
            treeNodeAdv15.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv15.EnsureDefaultOptionedChild = true;
            treeNodeAdv15.LeftImageIndices = new int[] {
        13};
            treeNodeAdv15.MultiLine = true;
            treeNodeAdv15.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv15.ShowLine = true;
            treeNodeAdv15.Text = "  FileSystemWatcher";
            treeNodeAdv16.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv16.EnsureDefaultOptionedChild = true;
            treeNodeAdv16.LeftImageIndices = new int[] {
        8};
            treeNodeAdv16.MultiLine = true;
            treeNodeAdv16.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv16.ShowLine = true;
            treeNodeAdv16.Text = "  GroupBox";
            treeNodeAdv17.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv17.EnsureDefaultOptionedChild = true;
            treeNodeAdv17.LeftImageIndices = new int[] {
        7};
            treeNodeAdv17.MultiLine = true;
            treeNodeAdv17.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv17.ShowLine = true;
            treeNodeAdv17.Text = "  HScrollBar";
            treeNodeAdv18.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv18.EnsureDefaultOptionedChild = true;
            treeNodeAdv18.LeftImageIndices = new int[] {
        4};
            treeNodeAdv18.MultiLine = true;
            treeNodeAdv18.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv18.ShowLine = true;
            treeNodeAdv18.Text = "  imageList";
            treeNodeAdv19.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv19.EnsureDefaultOptionedChild = true;
            treeNodeAdv19.LeftImageIndices = new int[] {
        12};
            treeNodeAdv19.MultiLine = true;
            treeNodeAdv19.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv19.ShowLine = true;
            treeNodeAdv19.Text = "  Label";
            treeNodeAdv20.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv20.EnsureDefaultOptionedChild = true;
            treeNodeAdv20.LeftImageIndices = new int[] {
        3};
            treeNodeAdv20.MultiLine = true;
            treeNodeAdv20.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv20.ShowLine = true;
            treeNodeAdv20.Text = "  ListBox";
            treeNodeAdv21.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv21.EnsureDefaultOptionedChild = true;
            treeNodeAdv21.LeftImageIndices = new int[] {
        10};
            treeNodeAdv21.MultiLine = true;
            treeNodeAdv21.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv21.ShowLine = true;
            treeNodeAdv21.Text = "  ListView";
            treeNodeAdv22.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv22.EnsureDefaultOptionedChild = true;
            treeNodeAdv22.LeftImageIndices = new int[] {
        12};
            treeNodeAdv22.MultiLine = true;
            treeNodeAdv22.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv22.ShowLine = true;
            treeNodeAdv22.Text = "  MaskedTextBox";
            treeNodeAdv23.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv23.EnsureDefaultOptionedChild = true;
            treeNodeAdv23.LeftImageIndices = new int[] {
        2};
            treeNodeAdv23.MultiLine = true;
            treeNodeAdv23.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv23.ShowLine = true;
            treeNodeAdv23.Text = "  MonthCalender";
            treeNodeAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv2,
            treeNodeAdv3,
            treeNodeAdv4,
            treeNodeAdv5,
            treeNodeAdv6,
            treeNodeAdv7,
            treeNodeAdv8,
            treeNodeAdv9,
            treeNodeAdv10,
            treeNodeAdv11,
            treeNodeAdv12,
            treeNodeAdv13,
            treeNodeAdv14,
            treeNodeAdv15,
            treeNodeAdv16,
            treeNodeAdv17,
            treeNodeAdv18,
            treeNodeAdv19,
            treeNodeAdv20,
            treeNodeAdv21,
            treeNodeAdv22,
            treeNodeAdv23});
            treeNodeAdv1.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv1.ShowLine = true;
            treeNodeAdv1.Text = "All Windows Forms Control";
            treeNodeAdv24.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246))))));
            treeNodeAdv24.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv24.EnsureDefaultOptionedChild = true;
            treeNodeAdv24.Expanded = true;
            treeNodeAdv24.MultiLine = true;
            treeNodeAdv25.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv25.EnsureDefaultOptionedChild = true;
            treeNodeAdv25.LeftImageIndices = new int[] {
        15};
            treeNodeAdv25.MultiLine = true;
            treeNodeAdv25.Optioned = true;
            treeNodeAdv25.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv25.ShowLine = true;
            treeNodeAdv25.Text = "  AutoComplete";
            treeNodeAdv26.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv26.EnsureDefaultOptionedChild = true;
            treeNodeAdv26.LeftImageIndices = new int[] {
        16};
            treeNodeAdv26.MultiLine = true;
            treeNodeAdv26.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv26.ShowLine = true;
            treeNodeAdv26.Text = "  ButtonAdv";
            treeNodeAdv27.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv27.EnsureDefaultOptionedChild = true;
            treeNodeAdv27.LeftImageIndices = new int[] {
        20};
            treeNodeAdv27.MultiLine = true;
            treeNodeAdv27.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv27.ShowLine = true;
            treeNodeAdv27.Text = "  ContextMenuStrip";
            treeNodeAdv28.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv28.EnsureDefaultOptionedChild = true;
            treeNodeAdv28.LeftImageIndices = new int[] {
        19};
            treeNodeAdv28.MultiLine = true;
            treeNodeAdv28.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv28.ShowLine = true;
            treeNodeAdv28.Text = "  ColorPickerUIAdv";
            treeNodeAdv29.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv29.EnsureDefaultOptionedChild = true;
            treeNodeAdv29.LeftImageIndices = new int[] {
        5};
            treeNodeAdv29.MultiLine = true;
            treeNodeAdv29.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv29.ShowLine = true;
            treeNodeAdv29.Text = "  CheckBoxAdv";
            treeNodeAdv30.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            treeNodeAdv30.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv30.EnsureDefaultOptionedChild = true;
            treeNodeAdv30.LeftImageIndices = new int[] {
        9};
            treeNodeAdv30.MultiLine = true;
            treeNodeAdv30.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv30.ShowLine = true;
            treeNodeAdv30.Text = "  CalculatorControl";
            treeNodeAdv31.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv31.EnsureDefaultOptionedChild = true;
            treeNodeAdv31.LeftImageIndices = new int[] {
        21};
            treeNodeAdv31.MultiLine = true;
            treeNodeAdv31.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv31.ShowLine = true;
            treeNodeAdv31.Text = "  DateTimePicker";
            treeNodeAdv32.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv32.EnsureDefaultOptionedChild = true;
            treeNodeAdv32.LeftImageIndices = new int[] {
        23};
            treeNodeAdv32.MultiLine = true;
            treeNodeAdv32.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv32.ShowLine = true;
            treeNodeAdv32.Text = "  DockingManager";
            treeNodeAdv24.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv25,
            treeNodeAdv26,
            treeNodeAdv27,
            treeNodeAdv28,
            treeNodeAdv29,
            treeNodeAdv30,
            treeNodeAdv31,
            treeNodeAdv32});
            treeNodeAdv24.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv24.ShowLine = true;
            treeNodeAdv24.Text = "Syncfusion Controls";
            this.treeViewAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv1,
            treeNodeAdv24});
            this.treeViewAdv1.SelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255))))));
            this.treeViewAdv1.SelectedNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this.treeViewAdv1.ShowFocusRect = false;
            this.treeViewAdv1.ShowLines = false;
            this.treeViewAdv1.Size = new System.Drawing.Size(281, 331);
            this.treeViewAdv1.Style = Syncfusion.Windows.Forms.Tools.TreeStyle.Metro;
            this.treeViewAdv1.TabIndex = 4;
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
            // imageList1
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.imageList1, "ImageList1", 40);
#else
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
#endif
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.png");
            this.imageList1.Images.SetKeyName(1, "2.png");
            this.imageList1.Images.SetKeyName(2, "3.png");
            this.imageList1.Images.SetKeyName(3, "4.png");
            this.imageList1.Images.SetKeyName(4, "5.png");
            this.imageList1.Images.SetKeyName(5, "6.png");
            this.imageList1.Images.SetKeyName(6, "7.png");
            this.imageList1.Images.SetKeyName(7, "8.png");
            this.imageList1.Images.SetKeyName(8, "9.png");
            this.imageList1.Images.SetKeyName(9, "10.png");
            this.imageList1.Images.SetKeyName(10, "11.png");
            this.imageList1.Images.SetKeyName(11, "12.png");
            this.imageList1.Images.SetKeyName(12, "13.png");
            this.imageList1.Images.SetKeyName(13, "14.png");
            this.imageList1.Images.SetKeyName(14, "15.png");
            this.imageList1.Images.SetKeyName(15, "Autocomplete.png");
            this.imageList1.Images.SetKeyName(16, "ButtonAdv.png");
            this.imageList1.Images.SetKeyName(17, "calculator.png");
            this.imageList1.Images.SetKeyName(18, "check box.png");
            this.imageList1.Images.SetKeyName(19, "ColorPicker.png");
            this.imageList1.Images.SetKeyName(20, "ContextMenuStrip.png");
            this.imageList1.Images.SetKeyName(21, "DateTimepicker.png");
            this.imageList1.Images.SetKeyName(22, "DigitalGauge.png");
            this.imageList1.Images.SetKeyName(23, "DockingManager.png");
            this.imageList1.Images.SetKeyName(24, "FontComboBox.png");
            this.imageList1.Images.SetKeyName(25, "FontListBox.png");
            this.imageList1.Images.SetKeyName(26, "GridControl.png");
            this.imageList1.Images.SetKeyName(27, "HTML UI.png");
            this.imageList1.Images.SetKeyName(28, "LinearGauge.png");
            this.imageList1.Images.SetKeyName(29, "MulticolumnTreeView.png");
            this.imageList1.Images.SetKeyName(30, "Numeric TextBox.png");
            this.imageList1.Images.SetKeyName(31, "RadialMenu.png");
            this.imageList1.Images.SetKeyName(32, "Rating.png");
            this.imageList1.Images.SetKeyName(33, "RibbonControlAdv.png");
            this.imageList1.Images.SetKeyName(34, "SplashControl.png");
            this.imageList1.Images.SetKeyName(35, "StatusBarAdv.png");
            this.imageList1.Images.SetKeyName(36, "TreeView.png");
            this.imageList1.Images.SetKeyName(37, "Wizard.png");
            this.imageList1.Images.SetKeyName(38, "XPTaskBar.png");
            this.imageList1.Images.SetKeyName(39, "XPToolBar.png");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dwTaskListView);
            this.panel2.Controls.Add(this.errorlistToolBar);
            this.panel2.Location = new System.Drawing.Point(1, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 40);
            this.panel2.TabIndex = 6;
            // 
            // dwTaskListView
            // 
            this.dwTaskListView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dwTaskListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dwTaskListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.dwTaskListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dwTaskListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.dwTaskListView.FullRowSelect = true;
            this.dwTaskListView.GridLines = true;
            listViewItem1.Checked = true;
            listViewItem1.StateImageIndex = 1;
            this.dwTaskListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.dwTaskListView.Location = new System.Drawing.Point(0, 25);
            this.dwTaskListView.MultiSelect = false;
            this.dwTaskListView.Name = "dwTaskListView";
            this.dwTaskListView.Size = new System.Drawing.Size(882, 15);
            this.dwTaskListView.TabIndex = 29;
            this.dwTaskListView.UseCompatibleStateImageBehavior = false;
            this.dwTaskListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "!";
            this.columnHeader1.Width = 20;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.Width = 22;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description";
            this.columnHeader3.Width = 1000;
            // 
            // errorlistToolBar
            // 
            this.errorlistToolBar.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.errorlistToolBar.Bar.BarName = "";
            this.errorlistToolBar.Bar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem14,
            this.barItem15,
            this.barItem16});
            this.errorlistToolBar.Bar.Manager = null;
            this.errorlistToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.errorlistToolBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.errorlistToolBar.Location = new System.Drawing.Point(0, 0);
            this.errorlistToolBar.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.errorlistToolBar.Name = "errorlistToolBar";
            this.errorlistToolBar.Size = new System.Drawing.Size(882, 25);
            this.errorlistToolBar.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.errorlistToolBar.TabIndex = 1;
            // 
            // barItem14
            // 
            this.barItem14.BarName = "barItem14";
            this.barItem14.Checked = true;
            this.barItem14.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.barItem14.ID = "Errors";
            this.barItem14.ShowToolTipInPopUp = false;
            this.barItem14.SizeToFit = true;
            this.barItem14.Text = "Errors";
            // 
            // barItem15
            // 
            this.barItem15.BarName = "barItem15";
            this.barItem15.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.barItem15.ID = "Warnings";
            this.barItem15.ShowToolTipInPopUp = false;
            this.barItem15.SizeToFit = true;
            this.barItem15.Text = "Warnings";
            // 
            // barItem16
            // 
            this.barItem16.BarName = "barItem16";
            this.barItem16.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.barItem16.ID = "Messages";
            this.barItem16.ShowToolTipInPopUp = false;
            this.barItem16.SizeToFit = true;
            this.barItem16.Text = "Messages";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Location = new System.Drawing.Point(1, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(882, 40);
            this.panel3.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.listBox1.Items.AddRange(new object[] {
            "Find all \"BarManager\", SubFolders, Find Results 2, \"Current Project\".."});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(882, 40);
            this.listBox1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.outputTextBox);
            this.panel4.Controls.Add(this.outputTypeComboBox);
            this.panel4.Location = new System.Drawing.Point(1, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(882, 40);
            this.panel4.TabIndex = 12;
            // 
            // outputTextBox
            // 
            this.outputTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.outputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.outputTextBox.Location = new System.Drawing.Point(0, 21);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(882, 19);
            this.outputTextBox.TabIndex = 4;
            this.outputTextBox.Text = "\'VSDemo.exe\': Loaded \'c:\\suite showcase\\tools\\vsdemo\\bin\\debug\\syncfusion.edit.dl" +
    "l\', Symbols loaded.";
            // 
            // outputTypeComboBox
            // 
            this.outputTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.outputTypeComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.outputTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.outputTypeComboBox.Location = new System.Drawing.Point(0, 0);
            this.outputTypeComboBox.Name = "outputTypeComboBox";
            this.outputTypeComboBox.Size = new System.Drawing.Size(882, 21);
            this.outputTypeComboBox.TabIndex = 3;
            this.outputTypeComboBox.Text = "Debug";
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(1, 26);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(254, 331);
            this.panel5.TabIndex = 17;
            // 
            // mainFrameBarManager1
            // 
#if !NETCORE
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
#endif
            this.mainFrameBarManager1.Bars.Add(this.bar1);
            this.mainFrameBarManager1.Categories.Add("File");
            this.mainFrameBarManager1.Categories.Add("Icons");
            this.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.MetroForm";
            this.mainFrameBarManager1.EnableMenuMerge = true;
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem4,
            this.barItem5,
            this.barItem9});
            this.mainFrameBarManager1.MetroBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.mainFrameBarManager1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(191)))));
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.mainFrameBarManager1.UseBackwardCompatiblity = false;
            // 
            // bar1
            // 
            this.bar1.BarName = "File";
            this.bar1.Caption = "File";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem2});
            this.bar1.Manager = this.mainFrameBarManager1;
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.CategoryIndex = 0;
            this.barItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem1.ID = "&FILE";
            this.barItem1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(191)))));
            this.barItem1.ShowToolTipInPopUp = false;
            this.barItem1.SizeToFit = true;
            this.barItem1.Text = "&File";
            this.barItem1.WrapLength = 20;
            // 
            // barItem2
            // 
            this.barItem2.BarName = "barItem2";
            this.barItem2.CategoryIndex = 0;
            this.barItem2.ID = "EDIT";
            this.barItem2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(191)))));
            this.barItem2.ShowToolTipInPopUp = false;
            this.barItem2.SizeToFit = true;
            this.barItem2.Text = "&Edit";
            this.barItem2.WrapLength = 20;
            // 
            // barItem3
            // 
            this.barItem3.BarName = "barItem3";
            this.barItem3.CategoryIndex = 0;
            this.barItem3.ID = "LAYOUTS";
            this.barItem3.ShowToolTipInPopUp = false;
            this.barItem3.SizeToFit = true;
            this.barItem3.Text = "&Team";
            // 
            // barItem4
            // 
            this.barItem4.BarName = "barItem4";
            this.barItem4.CategoryIndex = 0;
            this.barItem4.ID = "WINDOW";
            this.barItem4.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(191)))));
            this.barItem4.ShowToolTipInPopUp = false;
            this.barItem4.SizeToFit = true;
            this.barItem4.Text = "&Window";
            this.barItem4.WrapLength = 20;
            // 
            // barItem5
            // 
            this.barItem5.BarName = "barItem5";
            this.barItem5.CategoryIndex = 0;
            this.barItem5.ID = "HELP";
            this.barItem5.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(191)))));
            this.barItem5.ShowToolTipInPopUp = false;
            this.barItem5.SizeToFit = true;
            this.barItem5.Text = "&Help";
            this.barItem5.WrapLength = 20;
            // 
            // barItem9
            // 
            this.barItem9.BarName = "barItem9";
            this.barItem9.CategoryIndex = 1;
            this.barItem9.ID = "Save All";
            this.barItem9.ShowToolTipInPopUp = false;
            this.barItem9.SizeToFit = true;
            this.barItem9.Text = "Save All";
            // 
            // barItem7
            // 
            this.barItem7.BarName = "barItem7";
            this.barItem7.CategoryIndex = 1;
            this.barItem7.ID = "Open";
            this.barItem7.ShowToolTipInPopUp = false;
            this.barItem7.SizeToFit = true;
            this.barItem7.Text = "Open";
            // 
            // barItem8
            // 
            this.barItem8.BarName = "barItem8";
            this.barItem8.CategoryIndex = 1;
            this.barItem8.ID = "Save";
            this.barItem8.ShowToolTipInPopUp = false;
            this.barItem8.SizeToFit = true;
            this.barItem8.Text = "Save";
            // 
            // barItem10
            // 
            this.barItem10.BarName = "barItem10";
            this.barItem10.CategoryIndex = 1;
            this.barItem10.ID = "Start";
            this.barItem10.ShowToolTipInPopUp = false;
            this.barItem10.SizeToFit = true;
            this.barItem10.Text = "Start";
            // 
            // comboBoxBarItem1
            // 
            this.comboBoxBarItem1.BarName = "comboBoxBarItem1";
            this.comboBoxBarItem1.CategoryIndex = 1;
            this.comboBoxBarItem1.ID = "Debug";
            this.comboBoxBarItem1.ShowToolTipInPopUp = false;
            this.comboBoxBarItem1.SizeToFit = true;
            this.comboBoxBarItem1.Text = "Debug";
           
            // 
            // editControl1
            // 
            this.editControl1.CodeSnipptSize = new System.Drawing.Size(100, 100);
            this.editControl1.Configurator = config1;
            this.editControl1.ContextChoiceForeColor = System.Drawing.SystemColors.InfoText;
            this.editControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editControl1.IndicatorMarginBackColor = System.Drawing.Color.Empty;
            this.editControl1.LineNumbersFont = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editControl1.Location = new System.Drawing.Point(0, 0);
            this.editControl1.Name = "editControl1";
            this.editControl1.RenderRightToLeft = false;
            this.editControl1.ScrollPosition = new System.Drawing.Point(0, 0);
            this.editControl1.ScrollVisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;
            this.editControl1.ShowHorizontalSplitters = false;
            this.editControl1.ShowLineNumbers = false;
            this.editControl1.ShowOutliningCollapsers = false;
            this.editControl1.ShowSelectionMargin = false;
            this.editControl1.ShowVerticalSplitters = false;
            this.editControl1.Size = new System.Drawing.Size(254, 147);
            this.editControl1.StatusBarSettings.CoordsPanel.Width = 150;
            this.editControl1.StatusBarSettings.EncodingPanel.Width = 100;
            this.editControl1.StatusBarSettings.FileNamePanel.Width = 100;
            this.editControl1.StatusBarSettings.InsertPanel.Width = 33;
            this.editControl1.StatusBarSettings.Offcie2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue;
            this.editControl1.StatusBarSettings.Offcie2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Blue;
            this.editControl1.StatusBarSettings.StatusPanel.Width = 70;
            this.editControl1.StatusBarSettings.TextPanel.Width = 214;
            this.editControl1.StatusBarSettings.VisualStyle = Syncfusion.Windows.Forms.Tools.Controls.StatusBar.VisualStyle.Default;
            this.editControl1.TabIndex = 20;
            this.editControl1.Text = "editControl1\n\n\n\n\n";
            this.editControl1.UseXPStyleBorder = true;
            this.editControl1.VisualColumn = 1;
            this.editControl1.VScrollMode = Syncfusion.Windows.Forms.Edit.ScrollMode.Immediate;
            // 
            // editControl2
            // 
            this.editControl2.ChangedLinesMarkingLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(98)))));
            this.editControl2.CodeSnipptSize = new System.Drawing.Size(100, 100);
            this.editControl2.Configurator = config2;
            this.editControl2.ContextChoiceBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.editControl2.ContextChoiceBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(166)))), ((int)(((byte)(50)))));
            this.editControl2.ContextChoiceForeColor = System.Drawing.SystemColors.InfoText;
            this.editControl2.ContextPromptBackgroundBrush = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            this.editControl2.ContextTooltipBackgroundBrush = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(236))))));
            this.editControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editControl2.IndicatorMarginBackColor = System.Drawing.Color.Empty;
            this.editControl2.LineNumbersColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.editControl2.LineNumbersFont = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editControl2.Location = new System.Drawing.Point(0, 0);
            this.editControl2.MarkChangedLines = true;
            this.editControl2.Name = "editControl2";
            this.editControl2.RenderRightToLeft = false;
            this.editControl2.ScrollPosition = new System.Drawing.Point(0, 0);
            this.editControl2.ScrollVisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;
            this.editControl2.SelectionTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.editControl2.ShowHorizontalSplitters = false;
            this.editControl2.ShowLineNumbers = false;
            this.editControl2.ShowOutliningCollapsers = false;
            this.editControl2.ShowSelectionMargin = false;
            this.editControl2.ShowVerticalSplitters = false;
            this.editControl2.Size = new System.Drawing.Size(254, 147);
            this.editControl2.StatusBarSettings.CoordsPanel.Width = 150;
            this.editControl2.StatusBarSettings.EncodingPanel.Width = 100;
            this.editControl2.StatusBarSettings.FileNamePanel.Width = 100;
            this.editControl2.StatusBarSettings.InsertPanel.Width = 33;
            this.editControl2.StatusBarSettings.Offcie2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue;
            this.editControl2.StatusBarSettings.Offcie2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Blue;
            this.editControl2.StatusBarSettings.StatusPanel.Width = 70;
            this.editControl2.StatusBarSettings.TextPanel.Width = 214;
            this.editControl2.StatusBarSettings.VisualStyle = Syncfusion.Windows.Forms.Tools.Controls.StatusBar.VisualStyle.Default;
            this.editControl2.TabIndex = 21;
            this.editControl2.Text = "editControl1\n\n\n\n\n";
            this.editControl2.UseXPStyleBorder = true;
            this.editControl2.VisualColumn = 1;
            this.editControl2.VScrollMode = Syncfusion.Windows.Forms.Edit.ScrollMode.Immediate;
            // 
            // dockingImageList
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.dockingImageList, "DockingImageList", 80);
#else
            this.dockingImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("dockingImageList.ImageStream")));
#endif
            this.dockingImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.dockingImageList.Images.SetKeyName(0, "");
            this.dockingImageList.Images.SetKeyName(1, "");
            this.dockingImageList.Images.SetKeyName(2, "");
            this.dockingImageList.Images.SetKeyName(3, "");
            this.dockingImageList.Images.SetKeyName(4, "");
            this.dockingImageList.Images.SetKeyName(5, "");
            this.dockingImageList.Images.SetKeyName(6, "Refresh.png");
            this.dockingImageList.Images.SetKeyName(7, "");
            this.dockingImageList.Images.SetKeyName(8, "");
            this.dockingImageList.Images.SetKeyName(9, "");
            this.dockingImageList.Images.SetKeyName(10, "");
            this.dockingImageList.Images.SetKeyName(11, "");
            this.dockingImageList.Images.SetKeyName(12, "");
            this.dockingImageList.Images.SetKeyName(13, "");
            this.dockingImageList.Images.SetKeyName(14, "");
            this.dockingImageList.Images.SetKeyName(15, "");
            this.dockingImageList.Images.SetKeyName(16, "");
            this.dockingImageList.Images.SetKeyName(17, "");
            this.dockingImageList.Images.SetKeyName(18, "");
            this.dockingImageList.Images.SetKeyName(19, "");
            this.dockingImageList.Images.SetKeyName(20, "");
            this.dockingImageList.Images.SetKeyName(21, "");
            this.dockingImageList.Images.SetKeyName(22, "");
            this.dockingImageList.Images.SetKeyName(23, "");
            this.dockingImageList.Images.SetKeyName(24, "");
            this.dockingImageList.Images.SetKeyName(25, "");
            this.dockingImageList.Images.SetKeyName(26, "");
            this.dockingImageList.Images.SetKeyName(27, "");
            this.dockingImageList.Images.SetKeyName(28, "");
            this.dockingImageList.Images.SetKeyName(29, "");
            this.dockingImageList.Images.SetKeyName(30, "");
            this.dockingImageList.Images.SetKeyName(31, "01.png");
            this.dockingImageList.Images.SetKeyName(32, "10.png");
            this.dockingImageList.Images.SetKeyName(33, "");
            this.dockingImageList.Images.SetKeyName(34, "");
            this.dockingImageList.Images.SetKeyName(35, "");
            this.dockingImageList.Images.SetKeyName(36, "");
            this.dockingImageList.Images.SetKeyName(37, "");
            this.dockingImageList.Images.SetKeyName(38, "");
            this.dockingImageList.Images.SetKeyName(39, "");
            this.dockingImageList.Images.SetKeyName(40, "");
            this.dockingImageList.Images.SetKeyName(41, "");
            this.dockingImageList.Images.SetKeyName(42, "");
            this.dockingImageList.Images.SetKeyName(43, "");
            this.dockingImageList.Images.SetKeyName(44, "");
            this.dockingImageList.Images.SetKeyName(45, "");
            this.dockingImageList.Images.SetKeyName(46, "");
            this.dockingImageList.Images.SetKeyName(47, "");
            this.dockingImageList.Images.SetKeyName(48, "");
            this.dockingImageList.Images.SetKeyName(49, "");
            this.dockingImageList.Images.SetKeyName(50, "");
            this.dockingImageList.Images.SetKeyName(51, "");
            this.dockingImageList.Images.SetKeyName(52, "");
            this.dockingImageList.Images.SetKeyName(53, "");
            this.dockingImageList.Images.SetKeyName(54, "");
            this.dockingImageList.Images.SetKeyName(55, "");
            this.dockingImageList.Images.SetKeyName(56, "");
            this.dockingImageList.Images.SetKeyName(57, "");
            this.dockingImageList.Images.SetKeyName(58, "");
            this.dockingImageList.Images.SetKeyName(59, "");
            this.dockingImageList.Images.SetKeyName(60, "");
            this.dockingImageList.Images.SetKeyName(61, "02.png");
            this.dockingImageList.Images.SetKeyName(62, "03.png");
            this.dockingImageList.Images.SetKeyName(63, "05.png");
            this.dockingImageList.Images.SetKeyName(64, "");
            this.dockingImageList.Images.SetKeyName(65, "");
            this.dockingImageList.Images.SetKeyName(66, "03.png");
            this.dockingImageList.Images.SetKeyName(67, "03.png");
            this.dockingImageList.Images.SetKeyName(68, "");
            this.dockingImageList.Images.SetKeyName(69, "");
            this.dockingImageList.Images.SetKeyName(70, "");
            this.dockingImageList.Images.SetKeyName(71, "");
            this.dockingImageList.Images.SetKeyName(72, "");
            this.dockingImageList.Images.SetKeyName(73, "");
            this.dockingImageList.Images.SetKeyName(74, "");
            this.dockingImageList.Images.SetKeyName(75, "");
            this.dockingImageList.Images.SetKeyName(76, "");
            this.dockingImageList.Images.SetKeyName(77, "");
            this.dockingImageList.Images.SetKeyName(78, "");
            this.dockingImageList.Images.SetKeyName(79, "02.png");
            // 
            // imageList2
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.imageList2, "ImageList2", 21);
#else
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
#endif
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "1.png");
            this.imageList2.Images.SetKeyName(1, "2.png");
            this.imageList2.Images.SetKeyName(2, "3.png");
            this.imageList2.Images.SetKeyName(3, "4.png");
            this.imageList2.Images.SetKeyName(4, "5.png");
            this.imageList2.Images.SetKeyName(5, "6.png");
            this.imageList2.Images.SetKeyName(6, "7.png");
            this.imageList2.Images.SetKeyName(7, "8.png");
            this.imageList2.Images.SetKeyName(8, "9.png");
            this.imageList2.Images.SetKeyName(9, "10.png");
            this.imageList2.Images.SetKeyName(10, "11.png");
            this.imageList2.Images.SetKeyName(11, "12.png");
            this.imageList2.Images.SetKeyName(12, "13.png");
            this.imageList2.Images.SetKeyName(13, "14.png");
            this.imageList2.Images.SetKeyName(14, "15.png");
            this.imageList2.Images.SetKeyName(15, "16.png");
            this.imageList2.Images.SetKeyName(16, "17.png");
            this.imageList2.Images.SetKeyName(17, "18.png");
            this.imageList2.Images.SetKeyName(18, "19.png");
            this.imageList2.Images.SetKeyName(19, "20.png");
            this.imageList2.Images.SetKeyName(20, "21.png");
            // 
            // imageList3
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.imageList3, "ImageList3", 116);
#else
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
#endif
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "Window-New.png");
            this.imageList3.Images.SetKeyName(1, "");
            this.imageList3.Images.SetKeyName(2, "02.png");
            this.imageList3.Images.SetKeyName(3, "");
            this.imageList3.Images.SetKeyName(4, "");
            this.imageList3.Images.SetKeyName(5, "01.png");
            this.imageList3.Images.SetKeyName(6, "");
            this.imageList3.Images.SetKeyName(7, "");
            this.imageList3.Images.SetKeyName(8, "");
            this.imageList3.Images.SetKeyName(9, "");
            this.imageList3.Images.SetKeyName(10, "");
            this.imageList3.Images.SetKeyName(11, "");
            this.imageList3.Images.SetKeyName(12, "Cut.png");
            this.imageList3.Images.SetKeyName(13, "");
            this.imageList3.Images.SetKeyName(14, "");
            this.imageList3.Images.SetKeyName(15, "");
            this.imageList3.Images.SetKeyName(16, "");
            this.imageList3.Images.SetKeyName(17, "FindAll.png");
            this.imageList3.Images.SetKeyName(18, "Play.png");
            this.imageList3.Images.SetKeyName(19, "");
            this.imageList3.Images.SetKeyName(20, "");
            this.imageList3.Images.SetKeyName(21, "");
            this.imageList3.Images.SetKeyName(22, "");
            this.imageList3.Images.SetKeyName(23, "");
            this.imageList3.Images.SetKeyName(24, "");
            this.imageList3.Images.SetKeyName(25, "");
            this.imageList3.Images.SetKeyName(26, "");
            this.imageList3.Images.SetKeyName(27, "Properties.png");
            this.imageList3.Images.SetKeyName(28, "Redo.png");
            this.imageList3.Images.SetKeyName(29, "05.png");
            this.imageList3.Images.SetKeyName(30, "04.png");
            this.imageList3.Images.SetKeyName(31, "06.png");
            this.imageList3.Images.SetKeyName(32, "Undo.png");
            this.imageList3.Images.SetKeyName(33, "Tools.png");
            this.imageList3.Images.SetKeyName(34, "");
            this.imageList3.Images.SetKeyName(35, "");
            this.imageList3.Images.SetKeyName(36, "");
            this.imageList3.Images.SetKeyName(37, "");
            this.imageList3.Images.SetKeyName(38, "");
            this.imageList3.Images.SetKeyName(39, "");
            this.imageList3.Images.SetKeyName(40, "");
            this.imageList3.Images.SetKeyName(41, "");
            this.imageList3.Images.SetKeyName(42, "");
            this.imageList3.Images.SetKeyName(43, "");
            this.imageList3.Images.SetKeyName(44, "");
            this.imageList3.Images.SetKeyName(45, "");
            this.imageList3.Images.SetKeyName(46, "03.png");
            this.imageList3.Images.SetKeyName(47, "AddToWatch.png");
            this.imageList3.Images.SetKeyName(48, "Cut.png");
            this.imageList3.Images.SetKeyName(49, "");
            this.imageList3.Images.SetKeyName(50, "");
            this.imageList3.Images.SetKeyName(51, "");
            this.imageList3.Images.SetKeyName(52, "");
            this.imageList3.Images.SetKeyName(53, "");
            this.imageList3.Images.SetKeyName(54, "");
            this.imageList3.Images.SetKeyName(55, "");
            this.imageList3.Images.SetKeyName(56, "AddItem.png");
            this.imageList3.Images.SetKeyName(57, "");
            this.imageList3.Images.SetKeyName(58, "");
            this.imageList3.Images.SetKeyName(59, "");
            this.imageList3.Images.SetKeyName(60, "");
            this.imageList3.Images.SetKeyName(61, "");
            this.imageList3.Images.SetKeyName(62, "07.png");
            this.imageList3.Images.SetKeyName(63, "New Search Folder.png");
            this.imageList3.Images.SetKeyName(64, "");
            this.imageList3.Images.SetKeyName(65, "");
            this.imageList3.Images.SetKeyName(66, "");
            this.imageList3.Images.SetKeyName(67, "");
            this.imageList3.Images.SetKeyName(68, "");
            this.imageList3.Images.SetKeyName(69, "");
            this.imageList3.Images.SetKeyName(70, "");
            this.imageList3.Images.SetKeyName(71, "");
            this.imageList3.Images.SetKeyName(72, "");
            this.imageList3.Images.SetKeyName(73, "");
            this.imageList3.Images.SetKeyName(74, "");
            this.imageList3.Images.SetKeyName(75, "");
            this.imageList3.Images.SetKeyName(76, "");
            this.imageList3.Images.SetKeyName(77, "");
            this.imageList3.Images.SetKeyName(78, "");
            this.imageList3.Images.SetKeyName(79, "");
            this.imageList3.Images.SetKeyName(80, "Play.png");
            this.imageList3.Images.SetKeyName(81, "");
            this.imageList3.Images.SetKeyName(82, "");
            this.imageList3.Images.SetKeyName(83, "");
            this.imageList3.Images.SetKeyName(84, "");
            this.imageList3.Images.SetKeyName(85, "");
            this.imageList3.Images.SetKeyName(86, "");
            this.imageList3.Images.SetKeyName(87, "");
            this.imageList3.Images.SetKeyName(88, "");
            this.imageList3.Images.SetKeyName(89, "");
            this.imageList3.Images.SetKeyName(90, "News View.png");
            this.imageList3.Images.SetKeyName(91, "");
            this.imageList3.Images.SetKeyName(92, "panels_new3_close.ico");
            this.imageList3.Images.SetKeyName(93, "Next.png");
            this.imageList3.Images.SetKeyName(94, "1.png");
            this.imageList3.Images.SetKeyName(95, "2.png");
            this.imageList3.Images.SetKeyName(96, "3-corrected.png");
            this.imageList3.Images.SetKeyName(97, "4.png");
            this.imageList3.Images.SetKeyName(98, "5.png");
            this.imageList3.Images.SetKeyName(99, "6.png");
            this.imageList3.Images.SetKeyName(100, "11.png");
            this.imageList3.Images.SetKeyName(101, "12.png");
            this.imageList3.Images.SetKeyName(102, "bookmark.png");
            this.imageList3.Images.SetKeyName(103, "bookmark_left.png");
            this.imageList3.Images.SetKeyName(104, "bookmark_right.png");
            this.imageList3.Images.SetKeyName(105, "combo icon.png");
            this.imageList3.Images.SetKeyName(106, "connect.png");
            this.imageList3.Images.SetKeyName(107, "down.png");
            this.imageList3.Images.SetKeyName(108, "left undo.png");
            this.imageList3.Images.SetKeyName(109, "m1.png");
            this.imageList3.Images.SetKeyName(110, "msg  unread.png");
            this.imageList3.Images.SetKeyName(111, "msg.png");
            this.imageList3.Images.SetKeyName(112, "right undo.png");
            this.imageList3.Images.SetKeyName(113, "run.png");
            this.imageList3.Images.SetKeyName(114, "sub.png");
            this.imageList3.Images.SetKeyName(115, "unmark.png");
            // 
            // imageList4
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.imageList4, "ImageList4", 40);
#else
            this.imageList4.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList4.ImageStream")));
#endif
            this.imageList4.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList4.Images.SetKeyName(0, "");
            this.imageList4.Images.SetKeyName(1, "13.png");
            this.imageList4.Images.SetKeyName(2, "Next.png");
            this.imageList4.Images.SetKeyName(3, "");
            this.imageList4.Images.SetKeyName(4, "15.png");
            this.imageList4.Images.SetKeyName(5, "Before.png");
            this.imageList4.Images.SetKeyName(6, "");
            this.imageList4.Images.SetKeyName(7, "14.png");
            this.imageList4.Images.SetKeyName(8, "16.png");
            this.imageList4.Images.SetKeyName(9, "");
            this.imageList4.Images.SetKeyName(10, "11.png");
            this.imageList4.Images.SetKeyName(11, "Copy.png");
            this.imageList4.Images.SetKeyName(12, "");
            this.imageList4.Images.SetKeyName(13, "");
            this.imageList4.Images.SetKeyName(14, "");
            this.imageList4.Images.SetKeyName(15, "");
            this.imageList4.Images.SetKeyName(16, "");
            this.imageList4.Images.SetKeyName(17, "");
            this.imageList4.Images.SetKeyName(18, "10.png");
            this.imageList4.Images.SetKeyName(19, "PreviousBookMark.png");
            this.imageList4.Images.SetKeyName(20, "NextBookMark.png");
            this.imageList4.Images.SetKeyName(21, "");
            this.imageList4.Images.SetKeyName(22, "");
            this.imageList4.Images.SetKeyName(23, "");
            this.imageList4.Images.SetKeyName(24, "10.png");
            this.imageList4.Images.SetKeyName(25, "Paste.png");
            this.imageList4.Images.SetKeyName(26, "");
            this.imageList4.Images.SetKeyName(27, "09.png");
            this.imageList4.Images.SetKeyName(28, "");
            this.imageList4.Images.SetKeyName(29, "");
            this.imageList4.Images.SetKeyName(30, "");
            this.imageList4.Images.SetKeyName(31, "");
            this.imageList4.Images.SetKeyName(32, "");
            this.imageList4.Images.SetKeyName(33, "12.png");
            this.imageList4.Images.SetKeyName(34, "08.png");
            this.imageList4.Images.SetKeyName(35, "Copy.png");
            this.imageList4.Images.SetKeyName(36, "");
            this.imageList4.Images.SetKeyName(37, "10.png");
            this.imageList4.Images.SetKeyName(38, "10.png");
            this.imageList4.Images.SetKeyName(39, "Cut.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.CaptionBarHeight = 35;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(884, 486);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Visual Studio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editControl2)).EndInit();
            this.ResumeLayout(false);

        }

#endregion

        private Syncfusion.Windows.Forms.Tools.DockingManager dockingManager1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem barItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem barItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem barItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem barItem5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private SolutionExplorerView panel5;
        private Syncfusion.Windows.Forms.Edit.EditControl editControl1;
        private Syncfusion.Windows.Forms.Edit.EditControl editControl2;

        private System.Windows.Forms.ImageList dockingImageList;
        public Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar2;
        
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem7;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem8;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem9;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem10;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem comboBoxBarItem1;
       
        private Syncfusion.Windows.Forms.Tools.TreeViewAdv treeViewAdv1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView dwTaskListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        public Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar errorlistToolBar;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem14;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem15;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem16;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.ComboBox outputTypeComboBox;
        private System.Windows.Forms.ImageList imageList2;
        internal System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.ImageList imageList4;
    }
}

