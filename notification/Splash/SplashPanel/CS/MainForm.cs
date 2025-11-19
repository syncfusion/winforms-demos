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

namespace SplashPanelDemo
{
    using System;
    using System.Drawing;
    using System.Collections;
    using System.ComponentModel;
    using System.Windows.Forms;
    using System.Data;
    using Syncfusion.Windows.Forms.Tools;
    using Syncfusion.Drawing;
    using System.Reflection;
    using Syncfusion.Windows.Forms;

    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class MainForm : MetroForm
	{
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.IContainer components;
		private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
		private Point currentPt1;
        private Timer timer1;

        private delegate void SetStringDelegate(string val);//Any string value
        string lableText = "Animation style";
        string[] l;
        int i = 0, j = 0;
        private Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem2;
        private SplashPanel splashPanel1;
        private LinkLabel linkLabel1;
        private GradientPanel gradientPanel3;
        private GradientLabel gradientLabel2;
        private RadioButtonAdv alignSystemTray;
        private RadioButtonAdv alignBottomRight;
        private RadioButtonAdv alignCustom;
        private RadioButtonAdv alignBottomLeft;
        private RadioButtonAdv alignTopRight;
        private RadioButtonAdv alignTopLeft;
        private RadioButtonAdv alignCenter;
        private GradientPanel gradientPanel8;
        private RadioButtonAdv radioButton10;
        private RadioButtonAdv radioButton9;
        private RadioButtonAdv radioButton8;
        private RadioButtonAdv radioButton7;
        private GradientLabel gradientLabel5;
        private GradientPanel gradientPanel6;
        private RadioButtonAdv radioButton6;
        private RadioButtonAdv radioButton5;
        private RadioButtonAdv radioButton3;
        private RadioButtonAdv radioButton4;
        private GradientLabel gradientLabel4;
        private GradientPanel gradientPanel1;
        private RadioButtonAdv radioButtonAdv1;
        private Label label7;
        private Label label6;
        private Label label5;
        private RadioButtonAdv radioButton2;
        private RadioButtonAdv radioButton1;
        private GradientPanel gradientPanel5;
        private ButtonAdv buttonAdv3;
        private ButtonAdv buttonAdv4;
        private GradientPanel gradientPanel4;
        private Label label1;
        private TrackBarEx trackBar1;
        private Label label2;
        private TextBox timerInterval;
        private Timer timer2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem4;
        private TabPageAdv tabPageAdv5;
        private PictureBox pictureBox2;
        private ButtonAdv buttonAdv5;
        private SplitContainerAdv splitContainerAdv1;
        private GradientPanel gradientPanel7;
      
		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            this.splashPanel1.DesktopAlignment = SplashAlignment.LeftBottom;
            this.splashPanel1.SlideStyle = SlideStyle.Horizontal;
            label7.Text = "";
            label5.Text = lableText;
            l = new string[lableText.Length];
            for (int i = 0; i < lableText.Length; i++)
                l[i] = lableText[i].ToString();
            label5.Location = label6.Location = label7.Location = new Point(40, 5);
            label5.Font = label6.Font = label7.Font = new System.Drawing.Font("Microsoft Sans Serif",
                12F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            label6.Text = label7.Text = "";
            timer1.Start();
            this.mainFrameBarManager1.MainMenuBar.DrawBackground += new PaintEventHandler(MainMenuBar_DrawBackground);
            this.gradientPanel8.Visible = false;
            this.gradientPanel6.Enabled = false;
            this.gradientPanel3.Visible = this.gradientPanel6.Visible = true;
            this.trackBar1.Size = new Size(140,20);
            this.trackBar1.Value = 25;
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "Menu");
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.gradientPanel7 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.splashPanel1 = new Syncfusion.Windows.Forms.Tools.SplashPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new Syncfusion.Windows.Forms.Tools.TrackBarEx(2, 50);
            this.label2 = new System.Windows.Forms.Label();
            this.timerInterval = new System.Windows.Forms.TextBox();
            this.gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.gradientLabel2 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.alignSystemTray = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.alignBottomRight = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.alignCustom = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.alignBottomLeft = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.alignTopRight = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.alignTopLeft = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.alignCenter = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.radioButtonAdv1 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton2 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton1 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.gradientPanel8 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.radioButton10 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton9 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton8 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton7 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.gradientLabel5 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.gradientPanel5 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.buttonAdv3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv4 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.gradientPanel6 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.radioButton6 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton5 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton3 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton4 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.gradientLabel4 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.parentBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.tabPageAdv5 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonAdv5 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel7)).BeginInit();
            this.gradientPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            this.splashPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).BeginInit();
            this.gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).BeginInit();
            this.gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alignSystemTray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignBottomRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignCustom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignBottomLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignTopRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignTopLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel8)).BeginInit();
            this.gradientPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel5)).BeginInit();
            this.gradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel6)).BeginInit();
            this.gradientPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton4)).BeginInit();
            this.tabPageAdv5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(10, 410);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 107);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Events Log";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox1.Location = new System.Drawing.Point(3, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(754, 86);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mainFrameBarManager1
            // 
#if !NETCORE
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
#endif
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
            this.bar1.BarName = "Menu";
            this.bar1.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)
                       )));
            this.bar1.Caption = "Menu";
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
            // gradientPanel7
            // 
            this.gradientPanel7.BorderColor = System.Drawing.Color.DimGray;
            this.gradientPanel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel7.Controls.Add(this.splitContainerAdv1);
            this.gradientPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel7.Location = new System.Drawing.Point(10, 39);
            this.gradientPanel7.Name = "gradientPanel7";
            this.gradientPanel7.Size = new System.Drawing.Size(760, 371);
            this.gradientPanel7.TabIndex = 41;
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAdv1.IsSplitterFixed = true;
            this.splitContainerAdv1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.Controls.Add(this.splashPanel1);
            this.splitContainerAdv1.Panel1.Controls.Add(this.gradientPanel4);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.Controls.Add(this.gradientPanel3);
            this.splitContainerAdv1.Panel2.Controls.Add(this.gradientPanel1);
            this.splitContainerAdv1.Panel2.Controls.Add(this.gradientPanel8);
            this.splitContainerAdv1.Panel2.Controls.Add(this.gradientPanel5);
            this.splitContainerAdv1.Panel2.Controls.Add(this.gradientPanel6);
            this.splitContainerAdv1.Size = new System.Drawing.Size(758, 369);
            this.splitContainerAdv1.SplitterDistance = 236;
            this.splitContainerAdv1.TabIndex = 41;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            // 
            // splashPanel1
            // 
            this.splashPanel1.AnimationDirection = Syncfusion.Windows.Forms.Tools.AnimationDirection.Default;
            this.splashPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.SystemColors.Highlight, System.Drawing.SystemColors.HighlightText);
            this.splashPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splashPanel1.BackgroundImage")));
            this.splashPanel1.CloseOnClick = true;
            this.splashPanel1.Controls.Add(this.linkLabel1);
            this.splashPanel1.DiscreetLocation = new System.Drawing.Point(0, 0);
            this.splashPanel1.Location = new System.Drawing.Point(21, 32);
            this.splashPanel1.MarqueeDirection = Syncfusion.Windows.Forms.Tools.SplashPanelMarqueeDirection.LeftToRight;
            this.splashPanel1.MarqueePosition = Syncfusion.Windows.Forms.Tools.MarqueePosition.BottomLeft;
            this.splashPanel1.Name = "splashPanel1";
            this.splashPanel1.Size = new System.Drawing.Size(201, 148);
            this.splashPanel1.SlideStyle = Syncfusion.Windows.Forms.Tools.SlideStyle.TopToBottom;
            this.splashPanel1.TabIndex = 27;
            this.splashPanel1.BeforeSplash += new System.ComponentModel.CancelEventHandler(this.splashPanel1_BeforeSplash);
            this.splashPanel1.SplashDisplayed += new System.EventHandler(this.splashPanel1_SplashDisplayed);
            this.splashPanel1.SplashClosed += new Syncfusion.Windows.Forms.Tools.SplashClosedEventHandler(this.splashPanel1_SplashClosing);
            // 
            // linkLabel1
            // 
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.LinkColor = System.Drawing.Color.FloralWhite;
            this.linkLabel1.Location = new System.Drawing.Point(47, 58);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(112, 24);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.syncfusion.com";
            // 
            // gradientPanel4
            // 
            this.gradientPanel4.BorderColor = System.Drawing.Color.DimGray;
            this.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel4.Controls.Add(this.label1);
            this.gradientPanel4.Controls.Add(this.trackBar1);
            this.gradientPanel4.Controls.Add(this.label2);
            this.gradientPanel4.Controls.Add(this.timerInterval);
            this.gradientPanel4.Location = new System.Drawing.Point(21, 203);
            this.gradientPanel4.Name = "gradientPanel4";
            this.gradientPanel4.Size = new System.Drawing.Size(201, 121);
            this.gradientPanel4.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Speed";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(50, 26);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(160, 20);
            this.trackBar1.Style = Syncfusion.Windows.Forms.Tools.TrackBarEx.Theme.Metro;
            this.trackBar1.TabIndex = 14;
            this.trackBar1.TimerInterval = 100;
            this.trackBar1.Value = 25;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(3, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 32);
            this.label2.TabIndex = 29;
            this.label2.Text = "Display Interval (Milliseconds)";
            // 
            // timerInterval
            // 
            this.timerInterval.ForeColor = System.Drawing.Color.MidnightBlue;
            this.timerInterval.Location = new System.Drawing.Point(110, 67);
            this.timerInterval.Name = "timerInterval";
            this.timerInterval.Size = new System.Drawing.Size(72, 22);
            this.timerInterval.TabIndex = 15;
            this.timerInterval.Text = "5000";
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.BorderColor = System.Drawing.Color.DimGray;
            this.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel3.Controls.Add(this.gradientLabel2);
            this.gradientPanel3.Controls.Add(this.alignSystemTray);
            this.gradientPanel3.Controls.Add(this.alignBottomRight);
            this.gradientPanel3.Controls.Add(this.alignCustom);
            this.gradientPanel3.Controls.Add(this.alignBottomLeft);
            this.gradientPanel3.Controls.Add(this.alignTopRight);
            this.gradientPanel3.Controls.Add(this.alignTopLeft);
            this.gradientPanel3.Controls.Add(this.alignCenter);
            this.gradientPanel3.Location = new System.Drawing.Point(19, 126);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(256, 174);
            this.gradientPanel3.TabIndex = 34;
            // 
            // gradientLabel2
            // 
            this.gradientLabel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.gradientLabel2.BorderSides = System.Windows.Forms.Border3DSide.Top;
            this.gradientLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientLabel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel2.ForeColor = System.Drawing.Color.Black;
            this.gradientLabel2.Location = new System.Drawing.Point(0, 0);
            this.gradientLabel2.Name = "gradientLabel2";
            this.gradientLabel2.Size = new System.Drawing.Size(254, 24);
            this.gradientLabel2.TabIndex = 31;
            this.gradientLabel2.Text = "Desktop Alignment";
            this.gradientLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alignSystemTray
            // 
            this.alignSystemTray.Checked = true;
            this.alignSystemTray.DrawFocusRectangle = false;
            this.alignSystemTray.Location = new System.Drawing.Point(16, 40);
            this.alignSystemTray.MetroColor = System.Drawing.Color.DimGray;
            this.alignSystemTray.Name = "alignSystemTray";
            this.alignSystemTray.Size = new System.Drawing.Size(99, 24);
            this.alignSystemTray.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.alignSystemTray.TabIndex = 25;
            this.alignSystemTray.Text = "System Tray";
            this.alignSystemTray.ThemesEnabled = false;
            // 
            // alignBottomRight
            // 
            this.alignBottomRight.DrawFocusRectangle = false;
            this.alignBottomRight.Location = new System.Drawing.Point(136, 107);
            this.alignBottomRight.MetroColor = System.Drawing.Color.DimGray;
            this.alignBottomRight.Name = "alignBottomRight";
            this.alignBottomRight.Size = new System.Drawing.Size(101, 24);
            this.alignBottomRight.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.alignBottomRight.TabIndex = 29;
            this.alignBottomRight.Text = "BottomRight";
            this.alignBottomRight.ThemesEnabled = false;
            // 
            // alignCustom
            // 
            this.alignCustom.DrawFocusRectangle = false;
            this.alignCustom.Location = new System.Drawing.Point(77, 137);
            this.alignCustom.MetroColor = System.Drawing.Color.DimGray;
            this.alignCustom.Name = "alignCustom";
            this.alignCustom.Size = new System.Drawing.Size(88, 24);
            this.alignCustom.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.alignCustom.TabIndex = 30;
            this.alignCustom.Text = "Custom";
            this.alignCustom.ThemesEnabled = false;
            // 
            // alignBottomLeft
            // 
            this.alignBottomLeft.DrawFocusRectangle = false;
            this.alignBottomLeft.Location = new System.Drawing.Point(17, 107);
            this.alignBottomLeft.MetroColor = System.Drawing.Color.DimGray;
            this.alignBottomLeft.Name = "alignBottomLeft";
            this.alignBottomLeft.Size = new System.Drawing.Size(98, 24);
            this.alignBottomLeft.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.alignBottomLeft.TabIndex = 27;
            this.alignBottomLeft.Text = "BottomLeft";
            this.alignBottomLeft.ThemesEnabled = false;
            // 
            // alignTopRight
            // 
            this.alignTopRight.DrawFocusRectangle = false;
            this.alignTopRight.Location = new System.Drawing.Point(136, 73);
            this.alignTopRight.MetroColor = System.Drawing.Color.DimGray;
            this.alignTopRight.Name = "alignTopRight";
            this.alignTopRight.Size = new System.Drawing.Size(80, 24);
            this.alignTopRight.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.alignTopRight.TabIndex = 26;
            this.alignTopRight.Text = "TopRight";
            this.alignTopRight.ThemesEnabled = false;
            // 
            // alignTopLeft
            // 
            this.alignTopLeft.DrawFocusRectangle = false;
            this.alignTopLeft.Location = new System.Drawing.Point(17, 73);
            this.alignTopLeft.MetroColor = System.Drawing.Color.DimGray;
            this.alignTopLeft.Name = "alignTopLeft";
            this.alignTopLeft.Size = new System.Drawing.Size(88, 24);
            this.alignTopLeft.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.alignTopLeft.TabIndex = 28;
            this.alignTopLeft.Text = "TopLeft";
            this.alignTopLeft.ThemesEnabled = false;
            // 
            // alignCenter
            // 
            this.alignCenter.DrawFocusRectangle = false;
            this.alignCenter.Location = new System.Drawing.Point(137, 41);
            this.alignCenter.MetroColor = System.Drawing.Color.DimGray;
            this.alignCenter.Name = "alignCenter";
            this.alignCenter.Size = new System.Drawing.Size(80, 24);
            this.alignCenter.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.alignCenter.TabIndex = 24;
            this.alignCenter.Text = "Center";
            this.alignCenter.ThemesEnabled = false;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderColor = System.Drawing.Color.DimGray;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.radioButtonAdv1);
            this.gradientPanel1.Controls.Add(this.label7);
            this.gradientPanel1.Controls.Add(this.label6);
            this.gradientPanel1.Controls.Add(this.label5);
            this.gradientPanel1.Controls.Add(this.radioButton2);
            this.gradientPanel1.Controls.Add(this.radioButton1);
            this.gradientPanel1.Location = new System.Drawing.Point(19, 28);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(481, 70);
            this.gradientPanel1.TabIndex = 37;
            // 
            // radioButtonAdv1
            // 
            this.radioButtonAdv1.Checked = true;
            this.radioButtonAdv1.DrawFocusRectangle = false;
            this.radioButtonAdv1.Location = new System.Drawing.Point(388, 34);
            this.radioButtonAdv1.MetroColor = System.Drawing.Color.DimGray;
            this.radioButtonAdv1.Name = "radioButtonAdv1";
            this.radioButtonAdv1.Size = new System.Drawing.Size(76, 21);
            this.radioButtonAdv1.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv1.TabIndex = 28;
            this.radioButtonAdv1.Text = "Normal";
            this.radioButtonAdv1.ThemesEnabled = false;
            this.radioButtonAdv1.CheckChanged += new System.EventHandler(this.radioButtonAdv1_CheckChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(196, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Animation Style";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "label5";
            // 
            // radioButton2
            // 
            this.radioButton2.DrawFocusRectangle = false;
            this.radioButton2.Location = new System.Drawing.Point(199, 32);
            this.radioButton2.MetroColor = System.Drawing.Color.DimGray;
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 23);
            this.radioButton2.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton2.TabIndex = 27;
            this.radioButton2.TabStop = false;
            this.radioButton2.Text = "Marquee";
            this.radioButton2.ThemesEnabled = false;
            this.radioButton2.CheckChanged += new System.EventHandler(this.radioButton2_CheckChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.DrawFocusRectangle = false;
            this.radioButton1.Location = new System.Drawing.Point(27, 32);
            this.radioButton1.MetroColor = System.Drawing.Color.DimGray;
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 23);
            this.radioButton1.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton1.TabIndex = 26;
            this.radioButton1.Text = "Slide";
            this.radioButton1.ThemesEnabled = false;
            this.radioButton1.CheckChanged += new System.EventHandler(this.radioButton1_CheckChanged);
            // 
            // gradientPanel8
            // 
            this.gradientPanel8.BorderColor = System.Drawing.Color.DimGray;
            this.gradientPanel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel8.Controls.Add(this.radioButton10);
            this.gradientPanel8.Controls.Add(this.radioButton9);
            this.gradientPanel8.Controls.Add(this.radioButton8);
            this.gradientPanel8.Controls.Add(this.radioButton7);
            this.gradientPanel8.Controls.Add(this.gradientLabel5);
            this.gradientPanel8.Location = new System.Drawing.Point(19, 126);
            this.gradientPanel8.Name = "gradientPanel8";
            this.gradientPanel8.Size = new System.Drawing.Size(250, 173);
            this.gradientPanel8.TabIndex = 39;
            // 
            // radioButton10
            // 
            this.radioButton10.DrawFocusRectangle = false;
            this.radioButton10.Location = new System.Drawing.Point(155, 103);
            this.radioButton10.MetroColor = System.Drawing.Color.DimGray;
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(88, 22);
            this.radioButton10.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton10.TabIndex = 26;
            this.radioButton10.TabStop = false;
            this.radioButton10.Text = "Right Top";
            this.radioButton10.ThemesEnabled = false;
            this.radioButton10.CheckChanged += new System.EventHandler(this.radioButton10_CheckChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.DrawFocusRectangle = false;
            this.radioButton9.Location = new System.Drawing.Point(156, 48);
            this.radioButton9.MetroColor = System.Drawing.Color.DimGray;
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(81, 22);
            this.radioButton9.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton9.TabIndex = 25;
            this.radioButton9.TabStop = false;
            this.radioButton9.Text = "Left Top";
            this.radioButton9.ThemesEnabled = false;
            this.radioButton9.CheckChanged += new System.EventHandler(this.radioButton9_CheckChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.DrawFocusRectangle = false;
            this.radioButton8.Location = new System.Drawing.Point(16, 105);
            this.radioButton8.MetroColor = System.Drawing.Color.DimGray;
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(104, 22);
            this.radioButton8.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton8.TabIndex = 24;
            this.radioButton8.TabStop = false;
            this.radioButton8.Text = "Right Bottom";
            this.radioButton8.ThemesEnabled = false;
            this.radioButton8.CheckChanged += new System.EventHandler(this.radioButton8_CheckChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.Checked = true;
            this.radioButton7.DrawFocusRectangle = false;
            this.radioButton7.Location = new System.Drawing.Point(16, 48);
            this.radioButton7.MetroColor = System.Drawing.Color.DimGray;
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(98, 22);
            this.radioButton7.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton7.TabIndex = 23;
            this.radioButton7.Text = "Left Bottom";
            this.radioButton7.ThemesEnabled = false;
            this.radioButton7.CheckChanged += new System.EventHandler(this.radioButton7_CheckChanged);
            // 
            // gradientLabel5
            // 
            this.gradientLabel5.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.gradientLabel5.BorderSides = System.Windows.Forms.Border3DSide.Top;
            this.gradientLabel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientLabel5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel5.ForeColor = System.Drawing.Color.Black;
            this.gradientLabel5.Location = new System.Drawing.Point(0, 0);
            this.gradientLabel5.Name = "gradientLabel5";
            this.gradientLabel5.Size = new System.Drawing.Size(248, 24);
            this.gradientLabel5.TabIndex = 22;
            this.gradientLabel5.Text = "Slide Position\r\n";
            this.gradientLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientPanel5
            // 
            this.gradientPanel5.BorderColor = System.Drawing.Color.DimGray;
            this.gradientPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel5.Controls.Add(this.buttonAdv3);
            this.gradientPanel5.Controls.Add(this.buttonAdv4);
            this.gradientPanel5.Location = new System.Drawing.Point(19, 317);
            this.gradientPanel5.Name = "gradientPanel5";
            this.gradientPanel5.Size = new System.Drawing.Size(257, 40);
            this.gradientPanel5.TabIndex = 36;
            // 
            // buttonAdv3
            // 
            this.buttonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonAdv3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonAdv3.KeepFocusRectangle = false;
            this.buttonAdv3.Location = new System.Drawing.Point(155, 8);
            this.buttonAdv3.Name = "buttonAdv3";
            this.buttonAdv3.Size = new System.Drawing.Size(88, 23);
            this.buttonAdv3.TabIndex = 37;
            this.buttonAdv3.Text = "Show Splash";
            this.buttonAdv3.UseVisualStyle = true;
            this.buttonAdv3.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAdv4
            // 
            this.buttonAdv4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonAdv4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonAdv4.KeepFocusRectangle = false;
            this.buttonAdv4.Location = new System.Drawing.Point(8, 8);
            this.buttonAdv4.Name = "buttonAdv4";
            this.buttonAdv4.Size = new System.Drawing.Size(128, 23);
            this.buttonAdv4.TabIndex = 37;
            this.buttonAdv4.Text = "Show Splash (Modal)";
            this.buttonAdv4.UseVisualStyle = true;
            this.buttonAdv4.Click += new System.EventHandler(this.button2_Click);
            // 
            // gradientPanel6
            // 
            this.gradientPanel6.BorderColor = System.Drawing.Color.DimGray;
            this.gradientPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel6.Controls.Add(this.radioButton6);
            this.gradientPanel6.Controls.Add(this.radioButton5);
            this.gradientPanel6.Controls.Add(this.radioButton3);
            this.gradientPanel6.Controls.Add(this.radioButton4);
            this.gradientPanel6.Controls.Add(this.gradientLabel4);
            this.gradientPanel6.Location = new System.Drawing.Point(288, 126);
            this.gradientPanel6.Name = "gradientPanel6";
            this.gradientPanel6.Size = new System.Drawing.Size(213, 173);
            this.gradientPanel6.TabIndex = 38;
            // 
            // radioButton6
            // 
            this.radioButton6.DrawFocusRectangle = false;
            this.radioButton6.Location = new System.Drawing.Point(54, 103);
            this.radioButton6.MetroColor = System.Drawing.Color.DimGray;
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(116, 24);
            this.radioButton6.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton6.TabIndex = 26;
            this.radioButton6.TabStop = false;
            this.radioButton6.Text = "Bottom to Top";
            this.radioButton6.ThemesEnabled = false;
            this.radioButton6.CheckChanged += new System.EventHandler(this.radioButton6_CheckChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.DrawFocusRectangle = false;
            this.radioButton5.Location = new System.Drawing.Point(54, 72);
            this.radioButton5.MetroColor = System.Drawing.Color.DimGray;
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(104, 24);
            this.radioButton5.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton5.TabIndex = 25;
            this.radioButton5.TabStop = false;
            this.radioButton5.Text = "Left to Right";
            this.radioButton5.ThemesEnabled = false;
            this.radioButton5.CheckChanged += new System.EventHandler(this.radioButton5_CheckChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Checked = true;
            this.radioButton3.DrawFocusRectangle = false;
            this.radioButton3.Location = new System.Drawing.Point(54, 136);
            this.radioButton3.MetroColor = System.Drawing.Color.DimGray;
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(112, 24);
            this.radioButton3.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton3.TabIndex = 24;
            this.radioButton3.Text = "Top to Bottom";
            this.radioButton3.ThemesEnabled = false;
            this.radioButton3.CheckChanged += new System.EventHandler(this.radioButton3_CheckChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.DrawFocusRectangle = false;
            this.radioButton4.Location = new System.Drawing.Point(54, 39);
            this.radioButton4.MetroColor = System.Drawing.Color.DimGray;
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(104, 24);
            this.radioButton4.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton4.TabIndex = 23;
            this.radioButton4.Text = "Right to Left";
            this.radioButton4.ThemesEnabled = false;
            this.radioButton4.CheckChanged += new System.EventHandler(this.radioButton4_CheckChanged);
            // 
            // gradientLabel4
            // 
            this.gradientLabel4.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.gradientLabel4.BorderSides = System.Windows.Forms.Border3DSide.Top;
            this.gradientLabel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientLabel4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel4.ForeColor = System.Drawing.Color.Black;
            this.gradientLabel4.Location = new System.Drawing.Point(0, 0);
            this.gradientLabel4.Name = "gradientLabel4";
            this.gradientLabel4.Size = new System.Drawing.Size(211, 24);
            this.gradientLabel4.TabIndex = 22;
            this.gradientLabel4.Text = "Select Direction for Marquee";
            this.gradientLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parentBarItem3
            // 
            this.parentBarItem3.BarName = "parentBarItem3";
            this.parentBarItem3.CategoryIndex = 0;
            this.parentBarItem3.ID = "BarItem";
            this.parentBarItem3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem3});
            this.parentBarItem3.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem3.ShowToolTipInPopUp = false;
            this.parentBarItem3.SizeToFit = true;
            this.parentBarItem3.Text = "&File";
            // 
            // barItem3
            // 
            this.barItem3.BarName = "barItem3";
            this.barItem3.CategoryIndex = 0;
            this.barItem3.ID = "BarItem_1";
            this.barItem3.ShowToolTipInPopUp = false;
            this.barItem3.SizeToFit = true;
            this.barItem3.Text = "&Exit";
            // 
            // parentBarItem4
            // 
            this.parentBarItem4.BarName = "parentBarItem4";
            this.parentBarItem4.CategoryIndex = 1;
            this.parentBarItem4.ID = "BarItem_2";
            this.parentBarItem4.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem4});
            this.parentBarItem4.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem4.ShowToolTipInPopUp = false;
            this.parentBarItem4.SizeToFit = true;
            this.parentBarItem4.Text = "&Help";
            // 
            // barItem4
            // 
            this.barItem4.BarName = "barItem4";
            this.barItem4.CategoryIndex = 1;
            this.barItem4.ID = "BarItem_3";
            this.barItem4.ShowToolTipInPopUp = false;
            this.barItem4.SizeToFit = true;
            this.barItem4.Text = "&About";
            // 
            // tabPageAdv5
            // 
            this.tabPageAdv5.Controls.Add(this.pictureBox2);
            this.tabPageAdv5.Image = null;
            this.tabPageAdv5.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv5.Location = new System.Drawing.Point(0, 0);
            this.tabPageAdv5.Name = "tabPageAdv5";
            this.tabPageAdv5.ShowCloseButton = true;
            this.tabPageAdv5.Size = new System.Drawing.Size(200, 100);
            this.tabPageAdv5.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.tabPageAdv5.TabFont = null;
            this.tabPageAdv5.TabIndex = 0;
            this.tabPageAdv5.ThemesEnabled = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(162, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(452, 252);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // buttonAdv5
            // 
            this.buttonAdv5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(219)))));
            this.buttonAdv5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdv5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonAdv5.ImageIndex = 2;
            this.buttonAdv5.Location = new System.Drawing.Point(291, 343);
            this.buttonAdv5.Name = "buttonAdv5";
            this.buttonAdv5.Size = new System.Drawing.Size(192, 40);
            this.buttonAdv5.TabIndex = 6;
            this.buttonAdv5.Text = "Click to Show Splash Screen";
            this.buttonAdv5.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(780, 526);
            this.Controls.Add(this.gradientPanel7);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(792, 564);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash Panel ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel7)).EndInit();
            this.gradientPanel7.ResumeLayout(false);
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            this.splashPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).EndInit();
            this.gradientPanel4.ResumeLayout(false);
            this.gradientPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).EndInit();
            this.gradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alignSystemTray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignBottomRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignCustom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignBottomLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignTopRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignTopLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel8)).EndInit();
            this.gradientPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioButton10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel5)).EndInit();
            this.gradientPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel6)).EndInit();
            this.gradientPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioButton6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton4)).EndInit();
            this.tabPageAdv5.ResumeLayout(false);
            this.tabPageAdv5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

		}

        void radioButton4_CheckChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked && radioButton2.Checked)
            {
                this.splashPanel1.HideSplash();
                this.splashPanel1.DesktopAlignment = SplashAlignment.RightBottom;
                this.splashPanel1.MarqueeDirection = SplashPanelMarqueeDirection.RightToLeft;
                this.splashPanel1.ShowSplash();
            }
            else if (radioButton4.Checked && radioButton1.Checked)
            {
                this.splashPanel1.HideSplash();
                this.splashPanel1.AnimationDirection = AnimationDirection.RightToLeft;
                this.splashPanel1.ShowSplash();
            }
        }

        void radioButton7_CheckChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked && !this.radioButton2.Checked)
            {
                this.splashPanel1.DesktopAlignment = SplashAlignment.LeftBottom;
                radioButton6.Enabled = radioButton5.Enabled = true;
                radioButton3.Checked = radioButton4.Checked = false;
                radioButton3.Enabled = radioButton4.Enabled = false;

            }
        }

        void radioButton8_CheckChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked && !this.radioButton2.Checked)
            {
                this.splashPanel1.DesktopAlignment = SplashAlignment.RightBottom;
                radioButton4.Enabled = radioButton6.Enabled = true;
                radioButton3.Checked = radioButton5.Checked = false;
                radioButton3.Enabled = radioButton5.Enabled = false;
            }
        }

        void radioButton9_CheckChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                this.splashPanel1.DesktopAlignment = SplashAlignment.LeftTop;
                if (radioButton1.Checked)
                {
                    radioButton5.Enabled = radioButton3.Enabled = true;
                    radioButton4.Checked = radioButton6.Checked = false;
                    radioButton4.Enabled = radioButton6.Enabled = false;
                }
            }
        }

        void radioButton10_CheckChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked && !this.radioButton2.Checked)
            {
                this.splashPanel1.DesktopAlignment = SplashAlignment.RightTop;
                this.radioButton4.Enabled = this.radioButton3.Enabled = true;
                this.radioButton5.Checked = this.radioButton6.Checked = false;
                this.radioButton5.Enabled = this.radioButton6.Enabled = false;
            }
        }

        void radioButton3_CheckChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked && radioButton2.Checked)
            {
                this.splashPanel1.HideSplash();
                this.splashPanel1.DesktopAlignment = SplashAlignment.RightTop;
                this.splashPanel1.MarqueeDirection = SplashPanelMarqueeDirection.TopToBottom;
                this.splashPanel1.ShowSplash();
            }
            else if (radioButton3.Checked && radioButton1.Checked)
            {
                this.splashPanel1.HideSplash();
                this.splashPanel1.AnimationDirection = AnimationDirection.Default;
                this.splashPanel1.ShowSplash();
            }
        }

        void radioButton5_CheckChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked && radioButton2.Checked)
            {
                this.splashPanel1.HideSplash();
                this.splashPanel1.DesktopAlignment = SplashAlignment.LeftBottom;
                this.splashPanel1.MarqueeDirection = SplashPanelMarqueeDirection.LeftToRight;
                this.splashPanel1.ShowSplash();
            }
            if (radioButton7.Checked)
                this.splashPanel1.DesktopAlignment = SplashAlignment.LeftBottom;
            if (radioButton1.Checked && radioButton5.Checked)
            {
                splashPanel1.HideSplash();
                this.splashPanel1.AnimationDirection = AnimationDirection.LeftToRight;
                splashPanel1.ShowSplash();
            }
        }

        void radioButton6_CheckChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked && radioButton2.Checked)
            {
                this.splashPanel1.HideSplash();
                this.splashPanel1.DesktopAlignment = SplashAlignment.LeftBottom;
                this.splashPanel1.MarqueeDirection = SplashPanelMarqueeDirection.BottomToTop;
                this.splashPanel1.ShowSplash();
            }
            else if (radioButton6.Checked && radioButton1.Checked)
            {
                this.splashPanel1.HideSplash();
                this.splashPanel1.AnimationDirection = AnimationDirection.Default;
                this.splashPanel1.ShowSplash();
            }
        }

        void radioButton1_CheckChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.gradientPanel8.Visible = this.gradientPanel6.Visible = true;
                this.gradientPanel8.Enabled = this.gradientPanel6.Enabled = true;
                this.gradientPanel3.Visible=this.gradientPanel5.Visible = false;
                this.splashPanel1.SlideStyle = SlideStyle.Slide;
                this.gradientLabel5.Text = "Slide Position";
                this.gradientLabel4.Text = "Select Direction for Slide";
                if (radioButton7.Checked)
                {
                    splashPanel1.DesktopAlignment = SplashAlignment.LeftTop;
                    this.radioButton3.Checked = this.radioButton4.Checked = false;
                    this.radioButton3.Enabled = this.radioButton4.Enabled = false;
                    this.radioButton5.Enabled = this.radioButton6.Enabled = true;
                }
                else if (radioButton8.Checked)
                {
                    splashPanel1.DesktopAlignment = SplashAlignment.RightBottom;
                    radioButton4.Enabled = radioButton6.Enabled = true;
                    radioButton3.Checked = radioButton5.Checked = false;
                    radioButton3.Enabled = radioButton5.Enabled = false;
                }
                else if (radioButton9.Checked)
                {
                    splashPanel1.DesktopAlignment = SplashAlignment.LeftTop;
                    radioButton5.Enabled = radioButton3.Enabled = true;
                    radioButton4.Checked = radioButton6.Checked = false;
                    radioButton4.Enabled = radioButton6.Enabled = false;
                }
                else if (radioButton10.Checked)
                {
                    this.splashPanel1.DesktopAlignment = SplashAlignment.RightTop;
                    this.radioButton4.Enabled = this.radioButton3.Enabled = true;
                    this.radioButton5.Checked = this.radioButton6.Checked = false;
                    this.radioButton5.Enabled = this.radioButton6.Enabled = false;
                }
            }
        }

        void radioButton2_CheckChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                this.gradientPanel3.Visible=this.gradientPanel5.Visible = false;
                this.gradientPanel6.Visible=this.gradientPanel8.Visible = true;
                this.gradientPanel8.Enabled = false;
                this.gradientPanel6.Enabled = true;
                this.radioButton3.Enabled = this.radioButton4.Enabled = this.radioButton5.Enabled = this.radioButton6.Enabled = true;
                this.splashPanel1.SlideStyle = SlideStyle.Marquee;
                this.gradientLabel4.Text = "Select Direction for Marquee";

                using (Graphics g = Graphics.FromImage(new Bitmap(10, 10)))
                {
                    if (g.DpiX > 120)
                        this.gradientPanel6.Location = new Point(19, 139);
                    else if (g.DpiX > 96)
                        this.gradientPanel6.Location = new Point(25, 160);
                    else
                        this.gradientPanel6.Location = new Point(19, 139);
                    this.gradientPanel8.Visible = false;
                }
            }
            else
            {
                using (Graphics g = Graphics.FromImage(new Bitmap(10, 10)))
                {
                    if (g.DpiX > 120)
                        this.gradientPanel6.Location = new Point(320, 139);
                    else if (g.DpiX > 96)
                        this.gradientPanel6.Location = new Point(426, 170);
                    else
                        this.gradientPanel6.Location = new Point(288, 126);
                    this.gradientPanel8.Visible = true;
                }
            }


            this.splashPanel1.MarqueePosition = MarqueePosition.BottomLeft;
            splashPanel1.MarqueeDirection = SplashPanelMarqueeDirection.TopToBottom;
        }

#endregion

#region SplashAlignment

		private SplashAlignment GetDesktopAlignment()
		{
			if(this.alignCenter.Checked == true)
				return SplashAlignment.Center;
			else if(this.alignSystemTray.Checked == true)
				return SplashAlignment.SystemTray;
			else if(this.alignTopRight.Checked == true)
				return SplashAlignment.RightTop;
			else if(this.alignBottomLeft.Checked == true)
				return SplashAlignment.LeftBottom;
			else if(this.alignTopLeft.Checked == true)
				return SplashAlignment.LeftTop;
			else if(this.alignBottomRight.Checked == true)
				return SplashAlignment.RightBottom;
			else if(this.alignCustom.Checked  == true)
				return SplashAlignment.Custom;
			else
				return SplashAlignment.SystemTray;
		}
#endregion
		bool IsNumber(string text) 
		{
			if (text==null || text == String.Empty )
				return false;

			foreach(char c in text) 
			{
				if (Char.IsNumber(c) == false) 
					return false;
			}
			return true;
		}
#region ShowSplash
		private void ShowSplash(bool isModal)
		{
			Point pt = Point.Empty;
			SplashPanel currentPanel = this.splashPanel1;
			int interval = 5000;
		    currentPanel = this.splashPanel1;
			if(IsNumber(this.timerInterval.Text) == true)
				interval = Int32.Parse(this.timerInterval.Text);


			currentPanel.DesktopAlignment = GetDesktopAlignment();
			currentPanel.TimerInterval = interval;
			currentPanel.AnimationSpeed = this.trackBar1.Value;
	
			if(currentPanel.DesktopAlignment == SplashAlignment.Custom)
				pt = Control.MousePosition;

			currentPanel.ShowSplash(pt, this, isModal);
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
		private void button1_Click(object sender, System.EventArgs e)
		{
			this.ShowSplash(false);
		}
#endregion
		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}
#region BeforeSplash
		private void splashPanel1_BeforeSplash(object sender, System.ComponentModel.CancelEventArgs e)
		{
			string eventlogmessage = String.Format("Event: {0} Object: {1}\r\n", "BeforeSplash", ((Control)sender).Name);
			textBox1.Text = textBox1.Text + eventlogmessage;
		}
#endregion
#region SplashDisplayed

		private void splashPanel1_SplashDisplayed(object sender, System.EventArgs e)
		{
			string eventlogmessage = String.Format("Event: {0} Object: {1}\r\n", "SplashDisplayed", ((Control)sender).Name);
            if (this.InvokeRequired)
            {
                this.Invoke(new SetStringDelegate(OutputText), new object[] { eventlogmessage });
            }
            else
            {
                textBox1.Text = textBox1.Text + eventlogmessage;
            }
		}

#endregion
#region Method

        private void OutputText(string text)
        {
            textBox1.Text = textBox1.Text + text;
        }

#endregion
#region splashPanel1_SplashClosing
		private void splashPanel1_SplashClosing(object sender, Syncfusion.Windows.Forms.Tools.SplashClosedEventArgs args)
		{
			string eventlogmessage = String.Format("Event: {0} Object: {1}\r\n", "SplashClosing", ((Control)sender).Name);
            if (this.InvokeRequired)
            {
                this.Invoke(new SetStringDelegate(OutputText), new object[] { eventlogmessage });
            }
            else
            {
                OutputText(eventlogmessage);
            }

			this.splashPanel1.Location = this.currentPt1;
			this.splashPanel1.Visible = true;
		}
#endregion
		
#region MainForm_Load

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            this.currentPt1 = this.splashPanel1.Location;
            this.splashPanel1.Visible = true;
            this.Padding = new Padding(10, 0, 10, 10);
            this.MetroColor = Color.White;
        }
#endregion
#region codegen

		protected void CodeGen_InitializeComponent()
		{
			// InitializeComponent
			// <samplecodeblock name="SplashPanel InitializeComponent">

			// Create the splash panel
			this.splashPanel1 = new SplashPanel();

			// The animation speed
			this.splashPanel1.AnimationSpeed = 10;

			// The background 
			this.splashPanel1.BackgroundColor = new BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.SystemColors.HighlightText, System.Drawing.SystemColors.Highlight);
			
			// The border style
			this.splashPanel1.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;

			// The child controls - added through the designer
			this.splashPanel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					   this.linkLabel1});
			// The startup location for the splash panel
			this.splashPanel1.DesktopAlignment = SplashAlignment.SystemTray;

			// Specifies whether the window should appear animated
			this.splashPanel1.ShowAnimation = true;

			// The interval for which the panel is to be displayed
			this.splashPanel1.TimerInterval = 5000;

			//</samplecodeblock>
         
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CodeGen_button1_Click(object sender, System.EventArgs e)
		{
			this.splashPanel1.ShowSplash(Point.Empty, this, false);
		}

		private void CodeGen_splashPanel1_SplashClosing(object sender, Syncfusion.Windows.Forms.Tools.SplashClosedEventArgs args)
		{
			// <samplecodeblock name="SplashPanel SplashClosing event">
			this.splashPanel1.SplashClosed += new Syncfusion.Windows.Forms.Tools.SplashClosedEventHandler(this.splashPanel1_SplashClosing);

			// splashPanel1_SplashClosing event handler
			MessageBox.Show("SplashPanel closing event handler");
			//</samplecodeblock>
		}
#endregion
#region ShowSplash

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.ShowSplash(true);
		}
#endregion
#region splashPanel2_BeforeSplash
		private void splashPanel2_BeforeSplash(object sender, System.ComponentModel.CancelEventArgs e)
		{
			string eventlogmessage = String.Format("Event: {0} Object: {1}\r\n", "BeforeSplash", ((Control)sender).Name);
            if (this.InvokeRequired)
            {
                this.Invoke(new SetStringDelegate(OutputText), new object[] { eventlogmessage });
            }
            else
            {
                OutputText(eventlogmessage);
            }

		}
#endregion
#region splashPanel2_SplashDisplayed

		private void splashPanel2_SplashDisplayed(object sender, System.EventArgs e)
		{
			string eventlogmessage = String.Format("Event: {0} Object: {1}\r\n", "SplashDisplayed", ((Control)sender).Name);
            if (this.InvokeRequired)
            {
                this.Invoke(new SetStringDelegate(OutputText), new object[] { eventlogmessage });
            }
            else
            {
                OutputText(eventlogmessage);
            }

		}
#endregion
#region SplashMouseEnter
		private void splashPanel2_SplashMouseEnter(object sender, System.EventArgs e)
		{
			string eventlogmessage = String.Format("Event: {0} Object: {1}\r\n", "SplashMouseEnter", ((Control)sender).Name);
            if (this.InvokeRequired)
            {
                this.Invoke(new SetStringDelegate(OutputText), new object[] { eventlogmessage });
            }
            else
            {
                OutputText(eventlogmessage);
            }

		}
#endregion
#region splashPanel2_SplashMouseLeave
		private void splashPanel2_SplashMouseLeave(object sender, System.EventArgs e)
		{
			string eventlogmessage = String.Format("Event: {0} Object: {1}\r\n", "SplashMouseLeave", ((Control)sender).Name);
            if (this.InvokeRequired)
            {
                this.Invoke(new SetStringDelegate(OutputText), new object[] { eventlogmessage });
            }
            else
            {
                OutputText(eventlogmessage);
            }

		}
#endregion

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
			this.textBox1.SelectionStart = this.textBox1.Text.Length - 1;
			this.textBox1.ScrollToCaret();

		}

         private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //adding the characters one by one to the label2
            if (i < lableText.Length - 1)
                label6.Text += l[i].ToString();
            //starting the third label after 3 charaters of label2 adding
            if (i >= 3 && i <= 20)
            {
                if (i <= lableText.Length + 2)
                    label7.Text += l[j].ToString();
                j++;
            }
            if (j <= lableText.Length)
                i++;
            else
            {
                i = j = 0;
                label7.Text = label6.Text = "";
            }


        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.splashPanel1.AnimationSteps = trackBar1.Value;
        }

        private void barItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barItem2_Click(object sender, EventArgs e)
        {
            DemoCommon.AboutForm ab = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            ab.ShowDialog();
        }

        private void radioButtonAdv1_CheckChanged(object sender, EventArgs e)
        {
            if (radioButtonAdv1.Checked)
            {
                this.gradientPanel5.Visible =this.gradientPanel6.Visible= true;
                this.splashPanel1.SlideStyle = SlideStyle.Default;
                this.gradientPanel3.Visible = true;
                this.gradientPanel8.Visible = false;
                this.gradientPanel6.Enabled = false;
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {

        }

    }
}
