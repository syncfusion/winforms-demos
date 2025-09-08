#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace TickMarksDemo_2005
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
            this.chartTitle1 = new Syncfusion.Windows.Forms.Chart.ChartTitle();
            this.imageListAdv1 = new Syncfusion.Windows.Forms.Tools.ImageListAdv(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cbXAxisDrawLabelGrid = new System.Windows.Forms.CheckBox();
            this.nUDYAxisSmallTickWidth = new System.Windows.Forms.NumericUpDown();
            this.nUDXAxisSmallTickWidth = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nUDYAxisSmallTickHeight = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.nUDYAxisTickWidth = new System.Windows.Forms.NumericUpDown();
            this.nUDXAxisTickGridPadding = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.nUDXAxisTickWidth = new System.Windows.Forms.NumericUpDown();
            this.cpXAxisTickColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.nUDXAxisSmallTickHeight = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nUDYAxisTickHeight = new System.Windows.Forms.NumericUpDown();
            this.nUDYAxisTicksPerInterval = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.nUDXAxisTicksPerInterval = new System.Windows.Forms.NumericUpDown();
            this.cbYAxisDrawLabelGrid = new System.Windows.Forms.CheckBox();
            this.cpYAxisTickColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.nUDXAxisTickHeight = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nUDYAxisTickGridPadding = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.chartControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDYAxisSmallTickWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDXAxisSmallTickWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDYAxisSmallTickHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDYAxisTickWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDXAxisTickGridPadding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDXAxisTickWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDXAxisSmallTickHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDYAxisTickHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDYAxisTicksPerInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDXAxisTicksPerInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDXAxisTickHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDYAxisTickGridPadding)).BeginInit();
            this.SuspendLayout();
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
            this.chartControl1.Legend.Location = new System.Drawing.Point(591, 70);
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.DrawTickLabelGrid = true;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryXAxis.SmallTickSize = new System.Drawing.Size(1, 5);
            this.chartControl1.PrimaryXAxis.SmallTicksPerInterval = 5;
            this.chartControl1.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.chartControl1.PrimaryXAxis.TickSize = new System.Drawing.Size(2, 8);
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.ForceZero = true;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.SmallTickSize = new System.Drawing.Size(5, 1);
            this.chartControl1.PrimaryYAxis.SmallTicksPerInterval = 5;
            this.chartControl1.PrimaryYAxis.TickDrawingOperationMode = Syncfusion.Windows.Forms.Chart.ChartAxisTickDrawingOperationMode.IntervalFixed;
            this.chartControl1.PrimaryYAxis.TickSize = new System.Drawing.Size(8, 2);
            this.chartControl1.Size = new System.Drawing.Size(700, 622);
            this.chartControl1.Spacing = 40F;
            this.chartControl1.TabIndex = 0;
            // 
            // 
            // 
            this.chartControl1.Title.Margin = 1;
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartTitle1);
            this.chartControl1.ChartFormatAxisLabel += new Syncfusion.Windows.Forms.Chart.ChartFormatAxisLabelEventHandler(this.chartControl1_ChartFormatAxisLabel);
            // 
            // chartTitle1
            // 
            this.chartTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartTitle1.Margin = 1;
            this.chartTitle1.Name = "chartTitle1";
            this.chartTitle1.Text = "Transmission Life Expectancy";
            // 
            // imageListAdv1
            // 
            this.imageListAdv1.Images.AddRange(new System.Drawing.Image[] {
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images")))});
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.cbXAxisDrawLabelGrid);
            this.panel1.Controls.Add(this.nUDYAxisSmallTickWidth);
            this.panel1.Controls.Add(this.nUDXAxisSmallTickWidth);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nUDYAxisSmallTickHeight);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.nUDYAxisTickWidth);
            this.panel1.Controls.Add(this.nUDXAxisTickGridPadding);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.nUDXAxisTickWidth);
            this.panel1.Controls.Add(this.cpXAxisTickColor);
            this.panel1.Controls.Add(this.nUDXAxisSmallTickHeight);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nUDYAxisTickHeight);
            this.panel1.Controls.Add(this.nUDYAxisTicksPerInterval);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.nUDXAxisTicksPerInterval);
            this.panel1.Controls.Add(this.cbYAxisDrawLabelGrid);
            this.panel1.Controls.Add(this.cpYAxisTickColor);
            this.panel1.Controls.Add(this.nUDXAxisTickHeight);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nUDYAxisTickGridPadding);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(699, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 634);
            this.panel1.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label20.Location = new System.Drawing.Point(31, 666);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(108, 25);
            this.label20.TabIndex = 27;
            this.label20.Text = "Y Axis Ticks";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label19.Location = new System.Drawing.Point(32, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(108, 25);
            this.label19.TabIndex = 26;
            this.label19.Text = "X Axis Ticks";
            // 
            // cbXAxisDrawLabelGrid
            // 
            this.cbXAxisDrawLabelGrid.AutoSize = true;
            this.cbXAxisDrawLabelGrid.Checked = true;
            this.cbXAxisDrawLabelGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbXAxisDrawLabelGrid.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cbXAxisDrawLabelGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.cbXAxisDrawLabelGrid.Location = new System.Drawing.Point(35, 65);
            this.cbXAxisDrawLabelGrid.Name = "cbXAxisDrawLabelGrid";
            this.cbXAxisDrawLabelGrid.Size = new System.Drawing.Size(165, 24);
            this.cbXAxisDrawLabelGrid.TabIndex = 4;
            this.cbXAxisDrawLabelGrid.Text = "Draw Tick Label Grid";
            this.cbXAxisDrawLabelGrid.UseVisualStyleBackColor = true;
            this.cbXAxisDrawLabelGrid.CheckedChanged += new System.EventHandler(this.cbXAxisDrawLabelGrid_CheckedChanged);
            // 
            // nUDYAxisSmallTickWidth
            // 
            this.nUDYAxisSmallTickWidth.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nUDYAxisSmallTickWidth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.nUDYAxisSmallTickWidth.Location = new System.Drawing.Point(40, 1249);
            this.nUDYAxisSmallTickWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDYAxisSmallTickWidth.Name = "nUDYAxisSmallTickWidth";
            this.nUDYAxisSmallTickWidth.ReadOnly = true;
            this.nUDYAxisSmallTickWidth.Size = new System.Drawing.Size(167, 27);
            this.nUDYAxisSmallTickWidth.TabIndex = 20;
            this.nUDYAxisSmallTickWidth.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUDYAxisSmallTickWidth.ValueChanged += new System.EventHandler(this.nUDYAxisSmallTickWidth_ValueChanged);
            // 
            // nUDXAxisSmallTickWidth
            // 
            this.nUDXAxisSmallTickWidth.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nUDXAxisSmallTickWidth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.nUDXAxisSmallTickWidth.Location = new System.Drawing.Point(37, 614);
            this.nUDXAxisSmallTickWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDXAxisSmallTickWidth.Name = "nUDXAxisSmallTickWidth";
            this.nUDXAxisSmallTickWidth.ReadOnly = true;
            this.nUDXAxisSmallTickWidth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nUDXAxisSmallTickWidth.Size = new System.Drawing.Size(172, 27);
            this.nUDXAxisSmallTickWidth.TabIndex = 16;
            this.nUDXAxisSmallTickWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUDXAxisSmallTickWidth.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nUDXAxisSmallTickWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDXAxisSmallTickWidth.ValueChanged += new System.EventHandler(this.nUDXAxisSmallTickWidth_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label12.Location = new System.Drawing.Point(37, 1220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Small Ticks Size Width";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(31, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Small Ticks Per Interval";
            // 
            // nUDYAxisSmallTickHeight
            // 
            this.nUDYAxisSmallTickHeight.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nUDYAxisSmallTickHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.nUDYAxisSmallTickHeight.Location = new System.Drawing.Point(38, 1177);
            this.nUDYAxisSmallTickHeight.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDYAxisSmallTickHeight.Name = "nUDYAxisSmallTickHeight";
            this.nUDYAxisSmallTickHeight.ReadOnly = true;
            this.nUDYAxisSmallTickHeight.Size = new System.Drawing.Size(169, 27);
            this.nUDYAxisSmallTickHeight.TabIndex = 17;
            this.nUDYAxisSmallTickHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDYAxisSmallTickHeight.ValueChanged += new System.EventHandler(this.nUDYAxisSmallTickHeight_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label13.Location = new System.Drawing.Point(31, 575);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(157, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "Small Ticks Size Width";
            // 
            // nUDYAxisTickWidth
            // 
            this.nUDYAxisTickWidth.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nUDYAxisTickWidth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.nUDYAxisTickWidth.Location = new System.Drawing.Point(38, 1092);
            this.nUDYAxisTickWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDYAxisTickWidth.Name = "nUDYAxisTickWidth";
            this.nUDYAxisTickWidth.ReadOnly = true;
            this.nUDYAxisTickWidth.Size = new System.Drawing.Size(169, 27);
            this.nUDYAxisTickWidth.TabIndex = 25;
            this.nUDYAxisTickWidth.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nUDYAxisTickWidth.ValueChanged += new System.EventHandler(this.nUDYAxisTickWidth_ValueChanged);
            // 
            // nUDXAxisTickGridPadding
            // 
            this.nUDXAxisTickGridPadding.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nUDXAxisTickGridPadding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.nUDXAxisTickGridPadding.Location = new System.Drawing.Point(34, 290);
            this.nUDXAxisTickGridPadding.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDXAxisTickGridPadding.Name = "nUDXAxisTickGridPadding";
            this.nUDXAxisTickGridPadding.ReadOnly = true;
            this.nUDXAxisTickGridPadding.Size = new System.Drawing.Size(173, 27);
            this.nUDXAxisTickGridPadding.TabIndex = 8;
            this.nUDXAxisTickGridPadding.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUDXAxisTickGridPadding.ValueChanged += new System.EventHandler(this.nUDXAxisTickGridPadding_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label14.Location = new System.Drawing.Point(36, 1140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(162, 20);
            this.label14.TabIndex = 18;
            this.label14.Text = "Small Ticks Size Height";
            // 
            // nUDXAxisTickWidth
            // 
            this.nUDXAxisTickWidth.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nUDXAxisTickWidth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.nUDXAxisTickWidth.Location = new System.Drawing.Point(35, 445);
            this.nUDXAxisTickWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDXAxisTickWidth.Name = "nUDXAxisTickWidth";
            this.nUDXAxisTickWidth.ReadOnly = true;
            this.nUDXAxisTickWidth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nUDXAxisTickWidth.Size = new System.Drawing.Size(174, 27);
            this.nUDXAxisTickWidth.TabIndex = 21;
            this.nUDXAxisTickWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUDXAxisTickWidth.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nUDXAxisTickWidth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUDXAxisTickWidth.ValueChanged += new System.EventHandler(this.nUDXAxisTickWidth_ValueChanged);
            // 
            // cpXAxisTickColor
            // 
            this.cpXAxisTickColor.BackColor = System.Drawing.Color.Sienna;
            this.cpXAxisTickColor.BeforeTouchSize = new System.Drawing.Size(100, 30);
            this.cpXAxisTickColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.cpXAxisTickColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cpXAxisTickColor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cpXAxisTickColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.cpXAxisTickColor.IsBackStageButton = false;
            this.cpXAxisTickColor.Location = new System.Drawing.Point(35, 136);
            this.cpXAxisTickColor.Name = "cpXAxisTickColor";
            this.cpXAxisTickColor.SelectedAsBackcolor = true;
            this.cpXAxisTickColor.SelectedColor = System.Drawing.Color.Sienna;
            this.cpXAxisTickColor.Size = new System.Drawing.Size(100, 30);
            this.cpXAxisTickColor.TabIndex = 6;
            this.cpXAxisTickColor.UseVisualStyleBackColor = false;
            this.cpXAxisTickColor.ColorSelected += new System.EventHandler(this.cpXAxisTickColor_ColorSelected);
            // 
            // nUDXAxisSmallTickHeight
            // 
            this.nUDXAxisSmallTickHeight.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nUDXAxisSmallTickHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.nUDXAxisSmallTickHeight.Location = new System.Drawing.Point(37, 532);
            this.nUDXAxisSmallTickHeight.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDXAxisSmallTickHeight.Name = "nUDXAxisSmallTickHeight";
            this.nUDXAxisSmallTickHeight.ReadOnly = true;
            this.nUDXAxisSmallTickHeight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nUDXAxisSmallTickHeight.Size = new System.Drawing.Size(172, 27);
            this.nUDXAxisSmallTickHeight.TabIndex = 13;
            this.nUDXAxisSmallTickHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUDXAxisSmallTickHeight.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nUDXAxisSmallTickHeight.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUDXAxisSmallTickHeight.ValueChanged += new System.EventHandler(this.nUDXAxisSmallTickHeight_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label16.Location = new System.Drawing.Point(35, 1058);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 20);
            this.label16.TabIndex = 24;
            this.label16.Text = "Ticks Size Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(30, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tick Color";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label8.Location = new System.Drawing.Point(31, 738);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tick Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label6.Location = new System.Drawing.Point(33, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Small Ticks Size Height";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label10.Location = new System.Drawing.Point(34, 820);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Small Ticks Per Interval";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(30, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tick Label Grid Padding";
            // 
            // nUDYAxisTickHeight
            // 
            this.nUDYAxisTickHeight.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nUDYAxisTickHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.nUDYAxisTickHeight.Location = new System.Drawing.Point(38, 1016);
            this.nUDYAxisTickHeight.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDYAxisTickHeight.Name = "nUDYAxisTickHeight";
            this.nUDYAxisTickHeight.ReadOnly = true;
            this.nUDYAxisTickHeight.Size = new System.Drawing.Size(169, 27);
            this.nUDYAxisTickHeight.TabIndex = 22;
            this.nUDYAxisTickHeight.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUDYAxisTickHeight.ValueChanged += new System.EventHandler(this.nUDYAxisTickHeight_ValueChanged);
            // 
            // nUDYAxisTicksPerInterval
            // 
            this.nUDYAxisTicksPerInterval.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nUDYAxisTicksPerInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.nUDYAxisTicksPerInterval.Location = new System.Drawing.Point(38, 856);
            this.nUDYAxisTicksPerInterval.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDYAxisTicksPerInterval.Name = "nUDYAxisTicksPerInterval";
            this.nUDYAxisTicksPerInterval.ReadOnly = true;
            this.nUDYAxisTicksPerInterval.Size = new System.Drawing.Size(169, 27);
            this.nUDYAxisTicksPerInterval.TabIndex = 2;
            this.nUDYAxisTicksPerInterval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUDYAxisTicksPerInterval.ValueChanged += new System.EventHandler(this.nUDYAxisTicksPerInterval_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label18.Location = new System.Drawing.Point(34, 981);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(121, 20);
            this.label18.TabIndex = 21;
            this.label18.Text = "Ticks Size Heigth";
            // 
            // nUDXAxisTicksPerInterval
            // 
            this.nUDXAxisTicksPerInterval.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nUDXAxisTicksPerInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.nUDXAxisTicksPerInterval.Location = new System.Drawing.Point(34, 214);
            this.nUDXAxisTicksPerInterval.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDXAxisTicksPerInterval.Name = "nUDXAxisTicksPerInterval";
            this.nUDXAxisTicksPerInterval.ReadOnly = true;
            this.nUDXAxisTicksPerInterval.Size = new System.Drawing.Size(170, 27);
            this.nUDXAxisTicksPerInterval.TabIndex = 2;
            this.nUDXAxisTicksPerInterval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUDXAxisTicksPerInterval.ValueChanged += new System.EventHandler(this.nUDXAxisTicksPerInterval_ValueChanged);
            // 
            // cbYAxisDrawLabelGrid
            // 
            this.cbYAxisDrawLabelGrid.AutoSize = true;
            this.cbYAxisDrawLabelGrid.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cbYAxisDrawLabelGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.cbYAxisDrawLabelGrid.Location = new System.Drawing.Point(35, 703);
            this.cbYAxisDrawLabelGrid.Name = "cbYAxisDrawLabelGrid";
            this.cbYAxisDrawLabelGrid.Size = new System.Drawing.Size(165, 24);
            this.cbYAxisDrawLabelGrid.TabIndex = 4;
            this.cbYAxisDrawLabelGrid.Text = "Draw Tick Label Grid";
            this.cbYAxisDrawLabelGrid.UseVisualStyleBackColor = true;
            this.cbYAxisDrawLabelGrid.CheckedChanged += new System.EventHandler(this.cbYAxisDrawLabelGrid_CheckedChanged);
            // 
            // cpYAxisTickColor
            // 
            this.cpYAxisTickColor.BackColor = System.Drawing.Color.DimGray;
            this.cpYAxisTickColor.BeforeTouchSize = new System.Drawing.Size(100, 30);
            this.cpYAxisTickColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.cpYAxisTickColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cpYAxisTickColor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cpYAxisTickColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.cpYAxisTickColor.IsBackStageButton = false;
            this.cpYAxisTickColor.Location = new System.Drawing.Point(35, 774);
            this.cpYAxisTickColor.Name = "cpYAxisTickColor";
            this.cpYAxisTickColor.SelectedAsBackcolor = true;
            this.cpYAxisTickColor.SelectedColor = System.Drawing.Color.DimGray;
            this.cpYAxisTickColor.Size = new System.Drawing.Size(100, 30);
            this.cpYAxisTickColor.TabIndex = 6;
            this.cpYAxisTickColor.UseVisualStyleBackColor = false;
            this.cpYAxisTickColor.ColorSelected += new System.EventHandler(this.cpYAxisTickColor_ColorSelected);
            // 
            // nUDXAxisTickHeight
            // 
            this.nUDXAxisTickHeight.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nUDXAxisTickHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.nUDXAxisTickHeight.Location = new System.Drawing.Point(35, 370);
            this.nUDXAxisTickHeight.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDXAxisTickHeight.Name = "nUDXAxisTickHeight";
            this.nUDXAxisTickHeight.ReadOnly = true;
            this.nUDXAxisTickHeight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nUDXAxisTickHeight.Size = new System.Drawing.Size(172, 27);
            this.nUDXAxisTickHeight.TabIndex = 18;
            this.nUDXAxisTickHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUDXAxisTickHeight.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nUDXAxisTickHeight.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nUDXAxisTickHeight.ValueChanged += new System.EventHandler(this.nUDXAxisTickHeight_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.label7.Location = new System.Drawing.Point(34, 902);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tick Label Grid Padding";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(33, 412);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ticks Size Width";
            // 
            // nUDYAxisTickGridPadding
            // 
            this.nUDYAxisTickGridPadding.Enabled = false;
            this.nUDYAxisTickGridPadding.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nUDYAxisTickGridPadding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.nUDYAxisTickGridPadding.Location = new System.Drawing.Point(37, 940);
            this.nUDYAxisTickGridPadding.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDYAxisTickGridPadding.Name = "nUDYAxisTickGridPadding";
            this.nUDYAxisTickGridPadding.ReadOnly = true;
            this.nUDYAxisTickGridPadding.Size = new System.Drawing.Size(169, 27);
            this.nUDYAxisTickGridPadding.TabIndex = 8;
            this.nUDYAxisTickGridPadding.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUDYAxisTickGridPadding.ValueChanged += new System.EventHandler(this.nUDYAxisTickGridPadding_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label15.Location = new System.Drawing.Point(33, 336);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 20);
            this.label15.TabIndex = 17;
            this.label15.Text = "Ticks Size Heigth";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 634);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(660, 620);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tick Mark Customization";
            this.chartControl1.ResumeLayout(false);
            this.chartControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDYAxisSmallTickWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDXAxisSmallTickWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDYAxisSmallTickHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDYAxisTickWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDXAxisTickGridPadding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDXAxisTickWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDXAxisSmallTickHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDYAxisTickHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDYAxisTicksPerInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDXAxisTicksPerInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDXAxisTickHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDYAxisTickGridPadding)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private Syncfusion.Windows.Forms.Tools.ImageListAdv imageListAdv1;
        private Syncfusion.Windows.Forms.Chart.ChartTitle chartTitle1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nUDYAxisSmallTickWidth;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nUDYAxisSmallTickHeight;
        private System.Windows.Forms.NumericUpDown nUDYAxisTickWidth;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nUDYAxisTickHeight;
        private System.Windows.Forms.NumericUpDown nUDYAxisTicksPerInterval;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox cbYAxisDrawLabelGrid;
        public Syncfusion.Windows.Forms.ColorPickerButton cpYAxisTickColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nUDYAxisTickGridPadding;
        private System.Windows.Forms.NumericUpDown nUDXAxisSmallTickWidth;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nUDXAxisTickWidth;
        private System.Windows.Forms.NumericUpDown nUDXAxisSmallTickHeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nUDXAxisTicksPerInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox cbXAxisDrawLabelGrid;
        private System.Windows.Forms.NumericUpDown nUDXAxisTickHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nUDXAxisTickGridPadding;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        public Syncfusion.Windows.Forms.ColorPickerButton cpXAxisTickColor;


    }
}

