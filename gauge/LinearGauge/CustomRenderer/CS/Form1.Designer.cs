#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

namespace CustomRenderer_2008
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
            Syncfusion.Windows.Forms.Gauge.LinearRange linearRange4 = new Syncfusion.Windows.Forms.Gauge.LinearRange();
            Syncfusion.Windows.Forms.Gauge.LinearRange linearRange5 = new Syncfusion.Windows.Forms.Gauge.LinearRange();
            Syncfusion.Windows.Forms.Gauge.LinearRange linearRange6 = new Syncfusion.Windows.Forms.Gauge.LinearRange();
            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.linearGauge3 = new Syncfusion.Windows.Forms.Gauge.LinearGauge();
            this.linearGauge2 = new Syncfusion.Windows.Forms.Gauge.LinearGauge();
            this.linearGauge1 = new Syncfusion.Windows.Forms.Gauge.LinearGauge();
            this.trackBarEx1 = new Syncfusion.Windows.Forms.Tools.TrackBarEx(0, 10);
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.BeforeTouchSize = 1;
            this.splitContainerAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAdv1.HotGripLight = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.WindowFrame);
            this.splitContainerAdv1.IsSplitterFixed = true;
            this.splitContainerAdv1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.Controls.Add(this.label3);
            this.splitContainerAdv1.Panel1.Controls.Add(this.linearGauge3);
            this.splitContainerAdv1.Panel1.Controls.Add(this.linearGauge2);
            this.splitContainerAdv1.Panel1.Controls.Add(this.linearGauge1);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.Controls.Add(this.trackBarEx1);
            this.splitContainerAdv1.Panel2.Controls.Add(this.comboBoxAdv1);
            this.splitContainerAdv1.Panel2.Controls.Add(this.label2);
            this.splitContainerAdv1.Panel2.Controls.Add(this.label1);
            this.splitContainerAdv1.Size = new System.Drawing.Size(912, 534);
            this.splitContainerAdv1.SplitterDistance = 650;
            this.splitContainerAdv1.SplitterWidth = 1;
            this.splitContainerAdv1.TabIndex = 0;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pointer Value";
            // 
            // linearGauge3
            // 
            this.linearGauge3.BackgroundGradientEndColor = System.Drawing.Color.White;
            this.linearGauge3.BackgroundGradientStartColor = System.Drawing.Color.White;
            this.linearGauge3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linearGauge3.ForeColor = System.Drawing.Color.Gray;
            this.linearGauge3.GaugeBaseColor = System.Drawing.Color.White;
            this.linearGauge3.GaugelabelFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linearGauge3.InnerFrameGradientEndColor = System.Drawing.Color.White;
            this.linearGauge3.InnerFrameGradientStartColor = System.Drawing.Color.White;
            this.linearGauge3.LinearFrameType = Syncfusion.Windows.Forms.Gauge.LinearFrameType.Vertical;
            this.linearGauge3.Location = new System.Drawing.Point(62, 24);
            this.linearGauge3.MajorDifference = 10;
            this.linearGauge3.MajorTicksHeight = 15;
            this.linearGauge3.MaximumValue = 100F;
            this.linearGauge3.MinimumSize = new System.Drawing.Size(75, 125);
            this.linearGauge3.MinorTickCount = 0;
            this.linearGauge3.MinorTickHeight = 0;
            this.linearGauge3.Name = "linearGauge3";
            this.linearGauge3.OuterFrameGradientEndColor = System.Drawing.Color.White;
            this.linearGauge3.OuterFrameGradientStartColor = System.Drawing.Color.White;
            this.linearGauge3.PointerPlacement = Syncfusion.Windows.Forms.Gauge.Placement.Center;
            linearRange1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(181)))), ((int)(((byte)(63)))));
            linearRange1.EndValue = 50F;
            linearRange1.Height = 5;
            linearRange1.InRange = true;
            linearRange1.Name = "GaugeRange1";
            linearRange1.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            linearRange1.StartValue = 0F;
            linearRange2.Color = System.Drawing.Color.White;
            linearRange2.EndValue = 70F;
            linearRange2.Height = 5;
            linearRange2.InRange = false;
            linearRange2.Name = "GaugeRange2";
            linearRange2.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            linearRange2.StartValue = 50F;
            linearRange3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            linearRange3.EndValue = 100F;
            linearRange3.Height = 5;
            linearRange3.InRange = false;
            linearRange3.Name = "GaugeRange3";
            linearRange3.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            linearRange3.StartValue = 70F;
            this.linearGauge3.Ranges.Add(linearRange1);
            this.linearGauge3.Ranges.Add(linearRange2);
            this.linearGauge3.Ranges.Add(linearRange3);
            this.linearGauge3.Size = new System.Drawing.Size(125, 460);
            this.linearGauge3.TabIndex = 2;
            this.linearGauge3.Text = "linearGauge3";
            this.linearGauge3.Value = 15F;
            this.linearGauge3.ValueIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(170)))), ((int)(((byte)(176)))));
            // 
            // linearGauge2
            // 
            this.linearGauge2.BackgroundGradientEndColor = System.Drawing.Color.White;
            this.linearGauge2.BackgroundGradientStartColor = System.Drawing.Color.White;
            this.linearGauge2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linearGauge2.ForeColor = System.Drawing.Color.Gray;
            this.linearGauge2.GaugelabelFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linearGauge2.InnerFrameGradientEndColor = System.Drawing.Color.White;
            this.linearGauge2.InnerFrameGradientStartColor = System.Drawing.Color.White;
            this.linearGauge2.LinearFrameType = Syncfusion.Windows.Forms.Gauge.LinearFrameType.Vertical;
            this.linearGauge2.Location = new System.Drawing.Point(410, 24);
            this.linearGauge2.MajorDifference = 10;
            this.linearGauge2.MajorTicksHeight = 15;
            this.linearGauge2.MaximumValue = 30F;
            this.linearGauge2.MinimumSize = new System.Drawing.Size(75, 125);
            this.linearGauge2.MinorTickCount = 4;
            this.linearGauge2.MinorTickHeight = 7;
            this.linearGauge2.Name = "linearGauge2";
            this.linearGauge2.OuterFrameGradientEndColor = System.Drawing.Color.White;
            this.linearGauge2.OuterFrameGradientStartColor = System.Drawing.Color.White;
            this.linearGauge2.PointerPlacement = Syncfusion.Windows.Forms.Gauge.Placement.Center;
            linearRange4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            linearRange4.EndValue = 30F;
            linearRange4.Height = 5;
            linearRange4.InRange = true;
            linearRange4.Name = "GaugeRange1";
            linearRange4.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            linearRange4.StartValue = 0F;
            this.linearGauge2.Ranges.Add(linearRange4);
            this.linearGauge2.Size = new System.Drawing.Size(125, 425);
            this.linearGauge2.TabIndex = 1;
            this.linearGauge2.Text = "linearGauge2";
            this.linearGauge2.Value = 15F;
            this.linearGauge2.ValueIndicatorColor = System.Drawing.Color.White;
            // 
            // linearGauge1
            // 
            this.linearGauge1.BackgroundGradientEndColor = System.Drawing.Color.White;
            this.linearGauge1.BackgroundGradientStartColor = System.Drawing.Color.White;
            this.linearGauge1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linearGauge1.ForeColor = System.Drawing.Color.Gray;
            this.linearGauge1.GaugelabelFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linearGauge1.InnerFrameGradientEndColor = System.Drawing.Color.White;
            this.linearGauge1.InnerFrameGradientStartColor = System.Drawing.Color.White;
            this.linearGauge1.LinearFrameType = Syncfusion.Windows.Forms.Gauge.LinearFrameType.Vertical;
            this.linearGauge1.Location = new System.Drawing.Point(263, 24);
            this.linearGauge1.MajorDifference = 10;
            this.linearGauge1.MajorTicksHeight = 15;
            this.linearGauge1.MaximumValue = 50F;
            this.linearGauge1.MinimumSize = new System.Drawing.Size(75, 125);
            this.linearGauge1.MinorTickCount = 4;
            this.linearGauge1.MinorTickHeight = 7;
            this.linearGauge1.Name = "linearGauge1";
            this.linearGauge1.OuterFrameGradientEndColor = System.Drawing.Color.White;
            this.linearGauge1.OuterFrameGradientStartColor = System.Drawing.Color.White;
            this.linearGauge1.PointerPlacement = Syncfusion.Windows.Forms.Gauge.Placement.Center;
            linearRange5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            linearRange5.EndValue = 30F;
            linearRange5.Height = 5;
            linearRange5.InRange = true;
            linearRange5.Name = "GaugeRange1";
            linearRange5.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            linearRange5.StartValue = 0F;
            linearRange6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            linearRange6.EndValue = 50F;
            linearRange6.Height = 5;
            linearRange6.InRange = false;
            linearRange6.Name = "GaugeRange2";
            linearRange6.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            linearRange6.StartValue = 30F;
            this.linearGauge1.Ranges.Add(linearRange5);
            this.linearGauge1.Ranges.Add(linearRange6);
            this.linearGauge1.Size = new System.Drawing.Size(125, 460);
            this.linearGauge1.TabIndex = 0;
            this.linearGauge1.Text = "linearGauge1";
            this.linearGauge1.Value = 15F;
            this.linearGauge1.ValueIndicatorColor = System.Drawing.Color.White;
            // 
            // trackBarEx1
            // 
            this.trackBarEx1.BackColor = System.Drawing.Color.White;
            this.trackBarEx1.BeforeTouchSize = new System.Drawing.Size(224, 20);
            this.trackBarEx1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackBarEx1.Location = new System.Drawing.Point(19, 372);
            this.trackBarEx1.Name = "trackBarEx1";
            this.trackBarEx1.Size = new System.Drawing.Size(224, 20);
            this.trackBarEx1.Style = Syncfusion.Windows.Forms.Tools.TrackBarEx.Theme.Metro;
            this.trackBarEx1.TabIndex = 3;
            this.trackBarEx1.Text = "trackBarEx1";
            this.trackBarEx1.TimerInterval = 100;
            this.trackBarEx1.Value = 5;
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(224, 29);
            this.comboBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Ball Pointer",
            "Thermometer",
            "Custom Ranges"});
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Ball Pointer"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Thermometer"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Custom Ranges"));
            this.comboBoxAdv1.Location = new System.Drawing.Point(19, 207);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(224, 29);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.TabIndex = 2;
            this.comboBoxAdv1.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pointer Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appearance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            captionImage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            captionImage1.Location = new System.Drawing.Point(5, 22);
            captionImage1.Name = "CaptionImage1";
            this.ClientSize = new System.Drawing.Size(912, 534);
            this.Controls.Add(this.splitContainerAdv1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Renderer";
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel1.PerformLayout();
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.SplitContainerAdv splitContainerAdv1;
        private Syncfusion.Windows.Forms.Gauge.LinearGauge linearGauge1;
        private Syncfusion.Windows.Forms.Gauge.LinearGauge linearGauge3;
        private Syncfusion.Windows.Forms.Gauge.LinearGauge linearGauge2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.TrackBarEx trackBarEx1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
        private System.Windows.Forms.Label label3;
    }
}

