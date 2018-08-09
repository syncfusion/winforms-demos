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
using Syncfusion.Licensing;
using System.IO;

namespace SplitContainerAdv
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : MetroForm
    {
        private Syncfusion.Windows.Forms.Tools.SplitContainerAdv splitContainerAdv1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox2;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox3;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDown1;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.SplitContainerAdv splitContainerAdv2;
        private Label label4;
        private ComboBoxAdv comboBox2;
        private Syncfusion.Windows.Forms.Tools.TreeViewAdv treeViewAdv1;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel panel2;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv1;
        private GroupBox groupBox1;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv2;
        private Label label6;
        private ToolTip toolTip1;
        private ImageList imageList1;
        private Label label9;
        private IContainer components;

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


            
            this.comboBox2.SelectedIndex = 0;
            this.comboBox2.SelectedIndexChanged += new EventHandler(comboBox2_SelectedIndexChanged);
            

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

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.treeViewAdv1 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.label9 = new System.Windows.Forms.Label();
            this.splitContainerAdv2 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.panel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonAdv2 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonAdv1 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.comboBox2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.checkBox3 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv2)).BeginInit();
            this.splitContainerAdv2.Panel1.SuspendLayout();
            this.splitContainerAdv2.Panel2.SuspendLayout();
            this.splitContainerAdv2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.BackColor = System.Drawing.Color.White;
            this.splitContainerAdv1.BeforeTouchSize = 7;
            this.splitContainerAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAdv1.FixedPanel = Syncfusion.Windows.Forms.Tools.Enums.FixedPanel.Panel1;
            this.splitContainerAdv1.Location = new System.Drawing.Point(10, 10);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainerAdv1.Panel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            this.splitContainerAdv1.Panel1.Controls.Add(this.treeViewAdv1);
            this.splitContainerAdv1.Panel1.Controls.Add(this.label9);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))));
            this.splitContainerAdv1.Panel2.Controls.Add(this.splitContainerAdv2);
            this.splitContainerAdv1.PanelToBeCollapsed = Syncfusion.Windows.Forms.Tools.Enums.CollapsedPanel.Panel1;
            this.splitContainerAdv1.Size = new System.Drawing.Size(801, 521);
            this.splitContainerAdv1.SplitterDistance = 211;
            this.splitContainerAdv1.TabIndex = 0;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            this.splitContainerAdv1.SplitterMoved += new Syncfusion.Windows.Forms.Tools.Events.SplitterMoveEventHandler(this.splitContainerAdv1_SplitterMoved);
            // 
            // treeViewAdv1
            // 
            this.treeViewAdv1.AllowDrop = true;
            this.treeViewAdv1.BackColor = System.Drawing.Color.White;
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdvStyleInfo1.NoChildrenImgIndex = -1;
            this.treeViewAdv1.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this.treeViewAdv1.BeforeTouchSize = new System.Drawing.Size(209, 488);
            this.treeViewAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.treeViewAdv1.BorderColor = System.Drawing.Color.DarkGray;
            this.treeViewAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.treeViewAdv1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.HelpTextControl.Location = new System.Drawing.Point(732, 0);
            this.treeViewAdv1.HelpTextControl.Name = "helpText";
            this.treeViewAdv1.HelpTextControl.Size = new System.Drawing.Size(49, 15);
            this.treeViewAdv1.HelpTextControl.TabIndex = 0;
            this.treeViewAdv1.HelpTextControl.Text = "help text";
            this.treeViewAdv1.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.treeViewAdv1.Location = new System.Drawing.Point(0, 31);
            this.treeViewAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.treeViewAdv1.Name = "treeViewAdv1";
            this.treeViewAdv1.NoChildrenImgIndex = -1;
            treeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.Expanded = true;
            treeNodeAdv1.MultiLine = true;
            treeNodeAdv2.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.MultiLine = true;
            treeNodeAdv2.Optioned = true;
            treeNodeAdv2.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv2.ShowLine = true;
            treeNodeAdv2.ShowOptionButton = false;
            treeNodeAdv2.Text = "India";
            treeNodeAdv3.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.MultiLine = true;
            treeNodeAdv3.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv3.ShowLine = true;
            treeNodeAdv3.ShowOptionButton = false;
            treeNodeAdv3.Text = "China";
            treeNodeAdv4.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.MultiLine = true;
            treeNodeAdv4.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv4.ShowLine = true;
            treeNodeAdv4.ShowOptionButton = false;
            treeNodeAdv4.Text = "Pakistan";
            treeNodeAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv2,
            treeNodeAdv3,
            treeNodeAdv4});
            treeNodeAdv1.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv1.ShowLine = true;
            treeNodeAdv1.Text = "Asia";
            treeNodeAdv5.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.Expanded = true;
            treeNodeAdv5.MultiLine = true;
            treeNodeAdv6.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.MultiLine = true;
            treeNodeAdv6.Optioned = true;
            treeNodeAdv6.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv6.ShowLine = true;
            treeNodeAdv6.Text = "Canada";
            treeNodeAdv7.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.MultiLine = true;
            treeNodeAdv7.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv7.ShowLine = true;
            treeNodeAdv7.Text = "USA";
            treeNodeAdv8.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.MultiLine = true;
            treeNodeAdv8.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv8.ShowLine = true;
            treeNodeAdv8.Text = "Mexico";
            treeNodeAdv9.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.MultiLine = true;
            treeNodeAdv9.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv9.ShowLine = true;
            treeNodeAdv9.Text = "Cuba";
            treeNodeAdv5.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv6,
            treeNodeAdv7,
            treeNodeAdv8,
            treeNodeAdv9});
            treeNodeAdv5.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv5.ShowLine = true;
            treeNodeAdv5.Text = "NorthAmerica";
            treeNodeAdv10.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv10.EnsureDefaultOptionedChild = true;
            treeNodeAdv10.Expanded = true;
            treeNodeAdv10.MultiLine = true;
            treeNodeAdv11.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv11.EnsureDefaultOptionedChild = true;
            treeNodeAdv11.MultiLine = true;
            treeNodeAdv11.Optioned = true;
            treeNodeAdv11.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv11.ShowLine = true;
            treeNodeAdv11.Text = "Egypt";
            treeNodeAdv12.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv12.EnsureDefaultOptionedChild = true;
            treeNodeAdv12.MultiLine = true;
            treeNodeAdv12.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv12.ShowLine = true;
            treeNodeAdv12.Text = "Nigeria";
            treeNodeAdv13.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv13.EnsureDefaultOptionedChild = true;
            treeNodeAdv13.MultiLine = true;
            treeNodeAdv13.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv13.ShowLine = true;
            treeNodeAdv13.Text = "Kenya";
            treeNodeAdv14.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv14.EnsureDefaultOptionedChild = true;
            treeNodeAdv14.MultiLine = true;
            treeNodeAdv14.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv14.ShowLine = true;
            treeNodeAdv14.Text = "Sudan";
            treeNodeAdv10.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv11,
            treeNodeAdv12,
            treeNodeAdv13,
            treeNodeAdv14});
            treeNodeAdv10.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv10.ShowLine = true;
            treeNodeAdv10.Text = "Africa";
            treeNodeAdv15.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv15.EnsureDefaultOptionedChild = true;
            treeNodeAdv15.Expanded = true;
            treeNodeAdv15.MultiLine = true;
            treeNodeAdv16.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv16.EnsureDefaultOptionedChild = true;
            treeNodeAdv16.MultiLine = true;
            treeNodeAdv16.Optioned = true;
            treeNodeAdv16.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv16.ShowLine = true;
            treeNodeAdv16.Text = "Spain";
            treeNodeAdv17.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv17.EnsureDefaultOptionedChild = true;
            treeNodeAdv17.MultiLine = true;
            treeNodeAdv17.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv17.ShowLine = true;
            treeNodeAdv17.Text = "Italy";
            treeNodeAdv18.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv18.EnsureDefaultOptionedChild = true;
            treeNodeAdv18.MultiLine = true;
            treeNodeAdv18.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv18.ShowLine = true;
            treeNodeAdv18.Text = "France";
            treeNodeAdv19.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv19.EnsureDefaultOptionedChild = true;
            treeNodeAdv19.MultiLine = true;
            treeNodeAdv19.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv19.ShowLine = true;
            treeNodeAdv19.Text = "Poland";
            treeNodeAdv15.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv16,
            treeNodeAdv17,
            treeNodeAdv18,
            treeNodeAdv19});
            treeNodeAdv15.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv15.ShowLine = true;
            treeNodeAdv15.Text = "Europe";
            this.treeViewAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv1,
            treeNodeAdv5,
            treeNodeAdv10,
            treeNodeAdv15});
            this.treeViewAdv1.PathSeparator = "/";
            this.treeViewAdv1.SelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))));
            this.treeViewAdv1.SelectedNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this.treeViewAdv1.ShowFocusRect = false;
            this.treeViewAdv1.Size = new System.Drawing.Size(209, 488);
            this.treeViewAdv1.Style = Syncfusion.Windows.Forms.Tools.TreeStyle.Metro;
            this.treeViewAdv1.TabIndex = 1;
            this.treeViewAdv1.Text = "treeViewAdv1";
            // 
            // 
            // 
            this.treeViewAdv1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.treeViewAdv1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.ToolTipControl.Location = new System.Drawing.Point(642, 0);
            this.treeViewAdv1.ToolTipControl.Name = "toolTip";
            this.treeViewAdv1.ToolTipControl.Size = new System.Drawing.Size(41, 15);
            this.treeViewAdv1.ToolTipControl.TabIndex = 1;
            this.treeViewAdv1.ToolTipControl.Text = "toolTip";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sample Treeview with nodes";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // splitContainerAdv2
            // 
            this.splitContainerAdv2.BeforeTouchSize = 7;
            this.splitContainerAdv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAdv2.FixedPanel = Syncfusion.Windows.Forms.Tools.Enums.FixedPanel.Panel1;
            this.splitContainerAdv2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAdv2.Name = "splitContainerAdv2";
            this.splitContainerAdv2.Orientation = System.Windows.Forms.Orientation.Vertical;
            // 
            // splitContainerAdv2.Panel1
            // 
            this.splitContainerAdv2.Panel1.Controls.Add(this.gradientLabel1);
            // 
            // splitContainerAdv2.Panel2
            // 
            this.splitContainerAdv2.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainerAdv2.Panel2.Controls.Add(this.panel2);
            this.splitContainerAdv2.PanelToBeCollapsed = Syncfusion.Windows.Forms.Tools.Enums.CollapsedPanel.Panel1;
            this.splitContainerAdv2.Size = new System.Drawing.Size(581, 519);
            this.splitContainerAdv2.SplitterDistance = 245;
            this.splitContainerAdv2.TabIndex = 0;
            this.splitContainerAdv2.Text = "splitContainerAdv2";
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.gradientLabel1.BeforeTouchSize = new System.Drawing.Size(581, 245);
            this.gradientLabel1.BorderColor = System.Drawing.Color.Transparent;
            this.gradientLabel1.BorderSides = System.Windows.Forms.Border3DSide.Middle;
            this.gradientLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel1.Location = new System.Drawing.Point(0, 0);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(581, 245);
            this.gradientLabel1.TabIndex = 0;
            this.gradientLabel1.Text = resources.GetString("gradientLabel1.Text");
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.panel2.BorderColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.checkBox3);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.numericUpDown2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Location = new System.Drawing.Point(108, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 206);
            this.panel2.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.radioButtonAdv2);
            this.groupBox1.Controls.Add(this.radioButtonAdv1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(198, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 73);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toggle Panel On";
            // 
            // radioButtonAdv2
            // 
            this.radioButtonAdv2.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.radioButtonAdv2.DrawFocusRectangle = false;
            this.radioButtonAdv2.Location = new System.Drawing.Point(6, 43);
            this.radioButtonAdv2.MetroColor = System.Drawing.Color.Gray;
            this.radioButtonAdv2.Name = "radioButtonAdv2";
            this.radioButtonAdv2.Size = new System.Drawing.Size(100, 27);
            this.radioButtonAdv2.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv2.TabIndex = 7;
            this.radioButtonAdv2.TabStop = false;
            this.radioButtonAdv2.Text = "Double Click";
            this.radioButtonAdv2.ThemesEnabled = true;
            // 
            // radioButtonAdv1
            // 
            this.radioButtonAdv1.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.radioButtonAdv1.Checked = true;
            this.radioButtonAdv1.DrawFocusRectangle = false;
            this.radioButtonAdv1.Location = new System.Drawing.Point(6, 20);
            this.radioButtonAdv1.MetroColor = System.Drawing.Color.Gray;
            this.radioButtonAdv1.Name = "radioButtonAdv1";
            this.radioButtonAdv1.Size = new System.Drawing.Size(100, 27);
            this.radioButtonAdv1.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv1.TabIndex = 6;
            this.radioButtonAdv1.Text = "Click";
            this.radioButtonAdv1.ThemesEnabled = true;
            this.radioButtonAdv1.CheckChanged += new System.EventHandler(this.radioButtonAdv1_CheckChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = "Properties";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(16, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Style";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoHeight = true;
            this.checkBox1.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox1.DrawFocusRectangle = false;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(9, 147);
            this.checkBox1.MetroColor = System.Drawing.Color.Gray;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 20);
            this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "IsSplitter Fixed";
            this.checkBox1.ThemesEnabled = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.BeforeTouchSize = new System.Drawing.Size(104, 21);
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.Items.AddRange(new object[] {
            "None"});
            this.comboBox2.Location = new System.Drawing.Point(66, 46);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(104, 21);
            this.comboBox2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox2.TabIndex = 15;
            this.comboBox2.Text = "None";
            this.comboBox2.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoHeight = true;
            this.checkBox3.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox3.DrawFocusRectangle = false;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(9, 112);
            this.checkBox3.MetroColor = System.Drawing.Color.Gray;
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(183, 20);
            this.checkBox3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "Panel2 Collapsed";
            this.checkBox3.ThemesEnabled = true;
            this.checkBox3.CheckStateChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoHeight = true;
            this.checkBox2.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox2.DrawFocusRectangle = false;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(9, 77);
            this.checkBox2.MetroColor = System.Drawing.Color.Gray;
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(183, 20);
            this.checkBox2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Panel1 Collapsed";
            this.checkBox2.ThemesEnabled = true;
            this.checkBox2.CheckStateChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Splitter Distance";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.White;
            this.numericUpDown2.BeforeTouchSize = new System.Drawing.Size(104, 22);
            this.numericUpDown2.BorderColor = System.Drawing.Color.Silver;
            this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(295, 72);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown2.MetroColor = System.Drawing.Color.Silver;
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(104, 22);
            this.numericUpDown2.TabIndex = 7;
            this.numericUpDown2.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown2.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Splitter Width";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.White;
            this.numericUpDown1.BeforeTouchSize = new System.Drawing.Size(104, 22);
            this.numericUpDown1.BorderColor = System.Drawing.Color.Silver;
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(295, 42);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDown1.MetroColor = System.Drawing.Color.Silver;
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(104, 22);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            191,
            0,
            0,
            0});
            this.numericUpDown1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(821, 541);
            this.Controls.Add(this.splitContainerAdv1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(833, 577);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Split ContainerAdv";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).EndInit();
            this.splitContainerAdv2.Panel1.ResumeLayout(false);
            this.splitContainerAdv2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv2)).EndInit();
            this.splitContainerAdv2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            if(this.comboBox2.SelectedText == "Office2016Colorful")
            {
                this.treeViewAdv1.ForeColor = Color.Black;
            }

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

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.comboBox2.Items.AddRange(new String[] { "Office2007Black", "Office2007Blue", "Office2007Silver", "Office2003", "Mozilla", "Default", "Metro","Office2016Colorful","Office2016DarkGray","Office2016White","Office2016Black" });
            //this.comboBox2.DataSource = Enum.GetValues(typeof(Syncfusion.Windows.Forms.Tools.Enums.Style));
            //this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.None;
            //this.splitContainerAdv2.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.None;
            this.comboBox2.SelectedIndex = 8;
            SetTheme(Syncfusion.Windows.Forms.Tools.Enums.Style.None);
        }

       
       

        private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
        {
            this.splitContainerAdv1.SplitterDistance = (int)this.numericUpDown1.Value;
        }

        private void splitContainerAdv1_SplitterMoved(object sender, Syncfusion.Windows.Forms.Tools.Events.SplitterMoveEventArgs e)
        {
            this.numericUpDown1.Value = this.splitContainerAdv1.SplitterDistance;
        }

        private void numericUpDown2_ValueChanged(object sender, System.EventArgs e)
        {
            if(this.numericUpDown2.Value <20)
            this.splitContainerAdv1.SplitterWidth = (int)this.numericUpDown2.Value;
        }

        private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.splitContainerAdv1.Panel1Collapsed = true;
                this.checkBox3.Checked = false;
            }
            else
                this.splitContainerAdv1.Panel1Collapsed = false;


        }

        private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.checkBox3.Checked)
            {
                this.splitContainerAdv2.Panel1Collapsed = true;
                this.checkBox2.Checked = false;
            }
            else
                this.splitContainerAdv2.Panel1Collapsed = false;


        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.splitContainerAdv1.IsSplitterFixed = true;
                this.splitContainerAdv2.IsSplitterFixed = true;
            }
            else
            {
                this.splitContainerAdv1.IsSplitterFixed = false;
                this.splitContainerAdv2.IsSplitterFixed = false;
            }
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (this.comboBox2.SelectedItem != null)
            //{                
            //    //this.comboBox2.SelectedItem.
                
            //    Syncfusion.Windows.Forms.Tools.Enums.Style v = (Syncfusion.Windows.Forms.Tools.Enums.Style)this.comboBox2.SelectedValue;
            //    this.splitContainerAdv2.Style = v;
            //    this.splitContainerAdv1.Style = v;
            //    SetTheme(v);
            //}
        }
        void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox2.SelectedIndex == 0)
            {
                this.splitContainerAdv2.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.None;
                this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.None;
                SetTheme(Syncfusion.Windows.Forms.Tools.Enums.Style.None);
                this.treeViewAdv1.BackColor = Color.White;
                this.splitContainerAdv1.ForeColor = Color.Black;
                this.label1.ForeColor = Color.Black;
                this.label2.ForeColor = Color.Black;
                this.label4.ForeColor = Color.Black;
                this.label9.ForeColor = Color.Black;
                this.label9.ForeColor = Color.Black;
                this.groupBox1.ForeColor = Color.Black;
                this.label6.ForeColor = Color.Black;
                this.checkBox1.ForeColor = Color.Black;
                this.checkBox2.ForeColor = Color.Black;
                this.checkBox3.ForeColor = Color.Black;
                this.splitContainerAdv1.ForeColor = Color.Black;
                this.treeViewAdv1.ForeColor = Color.Black;
                this.gradientLabel1.BorderColor = Color.Silver;
                this.treeViewAdv1.BorderColor = Color.Silver;
                this.panel2.BorderColor = Color.Silver;
            }
            else if (this.comboBox2.SelectedIndex == 1)
            {
                this.splitContainerAdv2.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2007Black;
                this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2007Black;
                SetTheme(Syncfusion.Windows.Forms.Tools.Enums.Style.Office2007Black);
                this.treeViewAdv1.BackColor = Color.White;
                this.splitContainerAdv1.ForeColor = Color.Black;
                this.label1.ForeColor = Color.Black;
                this.label2.ForeColor = Color.Black;
                this.label4.ForeColor = Color.Black;
                this.label9.ForeColor = Color.Black;
                this.label9.ForeColor = Color.Black;
                this.groupBox1.ForeColor = Color.Black;
                this.label6.ForeColor = Color.Black;
                this.checkBox1.ForeColor = Color.Black;
                this.checkBox2.ForeColor = Color.Black;
                this.checkBox3.ForeColor = Color.Black;
                this.splitContainerAdv1.ForeColor = Color.Black;
                this.treeViewAdv1.ForeColor = Color.Black;
                this.gradientLabel1.BorderColor = Color.Silver;
                this.treeViewAdv1.BorderColor = Color.Silver;
                this.panel2.BorderColor = Color.Silver;
            }
            else if (this.comboBox2.SelectedIndex == 2)
            {
                this.splitContainerAdv2.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2007Blue;
                this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2007Blue;
                SetTheme(Syncfusion.Windows.Forms.Tools.Enums.Style.Office2007Blue);
                this.treeViewAdv1.BackColor = Color.White;
                this.splitContainerAdv1.ForeColor = Color.Black;
                this.label1.ForeColor = Color.Black;
                this.label2.ForeColor = Color.Black;
                this.label4.ForeColor = Color.Black;
                this.label9.ForeColor = Color.Black;
                this.label9.ForeColor = Color.Black;
                this.groupBox1.ForeColor = Color.Black;
                this.label6.ForeColor = Color.Black;
                this.checkBox1.ForeColor = Color.Black;
                this.checkBox2.ForeColor = Color.Black;
                this.checkBox3.ForeColor = Color.Black;
                this.splitContainerAdv1.ForeColor = Color.Black;
                this.treeViewAdv1.ForeColor = Color.Black;
                this.gradientLabel1.BorderColor = Color.Silver;
                this.treeViewAdv1.BorderColor = Color.Silver;
                this.panel2.BorderColor = Color.Silver;
            }
            else if (this.comboBox2.SelectedIndex == 3)
            {
                this.splitContainerAdv2.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2007Silver;
                this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2007Silver;
                SetTheme(Syncfusion.Windows.Forms.Tools.Enums.Style.Office2007Silver);
                this.treeViewAdv1.BackColor = Color.White;
                this.splitContainerAdv1.ForeColor = Color.Black;
                this.label1.ForeColor = Color.Black;
                this.label2.ForeColor = Color.Black;
                this.label4.ForeColor = Color.Black;
                this.label9.ForeColor = Color.Black;
                this.label9.ForeColor = Color.Black;
                this.groupBox1.ForeColor = Color.Black;
                this.label6.ForeColor = Color.Black;
                this.checkBox1.ForeColor = Color.Black;
                this.checkBox2.ForeColor = Color.Black;
                this.checkBox3.ForeColor = Color.Black;
                this.splitContainerAdv1.ForeColor = Color.Black;
                this.treeViewAdv1.ForeColor = Color.Black;
                this.gradientLabel1.BorderColor = Color.Silver;
                this.treeViewAdv1.BorderColor = Color.Silver;
                this.panel2.BorderColor = Color.Silver;
            }
            else if (this.comboBox2.SelectedIndex == 4)
            {
                this.splitContainerAdv2.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2003;
                this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2003;
                SetTheme(Syncfusion.Windows.Forms.Tools.Enums.Style.Office2003);
                this.treeViewAdv1.BackColor = Color.White;
                this.splitContainerAdv1.ForeColor = Color.Black;
                this.label1.ForeColor = Color.Black;
                this.label2.ForeColor = Color.Black;
                this.label4.ForeColor = Color.Black;
                this.label9.ForeColor = Color.Black;
                this.label9.ForeColor = Color.Black;
                this.groupBox1.ForeColor = Color.Black;
                this.label6.ForeColor = Color.Black;
                this.checkBox1.ForeColor = Color.Black;
                this.checkBox2.ForeColor = Color.Black;
                this.checkBox3.ForeColor = Color.Black;
                this.splitContainerAdv1.ForeColor = Color.Black;
                this.treeViewAdv1.ForeColor = Color.Black;
                this.gradientLabel1.BorderColor = Color.Silver;
                this.treeViewAdv1.BorderColor = Color.Silver;
                this.panel2.BorderColor = Color.Silver;
            }
            else if (this.comboBox2.SelectedIndex == 5)
            {
                this.splitContainerAdv2.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Mozilla;
                this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Mozilla;
                SetTheme(Syncfusion.Windows.Forms.Tools.Enums.Style.Mozilla);
                this.treeViewAdv1.BackColor = Color.White;
                this.splitContainerAdv1.ForeColor = Color.Black;
                this.label1.ForeColor = Color.Black;
                this.label2.ForeColor = Color.Black;
                this.label4.ForeColor = Color.Black;
                this.label9.ForeColor = Color.Black;
                this.label9.ForeColor = Color.Black;
                this.groupBox1.ForeColor = Color.Black;
                this.label6.ForeColor = Color.Black;
                this.checkBox1.ForeColor = Color.Black;
                this.checkBox2.ForeColor = Color.Black;
                this.checkBox3.ForeColor = Color.Black;
                this.splitContainerAdv1.ForeColor = Color.Black;
                this.treeViewAdv1.ForeColor = Color.Black;
                this.gradientLabel1.BorderColor = Color.Silver;
               
                this.panel2.BorderColor = Color.Silver;
              
                
            }
            else if (this.comboBox2.SelectedIndex == 6)
            {
                this.splitContainerAdv2.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Default;
                this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Default;
                SetTheme(Syncfusion.Windows.Forms.Tools.Enums.Style.VS2005);
                this.treeViewAdv1.BackColor = Color.White;
                this.splitContainerAdv1.ForeColor = Color.Black;
                this.label1.ForeColor = Color.Black;
                this.label2.ForeColor = Color.Black;
                this.label4.ForeColor = Color.Black;
                this.label9.ForeColor = Color.Black;
                this.label9.ForeColor = Color.Black;
                this.groupBox1.ForeColor = Color.Black;
                this.label6.ForeColor = Color.Black;
                this.checkBox1.ForeColor = Color.Black;
                this.checkBox2.ForeColor = Color.Black;
                this.checkBox3.ForeColor = Color.Black;
                this.splitContainerAdv1.ForeColor = Color.Black;
                this.treeViewAdv1.ForeColor = Color.Black;
                this.gradientLabel1.BorderColor = Color.Silver;
                this.treeViewAdv1.BorderColor = Color.Silver;
                this.panel2.BorderColor = Color.Silver;
            }
            else if (this.comboBox2.SelectedIndex == 7)
            {
                this.splitContainerAdv2.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Metro;
                this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Metro;
                SetTheme(Syncfusion.Windows.Forms.Tools.Enums.Style.Metro);
                this.treeViewAdv1.BackColor = Color.White;
                this.splitContainerAdv1.ForeColor = Color.Black;
                this.label1.ForeColor = Color.Black;
                this.label2.ForeColor = Color.Black;
                this.label4.ForeColor = Color.Black;
                this.label9.ForeColor = Color.Black;
                this.label9.ForeColor = Color.Black;
                this.groupBox1.ForeColor = Color.Black;
                this.label6.ForeColor = Color.Black;
                this.checkBox1.ForeColor = Color.Black;
                this.checkBox2.ForeColor = Color.Black;
                this.checkBox3.ForeColor = Color.Black;
                this.splitContainerAdv1.ForeColor = Color.Black;
                this.treeViewAdv1.ForeColor = Color.Black;
                this.gradientLabel1.BorderColor = Color.Silver;
                this.treeViewAdv1.BorderColor = Color.Silver;
                this.panel2.BorderColor = Color.Silver;
                this.treeViewAdv1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#ffffff"));
                this.panel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#ffffff"));
            }
            else if (this.comboBox2.SelectedIndex == 8)
            {
                this.splitContainerAdv2.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016Colorful;
                this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016Colorful;
                this.treeViewAdv1.BackColor = Color.White;
                SetTheme(Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016Colorful);
                this.splitContainerAdv1.ForeColor = Color.Black;
                this.treeViewAdv1.BackColor = Color.White;
                this.splitContainerAdv1.ForeColor = Color.Black;
                this.label1.ForeColor = Color.Black;
                this.label2.ForeColor = Color.Black;
                this.label4.ForeColor = Color.Black;
                this.label9.ForeColor = Color.Black;
                this.label9.ForeColor = Color.Black;
                this.groupBox1.ForeColor = Color.Black;
                this.label6.ForeColor = Color.Black;
                this.checkBox1.ForeColor = Color.Black;
                this.checkBox2.ForeColor = Color.Black;
                this.checkBox3.ForeColor = Color.Black;
                this.splitContainerAdv1.ForeColor = Color.Black;
                this.treeViewAdv1.ForeColor = Color.Black;
                this.panel2.BorderColor = Color.Silver;
                this.treeViewAdv1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#ffffff"));
                this.panel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#ffffff"));


            }
            else if (this.comboBox2.SelectedIndex == 9)
            {
                this.splitContainerAdv2.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016DarkGray;
                this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016DarkGray;
                SetTheme(Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016DarkGray);
                this.treeViewAdv1.BackColor = ColorTranslator.FromHtml("#727272");
                this.gradientLabel1.BorderColor = Color.Black;
                this.panel2.BorderColor = Color.Black;
                this.splitContainerAdv2.BorderStyle = BorderStyle.None;
                this.gradientLabel1.BorderAppearance = BorderStyle.None;
                this.label1.ForeColor = Color.White;
                this.label2.ForeColor = Color.White;
                this.label4.ForeColor = Color.White;
                this.label9.ForeColor = Color.White;
                this.label9.ForeColor = Color.White;
                this.treeViewAdv1.ForeColor = Color.White;
                this.treeViewAdv1.BorderColor = ColorTranslator.FromHtml("#4a4a4a");
                this.groupBox1.ForeColor = Color.White;
                this.label6.ForeColor = Color.White;
                this.checkBox1.ForeColor= Color.White;
                this.checkBox2.ForeColor = Color.White;
                this.checkBox3.ForeColor = Color.White;
                this.splitContainerAdv1.ForeColor = Color.White;
                this.treeViewAdv1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#727272"));
                this.panel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#727272"));




            }
            else if (this.comboBox2.SelectedIndex == 10)
            {
                this.splitContainerAdv2.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016White;
                this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016White;
                SetTheme(Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016White);
                this.treeViewAdv1.BackColor = Color.White;
                this.splitContainerAdv1.ForeColor = Color.Black;
                this.label1.ForeColor = Color.Black;
                this.label2.ForeColor = Color.Black;
                this.label4.ForeColor = Color.Black;
                this.label9.ForeColor = Color.Black;
                this.label9.ForeColor = Color.Black;
                this.groupBox1.ForeColor = Color.Black;
                this.label6.ForeColor = Color.Black;
                this.checkBox1.ForeColor = Color.Black;
                this.checkBox2.ForeColor = Color.Black;
                this.checkBox3.ForeColor = Color.Black;
                this.splitContainerAdv1.ForeColor = Color.Black;
                this.treeViewAdv1.ForeColor = Color.Black;
                this.gradientLabel1.BorderColor = Color.Silver;
                this.treeViewAdv1.BorderColor = Color.Silver;
                this.panel2.BorderColor = Color.Silver;
                this.treeViewAdv1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#ffffff"));
                this.panel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#ffffff"));
                this.splitContainerAdv1.BorderStyle = BorderStyle.FixedSingle;

            }
            else if (this.comboBox2.SelectedIndex == 11)
            {

                this.splitContainerAdv2.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016Black;
                this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016Black;
                SetTheme(Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016Black);
                this.treeViewAdv1.BackColor = ColorTranslator.FromHtml("#262626");
                this.gradientLabel1.BorderColor = Color.Gray;
                this.panel2.BorderColor = Color.Gray;
                this.splitContainerAdv2.BorderStyle = BorderStyle.None;
                this.gradientLabel1.BorderAppearance = BorderStyle.None;
                this.label1.ForeColor = Color.White;
                this.label2.ForeColor = Color.White;
                this.label4.ForeColor = Color.White;
                this.label9.ForeColor = Color.White;
                this.label9.ForeColor = Color.White;
                this.treeViewAdv1.ForeColor = Color.White;
                this.treeViewAdv1.BorderColor = ColorTranslator.FromHtml("#4a4a4a");
                this.groupBox1.ForeColor = Color.White;
                this.label6.ForeColor = Color.White;
                this.checkBox1.ForeColor = Color.White;
                this.checkBox2.ForeColor = Color.White;
                this.checkBox3.ForeColor = Color.White;
                this.splitContainerAdv1.ForeColor = Color.White;
                this.treeViewAdv1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#262626"));
                this.panel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#262626"));



            }
        }

        private void SetTheme(Syncfusion.Windows.Forms.Tools.Enums.Style style)
        {
            switch (style)
            {
                case Syncfusion.Windows.Forms.Tools.Enums.Style.None:
                    this.panel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
                    this.treeViewAdv1.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
                    this.treeViewAdv1.BackColor = Color.White;
                    this.panel2.BackColor = Color.Transparent;
                    break;
                case Syncfusion.Windows.Forms.Tools.Enums.Style.Default:
                    SetBackGroundColorToPanels(134, 134, 134, 134, 134, 134);
                    break;
                case Syncfusion.Windows.Forms.Tools.Enums.Style.Mozilla:
                    SetBackGroundColorToPanels(134, 134, 134, 134, 134, 134);
                    break;
                case Syncfusion.Windows.Forms.Tools.Enums.Style.Office2007Black:
                    SetBackGroundColorToPanels(90, 90, 90, 134, 134, 134);
                    break;
                case Syncfusion.Windows.Forms.Tools.Enums.Style.Office2007Blue:
                    SetBackGroundColorToPanels(186, 213, 252, 228, 240, 255);
                    break;
                case Syncfusion.Windows.Forms.Tools.Enums.Style.Office2007Silver:
                    SetBackGroundColorToPanels(192, 196, 205, 221, 225, 229);
                    break;
                case Syncfusion.Windows.Forms.Tools.Enums.Style.Office2003:
                    SetBackGroundColorToPanels(181, 196, 235, 197, 213, 233);
                    break;
                case Syncfusion.Windows.Forms.Tools.Enums.Style.OfficeXP:
                    SetBackGroundColorToPanels(181, 196, 235, 197, 213, 233);
                    break;
                case Syncfusion.Windows.Forms.Tools.Enums.Style.VS2005:
                    SetBackGroundColorToPanels(134, 134, 134, 134, 134, 134);
                    break;
            }
        }

        private void SetBackGroundColorToPanels(int r1, int g1, int b1, int r, int g, int b)
        {
            this.treeViewAdv1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(r1)))), ((int)(((byte)(g1)))), ((int)(((byte)(b1))))), System.Drawing.Color.FromArgb(((int)(((byte)(r)))), ((int)(((byte)(g)))), ((int)(((byte)(b))))));
          this.panel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(r1)))), ((int)(((byte)(g1)))), ((int)(((byte)(b1))))), System.Drawing.Color.FromArgb(((int)(((byte)(r)))), ((int)(((byte)(g)))), ((int)(((byte)(b))))));
        }

       

        private void radioButtonAdv1_CheckChanged(object sender, EventArgs e)
        {
            if (this.radioButtonAdv1.Checked)
            {
                this.splitContainerAdv1.TogglePanelOn = Syncfusion.Windows.Forms.Tools.Enums.TogglePanelOn.Click;
                this.splitContainerAdv2.TogglePanelOn = Syncfusion.Windows.Forms.Tools.Enums.TogglePanelOn.Click;
            }
            else
            {
                this.splitContainerAdv1.TogglePanelOn = Syncfusion.Windows.Forms.Tools.Enums.TogglePanelOn.DoubleClick;
                this.splitContainerAdv2.TogglePanelOn = Syncfusion.Windows.Forms.Tools.Enums.TogglePanelOn.DoubleClick;
            }
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
