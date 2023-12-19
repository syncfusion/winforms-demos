#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace PortfolioManager.Analyzer
{
    partial class Performance
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Performance));
            this.performanceChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.chartPeriodTollStrip = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.last3Months = new System.Windows.Forms.ToolStripButton();
            this.last6Months = new System.Windows.Forms.ToolStripButton();
            this.lastYear = new System.Windows.Forms.ToolStripButton();
            this.vanguardFundsCheckBox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.SchwabFundsCheckBox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.AmericanFundsCheckBox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.chartPeriodTollStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vanguardFundsCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SchwabFundsCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmericanFundsCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.SuspendLayout();
            // 
            // performanceChart
            // 
            this.performanceChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.performanceChart.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, System.Drawing.Color.White, System.Drawing.Color.White);
            this.performanceChart.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.performanceChart.ChartArea.CursorReDraw = false;
            this.performanceChart.ChartInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.performanceChart.IsWindowLess = false;
            // 
            // 
            // 
            this.performanceChart.Legend.Location = new System.Drawing.Point(404, 69);
            this.performanceChart.Localize = null;
            this.performanceChart.Location = new System.Drawing.Point(35, 35);
            this.performanceChart.Name = "performanceChart";
            this.performanceChart.PrimaryXAxis.Crossing = double.NaN;
            this.performanceChart.PrimaryXAxis.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performanceChart.PrimaryXAxis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(134)))), ((int)(((byte)(173)))));
            this.performanceChart.PrimaryXAxis.Margin = true;
            this.performanceChart.PrimaryYAxis.Crossing = double.NaN;
            this.performanceChart.PrimaryYAxis.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performanceChart.PrimaryYAxis.ForceZero = true;
            this.performanceChart.PrimaryYAxis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(134)))), ((int)(((byte)(173)))));
            this.performanceChart.PrimaryYAxis.Margin = true;
            this.performanceChart.Size = new System.Drawing.Size(513, 404);
            this.performanceChart.TabIndex = 0;
            this.performanceChart.Text = "chartControl1";
            // 
            // 
            // 
            this.performanceChart.Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performanceChart.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.performanceChart.Title.Name = "Default";
            this.performanceChart.Titles.Add(this.performanceChart.Title);
            // 
            // chartPeriodTollStrip
            // 
            this.chartPeriodTollStrip.BackColor = System.Drawing.Color.White;
            this.chartPeriodTollStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chartPeriodTollStrip.CaptionAlignment = Syncfusion.Windows.Forms.Tools.CaptionAlignment.Near;
            this.chartPeriodTollStrip.CaptionFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartPeriodTollStrip.CaptionMinHeight = 25;
            this.chartPeriodTollStrip.CaptionStyle = Syncfusion.Windows.Forms.Tools.CaptionStyle.Top;
            this.chartPeriodTollStrip.CaptionTextStyle = Syncfusion.Windows.Forms.Tools.CaptionTextStyle.Plain;
            this.chartPeriodTollStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartPeriodTollStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.chartPeriodTollStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.chartPeriodTollStrip.Image = null;
            this.chartPeriodTollStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.last3Months,
            this.last6Months,
            this.lastYear});
            this.chartPeriodTollStrip.Location = new System.Drawing.Point(0, 0);
            this.chartPeriodTollStrip.Name = "chartPeriodTollStrip";
            this.chartPeriodTollStrip.Size = new System.Drawing.Size(885, 50);
            this.chartPeriodTollStrip.TabIndex = 1;
            this.chartPeriodTollStrip.Text = "Choose Chart Period";
            // 
            // last3Months
            // 
            this.last3Months.Image = ((System.Drawing.Image)(resources.GetObject("last3Months.Image")));
            this.last3Months.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.last3Months.Name = "last3Months";
            this.last3Months.Size = new System.Drawing.Size(88, 22);
            this.last3Months.Text = "Last3Months";
            this.last3Months.Click += new System.EventHandler(this.last3Months_Click);
            // 
            // last6Months
            // 
            this.last6Months.Image = ((System.Drawing.Image)(resources.GetObject("last6Months.Image")));
            this.last6Months.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.last6Months.Name = "last6Months";
            this.last6Months.Size = new System.Drawing.Size(88, 22);
            this.last6Months.Text = "Last6Months";
            this.last6Months.Click += new System.EventHandler(this.last6Months_Click);
            // 
            // lastYear
            // 
            this.lastYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.lastYear.Image = ((System.Drawing.Image)(resources.GetObject("lastYear.Image")));
            this.lastYear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lastYear.Name = "lastYear";
            this.lastYear.Size = new System.Drawing.Size(69, 22);
            this.lastYear.Text = "LastYear";
            this.lastYear.Click += new System.EventHandler(this.lastYear_Click);
            // 
            // vanguardFundsCheckBox
            // 
            this.vanguardFundsCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.vanguardFundsCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.vanguardFundsCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.vanguardFundsCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.vanguardFundsCheckBox.Location = new System.Drawing.Point(573, 207);
            this.vanguardFundsCheckBox.MetroColor = System.Drawing.Color.Blue;
            this.vanguardFundsCheckBox.Name = "vanguardFundsCheckBox";
            this.vanguardFundsCheckBox.Size = new System.Drawing.Size(132, 21);
            this.vanguardFundsCheckBox.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2007;
            this.vanguardFundsCheckBox.TabIndex = 2;
            this.vanguardFundsCheckBox.Text = "VanguardFunds";
            this.vanguardFundsCheckBox.ThemesEnabled = false;
            this.vanguardFundsCheckBox.CheckStateChanged += new System.EventHandler(this.vanguardFundsCheckBox_CheckStateChanged);
            // 
            // SchwabFundsCheckBox
            // 
            this.SchwabFundsCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SchwabFundsCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.SchwabFundsCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.SchwabFundsCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.SchwabFundsCheckBox.Location = new System.Drawing.Point(573, 180);
            this.SchwabFundsCheckBox.MetroColor = System.Drawing.Color.Blue;
            this.SchwabFundsCheckBox.Name = "SchwabFundsCheckBox";
            this.SchwabFundsCheckBox.Size = new System.Drawing.Size(132, 21);
            this.SchwabFundsCheckBox.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2007;
            this.SchwabFundsCheckBox.TabIndex = 1;
            this.SchwabFundsCheckBox.Text = "SchwabFunds";
            this.SchwabFundsCheckBox.ThemesEnabled = false;
            this.SchwabFundsCheckBox.CheckStateChanged += new System.EventHandler(this.SchwabFundsCheckBox_CheckStateChanged);
            // 
            // AmericanFundsCheckBox
            // 
            this.AmericanFundsCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AmericanFundsCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.AmericanFundsCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AmericanFundsCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.AmericanFundsCheckBox.Location = new System.Drawing.Point(573, 153);
            this.AmericanFundsCheckBox.MetroColor = System.Drawing.Color.Blue;
            this.AmericanFundsCheckBox.Name = "AmericanFundsCheckBox";
            this.AmericanFundsCheckBox.Size = new System.Drawing.Size(132, 21);
            this.AmericanFundsCheckBox.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2007;
            this.AmericanFundsCheckBox.TabIndex = 0;
            this.AmericanFundsCheckBox.Text = "AmericanFunds";
            this.AmericanFundsCheckBox.ThemesEnabled = false;
            this.AmericanFundsCheckBox.CheckStateChanged += new System.EventHandler(this.AmericanFundsCheckBox_CheckStateChanged);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.White;
            this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.gradientPanel1.Controls.Add(this.gradientPanel2);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.AmericanFundsCheckBox);
            this.gradientPanel1.Controls.Add(this.SchwabFundsCheckBox);
            this.gradientPanel1.Controls.Add(this.vanguardFundsCheckBox);
            this.gradientPanel1.Controls.Add(this.performanceChart);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gradientPanel1.Location = new System.Drawing.Point(0, 50);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(885, 497);
            this.gradientPanel1.TabIndex = 3;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gradientPanel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, new System.Drawing.Color[] {
            System.Drawing.Color.DimGray,
            System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(178)))), ((int)(((byte)(206))))),
            System.Drawing.Color.DimGray});
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel2.Location = new System.Drawing.Point(554, 33);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(2, 410);
            this.gradientPanel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.label1.Location = new System.Drawing.Point(570, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Large Cap Accounts";
            // 
            // Performance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.chartPeriodTollStrip);
            this.Name = "Performance";
            this.Size = new System.Drawing.Size(885, 547);
            this.chartPeriodTollStrip.ResumeLayout(false);
            this.chartPeriodTollStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vanguardFundsCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SchwabFundsCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmericanFundsCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Chart.ChartControl performanceChart;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx chartPeriodTollStrip;
        private System.Windows.Forms.ToolStripButton last3Months;
        private System.Windows.Forms.ToolStripButton last6Months;
        private System.Windows.Forms.ToolStripButton lastYear;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv vanguardFundsCheckBox;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv SchwabFundsCheckBox;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv AmericanFundsCheckBox;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
    }
}
