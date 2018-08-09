namespace UserInteractionDemo_2013
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
            this.label4 = new System.Windows.Forms.Label();
            this.Valuelbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linearGauge1 = new Syncfusion.Windows.Forms.Gauge.LinearGauge();
            this.label1 = new System.Windows.Forms.Label();
            this.radialGauge1 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Valuelbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.linearGauge1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radialGauge1);
            this.panel1.Location = new System.Drawing.Point(25, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 447);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(738, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Value";
            // 
            // Valuelbl
            // 
            this.Valuelbl.AutoSize = true;
            this.Valuelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.Valuelbl.ForeColor = System.Drawing.Color.Gray;
            this.Valuelbl.Location = new System.Drawing.Point(791, 372);
            this.Valuelbl.Name = "Valuelbl";
            this.Valuelbl.Size = new System.Drawing.Size(14, 15);
            this.Valuelbl.TabIndex = 6;
            this.Valuelbl.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(607, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hold and Drag the bar pointer to interact with it";
            // 
            // linearGauge1
            // 
            this.linearGauge1.BackgroundGradientEndColor = System.Drawing.Color.White;
            this.linearGauge1.BackgroundGradientStartColor = System.Drawing.Color.White;
            this.linearGauge1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linearGauge1.ForeColor = System.Drawing.Color.Gray;
            this.linearGauge1.GaugelabelFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linearGauge1.LinearFrameType = Syncfusion.Windows.Forms.Gauge.LinearFrameType.Vertical;
            this.linearGauge1.Location = new System.Drawing.Point(656, 21);
            this.linearGauge1.MajorTicksHeight = 15;
            this.linearGauge1.MinimumSize = new System.Drawing.Size(75, 125);
            this.linearGauge1.MinorTickCount = 5;
            this.linearGauge1.MinorTickHeight = 10;
            this.linearGauge1.Name = "linearGauge1";
            this.linearGauge1.NeedleColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(180)))), ((int)(((byte)(205)))));
            this.linearGauge1.OuterFrameGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(180)))), ((int)(((byte)(205)))));
            this.linearGauge1.OuterFrameGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(180)))), ((int)(((byte)(205)))));
            this.linearGauge1.PointerPlacement = Syncfusion.Windows.Forms.Gauge.Placement.Far;
            linearRange1.Color = System.Drawing.SystemColors.MenuHighlight;
            linearRange1.EndValue = 70F;
            linearRange1.Height = 5;
            linearRange1.InRange = false;
            linearRange1.Name = "GaugeRange1";
            linearRange1.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            linearRange1.StartValue = 0F;
            linearRange2.Color = System.Drawing.Color.Red;
            linearRange2.EndValue = 110F;
            linearRange2.Height = 5;
            linearRange2.InRange = false;
            linearRange2.Name = "GaugeRange2";
            linearRange2.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            linearRange2.StartValue = 70F;
            linearRange3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            linearRange3.EndValue = 120F;
            linearRange3.Height = 5;
            linearRange3.InRange = false;
            linearRange3.Name = "GaugeRange2";
            linearRange3.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            linearRange3.StartValue = 110F;
            this.linearGauge1.Ranges.Add(linearRange1);
            this.linearGauge1.Ranges.Add(linearRange2);
            this.linearGauge1.Ranges.Add(linearRange3);
            this.linearGauge1.ReadOnly = false;
            this.linearGauge1.Size = new System.Drawing.Size(134, 340);
            this.linearGauge1.TabIndex = 4;
            this.linearGauge1.Text = "linearGauge1";
            this.linearGauge1.ValueIndicatorColor = System.Drawing.Color.Gray;
            this.linearGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Metro;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hold and Drag the pointer needle to interact with it";
            // 
            // radialGauge1
            // 
            this.radialGauge1.BackgroundGradientEndColor = System.Drawing.Color.White;
            this.radialGauge1.BackgroundGradientStartColor = System.Drawing.Color.White;
            this.radialGauge1.EnableCustomNeedles = false;
            this.radialGauge1.Font = new System.Drawing.Font("Segoe UI", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.radialGauge1.GaugeLabel = "0";
            this.radialGauge1.GaugeLableFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.radialGauge1.GaugeValueFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.radialGauge1.Location = new System.Drawing.Point(73, 40);
            this.radialGauge1.MinimumSize = new System.Drawing.Size(125, 125);
            this.radialGauge1.Name = "radialGauge1";
            this.radialGauge1.NeedleColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(180)))), ((int)(((byte)(205)))));
            this.radialGauge1.NeedleStyle = Syncfusion.Windows.Forms.Gauge.NeedleStyle.Advanced;
            this.radialGauge1.OuterFrameGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(180)))), ((int)(((byte)(205)))));
            this.radialGauge1.OuterFrameGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(180)))), ((int)(((byte)(205)))));
            range1.Color = System.Drawing.SystemColors.MenuHighlight;
            range1.EndValue = 70F;
            range1.Height = 5;
            range1.InRange = false;
            range1.Name = "GaugeRange1";
            range1.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range1.StartValue = 0F;
            range2.Color = System.Drawing.Color.Red;
            range2.EndValue = 110F;
            range2.Height = 5;
            range2.InRange = false;
            range2.Name = "GaugeRange2";
            range2.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range2.StartValue = 70F;
            range3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            range3.EndValue = 120F;
            range3.Height = 5;
            range3.InRange = false;
            range3.Name = "GaugeRange3";
            range3.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range3.StartValue = 110F;
            this.radialGauge1.Ranges.Add(range1);
            this.radialGauge1.Ranges.Add(range2);
            this.radialGauge1.Ranges.Add(range3);
            this.radialGauge1.ReadOnly = false;
            this.radialGauge1.Size = new System.Drawing.Size(347, 347);
            this.radialGauge1.TabIndex = 2;
            this.radialGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Metro;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.CaptionButtonColor = System.Drawing.Color.Black;
            this.CaptionButtonHoverColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(991, 522);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "User Interaction ";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge1;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Gauge.LinearGauge linearGauge1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Valuelbl;

    }
}

