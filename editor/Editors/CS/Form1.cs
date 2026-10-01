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
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TextBox_Demo
{
    public partial class Form1 : Form
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
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
            this.textBoxExt13.Text = "1.United States of America" + Environment.NewLine + Environment.NewLine + "2.United Kingdom" + Environment.NewLine + Environment.NewLine + "3.Spain"+Environment.NewLine+Environment.NewLine+"4.Sweden";
            this.textBoxExt15.Text = "We are a leading provider of software components and tools for the Microsoft .NET platform. " + Environment.NewLine + Environment.NewLine +
                "Powerful and feature-rich, Syncfusion's broad range of products are vital to mission-critical applications in organizations ranging from small businesses to multinational Fortune 100 companies.";
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

        private void textBoxExt8_Enter(object sender, EventArgs e)
        {
            Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt = (Syncfusion.Windows.Forms.Tools.TextBoxExt)sender;

            ToolTip toolTip = new ToolTip();
            toolTip.Show("TextBoxExt", textBoxExt, 1000);
        }

        private void textBoxExt14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
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
