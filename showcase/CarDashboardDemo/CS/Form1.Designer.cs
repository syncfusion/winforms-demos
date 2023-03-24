#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Windows.Forms;

namespace RadialGaugeDemo
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
            Syncfusion.Windows.Forms.Gauge.Range range1 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range2 = new Syncfusion.Windows.Forms.Gauge.Range();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.speedGauge = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.gradientPanel6 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.temperatureGauge = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.rpmGauge = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.gradientPanel5 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.fuelGauge = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.torqueGauge = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel6)).BeginInit();
            this.gradientPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).BeginInit();
            this.gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel5)).BeginInit();
            this.gradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).BeginInit();
            this.gradientPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.PatternStyle.Weave, System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18))))));
            this.gradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(2, 2);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1154, 606);
            this.gradientPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.gradientPanel2);
            this.panel1.Controls.Add(this.gradientPanel6);
            this.panel1.Controls.Add(this.gradientPanel3);
            this.panel1.Controls.Add(this.gradientPanel5);
            this.panel1.Controls.Add(this.gradientPanel4);
            this.panel1.Location = new System.Drawing.Point(63, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 604);
            this.panel1.TabIndex = 15;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.PatternStyle.Weave, System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18))))));
            this.gradientPanel2.BorderColor = System.Drawing.Color.Gray;
            this.gradientPanel2.BorderSingle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel2.Controls.Add(this.speedGauge);
            this.gradientPanel2.Location = new System.Drawing.Point(4, 0);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(482, 324);
            this.gradientPanel2.TabIndex = 12;
            // 
            // speedGauge
            // 
            this.speedGauge.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.speedGauge.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.speedGauge.EnableCustomNeedles = false;
            this.speedGauge.GaugeArcColor = System.Drawing.Color.White;
            this.speedGauge.GaugeLabel = "SPEED in MPH";
            this.speedGauge.GaugeLableFont = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedGauge.GaugeValueFont = new System.Drawing.Font("Segoe UI", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedGauge.InnerFrameGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.speedGauge.InnerFrameGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.speedGauge.InterLinesColor = System.Drawing.Color.White;
            this.speedGauge.LabelPlacement = Syncfusion.Windows.Forms.Gauge.LabelPlacement.Outside;
            this.speedGauge.Location = new System.Drawing.Point(43, 13);
            this.speedGauge.MajorTickMarkColor = System.Drawing.Color.White;
            this.speedGauge.MaximumValue = 160F;
            this.speedGauge.MinimumSize = new System.Drawing.Size(125, 125);
            this.speedGauge.MinorTickMarkColor = System.Drawing.Color.White;
            this.speedGauge.MinorTickMarkHeight = 0;
            this.speedGauge.Name = "speedGauge";
            this.speedGauge.NeedleColor = System.Drawing.Color.White;
            this.speedGauge.OuterFrameGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.speedGauge.OuterFrameGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            range1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(193)))), ((int)(((byte)(58)))));
            range1.EndValue = 0F;
            range1.Height = 5;
            range1.InRange = false;
            range1.Name = "GaugeRange4";
            range1.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            range1.StartValue = 0F;
            this.speedGauge.Ranges.Add(range1);
            this.speedGauge.ScaleLabelColor = System.Drawing.Color.White;
            this.speedGauge.ShowBackgroundFrame = false;
            this.speedGauge.Size = new System.Drawing.Size(375, 375);
            this.speedGauge.TabIndex = 6;
            this.speedGauge.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Black;
            // 
            // gradientPanel6
            // 
            this.gradientPanel6.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.PatternStyle.Weave, System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18))))));
            this.gradientPanel6.BorderColor = System.Drawing.Color.Gray;
            this.gradientPanel6.BorderSides = ((System.Windows.Forms.Border3DSide)((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientPanel6.BorderSingle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            this.gradientPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel6.Controls.Add(this.temperatureGauge);
            this.gradientPanel6.Location = new System.Drawing.Point(4, 324);
            this.gradientPanel6.Name = "gradientPanel6";
            this.gradientPanel6.Size = new System.Drawing.Size(323, 275);
            this.gradientPanel6.TabIndex = 14;
            // 
            // temperatureGauge
            // 
            this.temperatureGauge.EnableCustomNeedles = false;
            this.temperatureGauge.FrameType = Syncfusion.Windows.Forms.Gauge.FrameType.HalfCircle;
            this.temperatureGauge.GaugeArcColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.temperatureGauge.GaugeLabel = "TEMPERATURE";
            this.temperatureGauge.GaugeLableFont = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatureGauge.GaugeValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.temperatureGauge.GaugeValueFont = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatureGauge.Location = new System.Drawing.Point(-2, 35);
            this.temperatureGauge.MajorDifference = 10F;
            this.temperatureGauge.MaximumValue = 80F;
            this.temperatureGauge.MinimumSize = new System.Drawing.Size(130, 52);
            this.temperatureGauge.MinorInnerLinesHeight = 0;
            this.temperatureGauge.Name = "temperatureGauge";
            this.temperatureGauge.ShowBackgroundFrame = false;
            this.temperatureGauge.ShowGaugeValue = true;
            this.temperatureGauge.Size = new System.Drawing.Size(319, 212);
            this.temperatureGauge.StartAngle = 180;
            this.temperatureGauge.SweepAngle = 180;
            this.temperatureGauge.TabIndex = 8;
            this.temperatureGauge.TransparentBackGround = true;
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.PatternStyle.Weave, System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18))))));
            this.gradientPanel3.BorderColor = System.Drawing.Color.Gray;
            this.gradientPanel3.BorderSingle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            this.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel3.Controls.Add(this.rpmGauge);
            this.gradientPanel3.Location = new System.Drawing.Point(485, 0);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(489, 324);
            this.gradientPanel3.TabIndex = 13;
            // 
            // rpmGauge
            // 
            this.rpmGauge.EnableCustomNeedles = false;
            this.rpmGauge.ForeColor = System.Drawing.Color.White;
            this.rpmGauge.GaugeArcColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.rpmGauge.GaugeLabel = "RPM";
            this.rpmGauge.GaugeLableFont = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpmGauge.GaugeValueFont = new System.Drawing.Font("Segoe UI", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpmGauge.InnerFrameGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.rpmGauge.InnerFrameGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.rpmGauge.InterLinesColor = System.Drawing.Color.Black;
            this.rpmGauge.LabelPlacement = Syncfusion.Windows.Forms.Gauge.LabelPlacement.Outside;
            this.rpmGauge.Location = new System.Drawing.Point(79, 13);
            this.rpmGauge.MajorDifference = 1F;
            this.rpmGauge.MajorTickMarkColor = System.Drawing.Color.White;
            this.rpmGauge.MaximumValue = 8F;
            this.rpmGauge.MinimumSize = new System.Drawing.Size(125, 125);
            this.rpmGauge.MinorTickMarkColor = System.Drawing.Color.White;
            this.rpmGauge.Name = "rpmGauge";
            this.rpmGauge.NeedleColor = System.Drawing.Color.White;
            this.rpmGauge.OuterFrameGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.rpmGauge.OuterFrameGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            range2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            range2.EndValue = 0F;
            range2.Height = 5;
            range2.InRange = false;
            range2.Name = "GaugeRange4";
            range2.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            range2.StartValue = 0F;
            this.rpmGauge.Ranges.Add(range2);
            this.rpmGauge.ScaleLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.rpmGauge.ShowBackgroundFrame = false;
            this.rpmGauge.Size = new System.Drawing.Size(375, 375);
            this.rpmGauge.TabIndex = 11;
            this.rpmGauge.TextOrientation = Syncfusion.Windows.Forms.Gauge.TextOrientation.SlideOver;
            // 
            // gradientPanel5
            // 
            this.gradientPanel5.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.PatternStyle.Weave, System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18))))));
            this.gradientPanel5.BorderColor = System.Drawing.Color.Gray;
            this.gradientPanel5.BorderSides = ((System.Windows.Forms.Border3DSide)(((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientPanel5.BorderSingle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            this.gradientPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel5.Controls.Add(this.fuelGauge);
            this.gradientPanel5.Location = new System.Drawing.Point(328, 324);
            this.gradientPanel5.Name = "gradientPanel5";
            this.gradientPanel5.Size = new System.Drawing.Size(323, 275);
            this.gradientPanel5.TabIndex = 14;
            // 
            // fuelGauge
            // 
            this.fuelGauge.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.fuelGauge.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.fuelGauge.EnableCustomNeedles = false;
            this.fuelGauge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelGauge.FrameType = Syncfusion.Windows.Forms.Gauge.FrameType.HalfCircle;
            this.fuelGauge.GaugeArcColor = System.Drawing.Color.White;
            this.fuelGauge.GaugeLabel = "FUEL";
            this.fuelGauge.GaugeLableFont = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelGauge.GaugeValueFont = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelGauge.InnerFrameGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.fuelGauge.InnerFrameGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.fuelGauge.InterLinesColor = System.Drawing.Color.White;
            this.fuelGauge.Location = new System.Drawing.Point(45, 70);
            this.fuelGauge.MajorTickMarkColor = System.Drawing.Color.White;
            this.fuelGauge.MajorTickMarkHeight = 15;
            this.fuelGauge.MaximumValue = 100F;
            this.fuelGauge.MinimumSize = new System.Drawing.Size(130, 52);
            this.fuelGauge.MinorTickMarkColor = System.Drawing.Color.White;
            this.fuelGauge.Name = "fuelGauge";
            this.fuelGauge.NeedleColor = System.Drawing.Color.White;
            this.fuelGauge.NeedleStyle = Syncfusion.Windows.Forms.Gauge.NeedleStyle.Pointer;
            this.fuelGauge.OuterFrameGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.fuelGauge.OuterFrameGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.fuelGauge.ScaleLabelColor = System.Drawing.Color.White;
            this.fuelGauge.ShowBackgroundFrame = false;
            this.fuelGauge.ShowGaugeValue = true;
            this.fuelGauge.ShowNeedle = false;
            this.fuelGauge.ShowScaleLabel = false;
            this.fuelGauge.Size = new System.Drawing.Size(230, 152);
            this.fuelGauge.StartAngle = 180;
            this.fuelGauge.SweepAngle = 180;
            this.fuelGauge.TabIndex = 9;
            this.fuelGauge.TickPlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            this.fuelGauge.TransparentBackGround = true;
            this.fuelGauge.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Black;
            // 
            // gradientPanel4
            // 
            this.gradientPanel4.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.PatternStyle.Weave, System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18))))));
            this.gradientPanel4.BorderColor = System.Drawing.Color.Gray;
            this.gradientPanel4.BorderSides = ((System.Windows.Forms.Border3DSide)((System.Windows.Forms.Border3DSide.Right | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientPanel4.BorderSingle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            this.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel4.Controls.Add(this.torqueGauge);
            this.gradientPanel4.Location = new System.Drawing.Point(652, 324);
            this.gradientPanel4.Name = "gradientPanel4";
            this.gradientPanel4.Size = new System.Drawing.Size(322, 275);
            this.gradientPanel4.TabIndex = 14;
            // 
            // torqueGauge
            // 
            this.torqueGauge.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.torqueGauge.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.torqueGauge.EnableCustomNeedles = false;
            this.torqueGauge.FrameType = Syncfusion.Windows.Forms.Gauge.FrameType.HalfCircle;
            this.torqueGauge.GaugeArcColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.torqueGauge.GaugeLabel = "TORQUE";
            this.torqueGauge.GaugeLableFont = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.torqueGauge.GaugeValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(185)))), ((int)(((byte)(196)))));
            this.torqueGauge.GaugeValueFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.torqueGauge.InnerFrameGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.torqueGauge.InnerFrameGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.torqueGauge.InterLinesColor = System.Drawing.Color.Blue;
            this.torqueGauge.Location = new System.Drawing.Point(8, 22);
            this.torqueGauge.MajorDifference = 0.3F;
            this.torqueGauge.MajorTickMarkColor = System.Drawing.Color.Blue;
            this.torqueGauge.MajorTickMarkHeight = 14;
            this.torqueGauge.MaximumValue = 2.1F;
            this.torqueGauge.MinimumSize = new System.Drawing.Size(130, 52);
            this.torqueGauge.MinimumValue = 0.3F;
            this.torqueGauge.MinorTickMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(20)))), ((int)(((byte)(19)))));
            this.torqueGauge.MinorTickMarkHeight = 0;
            this.torqueGauge.Name = "torqueGauge";
            this.torqueGauge.NeedleColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.torqueGauge.NeedleStyle = Syncfusion.Windows.Forms.Gauge.NeedleStyle.Advanced;
            this.torqueGauge.OuterFrameGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.torqueGauge.OuterFrameGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.torqueGauge.ScaleLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.torqueGauge.ShowBackgroundFrame = false;
            this.torqueGauge.ShowGaugeValue = true;
            this.torqueGauge.Size = new System.Drawing.Size(317, 210);
            this.torqueGauge.StartAngle = 180;
            this.torqueGauge.SweepAngle = 180;
            this.torqueGauge.TabIndex = 10;
            this.torqueGauge.TransparentBackGround = true;
            this.torqueGauge.Value = 0.3F;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1158, 610);
            this.Controls.Add(this.gradientPanel1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.BackColor = System.Drawing.Color.Black;
            this.Style.InactiveShadowOpacity = ((byte)(0));
            this.Style.ShadowOpacity = ((byte)(0));
            this.Style.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.Style.TitleBar.CloseButtonForeColor = System.Drawing.Color.White;
            this.Style.TitleBar.CloseButtonHoverForeColor = System.Drawing.Color.FloralWhite;
            this.Style.TitleBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Style.TitleBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Style.TitleBar.Height = 70;
            this.Style.TitleBar.MaximizeButtonForeColor = System.Drawing.Color.White;
            this.Style.TitleBar.MaximizeButtonHoverForeColor = System.Drawing.Color.Black;
            this.Style.TitleBar.MinimizeButtonForeColor = System.Drawing.Color.White;
            this.Style.TitleBar.MinimizeButtonHoverForeColor = System.Drawing.Color.Black;
            this.Text = "Car Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel6)).EndInit();
            this.gradientPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).EndInit();
            this.gradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel5)).EndInit();
            this.gradientPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).EndInit();
            this.gradientPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge speedGauge;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge fuelGauge;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge temperatureGauge;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge torqueGauge;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge rpmGauge;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel4;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel5;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel6;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private System.Windows.Forms.Panel panel1;


    }
}

