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

namespace CustomizationDemo
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
            this.toolStripMenuItem6.Image = new Bitmap(Image.FromFile(@"Images/ExitIcon.png"));
            this.toolStripMenuItem6.Click += ToolStripMenuItem6_Click;
            this.toolStripMenuItem4.Image = new Bitmap(Image.FromFile(@"Images/UndoIcon.png"));
            this.toolStripMenuItem4.Click += ToolStripMenuItem4_Click;
            this.toolStripMenuItem5.Image = new Bitmap(Image.FromFile(@"Images/RedoIcon.png"));
            this.toolStripMenuItem5.Click += ToolStripMenuItem5_Click;
            this.toolStripMenuItem3.Image = new Bitmap(Image.FromFile(@"Images/PasteHS.png"));
            this.toolStripMenuItem3.Click += ToolStripMenuItem3_Click;
            this.toolStripMenuItem2.Image = new Bitmap(Image.FromFile(@"Images/CopyHS.png"));
            this.toolStripMenuItem2.Click += ToolStripMenuItem2_Click;
            this.toolStripMenuItem1.Image = new Bitmap(Image.FromFile(@"Images/CutHS.png"));
#else
            this.toolStripMenuItem6.Image = new Bitmap(Image.FromFile(@"Images/ExitIcon.png"));
            this.toolStripMenuItem6.Click += ToolStripMenuItem6_Click;
            this.toolStripMenuItem4.Image = new Bitmap(Image.FromFile(@"Images/UndoIcon.png"));
            this.toolStripMenuItem4.Click += ToolStripMenuItem4_Click;
            this.toolStripMenuItem5.Image = new Bitmap(Image.FromFile(@"Images/RedoIcon.png"));
            this.toolStripMenuItem5.Click += ToolStripMenuItem5_Click;
            this.toolStripMenuItem3.Image = new Bitmap(Image.FromFile(@"Images/PasteHS.png"));
            this.toolStripMenuItem3.Click += ToolStripMenuItem3_Click;
            this.toolStripMenuItem2.Image = new Bitmap(Image.FromFile(@"Images/CopyHS.png"));
            this.toolStripMenuItem2.Click += ToolStripMenuItem2_Click;
            this.toolStripMenuItem1.Image = new Bitmap(Image.FromFile(@"Images/CutHS.png"));
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
            this.toolStripMenuItem4.Enabled = this.toolStripMenuItem5.Enabled = (sender as Syncfusion.Windows.Forms.Tools.CheckBoxAdv).Checked;
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

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();
#if NETCORE
            Bitmap bmp = new Bitmap(Image.FromFile(@"Images/App.ico"));
            string path = Application.StartupPath.ToString() + @"..\..\..\..\Introduction.rtf";
#else
            Bitmap bmp = new Bitmap(Image.FromFile(@"Images/App.ico"));
            string path = Application.StartupPath.ToString() + @"..\..\..\Introduction.rtf";
#endif

            this.Icon = Icon.FromHandle(bmp.GetHicon());
            this.Load += this.Form1_Load;
            if (File.Exists(path))
            {
                this.richTextBox1.LoadFile(path, RichTextBoxStreamType.RichText);
            }
            this.label1.Location = new Point(this.panel1.Bounds.X, this.panel1.Bounds.Y);
            this.richTextBox1.Location = new Point(this.label1.Bounds.X, this.label1.Bounds.Y + this.label1.Height);
            this.groupBox1.Location = new Point(this.richTextBox1.Bounds.X + this.richTextBox1.Width + 10, this.label1.Bounds.Y + this.label1.Height);
        }
    }
}
