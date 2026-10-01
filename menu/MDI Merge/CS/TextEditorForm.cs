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
using Syncfusion.WinForms.Controls;

namespace MDIMerge
{
    /// <summary>
    /// Summary description for TextEditorForm.
    /// </summary>
    public class TextEditorForm : SfForm
    {
        #region Variables

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
		private Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem findItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem3;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem5;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem3;
		private Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenusManager popupMenusManager1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem saveItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem4;
		private static int instanceCount = 0;

        #endregion

        #region Constructor

        public TextEditorForm()
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

        #region Functions

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
			this.Text = "Child Form2";

			// The SourceFile needs to be set before load gets called.
			this.InitFromSourceFile();
			
			this.richTextBox1.SelectionStart = 0;
            this.richTextBox1.ScrollToCaret();
			
		}

        private void InitFromSourceFile()
        {
            if (this.sourceFile != String.Empty)
            {
                FileInfo file = new FileInfo(this.sourceFile);
                StreamReader r = file.OpenText();
                this.richTextBox1.SelectedText = r.ReadToEnd();
                r.Close();
            }
        }

        private void UpdateMenuItems()
        {
            if (this.richTextBox1.SelectedText.Length > 0)
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

        private void UpdateDropdownImageColor(Color newColor)
        {
            // Create a new bitmap off the base image.
            Image newImage = this.baseImage.Clone() as Image;
            Bitmap newBitmap = new Bitmap(newImage);

            // Set the Color cue pixels to the appropriate color.
            for (int i = 12; i <= 14; i++)
                for (int j = 2; j <= 14; j++)
                    newBitmap.SetPixel(j, i, this.colorUIControl1.SelectedColor);

            // Update the image stored in the imagelist to this new image.
            this.imageList1.Images[this.fontColorBarItem.ImageIndex] = newBitmap;
        }

        private void InitBaseImage()
        {
            // Store this for use later when the selected color changes in ColorUI control.
            this.baseImage = this.imageList1.Images[this.fontColorBarItem.ImageIndex].Clone() as Image;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditorForm));
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable1 = new Syncfusion.Windows.Forms.MetroColorTable();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.barManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ChildFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.barManager1, "MainMenu");
            this.parentBarItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.saveItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.editMenu = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.cutBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.copyBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.pasteBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.findItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem();
            this.fontColorBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem();
            this.popupControlContainer1 = new Syncfusion.Windows.Forms.PopupControlContainer();
            this.colorUIControl1 = new Syncfusion.Windows.Forms.ColorUIControl();
            this.selAllBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.findItem)).BeginInit();
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
#if !NETCORE
            this.barManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("barManager1.BarPositionInfo")));
#endif
            this.barManager1.Bars.Add(this.bar1);
            this.barManager1.Categories.Add("Edit");
            this.barManager1.Categories.Add("Standard");
            this.barManager1.CurrentBaseFormType = "Syncfusion.WinForms.Controls.SfForm";
            this.barManager1.EnableMenuMerge = true;
            this.barManager1.Form = this;
            this.barManager1.FormName = "Text Editor";
            this.barManager1.ImageList = this.imageList1;
            this.barManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem4,
            this.editMenu,
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
            this.saveItem});
            this.barManager1.LargeImageList = this.largeImageList;
            this.barManager1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.barManager1.ThemeName = "Office2019Colorful";
            this.barManager1.UseBackwardCompatiblity = false;
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
            this.parentBarItem4.BarName = "parentBarItem4";
            this.parentBarItem4.CategoryIndex = 0;
            this.parentBarItem4.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem4.ID = "&File";
            this.parentBarItem4.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.saveItem});
            this.parentBarItem4.MergeOrder = 1;
            this.parentBarItem4.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.parentBarItem4.ShowToolTipInPopUp = false;
            this.parentBarItem4.SizeToFit = true;
            this.parentBarItem4.Text = "&File";
            this.parentBarItem4.WrapLength = 20;
            // 
            // saveItem
            // 
            this.saveItem.BarName = "saveItem";
            this.saveItem.CategoryIndex = 1;
            this.saveItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveItem.ID = "&Save";
            this.saveItem.ImageIndex = 6;
            this.saveItem.MergeOrder = 2;
            this.saveItem.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.saveItem.ShowToolTipInPopUp = false;
            this.saveItem.SizeToFit = true;
            this.saveItem.Text = "&Save";
            this.saveItem.Tooltip = "Save Text (Ctrl + S)";
            this.saveItem.Click += new System.EventHandler(this.saveItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.BarName = "editMenu";
            this.editMenu.CategoryIndex = 0;
            this.editMenu.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editMenu.ID = "&Edit";
            this.editMenu.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.cutBarItem,
            this.copyBarItem,
            this.pasteBarItem,
            this.findItem,
            this.fontColorBarItem,
            this.selAllBarItem});
            this.editMenu.MergeOrder = 2;
            this.editMenu.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.editMenu.SeparatorIndices.AddRange(new int[] {
            2,
            5});
            this.editMenu.ShowToolTipInPopUp = false;
            this.editMenu.SizeToFit = true;
            this.editMenu.Text = "&Edit";
            this.editMenu.WrapLength = 20;
            // 
            // cutBarItem
            // 
            this.cutBarItem.BarName = "cutBarItem";
            this.cutBarItem.CategoryIndex = 0;
            this.cutBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cutBarItem.ID = "Cu&t";
            this.cutBarItem.ImageIndex = 1;
            this.cutBarItem.ShowToolTipInPopUp = false;
            this.cutBarItem.SizeToFit = true;
            this.cutBarItem.Text = "Cu&t";
            this.cutBarItem.Click += new System.EventHandler(this.cutBarItem_Click);
            // 
            // copyBarItem
            // 
            this.copyBarItem.BarName = "copyBarItem";
            this.copyBarItem.CategoryIndex = 0;
            this.copyBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyBarItem.ID = "&Copy";
            this.copyBarItem.ImageIndex = 0;
            this.copyBarItem.ShowToolTipInPopUp = false;
            this.copyBarItem.SizeToFit = true;
            this.copyBarItem.Text = "&Copy";
            this.copyBarItem.Click += new System.EventHandler(this.copyBarItem_Click);
            // 
            // pasteBarItem
            // 
            this.pasteBarItem.BarName = "pasteBarItem";
            this.pasteBarItem.CategoryIndex = 0;
            this.pasteBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasteBarItem.ID = "&Paste";
            this.pasteBarItem.ImageIndex = 2;
            this.pasteBarItem.ShowToolTipInPopUp = false;
            this.pasteBarItem.SizeToFit = true;
            this.pasteBarItem.Text = "&Paste";
            this.pasteBarItem.Click += new System.EventHandler(this.pasteBarItem_Click);
            // 
            // findItem
            // 
            this.findItem.AutoAppend = true;
            this.findItem.BarName = "findItem";
            this.findItem.CategoryIndex = 0;
            this.findItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findItem.ID = "Find";
            this.findItem.MinWidth = 80;
            this.findItem.ShowToolTipInPopUp = false;
            this.findItem.SizeToFit = true;
            this.findItem.Text = "Find";
            this.findItem.Click += new System.EventHandler(this.findItem_Click);
            // 
            // fontColorBarItem
            // 
            this.fontColorBarItem.BarName = "fontColorBarItem";
            this.fontColorBarItem.CategoryIndex = 0;
            this.fontColorBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontColorBarItem.ID = "&Font Color";
            this.fontColorBarItem.ImageIndex = 3;
            this.fontColorBarItem.PopupControlContainer = this.popupControlContainer1;
            this.fontColorBarItem.ShowToolTipInPopUp = false;
            this.fontColorBarItem.SizeToFit = true;
            this.fontColorBarItem.Text = "&Font Color";
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
            this.colorUIControl1.BeforeTouchSize = new System.Drawing.Size(206, 198);
            this.colorUIControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorUIControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorUIControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.colorUIControl1.Location = new System.Drawing.Point(1, 1);
            this.colorUIControl1.Name = "colorUIControl1";
            this.colorUIControl1.ScrollMetroColorTable = metroColorTable1;
            this.colorUIControl1.Size = new System.Drawing.Size(206, 198);
            this.colorUIControl1.TabIndex = 0;
            this.colorUIControl1.Text = "colorUIControl1";
            this.colorUIControl1.ThemeName = "Office2019Colorful";
            this.colorUIControl1.ColorSelected += new System.EventHandler(this.colorUIControl1_ColorSelected);
            // 
            // selAllBarItem
            // 
            this.selAllBarItem.BarName = "selAllBarItem";
            this.selAllBarItem.CategoryIndex = 0;
            this.selAllBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selAllBarItem.ID = "Select &All";
            this.selAllBarItem.IsRecentlyUsedItem = false;
            this.selAllBarItem.ShowToolTipInPopUp = false;
            this.selAllBarItem.SizeToFit = true;
            this.selAllBarItem.Text = "Select &All";
            this.selAllBarItem.Click += new System.EventHandler(this.selAllBarItem_Click);
            // 
            // barItem3
            // 
            this.barItem3.BarName = "barItem3";
            this.barItem3.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem3.ID = "Item 1";
            this.barItem3.ShowToolTipInPopUp = false;
            this.barItem3.SizeToFit = true;
            this.barItem3.Text = "Item 1";
            // 
            // barItem5
            // 
            this.barItem5.BarName = "barItem5";
            this.barItem5.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem5.ID = "Item 2";
            this.barItem5.ShowToolTipInPopUp = false;
            this.barItem5.SizeToFit = true;
            this.barItem5.Text = "Item 2";
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.BarName = "parentBarItem2";
            this.parentBarItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem2.ID = "Parent Item 1";
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem3});
            this.parentBarItem2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.parentBarItem2.ShowToolTipInPopUp = false;
            this.parentBarItem2.SizeToFit = true;
            this.parentBarItem2.Text = "Parent Item 1";
            this.parentBarItem2.WrapLength = 20;
            // 
            // parentBarItem3
            // 
            this.parentBarItem3.BarName = "parentBarItem3";
            this.parentBarItem3.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem3.ID = "Parent 2";
            this.parentBarItem3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.parentBarItem3.ShowToolTipInPopUp = false;
            this.parentBarItem3.SizeToFit = true;
            this.parentBarItem3.Text = "Parent 2";
            this.parentBarItem3.WrapLength = 20;
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
            this.barItem4.BarName = "barItem4";
            this.barItem4.CategoryIndex = 0;
            this.barItem4.ID = "Test";
            this.barItem4.ShowToolTipInPopUp = false;
            this.barItem4.SizeToFit = true;
            this.barItem4.Text = "Test";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.HideSelection = false;
            this.richTextBox1.Location = new System.Drawing.Point(2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(540, 388);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.popupMenusManager1.SetXPContextMenu(this.richTextBox1, this.popupMenu1);
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.BarName = "parentBarItem1";
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem3,
            this.barItem5,
            this.parentBarItem2});
            this.parentBarItem1.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem1.SeparatorIndices.AddRange(new int[] {
            1});
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.WrapLength = 20;
            // 
            // TextEditorForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(544, 392);
            this.Controls.Add(this.popupControlContainer1);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TextEditorForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Child Form2";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findItem)).EndInit();
            this.popupControlContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        #endregion

        #region Events

        protected override void OnLoad(EventArgs args)
        {
            this.barManager1.ThemeName = "Office2019Colorful";
            base.OnLoad(args);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void ClientForm_Load(object sender, System.EventArgs e)
		{
			// Updated the enabled/disabled state of the menu items.
			this.UpdateMenuItems();
			// Update the Font Color BarItem image.
			this.InitBaseImage();
			this.colorUIControl1.SelectedColor = Color.Black;
		}

		private void cutBarItem_Click(object sender, System.EventArgs e)
		{
			this.richTextBox1.Cut();
		}

		private void richTextBox1_SelectionChanged(object sender, System.EventArgs e)
		{
			this.UpdateMenuItems();
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
        
		private void fontColorBarItem_Click(object sender, System.EventArgs e)
		{
			// Set the selection's color to be the ColorUI's Selected Color.
			this.richTextBox1.ForeColor = this.colorUIControl1.SelectedColor;
		}

		private void colorUIControl1_ColorSelected(object sender, System.EventArgs e)
		{
			this.fontColorBarItem_Click(sender, e);

			this.UpdateDropdownImageColor(this.colorUIControl1.SelectedColor);
			// Close the popup, now that a Color was selected
			this.popupControlContainer1.HidePopup(PopupCloseType.Done);
		}

		private void findItem_Click(object sender, System.EventArgs e)
		{
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
				if (index != -1)
				{
					// Select the string using the index and the length of the string.
					this.richTextBox1.Select(searchBeginIndex + index, this.findItem.TextBoxValue.Length);
				}
			}
		}

		private void popupControlContainer1_Popup(object sender, System.EventArgs e)
		{
			this.colorUIControl1.Focus();
        }

        #endregion
    }
}
