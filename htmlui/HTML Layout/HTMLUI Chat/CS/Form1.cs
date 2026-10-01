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
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Xml;
using System.Reflection;

using Syncfusion.Windows.Forms.HTMLUI;
using Syncfusion.Licensing;

namespace Syncfusion.Windows.Forms.HTMLUI.Samples
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
		#region ClassSummaryDescription
		private Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl htmluiControl1;

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox1;
		private ButtonAdv button1;

		BaseElement table1 = null;

		private const string DEF_IMG_SMILE = "<img id='smile' src='..\\..\\smile.gif'>";
		private const string DEF_IMG_SAD = "<img id='sad' src='..\\..\\sad.gif'>";
		private const string DEF_IMG_LAUGH = "<img id='laugh' src='..\\..\\laugh.gif'>";
		private const string DEF_IMG_WAVE = "<img id='wave' src='..\\..\\wave.gif'>";
		private const string DEF_SMILE = ":-)";
		private const string DEF_SAD = ":-(";
		private const string DEF_LAUGH = ":))";
		private const string DEF_WAVE = ":-h";

        private ButtonAdv button2;
        private ButtonAdv button3;
        private ButtonAdv button4;
        private ButtonAdv button5;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
        private ButtonAdv button7;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenu1;
		private System.Windows.Forms.ToolStripMenuItem menuItem9;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Panel panel8;
        private ButtonAdv button6;
        private Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
        private Tools.XPMenus.Bar bar1;
        private Tools.XPMenus.ParentBarItem parentBarItem1;
        private Tools.XPMenus.BarItem barItem1;
        private Tools.XPMenus.BarItem barItem2;
        private Tools.XPMenus.BarItem barItem3;
        private Tools.XPMenus.BarItem barItem4;
        private Tools.XPMenus.BarItem barItem5;
        private Tools.XPMenus.BarItem barItem6;
        private Tools.XPMenus.ParentBarItem parentBarItem2;
		private System.ComponentModel.IContainer components;
		#endregion

		public Form1()
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
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

        #region Function

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

        #endregion

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
            for (int i = 1; i <= count; i++)
            {
                string imagePath = ($"Syncfusion.Windows.Forms.HTMLUI.Samples.Images.{folder}.Image_{i}.png");
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
            this.contextMenu1 = new System.Windows.Forms.ContextMenuStrip();
            this.menuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button6 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button4 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button7 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "HTMLUIChat");
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            ((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // htmluiControl1
            // 
            this.htmluiControl1.AutoScroll = true;
            this.htmluiControl1.AutoScrollMinSize = new System.Drawing.Size(376, 277);
            this.htmluiControl1.ContextMenuStrip = this.contextMenu1;
            this.htmluiControl1.DefaultFormat.BackgroundColor = System.Drawing.SystemColors.Control;
            this.htmluiControl1.DefaultFormat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.htmluiControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmluiControl1.Location = new System.Drawing.Point(0, 0);
            this.htmluiControl1.Name = "htmluiControl1";
            this.htmluiControl1.ShowTitle = false;
            this.htmluiControl1.Size = new System.Drawing.Size(393, 292);
            this.htmluiControl1.TabIndex = 0;
            this.htmluiControl1.Text = resources.GetString("htmluiControl1.Text");
            this.toolTip1.SetToolTip(this.htmluiControl1, "HTMLUI Control");
            this.htmluiControl1.LoadFinished += new System.EventHandler(this.htmluiControl1_LoadFinished);
            // 
            // contextMenu1
            // 
            this.contextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripMenuItem[] {
            this.menuItem9});
            // 
            // menuItem9
            // 
            this.menuItem9.MergeIndex = 0;
            this.menuItem9.Text = "Copy";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(7, 338);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 129);
            this.panel1.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.button6);
            this.panel8.Controls.Add(this.button1);
            this.panel8.Controls.Add(this.textBox1);
            this.panel8.Location = new System.Drawing.Point(8, 38);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(369, 81);
            this.panel8.TabIndex = 6;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(311, 55);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(48, 20);
            this.button6.TabIndex = 2;
            this.button6.Text = "Search";
            this.toolTip1.SetToolTip(this.button6, "Search for text");
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(311, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send";
            this.toolTip1.SetToolTip(this.button1, "Send Message");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 79);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(152, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(32, 24);
            this.button5.TabIndex = 5;
            this.toolTip1.SetToolTip(this.button5, "Cry");
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(104, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 24);
            this.button4.TabIndex = 4;
            this.toolTip1.SetToolTip(this.button4, "bye");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(56, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 24);
            this.button3.TabIndex = 3;
            this.toolTip1.SetToolTip(this.button3, "broad smile");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(8, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 24);
            this.button2.TabIndex = 2;
            this.toolTip1.SetToolTip(this.button2, "smile");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(229)))), ((int)(((byte)(245)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.panel2.Location = new System.Drawing.Point(405, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 426);
            this.panel2.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.AliceBlue;
            this.panel6.Controls.Add(this.button7);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(6, 290);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(112, 120);
            this.panel6.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.AliceBlue;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.AliceBlue;
            this.button7.ImageIndex = 5;
            this.button7.ImageList = this.imageList1;
            this.button7.Location = new System.Drawing.Point(72, 104);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(32, 15);
            this.button7.TabIndex = 1;
            this.button7.Text = "...";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.button7, "Change the display picture");
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // imageList1
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.imageList1, "ImageList1", 6);
#else
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
#endif
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.ForeColor = System.Drawing.Color.Honeydew;
            this.panel7.Location = new System.Drawing.Point(8, 8);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(96, 96);
            this.panel7.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.AliceBlue;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(6, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(112, 120);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.ForeColor = System.Drawing.Color.Honeydew;
            this.panel5.Location = new System.Drawing.Point(8, 8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(96, 96);
            this.panel5.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.htmluiControl1);
            this.panel3.Location = new System.Drawing.Point(7, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 294);
            this.panel3.TabIndex = 3;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Conversation1";
            this.saveFileDialog1.Title = "Save the conversation";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.CheckFileExists = false;
            this.openFileDialog1.CheckPathExists = false;
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // mainFrameBarManager1
            // 
#if !NETCORE
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
#endif
            this.mainFrameBarManager1.Bars.Add(this.bar1);
            this.mainFrameBarManager1.Categories.Add("File");
            this.mainFrameBarManager1.Categories.Add("Option");
            this.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.MetroForm";
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem4,
            this.barItem5,
            this.barItem6,
            this.parentBarItem2});
            this.mainFrameBarManager1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // bar1
            // 
            this.bar1.BarName = "HTMLUIChat";
            this.bar1.Caption = "HTMLUIChat";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.parentBarItem2});
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
            this.barItem4});
            this.parentBarItem1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.Text = "File";
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.CategoryIndex = 0;
            this.barItem1.ID = "New Chat Window";
            this.barItem1.ShowToolTipInPopUp = false;
            this.barItem1.SizeToFit = true;
            this.barItem1.Text = "New Chat Window";
            this.barItem1.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // barItem2
            // 
            this.barItem2.BarName = "barItem2";
            this.barItem2.CategoryIndex = 0;
            this.barItem2.ID = "Save this conversation";
            this.barItem2.ShowToolTipInPopUp = false;
            this.barItem2.SizeToFit = true;
            this.barItem2.Text = "Save this conversation";
            this.barItem2.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // barItem3
            // 
            this.barItem3.BarName = "barItem3";
            this.barItem3.CategoryIndex = 0;
            this.barItem3.ID = "Open old conversation";
            this.barItem3.ShowToolTipInPopUp = false;
            this.barItem3.SizeToFit = true;
            this.barItem3.Text = "Open old conversation";
            this.barItem3.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // barItem4
            // 
            this.barItem4.BarName = "barItem4";
            this.barItem4.CategoryIndex = 0;
            this.barItem4.ID = "Exit";
            this.barItem4.ShowToolTipInPopUp = false;
            this.barItem4.SizeToFit = true;
            this.barItem4.Text = "Exit";
            this.barItem4.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.BarName = "parentBarItem2";
            this.parentBarItem2.CategoryIndex = 1;
            this.parentBarItem2.ID = "Options";
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem5,
            this.barItem6});
            this.parentBarItem2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem2.ShowToolTipInPopUp = false;
            this.parentBarItem2.SizeToFit = true;
            this.parentBarItem2.Text = "Options";
            // 
            // barItem5
            // 
            this.barItem5.BarName = "barItem5";
            this.barItem5.CategoryIndex = 1;
            this.barItem5.ID = "Change display picture";
            this.barItem5.ShowToolTipInPopUp = false;
            this.barItem5.SizeToFit = true;
            this.barItem5.Text = "Change display picture";
            this.barItem5.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // barItem6
            // 
            this.barItem6.BarName = "barItem6";
            this.barItem6.CategoryIndex = 1;
            this.barItem6.ID = "ChangeBackGround";
            this.barItem6.ShowToolTipInPopUp = false;
            this.barItem6.SizeToFit = true;
            this.barItem6.Text = "ChangeBackGround";
            this.barItem6.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientSize = new System.Drawing.Size(543, 475);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.IconTextRelation = System.Windows.Forms.LeftRightAlignment.Left;
            this.MetroColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(555, 511);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTMLUI Chat";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
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
            Application.Run(new Form1());
		}

		#region ApplicationEvents
		private void htmluiControl1_LoadFinished(object sender, System.EventArgs e)
		{
			WireElements();
		}


		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.htmluiControl1.LoadFromString("");
			LoadHTMLFile(@"chat.htm");
			this.pictureBox1.Image = Image.FromFile(GetLocation()+@"\clouds.jpg");
			this.pictureBox2.Image = Image.FromFile(GetLocation()+@"\clouds.jpg");
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			SendContents();
		}

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
			if(this.textBox1.Text != String.Empty)
			{
				this.button1.Enabled = true;
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
            this.textBox1.Text += ":-)";
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			this.textBox1.Text += ":))";
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			this.textBox1.Text += ":-h";
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			this.textBox1.Text += ":-(";
		}

		private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				SendContents();
			}
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			Form form = new Form1();
			form.Show();
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			this.saveFileDialog1.Filter = "xml files|*.xml";
			this.openFileDialog1.InitialDirectory = Directory.CreateDirectory(@"..\..\").FullName.ToString();
			if(saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				this.htmluiControl1.Document.Document.Save(saveFileDialog1.FileName);
			}
			Console.WriteLine("Conversation saved.");
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			this.openFileDialog1.Filter = "xml files|*.xml";
			this.openFileDialog1.InitialDirectory = Directory.CreateDirectory(@"..\..\").FullName.ToString();
			if(this.openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				XmlDocument document = new XmlDocument();
#if NET40
                document.XmlResolver = null;
#endif
				document.Load(openFileDialog1.FileName);
				string outerXML = document.FirstChild.OuterXml.ToString();
				this.htmluiControl1.LoadFromString(ReplaceImage(outerXML));
			}
			Console.WriteLine("Conversation opened.");
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			this.ChangeDisplayPicture();
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			this.ChangeDisplayPicture();
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			this.htmluiControl1.DisplayFindForm();
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			ChangeBackGroundPicture();
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			string str = this.htmluiControl1.SelectedText.ToString();
			if(str != "")
			{
				Clipboard.SetDataObject(str, true);
			}
		}
		#endregion

		#region ClassHelperMethods
		private void ChangeDisplayPicture()
		{
			this.openFileDialog1.Filter = "Bmp files|*.bmp|Jpg files|*.jpg|Gif files|*.gif";
			this.openFileDialog1.InitialDirectory = Directory.CreateDirectory(@"..\..\").FullName.ToString();
			if(this.openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				this.pictureBox2.Image = Image.FromFile(this.openFileDialog1.FileName.ToString());
			}
		}

		private string ReplaceImage(string OuterXML)
		{
			this.htmluiControl1.LoadFromString(OuterXML);
			IHTMLElement[] element = this.htmluiControl1.Document.GetElementsByName("body");
			IHTMLElementsCollection collection = element[0].Children;

			foreach(IHTMLElement elem in collection)
			{
				WriteElement(elem);
			}
			return this.htmluiControl1.Document.Document.OuterXml;
		}

		private void WriteElement(IHTMLElement elem)
		{
			if(elem.ID == "smile")
			{
				Console.WriteLine(elem.Attributes["src"].Value.ToString());
				elem.Attributes["src"].Value = GetLocation() + @"\smile.gif";
			}

			else if(elem.ID == "sad")
			{
				elem.Attributes["src"].Value = GetLocation() + @"\sad.gif";
			}

			else if(elem.ID == "laugh")
			{
				elem.Attributes["src"].Value = GetLocation() + @"\laugh.gif";
			}

			else if(elem.ID == "wave")
			{
				elem.Attributes["src"].Value = GetLocation() + @"\wave.gif";
			}

			if(elem.Children.Count != 0)
			{
				IHTMLElementsCollection newParent = elem.Children;
				foreach(IHTMLElement smallChild in newParent)
				{
					WriteElement(smallChild);
				}
			}
		}

		private string GetLocation()
		{
			string path;
			path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase );
			int slashPos = path.LastIndexOf("\\",path.Length);
			slashPos = path.LastIndexOf("\\",slashPos-1);
			slashPos = path.LastIndexOf("\\",slashPos-1);
#if NETCORE
            slashPos = path.LastIndexOf("\\", slashPos - 1);
#endif
            if (slashPos > 0)
				path = path.Substring(0,slashPos);
			path = path.Replace("file:\\", "");
			path = path+"\\files";
			return path;
		}

		private void WireElements()
		{
			Hashtable htmlelements = this.htmluiControl1.Document.GetElementsByUserIdHash();
			this.table1 = htmlelements["Table1"] as BaseElement;
		}

		private void LoadHTMLFile(string fileName)
		{
			string path;
			path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase );
			int slashPos = path.LastIndexOf("\\",path.Length);
			slashPos = path.LastIndexOf("\\",slashPos-1);
			slashPos = path.LastIndexOf("\\",slashPos-1);
#if NETCORE
            slashPos = path.LastIndexOf("\\", slashPos - 1);
#endif
            if (slashPos > 0)
				path = path.Substring(0,slashPos);
			path = path.Replace("file:\\", "");
			this.htmluiControl1.StartupDocument = System.IO.Path.Combine(path+"//files", fileName);	
		}

		private void SendContents()
		{
			if(this.textBox1.Text != String.Empty)
			{
				AddToDisplay(this.textBox1.Text);
				this.textBox1.Clear();
				this.button1.Enabled = false;
			}
		}

		private void AddToDisplay(string newText)
		{
			//Replace the text with the smileys
			newText = newText.Replace(DEF_SMILE, DEF_IMG_SMILE);
			newText = newText.Replace(DEF_LAUGH, DEF_IMG_LAUGH);
			newText = newText.Replace(DEF_WAVE, DEF_IMG_WAVE);
			newText = newText.Replace(DEF_SAD, DEF_IMG_SAD);

			newText = newText.Replace("\r\n", "<br \\>" );

			// Create a new row and insert the text
			this.table1.InnerHTML += "<tr><td class=\"date\">" + DateTime.Now.ToString() +"</td></tr><tr><td class=\"message\">" + newText +"<p/></td></tr>";
			ScrollToEnd();
		}

		private void ChangeBackGroundPicture()
		{
			this.openFileDialog1.Filter = "Bmp files|*.bmp|Jpg files|*.jpg|Gif files|*.gif";
			this.openFileDialog1.InitialDirectory = Directory.CreateDirectory(@"..\..\").FullName.ToString();
			if(this.openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				this.panel1.BackgroundImage = Image.FromFile(this.openFileDialog1.FileName.ToString());
				this.panel2.BackgroundImage = Image.FromFile(this.openFileDialog1.FileName.ToString());
			}
		}

		private void ScrollToEnd()
		{
			Point lastPoint = new Point(this.table1.Location.X + this.table1.Size.Width, this.table1.Location.Y + this.table1.Size.Height);
            Rectangle rect = new Rectangle(new Point(lastPoint.X-10, lastPoint.Y-10), new Size(10,10));
			this.htmluiControl1.ScrollToRectangle(rect, this.htmluiControl1.Document);
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
