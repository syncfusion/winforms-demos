#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GettingStarted
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.PropertiesPanel = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.groupBar1 = new Syncfusion.Windows.Forms.Tools.GroupBar();
            this.panel14 = new System.Windows.Forms.Panel();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.RTLCkBox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.ThemeCmb = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.groupBarItem2 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.fontComboBox = new Syncfusion.Windows.Forms.Tools.FontComboBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel9.SuspendLayout();
            this.PropertiesPanel.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).BeginInit();
            this.groupBar1.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTLCkBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThemeCmb)).BeginInit();
            this.panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 10);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 675);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1050, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 675);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 659);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(911, 2);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 675);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(12, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1038, 2);
            this.panel6.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(1048, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(2, 673);
            this.panel7.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(12, 682);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1036, 3);
            this.panel8.TabIndex = 7;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label7);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(12, 12);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1036, 40);
            this.panel9.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(9, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(808, 34);
            this.label7.TabIndex = 0;
            this.label7.Text = "This sample illustrates the display of font family inside a combobox along with o" +
    "ptions to change its visual style and the font name with its symbol.";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(12, 52);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1036, 2);
            this.panel10.TabIndex = 9;
            // 
            // PropertiesPanel
            // 
            this.PropertiesPanel.Controls.Add(this.panel11);
            this.PropertiesPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.PropertiesPanel.Location = new System.Drawing.Point(679, 54);
            this.PropertiesPanel.Name = "PropertiesPanel";
            this.PropertiesPanel.Size = new System.Drawing.Size(369, 628);
            this.PropertiesPanel.TabIndex = 10;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.groupBar1);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(20);
            this.panel11.Size = new System.Drawing.Size(369, 628);
            this.panel11.TabIndex = 0;
            // 
            // groupBar1
            // 
            this.groupBar1.AllowDrop = true;
            this.groupBar1.BackColor = Color.White;
            this.groupBar1.BeforeTouchSize = new System.Drawing.Size(329, 588);
            this.groupBar1.BorderColor = System.Drawing.Color.White;
            this.groupBar1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupBar1.CollapseImage = ((System.Drawing.Image)(resources.GetObject("groupBar1.CollapseImage")));
            this.groupBar1.Controls.Add(this.panel14);
            this.groupBar1.Controls.Add(this.panel13);
            this.groupBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBar1.ExpandButtonToolTip = null;
            this.groupBar1.ExpandImage = ((System.Drawing.Image)(resources.GetObject("groupBar1.ExpandImage")));
            this.groupBar1.FlatLook = true;
            this.groupBar1.ForeColor = System.Drawing.Color.White;
            this.groupBar1.GroupBarDropDownToolTip = null;
            this.groupBar1.GroupBarItemHeight = 30;
            this.groupBar1.GroupBarItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupBarItem[] {
            this.groupBarItem2});
            this.groupBar1.IndexOnVisibleItems = true;
            this.groupBar1.Location = new System.Drawing.Point(20, 20);
            this.groupBar1.MinimizeButtonToolTip = null;
            this.groupBar1.Name = "groupBar1";
            this.groupBar1.NavigationPaneTooltip = null;
            this.groupBar1.Padding = new System.Windows.Forms.Padding(50);
            this.groupBar1.PopupClientSize = new System.Drawing.Size(0, 0);
            this.groupBar1.SelectedItem = 0;
            this.groupBar1.Size = new System.Drawing.Size(329, 588);
            this.groupBar1.SmartSizeBox = false;
            this.groupBar1.Splittercolor = System.Drawing.Color.Red;
            this.groupBar1.TabIndex = 0;
            this.groupBar1.Text = "groupBar1";
            // 
            // panel14
            // 
            this.panel14.AutoScroll = true;
            this.panel14.BackColor = Color.White;
            this.panel14.Controls.Add(this.checkBoxAdv1);
            this.panel14.Controls.Add(this.label2);
            this.panel14.Controls.Add(this.label14);
            this.panel14.Controls.Add(this.RTLCkBox);
            this.panel14.Controls.Add(this.ThemeCmb);
            this.panel14.Controls.Add(this.label1);
            this.panel14.Location = new System.Drawing.Point(0, 30);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(329, 558);
            this.panel14.TabIndex = 1;
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.BeforeTouchSize = new System.Drawing.Size(95, 15);
            this.checkBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv1.ForeColor = System.Drawing.Color.Black;
            this.checkBoxAdv1.Location = new System.Drawing.Point(119, 70);
            this.checkBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(95, 15);
            this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv1.TabIndex = 10;
            this.checkBoxAdv1.ThemeName = "Metro";
            this.checkBoxAdv1.ThemesEnabled = false;
            this.checkBoxAdv1.CheckStateChanged += new System.EventHandler(this.CheckBoxAdv1_CheckStateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Show symbol";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(16, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 15);
            this.label14.TabIndex = 23;
            this.label14.Text = "Right-to-left";
            // 
            // RTLCkBox
            // 
            this.RTLCkBox.BeforeTouchSize = new System.Drawing.Size(95, 15);
            this.RTLCkBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTLCkBox.ForeColor = System.Drawing.Color.Black;
            this.RTLCkBox.Location = new System.Drawing.Point(119, 113);
            this.RTLCkBox.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.RTLCkBox.Name = "RTLCkBox";
            this.RTLCkBox.Size = new System.Drawing.Size(95, 15);
            this.RTLCkBox.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.RTLCkBox.TabIndex = 10;
            this.RTLCkBox.ThemeName = "Metro";
            this.RTLCkBox.ThemesEnabled = false;
            this.RTLCkBox.CheckStateChanged += new System.EventHandler(this.RTLCkBox_CheckStateChanged);
            // 
            // ThemeCmb
            // 
            this.ThemeCmb.BeforeTouchSize = new System.Drawing.Size(170, 23);
            this.ThemeCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ThemeCmb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemeCmb.Items.AddRange(new object[] {
            "Office2016Colorful",
            "Office2016White",
            "Office2016Black",
            "Office2016DarkGray"});
            this.ThemeCmb.Location = new System.Drawing.Point(119, 21);
            this.ThemeCmb.Name = "ThemeCmb";
            this.ThemeCmb.Size = new System.Drawing.Size(170, 23);
            this.ThemeCmb.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.ThemeCmb.TabIndex = 3;
            this.ThemeCmb.Text = "Office2016Colorful";
            this.ThemeCmb.SelectedIndexChanged += ThemeCmb_SelectedIndexChanged;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Themes";
            // 
            // panel13
            // 
            this.panel13.Location = new System.Drawing.Point(1, 31);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(339, 0);
            this.panel13.TabIndex = 0;
            // 
            // groupBarItem2
            // 
            this.groupBarItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBarItem2.Client = this.panel14;
            this.groupBarItem2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBarItem2.ForeColor = System.Drawing.Color.Black;
            this.groupBarItem2.Text = "Settings";
            // 
            // fontComboBox
            // 
            this.fontComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fontComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.fontComboBox.IntegralHeight = false;
            this.fontComboBox.ItemHeight = 20;
            this.fontComboBox.Location = new System.Drawing.Point(402, 14);
            this.fontComboBox.MaxDropDownItems = 10;
            this.fontComboBox.Name = "fontComboBox";
            this.fontComboBox.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.fontComboBox.ShowSymbolFontPreview = false;
            this.fontComboBox.Size = new System.Drawing.Size(248, 26);
            this.fontComboBox.Sorted = true;
            this.fontComboBox.TabIndex = 0;
            this.fontComboBox.UseAutoComplete = true;
            this.fontComboBox.SelectedItem = "Arial";
            this.fontComboBox.VisualStyle = Syncfusion.Windows.Forms.Tools.ThemedComboBoxStyles.Office2016Colorful;
            this.fontComboBox.SelectedIndexChanged += new System.EventHandler(this.FontComboBox_SelectedIndexChanged);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.panel12.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel12.Location = new System.Drawing.Point(677, 54);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(2, 628);
            this.panel12.TabIndex = 11;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.label4);
            this.panel15.Controls.Add(this.richTextBox1);
            this.panel15.Controls.Add(this.fontComboBox);
            this.panel15.Location = new System.Drawing.Point(18, 60);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(653, 613);
            this.panel15.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(308, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Choose Font";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 65);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(644, 537);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(30);
            this.CaptionFont = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.CaptionForeColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1060, 685);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.PropertiesPanel);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Getting Started";
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.PropertiesPanel.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).EndInit();
            this.groupBar1.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTLCkBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThemeCmb)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.ResumeLayout(false);
            this.Load += Form1_Load;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                this.richTextBox1.LoadFile(path, RichTextBoxStreamType.RichText);
            }
        }

        #endregion

        #region 
        private void CheckBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxAdv1.Checked)
            {
                fontComboBox.ShowSymbolFontPreview = true;
            }
            else
                fontComboBox.ShowSymbolFontPreview = false;
        }

        private void RTLCkBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (RTLCkBox.Checked)
                fontComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            else
                fontComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
        }

        private void ThemeCmb_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.ThemeCmb.SelectedItem.ToString() == "Office2016Colorful")
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                this.groupBarItem2.BackColor = ColorTranslator.FromHtml("#ebebeb");
                this.groupBarItem2.ForeColor = Color.Black;
                this.groupBar1.BackColor = Color.White;
                this.panel13.BackColor = Color.White;
                this.panel14.BackColor = Color.White;
                this.label2.ForeColor = Color.Black;
                this.label1.ForeColor = Color.Black;
                this.label4.ForeColor = Color.Black;
                this.label7.ForeColor = Color.Black;
                this.label14.ForeColor = Color.Black;
                this.CaptionBarColor = Color.White;
                this.CaptionForeColor = Color.Black;
                this.PropertiesPanel.BackColor = Color.White;
                this.richTextBox1.ForeColor = Color.Black;
                this.richTextBox1.BackColor = Color.White;
                this.ThemeCmb.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
                this.fontComboBox.VisualStyle = Syncfusion.Windows.Forms.Tools.ThemedComboBoxStyles.Office2016Colorful;
#if NETCORE
                this.richTextBox1.Select(this.richTextBox1.GetFirstCharIndexFromLine(0), this.richTextBox1.Lines[0].Length);
                this.richTextBox1.SelectionBackColor = ColorTranslator.FromHtml("#FFFFFF");
#endif
            }
            else if (this.ThemeCmb.SelectedItem.ToString() == "Office2016DarkGray")
            {
                this.BackColor = ColorTranslator.FromHtml("#666666");
                this.ForeColor = Color.Black;
                this.groupBarItem2.BackColor = Color.Gray;
                this.groupBarItem2.ForeColor = Color.Black;
                this.groupBar1.BackColor = ColorTranslator.FromHtml("#666666");
                this.panel13.BackColor = ColorTranslator.FromHtml("#666666");
                this.panel14.BackColor = ColorTranslator.FromHtml("#666666");
                this.label2.ForeColor = Color.Black;
                this.label1.ForeColor = Color.Black;
                this.label4.ForeColor = Color.Black;
                this.label7.ForeColor = Color.Black;
                this.label14.ForeColor = Color.Black;
                this.CaptionBarColor = ColorTranslator.FromHtml("#666666");
                this.CaptionForeColor = Color.Black;
                this.PropertiesPanel.BackColor = Color.Black;
                this.richTextBox1.ForeColor = Color.Black;
                this.richTextBox1.BackColor = ColorTranslator.FromHtml("#666666");
                this.ThemeCmb.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016DarkGray;
                this.fontComboBox.VisualStyle = Syncfusion.Windows.Forms.Tools.ThemedComboBoxStyles.Office2016DarkGray;
#if NETCORE
                this.richTextBox1.Select(this.richTextBox1.GetFirstCharIndexFromLine(0), this.richTextBox1.Lines[0].Length);
                this.richTextBox1.SelectionBackColor = ColorTranslator.FromHtml("#666666");
#endif
            }
            else if (this.ThemeCmb.SelectedItem.ToString() == "Office2016White")
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                this.groupBarItem2.BackColor = ColorTranslator.FromHtml("#ebebeb");
                this.groupBarItem2.ForeColor = Color.Black;
                this.groupBar1.BackColor = Color.White;
                this.panel13.BackColor = Color.White;
                this.panel14.BackColor = Color.White;
                this.label2.ForeColor = Color.Black;
                this.label1.ForeColor = Color.Black;
                this.label4.ForeColor = Color.Black;
                this.label7.ForeColor = Color.Black;
                this.label14.ForeColor = Color.Black;
                this.CaptionBarColor = Color.White;
                this.CaptionForeColor = Color.Black;
                this.PropertiesPanel.BackColor = Color.White;
                this.richTextBox1.ForeColor = Color.Black;
                this.richTextBox1.BackColor = Color.White;
                this.ThemeCmb.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016White;
                this.fontComboBox.VisualStyle = Syncfusion.Windows.Forms.Tools.ThemedComboBoxStyles.Office2016White;
#if NETCORE
                this.richTextBox1.Select(this.richTextBox1.GetFirstCharIndexFromLine(0), this.richTextBox1.Lines[0].Length);
                this.richTextBox1.SelectionBackColor = ColorTranslator.FromHtml("#FFFFFF");
#endif

            }
            else if (this.ThemeCmb.SelectedItem.ToString() == "Office2016Black")
            {
                this.BackColor = ColorTranslator.FromHtml("#252525");
                this.ForeColor = Color.White;
                this.groupBarItem2.BackColor= ColorTranslator.FromHtml("#a0a0a0");
                this.groupBarItem2.ForeColor = Color.White;
                this.groupBar1.BackColor = ColorTranslator.FromHtml("#252525");
                this.panel13.BackColor = ColorTranslator.FromHtml("#252525");
                this.panel14.BackColor = ColorTranslator.FromHtml("#252525");
                this.label2.ForeColor = Color.White;
                this.label1.ForeColor = Color.White;
                this.label4.ForeColor = Color.White;
                this.label7.ForeColor = Color.White;
                this.label14.ForeColor = Color.White;
                this.CaptionBarColor= ColorTranslator.FromHtml("#252525");
                this.CaptionForeColor = Color.White;
                this.PropertiesPanel.BackColor = Color.Black;
                this.richTextBox1.ForeColor = Color.White;
                this.richTextBox1.BackColor = ColorTranslator.FromHtml("#252525");
#if NETCORE
                this.richTextBox1.Select(this.richTextBox1.GetFirstCharIndexFromLine(0), this.richTextBox1.Lines[0].Length);
                this.richTextBox1.SelectionBackColor = ColorTranslator.FromHtml("#252525");
#endif
                this.ThemeCmb.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Black;
                this.fontComboBox.VisualStyle = Syncfusion.Windows.Forms.Tools.ThemedComboBoxStyles.Office2016Black;
            }
        }

        private void FontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.fontComboBox.SelectedItem.ToString() != null)
            {
                this.richTextBox1.Font = new Font(this.fontComboBox.SelectedItem.ToString(), 10);
            }
        }

        #endregion

        string path = Application.StartupPath.ToString() + @"..\..\..\Introduction.rtf";
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel PropertiesPanel;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private Syncfusion.Windows.Forms.Tools.GroupBar groupBar1;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem2;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv RTLCkBox;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv ThemeCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv1;
        private Syncfusion.Windows.Forms.Tools.FontComboBox fontComboBox;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
    }
}

