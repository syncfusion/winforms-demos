using System.Drawing;
namespace GaugeDemo
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
            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radialGauge1 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radialGauge1
            // 
            this.radialGauge1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radialGauge1.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.radialGauge1.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.radialGauge1.EnableCustomNeedles = false;
            this.radialGauge1.ForeColor = System.Drawing.Color.Black;
            this.radialGauge1.FrameType = Syncfusion.Windows.Forms.Gauge.FrameType.HalfCircle;
            this.radialGauge1.GaugeArcColor = System.Drawing.Color.White;
            this.radialGauge1.GaugeLabel = "";
            this.radialGauge1.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge1.GaugeValueColor = System.Drawing.SystemColors.HotTrack;
            this.radialGauge1.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge1.InnerFrameGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.radialGauge1.InnerFrameGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.radialGauge1.InterLinesColor = System.Drawing.Color.White;
            this.radialGauge1.Location = new System.Drawing.Point(26, 3);
            this.radialGauge1.MajorDifference = 120F;
            this.radialGauge1.MajorTickMarkColor = System.Drawing.Color.White;
            this.radialGauge1.MinimumSize = new System.Drawing.Size(230, 152);
            this.radialGauge1.MinorTickMarkColor = System.Drawing.Color.White;
            this.radialGauge1.Name = "radialGauge1";
            this.radialGauge1.NeedleColor = System.Drawing.Color.White;
            this.radialGauge1.OuterFrameGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.radialGauge1.OuterFrameGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            range1.Color = System.Drawing.SystemColors.MenuHighlight;
            range1.EndValue = 90F;
            range1.Height = 70;
            range1.InRange = false;
            range1.Name = "BlueColor";
            range1.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range1.StartValue = 1F;
            range2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            range2.EndValue = 119F;
            range2.Height = 70;
            range2.InRange = false;
            range2.Name = "GrayColor";
            range2.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range2.StartValue = 85F;
            this.radialGauge1.Ranges.Add(range1);
            this.radialGauge1.Ranges.Add(range2);
            this.radialGauge1.ScaleLabelColor = System.Drawing.Color.White;
            this.radialGauge1.ShowBackgroundFrame = false;
            this.radialGauge1.ShowNeedle = false;
            this.radialGauge1.ShowScaleLabel = false;
            this.radialGauge1.Size = new System.Drawing.Size(403, 268);
            this.radialGauge1.TabIndex = 0;
            this.radialGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Black;
            this.radialGauge1.Click += new System.EventHandler(this.radialGauge1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(449, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "120M";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(744, 356);
            this.trackBar1.Maximum = 120;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(143, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "0M";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(252, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "$50,360";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(81)))));
            this.label3.Location = new System.Drawing.Point(280, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "$50,360";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.radialGauge1);
            this.panel1.Location = new System.Drawing.Point(77, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 300);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(338, 198);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(102, 10);
            this.panel3.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(25, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 10);
            this.panel2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarHeight = 46;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            captionImage1.Image = global::GaugeDemo.Properties.Resources.captionimage;
            captionImage1.Location = new System.Drawing.Point(0, 0);
            captionImage1.Name = "CaptionImage1";
            captionImage1.Size = new System.Drawing.Size(30, 52);
            this.CaptionImages.Add(captionImage1);
            this.ClientSize = new System.Drawing.Size(644, 390);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HalfCircleGauge";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;

    }
}

