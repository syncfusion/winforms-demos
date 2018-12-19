using Syncfusion.WinForms.Input;
using System;
using System.Drawing;
using Syncfusion.Windows.Forms.Tools;

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
            this.moveDateTimeEdit1 = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.multiSelectionCombo = new ComboBoxAdv();
            this.cultureCmbBox = new ComboBoxAdv();
            this.culture_lbl = new System.Windows.Forms.Label();
            this.captionLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Movedate_lbl = new System.Windows.Forms.Label();
            this.SelectedDateLbl = new System.Windows.Forms.Label();
            this.sfCalendar = new Syncfusion.WinForms.Input.SfCalendar();
            this.ThemeCmb = new ComboBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(993, 54);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(992, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "The following sample demonstrates the default functionalities of the Calendar suc" +
    "h as date selection, easy navigation through multiple views by clicking header," +
    "move to date and visual style.";
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
            this.borderPanel1.Controls.Add(this.ThemeCmb);
            this.borderPanel1.Controls.Add(this.label3);
            this.borderPanel1.Controls.Add(this.moveDateTimeEdit1);
            this.borderPanel1.Controls.Add(this.multiSelectionCombo);
            this.borderPanel1.Controls.Add(this.cultureCmbBox);
            this.borderPanel1.Controls.Add(this.culture_lbl);
            this.borderPanel1.Controls.Add(this.captionLbl);
            this.borderPanel1.Controls.Add(this.label2);
            this.borderPanel1.Controls.Add(this.Movedate_lbl);
            this.borderPanel1.Controls.Add(this.SelectedDateLbl);
            this.borderPanel1.Controls.Add(this.sfCalendar);
            this.borderPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borderPanel1.Location = new System.Drawing.Point(0, 56);
            this.borderPanel1.Name = "borderPanel1";
            this.borderPanel1.Size = new System.Drawing.Size(993, 590);
            this.borderPanel1.TabIndex = 2;
            // 
            // moveDateTimeEdit1
            // 
            
            this.moveDateTimeEdit1.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask;
            this.moveDateTimeEdit1.DropDownButtonWidth = 30;
            this.moveDateTimeEdit1.DropDownPopupAlignment = Syncfusion.WinForms.Input.Enums.DropDownPopupAlignment.Left;
            this.moveDateTimeEdit1.DropDownSize = new System.Drawing.Size(260, 250);
            this.moveDateTimeEdit1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveDateTimeEdit1.ForeColor = System.Drawing.Color.Black;
            this.moveDateTimeEdit1.InterceptArrowKeys = true;
            this.moveDateTimeEdit1.Location = new System.Drawing.Point(739, 113);
            this.moveDateTimeEdit1.Name = "moveDateTimeEdit1";
            this.moveDateTimeEdit1.ReadOnly = false;
            this.moveDateTimeEdit1.ShowDropDown = true;
            this.moveDateTimeEdit1.ShowUpDown = false;
            this.moveDateTimeEdit1.Size = new System.Drawing.Size(156, 31);
            this.moveDateTimeEdit1.TabIndex = 2;
            this.moveDateTimeEdit1.Text = "sfDateTimeEdit1";
            this.moveDateTimeEdit1.ValidationOption = Syncfusion.WinForms.Input.Enums.ValidationResetOption.Reset;
            this.moveDateTimeEdit1.Watermark = "None";
            // 
            // multiSelectionCombo
            // 
            this.multiSelectionCombo.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiSelectionCombo.Items.AddRange(new object[] {
            "False",
            "True"});
            this.multiSelectionCombo.Location = new System.Drawing.Point(739, 226);
            this.multiSelectionCombo.Margin = new System.Windows.Forms.Padding(2);
            this.multiSelectionCombo.Name = "multiSelectionCombo";
            this.multiSelectionCombo.Size = new System.Drawing.Size(156, 28);
            this.multiSelectionCombo.TabIndex = 4;
            this.multiSelectionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.multiSelectionCombo.SelectedValueChanged += new System.EventHandler(this.MultiSelection_Changed);
            // 
            // cultureCmbBox
            // 
            this.cultureCmbBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.cultureCmbBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cultureCmbBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cultureCmbBox.Items.AddRange(new object[] {
            "en-US",
            "fr-FR",
            "de-DE",
            "pt-BR", "he-IL"});
            this.cultureCmbBox.Location = new System.Drawing.Point(739, 170);
            this.cultureCmbBox.Margin = new System.Windows.Forms.Padding(2);
            this.cultureCmbBox.MinimumSize = new System.Drawing.Size(156, 0);
            this.cultureCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cultureCmbBox.Name = "cultureCmbBox";
            this.cultureCmbBox.Size = new System.Drawing.Size(156, 28);
            this.cultureCmbBox.TabIndex = 3;
            this.cultureCmbBox.SelectedValueChanged += new System.EventHandler(this.culture_Changed);
            // 
            // culture_lbl
            // 
            this.culture_lbl.AutoSize = true;
            this.culture_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.culture_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.culture_lbl.Location = new System.Drawing.Point(563, 174);
            this.culture_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.culture_lbl.Name = "culture_lbl";
            this.culture_lbl.Size = new System.Drawing.Size(59, 20);
            this.culture_lbl.TabIndex = 2;
            this.culture_lbl.Text = "Culture";
            // 
            // captionLbl
            // 
            this.captionLbl.AutoSize = true;
            this.captionLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.captionLbl.Location = new System.Drawing.Point(115, 472);
            this.captionLbl.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.captionLbl.Name = "captionLbl";
            this.captionLbl.Size = new System.Drawing.Size(106, 20);
            this.captionLbl.TabIndex = 18;
            this.captionLbl.Text = "Selected Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(563, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Multiple Selection";
            // 
            // Movedate_lbl
            // 
            this.Movedate_lbl.AutoSize = true;
            this.Movedate_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movedate_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Movedate_lbl.Location = new System.Drawing.Point(563, 118);
            this.Movedate_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Movedate_lbl.Name = "Movedate_lbl";
            this.Movedate_lbl.Size = new System.Drawing.Size(102, 20);
            this.Movedate_lbl.TabIndex = 0;
            this.Movedate_lbl.Text = "Move to Date";
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
            // sfCalendar
            // 
            this.sfCalendar.AllowMultipleSelection = true;
            this.sfCalendar.BlackoutDates = null;
            this.sfCalendar.Culture = new System.Globalization.CultureInfo("en-US");
            this.sfCalendar.EnableAnimation = true;
            this.sfCalendar.FooterHeight = 30;
            this.sfCalendar.HeaderHeight = 70;
            this.sfCalendar.Location = new System.Drawing.Point(119, 99);
            this.sfCalendar.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.sfCalendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.sfCalendar.Name = "sfCalendar";
            this.sfCalendar.NavigationButtonAlignment = Syncfusion.WinForms.Input.Enums.NavigationButtonAlignment.Right;
            this.sfCalendar.NumberOfWeeksInView = 6;
            this.sfCalendar.SelectedDate = new System.DateTime(2018, 2, 6, 12, 53, 12, 656);
            this.sfCalendar.ShowAbbreviatedDayNames = true;
            this.sfCalendar.ShowFooter = false;
            this.sfCalendar.ShowNavigationButton = true;
            this.sfCalendar.ShowWeekNumbers = false;
            this.sfCalendar.Size = new System.Drawing.Size(378, 354);
            this.sfCalendar.SpecialDates = null;
            this.sfCalendar.TabIndex = 1;
            this.sfCalendar.Text = "sfCalendar1";
            this.sfCalendar.TrailingDatesVisible = true;
            // 
            // ThemeCmb
            // 
            this.ThemeCmb.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemeCmb.Items.AddRange(new object[] {
            "Office2016Colorful",
            "Office2016White",
            "Office2016Darkgray",
            "Office2016Black"});
            this.ThemeCmb.Location = new System.Drawing.Point(739, 288);
            this.ThemeCmb.Margin = new System.Windows.Forms.Padding(2);
            this.ThemeCmb.Name = "ThemeCmb";
            this.ThemeCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ThemeCmb.Size = new System.Drawing.Size(156, 28);
            this.ThemeCmb.TabIndex = 19;
            this.ThemeCmb.Text = "Office2016Colorful";
            this.ThemeCmb.SelectedIndexChanged += new System.EventHandler(this.ThemeCmb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(563, 291);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Visual Style";
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
            this.ClientSize = new System.Drawing.Size(993, 646);
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
            this.Text = "Getting Started";
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
        private System.Windows.Forms.Label captionLbl;
        private System.Windows.Forms.Label SelectedDateLbl;
        private Syncfusion.WinForms.Input.SfCalendar sfCalendar;
        private System.Windows.Forms.Label Movedate_lbl;
         private ComboBoxAdv cultureCmbBox;
        private System.Windows.Forms.Label culture_lbl;
        private System.Windows.Forms.Label label2;
        private ComboBoxAdv multiSelectionCombo;
        private SfDateTimeEdit moveDateTimeEdit1;
        private ComboBoxAdv ThemeCmb;
        private System.Windows.Forms.Label label3;
    }
}

