#region Copyright Syncfusion Inc. 2001 - 2014
//
//  Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
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
        private ComboBox comboBox1;
        private Label label12;
        private Panel panel1;
        private Label label1;
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.BorderAppearance.BaseColor = System.Drawing.Color.Moccasin;
            this.chartControl1.BorderAppearance.FrameThickness = new Syncfusion.Windows.Forms.Chart.ChartThickness(15F, 15F, 15F, 15F);
            this.chartControl1.BorderAppearance.Interior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss;
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10);
            this.chartControl1.DataSourceName = "";
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(552, 81);
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.ForceZero = true;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Range = new Syncfusion.Windows.Forms.Chart.MinMaxInfo(0D, 600D, 100D);
            this.chartControl1.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set;
            this.chartControl1.Size = new System.Drawing.Size(700, 578);
            this.chartControl1.TabIndex = 1;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Margin = 1;
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ZoomOutIncrement = 0.20000000298023224D;
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox1.Location = new System.Drawing.Point(36, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 28);
            this.comboBox1.TabIndex = 93;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label12.Location = new System.Drawing.Point(33, 65);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(55, 23);
            this.label12.TabIndex = 92;
            this.label12.Text = "Style";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.panel1.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 94;
            this.label1.Text = "Skin Styles";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            //
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 584);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.MinimumSize = new System.Drawing.Size(494, 456);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borders";
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

            foreach (String str in Enum.GetNames(typeof(ChartBorderSkinStyle)))
                this.comboBox1.Items.Add(str);
            this.comboBox1.SelectedIndex = 0;

            // Customize the basic appearance and behaviour of Chart Control
            ChartAppearance.ApplyChartStyles(this.chartControl1);

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

			
            ChartSeries series1 = new ChartSeries();

            series1.Name = "Product A";
            series1.Points.Add(1995, 300);
            series1.Points.Add(1996, 240);
            series1.Points.Add(1997, 300);
            series1.Points.Add(1998, 240);
            series1.Points.Add(1999, 300);
            series1.Points.Add(2000, 240);
            series1.Type = ChartSeriesType.Column;
            series1.Text = series1.Name;
            this.chartControl1.Series.Add(series1);
			
            ChartSeries series2 = new ChartSeries();

            series2.Name = "Product B";
            series2.Points.Add(1995, 370);
            series2.Points.Add(1996, 420);
            series2.Points.Add(1997, 330);
            series2.Points.Add(1998, 440);
            series2.Points.Add(1999, 230);
            series2.Points.Add(2000, 540);
            series2.Type = ChartSeriesType.Column;
            series2.Text = series2.Name;
            this.chartControl1.Series.Add(series2);

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
            this.chartControl1.BorderAppearance.SkinStyle = (ChartBorderSkinStyle)Enum.Parse(typeof(ChartBorderSkinStyle), this.comboBox1.SelectedItem.ToString(), true);
            if (this.comboBox1.SelectedIndex == 0)
                this.chartControl1.Titles[0].Text = "Product Sales Comparison";
            else
                this.chartControl1.Titles[0].Text = this.chartControl1.BorderAppearance.SkinStyle.ToString() + " Border ";
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
