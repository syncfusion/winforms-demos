#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Tools;
using System.Drawing;

namespace RangeSlider_2017
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.borderPanel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownExt1 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxAdv2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.comboBoxAdv2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownExt2 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.rangeSlider2 = new Syncfusion.Windows.Forms.Tools.RangeSlider();
            this.panel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.rangeSlider1 = new Syncfusion.Windows.Forms.Tools.RangeSlider();
            this.SelectedDateLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.borderPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel3)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 54);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(992, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 54);
            this.panel6.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 2);
            this.panel2.TabIndex = 1;
            // 
            // borderPanel1
            // 
            this.borderPanel1.Controls.Add(this.panel5);
            this.borderPanel1.Controls.Add(this.panel4);
            this.borderPanel1.Controls.Add(this.panel3);
            this.borderPanel1.Controls.Add(this.SelectedDateLbl);
            this.borderPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borderPanel1.Location = new System.Drawing.Point(0, 56);
            this.borderPanel1.Name = "borderPanel1";
            this.borderPanel1.Size = new System.Drawing.Size(993, 590);
            this.borderPanel1.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.numericUpDownExt1);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.checkBoxAdv2);
            this.panel5.Controls.Add(this.comboBoxAdv2);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.numericUpDownExt2);
            this.panel5.Controls.Add(this.comboBoxAdv1);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.checkBoxAdv1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(658, 18);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(299, 560);
            this.panel5.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label8.Location = new System.Drawing.Point(26, 42);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Range Start";
            // 
            // numericUpDownExt1
            // 
            this.numericUpDownExt1.BeforeTouchSize = new System.Drawing.Size(120, 25);
            this.numericUpDownExt1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.numericUpDownExt1.Location = new System.Drawing.Point(149, 42);
            this.numericUpDownExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownExt1.MaximumSize = new System.Drawing.Size(120, 0);
            this.numericUpDownExt1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.numericUpDownExt1.MinimumSize = new System.Drawing.Size(120, 0);
            this.numericUpDownExt1.Name = "numericUpDownExt1";
            this.numericUpDownExt1.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownExt1.TabIndex = 25;
            this.numericUpDownExt1.ValueChanged += new System.EventHandler(this.numericUpDownExt1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(26, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Range End";
            // 
            // checkBoxAdv2
            // 
            this.checkBoxAdv2.BeforeTouchSize = new System.Drawing.Size(130, 20);
            this.checkBoxAdv2.Checked = true;
            this.checkBoxAdv2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv2.Location = new System.Drawing.Point(149, 467);
            this.checkBoxAdv2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.checkBoxAdv2.Name = "checkBoxAdv2";
            this.checkBoxAdv2.Size = new System.Drawing.Size(130, 20);
            this.checkBoxAdv2.TabIndex = 28;
            this.checkBoxAdv2.ThemesEnabled = false;
            this.checkBoxAdv2.CheckStateChanged += new System.EventHandler(this.checkBoxAdv2_CheckStateChanged);
            // 
            // comboBoxAdv2
            // 
            this.comboBoxAdv2.BeforeTouchSize = new System.Drawing.Size(120, 25);
            this.comboBoxAdv2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.comboBoxAdv2.Items.AddRange(new object[] {
            "BottomRight",
            "TopLeft",
            "Both"});
            this.comboBoxAdv2.Location = new System.Drawing.Point(149, 385);
            this.comboBoxAdv2.Name = "comboBoxAdv2";
            this.comboBoxAdv2.Size = new System.Drawing.Size(120, 25);
            this.comboBoxAdv2.TabIndex = 30;
            this.comboBoxAdv2.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(26, 467);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Show Labels";
            // 
            // numericUpDownExt2
            // 
            this.numericUpDownExt2.BeforeTouchSize = new System.Drawing.Size(120, 25);
            this.numericUpDownExt2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.numericUpDownExt2.Location = new System.Drawing.Point(149, 127);
            this.numericUpDownExt2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownExt2.MaximumSize = new System.Drawing.Size(120, 0);
            this.numericUpDownExt2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.numericUpDownExt2.MinimumSize = new System.Drawing.Size(120, 0);
            this.numericUpDownExt2.Name = "numericUpDownExt2";
            this.numericUpDownExt2.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownExt2.TabIndex = 26;
            this.numericUpDownExt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownExt2.ValueChanged += new System.EventHandler(this.numericUpDownExt2_ValueChanged);
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(120, 25);
            this.comboBoxAdv1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "BottomRight",
            "TopLeft",
            "Inline",
            "Both"});
            this.comboBoxAdv1.Location = new System.Drawing.Point(149, 212);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(120, 25);
            this.comboBoxAdv1.TabIndex = 29;
            this.comboBoxAdv1.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(26, 385);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Label Placement";
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.BeforeTouchSize = new System.Drawing.Size(120, 22);
            this.checkBoxAdv1.Checked = true;
            this.checkBoxAdv1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv1.Location = new System.Drawing.Point(149, 297);
            this.checkBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(120, 22);
            this.checkBoxAdv1.TabIndex = 27;
            this.checkBoxAdv1.ThemesEnabled = false;
            this.checkBoxAdv1.CheckStateChanged += new System.EventHandler(this.checkBoxAdv1_CheckStateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(26, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tick Placement";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label7.Location = new System.Drawing.Point(26, 297);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Show Ticks";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.rangeSlider2);
            this.panel4.Location = new System.Drawing.Point(352, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 520);
            this.panel4.TabIndex = 33;
            // 
            // rangeSlider2
            // 
            this.rangeSlider2.BeforeTouchSize = new System.Drawing.Size(44, 286);
            this.rangeSlider2.ChannelColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.rangeSlider2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.rangeSlider2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.rangeSlider2.HighlightedThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.rangeSlider2.Location = new System.Drawing.Point(119, 128);
            this.rangeSlider2.Name = "rangeSlider2";
            this.rangeSlider2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.rangeSlider2.PushedThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(86)))), ((int)(((byte)(148)))));
            this.rangeSlider2.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.rangeSlider2.ShowLabels = true;
            this.rangeSlider2.Size = new System.Drawing.Size(44, 286);
            this.rangeSlider2.SliderSize = new System.Drawing.Size(3, 16);
            this.rangeSlider2.TabIndex = 22;
            this.rangeSlider2.Text = "rangeSlider2";
            this.rangeSlider2.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.rangeSlider2.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.rangeSlider2.VisualStyle = Syncfusion.Windows.Forms.Tools.RangeSlider.RangeSliderStyle.Office2016Colorful;
            this.rangeSlider2.ValueChanged += new System.EventHandler(this.rangeSlider1_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.rangeSlider1);
            this.panel3.Location = new System.Drawing.Point(12, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(334, 520);
            this.panel3.TabIndex = 32;
            // 
            // rangeSlider1
            // 
            this.rangeSlider1.BeforeTouchSize = new System.Drawing.Size(286, 44);
            this.rangeSlider1.ChannelColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.rangeSlider1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.rangeSlider1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.rangeSlider1.HighlightedThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.rangeSlider1.Location = new System.Drawing.Point(20, 220);
            this.rangeSlider1.Name = "rangeSlider1";
            this.rangeSlider1.PushedThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(86)))), ((int)(((byte)(148)))));
            this.rangeSlider1.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.rangeSlider1.ShowLabels = true;
            this.rangeSlider1.Size = new System.Drawing.Size(286, 44);
            this.rangeSlider1.SliderSize = new System.Drawing.Size(3, 16);
            this.rangeSlider1.TabIndex = 21;
            this.rangeSlider1.Text = "rangeSlider1";
            this.rangeSlider1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.rangeSlider1.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.rangeSlider1.VisualStyle = Syncfusion.Windows.Forms.Tools.RangeSlider.RangeSliderStyle.Office2016Colorful;
            this.rangeSlider1.ValueChanged += new System.EventHandler(this.rangeSlider1_ValueChanged);
            // 
            // SelectedDateLbl
            // 
            this.SelectedDateLbl.AutoSize = true;
            this.SelectedDateLbl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SelectedDateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.SelectedDateLbl.Location = new System.Drawing.Point(217, 472);
            this.SelectedDateLbl.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.SelectedDateLbl.Name = "SelectedDateLbl";
            this.SelectedDateLbl.Size = new System.Drawing.Size(0, 19);
            this.SelectedDateLbl.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(992, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "The following sample demonstrates the functionalities of the RangeSlider such as " +
    "range selection, by moving sliders as well as programmatically, tick and label c" +
    "ustomization.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(993, 646);
            this.Controls.Add(this.borderPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.Border = new Pen(System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244))))), 5);
            this.Style.ShadowOpacity = 0;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Getting Started";
            this.panel1.ResumeLayout(false);
            this.borderPanel1.ResumeLayout(false);
            this.borderPanel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel borderPanel1;
        private System.Windows.Forms.Label SelectedDateLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private ComboBoxAdv comboBoxAdv2;
        private ComboBoxAdv comboBoxAdv1;
        private CheckBoxAdv checkBoxAdv2;
        private CheckBoxAdv checkBoxAdv1;
        private NumericUpDownExt numericUpDownExt1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private RangeSlider rangeSlider1;
        private System.Windows.Forms.Panel panel5;
        private NumericUpDownExt numericUpDownExt2;
        private GradientPanel panel4;
        private RangeSlider rangeSlider2;
        private GradientPanel panel3;
        private System.Windows.Forms.Label label1;
    }
}

