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
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;

namespace DateDataBinding
{
    public class Form1 : MetroForm
    {
        #region Private Members
        private DataSet prodDs1;
        DateTime lastTime = DateTime.Now;
        private ChartControl chartControl1;
        private System.ComponentModel.Container components = null;      

        #endregion

        #region Form Constructor, Main And Dispose
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
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.DataSourceName = "";
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Location = new System.Drawing.Point(829, 75);
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(8, 8);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.BreakInfo.LineSpacing = 3D;
            this.chartControl1.PrimaryXAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight;
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.BreakInfo.LineSpacing = 3D;
            this.chartControl1.PrimaryYAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.PrimaryYAxis.ForceZero = true;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Range = new Syncfusion.Windows.Forms.Chart.MinMaxInfo(0D, 500D, 100D);
            this.chartControl1.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set;
            this.chartControl1.Size = new System.Drawing.Size(938, 564);
            this.chartControl1.TabIndex = 1;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 584);
            this.Controls.Add(this.chartControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(485, 387);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data from DataSet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }
        #endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            CreateDataSet();
            InitializeChart();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            this.chartControl1.Dock = DockStyle.Fill;


        }
        #endregion

        #region Helper Methods
     
        #region InitializeChart
        protected void InitializeChart()
        {
            ChartSeries series = new ChartSeries();
            series.Name = "Products";
            series.Text = series.Name;
            ChartDataBindModel model = new ChartDataBindModel(this.prodDs1, "Products");
            model.XName = "ExpiresDate";
            model.YNames = new string[] { "Quantity" };
            series.SeriesModel = model;
            series.Type = ChartSeriesType.Column;     
            series.Style.Border.Color = Color.FromArgb(124, 83, 153);
            series.Style.DisplayShadow = false;
            this.chartControl1.Series.Add(series);  
            DateTime start = DateTime.Now;
            DateTime end = start.AddMonths(3);         
            this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(start, end, 1, ChartDateTimeIntervalType.Months);
        }
        #endregion

        #region CreateDataSet
        private void CreateDataSet()
        {
            string tableName = "Products";
            prodDs1 = new DataSet();
            prodDs1.Tables.Add(tableName);

            DataColumn ExpiresDate = prodDs1.Tables[tableName].Columns.Add("ExpiresDate", typeof(System.DateTime));
            DataColumn Quantity = prodDs1.Tables[tableName].Columns.Add("Quantity", typeof(double));
            Random rand = new Random();
            if (prodDs1 != null && prodDs1.Tables.Count > 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    DataRow drEmpty = prodDs1.Tables[tableName].NewRow();
                    prodDs1.Tables[tableName].Rows.Add(drEmpty);
                    int count = Math.Max(0, prodDs1.Tables[tableName].Rows.Count - 1);
                    prodDs1.Tables[tableName].Rows[count]["Quantity"] = (double)rand.Next(10, 400);
                    prodDs1.Tables[tableName].Rows[count]["ExpiresDate"] = lastTime.AddDays(10);
                    lastTime = (DateTime)prodDs1.Tables[tableName].Rows[count]["ExpiresDate"];
                }
            }
        }
        #endregion
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
