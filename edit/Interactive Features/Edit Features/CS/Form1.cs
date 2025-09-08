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
using Syncfusion.Windows.Forms.Edit.Utils;
using Syncfusion.Windows.Forms.Edit.Dialogs;
using Syncfusion.Windows.Forms.Edit.Implementation.Config;
using Syncfusion.Windows.Forms.Edit.Interfaces;
using Syncfusion.Windows.Forms.Edit.Implementation.IO;
using Syncfusion.Windows.Forms.Edit.Implementation.Formatting;
using Syncfusion.Windows.Forms.Edit.Implementation.Parser;
using Syncfusion.IO;
using Syncfusion.Drawing;

using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Syncfusion.Windows.Forms.Edit.Implementation;
using Syncfusion.Windows.Forms.Edit.Enums;
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;
using Syncfusion.WinForms.Controls;

namespace EditFeaturesDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : SfForm
    {
        private System.Windows.Forms.PropertyGrid edtProperties;
        private IContainer components = null;
        private Syncfusion.Windows.Forms.Edit.EditControl editControl1;
        private MenuStrip MainStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem optnToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStrip featuresStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton indentationBtn;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripButton scrollbarBtn;
        private ToolStripButton toolStripButton7;
        private ToolStripMenuItem propertyGridItem;
        private ToolStrip featuresStrip2;
        private ToolStripButton splittersBtn;
        private ToolStripButton propertygribtn;
        private ToolStripButton RTLbtn;
        private ToolStripButton statusBarBtn;
        private ToolStripButton toolStripButton10;
        private ToolStripButton toolStripButton11;
        private ToolStripButton toolStripButton12;
        private ToolStripButton wordwrapbtnItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButton14;
        private ToolStripButton toolStripButton15;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem rightToLeftToolStripMenuItem;
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

			this.editControl1.UserMarginBackgroundColor = new BrushInfo(GradientStyle.ForwardDiagonal, Color.Beige, Color.Orange);
			this.editControl1.ShowUserMargin = false;
			//this.usermarginItem.Checked = false;

			this.edtProperties.Visible = false;
			//this.propertiesgridItem.Checked = false;

			this.editControl1.ShowWhitespaces = false;
			//this.whitespacesItem.Checked = false;

			this.editControl1.ShowUserMargin = false;
			//this.usermarginItem.Checked = false;

			this.editControl1.StatusBarSettings.Visible = true;
			//this.statusbarItem.Checked = true;

			this.editControl1.ShowHorizontalScroller = true;
			this.editControl1.ShowVerticalScroller = true;
            this.scrollbarBtn.Checked = true;

			this.editControl1.ShowHorizontalSplitters = true;
			this.editControl1.ShowVerticalSplitters = true;
            this.splittersBtn.Checked = true;

			this.editControl1.ShowLineNumbers = true;
			//this.linenumberItem.Checked = true;

			this.editControl1.ShowIndicatorMargin = true;
			this.editControl1.MarkerAreaWidth = 20;
			//this.indicatorItem.Checked = true;

			this.editControl1.ShowOutliningCollapsers = true;	
			//this.outliningItem.Checked = true;

			this.editControl1.ShowIndentationGuidelines = true;
            this.indentationBtn.Checked = true;

			this.editControl1.ShowSelectionMargin = false;
			this.editControl1.SelectionMarginWidth = 25;
			this.editControl1.SelectionMarginBackgroundColor = Color.IndianRed;
			this.editControl1.SelectionMarginForegroundColor = Color.DarkGray;
			//this.selectionmarginItem.Checked = false;

			this.editControl1.StatusBarSettings.Visible = true;
			this.editControl1.StatusBarSettings.TextPanel.Visible = true;
			this.editControl1.StatusBarSettings.StatusPanel.Visible = true;
			this.editControl1.StatusBarSettings.EncodingPanel.Visible = true;
			this.editControl1.StatusBarSettings.CoordsPanel.Visible = true;
			this.editControl1.StatusBarSettings.InsertPanel.Visible = true;
			this.editControl1.StatusBarSettings.TextPanel.Panel.Text = filePath;
			this.editControl1.StatusBarSettings.StatusPanel.Panel.Text = "Edit Features";
			this.editControl1.StatusBarSettings.EncodingPanel.Panel.Text = "Parsing Mode : " + this.editControl1.ParsingMode.ToString();
			this.editControl1.StatusBarSettings.CoordsPanel.Panel.Text = Control.MousePosition.ToString();
			this.editControl1.StatusBarSettings.InsertPanel.Panel.Text = "Insert Key : " + (this.editControl1.InsertMode == true? "ON": "OFF");
            this.statusBarBtn.Checked = true;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(GetIconFile(@"..\\..\\\logo.ico")));
                this.Icon = ico;
            }
            catch { }
            Customization();


            this.editControl1.LoadFile(filePath);	
	
			this.Size = new Size(664,500);
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
            Syncfusion.Windows.Forms.Edit.Implementation.Config.Config config3 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.edtProperties = new System.Windows.Forms.PropertyGrid();
            this.editControl1 = new Syncfusion.Windows.Forms.Edit.EditControl();
            this.MainStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyGridItem = new System.Windows.Forms.ToolStripMenuItem();
            this.featuresStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.indentationBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.scrollbarBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.featuresStrip2 = new System.Windows.Forms.ToolStrip();
            this.splittersBtn = new System.Windows.Forms.ToolStripButton();
            this.propertygribtn = new System.Windows.Forms.ToolStripButton();
            this.RTLbtn = new System.Windows.Forms.ToolStripButton();
            this.statusBarBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.wordwrapbtnItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.rightToLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
            this.MainStrip.SuspendLayout();
            this.featuresStrip1.SuspendLayout();
            this.featuresStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // edtProperties
            // 
            this.edtProperties.BackColor = System.Drawing.Color.White;
            this.edtProperties.CommandsBackColor = System.Drawing.SystemColors.Window;
            this.edtProperties.Dock = System.Windows.Forms.DockStyle.Right;
            this.edtProperties.HelpBackColor = System.Drawing.Color.White;
            this.edtProperties.LineColor = System.Drawing.SystemColors.Menu;
            this.edtProperties.Location = new System.Drawing.Point(574, 84);
            this.edtProperties.Name = "edtProperties";
            this.edtProperties.SelectedObject = this.editControl1;
            this.edtProperties.Size = new System.Drawing.Size(232, 372);
            this.edtProperties.TabIndex = 25;
            this.edtProperties.Visible = false;
            // 
            // editControl1
            // 
            this.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.editControl1.CodeSnipptSize = new System.Drawing.Size(100, 100);
            this.editControl1.Configurator = config3;
            this.editControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editControl1.IndicatorMarginBackColor = System.Drawing.Color.Empty;
            this.editControl1.LineNumbersFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editControl1.Location = new System.Drawing.Point(10, 84);
            this.editControl1.Name = "editControl1";
            this.editControl1.RenderRightToLeft = false;
            this.editControl1.ScrollPosition = new System.Drawing.Point(0, 0);
            this.editControl1.ScrollVisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;
            this.editControl1.SharedFileMode = true;
            this.editControl1.Size = new System.Drawing.Size(564, 372);

            this.editControl1.StatusBarSettings.TextPanel.AutoSize = false;
            this.editControl1.TabIndex = 27;
            this.editControl1.Text = "";
            this.editControl1.UseXPStyleBorder = true;
            this.editControl1.VisualColumn = 1;
            // 
            // MainStrip
            // 
            this.MainStrip.BackColor = System.Drawing.Color.White;
            this.MainStrip.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
           
           });
            this.MainStrip.Location = new System.Drawing.Point(10, 10);
            this.MainStrip.Name = "MainStrip";
            this.MainStrip.Size = new System.Drawing.Size(796, 24);
            this.MainStrip.TabIndex = 28;
            this.MainStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.optnToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // optnToolStripMenuItem
            // 
            this.optnToolStripMenuItem.Name = "optnToolStripMenuItem";
            this.optnToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.optnToolStripMenuItem.Text = "Open...";
            this.optnToolStripMenuItem.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(118, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(118, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // propertyGridItem
            // 
            this.propertyGridItem.CheckOnClick = true;
            this.propertyGridItem.Name = "propertyGridItem";
            this.propertyGridItem.Size = new System.Drawing.Size(87, 20);
            this.propertyGridItem.Text = "Property Grid";
            this.propertyGridItem.Click += new System.EventHandler(this.propertyGridToolStripMenuItem_Click);
            // 
            // featuresStrip1
            // 
            this.featuresStrip1.BackColor = System.Drawing.Color.White;
            this.featuresStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.featuresStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.propertygribtn,
            this.RTLbtn,
            this.indentationBtn,
            this.toolStripButton3,
            this.toolStripSeparator5,
            this.toolStripButton4,
            this.toolStripButton5,
            this.scrollbarBtn,
            this.toolStripButton7});
            this.featuresStrip1.Location = new System.Drawing.Point(10, 34);
            this.featuresStrip1.Name = "featuresStrip1";
            this.featuresStrip1.Size = new System.Drawing.Size(796, 25);
            this.featuresStrip1.TabIndex = 29;
            this.featuresStrip1.Text = "ToolStrip";
            this.featuresStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(63, 22);
            this.toolStripButton1.Text = "Bookmark";
            // 
            // indentationBtn
            // 
            this.indentationBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.indentationBtn.Image = ((System.Drawing.Image)(resources.GetObject("indentationBtn.Image")));
            this.indentationBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.indentationBtn.Name = "indentationBtn";
            this.indentationBtn.Size = new System.Drawing.Size(130, 22);
            this.indentationBtn.Text = "Indentation Guidelines";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Checked = true;
            this.toolStripButton3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(97, 22);
            this.toolStripButton3.Text = "Indicator Margin";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Checked = true;
            this.toolStripButton4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton4.Text = "Line no";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Checked = true;
            this.toolStripButton5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(117, 22);
            this.toolStripButton5.Text = "Outlining Collapsers";
            // 
            // scrollbarBtn
            // 
            this.scrollbarBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.scrollbarBtn.Image = ((System.Drawing.Image)(resources.GetObject("scrollbarBtn.Image")));
            this.scrollbarBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scrollbarBtn.Name = "scrollbarBtn";
            this.scrollbarBtn.Size = new System.Drawing.Size(61, 22);
            this.scrollbarBtn.Text = "Scrollbars";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(98, 22);
            this.toolStripButton7.Text = "Selection Margin";
            // 
            // featuresStrip2
            // 
            this.featuresStrip2.BackColor = System.Drawing.Color.White;
            this.featuresStrip2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.featuresStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.splittersBtn,
            this.statusBarBtn,
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStripSeparator4,
            this.toolStripButton12,
            this.wordwrapbtnItem,
            this.toolStripSeparator3,
            this.toolStripButton14,
            this.toolStripButton15});
            this.featuresStrip2.Location = new System.Drawing.Point(10, 59);
            this.featuresStrip2.Name = "featuresStrip2";
            this.featuresStrip2.Size = new System.Drawing.Size(796, 25);
            this.featuresStrip2.TabIndex = 30;
            this.featuresStrip2.Text = "toolStrip2";
            this.featuresStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // splittersBtn
            // 
            this.splittersBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.splittersBtn.Image = ((System.Drawing.Image)(resources.GetObject("splittersBtn.Image")));
            this.splittersBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.splittersBtn.Name = "splittersBtn";
            this.splittersBtn.Size = new System.Drawing.Size(53, 22);
            this.splittersBtn.Text = "Splitters";
            

            // 
            // propertygribtn
            // 
            this.propertygribtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.propertygribtn.Image = ((System.Drawing.Image)(resources.GetObject("splittersBtn.Image")));
            this.propertygribtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.propertygribtn.Name = "splittersBtn";
            this.propertygribtn.Size = new System.Drawing.Size(53, 22);
            this.propertygribtn.Text = "Property Grid";

            // 
            // splittersBtn
            // 
            this.RTLbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RTLbtn.Image = ((System.Drawing.Image)(resources.GetObject("splittersBtn.Image")));
            this.RTLbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RTLbtn.Name = "splittersBtn";
            this.RTLbtn.Size = new System.Drawing.Size(53, 22);
            this.RTLbtn.Text = "RightToLeft";
            // 
            // statusBarBtn
            // 
            this.statusBarBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusBarBtn.Image = ((System.Drawing.Image)(resources.GetObject("statusBarBtn.Image")));
            this.statusBarBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.statusBarBtn.Name = "statusBarBtn";
            this.statusBarBtn.Size = new System.Drawing.Size(60, 22);
            this.statusBarBtn.Text = "StatusBar";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(74, 22);
            this.toolStripButton10.Text = "User Margin";
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(80, 22);
            this.toolStripButton11.Text = "White Spaces";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Size = new System.Drawing.Size(110, 22);
            this.toolStripButton12.Text = "Wordwrap Markers";
            // 
            // wordwrapbtnItem
            // 
            this.wordwrapbtnItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.wordwrapbtnItem.Image = ((System.Drawing.Image)(resources.GetObject("wordwrapbtnItem.Image")));
            this.wordwrapbtnItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.wordwrapbtnItem.Name = "wordwrapbtnItem";
            this.wordwrapbtnItem.Size = new System.Drawing.Size(69, 22);
            this.wordwrapbtnItem.Text = "Word wrap";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(71, 22);
            this.toolStripButton14.Text = "Collapse All";
            // 
            // toolStripButton15
            // 
            this.toolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton15.Image")));
            this.toolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton15.Name = "toolStripButton15";
            this.toolStripButton15.Size = new System.Drawing.Size(65, 22);
            this.toolStripButton15.Text = "Expand All";
            // 
            // rightToLeftToolStripMenuItem
            // 
            this.rightToLeftToolStripMenuItem.Name = "rightToLeftToolStripMenuItem";
            this.rightToLeftToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.rightToLeftToolStripMenuItem.Text = "Right To Left";
            this.rightToLeftToolStripMenuItem.Click += new System.EventHandler(this.rightToLeftToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.ClientSize = new System.Drawing.Size(816, 466);
            this.Controls.Add(this.editControl1);
            this.Controls.Add(this.edtProperties);
            this.Controls.Add(this.featuresStrip2);
            this.Controls.Add(this.featuresStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainStrip;
            this.MinimumSize = new System.Drawing.Size(828, 503);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Features";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).EndInit();
            this.MainStrip.ResumeLayout(false);
            this.MainStrip.PerformLayout();
            this.featuresStrip1.ResumeLayout(false);
            this.featuresStrip1.PerformLayout();
            this.featuresStrip2.ResumeLayout(false);
            this.featuresStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
            this.editControl1.Style = EditControlStyle.Office2016White;
            this.Padding = new System.Windows.Forms.Padding(0);
        }
        #endregion

        private void MainMenuClick(object sender, System.EventArgs e)
		{
            ToolStripMenuItem mi = sender as ToolStripMenuItem;

			switch (mi.Text)
			{
				case "New" :
					this.editControl1.NewFile();
					break;
				case "Open..." :
					this.editControl1.LoadFile();
					break;
				case "Save" :
					this.editControl1.Save();
					break;
				case "Save As..." :
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

        private void propertyGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.edtProperties.Visible = propertyGridItem.Checked;
            if(edtProperties.Visible)
                this.Size = new Size(825, 520);
            else
                this.Size = new Size(664, 500);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
			if(e.ClickedItem is ToolStripButton)
			{
	            ToolStripButton mi = (ToolStripButton)e.ClickedItem;

	            switch (mi.Text)
	            {
	                case "Bookmark":
	                    this.editControl1.BookmarkAdd(this.editControl1.CurrentLine);
	                    break;
                    case "Property Grid":
                        if (this.edtProperties.Visible)
                        {
                            this.edtProperties.Visible = false;
                            mi.Checked = this.edtProperties.Visible;
                            if (edtProperties.Visible)
                                this.Size = new Size(825, 520);
                            else
                                this.Size = new Size(664, 500);
                        }
                        else
                        {
                            this.edtProperties.Visible = true;
                            mi.Checked = this.edtProperties.Visible;
                            if (edtProperties.Visible)
                                this.Size = new Size(825, 520);
                            else
                                this.Size = new Size(664, 500);
                        }
                        break;
                    case "RightToLeft":
                        this.editControl1.RenderRightToLeft = !this.editControl1.RenderRightToLeft;
                        mi.Checked = this.editControl1.RenderRightToLeft;
                        break;
                    case "Indentation Guidelines":
	                    this.editControl1.ShowIndentationGuidelines = !this.editControl1.ShowIndentationGuidelines;
	                    mi.Checked = this.editControl1.ShowIndentationGuidelines;
	                    break;
	                case "Indicator Margin":
	                    this.editControl1.ShowIndicatorMargin = !this.editControl1.ShowIndicatorMargin;
	                    mi.Checked = this.editControl1.ShowIndicatorMargin;
	                    break;
	                case "Line no":
	                    this.editControl1.ShowLineNumbers = !this.editControl1.ShowLineNumbers;
	                    mi.Checked = this.editControl1.ShowLineNumbers;
	                    break;
	                case "Outlining Collapsers":
	                    this.editControl1.ShowOutliningCollapsers = !this.editControl1.ShowOutliningCollapsers;
	                    mi.Checked = this.editControl1.ShowOutliningCollapsers;
	                    break;
	                case "Scrollbars":
	                    this.editControl1.ShowHorizontalScroller = !this.editControl1.ShowHorizontalScroller;
	                    this.editControl1.ShowVerticalScroller = !this.editControl1.ShowVerticalScroller;
	                    mi.Checked = !mi.Checked;
	                    break;
	                case "Selection Margin":
	                    this.editControl1.ShowSelectionMargin = !this.editControl1.ShowSelectionMargin;
	                    mi.Checked = this.editControl1.ShowSelectionMargin;
	                    break;
	            }
			}
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripButton mi = (ToolStripButton)e.ClickedItem;

            switch (mi.Text)
            {
                case "Splitters":
                    this.editControl1.ShowHorizontalSplitters = !this.editControl1.ShowHorizontalSplitters;
                    this.editControl1.ShowVerticalSplitters = !this.editControl1.ShowVerticalSplitters;
                    mi.Checked = !mi.Checked;
                    break;
                case "StatusBar":
                    this.editControl1.StatusBarSettings.Visible = !this.editControl1.StatusBarSettings.Visible;
                    mi.Checked = this.editControl1.StatusBarSettings.Visible;
                    break;
                case "User Margin":
                    this.editControl1.ShowUserMargin = !this.editControl1.ShowUserMargin;
                    mi.Checked = this.editControl1.ShowUserMargin;
                    break;
                case "White Spaces":
                    this.editControl1.ShowWhitespaces = !this.editControl1.ShowWhitespaces;
                    mi.Checked = this.editControl1.ShowWhitespaces;
                    break;
                case "Wordwrap Markers":
                    if (this.editControl1.MarkWrappedLines == false)
                    {
                        this.editControl1.WordWrap = true;
                        this.wordwrapbtnItem.Checked = true;
                    }
                    this.editControl1.MarkWrappedLines = !this.editControl1.MarkWrappedLines;
                    mi.Checked = this.editControl1.MarkWrappedLines;
                    break;
                case "Word wrap":
                    this.editControl1.WordWrap = !this.editControl1.WordWrap;
                    mi.Checked = this.editControl1.WordWrap;
                    break;
                case "Collapse All":
                    this.editControl1.CollapseAll();
                    break;
                case "Expand All":
                    this.editControl1.ExpandAll();
                    break;
            }
        }

        private void rightToLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.editControl1.RenderRightToLeft = !this.editControl1.RenderRightToLeft;
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
