#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridLayoutExample
{
    public partial class Form1 : SfForm
    {
        public Form1()
        {
            InitializeComponent();
            this.trackBarEx1.ValueChanged += TrackBarEx1_ValueChanged;
            this.trackBarEx2.ValueChanged += TrackBarEx2_ValueChanged;
            this.MinimumSize = new Size((int)DpiAware.LogicalToDeviceUnits(500), (int)DpiAware.LogicalToDeviceUnits(500));
        }
       
        private void TrackBarEx2_ValueChanged(object sender, EventArgs e)
        {
            this.gridLayout1.VGap = (sender as TrackBarEx).Value;
            this.gridLayout1.HGap = (sender as TrackBarEx).Value;
        }

        private void TrackBarEx1_ValueChanged(object sender, EventArgs e)
        {
            this.gridLayout1.Rows = (sender as TrackBarEx).Value;
        }
        
    }
}
