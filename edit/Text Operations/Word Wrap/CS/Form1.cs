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
using System.IO;
using System.Drawing.Drawing2D;

using Syncfusion.Windows.Forms.Edit;
using Syncfusion.Windows.Forms.Edit.Enums;
using Syncfusion.Windows.Forms.Edit.Implementation;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using Syncfusion.Licensing;
using Syncfusion.WinForms.Controls;

namespace WordwrapDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : SfForm
	{
        private Syncfusion.Windows.Forms.Edit.EditControl editControl1;
        private IContainer components = null;
        private Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem WordWrap;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem5;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem6;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem7;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem8;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem9;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem10;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem11;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem12;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem13;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem14;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem5;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem15;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem16;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem17;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem18;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem6;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem19;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem20;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem21;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem22;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem7;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem23;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem24;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem25;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem26;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem8;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem27;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem28;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem29;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem30;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem31;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem32;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem33;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem34;

#if NETCORE
        string filePath = Path.GetDirectoryName(Application.ExecutablePath) + @"..\..\..\..\Test Files\VBSource.vb";
#else
        string filePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Test Files\VBSource.vb";
#endif

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.editControl1.LoadFile(filePath);
			this.AutoScaleMode = AutoScaleMode.Font;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(GetIconFile(@"..\\..\\\logo.ico")));
                this.Icon = ico;
            }
            catch { }

			this.editControl1.WordWrap = true;
			this.editControl1.WordWrapMode = WordWrapMode.WordWrapMargin;
			this.editControl1.WordWrapType = WordWrapType.WrapByChar;
			this.editControl1.TextAreaWidth = 350;
			this.editControl1.WordWrapMarginLineStyle = DashStyle.Dash;
			this.editControl1.WordWrapMarginLineColor = Color.Green;
			this.editControl1.WordWrapMarginBrush = new BrushInfo(gradientStyle, foreColor, backColor);
			this.editControl1.WordWrapMarginVisible = true;
            this.barItem7.Checked = true;
            this.barItem8.Checked = true;
            this.barItem10.Checked = true;
            Customization();


            this.Size = new Size(568,408);
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
            this.WordWrap = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem34 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem9 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem10 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem11 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem12 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem13 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem14 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem15 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem16 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem17 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem18 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem19 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem20 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem21 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem22 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem23 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem24 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem25 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem26 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem27 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem28 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem29 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem30 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem31 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem32 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem33 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
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
            this.editControl1.Location = new System.Drawing.Point(10, 42);
            this.editControl1.Name = "editControl1";
            this.editControl1.RenderRightToLeft = false;
            this.editControl1.ScrollPosition = new System.Drawing.Point(0, 0);
            this.editControl1.ScrollVisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;
            this.editControl1.ShowHorizontalSplitters = false;
            this.editControl1.ShowSelectionMargin = false;
            this.editControl1.ShowVerticalSplitters = false;
            this.editControl1.Size = new System.Drawing.Size(674, 372);
            this.editControl1.TabIndex = 0;
            this.editControl1.Text = "";
            this.editControl1.TransferFocusOnTab = true;
            this.editControl1.UseXPStyleBorder = true;
            this.editControl1.VisualColumn = 1;
            this.editControl1.WordWrap = true;
            // 
            // mainFrameBarManager1
            // 
#if !NETCORE
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
#endif
            this.mainFrameBarManager1.Bars.Add(this.bar1);
            this.mainFrameBarManager1.Categories.Add("file");
            this.mainFrameBarManager1.Categories.Add("wrap mode");
            this.mainFrameBarManager1.Categories.Add("wrap type");
            this.mainFrameBarManager1.Categories.Add("line style");
            this.mainFrameBarManager1.Categories.Add("line color");
            this.mainFrameBarManager1.Categories.Add("fore color");
            this.mainFrameBarManager1.Categories.Add("back color");
            this.mainFrameBarManager1.Categories.Add("gradient style");
            this.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.MetroForm";
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.WordWrap,
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem4,
            this.barItem5,
            this.parentBarItem2,
            this.barItem6,
            this.barItem7,
            this.parentBarItem3,
            this.barItem8,
            this.barItem9,
            this.parentBarItem4,
            this.barItem10,
            this.barItem11,
            this.barItem12,
            this.barItem13,
            this.barItem14,
            this.parentBarItem5,
            this.barItem15,
            this.barItem16,
            this.barItem17,
            this.barItem18,
            this.barItem34});
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
            this.WordWrap,
            });
            this.bar1.Manager = this.mainFrameBarManager1;
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.BarName = "parentBarItem1";
            this.parentBarItem1.CategoryIndex = 0;
            this.parentBarItem1.ID = "&File";
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem34,
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem4,
            this.barItem5});
            this.parentBarItem1.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.Text = "&File";

            // 
            // WordWrap
            // 
            this.WordWrap.BarName = "WordWrap";
            this.WordWrap.CategoryIndex = 0;
            this.WordWrap.ID = "&WordWrap";
            this.WordWrap.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem2,
            this.parentBarItem3,
            this.parentBarItem4,
            this.parentBarItem5});
            this.WordWrap.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.WordWrap.ShowToolTipInPopUp = false;
            this.WordWrap.SizeToFit = true;
            this.WordWrap.Text = "&WordWrap Options";
            // 
            // barItem34
            // 
            this.barItem34.BarName = "barItem34";
            this.barItem34.CategoryIndex = 0;
            this.barItem34.ID = "&New";
            this.barItem34.ShowToolTipInPopUp = false;
            this.barItem34.SizeToFit = true;
            this.barItem34.Text = "&New";
            this.barItem34.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.CategoryIndex = 0;
            this.barItem1.ID = "&Open";
            this.barItem1.ShowToolTipInPopUp = false;
            this.barItem1.SizeToFit = true;
            this.barItem1.Text = "&Open";
            this.barItem1.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // barItem2
            // 
            this.barItem2.BarName = "barItem2";
            this.barItem2.CategoryIndex = 0;
            this.barItem2.ID = "&Save";
            this.barItem2.ShowToolTipInPopUp = false;
            this.barItem2.SizeToFit = true;
            this.barItem2.Text = "&Save";
            this.barItem2.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // barItem3
            // 
            this.barItem3.BarName = "barItem3";
            this.barItem3.CategoryIndex = 0;
            this.barItem3.ID = "Save&As";
            this.barItem3.ShowToolTipInPopUp = false;
            this.barItem3.SizeToFit = true;
            this.barItem3.Text = "Save&As";
            this.barItem3.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // barItem4
            // 
            this.barItem4.BarName = "barItem4";
            this.barItem4.CategoryIndex = 0;
            this.barItem4.ID = "&Close";
            this.barItem4.ShowToolTipInPopUp = false;
            this.barItem4.SizeToFit = true;
            this.barItem4.Text = "&Close";
            this.barItem4.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // barItem5
            // 
            this.barItem5.BarName = "barItem5";
            this.barItem5.CategoryIndex = 0;
            this.barItem5.ID = "&Exit";
            this.barItem5.ShowToolTipInPopUp = false;
            this.barItem5.SizeToFit = true;
            this.barItem5.Text = "&Exit";
            this.barItem5.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.BarName = "parentBarItem2";
            this.parentBarItem2.CategoryIndex = 1;
            this.parentBarItem2.ID = "WrapMode";
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem6,
            this.barItem7});
            this.parentBarItem2.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.parentBarItem2.ShowToolTipInPopUp = false;
            this.parentBarItem2.SizeToFit = true;
            this.parentBarItem2.Text = "WrapMode";
            // 
            // barItem6
            // 
            this.barItem6.BarName = "barItem6";
            this.barItem6.CategoryIndex = 1;
            this.barItem6.ID = "Control";
            this.barItem6.ShowToolTipInPopUp = false;
            this.barItem6.SizeToFit = true;
            this.barItem6.Text = "Control";
            this.barItem6.Click += new System.EventHandler(this.WrapModeClick);
            // 
            // barItem7
            // 
            this.barItem7.BarName = "barItem7";
            this.barItem7.CategoryIndex = 1;
            this.barItem7.ID = "TextArea";
            this.barItem7.ShowToolTipInPopUp = false;
            this.barItem7.SizeToFit = true;
            this.barItem7.Text = "TextArea";
            this.barItem7.Click += new System.EventHandler(this.WrapModeClick);
            // 
            // parentBarItem3
            // 
            this.parentBarItem3.BarName = "parentBarItem3";
            this.parentBarItem3.CategoryIndex = 2;
            this.parentBarItem3.ID = "WrapType";
            this.parentBarItem3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem8,
            this.barItem9});
            this.parentBarItem3.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.parentBarItem3.ShowToolTipInPopUp = false;
            this.parentBarItem3.SizeToFit = true;
            this.parentBarItem3.Text = "WrapType";
            // 
            // barItem8
            // 
            this.barItem8.BarName = "barItem8";
            this.barItem8.CategoryIndex = 2;
            this.barItem8.ID = "Character";
            this.barItem8.ShowToolTipInPopUp = false;
            this.barItem8.SizeToFit = true;
            this.barItem8.Text = "Character";
            this.barItem8.Click += new System.EventHandler(this.WrapTypeClick);
            // 
            // barItem9
            // 
            this.barItem9.BarName = "barItem9";
            this.barItem9.CategoryIndex = 2;
            this.barItem9.ID = "Word";
            this.barItem9.ShowToolTipInPopUp = false;
            this.barItem9.SizeToFit = true;
            this.barItem9.Text = "Word";
            this.barItem9.Click += new System.EventHandler(this.WrapTypeClick);
            // 
            // parentBarItem4
            // 
            this.parentBarItem4.BarName = "parentBarItem4";
            this.parentBarItem4.CategoryIndex = 3;
            this.parentBarItem4.ID = "LineStyle";
            this.parentBarItem4.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem10,
            this.barItem11,
            this.barItem12,
            this.barItem13,
            this.barItem14});
            this.parentBarItem4.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.parentBarItem4.ShowToolTipInPopUp = false;
            this.parentBarItem4.SizeToFit = true;
            this.parentBarItem4.Text = "LineStyle";
            // 
            // barItem10
            // 
            this.barItem10.BarName = "barItem10";
            this.barItem10.CategoryIndex = 3;
            this.barItem10.ID = "Dash";
            this.barItem10.ShowToolTipInPopUp = false;
            this.barItem10.SizeToFit = true;
            this.barItem10.Text = "Dash";
            this.barItem10.Click += new System.EventHandler(this.LineStyleClick);
            // 
            // barItem11
            // 
            this.barItem11.BarName = "barItem11";
            this.barItem11.CategoryIndex = 3;
            this.barItem11.ID = "DashDot";
            this.barItem11.ShowToolTipInPopUp = false;
            this.barItem11.SizeToFit = true;
            this.barItem11.Text = "DashDot";
            this.barItem11.Click += new System.EventHandler(this.LineStyleClick);
            // 
            // barItem12
            // 
            this.barItem12.BarName = "barItem12";
            this.barItem12.CategoryIndex = 3;
            this.barItem12.ID = "DashDotDot";
            this.barItem12.ShowToolTipInPopUp = false;
            this.barItem12.SizeToFit = true;
            this.barItem12.Text = "DashDotDot";
            this.barItem12.Click += new System.EventHandler(this.LineStyleClick);
            // 
            // barItem13
            // 
            this.barItem13.BarName = "barItem13";
            this.barItem13.CategoryIndex = 3;
            this.barItem13.ID = "Dot";
            this.barItem13.ShowToolTipInPopUp = false;
            this.barItem13.SizeToFit = true;
            this.barItem13.Text = "Dot";
            this.barItem13.Click += new System.EventHandler(this.LineStyleClick);
            // 
            // barItem14
            // 
            this.barItem14.BarName = "barItem14";
            this.barItem14.CategoryIndex = 3;
            this.barItem14.ID = "Solid";
            this.barItem14.ShowToolTipInPopUp = false;
            this.barItem14.SizeToFit = true;
            this.barItem14.Text = "Solid";
            this.barItem14.Click += new System.EventHandler(this.LineStyleClick);
            // 
            // parentBarItem5
            // 
            this.parentBarItem5.BarName = "parentBarItem5";
            this.parentBarItem5.CategoryIndex = 4;
            this.parentBarItem5.ID = "LineColor";
            this.parentBarItem5.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem15,
            this.barItem16,
            this.barItem17,
            this.barItem18});
            this.parentBarItem5.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.parentBarItem5.ShowToolTipInPopUp = false;
            this.parentBarItem5.SizeToFit = true;
            this.parentBarItem5.Text = "LineColor";
            // 
            // barItem15
            // 
            this.barItem15.BarName = "barItem15";
            this.barItem15.CategoryIndex = 4;
            this.barItem15.ID = "Green";
            this.barItem15.ShowToolTipInPopUp = false;
            this.barItem15.SizeToFit = true;
            this.barItem15.Text = "Green";
            this.barItem15.Click += new System.EventHandler(this.LineColorClick);
            // 
            // barItem16
            // 
            this.barItem16.BarName = "barItem16";
            this.barItem16.CategoryIndex = 4;
            this.barItem16.ID = "Navy";
            this.barItem16.ShowToolTipInPopUp = false;
            this.barItem16.SizeToFit = true;
            this.barItem16.Text = "Navy";
            this.barItem16.Click += new System.EventHandler(this.LineColorClick);
            // 
            // barItem17
            // 
            this.barItem17.BarName = "barItem17";
            this.barItem17.CategoryIndex = 4;
            this.barItem17.ID = "IndianRed";
            this.barItem17.ShowToolTipInPopUp = false;
            this.barItem17.SizeToFit = true;
            this.barItem17.Text = "IndianRed";
            this.barItem17.Click += new System.EventHandler(this.LineColorClick);
            // 
            // barItem18
            // 
            this.barItem18.BarName = "barItem18";
            this.barItem18.CategoryIndex = 4;
            this.barItem18.ID = "Aqua";
            this.barItem18.ShowToolTipInPopUp = false;
            this.barItem18.SizeToFit = true;
            this.barItem18.Text = "Aqua";
            this.barItem18.Click += new System.EventHandler(this.LineColorClick);
            // 
            // parentBarItem6
            // 
            this.parentBarItem6.BarName = "parentBarItem6";
            this.parentBarItem6.CategoryIndex = 5;
            this.parentBarItem6.ID = "ForeColor";
            this.parentBarItem6.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem19,
            this.barItem20,
            this.barItem21,
            this.barItem22});
            this.parentBarItem6.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.parentBarItem6.ShowToolTipInPopUp = false;
            this.parentBarItem6.SizeToFit = true;
            this.parentBarItem6.Text = "ForeColor";
            // 
            // barItem19
            // 
            this.barItem19.BarName = "barItem19";
            this.barItem19.CategoryIndex = 5;
            this.barItem19.ID = "Salmon";
            this.barItem19.ShowToolTipInPopUp = false;
            this.barItem19.SizeToFit = true;
            this.barItem19.Text = "Salmon";
            this.barItem19.Click += new System.EventHandler(this.ForeColorClick);
            // 
            // barItem20
            // 
            this.barItem20.BarName = "barItem20";
            this.barItem20.CategoryIndex = 5;
            this.barItem20.ID = "Orange";
            this.barItem20.ShowToolTipInPopUp = false;
            this.barItem20.SizeToFit = true;
            this.barItem20.Text = "Orange";
            this.barItem20.Click += new System.EventHandler(this.ForeColorClick);
            // 
            // barItem21
            // 
            this.barItem21.BarName = "barItem21";
            this.barItem21.CategoryIndex = 5;
            this.barItem21.ID = "Blue";
            this.barItem21.ShowToolTipInPopUp = false;
            this.barItem21.SizeToFit = true;
            this.barItem21.Text = "Blue";
            this.barItem21.Click += new System.EventHandler(this.ForeColorClick);
            // 
            // barItem22
            // 
            this.barItem22.BarName = "barItem22";
            this.barItem22.CategoryIndex = 5;
            this.barItem22.ID = "Pink";
            this.barItem22.ShowToolTipInPopUp = false;
            this.barItem22.SizeToFit = true;
            this.barItem22.Text = "Pink";
            this.barItem22.Click += new System.EventHandler(this.ForeColorClick);
            // 
            // parentBarItem7
            // 
            this.parentBarItem7.BarName = "parentBarItem7";
            this.parentBarItem7.CategoryIndex = 6;
            this.parentBarItem7.ID = "BackColor";
            this.parentBarItem7.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem23,
            this.barItem24,
            this.barItem25,
            this.barItem26});
            this.parentBarItem7.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.parentBarItem7.ShowToolTipInPopUp = false;
            this.parentBarItem7.SizeToFit = true;
            this.parentBarItem7.Text = "BackColor";
            // 
            // barItem23
            // 
            this.barItem23.BarName = "barItem23";
            this.barItem23.CategoryIndex = 6;
            this.barItem23.ID = "Beige";
            this.barItem23.ShowToolTipInPopUp = false;
            this.barItem23.SizeToFit = true;
            this.barItem23.Text = "Beige";
            this.barItem23.Click += new System.EventHandler(this.BackColorClick);
            // 
            // barItem24
            // 
            this.barItem24.BarName = "barItem24";
            this.barItem24.CategoryIndex = 6;
            this.barItem24.ID = "LightYellow";
            this.barItem24.ShowToolTipInPopUp = false;
            this.barItem24.SizeToFit = true;
            this.barItem24.Text = "LightYellow";
            this.barItem24.Click += new System.EventHandler(this.BackColorClick);
            // 
            // barItem25
            // 
            this.barItem25.BarName = "barItem25";
            this.barItem25.CategoryIndex = 6;
            this.barItem25.ID = "LightSalmon";
            this.barItem25.ShowToolTipInPopUp = false;
            this.barItem25.SizeToFit = true;
            this.barItem25.Text = "LightSalmon";
            this.barItem25.Click += new System.EventHandler(this.BackColorClick);
            // 
            // barItem26
            // 
            this.barItem26.BarName = "barItem26";
            this.barItem26.CategoryIndex = 6;
            this.barItem26.ID = "Silver";
            this.barItem26.ShowToolTipInPopUp = false;
            this.barItem26.SizeToFit = true;
            this.barItem26.Text = "Silver";
            this.barItem26.Click += new System.EventHandler(this.BackColorClick);
            // 
            // parentBarItem8
            // 
            this.parentBarItem8.BarName = "parentBarItem8";
            this.parentBarItem8.CategoryIndex = 7;
            this.parentBarItem8.ID = "GradientStyle";
            this.parentBarItem8.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem27,
            this.barItem28,
            this.barItem29,
            this.barItem30,
            this.barItem31,
            this.barItem32,
            this.barItem33});
            this.parentBarItem8.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.parentBarItem8.ShowToolTipInPopUp = false;
            this.parentBarItem8.SizeToFit = true;
            this.parentBarItem8.Text = "GradientStyle";
            // 
            // barItem27
            // 
            this.barItem27.BarName = "barItem27";
            this.barItem27.CategoryIndex = 7;
            this.barItem27.ID = "BackwardDiagonal";
            this.barItem27.ShowToolTipInPopUp = false;
            this.barItem27.SizeToFit = true;
            this.barItem27.Text = "BackwardDiagonal";
            this.barItem27.Click += new System.EventHandler(this.GradientStyleClick);
            // 
            // barItem28
            // 
            this.barItem28.BarName = "barItem28";
            this.barItem28.CategoryIndex = 7;
            this.barItem28.ID = "ForwardDiagonal";
            this.barItem28.ShowToolTipInPopUp = false;
            this.barItem28.SizeToFit = true;
            this.barItem28.Text = "ForwardDiagonal";
            this.barItem28.Click += new System.EventHandler(this.GradientStyleClick);
            // 
            // barItem29
            // 
            this.barItem29.BarName = "barItem29";
            this.barItem29.CategoryIndex = 7;
            this.barItem29.ID = "Horizontal";
            this.barItem29.ShowToolTipInPopUp = false;
            this.barItem29.SizeToFit = true;
            this.barItem29.Text = "Horizontal";
            this.barItem29.Click += new System.EventHandler(this.GradientStyleClick);
            // 
            // barItem30
            // 
            this.barItem30.BarName = "barItem30";
            this.barItem30.CategoryIndex = 7;
            this.barItem30.ID = "None";
            this.barItem30.ShowToolTipInPopUp = false;
            this.barItem30.SizeToFit = true;
            this.barItem30.Text = "None";
            this.barItem30.Click += new System.EventHandler(this.GradientStyleClick);
            // 
            // barItem31
            // 
            this.barItem31.BarName = "barItem31";
            this.barItem31.CategoryIndex = 7;
            this.barItem31.ID = "PathEllipse";
            this.barItem31.ShowToolTipInPopUp = false;
            this.barItem31.SizeToFit = true;
            this.barItem31.Text = "PathEllipse";
            this.barItem31.Click += new System.EventHandler(this.GradientStyleClick);
            // 
            // barItem32
            // 
            this.barItem32.BarName = "barItem32";
            this.barItem32.CategoryIndex = 7;
            this.barItem32.ID = "PathRectangle";
            this.barItem32.ShowToolTipInPopUp = false;
            this.barItem32.SizeToFit = true;
            this.barItem32.Text = "PathRectangle";
            this.barItem32.Click += new System.EventHandler(this.GradientStyleClick);
            // 
            // barItem33
            // 
            this.barItem33.BarName = "barItem33";
            this.barItem33.CategoryIndex = 7;
            this.barItem33.ID = "Vertical";
            this.barItem33.ShowToolTipInPopUp = false;
            this.barItem33.SizeToFit = true;
            this.barItem33.Text = "Vertical";
            this.barItem33.Click += new System.EventHandler(this.GradientStyleClick);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.ClientSize = new System.Drawing.Size(694, 423);
            this.Controls.Add(this.editControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(706, 460);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Wrap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).EndInit();
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
            this.mainFrameBarManager1.Style = VisualStyle.Office2016White;
            this.editControl1.Style = Syncfusion.Windows.Forms.Edit.EditControlStyle.Office2016White;
            this.editControl1.ShowIndicatorMargin = false;
             this.Padding = new System.Windows.Forms.Padding(0);
        }
        #endregion

        private void MainMenuClick(object sender, System.EventArgs e)
		{
            BarItem mi = sender as BarItem;

			switch (mi.Text)
			{
				case "&New" :
					this.editControl1.NewFile();
					break;
				case "&Open" :
					this.editControl1.LoadFile();
					break;
				case "&Save" :
					this.editControl1.Save();
					break;
				case "Save&As" :
					this.editControl1.SaveAs();
					break;
				case "&Close" :
					this.editControl1.Close();
					this.editControl1.NewFile();
					break;
				case "&Exit" :
					this.Close();
					break;
			}
		}

		private void WrapModeClick(object sender, System.EventArgs e)
		{
            this.barItem6.Checked = false;
            this.barItem7.Checked = false;
            BarItem mi = sender as BarItem;
            mi.Checked = true;
			switch (mi.Text)
			{
				case "Control" :
					this.editControl1.WordWrapMode = WordWrapMode.Control;
					break;
				case "TextArea" :
					this.editControl1.WordWrapMode = WordWrapMode.WordWrapMargin;
					break;
			}
		}

		private void WrapTypeClick(object sender, System.EventArgs e)
		{
            this.barItem8.Checked = false;
            this.barItem9.Checked = false;
            BarItem mi = sender as BarItem;
            mi.Checked = true;
            switch (mi.Text)
			{
				case "Character" :
					this.editControl1.WordWrapType = WordWrapType.WrapByChar;
					break;
				case "Word" :
					this.editControl1.WordWrapType = WordWrapType.WrapByWord;
					break;
			}
		}

		private void LineStyleClick(object sender, System.EventArgs e)
		{
            this.barItem10.Checked = false;
            this.barItem11.Checked = false;
            this.barItem12.Checked = false;
            this.barItem13.Checked = false;
            this.barItem14.Checked = false;
            BarItem mi = sender as BarItem;
            mi.Checked = true;
            switch (mi.Text)
			{
				case "Dash" :
					this.editControl1.WordWrapMarginLineStyle = DashStyle.Dash;
					break;
				case "DashDot" :
					this.editControl1.WordWrapMarginLineStyle = DashStyle.DashDot;
					break;
				case "DashDotDot" :
					this.editControl1.WordWrapMarginLineStyle = DashStyle.DashDotDot;
					break;
				case "Dot" :
					this.editControl1.WordWrapMarginLineStyle = DashStyle.Dot;
					break;
				case "Solid" :
					this.editControl1.WordWrapMarginLineStyle = DashStyle.Solid;
					break;
			}
		}

		private void LineColorClick(object sender, System.EventArgs e)
		{
            this.barItem15.Checked = false;
            this.barItem16.Checked = false;
            this.barItem17.Checked = false;
            this.barItem18.Checked = false;
            BarItem mi = sender as BarItem;
            mi.Checked = true;
            switch (mi.Text)
			{
				case "Green" :
					this.editControl1.WordWrapMarginLineColor = Color.Green;
					break;
				case "Navy" :
					this.editControl1.WordWrapMarginLineColor = Color.Navy;
					break;
				case "IndianRed" :
					this.editControl1.WordWrapMarginLineColor = Color.IndianRed;
					break;
				case "Aqua" :
					this.editControl1.WordWrapMarginLineColor = Color.Aqua;
					break;
			}
		}

		Color foreColor = Color.White;
		private void ForeColorClick(object sender, System.EventArgs e)
		{
            this.barItem19.Checked = false;
            this.barItem20.Checked = false;
            this.barItem21.Checked = false;
            this.barItem22.Checked = false;
            BarItem mi = sender as BarItem;
            mi.Checked = true;
            switch (mi.Text)
			{
				case "Salmon" :
					foreColor = Color.Salmon;
					break;
				case "Orange" :
					foreColor = Color.Orange;
					break;
				case "Blue" :
					foreColor = Color.Blue;
					break;
				case "Pink" :
					foreColor = Color.Pink;
					break;
			}
			this.editControl1.WordWrapMarginBrush = new BrushInfo(gradientStyle, foreColor, backColor);
		}

		Color backColor = Color.LightSalmon;
		private void BackColorClick(object sender, System.EventArgs e)
		{
            this.barItem23.Checked = false;
            this.barItem24.Checked = false;
            this.barItem25.Checked = false;
            this.barItem26.Checked = false;
            BarItem mi = sender as BarItem;
            mi.Checked = true;
            switch (mi.Text)
			{
				case "Beige" :
					backColor = Color.Beige;
					break;
				case "LightYellow" :
					backColor = Color.LightYellow;
					break;
				case "LightSalmon" :
					backColor = Color.LightSalmon;
					break;
				case "Silver" :
					backColor = Color.Silver;
					break;
			}

			this.editControl1.WordWrapMarginBrush = new BrushInfo(gradientStyle, foreColor, backColor);
		}

		GradientStyle gradientStyle = GradientStyle.Horizontal;	
		private void GradientStyleClick(object sender, System.EventArgs e)
		{
            this.barItem27.Checked = false;
            this.barItem28.Checked = false;
            this.barItem29.Checked = false;
            this.barItem30.Checked = false;
            this.barItem31.Checked = false;
            this.barItem32.Checked = false;
            this.barItem33.Checked = false;
            BarItem mi = sender as BarItem;
            mi.Checked = true;
            switch (mi.Text)
			{
				case "BackwardDiagonal" :
					gradientStyle = GradientStyle.BackwardDiagonal;
					break;
				case "ForwardDiagonal" :
					gradientStyle = GradientStyle.ForwardDiagonal;
					break;
				case "Horizontal" :
					gradientStyle = GradientStyle.Horizontal;
					break;
				case "None" :
					gradientStyle = GradientStyle.None;
					break;
				case "PathEllipse" :
					gradientStyle = GradientStyle.PathEllipse;
					break;
				case "PathRectangle" :
					gradientStyle = GradientStyle.PathRectangle;
					break;
				case "Vertical" :
					gradientStyle = GradientStyle.Vertical;
					break;
			}

			this.editControl1.WordWrapMarginBrush = new BrushInfo(gradientStyle, foreColor, backColor);
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
}
