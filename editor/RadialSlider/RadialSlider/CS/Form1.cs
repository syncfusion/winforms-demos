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
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using System.Text.RegularExpressions;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Controls;

namespace Radial
{
    public partial class Form1 : SfForm
    {
        #region Initialization
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
            this.sfComboBox1.DataSource = style;
            this.sfComboBox1.SelectedIndex = 0;
            this.textBoxExt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = this.Size;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
        }

       
        #endregion
        #region Form Icon
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

        Char[] unallowedchar = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+' };
        #region VisualStyle        

        private void textBoxExt1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < unallowedchar.Length; i++)
                {
                    {
                        if (textBoxExt1.Text.Contains(unallowedchar[i]))
                        {
                            textBoxExt1.Text = String.Empty;
                            MessageBoxAdv.Show("No special characters allowed", "Invalid Input");
                        }
                    }
                }
                if (textBoxExt1.Text != string.Empty)
                {
                    this.radialSlider1.MaximumValue = Convert.ToInt32(this.textBoxExt1.Text.ToString());
                    this.radialSlider2.MaximumValue = Convert.ToInt32(this.textBoxExt1.Text.ToString());
                }
            }
            catch (Exception)
            {
            }
           
        }

        private void textBoxExt2_TextChanged(object sender, EventArgs e)
        {
            try
            {

                for (int i = 0; i < unallowedchar.Length; i++)
                {
                    {
                        if (textBoxExt2.Text.Contains(unallowedchar[i]))
                        {
                            textBoxExt2.Text = String.Empty;
                            MessageBoxAdv.Show("No special characters allowed", "Invalid Input");
                        }
                    }
                }

                if (textBoxExt2.Text != string.Empty)
                {
                    this.radialSlider1.SliderDivision = Convert.ToInt32(this.textBoxExt2.Text);
                    this.radialSlider2.SliderDivision = Convert.ToInt32(this.textBoxExt2.Text);
                }
            }
            catch (Exception)
            {
            }
        }

        
        private void textBoxExt3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < unallowedchar.Length; i++)
                {
                    {
                        if (textBoxExt3.Text.Contains(unallowedchar[i]))
                        {
                            textBoxExt3.Text = String.Empty;
                            MessageBoxAdv.Show("No special characters allowed", "Invalid Input");
                        }
                    }
                }
                if (textBoxExt1.Text != string.Empty)
                {
                    this.radialSlider1.MinimumValue = Convert.ToInt32(this.textBoxExt3.Text.ToString());
                    this.radialSlider2.MinimumValue = Convert.ToInt32(this.textBoxExt3.Text.ToString());
                }
            }
            catch (Exception)
            {
            }
        }

        private void sfComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.sfComboBox1.SelectedItem.ToString() == "Office2019Colorful")
            {               
                SkinManager.SetVisualStyle(this, "Office2019Colorful");
                this.BackColor = ColorTranslator.FromHtml("#f3f3f3");
            }
            else if (this.sfComboBox1.SelectedItem.ToString() == "HighContrastBlack")
            {                
                SkinManager.SetVisualStyle(this, "HighContrastBlack");
                this.BackColor = ColorTranslator.FromHtml("#000000");
            }
            else if (this.sfComboBox1.SelectedItem.ToString() == "Office2016Colorful")
            {
                SkinManager.SetVisualStyle(this, "Office2016Colorful");
                this.BackColor = ColorTranslator.FromHtml("#f4f4f4");
            }
            else if (this.sfComboBox1.SelectedItem.ToString() == "Office2016White")
            {                
                SkinManager.SetVisualStyle(this, "Office2016White");
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
            }
            else if (this.sfComboBox1.SelectedItem.ToString() == "Office2016DarkGray")
            {               
                SkinManager.SetVisualStyle(this, "Office2016DarkGray");
                this.BackColor = ColorTranslator.FromHtml("#666666");
            }
            else if (this.sfComboBox1.SelectedItem.ToString() == "Office2016Black")
            {
                SkinManager.SetVisualStyle(this, "Office2016Black");
                this.BackColor = ColorTranslator.FromHtml("#252525");
            }

        }
    }
    #endregion

}
