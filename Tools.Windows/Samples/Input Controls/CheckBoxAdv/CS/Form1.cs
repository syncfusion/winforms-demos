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
using System.Data;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System.Collections.Generic;
using Syncfusion.Licensing;

namespace CheckBoxAdvDemo
{
    using Syncfusion.Licensing;
    public class Form1 : MetroForm
    {
        #region Declarations
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList1;
        private Label label40;
        private ComboBoxAdv comboBox6;
        private Label label44;
        private Label label8;
        private ComboBoxAdv comboBox1;
        private Label label7;
        private ComboBoxAdv comboBox4;
        private Label label14;
        private Label label16;
        private Label label15;
        private Syncfusion.Windows.Forms.Tools.ButtonEdit buttonEdit2;
        private Syncfusion.Windows.Forms.Tools.ButtonEditChildButton buttonEditChildButton2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt2;
        private Syncfusion.Windows.Forms.Tools.ButtonEdit buttonEdit1;
        private Syncfusion.Windows.Forms.Tools.ButtonEditChildButton buttonEditChildButton1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
        private ColorDialog colorDialog1;
        private ComboBoxAdv comboBox8;
        private Label label25;
        private Syncfusion.Windows.Forms.Tools.ButtonEdit buttonEdit5;
        private Syncfusion.Windows.Forms.Tools.ButtonEditChildButton buttonEditChildButton5;
        private ComboBoxAdv comboBox5;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private ComboBoxAdv comboBox11;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv13;
        private Label label31;
        private Label label32;
        private Syncfusion.Windows.Forms.Tools.ButtonEdit buttonEdit6;
        private Syncfusion.Windows.Forms.Tools.ButtonEditChildButton buttonEditChildButton6;
        private Syncfusion.Windows.Forms.Tools.ButtonEdit buttonEdit7;
        private Syncfusion.Windows.Forms.Tools.ButtonEditChildButton buttonEditChildButton7;
        private ComboBoxAdv comboBox12;
        private Label label33;
        private Label label34;
        private Label label35;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv14;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv15;
        private ComboBoxAdv comboBox13;
        private Label label36;
        private Label label37;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv16;
        private ComboBoxAdv comboBox14;
        private Label label39;
        private CheckBoxAdv checkBox3;
        private CheckBoxAdv checkBox5;
        private CheckBoxAdv checkBox4;
        private CheckBoxAdv checkBox6;
        private ComboBoxAdv comboBox18;
        private Label label49;
        private Label label50;
        private ComboBoxAdv comboBox19;
        DataTable m_dt = null;
        private CheckBoxAdv checkBox7;
        private ToolTip toolTip1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Label label59;
        private Syncfusion.Windows.Forms.Tools.GroupBar groupBar1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel7;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel6;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel5;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel4;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem1;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem2;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem3;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem4;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem5;
        private Syncfusion.Windows.Forms.Tools.SplitContainerAdv splitContainerAdv1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel8;
        private Panel panel1;
        private Panel panel2;
        private System.ComponentModel.IContainer components;
        #endregion

        #region Constructor And Dispose
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
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label59 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gradientPanel8 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.comboBox2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.groupBar1 = new Syncfusion.Windows.Forms.Tools.GroupBar();
            this.gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();        
            this.gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label40 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.comboBox6 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBox8 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.buttonEdit5 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton5 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.label25 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.comboBox14 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.gradientPanel7 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.comboBox19 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.comboBox18 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.gradientPanel5 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox4 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.buttonEdit1 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton1 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.buttonEdit2 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton2 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.gradientPanel6 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.checkBox6 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox3 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox7 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox4 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox5 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.groupBarItem1 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem2 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem3 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem4 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem5 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.textBoxExt2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.comboBox5 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBox11 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.radioButtonAdv13 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.buttonEdit6 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton6 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.buttonEdit7 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton7 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.comboBox12 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.radioButtonAdv14 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonAdv15 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.comboBox13 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.radioButtonAdv16 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel8)).BeginInit();
            this.gradientPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).BeginInit();
            this.groupBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).BeginInit();
            this.gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).BeginInit();
            this.gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit5)).BeginInit();
            this.buttonEdit5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel7)).BeginInit();
            this.gradientPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel5)).BeginInit();
            this.gradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1)).BeginInit();
            this.buttonEdit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2)).BeginInit();
            this.buttonEdit2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel6)).BeginInit();
            this.gradientPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit6)).BeginInit();
            this.buttonEdit6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit7)).BeginInit();
            this.buttonEdit7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv16)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // label59
            // 
            this.label59.BackColor = System.Drawing.Color.Transparent;
            this.label59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label59.Dock = System.Windows.Forms.DockStyle.Top;
            this.label59.ForeColor = System.Drawing.Color.Black;
            this.label59.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label59.Location = new System.Drawing.Point(20, 20);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(913, 48);
            this.label59.TabIndex = 1;
            this.label59.Text = resources.GetString("label59.Text");
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label27.Image = ((System.Drawing.Image)(resources.GetObject("label27.Image")));
            this.label27.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label27.Location = new System.Drawing.Point(30, 255);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(114, 24);
            this.label27.TabIndex = 116;
            this.label27.Text = "Border Settings";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label28.Location = new System.Drawing.Point(30, 279);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(150, 1);
            this.label28.TabIndex = 115;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(25, 293);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(64, 13);
            this.label29.TabIndex = 114;
            this.label29.Text = "Border Style";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(25, 331);
            this.label30.Margin = new System.Windows.Forms.Padding(0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(78, 13);
            this.label30.TabIndex = 112;
            this.label30.Text = "Border3D Style";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(25, 217);
            this.label31.Margin = new System.Windows.Forms.Padding(0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(96, 13);
            this.label31.TabIndex = 109;
            this.label31.Text = "Gradient End Color";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(29, 190);
            this.label32.Margin = new System.Windows.Forms.Padding(0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(99, 13);
            this.label32.TabIndex = 108;
            this.label32.Text = "Gradient Start Color";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(29, 163);
            this.label33.Margin = new System.Windows.Forms.Padding(0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(93, 13);
            this.label33.TabIndex = 104;
            this.label33.Text = "BackGround Style";
            // 
            // label34
            // 
            this.label34.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label34.Image = ((System.Drawing.Image)(resources.GetObject("label34.Image")));
            this.label34.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label34.Location = new System.Drawing.Point(25, 123);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(147, 24);
            this.label34.TabIndex = 103;
            this.label34.Text = "Background Settings";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label35
            // 
            this.label35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label35.Location = new System.Drawing.Point(29, 147);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(150, 1);
            this.label35.TabIndex = 102;
            // 
            // label36
            // 
            this.label36.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label36.Image = ((System.Drawing.Image)(resources.GetObject("label36.Image")));
            this.label36.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label36.Location = new System.Drawing.Point(256, 99);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(95, 24);
            this.label36.TabIndex = 96;
            this.label36.Text = "Visual Styles";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label37
            // 
            this.label37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label37.Location = new System.Drawing.Point(256, 123);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(150, 1);
            this.label37.TabIndex = 95;
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerAdv1.BeforeTouchSize = 7;
            this.splitContainerAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerAdv1.IsSplitterFixed = true;
            this.splitContainerAdv1.Location = new System.Drawing.Point(20, 93);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.Controls.Add(this.gradientPanel1);
            this.splitContainerAdv1.Panel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.Controls.Add(this.panel2);
            this.splitContainerAdv1.Size = new System.Drawing.Size(913, 381);
            this.splitContainerAdv1.SplitterDistance = 655;
            this.splitContainerAdv1.TabIndex = 154;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.White;
            this.gradientPanel1.BorderColor = System.Drawing.Color.Silver;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(653, 379);
            this.gradientPanel1.TabIndex = 151;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gradientPanel8);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.checkBoxAdv1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 379);
            this.panel1.TabIndex = 37;
            // 
            // gradientPanel8
            // 
            this.gradientPanel8.BorderColor = System.Drawing.Color.Silver;
            this.gradientPanel8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel8.Controls.Add(this.comboBox2);
            this.gradientPanel8.Controls.Add(this.label5);
            this.gradientPanel8.Location = new System.Drawing.Point(27, 233);
            this.gradientPanel8.Name = "gradientPanel8";
            this.gradientPanel8.Size = new System.Drawing.Size(580, 123);
            this.gradientPanel8.TabIndex = 36;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.BeforeTouchSize = new System.Drawing.Size(116, 21);
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.Location = new System.Drawing.Point(242, 74);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(116, 21);
            this.comboBox2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox2.TabIndex = 23;
            this.comboBox2.UseMetroColorsInActiveMode = true;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(580, 47);
            this.label5.TabIndex = 0;
            this.label5.Text = "Select the bit value from the comboBox below to set state of the CheckBoxAdv whic" +
    "h is bound  to a field (containing only 0,1 or -1) column in a data table.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(24, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 24);
            this.label8.TabIndex = 34;
            this.label8.Text = "Data Binding";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.BeforeTouchSize = new System.Drawing.Size(163, 91);
            this.checkBoxAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.checkBoxAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkBoxAdv1.Checked = true;
            this.checkBoxAdv1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("checkBoxAdv1.CheckedImage")));
            this.checkBoxAdv1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv1.DrawFocusRectangle = false;
            this.checkBoxAdv1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxAdv1.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.checkBoxAdv1.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.checkBoxAdv1.ImageCheckBoxSize = new System.Drawing.Size(30, 30);
            this.checkBoxAdv1.IndeterminateImage = ((System.Drawing.Image)(resources.GetObject("checkBoxAdv1.IndeterminateImage")));
            this.checkBoxAdv1.Location = new System.Drawing.Point(233, 44);
            this.checkBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(163, 91);
            this.checkBoxAdv1.StretchImage = false;
            this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv1.TabIndex = 22;
            this.checkBoxAdv1.Text = "CheckBoxAdv";
            this.checkBoxAdv1.ThemesEnabled = false;
            this.checkBoxAdv1.UncheckedImage = ((System.Drawing.Image)(resources.GetObject("checkBoxAdv1.UncheckedImage")));
            this.checkBoxAdv1.CheckStateChanged += new System.EventHandler(this.checkBoxAdv1_CheckStateChanged);
            // 
            // groupBar1
            // 
            this.groupBar1.AllowDrop = true;
            this.groupBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBar1.BeforeTouchSize = new System.Drawing.Size(247, 377);
            this.groupBar1.BorderColor = System.Drawing.Color.White;
            this.groupBar1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupBar1.CollapseImage = ((System.Drawing.Image)(resources.GetObject("groupBar1.CollapseImage")));
            this.groupBar1.Controls.Add(this.gradientPanel3);
            this.groupBar1.Controls.Add(this.gradientPanel7);
            this.groupBar1.Controls.Add(this.gradientPanel4);
            this.groupBar1.Controls.Add(this.gradientPanel5);
            this.groupBar1.Controls.Add(this.gradientPanel6);
            this.groupBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBar1.ExpandButtonToolTip = null;
            this.groupBar1.ExpandImage = ((System.Drawing.Image)(resources.GetObject("groupBar1.ExpandImage")));
            this.groupBar1.FlatLook = true;
            this.groupBar1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBar1.ForeColor = System.Drawing.Color.White;
            this.groupBar1.GroupBarDropDownToolTip = null;
            this.groupBar1.GroupBarItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupBarItem[] {
            this.groupBarItem1,
            this.groupBarItem2,
            this.groupBarItem3,
            this.groupBarItem4,
            this.groupBarItem5});
            this.groupBar1.IndexOnVisibleItems = true;
            this.groupBar1.Location = new System.Drawing.Point(0, 0);
            this.groupBar1.MinimizeButtonToolTip = null;
            this.groupBar1.Name = "groupBar1";
            this.groupBar1.NavigationPaneTooltip = null;
            this.groupBar1.PopupClientSize = new System.Drawing.Size(0, 0);
            this.groupBar1.SelectedItem = 0;
            this.groupBar1.Size = new System.Drawing.Size(247, 377);
            this.groupBar1.SmartSizeBox = false;
            this.groupBar1.Splittercolor = System.Drawing.SystemColors.ControlDark;
            this.groupBar1.TabIndex = 153;
            this.groupBar1.Text = "groupBar1";
            this.groupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.groupBar1.GroupBarItemSelected += new System.EventHandler(this.groupBar1_GroupBarItemSelected);
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.BackColor = System.Drawing.Color.White;
            this.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel3.Controls.Add(this.label7);
            this.gradientPanel3.Controls.Add(this.comboBox1);
            this.gradientPanel3.Location = new System.Drawing.Point(0, 22);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(247, 267);
            this.gradientPanel3.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(19, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 90;
            this.label7.Text = "Style";          
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.BeforeTouchSize = new System.Drawing.Size(131, 21);
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox1.Items.AddRange(new object[] {
            "Default",
            "Office2007Blue",
            "Office2007Silver",
            "Office2007Black",
            "Office2010Blue",
            "Office2010Silver",
            "Office2010Black",
            "Metro",
            "Office2016Colorful",
            "Office2016DarkGray",
            "Office2016Black",
            "Office2016White"});
            this.comboBox1.Location = new System.Drawing.Point(82, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 21);
            this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox1.TabIndex = 91;
            this.comboBox1.Text = "Default";
            this.comboBox1.UseMetroColorsInActiveMode = true;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);            
            // 
            // gradientPanel4
            // 
            this.gradientPanel4.BackColor = System.Drawing.Color.White;
            this.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel4.Controls.Add(this.label40);
            this.gradientPanel4.Controls.Add(this.label44);
            this.gradientPanel4.Controls.Add(this.comboBox6);
            this.gradientPanel4.Controls.Add(this.comboBox8);
            this.gradientPanel4.Controls.Add(this.buttonEdit5);
            this.gradientPanel4.Controls.Add(this.label25);
            this.gradientPanel4.Controls.Add(this.label39);
            this.gradientPanel4.Controls.Add(this.comboBox14);
            this.gradientPanel4.Location = new System.Drawing.Point(0, 308);
            this.gradientPanel4.Name = "gradientPanel4";
            this.gradientPanel4.Size = new System.Drawing.Size(159, 0);
            this.gradientPanel4.TabIndex = 1;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label40.Location = new System.Drawing.Point(7, 40);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(69, 13);
            this.label40.TabIndex = 80;
            this.label40.Text = "Border Style";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label44.Location = new System.Drawing.Point(7, 104);
            this.label44.Margin = new System.Windows.Forms.Padding(0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(83, 13);
            this.label44.TabIndex = 76;
            this.label44.Text = "Border3D Style";
            // 
            // comboBox6
            // 
            this.comboBox6.BackColor = System.Drawing.Color.White;
            this.comboBox6.BeforeTouchSize = new System.Drawing.Size(101, 21);
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox6.Location = new System.Drawing.Point(122, 97);
            this.comboBox6.MetroColor = System.Drawing.Color.Gray;
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(101, 21);
            this.comboBox6.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox6.TabIndex = 78;
            this.comboBox6.UseMetroColorsInActiveMode = true;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // comboBox8
            // 
            this.comboBox8.BackColor = System.Drawing.Color.White;
            this.comboBox8.BeforeTouchSize = new System.Drawing.Size(101, 21);
            this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox8.Items.AddRange(new object[] {
            "None",
            "FixedSingle",
            "Fixed3D"});
            this.comboBox8.Location = new System.Drawing.Point(121, 34);
            this.comboBox8.MetroColor = System.Drawing.Color.Gray;
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(101, 21);
            this.comboBox8.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox8.TabIndex = 102;
            this.comboBox8.Text = "None";
            this.comboBox8.UseMetroColorsInActiveMode = true;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // buttonEdit5
            // 
            this.buttonEdit5.BeforeTouchSize = new System.Drawing.Size(101, 23);
            this.buttonEdit5.Buttons.Add(this.buttonEditChildButton5);
            this.buttonEdit5.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonEdit5.Controls.Add(this.buttonEditChildButton5);
            this.buttonEdit5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit5.Location = new System.Drawing.Point(122, 206);
            this.buttonEdit5.MetroColor = System.Drawing.Color.Silver;
            this.buttonEdit5.Name = "buttonEdit5";
            this.buttonEdit5.ShowTextBox = false;
            this.buttonEdit5.Size = new System.Drawing.Size(101, 23);
            this.buttonEdit5.TabIndex = 103;
            this.buttonEdit5.UseVisualStyle = true;
            this.buttonEdit5.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit5_ButtonClicked);
            // 
            // buttonEditChildButton5
            // 
            this.buttonEditChildButton5.BackColor = System.Drawing.Color.Silver;
            this.buttonEditChildButton5.BeforeTouchSize = new System.Drawing.Size(18, 19);
            this.buttonEditChildButton5.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.buttonEditChildButton5.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton5.ForeColor = System.Drawing.Color.White;
            this.buttonEditChildButton5.Image = null;
            this.buttonEditChildButton5.IsBackStageButton = false;
            this.buttonEditChildButton5.Name = "buttonEditChildButton5";
            this.buttonEditChildButton5.PreferredWidth = 18;
            this.buttonEditChildButton5.TabIndex = 1;
            this.buttonEditChildButton5.Text = "...";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label25.Location = new System.Drawing.Point(7, 212);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(73, 13);
            this.label25.TabIndex = 104;
            this.label25.Text = "Border Color";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label39.Location = new System.Drawing.Point(7, 152);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(77, 13);
            this.label39.TabIndex = 105;
            this.label39.Text = "Border Single";
            // 
            // comboBox14
            // 
            this.comboBox14.BackColor = System.Drawing.Color.White;
            this.comboBox14.BeforeTouchSize = new System.Drawing.Size(101, 21);
            this.comboBox14.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox14.Location = new System.Drawing.Point(122, 147);
            this.comboBox14.MetroColor = System.Drawing.Color.Gray;
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(101, 21);
            this.comboBox14.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox14.TabIndex = 106;
            this.comboBox14.UseMetroColorsInActiveMode = true;
            this.comboBox14.SelectedIndexChanged += new System.EventHandler(this.comboBox14_SelectedIndexChanged);
            // 
            // gradientPanel7
            // 
            this.gradientPanel7.BackColor = System.Drawing.Color.White;
            this.gradientPanel7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel7.Controls.Add(this.comboBox19);
            this.gradientPanel7.Controls.Add(this.label50);
            this.gradientPanel7.Controls.Add(this.label49);
            this.gradientPanel7.Controls.Add(this.comboBox18);
            this.gradientPanel7.Location = new System.Drawing.Point(0, 300);
            this.gradientPanel7.Name = "gradientPanel7";
            this.gradientPanel7.Size = new System.Drawing.Size(220, 0);
            this.gradientPanel7.TabIndex = 4;
            // 
            // comboBox19
            // 
            this.comboBox19.BackColor = System.Drawing.Color.White;
            this.comboBox19.BeforeTouchSize = new System.Drawing.Size(99, 21);
            this.comboBox19.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox19.Location = new System.Drawing.Point(123, 56);
            this.comboBox19.Name = "comboBox19";
            this.comboBox19.Size = new System.Drawing.Size(99, 21);
            this.comboBox19.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox19.TabIndex = 138;
            this.comboBox19.SelectedIndexChanged += new System.EventHandler(this.comboBox19_SelectedIndexChanged);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label50.Location = new System.Drawing.Point(14, 59);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(67, 13);
            this.label50.TabIndex = 139;
            this.label50.Text = "Glyph Align";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label49.Location = new System.Drawing.Point(14, 109);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(56, 13);
            this.label49.TabIndex = 140;
            this.label49.Text = "Text Align";
            // 
            // comboBox18
            // 
            this.comboBox18.BackColor = System.Drawing.Color.White;
            this.comboBox18.BeforeTouchSize = new System.Drawing.Size(99, 21);
            this.comboBox18.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox18.Location = new System.Drawing.Point(123, 100);
            this.comboBox18.Name = "comboBox18";
            this.comboBox18.Size = new System.Drawing.Size(99, 21);
            this.comboBox18.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox18.TabIndex = 141;
            this.comboBox18.SelectedIndexChanged += new System.EventHandler(this.comboBox18_SelectedIndexChanged);
            // 
            // gradientPanel5
            // 
            this.gradientPanel5.BackColor = System.Drawing.Color.White;
            this.gradientPanel5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel5.Controls.Add(this.label14);
            this.gradientPanel5.Controls.Add(this.comboBox4);
            this.gradientPanel5.Controls.Add(this.buttonEdit1);
            this.gradientPanel5.Controls.Add(this.buttonEdit2);
            this.gradientPanel5.Controls.Add(this.label15);
            this.gradientPanel5.Controls.Add(this.label16);
            this.gradientPanel5.Location = new System.Drawing.Point(0, 326);
            this.gradientPanel5.Name = "gradientPanel5";
            this.gradientPanel5.Size = new System.Drawing.Size(244, 0);
            this.gradientPanel5.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(5, 47);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 26);
            this.label14.TabIndex = 96;
            this.label14.Text = "BackGround \r\nStyle";
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.White;
            this.comboBox4.BeforeTouchSize = new System.Drawing.Size(143, 21);
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox4.Items.AddRange(new object[] {
            "Default",
            "HorizontalGradient",
            "VerticalGradient"});
            this.comboBox4.Location = new System.Drawing.Point(82, 48);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(143, 21);
            this.comboBox4.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox4.TabIndex = 97;
            this.comboBox4.Text = "Default";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.BeforeTouchSize = new System.Drawing.Size(144, 23);
            this.buttonEdit1.Buttons.Add(this.buttonEditChildButton1);
            this.buttonEdit1.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonEdit1.Controls.Add(this.buttonEditChildButton1);
            this.buttonEdit1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit1.Location = new System.Drawing.Point(82, 111);
            this.buttonEdit1.MetroColor = System.Drawing.Color.Gray;
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.ShowTextBox = false;
            this.buttonEdit1.Size = new System.Drawing.Size(144, 23);
            this.buttonEdit1.TabIndex = 98;
            this.buttonEdit1.UseVisualStyle = true;
            this.buttonEdit1.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit1_ButtonClicked);
            // 
            // buttonEditChildButton1
            // 
            this.buttonEditChildButton1.BackColor = System.Drawing.Color.Gray;
            this.buttonEditChildButton1.BeforeTouchSize = new System.Drawing.Size(18, 19);
            this.buttonEditChildButton1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.buttonEditChildButton1.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton1.ForeColor = System.Drawing.Color.White;
            this.buttonEditChildButton1.Image = null;
            this.buttonEditChildButton1.IsBackStageButton = false;
            this.buttonEditChildButton1.Name = "buttonEditChildButton1";
            this.buttonEditChildButton1.PreferredWidth = 18;
            this.buttonEditChildButton1.TabIndex = 1;
            this.buttonEditChildButton1.Text = "...";
            // 
            // buttonEdit2
            // 
            this.buttonEdit2.BeforeTouchSize = new System.Drawing.Size(144, 23);
            this.buttonEdit2.Buttons.Add(this.buttonEditChildButton2);
            this.buttonEdit2.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonEdit2.Controls.Add(this.buttonEditChildButton2);
            this.buttonEdit2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit2.Location = new System.Drawing.Point(82, 167);
            this.buttonEdit2.MetroColor = System.Drawing.Color.Gray;
            this.buttonEdit2.Name = "buttonEdit2";
            this.buttonEdit2.ShowTextBox = false;
            this.buttonEdit2.Size = new System.Drawing.Size(144, 23);
            this.buttonEdit2.TabIndex = 99;
            this.buttonEdit2.UseVisualStyle = true;
            this.buttonEdit2.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit2_ButtonClicked);
            // 
            // buttonEditChildButton2
            // 
            this.buttonEditChildButton2.BackColor = System.Drawing.Color.Gray;
            this.buttonEditChildButton2.BeforeTouchSize = new System.Drawing.Size(18, 19);
            this.buttonEditChildButton2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.buttonEditChildButton2.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton2.ForeColor = System.Drawing.Color.White;
            this.buttonEditChildButton2.Image = null;
            this.buttonEditChildButton2.IsBackStageButton = false;
            this.buttonEditChildButton2.Name = "buttonEditChildButton2";
            this.buttonEditChildButton2.PreferredWidth = 18;
            this.buttonEditChildButton2.TabIndex = 1;
            this.buttonEditChildButton2.Text = "...";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(5, 111);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 26);
            this.label15.TabIndex = 100;
            this.label15.Text = "Gradient \r\nStart Color";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(5, 166);
            this.label16.Margin = new System.Windows.Forms.Padding(0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 26);
            this.label16.TabIndex = 101;
            this.label16.Text = "Gradient \r\nEnd Color";
            // 
            // gradientPanel6
            // 
            this.gradientPanel6.BackColor = System.Drawing.Color.White;
            this.gradientPanel6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel6.Controls.Add(this.checkBox6);
            this.gradientPanel6.Controls.Add(this.checkBox3);
            this.gradientPanel6.Controls.Add(this.checkBox7);
            this.gradientPanel6.Controls.Add(this.checkBox4);
            this.gradientPanel6.Controls.Add(this.checkBox5);
            this.gradientPanel6.Location = new System.Drawing.Point(0, 348);
            this.gradientPanel6.Name = "gradientPanel6";
            this.gradientPanel6.Size = new System.Drawing.Size(244, 0);
            this.gradientPanel6.TabIndex = 3;
            // 
            // checkBox6
            // 
            this.checkBox6.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox6.DrawFocusRectangle = false;
            this.checkBox6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox6.Location = new System.Drawing.Point(31, 22);
            this.checkBox6.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(120, 24);
            this.checkBox6.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox6.TabIndex = 128;
            this.checkBox6.Text = "ReadOnly";
            this.checkBox6.ThemesEnabled = false;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox3.DrawFocusRectangle = false;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox3.Location = new System.Drawing.Point(31, 134);
            this.checkBox3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(157, 24);
            this.checkBox3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox3.TabIndex = 125;
            this.checkBox3.Text = "ImageCheckBox";
            this.checkBox3.ThemesEnabled = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox7.DrawFocusRectangle = false;
            this.checkBox7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox7.Location = new System.Drawing.Point(31, 106);
            this.checkBox7.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(157, 24);
            this.checkBox7.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox7.TabIndex = 144;
            this.checkBox7.Text = "Themes Enabled";
            this.checkBox7.ThemesEnabled = false;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox4.DrawFocusRectangle = false;
            this.checkBox4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox4.Location = new System.Drawing.Point(31, 78);
            this.checkBox4.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(137, 24);
            this.checkBox4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox4.TabIndex = 126;
            this.checkBox4.Text = "ShowShadow";
            this.checkBox4.ThemesEnabled = false;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox5.DrawFocusRectangle = false;
            this.checkBox5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox5.Location = new System.Drawing.Point(31, 50);
            this.checkBox5.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(112, 24);
            this.checkBox5.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox5.TabIndex = 127;
            this.checkBox5.Text = "TriState";
            this.checkBox5.ThemesEnabled = false;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // groupBarItem1
            // 
            this.groupBarItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBarItem1.Client = this.gradientPanel3;
            this.groupBarItem1.Text = "Visual Styles";
            // 
            // groupBarItem2
            // 
            this.groupBarItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBarItem2.Client = this.gradientPanel4;
            this.groupBarItem2.Text = "Border Settings";
            // 
            // groupBarItem3
            // 
            this.groupBarItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBarItem3.Client = this.gradientPanel5;
            this.groupBarItem3.Text = "Background Settings";
            // 
            // groupBarItem4
            // 
            this.groupBarItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBarItem4.Client = this.gradientPanel6;
            this.groupBarItem4.Text = "Properties";
            // 
            // groupBarItem5
            // 
            this.groupBarItem5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBarItem5.Client = this.gradientPanel7;
            this.groupBarItem5.Text = "Alignment";
            // 
            // textBoxExt2
            // 
            this.textBoxExt2.BeforeTouchSize = new System.Drawing.Size(42, 13);
            this.textBoxExt2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt2.Location = new System.Drawing.Point(2, 4);
            this.textBoxExt2.Metrocolor = System.Drawing.Color.Empty;
            this.textBoxExt2.Name = "textBoxExt2";
            this.textBoxExt2.OverflowIndicatorToolTipText = null;
            this.textBoxExt2.Size = new System.Drawing.Size(49, 13);
            this.textBoxExt2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBoxExt2.TabIndex = 0;
            // 
            // textBoxExt1
            // 
            this.textBoxExt1.BeforeTouchSize = new System.Drawing.Size(42, 13);
            this.textBoxExt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt1.Location = new System.Drawing.Point(2, 4);
            this.textBoxExt1.Metrocolor = System.Drawing.Color.Empty;
            this.textBoxExt1.Name = "textBoxExt1";
            this.textBoxExt1.OverflowIndicatorToolTipText = null;
            this.textBoxExt1.Size = new System.Drawing.Size(42, 13);
            this.textBoxExt1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBoxExt1.TabIndex = 0;
            // 
            // comboBox5
            // 
            this.comboBox5.BeforeTouchSize = new System.Drawing.Size(75, 21);
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.ForeColor = System.Drawing.Color.Black;
            this.comboBox5.Location = new System.Drawing.Point(132, 331);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(75, 21);
            this.comboBox5.TabIndex = 117;
            // 
            // comboBox11
            // 
            this.comboBox11.BeforeTouchSize = new System.Drawing.Size(75, 21);
            this.comboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox11.ForeColor = System.Drawing.Color.Black;
            this.comboBox11.Items.AddRange(new object[] {
            "None",
            "FixedSingle",
            "Fixed3D"});
            this.comboBox11.Location = new System.Drawing.Point(139, 291);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(75, 21);
            this.comboBox11.TabIndex = 111;
            this.comboBox11.Text = "None";
            // 
            // radioButtonAdv13
            // 
            this.radioButtonAdv13.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.radioButtonAdv13.Location = new System.Drawing.Point(215, 28);
            this.radioButtonAdv13.MetroColor = System.Drawing.Color.Empty;
            this.radioButtonAdv13.Name = "radioButtonAdv13";
            this.radioButtonAdv13.Size = new System.Drawing.Size(190, 34);
            this.radioButtonAdv13.TabIndex = 110;
            this.radioButtonAdv13.Text = "radioButtonAdv12";
            this.radioButtonAdv13.ThemesEnabled = false;
            // 
            // buttonEdit6
            // 
            this.buttonEdit6.BeforeTouchSize = new System.Drawing.Size(71, 21);
            this.buttonEdit6.Buttons.Add(this.buttonEditChildButton6);
            this.buttonEdit6.Controls.Add(this.buttonEditChildButton6);
            this.buttonEdit6.Controls.Add(this.textBoxExt2);
            this.buttonEdit6.Location = new System.Drawing.Point(156, 209);
            this.buttonEdit6.MetroColor = System.Drawing.Color.Empty;
            this.buttonEdit6.Name = "buttonEdit6";
            this.buttonEdit6.ShowTextBox = false;
            this.buttonEdit6.Size = new System.Drawing.Size(71, 21);
            this.buttonEdit6.TabIndex = 107;
            this.buttonEdit6.TextBox = this.textBoxExt2;
            this.buttonEdit6.UseVisualStyle = true;
            // 
            // buttonEditChildButton6
            // 
            this.buttonEditChildButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonEditChildButton6.BeforeTouchSize = new System.Drawing.Size(18, 17);
            this.buttonEditChildButton6.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton6.Image = null;
            this.buttonEditChildButton6.IsBackStageButton = false;
            this.buttonEditChildButton6.Name = "buttonEditChildButton6";
            this.buttonEditChildButton6.PreferredWidth = 18;
            this.buttonEditChildButton6.TabIndex = 1;
            this.buttonEditChildButton6.Text = "...";
            // 
            // buttonEdit7
            // 
            this.buttonEdit7.BeforeTouchSize = new System.Drawing.Size(64, 21);
            this.buttonEdit7.Buttons.Add(this.buttonEditChildButton7);
            this.buttonEdit7.Controls.Add(this.buttonEditChildButton7);
            this.buttonEdit7.Controls.Add(this.textBoxExt1);
            this.buttonEdit7.Location = new System.Drawing.Point(149, 182);
            this.buttonEdit7.MetroColor = System.Drawing.Color.Empty;
            this.buttonEdit7.Name = "buttonEdit7";
            this.buttonEdit7.ShowTextBox = false;
            this.buttonEdit7.Size = new System.Drawing.Size(64, 21);
            this.buttonEdit7.TabIndex = 106;
            this.buttonEdit7.TextBox = this.textBoxExt1;
            this.buttonEdit7.UseVisualStyle = true;
            // 
            // buttonEditChildButton7
            // 
            this.buttonEditChildButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonEditChildButton7.BeforeTouchSize = new System.Drawing.Size(18, 17);
            this.buttonEditChildButton7.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton7.Image = null;
            this.buttonEditChildButton7.IsBackStageButton = false;
            this.buttonEditChildButton7.Name = "buttonEditChildButton7";
            this.buttonEditChildButton7.PreferredWidth = 18;
            this.buttonEditChildButton7.TabIndex = 1;
            this.buttonEditChildButton7.Text = "...";
            // 
            // comboBox12
            // 
            this.comboBox12.BeforeTouchSize = new System.Drawing.Size(75, 21);
            this.comboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox12.ForeColor = System.Drawing.Color.Black;
            this.comboBox12.Items.AddRange(new object[] {
            "Default",
            "HorizontalGradient",
            "VerticalGradient"});
            this.comboBox12.Location = new System.Drawing.Point(125, 155);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(75, 21);
            this.comboBox12.TabIndex = 105;
            this.comboBox12.Text = "Default";
            // 
            // radioButtonAdv14
            // 
            this.radioButtonAdv14.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.radioButtonAdv14.Location = new System.Drawing.Point(274, 291);
            this.radioButtonAdv14.MetroColor = System.Drawing.Color.Empty;
            this.radioButtonAdv14.Name = "radioButtonAdv14";
            this.radioButtonAdv14.Size = new System.Drawing.Size(150, 21);
            this.radioButtonAdv14.StretchImage = false;
            this.radioButtonAdv14.TabIndex = 99;
            this.radioButtonAdv14.Text = "Office2007 - Black";
            this.radioButtonAdv14.ThemesEnabled = true;
            // 
            // radioButtonAdv15
            // 
            this.radioButtonAdv15.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.radioButtonAdv15.Location = new System.Drawing.Point(274, 253);
            this.radioButtonAdv15.MetroColor = System.Drawing.Color.Empty;
            this.radioButtonAdv15.Name = "radioButtonAdv15";
            this.radioButtonAdv15.Size = new System.Drawing.Size(150, 21);
            this.radioButtonAdv15.StretchImage = false;
            this.radioButtonAdv15.TabIndex = 98;
            this.radioButtonAdv15.Text = "Office2007 - Silver";
            this.radioButtonAdv15.ThemesEnabled = true;
            // 
            // comboBox13
            // 
            this.comboBox13.BeforeTouchSize = new System.Drawing.Size(75, 21);
            this.comboBox13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox13.ForeColor = System.Drawing.Color.Black;
            this.comboBox13.Location = new System.Drawing.Point(315, 176);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(75, 21);
            this.comboBox13.TabIndex = 97;
            // 
            // radioButtonAdv16
            // 
            this.radioButtonAdv16.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.radioButtonAdv16.Location = new System.Drawing.Point(274, 219);
            this.radioButtonAdv16.MetroColor = System.Drawing.Color.Empty;
            this.radioButtonAdv16.Name = "radioButtonAdv16";
            this.radioButtonAdv16.Size = new System.Drawing.Size(150, 21);
            this.radioButtonAdv16.StretchImage = false;
            this.radioButtonAdv16.TabIndex = 94;
            this.radioButtonAdv16.Text = "Office2007 - Blue";
            this.radioButtonAdv16.ThemesEnabled = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 379);
            this.panel2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 497);
            this.Controls.Add(this.splitContainerAdv1);
            this.Controls.Add(this.label59);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(956, 520);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBoxAdv";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel8)).EndInit();
            this.gradientPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).EndInit();
            this.groupBar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).EndInit();
            this.gradientPanel3.ResumeLayout(false);
            this.gradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).EndInit();
            this.gradientPanel4.ResumeLayout(false);
            this.gradientPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit5)).EndInit();
            this.buttonEdit5.ResumeLayout(false);
            this.buttonEdit5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel7)).EndInit();
            this.gradientPanel7.ResumeLayout(false);
            this.gradientPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel5)).EndInit();
            this.gradientPanel5.ResumeLayout(false);
            this.gradientPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1)).EndInit();
            this.buttonEdit1.ResumeLayout(false);
            this.buttonEdit1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2)).EndInit();
            this.buttonEdit2.ResumeLayout(false);
            this.buttonEdit2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel6)).EndInit();
            this.gradientPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit6)).EndInit();
            this.buttonEdit6.ResumeLayout(false);
            this.buttonEdit6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit7)).EndInit();
            this.buttonEdit7.ResumeLayout(false);
            this.buttonEdit7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv16)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        #region Main
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.Run(new Form1());
        }
        #endregion

        #region Form Load

        DataTable m_tbl = new DataTable();

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.checkBoxAdv1.ReadOnlyMode = true;
            #region CheckBoxAdv DataBinding
            m_tbl.Columns.Add("ID", typeof(int));
            m_tbl.Columns.Add("ValueStr", typeof(string));

            m_tbl.LoadDataRow(new object[] { 1, "Checked" }, true);
            m_tbl.LoadDataRow(new object[] { -1, "Indeterminate" }, true);
            m_tbl.LoadDataRow(new object[] { 0, "UnChecked" }, true);
            this.checkBoxAdv1.DataBindings.Add("IntValue", m_tbl, "ID");
            this.comboBox2.DataSource = m_tbl;
            this.comboBox2.DisplayMember = "ID";
            #endregion
            //Populate Border3DStyles
            string[] str1 = Enum.GetNames(typeof(Border3DStyle));
            comboBox6.Items.AddRange(str1);

            //Populate BorderSingle
            string[] str2 = Enum.GetNames(typeof(ButtonBorderStyle));
            comboBox14.Items.AddRange(str2);

            //Populate Content Alignment
            string[] str3 = Enum.GetNames(typeof(System.Drawing.ContentAlignment));
            comboBox19.Items.AddRange(str3);
            comboBox18.Items.AddRange(str3);
            this.comboBox1.SelectedIndex= 8;
            this.comboBox4.SelectedIndex = 0;
            this.comboBox6.SelectedIndex= 1;
             this.comboBox8.SelectedIndex = 1;
             this.comboBox14.SelectedIndex= 3;
             this.comboBox19.SelectedIndex= 3;
             this.comboBox18.SelectedIndex=3;
             this.buttonEdit1.TextBox.BackColor = Color.FromArgb(192, 192, 255);

             this.buttonEdit2.TextBox.BackColor = Color.FromArgb(255, 224, 192);
            this.checkBoxAdv1.AutoSize = false;
            this.checkBoxAdv1.Text = "Checked";
            this.checkBox6.Checked = true;
            //this.checkBoxAdv1.text
            this.label59.BorderStyle = BorderStyle.None;
            this.label59.Paint += Label59_Paint;
            this.panel1.Paint += Panel1_Paint;
            this.splitContainerAdv1.BorderStyle = BorderStyle.None;
            this.groupBar1.BorderStyle = BorderStyle.FixedSingle;
            foreach (GroupBarItem item in this.groupBar1.GroupBarItems)
            {
                item.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            this.panel2.BorderStyle = BorderStyle.None;
            
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            if (this.checkBoxAdv1.Style == CheckBoxAdvStyle.Office2016DarkGray)
                ControlPaint.DrawBorder(e.Graphics, this.panel1.DisplayRectangle, ColorTranslator.FromHtml("#444444"), ButtonBorderStyle.Solid);
            else if (this.checkBoxAdv1.Style == CheckBoxAdvStyle.Office2016Black)
                ControlPaint.DrawBorder(e.Graphics, this.panel1.DisplayRectangle, ColorTranslator.FromHtml("#444444"), ButtonBorderStyle.Solid);
            else if (this.checkBoxAdv1.Style == CheckBoxAdvStyle.Office2016Colorful || this.checkBoxAdv1.Style == CheckBoxAdvStyle.Office2016White)
                ControlPaint.DrawBorder(e.Graphics, this.panel1.DisplayRectangle, ColorTranslator.FromHtml("#c6c6c6"), ButtonBorderStyle.Solid);
            else
                ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.Gray, ButtonBorderStyle.Solid);
        }

        private void Label59_Paint(object sender, PaintEventArgs e)
        {
            if (this.checkBoxAdv1.Style == CheckBoxAdvStyle.Office2016DarkGray)
                ControlPaint.DrawBorder(e.Graphics, this.label59.DisplayRectangle, ColorTranslator.FromHtml("#444444"), ButtonBorderStyle.Solid);
            else if (this.checkBoxAdv1.Style == CheckBoxAdvStyle.Office2016Black)
                ControlPaint.DrawBorder(e.Graphics, this.label59.DisplayRectangle, ColorTranslator.FromHtml("#444444"), ButtonBorderStyle.Solid);
            else if (this.checkBoxAdv1.Style == CheckBoxAdvStyle.Office2016Colorful || this.checkBoxAdv1.Style == CheckBoxAdvStyle.Office2016White)
                ControlPaint.DrawBorder(e.Graphics, this.label59.DisplayRectangle, ColorTranslator.FromHtml("#c6c6c6"), ButtonBorderStyle.Solid);
            else
                ControlPaint.DrawBorder(e.Graphics, this.label59.ClientRectangle, Color.Gray, ButtonBorderStyle.Solid);
        }

        #endregion

        #region CheckBoxAdv PRoperties

        #region TextShadow

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            this.checkBoxAdv1.TextShadow = this.checkBox4.Checked;
        }


        #endregion

         #region ReadOnlyMode
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            this.checkBoxAdv1.ReadOnlyMode = this.checkBox6.Checked;
        }

        #endregion

         #region  ImageCheckBox
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            m_tbl = new DataTable();
            m_tbl.Columns.Add("ID", typeof(int));
            m_tbl.Columns.Add("ValueStr", typeof(string));
            this.checkBoxAdv1.DataBindings.Clear();
            this.checkBoxAdv1.DataBindings.Add("IntValue", m_tbl, "ID");
            m_tbl.LoadDataRow(new object[] { 1, "Checked" }, true);
            m_tbl.LoadDataRow(new object[] { -1, "Indeterminate" }, true);
            m_tbl.LoadDataRow(new object[] { 0, "UnChecked" }, true);
            this.comboBox2.DataSource = m_tbl;
            this.comboBox2.DisplayMember = "ID";
            this.checkBoxAdv1.ImageCheckBox = this.checkBox3.Checked;
        }

        #endregion

         #region Tristate
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            m_tbl = new DataTable();
            m_tbl.Columns.Add("ID", typeof(int));
            m_tbl.Columns.Add("ValueStr", typeof(string));
            this.checkBoxAdv1.DataBindings.Clear();
            this.checkBoxAdv1.DataBindings.Add("IntValue", m_tbl, "ID");
            m_tbl.LoadDataRow(new object[] { 1, "Checked" }, true);
            m_tbl.LoadDataRow(new object[] { -1, "Indeterminate" }, true);
            m_tbl.LoadDataRow(new object[] { 0, "UnChecked" }, true);
            this.comboBox2.DataSource = m_tbl;
            this.comboBox2.DisplayMember = "ID";
            if (this.checkBox5.Checked)
            {
                this.checkBoxAdv1.Tristate = true;
                //this.checkBoxAdv1.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            }
            else
            {
                this.checkBoxAdv1.Tristate = false;
                this.checkBoxAdv1.CheckState = System.Windows.Forms.CheckState.Checked;
            }

        }
        #endregion

         #region CheckState
        private void checkBoxAdv1_CheckStateChanged(object sender, System.EventArgs e)
        {
            if (this.checkBoxAdv1.CheckState == System.Windows.Forms.CheckState.Checked)
            {
                this.checkBoxAdv1.Text = "Checked";
            }
            else if (this.checkBoxAdv1.CheckState == System.Windows.Forms.CheckState.Unchecked)
            {
                this.checkBoxAdv1.Text = "Unchecked";
            }

            else if (this.checkBoxAdv1.CheckState == System.Windows.Forms.CheckState.Indeterminate)
            {
                this.checkBoxAdv1.Text = "Indeterminate";
            }


        }
        #endregion

         #region  BackGroundStyle
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox4.Items[comboBox4.SelectedIndex].ToString())
            {
                case "Default":
                    this.checkBoxAdv1.BackgroundStyle = Syncfusion.Windows.Forms.Tools.CheckBoxAdvBackStyle.Default;
                    break;
                case "HorizontalGradient":
                    this.checkBoxAdv1.BackgroundStyle = Syncfusion.Windows.Forms.Tools.CheckBoxAdvBackStyle.HorizontalGradient;
                    break;
                case "VerticalGradient":
                    this.checkBoxAdv1.BackgroundStyle = Syncfusion.Windows.Forms.Tools.CheckBoxAdvBackStyle.VerticalGradient;
                    break;
            }
        }

        #endregion
        
         #region Gradient Colors
        private void buttonEdit1_ButtonClicked(object sender, Syncfusion.Windows.Forms.Tools.ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                buttonEdit1.BackColor = colorDialog1.Color;
                this.checkBoxAdv1.GradientStart = colorDialog1.Color;
            }
        }

        private void buttonEdit2_ButtonClicked(object sender, Syncfusion.Windows.Forms.Tools.ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                buttonEdit2.BackColor = colorDialog1.Color;
                this.checkBoxAdv1.GradientEnd = colorDialog1.Color;
            }

        }
        #endregion

         #region  BorderStyle
        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox8.Items[comboBox8.SelectedIndex].ToString())
            {
                case "None":
                    this.checkBoxAdv1.BorderStyle = BorderStyle.None;
                    this.comboBox6.Enabled = false;
                    this.buttonEdit5.Enabled = false;
                    this.comboBox14.Enabled = false;
                    break;
                case "FixedSingle":
                    this.checkBoxAdv1.BorderStyle = BorderStyle.FixedSingle;
                    this.comboBox6.Enabled = false;
                    this.buttonEdit5.Enabled = true;
                    this.comboBox14.Enabled = true;
                    break;
                case "Fixed3D":
                    this.checkBoxAdv1.BorderStyle = BorderStyle.Fixed3D;
                    this.comboBox6.Enabled = true;
                    this.buttonEdit5.Enabled = false;
                    this.comboBox14.Enabled = false;
                    break;

            }
        }
        #endregion

         #region Border3DStyle
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox6.Items[comboBox6.SelectedIndex].ToString())
            {
                case "RaisedOuter":
                    this.checkBoxAdv1.Border3DStyle = Border3DStyle.RaisedOuter;
                    break;
                case "Adjust":
                    this.checkBoxAdv1.Border3DStyle = Border3DStyle.Adjust;
                    break;
                case "Bump":
                    this.checkBoxAdv1.Border3DStyle = Border3DStyle.Bump;
                    break;
                case "Etched":
                    this.checkBoxAdv1.Border3DStyle = Border3DStyle.Etched;
                    break;
                case "Flat":
                    this.checkBoxAdv1.Border3DStyle = Border3DStyle.Flat;
                    break;
                case "Raised":
                    this.checkBoxAdv1.Border3DStyle = Border3DStyle.Raised;
                    break;
                case "RaisedInner":
                    this.checkBoxAdv1.Border3DStyle = Border3DStyle.RaisedInner;
                    break;
                case "Sunken":
                    this.checkBoxAdv1.Border3DStyle = Border3DStyle.Sunken;
                    break;
                case "SunkenInner":
                    this.checkBoxAdv1.Border3DStyle = Border3DStyle.SunkenInner;
                    break;
                case "SunkenOuter":
                    this.checkBoxAdv1.Border3DStyle = Border3DStyle.SunkenOuter;
                    break;
            }
        }
        #endregion

         #region BorderColor
        private void buttonEdit5_ButtonClicked(object sender, Syncfusion.Windows.Forms.Tools.ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                buttonEdit5.BackColor = colorDialog1.Color;
                this.checkBoxAdv1.BorderColor = colorDialog1.Color;
            }
        }
        #endregion

         #region BorderSingleStyle

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox14.Items[comboBox14.SelectedIndex].ToString())
            {
                case "Dashed":
                    this.checkBoxAdv1.BorderSingle = ButtonBorderStyle.Dashed;
                    break;
                case "Dotted":
                    this.checkBoxAdv1.BorderSingle = ButtonBorderStyle.Dotted;
                    break;
                case "Inset":
                    this.checkBoxAdv1.BorderSingle = ButtonBorderStyle.Inset;
                    break;
                case "None":
                    this.checkBoxAdv1.BorderSingle = ButtonBorderStyle.None;
                    break;
                case "Outset":
                    this.checkBoxAdv1.BorderSingle = ButtonBorderStyle.Outset;
                    break;
                case "Solid":
                    this.checkBoxAdv1.BorderSingle = ButtonBorderStyle.Solid;
                    break;
            }

        }
        #endregion

         #region VisualStyle
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateStyle(Color.White, Color.Black);
            //this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.groupBar1.VisualStyle = VisualStyle.Metro;
            this.gradientPanel1.BorderColor = Color.Red;
            this.MetroColor = Color.White;
            this.panel2.BorderStyle = BorderStyle.FixedSingle;
            if (this.comboBox1.SelectedIndex == 0)
            {
                this.checkBox7.Checked = true;
                this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Default;
                
            }
            else if(this.comboBox1.SelectedIndex == 1)
            {
                this.checkBox7.Checked = false;
                this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2007;
                this.checkBoxAdv1.Office2007ColorScheme = Office2007Theme.Blue;
            }          
            else if (this.comboBox1.SelectedIndex == 2)
            {
                this.checkBox7.Checked = false;
                this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2007;
                this.checkBoxAdv1.Office2007ColorScheme = Office2007Theme.Silver;
            }
            else if (this.comboBox1.SelectedIndex == 3)
            {
                this.checkBox7.Checked = false;
                this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2007;
                this.checkBoxAdv1.Office2007ColorScheme = Office2007Theme.Black;
            }
            else if (this.comboBox1.SelectedIndex == 4)
            {
                this.checkBox7.Checked = false;
                this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2010;
                this.checkBoxAdv1.Office2010ColorScheme = Office2010Theme.Blue;
            }
            else if (this.comboBox1.SelectedIndex == 5)
            {
                this.checkBox7.Checked = false;
                this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2010;
                this.checkBoxAdv1.Office2010ColorScheme = Office2010Theme.Silver;
            }
            else if (this.comboBox1.SelectedIndex == 6)
            {
                this.checkBox7.Checked = false;
                this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2010;
                this.checkBoxAdv1.Office2010ColorScheme = Office2010Theme.Black;
            }
            else if (this.comboBox1.SelectedIndex == 7)
            {
                this.checkBox7.Checked = false;
                this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            }
            else if (this.comboBox1.SelectedIndex == 8)
            {
                this.checkBox7.Checked = false;
                this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                this.groupBar1.VisualStyle = VisualStyle.Office2016Colorful;
                foreach (Control ctrl in Collect(this.Controls))
                {
                    if (ctrl is ComboBoxAdv)
                    {
                        (ctrl as ComboBoxAdv).Style = VisualStyle.Office2016Colorful;
                    }
                    else if (ctrl is RadioButtonAdv)
                    {
                        (ctrl as RadioButtonAdv).Style = RadioButtonAdvStyle.Office2016Colorful;
                    }
                    else if (ctrl is CheckBoxAdv)
                    {
                        (ctrl as CheckBoxAdv).Style = CheckBoxAdvStyle.Office2016Colorful;
                    }
                    else if (ctrl is ButtonEdit)
                    {
                        (ctrl as ButtonEdit).ButtonStyle = ButtonAppearance.Office2016Colorful;
                    }
                }
                this.CaptionForeColor = Color.White;
                this.CaptionBarColor = ColorTranslator.FromHtml("#0173c7");
                this.MetroColor = ColorTranslator.FromHtml("#0173c7");
                this.CaptionButtonHoverColor = Color.White;               
                this.CaptionButtonColor = Color.White;
                this.panel2.BorderStyle = BorderStyle.None;
            }
            else if (this.comboBox1.SelectedIndex == 11)
            {
                this.checkBox7.Checked = false;
                this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                this.groupBar1.VisualStyle = VisualStyle.Office2016White;
                foreach (Control ctrl in Collect(this.Controls))
                {
                    if (ctrl is ComboBoxAdv)
                    {
                        (ctrl as ComboBoxAdv).Style = VisualStyle.Office2016White;
                    }
                    else if (ctrl is RadioButtonAdv)
                    {
                        (ctrl as RadioButtonAdv).Style = RadioButtonAdvStyle.Office2016White;
                    }
                    else if (ctrl is CheckBoxAdv)
                    {
                        (ctrl as CheckBoxAdv).Style = CheckBoxAdvStyle.Office2016White;
                    }
                    else if (ctrl is ButtonEdit)
                    {
                        (ctrl as ButtonEdit).ButtonStyle = ButtonAppearance.Office2016White;
                    }
                }
                this.panel2.BorderStyle = BorderStyle.None;
            }
            else if (this.comboBox1.SelectedIndex == 9)
            {
                this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.UpdateStyle(ColorTranslator.FromHtml("#666666"), Color.White);
                this.MetroColor = ColorTranslator.FromHtml("#505050");
                this.CaptionBarColor = ColorTranslator.FromHtml("#505050");
                this.CaptionForeColor = Color.White;
                this.CaptionButtonColor = Color.White;
                this.CaptionButtonHoverColor = Color.White;
                this.checkBox7.Checked = false;
                this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.groupBar1.VisualStyle = VisualStyle.Office2016DarkGray;
                foreach (Control ctrl in Collect(this.Controls))
                {
                    if (ctrl is ComboBoxAdv)
                    {
                        (ctrl as ComboBoxAdv).Style = VisualStyle.Office2016DarkGray;
                    }
                    else if (ctrl is RadioButtonAdv)
                    {
                        (ctrl as RadioButtonAdv).Style = RadioButtonAdvStyle.Office2016DarkGray;
                    }
                    else if (ctrl is CheckBoxAdv)
                    {
                        (ctrl as CheckBoxAdv).Style = CheckBoxAdvStyle.Office2016DarkGray;
                    }
                    else if (ctrl is ButtonEdit)
                    {
                        (ctrl as ButtonEdit).ButtonStyle = ButtonAppearance.Office2016DarkGray;
                    }
                }
                this.groupBar1.BorderColor = ColorTranslator.FromHtml("#444444");
                this.panel2.BorderStyle = BorderStyle.None;
            }
            else if (this.comboBox1.SelectedIndex == 10)
            {
                this.checkBox7.Checked = false;
                this.UpdateStyle(ColorTranslator.FromHtml("#262626"), Color.White);
                this.CaptionForeColor = Color.White;
                this.CaptionButtonColor = Color.White;
                this.CaptionButtonHoverColor = Color.White;                
                this.groupBar1.VisualStyle = VisualStyle.Office2016Black;
                this.MetroColor = ColorTranslator.FromHtml("#363636");
                this.CaptionBarColor = ColorTranslator.FromHtml("#363636");
                this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                foreach (Control ctrl in Collect(this.Controls))
                {
                    if (ctrl is ComboBoxAdv)
                    {
                        (ctrl as ComboBoxAdv).Style = VisualStyle.Office2016Black;
                    }
                    else if (ctrl is RadioButtonAdv)
                    {
                        (ctrl as RadioButtonAdv).Style = RadioButtonAdvStyle.Office2016Black;
                    }
                    else if (ctrl is CheckBoxAdv)
                    {
                        (ctrl as CheckBoxAdv).Style = CheckBoxAdvStyle.Office2016Black;
                    }
                    else if (ctrl is ButtonEdit)
                    {
                        (ctrl as ButtonEdit).ButtonStyle = ButtonAppearance.Office2016Black;
                    }
                }
                this.panel2.BorderStyle = BorderStyle.None;
            }
        }


        private void UpdateStyle(Color backColor, Color ForeColor)
        {
            this.CaptionBarColor = backColor;
            this.BackColor = backColor;
            this.MetroColor = Color.White;
            this.CaptionForeColor = Color.Black;
            this.CaptionButtonColor = Color.Black;
            this.CaptionButtonHoverColor = Color.Black;

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
                }
                else if (ctrl is CheckBoxAdv)
                {
                    (ctrl as CheckBoxAdv).Style = CheckBoxAdvStyle.Metro;
                }
                else if (ctrl is ButtonEdit)
                {
                    (ctrl as ButtonEdit).ButtonStyle = ButtonAppearance.Office2016White;
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
        
        #endregion

         #region Glyph Align
        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox19.SelectedIndex)
            {
                case 0:
                    this.checkBoxAdv1.CheckAlign = ContentAlignment.TopLeft;
                    break;
                case 1:
                    this.checkBoxAdv1.CheckAlign = ContentAlignment.TopCenter;
                    break;
                case 2:
                    this.checkBoxAdv1.CheckAlign = ContentAlignment.TopRight;
                    break;
                case 3:
                    this.checkBoxAdv1.CheckAlign = ContentAlignment.MiddleLeft;
                    break;
                case 4:
                    this.checkBoxAdv1.CheckAlign = ContentAlignment.MiddleCenter;
                    break;
                case 5:
                    this.checkBoxAdv1.CheckAlign = ContentAlignment.MiddleRight;
                    break;
                case 6:
                    this.checkBoxAdv1.CheckAlign = ContentAlignment.BottomLeft;
                    break;
                case 7:
                    this.checkBoxAdv1.CheckAlign = ContentAlignment.BottomCenter;
                    break;
                case 8:
                    this.checkBoxAdv1.CheckAlign = ContentAlignment.BottomRight;
                    break;


            }


        }
        #endregion

         #region TextAlign
        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox18.SelectedIndex)
            {
                case 0:
                    this.checkBoxAdv1.TextContentAlignment = ContentAlignment.TopLeft;
                    break;
                case 1:
                    this.checkBoxAdv1.TextContentAlignment = ContentAlignment.TopCenter;
                    break;
                case 2:
                    this.checkBoxAdv1.TextContentAlignment = ContentAlignment.TopRight;
                    break;
                case 3:
                    this.checkBoxAdv1.TextContentAlignment = ContentAlignment.MiddleLeft;
                    break;
                case 4:
                    this.checkBoxAdv1.TextContentAlignment = ContentAlignment.MiddleCenter;
                    break;
                case 5:
                    this.checkBoxAdv1.TextContentAlignment = ContentAlignment.MiddleRight;
                    break;
                case 6:
                    this.checkBoxAdv1.TextContentAlignment = ContentAlignment.BottomLeft;
                    break;
                case 7:
                    this.checkBoxAdv1.TextContentAlignment = ContentAlignment.BottomCenter;
                    break;
                case 8:
                    this.checkBoxAdv1.TextContentAlignment = ContentAlignment.BottomRight;
                    break;


            }

        }
        #endregion

         #region ThemesEnabled
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            this.checkBoxAdv1.ThemesEnabled = checkBox7.Checked;
        }
        #endregion

      

        #endregion
        
       

       

       

        #region DataBinding

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            CurrencyManager mgr = (CurrencyManager)(BindingContext[m_dt]);
            if (mgr.Position < mgr.Count - 1)
            {
                mgr.Position = mgr.Position + 1;
            }
            else if (mgr.Position > 0)
                mgr.Position = mgr.Position - 1;
        }
        #endregion

        private void groupBar1_GroupBarItemSelected(object sender, EventArgs e)
        {

        }
    }
}