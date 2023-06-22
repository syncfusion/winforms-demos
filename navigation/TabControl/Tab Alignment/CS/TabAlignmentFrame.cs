#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Licensing;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabAlignment_2005
{
    public partial class TabAlignmentFrame : SfForm
    {

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv2;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv3;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv4;
        private Syncfusion.Windows.Forms.Tools.GridLayout gridLayout2;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
        private Syncfusion.Windows.Forms.Tools.GridLayout gridLayout1;
        private System.Windows.Forms.Panel panel3;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv4;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv7;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv8;
        private Syncfusion.Windows.Forms.Tools.GridLayout gridLayout3;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv3;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv5;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;

        public TabAlignmentFrame()
        {
            InitializeComponent();
           
            this.tabControlAdv1.ThemeName = "Office2019Colorful";
            this.tabControlAdv2.ThemeName = "Office2019Colorful";
            this.tabControlAdv3.ThemeName = "Office2019Colorful";
            this.tabControlAdv4.ThemeName = "Office2019Colorful";
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            SkinManager.LoadAssembly(typeof(Office2019Theme).Assembly);
            Application.Run(new TabAlignmentFrame());
        }

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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabAlignmentFrame));
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControlAdv2 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageAdv4 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControlAdv4 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv7 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageAdv8 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControlAdv3 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv5 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageAdv6 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.label8 = new System.Windows.Forms.Label();
            this.gridLayout1 = new Syncfusion.Windows.Forms.Tools.GridLayout(this.components);
            this.gridLayout2 = new Syncfusion.Windows.Forms.Tools.GridLayout(this.components);
            this.gridLayout3 = new Syncfusion.Windows.Forms.Tools.GridLayout(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv2)).BeginInit();
            this.tabControlAdv2.SuspendLayout();
            this.tabPageAdv3.SuspendLayout();
            this.tabPageAdv4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            this.tabPageAdv2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv4)).BeginInit();
            this.tabControlAdv4.SuspendLayout();
            this.tabPageAdv7.SuspendLayout();
            this.tabPageAdv8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv3)).BeginInit();
            this.tabControlAdv3.SuspendLayout();
            this.tabPageAdv5.SuspendLayout();
            this.tabPageAdv6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1218, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 690);
            this.panel1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(2, 75);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(227, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Rotate Text When Vertical";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1216, 690);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tabControlAdv2);
            this.panel4.Controls.Add(this.tabControlAdv1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.gridLayout1.SetParticipateInLayout(this.panel4, true);
            this.panel4.Size = new System.Drawing.Size(608, 690);
            this.panel4.TabIndex = 1;
            // 
            // tabControlAdv2
            // 
            this.tabControlAdv2.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tabControlAdv2.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv2.BeforeTouchSize = new System.Drawing.Size(533, 270);
            this.tabControlAdv2.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv2.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv2.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv2.Controls.Add(this.tabPageAdv3);
            this.tabControlAdv2.Controls.Add(this.tabPageAdv4);
            this.tabControlAdv2.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv2.Location = new System.Drawing.Point(50, 50);
            this.tabControlAdv2.Name = "tabControlAdv2";
            this.gridLayout2.SetParticipateInLayout(this.tabControlAdv2, true);
            this.tabControlAdv2.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.tabControlAdv2.ShowSeparator = false;
            this.tabControlAdv2.Size = new System.Drawing.Size(533, 270);
            this.tabControlAdv2.TabIndex = 1;
            this.tabControlAdv2.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Colorful);
            this.tabControlAdv2.ThemeName = "TabRenderer3D";
            // 
            // tabPageAdv3
            // 
            this.tabPageAdv3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv3.Controls.Add(this.label1);
            this.tabPageAdv3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv3.Image = null;
            this.tabPageAdv3.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv3.Location = new System.Drawing.Point(1, 25);
            this.tabPageAdv3.Name = "tabPageAdv3";
            this.tabPageAdv3.ShowCloseButton = true;
            this.tabPageAdv3.Size = new System.Drawing.Size(530, 243);
            this.tabPageAdv3.TabIndex = 1;
            this.tabPageAdv3.Text = "Tab1";
            this.tabPageAdv3.ThemesEnabled = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tab Alignment : Top";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageAdv4
            // 
            this.tabPageAdv4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv4.Controls.Add(this.label5);
            this.tabPageAdv4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv4.Image = null;
            this.tabPageAdv4.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv4.Location = new System.Drawing.Point(1, 25);
            this.tabPageAdv4.Name = "tabPageAdv4";
            this.tabPageAdv4.ShowCloseButton = true;
            this.tabPageAdv4.Size = new System.Drawing.Size(530, 243);
            this.tabPageAdv4.TabIndex = 2;
            this.tabPageAdv4.Text = "Tab2";
            this.tabPageAdv4.ThemesEnabled = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tab Alignment : Top";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tabControlAdv1.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(533, 270);
            this.tabControlAdv1.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.Location = new System.Drawing.Point(50, 370);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.gridLayout2.SetParticipateInLayout(this.tabControlAdv1, true);
            this.tabControlAdv1.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.tabControlAdv1.ShowSeparator = false;
            this.tabControlAdv1.Size = new System.Drawing.Size(533, 270);
            this.tabControlAdv1.TabIndex = 0;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Colorful);
            this.tabControlAdv1.ThemeName = "TabRenderer3D";
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv1.Controls.Add(this.label2);
            this.tabPageAdv1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv1.Location = new System.Drawing.Point(1, 2);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(530, 243);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "Tab1";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tab Alignment : Bottom";
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv2.Controls.Add(this.label6);
            this.tabPageAdv2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv2.Location = new System.Drawing.Point(1, 2);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(530, 243);
            this.tabPageAdv2.TabIndex = 2;
            this.tabPageAdv2.Text = "Tab2";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tab Alignment : Bottom";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControlAdv4);
            this.panel3.Controls.Add(this.tabControlAdv3);
            this.panel3.Location = new System.Drawing.Point(608, 0);
            this.panel3.Name = "panel3";
            this.gridLayout1.SetParticipateInLayout(this.panel3, true);
            this.panel3.Size = new System.Drawing.Size(608, 690);
            this.panel3.TabIndex = 0;
            // 
            // tabControlAdv4
            // 
            this.tabControlAdv4.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tabControlAdv4.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv4.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlAdv4.BeforeTouchSize = new System.Drawing.Size(241, 590);
            this.tabControlAdv4.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv4.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv4.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv4.Controls.Add(this.tabPageAdv7);
            this.tabControlAdv4.Controls.Add(this.tabPageAdv8);
            this.tabControlAdv4.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv4.Location = new System.Drawing.Point(26, 50);
            this.tabControlAdv4.Name = "tabControlAdv4";
            this.gridLayout3.SetParticipateInLayout(this.tabControlAdv4, true);
            this.tabControlAdv4.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.tabControlAdv4.ShowSeparator = false;
            this.tabControlAdv4.Size = new System.Drawing.Size(241, 590);
            this.tabControlAdv4.TabIndex = 2;
            this.tabControlAdv4.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Colorful);
            this.tabControlAdv4.ThemeName = "TabRenderer3D";
            // 
            // tabPageAdv7
            // 
            this.tabPageAdv7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv7.Controls.Add(this.label3);
            this.tabPageAdv7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv7.Image = null;
            this.tabPageAdv7.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv7.Location = new System.Drawing.Point(27, 1);
            this.tabPageAdv7.Name = "tabPageAdv7";
            this.tabPageAdv7.ShowCloseButton = true;
            this.tabPageAdv7.Size = new System.Drawing.Size(213, 587);
            this.tabPageAdv7.TabIndex = 1;
            this.tabPageAdv7.Text = "Tab1";
            this.tabPageAdv7.ThemesEnabled = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tab Alignment : Left";
            // 
            // tabPageAdv8
            // 
            this.tabPageAdv8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv8.Controls.Add(this.label7);
            this.tabPageAdv8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv8.Image = null;
            this.tabPageAdv8.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv8.Location = new System.Drawing.Point(27, 1);
            this.tabPageAdv8.Name = "tabPageAdv8";
            this.tabPageAdv8.ShowCloseButton = true;
            this.tabPageAdv8.Size = new System.Drawing.Size(213, 587);
            this.tabPageAdv8.TabIndex = 2;
            this.tabPageAdv8.Text = "Tab2";
            this.tabPageAdv8.ThemesEnabled = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tab Alignment : Left";
            // 
            // tabControlAdv3
            // 
            this.tabControlAdv3.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tabControlAdv3.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv3.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControlAdv3.BeforeTouchSize = new System.Drawing.Size(241, 590);
            this.tabControlAdv3.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv3.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv3.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv3.Controls.Add(this.tabPageAdv5);
            this.tabControlAdv3.Controls.Add(this.tabPageAdv6);
            this.tabControlAdv3.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv3.Location = new System.Drawing.Point(317, 50);
            this.tabControlAdv3.Name = "tabControlAdv3";
            this.gridLayout3.SetParticipateInLayout(this.tabControlAdv3, true);
            this.tabControlAdv3.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.tabControlAdv3.ShowSeparator = false;
            this.tabControlAdv3.Size = new System.Drawing.Size(241, 590);
            this.tabControlAdv3.TabIndex = 1;
            this.tabControlAdv3.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Colorful);
            this.tabControlAdv3.ThemeName = "TabRenderer3D";
            // 
            // tabPageAdv5
            // 
            this.tabPageAdv5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv5.Controls.Add(this.label4);
            this.tabPageAdv5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv5.Image = null;
            this.tabPageAdv5.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv5.Location = new System.Drawing.Point(2, 1);
            this.tabPageAdv5.Name = "tabPageAdv5";
            this.tabPageAdv5.ShowCloseButton = true;
            this.tabPageAdv5.Size = new System.Drawing.Size(213, 587);
            this.tabPageAdv5.TabIndex = 1;
            this.tabPageAdv5.Text = "Tab1";
            this.tabPageAdv5.ThemesEnabled = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tab Alignment : Right";
            // 
            // tabPageAdv6
            // 
            this.tabPageAdv6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv6.Controls.Add(this.label8);
            this.tabPageAdv6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv6.Image = null;
            this.tabPageAdv6.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv6.Location = new System.Drawing.Point(2, 1);
            this.tabPageAdv6.Name = "tabPageAdv6";
            this.tabPageAdv6.ShowCloseButton = true;
            this.tabPageAdv6.Size = new System.Drawing.Size(213, 587);
            this.tabPageAdv6.TabIndex = 2;
            this.tabPageAdv6.Text = "Tab2";
            this.tabPageAdv6.ThemesEnabled = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tab Alignment : Right";
            // 
            // gridLayout1
            // 
            this.gridLayout1.Columns = 2;
            this.gridLayout1.ContainerControl = this.panel2;
            this.gridLayout1.Rows = 1;
            // 
            // gridLayout2
            // 
            this.gridLayout2.BottomMargin = 50;
            this.gridLayout2.Columns = 1;
            this.gridLayout2.ContainerControl = this.panel4;
            this.gridLayout2.HGap = 50;
            this.gridLayout2.HorzFarMargin = 25;
            this.gridLayout2.HorzNearMargin = 50;
            this.gridLayout2.Rows = 2;
            this.gridLayout2.TopMargin = 50;
            this.gridLayout2.VGap = 50;
            // 
            // gridLayout3
            // 
            this.gridLayout3.BottomMargin = 50;
            this.gridLayout3.Columns = 2;
            this.gridLayout3.ContainerControl = this.panel3;
            this.gridLayout3.HGap = 50;
            this.gridLayout3.HorzFarMargin = 50;
            this.gridLayout3.HorzNearMargin = 25;
            this.gridLayout3.Rows = 1;
            this.gridLayout3.TopMargin = 50;
            // 
            // TabAlignmentFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 694);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1500, 733);
            this.MinimumSize = new System.Drawing.Size(1500, 733);
            this.Name = "TabAlignmentFrame";
            this.Text = "Tab Alignment";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv2)).EndInit();
            this.tabControlAdv2.ResumeLayout(false);
            this.tabPageAdv3.ResumeLayout(false);
            this.tabPageAdv3.PerformLayout();
            this.tabPageAdv4.ResumeLayout(false);
            this.tabPageAdv4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.tabPageAdv1.PerformLayout();
            this.tabPageAdv2.ResumeLayout(false);
            this.tabPageAdv2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv4)).EndInit();
            this.tabControlAdv4.ResumeLayout(false);
            this.tabPageAdv7.ResumeLayout(false);
            this.tabPageAdv7.PerformLayout();
            this.tabPageAdv8.ResumeLayout(false);
            this.tabPageAdv8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv3)).EndInit();
            this.tabControlAdv3.ResumeLayout(false);
            this.tabPageAdv5.ResumeLayout(false);
            this.tabPageAdv5.PerformLayout();
            this.tabPageAdv6.ResumeLayout(false);
            this.tabPageAdv6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout3)).EndInit();
            this.ResumeLayout(false);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.tabControlAdv3.RotateTextWhenVertical = this.tabControlAdv4.RotateTextWhenVertical  = this.checkBox1.Checked;
           
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
