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

        public PictureBox PictureBox { get; set; }

        public RichTextBox RichTextBox { get; set; }
    }
}
