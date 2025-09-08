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
using Syncfusion.Drawing;
using Syncfusion.Licensing;

namespace ControlBars
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
		private Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem3;
		private System.Windows.Forms.ImageList imageList1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem3;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem comboBoxBarItem1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem comboBoxBarItem2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem5;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ToolbarListBarItem toolbarListBarItem1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem6;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ListBarItem listBarItem1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem7;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem8;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem9;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem7;
		private Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem dropDownBarItem3;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem10;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem8;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem11;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem12;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem13;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem9;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem14;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem15;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem comboBoxBarItem3;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem10;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem16;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem17;
		private Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem fontColorBarItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem11;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem19;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem20;
        private System.Windows.Forms.ListView listView1;
		private Syncfusion.Windows.Forms.Tools.ControlBar controlBar1;
		private System.Windows.Forms.Panel taskPanel;
		private Syncfusion.Windows.Forms.Tools.ControlBar controlBar2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar xpTaskPaneToolbar;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biTaskPrevious;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biTaskNext;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biTaskHome;
		private Syncfusion.Windows.Forms.Tools.CardLayout cardLayout1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu popupMenu1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem12;
		private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
		private Syncfusion.Windows.Forms.Tools.GradientPanel pnlGettingStarted;
		private Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar xpToolBar2;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.LinkLabel linkLabel11;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.LinkLabel linkLabel12;
		private System.Windows.Forms.LinkLabel linkLabel13;
        private System.Windows.Forms.LinkLabel linkLabel14;
		private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.LinkLabel linkLabel15;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.LinkLabel linkLabel16;
		private Syncfusion.Windows.Forms.Tools.GradientPanel pnlSearchOptions;
		private Syncfusion.Windows.Forms.Tools.XPTaskBar xpTaskBar1;
		private Syncfusion.Windows.Forms.Tools.XPTaskBarBox xpTaskBarBox1;
        private Syncfusion.Windows.Forms.Tools.XPTaskBarBox xpTaskBarBox2;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label27;
		private Syncfusion.Windows.Forms.Tools.GradientPanel pnlNewDocument;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.LinkLabel linkLabel17;
		private System.Windows.Forms.LinkLabel linkLabel18;
		private System.Windows.Forms.LinkLabel linkLabel19;
		private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.LinkLabel linkLabel20;
		private System.ComponentModel.IContainer components;

		private int nReportCount = 0;
		private int nLetterCount = 0;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem4;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem5;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biGettingStarted;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biNewDocument;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biSearchOptions;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem6;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem18;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem21;
		private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
		private System.Windows.Forms.ImageList LargeimageList;
        private ComboBoxAdv comboBoxAdv3;
        private ButtonAdv buttonAdv1;
        private ComboBoxAdv comboBoxAdv2;
        private ButtonAdv buttonAdv2;
        private PopupControlContainer popupControlContainer1;
        private ColorPickerUIAdv colorPickerUIAdv1;
        private DropDownBarItem dropDownBarItem1;
		private int nInvoiceCount = 0;

		public Form1()
		{
			InitializeComponent();
            this.MinimumSize = this.Size;
			ControlBars.TextForm txtform = new TextForm();
			txtform.TopLevel = false;
			txtform.MdiParent = this;
			txtform.Show();
			txtform.Text = String.Concat("Report ", (++nReportCount).ToString());
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

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Project Management"}, 13, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Calibri", 9.75F));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Sections"}, 0, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Calibri", 9.75F));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Introduction"}, 14, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Calibri", 9.75F));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Planning"}, 15, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Calibri", 9.75F));
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Departments"}, 18, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Calibri", 9.75F));
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Review 1"}, 13, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Calibri", 9.75F));
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Review 2"}, 13, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Calibri", 9.75F));
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "Records"}, 2, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Calibri", 9.75F));
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "Inventory"}, 22, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Calibri", 9.75F));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "MainMenu");
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.parentBarItem10 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem16 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem17 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.listBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ListBarItem();
            this.barItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.toolbarListBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ToolbarListBarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem11 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem19 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.dropDownBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem();
            this.popupControlContainer1 = new Syncfusion.Windows.Forms.PopupControlContainer(this.components);
            this.colorPickerUIAdv1 = new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv();
            this.bar2 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "File");
            this.controlBar1 = new Syncfusion.Windows.Forms.Tools.ControlBar();
            this.xpTaskPaneToolbar = new Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar();
            this.biTaskPrevious = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.biTaskNext = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biTaskHome = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.taskPanel = new System.Windows.Forms.Panel();
            this.pnlGettingStarted = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label24 = new System.Windows.Forms.Label();
            this.linkLabel15 = new System.Windows.Forms.LinkLabel();
            this.label25 = new System.Windows.Forms.Label();
            this.linkLabel16 = new System.Windows.Forms.LinkLabel();
            this.label20 = new System.Windows.Forms.Label();
            this.linkLabel11 = new System.Windows.Forms.LinkLabel();
            this.label21 = new System.Windows.Forms.Label();
            this.comboBoxAdv3 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.linkLabel12 = new System.Windows.Forms.LinkLabel();
            this.linkLabel13 = new System.Windows.Forms.LinkLabel();
            this.linkLabel14 = new System.Windows.Forms.LinkLabel();
            this.xpToolBar2 = new Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar();
            this.barItem11 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem10 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem12 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem13 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.pnlNewDocument = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.linkLabel20 = new System.Windows.Forms.LinkLabel();
            this.label33 = new System.Windows.Forms.Label();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.linkLabel17 = new System.Windows.Forms.LinkLabel();
            this.linkLabel18 = new System.Windows.Forms.LinkLabel();
            this.linkLabel19 = new System.Windows.Forms.LinkLabel();
            this.pnlSearchOptions = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.xpTaskBar1 = new Syncfusion.Windows.Forms.Tools.XPTaskBar();
            this.xpTaskBarBox1 = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.xpTaskBarBox2 = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.comboBoxAdv2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.LargeimageList = new System.Windows.Forms.ImageList(this.components);
            this.popupMenu1 = new Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(this.components);
            this.parentBarItem12 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.biGettingStarted = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biNewDocument = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biSearchOptions = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem18 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem21 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.controlBar2 = new Syncfusion.Windows.Forms.Tools.ControlBar();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.listView1 = new System.Windows.Forms.ListView();
            this.parentBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.comboBoxBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem();
            this.comboBoxBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem();
            this.fontColorBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem();
            this.barItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.dropDownBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem();
            this.barItem9 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.parentBarItem9 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem14 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem15 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.comboBoxBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem();
            this.barItem20 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.cardLayout1 = new Syncfusion.Windows.Forms.Tools.CardLayout(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            this.popupControlContainer1.SuspendLayout();
            this.controlBar1.SuspendLayout();
            this.taskPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGettingStarted)).BeginInit();
            this.pnlGettingStarted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlNewDocument)).BeginInit();
            this.pnlNewDocument.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearchOptions)).BeginInit();
            this.pnlSearchOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar1)).BeginInit();
            this.xpTaskBar1.SuspendLayout();
            this.xpTaskBarBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).BeginInit();
            this.controlBar2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardLayout1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainFrameBarManager1
            // 
            this.mainFrameBarManager1.AutoLoadToolBarPositions = false;
            this.mainFrameBarManager1.AutoPersistCustomization = false;
#if !NETCORE
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
#endif
            this.mainFrameBarManager1.Bars.Add(this.bar1);
            this.mainFrameBarManager1.Bars.Add(this.bar2);
            this.mainFrameBarManager1.Categories.Add("File");
            this.mainFrameBarManager1.Categories.Add("Format");
            this.mainFrameBarManager1.Categories.Add("View");
            this.mainFrameBarManager1.Categories.Add("Popups");
            this.mainFrameBarManager1.Categories.Add("Help");
            this.mainFrameBarManager1.Categories.Add("Misc");
            this.mainFrameBarManager1.Categories.Add("Custom color");
            this.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.MetroForm";
            this.mainFrameBarManager1.DetachedCommandBars.Add(this.controlBar1);
            this.mainFrameBarManager1.DetachedCommandBars.Add(this.controlBar2);
            this.mainFrameBarManager1.EnableCustomizing = false;
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.ImageList = this.imageList1;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem10,
            this.parentBarItem1,
            this.barItem2,
            this.barItem3,
            this.parentBarItem6,
            this.listBarItem1,
            this.barItem7,
            this.parentBarItem3,
            this.comboBoxBarItem1,
            this.comboBoxBarItem2,
            this.fontColorBarItem,
            this.parentBarItem5,
            this.toolbarListBarItem1,
            this.barItem1,
            this.barItem16,
            this.barItem17,
            this.parentBarItem11,
            this.barItem19,
            this.barItem4,
            this.barItem5,
            this.dropDownBarItem1});
            this.mainFrameBarManager1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
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
            this.parentBarItem5,
            this.parentBarItem11,
            this.dropDownBarItem1});
            this.bar1.Manager = this.mainFrameBarManager1;
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.BarName = "parentBarItem1";
            this.parentBarItem1.CategoryIndex = 3;
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
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem1.Text = "&File";
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
            this.parentBarItem10.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.parentBarItem10.ShowToolTipInPopUp = false;
            this.parentBarItem10.SizeToFit = true;
            this.parentBarItem10.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem10.Text = "&New";
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.CategoryIndex = 0;
            this.barItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem1.ID = "New1";
            this.barItem1.ImageIndex = 14;
            this.barItem1.ShowToolTipInPopUp = false;
            this.barItem1.SizeToFit = true;
            this.barItem1.Text = "Letter";
            this.barItem1.Click += new System.EventHandler(this.barItem1_Click);
            // 
            // barItem16
            // 
            this.barItem16.BarName = "barItem16";
            this.barItem16.CategoryIndex = 0;
            this.barItem16.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem16.ID = "New2";
            this.barItem16.ImageIndex = 15;
            this.barItem16.ShowToolTipInPopUp = false;
            this.barItem16.SizeToFit = true;
            this.barItem16.Text = "Report";
            this.barItem16.Click += new System.EventHandler(this.barItem16_Click);
            // 
            // barItem17
            // 
            this.barItem17.BarName = "barItem17";
            this.barItem17.CategoryIndex = 0;
            this.barItem17.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem17.ID = "New3";
            this.barItem17.ImageIndex = 13;
            this.barItem17.ShowToolTipInPopUp = false;
            this.barItem17.SizeToFit = true;
            this.barItem17.Text = "Invoice";
            this.barItem17.Click += new System.EventHandler(this.barItem17_Click);
            // 
            // barItem2
            // 
            this.barItem2.BarName = "barItem2";
            this.barItem2.CategoryIndex = 0;
            this.barItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem2.ID = "&Open";
            this.barItem2.ImageIndex = 1;
            this.barItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.barItem2.ShowToolTipInPopUp = false;
            this.barItem2.SizeToFit = true;
            this.barItem2.Text = "&Open";
            // 
            // barItem3
            // 
            this.barItem3.BarName = "barItem3";
            this.barItem3.CategoryIndex = 0;
            this.barItem3.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem3.ID = "&Save";
            this.barItem3.ImageIndex = 2;
            this.barItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.barItem3.ShowToolTipInPopUp = false;
            this.barItem3.SizeToFit = true;
            this.barItem3.Text = "&Save";
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
            // 
            // parentBarItem5
            // 
            this.parentBarItem5.BarName = "parentBarItem5";
            this.parentBarItem5.CategoryIndex = 3;
            this.parentBarItem5.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem5.ID = "&View";
            this.parentBarItem5.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.toolbarListBarItem1,
            this.barItem4,
            this.barItem5});
            this.parentBarItem5.MergeOrder = 2;
            this.parentBarItem5.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem5.ShowToolTipInPopUp = false;
            this.parentBarItem5.SizeToFit = true;
            this.parentBarItem5.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem5.Text = "&View";
            this.parentBarItem5.Popup += new System.EventHandler(this.parentBarItem5_Popup);
            // 
            // toolbarListBarItem1
            // 
            this.toolbarListBarItem1.BarName = "toolbarListBarItem1";
            this.toolbarListBarItem1.CategoryIndex = 2;
            this.toolbarListBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolbarListBarItem1.ID = "Toolbar List";
            this.toolbarListBarItem1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.toolbarListBarItem1.ShowToolTipInPopUp = false;
            this.toolbarListBarItem1.SizeToFit = true;
            this.toolbarListBarItem1.Text = "Toolbar List";
            // 
            // barItem4
            // 
            this.barItem4.BarName = "barItem4";
            this.barItem4.CategoryIndex = 2;
            this.barItem4.Checked = true;
            this.barItem4.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem4.ID = "Task Pane";
            this.barItem4.ShowToolTipInPopUp = false;
            this.barItem4.SizeToFit = true;
            this.barItem4.Text = "&Task Pane";
            this.barItem4.Click += new System.EventHandler(this.barItem4_Click);
            // 
            // barItem5
            // 
            this.barItem5.BarName = "barItem5";
            this.barItem5.CategoryIndex = 2;
            this.barItem5.Checked = true;
            this.barItem5.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem5.ID = "Properties Pane";
            this.barItem5.ShowToolTipInPopUp = false;
            this.barItem5.SizeToFit = true;
            this.barItem5.Text = "&Properties Pane";
            this.barItem5.Click += new System.EventHandler(this.barItem5_Click);
            // 
            // parentBarItem11
            // 
            this.parentBarItem11.BarName = "parentBarItem11";
            this.parentBarItem11.CategoryIndex = 3;
            this.parentBarItem11.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem11.ID = "&Help";
            this.parentBarItem11.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem19});
            this.parentBarItem11.MergeOrder = 5;
            this.parentBarItem11.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem11.ShowToolTipInPopUp = false;
            this.parentBarItem11.SizeToFit = true;
            this.parentBarItem11.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem11.Text = "&Help";
            // 
            // barItem19
            // 
            this.barItem19.BarName = "barItem19";
            this.barItem19.CategoryIndex = 4;
            this.barItem19.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem19.ID = "About Syncfusion";
            this.barItem19.ImageIndex = 41;
            this.barItem19.ShowToolTipInPopUp = false;
            this.barItem19.SizeToFit = true;
            this.barItem19.Text = "About Syncfusion";
            this.barItem19.Click += new System.EventHandler(this.barItem19_Click);
            // 
            // dropDownBarItem1
            // 
            this.dropDownBarItem1.BarName = "dropDownBarItem1";
            this.dropDownBarItem1.CategoryIndex = 6;
            this.dropDownBarItem1.ID = "BarItem";
            this.dropDownBarItem1.PopupControlContainer = this.popupControlContainer1;
            this.dropDownBarItem1.ShowToolTipInPopUp = false;
            this.dropDownBarItem1.SizeToFit = true;
            this.dropDownBarItem1.Text = "CustomColor";
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.Controls.Add(this.colorPickerUIAdv1);
            this.popupControlContainer1.Location = new System.Drawing.Point(324, 305);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Size = new System.Drawing.Size(182, 234);
            this.popupControlContainer1.TabIndex = 8;
            this.popupControlContainer1.Visible = false;
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
            this.colorPickerUIAdv1.HorizontalItemsSpacing = 7;
            this.colorPickerUIAdv1.Location = new System.Drawing.Point(0, 0);
            this.colorPickerUIAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.colorPickerUIAdv1.MinimumSize = new System.Drawing.Size(136, 195);
            this.colorPickerUIAdv1.Name = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(207)))), ((int)(((byte)(222)))));
            this.colorPickerUIAdv1.Size = new System.Drawing.Size(199, 199);
            this.colorPickerUIAdv1.Style = Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.visualstyle.Metro;
            this.colorPickerUIAdv1.TabIndex = 7;
            this.colorPickerUIAdv1.Text = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.UseOffice2007Style = false;
            this.colorPickerUIAdv1.VerticalItemsSpacing = 1;
            this.colorPickerUIAdv1.Picked += new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventHandler(this.colorPickerUIAdv1_Picked_1);
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
            // controlBar1
            // 
            this.controlBar1.AllowedDockBorders = ((Syncfusion.Windows.Forms.Tools.CommandBarDockBorder)((Syncfusion.Windows.Forms.Tools.CommandBarDockBorder.Left | Syncfusion.Windows.Forms.Tools.CommandBarDockBorder.Right)));
            this.controlBar1.CaptionControl = this.xpTaskPaneToolbar;
            this.controlBar1.ChevronColor = System.Drawing.SystemColors.ControlText;
            this.controlBar1.ControlBarCaptionHeight = 31;
            this.controlBar1.Controls.Add(this.taskPanel);
            this.controlBar1.Controls.Add(this.xpTaskPaneToolbar);
            this.controlBar1.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Left;
            this.controlBar1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlBar1.MaxLength = 250;
            this.controlBar1.MinHeight = 250;
            this.controlBar1.MinLength = 50;
            this.controlBar1.Name = "controlBar1";
            this.controlBar1.PopupMenu = this.popupMenu1;
            this.controlBar1.RowIndex = 0;
            this.controlBar1.TabIndex = 0;
            this.controlBar1.TabStop = false;
            this.controlBar1.Text = "Getting Started";
            this.controlBar1.CommandBarStateChanged += new System.EventHandler(this.controlBar1_CommandBarStateChanged);
            // 
            // xpTaskPaneToolbar
            // 
            this.xpTaskPaneToolbar.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.xpTaskPaneToolbar.Bar.BarName = "";
            this.xpTaskPaneToolbar.Bar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.biTaskPrevious,
            this.biTaskNext,
            this.biTaskHome});
            this.xpTaskPaneToolbar.Bar.Manager = null;
            this.xpTaskPaneToolbar.Location = new System.Drawing.Point(2, 33);
            this.xpTaskPaneToolbar.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.xpTaskPaneToolbar.Name = "xpTaskPaneToolbar";
            this.xpTaskPaneToolbar.Size = new System.Drawing.Size(218, 25);
            this.xpTaskPaneToolbar.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.xpTaskPaneToolbar.TabIndex = 29;
            this.xpTaskPaneToolbar.Text = "xpToolBar2";
            // 
            // biTaskPrevious
            // 
            this.biTaskPrevious.BarName = "biTaskPrevious";
            this.biTaskPrevious.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.biTaskPrevious.ID = "BarItem";
            this.biTaskPrevious.ImageIndex = 37;
            this.biTaskPrevious.ImageList = this.imageList1;
            this.biTaskPrevious.ShowToolTipInPopUp = false;
            this.biTaskPrevious.SizeToFit = true;
            this.biTaskPrevious.Click += new System.EventHandler(this.biTaskPrevious_Click);
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
            this.imageList1.Images.SetKeyName(23, "");
            this.imageList1.Images.SetKeyName(24, "");
            this.imageList1.Images.SetKeyName(25, "");
            this.imageList1.Images.SetKeyName(26, "");
            this.imageList1.Images.SetKeyName(27, "");
            this.imageList1.Images.SetKeyName(28, "");
            this.imageList1.Images.SetKeyName(29, "");
            this.imageList1.Images.SetKeyName(30, "");
            this.imageList1.Images.SetKeyName(31, "");
            this.imageList1.Images.SetKeyName(32, "");
            this.imageList1.Images.SetKeyName(33, "");
            this.imageList1.Images.SetKeyName(34, "");
            this.imageList1.Images.SetKeyName(35, "");
            this.imageList1.Images.SetKeyName(36, "");
            this.imageList1.Images.SetKeyName(37, "");
            this.imageList1.Images.SetKeyName(38, "");
            this.imageList1.Images.SetKeyName(39, "");
            this.imageList1.Images.SetKeyName(40, "");
            this.imageList1.Images.SetKeyName(41, "");
            // 
            // biTaskNext
            // 
            this.biTaskNext.BarName = "biTaskNext";
            this.biTaskNext.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.biTaskNext.ID = "BarItem";
            this.biTaskNext.ImageIndex = 38;
            this.biTaskNext.ImageList = this.imageList1;
            this.biTaskNext.ShowToolTipInPopUp = false;
            this.biTaskNext.SizeToFit = true;
            this.biTaskNext.Click += new System.EventHandler(this.biTaskNext_Click);
            // 
            // biTaskHome
            // 
            this.biTaskHome.BarName = "biTaskHome";
            this.biTaskHome.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.biTaskHome.ID = "BarItem";
            this.biTaskHome.ImageIndex = 39;
            this.biTaskHome.ImageList = this.imageList1;
            this.biTaskHome.ShowToolTipInPopUp = false;
            this.biTaskHome.SizeToFit = true;
            this.biTaskHome.Click += new System.EventHandler(this.biTaskHome_Click);
            // 
            // taskPanel
            // 
            this.taskPanel.Controls.Add(this.pnlGettingStarted);
            this.taskPanel.Controls.Add(this.pnlNewDocument);
            this.taskPanel.Controls.Add(this.pnlSearchOptions);
            this.taskPanel.Location = new System.Drawing.Point(2, 58);
            this.taskPanel.Name = "taskPanel";
            this.taskPanel.Size = new System.Drawing.Size(246, 520);
            this.taskPanel.TabIndex = 29;
            // 
            // pnlGettingStarted
            // 
            this.pnlGettingStarted.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.cardLayout1.SetCardName(this.pnlGettingStarted, "GettingStarted");
            this.pnlGettingStarted.Controls.Add(this.gradientPanel2);
            this.pnlGettingStarted.Controls.Add(this.label20);
            this.pnlGettingStarted.Controls.Add(this.linkLabel11);
            this.pnlGettingStarted.Controls.Add(this.label21);
            this.pnlGettingStarted.Controls.Add(this.comboBoxAdv3);
            this.pnlGettingStarted.Controls.Add(this.label22);
            this.pnlGettingStarted.Controls.Add(this.label23);
            this.pnlGettingStarted.Controls.Add(this.linkLabel12);
            this.pnlGettingStarted.Controls.Add(this.linkLabel13);
            this.pnlGettingStarted.Controls.Add(this.linkLabel14);
            this.pnlGettingStarted.Controls.Add(this.xpToolBar2);
            this.pnlGettingStarted.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlGettingStarted.Location = new System.Drawing.Point(0, 0);
            this.cardLayout1.SetMinimumSize(this.pnlGettingStarted, new System.Drawing.Size(176, 232));
            this.pnlGettingStarted.Name = "pnlGettingStarted";
            this.cardLayout1.SetPreferredSize(this.pnlGettingStarted, new System.Drawing.Size(176, 232));
            this.pnlGettingStarted.Size = new System.Drawing.Size(246, 520);
            this.pnlGettingStarted.TabIndex = 29;
            this.pnlGettingStarted.Tag = "Getting Started";
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanel2.BorderColor = System.Drawing.Color.Silver;
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel2.Controls.Add(this.label24);
            this.gradientPanel2.Controls.Add(this.linkLabel15);
            this.gradientPanel2.Controls.Add(this.label25);
            this.gradientPanel2.Controls.Add(this.linkLabel16);
            this.gradientPanel2.Location = new System.Drawing.Point(11, 287);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(221, 73);
            this.gradientPanel2.TabIndex = 49;
            // 
            // label24
            // 
            this.label24.Image = ((System.Drawing.Image)(resources.GetObject("label24.Image")));
            this.label24.Location = new System.Drawing.Point(6, 47);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(16, 16);
            this.label24.TabIndex = 40;
            // 
            // linkLabel15
            // 
            this.linkLabel15.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel15.Location = new System.Drawing.Point(40, 47);
            this.linkLabel15.Name = "linkLabel15";
            this.linkLabel15.Size = new System.Drawing.Size(168, 24);
            this.linkLabel15.TabIndex = 39;
            this.linkLabel15.TabStop = true;
            this.linkLabel15.Text = "Create a New Document...";
            // 
            // label25
            // 
            this.label25.ImageIndex = 1;
            this.label25.ImageList = this.imageList1;
            this.label25.Location = new System.Drawing.Point(6, 7);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(16, 16);
            this.label25.TabIndex = 38;
            // 
            // linkLabel16
            // 
            this.linkLabel16.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel16.Location = new System.Drawing.Point(40, 7);
            this.linkLabel16.Name = "linkLabel16";
            this.linkLabel16.Size = new System.Drawing.Size(168, 24);
            this.linkLabel16.TabIndex = 37;
            this.linkLabel16.TabStop = true;
            this.linkLabel16.Text = "Open...";
            // 
            // label20
            // 
            this.label20.ImageIndex = 40;
            this.label20.ImageList = this.imageList1;
            this.label20.Location = new System.Drawing.Point(8, 119);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(16, 8);
            this.label20.TabIndex = 47;
            // 
            // linkLabel11
            // 
            this.linkLabel11.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel11.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel11.Location = new System.Drawing.Point(32, 115);
            this.linkLabel11.Name = "linkLabel11";
            this.linkLabel11.Size = new System.Drawing.Size(40, 16);
            this.linkLabel11.TabIndex = 46;
            this.linkLabel11.TabStop = true;
            this.linkLabel11.Text = "More...";
            // 
            // label21
            // 
            this.label21.ImageIndex = 40;
            this.label21.ImageList = this.imageList1;
            this.label21.Location = new System.Drawing.Point(8, 96);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(16, 8);
            this.label21.TabIndex = 45;
            // 
            // comboBoxAdv3
            // 
            this.comboBoxAdv3.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv3.Items.AddRange(new object[] {
            "Custom Document Format 1",
            "Custom Document Format 2",
            "Letter Format",
            "Record Format",
            "Editorial Format",
            "Application Format"});
            this.comboBoxAdv3.Location = new System.Drawing.Point(8, 225);
            this.comboBoxAdv3.Name = "comboBoxAdv3";
            this.comboBoxAdv3.Size = new System.Drawing.Size(198, 21);
            this.comboBoxAdv3.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv3.TabIndex = 24;
            this.comboBoxAdv3.Text = "Custom Document Format 1";
            // 
            // label22
            // 
            this.label22.ImageIndex = 40;
            this.label22.ImageList = this.imageList1;
            this.label22.Location = new System.Drawing.Point(8, 72);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(16, 8);
            this.label22.TabIndex = 44;
            // 
            // label23
            // 
            this.label23.ImageIndex = 40;
            this.label23.ImageList = this.imageList1;
            this.label23.Location = new System.Drawing.Point(8, 48);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(16, 16);
            this.label23.TabIndex = 43;
            // 
            // linkLabel12
            // 
            this.linkLabel12.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel12.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel12.Location = new System.Drawing.Point(32, 94);
            this.linkLabel12.Name = "linkLabel12";
            this.linkLabel12.Size = new System.Drawing.Size(192, 16);
            this.linkLabel12.TabIndex = 42;
            this.linkLabel12.TabStop = true;
            this.linkLabel12.Text = "Save Current Document Format";
            // 
            // linkLabel13
            // 
            this.linkLabel13.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel13.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel13.Location = new System.Drawing.Point(32, 72);
            this.linkLabel13.Name = "linkLabel13";
            this.linkLabel13.Size = new System.Drawing.Size(192, 16);
            this.linkLabel13.TabIndex = 41;
            this.linkLabel13.TabStop = true;
            this.linkLabel13.Text = "Modify Current Format";
            // 
            // linkLabel14
            // 
            this.linkLabel14.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel14.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel14.Location = new System.Drawing.Point(32, 48);
            this.linkLabel14.Name = "linkLabel14";
            this.linkLabel14.Size = new System.Drawing.Size(192, 16);
            this.linkLabel14.TabIndex = 40;
            this.linkLabel14.TabStop = true;
            this.linkLabel14.Text = "Create Custom Document Format";
            // 
            // xpToolBar2
            // 
            this.xpToolBar2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.xpToolBar2.Bar.BarName = "";
            this.xpToolBar2.Bar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem11,
            this.parentBarItem7,
            this.barItem12,
            this.barItem13});
            this.xpToolBar2.Bar.Manager = null;
            this.xpToolBar2.Bar.SeparatorIndices.AddRange(new int[] {
            2});
            this.xpToolBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.xpToolBar2.Location = new System.Drawing.Point(0, 0);
            this.xpToolBar2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.xpToolBar2.Name = "xpToolBar2";
            this.xpToolBar2.SeparatorIndices.AddRange(new int[] {
            2});
            this.xpToolBar2.Size = new System.Drawing.Size(242, 25);
            this.xpToolBar2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.xpToolBar2.TabIndex = 2;
            this.xpToolBar2.Text = "xpToolBar2";
            // 
            // barItem11
            // 
            this.barItem11.BarName = "barItem11";
            this.barItem11.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem11.ID = "Item1";
            this.barItem11.ImageIndex = 16;
            this.barItem11.ImageList = this.imageList1;
            this.barItem11.ShowToolTipInPopUp = false;
            this.barItem11.SizeToFit = true;
            this.barItem11.Text = "Item1";
            // 
            // parentBarItem7
            // 
            this.parentBarItem7.BarName = "parentBarItem7";
            this.parentBarItem7.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.parentBarItem7.ID = "DropDown1";
            this.parentBarItem7.ImageIndex = 14;
            this.parentBarItem7.ImageList = this.imageList1;
            this.parentBarItem7.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem10});
            this.parentBarItem7.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem7.ShowToolTipInPopUp = false;
            this.parentBarItem7.SizeToFit = true;
            this.parentBarItem7.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem7.Text = "DropDown1";
            // 
            // barItem10
            // 
            this.barItem10.BarName = "barItem10";
            this.barItem10.ID = "Button Item1";
            this.barItem10.ShowToolTipInPopUp = false;
            this.barItem10.SizeToFit = true;
            this.barItem10.Text = "Button Item1";
            // 
            // barItem12
            // 
            this.barItem12.BarName = "barItem12";
            this.barItem12.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem12.ID = "Item2";
            this.barItem12.ImageIndex = 17;
            this.barItem12.ImageList = this.imageList1;
            this.barItem12.ShowToolTipInPopUp = false;
            this.barItem12.SizeToFit = true;
            this.barItem12.Text = "Item2";
            // 
            // barItem13
            // 
            this.barItem13.BarName = "barItem13";
            this.barItem13.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem13.ID = "Item3";
            this.barItem13.ImageIndex = 18;
            this.barItem13.ImageList = this.imageList1;
            this.barItem13.ShowToolTipInPopUp = false;
            this.barItem13.SizeToFit = true;
            this.barItem13.Text = "Item3";
            // 
            // pnlNewDocument
            // 
            this.pnlNewDocument.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.cardLayout1.SetCardName(this.pnlNewDocument, "NewDocument");
            this.pnlNewDocument.Controls.Add(this.label36);
            this.pnlNewDocument.Controls.Add(this.label37);
            this.pnlNewDocument.Controls.Add(this.label38);
            this.pnlNewDocument.Controls.Add(this.linkLabel20);
            this.pnlNewDocument.Controls.Add(this.label33);
            this.pnlNewDocument.Controls.Add(this.buttonAdv1);
            this.pnlNewDocument.Controls.Add(this.label34);
            this.pnlNewDocument.Controls.Add(this.textBox4);
            this.pnlNewDocument.Controls.Add(this.label35);
            this.pnlNewDocument.Controls.Add(this.label28);
            this.pnlNewDocument.Controls.Add(this.label29);
            this.pnlNewDocument.Controls.Add(this.label30);
            this.pnlNewDocument.Controls.Add(this.label31);
            this.pnlNewDocument.Controls.Add(this.label32);
            this.pnlNewDocument.Controls.Add(this.linkLabel17);
            this.pnlNewDocument.Controls.Add(this.linkLabel18);
            this.pnlNewDocument.Controls.Add(this.linkLabel19);
            this.pnlNewDocument.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlNewDocument.Location = new System.Drawing.Point(0, 0);
            this.cardLayout1.SetMinimumSize(this.pnlNewDocument, new System.Drawing.Size(200, 272));
            this.pnlNewDocument.Name = "pnlNewDocument";
            this.cardLayout1.SetPreferredSize(this.pnlNewDocument, new System.Drawing.Size(200, 272));
            this.pnlNewDocument.Size = new System.Drawing.Size(246, 520);
            this.pnlNewDocument.TabIndex = 32;
            this.pnlNewDocument.Tag = "New Document";
            // 
            // label36
            // 
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label36.Location = new System.Drawing.Point(8, 272);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(144, 16);
            this.label36.TabIndex = 75;
            this.label36.Text = "Recently used templates";
            // 
            // label37
            // 
            this.label37.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label37.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label37.ForeColor = System.Drawing.Color.Transparent;
            this.label37.Location = new System.Drawing.Point(8, 288);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(261, 2);
            this.label37.TabIndex = 74;
            // 
            // label38
            // 
            this.label38.ImageIndex = 22;
            this.label38.ImageList = this.imageList1;
            this.label38.Location = new System.Drawing.Point(8, 304);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(20, 24);
            this.label38.TabIndex = 73;
            // 
            // linkLabel20
            // 
            this.linkLabel20.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel20.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.linkLabel20.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel20.Location = new System.Drawing.Point(32, 312);
            this.linkLabel20.Name = "linkLabel20";
            this.linkLabel20.Size = new System.Drawing.Size(112, 16);
            this.linkLabel20.TabIndex = 72;
            this.linkLabel20.TabStop = true;
            this.linkLabel20.Text = "Letter format";
            // 
            // label33
            // 
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label33.Location = new System.Drawing.Point(8, 160);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(64, 16);
            this.label33.TabIndex = 71;
            this.label33.Text = "Templates";
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv1.Location = new System.Drawing.Point(175, 208);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(31, 23);
            this.buttonAdv1.TabIndex = 21;
            this.buttonAdv1.Text = "Go";
            this.buttonAdv1.UseVisualStyle = true;
            // 
            // label34
            // 
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label34.Location = new System.Drawing.Point(8, 184);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(96, 16);
            this.label34.TabIndex = 70;
            this.label34.Text = "Search online for:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.textBox4.Location = new System.Drawing.Point(8, 208);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(155, 23);
            this.textBox4.TabIndex = 68;
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label35.ForeColor = System.Drawing.Color.Transparent;
            this.label35.Location = new System.Drawing.Point(8, 176);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(261, 2);
            this.label35.TabIndex = 67;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label28.Location = new System.Drawing.Point(8, 16);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(136, 16);
            this.label28.TabIndex = 66;
            this.label28.Text = "New";
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label29.ForeColor = System.Drawing.Color.Transparent;
            this.label29.Location = new System.Drawing.Point(8, 32);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(261, 2);
            this.label29.TabIndex = 65;
            // 
            // label30
            // 
            this.label30.Image = ((System.Drawing.Image)(resources.GetObject("label30.Image")));
            this.label30.Location = new System.Drawing.Point(8, 96);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(20, 16);
            this.label30.TabIndex = 64;
            // 
            // label31
            // 
            this.label31.Image = ((System.Drawing.Image)(resources.GetObject("label31.Image")));
            this.label31.Location = new System.Drawing.Point(8, 72);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(20, 16);
            this.label31.TabIndex = 63;
            // 
            // label32
            // 
            this.label32.Image = ((System.Drawing.Image)(resources.GetObject("label32.Image")));
            this.label32.Location = new System.Drawing.Point(8, 48);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(20, 16);
            this.label32.TabIndex = 62;
            // 
            // linkLabel17
            // 
            this.linkLabel17.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel17.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.linkLabel17.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel17.Location = new System.Drawing.Point(32, 96);
            this.linkLabel17.Name = "linkLabel17";
            this.linkLabel17.Size = new System.Drawing.Size(192, 16);
            this.linkLabel17.TabIndex = 61;
            this.linkLabel17.TabStop = true;
            this.linkLabel17.Text = "From existing document";
            this.linkLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabel18
            // 
            this.linkLabel18.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel18.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.linkLabel18.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel18.Location = new System.Drawing.Point(32, 72);
            this.linkLabel18.Name = "linkLabel18";
            this.linkLabel18.Size = new System.Drawing.Size(192, 16);
            this.linkLabel18.TabIndex = 60;
            this.linkLabel18.TabStop = true;
            this.linkLabel18.Text = "Choose document type";
            this.linkLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabel19
            // 
            this.linkLabel19.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel19.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel19.Location = new System.Drawing.Point(32, 48);
            this.linkLabel19.Name = "linkLabel19";
            this.linkLabel19.Size = new System.Drawing.Size(192, 16);
            this.linkLabel19.TabIndex = 59;
            this.linkLabel19.TabStop = true;
            this.linkLabel19.Text = "Empty document";
            // 
            // pnlSearchOptions
            // 
            this.pnlSearchOptions.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.cardLayout1.SetCardName(this.pnlSearchOptions, "SearchOptions");
            this.pnlSearchOptions.Controls.Add(this.xpTaskBar1);
            this.pnlSearchOptions.Location = new System.Drawing.Point(0, 0);
            this.cardLayout1.SetMinimumSize(this.pnlSearchOptions, new System.Drawing.Size(192, 232));
            this.pnlSearchOptions.Name = "pnlSearchOptions";
            this.cardLayout1.SetPreferredSize(this.pnlSearchOptions, new System.Drawing.Size(192, 232));
            this.pnlSearchOptions.Size = new System.Drawing.Size(246, 520);
            this.pnlSearchOptions.TabIndex = 31;
            this.pnlSearchOptions.Tag = "Search Options";
            // 
            // xpTaskBar1
            // 
            this.xpTaskBar1.AutoPersistStates = false;
            this.xpTaskBar1.AutoScroll = true;
            this.xpTaskBar1.BackColor = System.Drawing.Color.Transparent;
            this.xpTaskBar1.BorderColor = System.Drawing.Color.Black;
            this.xpTaskBar1.Controls.Add(this.xpTaskBarBox1);
            this.xpTaskBar1.Controls.Add(this.xpTaskBarBox2);
            this.xpTaskBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpTaskBar1.HeaderImageList = this.LargeimageList;
            this.xpTaskBar1.Location = new System.Drawing.Point(0, 0);
            this.xpTaskBar1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.xpTaskBar1.MinimumSize = new System.Drawing.Size(0, 0);
            this.xpTaskBar1.Name = "xpTaskBar1";
            this.xpTaskBar1.Padding = new System.Windows.Forms.Padding(10);
            this.xpTaskBar1.Size = new System.Drawing.Size(242, 516);
            this.xpTaskBar1.TabIndex = 10;
            // 
            // xpTaskBarBox1
            // 
            this.xpTaskBarBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xpTaskBarBox1.HeaderBackColor = System.Drawing.Color.LightSteelBlue;
            this.xpTaskBarBox1.HeaderImageIndex = 0;
            this.xpTaskBarBox1.HitTaskBoxArea = false;
            this.xpTaskBarBox1.HotTrackColor = System.Drawing.Color.Empty;
            this.xpTaskBarBox1.ImageList = this.imageList1;
            this.xpTaskBarBox1.ItemBackColor = System.Drawing.Color.AliceBlue;
            this.xpTaskBarBox1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPTaskBarItem[] {
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Sort search results based on order", System.Drawing.SystemColors.ActiveCaption, 22, null, "about items", true, true, "", new System.Drawing.Font("Tahoma", 8.25F), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Sort search results based on date", System.Drawing.Color.Empty, 23, null, "about drawing", true, true, "", new System.Drawing.Font("Tahoma", 8.25F), 0)});
            this.xpTaskBarBox1.Location = new System.Drawing.Point(10, 10);
            this.xpTaskBarBox1.Name = "xpTaskBarBox1";
            this.xpTaskBarBox1.Size = new System.Drawing.Size(222, 89);
            this.xpTaskBarBox1.TabIndex = 0;
            this.xpTaskBarBox1.Text = "Search Options";
            // 
            // xpTaskBarBox2
            // 
            this.xpTaskBarBox2.Controls.Add(this.gradientPanel1);
            this.xpTaskBarBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xpTaskBarBox2.HeaderBackColor = System.Drawing.Color.SlateGray;
            this.xpTaskBarBox2.HeaderForeColor = System.Drawing.Color.White;
            this.xpTaskBarBox2.HeaderImageIndex = 1;
            this.xpTaskBarBox2.HitTaskBoxArea = false;
            this.xpTaskBarBox2.HotTrackColor = System.Drawing.Color.Empty;
            this.xpTaskBarBox2.ItemBackColor = System.Drawing.Color.AliceBlue;
            this.xpTaskBarBox2.Location = new System.Drawing.Point(10, 99);
            this.xpTaskBarBox2.Name = "xpTaskBarBox2";
            this.xpTaskBarBox2.PreferredChildPanelHeight = 120;
            this.xpTaskBarBox2.Size = new System.Drawing.Size(222, 166);
            this.xpTaskBarBox2.TabIndex = 1;
            this.xpTaskBarBox2.Text = "Search";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(252))))), System.Drawing.Color.AliceBlue);
            this.gradientPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.gradientPanel1.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel1.Controls.Add(this.label26);
            this.gradientPanel1.Controls.Add(this.textBox2);
            this.gradientPanel1.Controls.Add(this.label27);
            this.gradientPanel1.Controls.Add(this.comboBoxAdv2);
            this.gradientPanel1.Controls.Add(this.buttonAdv2);
            this.gradientPanel1.Location = new System.Drawing.Point(2, 44);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(218, 120);
            this.gradientPanel1.TabIndex = 0;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(5, 40);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(56, 13);
            this.label26.TabIndex = 2;
            this.label26.Text = "Category:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(64, 8);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 21);
            this.textBox2.TabIndex = 1;
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(6, 8);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(64, 16);
            this.label27.TabIndex = 0;
            this.label27.Text = "Keywords:";
            // 
            // comboBoxAdv2
            // 
            this.comboBoxAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.comboBoxAdv2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv2.Location = new System.Drawing.Point(63, 35);
            this.comboBoxAdv2.Name = "comboBoxAdv2";
            this.comboBoxAdv2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.comboBoxAdv2.TabIndex = 23;
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv2.Location = new System.Drawing.Point(64, 77);
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Size = new System.Drawing.Size(75, 23);
            this.buttonAdv2.TabIndex = 22;
            this.buttonAdv2.Text = "Search";
            this.buttonAdv2.UseVisualStyle = true;
            // 
            // LargeimageList
            // 
            this.LargeimageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("LargeimageList.ImageStream")));
            this.LargeimageList.TransparentColor = System.Drawing.Color.Transparent;
            this.LargeimageList.Images.SetKeyName(0, "");
            this.LargeimageList.Images.SetKeyName(1, "");
            // 
            // popupMenu1
            // 
            this.popupMenu1.ParentBarItem = this.parentBarItem12;
            // 
            // parentBarItem12
            // 
            this.parentBarItem12.BarName = "parentBarItem12";
            this.parentBarItem12.ID = "BarItem";
            this.parentBarItem12.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.biGettingStarted,
            this.biNewDocument,
            this.biSearchOptions,
            this.barItem6,
            this.barItem18,
            this.barItem21});
            this.parentBarItem12.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem12.SeparatorIndices.AddRange(new int[] {
            3});
            this.parentBarItem12.ShowToolTipInPopUp = false;
            this.parentBarItem12.SizeToFit = true;
            this.parentBarItem12.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem12.Popup += new System.EventHandler(this.parentBarItem12_Popup);
            // 
            // biGettingStarted
            // 
            this.biGettingStarted.BarName = "biGettingStarted";
            this.biGettingStarted.ID = "GettingStarted";
            this.biGettingStarted.ImageIndex = 25;
            this.biGettingStarted.ImageList = this.imageList1;
            this.biGettingStarted.ShowToolTipInPopUp = false;
            this.biGettingStarted.SizeToFit = true;
            this.biGettingStarted.Text = "Getting Started";
            this.biGettingStarted.Click += new System.EventHandler(this.biGettingStarted_Click);
            // 
            // biNewDocument
            // 
            this.biNewDocument.BarName = "biNewDocument";
            this.biNewDocument.ID = "New Document";
            this.biNewDocument.ImageIndex = 22;
            this.biNewDocument.ImageList = this.imageList1;
            this.biNewDocument.ShowToolTipInPopUp = false;
            this.biNewDocument.SizeToFit = true;
            this.biNewDocument.Text = "New Document";
            this.biNewDocument.Click += new System.EventHandler(this.biNewDocument_Click);
            // 
            // biSearchOptions
            // 
            this.biSearchOptions.BarName = "biSearchOptions";
            this.biSearchOptions.ID = "Search Options";
            this.biSearchOptions.ImageIndex = 26;
            this.biSearchOptions.ImageList = this.imageList1;
            this.biSearchOptions.ShowToolTipInPopUp = false;
            this.biSearchOptions.SizeToFit = true;
            this.biSearchOptions.Text = "Search Options";
            this.biSearchOptions.Click += new System.EventHandler(this.biSearchOptions_Click);
            // 
            // barItem6
            // 
            this.barItem6.BarName = "barItem6";
            this.barItem6.ID = "New Document";
            this.barItem6.ImageIndex = 2;
            this.barItem6.ImageList = this.imageList1;
            this.barItem6.ShowToolTipInPopUp = false;
            this.barItem6.SizeToFit = true;
            this.barItem6.Text = "Save Document";
            // 
            // barItem18
            // 
            this.barItem18.BarName = "barItem18";
            this.barItem18.ID = "Review";
            this.barItem18.ShowToolTipInPopUp = false;
            this.barItem18.SizeToFit = true;
            this.barItem18.Text = "Review";
            // 
            // barItem21
            // 
            this.barItem21.BarName = "barItem21";
            this.barItem21.ID = "Updates";
            this.barItem21.ShowToolTipInPopUp = false;
            this.barItem21.SizeToFit = true;
            this.barItem21.Text = "Updates";
            // 
            // controlBar2
            // 
            this.controlBar2.CaptionControl = this.comboBoxAdv1;
            this.controlBar2.ChevronColor = System.Drawing.SystemColors.ControlText;
            this.controlBar2.ControlBarCaptionHeight = 25;
            this.controlBar2.Controls.Add(this.listView1);
            this.controlBar2.Controls.Add(this.comboBoxAdv1);
            this.controlBar2.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Right;
            this.controlBar2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlBar2.HideDropDownButton = true;
            this.controlBar2.MaxLength = 200;
            this.controlBar2.MinHeight = 186;
            this.controlBar2.MinLength = 50;
            this.controlBar2.Name = "controlBar2";
            this.controlBar2.RowIndex = 0;
            this.controlBar2.TabIndex = 1;
            this.controlBar2.TabStop = false;
            this.controlBar2.Text = "Document Properties";
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.comboBoxAdv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Node Types",
            "Top-level Caption Nodes",
            "Sub Caption Nodes",
            "Selected Nodes",
            "Underlined Nodes",
            "Highlighted Nodes",
            "Italicized Nodes",
            ""});
            this.comboBoxAdv1.Location = new System.Drawing.Point(2, 27);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(181, 21);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.TabIndex = 29;
            this.comboBoxAdv1.Text = "Overview";
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.listView1.Location = new System.Drawing.Point(2, 46);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(182, 532);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // parentBarItem3
            // 
            this.parentBarItem3.BarName = "parentBarItem3";
            this.parentBarItem3.CategoryIndex = 3;
            this.parentBarItem3.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem3.ID = "Submenu";
            this.parentBarItem3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem3.ShowToolTipInPopUp = false;
            this.parentBarItem3.SizeToFit = true;
            this.parentBarItem3.Text = "Submenu";
            // 
            // comboBoxBarItem1
            // 
            this.comboBoxBarItem1.AutoAppend = true;
            this.comboBoxBarItem1.BarName = "comboBoxBarItem1";
            this.comboBoxBarItem1.CategoryIndex = 1;
            this.comboBoxBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBarItem1.ID = "Editable";
            this.comboBoxBarItem1.MinWidth = 100;
            this.comboBoxBarItem1.ShowToolTipInPopUp = false;
            this.comboBoxBarItem1.SizeToFit = true;
            this.comboBoxBarItem1.Text = "Editable";
            this.comboBoxBarItem1.Tooltip = "Provides Editable and AutoAppend functionality for Find features.";
            // 
            // comboBoxBarItem2
            // 
            this.comboBoxBarItem2.BarName = "comboBoxBarItem2";
            this.comboBoxBarItem2.CategoryIndex = 1;
            this.comboBoxBarItem2.ChoiceList.AddRange(new string[] {
            "Release",
            "Debug"});
            this.comboBoxBarItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBarItem2.Editable = false;
            this.comboBoxBarItem2.ID = "ChoiceList";
            this.comboBoxBarItem2.MinWidth = 70;
            this.comboBoxBarItem2.ShowToolTipInPopUp = false;
            this.comboBoxBarItem2.SizeToFit = true;
            this.comboBoxBarItem2.Text = "ChoiceList";
            // 
            // fontColorBarItem
            // 
            this.fontColorBarItem.BarName = "fontColorBarItem";
            this.fontColorBarItem.CategoryIndex = 1;
            this.fontColorBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontColorBarItem.ID = "Font DropDown";
            this.fontColorBarItem.ImageIndex = 8;
            this.fontColorBarItem.ShowToolTipInPopUp = false;
            this.fontColorBarItem.SizeToFit = true;
            this.fontColorBarItem.Text = "Font DropDown";
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
            // 
            // dropDownBarItem3
            // 
            this.dropDownBarItem3.BarName = "dropDownBarItem3";
            this.dropDownBarItem3.ID = "BarItem";
            this.dropDownBarItem3.ImageIndex = 15;
            this.dropDownBarItem3.ImageList = this.imageList1;
            this.dropDownBarItem3.ShowToolTipInPopUp = false;
            this.dropDownBarItem3.SizeToFit = true;
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
            // 
            // parentBarItem8
            // 
            this.parentBarItem8.BarName = "parentBarItem8";
            this.parentBarItem8.ID = "BarItem";
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
            // 
            // parentBarItem9
            // 
            this.parentBarItem9.BarName = "parentBarItem9";
            this.parentBarItem9.ID = "SubMenu";
            this.parentBarItem9.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem14,
            this.barItem15});
            this.parentBarItem9.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem9.ShowToolTipInPopUp = false;
            this.parentBarItem9.SizeToFit = true;
            this.parentBarItem9.Text = "SubMenu";
            // 
            // barItem14
            // 
            this.barItem14.BarName = "barItem14";
            this.barItem14.ID = "SubItem1";
            this.barItem14.ShowToolTipInPopUp = false;
            this.barItem14.SizeToFit = true;
            this.barItem14.Text = "SubItem1";
            // 
            // barItem15
            // 
            this.barItem15.BarName = "barItem15";
            this.barItem15.ID = "SubItem2";
            this.barItem15.ShowToolTipInPopUp = false;
            this.barItem15.SizeToFit = true;
            this.barItem15.Text = "SubItem2";
            // 
            // comboBoxBarItem3
            // 
            this.comboBoxBarItem3.AutoAppend = true;
            this.comboBoxBarItem3.BarName = "comboBoxBarItem3";
            this.comboBoxBarItem3.ID = "Combo:";
            this.comboBoxBarItem3.MinWidth = 70;
            this.comboBoxBarItem3.ShowToolTipInPopUp = false;
            this.comboBoxBarItem3.SizeToFit = true;
            this.comboBoxBarItem3.Text = "Combo:";
            // 
            // barItem20
            // 
            this.barItem20.BarName = "barItem20";
            this.barItem20.ID = "BarItem";
            this.barItem20.ShowToolTipInPopUp = false;
            this.barItem20.SizeToFit = true;
            // 
            // cardLayout1
            // 
            this.cardLayout1.ContainerControl = this.taskPanel;
            this.cardLayout1.LayoutMode = Syncfusion.Windows.Forms.Tools.CardLayoutMode.Fill;
            this.cardLayout1.SelectedCard = "GettingStarted";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(864, 638);
            this.Controls.Add(this.popupControlContainer1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.IsMdiContainer = true;
            this.MetroColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Bars ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).EndInit();
            this.popupControlContainer1.ResumeLayout(false);
            this.controlBar1.ResumeLayout(false);
            this.taskPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlGettingStarted)).EndInit();
            this.pnlGettingStarted.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlNewDocument)).EndInit();
            this.pnlNewDocument.ResumeLayout(false);
            this.pnlNewDocument.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearchOptions)).EndInit();
            this.pnlSearchOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar1)).EndInit();
            this.xpTaskBar1.ResumeLayout(false);
            this.xpTaskBarBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).EndInit();
            this.controlBar2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardLayout1)).EndInit();
            this.ResumeLayout(false);

   		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
            Application.Run(new Form1());
		}

		protected override void OnSystemColorsChanged(EventArgs e)
		{
			base.OnSystemColorsChanged(e);
		}
		

		// Display the About dialog
		DemoCommon.AboutForm aboutForm = null;
		private void barItem19_Click(object sender, System.EventArgs e)
		{			
			aboutForm = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
			aboutForm.ShowDialog();
		}		

		// Create a new MDI child form
		private void barItem1_Click(object sender, System.EventArgs e)
		{
			ControlBars.TextForm txtform = new TextForm();
			txtform.TopLevel = false;
			txtform.MdiParent = this;
			txtform.Show();
			txtform.Text = String.Concat("Letter ", (++nLetterCount).ToString());
		}

		// Create a new MDI child form
		private void barItem16_Click(object sender, System.EventArgs e)
		{
			ControlBars.TextForm txtform = new TextForm();
			txtform.TopLevel = false;
			txtform.MdiParent = this;
			txtform.Show();
			txtform.Text = String.Concat("Report ", (++this.nReportCount).ToString());
		}

		// Create a new MDI child form
		private void barItem17_Click(object sender, System.EventArgs e)
		{
			ControlBars.TextForm txtform = new TextForm();
			txtform.TopLevel = false;
			txtform.MdiParent = this;
			txtform.Show();
			txtform.Text = String.Concat("Invoice ", (++this.nInvoiceCount).ToString());
		}

		
		// Update the 'View' PopupMenu UI state
		private void parentBarItem5_Popup(object sender, System.EventArgs e)
		{
			this.barItem4.Checked = this.controlBar1.Visible;
			this.barItem5.Checked = this.controlBar2.Visible;
		}

		// Show/hide the TaskPane ControlBar
		private void barItem4_Click(object sender, System.EventArgs e)
		{
			this.controlBar1.Visible = !this.controlBar1.Visible;
		}

		// Show/hide the DocumentProperties ControlBar
		private void barItem5_Click(object sender, System.EventArgs e)
		{
			this.controlBar2.Visible = !this.controlBar2.Visible;
		}

		// ControlBar1 - TaskPane - switching logic implemented using the Card LayoutManager
		private void biTaskNext_Click(object sender, System.EventArgs e)
		{
			this.cardLayout1.Next();
			this.controlBar1.Text = this.cardLayout1.GetComponentFromName(this.cardLayout1.SelectedCard).Tag as String;
			//if(this.cardLayout1.NextCardIndex)
		}

		private void biTaskPrevious_Click(object sender, System.EventArgs e)
		{
			this.cardLayout1.Previous();
			this.controlBar1.Text = this.cardLayout1.GetComponentFromName(this.cardLayout1.SelectedCard).Tag as String;
			//if(this.cardLayout1.PreviousCardIndex)
		}

		private void biTaskHome_Click(object sender, System.EventArgs e)
		{
			this.cardLayout1.First();
			this.controlBar1.Text = this.cardLayout1.GetComponentFromName(this.cardLayout1.SelectedCard).Tag as String;
		}

		// The ControlBar1 PopupMenu - Update the taskpane visibility state
		private void parentBarItem12_Popup(object sender, System.EventArgs e)
		{
			String selectedcard = this.cardLayout1.GetComponentFromName(this.cardLayout1.SelectedCard).Tag as String;
			this.biGettingStarted.Checked = (selectedcard == (this.pnlGettingStarted.Tag as String));
			this.biNewDocument.Checked = (selectedcard == (this.pnlNewDocument.Tag as String));
			this.biSearchOptions.Checked = (selectedcard == (this.pnlSearchOptions.Tag as String));
		}

		// Set the Tasks ControlBar's selected card depending on the ControlBar PopupMenu item selection
		private void biGettingStarted_Click(object sender, System.EventArgs e)
		{
			this.cardLayout1.Show("GettingStarted");
			this.controlBar1.Text = "Getting Started";
		}

		private void biNewDocument_Click(object sender, System.EventArgs e)
		{
			this.cardLayout1.Show("NewDocument");
			this.controlBar1.Text = "New Document";
		}

		private void biSearchOptions_Click(object sender, System.EventArgs e)
		{
			this.cardLayout1.Show("SearchOptions");
			this.controlBar1.Text = "Search Options";
		}

		// Optionally, switch the XPTaskBar layout between the horizontal and vertical modes when the 
		// ControlBar orientation changes
		private void controlBar1_CommandBarStateChanged(object sender, System.EventArgs e)
		{
			if(this.controlBar1.Floating)
				// If floating:
				this.xpTaskBar1.VerticalLayout = true;
			else
			{
				// If Docked:
				if(this.controlBar1.DockState == CommandBarDockState.Top
					|| this.controlBar1.DockState == CommandBarDockState.Bottom)
					// to top or bottom
					this.xpTaskBar1.VerticalLayout = false;
				else
					// to left or right
					this.xpTaskBar1.VerticalLayout = true;
			}
		}

        private void Form1_Load(object sender, System.EventArgs e)
        {
            DrawBackground();
            this.cardLayout1.Show("NewDocument");
        }

        private void barItem7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void DrawBackground()
        {
            foreach (Bar bar in mainFrameBarManager1.Bars)
            {
                bar.DrawBackground += new PaintEventHandler(bar_DrawBackground);
            }
        }

        void bar_DrawBackground(object sender, PaintEventArgs e)
        {
            Rectangle rect = e.ClipRectangle;
            e.Graphics.FillRectangle(new SolidBrush(Color.White), rect);
        }

        private void SetGradientColors()
        {
            MenuColors.SelColor = colorPickerUIAdv1.SelectedColor;
            MenuColors.SelTextColor = Color.White;
            MenuColors.SelBorderColor = colorPickerUIAdv1.SelectedColor;
            MenuColors.MenuBGColor = Color.White;
            MenuColors.MenuLeftStripColor = Color.White;
            MenuColors.DropDownBorderColor = colorPickerUIAdv1.SelectedColor;
            MenuColors.PressedSelColor = colorPickerUIAdv1.SelectedColor;
            MenuColors.CheckedSelColor = colorPickerUIAdv1.SelectedColor;
            MenuColors.FloatingCommandBarCaptionColor = colorPickerUIAdv1.SelectedColor;
        }

        private void colorPickerUIAdv1_Picked_1(object sender, ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            SetGradientColors();
            this.popupControlContainer1.HidePopup(PopupCloseType.Done);
        }

        private void popupMenu2_BeforePopup(object sender, Syncfusion.Windows.Forms.CancelMouseEventArgs e)
        {

        }
	}
}
