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

namespace GridLabelsChartSample_2002
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : Syncfusion.Windows.Forms.MetroForm
    {
        private ChartControl chartControl1;
        private Panel panel2;
        private Label label15;
        private CheckBox checkBox2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

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
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}		

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
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
            this.chartControl1.DataSourceName = "";
            this.chartControl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Center;
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(313, 506);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom;
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.FormatLabel += PrimaryXAxis_FormatLabel;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.Size = new System.Drawing.Size(700, 583);
            this.chartControl1.TabIndex = 4;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "chartControl1";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ZoomOutIncrement = 1.5D;
            this.chartControl1.ChartFormatAxisLabel += new Syncfusion.Windows.Forms.Chart.ChartFormatAxisLabelEventHandler(this.chartControl1_ChartFormatAxisLabel);
            // 
            // panel2
            // 
            this.panel2.Dock = DockStyle.Right;
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Location = new System.Drawing.Point(700, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 586);
            this.panel2.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label15.Location = new System.Drawing.Point(32, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 25);
            this.label15.TabIndex = 30;
            this.label15.Text = "Axes Format";
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox2.Location = new System.Drawing.Point(37, 68);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(156, 25);
            this.checkBox2.TabIndex = 29;
            this.checkBox2.Text = " Format Axis Label";
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_1);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 584);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel2);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(659, 528);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Label Formatting";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

		}

        private void PrimaryXAxis_FormatLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            e.Handled = true;

            if (e.IsAxisPrimary)
            {
                e.Label = e.Label + "K";
            }
        }
        #endregion

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

		private void Form1_Load(object sender, System.EventArgs e)
		{			
			InitializeChartData();	
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            this.chartControl1.Dock = DockStyle.Fill;
         }

		protected void InitializeChartData()
		{
			ChartSeries series1 = new ChartSeries("Bus",ChartSeriesType.Scatter);
			ChartSeries series2 = new ChartSeries("Car",ChartSeriesType.Scatter);
			ChartSeries series3 = new ChartSeries("Bike",ChartSeriesType.Scatter);

			series1.Text = series1.Name;
			series2.Text = series2.Name;
			series3.Text = series3.Name;

			series1.Points.Add(1.1,110);
			series1.Points.Add(2,250);
			series1.Points.Add(3,280);
			series1.Points.Add(4,390);
			series1.Points.Add(5,530);
			series1.Points.Add(6,600);

			series2.Points.Add(1,100);
			series2.Points.Add(2.2,210);
			series2.Points.Add(3.1,320);
			series2.Points.Add(3.9,430);
			series2.Points.Add(5,510);
			series2.Points.Add(6.2,590);

			series3.Points.Add(1,90);
			series3.Points.Add(2.9,190);
			series3.Points.Add(3,300);
			series3.Points.Add(4.3,400);
			series3.Points.Add(5,450);
			series3.Points.Add(5.6,610);

			this.chartControl1.Series.Add(series1);
			this.chartControl1.Series.Add(series2);
			this.chartControl1.Series.Add(series3);         
		}               
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryXAxis.Labels.Clear();
            this.chartControl1.PrimaryYAxis.Labels.Clear();
           
            if (! this.checkBox2.Checked)
            {
                CustomLabel();             
            }
        }

        private void CustomLabel()
        {
            // adding custom labels
            this.chartControl1.PrimaryXAxis.Labels.Add(new ChartAxisLabel("Label1", Color.Black, new Font("Monospace", 10), 1, "", ChartValueType.Custom));
            this.chartControl1.PrimaryXAxis.Labels.Add(new ChartAxisLabel("Label2", Color.Black, new Font("Monospace", 10), 2, "", ChartValueType.Custom));
            this.chartControl1.PrimaryXAxis.Labels.Add(new ChartAxisLabel("Label3", Color.Black, new Font("Monospace", 10), 3, "", ChartValueType.Custom));
            this.chartControl1.PrimaryXAxis.Labels.Add(new ChartAxisLabel("Label4", Color.Black, new Font("Monospace", 10), 4, "", ChartValueType.Custom));
            this.chartControl1.PrimaryXAxis.Labels.Add(new ChartAxisLabel("Label5", Color.Black, new Font("Monospace", 10), 5, "", ChartValueType.Custom));
            this.chartControl1.PrimaryXAxis.Labels.Add(new ChartAxisLabel("Label6", Color.Black, new Font("Monospace", 10), 6, "", ChartValueType.Custom));

            this.chartControl1.PrimaryYAxis.Labels.Add(new ChartAxisLabel("Label1", Color.Black, new Font("Monospace", 10), 100, "", ChartValueType.Custom));
            this.chartControl1.PrimaryYAxis.Labels.Add(new ChartAxisLabel("Label2", Color.Black, new Font("Monospace", 10), 200, "", ChartValueType.Custom));
            this.chartControl1.PrimaryYAxis.Labels.Add(new ChartAxisLabel("Label3", Color.Black, new Font("Monospace", 10), 300, "", ChartValueType.Custom));
            this.chartControl1.PrimaryYAxis.Labels.Add(new ChartAxisLabel("Label4", Color.Black, new Font("Monospace", 10), 400, "", ChartValueType.Custom));
            this.chartControl1.PrimaryYAxis.Labels.Add(new ChartAxisLabel("Label5", Color.Black, new Font("Monospace", 10), 500, "", ChartValueType.Custom));
            this.chartControl1.PrimaryYAxis.Labels.Add(new ChartAxisLabel("Label6", Color.Black, new Font("Monospace", 10), 600, "", ChartValueType.Custom));

            this.chartControl1.PrimaryXAxis.LabelRotate = false;

            this.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.Wrap;
            this.chartControl1.PrimaryXAxis.OpposedPosition = false;
            this.chartControl1.PrimaryXAxis.OpposedPosition = false;
            this.chartControl1.PrimaryYAxis.OpposedPosition = false;
        }

        private void chartControl1_ChartFormatAxisLabel(object sender, Syncfusion.Windows.Forms.Chart.ChartFormatAxisLabelEventArgs e)
        {
            if (this.checkBox2.Checked)
            {
               e.Label = e.Value.ToString(".00");
               e.Handled = true;
            }

        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryXAxis.Labels.Clear();
            this.chartControl1.PrimaryYAxis.Labels.Clear();

            if (!this.checkBox2.Checked)
            {
                CustomLabel();
            }
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
