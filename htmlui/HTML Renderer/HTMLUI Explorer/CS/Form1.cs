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
using System.Diagnostics;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms.HTMLUI;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Licensing;
using System.IO;

namespace Syncfusion.Windows.Forms.samples.HTMLUIExplorer
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
		#region Variables
        private Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl htmluiControl1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Panel panel1;
		private ButtonAdv button1;
		private System.Windows.Forms.Label label1;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ImageList imageList1;
		private ButtonAdv button12;
        private System.Windows.Forms.Panel panel3;
		Uri home;
		string selectedText = "";
		string homeLocation = "";
		HTMLUIPrintDocument pd;
		float DftfontSize = 0;
        private ComboBoxAdv comboBox1;
        private Tools.XPMenus.XPToolBar xpToolBar1;
        private Tools.XPMenus.BarItem barItem1;
        private Tools.XPMenus.BarItem barItem2;
        private Tools.XPMenus.BarItem barItem3;
        private Tools.XPMenus.BarItem barItem4;
        private Tools.XPMenus.BarItem barItem5;
        private Tools.XPMenus.BarItem barItem6;
        private Tools.XPMenus.BarItem barItem7;
        private Tools.XPMenus.BarItem barItem8;
        private Tools.XPMenus.BarItem barItem9;
        private Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
        private Tools.XPMenus.Bar bar1;
        private Tools.XPMenus.ParentBarItem parentBarItem1;
        private Tools.XPMenus.BarItem barItem10;
        private Tools.XPMenus.BarItem barItem11;
        private Tools.XPMenus.BarItem barItem12;
        private Tools.XPMenus.BarItem barItem13;
        private Tools.XPMenus.ParentBarItem parentBarItem2;
        private Tools.XPMenus.BarItem barItem14;
        private Tools.XPMenus.ParentBarItem parentBarItem3;
        private Tools.XPMenus.ParentBarItem parentBarItem4;
        private Tools.XPMenus.ParentBarItem parentBarItem5;
        private Tools.XPMenus.BarItem barItem15;
        private Tools.XPMenus.BarItem barItem16;
        private Tools.XPMenus.BarItem barItem17;
        private Tools.XPMenus.BarItem barItem18;
        private Tools.XPMenus.ParentBarItem parentBarItem6;
        private Tools.XPMenus.BarItem barItem19;
        private Tools.XPMenus.BarItem barItem20;
        private Tools.XPMenus.BarItem barItem21;
        private Tools.XPMenus.BarItem barItem22;
        private Tools.XPMenus.ParentBarItem parentBarItem7;
        private Tools.XPMenus.BarItem barItem23;
        private Tools.XPMenus.ParentBarItem parentBarItem8;
        private Tools.XPMenus.BarItem barItem24;
        private Tools.XPMenus.BarItem barItem25;
        private Tools.XPMenus.ParentBarItem parentBarItem9;
        private Tools.XPMenus.BarItem barItem26;
        private Tools.XPMenus.BarItem barItem27;
        private Tools.XPMenus.BarItem barItem28;
        private StatusBarAdv statusBarAdv1;
        private StatusBarAdvPanel statusBarAdvPanel1;
        private GradientPanel gradientPanel1;
		float fontSize = 0;
        private bool temp;
		#endregion

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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

        //Get and Load the images
#if NET9_0_OR_GREATER
        private static Image GetImage(string path)
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            if (asm != null && !string.IsNullOrEmpty(path))
                return Image.FromStream(asm.GetManifestResourceStream(path));
            return null;
        }

        private void LoadImages(ImageList imageList, string folder, int count)
        {
            imageList.ImageSize = new System.Drawing.Size(32, 32);
            for (int i = 1; i <= count; i++)
            {
                string imagePath = ($"Syncfusion.Windows.Forms.samples.HTMLUIExplorer.Images.{folder}.Image_{i}.png");
                imageList.Images.Add(GetImage(imagePath));
            }
        }
#endif

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.htmluiControl1 = new Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.panel3 = new System.Windows.Forms.Panel();
            this.xpToolBar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem9 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button12 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "HTMLUI Explorer");
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem10 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem11 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem12 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem13 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem14 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.parentBarItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
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
            this.parentBarItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem24 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem25 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem9 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem26 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem27 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem28 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.statusBarAdv1 = new Syncfusion.Windows.Forms.Tools.StatusBarAdv();
            this.statusBarAdvPanel1 = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            ((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdv1)).BeginInit();
            this.statusBarAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // htmluiControl1
            // 
            this.htmluiControl1.AllowDrop = true;
            this.htmluiControl1.AutoRunScripts = true;
            this.htmluiControl1.AutoScroll = true;
            this.htmluiControl1.AutoScrollMinSize = new System.Drawing.Size(683, 327);
            this.htmluiControl1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.htmluiControl1.DefaultFormat.BackgroundColor = System.Drawing.SystemColors.Control;
            this.htmluiControl1.DefaultFormat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.htmluiControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmluiControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.htmluiControl1.Location = new System.Drawing.Point(0, 0);
            this.htmluiControl1.Name = "htmluiControl1";
            this.htmluiControl1.Size = new System.Drawing.Size(700, 342);
            this.htmluiControl1.TabIndex = 0;
            this.htmluiControl1.Text = "htmluiControl1";
            this.htmluiControl1.DragDrop += new System.Windows.Forms.DragEventHandler(this.htmluiControl1_DragDrop);
            this.htmluiControl1.LoadFinished += new System.EventHandler(this.htmluiControl1_LoadFinished);
            this.htmluiControl1.DragEnter += new System.Windows.Forms.DragEventHandler(this.htmluiControl1_DragEnter);
            this.htmluiControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.htmluiControl1_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 92);
            this.panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.BeforeTouchSize = new System.Drawing.Size(539, 21);
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.Location = new System.Drawing.Point(72, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(539, 21);
            this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "http://www.Google.com/";
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.xpToolBar1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(699, 46);
            this.panel3.TabIndex = 3;
            // 
            // xpToolBar1
            // 
            this.xpToolBar1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.xpToolBar1.Bar.BarName = "";
            this.xpToolBar1.Bar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem5,
            this.barItem4,
            this.barItem6,
            this.barItem7,
            this.barItem8,
            this.barItem9});
            this.xpToolBar1.Bar.Manager = null;
            this.xpToolBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpToolBar1.Location = new System.Drawing.Point(0, 0);
            this.xpToolBar1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.xpToolBar1.Name = "xpToolBar1";
            this.xpToolBar1.Size = new System.Drawing.Size(699, 41);
            this.xpToolBar1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.xpToolBar1.TabIndex = 0;
            this.xpToolBar1.Text = "xpToolBar1";
            this.xpToolBar1.Click += new System.EventHandler(this.toolBar1_ButtonClick);
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem1.ID = "back";
            this.barItem1.ImageIndex = 4;
            this.barItem1.ImageList = this.imageList1;
            this.barItem1.ShowToolTipInPopUp = false;
            this.barItem1.SizeToFit = true;
            this.barItem1.Text = "Back";
            this.barItem1.Tooltip = "Back";
            this.barItem1.Click += new System.EventHandler(this.barItem1_Click);
            // 
            // imageList1
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.imageList1, "ImageList1", 11);
#else
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
#endif
            this.imageList1.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(229)))), ((int)(((byte)(245)))));
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
            // 
            // barItem2
            // 
            this.barItem2.BarName = "barItem2";
            this.barItem2.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem2.ID = "Forward";
            this.barItem2.ImageIndex = 3;
            this.barItem2.ImageList = this.imageList1;
            this.barItem2.ShowToolTipInPopUp = false;
            this.barItem2.SizeToFit = true;
            this.barItem2.Text = "Forward";
            this.barItem2.Tooltip = "Forward";
            this.barItem2.Click += new System.EventHandler(this.barItem2_Click);
            // 
            // barItem3
            // 
            this.barItem3.BarName = "barItem3";
            this.barItem3.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem3.ID = "Stop";
            this.barItem3.ImageIndex = 9;
            this.barItem3.ImageList = this.imageList1;
            this.barItem3.ShowToolTipInPopUp = false;
            this.barItem3.SizeToFit = true;
            this.barItem3.Text = "Stop";
            this.barItem3.Tooltip = "Stop";
            this.barItem3.Click += new System.EventHandler(this.barItem3_Click);
            // 
            // barItem5
            // 
            this.barItem5.BarName = "barItem5";
            this.barItem5.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem5.ID = "Copy";
            this.barItem5.ImageIndex = 10;
            this.barItem5.ImageList = this.imageList1;
            this.barItem5.ShowToolTipInPopUp = false;
            this.barItem5.SizeToFit = true;
            this.barItem5.Text = "Copy";
            this.barItem5.Tooltip = "Copy to ClipBoard";
            this.barItem5.Click += new System.EventHandler(this.barItem5_Click);
            // 
            // barItem4
            // 
            this.barItem4.BarName = "barItem4";
            this.barItem4.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem4.ID = "Refresh";
            this.barItem4.ImageIndex = 6;
            this.barItem4.ImageList = this.imageList1;
            this.barItem4.ShowToolTipInPopUp = false;
            this.barItem4.SizeToFit = true;
            this.barItem4.Text = "Refresh";
            this.barItem4.Tooltip = "Refresh";
            this.barItem4.Click += new System.EventHandler(this.barItem4_Click);
            // 
            // barItem6
            // 
            this.barItem6.BarName = "barItem6";
            this.barItem6.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem6.ID = "Home";
            this.barItem6.ImageIndex = 2;
            this.barItem6.ImageList = this.imageList1;
            this.barItem6.ShowToolTipInPopUp = false;
            this.barItem6.SizeToFit = true;
            this.barItem6.Text = "Home";
            this.barItem6.Tooltip = "Home";
            this.barItem6.Click += new System.EventHandler(this.barItem6_Click);
            // 
            // barItem7
            // 
            this.barItem7.BarName = "barItem7";
            this.barItem7.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem7.ID = "Search";
            this.barItem7.ImageIndex = 7;
            this.barItem7.ImageList = this.imageList1;
            this.barItem7.ShowToolTipInPopUp = false;
            this.barItem7.SizeToFit = true;
            this.barItem7.Text = "Search";
            this.barItem7.Tooltip = "Search";
            this.barItem7.Click += new System.EventHandler(this.barItem7_Click);
            // 
            // barItem8
            // 
            this.barItem8.BarName = "barItem8";
            this.barItem8.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem8.ID = "Open";
            this.barItem8.ImageIndex = 0;
            this.barItem8.ImageList = this.imageList1;
            this.barItem8.ShowToolTipInPopUp = false;
            this.barItem8.SizeToFit = true;
            this.barItem8.Text = "Open";
            this.barItem8.Tooltip = "Open in Default Browser";
            this.barItem8.Click += new System.EventHandler(this.barItem8_Click);
            // 
            // barItem9
            // 
            this.barItem9.BarName = "barItem9";
            this.barItem9.CustomTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barItem9.ID = "Print";
            this.barItem9.ImageIndex = 5;
            this.barItem9.ImageList = this.imageList1;
            this.barItem9.ShowToolTipInPopUp = false;
            this.barItem9.SizeToFit = true;
            this.barItem9.Text = "Print";
            this.barItem9.Tooltip = "Print";
            this.barItem9.Click += new System.EventHandler(this.barItem9_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Address";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(30, 25);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IsBackStageButton = false;
            this.button1.Location = new System.Drawing.Point(619, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "...";
            this.button1.UseVisualStyle = true;
            this.button1.UseVisualStyleBackColor = false;
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.button1, "Browse the htm or html files");
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button12.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.BeforeTouchSize = new System.Drawing.Size(32, 28);
            this.button12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(229)))), ((int)(((byte)(245)))));
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.IsBackStageButton = false;
            this.button12.Location = new System.Drawing.Point(657, 53);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(32, 28);
            this.button12.TabIndex = 2;
            this.button12.UseVisualStyle = true;
            this.button12.UseVisualStyleBackColor = false;
            ToolTip ToolTip2 = new ToolTip();
            ToolTip2.SetToolTip(this.button12, "Go to");
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // mainFrameBarManager1
            // 
#if !NETCORE
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
#endif
            this.mainFrameBarManager1.Bars.Add(this.bar1);
            this.mainFrameBarManager1.Categories.Add("File");
            this.mainFrameBarManager1.Categories.Add("Edit");
            this.mainFrameBarManager1.Categories.Add("Format");
            this.mainFrameBarManager1.Categories.Add("Options");
            this.mainFrameBarManager1.Categories.Add("View");
            this.mainFrameBarManager1.Categories.Add("Help");
            this.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.MetroForm";
            this.mainFrameBarManager1.EnableMenuMerge = true;
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.barItem10,
            this.barItem11,
            this.barItem12,
            this.barItem13,
            this.parentBarItem2,
            this.barItem14,
            this.parentBarItem3,
            this.parentBarItem4,
            this.parentBarItem5,
            this.barItem15,
            this.barItem16,
            this.barItem17,
            this.barItem18,
            this.parentBarItem6,
            this.barItem19,
            this.barItem20,
            this.barItem21,
            this.barItem22,
            this.parentBarItem7,
            this.barItem23,
            this.parentBarItem8,
            this.barItem24,
            this.barItem25,
            this.parentBarItem9,
            this.barItem26,
            this.barItem27,
            this.barItem28});
            this.mainFrameBarManager1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.mainFrameBarManager1.UseBackwardCompatiblity = false;
            // 
            // bar1
            // 
            this.bar1.BarName = "HTMLUI Explorer";
            this.bar1.Caption = "HTMLUI Explorer";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.parentBarItem2,
            this.parentBarItem3,
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
            this.barItem10,
            this.barItem11,
            this.barItem12,
            this.barItem13});
            this.parentBarItem1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.Text = "File";
            this.parentBarItem1.WrapLength = 20;
            // 
            // barItem10
            // 
            this.barItem10.BarName = "barItem10";
            this.barItem10.CategoryIndex = 0;
            this.barItem10.ID = "Load From File";
            this.barItem10.ShowToolTipInPopUp = false;
            this.barItem10.SizeToFit = true;
            this.barItem10.Text = "Load From File";
            this.barItem10.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // barItem11
            // 
            this.barItem11.BarName = "barItem11";
            this.barItem11.CategoryIndex = 0;
            this.barItem11.ID = "Print Preview";
            this.barItem11.ShowToolTipInPopUp = false;
            this.barItem11.SizeToFit = true;
            this.barItem11.Text = "Print Preview";
            this.barItem11.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // barItem12
            // 
            this.barItem12.BarName = "barItem12";
            this.barItem12.CategoryIndex = 0;
            this.barItem12.ID = "Print";
            this.barItem12.ShowToolTipInPopUp = false;
            this.barItem12.SizeToFit = true;
            this.barItem12.Text = "Print";
            this.barItem12.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // barItem13
            // 
            this.barItem13.BarName = "barItem13";
            this.barItem13.CategoryIndex = 0;
            this.barItem13.ID = "Exit";
            this.barItem13.ShowToolTipInPopUp = false;
            this.barItem13.SizeToFit = true;
            this.barItem13.Text = "Exit";
            this.barItem13.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.BarName = "parentBarItem2";
            this.parentBarItem2.CategoryIndex = 1;
            this.parentBarItem2.ID = "Edit";
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem14});
            this.parentBarItem2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem2.ShowToolTipInPopUp = false;
            this.parentBarItem2.SizeToFit = true;
            this.parentBarItem2.Text = "Edit";
            this.parentBarItem2.WrapLength = 20;
            // 
            // barItem14
            // 
            this.barItem14.BarName = "barItem14";
            this.barItem14.CategoryIndex = 1;
            this.barItem14.ID = "Copy Selected Text";
            this.barItem14.ShowToolTipInPopUp = false;
            this.barItem14.SizeToFit = true;
            this.barItem14.Text = "Copy Selected Text";
            this.barItem14.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // parentBarItem3
            // 
            this.parentBarItem3.BarName = "parentBarItem3";
            this.parentBarItem3.CategoryIndex = 2;
            this.parentBarItem3.ID = "Format";
            this.parentBarItem3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem4});
            this.parentBarItem3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem3.ShowToolTipInPopUp = false;
            this.parentBarItem3.SizeToFit = true;
            this.parentBarItem3.Text = "Format";
            this.parentBarItem3.WrapLength = 20;
            // 
            // parentBarItem4
            // 
            this.parentBarItem4.BarName = "parentBarItem4";
            this.parentBarItem4.CategoryIndex = 2;
            this.parentBarItem4.ID = "Font";
            this.parentBarItem4.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem5,
            this.parentBarItem6});
            this.parentBarItem4.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem4.ShowToolTipInPopUp = false;
            this.parentBarItem4.SizeToFit = true;
            this.parentBarItem4.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem4.Text = "Font";
            this.parentBarItem4.WrapLength = 20;
            // 
            // parentBarItem5
            // 
            this.parentBarItem5.BarName = "parentBarItem5";
            this.parentBarItem5.CategoryIndex = 2;
            this.parentBarItem5.ID = "Face";
            this.parentBarItem5.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem15,
            this.barItem16,
            this.barItem17,
            this.barItem18});
            this.parentBarItem5.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem5.ShowToolTipInPopUp = false;
            this.parentBarItem5.SizeToFit = true;
            this.parentBarItem5.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem5.Text = "Face";
            this.parentBarItem5.WrapLength = 20;
            // 
            // barItem15
            // 
            this.barItem15.BarName = "barItem15";
            this.barItem15.CategoryIndex = 2;
            this.barItem15.ID = "Arial";
            this.barItem15.ShowToolTipInPopUp = false;
            this.barItem15.SizeToFit = true;
            this.barItem15.Text = "Arial";
            this.barItem15.Click += new System.EventHandler(this.menuItem17_Click);
            // 
            // barItem16
            // 
            this.barItem16.BarName = "barItem16";
            this.barItem16.CategoryIndex = 2;
            this.barItem16.ID = "Courier New";
            this.barItem16.ShowToolTipInPopUp = false;
            this.barItem16.SizeToFit = true;
            this.barItem16.Text = "Courier New";
            this.barItem16.Click += new System.EventHandler(this.menuItem18_Click);
            // 
            // barItem17
            // 
            this.barItem17.BarName = "barItem17";
            this.barItem17.CategoryIndex = 2;
            this.barItem17.ID = "Century Gothic";
            this.barItem17.ShowToolTipInPopUp = false;
            this.barItem17.SizeToFit = true;
            this.barItem17.Text = "Century Gothic";
            this.barItem17.Click += new System.EventHandler(this.menuItem19_Click);
            // 
            // barItem18
            // 
            this.barItem18.BarName = "barItem18";
            this.barItem18.CategoryIndex = 2;
            this.barItem18.ID = "Tahoma";
            this.barItem18.ShowToolTipInPopUp = false;
            this.barItem18.SizeToFit = true;
            this.barItem18.Text = "Tahoma";
            this.barItem18.Click += new System.EventHandler(this.menuItem24_Click);
            // 
            // parentBarItem6
            // 
            this.parentBarItem6.BarName = "parentBarItem6";
            this.parentBarItem6.CategoryIndex = 2;
            this.parentBarItem6.ID = "Size";
            this.parentBarItem6.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem19,
            this.barItem20,
            this.barItem21,
            this.barItem22});
            this.parentBarItem6.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem6.ShowToolTipInPopUp = false;
            this.parentBarItem6.SizeToFit = true;
            this.parentBarItem6.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem6.Text = "Size";
            this.parentBarItem6.WrapLength = 20;
            // 
            // barItem19
            // 
            this.barItem19.BarName = "barItem19";
            this.barItem19.CategoryIndex = 2;
            this.barItem19.ID = "Default";
            this.barItem19.ShowToolTipInPopUp = false;
            this.barItem19.SizeToFit = true;
            this.barItem19.Text = "Default";
            this.barItem19.Click += new System.EventHandler(this.menuItem20_Click);
            // 
            // barItem20
            // 
            this.barItem20.BarName = "barItem20";
            this.barItem20.CategoryIndex = 2;
            this.barItem20.ID = "Large";
            this.barItem20.ShowToolTipInPopUp = false;
            this.barItem20.SizeToFit = true;
            this.barItem20.Text = "Large";
            // 
            // barItem21
            // 
            this.barItem21.BarName = "barItem21";
            this.barItem21.CategoryIndex = 2;
            this.barItem21.ID = "Medium";
            this.barItem21.ShowToolTipInPopUp = false;
            this.barItem21.SizeToFit = true;
            this.barItem21.Text = "Medium";
            this.barItem21.Click += new System.EventHandler(this.menuItem22_Click);
            // 
            // barItem22
            // 
            this.barItem22.BarName = "barItem22";
            this.barItem22.CategoryIndex = 2;
            this.barItem22.ID = "Small";
            this.barItem22.ShowToolTipInPopUp = false;
            this.barItem22.SizeToFit = true;
            this.barItem22.Text = "Small";
            this.barItem22.Click += new System.EventHandler(this.menuItem23_Click);
            // 
            // parentBarItem7
            // 
            this.parentBarItem7.BarName = "parentBarItem7";
            this.parentBarItem7.CategoryIndex = 3;
            this.parentBarItem7.ID = "Option";
            this.parentBarItem7.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem23});
            this.parentBarItem7.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem7.ShowToolTipInPopUp = false;
            this.parentBarItem7.SizeToFit = true;
            this.parentBarItem7.Text = "Option";
            this.parentBarItem7.WrapLength = 20;
            // 
            // barItem23
            // 
            this.barItem23.BarName = "barItem23";
            this.barItem23.CategoryIndex = 3;
            this.barItem23.ID = "Set Current Page As My Home Page";
            this.barItem23.ShowToolTipInPopUp = false;
            this.barItem23.SizeToFit = true;
            this.barItem23.Text = "Set Current Page As My Home Page";
            // 
            // parentBarItem8
            // 
            this.parentBarItem8.BarName = "parentBarItem8";
            this.parentBarItem8.CategoryIndex = 4;
            this.parentBarItem8.ID = "View";
            this.parentBarItem8.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem24,
            this.barItem25});
            this.parentBarItem8.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem8.ShowToolTipInPopUp = false;
            this.parentBarItem8.SizeToFit = true;
            this.parentBarItem8.Text = "View";
            this.parentBarItem8.WrapLength = 20;
            // 
            // barItem24
            // 
            this.barItem24.BarName = "barItem24";
            this.barItem24.CategoryIndex = 4;
            this.barItem24.ID = "View HTML";
            this.barItem24.ShowToolTipInPopUp = false;
            this.barItem24.SizeToFit = true;
            this.barItem24.Text = "View HTML";
            // 
            // barItem25
            // 
            this.barItem25.BarName = "barItem25";
            this.barItem25.CategoryIndex = 4;
            this.barItem25.ID = "View XML";
            this.barItem25.ShowToolTipInPopUp = false;
            this.barItem25.SizeToFit = true;
            this.barItem25.Text = "View XML";
            // 
            // parentBarItem9
            // 
            this.parentBarItem9.BarName = "parentBarItem9";
            this.parentBarItem9.CategoryIndex = 5;
            this.parentBarItem9.ID = "Help";
            this.parentBarItem9.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem26,
            this.barItem27,
            this.barItem28});
            this.parentBarItem9.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem9.ShowToolTipInPopUp = false;
            this.parentBarItem9.SizeToFit = true;
            this.parentBarItem9.Text = "Help";
            this.parentBarItem9.WrapLength = 20;
            // 
            // barItem26
            // 
            this.barItem26.BarName = "barItem26";
            this.barItem26.CategoryIndex = 5;
            this.barItem26.ID = "Knowledge Base";
            this.barItem26.ShowToolTipInPopUp = false;
            this.barItem26.SizeToFit = true;
            this.barItem26.Text = "Knowledge Base";
            // 
            // barItem27
            // 
            this.barItem27.BarName = "barItem27";
            this.barItem27.CategoryIndex = 5;
            this.barItem27.ID = "About HTMLUI";
            this.barItem27.ShowToolTipInPopUp = false;
            this.barItem27.SizeToFit = true;
            this.barItem27.Text = "About HTMLUI";
            // 
            // barItem28
            // 
            this.barItem28.BarName = "barItem28";
            this.barItem28.CategoryIndex = 5;
            this.barItem28.ID = "About Syncfusion";
            this.barItem28.ShowToolTipInPopUp = false;
            this.barItem28.SizeToFit = true;
            this.barItem28.Text = "About Syncfusion";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel1.Controls.Add(this.htmluiControl1);
            this.gradientPanel1.Location = new System.Drawing.Point(0, 133);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(700, 342);
            this.gradientPanel1.TabIndex = 4;
            // 
            // statusBarAdv1
            // 
            this.statusBarAdv1.BeforeTouchSize = new System.Drawing.Size(701, 35);
            this.statusBarAdv1.BorderColor = System.Drawing.Color.Silver;
            this.statusBarAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusBarAdv1.Controls.Add(this.statusBarAdvPanel1);
            this.statusBarAdv1.CustomLayoutBounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.statusBarAdv1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBarAdv1.Location = new System.Drawing.Point(0, 485);
            this.statusBarAdv1.Name = "statusBarAdv1";
            this.statusBarAdv1.Padding = new System.Windows.Forms.Padding(3);
            this.statusBarAdv1.Size = new System.Drawing.Size(701, 35);
            this.statusBarAdv1.Spacing = new System.Drawing.Size(2, 2);
            this.statusBarAdv1.TabIndex = 5;
            // 
            // statusBarAdvPanel1
            // 
            this.statusBarAdvPanel1.BeforeTouchSize = new System.Drawing.Size(71, 29);
            this.statusBarAdvPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusBarAdvPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBarAdvPanel1.ForeColor = System.Drawing.Color.Black;
            this.statusBarAdvPanel1.Location = new System.Drawing.Point(0, 2);
            this.statusBarAdvPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.statusBarAdvPanel1.Name = "statusBarAdvPanel1";
            this.statusBarAdvPanel1.Size = new System.Drawing.Size(71, 29);
            this.statusBarAdvPanel1.TabIndex = 0;
            this.statusBarAdvPanel1.Text = "Loading . . .";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(701, 520);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusBarAdv1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(229)))), ((int)(((byte)(245)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(713, 556);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTMLUI Explorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdv1)).EndInit();
            this.statusBarAdv1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel1)).EndInit();
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
            Application.Run(new Form1());
		}

		#region ClassHelperEvents
		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.htmluiControl1.LoadFromString("<body bgcolor=#ffffff></body>");
			this.DftfontSize = this.htmluiControl1.DefaultFormat.Font.Size;
			this.fontSize = this.DftfontSize;
		}

		private void htmluiControl1_LoadFinished(object sender, System.EventArgs e)
		{
			pd = new HTMLUIPrintDocument( this.htmluiControl1.Document );
			this.htmluiControl1.Cursor = Cursors.Default;
			if(this.htmluiControl1.Document.IsFileName == true)
			{
				this.comboBox1.Text = this.htmluiControl1.Document.FileName.ToString();
				Console.WriteLine("File Loaded from drive: "+ this.htmluiControl1.Document.FileName.ToString());
			}
			if(this.htmluiControl1.Document.IsUri == true)
			{
				this.comboBox1.Text = this.htmluiControl1.Document.Uri.ToString();
				Console.WriteLine("File Loaded from URI: "+ this.htmluiControl1.Document.Uri.ToString());
			}
			this.htmluiControl1.DefaultFormat.Cursor = Cursors.IBeam;
		}
		#endregion

		#region UI Events

		private void htmluiControl1_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if(e.Data.GetDataPresent (DataFormats.FileDrop)) 
				e.Effect = DragDropEffects.All;
			else 
				e.Effect = DragDropEffects.None;		
		}

		private void htmluiControl1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			string[] files = (string[])e.Data.GetData("FileDrop", false); 

			foreach (string fileName in files) 
			{ 
				this.htmluiControl1.LoadHTML(fileName);
			}
		}

		private void htmluiControl1_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.Alt == true && e.KeyCode == Keys.F4)
			{
				ExitApplication();
			}
		}

		private void comboBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				LoadDocument();
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Uri uri = new Uri(this.comboBox1.SelectedItem.ToString());
			this.htmluiControl1.LoadHTML(uri);
			this.htmluiControl1.Refresh();
		}

		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
		{
			if(Convert.ToInt32(e.ClickedItem.Tag) == 1)
			{
				this.htmluiControl1.Back(-1);
				this.htmluiControl1.Refresh();
			}
			
			if(Convert.ToInt32(e.ClickedItem.Tag) == 2)
			{
				
			}

			if(Convert.ToInt32(e.ClickedItem.Tag) == 3)
			{
				
			}

			if(Convert.ToInt32(e.ClickedItem.Tag) == 4)
			{
				
			}

			if(Convert.ToInt32(e.ClickedItem.Tag) == 6)
			{
				this.htmluiControl1.Refresh();
			}

			if(Convert.ToInt32(e.ClickedItem.Tag) == 7)
			{
				try
				{
					if(this.homeLocation == "")
					{
						this.htmluiControl1.LoadHTML(this.home);
						this.comboBox1.Text = this.htmluiControl1.Document.Uri.ToString();
					}
					else
					{
						this.htmluiControl1.LoadHTML(this.homeLocation);
						this.comboBox1.Text = this.htmluiControl1.Document.FileName.ToString();
					}
				}
				catch(Exception)
				{
					MessageBox.Show("Please set your Home page from the options menu before using this option.");
				}
			}

			if(Convert.ToInt32(e.ClickedItem.Tag) == 8)
			{
				
			}

			if(Convert.ToInt32(e.ClickedItem.Tag) == 9)
			{
				
			}

			if(Convert.ToInt32(e.ClickedItem.Tag) == 10)
			{
				PrintDocument();
			}
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			this.openFileDialog1.Filter = "htm files(*.htm)|*.htm|html files(*.html)|*.html|mht files(*.mht)|*.mht";
			if (LoadTheHTML() && this.comboBox1.Text != "")
			{
				this.htmluiControl1.LoadHTML(this.comboBox1.Text);
				this.htmluiControl1.Cursor = Cursors.Arrow;
			}
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			ExitApplication();
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			PrintPreview();
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			PrintDocument();
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			CopyText();
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			if(this.comboBox1.Text != "")
			{
				if(this.htmluiControl1.Document.IsFileName == true)
				{
					this.homeLocation = this.htmluiControl1.Document.FileName.ToString();
				}
				if(this.htmluiControl1.Document.IsUri == true)
				{
					this.home = this.htmluiControl1.Document.Uri;
				}
			}
			else
			{
				MessageBox.Show("Load the page to use it as your home page.");
			}
		}


		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(this.htmluiControl1.Text);
		}

		private void menuItem12_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(this.htmluiControl1.Document.Document.OuterXml.ToString());
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.openFileDialog1.Filter = "htm files(*.htm)|*.htm|html files(*.html)|*.html";
			LoadTheHTML();
			LoadDocument();
		}

		private void button12_Click(object sender, System.EventArgs e)
		{
			LoadDocument();
            temp = true;
		}

		private void menuItem17_Click(object sender, System.EventArgs e)
		{
            if(temp==false)
            this.htmluiControl1.DefaultFormat.Font = new Font("Arial", this.fontSize);
		}

		private void menuItem18_Click(object sender, System.EventArgs e)
		{
            if (temp == false)
			this.htmluiControl1.DefaultFormat.Font = new Font("Courier New", this.fontSize);
		}

		private void menuItem19_Click(object sender, System.EventArgs e)
		{
            if (temp == false)
			this.htmluiControl1.DefaultFormat.Font = new Font("Century Gothic", this.fontSize);
		}

		private void menuItem20_Click(object sender, System.EventArgs e)
		{
            if (temp == false)
            {
                this.fontSize = this.DftfontSize;
                ChangeFontSize();
            }
		}

		private void menuItem21_Click(object sender, System.EventArgs e)
		{
            if (temp == false)
            {
                this.fontSize = (this.DftfontSize + 7);
                ChangeFontSize();
            }
		}

		private void menuItem22_Click(object sender, System.EventArgs e)
		{
            if (temp == false)
            {
                this.fontSize = (this.DftfontSize + 3);
                ChangeFontSize();
            }
		}

		private void menuItem23_Click(object sender, System.EventArgs e)
		{
            if (temp == false)
            {
                if ((this.DftfontSize - 3) > 0)
                {
                    this.fontSize = (this.DftfontSize - 3);
                    ChangeFontSize();
                }
                else
                {
                    MessageBox.Show("Font size cannot be less than or equal to zero");
                }
            }
		}

		private void menuItem24_Click(object sender, System.EventArgs e)
		{
            if (temp == false)
			this.htmluiControl1.DefaultFormat.Font = new Font("Tahoma", this.fontSize);
		}

		

		private void menuItem26_Click(object sender, System.EventArgs e)
		{
			Process process = Process.Start("http://www.syncfusion.com/support/kb/htmlui/Default.aspx");
		}

		private void menuItem28_Click(object sender, System.EventArgs e)
		{
			Process process = Process.Start("http://www.syncfusion.com/Products/product.aspx?p=25&tab_id=0");
		}

		private void menuItem27_Click(object sender, System.EventArgs e)
		{
			Process process = Process.Start("http://www.syncfusion.com/default.aspx");
		}

		#endregion

		#region UI methods
		private bool LoadTheHTML()
		{
			bool result = false;
			if(this.openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				if(this.openFileDialog1.FileName != "")
				{
					this.comboBox1.Text = this.openFileDialog1.FileName;
					this.htmluiControl1.Cursor = Cursors.Arrow;

					result = true;
				}
			}
			else
			{
				this.htmluiControl1.Cursor = Cursors.Arrow;
				this.htmluiControl1.Refresh();

				result = false;
			}
			return result;
		}

		private void LoadDocument()
		{
			this.htmluiControl1.Cursor = Cursors.WaitCursor;
			if(comboBox1.Text != "")
			{
				Console.WriteLine("Loading the Specified URI...");
				try
				{
					Uri uri = new Uri(this.comboBox1.Text);
					this.htmluiControl1.LoadHTML(uri);
					this.htmluiControl1.Cursor = Cursors.Arrow;
				}
				catch(Exception exc)
				{
					MessageBox.Show(exc.ToString());
				}
			}
			else
			{
				Console.WriteLine("Uri is Empty");
				this.htmluiControl1.Cursor = Cursors.Arrow;
			}
			this.comboBox1.Items.Add(this.comboBox1.Text.ToString());
		}

		private void CopyText()
		{
			this.selectedText = this.htmluiControl1.SelectedText.ToString();
			if(this.selectedText != "")
			{
				Clipboard.SetDataObject(this.selectedText, true);
			}
			else
			{
				Console.WriteLine("Please select some text");
			}
		}

		private void ChangeFontSize()
		{
			try
			{
				this.htmluiControl1.DefaultFormat.Font = new Font(this.htmluiControl1.DefaultFormat.Font.FontFamily, this.fontSize);
			}
			catch(Exception exc)
			{
				MessageBox.Show(exc.ToString());
			}
		}

		private void PrintDocument()
		{
			if(this.htmluiControl1.Document.Document.OuterXml != "")
			{
				PrintDialog dg = new PrintDialog();
				dg.AllowSomePages = true;
				dg.Document = pd;
				if(dg.ShowDialog() == DialogResult.OK)
					pd.Print();
			}

			else
			{
				Console.WriteLine("The current document is not valid for printing");
			}
		}

		private void PrintPreview()
		{
			PrintPreviewDialog dlg = new PrintPreviewDialog() ;
			dlg.Document = pd;
			dlg.ShowDialog();
		}

		private void ExitApplication()
		{
			Application.Exit();
		}
		#endregion

        private void toolBar1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void barItem1_Click(object sender, EventArgs e)
        {
            this.htmluiControl1.Back(-1);
            this.htmluiControl1.Refresh();
        }

        private void barItem2_Click(object sender, EventArgs e)
        {
            this.htmluiControl1.Forward(1);
            this.htmluiControl1.Refresh();
        }

        private void barItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barItem5_Click(object sender, EventArgs e)
        {
            CopyText();
        }

        private void barItem4_Click(object sender, EventArgs e)
        {
            this.htmluiControl1.Refresh();
        }

        private void barItem6_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.homeLocation == "")
                {
                    this.htmluiControl1.LoadHTML(this.home);
                    this.comboBox1.Text = this.htmluiControl1.Document.Uri.ToString();
                }
                else
                {
                    this.htmluiControl1.LoadHTML(this.homeLocation);
                    this.comboBox1.Text = this.htmluiControl1.Document.FileName.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please set your Home page from the options menu before using this option.");
            }
        }

        private void barItem7_Click(object sender, EventArgs e)
        {
            this.htmluiControl1.DisplayFindForm();
        }

        private void barItem8_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.Text != "")
            {
#if NETCORE
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = this.comboBox1.Text.ToString(),
                    UseShellExecute = true
                };
                Process.Start(psi);
#else
                Process process = Process.Start(this.comboBox1.Text.ToString());
#endif
            }
            else
            {
                Console.WriteLine("Please enter your file name in the text box.");
            }
        }

        private void barItem9_Click(object sender, EventArgs e)
        {
            PrintDocument();
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