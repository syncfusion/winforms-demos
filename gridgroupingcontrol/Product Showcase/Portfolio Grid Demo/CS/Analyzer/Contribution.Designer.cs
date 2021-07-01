#region Copyright Syncfusion Inc. 2001 - 2015
// Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Drawing;
namespace PortfolioManager.Analyzer
{
    partial class Contribution
    {
        #region "API Definition"
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Syncfusion.Windows.Forms.Chart.ChartControl accountsChart;
        private System.Windows.Forms.TableLayoutPanel n;
        private Syncfusion.Windows.Forms.Chart.ChartControl contributionChart;
        private System.Windows.Forms.RadioButton countryRadioButton;
        private System.Windows.Forms.RadioButton sectorRadioButton;
        private Syncfusion.Windows.Forms.Tools.GradientPanel accountChartPanel;
        private Syncfusion.Windows.Forms.Tools.GradientPanel contributionChartPanel;
        private System.Windows.Forms.Label label1;

        #endregion

        #region "Designer Stuffs"

        #region "Dispose"
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
        #endregion

        #region "Component Designer generated code"

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries1 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartBorder chartBorder1 = new Syncfusion.Windows.Forms.Chart.ChartBorder();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo1 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartLineInfo chartLineInfo1 = new Syncfusion.Windows.Forms.Chart.ChartLineInfo();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries2 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo2 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries3 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartBorder chartBorder2 = new Syncfusion.Windows.Forms.Chart.ChartBorder();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo3 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartLineInfo chartLineInfo2 = new Syncfusion.Windows.Forms.Chart.ChartLineInfo();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries4 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo4 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem chartToolBarSaveItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem chartToolBarCopyItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem chartToolBarPrintItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3DItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
            this.accountsChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.n = new System.Windows.Forms.TableLayoutPanel();
            this.accountChartPanel = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.contributionChartPanel = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.countryRadioButton = new System.Windows.Forms.RadioButton();
            this.sectorRadioButton = new System.Windows.Forms.RadioButton();
            this.contributionChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.n.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountChartPanel)).BeginInit();
            this.accountChartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contributionChartPanel)).BeginInit();
            this.contributionChartPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountsChart
            // 
            this.accountsChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.accountsChart.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.accountsChart.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.accountsChart.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.accountsChart.ChartArea.CursorReDraw = false;
            this.accountsChart.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.accountsChart.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(54))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(65)))), ((int)(((byte)(104))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(247))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(187)))), ((int)(((byte)(20))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(127)))), ((int)(((byte)(49))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))))};
            this.accountsChart.DataSourceName = "";
            this.accountsChart.ElementsSpacing = 4;
            this.accountsChart.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.accountsChart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.accountsChart.IsWindowLess = false;
            // 
            // 
            // 
            this.accountsChart.Legend.Location = new System.Drawing.Point(289, 75);
            this.accountsChart.Legend.Visible = false;
            this.accountsChart.Localize = null;
            this.accountsChart.Location = new System.Drawing.Point(3, 37);
            this.accountsChart.Name = "accountsChart";
            this.accountsChart.PrimaryXAxis.Crossing = double.NaN;
            this.accountsChart.PrimaryXAxis.DrawGrid = false;
            this.accountsChart.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.accountsChart.PrimaryXAxis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.accountsChart.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.accountsChart.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.accountsChart.PrimaryXAxis.Margin = true;
            this.accountsChart.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.accountsChart.PrimaryXAxis.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.accountsChart.PrimaryXAxis.ValueType = Syncfusion.Windows.Forms.Chart.ChartValueType.Custom;
            this.accountsChart.PrimaryYAxis.Crossing = double.NaN;
            this.accountsChart.PrimaryYAxis.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.accountsChart.PrimaryYAxis.ForceZero = true;
            this.accountsChart.PrimaryYAxis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.accountsChart.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.accountsChart.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.accountsChart.PrimaryYAxis.Margin = true;
            this.accountsChart.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.accountsChart.PrimaryYAxis.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            chartSeries1.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries1.Name = "Default0";
            chartSeries1.Points.Add(1D, ((double)(55D)));
            chartSeries1.Points.Add(2D, ((double)(70D)));
            chartSeries1.Points.Add(3D, ((double)(80D)));
            chartSeries1.Points.Add(4D, ((double)(65D)));
            chartSeries1.Points.Add(5D, ((double)(75D)));
            chartSeries1.Resolution = 0D;
            chartSeries1.StackingGroup = "Default Group";
            chartSeries1.Style.AltTagFormat = "";
            chartSeries1.Style.DrawTextShape = false;
            chartSeries1.Style.Symbol.Border = chartLineInfo1;
            chartSeries1.Style.Font.Facename = "Microsoft Sans Serif";
            chartLineInfo1.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
            chartLineInfo1.Color = System.Drawing.SystemColors.ControlText;
            chartLineInfo1.DashPattern = null;
            chartLineInfo1.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartLineInfo1.Width = 1F;
            chartCustomShapeInfo1.Border = chartLineInfo1;
            chartCustomShapeInfo1.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo1.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries1.Style.TextShape = chartCustomShapeInfo1;
            chartSeries1.Text = "Default0";
            chartSeries2.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries2.Name = "Default1";
            chartSeries2.Points.Add(1D, ((double)(70D)));
            chartSeries2.Points.Add(2D, ((double)(35D)));
            chartSeries2.Points.Add(3D, ((double)(65D)));
            chartSeries2.Points.Add(4D, ((double)(25D)));
            chartSeries2.Points.Add(5D, ((double)(50D)));
            chartSeries2.Resolution = 0D;
            chartSeries2.StackingGroup = "Default Group";
            chartSeries2.Style.AltTagFormat = "";
            chartSeries2.Style.DrawTextShape = false;
            chartSeries2.Style.Symbol.Border = chartLineInfo1;
            chartSeries2.Style.Font.Facename = "Microsoft Sans Serif";
            chartCustomShapeInfo2.Border = chartLineInfo1;
            chartCustomShapeInfo2.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo2.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries2.Style.TextShape = chartCustomShapeInfo2;
            chartSeries2.Text = "Default1";
            this.accountsChart.Series.Add(chartSeries1);
            this.accountsChart.Series.Add(chartSeries2);
            this.accountsChart.Size = new System.Drawing.Size(443, 412);
            this.accountsChart.TabIndex = 0;
            this.accountsChart.Text = "Portfolio Accounts";
            // 
            // 
            // 
            this.accountsChart.Title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountsChart.Title.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click the Portfolio accounts to DrillDown by Contributions";
            // 
            // contributionChartPanel
            // 
            this.contributionChartPanel.BackColor = System.Drawing.Color.White;
            this.contributionChartPanel.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.contributionChartPanel.BorderColor = System.Drawing.Color.Transparent;
            this.contributionChartPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contributionChartPanel.Controls.Add(this.panel1);
            this.contributionChartPanel.Controls.Add(this.contributionChart);
            this.contributionChartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contributionChartPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.contributionChartPanel.Location = new System.Drawing.Point(470, 3);
            this.contributionChartPanel.Name = "contributionChartPanel";
            this.contributionChartPanel.Size = new System.Drawing.Size(464, 461);
            this.contributionChartPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(23, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 56);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.countryRadioButton);
            this.groupBox1.Controls.Add(this.sectorRadioButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 56);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GroupBy Options";
            // 
            // countryRadioButton
            // 
            this.countryRadioButton.AutoSize = true;
            this.countryRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.countryRadioButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.countryRadioButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.countryRadioButton.Location = new System.Drawing.Point(98, 26);
            this.countryRadioButton.Name = "countryRadioButton";
            this.countryRadioButton.Size = new System.Drawing.Size(77, 23);
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
            this.sectorRadioButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sectorRadioButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sectorRadioButton.Location = new System.Drawing.Point(6, 26);
            this.sectorRadioButton.Name = "sectorRadioButton";
            this.sectorRadioButton.Size = new System.Drawing.Size(65, 23);
            this.sectorRadioButton.TabIndex = 0;
            this.sectorRadioButton.TabStop = true;
            this.sectorRadioButton.Text = "Sector";
            this.sectorRadioButton.UseVisualStyleBackColor = false;
            this.sectorRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
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
            this.contributionChart.DataSourceName = "";
            this.contributionChart.ElementsSpacing = 0;
            this.contributionChart.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.contributionChart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.contributionChart.IsWindowLess = false;
            // 
            // 
            // 
            this.contributionChart.Legend.Location = new System.Drawing.Point(486, 75);
            this.contributionChart.Legend.Visible = false;
            this.contributionChart.Localize = null;
            this.contributionChart.Location = new System.Drawing.Point(3, 65);
            this.contributionChart.Name = "contributionChart";
            this.contributionChart.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Metro;
            this.contributionChart.PrimaryXAxis.Crossing = double.NaN;
            this.contributionChart.PrimaryXAxis.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contributionChart.PrimaryXAxis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.contributionChart.PrimaryXAxis.Margin = true;
            this.contributionChart.PrimaryYAxis.Crossing = double.NaN;
            this.contributionChart.PrimaryYAxis.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contributionChart.PrimaryYAxis.ForceZero = true;
            this.contributionChart.PrimaryYAxis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.contributionChart.PrimaryYAxis.Margin = true;
            chartSeries3.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries3.Name = "Default0";
            chartSeries3.Points.Add(1D, ((double)(55D)));
            chartSeries3.Points.Add(2D, ((double)(70D)));
            chartSeries3.Points.Add(3D, ((double)(80D)));
            chartSeries3.Points.Add(4D, ((double)(65D)));
            chartSeries3.Points.Add(5D, ((double)(75D)));
            chartSeries3.Resolution = 0D;
            chartSeries3.StackingGroup = "Default Group";
            chartSeries3.Style.AltTagFormat = "";
            chartSeries3.Style.DrawTextShape = false;
            chartSeries3.Style.Symbol.Border = chartLineInfo2;
            chartSeries3.Style.Font.Facename = "Microsoft Sans Serif";
            chartLineInfo2.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
            chartLineInfo2.Color = System.Drawing.SystemColors.ControlText;
            chartLineInfo2.DashPattern = null;
            chartLineInfo2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartLineInfo2.Width = 1F;
            chartCustomShapeInfo3.Border = chartLineInfo2;
            chartCustomShapeInfo3.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo3.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries3.Style.TextShape = chartCustomShapeInfo3;
            chartSeries3.Text = "Default0";
            chartSeries4.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries4.Name = "Default1";
            chartSeries4.Points.Add(1D, ((double)(70D)));
            chartSeries4.Points.Add(2D, ((double)(35D)));
            chartSeries4.Points.Add(3D, ((double)(65D)));
            chartSeries4.Points.Add(4D, ((double)(25D)));
            chartSeries4.Points.Add(5D, ((double)(50D)));
            chartSeries4.Resolution = 0D;
            chartSeries4.StackingGroup = "Default Group";
            chartSeries4.Style.AltTagFormat = "";
            chartSeries4.Style.DrawTextShape = false;
            chartSeries4.Style.Symbol.Border = chartLineInfo2;
            chartSeries4.Style.Font.Facename = "Microsoft Sans Serif";
            chartCustomShapeInfo4.Border = chartLineInfo2;
            chartCustomShapeInfo4.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo4.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries4.Style.TextShape = chartCustomShapeInfo4;
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
            this.contributionChart.Title.ForeColor = System.Drawing.SystemColors.ControlText;
            this.contributionChart.Title.Name = "Default";
            this.contributionChart.Titles.Add(this.contributionChart.Title);
            this.contributionChart.ToolBar.EnableDefaultItems = false;
            this.contributionChart.ToolBar.Items.Add(chartToolBarSaveItem1);
            this.contributionChart.ToolBar.Items.Add(chartToolBarCopyItem1);
            this.contributionChart.ToolBar.Items.Add(chartToolBarPrintItem1);
            this.contributionChart.ToolBar.Items.Add(chartToolBarPrintPreviewItem1);
            this.contributionChart.ToolBar.Items.Add(chartToolBarSplitter1);
            this.contributionChart.ToolBar.Items.Add(chartToolBarPaletteItem1);
            this.contributionChart.ToolBar.Items.Add(chartToolBarStyleItem1);
            this.contributionChart.ToolBar.Items.Add(chartToolBarTypeItem1);
            this.contributionChart.ToolBar.Items.Add(chartToolBarSeries3DItem1);
            this.contributionChart.ToolBar.Items.Add(chartToolBarShowLegendItem1);
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
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;

        #endregion
        private System.Windows.Forms.Panel panel1;

    }
}
