#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Audit_Showcase_sample;
using Syncfusion.Windows.Forms;
using System;

namespace Audit_Showcase_sample
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.getInfoPanel = new System.Windows.Forms.Panel();
            this.AccountsCollection = new Syncfusion.WinForms.ListView.SfComboBox();
            this.EmploymentCollection = new Syncfusion.WinForms.ListView.SfComboBox();
            this.EducationCollection = new Syncfusion.WinForms.ListView.SfComboBox();
            this.MaritalCollection = new Syncfusion.WinForms.ListView.SfComboBox();
            this.OccupationCollection = new Syncfusion.WinForms.ListView.SfComboBox();
            this.GenderCollection = new Syncfusion.WinForms.ListView.SfComboBox();
            this.auditDescription = new System.Windows.Forms.Label();
            this.roundButton1 = new Audit_Showcase_sample.RoundButton();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.HoursTextValue = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.DeductionTextValue = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IncomeTextValue = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AgeTextValue = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.PredictedText = new System.Windows.Forms.Label();
            this.illustration = new System.Windows.Forms.Label();
            this.AuditPredicted = new System.Windows.Forms.Label();
            this.line1 = new Audit_Showcase_sample.Line();
            this.thumb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.getInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmploymentCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EducationCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaritalCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OccupationCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenderCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursTextValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeductionTextValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeTextValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeTextValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumb)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // getInfoPanel
            // 
            this.getInfoPanel.AutoSize = true;
            this.getInfoPanel.Controls.Add(this.AccountsCollection);
            this.getInfoPanel.Controls.Add(this.EmploymentCollection);
            this.getInfoPanel.Controls.Add(this.EducationCollection);
            this.getInfoPanel.Controls.Add(this.MaritalCollection);
            this.getInfoPanel.Controls.Add(this.OccupationCollection);
            this.getInfoPanel.Controls.Add(this.GenderCollection);
            this.getInfoPanel.Controls.Add(this.auditDescription);
            this.getInfoPanel.Controls.Add(this.roundButton1);
            this.getInfoPanel.Controls.Add(this.label15);
            this.getInfoPanel.Controls.Add(this.label10);
            this.getInfoPanel.Controls.Add(this.label9);
            this.getInfoPanel.Controls.Add(this.label8);
            this.getInfoPanel.Controls.Add(this.label7);
            this.getInfoPanel.Controls.Add(this.HoursTextValue);
            this.getInfoPanel.Controls.Add(this.DeductionTextValue);
            this.getInfoPanel.Controls.Add(this.label6);
            this.getInfoPanel.Controls.Add(this.label5);
            this.getInfoPanel.Controls.Add(this.label4);
            this.getInfoPanel.Controls.Add(this.IncomeTextValue);
            this.getInfoPanel.Controls.Add(this.label3);
            this.getInfoPanel.Controls.Add(this.AgeTextValue);
            this.getInfoPanel.Controls.Add(this.label2);
            this.getInfoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.getInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.getInfoPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.getInfoPanel.Name = "getInfoPanel";
            this.getInfoPanel.Size = new System.Drawing.Size(705, 928);
            this.getInfoPanel.TabIndex = 0;
            // 
            // AccountsCollection
            // 
            this.AccountsCollection.BackColor = System.Drawing.Color.White;
            this.AccountsCollection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccountsCollection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountsCollection.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AccountsCollection.Location = new System.Drawing.Point(447, 708);
            this.AccountsCollection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AccountsCollection.Name = "AccountsCollection";
            this.AccountsCollection.Size = new System.Drawing.Size(251, 33);
            this.AccountsCollection.TabIndex = 40;
            // 
            // EmploymentCollection
            // 
            this.EmploymentCollection.BackColor = System.Drawing.Color.White;
            this.EmploymentCollection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmploymentCollection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmploymentCollection.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EmploymentCollection.Location = new System.Drawing.Point(45, 708);
            this.EmploymentCollection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmploymentCollection.Name = "EmploymentCollection";
            this.EmploymentCollection.Size = new System.Drawing.Size(256, 33);
            this.EmploymentCollection.TabIndex = 39;
            // 
            // EducationCollection
            // 
            this.EducationCollection.BackColor = System.Drawing.Color.White;
            this.EducationCollection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EducationCollection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EducationCollection.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EducationCollection.Location = new System.Drawing.Point(45, 585);
            this.EducationCollection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EducationCollection.Name = "EducationCollection";
            this.EducationCollection.Size = new System.Drawing.Size(256, 33);
            this.EducationCollection.TabIndex = 38;
            // 
            // MaritalCollection
            // 
            this.MaritalCollection.BackColor = System.Drawing.Color.White;
            this.MaritalCollection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaritalCollection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaritalCollection.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MaritalCollection.Location = new System.Drawing.Point(45, 462);
            this.MaritalCollection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaritalCollection.Name = "MaritalCollection";
            this.MaritalCollection.Size = new System.Drawing.Size(256, 33);
            this.MaritalCollection.TabIndex = 37;
            // 
            // OccupationCollection
            // 
            this.OccupationCollection.BackColor = System.Drawing.Color.White;
            this.OccupationCollection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OccupationCollection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OccupationCollection.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OccupationCollection.Location = new System.Drawing.Point(450, 214);
            this.OccupationCollection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OccupationCollection.Name = "OccupationCollection";
            this.OccupationCollection.Size = new System.Drawing.Size(251, 33);
            this.OccupationCollection.TabIndex = 36;
            // 
            // GenderCollection
            // 
            this.GenderCollection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GenderCollection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderCollection.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GenderCollection.Location = new System.Drawing.Point(45, 338);
            this.GenderCollection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GenderCollection.Name = "GenderCollection";
            this.GenderCollection.Size = new System.Drawing.Size(254, 33);
            this.GenderCollection.TabIndex = 35;
            // 
            // auditDescription
            // 
            this.auditDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auditDescription.ForeColor = System.Drawing.Color.DimGray;
            this.auditDescription.Location = new System.Drawing.Point(38, 38);
            this.auditDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.auditDescription.Name = "auditDescription";
            this.auditDescription.Size = new System.Drawing.Size(621, 94);
            this.auditDescription.TabIndex = 33;
            this.auditDescription.Text = "This dataset consists of fictional clients who have been audited. For each case a" +
    "n outcome is recorded (whether the taxpayer\'s claims had to be adjusted or not)." +
    " ";
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(59)))), ((int)(((byte)(41)))));
            this.roundButton1.BeforeTouchSize = new System.Drawing.Size(654, 65);
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.roundButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.roundButton1.IsBackStageButton = false;
            this.roundButton1.Location = new System.Drawing.Point(45, 815);
            this.roundButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(654, 65);
            this.roundButton1.TabIndex = 32;
            this.roundButton1.Text = "Predict, if Tax Adjustable?";
            this.roundButton1.Click += new System.EventHandler(this.button_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(39, 414);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 28);
            this.label15.TabIndex = 28;
            this.label15.Text = "Marital";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(444, 660);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 28);
            this.label10.TabIndex = 14;
            this.label10.Text = "Accounts";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(444, 169);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 28);
            this.label9.TabIndex = 13;
            this.label9.Text = "Occupation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(38, 660);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 28);
            this.label8.TabIndex = 12;
            this.label8.Text = "Employment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(39, 537);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 28);
            this.label7.TabIndex = 11;
            this.label7.Text = "Education";
            // 
            // HoursTextValue
            // 
            this.HoursTextValue.BeforeTouchSize = new System.Drawing.Size(254, 26);
            this.HoursTextValue.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.HoursTextValue.BorderColor = System.Drawing.Color.Silver;
            this.HoursTextValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HoursTextValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HoursTextValue.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursTextValue.IntegerValue = ((long)(12));
            this.HoursTextValue.Location = new System.Drawing.Point(450, 338);
            this.HoursTextValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HoursTextValue.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.HoursTextValue.Name = "HoursTextValue";
            this.HoursTextValue.NullString = "";
            this.HoursTextValue.Size = new System.Drawing.Size(250, 30);
            this.HoursTextValue.TabIndex = 46;
            this.HoursTextValue.Text = "12";
            // 
            // DeductionTextValue
            // 
            this.DeductionTextValue.BeforeTouchSize = new System.Drawing.Size(254, 26);
            this.DeductionTextValue.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.DeductionTextValue.BorderColor = System.Drawing.Color.Silver;
            this.DeductionTextValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeductionTextValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DeductionTextValue.IntegerValue = ((long)(10000));
            this.DeductionTextValue.Location = new System.Drawing.Point(447, 589);
            this.DeductionTextValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeductionTextValue.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.DeductionTextValue.Name = "DeductionTextValue";
            this.DeductionTextValue.NullString = "";
            this.DeductionTextValue.Size = new System.Drawing.Size(250, 26);
            this.DeductionTextValue.TabIndex = 45;
            this.DeductionTextValue.Text = "10,000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(38, 292);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(444, 292);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(10)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(444, 537);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Deduction";
            // 
            // IncomeTextValue
            // 
            this.IncomeTextValue.BeforeTouchSize = new System.Drawing.Size(254, 26);
            this.IncomeTextValue.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.IncomeTextValue.BorderColor = System.Drawing.Color.Silver;
            this.IncomeTextValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IncomeTextValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IncomeTextValue.IntegerValue = ((long)(20000));
            this.IncomeTextValue.Location = new System.Drawing.Point(447, 462);
            this.IncomeTextValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IncomeTextValue.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.IncomeTextValue.Name = "IncomeTextValue";
            this.IncomeTextValue.NullString = "";
            this.IncomeTextValue.Size = new System.Drawing.Size(250, 26);
            this.IncomeTextValue.TabIndex = 44;
            this.IncomeTextValue.Text = "20,000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(444, 414);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Income";
            // 
            // AgeTextValue
            // 
            this.AgeTextValue.BeforeTouchSize = new System.Drawing.Size(254, 26);
            this.AgeTextValue.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.AgeTextValue.BorderColor = System.Drawing.Color.Silver;
            this.AgeTextValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AgeTextValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AgeTextValue.IntegerValue = ((long)(20));
            this.AgeTextValue.Location = new System.Drawing.Point(44, 214);
            this.AgeTextValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AgeTextValue.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.AgeTextValue.Name = "AgeTextValue";
            this.AgeTextValue.NullString = "";
            this.AgeTextValue.Size = new System.Drawing.Size(254, 26);
            this.AgeTextValue.TabIndex = 43;
            this.AgeTextValue.Text = "20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(10)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(38, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.White;
            this.gradientPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.gradientPanel1.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.PredictedText);
            this.gradientPanel1.Controls.Add(this.illustration);
            this.gradientPanel1.Controls.Add(this.AuditPredicted);
            this.gradientPanel1.Controls.Add(this.line1);
            this.gradientPanel1.Controls.Add(this.thumb);
            this.gradientPanel1.Location = new System.Drawing.Point(750, 20);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(30, 20, 80, 50);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(609,850);
            this.gradientPanel1.TabIndex = 41;
            // 
            // PredictedText
            // 
            this.PredictedText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PredictedText.Location = new System.Drawing.Point(188, 554);
            this.PredictedText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PredictedText.Name = "PredictedText";
            this.PredictedText.Size = new System.Drawing.Size(650, 58);
            this.PredictedText.TabIndex = 29;
            // 
            // illustration
            // 
            this.illustration.AutoSize = true;
            this.illustration.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.illustration.ForeColor = System.Drawing.Color.DimGray;
            this.illustration.Location = new System.Drawing.Point(192, 29);
            this.illustration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.illustration.Name = "illustration";
            this.illustration.Size = new System.Drawing.Size(250, 45);
            this.illustration.TabIndex = 26;
            this.illustration.Text = "Predicted Result";
            // 
            // AuditPredicted
            // 
            this.AuditPredicted.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuditPredicted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.AuditPredicted.Location = new System.Drawing.Point(261, 446);
            this.AuditPredicted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AuditPredicted.Name = "AuditPredicted";
            this.AuditPredicted.Size = new System.Drawing.Size(234, 95);
            this.AuditPredicted.TabIndex = 28;
            // 
            // line1
            // 
            this.line1.LineColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(66, 102);
            this.line1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(525, 3);
            this.line1.TabIndex = 25;
            this.line1.Text = "line1";
            // 
            // thumb
            // 
            this.thumb.Location = new System.Drawing.Point(252, 240);
            this.thumb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thumb.Name = "thumb";
            this.thumb.Size = new System.Drawing.Size(243, 202);
            this.thumb.TabIndex = 27;
            this.thumb.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Style.Border.Color = System.Drawing.Color.LightGray;
            this.Style.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(176)))));
            this.Style.TitleBar.Height = 60;
            this.Style.TitleBar.CloseButtonForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Style.TitleBar.MaximizeButtonForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Style.TitleBar.MinimizeButtonForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Style.TitleBar.CloseButtonHoverForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Style.TitleBar.MaximizeButtonHoverForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Style.TitleBar.MinimizeButtonHoverForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Style.TitleBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Style.ShadowOpacity = 0;
            this.Style.InactiveShadowOpacity = 0;
            this.Text = "Audit Prediction";
            this.Style.TitleBar.ForeColor = System.Drawing.SystemColors.Window;
            string imagepath = "Resource\\";
            Bitmap img = new Bitmap(Image.FromFile(imagepath + "Icon.ico"));
            this.Icon = Icon.FromHandle(img.GetHicon());
            this.ClientSize = new System.Drawing.Size(1510, 928);
            this.Controls.Add(this.getInfoPanel);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.getInfoPanel.ResumeLayout(false);
            this.getInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmploymentCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EducationCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaritalCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OccupationCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenderCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursTextValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeductionTextValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeTextValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeTextValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void AgeTextValue_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(Convert.ToInt32(AgeTextValue.IntegerValue) < 17 || Convert.ToInt32(AgeTextValue.IntegerValue) > 97)
            {
                e.Cancel = true;
                this.errorProvider.SetError(AgeTextValue, "Please check your age");
            }
            else
            {
                this.errorProvider.SetError(AgeTextValue, "");
            }
        }

        private void IncomeTextValue_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Convert.ToInt32(IncomeTextValue.IntegerValue) < 0)
            {
                e.Cancel = true;
                this.errorProvider.SetError(IncomeTextValue, "Please check the amount");
            }
            else
            {
                this.errorProvider.SetError(IncomeTextValue, "");
            }
        }

        private void DeductionTextValue_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Convert.ToInt32(DeductionTextValue.IntegerValue) < 0)
            {
                e.Cancel = true;
                this.errorProvider.SetError(DeductionTextValue, "Please check the amount");
            }
            else
            {
                this.errorProvider.SetError(DeductionTextValue, "");
            }
        }

        private void HoursTextValue_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Convert.ToInt32(HoursTextValue.IntegerValue) < 0)
            {
                e.Cancel = true;
                this.errorProvider.SetError(HoursTextValue, "Please check the worked hours");
            }
            else
            {
                this.errorProvider.SetError(HoursTextValue, "");
            }
        }

        private void OnPaint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel getInfoPanel;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;        
        private System.Windows.Forms.Label label15;
        
        private RoundButton roundButton1;
               
        private Label auditDescription;
        private Syncfusion.WinForms.ListView.SfComboBox GenderCollection;
        private Syncfusion.WinForms.ListView.SfComboBox OccupationCollection;
        private Syncfusion.WinForms.ListView.SfComboBox MaritalCollection;
        private Syncfusion.WinForms.ListView.SfComboBox EducationCollection;
        private Syncfusion.WinForms.ListView.SfComboBox EmploymentCollection;
        private Syncfusion.WinForms.ListView.SfComboBox AccountsCollection;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Label illustration;
        private PictureBox thumb;
        private Line line1;
        private Label AuditPredicted;
        private Label PredictedText;
        private ErrorProvider errorProvider;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox AgeTextValue;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox IncomeTextValue;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox DeductionTextValue;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox HoursTextValue;
    }
}