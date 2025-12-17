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
using System.IO;
using System.Reflection;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;


namespace ChartSeriesSample
{

    public class Form1 : MetroForm
    {
        #region Private Members
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.IContainer components = null;
        ChartCustomPoint cp1 = new ChartCustomPoint();
        ChartCustomPoint cp2 = new ChartCustomPoint();
        ChartCustomPoint cp3 = new ChartCustomPoint();
        ChartCustomPoint cp4 = new ChartCustomPoint();
        int i, j;
        private NumericUpDown numericUpDown9;
        private NumericUpDown numericUpDown2;
        private Label label9;
        private Label label8;
        private Label label5;
        private Label label3;
        private Label label20;
        private Label label30;
        private NumericUpDown numericUpDown10;
        private Label label1;
        private Label label22;
        private NumericUpDown numericUpDown1;
        private Label label13;
        private Label label7;
        private CheckBox checkBox1;
        private Label label16;
        private NumericUpDown numericUpDown4;
        private Label label14;
        private NumericUpDown numericUpDown3;
        private Label label18;
        private NumericUpDown numericUpDown6;
        private Label label2;
        private NumericUpDown numericUpDown5;
        private Label label21;
        private NumericUpDown numericUpDown7;
        private NumericUpDown numericUpDown8;
        private Label label4;
        private string codeString = String.Empty;
        #endregion

        #region Constructor, Main and Dispose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.numericUpDown10 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.label30 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
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
            this.chartControl1.Legend.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(58, 502);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom;
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.BreakInfo.LineSpacing = 3D;
            this.chartControl1.PrimaryXAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight;
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.BreakInfo.LineSpacing = 3D;
            this.chartControl1.PrimaryYAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.Size = new System.Drawing.Size(700, 579);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "chartControl1";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.numericUpDown9);
            this.panel1.Controls.Add(this.numericUpDown3);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.numericUpDown10);
            this.panel1.Controls.Add(this.numericUpDown7);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.numericUpDown8);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.numericUpDown6);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.numericUpDown4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.numericUpDown5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(698, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 584);
            this.panel1.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox1.Location = new System.Drawing.Point(42, 980);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(137, 25);
            this.checkBox1.TabIndex = 112;
            this.checkBox1.Text = "Hide Data Point";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // numericUpDown9
            // 
            this.numericUpDown9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown9.Location = new System.Drawing.Point(43, 942);
            this.numericUpDown9.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown9.Size = new System.Drawing.Size(177, 27);
            this.numericUpDown9.TabIndex = 118;
            this.numericUpDown9.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown9.ValueChanged += new System.EventHandler(this.EmptyPoint_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown3.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown3.Location = new System.Drawing.Point(42, 377);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(178, 27);
            this.numericUpDown3.TabIndex = 91;
            this.numericUpDown3.Value = new decimal(new int[] {
            289,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.CustomPoint2_ValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label20.Location = new System.Drawing.Point(39, 914);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 20);
            this.label20.TabIndex = 117;
            this.label20.Text = "SeriesIndex";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label21.Location = new System.Drawing.Point(38, 651);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 20);
            this.label21.TabIndex = 100;
            this.label21.Text = "X Value";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown10
            // 
            this.numericUpDown10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown10.Location = new System.Drawing.Point(43, 872);
            this.numericUpDown10.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown10.Name = "numericUpDown10";
            this.numericUpDown10.Size = new System.Drawing.Size(177, 27);
            this.numericUpDown10.TabIndex = 116;
            this.numericUpDown10.ValueChanged += new System.EventHandler(this.EmptyPoint_ValueChanged);
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown7.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown7.Location = new System.Drawing.Point(40, 679);
            this.numericUpDown7.Maximum = new decimal(new int[] {
            392,
            0,
            0,
            0});
            this.numericUpDown7.Minimum = new decimal(new int[] {
            66,
            0,
            0,
            0});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(180, 27);
            this.numericUpDown7.TabIndex = 103;
            this.numericUpDown7.Value = new decimal(new int[] {
            190,
            0,
            0,
            0});
            this.numericUpDown7.ValueChanged += new System.EventHandler(this.CustomPoint4_ValueChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label22.Location = new System.Drawing.Point(41, 843);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(83, 20);
            this.label22.TabIndex = 115;
            this.label22.Text = "Point Index";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown8.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown8.Location = new System.Drawing.Point(43, 754);
            this.numericUpDown8.Maximum = new decimal(new int[] {
            280,
            0,
            0,
            0});
            this.numericUpDown8.Minimum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(177, 27);
            this.numericUpDown8.TabIndex = 101;
            this.numericUpDown8.Value = new decimal(new int[] {
            135,
            0,
            0,
            0});
            this.numericUpDown8.ValueChanged += new System.EventHandler(this.CustomPoint4_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label18.Location = new System.Drawing.Point(41, 461);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 20);
            this.label18.TabIndex = 94;
            this.label18.Text = "X Value";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(40, 802);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(136, 34);
            this.label7.TabIndex = 113;
            this.label7.Text = "Empty Points";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(39, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 121;
            this.label8.Text = "Point3";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(39, 721);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 102;
            this.label4.Text = "Y Value";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown2.Location = new System.Drawing.Point(40, 194);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(180, 27);
            this.numericUpDown2.TabIndex = 85;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.CustomPoint1_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label14.Location = new System.Drawing.Point(39, 348);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 20);
            this.label14.TabIndex = 90;
            this.label14.Text = "Y Value";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown6.Location = new System.Drawing.Point(40, 565);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numericUpDown6.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(180, 27);
            this.numericUpDown6.TabIndex = 95;
            this.numericUpDown6.Value = new decimal(new int[] {
            47,
            0,
            0,
            0});
            this.numericUpDown6.ValueChanged += new System.EventHandler(this.CustomPoint3_ValueChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label30.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label30.Location = new System.Drawing.Point(33, 22);
            this.label30.Name = "label30";
            this.label30.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label30.Size = new System.Drawing.Size(169, 32);
            this.label30.TabIndex = 104;
            this.label30.Text = "Custom Points";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(37, 606);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 41);
            this.label9.TabIndex = 122;
            this.label9.Text = " Point4";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown4.Location = new System.Drawing.Point(40, 308);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            2008,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            1999,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(180, 27);
            this.numericUpDown4.TabIndex = 89;
            this.numericUpDown4.Value = new decimal(new int[] {
            2003,
            0,
            0,
            0});
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.CustomPoint2_ValueChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(36, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 27);
            this.label3.TabIndex = 119;
            this.label3.Text = "Point1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(39, 533);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 96;
            this.label2.Text = "Y Value";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label16.Location = new System.Drawing.Point(40, 276);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 20);
            this.label16.TabIndex = 88;
            this.label16.Text = "X Value";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(38, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 27);
            this.label5.TabIndex = 120;
            this.label5.Text = " Point2";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label13.Location = new System.Drawing.Point(36, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 20);
            this.label13.TabIndex = 84;
            this.label13.Text = "Series Index";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(36, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Point Index";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown1.Location = new System.Drawing.Point(40, 124);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(180, 27);
            this.numericUpDown1.TabIndex = 83;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.CustomPoint1_ValueChanged);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown5.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown5.Location = new System.Drawing.Point(42, 492);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            98,
            0,
            0,
            0});
            this.numericUpDown5.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(180, 27);
            this.numericUpDown5.TabIndex = 97;
            this.numericUpDown5.Value = new decimal(new int[] {
            68,
            0,
            0,
            0});
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.CustomPoint3_ValueChanged);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 584);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(648, 529);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Points";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Form Load

        private void Form1_Load(object sender, System.EventArgs e)
        {
            InitializeChartData();
            InitializeControlSettings();
            SetCustomPoints();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            this.chartControl1.Dock = DockStyle.Fill;
        }
        #endregion

        #region InitializeChartData

        protected void InitializeChartData()
        {
            ChartSeries series1 = new ChartSeries();
            series1.Name = "Beverages";
            series1.Type = ChartSeriesType.Column;
            series1.Text = series1.Name;

            series1.Points.Add(1999, 256);
            series1.Points.Add(2000, 451);
            series1.Points.Add(2001, 382);
            series1.Points.Add(2002, 437);
            series1.Points.Add(2003, 321);
            series1.Points.Add(2004, 234);
            series1.Points.Add(2005, 425);
            series1.Points.Add(2006, 257);
            series1.Points.Add(2007, 382);
            series1.Points.Add(2008, 296);
            series1.Style.Font.Bold = true;
            ChartSeries series2 = new ChartSeries();
            series2.Name = "Dairy Products";
            series2.Type = ChartSeriesType.Column;
            series2.Text = series2.Name;

            series2.Points.Add(1999, 358);
            series2.Points.Add(2000, 437);
            series2.Points.Add(2001, 491);
            series2.Points.Add(2002, 480);
            series2.Points.Add(2003, 366);
            series2.Points.Add(2004, 422);
            series2.Points.Add(2005, 361);
            series2.Points.Add(2006, 289);
            series2.Points.Add(2007, 384);
            series2.Points.Add(2008, 461);
            series2.Style.Font.Bold = true;
            this.chartControl1.Series.Add(series1);
            this.chartControl1.Series.Add(series2);

        }
        #endregion

        #region InitializeControlSettings

        private void InitializeControlSettings()
        {
            ChartLegend legend1 = new ChartLegend(chartControl1);
            legend1.Name = "legend1";
            legend1.ColumnsCount = 1;
            legend1.RowsCount = 1;
            legend1.RepresentationType = ChartLegendRepresentationType.None;
            legend1.ShowSymbol = false;
            legend1.Position = ChartDock.Bottom;
            legend1.Alignment = ChartAlignment.Center;

            ChartLegendItem[] customItems = new ChartLegendItem[0];
            ChartLegendItemsCollection clic = new ChartLegendItemsCollection();
            ChartLegendItem cli1 = new ChartLegendItem("That follows a series point");
            cli1.Type = ChartLegendItemType.Circle;
            cli1.Border.Color = Color.Transparent;
            cli1.RepresentationSize = new Size(8, 8);
            cli1.Interior = new BrushInfo(Color.FromArgb(0Xc1, 0X39, 0x2b));
            clic.Add(cli1);

            ChartLegendItem cli2 = new ChartLegendItem("That uses chart coordinates");
            cli2.Type = ChartLegendItemType.InvertedTriangle;
            cli2.RepresentationSize = new Size(8, 8);
            cli2.Interior = new BrushInfo(Color.FromArgb(0Xfc,0Xec,0X29));
            clic.Add(cli2);

            ChartLegendItem cli3 = new ChartLegendItem("That follows a percent type");
            cli3.Type = ChartLegendItemType.Pentagon;
            cli3.RepresentationSize = new Size(8, 8);
            cli3.Interior = new BrushInfo(Color.FromArgb(0X00, 0X66, 0Xcc));
            clic.Add(cli3);

            ChartLegendItem cli4 = new ChartLegendItem("That follows a pixel type");
            cli4.Type = ChartLegendItemType.Triangle;
            cli4.RepresentationSize = new Size(8, 8);
            cli4.Interior = new BrushInfo(Color.FromArgb(0X00, 0Xce, 0X45));
            clic.Add(cli4);

            legend1.CustomItems = clic.ToArray();
            chartControl1.Legends.Add(legend1);
            chartControl1.ShowToolTips = true;

        }
        #endregion

        #region Custom points

        protected void SetCustomPoints()
        {
            // Point that follows a series point:
            cp1.PointIndex = 1;
            cp1.SeriesIndex = 1;
            cp1.CustomType = ChartCustomPointType.PointFollow;
            cp1.Symbol.Shape = ChartSymbolShape.Circle;
            cp1.Offset = 20;
            cp1.Font.Facename = "Times New Roman";
            cp1.Font.Size = 9f;
            cp1.Symbol.Color = Color.FromArgb(0Xc1, 0X39, 0x2b);
            cp1.Alignment = ChartTextOrientation.Up;
            cp1.Symbol.Marker.LineInfo.Width = 4;
            this.chartControl1.CustomPoints.Add(cp1);

            // Point that uses chart coordinates (not tied to a series):
            cp2.CustomType = ChartCustomPointType.ChartCoordinates;
            cp2.XValue = 2003;
            cp2.YValue = 289;
            cp2.Symbol.Shape = ChartSymbolShape.InvertedTriangle;
            cp2.Alignment = ChartTextOrientation.Smart;
            cp2.Color = Color.FromArgb(0Xfc, 0Xec, 0X29);
       
            cp2.Symbol.Color = Color.Yellow;
            this.chartControl1.CustomPoints.Add(cp2);

            // Point that follows a percent type
            cp3.CustomType = ChartCustomPointType.Percent;
            cp3.Symbol.Shape = ChartSymbolShape.Pentagon;
            cp3.Symbol.Color = Color.FromArgb(0X00, 0X66, 0Xcc);
            cp3.XValue = 68;
            cp3.YValue = 47;
            cp3.Offset = 10;
            cp3.Color = Color.Blue;
         
            cp3.Alignment = ChartTextOrientation.Up;
            cp3.Symbol.Marker.LineInfo.Width = 4;
            this.chartControl1.CustomPoints.Add(cp3);

            // Point that follows a pixel type
            cp4.CustomType = ChartCustomPointType.Pixel;
            cp4.Symbol.Shape = ChartSymbolShape.Triangle;
            cp4.Symbol.Color = Color.FromArgb(0X00, 0Xce, 0X45);
            cp4.XValue = 190;
            cp4.YValue = 135;
            cp4.Color = Color.Blue;
        
           
            cp4.Alignment = ChartTextOrientation.Up;
            cp4.Symbol.Marker.LineInfo.Width = 4;
            cp4.Offset = 10;
            this.chartControl1.CustomPoints.Add(cp4);


            cp1.Symbol.Border.DashStyle = DashStyle.Solid;
            cp2.Symbol.Border.DashStyle = DashStyle.Solid;
            cp3.Symbol.Border.DashStyle = DashStyle.Solid;
            cp4.Symbol.Border.DashStyle = DashStyle.Solid;
        }

        #region custom Point location
        private void CustomPoint1_ValueChanged(object sender, EventArgs e)
        {
            cp1.PointIndex = Convert.ToInt32(this.numericUpDown1.Value);
            cp1.SeriesIndex = Convert.ToInt32(this.numericUpDown2.Value);
        }

        private void CustomPoint2_ValueChanged(object sender, EventArgs e)
        {
            cp2.XValue = Convert.ToInt32(this.numericUpDown4.Value);
            cp2.YValue = Convert.ToInt32(this.numericUpDown3.Value);
        }

        private void CustomPoint3_ValueChanged(object sender, EventArgs e)
        {
            cp3.XValue = Convert.ToInt32(this.numericUpDown5.Value);
            cp3.YValue = Convert.ToInt32(this.numericUpDown6.Value);
        }

        private void CustomPoint4_ValueChanged(object sender, EventArgs e)
        {
            cp4.XValue = Convert.ToInt32(this.numericUpDown7.Value);
            cp4.YValue = Convert.ToInt32(this.numericUpDown8.Value);
        }
        #endregion

        #endregion

        #region EmptyPoint
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SetEmptyPoint();
        }


        private void EmptyPoint_ValueChanged(object sender, EventArgs e)
        {
            SetEmptyPoint();
        }

        protected void SetEmptyPoint()
        {
            try
            {
                i = Convert.ToInt32(this.numericUpDown10.Value);
                j = Convert.ToInt32(this.numericUpDown9.Value);
                this.chartControl1.Series[j].Points[i].IsEmpty = this.checkBox1.Checked;
            }
            catch
            {
                MessageBox.Show("Data Point doesnt exists");
            }
            this.chartControl1.Refresh();
        }
        #endregion
               

    }
	/// <summary>
	/// Represents a class that is used to find the licensing file for Syncfusion controls.
	/// </summary>
	public class DemoCommon
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
				return File.ReadAllText(licenseKeyFile);
			}
			return string.Empty;
		}
	}

}
