#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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

using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;

namespace ChartToolTips
{
    public class Form1 : Syncfusion.Windows.Forms.MetroForm
    {
        #region Private Members
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChartAreaTooltip;
        private System.Windows.Forms.ComboBox CBox_TooltipFormat;
        private System.Windows.Forms.CheckBox ShowTooltip;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel6;
        private IContainer components;
        ChartSeries series1, series2;
        private CheckBox checkBoxChartToolTip;
        private CheckBox SeriesPointToolTip;
        private Label label22;
        private ChartControl chartControl1;
        Color[] color1 = new Color[] { Color.FromArgb(150, 172, 90), Color.FromArgb(197, 229, 92), Color.FromArgb(150, 172, 90) };
        private Panel panel3;
        private Syncfusion.Windows.Forms.ColorPickerButton FontColorPicker;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPicker_FancyToolTipBackColor;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Label label4;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private CheckBox Ser1CheckBox;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private CheckBox Ser2CheckBox;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel7;
        private ComboBox comboBox1;
        private Syncfusion.Windows.Forms.ColorPickerButton BorderColorPicker;
        Color[] color2 = new Color[] { Color.FromArgb(223, 111, 39), Color.FromArgb(251, 169, 113), Color.FromArgb(223, 111, 39) };
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
            this.CBox_TooltipFormat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.autoLabel6 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.ChartAreaTooltip = new System.Windows.Forms.CheckBox();
            this.ShowTooltip = new System.Windows.Forms.CheckBox();
            this.checkBoxChartToolTip = new System.Windows.Forms.CheckBox();
            this.SeriesPointToolTip = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.BorderColorPicker = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.FontColorPicker = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.autoLabel7 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.colorPicker_FancyToolTipBackColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.Ser1CheckBox = new System.Windows.Forms.CheckBox();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.Ser2CheckBox = new System.Windows.Forms.CheckBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // CBox_TooltipFormat
            // 
            this.CBox_TooltipFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBox_TooltipFormat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBox_TooltipFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.CBox_TooltipFormat.Items.AddRange(new object[] {
            " Series Name",
            " SeriesStyle.ToolTip",
            " SeriesStyle[i].ToolTip",
            " Series.Points[ index ].X",
            " Series.Points[ index ].YValues[i]"});
            this.CBox_TooltipFormat.Location = new System.Drawing.Point(44, 231);
            this.CBox_TooltipFormat.Name = "CBox_TooltipFormat";
            this.CBox_TooltipFormat.Size = new System.Drawing.Size(172, 28);
            this.CBox_TooltipFormat.TabIndex = 3;
            this.CBox_TooltipFormat.SelectedIndexChanged += new System.EventHandler(this.TooltipFormat_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(41, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "ToolTip Format";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // autoLabel6
            // 
            this.autoLabel6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.autoLabel6.Location = new System.Drawing.Point(41, 675);
            this.autoLabel6.Name = "autoLabel6";
            this.autoLabel6.Size = new System.Drawing.Size(41, 20);
            this.autoLabel6.TabIndex = 8;
            this.autoLabel6.Text = "Style";
            // 
            // ChartAreaTooltip
            // 
            this.ChartAreaTooltip.AutoSize = true;
            this.ChartAreaTooltip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChartAreaTooltip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ChartAreaTooltip.Location = new System.Drawing.Point(45, 131);
            this.ChartAreaTooltip.Name = "ChartAreaTooltip";
            this.ChartAreaTooltip.Size = new System.Drawing.Size(153, 24);
            this.ChartAreaTooltip.TabIndex = 2;
            this.ChartAreaTooltip.Text = "Chart Area ToolTip";
            this.ChartAreaTooltip.CheckedChanged += new System.EventHandler(this.ChartAreaTooltip_CheckedChanged);
            // 
            // ShowTooltip
            // 
            this.ShowTooltip.AutoSize = true;
            this.ShowTooltip.BackColor = System.Drawing.Color.Transparent;
            this.ShowTooltip.Checked = true;
            this.ShowTooltip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowTooltip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowTooltip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ShowTooltip.Location = new System.Drawing.Point(45, 68);
            this.ShowTooltip.Name = "ShowTooltip";
            this.ShowTooltip.Size = new System.Drawing.Size(119, 24);
            this.ShowTooltip.TabIndex = 1;
            this.ShowTooltip.Text = "Show ToolTip";
            this.ShowTooltip.UseVisualStyleBackColor = false;
            this.ShowTooltip.CheckedChanged += new System.EventHandler(this.ShowTooltip_CheckedChanged);
            // 
            // checkBoxChartToolTip
            // 
            this.checkBoxChartToolTip.AutoSize = true;
            this.checkBoxChartToolTip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxChartToolTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBoxChartToolTip.Location = new System.Drawing.Point(45, 100);
            this.checkBoxChartToolTip.Name = "checkBoxChartToolTip";
            this.checkBoxChartToolTip.Size = new System.Drawing.Size(118, 24);
            this.checkBoxChartToolTip.TabIndex = 3;
            this.checkBoxChartToolTip.Text = "Chart ToolTip";
            this.checkBoxChartToolTip.CheckedChanged += new System.EventHandler(this.checkBoxChartToolTip_CheckedChanged);
            // 
            // SeriesPointToolTip
            // 
            this.SeriesPointToolTip.AutoSize = true;
            this.SeriesPointToolTip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeriesPointToolTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.SeriesPointToolTip.Location = new System.Drawing.Point(45, 163);
            this.SeriesPointToolTip.Name = "SeriesPointToolTip";
            this.SeriesPointToolTip.Size = new System.Drawing.Size(160, 24);
            this.SeriesPointToolTip.TabIndex = 4;
            this.SeriesPointToolTip.Text = "Series Point ToolTip";
            this.SeriesPointToolTip.CheckedChanged += new System.EventHandler(this.SeriesPointToolTip_CheckedChanged);
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label22.Location = new System.Drawing.Point(39, 30);
            this.label22.Name = "label22";
            this.label22.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label22.Size = new System.Drawing.Size(132, 27);
            this.label22.TabIndex = 108;
            this.label22.Text = "Tool Tips";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chartControl1
            // 
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.None, System.Drawing.Color.White, System.Drawing.Color.White);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10);
            this.chartControl1.DataSourceName = "";
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Location = new System.Drawing.Point(581, 75);
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.ForceZero = true;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Range = new Syncfusion.Windows.Forms.Chart.MinMaxInfo(0D, 100D, 20D);
            this.chartControl1.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set;
            this.chartControl1.Size = new System.Drawing.Size(700, 580);
            this.chartControl1.TabIndex = 112;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "chartControl1";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.BorderColorPicker);
            this.panel3.Controls.Add(this.FontColorPicker);
            this.panel3.Controls.Add(this.autoLabel7);
            this.panel3.Controls.Add(this.colorPicker_FancyToolTipBackColor);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.autoLabel3);
            this.panel3.Controls.Add(this.autoLabel6);
            this.panel3.Controls.Add(this.autoLabel2);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.CBox_TooltipFormat);
            this.panel3.Controls.Add(this.autoLabel1);
            this.panel3.Controls.Add(this.SeriesPointToolTip);
            this.panel3.Controls.Add(this.Ser1CheckBox);
            this.panel3.Controls.Add(this.autoLabel4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.checkBoxChartToolTip);
            this.panel3.Controls.Add(this.Ser2CheckBox);
            this.panel3.Controls.Add(this.ChartAreaTooltip);
            this.panel3.Controls.Add(this.ShowTooltip);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(694, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 584);
            this.panel3.TabIndex = 119;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown1.Location = new System.Drawing.Point(45, 631);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(172, 27);
            this.numericUpDown1.TabIndex = 118;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(45, 776);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(172, 29);
            this.comboBox2.Sorted = true;
            this.comboBox2.TabIndex = 17;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // BorderColorPicker
            // 
            this.BorderColorPicker.BackColor = System.Drawing.Color.Black;
            this.BorderColorPicker.BeforeTouchSize = new System.Drawing.Size(100, 30);
            this.BorderColorPicker.ColorUISize = new System.Drawing.Size(208, 230);
            this.BorderColorPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorderColorPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorderColorPicker.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorderColorPicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.BorderColorPicker.IsBackStageButton = false;
            this.BorderColorPicker.Location = new System.Drawing.Point(45, 559);
            this.BorderColorPicker.Name = "BorderColorPicker";
            this.BorderColorPicker.SelectedAsBackcolor = true;
            this.BorderColorPicker.SelectedColor = System.Drawing.Color.Black;
            this.BorderColorPicker.Size = new System.Drawing.Size(100, 30);
            this.BorderColorPicker.TabIndex = 14;
            this.BorderColorPicker.UseVisualStyleBackColor = false;
            this.BorderColorPicker.ColorSelected += new System.EventHandler(this.colorPickerButton1_ColorSelected);
            // 
            // FontColorPicker
            // 
            this.FontColorPicker.BackColor = System.Drawing.Color.Black;
            this.FontColorPicker.BeforeTouchSize = new System.Drawing.Size(100, 30);
            this.FontColorPicker.ColorUISize = new System.Drawing.Size(208, 230);
            this.FontColorPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FontColorPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FontColorPicker.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontColorPicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.FontColorPicker.IsBackStageButton = false;
            this.FontColorPicker.Location = new System.Drawing.Point(45, 491);
            this.FontColorPicker.Name = "FontColorPicker";
            this.FontColorPicker.SelectedAsBackcolor = true;
            this.FontColorPicker.SelectedColor = System.Drawing.Color.Black;
            this.FontColorPicker.Size = new System.Drawing.Size(100, 30);
            this.FontColorPicker.TabIndex = 14;
            this.FontColorPicker.UseVisualStyleBackColor = false;
            this.FontColorPicker.ColorSelected += new System.EventHandler(this.FontColorPicker_ColorSelected);
            // 
            // autoLabel7
            // 
            this.autoLabel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.autoLabel7.Location = new System.Drawing.Point(41, 743);
            this.autoLabel7.Name = "autoLabel7";
            this.autoLabel7.Size = new System.Drawing.Size(63, 21);
            this.autoLabel7.TabIndex = 9;
            this.autoLabel7.Text = "Symbol";
            // 
            // colorPicker_FancyToolTipBackColor
            // 
            this.colorPicker_FancyToolTipBackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colorPicker_FancyToolTipBackColor.BeforeTouchSize = new System.Drawing.Size(100, 30);
            this.colorPicker_FancyToolTipBackColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPicker_FancyToolTipBackColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPicker_FancyToolTipBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPicker_FancyToolTipBackColor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPicker_FancyToolTipBackColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.colorPicker_FancyToolTipBackColor.IsBackStageButton = false;
            this.colorPicker_FancyToolTipBackColor.Location = new System.Drawing.Point(44, 420);
            this.colorPicker_FancyToolTipBackColor.Name = "colorPicker_FancyToolTipBackColor";
            this.colorPicker_FancyToolTipBackColor.SelectedAsBackcolor = true;
            this.colorPicker_FancyToolTipBackColor.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colorPicker_FancyToolTipBackColor.Size = new System.Drawing.Size(100, 30);
            this.colorPicker_FancyToolTipBackColor.TabIndex = 14;
            this.colorPicker_FancyToolTipBackColor.UseVisualStyleBackColor = false;
            this.colorPicker_FancyToolTipBackColor.ColorSelected += new System.EventHandler(this.colorPicker_FancyToolTipBackColor_ColorSelected);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.DropDownWidth = 105;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ellipse",
            "Rectangle",
            "SmoothRectangle"});
            this.comboBox1.Location = new System.Drawing.Point(45, 701);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 28);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // autoLabel3
            // 
            this.autoLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.autoLabel3.Location = new System.Drawing.Point(41, 603);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(98, 20);
            this.autoLabel3.TabIndex = 2;
            this.autoLabel3.Text = "Border Width";
            // 
            // autoLabel2
            // 
            this.autoLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.autoLabel2.Location = new System.Drawing.Point(41, 532);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(94, 20);
            this.autoLabel2.TabIndex = 1;
            this.autoLabel2.Text = "Border Color";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(41, 279);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(154, 27);
            this.label4.TabIndex = 109;
            this.label4.Text = "Fancy Tool Tips";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.autoLabel1.Location = new System.Drawing.Point(41, 392);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(80, 20);
            this.autoLabel1.TabIndex = 116;
            this.autoLabel1.Text = "Back Color";
            // 
            // Ser1CheckBox
            // 
            this.Ser1CheckBox.AutoSize = true;
            this.Ser1CheckBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ser1CheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Ser1CheckBox.Location = new System.Drawing.Point(45, 319);
            this.Ser1CheckBox.Name = "Ser1CheckBox";
            this.Ser1CheckBox.Size = new System.Drawing.Size(75, 24);
            this.Ser1CheckBox.TabIndex = 19;
            this.Ser1CheckBox.Text = "Series1";
            this.Ser1CheckBox.UseVisualStyleBackColor = true;
            this.Ser1CheckBox.CheckedChanged += new System.EventHandler(this.Ser1CheckBox_CheckedChanged);
            // 
            // autoLabel4
            // 
            this.autoLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.autoLabel4.Location = new System.Drawing.Point(41, 463);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(78, 20);
            this.autoLabel4.TabIndex = 5;
            this.autoLabel4.Text = "Fore Color";
            // 
            // Ser2CheckBox
            // 
            this.Ser2CheckBox.AutoSize = true;
            this.Ser2CheckBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ser2CheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Ser2CheckBox.Location = new System.Drawing.Point(45, 353);
            this.Ser2CheckBox.Name = "Ser2CheckBox";
            this.Ser2CheckBox.Size = new System.Drawing.Size(75, 24);
            this.Ser2CheckBox.TabIndex = 20;
            this.Ser2CheckBox.Text = "Series2";
            this.Ser2CheckBox.UseVisualStyleBackColor = true;
            this.Ser2CheckBox.CheckedChanged += new System.EventHandler(this.Ser2CheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 584);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(582, 620);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tooltip";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            InitializeChartData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            this.chartControl1.Dock = DockStyle.Fill;

        }
        #endregion

        #region Helper Methods
        
        #region InitializeChartData
        /// <summary>
        /// Create a series and add points to the series.
        /// </summary>
        protected void InitializeChartData()
        {
            series1 = new ChartSeries();
            series1.Name = "Server 1";
            series1.Type = ChartSeriesType.Column;
            series1.Text = series1.Name;

            series1.Points.Add(0, 20);
            series1.Points.Add(1, 40);
            series1.Points.Add(2, 80);
            series1.Points.Add(3, 70);
            series1.Points.Add(4, 50);
            series1.PrepareStyle += new ChartPrepareStyleInfoHandler(ChartControlSeries_PrepareStyle);
            this.chartControl1.Series.Add(series1);

            series2 = new ChartSeries();
            series2.Name = "Server 2";
            series2.Type = ChartSeriesType.Column;
            series2.Text = series2.Name;

            series2.Points.Add(0, 50);
            series2.Points.Add(1, 60);
            series2.Points.Add(2, 60);
            series2.Points.Add(3, 40);
            series2.Points.Add(4, 90);
            series2.PrepareStyle += new ChartPrepareStyleInfoHandler(ChartControlSeries_PrepareStyle);
            this.chartControl1.Series.Add(series2);
          
            series1.FancyToolTip.Style = MarkerStyle.Ellipse;
            series2.FancyToolTip.Style = MarkerStyle.Ellipse;
            series1.FancyToolTip.Symbol = ChartSymbolShape.Circle;
            series2.FancyToolTip.Symbol = ChartSymbolShape.Circle;
            series1.FancyToolTip.BackColor = Color.Gold;
            series2.FancyToolTip.BackColor = Color.Gold;

            this.CBox_TooltipFormat.SelectedIndex = 2;
            this.chartControl1.ElementsSpacing = 15;
            this.chartControl1.ShowToolTips = this.ShowTooltip.Checked;


            this.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.MultipleRows;
            this.chartControl1.PrimaryXAxis.Format = "Day 0";

            foreach (string symbol in Enum.GetNames(typeof(Syncfusion.Windows.Forms.Chart.ChartSymbolShape)))
            {
                if (symbol.Equals("Image"))
                {
                    break;
                }
                this.comboBox2.Items.Add(symbol);
            }

            this.chartControl1.Spacing = 30f;
            this.checkBoxChartToolTip.Checked = true;
            this.ChartAreaTooltip.Checked = true;
            this.SeriesPointToolTip.Checked = true;

            this.comboBox1.SelectedIndex = 0;
            this.comboBox2.SelectedIndex = 0;
        }

        #endregion

        #region SetFancyToolTip
        protected void SetFancyToolTip(ChartSeries series)
        {
            int width = Convert.ToInt32(this.numericUpDown1.Value);

            ChartSeries newSeries = series;
            series.FancyToolTip.BackColor = this.colorPicker_FancyToolTipBackColor.SelectedColor;
            series.FancyToolTip.ForeColor = this.FontColorPicker.SelectedColor;
            series.FancyToolTip.Border.ForeColor = this.BorderColorPicker.SelectedColor;
            series.FancyToolTip.Style = (Syncfusion.Windows.Forms.Chart.MarkerStyle)Enum.Parse(typeof(Syncfusion.Windows.Forms.Chart.MarkerStyle), this.comboBox1.SelectedItem.ToString(), true);
            series.FancyToolTip.Symbol = (Syncfusion.Windows.Forms.Chart.ChartSymbolShape)Enum.Parse(typeof(Syncfusion.Windows.Forms.Chart.ChartSymbolShape), this.comboBox2.SelectedItem.ToString(), true);
            series.FancyToolTip.Border.Width = width;

            this.chartControl1.Redraw(true);
        }
        #endregion
        #endregion

        #region Events
        #region Preparestyle Event
        /// <summary>
        /// Set tooltip format using preparestyle event in chart control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void ChartControlSeries_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
        {
            // Style formatting using a callback. You can apply the same settings directly on the series style on the
            // point styles.
            ChartSeries series = sender as ChartSeries;
            if (series != null)
            {
                args.Style.Text = string.Format("Value is {0}", series.Points[args.Index].YValues[0]);
                args.Style.ToolTip = "You are hovering over Day " + series.Points[args.Index].X.ToString();
                args.Handled = true;
            }
        }
        #endregion

        
        /// <summary>
        /// Tooltip customization.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ShowTooltip_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.ShowTooltip.Checked)
            {
                this.chartControl1.ShowToolTips = true;
                this.checkBoxChartToolTip.Enabled = true;
                this.ChartAreaTooltip.Enabled = true;
                this.SeriesPointToolTip.Enabled = true;

            }
            else
            {
                this.chartControl1.ShowToolTips = false;
                this.checkBoxChartToolTip.Enabled = false;
                this.ChartAreaTooltip.Enabled = false;
                this.SeriesPointToolTip.Enabled = false;
            }
            this.chartControl1.Redraw(true);
        }

        #region Chart ToolTip
        private void checkBoxChartToolTip_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxChartToolTip.Checked)
                this.chartControl1.ChartToolTip = "Chart ToolTip";
            else
                this.chartControl1.ChartToolTip = "";
            this.chartControl1.Redraw(true);  
        }
        #endregion

        #region ChartArea ToolTip
        private void ChartAreaTooltip_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.ChartAreaTooltip.Checked)
                this.chartControl1.ChartAreaToolTip = "Chart Area ToolTip";
            else
                this.chartControl1.ChartAreaToolTip = "";
            this.chartControl1.Redraw(true);
        }
         #endregion

        #region Series Point ToolTip
        private void SeriesPointToolTip_CheckedChanged(object sender, EventArgs e)
        {
            if (this.SeriesPointToolTip.Checked)
            {
                this.CBox_TooltipFormat.Visible = true;
                this.label1.Visible = true;
            }
            else
            {
                this.CBox_TooltipFormat.Visible = false;
                this.label1.Visible = false;
            }
        }

        private void TooltipFormat_Changed(object sender, System.EventArgs e)
        {
            foreach (ChartSeries s in this.chartControl1.Series)
            {
                int len = s.Points.Count;
                s.Style.ToolTip = "Server Load";
                for (int i = 0; i < len; i++)
                {
                    int x = this.CBox_TooltipFormat.SelectedIndex;
                    s.PointsToolTipFormat = "{" + x.ToString() + "}";

                    //
                    //ToolTips Format Style
                    //
                    //			"{0}" - series Name
                    //
                    //	        "{1}" - SeriesStyle.ToolTip;
                    //
                    //	        "{2}" - SeriesStyle[i].ToolTip; - this is what we want.
                    //
                    //	        "{3}" - series.Points[ index ].X;
                    //
                    //		    "{4+i}" - series.Points[ index ].YValues[i];

                }
            }
        }
         #endregion
       

        private void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            if (Ser1CheckBox.Checked)
                SetFancyToolTip(series1);
            if (Ser2CheckBox.Checked)
                SetFancyToolTip(series2);
            if (this.BorderColorPicker.SelectedColor == Color.Transparent)
            {
                
            }
            else
            {
              
            }

            this.Refresh();
        }

        private void FontColorPicker_ColorSelected(object sender, EventArgs e)
        {
            if (Ser1CheckBox.Checked)
                SetFancyToolTip(series1);
            if (Ser2CheckBox.Checked)
                SetFancyToolTip(series2);
            if (this.FontColorPicker.SelectedColor == Color.Transparent)
            {

            }
            else
            {
            }

            this.Refresh();
        }

        

        private void colorPicker_FancyToolTipBackColor_ColorSelected(object sender, EventArgs e)
        {
            if (Ser1CheckBox.Checked)
                SetFancyToolTip(series1);
            if (Ser2CheckBox.Checked)
                SetFancyToolTip(series2);
            if (this.colorPicker_FancyToolTipBackColor.SelectedColor == Color.Transparent)
            {
             
            }
            else
            {
               
            }

            this.Refresh();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Ser1CheckBox.Checked)
                SetFancyToolTip(series1);
            if (Ser2CheckBox.Checked)
                SetFancyToolTip(series2);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Ser1CheckBox.Checked)
                SetFancyToolTip(series1);
            if (Ser2CheckBox.Checked)
                SetFancyToolTip(series2);
        }

        private void chartControl1_ChartRegionMouseHover(object sender, ChartRegionMouseEventArgs e)
        {
            if (e.Region.SeriesIndex == 1 && this.Ser2CheckBox.Checked == false)
            {
                series1.FancyToolTip.Visible = false;
            }
            if (e.Region.SeriesIndex == 0 && this.Ser1CheckBox.Checked == false)
            {
                series2.FancyToolTip.Visible = false;
            }
            if (e.Region.SeriesIndex == 0 && this.Ser1CheckBox.Checked)
            {
                series1.FancyToolTip.Visible = true;
                series2.FancyToolTip.Visible = false;
            }
            if (e.Region.SeriesIndex == 1 && this.Ser2CheckBox.Checked)
            {
                series1.FancyToolTip.Visible = false;
                series2.FancyToolTip.Visible = true;
            }
            if (e.Region.SeriesIndex == -1)
            {
                series1.FancyToolTip.Visible = false;
                series2.FancyToolTip.Visible = false;
            }
            this.chartControl1.Redraw(true);
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {           
            if (Ser1CheckBox.Checked)
                SetFancyToolTip(series1);
            if (Ser2CheckBox.Checked)
                SetFancyToolTip(series2);
        }

        private void Ser1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.ShowToolTips = false;
            this.ShowTooltip.Checked = false;
            if (Ser1CheckBox.Checked == true)
            {
                series1.FancyToolTip.Visible = true;
                SetFancyToolTip(series1);
             }
            else
            {
                series1.FancyToolTip.Visible = false;
                
            }
        }
       
        private void Ser2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
          
            this.chartControl1.ShowToolTips = false;
            this.ShowTooltip.Checked = false;
            if (Ser2CheckBox.Checked == true)
            {
                series2.FancyToolTip.Visible = true;
                SetFancyToolTip(series2);
               
            }
            else
            {
                series2.FancyToolTip.Visible = false;
                
            }
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