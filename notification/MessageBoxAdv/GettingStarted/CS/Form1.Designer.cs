#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_custom = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btn_warning = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btn_confirmation = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btn_infomsg = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btn_errormsg = new Syncfusion.Windows.Forms.ButtonAdv();
            this.themeComboBox = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.Resize = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.themeComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Description, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.95041F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.04958F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(802, 454);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Resize);
            this.panel2.Controls.Add(this.btn_custom);
            this.panel2.Controls.Add(this.btn_warning);
            this.panel2.Controls.Add(this.btn_confirmation);
            this.panel2.Controls.Add(this.btn_infomsg);
            this.panel2.Controls.Add(this.btn_errormsg);
            this.panel2.Controls.Add(this.themeComboBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 399);
            this.panel2.TabIndex = 1;
            // 
            // btn_custom
            // 
            this.btn_custom.AccessibleName = "Button";
            this.btn_custom.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btn_custom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btn_custom.BeforeTouchSize = new System.Drawing.Size(162, 28);
            this.btn_custom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_custom.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_custom.ForeColor = System.Drawing.Color.White;
            this.btn_custom.Location = new System.Drawing.Point(316, 244);
            this.btn_custom.Name = "btn_custom";
            this.btn_custom.Size = new System.Drawing.Size(162, 28);
            this.btn_custom.TabIndex = 13;
            this.btn_custom.Text = "Custom Message";
            this.btn_custom.ThemeName = "Metro";
            this.btn_custom.UseVisualStyle = true;
            this.btn_custom.Click += new System.EventHandler(this.btn_custom_Click);
            // 
            // btn_warning
            // 
            this.btn_warning.AccessibleName = "Button";
            this.btn_warning.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btn_warning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btn_warning.BeforeTouchSize = new System.Drawing.Size(162, 28);
            this.btn_warning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_warning.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_warning.ForeColor = System.Drawing.Color.White;
            this.btn_warning.Location = new System.Drawing.Point(567, 124);
            this.btn_warning.Name = "btn_warning";
            this.btn_warning.Size = new System.Drawing.Size(162, 28);
            this.btn_warning.TabIndex = 12;
            this.btn_warning.Text = "Warning Message";
            this.btn_warning.ThemeName = "Metro";
            this.btn_warning.UseVisualStyle = true;
            this.btn_warning.Click += new System.EventHandler(this.btn_question_Click);
            // 
            // btn_confirmation
            // 
            this.btn_confirmation.AccessibleName = "Button";
            this.btn_confirmation.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btn_confirmation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btn_confirmation.BeforeTouchSize = new System.Drawing.Size(162, 28);
            this.btn_confirmation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmation.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_confirmation.ForeColor = System.Drawing.Color.White;
            this.btn_confirmation.Location = new System.Drawing.Point(66, 244);
            this.btn_confirmation.Name = "btn_confirmation";
            this.btn_confirmation.Size = new System.Drawing.Size(162, 28);
            this.btn_confirmation.TabIndex = 11;
            this.btn_confirmation.Text = "Confirmation Message";
            this.btn_confirmation.ThemeName = "Metro";
            this.btn_confirmation.UseVisualStyle = true;
            this.btn_confirmation.Click += new System.EventHandler(this.btn_warning_Click);
            // 
            // btn_infomsg
            // 
            this.btn_infomsg.AccessibleName = "Button";
            this.btn_infomsg.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btn_infomsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btn_infomsg.BeforeTouchSize = new System.Drawing.Size(162, 28);
            this.btn_infomsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_infomsg.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_infomsg.ForeColor = System.Drawing.Color.White;
            this.btn_infomsg.Location = new System.Drawing.Point(316, 124);
            this.btn_infomsg.Name = "btn_infomsg";
            this.btn_infomsg.Size = new System.Drawing.Size(162, 28);
            this.btn_infomsg.TabIndex = 10;
            this.btn_infomsg.Text = "Notification Message";
            this.btn_infomsg.ThemeName = "Metro";
            this.btn_infomsg.UseVisualStyle = true;
            this.btn_infomsg.Click += new System.EventHandler(this.btn_infomsg_Click);
            // 
            // btn_errormsg
            // 
            this.btn_errormsg.AccessibleName = "Button";
            this.btn_errormsg.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btn_errormsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btn_errormsg.BeforeTouchSize = new System.Drawing.Size(162, 28);
            this.btn_errormsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errormsg.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_errormsg.ForeColor = System.Drawing.Color.White;
            this.btn_errormsg.Location = new System.Drawing.Point(66, 124);
            this.btn_errormsg.Name = "btn_errormsg";
            this.btn_errormsg.Size = new System.Drawing.Size(162, 28);
            this.btn_errormsg.TabIndex = 9;
            this.btn_errormsg.Text = "Error Message";
            this.btn_errormsg.ThemeName = "Metro";
            this.btn_errormsg.UseVisualStyle = true;
            this.btn_errormsg.Click += new System.EventHandler(this.btn_errormsg_Click);
            // 
            // themeComboBox
            // 
            this.themeComboBox.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.themeComboBox.Location = new System.Drawing.Point(583, 32);
            this.themeComboBox.Name = "themeComboBox";
            this.themeComboBox.Size = new System.Drawing.Size(146, 28);
            this.themeComboBox.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.themeComboBox.TabIndex = 8;
            this.themeComboBox.SelectedIndexChanged += new System.EventHandler(this.themeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(461, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Theme";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Description.Location = new System.Drawing.Point(3, 0);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(796, 49);
            this.lbl_Description.TabIndex = 2;
            this.lbl_Description.Text = "This example illustrates displaying application-defined message and title with it" +
    "s combination of predefined buttons.";
            this.lbl_Description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Resize
            // 
            this.Resize.AutoSize = true;
            this.Resize.Location = new System.Drawing.Point(66, 32);
            this.Resize.Name = "Resize";
            this.Resize.Size = new System.Drawing.Size(64, 21);
            this.Resize.TabIndex = 14;
            this.Resize.Text = "CanResize";
            this.Resize.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionFont = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(802, 454);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowMaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Getting Started";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.themeComboBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.ListView.SfComboBox themeComboBox;
        private ButtonAdv btn_errormsg;
        private ButtonAdv btn_custom;
        private ButtonAdv btn_warning;
        private ButtonAdv btn_confirmation;
        private ButtonAdv btn_infomsg;
        private System.Windows.Forms.CheckBox Resize;
    }
}