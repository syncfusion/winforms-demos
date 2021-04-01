using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuccinitySeries
{
    public partial class Viewer : Form
    {
      
        public Viewer()
        {
            InitializeComponent();
            System.Drawing.Icon ico = new System.Drawing.Icon("pdf viewer.ico");
            this.Icon = ico;
        }

        public void LoadPdf(string fileName)
        {
            pdfViewerControl1.Load(fileName);
        }
    }
}
