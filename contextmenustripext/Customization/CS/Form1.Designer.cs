#region Copyright Syncfusion Inc. 2001-2018.
//-------------------------------------------------------------------------------------------------
// <copyright file="Form1.Designer.cs" company="syncfusion">
//  Copyright (c) Syncfusion Inc. 2001 - 2019. All rights reserved.
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Re-distribution in any form is strictly
//  prohibited. Any infringement will be prosecuted under applicable laws. 
// </copyright>
//-------------------------------------------------------------------------------------------------
#endregion

namespace CustomizationDemo
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// Represents a class that is used to design the context menu.
    /// </summary>
    public partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Define the text in rich text box.
        /// </summary>
        private System.Windows.Forms.RichTextBox richTextBox1;

        /// <summary>
        /// Define the description.
        /// </summary>
        private System.Windows.Forms.Label label1;

        /// <summary>
        /// To add the controls into panel.
        /// </summary>
        private System.Windows.Forms.Panel panel1;

        /// <summary>
        /// To add the controls into panel.
        /// </summary>
        private System.Windows.Forms.Panel panel2;

        /// <summary>
        /// To add the controls into panel.
        /// </summary>
        private System.Windows.Forms.Panel panel3;

        /// <summary>
        /// To define the context menu control.
        /// </summary>
        private ContextMenuStripEx contextMenuStripEx1;

        /// <summary>
        /// Define the menu item inside the context menu.
        /// </summary>
        private ToolStripMenuItem toolStripMenuItem1;

        /// <summary>
        /// Define the menu item inside the context menu.
        /// </summary>
        private ToolStripMenuItem toolStripMenuItem2;

        /// <summary>
        /// Define the menu item inside the context menu.
        /// </summary>
        private ToolStripMenuItem toolStripMenuItem3;

        /// <summary>
        /// Define the separator inside the context menu.
        /// </summary>
        private ToolStripSeparator toolStripSeparator1;

        /// <summary>
        /// To add the different options into group box.
        /// </summary>
        private GroupBox groupBox1;

        /// <summary>
        /// Define the tooltip visibility.
        /// </summary>
        private CheckBoxAdv checkBoxAdv2;

        /// <summary>
        /// Define the auto close property.
        /// </summary>
        private CheckBoxAdv checkBoxAdv1;

        /// <summary>
        /// Enable or disable the menu item visibility.
        /// </summary>
        private CheckBoxAdv checkBoxAdv4;

        /// <summary>
        /// Check/uncheck the menu item option.
        /// </summary>
        private CheckBoxAdv checkBoxAdv3;

        /// <summary>
        /// Define the menu item inside the context menu.
        /// </summary>
        private ToolStripMenuItem toolStripMenuItem4;

        /// <summary>
        /// Define the menu item inside the context menu.
        /// </summary>
        private ToolStripMenuItem toolStripMenuItem5;

        /// <summary>
        /// Define the separator inside the context menu.
        /// </summary>
        private ToolStripSeparator toolStripSeparator2;

        /// <summary>
        /// Define the menu item inside the context menu.
        /// </summary>
        private ToolStripMenuItem toolStripMenuItem6;

        /// <summary>
        /// Define the fore color for context menu items.
        /// </summary>
        private ComboBoxAdv comboBoxAdv1;

        /// <summary>
        /// Define the content of fore color.
        /// </summary>
        private Label label2;

        /// <summary>
        /// Enable or disable the RTL option.
        /// </summary>
        private CheckBoxAdv checkBoxAdv5;

        /// <summary>
        /// Define the back color for context menu items.
        /// </summary>
        private ComboBoxAdv comboBoxAdv2;

        /// <summary>
        /// Define the content of back color.
        /// </summary>
        private Label label3;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStripEx1 = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxAdv2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxAdv5 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.checkBoxAdv4 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv3 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.panel3 = new System.Windows.Forms.Panel();
            this.contextMenuStripEx1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStripEx1;
            this.richTextBox1.Location = new System.Drawing.Point(13, 128);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(567, 558);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // contextMenuStripEx1
            // 
            this.contextMenuStripEx1.DropShadowEnabled = false;
            this.contextMenuStripEx1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripSeparator1,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripSeparator2,
            this.toolStripMenuItem6});
            this.contextMenuStripEx1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            this.contextMenuStripEx1.Name = "contextMenuStripEx1";
            this.contextMenuStripEx1.ShowItemToolTips = false;
            this.contextMenuStripEx1.Size = new System.Drawing.Size(279, 232);
            this.contextMenuStripEx1.Style = Syncfusion.Windows.Forms.Tools.ContextMenuStripEx.ContextMenuStyle.Metro;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(278, 36);
            this.toolStripMenuItem1.Text = "Cut";
            this.toolStripMenuItem1.ToolTipText = "Remove the selection and put it on the Clipboard so you can paste it somewhere el" +
    "se.";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(278, 36);
            this.toolStripMenuItem2.Text = "Copy";
            this.toolStripMenuItem2.ToolTipText = "Put a copy of the selection on the Clipboard so you can paste it somewhere else.";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(278, 36);
            this.toolStripMenuItem3.Text = "Paste                   ";
            this.toolStripMenuItem3.ToolTipText = "Pick a paste option such as keeping formatting or pasting only content.";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(275, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(278, 36);
            this.toolStripMenuItem4.Text = "Undo";
            this.toolStripMenuItem4.ToolTipText = "To reverse your last action, just click the Undo option.";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(278, 36);
            this.toolStripMenuItem5.Text = "Redo";
            this.toolStripMenuItem5.ToolTipText = "To reverse your last Undo, just click the Redo option.";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(275, 6);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(278, 36);
            this.toolStripMenuItem6.Text = "Exit";
            this.toolStripMenuItem6.ToolTipText = "Close the current context menu and back into the application.";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, -12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(978, 125);
            this.label1.TabIndex = 0;
            this.label1.Text = "This sample illustrates the additional features of ContextMenuStripEx such as aut" +
    "o close, tooltip, check/uncheck state, enable/disable menu items, RTL and appear" +
    "ance customization.";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 45);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Location = new System.Drawing.Point(2, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(980, 706);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxAdv2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkBoxAdv5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxAdv1);
            this.groupBox1.Controls.Add(this.checkBoxAdv4);
            this.groupBox1.Controls.Add(this.checkBoxAdv3);
            this.groupBox1.Controls.Add(this.checkBoxAdv2);
            this.groupBox1.Controls.Add(this.checkBoxAdv1);
            this.groupBox1.Location = new System.Drawing.Point(586, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 558);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // comboBoxAdv2
            // 
            this.comboBoxAdv2.BeforeTouchSize = new System.Drawing.Size(148, 44);
            this.comboBoxAdv2.Location = new System.Drawing.Point(36, 375);
            this.comboBoxAdv2.Name = "comboBoxAdv2";
            this.comboBoxAdv2.Size = new System.Drawing.Size(148, 44);
            this.comboBoxAdv2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Background Color";
            // 
            // checkBoxAdv5
            // 
            this.checkBoxAdv5.BeforeTouchSize = new System.Drawing.Size(259, 40);
            this.checkBoxAdv5.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBoxAdv5.Location = new System.Drawing.Point(30, 190);
            this.checkBoxAdv5.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.checkBoxAdv5.Name = "checkBoxAdv5";
            this.checkBoxAdv5.Size = new System.Drawing.Size(259, 40);
            this.checkBoxAdv5.TabIndex = 6;
            this.checkBoxAdv5.Text = "Enable RTL";
            this.checkBoxAdv5.ThemesEnabled = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Foreground Color";
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(148, 44);
            this.comboBoxAdv1.Location = new System.Drawing.Point(36, 279);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(148, 44);
            this.comboBoxAdv1.TabIndex = 4;
            // 
            // checkBoxAdv4
            // 
            this.checkBoxAdv4.BeforeTouchSize = new System.Drawing.Size(290, 43);
            this.checkBoxAdv4.Checked = true;
            this.checkBoxAdv4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv4.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBoxAdv4.Location = new System.Drawing.Point(30, 107);
            this.checkBoxAdv4.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.checkBoxAdv4.Name = "checkBoxAdv4";
            this.checkBoxAdv4.Size = new System.Drawing.Size(290, 43);
            this.checkBoxAdv4.TabIndex = 3;
            this.checkBoxAdv4.Text = "Enable Menu Items";
            this.checkBoxAdv4.ThemesEnabled = false;
            // 
            // checkBoxAdv3
            // 
            this.checkBoxAdv3.BeforeTouchSize = new System.Drawing.Size(290, 37);
            this.checkBoxAdv3.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBoxAdv3.Location = new System.Drawing.Point(30, 147);
            this.checkBoxAdv3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.checkBoxAdv3.Name = "checkBoxAdv3";
            this.checkBoxAdv3.Size = new System.Drawing.Size(290, 37);
            this.checkBoxAdv3.TabIndex = 2;
            this.checkBoxAdv3.Text = "Enable Check State";
            this.checkBoxAdv3.ThemesEnabled = false;
            // 
            // checkBoxAdv2
            // 
            this.checkBoxAdv2.BeforeTouchSize = new System.Drawing.Size(290, 45);
            this.checkBoxAdv2.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBoxAdv2.Location = new System.Drawing.Point(30, 70);
            this.checkBoxAdv2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.checkBoxAdv2.Name = "checkBoxAdv2";
            this.checkBoxAdv2.Size = new System.Drawing.Size(290, 45);
            this.checkBoxAdv2.TabIndex = 1;
            this.checkBoxAdv2.Text = "Show Tooltip";
            this.checkBoxAdv2.ThemesEnabled = false;
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.BeforeTouchSize = new System.Drawing.Size(290, 42);
            this.checkBoxAdv1.Checked = true;
            this.checkBoxAdv1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv1.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBoxAdv1.Location = new System.Drawing.Point(30, 30);
            this.checkBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(290, 42);
            this.checkBoxAdv1.TabIndex = 0;
            this.checkBoxAdv1.Text = "Auto Close";
            this.checkBoxAdv1.ThemesEnabled = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(980, 2);
            this.panel3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 800);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customization Demo";
            this.contextMenuStripEx1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            this.ResumeLayout(false);

        }

        private void CheckBoxAdv2_CheckedChanged(object sender, EventArgs e)
        {
            this.contextMenuStripEx1.ShowItemToolTips = (sender as Syncfusion.Windows.Forms.Tools.CheckBoxAdv).Checked;
        }

        private void CheckBoxAdv1_CheckedChanged(object sender, EventArgs e)
        {
            this.contextMenuStripEx1.AutoClose = (sender as Syncfusion.Windows.Forms.Tools.CheckBoxAdv).Checked;
            if (this.contextMenuStripEx1.AutoClose)
            {
                this.contextMenuStripEx1.Close();
            }
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
#if NETCORE
            this.toolStripMenuItem6.Image = new Bitmap(Image.FromFile(@"../../../Images/ExitIcon.png"));
            this.toolStripMenuItem6.Click += ToolStripMenuItem6_Click;
            this.toolStripMenuItem4.Image = new Bitmap(Image.FromFile(@"../../../Images/UndoIcon.png"));
            this.toolStripMenuItem4.Click += ToolStripMenuItem4_Click;
            this.toolStripMenuItem5.Image = new Bitmap(Image.FromFile(@"../../../Images/RedoIcon.png"));
            this.toolStripMenuItem5.Click += ToolStripMenuItem5_Click;
            this.toolStripMenuItem3.Image = new Bitmap(Image.FromFile(@"../../../Images/PasteHS.png"));
            this.toolStripMenuItem3.Click += ToolStripMenuItem3_Click;
            this.toolStripMenuItem2.Image = new Bitmap(Image.FromFile(@"../../../Images/CopyHS.png"));
            this.toolStripMenuItem2.Click += ToolStripMenuItem2_Click;
            this.toolStripMenuItem1.Image = new Bitmap(Image.FromFile(@"../../../Images/CutHS.png"));
#else
            this.toolStripMenuItem6.Image = new Bitmap(Image.FromFile(@"../../Images/ExitIcon.png"));
            this.toolStripMenuItem6.Click += ToolStripMenuItem6_Click;
            this.toolStripMenuItem4.Image = new Bitmap(Image.FromFile(@"../../Images/UndoIcon.png"));
            this.toolStripMenuItem4.Click += ToolStripMenuItem4_Click;
            this.toolStripMenuItem5.Image = new Bitmap(Image.FromFile(@"../../Images/RedoIcon.png"));
            this.toolStripMenuItem5.Click += ToolStripMenuItem5_Click;
            this.toolStripMenuItem3.Image = new Bitmap(Image.FromFile(@"../../Images/PasteHS.png"));
            this.toolStripMenuItem3.Click += ToolStripMenuItem3_Click;
            this.toolStripMenuItem2.Image = new Bitmap(Image.FromFile(@"../../Images/CopyHS.png"));
            this.toolStripMenuItem2.Click += ToolStripMenuItem2_Click;
            this.toolStripMenuItem1.Image = new Bitmap(Image.FromFile(@"../../Images/CutHS.png"));
#endif
            this.toolStripMenuItem1.Click += ToolStripMenuItem1_Click;
            this.checkBoxAdv1.CheckedChanged += CheckBoxAdv1_CheckedChanged;
            this.checkBoxAdv2.CheckedChanged += CheckBoxAdv2_CheckedChanged;
            this.checkBoxAdv3.CheckedChanged += CheckBoxAdv3_CheckedChanged;
            this.checkBoxAdv4.CheckedChanged += CheckBoxAdv4_CheckedChanged;
            this.checkBoxAdv5.CheckedChanged += CheckBoxAdv5_CheckedChanged;
            this.comboBoxAdv1.SelectedValueChanged += ComboBoxAdv1_SelectedValueChanged;
            this.comboBoxAdv2.SelectedValueChanged += ComboBoxAdv2_SelectedValueChanged;
            foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            {
                if (prop.PropertyType.FullName == "System.Drawing.Color")
                {
                    this.comboBoxAdv1.Items.Add(prop.Name);
                    this.comboBoxAdv2.Items.Add(prop.Name);
                }
            }
            this.comboBoxAdv1.SelectedText = "Black";
            this.comboBoxAdv2.SelectedText = "White";
        }

        private void ComboBoxAdv3_SelectedValueChanged(object sender, EventArgs e)
        {
            string font = (sender as ComboBoxAdv).SelectedItem.ToString();
            this.contextMenuStripEx1.Font = new Font(font, 9);
        }

        private void ComboBoxAdv2_SelectedValueChanged(object sender, EventArgs e)
        {
            this.contextMenuStripEx1.RenderMode = ToolStripRenderMode.System;
            string color = (sender as ComboBoxAdv).SelectedItem.ToString();
            this.contextMenuStripEx1.BackColor = Color.FromName(color);
        }

        private void CheckBoxAdv5_CheckedChanged(object sender, EventArgs e)
        {
            bool isRTL = (sender as Syncfusion.Windows.Forms.Tools.CheckBoxAdv).Checked;
            this.contextMenuStripEx1.RightToLeft = isRTL ? RightToLeft.Yes : RightToLeft.No;
            string path = Application.StartupPath.ToString() + @"..\..\..\Introduction.rtf";
            if (File.Exists(path))
            {
                this.richTextBox1.LoadFile(path, RichTextBoxStreamType.RichText);
            }
        }

        private void ComboBoxAdv1_SelectedValueChanged(object sender, EventArgs e)
        {
            string color = (sender as ComboBoxAdv).SelectedItem.ToString();
            this.contextMenuStripEx1.ForeColor = Color.FromName(color);
        }

        private void ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            this.contextMenuStripEx1.Close();
        }

        private void CheckBoxAdv4_CheckedChanged(object sender, EventArgs e)
        {
             this.toolStripMenuItem4.Enabled = this.toolStripMenuItem5.Enabled =  (sender as Syncfusion.Windows.Forms.Tools.CheckBoxAdv).Checked;
        }

        private void CheckBoxAdv3_CheckedChanged(object sender, EventArgs e)
        {
            this.contextMenuStripEx1.ShowCheckMargin = (sender as Syncfusion.Windows.Forms.Tools.CheckBoxAdv).Checked;
            if (!this.checkBoxAdv3.Checked)
            {
                this.toolStripMenuItem1.Checked = false;
                this.toolStripMenuItem2.Checked = false;
                this.toolStripMenuItem3.Checked = false;
                this.toolStripMenuItem4.Checked = false;
                this.toolStripMenuItem5.Checked = false;
            }
        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Undo();
            if (this.checkBoxAdv3.Checked)
            {
                this.toolStripMenuItem1.Checked = false;
                this.toolStripMenuItem2.Checked = false;
                this.toolStripMenuItem3.Checked = false;
                this.toolStripMenuItem4.Checked = true;
                this.toolStripMenuItem5.Checked = false;
            }
        }

        private void ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Redo();
            if (this.checkBoxAdv3.Checked)
            {
                this.toolStripMenuItem1.Checked = false;
                this.toolStripMenuItem2.Checked = false;
                this.toolStripMenuItem3.Checked = false;
                this.toolStripMenuItem4.Checked = false;
                this.toolStripMenuItem5.Checked = true;
            }
        }

        private void ToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            this.richTextBox1.Cut();
            if (this.checkBoxAdv3.Checked)
            {
                this.toolStripMenuItem1.Checked = true;
                this.toolStripMenuItem2.Checked = false;
                this.toolStripMenuItem3.Checked = false;
                this.toolStripMenuItem4.Checked = false;
                this.toolStripMenuItem5.Checked = false;
            }
        }

        private void ToolStripMenuItem3_Click(object sender, System.EventArgs e)
        {
            this.richTextBox1.Paste();
            if (this.checkBoxAdv3.Checked)
            {
                this.toolStripMenuItem1.Checked = false;
                this.toolStripMenuItem2.Checked = false;
                this.toolStripMenuItem3.Checked = true;
                this.toolStripMenuItem4.Checked = false;
                this.toolStripMenuItem5.Checked = false;
            }
        }

        private void ToolStripMenuItem2_Click(object sender, System.EventArgs e)
        {
            this.richTextBox1.Copy();
            if (this.checkBoxAdv3.Checked)
            {
                this.toolStripMenuItem1.Checked = false;
                this.toolStripMenuItem2.Checked = true;
                this.toolStripMenuItem3.Checked = false;
                this.toolStripMenuItem4.Checked = false;
                this.toolStripMenuItem5.Checked = false;
            }
        }

#endregion
    }
}