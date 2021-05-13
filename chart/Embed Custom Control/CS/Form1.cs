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

using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
namespace Syncfusion.Windows.Forms.Chart.Samples
{
    public class Form1 : Syncfusion.Windows.Forms.MetroForm
    {
        #region Private Members
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private ChartDockControl chartDockControl1;
        private int count = 0;
        private DataTable dt;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private Label label10;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        #endregion

        #region Form's Constructor, Main and Dispose
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
            Application.EnableVisualStyles();
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
            this.label10 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.ChartArea.BorderColor = System.Drawing.Color.Transparent;
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10);
            this.chartControl1.DataSourceName = "";
            this.chartControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(89, 472);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom;
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.LightGray;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryXAxis.Title = "Month";
            this.chartControl1.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.LightGray;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Title = "Sales in Millions";
            this.chartControl1.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.chartControl1.Size = new System.Drawing.Size(700, 580);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "Fruit Production Statistics";
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "Fruit Production Statistics";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label10.Location = new System.Drawing.Point(43, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Table Position";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.radioButton2.Location = new System.Drawing.Point(48, 95);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 26);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bottom";
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.radioButton1.Location = new System.Drawing.Point(48, 63);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 26);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "Top";
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Dock = DockStyle.Right;
            this.gradientPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gradientPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.gradientPanel1.BorderColor = System.Drawing.Color.White;
            this.gradientPanel1.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel1.Controls.Add(this.label10);
            this.gradientPanel1.Controls.Add(this.radioButton1);
            this.gradientPanel1.Controls.Add(this.radioButton2);
            this.gradientPanel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel1.Location = new System.Drawing.Point(700, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(260, 585);
            this.gradientPanel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Dock = DockStyle.Bottom;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(83, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 204);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 581);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(545, 470);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Embedding Custom Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Form Load

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.dataGridView1.ColumnCount = 0;
            this.chartDockControl1 = new ChartDockControl(this.dataGridView1);
            this.chartDockControl1.Alignment = ChartAlignment.Center;
            this.chartDockControl1.Orientation = ChartOrientation.Horizontal;
            this.chartDockControl1.Position = ChartDock.Bottom;
            this.chartControl1.Controls.Add(chartDockControl1);
            this.chartControl1.DockingManager.Add(this.chartDockControl1);
            this.dataGridView1.Size = new Size(this.chartControl1.Width - 93, this.chartControl1.Height - 295);
            InitializeChartData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            PopulateDataGrid();
            this.chartControl1.Dock = DockStyle.Fill;


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
            series1.Type = ChartSeriesType.StackingColumn;
            series1.Name = "Banana";
            series1.Text = "Banana";

            series1.Points.Add(1, 35);
            series1.Points.Add(2, 30);
            series1.Points.Add(3, 25);
            series1.Points.Add(4, 20);
            series1.Points.Add(5, 15);
            series1.Points.Add(6, 10);
            series1.Points.Add(7, 5);
            series1.Points.Add(8, 15);
            series1.Points.Add(9, 20);
            series1.Points.Add(10, 25);
            series1.Points.Add(11, 30);
            series1.Points.Add(12, 35);
            this.chartControl1.Series.Add(series1);
            ///////

            ChartSeries series2 = new ChartSeries();
            series2.Type = ChartSeriesType.StackingColumn;
            series2.Name = "Apple";
            series2.Text = "Apple";

            series2.Points.Add(1, 25);
            series2.Points.Add(2, 20);
            series2.Points.Add(3, 18);
            series2.Points.Add(4, 17);
            series2.Points.Add(5, 15);
            series2.Points.Add(6, 10);
            series2.Points.Add(7, 5);
            series2.Points.Add(8, 7);
            series2.Points.Add(9, 10);
            series2.Points.Add(10, 15);
            series2.Points.Add(11, 20);
            series2.Points.Add(12, 25);
            this.chartControl1.Series.Add(series2);


            ChartSeries series3 = new ChartSeries();
            series3.Type = ChartSeriesType.StackingColumn;
            series3.Name = "Orange";
            series3.Text = "Orange";
            series3.Points.Add(1, 40);
            series3.Points.Add(2, 35);
            series3.Points.Add(3, 30);
            series3.Points.Add(4, 25);
            series3.Points.Add(5, 20);
            series3.Points.Add(6, 15);
            series3.Points.Add(7, 10);
            series3.Points.Add(8, 15);
            series3.Points.Add(9, 20);
            series3.Points.Add(10, 25);
            series3.Points.Add(11, 30);
            series3.Points.Add(12, 35);
            this.chartControl1.Series.Add(series3);
        }
        #endregion

        #region Populate Data Grid
        /// <summary>
        /// Populate the DataGrid with series values as data
        /// </summary>
        string[] strMonth = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        protected void PopulateDataGrid()
        {
            dt = new DataTable("SeriesValue");
            DataColumn ser = dt.Columns.Add("Fruits", typeof(String));
            for (int j = 0; j < this.chartControl1.Series[0].Points.Count; j++)
            {
                DataColumn dc = dt.Columns.Add(strMonth[j].ToString(), typeof(double));
            }
            for (int i = 0; i < this.chartControl1.Series.Count; i++)
            {
                ChartSeries series = this.chartControl1.Series[i];
                if (dt != null)
                {
                    DataRow dr = dt.NewRow();
                    dt.Rows.Add(dr);
                    count = Math.Max(0, dt.Rows.Count - 1);
                    if (count == 0)
                        dt.Rows[count]["Fruits"] = "Banana";
                    if (count == 1)
                        dt.Rows[count]["Fruits"] = "Apple";
                    if (count == 2)
                        dt.Rows[count]["Fruits"] = "Orange";
                    for (int j = 0; j < series.Points.Count; j++)
                        dt.Rows[count][strMonth[j]] = series.Points[j].YValues[0];
                }

            }
            this.dataGridView1.DataMember = "SeriesValue";

            this.dataGridView1.DataSource = dt;
            foreach (DataGridViewColumn column in this.dataGridView1.Columns)
            {
                column.Width = 28;
            }
            this.dataGridView1.Columns[0].Width = 60;
            this.dataGridView1.Width = 600;
            this.dataGridView1.Height = 150;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Columns[0].ReadOnly = true;
            this.dataGridView1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.dataGridView1.BackgroundColor = Color.White;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(147, 206, 242);
            this.dataGridView1.Columns[0].DefaultCellStyle.BackColor = Color.FromArgb(0, 159, 222);
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

        }
        #endregion

        #region UpdateChartSeries()

        /// <summary>
        /// This updates the chart with the changed values
        /// </summary>
        protected void UpdateChartSeries()
        {
            try
            {
                int seriesCount = this.dataGridView1.SelectedCells[0].RowIndex;
                int ColCount = this.dataGridView1.SelectedCells[0].ColumnIndex;
                double pointValue = Convert.ToDouble(this.dataGridView1.SelectedCells[0].Value);
                this.chartControl1.Series[seriesCount].Points[ColCount - 1].YValues[0] = pointValue;
                this.chartControl1.Refresh();
            }
            catch
            { }
        }
        #endregion

        #endregion

        #region Events

        private void radioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.radioButton1.Checked)
                this.chartDockControl1.Position = ChartDock.Top;
            else
                this.chartDockControl1.Position = ChartDock.Bottom;
        }

        private void Form1_SizeChanged(object sender, System.EventArgs e)
        {
            this.dataGridView1.Width = this.chartControl1.Width - 50;
            foreach (DataGridViewColumn column in this.dataGridView1.Columns)
            {
                column.Width = this.chartControl1.Width/16;
            }
            this.dataGridView1.Columns[0].Width = this.chartControl1.Width / 7;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            UpdateChartSeries();
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