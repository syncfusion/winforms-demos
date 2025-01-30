#region Copyright Syncfusion Inc. 2001 - 2008
//
//  Copyright Syncfusion Inc. 2001 - 2008. All rights reserved.
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
using System.Xml;
using System.Data.OleDb;

using Syncfusion.Windows.Forms;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Chart;

namespace ChartImportData
{
	public class Form1 : MetroForm
    {
        #region Private Members
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
		private DateTime lastTime = DateTime.Now;
        private ChartControl chartControl2;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Label label40;
        private Panel panel1;
        Color[] stripLineColor = new Color[] { Color.White, Color.Olive, Color.Olive};
        private Label label6;       
		private System.ComponentModel.Container components = null;
        #endregion

        #region Form's Constructor, Main And Dispose
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
            Application.Run(new Form1());
        }
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
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
            this.chartControl2 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label40 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = DockStyle.Top;
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Embed;
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 4, 20, 1);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.DataSourceName = "";
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Center;
            this.chartControl1.Legend.Location = new System.Drawing.Point(421, 55);
            this.chartControl1.Legend.Margin = new System.Windows.Forms.Padding(1);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top;
            this.chartControl1.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(180)))), ((int)(((byte)(233)))));
            this.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(146)))), ((int)(((byte)(194)))));
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl1.PrimaryXAxis.TickColor = System.Drawing.Color.Transparent;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(180)))), ((int)(((byte)(233)))));
            this.chartControl1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(146)))), ((int)(((byte)(194)))));
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.RangePaddingType = Syncfusion.Windows.Forms.Chart.ChartAxisRangePaddingType.None;
            this.chartControl1.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl1.PrimaryYAxis.TickColor = System.Drawing.Color.Transparent;
            this.chartControl1.Size = new System.Drawing.Size(920, 227);
            this.chartControl1.TabIndex = 1;
            this.chartControl1.Text = "High Level Chart";
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.Title.Margin = 1;
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "High Level Chart";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ZoomOutIncrement = 1.5D;
            this.chartControl1.VisibleRangeChanged += new System.EventHandler(this.chartControl1_VisibleRangeChanged);
            this.chartControl1.Click += new System.EventHandler(this.chartControl1_Click);
            // 
            // chartControl2
            // 
            this.chartControl2.Dock = DockStyle.Bottom;
            this.chartControl2.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.chartControl2.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Embed;
            this.chartControl2.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl2.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl2.ChartArea.CursorReDraw = false;
            this.chartControl2.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 4, 10, 1);
            this.chartControl2.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.None, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl2.DataSourceName = "";
            this.chartControl2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl2.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl2.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Center;
            this.chartControl2.Legend.Location = new System.Drawing.Point(421, 55);
            this.chartControl2.Legend.Margin = new System.Windows.Forms.Padding(1);
            this.chartControl2.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl2.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top;
            this.chartControl2.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.chartControl2.Localize = null;
            this.chartControl2.Location = new System.Drawing.Point(3, 212);
            this.chartControl2.Name = "chartControl2";
            this.chartControl2.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl2.PrimaryXAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.chartControl2.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(180)))), ((int)(((byte)(233)))));
            this.chartControl2.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(146)))), ((int)(((byte)(194)))));
            this.chartControl2.PrimaryXAxis.Margin = true;
            this.chartControl2.PrimaryXAxis.TickColor = System.Drawing.Color.Transparent;
            this.chartControl2.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl2.PrimaryYAxis.ForceZero = true;
            this.chartControl2.PrimaryYAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.chartControl2.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(180)))), ((int)(((byte)(233)))));
            this.chartControl2.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(146)))), ((int)(((byte)(194)))));
            this.chartControl2.PrimaryYAxis.Margin = true;
            this.chartControl2.PrimaryYAxis.TickColor = System.Drawing.Color.Transparent;
            this.chartControl2.Size = new System.Drawing.Size(920, 227);
            this.chartControl2.TabIndex = 3;
            this.chartControl2.Text = "Low Level Chart";
            // 
            // 
            // 
            this.chartControl2.Title.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl2.Title.Margin = 1;
            this.chartControl2.Title.Name = "Default";
            this.chartControl2.Titles.Add(this.chartControl2.Title);
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Dock = DockStyle.Bottom;
            this.gradientPanel2.BackColor = System.Drawing.Color.White;
            this.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel2.Controls.Add(this.label40);
            this.gradientPanel2.Controls.Add(this.label6);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel2.Location = new System.Drawing.Point(0, 481);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(958, 103);
            this.gradientPanel2.TabIndex = 7;
            // 
            // label40
            // 
            this.label40.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label40.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label40.Location = new System.Drawing.Point(23, 22);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(935, 72);
            this.label40.TabIndex = 1;
            this.label40.Text = resources.GetString("label40.Text");
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(23, -9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 35);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sample Description";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(this.chartControl1);
            this.panel1.Controls.Add(this.chartControl2);
            this.panel1.Location = new System.Drawing.Point(23, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 461);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 584);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gradientPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(657, 620);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiple Charts with Huge Datasource";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
		{           		
            InitializeChartData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            ChartAppearance.ApplyChartStyles(this.chartControl2);
        }
        #endregion

        #region Helper Methods         

        #region InitializeChartData
        /// <summary>
        /// Initializes chart data from access database.
        /// </summary>
        protected void InitializeChartData()
		{
            int yMax = 100;
            int totalXValues = 100000;

            DataTable tableSource = this.CreateLargeTable(totalXValues, yMax);

            #region MASTERCHART
            //Sets the value type and of the axes. Setting this ensures that the ranges stay consistent as you zoom into the chart.
            // Master Chart
            this.SetChartRange(this.chartControl1.PrimaryXAxis, new MinMaxInfo(0, totalXValues, totalXValues / 10));

            this.SetChartRange(this.chartControl1.PrimaryYAxis, new MinMaxInfo(0, yMax, yMax / 10));

            //Initializes new chart series.
            ChartSeries series = new ChartSeries();
            series.Name = "Population";
            series.Type = ChartSeriesType.Spline;

            // Model that "dilutes" the large set of data points based on the current chart width. Instead of just skipping
            // points, this model uses an average of a set of points.
            ChartOversizedDataBindModel model = new ChartOversizedDataBindModel(this.chartControl1, tableSource, "X", "Y", false);
            // Assign this data model to the new series.
			series.SeriesModel = model;
            model.DilutionFactorChanged += new EventHandler(model_DilutionFactorChanged);
            //Adds the series to the ChartSeriesCollection.
            this.chartControl1.Series.Add(series);

            this.chartControl1.EnableXZooming = true;

            SetStripLine(0, 10000);
            #endregion

            #region DETAILCHART
            // Detail Chart
            this.SetChartRange(this.chartControl2.PrimaryXAxis, new MinMaxInfo(0, totalXValues / 10, totalXValues / 100));
            this.SetChartRange(this.chartControl2.PrimaryYAxis, new MinMaxInfo(0, yMax, yMax / 10));

            ChartSeries series2 = new ChartSeries();
            series2.Name = "Population";
            series2.Type = ChartSeriesType.Spline;
            
            ChartOversizedDataBindModel model2 = new ChartOversizedDataBindModel(this.chartControl2, tableSource, "X", "Y");
            // Assign this data model to the new series.
            series2.SeriesModel = model2;
            model2.DilutionFactorChanged += new EventHandler(model_DilutionFactorChanged);
            this.chartControl2.Series.Add(series2);

            #endregion
            this.UpdateChartSubTitles();            
        }
        #endregion

        #region SetChartRange
        private void SetChartRange(ChartAxis axis, MinMaxInfo range)
        {
            axis.ValueType = ChartValueType.Double;
            axis.RangeType = ChartAxisRangeType.Set;
            axis.Range = range;
        }
        #endregion
        
        #region CreateLargeTable
        private DataTable CreateLargeTable(int totalXValues, int yMax)
        {
            DataTable table = new DataTable();
            // It's important that the x values are marked as integer, otherwise, the engine will treat it as strings and
            // sort them incorrectly.
            DataColumn x = new DataColumn("X", typeof(Int32));
            table.Columns.Add(x);
            table.Columns.Add(new DataColumn("Y"));

            Random ran = new Random(DateTime.Now.Second);

            for (int i = 0; i < totalXValues; i++)
            {
                int xVal = i;
                double yVal = ((double)xVal / totalXValues) * yMax + ran.Next(-20, 20);
                DataRow row = table.NewRow();

                row[0] = xVal;
                row[1] = yVal;

                table.Rows.Add(row);
            }
            return table;
        }
#endregion        

        #region SetStripLine
        protected void SetStripLine(double start, double end)
        {
            //Chart Strip Lines
            if (this.chartControl1.PrimaryXAxis.StripLines.Count >= 0)
                this.chartControl1.PrimaryXAxis.StripLines.Clear();
            ChartStripLine stripLine = new ChartStripLine();
            stripLine.Enabled = true;
            stripLine.Vertical = false;
            stripLine.Start = start;
            stripLine.End = end;
            stripLine.Text = " ";
            stripLine.Width = 250;
            stripLine.Period = 1;
            stripLine.Interior = new BrushInfo(GradientStyle.Horizontal, stripLineColor);
            this.chartControl1.PrimaryXAxis.StripLines.Add(stripLine);
        }
        #endregion

        #region UpdateChartSubTitles
        private void UpdateChartSubTitles()
        {
            this.chartControl1.Title.Text = "High Level Chart - Compression Ratio " + ((ChartOversizedDataBindModel)this.chartControl1.Series[0].SeriesModel).DilutionFactor.ToString()
                                               + " : 1";

            this.chartControl2.Title.Text = "Low Level Chart - Compression Ratio " + ((ChartOversizedDataBindModel)this.chartControl2.Series[0].SeriesModel).DilutionFactor.ToString()
                                                + " : 1";
        }
        #endregion
        #endregion

        #region Events
        private void chartControl1_VisibleRangeChanged(object sender, EventArgs e)
        {
            // Called when the user is done selecting an area in the master chart
            if (this.chartControl1.ZoomFactorX != 1)
            {
                double x1 = this.chartControl1.ZoomPositionX * this.chartControl1.PrimaryXAxis.Range.Max;
                double x2 = x1 + (this.chartControl1.ZoomFactorX * this.chartControl1.PrimaryXAxis.Range.Max);

                this.SetChartRange(this.chartControl2.PrimaryXAxis, new MinMaxInfo(x1, x2, (x2 - x1) / 10));

                ((ChartOversizedDataBindModel)this.chartControl2.Series[0].SeriesModel).Recaliberate();

                SetStripLine(x1, x2);
            }
            // Resetting it to 1 to cancel zooming
            if (this.chartControl1.ZoomFactorX != 1)
                this.chartControl1.ZoomFactorX = 1;

            if (this.chartControl1.ZoomFactorY != 1)
                this.chartControl1.ZoomFactorY = 1;            
        }

        void model_DilutionFactorChanged(object sender, EventArgs e)
        {
            this.UpdateChartSubTitles();
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            int height = this.panel1.Height/2;
            this.chartControl1.Height = height - 10;
            this.chartControl2.Height = height - 10;
        }
        #endregion

        private void chartControl1_Click(object sender, EventArgs e)
        {

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
