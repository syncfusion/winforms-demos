#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;

namespace Stacked100Charts
{
	public class Form1 : MetroForm
    {

        #region Private Members
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private ChartControl chartControl1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label4;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        #endregion 
		
        #region Constructor, Main and Dispose
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(44, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chart Type";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox1.Items.AddRange(new object[] {
            "StackingArea100",
            "StackingBar100",
            "StackingColumn100"});
            this.comboBox1.Location = new System.Drawing.Point(49, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 29);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(698, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 584);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(-12, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 572);
            this.label4.TabIndex = 127;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox2.Location = new System.Drawing.Point(51, 120);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(123, 25);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Enable Group";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox1.Location = new System.Drawing.Point(51, 158);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 25);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Enable 3D";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(1, 10, 17, 10);
            this.chartControl1.DataSourceName = "";
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Center;
            this.chartControl1.Legend.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 10F);
            this.chartControl1.Legend.ForeColor = System.Drawing.Color.Black;
            this.chartControl1.Legend.Location = new System.Drawing.Point(305, 49);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top;
            this.chartControl1.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.GridLineType.Width = 0F;
            this.chartControl1.PrimaryXAxis.LineType.Width = 0F;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.Size = new System.Drawing.Size(700, 580);
            this.chartControl1.TabIndex = 4;
            this.chartControl1.Text = "Essential Chart-Stacked 100% Chart";
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "Essential Chart-Stacked 100% Chart";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ChartFormatAxisLabel += new Syncfusion.Windows.Forms.Chart.ChartFormatAxisLabelEventHandler(this.chartControl1_ChartFormatAxisLabel);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 584);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.MinimumSize = new System.Drawing.Size(442, 453);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stacked 100";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            InitializeChartData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }

        #endregion 

        #region Helper Methods

        #region InitializeChartData

        protected void InitializeChartData()
        {
            ChartSeries series1 = new ChartSeries("Series1", ChartSeriesType.StackingArea100);
            series1.Points.Add(1, 20);
            series1.Points.Add(2, 30);
            series1.Points.Add(3, 10);
            series1.Points.Add(4, 15);
            series1.Points.Add(5, 25);
            this.chartControl1.Series.Add(series1);

            ChartSeries series2 = new ChartSeries("Series2", ChartSeriesType.StackingArea100);
            series2.Points.Add(1, 20);
            series2.Points.Add(2, 10);
            series2.Points.Add(3, 50);
            series2.Points.Add(4, 15);
            series2.Points.Add(5, 5);
            this.chartControl1.Series.Add(series2);

            ChartSeries series3 = new ChartSeries("Series3", ChartSeriesType.StackingArea100);
            series3.Points.Add(1, 20);
            series3.Points.Add(2, 40);
            series3.Points.Add(3, 10);
            series3.Points.Add(4, 5);
            series3.Points.Add(5, 20);
            this.chartControl1.Series.Add(series3);

            ChartSeries series4 = new ChartSeries("Series4", ChartSeriesType.StackingArea100);
            series4.Points.Add(1, 30);
            series4.Points.Add(2, 20);
            series4.Points.Add(3, 15);
            series4.Points.Add(4, 23);
            series4.Points.Add(5, 5);
            this.chartControl1.Series.Add(series4);
            this.comboBox1.SelectedIndex = 1;
        }

        #endregion

        #endregion 

        #region Events
        bool stackedBar = false;
        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Series[0].Type = (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), this.comboBox1.SelectedItem.ToString(), true);
            this.chartControl1.Series[1].Type = (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), this.comboBox1.SelectedItem.ToString(), true);
            this.chartControl1.Series[2].Type = (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), this.comboBox1.SelectedItem.ToString(), true);
            this.chartControl1.Series[3].Type = (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), this.comboBox1.SelectedItem.ToString(), true);
            switch (this.comboBox1.SelectedIndex)
            {
                case 0:

                    this.checkBox2.Checked = false;
                    this.chartControl1.Titles[0].Text = "100% Stacked Area Chart";
                    this.checkBox2.Enabled = false;                    
                    stackedBar = false;                  
                    break;
                case 1:
                    
                        this.chartControl1.Titles[0].Text = "100% Stacked Bar Chart";
                        this.checkBox2.Enabled = true;
                        stackedBar = true;
                    break;
                case 2:

                        this.chartControl1.Titles[0].Text = "100% Stacked Column Chart";
                        this.checkBox2.Enabled = true;
                        stackedBar = false;
                    break;
            }
        }

       

        #region Axis Labels
        private void chartControl1_ChartFormatAxisLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            if (stackedBar == true)
            {
                if (e.AxisOrientation == ChartOrientation.Horizontal)
                {
                    //Applying Formatted Axis label values.
                    e.Label = string.Format("{0}%", e.Value);
                }
            }
            else
            {
                if (e.AxisOrientation == ChartOrientation.Vertical)
                {
                    //Applying Formatted Axis label values.
                    e.Label = string.Format("{0}%", e.Value);
                }
        }
            e.Handled = true;
        }
        #endregion

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series3D = checkBox1.Checked;
        }

      #endregion

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                this.chartControl1.Series[0].StackingGroup = "First";
                this.chartControl1.Series[1].StackingGroup = "First";

                this.chartControl1.Series[2].StackingGroup = "Second";
                this.chartControl1.Series[3].StackingGroup = "Second";
                
            }
            else
            {
                this.chartControl1.Series[0].StackingGroup = "";
                this.chartControl1.Series[1].StackingGroup = "";

                this.chartControl1.Series[2].StackingGroup = "";
                this.chartControl1.Series[3].StackingGroup = "";

            }
            this.chartControl1.Redraw(true);
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
