#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp54
{
    public partial class Form1 : SfForm
    {
        public Form1()
        {
            InitializeComponent();
#if NETCORE
            this.Icon = new System.Drawing.Icon(@"..\\..\\..\\\logo.ico");
            string richTextBox1_path = Application.StartupPath.ToString() + @"..\..\..\PopupMenu.rtf";
#else
            this.Icon = new System.Drawing.Icon(@"..\\..\\\logo.ico");
            string richTextBox1_path = Application.StartupPath.ToString() + @"..\..\..\PopupMenu.rtf";
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sfComboBox1.DataSource = ((object)(resources.GetObject("sfComboBox1.DataSource")));
#endif
            if (File.Exists(richTextBox1_path))
            {
                this.richTextBox1.LoadFile(richTextBox1_path, RichTextBoxStreamType.RichText);
            }
            this.popupMenusManager1.SetXPContextMenu(richTextBox1, popupMenu1);
            this.richTextBox1.MouseDown += RichTextBox1_MouseDown;
            this.popupControlContainer1.BackColor = this.BackColor;
            this.colorPickerUIAdv1.ThemeName = "Office2019Colorful";
#if NETCORE
            List<string> languageList = new List<string>();
            languageList.Add("Office2019Colorful");
            languageList.Add("HighContrastBlack");
            languageList.Add("Office2016Black");
            languageList.Add("Office2016Colorful");
            languageList.Add("Office2016DarkGray");
            languageList.Add("Office2016White");
            sfComboBox1.DataSource = languageList;
#endif
        }

        private void RichTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.checkBoxAdv1.Checked)
            {
                if (e.Button == MouseButtons.Right)
                {
                    this.popupMenu1.Show(richTextBox1, new Point(xPosition, yPosition));
                }
            }
        }

        private void CheckBoxAdv1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.checkBoxAdv1.Checked)
            {
                this.numericUpDownExt1.Enabled = true;
                this.numericUpDownExt2.Enabled = true;
            }
            else
            {
                this.numericUpDownExt1.Enabled = false;
                this.numericUpDownExt2.Enabled = false;
            }
        }

        private void ColorPickerUIAdv1_Picked(object sender, Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            this.richTextBox1.ForeColor = this.colorPickerUIAdv1.SelectedColor;
        }
#region BarItem_Events
        private void ExitBarItem8_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void OpenBarItem7_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openDocument = new OpenFileDialog();
            openDocument.Filter = "txt files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openDocument.ShowDialog() == DialogResult.OK)
            {
                string fileContent = File.ReadAllText(openDocument.FileName);
                richTextBox1.Text = fileContent;

            }
        }

        private void NewBarItem6_Click(object sender, System.EventArgs e)
        {
            this.richTextBox1.Clear();
        }

        private void RedoBarItem5_Click(object sender, System.EventArgs e)
        {
            this.richTextBox1.Redo();
        }

        private void UndoBarItem4_Click(object sender, System.EventArgs e)
        {
            this.richTextBox1.Undo();
        }

        private void PasteBarItem3_Click(object sender, System.EventArgs e)
        {
            this.richTextBox1.Paste();
        }

        private void CopyBarItem2_Click(object sender, System.EventArgs e)
        {
            this.richTextBox1.Copy();
        }

        private void CutBarItem1_Click(object sender, System.EventArgs e)
        {
            this.richTextBox1.Cut();
        }
#endregion
        private void SfComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if(this.sfComboBox1.SelectedItem != null)
            {
                if (this.sfComboBox1.SelectedItem.ToString() == "Office2019Colorful")
                {
                    SfSkinManager.SetVisualStyle(this, "Office2019Colorful");
                    this.richTextBox1.BackColor = ColorTranslator.FromHtml("#F3F3F3");
                    this.gradientPanel1.BackColor = ColorTranslator.FromHtml("#F3F3F3");
                    this.gradientPanel2.BackColor = ColorTranslator.FromHtml("#F3F3F3");
                    this.gradientPanel1.BorderColor = ColorTranslator.FromHtml("#D2D2D2");
                    this.gradientPanel2.BorderColor = ColorTranslator.FromHtml("#D2D2D2");
                    this.BackColor = ColorTranslator.FromHtml("#F3F3F3");
                    this.popupControlContainer1.BackColor = this.BackColor;
                    this.label1.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.label3.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.label4.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.label6.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.checkBoxAdv1.ThemeName = "Office2019Colorful";
                    this.colorPickerUIAdv1.ThemeName = "Office2019Colorful";
                    this.richTextBox1.ForeColor = ColorTranslator.FromHtml("#444444");

#if NETCORE
                this.richTextBox1.Select(this.richTextBox1.GetFirstCharIndexFromLine(0), this.richTextBox1.Lines[0].Length);
                this.richTextBox1.SelectionBackColor = ColorTranslator.FromHtml("#F3F3F3");
#endif
                }
                else if (this.sfComboBox1.SelectedItem.ToString() == "HighContrastBlack")
                {
                    SfSkinManager.SetVisualStyle(this, "HighContrastBlack");
                    this.richTextBox1.BackColor = System.Drawing.Color.Black;
                    this.gradientPanel1.BackColor = System.Drawing.Color.Black;
                    this.gradientPanel2.BackColor = System.Drawing.Color.Black;
                    this.popupControlContainer1.BackColor = this.BackColor;
                    this.BackColor = Color.Black;
                    this.label1.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                    this.label3.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                    this.label4.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                    this.label6.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                    this.checkBoxAdv1.ThemeName = "HighContrastBlack";
                    this.colorPickerUIAdv1.ThemeName = "HighContrastBlack";
                    this.richTextBox1.ForeColor = Color.White;
                    this.gradientPanel1.BorderColor = ColorTranslator.FromHtml("#FFFFFF");
#if NETCORE
                this.richTextBox1.Select(this.richTextBox1.GetFirstCharIndexFromLine(0), this.richTextBox1.Lines[0].Length);
                this.richTextBox1.SelectionBackColor = ColorTranslator.FromHtml("#000000");
#endif
                }
                else if (this.sfComboBox1.SelectedItem.ToString() == "Office2016Black")
                {
                    SfSkinManager.SetVisualStyle(this, "Office2016Black");
                    this.richTextBox1.BackColor = ColorTranslator.FromHtml("#0a0a0a");
                    this.gradientPanel1.BackColor = ColorTranslator.FromHtml("#0a0a0a");
                    this.gradientPanel2.BackColor = ColorTranslator.FromHtml("#0a0a0a");
                    this.BackColor = ColorTranslator.FromHtml("#0a0a0a");
                    this.popupControlContainer1.BackColor = this.BackColor;
                    this.label1.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                    this.label3.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                    this.label4.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                    this.label6.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                    this.checkBoxAdv1.ThemeName = "Office2016Black";
                    this.colorPickerUIAdv1.ThemeName = "Office2016Black";
                    this.gradientPanel1.BorderColor = Color.WhiteSmoke;
                    this.gradientPanel2.BorderColor = Color.WhiteSmoke;
                    this.richTextBox1.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
#if NETCORE
                this.richTextBox1.Select(this.richTextBox1.GetFirstCharIndexFromLine(0), this.richTextBox1.Lines[0].Length);
                this.richTextBox1.SelectionBackColor = ColorTranslator.FromHtml("#0a0a0a");
#endif
                }
                else if (this.sfComboBox1.SelectedItem.ToString() == "Office2016Colorful")
                {
                    SfSkinManager.SetVisualStyle(this, "Office2016Colorful");
                    this.richTextBox1.BackColor = Color.White;
                    this.gradientPanel1.BackColor = Color.White;
                    this.gradientPanel2.BackColor = Color.White;
                    this.BackColor = Color.White;
                    this.popupControlContainer1.BackColor = this.BackColor;
                    this.label1.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.label3.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.label4.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.label6.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.checkBoxAdv1.ThemeName = "Office2016Colorful";
                    this.colorPickerUIAdv1.ThemeName = "Office2016Colorful";
                    this.gradientPanel1.BorderColor = Color.Black;
                    this.gradientPanel2.BorderColor = Color.Black;
                    this.richTextBox1.ForeColor = ColorTranslator.FromHtml("#444444");
#if NETCORE
                this.richTextBox1.Select(this.richTextBox1.GetFirstCharIndexFromLine(0), this.richTextBox1.Lines[0].Length);
                this.richTextBox1.SelectionBackColor = ColorTranslator.FromHtml("#FFFFFF");
#endif
                }
                else if (this.sfComboBox1.SelectedItem.ToString() == "Office2016DarkGray")
                {
                    SfSkinManager.SetVisualStyle(this, "Office2016DarkGray");
                    this.richTextBox1.BackColor = ColorTranslator.FromHtml("#444444");
                    this.gradientPanel1.BackColor = ColorTranslator.FromHtml("#444444");
                    this.gradientPanel2.BackColor = ColorTranslator.FromHtml("#444444");
                    this.BackColor = ColorTranslator.FromHtml("#444444");
                    this.popupControlContainer1.BackColor = this.BackColor;
                    this.label1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label4.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label6.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.checkBoxAdv1.ThemeName = "Office2016DarkGray";
                    this.colorPickerUIAdv1.ThemeName = "Office2016DarkGray";
                    this.gradientPanel1.BorderColor = Color.WhiteSmoke;
                    this.gradientPanel2.BorderColor = Color.WhiteSmoke;
                    this.richTextBox1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
#if NETCORE
                this.richTextBox1.Select(this.richTextBox1.GetFirstCharIndexFromLine(0), this.richTextBox1.Lines[0].Length);
                this.richTextBox1.SelectionBackColor = ColorTranslator.FromHtml("#444444");
#endif
                }
                else if (this.sfComboBox1.SelectedItem.ToString() == "Office2016White")
                {
                    SfSkinManager.SetVisualStyle(this, "Office2016White");
                    this.BackColor = Color.White;
                    this.richTextBox1.BackColor = Color.White;
                    this.gradientPanel1.BackColor = Color.White;
                    this.gradientPanel2.BackColor = Color.White;
                    this.popupControlContainer1.BackColor = this.BackColor;
                    this.label1.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.label3.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.label4.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.label6.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.checkBoxAdv1.ThemeName = "Office2016White";
                    this.colorPickerUIAdv1.ThemeName = "Office2016White";
                    this.gradientPanel1.BorderColor = Color.Black;
                    this.gradientPanel2.BorderColor = Color.Black;
                    this.richTextBox1.ForeColor = ColorTranslator.FromHtml("#444444");
#if NETCORE
                this.richTextBox1.Select(this.richTextBox1.GetFirstCharIndexFromLine(0), this.richTextBox1.Lines[0].Length);
                this.richTextBox1.SelectionBackColor = ColorTranslator.FromHtml("#FFFFFF");
#endif
                }
            }
        }
        private void RichTextBox1_SelectionChanged(object sender, System.EventArgs e)
        {
            if(richTextBox1.SelectedText.Length>0)
            {
                this.cutBarItem1.Enabled = true;
                this.copyBarItem2.Enabled = true;
                this.redoBarItem5.Enabled = true;
            }
        }
        private int xPosition = 0;
        private int yPosition = 0;
        
        private void numericUpDownExt2_ValueChanged(object sender, EventArgs e)
        {
            yPosition = (int)this.numericUpDownExt2.Value;
        }

        private void numericUpDownExt1_ValueChanged(object sender, EventArgs e)
        {
            xPosition = (int)this.numericUpDownExt1.Value;
        }
        
    }
}
