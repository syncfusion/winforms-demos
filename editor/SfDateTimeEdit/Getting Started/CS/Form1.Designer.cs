#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Input;
using Syncfusion.WinForms.Input.Enums;
using Syncfusion.WinForms.Input.Events;
using System;
using System.Drawing;

namespace SfDateTimeEdit_2015
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
            this.controlPanel = new System.Windows.Forms.Panel();
            this.label9 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.Editing = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.DateRange = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.Pattern = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.Culture = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.label8 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.SpecialDates = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.label2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.label7 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.DisabledDates = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.label3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.label6 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.Mask = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.dateTimeEdit = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.label4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.label5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.Allownull = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.PatternCmb = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.CultureCmb = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.EditingModeCmb = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.DropdownPopupalignmentCmb = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.RightToLeftCmb = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.shwUpdownCmb = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.AllowMouseWheelCmb = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.AllowNullCmb = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatternCmb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CultureCmb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditingModeCmb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DropdownPopupalignmentCmb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightToLeftCmb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shwUpdownCmb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllowMouseWheelCmb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllowNullCmb)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.label9);
            this.controlPanel.Controls.Add(this.Editing);
            this.controlPanel.Controls.Add(this.DateRange);
            this.controlPanel.Controls.Add(this.Pattern);
            this.controlPanel.Controls.Add(this.Culture);
            this.controlPanel.Controls.Add(this.label8);
            this.controlPanel.Controls.Add(this.SpecialDates);
            this.controlPanel.Controls.Add(this.label2);
            this.controlPanel.Controls.Add(this.label7);
            this.controlPanel.Controls.Add(this.DisabledDates);
            this.controlPanel.Controls.Add(this.label3);
            this.controlPanel.Controls.Add(this.label6);
            this.controlPanel.Controls.Add(this.Mask);
            this.controlPanel.Controls.Add(this.dateTimeEdit);
            this.controlPanel.Controls.Add(this.label4);
            this.controlPanel.Controls.Add(this.label5);
            this.controlPanel.Controls.Add(this.Allownull);
            this.controlPanel.Location = new System.Drawing.Point(12, 70);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(813, 495);
            this.controlPanel.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(528, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 21);
            this.label9.TabIndex = 28;
            this.label9.Text = "(de-DE)";
            // 
            // Editing
            // 
            this.Editing.AutoSize = true;
            this.Editing.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editing.Location = new System.Drawing.Point(41, 51);
            this.Editing.Name = "Editing";
            this.Editing.Size = new System.Drawing.Size(80, 21);
            this.Editing.TabIndex = 19;
            this.Editing.Text = "Edit Mode";
            // 
            // DateRange
            //      
            this.DateRange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateRange.BackColor = System.Drawing.Color.White;            
            this.DateRange.DateTimeEditingMode = DateTimeEditingMode.Mask;
            this.DateRange.DateTimePattern = DateTimePattern.Custom;
            this.DateRange.DropDownButtonWidth = 30;
            this.DateRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateRange.ForeColor = System.Drawing.Color.Black;
            this.DateRange.Location = new System.Drawing.Point(474, 194);
            this.DateRange.Margin = new System.Windows.Forms.Padding(0);
            this.DateRange.MaxDateTime = new System.DateTime(2018, 3, 29, 0, 0, 0, 0);
            this.DateRange.MinDateTime = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.DateRange.Name = "DateRange";
            this.DateRange.Size = new System.Drawing.Size(291, 32);
            this.DateRange.TabIndex = 4;
            this.DateRange.ValidationOption = ValidationResetOption.Reset;
            this.DateRange.Watermark = "None";
            this.DateRange.DateTimeValidating += new ValidatingEventHandler(DateRange_Validating);

            // 
            // Pattern
            //            
        
            this.Pattern.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pattern.BackColor = System.Drawing.Color.White;            
            this.Pattern.DateTimeEditingMode = DateTimeEditingMode.Mask;
            this.Pattern.DateTimePattern = DateTimePattern.FullDateTime;
            this.Pattern.DropDownButtonWidth = 30;
            this.Pattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pattern.ForeColor = System.Drawing.Color.Black;          
            this.Pattern.Location = new System.Drawing.Point(44, 420);
            this.Pattern.Margin = new System.Windows.Forms.Padding(0);
            this.Pattern.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            this.Pattern.Name = "Pattern";
            this.Pattern.Size = new System.Drawing.Size(291, 32);
            this.Pattern.TabIndex = 7;
            this.Pattern.ValidationOption = ValidationResetOption.Reset;
            this.Pattern.Value = new System.DateTime(2017, 6, 27, 0, 0, 0, 0);
            this.Pattern.Watermark = "None";
            this.Pattern.DateTimePattern = DateTimePattern.LongDate;
            this.Pattern.DateTimeValidating += new ValidatingEventHandler(DateRange_Validating);

            // 
            // Culture
            //           
            this.Culture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Culture.BackColor = System.Drawing.Color.White;            
            this.Culture.DateTimeEditingMode = DateTimeEditingMode.Mask;
            this.Culture.DateTimePattern = DateTimePattern.LongDate;
            this.Culture.DropDownButtonWidth = 30;
            this.Culture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Culture.ForeColor = System.Drawing.Color.Black;
            this.Culture.Location = new System.Drawing.Point(474, 308);
            this.Culture.Margin = new System.Windows.Forms.Padding(0);
            this.Culture.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            this.Culture.Name = "Culture";
            this.Culture.Size = new System.Drawing.Size(291, 32);
            this.Culture.TabIndex = 6;
            this.Culture.ValidationOption = ValidationResetOption.Reset;
            this.Culture.Value = new System.DateTime(2017, 6, 27, 0, 0, 0, 0);
            this.Culture.DateTimePattern = DateTimePattern.LongDate;
            this.Culture.Culture = System.Globalization.CultureInfo.CreateSpecificCulture("de-DE");
            this.Culture.DateTimeValidating += new ValidatingEventHandler(DateRange_Validating);


            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(470, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 21);
            this.label8.TabIndex = 26;
            this.label8.Text = "Disabled Dates";
            // 
            // SpecialDates
            //          
            this.SpecialDates.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SpecialDates.BackColor = System.Drawing.Color.White;            
            this.SpecialDates.DateTimeEditingMode = DateTimeEditingMode.Mask;
            this.SpecialDates.DateTimePattern = DateTimePattern.Custom;
            this.SpecialDates.DropDownButtonWidth = 30;       
            this.SpecialDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecialDates.ForeColor = System.Drawing.Color.Black;          
            this.SpecialDates.Location = new System.Drawing.Point(44, 308);
            this.SpecialDates.Margin = new System.Windows.Forms.Padding(0);
            this.SpecialDates.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            this.SpecialDates.Name = "SpecialDates";         
            this.SpecialDates.Size = new System.Drawing.Size(291, 32);
            this.SpecialDates.TabIndex = 5;
            this.SpecialDates.ValidationOption = ValidationResetOption.Reset;
            this.SpecialDates.Value = new System.DateTime(2017, 6, 27, 0, 0, 0, 0);
            this.SpecialDates.MonthCalendar.DrawCell += MonthCalendar_DrawCell;
            this.SpecialDates.Value = new DateTime(2017, 12, 21);
            this.SpecialDates.DateTimeValidating += new ValidatingEventHandler(DateRange_Validating);

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(470, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Watermark";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "DateTimePattern";
            // 
            // DisabledDates
            // 
          
            this.DisabledDates.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DisabledDates.BackColor = System.Drawing.Color.White;            
            this.DisabledDates.DateTimeEditingMode = DateTimeEditingMode.Mask;
            this.DisabledDates.DateTimePattern = DateTimePattern.Custom;
            this.DisabledDates.DropDownButtonWidth = 30;
            this.DisabledDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisabledDates.ForeColor = System.Drawing.Color.Black;
            this.DisabledDates.Location = new System.Drawing.Point(474, 420);
            this.DisabledDates.Margin = new System.Windows.Forms.Padding(0);           
            this.DisabledDates.Name = "DisabledDates";      
            this.DisabledDates.Size = new System.Drawing.Size(291, 32);
            this.DisabledDates.TabIndex = 8;
            this.DisabledDates.ValidationOption = ValidationResetOption.Reset;
            this.DisabledDates.Value = new System.DateTime(2017, 6, 27, 0, 0, 0, 0);
            this.DisabledDates.MonthCalendar.TrailingDatesVisible = false;
            this.DisabledDates.MonthCalendar.NumberOfWeeksInView = 5;
            this.DisabledDates.DateTimeValidating += new ValidatingEventHandler(DateRange_Validating);


            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mask Mode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(470, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Culture";
            // 
            // Mask
            // 
           
            this.Mask.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Mask.BackColor = System.Drawing.Color.White;            
            this.Mask.DateTimeEditingMode = DateTimeEditingMode.Mask;
            this.Mask.DateTimePattern = DateTimePattern.Custom;
            this.Mask.DropDownButtonWidth = 30;
            this.Mask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mask.ForeColor = System.Drawing.Color.Black;
            this.Mask.Location = new System.Drawing.Point(44, 194);
            this.Mask.Margin = new System.Windows.Forms.Padding(0);
            this.Mask.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            this.Mask.Name = "Mask";        
            this.Mask.Size = new System.Drawing.Size(291, 32);
            this.Mask.TabIndex = 3;
            this.Mask.ValidationOption = ValidationResetOption.Reset;
            this.Mask.Value = new System.DateTime(2017, 6, 27, 0, 0, 0, 0);
            this.Mask.DateTimeValidating += new ValidatingEventHandler(DateRange_Validating);

            // 
            // dateTimeEdit
            // 
            this.dateTimeEdit.AllowNull = true;
            this.dateTimeEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimeEdit.BackColor = System.Drawing.Color.White;            
            this.dateTimeEdit.DateTimeEditingMode = DateTimeEditingMode.Default;
            this.dateTimeEdit.DateTimePattern = DateTimePattern.Custom;
            this.dateTimeEdit.DropDownButtonWidth = 30;
            this.dateTimeEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeEdit.ForeColor = System.Drawing.Color.Black;
            this.dateTimeEdit.Location = new System.Drawing.Point(44, 85);
            this.dateTimeEdit.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimeEdit.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            this.dateTimeEdit.Name = "dateTimeEdit";
            this.dateTimeEdit.Size = new System.Drawing.Size(291, 32);
            this.dateTimeEdit.TabIndex = 1;
            this.dateTimeEdit.ValidationOption = ValidationResetOption.Reset;
            this.dateTimeEdit.Value = new System.DateTime(2017, 6, 27, 0, 0, 0, 0);
            this.dateTimeEdit.Watermark = "None";
            this.dateTimeEdit.DateTimeValidating += new ValidatingEventHandler(DateRange_Validating);

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(470, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Date Range";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Special Dates";
            // 
            // Allownull
            // 
            this.Allownull.AllowNull = true;
            this.Allownull.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Allownull.BackColor = System.Drawing.Color.White;            
            this.Allownull.DateTimeEditingMode = DateTimeEditingMode.Default;
            this.Allownull.DateTimePattern = DateTimePattern.Custom;
            this.Allownull.DropDownButtonWidth = 30;
            this.Allownull.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Allownull.ForeColor = System.Drawing.Color.Black;
            this.Allownull.Location = new System.Drawing.Point(473, 85);
            this.Allownull.Margin = new System.Windows.Forms.Padding(0);
            this.Allownull.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            this.Allownull.Name = "Allownull";           
            this.Allownull.Size = new System.Drawing.Size(291, 32);
            this.Allownull.TabIndex = 2;
            this.Allownull.ValidationOption = ValidationResetOption.Reset;
            this.Allownull.Value = null;
            this.Allownull.Watermark = "dd-mm-yyyy";
            this.Allownull.MonthCalendar.HighlightTodayCell = false;
            this.Allownull.ForeColor = ColorTranslator.FromHtml("#8f8f8f");
            this.Allownull.DateTimeValidating += new ValidatingEventHandler(DateRange_Validating);

           
            // 
            // CultureCmb
            // 
            this.CultureCmb.BackColor = System.Drawing.Color.White;
            this.CultureCmb.BeforeTouchSize = new System.Drawing.Size(224, 29);
            this.CultureCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CultureCmb.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CultureCmb.FlatStyle = Syncfusion.Windows.Forms.Tools.ComboFlatStyle.Flat;
            this.CultureCmb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CultureCmb.Location = new System.Drawing.Point(216, 167);
            this.CultureCmb.Name = "CultureCmb";
            this.CultureCmb.Size = new System.Drawing.Size(224, 29);
            this.CultureCmb.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.CultureCmb.TabIndex = 4;
            // 
            // EditingModeCmb
            // 
            this.EditingModeCmb.BackColor = System.Drawing.Color.White;
            this.EditingModeCmb.BeforeTouchSize = new System.Drawing.Size(224, 29);
            this.EditingModeCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditingModeCmb.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.EditingModeCmb.FlatStyle = Syncfusion.Windows.Forms.Tools.ComboFlatStyle.Flat;
            this.EditingModeCmb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditingModeCmb.Location = new System.Drawing.Point(216, 41);
            this.EditingModeCmb.Name = "EditingModeCmb";
            this.EditingModeCmb.Size = new System.Drawing.Size(224, 29);
            this.EditingModeCmb.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.EditingModeCmb.TabIndex = 0;
            // 
            // DropdownPopupalignmentCmb
            // 
            this.DropdownPopupalignmentCmb.BackColor = System.Drawing.Color.White;
            this.DropdownPopupalignmentCmb.BeforeTouchSize = new System.Drawing.Size(224, 29);
            this.DropdownPopupalignmentCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropdownPopupalignmentCmb.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DropdownPopupalignmentCmb.FlatStyle = Syncfusion.Windows.Forms.Tools.ComboFlatStyle.Flat;
            this.DropdownPopupalignmentCmb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropdownPopupalignmentCmb.Location = new System.Drawing.Point(215, 451);
            this.DropdownPopupalignmentCmb.Name = "DropdownPopupalignmentCmb";
            this.DropdownPopupalignmentCmb.Size = new System.Drawing.Size(224, 29);
            this.DropdownPopupalignmentCmb.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.DropdownPopupalignmentCmb.TabIndex = 16;
            // 
            // RightToLeftCmb
            // 
            this.RightToLeftCmb.BackColor = System.Drawing.Color.White;
            this.RightToLeftCmb.BeforeTouchSize = new System.Drawing.Size(224, 29);
            this.RightToLeftCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RightToLeftCmb.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.RightToLeftCmb.FlatStyle = Syncfusion.Windows.Forms.Tools.ComboFlatStyle.Flat;
            this.RightToLeftCmb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightToLeftCmb.Location = new System.Drawing.Point(215, 384);
            this.RightToLeftCmb.Name = "RightToLeftCmb";
            this.RightToLeftCmb.Size = new System.Drawing.Size(224, 29);
            this.RightToLeftCmb.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.RightToLeftCmb.TabIndex = 12;
            // 
            // shwUpdownCmb
            // 
            this.shwUpdownCmb.BackColor = System.Drawing.Color.White;
            this.shwUpdownCmb.BeforeTouchSize = new System.Drawing.Size(224, 29);
            this.shwUpdownCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shwUpdownCmb.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.shwUpdownCmb.FlatStyle = Syncfusion.Windows.Forms.Tools.ComboFlatStyle.Flat;
            this.shwUpdownCmb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shwUpdownCmb.Location = new System.Drawing.Point(215, 314);
            this.shwUpdownCmb.Name = "shwUpdownCmb";
            this.shwUpdownCmb.Size = new System.Drawing.Size(224, 29);
            this.shwUpdownCmb.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.shwUpdownCmb.TabIndex = 10;
            
            // 
            // AllowNullCmb
            // 
            this.AllowNullCmb.BackColor = System.Drawing.Color.White;
            this.AllowNullCmb.BeforeTouchSize = new System.Drawing.Size(224, 29);
            this.AllowNullCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AllowNullCmb.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AllowNullCmb.FlatStyle = Syncfusion.Windows.Forms.Tools.ComboFlatStyle.Flat;
            this.AllowNullCmb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllowNullCmb.Location = new System.Drawing.Point(215, 41);
            this.AllowNullCmb.Name = "AllowNullCmb";
            this.AllowNullCmb.Size = new System.Drawing.Size(224, 29);
            this.AllowNullCmb.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.AllowNullCmb.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.autoLabel1);
            this.panel1.Controls.Add(this.comboBoxAdv1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 62);
            this.panel1.TabIndex = 30;
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(194, 21);
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Office2016Colorful",
            "Office2016Black",
            "Office2016White",
            "Office2016DarkGray",
            "Office2019Colorful",
            "HighContrastBlack"});
            this.comboBoxAdv1.Location = new System.Drawing.Point(666, 21);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(194, 21);
            this.comboBoxAdv1.TabIndex = 30;
            this.comboBoxAdv1.Text = "Office2016Colorful";
            // 
            // autoLabel1
            // 
            this.autoLabel1.Location = new System.Drawing.Point(583, 25);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(61, 13);
            this.autoLabel1.TabIndex = 31;
            this.autoLabel1.Text = "Visual Style";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(877, 644);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.controlPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Getting Started";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.MaximizeBox = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            ((System.ComponentModel.ISupportInitialize)(this.PatternCmb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CultureCmb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditingModeCmb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DropdownPopupalignmentCmb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightToLeftCmb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shwUpdownCmb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllowMouseWheelCmb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllowNullCmb)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            this.ResumeLayout(false);

        }

        private void AllowNullCmb_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv EditingModeCmb;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv PatternCmb;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv AllowNullCmb;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv AllowMouseWheelCmb;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv shwUpdownCmb;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv RightToLeftCmb;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv DropdownPopupalignmentCmb;
        /// <summary>
        /// Initialize the new instance if <see cref="SfDateTimeEdit"/>.
        /// </summary>
        private Syncfusion.WinForms.Input.SfDateTimeEdit dateTimeEdit;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv CultureCmb;
        private System.Windows.Forms.Panel controlPanel;
        private Syncfusion.WinForms.Input.SfDateTimeEdit Pattern;
        private Syncfusion.WinForms.Input.SfDateTimeEdit Culture;
        private Syncfusion.WinForms.Input.SfDateTimeEdit SpecialDates;
        private Syncfusion.WinForms.Input.SfDateTimeEdit DisabledDates;
        private Syncfusion.WinForms.Input.SfDateTimeEdit Mask;
        private Syncfusion.WinForms.Input.SfDateTimeEdit Allownull;
        private Syncfusion.Windows.Forms.Tools.AutoLabel label8;
        private Syncfusion.Windows.Forms.Tools.AutoLabel label7;
        private Syncfusion.Windows.Forms.Tools.AutoLabel label6;
        private Syncfusion.Windows.Forms.Tools.AutoLabel label5;
        private Syncfusion.Windows.Forms.Tools.AutoLabel label4;
        private Syncfusion.Windows.Forms.Tools.AutoLabel label3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel label2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel Editing;
        private Syncfusion.WinForms.Input.SfDateTimeEdit DateRange;
        private Syncfusion.Windows.Forms.Tools.AutoLabel label9;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
    }
}

