#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace AsyncLoading
{
    public partial class LoadData : MetroForm
    {
        public LoadData()
        {
            InitializeComponent();
            numericUpDown1.Maximum = 500000;
            numericUpDown1.Minimum = 100000;
            numericUpDown1.Value = 200000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.recordCount = Convert.ToInt32(numericUpDown1.Value);
            DialogResult = DialogResult.OK;
        }
    }
}