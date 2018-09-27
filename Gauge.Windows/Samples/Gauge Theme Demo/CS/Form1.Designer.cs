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
            this.panel11 = new System.Windows.Forms.Panel();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.LinearDigitalBasePanel = new System.Windows.Forms.Panel();
            this.DigitalGaugePanel = new System.Windows.Forms.Panel();
            this.digitalGauge1 = new Syncfusion.Windows.Forms.Gauge.DigitalGauge();
            this.LinearGaugePanel = new System.Windows.Forms.Panel();
            this.linearGauge1 = new Syncfusion.Windows.Forms.Gauge.LinearGauge();
            this.RadialGaugePanel = new System.Windows.Forms.Panel();
            this.radialGauge1 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.LinearDigitalBasePanel.SuspendLayout();
            this.DigitalGaugePanel.SuspendLayout();
            this.LinearGaugePanel.SuspendLayout();
            this.RadialGaugePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1229, 46);
            this.panel1.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.comboBoxAdv1);
            this.panel11.Controls.Add(this.label2);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(833, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(396, 46);
            this.panel11.TabIndex = 2;
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(201, 25);
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Office2016Colorful",
            "Office2016DarkGray",
            "Office2016White",
            "Office2016Black",
            "Metro",
            "Blue",
            "Black",
            "Silver",
            "Custom"});
            this.comboBoxAdv1.Location = new System.Drawing.Point(183, 12);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(201, 25);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.TabIndex = 3;
            this.comboBoxAdv1.Text = "Office2016Colorful";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.label2.Location = new System.Drawing.Point(79, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Switch Theme:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(356, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 46);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 46);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personalize";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1229, 2);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.flowLayoutPanel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 48);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(356, 552);
            this.panel5.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3, 10, 10, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(356, 552);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(356, 48);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(2, 552);
            this.panel6.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(2, 552);
            this.panel7.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(358, 48);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(30, 25, 25, 25);
            this.panel8.Size = new System.Drawing.Size(871, 552);
            this.panel8.TabIndex = 4;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(30, 25);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(2);
            this.panel9.Size = new System.Drawing.Size(816, 502);
            this.panel9.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Controls.Add(this.LinearDigitalBasePanel);
            this.panel10.Controls.Add(this.RadialGaugePanel);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(2, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(812, 498);
            this.panel10.TabIndex = 0;
            this.panel10.SizeChanged += new System.EventHandler(this.panel10_SizeChanged);
            // 
            // LinearDigitalBasePanel
            // 
            this.LinearDigitalBasePanel.BackColor = System.Drawing.Color.Gray;
            this.LinearDigitalBasePanel.Controls.Add(this.DigitalGaugePanel);
            this.LinearDigitalBasePanel.Controls.Add(this.LinearGaugePanel);
            this.LinearDigitalBasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LinearDigitalBasePanel.Location = new System.Drawing.Point(404, 0);
            this.LinearDigitalBasePanel.Name = "LinearDigitalBasePanel";
            this.LinearDigitalBasePanel.Size = new System.Drawing.Size(408, 498);
            this.LinearDigitalBasePanel.TabIndex = 1;
            this.LinearDigitalBasePanel.SizeChanged += new System.EventHandler(this.LinearDigitalBasePanel_SizeChanged);
            // 
            // DigitalGaugePanel
            // 
            this.DigitalGaugePanel.BackColor = System.Drawing.Color.White;
            this.DigitalGaugePanel.Controls.Add(this.label5);
            this.DigitalGaugePanel.Controls.Add(this.digitalGauge1);
            this.DigitalGaugePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DigitalGaugePanel.Location = new System.Drawing.Point(0, 295);
            this.DigitalGaugePanel.Name = "DigitalGaugePanel";
            this.DigitalGaugePanel.Size = new System.Drawing.Size(408, 203);
            this.DigitalGaugePanel.TabIndex = 1;
            // 
            // digitalGauge1
            // 
            this.digitalGauge1.DisplayRecordIndex = 0;
            this.digitalGauge1.Location = new System.Drawing.Point(114, 55);
            this.digitalGauge1.MaximumSize = new System.Drawing.Size(500, 180);
            this.digitalGauge1.MinimumSize = new System.Drawing.Size(90, 90);
            this.digitalGauge1.Name = "digitalGauge1";
            this.digitalGauge1.Size = new System.Drawing.Size(221, 104);
            this.digitalGauge1.TabIndex = 0;
            // 
            // LinearGaugePanel
            // 
            this.LinearGaugePanel.BackColor = System.Drawing.Color.White;
            this.LinearGaugePanel.Controls.Add(this.label4);
            this.LinearGaugePanel.Controls.Add(this.linearGauge1);
            this.LinearGaugePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LinearGaugePanel.Location = new System.Drawing.Point(0, 0);
            this.LinearGaugePanel.Name = "LinearGaugePanel";
            this.LinearGaugePanel.Size = new System.Drawing.Size(408, 295);
            this.LinearGaugePanel.TabIndex = 0;
            // 
            // linearGauge1
            // 
            this.linearGauge1.ForeColor = System.Drawing.Color.Gray;
            this.linearGauge1.GaugelabelFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linearGauge1.LinearFrameType = Syncfusion.Windows.Forms.Gauge.LinearFrameType.Horizontal;
            this.linearGauge1.Location = new System.Drawing.Point(67, 90);
            this.linearGauge1.MajorTicksHeight = 15;
            this.linearGauge1.MinimumSize = new System.Drawing.Size(75, 125);
            this.linearGauge1.MinorTickCount = 5;
            this.linearGauge1.MinorTickHeight = 10;
            this.linearGauge1.Name = "linearGauge1";
            this.linearGauge1.PointerPlacement = Syncfusion.Windows.Forms.Gauge.Placement.Center;
            linearRange1.Color = System.Drawing.Color.Red;
            linearRange1.EndValue = 10F;
            linearRange1.Height = 5;
            linearRange1.InRange = false;
            linearRange1.Name = "GaugeRange1";
            linearRange1.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            linearRange1.StartValue = 0F;
            linearRange2.Color = System.Drawing.Color.Yellow;
            linearRange2.EndValue = 60F;
            linearRange2.Height = 5;
            linearRange2.InRange = false;
            linearRange2.Name = "GaugeRange2";
            linearRange2.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            linearRange2.StartValue = 30F;
            linearRange3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            linearRange3.EndValue = 110F;
            linearRange3.Height = 5;
            linearRange3.InRange = false;
            linearRange3.Name = "GaugeRange3";
            linearRange3.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            linearRange3.StartValue = 90F;
            this.linearGauge1.Ranges.Add(linearRange1);
            this.linearGauge1.Ranges.Add(linearRange2);
            this.linearGauge1.Ranges.Add(linearRange3);
            this.linearGauge1.ScaleColor = System.Drawing.Color.Gray;
            this.linearGauge1.Size = new System.Drawing.Size(300, 125);
            this.linearGauge1.TabIndex = 0;
            this.linearGauge1.Text = "linearGauge1";
            this.linearGauge1.ValueIndicatorColor = System.Drawing.Color.Gray;
            // 
            // RadialGaugePanel
            // 
            this.RadialGaugePanel.BackColor = System.Drawing.Color.White;
            this.RadialGaugePanel.Controls.Add(this.label3);
            this.RadialGaugePanel.Controls.Add(this.radialGauge1);
            this.RadialGaugePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.RadialGaugePanel.Location = new System.Drawing.Point(0, 0);
            this.RadialGaugePanel.Name = "RadialGaugePanel";
            this.RadialGaugePanel.Size = new System.Drawing.Size(404, 498);
            this.RadialGaugePanel.TabIndex = 0;
            // 
            // radialGauge1
            // 
            this.radialGauge1.EnableCustomNeedles = false;
            this.radialGauge1.GaugeLabel = "Gauge";
            this.radialGauge1.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge1.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge1.LabelPlacement = Syncfusion.Windows.Forms.Gauge.LabelPlacement.Outside;
            this.radialGauge1.Location = new System.Drawing.Point(44, 90);
            this.radialGauge1.MinimumSize = new System.Drawing.Size(125, 125);
            this.radialGauge1.Name = "radialGauge1";
            range1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            range1.EndValue = 40F;
            range1.Height = 5;
            range1.InRange = false;
            range1.Name = "GaugeRange1";
            range1.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            range1.StartValue = 0F;
            range2.Color = System.Drawing.Color.Yellow;
            range2.EndValue = 80F;
            range2.Height = 5;
            range2.InRange = false;
            range2.Name = "GaugeRange2";
            range2.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            range2.StartValue = 40F;
            range3.Color = System.Drawing.Color.Red;
            range3.EndValue = 100F;
            range3.Height = 5;
            range3.InRange = false;
            range3.Name = "GaugeRange3";
            range3.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            range3.StartValue = 80F;
            this.radialGauge1.Ranges.Add(range1);
            this.radialGauge1.Ranges.Add(range2);
            this.radialGauge1.Ranges.Add(range3);
            this.radialGauge1.Size = new System.Drawing.Size(317, 317);
            this.radialGauge1.TabIndex = 0;
            this.radialGauge1.TextOrientation = Syncfusion.Windows.Forms.Gauge.TextOrientation.SlideOver;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.label3.Location = new System.Drawing.Point(26, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "RadialGauge";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.label4.Location = new System.Drawing.Point(27, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "LinearGauge";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.label5.Location = new System.Drawing.Point(27, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "DigitalGauge";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.CaptionBarHeight = 40;
            this.CaptionButtonColor = System.Drawing.Color.White;
            this.CaptionButtonHoverColor = System.Drawing.Color.Black;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1229, 600);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Gauge Theme Demo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.LinearDigitalBasePanel.ResumeLayout(false);
            this.DigitalGaugePanel.ResumeLayout(false);
            this.DigitalGaugePanel.PerformLayout();
            this.LinearGaugePanel.ResumeLayout(false);
            this.LinearGaugePanel.PerformLayout();
            this.RadialGaugePanel.ResumeLayout(false);
            this.RadialGaugePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel11;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel RadialGaugePanel;
        private System.Windows.Forms.Panel LinearDigitalBasePanel;
        private System.Windows.Forms.Panel LinearGaugePanel;
        private System.Windows.Forms.Panel DigitalGaugePanel;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge1;
        private Syncfusion.Windows.Forms.Gauge.DigitalGauge digitalGauge1;
        private Syncfusion.Windows.Forms.Gauge.LinearGauge linearGauge1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

