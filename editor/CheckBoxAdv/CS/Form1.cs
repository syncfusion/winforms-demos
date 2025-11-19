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
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System.Collections.Generic;
using Syncfusion.Licensing;

namespace CheckBoxAdvDemo
{
    using Syncfusion.Licensing;
    using Syncfusion.WinForms.Controls;

    public class Form1 : SfForm
    {
        #region Declarations
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBox2;
        private System.Windows.Forms.ImageList imageList1;
        private ComboBoxAdv comboBox6;
        private ComboBoxAdv comboBox1;
        private ComboBoxAdv comboBox4;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
        private ColorDialog colorDialog1;
        private ComboBoxAdv comboBox8;
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
        private ComboBoxAdv comboBox18;
        private ComboBoxAdv comboBox19;
        DataTable m_dt = null;
        private ToolTip toolTip1;
        private Panel panel1;
        private CheckBoxAdv checkBoxAdv3;
        private CheckBoxAdv checkBoxAdv2;
        private CheckBoxAdv checkBoxAdv6;
        private CheckBoxAdv checkBoxAdv1;
        private CheckBoxAdv checkBoxAdv4;
        private CheckBoxAdv checkBoxAdv5;
        private AutoLabel autoLabel10;
        private Syncfusion.WinForms.ListView.SfComboBox sfComboBox1;
        private System.ComponentModel.IContainer components;
        #endregion

        #region Constructor And Dispose
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            List<string> style = new List<string>();
            style.Add("Office2019Colorful");
            style.Add("HighContrastBlack");
            style.Add("Office2016Colorful");
            style.Add("Office2016White");
            style.Add("Office2016DarkGray");
            style.Add("Office2016Black");
            this.sfComboBox1.DataSource = style;
            this.sfComboBox1.SelectedIndex = 0;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
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

        //Get and Load the images
#if NET9_0_OR_GREATER
        private static Image GetImage(string path)
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            if (asm != null && !string.IsNullOrEmpty(path))
                return Image.FromStream(asm.GetManifestResourceStream(path));
            return null;
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.comboBox2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBox1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBox19 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBox18 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBox6 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBox8 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBox14 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBox4 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.autoLabel10 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.sfComboBox1 = new Syncfusion.WinForms.ListView.SfComboBox();
            this.checkBoxAdv5 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv4 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv3 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv6 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label27 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox4)).BeginInit();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv6)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
#if NET9_0_OR_GREATER
            this.imageList1.Images.Add(GetImage("OptionControls_2005.Images.ImageList1.Image_1.png"));
#else
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
#endif
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label28.Location = new System.Drawing.Point(23, 277);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(150, 1);
            this.label28.TabIndex = 115;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(18, 291);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(64, 13);
            this.label29.TabIndex = 114;
            this.label29.Text = "Border Style";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(18, 329);
            this.label30.Margin = new System.Windows.Forms.Padding(0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(78, 13);
            this.label30.TabIndex = 112;
            this.label30.Text = "Border3D Style";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(18, 215);
            this.label31.Margin = new System.Windows.Forms.Padding(0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(96, 13);
            this.label31.TabIndex = 109;
            this.label31.Text = "Gradient End Color";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(22, 188);
            this.label32.Margin = new System.Windows.Forms.Padding(0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(99, 13);
            this.label32.TabIndex = 108;
            this.label32.Text = "Gradient Start Color";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(22, 161);
            this.label33.Margin = new System.Windows.Forms.Padding(0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(93, 13);
            this.label33.TabIndex = 104;
            this.label33.Text = "BackGround Style";
            // 
            // label35
            // 
            this.label35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label35.Location = new System.Drawing.Point(22, 145);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(150, 1);
            this.label35.TabIndex = 102;
            // 
            // label37
            // 
            this.label37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label37.Location = new System.Drawing.Point(249, 121);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(150, 1);
            this.label37.TabIndex = 95;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.BeforeTouchSize = new System.Drawing.Size(136, 21);
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox2.Location = new System.Drawing.Point(281, 166);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(136, 21);
            this.comboBox2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox2.TabIndex = 23;
            this.comboBox2.ThemeName = "Office2019Colorful";
            this.comboBox2.UseMetroColorsInActiveMode = true;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.BeforeTouchSize = new System.Drawing.Size(131, 21);
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox1.Location = new System.Drawing.Point(75, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 21);
            this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox1.TabIndex = 91;
            this.comboBox1.ThemeName = "Metro";
            this.comboBox1.UseMetroColorsInActiveMode = true;
            // 
            // comboBox19
            // 
            this.comboBox19.BackColor = System.Drawing.Color.White;
            this.comboBox19.BeforeTouchSize = new System.Drawing.Size(99, 21);
            this.comboBox19.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox19.Location = new System.Drawing.Point(116, 54);
            this.comboBox19.Name = "comboBox19";
            this.comboBox19.Size = new System.Drawing.Size(99, 21);
            this.comboBox19.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox19.TabIndex = 138;
            this.comboBox19.ThemeName = "Metro";
            // 
            // comboBox18
            // 
            this.comboBox18.BackColor = System.Drawing.Color.White;
            this.comboBox18.BeforeTouchSize = new System.Drawing.Size(99, 21);
            this.comboBox18.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox18.Location = new System.Drawing.Point(116, 98);
            this.comboBox18.Name = "comboBox18";
            this.comboBox18.Size = new System.Drawing.Size(99, 21);
            this.comboBox18.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox18.TabIndex = 141;
            this.comboBox18.ThemeName = "Metro";
            // 
            // comboBox6
            // 
            this.comboBox6.BackColor = System.Drawing.Color.White;
            this.comboBox6.BeforeTouchSize = new System.Drawing.Size(101, 21);
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox6.Location = new System.Drawing.Point(115, 95);
            this.comboBox6.MetroColor = System.Drawing.Color.Gray;
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(101, 21);
            this.comboBox6.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox6.TabIndex = 78;
            this.comboBox6.ThemeName = "Metro";
            this.comboBox6.UseMetroColorsInActiveMode = true;
            // 
            // comboBox8
            // 
            this.comboBox8.BackColor = System.Drawing.Color.White;
            this.comboBox8.BeforeTouchSize = new System.Drawing.Size(101, 21);
            this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox8.Location = new System.Drawing.Point(114, 32);
            this.comboBox8.MetroColor = System.Drawing.Color.Gray;
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(101, 21);
            this.comboBox8.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox8.TabIndex = 102;
            this.comboBox8.ThemeName = "Metro";
            this.comboBox8.UseMetroColorsInActiveMode = true;
            // 
            // comboBox14
            // 
            this.comboBox14.BackColor = System.Drawing.Color.White;
            this.comboBox14.BeforeTouchSize = new System.Drawing.Size(101, 21);
            this.comboBox14.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox14.Location = new System.Drawing.Point(115, 145);
            this.comboBox14.MetroColor = System.Drawing.Color.Gray;
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(101, 21);
            this.comboBox14.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox14.TabIndex = 106;
            this.comboBox14.ThemeName = "Metro";
            this.comboBox14.UseMetroColorsInActiveMode = true;
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.White;
            this.comboBox4.BeforeTouchSize = new System.Drawing.Size(143, 21);
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox4.Location = new System.Drawing.Point(75, 46);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(143, 21);
            this.comboBox4.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox4.TabIndex = 97;
            this.comboBox4.ThemeName = "Metro";
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
            this.textBoxExt2.TabIndex = 0;
            this.textBoxExt2.ThemeName = "Default";
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
            this.textBoxExt1.TabIndex = 0;
            this.textBoxExt1.ThemeName = "Default";
            // 
            // comboBox5
            // 
            this.comboBox5.BeforeTouchSize = new System.Drawing.Size(75, 21);
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.ForeColor = System.Drawing.Color.Black;
            this.comboBox5.Location = new System.Drawing.Point(125, 329);
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
            this.comboBox11.Location = new System.Drawing.Point(132, 289);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(75, 21);
            this.comboBox11.TabIndex = 111;
            this.comboBox11.Text = "None";
            // 
            // radioButtonAdv13
            // 
            this.radioButtonAdv13.Location = new System.Drawing.Point(208, 26);
            this.radioButtonAdv13.MetroColor = System.Drawing.Color.Empty;
            this.radioButtonAdv13.Name = "radioButtonAdv13";
            this.radioButtonAdv13.Size = new System.Drawing.Size(190, 34);
            this.radioButtonAdv13.TabIndex = 110;
            this.radioButtonAdv13.Text = "radioButtonAdv12";
            // 
            // buttonEdit6
            // 
            this.buttonEdit6.BeforeTouchSize = new System.Drawing.Size(71, 21);
            this.buttonEdit6.Buttons.Add(this.buttonEditChildButton6);
            this.buttonEdit6.Controls.Add(this.buttonEditChildButton6);
            this.buttonEdit6.Controls.Add(this.textBoxExt2);
            this.buttonEdit6.Location = new System.Drawing.Point(149, 207);
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
            this.buttonEditChildButton6.Name = "buttonEditChildButton6";
            this.buttonEditChildButton6.PreferredWidth = 18;
            this.buttonEditChildButton6.TabIndex = 1;
            this.buttonEditChildButton6.Text = "...";
            this.buttonEditChildButton6.ThemeName = "WindowsXP";
            // 
            // buttonEdit7
            // 
            this.buttonEdit7.BeforeTouchSize = new System.Drawing.Size(64, 21);
            this.buttonEdit7.Buttons.Add(this.buttonEditChildButton7);
            this.buttonEdit7.Controls.Add(this.buttonEditChildButton7);
            this.buttonEdit7.Controls.Add(this.textBoxExt1);
            this.buttonEdit7.Location = new System.Drawing.Point(142, 180);
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
            this.buttonEditChildButton7.Name = "buttonEditChildButton7";
            this.buttonEditChildButton7.PreferredWidth = 18;
            this.buttonEditChildButton7.TabIndex = 1;
            this.buttonEditChildButton7.Text = "...";
            this.buttonEditChildButton7.ThemeName = "WindowsXP";
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
            this.comboBox12.Location = new System.Drawing.Point(118, 153);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(75, 21);
            this.comboBox12.TabIndex = 105;
            this.comboBox12.Text = "Default";
            // 
            // radioButtonAdv14
            // 
            this.radioButtonAdv14.Location = new System.Drawing.Point(267, 289);
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
            this.radioButtonAdv15.Location = new System.Drawing.Point(267, 251);
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
            this.comboBox13.Location = new System.Drawing.Point(308, 174);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(75, 21);
            this.comboBox13.TabIndex = 97;
            // 
            // radioButtonAdv16
            // 
            this.radioButtonAdv16.Location = new System.Drawing.Point(267, 217);
            this.radioButtonAdv16.MetroColor = System.Drawing.Color.Empty;
            this.radioButtonAdv16.Name = "radioButtonAdv16";
            this.radioButtonAdv16.Size = new System.Drawing.Size(150, 21);
            this.radioButtonAdv16.StretchImage = false;
            this.radioButtonAdv16.TabIndex = 94;
            this.radioButtonAdv16.Text = "Office2007 - Blue";
            this.radioButtonAdv16.ThemesEnabled = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.autoLabel10);
            this.panel1.Controls.Add(this.sfComboBox1);
            this.panel1.Controls.Add(this.checkBoxAdv5);
            this.panel1.Controls.Add(this.checkBoxAdv4);
            this.panel1.Controls.Add(this.checkBoxAdv1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.checkBoxAdv3);
            this.panel1.Controls.Add(this.checkBoxAdv2);
            this.panel1.Controls.Add(this.checkBoxAdv6);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 270);
            this.panel1.TabIndex = 24;
            // 
            // autoLabel10
            // 
            this.autoLabel10.BackColor = System.Drawing.SystemColors.Control;
            this.autoLabel10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.autoLabel10.Location = new System.Drawing.Point(162, 10);
            this.autoLabel10.Name = "autoLabel10";
            this.autoLabel10.Size = new System.Drawing.Size(98, 19);
            this.autoLabel10.TabIndex = 106;
            this.autoLabel10.Text = "Choose theme";
            this.autoLabel10.ThemeName = "Default";
            this.autoLabel10.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // sfComboBox1
            // 
            this.sfComboBox1.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.sfComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfComboBox1.Location = new System.Drawing.Point(260, 9);
            this.sfComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.sfComboBox1.Name = "sfComboBox1";
            this.sfComboBox1.Size = new System.Drawing.Size(157, 20);
            this.sfComboBox1.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfComboBox1.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfComboBox1.TabIndex = 105;
            this.sfComboBox1.SelectedIndexChanged += new System.EventHandler(this.sfComboBox1_SelectedIndexChanged_1);
            // 
            // checkBoxAdv5
            // 
            this.checkBoxAdv5.Checked = true;
            this.checkBoxAdv5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv5.Enabled = false;
            this.checkBoxAdv5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv5.Location = new System.Drawing.Point(279, 228);
            this.checkBoxAdv5.Name = "checkBoxAdv5";
            this.checkBoxAdv5.Size = new System.Drawing.Size(150, 21);
            this.checkBoxAdv5.TabIndex = 26;
            this.checkBoxAdv5.Text = "Disabled CheckBox";
            this.checkBoxAdv5.ThemeName = "Office2019Colorful";
            // 
            // checkBoxAdv4
            // 
            this.checkBoxAdv4.BeforeTouchSize = new System.Drawing.Size(151, 31);
            this.checkBoxAdv4.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.checkBoxAdv4.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None;
            this.checkBoxAdv4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkBoxAdv4.Checked = true;
            this.checkBoxAdv4.CheckedImage = ((System.Drawing.Image)(resources.GetObject("checkBoxAdv4.CheckedImage")));
            this.checkBoxAdv4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv4.DrawFocusRectangle = false;
            this.checkBoxAdv4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.checkBoxAdv4.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.checkBoxAdv4.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.checkBoxAdv4.ImageCheckBox = true;
            this.checkBoxAdv4.ImageCheckBoxSize = new System.Drawing.Size(30, 30);
            this.checkBoxAdv4.IndeterminateImage = ((System.Drawing.Image)(resources.GetObject("checkBoxAdv4.IndeterminateImage")));
            this.checkBoxAdv4.Location = new System.Drawing.Point(278, 79);
            this.checkBoxAdv4.Name = "checkBoxAdv4";
            this.checkBoxAdv4.Size = new System.Drawing.Size(151, 31);
            this.checkBoxAdv4.StretchImage = false;
            this.checkBoxAdv4.TabIndex = 25;
            this.checkBoxAdv4.Text = "Image CheckBox";
            this.checkBoxAdv4.ThemeName = "Default";
            this.checkBoxAdv4.Tristate = true;
            this.checkBoxAdv4.UncheckedImage = ((System.Drawing.Image)(resources.GetObject("checkBoxAdv4.UncheckedImage")));
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.BeforeTouchSize = new System.Drawing.Size(142, 21);
            this.checkBoxAdv1.Checked = true;
            this.checkBoxAdv1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv1.Location = new System.Drawing.Point(279, 139);
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(142, 21);
            this.checkBoxAdv1.TabIndex = 4;
            this.checkBoxAdv1.Text = "Databinding (0,-1,1)";
            this.checkBoxAdv1.ThemeName = "Office2019Colorful";
            // 
            // checkBoxAdv3
            // 
            this.checkBoxAdv3.Checked = true;
            this.checkBoxAdv3.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.checkBoxAdv3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv3.Location = new System.Drawing.Point(21, 228);
            this.checkBoxAdv3.Name = "checkBoxAdv3";
            this.checkBoxAdv3.Size = new System.Drawing.Size(150, 21);
            this.checkBoxAdv3.TabIndex = 2;
            this.checkBoxAdv3.Text = "TriState CheckBox";
            this.checkBoxAdv3.ThemeName = "Office2019Colorful";
            this.checkBoxAdv3.Tristate = true;
            // 
            // checkBoxAdv2
            // 
            this.checkBoxAdv2.Checked = true;
            this.checkBoxAdv2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv2.Location = new System.Drawing.Point(21, 154);
            this.checkBoxAdv2.Name = "checkBoxAdv2";
            this.checkBoxAdv2.ReadOnlyMode = true;
            this.checkBoxAdv2.Size = new System.Drawing.Size(150, 21);
            this.checkBoxAdv2.TabIndex = 1;
            this.checkBoxAdv2.Text = "ReadOnly CheckBox";
            this.checkBoxAdv2.ThemeName = "Office2019Colorful";
            // 
            // checkBoxAdv6
            // 
            this.checkBoxAdv6.Checked = true;
            this.checkBoxAdv6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv6.Location = new System.Drawing.Point(21, 82);
            this.checkBoxAdv6.Name = "checkBoxAdv6";
            this.checkBoxAdv6.Size = new System.Drawing.Size(150, 21);
            this.checkBoxAdv6.TabIndex = 0;
            this.checkBoxAdv6.Text = "CheckBox";
            this.checkBoxAdv6.ThemeName = "Office2019Colorful";
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label27.Image = ((System.Drawing.Image)(resources.GetObject("label27.Image")));
            this.label27.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label27.Location = new System.Drawing.Point(23, 253);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(114, 24);
            this.label27.TabIndex = 116;
            this.label27.Text = "Border Settings";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label34
            // 
            this.label34.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label34.Image = ((System.Drawing.Image)(resources.GetObject("label34.Image")));
            this.label34.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label34.Location = new System.Drawing.Point(18, 121);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(147, 24);
            this.label34.TabIndex = 103;
            this.label34.Text = "Background Settings";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label36
            // 
            this.label36.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label36.Image = ((System.Drawing.Image)(resources.GetObject("label36.Image")));
            this.label36.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label36.Location = new System.Drawing.Point(249, 97);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(95, 24);
            this.label36.TabIndex = 96;
            this.label36.Text = "Visual Styles";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 297);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Box";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox4)).EndInit();
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv6)).EndInit();
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
            SkinManager.LoadAssembly(typeof(Syncfusion.WinForms.Themes.Office2019Theme).Assembly);
            SkinManager.LoadAssembly(typeof(Syncfusion.WinForms.Themes.Office2016Theme).Assembly);
            SkinManager.LoadAssembly(typeof(Syncfusion.HighContrastTheme.WinForms.HighContrastTheme).Assembly);
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
            this.checkBoxAdv1.AutoSize = false;      
          
        }      
        #endregion
         #region  ImageCheckBox
        //private void checkBox3_CheckedChanged(object sender, EventArgs e)
        //{
        //    m_tbl = new DataTable();
        //    m_tbl.Columns.Add("ID", typeof(int));
        //    m_tbl.Columns.Add("ValueStr", typeof(string));
        //    this.checkBoxAdv1.DataBindings.Clear();
        //    this.checkBoxAdv1.DataBindings.Add("IntValue", m_tbl, "ID");
        //    m_tbl.LoadDataRow(new object[] { 1, "Checked" }, true);
        //    m_tbl.LoadDataRow(new object[] { -1, "Indeterminate" }, true);
        //    m_tbl.LoadDataRow(new object[] { 0, "UnChecked" }, true);
        //    this.comboBox2.DataSource = m_tbl;
        //    this.comboBox2.DisplayMember = "ID";
        //}

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

        private void sfComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (this.sfComboBox1.SelectedItem.ToString() == "Office2019Colorful")
            {
                this.BackColor = ColorTranslator.FromHtml("#f3f3f3");
                SkinManager.SetVisualStyle(this, "Office2019Colorful");
            }
            else if (this.sfComboBox1.SelectedItem.ToString() == "HighContrastBlack")
            {
                this.BackColor = ColorTranslator.FromHtml("#000000");
                SkinManager.SetVisualStyle(this, "HighContrastBlack");
            }
            else if (this.sfComboBox1.SelectedItem.ToString() == "Office2016Colorful")
            {
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                SkinManager.SetVisualStyle(this, "Office2016Colorful");
            }
            else if (this.sfComboBox1.SelectedItem.ToString() == "Office2016White")
            {
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                SkinManager.SetVisualStyle(this, "Office2016White");
            }
            else if (this.sfComboBox1.SelectedItem.ToString() == "Office2016DarkGray")
            {
                this.BackColor = ColorTranslator.FromHtml("#666666");
                SkinManager.SetVisualStyle(this, "Office2016DarkGray");
            }
            else if (this.sfComboBox1.SelectedItem.ToString() == "Office2016Black")
            {
                this.BackColor = ColorTranslator.FromHtml("#252525");
                SkinManager.SetVisualStyle(this, "Office2016Black");
            }
        }
    }
}