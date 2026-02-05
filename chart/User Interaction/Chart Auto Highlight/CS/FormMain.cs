
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
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;

namespace Syncfusion.Windows.Forms.Chart.Samples
{
    /// <summary>
    /// The ChartControl sample form.
    /// </summary>
    public class FormMain : MetroForm
    {
        #region Private Members
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxAutoHighlight;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton1;
        ChartSeries series1;
        private Label label22;
        private Panel panel2;
        #endregion
        private Panel panel3;
        private Label label1;
        private IContainer components;

        #region Form's  Constructor, Main And Dispose
        public FormMain()
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.colorPickerButton1 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxAutoHighlight = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(226))))), System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(232)))), ((int)(((byte)(243))))));
            this.chartControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chartControl1.DataSourceName = "";
            this.chartControl1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(58, 409);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom;
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(12, 12);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl1.Size = new System.Drawing.Size(650, 486);
            this.chartControl1.TabIndex = 2;
            this.chartControl1.Text = "Essential Chart";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "Essential Chart";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ZoomOutIncrement = 1.5D;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBoxAutoHighlight);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel1.Location = new System.Drawing.Point(700, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 590);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Controls.Add(this.colorPickerButton1);
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Location = new System.Drawing.Point(22, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 161);
            this.panel3.TabIndex = 6;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label22.Location = new System.Drawing.Point(27, 7);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(116, 21);
            this.label22.TabIndex = 4;
            this.label22.Text = "Highlight Color";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.radioButton1.Location = new System.Drawing.Point(30, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(102, 25);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Automatic";
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.BackColor = System.Drawing.Color.Transparent;
            this.colorPickerButton1.BeforeTouchSize = new System.Drawing.Size(100, 30);
            this.colorPickerButton1.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.colorPickerButton1.IsBackStageButton = false;
            this.colorPickerButton1.Location = new System.Drawing.Point(30, 107);
            this.colorPickerButton1.Name = "colorPickerButton1";
            this.colorPickerButton1.SelectedAsBackcolor = true;
            this.colorPickerButton1.SelectedColor = System.Drawing.Color.Transparent;
            this.colorPickerButton1.Size = new System.Drawing.Size(100, 30);
            this.colorPickerButton1.TabIndex = 2;
            this.colorPickerButton1.UseVisualStyleBackColor = false;
            this.colorPickerButton1.ColorSelected += new System.EventHandler(this.Color_Selected);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.radioButton2.Location = new System.Drawing.Point(30, 70);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 25);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Specific";
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(49, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Highlight";
            // 
            // checkBoxAutoHighlight
            // 
            this.checkBoxAutoHighlight.AutoSize = true;
            this.checkBoxAutoHighlight.Checked = true;
            this.checkBoxAutoHighlight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoHighlight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxAutoHighlight.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxAutoHighlight.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAutoHighlight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBoxAutoHighlight.Location = new System.Drawing.Point(54, 71);
            this.checkBoxAutoHighlight.Name = "checkBoxAutoHighlight";
            this.checkBoxAutoHighlight.Size = new System.Drawing.Size(66, 25);
            this.checkBoxAutoHighlight.TabIndex = 0;
            this.checkBoxAutoHighlight.Text = "Auto";
            this.checkBoxAutoHighlight.CheckedChanged += new System.EventHandler(this.checkBoxAutoHighlight_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.chartControl1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 580);
            this.panel2.TabIndex = 4;
            // 
            // FormMain
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 581);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.MinimumSize = new System.Drawing.Size(527, 488);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Highlight ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Form Load
        private void FormMain_Load(object sender, System.EventArgs e)
        {
            InitializeChartData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
| System.Windows.Forms.AnchorStyles.Left)
| System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
| System.Windows.Forms.AnchorStyles.Left)
| System.Windows.Forms.AnchorStyles.Right)));
            
        }
        #endregion

        #region InitializeChartData
        /// <summary>
        /// Initializes the ChartControl's data and sets the Chart type
        /// </summary>
        protected void InitializeChartData()
        {
            Random random = new Random();

            series1 = new ChartSeries("Market");
            series1.Name = "Market";
            series1.Text = series1.Name;
            series1.Points.Add(0, 16);
            series1.Points.Add(1, 10);
            series1.Points.Add(2, 13);
            series1.Points.Add(3, 7);
            series1.Points.Add(4, 11);
            series1.Points.Add(5, 18);
            series1.Points.Add(6, 10);
            series1.Points.Add(7, 15);

            series1.Type = ChartSeriesType.Pie;
            series1.Style.Border.Color = Color.Transparent;
            this.chartControl1.AutoHighlight = this.checkBoxAutoHighlight.Checked;
            this.chartControl1.Series.Add(series1);
            series1.Style.DisplayText = true;
            series1.Style.TextColor = Color.Black;
            this.chartControl1.SmoothingMode = SmoothingMode.AntiAlias;
            series1.Styles[0].Text = string.Format("Production {0}%", series1.Points[0].YValues[0]);
            series1.Styles[1].Text = string.Format("Labor {0}%", series1.Points[1].YValues[0]);
            series1.Styles[2].Text = string.Format("Facilities {0}%", series1.Points[2].YValues[0]);
            series1.Styles[3].Text = string.Format("Taxes {0}%", series1.Points[3].YValues[0]);
            series1.Styles[4].Text = string.Format("Insurance{0}%", series1.Points[4].YValues[0]);
            series1.Styles[5].Text = string.Format("Licenses {0}%", series1.Points[5].YValues[0]);
            series1.Styles[6].Text = string.Format("Legal {0}%", series1.Points[6].YValues[0]);
            series1.Styles[7].Text = string.Format("Health {0}%", series1.Points[7].YValues[0]);
            this.chartControl1.ShowLegend = false;
            this.colorPickerButton1.SelectedColor = Color.Gold;
        }
        #endregion

        #region Events

        private void checkBoxAutoHighlight_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.checkBoxAutoHighlight.Checked)
            {
                this.chartControl1.AutoHighlight = true;
                this.chartControl1.Cursor = System.Windows.Forms.Cursors.Hand;
                this.panel3.Visible = true;
            }
            else
            {
                this.chartControl1.AutoHighlight = false;
                this.chartControl1.Cursor = System.Windows.Forms.Cursors.Default;
                this.panel3.Visible = false;
            }
        }

        private void Color_Selected(object sender, System.EventArgs e)
        {
            BrushInfo interior = this.chartControl1.Series[0].Style.HighlightInterior;
            if (interior == null)
                interior = new BrushInfo();
            if (this.radioButton2.Checked)
            {
                Color foreColor = interior.ForeColor;
                this.chartControl1.Series[0].Style.HighlightInterior = new BrushInfo(GradientStyle.None, foreColor, this.colorPickerButton1.SelectedColor);
                this.chartControl1.Refresh();
            }
        }

        private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.radioButton1.Checked)
                this.chartControl1.Series[0].Style.HighlightInterior = null;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            BrushInfo interior = this.chartControl1.Series[0].Style.HighlightInterior;
            if (interior == null)
                interior = new BrushInfo();
            Color foreColor = interior.ForeColor;
            // Specifying a "Gold" highlight color.
            this.chartControl1.Series[0].Style.HighlightInterior = new BrushInfo(GradientStyle.None, foreColor, this.colorPickerButton1.SelectedColor);
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