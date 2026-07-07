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
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;

namespace ChartDrillDown
{
	public class Form1 : MetroForm
    {
        #region Private Members

        private IContainer components;
		bool isDrilledDown = false;       
        private Panel panel1;
        private Label label1;
        private Timer timer1;
        private ToolTip toolTip1;        
        private ChartControl chartControl1;
        
        #endregion

        #region Form constructor, Main and dispose
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
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries1 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo1 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartLineInfo chartLineInfo1 = new Syncfusion.Windows.Forms.Chart.ChartLineInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = DockStyle.Right;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 542);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 27);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click on the columns to drill down further";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // chartControl1
            // 
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.DataSourceName = "";
            this.chartControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Location = new System.Drawing.Point(830, 75);
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(8, 10);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
			this.chartControl1.PrimaryXAxis.Title = "Vehicles";
            this.chartControl1.PrimaryXAxis.Margin = true;
			this.chartControl1.PrimaryYAxis.Title = "Sales (%)";
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.ForceZero = true;
            this.chartControl1.PrimaryYAxis.Margin = true;
            chartSeries1.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries1.Name = "Default";
            chartSeries1.Points.Add(0D, ((double)(18D)), ((double)(127D)), ((double)(112D)), ((double)(108D)));
            chartSeries1.Points.Add(1D, ((double)(56D)), ((double)(73D)), ((double)(61D)), ((double)(56D)));
            chartSeries1.Points.Add(2D, ((double)(4D)), ((double)(212D)), ((double)(82D)), ((double)(107D)));
            chartSeries1.Points.Add(3D, ((double)(50D)), ((double)(348D)), ((double)(55D)), ((double)(190D)));
            chartSeries1.Points.Add(4D, ((double)(87D)), ((double)(246D)), ((double)(136D)), ((double)(192D)));
            chartSeries1.Resolution = 0D;
            chartSeries1.StackingGroup = "Default Group";
            chartSeries1.Style.AltTagFormat = "";
            chartSeries1.Style.DrawTextShape = false;
            chartLineInfo1.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
            chartLineInfo1.Color = System.Drawing.SystemColors.ControlText;
            chartLineInfo1.DashPattern = null;
            chartLineInfo1.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartLineInfo1.Width = 1F;
            chartCustomShapeInfo1.Border = chartLineInfo1;
            chartCustomShapeInfo1.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo1.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries1.Style.TextShape = chartCustomShapeInfo1;
            chartSeries1.Text = "Default";
            this.chartControl1.Series.Add(chartSeries1);
            this.chartControl1.Size = new System.Drawing.Size(934, 526);
            this.chartControl1.TabIndex = 2;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ChartRegionClick += new Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventHandler(this.chartControl1_ChartRegionClick);
            this.chartControl1.ChartRegionMouseHover += new Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventHandler(this.chartControl1_ChartRegionMouseHover);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 581);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(461, 407);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drilldown";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
		{
			InitializeChart();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            this.chartControl1.Indexed = true;
            this.chartControl1.Dock = DockStyle.Fill;
           

        }
        #endregion

        #region Helper Methods
        #region InitializeDrillDownChart
        /// <summary>
		/// Initializes the ChartControl's data and sets the Chart type
		/// </summary>
		protected void InitializeDrillDownChart(int index)
		{
            
			ChartSeries series1 = new ChartSeries("Market Breakdown");
			series1.Name = "Market";
			series1.Text = series1.Name;
			string[] labelArray = null;

			switch(index)
			{
				case 0:
					labelArray = new string[]{"Toyota", "Ford", "GM"};
                    this.chartControl1.Titles[0].Text = "Automobile sales in the SUV segment";
					break;
				case 1:
					labelArray = new string[]{"Toyota", "Ford", "GM"};
                    this.chartControl1.Titles[0].Text = "Automobile sales in the Car segment";
					break;
				case 2:
					labelArray = new string[]{"Mercedes", "Ford", "GM", "Chrysler"};
                    this.chartControl1.Titles[0].Text = "Automobile sales in the Pickup segment";
					
					break;
				case 3:
					labelArray = new string[]{"Nissan", "Ford", "GM"};
                    this.chartControl1.Titles[0].Text = "Automobile sales in the Minivan segment";
					break;
				default:
					labelArray = new string[]{"Toyota", "Ford", "GM"};
					break;
			}

			int count = this.chartControl1.Series[0].Points[index].YValues.Length -1;
			for(int i = 0; i < count; i++)
			{
				series1.Points.Add(i, this.chartControl1.Series[0].Points[index].YValues[i+1]);
                series1.Styles[i].Text = labelArray[i] + " - " + this.chartControl1.Series[0].Points[index].YValues[i + 1].ToString() + " %";
			}
			
			series1.Style.TextOrientation = ChartTextOrientation.RegionCenter;
            series1.Style.DisplayText = true;
           
			series1.Type = ChartSeriesType.Pie;	
		       

			this.chartControl1.Series.Clear();
			this.chartControl1.Series.Add(series1);
            this.chartControl1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            series1.PrepareStyle += new ChartPrepareStyleInfoHandler(series1_PrepareStyle);
           	this.chartControl1.Refresh();
            
		}
#endregion
        
        #region InitializeChart

        protected void InitializeChart()
		{
			this.chartControl1.Series.Clear();

			ChartSeries series1 = new ChartSeries("Market");
			series1.Name = "Market";
			series1.Text = series1.Name;

            series1.Points.Add(0, 20, 50, 25, 25);//Only first Y value will be used by ColumnChart
            series1.Points.Add(1, 22, 50, 25, 35);
            series1.Points.Add(2, 23, 50, 25, 20, 20);
            series1.Points.Add(3, 24, 50, 25, 45);


			this.chartControl1.PrimaryXAxis.LabelsImpl = new LabelModel(new string[]{"","SUV", "Car", "Pickup", "Minivan"});
			this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.Custom;
                     
            series1.Type = ChartSeriesType.Column;	
			this.chartControl1.Series.Add(series1);
            this.chartControl1.Titles[0].Text = "Automobile Sales by Category";
                      
            this.chartControl1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            this.chartControl1.Legend.Visible = false;
            this.chartControl1.Series[0].Style.Border.Color = Color.Transparent;
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }
        #endregion
        #endregion

        #region Events
        #region series1_PrepareStyle
        void series1_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
		{
			ChartSeries series = sender as ChartSeries;
            series.ConfigItems.PieItem.PieType = ChartPieType.OutSide;
			if (series != null)
			{
                args.Style.Border.Color = Color.Transparent;
			}
        }
        #endregion

        #region ChartRegionClick
        private void chartControl1_ChartRegionClick(object sender, Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs e)
		{
			if(e.Region.IsChartPoint)
			{
				if(!isDrilledDown)
				{
					InitializeDrillDownChart(e.Region.PointIndex);
                    
                    this.label1.Text = "Click on the pie to go back and view \n 'Sales by category'";
				}
				else
				{
					InitializeChart();
                    
                    this.label1.Text = "Click on the columns to drill down further";
                   
				}
				isDrilledDown = !isDrilledDown;
			}
            ChartAppearance.ApplyChartStyles(this.chartControl1);
		
			this.chartControl1.Refresh();
        }
        #endregion
                
    

        #region ChartRegionMouseHover
         private void chartControl1_ChartRegionMouseHover(object sender, ChartRegionMouseEventArgs e)
        {
            Point mousePoint = new Point(e.Point.X, e.Point.Y);
            ChartPoint chpt = chartControl1.ChartArea.GetValueByPoint(new Point(e.Point.X, e.Point.Y));
            Point pt = chartControl1.ChartArea.GetPointByValue(chpt);
             string text = "";
            switch (e.Region.PointIndex)
            {
                case 0:
                    text = "Automobile sales in the SUV segment";
             
                    break;
                case 1:
                    text = "Automobile sales in the Car segment";
					break;
				case 2:
                    text = "Automobile sales in the Pickup segment";
					break;
				case 3:
                    text = "Automobile sales in the Minivan segment";
                    break;
                default:
                    text = "";
                    break;
            }
            if(e.Region.PointIndex >= 0 &&  e.Region.PointIndex < 4)
                 this.chartControl1.Cursor = System.Windows.Forms.Cursors.Hand;
                else
                       this.chartControl1.Cursor = System.Windows.Forms.Cursors.Default;
                   if (this.chartControl1.Series[0].Type == ChartSeriesType.Column)
                   {
                       toolTip1.SetToolTip(chartControl1, text);
                   }
               }
         #endregion
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

        #region LabelModel
    public class LabelModel : IChartAxisLabelModel
    {
        private string[] labels;

        public LabelModel(string[] labels)
        {
            this.labels = labels;
        }

        public ChartAxisLabel GetLabelAt(int index)
        {
            return new ChartAxisLabel(this.labels[index]);
        }

        public int Count
        {
            get
            {
                return this.labels.GetLength(0);
            }
        }
    }
    #endregion
}
