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

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace ControlBars
{
	/// <summary>
	/// Summary description for TextForm.
	/// </summary>
    public class TextForm : MetroForm
    {
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ChildFrameBarManager childFrameBarManager1;
        private System.Windows.Forms.ImageList imageList1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem5;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem comboBoxBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem comboBoxBarItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem dropDownBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
        private Syncfusion.Windows.Forms.PopupControlContainer popupControlContainer1;
        private Syncfusion.Windows.Forms.ColorUIControl colorUIControl1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenusManager popupMenusManager1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu popupMenu2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem comboBoxBarItem3;
        private ListBox listBox1;
        private System.ComponentModel.IContainer components;

        public TextForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            this.colorUIControl1.ColorSelected += new EventHandler(colorUIControl1_ColorSelected);
            this.comboBoxBarItem3.TextBoxValue = "ContextMenuStyle";
            this.comboBoxBarItem3.ListBox.SelectedIndex = 8;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"..\\..\\Icon\sfgrid.ico"));
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

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextForm));
            Syncfusion.Windows.Forms.MetroColorTable metroColorTabel1 = new Syncfusion.Windows.Forms.MetroColorTable();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.childFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ChildFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.childFrameBarManager1, "Edit");
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.bar2 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.childFrameBarManager1, "Format");
            this.comboBoxBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem();
            this.dropDownBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem();
            this.popupControlContainer1 = new Syncfusion.Windows.Forms.PopupControlContainer();
            this.colorUIControl1 = new Syncfusion.Windows.Forms.ColorUIControl();
            this.comboBoxBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem();
            this.bar3 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.childFrameBarManager1, "MainMenu");
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.comboBoxBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.parentBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.popupMenusManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenusManager(this.components);
            this.popupMenu2 = new Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.childFrameBarManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem1)).BeginInit();
            this.popupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Crimson;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(442, 440);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.popupMenusManager1.SetXPContextMenu(this.richTextBox1, this.popupMenu2);
            // 
            // childFrameBarManager1
            // 
#if !NETCORE
            this.childFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("childFrameBarManager1.BarPositionInfo")));
#endif
            this.childFrameBarManager1.Bars.Add(this.bar1);
            this.childFrameBarManager1.Bars.Add(this.bar2);
            this.childFrameBarManager1.Bars.Add(this.bar3);
            this.childFrameBarManager1.Categories.Add("Edit");
            this.childFrameBarManager1.Categories.Add("Format");
            this.childFrameBarManager1.Categories.Add("Popups");
            this.childFrameBarManager1.CategoriesToIgnoreInCustDialog.AddRange(new int[] {
            0});
            this.childFrameBarManager1.CurrentBaseFormType = "System.Windows.Forms.Form";
            this.childFrameBarManager1.Form = this;
            this.childFrameBarManager1.ImageList = this.imageList1;
            this.childFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem3,
            this.comboBoxBarItem1,
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem4,
            this.barItem5,
            this.comboBoxBarItem2,
            this.dropDownBarItem1,
            this.parentBarItem1,
            this.parentBarItem2,
            this.comboBoxBarItem3});
            this.childFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // bar1
            // 
            this.bar1.BarName = "Edit";
            this.bar1.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical) 
            | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) 
            | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder)));
            this.bar1.Caption = "Edit";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem4,
            this.barItem5});
            this.bar1.Manager = this.childFrameBarManager1;
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.CategoryIndex = 0;
            this.barItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem1.ID = "biCut";
            this.barItem1.ImageIndex = 3;
            this.barItem1.ShowToolTipInPopUp = false;
            this.barItem1.SizeToFit = true;
            this.barItem1.Text = "Cu&t";
            // 
            // barItem2
            // 
            this.barItem2.BarName = "barItem2";
            this.barItem2.CategoryIndex = 0;
            this.barItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem2.ID = "biCopy";
            this.barItem2.ImageIndex = 4;
            this.barItem2.ShowToolTipInPopUp = false;
            this.barItem2.SizeToFit = true;
            this.barItem2.Text = "&Copy";
            // 
            // barItem3
            // 
            this.barItem3.BarName = "barItem3";
            this.barItem3.CategoryIndex = 0;
            this.barItem3.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem3.ID = "biPaste";
            this.barItem3.ImageIndex = 5;
            this.barItem3.ShowToolTipInPopUp = false;
            this.barItem3.SizeToFit = true;
            this.barItem3.Text = "&Paste";
            // 
            // barItem4
            // 
            this.barItem4.BarName = "barItem4";
            this.barItem4.CategoryIndex = 0;
            this.barItem4.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem4.ID = "biUndo";
            this.barItem4.ImageIndex = 6;
            this.barItem4.ShowToolTipInPopUp = false;
            this.barItem4.SizeToFit = true;
            this.barItem4.Text = "&Undo";
            // 
            // barItem5
            // 
            this.barItem5.BarName = "barItem5";
            this.barItem5.CategoryIndex = 0;
            this.barItem5.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem5.ID = "biRedo";
            this.barItem5.ImageIndex = 7;
            this.barItem5.ShowToolTipInPopUp = false;
            this.barItem5.SizeToFit = true;
            this.barItem5.Text = "&Redo";
            // 
            // bar2
            // 
            this.bar2.BarName = "Format";
            this.bar2.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical) 
            | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) 
            | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder)));
            this.bar2.Caption = "Format";
            this.bar2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.comboBoxBarItem1,
            this.dropDownBarItem1,
            this.comboBoxBarItem2});
            this.bar2.Manager = this.childFrameBarManager1;
            // 
            // comboBoxBarItem1
            // 
            this.comboBoxBarItem1.BarName = "comboBoxBarItem1";
            this.comboBoxBarItem1.CategoryIndex = 1;
            this.comboBoxBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBarItem1.ID = "Editable";
            this.comboBoxBarItem1.ShowToolTipInPopUp = false;
            this.comboBoxBarItem1.SizeToFit = true;
            this.comboBoxBarItem1.Text = "Editable";
            // 
            // dropDownBarItem1
            // 
            this.dropDownBarItem1.BarName = "dropDownBarItem1";
            this.dropDownBarItem1.CategoryIndex = 1;
            this.dropDownBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownBarItem1.ID = "Font DropDown";
            this.dropDownBarItem1.ImageIndex = 8;
            this.dropDownBarItem1.PopupControlContainer = this.popupControlContainer1;
            this.dropDownBarItem1.ShowToolTipInPopUp = false;
            this.dropDownBarItem1.SizeToFit = true;
            this.dropDownBarItem1.Text = "Font DropDown";
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.Controls.Add(this.colorUIControl1);
            this.popupControlContainer1.Location = new System.Drawing.Point(192, 120);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Size = new System.Drawing.Size(208, 200);
            this.popupControlContainer1.TabIndex = 15;
            this.popupControlContainer1.Visible = false;
            // 
            // colorUIControl1
            // 
            this.colorUIControl1.BackColor = System.Drawing.SystemColors.Control;
            this.colorUIControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorUIControl1.Flag = false;
            this.colorUIControl1.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.colorUIControl1.Location = new System.Drawing.Point(0, 0);
            this.colorUIControl1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.colorUIControl1.MetroForeColor = System.Drawing.Color.White;
            this.colorUIControl1.Name = "colorUIControl1";
            metroColorTabel1.ArrowChecked = System.Drawing.Color.Black;         
            metroColorTabel1.ArrowNormal = System.Drawing.Color.Gray;
            metroColorTabel1.ArrowPushed = System.Drawing.Color.Black;
            metroColorTabel1.ScrollerBackground = System.Drawing.Color.White;
            metroColorTabel1.ThumbChecked = System.Drawing.Color.Black;         
            metroColorTabel1.ThumbNormal = System.Drawing.Color.Gray;
            metroColorTabel1.ThumbPushed = System.Drawing.Color.Black;
            this.colorUIControl1.ScrollMetroColorTable = metroColorTabel1;
            this.colorUIControl1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors;
            this.colorUIControl1.Size = new System.Drawing.Size(208, 200);
            this.colorUIControl1.TabIndex = 1;
            this.colorUIControl1.Text = "colorUIControl1";
            // 
            // comboBoxBarItem2
            // 
            this.comboBoxBarItem2.BarName = "comboBoxBarItem2";
            this.comboBoxBarItem2.CategoryIndex = 1;
            this.comboBoxBarItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBarItem2.ID = "ChoiceList";
            this.comboBoxBarItem2.ShowToolTipInPopUp = false;
            this.comboBoxBarItem2.SizeToFit = true;
            this.comboBoxBarItem2.Text = "ChoiceList";
            // 
            // bar3
            // 
            this.bar3.BarName = "MainMenu";
            this.bar3.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu) 
            | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) 
            | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder)));
            this.bar3.Caption = "MainMenu";
            this.bar3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.parentBarItem2,
            this.comboBoxBarItem3});
            this.bar3.Manager = this.childFrameBarManager1;
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.BarName = "parentBarItem1";
            this.parentBarItem1.CategoryIndex = 2;
            this.parentBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem1.ID = "Edit";
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem4,
            this.barItem5});
            this.parentBarItem1.MergeOrder = 1;
            this.parentBarItem1.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem1.Text = "Edit";
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.BarName = "parentBarItem2";
            this.parentBarItem2.CategoryIndex = 2;
            this.parentBarItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem2.ID = "Format";
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.comboBoxBarItem1,
            this.comboBoxBarItem2,
            this.dropDownBarItem1});
            this.parentBarItem2.MergeOrder = 3;
            this.parentBarItem2.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem2.ShowToolTipInPopUp = false;
            this.parentBarItem2.SizeToFit = true;
            this.parentBarItem2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem2.Text = "Format";
            // 
            // comboBoxBarItem3
            // 
            this.comboBoxBarItem3.BarName = "comboBoxBarItem3";
            this.comboBoxBarItem3.CategoryIndex = 1;
            this.comboBoxBarItem3.ChoiceList.AddRange(new string[] {
            "Default",
            "Office2003",
            "VS2005",
            "Office2007Blue",
            "Office2007Black",
            "Office2007Silver",
            "Office2007Managed",
            "Offic2007Outlook",
            "Metro"});
            this.comboBoxBarItem3.ID = "BarItem_1";
            this.comboBoxBarItem3.ListBox = this.listBox1;
            this.comboBoxBarItem3.MinWidth = 120;
            this.comboBoxBarItem3.ShowToolTipInPopUp = false;
            this.comboBoxBarItem3.SizeToFit = true;
            this.comboBoxBarItem3.Text = "ContextMenuStyle";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Default",
            "Office2003",
            "VS2005",
            "Office2007Blue",
            "Office2007Black",
            "Office2007Silver",
            "Office2007Managed",
            "Offic2007Outlook",
            "Metro"});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(199, 95);
            this.listBox1.TabIndex = 20;
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
            // 
            // parentBarItem3
            // 
            this.parentBarItem3.BarName = "parentBarItem3";
            this.parentBarItem3.CategoryIndex = 0;
            this.parentBarItem3.ID = "BarItem";
            this.parentBarItem3.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem3.ShowToolTipInPopUp = false;
            this.parentBarItem3.SizeToFit = true;
            this.parentBarItem3.Text = "Edit";
            // 
            // popupMenusManager1
            // 
            this.popupMenusManager1.ParentForm = this;
            // 
            // popupMenu2
            // 
            this.popupMenu2.ParentBarItem = this.parentBarItem1;
            this.popupMenu2.BeforePopup += new Syncfusion.Windows.Forms.CancelMouseEventHandler(this.popupMenu2_BeforePopup);
            // 
            // TextForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(442, 440);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.popupControlContainer1);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TextForm";
            this.Text = "Textpad";
            ((System.ComponentModel.ISupportInitialize)(this.childFrameBarManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem1)).EndInit();
            this.popupControlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem3)).EndInit();
            this.ResumeLayout(false);

        }

        void colorUIControl1_ColorSelected(object sender, EventArgs e)
        {
            this.popupControlContainer1.HidePopup(Syncfusion.Windows.Forms.PopupCloseType.Done);
        }
        #endregion

        private void popupMenu2_BeforePopup(object sender, Syncfusion.Windows.Forms.CancelMouseEventArgs e)
        {
            switch (comboBoxBarItem3.ListBox.SelectedIndex)
            {
                case 0:
                    popupMenu2.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Default;
                    break;
                case 1:
                    popupMenu2.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003;
                    break;
                case 2:
                    popupMenu2.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.VS2005;
                    break;
                case 3:
                    popupMenu2.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
                    popupMenu2.ParentBarItem.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Blue;
                    break;
                case 4:
                    popupMenu2.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
                    popupMenu2.ParentBarItem.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Black;
                    break;
                case 5:
                    popupMenu2.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
                    popupMenu2.ParentBarItem.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
                    break;
                case 6:
                    popupMenu2.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
                    popupMenu2.ParentBarItem.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
                    break;

                case 7:
                    popupMenu2.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook;
                    break;
                case 8:
                    popupMenu2.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
                    break;
            }
        }
    }
}
