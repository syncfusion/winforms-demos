#region Copyright Syncfusion Inc. 2001 - 2005
//
//  Copyright Syncfusion Inc. 2001 - 2005. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using System.Drawing.Drawing2D;



namespace Syncfusion.Windows.Forms.Chart.Samples
{
    public class Form1 : MetroForm
    {

        #region Private Members

        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Panel panel1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
       private CheckBox checkBox2;
       private CheckBox checkBox1;
        private CheckBox checkBox3;
       


        #endregion

        #region Constructor, Main And Dispose
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            BorderColor = Color.FromArgb(0xFF, 0xCD, 0xCD, 0xCD);
            BorderThickness = 3;
            CaptionBarHeight = 75;
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(1, 1, 1, 1);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(237)))), ((int)(((byte)(200))))), System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(227)))), ((int)(((byte)(167))))));
            this.chartControl1.DataSourceName = "";
            this.chartControl1.ElementsSpacing = 0;
            this.chartControl1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.Legend.Border.ForeColor = System.Drawing.Color.Transparent;
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.Legend.ItemsSize = new System.Drawing.Size(15, 15);
            this.chartControl1.Legend.Location = new System.Drawing.Point(32, 36);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top;
            this.chartControl1.Legend.Spacing = 3;
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.Size = new System.Drawing.Size(700, 580);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "chartControl1";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(46, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chart Type";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox1.Items.AddRange(new object[] {
            "Polar",
            "Radar"});
            this.comboBox1.Location = new System.Drawing.Point(49, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(48, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Radar Chart Axis Style";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox2.Location = new System.Drawing.Point(49, 318);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(178, 28);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(49, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chart Draw Type";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox3.Location = new System.Drawing.Point(50, 132);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(178, 28);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(698, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 584);
            this.panel1.TabIndex = 10;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox3.Location = new System.Drawing.Point(50, 246);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(140, 24);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = "Enable Line Style";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox2.Location = new System.Drawing.Point(50, 211);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(128, 24);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Y-Axis Inversed";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox1.Location = new System.Drawing.Point(50, 176);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(129, 24);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "X-Axis Inversed";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 584);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(624, 428);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polar and Radar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {

            FillControlPanel();
            this.comboBox2.Enabled = false;
            InitializeChartData();
            this.comboBox3.SelectedIndex = 0;
            this.comboBox1.SelectedIndex = 0;
            this.comboBox2.SelectedIndex = 0;
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }

        #endregion

        #region Helper Methods

        #region InitializeChartData for Polar Chart
        /// <summary>
        /// Initializes the ChartControl's data and sets the Chart type
        /// </summary>
        protected void InitializeChartData()
        {
            ChartSeries series1 = new ChartSeries(" System 1", ChartSeriesType.Polar);
            series1.Text = series1.Name;
            for (int i = 0; i <= 710; i++)
            {
                double x = Math.Abs(Math.Sin(3 * i));
                series1.Points.Add(i, x);
            }
            this.chartControl1.Series.Add(series1);

            ChartSeries series2 = new ChartSeries(" System 1", ChartSeriesType.Polar);
            series2.Text = series2.Name;
            for (int i = 0; i < 355; i++)
            {
                double x = Math.Abs(Math.Sin(3 * i));
                series2.Points.Add(i, x);
            }
            this.chartControl1.Series.Add(series2);

            this.chartControl1.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryYAxis.Range = new MinMaxInfo(0, 1.5, 0.5);

            this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryXAxis.Range = new MinMaxInfo(0, 360, 45);
            this.chartControl1.Text = "ABS(Sin(3φ))";
            this.chartControl1.Series[0].Style.Border.Color = Color.FromArgb(253, 171, 0);
            this.chartControl1.Series[1].Style.Border.Color = Color.FromArgb(199, 23, 33);
            this.chartControl1.ChartFormatAxisLabel -= new ChartFormatAxisLabelEventHandler(OnChartControl1_ChartFormatAxisLabel);
            this.chartControl1.PrimaryXAxis.Inversed = this.checkBox1.Checked;
            this.chartControl1.PrimaryYAxis.Inversed = this.checkBox2.Checked;
            this.chartControl1.PrimaryXAxis.Pens = null;
            this.chartControl1.PrimaryYAxis.Pens = null;
            this.chartControl1.PrimaryXAxis.LineType.Pen.Color = Color.DarkGray;
            this.chartControl1.PrimaryXAxis.LineType.Pen.Width = 1f;
            this.chartControl1.PrimaryXAxis.LineType.Pen.DashStyle = DashStyle.Solid;
            this.chartControl1.PrimaryYAxis.LineType.Pen.Color = Color.DarkGray;
            this.chartControl1.PrimaryYAxis.LineType.Pen.Width = 1f;
            this.chartControl1.PrimaryYAxis.LineType.Pen.DashStyle = DashStyle.Solid;
        }
        #endregion

        #region InitializeChartData for Radar Chart
        string[] labels = new string[]{ "Sales", 
			"Administration", 
			"Information \nTechnology", 
			"Customer\n Support", 
			"Development", 
			"Marketing" };
        protected void InitializeChartData1()
        {
            ChartSeries series1 = new ChartSeries(" Allocated Budget", ChartSeriesType.Radar);
            series1.Text = series1.Name;
            series1.Points.Add(0, 40);
            series1.Points.Add(1, 20);
            series1.Points.Add(2, 33);
            series1.Points.Add(3, 25);
            series1.Points.Add(4, 60);
            series1.Points.Add(5, 20);
            series1.Style.Border.Color = Color.FromArgb(0, 128, 192);

            ChartSeries series2 = new ChartSeries("Actual Spending", ChartSeriesType.Radar);
            series2.Text = series2.Name;
            series2.Points.Add(0, 50);
            series2.Points.Add(1, 22);
            series2.Points.Add(2, 25);
            series2.Points.Add(3, 20);
            series2.Points.Add(4, 20);
            series2.Points.Add(5, 45);

            series2.Style.Border.Color = Color.FromArgb(209, 0, 0);
            this.chartControl1.Series.Add(series1);
            this.chartControl1.Series.Add(series2);

            this.chartControl1.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryYAxis.Range = new MinMaxInfo(0, 60, 10);

            this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryXAxis.Range = new MinMaxInfo(0, 6, 1);

            this.chartControl1.Text = "Organization Budget";

            this.chartControl1.ChartFormatAxisLabel += new ChartFormatAxisLabelEventHandler(OnChartControl1_ChartFormatAxisLabel);
            this.chartControl1.PrimaryXAxis.Inversed = this.checkBox1.Checked;
            this.chartControl1.PrimaryYAxis.Inversed = this.checkBox2.Checked;
        }

        void OnChartControl1_ChartFormatAxisLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            if (e.AxisOrientation == ChartOrientation.Vertical)
            {
                //Applying Formatted Y Axis label values.
                e.Label = string.Format("${0}", e.Value);
            }
            else
            {
                int index = (int)e.Value;

                if (index >= 0 && index < labels.Length)
                {
                    //Applying custom label text for X Axis
                    e.Label = labels[index];
                }
                else
                {
                    e.Label = "";
                }
            }

            e.Handled = true;
        }

        #endregion

        #region FillControlPanel
        protected void FillControlPanel()
        {
            foreach (string radardrawtype in Enum.GetNames(typeof(Syncfusion.Windows.Forms.Chart.ChartRadarDrawType)))
            {
                this.comboBox3.Items.Add(radardrawtype);
            }

            foreach (string radaraxisstyle in Enum.GetNames(typeof(Syncfusion.Windows.Forms.Chart.ChartRadarAxisStyle)))
                this.comboBox2.Items.Add(radaraxisstyle);
        }

        #endregion

        #endregion

        #region Events
        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Radar")
            {
                this.chartControl1.Series.Clear();
                InitializeChartData1();
                this.comboBox2.Enabled = true;
                SelectDrawMode();
            }
            else
            {
                this.chartControl1.Series.Clear();
                InitializeChartData();
                this.comboBox2.Enabled = false;
                SelectDrawMode();
            }
        }
        private void SelectDrawMode()
        {
            if (comboBox3.SelectedIndex == 2)
            {
                this.chartControl1.Series[0].Style.Symbol.Size = new Size(5, 5);
                this.chartControl1.Series[1].Style.Symbol.Size = new Size(5, 5);
            }
            this.chartControl1.Series[0].ConfigItems.RadarItem.Type = (ChartRadarDrawType)Enum.Parse(typeof(ChartRadarDrawType), this.comboBox3.SelectedItem.ToString(), true);
            this.chartControl1.Series[1].ConfigItems.RadarItem.Type = (ChartRadarDrawType)Enum.Parse(typeof(ChartRadarDrawType), this.comboBox3.SelectedItem.ToString(), true);
            this.chartControl1.Redraw(true);
        }
        private void comboBox3_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboBox3.SelectedIndex == 2)
            {
                this.chartControl1.Series[0].Style.Symbol.Size = new Size(5, 5);
                this.chartControl1.Series[1].Style.Symbol.Size = new Size(5, 5);
            }
            this.chartControl1.Series[0].ConfigItems.RadarItem.Type = (ChartRadarDrawType)Enum.Parse(typeof(ChartRadarDrawType), this.comboBox3.SelectedItem.ToString(), true);
            this.chartControl1.Series[1].ConfigItems.RadarItem.Type = (ChartRadarDrawType)Enum.Parse(typeof(ChartRadarDrawType), this.comboBox3.SelectedItem.ToString(), true);
            this.chartControl1.Redraw(true);
        }

        private void comboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.RadarStyle = (ChartRadarAxisStyle)Enum.Parse(typeof(ChartRadarAxisStyle), this.comboBox2.SelectedItem.ToString(), true);
            this.chartControl1.Redraw(true);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryXAxis.Inversed = this.checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryYAxis.Inversed = this.checkBox2.Checked;
        }
        #endregion

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                Pen[] mypens = new Pen[3];
                mypens[0] = new Pen(Color.DarkOrange, 2f);
                mypens[1] = new Pen(Color.DarkGoldenrod, 2f);
                mypens[2] = new Pen(Color.Maroon, 2f);

                mypens[0].DashStyle = DashStyle.DashDot;
                mypens[1].DashStyle = DashStyle.Dash;

                this.chartControl1.PrimaryXAxis.Pens = mypens;
                this.chartControl1.PrimaryYAxis.Pens = mypens;
                this.chartControl1.PrimaryXAxis.LineType.Pen.Color = Color.SkyBlue;
                this.chartControl1.PrimaryXAxis.LineType.Pen.Width = 2f;
                this.chartControl1.PrimaryXAxis.LineType.Pen.DashStyle = DashStyle.DashDotDot;

                this.chartControl1.PrimaryYAxis.LineType.Pen.Color = Color.Coral;
                this.chartControl1.PrimaryYAxis.LineType.Pen.Width = 2f;
                this.chartControl1.PrimaryYAxis.LineType.Pen.DashStyle = DashStyle.Solid;
                this.chartControl1.Redraw(true); 
            }
            else
            {
                this.chartControl1.PrimaryXAxis.Pens = null;
                this.chartControl1.PrimaryYAxis.Pens = null;               

                this.chartControl1.PrimaryXAxis.LineType.Pen.Color = Color.DarkGray;
                this.chartControl1.PrimaryXAxis.LineType.Pen.Width = 1f;
                this.chartControl1.PrimaryXAxis.LineType.Pen.DashStyle = DashStyle.Solid;
                this.chartControl1.PrimaryYAxis.LineType.Pen.Color = Color.DarkGray;
                this.chartControl1.PrimaryYAxis.LineType.Pen.Width = 1f;
                this.chartControl1.PrimaryYAxis.LineType.Pen.DashStyle = DashStyle.Solid;
            }
        }
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
