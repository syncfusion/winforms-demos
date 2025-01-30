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


namespace LineChart2002
{
    public class Form1 : MetroForm
    {
        #region Private Members
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBoxChartType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;

        int count = 0;
        private Label label22;
        private ComboBox comboBox2;
        private Label label4;
        private CheckBox checkBox2;

        #endregion
        private ImageList imageList1;
        private RadioButton radioButton3;
        private IContainer components;

        #region Constructor, Main And Dispose
        public Form1()
        {
            BorderColor = Color.FromArgb(0xFF, 0xCD, 0xCD, 0xCD);
            BorderThickness = 3;
            CaptionBarHeight = CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(75.0f);
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
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label22 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBoxChartType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254))))), System.Drawing.Color.White);
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(5, 15, 15, 5);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(194)))), ((int)(((byte)(229))))), System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(250))))));
            this.chartControl1.DataSourceName = "";
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
            this.chartControl1.Legend.Location = new System.Drawing.Point(32, 53);
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
            // 
            // panel1
            // 
            this.panel1.Dock = DockStyle.Right;
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.comboBoxChartType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(700, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 585);
            this.panel1.TabIndex = 3;
            // 
            // radioButton3
            // 
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.radioButton3.Location = new System.Drawing.Point(36, 198);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(112, 24);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.Text = "France";
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox2.Location = new System.Drawing.Point(36, 484);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(96, 24);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "Enable 3D";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox2.Location = new System.Drawing.Point(36, 270);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(180, 28);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(33, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Legend Representation";
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.radioButton1.Location = new System.Drawing.Point(36, 131);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 28);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Italy";
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radiobutton1_SeriesType_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.radioButton2.Location = new System.Drawing.Point(36, 163);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(140, 28);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Spain";
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radiobutton2_SeriesType_CheckedChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label22.Location = new System.Drawing.Point(32, 99);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(87, 20);
            this.label22.TabIndex = 8;
            this.label22.Text = "Chart Series";
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox1.Location = new System.Drawing.Point(36, 449);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(207, 29);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Points in different Color";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBoxChartType
            // 
            this.comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChartType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxChartType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChartType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBoxChartType.Location = new System.Drawing.Point(35, 60);
            this.comboBoxChartType.Name = "comboBoxChartType";
            this.comboBoxChartType.Size = new System.Drawing.Size(184, 28);
            this.comboBoxChartType.TabIndex = 6;
            this.comboBoxChartType.SelectedIndexChanged += new System.EventHandler(this.comboBoxChartType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(36, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Width";
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(36, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dash Style";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox1.Location = new System.Drawing.Point(36, 342);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.White;
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown1.Location = new System.Drawing.Point(36, 414);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(178, 27);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(35, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chart Type";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "server_from_client.png");
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 581);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(705, 463);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Line";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.comboBoxChartType.Items.Add(ChartSeriesType.Line);
            this.comboBoxChartType.Items.Add(ChartSeriesType.Spline);
            this.comboBoxChartType.Items.Add(ChartSeriesType.StepLine);
            this.comboBoxChartType.Items.Add(ChartSeriesType.RotatedSpline);
            this.comboBoxChartType.SelectedIndex = 0;
            FillControlPanel();
            this.comboBox1.SelectedIndex = 0;
            InitializeChartData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }

        #endregion

        #region Helper Methods

        #region InitializeChartData
        protected void InitializeChartData()
        {
            ChartSeries series1 = new ChartSeries("Italy");
            series1.Text = series1.Name;
            series1.Type = (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), this.comboBoxChartType.SelectedItem.ToString(), true);
            // 4, 3, 3, 3, 5, 4, 5, 6, 8, 9,10, 9, 12, 11, 5,

            double[] points1 =  {2, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1,2 };
            int i = 0;
            for (int j = 1985; j < 2003 && i < 16; j++, i++)
            {
                series1.Points.Add(j, points1[i]);
            }
            this.chartControl1.Series.Add(series1);

            ChartSeries series2 = new ChartSeries("Spain");
            series2.Text = series2.Name;
            series2.Type = (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), this.comboBoxChartType.SelectedItem.ToString(), true);
            //6,9,10,10,12,8,10,5,6,5,4,3,4,2,3,
            i = 0;
            double[] points2 = {8,5,4,4,3,3,3,3,4,5,4,3,2,3,2,1};

            for (int k = 1985; k < 2003 && i < 16; k++, i++)
            {
                series2.Points.Add(k, points2[i]);
            }
            this.chartControl1.Series.Add(series2);


            ChartSeries series3 = new ChartSeries("France");
            series3.Text = series3.Name;
            series3.Type = (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), this.comboBoxChartType.SelectedItem.ToString(), true);
            // 19,17,18,23,21,18,16,14,9,10,8,6,6,8,10,
            i = 0;
            double[] points3 = {11,15,14,10,11,6,4,6,2,2,2,2,3,4,4,4};

            for (int l = 1985; l < 2003 && i < 16; l++, i++)
            {
                series3.Points.Add(l, points3[i]);
            }

            this.chartControl1.Series.Add(series3);

            series2.Style.Images = new ChartImageCollection(this.imageList1.Images);
            series2.Style.ImageIndex = 0;
            series1.Style.Images = new ChartImageCollection(this.imageList1.Images);
            series1.Style.ImageIndex = 0;
            series3.Style.Images = new ChartImageCollection(this.imageList1.Images);
            series3.Style.ImageIndex = 0;
        }

        #endregion

        #region FillControlPanel
        protected void FillControlPanel()
        {
            foreach (string linetype in Enum.GetNames(typeof(System.Drawing.Drawing2D.DashStyle)))
                this.comboBox1.Items.Add(linetype);
            this.comboBox1.SelectedIndex = 0;

            foreach (string representationtype in Enum.GetNames(typeof(Syncfusion.Windows.Forms.Chart.ChartLegendRepresentationType)))
            {
                this.comboBox2.Items.Add(representationtype);
            }
            this.comboBox2.SelectedIndex = 5;
        }

        #endregion

        #endregion

        #region Events

        void series_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
        {
            //Specifying  different Colors for data points using Prepare style event
            ChartSeries series = sender as ChartSeries;
            if (series != null)
            {
                if (this.chartControl1.Series[0].Type.ToString() == "Line")
                {
                    if (args.Index == 0)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Red);
                    else if (args.Index == 1)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Green);
                    else if (args.Index == 2)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Blue);
                    else if (args.Index == 3)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Yellow);
                    else if (args.Index == 4)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Violet);
                    else if (args.Index == 5)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.BlanchedAlmond);
                    else if (args.Index == 6)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Brown);
                    else if (args.Index == 7)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Aqua);
                    else if (args.Index == 8)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Red);
                    else if (args.Index == 9)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Green);
                    else if (args.Index == 10)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Blue);
                    else if (args.Index == 11)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Yellow);
                    else if (args.Index == 12)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Violet);
                    else if (args.Index == 13)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.BlanchedAlmond);
                    else if (args.Index == 14)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Brown);
                    else if (args.Index == 15)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Aqua);
                    else if (args.Index == 16)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Red);
                    else if (args.Index == 17)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Green);
                    else if (args.Index == 18)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Blue);
                    else if (args.Index == 19)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Yellow);
                    else if (args.Index == 20)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Violet);
                    else if (args.Index == 21)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.BlanchedAlmond);
                    else if (args.Index == 22)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Brown);
                    else if (args.Index == 23)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Aqua);
                    else if (args.Index == 24)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Red);
                    else if (args.Index == 25)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Green);
                    else if (args.Index == 26)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Blue);
                    else if (args.Index == 27)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Yellow);
                    else if (args.Index == 28)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Violet);
                    else if (args.Index == 29)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.BlanchedAlmond);
                    else if (args.Index == 30)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Brown);
                    else if (args.Index == 31)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Red);

                }
            }
        }
        private void comboBoxChartType_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            for (int i = 0; i < this.chartControl1.Series.Count; i++)
            {
                this.chartControl1.Series[i].Type = (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), this.comboBoxChartType.SelectedItem.ToString(), true);

                this.chartControl1.Series[i].Style.Border.Width = (float)(this.numericUpDown1.Value);
            }

            if ((this.comboBoxChartType.Text == "Line"))
            {
                this.checkBox1.Visible = true;
                this.chartControl1.Redraw(true);
            }
            if ((this.comboBoxChartType.Text == "Spline"))
            {
                this.checkBox1.Visible = false;
                this.chartControl1.Redraw(true);
            }
            if ((this.comboBoxChartType.Text == "StepLine"))
            {
                this.checkBox1.Visible = false;
                this.chartControl1.Redraw(true);
            }
            if (this.comboBoxChartType.Text == "RotatedSpline")
            {
                this.checkBox1.Visible = false;
                this.chartControl1.Series[0].Type = ChartSeriesType.RotatedSpline;
                this.chartControl1.Series[1].Type = ChartSeriesType.RotatedSpline;
                count = count + 1;
                this.chartControl1.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
                this.chartControl1.PrimaryYAxis.Range = new MinMaxInfo(1985, 2000, 2);
                this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
                this.chartControl1.PrimaryXAxis.Range = new MinMaxInfo(0,16, 2);
                this.chartControl1.PrimaryXAxis.Title = "Rank";
                this.chartControl1.PrimaryYAxis.Title = "Year";

            }
            else
            {
                this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
                this.chartControl1.PrimaryXAxis.Range = new MinMaxInfo(1985, 2000, 1);               
                this.chartControl1.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
                this.chartControl1.PrimaryYAxis.Range = new MinMaxInfo(0, 16, 2);
                this.chartControl1.PrimaryXAxis.Title = "Year";
                this.chartControl1.PrimaryYAxis.Title = "Rank";
               
            }
            this.chartControl1.Redraw(true);
        }

        private void radiobutton1_SeriesType_CheckedChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Series[0].Style.Border.Width = (float)(this.numericUpDown1.Value);
            this.chartControl1.Series[0].Style.Border.DashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), this.comboBox1.SelectedItem.ToString(), true);
            this.chartControl1.Redraw(true);
        }

        private void radiobutton2_SeriesType_CheckedChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Series[1].Style.Border.Width = (float)(this.numericUpDown1.Value);
            this.chartControl1.Series[1].Style.Border.DashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), this.comboBox1.SelectedItem.ToString(), true);
            this.chartControl1.Redraw(true);
        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.radioButton1.Checked)
                this.chartControl1.Series[0].Style.Border.DashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), this.comboBox1.SelectedItem.ToString(), true);
            else if(radioButton2.Checked)
                this.chartControl1.Series[1].Style.Border.DashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), this.comboBox1.SelectedItem.ToString(), true);
            else
                this.chartControl1.Series[2].Style.Border.DashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), this.comboBox1.SelectedItem.ToString(), true);
            this.chartControl1.Redraw(true);
        }

        private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
        {
            if (this.radioButton1.Checked)
                this.chartControl1.Series[0].Style.Border.Width = (float)(this.numericUpDown1.Value);
            else if (this.radioButton2.Checked)
                this.chartControl1.Series[1].Style.Border.Width = (float)(this.numericUpDown1.Value);
            else 
                this.chartControl1.Series[2].Style.Border.Width = (float)(this.numericUpDown1.Value);
            this.chartControl1.Redraw(true);
        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.chartControl1.Series[0].EnableStyles = true;
                this.chartControl1.Series[1].EnableStyles = true;
                this.chartControl1.Series[2].EnableStyles = true;
                this.chartControl1.Series[0].PrepareStyle += new ChartPrepareStyleInfoHandler(series_PrepareStyle);
                this.chartControl1.Series[1].PrepareStyle += new ChartPrepareStyleInfoHandler(series_PrepareStyle);
                this.chartControl1.Series[2].PrepareStyle += new ChartPrepareStyleInfoHandler(series_PrepareStyle);
            }
            else
            {
                this.chartControl1.Series[0].EnableStyles = false;
                this.chartControl1.Series[1].EnableStyles = false;
                this.chartControl1.Series[2].EnableStyles = false;
            }

            this.chartControl1.Redraw(true);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.Legend.RepresentationType = (ChartLegendRepresentationType)Enum.Parse(typeof(ChartLegendRepresentationType), this.comboBox2.SelectedItem.ToString(), true);

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series3D = checkBox2.Checked;
            this.chartControl1.Depth = 50;
        }
        #endregion

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series[2].Style.Border.Width = (float)(this.numericUpDown1.Value);
            this.chartControl1.Series[2].Style.Border.DashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), this.comboBox1.SelectedItem.ToString(), true);
            this.chartControl1.Redraw(true);
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
