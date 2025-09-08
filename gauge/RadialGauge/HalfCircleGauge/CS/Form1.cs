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
using System.Runtime.InteropServices;
using System.IO;
using Syncfusion.WinForms.Controls;

namespace GaugeDemo
{
    public partial class Form1 : SfForm
    {
        [DllImport("user32.dll")]
        static extern bool LockWindowUpdate(IntPtr hWndLock);

        Timer timer = new Timer();
        Syncfusion.Windows.Forms.Gauge.Range range1 = new Syncfusion.Windows.Forms.Gauge.Range();
        Syncfusion.Windows.Forms.Gauge.Range range2 = new Syncfusion.Windows.Forms.Gauge.Range();
        public Form1()
        {
            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
            this.radialGauge1.Ranges.Clear();
            timer = new Timer();
            timer.Interval = 1;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            this.radialGauge1.ArcThickness = 70;
            this.radialGauge1.Renderer = new CustomGaugeRenderer(this.radialGauge1);
            this.trackBar1.ValueChanged += new EventHandler(trackBar1_ValueChanged);
            this.radialGauge1.ValueChanged += new EventHandler(radialGauge1_ValueChanged);
          
            this.radialGauge1.MinorInnerLinesHeight = 0;
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
        void radialGauge1_ValueChanged(object sender, EventArgs e)
        {      

          
        }
        void trackBar1_ValueChanged(object sender, EventArgs e)
        {           
            this.radialGauge1.Value = this.trackBar1.Value;            
        }     
        int val = 0;
        bool inc = true ;
        void timer_Tick(object sender, EventArgs e)
        {            
          //  Random random = new Random();

            if (val == 110)
            {
                inc = false ;
            }

            if(val == 10)
            {
                inc = true;
            }
            if(inc)
            {
                      this.trackBar1.Value = val;
                      val = val + 2;
            }
            else
            {
                this.radialGauge1.Value =  val;
                val = val - 2;
            }
            this.Refresh();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.radialGauge1.GaugeValueFont = new Font("Segon UI", 20F,FontStyle.Bold);            
            this.radialGauge1.GaugeLableColor = System.Drawing.ColorTranslator.FromHtml("#00A551");
           
        }

        private void radialGauge1_Click(object sender, EventArgs e)
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
