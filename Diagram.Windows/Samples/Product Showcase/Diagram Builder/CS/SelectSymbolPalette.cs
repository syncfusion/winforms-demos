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
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Syncfusion.Windows.Forms.Diagram.Samples.DiagramTool
{
    public partial class SelectSymbolPalette : Form
    {
        string fileName = null;

        public SelectSymbolPalette()
        {
            InitializeComponent();
        }

        public SelectSymbolPalette(string filename)
            : this()
        {
            this.fileName = filename;
            this.label1.Text = "Cannot find "+filename+".edp. Please provide the location of this edp here.";
        }

        public string PaletteFileName
        {
            get
            {
                return fileName;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                this.fileName = this.label2.Text = openFileDialog1.FileName;
        }

    }
}