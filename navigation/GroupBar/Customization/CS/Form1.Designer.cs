#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.WinForms.Input;
using Syncfusion.WinForms.ListView;
using System.Drawing;

namespace GroupBarDemo_2005
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
                if (groupBar1 != null)
                {
                    groupBar1.Dispose();
                    groupBar1 = null;
                }
                if (gradientPanel1 != null)
                {
                    gradientPanel1.Dispose();
                    gradientPanel1 = null;
                }
                if (gradientPanel2 != null)
                {
                    gradientPanel2.Dispose();
                    gradientPanel2 = null;
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo2 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv35 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv36 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv37 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv38 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv39 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv40 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv41 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv42 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv43 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv44 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv45 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv46 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv47 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv48 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv49 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv50 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv51 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv52 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv53 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv54 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeViewAdvVisualStyle treeViewAdvVisualStyle2 = new Syncfusion.Windows.Forms.Tools.TreeViewAdvVisualStyle();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv2 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv3 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv4 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv5 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv6 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv7 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv8 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv9 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv10 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv11 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv12 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv13 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv14 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv15 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv16 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv17 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv18 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv19 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv20 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv21 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv22 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv23 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv24 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv25 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv26 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv27 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv28 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv29 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv30 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv31 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv32 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv33 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv34 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeViewAdvVisualStyle treeViewAdvVisualStyle1 = new Syncfusion.Windows.Forms.Tools.TreeViewAdvVisualStyle();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo5 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv60 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv61 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeViewAdvVisualStyle treeViewAdvVisualStyle5 = new Syncfusion.Windows.Forms.Tools.TreeViewAdvVisualStyle();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo4 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv58 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv59 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeViewAdvVisualStyle treeViewAdvVisualStyle4 = new Syncfusion.Windows.Forms.Tools.TreeViewAdvVisualStyle();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo3 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv55 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv56 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv57 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeViewAdvVisualStyle treeViewAdvVisualStyle3 = new Syncfusion.Windows.Forms.Tools.TreeViewAdvVisualStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.cbCollapse = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label15 = new System.Windows.Forms.Label();
            this.cbChevron = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.cmbPopupResize = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cbAllowCollapse = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.cbAutoClose = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.numericCollapsedWidth = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.label18 = new System.Windows.Forms.Label();
            this.cbShowGripper = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.groupBarItem2 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem1 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem3 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.panel15 = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.groupBar1 = new Syncfusion.Windows.Forms.Tools.GroupBar();
            this.treeViewAdv3 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.treeViewAdv4 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.treeViewAdv5 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.treeViewAdv2 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.treeViewAdv1 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.panel2 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new Syncfusion.WinForms.Input.SfCalendar();
            this.Mail = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.Calendar = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.Favorites = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.Notes = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.Tasks = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.Folders = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCollapse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChevron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPopupResize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAllowCollapse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAutoClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCollapsedWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbShowGripper)).BeginInit();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).BeginInit();
            this.groupBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BackColor = System.Drawing.Color.White;
            this.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel2.Controls.Add(this.cbCollapse);
            this.gradientPanel2.Controls.Add(this.label15);
            this.gradientPanel2.Controls.Add(this.cbChevron);
            this.gradientPanel2.Controls.Add(this.cmbPopupResize);
            this.gradientPanel2.Controls.Add(this.cbAllowCollapse);
            this.gradientPanel2.Controls.Add(this.cbAutoClose);
            this.gradientPanel2.Controls.Add(this.numericCollapsedWidth);
            this.gradientPanel2.Controls.Add(this.label18);
            this.gradientPanel2.Controls.Add(this.cbShowGripper);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.gradientPanel2.Location = new System.Drawing.Point(394, 0);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(286, 531);
            this.gradientPanel2.TabIndex = 197;
            // 
            // cbCollapse
            // 
            this.cbCollapse.AutoSize = true;
            this.cbCollapse.MinimumSize = new Size(300, 20);
            this.cbCollapse.BeforeTouchSize = new System.Drawing.Size(151, 20);
            this.cbCollapse.DrawFocusRectangle = false;
            this.cbCollapse.Location = new System.Drawing.Point(31, 179);
            this.cbCollapse.MetroColor = System.Drawing.Color.Gray;
            this.cbCollapse.Name = "cbCollapse";
            this.cbCollapse.Size = new System.Drawing.Size(151, 20);
            this.cbCollapse.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbCollapse.TabIndex = 0;
            this.cbCollapse.Text = "Expand / Collapse";
            this.cbCollapse.ThemeName = "Metro";
            this.cbCollapse.ThemesEnabled = false;
            this.cbCollapse.CheckedChanged += new System.EventHandler(this.cbCollapse_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(31, 357);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Popup Resize Mode";
            // 
            // cbChevron
            // 
            this.cbChevron.AutoSize = true;
            this.cbChevron.MinimumSize = new Size(300, 20);
            this.cbChevron.BeforeTouchSize = new System.Drawing.Size(115, 17);
            this.cbChevron.Checked = true;
            this.cbChevron.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbChevron.DrawFocusRectangle = false;
            this.cbChevron.Location = new System.Drawing.Point(31, 100);
            this.cbChevron.MetroColor = System.Drawing.Color.Gray;
            this.cbChevron.Name = "cbChevron";
            this.cbChevron.Size = new System.Drawing.Size(115, 17);
            this.cbChevron.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbChevron.TabIndex = 134;
            this.cbChevron.Text = "Show Chevron";
            this.cbChevron.ThemeName = "Metro";
            this.cbChevron.ThemesEnabled = false;
            this.cbChevron.CheckedChanged += new System.EventHandler(this.ChevronCheckBox_CheckedChanged);
            // 
            // cmbPopupResize
            // 
            this.cmbPopupResize.BackColor = System.Drawing.Color.White;
            this.cmbPopupResize.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;            
            this.cmbPopupResize.Location = new System.Drawing.Point(153, 354);
            this.cmbPopupResize.Name = "cmbPopupResize";
            this.cmbPopupResize.Size = new System.Drawing.Size(113, 21);
            this.cmbPopupResize.TabIndex = 16;
            this.cmbPopupResize.Text = "Both";
            this.cmbPopupResize.SelectedIndexChanged += new System.EventHandler(this.PopupResizeComboBox_SelectedIndexChanged);
            // 
            // cbAllowCollapse
            // 
            this.cbAllowCollapse.AutoSize = true;
            this.cbAllowCollapse.MinimumSize = new Size(300, 20);
            this.cbAllowCollapse.BeforeTouchSize = new System.Drawing.Size(130, 20);
            this.cbAllowCollapse.Checked = true;
            this.cbAllowCollapse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAllowCollapse.DrawFocusRectangle = false;
            this.cbAllowCollapse.Location = new System.Drawing.Point(31, 139);
            this.cbAllowCollapse.MetroColor = System.Drawing.Color.Gray;
            this.cbAllowCollapse.Name = "cbAllowCollapse";
            this.cbAllowCollapse.Size = new System.Drawing.Size(130, 20);
            this.cbAllowCollapse.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbAllowCollapse.TabIndex = 22;
            this.cbAllowCollapse.Text = "Show Collapse Icon";
            this.cbAllowCollapse.ThemeName = "Metro";
            this.cbAllowCollapse.ThemesEnabled = false;
            this.cbAllowCollapse.CheckedChanged += new System.EventHandler(this.cbAllowCollapse_CheckedChanged);
            // 
            // cbAutoClose
            // 
            this.cbAutoClose.AutoSize = true;
            this.cbAutoClose.MinimumSize = new Size(300, 20);
            this.cbAutoClose.BeforeTouchSize = new System.Drawing.Size(115, 16);
            this.cbAutoClose.DrawFocusRectangle = false;
            this.cbAutoClose.Location = new System.Drawing.Point(31, 256);
            this.cbAutoClose.MetroColor = System.Drawing.Color.Gray;
            this.cbAutoClose.Name = "cbAutoClose";
            this.cbAutoClose.Size = new System.Drawing.Size(115, 16);
            this.cbAutoClose.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbAutoClose.TabIndex = 11;
            this.cbAutoClose.Text = "Popup Auto Close";
            this.cbAutoClose.ThemeName = "Metro";
            this.cbAutoClose.ThemesEnabled = false;
            this.cbAutoClose.CheckedChanged += new System.EventHandler(this.cbAutoClose_CheckedChanged);
            // 
            // numericCollapsedWidth
            // 
            this.numericCollapsedWidth.BackColor = System.Drawing.Color.White;
            this.numericCollapsedWidth.BeforeTouchSize = new System.Drawing.Size(113, 22);
            this.numericCollapsedWidth.BorderColor = System.Drawing.Color.Gray;
            this.numericCollapsedWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericCollapsedWidth.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericCollapsedWidth.Location = new System.Drawing.Point(153, 319);
            this.numericCollapsedWidth.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numericCollapsedWidth.MetroColor = System.Drawing.Color.Gray;
            this.numericCollapsedWidth.Minimum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericCollapsedWidth.Name = "numericCollapsedWidth";
            this.numericCollapsedWidth.Size = new System.Drawing.Size(113, 22);
            this.numericCollapsedWidth.TabIndex = 8;
            this.numericCollapsedWidth.ThemeStyle.HoverUpDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.numericCollapsedWidth.ThemeStyle.PressedUpDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.numericCollapsedWidth.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericCollapsedWidth.ValueChanged += new System.EventHandler(this.CollapsedWidthNumericUpDown_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(31, 325);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Collapsed Width";
            // 
            // cbShowGripper
            // 
            this.cbShowGripper.AutoSize = true;
            this.cbShowGripper.MinimumSize = new Size(300,20);
            this.cbShowGripper.BeforeTouchSize = new System.Drawing.Size(130, 16);
            this.cbShowGripper.Checked = true;
            this.cbShowGripper.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowGripper.DrawFocusRectangle = false;
            this.cbShowGripper.Location = new System.Drawing.Point(31, 217);
            this.cbShowGripper.MetroColor = System.Drawing.Color.Gray;
            this.cbShowGripper.Name = "cbShowGripper";
            this.cbShowGripper.Size = new System.Drawing.Size(130, 16);
            this.cbShowGripper.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbShowGripper.TabIndex = 1;
            this.cbShowGripper.Text = "Show Popup Gripper";
            this.cbShowGripper.ThemeName = "Metro";
            this.cbShowGripper.ThemesEnabled = false;
            this.cbShowGripper.CheckedChanged += new System.EventHandler(this.cbShowGripper_CheckedChanged);
            // 
            // groupBarItem2
            // 
            this.groupBarItem2.Client = null;
            this.groupBarItem2.Text = "";
            // 
            // groupBarItem1
            // 
            this.groupBarItem1.Client = null;
            this.groupBarItem1.Text = "";
            // 
            // groupBarItem3
            // 
            this.groupBarItem3.Client = null;
            this.groupBarItem3.Text = "";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.gradientPanel1);
            this.panel15.Controls.Add(this.panel1);
            this.panel15.Controls.Add(this.gradientPanel2);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(10, 10);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(680, 531);
            this.panel15.TabIndex = 198;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.groupBar1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(386, 531);
            this.gradientPanel1.TabIndex = 199;
            // 
            // groupBar1
            // 
            this.groupBar1.AllowCollapse = true;
            this.groupBar1.AllowDrop = true;
            this.groupBar1.AnimatedSelection = false;
            this.groupBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupBar1.BeforeTouchSize = new System.Drawing.Size(365, 529);
            this.groupBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.groupBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupBar1.CollapsedText = "Outlook";
            this.groupBar1.CollapseImage = ((System.Drawing.Image)(resources.GetObject("groupBar1.CollapseImage")));
            this.groupBar1.Controls.Add(this.treeViewAdv4);
            this.groupBar1.Controls.Add(this.treeViewAdv3);
            this.groupBar1.Controls.Add(this.treeViewAdv1);
            this.groupBar1.Controls.Add(this.treeViewAdv2);
            this.groupBar1.Controls.Add(this.treeViewAdv5);
            this.groupBar1.Controls.Add(this.panel2);
            this.groupBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBar1.ExpandButtonToolTip = "Click to expand Folder Pane";
            this.groupBar1.ExpandedWidth = 365;
            this.groupBar1.ExpandImage = ((System.Drawing.Image)(resources.GetObject("groupBar1.ExpandImage")));
            this.groupBar1.FlatLook = true;
            this.groupBar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.groupBar1.GroupBarDropDownToolTip = null;
            this.groupBar1.GroupBarItemHeight = 40;
            this.groupBar1.GroupBarItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupBarItem[] {
            this.Mail,
            this.Calendar,
            this.Favorites,
            this.Notes,
            this.Tasks,
            this.Folders});
            this.groupBar1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupBar1.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.groupBar1.HeaderHeight = 35;
            this.groupBar1.IndexOnVisibleItems = true;
            this.groupBar1.Location = new System.Drawing.Point(0, 0);
            this.groupBar1.MinimizeButtonToolTip = null;
            this.groupBar1.Name = "groupBar1";
            this.groupBar1.NavigationPaneButtonWidth = 50;
            this.groupBar1.NavigationPaneHeight = 40;
            this.groupBar1.NavigationPaneTooltip = null;
            this.groupBar1.PopupClientSize = new System.Drawing.Size(330, 300);
            this.groupBar1.PopupResizeMode = Syncfusion.Windows.Forms.Tools.PopupResizeMode.Horizontal;
            this.groupBar1.SelectedItem = 0;
            this.groupBar1.ShowPopupGripper = true;
            this.groupBar1.Size = new System.Drawing.Size(365, 529);
            this.groupBar1.SmartSizeBox = false;
            this.groupBar1.Splittercolor = System.Drawing.Color.Red;
            this.groupBar1.StackedMode = true;
            this.groupBar1.TabIndex = 0;
            this.groupBar1.Text = "groupBar1";
            this.groupBar1.ThemeName = "Office2016Colorful";
            this.groupBar1.ThemeStyle.CollapsedViewStyle.ItemStyle.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.groupBar1.ThemeStyle.ItemStyle.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.groupBar1.ThemeStyle.StackedViewStyle.CollapsedItemStyle.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.groupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.groupBar1.StateChanged += new System.EventHandler(this.groupBar1_StateChanged);
            // 
            // treeViewAdv3
            // 
            this.treeViewAdv3.BackColor = System.Drawing.Color.White;
            this.treeViewAdv3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            treeNodeAdvStyleInfo2.CheckBoxTickThickness = 1;
            treeNodeAdvStyleInfo2.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo2.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo2.Font = new System.Drawing.Font("Segoe UI", 9F);
            treeNodeAdvStyleInfo2.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo2.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo2.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdvStyleInfo2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.treeViewAdv3.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo2)});
            this.treeViewAdv3.BeforeTouchSize = new System.Drawing.Size(363, 446);
            this.treeViewAdv3.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.treeViewAdv3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            // 
            // 
            // 
            this.treeViewAdv3.HelpTextControl.BaseThemeName = null;
            this.treeViewAdv3.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv3.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv3.HelpTextControl.Name = "helpText";
            this.treeViewAdv3.HelpTextControl.Size = new System.Drawing.Size(49, 15);
            this.treeViewAdv3.HelpTextControl.TabIndex = 0;
            this.treeViewAdv3.HelpTextControl.Text = "help text";
            this.treeViewAdv3.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.treeViewAdv3.ItemHeight = 25;
            this.treeViewAdv3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.treeViewAdv3.Location = new System.Drawing.Point(1, 36);
            this.treeViewAdv3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.treeViewAdv3.Name = "treeViewAdv3";
            treeNodeAdv35.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv35.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv35.EnsureDefaultOptionedChild = true;
            treeNodeAdv35.Expanded = true;
            treeNodeAdv35.MultiLine = true;
            treeNodeAdv36.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv36.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv36.EnsureDefaultOptionedChild = true;
            treeNodeAdv36.MultiLine = true;
            treeNodeAdv36.Optioned = true;
            treeNodeAdv36.ShowLine = true;
            treeNodeAdv36.Text = "Inbox";
            treeNodeAdv37.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv37.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv37.EnsureDefaultOptionedChild = true;
            treeNodeAdv37.MultiLine = true;
            treeNodeAdv37.ShowLine = true;
            treeNodeAdv37.Text = "Drafts";
            treeNodeAdv38.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv38.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv38.EnsureDefaultOptionedChild = true;
            treeNodeAdv38.MultiLine = true;
            treeNodeAdv38.ShowLine = true;
            treeNodeAdv38.Text = "Sent Items";
            treeNodeAdv39.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv39.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv39.EnsureDefaultOptionedChild = true;
            treeNodeAdv39.MultiLine = true;
            treeNodeAdv39.ShowLine = true;
            treeNodeAdv39.Text = "Deleted Items";
            treeNodeAdv40.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv40.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv40.EnsureDefaultOptionedChild = true;
            treeNodeAdv40.MultiLine = true;
            treeNodeAdv40.ShowLine = true;
            treeNodeAdv40.Text = "Archive";
            treeNodeAdv41.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv41.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv41.EnsureDefaultOptionedChild = true;
            treeNodeAdv41.MultiLine = true;
            treeNodeAdv41.ShowLine = true;
            treeNodeAdv41.Text = "Calendar";
            treeNodeAdv42.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv42.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv42.EnsureDefaultOptionedChild = true;
            treeNodeAdv42.MultiLine = true;
            treeNodeAdv42.ShowLine = true;
            treeNodeAdv42.Text = "Contacts";
            treeNodeAdv43.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv43.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv43.EnsureDefaultOptionedChild = true;
            treeNodeAdv43.MultiLine = true;
            treeNodeAdv43.ShowLine = true;
            treeNodeAdv43.Text = "Conversation History";
            treeNodeAdv44.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv44.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv44.EnsureDefaultOptionedChild = true;
            treeNodeAdv44.MultiLine = true;
            treeNodeAdv44.ShowLine = true;
            treeNodeAdv44.Text = "Journal";
            treeNodeAdv45.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv45.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv45.EnsureDefaultOptionedChild = true;
            treeNodeAdv45.MultiLine = true;
            treeNodeAdv45.ShowLine = true;
            treeNodeAdv45.Text = "Junk Emails";
            treeNodeAdv46.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv46.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv46.EnsureDefaultOptionedChild = true;
            treeNodeAdv46.MultiLine = true;
            treeNodeAdv46.ShowLine = true;
            treeNodeAdv46.Text = "Nodes";
            treeNodeAdv47.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv47.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv47.EnsureDefaultOptionedChild = true;
            treeNodeAdv47.MultiLine = true;
            treeNodeAdv47.ShowLine = true;
            treeNodeAdv47.Text = "Outbox";
            treeNodeAdv48.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv48.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv48.EnsureDefaultOptionedChild = true;
            treeNodeAdv48.MultiLine = true;
            treeNodeAdv48.ShowLine = true;
            treeNodeAdv48.Text = "RSS Subcription";
            treeNodeAdv49.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv49.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv49.EnsureDefaultOptionedChild = true;
            treeNodeAdv49.MultiLine = true;
            treeNodeAdv49.ShowLine = true;
            treeNodeAdv49.Text = "Tasks";
            treeNodeAdv50.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv50.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv50.EnsureDefaultOptionedChild = true;
            treeNodeAdv50.MultiLine = true;
            treeNodeAdv50.ShowLine = true;
            treeNodeAdv50.Text = "Search Folders";
            treeNodeAdv35.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv36,
            treeNodeAdv37,
            treeNodeAdv38,
            treeNodeAdv39,
            treeNodeAdv40,
            treeNodeAdv41,
            treeNodeAdv42,
            treeNodeAdv43,
            treeNodeAdv44,
            treeNodeAdv45,
            treeNodeAdv46,
            treeNodeAdv47,
            treeNodeAdv48,
            treeNodeAdv49,
            treeNodeAdv50});
            treeNodeAdv35.ShowLine = true;
            treeNodeAdv35.Text = "Robert.Downey@outlook.com";
            treeNodeAdv51.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv51.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv51.EnsureDefaultOptionedChild = true;
            treeNodeAdv51.Expanded = true;
            treeNodeAdv51.MultiLine = true;
            treeNodeAdv52.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv52.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv52.EnsureDefaultOptionedChild = true;
            treeNodeAdv52.MultiLine = true;
            treeNodeAdv52.Optioned = true;
            treeNodeAdv52.ShowLine = true;
            treeNodeAdv52.Text = "Support Team";
            treeNodeAdv53.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv53.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv53.EnsureDefaultOptionedChild = true;
            treeNodeAdv53.MultiLine = true;
            treeNodeAdv53.ShowLine = true;
            treeNodeAdv53.Text = "Sales Team";
            treeNodeAdv51.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv52,
            treeNodeAdv53});
            treeNodeAdv51.ShowLine = true;
            treeNodeAdv51.Text = "Groups";
            treeNodeAdv54.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv54.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv54.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv54.EnsureDefaultOptionedChild = true;
            treeNodeAdv54.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv54.MultiLine = true;
            treeNodeAdv54.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv54.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv54.ShowLine = true;
            treeNodeAdv54.Text = "Favorite Group Calender";
            this.treeViewAdv3.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv35,
            treeNodeAdv51,
            treeNodeAdv54});
            this.treeViewAdv3.SelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220))))));
            this.treeViewAdv3.SelectedNodeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.treeViewAdv3.ShowFocusRect = false;
            this.treeViewAdv3.ShowLines = false;
            this.treeViewAdv3.Size = new System.Drawing.Size(363, 446);
            this.treeViewAdv3.Style = Syncfusion.Windows.Forms.Tools.TreeStyle.Metro;
            this.treeViewAdv3.TabIndex = 3;
            this.treeViewAdv3.Text = "treeViewAdv3";
            this.treeViewAdv3.ThemeName = "Metro";
            treeViewAdvVisualStyle2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            treeViewAdvVisualStyle2.TreeNodeAdvStyle.CheckBoxTickThickness = 0;
            treeViewAdvVisualStyle2.TreeNodeAdvStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeViewAdvVisualStyle2.TreeNodeAdvStyle.EnsureDefaultOptionedChild = true;
            treeViewAdvVisualStyle2.TreeNodeAdvStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeViewAdvVisualStyle2.TreeNodeAdvStyle.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeViewAdvVisualStyle2.TreeNodeAdvStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.treeViewAdv3.ThemeStyle = treeViewAdvVisualStyle2;
            // 
            // 
            // 
            this.treeViewAdv3.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.treeViewAdv3.ToolTipControl.BaseThemeName = null;
            this.treeViewAdv3.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv3.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv3.ToolTipControl.Name = "toolTip";
            this.treeViewAdv3.ToolTipControl.Size = new System.Drawing.Size(41, 15);
            this.treeViewAdv3.ToolTipControl.TabIndex = 1;
            this.treeViewAdv3.ToolTipControl.Text = "toolTip";
            this.treeViewAdv3.TransparentControls = true;
            // 
            // treeViewAdv4
            // 
            this.treeViewAdv4.BackColor = System.Drawing.Color.White;
            this.treeViewAdv4.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            treeNodeAdvStyleInfo1.CheckBoxTickThickness = 1;
            treeNodeAdvStyleInfo1.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.Font = new System.Drawing.Font("Segoe UI", 9F);
            treeNodeAdvStyleInfo1.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdvStyleInfo1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.treeViewAdv4.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this.treeViewAdv4.BeforeTouchSize = new System.Drawing.Size(363, 446);
            this.treeViewAdv4.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.treeViewAdv4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            // 
            // 
            // 
            this.treeViewAdv4.HelpTextControl.BaseThemeName = null;
            this.treeViewAdv4.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv4.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv4.HelpTextControl.Name = "helpText";
            this.treeViewAdv4.HelpTextControl.Size = new System.Drawing.Size(49, 15);
            this.treeViewAdv4.HelpTextControl.TabIndex = 0;
            this.treeViewAdv4.HelpTextControl.Text = "help text";
            this.treeViewAdv4.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.treeViewAdv4.ItemHeight = 25;
            this.treeViewAdv4.LeftImageList = this.imageList1;
            this.treeViewAdv4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.treeViewAdv4.Location = new System.Drawing.Point(1, 36);
            this.treeViewAdv4.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.treeViewAdv4.Name = "treeViewAdv4";
            treeNodeAdv1.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.Expanded = true;
            treeNodeAdv1.MultiLine = true;
            treeNodeAdv2.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv2.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.LeftImageIndices = new int[] {
        0};
            treeNodeAdv2.MultiLine = true;
            treeNodeAdv2.Optioned = true;
            treeNodeAdv2.ShowLine = true;
            treeNodeAdv2.Text = "Inbox [23] ";
            treeNodeAdv3.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv3.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.LeftImageIndices = new int[] {
        0};
            treeNodeAdv3.MultiLine = true;
            treeNodeAdv3.ShowLine = true;
            treeNodeAdv3.Text = "Drafts [3]";
            treeNodeAdv4.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv4.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.LeftImageIndices = new int[] {
        0};
            treeNodeAdv4.MultiLine = true;
            treeNodeAdv4.ShowLine = true;
            treeNodeAdv4.Text = "Sent Items [4]";
            treeNodeAdv5.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv5.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.LeftImageIndices = new int[] {
        0};
            treeNodeAdv5.MultiLine = true;
            treeNodeAdv5.ShowLine = true;
            treeNodeAdv5.Text = "Archive ";
            treeNodeAdv6.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv6.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.LeftImageIndices = new int[] {
        0};
            treeNodeAdv6.MultiLine = true;
            treeNodeAdv6.ShowLine = true;
            treeNodeAdv6.Text = "Outbox";
            treeNodeAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv2,
            treeNodeAdv3,
            treeNodeAdv4,
            treeNodeAdv5,
            treeNodeAdv6});
            treeNodeAdv1.ShowLine = true;
            treeNodeAdv1.Text = "Favorites";
            treeNodeAdv7.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv7.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.Expanded = true;
            treeNodeAdv7.MultiLine = true;
            treeNodeAdv8.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv8.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.Expanded = true;
            treeNodeAdv8.MultiLine = true;
            treeNodeAdv8.Optioned = true;
            treeNodeAdv8.ShowLine = true;
            treeNodeAdv8.Text = "Inbox [23] ";
            treeNodeAdv9.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv9.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.MultiLine = true;
            treeNodeAdv9.ShowLine = true;
            treeNodeAdv9.Text = "Drafts [3]";
            treeNodeAdv10.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv10.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv10.EnsureDefaultOptionedChild = true;
            treeNodeAdv10.MultiLine = true;
            treeNodeAdv10.ShowLine = true;
            treeNodeAdv10.Text = "Sent Items [4]";
            treeNodeAdv11.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv11.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv11.EnsureDefaultOptionedChild = true;
            treeNodeAdv11.MultiLine = true;
            treeNodeAdv11.ShowLine = true;
            treeNodeAdv11.Text = "Deleted Items";
            treeNodeAdv12.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv12.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv12.EnsureDefaultOptionedChild = true;
            treeNodeAdv12.Expanded = true;
            treeNodeAdv12.MultiLine = true;
            treeNodeAdv12.ShowLine = true;
            treeNodeAdv12.Text = "Archive";
            treeNodeAdv13.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv13.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv13.EnsureDefaultOptionedChild = true;
            treeNodeAdv13.MultiLine = true;
            treeNodeAdv14.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv14.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv14.EnsureDefaultOptionedChild = true;
            treeNodeAdv14.MultiLine = true;
            treeNodeAdv14.Optioned = true;
            treeNodeAdv14.ShowLine = true;
            treeNodeAdv14.Text = "My Calender";
            treeNodeAdv13.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv14});
            treeNodeAdv13.ShowLine = true;
            treeNodeAdv13.Text = "Calendar";
            treeNodeAdv15.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv15.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv15.EnsureDefaultOptionedChild = true;
            treeNodeAdv15.MultiLine = true;
            treeNodeAdv15.ShowLine = true;
            treeNodeAdv15.Text = "Contacts";
            treeNodeAdv16.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv16.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv16.EnsureDefaultOptionedChild = true;
            treeNodeAdv16.Expanded = true;
            treeNodeAdv16.MultiLine = true;
            treeNodeAdv16.ShowLine = true;
            treeNodeAdv16.Text = "Conversation History";
            treeNodeAdv17.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv17.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv17.EnsureDefaultOptionedChild = true;
            treeNodeAdv17.MultiLine = true;
            treeNodeAdv17.ShowLine = true;
            treeNodeAdv17.Text = "Journal";
            treeNodeAdv18.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv18.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv18.EnsureDefaultOptionedChild = true;
            treeNodeAdv18.Expanded = true;
            treeNodeAdv18.MultiLine = true;
            treeNodeAdv18.ShowLine = true;
            treeNodeAdv18.Text = "Junk Email";
            treeNodeAdv19.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv19.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv19.EnsureDefaultOptionedChild = true;
            treeNodeAdv19.MultiLine = true;
            treeNodeAdv19.ShowLine = true;
            treeNodeAdv19.Text = "Notes";
            treeNodeAdv20.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv20.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv20.EnsureDefaultOptionedChild = true;
            treeNodeAdv20.MultiLine = true;
            treeNodeAdv20.ShowLine = true;
            treeNodeAdv20.Text = "Outbox";
            treeNodeAdv21.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv21.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv21.EnsureDefaultOptionedChild = true;
            treeNodeAdv21.Expanded = true;
            treeNodeAdv21.MultiLine = true;
            treeNodeAdv21.ShowLine = true;
            treeNodeAdv21.Text = "RSS Subscriptions";
            treeNodeAdv22.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv22.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv22.EnsureDefaultOptionedChild = true;
            treeNodeAdv22.Expanded = true;
            treeNodeAdv22.MultiLine = true;
            treeNodeAdv23.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv23.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv23.EnsureDefaultOptionedChild = true;
            treeNodeAdv23.MultiLine = true;
            treeNodeAdv23.ShowLine = true;
            treeNodeAdv23.Text = "Missed Calls";
            treeNodeAdv24.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv24.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv24.EnsureDefaultOptionedChild = true;
            treeNodeAdv24.MultiLine = true;
            treeNodeAdv24.ShowLine = true;
            treeNodeAdv24.Text = "Missed Conversations";
            treeNodeAdv25.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv25.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv25.EnsureDefaultOptionedChild = true;
            treeNodeAdv25.MultiLine = true;
            treeNodeAdv25.ShowLine = true;
            treeNodeAdv25.Text = "Voice Mail";
            treeNodeAdv22.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv23,
            treeNodeAdv24,
            treeNodeAdv25});
            treeNodeAdv22.ShowLine = true;
            treeNodeAdv22.Text = "Search Folders";
            treeNodeAdv7.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv8,
            treeNodeAdv9,
            treeNodeAdv10,
            treeNodeAdv11,
            treeNodeAdv12,
            treeNodeAdv13,
            treeNodeAdv15,
            treeNodeAdv16,
            treeNodeAdv17,
            treeNodeAdv18,
            treeNodeAdv19,
            treeNodeAdv20,
            treeNodeAdv21,
            treeNodeAdv22});
            treeNodeAdv7.ShowLine = true;
            treeNodeAdv7.Text = "Robert.Downey@outlook.com";
            treeNodeAdv26.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv26.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv26.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv26.EnsureDefaultOptionedChild = true;
            treeNodeAdv26.Expanded = true;
            treeNodeAdv26.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv26.MultiLine = true;
            treeNodeAdv27.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv27.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv27.EnsureDefaultOptionedChild = true;
            treeNodeAdv27.Expanded = true;
            treeNodeAdv27.MultiLine = true;
            treeNodeAdv27.ShowLine = true;
            treeNodeAdv27.Text = "Sales Team";
            treeNodeAdv28.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv28.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv28.EnsureDefaultOptionedChild = true;
            treeNodeAdv28.MultiLine = true;
            treeNodeAdv28.ShowLine = true;
            treeNodeAdv28.Text = "Support Team";
            treeNodeAdv26.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv27,
            treeNodeAdv28});
            treeNodeAdv26.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv26.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv26.ShowLine = true;
            treeNodeAdv26.Text = "Groups";
            treeNodeAdv29.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv29.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv29.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv29.EnsureDefaultOptionedChild = true;
            treeNodeAdv29.Expanded = true;
            treeNodeAdv29.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv29.MultiLine = true;
            treeNodeAdv30.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv30.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv30.EnsureDefaultOptionedChild = true;
            treeNodeAdv30.MultiLine = true;
            treeNodeAdv30.ShowLine = true;
            treeNodeAdv30.Text = "My Calendar";
            treeNodeAdv31.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv31.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv31.EnsureDefaultOptionedChild = true;
            treeNodeAdv31.MultiLine = true;
            treeNodeAdv31.ShowLine = true;
            treeNodeAdv31.Text = "Birthdays";
            treeNodeAdv32.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv32.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv32.EnsureDefaultOptionedChild = true;
            treeNodeAdv32.MultiLine = true;
            treeNodeAdv32.ShowLine = true;
            treeNodeAdv32.Text = "Holidays";
            treeNodeAdv29.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv30,
            treeNodeAdv31,
            treeNodeAdv32});
            treeNodeAdv29.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv29.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv29.ShowLine = true;
            treeNodeAdv29.Text = "Favorite Group Calendars";
            treeNodeAdv33.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv33.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv33.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv33.EnsureDefaultOptionedChild = true;
            treeNodeAdv33.Expanded = true;
            treeNodeAdv33.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv33.MultiLine = true;
            treeNodeAdv34.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv34.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv34.EnsureDefaultOptionedChild = true;
            treeNodeAdv34.Expanded = true;
            treeNodeAdv34.MultiLine = true;
            treeNodeAdv34.ShowLine = true;
            treeNodeAdv34.Text = "All Public Folders";
            treeNodeAdv33.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv34});
            treeNodeAdv33.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv33.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv33.ShowLine = true;
            treeNodeAdv33.Text = "Public Folders";
            this.treeViewAdv4.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv1,
            treeNodeAdv7,
            treeNodeAdv26,
            treeNodeAdv29,
            treeNodeAdv33});
            this.treeViewAdv4.SelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220))))));
            this.treeViewAdv4.SelectedNodeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.treeViewAdv4.ShowFocusRect = false;
            this.treeViewAdv4.ShowLines = false;
            this.treeViewAdv4.Size = new System.Drawing.Size(363, 446);
            this.treeViewAdv4.Style = Syncfusion.Windows.Forms.Tools.TreeStyle.Metro;
            this.treeViewAdv4.TabIndex = 4;
            this.treeViewAdv4.Text = "treeViewAdv4";
            this.treeViewAdv4.ThemeName = "Metro";
            treeViewAdvVisualStyle1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            treeViewAdvVisualStyle1.TreeNodeAdvStyle.CheckBoxTickThickness = 0;
            treeViewAdvVisualStyle1.TreeNodeAdvStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeViewAdvVisualStyle1.TreeNodeAdvStyle.EnsureDefaultOptionedChild = true;
            treeViewAdvVisualStyle1.TreeNodeAdvStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeViewAdvVisualStyle1.TreeNodeAdvStyle.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeViewAdvVisualStyle1.TreeNodeAdvStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.treeViewAdv4.ThemeStyle = treeViewAdvVisualStyle1;
            // 
            // 
            // 
            this.treeViewAdv4.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.treeViewAdv4.ToolTipControl.BaseThemeName = null;
            this.treeViewAdv4.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv4.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv4.ToolTipControl.Name = "toolTip";
            this.treeViewAdv4.ToolTipControl.Size = new System.Drawing.Size(41, 15);
            this.treeViewAdv4.ToolTipControl.TabIndex = 1;
            this.treeViewAdv4.ToolTipControl.Text = "toolTip";
            this.treeViewAdv4.TransparentControls = true;
            // 
            // treeViewAdv5
            // 
            this.treeViewAdv5.BackColor = System.Drawing.Color.White;
            this.treeViewAdv5.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            treeNodeAdvStyleInfo5.CheckBoxTickThickness = 1;
            treeNodeAdvStyleInfo5.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo5.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo5.Font = new System.Drawing.Font("Segoe UI", 9F);
            treeNodeAdvStyleInfo5.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo5.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo5.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdvStyleInfo5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.treeViewAdv5.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo5)});
            this.treeViewAdv5.BeforeTouchSize = new System.Drawing.Size(363, 566);
            this.treeViewAdv5.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.treeViewAdv5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            // 
            // 
            // 
            this.treeViewAdv5.HelpTextControl.BaseThemeName = null;
            this.treeViewAdv5.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv5.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv5.HelpTextControl.Name = "helpText";
            this.treeViewAdv5.HelpTextControl.Size = new System.Drawing.Size(49, 15);
            this.treeViewAdv5.HelpTextControl.TabIndex = 0;
            this.treeViewAdv5.HelpTextControl.Text = "help text";
            this.treeViewAdv5.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.treeViewAdv5.ItemHeight = 25;
            this.treeViewAdv5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.treeViewAdv5.Location = new System.Drawing.Point(1, 36);
            this.treeViewAdv5.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.treeViewAdv5.Name = "treeViewAdv5";
            treeNodeAdv60.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv60.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv60.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv60.EnsureDefaultOptionedChild = true;
            treeNodeAdv60.Expanded = true;
            treeNodeAdv60.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv60.MultiLine = true;
            treeNodeAdv61.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv61.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv61.EnsureDefaultOptionedChild = true;
            treeNodeAdv61.MultiLine = true;
            treeNodeAdv61.Optioned = true;
            treeNodeAdv61.ShowLine = true;
            treeNodeAdv61.Text = "Contacts";
            treeNodeAdv60.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv61});
            treeNodeAdv60.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv60.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv60.ShowLine = true;
            treeNodeAdv60.Text = "My Contact";
            this.treeViewAdv5.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv60});
            this.treeViewAdv5.SelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220))))));
            this.treeViewAdv5.SelectedNodeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.treeViewAdv5.ShowFocusRect = false;
            this.treeViewAdv5.ShowLines = false;
            this.treeViewAdv5.Size = new System.Drawing.Size(363, 566);
            this.treeViewAdv5.Style = Syncfusion.Windows.Forms.Tools.TreeStyle.Metro;
            this.treeViewAdv5.TabIndex = 5;
            this.treeViewAdv5.Text = "treeViewAdv5";
            this.treeViewAdv5.ThemeName = "Metro";
            treeViewAdvVisualStyle5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            treeViewAdvVisualStyle5.TreeNodeAdvStyle.CheckBoxTickThickness = 0;
            treeViewAdvVisualStyle5.TreeNodeAdvStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeViewAdvVisualStyle5.TreeNodeAdvStyle.EnsureDefaultOptionedChild = true;
            treeViewAdvVisualStyle5.TreeNodeAdvStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeViewAdvVisualStyle5.TreeNodeAdvStyle.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeViewAdvVisualStyle5.TreeNodeAdvStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.treeViewAdv5.ThemeStyle = treeViewAdvVisualStyle5;
            // 
            // 
            // 
            this.treeViewAdv5.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.treeViewAdv5.ToolTipControl.BaseThemeName = null;
            this.treeViewAdv5.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv5.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv5.ToolTipControl.Name = "toolTip";
            this.treeViewAdv5.ToolTipControl.Size = new System.Drawing.Size(41, 15);
            this.treeViewAdv5.ToolTipControl.TabIndex = 1;
            this.treeViewAdv5.ToolTipControl.Text = "toolTip";
            this.treeViewAdv5.TransparentControls = true;
            // 
            // treeViewAdv2
            // 
            this.treeViewAdv2.BackColor = System.Drawing.Color.White;
            this.treeViewAdv2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            treeNodeAdvStyleInfo4.CheckBoxTickThickness = 1;
            treeNodeAdvStyleInfo4.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo4.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo4.Font = new System.Drawing.Font("Segoe UI", 9F);
            treeNodeAdvStyleInfo4.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo4.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo4.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdvStyleInfo4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.treeViewAdv2.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo4)});
            this.treeViewAdv2.BeforeTouchSize = new System.Drawing.Size(363, 526);
            this.treeViewAdv2.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.treeViewAdv2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.treeViewAdv2.FullRowSelect = true;
            // 
            // 
            // 
            this.treeViewAdv2.HelpTextControl.BaseThemeName = null;
            this.treeViewAdv2.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv2.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv2.HelpTextControl.Name = "helpText";
            this.treeViewAdv2.HelpTextControl.Size = new System.Drawing.Size(49, 15);
            this.treeViewAdv2.HelpTextControl.TabIndex = 0;
            this.treeViewAdv2.HelpTextControl.Text = "help text";
            this.treeViewAdv2.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.treeViewAdv2.ItemHeight = 25;
            this.treeViewAdv2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.treeViewAdv2.Location = new System.Drawing.Point(1, 36);
            this.treeViewAdv2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.treeViewAdv2.Name = "treeViewAdv2";
            treeNodeAdv58.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv58.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv58.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv58.EnsureDefaultOptionedChild = true;
            treeNodeAdv58.Expanded = true;
            treeNodeAdv58.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv58.MultiLine = true;
            treeNodeAdv59.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv59.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv59.EnsureDefaultOptionedChild = true;
            treeNodeAdv59.MultiLine = true;
            treeNodeAdv59.Optioned = true;
            treeNodeAdv59.ShowLine = true;
            treeNodeAdv59.Text = "Notes";
            treeNodeAdv58.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv59});
            treeNodeAdv58.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv58.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv58.ShowLine = true;
            treeNodeAdv58.Text = "My Notes";
            this.treeViewAdv2.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv58});
            this.treeViewAdv2.SelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220))))));
            this.treeViewAdv2.SelectedNodeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.treeViewAdv2.ShowFocusRect = false;
            this.treeViewAdv2.ShowLines = false;
            this.treeViewAdv2.Size = new System.Drawing.Size(363, 526);
            this.treeViewAdv2.Style = Syncfusion.Windows.Forms.Tools.TreeStyle.Metro;
            this.treeViewAdv2.TabIndex = 2;
            this.treeViewAdv2.Text = "treeViewAdv2";
            this.treeViewAdv2.ThemeName = "Metro";
            treeViewAdvVisualStyle4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            treeViewAdvVisualStyle4.TreeNodeAdvStyle.CheckBoxTickThickness = 0;
            treeViewAdvVisualStyle4.TreeNodeAdvStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeViewAdvVisualStyle4.TreeNodeAdvStyle.EnsureDefaultOptionedChild = true;
            treeViewAdvVisualStyle4.TreeNodeAdvStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeViewAdvVisualStyle4.TreeNodeAdvStyle.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeViewAdvVisualStyle4.TreeNodeAdvStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.treeViewAdv2.ThemeStyle = treeViewAdvVisualStyle4;
            // 
            // 
            // 
            this.treeViewAdv2.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.treeViewAdv2.ToolTipControl.BaseThemeName = null;
            this.treeViewAdv2.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv2.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv2.ToolTipControl.Name = "toolTip";
            this.treeViewAdv2.ToolTipControl.Size = new System.Drawing.Size(41, 15);
            this.treeViewAdv2.ToolTipControl.TabIndex = 1;
            this.treeViewAdv2.ToolTipControl.Text = "toolTip";
            this.treeViewAdv2.TransparentControls = true;
            // 
            // treeViewAdv1
            // 
            this.treeViewAdv1.BackColor = System.Drawing.Color.White;
            this.treeViewAdv1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            treeNodeAdvStyleInfo3.CheckBoxTickThickness = 1;
            treeNodeAdvStyleInfo3.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo3.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo3.Font = new System.Drawing.Font("Segoe UI", 9F);
            treeNodeAdvStyleInfo3.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo3.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo3.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdvStyleInfo3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.treeViewAdv1.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo3)});
            this.treeViewAdv1.BeforeTouchSize = new System.Drawing.Size(363, 486);
            this.treeViewAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.treeViewAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            // 
            // 
            // 
            this.treeViewAdv1.HelpTextControl.BaseThemeName = null;
            this.treeViewAdv1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv1.HelpTextControl.Name = "helpText";
            this.treeViewAdv1.HelpTextControl.Size = new System.Drawing.Size(49, 15);
            this.treeViewAdv1.HelpTextControl.TabIndex = 0;
            this.treeViewAdv1.HelpTextControl.Text = "help text";
            this.treeViewAdv1.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.treeViewAdv1.ItemHeight = 25;
            this.treeViewAdv1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.treeViewAdv1.Location = new System.Drawing.Point(1, 36);
            this.treeViewAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.treeViewAdv1.Name = "treeViewAdv1";
            treeNodeAdv55.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv55.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv55.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv55.EnsureDefaultOptionedChild = true;
            treeNodeAdv55.Expanded = true;
            treeNodeAdv55.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv55.MultiLine = true;
            treeNodeAdv56.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv56.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv56.EnsureDefaultOptionedChild = true;
            treeNodeAdv56.Expanded = true;
            treeNodeAdv56.MultiLine = true;
            treeNodeAdv56.Optioned = true;
            treeNodeAdv56.ShowLine = true;
            treeNodeAdv56.Text = "To-Do List";
            treeNodeAdv57.ChildStyle.CheckBoxTickThickness = 0;
            treeNodeAdv57.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv57.EnsureDefaultOptionedChild = true;
            treeNodeAdv57.MultiLine = true;
            treeNodeAdv57.ShowLine = true;
            treeNodeAdv57.Text = "Tasks";
            treeNodeAdv55.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv56,
            treeNodeAdv57});
            treeNodeAdv55.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv55.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv55.ShowLine = true;
            treeNodeAdv55.Text = "My Tasks";
            this.treeViewAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv55});
            this.treeViewAdv1.SelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220))))));
            this.treeViewAdv1.SelectedNodeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.treeViewAdv1.ShowFocusRect = false;
            this.treeViewAdv1.ShowLines = false;
            this.treeViewAdv1.Size = new System.Drawing.Size(363, 486);
            this.treeViewAdv1.Style = Syncfusion.Windows.Forms.Tools.TreeStyle.Metro;
            this.treeViewAdv1.TabIndex = 1;
            this.treeViewAdv1.Text = "treeViewAdv1";
            this.treeViewAdv1.ThemeName = "Metro";
            treeViewAdvVisualStyle3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            treeViewAdvVisualStyle3.TreeNodeAdvStyle.CheckBoxTickThickness = 0;
            treeViewAdvVisualStyle3.TreeNodeAdvStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeViewAdvVisualStyle3.TreeNodeAdvStyle.EnsureDefaultOptionedChild = true;
            treeViewAdvVisualStyle3.TreeNodeAdvStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeViewAdvVisualStyle3.TreeNodeAdvStyle.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeViewAdvVisualStyle3.TreeNodeAdvStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.treeViewAdv1.ThemeStyle = treeViewAdvVisualStyle3;
            // 
            // 
            // 
            this.treeViewAdv1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.treeViewAdv1.ToolTipControl.BaseThemeName = null;
            this.treeViewAdv1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv1.ToolTipControl.Name = "toolTip";
            this.treeViewAdv1.ToolTipControl.Size = new System.Drawing.Size(41, 15);
            this.treeViewAdv1.ToolTipControl.TabIndex = 1;
            this.treeViewAdv1.ToolTipControl.Text = "toolTip";
            this.treeViewAdv1.TransparentControls = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.monthCalendar1);
            this.panel2.Location = new System.Drawing.Point(1, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 606);
            this.panel2.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Culture = new System.Globalization.CultureInfo("en-US");
            this.monthCalendar1.Location = new System.Drawing.Point(18, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.Size = new System.Drawing.Size(294, 289);
            this.monthCalendar1.TabIndex = 5;
            // 
            // Mail
            // 
            this.Mail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Mail.Client = this.treeViewAdv4;
            this.Mail.InNavigationPane = true;
            this.Mail.LargeImageMode = true;
            this.Mail.Text = "      Mail";
            // 
            // Calendar
            // 
            this.Calendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Calendar.Client = this.panel2;
            this.Calendar.InNavigationPane = true;
            this.Calendar.LargeImageMode = true;
            this.Calendar.Text = "Calendar";
            // 
            // Favorites
            // 
            this.Favorites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Favorites.Client = this.treeViewAdv5;
            this.Favorites.InNavigationPane = true;
            this.Favorites.LargeImageMode = true;
            this.Favorites.Text = "Favorites";
            // 
            // Notes
            // 
            this.Notes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Notes.Client = this.treeViewAdv2;
            this.Notes.InNavigationPane = true;
            this.Notes.LargeImageMode = true;
            this.Notes.Text = "    Notes";
            // 
            // Tasks
            // 
            this.Tasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Tasks.Client = this.treeViewAdv1;
            this.Tasks.InNavigationPane = true;
            this.Tasks.LargeImageMode = true;
            this.Tasks.Text = "   Tasks";
            // 
            // Folders
            // 
            this.Folders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Folders.Client = this.treeViewAdv3;
            this.Folders.InNavigationPane = true;
            this.Folders.LargeImageMode = true;
            this.Folders.Text = "Folders";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(386, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 531);
            this.panel1.TabIndex = 201;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 551);
            this.Controls.Add(this.panel15);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(540, 545);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customization";
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCollapse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChevron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPopupResize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAllowCollapse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAutoClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCollapsedWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbShowGripper)).EndInit();
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).EndInit();
            this.groupBar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.TreeViewAdv treeViewAdv4;
        private Syncfusion.Windows.Forms.Tools.TreeViewAdv treeViewAdv3;
        private Syncfusion.Windows.Forms.Tools.TreeViewAdv treeViewAdv2;
        private Syncfusion.Windows.Forms.Tools.TreeViewAdv treeViewAdv1;
        private Syncfusion.Windows.Forms.Tools.TreeViewAdv treeViewAdv5;
        private Syncfusion.Windows.Forms.Tools.GroupBar groupBar1;
        private System.Windows.Forms.Panel panel2;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem Favorites;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem Mail;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem Calendar;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem Tasks;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem Notes;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem Folders;
        private System.Windows.Forms.ImageList imageList1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbAllowCollapse;
        private SfComboBox cmbPopupResize;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericCollapsedWidth;
        private System.Windows.Forms.Label label18;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbAutoClose;
        private System.Windows.Forms.Label label15;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbShowGripper;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbCollapse;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbChevron;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem1;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem2;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem3;
        private System.Windows.Forms.Panel panel15;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private SfCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel1;
    }
}

