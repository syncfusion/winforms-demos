#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Syncfusion.WinForms.Controls;

namespace UserInteractionDemo_2013
{
    public partial class Form1 : SfForm
    {
        public Form1()
        {
            InitializeComponent();
            this.radialGauge1.OuterFrameGradientEndColor = System.Drawing.Color.White;
            this.radialGauge1.OuterFrameGradientStartColor = System.Drawing.Color.White;
            this.radialGauge1.InnerFrameGradientEndColor = System.Drawing.Color.White;
            this.radialGauge1.InnerFrameGradientStartColor = System.Drawing.Color.White;
            this.radialGauge1.NeedleColor = System.Drawing.Color.Black;
            this.linearGauge1.NeedleColor = System.Drawing.Color.Black;
            this.linearGauge1.BackgroundGradientEndColor = System.Drawing.Color.White;
            this.linearGauge1.BackgroundGradientStartColor = System.Drawing.Color.White;
            this.linearGauge1.OuterFrameGradientEndColor = System.Drawing.Color.White;
            this.linearGauge1.OuterFrameGradientStartColor = System.Drawing.Color.White;
            this.linearGauge1.InnerFrameGradientEndColor = System.Drawing.Color.White;
            this.linearGauge1.InnerFrameGradientStartColor = System.Drawing.Color.White;
            this.CenterToScreen();
            this.linearGauge1.ValueChanged += linearGauge1_ValueChanged;
            this.radialGauge1.ValueChanged += radialGauge1_ValueChanged;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
        }

        void radialGauge1_ValueChanged(object sender, EventArgs e)
        {
            this.linearGauge1.Value = this.radialGauge1.Value;
            this.radialGauge1.GaugeLabel = Math.Ceiling(this.radialGauge1.Value).ToString();
            this.Valuelbl.Text = Math.Ceiling(this.radialGauge1.Value).ToString();
            this.Valuelbl.Refresh();
        }

        void linearGauge1_ValueChanged(object sender, EventArgs e)
        {
            this.radialGauge1.Value = this.linearGauge1.Value;
            this.radialGauge1.GaugeLabel = Math.Ceiling(this.radialGauge1.Value).ToString();
            this.Valuelbl.Text = Math.Ceiling(this.radialGauge1.Value).ToString();
            this.Valuelbl.Refresh();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.panel1.Location = new Point(
            this.ClientSize.Width / 2 - this.panel1.Size.Width / 2,
            this.ClientSize.Height / 2 - this.panel1.Size.Height / 2);
            this.panel1.Anchor = AnchorStyles.None;
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
