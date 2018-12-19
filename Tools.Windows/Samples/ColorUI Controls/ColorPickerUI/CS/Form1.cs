#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using System.Collections.Generic;
using Syncfusion.Licensing;
using System.IO;

namespace ColorUIDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ImageList imageList1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBox1;
		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbSelectedColorGroup;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbSelectedColorGroup1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label15;
        private Syncfusion.Windows.Forms.ButtonAdv btnShowColorGroups;
		private System.Windows.Forms.Label label19;
		private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDownExt1;
		private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDownExt2;
		private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDownExt3;
        private Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv colorPickerUIAdv1;
        private Panel panel3;
        private SplitContainerAdv splitContainerAdv1;
        private ComboBoxAdv ComboBoxAdv2;
        private Label label16;
        private ComboBoxAdv comboBoxAdv1;
        private Label label4;
        private ComboBoxAdv cmbOffice2007Theme;
        private System.ComponentModel.IContainer components;

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

            this.SizeChanged += Form1_SizeChanged;
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

        void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.colorPickerUIAdv1.Location = new Point((this.splitContainerAdv1.Panel1.Width / 2 - this.colorPickerUIAdv1.Width / 2), (this.splitContainerAdv1.Panel1.Height / 2 - this.colorPickerUIAdv1.Height / 2)); 
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.colorPickerUIAdv1 = new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownExt3 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.numericUpDownExt2 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.numericUpDownExt1 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.label19 = new System.Windows.Forms.Label();
            this.btnShowColorGroups = new Syncfusion.Windows.Forms.ButtonAdv();
            this.ComboBoxAdv2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSelectedColorGroup = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cmbSelectedColorGroup1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.cmbOffice2007Theme = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectedColorGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectedColorGroup1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOffice2007Theme)).BeginInit();
            this.SuspendLayout();
            // 
            // colorPickerUIAdv1.RecentGroup
            // 
            this.colorPickerUIAdv1.RecentGroup.HeaderHeight = 19;
            this.colorPickerUIAdv1.RecentGroup.Name = "Recent Colors";
            this.colorPickerUIAdv1.RecentGroup.Visible = false;
            // 
            // colorPickerUIAdv1.StandardGroup
            // 
            this.colorPickerUIAdv1.StandardGroup.HeaderHeight = 19;
            this.colorPickerUIAdv1.StandardGroup.Name = "Standard Colors";
            // 
            // colorPickerUIAdv1.ThemeGroup
            // 
            this.colorPickerUIAdv1.ThemeGroup.HeaderHeight = 19;
            this.colorPickerUIAdv1.ThemeGroup.IsSubItemsVisible = true;
            this.colorPickerUIAdv1.ThemeGroup.Name = "Theme Colors";
            // 
            // colorPickerUIAdv1
            // 
            this.colorPickerUIAdv1.BeforeTouchSize = new System.Drawing.Size(13, 13);
            this.colorPickerUIAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPickerUIAdv1.ButtonsHeight = 27;
            this.colorPickerUIAdv1.ColorItemSize = new System.Drawing.Size(13, 13);
            this.colorPickerUIAdv1.HorizontalItemsSpacing = 9;
            this.colorPickerUIAdv1.Location = new System.Drawing.Point(38, 35);
            this.colorPickerUIAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.colorPickerUIAdv1.MinimumSize = new System.Drawing.Size(136, 195);
            this.colorPickerUIAdv1.Name = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.SelectedColor = System.Drawing.Color.Empty;
            this.colorPickerUIAdv1.Size = new System.Drawing.Size(217, 211);
            this.colorPickerUIAdv1.Style = Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.visualstyle.Office2016DarkGray;
            this.colorPickerUIAdv1.TabIndex = 4;
            this.colorPickerUIAdv1.Text = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.UseOffice2007Style = false;
            this.colorPickerUIAdv1.Picked += new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventHandler(this.colorPickerUIAdv1_Picked);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(622, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "The new ColorPickerUIAdv is an advanced color palette control that shows custom g" +
    "roup color palettes, Office2007 theme settings and an easy to use UI for color s" +
    "election.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // textBox1
            // 
            this.textBox1.BeforeTouchSize = new System.Drawing.Size(624, 116);
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(20, 390);
            this.textBox1.Metrocolor = System.Drawing.Color.Empty;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(624, 116);
            this.textBox1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBox1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxAdv1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numericUpDownExt3);
            this.panel1.Controls.Add(this.numericUpDownExt2);
            this.panel1.Controls.Add(this.numericUpDownExt1);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.btnShowColorGroups);
            this.panel1.Controls.Add(this.ComboBoxAdv2);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 289);
            this.panel1.TabIndex = 1;
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(124, 21);
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Enabled = false;
            this.comboBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Blue",
            "Black",
            "Silver"});
            this.comboBoxAdv1.Location = new System.Drawing.Point(164, 257);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(124, 21);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.TabIndex = 14;
            this.comboBoxAdv1.Text = "Blue";
            this.comboBoxAdv1.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(59, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Office2010Theme";
            // 
            // numericUpDownExt3
            // 
            this.numericUpDownExt3.BackColor = System.Drawing.Color.White;
            this.numericUpDownExt3.BeforeTouchSize = new System.Drawing.Size(125, 22);
            this.numericUpDownExt3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDownExt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt3.Location = new System.Drawing.Point(165, 172);
            this.numericUpDownExt3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDownExt3.Name = "numericUpDownExt3";
            this.numericUpDownExt3.Size = new System.Drawing.Size(125, 22);
            this.numericUpDownExt3.TabIndex = 12;
            this.numericUpDownExt3.ThemedBorder = false;
            this.numericUpDownExt3.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownExt3.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.numericUpDownExt3.ValueChanged += new System.EventHandler(this.numericUpDownExt3_ValueChanged);
            // 
            // numericUpDownExt2
            // 
            this.numericUpDownExt2.BackColor = System.Drawing.Color.White;
            this.numericUpDownExt2.BeforeTouchSize = new System.Drawing.Size(124, 22);
            this.numericUpDownExt2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDownExt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt2.Location = new System.Drawing.Point(166, 127);
            this.numericUpDownExt2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDownExt2.Name = "numericUpDownExt2";
            this.numericUpDownExt2.Size = new System.Drawing.Size(124, 22);
            this.numericUpDownExt2.TabIndex = 11;
            this.numericUpDownExt2.ThemedBorder = false;
            this.numericUpDownExt2.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.numericUpDownExt2.ValueChanged += new System.EventHandler(this.numericUpDownExt2_ValueChanged);
            // 
            // numericUpDownExt1
            // 
            this.numericUpDownExt1.BackColor = System.Drawing.Color.White;
            this.numericUpDownExt1.BeforeTouchSize = new System.Drawing.Size(124, 22);
            this.numericUpDownExt1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDownExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt1.Location = new System.Drawing.Point(166, 82);
            this.numericUpDownExt1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDownExt1.Name = "numericUpDownExt1";
            this.numericUpDownExt1.Size = new System.Drawing.Size(124, 22);
            this.numericUpDownExt1.TabIndex = 10;
            this.numericUpDownExt1.ThemedBorder = false;
            this.numericUpDownExt1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownExt1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.numericUpDownExt1.ValueChanged += new System.EventHandler(this.numericUpDownExt1_ValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(59, 172);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 13);
            this.label19.TabIndex = 9;
            this.label19.Text = "Button Height";
            // 
            // btnShowColorGroups
            // 
            this.btnShowColorGroups.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016DarkGray;
            this.btnShowColorGroups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.btnShowColorGroups.BeforeTouchSize = new System.Drawing.Size(117, 23);
            this.btnShowColorGroups.IsBackStageButton = false;
            this.btnShowColorGroups.KeepFocusRectangle = false;
            this.btnShowColorGroups.Location = new System.Drawing.Point(164, 31);
            this.btnShowColorGroups.Name = "btnShowColorGroups";
            this.btnShowColorGroups.Size = new System.Drawing.Size(117, 23);
            this.btnShowColorGroups.TabIndex = 8;
            this.btnShowColorGroups.Text = "Show Color Groups";
            this.btnShowColorGroups.UseVisualStyle = true;
            this.btnShowColorGroups.UseVisualStyleBackColor = true;
            this.btnShowColorGroups.Click += new System.EventHandler(this.btnShowColorGroups_Click);
            // 
            // ComboBoxAdv2
            // 
            this.ComboBoxAdv2.BackColor = System.Drawing.Color.White;
            this.ComboBoxAdv2.BeforeTouchSize = new System.Drawing.Size(125, 21);
            this.ComboBoxAdv2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxAdv2.Enabled = false;
            this.ComboBoxAdv2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxAdv2.Items.AddRange(new object[] {
            "Default",
            "Office2010",
            "Metro",
            "Office2016Colorful",
            "Office2016DarkGray",
            "Office2016Black",
            "Office2016White"});
            this.ComboBoxAdv2.Location = new System.Drawing.Point(165, 216);
            this.ComboBoxAdv2.Name = "ComboBoxAdv2";
            this.ComboBoxAdv2.Size = new System.Drawing.Size(125, 21);
            this.ComboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.ComboBoxAdv2.TabIndex = 7;
            this.ComboBoxAdv2.Text = "Default";
            this.ComboBoxAdv2.SelectedIndexChanged += new System.EventHandler(this.cmbOffice2007Theme_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(59, 216);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Style";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(59, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Vertical Spacing";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Horizontal Spacing";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Essential Properties";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSelectedColorGroup
            // 
            this.cmbSelectedColorGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.cmbSelectedColorGroup.BeforeTouchSize = new System.Drawing.Size(121, 21);
            this.cmbSelectedColorGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectedColorGroup.Location = new System.Drawing.Point(164, 251);
            this.cmbSelectedColorGroup.Name = "cmbSelectedColorGroup";
            this.cmbSelectedColorGroup.Size = new System.Drawing.Size(121, 21);
            this.cmbSelectedColorGroup.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.cmbSelectedColorGroup.TabIndex = 9;
            // 
            // cmbSelectedColorGroup1
            // 
            this.cmbSelectedColorGroup1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.cmbSelectedColorGroup1.BeforeTouchSize = new System.Drawing.Size(121, 21);
            this.cmbSelectedColorGroup1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectedColorGroup1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectedColorGroup1.Location = new System.Drawing.Point(168, 176);
            this.cmbSelectedColorGroup1.Name = "cmbSelectedColorGroup1";
            this.cmbSelectedColorGroup1.Size = new System.Drawing.Size(121, 21);
            this.cmbSelectedColorGroup1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.cmbSelectedColorGroup1.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(20, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(624, 57);
            this.panel3.TabIndex = 5;
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerAdv1.BeforeTouchSize = 7;
            this.splitContainerAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerAdv1.Location = new System.Drawing.Point(20, 92);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.Controls.Add(this.colorPickerUIAdv1);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.Controls.Add(this.panel1);
            this.splitContainerAdv1.Size = new System.Drawing.Size(621, 291);
            this.splitContainerAdv1.SplitterDistance = 295;
            this.splitContainerAdv1.TabIndex = 6;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            // 
            // cmbOffice2007Theme
            // 
            this.cmbOffice2007Theme.BackColor = System.Drawing.Color.White;
            this.cmbOffice2007Theme.BeforeTouchSize = new System.Drawing.Size(116, 21);
            this.cmbOffice2007Theme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOffice2007Theme.Enabled = false;
            this.cmbOffice2007Theme.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOffice2007Theme.Items.AddRange(new object[] {
            "Default",
            "Office2007",
            "Office2010",
            "Office2016Colorful",
            "Office2016White",
            "Office2016Black",
            "Office2016DarkGray",
            "Metro"});
            this.cmbOffice2007Theme.Location = new System.Drawing.Point(165, 216);
            this.cmbOffice2007Theme.Name = "cmbOffice2007Theme";
            this.cmbOffice2007Theme.Size = new System.Drawing.Size(116, 21);
            this.cmbOffice2007Theme.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmbOffice2007Theme.TabIndex = 7;
            this.cmbOffice2007Theme.Text = "Default";
            this.cmbOffice2007Theme.SelectedIndexChanged += new System.EventHandler(this.cmbOffice2007Theme_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 526);
            this.Controls.Add(this.splitContainerAdv1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(676, 562);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColorPickerUIAdv";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectedColorGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectedColorGroup1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbOffice2007Theme)).EndInit();
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
            Application.Run(new Form1());
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


        #region FormLoad

        Panel panel2 = new Panel();
        Panel panel4 = new Panel();
        private void Form1_Load(object sender, System.EventArgs e)
		{
			this.ComboBoxAdv2.SelectedIndex=3;
            this.ComboBoxAdv2.Enabled = true;
            this.colorPickerUIAdv1.MetroColor = ColorTranslator.FromHtml("#16A5DC");
            this.colorPickerUIAdv1.MoreColorsButton.BackColor = Color.White;
            this.colorPickerUIAdv1.BorderStyle = BorderStyle.FixedSingle;
            this.colorPickerUIAdv1.BorderOffset = 7;
            this.splitContainerAdv1.BorderStyle = BorderStyle.None;
            this.splitContainerAdv1.Panel1.Controls.Add(this.panel2);       

            this.panel2.Dock = DockStyle.Fill;
            this.panel2.Paint += Panel2_Paint;
            this.panel1.Paint += Panel1_Paint;
            this.label1.BorderStyle = BorderStyle.None;
            this.panel3.BorderStyle = BorderStyle.None;
            this.label1.Paint += Label1_Paint;
            this.textBox1.BorderColor = ColorTranslator.FromHtml("#c6c6c6");
            this.colorPickerUIAdv1.SizeChanged += ColorPickerUIAdv1_SizeChanged;
        }

        private void ColorPickerUIAdv1_SizeChanged(object sender, EventArgs e)
        {
            this.colorPickerUIAdv1.Location = new Point((this.splitContainerAdv1.Panel1.Width / 2 - this.colorPickerUIAdv1.Width / 2), (this.splitContainerAdv1.Panel1.Height / 2 - this.colorPickerUIAdv1.Height / 2));
        }

        private void Label1_Paint(object sender, PaintEventArgs e)
        {
            if (this.colorPickerUIAdv1.Style == ColorPickerUIAdv.visualstyle.Office2016DarkGray)
                ControlPaint.DrawBorder(e.Graphics, this.label1.DisplayRectangle, ColorTranslator.FromHtml("#444444"), ButtonBorderStyle.Solid);
            else if (this.colorPickerUIAdv1.Style == ColorPickerUIAdv.visualstyle.Office2016Black)
                ControlPaint.DrawBorder(e.Graphics, this.label1.DisplayRectangle, ColorTranslator.FromHtml("#444444"), ButtonBorderStyle.Solid);
            else if (this.colorPickerUIAdv1.Style == ColorPickerUIAdv.visualstyle.Office2016Colorful || this.colorPickerUIAdv1.Style == ColorPickerUIAdv.visualstyle.Office2016White)
                ControlPaint.DrawBorder(e.Graphics, this.label1.DisplayRectangle, ColorTranslator.FromHtml("#c6c6c6"), ButtonBorderStyle.Solid);
            else
                ControlPaint.DrawBorder(e.Graphics, this.label1.ClientRectangle, Color.Gray, ButtonBorderStyle.Solid);
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            if (this.colorPickerUIAdv1.Style == ColorPickerUIAdv.visualstyle.Office2016DarkGray)
                ControlPaint.DrawBorder(e.Graphics, this.panel2.DisplayRectangle, ColorTranslator.FromHtml("#444444"), ButtonBorderStyle.Solid);
            else if (this.colorPickerUIAdv1.Style == ColorPickerUIAdv.visualstyle.Office2016Black)
                ControlPaint.DrawBorder(e.Graphics, this.panel2.DisplayRectangle, ColorTranslator.FromHtml("#444444"), ButtonBorderStyle.Solid);
            else if (this.colorPickerUIAdv1.Style == ColorPickerUIAdv.visualstyle.Office2016Colorful || this.colorPickerUIAdv1.Style == ColorPickerUIAdv.visualstyle.Office2016White)
                ControlPaint.DrawBorder(e.Graphics, this.panel2.DisplayRectangle, ColorTranslator.FromHtml("#c6c6c6"), ButtonBorderStyle.Solid);
            else
                ControlPaint.DrawBorder(e.Graphics, this.panel2.ClientRectangle, Color.Gray, ButtonBorderStyle.Solid);
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            if (this.colorPickerUIAdv1.Style == ColorPickerUIAdv.visualstyle.Office2016DarkGray)
                ControlPaint.DrawBorder(e.Graphics, this.panel1.DisplayRectangle, ColorTranslator.FromHtml("#444444"), ButtonBorderStyle.Solid);
            else if (this.colorPickerUIAdv1.Style == ColorPickerUIAdv.visualstyle.Office2016Black)
                ControlPaint.DrawBorder(e.Graphics, this.panel1.DisplayRectangle, ColorTranslator.FromHtml("#444444"), ButtonBorderStyle.Solid);
            else if (this.colorPickerUIAdv1.Style == ColorPickerUIAdv.visualstyle.Office2016Colorful || this.colorPickerUIAdv1.Style == ColorPickerUIAdv.visualstyle.Office2016White)
                ControlPaint.DrawBorder(e.Graphics, this.panel1.DisplayRectangle, ColorTranslator.FromHtml("#c6c6c6"), ButtonBorderStyle.Solid);
            else
                ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.Gray, ButtonBorderStyle.Solid);
        }

        #endregion

        #region EventLog

        private void Addlog(string logText)
		{
			this.textBox1.Text += logText +"\r\n";
		}
		#endregion

		#region ColorPickerUIAdv properties


		private void cmbOffice2007Theme_SelectedIndexChanged(object sender, System.EventArgs e)
		{
            this.comboBoxAdv1.Enabled = false;
            this.label4.Enabled = false;
            this.UpdateStyle(Color.White, Color.Black);
            this.CaptionForeColor = Color.Black;
            this.CaptionButtonColor = Color.Black;
            this.CaptionBarColor = Color.White;
            this.MetroColor = Color.White;
            this.btnShowColorGroups.Appearance = ButtonAppearance.Metro;
            this.CaptionButtonHoverColor = Color.Black;
            foreach (Control ctrl in Collect(this.Controls))
            {
                if (ctrl is ComboBoxAdv)
                {
                    (ctrl as ComboBoxAdv).BackColor = Color.White;
                    (ctrl as ComboBoxAdv).ForeColor = Color.Black;
                    (ctrl as ComboBoxAdv).FlatBorderColor = Color.Black;
                    (ctrl as ComboBoxAdv).Style = VisualStyle.Metro;
                }
                else if (ctrl is NumericUpDownExt)
                {
                    (ctrl as NumericUpDownExt).VisualStyle = VisualStyle.Office2016White;
                }
            }
            switch (this.ComboBoxAdv2.Text)
			{
				case "Default":
					this.colorPickerUIAdv1.Style = ColorPickerUIAdv.visualstyle.Default;
					break;
				case "Office2010":
                    this.colorPickerUIAdv1.Style = ColorPickerUIAdv.visualstyle.Office2010;
                    this.label4.Enabled = true;
                    this.comboBoxAdv1.Enabled = true;
                    break;
                case "Office2016Colorful":
                    this.colorPickerUIAdv1.Style = ColorPickerUIAdv.visualstyle.Office2016Colorful;
                    this.MetroColor = ColorTranslator.FromHtml("#0173c7");
                    this.CaptionBarColor = Color.White;
                    this.CaptionForeColor = Color.Black;
                    this.CaptionButtonColor = Color.Black;
                    this.CaptionButtonHoverColor = Color.Black;
                    this.textBox1.Style = TextBoxExt.theme.Office2016Colorful;
                    this.textBox1.BorderColor = ColorTranslator.FromHtml("#c6c6c6");
                    this.btnShowColorGroups.Appearance = ButtonAppearance.Office2016Colorful;
                    foreach (Control ctrl in Collect(this.Controls))
                    {
                        if (ctrl is ComboBoxAdv)
                        {
                            (ctrl as ComboBoxAdv).Style = VisualStyle.Office2016Colorful;
                        }
                        else if (ctrl is NumericUpDownExt)
                        {
                            (ctrl as NumericUpDownExt).VisualStyle = VisualStyle.Office2016Colorful;
                        }
                    }
                    break;
                case "Office2016White":
                    this.colorPickerUIAdv1.Style = ColorPickerUIAdv.visualstyle.Office2016White;                   
                    foreach (Control ctrl in Collect(this.Controls))
                    {
                        if (ctrl is ComboBoxAdv)
                        {
                            (ctrl as ComboBoxAdv).Style = VisualStyle.Office2016White;
                        }
                        else if (ctrl is NumericUpDownExt)
                        {
                            (ctrl as NumericUpDownExt).VisualStyle = VisualStyle.Office2016White;
                        }
                    }
                    this.textBox1.BorderColor = ColorTranslator.FromHtml("#c6c6c6");
                    this.textBox1.Style = TextBoxExt.theme.Office2016White;
                    this.btnShowColorGroups.Appearance = ButtonAppearance.Office2016White;
                    this.CaptionButtonColor = Color.Black;
                    this.CaptionButtonHoverColor = Color.Black;
                    break;
                case "Office2016Black":
                    this.colorPickerUIAdv1.Style = ColorPickerUIAdv.visualstyle.Office2016Black;
                    this.UpdateStyle(ColorTranslator.FromHtml("#262626"), Color.White);
                    this.CaptionForeColor = Color.White;
                    this.CaptionButtonColor = Color.White;
                    this.CaptionButtonHoverColor = Color.White;
                    this.CaptionBarColor = ColorTranslator.FromHtml("#363636");
                    this.MetroColor = ColorTranslator.FromHtml("#363636");
                    this.textBox1.BorderColor = ColorTranslator.FromHtml("#444444");
                    this.textBox1.Style = TextBoxExt.theme.Office2016Black;
                    
                    foreach (Control ctrl in Collect(this.Controls))
                    {
                        if (ctrl is ComboBoxAdv)
                        {
                            (ctrl as ComboBoxAdv).Style = VisualStyle.Office2016Black;
                        }
                        else if (ctrl is NumericUpDownExt)
                        {
                            (ctrl as NumericUpDownExt).VisualStyle = VisualStyle.Office2016Black;
                        }
                    }
                    this.btnShowColorGroups.Appearance = ButtonAppearance.Office2016Black;
                    break;
                case "Office2016DarkGray":
                    this.colorPickerUIAdv1.Style = ColorPickerUIAdv.visualstyle.Office2016DarkGray;
                    this.UpdateStyle(ColorTranslator.FromHtml("#666666"), ColorTranslator.FromHtml("#000000"));
                    this.CaptionBarColor = ColorTranslator.FromHtml("#505050");
                    this.MetroColor = ColorTranslator.FromHtml("#505050");
                    this.CaptionForeColor = Color.White;
                    this.CaptionButtonColor = Color.White;
                    this.CaptionButtonHoverColor = Color.White;
                    this.textBox1.BorderColor = ColorTranslator.FromHtml("#444444");
                 
                    foreach (Control ctrl in Collect(this.Controls))
                    {
                        if (ctrl is ComboBoxAdv)
                        {
                            (ctrl as ComboBoxAdv).Style = VisualStyle.Office2016DarkGray;
                        }
                        else if (ctrl is NumericUpDownExt)
                        {
                            (ctrl as NumericUpDownExt).VisualStyle = VisualStyle.Office2016DarkGray;
                        }
                    }

                    this.textBox1.Style = TextBoxExt.theme.Office2016DarkGray;
                    this.btnShowColorGroups.Appearance = ButtonAppearance.Office2016DarkGray;


                    break;
                case "Metro":
                    this.colorPickerUIAdv1.UseOffice2007Style = false;
                    this.colorPickerUIAdv1.MetroColor = ColorTranslator.FromHtml("#16A5DC");
                    this.colorPickerUIAdv1.Style = ColorPickerUIAdv.visualstyle.Metro;
                    this.MetroColor = Color.White;
                    break;
            }

			Addlog("ColorPickerUIAdv's style set to "+this.colorPickerUIAdv1.Style.ToString());
		}

		private void btnShowColorGroups_Click(object sender, System.EventArgs e)
		{
			new ColorGroup(this.colorPickerUIAdv1).ShowDialog();
            this.Refresh();
		}


		private void numericUpDownExt1_ValueChanged(object sender, System.EventArgs e)
		{
			this.colorPickerUIAdv1.HorizontalItemsSpacing = (int)this.numericUpDownExt1.Value;
			Addlog("ColorPickerUIAdv's HorizontalItemsSpacing set to "+this.numericUpDownExt1.Value.ToString());
		}

		private void numericUpDownExt2_ValueChanged(object sender, System.EventArgs e)
		{
			this.colorPickerUIAdv1.VerticalItemsSpacing = (int)this.numericUpDownExt2.Value;
			Addlog("ColorPickerUIAdv's VerticalItemsSpacing set to "+this.numericUpDownExt2.Value.ToString());
		}

		private void numericUpDownExt3_ValueChanged(object sender, System.EventArgs e)
		{
			this.colorPickerUIAdv1.ButtonsHeight = (int)this.numericUpDownExt3.Value;
			Addlog("ColorPickerUIAdv's ButtonsHeight set to "+this.numericUpDownExt3.Value.ToString());
		}

		private void colorPickerUIAdv1_Picked(object sender, Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventArgs args)
		{
			this.splitContainerAdv1.Panel1.BackColor = this.colorPickerUIAdv1.SelectedItem.Color;
            this.splitContainerAdv1.Panel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo( this.colorPickerUIAdv1.SelectedItem.Color);
            Addlog("ColorPickerUIAdv is Setting TabPage BackColor to "+this.colorPickerUIAdv1.SelectedItem.Color.ToString());
		}

        #endregion

        private void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBoxAdv1.Text)
            {
                case "Blue":
                    this.colorPickerUIAdv1.Office2010Theme = Syncfusion.Windows.Forms.Office2010Theme.Blue;
                    break;
                case "Black":
                    this.colorPickerUIAdv1.Office2010Theme = Syncfusion.Windows.Forms.Office2010Theme.Black;
                    break;
                case "Silver":
                    this.colorPickerUIAdv1.Office2010Theme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
                    break;
            }
            Addlog("ColorPickerUIAdv's Office2007Theme set to " + this.colorPickerUIAdv1.Office2007Theme.ToString());
        }

        private void UpdateStyle(Color backColor, Color ForeColor)
        {
            this.BackColor = backColor;

            foreach (Control ctrl in Collect(this.Controls))
            {
                if (!(ctrl is GroupBar))
                {
                    ctrl.BackColor = backColor;
                    ctrl.ForeColor = ForeColor;
                }
                if (ctrl is ComboBoxAdv)
                {
                    (ctrl as ComboBoxAdv).Style = VisualStyle.Metro;
                    //(ctrl as ComboBoxAdv).ForeColor = Color.Black;
                }
            }
            foreach (Control ctrl in Collect(this.Controls))
            {
                if (ctrl is NumericUpDownExt)
                {
                    (ctrl as NumericUpDownExt).VisualStyle = VisualStyle.Metro;
                    (ctrl as NumericUpDownExt).ForeColor = Color.Black;
                }
            }
        }

        IEnumerable<Control> Collect(Form.ControlCollection ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                yield return ctrl;

                foreach (var child in Collect(ctrl.Controls))
                    yield return child;
            }
        }

        IEnumerable<Control> Collect(Control.ControlCollection ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                yield return ctrl;

                foreach (var child in Collect(ctrl.Controls))
                    yield return child;
            }
        }
    }
}
