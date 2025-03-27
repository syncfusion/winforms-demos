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

namespace FinancialChart
{
	public class Form1 : MetroForm
	{
        #region Private Members

        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox3;
        private Label label4;
        private Panel panel3;
        private Label label9;
        private Panel panel1;
        private Label label3;
        private Label label5;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        #endregion 
        		
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.BorderAppearance.BaseColor = System.Drawing.Color.Transparent;
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.BorderColor = System.Drawing.Color.Transparent;
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.chartControl1.DataSourceName = "";
            this.chartControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chartControl1.HidePartialLabels = true;
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(586, 81);
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Metro;
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.LightGray;
            this.chartControl1.PrimaryXAxis.HidePartialLabels = true;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.ForeColor = System.Drawing.Color.Black;
            this.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.LightGray;
            this.chartControl1.PrimaryYAxis.HidePartialLabels = true;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.chartControl1.Size = new System.Drawing.Size(698, 549);
            this.chartControl1.Skins = Syncfusion.Windows.Forms.Chart.Skins.Metro;
            this.chartControl1.Style3D = true;
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox2.Location = new System.Drawing.Point(8, 115);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(95, 25);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "NASDAQ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(7, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Select series";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox1.Location = new System.Drawing.Point(8, 85);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 25);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "NYSE";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox2.Location = new System.Drawing.Point(8, 181);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(178, 28);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(8, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Open-Close Draw Mode";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox1.Items.AddRange(new object[] {
            "Candle Chart",
            "HiLo Chart",
            "HiLo Open Close Chart",
            "Kagi Chart",
            "Point And Figure Chart",
            "Renko Chart",
            "Three Line Break Chart"});
            this.comboBox1.Location = new System.Drawing.Point(31, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Financial Chart";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox3.Location = new System.Drawing.Point(31, 145);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(83, 24);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "3D Style";
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Dock = DockStyle.Right;
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.checkBox3);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Location = new System.Drawing.Point(698, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 635);
            this.panel3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(-26, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(2, 553);
            this.label5.TabIndex = 127;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(26, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 224);
            this.panel1.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label9.Location = new System.Drawing.Point(1, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "HiLo Open Close";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(28, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chart";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 634);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(970, 670);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financial Series";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.chartControl1.Series.Clear();
            this.comboBox1.SelectedIndex = 0;
            FillControlPanel();
            this.comboBox2.SelectedIndex = 0;
            InitializeControlSettings();
           
        }
        #endregion 

        #region Helper Methods

        #region InitializeControlSettings
        private void InitializeControlSettings()
        {
            this.chartControl1.Legend.Visible = false;
            this.chartControl1.BorderAppearance.SkinStyle = ChartBorderSkinStyle.None;

          
        }

        #endregion
 

        #region InitializeChartData
        protected void InitializeChartData()
        {
            Random r = new Random();

            string select1 = this.comboBox1.SelectedItem.ToString();
            this.Size = new Size(478, 410);
            this.panel1.Visible = false;
            switch (select1)
            {
                case "Candle Chart":                 

                    ChartSeries series1 = new ChartSeries(" Series 1", ChartSeriesType.Candle);
                    series1.Text = series1.Name;

                    DateTime date1 = new DateTime(2006, 2, 12);
                    series1.Points.Add(date1.AddDays(1), 470, 200, 270, 400);
                    series1.Points.Add(date1.AddDays(2), 520, 234, 321, 458);
                    series1.Points.Add(date1.AddDays(3), 482, 193, 352, 302);
                    series1.Points.Add(date1.AddDays(4), 457, 230, 300, 410);
                    series1.Points.Add(date1.AddDays(5), 421, 150, 357, 200);
                    series1.Points.Add(date1.AddDays(6), 475, 200, 300, 385);
                  
                    this.chartControl1.Series.Add(series1);
                    this.chartControl1.Text = "Stock Price Summary";
                    this.chartControl1.PrimaryYAxis.Title = "Price $";
                    this.chartControl1.PrimaryXAxis.Title = "Week Day";
                    this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime;
                    this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
                    this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(date1, date1.AddDays(7), 2, ChartDateTimeIntervalType.Days);
                    this.chartControl1.PrimaryXAxis.DateTimeFormat = "MMM/dd";
                    this.chartControl1.Text = "Candle Chart";
         
                break;
                case "HiLo Chart":
                   
                    ChartSeries series2 = new ChartSeries("NYSE", ChartSeriesType.HiLo);
                    series2.Text = series2.Name;
                    DateTime start = new DateTime(2006, 2, 20);

                    series2.Points.Add(start.AddDays(0), 456, 214, 364, 386);
                    series2.Points.Add(start.AddDays(1), 491, 234, 321, 378);
                    series2.Points.Add(start.AddDays(2), 482, 193, 302, 352);
                    series2.Points.Add(start.AddDays(3), 437, 243, 354, 391);
                    series2.Points.Add(start.AddDays(4), 421, 223, 317, 367);
                    series2.Points.Add(start.AddDays(5), 434, 263, 339, 385);
                    series2.Points.Add(start.AddDays(6), 425, 245, 365, 396);
                    series2.Points.Add(start.AddDays(7), 457, 234, 385, 398);
                    series2.Points.Add(start.AddDays(8), 482, 267, 316, 389);
                    series2.Points.Add(start.AddDays(9), 496, 285, 374, 399);

                    ChartSeries series3 = new ChartSeries(" NASDAQ", ChartSeriesType.HiLo);
                    series3.Text = series3.Name;
                   
                    series3.Points.Add(start.AddDays(0), 437, 263, 373, 412);
                    series3.Points.Add(start.AddDays(1), 491, 243, 383, 391);
                    series3.Points.Add(start.AddDays(2), 480, 290, 313, 421);
                    series3.Points.Add(start.AddDays(3), 466, 215, 323, 452);
                    series3.Points.Add(start.AddDays(4), 486, 243, 328, 415);
                    series3.Points.Add(start.AddDays(5), 461, 263, 356, 371);
                    series3.Points.Add(start.AddDays(6), 489, 273, 316, 399);
                    series3.Points.Add(start.AddDays(7), 484, 285, 384, 415);
                    series3.Points.Add(start.AddDays(8), 461, 266, 396, 423);
                    series3.Points.Add(start.AddDays(9), 498, 278, 328, 433);

                    this.chartControl1.Series.Add(series2);
                    this.chartControl1.Series.Add(series3);
                    this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
                    this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(start.AddDays(-1), start.AddDays(10), 2, ChartDateTimeIntervalType.Days);
                    
                    this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime;
                    this.chartControl1.PrimaryXAxis.DateTimeFormat = "MMM/dd";
                    this.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.Rotate;
                    this.chartControl1.PrimaryYAxis.Title = "Price ($)";
                    this.chartControl1.Text = "HiLo Chart";
               
                 break;
                case "HiLo Open Close Chart":

                    this.Size = new Size(478, 515);
                    this.panel1.Visible = true;
                    ChartSeries series4 = new ChartSeries("NYSE", ChartSeriesType.HiLoOpenClose);
                    series4.Text = series4.Name;
                    DateTime date = new DateTime(2006, 2, 13);

                    series4.Points.Add(date, 456, 214, 364, 386);
                    series4.Points.Add(date.AddDays(1), 491, 234, 321, 378);
                    series4.Points.Add(date.AddDays(2), 482, 193, 302, 352);
                    series4.Points.Add(date.AddDays(3), 437, 243, 354, 391);
                    series4.Points.Add(date.AddDays(4), 421, 223, 317, 367);
                    series4.Points.Add(date.AddDays(5), 434, 263, 339, 385);

                    ChartSeries series5 = new ChartSeries("NASDAQ", ChartSeriesType.HiLoOpenClose);
                    series5.Text = series5.Name;

                    series5.Points.Add(date, 437, 263, 373, 412);
                    series5.Points.Add(date.AddDays(1), 491, 243, 383, 391);
                    series5.Points.Add(date.AddDays(2), 480, 290, 313, 421);
                    series5.Points.Add(date.AddDays(3), 466, 215, 323, 452);
                    series5.Points.Add(date.AddDays(4), 486, 243, 328, 415);
                    series5.Points.Add(date.AddDays(5), 461, 263, 356, 371);

                    this.chartControl1.Series.Add(series4);
                    this.chartControl1.Series.Add(series5);

                    this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime;
                    this.chartControl1.PrimaryXAxis.DateTimeFormat =  "MMM/dd";
                    this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
                    this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(date.AddDays(-1), date.AddDays(6), 2, ChartDateTimeIntervalType.Days);
                    this.chartControl1.PrimaryXAxis.Title = "Week Days";
                    this.chartControl1.PrimaryYAxis.Title = "Price $";
                    this.chartControl1.Text = "HiLo Open Close Chart";
                   
                break;
                case "Kagi Chart":
                   
                    double[] points2 = { 25.25, 27.75, 29.0, 28.275, 27.75, 27.75, 27.275, 26.25, 25.75, 25.25, 26.25, 25.25, 24.5, 25.625, 25.5, 26.625, 26.275, 26.25, 26.875, 27.25, 26.875, 26.5, 27.125, 26.275, 25.875, 26.625, 27.125, 26.25, 27.0, 27.25, 27.5, 28.5, 29.5, 28.875, 28.5, 29.0, 28.5, 28.5, 29.0, 29.0, 40.0, 29.875, 29.875, 28.875, 28.5, 28.25, 28.875, 29.275, 29.275, 29.75, 29.5, 29.275, 28.5, 27.75, 27.625, 27.5, 26.5, 25.0, 26.625, 26.0, 25.875, 25.0, 25.25, 25.125, 25.05 };
                    DateTime current = new DateTime(2004, 01, 1);
                    int numPoints = points2.Length;

                    ChartSeries series = new ChartSeries("Series 1");
                    for (int j = 0; j < numPoints; j++)
                    {
                        series.Points.Add(current.AddDays(j * 5), points2[j]);
                    }

                    series.Type = ChartSeriesType.Kagi;
                    series.Text = series.Name;
                    series.ReversalAmount = 1.0;

                    series.Style.Border.Width = 1;
                    this.chartControl1.Series.Add(series);

                    this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
                    this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(current, current.AddMonths(13), 3, ChartDateTimeIntervalType.Months);
                    this.chartControl1.PrimaryXAxis.DateTimeFormat = "MMM/dd";
                    this.chartControl1.Text = "Kagi Chart";
                  break;
                case "Point And Figure Chart":
                     double[] points = {   35.250,37.750,39.000,38.275,37.750,37.750,37.275,36.250,35.750,35.250,36.250,35.250,34.500,
										  35.625,35.500,36.625,36.275,36.250,36.875,37.250,36.875,36.500,37.125,36.275,35.875,36.625,
										  27.125,26.250,27.000,27.250,37.500,38.500,39.500,38.875,38.500,39.000,38.500,28.500,29.000,
										  29.000,40.000,29.875,29.875,28.875,28.500,28.250,28.875,29.275,29.275,29.750,29.500,29.275,
										  28.500,27.750,27.625,27.500,26.500,25.000,26.625,26.000,25.875,25.000,25.250,25.125,25.050};

                    double[] points1 = {   25,27.500,28.750,28.025,27.500,27.500,27.025,26.250,35.750,35.250,36.250,35.250,34.500,
										   25.625,25.500,26.625,26.275,26.250,26.875,27.250,26.875,26.500,27.125,26.275,25.875,26.625,
										   27.125,26.250,27.000,27.250,27.500,38.500,39.500,38.875,38.500,39.000,28.500,28.500,29.000,
										   29.000,40.000,29.875,29.875,28.875,28.500,28.250,28.875,29.275,29.275,29.750,29.500,29.275,
										   28.500,27.750,27.625,27.500,26.500,25.000,26.625,26.000,25.875,25.000,25.250,25.125,25.050};


                    DateTime current1 = new DateTime(2004, 01, 1);
                    int numPoints1 = points.Length;

                    ChartSeries series7 = new ChartSeries("Series 1");
                    for (int j = 0; j < numPoints1; j++)
                    {
                        series7.Points.Add(current1.AddDays(j), new double[] { points[j], points1[j] });
                    }

                    series7.Type = ChartSeriesType.PointAndFigure;
                    series7.Text = series7.Name;
                    series7.ReversalAmount = 0.0;
                  
                    
                    this.chartControl1.Series.Add(series7);

                    this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
                    this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(current1, current1.AddDays(30), 10, ChartDateTimeIntervalType.Days);
                    this.chartControl1.PrimaryXAxis.DateTimeFormat = "MMM/dd";
                    this.chartControl1.Text = "Point And Figure Chart";
                 break;
               case "Renko Chart":         
                    double[] points5 = {   25.250,27.750,29.000,28.275,27.750,27.750,27.275,26.250,25.750,25.250,26.250,25.250,24.500,
										  25.625,25.500,26.625,26.275,26.250,26.875,27.250,26.875,26.500,27.125,26.275,25.875,26.625,
										  27.125,26.250,27.000,27.250,27.500,28.500,29.500,28.875,28.500,29.000,28.500,28.500,29.000,
										  29.000,40.000,29.875,29.875,28.875,28.500,28.250,28.875,29.275,29.275,29.750,29.500,29.275,
										  28.500,27.750,27.625,27.500,26.500,25.000,26.625,26.000,25.875,25.000,25.250,25.125,25.050};

                    DateTime date5 = new DateTime(2004, 1, 1);

                    ChartSeries series11 = new ChartSeries("Series " + 0);

                    for (int day = 0; day < points5.Length; day++)
                    {
                        series11.Points.Add(date5.AddDays(day), points5[day]);
                    }

                    series11.Type = ChartSeriesType.Renko;
                    series11.ReversalAmount = 1;
                    this.chartControl1.Series.Add(series11);

                    this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime;
                    this.chartControl1.PrimaryXAxis.DateTimeFormat = "MMM/dd";
                    this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(date5, date5.AddDays(60), 10, ChartDateTimeIntervalType.Days);
                    this.chartControl1.Text = "Renko Chart";
                    this.chartControl1.PrimaryYAxis.Format = "$ #";
                    break;
                case "Three Line Break Chart":
                  
                    double[] points6 = {   25.250,27.750,29.000,28.275,27.750,27.750,27.275,26.250,25.750,25.250,26.250,25.250,24.500,
										  25.625,25.500,26.625,26.275,26.250,26.875,27.250,26.875,26.500,27.125,26.275,25.875,26.625,
										  27.125,26.250,27.000,27.250,27.500,28.500,29.500,28.875,28.500,29.000,28.500,28.500,29.000,
										  29.000,40.000,29.875,29.875,28.875,28.500,28.250,28.875,29.275,29.275,29.750,29.500,29.275,
										  28.500,27.750,27.625,27.500,26.500,25.000,26.625,26.000,25.875,25.000,25.250,25.125,25.050};

                    DateTime dates = DateTime.Today.AddDays(-points6.Length);

                    ChartSeries series8 = new ChartSeries("Series " + 0);

                    for (int day = 0; day < points6.Length; day++)
                    {
                        series8.Points.Add(dates.AddDays(day), points6[day]);
                    }

                    series8.Type = ChartSeriesType.ThreeLineBreak;
                    series8.ReversalAmount = 3.0;
                  
                    this.chartControl1.Text = "Three Line Break Chart";
                    this.chartControl1.PrimaryYAxis.Format = "$ #";
                    this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(dates, dates.AddDays(60), 10, ChartDateTimeIntervalType.Days);
                    this.chartControl1.PrimaryXAxis.DateTimeFormat = "MMM/dd";
                    this.chartControl1.Series.Add(series8);
                    break;
                default:
                    MessageBox.Show("Select any ONE Chart from the ListBox", "Error", MessageBoxButtons.OK);
                    break;
            }           
        }

        #endregion

        #region FillControlPanel
        protected void FillControlPanel()
        {
            foreach (string mode in Enum.GetNames(typeof(Syncfusion.Windows.Forms.Chart.ChartOpenCloseDrawMode)))
                this.comboBox2.Items.Add(mode);

        }

        #endregion

       
        #endregion 
        
        #region Events
        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Series.Clear();
            InitializeChartData();
        }

        private void comboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.checkBox1.Checked && this.checkBox2.Checked)
            {
                this.chartControl1.Series[0].ConfigItems.HiLoOpenCloseItem.DrawMode = (ChartOpenCloseDrawMode)Enum.Parse(typeof(ChartOpenCloseDrawMode), this.comboBox2.SelectedItem.ToString(), true);
                this.chartControl1.Series[1].ConfigItems.HiLoOpenCloseItem.DrawMode = (ChartOpenCloseDrawMode)Enum.Parse(typeof(ChartOpenCloseDrawMode), this.comboBox2.SelectedItem.ToString(), true);
            }
            else if (this.checkBox1.Checked)
                this.chartControl1.Series[0].ConfigItems.HiLoOpenCloseItem.DrawMode = (ChartOpenCloseDrawMode)Enum.Parse(typeof(ChartOpenCloseDrawMode), this.comboBox2.SelectedItem.ToString(), true);
            else if (this.checkBox2.Checked)
                this.chartControl1.Series[1].ConfigItems.HiLoOpenCloseItem.DrawMode = (ChartOpenCloseDrawMode)Enum.Parse(typeof(ChartOpenCloseDrawMode), this.comboBox2.SelectedItem.ToString(), true);

            this.chartControl1.Refresh();
        }

        private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.checkBox3.Checked)
            {
                this.chartControl1.Series3D = true;
            }
            else
            {
                this.chartControl1.Series3D = false;
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
