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
	using System.Windows.Forms;
	using System.IO;
	using System.Diagnostics;

	using Syncfusion.Windows.Forms.Tools;
	using Syncfusion.Windows.Forms.Tools.XPMenus;
	using Syncfusion.Windows.Forms;

	/// <summary>
	/// Summary description for TextEditorForm.
	/// </summary>
	public class TextEditorForm : MetroForm
	{
		private Image baseImage;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ChildFrameBarManager barManager1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu popupMenu1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolTip toolTip1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem4;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem cutBarItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem copyBarItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem pasteBarItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem fontColorBarItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem editMenu;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.ComponentModel.IContainer components;
		private string sourceFile;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem selAllBarItem;
		private Syncfusion.Windows.Forms.PopupControlContainer popupControlContainer1;
		private Syncfusion.Windows.Forms.ColorUIControl colorUIControl1;
		private System.Windows.Forms.ImageList largeImageList;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem findItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem3;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem5;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem3;
		private Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenusManager popupMenusManager1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar2;
		private Syncfusion.Windows.Forms.FocuslessListBox undoList;
		private Syncfusion.Windows.Forms.PopupControlContainer undoPopup;
		private System.Windows.Forms.Label undoLabel;
		private Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem dropDownBarItem1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar3;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem saveItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem4;
		private Syncfusion.Windows.Forms.Tools.FontListBox fontListBox1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem fontcomboBoxBarItem1;
		private static int instanceCount = 0;

		public TextEditorForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
           try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }

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
		// Leave the default constructor above. The XP Menus frameworks expects a default
		// constructor to be available for every child form.
		public TextEditorForm(string sourceFile)
		{
			this.sourceFile = sourceFile;
			this.InitializeComponent();
			
			instanceCount++;
			this.Text = "Text Editor" + instanceCount.ToString();

			// The SourceFile needs to be set before load gets called.
			this.InitFromSourceFile();
			
			this.richTextBox1.SelectionStart = 0;
            this.richTextBox1.ScrollToCaret();
			
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditorForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.barManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ChildFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.barManager1, "MainMenu");
            this.parentBarItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.saveItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.editMenu = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.dropDownBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem();
            this.undoPopup = new Syncfusion.Windows.Forms.PopupControlContainer();
            this.undoLabel = new System.Windows.Forms.Label();
            this.undoList = new Syncfusion.Windows.Forms.FocuslessListBox();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.cutBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.copyBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.pasteBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.findItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem();
            this.fontColorBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem();
            this.popupControlContainer1 = new Syncfusion.Windows.Forms.PopupControlContainer();
            this.colorUIControl1 = new Syncfusion.Windows.Forms.ColorUIControl();
            this.selAllBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.bar2 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.barManager1, "Text Edit");
            this.fontcomboBoxBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem();
            this.fontListBox1 = new Syncfusion.Windows.Forms.Tools.FontListBox();
            this.bar3 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.barManager1, "Standard");
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.parentBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.largeImageList = new System.Windows.Forms.ImageList(this.components);
            this.popupMenu1 = new Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.popupMenusManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenusManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.undoPopup.SuspendLayout();
            this.popupControlContainer1.SuspendLayout();
            this.SuspendLayout();
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
            // 
            // barManager1
            // 
            this.barManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("barManager1.BarPositionInfo")));
            this.barManager1.Bars.Add(this.bar1);
            this.barManager1.Bars.Add(this.bar2);
            this.barManager1.Bars.Add(this.bar3);
            this.barManager1.Categories.Add("Edit");
            this.barManager1.Categories.Add("Standard");
            this.barManager1.CurrentBaseFormType = "System.Windows.Forms.Form";
            this.barManager1.Form = this;
            this.barManager1.FormName = "Text Editor";
            this.barManager1.ImageList = this.imageList1;
            this.barManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem4,
            this.dropDownBarItem1,
            this.editMenu,
            this.barItem2,
            this.cutBarItem,
            this.copyBarItem,
            this.pasteBarItem,
            this.fontColorBarItem,
            this.selAllBarItem,
            this.findItem,
            this.barItem3,
            this.barItem5,
            this.parentBarItem2,
            this.parentBarItem3,
            this.saveItem,
            this.fontcomboBoxBarItem1});
            this.barManager1.LargeImageList = this.largeImageList;
            this.barManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            // 
            // bar1
            // 
            this.bar1.BarName = "MainMenu";
            this.bar1.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder)));
            this.bar1.Caption = "MainMenu";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem4,
            this.editMenu});
            this.bar1.Manager = this.barManager1;
            // 
            // parentBarItem4
            // 
            this.parentBarItem4.CategoryIndex = 0;
            this.parentBarItem4.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem4.ID = "&File";
            this.parentBarItem4.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.saveItem});
            this.parentBarItem4.MergeOrder = 1;
            this.parentBarItem4.Text = "&File";            
            this.parentBarItem4.Selected += new System.EventHandler(this.Bar_Selected);
            // 
            // saveItem
            // 
            this.saveItem.CategoryIndex = 1;
            this.saveItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveItem.ID = "&Save";
            this.saveItem.ImageIndex = 6;
            this.saveItem.MergeOrder = 2;
            this.saveItem.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.saveItem.Text = "&Save";
            this.saveItem.Tooltip = "Save Text (Ctrl + S)";
            this.saveItem.Selected += new System.EventHandler(this.Bar_Selected);
            this.saveItem.Click += new System.EventHandler(this.saveItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.CategoryIndex = 0;
            this.editMenu.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editMenu.ID = "&Edit";
            this.editMenu.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.dropDownBarItem1,
            this.barItem2,
            this.cutBarItem,
            this.copyBarItem,
            this.pasteBarItem,
            this.findItem,
            this.fontColorBarItem,
            this.selAllBarItem});
            this.editMenu.MergeOrder = 2;
            this.editMenu.SeparatorIndices.AddRange(new int[] {
            2,
            5});
            this.editMenu.Text = "&Edit";
            this.editMenu.Selected += new System.EventHandler(this.Bar_Selected);
            // 
            // dropDownBarItem1
            // 
            this.dropDownBarItem1.CategoryIndex = 0;
            this.dropDownBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownBarItem1.ID = "&Undo";
            this.dropDownBarItem1.ImageIndex = 4;
            this.dropDownBarItem1.MergeType = System.Windows.Forms.MenuMerge.Replace;
            this.dropDownBarItem1.PopupControlContainer = this.undoPopup;
            this.dropDownBarItem1.Text = "&Undo";
            this.dropDownBarItem1.Selected += new System.EventHandler(this.Bar_Selected);
            // 
            // undoPopup
            // 
            this.undoPopup.BackColor = System.Drawing.SystemColors.Window;
            this.undoPopup.Controls.Add(this.undoLabel);
            this.undoPopup.Controls.Add(this.undoList);
            this.undoPopup.Location = new System.Drawing.Point(16, 16);
            this.undoPopup.Name = "undoPopup";
            this.undoPopup.Padding = new System.Windows.Forms.Padding(1);
            this.undoPopup.Size = new System.Drawing.Size(104, 130);
            this.undoPopup.TabIndex = 6;
            this.undoPopup.Visible = false;
            this.undoPopup.BeforePopup += new System.ComponentModel.CancelEventHandler(this.undoPopup_BeforePopup);
            this.undoPopup.CloseUp += new Syncfusion.Windows.Forms.PopupClosedEventHandler(this.undoPopup_CloseUp);
            // 
            // undoLabel
            // 
            this.undoLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.undoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.undoLabel.Location = new System.Drawing.Point(1, 92);
            this.undoLabel.Name = "undoLabel";
            this.undoLabel.Size = new System.Drawing.Size(102, 37);
            this.undoLabel.TabIndex = 1;
            this.undoLabel.Text = "label1";
            this.undoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.undoLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.undoLabel_MouseDown);
            // 
            // undoList
            // 
            this.undoList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.undoList.CausesValidation = false;
            this.undoList.Dock = System.Windows.Forms.DockStyle.Top;
            this.undoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undoList.Items.AddRange(new object[] {
            "One",
            "Two",
            "Three",
            "Four",
            "Five",
            "Six",
            "Seven",
            "Eight",
            "Nine",
            "Ten",
            "Eleven",
            "Twelve",
            "Thirteen",
            "Fourteen",
            "Fifteen",
            "Sixteen",
            "Seventeen"});
            this.undoList.Location = new System.Drawing.Point(1, 1);
            this.undoList.Name = "undoList";
            this.undoList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.undoList.Size = new System.Drawing.Size(102, 91);
            this.undoList.TabIndex = 0;
            this.undoList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.undoList_MouseUp);
            this.undoList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.undoList_MouseMove);
            this.undoList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.undoList_MouseDown);
            // 
            // barItem2
            // 
            this.barItem2.CategoryIndex = 0;
            this.barItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem2.ID = "Re&do";
            this.barItem2.ImageIndex = 5;
            this.barItem2.Text = "Re&do";
            this.barItem2.Selected += new System.EventHandler(this.Bar_Selected);
            this.barItem2.Click += new System.EventHandler(this.barItem2_Click);
            // 
            // cutBarItem
            // 
            this.cutBarItem.CategoryIndex = 0;
            this.cutBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cutBarItem.ID = "Cu&t";
            this.cutBarItem.ImageIndex = 1;
            this.cutBarItem.Text = "Cu&t";
            this.cutBarItem.Selected += new System.EventHandler(this.Bar_Selected);
            this.cutBarItem.Click += new System.EventHandler(this.cutBarItem_Click);
            // 
            // copyBarItem
            // 
            this.copyBarItem.CategoryIndex = 0;
            this.copyBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyBarItem.ID = "&Copy";
            this.copyBarItem.ImageIndex = 0;
            this.copyBarItem.Text = "&Copy";
            this.copyBarItem.Selected += new System.EventHandler(this.Bar_Selected);
            this.copyBarItem.Click += new System.EventHandler(this.copyBarItem_Click);
            // 
            // pasteBarItem
            // 
            this.pasteBarItem.CategoryIndex = 0;
            this.pasteBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasteBarItem.ID = "&Paste";
            this.pasteBarItem.ImageIndex = 2;
            this.pasteBarItem.Text = "&Paste";
            this.pasteBarItem.Selected += new System.EventHandler(this.Bar_Selected);
            this.pasteBarItem.Click += new System.EventHandler(this.pasteBarItem_Click);
            // 
            // findItem
            // 
            this.findItem.AutoAppend = true;
            this.findItem.CategoryIndex = 0;
            this.findItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findItem.ID = "Find";
            this.findItem.MinWidth = 80;
            this.findItem.Text = "Find";
            this.findItem.Selected += new System.EventHandler(this.Bar_Selected);
            this.findItem.Click += new System.EventHandler(this.findItem_Click);
            // 
            // fontColorBarItem
            // 
            this.fontColorBarItem.CategoryIndex = 0;
            this.fontColorBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontColorBarItem.ID = "&Font Color";
            this.fontColorBarItem.ImageIndex = 3;
            this.fontColorBarItem.PopupControlContainer = this.popupControlContainer1;
            this.fontColorBarItem.Text = "&Font Color";
            this.fontColorBarItem.Selected += new System.EventHandler(this.Bar_Selected);
            this.fontColorBarItem.Click += new System.EventHandler(this.fontColorBarItem_Click);
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.popupControlContainer1.Controls.Add(this.colorUIControl1);
            this.popupControlContainer1.Location = new System.Drawing.Point(176, 32);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Padding = new System.Windows.Forms.Padding(1);
            this.popupControlContainer1.Size = new System.Drawing.Size(208, 200);
            this.popupControlContainer1.TabIndex = 5;
            this.popupControlContainer1.Visible = false;
            this.popupControlContainer1.Popup += new System.EventHandler(this.popupControlContainer1_Popup);
            // 
            // colorUIControl1
            // 
            this.colorUIControl1.BackColor = System.Drawing.SystemColors.Control;
            this.colorUIControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorUIControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorUIControl1.Location = new System.Drawing.Point(1, 1);
            this.colorUIControl1.Name = "colorUIControl1";
            this.colorUIControl1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors;
            this.colorUIControl1.Size = new System.Drawing.Size(206, 198);
            this.colorUIControl1.TabIndex = 0;
            this.colorUIControl1.Text = "colorUIControl1";
            this.colorUIControl1.UserTabName = "User Colors";
            this.colorUIControl1.ColorSelected += new System.EventHandler(this.colorUIControl1_ColorSelected);
            // 
            // selAllBarItem
            // 
            this.selAllBarItem.CategoryIndex = 0;
            this.selAllBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selAllBarItem.ID = "Select &All";
            this.selAllBarItem.IsRecentlyUsedItem = false;
            this.selAllBarItem.Text = "Select &All";
            this.selAllBarItem.Selected += new System.EventHandler(this.Bar_Selected);
            this.selAllBarItem.Click += new System.EventHandler(this.selAllBarItem_Click);
            // 
            // bar2
            // 
            this.bar2.BarName = "Text Edit";
            this.bar2.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder)));
            this.bar2.Caption = "Text Edit";
            this.bar2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.cutBarItem,
            this.copyBarItem,
            this.pasteBarItem,
            this.fontColorBarItem,
            this.findItem,
            this.dropDownBarItem1,
            this.barItem2,
            this.fontcomboBoxBarItem1});
            this.bar2.Manager = this.barManager1;
            // 
            // fontcomboBoxBarItem1
            // 
            this.fontcomboBoxBarItem1.CategoryIndex = 0;
            this.fontcomboBoxBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontcomboBoxBarItem1.Editable = false;
            this.fontcomboBoxBarItem1.ID = "fontCombo";
            this.fontcomboBoxBarItem1.ListBox = this.fontListBox1;
            this.fontcomboBoxBarItem1.MinWidth = 100;
            this.fontcomboBoxBarItem1.Text = "Font Selection";
            this.fontcomboBoxBarItem1.Click += new System.EventHandler(this.fontComboBoxBarItem1_Click);
            // 
            // fontListBox1
            // 
            this.fontListBox1.ItemHeight = 15;
            this.fontListBox1.Location = new System.Drawing.Point(24, 96);
            this.fontListBox1.Name = "fontListBox1";
            this.fontListBox1.Size = new System.Drawing.Size(128, 124);
            this.fontListBox1.TabIndex = 7;
            // 
            // bar3
            // 
            this.bar3.BarName = "Standard";
            this.bar3.Caption = "Standard";
            this.bar3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.saveItem});
            this.bar3.Manager = this.barManager1;
            // 
            // barItem3
            // 
            this.barItem3.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem3.ID = "Item 1";
            this.barItem3.Text = "Item 1";
            // 
            // barItem5
            // 
            this.barItem5.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem5.ID = "Item 2";
            this.barItem5.Text = "Item 2";
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem2.ID = "Parent Item 1";
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem3});
            this.parentBarItem2.Text = "Parent Item 1";
            // 
            // parentBarItem3
            // 
            this.parentBarItem3.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem3.ID = "Parent 2";
            this.parentBarItem3.Text = "Parent 2";
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
            // popupMenu1
            // 
            this.popupMenu1.ParentBarItem = this.editMenu;
            // 
            // barItem4
            // 
            this.barItem4.CategoryIndex = 0;
            this.barItem4.ID = "Test";
            this.barItem4.Text = "Test";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.HideSelection = false;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(532, 358);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.popupMenusManager1.SetXPContextMenu(this.richTextBox1, this.popupMenu1);
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);            
            
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem3,
            this.barItem5,
            this.parentBarItem2});
            this.parentBarItem1.SeparatorIndices.AddRange(new int[] {
            1});
            // 
            // TextEditorForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(532, 358);
            this.Controls.Add(this.fontListBox1);
            this.Controls.Add(this.undoPopup);
            this.Controls.Add(this.popupControlContainer1);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TextEditorForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Text Editor";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.undoPopup.ResumeLayout(false);
            this.popupControlContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		#region SampleAppLogic
		private void ClientForm_Load(object sender, System.EventArgs e)
		{
			// Updated the enabled/disabled state of the menu items.
			this.UpdateMenuItems();
			// Update the Font Color BarItem image.
			this.InitBaseImage();
			this.colorUIControl1.SelectedColor = Color.Black;
		}

		private void InitFromSourceFile()
		{
			if(this.sourceFile != String.Empty)
			{
				FileInfo file = new FileInfo(this.sourceFile);
				StreamReader r = file.OpenText();
				this.richTextBox1.SelectedText = r.ReadToEnd();
				r.Close();
			}
		}

		#endregion SampleAppLogic

		private void cutBarItem_Click(object sender, System.EventArgs e)
		{
			this.richTextBox1.Cut();
		}

		private void richTextBox1_SelectionChanged(object sender, System.EventArgs e)
		{
			this.UpdateMenuItems();
		}

		private void barItem2_Click(object sender, System.EventArgs e)
		{
			this.richTextBox1.Redo();
		}
		
		private void saveItem_Click(object sender, System.EventArgs e)
		{
			string filename="";
			SaveFileDialog savefDlg = new SaveFileDialog();
			savefDlg.Filter = "text files(*.txt)|*.txt";

			if (savefDlg.ShowDialog() == DialogResult.OK)
			{
				filename = savefDlg.FileName;
				StreamWriter wstr = new StreamWriter(filename, false, System.Text.Encoding.Unicode);

				foreach(string line in richTextBox1.Lines)
					wstr.WriteLine(line);
				wstr.Close();
			}
		}

		private void UpdateMenuItems()
		{
			if(this.richTextBox1.SelectedText.Length > 0)
			{
				this.copyBarItem.Enabled = true;
				this.cutBarItem.Enabled = true;
			}
			else
			{
				this.copyBarItem.Enabled = false;
				this.cutBarItem.Enabled = false;
			}
		}

		private void copyBarItem_Click(object sender, System.EventArgs e)
		{
			this.richTextBox1.Copy();
		}

		private void pasteBarItem_Click(object sender, System.EventArgs e)
		{
			this.richTextBox1.Paste();
		}

		private void selAllBarItem_Click(object sender, System.EventArgs e)
		{
			this.richTextBox1.SelectAll();
		}

		#region COLORUI_DROPDOWN

		private void fontColorBarItem_Click(object sender, System.EventArgs e)
		{
			// Set the selection's color to be the ColorUI's Selected Color.
			this.richTextBox1.SelectionColor = this.colorUIControl1.SelectedColor;
		}

		private void colorUIControl1_ColorSelected(object sender, System.EventArgs e)
		{
			this.fontColorBarItem_Click(sender, e);

			this.UpdateDropdownImageColor(this.colorUIControl1.SelectedColor);
			// Close the popup, now that a Color was selected
			this.popupControlContainer1.HidePopup(PopupCloseType.Done);
		}
		private void UpdateDropdownImageColor(Color newColor)
		{
			// Create a new bitmap off the base image.
			Image newImage = this.baseImage.Clone() as Image;
			Bitmap newBitmap = new Bitmap(newImage);
			
			// Set the Color cue pixels to the appropriate color.
			for(int i = 12; i <= 14; i++)
				for(int j = 2; j <= 14; j++)
					newBitmap.SetPixel(j, i, this.colorUIControl1.SelectedColor);

			// Update the image stored in the imagelist to this new image.
			this.imageList1.Images[this.fontColorBarItem.ImageIndex] = newBitmap;
		}
		private void InitBaseImage()
		{
			// Store this for use later when the selected color changes in ColorUI control.
			this.baseImage = this.imageList1.Images[this.fontColorBarItem.ImageIndex].Clone() as Image;
		}
		#endregion COLORUI_DROPDOWN

		private void findItem_Click(object sender, System.EventArgs e)
		{

//			int str = this.richTextBox1.Find(this.findItem.TextBoxValue);
//			this.richTextBox1.Select(str , this.findItem.TextBoxValue.Length);
			if(this.findItem.TextBoxValue != String.Empty)
			{
				// Determine the starting location of the word.
				string searchString = this.findItem.TextBoxValue;
				int searchBeginIndex = this.richTextBox1.SelectionStart + this.richTextBox1.SelectionLength;
				string sourceString = this.richTextBox1.Text.Substring(searchBeginIndex);
				int index = sourceString.IndexOf(searchString);

				if(index == -1)
				{
					searchBeginIndex = 0;
					sourceString = this.richTextBox1.Text.Substring(searchBeginIndex);
					index = sourceString.IndexOf(searchString);
				}

				// Determine if the word has been found and select it if it was.
				if (index != -1)
				{
					// Select the string using the index and the length of the string.
					this.richTextBox1.Select(searchBeginIndex + index, this.findItem.TextBoxValue.Length);
				}
			}
		}

		
		private void fontComboBoxBarItem1_Click(object sender, System.EventArgs e)
		{
			this.richTextBox1.SelectionFont = new Font(this.fontcomboBoxBarItem1.TextBoxValue, 10);	
		}

		private void popupControlContainer1_Popup(object sender, System.EventArgs e)
		{
			this.colorUIControl1.Focus();
		}

		#region UNDO_UI
		private void undoPopup_BeforePopup(object sender, System.ComponentModel.CancelEventArgs e)
		{
			int count = this.undoList.Items.Count > 15 ? 15 : this.undoList.Items.Count;
			this.undoList.Height = this.undoList.ItemHeight * count;
			this.undoPopup.Height = this.undoList.Height + 26;
			this.undoPopup.PopupHost.OverlapBorderColor = SystemColors.ControlDarkDark;
		}
		
		private void Bar_Selected(object sender, System.EventArgs e)
		{
			
		}
		
		private void undoPopup_CloseUp(object sender, Syncfusion.Windows.Forms.PopupClosedEventArgs args)
		{
			if(args.PopupCloseType == PopupCloseType.Done)
			{
				// Undo Actions here based on selections in the listbox.
			}
			this.undoList.SelectedIndex = -1;
		}
		private void undoList_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			int index = this.undoList.IndexFromPoint(e.X, e.Y);
			if(index != -1)
				this.undoList.SetSelected(index, true);
		}

		private void undoList_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			int index = this.undoList.IndexFromPoint(e.X, e.Y);
			if(index != -1)
			{
				ListBox.SelectedIndexCollection selectedIndices = this.undoList.SelectedIndices;
				for(int i = index; i >= 0; i--)
				{
					if(!selectedIndices.Contains(i))
						this.undoList.SetSelected(i, true);
				}

				for(int i = index + 1; i < this.undoList.Items.Count; i++)
				{
					if(selectedIndices.Contains(i))
						this.undoList.SetSelected(i, false);
				}

				index++;
				this.undoLabel.Text = "Undo " + index.ToString() + " Actions.";
			}
		}

		private void undoList_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.undoPopup.HidePopup(PopupCloseType.Done);
		}
		
		private void undoLabel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.undoPopup.HidePopup(PopupCloseType.Deactivated);
		}
		#endregion UNDO_UI
	}
}
