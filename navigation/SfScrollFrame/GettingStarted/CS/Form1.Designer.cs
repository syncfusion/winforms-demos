#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace GettingStarted
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

            this.UnWireEvents();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.sfScrollFrame1 = new Syncfusion.WinForms.Controls.SfScrollFrame();
            this.panel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVerticalArrowPressedBackColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.btnVerticalArrowPressedForeColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.btnVerticalScrollBarBackColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.btnVerticalThumbPressedColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.btnVerticalThumbColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.btnVerticalThumbHoverColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.btnVerticalArrowHoverBackColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.btnVerticalArrowHoverForeColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.btnVerticalArrowBackColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.btnVerticalArrowForeColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnScrollBarBackColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.btnThumbPressedColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.btnThumbColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.btnThumbHoverColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.btnArrowButtonPressedBackColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.btnArrowButtonPressedForeColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.btnArrowButtonHoverBackColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.btnArrowButtonHoverForeColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.btnArrowButtonBackColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.btnArrowButtonForeColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(15, 15);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(620, 660);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // sfScrollFrame1
            // 
            this.sfScrollFrame1.Control = this.listView1;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.groupBox1);
            this.panel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel.Location = new System.Drawing.Point(625, 5);
            this.panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel.Name = "panel";
            this.panel.Padding = new System.Windows.Forms.Padding(4, 5, 14, 5);
            this.panel.Size = new System.Drawing.Size(515, 748);
            this.panel.TabIndex = 1;
            this.panel.TabStop = false;
            this.panel.Text = "Options";
            this.panel.AutoScrollMinSize = new System.Drawing.Size(0, 500);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(500, 910);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnVerticalArrowPressedBackColor);
            this.groupBox3.Controls.Add(this.btnVerticalArrowPressedForeColor);
            this.groupBox3.Controls.Add(this.btnVerticalScrollBarBackColor);
            this.groupBox3.Controls.Add(this.btnVerticalThumbPressedColor);
            this.groupBox3.Controls.Add(this.btnVerticalThumbColor);
            this.groupBox3.Controls.Add(this.btnVerticalThumbHoverColor);
            this.groupBox3.Controls.Add(this.btnVerticalArrowHoverBackColor);
            this.groupBox3.Controls.Add(this.btnVerticalArrowHoverForeColor);
            this.groupBox3.Controls.Add(this.btnVerticalArrowBackColor);
            this.groupBox3.Controls.Add(this.btnVerticalArrowForeColor);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(5, 360);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(490, 312);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vertical Scrollbar";
            // 
            // btnVerticalArrowPressedBackColor
            // 
            this.btnVerticalArrowPressedBackColor.BackColor = System.Drawing.SystemColors.Control;
            this.btnVerticalArrowPressedBackColor.BeforeTouchSize = new System.Drawing.Size(232, 40);
            this.btnVerticalArrowPressedBackColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.btnVerticalArrowPressedBackColor.IsBackStageButton = false;
            this.btnVerticalArrowPressedBackColor.Location = new System.Drawing.Point(249, 143);
            this.btnVerticalArrowPressedBackColor.Name = "btnVerticalArrowPressedBackColor";
            this.btnVerticalArrowPressedBackColor.Size = new System.Drawing.Size(232, 40);
            this.btnVerticalArrowPressedBackColor.TabIndex = 37;
            this.btnVerticalArrowPressedBackColor.Text = "ArrowPressedBackColor";
            // 
            // btnVerticalArrowPressedForeColor
            // 
            this.btnVerticalArrowPressedForeColor.BackColor = System.Drawing.SystemColors.Control;
            this.btnVerticalArrowPressedForeColor.BeforeTouchSize = new System.Drawing.Size(229, 40);
            this.btnVerticalArrowPressedForeColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.btnVerticalArrowPressedForeColor.IsBackStageButton = false;
            this.btnVerticalArrowPressedForeColor.Location = new System.Drawing.Point(11, 143);
            this.btnVerticalArrowPressedForeColor.Name = "btnVerticalArrowPressedForeColor";
            this.btnVerticalArrowPressedForeColor.Size = new System.Drawing.Size(229, 40);
            this.btnVerticalArrowPressedForeColor.TabIndex = 36;
            this.btnVerticalArrowPressedForeColor.Text = "ArrowPressedForeColor";
            // 
            // btnVerticalScrollBarBackColor
            // 
            this.btnVerticalScrollBarBackColor.BackColor = System.Drawing.SystemColors.Control;
            this.btnVerticalScrollBarBackColor.BeforeTouchSize = new System.Drawing.Size(234, 39);
            this.btnVerticalScrollBarBackColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.btnVerticalScrollBarBackColor.IsBackStageButton = false;
            this.btnVerticalScrollBarBackColor.Location = new System.Drawing.Point(249, 241);
            this.btnVerticalScrollBarBackColor.Name = "btnVerticalScrollBarBackColor";
            this.btnVerticalScrollBarBackColor.Size = new System.Drawing.Size(234, 39);
            this.btnVerticalScrollBarBackColor.TabIndex = 35;
            this.btnVerticalScrollBarBackColor.Text = "ScrollBarBackColor";
            // 
            // btnVerticalThumbPressedColor
            // 
            this.btnVerticalThumbPressedColor.BackColor = System.Drawing.SystemColors.Control;
            this.btnVerticalThumbPressedColor.BeforeTouchSize = new System.Drawing.Size(229, 40);
            this.btnVerticalThumbPressedColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.btnVerticalThumbPressedColor.IsBackStageButton = false;
            this.btnVerticalThumbPressedColor.Location = new System.Drawing.Point(11, 240);
            this.btnVerticalThumbPressedColor.Name = "btnVerticalThumbPressedColor";
            this.btnVerticalThumbPressedColor.Size = new System.Drawing.Size(229, 40);
            this.btnVerticalThumbPressedColor.TabIndex = 34;
            this.btnVerticalThumbPressedColor.Text = "ThumbPressedColor";
            // 
            // btnVerticalThumbColor
            // 
            this.btnVerticalThumbColor.BackColor = System.Drawing.SystemColors.Control;
            this.btnVerticalThumbColor.BeforeTouchSize = new System.Drawing.Size(232, 41);
            this.btnVerticalThumbColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.btnVerticalThumbColor.IsBackStageButton = false;
            this.btnVerticalThumbColor.Location = new System.Drawing.Point(249, 191);
            this.btnVerticalThumbColor.Name = "btnVerticalThumbColor";
            this.btnVerticalThumbColor.Size = new System.Drawing.Size(232, 41);
            this.btnVerticalThumbColor.TabIndex = 33;
            this.btnVerticalThumbColor.Text = "ThumbColor";
            // 
            // btnVerticalThumbHoverColor
            // 
            this.btnVerticalThumbHoverColor.BackColor = System.Drawing.SystemColors.Control;
            this.btnVerticalThumbHoverColor.BeforeTouchSize = new System.Drawing.Size(229, 41);
            this.btnVerticalThumbHoverColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.btnVerticalThumbHoverColor.IsBackStageButton = false;
            this.btnVerticalThumbHoverColor.Location = new System.Drawing.Point(11, 191);
            this.btnVerticalThumbHoverColor.Name = "btnVerticalThumbHoverColor";
            this.btnVerticalThumbHoverColor.Size = new System.Drawing.Size(229, 41);
            this.btnVerticalThumbHoverColor.TabIndex = 32;
            this.btnVerticalThumbHoverColor.Text = "ThumbHoverColor";
            // 
            // btnVerticalArrowHoverBackColor
            // 
            this.btnVerticalArrowHoverBackColor.BackColor = System.Drawing.SystemColors.Control;
            this.btnVerticalArrowHoverBackColor.BeforeTouchSize = new System.Drawing.Size(232, 38);
            this.btnVerticalArrowHoverBackColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.btnVerticalArrowHoverBackColor.IsBackStageButton = false;
            this.btnVerticalArrowHoverBackColor.Location = new System.Drawing.Point(249, 96);
            this.btnVerticalArrowHoverBackColor.Name = "btnVerticalArrowHoverBackColor";
            this.btnVerticalArrowHoverBackColor.Size = new System.Drawing.Size(232, 38);
            this.btnVerticalArrowHoverBackColor.TabIndex = 31;
            this.btnVerticalArrowHoverBackColor.Text = "ArrowHoverBackColor";
            // 
            // btnVerticalArrowHoverForeColor
            // 
            this.btnVerticalArrowHoverForeColor.BackColor = System.Drawing.SystemColors.Control;
            this.btnVerticalArrowHoverForeColor.BeforeTouchSize = new System.Drawing.Size(231, 38);
            this.btnVerticalArrowHoverForeColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.btnVerticalArrowHoverForeColor.IsBackStageButton = false;
            this.btnVerticalArrowHoverForeColor.Location = new System.Drawing.Point(11, 96);
            this.btnVerticalArrowHoverForeColor.Name = "btnVerticalArrowHoverForeColor";
            this.btnVerticalArrowHoverForeColor.Size = new System.Drawing.Size(231, 38);
            this.btnVerticalArrowHoverForeColor.TabIndex = 30;
            this.btnVerticalArrowHoverForeColor.Text = "ArrowHoverForeColor";
            // 
            // btnVerticalArrowBackColor
            // 
            this.btnVerticalArrowBackColor.BackColor = System.Drawing.SystemColors.Control;
            this.btnVerticalArrowBackColor.BeforeTouchSize = new System.Drawing.Size(232, 37);
            this.btnVerticalArrowBackColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.btnVerticalArrowBackColor.IsBackStageButton = false;
            this.btnVerticalArrowBackColor.Location = new System.Drawing.Point(249, 49);
            this.btnVerticalArrowBackColor.Name = "btnVerticalArrowBackColor";
            this.btnVerticalArrowBackColor.Size = new System.Drawing.Size(232, 37);
            this.btnVerticalArrowBackColor.TabIndex = 29;
            this.btnVerticalArrowBackColor.Text = "ArrowBackColor";
            // 
            // btnVerticalArrowForeColor
            // 
            this.btnVerticalArrowForeColor.BackColor = System.Drawing.SystemColors.Control;
            this.btnVerticalArrowForeColor.BeforeTouchSize = new System.Drawing.Size(233, 40);
            this.btnVerticalArrowForeColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.btnVerticalArrowForeColor.IsBackStageButton = false;
            this.btnVerticalArrowForeColor.Location = new System.Drawing.Point(9, 49);
            this.btnVerticalArrowForeColor.Name = "btnVerticalArrowForeColor";
            this.btnVerticalArrowForeColor.Size = new System.Drawing.Size(233, 40);
            this.btnVerticalArrowForeColor.TabIndex = 28;
            this.btnVerticalArrowForeColor.Text = "ArrowForeColor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnScrollBarBackColor);
            this.groupBox2.Controls.Add(this.btnThumbPressedColor);
            this.groupBox2.Controls.Add(this.btnThumbColor);
            this.groupBox2.Controls.Add(this.btnThumbHoverColor);
            this.groupBox2.Controls.Add(this.btnArrowButtonPressedBackColor);
            this.groupBox2.Controls.Add(this.btnArrowButtonPressedForeColor);
            this.groupBox2.Controls.Add(this.btnArrowButtonHoverBackColor);
            this.groupBox2.Controls.Add(this.btnArrowButtonHoverForeColor);
            this.groupBox2.Controls.Add(this.btnArrowButtonBackColor);
            this.groupBox2.Controls.Add(this.btnArrowButtonForeColor);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 45);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(490, 291);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Horizontal Scrollbar";
            // 
            // btnScrollBarBackColor
            // 
            this.btnScrollBarBackColor.BackColor = System.Drawing.SystemColors.Control;
            this.btnScrollBarBackColor.BeforeTouchSize = new System.Drawing.Size(232, 40);
            this.btnScrollBarBackColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.btnScrollBarBackColor.IsBackStageButton = false;
            this.btnScrollBarBackColor.Location = new System.Drawing.Point(249, 222);
            this.btnScrollBarBackColor.Name = "btnScrollBarBackColor";
            this.btnScrollBarBackColor.Size = new System.Drawing.Size(232, 40);
            this.btnScrollBarBackColor.TabIndex = 28;
            this.btnScrollBarBackColor.Text = "ScrollBarBackColor";
            // 
            // btnThumbPressedColor
            // 
            this.btnThumbPressedColor.BackColor = System.Drawing.SystemColors.Control;
            this.btnThumbPressedColor.BeforeTouchSize = new System.Drawing.Size(231, 40);
            this.btnThumbPressedColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.btnThumbPressedColor.IsBackStageButton = false;
            this.btnThumbPressedColor.Location = new System.Drawing.Point(9, 222);
            this.btnThumbPressedColor.Name = "btnThumbPressedColor";
            this.btnThumbPressedColor.Size = new System.Drawing.Size(231, 40);
            this.btnThumbPressedColor.TabIndex = 27;
            this.btnThumbPressedColor.Text = "ThumbPressedColor";
            // 
            // btnThumbColor
            // 
            this.btnThumbColor.BackColor = System.Drawing.SystemColors.Control;
            this.btnThumbColor.BeforeTouchSize = new System.Drawing.Size(232, 42);
            this.btnThumbColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.btnThumbColor.IsBackStageButton = false;
            this.btnThumbColor.Location = new System.Drawing.Point(249, 172);
            this.btnThumbColor.Name = "btnThumbColor";
            this.btnThumbColor.Size = new System.Drawing.Size(232, 42);
            this.btnThumbColor.TabIndex = 26;
            this.btnThumbColor.Text = "ThumbColor";
            // 
            // btnThumbHoverColor
            // 
            this.btnThumbHoverColor.BackColor = System.Drawing.SystemColors.Control;
            this.btnThumbHoverColor.BeforeTouchSize = new System.Drawing.Size(231, 42);
            this.btnThumbHoverColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.btnThumbHoverColor.IsBackStageButton = false;
            this.btnThumbHoverColor.Location = new System.Drawing.Point(9, 172);
            this.btnThumbHoverColor.Name = "btnThumbHoverColor";
            this.btnThumbHoverColor.Size = new System.Drawing.Size(231, 42);
            this.btnThumbHoverColor.TabIndex = 25;
            this.btnThumbHoverColor.Text = "ThumbHoverColor";
            // 
            // btnArrowButtonPressedBackColor
            // 
            this.btnArrowButtonPressedBackColor.BackColor = System.Drawing.SystemColors.Control;
            this.btnArrowButtonPressedBackColor.BeforeTouchSize = new System.Drawing.Size(232, 40);
            this.btnArrowButtonPressedBackColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.btnArrowButtonPressedBackColor.IsBackStageButton = false;
            this.btnArrowButtonPressedBackColor.Location = new System.Drawing.Point(249, 123);
            this.btnArrowButtonPressedBackColor.Name = "btnArrowButtonPressedBackColor";
            this.btnArrowButtonPressedBackColor.Size = new System.Drawing.Size(232, 40);
            this.btnArrowButtonPressedBackColor.TabIndex = 24;
            this.btnArrowButtonPressedBackColor.Text = "ArrowPressedBackColor";
            // 
            // btnArrowButtonPressedForeColor
            // 
            this.btnArrowButtonPressedForeColor.BackColor = System.Drawing.SystemColors.Control;
            this.btnArrowButtonPressedForeColor.BeforeTouchSize = new System.Drawing.Size(232, 40);
            this.btnArrowButtonPressedForeColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.btnArrowButtonPressedForeColor.IsBackStageButton = false;
            this.btnArrowButtonPressedForeColor.Location = new System.Drawing.Point(8, 123);
            this.btnArrowButtonPressedForeColor.Name = "btnArrowButtonPressedForeColor";
            this.btnArrowButtonPressedForeColor.Size = new System.Drawing.Size(232, 40);
            this.btnArrowButtonPressedForeColor.TabIndex = 23;
            this.btnArrowButtonPressedForeColor.Text = "ArrowPressedForeColor";
            // 
            // btnArrowButtonHoverBackColor
            // 
            this.btnArrowButtonHoverBackColor.BackColor = System.Drawing.SystemColors.Control;
            this.btnArrowButtonHoverBackColor.BeforeTouchSize = new System.Drawing.Size(232, 39);
            this.btnArrowButtonHoverBackColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.btnArrowButtonHoverBackColor.IsBackStageButton = false;
            this.btnArrowButtonHoverBackColor.Location = new System.Drawing.Point(249, 76);
            this.btnArrowButtonHoverBackColor.Name = "btnArrowButtonHoverBackColor";
            this.btnArrowButtonHoverBackColor.Size = new System.Drawing.Size(232, 39);
            this.btnArrowButtonHoverBackColor.TabIndex = 22;
            this.btnArrowButtonHoverBackColor.Text = "ArrowHoverBackColor";
            // 
            // btnArrowButtonHoverForeColor
            // 
            this.btnArrowButtonHoverForeColor.BackColor = System.Drawing.SystemColors.Control;
            this.btnArrowButtonHoverForeColor.BeforeTouchSize = new System.Drawing.Size(231, 39);
            this.btnArrowButtonHoverForeColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.btnArrowButtonHoverForeColor.IsBackStageButton = false;
            this.btnArrowButtonHoverForeColor.Location = new System.Drawing.Point(9, 76);
            this.btnArrowButtonHoverForeColor.Name = "btnArrowButtonHoverForeColor";
            this.btnArrowButtonHoverForeColor.Size = new System.Drawing.Size(231, 39);
            this.btnArrowButtonHoverForeColor.TabIndex = 21;
            this.btnArrowButtonHoverForeColor.Text = "ArrowHoverForeColor";
            // 
            // btnArrowButtonBackColor
            // 
            this.btnArrowButtonBackColor.BackColor = System.Drawing.SystemColors.Control;
            this.btnArrowButtonBackColor.BeforeTouchSize = new System.Drawing.Size(232, 37);
            this.btnArrowButtonBackColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.btnArrowButtonBackColor.IsBackStageButton = false;
            this.btnArrowButtonBackColor.Location = new System.Drawing.Point(249, 29);
            this.btnArrowButtonBackColor.Name = "btnArrowButtonBackColor";
            this.btnArrowButtonBackColor.Size = new System.Drawing.Size(232, 37);
            this.btnArrowButtonBackColor.TabIndex = 20;
            this.btnArrowButtonBackColor.Text = "ArrowBackColor";
            // 
            // btnArrowButtonForeColor
            // 
            this.btnArrowButtonForeColor.BackColor = System.Drawing.SystemColors.Control;
            this.btnArrowButtonForeColor.BeforeTouchSize = new System.Drawing.Size(231, 40);
            this.btnArrowButtonForeColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.btnArrowButtonForeColor.IsBackStageButton = false;
            this.btnArrowButtonForeColor.Location = new System.Drawing.Point(9, 29);
            this.btnArrowButtonForeColor.Name = "btnArrowButtonForeColor";
            this.btnArrowButtonForeColor.Size = new System.Drawing.Size(231, 40);
            this.btnArrowButtonForeColor.TabIndex = 19;
            this.btnArrowButtonForeColor.Text = "ArrowForeColor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new System.Drawing.Size(1300, 800);
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1200, 566);
            this.Name = "Form1";
            this.Text = "Getting Started";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private Syncfusion.WinForms.Controls.SfScrollFrame sfScrollFrame1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private Syncfusion.Windows.Forms.ColorPickerButton btnArrowButtonBackColor;
        private Syncfusion.Windows.Forms.ColorPickerButton btnArrowButtonForeColor;
        private Syncfusion.Windows.Forms.ColorPickerButton btnArrowButtonHoverBackColor;
        private Syncfusion.Windows.Forms.ColorPickerButton btnArrowButtonHoverForeColor;
        private Syncfusion.Windows.Forms.ColorPickerButton btnArrowButtonPressedForeColor;
        private Syncfusion.Windows.Forms.ColorPickerButton btnArrowButtonPressedBackColor;
        private Syncfusion.Windows.Forms.ColorPickerButton btnThumbColor;
        private Syncfusion.Windows.Forms.ColorPickerButton btnThumbHoverColor;
        private Syncfusion.Windows.Forms.ColorPickerButton btnScrollBarBackColor;
        private Syncfusion.Windows.Forms.ColorPickerButton btnThumbPressedColor;
        private Syncfusion.Windows.Forms.ColorPickerButton btnVerticalArrowForeColor;
        private Syncfusion.Windows.Forms.ColorPickerButton btnVerticalArrowBackColor;
        private Syncfusion.Windows.Forms.ColorPickerButton btnVerticalArrowHoverBackColor;
        private Syncfusion.Windows.Forms.ColorPickerButton btnVerticalArrowHoverForeColor;
        private Syncfusion.Windows.Forms.ColorPickerButton btnVerticalThumbColor;
        private Syncfusion.Windows.Forms.ColorPickerButton btnVerticalThumbHoverColor;
        private Syncfusion.Windows.Forms.ColorPickerButton btnVerticalScrollBarBackColor;
        private Syncfusion.Windows.Forms.ColorPickerButton btnVerticalThumbPressedColor;
        private Syncfusion.Windows.Forms.ColorPickerButton btnVerticalArrowPressedBackColor;
        private Syncfusion.Windows.Forms.ColorPickerButton btnVerticalArrowPressedForeColor;
    }
}

