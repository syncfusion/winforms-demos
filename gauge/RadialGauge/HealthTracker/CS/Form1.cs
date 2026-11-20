#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
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
using System.IO;
using Syncfusion.WinForms.Controls;

namespace GaugeInterctionSample
{
    public partial class Form1 : SfForm
    {
        CustomRenderer custom, custom1, custom2;
        CustomRenderer1 custom3;
        float prevStep, prevFloor;
        public Form1()
        {
            InitializeComponent();
            this.label2.ForeColor = ColorTranslator.FromHtml("#ff8860");
            this.radialGauge1.GaugeArcColor=this.radialGauge2.GaugeArcColor=this.radialGauge3.GaugeArcColor = ColorTranslator.FromHtml("#ededed");
            this.radialGauge1.GaugeLableColor = this.radialGauge1.GaugeValueColor = ColorTranslator.FromHtml("#8cc34b");
            this.radialGauge1.Ranges[0].Color = ColorTranslator.FromHtml("#8cc34b");
            custom = new CustomRenderer(this.radialGauge1);
            this.radialGauge1.Renderer = custom;
            custom1 = new CustomRenderer(this.radialGauge2);
            this.radialGauge2.GaugeLableColor = this.radialGauge2.GaugeValueColor =
                this.radialGauge2.Ranges[0].Color = ColorTranslator.FromHtml("#4db7ad");
            this.radialGauge2.Renderer = custom1;
            this.radialGauge1.ReadOnly = this.radialGauge2.ReadOnly = this.radialGauge3.ReadOnly = true;
            this.radialGauge1.FrameThickness = this.radialGauge2.FrameThickness = this.radialGauge3.FrameThickness = 7;
            custom2 = new CustomRenderer(this.radialGauge3);
            this.radialGauge3.GaugeLableColor = this.radialGauge3.GaugeValueColor =
                 this.radialGauge3.Ranges[0].Color = ColorTranslator.FromHtml("#ad7c71"); 
            this.radialGauge3.Renderer = custom2;
            this.linearGauge1.GaugeBaseColor = ColorTranslator.FromHtml("#ededed");
            this.linearGauge1.Ranges[0].Color = ColorTranslator.FromHtml("#ff8860");
            custom3 = new CustomRenderer1(this.linearGauge1);
            this.linearGauge1.Renderer=custom3;
            this.radialGauge2.Ranges[0].EndValue = this.radialGauge2.Value;
            this.radialGauge3.Ranges[0].EndValue = this.radialGauge3.Value;
            this.radialGauge1.Ranges[0].EndValue = this.radialGauge1.Value;
            this.linearGauge1.Ranges[0].EndValue = this.linearGauge1.Value;
            this.radialGauge2.MouseDown += new MouseEventHandler(radialGauge2_MouseDown);
            this.radialGauge3.MouseDown+=new MouseEventHandler(radialGauge2_MouseDown);
        }

        void radialGauge2_MouseDown(object sender, MouseEventArgs e)
        {
            prevStep = this.radialGauge2.Value;
            prevFloor = this.radialGauge3.Value;
        }

        private void radialGauge1_ValueChanged_1(object sender, EventArgs e)
        {
            this.linearGauge1.Value = this.radialGauge1.Value * 10;
            this.radialGauge1.Ranges[0].EndValue = this.radialGauge1.Value;
            this.radialGauge2.Ranges[0].EndValue = this.radialGauge2.Value;
            this.radialGauge3.Ranges[0].EndValue = this.radialGauge3.Value;
            this.linearGauge1.Ranges[0].EndValue = this.linearGauge1.Value;
        }

        private void radialGauge2_ValueChanged(object sender, EventArgs e)
        {
            if (prevStep < this.radialGauge2.Value || prevFloor < this.radialGauge3.Value)
            {
                float Excercise = this.radialGauge2.Value + (this.radialGauge3.Value * 2);
                this.linearGauge1.Value = linearGauge1.Value - Excercise;
            }
            this.radialGauge2.Ranges[0].EndValue = this.radialGauge2.Value;
            this.radialGauge3.Ranges[0].EndValue = this.radialGauge3.Value;
            this.radialGauge1.Ranges[0].EndValue = this.radialGauge1.Value;
            this.linearGauge1.Ranges[0].EndValue = this.linearGauge1.Value;
        }

        private void linearGauge1_ValueChanged(object sender, EventArgs e)
        {
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
            MessageBoxAdv.MetroColorTable.CaptionBarColor = Color.FromArgb(17, 158, 218);
            MessageBoxAdv.MetroColorTable.CaptionForeColor = Color.White;
            prevStep = this.radialGauge2.Value;
            prevFloor = this.radialGauge3.Value;
            this.radialGauge1.Value = this.linearGauge1.Value / 10;
            if (radialGauge1.Value == 0)
                MessageBoxAdv.Show("In take food", "Alert Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.label2.Location = new Point(this.Width / 2 - this.label2.Width / 2, this.label2.Location.Y);
            this.linearGauge1.Location = new Point(this.Width / 2 - this.linearGauge1.Width / 2, this.linearGauge1.Location.Y);
        }

        int i = 350, j = 15;
        float Excercise = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i > 3000)
            {
                if (j < 100)
                {
                    timer1.Interval = 60;
                    this.radialGauge2.Value = this.radialGauge3.Value = j;
                    float Excercise = this.radialGauge2.Value + (this.radialGauge3.Value * 2);
                    if (linearGauge1.Value > 3500)
                    {
                        this.linearGauge1.Value = linearGauge1.Value - Excercise;
                        this.linearGauge1.Value = linearGauge1.Value - Excercise;
                        this.radialGauge1.Value = this.linearGauge1.Value / 10;
                    }
                    else
                    {
                        this.linearGauge1.Value = 3500;
                        this.radialGauge1.Value = 350;
                    }
                    j++;
                }
                else
                {
                    i = 350;
                    j = 15;
                    this.radialGauge2.Value = 15;
                    this.radialGauge3.Value = 5;
                    this.radialGauge2.Ranges[0].EndValue = 15;
                    this.radialGauge3.Ranges[0].EndValue = 5;
                }
            }
            else
            {
                timer1.Interval = 20;
                this.radialGauge1.Value = i;
                this.linearGauge1.Value = this.radialGauge1.Value * 10;
                i = i + 10;
            }
            this.radialGauge2.Ranges[0].EndValue = this.radialGauge2.Value;
            this.radialGauge3.Ranges[0].EndValue = this.radialGauge3.Value;
            this.radialGauge1.Ranges[0].EndValue = this.radialGauge1.Value;
            this.linearGauge1.Ranges[0].EndValue = this.linearGauge1.Value;
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
