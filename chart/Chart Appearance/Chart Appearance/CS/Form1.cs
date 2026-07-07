#region Copyright Syncfusion Inc. 2001 - 2014
// Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Collections.Generic;
using System.IO;

namespace ChartAppearance
{
    public class Form1 : MetroForm
    {
        #region Private Members

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Timer timer1;
        string filename = null;
        private Label label3;
        private ComboBox comboBox3;
        private Label label4;
        private NumericUpDown numericUpDown4;
        private Label label17;
        private ColorPickerButton colorPickerButton3;
        private Label label18;
        private ColorPickerButton colorPickerButton2;
        private NumericUpDown numericUpDown5;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Label label23;
        private ColorPickerButton colorPickerButton6;
        private ColorPickerButton colorPickerButton5;
        private Label label34;
        private ColorPickerButton colorPickerButton1;
        private ColorPickerButton colorPickerButton7;
        private Label label35;
        private ColorPickerButton colorPickerButton8;
        private ColorPickerButton colorPickerButton9;
        private Button button1;
        private Button Btn_Clear;
        private ComboBox comboBox8;
        private Label label19;
        private CheckBox checkBox5;
        private Label label31;
        private ComboBox comboBox9;
        private ColorPickerButton colorPickerButton4;
        private ComboBox comboBox6;
        private Label label6;
        private Label label5;
        private ComboBox comboBox5;
        private Label label20;
        private Label label22;
        private NumericUpDown numericUpDown3;
        private Label label7;
        private NumericUpDown numericUpDown2;
        private Label label8;
        private NumericUpDown numericUpDown1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Label label21;
        private ComboBox comboBox7;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private CheckBox checkBox1;
        private Label label24;
        private Label label28;
        private RadioButton radioButton1;
        private ToolTip toolTip1;
        private ChartControl chartControl1;
        private Label label36;
        private Label label33;
        private Label label16;
        private Label label10;
        private Label label9;
        private Label label12;
        private Label label11;
        private Label label13;

        private string Font_Name;

        #endregion

        #region Constructor, Main And Dispose
        public Form1()
        {
            BorderColor = Color.FromArgb(0xFF,0xCD,0xCD,0xCD);
            BorderThickness = 3;
            CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(75.0f);
            CaptionBarColor = Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2);
            CaptionFont = new Font("Segoe UI", 22.0f);
            CaptionForeColor = Color.White;
            CaptionAlign = HorizontalAlignment.Left;
            CaptionButtonColor = Color.White;
            CaptionButtonHoverColor = Color.White;
            ControlBox = true;
            //FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            ShowIcon = false;
            InitializeComponent();
            InitializeControlSettings();
            InitializeChartData();
            FillControlPanel();
            
        }


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

        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, System.EventArgs e)
        {           
            this.comboBox8.SelectedIndex = 2;
            for (int i = 0; i <= 2; i++)
            {
                this.chartControl1.Series[i].Style.DisplayText = this.checkBox1.Checked;
                this.chartControl1.Series[i].Style.TextOrientation = ChartTextOrientation.Up;
            }
            comboBox5.SelectedIndex = 19;
            this.chartControl1.PrimaryXAxis.Font = new Font(this.comboBox5.SelectedItem.ToString(), 10.25F);
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }

        #endregion

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
            this.label13 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.colorPickerButton4 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label28 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.colorPickerButton8 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.colorPickerButton2 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.colorPickerButton9 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.colorPickerButton1 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.colorPickerButton7 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.colorPickerButton6 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label36 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colorPickerButton5 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.colorPickerButton3 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.label35 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = DockStyle.Right;
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.comboBox9);
            this.panel1.Controls.Add(this.colorPickerButton4);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.comboBox8);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.comboBox6);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.comboBox7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.colorPickerButton8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.comboBox5);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.colorPickerButton2);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.Btn_Clear);
            this.panel1.Controls.Add(this.colorPickerButton9);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.colorPickerButton1);
            this.panel1.Controls.Add(this.numericUpDown3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.colorPickerButton7);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.numericUpDown4);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.colorPickerButton6);
            this.panel1.Controls.Add(this.label36);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.colorPickerButton5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.colorPickerButton3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Controls.Add(this.label34);
            this.panel1.Controls.Add(this.numericUpDown5);
            this.panel1.Controls.Add(this.label35);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(706, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 590);
            this.panel1.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label13.Location = new System.Drawing.Point(31, 1645);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 20);
            this.label13.TabIndex = 68;
            this.label13.Text = "Series Settings";
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label21.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label21.Location = new System.Drawing.Point(35, 1897);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(104, 20);
            this.label21.TabIndex = 55;
            this.label21.Text = "Symbol Shape";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label9.Location = new System.Drawing.Point(31, 1575);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 25);
            this.label9.TabIndex = 58;
            this.label9.Text = "Shadow";
            // 
            // radioButton1
            // 
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.radioButton1.Location = new System.Drawing.Point(38, 1867);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 24);
            this.radioButton1.TabIndex = 67;
            this.radioButton1.Text = "Series 3";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // checkBox5
            // 
            this.checkBox5.BackColor = System.Drawing.Color.Transparent;
            this.checkBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox5.Location = new System.Drawing.Point(35, 1616);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(118, 24);
            this.checkBox5.TabIndex = 34;
            this.checkBox5.Text = "Show Shadow";
            this.checkBox5.UseVisualStyleBackColor = false;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.ChartAreaShadow_CheckedChanged);
            // 
            // comboBox9
            // 
            this.comboBox9.BackColor = System.Drawing.Color.White;
            this.comboBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox9.Location = new System.Drawing.Point(35, 1700);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(179, 28);
            this.comboBox9.TabIndex = 36;
            this.comboBox9.SelectedIndexChanged += new System.EventHandler(this.ColorPalette_SelectedIndexChanged);
            // 
            // colorPickerButton4
            // 
            this.colorPickerButton4.BackColor = System.Drawing.Color.DimGray;
            this.colorPickerButton4.BeforeTouchSize = new System.Drawing.Size(100, 30);
            this.colorPickerButton4.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.colorPickerButton4.IsBackStageButton = false;
            this.colorPickerButton4.Location = new System.Drawing.Point(35, 1520);
            this.colorPickerButton4.Name = "colorPickerButton4";
            this.colorPickerButton4.SelectedAsBackcolor = true;
            this.colorPickerButton4.SelectedColor = System.Drawing.Color.DimGray;
            this.colorPickerButton4.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.StandardColors;
            this.colorPickerButton4.Size = new System.Drawing.Size(100, 30);
            this.colorPickerButton4.TabIndex = 45;
            this.colorPickerButton4.UseVisualStyleBackColor = false;
            this.colorPickerButton4.ColorSelected += new System.EventHandler(this.FontColor_ColorSelected);
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label28.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label28.Location = new System.Drawing.Point(35, 1770);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(93, 20);
            this.label28.TabIndex = 66;
            this.label28.Text = "Select series:";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label16.Location = new System.Drawing.Point(27, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(179, 32);
            this.label16.TabIndex = 0;
            this.label16.Text = "Border Settings";
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label31.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label31.Location = new System.Drawing.Point(35, 1673);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(95, 20);
            this.label31.TabIndex = 37;
            this.label31.Text = "Color Palette";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label12.Location = new System.Drawing.Point(30, 1321);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 25);
            this.label12.TabIndex = 53;
            this.label12.Text = "Font Settings";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox1.Location = new System.Drawing.Point(36, 1738);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(167, 24);
            this.checkBox1.TabIndex = 52;
            this.checkBox1.Text = "Show Data Point Text";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.Showtext_CheckedChanged);
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label20.Location = new System.Drawing.Point(35, 1492);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 20);
            this.label20.TabIndex = 48;
            this.label20.Text = "Font Color";
            // 
            // radioButton4
            // 
            this.radioButton4.BackColor = System.Drawing.Color.Transparent;
            this.radioButton4.Checked = true;
            this.radioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.radioButton4.Location = new System.Drawing.Point(38, 1805);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(77, 24);
            this.radioButton4.TabIndex = 53;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Series 1";
            this.radioButton4.UseVisualStyleBackColor = false;
            // 
            // comboBox8
            // 
            this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox8.Location = new System.Drawing.Point(33, 860);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(158, 28);
            this.comboBox8.TabIndex = 35;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.radioButton3.Location = new System.Drawing.Point(38, 1836);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(77, 24);
            this.radioButton3.TabIndex = 54;
            this.radioButton3.Text = "Series 2";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // comboBox6
            // 
            this.comboBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox6.Location = new System.Drawing.Point(33, 1450);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(179, 28);
            this.comboBox6.TabIndex = 43;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.FontStyle_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label11.Location = new System.Drawing.Point(29, 986);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "3D Mode";
            // 
            // comboBox7
            // 
            this.comboBox7.BackColor = System.Drawing.Color.White;
            this.comboBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox7.Location = new System.Drawing.Point(35, 1923);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(181, 28);
            this.comboBox7.TabIndex = 56;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.SymbolShape_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label6.Location = new System.Drawing.Point(35, 1423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Font Style";
            // 
            // colorPickerButton8
            // 
            this.colorPickerButton8.BackColor = System.Drawing.Color.White;
            this.colorPickerButton8.BeforeTouchSize = new System.Drawing.Size(78, 29);
            this.colorPickerButton8.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.colorPickerButton8.IsBackStageButton = false;
            this.colorPickerButton8.Location = new System.Drawing.Point(134, 780);
            this.colorPickerButton8.Name = "colorPickerButton8";
            this.colorPickerButton8.SelectedAsBackcolor = true;
            this.colorPickerButton8.SelectedColor = System.Drawing.Color.White;
            this.colorPickerButton8.Size = new System.Drawing.Size(78, 29);
            this.colorPickerButton8.TabIndex = 15;
            this.colorPickerButton8.UseVisualStyleBackColor = false;
            this.colorPickerButton8.ColorSelected += new System.EventHandler(this.ChartInterior_ColorChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label5.Location = new System.Drawing.Point(35, 1353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Font Face";
            // 
            // checkBox3
            // 
            this.checkBox3.BackColor = System.Drawing.Color.Transparent;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox3.Location = new System.Drawing.Point(35, 1029);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(87, 24);
            this.checkBox3.TabIndex = 45;
            this.checkBox3.Text = "3D Mode";
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox5.Items.AddRange(new object[] {
            "Agency FB",
            "Arial",
            "Book Antiqua",
            "Bookman Old Style",
            "Bradley Hand ITC",
            "Courier New",
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
            "Segoe UI"});
            this.comboBox5.Location = new System.Drawing.Point(35, 1382);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(179, 28);
            this.comboBox5.TabIndex = 43;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.FontName_SelectedIndexChanged);
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label24.Location = new System.Drawing.Point(29, 905);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(160, 29);
            this.label24.TabIndex = 57;
            this.label24.Text = "Background Image";
            // 
            // colorPickerButton2
            // 
            this.colorPickerButton2.BackColor = System.Drawing.Color.Transparent;
            this.colorPickerButton2.BeforeTouchSize = new System.Drawing.Size(100, 30);
            this.colorPickerButton2.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.colorPickerButton2.IsBackStageButton = false;
            this.colorPickerButton2.Location = new System.Drawing.Point(34, 512);
            this.colorPickerButton2.Name = "colorPickerButton2";
            this.colorPickerButton2.SelectedAsBackcolor = true;
            this.colorPickerButton2.SelectedColor = System.Drawing.Color.Transparent;
            this.colorPickerButton2.Size = new System.Drawing.Size(100, 30);
            this.colorPickerButton2.TabIndex = 5;
            this.colorPickerButton2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.colorPickerButton2.UseVisualStyleBackColor = false;
            this.colorPickerButton2.ColorSelected += new System.EventHandler(this.SeriesBorderColor_ColorSelected);
            this.colorPickerButton2.Click += new System.EventHandler(this.colorPickerButton2_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox2.Location = new System.Drawing.Point(35, 1063);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(100, 24);
            this.checkBox2.TabIndex = 46;
            this.checkBox2.Text = "Rotate Axis";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.RotateAxis_CheckedChanged);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))));
            this.Btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Clear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Clear.Enabled = false;
            this.Btn_Clear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Btn_Clear.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Clear.Image")));
            this.Btn_Clear.Location = new System.Drawing.Point(122, 940);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(78, 29);
            this.Btn_Clear.TabIndex = 31;
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // colorPickerButton9
            // 
            this.colorPickerButton9.BackColor = System.Drawing.Color.White;
            this.colorPickerButton9.BeforeTouchSize = new System.Drawing.Size(78, 29);
            this.colorPickerButton9.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.colorPickerButton9.IsBackStageButton = false;
            this.colorPickerButton9.Location = new System.Drawing.Point(35, 780);
            this.colorPickerButton9.Name = "colorPickerButton9";
            this.colorPickerButton9.SelectedAsBackcolor = true;
            this.colorPickerButton9.SelectedColor = System.Drawing.Color.White;
            this.colorPickerButton9.Size = new System.Drawing.Size(78, 29);
            this.colorPickerButton9.TabIndex = 14;
            this.colorPickerButton9.UseVisualStyleBackColor = false;
            this.colorPickerButton9.ColorSelected += new System.EventHandler(this.ChartInterior_ColorChanged);
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label22.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.label22.Location = new System.Drawing.Point(31, 1238);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(30, 20);
            this.label22.TabIndex = 52;
            this.label22.Text = "Tilt";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label17.Location = new System.Drawing.Point(30, 241);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 20);
            this.label17.TabIndex = 13;
            this.label17.Text = "Border Color";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label19.Location = new System.Drawing.Point(30, 830);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(102, 20);
            this.label19.TabIndex = 36;
            this.label19.Text = "Gradient Style";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button1.Location = new System.Drawing.Point(33, 940);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 29);
            this.button1.TabIndex = 28;
            this.button1.Text = "...";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ChartControlBackGroundImage_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown1.Location = new System.Drawing.Point(35, 1125);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(179, 27);
            this.numericUpDown1.TabIndex = 47;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.Depth_ValueChanged);
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.BackColor = System.Drawing.Color.White;
            this.colorPickerButton1.BeforeTouchSize = new System.Drawing.Size(78, 29);
            this.colorPickerButton1.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.colorPickerButton1.IsBackStageButton = false;
            this.colorPickerButton1.Location = new System.Drawing.Point(134, 705);
            this.colorPickerButton1.Name = "colorPickerButton1";
            this.colorPickerButton1.SelectedAsBackcolor = true;
            this.colorPickerButton1.SelectedColor = System.Drawing.Color.White;
            this.colorPickerButton1.Size = new System.Drawing.Size(78, 29);
            this.colorPickerButton1.TabIndex = 15;
            this.colorPickerButton1.UseVisualStyleBackColor = false;
            this.colorPickerButton1.ColorSelected += new System.EventHandler(this.ChartArea_ColorChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown3.Location = new System.Drawing.Point(35, 1271);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.ReadOnly = true;
            this.numericUpDown3.Size = new System.Drawing.Size(179, 27);
            this.numericUpDown3.TabIndex = 51;
            this.numericUpDown3.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox1.Location = new System.Drawing.Point(34, 384);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 28);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.SeriesBorder_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.label8.Location = new System.Drawing.Point(29, 1095);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = " Z Axis Depth";
            // 
            // colorPickerButton7
            // 
            this.colorPickerButton7.BackColor = System.Drawing.Color.White;
            this.colorPickerButton7.BeforeTouchSize = new System.Drawing.Size(78, 29);
            this.colorPickerButton7.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.colorPickerButton7.IsBackStageButton = false;
            this.colorPickerButton7.Location = new System.Drawing.Point(35, 704);
            this.colorPickerButton7.Name = "colorPickerButton7";
            this.colorPickerButton7.SelectedAsBackcolor = true;
            this.colorPickerButton7.SelectedColor = System.Drawing.Color.White;
            this.colorPickerButton7.Size = new System.Drawing.Size(78, 29);
            this.colorPickerButton7.TabIndex = 14;
            this.colorPickerButton7.UseVisualStyleBackColor = false;
            this.colorPickerButton7.ColorSelected += new System.EventHandler(this.ChartArea_ColorChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.label7.Location = new System.Drawing.Point(31, 1168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Series Spacing";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown4.Location = new System.Drawing.Point(34, 203);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(181, 27);
            this.numericUpDown4.TabIndex = 11;
            this.numericUpDown4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown2.Location = new System.Drawing.Point(35, 1197);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.ReadOnly = true;
            this.numericUpDown2.Size = new System.Drawing.Size(179, 27);
            this.numericUpDown2.TabIndex = 49;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.Spacing_ValueChanged);
            // 
            // colorPickerButton6
            // 
            this.colorPickerButton6.BackColor = System.Drawing.Color.White;
            this.colorPickerButton6.BeforeTouchSize = new System.Drawing.Size(78, 29);
            this.colorPickerButton6.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.colorPickerButton6.IsBackStageButton = false;
            this.colorPickerButton6.Location = new System.Drawing.Point(134, 635);
            this.colorPickerButton6.Name = "colorPickerButton6";
            this.colorPickerButton6.SelectedAsBackcolor = true;
            this.colorPickerButton6.SelectedColor = System.Drawing.Color.White;
            this.colorPickerButton6.Size = new System.Drawing.Size(78, 29);
            this.colorPickerButton6.TabIndex = 15;
            this.colorPickerButton6.UseVisualStyleBackColor = false;
            this.colorPickerButton6.ColorSelected += new System.EventHandler(this.ChartControl_ColorChanged);
            // 
            // label36
            // 
            this.label36.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label36.Location = new System.Drawing.Point(27, 317);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(113, 25);
            this.label36.TabIndex = 15;
            this.label36.Text = "Chart Series";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(31, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Border DashStyle";
            // 
            // colorPickerButton5
            // 
            this.colorPickerButton5.BackColor = System.Drawing.Color.White;
            this.colorPickerButton5.BeforeTouchSize = new System.Drawing.Size(78, 29);
            this.colorPickerButton5.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton5.CustomManagedColor = System.Drawing.Color.White;
            this.colorPickerButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.colorPickerButton5.IsBackStageButton = false;
            this.colorPickerButton5.Location = new System.Drawing.Point(36, 635);
            this.colorPickerButton5.Name = "colorPickerButton5";
            this.colorPickerButton5.SelectedAsBackcolor = true;
            this.colorPickerButton5.SelectedColor = System.Drawing.Color.White;
            this.colorPickerButton5.Size = new System.Drawing.Size(78, 29);
            this.colorPickerButton5.TabIndex = 14;
            this.colorPickerButton5.UseVisualStyleBackColor = false;
            this.colorPickerButton5.ColorSelected += new System.EventHandler(this.ChartControl_ColorChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(30, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Border Width";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label18.Location = new System.Drawing.Point(30, 482);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 20);
            this.label18.TabIndex = 22;
            this.label18.Text = "Border Color";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label10.Location = new System.Drawing.Point(30, 565);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "Background Settings";
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label23.Location = new System.Drawing.Point(31, 607);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(97, 20);
            this.label23.TabIndex = 28;
            this.label23.Text = "Chart Control";
            // 
            // colorPickerButton3
            // 
            this.colorPickerButton3.BackColor = System.Drawing.Color.Transparent;
            this.colorPickerButton3.BeforeTouchSize = new System.Drawing.Size(100, 30);
            this.colorPickerButton3.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.colorPickerButton3.IsBackStageButton = false;
            this.colorPickerButton3.Location = new System.Drawing.Point(34, 268);
            this.colorPickerButton3.Name = "colorPickerButton3";
            this.colorPickerButton3.SelectedAsBackcolor = true;
            this.colorPickerButton3.SelectedColor = System.Drawing.Color.Transparent;
            this.colorPickerButton3.Size = new System.Drawing.Size(100, 30);
            this.colorPickerButton3.TabIndex = 6;
            this.colorPickerButton3.UseVisualStyleBackColor = false;
            this.colorPickerButton3.ColorSelected += new System.EventHandler(this.colorPickerButton3_ColorSelected);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(30, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Border Width";
            // 
            // label33
            // 
            this.label33.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label33.Location = new System.Drawing.Point(27, 71);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(126, 25);
            this.label33.TabIndex = 1;
            this.label33.Text = "Chart Control";
            // 
            // label34
            // 
            this.label34.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label34.Location = new System.Drawing.Point(30, 676);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(79, 20);
            this.label34.TabIndex = 31;
            this.label34.Text = "Chart Area";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown5.Location = new System.Drawing.Point(34, 447);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(179, 27);
            this.numericUpDown5.TabIndex = 20;
            this.numericUpDown5.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // label35
            // 
            this.label35.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label35.Location = new System.Drawing.Point(30, 748);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(96, 20);
            this.label35.TabIndex = 34;
            this.label35.Text = "Chart Interior";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox3.Location = new System.Drawing.Point(32, 135);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(180, 28);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.ChartBorderStyle_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(29, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Border Style";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathEllipse, System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254))))));
            this.chartControl1.DataSourceName = "";
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Location = new System.Drawing.Point(591, 31);
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.Size = new System.Drawing.Size(700, 580);
            this.chartControl1.TabIndex = 1;
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ChartFormatAxisLabel += new Syncfusion.Windows.Forms.Chart.ChartFormatAxisLabelEventHandler(this.chartControl1_ChartFormatAxisLabel);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 584);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimumSize = new System.Drawing.Size(860, 490);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appearance";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Helper Methods

        #region InitializeChartData

        /// <summary>
        /// In this method chart data has been Initialized.
        /// </summary>
        protected void InitializeChartData()
        {
            // Top 5 olympic medal winners
            ChartSeries series1 = new ChartSeries("Gold");
            series1.Text = "Gold";
            series1.Type = ChartSeriesType.Column;

            ChartSeries series2 = new ChartSeries("Silver");
            series2.Text = "Silver";
            series2.Type = ChartSeriesType.Column;

            ChartSeries series3 = new ChartSeries("Bronze");
            series3.Text = "Bronze";
            series3.Type = ChartSeriesType.Column;

            // USA
            series1.Points.Add(1, 35);
            series2.Points.Add(1, 39);
            series3.Points.Add(1, 29);

            // China
            series1.Points.Add(2, 32);
            series2.Points.Add(2, 17);
            series3.Points.Add(2, 14);

            // Russia
            series1.Points.Add(3, 27);
            series2.Points.Add(3, 27);
            series3.Points.Add(3, 28);

            // Australia
            series1.Points.Add(4, 17);
            series2.Points.Add(4, 16);
            series3.Points.Add(4, 16);

            // China
            series1.Points.Add(5, 16);
            series2.Points.Add(5, 9);
            series3.Points.Add(5, 12);

            series1.Style.Images = new ChartImageCollection(this.imageList1.Images);
            series2.Style.Images = new ChartImageCollection(this.imageList1.Images);
            series3.Style.Images = new ChartImageCollection(this.imageList1.Images);

            this.chartControl1.Series.Add(series1);
            this.chartControl1.Series.Add(series2);
            this.chartControl1.Series.Add(series3);

            for (int i = 0; i < series1.Points.Count; i++)
                series1.Styles[i].Text = string.Format("{0}", series1.Points[i].YValues[0]);

            for (int i = 0; i < series2.Points.Count; i++)
                series2.Styles[i].Text = string.Format("{0}", series2.Points[i].YValues[0]);

            for (int i = 0; i < series3.Points.Count; i++)
                series3.Styles[i].Text = string.Format("{0}", series3.Points[i].YValues[0]);
        }

        #endregion

        #region InitializeControlSettings
        /// <summary>
        /// Setting Chart control properties.
        /// </summary>
        private void InitializeControlSettings()
        {
            this.checkBox2.Enabled = false;
            this.numericUpDown1.Enabled = false;
            this.numericUpDown2.Enabled = false;
            this.numericUpDown3.Enabled = false;

            foreach (ChartSeries series in this.chartControl1.Series)
            {
                if (series == this.chartControl1.Series[0])
                {
                    series.Style.Images = new ChartImageCollection(this.imageList1.Images);
                    series.Style.Symbol.Shape = ChartSymbolShape.Image;
                    series.Style.Symbol.Size = new Size(16, 16);
                    series.Style.ImageIndex = 0;
                }
                series.Style.Symbol.Color = Color.Yellow;
                series.Style.DisplayShadow = false;
                series.Style.PointWidth = 2;
                series.Style.Font.Bold = true;
            }
            this.chartControl1.ColumnDrawMode = ChartColumnDrawMode.PlaneMode;
            this.chartControl1.LegendPosition = ChartDock.Top;
            this.chartControl1.PrimaryXAxis.LabelRotate = true;
            this.chartControl1.Spacing = 20;
        }
        #endregion

        #region FillControlPanel

        /// <summary>
        /// Initializes the control values.
        /// </summary>
        protected void FillControlPanel()
        {
            foreach (string linetype in Enum.GetNames(typeof(System.Drawing.Drawing2D.DashStyle)))
                this.comboBox1.Items.Add(linetype);
            foreach (string linetype1 in Enum.GetNames(typeof(BorderStyle)))
                this.comboBox3.Items.Add(linetype1);
            foreach (string fontstyle in Enum.GetNames(typeof(System.Drawing.FontStyle)))
                this.comboBox6.Items.Add(fontstyle);
            foreach (string gradient in Enum.GetNames(typeof(Syncfusion.Drawing.GradientStyle)))
                this.comboBox8.Items.Add(gradient);
            foreach (string palette in Enum.GetNames(typeof(Syncfusion.Windows.Forms.Chart.ChartColorPalette)))
                this.comboBox9.Items.Add(palette);
            foreach (string symbol in Enum.GetNames(typeof(Syncfusion.Windows.Forms.Chart.ChartSymbolShape)))
                this.comboBox7.Items.Add(symbol);

            this.comboBox7.SelectedIndex = 11;
            this.comboBox6.SelectedIndex = 0;
            this.comboBox5.SelectedIndex = 18;
            this.comboBox1.SelectedIndex = 0;
            this.comboBox3.SelectedIndex = 0;
            this.comboBox9.SelectedIndex = 17;
            this.colorPickerButton4.SelectedColor = Color.Black;
            this.numericUpDown2.Value = 10;
            this.timer1.Enabled = this.checkBox2.Checked;
        }
        #endregion

        #endregion

        #region Appearance

        #region Border Settings

        #region Border Color
        private void colorPickerButton3_ColorSelected(object sender, System.EventArgs e)
        {
            this.chartControl1.ChartArea.BorderColor = this.colorPickerButton3.SelectedColor;
            this.colorPickerButton3.BackColor = this.colorPickerButton3.SelectedColor;

            if (this.colorPickerButton3.SelectedColor == Color.Transparent)
            {
             
            }
            else
            {
             
            }

            this.chartControl1.Redraw(true);
        }

        #endregion

        #region Border Width

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.ChartArea.BorderWidth = Convert.ToInt32(this.numericUpDown4.Value);
            this.chartControl1.Redraw(true);
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= 2; i++)
                this.chartControl1.Series[i].Style.Border.Width = Convert.ToInt32(this.numericUpDown5.Value);
            this.chartControl1.Redraw(true);
        }

        #endregion

        #region Border Style

        private void ChartBorderStyle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.ChartArea.BorderStyle = (BorderStyle)Enum.Parse(typeof(BorderStyle), this.comboBox3.SelectedItem.ToString(), true);
            this.chartControl1.Redraw(true);
        }

        #endregion

        #region Series Border

        private void SeriesBorder_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            for (int i = 0; i <= 2; i++)
                this.chartControl1.Series[i].Style.Border.DashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), this.comboBox1.SelectedItem.ToString(), true);
            this.chartControl1.Redraw(true);
        }

        private void SeriesBorderColor_ColorSelected(object sender, System.EventArgs e)
        {
            for (int i = 0; i <= 2; i++)
                this.chartControl1.Series[i].Style.Border.Color = this.colorPickerButton2.SelectedColor;
            this.colorPickerButton2.BackColor = this.colorPickerButton2.SelectedColor;

            if (this.colorPickerButton2.SelectedColor == Color.Transparent)
            {
              
            }
            else
            {
                
            }

            this.chartControl1.Redraw(true);
        }

        #endregion

        #endregion

        #region Background Settings

        #region BackImage

        /// <summary>
        /// Setting Background image for the control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static readonly List<string> ImageExtensions = new List<string>(new String[] { ".JPG", ".JPE", ".BMP", ".GIF", ".PNG" });
        private void ChartControlBackGroundImage_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"..\..\..\..\..\..\..\..\..\Common\images\Chart";
            ofd.Filter = "BackGround files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (DialogResult.OK == ofd.ShowDialog() && ImageExtensions.Contains(Path.GetExtension(ofd.SafeFileName).ToUpperInvariant()))
            {
                filename = ofd.FileName;
                this.chartControl1.ChartAreaBackImage = new Bitmap(filename);
                this.chartControl1.ChartInterior = new BrushInfo(Color.Transparent);
                Btn_Clear.Enabled = true;
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            this.chartControl1.ChartAreaBackImage = null;
            Btn_Clear.Enabled = false;
            this.ChartInterior_ColorChanged(this.colorPickerButton8, EventArgs.Empty);
        }

        #endregion

        #region Interior

        private void ChartControl_ColorChanged(object sender, EventArgs e)
        {
            try
            {
                this.chartControl1.BackInterior = new BrushInfo((GradientStyle)Enum.Parse(typeof(GradientStyle), this.comboBox8.SelectedItem.ToString(), true), this.colorPickerButton5.SelectedColor, this.colorPickerButton6.SelectedColor);
                this.colorPickerButton5.BackColor = this.colorPickerButton5.SelectedColor;
                this.colorPickerButton6.BackColor = this.colorPickerButton6.SelectedColor;

                if (this.colorPickerButton5.SelectedColor == Color.Transparent)
                { 
                }

                else
                {

                }

                if (this.colorPickerButton6.SelectedColor == Color.Transparent)
                {
                    
                }
                else
                {
                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ChartArea_ColorChanged(object sender, EventArgs e)
        {
            try
            {
                this.chartControl1.ChartArea.BackInterior = new BrushInfo((GradientStyle)Enum.Parse(typeof(GradientStyle), this.comboBox8.SelectedItem.ToString(), true), this.colorPickerButton7.SelectedColor, this.colorPickerButton1.SelectedColor);
                this.colorPickerButton1.BackColor = this.colorPickerButton1.SelectedColor;
                this.colorPickerButton7.BackColor = this.colorPickerButton7.SelectedColor;

                if (this.colorPickerButton7.SelectedColor == Color.Transparent)
                {
                   
                }
                else
                {
                    
                }
                if (this.colorPickerButton1.SelectedColor == Color.Transparent)
                {
                   
                }
                else
                {
                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ChartInterior_ColorChanged(object sender, EventArgs e)
        {
            try
            {
                this.chartControl1.ChartInterior = new BrushInfo((GradientStyle)Enum.Parse(typeof(GradientStyle), this.comboBox8.SelectedItem.ToString(), true), this.colorPickerButton8.SelectedColor, this.colorPickerButton9.SelectedColor);
                this.colorPickerButton8.BackColor = this.colorPickerButton8.SelectedColor;
                this.colorPickerButton9.BackColor = this.colorPickerButton9.SelectedColor;
                if (this.colorPickerButton9.SelectedColor == Color.Transparent)
                {
                   
                }
                else
                {
                    
                }
                if (this.colorPickerButton8.SelectedColor == Color.Transparent)
                {
                  
                }
                else
                {
                 
                }

            }
            catch (Exception ex)
            {
                this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254))))));
                Console.WriteLine(ex.ToString());
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.BackInterior = new BrushInfo((GradientStyle)Enum.Parse(typeof(GradientStyle), this.comboBox8.SelectedItem.ToString(), true), this.colorPickerButton5.SelectedColor, this.colorPickerButton6.SelectedColor);
            this.chartControl1.ChartArea.BackInterior = new BrushInfo((GradientStyle)Enum.Parse(typeof(GradientStyle), this.comboBox8.SelectedItem.ToString(), true), this.colorPickerButton7.SelectedColor, this.colorPickerButton1.SelectedColor);
            this.chartControl1.ChartInterior = new BrushInfo((GradientStyle)Enum.Parse(typeof(GradientStyle), this.comboBox8.SelectedItem.ToString(), true), this.colorPickerButton8.SelectedColor, this.colorPickerButton9.SelectedColor);
        }

        #endregion

        #endregion

        #region Font Settings

        /// <summary>
        /// Setting font style, font name.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Showtext_CheckedChanged(object sender, System.EventArgs e)
        {
            SetFont();
            FontColor_ColorSelected(this.colorPickerButton4, EventArgs.Empty);
            for (int i = 0; i <= 2; i++)
            {
                this.chartControl1.Series[i].Style.DisplayText = this.checkBox1.Checked;
                this.chartControl1.Series[i].Style.TextOrientation = ChartTextOrientation.Up;
            }
            this.chartControl1.Redraw(true);
        }

        private void FontName_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Font_Name = this.comboBox5.SelectedItem.ToString();
            SetFont();
            for (int i = 0; i <= 2; i++)
                this.chartControl1.Series[i].Style.Font.Facename = this.comboBox5.SelectedItem.ToString();
        }

        private void FontStyle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            SetFont();
        }

        private void SetFont()
        {
            // Changing Font for Chart Legend
            ChartLegend item = this.chartControl1.Legend;
            item.Font = new Font(Font_Name, 10f, (FontStyle)Enum.Parse(typeof(FontStyle), this.comboBox6.SelectedItem.ToString(), true));

            // Changing font for chart axis
            ChartAxis axis = this.chartControl1.PrimaryXAxis;
            axis.Font = new Font(Font_Name, 10f, (FontStyle)Enum.Parse(typeof(FontStyle), this.comboBox6.SelectedItem.ToString(), true));
            axis = this.chartControl1.PrimaryYAxis;
            axis.Font = new Font(Font_Name, 10f, (FontStyle)Enum.Parse(typeof(FontStyle), this.comboBox6.SelectedItem.ToString(), true));
            // Changing font for chart title
            ChartTitle title = this.chartControl1.Title;
            title.Font = new Font(Font_Name, 10f, (FontStyle)Enum.Parse(typeof(FontStyle), this.comboBox6.SelectedItem.ToString(), true));

            if (this.chartControl1.Series.Count != 0)
            {
                for (int i = 0; i < this.chartControl1.Series.Count; i++)
                {
                    ChartSeries series = this.chartControl1.Series[i];
                    if (series != null)
                    {
                        series.Style.Font.Facename = Font_Name;
                        series.Style.Font.Size = 10f;
                        series.Style.Font.FontStyle = (FontStyle)Enum.Parse(typeof(FontStyle), this.comboBox6.SelectedItem.ToString(), true);
                    }
                }
            }
            this.chartControl1.Redraw(true);
        }

        private void FontColor_ColorSelected(object sender, System.EventArgs e)
        {
            this.colorPickerButton4.BackColor = this.colorPickerButton4.SelectedColor;
            for (int i = 0; i <= 2; i++)
            {
                this.chartControl1.Series[i].Style.TextColor = this.colorPickerButton4.SelectedColor;
                // Changing Legend Color
                this.chartControl1.Series[i].LegendItem.TextColor = this.colorPickerButton4.SelectedColor;
            }
            // Changing axis label color
            this.chartControl1.PrimaryXAxis.ForeColor = this.colorPickerButton4.SelectedColor;
            this.chartControl1.PrimaryYAxis.ForeColor = this.colorPickerButton4.SelectedColor;
            //  Changing Title Color
            this.chartControl1.Title.ForeColor = this.colorPickerButton4.SelectedColor;

            if (this.colorPickerButton4.SelectedColor == Color.Transparent)
            {
              
            }
            else
            {
               
            }

            this.chartControl1.Redraw(true);
        }
        #endregion

        #region Shadow
        /// <summary>
        /// Setting shadow for the chart area.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChartAreaShadow_CheckedChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.ChartAreaShadow = this.checkBox5.Checked;
        }
        #endregion

        #region ColorPalette
        /// <summary>
        /// Change the color palette in the Chart Control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorPalette_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.comboBox9.SelectedItem.ToString() == "Custom")
            {
                this.chartControl1.Palette = ChartColorPalette.Custom;
                this.chartControl1.CustomPalette = new System.Drawing.Color[] 
                {              
                Color.FromArgb(200,247,148,29),                
                Color.FromArgb(200, 140,198,62),
                Color.FromArgb(200, 163,48,45)
                };
            }
            else
            {
                this.chartControl1.Palette = (ChartColorPalette)Enum.Parse(typeof(ChartColorPalette), this.comboBox9.SelectedItem.ToString(), true);
                this.chartControl1.Series[0].Style.Interior = null;
                this.chartControl1.Series[1].Style.Interior = null;
                this.chartControl1.Series[2].Style.Interior = null;
            }
        }

        #endregion

        #region ChartFormatAxisLabel Event
        /// <summary>
        /// Formatting Chart Axes Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chartControl1_ChartFormatAxisLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            if (e.AxisOrientation == ChartOrientation.Horizontal)
            {
                if (e.Value == 1)
                    e.Label = "USA";
                else if (e.Value == 2)
                    e.Label = "China";
                else if (e.Value == 3)
                    e.Label = "Russia";
                else if (e.Value == 4)
                    e.Label = "Australia";
                else if (e.Value == 5)
                    e.Label = "Japan";
                else
                    e.Label = "";

                e.Handled = true;
            }
        }

        #endregion

        #endregion

        #region Behavior

        #region Rotation
        /// <summary>
        /// Enable and Disable the rotation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void RotateAxis_CheckedChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Series3D = this.checkBox3.Checked;
            this.chartControl1.ChartArea.Rotation = 30;
            this.chartControl1.ChartArea.Tilt = (float)this.numericUpDown3.Value;
            this.timer1.Enabled = this.checkBox2.Checked;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.Tilt = (float)this.numericUpDown3.Value;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series3D = this.checkBox3.Checked;
            if (this.checkBox3.Checked)
            {
			    this.checkBox2.Enabled = true;
                this.chartControl1.Series3D = true;
                this.checkBox2.Enabled = true;
                this.numericUpDown1.Enabled = true;
                this.numericUpDown2.Enabled = true;
                this.numericUpDown3.Enabled = true;
                this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
                this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
                this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            }
            else
            {
				this.checkBox2.Enabled = false;
                this.chartControl1.Series3D = false;
                this.checkBox2.Enabled = false;
                this.checkBox2.Checked = false;
                this.numericUpDown1.Enabled = false;
                this.numericUpDown2.Enabled = false;
                this.numericUpDown3.Enabled = false;
                this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
                this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
                this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            }
        }

        #endregion

        #region Depth
        /// <summary>
        /// Changing chart area depth in chart control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Depth_ValueChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.ChartArea.Depth = (float)this.numericUpDown1.Value;
        }

        #endregion

        #region Spacing
        /// <summary>
        /// Changing spacing between the series in the chartcontrol.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Spacing_ValueChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.SpacingBetweenSeries = (float)this.numericUpDown2.Value;
        }
        #endregion

        #region Timer
        /// <summary>
        /// Enable and disable the timer to rotate the chartarea.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            try
            {
                this.chartControl1.ChartArea.Rotation += 5;

                if (this.chartControl1.ChartArea.Rotation >= 90)
                    this.chartControl1.ChartArea.Rotation = 30;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region Symbol
        /// <summary>
        /// Set and change the symbol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ChangeSymbol()
        {
            if (this.radioButton4.Checked)
            {
                if (this.comboBox7.SelectedItem.ToString() == "Image")
                {
                    this.chartControl1.Series[0].Style.Symbol.Shape = (ChartSymbolShape)Enum.Parse(typeof(ChartSymbolShape), this.comboBox7.SelectedItem.ToString(), true);
                    this.chartControl1.Series[0].Style.Symbol.ImageIndex = 0;
                }
                else
                    this.chartControl1.Series[0].Style.Symbol.Shape = (ChartSymbolShape)Enum.Parse(typeof(ChartSymbolShape), this.comboBox7.SelectedItem.ToString(), true);
                this.chartControl1.Series[0].Style.Symbol.Color = Color.Red;
            }
            else if (this.radioButton3.Checked)
            {
                if (this.comboBox7.SelectedItem.ToString() == "Image")
                {
                    this.chartControl1.Series[1].Style.Symbol.Shape = (ChartSymbolShape)Enum.Parse(typeof(ChartSymbolShape), this.comboBox7.SelectedItem.ToString(), true);
                    this.chartControl1.Series[1].Style.Symbol.ImageIndex = 0;
                }
                else
                    this.chartControl1.Series[1].Style.Symbol.Shape = (ChartSymbolShape)Enum.Parse(typeof(ChartSymbolShape), this.comboBox7.SelectedItem.ToString(), true);
                this.chartControl1.Series[1].Style.Symbol.Color = Color.Purple;
            }
            else if (this.radioButton1.Checked)
            {
                if (this.comboBox7.SelectedItem.ToString() == "Image")
                {
                    this.chartControl1.Series[2].Style.Symbol.Shape = (ChartSymbolShape)Enum.Parse(typeof(ChartSymbolShape), this.comboBox7.SelectedItem.ToString(), true);
                    this.chartControl1.Series[2].Style.Symbol.ImageIndex = 0;
                }
                else
                    this.chartControl1.Series[2].Style.Symbol.Shape = (ChartSymbolShape)Enum.Parse(typeof(ChartSymbolShape), this.comboBox7.SelectedItem.ToString(), true);
                this.chartControl1.Series[2].Style.Symbol.Color = Color.RoyalBlue;
            }
        }

        private void SymbolShape_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ChangeSymbol();
            this.chartControl1.Redraw(true);
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            ChangeSymbol();
            this.chartControl1.Redraw(true);
        }
        #endregion

        private void colorPickerButton2_Click(object sender, EventArgs e)
        {

        }

       
        #endregion

       
      
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