#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace VSDemo
{
	/// <summary>
	/// Summary description for SolutionExplorer.
	/// </summary>
	public class SolutionExplorerView : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Panel panelSolutionExplorer;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem viewCodeBarItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem viewDesignerBarItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem refreshBarItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem showAllFilesBarItem;
		private System.Windows.Forms.ImageList dockingImageList;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem propertiesBarItem;
		public Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar solutionExplorerToolBar;
        protected Syncfusion.Windows.Forms.ScrollersFrame scrollersFrame1;
        private Syncfusion.Windows.Forms.Tools.TreeViewAdv treeViewAdv1;
		private System.ComponentModel.IContainer components;

		public SolutionExplorerView()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call

		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv2 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv3 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv4 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv5 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv6 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv7 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv8 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv9 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolutionExplorerView));
            this.panelSolutionExplorer = new System.Windows.Forms.Panel();
            this.treeViewAdv1 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.dockingImageList = new System.Windows.Forms.ImageList(this.components);
            this.solutionExplorerToolBar = new Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar();
            this.viewCodeBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.viewDesignerBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.refreshBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.showAllFilesBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.propertiesBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.scrollersFrame1 = new Syncfusion.Windows.Forms.ScrollersFrame(this.components);
            this.panelSolutionExplorer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSolutionExplorer
            // 
            this.panelSolutionExplorer.Controls.Add(this.treeViewAdv1);
            this.panelSolutionExplorer.Controls.Add(this.solutionExplorerToolBar);
            this.panelSolutionExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSolutionExplorer.Location = new System.Drawing.Point(0, 0);
            this.panelSolutionExplorer.Name = "panelSolutionExplorer";
            this.panelSolutionExplorer.Size = new System.Drawing.Size(192, 395);
            this.panelSolutionExplorer.TabIndex = 0;
            // 
            // treeViewAdv1
            // 
            this.treeViewAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.treeViewAdv1.CanSelectDisabledNode = false;
            this.treeViewAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewAdv1.DpiAware = false;
            // 
            // 
            // 
            this.treeViewAdv1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv1.HelpTextControl.Name = "helpText";
            this.treeViewAdv1.HelpTextControl.Size = new System.Drawing.Size(49, 15);
            this.treeViewAdv1.HelpTextControl.TabIndex = 0;
            this.treeViewAdv1.HelpTextControl.Text = "help text";
            this.treeViewAdv1.LeftImageList = this.dockingImageList;
            this.treeViewAdv1.Location = new System.Drawing.Point(0, 25);
            this.treeViewAdv1.MetroColor = System.Drawing.Color.Black;
            this.treeViewAdv1.Name = "treeViewAdv1";
            treeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.LeftImageIndices = new int[] {
        31};
            treeNodeAdv1.MultiLine = true;
            treeNodeAdv1.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv1.ShowLine = true;
            treeNodeAdv1.Text = "Solution \'ConsoleApplication1\' (1 Project)";
            treeNodeAdv2.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.Expanded = true;
            treeNodeAdv2.LeftImageIndices = new int[] {
        79};
            treeNodeAdv2.MultiLine = true;
            treeNodeAdv3.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.Expanded = true;
            treeNodeAdv3.LeftImageIndices = new int[] {
        62};
            treeNodeAdv3.MultiLine = true;
            treeNodeAdv4.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.LeftImageIndices = new int[] {
        67};
            treeNodeAdv4.MultiLine = true;
            treeNodeAdv4.Optioned = true;
            treeNodeAdv4.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv4.ShowLine = true;
            treeNodeAdv4.Text = "System";
            treeNodeAdv5.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.LeftImageIndices = new int[] {
        67};
            treeNodeAdv5.MultiLine = true;
            treeNodeAdv5.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv5.ShowLine = true;
            treeNodeAdv5.Text = "System.Data";
            treeNodeAdv6.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.LeftImageIndices = new int[] {
        67};
            treeNodeAdv6.MultiLine = true;
            treeNodeAdv6.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv6.ShowLine = true;
            treeNodeAdv6.Text = "System.Windows.Forms";
            treeNodeAdv3.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv4,
            treeNodeAdv5,
            treeNodeAdv6});
            treeNodeAdv3.Optioned = true;
            treeNodeAdv3.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv3.ShowLine = true;
            treeNodeAdv3.Text = "References";
            treeNodeAdv7.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.LeftImageIndices = new int[] {
        64};
            treeNodeAdv7.MultiLine = true;
            treeNodeAdv7.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv7.ShowLine = true;
            treeNodeAdv7.Text = "App.ico";
            treeNodeAdv8.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.LeftImageIndices = new int[] {
        63};
            treeNodeAdv8.MultiLine = true;
            treeNodeAdv8.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv8.ShowLine = true;
            treeNodeAdv8.Text = "AssemblyInfo.cs";
            treeNodeAdv9.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.LeftImageIndices = new int[] {
        63};
            treeNodeAdv9.MultiLine = true;
            treeNodeAdv9.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv9.ShowLine = true;
            treeNodeAdv9.Text = "Class1.cs";
            treeNodeAdv2.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv3,
            treeNodeAdv7,
            treeNodeAdv8,
            treeNodeAdv9});
            treeNodeAdv2.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv2.ShowLine = true;
            treeNodeAdv2.Text = "ConsoleApplication";
            this.treeViewAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv1,
            treeNodeAdv2});
            this.treeViewAdv1.SelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Gray);
            this.treeViewAdv1.ShowFocusRect = false;
            this.treeViewAdv1.ShowLines = false;
            this.treeViewAdv1.ShowRootLines = false;
            this.treeViewAdv1.Size = new System.Drawing.Size(192, 370);
            this.treeViewAdv1.Style = Syncfusion.Windows.Forms.Tools.TreeStyle.Metro;
            this.treeViewAdv1.TabIndex = 3;
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
            // dockingImageList
            // 
            this.dockingImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("dockingImageList.ImageStream")));
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
            // solutionExplorerToolBar
            // 
            this.solutionExplorerToolBar.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.solutionExplorerToolBar.Bar.BarName = "";
            this.solutionExplorerToolBar.Bar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.viewCodeBarItem,
            this.viewDesignerBarItem,
            this.refreshBarItem,
            this.showAllFilesBarItem,
            this.propertiesBarItem});
            this.solutionExplorerToolBar.Bar.Manager = null;
            this.solutionExplorerToolBar.Bar.SeparatorIndices.AddRange(new int[] {
            2,
            4});
            this.solutionExplorerToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.solutionExplorerToolBar.Location = new System.Drawing.Point(0, 0);
            this.solutionExplorerToolBar.Name = "solutionExplorerToolBar";
            this.solutionExplorerToolBar.SeparatorIndices.AddRange(new int[] {
            2,
            4});
            this.solutionExplorerToolBar.Size = new System.Drawing.Size(192, 25);
            this.solutionExplorerToolBar.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.solutionExplorerToolBar.TabIndex = 0;
            // 
            // viewCodeBarItem
            // 
            this.viewCodeBarItem.BarName = "viewCodeBarItem";
            this.viewCodeBarItem.ID = "BarItem";
            this.viewCodeBarItem.ImageIndex = 4;
            this.viewCodeBarItem.ImageList = this.dockingImageList;
            this.viewCodeBarItem.ShowToolTipInPopUp = false;
            this.viewCodeBarItem.SizeToFit = true;
            // 
            // viewDesignerBarItem
            // 
            this.viewDesignerBarItem.BarName = "viewDesignerBarItem";
            this.viewDesignerBarItem.ID = "BarItem";
            this.viewDesignerBarItem.ImageIndex = 5;
            this.viewDesignerBarItem.ImageList = this.dockingImageList;
            this.viewDesignerBarItem.ShowToolTipInPopUp = false;
            this.viewDesignerBarItem.SizeToFit = true;
            // 
            // refreshBarItem
            // 
            this.refreshBarItem.BarName = "refreshBarItem";
            this.refreshBarItem.ID = "BarItem";
            this.refreshBarItem.ImageIndex = 6;
            this.refreshBarItem.ImageList = this.dockingImageList;
            this.refreshBarItem.ShowToolTipInPopUp = false;
            this.refreshBarItem.SizeToFit = true;
            // 
            // showAllFilesBarItem
            // 
            this.showAllFilesBarItem.BarName = "showAllFilesBarItem";
            this.showAllFilesBarItem.ID = "BarItem";
            this.showAllFilesBarItem.ImageIndex = 7;
            this.showAllFilesBarItem.ImageList = this.dockingImageList;
            this.showAllFilesBarItem.ShowToolTipInPopUp = false;
            this.showAllFilesBarItem.SizeToFit = true;
            this.showAllFilesBarItem.UpdateUIOnAppIdle = true;
            // 
            // propertiesBarItem
            // 
            this.propertiesBarItem.BarName = "propertiesBarItem";
            this.propertiesBarItem.ID = "BarItem";
            this.propertiesBarItem.ImageIndex = 8;
            this.propertiesBarItem.ImageList = this.dockingImageList;
            this.propertiesBarItem.ShowToolTipInPopUp = false;
            this.propertiesBarItem.SizeToFit = true;
            // 
            // scrollersFrame1
            // 
            this.scrollersFrame1.CustomRender = null;
            this.scrollersFrame1.MetroColorScheme = Syncfusion.Windows.Forms.MetroColorScheme.Managed;
            this.scrollersFrame1.SizeGripperVisibility = Syncfusion.Windows.Forms.SizeGripperVisibility.Auto;
            this.scrollersFrame1.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;
            // 
            // SolutionExplorerView
            // 
            this.Controls.Add(this.panelSolutionExplorer);
            this.Name = "SolutionExplorerView";
            this.Size = new System.Drawing.Size(192, 395);
            this.panelSolutionExplorer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
	}
}
