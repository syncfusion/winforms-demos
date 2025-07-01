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

namespace MDIMerge
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
    using System.Runtime.InteropServices;
    using Syncfusion.Windows.Forms.Tools;
    using Syncfusion.Windows.Forms.Tools.XPMenus;
    using Syncfusion.Win32;
    using Syncfusion.Runtime.Serialization;
    using Syncfusion.Windows.Forms;
    using Syncfusion.WinForms.Controls;
    using System.Windows.Forms;
    using Syncfusion.HighContrastTheme.WinForms;

    /// <summary>
    /// Summary description for MainForm.
    /// </summary>
    public partial class MainForm : SfForm
    {
        #region Variables

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
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem openBarItem;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem closeBarItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.MdiListBarItem mdiListBarItem1;
		private System.Windows.Forms.ImageList largeImageList;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ToolbarListBarItem toolbarListBarItem1;
        private BarItem barItem4;
        private ParentBarItem parentBarItem6;
        private PopupControlContainer popupControlContainer2;
        private ColorPickerUIAdv colorPickerUIAdv1;
        private DropDownBarItem dropDownBarItem2;
		private System.ComponentModel.IContainer components;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        extern public static bool SetForegroundWindow(IntPtr hwnd);
        ParentBarItem baritem = new ParentBarItem();

        #endregion

        #region Constructor

        public MainForm()
		{
			InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
        }

        #endregion

        #region Function

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

        #region Events

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

		private void Form1_Load(object sender, System.EventArgs e)
		{
			bool found = true;
			try
			{
				this.AddDocument(new ImageEditorForm("..\\..\\logo.jpg"));
				this.AddDocument(new TextEditorForm("..\\..\\Description.txt"));
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

            this.barManager1.Categories.Add("&Help1");

            this.baritem.BarName = "Bar";
            this.baritem.CategoryIndex = 3;
            this.baritem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baritem.ID = "&Help";
            this.baritem.MergeOrder = 20;
            this.baritem.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.baritem.ShowToolTipInPopUp = false;
            this.baritem.SizeToFit = true;
            this.baritem.Text = "&Help1";
            this.barManager1.Items.Add(baritem);
            this.bar1.Items.Add(baritem);
            this.barManager1.ThemeName = "Office2019Colorful";
            this.dropDownBarItem2.UpdateUIOnAppIdle = true;
            this.dropDownBarItem2.UpdateUI += new EventHandler(dropDownBarItem2_UpdateUI);
            this.barManager1.RegisterMdiChildTypes(new Type[]
							{
								typeof(TextEditorForm),
								typeof(ImageEditorForm)
							});
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

		private void exitBarItem_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

        #endregion

        #region Function

        internal void HideToolBar()
        {
            this.barManager1.GetCommandBarManager().SetBarVisibility(this.bar2, false);
        }

		private void AddDocument(Form newForm) 
		{
			newForm.MdiParent = this;
			newForm.Show();
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
            this.parentBarItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.toolbarListBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ToolbarListBarItem();
            this.mdiListBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MdiListBarItem();
            this.parentBarItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.bar2 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.barManager1, "Standard");
            this.dropDownBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem();
            this.popupControlContainer2 = new Syncfusion.Windows.Forms.PopupControlContainer();
            this.colorPickerUIAdv1 = new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv();
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
#if !NETCORE
            this.barManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("barManager1.BarPositionInfo")));
#endif
            this.barManager1.ThemeName = "Office2019Colorful";
            this.barManager1.Bars.Add(this.bar1);
            //this.barManager1.Bars.Add(this.bar2);
            this.barManager1.Categories.Add("File");
            this.barManager1.Categories.Add("View");
            this.barManager1.Categories.Add("Window");
            this.barManager1.Categories.Add("&Help");
            this.barManager1.Categories.Add("StatusBar");
            this.barManager1.EnableMenuMerge = true;
            this.barManager1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.barManager1.Form = this;
            this.barManager1.ImageList = this.imageList1;
            this.barManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.openBarItem,
            this.closeBarItem,
            this.parentBarItem4,
            this.mdiListBarItem1,
            this.toolbarListBarItem1,
            this.dropDownBarItem2,
            this.parentBarItem6});
            this.barManager1.LargeImageList = this.largeImageList;
            this.barManager1.ResetCustomization = false;
            this.barManager1.UseBackwardCompatiblity = false;
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
            this.parentBarItem6});
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
            this.closeBarItem});
            this.parentBarItem1.MergeOrder = 1;
            this.parentBarItem1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem1.SeparatorIndices.AddRange(new int[] {
            2,
            3});
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem1.Text = "&File";
            this.parentBarItem1.WrapLength = 20;
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
            this.parentBarItem4.WrapLength = 20;
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
            this.toolbarListBarItem1.WrapLength = 20;
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
            // parentBarItem6
            // 
            this.parentBarItem6.BarName = "parentBarItem6";
            this.parentBarItem6.CategoryIndex = 5;
            this.parentBarItem6.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem6.ID = "&Help";
            this.parentBarItem6.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] { });
            this.parentBarItem6.MergeOrder = 21;
            this.parentBarItem6.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem6.ShowToolTipInPopUp = false;
            this.parentBarItem6.SizeToFit = true;
            this.parentBarItem6.Text = "&Help";
            this.parentBarItem6.WrapLength = 20;
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
            this.popupControlContainer2.Location = new System.Drawing.Point(277, 241);
            this.popupControlContainer2.Name = "popupControlContainer2";
            this.popupControlContainer2.Size = new System.Drawing.Size(275, 294);
            this.popupControlContainer2.TabIndex = 10002;
            this.popupControlContainer2.Visible = false;
            // 
            // colorPickerUIAdv1.RecentGroup
            // 
            this.colorPickerUIAdv1.RecentGroup.HeaderHeight = 23;
            this.colorPickerUIAdv1.RecentGroup.Name = "Recent Colors";
            this.colorPickerUIAdv1.RecentGroup.Visible = false;
            // 
            // colorPickerUIAdv1.StandardGroup
            // 
            this.colorPickerUIAdv1.StandardGroup.HeaderHeight = 23;
            this.colorPickerUIAdv1.StandardGroup.Name = "Standard Colors";
            // 
            // colorPickerUIAdv1.ThemeGroup
            // 
            this.colorPickerUIAdv1.ThemeGroup.HeaderHeight = 23;
            this.colorPickerUIAdv1.ThemeGroup.IsSubItemsVisible = true;
            this.colorPickerUIAdv1.ThemeGroup.Name = "Theme Colors";
            // 
            // colorPickerUIAdv1
            // 
            this.colorPickerUIAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPickerUIAdv1.ButtonsHeight = 31;
            this.colorPickerUIAdv1.ColorItemSize = new System.Drawing.Size(21, 21);
            this.colorPickerUIAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorPickerUIAdv1.Location = new System.Drawing.Point(0, 0);
            this.colorPickerUIAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.colorPickerUIAdv1.MinimumSize = new System.Drawing.Size(136, 217);
            this.colorPickerUIAdv1.Name = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.Size = new System.Drawing.Size(275, 294);
            this.colorPickerUIAdv1.ThemeName = "Office2019Colorful";
            this.colorPickerUIAdv1.TabIndex = 10003;
            this.colorPickerUIAdv1.Text = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.VerticalItemsSpacing = 1;
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
            this.AutoScaleBaseSize = new System.Drawing.Size(4, 19);
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.WindowState = FormWindowState.Normal;
            this.Controls.Add(this.popupControlContainer2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = new System.Drawing.Icon(GetIconFile(@"..\\..\\\logo.ico"));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI Merge";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.popupControlContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            SkinManager.LoadAssembly(typeof(Syncfusion.WinForms.Themes.Office2019Theme).Assembly);
            SkinManager.LoadAssembly(typeof(HighContrastTheme).Assembly);
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
            MainForm mainForm = new MainForm();
            Application.Run(new MainForm());
        }
	}
}
