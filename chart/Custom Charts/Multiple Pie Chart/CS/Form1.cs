#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using System.Drawing.Drawing2D;
using Syncfusion.Drawing;

namespace MultiplePieChart_2005
{
    public partial class Form1 : MetroForm
    {
        #region Private Member
        private Color[] color1, color2, color3, color4, color5, color6, color7, color8;
        #endregion

        #region Constructor And Form Load
        public Form1()
        {
            InitializeComponent();
            BorderColor = Color.FromArgb(0xFF, 0xCD, 0xCD, 0xCD);
            BorderThickness = 3;
            CaptionBarHeight = 75;
            CaptionBarColor = Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2);
            CaptionFont = new Font("Segoe UI", 22.0f);
            CaptionForeColor = Color.White;
            CaptionAlign = HorizontalAlignment.Left;
            CaptionButtonColor = Color.White;
            CaptionButtonHoverColor = Color.White;
            ShowIcon = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {          
            InitialiseData();
            InitialiseControls();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
| System.Windows.Forms.AnchorStyles.Left)
| System.Windows.Forms.AnchorStyles.Right)));


        }
        #endregion

        #region Healper Methods
        public void InitialiseControls()
        { 
            foreach (string connect in Enum.GetNames(typeof(Syncfusion.Windows.Forms.Chart.ChartPieType)))
                this.cbBxPieType.Items.Add(connect);
            this.cbBxPieType.SelectedIndex = 0;
        }

        public void InitialiseData()
        {
            chartControl1.Series.Clear();

            Random random = new Random();
            ChartSeries series1 = new ChartSeries();
            series1.Name = "Year 2006";
            series1.Text = series1.Name;
            series1.Points.Add(0, 20);
            series1.Points.Add(2, 18);
            series1.Points.Add(3, 21);
            series1.Points.Add(4, 23);
            series1.Points.Add(5, 18);
            SeriesSettings(series1);
            this.chartControl1.Series.Add(series1);

            ChartSeries series2 = new ChartSeries();
            series2.Name = "Year 2007";
            series2.Text = series2.Name;
            series2.Points.Add(0, 12);
            series2.Points.Add(2, 21);
            series2.Points.Add(3, 18);
            series2.Points.Add(4, 25);
            series2.Points.Add(5, 24);
            SeriesSettings(series2);
            this.chartControl1.Series.Add(series2);

            ChartSeries series3 = new ChartSeries();
            series3.Name = "Year 2008";
            series3.Text = series3.Name;
            series3.Points.Add(0, 18);
            series3.Points.Add(2, 12);
            series3.Points.Add(3, 18);
            series3.Points.Add(4, 21);
            series3.Points.Add(5, 31);
            SeriesSettings(series3);
            this.chartControl1.Series.Add(series3);

            //Enable MultiplePies property to enable this feature.
            chartControl1.ChartArea.MultiplePies = true;
            this.chartControl1.ShowLegend = true;

            series1.Type = ChartSeriesType.Pie;
            series2.Type = ChartSeriesType.Pie;
            series3.Type = ChartSeriesType.Pie;

            //Each series must have DoughnutCoEfficient value [except the most inner series example: series1], to get the complete functionality of this feature.
            series2.ConfigItems.PieItem.DoughnutCoeficient = 0.7f;
            series3.ConfigItems.PieItem.DoughnutCoeficient = 0.8f;

            series3.ConfigItems.PieItem.AngleOffset = 130f;
            series2.ConfigItems.PieItem.AngleOffset = 130f;
            series1.ConfigItems.PieItem.AngleOffset = 130f;

            ChartLegend chartLegend = new ChartLegend();
            chartLegend.Name = "Legend 1";
            string[] label = new string[] { "Engineering-13.33%", "Medical Sciences-16.67%", "BioTechnology-30%", "Information Services-23%", "Economics -27%" };
            List<ChartLegendItem> items = new List<ChartLegendItem>();
            for (int i = 0; i < 5; i++)
            {
                ChartLegendItem legendItem = new ChartLegendItem(label[i]);
                legendItem.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                legendItem.RepresentationSize = new Size(16, 16);                
                items.Add(legendItem);
            }

            chartControl1.Legend.RepresentationType = ChartLegendRepresentationType.SeriesType;
            chartControl1.Legend.CustomItems = items.ToArray();
            chartControl1.Legend.RowsCount = 5;
            this.chartControl1.LegendAlignment = ChartAlignment.Center;            
            this.chartControl1.SmoothingMode = SmoothingMode.AntiAlias;
            this.chartControl1.Legend.DrawItemText+=new LegendDrawItemTextEventHandler(Legend_DrawItemText);

            if (ckBxEnable3D.Checked)
            {
                this.lblPieHeight.Visible = true;
                this.nUpDownPieHeight.Visible = true;
            }
            else
            {
                this.lblPieHeight.Visible = false;
                this.nUpDownPieHeight.Visible = false;
            }

        }
        protected void SeriesSettings(ChartSeries series)
        {
            ChartSeries newSeries = series;
            newSeries.Type = ChartSeriesType.Pie;

            newSeries.Style.TextColor = Color.MidnightBlue;
            newSeries.Style.Font.Bold = true;
            newSeries.Style.Font.Size = 7;
            newSeries.Style.DisplayText = this.ckBxDisplayText.Checked;

            newSeries.LegendName = "Legend 1";
            newSeries.PrepareStyle += new ChartPrepareStyleInfoHandler(series1_PrepareStyle);

            for (int i = 0; i < 5; i++)
            {
                series.Styles[i].Font.Size = 7f;
                series.Styles[i].TextFormat = string.Format("{0}%", series.Points[i].YValues[0]);
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// Handler for the PrepareStyle event of ChartSeries. 
        /// </summary>
        /// <param name="sender">The ChartSeries object that raises this event.</param>
        /// <param name="args">The event data. Can be modified to change series appearance.</param>
        void series1_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
        {
            ChartSeries series = sender as ChartSeries;
            series.Style.Border.Color = Color.SlateGray;           

            if (series != null)
            {

                color1 = new Color[] { Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2) };
                color2 = new Color[] { Color.FromArgb(0xFF, 0xA0, 0x50, 0x00) };
                color3 = new Color[] { Color.FromArgb(0xFF, 0x33, 0x99, 0x33) };
                color4 = new Color[] { Color.FromArgb(0xFF, 0xA2, 0xC1, 0x39) };
                color5 = new Color[] { Color.FromArgb(0xFF, 0xD8, 0x00, 0x73) };
                color6 = new Color[] { Color.FromArgb(0xFF, 0xF0, 0x96, 0x09) };
                color7 = new Color[] { Color.FromArgb(0xFF, 0xE6, 0x71, 0xB8) };
                color8 = new Color[] { Color.FromArgb(0xFF, 0xA2, 0x00, 0xFF) };

                if (args.Index == 0)
                {
                    args.Style.Interior = new BrushInfo(GradientStyle.None, color3);
                    this.chartControl1.Legend.Items[0].Interior = new BrushInfo(GradientStyle.None, color3);
                }
                else if (args.Index == 1)
                {
                    args.Style.Interior = new BrushInfo(GradientStyle.None, color2);
                    this.chartControl1.Legend.Items[1].Interior = new BrushInfo(GradientStyle.None, color2);
                }
                else if (args.Index == 2)
                {
                    args.Style.Interior = new BrushInfo(GradientStyle.None, color5);
                    this.chartControl1.Legend.Items[2].Interior = new BrushInfo(GradientStyle.None, color5);
                }
                else if (args.Index == 3)
                {
                    args.Style.Interior = new BrushInfo(GradientStyle.None, color7);
                    this.chartControl1.Legend.Items[3].Interior = new BrushInfo(GradientStyle.None, color7);
                }
                else if (args.Index == 4)
                {
                    args.Style.Interior = new BrushInfo(GradientStyle.None, color4);
                    this.chartControl1.Legend.Items[4].Interior = new BrushInfo(GradientStyle.None, color4);
                }
                else
                {
                    args.Style.Interior = new BrushInfo(GradientStyle.None, color1);
                }
            }
        }

        private void ckBxDisplayText_CheckedChanged(object sender, EventArgs e)
        {
            chartControl1.Series[0].Style.DisplayText = ckBxDisplayText.Checked;
            chartControl1.Series[1].Style.DisplayText = ckBxDisplayText.Checked;
            chartControl1.Series[2].Style.DisplayText = ckBxDisplayText.Checked;
        }

        private void cbBxPieType_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartControl1.Series[0].ConfigItems.PieItem.PieType = (ChartPieType)Enum.Parse(typeof(ChartPieType), this.cbBxPieType.SelectedItem.ToString(), true);
            chartControl1.Series[1].ConfigItems.PieItem.PieType = (ChartPieType)Enum.Parse(typeof(ChartPieType), this.cbBxPieType.SelectedItem.ToString(), true);
            chartControl1.Series[2].ConfigItems.PieItem.PieType = (ChartPieType)Enum.Parse(typeof(ChartPieType), this.cbBxPieType.SelectedItem.ToString(), true);
        }


        private void ckBxEnable3D_CheckedChanged(object sender, EventArgs e)
        {
            chartControl1.Series3D = ckBxEnable3D.Checked;
            if (ckBxEnable3D.Checked)
            {
                this.lblPieHeight.Visible = true;
                this.nUpDownPieHeight.Visible = true;
            }
            else
            {
                this.lblPieHeight.Visible = false;
                this.nUpDownPieHeight.Visible = false;
            }
        }

        private void nUpDownPieHeight_ValueChanged(object sender, EventArgs e)
        {
            chartControl1.Series[0].ConfigItems.PieItem.PieHeight = Convert.ToSingle(nUpDownPieHeight.Value);
            chartControl1.Series[1].ConfigItems.PieItem.PieHeight = Convert.ToSingle(nUpDownPieHeight.Value);
            chartControl1.Series[2].ConfigItems.PieItem.PieHeight = Convert.ToSingle(nUpDownPieHeight.Value);
        }
		void Legend_DrawItemText(object sender, ChartLegendDrawItemTextEventArgs e)
        {
            //Get current Legend item
            ChartLegendItem item = sender as ChartLegendItem;
           //current item bounds value
            RectangleF textRect = e.TextRect;
            //Text split for description and value text by mentionted symbol in Text property
            string[] mulText = e.Text.Split('-');
            //Get Max size of text from legend item collection
            Size[] itemMaxSize = MeasureSize(e.Graphics,  this.chartControl1.Legend.Items, mulText.Length);
             
            for (int i = 0; mulText.Length > i; i++)
            {
               //Get current text size
                SizeF currentText = e.Graphics.MeasureString(mulText[i], item.Font);
                if (i > 0)
                {
                    //Calculate value text position
                    textRect.X = textRect.Width;
                    //If you need more space between description and values text, add hard values for textRect.Widht( textRect.Width += itemMaxSize(i).Width+10)
                    textRect.Width += itemMaxSize[i].Width - 24;
                        //Hard code 30 for space between decs and values
                    //Align text for "Far" alignment
                    textRect.X += (textRect.Width - textRect.X) - currentText.Width;

                }
                else
                {
                    //Calculate description text position
                    textRect = new RectangleF(textRect.X, textRect.Y, itemMaxSize[i].Width, currentText.Height);
                    
                }
                //Draw the text
                using (Brush sb = new SolidBrush(item.TextColor))
                {
                    e.Graphics.DrawString(mulText[i], item.Font, sb, textRect);
                }
            }
             //Set "True" to handled property to draw the legend custom text properly.
            e.Handled = true;
        }
        private Size[] MeasureSize(Graphics g, ChartLegendItem[] items, int textcols)
        {
            Size[] itemsize = new Size[textcols];
            string[] itemText;
            for (int j = 0; j < textcols; j++)
            {
                Size itemsize1 = new Size(0, 0);
                foreach (ChartLegendItem item in items)
                {

                    if (item.Visible)
                    {
                        itemText = item.Text.Split('-');
                        if (itemText.Length > j)
                        {
                            SizeF sz = GetSize(g, itemText[j], item.Font);// g.MeasureString(itemText[j], item.Font);
                            
                            itemsize1.Width = Math.Max((int)sz.Width, itemsize1.Width);
                            itemsize1.Height = Math.Max((int)sz.Height, itemsize1.Height);
                        }
                    }
                }
                //Set max size for desc and values separatly in itemsize array
                itemsize[j] = Size.Ceiling(itemsize1);
            }

            return itemsize;
        }
        SizeF GetSize(Graphics g, string m_text, Font font)
        {
            float spacing = this.chartControl1.ElementsSpacing;
            SizeF result = g.MeasureString(m_text, this.Font);

             //Calculate size with icon size of legend item
            Size iconSize = chartControl1.Legend.Items[0].RepresentationSize;
            result.Width += spacing + iconSize.Width;
            result.Height = Math.Max(result.Height, iconSize.Height);
             
            return Size.Ceiling(result);
        }
        #endregion

       
    }
}