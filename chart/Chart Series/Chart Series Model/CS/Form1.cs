#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
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

namespace ChartSeriesModel
{
    public class Form1 : MetroForm
    {
        #region Private Members

        private Panel panel2;
        private ChartControl chartControl1;
        private Label label3;
        private Panel panel1;
        private RadioButton radioButtonIndexed;
        private RadioButton radioButtonSeries;
        private Label label1;
        private CheckBox checkBox6;
        private CheckBox checkBox2;
        private CheckBox checkBox5;
        private CheckBox checkBox3;
        private CheckBox checkBox1;
        private CheckBox checkBox4;
        private Label label2;
        private System.ComponentModel.Container components = null;
        #endregion

        #region Constructor, Main And Dispose
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonIndexed = new System.Windows.Forms.RadioButton();
            this.radioButtonSeries = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.chartControl1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(958, 584);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Dock = DockStyle.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(65, 550);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(498, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Series Style Dialog will be displayed while double click the Series points in the" +
    " Chart.";
            // 
            // chartControl1
            // 
            this.chartControl1.AllowUserEditStyles = true;
            this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss;
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartArea.Watermark.TextColor = System.Drawing.SystemColors.ControlText;
            this.chartControl1.DataSourceName = "";
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Location = new System.Drawing.Point(574, 87);
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 12);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.ForeColor = System.Drawing.Color.Black;
            this.chartControl1.PrimaryXAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.White;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryXAxis.Title = "Version";
            this.chartControl1.PrimaryXAxis.TitleColor = System.Drawing.Color.Black;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.ForceZero = true;
            this.chartControl1.PrimaryYAxis.ForeColor = System.Drawing.Color.Black;
            this.chartControl1.PrimaryYAxis.GridLineType.BackColor = System.Drawing.Color.White;
            this.chartControl1.PrimaryYAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.White;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Title = "Documents Generated";
            this.chartControl1.PrimaryYAxis.TitleColor = System.Drawing.Color.Black;
            this.chartControl1.Size = new System.Drawing.Size(700, 521);
            this.chartControl1.TabIndex = 2;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.ForeColor = System.Drawing.Color.Black;
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // panel1
            // 
            this.panel1.Dock = DockStyle.Right;
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.radioButtonIndexed);
            this.panel1.Controls.Add(this.radioButtonSeries);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox6);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(698, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 584);
            this.panel1.TabIndex = 1;
            // 
            // radioButtonIndexed
            // 
            this.radioButtonIndexed.AutoSize = true;
            this.radioButtonIndexed.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonIndexed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.radioButtonIndexed.Location = new System.Drawing.Point(46, 359);
            this.radioButtonIndexed.Name = "radioButtonIndexed";
            this.radioButtonIndexed.Size = new System.Drawing.Size(170, 24);
            this.radioButtonIndexed.TabIndex = 14;
            this.radioButtonIndexed.TabStop = true;
            this.radioButtonIndexed.Text = "Indexed Series Model";
            this.radioButtonIndexed.UseVisualStyleBackColor = false;
            this.radioButtonIndexed.CheckedChanged += new System.EventHandler(this.SeriesModel_CheckedChanged);
            // 
            // radioButtonSeries
            // 
            this.radioButtonSeries.AutoSize = true;
            this.radioButtonSeries.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSeries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.radioButtonSeries.Location = new System.Drawing.Point(46, 326);
            this.radioButtonSeries.Name = "radioButtonSeries";
            this.radioButtonSeries.Size = new System.Drawing.Size(113, 24);
            this.radioButtonSeries.TabIndex = 13;
            this.radioButtonSeries.TabStop = true;
            this.radioButtonSeries.Text = "Series Model";
            this.radioButtonSeries.UseVisualStyleBackColor = false;
            this.radioButtonSeries.CheckedChanged += new System.EventHandler(this.SeriesModel_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(41, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Chart Model\r\n";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox6.Location = new System.Drawing.Point(45, 240);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(122, 24);
            this.checkBox6.TabIndex = 21;
            this.checkBox6.Text = "Show Text tab";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged_1);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox2.Location = new System.Drawing.Point(45, 108);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(188, 24);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Show FancyToolTips tab";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_1);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox5.Location = new System.Drawing.Point(45, 206);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(144, 24);
            this.checkBox5.TabIndex = 20;
            this.checkBox5.Text = "Show Symbol tab";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged_1);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox3.Location = new System.Drawing.Point(45, 140);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(142, 24);
            this.checkBox3.TabIndex = 18;
            this.checkBox3.Text = "Show Interior tab";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox1.Location = new System.Drawing.Point(45, 74);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 24);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Show Border tab";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox4.Location = new System.Drawing.Point(45, 172);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(147, 24);
            this.checkBox4.TabIndex = 19;
            this.checkBox4.Text = "Show Shadow tab";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(40, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Style Dialog Options";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 584);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(505, 568);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Series Model";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Form Load

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.radioButtonIndexed.Checked = true;
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            InitializeChartData();
            this.chartControl1.Dock = DockStyle.Fill;
        }
        #endregion

        #region Helper Methods
        #region InitializeChartData
        protected void InitializeChartData()
        {
            this.chartControl1.Series.Clear();
            ChartSeries series = new ChartSeries();
            series.Name = "Machine 1";
            series.Text = series.Name;
            series.Type = ChartSeriesType.Line;
            this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.Custom;

            //IndexedSeriesModel
            if (this.radioButtonIndexed.Checked)
            {
                //Indexed models do not have an associated X-axis value for their points.
                //The X-axis value is commonly just the position of the data within the series.
                series.SeriesIndexedModelImpl = new CustomIndexedSeriesModel();
                this.chartControl1.Indexed = true;
                this.chartControl1.Titles[0].Text = "Custom Indexed Series Model";
                this.chartControl1.PrimaryXAxis.LabelsImpl = new IndexedSeriesLabelModel();
                this.chartControl1.PrimaryXAxis.Title = "Version";
            }
            //SeriesModel
            else if (this.radioButtonSeries.Checked)
            {
                series.SeriesModel = new CustomSeriesModel();
                this.chartControl1.Indexed = false;
                this.chartControl1.Titles[0].Text = "Custom Series Model";
                this.chartControl1.PrimaryXAxis.LabelsImpl = new SeriesLabelModel(new string[] { "Mar", "Apr", "May", "Jun", "Jul" });
                this.chartControl1.PrimaryXAxis.Title = "Month";
            }
            series.Style.Symbol.Size = new Size(25, 25);
            series.Style.Symbol.Shape = ChartSymbolShape.Diamond;
            series.Style.Symbol.Color = Color.White;
            series.Style.DisplayText = true;
            series.Style.Border.Width = 3;
            this.chartControl1.Series.Add(series);
        }

        #endregion
        #endregion

        #region Event

        private void SeriesModel_CheckedChanged(object sender, EventArgs e)
        {
            InitializeChartData();
        }
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            this.chartControl1.StyleDialogOptions.ShowBorderTab = this.checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            this.chartControl1.StyleDialogOptions.ShowFancyToolTipsTab = this.checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            this.chartControl1.StyleDialogOptions.ShowInteriorTab = this.checkBox3.Checked;
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            this.chartControl1.StyleDialogOptions.ShowShadowTab = this.checkBox4.Checked;
        }

        private void checkBox5_CheckedChanged_1(object sender, EventArgs e)
        {
            this.chartControl1.StyleDialogOptions.ShowSymbolTab = this.checkBox5.Checked;
        }

        private void checkBox6_CheckedChanged_1(object sender, EventArgs e)
        {
            this.chartControl1.StyleDialogOptions.ShowTextTab = this.checkBox6.Checked;
        }
        #endregion

        

       
    }
	/// <summary>
	/// Represents a class that is used to find the licensing file for Syncfusion controls.
	/// </summary>
	public class DemoCommon
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