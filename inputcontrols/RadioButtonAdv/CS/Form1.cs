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
using System.Drawing.Drawing2D;
using System.Collections.Generic;

namespace CheckBoxAdvDemo
{
    using Syncfusion.Licensing;
    public class Form1 : MetroForm
    {
        #region Declarations
        public Color startcolor = Color.LightGreen;
        public Color endcolor = Color.Green;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBox2;
        private System.Windows.Forms.ImageList imageList1;
        private ComboBoxAdv comboBox6;
        private ComboBoxAdv comboBox1;
        private ComboBoxAdv comboBox4;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv12;
        private Label label17;
        private Label label18;
        private Syncfusion.Windows.Forms.Tools.ButtonEdit buttonEdit3;
        private Syncfusion.Windows.Forms.Tools.ButtonEditChildButton buttonEditChildButton3;
        private Syncfusion.Windows.Forms.Tools.ButtonEdit buttonEdit4;
        private Syncfusion.Windows.Forms.Tools.ButtonEditChildButton buttonEditChildButton4;
        private ComboBoxAdv comboBox7;
        private Label label19;
        private ColorDialog colorDialog1;
        private ComboBoxAdv comboBox8;
        private ComboBoxAdv comboBox9;
        private ComboBoxAdv comboBox10;
        private Label label24;
        private Label label26;
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
        private ComboBoxAdv comboBox15;
        private Label label38;
        private Label label41;
        private Syncfusion.Windows.Forms.Tools.ButtonEdit buttonEdit8;
        private Syncfusion.Windows.Forms.Tools.ButtonEditChildButton buttonEditChildButton8;
        private ButtonAdv buttonAdv1;
        private CheckBoxAdv checkBox1;
        private ComboBoxAdv comboBox3;
        private Label label42;
        private CheckBoxAdv checkBox9;
        private ComboBoxAdv comboBox17;
        private Label label48;
        private Label label47;
        private ComboBoxAdv comboBox16;
        private ComboBoxAdv comboBox18;
        private ComboBoxAdv comboBox19;
        DataTable m_dt;
        private Label label54;
        private CheckBoxAdv checkBox8;
        private ToolTip toolTip1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Label label57;
        private Label label60;
        private CheckBoxAdv checkBox2;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel8;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel7;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel6;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel4;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private GroupBar groupBar2;
        private GroupBarItem groupBarItem5;
        private GroupBarItem groupBarItem6;
        private GroupBarItem groupBarItem7;
        private GroupBarItem groupBarItem8;
        private GroupBarItem groupBarItem1;
        private SplitContainerAdv splitContainerAdv1;
        private Panel panel2;
        private ComboBoxAdv comboBoxAdv1;
        private Label label50;
        private Label label49;
        private ComboBoxAdv comboBoxAdv2;
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
            this.comboBox2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.comboBox1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBox6 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBox8 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBox14 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBox4 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBox19 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBox18 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.groupBar2 = new Syncfusion.Windows.Forms.Tools.GroupBar();
            this.gradientPanel6 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.comboBox9 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.comboBox10 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.buttonEdit8 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton8 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.label41 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.comboBox15 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.gradientPanel8 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBox7 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.buttonEdit4 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton4 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.buttonEdit3 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton3 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.label18 = new System.Windows.Forms.Label();
            this.gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.checkBox1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox9 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox8 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.comboBoxAdv2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label42 = new System.Windows.Forms.Label();
            this.comboBox3 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.groupBarItem5 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem6 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem7 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem8 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem1 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.comboBox16 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.comboBox17 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.gradientPanel7 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label54 = new System.Windows.Forms.Label();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label60 = new System.Windows.Forms.Label();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.radioButtonAdv12 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.label57 = new System.Windows.Forms.Label();
            this.textBoxExt2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.comboBox5 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.comboBox11 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.radioButtonAdv13 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.buttonEdit6 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton6 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.buttonEdit7 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton7 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.comboBox12 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.radioButtonAdv14 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonAdv15 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.comboBox13 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.radioButtonAdv16 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBar2)).BeginInit();
            this.groupBar2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel6)).BeginInit();
            this.gradientPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit8)).BeginInit();
            this.buttonEdit8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel8)).BeginInit();
            this.gradientPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit4)).BeginInit();
            this.buttonEdit4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit3)).BeginInit();
            this.buttonEdit3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).BeginInit();
            this.gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox8)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).BeginInit();
            this.gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel7)).BeginInit();
            this.gradientPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv12)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.BeforeTouchSize = new System.Drawing.Size(116, 21);
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.Location = new System.Drawing.Point(39, 111);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(116, 21);
            this.comboBox2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox2.TabIndex = 23;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.BeforeTouchSize = new System.Drawing.Size(134, 28);
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.Location = new System.Drawing.Point(92, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 28);
            this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox1.TabIndex = 91;
            // 
            // comboBox6
            // 
            this.comboBox6.BackColor = System.Drawing.Color.White;
            this.comboBox6.BeforeTouchSize = new System.Drawing.Size(101, 21);
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FlatBorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.ForeColor = System.Drawing.Color.Black;
            this.comboBox6.Location = new System.Drawing.Point(127, 75);
            this.comboBox6.MetroColor = System.Drawing.Color.Gray;
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(101, 21);
            this.comboBox6.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox6.TabIndex = 78;
            // 
            // comboBox8
            // 
            this.comboBox8.BackColor = System.Drawing.Color.White;
            this.comboBox8.BeforeTouchSize = new System.Drawing.Size(101, 21);
            this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox8.FlatBorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox8.ForeColor = System.Drawing.Color.Black;
            this.comboBox8.Location = new System.Drawing.Point(126, 20);
            this.comboBox8.MetroColor = System.Drawing.Color.Gray;
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(101, 21);
            this.comboBox8.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox8.TabIndex = 102;
            // 
            // comboBox14
            // 
            this.comboBox14.BackColor = System.Drawing.Color.White;
            this.comboBox14.BeforeTouchSize = new System.Drawing.Size(101, 21);
            this.comboBox14.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox14.FlatBorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox14.ForeColor = System.Drawing.Color.Black;
            this.comboBox14.Location = new System.Drawing.Point(127, 128);
            this.comboBox14.MetroColor = System.Drawing.Color.Gray;
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(101, 21);
            this.comboBox14.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox14.TabIndex = 106;
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.White;
            this.comboBox4.BeforeTouchSize = new System.Drawing.Size(106, 28);
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.ForeColor = System.Drawing.Color.Black;
            this.comboBox4.Location = new System.Drawing.Point(106, 41);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(106, 28);
            this.comboBox4.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox4.TabIndex = 97;
            // 
            // comboBox19
            // 
            this.comboBox19.BackColor = System.Drawing.Color.White;
            this.comboBox19.BeforeTouchSize = new System.Drawing.Size(99, 21);
            this.comboBox19.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox19.ForeColor = System.Drawing.Color.Black;
            this.comboBox19.Location = new System.Drawing.Point(65, 51);
            this.comboBox19.Name = "comboBox19";
            this.comboBox19.Size = new System.Drawing.Size(99, 21);
            this.comboBox19.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox19.TabIndex = 138;
            // 
            // comboBox18
            // 
            this.comboBox18.BackColor = System.Drawing.Color.White;
            this.comboBox18.BeforeTouchSize = new System.Drawing.Size(99, 21);
            this.comboBox18.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox18.ForeColor = System.Drawing.Color.Black;
            this.comboBox18.Location = new System.Drawing.Point(65, 95);
            this.comboBox18.Name = "comboBox18";
            this.comboBox18.Size = new System.Drawing.Size(99, 21);
            this.comboBox18.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox18.TabIndex = 141;
            // 
            // groupBar2
            // 
            this.groupBar2.AllowDrop = true;
            this.groupBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBar2.BeforeTouchSize = new System.Drawing.Size(256, 346);
            this.groupBar2.BorderColor = System.Drawing.Color.White;
            this.groupBar2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupBar2.CollapseImage = ((System.Drawing.Image)(resources.GetObject("groupBar2.CollapseImage")));
            this.groupBar2.Controls.Add(this.gradientPanel6);
            this.groupBar2.Controls.Add(this.panel2);
            this.groupBar2.Controls.Add(this.gradientPanel8);
            this.groupBar2.Controls.Add(this.gradientPanel3);
            this.groupBar2.Controls.Add(this.gradientPanel4);
            this.groupBar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBar2.ExpandButtonToolTip = null;
            this.groupBar2.ExpandImage = ((System.Drawing.Image)(resources.GetObject("groupBar2.ExpandImage")));
            this.groupBar2.FlatLook = true;
            this.groupBar2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBar2.ForeColor = System.Drawing.Color.White;
            this.groupBar2.GroupBarDropDownToolTip = null;
            this.groupBar2.GroupBarItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupBarItem[] {
            this.groupBarItem5,
            this.groupBarItem6,
            this.groupBarItem7,
            this.groupBarItem8,
            this.groupBarItem1});
            this.groupBar2.IndexOnVisibleItems = true;
            this.groupBar2.Location = new System.Drawing.Point(0, 0);
            this.groupBar2.MinimizeButtonToolTip = null;
            this.groupBar2.Name = "groupBar2";
            this.groupBar2.NavigationPaneTooltip = null;
            this.groupBar2.PopupClientSize = new System.Drawing.Size(0, 0);
            this.groupBar2.SelectedItem = 1;
            this.groupBar2.Size = new System.Drawing.Size(256, 346);
            this.groupBar2.SmartSizeBox = false;
            this.groupBar2.Splittercolor = System.Drawing.SystemColors.ControlDark;
            this.groupBar2.TabIndex = 162;
            this.groupBar2.Text = "groupBar2";
            this.groupBar2.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.groupBar2.GroupBarItemSelected += new System.EventHandler(this.groupBar2_GroupBarItemSelected);
            // 
            // gradientPanel6
            // 
            this.gradientPanel6.BackColor = System.Drawing.Color.White;
            this.gradientPanel6.BorderColor = System.Drawing.Color.DarkGray;
            this.gradientPanel6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel6.Controls.Add(this.comboBox9);
            this.gradientPanel6.Controls.Add(this.label26);
            this.gradientPanel6.Controls.Add(this.label24);
            this.gradientPanel6.Controls.Add(this.comboBox10);
            this.gradientPanel6.Controls.Add(this.buttonEdit8);
            this.gradientPanel6.Controls.Add(this.label41);
            this.gradientPanel6.Controls.Add(this.label38);
            this.gradientPanel6.Controls.Add(this.comboBox15);
            this.gradientPanel6.Location = new System.Drawing.Point(0, 44);
            this.gradientPanel6.Name = "gradientPanel6";
            this.gradientPanel6.Size = new System.Drawing.Size(256, 236);
            this.gradientPanel6.TabIndex = 158;
            // 
            // comboBox9
            // 
            this.comboBox9.BackColor = System.Drawing.Color.White;
            this.comboBox9.BeforeTouchSize = new System.Drawing.Size(120, 21);
            this.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox9.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox9.ForeColor = System.Drawing.Color.Black;
            this.comboBox9.Items.AddRange(new object[] {
            "None",
            "FixedSingle",
            "Fixed3D"});
            this.comboBox9.Location = new System.Drawing.Point(122, 32);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(120, 21);
            this.comboBox9.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox9.TabIndex = 111;
            this.comboBox9.Text = "None";
            this.comboBox9.SelectedIndexChanged += new System.EventHandler(this.comboBox9_SelectedIndexChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(3, 80);
            this.label26.Margin = new System.Windows.Forms.Padding(0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(84, 13);
            this.label26.TabIndex = 112;
            this.label26.Text = "Border3D Style";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(3, 37);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(70, 13);
            this.label24.TabIndex = 114;
            this.label24.Text = "Border Style";
            // 
            // comboBox10
            // 
            this.comboBox10.BackColor = System.Drawing.Color.White;
            this.comboBox10.BeforeTouchSize = new System.Drawing.Size(120, 21);
            this.comboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox10.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox10.ForeColor = System.Drawing.Color.Black;
            this.comboBox10.Location = new System.Drawing.Point(122, 76);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(120, 21);
            this.comboBox10.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox10.TabIndex = 117;
            this.comboBox10.SelectedIndexChanged += new System.EventHandler(this.comboBox10_SelectedIndexChanged);
            // 
            // buttonEdit8
            // 
            this.buttonEdit8.BeforeTouchSize = new System.Drawing.Size(120, 23);
            this.buttonEdit8.Buttons.Add(this.buttonEditChildButton8);
            this.buttonEdit8.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonEdit8.Controls.Add(this.buttonEditChildButton8);
            this.buttonEdit8.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit8.Location = new System.Drawing.Point(122, 168);
            this.buttonEdit8.MetroColor = System.Drawing.Color.Gainsboro;
            this.buttonEdit8.Name = "buttonEdit8";
            this.buttonEdit8.ShowTextBox = false;
            this.buttonEdit8.Size = new System.Drawing.Size(120, 23);
            this.buttonEdit8.TabIndex = 118;
            this.buttonEdit8.UseVisualStyle = true;
            this.buttonEdit8.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit8_ButtonClicked);
            // 
            // buttonEditChildButton8
            // 
            this.buttonEditChildButton8.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonEditChildButton8.BeforeTouchSize = new System.Drawing.Size(18, 19);
            this.buttonEditChildButton8.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.buttonEditChildButton8.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton8.ForeColor = System.Drawing.Color.White;
            this.buttonEditChildButton8.Image = null;
            this.buttonEditChildButton8.IsBackStageButton = false;
            this.buttonEditChildButton8.Name = "buttonEditChildButton8";
            this.buttonEditChildButton8.PreferredWidth = 18;
            this.buttonEditChildButton8.TabIndex = 1;
            this.buttonEditChildButton8.Text = "...";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.Black;
            this.label41.Location = new System.Drawing.Point(3, 173);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(73, 13);
            this.label41.TabIndex = 119;
            this.label41.Text = "Border Color";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.Black;
            this.label38.Location = new System.Drawing.Point(3, 127);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(76, 13);
            this.label38.TabIndex = 120;
            this.label38.Text = "Border Single";
            // 
            // comboBox15
            // 
            this.comboBox15.BackColor = System.Drawing.Color.White;
            this.comboBox15.BeforeTouchSize = new System.Drawing.Size(120, 21);
            this.comboBox15.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox15.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox15.ForeColor = System.Drawing.Color.Black;
            this.comboBox15.Location = new System.Drawing.Point(122, 123);
            this.comboBox15.Name = "comboBox15";
            this.comboBox15.Size = new System.Drawing.Size(120, 21);
            this.comboBox15.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox15.TabIndex = 121;
            this.comboBox15.SelectedIndexChanged += new System.EventHandler(this.comboBox15_SelectedIndexChanged);
            // 
            // gradientPanel8
            // 
            this.gradientPanel8.BackColor = System.Drawing.Color.White;
            this.gradientPanel8.BorderColor = System.Drawing.Color.DarkGray;
            this.gradientPanel8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel8.Controls.Add(this.label17);
            this.gradientPanel8.Controls.Add(this.label19);
            this.gradientPanel8.Controls.Add(this.comboBox7);
            this.gradientPanel8.Controls.Add(this.buttonEdit4);
            this.gradientPanel8.Controls.Add(this.buttonEdit3);
            this.gradientPanel8.Controls.Add(this.label18);
            this.gradientPanel8.Location = new System.Drawing.Point(0, 302);
            this.gradientPanel8.Name = "gradientPanel8";
            this.gradientPanel8.Size = new System.Drawing.Size(256, 0);
            this.gradientPanel8.TabIndex = 160;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(14, 145);
            this.label17.Margin = new System.Windows.Forms.Padding(0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 26);
            this.label17.TabIndex = 109;
            this.label17.Text = "Gradient \r\nEnd Color";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(17, 26);
            this.label19.Margin = new System.Windows.Forms.Padding(0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 26);
            this.label19.TabIndex = 104;
            this.label19.Text = "BackGround \r\nStyle";
            // 
            // comboBox7
            // 
            this.comboBox7.BackColor = System.Drawing.Color.White;
            this.comboBox7.BeforeTouchSize = new System.Drawing.Size(99, 21);
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox7.ForeColor = System.Drawing.Color.Black;
            this.comboBox7.Items.AddRange(new object[] {
            "Default",
            "HorizontalGradient",
            "VerticalGradient"});
            this.comboBox7.Location = new System.Drawing.Point(128, 29);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(99, 21);
            this.comboBox7.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox7.TabIndex = 105;
            this.comboBox7.Text = "Default";
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // buttonEdit4
            // 
            this.buttonEdit4.BeforeTouchSize = new System.Drawing.Size(99, 23);
            this.buttonEdit4.Buttons.Add(this.buttonEditChildButton4);
            this.buttonEdit4.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonEdit4.Controls.Add(this.buttonEditChildButton4);
            this.buttonEdit4.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit4.Location = new System.Drawing.Point(129, 80);
            this.buttonEdit4.MetroColor = System.Drawing.Color.Gainsboro;
            this.buttonEdit4.Name = "buttonEdit4";
            this.buttonEdit4.ShowTextBox = false;
            this.buttonEdit4.Size = new System.Drawing.Size(99, 23);
            this.buttonEdit4.TabIndex = 106;
            this.buttonEdit4.UseVisualStyle = true;
            this.buttonEdit4.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit4_ButtonClicked);
            // 
            // buttonEditChildButton4
            // 
            this.buttonEditChildButton4.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonEditChildButton4.BeforeTouchSize = new System.Drawing.Size(18, 19);
            this.buttonEditChildButton4.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.buttonEditChildButton4.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton4.ForeColor = System.Drawing.Color.White;
            this.buttonEditChildButton4.Image = null;
            this.buttonEditChildButton4.IsBackStageButton = false;
            this.buttonEditChildButton4.Name = "buttonEditChildButton4";
            this.buttonEditChildButton4.PreferredWidth = 18;
            this.buttonEditChildButton4.TabIndex = 1;
            this.buttonEditChildButton4.Text = "...";
            // 
            // buttonEdit3
            // 
            this.buttonEdit3.BeforeTouchSize = new System.Drawing.Size(99, 23);
            this.buttonEdit3.Buttons.Add(this.buttonEditChildButton3);
            this.buttonEdit3.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonEdit3.Controls.Add(this.buttonEditChildButton3);
            this.buttonEdit3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit3.Location = new System.Drawing.Point(129, 145);
            this.buttonEdit3.MetroColor = System.Drawing.Color.Gainsboro;
            this.buttonEdit3.Name = "buttonEdit3";
            this.buttonEdit3.ShowTextBox = false;
            this.buttonEdit3.Size = new System.Drawing.Size(99, 23);
            this.buttonEdit3.TabIndex = 107;
            this.buttonEdit3.UseVisualStyle = true;
            this.buttonEdit3.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit3_ButtonClicked);
            // 
            // buttonEditChildButton3
            // 
            this.buttonEditChildButton3.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonEditChildButton3.BeforeTouchSize = new System.Drawing.Size(18, 19);
            this.buttonEditChildButton3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.buttonEditChildButton3.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton3.ForeColor = System.Drawing.Color.White;
            this.buttonEditChildButton3.Image = null;
            this.buttonEditChildButton3.IsBackStageButton = false;
            this.buttonEditChildButton3.Name = "buttonEditChildButton3";
            this.buttonEditChildButton3.PreferredWidth = 18;
            this.buttonEditChildButton3.TabIndex = 1;
            this.buttonEditChildButton3.Text = "...";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(17, 79);
            this.label18.Margin = new System.Windows.Forms.Padding(0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 26);
            this.label18.TabIndex = 108;
            this.label18.Text = "Gradient \r\nStart Color";
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.BackColor = System.Drawing.Color.White;
            this.gradientPanel3.BorderColor = System.Drawing.Color.DarkGray;
            this.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel3.Controls.Add(this.checkBox1);
            this.gradientPanel3.Controls.Add(this.checkBox2);
            this.gradientPanel3.Controls.Add(this.checkBox9);
            this.gradientPanel3.Controls.Add(this.checkBox8);
            this.gradientPanel3.Location = new System.Drawing.Point(0, 324);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(256, 0);
            this.gradientPanel3.TabIndex = 155;
            // 
            // checkBox1
            // 
            this.checkBox1.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox1.DrawFocusRectangle = false;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(40, 58);
            this.checkBox1.MetroColor = System.Drawing.Color.Silver;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(178, 24);
            this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox1.TabIndex = 124;
            this.checkBox1.Text = "ImageCheckBox";
            this.checkBox1.ThemesEnabled = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox2.DrawFocusRectangle = false;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.Black;
            this.checkBox2.Location = new System.Drawing.Point(40, 92);
            this.checkBox2.MetroColor = System.Drawing.Color.Silver;
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(168, 24);
            this.checkBox2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox2.TabIndex = 153;
            this.checkBox2.Text = "Checked State";
            this.checkBox2.ThemesEnabled = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox9
            // 
            this.checkBox9.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox9.DrawFocusRectangle = false;
            this.checkBox9.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox9.ForeColor = System.Drawing.Color.Black;
            this.checkBox9.Location = new System.Drawing.Point(40, 24);
            this.checkBox9.MetroColor = System.Drawing.Color.Silver;
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(161, 24);
            this.checkBox9.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox9.TabIndex = 133;
            this.checkBox9.Text = "ShowShadow";
            this.checkBox9.ThemesEnabled = false;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox8.Checked = true;
            this.checkBox8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox8.DrawFocusRectangle = false;
            this.checkBox8.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.ForeColor = System.Drawing.Color.Black;
            this.checkBox8.Location = new System.Drawing.Point(40, 126);
            this.checkBox8.MetroColor = System.Drawing.Color.Silver;
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(178, 24);
            this.checkBox8.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox8.TabIndex = 148;
            this.checkBox8.Text = "Themes Enabled";
            this.checkBox8.ThemesEnabled = false;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.comboBoxAdv1);
            this.panel2.Controls.Add(this.label50);
            this.panel2.Controls.Add(this.label49);
            this.panel2.Controls.Add(this.comboBoxAdv2);
            this.panel2.Location = new System.Drawing.Point(0, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 0);
            this.panel2.TabIndex = 161;
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(99, 21);
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxAdv1.Location = new System.Drawing.Point(133, 85);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(99, 21);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.TabIndex = 142;
            this.comboBoxAdv1.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv1_SelectedIndexChanged);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label50.Location = new System.Drawing.Point(24, 88);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(67, 13);
            this.label50.TabIndex = 143;
            this.label50.Text = "Glyph Align";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label49.Location = new System.Drawing.Point(24, 138);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(56, 13);
            this.label49.TabIndex = 144;
            this.label49.Text = "Text Align";
            // 
            // comboBoxAdv2
            // 
            this.comboBoxAdv2.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv2.BeforeTouchSize = new System.Drawing.Size(99, 21);
            this.comboBoxAdv2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxAdv2.Location = new System.Drawing.Point(133, 129);
            this.comboBoxAdv2.Name = "comboBoxAdv2";
            this.comboBoxAdv2.Size = new System.Drawing.Size(99, 21);
            this.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv2.TabIndex = 145;
            this.comboBoxAdv2.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv2_SelectedIndexChanged);
            // 
            // gradientPanel4
            // 
            this.gradientPanel4.BackColor = System.Drawing.Color.White;
            this.gradientPanel4.BorderColor = System.Drawing.Color.DarkGray;
            this.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel4.Controls.Add(this.label42);
            this.gradientPanel4.Controls.Add(this.comboBox3);
            this.gradientPanel4.Location = new System.Drawing.Point(0, 22);
            this.gradientPanel4.Name = "gradientPanel4";
            this.gradientPanel4.Size = new System.Drawing.Size(256, 0);
            this.gradientPanel4.TabIndex = 156;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.Black;
            this.label42.Location = new System.Drawing.Point(24, 62);
            this.label42.Margin = new System.Windows.Forms.Padding(0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(32, 13);
            this.label42.TabIndex = 125;
            this.label42.Text = "Style";          
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.White;
            this.comboBox3.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.ForeColor = System.Drawing.Color.Black;
            this.comboBox3.Items.AddRange(new object[] {
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
            this.comboBox3.Location = new System.Drawing.Point(81, 59);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(150, 21);
            this.comboBox3.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox3.TabIndex = 126;
            this.comboBox3.Text = "Default";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // groupBarItem5
            // 
            this.groupBarItem5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBarItem5.Client = this.gradientPanel4;
            this.groupBarItem5.Text = "Visual Style";
            // 
            // groupBarItem6
            // 
            this.groupBarItem6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBarItem6.Client = this.gradientPanel6;
            this.groupBarItem6.Text = "Border Settings";
            // 
            // groupBarItem7
            // 
            this.groupBarItem7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBarItem7.Client = this.gradientPanel8;
            this.groupBarItem7.Text = "Background Settings";
            // 
            // groupBarItem8
            // 
            this.groupBarItem8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBarItem8.Client = this.gradientPanel3;
            this.groupBarItem8.Text = "Properties";
            // 
            // groupBarItem1
            // 
            this.groupBarItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBarItem1.Client = this.panel2;
            this.groupBarItem1.Text = "Alignment";
            // 
            // comboBox16
            // 
            this.comboBox16.BeforeTouchSize = new System.Drawing.Size(99, 21);
            this.comboBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox16.Location = new System.Drawing.Point(0, 0);
            this.comboBox16.Name = "comboBox16";
            this.comboBox16.Size = new System.Drawing.Size(121, 21);
            this.comboBox16.TabIndex = 0;
            // 
            // label47
            // 
            this.label47.Location = new System.Drawing.Point(0, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(100, 23);
            this.label47.TabIndex = 0;
            // 
            // label48
            // 
            this.label48.Location = new System.Drawing.Point(0, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(100, 23);
            this.label48.TabIndex = 0;
            // 
            // comboBox17
            // 
            this.comboBox17.BeforeTouchSize = new System.Drawing.Size(99, 21);
            this.comboBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox17.Location = new System.Drawing.Point(0, 0);
            this.comboBox17.Name = "comboBox17";
            this.comboBox17.Size = new System.Drawing.Size(121, 21);
            this.comboBox17.TabIndex = 0;
            // 
            // gradientPanel7
            // 
            this.gradientPanel7.BorderColor = System.Drawing.Color.DarkGray;
            this.gradientPanel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel7.Controls.Add(this.label54);
            this.gradientPanel7.Controls.Add(this.buttonAdv1);
            this.gradientPanel7.Controls.Add(this.label60);
            this.gradientPanel7.Location = new System.Drawing.Point(155, 184);
            this.gradientPanel7.Name = "gradientPanel7";
            this.gradientPanel7.Size = new System.Drawing.Size(190, 141);
            this.gradientPanel7.TabIndex = 159;
            // 
            // label54
            // 
            this.label54.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label54.Location = new System.Drawing.Point(3, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(99, 24);
            this.label54.TabIndex = 147;
            this.label54.Text = "Data Binding";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(88, 23);
            this.buttonAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.Location = new System.Drawing.Point(63, 83);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(88, 23);
            this.buttonAdv1.TabIndex = 123;
            this.buttonAdv1.Text = "Checked";
            this.buttonAdv1.UseVisualStyle = true;
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // label60
            // 
            this.label60.Location = new System.Drawing.Point(20, 39);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(169, 27);
            this.label60.TabIndex = 152;
            this.label60.Text = "Set the RadioButton as checked through DataBase";
            this.label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BackColor = System.Drawing.Color.White;
            this.gradientPanel2.BorderColor = System.Drawing.Color.Silver;
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel2.Controls.Add(this.radioButtonAdv12);
            this.gradientPanel2.Controls.Add(this.gradientPanel7);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(455, 346);
            this.gradientPanel2.TabIndex = 150;
            // 
            // radioButtonAdv12
            // 
            this.radioButtonAdv12.BeforeTouchSize = new System.Drawing.Size(190, 72);
            this.radioButtonAdv12.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.radioButtonAdv12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.radioButtonAdv12.CheckedImage = ((System.Drawing.Image)(resources.GetObject("radioButtonAdv12.CheckedImage")));
            this.radioButtonAdv12.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.radioButtonAdv12.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.radioButtonAdv12.Location = new System.Drawing.Point(155, 65);
            this.radioButtonAdv12.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.radioButtonAdv12.Name = "radioButtonAdv12";
            this.radioButtonAdv12.Size = new System.Drawing.Size(190, 72);
            this.radioButtonAdv12.TabIndex = 110;
            this.radioButtonAdv12.Text = "RadioButtonAdv";
            this.radioButtonAdv12.ThemesEnabled = true;
            this.radioButtonAdv12.UncheckedImage = ((System.Drawing.Image)(resources.GetObject("radioButtonAdv12.UncheckedImage")));
            // 
            // label57
            // 
            this.label57.BackColor = System.Drawing.Color.Transparent;
            this.label57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label57.Dock = System.Windows.Forms.DockStyle.Top;
            this.label57.ForeColor = System.Drawing.Color.Black;
            this.label57.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label57.Location = new System.Drawing.Point(20, 20);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(728, 60);
            this.label57.TabIndex = 1;
            this.label57.Text = "RadioButtonAdv is an advanced RadioButton control that supports themes, gradient " +
    "colors and shadow text. \r\nIt has provisions to set images when checked and unche" +
    "cked. ";
            this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxExt2
            // 
            this.textBoxExt2.BackColor = System.Drawing.Color.White;
            this.textBoxExt2.BeforeTouchSize = new System.Drawing.Size(42, 20);
            this.textBoxExt2.Location = new System.Drawing.Point(2, 3);
            this.textBoxExt2.Metrocolor = System.Drawing.Color.Empty;
            this.textBoxExt2.Name = "textBoxExt2";
            this.textBoxExt2.OverflowIndicatorToolTipText = null;
            this.textBoxExt2.Size = new System.Drawing.Size(49, 20);
            this.textBoxExt2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBoxExt2.TabIndex = 0;
            // 
            // textBoxExt1
            // 
            this.textBoxExt1.BackColor = System.Drawing.Color.White;
            this.textBoxExt1.BeforeTouchSize = new System.Drawing.Size(42, 20);
            this.textBoxExt1.Location = new System.Drawing.Point(2, 3);
            this.textBoxExt1.Metrocolor = System.Drawing.Color.Empty;
            this.textBoxExt1.Name = "textBoxExt1";
            this.textBoxExt1.OverflowIndicatorToolTipText = null;
            this.textBoxExt1.Size = new System.Drawing.Size(42, 20);
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
            // buttonEdit6
            // 
            this.buttonEdit6.BackColor = System.Drawing.Color.White;
            this.buttonEdit6.BeforeTouchSize = new System.Drawing.Size(71, 26);
            this.buttonEdit6.Buttons.Add(this.buttonEditChildButton6);
            this.buttonEdit6.Controls.Add(this.buttonEditChildButton6);
            this.buttonEdit6.Controls.Add(this.textBoxExt2);
            this.buttonEdit6.Location = new System.Drawing.Point(156, 209);
            this.buttonEdit6.MetroColor = System.Drawing.Color.Empty;
            this.buttonEdit6.Name = "buttonEdit6";
            this.buttonEdit6.ShowTextBox = false;
            this.buttonEdit6.Size = new System.Drawing.Size(71, 26);
            this.buttonEdit6.TabIndex = 107;
            this.buttonEdit6.TextBox = this.textBoxExt2;
            this.buttonEdit6.UseVisualStyle = true;
            // 
            // buttonEditChildButton6
            // 
            this.buttonEditChildButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonEditChildButton6.BeforeTouchSize = new System.Drawing.Size(18, 22);
            this.buttonEditChildButton6.ComboEditBackColor = System.Drawing.Color.White;
            this.buttonEditChildButton6.Image = null;
            this.buttonEditChildButton6.IsBackStageButton = false;
            this.buttonEditChildButton6.Name = "buttonEditChildButton6";
            this.buttonEditChildButton6.PreferredWidth = 18;
            this.buttonEditChildButton6.TabIndex = 1;
            this.buttonEditChildButton6.Text = "...";
            // 
            // buttonEdit7
            // 
            this.buttonEdit7.BackColor = System.Drawing.Color.White;
            this.buttonEdit7.BeforeTouchSize = new System.Drawing.Size(64, 26);
            this.buttonEdit7.Buttons.Add(this.buttonEditChildButton7);
            this.buttonEdit7.Controls.Add(this.buttonEditChildButton7);
            this.buttonEdit7.Controls.Add(this.textBoxExt1);
            this.buttonEdit7.Location = new System.Drawing.Point(149, 182);
            this.buttonEdit7.MetroColor = System.Drawing.Color.Empty;
            this.buttonEdit7.Name = "buttonEdit7";
            this.buttonEdit7.ShowTextBox = false;
            this.buttonEdit7.Size = new System.Drawing.Size(64, 26);
            this.buttonEdit7.TabIndex = 106;
            this.buttonEdit7.TextBox = this.textBoxExt1;
            this.buttonEdit7.UseVisualStyle = true;
            // 
            // buttonEditChildButton7
            // 
            this.buttonEditChildButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonEditChildButton7.BeforeTouchSize = new System.Drawing.Size(18, 22);
            this.buttonEditChildButton7.ComboEditBackColor = System.Drawing.Color.White;
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
            this.splitContainerAdv1.Panel1.Controls.Add(this.gradientPanel2);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.Controls.Add(this.groupBar2);
            this.splitContainerAdv1.Size = new System.Drawing.Size(722, 348);
            this.splitContainerAdv1.SplitterDistance = 457;
            this.splitContainerAdv1.TabIndex = 163;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 464);
            this.Controls.Add(this.splitContainerAdv1);
            this.Controls.Add(this.label57);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(780, 496);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RadioButtonAdv";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBar2)).EndInit();
            this.groupBar2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel6)).EndInit();
            this.gradientPanel6.ResumeLayout(false);
            this.gradientPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit8)).EndInit();
            this.buttonEdit8.ResumeLayout(false);
            this.buttonEdit8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel8)).EndInit();
            this.gradientPanel8.ResumeLayout(false);
            this.gradientPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit4)).EndInit();
            this.buttonEdit4.ResumeLayout(false);
            this.buttonEdit4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit3)).EndInit();
            this.buttonEdit3.ResumeLayout(false);
            this.buttonEdit3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).EndInit();
            this.gradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox8)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).EndInit();
            this.gradientPanel4.ResumeLayout(false);
            this.gradientPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel7)).EndInit();
            this.gradientPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv12)).EndInit();
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
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
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
        private void Form1_Load(object sender, System.EventArgs e)
        {
            #region RadioButtonAdv DataBinding
            m_dt = new DataTable();
            m_dt.Columns.Add("ID", typeof(int));
            m_dt.Columns.Add("ValueStr", typeof(string));
            m_dt.LoadDataRow(new object[] { 0, "N" }, false);
            m_dt.LoadDataRow(new object[] { 1, "Y" }, true);
            this.radioButtonAdv12.DataBindings.Add("IntValue", m_dt, "ID");
            #endregion


            //Populate Border3DStyles
            string[] str1 = Enum.GetNames(typeof(Border3DStyle));
            comboBox6.Items.AddRange(str1);
            comboBox10.Items.AddRange(str1);

            //Populate BorderSingle
            string[] str2 = Enum.GetNames(typeof(ButtonBorderStyle));
            comboBox14.Items.AddRange(str2);
            comboBox15.Items.AddRange(str2);

            //Populate Content Alignment
            string[] str3 = Enum.GetNames(typeof(System.Drawing.ContentAlignment));
            comboBoxAdv1.Items.AddRange(str3);
            comboBoxAdv2.Items.AddRange(str3);
            comboBox19.Items.AddRange(str3);
            comboBox18.Items.AddRange(str3);
            this.comboBox6.SelectedIndex= 1;
             this.comboBox7.SelectedIndex = 0;
             this.comboBox9.SelectedIndex = 1;
             this.comboBox10.SelectedIndex = 1;
             this.comboBox14.SelectedIndex= 3;
             this.comboBox15.SelectedIndex = 3;
             this.comboBoxAdv1.SelectedIndex = 3;
             this.comboBoxAdv2.SelectedIndex = 3;
             this.comboBox19.SelectedIndex= 3;
             this.comboBox18.SelectedIndex=3;
             this.buttonEdit4.TextBox.BackColor = Color.FromArgb(192, 192, 255);
             this.buttonEdit3.TextBox.BackColor = Color.FromArgb(255, 224, 192);
            this.label57.BorderStyle = BorderStyle.None;
            this.label57.Paint += Label57_Paint;
            this.splitContainerAdv1.BorderStyle = BorderStyle.None;            
            this.comboBox3.SelectedIndex = 8;
        }

        private void Label57_Paint(object sender, PaintEventArgs e)
        {
            if (this.radioButtonAdv12.Style == RadioButtonAdvStyle.Office2016DarkGray)
                ControlPaint.DrawBorder(e.Graphics, this.label57.DisplayRectangle, ColorTranslator.FromHtml("#444444"), ButtonBorderStyle.Solid);
            else if (this.radioButtonAdv12.Style == RadioButtonAdvStyle.Office2016Black)
                ControlPaint.DrawBorder(e.Graphics, this.label57.DisplayRectangle, ColorTranslator.FromHtml("#444444"), ButtonBorderStyle.Solid);
            else if (this.radioButtonAdv12.Style == RadioButtonAdvStyle.Office2016Colorful || this.radioButtonAdv12.Style == RadioButtonAdvStyle.Office2016White)
                ControlPaint.DrawBorder(e.Graphics, this.label57.DisplayRectangle, ColorTranslator.FromHtml("#c6c6c6"), ButtonBorderStyle.Solid);
            else
                ControlPaint.DrawBorder(e.Graphics, this.label57.ClientRectangle, Color.Gray, ButtonBorderStyle.Solid);
        }
        #endregion

        #region RadioButtonAdv properties

        #region ImageCheckBox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.radioButtonAdv12.ImageCheckBox = this.checkBox1.Checked;
        }
        #endregion
       
        #region BackGroundStyle
        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox7.Items[comboBox7.SelectedIndex].ToString())
            {
                case "Default":
                    this.radioButtonAdv12.BackgroundStyle = Syncfusion.Windows.Forms.Tools.CheckBoxAdvBackStyle.Default;
                    break;
                case "HorizontalGradient":
                    this.radioButtonAdv12.BackgroundStyle = Syncfusion.Windows.Forms.Tools.CheckBoxAdvBackStyle.HorizontalGradient;
                    break;
                case "VerticalGradient":
                    this.radioButtonAdv12.BackgroundStyle = Syncfusion.Windows.Forms.Tools.CheckBoxAdvBackStyle.VerticalGradient;
                    break;
            }
        }
        #endregion

        #region Gradient Colors
        private void buttonEdit4_ButtonClicked(object sender, Syncfusion.Windows.Forms.Tools.ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {               
                buttonEditChildButton4.BackColor = colorDialog1.Color;
                this.radioButtonAdv12.GradientStart = colorDialog1.Color;
            }
        }

        private void buttonEdit3_ButtonClicked(object sender, Syncfusion.Windows.Forms.Tools.ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {               
                buttonEditChildButton3.BackColor = colorDialog1.Color;
                this.radioButtonAdv12.GradientEnd = colorDialog1.Color;
            }
        }
        #endregion

        #region BorderStyle

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox9.Items[comboBox9.SelectedIndex].ToString())
            {
                case "None":
                    this.radioButtonAdv12.BorderStyle = BorderStyle.None;
                    this.comboBox10.Enabled = false;
                    this.comboBox15.Enabled = false;
                    this.buttonEdit8.Enabled = false;
                    break;
                case "FixedSingle":
                    this.radioButtonAdv12.BorderStyle = BorderStyle.FixedSingle;
                    this.comboBox10.Enabled = false;
                    this.comboBox15.Enabled = true;
                    this.buttonEdit8.Enabled = true;
                    break;
                case "Fixed3D":
                    this.radioButtonAdv12.BorderStyle = BorderStyle.Fixed3D;
                    this.comboBox10.Enabled = true;
                    this.comboBox15.Enabled = false;
                    this.buttonEdit8.Enabled = false;
                    break;
            }
        }
        #endregion
        
        #region Border3DStyle
        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox10.Items[comboBox10.SelectedIndex].ToString())
            {
                case "RaisedOuter":
                    this.radioButtonAdv12.Border3DStyle = Border3DStyle.RaisedOuter;
                    break;
                case "Adjust":
                    this.radioButtonAdv12.Border3DStyle = Border3DStyle.Adjust;
                    break;
                case "Bump":
                    this.radioButtonAdv12.Border3DStyle = Border3DStyle.Bump;
                    break;
                case "Etched":
                    this.radioButtonAdv12.Border3DStyle = Border3DStyle.Etched;
                    break;
                case "Flat":
                    this.radioButtonAdv12.Border3DStyle = Border3DStyle.Flat;
                    break;
                case "Raised":
                    this.radioButtonAdv12.Border3DStyle = Border3DStyle.Raised;
                    break;
                case "RaisedInner":
                    this.radioButtonAdv12.Border3DStyle = Border3DStyle.RaisedInner;
                    break;
                case "Sunken":
                    this.radioButtonAdv12.Border3DStyle = Border3DStyle.Sunken;
                    break;
                case "SunkenInner":
                    this.radioButtonAdv12.Border3DStyle = Border3DStyle.SunkenInner;
                    break;
                case "SunkenOuter":
                    this.radioButtonAdv12.Border3DStyle = Border3DStyle.SunkenOuter;
                    break;
            }
        }
        #endregion

        #region  BorderColor
        private void buttonEdit8_ButtonClicked(object sender, Syncfusion.Windows.Forms.Tools.ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {               
                buttonEditChildButton8.BackColor = colorDialog1.Color;
                this.radioButtonAdv12.BorderColor = colorDialog1.Color;
            }

        }
        #endregion

        #region BorderSingleStyle

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox15.Items[comboBox15.SelectedIndex].ToString())
            {
                case "Dashed":
                    this.radioButtonAdv12.BorderSingle = ButtonBorderStyle.Dashed;
                    break;
                case "Dotted":
                    this.radioButtonAdv12.BorderSingle = ButtonBorderStyle.Dotted;
                    break;
                case "Inset":
                    this.radioButtonAdv12.BorderSingle = ButtonBorderStyle.Inset;
                    break;
                case "None":
                    this.radioButtonAdv12.BorderSingle = ButtonBorderStyle.None;
                    break;
                case "Outset":
                    this.radioButtonAdv12.BorderSingle = ButtonBorderStyle.Outset;
                    break;
                case "Solid":
                    this.radioButtonAdv12.BorderSingle = ButtonBorderStyle.Solid;
                    break;
            }
        }
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

        #region VisualStyle
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateStyle(Color.White, Color.Black);
            this.gradientPanel2.BorderStyle = BorderStyle.FixedSingle;
            this.groupBar2.BorderStyle = BorderStyle.FixedSingle;
            this.groupBar2.BorderColor = Color.Gray;
            this.gradientPanel2.BorderColor = Color.Gray;
            this.gradientPanel7.BorderColor = Color.Gray;

            this.CaptionBarColor = Color.White;
            this.BackColor = Color.White;
            this.CaptionForeColor = Color.Black;
            this.CaptionButtonColor = Color.Black;
            this.CaptionButtonHoverColor = Color.Black;

            if (this.comboBox3.SelectedIndex == 0)
            {
                this.checkBox8.Checked = true;
                this.radioButtonAdv12.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Default;

            }
            else if (this.comboBox3.SelectedIndex == 1)
            {
                this.checkBox8.Checked = false;
                this.radioButtonAdv12.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2007;
                this.radioButtonAdv12.Office2007ColorScheme = Office2007Theme.Blue;
            }
            else if (this.comboBox3.SelectedIndex == 2)
            {
                this.checkBox8.Checked = false;
                this.radioButtonAdv12.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2007;
                this.radioButtonAdv12.Office2007ColorScheme = Office2007Theme.Silver;
            }
            else if (this.comboBox3.SelectedIndex == 3)
            {
                this.checkBox8.Checked = false;
                this.radioButtonAdv12.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2007;
                this.radioButtonAdv12.Office2007ColorScheme = Office2007Theme.Black;
            }
            else if (this.comboBox3.SelectedIndex == 4)
            {
                this.checkBox8.Checked = false;
                this.radioButtonAdv12.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2010;
                this.radioButtonAdv12.Office2010ColorScheme = Office2010Theme.Blue;
            }
            else if (this.comboBox3.SelectedIndex == 5)
            {
                this.checkBox8.Checked = false;
                this.radioButtonAdv12.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2010;
                this.radioButtonAdv12.Office2010ColorScheme = Office2010Theme.Silver;
            }
            else if (this.comboBox3.SelectedIndex == 6)
            {
                this.checkBox8.Checked = false;
                this.radioButtonAdv12.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2010;
                this.radioButtonAdv12.Office2010ColorScheme = Office2010Theme.Black;
            }
            else if (this.comboBox3.SelectedIndex == 7)
            {
                this.checkBox8.Checked = false;
                this.radioButtonAdv12.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            }
            else if (this.comboBox3.SelectedIndex == 8)
            {
                this.checkBox8.Checked = false;
                
                this.groupBar2.BorderColor = ColorTranslator.FromHtml("#c6c6c6");
                this.gradientPanel2.BorderColor = ColorTranslator.FromHtml("#c6c6c6");
                this.gradientPanel7.BorderColor = ColorTranslator.FromHtml("#c6c6c6");
                this.CaptionForeColor = Color.White;
                this.CaptionBarColor = ColorTranslator.FromHtml("#0173c7");
                this.CaptionButtonColor = Color.White;
                this.CaptionButtonHoverColor = Color.White;
                this.groupBar2.VisualStyle = VisualStyle.Office2016Colorful;
                this.buttonAdv1.Appearance = ButtonAppearance.Office2016Colorful;
                this.radioButtonAdv12.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
                this.MetroColor = ColorTranslator.FromHtml("#0173c7");
                foreach (Control ctrl in Collect(this.Controls))
                {
                    if (ctrl is ComboBoxAdv)
                    {
                        (ctrl as ComboBoxAdv).Style = VisualStyle.Office2016Colorful;
                    }
                }
                
            }
            else if (this.comboBox3.SelectedIndex == 11)
            {
                this.checkBox8.Checked = false;
                this.radioButtonAdv12.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016White;
                this.groupBar2.BorderColor = ColorTranslator.FromHtml("#c6c6c6");
                this.gradientPanel2.BorderColor = ColorTranslator.FromHtml("#c6c6c6");
                this.gradientPanel7.BorderColor = ColorTranslator.FromHtml("#c6c6c6");
                this.groupBar2.VisualStyle = VisualStyle.Office2016White;
                this.buttonAdv1.Appearance = ButtonAppearance.Office2016White;
                this.MetroColor = Color.White;
                foreach (Control ctrl in Collect(this.Controls))
                {
                    if (ctrl is ComboBoxAdv)
                    {
                        (ctrl as ComboBoxAdv).Style = VisualStyle.Office2016White;
                    }
                }
            }
            else if (this.comboBox3.SelectedIndex == 10)
            {
                this.checkBox8.Checked = false;
                this.radioButtonAdv12.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Black;
                this.UpdateStyle(ColorTranslator.FromHtml("#262626"), Color.White);
                foreach (Control ctrl in Collect(this.Controls))
                {
                    if (ctrl is ComboBoxAdv)
                    {
                        ctrl.ForeColor = ColorTranslator.FromHtml("#969696");
                        (ctrl as ComboBoxAdv).Style = VisualStyle.Office2016Black;
                    }
                    else if (ctrl is RadioButtonAdv)
                    {
                        (ctrl as RadioButtonAdv).Style = RadioButtonAdvStyle.Office2016Black;
                    }
                    else if (ctrl is GroupBar)
                    {
                        (ctrl as GroupBar).VisualStyle = VisualStyle.Office2016Black;
                    }
                    else if (ctrl is ButtonAdv)
                    {
                        (ctrl as ButtonAdv).Appearance = ButtonAppearance.Office2016Black;
                    }

                }
                this.groupBar2.BorderColor = ColorTranslator.FromHtml("#444444");
                this.gradientPanel2.BorderColor = ColorTranslator.FromHtml("#444444");
                this.gradientPanel7.BorderColor = ColorTranslator.FromHtml("#444444");
                this.gradientPanel2.BorderStyle = BorderStyle.FixedSingle;
                this.CaptionForeColor = Color.White;
                this.splitContainerAdv1.BorderStyle = BorderStyle.None;
                this.CaptionForeColor = Color.White;
                this.CaptionButtonColor = Color.White;
                this.CaptionButtonHoverColor = Color.White;
                this.MetroColor = ColorTranslator.FromHtml("#363636");
                this.CaptionBarColor = ColorTranslator.FromHtml("#363636");
            }
            else if (this.comboBox3.SelectedIndex == 9)
            {
                this.checkBox8.Checked = false;
                this.radioButtonAdv12.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016DarkGray;
                this.UpdateStyle(ColorTranslator.FromHtml("#666666"), ColorTranslator.FromHtml("#f0f0f0"));
                foreach (Control ctrl in Collect(this.Controls))
                {
                    if (ctrl is ComboBoxAdv)
                    {
                        (ctrl as ComboBoxAdv).Style = VisualStyle.Office2016DarkGray;
                    }
                    else if (ctrl is GroupBar)
                    {
                        (ctrl as GroupBar).VisualStyle = VisualStyle.Office2016DarkGray;
                    }
                    else if (ctrl is ButtonAdv)
                    {
                        (ctrl as ButtonAdv).Appearance = ButtonAppearance.Office2016DarkGray;
                    }
                }

                this.buttonAdv1.ForeColor = Color.Black;
                this.groupBar2.BorderColor = Color.DarkGray;
                this.gradientPanel2.BorderColor = ColorTranslator.FromHtml("#444444");
                this.gradientPanel7.BorderColor = ColorTranslator.FromHtml("#444444");
                this.gradientPanel2.BorderStyle = BorderStyle.FixedSingle;
                this.MetroColor = ColorTranslator.FromHtml("#505050");
                this.CaptionBarColor = ColorTranslator.FromHtml("#505050");
                this.CaptionForeColor = Color.White;
                this.CaptionButtonColor = Color.White;
                this.CaptionButtonHoverColor = Color.White;
                this.groupBar2.BorderColor = ColorTranslator.FromHtml("#444444");
            }
        }

        private void UpdateStyle(Color backColor, Color ForeColor)
        {
            this.CaptionForeColor = Color.Black;
            this.CaptionBarColor = backColor;
            this.BackColor = backColor;
            this.MetroColor = Color.White;
            this.gradientPanel2.BorderStyle = BorderStyle.None;

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
                    ctrl.ForeColor = Color.Black;
                }
                else if (ctrl is GroupBar)
                {
                    (ctrl as GroupBar).VisualStyle = VisualStyle.Metro;
                }
                else if (ctrl is ButtonAdv)
                {
                    ctrl.ForeColor = Color.White;
                    (ctrl as ButtonAdv).Appearance = ButtonAppearance.Metro;
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

        #region TextShadow
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            this.radioButtonAdv12.TextShadow = this.checkBox9.Checked;
        }
        #endregion
        
        #region Glyph Align
        private void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxAdv1.SelectedIndex)
            {
                case 0:
                    this.radioButtonAdv12.CheckAlign = ContentAlignment.TopLeft;
                    break;
                case 1:
                    this.radioButtonAdv12.CheckAlign = ContentAlignment.TopCenter;
                    break;
                case 2:
                    this.radioButtonAdv12.CheckAlign = ContentAlignment.TopRight;
                    break;
                case 3:
                    this.radioButtonAdv12.CheckAlign = ContentAlignment.MiddleLeft;
                    break;
                case 4:
                    this.radioButtonAdv12.CheckAlign = ContentAlignment.MiddleCenter;
                    break;
                case 5:
                    this.radioButtonAdv12.CheckAlign = ContentAlignment.MiddleRight;
                    break;
                case 6:
                    this.radioButtonAdv12.CheckAlign = ContentAlignment.BottomLeft;
                    break;
                case 7:
                    this.radioButtonAdv12.CheckAlign = ContentAlignment.BottomCenter;
                    break;
                case 8:
                    this.radioButtonAdv12.CheckAlign = ContentAlignment.BottomRight;
                    break;


            }

        }
        #endregion

        #region TextAlign
        private void comboBoxAdv2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxAdv2.SelectedIndex)
            {
                case 0:
                    this.radioButtonAdv12.TextContentAlignment = ContentAlignment.TopLeft;
                    break;
                case 1:
                    this.radioButtonAdv12.TextContentAlignment = ContentAlignment.TopCenter;
                    break;
                case 2:
                    this.radioButtonAdv12.TextContentAlignment = ContentAlignment.TopRight;
                    break;
                case 3:
                    this.radioButtonAdv12.TextContentAlignment = ContentAlignment.MiddleLeft;
                    break;
                case 4:
                    this.radioButtonAdv12.TextContentAlignment = ContentAlignment.MiddleCenter;
                    break;
                case 5:
                    this.radioButtonAdv12.TextContentAlignment = ContentAlignment.MiddleRight;
                    break;
                case 6:
                    this.radioButtonAdv12.TextContentAlignment = ContentAlignment.BottomLeft;
                    break;
                case 7:
                    this.radioButtonAdv12.TextContentAlignment = ContentAlignment.BottomCenter;
                    break;
                case 8:
                    this.radioButtonAdv12.TextContentAlignment = ContentAlignment.BottomRight;
                    break;


            }

        }
        #endregion
        
        #region ThemesEnabled
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            this.radioButtonAdv12.ThemesEnabled = checkBox8.Checked;
        }
        #endregion

        #region RadioButton State
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.radioButtonAdv12.Checked = this.checkBox2.Checked;
        }
        #endregion

        private void tabPageAdv2_Click(object sender, EventArgs e)
        {

        }

         #endregion

        private void groupBar2_GroupBarItemSelected(object sender, EventArgs e)
        {

        }

    }
}