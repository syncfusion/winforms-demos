#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
using System.Drawing;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;

namespace SfNumericTextBoxDemo
{
    public partial class GettingStarted : SfForm
    {
        #region Constructor

        /// <summary>
        /// Initialize the new instance of <see cref="GettingStarted"/> class.
        /// </summary>
        public GettingStarted()
        {
            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
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
            this.ValidationTextBox.ValueChanged += ValidationTextBox_ValueChanged;
            this.ValidationTextBox.NumberFormatInfo = new System.Globalization.NumberFormatInfo() { NumberGroupSeparator = "", NumberDecimalDigits = 0};
        }

        #endregion

        #region Events

        /// <summary>
        /// Validates the control and updated the error message for <see cref="ValidationTextBox"/>.
        /// </summary>
        /// <param name="sender"><see cref="ValidationTextBox"/>.</param>
        /// <param name="e">Event args that contains new value and old value.</param>
        private void ValidationTextBox_ValueChanged(object sender, Syncfusion.WinForms.Input.Events.ValueChangedEventArgs e)
        {
            if((this.ValidationTextBox.Value >= 1000000000 && this.ValidationTextBox.Value <= 9999999999) || this.ValidationTextBox.Value == null)
            {
                this.errorProvider.SetError(this.ValidationTextBox, string.Empty);
                this.ValidationTextBox.Style.FocusBorderColor = this.ValidationTextBox.Style.BorderColor = ColorTranslator.FromHtml("#7A7A7A");
            }
            else
            {
                this.errorProvider.SetError(this.ValidationTextBox, "Invalid mobile number.");
                this.ValidationTextBox.Style.FocusBorderColor = this.ValidationTextBox.Style.BorderColor = Color.Red;
            }
        }

        #endregion

        #region Methods.

        /// <summary>
        /// Gets the icon.
        /// </summary>
        /// <param name="bitmapName">Bitmap image.</param>
        /// <returns>Location of the bitmap image.</returns>
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

        private void sfComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
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
}
