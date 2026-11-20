#region Copyright Syncfusion Inc. 2001-2018.
//-------------------------------------------------------------------------------------------------
// <copyright file="Form1.cs" company="syncfusion">
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
    using Syncfusion.Windows.Forms.Tools;
    using Syncfusion.WinForms.Controls;
    using System;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    /// <summary>
    /// Represents a class that is used to design the context menu.
    /// </summary>
    public partial class Form1 : SfForm
    {
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
            this.toolStripMenuItem3.Image = new Bitmap(Image.FromFile(@"Images/PasteHS.png"));
            this.toolStripMenuItem3.Click += ToolStripMenuItem3_Click;
            this.toolStripMenuItem2.Image = new Bitmap(Image.FromFile(@"Images/CopyHS.png"));
            this.toolStripMenuItem2.Click += ToolStripMenuItem2_Click;
            this.toolStripMenuItem1.Image = new Bitmap(Image.FromFile(@"Images/CutHS.png"));
            this.toolStripMenuItem1.Click += ToolStripMenuItem1_Click;
            this.toolStripMenuItem4.Image = new Bitmap(Image.FromFile(@"Images/ExitIcon.png"));
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
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();
#if NETCORE
            Bitmap bmp = new Bitmap(Image.FromFile(@"Images/App.ico"));
#else
            Bitmap bmp = new Bitmap(Image.FromFile(@"Images/App.ico"));
#endif
            this.Icon = Icon.FromHandle(bmp.GetHicon());
            this.Load += this.Form1_Load;
            this.comboBoxAdv1.Location = new Point(this.label2.Bounds.X + this.label2.Width, this.label2.Bounds.Y);
            this.panel2.Location = new Point(this.label1.Bounds.X, this.label1.Bounds.Y + this.label1.Height);
        }
    }
}
