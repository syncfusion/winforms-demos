#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
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
using System.Windows.Forms;

namespace NavigationDrawer_2010
{
    public partial class PersonelView : UserControl
    {
        public PersonelView()
        {
            InitializeComponent();
            //this.label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#858585");
            this.hubTile1.EnableHoverColor = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
            //e.Graphics.DrawRectangle(new Pen(Brushes.LightGray, 3), new Rectangle(this.DisplayRectangle.X + 1, this.DisplayRectangle.Y + 1, this.DisplayRectangle.Width - 4, this.DisplayRectangle.Height - 3));
        }
    }
}
