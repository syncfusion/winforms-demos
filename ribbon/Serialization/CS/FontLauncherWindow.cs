using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WF_Word
{
    public partial class FontLauncherWindow : MetroForm
    {
        RichTextBox richTextBox;
        public FontLauncherWindow(RichTextBox rtb)
        {
            InitializeComponent();
            richTextBox = rtb;
            this.SizecomboBox.Text = this.richTextBox.Font.Size.ToString();
            this.fontcombobox.Text = this.richTextBox.Font.FontFamily.ToString();
            this.styleComboBox.Text = this.richTextBox.Font.Style.ToString();
            foreach (FontFamily oneFontFamily in FontFamily.Families)
            {
                fontcombobox.Items.Add(oneFontFamily.Name);
            }
            this.AcceptButton = OKbutton;
            this.CancelButton = cancelbutton;
        }


        private void OKbutton_Click(object sender, EventArgs e)
        {
            string font = this.fontcombobox.Text;
            float size = Convert.ToSingle(this.SizecomboBox.Text);
            FontStyle style = FontStyle.Regular;
            if (this.styleComboBox.SelectedItem.ToString().Equals("Regular"))
                style = FontStyle.Regular;
            else if (this.styleComboBox.SelectedItem.ToString().Equals("Italic"))
                style = FontStyle.Italic;
            else if (this.styleComboBox.SelectedItem.ToString().Equals("Bold"))
                style = FontStyle.Bold;
            else if (this.styleComboBox.SelectedItem.ToString().Equals("Bold Italic"))
                style = FontStyle.Bold |FontStyle.Italic;
            if (strikethroughcheckBox.Checked)
                style |= FontStyle.Strikeout;
            if(superScriptcheckBox.Checked)
                this.richTextBox.SelectionCharOffset = 10;
            if (subScriptcheckBox.Checked)
                this.richTextBox.SelectionCharOffset = -10;
            if (capsCheckBox.Checked)
                this.richTextBox.SelectedText = this.richTextBox.SelectedText.ToUpper();
            richTextBox.SelectionFont = new Font(font, size,style);
            richTextBox.ForeColor = this.colorPickerButton1.SelectedColor;
            this.Close();
        }
        
        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
