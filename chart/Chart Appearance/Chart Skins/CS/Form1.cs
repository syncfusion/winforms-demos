#region Copyright Syncfusion Inc. 2001 - 2010
//
//  Copyright Syncfusion Inc. 2001 - 2010. All rights reserved.
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

using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms;

namespace EssentialChartSamples
{
    public class Form1 : MetroForm
    {
        #region Private Members

        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        Color[] color1 = new Color[] { Color.FromArgb(192, 126, 44), Color.FromArgb(255, 221, 158), Color.FromArgb(192, 126, 44) };
        Color[] color2 = new Color[] { Color.FromArgb(118, 147, 58), Color.FromArgb(200, 224, 150), Color.FromArgb(118, 147, 58) };
        private Panel panel1;
        private Label label1;
        private Label label12;
        private ComboBox comboBox1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        #endregion

        #region Form Constructor, Main, Dispose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.BorderAppearance.BaseColor = System.Drawing.Color.Moccasin;
            this.chartControl1.BorderAppearance.FrameThickness = new Syncfusion.Windows.Forms.Chart.ChartThickness(15F, 15F, 15F, 15F);
            this.chartControl1.BorderAppearance.Interior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.BorderColor = System.Drawing.Color.Transparent;
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.chartControl1.DataSourceName = "";
            this.chartControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Location = new System.Drawing.Point(581, 75);
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Metro;
            this.chartControl1.PrimaryXAxis.EdgeLabelsDrawingMode = Syncfusion.Windows.Forms.Chart.ChartAxisEdgeLabelsDrawingMode.Shift;
            this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.LightGray;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryXAxis.Title = "Year";
            this.chartControl1.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.chartControl1.PrimaryYAxis.ForceZero = true;
            this.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.LightGray;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Range = new Syncfusion.Windows.Forms.Chart.MinMaxInfo(0D, 600D, 100D);
            this.chartControl1.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set;
            this.chartControl1.PrimaryYAxis.Title = "Sales $";
            this.chartControl1.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.chartControl1.Size = new System.Drawing.Size(700, 587);
            this.chartControl1.Skins = Syncfusion.Windows.Forms.Chart.Skins.Metro;
            this.chartControl1.Style3D = true;
            this.chartControl1.TabIndex = 1;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.chartControl1.Title.Margin = 1;
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ZoomOutIncrement = 0.20000000298023224D;
            // 
            // panel1
            // 
            this.panel1.Dock = DockStyle.Right;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(700, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 590);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 102;
            this.label1.Text = "Skins";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label12.Location = new System.Drawing.Point(38, 75);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(102, 23);
            this.label12.TabIndex = 100;
            this.label12.Text = "Chart Skins";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox1.Location = new System.Drawing.Point(41, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 28);
            this.comboBox1.TabIndex = 101;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 584);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(494, 456);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skins";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Form_Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            // Creates series and associate with the Chart control
            InitializeChartData();

            this.comboBox1.DataSource = Enum.GetNames(typeof(Skins));
            this.comboBox1.SelectedIndex = 15;


        }
        #endregion

        #region Helper Methods

        #region InitializeChartData
        /// <summary>
        /// Initializes Chart Data
        /// </summary>
        private void InitializeChartData()
        {
            this.chartControl1.Series.Clear();

            ChartSeries Series = new ChartSeries();

            Series.Name = "Sales";
            Series.Style.DisplayText = true;
            Series.Style.TextOrientation = ChartTextOrientation.RegionUp;           
            Series.Points.Add(1995, 370);
            Series.Points.Add(1996, 420);
            Series.Points.Add(1997, 330);
            Series.Points.Add(1998, 440);
            Series.Points.Add(1999, 230);
            Series.Points.Add(2000, 300);
            Series.Type = ChartSeriesType.Scatter;
            Series.Text = Series.Name;
            this.chartControl1.Series.Add(Series);

            //Legend Customization. 
            for (int i = 0; i < chartControl1.Legend.Items.Length; i++)
            {
                chartControl1.Legend.Items[i].Spacing = 4;
                chartControl1.Legend.ItemsSize = new Size(13, 13);
                chartControl1.Legend.BackColor = Color.Transparent;
                chartControl1.LegendsPlacement = ChartPlacement.Outside;
                chartControl1.LegendAlignment = ChartAlignment.Center;
                chartControl1.LegendPosition = ChartDock.Bottom;
                chartControl1.Legend.Font = new Font("Segoe UI", 12f);
            }   

        }
        /// <summary>
        /// Adjusts the series and axis based on the  skin format.
        /// </summary>
        /// <param name="skins">The skins.</param>
        private void AdjustFormat(Skins skins)
        {
            Color ForeColor = new Color();
            Color[] SeriesPoint1Color = new Color[] { Color.Black, Color.Black };
            Color[] SeriesPoint2Color = new Color[] { Color.Black, Color.Black };
            Color[] SeriesPoint3Color = new Color[] { Color.Black, Color.Black };
            SetSkins(skins, out ForeColor, out SeriesPoint1Color, out SeriesPoint2Color, out SeriesPoint3Color);

            if (ForeColor != Color.Transparent)
            {
                for (int i = 0; i < chartControl1.Axes.Count - 1; i++)
                {
                    chartControl1.Axes[i].ForeColor = ForeColor;
                    chartControl1.Axes[i].TitleColor = ForeColor;
                    chartControl1.Axes[i].LineType.ForeColor = ForeColor;
                    chartControl1.Axes[i].GridLineType.ForeColor = Color.FromArgb(50, ForeColor);
                    chartControl1.Axes[i].Font = new Font("Segoe UI", 9, FontStyle.Regular);
                    chartControl1.Axes[i].TitleFont = new Font("Segoe UI", 14, FontStyle.Regular);
                }


                chartControl1.ForeColor = ForeColor;
            }
            if (SeriesPoint1Color.Length > 0)
            {
                for (int i = 0; i < chartControl1.Series.Count; i++)
                {
                    if (i % 3 == 0)
                    {
                        chartControl1.Series[i].Style.Border.Color = SeriesPoint1Color[0];
                        chartControl1.Series[i].Style.Interior = new BrushInfo(GradientStyle.Vertical, SeriesPoint1Color);
                    }
                    if (i % 3 == 1)
                    {
                        chartControl1.Series[i].Style.Border.Color = SeriesPoint2Color[0];
                        chartControl1.Series[i].Style.Interior = new BrushInfo(GradientStyle.Vertical, SeriesPoint2Color);
                    }
                    if (i % 3 == 2)
                    {
                        chartControl1.Series[i].Style.Border.Color = SeriesPoint3Color[0];
                        chartControl1.Series[i].Style.Interior = new BrushInfo(GradientStyle.Vertical, SeriesPoint3Color);
                    }
                }
            }
        }
        /// <summary>
        /// find out the color for the series . 
        /// </summary>
        /// <param name="Skins">The skins.</param>
        /// <param name="ForeColor">Color of the fore.</param>
        /// <param name="SeriesPoint1Color">Color of the series point1.</param>
        /// <param name="SeriesPoint2Color">Color of the series point2.</param>
        /// <param name="SeriesPoint3Color">Color of the series point3.</param>
        public void SetSkins(Skins Skins, out Color ForeColor, out Color[] SeriesPoint1Color, out Color[] SeriesPoint2Color, out Color[] SeriesPoint3Color)
        {
            ForeColor = Color.Transparent;
            ColorConverter ColorConv = new ColorConverter();
            switch (Skins)
            {
                case Skins.None:
                    SeriesPoint1Color = new Color[] { };
                    SeriesPoint2Color = new Color[] { };
                    SeriesPoint3Color = new Color[] { };
                    break;
                case Skins.Office2007Blue:
                    ForeColor = (Color)ColorConv.ConvertFromString("#FF15428B");
                    SeriesPoint1Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF3F6C91"), (Color)ColorConv.ConvertFromString("#FF4F81A6") };
                    SeriesPoint2Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF4E80A5"), (Color)ColorConv.ConvertFromString("#FF6795B4") };
                    SeriesPoint3Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF6F9BBA"), (Color)ColorConv.ConvertFromString("#FFACC6D8") };
                    break;
                case Skins.Office2007Black:
                    ForeColor = Color.Black;
                    SeriesPoint1Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF2A5DAB"), (Color)ColorConv.ConvertFromString("#FF6583EB"), (Color)ColorConv.ConvertFromString("#FF7391FB") };
                    SeriesPoint2Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF078FBF"), (Color)ColorConv.ConvertFromString("#FF3CBFE3"), (Color)ColorConv.ConvertFromString("#FF5FE3F5") };
                    SeriesPoint3Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF629147"), (Color)ColorConv.ConvertFromString("#FF92BC39"), (Color)ColorConv.ConvertFromString("#FFCEEB74") };
                    break;
                case Skins.Office2007Silver:
                    ForeColor = (Color)ColorConv.ConvertFromString("#FF6C6C6C");
                    SeriesPoint1Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF3B3B3B"), (Color)ColorConv.ConvertFromString("#FF555555") };
                    SeriesPoint2Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF4E4E4E"), (Color)ColorConv.ConvertFromString("#FF6D6D6D") };
                    SeriesPoint3Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF747474"), (Color)ColorConv.ConvertFromString("#FFB0B0B0") };
                    break;
                case Skins.Olive:
                    ForeColor = (Color)ColorConv.ConvertFromString("#FF6A8012");
                    SeriesPoint1Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF7F8442"), (Color)ColorConv.ConvertFromString("#FF9B9D56") };
                    SeriesPoint2Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF979952"), (Color)ColorConv.ConvertFromString("#FFACAB6D") };
                    SeriesPoint3Color = new Color[] { (Color)ColorConv.ConvertFromString("#FFB4B57B"), (Color)ColorConv.ConvertFromString("#FFD1D2AF") };
                    break;
                case Skins.Almond:
                    ForeColor = (Color)ColorConv.ConvertFromString("#FFB47A7A");
                    SeriesPoint1Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF4C2097"), (Color)ColorConv.ConvertFromString("#FF7650AC"), (Color)ColorConv.ConvertFromString("#FFBF96DD") };
                    SeriesPoint2Color = new Color[] { (Color)ColorConv.ConvertFromString("#FFE06F07"), (Color)ColorConv.ConvertFromString("#FFFE9D30"), (Color)ColorConv.ConvertFromString("#FFFDC74A") };
                    SeriesPoint3Color = new Color[] { (Color)ColorConv.ConvertFromString("#FFA83935"), (Color)ColorConv.ConvertFromString("#FFEF6860"), (Color)ColorConv.ConvertFromString("#FFF7746C") };
                    break;
                case Skins.Blend:
                    ForeColor = Color.White;
                    SeriesPoint1Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF2A5DAB"), (Color)ColorConv.ConvertFromString("#FF6583EB"), (Color)ColorConv.ConvertFromString("#FF7391FB") };
                    SeriesPoint2Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF078FBF"), (Color)ColorConv.ConvertFromString("#FF3CBFE3"), (Color)ColorConv.ConvertFromString("#FF5FE3F5") };
                    SeriesPoint3Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF629147"), (Color)ColorConv.ConvertFromString("#FF92BC39"), (Color)ColorConv.ConvertFromString("#FFCEEB74") };
                    break;
                case Skins.Blueberry:
                    ForeColor = (Color)ColorConv.ConvertFromString("#FF0D55E2");
                    SeriesPoint1Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF3F6C91"), (Color)ColorConv.ConvertFromString("#FF4F81A6") };
                    SeriesPoint2Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF4E80A5"), (Color)ColorConv.ConvertFromString("#FF6795B4") };
                    SeriesPoint3Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF6F9BBA"), (Color)ColorConv.ConvertFromString("#FFACC6D8") };
                    break;
                case Skins.Marble:
                    ForeColor = (Color)ColorConv.ConvertFromString("#FF808282");
                    SeriesPoint1Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF3B3B3B"), (Color)ColorConv.ConvertFromString("#FF555555") };
                    SeriesPoint2Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF4E4E4E"), (Color)ColorConv.ConvertFromString("#FF6D6D6D") };
                    SeriesPoint3Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF747474"), (Color)ColorConv.ConvertFromString("#FFB0B0B0") };
                    break;
                case Skins.Midnight:
                    ForeColor = Color.White;
                    SeriesPoint1Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF2A5DAB"), (Color)ColorConv.ConvertFromString("#FF6583EB"), (Color)ColorConv.ConvertFromString("#FF7391FB") };
                    SeriesPoint2Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF078FBF"), (Color)ColorConv.ConvertFromString("#FF3CBFE3"), (Color)ColorConv.ConvertFromString("#FF5FE3F5") };
                    SeriesPoint3Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF629147"), (Color)ColorConv.ConvertFromString("#FF92BC39"), (Color)ColorConv.ConvertFromString("#FFCEEB74") };

                    break;
                case Skins.Monochrome:
                    ForeColor = (Color)ColorConv.ConvertFromString("#FF112437");
                    SeriesPoint1Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF3F6C91"), (Color)ColorConv.ConvertFromString("#FF4F81A6") };
                    SeriesPoint2Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF4E80A5"), (Color)ColorConv.ConvertFromString("#FF6795B4") };
                    SeriesPoint3Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF6F9BBA"), (Color)ColorConv.ConvertFromString("#FFACC6D8") };
                    break;
                case Skins.Sandune:
                    ForeColor = (Color)ColorConv.ConvertFromString("#FF836B33");
                    SeriesPoint1Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF8C713B"), (Color)ColorConv.ConvertFromString("#FFA6854F") };
                    SeriesPoint2Color = new Color[] { (Color)ColorConv.ConvertFromString("#FFA5844E"), (Color)ColorConv.ConvertFromString("#FFB49567") };
                    SeriesPoint3Color = new Color[] { (Color)ColorConv.ConvertFromString("#FFB99C6E"), (Color)ColorConv.ConvertFromString("#FFD8C7AC") };
                    break;
                case Skins.Turquoise:
                    ForeColor = (Color)ColorConv.ConvertFromString("#FF174E53");
                    SeriesPoint1Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF3B3B3B"), (Color)ColorConv.ConvertFromString("#FF555555") };
                    SeriesPoint2Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF4E4E4E"), (Color)ColorConv.ConvertFromString("#FF6D6D6D") };
                    SeriesPoint3Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF747474"), (Color)ColorConv.ConvertFromString("#FFB0B0B0") };
                    break;
                case Skins.Vista:
                    ForeColor = Color.White;
                    SeriesPoint1Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF2C91A7"), (Color)ColorConv.ConvertFromString("#FF3AA8BD") };
                    SeriesPoint2Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF369FB5"), (Color)ColorConv.ConvertFromString("#FF55B9C9") };
                    SeriesPoint3Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF5FBECE"), (Color)ColorConv.ConvertFromString("#FFA2DCE5") };
                    break;
                case Skins.VS2010:
                    ForeColor = Color.White;
                    SeriesPoint1Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF3B3B3B"), (Color)ColorConv.ConvertFromString("#FF555555") };
                    SeriesPoint2Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF4E4E4E"), (Color)ColorConv.ConvertFromString("#FF6D6D6D") };
                    SeriesPoint3Color = new Color[] { (Color)ColorConv.ConvertFromString("#FF747474"), (Color)ColorConv.ConvertFromString("#FFB0B0B0") };
                    break;
                case Skins.Metro:
                    ForeColor = Color.Black;
                    SeriesPoint1Color = new Color[] { Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2), Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2) };
                    SeriesPoint2Color = new Color[] { Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2), Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2) };
                    SeriesPoint3Color = new Color[] { Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2), Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2) };
                    break;
                default:
                    SeriesPoint1Color = new Color[] { };
                    SeriesPoint2Color = new Color[] { };
                    SeriesPoint3Color = new Color[] { };
                    break;

            }
        }

        #endregion

        #endregion

        #region Border Settings
        /// <summary>
        /// Changes the border appearance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.Skins = (Skins)this.comboBox1.SelectedIndex;
            if (this.comboBox1.SelectedIndex == 0)
                this.chartControl1.Titles[0].Text = "Essential Chart";
            else
                this.chartControl1.Titles[0].Text = this.chartControl1.Skins.ToString() + " Skin ";
            AdjustFormat(this.chartControl1.Skins);
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
