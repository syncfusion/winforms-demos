#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
namespace ChartLabels_2005
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox_StringAlign = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.colorPicker_TextColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.comboBox_DateFormat = new System.Windows.Forms.ComboBox();
            this.comboBox_datesHidden = new System.Windows.Forms.ComboBox();
            this.numericUpDown_FontSize = new System.Windows.Forms.NumericUpDown();
            this.comboBox_Fontfamily = new System.Windows.Forms.ComboBox();
            this.comboBox_FontStyle = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_DoubleFormat = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.radioButton_ChartFormatAxisLabel = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.comboBox_LabelIntersectAction = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.comboBox_EdgeDrawingMode = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FontSize)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown1.Increment = new decimal(new int[] {
            225,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(31, 828);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(162, 27);
            this.numericUpDown1.TabIndex = 104;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.label4.Location = new System.Drawing.Point(27, 797);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 105;
            this.label4.Text = "Rotate Angle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(27, 650);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 101;
            this.label3.Text = "Label Alignment";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label15.Location = new System.Drawing.Point(25, 615);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 25);
            this.label15.TabIndex = 111;
            this.label15.Text = "Label Settings";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox1.Location = new System.Drawing.Point(31, 766);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 103;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox_StringAlign
            // 
            this.comboBox_StringAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_StringAlign.DropDownWidth = 100;
            this.comboBox_StringAlign.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_StringAlign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox_StringAlign.FormattingEnabled = true;
            this.comboBox_StringAlign.Items.AddRange(new object[] {
            "Center",
            "Near",
            "Far"});
            this.comboBox_StringAlign.Location = new System.Drawing.Point(31, 684);
            this.comboBox_StringAlign.Name = "comboBox_StringAlign";
            this.comboBox_StringAlign.Size = new System.Drawing.Size(162, 28);
            this.comboBox_StringAlign.TabIndex = 100;
            this.comboBox_StringAlign.SelectedIndexChanged += new System.EventHandler(this.comboBox_StringAlign_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label9.Location = new System.Drawing.Point(27, 727);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 102;
            this.label9.Text = "Label Rotate";
            // 
            // colorPicker_TextColor
            // 
            this.colorPicker_TextColor.BackColor = System.Drawing.Color.Black;
            this.colorPicker_TextColor.BeforeTouchSize = new System.Drawing.Size(100, 30);
            this.colorPicker_TextColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPicker_TextColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPicker_TextColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPicker_TextColor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPicker_TextColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.colorPicker_TextColor.IsBackStageButton = false;
            this.colorPicker_TextColor.Location = new System.Drawing.Point(31, 566);
            this.colorPicker_TextColor.Name = "colorPicker_TextColor";
            this.colorPicker_TextColor.SelectedAsBackcolor = true;
            this.colorPicker_TextColor.SelectedColor = System.Drawing.Color.Black;
            this.colorPicker_TextColor.Size = new System.Drawing.Size(100, 30);
            this.colorPicker_TextColor.TabIndex = 14;
            this.colorPicker_TextColor.UseVisualStyleBackColor = false;
            this.colorPicker_TextColor.ColorSelected += new System.EventHandler(this.colorPicker_TextColor_ColorSelected);
            // 
            // comboBox_DateFormat
            // 
            this.comboBox_DateFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DateFormat.DropDownWidth = 200;
            this.comboBox_DateFormat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_DateFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox_DateFormat.FormattingEnabled = true;
            this.comboBox_DateFormat.Items.AddRange(new object[] {
            "3/14/2001",
            "Wednesday, March 14, 2001",
            "3/14",
            "3/14/01",
            "03/14/01",
            "14-Mar",
            "14-Mar-01",
            "Mar-01",
            "March -01",
            "March 14,2001",
            "M",
            "M-01",
            "3/14/2001",
            "14-Mar-2001",
            "Mar",
            "Tue",
            "Tuesday",
            "Mar/12,Wed"});
            this.comboBox_DateFormat.Location = new System.Drawing.Point(31, 236);
            this.comboBox_DateFormat.Name = "comboBox_DateFormat";
            this.comboBox_DateFormat.Size = new System.Drawing.Size(165, 28);
            this.comboBox_DateFormat.TabIndex = 73;
            this.comboBox_DateFormat.SelectedIndexChanged += new System.EventHandler(this.comboBox_DateFormat_SelectedIndexChanged);
            // 
            // comboBox_datesHidden
            // 
            this.comboBox_datesHidden.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_datesHidden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox_datesHidden.FormattingEnabled = true;
            this.comboBox_datesHidden.Items.AddRange(new object[] {
            "M/d/yyyy",
            "dddd, MMMM dd, yyyy",
            "M/d",
            "M/d/yy",
            "MM/dd/yy",
            "d-MMM",
            "d-MMM-yy",
            "MMM-yy",
            "MMMM-yy",
            "MMMM d, yyyy",
            "MMMMM",
            "MMMMM-yy",
            "M/d/yyyy",
            "d-MMM-yyyy",
            "MMM",
            "ddd",
            "dddd",
            "MMM/dd, ddd"});
            this.comboBox_datesHidden.Location = new System.Drawing.Point(31, 235);
            this.comboBox_datesHidden.Name = "comboBox_datesHidden";
            this.comboBox_datesHidden.Size = new System.Drawing.Size(165, 29);
            this.comboBox_datesHidden.TabIndex = 92;
            this.comboBox_datesHidden.Visible = false;
            // 
            // numericUpDown_FontSize
            // 
            this.numericUpDown_FontSize.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_FontSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown_FontSize.Location = new System.Drawing.Point(31, 495);
            this.numericUpDown_FontSize.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.numericUpDown_FontSize.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown_FontSize.Name = "numericUpDown_FontSize";
            this.numericUpDown_FontSize.ReadOnly = true;
            this.numericUpDown_FontSize.Size = new System.Drawing.Size(165, 27);
            this.numericUpDown_FontSize.TabIndex = 82;
            this.numericUpDown_FontSize.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown_FontSize.ValueChanged += new System.EventHandler(this.numericUpDown_FontSize_ValueChanged);
            // 
            // comboBox_Fontfamily
            // 
            this.comboBox_Fontfamily.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_Fontfamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Fontfamily.DropDownWidth = 200;
            this.comboBox_Fontfamily.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Fontfamily.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox_Fontfamily.Items.AddRange(new object[] {
            "Agency FB",
            "Arial",
            "Book Antiqua",
            "Bookman Old Style",
            "Bradley Hand ITC",
            "Courier New",
            "Calibri",
            "Curlz MT",
            "Estrangelo Edessa",
            "Felix Titling",
            "Gautami",
            "Gill Sans MT Ext Condensed Bold",
            "Impact",
            "Microsoft Sans Serif",
            "MS Outlook",
            "Pristina",
            "Raavi",
            "Symbol",
            "Tahoma",
            "Times New Roman",
            "Verdana"});
            this.comboBox_Fontfamily.Location = new System.Drawing.Point(31, 348);
            this.comboBox_Fontfamily.Name = "comboBox_Fontfamily";
            this.comboBox_Fontfamily.Size = new System.Drawing.Size(165, 28);
            this.comboBox_Fontfamily.TabIndex = 79;
            this.comboBox_Fontfamily.SelectedIndexChanged += new System.EventHandler(this.font_SelectedIndexChanged);
            // 
            // comboBox_FontStyle
            // 
            this.comboBox_FontStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_FontStyle.DropDownWidth = 100;
            this.comboBox_FontStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_FontStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox_FontStyle.FormattingEnabled = true;
            this.comboBox_FontStyle.Location = new System.Drawing.Point(31, 421);
            this.comboBox_FontStyle.Name = "comboBox_FontStyle";
            this.comboBox_FontStyle.Size = new System.Drawing.Size(165, 28);
            this.comboBox_FontStyle.TabIndex = 81;
            this.comboBox_FontStyle.SelectedIndexChanged += new System.EventHandler(this.font_SelectedIndexChanged);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label35.Location = new System.Drawing.Point(27, 537);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(78, 20);
            this.label35.TabIndex = 77;
            this.label35.Text = "Font Color";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label10.Location = new System.Drawing.Point(26, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 81;
            this.label10.Text = "DateTime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label6.Location = new System.Drawing.Point(27, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 83;
            this.label6.Text = "Font Style";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(28, 55);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(150, 27);
            this.label12.TabIndex = 108;
            this.label12.Text = "X Axis Format";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label7.Location = new System.Drawing.Point(27, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 84;
            this.label7.Text = "Font Size";
            // 
            // comboBox_DoubleFormat
            // 
            this.comboBox_DoubleFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DoubleFormat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_DoubleFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox_DoubleFormat.FormattingEnabled = true;
            this.comboBox_DoubleFormat.Items.AddRange(new object[] {
            "1234",
            "1234.00",
            "$1234.00",
            "1234.000",
            "$1234.000"});
            this.comboBox_DoubleFormat.Location = new System.Drawing.Point(31, 125);
            this.comboBox_DoubleFormat.Name = "comboBox_DoubleFormat";
            this.comboBox_DoubleFormat.Size = new System.Drawing.Size(165, 28);
            this.comboBox_DoubleFormat.TabIndex = 82;
            this.comboBox_DoubleFormat.SelectedIndexChanged += new System.EventHandler(this.comboBox_DoubleFormat_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label11.Location = new System.Drawing.Point(27, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 83;
            this.label11.Text = "Double";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label5.Location = new System.Drawing.Point(27, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 80;
            this.label5.Text = "Font family";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label17.Location = new System.Drawing.Point(30, 1291);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(201, 75);
            this.label17.TabIndex = 111;
            this.label17.Text = "Select this option to restrict the number of labels rendered in the axis and also" +
    " customize it\'s formatting";
            // 
            // radioButton_ChartFormatAxisLabel
            // 
            this.radioButton_ChartFormatAxisLabel.AutoSize = true;
            this.radioButton_ChartFormatAxisLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.radioButton_ChartFormatAxisLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.radioButton_ChartFormatAxisLabel.Location = new System.Drawing.Point(31, 939);
            this.radioButton_ChartFormatAxisLabel.Name = "radioButton_ChartFormatAxisLabel";
            this.radioButton_ChartFormatAxisLabel.Size = new System.Drawing.Size(160, 24);
            this.radioButton_ChartFormatAxisLabel.TabIndex = 1;
            this.radioButton_ChartFormatAxisLabel.Text = "For Default Intervals";
            this.radioButton_ChartFormatAxisLabel.UseVisualStyleBackColor = true;
            this.radioButton_ChartFormatAxisLabel.CheckedChanged += new System.EventHandler(this.radioButton_ChartFormatAxisLabel_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.radioButton1.Location = new System.Drawing.Point(31, 1258);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(161, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "For Custom Intervals";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label16.Location = new System.Drawing.Point(28, 969);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(208, 72);
            this.label16.TabIndex = 110;
            this.label16.Text = "Select this option to customize \r\nthe label-text for the automatically\r\ngenerated" +
    " intervals using the \r\nChartFormatAxisLabel event";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.textBox1.Location = new System.Drawing.Point(33, 1059);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 179);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "-\r\nSale Starts\r\n-\r\n-\r\n-\r\nSale Ends\r\n-\r\n-\r\n";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox2.Location = new System.Drawing.Point(33, 1630);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(60, 24);
            this.checkBox2.TabIndex = 105;
            this.checkBox2.Text = "Hide";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label8.Location = new System.Drawing.Point(28, 1432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 99;
            this.label8.Text = "Intersect Action";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label31.Location = new System.Drawing.Point(28, 1599);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(97, 20);
            this.label31.TabIndex = 104;
            this.label31.Text = "Partial Labels";
            // 
            // comboBox_LabelIntersectAction
            // 
            this.comboBox_LabelIntersectAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_LabelIntersectAction.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_LabelIntersectAction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox_LabelIntersectAction.FormattingEnabled = true;
            this.comboBox_LabelIntersectAction.Location = new System.Drawing.Point(31, 1469);
            this.comboBox_LabelIntersectAction.Name = "comboBox_LabelIntersectAction";
            this.comboBox_LabelIntersectAction.Size = new System.Drawing.Size(165, 28);
            this.comboBox_LabelIntersectAction.TabIndex = 100;
            this.comboBox_LabelIntersectAction.SelectedIndexChanged += new System.EventHandler(this.comboBox_LabelIntersectAction_SelectedIndexChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label28.Location = new System.Drawing.Point(28, 1520);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(192, 20);
            this.label28.TabIndex = 102;
            this.label28.Text = "Edge Labels Drawing Mode";
            // 
            // comboBox_EdgeDrawingMode
            // 
            this.comboBox_EdgeDrawingMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_EdgeDrawingMode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_EdgeDrawingMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox_EdgeDrawingMode.FormattingEnabled = true;
            this.comboBox_EdgeDrawingMode.Items.AddRange(new object[] {
            "Center ",
            "Shift",
            "ClippingProtection "});
            this.comboBox_EdgeDrawingMode.Location = new System.Drawing.Point(31, 1554);
            this.comboBox_EdgeDrawingMode.Name = "comboBox_EdgeDrawingMode";
            this.comboBox_EdgeDrawingMode.Size = new System.Drawing.Size(165, 28);
            this.comboBox_EdgeDrawingMode.TabIndex = 103;
            this.comboBox_EdgeDrawingMode.SelectedIndexChanged += new System.EventHandler(this.comboBox_EdgeDrawingMode_SelectedIndexChanged);
            // 
            // chartControl1
            // 
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(243))))), System.Drawing.Color.White);
            this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Slice;
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 25, 10);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(226))))), System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(232)))), ((int)(((byte)(243))))));
            this.chartControl1.DataSourceName = "";
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Center;
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.Legend.Location = new System.Drawing.Point(311, 71);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top;
            this.chartControl1.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 2);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.BreakInfo.LineSpacing = 3D;
			this.chartControl1.PrimaryXAxis.Title = "Days";
			this.chartControl1.PrimaryYAxis.Title = "Visitors Count";
            this.chartControl1.PrimaryXAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight;
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.DateTimeFormat = "dddd";
            this.chartControl1.PrimaryXAxis.GridLineType.BackColor = System.Drawing.Color.DarkGray;
            this.chartControl1.PrimaryXAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.DarkGray;
            this.chartControl1.PrimaryXAxis.HidePartialLabels = true;
            this.chartControl1.PrimaryXAxis.LabelIntersectAction = Syncfusion.Windows.Forms.Chart.ChartLabelIntersectAction.MultipleRows;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryXAxis.Offset = 1D;
            this.chartControl1.PrimaryXAxis.Origin = 39358D;
            this.chartControl1.PrimaryXAxis.OriginDate = new System.DateTime(2007, 10, 3, 0, 0, 0, 0);
            this.chartControl1.PrimaryXAxis.Range = new Syncfusion.Windows.Forms.Chart.MinMaxInfo(0D, 8D, 1D);
            this.chartControl1.PrimaryXAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set;
            this.chartControl1.PrimaryXAxis.ValueType = Syncfusion.Windows.Forms.Chart.ChartValueType.DateTime;
            this.chartControl1.PrimaryYAxis.BreakInfo.LineSpacing = 3D;
            this.chartControl1.PrimaryYAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.GridLineType.BackColor = System.Drawing.Color.DarkGray;
            this.chartControl1.PrimaryYAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.DarkGray;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Range = new Syncfusion.Windows.Forms.Chart.MinMaxInfo(0D, 10000D, 1000D);
            this.chartControl1.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set;
            this.chartControl1.Size = new System.Drawing.Size(700, 570);
            this.chartControl1.TabIndex = 80;
            this.chartControl1.Text = "Visitors Count of Common Appliances";
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ChartFormatAxisLabel += new Syncfusion.Windows.Forms.Chart.ChartFormatAxisLabelEventHandler(this.chartControl1_ChartFormatAxisLabel);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.comboBox_LabelIntersectAction);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.comboBox_EdgeDrawingMode);
            this.panel1.Controls.Add(this.radioButton_ChartFormatAxisLabel);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.comboBox_DoubleFormat);
            this.panel1.Controls.Add(this.comboBox_StringAlign);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.colorPicker_TextColor);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.numericUpDown_FontSize);
            this.panel1.Controls.Add(this.comboBox_DateFormat);
            this.panel1.Controls.Add(this.label35);
            this.panel1.Controls.Add(this.comboBox_FontStyle);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBox_datesHidden);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.comboBox_Fontfamily);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(702, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 588);
            this.panel1.TabIndex = 81;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label13.Location = new System.Drawing.Point(22, 1382);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(213, 32);
            this.label13.TabIndex = 113;
            this.label13.Text = "Intersecting Labels";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(24, 882);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 32);
            this.label2.TabIndex = 112;
            this.label2.Text = "Custom Label Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text Formating";
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label22.Location = new System.Drawing.Point(28, 167);
            this.label22.Name = "label22";
            this.label22.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label22.Size = new System.Drawing.Size(136, 25);
            this.label22.TabIndex = 107;
            this.label22.Text = "Y Axis Format";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Location = new System.Drawing.Point(28, 278);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 25);
            this.label14.TabIndex = 110;
            this.label14.Text = "Font Settings";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 584);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(558, 620);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Label Customization";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FontSize)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_datesHidden;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_FontStyle;
        private System.Windows.Forms.ComboBox comboBox_DoubleFormat;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPicker_TextColor;
        private System.Windows.Forms.NumericUpDown numericUpDown_FontSize;
        private System.Windows.Forms.ComboBox comboBox_Fontfamily;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton_ChartFormatAxisLabel;
        private System.Windows.Forms.RadioButton radioButton1;
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox comboBox_EdgeDrawingMode;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_LabelIntersectAction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox_StringAlign;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox_DateFormat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
    }
}

