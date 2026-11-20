#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
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

namespace FontListBox_GettingStarted
{
    public partial class Form1 : SfForm
    {
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
            this.fontComboBox2.SelectedItem = "Segoe UI";
            this.fontListBox1.Focus();
            this.scrollersFrame1.AttachedTo = this.fontListBox1;
            this.fontComboBox2.Items.Remove("HoloLens MDL2 Assets");
            this.fontComboBox2.Items.Remove("Bookshelf Symbol 7");
            this.fontComboBox2.Items.Remove("Cambria Math");
            this.fontComboBox2.Items.Remove("Marlett");
            this.fontComboBox2.Items.Remove("MS Outlook");
            this.fontComboBox2.Items.Remove("MS Reference Specialty");
            this.fontComboBox2.Items.Remove("MT Extra");
            this.fontComboBox2.Items.Remove("Segoe MDL2 Assets");
            this.fontComboBox2.Items.Remove("Webdings");
            this.fontComboBox2.Items.Remove("Wingdings");
            this.fontComboBox2.Items.Remove("Wingdings 2");
            this.fontComboBox2.Items.Remove("Wingdings 3");
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
        }


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

        private void fontComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label4.Font = new Font(this.fontComboBox2.SelectedItem.ToString(),10,FontStyle.Regular);
            this.fontListBox1.SelectedItem = this.fontComboBox2.SelectedItem;
        }

        private void fontListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label4.Font = new Font(this.fontListBox1.SelectedItem.ToString(), 10, FontStyle.Regular);
            this.fontComboBox2.SelectedItem = this.fontListBox1.SelectedItem;
        }

        private void sfComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.sfComboBox1.SelectedItem.ToString() == "Office2019Colorful")
            {
                this.label4.ForeColor = ColorTranslator.FromHtml("#000000");
                this.BackColor = ColorTranslator.FromHtml("#f3f3f3");
                SkinManager.SetVisualStyle(this, "Office2019Colorful");
            }
            else if (this.sfComboBox1.SelectedItem.ToString() == "HighContrastBlack")
            {
                this.label4.ForeColor = ColorTranslator.FromHtml("#ffffff");
                this.BackColor = ColorTranslator.FromHtml("#000000");
                SkinManager.SetVisualStyle(this, "HighContrastBlack");
                
            }
            else if (this.sfComboBox1.SelectedItem.ToString() == "Office2016Colorful")
            {
                this.label4.ForeColor = ColorTranslator.FromHtml("#000000");
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                SkinManager.SetVisualStyle(this, "Office2016Colorful");
            }
            else if (this.sfComboBox1.SelectedItem.ToString() == "Office2016White")
            {
                this.label4.ForeColor = ColorTranslator.FromHtml("#000000");
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                SkinManager.SetVisualStyle(this, "Office2016White");
            }
            else if (this.sfComboBox1.SelectedItem.ToString() == "Office2016DarkGray")
            {
                this.label4.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.BackColor = ColorTranslator.FromHtml("#666666");
                SkinManager.SetVisualStyle(this, "Office2016DarkGray");
            }
            else if (this.sfComboBox1.SelectedItem.ToString() == "Office2016Black")
            {
                this.label4.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.BackColor = ColorTranslator.FromHtml("#252525");
                SkinManager.SetVisualStyle(this, "Office2016Black");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void autoLabel10_Click(object sender, EventArgs e)
        {

        }
    }

    /// <summary>
    /// Represents a class that is used to find the licensing file for Syncfusion controls.
    /// </summary>
    public class DemoCommon
    {
        /// <summary>
        /// Finds the license key from the Common folder.
        /// </summary>
        /// <returns>Returns the license key.</returns>
        public static string FindLicenseKey()
        {
            string licenseKeyFile = "..\\Common\\SyncfusionLicense.txt";
            for (int n = 0; n < 20; n++)
            {
                if (!System.IO.File.Exists(licenseKeyFile))
                {
                    licenseKeyFile = @"..\" + licenseKeyFile;
                    continue;
                }
                return File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }
}
