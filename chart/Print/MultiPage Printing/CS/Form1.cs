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
using Syncfusion.Windows.Forms.Chart;
using System.Drawing.Drawing2D;
using Syncfusion.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Drawing.Text;
using Syncfusion.Windows.Forms;

namespace MultiPagePrinting_2005
{
    public partial class Form1 : MetroForm
    {
        private PrintAction? m_currectAction = null;
        double mx = 0.0, mi = 0.0;
        double start, end;
        double Intervel;
        public Form1()
        {
            BorderColor = Color.FromArgb(0xFF, 0xCD, 0xCD, 0xCD);
            BorderThickness = 3;
            CaptionBarHeight = 75;
            CaptionBarColor = Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2);
            CaptionFont = new Font("Segoe UI", 22.0f);
            CaptionForeColor = Color.White;
            CaptionAlign = HorizontalAlignment.Left;
            ShowIcon = false;
            CaptionButtonColor = Color.White;
            CaptionButtonHoverColor = Color.White;
            InitializeComponent();
            InitializeChartData();
            Appearanceset();
            this.chartControl1.PrintDocument.BeginPrint += new PrintEventHandler(PrintDocument_BeginPrint);
            this.chartControl1.PrintDocument.EndPrint += new PrintEventHandler(PrintDocument_EndPrint);
            this.chartControl1.PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(PrintDocument_PrintPage);
            this.comboBox1.SelectedIndex = 0;

            this.chartControl1.Dock = DockStyle.Fill;

            this.buttonAdv1.MouseMove += buttonAdv1_MouseMove;
            this.buttonPrint.MouseMove += buttonPrint_MouseMove;
        }

        bool previewTitleSet = false;

        void buttonPrint_MouseMove(object sender, MouseEventArgs e)
        {
            //Set tooltip title only once during mouse move
            if (previewTitleSet)
            {
                this.toolTip1.ToolTipTitle = "Print";
                previewTitleSet = false;
            }
        }
        
        void buttonAdv1_MouseMove(object sender, MouseEventArgs e)
        {
            //Set tooltip title only once during mouse move
            if (!previewTitleSet)
            {
                this.toolTip1.ToolTipTitle = "Print preview";
                previewTitleSet = true;
            }
        }
        private void InitChart()
        {
            this.chartControl1.PrimaryXAxis.DrawGrid = false;
            this.chartControl1.PrimaryXAxis.Title = "Pages";
            this.chartControl1.PrimaryYAxis.Title = "Printing Count";
            this.chartControl1.PrimaryXAxis.DrawGrid = false;

        }
        private void InitializeChartData()
        {
            this.chartControl1.Series.Clear();
            InitChart();
            Appearanceset();
            ChartSeries ser = new ChartSeries("MultiPage");
            ser.Points.Add(2, 45);
            ser.Points.Add(5, 100);
            ser.Points.Add(7, 210);
            ser.Points.Add(9, 110);
            ser.Points.Add(10, 150);
            ser.Points.Add(11, 180);
            ser.Points.Add(3, 45);
            ser.Points.Add(4, 100);
            ser.Points.Add(6, 210);
            ser.Points.Add(12, 110);
            ser.Points.Add(13, 150);
            ser.Points.Add(14, 180);
            ser.Points.Add(8, 45);
            ser.Points.Add(9, 100);
            ser.Points.Add(15, 210);
            ser.Points.Add(16, 110);
            ser.Points.Add(17, 150);
            ser.Points.Add(18, 180);
            ser.Points.Add(19, 100);
            ser.Points.Add(20, 210);
            ser.Points.Add(21, 110);
            ser.Points.Add(22, 150);
            ser.Points.Add(23, 180);
            ser.Points.Add(24, 150);
            ser.Points.Add(25, 180);
            ser.Points.Add(26, 210);
            ser.Points.Add(27, 110);
            ser.Points.Add(28, 150);
            ser.Points.Add(29, 180);
            ser.Points.Add(30, 150);
            ser.Points.Add(40, 210);
            ser.Points.Add(41, 110);
            ser.Points.Add(42, 150);
            ser.Points.Add(43, 180);
            ser.Points.Add(44, 150);
            ser.Points.Add(45, 180);
            ser.Points.Add(46, 210);
            ser.Points.Add(47, 110);
            ser.Points.Add(48, 150);
            ser.Points.Add(49, 180);
            ser.Points.Add(50, 150);
            ser.Points.Add(60, 210);
            ser.Points.Add(61, 110);
            ser.Points.Add(62, 150);
            ser.Points.Add(63, 180);
            ser.Points.Add(64, 150);
            ser.Points.Add(65, 180);
            ser.Points.Add(66, 210);
            ser.Points.Add(67, 110);
            ser.Points.Add(68, 150);
            ser.Points.Add(69, 180);
            ser.Points.Add(70, 150);
            ser.Points.Add(71, 110);
            ser.Points.Add(72, 150);
            ser.Points.Add(73, 180);
            ser.Points.Add(74, 150);
            ser.Points.Add(75, 180);
            ser.Points.Add(76, 210);
            ser.Points.Add(77, 110);
            ser.Points.Add(78, 150);
            ser.Points.Add(79, 180);
            ser.Points.Add(80, 150);

            this.chartControl1.Series.Add(ser);
            this.chartControl1.PrimaryXAxis.Range = new MinMaxInfo(0, 80, 5);
            ser.Type = ChartSeriesType.Column;
            this.chartControl1.Skins = Skins.Metro;
            this.chartControl1.Text = "Multiple Page Printing";            
            start = this.chartControl1.PrimaryXAxis.Range.Min;
            end = this.chartControl1.PrimaryXAxis.Range.Max;
            Intervel = this.chartControl1.PrimaryXAxis.Range.Interval;

            
        }
        private void Appearanceset()
        {
            
            #region Chart Appearance Customization
        
            chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.None;
             chartControl1.BorderAppearance.FrameThickness = new ChartThickness(-2, -2, 2, 2);
            chartControl1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            chartControl1.ElementsSpacing = 5;

            #endregion

            #region Axes Customization

            chartControl1.PrimaryXAxis.HidePartialLabels = true;
            chartControl1.PrimaryXAxis.HidePartialLabels = true;
              chartControl1.Legend.Visible = false;
            
            #endregion
        }

        void PrintDocument_EndPrint(object sender, PrintEventArgs e)
        {
            mx = 0.0;
            mi = 0.0;
        }
        void PrintDocument_BeginPrint(object sender, PrintEventArgs e)
        {
            m_currectAction = e.PrintAction;
        }

        void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
         
            e.HasMorePages = true;
            this.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.Wrap;
            if (mx == 0.0 && mi == 0.0)
            {

                mx = Convert.ToDouble(this.comboBox1.SelectedItem);
                mi = 0;
            }
            bool grayScale = this.chartControl1.PrintDocument.ColorMode == ChartPrintColorMode.GrayScale;
            bool toolBatVisibility = this.chartControl1.ShowToolbar;

            if (!this.chartControl1.PrintDocument.PrintToolBar)
            {
                this.chartControl1.ShowToolbar = false;
            }

            if (m_currectAction.Value == PrintAction.PrintToPrinter
                && this.chartControl1.PrintDocument.ColorMode == ChartPrintColorMode.CheckPrinter)
            {
                grayScale = this.chartControl1.PrintDocument.PrinterSettings.SupportsColor;
            }
             
            if (!grayScale)
            {

                this.chartControl1.PrimaryXAxis.Range.Min = mi;
                this.chartControl1.PrimaryXAxis.Range.Max = mx;
                this.chartControl1.PrimaryXAxis.Range.Interval = (this.chartControl1.PrimaryXAxis.Range.Max - this.chartControl1.PrimaryXAxis.Range.Min) / this.chartControl1.PrimaryXAxis.Range.NumberOfIntervals;
                mi = mx;
                mx = mx + Convert.ToDouble(this.comboBox1.SelectedItem);
                GraphicsContainer container = BeginTransform(e.Graphics);
                e.Graphics.ResetTransform();
                this.chartControl1.Draw(e.Graphics, e.MarginBounds);
                EndTransform(e.Graphics, container);
            }
            else if (grayScale)
            {
                ChartStyleInfo[] tempStyles = new ChartStyleInfo[this.chartControl1.Series.Count];
                Array ps = System.Enum.GetValues(typeof(PatternStyle));
                Array ds = System.Enum.GetValues(typeof(DashStyle));

                for (int i = 0; i < this.chartControl1.Series.Count; i++)
                {
                    tempStyles[i] = new ChartStyleInfo();
                    tempStyles[i].CopyFrom(this.chartControl1.Series[i].StylesImpl.Style);

                    this.chartControl1.Series[i].Style.Interior = new BrushInfo((PatternStyle)ps.GetValue(i % ps.Length), Color.Black, Color.White);
                    this.chartControl1.Series[i].Style.Border.MakeCopy(tempStyles[i], this.chartControl1.Series[i].Style.Border.Sip);
                    this.chartControl1.Series[i].Style.Border.Color = Color.Transparent;
                    this.chartControl1.Series[i].Style.Border.DashStyle = (DashStyle)ds.GetValue(i % ds.Length);

                    if (this.chartControl1.Series[i].Type == ChartSeriesType.Line || this.chartControl1.Series[i].Type == ChartSeriesType.Spline || this.chartControl1.Series[i].Type == ChartSeriesType.StepLine || this.chartControl1.Series[i].Type == ChartSeriesType.RotatedSpline)
                    {
                        this.chartControl1.Series[i].Style.Interior = new BrushInfo((PatternStyle)ps.GetValue(i % ps.Length), Color.White, Color.Black);

                        if (this.chartControl1.Series3D || this.chartControl1.ChartInterior.BackColor == Color.Black)
                        {
                            this.chartControl1.Series[i].Style.Interior = new BrushInfo((PatternStyle)ps.GetValue(i % ps.Length), Color.Black, Color.White);
                            this.chartControl1.Series[i].Style.Border.Color = Color.Transparent;

                        }
                    }
                }

                GraphicsContainer container = BeginTransform(e.Graphics);
                e.Graphics.ResetTransform();

                using (Image img = new Bitmap(e.MarginBounds.Width, e.MarginBounds.Height))
                {
                    using (Graphics g = Graphics.FromImage(img))
                    {
                        this.chartControl1.ChartArea.PrimaryXAxis.Range.Min = mi;
                        this.chartControl1.ChartArea.PrimaryXAxis.Range.Max = mx;
                        this.chartControl1.ChartArea.PrimaryXAxis.Range.Interval = (this.chartControl1.ChartArea.PrimaryXAxis.Range.Max - this.chartControl1.ChartArea.PrimaryXAxis.Range.Min) / this.chartControl1.ChartArea.PrimaryXAxis.Range.NumberOfIntervals;
                        mi = mx;
                        mx = mx + Convert.ToDouble(this.comboBox1.SelectedItem);
                        IntPtr hdc = g.GetHdc();
                        Stream stream = new MemoryStream();
                        Metafile mf = new Metafile(stream, hdc);

                        this.chartControl1.Draw(mf, img.Size);

                        DrawingUtils.DrawGrayedImage(e.Graphics, mf, e.MarginBounds, new Rectangle(Point.Empty, img.Size));

                        g.ReleaseHdc(hdc);
                        g.Dispose();
                        mf.Dispose();
                    }
                }

                EndTransform(e.Graphics, container);

                for (int i = 0; i < this.chartControl1.Series.Count; i++)
                {
                    this.chartControl1.Series[i].StylesImpl.Style.ResetInterior();
                    this.chartControl1.Series[i].StylesImpl.Style.ResetBorder();
                    this.chartControl1.Series[i].StylesImpl.Style.CopyFrom(tempStyles[i]);
                }
            }
            ////END A little experimental code

            if (!this.chartControl1.PrintDocument.PrintToolBar)
            {
                this.chartControl1.ShowToolbar = toolBatVisibility;
            }

            this.chartControl1.Redraw(true);
            if (mx > end)
                e.HasMorePages = false;


            this.chartControl1.PrimaryXAxis.Range.Min = start;
            this.chartControl1.PrimaryXAxis.Range.Max = end;
            this.chartControl1.PrimaryXAxis.Range.Interval = Intervel;
        }

        internal static GraphicsContainer BeginTransform(Graphics g)
        {
            SmoothingMode mode = g.SmoothingMode;
            TextRenderingHint textRH = g.TextRenderingHint;
            GraphicsContainer cont = g.BeginContainer();
            g.SmoothingMode = mode;
            g.TextRenderingHint = textRH;
            return cont;
        }
        internal static void EndTransform(Graphics g, GraphicsContainer cont)
        {
            g.EndContainer(cont);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
                this.chartControl1.PrintDocument.ColorMode = ChartPrintColorMode.GrayScale;
            else
                this.chartControl1.PrintDocument.ColorMode = ChartPrintColorMode.CheckPrinter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printDialog = new PrintPreviewDialog();

            printDialog.Document = this.chartControl1.PrintDocument;
            printDialog.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = this.chartControl1.PrintDocument;
            printDialog.UseEXDialog = true;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.chartControl1.PrintDocument.Print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printDialog = new PrintPreviewDialog();

            printDialog.Document = this.chartControl1.PrintDocument;
            printDialog.ShowDialog();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = this.chartControl1.PrintDocument;
            printDialog.UseEXDialog = true;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.chartControl1.PrintDocument.Print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


    }
}
