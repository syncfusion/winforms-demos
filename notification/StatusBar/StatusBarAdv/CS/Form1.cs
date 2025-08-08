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
using Syncfusion.WinForms.Controls;
using System.Globalization;
using System.Collections.Generic;
using Syncfusion.WinForms.ListView;

namespace StatusBarAdvDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : SfForm
	{
        private System.Windows.Forms.StatusStrip statusBarPanel1;
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
		private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel customPanel;
        private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel keyPanel;
        private GradientPanel gradientPanel1;
        private IContainer components;
        private SfComboBox comboBoxAdv1;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private BannerTextProvider bannerTextProvider1;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private SplitButton splitButton1;
        private toolstripitem toolstripitem1;
        private toolstripitem toolstripitem2;
        private ProgressBarAdv progressBarAdv1;
        private Timer timer1;
        private toolstripitem toolstripitem3;
        private CheckBoxAdv checkBoxAdv1;
        private Label label8;
        private SplitButton splitButton2;
        private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel datePanel;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            }
            this.MinimumSize = this.Size;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sficon.ico"));
                this.Icon = ico;
            }
            catch { }
            SkinManager.SetVisualStyle(this, "Office2019Colorful");
            this.splitButton1.ThemeName = "Office2019Colorful";
            this.gradientPanel1.ThemeStyle.BackColor = Color.White;
            this.gradientPanel1.BorderStyle = BorderStyle.None;
            foreach (StatusBarAdvPanel item in statusBarAdv3.Panels)
            {
                item.BorderStyle = BorderStyle.None;
                item.ThemeStyle.BorderColor = ColorTranslator.FromHtml("#f3f3f3");
            }
            PopulateComboBox();
            this.label7.Text = CultureInfo.CurrentCulture.DisplayName;
            this.radioButton1.Checked = this.keyPanel.PanelType == StatusBarAdvPanelType.CapsLockState;
            this.radioButton4.Checked = true;
            this.radioButton6.Checked = true;
            this.label8.Text = "Loading..";
            this.checkBoxAdv1.Checked = this.statusBarAdv3.SizingGrip;
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
            Syncfusion.Windows.Forms.Tools.Office2016WhiteSplitButtonRenderer office2016WhiteSplitButtonRenderer1 = new Syncfusion.Windows.Forms.Tools.Office2016WhiteSplitButtonRenderer();
            Syncfusion.Windows.Forms.Tools.SplitButtonRenderer splitButtonRenderer1 = new Syncfusion.Windows.Forms.Tools.SplitButtonRenderer();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitButton1 = new Syncfusion.Windows.Forms.Tools.SplitButton();
            this.toolstripitem1 = new Syncfusion.Windows.Forms.Tools.toolstripitem();
            this.toolstripitem2 = new Syncfusion.Windows.Forms.Tools.toolstripitem();
            this.toolstripitem3 = new Syncfusion.Windows.Forms.Tools.toolstripitem();
            this.splitButton2 = new Syncfusion.Windows.Forms.Tools.SplitButton();
            this.statusBarPanel1 = new System.Windows.Forms.StatusStrip();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.textBox1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton7 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton6 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton5 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton4 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton3 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton1 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton2 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAdv1 = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusBarAdv3 = new Syncfusion.Windows.Forms.Tools.StatusBarAdv();
            this.customPanel = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.progressBarAdv1 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.keyPanel = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.datePanel = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.timePanel = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.statusBarAdvPanel11 = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton6)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdv3)).BeginInit();
            this.statusBarAdv3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel11)).BeginInit();
            this.SuspendLayout();
            // 
            // splitButton1
            // 
            this.splitButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.splitButton1.BeforeTouchSize = new System.Drawing.Size(100, 32);
            this.splitButton1.DropDownIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.splitButton1.DropDownItems.Add(this.toolstripitem1);
            this.splitButton1.DropDownItems.Add(this.toolstripitem2);
            this.splitButton1.DropDownItems.Add(this.toolstripitem3);
            this.splitButton1.DropDownPosition = Syncfusion.Windows.Forms.Tools.Position.Bottom;
            this.splitButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.splitButton1.Location = new System.Drawing.Point(0, 2);
            this.splitButton1.MinimumSize = new System.Drawing.Size(75, 23);
            this.splitButton1.Name = "splitButton1";
            this.splitButton1.Renderer = office2016WhiteSplitButtonRenderer1;
            this.splitButton1.ShowDropDownOnButtonClick = false;
            this.splitButton1.Size = new System.Drawing.Size(100, 32);
            this.splitButton1.Style = Syncfusion.Windows.Forms.Tools.SplitButtonVisualStyle.Office2016White;
            this.splitButton1.TabIndex = 7;
            this.splitButton1.Text = "Show All";
            this.splitButton1.ThemeName = "Office2016White";
            this.splitButton1.DropDowItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.splitButton1_DropDowItemClicked);
            this.splitButton1.Click += new System.EventHandler(this.splitButton1_Click);
            // 
            // toolstripitem1
            // 
            this.toolstripitem1.Name = "toolstripitem1";
            this.toolstripitem1.Size = new System.Drawing.Size(23, 23);
            this.toolstripitem1.Text = "Show All";
            // 
            // toolstripitem2
            // 
            this.toolstripitem2.Name = "toolstripitem2";
            this.toolstripitem2.Size = new System.Drawing.Size(23, 23);
            this.toolstripitem2.Text = "Show Range";
            // 
            // toolstripitem3
            // 
            this.toolstripitem3.Name = "toolstripitem3";
            this.toolstripitem3.Size = new System.Drawing.Size(23, 23);
            this.toolstripitem3.Text = "Refresh";
            // 
            // splitButton2
            // 
            this.splitButton2.BackColor = System.Drawing.SystemColors.Control;
            this.splitButton2.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.splitButton2.DropDownItems.Add(this.toolstripitem1);
            this.splitButton2.DropDownItems.Add(this.toolstripitem2);
            this.splitButton2.DropDownPosition = Syncfusion.Windows.Forms.Tools.Position.Bottom;
            this.splitButton2.ForeColor = System.Drawing.Color.Black;
            this.splitButton2.Location = new System.Drawing.Point(0, 0);
            this.splitButton2.MinimumSize = new System.Drawing.Size(75, 23);
            this.splitButton2.Name = "splitButton2";
            this.splitButton2.Renderer = splitButtonRenderer1;
            this.splitButton2.ShowDropDownOnButtonClick = false;
            this.splitButton2.Size = new System.Drawing.Size(75, 23);
            this.splitButton2.TabIndex = 0;
            this.splitButton2.Text = "Show All";
            this.splitButton2.ThemeName = "Default";
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
            this.button1.ThemeName = "Metro";
            this.button1.UseVisualStyle = true;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BeforeTouchSize = new System.Drawing.Size(1132, 55);
            this.textBox1.BorderColor = System.Drawing.Color.Empty;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(58, 2);
            this.textBox1.Metrocolor = System.Drawing.Color.Empty;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1132, 55);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "textBox";
            this.textBox1.ThemeName = "Default";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.AutoSize = true;
            this.gradientPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.gradientPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.checkBoxAdv1);
            this.gradientPanel1.Controls.Add(this.label8);
            this.gradientPanel1.Controls.Add(this.panel3);
            this.gradientPanel1.Controls.Add(this.panel2);
            this.gradientPanel1.Controls.Add(this.label7);
            this.gradientPanel1.Controls.Add(this.label6);
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Controls.Add(this.label5);
            this.gradientPanel1.Controls.Add(this.label4);
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.comboBoxAdv1);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1062, 453);
            this.gradientPanel1.TabIndex = 11;
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxAdv1.Location = new System.Drawing.Point(41, 356);
            this.checkBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(150, 21);
            this.checkBoxAdv1.TabIndex = 14;
            this.checkBoxAdv1.Text = "Show Gripper";
            this.checkBoxAdv1.ThemesEnabled = false;
            this.checkBoxAdv1.CheckedChanged += new System.EventHandler(this.checkBoxAdv1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label8.Location = new System.Drawing.Point(164, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "label8";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButton7);
            this.panel3.Controls.Add(this.radioButton6);
            this.panel3.Location = new System.Drawing.Point(151, 135);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(332, 40);
            this.panel3.TabIndex = 11;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.BeforeTouchSize = new System.Drawing.Size(72, 16);
            this.radioButton7.DrawFocusRectangle = false;
            this.radioButton7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton7.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButton7.Location = new System.Drawing.Point(116, 14);
            this.radioButton7.MetroColor = System.Drawing.Color.Gray;
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(72, 16);
            this.radioButton7.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton7.TabIndex = 3;
            this.radioButton7.TabStop = false;
            this.radioButton7.Text = "Long Time";
            this.radioButton7.ThemeName = "Metro";
            this.radioButton7.ThemesEnabled = false;
            this.radioButton7.CheckChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.BeforeTouchSize = new System.Drawing.Size(73, 16);
            this.radioButton6.Checked = true;
            this.radioButton6.DrawFocusRectangle = false;
            this.radioButton6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton6.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButton6.Location = new System.Drawing.Point(13, 14);
            this.radioButton6.MetroColor = System.Drawing.Color.Gray;
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(73, 16);
            this.radioButton6.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton6.TabIndex = 2;
            this.radioButton6.Text = "Short Time";
            this.radioButton6.ThemeName = "Metro";
            this.radioButton6.ThemesEnabled = false;
            this.radioButton6.CheckChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton5);
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Location = new System.Drawing.Point(151, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 43);
            this.panel2.TabIndex = 11;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.BeforeTouchSize = new System.Drawing.Size(72, 16);
            this.radioButton5.DrawFocusRectangle = false;
            this.radioButton5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton5.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButton5.Location = new System.Drawing.Point(116, 13);
            this.radioButton5.MetroColor = System.Drawing.Color.Gray;
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(72, 16);
            this.radioButton5.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = false;
            this.radioButton5.Text = "Long Date";
            this.radioButton5.ThemeName = "Metro";
            this.radioButton5.ThemesEnabled = false;
            this.radioButton5.CheckChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.BeforeTouchSize = new System.Drawing.Size(73, 16);
            this.radioButton4.DrawFocusRectangle = false;
            this.radioButton4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton4.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButton4.Location = new System.Drawing.Point(13, 13);
            this.radioButton4.MetroColor = System.Drawing.Color.Gray;
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(73, 16);
            this.radioButton4.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = false;
            this.radioButton4.Text = "Short Date";
            this.radioButton4.ThemeName = "Metro";
            this.radioButton4.ThemesEnabled = false;
            this.radioButton4.CheckChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label7.Location = new System.Drawing.Point(164, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label6.Location = new System.Drawing.Point(41, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Custom panel ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Location = new System.Drawing.Point(151, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 45);
            this.panel1.TabIndex = 10;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BeforeTouchSize = new System.Drawing.Size(75, 16);
            this.radioButton3.DrawFocusRectangle = false;
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton3.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButton3.Location = new System.Drawing.Point(218, 25);
            this.radioButton3.MetroColor = System.Drawing.Color.Gray;
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(75, 16);
            this.radioButton3.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = false;
            this.radioButton3.Text = "Scroll Lock";
            this.radioButton3.ThemeName = "Metro";
            this.radioButton3.ThemesEnabled = false;
            this.radioButton3.CheckChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BeforeTouchSize = new System.Drawing.Size(73, 16);
            this.radioButton1.DrawFocusRectangle = false;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton1.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButton1.Location = new System.Drawing.Point(12, 25);
            this.radioButton1.MetroColor = System.Drawing.Color.Gray;
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 16);
            this.radioButton1.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = false;
            this.radioButton1.Text = "Caps Lock";
            this.radioButton1.ThemeName = "Metro";
            this.radioButton1.ThemesEnabled = false;
            this.radioButton1.CheckChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BeforeTouchSize = new System.Drawing.Size(71, 16);
            this.radioButton2.DrawFocusRectangle = false;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton2.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButton2.Location = new System.Drawing.Point(114, 25);
            this.radioButton2.MetroColor = System.Drawing.Color.Gray;
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 16);
            this.radioButton2.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = false;
            this.radioButton2.Text = "Num Lock";
            this.radioButton2.ThemeName = "Metro";
            this.radioButton2.ThemesEnabled = false;
            this.radioButton2.CheckChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label5.Location = new System.Drawing.Point(41, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Current culture panel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label4.Location = new System.Drawing.Point(41, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Time panel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label3.Location = new System.Drawing.Point(41, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date panel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(41, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Keys state panel";
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxAdv1.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.comboBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBoxAdv1.Location = new System.Drawing.Point(164, 308);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(150, 25);
            this.comboBoxAdv1.Style.EditorStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxAdv1.Style.EditorStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.Style.EditorStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBoxAdv1.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.TabIndex = 0;
            this.comboBoxAdv1.Text = "Office2019Colorful";
            this.comboBoxAdv1.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label2.Location = new System.Drawing.Point(41, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Visual Style";
            // 
            // statusBarAdv3
            // 
            this.statusBarAdv3.BeforeTouchSize = new System.Drawing.Size(1062, 40);
            this.statusBarAdv3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.statusBarAdv3.Controls.Add(this.splitButton1);
            this.statusBarAdv3.Controls.Add(this.customPanel);
            this.statusBarAdv3.Controls.Add(this.progressBarAdv1);
            this.statusBarAdv3.Controls.Add(this.keyPanel);
            this.statusBarAdv3.Controls.Add(this.datePanel);
            this.statusBarAdv3.Controls.Add(this.timePanel);
            this.statusBarAdv3.Controls.Add(this.statusBarAdvPanel11);
            this.statusBarAdv3.CustomLayoutBounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.statusBarAdv3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBarAdv3.Location = new System.Drawing.Point(0, 453);
            this.statusBarAdv3.Name = "statusBarAdv3";
            this.statusBarAdv3.Size = new System.Drawing.Size(1062, 40);
            this.statusBarAdv3.Spacing = new System.Drawing.Size(2, 2);
            this.statusBarAdv3.TabIndex = 2;
            this.statusBarAdv3.ThemeName = "Default";
            // 
            // customPanel
            // 
            this.customPanel.AnimationDirection = Syncfusion.Windows.Forms.Tools.MarqueeDirection.Right;
            this.customPanel.AnimationStyle = Syncfusion.Windows.Forms.Tools.MarqueeStyle.Slide;
            this.customPanel.BeforeTouchSize = new System.Drawing.Size(57, 32);
            this.customPanel.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.customPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.customPanel.IsMarquee = true;
            this.customPanel.Location = new System.Drawing.Point(102, 2);
            this.customPanel.Margin = new System.Windows.Forms.Padding(0);
            this.customPanel.Name = "customPanel";
            this.customPanel.Size = new System.Drawing.Size(57, 32);
            this.customPanel.TabIndex = 4;
            this.customPanel.Text = "Loading..";
            // 
            // progressBarAdv1
            // 
            this.progressBarAdv1.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv1.BackSegments = false;
            this.progressBarAdv1.CustomText = null;
            this.progressBarAdv1.CustomWaitingRender = false;
            this.progressBarAdv1.ForegroundImage = null;
            this.progressBarAdv1.Location = new System.Drawing.Point(161, 2);
            this.progressBarAdv1.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv1.Name = "progressBarAdv1";
            this.progressBarAdv1.SegmentWidth = 12;
            this.progressBarAdv1.Size = new System.Drawing.Size(308, 32);
            this.progressBarAdv1.TabIndex = 6;
            this.progressBarAdv1.Text = "progressBarAdv1";
            this.progressBarAdv1.TextShadow = false;
            this.progressBarAdv1.ThemesEnabled = false;
            this.progressBarAdv1.Value = 0;
            this.progressBarAdv1.WaitingGradientWidth = 400;
            // 
            // keyPanel
            // 
            this.keyPanel.BeforeTouchSize = new System.Drawing.Size(115, 32);
            this.keyPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.keyPanel.Location = new System.Drawing.Point(471, 2);
            this.keyPanel.Margin = new System.Windows.Forms.Padding(0);
            this.keyPanel.Name = "keyPanel";
            this.keyPanel.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.CapsLockState;
            this.keyPanel.Size = new System.Drawing.Size(115, 32);
            this.keyPanel.TabIndex = 2;
            this.keyPanel.Text = "statusBarAdvPanel13";
            // 
            // datePanel
            // 
            this.datePanel.BeforeTouchSize = new System.Drawing.Size(193, 32);
            this.datePanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.datePanel.BorderSingle = System.Windows.Forms.ButtonBorderStyle.Dashed;
            this.datePanel.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify;
            this.datePanel.Location = new System.Drawing.Point(588, 2);
            this.datePanel.Margin = new System.Windows.Forms.Padding(0);
            this.datePanel.Name = "datePanel";
            this.datePanel.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.ShortDate;
            this.datePanel.PreferredSize = new System.Drawing.Size(65, 18);
            this.datePanel.Size = new System.Drawing.Size(193, 32);
            this.datePanel.TabIndex = 1;
            this.datePanel.Text = "statusBarAdvPanel12";
            // 
            // timePanel
            // 
            this.timePanel.BeforeTouchSize = new System.Drawing.Size(131, 32);
            this.timePanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.timePanel.Location = new System.Drawing.Point(783, 2);
            this.timePanel.Margin = new System.Windows.Forms.Padding(0);
            this.timePanel.Name = "timePanel";
            this.timePanel.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.ShortTime;
            this.timePanel.Size = new System.Drawing.Size(131, 32);
            this.timePanel.TabIndex = 3;
            this.timePanel.Text = "statusBarAdvPanel1";
            // 
            // statusBarAdvPanel11
            // 
            this.statusBarAdvPanel11.BeforeTouchSize = new System.Drawing.Size(125, 32);
            this.statusBarAdvPanel11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.statusBarAdvPanel11.Location = new System.Drawing.Point(916, 2);
            this.statusBarAdvPanel11.Margin = new System.Windows.Forms.Padding(0);
            this.statusBarAdvPanel11.Name = "statusBarAdvPanel11";
            this.statusBarAdvPanel11.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.CurrentCulture;
            this.statusBarAdvPanel11.Size = new System.Drawing.Size(125, 32);
            this.statusBarAdvPanel11.TabIndex = 0;
            this.statusBarAdvPanel11.Text = "statusBarAdvPanel11";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1062, 493);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.statusBarAdv3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatusBarAdv";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioButton7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton6)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton4)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdv3)).EndInit();
            this.statusBarAdv3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel11)).EndInit();
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
            SkinManager.LoadAssembly(typeof(Syncfusion.WinForms.Themes.Office2019Theme).Assembly);
            SkinManager.LoadAssembly(typeof(Syncfusion.WinForms.Themes.Office2016Theme).Assembly);
            SkinManager.LoadAssembly(typeof(Syncfusion.HighContrastTheme.WinForms.HighContrastTheme).Assembly);
            Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
            this.timer1.Tick += Timer1_Tick;
            this.timer1.Enabled = true;
        }


        private void PopulateComboBox()
        {
            List<string> comboStyle = new List<string> {
            "Office2019Colorful",
            "HighContrastBlack",
            "Office2016Colorful",
            "Office2016White",
            "Office2016DarkGray",
            "Office2016Black"};
            this.comboBoxAdv1.AllowDropDownResize = false;
            this.comboBoxAdv1.DataSource = comboStyle;
            this.comboBoxAdv1.SelectedIndex = 0;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (progressBarAdv1.Value < 100)
                progressBarAdv1.Value++;
            else
            {
                this.timer1.Stop();
                this.customPanel.Text =this.label8.Text= "Loaded";
            }
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
	
        private void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SkinManager.SetVisualStyle(this, comboBoxAdv1.SelectedItem.ToString());
            if (comboBoxAdv1.SelectedItem.ToString().Equals("Office2016White"))
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                this.label2.ForeColor = Color.Black;
                this.gradientPanel1.BackColor = Color.White;
                this.Style.TitleBar.ForeColor = this.Style.TitleBar.CloseButtonForeColor = this.Style.TitleBar.MinimizeButtonForeColor = this.Style.TitleBar.MaximizeButtonForeColor = Color.Black;
                this.Style.TitleBar.BackColor = Color.FromArgb(242, 242, 242);
                this.label1.ForeColor = Color.Black;
                this.label2.ForeColor = Color.Black;
                this.label3.ForeColor = Color.Black;
                this.label4.ForeColor = Color.Black;
                this.label5.ForeColor = Color.Black;
                this.label6.ForeColor = Color.Black;
                this.label7.ForeColor = Color.Black;
                this.label8.ForeColor = Color.Black;
                this.Icon = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sficon.ico"));
            }
            else if (comboBoxAdv1.SelectedItem.ToString().Equals("Office2019Colorful"))
            {
                this.label7.Text = CultureInfo.CurrentCulture.DisplayName;
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                this.label1.ForeColor = Color.FromArgb(68, 68, 68);
                this.label2.ForeColor = Color.FromArgb(68, 68, 68);
                this.label3.ForeColor = Color.FromArgb(68, 68, 68);
                this.label4.ForeColor = Color.FromArgb(68, 68, 68);
                this.label5.ForeColor = Color.FromArgb(68, 68, 68);
                this.label6.ForeColor = Color.FromArgb(68, 68, 68);
                this.label7.ForeColor = Color.FromArgb(68, 68, 68);
                this.label8.ForeColor = Color.FromArgb(68, 68, 68);
                this.gradientPanel1.ThemeStyle.BackColor = Color.White;
                this.gradientPanel1.BorderColor = Color.FromArgb(210, 210, 210);
                this.Style.TitleBar.ForeColor = this.Style.TitleBar.CloseButtonForeColor= this.Style.TitleBar.MinimizeButtonForeColor = this.Style.TitleBar.MaximizeButtonForeColor = Color.Black;
                this.Style.TitleBar.BackColor = Color.FromArgb(242, 242, 242);
                this.Icon = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sficon.ico"));
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2016Black"))
            {
                this.BackColor = ColorTranslator.FromHtml("#252525");
                this.ForeColor = Color.White;
                this.label1.ForeColor = Color.White;
                this.label2.ForeColor = Color.White;
                this.label3.ForeColor = Color.White;
                this.label4.ForeColor = Color.White;
                this.label5.ForeColor = Color.White;
                this.label6.ForeColor = Color.White;
                this.label7.ForeColor = Color.White;
                this.label8.ForeColor = Color.White;
                this.gradientPanel1.BackColor = ColorTranslator.FromHtml("#252525");
                this.label2.ForeColor = Color.White;
                this.Style.TitleBar.ForeColor = this.Style.TitleBar.CloseButtonForeColor = this.Style.TitleBar.MinimizeButtonForeColor = this.Style.TitleBar.MaximizeButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Style.TitleBar.BackColor = ColorTranslator.FromHtml("#363636");
                this.gradientPanel1.BorderColor = ColorTranslator.FromHtml("#5e5e5e");
                this.Icon = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString().Equals("HighContrastBlack"))
            {
                this.BackColor = ColorTranslator.FromHtml("#252525");
                this.ForeColor = Color.White;
                this.label1.ForeColor = Color.White;
                this.label2.ForeColor = Color.White;
                this.label3.ForeColor = Color.White;
                this.label4.ForeColor = Color.White;
                this.label5.ForeColor = Color.White;
                this.label6.ForeColor = Color.White;
                this.label7.ForeColor = Color.White;
                this.label8.ForeColor = Color.White;
                this.gradientPanel1.ThemeStyle.BackColor = Color.Black;
                this.label2.ForeColor = Color.White;
                this.Style.TitleBar.ForeColor = this.Style.TitleBar.CloseButtonForeColor = this.Style.TitleBar.MinimizeButtonForeColor = this.Style.TitleBar.MaximizeButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Style.TitleBar.BackColor = ColorTranslator.FromHtml("#363636");
                this.gradientPanel1.BorderColor = ColorTranslator.FromHtml("#ffffff");
                this.Icon = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2016DarkGray"))
            {
                this.BackColor = ColorTranslator.FromHtml("#666666");
                this.ForeColor = Color.Black;
                this.gradientPanel1.BackColor = ColorTranslator.FromHtml("#666666");
                this.label2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Style.TitleBar.ForeColor = this.Style.TitleBar.CloseButtonForeColor=this.Style.TitleBar.MinimizeButtonForeColor = this.Style.TitleBar.MaximizeButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Style.TitleBar.BackColor = ColorTranslator.FromHtml("#505050");
                this.gradientPanel1.BorderColor = ColorTranslator.FromHtml("#444444");
                this.label1.ForeColor = Color.White;
                this.label2.ForeColor = Color.White;
                this.label3.ForeColor = Color.White;
                this.label4.ForeColor = Color.White;
                this.label5.ForeColor = Color.White;
                this.label6.ForeColor = Color.White;
                this.label7.ForeColor = Color.White;
                this.label8.ForeColor = Color.White;
                this.Icon = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2016Colorful"))
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                this.label2.ForeColor = Color.Black;
                this.gradientPanel1.BackColor = Color.White;
                this.Style.TitleBar.ForeColor = this.Style.TitleBar.CloseButtonForeColor = this.Style.TitleBar.MinimizeButtonForeColor= this.Style.TitleBar.MaximizeButtonForeColor = Color.Black;
                this.Style.TitleBar.BackColor = Color.FromArgb(242, 242, 242);
                this.label1.ForeColor = Color.Black;
                this.label2.ForeColor = Color.Black;
                this.label3.ForeColor = Color.Black;
                this.label4.ForeColor = Color.Black;
                this.label5.ForeColor = Color.Black;
                this.label6.ForeColor = Color.Black;
                this.label7.ForeColor = Color.Black;
                this.label8.ForeColor = Color.Black;
                this.Icon = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sficon.ico"));
            }
        }

        private void splitButton1_DropDowItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.customPanel.Text = this.label8.Text = "Loading..";
            this.progressBarAdv1.Value = 0;
            this.timer1.Start();
        }

        private void splitButton1_Click(object sender, EventArgs e)
        {
            this.progressBarAdv1.Value = 0;
            this.customPanel.Text = this.label8.Text = "Loading..";
            this.timer1.Start();
        }

        private void checkBoxAdv1_CheckedChanged(object sender, EventArgs e)
        {
            this.statusBarAdv3.SizingGrip = this.checkBoxAdv1.Checked;
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
