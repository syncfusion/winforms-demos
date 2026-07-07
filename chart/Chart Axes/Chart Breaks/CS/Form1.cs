#region Copyright Syncfusion Inc. 2001 - 2014
// Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Syncfusion.Windows.Forms.Chart;
using System.Drawing.Drawing2D;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;

namespace EssentialChartSample
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : MetroForm
    {
        # region Private Members

        private ChartAxis axis1 = new ChartAxis();
        private System.Windows.Forms.Panel panel1;
        Color[] color1 = new Color[]{Color.FromArgb(204, 96, 134), 
                Color.FromArgb(249, 174, 200),Color.FromArgb(204, 96, 134)};
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private ListBox listBox1;
        private Label label3;
        private Button button2;
        private ToolTip toolTip1;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label10;
        private NumericUpDown numericUpDownSpacing;
        private Label label9;
        private ComboBox comboBoxType;
        private Label label8;
        private Label label13;
        private ComboBox comboBoxStyle;
        private Label label12;
        private NumericUpDown numericUpDownWidth;
        private Label label11;
        private ColorPickerButton colorPickerButton2;
        private ColorPickerButton colorPickerButton1;
        private ChartControl chartControl1;
        private CheckBox checkBox2;
        private IContainer components;
        # endregion

        # region Main and Constructor
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            BorderColor = Color.FromArgb(0xFF, 0xCD, 0xCD, 0xCD);
            BorderThickness = 3;
            CaptionBarHeight = CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(75.0f);
            CaptionBarColor = Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2);
            CaptionFont = new Font("Segoe UI", 22.0f);
            CaptionForeColor = Color.White;
            CaptionAlign = HorizontalAlignment.Left;
            ShowIcon = false;
            CaptionButtonColor = Color.White;
            CaptionButtonHoverColor = Color.White;  
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.colorPickerButton1 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorPickerButton2 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxStyle = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpacing = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpacing)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = DockStyle.Right;
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.colorPickerButton1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.colorPickerButton2);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.comboBoxStyle);
            this.panel1.Controls.Add(this.comboBoxType);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.numericUpDownWidth);
            this.panel1.Controls.Add(this.numericUpDownSpacing);
            this.panel1.Controls.Add(this.label11);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(700, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 586);
            this.panel1.TabIndex = 2;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox2.Location = new System.Drawing.Point(43, 66);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(177, 25);
            this.checkBox2.TabIndex = 24;
            this.checkBox2.Text = "Enable Break in Chart";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(43, 778);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "REMOVE BREAK";
            this.toolTip1.SetToolTip(this.button2, "Select Range to Remove");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.BackColor = System.Drawing.Color.Transparent;
            this.colorPickerButton1.BeforeTouchSize = new System.Drawing.Size(100, 30);
            this.colorPickerButton1.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colorPickerButton1.IsBackStageButton = false;
            this.colorPickerButton1.Location = new System.Drawing.Point(43, 468);
            this.colorPickerButton1.Name = "colorPickerButton1";
            this.colorPickerButton1.SelectedAsBackcolor = true;
            this.colorPickerButton1.SelectedColor = System.Drawing.Color.Transparent;
            this.colorPickerButton1.Size = new System.Drawing.Size(100, 30);
            this.colorPickerButton1.TabIndex = 23;
            this.colorPickerButton1.UseVisualStyleBackColor = true;
            this.colorPickerButton1.ColorSelected += new System.EventHandler(this.colorPickerButton1_ColorSelected);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(43, 728);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "INSERT BREAK";
            this.toolTip1.SetToolTip(this.button1, "Select Range to Insert");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(39, 624);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Manual";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "300-500",
            "800-1100"});
            this.listBox1.Location = new System.Drawing.Point(43, 686);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(165, 24);
            this.listBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(40, 653);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Break Range";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(39, 522);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Behavior";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(40, 558);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Break Mode";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(43, 685);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(165, 27);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "Manual",
            "Auto"});
            this.comboBox1.Location = new System.Drawing.Point(43, 585);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(39, 627);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Auto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(40, 652);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Break Amount";
            // 
            // colorPickerButton2
            // 
            this.colorPickerButton2.BackColor = System.Drawing.Color.Black;
            this.colorPickerButton2.BeforeTouchSize = new System.Drawing.Size(100, 30);
            this.colorPickerButton2.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colorPickerButton2.IsBackStageButton = false;
            this.colorPickerButton2.Location = new System.Drawing.Point(43, 397);
            this.colorPickerButton2.Name = "colorPickerButton2";
            this.colorPickerButton2.SelectedAsBackcolor = true;
            this.colorPickerButton2.SelectedColor = System.Drawing.Color.Black;
            this.colorPickerButton2.Size = new System.Drawing.Size(100, 30);
            this.colorPickerButton2.TabIndex = 22;
            this.colorPickerButton2.UseVisualStyleBackColor = true;
            this.colorPickerButton2.ColorSelected += new System.EventHandler(this.colorPickerButton2_ColorSelected);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(40, 438);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "Spacing Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(39, 30);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Appearance";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(39, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Line Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(40, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Line Color";
            // 
            // comboBoxStyle
            // 
            this.comboBoxStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxStyle.FormattingEnabled = true;
            this.comboBoxStyle.Location = new System.Drawing.Point(43, 331);
            this.comboBoxStyle.Name = "comboBoxStyle";
            this.comboBoxStyle.Size = new System.Drawing.Size(165, 28);
            this.comboBoxStyle.TabIndex = 19;
            this.comboBoxStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxStyle_SelectedIndexChanged);
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(43, 134);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(165, 28);
            this.comboBoxType.TabIndex = 10;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(40, 303);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Line Style";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(39, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Line Spacing";
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownWidth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDownWidth.Location = new System.Drawing.Point(44, 265);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(165, 27);
            this.numericUpDownWidth.TabIndex = 17;
            this.numericUpDownWidth.ValueChanged += new System.EventHandler(this.numericUpDownWidth_ValueChanged);
            // 
            // numericUpDownSpacing
            // 
            this.numericUpDownSpacing.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownSpacing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDownSpacing.Location = new System.Drawing.Point(43, 199);
            this.numericUpDownSpacing.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSpacing.Name = "numericUpDownSpacing";
            this.numericUpDownSpacing.Size = new System.Drawing.Size(165, 27);
            this.numericUpDownSpacing.TabIndex = 12;
            this.numericUpDownSpacing.ValueChanged += new System.EventHandler(this.numericUpDownSpacing_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(40, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Line Width";
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = DockStyle.Fill;
            this.chartControl1.BorderAppearance.BaseColor = System.Drawing.Color.RosyBrown;
            this.chartControl1.BorderAppearance.Interior.ForeColor = System.Drawing.Color.RosyBrown;
            this.chartControl1.BorderAppearance.Interior.Width = 1F;
            this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss;
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.DataSourceName = "";
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(571, 87);
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(-6, 12);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.BreakInfo.LineSpacing = 3D;
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.Size = new System.Drawing.Size(700, 548);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ZoomOutIncrement = 1.5D;
            this.chartControl1.ChartFormatAxisLabel += new Syncfusion.Windows.Forms.Chart.ChartFormatAxisLabelEventHandler(this.chartControl1_ChartFormatAxisLabel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 584);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(569, 620);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Axis Breaks";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpacing)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }

        # endregion

        # region Form Load
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, System.EventArgs e)
        {
            InitializeChartData();         
            InitializeControls();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }
        # endregion

        # region Helpher Methods
        /// <summary>
        /// Initializes chart series data
        /// </summary>
        protected void InitializeChartData()
        {
            ChartSeries series = new ChartSeries("Populated Countries", ChartSeriesType.Column);
            series.Text = series.Name;
            series.Points.Add(1, 1330);
            series.Points.Add(2, 1148);
            series.Points.Add(3, 303.8);
            series.Points.Add(4, 237.5);
            series.Points.Add(5, 191.9);
            series.Points.Add(6, 167.8);
            series.Points.Add(7, 153.5);
            series.Points.Add(8, 140.7);
            series.Points.Add(9, 138.3);
            series.Points.Add(10, 127.3);
            this.chartControl1.Series.Add(series);
            this.chartControl1.Series[0].PrepareStyle += new ChartPrepareStyleInfoHandler(Form1_PrepareStyle);
            MakeBreakChart();
        }
        /// <summary>
        /// Initializes controls
        /// </summary>
        protected void InitializeControls()
        {
            this.comboBox1.SelectedIndex = 1;
            this.listBox1.SelectedIndex = 0;
            foreach (string line in Enum.GetNames(typeof(ChartBreakLineType)))
                this.comboBoxType.Items.Add(line);
            foreach (string line in Enum.GetNames(typeof(DashStyle)))
                this.comboBoxStyle.Items.Add(line);

            this.comboBoxType.SelectedIndex = 1;
            this.comboBoxStyle.SelectedIndex = 2;
            this.numericUpDownSpacing.Value = 5;
            this.numericUpDownWidth.Value = 1;

            this.chartControl1.Dock = DockStyle.Fill;

            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
        }        

        /// <summary>
        /// Prepares for manual mode break chart
        /// </summary>
        protected void MakeBreakChart()
        {
            this.chartControl1.PrimaryYAxis.BreakRanges.BreaksMode = ChartBreaksMode.Manual;
            this.chartControl1.PrimaryYAxis.BreakRanges.Union(new DoubleRange(300, 500));
            this.chartControl1.PrimaryYAxis.BreakRanges.Union(new DoubleRange(800, 1100));
            this.chartControl1.PrimaryYAxis.BreakInfo.LineType = ChartBreakLineType.Wave;
            this.chartControl1.PrimaryYAxis.BreakInfo.LineSpacing = 5;
            this.chartControl1.PrimaryYAxis.BreakInfo.LineColor = Color.Black;
            this.chartControl1.PrimaryYAxis.BreakInfo.LineWidth = 1;
            this.chartControl1.PrimaryYAxis.BreakInfo.LineStyle = DashStyle.Dot;
            this.chartControl1.PrimaryYAxis.BreakInfo.SpacingColor = Color.White;
        }
        #endregion

        # region Events

        void Form1_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
        {
            ChartSeries series = this.chartControl1.Series[0];
            if (series != null)
            {

                if (args.Index == 0)
                {
                    args.Style.Interior = new BrushInfo(Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2));
                }
                else if (args.Index == 1)
                {
                    args.Style.Interior = new BrushInfo(Color.FromArgb(0xFF, 0xA0, 0x50, 0x00));
                }
                else if (args.Index == 2)
                {
                    args.Style.Interior = new BrushInfo(Color.FromArgb(0xFF, 0x33, 0x99, 0x33));
                }
                else if (args.Index == 3)
                {
                    args.Style.Interior = new BrushInfo(Color.FromArgb(0xFF, 0xA2, 0xC1, 0x39));
                }
                else if (args.Index == 4)
                {
                    args.Style.Interior = new BrushInfo(Color.FromArgb(0xFF, 0xD8, 0x00, 0x73));
                }
                else if (args.Index == 5)
                {
                    args.Style.Interior = new BrushInfo(Color.FromArgb(0xFF, 0xF0, 0x96, 0x09));
                }
                else if (args.Index == 6)
                {
                    args.Style.Interior = new BrushInfo(Color.FromArgb(0xFF, 0xE6, 0x71, 0xB8));
                }
                else if (args.Index == 7)
                {
                    args.Style.Interior = new BrushInfo(Color.FromArgb(0xFF, 0xA2, 0x00, 0xFF));
                }
                else if (args.Index == 8)
                {
                    args.Style.Interior = new BrushInfo(Color.FromArgb(0xFF, 0xE5, 0x14, 0x00));
                }
                else if (args.Index == 9)
                {
                    args.Style.Interior = new BrushInfo(Color.FromArgb(0xFF, 0x00, 0xAB, 0xA9));
                }
            }
        }

        /// <summary>
        /// Toggles between Break and regular chart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
    
        public void SetRange()
        {
            this.chartControl1.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryYAxis.Range = new MinMaxInfo(0, 1400, 100);
        }
        /// <summary>
        /// Handles the different break modes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == 0)
            {
                this.chartControl1.PrimaryYAxis.BreakRanges.Clear();
                this.label6.Visible = false;
                this.label2.Visible = false;
                this.numericUpDown1.Visible = false;
                this.label7.Visible = false;
                this.label3.Visible = false;
                this.listBox1.Visible = false;
                this.button1.Visible = false;  
                this.button2.Visible = false;
            }
                
            else if (this.comboBox1.SelectedIndex == 1)
            {

                this.label6.Visible = false;
                this.label2.Visible = false;
                this.numericUpDown1.Visible = false;
                this.label7.Visible = true;
                this.label3.Visible = true;
                this.listBox1.Visible = true;
                this.button1.Visible = true;
                this.button2.Visible = true;
                MakeBreakChart();
            }
            else if (this.comboBox1.SelectedIndex == 2)
            {
                this.label6.Visible = true;
                this.label2.Visible = true;
                this.numericUpDown1.Visible = true;
                this.label7.Visible = false;
                this.label3.Visible = false;
                this.listBox1.Visible = false;
                this.button1.Visible = false;
                this.button2.Visible = false;
                this.chartControl1.PrimaryYAxis.BreakRanges.BreaksMode = ChartBreaksMode.Auto;
                this.chartControl1.PrimaryYAxis.BreakRanges.BreakAmount = Convert.ToDouble(this.numericUpDown1.Value);
            }
            SetRange();
        }

        /// <summary>
        /// Removes the specified range from manual break chart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            
            string temp = this.listBox1.SelectedItem.ToString();
            double start = Convert.ToDouble(temp.Substring(0, temp.LastIndexOf('-')));
            double end = Convert.ToDouble(temp.Substring(temp.LastIndexOf('-') + 1));
            this.chartControl1.PrimaryYAxis.BreakRanges.Exclude(new DoubleRange(start, end));
            SetRange();
        }

        /// <summary>
        /// Inserts the specified range from manual break chart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string temp = this.listBox1.SelectedItem.ToString();
            double start = Convert.ToDouble(temp.Substring(0, temp.LastIndexOf('-')));
            double end = Convert.ToDouble(temp.Substring(temp.LastIndexOf('-') + 1));
            this.chartControl1.PrimaryYAxis.BreakRanges.Union(new DoubleRange(start, end));
            SetRange();
        }

        /// <summary>
        /// Updates the break amount during auto break mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryYAxis.BreakRanges.BreakAmount = Convert.ToDouble(this.numericUpDown1.Value);
            SetRange();
        }

        /// <summary>
        /// Updates the type of the break line
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryYAxis.BreakInfo.LineType = (ChartBreakLineType)Enum.Parse(typeof(ChartBreakLineType), this.comboBoxType.SelectedItem.ToString());
            SetRange();
        }

        /// <summary>
        /// Updates the style of the break line
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryYAxis.BreakInfo.LineStyle = (DashStyle)Enum.Parse(typeof(DashStyle), this.comboBoxStyle.SelectedItem.ToString());
            SetRange();
        }

        /// <summary>
        /// Controls the spacing of the break line
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownSpacing_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryYAxis.BreakInfo.LineSpacing = Convert.ToDouble(this.numericUpDownSpacing.Value);
            SetRange();
        }

        /// <summary>
        /// Controls the width of the break line border
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownWidth_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryYAxis.BreakInfo.LineWidth = (float)(this.numericUpDownWidth.Value);
            SetRange();
        }

        /// <summary>
        /// Handles the color of the break line border
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colorPickerButton2_ColorSelected(object sender, EventArgs e)
        {
            this.colorPickerButton2.BackColor = this.colorPickerButton2.SelectedColor;
            this.chartControl1.PrimaryYAxis.BreakInfo.LineColor = this.colorPickerButton2.SelectedColor;
            SetRange();
        }

        /// <summary>
        /// Handles the color of the spacing of breakline
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            this.colorPickerButton1.BackColor = this.colorPickerButton1.SelectedColor;
            this.chartControl1.PrimaryYAxis.BreakInfo.SpacingColor = this.colorPickerButton1.SelectedColor;
            SetRange();
        }
              

        private void chartControl1_ChartFormatAxisLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            if (e.AxisOrientation == ChartOrientation.Horizontal)
            {
                if (e.Value == 1)
                    e.Label = "China";
                else if (e.Value == 2)
                    e.Label = "India";
                else if (e.Value == 3)
                    e.Label = "United States";
                else if (e.Value == 4)
                    e.Label = "Indonesia";
                else if (e.Value == 5)
                    e.Label = "Brazil";
                else if (e.Value == 6)
                    e.Label = "Pakistan";
                else if (e.Value == 7)
                    e.Label = "Bangladesh";
                else if (e.Value == 8)
                    e.Label = "Russia";
                else if (e.Value == 9)
                    e.Label = "Nigeria";
                else if (e.Value == 10)
                    e.Label = "Japan";
                else
                    e.Label = "";

                e.Handled = true;
            }
        }
        # endregion

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.chartControl1.PrimaryYAxis.MakeBreaks = true;
                this.chartControl1.PrimaryYAxis.BreakRanges.BreaksMode = (ChartBreaksMode)Enum.Parse(typeof(ChartBreaksMode), this.comboBox1.SelectedItem.ToString());
            }
            else
            {
                this.chartControl1.PrimaryYAxis.MakeBreaks = false;
            }
            SetRange();
        }

    }
    /// <summary>
    /// Represents a class that is used to find the licensing file for Syncfusion controls.
    /// </summary>
    internal class DemoCommon
    {

        /// <summary>
        /// Finds the license key from the Common folder.
        /// </summary>
        /// <returns>Returns the license key.</returns>
        public static string FindLicenseKey()
        {
            string licenseKeyFile = "..\\Common\\SyncfusionLicense.txt";
            for (int n = 0; n < 20; n++)
            {
                if (!System.IO.File.Exists(licenseKeyFile))
                {
                    licenseKeyFile = @"..\" + licenseKeyFile;
                    continue;
                }
                return System.IO.File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }
}
