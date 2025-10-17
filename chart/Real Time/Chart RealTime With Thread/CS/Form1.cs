#region Copyright Syncfusion Inc. 2001 - 2019
//
//  Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
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
using System.Threading;

namespace Syncfusion.Windows.Forms.Chart.Samples
{
    public class Form1 : MetroForm
    {
        #region Private Members
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Panel panel1;
        private Button btnStop;
        private Button btnStart;
        private Label label6;
        private Label label40;
        private Panel panel2;

        DateTime lastTime = DateTime.Now;
        #endregion

        #region Form Constructor, Main And Dispose
        public Form1()
        {
            BorderColor = Color.FromArgb(0xFF, 0xCD, 0xCD, 0xCD);
            BorderThickness = 3;
            CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(75.0f);
            CaptionBarColor = Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2);
            CaptionFont = new Font("Segow UI", 22.0f);
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label40 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.DataSourceName = "";
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.Legend.Location = new System.Drawing.Point(85, 419);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom;
            this.chartControl1.Legend.Visible = false;
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.Gray;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.Rotation = 0.1F;
            this.chartControl1.Size = new System.Drawing.Size(700, 492);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "Syncfusion Essential Chart";
            this.chartControl1.Tilt = 0.1F;
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "Syncfusion Essential Chart";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label40);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 498);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 85);
            this.panel1.TabIndex = 1;
            // 
            // label40
            // 
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label40.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label40.Location = new System.Drawing.Point(3, 36);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(697, 42);
            this.label40.TabIndex = 7;
            this.label40.Text = "Points are added by thread for each one second. The last 20 seconds points are on" +
    "ly visible in chart, other invisible points are removed from chart series to imp" +
    "rove performance of chart.\r\n";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(4, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(688, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sample Description";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(48, 83);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(137, 34);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Green;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(48, 36);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(137, 34);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Location = new System.Drawing.Point(700, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 590);
            this.panel2.TabIndex = 2;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 584);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(553, 516);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Real Time Scenario using Thread";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
      
        private Thread addRealData;
        public delegate void AddDataDelegate();
        public AddDataDelegate addDataDel;
        private ManualResetEvent run;
        Random rand = new Random();
        private DateTime minValue;
        private DateTime maxValue;
        ThreadStart Start;
        DateTime timeStamp = DateTime.Now;

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            //Create a new single thread to add points to chart series
            Start = new ThreadStart(DataThreadLoop);
            addRealData = new Thread(Start);
            addDataDel += new AddDataDelegate(AddChartData);
            run = new ManualResetEvent(true);
            InitializeChart();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }
        #endregion

        #region Helper Method
        void InitializeChart()
        {
            minValue = timeStamp;
            maxValue = minValue.AddSeconds(30);
            chartControl1.Series.Clear();
            chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime;
            chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(minValue, maxValue, 10, ChartDateTimeIntervalType.Seconds);
            chartControl1.PrimaryXAxis.DateTimeFormat = "HH:mm:ss";
            this.chartControl1.ShowLegend = false;
            ChartSeries series = new ChartSeries("Spline");
            series.Type = ChartSeriesType.Spline;
            for (int i = 0; i <= 30; i++)
            {
                timeStamp = timeStamp.AddSeconds(i);
                series.Points.Add(timeStamp, rand.Next(2, 17));
            }
            
            series.Style.Border.Width = 2;
            //series.Style.Symbol.Shape = ChartSymbolShape.Circle;
            chartControl1.Series.Add(series);
            
           this.btnStart_Click(null, EventArgs.Empty);
        }

       private void DataThreadLoop()
        {
            try
            {
                while (true)
                {
                    run.WaitOne();
                    // Invoke method used to interact with the chart control on the form
                    chartControl1.Invoke(addDataDel);

                    // Thread is inactive for 200ms
                    Thread.Sleep(200);
                }
            }
            catch
            {
                // Thread is aborted
            }
        }
        /// <summary>
        /// AddChartData Method invoked from the thread to add series points
        /// </summary>
        public void AddChartData()
        {
            timeStamp = timeStamp.AddSeconds(1);
            foreach (ChartSeries Series in this.chartControl1.Series)
            {
                AddNewPoint(timeStamp, Series);
            }
        }
        public void AddNewPoint(DateTime timeStamp, ChartSeries Series)
        {
            // Add new data point to series.
            Series.Points.Add(timeStamp, rand.Next(3, 17));
          
            //// remove all points from the source series older than 30 seconds.
            double removePointVal = timeStamp.AddSeconds((double)(30) * (-1)).ToOADate();


            while (Series.Points[0].DateX.ToOADate() < removePointVal)
            {
                Series.Points.RemoveAt(0);
            }
            chartControl1.PrimaryXAxis.Range.Min = Series.Points[0].DateX.ToOADate();
            chartControl1.PrimaryXAxis.Range.Max = Series.Points[0].DateX.AddSeconds(30).ToOADate();
        }
       
        private void btnStart_Click(object sender, EventArgs e)
        {
            // Disable the Stop button on the form
            btnStart.Enabled = false;
            // Enable the Stop button on the form
            btnStop.Enabled = true;       

            // start worker threads.
            if (addRealData.IsAlive == true)
            {
                run.Set();
            }
            else
            {
                addRealData.Start();
            }  

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
       
			// Suspend thread
            if (addRealData.IsAlive == true)
			{
                run.Reset();
            }

			// Enable start button on the form
            btnStart.Enabled = true;

			// Disable the Stop button
            btnStop.Enabled = false;

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