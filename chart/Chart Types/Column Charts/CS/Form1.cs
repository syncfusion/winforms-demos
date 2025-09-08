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
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms;

namespace ColumnChart2005
{

    public class Form1 : MetroForm
    {
        #region Private Members
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxChartType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown udSpacing;
        private System.Windows.Forms.RadioButton rbRelativeMode;
        private System.Windows.Forms.RadioButton rbFixedMode;
        private System.Windows.Forms.RadioButton rbDefaultMode;
        private Label label3;
        private Label label5;
        private GroupBox groupBox2;
        private Label label7;
        private ComboBox ColTypeCombo;
        private CheckBox checkBox1;
        private ChartControl chartControl1;
        private System.ComponentModel.Container components = null;
        Color[] color1 = new Color[] { Color.FromArgb(136, 197, 242), Color.FromArgb(139, 202, 245), Color.FromArgb(115, 161, 194) };
        Color[] color2 = new Color[] { Color.FromArgb(241, 153, 103), Color.FromArgb(242, 154, 104), Color.FromArgb(206, 133, 90) };
        private Label label2;


        #endregion

        #region Form's Constructor
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
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
        #endregion

        #region Dispose
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ColTypeCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbDefaultMode = new System.Windows.Forms.RadioButton();
            this.rbFixedMode = new System.Windows.Forms.RadioButton();
            this.rbRelativeMode = new System.Windows.Forms.RadioButton();
            this.udSpacing = new System.Windows.Forms.NumericUpDown();
            this.comboBoxChartType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udSpacing)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = DockStyle.Right;
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.ColTypeCombo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.udSpacing);
            this.panel1.Controls.Add(this.comboBoxChartType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(700, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 585);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(36, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 25);
            this.label2.TabIndex = 127;
            this.label2.Text = "3D";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox1.Location = new System.Drawing.Point(40, 391);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 24);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "3D View";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ColTypeCombo
            // 
            this.ColTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColTypeCombo.Enabled = false;
            this.ColTypeCombo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ColTypeCombo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColTypeCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ColTypeCombo.FormattingEnabled = true;
            this.ColTypeCombo.Location = new System.Drawing.Point(39, 469);
            this.ColTypeCombo.Name = "ColTypeCombo";
            this.ColTypeCombo.Size = new System.Drawing.Size(168, 28);
            this.ColTypeCombo.TabIndex = 14;
            this.ColTypeCombo.SelectedIndexChanged += new System.EventHandler(this.ColTypeCombo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.label7.Location = new System.Drawing.Point(36, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Column Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbDefaultMode);
            this.groupBox2.Controls.Add(this.rbFixedMode);
            this.groupBox2.Controls.Add(this.rbRelativeMode);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(40, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 128);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // rbDefaultMode
            // 
            this.rbDefaultMode.Checked = true;
            this.rbDefaultMode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbDefaultMode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDefaultMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.rbDefaultMode.Location = new System.Drawing.Point(14, 12);
            this.rbDefaultMode.Name = "rbDefaultMode";
            this.rbDefaultMode.Size = new System.Drawing.Size(143, 35);
            this.rbDefaultMode.TabIndex = 0;
            this.rbDefaultMode.TabStop = true;
            this.rbDefaultMode.Text = "Default";
            this.rbDefaultMode.CheckedChanged += new System.EventHandler(this.radioButtonWidthMode_CheckedChanged);
            // 
            // rbFixedMode
            // 
            this.rbFixedMode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbFixedMode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFixedMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.rbFixedMode.Location = new System.Drawing.Point(14, 91);
            this.rbFixedMode.Name = "rbFixedMode";
            this.rbFixedMode.Size = new System.Drawing.Size(104, 30);
            this.rbFixedMode.TabIndex = 1;
            this.rbFixedMode.Text = "Fixed";
            this.rbFixedMode.CheckedChanged += new System.EventHandler(this.radioButtonWidthMode_CheckedChanged);
            // 
            // rbRelativeMode
            // 
            this.rbRelativeMode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbRelativeMode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRelativeMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.rbRelativeMode.Location = new System.Drawing.Point(14, 53);
            this.rbRelativeMode.Name = "rbRelativeMode";
            this.rbRelativeMode.Size = new System.Drawing.Size(118, 32);
            this.rbRelativeMode.TabIndex = 2;
            this.rbRelativeMode.Text = "Relative";
            this.rbRelativeMode.CheckedChanged += new System.EventHandler(this.radioButtonWidthMode_CheckedChanged);
            // 
            // udSpacing
            // 
            this.udSpacing.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udSpacing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.udSpacing.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udSpacing.Location = new System.Drawing.Point(40, 309);
            this.udSpacing.Name = "udSpacing";
            this.udSpacing.ReadOnly = true;
            this.udSpacing.Size = new System.Drawing.Size(167, 27);
            this.udSpacing.TabIndex = 0;
            this.udSpacing.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // comboBoxChartType
            // 
            this.comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChartType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxChartType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChartType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBoxChartType.Location = new System.Drawing.Point(43, 62);
            this.comboBoxChartType.Name = "comboBoxChartType";
            this.comboBoxChartType.Size = new System.Drawing.Size(167, 28);
            this.comboBoxChartType.TabIndex = 4;
            this.comboBoxChartType.SelectedIndexChanged += new System.EventHandler(this.comboBoxChartType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chart Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(39, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Width Mode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label5.Location = new System.Drawing.Point(36, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Spacing";
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = DockStyle.Fill;
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(193))))), System.Drawing.Color.White);
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(6, 6, 15, 6);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.DataSourceName = "";
            this.chartControl1.ElementsSpacing = 0;
            this.chartControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.Legend.Border.ForeColor = System.Drawing.Color.Transparent;
            this.chartControl1.Legend.Location = new System.Drawing.Point(606, 41);
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Pastel;
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.Size = new System.Drawing.Size(700, 580);
            this.chartControl1.TabIndex = 5;
            this.chartControl1.Text = "Essential Chart";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "Essential Chart";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 584);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(626, 428);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Column";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.udSpacing)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.comboBoxChartType.Items.Add(ChartSeriesType.Column);
            this.comboBoxChartType.Items.Add(ChartSeriesType.ColumnRange);
            this.comboBoxChartType.Items.Add(ChartSeriesType.StackingColumn);
            this.comboBoxChartType.SelectedIndex = 0;

            this.udSpacing.Value = (decimal)this.chartControl1.Spacing;

            InitializeChartData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);

            foreach (string columnType in Enum.GetNames(typeof(ChartColumnType)))
            {
                this.ColTypeCombo.Items.Add(columnType);

            }
            this.ColTypeCombo.SelectedIndex = 0;
            this.chartControl1.Series[0].ConfigItems.ColumnItem.ColumnType = (ChartColumnType)Enum.Parse(typeof(ChartColumnType), this.ColTypeCombo.SelectedItem.ToString());
            this.chartControl1.Series[1].ConfigItems.ColumnItem.ColumnType = (ChartColumnType)Enum.Parse(typeof(ChartColumnType), this.ColTypeCombo.SelectedItem.ToString());
            this.chartControl1.Series[2].ConfigItems.ColumnItem.ColumnType = (ChartColumnType)Enum.Parse(typeof(ChartColumnType), this.ColTypeCombo.SelectedItem.ToString());

        }
        #endregion

        #region Helper Methods

        #region InitializeChartData

        protected void InitializeChartData()
        {
            int numPoints = 4;

            this.chartControl1.Series.Clear();

            ChartSeries series = new ChartSeries("Team 1");
            for (int j = 1; j <= numPoints; j++)
            {
                if (rbDefaultMode.Checked)
                    series.Points.Add(j, new double[] { j * 12 + 12 });
                else if (rbFixedMode.Checked)
                    series.Points.Add(j, new double[] { j * 12 + 12, 12 });
                else if (rbRelativeMode.Checked)
                    series.Points.Add(j, new double[] { j * 12 + 12, 0.75 });
            }
            series.Type = (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), this.comboBoxChartType.SelectedItem.ToString(), true);
            series.Text = series.Name;
            this.chartControl1.Series.Add(series);

            series = new ChartSeries("Team 2");
            for (int k = 1; k <= numPoints; k++)
            {
                if (rbDefaultMode.Checked)
                    series.Points.Add(k, new double[] { k * 14 + 14 });
                else if (rbFixedMode.Checked)
                    series.Points.Add(k, new double[] { k * 14 + 14, 14 });
                else if (rbRelativeMode.Checked)
                    series.Points.Add(k, new double[] { k * 14 + 14, 0.75 });
            }
            series.Text = series.Name;
            series.Type = (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), this.comboBoxChartType.SelectedItem.ToString(), true);
            this.chartControl1.Series.Add(series);

            series = new ChartSeries("Team 3");
            for (int k = 1; k <= numPoints; k++)
            {
                if (rbDefaultMode.Checked)
                    series.Points.Add(k, new double[] { k * 16 + 16 });
                else if (rbFixedMode.Checked)
                    series.Points.Add(k, new double[] { k * 16 + 16, 16 });
                else if (rbRelativeMode.Checked)
                    series.Points.Add(k, new double[] { k * 16 + 16, 0.75 });
            }
            series.Text = series.Name;
            series.Type = (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), this.comboBoxChartType.SelectedItem.ToString(), true);
            this.chartControl1.Series.Add(series);

            this.chartControl1.Series[0].Style.Border.Color = Color.Transparent;
            this.chartControl1.Series[1].Style.Border.Color = Color.Transparent;
            this.chartControl1.Series[2].Style.Border.Color = Color.Transparent;

        }
        #endregion

        private void comboBoxChartType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.comboBoxChartType.SelectedIndex == 1)
            {
                this.rbDefaultMode.Enabled = false;
                this.rbRelativeMode.Enabled = false;
                this.rbFixedMode.Checked = true;
            }
            else
            {
                this.rbDefaultMode.Enabled = true;
                this.rbDefaultMode.Checked = true;
            }
            if (this.comboBoxChartType.SelectedIndex == 2)
            {
                this.rbFixedMode.Enabled = false;
            }
            else
            {
                this.rbFixedMode.Enabled = true;
                if (this.checkBox1.Checked) 
                this.rbRelativeMode.Enabled = true;
            }
            for (int i = 0; i < this.chartControl1.Series.Count; i++)
            {
                this.chartControl1.Series[i].Type = (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), this.comboBoxChartType.SelectedItem.ToString(), true);
                
            }
            SetColumnType();
        }
       private void SetColumnType()
        {
            if (checkBox1.Checked)
            {
                this.chartControl1.Series[0].ConfigItems.ColumnItem.ColumnType = (ChartColumnType)Enum.Parse(typeof(ChartColumnType), this.ColTypeCombo.SelectedItem.ToString());
                this.chartControl1.Series[1].ConfigItems.ColumnItem.ColumnType = (ChartColumnType)Enum.Parse(typeof(ChartColumnType), this.ColTypeCombo.SelectedItem.ToString());
                this.chartControl1.Series[2].ConfigItems.ColumnItem.ColumnType = (ChartColumnType)Enum.Parse(typeof(ChartColumnType), this.ColTypeCombo.SelectedItem.ToString());
            }
        }
        private void radioButtonWidthMode_CheckedChanged(object sender, System.EventArgs e)
        {
            InitializeChartData();
            RadioButton rbtn = sender as RadioButton;
            if (rbtn == this.rbDefaultMode) // default
                this.chartControl1.ColumnWidthMode = ChartColumnWidthMode.DefaultWidthMode;
            else if (rbtn == this.rbFixedMode) // fixed
            {
                // YValues[1] set as 12 for each series point in InitializeChartData
                this.chartControl1.ColumnWidthMode = ChartColumnWidthMode.FixedWidthMode;

            }
            else if (rbtn == this.rbRelativeMode) //relative
            {
                // YValues[1] set as 0.75 for each series point in InitializeChartData
                this.chartControl1.ColumnWidthMode = ChartColumnWidthMode.RelativeWidthMode;
            }

            if (rbtn == this.rbFixedMode || rbtn == this.rbRelativeMode)
                this.udSpacing.Enabled = false;
            else
                this.udSpacing.Enabled = true;
            this.chartControl1.Series[0].ConfigItems.ColumnItem.ColumnType = (ChartColumnType)Enum.Parse(typeof(ChartColumnType), this.ColTypeCombo.SelectedItem.ToString());
            this.chartControl1.Series[1].ConfigItems.ColumnItem.ColumnType = (ChartColumnType)Enum.Parse(typeof(ChartColumnType), this.ColTypeCombo.SelectedItem.ToString());
            this.chartControl1.Series[2].ConfigItems.ColumnItem.ColumnType = (ChartColumnType)Enum.Parse(typeof(ChartColumnType), this.ColTypeCombo.SelectedItem.ToString());
        }

        private void radioButtonMultipleY_CheckedChanged(object sender, System.EventArgs e)
        {
            InitializeChartData();
            this.chartControl1.Series[0].ConfigItems.ColumnItem.ColumnType = (ChartColumnType)Enum.Parse(typeof(ChartColumnType), this.ColTypeCombo.SelectedItem.ToString());
            this.chartControl1.Series[1].ConfigItems.ColumnItem.ColumnType = (ChartColumnType)Enum.Parse(typeof(ChartColumnType), this.ColTypeCombo.SelectedItem.ToString());
            this.chartControl1.Series[2].ConfigItems.ColumnItem.ColumnType = (ChartColumnType)Enum.Parse(typeof(ChartColumnType), this.ColTypeCombo.SelectedItem.ToString());
        }

        private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Spacing = (float)this.udSpacing.Value;
        }

        private void ColTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series[0].ConfigItems.ColumnItem.ColumnType = (ChartColumnType)Enum.Parse(typeof(ChartColumnType), this.ColTypeCombo.SelectedItem.ToString());
            this.chartControl1.Series[1].ConfigItems.ColumnItem.ColumnType = (ChartColumnType)Enum.Parse(typeof(ChartColumnType), this.ColTypeCombo.SelectedItem.ToString());
            this.chartControl1.Series[2].ConfigItems.ColumnItem.ColumnType = (ChartColumnType)Enum.Parse(typeof(ChartColumnType), this.ColTypeCombo.SelectedItem.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series3D = this.checkBox1.Checked;
            this.label7.ForeColor = this.checkBox1.Checked ? System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66))))) : System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            if (!this.checkBox1.Checked)
            {
                this.ColTypeCombo.Enabled = false;
            }
            else
            {
                this.ColTypeCombo.Enabled = true;
                if (this.comboBoxChartType.SelectedIndex != 2);
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
