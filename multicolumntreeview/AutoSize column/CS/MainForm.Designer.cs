#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Drawing;
using System.Windows.Forms;

namespace MultiColumnTreeViewDemo
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
            Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvStyleInfo();
            Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvSubItemStyleInfo treeNodeAdvSubItemStyleInfo1 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvSubItemStyleInfo();
            Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdvStyleInfo treeColumnAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdvStyleInfo();
            Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.MultiColumnTreeViewVisualStyle multiColumnTreeViewVisualStyle1 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.MultiColumnTreeViewVisualStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.multiColumnTreeView1 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.MultiColumnTreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.multiColumnTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // multiColumnTreeView1
            // 
            this.multiColumnTreeView1.AddSeparatorAtEnd = true;
            this.multiColumnTreeView1.AutoAdjustMultiLineHeight = true;
            treeNodeAdvStyleInfo1.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdvStyleInfo1.DisabledOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            treeNodeAdvStyleInfo1.HoverCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            treeNodeAdvStyleInfo1.HoverOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            treeNodeAdvStyleInfo1.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.IntermediateDisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdvStyleInfo1.IntermediateHoverCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            treeNodeAdvStyleInfo1.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            treeNodeAdvStyleInfo1.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.multiColumnTreeView1.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.StyleNamePair("Standard", treeNodeAdvStyleInfo1),
            new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.StyleNamePair("Standard - SubItem", treeNodeAdvSubItemStyleInfo1),
            new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.StyleNamePair("Standard - Column", treeColumnAdvStyleInfo1)});
            this.multiColumnTreeView1.BeforeTouchSize = new System.Drawing.Size(813, 470);
            this.multiColumnTreeView1.BorderColor = System.Drawing.Color.Silver;
            this.multiColumnTreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.multiColumnTreeView1.ColumnsHeaderBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.ButtonFace);
            this.multiColumnTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiColumnTreeView1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // 
            // 
            this.multiColumnTreeView1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.multiColumnTreeView1.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.multiColumnTreeView1.HelpTextControl.Name = "m_helpText";
            this.multiColumnTreeView1.HelpTextControl.Size = new System.Drawing.Size(49, 15);
            this.multiColumnTreeView1.HelpTextControl.TabIndex = 0;
            this.multiColumnTreeView1.HelpTextControl.Text = "help text";
            this.multiColumnTreeView1.LabelEdit = true;
            this.multiColumnTreeView1.LoadOnDemand = true;
            this.multiColumnTreeView1.Location = new System.Drawing.Point(0, 0);
            this.multiColumnTreeView1.MetroScrollBars = true;
            this.multiColumnTreeView1.Name = "multiColumnTreeView1";
            this.multiColumnTreeView1.OwnerDrawNodes = true;
            this.multiColumnTreeView1.Size = new System.Drawing.Size(813, 470);
            this.multiColumnTreeView1.StateImageList = this.imageList1;
            this.multiColumnTreeView1.TabIndex = 1;
            this.multiColumnTreeView1.Text = "MultiColumnTreeViewDemo.csmultiColumnTreeView1";
            multiColumnTreeViewVisualStyle1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            multiColumnTreeViewVisualStyle1.TreeNodeAdvStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            multiColumnTreeViewVisualStyle1.TreeNodeAdvStyle.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            multiColumnTreeViewVisualStyle1.TreeNodeAdvStyle.DisabledOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            multiColumnTreeViewVisualStyle1.TreeNodeAdvStyle.HoverCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            multiColumnTreeViewVisualStyle1.TreeNodeAdvStyle.HoverOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            multiColumnTreeViewVisualStyle1.TreeNodeAdvStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            multiColumnTreeViewVisualStyle1.TreeNodeAdvStyle.IntermediateDisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            multiColumnTreeViewVisualStyle1.TreeNodeAdvStyle.IntermediateHoverCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            multiColumnTreeViewVisualStyle1.TreeNodeAdvStyle.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            multiColumnTreeViewVisualStyle1.TreeNodeAdvStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.multiColumnTreeView1.ThemeStyle = multiColumnTreeViewVisualStyle1;
            // 
            // 
            // 
            this.multiColumnTreeView1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.multiColumnTreeView1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.multiColumnTreeView1.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.multiColumnTreeView1.ToolTipControl.Name = "m_toolTip";
            this.multiColumnTreeView1.ToolTipControl.Size = new System.Drawing.Size(41, 15);
            this.multiColumnTreeView1.ToolTipControl.TabIndex = 1;
            this.multiColumnTreeView1.ToolTipControl.Text = "toolTip";
            // 
            // imageList1
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.imageList1, "ImageList1", 3);
#else
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
#endif
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.ico");
            this.imageList1.Images.SetKeyName(1, "folder.ico");
            this.imageList1.Images.SetKeyName(2, "folder.ico");
            // 
            // panel1
            // 
            this.panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBoxAdv1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 55);
            this.panel1.TabIndex = 1;
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(217, 25);
            this.comboBoxAdv1.Location = new System.Drawing.Point(157, 14);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(217, 25);
            this.comboBoxAdv1.TabIndex = 0;
            this.comboBoxAdv1.Text = "comboBoxAdv1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "AutoFit Column Mode";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(10, 10);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.multiColumnTreeView1);
            this.splitContainer1.Size = new System.Drawing.Size(813, 532);
            this.splitContainer1.SplitterDistance = 55;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 552);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoFit Column";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.multiColumnTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        
        private Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.MultiColumnTreeView multiColumnTreeView1;
        private System.Windows.Forms.ImageList imageList1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
    }
}