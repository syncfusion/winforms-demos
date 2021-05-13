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
using System.Text;
using System.Xml;
using System.Xml.Serialization;

using Syncfusion.Windows.Forms.Edit;
using Syncfusion.Windows.Forms.Edit.Dialogs;
using Syncfusion.Windows.Forms.Edit.Implementation.Config;
using Syncfusion.Windows.Forms.Edit.Interfaces;
using Syncfusion.Windows.Forms.Edit.Implementation.IO;
using Syncfusion.Windows.Forms.Edit.Implementation.Formatting;
using Syncfusion.Windows.Forms.Edit.Implementation.Parser;
using Syncfusion.IO;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using Syncfusion.Windows.Forms.Edit.Enums;
using Syncfusion.Windows.Forms.Edit.Utils;
using Syncfusion.Windows.Forms.Edit.Implementation;
using Syncfusion.Licensing;
using Syncfusion.WinForms.Controls;

namespace ActionGroupingDemo
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
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem10;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem11;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem12;
        private BarItem barItem13;
        private BarItem barItem14;
        private ParentBarItem parentBarItem3;
        private ParentBarItem parentBarItem4;
        private BarItem barItem16;
        private BarItem barItem17;
        private BarItem barItem18;
        private BarItem barItem19;
        private BarItem barItem20;
        private BarItem barItem21;
        private ParentBarItem parentBarItem5;
        private BarItem barItem15;
        private BarItem barItem22;
        private BarItem barItem23;
        private ParentBarItem parentBarItem6;
        private BarItem barItem24;
        private BarItem barItem25;
        private BarItem barItem26;
        private BarItem barItem27;
        private ParentBarItem parentBarItem7;
        private BarItem barItem28;
        private BarItem barItem29;
        private ParentBarItem parentBarItem8;
        private BarItem barItem30;
        private BarItem barItem31;
        private BarItem barItem32;
        private Syncfusion.Windows.Forms.Edit.Utils.ColumnGuideItem[] columnGuideItem;
        private ParentBarItem parentBarItem9;
        private BarItem barItem33;
        private BarItem barItem34;
        private BarItem barItem35;
        private BarItem barItem36;
        private BarItem barItem37;
        private BarItem barItem38;
        private BarItem barItem39;
        private BarItem barItem40;
        private BarItem barItem41;
        private BarItem barItem42;
        private BarItem barItem43;
        private BarItem barItem44;
        private BarItem barItem45;
        private Cursor currentCursor = Cursors.Default;
#if NETCORE
        private string filePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\..\Test Files\CSharpSource.cs";
#else
        private string filePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Test Files\CSharpSource.cs";
#endif


        public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            try
            {
#if NETCORE
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(GetIconFile(@"..\\..\\..\\\logo.ico")));
#else
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(GetIconFile(@"..\\..\\\logo.ico")));
#endif
                this.Icon = ico;
            }
            catch { }
            this.AutoScaleMode = AutoScaleMode.Font;
			this.editControl1.ShowOutliningCollapsers = true;
			this.editControl1.ShowIndicatorMargin = true;            
			this.Size = new Size(550,500);
            this.editControl1.Cursor = this.currentCursor;
            this.editControl1.MouseMove += new MouseEventHandler(editControl1_MouseMove);
            this.editControl1.LoadFile(filePath); this.editControl1.MenuFill += new EventHandler(cm_FillMenu);
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
            this.barItem10 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem11 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem12 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.parentBarItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem16 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem17 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem18 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem19 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem20 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem21 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem15 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem22 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem23 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem24 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem25 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem26 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem27 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem28 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem29 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem30 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem31 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem32 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem9 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem33 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem34 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem35 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem36 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem37 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem38 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem39 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem40 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem41 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem42 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem43 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem44 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem45 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem13 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem14 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
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
            this.editControl1.Location = new System.Drawing.Point(10, 39);
            this.editControl1.Name = "editControl1";
            this.editControl1.RenderRightToLeft = false;
            this.editControl1.ScrollPosition = new System.Drawing.Point(0, 0);
            this.editControl1.ScrollVisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;
            this.editControl1.ShowHorizontalSplitters = false;
            this.editControl1.ShowSelectionMargin = false;
            this.editControl1.ShowVerticalSplitters = false;
            this.editControl1.Size = new System.Drawing.Size(590, 396);

            this.editControl1.StatusBarSettings.TextPanel.AutoSize = false;
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
            this.mainFrameBarManager1.Categories.Add("File");
            this.mainFrameBarManager1.Categories.Add("Action");
            this.mainFrameBarManager1.Categories.Add("Border");
            this.mainFrameBarManager1.Categories.Add("SetText");
            this.mainFrameBarManager1.Categories.Add("Removetext");
            this.mainFrameBarManager1.Categories.Add("columnguide");
            this.mainFrameBarManager1.Categories.Add("cursor");
            this.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.MetroForm";
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem9,
            this.parentBarItem3,
            this.barItem33,
            this.parentBarItem1,
            this.barItem34,
            this.barItem16,
            this.barItem35,
            this.barItem1,
            this.barItem36,
            this.barItem17,
            this.barItem37,
            this.barItem2,
            this.barItem38,
            this.barItem18,
            this.barItem39,
            this.barItem3,
            this.barItem40,
            this.barItem19,
            this.barItem41,
            this.barItem4,
            this.barItem42,
            this.barItem20,
            this.barItem43,
            this.barItem5,
            this.barItem44,
            this.barItem21,
            this.barItem45,
            this.barItem6,
            this.parentBarItem4,
            this.parentBarItem2,
            this.barItem7,
            this.barItem8,
            this.barItem9,
            this.barItem10,
            this.barItem11,
            this.barItem12,
            this.barItem13,
            this.barItem14,
            this.parentBarItem5,
            this.barItem15,
            this.barItem22,
            this.barItem23,
            this.parentBarItem6,
            this.barItem24,
            this.barItem25,
            this.barItem26,
            this.barItem27,
            this.parentBarItem7,
            this.parentBarItem8,
            this.barItem28,
            this.barItem29,
            this.barItem30,
            this.barItem31,
           });
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
            this.parentBarItem7,
            this.parentBarItem8,
            this.parentBarItem9});
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
            this.parentBarItem2.ID = "ActionMenu";
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem7,
            this.barItem8,
            this.barItem9,
            this.barItem10,
            this.barItem11,
            this.barItem12});
            this.parentBarItem2.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.parentBarItem2.ShowToolTipInPopUp = false;
            this.parentBarItem2.SizeToFit = true;
            this.parentBarItem2.Text = "ActionMenu";
            this.parentBarItem2.Click += new System.EventHandler(this.menuItem9_Select);
            // 
            // barItem7
            // 
            this.barItem7.BarName = "barItem7";
            this.barItem7.CategoryIndex = 1;
            this.barItem7.ID = "Open Group";
            this.barItem7.ShowToolTipInPopUp = false;
            this.barItem7.SizeToFit = true;
            this.barItem7.Text = "Open Group";
            this.barItem7.Click += new System.EventHandler(this.ActionMenuClick);
            // 
            // barItem8
            // 
            this.barItem8.BarName = "barItem8";
            this.barItem8.CategoryIndex = 1;
            this.barItem8.Enabled = false;
            this.barItem8.ID = "Close Group";
            this.barItem8.ShowToolTipInPopUp = false;
            this.barItem8.SizeToFit = true;
            this.barItem8.Text = "Close Group";
            this.barItem8.Click += new System.EventHandler(this.ActionMenuClick);
            // 
            // barItem9
            // 
            this.barItem9.BarName = "barItem9";
            this.barItem9.CategoryIndex = 1;
            this.barItem9.ID = "Cancel Group";
            this.barItem9.ShowToolTipInPopUp = false;
            this.barItem9.SizeToFit = true;
            this.barItem9.Text = "Cancel Group";
            this.barItem9.Click += new System.EventHandler(this.ActionMenuClick);
            // 
            // barItem10
            // 
            this.barItem10.BarName = "barItem10";
            this.barItem10.CategoryIndex = 1;
            this.barItem10.ID = "Undo";
            this.barItem10.ShowToolTipInPopUp = false;
            this.barItem10.SizeToFit = true;
            this.barItem10.Text = "Undo";
            this.barItem10.Click += new System.EventHandler(this.ActionMenuClick);
            // 
            // barItem11
            // 
            this.barItem11.BarName = "barItem11";
            this.barItem11.CategoryIndex = 1;
            this.barItem11.ID = "Redo";
            this.barItem11.ShowToolTipInPopUp = false;
            this.barItem11.SizeToFit = true;
            this.barItem11.Text = "Redo";
            this.barItem11.Click += new System.EventHandler(this.ActionMenuClick);
            // 
            // barItem12
            // 
            this.barItem12.BarName = "barItem12";
            this.barItem12.CategoryIndex = 1;
            this.barItem12.ID = "Introduce Save Point";
            this.barItem12.ShowToolTipInPopUp = false;
            this.barItem12.SizeToFit = true;
            this.barItem12.Text = "Introduce Save Point";
            this.barItem12.Click += new System.EventHandler(this.ActionMenuClick);
            // 
            // parentBarItem3
            // 
            this.parentBarItem3.BarName = "parentBarItem3";
            this.parentBarItem3.CategoryIndex = 2;
            this.parentBarItem3.ID = "Borders";
            this.parentBarItem3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem4,
            this.parentBarItem5,
            this.parentBarItem6});
            this.parentBarItem3.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.parentBarItem3.ShowToolTipInPopUp = false;
            this.parentBarItem3.SizeToFit = true;
            this.parentBarItem3.Text = "Borders";
            // 
            // parentBarItem4
            // 
            this.parentBarItem4.BarName = "parentBarItem4";
            this.parentBarItem4.CategoryIndex = 2;
            this.parentBarItem4.ID = "BorderStyle";
            this.parentBarItem4.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem16,
            this.barItem17,
            this.barItem18,
            this.barItem19,
            this.barItem20,
            this.barItem21});
            this.parentBarItem4.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.parentBarItem4.ShowToolTipInPopUp = false;
            this.parentBarItem4.SizeToFit = true;
            this.parentBarItem4.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem4.Text = "BorderStyle";
            // 
            // barItem16
            // 
            this.barItem16.BarName = "barItem16";
            this.barItem16.CategoryIndex = 2;
            this.barItem16.ID = "Dash";
            this.barItem16.ShowToolTipInPopUp = false;
            this.barItem16.SizeToFit = true;
            this.barItem16.Text = "Dash";
            this.barItem16.Click += new System.EventHandler(this.BorderStyle_Click);
            // 
            // barItem17
            // 
            this.barItem17.BarName = "barItem17";
            this.barItem17.CategoryIndex = 2;
            this.barItem17.ID = "Dot";
            this.barItem17.ShowToolTipInPopUp = false;
            this.barItem17.SizeToFit = true;
            this.barItem17.Text = "Dot";
            this.barItem17.Click += new System.EventHandler(this.BorderStyle_Click);
            // 
            // barItem18
            // 
            this.barItem18.BarName = "barItem18";
            this.barItem18.CategoryIndex = 2;
            this.barItem18.ID = "DotDash";
            this.barItem18.ShowToolTipInPopUp = false;
            this.barItem18.SizeToFit = true;
            this.barItem18.Text = "DotDash";
            this.barItem18.Click += new System.EventHandler(this.BorderStyle_Click);
            // 
            // barItem19
            // 
            this.barItem19.BarName = "barItem19";
            this.barItem19.CategoryIndex = 2;
            this.barItem19.ID = "Solid";
            this.barItem19.ShowToolTipInPopUp = false;
            this.barItem19.SizeToFit = true;
            this.barItem19.Text = "Solid";
            this.barItem19.Click += new System.EventHandler(this.BorderStyle_Click);
            // 
            // barItem20
            // 
            this.barItem20.BarName = "barItem20";
            this.barItem20.CategoryIndex = 2;
            this.barItem20.ID = "Wave";
            this.barItem20.ShowToolTipInPopUp = false;
            this.barItem20.SizeToFit = true;
            this.barItem20.Text = "Wave";
            this.barItem20.Click += new System.EventHandler(this.BorderStyle_Click);
            // 
            // barItem21
            // 
            this.barItem21.BarName = "barItem21";
            this.barItem21.CategoryIndex = 2;
            this.barItem21.ID = "None";
            this.barItem21.ShowToolTipInPopUp = false;
            this.barItem21.SizeToFit = true;
            this.barItem21.Text = "None";
            this.barItem21.Click += new System.EventHandler(this.BorderStyle_Click);
            // 
            // parentBarItem5
            // 
            this.parentBarItem5.BarName = "parentBarItem5";
            this.parentBarItem5.CategoryIndex = 2;
            this.parentBarItem5.ID = "BorderWeight";
            this.parentBarItem5.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem15,
            this.barItem22,
            this.barItem23});
            this.parentBarItem5.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.parentBarItem5.ShowToolTipInPopUp = false;
            this.parentBarItem5.SizeToFit = true;
            this.parentBarItem5.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem5.Text = "BorderWeight";
            // 
            // barItem15
            // 
            this.barItem15.BarName = "barItem15";
            this.barItem15.CategoryIndex = 2;
            this.barItem15.ID = "Thin";
            this.barItem15.ShowToolTipInPopUp = false;
            this.barItem15.SizeToFit = true;
            this.barItem15.Text = "Thin";
            this.barItem15.Click += new System.EventHandler(this.BorderWeight_Click);
            // 
            // barItem22
            // 
            this.barItem22.BarName = "barItem22";
            this.barItem22.CategoryIndex = 2;
            this.barItem22.ID = "Double";
            this.barItem22.ShowToolTipInPopUp = false;
            this.barItem22.SizeToFit = true;
            this.barItem22.Text = "Double";
            this.barItem22.Click += new System.EventHandler(this.BorderWeight_Click);
            // 
            // barItem23
            // 
            this.barItem23.BarName = "barItem23";
            this.barItem23.CategoryIndex = 2;
            this.barItem23.ID = "Bold";
            this.barItem23.ShowToolTipInPopUp = false;
            this.barItem23.SizeToFit = true;
            this.barItem23.Text = "Bold";
            this.barItem23.Click += new System.EventHandler(this.BorderWeight_Click);
            // 
            // parentBarItem6
            // 
            this.parentBarItem6.BarName = "parentBarItem6";
            this.parentBarItem6.CategoryIndex = 2;
            this.parentBarItem6.ID = "BorderColor";
            this.parentBarItem6.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem24,
            this.barItem25,
            this.barItem26,
            this.barItem27});
            this.parentBarItem6.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.parentBarItem6.ShowToolTipInPopUp = false;
            this.parentBarItem6.SizeToFit = true;
            this.parentBarItem6.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem6.Text = "BorderColor";
            // 
            // barItem24
            // 
            this.barItem24.BarName = "barItem24";
            this.barItem24.CategoryIndex = 2;
            this.barItem24.ID = "Aqua";
            this.barItem24.ShowToolTipInPopUp = false;
            this.barItem24.SizeToFit = true;
            this.barItem24.Text = "Aqua";
            this.barItem24.Click += new System.EventHandler(this.BorderColor_Click);
            // 
            // barItem25
            // 
            this.barItem25.BarName = "barItem25";
            this.barItem25.CategoryIndex = 2;
            this.barItem25.ID = "Navy";
            this.barItem25.ShowToolTipInPopUp = false;
            this.barItem25.SizeToFit = true;
            this.barItem25.Text = "Navy";
            this.barItem25.Click += new System.EventHandler(this.BorderColor_Click);
            // 
            // barItem26
            // 
            this.barItem26.BarName = "barItem26";
            this.barItem26.CategoryIndex = 2;
            this.barItem26.ID = "Khaki";
            this.barItem26.ShowToolTipInPopUp = false;
            this.barItem26.SizeToFit = true;
            this.barItem26.Text = "Khaki";
            this.barItem26.Click += new System.EventHandler(this.BorderColor_Click);
            // 
            // barItem27
            // 
            this.barItem27.BarName = "barItem27";
            this.barItem27.CategoryIndex = 2;
            this.barItem27.ID = "Salmon";
            this.barItem27.ShowToolTipInPopUp = false;
            this.barItem27.SizeToFit = true;
            this.barItem27.Text = "Salmon";
            this.barItem27.Click += new System.EventHandler(this.BorderColor_Click);
            // 
            // parentBarItem7
            // 
            this.parentBarItem7.BarName = "parentBarItem7";
            this.parentBarItem7.CategoryIndex = 3;
            this.parentBarItem7.ID = "SetTextBorder";
            this.parentBarItem7.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem28,
            this.barItem29});
            this.parentBarItem7.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.parentBarItem7.ShowToolTipInPopUp = false;
            this.parentBarItem7.SizeToFit = true;
            this.parentBarItem7.Text = "Set Text Border";
            // 
            // barItem28
            // 
            this.barItem28.BarName = "barItem28";
            this.barItem28.CategoryIndex = 3;
            this.barItem28.ID = "Selected Text";
            this.barItem28.ShowToolTipInPopUp = false;
            this.barItem28.SizeToFit = true;
            this.barItem28.Text = "Selected Text";
            this.barItem28.Click += new System.EventHandler(this.menuItem9_Click_1);
            // 
            // barItem29
            // 
            this.barItem29.BarName = "barItem29";
            this.barItem29.CategoryIndex = 3;
            this.barItem29.ID = "Specify Text Range";
            this.barItem29.ShowToolTipInPopUp = false;
            this.barItem29.SizeToFit = true;
            this.barItem29.Text = "Specify Text Range";
            this.barItem29.Click += new System.EventHandler(this.menuItem23_Click);
            // 
            // parentBarItem8
            // 
            this.parentBarItem8.BarName = "parentBarItem8";
            this.parentBarItem8.CategoryIndex = 4;
            this.parentBarItem8.ID = "RemoveTextBorder";
            this.parentBarItem8.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem30,
            this.barItem31});
            this.parentBarItem8.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.parentBarItem8.ShowToolTipInPopUp = false;
            this.parentBarItem8.SizeToFit = true;
            this.parentBarItem8.Text = "Remove Text Border";
            // 
            // barItem30
            // 
            this.barItem30.BarName = "barItem30";
            this.barItem30.CategoryIndex = 4;
            this.barItem30.ID = "Selected Text_1";
            this.barItem30.ShowToolTipInPopUp = false;
            this.barItem30.SizeToFit = true;
            this.barItem30.Text = "Selected Text";
            this.barItem30.Click += new System.EventHandler(this.menuItem24_Click);
            // 
            // barItem31
            // 
            this.barItem31.BarName = "barItem31";
            this.barItem31.CategoryIndex = 4;
            this.barItem31.ID = "Specify Text Range_1";
            this.barItem31.ShowToolTipInPopUp = false;
            this.barItem31.SizeToFit = true;
            this.barItem31.Text = "Specify Text Range";
            this.barItem31.Click += new System.EventHandler(this.menuItem25_Click);
            // 
            // barItem32
            // 
            this.barItem32.BarName = "barItem32";
            this.barItem32.CategoryIndex = 5;
            this.barItem32.ID = "SetColumnGuides";
            this.barItem32.ShowToolTipInPopUp = false;
            this.barItem32.SizeToFit = true;
            this.barItem32.Text = "SetColumnGuides";
            this.barItem32.Click += new System.EventHandler(this.column_Click);
            // 
            // parentBarItem9
            // 
            this.parentBarItem9.BarName = "parentBarItem9";
            this.parentBarItem9.CategoryIndex = 6;
            this.parentBarItem9.ID = "Cursors";
            this.parentBarItem9.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem33,
            this.barItem34,
            this.barItem35,
            this.barItem36,
            this.barItem37,
            this.barItem38,
            this.barItem39,
            this.barItem40,
            this.barItem41,
            this.barItem42,
            this.barItem43,
            this.barItem44,
            this.barItem45});
            this.parentBarItem9.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.parentBarItem9.ShowToolTipInPopUp = false;
            this.parentBarItem9.SizeToFit = true;
            this.parentBarItem9.Text = "Cursor Types";
            // 
            // barItem33
            // 
            this.barItem33.BarName = "barItem33";
            this.barItem33.CategoryIndex = 6;
            this.barItem33.ID = "AppStarting";
            this.barItem33.ShowToolTipInPopUp = false;
            this.barItem33.SizeToFit = true;
            this.barItem33.Text = "AppStarting";
            this.barItem33.Click += new System.EventHandler(this.cursor_Click);
            // 
            // barItem34
            // 
            this.barItem34.BarName = "barItem34";
            this.barItem34.CategoryIndex = 6;
            this.barItem34.ID = "Arrow";
            this.barItem34.ShowToolTipInPopUp = false;
            this.barItem34.SizeToFit = true;
            this.barItem34.Text = "Arrow";
            this.barItem34.Click += new System.EventHandler(this.cursor_Click);
            // 
            // barItem35
            // 
            this.barItem35.BarName = "barItem35";
            this.barItem35.CategoryIndex = 6;
            this.barItem35.ID = "Cross";
            this.barItem35.ShowToolTipInPopUp = false;
            this.barItem35.SizeToFit = true;
            this.barItem35.Text = "Cross";
            this.barItem35.Click += new System.EventHandler(this.cursor_Click);
            // 
            // barItem36
            // 
            this.barItem36.BarName = "barItem36";
            this.barItem36.CategoryIndex = 6;
            this.barItem36.ID = "Default";
            this.barItem36.ShowToolTipInPopUp = false;
            this.barItem36.SizeToFit = true;
            this.barItem36.Text = "Default";
            this.barItem36.Click += new System.EventHandler(this.cursor_Click);
            // 
            // barItem37
            // 
            this.barItem37.BarName = "barItem37";
            this.barItem37.CategoryIndex = 6;
            this.barItem37.ID = "Hand";
            this.barItem37.ShowToolTipInPopUp = false;
            this.barItem37.SizeToFit = true;
            this.barItem37.Text = "Hand";
            this.barItem37.Click += new System.EventHandler(this.cursor_Click);
            // 
            // barItem38
            // 
            this.barItem38.BarName = "barItem38";
            this.barItem38.CategoryIndex = 6;
            this.barItem38.ID = "Help";
            this.barItem38.ShowToolTipInPopUp = false;
            this.barItem38.SizeToFit = true;
            this.barItem38.Text = "Help";
            this.barItem38.Click += new System.EventHandler(this.cursor_Click);
            // 
            // barItem39
            // 
            this.barItem39.BarName = "barItem39";
            this.barItem39.CategoryIndex = 6;
            this.barItem39.ID = "HSplit";
            this.barItem39.ShowToolTipInPopUp = false;
            this.barItem39.SizeToFit = true;
            this.barItem39.Text = "HSplit";
            this.barItem39.Click += new System.EventHandler(this.cursor_Click);
            // 
            // barItem40
            // 
            this.barItem40.BarName = "barItem40";
            this.barItem40.CategoryIndex = 6;
            this.barItem40.ID = "IBeam";
            this.barItem40.ShowToolTipInPopUp = false;
            this.barItem40.SizeToFit = true;
            this.barItem40.Text = "IBeam";
            this.barItem40.Click += new System.EventHandler(this.cursor_Click);
            // 
            // barItem41
            // 
            this.barItem41.BarName = "barItem41";
            this.barItem41.CategoryIndex = 6;
            this.barItem41.ID = "No";
            this.barItem41.ShowToolTipInPopUp = false;
            this.barItem41.SizeToFit = true;
            this.barItem41.Text = "No";
            this.barItem41.Click += new System.EventHandler(this.cursor_Click);
            // 
            // barItem42
            // 
            this.barItem42.BarName = "barItem42";
            this.barItem42.CategoryIndex = 6;
            this.barItem42.ID = "SizeAll";
            this.barItem42.ShowToolTipInPopUp = false;
            this.barItem42.SizeToFit = true;
            this.barItem42.Text = "SizeAll";
            this.barItem42.Click += new System.EventHandler(this.cursor_Click);
            // 
            // barItem43
            // 
            this.barItem43.BarName = "barItem43";
            this.barItem43.CategoryIndex = 6;
            this.barItem43.ID = "UpArrow";
            this.barItem43.ShowToolTipInPopUp = false;
            this.barItem43.SizeToFit = true;
            this.barItem43.Text = "UpArrow";
            this.barItem43.Click += new System.EventHandler(this.cursor_Click);
            // 
            // barItem44
            // 
            this.barItem44.BarName = "barItem44";
            this.barItem44.CategoryIndex = 6;
            this.barItem44.ID = "VSplit";
            this.barItem44.ShowToolTipInPopUp = false;
            this.barItem44.SizeToFit = true;
            this.barItem44.Text = "VSplit";
            this.barItem44.Click += new System.EventHandler(this.cursor_Click);
            // 
            // barItem45
            // 
            this.barItem45.BarName = "barItem45";
            this.barItem45.CategoryIndex = 6;
            this.barItem45.ID = "WaitCursor";
            this.barItem45.ShowToolTipInPopUp = false;
            this.barItem45.SizeToFit = true;
            this.barItem45.Text = "WaitCursor";
            this.barItem45.Click += new System.EventHandler(this.cursor_Click);
            // 
            // barItem13
            // 
            this.barItem13.BarName = "barItem13";
            this.barItem13.CategoryIndex = 1;
            this.barItem13.ID = "UndoMenu";
            this.barItem13.ShowToolTipInPopUp = false;
            this.barItem13.SizeToFit = true;
            this.barItem13.Text = "UndoMenu";
            // 
            // barItem14
            // 
            this.barItem14.BarName = "barItem14";
            this.barItem14.CategoryIndex = 1;
            this.barItem14.ID = "RedoMenu";
            this.barItem14.ShowToolTipInPopUp = false;
            this.barItem14.SizeToFit = true;
            this.barItem14.Text = "RedoMenu";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.ClientSize = new System.Drawing.Size(610, 445);
            this.Controls.Add(this.editControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(622, 482);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Getting Started";
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
            this.Padding = new System.Windows.Forms.Padding(0);
        }
#endregion

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

		private void ActionMenuClick(object sender, System.EventArgs e)
		{
            BarItem mi = sender as BarItem;

			switch (mi.Text)
			{
				case "Open Group" :
					try
					{
					this.editControl1.UndoGroupOpen();
                    this.barItem8.Enabled = true;
                    this.barItem9.Enabled = true;
                    this.barItem7.Enabled = false;

					}
					catch(Exception ex)
					{
						Console.WriteLine(ex.Message);
					}

					break;
				case "Close Group" :
					try
					{
						this.editControl1.UndoGroupClose();
                        this.barItem8.Enabled = false;
                        this.barItem9.Enabled = false;
                        this.barItem7.Enabled = true;
					}
					catch(Exception ex)
					{
                        MessageBox.Show(ex.Message, "Alert");
					}
					break;
				case "Cancel Group" :
					try
					{
					this.editControl1.UndoGroupCancel();
                    this.barItem8.Enabled = false;
                    this.barItem9.Enabled = false;
                    this.barItem7.Enabled = true;
					}
					catch(Exception ex)
					{						
						MessageBox.Show(ex.Message,"Alert");
					}
					break;
				case "Undo" :
					this.editControl1.Undo();
					break;
				case "Redo" :
					this.editControl1.Redo();					
					break;
				case "Introduce Save Point" :
					this.editControl1.ResetUndoInfo();
					break;
			}
		}
        public int PhysicalLineCount
        {
            get
            {
                return this.editControl1.PhysicalLineCount;
            }
        }
        public int GetLineLength(int line)
        {
            return this.editControl1.GetLine(line).LineLength;
        }
        private void menuItem9_Select(object sender, EventArgs e)
        {
             barItem13.Enabled =this.editControl1.CanUndo;
             barItem14.Enabled = this.editControl1.CanRedo;
          
        }
        private FrameBorderStyle borderstyle = FrameBorderStyle.Dash;
        private void BorderStyle_Click(object sender, System.EventArgs e)
        {
            BarItem mi = sender as BarItem;

            switch (mi.Text)
            {
                case "Dash":
                    this.borderstyle = FrameBorderStyle.Dash;
                    break;
                case "DotDash":
                    this.borderstyle = FrameBorderStyle.DashDot;
                    break;
                case "Dot":
                    this.borderstyle = FrameBorderStyle.Dot;
                    break;
                case "Solid":
                    this.borderstyle = FrameBorderStyle.Solid;
                    break;
                case "Wave":
                    this.borderstyle = FrameBorderStyle.Wave;
                    break;
                case "None":
                    this.borderstyle = FrameBorderStyle.None;
                    break;
            }
        }
        private BorderWeight weight = BorderWeight.Thin;
        private void BorderWeight_Click(object sender, System.EventArgs e)
        {
            BarItem mi = sender as BarItem;

            switch (mi.Text)
            {
                case "Thin":
                    this.weight = BorderWeight.Thin;
                    break;
                case "Bold":
                    this.weight = BorderWeight.Bold;
                    break;
                case "Double":
                    this.weight = BorderWeight.Double;
                    break;
            }
        }
        private Color color = Color.Aqua;
        private void BorderColor_Click(object sender, System.EventArgs e)
        {
            BarItem mi = sender as BarItem;

            switch (mi.Text)
            {
                case "Aqua":
                    this.color = Color.Aqua;
                    break;
                case "Navy":
                    this.color = Color.Navy;
                    break;
                case "Khaki":
                    this.color = Color.Khaki;
                    break;
                case "Salmon":
                    this.color = Color.Salmon;
                    break;
            }
        }
        private void menuItem9_Click_1(object sender, System.EventArgs e)
        {
            if (editControl1.SelectedText != String.Empty)
            {
                // Set borders to the selected text
                this.editControl1.SetTextBorder(this.editControl1.Selection.Top, this.editControl1.Selection.Bottom, color, this.borderstyle, this.weight);
            }
            else
                MessageBox.Show("Please select text.","Select");
        }
        private void menuItem23_Click(object sender, System.EventArgs e)
        {
            Form2 dialog = new Form2(this);
            if (DialogResult.OK == dialog.ShowDialog())
            {
                int startline = dialog.startLine;
                int startcolumn = dialog.startColumn;

                CoordinatePoint startCoordinatePoint;
                CoordinatePoint endCoordinatePoint;

                int endline = dialog.endLine;
                int endcolumn = dialog.endColumn;

                if ((startcolumn * startline * endcolumn * endline) == 0)
                {
                    MessageBox.Show(" Zero is not valid line number or column number", "Invalid Number");
                    return;
                }

                if (endcolumn < startcolumn)
                {
                    int temp = endcolumn;
                    endcolumn = startcolumn;
                    startcolumn = temp;
                }
                if (endline < startline)
                {
                    int temp = endline;
                    endline = startline;
                    startline = temp;
                }

                if ((startline < this.editControl1.PhysicalLineCount) && (endline < this.editControl1.PhysicalLineCount))
                {
                    if ((endcolumn < this.editControl1.GetLine(endline).LineLength) && (startcolumn < this.editControl1.GetLine(startline).LineLength))
                    {
                        // Creating the associated CoordinatePoints that indicate the text range                       

                        startCoordinatePoint = this.editControl1.ConvertVirtualPointToCoordinatePoint(startcolumn, startline);
                        endCoordinatePoint = this.editControl1.ConvertVirtualPointToCoordinatePoint(endcolumn, endline);

                        // Set borders to the specified text range
                        this.editControl1.SetTextBorder(startCoordinatePoint, endCoordinatePoint, color, this.borderstyle, this.weight);
                    }
                    else
                    {
                        MessageBox.Show(this, "Starting or Ending column number is greater than the number of Columns in the line", "Wrong Column Number", MessageBoxButtons.OK);
                    }

                }
                else
                {
                    MessageBox.Show(this, "Starting or Ending line number is greater than the number of lines in EditControl", "Wrong Line Number", MessageBoxButtons.OK);
                }
            }

        }
        private void menuItem24_Click(object sender, System.EventArgs e)
        {
            if (this.editControl1.Selection != null)
                // Remove borders from the selected text
                this.editControl1.RemoveTextBorder(this.editControl1.Selection.Top, this.editControl1.Selection.Bottom);
            else
                MessageBox.Show("Please select text containing border.","Select");
        }
        private void menuItem25_Click(object sender, System.EventArgs e)
        {
            Form2 dialog = new Form2(this);
            if (DialogResult.OK == dialog.ShowDialog())
            {

                int startline = dialog.startLine;
                int startcolumn = dialog.startColumn;

                CoordinatePoint startCoordinatePoint;
                CoordinatePoint endCoordinatePoint;

                int endline = dialog.endLine;
                int endcolumn = dialog.endColumn;

                if ((startcolumn * startline * endcolumn * endline) == 0)
                {
                    MessageBox.Show(" Zero is not valid line number or column number", "Invalid Number");
                    return;
                }

                if (endcolumn < startcolumn)
                {
                    int temp = endcolumn;
                    endcolumn = startcolumn;
                    startcolumn = temp;
                }
                if (endline < startline)
                {
                    int temp = endline;
                    endline = startline;
                    startline = temp;
                }


                if ((startline < this.editControl1.PhysicalLineCount) && (endline < this.editControl1.PhysicalLineCount))
                {
                    if ((endcolumn < this.editControl1.GetLine(endline).LineLength) && (startcolumn < this.editControl1.GetLine(startline).LineLength))
                    {
                        // Creating the associated CoordinatePoints that indicate the text range
                        startCoordinatePoint = this.editControl1.ConvertVirtualPointToCoordinatePoint(startcolumn, startline);
                        endCoordinatePoint = this.editControl1.ConvertVirtualPointToCoordinatePoint(endcolumn, endline);

                        // Remove borders to the specified text range
                        this.editControl1.RemoveTextBorder(startCoordinatePoint, endCoordinatePoint);
                    }
                    else
                    {
                        MessageBox.Show(this, "Starting or Ending column number is greater than the number of Columns in the line", "Wrong Column Number", MessageBoxButtons.OK);
                    }

                }
                else
                {
                    MessageBox.Show(this, "Starting or Ending line number is greater than the number of lines in EditControl", "Wrong Line Number", MessageBoxButtons.OK);
                }
            }
        }
        private void column_Click(object sender, System.EventArgs e)
        {
            ColumnGuidesEditor cgEditor = new ColumnGuidesEditor();

            if (cgEditor.ShowDialog() == DialogResult.OK)
            {
                if (!ColumnGuidesEditor.invalidinput)
                {
                    CreateColumnGuideItems();
                }
            }
        }

        private void CreateColumnGuideItems()
        {
            try
            {
                columnGuideItem = new ColumnGuideItem[ColumnGuidesEditor.columncount];
                for (int i = 0; i < ColumnGuidesEditor.columncount; i++)
                {
                    for (KnownColor enumValue = KnownColor.YellowGreen; enumValue >= 0; enumValue--)
                    {
                        string s = enumValue.ToString();
                        System.Drawing.Color somecolor = Color.FromKnownColor(enumValue);

                        if ((s.CompareTo(ColumnGuidesEditor.color[i])) == 0)
                        {
                            columnGuideItem[i] = new ColumnGuideItem(int.Parse(ColumnGuidesEditor.columnnumber[i]), somecolor);
                        }
                    }

                }

                this.editControl1.ColumnGuideItems = columnGuideItem;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Enter the known colors");
            }
        }
 			
		private void cm_FillMenu(object sender, EventArgs e)
		{
			ContextMenuManager cm = (ContextMenuManager) sender;
			
			// To clear default context menu items 
			// cm.ClearMenu();

			// Add a separator
			cm.AddSeparator();
            cm.ContextMenuProvider.SetVisualStyle(VisualStyle.Metro);
			// Add custom custom context menu items and their Click eventhandlers
			cm.AddMenuItem("&Find", new EventHandler(ShowFindDialog));
			cm.AddMenuItem("&Replace", new EventHandler(ShowReplaceDialog));
			cm.AddMenuItem("&Goto", new EventHandler(ShowGoToDialog));

			
			// If you need to get access to the underlying menu provider you can access it via:
			Syncfusion.Windows.Forms.IContextMenuProvider contextMenuProvider = this.editControl1.ContextMenuManager.ContextMenuProvider;
			//	contextMenuProvider.SetContextMenuItemChecked(...);
			//	contextMenuProvider.SetContextMenuItemEnabled(...);
			//	contextMenuProvider.SetContextMenuItemImage(...);
			//	contextMenuProvider.SetContextMenuItemShortcut(...);
		}


		void ShowFindDialog(object sender, EventArgs e)
		{
			this.editControl1.ShowFindDialog();
		}

		void ShowReplaceDialog(object sender, EventArgs e)
		{
			this.editControl1.ShowReplaceDialog();
		}

		void ShowGoToDialog(object sender, EventArgs e)
		{
			this.editControl1.ShowGoToDialog();
		}
        private void editControl1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.editControl1.Cursor = this.currentCursor;
        }

        private void cursor_Click(object sender, System.EventArgs e)
        {
            BarItem mitem = sender as BarItem;

            switch (mitem.Text)
            {
                case "AppStarting":
                    this.currentCursor = Cursors.AppStarting;
                    this.barItem33.Checked = true;
                    this.barItem34.Checked = false;
                    this.barItem35.Checked = false;
                    this.barItem36.Checked = false;
                    this.barItem37.Checked = false;
                    this.barItem38.Checked = false;
                    this.barItem39.Checked = false;
                    this.barItem40.Checked = false;
                    this.barItem41.Checked = false;
                    this.barItem42.Checked = false;
                    this.barItem43.Checked = false;
                    this.barItem44.Checked = false;
                    this.barItem45.Checked = false;
                    break;

                case "Arrow":
                    this.currentCursor = Cursors.Arrow;
                    this.barItem33.Checked = false;
                    this.barItem34.Checked = true;
                    this.barItem35.Checked = false;
                    this.barItem36.Checked = false;
                    this.barItem37.Checked = false;
                    this.barItem38.Checked = false;
                    this.barItem39.Checked = false;
                    this.barItem40.Checked = false;
                    this.barItem41.Checked = false;
                    this.barItem42.Checked = false;
                    this.barItem43.Checked = false;
                    this.barItem44.Checked = false;
                    this.barItem45.Checked = false;
                    break;

                case "Cross":
                    this.currentCursor = Cursors.Cross;
                    this.barItem33.Checked = false;
                    this.barItem34.Checked = false;
                    this.barItem35.Checked = true;
                    this.barItem36.Checked = false;
                    this.barItem37.Checked = false;
                    this.barItem38.Checked = false;
                    this.barItem39.Checked = false;
                    this.barItem40.Checked = false;
                    this.barItem41.Checked = false;
                    this.barItem42.Checked = false;
                    this.barItem43.Checked = false;
                    this.barItem44.Checked = false;
                    this.barItem45.Checked = false;
                    break;

                case "Default":
                    this.currentCursor = Cursors.Default;
                    this.barItem33.Checked = false;
                    this.barItem34.Checked = false;
                    this.barItem35.Checked = false;
                    this.barItem36.Checked = true;
                    this.barItem37.Checked = false;
                    this.barItem38.Checked = false;
                    this.barItem39.Checked = false;
                    this.barItem40.Checked = false;
                    this.barItem41.Checked = false;
                    this.barItem42.Checked = false;
                    this.barItem43.Checked = false;
                    this.barItem44.Checked = false;
                    this.barItem45.Checked = false;
                    break;

                case "Hand":
                    this.currentCursor = Cursors.Hand;
                    this.barItem33.Checked = false;
                    this.barItem34.Checked = false;
                    this.barItem35.Checked = false;
                    this.barItem36.Checked = false;
                    this.barItem37.Checked = true;
                    this.barItem38.Checked = false;
                    this.barItem39.Checked = false;
                    this.barItem40.Checked = false;
                    this.barItem41.Checked = false;
                    this.barItem42.Checked = false;
                    this.barItem43.Checked = false;
                    this.barItem44.Checked = false;
                    this.barItem45.Checked = false;
                    break;

                case "Help":
                    this.currentCursor = Cursors.Help;
                    this.barItem33.Checked = false;
                    this.barItem34.Checked = false;
                    this.barItem35.Checked = false;
                    this.barItem36.Checked = false;
                    this.barItem37.Checked = false;
                    this.barItem38.Checked = true;
                    this.barItem39.Checked = false;
                    this.barItem40.Checked = false;
                    this.barItem41.Checked = false;
                    this.barItem42.Checked = false;
                    this.barItem43.Checked = false;
                    this.barItem44.Checked = false;
                    this.barItem45.Checked = false;
                    break;

                case "HSplit":
                    this.currentCursor = Cursors.HSplit;
                    this.barItem33.Checked = false;
                    this.barItem34.Checked = false;
                    this.barItem35.Checked = false;
                    this.barItem36.Checked = false;
                    this.barItem37.Checked = false;
                    this.barItem38.Checked = false;
                    this.barItem39.Checked = true;
                    this.barItem40.Checked = false;
                    this.barItem41.Checked = false;
                    this.barItem42.Checked = false;
                    this.barItem43.Checked = false;
                    this.barItem44.Checked = false;
                    this.barItem45.Checked = false;
                    break;

                case "IBeam":
                    this.currentCursor = Cursors.IBeam;
                    this.barItem33.Checked = false;
                    this.barItem34.Checked = false;
                    this.barItem35.Checked = false;
                    this.barItem36.Checked = false;
                    this.barItem37.Checked = false;
                    this.barItem38.Checked = false;
                    this.barItem39.Checked = false;
                    this.barItem40.Checked = true;
                    this.barItem41.Checked = false;
                    this.barItem42.Checked = false;
                    this.barItem43.Checked = false;
                    this.barItem44.Checked = false;
                    this.barItem45.Checked = false;
                    break;

                case "No":
                    this.currentCursor = Cursors.No;
                    this.barItem33.Checked = false;
                    this.barItem34.Checked = false;
                    this.barItem35.Checked = false;
                    this.barItem36.Checked = false;
                    this.barItem37.Checked = false;
                    this.barItem38.Checked = false;
                    this.barItem39.Checked = false;
                    this.barItem40.Checked = false;
                    this.barItem41.Checked = true;
                    this.barItem42.Checked = false;
                    this.barItem43.Checked = false;
                    this.barItem44.Checked = false;
                    this.barItem45.Checked = false;
                    break;

                case "SizeAll":
                    this.currentCursor = Cursors.SizeAll;
                    this.barItem33.Checked = false;
                    this.barItem34.Checked = false;
                    this.barItem35.Checked = false;
                    this.barItem36.Checked = false;
                    this.barItem37.Checked = false;
                    this.barItem38.Checked = false;
                    this.barItem39.Checked = false;
                    this.barItem40.Checked = false;
                    this.barItem41.Checked = false;
                    this.barItem42.Checked = true;
                    this.barItem43.Checked = false;
                    this.barItem44.Checked = false;
                    this.barItem45.Checked = false;
                    break;

                case "UpArrow":
                    this.currentCursor = Cursors.UpArrow;
                    this.barItem33.Checked = false;
                    this.barItem34.Checked = false;
                    this.barItem35.Checked = false;
                    this.barItem36.Checked = false;
                    this.barItem37.Checked = false;
                    this.barItem38.Checked = false;
                    this.barItem39.Checked = false;
                    this.barItem40.Checked = false;
                    this.barItem41.Checked = false;
                    this.barItem42.Checked = false;
                    this.barItem43.Checked = true;
                    this.barItem44.Checked = false;
                    this.barItem45.Checked = false;
                    break;

                case "VSplit":
                    this.currentCursor = Cursors.VSplit;
                    this.barItem33.Checked = false;
                    this.barItem34.Checked = false;
                    this.barItem35.Checked = false;
                    this.barItem36.Checked = false;
                    this.barItem37.Checked = false;
                    this.barItem38.Checked = false;
                    this.barItem39.Checked = false;
                    this.barItem40.Checked = false;
                    this.barItem41.Checked = false;
                    this.barItem42.Checked = false;
                    this.barItem43.Checked = false;
                    this.barItem44.Checked = true;
                    this.barItem45.Checked = false;
                    break;

                case "WaitCursor":
                    this.currentCursor = Cursors.WaitCursor;
                    this.barItem33.Checked = false;
                    this.barItem34.Checked = false;
                    this.barItem35.Checked = false;
                    this.barItem36.Checked = false;
                    this.barItem37.Checked = false;
                    this.barItem38.Checked = false;
                    this.barItem39.Checked = false;
                    this.barItem40.Checked = false;
                    this.barItem41.Checked = false;
                    this.barItem42.Checked = false;
                    this.barItem43.Checked = false;
                    this.barItem44.Checked = false;
                    this.barItem45.Checked = true;
                    break;
            }
            this.editControl1.Cursor = this.currentCursor;
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
