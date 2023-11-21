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
using Syncfusion.Windows.Forms;

namespace VSDemo
{
	/// <summary>
	/// Summary description for ToolBox.
	/// </summary>
	public class ToolBoxView : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Panel panelToolBox;
		public Syncfusion.Windows.Forms.Tools.GroupBar gBToolBox;
		private Syncfusion.Windows.Forms.Tools.GroupBarItem gvbSyncfusion;
		private Syncfusion.Windows.Forms.Tools.GroupBarItem gvbComponents;
		private Syncfusion.Windows.Forms.Tools.GroupBarItem gvbWindowsForm;
		private Syncfusion.Windows.Forms.Tools.GroupBarItem gvbGeneral;
		private System.Windows.Forms.ImageList largeImageList;
		public Syncfusion.Windows.Forms.Tools.GroupView gvcSyncfusion;
		private System.Windows.Forms.ImageList dockingImageList;
		public Syncfusion.Windows.Forms.Tools.GroupView gvcComponents;
		public Syncfusion.Windows.Forms.Tools.GroupView gvcWindowsForms;
		public Syncfusion.Windows.Forms.Tools.GroupView gvcGeneral;
		private System.ComponentModel.IContainer components;

		public ToolBoxView()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
            this.gBToolBox.HeaderBackColor = Color.FromArgb(0, 122, 204);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolBoxView));
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.gBToolBox = new Syncfusion.Windows.Forms.Tools.GroupBar();
            this.gvcComponents = new Syncfusion.Windows.Forms.Tools.GroupView();
            this.largeImageList = new System.Windows.Forms.ImageList(this.components);
            this.dockingImageList = new System.Windows.Forms.ImageList(this.components);
            this.gvcGeneral = new Syncfusion.Windows.Forms.Tools.GroupView();
            this.gvcWindowsForms = new Syncfusion.Windows.Forms.Tools.GroupView();
            this.gvcSyncfusion = new Syncfusion.Windows.Forms.Tools.GroupView();
            this.gvbSyncfusion = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.gvbComponents = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.gvbWindowsForm = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.gvbGeneral = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.panelToolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gBToolBox)).BeginInit();
            this.gBToolBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelToolBox
            // 
            this.panelToolBox.Controls.Add(this.gBToolBox);
            this.panelToolBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelToolBox.Location = new System.Drawing.Point(0, 0);
            this.panelToolBox.Name = "panelToolBox";
            this.panelToolBox.Size = new System.Drawing.Size(216, 568);
            this.panelToolBox.TabIndex = 0;
            // 
            // gBToolBox
            // 
            this.gBToolBox.AllowDrop = true;
            this.gBToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.gBToolBox.BorderColor = System.Drawing.Color.White;
            this.gBToolBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gBToolBox.Controls.Add(this.gvcSyncfusion);
            this.gBToolBox.Controls.Add(this.gvcComponents);
            this.gBToolBox.Controls.Add(this.gvcGeneral);
            this.gBToolBox.Controls.Add(this.gvcWindowsForms);
            this.gBToolBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBToolBox.ExpandButtonToolTip = null;
            this.gBToolBox.FlatLook = true;
            this.gBToolBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBToolBox.ForeColor = System.Drawing.Color.White;
            this.gBToolBox.GroupBarDropDownToolTip = null;
            this.gBToolBox.GroupBarItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupBarItem[] {
            this.gvbSyncfusion,
            this.gvbComponents,
            this.gvbWindowsForm,
            this.gvbGeneral});
            this.gBToolBox.IndexOnVisibleItems = true;
            this.gBToolBox.Location = new System.Drawing.Point(0, 0);
            this.gBToolBox.MinimizeButtonToolTip = null;
            this.gBToolBox.Name = "gBToolBox";
            this.gBToolBox.NavigationPaneTooltip = null;
            this.gBToolBox.PopupClientSize = new System.Drawing.Size(0, 0);
            this.gBToolBox.SelectedItem = 0;
            this.gBToolBox.ShowItemImageInHeader = true;
            this.gBToolBox.Size = new System.Drawing.Size(216, 568);
            this.gBToolBox.TabIndex = 0;
            this.gBToolBox.GroupBarItemHeight = (int)DpiAware.LogicalToDeviceUnits(22);
            this.gBToolBox.Text = "groupBar1";
            this.gBToolBox.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left;
            this.gBToolBox.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // gvcComponents
            // 
            this.gvcComponents.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gvcComponents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvcComponents.ButtonView = true;
            this.gvcComponents.FlatLook = true;
            this.gvcComponents.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvcComponents.ForeColor = System.Drawing.Color.Black;
            this.gvcComponents.GroupViewItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupViewItem[] {
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Pointer", 9, true, null, "Pointer"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("FileSystemWatcher", 20, true, null, "FileSystemWatcher"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("EventLog", 21, true, null, "EventLog"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("DirectoryEntry", 22, true, null, "DirectoryEntry"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("DirectorySearcher", 23, true, null, "DirectorySearcher"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("MessageQueue", 24, true, null, "MessageQueue")});
            this.gvcComponents.IntegratedScrolling = true;
            this.gvcComponents.ItemYSpacing = 1;
            this.gvcComponents.LargeImageList = this.largeImageList;
            this.gvcComponents.Location = new System.Drawing.Point(0, 524);
            this.gvcComponents.Name = "gvcComponents";
            this.gvcComponents.SelectedItem = 0;
            this.gvcComponents.SelectedItemColor = Color.Lavender;
            this.gvcComponents.SelectedTextColor = Color.Black;
            this.gvcComponents.HighlightItemColor = Color.LightGray;
            this.gvcComponents.Size = new System.Drawing.Size(216, 0);
            this.gvcComponents.SmallImageList = this.dockingImageList;
            this.gvcComponents.SmallImageView = true;
            this.gvcComponents.TabIndex = 33;
            this.gvcComponents.Text = "groupViewControl1";
            // 
            // largeImageList
            // 
            this.largeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeImageList.ImageStream")));
            this.largeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.largeImageList.Images.SetKeyName(0, "");
            this.largeImageList.Images.SetKeyName(1, "");
            this.largeImageList.Images.SetKeyName(2, "");
            this.largeImageList.Images.SetKeyName(3, "");
            this.largeImageList.Images.SetKeyName(4, "");
            this.largeImageList.Images.SetKeyName(5, "");
            this.largeImageList.Images.SetKeyName(6, "");
            this.largeImageList.Images.SetKeyName(7, "");
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
            // gvcGeneral
            // 
            this.gvcGeneral.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gvcGeneral.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvcGeneral.ButtonView = true;
            this.gvcGeneral.FlatLook = true;
            this.gvcGeneral.FlowView = true;
            this.gvcGeneral.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvcGeneral.GroupViewItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupViewItem[] {
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Pointer", 9, true, null, "Pointer"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Label", 10, true, null, "Label"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("LinkLabel", 11, true, null, "LinkLabel"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Button", 12, true, null, "Button"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("TextBox", 13, true, null, "TextBox"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("MainMenu", 14, true, null, "MainMenu"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("RadioButton", 15, true, null, "RadioButton")});
            this.gvcGeneral.HighlightText = false;
            this.gvcGeneral.SelectedTextColor = Color.Black;
            this.gvcGeneral.HighlightItemColor = Color.LightGray;
            this.gvcGeneral.ImageSpacing = 5;
            this.gvcGeneral.IntegratedScrolling = true;
            this.gvcGeneral.ItemXSpacing = 0;
            this.gvcGeneral.ItemYSpacing = 0;
            this.gvcGeneral.LargeImageList = this.largeImageList;
            this.gvcGeneral.Location = new System.Drawing.Point(0, 300);
            this.gvcGeneral.Name = "gvcGeneral";
            this.gvcGeneral.SelectedItem = 0;
            this.gvcGeneral.SelectedItemColor = Color.Lavender;
            this.gvcGeneral.Size = new System.Drawing.Size(220, 0);
            this.gvcGeneral.SmallImageList = this.dockingImageList;
            this.gvcGeneral.SmallImageView = true;
            this.gvcGeneral.TabIndex = 35;
            this.gvcGeneral.Text = "groupViewControl1";
            // 
            // gvcWindowsForms
            // 
            this.gvcWindowsForms.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gvcWindowsForms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvcWindowsForms.ButtonView = true;
            this.gvcWindowsForms.FlatLook = true;
            this.gvcWindowsForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvcWindowsForms.ForeColor = System.Drawing.Color.Black;
            this.gvcWindowsForms.GroupViewItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupViewItem[] {
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Pointer", 9, true, null, "Pointer"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Label", 10, true, null, "Label"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("LinkLabel", 11, true, null, "LinkLabel"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Button", 12, true, null, "Button"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("TextBox", 13, true, null, "TextBox"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("MainMenu", 14, true, null, "MainMenu"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("CheckBox", 15, true, null, "CheckBox"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("RadioButton", 16, true, null, "RadioButton"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("GroupBox", 17, true, null, "GroupBox"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("PictureBox", 18, true, null, "PictureBox"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("DataGrid", 19, true, null, "DataGrid")});
            this.gvcWindowsForms.IntegratedScrolling = true;
            this.gvcWindowsForms.ItemYSpacing = 1;
            this.gvcWindowsForms.LargeImageList = this.largeImageList;
            this.gvcWindowsForms.Location = new System.Drawing.Point(0, 66);
            this.gvcWindowsForms.Name = "gvcWindowsForms";
            this.gvcWindowsForms.SelectedItem = 0;
            this.gvcWindowsForms.SelectedItemColor = Color.Lavender;
            this.gvcWindowsForms.SelectedTextColor = Color.Black;
            this.gvcWindowsForms.HighlightItemColor = Color.LightGray;
            this.gvcWindowsForms.Size = new System.Drawing.Size(216, 0);
            this.gvcWindowsForms.SmallImageList = this.dockingImageList;
            this.gvcWindowsForms.SmallImageView = true;
            this.gvcWindowsForms.TabIndex = 34;
            this.gvcWindowsForms.Text = "groupViewControl1";
            // 
            // gvcSyncfusion
            // 
            this.gvcSyncfusion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gvcSyncfusion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvcSyncfusion.ButtonView = true;
            this.gvcSyncfusion.FlatLook = true;
            this.gvcSyncfusion.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvcSyncfusion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gvcSyncfusion.GroupViewItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupViewItem[] {
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Pointer", 9, true, null, "Pointer"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("AutoComplete", 43, true, null, "AutoComplete"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("XPToolBar", 44, true, null, "XPToolBar"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("ButtonEdit", 45, true, null, "ButtonEdit"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("CalculatorControl", 46, true, null, "CalculatorControl"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("ColorPicker", 47, true, null, "ColorPicker"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("CurrencyEdit", 48, true, null, "CurrencyEdit"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("CurrencyTextBox", 48, true, null, "CurrencyTextBox"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("FolderBrowser", 49, true, null, "FolderBrowser"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("GroupBar", 50, true, null, "GroupBar"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("GroupView", 51, true, null, "GroupView"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("DockingManager", 52, true, null, "DockingManager"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("MainFrameBarManager", 53, true, null, "MainFrameBarManager"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("MaskedEditBox", 54, true, null, "MaskedEditBox"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("PopupMenu", 55, true, null, "PopupMenu"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("GridRecordNavigationControl", 56, true, null, "GridRecordNavigationControl"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("SplashControl", 57, true, null, "SplashControl"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("TabControlExt", 58, true, null, "TabControlExt")});
            this.gvcSyncfusion.IntegratedScrolling = true;
            this.gvcSyncfusion.ItemYSpacing = 1;
            this.gvcSyncfusion.LargeImageList = this.largeImageList;
            this.gvcSyncfusion.Location = new System.Drawing.Point(0, 22);
            this.gvcSyncfusion.Name = "gvcSyncfusion";
            this.gvcSyncfusion.SelectedItem = 0;
            this.gvcSyncfusion.SelectedItemColor = Color.Lavender;
            this.gvcSyncfusion.SelectedTextColor = Color.Black;
            this.gvcSyncfusion.HighlightItemColor = Color.LightGray;
            this.gvcSyncfusion.Size = new System.Drawing.Size(216, 480);
            this.gvcSyncfusion.SmallImageList = this.dockingImageList;
            this.gvcSyncfusion.SmallImageView = true;
            this.gvcSyncfusion.TabIndex = 32;
            this.gvcSyncfusion.Text = "groupViewControl1";
            // 
            // gvbSyncfusion
            // 
            this.gvbSyncfusion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.gvbSyncfusion.Client = this.gvcSyncfusion;
            this.gvbSyncfusion.Text = "Syncfusion";
            // 
            // gvbComponents
            // 
            this.gvbComponents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.gvbComponents.Client = this.gvcComponents;
            this.gvbComponents.Text = "Components";
            // 
            // gvbWindowsForm
            // 
            this.gvbWindowsForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.gvbWindowsForm.Client = this.gvcWindowsForms;
            this.gvbWindowsForm.Text = "Windows Forms";
            // 
            // gvbGeneral
            // 
            this.gvbGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.gvbGeneral.Client = this.gvcGeneral;
            this.gvbGeneral.Text = "General";
            // 
            // ToolBoxView
            // 
            this.Controls.Add(this.panelToolBox);
            this.Name = "ToolBoxView";
            this.Size = new System.Drawing.Size(216, 568);
            this.panelToolBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gBToolBox)).EndInit();
            this.gBToolBox.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion


	}
}
