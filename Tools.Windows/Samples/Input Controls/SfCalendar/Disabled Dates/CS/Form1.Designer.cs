using Syncfusion.WinForms.Input.Events;
using System;

namespace SfCalendar_2015
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.borderPanel1 = new System.Windows.Forms.Panel();
            this.maxDateTimeEdit = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.minDateTimeEdit = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.minDate_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.captionLbl = new System.Windows.Forms.Label();
            this.sfCalendar = new Syncfusion.WinForms.Input.SfCalendar();
            this.panel1.SuspendLayout();
            this.borderPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 48);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(890, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(892, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 48);
            this.panel6.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(893, 1);
            this.panel2.TabIndex = 1;
            // 
            // borderPanel1
            // 
            this.borderPanel1.Controls.Add(this.maxDateTimeEdit);
            this.borderPanel1.Controls.Add(this.label3);
            this.borderPanel1.Controls.Add(this.minDateTimeEdit);
            this.borderPanel1.Controls.Add(this.minDate_lbl);
            this.borderPanel1.Controls.Add(this.label2);
            this.borderPanel1.Controls.Add(this.captionLbl);
            this.borderPanel1.Controls.Add(this.sfCalendar);
            this.borderPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borderPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderPanel1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.borderPanel1.Location = new System.Drawing.Point(0, 49);
            this.borderPanel1.Name = "borderPanel1";
            this.borderPanel1.Size = new System.Drawing.Size(893, 591);
            this.borderPanel1.TabIndex = 2;
            // 
            // maxDateTimeEdit
            //             
            this.maxDateTimeEdit.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask;
            this.maxDateTimeEdit.DropDownSize = new System.Drawing.Size(260, 250);
            this.maxDateTimeEdit.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.maxDateTimeEdit.ForeColor = System.Drawing.Color.Black;
            this.maxDateTimeEdit.Location = new System.Drawing.Point(671, 172);
            this.maxDateTimeEdit.Margin = new System.Windows.Forms.Padding(2);
            this.maxDateTimeEdit.Name = "maxDateTimeEdit";
            this.maxDateTimeEdit.Size = new System.Drawing.Size(155, 29);
            this.maxDateTimeEdit.TabIndex = 3;
            this.maxDateTimeEdit.Text = "sfDateTimeEdit2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(556, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "MaxDate";
            // 
            // minDateTimeEdit
            //             
            this.minDateTimeEdit.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask;            
            this.minDateTimeEdit.DropDownPopupAlignment = Syncfusion.WinForms.Input.Enums.DropDownPopupAlignment.Left;
            this.minDateTimeEdit.DropDownSize = new System.Drawing.Size(260, 250);
            this.minDateTimeEdit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minDateTimeEdit.Location = new System.Drawing.Point(671, 102);
            this.minDateTimeEdit.Margin = new System.Windows.Forms.Padding(2);
            this.minDateTimeEdit.Name = "minDateTimeEdit";
            this.minDateTimeEdit.Size = new System.Drawing.Size(155, 29);
            this.minDateTimeEdit.TabIndex = 2;
            this.minDateTimeEdit.Text = "sfDateTimeEdit1";
            this.minDateTimeEdit.ValidationOption = Syncfusion.WinForms.Input.Enums.ValidationResetOption.Reset;
            // 
            // minDate_lbl
            // 
            this.minDate_lbl.AutoSize = true;
            this.minDate_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minDate_lbl.Location = new System.Drawing.Point(555, 105);
            this.minDate_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minDate_lbl.Name = "minDate_lbl";
            this.minDate_lbl.Size = new System.Drawing.Size(68, 20);
            this.minDate_lbl.TabIndex = 21;
            this.minDate_lbl.Text = "MinDate";
            this.minDate_lbl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(178, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 20;
            // 
            // captionLbl
            // 
            this.captionLbl.AutoSize = true;
            this.captionLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.captionLbl.Location = new System.Drawing.Point(66, 462);
            this.captionLbl.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.captionLbl.Name = "captionLbl";
            this.captionLbl.Size = new System.Drawing.Size(106, 20);
            this.captionLbl.TabIndex = 19;
            this.captionLbl.Text = "Selected Date:";
            // 
            // sfCalendar
            //
            this.sfCalendar.Location = new System.Drawing.Point(70, 86);            
            this.sfCalendar.Name = "sfCalendar";            
            this.sfCalendar.NumberOfWeeksInView = 5;   
            this.sfCalendar.ShowFooter = false;            
            this.sfCalendar.Size = new System.Drawing.Size(420, 354);            
            this.sfCalendar.TabIndex = 1;
            this.sfCalendar.Text = "sfCalendar1";
            this.sfCalendar.TrailingDatesVisible = false;
            this.sfCalendar.SelectionChanged += new SelectionChangedEventHandler(this.sfCalendar_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BorderThickness = 10;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.CaptionBarHeight = 45;
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.CaptionFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(893, 640);
            this.Controls.Add(this.borderPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = this.Size;
            this.MetroColor = System.Drawing.Color.Empty;
            this.MinimumSize = this.Size;
            this.Name = "Form1";
            this.ShowMaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disabled Dates";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.borderPanel1.ResumeLayout(false);
            this.borderPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

      
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel borderPanel1;
        private Syncfusion.WinForms.Input.SfCalendar sfCalendar;
        private System.Windows.Forms.Label captionLbl;
        private System.Windows.Forms.Label label2;
        private Syncfusion.WinForms.Input.SfDateTimeEdit maxDateTimeEdit;
        private System.Windows.Forms.Label label3;
        private Syncfusion.WinForms.Input.SfDateTimeEdit minDateTimeEdit;
        private System.Windows.Forms.Label minDate_lbl;
    }
}

