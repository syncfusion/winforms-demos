#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Virtualization_Demo
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
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            Syncfusion.Windows.Forms.Tools.TreeViewAdvVisualStyle treeViewAdvVisualStyle1 = new Syncfusion.Windows.Forms.Tools.TreeViewAdvVisualStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.load_Button = new Syncfusion.WinForms.Controls.SfButton();
            this.nodeCount_ComboBox = new Syncfusion.WinForms.ListView.SfComboBox();
            this.showCheckBox_CheckBoxAdv = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.expandnLoad_label = new System.Windows.Forms.Label();
            this.expandOnLoad_checkBoxAdv = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.showCheckBox_label = new System.Windows.Forms.Label();
            this.nodeCountlabel = new System.Windows.Forms.Label();
            this.treeViewAdv1 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.leftImageList = new System.Windows.Forms.ImageList(this.components);
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.timeTakenLabel = new System.Windows.Forms.Label();
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            ((System.ComponentModel.ISupportInitialize)(this.nodeCount_ComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showCheckBox_CheckBoxAdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expandOnLoad_checkBoxAdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            this.SuspendLayout();
            // 
            // load_Button
            // 
            this.load_Button.AccessibleName = "Button";
            this.load_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.load_Button.Location = new System.Drawing.Point(115, 245);
            this.load_Button.Name = "load_Button";
            this.load_Button.Size = new System.Drawing.Size(110, 28);
            this.load_Button.TabIndex = 10;
            this.load_Button.Text = "Load";
            this.load_Button.Click += new System.EventHandler(this.load_Button_Click);
            // 
            // nodeCount_ComboBox
            // 
            this.nodeCount_ComboBox.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.nodeCount_ComboBox.Location = new System.Drawing.Point(157, 104);
            this.nodeCount_ComboBox.Name = "nodeCount_ComboBox";
            this.nodeCount_ComboBox.Size = new System.Drawing.Size(121, 28);
            this.nodeCount_ComboBox.TabIndex = 9;
            this.nodeCount_ComboBox.SelectedIndexChanged += new System.EventHandler(this.nodeCount_Combobox_SelectedIndexChanged);
            // 
            // showCheckBox_CheckBoxAdv
            // 
            this.showCheckBox_CheckBoxAdv.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.showCheckBox_CheckBoxAdv.Location = new System.Drawing.Point(157, 197);
            this.showCheckBox_CheckBoxAdv.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.showCheckBox_CheckBoxAdv.Name = "showCheckBox_CheckBoxAdv";
            this.showCheckBox_CheckBoxAdv.Size = new System.Drawing.Size(150, 21);
            this.showCheckBox_CheckBoxAdv.TabIndex = 7;
            this.showCheckBox_CheckBoxAdv.ThemesEnabled = false;
            this.showCheckBox_CheckBoxAdv.CheckStateChanged += new System.EventHandler(this.showCheckBox_CheckBoxAdv_CheckStateChanged);
            // 
            // expandnLoad_label
            // 
            this.expandnLoad_label.AutoSize = true;
            this.expandnLoad_label.Location = new System.Drawing.Point(36, 154);
            this.expandnLoad_label.Name = "expandnLoad_label";
            this.expandnLoad_label.Size = new System.Drawing.Size(57, 13);
            this.expandnLoad_label.TabIndex = 4;
            this.expandnLoad_label.Text = "Expand All";
            // 
            // expandOnLoad_checkBoxAdv
            // 
            this.expandOnLoad_checkBoxAdv.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.expandOnLoad_checkBoxAdv.Checked = true;
            this.expandOnLoad_checkBoxAdv.CheckState = System.Windows.Forms.CheckState.Checked;
            this.expandOnLoad_checkBoxAdv.Location = new System.Drawing.Point(157, 154);
            this.expandOnLoad_checkBoxAdv.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.expandOnLoad_checkBoxAdv.Name = "expandOnLoad_checkBoxAdv";
            this.expandOnLoad_checkBoxAdv.Size = new System.Drawing.Size(150, 21);
            this.expandOnLoad_checkBoxAdv.TabIndex = 3;
            this.expandOnLoad_checkBoxAdv.ThemeName = "Office2019Colorful";
            this.expandOnLoad_checkBoxAdv.ThemesEnabled = false;
            // 
            // showCheckBox_label
            // 
            this.showCheckBox_label.AutoSize = true;
            this.showCheckBox_label.Location = new System.Drawing.Point(36, 197);
            this.showCheckBox_label.Name = "showCheckBox_label";
            this.showCheckBox_label.Size = new System.Drawing.Size(92, 13);
            this.showCheckBox_label.TabIndex = 2;
            this.showCheckBox_label.Text = "Enable CheckBox";
            // 
            // nodeCountlabel
            // 
            this.nodeCountlabel.AutoSize = true;
            this.nodeCountlabel.Location = new System.Drawing.Point(36, 113);
            this.nodeCountlabel.Name = "nodeCountlabel";
            this.nodeCountlabel.Size = new System.Drawing.Size(97, 13);
            this.nodeCountlabel.TabIndex = 0;
            this.nodeCountlabel.Text = "Select Node Count";
            // 
            // treeViewAdv1
            // 
            treeNodeAdvStyleInfo1.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdvStyleInfo1.TextColor = System.Drawing.Color.Black;
            this.treeViewAdv1.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this.treeViewAdv1.BeforeTouchSize = new System.Drawing.Size(376, 555);
            this.treeViewAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.treeViewAdv1.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.treeViewAdv1.Name = "treeViewAdv1";
            this.treeViewAdv1.SelectedNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this.treeViewAdv1.Size = new System.Drawing.Size(376, 555);
            this.treeViewAdv1.TabIndex = 1;
            this.treeViewAdv1.Text = "Office2019Colorful";
            treeViewAdvVisualStyle1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            treeViewAdvVisualStyle1.TreeNodeAdvStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeViewAdvVisualStyle1.TreeNodeAdvStyle.EnsureDefaultOptionedChild = true;
            treeViewAdvVisualStyle1.TreeNodeAdvStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeViewAdvVisualStyle1.TreeNodeAdvStyle.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeViewAdvVisualStyle1.TreeNodeAdvStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.treeViewAdv1.ThemeStyle = treeViewAdvVisualStyle1;
            // 
            // 
            // 
            this.treeViewAdv1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.treeViewAdv1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv1.ToolTipControl.Name = "toolTip";
            this.treeViewAdv1.ToolTipControl.Size = new System.Drawing.Size(41, 15);
            this.treeViewAdv1.ToolTipControl.TabIndex = 1;
            this.treeViewAdv1.ToolTipControl.Text = "toolTip";
            // 
            // leftImageList
            // 
            this.leftImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.leftImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.leftImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.timeTakenLabel);
            this.gradientPanel1.Controls.Add(this.load_Button);
            this.gradientPanel1.Controls.Add(this.showCheckBox_label);
            this.gradientPanel1.Controls.Add(this.nodeCount_ComboBox);
            this.gradientPanel1.Controls.Add(this.expandOnLoad_checkBoxAdv);
            this.gradientPanel1.Controls.Add(this.nodeCountlabel);
            this.gradientPanel1.Controls.Add(this.showCheckBox_CheckBoxAdv);
            this.gradientPanel1.Controls.Add(this.expandnLoad_label);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(325, 555);
            this.gradientPanel1.TabIndex = 11;
            // 
            // timeTakenLabel
            // 
            this.timeTakenLabel.AutoSize = true;
            this.timeTakenLabel.Location = new System.Drawing.Point(92, 309);
            this.timeTakenLabel.Name = "timeTakenLabel";
            this.timeTakenLabel.Size = new System.Drawing.Size(63, 13);
            this.timeTakenLabel.TabIndex = 11;
            this.timeTakenLabel.Text = "Loaded in : ";
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.BeforeTouchSize = 8;
            this.splitContainerAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAdv1.Location = new System.Drawing.Point(10, 10);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.Controls.Add(this.treeViewAdv1);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.Controls.Add(this.gradientPanel1);
            this.splitContainerAdv1.Size = new System.Drawing.Size(709, 555);
            this.splitContainerAdv1.SplitterDistance = 376;
            this.splitContainerAdv1.SplitterWidth = 8;
            this.splitContainerAdv1.TabIndex = 12;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            this.splitContainerAdv1.ThemeName = "None";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 575);
            this.Controls.Add(this.splitContainerAdv1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vitrualization";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nodeCount_ComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showCheckBox_CheckBoxAdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expandOnLoad_checkBoxAdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.TreeViewAdv treeViewAdv1;
        private System.Windows.Forms.Label nodeCountlabel;
        private System.Windows.Forms.Label showCheckBox_label;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv expandOnLoad_checkBoxAdv;
        private System.Windows.Forms.Label expandnLoad_label;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv showCheckBox_CheckBoxAdv;
        private System.Windows.Forms.ImageList leftImageList;
        private Syncfusion.WinForms.ListView.SfComboBox nodeCount_ComboBox;
        private Syncfusion.WinForms.Controls.SfButton load_Button;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.SplitContainerAdv splitContainerAdv1;
        private System.Windows.Forms.Label timeTakenLabel;
    }
}

