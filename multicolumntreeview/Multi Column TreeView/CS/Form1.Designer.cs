#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Tools;

namespace MultiColumnTreeViewDemo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo2 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvStyleInfo();
            Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvSubItemStyleInfo treeNodeAdvSubItemStyleInfo2 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvSubItemStyleInfo();
            Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdvStyleInfo treeColumnAdvStyleInfo2 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdvStyleInfo();
            Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.MultiColumnTreeViewVisualStyle multiColumnTreeViewVisualStyle2 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.MultiColumnTreeViewVisualStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.selectionModeGroupBox = new System.Windows.Forms.GroupBox();
            this.multiSelectAllCheckBox = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.multiSelectSameCheckBoxAdv = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.singleSelectioncheckBox = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.visualStylelabel = new System.Windows.Forms.Label();
            this.visualStyleComboBox = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.multiColumnTreeView1 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.MultiColumnTreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).BeginInit();
            this.panel2.SuspendLayout();
            this.selectionModeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.multiSelectAllCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiSelectSameCheckBoxAdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleSelectioncheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyleComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiColumnTreeView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.selectionModeGroupBox);
            this.panel2.Controls.Add(this.visualStylelabel);
            this.panel2.Controls.Add(this.visualStyleComboBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(528, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 571);
            this.panel2.TabIndex = 3;
            // 
            // selectionModeGroupBox
            // 
            this.selectionModeGroupBox.Controls.Add(this.multiSelectAllCheckBox);
            this.selectionModeGroupBox.Controls.Add(this.multiSelectSameCheckBoxAdv);
            this.selectionModeGroupBox.Controls.Add(this.singleSelectioncheckBox);
            this.selectionModeGroupBox.Location = new System.Drawing.Point(38, 131);
            this.selectionModeGroupBox.Name = "selectionModeGroupBox";
            this.selectionModeGroupBox.Size = new System.Drawing.Size(200, 180);
            this.selectionModeGroupBox.TabIndex = 5;
            this.selectionModeGroupBox.TabStop = false;
            this.selectionModeGroupBox.Text = "Selection Mode";
            // 
            // multiSelectAllCheckBox
            // 
            this.multiSelectAllCheckBox.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.multiSelectAllCheckBox.Location = new System.Drawing.Point(19, 127);
            this.multiSelectAllCheckBox.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.multiSelectAllCheckBox.Name = "multiSelectAllCheckBox";
            this.multiSelectAllCheckBox.Size = new System.Drawing.Size(150, 21);
            this.multiSelectAllCheckBox.TabIndex = 5;
            this.multiSelectAllCheckBox.Text = "Multiselect All Level";
            this.multiSelectAllCheckBox.ThemesEnabled = false;
            this.multiSelectAllCheckBox.CheckChanged += new System.EventHandler(this.singleSelectioncheckBox_CheckChanged);
            // 
            // multiSelectSameCheckBoxAdv
            // 
            this.multiSelectSameCheckBoxAdv.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.multiSelectSameCheckBoxAdv.Location = new System.Drawing.Point(19, 84);
            this.multiSelectSameCheckBoxAdv.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.multiSelectSameCheckBoxAdv.Name = "multiSelectSameCheckBoxAdv";
            this.multiSelectSameCheckBoxAdv.Size = new System.Drawing.Size(150, 21);
            this.multiSelectSameCheckBoxAdv.TabIndex = 4;
            this.multiSelectSameCheckBoxAdv.Text = "Multiselect Same Level";
            this.multiSelectSameCheckBoxAdv.ThemesEnabled = false;
            this.multiSelectSameCheckBoxAdv.CheckChanged += new System.EventHandler(this.singleSelectioncheckBox_CheckChanged);
            // 
            // singleSelectioncheckBox
            // 
            this.singleSelectioncheckBox.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.singleSelectioncheckBox.ForeColor = System.Drawing.Color.Black;
            this.singleSelectioncheckBox.Location = new System.Drawing.Point(19, 41);
            this.singleSelectioncheckBox.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.singleSelectioncheckBox.Name = "singleSelectioncheckBox";
            this.singleSelectioncheckBox.Size = new System.Drawing.Size(150, 21);
            this.singleSelectioncheckBox.TabIndex = 3;
            this.singleSelectioncheckBox.Text = "Single selection";
            this.singleSelectioncheckBox.ThemeName = "Default";
            this.singleSelectioncheckBox.ThemesEnabled = false;
            this.singleSelectioncheckBox.CheckChanged += new System.EventHandler(this.singleSelectioncheckBox_CheckChanged);
            // 
            // visualStylelabel
            // 
            this.visualStylelabel.AutoSize = true;
            this.visualStylelabel.Location = new System.Drawing.Point(35, 88);
            this.visualStylelabel.Name = "visualStylelabel";
            this.visualStylelabel.Size = new System.Drawing.Size(61, 13);
            this.visualStylelabel.TabIndex = 2;
            this.visualStylelabel.Text = "Visual Style";
            // 
            // visualStyleComboBox
            // 
            this.visualStyleComboBox.BeforeTouchSize = new System.Drawing.Size(132, 21);
            this.visualStyleComboBox.Location = new System.Drawing.Point(106, 84);
            this.visualStyleComboBox.Name = "visualStyleComboBox";
            this.visualStyleComboBox.Size = new System.Drawing.Size(132, 21);
            this.visualStyleComboBox.TabIndex = 4;
            this.visualStyleComboBox.Text = "comboBoxAdv1";
            this.visualStyleComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // multiColumnTreeView1
            // 
            this.multiColumnTreeView1.AddSeparatorAtEnd = true;
            this.multiColumnTreeView1.AutoAdjustMultiLineHeight = true;
            this.multiColumnTreeView1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            treeNodeAdvStyleInfo2.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            treeNodeAdvStyleInfo2.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo2.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdvStyleInfo2.DisabledOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            treeNodeAdvStyleInfo2.HoverCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            treeNodeAdvStyleInfo2.HoverOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            treeNodeAdvStyleInfo2.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo2.IntermediateDisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdvStyleInfo2.IntermediateHoverCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            treeNodeAdvStyleInfo2.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            treeNodeAdvStyleInfo2.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            treeNodeAdvSubItemStyleInfo2.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            treeNodeAdvSubItemStyleInfo2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            treeColumnAdvStyleInfo2.AreaBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            treeColumnAdvStyleInfo2.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225))))));
            treeColumnAdvStyleInfo2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.multiColumnTreeView1.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.StyleNamePair("Standard", treeNodeAdvStyleInfo2),
            new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.StyleNamePair("Standard - SubItem", treeNodeAdvSubItemStyleInfo2),
            new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.StyleNamePair("Standard - Column", treeColumnAdvStyleInfo2)});
            this.multiColumnTreeView1.BeforeTouchSize = new System.Drawing.Size(510, 571);
            this.multiColumnTreeView1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.multiColumnTreeView1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.multiColumnTreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.multiColumnTreeView1.ColumnsHeaderBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            this.multiColumnTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiColumnTreeView1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiColumnTreeView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            // 
            // 
            // 
            this.multiColumnTreeView1.HelpTextControl.BaseThemeName = null;
            this.multiColumnTreeView1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.multiColumnTreeView1.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.multiColumnTreeView1.HelpTextControl.Name = "m_helpText";
            this.multiColumnTreeView1.HelpTextControl.Size = new System.Drawing.Size(49, 15);
            this.multiColumnTreeView1.HelpTextControl.TabIndex = 0;
            this.multiColumnTreeView1.HelpTextControl.Text = "help text";
            this.multiColumnTreeView1.KeepDottedSelection = false;
            this.multiColumnTreeView1.LabelEdit = true;
            this.multiColumnTreeView1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.multiColumnTreeView1.LoadOnDemand = true;
            this.multiColumnTreeView1.Location = new System.Drawing.Point(10, 10);
            this.multiColumnTreeView1.MetroScrollBars = true;
            this.multiColumnTreeView1.Name = "multiColumnTreeView1";
            this.multiColumnTreeView1.OwnerDrawNodes = true;
            this.multiColumnTreeView1.SelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197))))));
            this.multiColumnTreeView1.SelectedNodeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.multiColumnTreeView1.Size = new System.Drawing.Size(510, 571);
            this.multiColumnTreeView1.Style = Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.MultiColumnVisualStyle.Office2016Colorful;
            this.multiColumnTreeView1.TabIndex = 4;
            this.multiColumnTreeView1.Text = "MultiColumnTreeViewDemo.csmultiColumnTreeView1";
            this.multiColumnTreeView1.ThemeName = "Office2016Colorful";
            multiColumnTreeViewVisualStyle2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.multiColumnTreeView1.ThemeStyle = multiColumnTreeViewVisualStyle2;
            // 
            // 
            // 
            this.multiColumnTreeView1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.multiColumnTreeView1.ToolTipControl.BaseThemeName = null;
            this.multiColumnTreeView1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.multiColumnTreeView1.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.multiColumnTreeView1.ToolTipControl.Name = "m_toolTip";
            this.multiColumnTreeView1.ToolTipControl.Size = new System.Drawing.Size(41, 15);
            this.multiColumnTreeView1.ToolTipControl.TabIndex = 1;
            this.multiColumnTreeView1.ToolTipControl.Text = "toolTip";
            this.multiColumnTreeView1.TransparentControls = true;
            this.multiColumnTreeView1.VScrollPos = -13;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(520, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 571);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 591);
            this.Controls.Add(this.multiColumnTreeView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Getting Started";
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.selectionModeGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.multiSelectAllCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiSelectSameCheckBoxAdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleSelectioncheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyleComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiColumnTreeView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel panel2;
        private System.Windows.Forms.GroupBox selectionModeGroupBox;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv multiSelectAllCheckBox;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv multiSelectSameCheckBoxAdv;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv singleSelectioncheckBox;
        private System.Windows.Forms.Label visualStylelabel;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv visualStyleComboBox;
        private Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.MultiColumnTreeView multiColumnTreeView1;
        private System.Windows.Forms.Panel panel1;
    }
}