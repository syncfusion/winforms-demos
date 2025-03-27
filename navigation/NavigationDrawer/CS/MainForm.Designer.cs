#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.ListView;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NavigationDrawer_2010
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.navigationDrawer1 = new Syncfusion.Windows.Forms.Tools.NavigationDrawer();
            this.header = new Syncfusion.Windows.Forms.Tools.DrawerHeader();
            this.drawerMenuItem1 = new Syncfusion.Windows.Forms.Tools.DrawerMenuItem();
            this.drawerMenuItem2 = new Syncfusion.Windows.Forms.Tools.DrawerMenuItem();
            this.drawerMenuItem3 = new Syncfusion.Windows.Forms.Tools.DrawerMenuItem();
            this.drawerMenuItem4 = new Syncfusion.Windows.Forms.Tools.DrawerMenuItem();
            this.drawerMenuItem5 = new Syncfusion.Windows.Forms.Tools.DrawerMenuItem();
            this.imageListAdv1 = new Syncfusion.Windows.Forms.Tools.ImageListAdv(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboboxAdv1 = new Syncfusion.WinForms.ListView.SfComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sfComboBox2 = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sfComboBox1 = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.numericUpDown1 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.comboBoxAdv3 = new Syncfusion.WinForms.ListView.SfComboBox();
            this.comboBoxAdv2 = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new Syncfusion.WinForms.ListView.SfListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.comboboxAdv1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationDrawer1
            // 
            this.navigationDrawer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.navigationDrawer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationDrawer1.DrawerWidth = 250;
            this.navigationDrawer1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.navigationDrawer1.Items.Add(this.header);
            this.navigationDrawer1.Items.Add(this.drawerMenuItem1);
            this.navigationDrawer1.Items.Add(this.drawerMenuItem2);
            this.navigationDrawer1.Items.Add(this.drawerMenuItem3);
            this.navigationDrawer1.Items.Add(this.drawerMenuItem4);
            this.navigationDrawer1.Items.Add(this.drawerMenuItem5);
            this.navigationDrawer1.Location = new System.Drawing.Point(0, 34);
            this.navigationDrawer1.Name = "navigationDrawer1";
            this.navigationDrawer1.Size = new System.Drawing.Size(606, 665);
            this.navigationDrawer1.Style = Syncfusion.Windows.Forms.Tools.NavigationDrawerStyle.Office2016Colorful;
            this.navigationDrawer1.TabIndex = 0;
            this.navigationDrawer1.Text = "navigationDrawer1";
            this.navigationDrawer1.ThemeName = "Office2016Colorful";
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.header.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.header.HeaderText = "header";
            this.header.Location = new System.Drawing.Point(2, 0);
            this.header.Margin = new System.Windows.Forms.Padding(0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(250, 120);
            this.header.TabIndex = 0;
            this.header.Text = "header";
            this.header.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // drawerMenuItem1
            // 
            this.drawerMenuItem1.BackColor = System.Drawing.Color.White;
            this.drawerMenuItem1.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.drawerMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.drawerMenuItem1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.drawerMenuItem1.ItemText = "Inbox";
            this.drawerMenuItem1.Location = new System.Drawing.Point(2, 120);
            this.drawerMenuItem1.Margin = new System.Windows.Forms.Padding(0);
            this.drawerMenuItem1.MinimumSize = new System.Drawing.Size(200, 50);
            this.drawerMenuItem1.Name = "drawerMenuItem1";
            this.drawerMenuItem1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.drawerMenuItem1.Size = new System.Drawing.Size(250, 50);
            this.drawerMenuItem1.TabIndex = 0;
            this.drawerMenuItem1.Text = "Inbox";
            this.drawerMenuItem1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.drawerMenuItem1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawerMenuItem1_MouseDown);
            this.drawerMenuItem1.MouseEnter += new System.EventHandler(this.drawerMenuItem1_MouseEnter);
            this.drawerMenuItem1.MouseLeave += new System.EventHandler(this.drawerMenuItem1_MouseLeave);
            // 
            // drawerMenuItem2
            // 
            this.drawerMenuItem2.BackColor = System.Drawing.Color.White;
            this.drawerMenuItem2.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.drawerMenuItem2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.drawerMenuItem2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.drawerMenuItem2.ItemText = "Drafts";
            this.drawerMenuItem2.Location = new System.Drawing.Point(2, 170);
            this.drawerMenuItem2.Margin = new System.Windows.Forms.Padding(0);
            this.drawerMenuItem2.MinimumSize = new System.Drawing.Size(200, 50);
            this.drawerMenuItem2.Name = "drawerMenuItem2";
            this.drawerMenuItem2.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.drawerMenuItem2.Size = new System.Drawing.Size(250, 50);
            this.drawerMenuItem2.TabIndex = 1;
            this.drawerMenuItem2.Text = "Drafts";
            this.drawerMenuItem2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.drawerMenuItem2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawerMenuItem1_MouseDown);
            this.drawerMenuItem2.MouseEnter += new System.EventHandler(this.drawerMenuItem1_MouseEnter);
            this.drawerMenuItem2.MouseLeave += new System.EventHandler(this.drawerMenuItem1_MouseLeave);
            // 
            // drawerMenuItem3
            // 
            this.drawerMenuItem3.BackColor = System.Drawing.Color.White;
            this.drawerMenuItem3.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.drawerMenuItem3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.drawerMenuItem3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.drawerMenuItem3.ItemText = "Sent";
            this.drawerMenuItem3.Location = new System.Drawing.Point(2, 220);
            this.drawerMenuItem3.Margin = new System.Windows.Forms.Padding(0);
            this.drawerMenuItem3.MinimumSize = new System.Drawing.Size(200, 50);
            this.drawerMenuItem3.Name = "drawerMenuItem3";
            this.drawerMenuItem3.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.drawerMenuItem3.Size = new System.Drawing.Size(250, 50);
            this.drawerMenuItem3.TabIndex = 2;
            this.drawerMenuItem3.Text = "Sent";
            this.drawerMenuItem3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.drawerMenuItem3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawerMenuItem1_MouseDown);
            this.drawerMenuItem3.MouseEnter += new System.EventHandler(this.drawerMenuItem1_MouseEnter);
            this.drawerMenuItem3.MouseLeave += new System.EventHandler(this.drawerMenuItem1_MouseLeave);
            // 
            // drawerMenuItem4
            // 
            this.drawerMenuItem4.BackColor = System.Drawing.Color.White;
            this.drawerMenuItem4.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.drawerMenuItem4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.drawerMenuItem4.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.drawerMenuItem4.ItemText = "Outbox";
            this.drawerMenuItem4.Location = new System.Drawing.Point(2, 270);
            this.drawerMenuItem4.Margin = new System.Windows.Forms.Padding(0);
            this.drawerMenuItem4.MinimumSize = new System.Drawing.Size(200, 50);
            this.drawerMenuItem4.Name = "drawerMenuItem4";
            this.drawerMenuItem4.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.drawerMenuItem4.Size = new System.Drawing.Size(250, 50);
            this.drawerMenuItem4.TabIndex = 3;
            this.drawerMenuItem4.Text = "Outbox";
            this.drawerMenuItem4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.drawerMenuItem4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawerMenuItem1_MouseDown);
            this.drawerMenuItem4.MouseEnter += new System.EventHandler(this.drawerMenuItem1_MouseEnter);
            this.drawerMenuItem4.MouseLeave += new System.EventHandler(this.drawerMenuItem1_MouseLeave);
            // 
            // drawerMenuItem5
            // 
            this.drawerMenuItem5.BackColor = System.Drawing.Color.White;
            this.drawerMenuItem5.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.drawerMenuItem5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.drawerMenuItem5.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.drawerMenuItem5.ItemText = "Profile";
            this.drawerMenuItem5.Location = new System.Drawing.Point(2, 320);
            this.drawerMenuItem5.Margin = new System.Windows.Forms.Padding(0);
            this.drawerMenuItem5.MinimumSize = new System.Drawing.Size(200, 50);
            this.drawerMenuItem5.Name = "drawerMenuItem5";
            this.drawerMenuItem5.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.drawerMenuItem5.Size = new System.Drawing.Size(250, 50);
            this.drawerMenuItem5.TabIndex = 4;
            this.drawerMenuItem5.Text = "Profile";
            this.drawerMenuItem5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.drawerMenuItem5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawerMenuItem1_MouseDown);
            this.drawerMenuItem5.MouseEnter += new System.EventHandler(this.drawerMenuItem1_MouseEnter);
            this.drawerMenuItem5.MouseLeave += new System.EventHandler(this.drawerMenuItem1_MouseLeave);
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
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images43")))});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label2.Location = new System.Drawing.Point(19, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Transition";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label4.Location = new System.Drawing.Point(19, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Style";
            // 
            // comboboxAdv1
            // 
            this.comboboxAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboboxAdv1.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.comboboxAdv1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboboxAdv1.Location = new System.Drawing.Point(126, 240);
            this.comboboxAdv1.Name = "comboboxAdv1";
            this.comboboxAdv1.Size = new System.Drawing.Size(200, 21);
            this.comboboxAdv1.Style.EditorStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboboxAdv1.Style.EditorStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboboxAdv1.TabIndex = 19;
            this.comboboxAdv1.SelectedIndexChanged += new System.EventHandler(this.ComboboxAdv1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sfComboBox2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.sfComboBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.comboBoxAdv3);
            this.panel1.Controls.Add(this.comboBoxAdv2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboboxAdv1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 697);
            this.panel1.TabIndex = 16;
            // 
            // sfComboBox2
            // 
            this.sfComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfComboBox2.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.sfComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.sfComboBox2.Location = new System.Drawing.Point(126, 424);
            this.sfComboBox2.Name = "sfComboBox2";
            this.sfComboBox2.Size = new System.Drawing.Size(200, 21);
            this.sfComboBox2.Style.EditorStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfComboBox2.Style.EditorStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.sfComboBox2.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label8.Location = new System.Drawing.Point(19, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Text Image Relation";
            // 
            // sfComboBox1
            // 
            this.sfComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfComboBox1.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.sfComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.sfComboBox1.Location = new System.Drawing.Point(127, 377);
            this.sfComboBox1.Name = "sfComboBox1";
            this.sfComboBox1.Size = new System.Drawing.Size(200, 21);
            this.sfComboBox1.Style.EditorStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfComboBox1.Style.EditorStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.sfComboBox1.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label6.Location = new System.Drawing.Point(19, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Text Align";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BeforeTouchSize = new System.Drawing.Size(200, 20);
            this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown2.Location = new System.Drawing.Point(126, 331);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(200, 20);
            this.numericUpDown2.TabIndex = 25;
            this.numericUpDown2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BeforeTouchSize = new System.Drawing.Size(200, 20);
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Location = new System.Drawing.Point(126, 286);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(200, 20);
            this.numericUpDown1.TabIndex = 24;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // comboBoxAdv3
            // 
            this.comboBoxAdv3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxAdv3.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.comboBoxAdv3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBoxAdv3.Location = new System.Drawing.Point(126, 194);
            this.comboBoxAdv3.Name = "comboBoxAdv3";
            this.comboBoxAdv3.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAdv3.Style.EditorStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxAdv3.Style.EditorStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBoxAdv3.TabIndex = 23;
            // 
            // comboBoxAdv2
            // 
            this.comboBoxAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxAdv2.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.comboBoxAdv2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBoxAdv2.Location = new System.Drawing.Point(126, 148);
            this.comboBoxAdv2.Name = "comboBoxAdv2";
            this.comboBoxAdv2.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAdv2.Style.EditorStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxAdv2.Style.EditorStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBoxAdv2.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label5.Location = new System.Drawing.Point(19, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Drawer Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label3.Location = new System.Drawing.Point(19, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(19, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Animation Duration";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.label7);
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Controls.Add(this.listView1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(606, 34);
            this.gradientPanel1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Inbox";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NavigationDrawer_2010.Properties.Resources.Icon_menu_Colorful;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.AccessibleName = "ScrollControl";
            this.listView1.ItemHeight = 70D;
            this.listView1.Location = new System.Drawing.Point(130, 183);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.navigationDrawer1);
            this.panel2.Controls.Add(this.gradientPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 699);
            this.panel2.TabIndex = 2;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel2.Controls.Add(this.panel1);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.gradientPanel2.Location = new System.Drawing.Point(624, 10);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(354, 699);
            this.gradientPanel2.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(616, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(8, 699);
            this.panel5.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 719);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.gradientPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Navigation Drawer";
            ((System.ComponentModel.ISupportInitialize)(this.comboboxAdv1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

       


        #endregion

        private Syncfusion.Windows.Forms.Tools.NavigationDrawer navigationDrawer1;
        private Syncfusion.Windows.Forms.Tools.DrawerMenuItem drawerMenuItem1;
        private Syncfusion.Windows.Forms.Tools.DrawerMenuItem drawerMenuItem2;
        private Syncfusion.Windows.Forms.Tools.DrawerMenuItem drawerMenuItem3;
        private Syncfusion.Windows.Forms.Tools.DrawerMenuItem drawerMenuItem4;
        private Syncfusion.Windows.Forms.Tools.DrawerMenuItem drawerMenuItem5;
        private Syncfusion.Windows.Forms.Tools.ImageListAdv imageListAdv1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private SfComboBox comboboxAdv1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private DrawerHeader header;
        private GradientPanel gradientPanel1;
        private GradientPanel gradientPanel2;
        private Panel panel5;
        private NumericUpDownExt numericUpDown2;
        private NumericUpDownExt numericUpDown1;
        private SfComboBox comboBoxAdv3;
        private SfComboBox comboBoxAdv2;
        private Label label5;
        private SfListView listView1;
        private Panel panel2;
        private Label label7;
        private PictureBox pictureBox1;
        private SfComboBox sfComboBox1;
        private Label label6;
        private SfComboBox sfComboBox2;
        private Label label8;
    }
}

