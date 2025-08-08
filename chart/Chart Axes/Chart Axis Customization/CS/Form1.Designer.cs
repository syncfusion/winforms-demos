#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Chart;
using System;

namespace ChartAxisCustomization_2005
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
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.colorPickerButton1 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.comboBox_rotationAngle = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.comboBox_FontStyle = new System.Windows.Forms.ComboBox();
            this.colorPicker_TextColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.numericUpDown_FontSize = new System.Windows.Forms.NumericUpDown();
            this.comboBox_Fontfamily = new System.Windows.Forms.ComboBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.colorPickerButton2 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.colorPickerButton3 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBoxXAxis = new System.Windows.Forms.CheckBox();
            this.checkBoxYAxis = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FontSize)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(226))))), System.Drawing.Color.White);
            this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Raised;
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartArea.Watermark.TextColor = System.Drawing.SystemColors.ControlText;
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(226))))), System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(232)))), ((int)(((byte)(243))))));
            this.chartControl1.DataSourceName = "";
            this.chartControl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(226))))), System.Drawing.Color.AliceBlue);
            this.chartControl1.Legend.Location = new System.Drawing.Point(579, 77);
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(9, 7);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.BreakInfo.LineSpacing = 3D;
            this.chartControl1.PrimaryXAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight;
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl1.PrimaryXAxis.Title = "Peak Load hours";
            this.chartControl1.PrimaryYAxis.BreakInfo.LineSpacing = 3D;
            this.chartControl1.PrimaryYAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl1.PrimaryYAxis.Title = "Server load (MB)";
            this.chartControl1.Size = new System.Drawing.Size(700, 565);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "Peak Average Network loads";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "Peak Average Network loads";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ZoomOutIncrement = 1.5D;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox4.Location = new System.Drawing.Point(39, 196);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(136, 25);
            this.checkBox4.TabIndex = 78;
            this.checkBox4.Text = "Opposed Y-Axis";
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox5.Location = new System.Drawing.Point(39, 100);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(136, 25);
            this.checkBox5.TabIndex = 77;
            this.checkBox5.Text = "Opposed X-Axis";
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox2.Location = new System.Drawing.Point(39, 69);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(111, 25);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Invert X Axis";
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox3.Location = new System.Drawing.Point(39, 164);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(111, 25);
            this.checkBox3.TabIndex = 73;
            this.checkBox3.Text = "Invert Y Axis";
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label5.Location = new System.Drawing.Point(34, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 74;
            this.label5.Text = "Axes Position";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label14.Location = new System.Drawing.Point(35, 957);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(144, 25);
            this.label14.TabIndex = 111;
            this.label14.Text = "Minor Grid Line";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label15.Location = new System.Drawing.Point(39, 1207);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 21);
            this.label15.TabIndex = 117;
            this.label15.Text = "Color";
            // 
            // comboBox4
            // 
            this.comboBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox4.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "DashDot",
            "DashDotDot",
            "Custom"});
            this.comboBox4.Location = new System.Drawing.Point(39, 1098);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(165, 29);
            this.comboBox4.TabIndex = 116;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox7
            // 
            this.comboBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox7.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox7.Location = new System.Drawing.Point(39, 1167);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(165, 29);
            this.comboBox7.TabIndex = 115;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label16.Location = new System.Drawing.Point(39, 1138);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 21);
            this.label16.TabIndex = 114;
            this.label16.Text = "Width";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label17.Location = new System.Drawing.Point(39, 1068);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 21);
            this.label17.TabIndex = 113;
            this.label17.Text = "Style";
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.BackColor = System.Drawing.Color.DimGray;
            this.colorPickerButton1.BeforeTouchSize = new System.Drawing.Size(100, 30);
            this.colorPickerButton1.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.colorPickerButton1.IsBackStageButton = false;
            this.colorPickerButton1.Location = new System.Drawing.Point(39, 1235);
            this.colorPickerButton1.Name = "colorPickerButton1";
            this.colorPickerButton1.SelectedAsBackcolor = true;
            this.colorPickerButton1.SelectedColor = System.Drawing.Color.DimGray;
            this.colorPickerButton1.Size = new System.Drawing.Size(100, 30);
            this.colorPickerButton1.TabIndex = 14;
            this.colorPickerButton1.UseVisualStyleBackColor = true;
            this.colorPickerButton1.ColorSelected += new System.EventHandler(this.colorPickerButton1_ColorSelected);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox1.Location = new System.Drawing.Point(39, 994);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 25);
            this.checkBox1.TabIndex = 119;
            this.checkBox1.Text = "X Axis";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox6.Location = new System.Drawing.Point(39, 1027);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(67, 25);
            this.checkBox6.TabIndex = 120;
            this.checkBox6.Text = "Y Axis";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label19.Location = new System.Drawing.Point(35, 1287);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 25);
            this.label19.TabIndex = 121;
            this.label19.Text = "Axes Title";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label23.Location = new System.Drawing.Point(35, 1465);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 21);
            this.label23.TabIndex = 135;
            this.label23.Text = "Font Size";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label35.Location = new System.Drawing.Point(35, 1537);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(83, 21);
            this.label35.TabIndex = 129;
            this.label35.Text = "Font Color";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label36.Location = new System.Drawing.Point(35, 1617);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(83, 21);
            this.label36.TabIndex = 130;
            this.label36.Text = "Title Rotation Angle";
            // 
            // comboBox rotation angle
            //
            comboBox_rotationAngle.Cursor = System.Windows.Forms.Cursors.Hand;
            comboBox_rotationAngle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_rotationAngle.DropDownWidth = 200;
            comboBox_rotationAngle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            comboBox_rotationAngle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            comboBox_rotationAngle.Location = new System.Drawing.Point(39, 1645);
            comboBox_rotationAngle.Name = "comboBox_Fontfamily";
            comboBox_rotationAngle.Size = new System.Drawing.Size(165, 29);
            comboBox_rotationAngle.TabIndex = 130;
            comboBox_rotationAngle.DataSource = Enum.GetNames(typeof(AxisTitleRotationAngle));
            comboBox_rotationAngle.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label24.Location = new System.Drawing.Point(35, 1325);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(88, 21);
            this.label24.TabIndex = 131;
            this.label24.Text = "Font family";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label26.Location = new System.Drawing.Point(35, 1394);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(79, 21);
            this.label26.TabIndex = 134;
            this.label26.Text = "Font Style";
            // 
            // comboBox_FontStyle
            // 
            this.comboBox_FontStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_FontStyle.DropDownWidth = 200;
            this.comboBox_FontStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_FontStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox_FontStyle.FormattingEnabled = true;
            this.comboBox_FontStyle.Location = new System.Drawing.Point(39, 1423);
            this.comboBox_FontStyle.Name = "comboBox_FontStyle";
            this.comboBox_FontStyle.Size = new System.Drawing.Size(165, 29);
            this.comboBox_FontStyle.TabIndex = 132;
            this.comboBox_FontStyle.SelectedIndexChanged += new System.EventHandler(this.comboBox_FontStyle_SelectedIndexChanged);
            // 
            // colorPicker_TextColor
            // 
            this.colorPicker_TextColor.BackColor = System.Drawing.Color.Black;
            this.colorPicker_TextColor.BeforeTouchSize = new System.Drawing.Size(100, 30);
            this.colorPicker_TextColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPicker_TextColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPicker_TextColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPicker_TextColor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPicker_TextColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.colorPicker_TextColor.IsBackStageButton = false;
            this.colorPicker_TextColor.Location = new System.Drawing.Point(39, 1569);
            this.colorPicker_TextColor.Name = "colorPicker_TextColor";
            this.colorPicker_TextColor.SelectedAsBackcolor = true;
            this.colorPicker_TextColor.SelectedColor = System.Drawing.Color.Black;
            this.colorPicker_TextColor.Size = new System.Drawing.Size(100, 30);
            this.colorPicker_TextColor.TabIndex = 14;
            this.colorPicker_TextColor.UseVisualStyleBackColor = false;
            this.colorPicker_TextColor.ColorSelected += new System.EventHandler(this.colorPicker_TextColor_ColorSelected);
            // 
            // numericUpDown_FontSize
            // 
            this.numericUpDown_FontSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_FontSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown_FontSize.Location = new System.Drawing.Point(39, 1495);
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
            this.numericUpDown_FontSize.Size = new System.Drawing.Size(165, 29);
            this.numericUpDown_FontSize.TabIndex = 133;
            this.numericUpDown_FontSize.Value = new decimal(new int[] {
            8,
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
            this.comboBox_Fontfamily.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.comboBox_Fontfamily.Location = new System.Drawing.Point(39, 1354);
            this.comboBox_Fontfamily.Name = "comboBox_Fontfamily";
            this.comboBox_Fontfamily.Size = new System.Drawing.Size(165, 29);
            this.comboBox_Fontfamily.TabIndex = 130;
            this.comboBox_Fontfamily.SelectedIndexChanged += new System.EventHandler(this.comboBox_Fontfamily_SelectedIndexChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox7.Location = new System.Drawing.Point(39, 229);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(155, 25);
            this.checkBox7.TabIndex = 137;
            this.checkBox7.Text = "Inside Y-Axis Label";
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox8.Location = new System.Drawing.Point(39, 132);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(155, 25);
            this.checkBox8.TabIndex = 0;
            this.checkBox8.Text = "Inside X-Axis Label";
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.AutoScroll = true;
            this.panel5.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.colorPicker_TextColor);
            this.panel5.Controls.Add(this.colorPickerButton2);
            this.panel5.Controls.Add(this.label35);
            this.panel5.Controls.Add(this.label36);
            this.panel5.Controls.Add(this.comboBox_rotationAngle);
            this.panel5.Controls.Add(this.label23);
            this.panel5.Controls.Add(this.numericUpDown_FontSize);
            this.panel5.Controls.Add(this.colorPickerButton1);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.comboBox_FontStyle);
            this.panel5.Controls.Add(this.label26);
            this.panel5.Controls.Add(this.label24);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.comboBox_Fontfamily);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.comboBox7);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.comboBox5);
            this.panel5.Controls.Add(this.comboBox6);
            this.panel5.Controls.Add(this.comboBox4);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.colorPickerButton3);
            this.panel5.Controls.Add(this.checkBox3);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.checkBox1);
            this.panel5.Controls.Add(this.checkBox6);
            this.panel5.Controls.Add(this.comboBox3);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.comboBox2);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label25);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.checkBox7);
            this.panel5.Controls.Add(this.comboBox1);
            this.panel5.Controls.Add(this.checkBox2);
            this.panel5.Controls.Add(this.checkBox8);
            this.panel5.Controls.Add(this.checkBox5);
            this.panel5.Controls.Add(this.checkBox4);
            this.panel5.Controls.Add(this.checkBoxXAxis);
            this.panel5.Controls.Add(this.checkBoxYAxis);
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Location = new System.Drawing.Point(708, 7);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(251, 565);
            this.panel5.TabIndex = 2;
            // 
            // colorPickerButton2
            // 
            this.colorPickerButton2.BackColor = System.Drawing.Color.DimGray;
            this.colorPickerButton2.BeforeTouchSize = new System.Drawing.Size(100, 30);
            this.colorPickerButton2.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.colorPickerButton2.IsBackStageButton = false;
            this.colorPickerButton2.Location = new System.Drawing.Point(39, 905);
            this.colorPickerButton2.Name = "colorPickerButton2";
            this.colorPickerButton2.SelectedAsBackcolor = true;
            this.colorPickerButton2.SelectedColor = System.Drawing.Color.DimGray;
            this.colorPickerButton2.Size = new System.Drawing.Size(100, 30);
            this.colorPickerButton2.TabIndex = 14;
            this.colorPickerButton2.UseVisualStyleBackColor = true;
            this.colorPickerButton2.ColorSelected += new System.EventHandler(this.colorPickerButton2_ColorSelected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label6.Location = new System.Drawing.Point(39, 875);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 21);
            this.label6.TabIndex = 103;
            this.label6.Text = "Color";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label10.Location = new System.Drawing.Point(35, 704);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 25);
            this.label10.TabIndex = 101;
            this.label10.Text = "Major Grid Line";
            // 
            // comboBox5
            // 
            this.comboBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox5.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox5.Location = new System.Drawing.Point(39, 836);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(165, 29);
            this.comboBox5.TabIndex = 84;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // comboBox6
            // 
            this.comboBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox6.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "DashDot",
            "DashDotDot",
            "Custom"});
            this.comboBox6.Location = new System.Drawing.Point(39, 768);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(165, 29);
            this.comboBox6.TabIndex = 91;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label11.Location = new System.Drawing.Point(39, 806);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 21);
            this.label11.TabIndex = 82;
            this.label11.Text = "Width";
            // 
            // colorPickerButton3
            // 
            this.colorPickerButton3.AutoSize = true;
            this.colorPickerButton3.BackColor = System.Drawing.Color.DimGray;
            this.colorPickerButton3.BeforeTouchSize = new System.Drawing.Size(100, 30);
            this.colorPickerButton3.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.colorPickerButton3.IsBackStageButton = false;
            this.colorPickerButton3.Location = new System.Drawing.Point(39, 652);
            this.colorPickerButton3.Name = "colorPickerButton3";
            this.colorPickerButton3.SelectedAsBackcolor = true;
            this.colorPickerButton3.SelectedColor = System.Drawing.Color.DimGray;
            this.colorPickerButton3.Size = new System.Drawing.Size(100, 30);
            this.colorPickerButton3.TabIndex = 14;
            this.colorPickerButton3.UseVisualStyleBackColor = false;
            this.colorPickerButton3.ColorSelected += new System.EventHandler(this.colorPickerButton3_ColorSelected);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label12.Location = new System.Drawing.Point(39, 738);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 21);
            this.label12.TabIndex = 81;
            this.label12.Text = "Style";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label9.Location = new System.Drawing.Point(39, 623);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 21);
            this.label9.TabIndex = 99;
            this.label9.Text = "Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(39, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "Style";
            // 
            // comboBox3
            // 
            this.comboBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox3.Location = new System.Drawing.Point(39, 579);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(165, 29);
            this.comboBox3.TabIndex = 41;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(39, 545);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 40;
            this.label3.Text = "Height";
            // 
            // comboBox2
            // 
            this.comboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox2.Location = new System.Drawing.Point(39, 503);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(165, 29);
            this.comboBox2.TabIndex = 37;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(39, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "Width";
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label25.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label25.Location = new System.Drawing.Point(33, 265);
            this.label25.Name = "label25";
            this.label25.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label25.Size = new System.Drawing.Size(175, 29);
            this.label25.TabIndex = 72;
            this.label25.Text = "Customize Axes";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label8.Location = new System.Drawing.Point(35, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 25);
            this.label8.TabIndex = 100;
            this.label8.Text = "Line";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox1.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "DashDot",
            "DashDotDot",
            "Custom"});
            this.comboBox1.Location = new System.Drawing.Point(39, 433);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 29);
            this.comboBox1.TabIndex = 38;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBoxXAxis
            // 
            this.checkBoxXAxis.AutoSize = true;
            this.checkBoxXAxis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxXAxis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxXAxis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxXAxis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBoxXAxis.Location = new System.Drawing.Point(39, 302);
            this.checkBoxXAxis.Name = "checkBoxXAxis";
            this.checkBoxXAxis.Size = new System.Drawing.Size(67, 25);
            this.checkBoxXAxis.TabIndex = 109;
            this.checkBoxXAxis.Text = "X Axis";
            this.checkBoxXAxis.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxYAxis
            // 
            this.checkBoxYAxis.AutoSize = true;
            this.checkBoxYAxis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxYAxis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxYAxis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxYAxis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBoxYAxis.Location = new System.Drawing.Point(39, 333);
            this.checkBoxYAxis.Name = "checkBoxYAxis";
            this.checkBoxYAxis.Size = new System.Drawing.Size(67, 25);
            this.checkBoxYAxis.TabIndex = 110;
            this.checkBoxYAxis.Text = "Y Axis";
            this.checkBoxYAxis.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 584);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(688, 620);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Axis Customization";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FontSize)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox comboBox_FontStyle;
        private System.Windows.Forms.ComboBox comboBox_rotationAngle;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPicker_TextColor;
        private System.Windows.Forms.NumericUpDown numericUpDown_FontSize;
        private System.Windows.Forms.ComboBox comboBox_Fontfamily;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBoxXAxis;
        private System.Windows.Forms.CheckBox checkBoxYAxis;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton3;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton2;
    }
}

