#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GettingStarted
{
    public partial class Form1 : MetroForm
    {
        bool isDefaultTheme = false;
        public Form1()
        {
            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            themeComboBoxSettings();
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
        /// <summary>
        /// ComboBox settings
        /// </summary>
        private void themeComboBoxSettings()
        {
            List<string> list = new List<string>();
            list.AddRange(new string[]
            {
            "Default",
            "Office2007Black",
            "Office2007Blue",
            "Office2007Managed",
            "Office2007Silver",
            "Office2010Black",
            "Office2010Blue",
            "Office2010Managed",
            "Office2010Silver",
            "Metro",
            "Office2013DarkGray",
            "Office2013LightGray",
            "Office2013White",
            "Office2016Colorful",
            "Office2016DarkGray",
            "Office2016White" });
            this.themeComboBox.DataSource = list;
            this.themeComboBox.SelectedValue = "Metro";
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
        }

        /// <summary>
        /// Change the theme for MessageBoxAdv.
        /// </summary>
        private void themeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.themeComboBox.SelectedItem.ToString() == "Default")
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Default;
                MessageBoxAdv.UseDefaultTheme = true;
            }
            if (this.themeComboBox.SelectedItem.ToString() == "Office2007Black")
            {
                MessageBoxAdv.Office2007Theme = Office2007Theme.Black;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Default;
                MessageBoxAdv.UseDefaultTheme = isDefaultTheme ? false : isDefaultTheme;
                setOffice2007Theme();
            }
            if (this.themeComboBox.SelectedItem.ToString() == "Office2007Blue")
            {
                MessageBoxAdv.Office2007Theme = Office2007Theme.Blue;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Default;
                MessageBoxAdv.UseDefaultTheme = isDefaultTheme ? false : isDefaultTheme;
                setOffice2007Theme();
            }
            if (this.themeComboBox.SelectedItem.ToString() == "Office2007Managed")
            {
                MessageBoxAdv.Office2007Theme = Office2007Theme.Managed;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Default;
                Office2007Colors.ApplyManagedColors(this, Color.Red);
                MessageBoxAdv.UseDefaultTheme = isDefaultTheme ? false : isDefaultTheme;
                setOffice2007Theme();
            }
            if (this.themeComboBox.SelectedItem.ToString() == "Office2007Silver")
            {
                MessageBoxAdv.Office2007Theme = Office2007Theme.Silver;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Default;
                MessageBoxAdv.UseDefaultTheme = isDefaultTheme ? false : isDefaultTheme;
                setOffice2007Theme();
            }
            if (this.themeComboBox.SelectedItem.ToString() == "Office2010Black")
            {
                MessageBoxAdv.Office2010Theme = Office2010Theme.Black;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2010;
                MessageBoxAdv.UseDefaultTheme = isDefaultTheme ? false : isDefaultTheme;
                setOffice2010Theme();
            }
            if (this.themeComboBox.SelectedItem.ToString() == "Office2010Blue")
            {
                MessageBoxAdv.Office2010Theme = Office2010Theme.Blue;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2010;
                MessageBoxAdv.UseDefaultTheme = isDefaultTheme ? false : isDefaultTheme;
                setOffice2010Theme();
            }
            if (this.themeComboBox.SelectedItem.ToString() == "Office2010Managed")
            {
                MessageBoxAdv.Office2010Theme = Office2010Theme.Managed;
                Office2010Colors.ApplyManagedColors(this, Color.Brown);
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2010;
                MessageBoxAdv.UseDefaultTheme = isDefaultTheme ? false : isDefaultTheme;
                setOffice2010Theme();
            }
            if (this.themeComboBox.SelectedItem.ToString() == "Office2010Silver")
            {
                MessageBoxAdv.Office2010Theme = Office2010Theme.Silver;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2010;
                MessageBoxAdv.UseDefaultTheme = isDefaultTheme ? false : isDefaultTheme;
                setOffice2010Theme();
            }
            if (this.themeComboBox.SelectedItem.ToString() == "Metro")
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.UseDefaultTheme = isDefaultTheme ? false : isDefaultTheme;
                setMetroTheme();

            }
            if (this.themeComboBox.SelectedItem.ToString() == "Office2013DarkGray")
            {
                MessageBoxAdv.Office2013Theme = Office2013Theme.DarkGray;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2013;
                MessageBoxAdv.UseDefaultTheme = isDefaultTheme ? false : isDefaultTheme;
            }
            if (this.themeComboBox.SelectedItem.ToString() == "Office2013LightGray")
            {
                MessageBoxAdv.Office2013Theme = Office2013Theme.LightGray;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2013;
                MessageBoxAdv.UseDefaultTheme = isDefaultTheme ? false : isDefaultTheme;
            }
            if (this.themeComboBox.SelectedItem.ToString() == "Office2013White")
            {
                MessageBoxAdv.Office2013Theme = Office2013Theme.White;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2013;
                MessageBoxAdv.UseDefaultTheme = isDefaultTheme ? false : isDefaultTheme;
            }
            if (this.themeComboBox.SelectedItem.ToString() == "Office2016Colorful")
            {
                MessageBoxAdv.Office2016Theme = Office2016Theme.Colorful;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2016;
                MessageBoxAdv.UseDefaultTheme = isDefaultTheme ? false : isDefaultTheme;
                setOffice2016Theme();
            }
            if (this.themeComboBox.SelectedItem.ToString() == "Office2016DarkGray")
            {
                MessageBoxAdv.Office2016Theme = Office2016Theme.DarkGray;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2016;
                MessageBoxAdv.UseDefaultTheme = isDefaultTheme ? false : isDefaultTheme;
                setOffice2016Theme();
            }
            if (this.themeComboBox.SelectedItem.ToString() == "Office2016White")
            {
                MessageBoxAdv.Office2016Theme = Office2016Theme.White;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2016;
                MessageBoxAdv.UseDefaultTheme = isDefaultTheme ? false : isDefaultTheme;
                setOffice2016Theme();
            }
        }

        private void setOffice2007Theme()
        {
            if (themeComboBox.SelectedItem.ToString() == "Office2007Black")
            {
                this.btn_custom.Appearance = ButtonAppearance.Office2007;
                this.btn_custom.Office2007ColorScheme = Office2007Theme.Black;
                this.btn_confirmation.Appearance = ButtonAppearance.Office2007;
                this.btn_confirmation.Office2007ColorScheme = Office2007Theme.Black;
                this.btn_errormsg.Appearance = ButtonAppearance.Office2007;
                this.btn_errormsg.Office2007ColorScheme = Office2007Theme.Black;
                this.btn_infomsg.Appearance = ButtonAppearance.Office2007;
                this.btn_infomsg.Office2007ColorScheme = Office2007Theme.Black;
                this.btn_warning.Appearance = ButtonAppearance.Office2007;
                this.btn_warning.Office2007ColorScheme = Office2007Theme.Black;
            }
            else if (themeComboBox.SelectedItem.ToString() == "Office2007Blue")
            {
                this.btn_custom.Appearance = ButtonAppearance.Office2007;
                this.btn_custom.Office2007ColorScheme = Office2007Theme.Blue;
                this.btn_confirmation.Appearance = ButtonAppearance.Office2007;
                this.btn_confirmation.Office2007ColorScheme = Office2007Theme.Blue;
                this.btn_errormsg.Appearance = ButtonAppearance.Office2007;
                this.btn_errormsg.Office2007ColorScheme = Office2007Theme.Blue;
                this.btn_infomsg.Appearance = ButtonAppearance.Office2007;
                this.btn_infomsg.Office2007ColorScheme = Office2007Theme.Blue;
                this.btn_warning.Appearance = ButtonAppearance.Office2007;
                this.btn_warning.Office2007ColorScheme = Office2007Theme.Blue;
            }
            else if (themeComboBox.SelectedItem.ToString() == "Office2007Silver")
            {
                this.btn_custom.Appearance = ButtonAppearance.Office2007;
                this.btn_custom.Office2007ColorScheme = Office2007Theme.Silver;
                this.btn_confirmation.Appearance = ButtonAppearance.Office2007;
                this.btn_confirmation.Office2007ColorScheme = Office2007Theme.Silver;
                this.btn_errormsg.Appearance = ButtonAppearance.Office2007;
                this.btn_errormsg.Office2007ColorScheme = Office2007Theme.Silver;
                this.btn_infomsg.Appearance = ButtonAppearance.Office2007;
                this.btn_infomsg.Office2007ColorScheme = Office2007Theme.Silver;
                this.btn_warning.Appearance = ButtonAppearance.Office2007;
                this.btn_warning.Office2007ColorScheme = Office2007Theme.Silver;
            }
            else
            {
                this.btn_custom.Appearance = ButtonAppearance.Office2007;
                this.btn_custom.Office2007ColorScheme = Office2007Theme.Managed;
                this.btn_confirmation.Appearance = ButtonAppearance.Office2007;
                this.btn_confirmation.Office2007ColorScheme = Office2007Theme.Managed;
                this.btn_errormsg.Office2007ColorScheme = Office2007Theme.Managed;
                this.btn_infomsg.Appearance = ButtonAppearance.Office2007;
                this.btn_infomsg.Office2007ColorScheme = Office2007Theme.Managed;
                this.btn_warning.Appearance = ButtonAppearance.Office2007;
                this.btn_warning.Office2007ColorScheme = Office2007Theme.Managed;
            }
        }
        private void setOffice2010Theme()
        {
            if (themeComboBox.SelectedItem.ToString() == "Office2010Black")
            {
                this.btn_custom.Appearance = ButtonAppearance.Office2010;
                this.btn_custom.Office2010ColorScheme = Office2010Theme.Black;
                this.btn_confirmation.Appearance = ButtonAppearance.Office2010;
                this.btn_confirmation.Office2010ColorScheme = Office2010Theme.Black;
                this.btn_errormsg.Appearance = ButtonAppearance.Office2010;
                this.btn_errormsg.Office2010ColorScheme = Office2010Theme.Black;
                this.btn_infomsg.Appearance = ButtonAppearance.Office2010;
                this.btn_infomsg.Office2010ColorScheme = Office2010Theme.Black;
                this.btn_warning.Appearance = ButtonAppearance.Office2010;
                this.btn_warning.Office2010ColorScheme = Office2010Theme.Black;
            }
            else if (themeComboBox.SelectedItem.ToString() == "Office2010Blue")
            {
                this.btn_custom.Appearance = ButtonAppearance.Office2010;
                this.btn_custom.Office2010ColorScheme = Office2010Theme.Blue;
                this.btn_confirmation.Appearance = ButtonAppearance.Office2010;
                this.btn_confirmation.Office2010ColorScheme = Office2010Theme.Blue;
                this.btn_errormsg.Appearance = ButtonAppearance.Office2010;
                this.btn_errormsg.Office2010ColorScheme = Office2010Theme.Blue;
                this.btn_infomsg.Appearance = ButtonAppearance.Office2010;
                this.btn_infomsg.Office2010ColorScheme = Office2010Theme.Blue;
                this.btn_warning.Appearance = ButtonAppearance.Office2010;
                this.btn_warning.Office2010ColorScheme = Office2010Theme.Blue;
            }
            else if (themeComboBox.SelectedItem.ToString() == "Office2010Silver")
            {
                this.btn_custom.Appearance = ButtonAppearance.Office2010;
                this.btn_custom.Office2010ColorScheme = Office2010Theme.Silver;
                this.btn_confirmation.Appearance = ButtonAppearance.Office2010;
                this.btn_confirmation.Office2010ColorScheme = Office2010Theme.Silver;
                this.btn_errormsg.Appearance = ButtonAppearance.Office2010;
                this.btn_errormsg.Office2010ColorScheme = Office2010Theme.Silver;
                this.btn_infomsg.Appearance = ButtonAppearance.Office2010;
                this.btn_infomsg.Office2010ColorScheme = Office2010Theme.Silver;
                this.btn_warning.Appearance = ButtonAppearance.Office2010;
                this.btn_warning.Office2010ColorScheme = Office2010Theme.Silver;
            }
            else
            {
                this.btn_custom.Appearance = ButtonAppearance.Office2010;
                this.btn_custom.Office2010ColorScheme = Office2010Theme.Managed;
                this.btn_confirmation.Appearance = ButtonAppearance.Office2010;
                this.btn_confirmation.Office2010ColorScheme = Office2010Theme.Managed;
                this.btn_errormsg.Appearance = ButtonAppearance.Office2010;
                this.btn_errormsg.Office2010ColorScheme = Office2010Theme.Managed;
                this.btn_infomsg.Appearance = ButtonAppearance.Office2010;
                this.btn_infomsg.Office2010ColorScheme = Office2010Theme.Managed;
                this.btn_warning.Appearance = ButtonAppearance.Office2010;
                this.btn_warning.Office2010ColorScheme = Office2010Theme.Managed;
            }
        }
        private void setOffice2016Theme()
        {
            if (themeComboBox.SelectedItem.ToString() == "Office2016Black")
            {
                this.btn_custom.Appearance = ButtonAppearance.Office2016Black;                
                this.btn_confirmation.Appearance = ButtonAppearance.Office2016Black;                
                this.btn_errormsg.Appearance = ButtonAppearance.Office2016Black;                
                this.btn_infomsg.Appearance = ButtonAppearance.Office2016Black;
                this.btn_warning.Appearance = ButtonAppearance.Office2016Black;
            }
            else if (themeComboBox.SelectedItem.ToString() == "Office2016Colorful")
            {
                this.btn_custom.Appearance = ButtonAppearance.Office2016Colorful;
                this.btn_confirmation.Appearance = ButtonAppearance.Office2016Colorful;
                this.btn_errormsg.Appearance = ButtonAppearance.Office2016Colorful;
                this.btn_infomsg.Appearance = ButtonAppearance.Office2016Colorful;
                this.btn_warning.Appearance = ButtonAppearance.Office2016Colorful;
            }
            else if (themeComboBox.SelectedItem.ToString() == "Office2016DarkGray")
            {
                this.btn_custom.Appearance = ButtonAppearance.Office2016DarkGray;
                this.btn_confirmation.Appearance = ButtonAppearance.Office2016DarkGray;
                this.btn_errormsg.Appearance = ButtonAppearance.Office2016DarkGray;
                this.btn_infomsg.Appearance = ButtonAppearance.Office2016DarkGray;
                this.btn_warning.Appearance = ButtonAppearance.Office2016DarkGray;
            }
            else
            {
                this.btn_custom.Appearance = ButtonAppearance.Office2016White;
                this.btn_confirmation.Appearance = ButtonAppearance.Office2016White;
                this.btn_errormsg.Appearance = ButtonAppearance.Office2016White;
                this.btn_infomsg.Appearance = ButtonAppearance.Office2016White;
                this.btn_warning.Appearance = ButtonAppearance.Office2016White;
            }
        }
        private void setMetroTheme()
        {
            this.btn_confirmation.Appearance = ButtonAppearance.Metro;
            this.btn_custom.Appearance = ButtonAppearance.Metro;
            this.btn_errormsg.Appearance = ButtonAppearance.Metro;
            this.btn_infomsg.Appearance = ButtonAppearance.Metro;
            this.btn_warning.Appearance = ButtonAppearance.Metro;
        }
        
        /// <summary>
        /// Show Error Message
        /// </summary>
        private void btn_errormsg_Click(object sender, EventArgs e)
        {
            string errorMessage = "Windows cannot install required files. The file may be corrupt or missing. Make sure all files " +
                "required for installation are available, and restart the installation.Error code:0x80070570";
            string details = "The file may be corrupt or missing. Make sure all files " +
                "required for installation are available, and restart the installation.Error code:0x80070570";
            MessageBoxAdv.Show(errorMessage, "Install Windows", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error,
              details);
        }

        /// <summary>
        /// Show Notification Message
        /// </summary>
        private void btn_infomsg_Click(object sender, EventArgs e)
        {
            string errorMessage = "Windows installed new updates. Your computer was restarted to finish installing updates.";
            MessageBoxAdv.Show(errorMessage, "Windows Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information); 
        }

        /// <summary>
        /// Show Warning Message
        /// </summary>
        private void btn_question_Click(object sender, EventArgs e)
        {
            string errorMessage = "There is a problem with this Windows Installer package.\nA program required for this install to complete could not be run.\nContact your support personnel or package vendor.";
            MessageBoxAdv.Show(errorMessage, "Windows Installation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Show Confirmation Message
        /// </summary>
        private void btn_warning_Click(object sender, EventArgs e)
        {
            string errorDetails = "Formatting this volume will erase all data on it.\n\nDo you want to continue?";
            MessageBoxAdv.Show(errorDetails, "Delete Disk", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
        }

        /// <summary>
        /// Show message with custom buttons
        /// </summary>
        private void btn_custom_Click(object sender, EventArgs e)
        {
            Image image = (Image) global::GettingStarted.Properties.Resources.print;
            Size imageSize = new System.Drawing.Size(image.Width,image.Height);
            string errorMessage = "Do you want to print this page?";
            string details = "To print this page, click Yes otherwise click No to exit.";
            string[] customButtons = new string[] { "Yes", "No", "Help" };
            MessageBoxAdv.Show(this, errorMessage, "Print", customButtons, image, imageSize);
        }
    }
}
