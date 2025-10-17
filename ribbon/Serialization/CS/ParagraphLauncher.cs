#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
