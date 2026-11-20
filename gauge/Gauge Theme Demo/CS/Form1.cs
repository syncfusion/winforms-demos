#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
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
using System.Runtime.InteropServices;
using Syncfusion.Windows.Forms.Gauge;
using System.IO;
using Syncfusion.WinForms.Controls;

namespace GaugeTheme_2010
{
    public partial class Form1 : SfForm
    {
        internal Dictionary<string, Color> RestoreColors = new Dictionary<string, Color>();
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.comboBoxAdv1.SelectedIndexChanged += ComboBoxAdv1_SelectedIndexChanged;
            this.RadialGaugePanel.SizeChanged += new EventHandler(RadialGaugePanel_SizeChanged);
            this.LinearGaugePanel.SizeChanged += new EventHandler(LinearGaugePanel_SizeChanged);
            this.DigitalGaugePanel.SizeChanged += new EventHandler(DigitalGaugePanel_SizeChanged);
            this.RadialGaugePanel.Paint += new PaintEventHandler(RadialGaugePanel_Paint);
            this.LinearGaugePanel.Paint += new PaintEventHandler(LinearGaugePanel_Paint);
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
           
            SkinManager.SetVisualStyle(this, "Office2019Colorful");
            this.BackColor = ColorTranslator.FromHtml("#f3f3f3");
            UpdateOffice2019andHighContrastThemeColor();
            this.comboBoxAdv1.SelectedIndex = 0;
        }
        void LinearGaugePanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillRectangle(new SolidBrush(Color.Transparent), new Rectangle(this.LinearGaugePanel.DisplayRectangle.X, (this.LinearGaugePanel.DisplayRectangle.Y + this.LinearGaugePanel.DisplayRectangle.Height - 2),
                this.LinearGaugePanel.DisplayRectangle.Width, this.LinearGaugePanel.DisplayRectangle.Height - 2));
        }

        void RadialGaugePanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillRectangle(new SolidBrush(Color.Transparent), new Rectangle(this.DigitalGaugePanel.DisplayRectangle.X + this.DigitalGaugePanel.DisplayRectangle.Width - 3, this.DigitalGaugePanel.DisplayRectangle.Y, 2, (this.DigitalGaugePanel.DisplayRectangle.Height * 2)));
        }

        void DigitalGaugePanel_SizeChanged(object sender, EventArgs e)
        {
            this.digitalGauge1.Left = (this.DigitalGaugePanel.Width - this.digitalGauge1.Width) / 2;
            this.digitalGauge1.Top = (this.DigitalGaugePanel.Height - this.digitalGauge1.Height) / 2;
        }

        void LinearGaugePanel_SizeChanged(object sender, EventArgs e)
        {
            this.linearGauge1.Left = (this.LinearGaugePanel.Width - this.linearGauge1.Width) / 2;
            this.linearGauge1.Top = (this.LinearGaugePanel.Height - this.linearGauge1.Height) / 2;
        }

        void RadialGaugePanel_SizeChanged(object sender, EventArgs e)
        {
            this.radialGauge1.Left = (this.RadialGaugePanel.Width - this.radialGauge1.Width) / 2;
            this.radialGauge1.Top = (this.RadialGaugePanel.Height - this.radialGauge1.Height) / 2;
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

        private void ComboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            SkinManager.SetVisualStyle(this, comboBoxAdv1.SelectedItem.ToString());
            if (this.comboBoxAdv1.SelectedItem.ToString() == "Office2016DarkGray")
            {
                this.BackColor = Color.DarkGray;
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString() == "Office2016Black")
            {
                this.BackColor = ColorTranslator.FromHtml("#262626");
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString() == "Blue")
            {
                this.radialGauge1.VisualStyle = this.digitalGauge1.VisualStyle = this.linearGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Blue;
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString() == "Silver")
            {
                this.radialGauge1.VisualStyle = this.digitalGauge1.VisualStyle = this.linearGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Silver;
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString() == "Office2019Colorful")
            {
                this.BackColor = ColorTranslator.FromHtml("#f3f3f3");
                UpdateOffice2019andHighContrastThemeColor();
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString() == "HighContrastBlack")
            {
                this.BackColor = Color.Black;
                UpdateOffice2019andHighContrastThemeColor();
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString() == "Custom")
            {
                CustomVisualStyleDialog visualStyleDialog = new CustomVisualStyleDialog(this);
                this.radialGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Custom;
                this.digitalGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Custom;
                this.linearGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Custom;
                visualStyleDialog.ShowDialog();
            }
            this.radialGauge1.Refresh();
            this.digitalGauge1.Refresh();
            this.linearGauge1.Refresh();
        }

        private void panel2_SizeChanged(object sender, EventArgs e)
        {
            this.RadialGaugePanel.Width = (sender as Panel).Width / 2;
            this.comboBoxAdv1.Location = new Point(this.panel1.Width - this.comboBoxAdv1.Width - 25, (this.panel1.Height - this.comboBoxAdv1.Height) / 2);
            this.label1.Location = new Point(this.comboBoxAdv1.Location.X - this.label1.Width - 10, this.comboBoxAdv1.Location.Y + 3);
        }

        private void LinearDigitalBasePanel_SizeChanged(object sender, EventArgs e)
        {
            this.LinearGaugePanel.Height = this.LinearDigitalBasePanel.Height / 2;
        }

        void UpdateOffice2019andHighContrastThemeColor()
        {
            this.digitalGauge1.OuterFrameGradientEndColor = Color.Transparent;
            this.digitalGauge1.OuterFrameGradientStartColor = Color.Transparent;
            this.digitalGauge1.BackgroundGradientEndColor = this.radialGauge1.BackColor;
            this.digitalGauge1.BackgroundGradientStartColor = this.radialGauge1.BackColor;
            this.digitalGauge1.FrameBorderColor = this.radialGauge1.ThemeStyle.ArcColor;
            this.digitalGauge1.ForeColor = this.radialGauge1.ThemeStyle.NeedleColor;
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
