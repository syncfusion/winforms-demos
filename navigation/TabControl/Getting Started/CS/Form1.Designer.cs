#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TabControlAdv_2005
{
    partial class Form1
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
                string imagePath = ($"TabControlAdv_2005.Images.{folder}.Image_{i}.png");
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
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo1 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            this.gridLayout1 = new Syncfusion.Windows.Forms.Tools.GridLayout(this.components);
            this.PrimitivesTabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv4 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv5 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv22 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabControlAdv3 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.contextMenuStripEx1 = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            this.addTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageAdv16 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv18 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv21 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv17 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv19 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv20 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv33 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabControlAdv2 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.toolTipPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.superToolTipPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv23 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv24 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv25 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv36 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv38 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv32 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv31 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv34 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv35 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv37 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPageAdv6 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv7 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv8 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv9 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv10 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv11 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv12 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv13 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv14 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv15 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv26 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv27 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv28 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv29 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv30 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrimitivesTabControl)).BeginInit();
            this.PrimitivesTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv3)).BeginInit();
            this.tabControlAdv3.SuspendLayout();
            this.contextMenuStripEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv2)).BeginInit();
            this.tabControlAdv2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridLayout1
            // 
            this.gridLayout1.BottomMargin = 50;
            this.gridLayout1.Columns = 2;
            this.gridLayout1.ContainerControl = this;
            this.gridLayout1.HGap = 50;
            this.gridLayout1.HorzFarMargin = 50;
            this.gridLayout1.HorzNearMargin = 50;
            this.gridLayout1.Rows = 2;
            this.gridLayout1.TopMargin = 50;
            this.gridLayout1.VGap = 50;
            // 
            // PrimitivesTabControl
            // 
            this.PrimitivesTabControl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PrimitivesTabControl.BeforeTouchSize = new System.Drawing.Size(445, 278);
            this.PrimitivesTabControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrimitivesTabControl.Controls.Add(this.tabPageAdv1);
            this.PrimitivesTabControl.Controls.Add(this.tabPageAdv3);
            this.PrimitivesTabControl.Controls.Add(this.tabPageAdv4);
            this.PrimitivesTabControl.Controls.Add(this.tabPageAdv2);
            this.PrimitivesTabControl.Controls.Add(this.tabPageAdv5);
            this.PrimitivesTabControl.Controls.Add(this.tabPageAdv22);
            this.PrimitivesTabControl.FixedSingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(161)))));
            this.PrimitivesTabControl.FocusOnTabClick = false;
            this.PrimitivesTabControl.Location = new System.Drawing.Point(50, 51);
            this.PrimitivesTabControl.Name = "PrimitivesTabControl";
            this.gridLayout1.SetParticipateInLayout(this.PrimitivesTabControl, true);
            this.PrimitivesTabControl.ShowScroll = false;
            this.PrimitivesTabControl.ShowToolTips = true;
            this.PrimitivesTabControl.Size = new System.Drawing.Size(445, 278);
            this.PrimitivesTabControl.TabIndex = 4;
            this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(new Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.Custom, ((System.Drawing.Image)(resources.GetObject("PrimitivesTabControl.TabPrimitivesHost.TabPrimitives"))), System.Drawing.Color.Transparent, false, 1, "AddTab", "AddTab"));
            this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(new Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.FirstTab, null, System.Drawing.Color.Transparent, true, 1, "TabPrimitive0", "FirstTab"));
            this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(new Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.PreviousPage, null, System.Drawing.Color.Empty, true, 1, "TabPrimitive1", "PreviousPage"));
            this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(new Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.PreviousTab, null, System.Drawing.Color.Empty, true, 1, "TabPrimitive2", "PreviousTab"));
            this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(new Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.NextTab, null, System.Drawing.Color.Empty, true, 1, "TabPrimitive3", "NextTab"));
            this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(new Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.NextPage, null, System.Drawing.Color.Empty, true, 1, "TabPrimitive4", "NextPage"));
            this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(new Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.LastTab, null, System.Drawing.Color.Empty, true, 1, "TabPrimitive5", "LastTab"));
            this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(new Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.DropDown, null, System.Drawing.Color.Empty, true, 1, "TabPrimitive6", "DropDown"));
            this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(new Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.Close, null, System.Drawing.Color.Empty, true, 1, "TabPrimitive7", "Close"));
            this.PrimitivesTabControl.TabPrimitivesHost.Visible = true;
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(1, 25);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(443, 252);
            this.tabPageAdv1.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "Primitives Options";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // tabPageAdv3
            // 
            this.tabPageAdv3.Image = null;
            this.tabPageAdv3.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv3.Location = new System.Drawing.Point(1, 25);
            this.tabPageAdv3.Name = "tabPageAdv3";
            this.tabPageAdv3.ShowCloseButton = true;
            this.tabPageAdv3.Size = new System.Drawing.Size(443, 252);
            this.tabPageAdv3.TabIndex = 2;
            this.tabPageAdv3.Text = "TabPage 1";
            this.tabPageAdv3.ThemesEnabled = false;
            // 
            // tabPageAdv4
            // 
            this.tabPageAdv4.Image = null;
            this.tabPageAdv4.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv4.Location = new System.Drawing.Point(1, 25);
            this.tabPageAdv4.Name = "tabPageAdv4";
            this.tabPageAdv4.ShowCloseButton = true;
            this.tabPageAdv4.Size = new System.Drawing.Size(443, 252);
            this.tabPageAdv4.TabIndex = 3;
            this.tabPageAdv4.Text = "Tab Page 2";
            this.tabPageAdv4.ThemesEnabled = false;
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv2.Location = new System.Drawing.Point(1, 25);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(443, 252);
            this.tabPageAdv2.TabIndex = 4;
            this.tabPageAdv2.Text = "TabPage3";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // tabPageAdv5
            // 
            this.tabPageAdv5.Image = null;
            this.tabPageAdv5.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv5.Location = new System.Drawing.Point(1, 25);
            this.tabPageAdv5.Name = "tabPageAdv5";
            this.tabPageAdv5.ShowCloseButton = true;
            this.tabPageAdv5.Size = new System.Drawing.Size(443, 252);
            this.tabPageAdv5.TabIndex = 5;
            this.tabPageAdv5.Text = "TabPage4";
            this.tabPageAdv5.ThemesEnabled = false;
            // 
            // tabPageAdv22
            // 
            this.tabPageAdv22.Image = null;
            this.tabPageAdv22.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv22.Location = new System.Drawing.Point(1, 25);
            this.tabPageAdv22.Name = "tabPageAdv22";
            this.tabPageAdv22.ShowCloseButton = true;
            this.tabPageAdv22.Size = new System.Drawing.Size(443, 252);
            this.tabPageAdv22.TabIndex = 6;
            this.tabPageAdv22.Text = "TabPage5";
            this.tabPageAdv22.ThemesEnabled = false;
            // 
            // tabControlAdv3
            // 
            this.tabControlAdv3.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tabControlAdv3.BeforeTouchSize = new System.Drawing.Size(445, 278);
            this.tabControlAdv3.ContextMenuStrip = this.contextMenuStripEx1;
            this.tabControlAdv3.Controls.Add(this.tabPageAdv16);
            this.tabControlAdv3.Controls.Add(this.tabPageAdv18);
            this.tabControlAdv3.Controls.Add(this.tabPageAdv21);
            this.tabControlAdv3.Controls.Add(this.tabPageAdv17);
            this.tabControlAdv3.Controls.Add(this.tabPageAdv19);
            this.tabControlAdv3.Controls.Add(this.tabPageAdv20);
            this.tabControlAdv3.Controls.Add(this.tabPageAdv33);
            this.tabControlAdv3.InactiveCloseButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tabControlAdv3.Location = new System.Drawing.Point(545, 379);
            this.tabControlAdv3.Margin = new System.Windows.Forms.Padding(2);
            this.gridLayout1.SetMinimumSize(this.tabControlAdv3, new System.Drawing.Size(706, 374));
            this.tabControlAdv3.Multiline = true;
            this.tabControlAdv3.Name = "tabControlAdv3";
            this.gridLayout1.SetParticipateInLayout(this.tabControlAdv3, true);
            this.gridLayout1.SetPreferredSize(this.tabControlAdv3, new System.Drawing.Size(706, 374));
            this.tabControlAdv3.ShowTabCloseButton = true;
            this.tabControlAdv3.Size = new System.Drawing.Size(445, 278);
            this.tabControlAdv3.TabGap = 10;
            this.tabControlAdv3.TabIndex = 1;
            // 
            // contextMenuStripEx1
            // 
            this.contextMenuStripEx1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTabToolStripMenuItem});
            this.contextMenuStripEx1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.contextMenuStripEx1.Name = "contextMenuStripEx1";
            this.contextMenuStripEx1.Size = new System.Drawing.Size(118, 53);
            this.contextMenuStripEx1.Style = Syncfusion.Windows.Forms.Tools.ContextMenuStripEx.ContextMenuStyle.Default;
            this.contextMenuStripEx1.Text = "Options";
            this.contextMenuStripEx1.ThemeName = "Default";
            this.contextMenuStripEx1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripEx1_Opening);
            // 
            // addTabToolStripMenuItem
            // 
            this.addTabToolStripMenuItem.Name = "addTabToolStripMenuItem";
            this.addTabToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addTabToolStripMenuItem.Text = "Add Tab";
            this.addTabToolStripMenuItem.Click += new System.EventHandler(this.addTabToolStripMenuItem_Click);
            // 
            // tabPageAdv16
            // 
            this.tabPageAdv16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv16.Image = null;
            this.tabPageAdv16.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv16.Location = new System.Drawing.Point(1, 47);
            this.tabPageAdv16.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdv16.Name = "tabPageAdv16";
            this.tabPageAdv16.ShowCloseButton = true;
            this.tabPageAdv16.Size = new System.Drawing.Size(442, 229);
            this.tabPageAdv16.TabIndex = 1;
            this.tabPageAdv16.Text = "Tab Close Button";
            this.tabPageAdv16.ThemesEnabled = false;
            // 
            // tabPageAdv18
            // 
            this.tabPageAdv18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv18.Image = null;
            this.tabPageAdv18.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv18.Location = new System.Drawing.Point(1, 47);
            this.tabPageAdv18.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdv18.Name = "tabPageAdv18";
            this.tabPageAdv18.ShowCloseButton = true;
            this.tabPageAdv18.Size = new System.Drawing.Size(442, 229);
            this.tabPageAdv18.TabIndex = 2;
            this.tabPageAdv18.Text = "Double click to rename";
            this.tabPageAdv18.ThemesEnabled = false;
            // 
            // tabPageAdv21
            // 
            this.tabPageAdv21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv21.Image = null;
            this.tabPageAdv21.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv21.Location = new System.Drawing.Point(1, 47);
            this.tabPageAdv21.Name = "tabPageAdv21";
            this.tabPageAdv21.ShowCloseButton = true;
            this.tabPageAdv21.Size = new System.Drawing.Size(442, 229);
            this.tabPageAdv21.TabIndex = 6;
            this.tabPageAdv21.Text = "Right to Left";
            this.tabPageAdv21.ThemesEnabled = false;
            // 
            // tabPageAdv17
            // 
            this.tabPageAdv17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv17.Image = ((System.Drawing.Image)(resources.GetObject("tabPageAdv17.Image")));
            this.tabPageAdv17.ImageSize = new System.Drawing.Size(0, 0);
            this.tabPageAdv17.Location = new System.Drawing.Point(1, 47);
            this.tabPageAdv17.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdv17.Name = "tabPageAdv17";
            this.tabPageAdv17.ShowCloseButton = true;
            this.tabPageAdv17.Size = new System.Drawing.Size(442, 229);
            this.tabPageAdv17.TabIndex = 5;
            this.tabPageAdv17.Text = "MultiLine";
            this.tabPageAdv17.ThemesEnabled = false;
            // 
            // tabPageAdv19
            // 
            this.tabPageAdv19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv19.Image = null;
            this.tabPageAdv19.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv19.Location = new System.Drawing.Point(1, 47);
            this.tabPageAdv19.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdv19.Name = "tabPageAdv19";
            this.tabPageAdv19.ShowCloseButton = true;
            this.tabPageAdv19.Size = new System.Drawing.Size(442, 229);
            this.tabPageAdv19.TabIndex = 3;
            this.tabPageAdv19.Text = "Image Above Text";
            this.tabPageAdv19.ThemesEnabled = false;
            // 
            // tabPageAdv20
            // 
            this.tabPageAdv20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv20.Image = null;
            this.tabPageAdv20.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv20.Location = new System.Drawing.Point(1, 47);
            this.tabPageAdv20.Name = "tabPageAdv20";
            this.tabPageAdv20.ShowCloseButton = true;
            this.tabPageAdv20.Size = new System.Drawing.Size(442, 229);
            this.tabPageAdv20.TabIndex = 7;
            this.tabPageAdv20.Text = "TabPage1";
            this.tabPageAdv20.ThemesEnabled = false;
            // 
            // tabPageAdv33
            // 
            this.tabPageAdv33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv33.Image = null;
            this.tabPageAdv33.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv33.Location = new System.Drawing.Point(1, 47);
            this.tabPageAdv33.Name = "tabPageAdv33";
            this.tabPageAdv33.ShowCloseButton = true;
            this.tabPageAdv33.Size = new System.Drawing.Size(442, 229);
            this.tabPageAdv33.TabIndex = 8;
            this.tabPageAdv33.Text = "TabPage2";
            this.tabPageAdv33.ThemesEnabled = false;
            // 
            // tabControlAdv2
            // 
            this.tabControlAdv2.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tabControlAdv2.BeforeTouchSize = new System.Drawing.Size(445, 278);
            this.tabControlAdv2.ContextMenuStrip = this.contextMenuStripEx1;
            this.tabControlAdv2.Controls.Add(this.toolTipPage);
            this.tabControlAdv2.Controls.Add(this.superToolTipPage);
            this.tabControlAdv2.Controls.Add(this.tabPageAdv23);
            this.tabControlAdv2.Controls.Add(this.tabPageAdv24);
            this.tabControlAdv2.Controls.Add(this.tabPageAdv25);
            this.tabControlAdv2.Controls.Add(this.tabPageAdv36);
            this.tabControlAdv2.Controls.Add(this.tabPageAdv38);
            this.tabControlAdv2.InactiveCloseButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tabControlAdv2.InactiveTabColor = System.Drawing.Color.LightGray;
            this.tabControlAdv2.Location = new System.Drawing.Point(50, 379);
            this.tabControlAdv2.Margin = new System.Windows.Forms.Padding(2);
            this.gridLayout1.SetMinimumSize(this.tabControlAdv2, new System.Drawing.Size(706, 374));
            this.tabControlAdv2.MultilineText = true;
            this.tabControlAdv2.Name = "tabControlAdv2";
            this.gridLayout1.SetParticipateInLayout(this.tabControlAdv2, true);
            this.gridLayout1.SetPreferredSize(this.tabControlAdv2, new System.Drawing.Size(706, 374));
            this.tabControlAdv2.ShowSuperToolTips = true;
            this.tabControlAdv2.ShowToolTips = true;
            this.tabControlAdv2.Size = new System.Drawing.Size(445, 278);
            this.tabControlAdv2.TabIndex = 2;
            // 
            // toolTipPage
            // 
            this.toolTipPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolTipPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.toolTipPage.Image = null;
            this.toolTipPage.ImageSize = new System.Drawing.Size(20, 20);
            this.toolTipPage.Location = new System.Drawing.Point(1, 51);
            this.toolTipPage.Margin = new System.Windows.Forms.Padding(2);
            this.toolTipPage.Name = "toolTipPage";
            this.toolTipPage.ShowCloseButton = true;
            this.toolTipPage.Size = new System.Drawing.Size(442, 225);
            this.toolTipPage.TabIndex = 1;
            this.toolTipPage.Text = "Tool Tip";
            this.toolTipPage.ThemesEnabled = false;
            this.toolTipPage.ToolTipText = "TabControlAdv with ToolTip";
            // 
            // superToolTipPage
            // 
            this.superToolTipPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.superToolTipPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.superToolTipPage.Image = ((System.Drawing.Image)(resources.GetObject("superToolTipPage.Image")));
            this.superToolTipPage.ImageSize = new System.Drawing.Size(0, 0);
            this.superToolTipPage.Location = new System.Drawing.Point(1, 51);
            this.superToolTipPage.Margin = new System.Windows.Forms.Padding(2);
            this.superToolTipPage.Name = "superToolTipPage";
            this.superToolTipPage.ShowCloseButton = true;
            this.superToolTipPage.Size = new System.Drawing.Size(442, 225);
            toolTipInfo1.Body.Size = new System.Drawing.Size(50, 20);
            toolTipInfo1.Body.Text = "Body";
            toolTipInfo1.Footer.Size = new System.Drawing.Size(50, 20);
            toolTipInfo1.Footer.Text = "Footer";
            toolTipInfo1.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            toolTipInfo1.Header.Size = new System.Drawing.Size(50, 20);
            toolTipInfo1.Header.Text = "Header";
            toolTipInfo1.Separator = false;
            this.superToolTipPage.SuperTooltip = toolTipInfo1;
            this.superToolTipPage.TabIndex = 5;
            this.superToolTipPage.Text = "Super Tool Tip";
            this.superToolTipPage.ThemesEnabled = false;
            // 
            // tabPageAdv23
            // 
            this.tabPageAdv23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv23.Image = null;
            this.tabPageAdv23.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv23.Location = new System.Drawing.Point(1, 51);
            this.tabPageAdv23.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdv23.Name = "tabPageAdv23";
            this.tabPageAdv23.ShowCloseButton = true;
            this.tabPageAdv23.Size = new System.Drawing.Size(442, 225);
            this.tabPageAdv23.TabIndex = 2;
            this.tabPageAdv23.Text = "Right Image";
            this.tabPageAdv23.ThemesEnabled = false;
            // 
            // tabPageAdv24
            // 
            this.tabPageAdv24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv24.Image = null;
            this.tabPageAdv24.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv24.Location = new System.Drawing.Point(1, 51);
            this.tabPageAdv24.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdv24.Name = "tabPageAdv24";
            this.tabPageAdv24.ShowCloseButton = true;
            this.tabPageAdv24.Size = new System.Drawing.Size(442, 225);
            this.tabPageAdv24.TabIndex = 3;
            this.tabPageAdv24.Text = "Multiline\r\nText\r\n";
            this.tabPageAdv24.ThemesEnabled = false;
            // 
            // tabPageAdv25
            // 
            this.tabPageAdv25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv25.Image = null;
            this.tabPageAdv25.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv25.Location = new System.Drawing.Point(1, 51);
            this.tabPageAdv25.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdv25.Name = "tabPageAdv25";
            this.tabPageAdv25.ShowCloseButton = true;
            this.tabPageAdv25.Size = new System.Drawing.Size(442, 225);
            this.tabPageAdv25.TabIndex = 4;
            this.tabPageAdv25.Text = "Tab Gap";
            this.tabPageAdv25.ThemesEnabled = false;
            // 
            // tabPageAdv36
            // 
            this.tabPageAdv36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv36.Image = null;
            this.tabPageAdv36.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv36.Location = new System.Drawing.Point(1, 51);
            this.tabPageAdv36.Name = "tabPageAdv36";
            this.tabPageAdv36.ShowCloseButton = true;
            this.tabPageAdv36.Size = new System.Drawing.Size(442, 225);
            this.tabPageAdv36.TabIndex = 6;
            this.tabPageAdv36.Text = "Top Gap";
            this.tabPageAdv36.ThemesEnabled = false;
            // 
            // tabPageAdv38
            // 
            this.tabPageAdv38.Image = null;
            this.tabPageAdv38.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv38.Location = new System.Drawing.Point(1, 51);
            this.tabPageAdv38.Name = "tabPageAdv38";
            this.tabPageAdv38.ShowCloseButton = true;
            this.tabPageAdv38.Size = new System.Drawing.Size(442, 225);
            this.tabPageAdv38.TabIndex = 7;
            this.tabPageAdv38.Text = "Close Tab Middle Click";
            this.tabPageAdv38.ThemesEnabled = false;
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(445, 278);
            this.tabControlAdv1.ContextMenuStrip = this.contextMenuStripEx1;
            this.tabControlAdv1.Controls.Add(this.tabPageAdv32);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv31);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv34);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv35);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv37);
            this.tabControlAdv1.ImageList = this.imageList;
            this.tabControlAdv1.Location = new System.Drawing.Point(545, 51);
            this.tabControlAdv1.Margin = new System.Windows.Forms.Padding(2);
            this.gridLayout1.SetMinimumSize(this.tabControlAdv1, new System.Drawing.Size(706, 374));
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.gridLayout1.SetParticipateInLayout(this.tabControlAdv1, true);
            this.gridLayout1.SetPreferredSize(this.tabControlAdv1, new System.Drawing.Size(706, 374));
            this.tabControlAdv1.Size = new System.Drawing.Size(445, 278);
            this.tabControlAdv1.TabIndex = 3;
            this.tabControlAdv1.VSLikeScrollButton = true;
            // 
            // tabPageAdv32
            // 
            this.tabPageAdv32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv32.Image = null;
            this.tabPageAdv32.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv32.Location = new System.Drawing.Point(1, 36);
            this.tabPageAdv32.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdv32.Name = "tabPageAdv32";
            this.tabPageAdv32.ShowCloseButton = true;
            this.tabPageAdv32.Size = new System.Drawing.Size(442, 240);
            this.tabPageAdv32.TabIndex = 5;
            this.tabPageAdv32.Text = "Animated Tab";
            this.tabPageAdv32.ThemesEnabled = false;
            // 
            // tabPageAdv31
            // 
            this.tabPageAdv31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv31.Image = null;
            this.tabPageAdv31.ImageIndex = 8;
            this.tabPageAdv31.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv31.Location = new System.Drawing.Point(1, 36);
            this.tabPageAdv31.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdv31.Name = "tabPageAdv31";
            this.tabPageAdv31.ShowCloseButton = true;
            this.tabPageAdv31.Size = new System.Drawing.Size(442, 240);
            this.tabPageAdv31.TabIndex = 1;
            this.tabPageAdv31.Text = "Custom ContextMenu";
            this.tabPageAdv31.ThemesEnabled = false;
            // 
            // tabPageAdv34
            // 
            this.tabPageAdv34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv34.Image = null;
            this.tabPageAdv34.ImageIndex = 1;
            this.tabPageAdv34.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv34.Location = new System.Drawing.Point(1, 36);
            this.tabPageAdv34.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdv34.Name = "tabPageAdv34";
            this.tabPageAdv34.ShowCloseButton = true;
            this.tabPageAdv34.Size = new System.Drawing.Size(442, 240);
            this.tabPageAdv34.TabIndex = 3;
            this.tabPageAdv34.Text = "Left Image";
            this.tabPageAdv34.ThemesEnabled = false;
            // 
            // tabPageAdv35
            // 
            this.tabPageAdv35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv35.Image = null;
            this.tabPageAdv35.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv35.Location = new System.Drawing.Point(1, 36);
            this.tabPageAdv35.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdv35.Name = "tabPageAdv35";
            this.tabPageAdv35.ShowCloseButton = true;
            this.tabPageAdv35.Size = new System.Drawing.Size(442, 240);
            this.tabPageAdv35.TabIndex = 4;
            this.tabPageAdv35.Text = "Disable Inactive Image";
            this.tabPageAdv35.ThemesEnabled = false;
            // 
            // tabPageAdv37
            // 
            this.tabPageAdv37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv37.Image = null;
            this.tabPageAdv37.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv37.Location = new System.Drawing.Point(1, 36);
            this.tabPageAdv37.Name = "tabPageAdv37";
            this.tabPageAdv37.ShowCloseButton = true;
            this.tabPageAdv37.Size = new System.Drawing.Size(442, 240);
            this.tabPageAdv37.TabIndex = 6;
            this.tabPageAdv37.Text = "Move tabs on Drag";
            this.tabPageAdv37.ThemesEnabled = false;
            // 
            // imageList
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.imageList, "ImageList", 9);
#else
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
#endif
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "user_24.png");
            this.imageList.Images.SetKeyName(1, "clip_24.png");
            this.imageList.Images.SetKeyName(2, "sphere_24.png");
            this.imageList.Images.SetKeyName(3, "ellipse_24_hot.png");
            this.imageList.Images.SetKeyName(4, "mergedfield_icon_16.png");
            this.imageList.Images.SetKeyName(5, "group_icon_16.png");
            this.imageList.Images.SetKeyName(6, "primitives.gif");
            this.imageList.Images.SetKeyName(7, "apperance.gif");
            this.imageList.Images.SetKeyName(8, "behaviour.gif");
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.gridLayout1.SetParticipateInLayout(this.panel1, false);
            this.panel1.Size = new System.Drawing.Size(1036, 27);
            this.panel1.TabIndex = 5;
            // 
            // autoLabel1
            // 
            this.autoLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.autoLabel1.Location = new System.Drawing.Point(727, 7);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(61, 13);
            this.autoLabel1.TabIndex = 1;
            this.autoLabel1.Text = "Visual Style";
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(189, 19);
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Office2019Colorful",
            "HighContrastBlack"});
            this.comboBoxAdv1.Location = new System.Drawing.Point(794, 3);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(189, 19);
            this.comboBoxAdv1.TabIndex = 0;
            this.comboBoxAdv1.Text = "Office2019Colorful";
            this.comboBoxAdv1.ThemeName = "Office2019Colorful";
            // 
            // imageList1
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.imageList1, "ImageList1", 2);
#else
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
#endif
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "behaviour.gif");
            this.imageList1.Images.SetKeyName(1, "tab.png");
            // 
            // tabPageAdv6
            // 
            this.tabPageAdv6.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageAdv6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageAdv6.Image = null;
            this.tabPageAdv6.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv6.Location = new System.Drawing.Point(1, 0);
            this.tabPageAdv6.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdv6.Name = "tabPageAdv6";
            this.tabPageAdv6.ShowCloseButton = true;
            this.tabPageAdv6.Size = new System.Drawing.Size(197, 98);
            this.tabPageAdv6.TabFont = null;
            this.tabPageAdv6.TabIndex = 1;
            this.tabPageAdv6.Text = "Custom ContextMenu";
            this.tabPageAdv6.ThemesEnabled = false;
            // 
            // tabPageAdv7
            // 
            this.tabPageAdv7.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageAdv7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageAdv7.Image = ((System.Drawing.Image)(resources.GetObject("tabPageAdv7.Image")));
            this.tabPageAdv7.ImageSize = new System.Drawing.Size(0, 0);
            this.tabPageAdv7.Location = new System.Drawing.Point(1, 0);
            this.tabPageAdv7.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdv7.Name = "tabPageAdv7";
            this.tabPageAdv7.ShowCloseButton = true;
            this.tabPageAdv7.Size = new System.Drawing.Size(197, 98);
            this.tabPageAdv7.TabFont = null;
            this.tabPageAdv7.TabIndex = 5;
            this.tabPageAdv7.Text = "Animated Tab";
            this.tabPageAdv7.ThemesEnabled = false;
            // 
            // tabPageAdv8
            // 
            this.tabPageAdv8.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageAdv8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageAdv8.Image = null;
            this.tabPageAdv8.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv8.Location = new System.Drawing.Point(1, 0);
            this.tabPageAdv8.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdv8.Name = "tabPageAdv8";
            this.tabPageAdv8.ShowCloseButton = true;
            this.tabPageAdv8.Size = new System.Drawing.Size(197, 98);
            this.tabPageAdv8.TabFont = null;
            this.tabPageAdv8.TabIndex = 2;
            this.tabPageAdv8.Text = "Outside Image";
            this.tabPageAdv8.ThemesEnabled = false;
            // 
            // tabPageAdv9
            // 
            this.tabPageAdv9.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageAdv9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageAdv9.Image = null;
            this.tabPageAdv9.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv9.Location = new System.Drawing.Point(1, 0);
            this.tabPageAdv9.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdv9.Name = "tabPageAdv9";
            this.tabPageAdv9.ShowCloseButton = true;
            this.tabPageAdv9.Size = new System.Drawing.Size(197, 98);
            this.tabPageAdv9.TabFont = null;
            this.tabPageAdv9.TabIndex = 3;
            this.tabPageAdv9.Text = "Left Image";
            this.tabPageAdv9.ThemesEnabled = false;
            // 
            // tabPageAdv10
            // 
            this.tabPageAdv10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv10.Image = null;
            this.tabPageAdv10.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv10.Location = new System.Drawing.Point(1, 22);
            this.tabPageAdv10.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdv10.Name = "tabPageAdv10";
            this.tabPageAdv10.ShowCloseButton = true;
            this.tabPageAdv10.Size = new System.Drawing.Size(548, 279);
            this.tabPageAdv10.TabFont = null;
            this.tabPageAdv10.TabIndex = 4;
            this.tabPageAdv10.Text = "Disable Image";
            this.tabPageAdv10.ThemesEnabled = false;
            // 
            // tabPageAdv11
            // 
            this.tabPageAdv11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv11.Image = null;
            this.tabPageAdv11.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv11.Location = new System.Drawing.Point(1, 0);
            this.tabPageAdv11.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdv11.Name = "tabPageAdv11";
            this.tabPageAdv11.ShowCloseButton = true;
            this.tabPageAdv11.Size = new System.Drawing.Size(197, 98);
            this.tabPageAdv11.TabFont = null;
            this.tabPageAdv11.TabIndex = 1;
            this.tabPageAdv11.Text = "Custom ContextMenu";
            this.tabPageAdv11.ThemesEnabled = false;
            // 
            // tabPageAdv12
            // 
            this.tabPageAdv12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv12.Image = ((System.Drawing.Image)(resources.GetObject("tabPageAdv12.Image")));
            this.tabPageAdv12.ImageSize = new System.Drawing.Size(0, 0);
            this.tabPageAdv12.Location = new System.Drawing.Point(1, 0);
            this.tabPageAdv12.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdv12.Name = "tabPageAdv12";
            this.tabPageAdv12.ShowCloseButton = true;
            this.tabPageAdv12.Size = new System.Drawing.Size(197, 98);
            this.tabPageAdv12.TabFont = null;
            this.tabPageAdv12.TabIndex = 5;
            this.tabPageAdv12.Text = "Animated Tab";
            this.tabPageAdv12.ThemesEnabled = false;
            // 
            // tabPageAdv13
            // 
            this.tabPageAdv13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv13.Image = null;
            this.tabPageAdv13.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv13.Location = new System.Drawing.Point(1, 0);
            this.tabPageAdv13.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdv13.Name = "tabPageAdv13";
            this.tabPageAdv13.ShowCloseButton = true;
            this.tabPageAdv13.Size = new System.Drawing.Size(197, 98);
            this.tabPageAdv13.TabFont = null;
            this.tabPageAdv13.TabIndex = 2;
            this.tabPageAdv13.Text = "Outside Image";
            this.tabPageAdv13.ThemesEnabled = false;
            // 
            // tabPageAdv14
            // 
            this.tabPageAdv14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv14.Image = null;
            this.tabPageAdv14.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv14.Location = new System.Drawing.Point(1, 0);
            this.tabPageAdv14.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdv14.Name = "tabPageAdv14";
            this.tabPageAdv14.ShowCloseButton = true;
            this.tabPageAdv14.Size = new System.Drawing.Size(197, 98);
            this.tabPageAdv14.TabFont = null;
            this.tabPageAdv14.TabIndex = 3;
            this.tabPageAdv14.Text = "Left Image";
            this.tabPageAdv14.ThemesEnabled = false;
            // 
            // tabPageAdv15
            // 
            this.tabPageAdv15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv15.Image = null;
            this.tabPageAdv15.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv15.Location = new System.Drawing.Point(1, 22);
            this.tabPageAdv15.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdv15.Name = "tabPageAdv15";
            this.tabPageAdv15.ShowCloseButton = true;
            this.tabPageAdv15.Size = new System.Drawing.Size(548, 279);
            this.tabPageAdv15.TabFont = null;
            this.tabPageAdv15.TabIndex = 4;
            this.tabPageAdv15.Text = "Disable Image";
            this.tabPageAdv15.ThemesEnabled = false;
            // 
            // tabPageAdv26
            // 
            this.tabPageAdv26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv26.Image = null;
            this.tabPageAdv26.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv26.Location = new System.Drawing.Point(1, 0);
            this.tabPageAdv26.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdv26.Name = "tabPageAdv26";
            this.tabPageAdv26.ShowCloseButton = true;
            this.tabPageAdv26.Size = new System.Drawing.Size(197, 98);
            this.tabPageAdv26.TabFont = null;
            this.tabPageAdv26.TabIndex = 1;
            this.tabPageAdv26.Text = "Custom ContextMenu";
            this.tabPageAdv26.ThemesEnabled = false;
            // 
            // tabPageAdv27
            // 
            this.tabPageAdv27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv27.Image = ((System.Drawing.Image)(resources.GetObject("tabPageAdv27.Image")));
            this.tabPageAdv27.ImageSize = new System.Drawing.Size(0, 0);
            this.tabPageAdv27.Location = new System.Drawing.Point(1, 0);
            this.tabPageAdv27.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdv27.Name = "tabPageAdv27";
            this.tabPageAdv27.ShowCloseButton = true;
            this.tabPageAdv27.Size = new System.Drawing.Size(197, 98);
            this.tabPageAdv27.TabFont = null;
            this.tabPageAdv27.TabIndex = 5;
            this.tabPageAdv27.Text = "Animated Tab";
            this.tabPageAdv27.ThemesEnabled = false;
            // 
            // tabPageAdv28
            // 
            this.tabPageAdv28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv28.Image = null;
            this.tabPageAdv28.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv28.Location = new System.Drawing.Point(1, 0);
            this.tabPageAdv28.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdv28.Name = "tabPageAdv28";
            this.tabPageAdv28.ShowCloseButton = true;
            this.tabPageAdv28.Size = new System.Drawing.Size(197, 98);
            this.tabPageAdv28.TabFont = null;
            this.tabPageAdv28.TabIndex = 2;
            this.tabPageAdv28.Text = "Outside Image";
            this.tabPageAdv28.ThemesEnabled = false;
            // 
            // tabPageAdv29
            // 
            this.tabPageAdv29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv29.Image = null;
            this.tabPageAdv29.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv29.Location = new System.Drawing.Point(1, 0);
            this.tabPageAdv29.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdv29.Name = "tabPageAdv29";
            this.tabPageAdv29.ShowCloseButton = true;
            this.tabPageAdv29.Size = new System.Drawing.Size(197, 98);
            this.tabPageAdv29.TabFont = null;
            this.tabPageAdv29.TabIndex = 3;
            this.tabPageAdv29.Text = "Left Image";
            this.tabPageAdv29.ThemesEnabled = false;
            // 
            // tabPageAdv30
            // 
            this.tabPageAdv30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv30.Image = null;
            this.tabPageAdv30.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv30.Location = new System.Drawing.Point(1, 22);
            this.tabPageAdv30.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdv30.Name = "tabPageAdv30";
            this.tabPageAdv30.ShowCloseButton = true;
            this.tabPageAdv30.Size = new System.Drawing.Size(548, 279);
            this.tabPageAdv30.TabFont = null;
            this.tabPageAdv30.TabIndex = 4;
            this.tabPageAdv30.Text = "Disable Image";
            this.tabPageAdv30.ThemesEnabled = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.comboBoxAdv1);
            this.flowLayoutPanel1.Controls.Add(this.autoLabel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1036, 27);
            this.flowLayoutPanel1.TabIndex = 2;
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.flowLayoutPanel1.Padding = new Padding(0, 0, (int)(((DpiAware.GetCurrentDpi() / 96) - 1) * this.flowLayoutPanel1.Padding.Right), 0);
            }
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 707);
            this.Controls.Add(this.PrimitivesTabControl);
            this.Controls.Add(this.tabControlAdv1);
            this.Controls.Add(this.tabControlAdv2);
            this.Controls.Add(this.tabControlAdv3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Tab Control";
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrimitivesTabControl)).EndInit();
            this.PrimitivesTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv3)).EndInit();
            this.tabControlAdv3.ResumeLayout(false);
            this.contextMenuStripEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv2)).EndInit();
            this.tabControlAdv2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GridLayout gridLayout1;
        private System.Windows.Forms.Panel panel1;
        private ContextMenuStripEx contextMenuStripEx1;
        private ToolStripMenuItem addTabToolStripMenuItem;
        private ImageList imageList1;
        private TabPageAdv tabPageAdv6;
        private TabPageAdv tabPageAdv7;
        private TabPageAdv tabPageAdv8;
        private TabPageAdv tabPageAdv9;
        private TabPageAdv tabPageAdv10;
        private TabPageAdv tabPageAdv11;
        private TabPageAdv tabPageAdv12;
        private TabPageAdv tabPageAdv13;
        private TabPageAdv tabPageAdv14;
        private TabPageAdv tabPageAdv15;
        private TabControlAdv tabControlAdv2;
        private TabPageAdv toolTipPage;
        private TabPageAdv superToolTipPage;
        private TabPageAdv tabPageAdv23;
        private TabPageAdv tabPageAdv24;
        private TabPageAdv tabPageAdv25;
        private TabControlAdv tabControlAdv3;
        private TabPageAdv tabPageAdv16;
        private TabPageAdv tabPageAdv17;
        private TabPageAdv tabPageAdv18;
        private TabPageAdv tabPageAdv19;
        private TabPageAdv tabPageAdv26;
        private TabPageAdv tabPageAdv27;
        private TabPageAdv tabPageAdv28;
        private TabPageAdv tabPageAdv29;
        private TabPageAdv tabPageAdv30;
        private TabControlAdv tabControlAdv1;
        private TabPageAdv tabPageAdv32;
        private TabPageAdv tabPageAdv34;
        private TabPageAdv tabPageAdv35;
        private TabPageAdv tabPageAdv31;
        private TabPageAdv tabPageAdv21;
        private ImageList imageList;
        private TabControlAdv PrimitivesTabControl;
        private TabPageAdv tabPageAdv1;
        private TabPageAdv tabPageAdv3;
        private TabPageAdv tabPageAdv4;
        private TabPageAdv tabPageAdv2;
        private TabPageAdv tabPageAdv5;
        private TabPageAdv tabPageAdv22;
        private TabPageAdv tabPageAdv36;
        private TabPageAdv tabPageAdv20;
        private TabPageAdv tabPageAdv33;
        private TabPageAdv tabPageAdv37;
        private TabPageAdv tabPageAdv38;
        private AutoLabel autoLabel1;
        private ComboBoxAdv comboBoxAdv1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}