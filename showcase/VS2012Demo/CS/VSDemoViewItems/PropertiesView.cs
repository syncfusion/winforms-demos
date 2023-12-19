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
	/// Summary description for Properties.
	/// </summary>
	public class PropertiesView : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.ImageList dockingImageList;
		private System.Windows.Forms.Panel panelProperties;
		public Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar propertiesToolBar;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem catergorizedBarItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem alphabeticBarItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem propertiesBarItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem eventBarItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem propertyPagesBarItem;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        protected Syncfusion.Windows.Forms.ScrollersFrame scrollersFrame1;
		private System.ComponentModel.IContainer components;

		public PropertiesView()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
            this.scrollersFrame1.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropertiesView));
            this.dockingImageList = new System.Windows.Forms.ImageList(this.components);
            this.panelProperties = new System.Windows.Forms.Panel();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.propertiesToolBar = new Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar();
            this.catergorizedBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.alphabeticBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.propertiesBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.eventBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.propertyPagesBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.scrollersFrame1 = new Syncfusion.Windows.Forms.ScrollersFrame(this.components);
            this.panelProperties.SuspendLayout();
            this.SuspendLayout();
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
            this.dockingImageList.Images.SetKeyName(28, "Winamp.png");
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
            // panelProperties
            // 
            this.panelProperties.Controls.Add(this.propertyGrid1);
            this.panelProperties.Controls.Add(this.propertiesToolBar);
            this.panelProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProperties.Location = new System.Drawing.Point(0, 0);
            this.panelProperties.Name = "panelProperties";
            this.panelProperties.Size = new System.Drawing.Size(216, 392);
            this.panelProperties.TabIndex = 0;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyGrid1.HelpVisible = false;
            this.propertyGrid1.LineColor = System.Drawing.SystemColors.Control;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 25);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.propertyGrid1;
            this.propertyGrid1.Size = new System.Drawing.Size(216, 367);
            this.propertyGrid1.TabIndex = 3;
            this.propertyGrid1.ToolbarVisible = false;
            // 
            // propertiesToolBar
            // 
            this.propertiesToolBar.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.propertiesToolBar.Bar.BarName = "";
            this.propertiesToolBar.Bar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.catergorizedBarItem,
            this.alphabeticBarItem,
            this.propertiesBarItem,
            this.eventBarItem,
            this.propertyPagesBarItem});
            this.propertiesToolBar.Bar.Manager = null;
            this.propertiesToolBar.Bar.SeparatorIndices.AddRange(new int[] {
            2,
            4});
            this.propertiesToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.propertiesToolBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertiesToolBar.Location = new System.Drawing.Point(0, 0);
            this.propertiesToolBar.Name = "propertiesToolBar";
            this.propertiesToolBar.SeparatorIndices.AddRange(new int[] {
            2,
            4});
            this.propertiesToolBar.Size = new System.Drawing.Size(216, 25);
            this.propertiesToolBar.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.propertiesToolBar.TabIndex = 0;
            // 
            // catergorizedBarItem
            // 
            this.catergorizedBarItem.BarName = "catergorizedBarItem";
            this.catergorizedBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catergorizedBarItem.ID = "BarItem";
            this.catergorizedBarItem.ImageIndex = 25;
            this.catergorizedBarItem.ImageList = this.dockingImageList;
            this.catergorizedBarItem.ShowToolTipInPopUp = false;
            this.catergorizedBarItem.SizeToFit = true;
            // 
            // alphabeticBarItem
            // 
            this.alphabeticBarItem.BarName = "alphabeticBarItem";
            this.alphabeticBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphabeticBarItem.ID = "BarItem";
            this.alphabeticBarItem.ImageIndex = 26;
            this.alphabeticBarItem.ImageList = this.dockingImageList;
            this.alphabeticBarItem.ShowToolTipInPopUp = false;
            this.alphabeticBarItem.SizeToFit = true;
            // 
            // propertiesBarItem
            // 
            this.propertiesBarItem.BarName = "propertiesBarItem";
            this.propertiesBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertiesBarItem.ID = "BarItem";
            this.propertiesBarItem.ImageIndex = 27;
            this.propertiesBarItem.ImageList = this.dockingImageList;
            this.propertiesBarItem.ShowToolTipInPopUp = false;
            this.propertiesBarItem.SizeToFit = true;
            // 
            // eventBarItem
            // 
            this.eventBarItem.BarName = "eventBarItem";
            this.eventBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventBarItem.ID = "BarItem";
            this.eventBarItem.ImageIndex = 28;
            this.eventBarItem.ImageList = this.dockingImageList;
            this.eventBarItem.ShowToolTipInPopUp = false;
            this.eventBarItem.SizeToFit = true;
            // 
            // propertyPagesBarItem
            // 
            this.propertyPagesBarItem.BarName = "propertyPagesBarItem";
            this.propertyPagesBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyPagesBarItem.ID = "BarItem";
            this.propertyPagesBarItem.ImageIndex = 29;
            this.propertyPagesBarItem.ImageList = this.dockingImageList;
            this.propertyPagesBarItem.ShowToolTipInPopUp = false;
            this.propertyPagesBarItem.SizeToFit = true;
            // 
            // scrollersFrame1
            // 
            this.scrollersFrame1.AttachedTo = this.propertyGrid1;
            this.scrollersFrame1.CustomRender = null;
            this.scrollersFrame1.MetroColorScheme = Syncfusion.Windows.Forms.MetroColorScheme.Managed;
            this.scrollersFrame1.SizeGripperVisibility = Syncfusion.Windows.Forms.SizeGripperVisibility.Auto;
            this.scrollersFrame1.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;
            // 
            // PropertiesView
            // 
            this.Controls.Add(this.panelProperties);
            this.Name = "PropertiesView";
            this.Size = new System.Drawing.Size(216, 392);
            this.panelProperties.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion
	}
}
