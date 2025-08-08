#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace TextFormatting_2017
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radialSlider2 = new Syncfusion.Windows.Forms.Tools.RadialSlider();
            this.radialSlider3 = new Syncfusion.Windows.Forms.Tools.RadialSlider();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(239, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Default Slider";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(499, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Frame Slider";
            // 
            // radialSlider2
            // 
            this.radialSlider2.BackgroundColor = System.Drawing.Color.White;
            this.radialSlider2.BeforeTouchSize = new System.Drawing.Size(240, 240);
            this.radialSlider2.EndAngle = 360D;
            this.radialSlider2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(151)))), ((int)(((byte)(55)))));
            this.radialSlider2.Location = new System.Drawing.Point(173, 139);
            this.radialSlider2.MaximumValue = 100D;
            this.radialSlider2.Name = "radialSlider2";
            this.radialSlider2.RadialDirection = Syncfusion.Windows.Forms.Tools.RadialDirection.Clockwise;
            this.radialSlider2.Size = new System.Drawing.Size(240, 240);
            this.radialSlider2.StartAngle = 0D;
            this.radialSlider2.TabIndex = 7;
            this.radialSlider2.Text = "radialSlider2";
            this.radialSlider2.ThemeName = "Default";
            this.radialSlider2.DrawText += new System.EventHandler<Syncfusion.Windows.Forms.Tools.RadialSlider.DrawTextEventArgs>(this.radialSlider2_DrawText);
            // 
            // radialSlider3
            // 
            this.radialSlider3.BackgroundColor = System.Drawing.Color.White;
            this.radialSlider3.BeforeTouchSize = new System.Drawing.Size(207, 207);
            this.radialSlider3.EndAngle = 360D;
            this.radialSlider3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(151)))), ((int)(((byte)(55)))));
            this.radialSlider3.Location = new System.Drawing.Point(446, 152);
            this.radialSlider3.MaximumValue = 50D;
            this.radialSlider3.Name = "radialSlider3";
            this.radialSlider3.RadialDirection = Syncfusion.Windows.Forms.Tools.RadialDirection.Clockwise;
            this.radialSlider3.Size = new System.Drawing.Size(207, 207);
            this.radialSlider3.SliderStyle = Syncfusion.Windows.Forms.Tools.SliderStyles.Frame;
            this.radialSlider3.StartAngle = 0D;
            this.radialSlider3.TabIndex = 8;
            this.radialSlider3.Text = "radialSlider3";
            this.radialSlider3.ThemeName = "Default";
            this.radialSlider3.DrawText += new System.EventHandler<Syncfusion.Windows.Forms.Tools.RadialSlider.DrawTextEventArgs>(this.radialSlider3_DrawText);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 468);
            this.Controls.Add(this.radialSlider3);
            this.Controls.Add(this.radialSlider2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Appearance customization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.RadialSlider radialSlider2;
        private Syncfusion.Windows.Forms.Tools.RadialSlider radialSlider3;
    }
}

