#region Copyright Syncfusion Inc. 2001 - 2006
//
//  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
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
using System.Globalization;

namespace Syncfusion.Windows.Forms.Chart.Samples
{
    public class FormMain : MetroForm
    {
        #region Private Members
        private System.ComponentModel.IContainer components = null;
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private Label label9;
        private Label label3;
        private Label label5;
        private ComboBox CB_Origin;
        private Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private ComboBox CB_axis;
        private ComboBox CB_DateInterval;
        private Label label10;
        private NumericUpDown UpDown_Origin;
        private Label label8;

        DateTime start = new DateTime(2007, 8, 1);
        #endregion

        #region Constructor, Main and Dispose
        public FormMain()
        {
            //
            // Required for Windows Form Designer support.
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
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.EnableVisualStyles();
            Application.Run(new FormMain());
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
        /// Required method for Designer support; do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.UpDown_Origin = new System.Windows.Forms.NumericUpDown();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CB_DateInterval = new System.Windows.Forms.ComboBox();
            this.CB_Origin = new System.Windows.Forms.ComboBox();
            this.CB_axis = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Origin)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 30, 10);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(226))))), System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(232)))), ((int)(((byte)(243))))));
            this.chartControl1.DataSourceName = "";
            this.chartControl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(559, 77);
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(-2, 12);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl1.Size = new System.Drawing.Size(700, 571);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "Chart Axis - Custom Origin";
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "Chart Axis - Custom Origin";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ZoomOutIncrement = 1.5D;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.UpDown_Origin);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.CB_DateInterval);
            this.panel1.Controls.Add(this.CB_Origin);
            this.panel1.Controls.Add(this.CB_axis);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(699, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 588);
            this.panel1.TabIndex = 1;
            // 
            // checkBox4
            // 
            this.checkBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox4.Location = new System.Drawing.Point(43, 576);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(137, 24);
            this.checkBox4.TabIndex = 1;
            this.checkBox4.Text = "Opposed Y-Axis";
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // UpDown_Origin
            // 
            this.UpDown_Origin.BackColor = System.Drawing.Color.White;
            this.UpDown_Origin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpDown_Origin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_Origin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.UpDown_Origin.Location = new System.Drawing.Point(44, 343);
            this.UpDown_Origin.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.UpDown_Origin.Name = "UpDown_Origin";
            this.UpDown_Origin.ReadOnly = true;
            this.UpDown_Origin.Size = new System.Drawing.Size(165, 27);
            this.UpDown_Origin.TabIndex = 23;
            this.UpDown_Origin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDown_Origin.ValueChanged += new System.EventHandler(this.UpDown_Origin_ValueChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox5.Location = new System.Drawing.Point(43, 544);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(163, 24);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "Opposed X-Axis";
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label5.Location = new System.Drawing.Point(38, 506);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Opposed Axes";
            // 
            // checkBox2
            // 
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox2.Location = new System.Drawing.Point(43, 427);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(111, 31);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Invert X Axis";
            this.checkBox2.CheckedChanged += new System.EventHandler(this.Invert_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(39, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Invert Axes";
            // 
            // checkBox3
            // 
            this.checkBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox3.Location = new System.Drawing.Point(43, 462);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox3.Size = new System.Drawing.Size(137, 30);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Invert Y Axis";
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.Invert_CheckedChanged);
            // 
            // label8
            // 
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label8.Location = new System.Drawing.Point(43, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 27);
            this.label8.TabIndex = 97;
            this.label8.Text = "Value";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label9.Location = new System.Drawing.Point(39, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Custom Origin";
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox1.Location = new System.Drawing.Point(43, 66);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(164, 22);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Show Custom Axis";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkbox_changed);
            // 
            // CB_DateInterval
            // 
            this.CB_DateInterval.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_DateInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_DateInterval.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_DateInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.CB_DateInterval.Items.AddRange(new object[] {
            "Auto",
            "Days",
            "Hours",
            "Milliseconds",
            "Minutes",
            "Months",
            "Seconds",
            "Weeks",
            "Years"});
            this.CB_DateInterval.Location = new System.Drawing.Point(43, 271);
            this.CB_DateInterval.Name = "CB_DateInterval";
            this.CB_DateInterval.Size = new System.Drawing.Size(165, 28);
            this.CB_DateInterval.TabIndex = 21;
            this.CB_DateInterval.SelectedIndexChanged += new System.EventHandler(this.CB_DateInterval_SelectedIndexChanged);
            // 
            // CB_Origin
            // 
            this.CB_Origin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Origin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Origin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Origin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.CB_Origin.Location = new System.Drawing.Point(44, 270);
            this.CB_Origin.Name = "CB_Origin";
            this.CB_Origin.Size = new System.Drawing.Size(165, 29);
            this.CB_Origin.TabIndex = 11;
            this.CB_Origin.SelectedIndexChanged += new System.EventHandler(this.CB_Origin_SelectedIndexChanged);
            // 
            // CB_axis
            // 
            this.CB_axis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_axis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_axis.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_axis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.CB_axis.Items.AddRange(new object[] {
            "Date Time Offset",
            "Offset",
            "Date Time Interval",
            "Range Padding Type"});
            this.CB_axis.Location = new System.Drawing.Point(44, 196);
            this.CB_axis.Name = "CB_axis";
            this.CB_axis.Size = new System.Drawing.Size(165, 28);
            this.CB_axis.TabIndex = 17;
            this.CB_axis.SelectedIndexChanged += new System.EventHandler(this.CB_axis_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(43, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Average Load";
            // 
            // label7
            // 
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label7.Location = new System.Drawing.Point(43, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Range Padding Type";
            // 
            // label10
            // 
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label10.Location = new System.Drawing.Point(42, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 28);
            this.label10.TabIndex = 22;
            this.label10.Text = "Origin Customiztion";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox1.Location = new System.Drawing.Point(44, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.combobox_changed);
            // 
            // FormMain
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 581);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(656, 469);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Axis Origin";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Origin)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Form Load
        private void FormMain_Load(object sender, System.EventArgs e)
        {
            CB_axis.SelectedIndex = 0;
            InitializeChartData();
            FillControlPanel();
            this.chartControl1.PrimaryXAxis.Inversed = true;
            this.chartControl1.PrimaryYAxis.Inversed = true;
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }
        #endregion

        #region InitializeChartData()
        /// <summary>
        /// Initializes the ChartControl's data and sets the Chart type.
        /// </summary>
        protected void InitializeChartData()
        {
            this.chartControl1.Indexed = true;
           // this.chartControl1.LegendPosition = ChartDock.Bottom;
            ChartSeries series1 = new ChartSeries(" Server 1", ChartSeriesType.Column);
            series1.Text = series1.Name;

            series1.Points.Add(start.AddDays(7), 68);
            series1.Points.Add(start.AddDays(8), 65);
            series1.Points.Add(start.AddDays(9), 72);
            series1.Points.Add(start.AddDays(10), 71);
            series1.Points.Add(start.AddDays(11), 73);
            series1.Points.Add(start.AddDays(12), 70);
            series1.Points.Add(start.AddDays(13), 68);
            series1.Points.Add(start.AddDays(14), 72);

            series1.Style.Border.DashStyle = DashStyle.Solid;
            series1.Style.Font.Bold = true;
            this.chartControl1.Series.Add(series1);


            ChartSeries series2 = new ChartSeries(" Server 2", ChartSeriesType.Column);
            series2.Text = series2.Name;

            series2.Points.Add(start.AddDays(7), 65);
            series2.Points.Add(start.AddDays(8), 68);
            series2.Points.Add(start.AddDays(9), 71);
            series2.Points.Add(start.AddDays(10), 72);
            series2.Points.Add(start.AddDays(11), 72);
            series2.Points.Add(start.AddDays(12), 68);
            series2.Points.Add(start.AddDays(13), 70);
            series2.Points.Add(start.AddDays(14), 73);

            series2.Style.Border.DashStyle = DashStyle.Solid;
            series2.Style.Font.Bold = true;
            this.chartControl1.Series.Add(series2);

            this.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.Rotate;
            this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime;
            this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(start.AddDays(-1), start.AddDays(13), 3, ChartDateTimeIntervalType.Days);
            this.chartControl1.PrimaryXAxis.DateTimeFormat = "MM/dd,ddd";

            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));

        }
        #endregion

        #region Custom Origin

        private void FillControlPanel()
        {
            for (int i = 0; i < this.chartControl1.Series[0].Points.Count; i++)
            {
                this.comboBox1.Items.Add(this.chartControl1.Series[0].Points[i].YValues[0]);
            }


            this.CB_DateInterval.SelectedIndex = 0;
            this.comboBox1.SelectedIndex = 0;

            CB_Origin.Items.Add("Calculate");
            CB_Origin.Items.Add("None");

            CB_Origin.SelectedIndex = 0;
        }

        private void combobox_changed(object sender, System.EventArgs e)
        {
            SetOrigin();
        }

        private void checkbox_changed(object sender, System.EventArgs e)
        {
            SetOrigin();

            this.comboBox1.Enabled = this.checkBox1.Checked;

        }

        protected void SetOrigin()
        {
            if (this.checkBox1.Checked)
            {
                this.chartControl1.PrimaryYAxis.CustomOrigin = true;
                this.chartControl1.PrimaryYAxis.Origin = (double)this.comboBox1.SelectedItem;
            }
            else
            {
                this.chartControl1.PrimaryYAxis.CustomOrigin = false;
                this.chartControl1.PrimaryYAxis.Origin = 0;
            }
            this.chartControl1.Redraw(true);
        }
        #endregion

        #region Invert Axes
        /// <summary>
        /// Inver chart primary X and Y axes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Invert_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.checkBox2.Checked && this.checkBox3.Checked)
            {
                this.chartControl1.PrimaryXAxis.Inversed = true;
                this.chartControl1.PrimaryYAxis.Inversed = true;
            }
            else if (this.checkBox2.Checked)
            {
                this.chartControl1.PrimaryXAxis.Inversed = true;
                this.chartControl1.PrimaryYAxis.Inversed = false;
            }
            else if (this.checkBox3.Checked)
            {
                this.chartControl1.PrimaryXAxis.Inversed = false;
                this.chartControl1.PrimaryYAxis.Inversed = true;
            }
            else
            {
                this.chartControl1.PrimaryXAxis.Inversed = false;
                this.chartControl1.PrimaryYAxis.Inversed = false;
            }
        }
        #endregion

        #region Opposed axes
        /// <summary>
        /// Set opposed axes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void checkBox5_CheckedChanged(object sender, System.EventArgs e)
        {
            SetOpposedPosition();
        }

        private void checkBox4_CheckedChanged(object sender, System.EventArgs e)
        {
            SetOpposedPosition();
        }
        private void SetOpposedPosition()
        {
            this.chartControl1.PrimaryXAxis.OpposedPosition = checkBox5.Checked;
            this.chartControl1.PrimaryYAxis.OpposedPosition = checkBox4.Checked;
        }


        #endregion

        #region OriginCustomization
        private void CB_Origin_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Visible = true;
            this.Enabled = true;
            this.chartControl1.PrimaryXAxis.CustomOrigin = true;

            if (CB_Origin.SelectedItem.ToString() == "Calculate")
            {
                this.chartControl1.PrimaryXAxis.RangePaddingType = ChartAxisRangePaddingType.Calculate;
            }
            else if (CB_Origin.SelectedItem.ToString() == "None")
            {
                this.chartControl1.PrimaryXAxis.RangePaddingType = ChartAxisRangePaddingType.None;
            }
        }


        private void CB_axis_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetClear();

            this.CB_DateInterval.Visible = true;
            if (CB_axis.SelectedItem.ToString() == "Date Time Offset")
            {
                this.label8.Enabled = true;
                this.UpDown_Origin.Enabled = true;
            }
            if (CB_axis.SelectedItem.ToString() == "Offset")
            {
                this.label8.Enabled = true;
                this.UpDown_Origin.Enabled = true;
            }
            if (CB_axis.SelectedItem.ToString() == "Date Time Interval")
            {
                this.label7.Enabled = true;
                this.label7.Text = "Date Time Interval";
                this.label8.Enabled = true;
                this.UpDown_Origin.Enabled = true;
                this.CB_DateInterval.Enabled = true;
            }
            if (CB_axis.SelectedItem.ToString() == "Range Padding Type")
            {
                this.CB_DateInterval.Visible = false;
                this.CB_Origin.Enabled = true;
                this.label7.Enabled = true;
                this.label7.Text = "Range Padding Type";
            }
        }

        private void SetClear()
        {
            this.label8.Enabled = false;
            this.label7.Enabled = false;
            this.UpDown_Origin.Enabled = false;
            this.UpDown_Origin.Text = "0";
            this.CB_Origin.Enabled = false;
            this.CB_DateInterval.Enabled = false;
            this.chartControl1.PrimaryXAxis.Offset = 0;
        }

        private void CB_DateInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;

            this.chartControl1.PrimaryXAxis.DateTimeInterval.OffsetType = (ChartDateTimeIntervalType)Enum.Parse(typeof(ChartDateTimeIntervalType), CB_DateInterval.SelectedItem.ToString(), true);
            this.chartControl1.PrimaryXAxis.DateTimeInterval.Offset = Double.Parse(UpDown_Origin.Value.ToString());
            this.chartControl1.Redraw(true);
        }

        private void UpDown_Origin_ValueChanged(object sender, EventArgs e)
        {
            if (CB_axis.SelectedItem.ToString() == "Date Time Offset")
            {
                this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Auto;
                this.chartControl1.PrimaryXAxis.DateTimeOffset = new TimeSpan(Int32.Parse(UpDown_Origin.Value.ToString()), 0, 0, 0, 0);
            }
            else if (CB_axis.SelectedItem.ToString() == "Offset")
            {
                this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
                this.chartControl1.PrimaryXAxis.CustomOrigin = true;
                this.chartControl1.PrimaryXAxis.Offset = Int32.Parse(UpDown_Origin.Value.ToString());

            }
            else if (CB_axis.SelectedItem.ToString() == "Date Time Interval")
            {
                this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
                this.chartControl1.PrimaryXAxis.CustomOrigin = true;
                this.chartControl1.PrimaryXAxis.Offset = Int32.Parse(UpDown_Origin.Value.ToString());
            }
            else
            {
                this.chartControl1.PrimaryXAxis.DateTimeInterval.Offset = Double.Parse(UpDown_Origin.Text.ToString());
            }
            this.chartControl1.Redraw(true);
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