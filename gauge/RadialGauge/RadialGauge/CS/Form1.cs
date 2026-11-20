#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Gauge;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Range = Syncfusion.Windows.Forms.Gauge.Range;

namespace RadialGaugeDemo
{
    public partial class Form1 : SfForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        #region private variables

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge4;
        private Syncfusion.Windows.Forms.Tools.GridLayout gridLayout1;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge3;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge2;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge7;
        private Syncfusion.Windows.Forms.Tools.GridLayout gridLayout2;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge6;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge5;

        #endregion

        #region constructor 
        public Form1()
        {
            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
            this.Text = "Radial Gauge";           
        }

        #endregion

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.radialGauge7 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.radialGauge6 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.radialGauge5 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.radialGauge3 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radialGauge4 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.radialGauge2 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.radialGauge1 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.gridLayout1 = new Syncfusion.Windows.Forms.Tools.GridLayout(this.components);
            this.gridLayout2 = new Syncfusion.Windows.Forms.Tools.GridLayout(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(612, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 687);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(370, 691);
            this.panel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.radialGauge7);
            this.panel5.Controls.Add(this.radialGauge6);
            this.panel5.Controls.Add(this.radialGauge5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(370, 691);
            this.panel5.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radialGauge4);
            this.panel2.Controls.Add(this.radialGauge3);
            this.panel2.Controls.Add(this.radialGauge2);
            this.panel2.Controls.Add(this.radialGauge1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 687);
            this.panel2.TabIndex = 1;
            // 
            // gridLayout1
            // 
            this.gridLayout1.BottomMargin = 10;
            this.gridLayout1.Columns = 2;
            this.gridLayout1.ContainerControl = this.panel2;
            this.gridLayout1.HGap = 10;
            this.gridLayout1.HorzFarMargin = 10;
            this.gridLayout1.HorzNearMargin = 30;
            this.gridLayout1.Rows = 2;
            this.gridLayout1.TopMargin = 10;
            // 
            // gridLayout2
            // 
            this.gridLayout2.BottomMargin = 50;
            this.gridLayout2.Columns = 1;
            this.gridLayout2.ContainerControl = this.panel5;
            this.gridLayout2.HGap = 10;
            this.gridLayout2.HorzNearMargin = 30;
            this.gridLayout2.Rows = 3;
            this.gridLayout2.TopMargin = 10;
            this.gridLayout2.VGap = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 691);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MinimumSize= this.MaximumSize= this.Size = new Size(1123, 720);
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout2)).EndInit();
            this.ResumeLayout(false);
            UpdateGaugeProperties();
        }

        #endregion
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
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 

        private void UpdateGaugeProperties()
        {
            // 
            // radialGauge1
            // 
            this.radialGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Silver;
            this.radialGauge1.ArcThickness = 1F;
            this.radialGauge1.BackgroundGradientEndColor = System.Drawing.Color.White;
            this.radialGauge1.BackgroundGradientStartColor = System.Drawing.Color.White;
            this.radialGauge1.EnableCustomNeedles = false;
            this.radialGauge1.FillColor = System.Drawing.Color.Gray;
            this.radialGauge1.GaugeArcColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge1.GaugeLabel = "Gauge";
            this.radialGauge1.GaugeLableFont = new System.Drawing.Font("Segoe UI", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge1.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge1.InnerFrameGradientEndColor = System.Drawing.Color.White;
            this.radialGauge1.InnerFrameGradientStartColor = System.Drawing.Color.White;
            this.radialGauge1.TickPlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            this.radialGauge1.Location = new System.Drawing.Point(10, 351);
            this.radialGauge1.MajorDifference = 10F;
            this.radialGauge1.MaximumSize = new System.Drawing.Size(350, 350);
            this.radialGauge1.MaximumValue = 120F;
            this.radialGauge1.MinimumSize = new System.Drawing.Size(350, 350);
            this.radialGauge1.MinorDifference = 2F;
            this.radialGauge1.Name = "radialGauge1";
            this.radialGauge1.MajorTickMarkColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge1.MinorTickMarkColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge1.NeedleColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge1.OuterFrameGradientEndColor = System.Drawing.Color.White;
            this.radialGauge1.OuterFrameGradientStartColor = System.Drawing.Color.White;
            this.gridLayout1.SetParticipateInLayout(this.radialGauge4, true);
            this.radialGauge1.ShowTicks = true;
            this.radialGauge1.Size = new System.Drawing.Size(277, 277);
            this.radialGauge1.TabIndex = 0;
            this.radialGauge1.ThemeName = "Silver";
            this.radialGauge1.TransparentBackGround = true;
            this.radialGauge1.GaugeLabel = "TickPlacement OutSide" +" \n" + "           Read only";
            this.radialGauge1.NeedleStyle = NeedleStyle.Pointer;
            this.radialGauge1.GaugeLableColor = Color.Black;
            this.radialGauge1.ScaleLabelColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge1.Value = 50;
            // 
            // radialGauge2
            // 
            this.radialGauge2.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Silver;
            this.radialGauge2.ArcThickness = 1F;
            this.radialGauge2.BackgroundGradientEndColor = System.Drawing.Color.White;
            this.radialGauge2.BackgroundGradientStartColor = System.Drawing.Color.White;
            this.radialGauge2.EnableCustomNeedles = false;
            this.radialGauge2.FillColor = System.Drawing.Color.Gray;
            this.radialGauge2.GaugeArcColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge2.GaugeLabel = "Gauge";
            this.radialGauge2.GaugeLableFont = new System.Drawing.Font("Segoe UI", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge2.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge2.InnerFrameGradientEndColor = System.Drawing.Color.White;
            this.radialGauge2.InnerFrameGradientStartColor = System.Drawing.Color.White;
            this.radialGauge2.TickPlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            this.radialGauge2.Location = new System.Drawing.Point(297, 11);
            this.radialGauge2.MajorDifference = 10F;
            this.radialGauge2.MaximumSize = new System.Drawing.Size(350, 350);
            this.radialGauge2.MaximumValue = 120F;
            this.radialGauge2.MinimumSize = new System.Drawing.Size(350, 350);
            this.radialGauge2.MinorDifference = 2F;
            this.radialGauge2.Name = "radialGauge2";
            this.radialGauge2.MajorTickMarkColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge2.MinorTickMarkColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge2.NeedleColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge2.OuterFrameGradientEndColor = System.Drawing.Color.White;
            this.radialGauge2.OuterFrameGradientStartColor = System.Drawing.Color.White;
            this.gridLayout1.SetParticipateInLayout(this.radialGauge4, true);
            this.radialGauge2.ShowTicks = true;
            this.radialGauge2.Size = new System.Drawing.Size(277, 277);
            this.radialGauge2.TabIndex = 1;
            this.radialGauge2.ThemeName = "Silver";
            this.radialGauge2.TransparentBackGround = true;
            this.radialGauge2.GaugeLabel = "TickPlacement Inside"+ "\n" + "   User interaction";
            this.radialGauge2.NeedleStyle = NeedleStyle.Pointer;
            this.radialGauge2.GaugeLableColor = Color.Black;
            this.radialGauge2.ScaleLabelColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge2.Value = 80;
            this.radialGauge2.ReadOnly = false;
            // 
            // radialGauge3
            // 
            this.radialGauge3.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Silver;
            this.radialGauge3.ArcThickness = 0F;
            this.radialGauge3.BackgroundGradientEndColor = System.Drawing.Color.White;
            this.radialGauge3.BackgroundGradientStartColor = System.Drawing.Color.White;
            this.radialGauge3.EnableCustomNeedles = false;
            this.radialGauge3.FillColor = System.Drawing.Color.Gray;
            this.radialGauge3.GaugeArcColor = System.Drawing.Color.Transparent;
            this.radialGauge3.GaugeLabel = "Gauge";
            this.radialGauge3.GaugeLableFont = new System.Drawing.Font("Segoe UI", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge3.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge3.InnerFrameGradientEndColor = System.Drawing.Color.White;
            this.radialGauge3.InnerFrameGradientStartColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge3.LabelPlacement = Syncfusion.Windows.Forms.Gauge.LabelPlacement.Inside;
            this.radialGauge3.Location = new System.Drawing.Point(297, 11);
            this.radialGauge3.MajorDifference = 10F;
            this.radialGauge3.MaximumSize = new System.Drawing.Size(350, 350);
            this.radialGauge3.MaximumValue = 200F;
            this.radialGauge3.MinimumValue = 100F;
            this.radialGauge3.MinimumSize = new System.Drawing.Size(350, 350);
            this.radialGauge3.MinorDifference = 2F;
            this.radialGauge3.Name = "radialGauge3";
            this.radialGauge3.MajorTickMarkColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge3.MinorTickMarkColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge3.NeedleColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge3.OuterFrameGradientEndColor = System.Drawing.Color.White;
            this.radialGauge3.OuterFrameGradientStartColor = System.Drawing.Color.White;
            this.gridLayout1.SetParticipateInLayout(this.radialGauge4, true);
            this.radialGauge3.ShowTicks = true;
            this.radialGauge3.Size = new System.Drawing.Size(277, 277);
            this.radialGauge3.TabIndex = 2;
            this.radialGauge3.ThemeName = "Silver";
            this.radialGauge3.TransparentBackGround = true;
            Range newRange1 = new Range();
            newRange1.EndValue = 135;
            newRange1.StartValue = 100;
            newRange1.Height = 10;
            newRange1.RangePlacement = TickPlacement.OutSide;
            newRange1.Color = Color.OrangeRed;
            Range newRange2 = new Range();
            newRange2.EndValue = 170;
            newRange2.StartValue = 135;
            newRange2.Height = 10;
            newRange2.RangePlacement = TickPlacement.OutSide;
            newRange2.Color = Color.Gold;
            Range newRange3 = new Range();
            newRange3.EndValue = 200;
            newRange3.StartValue = 170;
            newRange3.Height = 10;
            newRange3.RangePlacement = TickPlacement.OutSide;
            newRange3.Color = Color.Turquoise;
            this.radialGauge3.Ranges.Add(newRange1);
            this.radialGauge3.Ranges.Add(newRange2);
            this.radialGauge3.Ranges.Add(newRange3);
            this.radialGauge3.Refresh();
            this.radialGauge3.GaugeLabel = "Range Outside"+ "\n"+"   Value Inside";
            this.radialGauge3.NeedleStyle = NeedleStyle.Advanced;
            this.radialGauge3.GaugeLableColor = Color.Black;
            this.radialGauge3.ScaleLabelColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge3.Value = 145;
            this.radialGauge3.ReadOnly = false;
            // 
            // radialGauge4
            // 

            this.radialGauge4.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Silver;
            this.radialGauge4.ArcThickness = 0F;
            this.radialGauge4.BackgroundGradientEndColor = System.Drawing.Color.White;
            this.radialGauge4.BackgroundGradientStartColor = System.Drawing.Color.White;
            this.radialGauge4.EnableCustomNeedles = false;
            this.radialGauge4.FillColor = System.Drawing.Color.Gray;
            this.radialGauge4.GaugeArcColor = System.Drawing.Color.Transparent;
            this.radialGauge4.GaugeLabel = "Gauge";
            this.radialGauge4.GaugeLableFont = new System.Drawing.Font("Segoe UI", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge4.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge4.InnerFrameGradientEndColor = System.Drawing.Color.White;
            this.radialGauge4.InnerFrameGradientStartColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge4.LabelPlacement = Syncfusion.Windows.Forms.Gauge.LabelPlacement.Outside;
            this.radialGauge4.Location = new System.Drawing.Point(10, 11);
            this.radialGauge4.MajorDifference = 10F;
            this.radialGauge4.MaximumSize = new System.Drawing.Size(350, 350);
            this.radialGauge4.MaximumValue = 120F;
            this.radialGauge4.MinimumSize = new System.Drawing.Size(350, 350);
            this.radialGauge4.MinorDifference = 2F;
            this.radialGauge4.Name = "radialGauge4";
            this.radialGauge4.MajorTickMarkColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge4.MinorTickMarkColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge4.NeedleColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge4.OuterFrameGradientEndColor = System.Drawing.Color.White;
            this.radialGauge4.OuterFrameGradientStartColor = System.Drawing.Color.White;
            this.gridLayout1.SetParticipateInLayout(this.radialGauge4, true);
            this.radialGauge4.ShowTicks = true;
            this.radialGauge4.Size = new System.Drawing.Size(277, 277);
            this.radialGauge4.TabIndex = 0;
            this.radialGauge4.ThemeName = "Silver";
            this.radialGauge4.TransparentBackGround = true;
            Range newRange4 = new Range();
            newRange4.EndValue = 40;
            newRange4.StartValue = 0;
            newRange4.Height = 10;
            newRange4.Color = Color.OrangeRed;
            Range newRange5 = new Range();
            newRange5.EndValue = 80;
            newRange5.StartValue = 40;
            newRange5.Height = 10;
            newRange5.Color = Color.Gold;
            Range newRange6 = new Range();
            newRange6.EndValue = 120;
            newRange6.StartValue = 80;
            newRange6.Height = 10;
            newRange6.Color = Color.Turquoise;
            this.radialGauge4.Ranges.Add(newRange4);
            this.radialGauge4.Ranges.Add(newRange5);
            this.radialGauge4.Ranges.Add(newRange6);
            this.radialGauge4.Refresh();
            this.radialGauge4.GaugeLabel = " Range Inside" + "\n" + "Value Outside"; ;
            this.radialGauge4.NeedleStyle = NeedleStyle.Advanced;
            this.radialGauge4.GaugeLableColor = Color.Black;
            this.radialGauge4.ScaleLabelColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge4.Value = 65;
            this.radialGauge4.ReadOnly = false;
            // 
            // radialGauge5
            // 
            this.radialGauge5.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Silver;
            this.radialGauge5.ArcThickness = 1F;
            this.radialGauge5.BackgroundGradientEndColor = System.Drawing.Color.White;
            this.radialGauge5.BackgroundGradientStartColor = System.Drawing.Color.White;
            this.radialGauge5.EnableCustomNeedles = false;
            this.radialGauge5.FillColor = System.Drawing.Color.Gray;
            this.radialGauge5.GaugeArcColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge5.GaugeLabel = "Gauge";
            this.radialGauge5.GaugeLableFont = new System.Drawing.Font("Segoe UI", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge5.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge5.InnerFrameGradientEndColor = System.Drawing.Color.White;
            this.radialGauge5.InnerFrameGradientStartColor = System.Drawing.Color.White;
            this.radialGauge5.TickPlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            this.radialGauge5.Location = new System.Drawing.Point(0, 421);
            this.radialGauge5.MajorDifference = 10F;
            this.radialGauge5.MaximumSize = new System.Drawing.Size(250, 250);
            this.radialGauge5.MaximumValue = 100F;
            this.radialGauge5.MinimumSize = new System.Drawing.Size(250, 250);
            this.radialGauge5.MinorDifference = 2F;
            this.radialGauge5.Name = "radialGauge5";
            this.radialGauge5.MajorTickMarkColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge5.MinorTickMarkColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge5.NeedleColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge5.OuterFrameGradientEndColor = System.Drawing.Color.White;
            this.radialGauge5.OuterFrameGradientStartColor = System.Drawing.Color.White;
            this.gridLayout2.SetParticipateInLayout(this.radialGauge4, true);
            this.radialGauge5.ShowTicks = true;
            this.radialGauge5.Size = new System.Drawing.Size(277, 277);
            this.radialGauge5.TabIndex = 0;
            this.radialGauge5.ThemeName = "Silver";
            this.radialGauge5.TransparentBackGround = true;
            this.radialGauge5.GaugeLabel = "Needle Default";
            this.radialGauge5.NeedleStyle = NeedleStyle.Default;
            this.radialGauge5.GaugeLableColor = Color.Black;
            this.radialGauge5.ScaleLabelColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge5.MajorTickMarkHeight = this.radialGauge5.MinorTickMarkHeight;
            this.radialGauge5.ReadOnly = false;
            // 
            // radialGauge6
            // 

            this.radialGauge6.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Silver;
            this.radialGauge6.ArcThickness = 1F;
            this.radialGauge6.BackgroundGradientEndColor = System.Drawing.Color.White;
            this.radialGauge6.BackgroundGradientStartColor = System.Drawing.Color.White;
            this.radialGauge6.EnableCustomNeedles = false;
            this.radialGauge6.FillColor = System.Drawing.Color.Gray;
            this.radialGauge6.GaugeArcColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge6.GaugeLabel = "Gauge";
            this.radialGauge6.GaugeLableFont = new System.Drawing.Font("Segoe UI", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge6.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge6.InnerFrameGradientEndColor = System.Drawing.Color.White;
            this.radialGauge6.InnerFrameGradientStartColor = System.Drawing.Color.White;
            this.radialGauge6.TickPlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            this.radialGauge6.Location = new System.Drawing.Point(0, 218);
            this.radialGauge6.MajorDifference = 10F;
            this.radialGauge6.MaximumSize = new System.Drawing.Size(250, 250);
            this.radialGauge6.MaximumValue = 100F;
            this.radialGauge6.MinimumSize = new System.Drawing.Size(250, 250);
            this.radialGauge6.MinorDifference = 10F;
            this.radialGauge6.Name = "radialGauge5";
            this.radialGauge6.MajorTickMarkColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge6.MinorTickMarkColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge6.NeedleColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge6.OuterFrameGradientEndColor = System.Drawing.Color.White;
            this.radialGauge6.OuterFrameGradientStartColor = System.Drawing.Color.White;
            this.gridLayout2.SetParticipateInLayout(this.radialGauge4, true);
            this.radialGauge6.ShowTicks = true;
            this.radialGauge6.Size = new System.Drawing.Size(277, 277);
            this.radialGauge6.TabIndex = 1;
            this.radialGauge6.ThemeName = "Silver";
            this.radialGauge6.TransparentBackGround = true;
            this.radialGauge6.GaugeLabel = "Needle Pointer";
            this.radialGauge6.NeedleStyle = NeedleStyle.Pointer;
            this.radialGauge6.GaugeLableColor = Color.Black;
            this.radialGauge6.ScaleLabelColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge6.Value = 50;
            this.radialGauge6.ShowGaugeValue = true;
            this.radialGauge6.GaugeValueColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge6.ReadOnly = true;
            //
            // radialGauge7
            // 
            this.radialGauge7.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Silver;
            this.radialGauge7.ArcThickness = 1F;
            this.radialGauge7.BackgroundGradientEndColor = System.Drawing.Color.White;
            this.radialGauge7.BackgroundGradientStartColor = System.Drawing.Color.White;
            this.radialGauge7.EnableCustomNeedles = false;
            this.radialGauge7.FillColor = System.Drawing.Color.Gray;
            this.radialGauge7.GaugeArcColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge7.GaugeLabel = "Gauge";
            this.radialGauge7.GaugeLableFont = new System.Drawing.Font("Segoe UI", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge7.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge7.InnerFrameGradientEndColor = System.Drawing.Color.White;
            this.radialGauge7.InnerFrameGradientStartColor = System.Drawing.Color.White;
            this.radialGauge7.TickPlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            this.radialGauge7.Location = new System.Drawing.Point(0, 11);
            this.radialGauge7.MajorDifference = 10F;
            this.radialGauge7.MaximumSize = new System.Drawing.Size(250, 250);
            this.radialGauge7.MaximumValue = 100F;
            this.radialGauge7.MinimumSize = new System.Drawing.Size(250, 250);
            this.radialGauge7.MinorDifference = 2F;
            this.radialGauge7.Name = "radialGauge5";
            this.radialGauge7.MajorTickMarkColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge7.MinorTickMarkColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge7.NeedleColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge7.OuterFrameGradientEndColor = System.Drawing.Color.White;
            this.radialGauge7.OuterFrameGradientStartColor = System.Drawing.Color.White;
            this.gridLayout2.SetParticipateInLayout(this.radialGauge4, true);
            this.radialGauge7.ShowTicks = true;
            this.radialGauge7.Size = new System.Drawing.Size(277, 277);
            this.radialGauge7.TabIndex = 2;
            this.radialGauge7.ThemeName = "Silver";
            this.radialGauge7.TransparentBackGround = true;
            this.radialGauge7.GaugeLabel = "Needle Advanced";
            this.radialGauge7.NeedleStyle = NeedleStyle.Advanced;
            this.radialGauge7.GaugeLableColor = Color.Black;
            this.radialGauge7.ShowTicks = false;
            this.radialGauge7.ScaleLabelColor = ColorTranslator.FromHtml("#ff1800bd");
            this.radialGauge7.ReadOnly = false;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }

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
                return System.IO.File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }
}
