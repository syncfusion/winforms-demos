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
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;

namespace ChartDragDrop
{
    public class Form1 : Syncfusion.Windows.Forms.MetroForm
    {
        #region Private Members
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private bool isDragging = false;
        private ChartRegion currentRegion = null;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        #endregion

        #region Form constructor, Main And Dispose
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = DockStyle.Fill;
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10);
            this.chartControl1.DataSourceName = "";
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Location = new System.Drawing.Point(581, 71);
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.Size = new System.Drawing.Size(700, 585);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "chartControl1";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ChartRegionClick += new Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventHandler(this.chartControl1_ChartRegionClick);
            this.chartControl1.ChartRegionMouseDown += new Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventHandler(this.chartControl1_ChartRegionMouseDown);
            this.chartControl1.ChartRegionMouseMove += new Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventHandler(this.chartControl1_ChartRegionMouseMove);
            this.chartControl1.ChartRegionMouseUp += new Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventHandler(this.chartControl1_ChartRegionMouseUp);
            // 
            // panel1
            // 
            this.panel1.Dock = DockStyle.Right;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(700, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 585);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(32, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chart Type";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox1.Items.AddRange(new object[] {
            "Line",
            "Column",
            "Spline",
            "Scatter"});
            this.comboBox1.Location = new System.Drawing.Point(34, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 29);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.MinimumSize = new System.Drawing.Size(494, 382);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drag and Drop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            InitializeChartData();
            this.comboBox1.SelectedIndex = 0;
            this.chartControl1.Dock = DockStyle.Fill;


        }
        #endregion

        #region Helper Method
        #region InitializeChartData
        /// <summary>
        /// Initializes chart data
        /// </summary>
        protected void InitializeChartData()
        {
            ChartSeries series = new ChartSeries("Drag and Drop Series", ChartSeriesType.Line);
            series.Text = series.Name;
            series.Points.Add(1, 25);
            series.Points.Add(2, 31);
            series.Points.Add(3, 42);
            series.Points.Add(4, 59);
            series.Points.Add(5, 78);
            series.Points.Add(6, 89);
            this.chartControl1.Series.Add(series);
            series.Style.Border.Color = Color.Transparent;
        }
        #endregion

        #endregion

        #region Events
        private Point selectedDataPoint;

        /// <summary>
        /// The chart mouse down event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chartControl1_ChartRegionMouseDown(object sender, Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs e)
        {
            selectedDataPoint = new System.Drawing.Point();
            if (e.Region.Type == ChartRegionType.SeriesPoint)
            {
                selectedDataPoint = e.Point;
                this.Cursor = Cursors.SizeAll;
                this.isDragging = true;
                this.currentRegion = e.Region;
            }

        }

        /// <summary>
        /// The chart mouse up event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void chartControl1_ChartRegionMouseUp(object sender, Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs e)
        {
            Cursor = Cursors.SizeAll;
            if (this.isDragging)
            {
                double newY = Math.Floor(this.chartControl1.ChartArea.GetValueByPoint(e.Point).YValues[0]);
                double newX = this.chartControl1.ChartArea.GetValueByPoint(e.Point).X;


                if (newY < 0 || newY >= 100 || newX < 0 || newX > 7)
                    MessageBox.Show("Cannot drag outside chart bounds");
                else
                {
                    this.NewYValue(newY);
                    this.NewXValue(newX);
                }

                this.isDragging = false;
                this.currentRegion = null;
                this.selectedDataPoint.Y = 0;
                this.selectedDataPoint.X = 0;
                this.chartControl1.Redraw(true);
            }

            this.chartControl1.Series[0].Style.TextFormat = "{0}";
            this.chartControl1.Refresh();
        }
        private void NewXValue(double newX)
        {
            this.chartControl1.Series[0].Points[this.currentRegion.PointIndex].X = newX;
        }
        private void NewYValue(double newY)
        {
            this.chartControl1.Series[0].Points[this.currentRegion.PointIndex].YValues[0] = newY;
        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Series.Clear();
            InitializeChartData();
            this.chartControl1.Series[0].Type = (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), this.comboBox1.SelectedItem.ToString(), true);
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            this.chartControl1.Refresh();
        }

        private void chartControl1_ChartRegionMouseMove(object sender, Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs e)
        {
            if (e.Region.Type == ChartRegionType.SeriesPoint)
            {
                this.isDragging = true;
                this.currentRegion = e.Region;
                this.Cursor = Cursors.SizeAll;
            }
            else
            {
                if (this.selectedDataPoint.X == 0 && this.selectedDataPoint.Y == 0)
                    this.Cursor = Cursors.Default;
            }
        }

        private void chartControl1_ChartRegionClick(object sender, ChartRegionMouseEventArgs e)
        {
            if (e.Region.Type == ChartRegionType.ChartCustom)
            {
                this.isDragging = false;
                this.Cursor = Cursors.Default;
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