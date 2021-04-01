#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinearGaugeDemo
{
    public partial class Form1 : SfForm
    {
        public Form1()
        {
            InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
            this.linearGauge5.ReadOnly = false;
            this.linearGauge6.ReadOnly = false;
            this.linearGauge6.Value = this.linearGauge5.Value;
        }

        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
        }
    
        private void linearGauge5_ValueChanged(object sender, EventArgs e)
        {
            if (this.linearGauge5.Value != this.linearGauge6.Value)
                this.linearGauge5.Value = this.linearGauge6.Value;
        }
        private void linearGauge6_ValueChanged(object sender, EventArgs e)
        {
            if (this.linearGauge6.Value != this.linearGauge5.Value)
                this.linearGauge6.Value = this.linearGauge5.Value;
        }
    }
}
