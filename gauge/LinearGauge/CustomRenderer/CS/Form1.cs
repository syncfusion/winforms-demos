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

namespace CustomRenderer_2008
{
    public partial class Form1 : SfForm
    {
        CustomRenderer1 renderer1;
        CustomRenderer2 renderer2;
        CustomRenderer3 renderer3;
        public Form1()
        {
            InitializeComponent();
            this.comboBoxAdv1.DropDownStyle = ComboBoxStyle.DropDownList;
            renderer1 = new CustomRenderer1(this.linearGauge1);
            renderer2 = new CustomRenderer2(this.linearGauge2);
            renderer3 = new CustomRenderer3(this.linearGauge3);
            this.MinimumSize=new Size(915,605);
            this.linearGauge1.GaugeBaseColor = this.linearGauge1.ForeColor = this.linearGauge1.MajorTickMarkColor =
               this.linearGauge1.MinorTickMarkColor = ColorTranslator.FromHtml("#565656");
            this.linearGauge2.GaugeBaseColor = this.linearGauge2.ForeColor = this.linearGauge2.MajorTickMarkColor =
               this.linearGauge2.MinorTickMarkColor = ColorTranslator.FromHtml("#565656");
            this.trackBarEx1.ValueChanged += new EventHandler(trackBarEx1_ValueChanged);
            this.linearGauge1.Ranges[0].Color = ColorTranslator.FromHtml("#87ceeb");
            this.linearGauge1.Ranges[1].Color = ColorTranslator.FromHtml("#dc143c");
            this.linearGauge1.NeedleColor = ColorTranslator.FromHtml("#afe2f2");
            this.linearGauge2.Ranges[0].Color = ColorTranslator.FromHtml("#ccf6f3");
            this.linearGauge2.ValueIndicatorColor = ColorTranslator.FromHtml("#01d4c3");
            this.linearGauge2.Renderer = renderer2;
            this.linearGauge1.Renderer = renderer1;
            this.linearGauge3.Renderer = renderer3;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }

            #region Initial Settings
            this.SizeChanged += new EventHandler(MainForm_SizeChanged);
            this.comboBoxAdv1.Text = "Ball Pointer";
            this.label3.Text = "Pointer Value is " + linearGauge1.Value.ToString();
            this.linearGauge2.Visible = false;
            this.linearGauge3.Visible = false;
            this.trackBarEx1.Value = (int) this.linearGauge1.Value;
            this.trackBarEx1.Maximum = (int) this.linearGauge1.MaximumValue;
            this.linearGauge1.Location = new Point(this.splitContainerAdv1.Panel1.Width / 2 - this.linearGauge1.Width / 2, this.splitContainerAdv1.Panel1.Height / 2 - this.linearGauge1.Height / 2);
            this.linearGauge2.Location = new Point(this.splitContainerAdv1.Panel1.Width / 2 - this.linearGauge2.Width / 2, this.splitContainerAdv1.Panel1.Height / 2 - this.linearGauge2.Height / 2);
            this.linearGauge3.Location = new Point(this.splitContainerAdv1.Panel1.Width / 2 - this.linearGauge3.Width / 2, this.splitContainerAdv1.Panel1.Height / 2 - this.linearGauge3.Height / 2);
            this.label3.Location = new Point(this.splitContainerAdv1.Panel1.Width/2 - this.label3.Width/2,
                this.linearGauge1.Location.Y + this.linearGauge1.Height + 3);
            this.comboBoxAdv1.Location = new Point((this.splitContainerAdv1.Panel2.Width - this.comboBoxAdv1.Width) / 2, this.comboBoxAdv1.Location.Y);
            this.trackBarEx1.Location = new Point((this.splitContainerAdv1.Panel2.Width - this.trackBarEx1.Width) / 2, this.trackBarEx1.Location.Y);
            this.label1.Location = new Point(this.comboBoxAdv1.Location.X, this.label1.Location.Y);
            this.label2.Location = new Point(this.trackBarEx1.Location.X, this.label2.Location.Y);
            this.label2.Text = "Pointer Value : " + this.trackBarEx1.Value.ToString();
            #endregion
        }

        void trackBarEx1_ValueChanged(object sender, EventArgs e)
        {
            this.label2.Text = "Pointer Value : " + this.trackBarEx1.Value.ToString();
            if (linearGauge1.Visible)
            {
                this.linearGauge1.Value = this.trackBarEx1.Value;
                this.label3.Text = "Pointer Value is " + linearGauge1.Value.ToString();
            }
            else if (this.linearGauge2.Visible)
            {
                char degree = (char)176;
                this.linearGauge2.Value = this.trackBarEx1.Value;
                this.label3.Text = "Boiling point is " + linearGauge2.Value.ToString()+ degree +" C"; 
            }
            else if (linearGauge3.Visible)
            {
                this.linearGauge3.Value = this.trackBarEx1.Value;
                this.label3.Text = "Range Value is " + linearGauge3.Value.ToString();
            }
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

        void MainForm_SizeChanged(object sender, EventArgs e)
        {
            this.linearGauge1.Location = new Point(this.splitContainerAdv1.Panel1.Width / 2 - this.linearGauge1.Width / 2, this.splitContainerAdv1.Panel1.Height / 2 - this.linearGauge1.Height / 2);
            this.linearGauge2.Location = new Point(this.splitContainerAdv1.Panel1.Width / 2 - this.linearGauge2.Width / 2, this.splitContainerAdv1.Panel1.Height / 2 - this.linearGauge2.Height / 2);
            this.linearGauge3.Location = new Point(this.splitContainerAdv1.Panel1.Width / 2 - this.linearGauge3.Width / 2, this.splitContainerAdv1.Panel1.Height / 2 - this.linearGauge3.Height / 2);
            this.label3.Location = new Point(this.splitContainerAdv1.Panel1.Width/2 - this.label3.Width/2,
                this.linearGauge1.Location.Y + this.linearGauge1.Height + 3);
            this.comboBoxAdv1.Location = new Point((this.splitContainerAdv1.Panel2.Width - this.comboBoxAdv1.Width) / 2, this.comboBoxAdv1.Location.Y);
            this.trackBarEx1.Location = new Point( (this.splitContainerAdv1.Panel2.Width - this.trackBarEx1.Width) / 2, this.trackBarEx1.Location.Y);
            this.label1.Location = new Point(this.comboBoxAdv1.Location.X, this.label1.Location.Y);
            this.label2.Location = new Point(this.trackBarEx1.Location.X, this.label2.Location.Y);
        }

        private void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxAdv1.SelectedIndex==0)
            {
                this.linearGauge1.Visible = true;
                this.linearGauge2.Visible = false;
                this.linearGauge3.Visible = false;
                this.trackBarEx1.Maximum = 50;
                this.trackBarEx1.Value = (int)this.linearGauge1.Value;
                this.label3.Text = "Pointer Value is " + linearGauge1.Value.ToString();
            }
            else if (this.comboBoxAdv1.SelectedIndex==1)
            {
                char degree = (char) 176;
                this.linearGauge2.Visible = true;
                this.linearGauge1.Visible = false;
                this.linearGauge3.Visible = false;
                this.trackBarEx1.Maximum = 30;
                this.trackBarEx1.Value = (int)this.linearGauge2.Value;
                this.label3.Text = "Boiling point is " + linearGauge2.Value.ToString() + degree+" C";
            }
            else if (this.comboBoxAdv1.SelectedIndex == 2)
            {
                this.linearGauge3.Visible = true;
                this.linearGauge1.Visible = false;
                this.linearGauge2.Visible = false;
                this.trackBarEx1.Maximum = 100;
                this.trackBarEx1.Value = (int)this.linearGauge3.Value;
                this.label3.Text = "Range Value is " + linearGauge3.Value.ToString();
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
