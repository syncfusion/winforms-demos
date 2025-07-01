#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.WinForms.Controls;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp54
{
    partial class Form1 : SfForm
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

        #region Windows Form Designer - Generated Code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.popupMenu1 = new Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(this.components);
            this.popupMenusManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenusManager();
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.editBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.cutBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.copyBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.pasteBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.undoBarItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.redoBarItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.newBarItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.openBarItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.fontColordropDownBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem();
            this.popupControlContainer1 = new Syncfusion.Windows.Forms.PopupControlContainer();
            this.colorPickerUIAdv1 = new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv();
            this.textBoxBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.TextBoxBarItem();
            this.exitBarItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownExt2 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.numericUpDownExt1 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.sfComboBox1 = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.popupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // popupMenu1
            // 
            this.popupMenu1.ParentBarItem = this.parentBarItem1;
            this.popupMenu1.ThemeName = "Office2019Colorful";
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.BarName = "parentBarItem1";
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.newBarItem6,
            this.openBarItem7,
            this.editBarItem2,
            this.fontColordropDownBarItem2,
            this.textBoxBarItem1,
            this.exitBarItem8});
            this.parentBarItem1.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem1.SeparatorIndices.AddRange(new int[] {
            2,
            5});
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.WrapLength = 20;
            // 
            // editBarItem2
            // 
            this.editBarItem2.BarName = "editBarItem2";
            this.editBarItem2.ID = "Edit";
            this.editBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.cutBarItem1,
            this.copyBarItem2,
            this.pasteBarItem3,
            this.undoBarItem4,
            this.redoBarItem5});
            this.editBarItem2.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.editBarItem2.ShowToolTipInPopUp = false;
            this.editBarItem2.SizeToFit = true;
            this.editBarItem2.Text = "Edit";
            this.editBarItem2.WrapLength = 20;
            // 
            // cutBarItem1
            // 
            this.cutBarItem1.BarName = "cutBarItem1";
            this.cutBarItem1.Enabled = false;
            this.cutBarItem1.ID = "Cut";
            this.cutBarItem1.Image = ((Syncfusion.Windows.Forms.Tools.XPMenus.ImageExt)(resources.GetObject("cutBarItem1.Image")));
            this.cutBarItem1.ShowToolTipInPopUp = false;
            this.cutBarItem1.SizeToFit = true;
            this.cutBarItem1.Text = "Cut";
            this.cutBarItem1.Click += CutBarItem1_Click;
            // 
            // copyBarItem2
            // 
            this.copyBarItem2.BarName = "copyBarItem2";
            this.copyBarItem2.Enabled = false;
            this.copyBarItem2.ID = "Copy";
            this.copyBarItem2.Image = ((Syncfusion.Windows.Forms.Tools.XPMenus.ImageExt)(resources.GetObject("copyBarItem2.Image")));
            this.copyBarItem2.ShowToolTipInPopUp = false;
            this.copyBarItem2.SizeToFit = true;
            this.copyBarItem2.Text = "Copy";
            this.copyBarItem2.Click += CopyBarItem2_Click;
            // 
            // pasteBarItem3
            // 
            this.pasteBarItem3.BarName = "pasteBarItem3";
            this.pasteBarItem3.ID = "Paste";
            this.pasteBarItem3.Image = ((Syncfusion.Windows.Forms.Tools.XPMenus.ImageExt)(resources.GetObject("pasteBarItem3.Image")));
            this.pasteBarItem3.ShowToolTipInPopUp = false;
            this.pasteBarItem3.SizeToFit = true;
            this.pasteBarItem3.Text = "Paste";
            this.pasteBarItem3.Click += PasteBarItem3_Click;
            // 
            // undoBarItem4
            // 
            this.undoBarItem4.BarName = "undoBarItem4";
            this.undoBarItem4.ID = "Undo";
            this.undoBarItem4.Image = ((Syncfusion.Windows.Forms.Tools.XPMenus.ImageExt)(resources.GetObject("undoBarItem4.Image")));
            this.undoBarItem4.ShowToolTipInPopUp = false;
            this.undoBarItem4.SizeToFit = true;
            this.undoBarItem4.Text = "Undo";
            this.undoBarItem4.Click += UndoBarItem4_Click;
            // 
            // redoBarItem5
            // 
            this.redoBarItem5.BarName = "redoBarItem5";
            this.redoBarItem5.Enabled = false;
            this.redoBarItem5.ID = "Redo";
            this.redoBarItem5.Image = ((Syncfusion.Windows.Forms.Tools.XPMenus.ImageExt)(resources.GetObject("redoBarItem5.Image")));
            this.redoBarItem5.ShowToolTipInPopUp = false;
            this.redoBarItem5.SizeToFit = true;
            this.redoBarItem5.Text = "Redo";
            this.redoBarItem5.Click += RedoBarItem5_Click;
            // 
            // newBarItem6
            // 
            this.newBarItem6.BarName = "newBarItem6";
            this.newBarItem6.ID = "New";
            this.newBarItem6.Image = ((Syncfusion.Windows.Forms.Tools.XPMenus.ImageExt)(resources.GetObject("newBarItem6.Image")));
            this.newBarItem6.ShowToolTipInPopUp = false;
            this.newBarItem6.SizeToFit = true;
            this.newBarItem6.Text = "New";
            this.newBarItem6.Click += NewBarItem6_Click;
            // 
            // openBarItem7
            // 
            this.openBarItem7.BarName = "openBarItem7";
            this.openBarItem7.ID = "Open";
            this.openBarItem7.Image = ((Syncfusion.Windows.Forms.Tools.XPMenus.ImageExt)(resources.GetObject("openBarItem7.Image")));
            this.openBarItem7.ShowToolTipInPopUp = false;
            this.openBarItem7.SizeToFit = true;
            this.openBarItem7.Text = "Open";
            this.openBarItem7.Click += OpenBarItem7_Click;
            // 
            // fontColordropDownBarItem2
            // 
            this.fontColordropDownBarItem2.BarName = "fontColordropDownBarItem2";
            this.fontColordropDownBarItem2.ID = "Font Color";
            this.fontColordropDownBarItem2.PopupControlContainer = this.popupControlContainer1;
            this.fontColordropDownBarItem2.ShowToolTipInPopUp = false;
            this.fontColordropDownBarItem2.SizeToFit = true;
            this.fontColordropDownBarItem2.Text = "Font Color";
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.Controls.Add(this.colorPickerUIAdv1);
            this.popupControlContainer1.Location = new System.Drawing.Point(636, 67);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Size = new System.Drawing.Size(290, 300);
            this.popupControlContainer1.TabIndex = 8;
            this.popupControlContainer1.Visible = false;
            // 
            // colorPickerUIAdv1.RecentGroup
            // 
            this.colorPickerUIAdv1.RecentGroup.HeaderHeight = 17;
            this.colorPickerUIAdv1.RecentGroup.Name = "Recent Colors";
            this.colorPickerUIAdv1.RecentGroup.Visible = false;
            // 
            // colorPickerUIAdv1.StandardGroup
            // 
            this.colorPickerUIAdv1.StandardGroup.HeaderHeight = 17;
            this.colorPickerUIAdv1.StandardGroup.Name = "Standard Colors";
            // 
            // colorPickerUIAdv1.ThemeGroup
            // 
            this.colorPickerUIAdv1.ThemeGroup.HeaderHeight = 17;
            this.colorPickerUIAdv1.ThemeGroup.IsSubItemsVisible = true;
            this.colorPickerUIAdv1.ThemeGroup.Name = "Theme Colors";
            // 
            // colorPickerUIAdv1
            // 
            this.colorPickerUIAdv1.ButtonsHeight = 25;
            this.colorPickerUIAdv1.ColorItemSize = new System.Drawing.Size(17, 17);
            this.colorPickerUIAdv1.Location = new System.Drawing.Point(5, 4);
            this.colorPickerUIAdv1.MinimumSize = new System.Drawing.Size(136, 193);
            this.colorPickerUIAdv1.Name = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.Size = new System.Drawing.Size(212, 247);
            this.colorPickerUIAdv1.TabIndex = 0;
            this.colorPickerUIAdv1.Text = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.Picked += ColorPickerUIAdv1_Picked;
            // 
            // textBoxBarItem1
            // 
            this.textBoxBarItem1.BarName = "textBoxBarItem1";
            this.textBoxBarItem1.ID = "Type Anything...";
            this.textBoxBarItem1.ShowToolTipInPopUp = false;
            this.textBoxBarItem1.SizeToFit = true;
            this.textBoxBarItem1.TextBoxValue = "Type Anything...";
            // 
            // exitBarItem8
            // 
            this.exitBarItem8.BarName = "exitBarItem8";
            this.exitBarItem8.ID = "Exit";
            this.exitBarItem8.Image = ((Syncfusion.Windows.Forms.Tools.XPMenus.ImageExt)(resources.GetObject("exitBarItem8.Image")));
            this.exitBarItem8.ShowToolTipInPopUp = false;
            this.exitBarItem8.SizeToFit = true;
            this.exitBarItem8.Text = "Exit";
            this.exitBarItem8.Click += ExitBarItem8_Click;
            // 
            // popupMenusManager1
            // 
            this.popupMenusManager1.ParentForm = this;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(1, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(950, 852);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.SelectionChanged += RichTextBox1_SelectionChanged;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderColor = System.Drawing.Color.LightGray;
            this.gradientPanel1.Dock = DockStyle.Left;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.popupControlContainer1);
            this.gradientPanel1.Controls.Add(this.richTextBox1);
            this.gradientPanel1.Location = new System.Drawing.Point(3, 4);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(954, 852);
            this.gradientPanel1.TabIndex = 0;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BorderColor = System.Drawing.Color.LightGray;
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel2.Dock = DockStyle.Right;
            this.gradientPanel2.Controls.Add(this.label4);
            this.gradientPanel2.Controls.Add(this.label3);
            this.gradientPanel2.Controls.Add(this.label6);
            this.gradientPanel2.Controls.Add(this.checkBoxAdv1);
            this.gradientPanel2.Controls.Add(this.label1);
            this.gradientPanel2.Controls.Add(this.numericUpDownExt2);
            this.gradientPanel2.Controls.Add(this.numericUpDownExt1);
            this.gradientPanel2.Controls.Add(this.sfComboBox1);
            this.gradientPanel2.Location = new System.Drawing.Point(945, 4);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(320, 852);
            this.gradientPanel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(5, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Y-Coordinate";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(5, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "X-Coordinate";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(5, 96);
            this.label6.Name = "label3";
            this.label6.Size = new System.Drawing.Size(130, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Set Menu Location";
            this.label6.Visible = true;
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.BeforeTouchSize = new System.Drawing.Size(183, 19);
            this.checkBoxAdv1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.checkBoxAdv1.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBoxAdv1.Location = new System.Drawing.Point(139, 95);
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(23, 23);
            this.checkBoxAdv1.TabIndex = 2;
            this.checkBoxAdv1.ThemeName = "Office2019Colorful";
            this.checkBoxAdv1.CheckedChanged += CheckBoxAdv1_CheckedChanged;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose Theme";
            // 
            // numericUpDownExt2
            // 
            this.numericUpDownExt2.BeforeTouchSize = new System.Drawing.Size(170, 22);
            this.numericUpDownExt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt2.Location = new System.Drawing.Point(140, 253);
            this.numericUpDownExt2.Maximum = new decimal(new int[] {
            556,
            0,
            0,
            0});
            this.numericUpDownExt2.Name = "numericUpDownExt2";
            this.numericUpDownExt2.Size = new System.Drawing.Size(170, 22);
            this.numericUpDownExt2.TabIndex = 1;
            this.numericUpDownExt2.ThemeName = "Office2019Colorful";
            this.numericUpDownExt2.Enabled = false;
            this.numericUpDownExt2.ValueChanged += new System.EventHandler(this.numericUpDownExt2_ValueChanged);
            // 
            // numericUpDownExt1
            // 
            this.numericUpDownExt1.BeforeTouchSize = new System.Drawing.Size(170, 22);
            this.numericUpDownExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt1.Location = new System.Drawing.Point(140, 166);
            this.numericUpDownExt1.Maximum = new decimal(new int[] {
            572,
            0,
            0,
            0});
            this.numericUpDownExt1.Name = "numericUpDownExt1";
            this.numericUpDownExt1.Size = new System.Drawing.Size(170, 22);
            this.numericUpDownExt1.TabIndex = 1;
            this.numericUpDownExt1.ValueChanged += new System.EventHandler(this.numericUpDownExt1_ValueChanged);
            this.numericUpDownExt1.ThemeName = "Office2019Colorful";
            this.numericUpDownExt1.Enabled = false;
            // 
            // sfComboBox1
            // 
            this.sfComboBox1.AllowDropDownResize = false;
            this.sfComboBox1.Location = new System.Drawing.Point(140, 24);
            this.sfComboBox1.Name = "sfComboBox1";
            this.sfComboBox1.Size = new System.Drawing.Size(170, 28);
            this.sfComboBox1.TabIndex = 0;
            this.sfComboBox1.Text = "Office2019Colorful";
            this.sfComboBox1.ThemeName = "Office2019Colorful";
            this.sfComboBox1.SelectedIndexChanged += SfComboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 905);
            this.Controls.Add(this.gradientPanel2);
            this.Controls.Add(this.gradientPanel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Getting Started";
            this.popupControlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion

        private Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu popupMenu1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenusManager popupMenusManager1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem editBarItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem cutBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem copyBarItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem pasteBarItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem undoBarItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem redoBarItem5;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem newBarItem6;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem openBarItem7;
        private Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem fontColordropDownBarItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.TextBoxBarItem textBoxBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem exitBarItem8;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDownExt2;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDownExt1;
        private Syncfusion.WinForms.ListView.SfComboBox sfComboBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.PopupControlContainer popupControlContainer1;
        private Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv colorPickerUIAdv1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv1;
        private Label label4;
        private Label label3;
        private Label label6;
    }
}

