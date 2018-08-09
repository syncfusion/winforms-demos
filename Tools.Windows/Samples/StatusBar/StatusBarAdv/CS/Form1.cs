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
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;
using Syncfusion.Licensing;
using System.IO;

namespace StatusBarAdvDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private Syncfusion.Windows.Forms.Tools.StatusBarAdv statusBarAdv3;
		private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel statusBarAdvPanel11;
		private TextBoxExt textBox1;
		private ButtonAdv button1;
		private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel timePanel;
		private RadioButtonAdv radioButton1;
        private RadioButtonAdv radioButton2;
        private RadioButtonAdv radioButton3;
        private RadioButtonAdv radioButton4;
        private RadioButtonAdv radioButton5;
        private RadioButtonAdv radioButton6;
        private RadioButtonAdv radioButton7;
        private TextBoxExt textBox2;
        private ButtonAdv button2;
		private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel customPanel;
        private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel keyPanel;
        private TabControlAdv tabControlAdv1;
        private TabPageAdv tabPageAdv1;
        private TabPageAdv tabPageAdv2;
        private TabPageAdv tabPageAdv3;
        private TabPageAdv tabPageAdv4;
        private GradientPanel gradientPanel1;
        private IContainer components;
        private TabPageAdv tabPageAdv5;
        private ComboBoxAdv comboBoxAdv1;
        private Label label2;
        private GradientLabel gradientLabel2;
        private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel datePanel;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
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
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.textBox1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.gradientLabel2 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.radioButton3 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton1 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton2 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.radioButton5 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton4 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.tabPageAdv3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.radioButton7 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton6 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.tabPageAdv4 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.textBox2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.button2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.tabPageAdv5 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.statusBarAdv3 = new Syncfusion.Windows.Forms.Tools.StatusBarAdv();
            this.customPanel = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.statusBarAdvPanel11 = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.timePanel = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.keyPanel = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.datePanel = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton2)).BeginInit();
            this.tabPageAdv2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton4)).BeginInit();
            this.tabPageAdv3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton6)).BeginInit();
            this.tabPageAdv4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).BeginInit();
            this.tabPageAdv5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdv3)).BeginInit();
            this.statusBarAdv3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePanel)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "statusBarPanel1";
            // 
            // button1
            // 
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(56, 27);
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IsBackStageButton = false;
            this.button1.Location = new System.Drawing.Point(0, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyle = true;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BeforeTouchSize = new System.Drawing.Size(160, 29);
            this.textBox1.BorderColor = System.Drawing.Color.Empty;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(58, 2);
            this.textBox1.Metrocolor = System.Drawing.Color.Empty;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1132, 55);
            this.textBox1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "textBox";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.gradientPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.tabControlAdv1);
            this.gradientPanel1.Location = new System.Drawing.Point(293, 123);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(584, 412);
            this.gradientPanel1.TabIndex = 11;
            // 
            // gradientLabel2
            // 
            this.gradientLabel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.Transparent);
            this.gradientLabel2.BeforeTouchSize = new System.Drawing.Size(1132, 73);
            this.gradientLabel2.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel2.Location = new System.Drawing.Point(13, 10);
            this.gradientLabel2.Name = "gradientLabel2";
            this.gradientLabel2.Size = new System.Drawing.Size(1132, 73);
            this.gradientLabel2.TabIndex = 15;
            this.gradientLabel2.Text = "\r\nThe StatusBarAdv is an advanced status bar control that can display status-bar " +
    "panels with enhanced backgrounds and appearances.\r\n\r\n\r\n";
            this.gradientLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(582, 410);
            this.tabControlAdv1.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv3);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv4);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv5);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv1.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.tabControlAdv1.ShowSeparator = false;
            this.tabControlAdv1.Size = new System.Drawing.Size(582, 410);
            this.tabControlAdv1.TabIndex = 10;
            this.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.White;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageAdv1.Controls.Add(this.radioButton3);
            this.tabPageAdv1.Controls.Add(this.radioButton1);
            this.tabPageAdv1.Controls.Add(this.radioButton2);
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(1, 32);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(579, 376);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "KeyStatePanels";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // radioButton3
            // 
            this.radioButton3.BeforeTouchSize = new System.Drawing.Size(166, 35);
            this.radioButton3.DrawFocusRectangle = false;
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton3.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButton3.Location = new System.Drawing.Point(189, 260);
            this.radioButton3.MetroColor = System.Drawing.Color.Gray;
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(166, 35);
            this.radioButton3.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = false;
            this.radioButton3.Text = "Scroll Lock";
            this.radioButton3.ThemesEnabled = false;
            this.radioButton3.CheckChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.BeforeTouchSize = new System.Drawing.Size(166, 35);
            this.radioButton1.Checked = true;
            this.radioButton1.DrawFocusRectangle = false;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton1.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButton1.Location = new System.Drawing.Point(189, 106);
            this.radioButton1.MetroColor = System.Drawing.Color.Gray;
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(166, 35);
            this.radioButton1.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Caps Lock";
            this.radioButton1.ThemesEnabled = false;
            this.radioButton1.CheckChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.BeforeTouchSize = new System.Drawing.Size(166, 36);
            this.radioButton2.DrawFocusRectangle = false;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton2.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButton2.Location = new System.Drawing.Point(189, 177);
            this.radioButton2.MetroColor = System.Drawing.Color.Gray;
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(166, 36);
            this.radioButton2.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Num Lock";
            this.radioButton2.ThemesEnabled = false;
            this.radioButton2.CheckChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.Controls.Add(this.radioButton5);
            this.tabPageAdv2.Controls.Add(this.radioButton4);
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv2.Location = new System.Drawing.Point(1, 32);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(579, 376);
            this.tabPageAdv2.TabIndex = 2;
            this.tabPageAdv2.Text = "DatePanels";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // radioButton5
            // 
            this.radioButton5.BeforeTouchSize = new System.Drawing.Size(167, 35);
            this.radioButton5.DrawFocusRectangle = false;
            this.radioButton5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton5.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButton5.Location = new System.Drawing.Point(203, 195);
            this.radioButton5.MetroColor = System.Drawing.Color.Gray;
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(167, 35);
            this.radioButton5.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = false;
            this.radioButton5.Text = "Long Date";
            this.radioButton5.ThemesEnabled = false;
            this.radioButton5.CheckChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.BeforeTouchSize = new System.Drawing.Size(167, 35);
            this.radioButton4.Checked = true;
            this.radioButton4.DrawFocusRectangle = false;
            this.radioButton4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton4.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButton4.Location = new System.Drawing.Point(203, 116);
            this.radioButton4.MetroColor = System.Drawing.Color.Gray;
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(167, 35);
            this.radioButton4.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton4.TabIndex = 0;
            this.radioButton4.Text = "Short Date";
            this.radioButton4.ThemesEnabled = false;
            this.radioButton4.CheckChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // tabPageAdv3
            // 
            this.tabPageAdv3.Controls.Add(this.radioButton7);
            this.tabPageAdv3.Controls.Add(this.radioButton6);
            this.tabPageAdv3.Image = null;
            this.tabPageAdv3.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv3.Location = new System.Drawing.Point(1, 32);
            this.tabPageAdv3.Name = "tabPageAdv3";
            this.tabPageAdv3.ShowCloseButton = true;
            this.tabPageAdv3.Size = new System.Drawing.Size(579, 376);
            this.tabPageAdv3.TabIndex = 3;
            this.tabPageAdv3.Text = "TimePanels";
            this.tabPageAdv3.ThemesEnabled = false;
            // 
            // radioButton7
            // 
            this.radioButton7.BeforeTouchSize = new System.Drawing.Size(166, 35);
            this.radioButton7.DrawFocusRectangle = false;
            this.radioButton7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton7.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButton7.Location = new System.Drawing.Point(205, 208);
            this.radioButton7.MetroColor = System.Drawing.Color.Gray;
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(166, 35);
            this.radioButton7.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton7.TabIndex = 3;
            this.radioButton7.TabStop = false;
            this.radioButton7.Text = "Long Time";
            this.radioButton7.ThemesEnabled = false;
            this.radioButton7.CheckChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.BeforeTouchSize = new System.Drawing.Size(166, 35);
            this.radioButton6.Checked = true;
            this.radioButton6.DrawFocusRectangle = false;
            this.radioButton6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton6.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButton6.Location = new System.Drawing.Point(205, 119);
            this.radioButton6.MetroColor = System.Drawing.Color.Gray;
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(166, 35);
            this.radioButton6.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton6.TabIndex = 2;
            this.radioButton6.Text = "Short Time";
            this.radioButton6.ThemesEnabled = false;
            this.radioButton6.CheckChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // tabPageAdv4
            // 
            this.tabPageAdv4.Controls.Add(this.textBox2);
            this.tabPageAdv4.Controls.Add(this.button2);
            this.tabPageAdv4.Image = null;
            this.tabPageAdv4.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv4.Location = new System.Drawing.Point(1, 32);
            this.tabPageAdv4.Name = "tabPageAdv4";
            this.tabPageAdv4.ShowCloseButton = true;
            this.tabPageAdv4.Size = new System.Drawing.Size(579, 376);
            this.tabPageAdv4.TabIndex = 4;
            this.tabPageAdv4.Text = "CustomPanels";
            this.tabPageAdv4.ThemesEnabled = false;
            // 
            // textBox2
            // 
            this.textBox2.BeforeTouchSize = new System.Drawing.Size(160, 29);
            this.textBox2.BorderColor = System.Drawing.Color.Gray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Location = new System.Drawing.Point(216, 110);
            this.textBox2.Metrocolor = System.Drawing.Color.Gray;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 29);
            this.textBox2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Custom Panel";
            this.textBox2.ThemesEnabled = false;
            // 
            // button2
            // 
            this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button2.BeforeTouchSize = new System.Drawing.Size(120, 34);
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.IsBackStageButton = false;
            this.button2.Location = new System.Drawing.Point(235, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Set Text";
            this.button2.UseVisualStyle = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPageAdv5
            // 
            this.tabPageAdv5.Controls.Add(this.comboBoxAdv1);
            this.tabPageAdv5.Controls.Add(this.label2);
            this.tabPageAdv5.Image = null;
            this.tabPageAdv5.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv5.Location = new System.Drawing.Point(1, 32);
            this.tabPageAdv5.Name = "tabPageAdv5";
            this.tabPageAdv5.ShowCloseButton = true;
            this.tabPageAdv5.Size = new System.Drawing.Size(579, 376);
            this.tabPageAdv5.TabIndex = 5;
            this.tabPageAdv5.Text = "Visual Style";
            this.tabPageAdv5.ThemesEnabled = false;
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(165, 31);
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Default",
            "Metro",
            "Office2016Colorful",
            "Office2016White",
            "Office2016Black",
            "Office2016DarkGray"});
            this.comboBoxAdv1.Location = new System.Drawing.Point(205, 173);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(165, 31);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.comboBoxAdv1.TabIndex = 0;
            this.comboBoxAdv1.Text = "Default";
            this.comboBoxAdv1.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Visual Style";
            // 
            // statusBarAdv3
            // 
            this.statusBarAdv3.BeforeTouchSize = new System.Drawing.Size(1132, 49);
            this.statusBarAdv3.Border3DStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.statusBarAdv3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.statusBarAdv3.Controls.Add(this.customPanel);
            this.statusBarAdv3.Controls.Add(this.statusBarAdvPanel11);
            this.statusBarAdv3.Controls.Add(this.timePanel);
            this.statusBarAdv3.Controls.Add(this.keyPanel);
            this.statusBarAdv3.Controls.Add(this.datePanel);
            this.statusBarAdv3.CustomLayoutBounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.statusBarAdv3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBarAdv3.Location = new System.Drawing.Point(10, 609);
            this.statusBarAdv3.Name = "statusBarAdv3";
            this.statusBarAdv3.Padding = new System.Windows.Forms.Padding(3);
            this.statusBarAdv3.Size = new System.Drawing.Size(1132, 49);
            this.statusBarAdv3.Spacing = new System.Drawing.Size(2, 2);
            this.statusBarAdv3.TabIndex = 2;
            // 
            // customPanel
            // 
            this.customPanel.AnimationDirection = Syncfusion.Windows.Forms.Tools.MarqueeDirection.Right;
            this.customPanel.AnimationStyle = Syncfusion.Windows.Forms.Tools.MarqueeStyle.Slide;
            this.customPanel.BackColor = System.Drawing.Color.DarkGray;
            this.customPanel.BeforeTouchSize = new System.Drawing.Size(237, 41);
            this.customPanel.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.customPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.customPanel.IsMarquee = true;
            this.customPanel.Location = new System.Drawing.Point(0, 2);
            this.customPanel.Margin = new System.Windows.Forms.Padding(0);
            this.customPanel.Name = "customPanel";
            this.customPanel.Size = new System.Drawing.Size(237, 41);
            this.customPanel.TabIndex = 4;
            this.customPanel.Text = "Custom Panel";
            // 
            // statusBarAdvPanel11
            // 
            this.statusBarAdvPanel11.BackColor = System.Drawing.Color.DarkGray;
            this.statusBarAdvPanel11.BeforeTouchSize = new System.Drawing.Size(190, 41);
            this.statusBarAdvPanel11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.statusBarAdvPanel11.Location = new System.Drawing.Point(239, 2);
            this.statusBarAdvPanel11.Margin = new System.Windows.Forms.Padding(0);
            this.statusBarAdvPanel11.Name = "statusBarAdvPanel11";
            this.statusBarAdvPanel11.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.CurrentCulture;
            this.statusBarAdvPanel11.Size = new System.Drawing.Size(190, 41);
            this.statusBarAdvPanel11.TabIndex = 0;
            this.statusBarAdvPanel11.Text = "statusBarAdvPanel11";
            // 
            // timePanel
            // 
            this.timePanel.BackColor = System.Drawing.Color.DarkGray;
            this.timePanel.BeforeTouchSize = new System.Drawing.Size(185, 41);
            this.timePanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.timePanel.Location = new System.Drawing.Point(431, 2);
            this.timePanel.Margin = new System.Windows.Forms.Padding(0);
            this.timePanel.Name = "timePanel";
            this.timePanel.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.ShortTime;
            this.timePanel.Size = new System.Drawing.Size(185, 41);
            this.timePanel.TabIndex = 3;
            this.timePanel.Text = "statusBarAdvPanel1";
            // 
            // keyPanel
            // 
            this.keyPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.keyPanel.BeforeTouchSize = new System.Drawing.Size(255, 41);
            this.keyPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.keyPanel.Location = new System.Drawing.Point(618, 2);
            this.keyPanel.Margin = new System.Windows.Forms.Padding(0);
            this.keyPanel.Name = "keyPanel";
            this.keyPanel.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.CapsLockState;
            this.keyPanel.Size = new System.Drawing.Size(255, 41);
            this.keyPanel.TabIndex = 2;
            this.keyPanel.Text = "statusBarAdvPanel13";
            // 
            // datePanel
            // 
            this.datePanel.BackColor = System.Drawing.Color.DarkGray;
            this.datePanel.BeforeTouchSize = new System.Drawing.Size(236, 41);
            this.datePanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.datePanel.BorderSingle = System.Windows.Forms.ButtonBorderStyle.Dashed;
            this.datePanel.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify;
            this.datePanel.Location = new System.Drawing.Point(875, 2);
            this.datePanel.Margin = new System.Windows.Forms.Padding(0);
            this.datePanel.Name = "datePanel";
            this.datePanel.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.ShortDate;
            this.datePanel.PreferredSize = new System.Drawing.Size(65, 18);
            this.datePanel.Size = new System.Drawing.Size(236, 41);
            this.datePanel.TabIndex = 1;
            this.datePanel.Text = "statusBarAdvPanel12";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 22);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionButtonColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1152, 668);
            this.Controls.Add(this.gradientLabel2);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.statusBarAdv3);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatusBarAdv";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton2)).EndInit();
            this.tabPageAdv2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton4)).EndInit();
            this.tabPageAdv3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioButton7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton6)).EndInit();
            this.tabPageAdv4.ResumeLayout(false);
            this.tabPageAdv4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).EndInit();
            this.tabPageAdv5.ResumeLayout(false);
            this.tabPageAdv5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdv3)).EndInit();
            this.statusBarAdv3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePanel)).EndInit();
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

		void UpdatePanelSizeonResize()
        {
            var x = (this.Width / 2) - (this.gradientPanel1.Width / 2);
            var y = ((this.Height - (this.gradientLabel2.Height)) / 2) - (this.gradientPanel1.Height / 2);
            this.gradientPanel1.Location = new Point(x, y);
        }

		private void Form1_Load(object sender, System.EventArgs e)
		{
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.gradientLabel2.Dock = DockStyle.Top;
            this.Resize += Form1_Resize;
            UpdatePanelSizeonResize();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            UpdatePanelSizeonResize();
        }

        #region keyPanel
        private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton1.Checked) this.keyPanel.PanelType = StatusBarAdvPanelType.CapsLockState;
		}

		private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton2.Checked) this.keyPanel.PanelType = StatusBarAdvPanelType.NumLockState;
		}

		private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton3.Checked) this.keyPanel.PanelType = StatusBarAdvPanelType.ScrollLockState;
		}
		#endregion
		#region TimePanel
		private void radioButton6_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton6.Checked) this.timePanel.PanelType = StatusBarAdvPanelType.ShortTime;
		}

		private void radioButton7_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton7.Checked) this.timePanel.PanelType = StatusBarAdvPanelType.LongTime;
		}
		#endregion
		#region DatePanel
		private void radioButton4_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton4.Checked) this.datePanel.PanelType = StatusBarAdvPanelType.ShortDate;
		}

		private void radioButton5_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton5.Checked) this.datePanel.PanelType = StatusBarAdvPanelType.LongDate;
		}
		#endregion
		#region customPanel

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.customPanel.Text = this.textBox2.Text;
		}
        #endregion

        private void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAdv1.SelectedItem.ToString().Equals("Office2016White"))
            {
                this.statusBarAdv3.Style = StatusbarStyle.Office2016White;
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                this.customPanel.BackColor = ColorTranslator.FromHtml("#ababab");
                this.statusBarAdvPanel11.BackColor = ColorTranslator.FromHtml("#ababab");
                this.timePanel.BackColor = ColorTranslator.FromHtml("#ababab");
                this.keyPanel.BackColor = ColorTranslator.FromHtml("#ababab");
                this.datePanel.BackColor = ColorTranslator.FromHtml("#ababab");
                this.customPanel.ForeColor = ColorTranslator.FromHtml("#262626");
                this.ForeColor = ColorTranslator.FromHtml("#262626");
                this.keyPanel.ForeColor = ColorTranslator.FromHtml("#262626");
                this.timePanel.ForeColor = ColorTranslator.FromHtml("#262626");
                this.datePanel.ForeColor = ColorTranslator.FromHtml("#262626");
                this.statusBarAdvPanel11.ForeColor = Color.Black;
                this.button2.UseVisualStyle = true;
                this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016White;
                this.textBox2.Style = TextBoxExt.theme.Office2016White;
                this.CaptionButtonColor = ColorTranslator.FromHtml("#ada9a9");
                this.CaptionBarColor=this.MetroColor= Color.White;
                this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016White);
                this.BorderColor= ColorTranslator.FromHtml("#e1e1e1");
                this.CaptionForeColor = Color.Black;
                this.label2.ForeColor = Color.Black;
                this.gradientPanel1.BackColor = Color.White;
                this.comboBoxAdv1.Style = VisualStyle.Office2016White;
                this.radioButton1.Style = RadioButtonAdvStyle.Office2016White;
                this.radioButton2.Style = RadioButtonAdvStyle.Office2016White;
                this.radioButton3.Style = RadioButtonAdvStyle.Office2016White;
                this.radioButton4.Style = RadioButtonAdvStyle.Office2016White;
                this.radioButton5.Style = RadioButtonAdvStyle.Office2016White;
                this.radioButton6.Style = RadioButtonAdvStyle.Office2016White;
                this.radioButton7.Style = RadioButtonAdvStyle.Office2016White;
                this.gradientLabel2.BackColor = Color.White;
                this.gradientLabel2.BorderColor = Color.Gainsboro;

            }
            else if (comboBoxAdv1.SelectedItem.ToString().Equals("Default"))
            {
                this.statusBarAdv3.Style = StatusbarStyle.Default;
                this.BackColor = Color.White;
                this.customPanel.BackColor = Color.White;
                this.statusBarAdvPanel11.BackColor = Color.White;
                this.timePanel.BackColor = Color.White;
                this.keyPanel.BackColor = Color.White;
                this.datePanel.BackColor = Color.White;
                this.ForeColor = Color.Black;
                this.customPanel.ForeColor = Color.Black;
                this.keyPanel.ForeColor = Color.Black;
                this.timePanel.ForeColor = Color.Black;
                this.datePanel.ForeColor = Color.Black;
                this.statusBarAdvPanel11.ForeColor = Color.Black;
                this.textBox2.Style = TextBoxExt.theme.Default;
                this.button2.UseVisualStyle = true;
                this.button2.Appearance= Syncfusion.Windows.Forms.ButtonAppearance.Classic;
                this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRenderer2D);
                this.CaptionBarColor=this.MetroColor= Color.White;
                this.button2.UseVisualStyle = true;
                this.button2.Appearance = ButtonAppearance.Classic;
                this.radioButton1.Style = RadioButtonAdvStyle.Default;
                this.radioButton2.Style = RadioButtonAdvStyle.Default;
                this.radioButton3.Style = RadioButtonAdvStyle.Default;
                this.radioButton4.Style = RadioButtonAdvStyle.Default;
                this.radioButton5.Style = RadioButtonAdvStyle.Default;
                this.radioButton6.Style = RadioButtonAdvStyle.Default;
                this.radioButton7.Style = RadioButtonAdvStyle.Default;
                this.gradientPanel1.BackColor = Color.White;
                this.comboBoxAdv1.Style = VisualStyle.Default;
                this.CaptionForeColor = Color.Black;
                this.gradientLabel2.BackColor = Color.White;
                this.gradientLabel2.BorderColor = Color.Gainsboro;
            }

            else if (comboBoxAdv1.SelectedItem.ToString().Equals("Metro"))
            {
                this.statusBarAdv3.Style = StatusbarStyle.Metro;
                this.BackColor = Color.White;
                //this.customPanel.IgnoreThemeBackground = true;
                this.customPanel.BackColor = this.statusBarAdv3.MetroColor;
                this.statusBarAdvPanel11.BackColor = this.statusBarAdv3.MetroColor;
                this.timePanel.BackColor = this.statusBarAdv3.MetroColor;
                this.keyPanel.BackColor = this.statusBarAdv3.MetroColor;
                this.datePanel.BackColor = this.statusBarAdv3.MetroColor;
                this.statusBarAdvPanel11.ForeColor = Color.White;
                this.ForeColor = Color.Black;
                this.customPanel.ForeColor = Color.White;
                this.keyPanel.ForeColor = Color.White;
                this.timePanel.ForeColor = Color.White;
                this.datePanel.ForeColor = Color.White;
                this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
                this.textBox2.Style = TextBoxExt.theme.Metro;
                this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
                this.button2.UseVisualStyle = true;
                this.CaptionBarColor=this.MetroColor= Color.White;
                this.button2.UseVisualStyle = true;
                this.radioButton1.Style = RadioButtonAdvStyle.Metro;
                this.radioButton2.Style = RadioButtonAdvStyle.Metro;
                this.radioButton3.Style = RadioButtonAdvStyle.Metro;
                this.radioButton4.Style = RadioButtonAdvStyle.Metro;
                this.radioButton5.Style = RadioButtonAdvStyle.Metro;
                this.radioButton6.Style = RadioButtonAdvStyle.Metro;
                this.radioButton7.Style = RadioButtonAdvStyle.Metro;
                this.gradientPanel1.BackColor = Color.White;
                this.comboBoxAdv1.Style = VisualStyle.Metro;
                this.CaptionForeColor = Color.Black;
                this.gradientLabel2.BackColor = Color.White;
                this.gradientLabel2.BorderColor = Color.Gainsboro;
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2016Black"))
            {
                this.statusBarAdv3.Style = StatusbarStyle.Office2016Black;
                this.BackColor = ColorTranslator.FromHtml("#252525");
                this.ForeColor = Color.White;
                this.customPanel.BackColor = ColorTranslator.FromHtml("#5e5e5e");
                this.customPanel.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.statusBarAdvPanel11.BackColor = ColorTranslator.FromHtml("#5e5e5e");
                this.statusBarAdvPanel11.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.timePanel.BackColor = ColorTranslator.FromHtml("#5e5e5e");
                this.timePanel.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.keyPanel.BackColor = ColorTranslator.FromHtml("#5e5e5e");
                this.keyPanel.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.datePanel.BackColor = ColorTranslator.FromHtml("#5e5e5e");
                this.datePanel.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Black;
                this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Black);
                this.radioButton1.Style = RadioButtonAdvStyle.Office2016Black;
                this.radioButton2.Style = RadioButtonAdvStyle.Office2016Black;
                this.radioButton3.Style = RadioButtonAdvStyle.Office2016Black;
                this.radioButton4.Style = RadioButtonAdvStyle.Office2016Black;
                this.radioButton5.Style = RadioButtonAdvStyle.Office2016Black;
                this.radioButton6.Style = RadioButtonAdvStyle.Office2016Black;
                this.radioButton7.Style = RadioButtonAdvStyle.Office2016Black;
                this.gradientPanel1.BackColor= ColorTranslator.FromHtml("#252525");
                this.label2.ForeColor = Color.White;
                this.textBox2.Style = TextBoxExt.theme.Office2016Black;
                this.CaptionForeColor= ColorTranslator.FromHtml("#f0f0f0");
                this.CaptionButtonColor = ColorTranslator.FromHtml("#f0f0f0");
                this.BorderColor= ColorTranslator.FromHtml("#5e5e5e");
                this.CaptionBarColor=this.MetroColor= ColorTranslator.FromHtml("#363636");
                this.button2.UseVisualStyle = true;
                this.comboBoxAdv1.Style = VisualStyle.Office2016Black;
                this.gradientLabel2.BackColor = ColorTranslator.FromHtml("#252525");
                this.gradientLabel2.BorderColor = ColorTranslator.FromHtml("#d6cfcf");
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2016DarkGray"))
            {
                this.statusBarAdv3.Style = StatusbarStyle.Office2016DarkGray;
                this.BackColor = ColorTranslator.FromHtml("#666666");
                this.ForeColor = Color.Black;
                this.customPanel.BackColor = ColorTranslator.FromHtml("#444444");
                this.customPanel.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.statusBarAdvPanel11.BackColor = ColorTranslator.FromHtml("#444444");
                this.statusBarAdvPanel11.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.timePanel.BackColor = ColorTranslator.FromHtml("#444444");
                this.timePanel.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.keyPanel.BackColor = ColorTranslator.FromHtml("#444444");
                this.keyPanel.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.datePanel.BackColor = ColorTranslator.FromHtml("#444444");
                this.datePanel.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016DarkGray;
                this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016DarkGray);
                this.textBox2.Style = TextBoxExt.theme.Office2016DarkGray;
                this.CaptionButtonColor = ColorTranslator.FromHtml("#f0f0f0");
                this.CaptionBarColor = this.MetroColor = ColorTranslator.FromHtml("#505050");
                this.CaptionForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.BorderColor = ColorTranslator.FromHtml("#444444");
                this.gradientPanel1.BackColor = ColorTranslator.FromHtml("#505050");
                this.label2.ForeColor= ColorTranslator.FromHtml("#f0f0f0");
                this.radioButton1.Style = RadioButtonAdvStyle.Office2016DarkGray;
                this.radioButton2.Style = RadioButtonAdvStyle.Office2016DarkGray;
                this.radioButton3.Style = RadioButtonAdvStyle.Office2016DarkGray;
                this.radioButton4.Style = RadioButtonAdvStyle.Office2016DarkGray;
                this.radioButton5.Style = RadioButtonAdvStyle.Office2016DarkGray;
                this.radioButton6.Style = RadioButtonAdvStyle.Office2016DarkGray;
                this.radioButton7.Style = RadioButtonAdvStyle.Office2016DarkGray;
                this.button2.UseVisualStyle = true;
                this.comboBoxAdv1.Style = VisualStyle.Office2016DarkGray;
                this.gradientLabel2.BackColor = ColorTranslator.FromHtml("#505050");
                this.gradientLabel2.BorderColor = ColorTranslator.FromHtml("#b1c6b0");
                this.gradientLabel2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2016Colorful"))
            {
                this.statusBarAdv3.Style = StatusbarStyle.Office2016Colorful;
                this.BackColor = Color.White;
                this.CaptionBarColor = this.MetroColor = Color.White;
                this.customPanel.BackColor = ColorTranslator.FromHtml("#ababab");
                this.keyPanel.BackColor = ColorTranslator.FromHtml("#ababab");
                this.timePanel.BackColor = ColorTranslator.FromHtml("#ababab");
                this.datePanel.BackColor = ColorTranslator.FromHtml("#ababab");
                this.statusBarAdvPanel11.BackColor = ColorTranslator.FromHtml("#ababab");
                this.ForeColor = Color.Black;
                this.customPanel.ForeColor = ColorTranslator.FromHtml("#262626"); 
                this.keyPanel.ForeColor = ColorTranslator.FromHtml("#262626");
                this.timePanel.ForeColor = ColorTranslator.FromHtml("#262626");
                this.datePanel.ForeColor = ColorTranslator.FromHtml("#262626");
                this.statusBarAdvPanel11.ForeColor = ColorTranslator.FromHtml("#262626");
                this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
                this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Colorful);
                this.textBox2.Style = TextBoxExt.theme.Office2016Colorful;
                this.CaptionButtonColor = ColorTranslator.FromHtml("#ada9a9");
                this.BorderColor = ColorTranslator.FromHtml("#ababab");
                this.CaptionForeColor = Color.Black;
                this.label2.ForeColor = Color.Black;
                this.gradientPanel1.BackColor = Color.White;
                this.radioButton1.Style = RadioButtonAdvStyle.Office2016Colorful;
                this.radioButton2.Style = RadioButtonAdvStyle.Office2016Colorful;
                this.radioButton3.Style = RadioButtonAdvStyle.Office2016Colorful;
                this.radioButton4.Style = RadioButtonAdvStyle.Office2016Colorful;
                this.radioButton5.Style = RadioButtonAdvStyle.Office2016Colorful;
                this.radioButton6.Style = RadioButtonAdvStyle.Office2016Colorful;
                this.radioButton7.Style = RadioButtonAdvStyle.Office2016Colorful;
                this.button2.UseVisualStyle = true;
                this.comboBoxAdv1.Style = VisualStyle.Office2016Colorful;
                this.gradientLabel2.BackColor = Color.White;
                this.gradientLabel2.BorderColor = Color.Gainsboro;
            }
        }

        private void textBoxExt1_TextChanged(object sender, EventArgs e)
        {

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
