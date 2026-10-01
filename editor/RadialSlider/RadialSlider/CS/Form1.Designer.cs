#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Tools;
using System.Drawing;

namespace Radial
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radialSlider1 = new Syncfusion.Windows.Forms.Tools.RadialSlider();
            this.radialSlider2 = new Syncfusion.Windows.Forms.Tools.RadialSlider();
            this.label4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.label5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBoxExt2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBoxExt3 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label10 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.label1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.sfComboBox1 = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label8 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.label9 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.checkBox1);
            this.groupBox5.Location = new System.Drawing.Point(0, 123);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(241, 0);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Show Outer Circle";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Location = new System.Drawing.Point(25, -16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 18);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Show Outer Circle";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // radialSlider1
            // 
            this.radialSlider1.BeforeTouchSize = new System.Drawing.Size(268, 268);
            this.radialSlider1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(151)))), ((int)(((byte)(55)))));
            this.radialSlider1.Location = new System.Drawing.Point(-5, -10);
            this.radialSlider1.MaximumValue = 50D;
            this.radialSlider1.MinimumSize = new System.Drawing.Size(75, 75);
            this.radialSlider1.Name = "radialSlider1";
            this.radialSlider1.Size = new System.Drawing.Size(268, 268);
            this.radialSlider1.TabIndex = 24;
            this.radialSlider1.Text = "radialSlider2";
            this.radialSlider1.ThemeName = "Office2019Colorful";
            this.radialSlider1.Value = 10D;
            // 
            // radialSlider2
            // 
            this.radialSlider2.BeforeTouchSize = new System.Drawing.Size(224, 224);
            this.radialSlider2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(151)))), ((int)(((byte)(55)))));
            this.radialSlider2.Location = new System.Drawing.Point(17, 312);
            this.radialSlider2.MaximumValue = 50D;
            this.radialSlider2.MinimumSize = new System.Drawing.Size(75, 75);
            this.radialSlider2.Name = "radialSlider2";
            this.radialSlider2.Size = new System.Drawing.Size(224, 224);
            this.radialSlider2.SliderStyle = Syncfusion.Windows.Forms.Tools.SliderStyles.Frame;
            this.radialSlider2.TabIndex = 25;
            this.radialSlider2.Text = "radialSlider2";
            this.radialSlider2.ThemeName = "Office2019Colorful";
            this.radialSlider2.Value = 10D;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "MaximumValue ";
            this.label4.ThemeStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(288, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Slider Divisions ";
            this.label5.ThemeStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // textBoxExt1
            // 
            this.textBoxExt1.BeforeTouchSize = new System.Drawing.Size(156, 22);
            this.textBoxExt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExt1.Location = new System.Drawing.Point(392, 78);
            this.textBoxExt1.Name = "textBoxExt1";
            this.textBoxExt1.Size = new System.Drawing.Size(156, 22);
            this.textBoxExt1.TabIndex = 2;
            this.textBoxExt1.Text = "50";
            this.textBoxExt1.ThemeName = "Office2019Colorful";
            this.textBoxExt1.TextChanged += new System.EventHandler(this.textBoxExt1_TextChanged);
            // 
            // textBoxExt2
            // 
            this.textBoxExt2.BeforeTouchSize = new System.Drawing.Size(156, 22);
            this.textBoxExt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExt2.Location = new System.Drawing.Point(392, 129);
            this.textBoxExt2.Name = "textBoxExt2";
            this.textBoxExt2.Size = new System.Drawing.Size(156, 22);
            this.textBoxExt2.TabIndex = 3;
            this.textBoxExt2.Text = "10";
            this.textBoxExt2.ThemeName = "Office2019Colorful";
            this.textBoxExt2.TextChanged += new System.EventHandler(this.textBoxExt2_TextChanged);
            // 
            // textBoxExt3
            // 
            this.textBoxExt3.BeforeTouchSize = new System.Drawing.Size(156, 22);
            this.textBoxExt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExt3.Location = new System.Drawing.Point(392, 26);
            this.textBoxExt3.Name = "textBoxExt3";
            this.textBoxExt3.Size = new System.Drawing.Size(156, 22);
            this.textBoxExt3.TabIndex = 1;
            this.textBoxExt3.Text = "0";
            this.textBoxExt3.ThemeName = "Office2019Colorful";
            this.textBoxExt3.TextChanged += new System.EventHandler(this.textBoxExt3_TextChanged);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(289, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 16);
            this.label10.TabIndex = 42;
            this.label10.Text = "MinimumValue ";
            this.label10.ThemeStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "Choose Theme";
            this.label1.ThemeStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // sfComboBox1
            // 
            this.sfComboBox1.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.sfComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfComboBox1.Location = new System.Drawing.Point(392, 182);
            this.sfComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.sfComboBox1.Name = "sfComboBox1";
            this.sfComboBox1.Size = new System.Drawing.Size(156, 22);
            this.sfComboBox1.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfComboBox1.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfComboBox1.TabIndex = 57;
            this.sfComboBox1.SelectedIndexChanged += new System.EventHandler(this.sfComboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(104, 546);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 19);
            this.label8.TabIndex = 41;
            this.label8.Text = "Frame";
            this.label8.ThemeStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(107, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 19);
            this.label9.TabIndex = 40;
            this.label9.Text = "Default";
            this.label9.ThemeStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Form1
            // 
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(567, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sfComboBox1);
            this.Controls.Add(this.textBoxExt3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxExt2);
            this.Controls.Add(this.textBoxExt1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radialSlider2);
            this.Controls.Add(this.radialSlider1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Text = "Radial Slider";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBox1;
        private Syncfusion.Windows.Forms.Tools.RadialSlider radialSlider1;
        private Syncfusion.Windows.Forms.Tools.RadialSlider radialSlider2;
        private AutoLabel label4;
        private AutoLabel label5;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt3;
        private AutoLabel label10;
        private AutoLabel label1;
        private Syncfusion.WinForms.ListView.SfComboBox sfComboBox1;
        private AutoLabel label8;
        private AutoLabel label9;
    }
}