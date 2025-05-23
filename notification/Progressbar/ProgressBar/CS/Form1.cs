#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms;
using System.Runtime.InteropServices;
using Syncfusion.Licensing;
using System.IO;
using Syncfusion.WinForms.Controls;

namespace ProgressBarAdvProperties
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : SfForm
    {
        private System.Windows.Forms.Timer Timer;
        private System.ComponentModel.IContainer components;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarAdv5;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarAdv4;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarAdv3;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarAdv2;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarAdv1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        bool Start = true;

        [DllImport("user32.dll")]
        static extern bool LockWindowUpdate(IntPtr hWndLock);

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile((@"../../Image/App.ico")));
                this.Icon = ico;
            }
            catch { }
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
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.progressBarAdv5 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.progressBarAdv4 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.progressBarAdv3 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.progressBarAdv2 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.progressBarAdv1 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // progressBarAdv5
            // 
            this.progressBarAdv5.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv5.BackSegments = false;
            this.progressBarAdv5.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.progressBarAdv5.BorderColor = System.Drawing.Color.LightGray;
            this.progressBarAdv5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressBarAdv5.CustomText = "Loading";
            this.progressBarAdv5.CustomWaitingRender = false;
            this.progressBarAdv5.ForegroundImage = null;
            this.progressBarAdv5.ForeSegments = false;
            this.progressBarAdv5.Location = new System.Drawing.Point(73, 469);
            this.progressBarAdv5.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Blue,
        System.Drawing.Color.Green,
        System.Drawing.Color.Pink,
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Red};
            this.progressBarAdv5.Name = "progressBarAdv5";
            this.progressBarAdv5.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.MultipleGradient;
            this.progressBarAdv5.SegmentWidth = 2;
            this.progressBarAdv5.Size = new System.Drawing.Size(400, 23);
            this.progressBarAdv5.StretchMultGrad = false;
            this.progressBarAdv5.TabIndex = 6;
            this.progressBarAdv5.Text = "progressBarAdv5";
            this.progressBarAdv5.TextShadow = false;
            this.progressBarAdv5.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Value;
            this.progressBarAdv5.TextVisible = false;
            this.progressBarAdv5.ThemeName = "MultipleGradient";
            this.progressBarAdv5.Value = 100;
            this.progressBarAdv5.WaitingGradientWidth = 400;
            // 
            // progressBarAdv4
            // 
            this.progressBarAdv4.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv4.BackSegments = false;
            this.progressBarAdv4.BackTubeStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.progressBarAdv4.BorderColor = System.Drawing.Color.LightGray;
            this.progressBarAdv4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressBarAdv4.CustomText = "Loading";
            this.progressBarAdv4.CustomWaitingRender = false;
            this.progressBarAdv4.ForegroundImage = null;
            this.progressBarAdv4.ForeSegments = false;
            this.progressBarAdv4.Location = new System.Drawing.Point(73, 367);
            this.progressBarAdv4.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv4.Name = "progressBarAdv4";
            this.progressBarAdv4.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube;
            this.progressBarAdv4.SegmentWidth = 2;
            this.progressBarAdv4.Size = new System.Drawing.Size(400, 23);
            this.progressBarAdv4.TabIndex = 5;
            this.progressBarAdv4.Text = "progressBarAdv4";
            this.progressBarAdv4.TextShadow = false;
            this.progressBarAdv4.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Value;
            this.progressBarAdv4.TextVisible = false;
            this.progressBarAdv4.ThemeName = "Tube";
            this.progressBarAdv4.TubeEndColor = System.Drawing.Color.White;
            this.progressBarAdv4.TubeStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.progressBarAdv4.Value = 100;
            this.progressBarAdv4.WaitingGradientWidth = 400;
            // 
            // progressBarAdv3
            // 
            this.progressBarAdv3.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv3.BackSegments = false;
            this.progressBarAdv3.BorderColor = System.Drawing.Color.LightGray;
            this.progressBarAdv3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressBarAdv3.CustomText = "Loading";
            this.progressBarAdv3.CustomWaitingRender = false;
            this.progressBarAdv3.ForegroundImage = null;
            this.progressBarAdv3.ForeSegments = false;
            this.progressBarAdv3.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.progressBarAdv3.GradientStartColor = System.Drawing.Color.White;
            this.progressBarAdv3.Location = new System.Drawing.Point(73, 268);
            this.progressBarAdv3.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv3.Name = "progressBarAdv3";
            this.progressBarAdv3.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Gradient;
            this.progressBarAdv3.SegmentWidth = 12;
            this.progressBarAdv3.Size = new System.Drawing.Size(400, 23);
            this.progressBarAdv3.TabIndex = 4;
            this.progressBarAdv3.Text = "progressBarAdv3";
            this.progressBarAdv3.TextShadow = false;
            this.progressBarAdv3.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Value;
            this.progressBarAdv3.TextVisible = false;
            this.progressBarAdv3.ThemeName = "Gradient";
            this.progressBarAdv3.ThemesEnabled = true;
            this.progressBarAdv3.Value = 100;
            this.progressBarAdv3.WaitingGradientWidth = 400;
            // 
            // progressBarAdv2
            // 
            this.progressBarAdv2.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv2.BackSegments = false;
            this.progressBarAdv2.BackTubeStartColor = System.Drawing.Color.White;
            this.progressBarAdv2.BorderColor = System.Drawing.Color.LightGray;
            this.progressBarAdv2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressBarAdv2.CustomText = "Loading";
            this.progressBarAdv2.CustomWaitingRender = false;
            this.progressBarAdv2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.progressBarAdv2.ForegroundImage = null;
            this.progressBarAdv2.Location = new System.Drawing.Point(73, 170);
            this.progressBarAdv2.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv2.Name = "progressBarAdv2";
            this.progressBarAdv2.SegmentWidth = 12;
            this.progressBarAdv2.Size = new System.Drawing.Size(400, 23);
            this.progressBarAdv2.TabIndex = 3;
            this.progressBarAdv2.Text = "progressBarAdv2";
            this.progressBarAdv2.TextShadow = false;
            this.progressBarAdv2.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Value;
            this.progressBarAdv2.TextVisible = false;
            this.progressBarAdv2.ThemesEnabled = true;
            this.progressBarAdv2.Value = 100;
            this.progressBarAdv2.WaitingGradientWidth = 400;
            // 
            // progressBarAdv1
            // 
            this.progressBarAdv1.BackgroundFallbackStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.VerticalGradient;
            this.progressBarAdv1.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Office2016White;
            this.progressBarAdv1.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            this.progressBarAdv1.BackSegments = false;
            this.progressBarAdv1.BackTubeStartColor = System.Drawing.Color.White;
            this.progressBarAdv1.BorderColor = System.Drawing.Color.LightGray;
            this.progressBarAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressBarAdv1.CustomText = "Loading";
            this.progressBarAdv1.CustomWaitingRender = false;
            this.progressBarAdv1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.progressBarAdv1.ForegroundImage = null;
            this.progressBarAdv1.ForeSegments = false;
            this.progressBarAdv1.Location = new System.Drawing.Point(73, 78);
            this.progressBarAdv1.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv1.Name = "progressBarAdv1";
            this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Office2016White;
            this.progressBarAdv1.SegmentWidth = 12;
            this.progressBarAdv1.Size = new System.Drawing.Size(400, 23);
            this.progressBarAdv1.TabIndex = 0;
            this.progressBarAdv1.Text = "progressBarAdv1";
            this.progressBarAdv1.TextShadow = false;
            this.progressBarAdv1.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Value;
            this.progressBarAdv1.ThemeName = "Office2016White";
            this.progressBarAdv1.Value = 100;
            this.progressBarAdv1.WaitingGradientWidth = 400;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Progress Bar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Segmented Progress Bar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gradient";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tube";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Multiple Colors";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 549);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarAdv5);
            this.Controls.Add(this.progressBarAdv4);
            this.Controls.Add(this.progressBarAdv2);
            this.Controls.Add(this.progressBarAdv3);
            this.Controls.Add(this.progressBarAdv1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Getting Started";
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.Run(new Form1());
        }

        #region timer
        private void timer2_Tick(object sender, System.EventArgs e)
        {

            if (Start)
            {
                if (this.progressBarAdv1.Value < 100)
                    this.progressBarAdv1.Value++;
                else
                    this.progressBarAdv1.Value = 0;

                if (this.progressBarAdv2.Value < 100)
                    this.progressBarAdv2.Value++;
                else
                    this.progressBarAdv2.Value = 0;

                if (this.progressBarAdv3.Value < 100)
                    this.progressBarAdv3.Value++;
                else
                    this.progressBarAdv3.Value = 0;

                if (this.progressBarAdv4.Value < 100)
                    this.progressBarAdv4.Value++;
                else
                    this.progressBarAdv4.Value = 0;

                if (this.progressBarAdv5.Value < 100)
                    this.progressBarAdv5.Value++;
                else
                    this.progressBarAdv5.Value = 0;
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
