#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Licensing;
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

namespace EditorControls
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
            this.sfComboBox1.DataSource = style;
            this.sfComboBox1.SelectedIndex = 0;
            this.sfComboBox1.AllowDropDownResize = false;

            bannerTextProvider1 = new BannerTextProvider();

            this.domainUpDownExt1.SelectedIndex = 0;
            this.domainUpDownExt2.SelectedIndex = 0;
            this.domainUpDownExt3.SelectedIndex = 0;
            this.domainUpDownExt6.SelectedIndex = 0;
            this.domainUpDownExt7.SelectedIndex = 0;
            this.numericUpDownExt4.ResetText();
            this.numericUpDownExt5.ResetText();

            this.bannerTextProvider1.SetBannerText(this.numericUpDownExt4, new BannerTextInfo("Choose a value", true, new Font("Segoe UI", 8.25F, FontStyle.Regular), Color.Gray, BannerTextMode.EditMode));
            this.bannerTextProvider1.SetBannerText(this.numericUpDownExt5, new BannerTextInfo("Choose a value", true, new Font("Segoe UI", 8.25F, FontStyle.Regular), Color.Gray, BannerTextMode.FocusMode));
            this.bannerTextProvider1.SetBannerText(this.domainUpDownExt4, new BannerTextInfo("Choose a value", true, new Font("Segoe UI", 8.25F, FontStyle.Regular), Color.Gray, BannerTextMode.EditMode));
            this.bannerTextProvider1.SetBannerText(this.domainUpDownExt5, new BannerTextInfo("Choose a value", true, new Font("Segoe UI", 8.25F, FontStyle.Regular), Color.Gray, BannerTextMode.FocusMode));

            this.domainUpDownExt1.Font = new System.Drawing.Font("Microsoft Sans Serif",10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainUpDownExt2.Font = new System.Drawing.Font("Microsoft Sans Serif",10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainUpDownExt3.Font = new System.Drawing.Font("Microsoft Sans Serif",10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainUpDownExt4.Font = new System.Drawing.Font("Microsoft Sans Serif",10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainUpDownExt5.Font = new System.Drawing.Font("Microsoft Sans Serif",10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainUpDownExt6.Font = new System.Drawing.Font("Microsoft Sans Serif",10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainUpDownExt7.Font = new System.Drawing.Font("Microsoft Sans Serif",10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
        }

        #endregion

        #region Methods

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

        static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            SkinManager.LoadAssembly(typeof(Syncfusion.WinForms.Themes.Office2019Theme).Assembly);
            SkinManager.LoadAssembly(typeof(Syncfusion.WinForms.Themes.Office2016Theme).Assembly);
            SkinManager.LoadAssembly(typeof(Syncfusion.HighContrastTheme.WinForms.HighContrastTheme).Assembly);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private void sfComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.sfComboBox1.SelectedItem.ToString() == "Office2019Colorful")
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

        #endregion
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
