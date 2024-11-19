#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Syncfusion.Windows.Forms.Tools;
using System.Windows.Forms;
using System.Drawing;

namespace NavigationDrawer_2010
{
    public class DrawMenuItemExt : DrawerMenuItem
    {
        public DrawMenuItemExt()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(new SolidBrush(System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(165)))), ((int)(((byte)(215)))))), 1), new Point(this.DisplayRectangle.X, this.DisplayRectangle.Height - 1), new Point((this.DisplayRectangle.Left + this.DisplayRectangle.Width - 5),this.DisplayRectangle.Height - 1));            
        }
    }
}
