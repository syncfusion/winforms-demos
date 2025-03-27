#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Syncfusion.WinForms.Controls;

namespace SpellCheckerAdv_2012
{
    public partial class Form1 : SfForm
    {
        TextBoxSpellEditor TextEditor;
        ContextMenuStrip textboxcontextmenu = new ContextMenuStrip();
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.spellCheckerAdv1.VisualStyle = SpellCheckerAdvStyle.Office2016Colorful;
            TextEditor = new TextBoxSpellEditor(this.textBoxExt1);
            SpellEditor = TextEditor;
            this.spellCheckerAdv1.PerformSpellCheckForControl(SpellEditor);
            this.textBoxExt1.ContextMenuStrip = textboxcontextmenu;
            this.Load += new EventHandler(Form1_Load);
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
            if (!File.Exists("C:\\ProgramData\\Microsoft Corporation\\Microsoft® Visual Studio® 2012\\11.0.50727.1\\Custom_Dictionay.dic"))
                this.spellCheckerAdv1.CustomDictionaryPath = "C:\\ProgramData\\ClipboardFunctionsDemo\\SpellCheckerDemo_2008\\1.0.0.0\\Custom_Dictionay.dic";

            UpdateSpellCheckerAdvStyleforOffice2016Themes();
        }
        #region [IconFile]
        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
        }
        #endregion

        /// <summary>
        /// Gets or sets the ISpellCheckerAdvEditorTools interface.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public ISpellCheckerAdvEditorTools SpellEditor
        {
            get;
            set;
        }

        #region[Events]

        void Form1_Load(object sender, EventArgs e)
        {
            this.textBoxExt1.HideSelection = true;
        }      

        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            this.spellCheckerAdv1.IgnoreEmailAddress = this.checkBoxAdv1.Checked;
        }

        private void ComboBoxAdv1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.comboBoxAdv1.SelectedIndex == 0)
            {
                this.spellCheckerAdv1.VisualStyle = SpellCheckerAdvStyle.Metro;
                this.groupBox1.ForeColor = Color.Black;
                this.textBoxExt1.Style = TextBoxExt.theme.Metro;

            }
            else if (this.comboBoxAdv1.SelectedIndex == 1)
            {
                this.spellCheckerAdv1.VisualStyle = SpellCheckerAdvStyle.Office2016Colorful;
                this.groupBox1.ForeColor = Color.Black;
                this.textBoxExt1.Style = TextBoxExt.theme.Office2016Colorful;

            }
            else if (this.comboBoxAdv1.SelectedIndex == 2)
            {
                this.spellCheckerAdv1.VisualStyle = SpellCheckerAdvStyle.Office2016White;
                this.groupBox1.ForeColor = Color.Black;
                this.textBoxExt1.Style = TextBoxExt.theme.Office2016White;

            }
            else if (this.comboBoxAdv1.SelectedIndex == 3)
            {
                this.spellCheckerAdv1.VisualStyle = SpellCheckerAdvStyle.Office2016DarkGray;
                
                this.textBoxExt1.Style = TextBoxExt.theme.Office2016DarkGray;
            }
            else if (this.comboBoxAdv1.SelectedIndex == 4)
            {
                this.spellCheckerAdv1.VisualStyle = SpellCheckerAdvStyle.Office2016Black;
                this.groupBox1.ForeColor = Color.White;
                this.textBoxExt1.Style = TextBoxExt.theme.Office2016Black;

            }
            else if (this.comboBoxAdv1.SelectedIndex == 5)
            {
                this.spellCheckerAdv1.ThemeName = "Office2019Colorful";
                this.textBoxExt1.ThemeName = "Office2019Colorful";
            }
            else if (this.comboBoxAdv1.SelectedIndex == 6)
            {
                this.spellCheckerAdv1.ThemeName = "HighContrastBlack";
                this.textBoxExt1.ThemeName = "HighContrastBlack";
            }

            UpdateSpellCheckerAdvStyleforOffice2016Themes();

        }
        private void checkBoxAdv2_CheckStateChanged(object sender, EventArgs e)
        {
            this.spellCheckerAdv1.IgnoreUpperCaseWords = this.checkBoxAdv2.Checked;
        }

        private void checkBoxAdv3_CheckStateChanged(object sender, EventArgs e)
        {
            this.spellCheckerAdv1.IgnoreAlphaNumericWords = this.checkBoxAdv3.Checked;
        }

        private void checkBoxAdv4_CheckStateChanged(object sender, EventArgs e)
        {
            this.spellCheckerAdv1.IgnoreUrl = this.checkBoxAdv4.Checked;
        }

        private void checkBoxAdv5_CheckStateChanged(object sender, EventArgs e)
        {
            this.spellCheckerAdv1.IgnoreMixedCaseWords = this.checkBoxAdv5.Checked;
        }

        private void buttonAdv1_Click_1(object sender, EventArgs e)
        {
            this.spellCheckerAdv1.SpellCheck(new SpellCheckerAdvEditorWrapper(this.textBoxExt1));
        }
        private void UpdateSpellCheckerAdvStyleforOffice2016Themes()
        {
           
            if (this.spellCheckerAdv1.ThemeName == "Metro")
            {
                this.BackColor = System.Drawing.Color.White;
                this.ForeColor = System.Drawing.Color.Black;
                this.label1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.textBoxExt1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.textBoxExt1.ForeColor = System.Drawing.Color.Black;
                this.label1.ForeColor = System.Drawing.Color.Black;
                this.comboBoxAdv1.Style = VisualStyle.Metro;
                this.checkBoxAdv1.Style = CheckBoxAdvStyle.Metro;
                this.checkBoxAdv2.Style = CheckBoxAdvStyle.Metro;
                this.checkBoxAdv3.Style = CheckBoxAdvStyle.Metro;
                this.checkBoxAdv4.Style = CheckBoxAdvStyle.Metro;
                this.checkBoxAdv5.Style = CheckBoxAdvStyle.Metro;
                this.buttonAdv1.Appearance = ButtonAppearance.Metro;
                this.spellCheckerAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
                this.ShowIcon = true;
            }
            else if (this.spellCheckerAdv1.ThemeName == "Office2016Colorful")
            {
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.ForeColor = ColorTranslator.FromHtml("#262626");
                this.textBoxExt1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.label1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.textBoxExt1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label1.ForeColor= ColorTranslator.FromHtml("#262626");
                this.comboBoxAdv1.Style = VisualStyle.Office2016Colorful;
                this.checkBoxAdv1.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.checkBoxAdv2.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.checkBoxAdv3.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.checkBoxAdv4.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.checkBoxAdv5.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.buttonAdv1.Appearance = ButtonAppearance.Office2016Colorful;
                this.ShowIcon = true;
            }
            else if (this.spellCheckerAdv1.ThemeName == "Office2016Black")
            {
                this.BackColor = ColorTranslator.FromHtml("#262626");
                this.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.textBoxExt1.BackColor = ColorTranslator.FromHtml("#262626");
                this.label1.BackColor= ColorTranslator.FromHtml("#262626");
                this.textBoxExt1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.comboBoxAdv1.Style = VisualStyle.Office2016Black;
                this.checkBoxAdv1.Style = CheckBoxAdvStyle.Office2016Black;
                this.checkBoxAdv2.Style = CheckBoxAdvStyle.Office2016Black;
                this.checkBoxAdv3.Style = CheckBoxAdvStyle.Office2016Black;
                this.checkBoxAdv4.Style = CheckBoxAdvStyle.Office2016Black;
                this.checkBoxAdv5.Style = CheckBoxAdvStyle.Office2016Black;
                this.buttonAdv1.Appearance = ButtonAppearance.Office2016Black;
                this.ShowIcon = true;
            }
            else if (this.spellCheckerAdv1.ThemeName == "Office2016White")
            {
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.ForeColor = ColorTranslator.FromHtml("#262626");
                this.textBoxExt1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.label1.BackColor= ColorTranslator.FromHtml("#ffffff");
                this.textBoxExt1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label1.ForeColor= ColorTranslator.FromHtml("#262626");
                this.comboBoxAdv1.Style = VisualStyle.Office2016White;
                this.checkBoxAdv1.Style = CheckBoxAdvStyle.Office2016White;
                this.checkBoxAdv2.Style = CheckBoxAdvStyle.Office2016White;
                this.checkBoxAdv3.Style = CheckBoxAdvStyle.Office2016White;
                this.checkBoxAdv4.Style = CheckBoxAdvStyle.Office2016White;
                this.checkBoxAdv5.Style = CheckBoxAdvStyle.Office2016White;
                this.buttonAdv1.Appearance = ButtonAppearance.Office2016White;
                this.ShowIcon = true;
            }
            else if (this.spellCheckerAdv1.ThemeName == "Office2016DarkGray")
            {
                this.BackColor = ColorTranslator.FromHtml("#666666");
                this.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.textBoxExt1.BackColor = ColorTranslator.FromHtml("#666666");
                this.label1.BackColor = ColorTranslator.FromHtml("#666666");
                this.textBoxExt1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.comboBoxAdv1.Style = VisualStyle.Office2016DarkGray;
                this.checkBoxAdv1.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBoxAdv2.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBoxAdv3.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBoxAdv4.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBoxAdv5.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.buttonAdv1.Appearance = ButtonAppearance.Office2016DarkGray;
                this.buttonAdv1.ForeColor = Color.Black;
                this.ShowIcon = true;
            }
            else if(this.spellCheckerAdv1.ThemeName == "Office2019Colorful")
            {
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.ForeColor = ColorTranslator.FromHtml("#262626");
                this.textBoxExt1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.label1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.textBoxExt1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.comboBoxAdv1.ThemeName = "Office2019Colorful";
                this.checkBoxAdv1.ThemeName = "Office2019Colorful";
                this.checkBoxAdv2.ThemeName = "Office2019Colorful";
                this.checkBoxAdv3.ThemeName = "Office2019Colorful";
                this.checkBoxAdv4.ThemeName = "Office2019Colorful";
                this.checkBoxAdv5.ThemeName = "Office2019Colorful";
                this.buttonAdv1.ThemeName = "Office2019Colorful";
                this.ThemeName = "Office2019Colorful";
                this.ShowIcon = true;
            }
            else if(this.spellCheckerAdv1.ThemeName == "HighContrastBlack")
            {
                this.BackColor = System.Drawing.Color.Black;
                this.groupBox1.ForeColor = System.Drawing.Color.White;
                this.label1.BackColor = System.Drawing.Color.Black;
                this.label1.ForeColor = System.Drawing.Color.White;
                this.textBoxExt1.ThemeName = "HighContrastBlack";
                this.comboBoxAdv1.ThemeName = "HighContrastBlack";
                this.checkBoxAdv1.ThemeName = "HighContrastBlack";
                this.checkBoxAdv2.ThemeName = "HighContrastBlack";
                this.checkBoxAdv3.ThemeName = "HighContrastBlack";
                this.checkBoxAdv4.ThemeName = "HighContrastBlack";
                this.checkBoxAdv5.ThemeName = "HighContrastBlack";
                this.buttonAdv1.ThemeName = "HighContrastBlack";
                this.ThemeName = "HighContrastBlack";
                this.ShowIcon = true;
            }
        }
        #endregion


    }
}
