using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms;
using Syncfusion.Drawing;

namespace ChartDataBinding
{
    public partial class Form1 : MetroForm
    {
        #region Members
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.Windows.Forms.ButtonAdv btnTop3;
        private ButtonAdv buttonAdv1;
        private System.ComponentModel.IContainer components = null;
        #endregion

        public Form1()
        {
            BorderColor = Color.FromArgb(0xFF, 0xCD, 0xCD, 0xCD);
            BorderThickness = 3;
            CaptionBarHeight = 75;
            CaptionBarColor = Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2);
            CaptionFont = new Font("Segow UI", 22.0f);
            CaptionForeColor = Color.White;
            CaptionAlign = HorizontalAlignment.Left;
            ShowIcon = false;
            CaptionButtonColor = Color.White;
            CaptionButtonHoverColor = Color.White;
            InitializeComponent();
            //Setup a database.
            PopulationDataService.PopulateDataBase();
        }

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
            this.label2 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnTop3 = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.BackwardDiagonal, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.BorderColor = System.Drawing.Color.Transparent;
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(1, 4, 5, 1);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.chartControl1.DataSourceName = "";
            this.chartControl1.ElementsSpacing = 0;
            this.chartControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Center;
            this.chartControl1.Legend.ItemsSize = new System.Drawing.Size(15, 15);
            this.chartControl1.Legend.Location = new System.Drawing.Point(194, 52);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top;
            this.chartControl1.Legend.Spacing = 3;
            this.chartControl1.Legend.Visible = false;
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(5, 12);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.PrimaryXAxis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.LightGray;
            this.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.DarkGray;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.PrimaryYAxis.ForceZero = true;
            this.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.LightGray;
            this.chartControl1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.DarkGray;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.chartControl1.Size = new System.Drawing.Size(689, 560);
            this.chartControl1.Skins = Syncfusion.Windows.Forms.Chart.Skins.Metro;
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "Binding To Linq Datasource";
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 155);
            this.label2.TabIndex = 4;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.White;
            this.gradientPanel1.BorderColor = System.Drawing.Color.White;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gradientPanel1.Location = new System.Drawing.Point(781, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(177, 584);
            this.gradientPanel1.TabIndex = 7;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gradientPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.gradientPanel2.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None;
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel2.Controls.Add(this.buttonAdv1);
            this.gradientPanel2.Controls.Add(this.btnTop3);
            this.gradientPanel2.Controls.Add(this.label2);
            this.gradientPanel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel2.Location = new System.Drawing.Point(700, 0);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(260, 590);
            this.gradientPanel2.TabIndex = 6;
            this.gradientPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel2_Paint);
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(116, 31);
            this.buttonAdv1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.KeepFocusRectangle = false;
            this.buttonAdv1.Location = new System.Drawing.Point(76, 208);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(116, 31);
            this.buttonAdv1.TabIndex = 97;
            this.buttonAdv1.Text = "REFRESH";
            this.buttonAdv1.UseVisualStyle = true;
            this.buttonAdv1.Visible = false;
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // btnTop3
            // 
            this.btnTop3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnTop3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTop3.BeforeTouchSize = new System.Drawing.Size(168, 31);
            this.btnTop3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTop3.ForeColor = System.Drawing.Color.White;
            this.btnTop3.IsBackStageButton = false;
            this.btnTop3.KeepFocusRectangle = false;
            this.btnTop3.Location = new System.Drawing.Point(48, 208);
            this.btnTop3.Name = "btnTop3";
            this.btnTop3.Size = new System.Drawing.Size(168, 31);
            this.btnTop3.TabIndex = 7;
            this.btnTop3.Text = "FILTER TOP 3 CITIES";
            this.btnTop3.UseVisualStyle = true;
            this.btnTop3.Click += new System.EventHandler(this.btnTop3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 584);
            this.Controls.Add(this.gradientPanel2);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.chartControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(701, 359);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LINQ DataSource";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        #region Main Function
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        #endregion

        #region Dispose
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion

        #region InitializeChart
        private void Form1_Load(object sender, EventArgs e)
        {
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            //Bind the chart to a datasource that contains the entire records from the database.
            this.BindChart(PopulationDataService.GetCompleteList());
        }
        #endregion

        #region Update ChartDataRange
        private void btnTop3_Click(object sender, EventArgs e)
        {
            this.buttonAdv1.Visible = true;
            btnTop3.Visible = false;
            //Filter the records based on a constraint and bound them to the chart control.
            object datasource = PopulationDataService.GetFilteredData();
            //Refresh the chart with the above datasource.
            this.BindChart(datasource);
        }
        #endregion

        #region ChartDataBinding
        //This method binds the chart to a given datasource.
        private void BindChart(object populations)
        {
            this.chartControl1.Series.Clear();
            ChartSeries series = new ChartSeries("Populations");
            ChartDataBindModel dataSeriesModel = new ChartDataBindModel(populations);

            // If ChartDataBindModel.XName is empty or null, X value is index of point.
            dataSeriesModel.YNames = new string[] { "Population" };
            series.SeriesModel = dataSeriesModel;
            series.Style.Border.Color = Color.Transparent;
            ChartDataBindAxisLabelModel dataLabelsModel = new ChartDataBindAxisLabelModel(populations);
            dataLabelsModel.LabelName = "City";
            chartControl1.Series.Add(series);
            chartControl1.PrimaryXAxis.LabelsImpl = dataLabelsModel;         
        }
        #endregion

        private void gradientPanel2_Paint(object sender, PaintEventArgs e)
        {
          
            
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            btnTop3.Visible = true;
            buttonAdv1.Visible = false;
            this.BindChart(PopulationDataService.GetCompleteList());
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
