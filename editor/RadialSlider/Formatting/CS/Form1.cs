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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFormatting_2017
{
    public partial class Form1 : SfForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radialSlider2_DrawText(object sender, Syncfusion.Windows.Forms.Tools.RadialSlider.DrawTextEventArgs e)
        {
            if(e.TextType == Syncfusion.Windows.Forms.Tools.TextType.Value)
            {
                e.Text = "$" + radialSlider2.Value.ToString("N00");
                e.ForeColor = new SolidBrush(Color.DarkCyan);
            }
            else if(e.TextType == Syncfusion.Windows.Forms.Tools.TextType.Interval)
            {
                e.Font = new Font(radialSlider2.Font, FontStyle.Italic);
                e.ForeColor = new SolidBrush(Color.BlueViolet);
            }
            else if(e.TextType == Syncfusion.Windows.Forms.Tools.TextType.Pointer)
            {
                e.Font = new Font(radialSlider2.Font, FontStyle.Bold);
                e.ForeColor = new SolidBrush(Color.Black);
            }
        }

        private void radialSlider3_DrawText(object sender, Syncfusion.Windows.Forms.Tools.RadialSlider.DrawTextEventArgs e)
        {
            if(e.TextType == Syncfusion.Windows.Forms.Tools.TextType.Value)
            {
                e.Text = radialSlider3.Value.ToString("N00") + "%";
                e.ForeColor = new SolidBrush(Color.DarkOrange);
            }
        }
    }
}
