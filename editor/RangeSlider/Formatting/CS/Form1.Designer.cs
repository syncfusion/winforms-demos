#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Drawing;
using System.Globalization;

namespace SliderFormatting_2017
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
            this.rangeSlider1 = new Syncfusion.Windows.Forms.Tools.RangeSlider();
            this.rangeSlider2 = new Syncfusion.Windows.Forms.Tools.RangeSlider();
            this.rangeSlider3 = new Syncfusion.Windows.Forms.Tools.RangeSlider();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rangeSlider1
            // 
            this.rangeSlider1.VisualStyle = Syncfusion.Windows.Forms.Tools.RangeSlider.RangeSliderStyle.Office2016Colorful;
            this.rangeSlider1.BeforeTouchSize = new System.Drawing.Size(800, 52);
            this.rangeSlider1.ChannelColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.rangeSlider1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.rangeSlider1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.rangeSlider1.HighlightedThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.rangeSlider1.Location = new System.Drawing.Point(65, 135);
            this.rangeSlider1.Maximum = 100;
            this.rangeSlider1.Name = "rangeSlider1";
            this.rangeSlider1.PushedThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(86)))), ((int)(((byte)(148)))));
            this.rangeSlider1.RangeColor = ColorTranslator.FromHtml("#106ebe");
            this.rangeSlider1.ShowLabels = true;
            this.rangeSlider1.ShowTicks = false;
            this.rangeSlider1.Size = new System.Drawing.Size(800, 52);
            this.rangeSlider1.SliderMax = 40;
            this.rangeSlider1.SliderSize = new System.Drawing.Size(5, 18);
            this.rangeSlider1.TabIndex = 0;
            this.rangeSlider1.Text = "rangeSlider1";
            this.rangeSlider1.ThumbColor = ColorTranslator.FromHtml("#106ebe");
            this.rangeSlider1.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.rangeSlider1.TickFrequency = 20;
            this.rangeSlider1.DrawLabel += RangeSlider1_DrawLabel;
            // 
            // rangeSlider2
            // 
            this.rangeSlider2.VisualStyle = Syncfusion.Windows.Forms.Tools.RangeSlider.RangeSliderStyle.Office2016Colorful;
            this.rangeSlider2.BeforeTouchSize = new System.Drawing.Size(800, 52);
            this.rangeSlider2.ChannelColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.rangeSlider2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.rangeSlider2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.rangeSlider2.HighlightedThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.rangeSlider2.Location = new System.Drawing.Point(65, 295);
            this.rangeSlider2.Maximum = 2100;
            this.rangeSlider2.SliderMax = 1700;
            this.rangeSlider2.Minimum = 900;
            this.rangeSlider2.SliderMin = 1300;
            this.rangeSlider2.Name = "rangeSlider2";
            this.rangeSlider2.PushedThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(86)))), ((int)(((byte)(148)))));
            this.rangeSlider2.RangeColor = ColorTranslator.FromHtml("#106ebe");
            this.rangeSlider2.ShowLabels = true;
            this.rangeSlider2.ShowTicks = false;
            this.rangeSlider2.Size = new System.Drawing.Size(800, 52);
            this.rangeSlider2.SliderSize = new System.Drawing.Size(5, 18);
            this.rangeSlider2.TabIndex = 1;
            this.rangeSlider2.Text = "rangeSlider2";
            this.rangeSlider2.ThumbColor = ColorTranslator.FromHtml("#106ebe");
            this.rangeSlider2.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.rangeSlider2.TickFrequency = 400;
            this.rangeSlider2.DrawLabel += RangeSlider2_DrawLabel;
            // 
            // rangeSlider3
            // 
            this.rangeSlider3.VisualStyle = Syncfusion.Windows.Forms.Tools.RangeSlider.RangeSliderStyle.Office2016Colorful;
            this.rangeSlider3.BeforeTouchSize = new System.Drawing.Size(800, 52);
            this.rangeSlider3.ChannelColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.rangeSlider3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.rangeSlider3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.rangeSlider3.HighlightedThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.rangeSlider3.Location = new System.Drawing.Point(65, 457);
            this.rangeSlider3.Maximum = 23;
            this.rangeSlider3.SliderMax = 23;
            this.rangeSlider3.Minimum = 8;
            this.rangeSlider3.SliderMin = 17;
            this.rangeSlider3.Name = "rangeSlider3";
            this.rangeSlider3.PushedThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(86)))), ((int)(((byte)(148)))));
            this.rangeSlider3.RangeColor = ColorTranslator.FromHtml("#106ebe");
            this.rangeSlider3.ShowLabels = true;
            this.rangeSlider3.ShowTicks = false;
            this.rangeSlider3.Size = new System.Drawing.Size(800, 52);
            this.rangeSlider3.SliderSize = new System.Drawing.Size(5, 18);
            this.rangeSlider3.TabIndex = 2;
            this.rangeSlider3.Text = "rangeSlider3";
            this.rangeSlider3.ThumbColor = ColorTranslator.FromHtml("#106ebe");
            this.rangeSlider3.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.rangeSlider3.TickFrequency = 3;
            this.rangeSlider3.DrawLabel += RangeSlider3_DrawLabel;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(70, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Currency Slider";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(70, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kilometer Slider";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(70, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Time Slider";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 51);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(991, 51);
            this.label4.TabIndex = 0;
            this.label4.Text = "The following sample demonstates the customization of text, font and color of the" +
    " labels present in RangeSlider, which helps in converting the labels into currency" +
    ", kilometer and time format.";
            // 
            // Form1
            // 
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Style.Border = new Pen(System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244))))), 5);
            this.Style.ShadowOpacity = 0;
            this.ClientSize = new System.Drawing.Size(993, 646);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rangeSlider3);
            this.Controls.Add(this.rangeSlider2);
            this.Controls.Add(this.rangeSlider1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slider Formatting";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private Syncfusion.Windows.Forms.Tools.RangeSlider rangeSlider1;
        private Syncfusion.Windows.Forms.Tools.RangeSlider rangeSlider2;
        private Syncfusion.Windows.Forms.Tools.RangeSlider rangeSlider3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}

