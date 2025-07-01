#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing.Drawing2D;

namespace ChartLegendSample
{
    public class Form1 : MetroForm
    {
        #region Private Members
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLegendType;
        private System.Windows.Forms.Label label3;
        private Label label8;
        private Label label10;
        private ComboBox comboBox4;
        private ComboBox comboBox1;
        private ComboBox comboBox5;
        private Label label7;
        private Label label12;
        private Label label13;
        private ComboBox comboBox_FontStyle;
        private ColorPickerButton colorPicker_TextColor;
        private NumericUpDown numericUpDown_FontSize;
        private ComboBox comboBox_Fontfamily;
        private ColorPickerButton colorPickerButton1;
        private ComboBox comboBox2;
        private Label label19;
        private ColorPickerButton colorPickerButton2;
        private Label label18;
        private Label label17;
        private CheckBox checkBox1;
        private Label label5;
        private ColorPickerButton colorPickerButton3;
        private Label label21;
        private TextBox textBox4;
        private Label label22;
        private ColorPickerButton colorPickerButton4;
        private Label label23;
        private ComboBox comboBox3;
        private Label label26;
        private NumericUpDown numericUpDown2;
        private Label label27;
        private NumericUpDown numericUpDown3;
        private Label label28;
        private ComboBox comboBox6;
        private ComboBox comboBox7;
        private Label label29;
        private CheckBox checkBox2;
        private CheckBox checkBox4;
        private ToolTip toolTip1;
        private CheckBox checkBox5;
        private ComboBox comboBox8;
        private Label label9;
        private Label label11;
        private NumericUpDown numericUpDown5;
        private CheckBox checkBox7;
        private Label label34;
        private ColorPickerButton colorPickerButton5;
        private Syncfusion.Windows.Forms.Tools.ImageListAdv imageListAdv1;
        private ComboBox comboBox9;
        private Label label42;
        private ChartControl chartControl1;
        private Label label1;
        private Label label2;
        private Label label6;
        private ComboBox comboBox10;
        private Panel panel1;
        private Label label14;
        private Label label30;
        private Label label25;
        private Label label24;
        private Label label20;
        private Label label16;
        private Label label15;
        private Label label31;
        private System.ComponentModel.IContainer components;
        #endregion

        #region Form Constructor, Main And Dispose
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            BorderColor = Color.FromArgb(0xFF, 0xCD, 0xCD, 0xCD);
            BorderThickness = 3;
            CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(75.0f);
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.imageListAdv1 = new Syncfusion.Windows.Forms.Tools.ImageListAdv(this.components);
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorPickerButton3 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.colorPickerButton4 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label31 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLegendType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.colorPicker_TextColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_FontSize = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.colorPickerButton5 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox_FontStyle = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_Fontfamily = new System.Windows.Forms.ComboBox();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.colorPickerButton2 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.colorPickerButton1 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.SuspendLayout();
            // 
            // imageListAdv1
            // 
            this.imageListAdv1.Images.AddRange(new System.Drawing.Image[] {
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images1"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images2"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images3"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images4"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images5"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images6"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images7"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images8"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images9"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images10"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images11"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images12")))});
            // 
            // chartControl1
            // 
            this.chartControl1.BorderAppearance.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(220)))), ((int)(((byte)(231)))));
            this.chartControl1.BorderAppearance.FrameThickness = new Syncfusion.Windows.Forms.Chart.ChartThickness(1F, 1F, 2F, 2F);
            this.chartControl1.BorderAppearance.Interior.ForeColor = System.Drawing.Color.Red;
            this.chartControl1.BorderAppearance.Interior.Width = 1F;
            this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame;
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(226))))), System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(232)))), ((int)(((byte)(243))))));
            this.chartControl1.DataSourceName = "";
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Center;
            this.chartControl1.Legend.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255))))), System.Drawing.Color.Transparent);
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(310, 485);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom;
            this.chartControl1.Legend.RowsCount = 2;
            this.chartControl1.Legend.Spacing = 9;
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.BreakInfo.LineSpacing = 3D;
            this.chartControl1.PrimaryXAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight;
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.DrawGrid = false;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryXAxis.Range = new Syncfusion.Windows.Forms.Chart.MinMaxInfo(0D, 6D, 1D);
            this.chartControl1.PrimaryXAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set;
            this.chartControl1.PrimaryYAxis.BreakInfo.LineSpacing = 3D;
            this.chartControl1.PrimaryYAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Range = new Syncfusion.Windows.Forms.Chart.MinMaxInfo(-100D, 500D, 100D);
            this.chartControl1.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set;
            this.chartControl1.Size = new System.Drawing.Size(700, 581);
            this.chartControl1.TabIndex = 4;
            this.chartControl1.Text = "Essential Chart";
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.Title.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "Essential Chart";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ZoomOutIncrement = 0.20000000298023224D;
            this.chartControl1.ChartFormatAxisLabel += new Syncfusion.Windows.Forms.Chart.ChartFormatAxisLabelEventHandler(this.chartControl1_ChartFormatAxisLabel);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.colorPickerButton3);
            this.panel1.Controls.Add(this.colorPickerButton4);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbLegendType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label42);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.comboBox9);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.comboBox7);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.comboBox6);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.numericUpDown3);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.comboBox10);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.colorPicker_TextColor);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.comboBox5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.numericUpDown_FontSize);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.colorPickerButton5);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.comboBox_FontStyle);
            this.panel1.Controls.Add(this.label34);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.comboBox_Fontfamily);
            this.panel1.Controls.Add(this.numericUpDown5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.comboBox8);
            this.panel1.Controls.Add(this.checkBox7);
            this.panel1.Controls.Add(this.colorPickerButton2);
            this.panel1.Controls.Add(this.colorPickerButton1);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(694, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 581);
            this.panel1.TabIndex = 145;
            // 
            // colorPickerButton3
            // 
            this.colorPickerButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colorPickerButton3.BeforeTouchSize = new System.Drawing.Size(100, 29);
            this.colorPickerButton3.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.colorPickerButton3.IsBackStageButton = false;
            this.colorPickerButton3.Location = new System.Drawing.Point(49, 2119);
            this.colorPickerButton3.Name = "colorPickerButton3";
            this.colorPickerButton3.SelectedAsBackcolor = true;
            this.colorPickerButton3.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colorPickerButton3.Size = new System.Drawing.Size(100, 29);
            this.colorPickerButton3.TabIndex = 14;
            this.colorPickerButton3.UseVisualStyleBackColor = false;
            this.colorPickerButton3.ColorSelected += new System.EventHandler(this.colorPickerButton3_ColorSelected);
            // 
            // colorPickerButton4
            // 
            this.colorPickerButton4.BackColor = System.Drawing.Color.Black;
            this.colorPickerButton4.BeforeTouchSize = new System.Drawing.Size(100, 30);
            this.colorPickerButton4.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.colorPickerButton4.IsBackStageButton = false;
            this.colorPickerButton4.Location = new System.Drawing.Point(49, 1923);
            this.colorPickerButton4.Name = "colorPickerButton4";
            this.colorPickerButton4.SelectedAsBackcolor = true;
            this.colorPickerButton4.SelectedColor = System.Drawing.Color.Black;
            this.colorPickerButton4.Size = new System.Drawing.Size(100, 30);
            this.colorPickerButton4.TabIndex = 14;
            this.colorPickerButton4.UseVisualStyleBackColor = false;
            this.colorPickerButton4.ColorSelected += new System.EventHandler(this.colorPickerButton4_ColorSelected);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label31.Location = new System.Drawing.Point(44, 1509);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(181, 25);
            this.label31.TabIndex = 152;
            this.label31.Text = "Item Representation";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox1.Location = new System.Drawing.Point(51, 2062);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(38, 25);
            this.checkBox1.TabIndex = 95;
            this.checkBox1.Text = " ";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label5.Location = new System.Drawing.Point(46, 2091);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 97;
            this.label5.Text = "Shadow Color";
            // 
            // cmbLegendType
            // 
            this.cmbLegendType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbLegendType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLegendType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLegendType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.cmbLegendType.Location = new System.Drawing.Point(50, 1744);
            this.cmbLegendType.Name = "cmbLegendType";
            this.cmbLegendType.Size = new System.Drawing.Size(153, 28);
            this.cmbLegendType.TabIndex = 4;
            this.cmbLegendType.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(46, 2034);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 102;
            this.label2.Text = "Shadow Visible";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox2.Location = new System.Drawing.Point(51, 1551);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(138, 25);
            this.checkBox2.TabIndex = 111;
            this.checkBox2.Text = "Show CheckBox";
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_1);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Near",
            "Center",
            "Far"});
            this.comboBox3.Location = new System.Drawing.Point(49, 1995);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(153, 28);
            this.comboBox3.TabIndex = 101;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(52, 1717);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Type";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label23.Location = new System.Drawing.Point(47, 1964);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(111, 20);
            this.label23.TabIndex = 100;
            this.label23.Text = "Title Alignment";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label42.Location = new System.Drawing.Point(47, 1654);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(75, 20);
            this.label42.TabIndex = 138;
            this.label42.Text = "Hide Item";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label21.Location = new System.Drawing.Point(47, 1832);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(70, 20);
            this.label21.TabIndex = 95;
            this.label21.Text = "Title Text";
            // 
            // comboBox9
            // 
            this.comboBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox9.Items.AddRange(new object[] {
            "Anguilla",
            "Argentina",
            "Bahamas",
            "Belize",
            "Bolivia",
            "Canada",
            "Chile",
            "Colombia",
            "None"});
            this.comboBox9.Location = new System.Drawing.Point(49, 1679);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(153, 28);
            this.comboBox9.TabIndex = 137;
            this.comboBox9.SelectedIndexChanged += new System.EventHandler(this.comboBox9_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label22.Location = new System.Drawing.Point(46, 1895);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 20);
            this.label22.TabIndex = 98;
            this.label22.Text = "Title Color";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox5.Location = new System.Drawing.Point(51, 1620);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(130, 25);
            this.checkBox5.TabIndex = 117;
            this.checkBox5.Text = "Custom Image";
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.textBox4.Location = new System.Drawing.Point(50, 1858);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(145, 27);
            this.textBox4.TabIndex = 96;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // comboBox7
            // 
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "Bottom",
            "Center",
            "Top"});
            this.comboBox7.Location = new System.Drawing.Point(47, 1462);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(156, 28);
            this.comboBox7.TabIndex = 110;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox4.Location = new System.Drawing.Point(51, 1586);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(124, 25);
            this.checkBox4.TabIndex = 115;
            this.checkBox4.Text = "Show Symbol";
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label26.Location = new System.Drawing.Point(45, 1222);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(81, 20);
            this.label26.TabIndex = 104;
            this.label26.Text = "Row Count";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label29.Location = new System.Drawing.Point(44, 1433);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(110, 20);
            this.label29.TabIndex = 109;
            this.label29.Text = "Text Alignment";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label30.Location = new System.Drawing.Point(44, 1796);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(159, 25);
            this.label30.TabIndex = 151;
            this.label30.Text = "Title And Shadow";
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Near",
            "Center",
            "Far"});
            this.comboBox6.Location = new System.Drawing.Point(47, 1390);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(157, 28);
            this.comboBox6.TabIndex = 108;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label27.Location = new System.Drawing.Point(45, 1290);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(62, 20);
            this.label27.TabIndex = 106;
            this.label27.Text = "Spacing";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label28.Location = new System.Drawing.Point(46, 1360);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(112, 20);
            this.label28.TabIndex = 107;
            this.label28.Text = "Item Alignment";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label25.Location = new System.Drawing.Point(43, 1182);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(122, 25);
            this.label25.TabIndex = 150;
            this.label25.Text = "Item Position";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown3.Location = new System.Drawing.Point(47, 1318);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(156, 27);
            this.numericUpDown3.TabIndex = 105;
            this.numericUpDown3.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label24.Location = new System.Drawing.Point(41, 878);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(141, 25);
            this.label24.TabIndex = 149;
            this.label24.Text = "Item Alignment";
            // 
            // comboBox10
            // 
            this.comboBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox10.Items.AddRange(new object[] {
            "All",
            "Dockable",
            "Movable",
            "None"});
            this.comboBox10.Location = new System.Drawing.Point(46, 1133);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(157, 28);
            this.comboBox10.TabIndex = 87;
            this.comboBox10.SelectedIndexChanged += new System.EventHandler(this.comboBox10_SelectedIndexChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown2.Location = new System.Drawing.Point(49, 1250);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(155, 27);
            this.numericUpDown2.TabIndex = 103;
            this.numericUpDown2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
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
            this.colorPicker_TextColor.Location = new System.Drawing.Point(46, 824);
            this.colorPicker_TextColor.Name = "colorPicker_TextColor";
            this.colorPicker_TextColor.SelectedAsBackcolor = true;
            this.colorPicker_TextColor.SelectedColor = System.Drawing.Color.Black;
            this.colorPicker_TextColor.Size = new System.Drawing.Size(100, 30);
            this.colorPicker_TextColor.TabIndex = 14;
            this.colorPicker_TextColor.UseVisualStyleBackColor = false;
            this.colorPicker_TextColor.ColorSelected += new System.EventHandler(this.colorPicker_TextColor_ColorSelected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label6.Location = new System.Drawing.Point(47, 1107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 88;
            this.label6.Text = "Behavior";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label20.Location = new System.Drawing.Point(41, 556);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(121, 25);
            this.label20.TabIndex = 148;
            this.label20.Text = "Font Settings";
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Near",
            "Center",
            "Far"});
            this.comboBox5.Location = new System.Drawing.Point(46, 1070);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(156, 28);
            this.comboBox5.TabIndex = 79;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(47, 917);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Placement";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label10.Location = new System.Drawing.Point(47, 1043);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 74;
            this.label10.Text = "Alignment";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Top",
            "Bottom",
            "Floating"});
            this.comboBox1.Location = new System.Drawing.Point(46, 1005);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 28);
            this.comboBox1.TabIndex = 78;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(44, 796);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 93;
            this.label1.Text = "Font Color";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Inside",
            "Outside"});
            this.comboBox4.Location = new System.Drawing.Point(46, 944);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(156, 28);
            this.comboBox4.TabIndex = 77;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label8.Location = new System.Drawing.Point(47, 980);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 73;
            this.label8.Text = "Position";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label7.Location = new System.Drawing.Point(44, 726);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 92;
            this.label7.Text = "Font Size";
            // 
            // numericUpDown_FontSize
            // 
            this.numericUpDown_FontSize.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_FontSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown_FontSize.Location = new System.Drawing.Point(47, 754);
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
            this.numericUpDown_FontSize.Size = new System.Drawing.Size(155, 27);
            this.numericUpDown_FontSize.TabIndex = 90;
            this.numericUpDown_FontSize.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown_FontSize.ValueChanged += new System.EventHandler(this.numericUpDown_FontSize_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label12.Location = new System.Drawing.Point(44, 592);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 20);
            this.label12.TabIndex = 88;
            this.label12.Text = "Font Family";
            // 
            // colorPickerButton5
            // 
            this.colorPickerButton5.BackColor = System.Drawing.Color.Black;
            this.colorPickerButton5.BeforeTouchSize = new System.Drawing.Size(100, 30);
            this.colorPickerButton5.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.colorPickerButton5.IsBackStageButton = false;
            this.colorPickerButton5.Location = new System.Drawing.Point(44, 503);
            this.colorPickerButton5.Name = "colorPickerButton5";
            this.colorPickerButton5.SelectedAsBackcolor = true;
            this.colorPickerButton5.SelectedColor = System.Drawing.Color.Black;
            this.colorPickerButton5.Size = new System.Drawing.Size(100, 30);
            this.colorPickerButton5.TabIndex = 14;
            this.colorPickerButton5.UseVisualStyleBackColor = false;
            this.colorPickerButton5.ColorSelected += new System.EventHandler(this.colorPickerButton5_ColorSelected);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label13.Location = new System.Drawing.Point(44, 659);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 20);
            this.label13.TabIndex = 91;
            this.label13.Text = "Font Style";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label16.Location = new System.Drawing.Point(41, 277);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(141, 25);
            this.label16.TabIndex = 147;
            this.label16.Text = "Border Settings";
            // 
            // comboBox_FontStyle
            // 
            this.comboBox_FontStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_FontStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_FontStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox_FontStyle.FormattingEnabled = true;
            this.comboBox_FontStyle.Location = new System.Drawing.Point(47, 686);
            this.comboBox_FontStyle.Name = "comboBox_FontStyle";
            this.comboBox_FontStyle.Size = new System.Drawing.Size(155, 28);
            this.comboBox_FontStyle.TabIndex = 89;
            this.comboBox_FontStyle.SelectedIndexChanged += new System.EventHandler(this.comboBox_FontStyle_SelectedIndexChanged);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label34.Location = new System.Drawing.Point(41, 478);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(94, 20);
            this.label34.TabIndex = 106;
            this.label34.Text = "Border Color";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label11.Location = new System.Drawing.Point(42, 411);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 20);
            this.label11.TabIndex = 104;
            this.label11.Text = "Width";
            // 
            // comboBox_Fontfamily
            // 
            this.comboBox_Fontfamily.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_Fontfamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Fontfamily.DropDownWidth = 150;
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
            this.comboBox_Fontfamily.Location = new System.Drawing.Point(47, 621);
            this.comboBox_Fontfamily.Name = "comboBox_Fontfamily";
            this.comboBox_Fontfamily.Size = new System.Drawing.Size(155, 28);
            this.comboBox_Fontfamily.TabIndex = 87;
            this.comboBox_Fontfamily.SelectedIndexChanged += new System.EventHandler(this.comboBox_Fontfamily_SelectedIndexChanged);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown5.Location = new System.Drawing.Point(45, 441);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(158, 27);
            this.numericUpDown5.TabIndex = 103;
            this.numericUpDown5.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label9.Location = new System.Drawing.Point(42, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 100;
            this.label9.Text = "Dash Style";
            // 
            // comboBox8
            // 
            this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "DashDot",
            "DashDotDot",
            "Custom"});
            this.comboBox8.Location = new System.Drawing.Point(45, 374);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(157, 28);
            this.comboBox8.TabIndex = 101;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Checked = true;
            this.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox7.Location = new System.Drawing.Point(45, 314);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(113, 24);
            this.checkBox7.TabIndex = 102;
            this.checkBox7.Text = "Show Border";
            this.checkBox7.UseVisualStyleBackColor = false;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // colorPickerButton2
            // 
            this.colorPickerButton2.BackColor = System.Drawing.Color.White;
            this.colorPickerButton2.BeforeTouchSize = new System.Drawing.Size(100, 30);
            this.colorPickerButton2.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.colorPickerButton2.IsBackStageButton = false;
            this.colorPickerButton2.Location = new System.Drawing.Point(45, 228);
            this.colorPickerButton2.Name = "colorPickerButton2";
            this.colorPickerButton2.SelectedAsBackcolor = true;
            this.colorPickerButton2.SelectedColor = System.Drawing.Color.White;
            this.colorPickerButton2.Size = new System.Drawing.Size(100, 30);
            this.colorPickerButton2.TabIndex = 14;
            this.colorPickerButton2.UseVisualStyleBackColor = false;
            this.colorPickerButton2.ColorSelected += new System.EventHandler(this.colorPickerButton2_ColorSelected);
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.BackColor = System.Drawing.Color.Transparent;
            this.colorPickerButton1.BeforeTouchSize = new System.Drawing.Size(100, 30);
            this.colorPickerButton1.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.colorPickerButton1.IsBackStageButton = false;
            this.colorPickerButton1.Location = new System.Drawing.Point(45, 158);
            this.colorPickerButton1.Name = "colorPickerButton1";
            this.colorPickerButton1.SelectedAsBackcolor = true;
            this.colorPickerButton1.SelectedColor = System.Drawing.Color.Transparent;
            this.colorPickerButton1.Size = new System.Drawing.Size(100, 30);
            this.colorPickerButton1.TabIndex = 14;
            this.colorPickerButton1.UseVisualStyleBackColor = false;
            this.colorPickerButton1.ColorSelected += new System.EventHandler(this.colorPickerButton1_ColorSelected);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label15.Location = new System.Drawing.Point(41, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 25);
            this.label15.TabIndex = 146;
            this.label15.Text = "Back Interior";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.DropDownWidth = 150;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(45, 95);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(157, 28);
            this.comboBox2.TabIndex = 93;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label17.Location = new System.Drawing.Point(42, 201);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 20);
            this.label17.TabIndex = 89;
            this.label17.Text = "Interior 2";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label14.Location = new System.Drawing.Point(-286, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(2, 15536);
            this.label14.TabIndex = 145;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label18.Location = new System.Drawing.Point(41, 133);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 20);
            this.label18.TabIndex = 90;
            this.label18.Text = "Interior 1";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label19.Location = new System.Drawing.Point(42, 68);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(102, 20);
            this.label19.TabIndex = 92;
            this.label19.Text = "Gradient Style";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 581);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(844, 608);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Legend";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            InitializeChartData();
       
            foreach (string fontstyle in Enum.GetNames(typeof(System.Drawing.FontStyle)))
                this.comboBox_FontStyle.Items.Add(fontstyle);

            foreach (string gradientstyle in Enum.GetNames(typeof(GradientStyle)))
                this.comboBox2.Items.Add(gradientstyle);

            this.comboBox_FontStyle.SelectedIndex = 0;
            this.comboBox_Fontfamily.SelectedIndex = 13;
            this.comboBox2.SelectedIndex = 4;
            this.chartControl1.Legend.ShowItemsShadow = false;
           
            this.comboBox8.SelectedIndex = 0;
            this.comboBox3.SelectedIndex = 1;
            this.comboBox1.SelectedIndex = 3;
            this.comboBox4.SelectedIndex = 1;
            this.comboBox5.SelectedIndex = 1;
            this.comboBox6.SelectedIndex = 0;
            this.comboBox7.SelectedIndex = 1;
            this.comboBox9.SelectedIndex = 8;
            this.comboBox10.SelectedIndex = 0;
            this.chartControl1.Legend.ShowBorder = true;
            this.chartControl1.Legend.VisibleCheckBox = true;

            foreach (string representationtype in Enum.GetNames(typeof(Syncfusion.Windows.Forms.Chart.ChartLegendRepresentationType)))
            {
                this.cmbLegendType.Items.Add(representationtype);
            }
            this.cmbLegendType.SelectedIndex = 2;
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;

        }
        #endregion

        #region Helper Methods
        #region InitializeChartData
        private void InitializeChartData()
        {
            this.chartControl1.Text = "Population Statistics";

            ChartSeries series1 = new ChartSeries();
            series1.Name = "Anguilla";
            series1.Text = series1.Name;
            series1.SeriesIndexedModelImpl = new ArrayModel(new double[] { 1000.500, 1100.797, 1500.000 });
            series1.Type = ChartSeriesType.Column;
            this.chartControl1.Series.Add(series1);
            series1.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            series1.Style.ImageIndex = 0;

            ChartSeries series2 = new ChartSeries();
            series2.Name = "Argentina";
            series2.Text = series2.Name;
            series2.SeriesIndexedModelImpl = new ArrayModel(new double[] { 25955.82, 36955.182, 38955.182 });
            series2.Type = ChartSeriesType.Column;
            this.chartControl1.Series.Add(series2);
            series2.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            series2.Style.ImageIndex = 1;

            ChartSeries series3 = new ChartSeries();
            series3.Name = "Bahamas";
            series3.Text = series3.Name;
            series3.SeriesIndexedModelImpl = new ArrayModel(new double[] { 2040.082, 2940.982, 2960.982 });
            series3.Type = ChartSeriesType.Column;
            this.chartControl1.Series.Add(series3);
            series3.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            series3.Style.ImageIndex = 3;

            ChartSeries series4 = new ChartSeries();
            series4.Name = "Belize";
            series4.Text = series4.Name;
            series4.SeriesIndexedModelImpl = new ArrayModel(new double[] { 2350.183, 2490.183, 2550.183 });
            series4.Type = ChartSeriesType.Column;
            this.chartControl1.Series.Add(series4);
            series4.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            series4.Style.ImageIndex = 5;

            ChartSeries series5 = new ChartSeries();
            series5.Name = "Bolivia";
            series5.Text = series5.Name;
            series5.SeriesIndexedModelImpl = new ArrayModel(new double[] { 7812.520, 8152.620, 8002.620 });
            series5.Type = ChartSeriesType.Column;
            this.chartControl1.Series.Add(series5);
            series5.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            series5.Style.ImageIndex = 6;

            ChartSeries series6 = new ChartSeries();
            series6.Name = "Canada";
            series6.Text = series6.Name;
            series6.SeriesIndexedModelImpl = new ArrayModel(new double[] { 30281.092, 31281.092, 31581.092 });
            series6.Type = ChartSeriesType.Column;
            this.chartControl1.Series.Add(series6);
            series6.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            series6.Style.ImageIndex = 8;

        

            ChartSeries series7 = new ChartSeries();
            series7.Name = "Chile";
            series7.Text = series7.Name;
            series7.SeriesIndexedModelImpl = new ArrayModel(new double[] { 10153.797, 15153.797, 16153.797 });
            series7.Type = ChartSeriesType.Column;
            this.chartControl1.Series.Add(series7);
            series7.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            series7.Style.ImageIndex = 9;
          

            ChartSeries series8 = new ChartSeries();
            series8.Name = "Colombia";
            series8.Text = series8.Name;
            series8.SeriesIndexedModelImpl = new ArrayModel(new double[] { 32685.655, 35685.655, 37685.655 });
            series8.Type = ChartSeriesType.Column;
            this.chartControl1.Series.Add(series8);
            series8.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            series8.Style.ImageIndex = 10;
          

            this.chartControl1.Legend.OnlyColumnsForFloating = false;            
            this.chartControl1.Indexed = true;


            for (int i = 0; i < this.chartControl1.Series.Count; i++)
            {
                this.chartControl1.Series[i].Style.Border.Color = Color.Transparent;
            }

        }
        #endregion

        #region ChangeFont
        private void ChangeFont()
        {
            if (this.comboBox_Fontfamily.SelectedItem != null)
            {
                FontStyle fs = (FontStyle)Enum.Parse(typeof(FontStyle), this.comboBox_FontStyle.SelectedItem.ToString(), true);
                this.chartControl1.Legend.Font = new Font(this.comboBox_Fontfamily.SelectedItem.ToString(), (float)this.numericUpDown_FontSize.Value, fs);
            }
        }

        #endregion


        #endregion

        #region Events

        private void cmbFontFace_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        #region ChartFormatAxisLabel
        private void chartControl1_ChartFormatAxisLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {

            if (e.AxisOrientation == ChartOrientation.Horizontal)
            {
                switch ((int)e.Value)
                {
                    case 0:
                        e.Label = "1995";
                        break;
                    case 1:
                        e.Label = "2000";
                        break;
                    case 2:
                        e.Label = "2005";
                        break;
                    default:
                        e.Label = "";
                        break;

                }

            }

            e.Handled = true;
        }
        #endregion

        #region Legend Alignment
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.LegendsPlacement = (ChartPlacement)Enum.Parse(typeof(ChartPlacement), this.comboBox4.SelectedItem.ToString(), true);

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.chartControl1.LegendPosition = (ChartDock)Enum.Parse(typeof(ChartDock), this.comboBox1.SelectedItem.ToString(), true);
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.LegendAlignment = (ChartAlignment)Enum.Parse(typeof(ChartAlignment), this.comboBox5.SelectedItem.ToString(), true);
        }

        #endregion

        #region Font Settings
        private void comboBox_Fontfamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void comboBox_FontStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void numericUpDown_FontSize_ValueChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void colorPicker_TextColor_ColorSelected(object sender, EventArgs e)
        {
            foreach (ChartLegendItem item in this.chartControl1.Legend.Items)
            {
                item.TextColor = this.colorPicker_TextColor.SelectedColor;
            }
           
            this.Refresh();

        }
        #endregion

        #region  BackInterior
        protected void SetBackInterior()
        {
            this.chartControl1.Legend.BackInterior = new BrushInfo((GradientStyle)Enum.Parse(typeof(GradientStyle), this.comboBox2.SelectedItem.ToString(), true), this.colorPickerButton1.SelectedColor, this.colorPickerButton2.SelectedColor);
        }
        private void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            SetBackInterior();
           
            this.Refresh();
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SetBackInterior();
        }

        private void colorPickerButton2_ColorSelected(object sender, EventArgs e)
        {
            SetBackInterior();
          
            this.Refresh();
        }
        #endregion

        #region Shadow
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.chartControl1.Legend.ShowItemsShadow = true;
                

            }
            else
            {
                this.chartControl1.Legend.ShowItemsShadow = false;
               

            }
        }

        private void colorPickerButton3_ColorSelected(object sender, EventArgs e)
        {
            this.chartControl1.Legend.ItemsShadowColor = this.colorPickerButton3.SelectedColor;
        }


        #endregion

        #region Title
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.chartControl1.Legend.Text = this.textBox4.Text;
        }

        private void colorPickerButton4_ColorSelected(object sender, EventArgs e)
        {
            this.chartControl1.Legend.ForeColor = this.colorPickerButton4.SelectedColor;
           
            this.Refresh();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.Legend.TextAlignment = (StringAlignment)Enum.Parse(typeof(StringAlignment), this.comboBox3.SelectedItem.ToString(), true);
        }
        #endregion

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.Legend.RowsCount = (int)this.numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.Legend.Spacing = (int)this.numericUpDown3.Value;

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.Legend.ItemsAlignment = (StringAlignment)Enum.Parse(typeof(StringAlignment), this.comboBox6.SelectedItem.ToString(), true);
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.Legend.ItemsTextAligment = ( Syncfusion.Windows.Forms.Chart.VerticalAlignment)Enum.Parse(typeof(Syncfusion.Windows.Forms.Chart.VerticalAlignment), this.comboBox7.SelectedItem.ToString(), true);

        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            this.chartControl1.Legend.VisibleCheckBox = this.checkBox2.Checked;
        }

        #region HideItem


        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ChartLegendItem item in this.chartControl1.Legend.Items)
            {
                item.Visible = true;
            }
            this.chartControl1.Refresh();
            if (this.comboBox9.SelectedIndex < 8)
            {
                this.chartControl1.Legend.Items[(int)this.comboBox9.SelectedIndex].Visible = false;
                this.chartControl1.Refresh();
            }

        }



        #endregion

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox4.Checked)
            {
                //Set symbol for first series
                this.chartControl1.Series[1].Style.Symbol.Shape = ChartSymbolShape.Circle;
                this.chartControl1.Series[1].Style.Symbol.Color = Color.Red;
                this.chartControl1.Series[1].Style.Symbol.Size = new Size(7, 7);
                this.chartControl1.Legend.ShowSymbol = true;
            }
            else
            {
                this.chartControl1.Series[1].Style.Symbol.Shape = ChartSymbolShape.None;
                this.chartControl1.Legend.ShowSymbol = false;
            }
            this.chartControl1.Refresh();
        }
        private void comboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Legend.RepresentationType = (ChartLegendRepresentationType)Enum.Parse(typeof(ChartLegendRepresentationType), this.cmbLegendType.SelectedItem.ToString(), true);


        }
        #region Custom Image
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox5.Checked)
            {
                //An Item is added with custom image. 
                ChartLegendItem cli = new ChartLegendItem("Custom Image");
                ChartLegendItemsCollection clic = new ChartLegendItemsCollection();
                cli.Type = ChartLegendItemType.Image;
                cli.ImageList = new ChartImageCollection();
                cli.ImageList.Add(this.imageListAdv1.Images[12]);
                cli.ImageIndex = 0;
                clic.Add(cli);
                this.chartControl1.Legend.CustomItems = clic.ToArray();

                //  //Custom image could be set for existing items with the below code
                //  this.chartControl1.Legend.Items[0].ImageList = new ChartImageCollection();
                //  this.chartControl1.Legend.Items[0].ImageList.Add(this.imageListAdv1.Images[12]);
                //  this.chartControl1.Legend.Items[0].ImageIndex = 0;
                //    this.chartControl1.Legend.Items[0].Type = ChartLegendItemType.Image;

            }
            else
            {
                this.chartControl1.Legend.CustomItems = null;
            }
        }
        #endregion



        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.chartControl1.Legend.Border.DashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), this.comboBox8.SelectedItem.ToString(), true);
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.Legend.Border.Width = (int)this.numericUpDown5.Value;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox7.Checked)
            {
                this.comboBox8.Enabled = true;
                
                this.numericUpDown5.Enabled = true;
                this.chartControl1.Legend.ShowBorder = true;
            }

            else
            {
                this.comboBox8.Enabled = false;
               
                this.numericUpDown5.Enabled = false;
                this.chartControl1.Legend.ShowBorder = false;
            }
        }

        private void colorPickerButton5_ColorSelected(object sender, EventArgs e)
        {
            this.chartControl1.Legend.Border.ForeColor = this.colorPickerButton5.SelectedColor;
           
            this.Refresh();
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.Legend.Behavior = (ChartDockingFlags)Enum.Parse(typeof(ChartDockingFlags), this.comboBox10.SelectedItem.ToString(), true);
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
