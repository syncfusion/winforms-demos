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
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;

using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Licensing;
using System.IO;

namespace TaskBar
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
    {
        #region Private Members
        private TaskBar.GradientTaskBar xpTaskBar1;
        private Syncfusion.Windows.Forms.Tools.XPTaskBarBox xpTaskBarBox1;
        private Syncfusion.Windows.Forms.Tools.XPTaskBarBox xpTaskBarBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ImageList imageList2;
        private TabControlAdv tabControlAdv1;
        private TabPageAdv tabPageAdv1;
        private TabPageAdv tabPageAdv2;
        private XPTaskBar xpTaskBarStyles;
        private StyleTaskBox xpTaskBarBox3;
        private StyleTaskBox xpTaskBarBox4;
        private StyleTaskBox xpTaskBarBox5;
        private Label label2;
		private System.ComponentModel.IContainer components;
#endregion

        #region Form's constructor, Main and Dispose
        public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            this.xpTaskBarBox3.ItemBackColor = Color.White;
            this.xpTaskBarBox4.ItemBackColor = Color.White;
            this.xpTaskBarBox5.ItemBackColor = Color.White;
            this.MinimumSize = this.Size;          
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }


			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.Run(new Form1());
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
        #endregion

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
            if (folder == "ImageList2")
            {
                imageList.ImageSize = new System.Drawing.Size(32, 32);
            }
            for (int i = 1; i <= count; i++)
            {
                string imagePath = ($"TaskBar.Images.{folder}.Image_{i}.png");
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
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.xpTaskBar1 = new TaskBar.GradientTaskBar(this.components);
            this.xpTaskBarBox1 = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.xpTaskBarBox2 = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.xpTaskBarStyles = new Syncfusion.Windows.Forms.Tools.XPTaskBar();
            this.xpTaskBarBox3 = new TaskBar.StyleTaskBox();
            this.xpTaskBarBox4 = new TaskBar.StyleTaskBox();
            this.xpTaskBarBox5 = new TaskBar.StyleTaskBox();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar1)).BeginInit();
            this.xpTaskBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            this.tabPageAdv2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBarStyles)).BeginInit();
            this.xpTaskBarStyles.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList2
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.imageList2, "ImageList2", 2);
#else
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
#endif
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "");
            this.imageList2.Images.SetKeyName(1, "");
            // 
            // imageList1
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.imageList1, "ImageList1", 5);
#else
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
#endif
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            // 
            // xpTaskBar1
            // 
            this.xpTaskBar1.AutoScroll = true;
            this.xpTaskBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(78)))), ((int)(((byte)(129)))));
            this.xpTaskBar1.BlendImage = ((System.Drawing.Image)(resources.GetObject("xpTaskBar1.BlendImage")));
            this.xpTaskBar1.BorderColor = System.Drawing.Color.Black;
            this.xpTaskBar1.Controls.Add(this.xpTaskBarBox1);
            this.xpTaskBar1.Controls.Add(this.xpTaskBarBox2);
            this.xpTaskBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.xpTaskBar1.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(78)))), ((int)(((byte)(129)))));
            this.xpTaskBar1.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.xpTaskBar1.HeaderImageList = this.imageList2;
            this.xpTaskBar1.Location = new System.Drawing.Point(280, 0);
            this.xpTaskBar1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.xpTaskBar1.MinimumSize = new System.Drawing.Size(0, 0);
            this.xpTaskBar1.Name = "xpTaskBar1";
            this.xpTaskBar1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.xpTaskBar1.Size = new System.Drawing.Size(240, 400);
            this.xpTaskBar1.TabIndex = 0;
            // 
            // xpTaskBarBox1
            // 
            this.xpTaskBarBox1.BackColor = System.Drawing.Color.Transparent;
            this.xpTaskBarBox1.DrawFocusRect = false;
            this.xpTaskBarBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xpTaskBarBox1.ForeColor = System.Drawing.Color.White;
            this.xpTaskBarBox1.HeaderBackColor = System.Drawing.Color.Transparent;
            this.xpTaskBarBox1.HeaderForeColor = System.Drawing.Color.White;
            this.xpTaskBarBox1.HeaderImageIndex = 0;
            this.xpTaskBarBox1.HeaderImageList = this.imageList2;
            this.xpTaskBarBox1.HitTaskBoxArea = false;
            this.xpTaskBarBox1.HotTrackColor = System.Drawing.Color.Empty;
            this.xpTaskBarBox1.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.xpTaskBarBox1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPTaskBarItem[] {
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Item 1", System.Drawing.Color.Black, -1, null, null, true, true, "", new System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Item2", System.Drawing.Color.Black, -1, null, null, true, true, "", new System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Item 3", System.Drawing.Color.Black, -1, null, null, true, true, "", new System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Item 4", System.Drawing.Color.Black, -1, null, null, true, true, "", new System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Item 5", System.Drawing.Color.Black, -1, null, null, true, true, "", new System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Item 6", System.Drawing.Color.Black, -1, null, null, true, true, "", new System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0)});
            this.xpTaskBarBox1.Location = new System.Drawing.Point(10, 5);
            this.xpTaskBarBox1.Name = "xpTaskBarBox1";
            this.xpTaskBarBox1.Size = new System.Drawing.Size(220, 179);
            this.xpTaskBarBox1.TabIndex = 0;
            this.xpTaskBarBox1.Text = "Tasks";
            this.xpTaskBarBox1.ProvideHeaderBackgroundBrush += new Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(this.xpTaskBarBox1_ProvideHeaderBackgroundBrush);
            // 
            // xpTaskBarBox2
            // 
            this.xpTaskBarBox2.BackColor = System.Drawing.Color.Transparent;
            this.xpTaskBarBox2.ForeColor = System.Drawing.Color.White;
            this.xpTaskBarBox2.HeaderBackColor = System.Drawing.Color.Transparent;
            this.xpTaskBarBox2.HeaderForeColor = System.Drawing.Color.White;
            this.xpTaskBarBox2.HeaderImageIndex = 1;
            this.xpTaskBarBox2.HitTaskBoxArea = false;
            this.xpTaskBarBox2.HotTrackColor = System.Drawing.Color.Empty;
            this.xpTaskBarBox2.ImageList = this.imageList1;
            this.xpTaskBarBox2.ItemBackColor = System.Drawing.Color.Transparent;
            this.xpTaskBarBox2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPTaskBarItem[] {
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Canada", System.Drawing.Color.Empty, 0, null, null, true, true, "", new System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("France", System.Drawing.Color.Empty, 1, null, null, true, true, "", new System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Germany", System.Drawing.Color.Empty, 2, null, null, true, true, "", new System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("UK", System.Drawing.Color.Empty, 3, null, null, true, true, "", new System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("USA", System.Drawing.Color.Empty, 4, null, null, true, true, "", new System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0)});
            this.xpTaskBarBox2.Location = new System.Drawing.Point(10, 184);
            this.xpTaskBarBox2.Name = "xpTaskBarBox2";
            this.xpTaskBarBox2.Size = new System.Drawing.Size(220, 152);
            this.xpTaskBarBox2.TabIndex = 1;
            this.xpTaskBarBox2.Text = "Countries...";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 400);
            this.label1.TabIndex = 1;
            this.label1.Text = "MSN like TaskBar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabColor = System.Drawing.SystemColors.Highlight;
            this.tabControlAdv1.BackColor = System.Drawing.Color.White;
            this.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv1.FixedSingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.tabControlAdv1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tabControlAdv1.Location = new System.Drawing.Point(10, 10);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Size = new System.Drawing.Size(526, 427);
            this.tabControlAdv1.TabIndex = 2;
            this.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.White;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            this.tabControlAdv1.ThemesEnabled = true;
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(248)))));
            this.tabPageAdv1.Controls.Add(this.label1);
            this.tabPageAdv1.Controls.Add(this.xpTaskBar1);
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(3, 24);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(520, 400);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "MSN TaskBar";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(248)))));
            this.tabPageAdv2.Controls.Add(this.label2);
            this.tabPageAdv2.Controls.Add(this.xpTaskBarStyles);
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv2.Location = new System.Drawing.Point(3, 24);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(520, 400);
            this.tabPageAdv2.TabIndex = 2;
            this.tabPageAdv2.Text = "Custom TaskBar";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(250)))));
            this.label2.Location = new System.Drawing.Point(184, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 400);
            this.label2.TabIndex = 2;
            this.label2.Text = "Custom TaskBar ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xpTaskBarStyles
            // 
            this.xpTaskBarStyles.BackColor = System.Drawing.Color.White;
            this.xpTaskBarStyles.BorderColor = System.Drawing.Color.Black;
            this.xpTaskBarStyles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xpTaskBarStyles.Controls.Add(this.xpTaskBarBox3);
            this.xpTaskBarStyles.Controls.Add(this.xpTaskBarBox4);
            this.xpTaskBarStyles.Controls.Add(this.xpTaskBarBox5);
            this.xpTaskBarStyles.Dock = System.Windows.Forms.DockStyle.Left;
            this.xpTaskBarStyles.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xpTaskBarStyles.Location = new System.Drawing.Point(0, 0);
            this.xpTaskBarStyles.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.xpTaskBarStyles.MinimumSize = new System.Drawing.Size(0, 0);
            this.xpTaskBarStyles.Name = "xpTaskBarStyles";
            this.xpTaskBarStyles.Padding = new System.Windows.Forms.Padding(10, 15, 10, 0);
            this.xpTaskBarStyles.Size = new System.Drawing.Size(184, 400);
            this.xpTaskBarStyles.Style = Syncfusion.Windows.Forms.Tools.XPTaskBarStyle.Metro;
            this.xpTaskBarStyles.TabIndex = 3;
            this.xpTaskBarStyles.VerticalPadding = 15;
            // 
            // xpTaskBarBox3
            // 
            this.xpTaskBarBox3.DrawFocusRect = false;
            this.xpTaskBarBox3.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.xpTaskBarBox3.HeaderImageIndex = -1;
            this.xpTaskBarBox3.HitTaskBoxArea = false;
            this.xpTaskBarBox3.HotTrackColor = System.Drawing.Color.Empty;
            this.xpTaskBarBox3.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(187)))), ((int)(((byte)(240)))));
            this.xpTaskBarBox3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPTaskBarItem[] {
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Make a New Folder", System.Drawing.Color.Empty, -1, null, "", true, true, "XPTaskBarItem0", new System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Publish this Folder to the web", System.Drawing.Color.Empty, -1, null, "", true, true, "XPTaskBarItem1", new System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Copy", System.Drawing.Color.Empty, -1, null, "", true, true, "XPTaskBarItem6", new System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Paste", System.Drawing.Color.Empty, -1, null, "", true, true, "XPTaskBarItem7", new System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0)});
            this.xpTaskBarBox3.Location = new System.Drawing.Point(10, 15);
            this.xpTaskBarBox3.Name = "xpTaskBarBox3";
            this.xpTaskBarBox3.PADY = 2;
            this.xpTaskBarBox3.Size = new System.Drawing.Size(162, 99);
            this.xpTaskBarBox3.TabIndex = 0;
            this.xpTaskBarBox3.Text = "Files And Folder Task";
            this.xpTaskBarBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.xpTaskBarBox_Paint);
            // 
            // xpTaskBarBox4
            // 
            this.xpTaskBarBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(223)))), ((int)(((byte)(242)))));
            this.xpTaskBarBox4.DrawFocusRect = false;
            this.xpTaskBarBox4.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.xpTaskBarBox4.HeaderImageIndex = -1;
            this.xpTaskBarBox4.HitTaskBoxArea = false;
            this.xpTaskBarBox4.HotTrackColor = System.Drawing.Color.Empty;
            this.xpTaskBarBox4.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(187)))), ((int)(((byte)(240)))));
            this.xpTaskBarBox4.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPTaskBarItem[] {
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("My Documents", System.Drawing.Color.Empty, -1, null, "", true, true, "XPTaskBarItem2", new System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Desktop", System.Drawing.Color.Empty, -1, null, "", true, true, "XPTaskBarItem5", new System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("My Computer", System.Drawing.Color.Empty, -1, null, "", true, true, "XPTaskBarItem8", new System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("My Network Places", System.Drawing.Color.Empty, -1, null, "", true, true, "XPTaskBarItem9", new System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("My Music", System.Drawing.Color.Empty, -1, null, "", true, true, "XPTaskBarItem10", new System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0)});
            this.xpTaskBarBox4.Location = new System.Drawing.Point(10, 129);
            this.xpTaskBarBox4.Name = "xpTaskBarBox4";
            this.xpTaskBarBox4.PADY = 2;
            this.xpTaskBarBox4.Size = new System.Drawing.Size(162, 118);
            this.xpTaskBarBox4.TabIndex = 1;
            this.xpTaskBarBox4.Text = "Other Places";
            this.xpTaskBarBox4.Paint += new System.Windows.Forms.PaintEventHandler(this.xpTaskBarBox_Paint);
            // 
            // xpTaskBarBox5
            // 
            this.xpTaskBarBox5.DrawFocusRect = false;
            this.xpTaskBarBox5.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.xpTaskBarBox5.HeaderImageIndex = -1;
            this.xpTaskBarBox5.HitTaskBoxArea = false;
            this.xpTaskBarBox5.HotTrackColor = System.Drawing.Color.Empty;
            this.xpTaskBarBox5.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(187)))), ((int)(((byte)(240)))));
            this.xpTaskBarBox5.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPTaskBarItem[] {
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Cut", System.Drawing.Color.Empty, -1, null, "", true, true, "XPTaskBarItem3", new System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Copy", System.Drawing.Color.Empty, -1, null, "", true, true, "XPTaskBarItem4", new System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Paste", System.Drawing.Color.Empty, -1, null, "", true, true, "XPTaskBarItem11", new System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Delete", System.Drawing.Color.Empty, -1, null, "", true, true, "XPTaskBarItem12", new System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0)});
            this.xpTaskBarBox5.Location = new System.Drawing.Point(10, 262);
            this.xpTaskBarBox5.Name = "xpTaskBarBox5";
            this.xpTaskBarBox5.PADY = 2;
            this.xpTaskBarBox5.Size = new System.Drawing.Size(162, 99);
            this.xpTaskBarBox5.TabIndex = 2;
            this.xpTaskBarBox5.Text = "ClipBoard";
            this.xpTaskBarBox5.Paint += new System.Windows.Forms.PaintEventHandler(this.xpTaskBarBox_Paint);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientSize = new System.Drawing.Size(546, 447);
            this.Controls.Add(this.tabControlAdv1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MetroColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XpTaskBar";
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar1)).EndInit();
            this.xpTaskBar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.tabPageAdv2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBarStyles)).EndInit();
            this.xpTaskBarStyles.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        #region Events
        private void xpTaskBarBox1_ProvideHeaderBackgroundBrush(object sender, Syncfusion.Windows.Forms.Tools.ProvideBrushEventArgs args)
        {
            // Custom draw the background only when XP Themes is not available.
            if (!XPThemes.IsThemedOS || !XPThemes.IsThemeActive || !this.xpTaskBar1.ThemesEnabled)
            {
                // Blend settings
                float[] relativeIntensities = { 0.0f, 0.0f, 1.0f };
                float[] relativePositions = { 0.0F, 0.5f, 1.0F };
                Blend blend = new Blend();
                blend.Factors = relativeIntensities;
                blend.Positions = relativePositions;

                XPTaskBarBox box = sender as XPTaskBarBox;

                // Header back brush
                LinearGradientBrush lgBrush = new LinearGradientBrush(args.Bounds,
                    Color.FromArgb(132, 164, 193),
                    Color.FromArgb(46, 116, 163),
                    0, true);
                lgBrush.Blend = blend;
                args.Brush = lgBrush;
            }
		}
      

        private void xpTaskBarBox_Paint(object sender, PaintEventArgs e)
        {
            XPTaskBarBox xptBox = sender as XPTaskBarBox;
            Rectangle itemsRect = xptBox.GetItemsRect();
            itemsRect.Width -= 1;
            itemsRect.Height -= 1;
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(113, 137, 183), 3), itemsRect);

        }
        #endregion

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
