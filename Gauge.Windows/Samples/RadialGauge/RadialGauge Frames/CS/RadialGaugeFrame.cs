#region Copyright Syncfusion Inc. 2001 - 2020
// Copyright Syncfusion Inc. 2001 - 2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadialGaugeFramesDemo
{
    public partial class RadialGaugeFrame : SfForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private Syncfusion.Windows.Forms.Tools.GridLayout gridLayout2;
        private System.Windows.Forms.Panel panel4;
        private Syncfusion.Windows.Forms.Tools.GridLayout gridLayout1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private Syncfusion.Windows.Forms.Tools.GridLayout gridLayout3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Timer timer1;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge1;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge3;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge2;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge4;
        private Syncfusion.Windows.Forms.Gauge.Range range1;
        private Syncfusion.Windows.Forms.Gauge.Range range2;
        private Syncfusion.Windows.Forms.Gauge.Range range3;
        private Syncfusion.Windows.Forms.Gauge.Range range4;

        private Syncfusion.Windows.Forms.Gauge.Range range8;
        private Syncfusion.Windows.Forms.Gauge.Range range9;
        private Syncfusion.Windows.Forms.Gauge.Range range10;
        private Syncfusion.Windows.Forms.Gauge.Range range11;
        private Syncfusion.Windows.Forms.Gauge.Range range5;
        private Syncfusion.Windows.Forms.Gauge.Range range6;
        private Syncfusion.Windows.Forms.Gauge.Range range7;
        private System.Windows.Forms.Label label1;

        public RadialGaugeFrame()
        {
            InitializeComponent();
            this.UpdateRadialGaugeStyle();
            this.Load += Form1_Load;
            this.StartPosition = FormStartPosition.CenterScreen;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
            this.radialGauge4.DrawLabel += RadialGauge4_DrawLabel;
        }

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
            this.radialGauge1 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radialGauge3 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.radialGauge2 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.radialGauge4 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.gridLayout1 = new Syncfusion.Windows.Forms.Tools.GridLayout(this.components);
            this.gridLayout2 = new Syncfusion.Windows.Forms.Tools.GridLayout(this.components);
            this.gridLayout3 = new Syncfusion.Windows.Forms.Tools.GridLayout(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 907);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.gridLayout1.SetMinimumSize(this.panel3, new System.Drawing.Size(640, 907));
            this.panel3.Name = "panel3";
            this.gridLayout1.SetParticipateInLayout(this.panel3, true);
            this.gridLayout1.SetPreferredSize(this.panel3, new System.Drawing.Size(640, 907));
            this.panel3.Size = new System.Drawing.Size(640, 907);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.radialGauge1);
            this.panel5.Location = new System.Drawing.Point(0, 1);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.gridLayout2.SetMinimumSize(this.panel5, new System.Drawing.Size(640, 453));
            this.panel5.Name = "panel5";
            this.gridLayout2.SetParticipateInLayout(this.panel5, true);
            this.gridLayout2.SetPreferredSize(this.panel5, new System.Drawing.Size(640, 453));
            this.panel5.Size = new System.Drawing.Size(640, 453);
            this.panel5.TabIndex = 1;
            // 
            // radialGauge1
            // 
            this.radialGauge1.ArcThickness = 2F;
            this.radialGauge1.EnableCustomNeedles = false;
            this.radialGauge1.FillColor = System.Drawing.Color.DarkGray;
            this.radialGauge1.GaugeLabel = "Gauge";
            this.radialGauge1.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge1.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge1.Location = new System.Drawing.Point(97, 15);
            this.radialGauge1.MajorDifference = 30F;
            this.radialGauge1.MaximumValue = 300F;
            this.radialGauge1.MinimumSize = new System.Drawing.Size(125, 125);
            this.radialGauge1.MinimumValue = 120F;
            this.radialGauge1.MinorDifference = 5F;
            this.radialGauge1.Name = "radialGauge1";
            this.radialGauge1.ShowTicks = true;
            this.radialGauge1.Size = new System.Drawing.Size(331, 331);
            this.radialGauge1.TabIndex = 0;
            this.radialGauge1.ThemeStyle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.radialGauge3);
            this.panel4.Location = new System.Drawing.Point(0, 454);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.gridLayout2.SetMinimumSize(this.panel4, new System.Drawing.Size(640, 453));
            this.panel4.Name = "panel4";
            this.gridLayout2.SetParticipateInLayout(this.panel4, true);
            this.gridLayout2.SetPreferredSize(this.panel4, new System.Drawing.Size(640, 453));
            this.panel4.Size = new System.Drawing.Size(640, 453);
            this.panel4.TabIndex = 0;
            // 
            // radialGauge3
            // 
            this.radialGauge3.ArcThickness = 2F;
            this.radialGauge3.EnableCustomNeedles = false;
            this.radialGauge3.FillColor = System.Drawing.Color.DarkGray;
            this.radialGauge3.FrameType = Syncfusion.Windows.Forms.Gauge.FrameType.HalfCircle;
            this.radialGauge3.GaugeLabel = "Gauge";
            this.radialGauge3.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge3.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge3.Location = new System.Drawing.Point(97, 50);
            this.radialGauge3.MinimumSize = new System.Drawing.Size(130, 52);
            this.radialGauge3.Name = "radialGauge3";
            this.radialGauge3.ShowTicks = true;
            this.radialGauge3.Size = new System.Drawing.Size(262, 174);
            this.radialGauge3.StartAngle = 180;
            this.radialGauge3.SweepAngle = 180;
            this.radialGauge3.TabIndex = 1;
            this.radialGauge3.ThemeStyle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(640, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.gridLayout1.SetMinimumSize(this.panel2, new System.Drawing.Size(640, 907));
            this.panel2.Name = "panel2";
            this.gridLayout1.SetParticipateInLayout(this.panel2, true);
            this.gridLayout1.SetPreferredSize(this.panel2, new System.Drawing.Size(640, 907));
            this.panel2.Size = new System.Drawing.Size(640, 907);
            this.panel2.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Controls.Add(this.radialGauge2);
            this.panel7.Location = new System.Drawing.Point(0, 1);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.gridLayout3.SetMinimumSize(this.panel7, new System.Drawing.Size(640, 453));
            this.panel7.Name = "panel7";
            this.gridLayout3.SetParticipateInLayout(this.panel7, true);
            this.gridLayout3.SetPreferredSize(this.panel7, new System.Drawing.Size(640, 453));
            this.panel7.Size = new System.Drawing.Size(640, 453);
            this.panel7.TabIndex = 1;
            // 
            // radialGauge2
            // 
            this.radialGauge2.ArcThickness = 2F;
            this.radialGauge2.EnableCustomNeedles = false;
            this.radialGauge2.FillColor = System.Drawing.Color.DarkGray;
            this.radialGauge2.FrameType = Syncfusion.Windows.Forms.Gauge.FrameType.QuarterCircle;
            this.radialGauge2.GaugeLabel = "Gauge";
            this.radialGauge2.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge2.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge2.Location = new System.Drawing.Point(108, 66);
            this.radialGauge2.MinimumSize = new System.Drawing.Size(125, 125);
            this.radialGauge2.Name = "radialGauge2";
            this.radialGauge2.ShowTicks = true;
            this.radialGauge2.Size = new System.Drawing.Size(295, 295);
            this.radialGauge2.StartAngle = 180;
            this.radialGauge2.SweepAngle = 90;
            this.radialGauge2.TabIndex = 1;
            this.radialGauge2.ThemeStyle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.radialGauge4);
            this.panel6.Location = new System.Drawing.Point(0, 454);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.gridLayout3.SetMinimumSize(this.panel6, new System.Drawing.Size(640, 453));
            this.panel6.Name = "panel6";
            this.gridLayout3.SetParticipateInLayout(this.panel6, true);
            this.gridLayout3.SetPreferredSize(this.panel6, new System.Drawing.Size(640, 453));
            this.panel6.Size = new System.Drawing.Size(640, 453);
            this.panel6.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(286, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fill";
            // 
            // radialGauge4
            // 
            this.radialGauge4.ArcThickness = 2F;
            this.radialGauge4.EnableCustomNeedles = false;
            this.radialGauge4.FillColor = System.Drawing.Color.DarkGray;
            this.radialGauge4.FrameType = Syncfusion.Windows.Forms.Gauge.FrameType.Fill;
            this.radialGauge4.GaugeLabel = "Gauge";
            this.radialGauge4.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge4.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge4.Location = new System.Drawing.Point(125, 41);
            this.radialGauge4.MinimumSize = new System.Drawing.Size(125, 125);
            this.radialGauge4.Name = "radialGauge4";
            this.radialGauge4.ShowTicks = true;
            this.radialGauge4.Size = new System.Drawing.Size(217, 217);
            this.radialGauge4.StartAngle = 0;
            this.radialGauge4.SweepAngle = 360;
            this.radialGauge4.TabIndex = 1;
            this.radialGauge4.ThemeStyle.ArcThickness = 20F;
            this.radialGauge4.ThemeStyle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            // 
            // gridLayout1
            // 
            this.gridLayout1.Columns = 2;
            this.gridLayout1.ContainerControl = this.panel1;
            this.gridLayout1.Rows = 1;
            // 
            // gridLayout2
            // 
            this.gridLayout2.Columns = 1;
            this.gridLayout2.ContainerControl = this.panel3;
            this.gridLayout2.Rows = 2;
            // 
            // gridLayout3
            // 
            this.gridLayout3.Columns = 1;
            this.gridLayout3.ContainerControl = this.panel2;
            this.gridLayout3.Rows = 2;
            // 
            // RadialGaugeFrame
            //            
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 609);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(979, 779);
            this.MinimumSize = new System.Drawing.Size(979, 597);
            this.Name = "RadialGaugeFrame";
            this.Text = "Frame Types";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 500;
            timer1.Tick += Timer1_Tick;
            this.CenterToScreen();
        }

        int gauge4 = 0;
        int gauge2 = 5;
        int gauge1 = 120;
        int gauge3 = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (gauge4 > radialGauge4.MaximumValue)
            {
                gauge4 = 0;
            }
            else 
            {
                gauge4 = gauge4 + 5;
            }

            if (gauge2 > radialGauge2.MaximumValue)
            {
                gauge2 = 0;
            }
            else
            {
                gauge2++;
            }
            
            if (gauge3 > radialGauge3.MaximumValue)
                gauge3 = 0;
            else
            {                
                gauge3 = gauge3 + 3;
            }


            if (gauge1 > radialGauge1.MaximumValue)
                gauge1 = 120;
            else
            {
               gauge1 = gauge1+10;
            }


            radialGauge1.Value = gauge1;
            radialGauge2.Value = gauge2;
            radialGauge3.Value = gauge3;
            radialGauge4.Value = gauge4;

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

        private void UpdateRadialGaugeStyle()
        {
            #region Ranges

            range1 = new Syncfusion.Windows.Forms.Gauge.Range();
            range2 = new Syncfusion.Windows.Forms.Gauge.Range();
            range3 = new Syncfusion.Windows.Forms.Gauge.Range();
            range4 = new Syncfusion.Windows.Forms.Gauge.Range();
            range5 = new Syncfusion.Windows.Forms.Gauge.Range();
            range6 = new Syncfusion.Windows.Forms.Gauge.Range();
            range7 = new Syncfusion.Windows.Forms.Gauge.Range();
            range8 = new Syncfusion.Windows.Forms.Gauge.Range();
            range9 = new Syncfusion.Windows.Forms.Gauge.Range();
            range10 = new Syncfusion.Windows.Forms.Gauge.Range();
            range11 = new Syncfusion.Windows.Forms.Gauge.Range();

            #endregion

            #region Style of QuarterCircle

            this.radialGauge2.ThemeName = "HighContrastBlack";
            this.radialGauge2.NeedleStyle = Syncfusion.Windows.Forms.Gauge.NeedleStyle.Advanced;
            this.radialGauge2.Value = 20;
            this.radialGauge2.ThemeStyle.NeedleColor = ColorTranslator.FromHtml("#f76400");
            this.radialGauge2.ThemeStyle.ArcColor = ColorTranslator.FromHtml("#717370");
            this.radialGauge2.MajorTickMarkHeight = 15;
            this.radialGauge2.MinorTickMarkHeight = 10;
            this.radialGauge2.MinorInnerLinesHeight = 10;
            this.radialGauge2.ThemeStyle.MinorTickMarkColor = ColorTranslator.FromHtml("#FFFFFF");
            this.radialGauge2.ThemeStyle.MajorTickMarkColor = ColorTranslator.FromHtml("#FFFFFF");
            this.radialGauge2.ThemeStyle.InnerTickMarkColor = ColorTranslator.FromHtml("#FFFFFF");
            this.radialGauge2.TickPlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            this.radialGauge2.LabelPlacement = Syncfusion.Windows.Forms.Gauge.LabelPlacement.Outside;
            this.radialGauge2.MaximumValue = 20;
            this.radialGauge2.MajorDifference = 5;
            this.radialGauge2.ThemeStyle.LabelFont = new System.Drawing.Font("Segoe UI",10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge2.ThemeStyle.ValueFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge2.ThemeStyle.LabelForeColor = Color.White;
            this.radialGauge2.ThemeStyle.ScaleLabelForeColor = Color.White;
            this.radialGauge2.TextOrientation = Syncfusion.Windows.Forms.Gauge.TextOrientation.SlideOver;
            this.radialGauge2.GaugeLabel = "Quarter Circle";
            this.radialGauge2.Value = 10;
            this.radialGauge2.Size = new System.Drawing.Size(295, 295);
            #endregion

            #region Style of FillCircle

            this.radialGauge4.ThemeName = "HighContrastBlack";
            this.radialGauge4.ThemeStyle.ArcThickness = 20F;
            this.radialGauge4.EnableCustomNeedles = false;
            this.radialGauge4.FrameType = Syncfusion.Windows.Forms.Gauge.FrameType.Fill;
            this.radialGauge4.ThemeStyle.ArcColor = Color.Gray;
            this.radialGauge4.ThemeStyle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.radialGauge4.GaugeLabel = "Gauge";
            this.radialGauge4.ThemeStyle.LabelFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge4.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge4.MaximumValue = 100F;
            this.radialGauge4.MinimumSize = new System.Drawing.Size(125, 125);
            this.radialGauge4.Name = "radialGauge4";
            this.radialGauge4.ShowTicks = true;
            this.radialGauge4.StartAngle = 90;
            this.radialGauge4.SweepAngle = 360;
            this.radialGauge4.TabIndex = 0;
            this.radialGauge4.Value = 75F;
            this.radialGauge4.MaximumValue = 100;

            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new Point( this.radialGauge4.Bounds.X + (int)(this.radialGauge4.Width/2 - (2 * this.radialGauge4.ThemeStyle.ArcThickness) + this.CreateGraphics().MeasureString(this.label1.Text, this.label1.Font).Width) ,this.radialGauge4.Bounds.Bottom + (int)DpiAware.LogicalToDeviceUnits(7));

            #endregion

            #region Style of FullCircle

            this.radialGauge1.ThemeName = "HighContrastBlack";
            this.radialGauge1.ThemeStyle.ArcThickness = 0F;
            this.radialGauge1.EnableCustomNeedles = false;
            this.radialGauge1.GaugeLabel = "Full Circle";
            this.radialGauge1.ThemeStyle.LabelFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge1.ThemeStyle.ValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge1.MinimumValue = 120F;
            this.radialGauge1.MaximumValue = 300F;
            this.radialGauge1.MajorDifference = 30;
            this.radialGauge1.MinorDifference = 5;
            this.radialGauge1.MinimumSize = new System.Drawing.Size(125, 125);
            this.radialGauge1.Name = "radialGauge1";
            this.radialGauge1.ShowTicks = true;
            this.radialGauge1.StartAngle = 135;
            this.radialGauge1.SweepAngle = 270;
            this.radialGauge1.TabIndex = 0;
            this.radialGauge1.LabelPlacement = Syncfusion.Windows.Forms.Gauge.LabelPlacement.Outside;
            this.radialGauge1.TickPlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            this.radialGauge1.DrawLabel += RadialGauge1_DrawLabel;
            this.radialGauge1.ThemeStyle.ShowBackgroundFrame = false;
            this.radialGauge1.NeedleStyle = Syncfusion.Windows.Forms.Gauge.NeedleStyle.Advanced;
            this.radialGauge1.ThemeStyle.NeedleColor = ColorTranslator.FromHtml("#d5d5d5");
            this.radialGauge1.MajorTickMarkHeight = 15;
            this.radialGauge1.MinorTickMarkHeight = 8;
            this.radialGauge1.MinorInnerLinesHeight = 8;
            this.radialGauge1.ThemeStyle.MinorTickMarkColor = ColorTranslator.FromHtml("#FFFFFF");
            this.radialGauge1.ThemeStyle.MajorTickMarkColor = ColorTranslator.FromHtml("#FFFFFF");
            this.radialGauge1.ThemeStyle.InnerTickMarkColor = ColorTranslator.FromHtml("#FFFFFF");

            range4.Color = ColorTranslator.FromHtml("#dedede");
            range4.EndValue = 150;
            range4.Height = 15;
            range4.InRange = false;
            range4.Name = "GaugeRange4";
            range4.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            range4.StartValue = 120F;
            range1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            range1.EndValue = 190F;
            range1.Height = 15;
            range1.InRange = false;
            range1.Name = "GaugeRange1";
            range1.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            range1.StartValue = 150F;
            range2.Color = System.Drawing.Color.Green;
            range2.EndValue = 230F;
            range2.Height = 15;
            range2.InRange = false;
            range2.Name = "GaugeRange2";
            range2.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            range2.StartValue = 190F;
            range3.Color = System.Drawing.Color.Red;
            range3.EndValue = 300F;
            range3.Height = 15;
            range3.InRange = false;
            range3.Name = "GaugeRange3";
            range3.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            range3.StartValue = 230F;
            this.radialGauge1.ThemeStyle.LabelForeColor = Color.White;
            this.radialGauge1.ThemeStyle.LabelFont = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.radialGauge1.Ranges.Add(range1);
            this.radialGauge1.Ranges.Add(range2);
            this.radialGauge1.Ranges.Add(range3);
            this.radialGauge1.Ranges.Add(range4);
            #endregion

            #region Style of HalfCircle

            this.radialGauge3.ThemeName = "HighContrastBlack";
            this.radialGauge3.ThemeStyle.ArcThickness = 0F;
            this.radialGauge3.EnableCustomNeedles = false;
            this.radialGauge3.FrameType = Syncfusion.Windows.Forms.Gauge.FrameType.HalfCircle;
            this.radialGauge3.FillColor = System.Drawing.Color.DarkGray;
            this.radialGauge3.GaugeLabel = "Half Circle";
            this.radialGauge3.MinimumSize = new System.Drawing.Size(130, 52);
            this.radialGauge3.ShowTicks = false;
            this.radialGauge3.LabelPlacement = Syncfusion.Windows.Forms.Gauge.LabelPlacement.Inside;
            this.radialGauge3.MajorTickMarkHeight = 5;
            this.radialGauge3.Name = "radialGauge3";
            this.radialGauge3.ThemeStyle.ShowBackgroundFrame = false;
            this.radialGauge3.MaximumValue = 100;

            #region Range
            range8.Color = System.Drawing.Color.Blue;
            range8.EndValue = 20F;
            range8.Height = 15;
            range8.InRange = false;
            range8.Name = "GaugeRange8";
            range8.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range8.StartValue = 0F;
            range9.Color = System.Drawing.Color.Blue;
            range9.EndValue = 40F;
            range9.Height = 15;
            range9.InRange = false;
            range9.Name = "GaugeRange9";
            range9.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range9.StartValue = 21F;
            range10.Color = Color.Blue;
            range10.EndValue = 51F;
            range10.Height = 15;
            range10.InRange = false;
            range10.Name = "GaugeRange10";
            range10.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range10.StartValue = 41F;
            range11.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            range11.EndValue = 60F;
            range11.Height = 15;
            range11.InRange = false;
            range11.Name = "GaugeRange11";
            range11.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range11.StartValue = 51F;
            range5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            range5.EndValue = 80F;
            range5.Height = 15;
            range5.InRange = false;
            range5.Name = "GaugeRange4";
            range5.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range5.StartValue = 61F;
            range6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            range6.EndValue = 100F;
            range6.Height = 15;
            range6.InRange = false;
            range6.Name = "GaugeRange6";
            range6.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range6.StartValue = 81F;

            #endregion

            this.radialGauge3.Ranges.Add(range8);
            this.radialGauge3.Ranges.Add(range9);
            this.radialGauge3.Ranges.Add(range10);
            this.radialGauge3.Ranges.Add(range11);
            this.radialGauge3.Ranges.Add(range5);
            this.radialGauge3.Ranges.Add(range6);
            this.radialGauge3.Size = new System.Drawing.Size(350, 350);
            this.radialGauge3.StartAngle = 180;
            this.radialGauge3.SweepAngle = 180;
            this.radialGauge3.TabIndex = 1;
            this.radialGauge3.ThemeStyle.LabelFont = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge3.NeedleStyle = Syncfusion.Windows.Forms.Gauge.NeedleStyle.Advanced;            
            this.radialGauge3.ThemeStyle.NeedleColor = Color.White;
            this.radialGauge3.ThemeStyle.ValueFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge3.Value = 50;

            #endregion
        }

        private void RadialGauge1_DrawLabel(object sender, Syncfusion.Windows.Forms.Gauge.DrawLabelEventArgs e)
        {
            e.Handled = true;
            if (e.LabelType == Syncfusion.Windows.Forms.Gauge.LabelType.Scale)
                e.Text += " °C";
            e.LabelAlignment = Syncfusion.Windows.Forms.Gauge.LabelAlignment.Default;
            e.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));           
        }

        private void RadialGauge4_DrawLabel(object sender, Syncfusion.Windows.Forms.Gauge.DrawLabelEventArgs e)
        {
            e.Handled = true;
            e.Text += " %";
            e.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

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
