#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing.Drawing2D;

namespace MultiplyLegendsSample
{
    public class Form1 : MetroForm
    {
        #region Private Members
        private System.ComponentModel.IContainer components = null;
        private ChartControl chartControl1;
        private ChartTitle chartTitle1;
        private Syncfusion.Windows.Forms.Tools.ImageListAdv imageListAdv1;
        Color[] legendColor = new Color[] { Color.White, Color.White, Color.White, Color.White, Color.FromArgb(189, 221, 253), Color.FromArgb(236, 241, 245) };
        Color[] legendHighlightColor = new Color[] { Color.FromArgb(249, 196, 74), Color.FromArgb(249, 196, 74), Color.FromArgb(249, 196, 74), Color.FromArgb(189, 221, 253), Color.FromArgb(236, 241, 245) };
        #endregion

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageListAdv1 = new Syncfusion.Windows.Forms.Tools.ImageListAdv(this.components);
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.chartTitle1 = new Syncfusion.Windows.Forms.Chart.ChartTitle();
            this.chartControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListAdv1
            // 
            this.imageListAdv1.Images.AddRange(new System.Drawing.Image[] {
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images1"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images2"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images3"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images4"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images5"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images6"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images7")))});
            // 
            // chartControl1
            // 
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.None, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.DataSourceName = "";
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Center;
            this.chartControl1.Legend.Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chartControl1.Legend.Border.ForeColor = System.Drawing.Color.Red;
            this.chartControl1.Legend.ColumnsCount = 3;
            this.chartControl1.Legend.FloatingAutoSize = false;
            this.chartControl1.Legend.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.Legend.Location = new System.Drawing.Point(416, 54);
            this.chartControl1.Legend.OnlyColumnsForFloating = false;
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top;
            this.chartControl1.Legend.ShowBorder = true;
            this.chartControl1.Legend.Size = new System.Drawing.Size(83, 43);
            this.chartControl1.Legend.Text = "Legend";
            this.chartControl1.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(12, 7);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.BreakInfo.LineSpacing = 3D;
            this.chartControl1.PrimaryXAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight;
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.DateTimeFormat = "";
            this.chartControl1.PrimaryXAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.chartControl1.PrimaryXAxis.GridLineType.Width = 0F;
            this.chartControl1.PrimaryXAxis.HidePartialLabels = true;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryXAxis.Origin = 34704D;
            this.chartControl1.PrimaryXAxis.OriginDate = new System.DateTime(1995, 1, 5, 0, 0, 0, 0);
            this.chartControl1.PrimaryXAxis.Range = new Syncfusion.Windows.Forms.Chart.MinMaxInfo(1990D, 2010D, 5D);
            this.chartControl1.PrimaryXAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set;
            this.chartControl1.PrimaryXAxis.Title = "Year";
            this.chartControl1.PrimaryYAxis.BreakInfo.LineSpacing = 3D;
            this.chartControl1.PrimaryYAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.ForceZero = true;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Range = new Syncfusion.Windows.Forms.Chart.MinMaxInfo(0D, 100D, 10D);
            this.chartControl1.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set;
            this.chartControl1.PrimaryYAxis.Title = "Sales Percentage";
            this.chartControl1.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.PatternStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(187)))), ((int)(((byte)(217))))), System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(187)))), ((int)(((byte)(217))))));
            this.chartControl1.ShadowWidth = 2;
            this.chartControl1.Size = new System.Drawing.Size(916, 562);
            this.chartControl1.TabIndex = 18;
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartTitle1);
            this.chartControl1.ChartRegionMouseHover += new Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventHandler(this.chartControl1_ChartRegionMouseHover);
            // 
            // chartTitle1
            // 
            this.chartTitle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartTitle1.Name = "chartTitle1";
            this.chartTitle1.Text = "Car Sales";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 581);
            this.Controls.Add(this.chartControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(630, 439);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Legends";
            this.chartControl1.ResumeLayout(false);
            this.chartControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        #region Form's Constructor And Dispose

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
            this.InitializeData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;

        }
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion

        #region InitializeData
        protected void InitializeData()
        {
            #region Add Series

            Color[] color1 = new Color[] { Color.FromArgb(41, 88, 145), Color.FromArgb(118, 178, 249), Color.FromArgb(41, 88, 145) };
            Color[] color2 = new Color[] { Color.FromArgb(123, 156, 56), Color.FromArgb(211, 247, 131), Color.FromArgb(123, 156, 56) };
            Color[] color3 = new Color[] { Color.FromArgb(149, 44, 41), Color.FromArgb(251, 120, 116), Color.FromArgb(149, 44, 41) };
            Color[] color4 = new Color[] { Color.FromArgb(209, 115, 114), Color.FromArgb(255, 194, 191), Color.FromArgb(209, 115, 114) };
            Color[] color5 = new Color[] { Color.FromArgb(39, 133, 158), Color.FromArgb(133, 230, 254), Color.FromArgb(39, 133, 158) };
            Color[] color6 = new Color[] { Color.FromArgb(203, 108, 30), Color.FromArgb(254, 196, 101), Color.FromArgb(203, 108, 30) };
            Color[] color8 = new Color[] { Color.FromArgb(116, 147, 51), Color.FromArgb(194, 229, 121), Color.FromArgb(116, 147, 51) };
            Color[] color9 = new Color[] { Color.FromArgb(88, 62, 120), Color.FromArgb(182, 147, 223), Color.FromArgb(88, 62, 120) };
            
            ChartSeries series5 = new ChartSeries();
            series5.Name = "Model3_Blue";
            series5.Text = "Blue";
            series5.Points.Add(1995, 30);
            series5.Points.Add(2000, 55);
            series5.Points.Add(2005, 80);
            series5.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            series5.Style.ImageIndex = 4;
            series5.Style.Interior = new Syncfusion.Drawing.BrushInfo(GradientStyle.Horizontal, color5);
            series5.Style.Border.Color = Color.FromArgb(48, 98, 112);
            series5.Type = ChartSeriesType.Spline;
            series5.Style.Border.Width = 3;
            series5.Style.Symbol.Shape = ChartSymbolShape.Circle;
            series5.Style.Symbol.Color = Color.White;
            series5.Style.Symbol.Border.Color = Color.FromArgb(39, 133, 158);
            series5.Style.Symbol.Border.Width = 3;
            series5.Style.Border.Width = 3;
            chartControl1.Series.Add(series5);

            ChartSeries series6 = new ChartSeries();
            series6.Name = "Model3_Green";
            series6.Text = "Orange";
            series6.Points.Add(1995, 50);
            series6.Points.Add(2000, 43);
            series6.Points.Add(2005, 65);
            series6.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            series6.Style.ImageIndex = 5;
            series6.Style.Interior = new Syncfusion.Drawing.BrushInfo(GradientStyle.Horizontal, color6);
            series6.Style.Border.Color = Color.FromArgb(240, 139, 47);
            series6.Type = ChartSeriesType.Line;
            series6.Style.Border.Width = 3;
            series6.Style.Symbol.Shape = ChartSymbolShape.Circle;
            series6.Style.Symbol.Color = Color.White;
            series6.Style.Symbol.Border.Color = Color.FromArgb(203, 108, 30);
            series6.Style.Symbol.Border.Width = 3;
            chartControl1.Series.Add(series6);

            ChartSeries series7 = new ChartSeries();
            series7.Name = "Model4_Blue";
            series7.Text = "Green";
            series7.Points.Add(1995, 43);
            series7.Points.Add(2000, 62);
            series7.Points.Add(2005, 60);
            series7.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            series7.Style.ImageIndex = 6;
            series7.Style.Interior = new Syncfusion.Drawing.BrushInfo(GradientStyle.Horizontal, color8);
            series7.Style.Border.Color = Color.FromArgb(106, 127, 64);
            series7.Type = ChartSeriesType.Line;
            series7.Style.Border.Width = 3;           
            series7.Style.Symbol.Shape = ChartSymbolShape.Circle;
            series7.Style.Symbol.Color = Color.White;
            series7.Style.Symbol.Border.Color = Color.FromArgb(116, 147, 51);
            series7.Style.Symbol.Border.Width = 3;
            chartControl1.Series.Add(series7);

            ChartSeries series8 = new ChartSeries();
            series8.Name = "Model4_Blue";
            series8.Text = "Purple";
            series8.Points.Add(1995, 48);
            series8.Points.Add(2000, 71);
            series8.Points.Add(2005, 66);
            series8.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            series8.Style.ImageIndex = 7;
            series8.Style.Interior = new Syncfusion.Drawing.BrushInfo(GradientStyle.Horizontal, color9);
            series8.Style.Border.Color = Color.FromArgb(75, 61, 92);
            series8.Type = ChartSeriesType.Spline;
            series8.Style.Border.DashStyle = DashStyle.DashDotDot;
            series8.Style.Border.Width = 3;
            chartControl1.Series.Add(series8);

            ChartSeries series1 = new ChartSeries();
            series1.Name = "Model1_Blue";
            series1.Text = "Blue";
            series1.Points.Add(1995, 40);
            series1.Points.Add(2000, 60);
            series1.Points.Add(2005, 75);
            series1.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            series1.Style.ImageIndex = 0;
            series1.Style.Interior = new Syncfusion.Drawing.BrushInfo(GradientStyle.Horizontal, color1);
            series1.Style.Border.Color = Color.FromArgb(49, 73, 102);
            chartControl1.Series.Add(series1);

            ChartSeries series2 = new ChartSeries();
            series2.Name = "Model1_Green";
            series2.Text = "Green";
            series2.Points.Add(1995, 35);
            series2.Points.Add(2000, 70);
            series2.Points.Add(2005, 45);
            series2.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            series2.Style.ImageIndex = 1;
            series2.Style.Interior = new Syncfusion.Drawing.BrushInfo(GradientStyle.Horizontal, color2);
            series2.Style.Border.Color = Color.FromArgb(151, 188, 75);
            chartControl1.Series.Add(series2);

            ChartSeries series3 = new ChartSeries();
            series3.Name = "Model2_Blue";
            series3.Text = "Red";
            series3.Points.Add(1995, 60);
            series3.Points.Add(2000, 35);
            series3.Points.Add(2005, 55);
            series3.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            series3.Style.ImageIndex = 2;
            series3.Style.Interior = new Syncfusion.Drawing.BrushInfo(GradientStyle.Horizontal, color3);
            series3.Style.Border.Color = Color.FromArgb(110, 68, 67);
            chartControl1.Series.Add(series3);

            ChartSeries series4 = new ChartSeries();
            series4.Name = "Model2_Green";
            series4.Text = "Pink";
            series4.Points.Add(1995, 45);
            series4.Points.Add(2000, 50);
            series4.Points.Add(2005, 35);
            series4.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            series4.Style.ImageIndex = 3;
            series4.Style.Interior = new Syncfusion.Drawing.BrushInfo(GradientStyle.Horizontal, color4);
            series4.Style.Border.Color = Color.FromArgb(169, 119, 118);
            chartControl1.Series.Add(series4);
            this.chartControl1.ShowLegend = false;


            #endregion

            #region Add Legend
            ChartLegend legend1 = new ChartLegend(chartControl1);
            ChartLegend legend2 = new ChartLegend(chartControl1);
            ChartLegend legend3 = new ChartLegend(chartControl1);
            ChartLegend legend5 = new ChartLegend(chartControl1);
            ChartLegend legend6 = new ChartLegend(chartControl1);

            legend1.Name = "legend1";
            legend2.Name = "legend2";
            legend3.Name = "legend3";
            legend5.Name = "legend5";
            legend6.Name = "legend6";

            legend1.Text = "Zen";
            legend2.Text = "Ford";
            legend3.Text = "Sedan";
            legend5.Text = "MobileHome";
            legend6.Text = "Oldtimer";

            chartControl1.Legends.Add(legend1);
            chartControl1.Legends.Add(legend2);
            chartControl1.Legends.Add(legend3);
            chartControl1.Legends.Add(legend5);
            chartControl1.Legends.Add(legend6);

            series1.LegendName = "legend1";
            series2.LegendName = "legend1";
            series3.LegendName = "legend2";
            series4.LegendName = "legend2";
            series5.LegendName = "legend3";
            series6.LegendName = "legend3";
            series7.LegendName = "legend5";
            series8.LegendName = "legend6";
            legend1.Spacing = 0;
            legend2.Spacing = 0;
            legend3.Spacing = 0;
            legend5.Spacing = 0;
            legend6.Spacing = 0;
            
            for (int i = 0; i < this.chartControl1.Series.Count; i++)
            {
                this.chartControl1.Series[i].Style.Border.Color = Color.Transparent;
            }
            #endregion

            #region AutoHighlight
            this.chartControl1.AutoHighlight = true;
            foreach (ChartSeries series in this.chartControl1.Series)
            {
                Color[] highlightcolor = new Color[] { Color.FromArgb(255, 204, 68), Color.FromArgb(254, 234, 180), Color.FromArgb(250, 186, 13) };
                series.Style.HighlightInterior = new BrushInfo(GradientStyle.Horizontal, highlightcolor);
            }
            this.chartControl1.Refresh();
            #endregion

            #region Legend Settings
            foreach (ChartLegend chartLegend in this.chartControl1.Legends)
            {
                if (chartLegend.Name == "legend1" || chartLegend.Name == "legend2" || chartLegend.Name == "legend3" || chartLegend.Name == "legend5" || chartLegend.Name == "legend6")
                {
                    chartLegend.Position = ChartDock.Bottom;
                    chartLegend.Alignment = ChartAlignment.Center;
                }
                chartLegend.RepresentationType = ChartLegendRepresentationType.SeriesImage;
                chartLegend.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
                chartLegend.ForeColor = Color.FromArgb(23, 83, 120);
                chartLegend.BackInterior = new BrushInfo(GradientStyle.Vertical, legendColor);
                chartLegend.ShowBorder = true;
                chartLegend.Border.ForeColor = Color.FromArgb(143, 192, 223);
                chartLegend.Border.Width = 1;


                foreach (ChartLegendItem cli in chartLegend.Items)
                {
                    cli.Font = new Font("Segoe UI", 8.0f, FontStyle.Regular);
                    cli.TextColor = Color.Black;
                    cli.RepresentationSize = new Size(32, 32);
                }

                this.chartControl1.DockingManager.LayoutMode = ChartLayoutMode.Wrap;
                this.chartControl1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            }
            #endregion
        }
        #endregion

        #region Events
        //Highlights the series point and the corresponding LegendItem.
        private void chartControl1_ChartRegionMouseHover(object sender, ChartRegionMouseEventArgs e)
        {
            foreach (ChartLegend chartLegend in this.chartControl1.Legends)
            {
                chartLegend.BackInterior = new BrushInfo(GradientStyle.Vertical, legendColor);
                foreach (ChartLegendItem cli in chartLegend.Items)
                {
                    cli.Font = new Font("Segoe UI", 8.0f, FontStyle.Regular);
                    cli.TextColor = Color.Black;
                }
            }
            if (e.Region.SeriesIndex > -1)
            {
                chartControl1.Legends[this.chartControl1.Series[e.Region.SeriesIndex].LegendName].BackInterior = new BrushInfo(GradientStyle.Vertical, legendHighlightColor);
                this.chartControl1.Series[e.Region.SeriesIndex].LegendItem.Font = new Font("Segoe UI", 7.0f, FontStyle.Bold);
                this.chartControl1.Series[e.Region.SeriesIndex].LegendItem.TextColor = Color.FromArgb(44, 127, 179);
            }
        }
        #endregion
    }
}