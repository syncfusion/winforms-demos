#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Tools;
using System.Drawing;
namespace RadialMenuDemo
{
    partial class RadialMenuMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadialMenuMainForm));
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable1 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable2 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable3 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable4 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable5 = new Syncfusion.Windows.Forms.MetroColorTable();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.panel1 = new RadialMenuDemo.Panels();
            this.groupBox1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.numericUpDown2 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBox3 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.radialMenu1 = new Syncfusion.Windows.Forms.Tools.RadialMenu();
            this.radialMenuItem1 = new Syncfusion.Windows.Forms.Tools.RadialMenuItem();
            this.radialMenuItem2 = new Syncfusion.Windows.Forms.Tools.RadialMenuItem();
            this.radialMenuItem3 = new Syncfusion.Windows.Forms.Tools.RadialMenuItem();
            this.radialMenuItem4 = new Syncfusion.Windows.Forms.Tools.RadialMenuItem();
            this.radialMenuItem5 = new Syncfusion.Windows.Forms.Tools.RadialMenuItem();
            this.radialMenuSlider1 = new Syncfusion.Windows.Forms.Tools.RadialMenuSlider();
            this.radialColorPalette1 = new Syncfusion.Windows.Forms.Tools.RadialColorPalette();
            this.radialFontListBox1 = new Syncfusion.Windows.Forms.Tools.RadialFontListBox();
            this.radialMenuItem6 = new Syncfusion.Windows.Forms.Tools.RadialMenuItem();
            this.radialMenuItem7 = new Syncfusion.Windows.Forms.Tools.RadialMenuItem();
            this.radialMenuItem8 = new Syncfusion.Windows.Forms.Tools.RadialMenuItem();
            this.radialMenuItem9 = new Syncfusion.Windows.Forms.Tools.RadialMenuItem();
            this.radialMenuItem10 = new Syncfusion.Windows.Forms.Tools.RadialMenuItem();
            this.radialMenuItem11 = new Syncfusion.Windows.Forms.Tools.RadialMenuItem();
            this.radialMenuItem12 = new Syncfusion.Windows.Forms.Tools.RadialMenuItem();
            this.radialMenuItem13 = new Syncfusion.Windows.Forms.Tools.RadialMenuItem();
            this.radialMenuItem14 = new Syncfusion.Windows.Forms.Tools.RadialMenuItem();
            this.radialMenuItem15 = new Syncfusion.Windows.Forms.Tools.RadialMenuItem();
            this.radialMenuItem16 = new Syncfusion.Windows.Forms.Tools.RadialMenuItem();
            this.scrollersFrame = new Syncfusion.Windows.Forms.ScrollersFrame(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageListAdv1 = new Syncfusion.Windows.Forms.Tools.ImageListAdv(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.radialMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(151)))), ((int)(((byte)(217)))));
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Controls.Add(this.richTextBox1);
            this.gradientPanel1.Controls.Add(this.radialMenu1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(4, 12);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Padding = new System.Windows.Forms.Padding(15);
            this.gradientPanel1.Size = new System.Drawing.Size(1436, 912);
            this.gradientPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1098, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 899);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.groupBox1.Location = new System.Drawing.Point(3, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 640);
            this.groupBox1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.checkBox1.BeforeTouchSize = new System.Drawing.Size(202, 23);
            this.checkBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.DrawFocusRectangle = false;
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.checkBox1.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.checkBox1.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.checkBox1.Location = new System.Drawing.Point(30, 462);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(202, 23);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.ThemeName = "Office2016Colorful";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.label4.Location = new System.Drawing.Point(26, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Visual Style";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox1.BeforeTouchSize = new System.Drawing.Size(188, 28);
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBox1.Items.AddRange(new object[] {
            "Office2016 Colorful",
            "Office2016 Black",
            "Office2016 White",
            "Office2016 Dark Gray"});
            this.comboBox1.Location = new System.Drawing.Point(187, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 28);
            this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Text = "Office2016 Colorful";
            this.comboBox1.ThemeName = "Office2016Colorful";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BeforeTouchSize = new System.Drawing.Size(105, 26);
            this.numericUpDown2.Location = new System.Drawing.Point(187, 310);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(105, 26);
            this.numericUpDown2.TabIndex = 8;
            this.numericUpDown2.ThemeName = "Office2019Colorful";
            this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.label1.Location = new System.Drawing.Point(26, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Start Angle";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox2.BeforeTouchSize = new System.Drawing.Size(188, 28);
            this.comboBox2.FlatStyle = Syncfusion.Windows.Forms.Tools.ComboFlatStyle.Flat;
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBox2.Items.AddRange(new object[] {
            "TextAboveImage",
            "ImageAboveText",
            "Text",
            "Image"});
            this.comboBox2.Location = new System.Drawing.Point(187, 150);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(188, 28);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.Text = "TextAboveImage";
            this.comboBox2.ThemeName = "Office2016Colorful";
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox3.BeforeTouchSize = new System.Drawing.Size(188, 28);
            this.comboBox3.FlatStyle = Syncfusion.Windows.Forms.Tools.ComboFlatStyle.Flat;
            this.comboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBox3.Items.AddRange(new object[] {
            "16,16",
            "24,24",
            "28,28"});
            this.comboBox3.Location = new System.Drawing.Point(187, 392);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(118, 28);
            this.comboBox3.TabIndex = 9;
            this.comboBox3.SelectedIndex = 1;
            this.comboBox3.ThemeName = "Office2016Colorful";

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.label2.Location = new System.Drawing.Point(26, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Display Style";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.label3.Location = new System.Drawing.Point(26, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wedge Count\r\n";
            // 
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.label5.Location = new System.Drawing.Point(30, 392);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Image Size";

            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BeforeTouchSize = new System.Drawing.Size(105, 26);
            this.numericUpDown1.Location = new System.Drawing.Point(187, 228);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(105, 26);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.ThemeName = "Office2019Colorful";
            this.numericUpDown1.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(42, 28);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(980, 860);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseUp);
            // 
            // radialMenu1
            // 
            this.radialMenu1.Controls.Add(this.radialMenuItem1);
            this.radialMenu1.Controls.Add(this.radialMenuSlider1);
            this.radialMenu1.Controls.Add(this.radialColorPalette1);
            this.radialMenu1.Controls.Add(this.radialFontListBox1);
            this.radialMenu1.Controls.Add(this.radialMenuItem6);
            this.radialMenu1.Controls.Add(this.radialMenuItem13);
            this.radialMenu1.Items.Add(this.radialMenuItem1);
            this.radialMenu1.Items.Add(this.radialMenuSlider1);
            this.radialMenu1.Items.Add(this.radialColorPalette1);
            this.radialMenu1.Items.Add(this.radialFontListBox1);
            this.radialMenu1.Items.Add(this.radialMenuItem6);
            this.radialMenu1.Items.Add(this.radialMenuItem13);
            this.radialMenu1.Location = new System.Drawing.Point(39, 97);
            this.radialMenu1.MaximumSize = new System.Drawing.Size(700, 700);
            this.radialMenu1.MinimumSize = new System.Drawing.Size(150, 150);
            this.radialMenu1.Name = "radialMenu1";
            this.radialMenu1.OuterRimThickness = 28;
            this.radialMenu1.Size = new System.Drawing.Size(280, 280);
            this.radialMenu1.TabIndex = 2;
            this.radialMenu1.UseIndexBasedOrder = true;
            this.radialMenu1.Visible = false;
            this.radialMenu1.WedgeCount = 6;
            // 
            // radialMenuItem1
            // 
            this.radialMenuItem1.ImageIndex = 7;
            this.radialMenuItem1.Index = 0;
            this.radialMenuItem1.Items.Add(this.radialMenuItem2);
            this.radialMenuItem1.Items.Add(this.radialMenuItem3);
            this.radialMenuItem1.Items.Add(this.radialMenuItem4);
            this.radialMenuItem1.Items.Add(this.radialMenuItem5);
            this.radialMenuItem1.Location = new System.Drawing.Point(0, 0);
            this.radialMenuItem1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radialMenuItem1.Name = "radialMenuItem1";
            this.radialMenuItem1.Size = new System.Drawing.Size(0, 0);
            this.radialMenuItem1.TabIndex = 0;
            this.radialMenuItem1.Text = "Edit";
            // 
            // radialMenuItem2
            // 
            this.radialMenuItem2.ImageIndex = 2;
            this.radialMenuItem2.Index = 0;
            this.radialMenuItem2.Location = new System.Drawing.Point(0, 0);
            this.radialMenuItem2.Name = "radialMenuItem2";
            this.radialMenuItem2.Size = new System.Drawing.Size(0, 0);
            this.radialMenuItem2.TabIndex = 0;
            this.radialMenuItem2.Text = "Cut";
            this.radialMenuItem2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.radialMenuItem2_MouseUp);
            // 
            // radialMenuItem3
            // 
            this.radialMenuItem3.ImageIndex = 1;
            this.radialMenuItem3.Index = 1;
            this.radialMenuItem3.Location = new System.Drawing.Point(0, 0);
            this.radialMenuItem3.Name = "radialMenuItem3";
            this.radialMenuItem3.Size = new System.Drawing.Size(0, 0);
            this.radialMenuItem3.TabIndex = 0;
            this.radialMenuItem3.Text = "Copy";
            this.radialMenuItem3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.radialMenuItem3_MouseUp);
            // 
            // radialMenuItem4
            // 
            this.radialMenuItem4.ImageIndex = 4;
            this.radialMenuItem4.Index = 2;
            this.radialMenuItem4.Location = new System.Drawing.Point(0, 0);
            this.radialMenuItem4.Name = "radialMenuItem4";
            this.radialMenuItem4.Size = new System.Drawing.Size(0, 0);
            this.radialMenuItem4.TabIndex = 0;
            this.radialMenuItem4.Text = "Paste";
            this.radialMenuItem4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.radialMenuItem4_MouseUp);
            // 
            // radialMenuItem5
            // 
            this.radialMenuItem5.Enabled = false;
            this.radialMenuItem5.ImageIndex = 6;
            this.radialMenuItem5.Index = 3;
            this.radialMenuItem5.Location = new System.Drawing.Point(0, 0);
            this.radialMenuItem5.Name = "radialMenuItem5";
            this.radialMenuItem5.Size = new System.Drawing.Size(0, 0);
            this.radialMenuItem5.TabIndex = 0;
            this.radialMenuItem5.Text = "Undo";
            this.radialMenuItem5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.radialMenuItem5_MouseUp);
            // 
            // radialMenuSlider1
            // 
            this.radialMenuSlider1.ImageIndex = 5;
            this.radialMenuSlider1.Index = 3;
            this.radialMenuSlider1.Location = new System.Drawing.Point(0, 0);
            this.radialMenuSlider1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radialMenuSlider1.MaximumValue = 30;
            this.radialMenuSlider1.MinimumValue = 10;
            this.radialMenuSlider1.Name = "radialMenuSlider1";
            this.radialMenuSlider1.Size = new System.Drawing.Size(0, 0);
            this.radialMenuSlider1.SliderValue = 0D;
            this.radialMenuSlider1.TabIndex = 0;
            this.radialMenuSlider1.Text = "Size";
            this.radialMenuSlider1.SliderValueChanged += new Syncfusion.Windows.Forms.Tools.SliderValueChangedEventArgs(this.radialMenuSlider1_SliderValueChanged);
            // 
            // radialColorPalette1
            // 
            this.radialColorPalette1.ImageIndex = 0;
            this.radialColorPalette1.Index = 4;
            this.radialColorPalette1.Location = new System.Drawing.Point(0, 0);
            this.radialColorPalette1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radialColorPalette1.Name = "radialColorPalette1";
            this.radialColorPalette1.Size = new System.Drawing.Size(0, 0);
            this.radialColorPalette1.TabIndex = 0;
            this.radialColorPalette1.Text = "Color";
            this.radialColorPalette1.ColorPaletteColorChanged += new Syncfusion.Windows.Forms.Tools.ColorChanged(this.radialColorPalette1_ColorPaletteColorChanged);
            // 
            // radialFontListBox1
            // 
            this.radialFontListBox1.ImageIndex = 3;
            this.radialFontListBox1.Index = 5;
            this.radialFontListBox1.Location = new System.Drawing.Point(0, 0);
            this.radialFontListBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radialFontListBox1.Name = "radialFontListBox1";
            this.radialFontListBox1.Size = new System.Drawing.Size(0, 0);
            this.radialFontListBox1.TabIndex = 0;
            this.radialFontListBox1.Text = "Font";
            this.radialFontListBox1.RadialFontChanged += new Syncfusion.Windows.Forms.Tools.SelectedFontChanged(this.radialFontListBox1_RadialFontChanged);
            // 
            // radialMenuItem6
            // 
            this.radialMenuItem6.ImageIndex = 13;
            this.radialMenuItem6.Index = 1;
            this.radialMenuItem6.Items.Add(this.radialMenuItem7);
            this.radialMenuItem6.Items.Add(this.radialMenuItem8);
            this.radialMenuItem6.Items.Add(this.radialMenuItem9);
            this.radialMenuItem6.Items.Add(this.radialMenuItem10);
            this.radialMenuItem6.Items.Add(this.radialMenuItem11);
            this.radialMenuItem6.Items.Add(this.radialMenuItem12);
            this.radialMenuItem6.Location = new System.Drawing.Point(0, 0);
            this.radialMenuItem6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radialMenuItem6.Name = "radialMenuItem6";
            this.radialMenuItem6.Size = new System.Drawing.Size(0, 0);
            this.radialMenuItem6.TabIndex = 2;
            this.radialMenuItem6.Text = "List";
            // 
            // radialMenuItem7
            // 
            this.radialMenuItem7.ImageIndex = 8;
            this.radialMenuItem7.Index = 0;
            this.radialMenuItem7.Location = new System.Drawing.Point(0, 0);
            this.radialMenuItem7.Name = "radialMenuItem7";
            this.radialMenuItem7.Size = new System.Drawing.Size(0, 0);
            this.radialMenuItem7.TabIndex = 2;
            this.radialMenuItem7.Text = " ";
            // 
            // radialMenuItem8
            // 
            this.radialMenuItem8.ImageIndex = 9;
            this.radialMenuItem8.Index = 1;
            this.radialMenuItem8.Location = new System.Drawing.Point(0, 0);
            this.radialMenuItem8.Name = "radialMenuItem8";
            this.radialMenuItem8.Size = new System.Drawing.Size(0, 0);
            this.radialMenuItem8.TabIndex = 3;
            this.radialMenuItem8.Text = " ";
            // 
            // radialMenuItem9
            // 
            this.radialMenuItem9.ImageIndex = 11;
            this.radialMenuItem9.Index = 2;
            this.radialMenuItem9.Location = new System.Drawing.Point(0, 0);
            this.radialMenuItem9.Name = "radialMenuItem9";
            this.radialMenuItem9.Size = new System.Drawing.Size(0, 0);
            this.radialMenuItem9.TabIndex = 4;
            this.radialMenuItem9.Text = " ";
            // 
            // radialMenuItem10
            // 
            this.radialMenuItem10.ImageIndex = 12;
            this.radialMenuItem10.Index = 3;
            this.radialMenuItem10.Location = new System.Drawing.Point(0, 0);
            this.radialMenuItem10.Name = "radialMenuItem10";
            this.radialMenuItem10.Size = new System.Drawing.Size(0, 0);
            this.radialMenuItem10.TabIndex = 5;
            this.radialMenuItem10.Text = " ";
            // 
            // radialMenuItem11
            // 
            this.radialMenuItem11.ImageIndex = 13;
            this.radialMenuItem11.Index = 4;
            this.radialMenuItem11.Location = new System.Drawing.Point(0, 0);
            this.radialMenuItem11.Name = "radialMenuItem11";
            this.radialMenuItem11.Size = new System.Drawing.Size(0, 0);
            this.radialMenuItem11.TabIndex = 6;
            this.radialMenuItem11.Text = " ";
            // 
            // radialMenuItem12
            // 
            this.radialMenuItem12.ImageIndex = 14;
            this.radialMenuItem12.Index = 5;
            this.radialMenuItem12.Location = new System.Drawing.Point(0, 0);
            this.radialMenuItem12.Name = "radialMenuItem12";
            this.radialMenuItem12.Size = new System.Drawing.Size(0, 0);
            this.radialMenuItem12.TabIndex = 7;
            this.radialMenuItem12.Text = " ";
            // 
            // radialMenuItem13
            // 
            this.radialMenuItem13.Enabled = false;
            this.radialMenuItem13.ImageIndex = 10;
            this.radialMenuItem13.Index = 2;
            this.radialMenuItem13.Items.Add(this.radialMenuItem14);
            this.radialMenuItem13.Items.Add(this.radialMenuItem15);
            this.radialMenuItem13.Items.Add(this.radialMenuItem16);
            this.radialMenuItem13.Location = new System.Drawing.Point(0, 0);
            this.radialMenuItem13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radialMenuItem13.Name = "radialMenuItem13";
            this.radialMenuItem13.Size = new System.Drawing.Size(0, 0);
            this.radialMenuItem13.TabIndex = 2;
            this.radialMenuItem13.Text = "Undo";
            // 
            // radialMenuItem14
            // 
            this.radialMenuItem14.ImageIndex = 18;
            this.radialMenuItem14.Index = 1;
            this.radialMenuItem14.Location = new System.Drawing.Point(0, 0);
            this.radialMenuItem14.Name = "radialMenuItem14";
            this.radialMenuItem14.Size = new System.Drawing.Size(0, 0);
            this.radialMenuItem14.TabIndex = 2;
            this.radialMenuItem14.Text = "Copy Format";
            // 
            // radialMenuItem15
            // 
            this.radialMenuItem15.Enabled = false;
            this.radialMenuItem15.ImageIndex = 10;
            this.radialMenuItem15.Index = 2;
            this.radialMenuItem15.Location = new System.Drawing.Point(0, 0);
            this.radialMenuItem15.Name = "radialMenuItem15";
            this.radialMenuItem15.Size = new System.Drawing.Size(0, 0);
            this.radialMenuItem15.TabIndex = 3;
            this.radialMenuItem15.Text = "Undo";
            // 
            // radialMenuItem16
            // 
            this.radialMenuItem16.ImageIndex = 24;
            this.radialMenuItem16.Index = 3;
            this.radialMenuItem16.Location = new System.Drawing.Point(0, 0);
            this.radialMenuItem16.Name = "radialMenuItem16";
            this.radialMenuItem16.Size = new System.Drawing.Size(0, 0);
            this.radialMenuItem16.TabIndex = 4;
            this.radialMenuItem16.Text = "Redo";
            // 
            // scrollersFrame
            // 
            this.scrollersFrame.AttachedTo = this.richTextBox1;
            this.scrollersFrame.CustomRender = null;
            this.scrollersFrame.MetroColorScheme = Syncfusion.Windows.Forms.MetroColorScheme.Managed;
            this.scrollersFrame.MetroThumbSize = new System.Drawing.Size(0, 0);
            this.scrollersFrame.Office2016ColorScheme = Syncfusion.Windows.Forms.ScrollBarOffice2016ColorScheme.Colorful;
            this.scrollersFrame.ScrollMetroColorTable = metroColorTable1;
            metroColorTable2.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            metroColorTable2.ArrowCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable2.ArrowInActive = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            metroColorTable2.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            metroColorTable2.ArrowNormalBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable2.ArrowNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            metroColorTable2.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            metroColorTable2.ArrowPushedBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            metroColorTable2.ArrowPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            metroColorTable2.ScrollerBackground = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            metroColorTable2.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            metroColorTable2.ThumbCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable2.ThumbInActive = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            metroColorTable2.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable2.ThumbNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            metroColorTable2.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            metroColorTable2.ThumbPushedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            metroColorTable2.ThumbPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.scrollersFrame.ScrollOffice2016BlackColorTable = metroColorTable2;
            metroColorTable3.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable3.ArrowCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable3.ArrowInActive = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable3.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable3.ArrowNormalBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            metroColorTable3.ArrowNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable3.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable3.ArrowPushedBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable3.ArrowPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            metroColorTable3.ScrollerBackground = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable3.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            metroColorTable3.ThumbCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            metroColorTable3.ThumbInActive = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            metroColorTable3.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            metroColorTable3.ThumbNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            metroColorTable3.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            metroColorTable3.ThumbPushedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            metroColorTable3.ThumbPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.scrollersFrame.ScrollOffice2016ColorfulColorTable = metroColorTable3;
            metroColorTable4.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            metroColorTable4.ArrowCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable4.ArrowInActive = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            metroColorTable4.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable4.ArrowNormalBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            metroColorTable4.ArrowNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            metroColorTable4.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable4.ArrowPushedBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            metroColorTable4.ArrowPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable4.ScrollerBackground = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            metroColorTable4.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            metroColorTable4.ThumbCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            metroColorTable4.ThumbInActive = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            metroColorTable4.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            metroColorTable4.ThumbNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable4.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            metroColorTable4.ThumbPushedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable4.ThumbPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.scrollersFrame.ScrollOffice2016DarkGrayColorTable = metroColorTable4;
            metroColorTable5.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable5.ArrowCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable5.ArrowInActive = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            metroColorTable5.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable5.ArrowNormalBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            metroColorTable5.ArrowNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable5.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable5.ArrowPushedBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable5.ArrowPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            metroColorTable5.ScrollerBackground = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            metroColorTable5.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            metroColorTable5.ThumbCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            metroColorTable5.ThumbInActive = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            metroColorTable5.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            metroColorTable5.ThumbNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            metroColorTable5.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            metroColorTable5.ThumbPushedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            metroColorTable5.ThumbPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.scrollersFrame.ScrollOffice2016WhiteColorTable = metroColorTable5;
            this.scrollersFrame.ShowMetroArrowButton = true;
            this.scrollersFrame.SizeGripperVisibility = Syncfusion.Windows.Forms.SizeGripperVisibility.Auto;
            this.scrollersFrame.ThemeName = "Office2016";
            this.scrollersFrame.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Office2016;
            // 
            // imageListAdv1
            // 
            this.imageListAdv1.Images.AddRange(new System.Drawing.Image[] {
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images1"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images2"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images3"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images4"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images5"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images6"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images7"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images8"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images9"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images10"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images11"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images12"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images13"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images14"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images15"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images16"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images17"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images18"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images19"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images20"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images21"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images22"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images23"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images24"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images25"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images26"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images27"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images28"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images29"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images30"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images31"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images32"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images33"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images34"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images35"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images36"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images37"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images38"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images39"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images40"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images41"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images42"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images43"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images44"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images45"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images46"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images47"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images48"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images49"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images50"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images51"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images52"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images53"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images54"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images55"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images56"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images57"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images58"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images59"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images60"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images61"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images62"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images63"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images64"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images65"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images66"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images67"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images68"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images69"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images70"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images71"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images72"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images73"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images74"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images75")))});
            // 
            // RadialMenuMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ClientSize = new System.Drawing.Size(1444, 929);
            this.Controls.Add(this.gradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(151)))), ((int)(((byte)(217)))));
            this.Name = "RadialMenuMainForm";
            this.Padding = new System.Windows.Forms.Padding(4, 12, 4, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Getting Started";
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.radialMenu1.ResumeLayout(false);
            this.radialMenu1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Syncfusion.Windows.Forms.Tools.RadialMenu radialMenu1;
        private Syncfusion.Windows.Forms.Tools.RadialMenuItem radialMenuItem1;
        private Syncfusion.Windows.Forms.Tools.RadialMenuSlider radialMenuSlider1;
        private Syncfusion.Windows.Forms.Tools.RadialColorPalette radialColorPalette1;
        private Syncfusion.Windows.Forms.Tools.RadialFontListBox radialFontListBox1;
        private Syncfusion.Windows.Forms.Tools.RadialMenuItem radialMenuItem2;
        private Syncfusion.Windows.Forms.Tools.RadialMenuItem radialMenuItem3;
        private Syncfusion.Windows.Forms.Tools.RadialMenuItem radialMenuItem4;
        private Syncfusion.Windows.Forms.Tools.RadialMenuItem radialMenuItem5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Syncfusion.Windows.Forms.Tools.RadialMenuItem radialMenuItem6;
        private Syncfusion.Windows.Forms.Tools.RadialMenuItem radialMenuItem7;
        private Syncfusion.Windows.Forms.Tools.RadialMenuItem radialMenuItem8;
        private Syncfusion.Windows.Forms.Tools.RadialMenuItem radialMenuItem9;
        private Syncfusion.Windows.Forms.Tools.RadialMenuItem radialMenuItem10;
        private Syncfusion.Windows.Forms.Tools.RadialMenuItem radialMenuItem11;
        private Syncfusion.Windows.Forms.Tools.RadialMenuItem radialMenuItem12;
        private Syncfusion.Windows.Forms.Tools.RadialMenuItem radialMenuItem13;
        private Syncfusion.Windows.Forms.Tools.RadialMenuItem radialMenuItem14;
        private Syncfusion.Windows.Forms.Tools.RadialMenuItem radialMenuItem15;
        private Syncfusion.Windows.Forms.Tools.RadialMenuItem radialMenuItem16;
        private Syncfusion.Windows.Forms.ScrollersFrame scrollersFrame;
        private Syncfusion.Windows.Forms.Tools.ImageListAdv imageListAdv1;
        private NumericUpDownExt numericUpDown1;
        private System.Windows.Forms.Label label3;
        private ComboBoxAdv comboBox2;
        private System.Windows.Forms.Label label2;
        private Panels panel1;
        private System.Windows.Forms.Panel groupBox1;
        private NumericUpDownExt numericUpDown2;
        private System.Windows.Forms.Label label1;
        private CheckBoxAdv checkBox1;
        private System.Windows.Forms.Label label4;
        private ComboBoxAdv comboBox1;
        private System.Windows.Forms.Label label5;
        private ComboBoxAdv comboBox3;
    }
}

