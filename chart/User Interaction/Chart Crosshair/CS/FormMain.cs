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
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		
		private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private Label label4;
		private ChartAxis secXAxis = new ChartAxis();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = DockStyle.Fill;
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(210)))), ((int)(((byte)(193))))), System.Drawing.Color.White);
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(2, -1, 5, 2);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.ForeColor = System.Drawing.Color.Black;
            this.chartControl1.IsWindowLess = false;
            this.chartControl1.Size = new System.Drawing.Size(687, 614);
            this.chartControl1.TabIndex = 1;
            this.chartControl1.Text = "Weather Condition";
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.Indexed = false;
            this.chartControl1.Crosshair.Visible = true;
            this.chartControl1.Crosshair.AxisTooltipRendering += Crosshair_AxisTooltipRendering;
            this.chartControl1.Crosshair.AxisTooltip.Interior = new BrushInfo(Color.Black);
            this.chartControl1.Crosshair.AxisTooltip.TextColor = Color.White;
            // 
            // Legend
            // 
            this.chartControl1.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Center;
            this.chartControl1.Legend.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.Legend.Border.ForeColor = System.Drawing.Color.Transparent;
            this.chartControl1.Legend.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.Legend.ItemsSize = new System.Drawing.Size(15, 15);
            this.chartControl1.Legend.Location = new System.Drawing.Point(301, 573);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom;
            this.chartControl1.Legend.Spacing = 3;
            this.chartControl1.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            //
            // PrimaryXAxis
            //
            this.chartControl1.PrimaryXAxis.DrawGrid = false;
            this.chartControl1.PrimaryXAxis.ShowCrosshairTooltip = true;
            this.chartControl1.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.PrimaryXAxis.ForeColor = System.Drawing.Color.Black;
            this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.DarkGray;
            this.chartControl1.PrimaryXAxis.RangePaddingType = Syncfusion.Windows.Forms.Chart.ChartAxisRangePaddingType.None;
            this.chartControl1.PrimaryXAxis.Title = "Month";
            this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime;
            this.chartControl1.PrimaryXAxis.DateTimeFormat = "MMM/yyyy";
            //
            //PrimaryYAxis
            //
            this.chartControl1.PrimaryYAxis.Title = "Temperature (Fahrenheit)";
            this.chartControl1.PrimaryYAxis.ShowCrosshairTooltip = true;
            this.chartControl1.PrimaryYAxis.FormatLabel += PrimaryYAxis_FormatLabel;
            this.chartControl1.PrimaryYAxis.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.PrimaryYAxis.ForeColor = System.Drawing.Color.Black;
            this.chartControl1.PrimaryYAxis.GridLineType.BackColor = System.Drawing.Color.White;
            this.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.DarkGray;
            this.chartControl1.PrimaryYAxis.GridLineType.PenType = System.Drawing.Drawing2D.PenType.PathGradient;
            this.chartControl1.PrimaryYAxis.GridLineType.Width = 0F;
            this.chartControl1.PrimaryYAxis.HidePartialLabels = true;
            this.chartControl1.PrimaryYAxis.RangePaddingType = ChartAxisRangePaddingType.None;
            this.chartControl1.PrimaryYAxis.ValueType = ChartValueType.Double;
            this.chartControl1.PrimaryYAxis.Range = new MinMaxInfo(0, 160, 20);
            // 
            // panel1
            // 
            this.panel1.Dock = DockStyle.Right;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Location = new System.Drawing.Point(687, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(176, 415);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 625);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(54, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 39);
            this.label4.TabIndex = 11;
            this.label4.Text = "Chart Crosshair";
            //
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox1.Location = new System.Drawing.Point(62, 102);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(216, 35);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Opposed Position";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkbox1_changed);
            // 
            // FormMain
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1094, 617);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1106, 664);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crosshair";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

        private void Crosshair_AxisTooltipRendering(object sender, AxisTooltipEventArgs args)
        {
            if (this.chartControl1.Axes[args.AxisIndex].Title == "Temperature (Fahrenheit)")
            {
                args.Text = args.Text + "F";    
            }
            else if (this.chartControl1.Axes[args.AxisIndex].Title == "Rainfall")
            {
                args.Text = args.Text + "mm";
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
			Application.Run(new FormMain());
		}

        private void FormMain_Load(object sender, System.EventArgs e)
        {                   
            InitializeChartData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);

        }

        #region InitializeChartData()
        /// <summary>
        /// Initializes the ChartControl's data and sets the Chart type
        /// </summary>

        ChartAxis secYAxis = new ChartAxis();
        protected void InitializeChartData()
        {
            //
            // Series 1
            //
            ChartSeries series1 = new ChartSeries("Temperature");
            series1.Type = ChartSeriesType.Line;

            DateTime dateTime = new DateTime(1900, 1, 1);
            double value = 100;
            double value1 = 50;
            Random random = new Random();

            for (var i = 1; i < 2000; i++)
            {
                if (random.NextDouble() > .5)
                {
                    value += random.NextDouble();
                }
                else
                {
                    value -= random.NextDouble();
                }
                series1.Points.Add(dateTime.AddMonths(i), value);

            }
            //
            // Series 2
            //
            ChartSeries series2 = new ChartSeries("Rainfall");
            series2.Text = series2.Name;
            series2.Type = ChartSeriesType.Line;
            series2.FancyToolTip.Visible = true;

            for (var j = 1; j < 2000; j++)
            {
                if (random.NextDouble() > .5)
                {
                    value1 += random.NextDouble();
                }
                else
                {
                    value1 -= random.NextDouble();
                }
                series2.Points.Add(dateTime.AddDays(j), value1);               
            }
                        
            this.chartControl1.Series.Add(series1);
            this.chartControl1.Series.Add(series2);
            //
            // SecondaryYAxis
            //
            secYAxis.Title = "Rainfall";
            secYAxis.TitleFont = new Font("Segoe UI", 16f);
            secYAxis.DrawGrid = false;
            secYAxis.Range = new MinMaxInfo(0, 160, 20);
            secYAxis.HidePartialLabels = true;
            secYAxis.OpposedPosition = true;
            secYAxis.LabelIntersectAction = ChartLabelIntersectAction.Rotate;
            secYAxis.LineType.ForeColor = Color.FromArgb(213, 219, 204);
            secYAxis.ValueType = ChartValueType.Double;
            secYAxis.Orientation = ChartOrientation.Vertical;
            secYAxis.GridLineType.BackColor = Color.FromArgb(250, 209, 150, 150);
            secYAxis.GridLineType.ForeColor = Color.FromArgb(250, 230, 193, 193);
            secYAxis.GridLineType.PenType = System.Drawing.Drawing2D.PenType.LinearGradient;
            secYAxis.LineType.ForeColor = Color.FromArgb(213, 219, 204);
            secYAxis.Font = new Font("Segoe UI", 10.25f);
            secYAxis.FormatLabel += SecYAxis_FormatLabel;           
            secYAxis.ShowCrosshairTooltip = true;

            this.chartControl1.Axes.Add(secYAxis);            
            this.chartControl1.Series[1].YAxis = secYAxis;
            //
            // SecondaryXAxis
            //
            secXAxis.ShowCrosshairTooltip = true;
            secXAxis.DrawGrid = false;
            secXAxis.ValueType = ChartValueType.DateTime;
            secXAxis.LabelRotate = true;
            secXAxis.LabelRotateAngle = 90;
            secXAxis.RangePaddingType = ChartAxisRangePaddingType.None;
            secXAxis.Orientation = ChartOrientation.Horizontal;
            secXAxis.DateTimeFormat = "MMM/dd";

            this.chartControl1.Axes.Add(secXAxis);
            this.chartControl1.Series[1].XAxis = secXAxis;

            this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(series1.Points[0].DateX, series1.Points[1998].DateX, 15, ChartDateTimeIntervalType.Years);
      
        }

        private void SecYAxis_FormatLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            e.Handled = true;
            e.Label = e.Label + "mm";
        }

        private void PrimaryYAxis_FormatLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            e.Handled = true;
            e.Label = e.Label + "F";
        }

        #endregion

        #region Opposed position and Location of the Axes
        private void checkbox1_changed(object sender, System.EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.secYAxis.LocationType = ChartAxisLocationType.Auto;
                this.secYAxis.OpposedPosition = true;
            }

            else
            {
                this.secYAxis.OpposedPosition = false;

            }
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