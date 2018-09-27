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

namespace SplashControlDemo
{
    using System;
    using System.Drawing;
    using System.Collections;
    using System.ComponentModel;
    using System.Windows.Forms;
    using System.Data;
    using Syncfusion.Windows.Forms.Tools;
    using Syncfusion.Windows.Forms;

    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class MainForm : MetroForm
	{
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button6;
		private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private System.Windows.Forms.ImageList imageList2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem2;
        private GradientPanel gradientPanel1;
        internal TextBoxExt textBox5;
		public Syncfusion.Windows.Forms.Tools.SplashControl splashControl1;


		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
               try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }

;

            this.mainFrameBarManager1.MainMenuBar.DrawBackground += new PaintEventHandler(MainMenuBar_DrawBackground);
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

        void MainMenuBar_DrawBackground(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White,e.ClipRectangle);
        }

		private void SplashClosedHandler(object sender, EventArgs e)
		{
			
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splashControl1 = new Syncfusion.Windows.Forms.Tools.SplashControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.textBox5 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "menu");
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            // 
            // splashControl1
            // 
            this.splashControl1.DesktopAlignment = Syncfusion.Windows.Forms.Tools.SplashAlignment.RightBottom;
            this.splashControl1.HostForm = this;
            this.splashControl1.SplashImage = ((System.Drawing.Image)(resources.GetObject("splashControl1.SplashImage")));
            this.splashControl1.TimerInterval = 3000;
            this.splashControl1.UseCustomSplashPanel = true;
            this.splashControl1.BeforeSplash += new System.ComponentModel.CancelEventHandler(this.splashControl1_BeforeSplash);
            this.splashControl1.SplashDisplayed += new System.EventHandler(this.splashControl1_SplashDisplayed);
            this.splashControl1.SplashClosed += new System.EventHandler(this.splashControl1_SplashClosed);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(222, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(219)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button6.ImageIndex = 2;
            this.button6.Location = new System.Drawing.Point(392, 334);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(151, 40);
            this.button6.TabIndex = 4;
            this.button6.Text = "Click to Show Splash Screen";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.BackColor = System.Drawing.Color.White;
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv1.ImageList = this.imageList2;
            this.tabControlAdv1.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Size = new System.Drawing.Size(857, 486);
            this.tabControlAdv1.TabIndex = 6;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            this.tabControlAdv1.SelectedIndexChanged += new System.EventHandler(this.tabControlAdv1_SelectedIndexChanged);
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.Controls.Add(this.textBox5);
            this.tabPageAdv1.Controls.Add(this.pictureBox1);
            this.tabPageAdv1.Controls.Add(this.button6);
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageIndex = 0;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(1, 25);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(854, 459);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "Show Splash";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // textBox5
            // 
            this.textBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(110)))), ((int)(((byte)(154)))));
            this.textBox5.Location = new System.Drawing.Point(10, 396);
            this.textBox5.Metrocolor = System.Drawing.Color.Empty;
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox5.Size = new System.Drawing.Size(834, 53);
            this.textBox5.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBox5.TabIndex = 4;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "");
            this.imageList2.Images.SetKeyName(1, "");
            // 
            // mainFrameBarManager1
            // 
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
            this.mainFrameBarManager1.Bars.Add(this.bar1);
            this.mainFrameBarManager1.Categories.Add("File");
            this.mainFrameBarManager1.Categories.Add("Help");
            this.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.MetroForm";
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.barItem1,
            this.parentBarItem2,
            this.barItem2});
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // bar1
            // 
            this.bar1.BarName = "menu";
            this.bar1.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu) 
            | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) 
            | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder)));
            this.bar1.Caption = "menu";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.parentBarItem2});
            this.bar1.Manager = this.mainFrameBarManager1;
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.BarName = "parentBarItem1";
            this.parentBarItem1.CategoryIndex = 0;
            this.parentBarItem1.ID = "BarItem";
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1});
            this.parentBarItem1.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.Text = "&File";
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.CategoryIndex = 0;
            this.barItem1.ID = "BarItem_1";
            this.barItem1.ShowToolTipInPopUp = false;
            this.barItem1.SizeToFit = true;
            this.barItem1.Text = "&Exit";
            this.barItem1.Click += new System.EventHandler(this.barItem1_Click);
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.BarName = "parentBarItem2";
            this.parentBarItem2.CategoryIndex = 1;
            this.parentBarItem2.ID = "BarItem_2";
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem2});
            this.parentBarItem2.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem2.ShowToolTipInPopUp = false;
            this.parentBarItem2.SizeToFit = true;
            this.parentBarItem2.Text = "&Help";
            // 
            // barItem2
            // 
            this.barItem2.BarName = "barItem2";
            this.barItem2.CategoryIndex = 1;
            this.barItem2.ID = "BarItem_3";
            this.barItem2.ShowToolTipInPopUp = false;
            this.barItem2.SizeToFit = true;
            this.barItem2.Text = "&About";
            this.barItem2.Click += new System.EventHandler(this.barItem2_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderColor = System.Drawing.Color.Gray;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.tabControlAdv1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(15, 44);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(859, 488);
            this.gradientPanel1.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 547);
            this.Controls.Add(this.gradientPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(901, 584);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash Control";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.tabPageAdv1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main() 
		{
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
            MainForm frmMain = new MainForm();
			Application.Run(frmMain);
		}
		#region ShowSplash
		private void button6_Click(object sender, System.EventArgs e)
		{
			this.splashControl1.ShowSplash(false);
		}
		#endregion
		#region samplecodeblock
		protected void CodeGen_InitializeComponent()
		{
			// <samplecodeblock name="SplashControl InitializeComponent">
			// InitializeComponent
			
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));

			// Create the splash control
			this.splashControl1 = new SplashControl();

			// Setting AutoMode to true will automatically launch
			// splash screen - no additional code is required
			this.splashControl1.AutoMode = true;

			// The start position for the splash screen
			this.splashControl1.DesktopAlignment = Syncfusion.Windows.Forms.Tools.SplashAlignment.Center;
			
			// The host form for the splash control
			this.splashControl1.HostForm = this;

			// Specifies if the splash screen should appear animated
			this.splashControl1.ShowAnimation = false;
			
			// The Splash image - specified through the designer
			this.splashControl1.SplashImage = ((System.Drawing.Bitmap)(resources.GetObject("splashControl1.SplashImage")));
			
			// The time period for which the splash should appear
			this.splashControl1.TimerInterval = 3000;
			//</samplecodeblock>
		}

		#endregion
		#region Exit
		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			
		}
		#endregion
		#region SplashClosed
		//<samplecodeblock name="SplashControl SplashClosed event.">
		private void splashControl1_SplashClosed(object sender, System.EventArgs e)
		{
			string eventlogmessage = String.Format("Event: {0} Object: {1}\r\n", "SplashClosed", sender.ToString());
			textBox5.Text = textBox5.Text + eventlogmessage;

		}
		#endregion
		//</samplecodeblock>
		#region SplashControlAboutForm
		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			
		}
		#endregion
		#region BeforeSplash
		private void splashControl1_BeforeSplash(object sender, System.ComponentModel.CancelEventArgs e)
		{
			string eventlogmessage = String.Format("Event: {0} Object: {1}\r\n", "BeforeSplash", sender.ToString());
			textBox5.Text = textBox5.Text + eventlogmessage;
	
		}
		#endregion
		#region SplashDisplayed
		private void splashControl1_SplashDisplayed(object sender, System.EventArgs e)
		{
			string eventlogmessage = String.Format("Event: {0} Object: {1}\r\n", "SplashDisplayed", sender.ToString());
			textBox5.Text = textBox5.Text + eventlogmessage;
		}
		#endregion

        private void barItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barItem2_Click(object sender, EventArgs e)
        {
            DemoCommon.AboutForm ab = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            ab.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void tabControlAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                this.pictureBox1.Location = new Point(422, 56);
                this.button6.Location = new Point(592, 334);
            }
            else
            {
                this.pictureBox1.Location = new Point(222, 56);
                this.button6.Location = new Point(392, 334);
            }
        }

		
	}
}
