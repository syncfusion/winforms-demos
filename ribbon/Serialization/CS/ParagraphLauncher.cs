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
    public partial class ParagraphLauncher : MetroForm
    {
        RichTextBox richtetbox;
        public ParagraphLauncher(RichTextBox rtb)
        {
            InitializeComponent();
            richtetbox = rtb;
        }

        private void Okbutton_Click(object sender, EventArgs e)
        {
            this.richtetbox.SelectionIndent = (int)this.leftnumericUpDownExt.Value;
            this.richtetbox.SelectionRightIndent = (int)this.rightNumericUpDownExt.Value;
            this.Close();
        }
    }
}
