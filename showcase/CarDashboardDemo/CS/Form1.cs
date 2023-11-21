#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
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
using System.Drawing.Drawing2D;
using Syncfusion.Windows.Forms.Gauge;
using System.IO;
using Syncfusion.WinForms.Controls;
using CarDashboard;

namespace RadialGaugeDemo
{
    public partial class Form1 : SfForm
    {
        SpeedGaugeCustomRenderer speedGaugeRender;
        RpmGaugeCustomRenderer rpmGaugeRender;
        TemperatureCustomRenderer temperatureGaugeRender;
        FuelGaugeCustomRenderer fuelGaugeRender;
        TorqueGaugeCustomRenderer torqueGaugeRender;
        Syncfusion.Windows.Forms.Gauge.Range Speedrange = new Syncfusion.Windows.Forms.Gauge.Range();
        Syncfusion.Windows.Forms.Gauge.Range Rpmrange = new Syncfusion.Windows.Forms.Gauge.Range();
        Syncfusion.Windows.Forms.Gauge.Range Temperaturerange = new Syncfusion.Windows.Forms.Gauge.Range();
        Syncfusion.Windows.Forms.Gauge.Range Fuelrange = new Syncfusion.Windows.Forms.Gauge.Range();
        Syncfusion.Windows.Forms.Gauge.Range Tarquerange = new Syncfusion.Windows.Forms.Gauge.Range();
        Timer t;
        public Form1()
        {
            InitializeComponent();

            speedGaugeRender = new SpeedGaugeCustomRenderer(this.speedGauge);
            rpmGaugeRender = new RpmGaugeCustomRenderer(this.rpmGauge);
            temperatureGaugeRender = new TemperatureCustomRenderer(this.temperatureGauge);
            fuelGaugeRender = new FuelGaugeCustomRenderer(this.fuelGauge);
            torqueGaugeRender = new TorqueGaugeCustomRenderer(this.torqueGauge);

            //Gauge customization methods
            speedGaugeCustomization();
            RpmGaugeCustomization();
            TemperatureGaugeCustomization();
            FuelGaugeCustomization();
            TorqueGaugeCustomization();

            t = new Timer();
            t.Interval = 30;
            t.Tick += new EventHandler(t_Tick);
            this.Load += new EventHandler(Form1_Load);
            this.Resize += Form1_Resize;
            
            t.Start();

            //Set the form icon
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(panel1.Width , panel1.Height);
        }

        /// <summary>
        /// SpeedGauge Custom Renderer
        /// </summary>
        private void speedGaugeCustomization()
        {
            this.speedGauge.NeedleColor = ColorTranslator.FromHtml("#719836");
            Speedrange.Color = speedGauge.NeedleColor = ColorTranslator.FromHtml("#719836");
            speedGauge.GaugeArcColor = speedGauge.MajorTickMarkColor = Color.FromArgb(187, 187, 187);
            speedGauge.GaugeLableColor = Color.Gray;
            speedGauge.ScaleLabelColor = Color.FromArgb(164, 164, 164);
            Speedrange.EndValue = 0F;
            Speedrange.Height = 13;
            Speedrange.InRange = false;
            Speedrange.Name = "GaugeRange1";
            Speedrange.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            Speedrange.StartValue = 0F;
            this.speedGauge.Ranges.Add(Speedrange);
            speedGauge.Renderer = speedGaugeRender;
        }

        /// <summary>
        /// RpmGauge Custom Renderer
        /// </summary>
        private void RpmGaugeCustomization()
        {
            rpmGauge.GaugeArcColor = rpmGauge.MajorTickMarkColor = Color.FromArgb(187, 187, 187);
            rpmGauge.GaugeLableColor = Color.Gray;
            rpmGauge.ScaleLabelColor = Color.FromArgb(164, 164, 164);

            Rpmrange.Color = rpmGauge.NeedleColor = ColorTranslator.FromHtml("#1b8fcf");
            Rpmrange.EndValue = 0F;
            Rpmrange.Height = 13;
            Rpmrange.InRange = true;
            Rpmrange.Name = "GaugeRange4";
            Rpmrange.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            Rpmrange.StartValue = 0F;
            this.rpmGauge.Ranges.Add(Rpmrange);
            rpmGauge.Renderer = rpmGaugeRender;
        }

        /// <summary>
        /// TemperatureGauge Custom Renderer
        /// </summary>
        private void TemperatureGaugeCustomization()
        {
            temperatureGauge.GaugeArcColor = temperatureGauge.MajorTickMarkColor = Color.FromArgb(187, 187, 187);
            Temperaturerange.Color = ColorTranslator.FromHtml("#a41413");
            Temperaturerange.EndValue = 0F;
            Temperaturerange.Height = 18;
            Temperaturerange.InRange = true;
            Temperaturerange.Name = "GaugeRange4";
            Temperaturerange.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            this.temperatureGauge.Ranges.Add(Temperaturerange);
            this.temperatureGauge.Renderer = temperatureGaugeRender;
        }

        /// <summary>
        /// FuelGauge Custom Renderer
        /// </summary>
        private void FuelGaugeCustomization()
        {
            fuelGauge.GaugeArcColor = fuelGauge.MajorTickMarkColor = Color.FromArgb(187, 187, 187);
            Fuelrange.Color = fuelGauge.GaugeValueColor = ColorTranslator.FromHtml("#eca414");
            Fuelrange.EndValue = 0F;
            Fuelrange.Height = 7;
            Fuelrange.InRange = true;
            Fuelrange.Name = "GaugeRange4";
            Fuelrange.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            Fuelrange.StartValue = 0F;
            this.fuelGauge.Ranges.Add(Fuelrange);
            this.fuelGauge.Renderer = fuelGaugeRender;
        }

        /// <summary>
        /// Torque Gauge Custom Renderer
        /// </summary>
        private void TorqueGaugeCustomization()
        {
            torqueGauge.GaugeArcColor = torqueGauge.MajorTickMarkColor = Color.FromArgb(187, 187, 187);
            Tarquerange.Color = fuelGauge.GaugeValueColor = ColorTranslator.FromHtml("#24b8c4");
            Tarquerange.EndValue = 0.9F;
            Tarquerange.Height = 20;
            Tarquerange.InRange = true;
            Tarquerange.Name = "GaugeRange4";
            Tarquerange.StartValue = 0.3F;
            this.torqueGauge.Ranges.Add(Tarquerange);
            this.torqueGauge.Renderer = torqueGaugeRender;
        }

        #region Helpers

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

        bool temp = true;
        int flag = 0;
        int i = 0;
        int j = 0;
        void t_Tick(object sender, EventArgs e)
        {
            j++;
            if (temp)
                i++;
            else
                i--;

            if (i <= 160)
            {
                rpmGauge.Value = (float)(i * .03);
                temperatureGauge.Value = (float)(i * 1);
                Rpmrange.EndValue = rpmGauge.Value;
                Temperaturerange.EndValue = temperatureGauge.Value;
                torqueGauge.Value = (float)(i * 0.03);
                Tarquerange.EndValue = torqueGauge.Value;
                speedGauge.Value = i;
                fuelGauge.Value = i;// 100 - (j / 30);
                Fuelrange.EndValue = fuelGauge.Value;
                Speedrange.EndValue = i;
                if (fuelGauge.Value == 0)
                    j = 0;
                Speedrange.EndValue = i;
                //if (i > 40 && i < 80)
                //{
                //    this.radialGauge2.NeedleColor = range4.Color = ColorTranslator.FromHtml("#87C13A"); ;
                //}
                //else if (i > 80 && i < 120)
                //{
                //    this.radialGauge2.NeedleColor = range4.Color = Color.Red;
                //}
                //else if (i < 40)
                //{
                //    this.radialGauge2.NeedleColor = range4.Color = Color.FromArgb(50, 179, 198);
                //}
                if (i == 60 && temp && flag == 0)
                {
                    flag = 1;
                    temp = false;
                }
                else if (i == 80 && temp && flag == 1)
                {
                    flag = 2;
                    temp = false;
                }
                else if ((i == 40 || i == 60) && !temp && flag != 3)
                {
                    temp = true;
                }
                else if (i == 160)
                {
                    flag = 3;
                    temp = false;
                }
                else if (i == 0 && flag == 3)
                {
                    flag = 0;
                    temp = true;
                }

            }
        }
        int exParam = -1; bool disable = false;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                if (exParam == -1)
                    exParam = cp.ExStyle;
                if (!disable)
                    cp.ExStyle |= 0x02000000;
                else
                    cp.ExStyle = exParam;
                return cp;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            disable = true;
            UpdateStyles();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.panel1.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(978), (int)DpiAware.LogicalToDeviceUnits(604));
            this.gradientPanel2.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(482), (int)DpiAware.LogicalToDeviceUnits(324));
            this.speedGauge.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(375), (int)DpiAware.LogicalToDeviceUnits(375));
            this.gradientPanel6.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(323), (int)DpiAware.LogicalToDeviceUnits(275));
            this.temperatureGauge.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(319), (int)DpiAware.LogicalToDeviceUnits(212));
            this.gradientPanel3.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(489), (int)DpiAware.LogicalToDeviceUnits(324));
            this.rpmGauge.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(375), (int)DpiAware.LogicalToDeviceUnits(375));
            this.gradientPanel5.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(323), (int)DpiAware.LogicalToDeviceUnits(275));
            this.fuelGauge.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(230), (int)DpiAware.LogicalToDeviceUnits(152));
            this.gradientPanel4.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(322), (int)DpiAware.LogicalToDeviceUnits(275));
            this.torqueGauge.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(317), (int)DpiAware.LogicalToDeviceUnits(210));
            this.gradientPanel3.Location = new Point(gradientPanel2.Width, 0);
            this.gradientPanel6.Location = new Point(gradientPanel2.Location.X, gradientPanel2.Height);
            this.gradientPanel5.Location = new Point(gradientPanel6.Location.X + gradientPanel6.Width, gradientPanel2.Height);
            this.gradientPanel4.Location = new Point(gradientPanel6.Location.X + gradientPanel6.Width + gradientPanel5.Width, gradientPanel3.Height);
            this.panel1.Location = new Point((this.ClientSize.Width / 2) - (this.panel1.Width / 2), (this.ClientSize.Height / 2) - (this.panel1.Height / 2));
            this.MinimumSize = new Size(ClientRectangle.Width - 200, ClientRectangle.Height - 30);
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
