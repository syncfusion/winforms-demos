#region Copyright Syncfusion Inc. 2001 - 2006
//
//  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;

namespace Syncfusion.Windows.Forms.Chart.Samples
{
    public class FormMain : Syncfusion.Windows.Forms.MetroForm
    {
        private IContainer components = null;

        #region Private Members

        private System.Windows.Forms.Panel panel1;
        private ChartInteractiveCursor cursor1;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton1;
        private Label label2;
        private ComboBox comboBox2;
        private Label label4;
        private ComboBox comboBox1;
        private Label label1;
        private CheckBox checkBox1;
        private Label label3;
        private ChartControl chartControl1;
        #endregion

        #region Constructor, Main and Dispose
        public FormMain()
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
            Application.Run(new FormMain());
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colorPickerButton1 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.DataSourceName = "";
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Location = new System.Drawing.Point(591, 75);
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.Size = new System.Drawing.Size(700, 556);
            this.chartControl1.TabIndex = 1;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "chartControl1";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ZoomOutIncrement = 1.5D;
            // 
            // panel1
            // 
            this.panel1.Dock = DockStyle.Right;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.colorPickerButton1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(700, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 585);
            this.panel1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "100",
            "150",
            "200"});
            this.comboBox2.Location = new System.Drawing.Point(33, 156);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(178, 29);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(31, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Y Interval";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "4",
            "6"});
            this.comboBox1.Location = new System.Drawing.Point(33, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 29);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(31, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "X Interval";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox1.Location = new System.Drawing.Point(34, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(163, 25);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "MoveTo Chart Area";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(31, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cursor Color";
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.BackColor = System.Drawing.Color.Black;
            this.colorPickerButton1.BeforeTouchSize = new System.Drawing.Size(100, 30);
            this.colorPickerButton1.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.colorPickerButton1.IsBackStageButton = false;
            this.colorPickerButton1.Location = new System.Drawing.Point(34, 221);
            this.colorPickerButton1.MetroColor = System.Drawing.Color.Black;
            this.colorPickerButton1.Name = "colorPickerButton1";
            this.colorPickerButton1.SelectedAsBackcolor = true;
            this.colorPickerButton1.SelectedColor = System.Drawing.Color.Black;
            this.colorPickerButton1.Size = new System.Drawing.Size(100, 30);
            this.colorPickerButton1.TabIndex = 2;
            this.colorPickerButton1.UseVisualStyleBackColor = false;
            this.colorPickerButton1.ColorSelected += new System.EventHandler(this.Color_selected);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(60, 549);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Click on the interactive cursor line and drag the chart area or series points";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 581);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(630, 497);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interactive Cursor";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Form Load
        private void FormMain_Load(object sender, EventArgs e)
        {
            InitializeChartData();
            this.comboBox1.SelectedIndex = 0;
            this.comboBox2.SelectedIndex = 0;
            
            this.label1.Enabled = true;
            this.label4.Enabled = true;
            this.comboBox1.Enabled = true;
            this.comboBox2.Enabled = true;
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            this.chartControl1.Dock = DockStyle.Fill;

            //InitializeControlSettings();
        }
        #endregion

        #region Helper Methods

        #region InitializeChartData
        /// <summary>
        /// Initializes the ChartControl's data and sets the Chart type
        /// </summary>
        protected void InitializeChartData()
        {
            ChartSeries series1 = new ChartSeries();
            series1.Name = "Server 1";
            series1.Type = ChartSeriesType.Line;
            series1.Text = series1.Name;
            int[] r1 = new int[] { 256, 491, 382, 437, 321, 234, 425, 257, 382, 296, 437, 451, 490, 366, 422, 361, 185, 384, 461, 258 };
            for (int i = 2; i < 20; i = i + 2)
                series1.Points.Add(i, r1[i]);

            series1.PrepareStyle += new ChartPrepareStyleInfoHandler(ChartControlSeries_PrepareStyle);

            this.chartControl1.Series.Add(series1);
            this.chartControl1.Text = "Chart Interactive cursor";
            cursor1 = new ChartInteractiveCursor(this.chartControl1.Series[0]);
            this.chartControl1.ChartArea.InteractiveCursors.Add(cursor1);
            cursor1.Color = Color.Black;
            this.chartControl1.ChartArea.InteractiveCursors[0].XPosition = 2;
            this.chartControl1.ChartArea.InteractiveCursors[0].YPosition = 2;
            this.chartControl1.ChartArea.InteractiveCursors[0].MoveToChartArea = this.checkBox1.Checked;
            if (this.chartControl1.ChartArea.InteractiveCursors[0].MoveToChartArea)
            {
                this.chartControl1.ChartArea.InteractiveCursors[0].XInterval = 2;
                this.chartControl1.ChartArea.InteractiveCursors[0].YInterval = 50;
            }
        }
        #endregion
        #endregion

        #region Events

        #region PrepareStyle
        /// <summary>
        /// Handler for the PrepareStyle event of ChartSeries. 
        /// </summary>
        /// <param name="sender">The ChartSeries object that raises this event.</param>
        /// <param name="args">The event data. Can be modified to change series appearance.</param>
        protected void ChartControlSeries_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
        {
            // Style formatting using a callback. You can apply the same settings directly on the series style on the
            // point styles.
            ChartSeries series = sender as ChartSeries;
            if (series != null)
            {
                args.Style.DisplayText = true;
                args.Style.TextFormat = "{0}";
                args.Style.TextOrientation = ChartTextOrientation.Up;
                args.Style.Symbol.Shape = ChartSymbolShape.Circle;
                args.Style.Symbol.Size = new Size(10, 10);
                args.Style.Symbol.Color = Color.White;
                args.Style.Symbol.Border.Color = Color.FromArgb(129, 115, 27);
                args.Style.Symbol.Border.Width = 2;
            }
        }
        #endregion


        private void Color_selected(object sender, System.EventArgs e)
        {
            cursor1.Color = this.colorPickerButton1.SelectedColor;

            this.chartControl1.Redraw(true);
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked && this.chartControl1.ChartArea.InteractiveCursors.Count >0)
            {
                this.chartControl1.ChartArea.InteractiveCursors[0].MoveToChartArea = this.checkBox1.Checked;
                this.label1.Enabled = true;
                this.label4.Enabled = true;
                this.comboBox1.Enabled = true;
                this.comboBox2.Enabled = true;
            }
            else
            {
                if (this.chartControl1.ChartArea.InteractiveCursors.Count > 0)
                {
                    this.chartControl1.ChartArea.InteractiveCursors[0].MoveToChartArea = this.checkBox1.Checked;
                }
                this.label1.Enabled = false;
                this.label4.Enabled = false;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = false;
            }
            this.chartControl1.Redraw(true);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.ChartArea.InteractiveCursors[0].XInterval = Convert.ToDouble(this.comboBox1.SelectedItem);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.chartControl1.ChartArea.InteractiveCursors[0].YInterval = Convert.ToDouble(this.comboBox2.SelectedItem);
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