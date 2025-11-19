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
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;


namespace Trackball
{
    public class Form1 : MetroForm
    {
        #region Private Members
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private System.Windows.Forms.Panel panel1;

        int count = 0;

        #endregion

        private CheckBox checkBox1;
        private Label label1;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label6;
        private NumericUpDown numericUpDown2;
        private Label label7;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Label label8;
        private ComboBox comboBox1;
        private Label label9;
        private TextBox textBox3;
        private IContainer components;

        #region Constructor, Main And Dispose
        public Form1()
        {
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
            Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem chartToolBarSaveItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem chartToolBarCopyItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem chartToolBarPrintItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3DItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = DockStyle.Right;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(700, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 585);
            this.panel1.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label9.Location = new System.Drawing.Point(23, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Y value format";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(130, 230);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(87, 27);
            this.textBox3.TabIndex = 29;
            this.textBox3.Text = "n0";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox1.Location = new System.Drawing.Point(130, 344);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(103, 28);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label8.Location = new System.Drawing.Point(23, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Display Mode";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(130, 302);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(85, 27);
            this.numericUpDown2.TabIndex = 26;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label7.Location = new System.Drawing.Point(23, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Border Width";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(130, 269);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(85, 27);
            this.numericUpDown1.TabIndex = 24;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(23, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Corner Radius";
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label6.Location = new System.Drawing.Point(25, 130);
            this.label6.MaximumSize = new System.Drawing.Size(250, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 48);
            this.label6.TabIndex = 21;
            this.label6.Text = "{1} - Place holder for X value of the data point, {2} - place holder for Y value " +
    "of the data point";            
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label5.Location = new System.Drawing.Point(23, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "X value format";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(130, 188);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 27);
            this.textBox2.TabIndex = 19;
            this.textBox2.Text = "MMM, yyyy";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(121, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "{1} : {2}";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(27, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Text Format";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox1.Location = new System.Drawing.Point(27, 50);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 24);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Visible";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Trackball Settings";
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = DockStyle.Fill;
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254))))), System.Drawing.Color.White);
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(194)))), ((int)(((byte)(229))))), System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(250))))));
            this.chartControl1.DataSourceName = "";
            this.chartControl1.DataSourceType = "";
            this.chartControl1.ElementsSpacing = 1;
            this.chartControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.Legend.Border.ForeColor = System.Drawing.Color.Transparent;
            this.chartControl1.Legend.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.Legend.ItemsSize = new System.Drawing.Size(15, 15);
            this.chartControl1.Legend.Location = new System.Drawing.Point(37, 48);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top;
            this.chartControl1.Legend.ShowSymbol = true;
            this.chartControl1.Legend.Spacing = 3;
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.Silver;
            this.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.DarkGray;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.Silver;
            this.chartControl1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.DarkGray;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.Rotation = 90F;
            this.chartControl1.Size = new System.Drawing.Size(700, 569);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "EssentialChart";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "EssentialChart";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ToolBar.EnableDefaultItems = false;
            this.chartControl1.ToolBar.Items.Add(chartToolBarSaveItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarCopyItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPrintItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPrintPreviewItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarSplitter2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPaletteItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarStyleItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarTypeItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarSeries3DItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarShowLegendItem2);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 581);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.MinimumSize = new System.Drawing.Size(705, 463);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trackball";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.comboBox1.DataSource = Enum.GetNames(typeof(TrackballTooltipDisplayMode));
            this.comboBox1.SelectedIndex = 1;
            InitializeChartData();
                        
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            
            this.checkBox1.Checked = true;
            this.chartControl1.Legend.ShowSymbol = false;
            this.chartControl1.Legend.VisibleCheckBox = true;
            this.chartControl1.PrimaryXAxis.RoundingPlaces = 2;
            Color[] colors = new Color[] { 
                Color.FromArgb(200, 9, 116, 210), 
                Color.FromArgb(200, 199, 23, 33), 
                Color.FromArgb(200, 36, 119, 51), 
                Color.FromArgb(0xFF, 0xA2, 0xC1, 0x39), 
                Color.FromArgb(0xFF, 0xD8, 0x00, 0x73) 
            };
            for (int i = 0; i < this.chartControl1.Series.Count; i++ )
            {
                ChartSeries series = this.chartControl1.Series[i];
                series.Style.Symbol.Shape = ChartSymbolShape.Circle;
                series.Style.Symbol.Color = colors[i];
                series.Style.Symbol.Border.Color = Color.White;
                series.Style.Symbol.Border.Width = 2;
                series.Style.Symbol.Size = new Size(10, 10);
            }
        }
        
        #endregion

        #region Helper Methods

        #region InitializeChartData
        protected void InitializeChartData()
        {
            DateTime[] x = new DateTime[] { 
                                             new DateTime(2000, 2, 11), new DateTime(2000, 9, 14),
                                             new DateTime(2001, 2, 11), new DateTime(2001, 9, 16),
                                             new DateTime(2002, 2, 7), new DateTime(2002, 9, 7),
                                             new DateTime(2003, 2, 11), new DateTime(2003, 9, 14),
                                             new DateTime(2004, 2, 6), new DateTime(2004, 9, 6),
                                             new DateTime(2005, 2, 11), new DateTime(2005, 9, 11),
                                             new DateTime(2006, 2, 11)
                                          };
            ChartSeries series1 = new ChartSeries("John", ChartSeriesType.Line);
            series1.Text = series1.Name;            
            double[] points1 = { 30, 35, 40, 36, 28, 33, 39, 38, 34, 46, 54, 65, 39 };

            ChartSeries series2 = new ChartSeries("Andrew", ChartSeriesType.Line);
            series2.Text = series2.Name;
            double[] points2 = { 54, 45, 43, 50, 54, 56, 60, 63, 69, 70, 72, 75, 75 };

            ChartSeries series3 = new ChartSeries("Thomas", ChartSeriesType.Line);
            series3.Text = series3.Name;            
            double[] points3 = { 76, 70, 63, 72, 77, 79, 72, 68, 78, 65, 81, 80, 94 };

            ChartSeries series4 = new ChartSeries("Hendry", ChartSeriesType.Line);
            series4.Text = series4.Name;
            double[] points4 = { 98, 90, 83, 90, 86, 86, 106, 99, 110, 102, 90, 85, 110 };

            ChartSeries series5 = new ChartSeries("William", ChartSeriesType.Line);
            series5.Text = series5.Name;
            double[] points5 = { 116, 110, 100, 102, 97, 89, 88, 90, 88, 75, 63, 70, 55 };

            for (int i = 0; i < x.Length; i++)
            {
                series1.Points.Add(x[i], points1[i]);
                series2.Points.Add(x[i], points2[i]);
                series3.Points.Add(x[i], points3[i]);
                series4.Points.Add(x[i], points4[i]);
                series5.Points.Add(x[i], points5[i]);
            }

            this.chartControl1.Series.Add(series1);
            this.chartControl1.Series.Add(series2);
            this.chartControl1.Series.Add(series3);
            this.chartControl1.Series.Add(series4);
            this.chartControl1.Series.Add(series5);
            
        }

        #endregion
                
        #endregion

        #region Events
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.Trackball.Visible = this.checkBox1.Checked;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.chartControl1.Trackball.Tooltip.TextFormat = this.textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.chartControl1.Trackball.Tooltip.XValueFormat = this.textBox2.Text;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.Trackball.Tooltip.CornerRadius = (int)this.numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (this.chartControl1.Trackball.Tooltip.Border == null)
                this.chartControl1.Trackball.Tooltip.Border = new ChartLineInfo();
            this.chartControl1.Trackball.Tooltip.Border.Width = (int)this.numericUpDown2.Value;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.Trackball.DisplayMode = (TrackballTooltipDisplayMode)Enum.Parse(typeof(TrackballTooltipDisplayMode), this.comboBox1.SelectedItem.ToString());
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.chartControl1.Trackball.Tooltip.YValueFormat = this.textBox3.Text;
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
