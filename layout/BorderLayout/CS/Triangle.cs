#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
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

namespace BorderLayout_Example
{
    public partial class Triangle : UserControl
    {
        public Triangle()
        {
            InitializeComponent();
        }

        private void Triangle_Paint(object sender, PaintEventArgs e)
        {
            Point[] p = new Point[3];
            p[0] = new Point(2, 14);
            p[1] = new Point(14, 14);
            p[2] = new Point(8, 1);
            SolidBrush brush = new SolidBrush(Color.FromArgb(55, 159, 100));
            e.Graphics.DrawLines(Pens.Black, p);
            e.Graphics.FillPolygon(brush, p);
        }
    }
}
