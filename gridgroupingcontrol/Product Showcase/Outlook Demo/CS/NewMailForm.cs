using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Tools.XPMenus;

namespace OutlookDemo
{
    public partial class NewMailForm : RibbonForm
    {
        private Form1 m_form1;
        public NewMailForm(Form1 parentForm, String theme)
        {
            InitializeComponent();
            this.m_form1 = parentForm;
            SetTheme(theme);
        }

        private void OnNewMailFormLoad(object sender, EventArgs e)
        {
            foreach (object o in new FontListBox().Items)
            {
                this.messageFontListComboBox.Items.Add(o);
                this.fontToolStripComboBox.Items.Add(o);
            }
            this.messageFontListComboBox.SelectedItem = "Calibri";
            this.fontToolStripComboBox.SelectedItem = "Calibri";
            this.richTextBox1.SelectionFont = new Font("Calibri", 11);
        }

        #region TextChange EventHandlers

        private void OnBoldClick(object sender, EventArgs e)
        {
            ToolStripButton boldToolStripBtn = sender as ToolStripButton;
            if (!boldToolStripBtn.Checked)
                this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, (richTextBox1.SelectionFont.Style & ~(richTextBox1.SelectionFont.Style & FontStyle.Bold)));
            else
                this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, this.richTextBox1.SelectionFont.Style | FontStyle.Bold);
        }

        private void OnItalicClick(object sender, EventArgs e)
        {
            ToolStripButton italicToolStripBtn = sender as ToolStripButton;
            if (!italicToolStripBtn.Checked)
                this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, (richTextBox1.SelectionFont.Style & ~(richTextBox1.SelectionFont.Style & FontStyle.Italic)));
            else
                this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, this.richTextBox1.SelectionFont.Style | FontStyle.Italic);
        }

        private void OnUnderlineClick(object sender, EventArgs e)
        {
            ToolStripButton underlineToolStripBtn = sender as ToolStripButton;
            if (!underlineToolStripBtn.Checked)
                this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, (richTextBox1.SelectionFont.Style & ~(richTextBox1.SelectionFont.Style & FontStyle.Underline)));
            else
                this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Underline);
        }

        private void OnStrikeThroughClick(object sender, EventArgs e)
        {
            ToolStripButton strikeThroughToolStripBtn = sender as ToolStripButton;
            if (!strikeThroughToolStripBtn.Checked)
                this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, (richTextBox1.SelectionFont.Style & ~(richTextBox1.SelectionFont.Style & FontStyle.Strikeout)));
            else
                this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Strikeout);
        }

        private void OnIndentClick(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionIndent += 20;
        }

        private void OnOutdentClick(object sender, EventArgs e)
        {
            if (this.richTextBox1.SelectionIndent > 0)
                this.richTextBox1.SelectionIndent -= 20;
        }

        private void OnFontChange(object sender, EventArgs e)
        {
            ToolStripComboBox fontListCombo = sender as ToolStripComboBox;
            this.messageFontListComboBox.SelectedItem = fontListCombo.SelectedItem.ToString();
            this.fontToolStripComboBox.SelectedItem = fontListCombo.SelectedItem.ToString();
            this.richTextBox1.SelectionFont = new Font(fontListCombo.SelectedItem.ToString(), this.richTextBox1.SelectionFont.Size);
        }

        private void OnFontSizeChange(object sender, EventArgs e)
        {
            ToolStripComboBox fontSizeComboBox = sender as ToolStripComboBox;
            this.richTextBox1.SelectionFont = new Font(this.messageFontListComboBox.SelectedItem.ToString(), float.Parse(fontSizeComboBox.SelectedItem.ToString()));
        }

        #endregion

        #region Cut,Copy and Paste Event Handlers

        private void OnPasteClick(object sender, EventArgs e)
        {
            this.richTextBox1.Paste();
        }

        private void OnCutClick(object sender, EventArgs e)
        {
            this.richTextBox1.Cut();
        }

        private void OnCopyClick(object sender, EventArgs e)
        {
            this.richTextBox1.Copy();
        }

        #endregion

        #region Theme Effects

        private void OnThemeStyleChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            SetTheme(item.Text);
        }

        public void SetTheme(String theme)
        {
            switch (theme)
            {
                case "Blue":
                    this.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Blue;
                    this.ColorScheme = ColorSchemeType.Blue;
                    this.sendButtonAdv.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue;
                    this.toButtonAdv.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue;
                    this.ccbuttonAdv1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue;
                    this.autoLabel1.ForeColor = Color.FromArgb(21, 66, 139);
                    this.blueToolStripMenuItem.Checked = true;
                    this.blackToolStripMenuItem.Checked = false;
                    this.silverToolStripMenuItem.Checked = false;
					this.panel1.BackColor = Color.FromArgb(227, 239, 255);
                    this.m_form1.SetTheme(theme);
                    break;
                case "Black":
                    this.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Black;
                    this.sendButtonAdv.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
                    this.toButtonAdv.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
                    this.ccbuttonAdv1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
                    this.ColorScheme = ColorSchemeType.Black;
                    this.autoLabel1.ForeColor = Color.White;
                    this.blueToolStripMenuItem.Checked = false;
                    this.blackToolStripMenuItem.Checked = true;
                    this.silverToolStripMenuItem.Checked = false;
                    this.panel1.BackColor = Color.FromArgb(191, 198, 206);
                    this.m_form1.SetTheme(theme);
                    break;
                case "Silver":
                    this.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver;
                    this.sendButtonAdv.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
                    this.toButtonAdv.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
                    this.ccbuttonAdv1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
                    this.autoLabel1.ForeColor = Color.Black;
                    this.ColorScheme = ColorSchemeType.Silver;
                    this.blueToolStripMenuItem.Checked = false;
                    this.blackToolStripMenuItem.Checked = false;
                    this.silverToolStripMenuItem.Checked = true;
                    this.panel1.BackColor = Color.FromArgb(231, 234, 240);
                    this.m_form1.SetTheme(theme);
                    break;
            }
            Refresh();
        }

        #endregion
    }
}