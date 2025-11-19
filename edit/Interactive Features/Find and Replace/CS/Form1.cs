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
using System.Diagnostics;
using System.Runtime.InteropServices;

using Syncfusion.Windows.Forms.Edit;
using Syncfusion.Windows.Forms.Edit.Dialogs;
using Syncfusion.Windows.Forms.Edit.Implementation.Config;
using Syncfusion.Windows.Forms.Edit.Interfaces;
using Syncfusion.Windows.Forms.Edit.Implementation.IO;
using Syncfusion.Windows.Forms.Edit.Implementation.Formatting;
using Syncfusion.Windows.Forms.Edit.Implementation.Parser;
using Syncfusion.IO;

using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Syncfusion.Windows.Forms.Edit.Implementation;
using Syncfusion.Windows.Forms.Edit.Enums;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;
using Syncfusion.WinForms.Controls;

namespace FindReplaceDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : SfForm
    {
        private Syncfusion.Windows.Forms.Edit.EditControl editControl1;
        private IContainer components = null;
		private int i;
        private Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem5;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem6;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem7;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem8;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem9;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem10;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem11;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem12;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem13;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem14;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem15;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem16;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem17;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem5;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem18;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem19;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem20;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem21;
        private Panel panel1;
        private Label label4;
        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private ButtonAdv button1;
        private ComboBox comboBox2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Panel panel2;
        private FindDialogExt findDlgobj = null;
        public Color btnBackColor;
        public Color cmboBackColor;
        public string msgString;
#if NETCORE
        private string filePath = Path.GetDirectoryName(Application.ExecutablePath) + @"..\..\..\..\Test Files\CSharpSource.cs";
#else
        private string filePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Test Files\CSharpSource.cs";
#endif

        public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			this.AutoScaleMode = AutoScaleMode.Font;
			this.editControl1.ShowLineNumbers = true;
			this.editControl1.ShowIndicatorMargin = true;
			this.editControl1.ShowOutliningCollapsers = true;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(GetIconFile(@"..\\..\\\logo.ico")));
                this.Icon = ico;
            }
            catch { }

			this.editControl1.LoadFile(filePath);
            Customization();
			
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            Syncfusion.Windows.Forms.Edit.Implementation.Config.Config config1 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.editControl1 = new Syncfusion.Windows.Forms.Edit.EditControl();
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "Menu");
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem9 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem10 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem11 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem12 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem13 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem14 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem15 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem16 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem17 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem18 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem19 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem20 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem21 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new ButtonAdv();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // editControl1
            // 
            this.editControl1.AutoIndentMode = Syncfusion.Windows.Forms.Edit.Enums.AutoIndentMode.Smart;
            this.editControl1.BackColor = System.Drawing.SystemColors.Window;
            this.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.editControl1.CodeSnipptSize = new System.Drawing.Size(100, 100);
            this.editControl1.Configurator = config1;
            this.editControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editControl1.IndicatorMarginBackColor = System.Drawing.Color.Empty;
            this.editControl1.LineNumbersFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.editControl1.Location = new System.Drawing.Point(0, 0);
            this.editControl1.Name = "editControl1";
            this.editControl1.RenderRightToLeft = false;
            this.editControl1.ScrollPosition = new System.Drawing.Point(0, 0);
            this.editControl1.ScrollVisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;
            this.editControl1.ShowIndicatorMargin = false;
            this.editControl1.ShowLineNumbers = false;
            this.editControl1.ShowOutliningCollapsers = false;
            this.editControl1.Size = new System.Drawing.Size(460, 396);

            this.editControl1.StatusBarSettings.TextPanel.AutoSize = false;
            this.editControl1.TabIndex = 0;
            this.editControl1.Text = "";
            this.editControl1.UseXPStyleBorder = true;
            this.editControl1.VisualColumn = 1;
            // 
            // mainFrameBarManager1
            // 
#if !NETCORE
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
#endif
            this.mainFrameBarManager1.Bars.Add(this.bar1);
            this.mainFrameBarManager1.Categories.Add("file");
            this.mainFrameBarManager1.Categories.Add("launch");
            this.mainFrameBarManager1.Categories.Add("find history");
            this.mainFrameBarManager1.Categories.Add("replace history");
            this.mainFrameBarManager1.Categories.Add("replace");
            this.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.MetroForm";
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem4,
            this.barItem5,
            this.barItem6,
            this.parentBarItem2,
            this.barItem7,
            this.barItem8,
            this.barItem9,
            this.parentBarItem3,
            this.barItem10,
            this.barItem11,
            this.barItem12,
            this.barItem13,
            this.parentBarItem4,
            this.barItem14,
            this.barItem15,
            this.barItem16,
            this.barItem17,
            this.parentBarItem5,
            this.barItem18,
            this.barItem19,
            this.barItem20,
            this.barItem21});
            this.mainFrameBarManager1.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // bar1
            // 
            this.bar1.BarName = "Menu";
            this.bar1.Caption = "Menu";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.parentBarItem2,
            this.parentBarItem3,
            this.parentBarItem4,
            this.parentBarItem5});
            this.bar1.Manager = this.mainFrameBarManager1;
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.BarName = "parentBarItem1";
            this.parentBarItem1.CategoryIndex = 0;
            this.parentBarItem1.ID = "File";
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem4,
            this.barItem5,
            this.barItem6});
            this.parentBarItem1.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem1.Text = "File";
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.CategoryIndex = 0;
            this.barItem1.ID = "New";
            this.barItem1.ShowToolTipInPopUp = false;
            this.barItem1.SizeToFit = true;
            this.barItem1.Text = "New";
            this.barItem1.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // barItem2
            // 
            this.barItem2.BarName = "barItem2";
            this.barItem2.CategoryIndex = 0;
            this.barItem2.ID = "Open";
            this.barItem2.ShowToolTipInPopUp = false;
            this.barItem2.SizeToFit = true;
            this.barItem2.Text = "Open";
            this.barItem2.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // barItem3
            // 
            this.barItem3.BarName = "barItem3";
            this.barItem3.CategoryIndex = 0;
            this.barItem3.ID = "Save";
            this.barItem3.ShowToolTipInPopUp = false;
            this.barItem3.SizeToFit = true;
            this.barItem3.Text = "Save";
            this.barItem3.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // barItem4
            // 
            this.barItem4.BarName = "barItem4";
            this.barItem4.CategoryIndex = 0;
            this.barItem4.ID = "SaveAs";
            this.barItem4.ShowToolTipInPopUp = false;
            this.barItem4.SizeToFit = true;
            this.barItem4.Text = "SaveAs";
            this.barItem4.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // barItem5
            // 
            this.barItem5.BarName = "barItem5";
            this.barItem5.CategoryIndex = 0;
            this.barItem5.ID = "Close";
            this.barItem5.ShowToolTipInPopUp = false;
            this.barItem5.SizeToFit = true;
            this.barItem5.Text = "Close";
            this.barItem5.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // barItem6
            // 
            this.barItem6.BarName = "barItem6";
            this.barItem6.CategoryIndex = 0;
            this.barItem6.ID = "Exit";
            this.barItem6.ShowToolTipInPopUp = false;
            this.barItem6.SizeToFit = true;
            this.barItem6.Text = "Exit";
            this.barItem6.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.BarName = "parentBarItem2";
            this.parentBarItem2.CategoryIndex = 1;
            this.parentBarItem2.ID = "Launch Menu";
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem7,
            this.barItem8,
            this.barItem9});
            this.parentBarItem2.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.parentBarItem2.ShowToolTipInPopUp = false;
            this.parentBarItem2.SizeToFit = true;
            this.parentBarItem2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem2.Text = "Launch Menu";
            // 
            // barItem7
            // 
            this.barItem7.BarName = "barItem7";
            this.barItem7.CategoryIndex = 1;
            this.barItem7.ID = "Find Dialog";
            this.barItem7.ShowToolTipInPopUp = false;
            this.barItem7.SizeToFit = true;
            this.barItem7.Text = "Find Dialog";
            this.barItem7.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // barItem8
            // 
            this.barItem8.BarName = "barItem8";
            this.barItem8.CategoryIndex = 1;
            this.barItem8.ID = "Replace Dialog";
            this.barItem8.ShowToolTipInPopUp = false;
            this.barItem8.SizeToFit = true;
            this.barItem8.Text = "Replace Dialog";
            this.barItem8.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // barItem9
            // 
            this.barItem9.BarName = "barItem9";
            this.barItem9.CategoryIndex = 1;
            this.barItem9.ID = "GoTo Dialog";
            this.barItem9.ShowToolTipInPopUp = false;
            this.barItem9.SizeToFit = true;
            this.barItem9.Text = "GoTo Dialog";
            this.barItem9.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // parentBarItem3
            // 
            this.parentBarItem3.BarName = "parentBarItem3";
            this.parentBarItem3.CategoryIndex = 2;
            this.parentBarItem3.ID = "Find History";
            this.parentBarItem3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem10,
            this.barItem11,
            this.barItem12,
            this.barItem13});
            this.parentBarItem3.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.parentBarItem3.ShowToolTipInPopUp = false;
            this.parentBarItem3.SizeToFit = true;
            this.parentBarItem3.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem3.Text = "Find History";
            // 
            // barItem10
            // 
            this.barItem10.BarName = "barItem10";
            this.barItem10.CategoryIndex = 2;
            this.barItem10.ID = "Add To History";
            this.barItem10.ShowToolTipInPopUp = false;
            this.barItem10.SizeToFit = true;
            this.barItem10.Text = "Add To History";
            this.barItem10.Click += new System.EventHandler(this.FindHistoryMenu_Click);
            // 
            // barItem11
            // 
            this.barItem11.BarName = "barItem11";
            this.barItem11.CategoryIndex = 2;
            this.barItem11.ID = "Remove From History";
            this.barItem11.ShowToolTipInPopUp = false;
            this.barItem11.SizeToFit = true;
            this.barItem11.Text = "Remove From History";
            this.barItem11.Click += new System.EventHandler(this.FindHistoryMenu_Click);
            // 
            // barItem12
            // 
            this.barItem12.BarName = "barItem12";
            this.barItem12.CategoryIndex = 2;
            this.barItem12.ID = "Sort History";
            this.barItem12.ShowToolTipInPopUp = false;
            this.barItem12.SizeToFit = true;
            this.barItem12.Text = "Sort History";
            this.barItem12.Click += new System.EventHandler(this.FindHistoryMenu_Click);
            // 
            // barItem13
            // 
            this.barItem13.BarName = "barItem13";
            this.barItem13.CategoryIndex = 2;
            this.barItem13.ID = "Clear History";
            this.barItem13.ShowToolTipInPopUp = false;
            this.barItem13.SizeToFit = true;
            this.barItem13.Text = "Clear History";
            this.barItem13.Click += new System.EventHandler(this.FindHistoryMenu_Click);
            // 
            // parentBarItem4
            // 
            this.parentBarItem4.BarName = "parentBarItem4";
            this.parentBarItem4.CategoryIndex = 3;
            this.parentBarItem4.ID = "Replace History";
            this.parentBarItem4.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem14,
            this.barItem15,
            this.barItem16,
            this.barItem17});
            this.parentBarItem4.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.parentBarItem4.ShowToolTipInPopUp = false;
            this.parentBarItem4.SizeToFit = true;
            this.parentBarItem4.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem4.Text = "Replace History";
            // 
            // barItem14
            // 
            this.barItem14.BarName = "barItem14";
            this.barItem14.CategoryIndex = 3;
            this.barItem14.ID = "Add To History_1";
            this.barItem14.ShowToolTipInPopUp = false;
            this.barItem14.SizeToFit = true;
            this.barItem14.Text = "Add To History";
            this.barItem14.Click += new System.EventHandler(this.ReplaceHistory_Click);
            // 
            // barItem15
            // 
            this.barItem15.BarName = "barItem15";
            this.barItem15.CategoryIndex = 3;
            this.barItem15.ID = "Remove From History_1";
            this.barItem15.ShowToolTipInPopUp = false;
            this.barItem15.SizeToFit = true;
            this.barItem15.Text = "Remove From History";
            this.barItem15.Click += new System.EventHandler(this.ReplaceHistory_Click);
            // 
            // barItem16
            // 
            this.barItem16.BarName = "barItem16";
            this.barItem16.CategoryIndex = 3;
            this.barItem16.ID = "Sort History_1";
            this.barItem16.ShowToolTipInPopUp = false;
            this.barItem16.SizeToFit = true;
            this.barItem16.Text = "Sort History";
            this.barItem16.Click += new System.EventHandler(this.ReplaceHistory_Click);
            // 
            // barItem17
            // 
            this.barItem17.BarName = "barItem17";
            this.barItem17.CategoryIndex = 3;
            this.barItem17.ID = "Clear History_1";
            this.barItem17.ShowToolTipInPopUp = false;
            this.barItem17.SizeToFit = true;
            this.barItem17.Text = "Clear History";
            this.barItem17.Click += new System.EventHandler(this.ReplaceHistory_Click);
            // 
            // parentBarItem5
            // 
            this.parentBarItem5.BarName = "parentBarItem5";
            this.parentBarItem5.CategoryIndex = 4;
            this.parentBarItem5.ID = "Replace Search History";
            this.parentBarItem5.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem18,
            this.barItem19,
            this.barItem20,
            this.barItem21});
            this.parentBarItem5.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.parentBarItem5.ShowToolTipInPopUp = false;
            this.parentBarItem5.SizeToFit = true;
            this.parentBarItem5.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem5.Text = "Replace Search History";
            // 
            // barItem18
            // 
            this.barItem18.BarName = "barItem18";
            this.barItem18.CategoryIndex = 4;
            this.barItem18.ID = "Add To History_2";
            this.barItem18.ShowToolTipInPopUp = false;
            this.barItem18.SizeToFit = true;
            this.barItem18.Text = "Add To History";
            // 
            // barItem19
            // 
            this.barItem19.BarName = "barItem19";
            this.barItem19.CategoryIndex = 4;
            this.barItem19.ID = "Remove From History_2";
            this.barItem19.ShowToolTipInPopUp = false;
            this.barItem19.SizeToFit = true;
            this.barItem19.Text = "Remove From History";
            // 
            // barItem20
            // 
            this.barItem20.BarName = "barItem20";
            this.barItem20.CategoryIndex = 4;
            this.barItem20.ID = "Sort History_2";
            this.barItem20.ShowToolTipInPopUp = false;
            this.barItem20.SizeToFit = true;
            this.barItem20.Text = "Sort History";
            // 
            // barItem21
            // 
            this.barItem21.BarName = "barItem21";
            this.barItem21.CategoryIndex = 4;
            this.barItem21.ID = "Clear History_2";
            this.barItem21.ShowToolTipInPopUp = false;
            this.barItem21.SizeToFit = true;
            this.barItem21.Text = "Clear History";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(10, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 396);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Set Properties of Find Dialog";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 44);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(171, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Use Customized Find Dialog";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(10, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseVisualStyle = true;
            this.button1.Appearance = ButtonAppearance.Office2016White;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "Grey",
            "Green"});
            this.comboBox2.Text = "Gray";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Gray",
            "DarkGray"});
            this.comboBox2.Location = new System.Drawing.Point(19, 152);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(130, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CheckBox Back Color";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Gray",
            "LightGray",
            "Dark Gray"});
            this.comboBox1.Location = new System.Drawing.Point(19, 100);
            this.comboBox1.Text = "Gray";
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buttons Back Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type Custom Message";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Type Custom message..";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.editControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(197, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 396);
            this.panel2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.ClientSize = new System.Drawing.Size(667, 445);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MinimumSize = new System.Drawing.Size(679, 482);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find and Replace";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.EnableVisualStyles();
			Application.Run(new Form1());
		}

        #region Customization
        public void Customization()
        {
            btnBackColor = Color.Gray;
            this.checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
            this.mainFrameBarManager1.Style = VisualStyle.Office2016White;
            this.editControl1.Style = Syncfusion.Windows.Forms.Edit.EditControlStyle.Office2016White;
            this.Padding = new System.Windows.Forms.Padding(0);
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (findDlgobj != null)
                    findDlgobj.Dispose();

                findDlgobj = new FindDialogExt(this.editControl1);
                this.editControl1.FindControl = findDlgobj;
                findDlgobj.CustomizeFindDialog(this);
            }
            else
            {
                if (findDlgobj != null)
                    findDlgobj.Dispose();

                this.editControl1.FindControl = new Syncfusion.Windows.Forms.Edit.Dialogs.FrmFindDialog(this.editControl1);

            }
        }
        #endregion

        private void menuItem2_Click(object sender, System.EventArgs e)
		{
			this.FindDialogOpen();
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			this.ReplaceDialogOpen();
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			this.GoToDialogOpen();
		}

		private void codeEdit1_RegisteringKeyCommands(object sender, System.EventArgs e)
		{
			this.editControl1.Commands.Add("FindDialog.Open").ProcessCommand += new ProcessCommandEventHandler(FindDialogOpen);
			this.editControl1.Commands.Add("ReplaceDialog.Open").ProcessCommand += new ProcessCommandEventHandler(ReplaceDialogOpen);
			this.editControl1.Commands.Add("GoToDialog.Open").ProcessCommand += new ProcessCommandEventHandler(GoToDialogOpen);			
		}	
	
		private void FindDialogOpen()
		{
			this.editControl1.ShowFindDialog();			
		}

		private void ReplaceDialogOpen()
		{
			this.editControl1.ShowReplaceDialog();			
		}

		private void GoToDialogOpen()
		{
			this.editControl1.ShowGoToDialog();			
		}

		private void codeEdit1_RegisteringDefaultKeyBindings(object sender, System.EventArgs e)
		{
			this.editControl1.KeyBinder.BindToCommand (Keys.Control | Keys.F, "FindDialog.Open");
			this.editControl1.KeyBinder.BindToCommand (Keys.Control | Keys.R, "ReplaceDialog.Open");
			this.editControl1.KeyBinder.BindToCommand (Keys.Control | Keys.G, "GoToDialog.Open");
		}

		private void MainMenuClick(object sender, System.EventArgs e)
		{
            BarItem mi = sender as BarItem;

			switch (mi.Text)
			{
				case "New" :
					this.editControl1.NewFile();
					break;
				case "Open" :
					this.editControl1.LoadFile();
					break;
				case "Save" :
					this.editControl1.Save();
					break;
				case "SaveAs" :
					this.editControl1.SaveAs();
					break;
				case "Close" :
					this.editControl1.Close();
					break;
				case "Exit" :
					this.Close();
					break;
			}
		}


		private void FindHistoryMenu_Click(object sender, System.EventArgs e)
		{
            BarItem mi = sender as BarItem;
			switch (mi.Text)
			{
				case "Add To History":
					AddToHistoryDlg ATH=new AddToHistoryDlg();
					if(DialogResult.OK==ATH.ShowDialog())
					{
						this.editControl1.FindHistory.Insert(0,(object)ATH.addedItem);
					}
					break;
				case "Remove From History":
					i=1;
					RemoveHistoryItem r=new RemoveHistoryItem(this.SearchItemList);
					if(DialogResult.OK==r.ShowDialog())
					{
						if(r.RemoveListItems!=null)
						{
							foreach(Object o in r.RemoveListItems)
							{
								this.editControl1.FindHistory.Remove(o);
							}
						}
					}
					break;
				case "Sort History":
					this.editControl1.FindHistory.Sort();
					break;
				case "Clear History":
					this.editControl1.FindHistory.Clear();
					break;
				}

		
		} 

		private void ReplaceHistory_Click  (object sender, System.EventArgs e)
		{
            BarItem mi = sender as BarItem;
			switch (mi.Text)
			{
				case "Add To History":
					AddToHistoryDlg ATH=new AddToHistoryDlg();
					if(DialogResult.OK==ATH.ShowDialog())
					{
						this.editControl1.ReplaceHistory.Insert(0,(object)ATH.addedItem);
					}
					break;
				case "Remove From History":
					i=2;
					RemoveHistoryItem r=new RemoveHistoryItem(this.SearchItemList);
					if(DialogResult.OK==r.ShowDialog())
					{
						if(r.RemoveListItems!=null)
						{
							foreach(Object o in r.RemoveListItems)
							{
								this.editControl1.ReplaceHistory.Remove(o);
							}
						}
					}
					break;
				case "Sort History":
					this.editControl1.ReplaceHistory.Sort();
					break;
				case "Clear History":
					this.editControl1.ReplaceHistory.Clear();
					break;
			}
		
		}

		private void ReplaceSearchHistory_Click(object sender, System.EventArgs e)
		{
			BarItem mi = sender as BarItem;
			switch (mi.Text)
			{
				case "Add To History":
					AddToHistoryDlg ATH = new AddToHistoryDlg();
					if(DialogResult.OK == ATH.ShowDialog())
					{
						this.editControl1.ReplaceSearchHistory.Insert(0,(object)ATH.addedItem);
					}
					break;
				case "Remove From History":
					i=3;
					RemoveHistoryItem r = new RemoveHistoryItem(this.SearchItemList);
					if(DialogResult.OK == r.ShowDialog())
					{
						if(r.RemoveListItems!=null)
						{
							foreach(Object o in r.RemoveListItems)
							{
								this.editControl1.ReplaceSearchHistory.Remove(o);
							}
						}
					}
					break;
				case "Sort History":
					this.editControl1.ReplaceSearchHistory.Sort();
					break;
				case "Clear History":
					this.editControl1.ReplaceSearchHistory.Clear();
					
					break;
					
			}
		
		}

		//Properties
		public System.Collections.ArrayList SearchItemList
		{
			
			get
			{
				if(i==1)
				return this.editControl1.FindHistory;
				else if(i==2)
				return this.editControl1.ReplaceHistory;
				else if(i==3)
                return this.editControl1.ReplaceSearchHistory;
				else
					return null;
			}
		}

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Gray")
                btnBackColor = Color.Red;
            else if (comboBox1.Text == "Dark Gray")
                btnBackColor = Color.DarkGray;
            else
                btnBackColor = Color.LightGray;

            if (comboBox2.Text == "Gray")
                cmboBackColor = Color.Gray;
            else
                cmboBackColor = Color.DarkGray;

            if (textBox1.Text != "" && textBox1.Text != "Type Custom message..")
            {
                msgString = textBox1.Text;
            }
            else
            {
                msgString = String.Empty;
            }

            if (checkBox1.Checked)
            {
                if (findDlgobj != null)
                    findDlgobj.Dispose();

                findDlgobj = new FindDialogExt(this.editControl1);
                this.editControl1.FindControl = findDlgobj;
                findDlgobj.CustomizeFindDialog(this);
            }
            else
            {
                if (findDlgobj != null)
                    findDlgobj.Dispose();

                this.editControl1.FindControl = new Syncfusion.Windows.Forms.Edit.Dialogs.FrmFindDialog(this.editControl1);

            }

        }
	}
    public class FindDialogExt : Syncfusion.Windows.Forms.Edit.Dialogs.FrmFindDialog
    {
        private string messageString = String.Empty;

        public FindDialogExt(Syncfusion.Windows.Forms.Edit.EditControl editControl)
            : base(editControl)
        {
            // Handle the FindComplete event.
            this.FindComplete += new EventHandler<FindCompleteEventArgs>(FindDialogExt_FindComplete);

            this.btnClose.FlatStyle = FlatStyle.Standard;
            this.btnFind.FlatStyle = FlatStyle.Standard;
            this.btnMarkAll.FlatStyle = FlatStyle.Standard;
            this.BackColor = editControl.Parent.BackColor;

        }

        //Set the value for message box when search reaches the starting point of search
        void FindDialogExt_FindComplete(object sender, FrmFindDialog.FindCompleteEventArgs e)
        {
            //Arabic text as message
            if (messageString != string.Empty)
                e.Message = messageString;// "انتهى";
            else
                e.Message = "Find reached the starting point of the search.";
        }

        public void CustomizeFindDialog(Form1 mainFrm)
        {
            this.btnMarkAll.BackColor = this.btnFind.BackColor = this.btnClose.BackColor = mainFrm.btnBackColor;

            this.btnMarkAll.ForeColor = this.btnFind.ForeColor = this.btnClose.ForeColor = Color.Brown;

            if (mainFrm.cmboBackColor == Color.Gray)
            {
                this.chkCase.BackColor = Color.Gray;
                this.chkWholeWord.BackColor = Color.Brown;
                this.chkHidden.BackColor = Color.Gray;
                this.chkUp.BackColor = Color.Brown;
                this.chkRegular.BackColor = Color.Gray;

            }
            else
            {
                this.chkCase.BackColor = Color.DarkGray;
                this.chkWholeWord.BackColor = Color.Brown;
                this.chkHidden.BackColor = Color.DarkGray;
                this.chkUp.BackColor = Color.Brown;
                this.chkRegular.BackColor = Color.DarkGray;
            }
            this.chkWholeWord.ForeColor = Color.WhiteSmoke;
            this.chkUp.ForeColor = Color.WhiteSmoke;

            messageString = mainFrm.msgString;


        }

    }
	
	/// <summary>
    /// Represents a class that is used to find the licensing file for Syncfusion controls.
    /// </summary>
    public class DemoCommon
    {
        /// <summary>
        /// Finds the license key from the Common folder.
        /// </summary>
        /// <returns>Returns the license key.</returns>
        public static string FindLicenseKey()
        {
            string licenseKeyFile = "..\\Common\\SyncfusionLicense.txt";
            for (int n = 0; n < 20; n++)
            {
                if (!System.IO.File.Exists(licenseKeyFile))
                {
                    licenseKeyFile = @"..\" + licenseKeyFile;
                    continue;
                }
                return File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }

}