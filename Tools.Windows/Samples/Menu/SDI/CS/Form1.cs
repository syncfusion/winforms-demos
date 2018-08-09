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
using System.Data;

using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using Syncfusion.Windows.Forms;

namespace XPMenusSDI
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
    {
        #region Members
        private Image baseImage;
		private Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar3;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem3;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem4;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem5;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem6;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ImageList largeImageList1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem comboBoxBarItem1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem comboBoxBarItem2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem4;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem5;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ToolbarListBarItem toolbarListBarItem1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem6;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ListBarItem listBarItem1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem7;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar xpToolBar1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem8;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem9;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem7;
		private Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem dropDownBarItem3;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem10;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private GradientLabel label1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu popupMenu1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu popupMenu2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem8;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem11;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem12;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem13;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem9;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem14;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem15;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem comboBoxBarItem3;
		private Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenusManager popupMenusManager1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem10;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem16;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem17;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem18;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Metro;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Office2016Colorful;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Office2016DarkGray;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Office2016White;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Office2016Black;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Office2003;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Office2007;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Office2010;
      
		private Syncfusion.Windows.Forms.PopupControlContainer popupControlContainer1;
		private Syncfusion.Windows.Forms.ColorUIControl colorUIControl1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem fontColorBarItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem11;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem12;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem19;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Splitter splitter2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem20;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar5;
		private Syncfusion.Windows.Forms.Tools.XPMenus.StaticBarItem staticBarItem1;
        private SuperToolTip superToolTip1;
        private ImageListAdv imageListAdv1;
        private CheckBoxAdv checkBoxAdv1;
		private System.ComponentModel.IContainer components;
        #endregion

        #region Form Constructor
        public Form1()
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


			// It's recommended that you keep the PopupControlContainer unparented by
			// any Control on the Form (which will be the default case as set up during design-time).
			// Otherwise, the Form wouldn't close sometimes, after dropping down this popup!

            //this.bari
			this.popupControlContainer1.Parent.Controls.Remove(this.popupControlContainer1);
            this.richTextBox1.Text = "Right-Click here to bring up context menu.\r\n";
			this.staticBarItem1.Text ="Ready";
            this.checkBoxAdv1.Checked = true;
            this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016White;
        }
        #endregion
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

        #region Dispose
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
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo8 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo5 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo6 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo7 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo4 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo1 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo2 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo3 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo9 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo13 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo10 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo11 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo12 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTabel1 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo14 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo15 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "MainMenu");
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.parentBarItem10 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem16 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem17 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.imageListAdv1 = new Syncfusion.Windows.Forms.Tools.ImageListAdv(this.components);
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Metro = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Office2003 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Office2007 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Office2010 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Office2016Black = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Office2016Colorful = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Office2016DarkGray = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Office2016White=new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.listBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ListBarItem();
            this.barItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem18 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.toolbarListBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ToolbarListBarItem();
            this.parentBarItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.comboBoxBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem();
            this.comboBoxBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem();
            this.fontColorBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem();
            this.popupControlContainer1 = new Syncfusion.Windows.Forms.PopupControlContainer();
            this.colorUIControl1 = new Syncfusion.Windows.Forms.ColorUIControl();
            this.parentBarItem11 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.parentBarItem12 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem19 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.bar2 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "File");
            this.bar3 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "Format");
            this.bar4 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "Edit");
            this.bar5 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "StatusBar");
            this.staticBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.StaticBarItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.largeImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.xpToolBar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar();
            this.barItem11 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem10 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem12 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem13 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.dropDownBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem();
            this.barItem9 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.popupMenu1 = new Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(this.components);
            this.popupMenu2 = new Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(this.components);
            this.parentBarItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.parentBarItem9 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem14 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem15 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.comboBoxBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem();
            this.popupMenusManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenusManager(this.components);
            this.barItem20 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.superToolTip1 = new Syncfusion.Windows.Forms.Tools.SuperToolTip(this);
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem2)).BeginInit();
            this.popupControlContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainFrameBarManager1
            // 
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
            this.mainFrameBarManager1.Bars.Add(this.bar1);
            this.mainFrameBarManager1.Bars.Add(this.bar2);
            this.mainFrameBarManager1.Bars.Add(this.bar3);
            this.mainFrameBarManager1.Bars.Add(this.bar4);
            this.mainFrameBarManager1.Bars.Add(this.bar5);
            this.mainFrameBarManager1.Categories.Add("File");
            this.mainFrameBarManager1.Categories.Add("Edit");
            this.mainFrameBarManager1.Categories.Add("Format");
            this.mainFrameBarManager1.Categories.Add("View");
            this.mainFrameBarManager1.Categories.Add("Help");
            this.mainFrameBarManager1.Categories.Add("StatusBar");
            this.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.MetroForm";
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.ImageList = this.imageList1;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.parentBarItem4,
            this.parentBarItem10,
            this.barItem2,
            this.comboBoxBarItem1,
            this.barItem3,
            this.parentBarItem6,
            this.comboBoxBarItem2,
            this.listBarItem1,
            this.barItem7,
            this.fontColorBarItem,
            this.barItem1,
            this.parentBarItem2,
            this.barItem16,
            this.barItem17,
            this.barItem4,
            this.barItem5,
            this.barItem6,
            this.parentBarItem5,
            this.toolbarListBarItem1,
            this.barItem18,
            this.parentBarItem11,
            this.parentBarItem12,
            this.barItem19,
            this.staticBarItem1});
            this.mainFrameBarManager1.LargeImageList = this.largeImageList1;
            this.mainFrameBarManager1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.CustomizationBegin += new System.EventHandler(this.Customization_Begin);
            this.mainFrameBarManager1.CustomizationDone += new System.EventHandler(this.Customization_Done);
            // 
            // bar1
            // 
            this.bar1.BarName = "MainMenu";
            this.bar1.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)(((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder)));
            this.bar1.Caption = "MainMenu";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.parentBarItem2,
            this.parentBarItem5,
            this.parentBarItem4,
            this.parentBarItem11,
            this.parentBarItem12});
            this.bar1.Manager = this.mainFrameBarManager1;
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.BarName = "parentBarItem1";
            this.parentBarItem1.CategoryIndex = 0;
            this.parentBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem1.ID = "&File";
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem10,
            this.barItem2,
            this.barItem3,
            this.parentBarItem6,
            this.barItem7});
            this.parentBarItem1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem1.SeparatorIndices.AddRange(new int[] {
            3,
            4});
            this.parentBarItem1.ShowTooltip = false;
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem1.Text = "&File";
            toolTipInfo8.Body.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            toolTipInfo8.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo8.Body.Text = "Click here to open, \r\nsave, view recent \r\nfiles and close.";
            toolTipInfo8.Body.TextMargin = new System.Windows.Forms.Padding(6);
            toolTipInfo8.Footer.Hidden = true;
            toolTipInfo8.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo8.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo8.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo8.Header.Text = "File Item";
            toolTipInfo8.Header.TextMargin = new System.Windows.Forms.Padding(3);
            toolTipInfo8.Separator = false;
            this.superToolTip1.SetToolTip(this.parentBarItem1, toolTipInfo8);
            this.parentBarItem1.Popup += new System.EventHandler(this.Submenu_Popup);
            this.parentBarItem1.PopupClosed += new System.EventHandler(this.Sumenu_PopupClosed);
            this.parentBarItem1.Selected += new System.EventHandler(this.BarItem_Selected);
            // 
            // parentBarItem10
            // 
            this.parentBarItem10.BarName = "parentBarItem10";
            this.parentBarItem10.CategoryIndex = 0;
            this.parentBarItem10.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem10.ID = "&New";
            this.parentBarItem10.ImageIndex = 0;
            this.parentBarItem10.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem16,
            this.barItem17});
            this.parentBarItem10.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem10.ParentStyle = Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItemStyle.DropDown;
            this.parentBarItem10.PressedImageIndex = 0;
            this.parentBarItem10.PressedImageListAdv = this.imageListAdv1;
            this.parentBarItem10.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.parentBarItem10.ShowTooltip = false;
            this.parentBarItem10.ShowToolTipInPopUp = false;
            this.parentBarItem10.SizeToFit = true;
            this.parentBarItem10.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem10.Text = "&New";
            toolTipInfo5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(151)))), ((int)(((byte)(223)))));
            toolTipInfo5.Body.Hidden = true;
            toolTipInfo5.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo5.Footer.Hidden = true;
            toolTipInfo5.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo5.Header.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            toolTipInfo5.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo5.Header.Text = "New";
            toolTipInfo5.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTipInfo5.Separator = false;
            this.superToolTip1.SetToolTip(this.parentBarItem10, toolTipInfo5);
            this.parentBarItem10.Popup += new System.EventHandler(this.Submenu_Popup);
            this.parentBarItem10.PopupClosed += new System.EventHandler(this.Sumenu_PopupClosed);
            this.parentBarItem10.Click += new System.EventHandler(this.BarItem_Click);
            this.parentBarItem10.Selected += new System.EventHandler(this.BarItem_Selected);
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.CategoryIndex = 0;
            this.barItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem1.ID = "New1";
            this.barItem1.ShowToolTipInPopUp = false;
            this.barItem1.SizeToFit = true;
            this.barItem1.Text = "New1";
            this.barItem1.Click += new System.EventHandler(this.BarItem_Click);
            this.barItem1.Selected += new System.EventHandler(this.BarItem_Selected);
            // 
            // barItem16
            // 
            this.barItem16.BarName = "barItem16";
            this.barItem16.CategoryIndex = 0;
            this.barItem16.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem16.ID = "New2";
            this.barItem16.ShowToolTipInPopUp = false;
            this.barItem16.SizeToFit = true;
            this.barItem16.Text = "New2";
            this.barItem16.Click += new System.EventHandler(this.BarItem_Click);
            this.barItem16.Selected += new System.EventHandler(this.BarItem_Selected);
            // 
            // barItem17
            // 
            this.barItem17.BarName = "barItem17";
            this.barItem17.CategoryIndex = 0;
            this.barItem17.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem17.ID = "New3";
            this.barItem17.ShowToolTipInPopUp = false;
            this.barItem17.SizeToFit = true;
            this.barItem17.Text = "New3";
            this.barItem17.Click += new System.EventHandler(this.BarItem_Click);
            this.barItem17.Selected += new System.EventHandler(this.BarItem_Selected);
            // 
            // imageListAdv1
            // 
            this.imageListAdv1.Images.AddRange(new System.Drawing.Image[] {
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images1"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images2")))});
            // 
            // barItem2
            // 
            this.barItem2.BarName = "barItem2";
            this.barItem2.CategoryIndex = 0;
            this.barItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem2.ID = "&Open";
            this.barItem2.ImageIndex = 1;
            this.barItem2.PressedImageIndex = 1;
            this.barItem2.PressedImageListAdv = this.imageListAdv1;
            this.barItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.barItem2.ShowTooltip = false;
            this.barItem2.ShowToolTipInPopUp = false;
            this.barItem2.SizeToFit = true;
            this.barItem2.Text = "&Open";
            toolTipInfo6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            toolTipInfo6.Body.Hidden = true;
            toolTipInfo6.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo6.Footer.Hidden = true;
            toolTipInfo6.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo6.Header.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            toolTipInfo6.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo6.Header.Text = "Open";
            toolTipInfo6.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTipInfo6.Separator = false;
            this.superToolTip1.SetToolTip(this.barItem2, toolTipInfo6);
            this.barItem2.Click += new System.EventHandler(this.BarItem_Click);
            this.barItem2.Selected += new System.EventHandler(this.BarItem_Selected);
            // 
            // barItem3
            // 
            this.barItem3.BarName = "barItem3";
            this.barItem3.CategoryIndex = 0;
            this.barItem3.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem3.ID = "&Save";
            this.barItem3.ImageIndex = 2;
            this.barItem3.PressedImageIndex = 2;
            this.barItem3.PressedImageListAdv = this.imageListAdv1;
            this.barItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.barItem3.ShowTooltip = false;
            this.barItem3.ShowToolTipInPopUp = false;
            this.barItem3.SizeToFit = true;
            this.barItem3.Text = "&Save";
            toolTipInfo7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(197)))), ((int)(((byte)(124)))));
            toolTipInfo7.Body.Hidden = true;
            toolTipInfo7.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo7.Footer.Hidden = true;
            toolTipInfo7.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo7.Header.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            toolTipInfo7.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo7.Header.Text = "Save";
            toolTipInfo7.Separator = false;
            this.superToolTip1.SetToolTip(this.barItem3, toolTipInfo7);
            this.barItem3.Click += new System.EventHandler(this.BarItem_Click);
            this.barItem3.Selected += new System.EventHandler(this.BarItem_Selected);
            // 
            // parentBarItem6
            // 
            this.parentBarItem6.BarName = "parentBarItem6";
            this.parentBarItem6.CategoryIndex = 0;
            this.parentBarItem6.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem6.ID = "Recent Views (Expanding List)";
            this.parentBarItem6.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.listBarItem1});
            this.parentBarItem6.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem6.ShowToolTipInPopUp = false;
            this.parentBarItem6.SizeToFit = true;
            this.parentBarItem6.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItem6.Text = "Recent Views (Expanding List)";
            this.parentBarItem6.Popup += new System.EventHandler(this.Submenu_Popup);
            this.parentBarItem6.PopupClosed += new System.EventHandler(this.Sumenu_PopupClosed);
            this.parentBarItem6.Selected += new System.EventHandler(this.BarItem_Selected);
            // 
            // listBarItem1
            // 
            this.listBarItem1.BarName = "listBarItem1";
            this.listBarItem1.CategoryIndex = 0;
            this.listBarItem1.ChildCaptions.AddRange(new string[] {
            "View 1",
            "View 2",
            "View 3"});
            this.listBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBarItem1.ID = "MRU List";
            this.listBarItem1.ShowToolTipInPopUp = false;
            this.listBarItem1.SizeToFit = true;
            this.listBarItem1.Text = "MRU List";
            this.listBarItem1.Selected += new System.EventHandler(this.BarItem_Selected);
            // 
            // barItem7
            // 
            this.barItem7.BarName = "barItem7";
            this.barItem7.CategoryIndex = 0;
            this.barItem7.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem7.ID = "&Exit";
            this.barItem7.ShowToolTipInPopUp = false;
            this.barItem7.SizeToFit = true;
            this.barItem7.Text = "&Exit";
            this.barItem7.Click += new System.EventHandler(this.barItem7_Click);
            this.barItem7.Selected += new System.EventHandler(this.BarItem_Selected);
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.BarName = "parentBarItem2";
            this.parentBarItem2.CategoryIndex = 1;
            this.parentBarItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem2.ID = "&Edit";
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem4,
            this.barItem5,
            this.barItem6,
            this.barItem18});
            this.parentBarItem2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem2.SeparatorIndices.AddRange(new int[] {
            3});
            this.parentBarItem2.ShowTooltip = false;
            this.parentBarItem2.ShowToolTipInPopUp = false;
            this.parentBarItem2.SizeToFit = true;
            this.parentBarItem2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem2.Text = "&Edit";
            toolTipInfo4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(180)))), ((int)(((byte)(213)))));
            toolTipInfo4.Body.Hidden = true;
            toolTipInfo4.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo4.Footer.Hidden = true;
            toolTipInfo4.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo4.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo4.Header.Text = "Edit";
            toolTipInfo4.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTipInfo4.Separator = false;
            this.superToolTip1.SetToolTip(this.parentBarItem2, toolTipInfo4);
            this.parentBarItem2.Popup += new System.EventHandler(this.Submenu_Popup);
            this.parentBarItem2.PopupClosed += new System.EventHandler(this.Sumenu_PopupClosed);
            this.parentBarItem2.Selected += new System.EventHandler(this.BarItem_Selected);
            // 
            // barItem4
            // 
            this.barItem4.BarName = "barItem4";
            this.barItem4.CategoryIndex = 1;
            this.barItem4.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem4.ID = "Cu&t";
            this.barItem4.ImageIndex = 3;
            this.barItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.barItem4.ShowTooltip = false;
            this.barItem4.ShowToolTipInPopUp = false;
            this.barItem4.SizeToFit = true;
            this.barItem4.Text = "Cu&t";
            toolTipInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            toolTipInfo1.Body.Hidden = true;
            toolTipInfo1.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo1.Footer.Hidden = true;
            toolTipInfo1.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo1.Header.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            toolTipInfo1.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo1.Header.Text = "Cut";
            toolTipInfo1.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTipInfo1.Separator = false;
            this.superToolTip1.SetToolTip(this.barItem4, toolTipInfo1);
            this.barItem4.Click += new System.EventHandler(this.BarItem_Click);
            this.barItem4.Selected += new System.EventHandler(this.BarItem_Selected);
            // 
            // barItem5
            // 
            this.barItem5.BarName = "barItem5";
            this.barItem5.CategoryIndex = 1;
            this.barItem5.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem5.ID = "&Copy";
            this.barItem5.ImageIndex = 4;
            this.barItem5.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.barItem5.ShowTooltip = false;
            this.barItem5.ShowToolTipInPopUp = false;
            this.barItem5.SizeToFit = true;
            this.barItem5.Text = "&Copy";
            toolTipInfo2.BackColor = System.Drawing.Color.LightCoral;
            toolTipInfo2.Body.Hidden = true;
            toolTipInfo2.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo2.Footer.Hidden = true;
            toolTipInfo2.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo2.Header.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            toolTipInfo2.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo2.Header.Text = "Copy";
            toolTipInfo2.Separator = false;
            this.superToolTip1.SetToolTip(this.barItem5, toolTipInfo2);
            this.barItem5.Click += new System.EventHandler(this.BarItem_Click);
            this.barItem5.Selected += new System.EventHandler(this.BarItem_Selected);
            // 
            // barItem6
            // 
            this.barItem6.BarName = "barItem6";
            this.barItem6.CategoryIndex = 1;
            this.barItem6.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem6.ID = "&Paste";
            this.barItem6.ImageIndex = 5;
            this.barItem6.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            this.barItem6.ShowTooltip = false;
            this.barItem6.ShowToolTipInPopUp = false;
            this.barItem6.SizeToFit = true;
            this.barItem6.Text = "&Paste";
            toolTipInfo3.BackColor = System.Drawing.Color.PaleTurquoise;
            toolTipInfo3.Body.Hidden = true;
            toolTipInfo3.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo3.Footer.Hidden = true;
            toolTipInfo3.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo3.Header.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            toolTipInfo3.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo3.Header.Text = "Paste";
            toolTipInfo3.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTipInfo3.Separator = false;
            this.superToolTip1.SetToolTip(this.barItem6, toolTipInfo3);
            this.barItem6.Click += new System.EventHandler(this.BarItem_Click);
            this.barItem6.Selected += new System.EventHandler(this.BarItem_Selected);
            // 
            // barItem18
            // 
            this.barItem18.BarName = "barItem18";
            this.barItem18.CategoryIndex = 1;
            this.barItem18.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem18.ID = "Clear Events";
            this.barItem18.Shortcut = System.Windows.Forms.Shortcut.CtrlL;
            this.barItem18.ShowToolTipInPopUp = false;
            this.barItem18.SizeToFit = true;
            this.barItem18.Text = "Clear Events";
            this.barItem18.Click += new System.EventHandler(this.Clear_Events);
            this.barItem18.Selected += new System.EventHandler(this.BarItem_Selected);
            // 
            // parentBarItem5
            // 
            this.parentBarItem5.BarName = "parentBarItem5";
            this.parentBarItem5.CategoryIndex = 3;
            this.parentBarItem5.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem5.ID = "&View";
            this.parentBarItem5.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.toolbarListBarItem1});
            this.parentBarItem5.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem5.ShowTooltip = false;
            this.parentBarItem5.ShowToolTipInPopUp = false;
            this.parentBarItem5.SizeToFit = true;
            this.parentBarItem5.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem5.Text = "&View";
            toolTipInfo9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(150)))), ((int)(((byte)(71)))));
            toolTipInfo9.Body.Hidden = true;
            toolTipInfo9.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo9.Footer.Hidden = true;
            toolTipInfo9.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo9.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo9.Header.Text = "View";
            toolTipInfo9.Separator = false;
            this.superToolTip1.SetToolTip(this.parentBarItem5, toolTipInfo9);
            this.parentBarItem5.Popup += new System.EventHandler(this.Submenu_Popup);
            this.parentBarItem5.PopupClosed += new System.EventHandler(this.Sumenu_PopupClosed);
            this.parentBarItem5.Selected += new System.EventHandler(this.BarItem_Selected);
            // 
            // toolbarListBarItem1
            // 
            this.toolbarListBarItem1.BarName = "toolbarListBarItem1";
            this.toolbarListBarItem1.CategoryIndex = 3;
            this.toolbarListBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolbarListBarItem1.ID = "Toolbar List";
            this.toolbarListBarItem1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.toolbarListBarItem1.ShowToolTipInPopUp = false;
            this.toolbarListBarItem1.SizeToFit = true;
            this.toolbarListBarItem1.Text = "Toolbar List";
            this.toolbarListBarItem1.Popup += new System.EventHandler(this.Submenu_Popup);
            this.toolbarListBarItem1.PopupClosed += new System.EventHandler(this.Sumenu_PopupClosed);
            this.toolbarListBarItem1.Selected += new System.EventHandler(this.BarItem_Selected);
            // 
            // parentBarItem4
            // 
            this.parentBarItem4.BarName = "parentBarItem4";
            this.parentBarItem4.CategoryIndex = 2;
            this.parentBarItem4.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem4.ID = "Forma&t";
            this.parentBarItem4.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.comboBoxBarItem1,
            this.comboBoxBarItem2,
            this.fontColorBarItem});
            this.parentBarItem4.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem4.ShowTooltip = false;
            this.parentBarItem4.ShowToolTipInPopUp = false;
            this.parentBarItem4.SizeToFit = true;
            this.parentBarItem4.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem4.Text = "Forma&t";
            toolTipInfo13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(0)))));
            toolTipInfo13.Body.Hidden = true;
            toolTipInfo13.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo13.Footer.Hidden = true;
            toolTipInfo13.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo13.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo13.Header.Text = "Format";
            toolTipInfo13.Separator = false;
            this.superToolTip1.SetToolTip(this.parentBarItem4, toolTipInfo13);
            this.parentBarItem4.Popup += new System.EventHandler(this.Submenu_Popup);
            this.parentBarItem4.PopupClosed += new System.EventHandler(this.Sumenu_PopupClosed);
            this.parentBarItem4.Selected += new System.EventHandler(this.BarItem_Selected);
            // 
            // comboBoxBarItem1
            // 
            this.comboBoxBarItem1.AutoAppend = true;
            this.comboBoxBarItem1.BarName = "comboBoxBarItem1";
            this.comboBoxBarItem1.CategoryIndex = 2;
            this.comboBoxBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBarItem1.ID = "Editable";
            this.comboBoxBarItem1.MinWidth = 100;
            this.comboBoxBarItem1.ShowTooltip = false;
            this.comboBoxBarItem1.ShowToolTipInPopUp = false;
            this.comboBoxBarItem1.SizeToFit = true;
            this.comboBoxBarItem1.Text = "Editable";
            this.comboBoxBarItem1.Tooltip = "Provides Editable and AutoAppend functionality for Find features.";
            toolTipInfo10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            toolTipInfo10.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo10.Body.Text = "Provides Editable and AutoAppend \r\nfunctionality for Find features.";
            toolTipInfo10.Body.TextMargin = new System.Windows.Forms.Padding(5);
            toolTipInfo10.Footer.Hidden = true;
            toolTipInfo10.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo10.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo10.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo10.Header.Text = "Editable";
            toolTipInfo10.Header.TextMargin = new System.Windows.Forms.Padding(5);
            toolTipInfo10.Separator = false;
            this.superToolTip1.SetToolTip(this.comboBoxBarItem1, toolTipInfo10);
            this.comboBoxBarItem1.Click += new System.EventHandler(this.BarItem_Click);
            this.comboBoxBarItem1.Selected += new System.EventHandler(this.BarItem_Selected);
            // 
            // comboBoxBarItem2
            // 
            this.comboBoxBarItem2.BarName = "comboBoxBarItem2";
            this.comboBoxBarItem2.CategoryIndex = 2;
            this.comboBoxBarItem2.ChoiceList.AddRange(new string[] {
            "Release",
            "Debug"});
            this.comboBoxBarItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBarItem2.Editable = false;
            this.comboBoxBarItem2.ID = "ChoiceList";
            this.comboBoxBarItem2.MinWidth = 70;
            this.comboBoxBarItem2.ShowTooltip = false;
            this.comboBoxBarItem2.ShowToolTipInPopUp = false;
            this.comboBoxBarItem2.SizeToFit = true;
            this.comboBoxBarItem2.Text = "ChoiceList";
            toolTipInfo11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            toolTipInfo11.Body.Hidden = true;
            toolTipInfo11.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo11.Footer.Hidden = true;
            toolTipInfo11.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo11.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo11.Header.Text = "ChoiceList";
            toolTipInfo11.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTipInfo11.Separator = false;
            this.superToolTip1.SetToolTip(this.comboBoxBarItem2, toolTipInfo11);
            this.comboBoxBarItem2.Click += new System.EventHandler(this.BarItem_Click);
            this.comboBoxBarItem2.Selected += new System.EventHandler(this.BarItem_Selected);
            // 
            // fontColorBarItem
            // 
            this.fontColorBarItem.BarName = "fontColorBarItem";
            this.fontColorBarItem.CategoryIndex = 2;
            this.fontColorBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontColorBarItem.ID = "Font DropDown";
            this.fontColorBarItem.ImageIndex = 8;
            this.fontColorBarItem.PopupControlContainer = this.popupControlContainer1;
            this.fontColorBarItem.ShowTooltip = false;
            this.fontColorBarItem.ShowToolTipInPopUp = false;
            this.fontColorBarItem.SizeToFit = true;
            this.fontColorBarItem.Text = "Font DropDown";
            toolTipInfo12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            toolTipInfo12.Body.Hidden = true;
            toolTipInfo12.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo12.Footer.Hidden = true;
            toolTipInfo12.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo12.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo12.Header.Text = "Font DropDown";
            toolTipInfo12.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTipInfo12.Separator = false;
            this.superToolTip1.SetToolTip(this.fontColorBarItem, toolTipInfo12);
            this.fontColorBarItem.Click += new System.EventHandler(this.fontColorBarItem_Click);
            this.fontColorBarItem.Selected += new System.EventHandler(this.BarItem_Selected);
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.popupControlContainer1.Controls.Add(this.colorUIControl1);
            this.popupControlContainer1.Location = new System.Drawing.Point(464, 48);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Padding = new System.Windows.Forms.Padding(1);
            this.popupControlContainer1.Size = new System.Drawing.Size(208, 200);
            this.popupControlContainer1.TabIndex = 6;
            this.popupControlContainer1.Visible = false;
            // 
            // colorUIControl1
            // 
            this.colorUIControl1.BackColor = System.Drawing.SystemColors.Control;
            this.colorUIControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorUIControl1.Flag = false;
            this.colorUIControl1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorUIControl1.Location = new System.Drawing.Point(1, 1);
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
            this.colorUIControl1.Size = new System.Drawing.Size(206, 198);
            this.colorUIControl1.TabIndex = 0;
            this.colorUIControl1.Text = "colorUIControl1";
            this.colorUIControl1.VisualStyle = Syncfusion.Windows.Forms.ColorUIStyle.Metro;
            this.colorUIControl1.ColorSelected += new System.EventHandler(this.colorUIControl1_ColorSelected);
            // 
            // parentBarItem11
            // 
            this.parentBarItem11.BarName = "parentBarItem11";
            this.parentBarItem11.CategoryIndex = 4;
            this.parentBarItem11.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem11.ID = "&Visual Style";
            this.parentBarItem11.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.Metro,
            this.Office2016Black,
           this.Office2016Colorful,
           this.Office2016DarkGray,
           this.Office2016White
               });
            this.parentBarItem11.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem11.ShowTooltip = false;
            this.parentBarItem11.ShowToolTipInPopUp = false;
            this.parentBarItem11.SizeToFit = true;
            this.parentBarItem11.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem11.Text = "VisualStyle";
            toolTipInfo15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(127)))), ((int)(((byte)(213)))));
            toolTipInfo15.Body.Hidden = true;
            toolTipInfo15.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo15.Footer.Hidden = true;
            toolTipInfo15.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo15.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo15.Header.Text = "VisualStyle";
            toolTipInfo15.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTipInfo15.Separator = false;
            this.superToolTip1.SetToolTip(this.parentBarItem11, toolTipInfo15);
            this.parentBarItem11.Popup += new System.EventHandler(this.Submenu_Popup);
            this.parentBarItem11.PopupClosed += new System.EventHandler(this.Sumenu_PopupClosed);
            this.parentBarItem11.Selected += new System.EventHandler(this.BarItem_Selected);
            // 
            // barItem19
            // 
            this.barItem19.BarName = "barItem19";
            this.barItem19.CategoryIndex = 4;
            this.barItem19.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem19.ID = "About Syncfusion";
            this.barItem19.ImageIndex = 22;
            this.barItem19.ShowToolTipInPopUp = false;
            this.barItem19.SizeToFit = true;
            this.barItem19.Text = "About Syncfusion";
            this.barItem19.Click += new System.EventHandler(this.barItem19_Click);
            // 
            // bar2
            // 
            this.bar2.BarName = "File";
            this.bar2.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder)));
            this.bar2.Caption = "File";
            this.bar2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem10,
            this.barItem2,
            this.barItem3});
            this.bar2.Manager = this.mainFrameBarManager1;
            // 
            // bar3
            // 
            this.bar3.BarName = "Format";
            this.bar3.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder)));
            this.bar3.Caption = "Format";
            this.bar3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.comboBoxBarItem1,
            this.fontColorBarItem,
            this.comboBoxBarItem2});
            this.bar3.Manager = this.mainFrameBarManager1;
            this.bar3.SeparatorIndices.AddRange(new int[] {
            1});
            // 
            // bar4
            // 
            this.bar4.BarName = "Edit";
            this.bar4.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder)));
            this.bar4.Caption = "Edit";
            this.bar4.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem4,
            this.barItem5,
            this.barItem6});
            this.bar4.Manager = this.mainFrameBarManager1;
            // 
            // bar5
            // 
            this.bar5.BarName = "StatusBar";
            this.bar5.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)(((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsStatusBar)));
            this.bar5.Caption = "StatusBar";
            this.bar5.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.staticBarItem1});
            this.bar5.Manager = this.mainFrameBarManager1;
            // 
            // staticBarItem1
            // 
            this.staticBarItem1.BarName = "staticBarItem1";
            this.staticBarItem1.CategoryIndex = 5;
            this.staticBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticBarItem1.FlatBorderColor = System.Drawing.SystemColors.GrayText;
            this.staticBarItem1.ID = "Status1";
            this.staticBarItem1.ShowToolTipInPopUp = false;
            this.staticBarItem1.SizeToFit = true;
            this.staticBarItem1.Text = "Status1";
            this.staticBarItem1.Click += new System.EventHandler(this.BarItem_Click);
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
            this.imageList1.Images.SetKeyName(15, "");
            this.imageList1.Images.SetKeyName(16, "");
            this.imageList1.Images.SetKeyName(17, "");
            this.imageList1.Images.SetKeyName(18, "");
            this.imageList1.Images.SetKeyName(19, "");
            this.imageList1.Images.SetKeyName(20, "");
            this.imageList1.Images.SetKeyName(21, "");
            this.imageList1.Images.SetKeyName(22, "");
            // 
            // largeImageList1
            // 
            this.largeImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeImageList1.ImageStream")));
            this.largeImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.largeImageList1.Images.SetKeyName(0, "");
            this.largeImageList1.Images.SetKeyName(1, "");
            this.largeImageList1.Images.SetKeyName(2, "");
            this.largeImageList1.Images.SetKeyName(3, "");
            this.largeImageList1.Images.SetKeyName(4, "");
            this.largeImageList1.Images.SetKeyName(5, "");
            this.largeImageList1.Images.SetKeyName(6, "");
            this.largeImageList1.Images.SetKeyName(7, "");
            this.largeImageList1.Images.SetKeyName(8, "");
            this.largeImageList1.Images.SetKeyName(9, "");
            this.largeImageList1.Images.SetKeyName(10, "");
            this.largeImageList1.Images.SetKeyName(11, "");
            this.largeImageList1.Images.SetKeyName(12, "");
            this.largeImageList1.Images.SetKeyName(13, "");
            this.largeImageList1.Images.SetKeyName(14, "");
            this.largeImageList1.Images.SetKeyName(15, "");
            this.largeImageList1.Images.SetKeyName(16, "");
            this.largeImageList1.Images.SetKeyName(17, "");
            this.largeImageList1.Images.SetKeyName(18, "");
            this.largeImageList1.Images.SetKeyName(19, "");
            this.largeImageList1.Images.SetKeyName(20, "");
            this.largeImageList1.Images.SetKeyName(21, "");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.popupControlContainer1);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 316);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 169);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Events";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 17);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(430, 149);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.popupMenusManager1.SetXPContextMenu(this.richTextBox1, this.popupMenu1);
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 134);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(449, 3);
            this.splitter2.TabIndex = 8;
            this.splitter2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(449, 134);
            this.panel3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
            this.label1.BorderSides = ((System.Windows.Forms.Border3DSide)(((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top)
                        | System.Windows.Forms.Border3DSide.Right)
                        | System.Windows.Forms.Border3DSide.Bottom)
                        | System.Windows.Forms.Border3DSide.Middle)));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 124);
            this.label1.TabIndex = 4;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.popupMenusManager1.SetXPContextMenu(this.label1, this.popupMenu2);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(449, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 316);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.propertyGrid1);
            this.panel2.Controls.Add(this.xpToolBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(452, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel2.Size = new System.Drawing.Size(192, 316);
            this.panel2.TabIndex = 0;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.CommandsBackColor = System.Drawing.Color.WhiteSmoke;
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 30);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(190, 284);
            this.propertyGrid1.TabIndex = 0;
            this.propertyGrid1.ToolbarVisible = false;
            // 
            // xpToolBar1
            // 
            this.xpToolBar1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.xpToolBar1.Bar.BarName = "";
            this.xpToolBar1.Bar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem11,
            this.parentBarItem7,
            this.barItem12,
            this.barItem13});
            this.xpToolBar1.Bar.Manager = null;
            this.xpToolBar1.Bar.SeparatorIndices.AddRange(new int[] {
            2});
            this.xpToolBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xpToolBar1.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.xpToolBar1.Location = new System.Drawing.Point(0, 5);
            this.xpToolBar1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.xpToolBar1.Name = "xpToolBar1";
            this.xpToolBar1.SeparatorIndices.AddRange(new int[] {
            2,
            2,
            2,
            2,
            2});
            this.xpToolBar1.Size = new System.Drawing.Size(190, 25);
            this.xpToolBar1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.xpToolBar1.TabIndex = 1;
            this.xpToolBar1.Text = "xpToolBar1";
            // 
            // barItem11
            // 
            this.barItem11.BarName = "barItem11";
            this.barItem11.CustomTextFont = new System.Drawing.Font("Calibri", 9.75F);
            this.barItem11.ID = "Item1";
            this.barItem11.ImageIndex = 16;
            this.barItem11.ImageList = this.imageList1;
            this.barItem11.LargeImageList = this.largeImageList1;
            this.barItem11.ShowToolTipInPopUp = false;
            this.barItem11.SizeToFit = true;
            this.barItem11.Text = "Item1";
            this.barItem11.Click += new System.EventHandler(this.BarItem_Click);
            this.barItem11.Selected += new System.EventHandler(this.BarItem_Selected);
            // 
            // parentBarItem12
            // 
            this.parentBarItem12.BarName = "parentBarItem12";
            this.parentBarItem12.CategoryIndex = 5;
            this.parentBarItem12.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem12.ID = "&Help";
            this.parentBarItem12.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
             this.barItem19
         
        });
            this.parentBarItem12.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem12.ShowTooltip = false;
            this.parentBarItem12.ShowToolTipInPopUp = false;
            this.parentBarItem12.SizeToFit = true;
            this.parentBarItem12.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem12.Text = "Help";
            toolTipInfo14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(127)))), ((int)(((byte)(213)))));
            toolTipInfo14.Body.Hidden = true;
            toolTipInfo14.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo14.Footer.Hidden = true;
            toolTipInfo14.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo14.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo14.Header.Text = "Help";
            toolTipInfo14.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTipInfo14.Separator = false;
            this.superToolTip1.SetToolTip(this.parentBarItem12, toolTipInfo14);
            this.parentBarItem12.Popup += new System.EventHandler(this.Submenu_Popup);
            this.parentBarItem12.PopupClosed += new System.EventHandler(this.Sumenu_PopupClosed);
            this.parentBarItem12.Selected += new System.EventHandler(this.BarItem_Selected);

            //
            //Office2016Colorfulitem
            //

            this.Office2016Colorful.BarName = "Office2016Colorful";
            this.Office2016Colorful.CategoryIndex = 5;
            this.Office2016Colorful.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Office2016Colorful.ID = "Office2016Colorful";
           
            this.Office2016Colorful.ShowToolTipInPopUp = false;
            this.Office2016Colorful.SizeToFit = true;
            this.Office2016Colorful.Text = "Office2016Colorful";
            this.Office2016Colorful.Click += new System.EventHandler(this.Office2016Colorful_Click);
            //
            //Office2016BlackItem
            //

            this.Office2016Black.BarName = "Office2016Black";
            this.Office2016Black.CategoryIndex = 5;
            this.Office2016Black.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Office2016Black.ID = "Office2016Black";          
            this.Office2016Black.ShowToolTipInPopUp = false;
            this.Office2016Black.SizeToFit = true;
            this.Office2016Black.Text = "Office2016Black";
            this.Office2016Black.Click += new System.EventHandler(this.Office2016Black_Click);
            //
            //Office2016DarkGrayItem
            //

            this.Office2016DarkGray.BarName = "Office2016DarkGray";
            this.Office2016DarkGray.CategoryIndex = 5;
            this.Office2016DarkGray.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Office2016DarkGray.ID = "Office2016DarkGray";         
            this.Office2016DarkGray.ShowToolTipInPopUp = false;
            this.Office2016DarkGray.SizeToFit = true;
            this.Office2016DarkGray.Text = "Office2016DarkGray";
            this.Office2016DarkGray.Click += new System.EventHandler(this.Office2016DarkGray_Click);
            //
            //Office2016WhiteItem
            //
              this.Office2016White.BarName = "Office2016White";
              this.Office2016White.CategoryIndex = 5;
              this.Office2016White.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
              this.Office2016White.ID = "Office2016White";
              this.Office2016White.ShowToolTipInPopUp = false;
              this.Office2016White.SizeToFit = true;
              this.Office2016White.Text = "Office2016White";
              this.Office2016White.Click += new System.EventHandler(this.Office2016White_Click);
              //
              //Office2003Item
              //
              this.Office2003.BarName = "Office2003";
              this.Office2003.CategoryIndex = 5;
              this.Office2003.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
              this.Office2003.ID = "Office2003";              
              this.Office2003.ShowToolTipInPopUp = false;
              this.Office2003.SizeToFit = true;
              this.Office2003.Text = "Office2003";
              this.Office2003.Click += new System.EventHandler(this.Office2003_Click);
              //
              //Metro
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
              //Office2010
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
              //Office2007
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
            // parentBarItem7
            // 
            this.parentBarItem7.BarName = "parentBarItem7";
            this.parentBarItem7.CustomTextFont = new System.Drawing.Font("Calibri", 9.75F);
            this.parentBarItem7.ID = "DropDown1";
            this.parentBarItem7.ImageIndex = 14;
            this.parentBarItem7.ImageList = this.imageList1;
            this.parentBarItem7.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem10});
            this.parentBarItem7.LargeImageList = this.largeImageList1;
            this.parentBarItem7.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem7.ShowToolTipInPopUp = false;
            this.parentBarItem7.SizeToFit = true;
            this.parentBarItem7.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem7.Text = "DropDown1";
            this.parentBarItem7.Popup += new System.EventHandler(this.Submenu_Popup);
            this.parentBarItem7.PopupClosed += new System.EventHandler(this.Sumenu_PopupClosed);
            this.parentBarItem7.Selected += new System.EventHandler(this.BarItem_Selected);
            // 
            // barItem10
            // 
            this.barItem10.BarName = "barItem10";
            this.barItem10.ID = "Button Item1";
            this.barItem10.ShowToolTipInPopUp = false;
            this.barItem10.SizeToFit = true;
            this.barItem10.Text = "Button Item1";
            this.barItem10.Click += new System.EventHandler(this.BarItem_Click);
            // 
            // barItem12
            // 
            this.barItem12.BarName = "barItem12";
            this.barItem12.CustomTextFont = new System.Drawing.Font("Calibri", 9.75F);
            this.barItem12.ID = "Item2";
            this.barItem12.ImageIndex = 17;
            this.barItem12.ImageList = this.imageList1;
            this.barItem12.LargeImageList = this.largeImageList1;
            this.barItem12.ShowToolTipInPopUp = false;
            this.barItem12.SizeToFit = true;
            this.barItem12.Text = "Item2";
            this.barItem12.Click += new System.EventHandler(this.BarItem_Click);
            this.barItem12.Selected += new System.EventHandler(this.BarItem_Selected);
            // 
            // barItem13
            // 
            this.barItem13.BarName = "barItem13";
            this.barItem13.CustomTextFont = new System.Drawing.Font("Calibri", 9.75F);
            this.barItem13.ID = "Item3";
            this.barItem13.ImageIndex = 18;
            this.barItem13.ImageList = this.imageList1;
            this.barItem13.LargeImageList = this.largeImageList1;
            this.barItem13.ShowToolTipInPopUp = false;
            this.barItem13.SizeToFit = true;
            this.barItem13.Text = "Item3";
            this.barItem13.Click += new System.EventHandler(this.BarItem_Click);
            this.barItem13.Selected += new System.EventHandler(this.BarItem_Selected);
            // 
            // barItem8
            // 
            this.barItem8.BarName = "barItem8";
            this.barItem8.ID = "Item1";
            this.barItem8.ImageIndex = 12;
            this.barItem8.ImageList = this.imageList1;
            this.barItem8.ShowToolTipInPopUp = false;
            this.barItem8.SizeToFit = true;
            this.barItem8.Text = "Item1";
            this.barItem8.Click += new System.EventHandler(this.BarItem_Click);
            // 
            // dropDownBarItem3
            // 
            this.dropDownBarItem3.BarName = "dropDownBarItem3";
            this.dropDownBarItem3.ImageIndex = 15;
            this.dropDownBarItem3.ImageList = this.imageList1;
            this.dropDownBarItem3.PopupControlContainer = this.popupControlContainer1;
            this.dropDownBarItem3.ShowToolTipInPopUp = false;
            this.dropDownBarItem3.SizeToFit = true;
            this.dropDownBarItem3.Click += new System.EventHandler(this.BarItem_Click);
            this.dropDownBarItem3.Selected += new System.EventHandler(this.BarItem_Selected);
            // 
            // barItem9
            // 
            this.barItem9.BarName = "barItem9";
            this.barItem9.ID = "Item2";
            this.barItem9.ImageIndex = 13;
            this.barItem9.ImageList = this.imageList1;
            this.barItem9.ShowToolTipInPopUp = false;
            this.barItem9.SizeToFit = true;
            this.barItem9.Text = "Item2";
            this.barItem9.Click += new System.EventHandler(this.BarItem_Click);
            // 
            // popupMenu1
            // 
            this.popupMenu1.ParentBarItem = this.parentBarItem2;
            // 
            // popupMenu2
            // 
            this.popupMenu2.ParentBarItem = this.parentBarItem8;
            // 
            // parentBarItem8
            // 
            this.parentBarItem8.BarName = "parentBarItem8";
            this.parentBarItem8.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem8.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem11,
            this.barItem12,
            this.barItem13,
            this.parentBarItem9,
            this.comboBoxBarItem3});
            this.parentBarItem8.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem8.SeparatorIndices.AddRange(new int[] {
            3});
            this.parentBarItem8.ShowToolTipInPopUp = false;
            this.parentBarItem8.SizeToFit = true;
            this.parentBarItem8.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItem8.Popup += new System.EventHandler(this.Submenu_Popup);
            this.parentBarItem8.PopupClosed += new System.EventHandler(this.Sumenu_PopupClosed);
            this.parentBarItem8.Selected += new System.EventHandler(this.BarItem_Selected);
            // 
            // parentBarItem9
            // 
            this.parentBarItem9.BarName = "parentBarItem9";
            this.parentBarItem9.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.parentBarItem9.ID = "SubMenu";
            this.parentBarItem9.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem14,
            this.barItem15});
            this.parentBarItem9.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem9.ShowToolTipInPopUp = false;
            this.parentBarItem9.SizeToFit = true;
            this.parentBarItem9.Text = "SubMenu";
            this.parentBarItem9.Popup += new System.EventHandler(this.Submenu_Popup);
            this.parentBarItem9.PopupClosed += new System.EventHandler(this.Sumenu_PopupClosed);
            this.parentBarItem9.Selected += new System.EventHandler(this.BarItem_Selected);
            // 
            // barItem14
            // 
            this.barItem14.BarName = "barItem14";
            this.barItem14.ID = "SubItem1";
            this.barItem14.ShowToolTipInPopUp = false;
            this.barItem14.SizeToFit = true;
            this.barItem14.Text = "SubItem1";
            this.barItem14.Click += new System.EventHandler(this.BarItem_Click);
            this.barItem14.Selected += new System.EventHandler(this.BarItem_Selected);
            // 
            // barItem15
            // 
            this.barItem15.BarName = "barItem15";
            this.barItem15.ID = "SubItem2";
            this.barItem15.ShowToolTipInPopUp = false;
            this.barItem15.SizeToFit = true;
            this.barItem15.Text = "SubItem2";
            this.barItem15.Click += new System.EventHandler(this.BarItem_Click);
            this.barItem15.Selected += new System.EventHandler(this.BarItem_Selected);
            // 
            // comboBoxBarItem3
            // 
            this.comboBoxBarItem3.AutoAppend = true;
            this.comboBoxBarItem3.BarName = "comboBoxBarItem3";
            this.comboBoxBarItem3.ChoiceList.AddRange(new string[] {
            "Item 1",
            "Item 2",
            "Item 3"});
            this.comboBoxBarItem3.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboBoxBarItem3.ID = "Combo:";
            this.comboBoxBarItem3.MinWidth = 70;
            this.comboBoxBarItem3.ShowToolTipInPopUp = false;
            this.comboBoxBarItem3.SizeToFit = true;
            this.comboBoxBarItem3.Text = "Combo:";
            this.comboBoxBarItem3.Click += new System.EventHandler(this.BarItem_Click);
            this.comboBoxBarItem3.Selected += new System.EventHandler(this.BarItem_Selected);
            // 
            // popupMenusManager1
            // 
            this.popupMenusManager1.ParentForm = this;
            // 
            // barItem20
            // 
            this.barItem20.BarName = "barItem20";
            this.barItem20.ShowToolTipInPopUp = false;
            this.barItem20.SizeToFit = true;
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.DrawFocusRectangle = false;
            this.checkBoxAdv1.Location = new System.Drawing.Point(514, 13);
            this.checkBoxAdv1.MetroColor = System.Drawing.Color.Gray;
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(150, 21);
            this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv1.TabIndex = 5;
            this.checkBoxAdv1.Text = "PersistAutoAppendList";
            this.checkBoxAdv1.ThemesEnabled = false;
            this.checkBoxAdv1.CheckedChanged += new System.EventHandler(this.checkBoxAdv1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.White;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientSize = new System.Drawing.Size(664, 423);
            this.Controls.Add(this.checkBoxAdv1);
            this.Controls.Add(this.panel1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.IconTextRelation = System.Windows.Forms.LeftRightAlignment.Left;
            this.MetroColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SDI Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem2)).EndInit();
            this.popupControlContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        #region Main
        /// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
            Application.Run(new Form1());
        }
        #endregion

        #region Event Handlers for Tracing
        private void BarItem_Click(object sender, System.EventArgs e)
		{
			if(sender is BarItem)
			{
				BarItem barItem = sender as BarItem;
				this.MyTraceLine(barItem.Text + " Clicked.");
			}
			else
				this.MyTraceLine("Unknown Item Clicked.");
		}

		private void BarItem_Selected(object sender, System.EventArgs e)
		{
			if(sender is BarItem)
			{
				BarItem barItem = sender as BarItem;
				this.staticBarItem1.Text = barItem.Text;
				this.MyTraceLine(barItem.Text + " Selected.");
			}
			else
				this.MyTraceLine("Unknown Item Selected.");
		}

		private void Submenu_Popup(object sender, System.EventArgs e)
		{
			if(sender is ParentBarItem)
			{
				ParentBarItem barItem = sender as ParentBarItem;
				this.MyTraceLine(barItem.Text + " Popup.");
			}
			else
				this.MyTraceLine("Unknown Item Popup.");
		}

		private void Sumenu_PopupClosed(object sender, System.EventArgs e)
		{
			if(sender is ParentBarItem)
			{
				ParentBarItem barItem = sender as ParentBarItem;
				this.MyTraceLine(barItem.Text + " PopupClosed.");
			}
			else
			{
				this.MyTraceLine("Unknown Item PopupClosed.");
			}
		}

		private void Customization_Begin(object sender, System.EventArgs e)
		{
			this.MyTraceLine("CustomizationBegin occured.");
		}

		private void Customization_Done(object sender, System.EventArgs e)
		{
			this.MyTraceLine("CustomizationDone occured.");
		}
		private void MyTraceLine(string text)
		{
			this.richTextBox1.Text += text + "\r\n";
			this.richTextBox1.SelectionStart = 10000;
		}
		private void Clear_Events(object sender, System.EventArgs e)
		{
			// Forwarding for tracing
			this.BarItem_Click(sender, e);

			this.richTextBox1.Text = String.Empty;
		}
		#endregion 

		#region ColorUI DropDown
		private void fontColorBarItem_Click(object sender, System.EventArgs e)
		{
			// Forward for tracing.
			this.BarItem_Click(sender, e);

			this.UpdateRichTextColor();
		}
		private void UpdateRichTextColor()
		{
			// Set the selection's color to be the ColorUI's Selected Color.
			this.richTextBox1.SelectAll();
			this.richTextBox1.SelectionColor = this.colorUIControl1.SelectedColor;
			this.richTextBox1.SelectionStart = this.richTextBox1.SelectionLength;
		}


		private void colorUIControl1_ColorSelected(object sender, System.EventArgs e)
		{
			this.UpdateDropdownImageColor(this.colorUIControl1.SelectedColor);
			// Close the popup, now that a Color was selected
			this.popupControlContainer1.HidePopup(PopupCloseType.Done);

			this.UpdateRichTextColor();
		}

		private void UpdateDropdownImageColor(Color newColor)
		{
			// Create a new bitmap off the base image.
			Image newImage = this.baseImage.Clone() as Image;
			Bitmap newBitmap = new Bitmap(newImage);
			
			// Set the Color cue pixels to the appropriate color.
			for(int i = 13; i <= 15; i++)
				for(int j = 1; j <= 13; j++)
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

		#region Sample App Logic
		private void Form1_Load(object sender, System.EventArgs e)
		{
			// Update the Font Color BarItem image.
			this.InitBaseImage();
			this.colorUIControl1.SelectedColor = Color.Black;
            this.mainFrameBarManager1.MainMenuBar.DrawBackground += new PaintEventHandler(MainMenuBar_DrawBackground);
		}

        void MainMenuBar_DrawBackground(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White,e.ClipRectangle);
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.richTextBox1.Text.Length > 0)
            {
                this.richTextBox1.SelectionStart = this.richTextBox1.Text.Length - 1;
                this.richTextBox1.ScrollToCaret();
            }
        }

        private void barItem7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
		#endregion



        /// <summary>
        /// Click event for office2016Colorful visualstyle 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Office2016Colorful_Click(object sender, System.EventArgs e)
        {
            this.mainFrameBarManager1.Style = VisualStyle.Office2016Colorful;
        }
        /// <summary>
        /// Click event for office201White visualstyle 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Office2016White_Click(object sender, System.EventArgs e)
        {
            this.mainFrameBarManager1.Style = VisualStyle.Office2016White;
        }
        /// <summary>
        /// Click event for office2016DarkGray visualstyle 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Office2016DarkGray_Click(object sender, System.EventArgs e)
        {
            this.mainFrameBarManager1.Style = VisualStyle.Office2016DarkGray;
        }
        /// <summary>
        /// Click event for office2016Black visualstyle 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Office2016Black_Click(object sender, System.EventArgs e)
        {
            this.mainFrameBarManager1.Style = VisualStyle.Office2016Black;
        }
        /// <summary>
        /// Click event for Metro visualstyle 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Metro_Click(object sender, System.EventArgs e)
        {
            this.mainFrameBarManager1.Style = VisualStyle.Metro;
        }
        /// <summary>
        /// Click event for Office2007 visualstyle 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Office2007_Click(object sender, System.EventArgs e)
        {
            this.mainFrameBarManager1.Style = VisualStyle.Office2007;
        }
        /// <summary>
        /// Click event for Office2010 visualstyle 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Office2010_Click(object sender, System.EventArgs e)
        {
            this.mainFrameBarManager1.Style = VisualStyle.Office2010;
        }
        /// <summary>
        /// Click event for Office2003 visualstyle 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Office2003_Click(object sender, System.EventArgs e)
        {
            this.mainFrameBarManager1.Style = VisualStyle.Office2003;
        }

        private void barItem19_Click(object sender, EventArgs e)
        {
            DemoCommon.AboutForm frm = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            frm.ShowDialog();
        }

        private void checkBoxAdv1_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBoxBarItem1.PersistAutoAppendList = this.checkBoxAdv1.Checked;
        }

       
	}
}
