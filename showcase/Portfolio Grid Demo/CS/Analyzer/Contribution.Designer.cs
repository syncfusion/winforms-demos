#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace PortfolioManager.Analyzer
{
    partial class Contribution
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
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries1 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartBorder chartBorder1 = new Syncfusion.Windows.Forms.Chart.ChartBorder();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries2 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries3 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartBorder chartBorder2 = new Syncfusion.Windows.Forms.Chart.ChartBorder();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries4 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            this.accountsChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.n = new System.Windows.Forms.TableLayoutPanel();
            this.accountChartPanel = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.contributionChartPanel = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.contributionChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.countryRadioButton = new System.Windows.Forms.RadioButton();
            this.sectorRadioButton = new System.Windows.Forms.RadioButton();
            this.n.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountChartPanel)).BeginInit();
            this.accountChartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contributionChartPanel)).BeginInit();
            this.contributionChartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountsChart
            // 
            this.accountsChart.AllowGradientPalette = true;
            this.accountsChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountsChart.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.accountsChart.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.accountsChart.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.accountsChart.ChartArea.CursorReDraw = false;
            this.accountsChart.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.accountsChart.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(144)))), ((int)(((byte)(34))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(190)))), ((int)(((byte)(82))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(222)))), ((int)(((byte)(37))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(66)))), ((int)(((byte)(153))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(90)))), ((int)(((byte)(36))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(38)))))};
            this.accountsChart.ElementsSpacing = 4;
            this.accountsChart.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.accountsChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.accountsChart.IsWindowLess = false;
            // 
            // 
            // 
            this.accountsChart.Legend.Location = new System.Drawing.Point(289, 75);
            this.accountsChart.Legend.Visible = false;
            this.accountsChart.Localize = null;
            this.accountsChart.Location = new System.Drawing.Point(3, 37);
            this.accountsChart.Name = "accountsChart";
            this.accountsChart.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.accountsChart.PrimaryXAxis.Crossing = double.NaN;
            this.accountsChart.PrimaryXAxis.DrawGrid = false;
            this.accountsChart.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.accountsChart.PrimaryXAxis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.accountsChart.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.accountsChart.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.accountsChart.PrimaryXAxis.Margin = true;
            this.accountsChart.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.accountsChart.PrimaryXAxis.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.accountsChart.PrimaryXAxis.ValueType = Syncfusion.Windows.Forms.Chart.ChartValueType.Custom;
            this.accountsChart.PrimaryYAxis.Crossing = double.NaN;
            this.accountsChart.PrimaryYAxis.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.accountsChart.PrimaryYAxis.ForceZero = true;
            this.accountsChart.PrimaryYAxis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.accountsChart.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.accountsChart.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.accountsChart.PrimaryYAxis.Margin = true;
            this.accountsChart.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.accountsChart.PrimaryYAxis.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.accountsChart.Title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.accountsChart.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            chartSeries1.Name = "Default0";
            chartSeries1.Points.Add(1D, ((double)(55D)));
            chartSeries1.Points.Add(2D, ((double)(70D)));
            chartSeries1.Points.Add(3D, ((double)(80D)));
            chartSeries1.Points.Add(4D, ((double)(65D)));
            chartSeries1.Points.Add(5D, ((double)(75D)));
            chartSeries1.Resolution = 0D;
            chartSeries1.StackingGroup = "Default Group";
            chartSeries1.Style.ElementBorders.Inner = chartBorder1;
            chartSeries1.Style.Font.Facename = "Microsoft Sans Serif";
            chartSeries1.Text = "Default0";
            chartSeries2.Name = "Default1";
            chartSeries2.Points.Add(1D, ((double)(70D)));
            chartSeries2.Points.Add(2D, ((double)(35D)));
            chartSeries2.Points.Add(3D, ((double)(65D)));
            chartSeries2.Points.Add(4D, ((double)(25D)));
            chartSeries2.Points.Add(5D, ((double)(50D)));
            chartSeries2.Resolution = 0D;
            chartSeries2.StackingGroup = "Default Group";
            chartSeries2.Style.ElementBorders.Inner = chartBorder1;
            chartSeries2.Style.Font.Facename = "Microsoft Sans Serif";
            chartSeries2.Text = "Default1";
            this.accountsChart.Series.Add(chartSeries1);
            this.accountsChart.Series.Add(chartSeries2);
            this.accountsChart.Size = new System.Drawing.Size(443, 412);
            this.accountsChart.TabIndex = 0;
            this.accountsChart.Text = "Portfolio Accounts";
            // 
            // 
            // 
            this.accountsChart.Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountsChart.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.accountsChart.Title.Name = "Default";
            this.accountsChart.Titles.Add(this.accountsChart.Title);
            // 
            // n
            // 
            this.n.BackColor = System.Drawing.Color.White;
            this.n.ColumnCount = 2;
            this.n.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.83992F));
            this.n.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.16008F));
            this.n.Controls.Add(this.accountChartPanel, 0, 0);
            this.n.Controls.Add(this.contributionChartPanel, 1, 0);
            this.n.Dock = System.Windows.Forms.DockStyle.Fill;
            this.n.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.n.Location = new System.Drawing.Point(0, 0);
            this.n.Name = "n";
            this.n.RowCount = 1;
            this.n.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.92776F));
            this.n.Size = new System.Drawing.Size(937, 467);
            this.n.TabIndex = 1;
            // 
            // accountChartPanel
            // 
            this.accountChartPanel.BackColor = System.Drawing.Color.White;
            this.accountChartPanel.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.accountChartPanel.BorderColor = System.Drawing.Color.Transparent;
            this.accountChartPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accountChartPanel.Controls.Add(this.label1);
            this.accountChartPanel.Controls.Add(this.accountsChart);
            this.accountChartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountChartPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.accountChartPanel.Location = new System.Drawing.Point(3, 3);
            this.accountChartPanel.Name = "accountChartPanel";
            this.accountChartPanel.Size = new System.Drawing.Size(461, 461);
            this.accountChartPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click the Portfolio accounts to DrillDown by Contributions";
            // 
            // contributionChartPanel
            // 
            this.contributionChartPanel.BackColor = System.Drawing.Color.White;
            this.contributionChartPanel.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.contributionChartPanel.BorderColor = System.Drawing.Color.Transparent;
            this.contributionChartPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contributionChartPanel.Controls.Add(this.contributionChart);
            this.contributionChartPanel.Controls.Add(this.gradientPanel1);
            this.contributionChartPanel.Controls.Add(this.countryRadioButton);
            this.contributionChartPanel.Controls.Add(this.sectorRadioButton);
            this.contributionChartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contributionChartPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.contributionChartPanel.Location = new System.Drawing.Point(470, 3);
            this.contributionChartPanel.Name = "contributionChartPanel";
            this.contributionChartPanel.Size = new System.Drawing.Size(464, 461);
            this.contributionChartPanel.TabIndex = 3;
            // 
            // contributionChart
            // 
            this.contributionChart.AllowGradientPalette = true;
            this.contributionChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contributionChart.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.contributionChart.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.contributionChart.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.contributionChart.ChartArea.CursorReDraw = false;
            this.contributionChart.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(0, 0, 0, 0);
            this.contributionChart.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.contributionChart.ElementsSpacing = 0;
            this.contributionChart.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.contributionChart.Title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.contributionChart.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.contributionChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.contributionChart.IsWindowLess = false;
            // 
            // 
            // 
            this.contributionChart.Legend.Location = new System.Drawing.Point(486, 75);
            this.contributionChart.Legend.Visible = false;
            this.contributionChart.Localize = null;
            this.contributionChart.Location = new System.Drawing.Point(3, 65);
            this.contributionChart.Name = "contributionChart";
            this.contributionChart.PrimaryXAxis.Crossing = double.NaN;
            this.contributionChart.PrimaryXAxis.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contributionChart.PrimaryXAxis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.contributionChart.PrimaryXAxis.Margin = true;
            this.contributionChart.PrimaryYAxis.Crossing = double.NaN;
            this.contributionChart.PrimaryYAxis.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contributionChart.PrimaryYAxis.ForceZero = true;
            this.contributionChart.PrimaryYAxis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.contributionChart.PrimaryYAxis.Margin = true;
            chartSeries3.Name = "Default0";
            chartSeries3.Points.Add(1D, ((double)(55D)));
            chartSeries3.Points.Add(2D, ((double)(70D)));
            chartSeries3.Points.Add(3D, ((double)(80D)));
            chartSeries3.Points.Add(4D, ((double)(65D)));
            chartSeries3.Points.Add(5D, ((double)(75D)));
            chartSeries3.Resolution = 0D;
            chartSeries3.StackingGroup = "Default Group";
            chartSeries3.Style.ElementBorders.Inner = chartBorder2;
            chartSeries3.Style.Font.Facename = "Microsoft Sans Serif";
            chartSeries3.Text = "Default0";
            chartSeries4.Name = "Default1";
            chartSeries4.Points.Add(1D, ((double)(70D)));
            chartSeries4.Points.Add(2D, ((double)(35D)));
            chartSeries4.Points.Add(3D, ((double)(65D)));
            chartSeries4.Points.Add(4D, ((double)(25D)));
            chartSeries4.Points.Add(5D, ((double)(50D)));
            chartSeries4.Resolution = 0D;
            chartSeries4.StackingGroup = "Default Group";
            chartSeries4.Style.ElementBorders.Inner = chartBorder2;
            chartSeries4.Style.Font.Facename = "Microsoft Sans Serif";
            chartSeries4.Text = "Default1";
            this.contributionChart.Series.Add(chartSeries3);
            this.contributionChart.Series.Add(chartSeries4);
            this.contributionChart.Size = new System.Drawing.Size(458, 384);
            this.contributionChart.TabIndex = 0;
            this.contributionChart.Text = "Contributions";
            // 
            // 
            // 
            this.contributionChart.Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contributionChart.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.contributionChart.Title.Name = "Default";
            this.contributionChart.Titles.Add(this.contributionChart.Title);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.White, System.Drawing.Color.Transparent);
            this.gradientPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gradientPanel1.Location = new System.Drawing.Point(12, 11);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(319, 22);
            this.gradientPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.label2.Location = new System.Drawing.Point(1, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "GroupBy Options";
            // 
            // countryRadioButton
            // 
            this.countryRadioButton.AutoSize = true;
            this.countryRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.countryRadioButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.countryRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.countryRadioButton.Location = new System.Drawing.Point(111, 37);
            this.countryRadioButton.Name = "countryRadioButton";
            this.countryRadioButton.Size = new System.Drawing.Size(66, 17);
            this.countryRadioButton.TabIndex = 2;
            this.countryRadioButton.TabStop = true;
            this.countryRadioButton.Text = "Country";
            this.countryRadioButton.UseVisualStyleBackColor = false;
            this.countryRadioButton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // sectorRadioButton
            // 
            this.sectorRadioButton.AutoSize = true;
            this.sectorRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.sectorRadioButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.sectorRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.sectorRadioButton.Location = new System.Drawing.Point(21, 37);
            this.sectorRadioButton.Name = "sectorRadioButton";
            this.sectorRadioButton.Size = new System.Drawing.Size(57, 17);
            this.sectorRadioButton.TabIndex = 0;
            this.sectorRadioButton.TabStop = true;
            this.sectorRadioButton.Text = "Sector";
            this.sectorRadioButton.UseVisualStyleBackColor = false;
            this.sectorRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Contribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.n);
            this.Name = "Contribution";
            this.Size = new System.Drawing.Size(937, 467);
            this.n.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountChartPanel)).EndInit();
            this.accountChartPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contributionChartPanel)).EndInit();
            this.contributionChartPanel.ResumeLayout(false);
            this.contributionChartPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Chart.ChartControl accountsChart;
        private System.Windows.Forms.TableLayoutPanel n;
        private Syncfusion.Windows.Forms.Chart.ChartControl contributionChart;
        private System.Windows.Forms.RadioButton countryRadioButton;
        private System.Windows.Forms.RadioButton sectorRadioButton;
        private Syncfusion.Windows.Forms.Tools.GradientPanel accountChartPanel;
        private Syncfusion.Windows.Forms.Tools.GradientPanel contributionChartPanel;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label2;



    }
}
