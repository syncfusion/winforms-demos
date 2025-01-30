#region Copyright Syncfusion Inc. 2001 - 2014
// Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Drawing;

namespace RibbonControlAdv_2005
{
    public partial class DialogForm : Office2007Form
    {
        public DialogForm()
        {
            InitializeComponent();
        }

        private void gradientLabel3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       public void UpdateFormControlColors(Office2007Theme theme)
       {
           switch (theme)
           {
               case Office2007Theme.Blue:
                   BrushInfo gradient = new BrushInfo(GradientStyle.PathEllipse, Color.FromArgb(208, 226, 247), Color.FromArgb(237, 240, 247));
                   this.gradientLabel1.BackgroundColor = gradient;
                   this.gradientLabel2.BackgroundColor = gradient;
                   this.gradientLabel3.BackgroundColor = gradient;
                   this.gradientPanel1.BackgroundColor = gradient;
                   break;
               case Office2007Theme.Black:
                   BrushInfo gradient2 = new BrushInfo(GradientStyle.PathEllipse, Color.FromArgb(181, 188, 198), Color.FromArgb(213, 221, 225));
                   this.gradientLabel1.BackgroundColor = gradient2;
                   this.gradientLabel2.BackgroundColor = gradient2;
                   this.gradientLabel3.BackgroundColor = gradient2;
                   this.gradientPanel1.BackgroundColor = gradient2;
                   break;
               case Office2007Theme.Silver:
                   BrushInfo gradient3 = new BrushInfo(GradientStyle.PathEllipse, Color.FromArgb(214, 219, 231), Color.FromArgb(226, 231, 239));
                   this.gradientLabel1.BackgroundColor = gradient3;
                   this.gradientLabel2.BackgroundColor = gradient3;
                   this.gradientLabel3.BackgroundColor = gradient3;
                   this.gradientPanel1.BackgroundColor = gradient3;
                   break;
           }
       }
    }
}