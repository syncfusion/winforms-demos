#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Drawing;

namespace GaugeTheme_2010
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
            Syncfusion.Windows.Forms.Gauge.LinearRange linearRange1 = new Syncfusion.Windows.Forms.Gauge.LinearRange();
            Syncfusion.Windows.Forms.Gauge.LinearRange linearRange2 = new Syncfusion.Windows.Forms.Gauge.LinearRange();
            Syncfusion.Windows.Forms.Gauge.LinearRange linearRange3 = new Syncfusion.Windows.Forms.Gauge.LinearRange();
            Syncfusion.Windows.Forms.Gauge.Range range1 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range2 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range3 = new Syncfusion.Windows.Forms.Gauge.Range();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LinearDigitalBasePanel = new System.Windows.Forms.Panel();
            this.DigitalGaugePanel = new System.Windows.Forms.Panel();
            this.digitalGauge1 = new Syncfusion.Windows.Forms.Gauge.DigitalGauge();
            this.LinearGaugePanel = new System.Windows.Forms.Panel();
            this.linearGauge1 = new Syncfusion.Windows.Forms.Gauge.LinearGauge();
            this.RadialGaugePanel = new System.Windows.Forms.Panel();
            this.radialGauge1 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            this.panel2.SuspendLayout();
            this.LinearDigitalBasePanel.SuspendLayout();
            this.DigitalGaugePanel.SuspendLayout();
            this.LinearGaugePanel.SuspendLayout();
            this.RadialGaugePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.comboBoxAdv1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 46);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(201, 25);
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Office2019Colorful",
            "HighContrastBlack",
            "Office2016Colorful",
            "Office2016DarkGray",
            "Office2016White",
            "Office2016Black",
            "Metro",
            "Blue",
            "Silver",
            "Custom"});
            this.comboBoxAdv1.Location = new System.Drawing.Point(999, 10);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(201, 25);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.TabIndex = 7;
            this.comboBoxAdv1.Text = "Office2019Colorful";
            this.comboBoxAdv1.ThemeName = "Metro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.label1.Location = new System.Drawing.Point(895, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Switch Theme:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.LinearDigitalBasePanel);
            this.panel2.Controls.Add(this.RadialGaugePanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 48);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(30, 25, 25, 25);
            this.panel2.Size = new System.Drawing.Size(980, 511);
            this.panel2.TabIndex = 4;
            this.panel2.SizeChanged += new System.EventHandler(this.panel2_SizeChanged);
            // 
            // LinearDigitalBasePanel
            // 
            this.LinearDigitalBasePanel.BackColor = System.Drawing.Color.Transparent;
            this.LinearDigitalBasePanel.Controls.Add(this.DigitalGaugePanel);
            this.LinearDigitalBasePanel.Controls.Add(this.LinearGaugePanel);
            this.LinearDigitalBasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LinearDigitalBasePanel.Location = new System.Drawing.Point(434, 25);
            this.LinearDigitalBasePanel.Name = "LinearDigitalBasePanel";
            this.LinearDigitalBasePanel.Size = new System.Drawing.Size(521, 461);
            this.LinearDigitalBasePanel.TabIndex = 1;
            this.LinearDigitalBasePanel.SizeChanged += new System.EventHandler(this.LinearDigitalBasePanel_SizeChanged);
            // 
            // DigitalGaugePanel
            // 
            this.DigitalGaugePanel.BackColor = System.Drawing.Color.Transparent;
            this.DigitalGaugePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DigitalGaugePanel.Controls.Add(this.digitalGauge1);
            this.DigitalGaugePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DigitalGaugePanel.Location = new System.Drawing.Point(0, 295);
            this.DigitalGaugePanel.Name = "DigitalGaugePanel";
            this.DigitalGaugePanel.Size = new System.Drawing.Size(521, 166);
            this.DigitalGaugePanel.TabIndex = 1;
            // 
            // digitalGauge1
            // 
            this.digitalGauge1.DisplayRecordIndex = 0;
            this.digitalGauge1.Location = new System.Drawing.Point(120, 58);
            this.digitalGauge1.MaximumSize = new System.Drawing.Size(500, 180);
            this.digitalGauge1.MinimumSize = new System.Drawing.Size(90, 90);
            this.digitalGauge1.Name = "digitalGauge1";
            this.digitalGauge1.Size = new System.Drawing.Size(288, 104);
            this.digitalGauge1.TabIndex = 0;
            this.digitalGauge1.Value = "12345";
            // 
            // LinearGaugePanel
            // 
            this.LinearGaugePanel.BackColor = System.Drawing.Color.Transparent;
            this.LinearGaugePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LinearGaugePanel.Controls.Add(this.linearGauge1);
            this.LinearGaugePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LinearGaugePanel.Location = new System.Drawing.Point(0, 0);
            this.LinearGaugePanel.Name = "LinearGaugePanel";
            this.LinearGaugePanel.Size = new System.Drawing.Size(521, 295);
            this.LinearGaugePanel.TabIndex = 0;
            // 
            // linearGauge1
            // 
            this.linearGauge1.ForeColor = System.Drawing.Color.Gray;
            this.linearGauge1.GaugelabelFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linearGauge1.LinearFrameType = Syncfusion.Windows.Forms.Gauge.LinearFrameType.Horizontal;
            this.linearGauge1.Location = new System.Drawing.Point(108, 90);
            this.linearGauge1.MajorTicksHeight = 15;
            this.linearGauge1.MinimumSize = new System.Drawing.Size(75, 125);
            this.linearGauge1.MinorTickCount = 5;
            this.linearGauge1.MinorTickHeight = 10;
            this.linearGauge1.Name = "linearGauge1";
            this.linearGauge1.PointerPlacement = Syncfusion.Windows.Forms.Gauge.Placement.Center;
            linearRange1.Color = System.Drawing.Color.Red;
            linearRange1.EndValue = 40F;
            linearRange1.Height = 5;
            linearRange1.InRange = false;
            linearRange1.Name = "GaugeRange1";
            linearRange1.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            linearRange1.StartValue = 0F;
            linearRange2.Color = System.Drawing.Color.Yellow;
            linearRange2.EndValue = 80F;
            linearRange2.Height = 5;
            linearRange2.InRange = true;
            linearRange2.Name = "GaugeRange2";
            linearRange2.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            linearRange2.StartValue = 40F;
            linearRange3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            linearRange3.EndValue = 120F;
            linearRange3.Height = 5;
            linearRange3.InRange = false;
            linearRange3.Name = "GaugeRange3";
            linearRange3.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            linearRange3.StartValue = 80F;
            this.linearGauge1.Ranges.Add(linearRange1);
            this.linearGauge1.Ranges.Add(linearRange2);
            this.linearGauge1.Ranges.Add(linearRange3);
            this.linearGauge1.ScaleColor = System.Drawing.Color.Gray;
            this.linearGauge1.Size = new System.Drawing.Size(300, 125);
            this.linearGauge1.TabIndex = 0;
            this.linearGauge1.Text = "linearGauge1";
            this.linearGauge1.Value = 30F;
            this.linearGauge1.ValueIndicatorColor = System.Drawing.Color.Gray;
            // 
            // RadialGaugePanel
            // 
            this.RadialGaugePanel.BackColor = System.Drawing.Color.Transparent;
            this.RadialGaugePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RadialGaugePanel.Controls.Add(this.radialGauge1);
            this.RadialGaugePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.RadialGaugePanel.ForeColor = System.Drawing.Color.Transparent;
            this.RadialGaugePanel.Location = new System.Drawing.Point(30, 25);
            this.RadialGaugePanel.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.RadialGaugePanel.Name = "RadialGaugePanel";
            this.RadialGaugePanel.Size = new System.Drawing.Size(404, 461);
            this.RadialGaugePanel.TabIndex = 0;
            // 
            // radialGauge1
            // 
            this.radialGauge1.ArcThickness = 2F;
            this.radialGauge1.EnableCustomNeedles = false;
            this.radialGauge1.FillColor = System.Drawing.Color.DarkGray;
            this.radialGauge1.GaugeLabel = "Gauge";
            this.radialGauge1.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge1.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge1.LabelPlacement = Syncfusion.Windows.Forms.Gauge.LabelPlacement.Outside;
            this.radialGauge1.Location = new System.Drawing.Point(44, 90);
            this.radialGauge1.MinimumSize = new System.Drawing.Size(125, 125);
            this.radialGauge1.MinorDifference = 10F;
            this.radialGauge1.Name = "radialGauge1";
            range1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            range1.EndValue = 40F;
            range1.Height = 5;
            range1.InRange = true;
            range1.Name = "GaugeRange1";
            range1.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            range1.StartValue = 0F;
            range2.Color = System.Drawing.Color.Yellow;
            range2.EndValue = 80F;
            range2.Height = 5;
            range2.InRange = true;
            range2.Name = "GaugeRange2";
            range2.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            range2.StartValue = 40F;
            range3.Color = System.Drawing.Color.Red;
            range3.EndValue = 120F;
            range3.Height = 5;
            range3.InRange = false;
            range3.Name = "GaugeRange3";
            range3.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            range3.StartValue = 80F;
            this.radialGauge1.Ranges.Add(range1);
            this.radialGauge1.Ranges.Add(range2);
            this.radialGauge1.Ranges.Add(range3);
            this.radialGauge1.ShowTicks = true;
            this.radialGauge1.Size = new System.Drawing.Size(317, 317);
            this.radialGauge1.TabIndex = 0;
            this.radialGauge1.TextOrientation = Syncfusion.Windows.Forms.Gauge.TextOrientation.SlideOver;
            this.radialGauge1.Value = 40F;
            // 
            // Form1
            // 
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Gauge Theme ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.LinearDigitalBasePanel.ResumeLayout(false);
            this.DigitalGaugePanel.ResumeLayout(false);
            this.LinearGaugePanel.ResumeLayout(false);
            this.RadialGaugePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Panel LinearDigitalBasePanel;
        internal System.Windows.Forms.Panel DigitalGaugePanel;
        internal Syncfusion.Windows.Forms.Gauge.DigitalGauge digitalGauge1;
        internal System.Windows.Forms.Panel LinearGaugePanel;
        internal Syncfusion.Windows.Forms.Gauge.LinearGauge linearGauge1;
        internal System.Windows.Forms.Panel RadialGaugePanel;
        internal Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge1;
    }
}

