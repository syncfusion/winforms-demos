#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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
