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

using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms.Chart.Statistics;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;

namespace ChartStatisticalFormulas
{
    public class Form1 : Syncfusion.Windows.Forms.MetroForm
    {
        #region Private Members

        private ChartSeries series1;
        private ChartSeries series2;
        private ChartSeries series3;

        private double sqrtVarianceOfFirstSeries; //Standard deviation of the first series.
        private double sqrtVarianceOfSecondSeries; //Standard deviation of the second series.
        private double sqrtVarianceOfThirdSeries; //Standard deviation of the third series.
        private double meanOfFirstSeries; //Mean of the first series.
        private double meanOfSecondSeries; //Mean of the second series.
        private double meanOfThirdSeries; //Mean of the third series.
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel Panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.CheckBox checkBox1;
        private Label label31;
        private ToolTip toolTip1;
        private Label label7;
        private Label label8;
        private Panel panel1;
        private ChartControl chartControl1;
        private IContainer components;
        #endregion

        #region Form's Constructor, Main And Dispose
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Panel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label31 = new System.Windows.Forms.Label();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.Panel2)).BeginInit();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.richTextBox1.Location = new System.Drawing.Point(35, 604);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(168, 101);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Panel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.Panel2.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.Panel2.BorderColor = System.Drawing.Color.Transparent;
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Panel2.Controls.Add(this.label31);
            this.Panel2.Controls.Add(this.numericUpDown6);
            this.Panel2.Controls.Add(this.checkBox1);
            this.Panel2.Controls.Add(this.label7);
            this.Panel2.Controls.Add(this.button1);
            this.Panel2.Controls.Add(this.label6);
            this.Panel2.Controls.Add(this.comboBox1);
            this.Panel2.Controls.Add(this.numericUpDown4);
            this.Panel2.Controls.Add(this.numericUpDown3);
            this.Panel2.Controls.Add(this.numericUpDown5);
            this.Panel2.Controls.Add(this.numericUpDown2);
            this.Panel2.Controls.Add(this.numericUpDown1);
            this.Panel2.Controls.Add(this.label5);
            this.Panel2.Controls.Add(this.label4);
            this.Panel2.Controls.Add(this.label3);
            this.Panel2.Controls.Add(this.label2);
            this.Panel2.Controls.Add(this.label1);
            this.Panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Panel2.Location = new System.Drawing.Point(-13, 3);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(247, 564);
            this.Panel2.TabIndex = 2;
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(32, 678);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(20, 20);
            this.label31.TabIndex = 41;
            this.toolTip1.SetToolTip(this.label31, "Tests if the samples means difference is equal to Hyphotetized mean difference.");
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDown6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown6.Location = new System.Drawing.Point(63, 470);
            this.numericUpDown6.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.ReadOnly = true;
            this.numericUpDown6.Size = new System.Drawing.Size(168, 27);
            this.numericUpDown6.TabIndex = 12;
            this.numericUpDown6.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown6.ValueChanged += new System.EventHandler(this.numericUpDown6_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox1.Location = new System.Drawing.Point(63, 503);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 25);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "3D View";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(59, 30);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(166, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Statistical Tests";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(63, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "PERFORM T TEST";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label6.Location = new System.Drawing.Point(59, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sample 3 Deviation";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox1.Location = new System.Drawing.Point(63, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDown4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown4.Location = new System.Drawing.Point(63, 315);
            this.numericUpDown4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.ReadOnly = true;
            this.numericUpDown4.Size = new System.Drawing.Size(168, 27);
            this.numericUpDown4.TabIndex = 8;
            this.numericUpDown4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDown3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown3.Location = new System.Drawing.Point(63, 250);
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.ReadOnly = true;
            this.numericUpDown3.Size = new System.Drawing.Size(168, 27);
            this.numericUpDown3.TabIndex = 7;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDown5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown5.Location = new System.Drawing.Point(63, 404);
            this.numericUpDown5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.ReadOnly = true;
            this.numericUpDown5.Size = new System.Drawing.Size(168, 27);
            this.numericUpDown5.TabIndex = 9;
            this.numericUpDown5.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDown2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown2.Location = new System.Drawing.Point(63, 186);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.ReadOnly = true;
            this.numericUpDown2.Size = new System.Drawing.Size(168, 27);
            this.numericUpDown2.TabIndex = 6;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown1.Location = new System.Drawing.Point(63, 119);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(168, 27);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label5.Location = new System.Drawing.Point(63, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 40);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hyphotetized mean \r\nDifference";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(63, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sample 2 Deviation";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(63, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sample 2 Mean";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(63, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sample 1 Deviation";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(63, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sample 1 Mean";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2.Location = new System.Drawing.Point(15, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "Exchange Samples";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(30, 570);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(131, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "Test Result";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Dock = DockStyle.Right;
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Panel2);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(709, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 590);
            this.panel1.TabIndex = 7;
            // 
            // chartControl1
            // 
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.DataSourceName = "";
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.Legend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(58, 495);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom;
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(-1, 3);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.Size = new System.Drawing.Size(704, 572);
            this.chartControl1.TabIndex = 8;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "chartControl1";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 584);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(668, 620);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistical Formulas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Panel2)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        #region Form1 Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.chartControl1.PrimaryXAxis.Title = "Sample X values";
            this.chartControl1.PrimaryYAxis.Title = "Frequency of occurrence";
            sqrtVarianceOfFirstSeries = 10;
            sqrtVarianceOfSecondSeries = 5;
            meanOfFirstSeries = 15;
            meanOfSecondSeries = 1;
            sqrtVarianceOfThirdSeries = 7;
            meanOfThirdSeries = 4;
            FillControl();
            UpdateChart();
            this.chartControl1.Dock = DockStyle.Fill;
            this.chartControl1.Skins = Skins.Metro;
        }
        #endregion

        #region Helper Methods
        #region FillControl
        /// <summary>
        /// Fills the combobox.
        /// </summary>
        protected void FillControl()
        {
            this.comboBox1.Items.Add("Statistical Functions");
            this.comboBox1.Items.Add("Perform Anova Test");
            this.comboBox1.Items.Add("Perform F Test");
            this.comboBox1.Items.Add("Perform T Test");
            this.comboBox1.Items.Add("Perform Z Test");
            this.comboBox1.SelectedIndex = 0;
        }
        #endregion

        #region UpdateChart
        /// <summary>
        /// Designs the side panel and updates the chartcontrol.
        /// </summary>
        protected void UpdateChart()
        {
            this.SuspendLayout();

            if (!this.Contains(this.Panel2))
                this.Controls.Add(this.Panel2);
            if (!this.Panel2.Contains(this.label5))
            {
                this.Panel2.Controls.Add(this.label5);
                this.Panel2.Controls.Add(this.numericUpDown5);
                this.Panel2.Controls.Remove(this.button2);
                this.Panel2.Controls.Remove(this.label6);
                this.Panel2.Controls.Remove(this.numericUpDown6);
            }
            this.richTextBox1.Clear();
            switch (this.comboBox1.SelectedIndex)
            {
                case 0:
                    InitializeChartBasicStatisticalFunctions();
                    break;
                case 1:
                    InitializeAnovaChartData();
                    Color[] color3 = new Color[] { Color.FromArgb(255, 153, 53), Color.FromArgb(253, 205, 154), Color.FromArgb(255, 153, 53) };
                    this.chartControl1.Series[2].Style.Interior = new BrushInfo(Color.FromArgb(200, 199, 23, 33));
                    this.chartControl1.Series[2].Style.Border.Color = Color.Gray;

                    break;
                case 2:
                    InitializeFTestChartData();
                    break;
                case 3:
                    InitializeTTestChartData();
                    break;
                case 4:
                    InitializeZTestChartData();
                    break;
                default:
                    InitializeChartBasicStatisticalFunctions();
                    break;
            }

            this.ResumeLayout();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }
        #endregion

        #region InitializeChartData
        /// <summary>
        /// Initializes chart data.
        /// </summary>
        /// <param name="numPoints"></param>
        /// <param name="hintervals"></param>
        protected void InitializeChartData(int numPoints, int hintervals)
        {
            //Clears the series collection of the chartcontrol.
            chartControl1.Series.Clear();

            //Initializes a new series with chart type as Histogram.
            series1 = new ChartSeries();
            series1.Name = "Sample 1";
            series1.Type = ChartSeriesType.Histogram;
            series1.Text = series1.Name;

            for (int j = 0; j < numPoints; j++)
            {
                //making normally distributed sample with meanOfFirstSeries as Mean, and sqrtVarianceOfFirstSeries as Standard deviation
                double p = 1.0 / (numPoints * numPoints) + ((double)j) / (numPoints);
                double x = meanOfFirstSeries + sqrtVarianceOfFirstSeries * UtilityFunctions.InverseNormalDistribution(p);

                //Adds the data point.
                series1.Points.Add(x, 0);
            }

            //Turns on the histogram normal distribution curve.
            series1.ConfigItems.HistogramItem.ShowNormalDistribution = true;

            //Specifies the number of histogram intervals to be drawn.
            series1.ConfigItems.HistogramItem.NumberOfIntervals = hintervals;

            //Adds the series to the series collection of the chartcontrol.
            this.chartControl1.Series.Add(series1);

            //Initializes a new series with chart type as Histogram.
            series2 = new ChartSeries();
            series2.Name = "Sample 2";
            series2.Type = ChartSeriesType.Histogram;
            series2.Text = series2.Name;

            for (int j = 0; j < numPoints; j++)
            {
                //making normally distributed sample
                double p = 1.0 / (numPoints * numPoints) + ((double)j) / (numPoints);
                double x = meanOfSecondSeries + sqrtVarianceOfSecondSeries * UtilityFunctions.InverseNormalDistribution(p);

                //Adds the data point.
                series2.Points.Add(x, 0);
            }

            //Turns on the histogram normal distribution curve.
            series2.ConfigItems.HistogramItem.ShowNormalDistribution = true;

            //Specifies the number of histogram intervals to be drawn.
            series2.ConfigItems.HistogramItem.NumberOfIntervals = hintervals;

            //Adds the series to the series collection of the chartcontrol.
            this.chartControl1.Series.Add(series2);

            if (this.comboBox1.SelectedIndex == 1)
            {
                //Initializes a new series with chart type as Histogram.
                series3 = new ChartSeries();
                series3.Name = "sample 3";
                series3.Type = ChartSeriesType.Histogram;
                series3.Text = series3.Name;

                for (int j = 0; j < numPoints; j++)
                {
                    //making normally distributed sample
                    double p = 1.0 / (numPoints * numPoints) + ((double)j) / (numPoints);
                    double x = meanOfThirdSeries + sqrtVarianceOfThirdSeries * UtilityFunctions.InverseNormalDistribution(p);

                    //Adds the data point.
                    series3.Points.Add(x, 0);
                }

                //Turns on the histogram normal distribution curve.
                series3.ConfigItems.HistogramItem.ShowNormalDistribution = true;

                //Specifies the number of histogram intervals to be drawn.
                series3.ConfigItems.HistogramItem.NumberOfIntervals = hintervals;

                //Adds the series to the series collection of the chartcontrol.
                this.chartControl1.Series.Add(series3);
            }
        }
        #endregion

        #region InitializeAnovaChartData
        /// <summary>
        /// Performes Anova Test on Chart Data.
        /// </summary>
        protected void InitializeAnovaChartData()
        {
            label5.Enabled = true;
            numericUpDown5.Enabled = true;
            label6.Enabled = true;
            numericUpDown6.Enabled = true;

            InitializeChartData(10, 50);

            this.chartControl1.Text = "ANOVA Test Sample";
            this.label5.Text = "Sample 3 Mean";
            this.button1.Text = "Perform Anova Test";
            this.toolTip1.SetToolTip(this.label31, "Tests if the samples means are equal (The number of samples can be bigger than 2)");
        }
        #endregion

        #region InitializeFTestChartData
        /// <summary>
        /// Performes F Test of chart data.
        /// </summary>
        protected void InitializeFTestChartData()
        {
            if (!this.Panel2.Contains(this.button2))
            {
                label5.Enabled = false;
                numericUpDown5.Enabled = false;
                label6.Enabled = false;
                numericUpDown6.Enabled = false;                
            }

            InitializeChartData(30, 40);
            this.numericUpDown5.Visible = true;
            this.chartControl1.Text = "F Test Sample";
            this.button1.Text = "Perform F Test";
            this.toolTip1.SetToolTip(this.label31, "Tests if the samples variances are equal");
        }
        #endregion

        #region InitializeTTestChartData
        /// <summary>
        /// Performes T Test on Chart data.
        /// </summary>
        protected void InitializeTTestChartData()
        {
            InitializeChartData(30, 40);
            label5.Enabled = true;
            numericUpDown5.Enabled = true;
            label6.Enabled = true;
            numericUpDown6.Enabled = true;
            this.chartControl1.Text = "T Test Sample";
            this.label5.Text = "Hyphotetized mean\nDifference";
            this.button1.Text = "Perform T Test";
            this.toolTip1.SetToolTip(this.label31, "Tests if the samples means difference is equal to Hyphotetized mean difference");
        }
        #endregion

        #region InitializeZTestChartData
        /// <summary>
        /// Performes Z Test on Chart Data.
        /// </summary>
        protected void InitializeZTestChartData()
        {
            InitializeChartData(30, 40); 
            label5.Enabled = true;
            numericUpDown5.Enabled = true;
            label6.Enabled = true;
            numericUpDown6.Enabled = true;
            this.chartControl1.Text = "Z Test Sample";
            this.label5.Text = "Hyphotetized mean\nDifference";
            this.button1.Text = "Perform Z Test";
            this.toolTip1.SetToolTip(this.label31, "Tests if the samples means difference is equal to Hyphotetized mean difference");
        }
        #endregion

        #region InitializeChartBasicStatisticalFunctions
        /// <summary>
        /// Performes basic statistical calculations on Chart data.
        /// </summary>
        protected void InitializeChartBasicStatisticalFunctions()
        {
            label5.Enabled = true;
            numericUpDown5.Enabled = true;
            label6.Enabled = true;
            numericUpDown6.Enabled = true;

            this.chartControl1.Series.Clear();

            //Initializes a Column chart.
            series1 = new ChartSeries();
            series1.Name = "Sample 1";
            series1.Type = ChartSeriesType.Column;
            series1.Text = series1.Name;

            //Adds the datapoints to the series.
            series1.Points.Add(1, 345);
            series1.Points.Add(2, 256);
            series1.Points.Add(3, 491);
            series1.Points.Add(4, 382);
            series1.Points.Add(5, 437);
            series1.Points.Add(6, 321);
            series1.Points.Add(7, 412);
            series1.Points.Add(8, 451);
            series1.Points.Add(9, 490);
            series1.Points.Add(10, 366);

            //Adds the series to the series collection of the chartcontrol.
            this.chartControl1.Series.Add(series1);

            //Initializes a Column chart.
            series2 = new ChartSeries();
            series2.Name = "Sample 2";
            series2.Type = ChartSeriesType.Column;
            series2.Text = series2.Name;

            //Adds the datapoints to the series.
            series2.Points.Add(1, 245);
            series2.Points.Add(2, 156);
            series2.Points.Add(3, 391);
            series2.Points.Add(4, 282);
            series2.Points.Add(5, 337);
            series2.Points.Add(6, 221);
            series2.Points.Add(7, 312);
            series2.Points.Add(8, 351);
            series2.Points.Add(9, 390);
            series2.Points.Add(10, 266);

            //Adds the series to the series collection of the chartcontrol.
            this.chartControl1.Series.Add(series2);

            this.chartControl1.PrimaryXAxis.Title = "X Values";
            this.chartControl1.PrimaryYAxis.Title = "Y Values";
            this.chartControl1.Text = "Basic Statistical Functions";
            this.label5.Text = "Hyphotetized mean \nDifference";
            CalculateValues(series1);
        }
        #endregion

        #region CalculateValues
        //Calculates and displays the statistical values.
        protected void CalculateValues(ChartSeries series)
        {
            string val = "";

            val += "Mean = " + BasicStatisticalFormulas.Mean(series).ToString() + "\r\n";
            val += "Median = " + BasicStatisticalFormulas.Median(series).ToString() + "\r\n";
            val += "Standard Deviation = " + BasicStatisticalFormulas.StandardDeviation(series, true).ToString() + "\r\n";
            val += "Variance = " + BasicStatisticalFormulas.Variance(series, true).ToString() + "\r\n";
            val += "Variance Based Estimator = " + BasicStatisticalFormulas.VarianceBiasedEstimator(series).ToString() + "\r\n";
            val += "Variance UnBased Estimator = " + BasicStatisticalFormulas.VarianceUnbiasedEstimator(series).ToString() + "\r\n";
            val += "Correlation Co-efficient = " + BasicStatisticalFormulas.Correlation(this.chartControl1.Series[0], this.chartControl1.Series[1]).ToString() + "\r\n";
            val += "Covariance = " + BasicStatisticalFormulas.Covariance(this.chartControl1.Series[0], this.chartControl1.Series[1]).ToString() + "\r\n";

            this.richTextBox1.Text = val;
        }
        #endregion
        #endregion

        #region Events
        private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
        {
            meanOfFirstSeries = (double)numericUpDown1.Value;
            UpdateChart();
        }

        private void numericUpDown2_ValueChanged(object sender, System.EventArgs e)
        {
            meanOfSecondSeries = (double)numericUpDown2.Value;
            UpdateChart();
        }

        private void numericUpDown3_ValueChanged(object sender, System.EventArgs e)
        {
            sqrtVarianceOfFirstSeries = (double)numericUpDown3.Value;
            UpdateChart();
        }

        private void numericUpDown4_ValueChanged(object sender, System.EventArgs e)
        {
            sqrtVarianceOfSecondSeries = (double)numericUpDown4.Value;
            UpdateChart();
        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == 0)
                this.button1.Enabled = false;
            else
                this.button1.Enabled = true;
            UpdateChart();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            richTextBox1.Text = "";
            double confidenceLevel = 0.05;
            string s = "";

            if (this.comboBox1.SelectedIndex == 4)
            {
                //Thus, lets perform the ZTest to test whether the difference is really guessed correctly.
                ZTestResult ztr = BasicStatisticalFormulas.ZTest((double)numericUpDown5.Value,
                    sqrtVarianceOfFirstSeries * sqrtVarianceOfFirstSeries,
                    sqrtVarianceOfSecondSeries * sqrtVarianceOfSecondSeries,
                    0.05,
                    series1,
                    series2);

                s += "ZValue = " + ztr.ZValue.ToString() + "\n";
                s += "ZCriticalValueOneTail = " + ztr.ZCriticalValueOneTail.ToString() + "\n";
                s += "ZCriticalValueTwoTail = " + ztr.ZCriticalValueTwoTail.ToString() + "\n";
                s += "ProbabilityZOneTail = " + ztr.ProbabilityZOneTail.ToString() + "\n";
                s += "ProbabilityZTwoTail = " + ztr.ProbabilityZTwoTail.ToString() + "\n";
                s += "FirstSeriesMean = " + ztr.FirstSeriesMean.ToString() + "\n";
                s += "FirstSeriesVariance = " + ztr.FirstSeriesVariance.ToString() + "\n";
                s += "SecondSeriesMean = " + ztr.SecondSeriesMean.ToString() + "\n";
                s += "SecondSeriesVariance = " + ztr.SecondSeriesVariance.ToString() + "\n";
                s += "\n";

                if (Math.Abs(ztr.ZValue) < ztr.ZCriticalValueTwoTail)
                {
                    s += "Z Test fails to prove that hyphotetized mean is wrong.\n";
                    s += "\n";
                    s += "Because ZValue is closer to zero than ZCriticalValueTwoTail, we can't deduce that hypothetized mean difference is wrong. ";
                    s += " Thus, there is probability that they are close to each other.";
                    s += " This don't automatically proves that our sample means are equal, but rather indicates that we don't have enough data to prove that means are different or close enough. ";
                }
                else
                {
                    s += "Z Test succeeds to prove that hyphotetized mean is wrong with probability " + ((1.0 - 0.05).ToString()) + ".\n";
                    s += "\n";
                    s += "Because ZValue is farther from zero than ZCriticalValueTwoTail, we can deduce that hypothetized mean difference is wrong. ";
                }
            }
            else if (this.comboBox1.SelectedIndex == 3)
            {
                //Thus, lets perform the TTest to test whether the difference is really guessed correctly.
                TTestResult ttr = BasicStatisticalFormulas.TTestUnEqualVariances((double)numericUpDown5.Value,
                    0.05,
                    series1,
                    series2);

                s += "TValue = " + ttr.TValue.ToString() + "\n";
                s += "TCriticalValueOneTail = " + ttr.TCriticalValueOneTail.ToString() + "\n";
                s += "TCriticalValueTwoTail = " + ttr.TCriticalValueTwoTail.ToString() + "\n";
                s += "ProbabilityTOneTail = " + ttr.ProbabilityTOneTail.ToString() + "\n";
                s += "ProbabilityTTwoTail = " + ttr.ProbabilityTTwoTail.ToString() + "\n";
                s += "FirstSeriesMean = " + ttr.FirstSeriesMean.ToString() + "\n";
                s += "FirstSeriesVariance = " + ttr.FirstSeriesVariance.ToString() + "\n";
                s += "SecondSeriesMean = " + ttr.SecondSeriesMean.ToString() + "\n";
                s += "SecondSeriesVariance = " + ttr.SecondSeriesVariance.ToString() + "\n";
                s += "\n";

                if (Math.Abs(ttr.TValue) < ttr.TCriticalValueTwoTail)
                {
                    s += "T Test fails to prove that hyphotetized mean is wrong.\n";
                    s += "\n";
                    s += "Because TValue is closer to zero than TCriticalValueTwoTail, we can't deduce that hypothetized mean difference is wrong. ";
                    s += " Thus, there is probability that they are close to each other.";
                    s += " This don't automatically proves that our sample means are equal, but rather indicates that we don't have enough data to prove that means are different or close enough. ";
                }
                else
                {
                    s += "T Test succeeds to prove that hyphotetized mean is wrong with probability " + ((1.0 - 0.05).ToString()) + ".\n";
                    s += "\n";
                    s += "Because TValue is farther from zero than TCriticalValueTwoTail, we can deduce that hypothetized mean difference is wrong. ";
                }
            }

            else if (this.comboBox1.SelectedIndex == 2)
            {
                //Thus, lets perform the FTest to test whether the difference is really guessed correctly.
                FTestResult ttr = BasicStatisticalFormulas.FTest(
                    confidenceLevel,
                    series1,
                    series2);

                s += "FValue = " + ttr.FValue.ToString() + "\n";
                s += "FCriticalValueOneTail = " + ttr.FCriticalValueOneTail.ToString() + "\n";
                s += "ProbabilityFOneTail = " + ttr.ProbabilityFOneTail.ToString() + "\n";
                s += "FirstSeriesMean = " + ttr.FirstSeriesMean.ToString() + "\n";
                s += "FirstSeriesVariance = " + ttr.FirstSeriesVariance.ToString() + "\n";
                s += "SecondSeriesMean = " + ttr.SecondSeriesMean.ToString() + "\n";
                s += "SecondSeriesVariance = " + ttr.SecondSeriesVariance.ToString() + "\n";
                s += "\n";

                if (ttr.FValue <= 1.0)
                {
                    if (Math.Abs(ttr.FValue - 1.0) < Math.Abs(ttr.FCriticalValueOneTail - 1.0))
                    {
                        s += "F Test fails to prove that first variance is smaller than second.\n";
                        s += "\n";
                        s += "Because FValue is closer to unity than FCriticalValueOneTail, we can't be sure enough that first sample variance is smaller than second. ";
                    }
                    else
                    {
                        s += "F Test succeeds to prove (with probability " + (1.0 - confidenceLevel).ToString() + ") that first sample variance is smaller than second.\n";
                        s += "\n";
                        s += "Because FValue is farther from unity than FCriticalValueOneTail, we can deduce that first sample variance is smaller than second.\n";
                    }
                }
                else
                {
                    s += "FValue is bigger than 1.0. So it is possible that first sample variance is bigger than second. \n";
                    s += "Exchange the sample order and test if the second sample variance is smaller than first sample variance.\n";
                    s += "\n";
                }

            }
            else if (this.comboBox1.SelectedIndex == 1)
            {
                //Thus, lets perform the Anova Test to test whether the difference is really guessed correctly.
                AnovaResult ar = BasicStatisticalFormulas.Anova(
                    confidenceLevel,
                    new ChartSeries[]{ series1,
										 series2,
										 series3});

                s += "FRatio = " + ar.FRatio.ToString() + "\n";
                s += "FCriticalValue = " + ar.FCriticalValue.ToString() + "\n";
                s += "DegreeOfFreedomBetweenGroups = " + ar.DegreeOfFreedomBetweenGroups.ToString() + "\n";
                s += "DegreeOfFreedomWithinGroups = " + ar.DegreeOfFreedomWithinGroups.ToString() + "\n";
                s += "DegreeOfFreedomTotal = " + ar.DegreeOfFreedomTotal.ToString() + "\n";
                s += "MeanSquareVarianceBetweenGroups = " + ar.MeanSquareVarianceBetweenGroups.ToString() + "\n";
                s += "MeanSquareVarianceWithinGroups = " + ar.MeanSquareVarianceWithinGroups.ToString() + "\n";
                s += "SumOfSquaresBetweenGroups = " + ar.SumOfSquaresBetweenGroups.ToString() + "\n";
                s += "SumOfSquaresWithinGroups = " + ar.SumOfSquaresWithinGroups.ToString() + "\n";
                s += "SumOfSquaresTotal = " + ar.SumOfSquaresTotal.ToString() + "\n";
                s += "\n";

                if (ar.FRatio < ar.FCriticalValue)
                {
                    s += "Anova test fails to prove that there is inequality between sample means.\n";
                    s += "\n";
                    s += "Because FRatio is smaller than FCriticalValue, we can't be sure enough that means are unequal. ";
                }
                else
                {
                    s += "Anova succeeds to prove (with probability " + (1.0 - confidenceLevel).ToString() + ") that first there is inequality between sample means.\n";
                    s += "\n";
                    s += "Because FRatio is bigger than FCriticalValue, we can deduce that there is at least one inequality between means.\n";
                }
            }
            richTextBox1.Text = s;
            if (this.comboBox1.SelectedIndex == 0)
                CalculateValues(this.chartControl1.Series[0]);
        }

        private void button2_Click(object sender, System.EventArgs e)
        {

            double tvar = sqrtVarianceOfSecondSeries;
            double tmean = meanOfSecondSeries;

            sqrtVarianceOfSecondSeries = sqrtVarianceOfFirstSeries;
            meanOfSecondSeries = meanOfFirstSeries;

            sqrtVarianceOfFirstSeries = tvar;
            meanOfFirstSeries = tmean;

            InitializeFTestChartData();
            RefreshNumerciUpDowns();
        }

        /// <summary>
        /// Refreshes numeric up down controls for F Test on chart data.
        /// </summary>
        private void RefreshNumerciUpDowns()
        {
            numericUpDown1.Value = (int)meanOfFirstSeries;
            numericUpDown2.Value = (int)meanOfSecondSeries;
            numericUpDown3.Value = (int)sqrtVarianceOfFirstSeries;
            numericUpDown4.Value = (int)sqrtVarianceOfSecondSeries;
        }

        private void numericUpDown6_ValueChanged(object sender, System.EventArgs e)
        {
            meanOfThirdSeries = (double)numericUpDown6.Value;
            UpdateChart();
        }

        private void numericUpDown5_ValueChanged(object sender, System.EventArgs e)
        {
            sqrtVarianceOfThirdSeries = (double)numericUpDown5.Value;
            UpdateChart();
        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Series3D = this.checkBox1.Checked;
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
				return System.IO.File.ReadAllText(licenseKeyFile);
			}
			return string.Empty;
		}
	}
}