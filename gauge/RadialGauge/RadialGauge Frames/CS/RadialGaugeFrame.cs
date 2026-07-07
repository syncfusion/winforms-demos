#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
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
        private Syncfusion.Windows.Forms.Tools.GridLayout gridLayout2;
        private Syncfusion.Windows.Forms.Tools.GridLayout gridLayout1;
        private Syncfusion.Windows.Forms.Tools.GridLayout gridLayout3;
        private System.Windows.Forms.Timer timer1;
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
        private TableLayoutPanel tableLayoutPanel1;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge2;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge3;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge4;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge1;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Syncfusion.Windows.Forms.Gauge.Range range7;

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
            this.gridLayout1 = new Syncfusion.Windows.Forms.Tools.GridLayout(this.components);
            this.gridLayout2 = new Syncfusion.Windows.Forms.Tools.GridLayout(this.components);
            this.gridLayout3 = new Syncfusion.Windows.Forms.Tools.GridLayout(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.radialGauge4 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.radialGauge3 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.radialGauge2 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radialGauge1 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout3)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridLayout1
            // 
            this.gridLayout1.Columns = 2;
            this.gridLayout1.Rows = 1;
            // 
            // gridLayout2
            // 
            this.gridLayout2.Columns = 1;
            this.gridLayout2.Rows = 2;
            // 
            // gridLayout3
            // 
            this.gridLayout3.Columns = 1;
            this.gridLayout3.Rows = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-6, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(973, 605);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Controls.Add(this.radialGauge4);
            this.flowLayoutPanel4.Controls.Add(this.label1);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(638, 305);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(183, 297);
            this.flowLayoutPanel4.TabIndex = 4;
            // 
            // radialGauge4
            // 
            this.radialGauge4.ArcThickness = 2F;
            this.radialGauge4.EnableCustomNeedles = false;
            this.radialGauge4.FillColor = System.Drawing.Color.DarkGray;
            this.radialGauge4.FrameThickness = 20;
            this.radialGauge4.FrameType = Syncfusion.Windows.Forms.Gauge.FrameType.Fill;
            this.radialGauge4.GaugeLabel = "Gauge";
            this.radialGauge4.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge4.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge4.Location = new System.Drawing.Point(3, 3);
            this.radialGauge4.MinimumSize = new System.Drawing.Size(125, 125);
            this.radialGauge4.Name = "radialGauge4";
            this.radialGauge4.ShowTicks = true;
            this.radialGauge4.Size = new System.Drawing.Size(177, 177);
            this.radialGauge4.StartAngle = 0;
            this.radialGauge4.SweepAngle = 360;
            this.radialGauge4.TabIndex = 1;
            this.radialGauge4.ThemeStyle.ArcThickness = 20F;
            this.radialGauge4.ThemeStyle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fill";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.radialGauge3);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(134, 305);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(218, 297);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // radialGauge3
            // 
            this.radialGauge3.ArcThickness = 2F;
            this.radialGauge3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radialGauge3.EnableCustomNeedles = false;
            this.radialGauge3.FillColor = System.Drawing.Color.DarkGray;
            this.radialGauge3.FrameThickness = 12;
            this.radialGauge3.FrameType = Syncfusion.Windows.Forms.Gauge.FrameType.HalfCircle;
            this.radialGauge3.GaugeLabel = "Gauge";
            this.radialGauge3.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge3.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge3.Location = new System.Drawing.Point(3, 3);
            this.radialGauge3.MaximumSize = new System.Drawing.Size(262, 174);
            this.radialGauge3.MinimumSize = new System.Drawing.Size(130, 52);
            this.radialGauge3.Name = "radialGauge3";
            this.radialGauge3.ShowTicks = true;
            this.radialGauge3.Size = new System.Drawing.Size(212, 140);
            this.radialGauge3.StartAngle = 180;
            this.radialGauge3.SweepAngle = 180;
            this.radialGauge3.TabIndex = 1;
            this.radialGauge3.ThemeStyle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.radialGauge2);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(621, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(216, 296);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // radialGauge2
            // 
            this.radialGauge2.ArcThickness = 5F;
            this.radialGauge2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radialGauge2.EnableCustomNeedles = false;
            this.radialGauge2.FillColor = System.Drawing.Color.DarkGray;
            this.radialGauge2.FrameThickness = 12;
            this.radialGauge2.FrameType = Syncfusion.Windows.Forms.Gauge.FrameType.QuarterCircle;
            this.radialGauge2.GaugeLabel = "Gauge";
            this.radialGauge2.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge2.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge2.Location = new System.Drawing.Point(3, 42);
            this.radialGauge2.MajorTickMarkHeight = 0;
            this.radialGauge2.MinimumSize = new System.Drawing.Size(125, 125);
            this.radialGauge2.MinorInnerLinesHeight = 0;
            this.radialGauge2.MinorTickMarkHeight = 0;
            this.radialGauge2.Name = "radialGauge2";
            this.radialGauge2.ShowTicks = true;
            this.radialGauge2.Size = new System.Drawing.Size(210, 210);
            this.radialGauge2.StartAngle = 180;
            this.radialGauge2.SweepAngle = 90;
            this.radialGauge2.TabIndex = 1;
            this.radialGauge2.ThemeStyle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.radialGauge1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(112, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(262, 296);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // radialGauge1
            // 
            this.radialGauge1.ArcThickness = 2F;
            this.radialGauge1.EnableCustomNeedles = false;
            this.radialGauge1.FillColor = System.Drawing.Color.DarkGray;
            this.radialGauge1.FrameThickness = 12;
            this.radialGauge1.GaugeLabel = "Gauge";
            this.radialGauge1.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge1.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge1.Location = new System.Drawing.Point(3, 16);
            this.radialGauge1.MajorDifference = 30F;
            this.radialGauge1.MaximumSize = new System.Drawing.Size(331, 331);
            this.radialGauge1.MaximumValue = 300F;
            this.radialGauge1.MinimumSize = new System.Drawing.Size(125, 125);
            this.radialGauge1.MinimumValue = 120F;
            this.radialGauge1.MinorDifference = 5F;
            this.radialGauge1.Name = "radialGauge1";
            this.radialGauge1.ShowTicks = true;
            this.radialGauge1.Size = new System.Drawing.Size(256, 256);
            this.radialGauge1.TabIndex = 0;
            this.radialGauge1.ThemeStyle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.MinimumSize = new System.Drawing.Size(210, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label22131212312312312312312312";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.MinimumSize = new System.Drawing.Size(210, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "label5";
            // 
            // RadialGaugeFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 609);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(979, 779);
            this.MinimumSize = new System.Drawing.Size(979, 597);
            this.Name = "RadialGaugeFrame";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Frame Types";
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout3)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
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
