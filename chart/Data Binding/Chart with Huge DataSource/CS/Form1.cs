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
        private ChartTitle chartTitle1;
        private System.ComponentModel.Container components = null;
        private Panel panel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Label label40;
        private Label label6;
        private ComboBox comboBox1;
        private Label label4;
        private Panel panel2;
        private ChartOversizedDataBindModel model;
        #endregion

        #region Form's Constructor, Main and Dispose
        public Form1()
        {

            BorderColor = Color.FromArgb(0xFF, 0xCD, 0xCD, 0xCD);
            BorderThickness = 3;
            CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(75.0f);
            CaptionBarColor = Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2);
            CaptionFont = new Font("Segoe UI", 22.0f);
            CaptionForeColor = Color.White;
            CaptionAlign = HorizontalAlignment.Left;
            CaptionButtonColor = Color.White;
            CaptionButtonHoverColor = Color.White;
            ShowIcon = false;
            InitializeComponent();
            this.comboBox1.SelectedIndex = 0;
            Application.EnableVisualStyles();
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
            this.chartTitle1 = new Syncfusion.Windows.Forms.Chart.ChartTitle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label40 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = DockStyle.Fill;
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Silver, System.Drawing.Color.White);
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.DataSourceName = "";
            this.chartControl1.ForeColor = System.Drawing.Color.Black;
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(58, 346);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom;
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.RangePaddingType = Syncfusion.Windows.Forms.Chart.ChartAxisRangePaddingType.None;
            this.chartControl1.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl1.Size = new System.Drawing.Size(700, 423);
            this.chartControl1.TabIndex = 1;
            this.chartControl1.Text = "Essential Chart";
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "Essential Chart";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.Titles.Add(this.chartTitle1);
            this.chartControl1.ZoomOutIncrement = 1.5D;
            this.chartControl1.VisibleRangeChanged += new System.EventHandler(this.chartControl1_VisibleRangeChanged);
            // 
            // chartTitle1
            // 
            this.chartTitle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartTitle1.Name = "chartTitle1";
            this.chartTitle1.Text = "chartTitle1";
            // 
            // panel1
            // 
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Controls.Add(this.gradientPanel2);
            this.panel1.Location = new System.Drawing.Point(12, 449);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 144);
            this.panel1.TabIndex = 5;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BackColor = System.Drawing.Color.White;
            this.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel2.Controls.Add(this.label6);
            this.gradientPanel2.Controls.Add(this.label40);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel2.Location = new System.Drawing.Point(0, -8);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(688, 152);
            this.gradientPanel2.TabIndex = 7;
            // 
            // label40
            // 
            this.label40.Dock = DockStyle.Bottom;
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label40.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label40.Location = new System.Drawing.Point(0, 32);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(680, 107);
            this.label40.TabIndex = 1;
            this.label40.Text = resources.GetString("label40.Text");
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(0, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(688, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sample Description";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "100000",
            "50000",
            "20000",
            "10000"});
            this.comboBox1.Location = new System.Drawing.Point(35, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 29);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(31, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Points";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(698, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 593);
            this.panel2.TabIndex = 4;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 593);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(704, 629);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Huge Datasource";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.chartControl1.ResumeLayout(false);
            this.chartControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {                      
            ChartAppearance.ApplyChartStyles(this.chartControl1);
           

        }
        #endregion

        #region InitializeChartData
        /// <summary>
        /// Initializes chart data from a sample data table.
        /// </summary>
        protected void InitializeChartData(int totalXValues)
        {            
            // Create a sample table:
            DataTable tableSource = this.CreateLargeTable(totalXValues);

            //Initializes new chart series.
            ChartSeries series = new ChartSeries("population", ChartSeriesType.Spline);           

            // Instantiate the Model that "dilutes" the large set of data points based on the current chart width. Instead of just skipping
            // points, this model uses an average of a set of points and uses those averages instead of the points.
            this.model = new ChartOversizedDataBindModel(this.chartControl1, tableSource, "X", "Y");

            // Update chart settings based on the Model:
            this.InitChartBasedOnModel(model);

            // Assign this data model to the new series.
            series.SeriesModel = model;          

            //Adds the series to the ChartSeriesCollection.
            this.chartControl1.Series.Add(series);          

            this.UpdateChartTitle();

            series.PrepareStyle += new ChartPrepareStyleInfoHandler(series_PrepareStyle);
            this.chartControl1.EnableXZooming = true;
            model.DilutionFactorChanged += new EventHandler(model_DilutionFactorChanged);
            this.chartControl1.ChartFormatAxisLabel += new ChartFormatAxisLabelEventHandler(ChartWebControl1_ChartFormatAxisLabel);
        }

        #endregion
       
        #region CreateLargeTable
        private DataTable CreateLargeTable(int totalXValues)
        {
            int yMax = 600;
            DateTime tempstart = new DateTime(2003, 11, 1);

            DataTable table = new DataTable();
            // It's important that the x values are marked as integer or DateTime, otherwise, the engine will treat it as strings and
            // sort them incorrectly.
            DataColumn x = new DataColumn("X", typeof(DateTime));
            table.Columns.Add(x);
            table.Columns.Add(new DataColumn("Y"));

            Random ran = new Random(DateTime.Now.Second);
            Random rany = new Random();

            for (int i = 1; i <= totalXValues; i++)
            {
                //int xVal = i;
                DateTime dtX = tempstart.AddHours(i);
                double yVal = ((double)i / totalXValues) * (yMax - 40) + ran.Next(0, 40);

                DataRow row = table.NewRow();

                //row[0] = xVal;
                row[0] = dtX;
                row[1] = yVal;

                table.Rows.Add(row);
            }
            return table;
        }
        #endregion       

        #region Events
        void ChartWebControl1_ChartFormatAxisLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            if (e.AxisOrientation == ChartOrientation.Horizontal)
            {
                // Here we customize the label text for a point by getting the text from the model:
                ChartOversizedDataBindModel model = this.chartControl1.Series[0].SeriesModel as ChartOversizedDataBindModel;

                int index = (int)e.Value;
                if (model !=null && index < model.Count)
                {
                    // The fact that the data type is DateTiem is based on our knowledge of the bound data source.
                    DateTime date = (DateTime)model.GetXData((int)e.Value);
                    e.Label = this.GetFormattedLabelText(date);
                }
                else
                    e.Label = String.Empty;

                e.Handled = true;
            }
        }
        string GetFormattedLabelText(DateTime dtX)
        {
            // This logic we use here is based on prior knowledge of the data source.
            // We know that we have 1 data point for every hour, so this logic is based on that knowledge
            if (this.model.DilutionFactor > 700) // 24 X 30 = 720
                return dtX.ToString("MMM yyyy");
            else if (this.model.DilutionFactor > 24)
                return dtX.ToString("dd MMM yyyy");
            else if (this.model.DilutionFactor > 12)
                return dtX.ToString("dd MMM yyyy tt");
            else
                return dtX.ToString("dd MMM yyyy HH") + "hrs";
        }

        private void InitChartBasedOnModel(ChartOversizedDataBindModel model)
        {
            this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.Double;
            this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryXAxis.Range = new MinMaxInfo(0, model.Count, (int)(model.Count / 10));

            this.chartControl1.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            double maxY = model.GetMaxY();
            this.chartControl1.PrimaryYAxis.Range = new MinMaxInfo(0, maxY, (int)(maxY / 10));
        }
        void series_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
        {
            // Compose the tooltip for each point:
            ChartSeries series = sender as ChartSeries;
            series.PointsToolTipFormat = "{2}";
            if (args != null)
            {
                DateTime dd = (DateTime)model.GetXData(args.Index);
                double y = this.chartControl1.Series[0].Points[args.Index].YValues[0];

                args.Style.ToolTip = "X= " + this.GetFormattedLabelText(dd) + ", Y= " + y.ToString("F01");
            }
            args.Handled = true;
        }
        //Set Data Points
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dataPoints = Convert.ToInt32(this.comboBox1.SelectedItem);
            this.chartControl1.Series.Clear();
            this.InitializeChartData(dataPoints);
        }

        void model_DilutionFactorChanged(object sender, EventArgs e)
        {
            // Could happen when chart resizes or zoomed in.
            this.UpdateChartTitle();
            ChartOversizedDataBindModel model = sender as ChartOversizedDataBindModel;
            this.chartControl1.PrimaryXAxis.Range = new MinMaxInfo(0, model.Count, (int)(model.Count / 10));
        }

        private void UpdateChartTitle()
        {
            this.chartControl1.Text = "Compression Ratio - " +
                                                ((ChartOversizedDataBindModel)this.chartControl1.Series[0].SeriesModel).DilutionFactor.ToString() +
                                                " : 1";
            this.chartTitle1.Text = "Number of data points: " + this.comboBox1.SelectedItem.ToString();
        }
		private void chartControl1_VisibleRangeChanged(object sender, EventArgs e)
        {
            this.model.RangeChanged(Convert.ToDouble(this.comboBox1.SelectedItem));
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