#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
namespace ProgressBarAdv_CustomRender
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                if (this.progressBarAdv1 != null)
                {
                    if (this.progressBarAdv1.Renderer != null && this.progressBarAdv1.Renderer is IDisposable)
                    {
                        (this.progressBarAdv1.Renderer as IDisposable).Dispose();
                    }
                }
                if (this.progressBarAdv2 != null)
                {
                    if (this.progressBarAdv2.Renderer != null && this.progressBarAdv2.Renderer is IDisposable)
                    {
                        (this.progressBarAdv2.Renderer as IDisposable).Dispose();
                    }
                }
                if (this.progressBarAdv3 != null)
                {
                    if (this.progressBarAdv3.Renderer != null && this.progressBarAdv3.Renderer is IDisposable)
                    {
                        (this.progressBarAdv3.Renderer as IDisposable).Dispose();
                    }
                }
                if (this.progressBarAdv4 != null)
                {
                    if (this.progressBarAdv4.Renderer != null && this.progressBarAdv4.Renderer is IDisposable)
                    {
                        (this.progressBarAdv4.Renderer as IDisposable).Dispose();
                    }
                }
                if (this.progressBarAdv5 != null)
                {
                    if (this.progressBarAdv5.Renderer != null && this.progressBarAdv5.Renderer is IDisposable)
                    {
                        (this.progressBarAdv5.Renderer as IDisposable).Dispose();
                    }
                }
                if (this.progressBarAdv6 != null)
                {
                    if (this.progressBarAdv6.Renderer != null && this.progressBarAdv6.Renderer is IDisposable)
                    {
                        (this.progressBarAdv6.Renderer as IDisposable).Dispose();
                    }
                }
                if (this.progressBarAdv7 != null)
                {
                    if (this.progressBarAdv7.Renderer != null && this.progressBarAdv7.Renderer is IDisposable)
                    {
                        (this.progressBarAdv7.Renderer as IDisposable).Dispose();
                    }
                }
                if (this.progressBarAdv8 != null)
                {
                    if (this.progressBarAdv8.Renderer != null && this.progressBarAdv8.Renderer is IDisposable)
                    {
                        (this.progressBarAdv8.Renderer as IDisposable).Dispose();
                    }
                }

                if (this.timer1 != null)
                {
                    this.timer1.Tick -= new EventHandler(timer1_Tick);
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarAdv8 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.progressBarAdv7 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.progressBarAdv3 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.progressBarAdv6 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.progressBarAdv5 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.progressBarAdv4 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.progressBarAdv1 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBarAdv2 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.progressBarAdv8);
            this.panel1.Controls.Add(this.progressBarAdv7);
            this.panel1.Controls.Add(this.progressBarAdv3);
            this.panel1.Controls.Add(this.progressBarAdv6);
            this.panel1.Controls.Add(this.progressBarAdv5);
            this.panel1.Controls.Add(this.progressBarAdv4);
            this.panel1.Controls.Add(this.progressBarAdv1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Name = "panel1";
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Name = "label3";
            this.label3.TabIndex = 17;
            this.label3.Text = "Custom view";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Name = "label2";
            this.label2.TabIndex = 16;
            this.label2.Text = "Segment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Name = "label1";
            this.label1.TabIndex = 15;
            this.label1.Text = "Radial";
            // 
            // progressBarAdv8
            // 
            this.progressBarAdv8.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv8.BackSegments = false;
            this.progressBarAdv8.BorderColor = System.Drawing.Color.LightGray;
            this.progressBarAdv8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.progressBarAdv8.CustomText = null;
            this.progressBarAdv8.CustomWaitingRender = false;
            this.progressBarAdv8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarAdv8.ForegroundImage = null;
            this.progressBarAdv8.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv8.Name = "progressBarAdv8";
            this.progressBarAdv8.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient;
            this.progressBarAdv8.SegmentWidth = 12;
            this.progressBarAdv8.TabIndex = 14;
            this.progressBarAdv8.Text = "progressBarAdv8";
            this.progressBarAdv8.ThemeName = "WaitingGradient";
            this.progressBarAdv8.ThemesEnabled = false;
            this.progressBarAdv8.Value = 0;
            this.progressBarAdv8.WaitingGradientWidth = 400;
            // 
            // progressBarAdv7
            // 
            this.progressBarAdv7.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv7.BackSegments = false;
            this.progressBarAdv7.BorderColor = System.Drawing.Color.LightGray;
            this.progressBarAdv7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.progressBarAdv7.CustomText = null;
            this.progressBarAdv7.CustomWaitingRender = false;
            this.progressBarAdv7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarAdv7.ForegroundImage = null;
            this.progressBarAdv7.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv7.Name = "progressBarAdv7";
            this.progressBarAdv7.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient;
            this.progressBarAdv7.SegmentWidth = 12;
            this.progressBarAdv7.TabIndex = 13;
            this.progressBarAdv7.Text = "progressBarAdv7";
            this.progressBarAdv7.ThemeName = "WaitingGradient";
            this.progressBarAdv7.ThemesEnabled = false;
            this.progressBarAdv7.Value = 0;
            this.progressBarAdv7.WaitingGradientWidth = 400;
            // 
            // progressBarAdv3
            // 
            this.progressBarAdv3.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv3.BackSegments = false;
            this.progressBarAdv3.CustomText = null;
            this.progressBarAdv3.CustomWaitingRender = false;
            this.progressBarAdv3.ForegroundImage = null;
            this.progressBarAdv3.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv3.Name = "progressBarAdv3";
            this.progressBarAdv3.SegmentWidth = 12;
            this.progressBarAdv3.TabIndex = 10;
            this.progressBarAdv3.Text = "S";
            this.progressBarAdv3.ThemesEnabled = false;
            this.progressBarAdv3.WaitingGradientWidth = 400;
            // 
            // progressBarAdv6
            // 
            this.progressBarAdv6.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv6.BackSegments = false;
            this.progressBarAdv6.BorderColor = System.Drawing.Color.LightGray;
            this.progressBarAdv6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.progressBarAdv6.CustomText = null;
            this.progressBarAdv6.CustomWaitingRender = false;
            this.progressBarAdv6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarAdv6.ForegroundImage = null;
            this.progressBarAdv6.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv6.Name = "progressBarAdv6";
            this.progressBarAdv6.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient;
            this.progressBarAdv6.SegmentWidth = 12;
            this.progressBarAdv6.TabIndex = 8;
            this.progressBarAdv6.Text = "progressBarAdv6";
            this.progressBarAdv6.ThemeName = "WaitingGradient";
            this.progressBarAdv6.ThemesEnabled = false;
            this.progressBarAdv6.Value = 0;
            this.progressBarAdv6.WaitingGradientWidth = 400;
            // 
            // progressBarAdv5
            // 
            this.progressBarAdv5.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv5.BackSegments = false;
            this.progressBarAdv5.BorderColor = System.Drawing.Color.LightGray;
            this.progressBarAdv5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.progressBarAdv5.CustomText = null;
            this.progressBarAdv5.CustomWaitingRender = false;
            this.progressBarAdv5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarAdv5.ForegroundImage = null;
            this.progressBarAdv5.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv5.Name = "progressBarAdv5";
            this.progressBarAdv5.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient;
            this.progressBarAdv5.SegmentWidth = 12;
            this.progressBarAdv5.TabIndex = 3;
            this.progressBarAdv5.Text = "progressBarAdv5";
            this.progressBarAdv5.ThemeName = "WaitingGradient";
            this.progressBarAdv5.ThemesEnabled = false;
            this.progressBarAdv5.Value = 0;
            this.progressBarAdv5.WaitingGradientWidth = 400;
            // 
            // progressBarAdv4
            // 
            this.progressBarAdv4.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv4.BackSegments = false;
            this.progressBarAdv4.BorderColor = System.Drawing.Color.LightGray;
            this.progressBarAdv4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.progressBarAdv4.CustomText = null;
            this.progressBarAdv4.CustomWaitingRender = false;
            this.progressBarAdv4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarAdv4.ForegroundImage = null;
            this.progressBarAdv4.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv4.Name = "progressBarAdv4";
            this.progressBarAdv4.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient;
            this.progressBarAdv4.SegmentWidth = 12;
            this.progressBarAdv4.TabIndex = 2;
            this.progressBarAdv4.Text = "progressBarAdv4";
            this.progressBarAdv4.ThemeName = "WaitingGradient";
            this.progressBarAdv4.ThemesEnabled = false;
            this.progressBarAdv4.Value = 0;
            this.progressBarAdv4.WaitingGradientWidth = 400;
            // 
            // progressBarAdv1
            // 
            this.progressBarAdv1.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv1.BackSegments = false;
            this.progressBarAdv1.BorderColor = System.Drawing.Color.LightGray;
            this.progressBarAdv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.progressBarAdv1.CustomText = null;
            this.progressBarAdv1.CustomWaitingRender = false;
            this.progressBarAdv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarAdv1.ForegroundImage = null;
            this.progressBarAdv1.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv1.Name = "progressBarAdv1";
            this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient;
            this.progressBarAdv1.SegmentWidth = 12;
            this.progressBarAdv1.TabIndex = 0;
            this.progressBarAdv1.Text = "progressBarAdv1";
            this.progressBarAdv1.ThemeName = "WaitingGradient";
            this.progressBarAdv1.ThemesEnabled = false;
            this.progressBarAdv1.Value = 0;
            this.progressBarAdv1.WaitingGradientWidth = 400;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // progressBarAdv2
            // 
            this.progressBarAdv2.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv2.BackSegments = false;
            this.progressBarAdv2.BorderColor = System.Drawing.Color.LightGray;
            this.progressBarAdv2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.progressBarAdv2.CustomText = null;
            this.progressBarAdv2.CustomWaitingRender = false;
            this.progressBarAdv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarAdv2.ForegroundImage = null;
            this.progressBarAdv2.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv2.Name = "progressBarAdv2";
            this.progressBarAdv2.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient;
            this.progressBarAdv2.SegmentWidth = 12;
            this.progressBarAdv2.TabIndex = 1;
            this.progressBarAdv2.Text = "progressBarAdv2";
            this.progressBarAdv2.ThemeName = "WaitingGradient";
            this.progressBarAdv2.ThemesEnabled = false;
            this.progressBarAdv2.Value = 0;
            this.progressBarAdv2.WaitingGradientWidth = 400;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 687);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(881, 800);
            this.MinimumSize = new System.Drawing.Size(881, 726);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customization";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarAdv3;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarAdv6;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarAdv5;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarAdv4;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarAdv2;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarAdv1;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarAdv7;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarAdv8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

