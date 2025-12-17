#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GettingStarted
{
    public partial class PictureBoxControl : UserControl
    {
        public PictureBoxControl()
        {
            InitializeComponent();
        }

        public void AddControls()
        {
            this.Controls.Add(PictureBox);
            this.Controls.Add(RichTextBox);
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PictureBox PictureBox { get; set; }

        [DesignerSerializationVisibility (DesignerSerializationVisibility.Hidden)]
        public RichTextBox RichTextBox { get; set; }
    }
}
