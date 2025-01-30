#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;

namespace OtherCharts
{
    public class Form1 : MetroForm
    {
        #region Private Members

        private System.Windows.Forms.Panel panel1;

        private ChartStripLine line = new ChartStripLine();

        private ChartAxis secaxis = new ChartAxis();
        private bool isDragging = false;
        private ChartRegion currentRegion = null;
        private Point chartAreaPoint;
       
        private System.Windows.Forms.CheckBox checkBox_Drag;
        private ChartControl chartControl1;

        private ToolTip toolTip1;
        private CheckBox checkBox1;
        private IContainer components;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkBox_Drag = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_Drag
            // 
            this.checkBox_Drag.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Drag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox_Drag.Location = new System.Drawing.Point(56, 66);
            this.checkBox_Drag.Name = "checkBox_Drag";
            this.checkBox_Drag.Size = new System.Drawing.Size(151, 27);
            this.checkBox_Drag.TabIndex = 3;
            this.checkBox_Drag.Text = "Drag And Drop";
            // 
            // panel1
            // 
            this.panel1.Dock = DockStyle.Right;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.checkBox_Drag);
            this.panel1.Location = new System.Drawing.Point(700, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 580);
            this.panel1.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox1.Location = new System.Drawing.Point(56, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 27);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Enable 3D";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250))))), System.Drawing.Color.White);
            this.chartControl1.BorderAppearance.Interior.ForeColor = System.Drawing.Color.Transparent;
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.None, System.Drawing.Color.White, System.Drawing.Color.White);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(5, 5, 5, 2);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.BackwardDiagonal, System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250))))), System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250))))));
            this.chartControl1.ColumnFixedWidth = 35;
            this.chartControl1.DataSourceName = "";
            this.chartControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Center;
            this.chartControl1.Legend.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.Legend.Border.ForeColor = System.Drawing.Color.Transparent;
            this.chartControl1.Legend.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.Legend.ItemsSize = new System.Drawing.Size(15, 15);
            this.chartControl1.Legend.Location = new System.Drawing.Point(318, 46);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top;
            this.chartControl1.Legend.Spacing = 3;
            this.chartControl1.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.Transparent;
            this.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.DarkGray;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.Transparent;
            this.chartControl1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.DarkGray;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl1.Size = new System.Drawing.Size(700, 580);
            this.chartControl1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.chartControl1.TabIndex = 3;
            this.chartControl1.Text = "Essential Chart";
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "Essential Chart";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ZoomOutIncrement = 1.5D;
            this.chartControl1.ChartFormatAxisLabel += new Syncfusion.Windows.Forms.Chart.ChartFormatAxisLabelEventHandler(this.chartControl1_ChartFormatAxisLabel);
            this.chartControl1.ChartRegionMouseMove += new Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventHandler(this.chartControl1_ChartRegionMouseMove);
            this.chartControl1.ChartRegionMouseUp += new Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventHandler(this.chartControl1_ChartRegionMouseUp);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 584);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.MinimumSize = new System.Drawing.Size(706, 428);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gantt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.chartControl1.Series.Clear();
           
            InitializeChartData();
            this.chartControl1.PrimaryXAxis.RangePaddingType = ChartAxisRangePaddingType.Calculate;
            this.chartControl1.PrimaryYAxis.RangePaddingType = ChartAxisRangePaddingType.Calculate;
            this.chartControl1.LegendPosition = ChartDock.Top;
            this.chartControl1.Legend.ColumnsCount = 2;
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }

        #endregion

        #region Helper Methods

        #region InitializeChartData
        protected void InitializeChartData()
        {
            ChartSeries Completion = new ChartSeries("Completion", ChartSeriesType.Gantt);

            DateTime dt = new DateTime(2009, 1, 1);
            Completion.Points.Add(0, dt, dt.AddDays(2));
            Completion.Points.Add(1, dt.AddDays(1), dt.AddDays(2));
            Completion.Points.Add(2, dt.AddDays(3), dt.AddDays(5));
            Completion.Points.Add(3, dt.AddDays(6), dt.AddDays(9));
            Completion.Points.Add(4, dt.AddDays(10), dt.AddDays(13));
            Completion.Points.Add(5, dt.AddDays(15), dt.AddDays(18));
                        
            Completion.Style.PointWidth = 0.5f;

            this.chartControl1.Series.Add(Completion);
            Completion.PointsToolTipFormat = "{1}{2}";

            ChartSeries Task = new ChartSeries("Task", ChartSeriesType.Gantt);

            Task.Points.Add(0, dt, dt.AddDays(2));
            Task.Points.Add(1, dt.AddDays(1), dt.AddDays(3));
            Task.Points.Add(2, dt.AddDays(3), dt.AddDays(6));
            Task.Points.Add(3, dt.AddDays(6), dt.AddDays(10));
            Task.Points.Add(4, dt.AddDays(10), dt.AddDays(15));
            Task.Points.Add(5, dt.AddDays(15), dt.AddDays(20));

            // Make a note of the last day:
            DateTime lastDay = DateTime.FromOADate(Task.Points[Task.Points.Count - 1].YValues[1]);

            Task.Style.PointWidth = 0.75f;
            this.chartControl1.Series.Add(Task);
            Task.PointsToolTipFormat = "{1}{2}";

            this.chartControl1.ShowToolTips = true;
            this.chartControl1.CalcRegions = true;
                   

            this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(dt, lastDay.AddDays(2), 1, ChartDateTimeIntervalType.Days);

            // Displays custom into on Points
            for (int i = 0; i < this.chartControl1.Series[0].Points.Count; i++)
            {
                if (this.chartControl1.Series[1].Points[i].YValues[0] != this.chartControl1.Series[1].Points[i].YValues[1])
                {
                    ChartCustomPoint ccp = new ChartCustomPoint();

                    ChartPoint pt = this.chartControl1.Series[1].Points[i];
                    ccp.XValue = pt.X;
                    ccp.YValue = pt.YValues[0] + 1;
                    ccp.CustomType = ChartCustomPointType.ChartCoordinates;
                    ccp.Text = String.Format("{0} days", pt.YValues[1] - pt.YValues[0]);
                    ccp.Color = Color.White;
                    ccp.Font.Facename = "Segoe UI";
                    this.chartControl1.CustomPoints.Add(ccp);
                }
            }

            // To indicate weekends
            Color[] stripLineColor = new Color[] { Color.LightGray, Color.WhiteSmoke, Color.LightGray};

            //Chart Strip Lines
            ChartStripLine stripLine1 = new ChartStripLine();
            stripLine1.Enabled = true;
            stripLine1.Vertical = false;
            stripLine1.StartDate = dt.AddDays(2); //// We know that Jan 3rd is a Saturday.
            stripLine1.EndDate = lastDay;
            stripLine1.Width = 2;

            // Repetition frequency: every 7 days
            stripLine1.PeriodDate = new TimeSpan(7, 0, 0, 0);
            stripLine1.Text = string.Empty;
            stripLine1.Interior = new BrushInfo(GradientStyle.ForwardDiagonal, stripLineColor);
            this.chartControl1.PrimaryXAxis.StripLines.Add(stripLine1);

            this.chartControl1.Series[0].PrepareStyle += new ChartPrepareStyleInfoHandler(Form1_PrepareStyle);
            this.chartControl1.Series[1].PrepareStyle += new ChartPrepareStyleInfoHandler(Form1_PrepareStyle);            
        }

        void Form1_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
        {
            ChartSeries series = sender as ChartSeries;
            if (series == null)
                return;

            ChartPoint taskPoint = this.chartControl1.Series[1].Points[args.Index];
            ChartPoint completionPoint = this.chartControl1.Series[0].Points[args.Index];

            DateTime completionStartDate = DateTime.FromOADate(completionPoint.YValues[0]);
            DateTime completionEndDate = DateTime.FromOADate(completionPoint.YValues[1]);

            DateTime taskStartDate = DateTime.FromOADate(taskPoint.YValues[0]);
            DateTime taskEndDate = DateTime.FromOADate(taskPoint.YValues[1]);
            double percentCompleted = ((double)(completionEndDate.Day - completionStartDate.Day) / (double)(taskEndDate.Day - taskStartDate.Day)) * 100;
            double percentRemaining = 100 - percentCompleted;
            args.Style.ToolTip = "Start date:" + taskStartDate.ToShortDateString() + "\nEnd date:" + taskEndDate.ToShortDateString() + "\nPercent Completed:" + Math.Round(percentCompleted, 2) + "%\nPercent Remaining: " + Math.Round(percentRemaining, 2) + "%";

            args.Handled = true;
        }

        #endregion

        #region ConvertScreenPointToChartAreaPoint
        private Point ConvertScreenPointToChartAreaPoint(Point screenPoint)
        {
            // We cant directly convert a Screen Point to Chart Area Coordinates
            // This converts the point in screen coordinates to chartcontrol coordinates
            Point ccp = this.chartControl1.PointToClient(screenPoint);

            return ccp;
        }

        #endregion

        private void NewXValue(double newX)
        {
            this.chartControl1.Series[0].Points[this.currentRegion.PointIndex].X=(newX);
        }

        private void NewYValue(double newY)
        {
            this.chartControl1.Series[0].Points[this.currentRegion.PointIndex].YValues[0] =newY;
        }

        #endregion

        #region Events

        # region ChartRegionMouseMove
        private void chartControl1_ChartRegionMouseMove(object sender, Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs e)
        {
            if (this.checkBox_Drag.Checked)
            {
                if (e.Region.IsChartPoint)
                {
                    Cursor = Cursors.SizeAll;
                    this.isDragging = true;
                    this.currentRegion = e.Region;
                }
                else
                {
                    Cursor = Cursors.Default;
                }
            }
        }

        # endregion

        # region ChartRegionMouseUp
        private void chartControl1_ChartRegionMouseUp(object sender, Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs e)
        {
            if (this.checkBox_Drag.Checked)
            {
                if (this.isDragging)
                {
                    chartAreaPoint = ConvertScreenPointToChartAreaPoint(Control.MousePosition);

                    double newY = Math.Floor(this.chartControl1.ChartArea.GetValueByPoint(chartAreaPoint).YValues[0]);
                    double newX = Math.Floor(this.chartControl1.ChartArea.GetValueByPoint(chartAreaPoint).X);

                    if (newY < 0 || newY >= 39835 || newX < 0 || newX > 7)
                        MessageBox.Show("Cannot drag outside chart bounds");
                    else
                    {
                        this.NewYValue(newY);                     
                    }
                    this.isDragging = false;
                    this.currentRegion = null;
                }
                this.isDragging = false;
                this.currentRegion = null;
                this.chartControl1.Redraw(true);
            }
        }

        # endregion

        private void numericUpDown_CriticalValue_ValueChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Redraw(true);
        }

        #region ChartFormatAxisLabel

        private void chartControl1_ChartFormatAxisLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            if (e.AxisOrientation == ChartOrientation.Vertical)
            {
                // To make the label text as "Activity N"
                if (e.Value >= 0 && e.Value < this.chartControl1.Series[0].Points.Count)
                    e.Label = String.Format("Activity {0}", e.Value + 1);
                else
                    e.Label = String.Empty;
            }
            else
            {
                e.Label = e.ValueAsDate.ToString("MM/dd/yy");
            }

            e.Handled = true;


        }
        #endregion

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series3D = checkBox1.Checked;
            this.chartControl1.Series[0].Style.Border.Color=Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2);
            this.chartControl1.Series[1].Style.Border.Color = Color.FromArgb(0xFF, 0xA0, 0x50, 0x00);
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