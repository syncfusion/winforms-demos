using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication25
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
