#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.Input;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace UnitConverterDemo
{
    public partial class MainForm : SfForm
    {
        public MainForm()
        {
            InitializeComponent();
            this.splitContainer1.TabStop = false;
            this.saNumericTextBox.NumberFormatInfo = new CultureInfo("en-za").NumberFormat;
            this.usNumericTextBox.NumberFormatInfo = new CultureInfo("en-US").NumberFormat;
            this.brNumericTextBox.NumberFormatInfo = new CultureInfo("en-GB").NumberFormat;
            this.germanNumericTextBox.NumberFormatInfo = new CultureInfo("de-DE").NumberFormat;
            this.turkeyTextBox.NumberFormatInfo = new CultureInfo("tr-TR").NumberFormat;
            this.japanNumericTextBox.NumberFormatInfo = new CultureInfo("ja-JP").NumberFormat;
            this.chNumericTextBox.NumberFormatInfo = new CultureInfo("zh-Hans").NumberFormat;
            this.indNumericTextBox.NumberFormatInfo = new CultureInfo("en-IN").NumberFormat;
            this.usNumericTextBox.Value = 1;
            this.celNumericTextBox.Value = 1;
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

        private void TemperatureValueChanged(object sender, Syncfusion.WinForms.Input.Events.ValueChangedEventArgs e)
        {
            if ((sender as SfNumericTextBox).Value != null && e.NewValue != e.OldValue)
            {
                if ((sender as SfNumericTextBox).Name.Equals("celNumericTextBox"))
                {
                    this.farNumericTextBox.Value = Math.Round((double)this.celNumericTextBox.Value * 1.8 + 32, 2);
                    this.ranNumericTextBox.Value = Math.Round((double)this.celNumericTextBox.Value * 1.8 + 491.67, 2);
                    this.kelNumericTextBox.Value = Math.Round((double)this.celNumericTextBox.Value + 273.15, 2);
                }
                else if ((sender as SfNumericTextBox).Name.Equals("farNumericTextBox"))
                {
                    this.celNumericTextBox.Value = Math.Round(((double)this.farNumericTextBox.Value - 32) / 1.8, 2);
                    this.kelNumericTextBox.Value = Math.Round((double)this.celNumericTextBox.Value + 273.15, 2);
                    this.ranNumericTextBox.Value = Math.Round((double)this.celNumericTextBox.Value * 1.8 + 491.67, 2);
                }
                else if ((sender as SfNumericTextBox).Name.Equals("kelNumericTextBox"))
                {
                    this.celNumericTextBox.Value = Math.Round((double)this.kelNumericTextBox.Value - 273.15, 2);
                    this.farNumericTextBox.Value = Math.Round((double)this.celNumericTextBox.Value * 1.8 + 32, 2);
                    this.ranNumericTextBox.Value = Math.Round((double)this.celNumericTextBox.Value * 1.8 + 491.67, 2);
                }
                else if ((sender as SfNumericTextBox).Name.Equals("ranNumericTextBox"))
                {
                    this.celNumericTextBox.Value = Math.Round(((double)this.ranNumericTextBox.Value - 491.67) / 1.8, 2);
                    this.kelNumericTextBox.Value = Math.Round((double)this.celNumericTextBox.Value + 273.15, 2);
                    this.farNumericTextBox.Value = Math.Round((double)this.celNumericTextBox.Value * 1.8 + 32, 2);
                }
            }
        }

        private void CurrencyValueChanged(object sender, Syncfusion.WinForms.Input.Events.ValueChangedEventArgs e)
        {
            if ((sender as SfNumericTextBox).Value != null && e.NewValue != e.OldValue)
            {
                if ((sender as SfNumericTextBox).Name.Equals("usNumericTextBox"))
                {
                    this.turkeyTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 3.78, 2);
                    this.chNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 6.21, 2);
                    this.indNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 64.09, 2);
                    this.japanNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 123.55, 2);
                    this.germanNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 0.8905, 2);
                    this.brNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 0.807, 2);
                    this.saNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 13.39, 2);
                }
                if ((sender as SfNumericTextBox).Name.Equals("turkeyTextBox"))
                {
                    this.usNumericTextBox.Value = Math.Round((double)this.turkeyTextBox.Value / 3.78, 2);
                    this.chNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 6.21, 2);
                    this.indNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 64.09, 2);
                    this.japanNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 123.55, 2);
                    this.germanNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 0.8905, 2);
                    this.brNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 0.807, 2);
                    this.saNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 13.39, 2);
                }
                if ((sender as SfNumericTextBox).Name.Equals("chNumericTextBox"))
                {
                    this.usNumericTextBox.Value = Math.Round((double)this.chNumericTextBox.Value / 6.21, 2);
                    this.turkeyTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 3.78, 2);
                    this.indNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 64.09, 2);
                    this.japanNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 123.55, 2);
                    this.germanNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 0.8905, 2);
                    this.brNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 0.807, 2);
                    this.saNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 13.39, 2);
                }
                if ((sender as SfNumericTextBox).Name.Equals("japanNumericTextBox"))
                {
                    this.usNumericTextBox.Value = Math.Round((double)this.japanNumericTextBox.Value / 123.55, 2);
                    this.turkeyTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 3.78, 2);
                    this.chNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 6.21, 2);
                    this.indNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 64.09, 2);
                    this.germanNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 0.8905, 2);
                    this.brNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 0.807, 2);
                    this.saNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 13.39, 2);
                }
                if ((sender as SfNumericTextBox).Name.Equals("indNumericTextBox"))
                {
                    this.usNumericTextBox.Value = Math.Round((double)this.indNumericTextBox.Value / 64.09, 2);
                    this.turkeyTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 3.78, 2);
                    this.chNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 6.21, 2);
                    this.japanNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 123.55, 2);
                    this.germanNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 0.8905, 2);
                    this.brNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 0.807, 2);
                    this.saNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 13.39, 2);
                }
                if ((sender as SfNumericTextBox).Name.Equals("germanNumericTextBox"))
                {
                    this.usNumericTextBox.Value = Math.Round((double)this.germanNumericTextBox.Value / 0.8905, 2);
                    this.turkeyTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 3.78, 2);
                    this.chNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 6.21, 2);
                    this.indNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 64.09, 2);
                    this.japanNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 123.55, 2);
                    this.brNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 0.807, 2);
                    this.saNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 13.39, 2);
                }
                if ((sender as SfNumericTextBox).Name.Equals("brNumericTextBox"))
                {
                    this.usNumericTextBox.Value = Math.Round((double)this.brNumericTextBox.Value / 0.807, 2);
                    this.turkeyTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 3.78, 2);
                    this.chNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 6.21, 2);
                    this.indNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 64.09, 2);
                    this.japanNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 123.55, 2);
                    this.germanNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 0.8905, 2);
                    this.saNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 13.39, 2);
                }
                if ((sender as SfNumericTextBox).Name.Equals("saNumericTextBox"))
                {
                    this.usNumericTextBox.Value = Math.Round((double)this.saNumericTextBox.Value / 13.39, 2);
                    this.turkeyTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 3.78, 2);
                    this.chNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 6.21, 2);
                    this.indNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 64.09, 2);
                    this.japanNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 123.55, 2);
                    this.germanNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 0.8905, 2);
                    this.brNumericTextBox.Value = Math.Round((double)this.usNumericTextBox.Value * 0.807, 2);
                }
            }
        }

        private void UnitButton_Click(object sender, EventArgs e)
        {
            if (string.Equals("currencyButton", (sender as SfButton).Name))
            {
                this.currencyButton.Style.BackColor = System.Drawing.Color.FromArgb(147, 158, 68);
                this.currencyButton.Style.HoverBackColor = System.Drawing.Color.FromArgb(147, 158, 68);
                this.currencyButton.Style.PressedBackColor = System.Drawing.Color.FromArgb(147, 158, 68);
                this.currencyButton.Style.FocusedBackColor = System.Drawing.Color.FromArgb(147, 158, 68);
                this.currencyButton.Style.ForeColor = System.Drawing.Color.White;
                this.currencyButton.Style.HoverForeColor = System.Drawing.Color.White;
                this.currencyButton.Style.PressedForeColor = System.Drawing.Color.White;
                this.currencyButton.Style.FocusedForeColor = System.Drawing.Color.White;

                this.temperatureButton.Style.BackColor = System.Drawing.Color.White;
                this.temperatureButton.Style.HoverBackColor = System.Drawing.Color.White;
                this.temperatureButton.Style.PressedBackColor = System.Drawing.Color.White;
                this.temperatureButton.Style.ForeColor = System.Drawing.Color.Black;
                this.temperatureButton.Style.HoverForeColor = System.Drawing.Color.Black;
                this.temperatureButton.Style.PressedForeColor = System.Drawing.Color.Black;

                this.currencyPanel.Visible = true;
                this.temperaturePanel.Visible = false;
            }
            else if (string.Equals("temperatureButton", (sender as SfButton).Name))
            {
                this.temperatureButton.Style.BackColor = System.Drawing.Color.FromArgb(147, 158, 68);
                this.temperatureButton.Style.HoverBackColor = System.Drawing.Color.FromArgb(147, 158, 68);
                this.temperatureButton.Style.PressedBackColor = System.Drawing.Color.FromArgb(147, 158, 68);
                this.temperatureButton.Style.FocusedBackColor = System.Drawing.Color.FromArgb(147, 158, 68);
                this.temperatureButton.Style.ForeColor = System.Drawing.Color.White;
                this.temperatureButton.Style.HoverForeColor = System.Drawing.Color.White;
                this.temperatureButton.Style.PressedForeColor = System.Drawing.Color.White;
                this.temperatureButton.Style.FocusedForeColor = System.Drawing.Color.White;

                this.currencyButton.Style.BackColor = System.Drawing.Color.White;
                this.currencyButton.Style.HoverBackColor = System.Drawing.Color.White;
                this.currencyButton.Style.PressedBackColor = System.Drawing.Color.White;
                this.currencyButton.Style.ForeColor = System.Drawing.Color.Black;
                this.currencyButton.Style.HoverForeColor = System.Drawing.Color.Black;
                this.currencyButton.Style.PressedForeColor = System.Drawing.Color.Black;

                this.currencyPanel.Visible = false;
                this.temperaturePanel.Visible = true;
            }
        }
    }
}
