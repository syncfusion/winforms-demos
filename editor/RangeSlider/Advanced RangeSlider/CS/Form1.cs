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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RangeSlider_2017
{
    public partial class Form1 : SfForm
    {
    
        #region Constructor
        public Form1()
        {
            InitializeComponent();
            List<string> style = new List<string>();
            style.Add("Office2019Colorful");
            style.Add("HighContrastBlack");
            style.Add("Office2016Colorful");
            style.Add("Office2016White");
            style.Add("Office2016DarkGray");
            style.Add("Office2016Black");
            ApplyUIConfiguration();
            this.rangeSlider2.Maximum = 2100;
            this.rangeSlider2.SliderMax = 1700;
            this.rangeSlider2.SliderMin = 1300;
            this.rangeSlider2.Minimum = 900;
            this.rangeSlider2.TickFrequency = 400;

            this.sfComboBox1.DataSource = style;
            this.sfComboBox1.SelectedIndex = 0;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
        }

        #endregion

        # region Form Icon
        /// <summary>
        /// Gets the icon file
        /// </summary>
        /// <param name="bitmapName">Icon name</param>
        /// <returns>Icon path</returns>
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
        #endregion

        #region Methods
        private void ApplyUIConfiguration()
        {
            this.BackColor = System.Drawing.Color.White;
           
        }
        #endregion

        private void rangeSlider1_DrawLabel(object sender, DrawLabelEventArgs e)
        {
            RangeSlider range = sender as RangeSlider;
            e.Handled = true;
            e.Text = "$" + ((Double)e.Value).ToString() + ".00";
            if (range.ThemeName == "HighContrastBlack")
            {
                e.ForeColor = ColorTranslator.FromHtml("#ffffff");
            }
            else if (range.ThemeName == "Office2019Colorful")
            {
                e.ForeColor = ColorTranslator.FromHtml("#444444");
            }
        }

        private void rangeSlider3_DrawLabel(object sender, DrawLabelEventArgs e)
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
            if (range.ThemeName == "HighContrastBlack")
            {
                e.ForeColor = ColorTranslator.FromHtml("#ffffff");
            }
            else if (range.ThemeName == "Office2019Colorful")
            {
                e.ForeColor = ColorTranslator.FromHtml("#444444");
            }
        }

        private void rangeSlider2_DrawLabel_1(object sender, DrawLabelEventArgs e)
        {
            RangeSlider range = sender as RangeSlider;
            e.Handled = true;
            e.Text = e.Value.ToString() + " Km";
            if(range.ThemeName== "HighContrastBlack")
            {
                e.ForeColor = ColorTranslator.FromHtml("#ffffff");
            }
            else if (range.ThemeName == "Office2019Colorful")
            {
                e.ForeColor = ColorTranslator.FromHtml("#444444");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sfComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.sfComboBox1.SelectedItem.ToString() == "Office2019Colorful")
            {
                this.BackColor = ColorTranslator.FromHtml("#f3f3f3");
                SkinManager.SetVisualStyle(this, "Office2019Colorful");
            }
            else if (this.sfComboBox1.SelectedItem.ToString() == "HighContrastBlack")
            {
                this.BackColor = ColorTranslator.FromHtml("#000000");
                SkinManager.SetVisualStyle(this, "HighContrastBlack");
            }
            else if (this.sfComboBox1.SelectedItem.ToString() == "Office2016Colorful")
            {
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                SkinManager.SetVisualStyle(this, "Office2016Colorful");
            }
            else if (this.sfComboBox1.SelectedItem.ToString() == "Office2016White")
            {
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                SkinManager.SetVisualStyle(this, "Office2016White");
            }
            else if (this.sfComboBox1.SelectedItem.ToString() == "Office2016DarkGray")
            {
                this.BackColor = ColorTranslator.FromHtml("#666666");
                SkinManager.SetVisualStyle(this, "Office2016DarkGray");
            }
            else if (this.sfComboBox1.SelectedItem.ToString() == "Office2016Black")
            {
                this.BackColor = ColorTranslator.FromHtml("#252525");
                SkinManager.SetVisualStyle(this, "Office2016Black");
            }
        }

        private void borderPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
