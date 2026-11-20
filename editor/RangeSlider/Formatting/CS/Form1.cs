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

namespace SliderFormatting_2017
{
    public partial class Form1 : SfForm
    {
        public Form1()
        { 
            InitializeComponent();
        }

        private void RangeSlider3_DrawLabel(object sender, DrawLabelEventArgs e)
        {
            RangeSlider range = sender as RangeSlider;
            TimeSpan time = TimeSpan.FromHours(e.Value);
            e.Handled = true;
            var hours = time.Hours;
            var minutes = time.Minutes;
            var amPmDesignator = "AM";
            if (hours == 0)
                hours = 12;
            else if (hours == 12)
                amPmDesignator = "PM";
            else if (hours > 12)
            {
                hours -= 12;
                amPmDesignator = "PM";
            }
            var formattedTime =
              String.Format("{0}:{1:00}{2}", hours, minutes, amPmDesignator);
            e.Text = formattedTime.ToString();
        }

        private void RangeSlider2_DrawLabel(object sender, DrawLabelEventArgs e)
        {
            RangeSlider range = sender as RangeSlider;
            e.Handled = true;
            e.Text = e.Value.ToString() + " km";
        }

        private void RangeSlider1_DrawLabel(object sender, DrawLabelEventArgs e)
        {
            RangeSlider range = sender as RangeSlider;
            e.Handled = true;
            e.Text = "$" + ((Double)e.Value).ToString() + ".00";
        }
    }
}
