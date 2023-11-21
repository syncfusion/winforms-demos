#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WeatherAnalysis
{
    class RotateLabel : System.Windows.Forms.Label
    {
        int a;
        public int RotateAngle { get; set; }  // to rotate your text
        public string NewText { get; set; }   // to draw text
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            Brush b = new SolidBrush(this.ForeColor);
            e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);
            e.Graphics.RotateTransform(this.RotateAngle);
            if (this.NewText.Length > 8)
                a = 120;
            else
                a = 150;

            using (Graphics dpi = this.CreateGraphics())
            {
                if (dpi.DpiX == 120)
                {
                    if (this.NewText.Length > 8)
                        a = 70;
                    else
                        a = 110;
                }
            }
            e.Graphics.DrawString(this.NewText, this.Font, b, a, -20f);
            base.OnPaint(e);
        }
    }
}
