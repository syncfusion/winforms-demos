#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Controls;
using System.Drawing;

namespace RangeSlider_2017
{
    partial class Form1 : SfForm
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
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.rangeSlider1 = new Syncfusion.Windows.Forms.Tools.RangeSlider();
            this.rangeSlider3 = new Syncfusion.Windows.Forms.Tools.RangeSlider();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.rangeSlider5 = new Syncfusion.Windows.Forms.Tools.RangeSlider();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.rangeSlider6 = new Syncfusion.Windows.Forms.Tools.RangeSlider();
            this.rangeSlider2 = new Syncfusion.Windows.Forms.Tools.RangeSlider();
            this.rangeSlider4 = new Syncfusion.Windows.Forms.Tools.RangeSlider();
            this.borderPanel1 = new System.Windows.Forms.Panel();
            this.autoLabel10 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.sfComboBox1 = new Syncfusion.WinForms.ListView.SfComboBox();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.borderPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.Location = new System.Drawing.Point(21, 70);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(164, 16);
            this.autoLabel1.TabIndex = 36;
            this.autoLabel1.Text = "Label and Tick Placement";
            this.autoLabel1.ThemeStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            // 
            // rangeSlider1
            // 
            this.rangeSlider1.BeforeTouchSize = new System.Drawing.Size(44, 391);
            this.rangeSlider1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangeSlider1.ForeColor = System.Drawing.Color.Black;
            this.rangeSlider1.HighlightedThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(141)))), ((int)(((byte)(212)))));
            this.rangeSlider1.Location = new System.Drawing.Point(485, 128);
            this.rangeSlider1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rangeSlider1.Maximum = 100;
            this.rangeSlider1.Name = "rangeSlider1";
            this.rangeSlider1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.rangeSlider1.PushedThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.rangeSlider1.ShowLabels = true;
            this.rangeSlider1.Size = new System.Drawing.Size(44, 391);
            this.rangeSlider1.SliderMax = 60;
            this.rangeSlider1.SliderMin = 40;
            this.rangeSlider1.TabIndex = 37;
            this.rangeSlider1.Text = "rangeSlider1";
            this.rangeSlider1.ThemeName = "Office2019Colorful";
            this.rangeSlider1.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rangeSlider1.TickFrequency = 20;
            this.rangeSlider1.DrawLabel += new System.EventHandler<Syncfusion.Windows.Forms.Tools.DrawLabelEventArgs>(this.rangeSlider1_DrawLabel);
            // 
            // rangeSlider3
            // 
            this.rangeSlider3.BeforeTouchSize = new System.Drawing.Size(400, 44);
            this.rangeSlider3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangeSlider3.ForeColor = System.Drawing.Color.Black;
            this.rangeSlider3.HighlightedThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(141)))), ((int)(((byte)(212)))));
            this.rangeSlider3.LabelPlacement = Syncfusion.Windows.Forms.Tools.LabelPlacement.TopLeft;
            this.rangeSlider3.Location = new System.Drawing.Point(21, 364);
            this.rangeSlider3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rangeSlider3.Maximum = 23;
            this.rangeSlider3.Minimum = 8;
            this.rangeSlider3.Name = "rangeSlider3";
            this.rangeSlider3.PushedThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.rangeSlider3.ShowLabels = true;
            this.rangeSlider3.Size = new System.Drawing.Size(400, 44);
            this.rangeSlider3.SliderMax = 23;
            this.rangeSlider3.SliderMin = 17;
            this.rangeSlider3.TabIndex = 39;
            this.rangeSlider3.Text = "rangeSlider3";
            this.rangeSlider3.ThemeName = "Office2019Colorful";
            this.rangeSlider3.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rangeSlider3.TickFrequency = 3;
            this.rangeSlider3.TickPlacement = Syncfusion.Windows.Forms.Tools.TickPlacement.TopLeft;
            this.rangeSlider3.DrawLabel += new System.EventHandler<Syncfusion.Windows.Forms.Tools.DrawLabelEventArgs>(this.rangeSlider3_DrawLabel);
            // 
            // autoLabel2
            // 
            this.autoLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.Location = new System.Drawing.Point(477, 70);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(72, 16);
            this.autoLabel2.TabIndex = 41;
            this.autoLabel2.Text = "Orientation";
            this.autoLabel2.ThemeStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            // 
            // rangeSlider5
            // 
            this.rangeSlider5.BeforeTouchSize = new System.Drawing.Size(400, 44);
            this.rangeSlider5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangeSlider5.ForeColor = System.Drawing.Color.Black;
            this.rangeSlider5.HighlightedThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.rangeSlider5.Location = new System.Drawing.Point(21, 102);
            this.rangeSlider5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rangeSlider5.Name = "rangeSlider5";
            this.rangeSlider5.PushedThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(86)))), ((int)(((byte)(148)))));
            this.rangeSlider5.ShowLabels = true;
            this.rangeSlider5.Size = new System.Drawing.Size(400, 44);
            this.rangeSlider5.SliderMax = 3;
            this.rangeSlider5.TabIndex = 42;
            this.rangeSlider5.Text = "rangeSlider5";
            this.rangeSlider5.ThemeName = "Default";
            this.rangeSlider5.ThemeStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.rangeSlider5.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            // 
            // autoLabel3
            // 
            this.autoLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel3.Location = new System.Drawing.Point(578, 70);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(132, 16);
            this.autoLabel3.TabIndex = 43;
            this.autoLabel3.Text = "Hide Ticks or Labels";
            this.autoLabel3.ThemeStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            // 
            // rangeSlider6
            // 
            this.rangeSlider6.BeforeTouchSize = new System.Drawing.Size(22, 391);
            this.rangeSlider6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangeSlider6.ForeColor = System.Drawing.Color.Black;
            this.rangeSlider6.HighlightedThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(141)))), ((int)(((byte)(212)))));
            this.rangeSlider6.Location = new System.Drawing.Point(631, 128);
            this.rangeSlider6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rangeSlider6.Name = "rangeSlider6";
            this.rangeSlider6.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.rangeSlider6.PushedThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.rangeSlider6.ShowTicks = false;
            this.rangeSlider6.Size = new System.Drawing.Size(22, 391);
            this.rangeSlider6.SliderMax = 7;
            this.rangeSlider6.SliderMin = 2;
            this.rangeSlider6.TabIndex = 44;
            this.rangeSlider6.Text = "rangeSlider6";
            this.rangeSlider6.ThemeName = "Office2019Colorful";
            this.rangeSlider6.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            // 
            // rangeSlider2
            // 
            this.rangeSlider2.BeforeTouchSize = new System.Drawing.Size(400, 44);
            this.rangeSlider2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangeSlider2.ForeColor = System.Drawing.Color.Black;
            this.rangeSlider2.LabelPlacement = Syncfusion.Windows.Forms.Tools.LabelPlacement.TopLeft;
            this.rangeSlider2.Location = new System.Drawing.Point(21, 232);
            this.rangeSlider2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rangeSlider2.Name = "rangeSlider2";
            this.rangeSlider2.ShowLabels = true;
            this.rangeSlider2.Size = new System.Drawing.Size(400, 44);
            this.rangeSlider2.TabIndex = 45;
            this.rangeSlider2.Text = "rangeSlider2";
            this.rangeSlider2.ThemeName = "Office2019Colorful";
            this.rangeSlider2.TickPlacement = Syncfusion.Windows.Forms.Tools.TickPlacement.Inline;
            this.rangeSlider2.DrawLabel += new System.EventHandler<Syncfusion.Windows.Forms.Tools.DrawLabelEventArgs>(this.rangeSlider2_DrawLabel_1);
            // 
            // rangeSlider4
            // 
            this.rangeSlider4.BeforeTouchSize = new System.Drawing.Size(400, 44);
            this.rangeSlider4.Enabled = false;
            this.rangeSlider4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangeSlider4.ForeColor = System.Drawing.Color.Black;
            this.rangeSlider4.HighlightedThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(141)))), ((int)(((byte)(212)))));
            this.rangeSlider4.Location = new System.Drawing.Point(21, 498);
            this.rangeSlider4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rangeSlider4.Maximum = 500;
            this.rangeSlider4.Name = "rangeSlider4";
            this.rangeSlider4.PushedThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.rangeSlider4.ShowLabels = true;
            this.rangeSlider4.Size = new System.Drawing.Size(400, 44);
            this.rangeSlider4.SliderMax = 450;
            this.rangeSlider4.SliderMin = 50;
            this.rangeSlider4.TabIndex = 46;
            this.rangeSlider4.Text = "rangeSlider4";
            this.rangeSlider4.ThemeName = "Office2019Colorful";
            this.rangeSlider4.ThemeStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.rangeSlider4.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rangeSlider4.TickFrequency = 50;
            this.rangeSlider4.TickPlacement = Syncfusion.Windows.Forms.Tools.TickPlacement.Inline;
            // 
            // borderPanel1
            // 
            this.borderPanel1.Controls.Add(this.autoLabel10);
            this.borderPanel1.Controls.Add(this.sfComboBox1);
            this.borderPanel1.Controls.Add(this.autoLabel4);
            this.borderPanel1.Controls.Add(this.rangeSlider4);
            this.borderPanel1.Controls.Add(this.rangeSlider2);
            this.borderPanel1.Controls.Add(this.rangeSlider6);
            this.borderPanel1.Controls.Add(this.autoLabel3);
            this.borderPanel1.Controls.Add(this.rangeSlider5);
            this.borderPanel1.Controls.Add(this.autoLabel2);
            this.borderPanel1.Controls.Add(this.rangeSlider3);
            this.borderPanel1.Controls.Add(this.rangeSlider1);
            this.borderPanel1.Controls.Add(this.autoLabel1);
            this.borderPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderPanel1.Location = new System.Drawing.Point(2, 2);
            this.borderPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.borderPanel1.Name = "borderPanel1";
            this.borderPanel1.Size = new System.Drawing.Size(724, 574);
            this.borderPanel1.TabIndex = 2;
            this.borderPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.borderPanel1_Paint);
            // 
            // autoLabel10
            // 
            this.autoLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel10.Location = new System.Drawing.Point(453, 27);
            this.autoLabel10.Name = "autoLabel10";
            this.autoLabel10.Size = new System.Drawing.Size(107, 16);
            this.autoLabel10.TabIndex = 56;
            this.autoLabel10.Text = "Choose theme";
            this.autoLabel10.ThemeStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            // 
            // sfComboBox1
            // 
            this.sfComboBox1.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.sfComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfComboBox1.Location = new System.Drawing.Point(553, 26);
            this.sfComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.sfComboBox1.Name = "sfComboBox1";
            this.sfComboBox1.Size = new System.Drawing.Size(157, 21);
            this.sfComboBox1.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfComboBox1.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfComboBox1.TabIndex = 55;
            this.sfComboBox1.SelectedIndexChanged += new System.EventHandler(this.sfComboBox1_SelectedIndexChanged);
            // 
            // autoLabel4
            // 
            this.autoLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel4.Location = new System.Drawing.Point(21, 478);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(97, 16);
            this.autoLabel4.TabIndex = 47;
            this.autoLabel4.Text = "Disabled State";
            this.autoLabel4.ThemeStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            // 
            // Form1
            // 
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AllowDrop = true;
            this.ClientSize = new System.Drawing.Size(728, 582);
            this.Controls.Add(this.borderPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimumSize = this.Size;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.ShadowOpacity = ((byte)(0));
            this.Text = "Range Slider";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.borderPanel1.ResumeLayout(false);
            this.borderPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AutoLabel autoLabel1;
        private RangeSlider rangeSlider1;
        private RangeSlider rangeSlider3;
        private AutoLabel autoLabel2;
        private RangeSlider rangeSlider5;
        private AutoLabel autoLabel3;
        private RangeSlider rangeSlider6;
        private RangeSlider rangeSlider2;
        private RangeSlider rangeSlider4;
        private System.Windows.Forms.Panel borderPanel1;
        private AutoLabel autoLabel4;
        private AutoLabel autoLabel10;
        private Syncfusion.WinForms.ListView.SfComboBox sfComboBox1;
    }
}

