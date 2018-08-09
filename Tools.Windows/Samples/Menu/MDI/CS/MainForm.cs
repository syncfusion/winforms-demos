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

namespace XPMenusMDI
{
    using System;
    using System.Drawing;
    using System.Collections;
    using System.ComponentModel;
    using System.Data;
    using System.IO;
    using System.Diagnostics;
    using Microsoft.Win32;
    using System.Threading;
    using System.Windows.Forms;
    using System.Runtime.InteropServices;

    using Syncfusion.Windows.Forms.Tools;
    using Syncfusion.Windows.Forms.Tools.XPMenus;
    using Syncfusion.Win32;
    using Syncfusion.Runtime.Serialization;
    using Syncfusion.Windows.Forms;

    /// <summary>
    /// Summary description for MainForm.
    /// </summary>
    public class MainForm : MetroForm
	{
		private Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu popupMenu2;
		private System.Windows.Forms.ImageList imageList1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager barManager1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem8;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem9;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem10;
		private Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem dropDownBarItem1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem11;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem12;
		private System.Windows.Forms.MdiClient mdiClient1;
		private Syncfusion.Windows.Forms.PopupControlContainer popupControlContainer1;
		private System.Windows.Forms.ListBox listBox1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem13;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem14;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem15;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem16;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem17;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Metro;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Office2007;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Office2010;

		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem openBarItem;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem closeBarItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem WindowsMenu;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem exitBarItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem cascadeBarItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem tileHBarItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem tileVBarItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ListBarItem mruFilesListItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.MdiListBarItem mdiListBarItem1;
		private System.Windows.Forms.ImageList largeImageList;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem themesItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ToolbarListBarItem toolbarListBarItem1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar3;
		public Syncfusion.Windows.Forms.Tools.XPMenus.StaticBarItem staticBarItem1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem3;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Office2003Item;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar4;
        private BarItem VS2005Item;
        private BarItem Outlook2007Item;
        private ParentBarItem parentBarItem5;
        private BarItem barItem2;
        private BarItem barItem3;
        private BarItem barItem1;
        private BarItem barItem4;
        private ParentBarItem parentBarItem6;
        private PopupControlContainer popupControlContainer2;
        private ColorPickerUIAdv colorPickerUIAdv1;
        private DropDownBarItem dropDownBarItem2;
		private System.ComponentModel.IContainer components;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            this.MinimumSize = this.Size;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }


			// Choosing to show a merged menu/toolbar structure, all the time.
			// Hence registering the Child Form Types that will be instantiated during the course of
			// the application.
			// (You can choose not to invoke a merge explicitly, in which case, the framework
			// will automatically merge the menus/toolbars from the child Forms when instances
			// of those types get created).
            this.barManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016White;
			this.staticBarItem1.Text = "Ready";
            this.dropDownBarItem2.UpdateUIOnAppIdle = true;
            this.dropDownBarItem2.UpdateUI += new EventHandler(dropDownBarItem2_UpdateUI);
			this.barManager1.RegisterMdiChildTypes(new Type[]
							{
								typeof(TextEditorForm),
								typeof(ImageEditorForm)
							});

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

        void dropDownBarItem2_UpdateUI(object sender, EventArgs e)
        {
            this.colorPickerUIAdv1.RecentGroup.Visible = false;
        }

		private void ListItemClicked(object sender, EventArgs e)
		{
			ListBarItemClickedEventArgs args = e as ListBarItemClickedEventArgs;
			ListBarItem listItem = sender as ListBarItem;

			listItem.CheckedIndices.Clear();
			listItem.CheckedIndices.Add(args.IndexClicked);
			// Refresh, in case this item is put in a ParentBarItem with CloseOnClick = false
			listItem.UpdateCheckedStates();

			MessageBox.Show("ListItem: " + listItem.ChildCaptions[args.IndexClicked]);
		}


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.barItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem9 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.popupControlContainer1 = new Syncfusion.Windows.Forms.PopupControlContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.barManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.barManager1, "MainMenu");
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.openBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.closeBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.mruFilesListItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ListBarItem();
            this.exitBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.toolbarListBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ToolbarListBarItem();
            this.WindowsMenu = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.cascadeBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.tileHBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.tileVBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.mdiListBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MdiListBarItem();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem13 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem14 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem15 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem16 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem17 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Metro= new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Office2007 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Office2010 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();

            this.parentBarItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
           
            this.bar2 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.barManager1, "Standard");
            this.bar3 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.barManager1, "StatusBar");
            this.staticBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.StaticBarItem();
            this.bar4 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.barManager1, "Color");
            this.Office2003Item = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.VS2005Item = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Outlook2007Item = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.dropDownBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem();
            this.popupControlContainer2 = new Syncfusion.Windows.Forms.PopupControlContainer();
            this.colorPickerUIAdv1 = new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv();
            this.themesItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.largeImageList = new System.Windows.Forms.ImageList(this.components);
            this.mdiClient1 = new System.Windows.Forms.MdiClient();
            this.barItem12 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem11 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem10 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.dropDownBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem();
            this.popupMenu2 = new Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.popupControlContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // barItem8
            // 
            this.barItem8.BarName = "barItem8";
            this.barItem8.CategoryIndex = 0;
            this.barItem8.ID = "Test4";
            this.barItem8.ShowToolTipInPopUp = false;
            this.barItem8.SizeToFit = true;
            this.barItem8.Text = "Test4";
            // 
            // barItem9
            // 
            this.barItem9.BarName = "barItem9";
            this.barItem9.CategoryIndex = 0;
            this.barItem9.ID = "Test5";
            this.barItem9.ShowToolTipInPopUp = false;
            this.barItem9.SizeToFit = true;
            this.barItem9.Text = "Test5";
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
            this.imageList1.Images.SetKeyName(15, "architecture_info_16.png");
            this.imageList1.Images.SetKeyName(16, "ballon_fav_16.png");
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.Location = new System.Drawing.Point(384, 80);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Size = new System.Drawing.Size(96, 96);
            this.popupControlContainer1.TabIndex = 5;
            this.popupControlContainer1.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(96, 95);
            this.listBox1.TabIndex = 0;
            // 
            // barManager1
            // 
            this.barManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("barManager1.BarPositionInfo")));
            this.barManager1.Bars.Add(this.bar1);
            this.barManager1.Bars.Add(this.bar2);
            this.barManager1.Bars.Add(this.bar3);
            this.barManager1.Bars.Add(this.bar4);
            this.barManager1.Categories.Add("File");
            this.barManager1.Categories.Add("View");
            this.barManager1.Categories.Add("Window");
            this.barManager1.Categories.Add("&Help");
            this.barManager1.Categories.Add("StatusBar");
            this.barManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.MetroForm";
            this.barManager1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barManager1.Form = this;
            this.barManager1.ImageList = this.imageList1;
            this.barManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.openBarItem,
            this.closeBarItem,
            this.parentBarItem4,
            this.mruFilesListItem,
            this.WindowsMenu,
            this.exitBarItem,
            this.themesItem,
            this.parentBarItem2,
            this.parentBarItem3,
            this.Office2003Item,
            this.VS2005Item,
            this.cascadeBarItem,
            this.Outlook2007Item,
            this.tileHBarItem,
            this.parentBarItem5,
            this.tileVBarItem,
            this.barItem1,
            this.barItem13,
            this.barItem14,
            this.barItem15,
            this.barItem2,
            this.mdiListBarItem1,
            this.barItem3,
            this.toolbarListBarItem1,
            this.staticBarItem1,
            this.dropDownBarItem2,
            this.parentBarItem6});
            this.barManager1.LargeImageList = this.largeImageList;
            this.barManager1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.barManager1.ResetCustomization = false;
         
            // 
            // bar1
            // 
            this.bar1.BarName = "MainMenu";
            this.bar1.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)));
            this.bar1.Caption = "MainMenu";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.parentBarItem4,
            this.WindowsMenu,
            this.parentBarItem6,
            this.parentBarItem2});
            this.bar1.Manager = this.barManager1;
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.BarName = "parentBarItem1";
            this.parentBarItem1.CategoryIndex = 0;
            this.parentBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem1.ID = "&File";
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.openBarItem,
            this.closeBarItem,
            this.parentBarItem3,
            this.exitBarItem});
            this.parentBarItem1.MergeOrder = 1;
            this.parentBarItem1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem1.SeparatorIndices.AddRange(new int[] {
            2,
            3});
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem1.Text = "&File";
            this.parentBarItem1.Selected += new System.EventHandler(this.Item_Selected);
            // 
            // openBarItem
            // 
            this.openBarItem.BarName = "openBarItem";
            this.openBarItem.CategoryIndex = 0;
            this.openBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openBarItem.ID = "&Open";
            this.openBarItem.ImageIndex = 0;
            this.openBarItem.MergeOrder = 1;
            this.openBarItem.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.openBarItem.ShowToolTipInPopUp = false;
            this.openBarItem.SizeToFit = true;
            this.openBarItem.Text = "&Open";
            this.openBarItem.Click += new System.EventHandler(this.openBarItem_Click);
            this.openBarItem.Selected += new System.EventHandler(this.Item_Selected);
            // 
            // closeBarItem
            // 
            this.closeBarItem.BarName = "closeBarItem";
            this.closeBarItem.CategoryIndex = 0;
            this.closeBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBarItem.ID = "&Close";
            this.closeBarItem.ImageIndex = 4;
            this.closeBarItem.MergeOrder = 3;
            this.closeBarItem.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftO;
            this.closeBarItem.ShowToolTipInPopUp = false;
            this.closeBarItem.SizeToFit = true;
            this.closeBarItem.Text = "&Close";
            this.closeBarItem.Click += new System.EventHandler(this.closeBarItem_Click);
            this.closeBarItem.Selected += new System.EventHandler(this.Item_Selected);
            // 
            // parentBarItem3
            // 
            this.parentBarItem3.BarName = "parentBarItem3";
            this.parentBarItem3.CategoryIndex = 0;
            this.parentBarItem3.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem3.ID = "Most Rec&ently Used Files";
            this.parentBarItem3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.mruFilesListItem});
            this.parentBarItem3.MergeOrder = 8;
            this.parentBarItem3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem3.ShowToolTipInPopUp = false;
            this.parentBarItem3.SizeToFit = true;
            this.parentBarItem3.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem3.Text = "Most Recently Used Files";
            // 
            // mruFilesListItem
            // 
            this.mruFilesListItem.BarName = "mruFilesListItem";
            this.mruFilesListItem.CategoryIndex = 0;
            this.mruFilesListItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mruFilesListItem.ID = "Most Recently Used Files List";
            this.mruFilesListItem.MergeOrder = 10;
            this.mruFilesListItem.ShowToolTipInPopUp = false;
            this.mruFilesListItem.SizeToFit = true;
            this.mruFilesListItem.Text = "MRU List";
            this.mruFilesListItem.Click += new System.EventHandler(this.ListItemClicked);
            // 
            // exitBarItem
            // 
            this.exitBarItem.BarName = "exitBarItem";
            this.exitBarItem.CategoryIndex = 0;
            this.exitBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBarItem.ID = "E&xit";
            this.exitBarItem.ImageIndex = 8;
            this.exitBarItem.MergeOrder = 20;
            this.exitBarItem.ShowToolTipInPopUp = false;
            this.exitBarItem.SizeToFit = true;
            this.exitBarItem.Text = "E&xit";
            this.exitBarItem.Click += new System.EventHandler(this.exitBarItem_Click);
            this.exitBarItem.Selected += new System.EventHandler(this.Item_Selected);
            // 
            // parentBarItem4
            // 
            this.parentBarItem4.BarName = "parentBarItem4";
            this.parentBarItem4.CategoryIndex = 1;
            this.parentBarItem4.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem4.ID = "&View";
            this.parentBarItem4.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.toolbarListBarItem1});
            this.parentBarItem4.MergeOrder = 5;
            this.parentBarItem4.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem4.ShowToolTipInPopUp = false;
            this.parentBarItem4.SizeToFit = true;
            this.parentBarItem4.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem4.Text = "&View";
            this.parentBarItem4.Selected += new System.EventHandler(this.Item_Selected);
            // 
            // toolbarListBarItem1
            // 
            this.toolbarListBarItem1.BarName = "toolbarListBarItem1";
            this.toolbarListBarItem1.CategoryIndex = 1;
            this.toolbarListBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolbarListBarItem1.ID = "&Toolbars";
            this.toolbarListBarItem1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.toolbarListBarItem1.ShowToolTipInPopUp = false;
            this.toolbarListBarItem1.SizeToFit = true;
            this.toolbarListBarItem1.Text = "&Toolbars";
            // 
            // WindowsMenu
            // 
            this.WindowsMenu.BarName = "WindowsMenu";
            this.WindowsMenu.CategoryIndex = 2;
            this.WindowsMenu.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowsMenu.ID = "&Window";
            this.WindowsMenu.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.cascadeBarItem,
            this.tileHBarItem,
            this.tileVBarItem,
            this.mdiListBarItem1});
            this.WindowsMenu.MergeOrder = 19;
            this.WindowsMenu.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.WindowsMenu.SeparatorIndices.AddRange(new int[] {
            3});
            this.WindowsMenu.ShowToolTipInPopUp = false;
            this.WindowsMenu.SizeToFit = true;
            this.WindowsMenu.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.WindowsMenu.Text = "&Window";
            this.WindowsMenu.Selected += new System.EventHandler(this.Item_Selected);
            // 
            // cascadeBarItem
            // 
            this.cascadeBarItem.BarName = "cascadeBarItem";
            this.cascadeBarItem.CategoryIndex = 2;
            this.cascadeBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cascadeBarItem.ID = "&Cascade";
            this.cascadeBarItem.ImageIndex = 1;
            this.cascadeBarItem.ShowToolTipInPopUp = false;
            this.cascadeBarItem.SizeToFit = true;
            this.cascadeBarItem.Text = "&Cascade";
            this.cascadeBarItem.Click += new System.EventHandler(this.cascadeBarItem_Click);
            this.cascadeBarItem.Selected += new System.EventHandler(this.Item_Selected);
            // 
            // tileHBarItem
            // 
            this.tileHBarItem.BarName = "tileHBarItem";
            this.tileHBarItem.CategoryIndex = 2;
            this.tileHBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileHBarItem.ID = "Tile &Horizontal";
            this.tileHBarItem.ImageIndex = 2;
            this.tileHBarItem.ShowToolTipInPopUp = false;
            this.tileHBarItem.SizeToFit = true;
            this.tileHBarItem.Text = "Tile &Horizontal";
            this.tileHBarItem.Click += new System.EventHandler(this.tileHBarItem_Click);
            this.tileHBarItem.Selected += new System.EventHandler(this.Item_Selected);
            // 
            // tileVBarItem
            // 
            this.tileVBarItem.BarName = "tileVBarItem";
            this.tileVBarItem.CategoryIndex = 2;
            this.tileVBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileVBarItem.ID = "Tile &Vertical";
            this.tileVBarItem.ImageIndex = 3;
            this.tileVBarItem.ShowToolTipInPopUp = false;
            this.tileVBarItem.SizeToFit = true;
            this.tileVBarItem.Text = "Tile &Vertical";
            this.tileVBarItem.Click += new System.EventHandler(this.tileVBarItem_Click);
            this.tileVBarItem.Selected += new System.EventHandler(this.Item_Selected);
            // 
            // mdiListBarItem1
            // 
            this.mdiListBarItem1.BarName = "mdiListBarItem1";
            this.mdiListBarItem1.CategoryIndex = 2;
            this.mdiListBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdiListBarItem1.ID = "Window List";
            this.mdiListBarItem1.ShowToolTipInPopUp = false;
            this.mdiListBarItem1.SizeToFit = true;
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.BarName = "parentBarItem2";
            this.parentBarItem2.CategoryIndex = 3;
            this.parentBarItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem2.ID = "Visual Style";
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {           
             this.Office2003Item,
            this.VS2005Item,
            this.Outlook2007Item,
             this.Office2007,
            this.Office2010,
            this.Metro,           
            this.barItem14,
            this.barItem15,
            this.barItem16,
            this.barItem17,   });
            this.parentBarItem2.MergeOrder = 20;
            this.parentBarItem2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem2.ShowToolTipInPopUp = false;
            this.parentBarItem2.SizeToFit = true;
            this.parentBarItem2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem2.Text = "Visual Style";
            this.parentBarItem2.Selected += new System.EventHandler(this.Item_Selected);
            // 
            // barItem13
            // 
            this.barItem13.BarName = "barItem13";
            this.barItem13.CategoryIndex = 3;
            this.barItem13.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem13.ID = "Syncfusion on the Web";          
            this.barItem13.ShowToolTipInPopUp = false;
            this.barItem13.SizeToFit = true;
            this.barItem13.Text = "Syncfusion on the Web";
            this.barItem13.Click += new System.EventHandler(this.barItem13_Click);
            this.barItem13.Selected += new System.EventHandler(this.Item_Selected);
            // 
            // parentBarItem6
            // 
            this.parentBarItem6.BarName = "parentBarItem6";
            this.parentBarItem6.CategoryIndex = 5;
            this.parentBarItem6.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem6.ID = "&Help";
            this.parentBarItem6.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem13      
          });
            this.parentBarItem6.MergeOrder = 21;
            this.parentBarItem6.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem6.ShowToolTipInPopUp = false;
            this.parentBarItem6.SizeToFit = true;
            this.parentBarItem6.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem6.Text = "&Help";           
            // 
            // barItem14
            // 
            this.barItem14.BarName = "barItem14";
            this.barItem14.CategoryIndex = 5;
            this.barItem14.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem14.ID = "Office2016Colorful";          
            this.barItem14.ShowToolTipInPopUp = false;
            this.barItem14.SizeToFit = true;
            this.barItem14.Text = "Office2016Colorful";
            this.barItem14.Click += new System.EventHandler(this.barItem14_Click);
            // 
            // barItem15
            // 
            this.barItem15.BarName = "barItem15";
            this.barItem15.CategoryIndex = 5;
            this.barItem15.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem15.ID = "Office2016White";       
            this.barItem15.ShowToolTipInPopUp = false;
            this.barItem15.SizeToFit = true;
            this.barItem15.Text = "Office2016White";
            this.barItem15.Click += new System.EventHandler(this.barItem15_Click);


            // 
            // barItem16
            // 
            this.barItem16.BarName = "barItem16";
            this.barItem16.CategoryIndex = 5;
            this.barItem16.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem16.ID = "Office2016DarkGray";          
            this.barItem16.ShowToolTipInPopUp = false;
            this.barItem16.SizeToFit = true;
            this.barItem16.Text = "Office2016DarkGray";
            this.barItem16.Click += new System.EventHandler(this.barItem16_Click);


            // 
            // barItem16
            // 
            this.barItem17.BarName = "barItem16";
            this.barItem17.CategoryIndex = 5;
            this.barItem17.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem17.ID = "Office2016Black";           
            this.barItem17.ShowToolTipInPopUp = false;
            this.barItem17.SizeToFit = true;
            this.barItem17.Text = "Office2016Black";
            this.barItem17.Click += new System.EventHandler(this.barItem17_Click);
            // 
            // MetroItem
            // 
            this.Metro.BarName = "Metro";
            this.Metro.CategoryIndex = 5;
            this.Metro.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Metro.ID = "Metro";          
            this.Metro.ShowToolTipInPopUp = false;
            this.Metro.SizeToFit = true;
            this.Metro.Text = "Metro";
            this.Metro.Click += new System.EventHandler(this.Metro_Click);
            // 
            // Office2007Item
            // 
            this.Office2007.BarName = "Office2007";
            this.Office2007.CategoryIndex = 5;
            this.Office2007.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Office2007.ID = "Office2007";          
            this.Office2007.ShowToolTipInPopUp = false;
            this.Office2007.SizeToFit = true;
            this.Office2007.Text = "Office2007";
            this.Office2007.Click += new System.EventHandler(this.Office2007_Click);
            // 
            // Office2010Item
            // 
            this.Office2010.BarName = "Office2010";
            this.Office2010.CategoryIndex = 5;
            this.Office2010.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Office2010.ID = "Office2010";       
            this.Office2010.ShowToolTipInPopUp = false;
            this.Office2010.SizeToFit = true;
            this.Office2010.Text = "Office2010";
            this.Office2010.Click += new System.EventHandler(this.Office2010_Click);



            // 
            // bar2
            // 
            this.bar2.BarName = "Standard";
            this.bar2.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder)));
            this.bar2.Caption = "Standard";
            this.bar2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.openBarItem,
            this.closeBarItem});
            this.bar2.Manager = this.barManager1;
            // 
            // bar3
            // 
            this.bar3.BarName = "StatusBar";
            this.bar3.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)(((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsStatusBar)));
            this.bar3.Caption = "StatusBar";
            this.bar3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.staticBarItem1});
            this.bar3.Manager = this.barManager1;
            // 
            // staticBarItem1
            // 
            this.staticBarItem1.BarName = "staticBarItem1";
            this.staticBarItem1.CategoryIndex = 4;
            this.staticBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticBarItem1.FlatBorderColor = System.Drawing.SystemColors.GrayText;
            this.staticBarItem1.ID = "Stutus1";
            this.staticBarItem1.ShowToolTipInPopUp = false;
            this.staticBarItem1.SizeToFit = true;
            this.staticBarItem1.Text = "Status1";
            // 
            // bar4
            // 
            this.bar4.BarName = "Color";
            this.bar4.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder)));
            this.bar4.Caption = "Color";
            this.bar4.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
           
            this.parentBarItem5,
            this.themesItem});
            this.bar4.Manager = this.barManager1;
            this.bar4.SeparatorIndices.AddRange(new int[] {
            0,
            1,
            2,
            3});
            // 
            // Office2003Item
            // 
            this.Office2003Item.BarName = "Office2003Item";
            this.Office2003Item.CategoryIndex = 0;
            this.Office2003Item.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Office2003Item.ID = "Office2003";
            this.Office2003Item.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.Office2003Item.ShowToolTipInPopUp = false;
            this.Office2003Item.SizeToFit = true;
            this.Office2003Item.Text = "Office 2003";
            this.Office2003Item.Tooltip = "Enable Office 2003 Style";
            this.Office2003Item.Click += new System.EventHandler(this.barItem1_Click);
            // 
            // VS2005Item
            // 
            this.VS2005Item.BarName = "VS2005Item";
            this.VS2005Item.CategoryIndex = 0;
            this.VS2005Item.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VS2005Item.ID = "VS2005";
            this.VS2005Item.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.VS2005Item.ShowToolTipInPopUp = false;
            this.VS2005Item.SizeToFit = true;
            this.VS2005Item.Text = "VS 2005";
            this.VS2005Item.Click += new System.EventHandler(this.VS2005Item_Click);
            // 
            // Outlook2007Item
            // 
            this.Outlook2007Item.BarName = "Outlook2007Item";
            this.Outlook2007Item.CategoryIndex = 0;
            this.Outlook2007Item.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outlook2007Item.ID = "Outlook2007";
            this.Outlook2007Item.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.Outlook2007Item.ShowToolTipInPopUp = false;
            this.Outlook2007Item.SizeToFit = true;
            this.Outlook2007Item.Text = "Outlook2007";
            this.Outlook2007Item.Click += new System.EventHandler(this.Outlook2007Item_Click);
            // 
            // parentBarItem5
            // 
            this.parentBarItem5.BarName = "parentBarItem5";
            this.parentBarItem5.CategoryIndex = 0;
            this.parentBarItem5.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem5.ID = "Color Scheme";
            this.parentBarItem5.ImageIndex = 7;
            this.parentBarItem5.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem2,
            this.barItem3,
            this.barItem1,
            this.dropDownBarItem2});
            this.parentBarItem5.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem5.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.parentBarItem5.ShowToolTipInPopUp = false;
            this.parentBarItem5.SizeToFit = true;
            this.parentBarItem5.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem5.Text = "Color Scheme";
            // 
            // barItem2
            // 
            this.barItem2.BarName = "barItem2";
            this.barItem2.CategoryIndex = 0;
            this.barItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem2.ID = "Blue";
            this.barItem2.ShowToolTipInPopUp = false;
            this.barItem2.SizeToFit = true;
            this.barItem2.Text = "Blue";
            this.barItem2.Click += new System.EventHandler(this.barItem2_Click);
            // 
            // barItem3
            // 
            this.barItem3.BarName = "barItem3";
            this.barItem3.CategoryIndex = 0;
            this.barItem3.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem3.ID = "Silver";
            this.barItem3.ShowToolTipInPopUp = false;
            this.barItem3.SizeToFit = true;
            this.barItem3.Text = "Silver";
            this.barItem3.Click += new System.EventHandler(this.barItem3_Click);
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.CategoryIndex = 0;
            this.barItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem1.ID = "Black";
            this.barItem1.ShowToolTipInPopUp = false;
            this.barItem1.SizeToFit = true;
            this.barItem1.Text = "Black";
            this.barItem1.Click += new System.EventHandler(this.barItem1_Click_1);
            // 
            // dropDownBarItem2
            // 
            this.dropDownBarItem2.BarName = "dropDownBarItem2";
            this.dropDownBarItem2.CategoryIndex = 0;
            this.dropDownBarItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownBarItem2.ID = "Custom Colors";
            this.dropDownBarItem2.PopupControlContainer = this.popupControlContainer2;
            this.dropDownBarItem2.ShowToolTipInPopUp = false;
            this.dropDownBarItem2.SizeToFit = true;
            this.dropDownBarItem2.Text = "Custom Colors";
            // 
            // popupControlContainer2
            // 
            this.popupControlContainer2.Controls.Add(this.colorPickerUIAdv1);
            this.popupControlContainer2.Location = new System.Drawing.Point(173, 164);
            this.popupControlContainer2.Name = "popupControlContainer2";
            this.popupControlContainer2.Size = new System.Drawing.Size(172, 201);
            this.popupControlContainer2.TabIndex = 10002;
            this.popupControlContainer2.Visible = false;
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
            this.colorPickerUIAdv1.ColorItemSize = new System.Drawing.Size(13, 13);
            this.colorPickerUIAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorPickerUIAdv1.Location = new System.Drawing.Point(0, 0);
            this.colorPickerUIAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.colorPickerUIAdv1.MinimumSize = new System.Drawing.Size(136, 195);
            this.colorPickerUIAdv1.Name = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.SelectedColor = System.Drawing.Color.Empty;
            this.colorPickerUIAdv1.Size = new System.Drawing.Size(172, 201);
            this.colorPickerUIAdv1.Style = Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.visualstyle.Metro;
            this.colorPickerUIAdv1.TabIndex = 10003;
            this.colorPickerUIAdv1.Text = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.UseOffice2007Style = false;
            this.colorPickerUIAdv1.VerticalItemsSpacing = 1;
            this.colorPickerUIAdv1.Picked += new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventHandler(this.colorPickerUIAdv1_Picked);
            // 
            // themesItem
            // 
            this.themesItem.BarName = "themesItem";
            this.themesItem.CategoryIndex = 0;
            this.themesItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themesItem.ID = "ThemesEnabled";
            this.themesItem.ImageIndex = 5;
            this.themesItem.MergeOrder = 21;
            this.themesItem.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.themesItem.ShowToolTipInPopUp = false;
            this.themesItem.SizeToFit = true;
            this.themesItem.Text = "Themes Enabled";
            this.themesItem.Tooltip = "Enable Themes";
            this.themesItem.Click += new System.EventHandler(this.themesItem_Click);
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
            // 
            // mdiClient1
            // 
            this.mdiClient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mdiClient1.Location = new System.Drawing.Point(0, 50);
            this.mdiClient1.Name = "mdiClient1";
            this.mdiClient1.Size = new System.Drawing.Size(0, 0);
            this.mdiClient1.TabIndex = 4;
            // 
            // barItem12
            // 
            this.barItem12.BarName = "barItem12";
            this.barItem12.CategoryIndex = 0;
            this.barItem12.ID = "dummy";
            this.barItem12.ShowToolTipInPopUp = false;
            this.barItem12.SizeToFit = true;
            this.barItem12.Text = "dummy";
            // 
            // barItem11
            // 
            this.barItem11.BarName = "barItem11";
            this.barItem11.CategoryIndex = 2;
            this.barItem11.ID = "Tseting";
            this.barItem11.ShowToolTipInPopUp = false;
            this.barItem11.SizeToFit = true;
            this.barItem11.Text = "Tseting";
            // 
            // barItem10
            // 
            this.barItem10.BarName = "barItem10";
            this.barItem10.CategoryIndex = 0;
            this.barItem10.ID = "Test";
            this.barItem10.ShowToolTipInPopUp = false;
            this.barItem10.SizeToFit = true;
            this.barItem10.Text = "Test";
            // 
            // dropDownBarItem1
            // 
            this.dropDownBarItem1.BarName = "dropDownBarItem1";
            this.dropDownBarItem1.CategoryIndex = 1;
            this.dropDownBarItem1.ID = "DropDown";
            this.dropDownBarItem1.ShowToolTipInPopUp = false;
            this.dropDownBarItem1.SizeToFit = true;
            this.dropDownBarItem1.Text = "DropDown";
            // 
            // popupMenu2
            // 
            this.popupMenu2.ParentBarItem = this.parentBarItem1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "txt files (*.txt)|*.txt|Image Files (*.bmp; *.ico)|*.bmp;*.ico";
            this.openFileDialog1.FilterIndex = 0;
            this.openFileDialog1.Title = "Text or Image File Selection Dialog";
            // 
            // barItem4
            // 
            this.barItem4.BarName = "barItem4";
            this.barItem4.CategoryIndex = 0;
            this.barItem4.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem4.ID = "Custom Colors";
            this.barItem4.ShowToolTipInPopUp = false;
            this.barItem4.SizeToFit = true;
            this.barItem4.Text = "Custom Colors";
            // 
            // MainForm
            // 
            this.AccessibleName = "";
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientSize = new System.Drawing.Size(709, 495);
            this.Controls.Add(this.popupControlContainer2);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.IconTextRelation = System.Windows.Forms.LeftRightAlignment.Left;
            this.IsMdiContainer = true;
            this.MetroColor = System.Drawing.Color.White;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MdiChildActivate += new System.EventHandler(this.MainForm_MdiChildActivate);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.popupControlContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		#region DLL Imports
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		extern public static bool SetForegroundWindow(IntPtr hwnd);
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main() 
		{
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
            // Safe mode check
            // Uncomment this to include support for running this app in "Safe Mode" (when persisted data will not be loaded).
            // SafeModeCheck();

            // Modify this version, whenever changes are made such that the persisted state cannot be loaded anymore.
            string curVersion = "1.0";
			ValidatePersistedStateVersion(curVersion);
			StoreVersionInfo(curVersion);

			MainForm mainForm = new MainForm();

			bool bRunning = false;
			foreach ( Process p in Process.GetProcesses(System.Environment.MachineName) )
			{
				if( p.MainWindowHandle != IntPtr.Zero)
				{
					// Process name gets truncated!
					if(p.ProcessName == "XPMenus")
					{
						bRunning = true;
						MessageBox.Show("Activating the already open instance of XPMenus.exe.");
						SetForegroundWindow(p.MainWindowHandle);
						break;
					}
				}
			}
			if(!bRunning)
			{
                Application.Run(mainForm);
				OnAppShutDown();
			}		
		}


		#region VERSIONING
		private static bool safeModeOn = false;
		static void SafeModeCheck()
		{
			object value;
			RegistryKey regKey = Registry.CurrentUser;
			regKey = regKey.CreateSubKey("Software\\Syncfusion\\XPMenus");
			AppStateSerializer ass = new AppStateSerializer(SerializeMode.WindowsRegistry, regKey);
			value = ass.DeserializeObject("SafeModeFlag");

			if(value != null)
				safeModeOn = (bool)value;

			if(safeModeOn)
			{
				MessageBox.Show("Previous instantiation of this application did not shut down properly. Running in safe mode. User specific persisted information will not be loaded. You can turn off safe mode when the application exits.", "Safe Mode Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				AppStateSerializer.GetSingleton().Enabled = false;
			}
			else
			{
				RegistryKey key = Registry.CurrentUser;
				key = key.CreateSubKey("Software\\Syncfusion\\XPMenus");
				// turn on safe mode (will be reset if app closed safely)
				ass.SerializeObject("SafeModeFlag", (object)true);
			}
		}

		static void OnAppShutDown()
		{
			RegistryKey regKey = Registry.CurrentUser;
			regKey = regKey.CreateSubKey("Software\\Syncfusion\\XPMenus");

			bool resetFlag = false;
			if(safeModeOn)
			{
				DialogResult dlgResult = MessageBox.Show("Would you like to turn off Safe Mode?", "Safe Mode information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if(dlgResult == DialogResult.Yes)
					resetFlag = true;
			}
			else
				resetFlag = true;

			AppStateSerializer.GetSingleton().Enabled = true;

			if(resetFlag)
			{
				AppStateSerializer ass = new AppStateSerializer(SerializeMode.WindowsRegistry, regKey);
				ass.SerializeObject("SafeModeFlag", (object)false);
			}
		}

		static string VersionTag = "AppVersion";
		static void ValidatePersistedStateVersion(string curVersion)
		{
			// Versioning
			AppStateSerializer serializer = AppStateSerializer.GetSingleton();
			object objectOut = serializer.DeserializeObject(VersionTag);
			if(objectOut != null)
			{
				string version = (string)objectOut;
				version = version.ToLower();

				curVersion = curVersion.ToLower();

				// Persisted info is not the current version, lets lose it.
				if(version != curVersion)
					serializer.FlushSerializer();
			}
		}
		// Store the current version, so that we can validate it the next time.
		static void StoreVersionInfo(string curVersion)
		{
			AppStateSerializer serializer = AppStateSerializer.GetSingleton();
			serializer.SerializeObject(VersionTag, curVersion, true);
		}
		#endregion VERSIONING

		#region XPMenusInitialization

		private void Form1_Load(object sender, System.EventArgs e)
		{
			bool found = true;
			try
			{
				string filename1 = "..\\..\\logo.jpg";
				string filename2 = "..\\..\\Description.txt";
				this.AddDocument(new ImageEditorForm("..\\..\\logo.jpg"));
				this.AddDocument(new TextEditorForm("..\\..\\Description.txt"));
				this.mruFilesListItem.ChildCaptions.Add(filename1);
				this.mruFilesListItem.ChildCaptions.Add(filename2);
			}
			catch{found = false;}
			if(!found)
			{
				try
				{
					this.AddDocument(new ImageEditorForm("suite.gif"));
					this.AddDocument(new TextEditorForm("csharp.ini"));
					
				}
				catch{}
			}
			// Application specific initialization
			this.UpdateMenuItems();

            this.barManager1.Categories.Add("&Help1");

            this.baritem.BarName = "Bar";
            this.baritem.CategoryIndex = 3;
            this.baritem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baritem.ID = "&Help";
            this.baritem.MergeOrder = 20;
            this.baritem.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.baritem.ShowToolTipInPopUp = false;
            this.baritem.SizeToFit = true;
            this.baritem.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.baritem.Text = "&Help1";
            this.baritem.Selected += new System.EventHandler(this.Item_Selected);
            this.barManager1.Items.Add(baritem);
            this.bar1.Items.Add(baritem);
		}

        ParentBarItem baritem = new ParentBarItem();
		#endregion XPMenusInitialization

		#region SampleAppLogic
		private void AddDocument(Form newForm) 
		{
			newForm.MdiParent = this;
			newForm.Show();
		}

		private void openBarItem_Click(object sender, System.EventArgs e)
		{
			DocumentTypeSelectionDialog dlg = new DocumentTypeSelectionDialog();
			if(dlg.ShowDialog() != DialogResult.OK)
				return;

			int docType = dlg.SelectedType;

			this.openFileDialog1.FileName = String.Empty;
			if(docType == 0)
				this.openFileDialog1.Filter = "txt files (*.txt)|*.txt|All Files (*.*)|*.*";
			else if(docType == 1)
				this.openFileDialog1.Filter = "Image Files (*.bmp; *.ico; *.jpg)|*.bmp;*.ico;*.jpg|All Files (*.*)|*.*";

			if(this.openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				string filename = this.openFileDialog1.FileName;
				filename = filename.ToLower();
				//if(filename.IndexOf(".txt") != -1)
				this.mruFilesListItem.ChildCaptions.Add(filename);

				if(docType == 0)
				{
					// Text file opened
					TextEditorForm childForm = new TextEditorForm(filename);
					this.AddDocument(childForm);
				}
				else if(docType == 1)
				{
					try
					{
						ImageEditorForm imageEditor = new ImageEditorForm(filename);
						this.AddDocument(imageEditor);
					}
					catch{};
				}
			}
		}
		
		private void closeBarItem_Click(object sender, System.EventArgs e)
		{
			Form activeChild = this.ActiveMdiChild;
			if(activeChild != null)
				activeChild.Close();
		}

		private void MainForm_MdiChildActivate(object sender, System.EventArgs e)
		{
			this.UpdateMenuItems();
		}

		private void UpdateMenuItems()
		{
			if(this.ActiveMdiChild != null)
			{
				this.closeBarItem.Enabled = true;
				this.WindowsMenu.Enabled = true;
			}
			else
			{
				this.closeBarItem.Enabled = false;
				this.WindowsMenu.Enabled = false;
			}
		}

		private void exitBarItem_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		
		private void cascadeBarItem_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(MdiLayout.Cascade);
		}

		private void tileHBarItem_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void tileVBarItem_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileVertical);
		}
		#endregion SampleAppLogic
	
		#region AboutForm_Logic
		DemoCommon.AboutForm aboutForm = null;
		private void barItem13_Click(object sender, System.EventArgs e)
		{
			aboutForm = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
			aboutForm.ShowDialog();
		}
        /// <summary>
        /// Click event for office2016Colorful visualstyle 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barItem14_Click(object sender, System.EventArgs e)
        {
            this.barManager1.Style = VisualStyle.Office2016Colorful;
        }
        /// <summary>
        /// Click event for office201White visualstyle 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barItem15_Click(object sender, System.EventArgs e)
        {
            this.barManager1.Style = VisualStyle.Office2016White;
        }
        /// <summary>
        /// Click event for office2016DarkGray visualstyle 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barItem16_Click(object sender, System.EventArgs e)
        {
            this.barManager1.Style = VisualStyle.Office2016DarkGray;
        }
        /// <summary>
        /// Click event for office2016Black visualstyle 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barItem17_Click(object sender, System.EventArgs e)
        {
            this.barManager1.Style = VisualStyle.Office2016Black;
        }
        /// <summary>
        /// Click event for Metro visualstyle 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Metro_Click(object sender, System.EventArgs e)
        {
            this.barManager1.Style = VisualStyle.Metro;
        }
        /// <summary>
        /// Click event for Office2007 visualstyle 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Office2007_Click(object sender, System.EventArgs e)
        {
            this.barManager1.Style = VisualStyle.Office2007;
        }
        /// <summary>
        /// Click event for Office2010 visualstyle 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Office2010_Click(object sender, System.EventArgs e)
        {
            this.barManager1.Style = VisualStyle.Office2010;
        }
		private void AboutFormCloseBtnClicked(object sender, EventArgs e)
		{
			aboutForm.Close();
		}
		#endregion AboutForm_Logic

		internal void HideToolBar()
		{
			this.barManager1.GetCommandBarManager().SetBarVisibility(this.bar2, false);
		}

		private void Item_Selected(object sender, System.EventArgs e)
		{
			BarItem item = sender as BarItem;
			this.staticBarItem1.Text = item.Text;
		}

		private void themesItem_Click(object sender, System.EventArgs e)
		{
            this.Office2003Item.Checked = false;
            this.VS2005Item.Checked = false;
            this.Outlook2007Item.Checked = false;

			this.themesItem.Checked = !this.themesItem.Checked;
            this.barManager1.Style = VisualStyle.Default;
            if (this.themesItem.Checked)
                this.barManager1.ThemesEnabled = true;
            else
                this.barManager1.ThemesEnabled = false;
		}

        // Office 2003 Item
		private void barItem1_Click(object sender, System.EventArgs e)
		{
            this.themesItem.Checked = false;
            this.VS2005Item.Checked = false;
            this.Outlook2007Item.Checked = false;
            this.barManager1.ThemesEnabled = false;

			this.Office2003Item.Checked =!this.Office2003Item.Checked;
            this.barManager1.Style = VisualStyle.Default;
			if(this.Office2003Item.Checked)
			{
				this.barManager1.Style = VisualStyle.Office2003;
			}
			else
			{
				this.barManager1.Style = VisualStyle.OfficeXP;
			}
		}

       

        private void VS2005Item_Click(object sender, EventArgs e)
        {
            this.Office2003Item.Checked = false;
            this.themesItem.Checked = false;
            this.barManager1.ThemesEnabled = false;
            this.Outlook2007Item.Checked = false;

            this.VS2005Item.Checked = !this.VS2005Item.Checked;
            if (this.VS2005Item.Checked)
            {
                this.barManager1.Style = VisualStyle.VS2005;
            }
            else
            {
                this.barManager1.Style = VisualStyle.OfficeXP;
            }
        }

        private void Outlook2007Item_Click(object sender, EventArgs e)
        {
            this.Office2003Item.Checked = false;
            this.themesItem.Checked = false;
            //this.barManager1.ThemesEnabled = false;
            this.VS2005Item.Checked = false;

            this.Outlook2007Item.Checked = !this.Outlook2007Item.Checked;
            if (this.Outlook2007Item.Checked)
            {
                this.barManager1.Style = VisualStyle.Office2007Outlook;
            }
            else
            {
                this.barManager1.Style = VisualStyle.OfficeXP;
            }
        }

        private void barItem2_Click(object sender, EventArgs e)
        {
            this.Office2003Item.Checked = false;
            this.VS2005Item.Checked = false;
            this.Outlook2007Item.Checked = false;
            this.themesItem.Checked = false;

            this.barManager1.Style = VisualStyle.Office2007;
            this.barManager1.Office2007Theme = Office2007Theme.Blue;
        }

        private void barItem3_Click(object sender, EventArgs e)
        {
            this.Office2003Item.Checked = false;
            this.VS2005Item.Checked = false;
            this.Outlook2007Item.Checked = false;
            this.themesItem.Checked = false;

            this.barManager1.Style = VisualStyle.Office2007;
            this.barManager1.Office2007Theme = Office2007Theme.Silver;
        }

        private void barItem1_Click_1(object sender, EventArgs e)
        {
            this.Office2003Item.Checked = false;
            this.VS2005Item.Checked = false;
            this.Outlook2007Item.Checked = false;
            this.themesItem.Checked = false;

            this.barManager1.Style = VisualStyle.Office2007;
            this.barManager1.Office2007Theme = Office2007Theme.Black;
        }

        private void colorPickerUIAdv1_Picked(object sender, ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            this.Office2003Item.Checked = false;
            this.VS2005Item.Checked = false;
            this.Outlook2007Item.Checked = false;
            this.themesItem.Checked = false;

            this.barManager1.Style = VisualStyle.Office2007;
            this.barManager1.Office2007Theme = Office2007Theme.Managed;
            Office2007Colors.ApplyManagedColors(this, args.Color);
            this.dropDownBarItem2.Checked = true;
            this.dropDownBarItem2.PopupControlContainer.HidePopup(PopupCloseType.Done);

        }

	}
}
