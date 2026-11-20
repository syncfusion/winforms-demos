using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GridScheduleSample
{
    public partial class ToolTipControl : UserControl
    {
        public ToolTipControl()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap("..\\..\\userTool.png");
        }
    }
}
