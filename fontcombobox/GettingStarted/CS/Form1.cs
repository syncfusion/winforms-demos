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
using System.Windows.Forms;
using System.IO;

namespace GettingStarted
{
    public partial class Form1 : MetroForm
    {
        string path = Application.StartupPath.ToString() + @"..\..\..\Introduction.rtf";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                this.richTextBox1.LoadFile(path, RichTextBoxStreamType.RichText);
            }
        }
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
                this.groupBarItem2.BackColor = ColorTranslator.FromHtml("#a0a0a0");
                this.groupBarItem2.ForeColor = Color.White;
                this.groupBar1.BackColor = ColorTranslator.FromHtml("#252525");
                this.panel13.BackColor = ColorTranslator.FromHtml("#252525");
                this.panel14.BackColor = ColorTranslator.FromHtml("#252525");
                this.label2.ForeColor = Color.White;
                this.label1.ForeColor = Color.White;
                this.label4.ForeColor = Color.White;
                this.label7.ForeColor = Color.White;
                this.label14.ForeColor = Color.White;
                this.CaptionBarColor = ColorTranslator.FromHtml("#252525");
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
    }
}
