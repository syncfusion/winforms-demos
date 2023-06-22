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
	/// Summary description for ObjectBrowser.
	/// </summary>
	public class ObjectBrowserView : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Panel panel1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem browseBarItem;
		public Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar objectBrowserToolBar;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem sortNameParentBarItem;
		private System.Windows.Forms.ImageList dockingImageList;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem sortTypeParentBarItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem backBarItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem forwardBarItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem findSymbolBarItem;
		private System.Windows.Forms.LinkLabel llObjBrowserBottom;
        private Syncfusion.Windows.Forms.ScrollersFrame scrollersFrame1;
		private System.ComponentModel.IContainer components;

		public ObjectBrowserView()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjectBrowserView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.llObjBrowserBottom = new System.Windows.Forms.LinkLabel();
            this.objectBrowserToolBar = new Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar();
            this.browseBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem();
            this.sortNameParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.dockingImageList = new System.Windows.Forms.ImageList(this.components);
            this.sortTypeParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.backBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.forwardBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.findSymbolBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.scrollersFrame1 = new Syncfusion.Windows.Forms.ScrollersFrame(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.browseBarItem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.llObjBrowserBottom);
            this.panel1.Controls.Add(this.objectBrowserToolBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 88);
            this.panel1.TabIndex = 0;
            // 
            // llObjBrowserBottom
            // 
            this.llObjBrowserBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.llObjBrowserBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llObjBrowserBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.llObjBrowserBottom.LinkArea = new System.Windows.Forms.LinkArea(25, 58);
            this.llObjBrowserBottom.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.llObjBrowserBottom.LinkColor = System.Drawing.Color.DarkGreen;
            this.llObjBrowserBottom.Location = new System.Drawing.Point(0, 28);
            this.llObjBrowserBottom.Name = "llObjBrowserBottom";
            this.llObjBrowserBottom.Size = new System.Drawing.Size(696, 60);
            this.llObjBrowserBottom.TabIndex = 1;
            this.llObjBrowserBottom.TabStop = true;
            this.llObjBrowserBottom.Text = "public class RichTextBox: System.Windows.Forms.RichTextBox";
            this.llObjBrowserBottom.UseCompatibleTextRendering = true;
            // 
            // objectBrowserToolBar
            // 
            this.objectBrowserToolBar.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.objectBrowserToolBar.Bar.BarName = "";
            this.objectBrowserToolBar.Bar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.browseBarItem,
            this.sortNameParentBarItem,
            this.sortTypeParentBarItem,
            this.backBarItem,
            this.forwardBarItem,
            this.findSymbolBarItem});
            this.objectBrowserToolBar.Bar.Manager = null;
            this.objectBrowserToolBar.Bar.SeparatorIndices.AddRange(new int[] {
            1,
            3});
            this.objectBrowserToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.objectBrowserToolBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.objectBrowserToolBar.Location = new System.Drawing.Point(0, 0);
            this.objectBrowserToolBar.Name = "objectBrowserToolBar";
            this.objectBrowserToolBar.SeparatorIndices.AddRange(new int[] {
            1,
            3});
            this.objectBrowserToolBar.Size = new System.Drawing.Size(696, 28);
            this.objectBrowserToolBar.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.objectBrowserToolBar.TabIndex = 0;
            // 
            // browseBarItem
            // 
            this.browseBarItem.BarName = "browseBarItem";
            this.browseBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.browseBarItem.ID = "Select ";
            this.browseBarItem.MinWidth = 100;
            this.browseBarItem.ShowToolTipInPopUp = false;
            this.browseBarItem.SizeToFit = true;
            this.browseBarItem.Text = "Select Component";
            // 
            // sortNameParentBarItem
            // 
            this.sortNameParentBarItem.BarName = "sortNameParentBarItem";
            this.sortNameParentBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.sortNameParentBarItem.ID = "BarItem";
            this.sortNameParentBarItem.ImageIndex = 26;
            this.sortNameParentBarItem.ImageList = this.dockingImageList;
            this.sortNameParentBarItem.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.sortNameParentBarItem.ParentStyle = Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItemStyle.DropDown;
            this.sortNameParentBarItem.ShowToolTipInPopUp = false;
            this.sortNameParentBarItem.SizeToFit = true;
            this.sortNameParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
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
            this.dockingImageList.Images.SetKeyName(6, "");
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
            this.dockingImageList.Images.SetKeyName(31, "");
            this.dockingImageList.Images.SetKeyName(32, "");
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
            this.dockingImageList.Images.SetKeyName(61, "");
            this.dockingImageList.Images.SetKeyName(62, "");
            this.dockingImageList.Images.SetKeyName(63, "");
            this.dockingImageList.Images.SetKeyName(64, "");
            this.dockingImageList.Images.SetKeyName(65, "");
            this.dockingImageList.Images.SetKeyName(66, "");
            this.dockingImageList.Images.SetKeyName(67, "");
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
            // 
            // sortTypeParentBarItem
            // 
            this.sortTypeParentBarItem.BarName = "sortTypeParentBarItem";
            this.sortTypeParentBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.sortTypeParentBarItem.ID = "BarItem";
            this.sortTypeParentBarItem.ImageIndex = 36;
            this.sortTypeParentBarItem.ImageList = this.dockingImageList;
            this.sortTypeParentBarItem.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.sortTypeParentBarItem.ShowToolTipInPopUp = false;
            this.sortTypeParentBarItem.SizeToFit = true;
            this.sortTypeParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // backBarItem
            // 
            this.backBarItem.BarName = "backBarItem";
            this.backBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.backBarItem.ID = "BarItem";
            this.backBarItem.ImageIndex = 39;
            this.backBarItem.ImageList = this.dockingImageList;
            this.backBarItem.ShowToolTipInPopUp = false;
            this.backBarItem.SizeToFit = true;
            // 
            // forwardBarItem
            // 
            this.forwardBarItem.BarName = "forwardBarItem";
            this.forwardBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.forwardBarItem.ID = "BarItem";
            this.forwardBarItem.ImageIndex = 40;
            this.forwardBarItem.ImageList = this.dockingImageList;
            this.forwardBarItem.ShowToolTipInPopUp = false;
            this.forwardBarItem.SizeToFit = true;
            // 
            // findSymbolBarItem
            // 
            this.findSymbolBarItem.BarName = "findSymbolBarItem";
            this.findSymbolBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.findSymbolBarItem.ID = "BarItem";
            this.findSymbolBarItem.ImageIndex = 41;
            this.findSymbolBarItem.ImageList = this.dockingImageList;
            this.findSymbolBarItem.ShowToolTipInPopUp = false;
            this.findSymbolBarItem.SizeToFit = true;
            // 
            // scrollersFrame1
            // 
            this.scrollersFrame1.AttachedTo = this.panel1;
            this.scrollersFrame1.CustomRender = null;
            this.scrollersFrame1.MetroColorScheme = Syncfusion.Windows.Forms.MetroColorScheme.Managed;
            this.scrollersFrame1.SizeGripperVisibility = Syncfusion.Windows.Forms.SizeGripperVisibility.Auto;
            this.scrollersFrame1.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;
            // 
            // ObjectBrowserView
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel1);
            this.Name = "ObjectBrowserView";
            this.Size = new System.Drawing.Size(696, 88);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.browseBarItem)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
	}
}
