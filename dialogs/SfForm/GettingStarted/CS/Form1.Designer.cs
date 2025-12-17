#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Tools;
using System.Drawing;
using System.Windows.Forms;

namespace GettingStarted
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    partial class Form1
    {

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
            this.components = new System.ComponentModel.Container();
            this.trackBarEx1 = new Syncfusion.Windows.Forms.Tools.TrackBarEx(0, 10);
            this.comboBox1 = new Syncfusion.WinForms.ListView.SfComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBorderColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.label1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.label8 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.label7 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonBottom = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonMiddle = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonTop = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonRight = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonCenter = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonLeft = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.label4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.btnCaptionButtonForeColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.btnCaptionButtonBackColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.btnCaptionForeColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.btnCaptionBackColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBoxRoundedCorners = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxHelpButton = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxIcon = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.label6 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonLeft)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxRoundedCorners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxHelpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarEx1
            // 
            this.trackBarEx1.BackColor = System.Drawing.Color.White;
            this.trackBarEx1.BeforeTouchSize = new System.Drawing.Size(134, 20);
            this.trackBarEx1.DecreaseButtonSize = new System.Drawing.Size(0, 0);
            this.trackBarEx1.IncreaseButtonSize = new System.Drawing.Size(0, 0);
            this.trackBarEx1.Location = new System.Drawing.Point(25, 81);
            this.trackBarEx1.Name = "trackBarEx1";
            this.trackBarEx1.ShowButtons = false;
            this.trackBarEx1.Size = new System.Drawing.Size(134, 20);
            this.trackBarEx1.SmallChange = 2;
            this.trackBarEx1.Style = Syncfusion.Windows.Forms.Tools.TrackBarEx.Theme.Metro;
            this.trackBarEx1.TabIndex = 0;
            this.trackBarEx1.Text = "trackBarEx1";
            this.trackBarEx1.ThemeName = "Metro";
            this.trackBarEx1.TimerInterval = 100;
            this.trackBarEx1.Minimum = 1; 
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.comboBox1.Location = new System.Drawing.Point(578, 83);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 27);
            this.comboBox1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBorderColor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.trackBarEx1);
            this.panel1.Location = new System.Drawing.Point(437, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 182);
            this.panel1.TabIndex = 1;
            // 
            // btnBorderColor
            // 
            this.btnBorderColor.BeforeTouchSize = new System.Drawing.Size(134, 36);
            this.btnBorderColor.Location = new System.Drawing.Point(25, 119);
            this.btnBorderColor.Name = "btnBorderColor";
            this.btnBorderColor.Size = new System.Drawing.Size(134, 36);
            this.btnBorderColor.TabIndex = 3;
            this.btnBorderColor.Text = "Border Color";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thickness";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Border customization";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(200, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Vertical";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Horizontal";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.radioButtonBottom);
            this.panel2.Controls.Add(this.radioButtonMiddle);
            this.panel2.Controls.Add(this.radioButtonTop);
            this.panel2.Controls.Add(this.radioButtonRight);
            this.panel2.Controls.Add(this.radioButtonCenter);
            this.panel2.Controls.Add(this.radioButtonLeft);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnCaptionButtonForeColor);
            this.panel2.Controls.Add(this.btnCaptionButtonBackColor);
            this.panel2.Controls.Add(this.btnCaptionForeColor);
            this.panel2.Controls.Add(this.btnCaptionBackColor);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(50, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 324);
            this.panel2.TabIndex = 2;
            // 
            // radioButtonBottom
            // 
            this.radioButtonBottom.BeforeTouchSize = new System.Drawing.Size(125, 21);
            this.radioButtonBottom.DrawFocusRectangle = false;
            this.radioButtonBottom.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButtonBottom.Location = new System.Drawing.Point(15, 260);
            this.radioButtonBottom.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.radioButtonBottom.Name = "radioButtonBottom";
            this.radioButtonBottom.Size = new System.Drawing.Size(125, 21);
            this.radioButtonBottom.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonBottom.TabIndex = 2;
            this.radioButtonBottom.TabStop = false;
            this.radioButtonBottom.Text = "Bottom";
            this.radioButtonBottom.ThemeName = "Metro";
            this.radioButtonBottom.CheckChanged += new System.EventHandler(this.radioButtonBottom_CheckChanged);
            // 
            // radioButtonMiddle
            // 
            this.radioButtonMiddle.BeforeTouchSize = new System.Drawing.Size(125, 21);
            this.radioButtonMiddle.DrawFocusRectangle = false;
            this.radioButtonMiddle.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButtonMiddle.Location = new System.Drawing.Point(15, 240);
            this.radioButtonMiddle.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.radioButtonMiddle.Name = "radioButtonMiddle";
            this.radioButtonMiddle.Size = new System.Drawing.Size(125, 21);
            this.radioButtonMiddle.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonMiddle.TabIndex = 1;
            this.radioButtonMiddle.TabStop = false;
            this.radioButtonMiddle.Text = "Center";
            this.radioButtonMiddle.ThemeName = "Metro";
            this.radioButtonMiddle.CheckChanged += new System.EventHandler(this.radioButtonMiddle_CheckChanged);
            // 
            // radioButtonTop
            // 
            this.radioButtonTop.BeforeTouchSize = new System.Drawing.Size(125, 21);
            this.radioButtonTop.DrawFocusRectangle = false;
            this.radioButtonTop.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButtonTop.Location = new System.Drawing.Point(15, 220);
            this.radioButtonTop.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.radioButtonTop.Name = "radioButtonTop";
            this.radioButtonTop.Size = new System.Drawing.Size(125, 21);
            this.radioButtonTop.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonTop.TabIndex = 0;
            this.radioButtonTop.TabStop = false;
            this.radioButtonTop.Text = "Top";
            this.radioButtonTop.ThemeName = "Metro";
            this.radioButtonTop.CheckChanged += new System.EventHandler(this.radioButtonTop_CheckChanged);
            // 
            // radioButtonRight
            // 
            this.radioButtonRight.BeforeTouchSize = new System.Drawing.Size(127, 27);
            this.radioButtonRight.DrawFocusRectangle = false;
            this.radioButtonRight.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButtonRight.Location = new System.Drawing.Point(198, 260);
            this.radioButtonRight.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.radioButtonRight.Name = "radioButtonRight";
            this.radioButtonRight.Size = new System.Drawing.Size(127, 27);
            this.radioButtonRight.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonRight.TabIndex = 10;
            this.radioButtonRight.TabStop = false;
            this.radioButtonRight.Text = "Right";
            this.radioButtonRight.ThemeName = "Metro";
            this.radioButtonRight.CheckChanged += new System.EventHandler(this.radioButtonRight_CheckChanged_1);
            // 
            // radioButtonCenter
            // 
            this.radioButtonCenter.BeforeTouchSize = new System.Drawing.Size(127, 21);
            this.radioButtonCenter.DrawFocusRectangle = false;
            this.radioButtonCenter.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButtonCenter.Location = new System.Drawing.Point(198, 240);
            this.radioButtonCenter.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.radioButtonCenter.Name = "radioButtonCenter";
            this.radioButtonCenter.Size = new System.Drawing.Size(127, 21);
            this.radioButtonCenter.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonCenter.TabIndex = 9;
            this.radioButtonCenter.TabStop = false;
            this.radioButtonCenter.Text = "Center";
            this.radioButtonCenter.ThemeName = "Metro";
            this.radioButtonCenter.CheckChanged += new System.EventHandler(this.radioButtonCenter_CheckChanged_1);
            // 
            // radioButtonLeft
            // 
            this.radioButtonLeft.BeforeTouchSize = new System.Drawing.Size(127, 31);
            this.radioButtonLeft.Checked = true;
            this.radioButtonLeft.DrawFocusRectangle = false;
            this.radioButtonLeft.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButtonLeft.Location = new System.Drawing.Point(198, 215);
            this.radioButtonLeft.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.radioButtonLeft.Name = "radioButtonLeft";
            this.radioButtonLeft.Size = new System.Drawing.Size(127, 31);
            this.radioButtonLeft.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonLeft.TabIndex = 8;
            this.radioButtonLeft.Text = "Left";
            this.radioButtonLeft.ThemeName = "Metro";
            this.radioButtonLeft.CheckChanged += new System.EventHandler(this.radioButtonLeft_CheckChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Caption alignment";
            // 
            // btnCaptionButtonForeColor
            // 
            this.btnCaptionButtonForeColor.BeforeTouchSize = new System.Drawing.Size(189, 36);
            this.btnCaptionButtonForeColor.Location = new System.Drawing.Point(167, 96);
            this.btnCaptionButtonForeColor.Name = "btnCaptionButtonForeColor";
            this.btnCaptionButtonForeColor.Size = new System.Drawing.Size(189, 36);
            this.btnCaptionButtonForeColor.TabIndex = 4;
            this.btnCaptionButtonForeColor.Text = "Button ForeColor";
            // 
            // btnCaptionButtonBackColor
            // 
            this.btnCaptionButtonBackColor.BeforeTouchSize = new System.Drawing.Size(189, 36);
            this.btnCaptionButtonBackColor.Location = new System.Drawing.Point(167, 55);
            this.btnCaptionButtonBackColor.Name = "btnCaptionButtonBackColor";
            this.btnCaptionButtonBackColor.Size = new System.Drawing.Size(189, 36);
            this.btnCaptionButtonBackColor.TabIndex = 3;
            this.btnCaptionButtonBackColor.Text = "Button HoverBackColor";
            // 
            // btnCaptionForeColor
            // 
            this.btnCaptionForeColor.BeforeTouchSize = new System.Drawing.Size(143, 36);
            this.btnCaptionForeColor.Location = new System.Drawing.Point(7, 96);
            this.btnCaptionForeColor.Name = "btnCaptionForeColor";
            this.btnCaptionForeColor.Size = new System.Drawing.Size(143, 36);
            this.btnCaptionForeColor.TabIndex = 2;
            this.btnCaptionForeColor.Text = "ForeColor";
            // 
            // btnCaptionBackColor
            // 
            this.btnCaptionBackColor.BeforeTouchSize = new System.Drawing.Size(143, 36);
            this.btnCaptionBackColor.Location = new System.Drawing.Point(7, 55);
            this.btnCaptionBackColor.Name = "btnCaptionBackColor";
            this.btnCaptionBackColor.Size = new System.Drawing.Size(143, 36);
            this.btnCaptionBackColor.TabIndex = 1;
            this.btnCaptionBackColor.Text = "BackColor";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Title bar customization";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.checkBoxRoundedCorners);
            this.panel3.Controls.Add(this.checkBoxHelpButton);
            this.panel3.Controls.Add(this.checkBoxIcon);
            this.panel3.Location = new System.Drawing.Point(437, 352);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 122);
            this.panel3.TabIndex = 3;
            // 
            // checkBoxRoundedCorners
            // 
            this.checkBoxRoundedCorners.BeforeTouchSize = new System.Drawing.Size(175, 21);
            this.checkBoxRoundedCorners.Checked = true;
            this.checkBoxRoundedCorners.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRoundedCorners.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.checkBoxRoundedCorners.Location = new System.Drawing.Point(25, 78);
            this.checkBoxRoundedCorners.Name = "checkBoxRoundedCorners";
            this.checkBoxRoundedCorners.Size = new System.Drawing.Size(175, 21);
            this.checkBoxRoundedCorners.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxRoundedCorners.TabIndex = 3;
            this.checkBoxRoundedCorners.Text = "Allow Rounded Corners";
            this.checkBoxRoundedCorners.ThemeName = "Metro";
            this.checkBoxRoundedCorners.Visible = true;
            this.checkBoxRoundedCorners.CheckStateChanged += new System.EventHandler(this.checkBoxRoundedCorners_CheckStateChanged);
            // 
            // checkBoxHelpButton
            // 
            this.checkBoxHelpButton.BeforeTouchSize = new System.Drawing.Size(175, 21);
            this.checkBoxHelpButton.Checked = true;
            this.checkBoxHelpButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHelpButton.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.checkBoxHelpButton.Location = new System.Drawing.Point(25, 45);
            this.checkBoxHelpButton.Name = "checkBoxHelpButton";
            this.checkBoxHelpButton.Size = new System.Drawing.Size(175, 21);
            this.checkBoxHelpButton.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxHelpButton.TabIndex = 2;
            this.checkBoxHelpButton.Text = "Show help button";
            this.checkBoxHelpButton.ThemeName = "Metro";
            this.checkBoxHelpButton.CheckStateChanged += new System.EventHandler(this.checkBoxHelpButton_CheckStateChanged);
            // 
            // checkBoxIcon
            // 
            this.checkBoxIcon.BeforeTouchSize = new System.Drawing.Size(231, 21);
            this.checkBoxIcon.Checked = true;
            this.checkBoxIcon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIcon.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.checkBoxIcon.Location = new System.Drawing.Point(25, 14);
            this.checkBoxIcon.Name = "checkBoxIcon";
            this.checkBoxIcon.Size = new System.Drawing.Size(231, 21);
            this.checkBoxIcon.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxIcon.TabIndex = 1;
            this.checkBoxIcon.Text = "Show form icon in title bar";
            this.checkBoxIcon.ThemeName = "Metro";
            this.checkBoxIcon.CheckStateChanged += new System.EventHandler(this.checkBoxIcon_CheckStateChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(502, 34);
            this.label5.TabIndex = 6;
            this.label5.Text = "SfForm provides options to customize the appearance of each elements of the form " +
    "\nsuch as TitleBar and Border. This sample showcases some basic customizations.";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(575, 54);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Choose theme";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AllowRoundedCorners = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 521);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.HelpButton = true;
            this.MinimumSize = new System.Drawing.Size(762, 560);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Getting Started";
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonLeft)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxRoundedCorners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxHelpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TrackBarEx trackBarEx1;
        private Panel panel1;
        private AutoLabel label2;
        private AutoLabel label1;
        private Syncfusion.Windows.Forms.ColorPickerButton btnBorderColor;
        private Syncfusion.WinForms.ListView.SfComboBox comboBox1;
        private System.ComponentModel.IContainer components;
        private Panel panel2;
        private Syncfusion.Windows.Forms.ColorPickerButton btnCaptionForeColor;
        private Syncfusion.Windows.Forms.ColorPickerButton btnCaptionBackColor;
        private AutoLabel label3;
        private Syncfusion.Windows.Forms.ColorPickerButton btnCaptionButtonBackColor;
        private Syncfusion.Windows.Forms.ColorPickerButton btnCaptionButtonForeColor;
        private AutoLabel label4;
        private AutoLabel label8;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonBottom;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonMiddle;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonTop;
        private AutoLabel label7;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonRight;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonCenter;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonLeft;
        private Panel panel3;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxIcon;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxHelpButton;
        private AutoLabel label5;
        private AutoLabel label6;
        private CheckBoxAdv checkBoxRoundedCorners;
    }
}

