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

namespace GettingStarted
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
        /// Define the content for theme selection.
        /// </summary>
        private System.Windows.Forms.Label label2;

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
        /// Define the built-in context menu styles.
        /// </summary>
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;

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
        /// Define the font family text as text box menu item inside the context menu.
        /// </summary>
        private ToolStripTextBox toolStripTextBox1;

        /// <summary>
        /// Define the font family list inside the context menu.
        /// </summary>
        private ToolStripComboBox toolStripComboBox1;

        /// <summary>
        /// Define the separator inside the context menu.
        /// </summary>
        private ToolStripSeparator toolStripSeparator2;

        /// <summary>
        /// Define the menu item inside the context menu.
        /// </summary>
        private ToolStripMenuItem toolStripMenuItem4;

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
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.contextMenuStripEx1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStripEx1;
            this.richTextBox1.Location = new System.Drawing.Point(30, 71);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(931, 507);
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
            this.toolStripTextBox1,
            this.toolStripComboBox1,
            this.toolStripSeparator2,
            this.toolStripMenuItem4});
            this.contextMenuStripEx1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            this.contextMenuStripEx1.Name = "contextMenuStripEx1";
            this.contextMenuStripEx1.Size = new System.Drawing.Size(182, 183);
            this.contextMenuStripEx1.Style = Syncfusion.Windows.Forms.Tools.ContextMenuStripEx.ContextMenuStyle.Metro;
            this.contextMenuStripEx1.Text = "Edit";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem1.Text = "Cut";
            this.toolStripMenuItem1.ToolTipText = "Remove the selection and put it on the Clipboard so you can paste it somewhere el" +
                                                  "se.";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem2.Text = "Copy";
            this.toolStripMenuItem2.ToolTipText = "Put a copy of the selection on the Clipboard so you can paste it somewhere else.";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem3.Text = "Paste";
            this.toolStripMenuItem3.ToolTipText = "Pick a paste option such as keeping formatting or pasting only content.";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Margin = new System.Windows.Forms.Padding(2, 1, 1, 1);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "Font Family: ";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.ToolTipText = "Pick a new font for your text";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem4.Text = "Exit";
            this.toolStripMenuItem4.ToolTipText = "Close the current context menu and back into the application.";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(912, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "This sample showcases ContextMenuStripEx control with bar items, separator and built -in context menu styles.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(550, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choose Theme";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 34);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.comboBoxAdv1);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(2, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(970, 604);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(970, 2);
            this.panel3.TabIndex = 2;
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(182, 25);
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Default",
            "Metro",
            "Office2016Colorful",
            "Office2016White",
            "Office2016DarkGray",
            "Office2016Black"});
            this.comboBoxAdv1.Location = new System.Drawing.Point(668, 21);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(182, 25);
            this.comboBoxAdv1.TabIndex = 2;
            this.comboBoxAdv1.Text = "Metro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 686);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 725);
            this.MinimumSize = new System.Drawing.Size(1000, 725);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Getting Started";
            this.contextMenuStripEx1.ResumeLayout(false);
            this.contextMenuStripEx1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            this.ResumeLayout(false);

        }

        private void ComboBoxAdv1_SelectedValueChanged(object sender, System.EventArgs e)
        {
            string style = (sender as ComboBoxAdv).SelectedItem.ToString();
            switch (style)
            {
                case "Metro":
                    this.BackColor = Color.White;
                    this.ForeColor = Color.Black;
                    this.label2.ForeColor = Color.Black;
                    this.richTextBox1.ForeColor = Color.Black;
                    this.richTextBox1.BackColor = Color.White;
                    this.Style.TitleBar.ForeColor = this.Style.TitleBar.CloseButtonForeColor = this.Style.TitleBar.MinimizeButtonForeColor = this.Style.TitleBar.MaximizeButtonForeColor = Color.Black;
                    this.Style.TitleBar.BackColor = Color.FromArgb(242, 242, 242);
                    this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
                    this.contextMenuStripEx1.Style = Syncfusion.Windows.Forms.Tools.ContextMenuStripEx.ContextMenuStyle.Metro;
                    break;
                case "Default":
                    this.BackColor = Color.White;
                    this.ForeColor = Color.Black;
                    this.label2.ForeColor = Color.Black;
                    this.richTextBox1.ForeColor = Color.Black;
                    this.richTextBox1.BackColor = Color.White;
                    this.Style.TitleBar.ForeColor = this.Style.TitleBar.CloseButtonForeColor = this.Style.TitleBar.MinimizeButtonForeColor = this.Style.TitleBar.MaximizeButtonForeColor = Color.Black;
                    this.Style.TitleBar.BackColor = Color.FromArgb(242, 242, 242);
                    this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Default;
                    this.contextMenuStripEx1.Style = Syncfusion.Windows.Forms.Tools.ContextMenuStripEx.ContextMenuStyle.Default;
                    break;
                case "Office2016Colorful":
                    this.BackColor = Color.White;
                    this.ForeColor = Color.Black;
                    this.richTextBox1.ForeColor = Color.Black;
                    this.richTextBox1.BackColor = Color.White;
                    this.label2.ForeColor = Color.Black;
                    this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
                    this.Style.TitleBar.ForeColor = this.Style.TitleBar.CloseButtonForeColor = this.Style.TitleBar.MinimizeButtonForeColor = this.Style.TitleBar.MaximizeButtonForeColor = Color.Black;
                    this.Style.TitleBar.BackColor = Color.FromArgb(242, 242, 242);
                    this.contextMenuStripEx1.Style = Syncfusion.Windows.Forms.Tools.ContextMenuStripEx.ContextMenuStyle.Office2016Colorful;
                    break;
                case "Office2016White":
                    this.BackColor = Color.White;
                    this.ForeColor = Color.Black;
                    this.label2.ForeColor = Color.Black;
                    this.richTextBox1.ForeColor = Color.Black;
                    this.richTextBox1.BackColor = Color.White;
                    this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016White;
                    this.Style.TitleBar.ForeColor = this.Style.TitleBar.CloseButtonForeColor = this.Style.TitleBar.MinimizeButtonForeColor = this.Style.TitleBar.MaximizeButtonForeColor = Color.Black;
                    this.Style.TitleBar.BackColor = Color.FromArgb(242, 242, 242);
                    this.contextMenuStripEx1.Style = Syncfusion.Windows.Forms.Tools.ContextMenuStripEx.ContextMenuStyle.Office2016White;
                    break;
                case "Office2016DarkGray":
                    this.contextMenuStripEx1.Style = Syncfusion.Windows.Forms.Tools.ContextMenuStripEx.ContextMenuStyle.Office2016DarkGray;
                    this.BackColor = ColorTranslator.FromHtml("#666666");
                    this.ForeColor = Color.Black;
                    this.label2.ForeColor = Color.White;
                    this.richTextBox1.ForeColor = Color.Black;
                    this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016DarkGray;
                    this.richTextBox1.BackColor = ColorTranslator.FromHtml("#666666");
                    this.label2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.Style.TitleBar.ForeColor = this.Style.TitleBar.CloseButtonForeColor = this.Style.TitleBar.MinimizeButtonForeColor = this.Style.TitleBar.MaximizeButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.Style.TitleBar.BackColor = ColorTranslator.FromHtml("#505050");
                    break;
                case "Office2016Black":
                    this.BackColor = ColorTranslator.FromHtml("#252525");
                    this.ForeColor = Color.White;
                    this.label2.ForeColor = Color.White;
                    this.richTextBox1.ForeColor = Color.White;
                    this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Black;
                    this.richTextBox1.BackColor = ColorTranslator.FromHtml("#252525");
                    this.Style.TitleBar.ForeColor = this.Style.TitleBar.CloseButtonForeColor = this.Style.TitleBar.MinimizeButtonForeColor = this.Style.TitleBar.MaximizeButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.Style.TitleBar.BackColor = ColorTranslator.FromHtml("#363636");
                    this.contextMenuStripEx1.Style = Syncfusion.Windows.Forms.Tools.ContextMenuStripEx.ContextMenuStyle.Office2016Black;
                    break;
                default:
                    this.BackColor = Color.White;
                    this.ForeColor = Color.Black;
                    this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Default;
                    this.label2.ForeColor = Color.Black;
                    this.richTextBox1.ForeColor = Color.Black;
                    this.richTextBox1.BackColor = Color.White;
                    this.Style.TitleBar.ForeColor = this.Style.TitleBar.CloseButtonForeColor = this.Style.TitleBar.MinimizeButtonForeColor = this.Style.TitleBar.MaximizeButtonForeColor = Color.Black;
                    this.Style.TitleBar.BackColor = Color.FromArgb(242, 242, 242);
                    this.contextMenuStripEx1.Style = Syncfusion.Windows.Forms.Tools.ContextMenuStripEx.ContextMenuStyle.Metro;
                    break;
            }
        }

        private void ToolStripComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string font = (sender as System.Windows.Forms.ToolStripComboBox).SelectedItem.ToString();
            if (this.richTextBox1.SelectedText == string.Empty)
            {
                this.richTextBox1.Font = new Font(font, 10);
            }
            else
            {
                this.richTextBox1.SelectionFont = new Font(font, 10);
            }
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
#if NETCORE
            this.richTextBox1.SelectionChanged += RichTextBox1_SelectionChanged;
            this.comboBoxAdv1.SelectedValueChanged += ComboBoxAdv1_SelectedValueChanged;
            this.toolStripComboBox1.SelectedIndexChanged += ToolStripComboBox1_SelectedIndexChanged;
            this.toolStripMenuItem3.Image = new Bitmap(Image.FromFile(@"../../../Images/PasteHS.png"));
            this.toolStripMenuItem3.Click += ToolStripMenuItem3_Click;
            this.toolStripMenuItem2.Image = new Bitmap(Image.FromFile(@"../../../Images/CopyHS.png"));
            this.toolStripMenuItem2.Click += ToolStripMenuItem2_Click;
            this.toolStripMenuItem1.Image = new Bitmap(Image.FromFile(@"../../../Images/CutHS.png"));
            this.toolStripMenuItem1.Click += ToolStripMenuItem1_Click;
            this.toolStripMenuItem4.Image = new Bitmap(Image.FromFile(@"../../../Images/ExitIcon.png"));
            this.toolStripMenuItem4.Click += ToolStripMenuItem4_Click;
            this.UpdateMenuItems();
            foreach (FontFamily family in FontFamily.Families)
            {
                this.toolStripComboBox1.Items.Add(family.Name);
            }
            this.toolStripComboBox1.SelectedItem = "Verdana";
            string path = Application.StartupPath.ToString() + @"..\..\..\..\Introduction.rtf";
            if (File.Exists(path))
            {
                this.richTextBox1.LoadFile(path, RichTextBoxStreamType.RichText);
            }
#else
            this.richTextBox1.SelectionChanged += RichTextBox1_SelectionChanged;
            this.comboBoxAdv1.SelectedValueChanged += ComboBoxAdv1_SelectedValueChanged;
            this.toolStripComboBox1.SelectedIndexChanged += ToolStripComboBox1_SelectedIndexChanged;
            this.toolStripMenuItem3.Image = new Bitmap(Image.FromFile(@"../../Images/PasteHS.png"));
            this.toolStripMenuItem3.Click += ToolStripMenuItem3_Click;
            this.toolStripMenuItem2.Image = new Bitmap(Image.FromFile(@"../../Images/CopyHS.png"));
            this.toolStripMenuItem2.Click += ToolStripMenuItem2_Click;
            this.toolStripMenuItem1.Image = new Bitmap(Image.FromFile(@"../../Images/CutHS.png"));
            this.toolStripMenuItem1.Click += ToolStripMenuItem1_Click;
            this.toolStripMenuItem4.Image = new Bitmap(Image.FromFile(@"../../Images/ExitIcon.png"));
            this.toolStripMenuItem4.Click += ToolStripMenuItem4_Click;
            this.UpdateMenuItems();
            foreach (FontFamily family in FontFamily.Families)
            {
                this.toolStripComboBox1.Items.Add(family.Name);
            }
            this.toolStripComboBox1.SelectedItem = "Verdana";
            string path = Application.StartupPath.ToString() + @"..\..\..\Introduction.rtf";
            if (File.Exists(path))
            {
                this.richTextBox1.LoadFile(path, RichTextBoxStreamType.RichText);
            }
#endif
        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.contextMenuStripEx1.Close();
        }

        private void RichTextBox1_SelectionChanged(object sender, System.EventArgs e)
        {
            this.UpdateMenuItems();
        }

        private void ToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            this.richTextBox1.Cut();
        }

        private void ToolStripMenuItem3_Click(object sender, System.EventArgs e)
        {
            this.richTextBox1.Paste();
        }

        private void ToolStripMenuItem2_Click(object sender, System.EventArgs e)
        {
            this.richTextBox1.Copy();
        }

        private void UpdateMenuItems()
        {
            if (this.richTextBox1.SelectedText.Length > 0)
            {
                this.toolStripMenuItem2.Enabled = true;
                this.toolStripMenuItem1.Enabled = true;
            }
            else
            {
                this.toolStripMenuItem2.Enabled = false;
                this.toolStripMenuItem1.Enabled = false;
            }
        }

#endregion
    }
}