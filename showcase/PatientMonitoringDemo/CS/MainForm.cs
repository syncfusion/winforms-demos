#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using PatientDetailsDemo;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGrid.Interactivity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientMonitoring
{
    public partial class MainForm : SfForm
    {
        [DllImport("user32.dll")]
        public static extern bool LockWindowUpdate(IntPtr hWndLock);
        Syncfusion.Windows.Forms.Chart.ChartPoint previousPoint = new Syncfusion.Windows.Forms.Chart.ChartPoint();
        Syncfusion.Windows.Forms.Chart.ChartPoint currentPoint = new Syncfusion.Windows.Forms.Chart.ChartPoint();
        TrackBall TrackBallInfo = new TrackBall();
        string imagepath = "Image\\";
        bool updatePanel = true;
       
        public MainForm()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Image.FromFile(imagepath + "App.ico"));
            this.Icon = Icon.FromHandle(img.GetHicon());

            #region [ data source ]
            List<PatientDetails> list = new List<PatientDetails>();
            List<PatientDetails> patientDetails = new List<PatientDetails>();
            list = this.GetPatientDetails();
            this.sfDataGrid1.DataSource = list;
            #endregion

            #region [ hide columns ]
            this.sfDataGrid1.Columns["ImageName"].Visible = false;
            this.sfDataGrid1.Columns["TileIntreval"].Visible = false; ;
            this.sfDataGrid1.Columns["BloodPressure2"].Visible = false;
            this.sfDataGrid1.Columns["ID"].Visible = false;
            this.sfDataGrid1.Columns["RoomNo"].Visible = false;
            this.sfDataGrid1.Columns["Sex"].Visible = false;
            #endregion

            #region [ grid settings ]

            this.sfDataGrid1.ShowRowHeader = false;
            this.sfDataGrid1.Columns[10].HeaderText = "BP";
            this.sfDataGrid1.Columns["Name"].HeaderText = "Full Name";
            this.sfDataGrid1.Columns["HeartRate"].HeaderText = "Heart Rate";
            this.sfDataGrid1.Columns["RespirationRate"].HeaderText = "Respiration Rate";
            this.sfDataGrid1.NavigationMode = NavigationMode.Row;
            this.sfDataGrid1.Columns[0].CellStyle.HorizontalAlignment = HorizontalAlignment.Left;
            this.sfDataGrid1.Columns[5].CellStyle.HorizontalAlignment = HorizontalAlignment.Center;
            this.sfDataGrid1.AutoSizeColumnsMode = AutoSizeColumnsMode.Fill;
            this.sfDataGrid1.Style.HeaderStyle.BackColor = Color.FromArgb(51, 120, 158);
            this.sfDataGrid1.Style.HeaderStyle.TextColor = Color.White;
            this.sfDataGrid1.Style.HeaderStyle.PressedTextColor = Color.White;
            this.sfDataGrid1.Style.HeaderStyle.HoverTextColor = Color.White;
            this.sfDataGrid1.Style.HeaderStyle.Font.Size = 12f;
            this.sfDataGrid1.Style.HeaderStyle.HoverBackColor = Color.FromArgb(51, 120, 158);
            this.sfDataGrid1.Style.HeaderStyle.PressedBackColor = Color.FromArgb(51, 120, 158);
            this.sfDataGrid1.SelectionMode = GridSelectionMode.Single;
            this.sfDataGrid1.Style.CellStyle.VerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.sfDataGrid1.Style.CellStyle.HorizontalAlignment = HorizontalAlignment.Right;
            this.sfDataGrid1.Style.SelectionStyle.BackColor = Color.FromArgb(140, 198, 63);
            this.sfDataGrid1.Style.SelectionStyle.TextColor = Color.White;
            this.sfDataGrid1.RowHeight =(int)DpiAware.LogicalToDeviceUnits(40);
            this.sfDataGrid1.HeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(40);
            this.sfDataGrid1.IndentColumnWidth = 20;
            var record = SelectionHelper.GetRecordAtRowIndex(this.sfDataGrid1, 1);
            this.sfDataGrid1.SelectedItem = record;
            this.sfDataGrid1.BackColor = Color.White;
            this.sfDataGrid1.Style.CellStyle.Font.Size = 12f;
            this.sfDataGrid1.CellClick += sfDataGrid1_CellClick;
            this.sfDataGrid1.SelectionChanged += SfDataGrid1_SelectionChanged;
            //Chart label values
            GetCurrentRecordData();
            #endregion

            #region Chart Initialize
            InitializeChart();
            InitLiveChart();
            this.timer1.Interval = 100;
            timer1.Tick += timer1_Tick;
            #endregion

           
            this.pictureBox2.Click += new EventHandler(pictureBox2_Click_2);
            this.pictureBox1.Click += new EventHandler(pictureBox1_Click_1);
            this.ResizeBegin += new EventHandler(MainForm_ResizeBegin);
            this.ResizeEnd += new EventHandler(MainForm_ResizeEnd);
            this.SizeChanged += new EventHandler(MainForm_SizeChanged);
            this.StartPosition = FormStartPosition.CenterScreen;
           

            ArrangeLocation();

            
        }

        /// <summary>
        /// MainForm size changed event set the size for controls based on Client size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MainForm_SizeChanged(object sender, EventArgs e)
        {
            int spacing = 10;
            LockWindowUpdate(IntPtr.Zero);
            this.splitContainerAdv1.Size = this.ClientRectangle.Size;

            Firstpanel.Height=sfDataGrid1.Height = this.splitContainerAdv1.SplitterDistance;
            tableLayoutPanelmain.Height = this.splitContainerAdv1.SplitterDistance;
            
            this.tableLayoutPanelmain.Width = this.ClientRectangle.Width;
            this.Firstpanel.Width = this.ClientRectangle.Width;
            this.secondpanel.Width = this.ClientRectangle.Width;
            this.thirdpanel.Width = this.ClientRectangle.Width;
            this.chartControl2.Width = this.ClientRectangle.Width - tableLayoutPanel1.Width - unwantedpanel.Width-tableLayoutPanel1.Margin.Left;
            this.chartControl1.Width = this.ClientRectangle.Width - unwantedpanel.Width-chartControl1.Margin.Right;
            this.sfDataGrid1.Width = this.ClientRectangle.Width - panel1.Width-sfDataGrid1.Margin.Right;
            this.chartControl1.Height = this.chartControl1.Parent.Height - spacing;
            this.chartControl2.Height = this.chartControl2.Parent.Height - spacing;
            this.unwantedpanel.Height = this.chartControl1.Height;
        }

        /// <summary>
        /// Rearrange the Controls size and location based on client size
        /// </summary>
        private void ArrangeLocation()
        {
            this.splitContainerAdv1.SplitterDistance = this.Height / 2;
            Firstpanel.Height = sfDataGrid1.Height;
            secondpanel.Height = pictureBox1.Height > label11.Height ? pictureBox1.Height : label11.Height;
            this.tableLayoutPanel1.Width = 160 + (int)DpiAware.LogicalToDeviceUnits(50);
            this.thirdpanel.Height = tableLayoutPanelmain.Height - secondpanel.Height;
            this.chartControl2.Height =  thirdpanel.Height=tableLayoutPanel1.Height;
            this.chartControl1.Height = unwantedpanel.Height = thirdpanel.Height;
            this.tableLayoutPanelmain.Height = thirdpanel.Height + secondpanel.Height;
            this.chartControl2.Location = new Point(20, tableLayoutPanel1.Location.Y);
            this.chartControl1.Location = new Point(this.unwantedpanel.Location.X + unwantedpanel.Width, 5);
            this.MinimumSize = new Size(unwantedpanel.Width + chartControl2.Width + tableLayoutPanel1.Width, this.sfDataGrid1.Height +tableLayoutPanel1.Height+secondpanel.Height + this.Style.TitleBar.Height + 200);
            if (this.splitContainerAdv1.Width <= this.Width || this.splitContainerAdv1.Height <= this.Height)
            {
                this.panelMain.AutoScroll = false;
            }
            this.splitContainerAdv1.IsSplitterFixed = true;
        }
        private void sfDataGrid1_CellClick(object sender, CellClickEventArgs e)
        {
            isKeyDown = true;
            GetCurrentRecordData();
            InitializeChart();
            InitLiveChart();

        }

        bool isKeyDown = false;
        private void SfDataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (isKeyDown)
            {
                isKeyDown = false;
                GetCurrentRecordData();
                InitializeChart();
                InitLiveChart();
            }
        }

        void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            LockWindowUpdate(IntPtr.Zero);
        }

        void MainForm_ResizeBegin(object sender, EventArgs e)
        {
            LockWindowUpdate(this.Handle);
        }

        private void GetCurrentRecordData()
        {
            object cd = SelectionHelper.GetRecordAtRowIndex(this.sfDataGrid1, this.sfDataGrid1.CurrentCell.RowIndex);
            label11.Text = ((PatientDetailsDemo.PatientDetails)(cd)).Name.ToString();
            label8.Text = ((PatientDetailsDemo.PatientDetails)(cd)).HeartRate.ToString();
            label6.Text = ((PatientDetailsDemo.PatientDetails)(cd)).RespirationRate.ToString();
            label4.Text = ((PatientDetailsDemo.PatientDetails)(cd)).Saturation.ToString() + "%";
            label10.Text = ((PatientDetailsDemo.PatientDetails)(cd)).Temperature.ToString();
            label2.Text = (((PatientDetailsDemo.PatientDetails)(cd)).BloodPressure.ToString()) + "/" + (((PatientDetailsDemo.PatientDetails)(cd)).BloodPressure2.ToString());
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            historypanel.Visible = true;
            this.unwantedpanel.Visible = true;
            this.chartControl1.Visible = true;
            this.chartControl2.Visible = false;
            this.measurepanel.Visible = false;
            currentpanel.Visible = false;
            this.tableLayoutPanel1.Visible = false;
            chartControl1.Visible = true;
            this.pictureBox1.Image = this.imageListAdv1.Images[0];
            this.pictureBox2.Image = this.imageListAdv1.Images[1];
        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {

            currentpanel.Visible = true;
            this.chartControl2.Visible = true;
            this.measurepanel.Visible = true;
            this.tableLayoutPanel1.Visible = true;
            this.unwantedpanel.Visible = false;
            this.chartControl1.Visible = false;
            historypanel.Visible = false;
            this.pictureBox2.Image = this.imageListAdv1.Images[3];
            this.pictureBox1.Image = this.imageListAdv1.Images[4];
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                Rectangle rec = c.Bounds; rec.Inflate(2, 2);
                ControlPaint.DrawBorder(e.Graphics, rec, Color.FromArgb(51, 120, 158), ButtonBorderStyle.Solid);
            }
        }

        private void unwantedpanel_Paint(object sender, PaintEventArgs e)
        {
            var range = this.chartControl1.PrimaryXAxis.Range;
            var yRange = this.chartControl1.PrimaryYAxis.Range;
            var area = this.chartControl1.ChartArea;

            e.Graphics.Clear(Color.White);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var text = new string[] { "Sat", "RR", "HR", "TP" };
            int radius = (int)DpiAware.LogicalToDeviceUnits(32);
            var circleSize = new Size(radius, radius);
            var startPoint = new Syncfusion.Windows.Forms.Chart.ChartPoint(range.Min, yRange.Min);
            var endPoint = new Syncfusion.Windows.Forms.Chart.ChartPoint(range.Min, yRange.Min + yRange.Max);
            var dHeight = Math.Abs(area.GetPointByValue(startPoint).Y - area.GetPointByValue(new Syncfusion.Windows.Forms.Chart.ChartPoint(startPoint.X, startPoint.YValues[0] + yRange.Interval)).Y) / 2 + circleSize.Height / 2;
            Font textFont = new System.Drawing.Font("Segoe UI", 5F);
            int k = 0;
            for (double i = startPoint.YValues[0]; i < endPoint.YValues[0]; i += yRange.Interval)
            {
                var point = area.GetPointByValue(new Syncfusion.Windows.Forms.Chart.ChartPoint(range.Min, i));
                var brush = new SolidBrush(this.chartControl1.Series[k].Style.Interior.BackColor);
                e.Graphics.FillEllipse(brush, e.ClipRectangle.X, point.Y - dHeight, circleSize.Width , circleSize.Width);
                var textSize = e.Graphics.MeasureString(text[k], Font, new PointF(e.ClipRectangle.X + circleSize.Width / 2, point.Y - dHeight), StringFormat.GenericDefault);
                e.Graphics.DrawString(text[k], Font, Brushes.White, new PointF(e.ClipRectangle.X + circleSize.Width / 2 - textSize.Width / 2, point.Y - dHeight + circleSize.Height / 2 - textSize.Height / 2), StringFormat.GenericDefault);
                brush.Dispose();
                k++;
            }
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            foreach (ChartSeries series in this.chartControl2.Series)
            {
                double y = series.Points[0].YValues[0];
                for (int i = 0; i < series.Points.Count; i++)
                {
                    if (i == series.Points.Count - 1)
                        series.Points[i].YValues[0] = y;
                    else
                        series.Points[i].YValues[0] = series.Points[i + 1].YValues[0];
                }
                this.chartControl2.Refresh();
            }
        }

        #region[chart]
        public void InitializeChart()
        {
            PatientDetails details = (PatientDetails)SelectionHelper.GetRecordAtRowIndex(this.sfDataGrid1, this.sfDataGrid1.CurrentCell.RowIndex);
            this.chartControl1.Title.Visible = false;
            DateTime dt = DateTime.Now;
            Random r = new Random();
            this.chartControl1.Series.Clear();
            ChartSeries series = new ChartSeries("Temp", ChartSeriesType.Line);
            ChartSeries series1 = new ChartSeries("HR", ChartSeriesType.Line);
            ChartSeries series2 = new ChartSeries("RR", ChartSeriesType.Line);
            ChartSeries series3 = new ChartSeries("Sat", ChartSeriesType.Line);
            for (int i = 0; i < 7; i++)
            {
                series.Points.Add(dt.AddSeconds(i * 10), r.Next(10, 20));
                series1.Points.Add(dt.AddSeconds(i * 10), r.Next(40, 50));
                series2.Points.Add(dt.AddSeconds(i * 10), r.Next(70, 85));
                series3.Points.Add(dt.AddSeconds(i * 10), r.Next(95, 110));
            }
            series.Style.Border.Width = 4;
            series1.Style.Border.Width = 4;
            series2.Style.Border.Width = 4;
            series3.Style.Border.Width = 4;
            series.Style.Interior = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#A2C133"));
            series1.Style.Interior = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#339933"));
            series2.Style.Interior = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#A05000"));
            series3.Style.Interior = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#1BA1E2"));
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(133, 199, 117));
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Color.White);
            this.chartControl1.Series.Add(series);
            this.chartControl1.Series.Add(series1);
            this.chartControl1.Series.Add(series2);
            this.chartControl1.Series.Add(series3);
            this.chartControl1.ElementsSpacing = 0;
            this.chartControl1.ChartArea.ChartAreaMargins = new ChartMargins(0, 0, 0, 20);
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Color.Green);
            this.chartControl1.PrimaryXAxis.DrawGrid = false;
            this.chartControl1.PrimaryYAxis.GridLineType.ForeColor = Color.Gray;
            this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = Color.Gray;
            this.chartControl1.PrimaryYAxis.LineType.ForeColor = Color.Transparent;
            this.chartControl1.PrimaryXAxis.LineType.ForeColor = Color.Transparent;
            this.chartControl1.PrimaryYAxis.TickColor = Color.Transparent;
            this.chartControl1.PrimaryXAxis.TickColor = Color.Transparent;
            this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime;
            this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(dt.AddSeconds(-10), dt.AddSeconds(70), 10, ChartDateTimeIntervalType.Seconds);
            this.chartControl1.PrimaryXAxis.DateTimeFormat = "hh:mm:ss \n MM/dd";
            this.chartControl1.PrimaryYAxis.IsVisible = false;
            this.chartControl1.PrimaryYAxis.Range = new MinMaxInfo(0, 120, 30);
            this.chartControl1.PrimaryXAxis.ForeColor = Color.White;
            this.chartControl1.PrimaryYAxis.ForeColor = Color.White;
            this.chartControl1.PrimaryXAxis.HidePartialLabels = true;
            this.chartControl1.ShowLegend = false;
            this.chartControl1.ChartRegionMouseMove += chartControl1_ChartRegionMouseMove;
            this.chartControl1.Paint += chartControl1_Paint;
        }

        void chartControl1_Paint(object sender, PaintEventArgs e)
        {
            if (updatePanel)
            {
                this.unwantedpanel.Refresh();
            }
        }
        void chartControl1_ChartRegionMouseMove(object sender, ChartRegionMouseEventArgs e)
        {
            Graphics g = this.chartControl1.CreateGraphics();
            Rectangle bounds = this.chartControl1.ChartArea.RenderBounds;
            if (e.Point.X > bounds.Left && e.Point.X < bounds.Right && e.Point.Y > bounds.Top && e.Point.Y < bounds.Bottom)
            {
                Syncfusion.Windows.Forms.Chart.ChartPoint point = FindClosestChartPoint(e.Point);
                Point closestPoint = this.chartControl1.ChartArea.GetPointByValue(point);
                currentPoint = point;
                if (previousPoint.X != currentPoint.X)
                {
                    updatePanel = false;
                    this.chartControl1.Refresh();
                    updatePanel = true;
                    TrackBallInfo.TrackBallLine.Color = Color.Orange;
                    TrackBallInfo.TrackBallLine.Width = 2;
                    g.DrawLine(TrackBallInfo.TrackBallLine, closestPoint.X, bounds.Top, closestPoint.X, bounds.Bottom);
                    DrawTrackBallToolTip(g, point);
                }
            }
            previousPoint = currentPoint;
        }

        void DrawTrackBallToolTip(Graphics g, Syncfusion.Windows.Forms.Chart.ChartPoint pt)
        {
            Point location = Point.Empty;
            foreach (ChartSeries series in this.chartControl1.Series)
                for (int i = 0; i < series.Points.Count; i++)
                    if (pt.X == series.Points[i].X)
                    {
                        location = this.chartControl1.ChartArea.GetPointByValue(series.Points[i]);
                        TrackBallInfo.SymbolColor.Color = series.Style.Interior.BackColor;
                        TrackBallInfo.SymbolSize = new System.Drawing.Size(10, 10);
                        string toolTipText = null;
                        if (series.Name.Equals("Temp"))
                        {
                            toolTipText = (series.Points[i].YValues[0] + 50) + "°" + " F" + "/" + (series.Points[i].YValues[0] + 75) + (Char)176;
                            DrawToolTip(g, location, toolTipText, TrackBallInfo.SymbolColor.Color);
                        }
                        else if (series.Name.Equals("RR"))
                        {
                            toolTipText = (series.Points[i].YValues[0] - 10).ToString();
                            DrawToolTip(g, location, toolTipText, TrackBallInfo.SymbolColor.Color);
                        }
                        else if (!(series.Name.Equals("HR")))
                        {
                            toolTipText = (series.Points[i].YValues[0] - 80).ToString();
                            DrawToolTip(g, location, toolTipText, TrackBallInfo.SymbolColor.Color);
                        }
                        DrawAxisLabelToolTip(g, location, series.Points[i].DateX.ToString("hh:mm:ss \n MM/dd"));
                        break;
                    }
        }

        private void DrawAxisLabelToolTip(Graphics g, Point location, string toolTipText)
        {
            SizeF sz = g.MeasureString(toolTipText, TrackBallInfo.ToolTipFont, location, StringFormat.GenericDefault);
            Rectangle rect = new Rectangle((int)(location.X - (sz.Width / 2) - 10), this.chartControl1.ChartArea.RenderBounds.Bottom + 2, (int)sz.Width + 20, (int)sz.Height + 10);
            GraphicsPath gp = new GraphicsPath();
            PointF[] points ={new PointF(rect.X, rect.Y), 
                            new PointF(rect.X+rect.Width/2-5, rect.Y), new PointF(rect.X+rect.Width/2, rect.Y-5),
                            new PointF(rect.X+rect.Width/2+5, rect.Y),
                            new PointF(rect.X+rect.Width, rect.Y), new PointF(rect.X+rect.Width, rect.Y+rect.Height),
                            new PointF(rect.X, rect.Y+rect.Height)};
            g.FillPolygon(Brushes.Orange, points);
            g.DrawPolygon(TrackBallInfo.TrackBallLine, points);
            g.DrawString(toolTipText, TrackBallInfo.ToolTipFont, Brushes.Black, new Point((int)(location.X - (sz.Width / 2)), rect.Y + (int)sz.Height / 4), StringFormat.GenericDefault);
        }

        private void DrawToolTip(Graphics g, Point location, string p, Color clr)
        {
            Brush b = new SolidBrush(clr);
            Pen pn = new Pen(b);
            g.DrawEllipse(TrackBallInfo.SymbolBorder, location.X - 5, location.Y - 5, TrackBallInfo.SymbolSize.Width, TrackBallInfo.SymbolSize.Height);
            g.FillEllipse(TrackBallInfo.SymbolColor, location.X - 5, location.Y - 5, TrackBallInfo.SymbolSize.Width, TrackBallInfo.SymbolSize.Height);
            SizeF sz = g.MeasureString(p, TrackBallInfo.ToolTipFont, location, StringFormat.GenericDefault);
            Rectangle rect = new Rectangle(location.X - (int)Math.Round(sz.Width) - 10 - 15, (location.Y - (int)(sz.Height + 10) / 2) + 8, (int)Math.Round(sz.Width) + 10, (int)Math.Round(sz.Height) + 10);
            TrackBallInfo.TooltipBackGround.Color = Color.White;
            FontFamily fontFamily = new FontFamily("Arial");
            TrackBallInfo.ToolTipFont = new Font(fontFamily, 10, FontStyle.Regular);
            Point[] p1 = new Point[] { new Point(rect.X, rect.Y), new Point(rect.X + rect.Width+4,rect.Y),
                new Point(rect.X + rect.Width,rect.Y+8),
                new Point(rect.X + rect.Width,rect.Y+rect.Height),
                new Point(rect.X,rect.Y+rect.Height)};
            g.FillPolygon(TrackBallInfo.TooltipBackGround, p1);
            g.FillRectangle(b, rect.X, rect.Y, 4, rect.Height);
            TrackBallInfo.ToolTipBorder.Color = Color.Gray;
            g.DrawPolygon(TrackBallInfo.ToolTipBorder, p1);
            g.DrawRectangle(pn, rect.X, rect.Y, 4, rect.Height);
            TrackBallInfo.TextColor.Color = Color.Black;
            g.DrawString(p, TrackBallInfo.ToolTipFont, Brushes.Black, new Point(rect.X + rect.Width / 2 - (int)(sz.Width / 2), (location.Y - (int)(sz.Height + 10) / 4) + 8));

        }

        private Syncfusion.Windows.Forms.Chart.ChartPoint FindClosestChartPoint(Point point)
        {
            Syncfusion.Windows.Forms.Chart.ChartPoint temp = this.chartControl1.ChartArea.GetValueByPoint(point);
            Syncfusion.Windows.Forms.Chart.ChartPoint result = null;
            foreach (ChartSeries series in this.chartControl1.Series)
                foreach (Syncfusion.Windows.Forms.Chart.ChartPoint point2 in series.Points)
                {
                    if (result == null)
                    {
                        result = point2;
                        continue;
                    }
                    if (Math.Abs(point2.X - temp.X) < Math.Abs(temp.X - result.X))
                    {
                        result = point2;
                    }
                }
            return result;
        }


        public class TrackBall
        {
            public Pen TrackBallLine;
            public Pen ToolTipBorder;
            public SolidBrush TooltipBackGround;
            public SolidBrush TextColor;
            public SolidBrush SymbolColor;
            public Pen SymbolBorder;
            public Font ToolTipFont;
            public Size SymbolSize;

            public TrackBall()
            {
                TrackBallLine = new Pen(Color.Transparent);
                ToolTipBorder = new Pen(Color.Transparent);
                TooltipBackGround = new SolidBrush(Color.Transparent);
                ToolTipFont = new Font("Arial", 10);
                TextColor = new SolidBrush(Color.Transparent);
                SymbolBorder = new Pen(Color.Transparent);
                SymbolColor = new SolidBrush(Color.Transparent);
                SymbolSize = new Size();
            }
        }

        #endregion

        void InitLiveChart()
        {
            this.chartControl2.Title.Visible = false;
            DateTime dt = DateTime.Now;
            Random r = new Random();
            this.chartControl2.Series.Clear();
            ChartSeries series = new ChartSeries("Series", ChartSeriesType.Line);
            ChartSeries series1 = new ChartSeries("Series1", ChartSeriesType.Line);
            ChartSeries series2 = new ChartSeries("Series2", ChartSeriesType.Line);
            for (int i = 0; i < 75; i++)
            {
                series.Points.Add(i, r.Next(10, 20));
                series1.Points.Add(i, r.Next(40, 50));
                series2.Points.Add(i, r.Next(70, 85));

            }
            series.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.SteelBlue);
            series1.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.SteelBlue);
            series2.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.SteelBlue);
            series.Style.Border.Width = 2;
            series1.Style.Border.Width = 2;
            series2.Style.Border.Width = 2;
            this.chartControl2.Series.Add(series);
            this.chartControl2.Series.Add(series1);
            this.chartControl2.Series.Add(series2);
            this.chartControl2.ElementsSpacing = 0;
            this.chartControl2.ChartArea.ChartAreaMargins = new ChartMargins(0, 0, 0, -15);
            this.chartControl2.ShowLegend = false;
            this.chartControl2.PrimaryYAxis.GridLineType.ForeColor = Color.Gray;
            this.chartControl2.PrimaryYAxis.GridLineType.Width = 1;
            this.chartControl2.PrimaryXAxis.GridLineType.ForeColor = Color.Gray;
            this.chartControl2.PrimaryYAxis.LineType.ForeColor = Color.Gray;
            this.chartControl2.PrimaryXAxis.LineType.ForeColor = Color.Gray;
            this.chartControl2.PrimaryYAxis.TickColor = Color.Transparent;
            this.chartControl2.PrimaryXAxis.TickColor = Color.Transparent;
            this.chartControl2.PrimaryXAxis.ForeColor = Color.Transparent;
            this.chartControl2.PrimaryYAxis.ForeColor = Color.Transparent;
            this.chartControl2.PrimaryXAxis.Range = new MinMaxInfo(0, 74, 1);
            this.chartControl2.PrimaryYAxis.Range = new MinMaxInfo(0, 90, 30);
            this.timer1.Start();
        }

        public List<PatientDetails> GetPatientDetails()
        {
            List<PatientDetails> patientDetails = new List<PatientDetails>();
            patientDetails.Add(new PatientDetails() { Name = "Jessie Mcferron", ID = 1, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image1.jpg", Sex = "Male", Block = "A", RoomNo = "1" });
            patientDetails.Add(new PatientDetails() { Name = "Erik Edgemon", ID = 2, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image2.jpg", Sex = "Female", Block = "A", RoomNo = "2" });
            patientDetails.Add(new PatientDetails() { Name = "Christian Tilson", ID = 3, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image3.jpg", Sex = "Male", Block = "A", RoomNo = "3" });
            patientDetails.Add(new PatientDetails() { Name = "Jessie Badgley", ID = 4, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image4.jpg", Sex = "Male", Block = "A", RoomNo = "4" });
            patientDetails.Add(new PatientDetails() { Name = "Ted Zinke", ID = 5, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image5.jpg", Sex = "Male", Block = "A", RoomNo = "5" });
            patientDetails.Add(new PatientDetails() { Name = "Julio Ice", ID = 6, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image6.jpg", Sex = "Female", Block = "A", RoomNo = "6" });
            patientDetails.Add(new PatientDetails() { Name = "Clayton Lillibridge", ID = 7, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image7.jpg", Sex = "Male", Block = "A", RoomNo = "7" });
            patientDetails.Add(new PatientDetails() { Name = "Mathew Lechler", ID = 8, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image8.jpg", Sex = "Male", Block = "A", RoomNo = "8" });
            patientDetails.Add(new PatientDetails() { Name = "Cody Paskett", ID = 9, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image13.jpg", Sex = "Female", Block = "A", RoomNo = "9" });
            patientDetails.Add(new PatientDetails() { Name = "Nelson Donnellan", ID = 10, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image10.jpg", Sex = "Male", Block = "A", RoomNo = "10" });
            patientDetails.Add(new PatientDetails() { Name = "Alejandra Mescher", ID = 11, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image11.jpg", Sex = "Male", Block = "A", RoomNo = "11" });
            patientDetails.Add(new PatientDetails() { Name = "Zazueta", ID = 1, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image4.jpg", Sex = "Female", Block = "B", RoomNo = "1" });
            patientDetails.Add(new PatientDetails() { Name = "Clayton Lebaron", ID = 2, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image8.jpg", Sex = "Male", Block = "B", RoomNo = "2" });
            patientDetails.Add(new PatientDetails() { Name = "JKarina Ziolkowski", ID = 3, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image1.jpg", Sex = "Female", Block = "B", RoomNo = "3" });
            patientDetails.Add(new PatientDetails() { Name = "Javier Vanleuven", ID = 4, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image9.jpg", Sex = "Male", Block = "B", RoomNo = "4" });
            patientDetails.Add(new PatientDetails() { Name = "Kelly Barga", ID = 5, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image10.jpg", Sex = "Male", Block = "B", RoomNo = "5" });
            patientDetails.Add(new PatientDetails() { Name = "Allan Quarterman", ID = 6, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image14.jpg", Sex = "Male", Block = "B", RoomNo = "6" });
            patientDetails.Add(new PatientDetails() { Name = "Tameka Douse", ID = 7, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image6.jpg", Sex = "Female", Block = "B", RoomNo = "7" });
            patientDetails.Add(new PatientDetails() { Name = "Tyrone Hadfield", ID = 8, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image3.jpg", Sex = "Male", Block = "B", RoomNo = "8" });
            patientDetails.Add(new PatientDetails() { Name = "Darcy Mascio", ID = 9, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image7.jpg", Sex = "Female", Block = "B", RoomNo = "9" });
            patientDetails.Add(new PatientDetails() { Name = "Gay Roeser", ID = 10, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image4.jpg", Sex = "Female", Block = "B", RoomNo = "10" });
            patientDetails.Add(new PatientDetails() { Name = "Lance Piotrowski", ID = 11, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image11.jpg", Sex = "Male", Block = "B", RoomNo = "11" });
            patientDetails.Add(new PatientDetails() { Name = "Louisa Fargo", ID = 1, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image7.jpg", Sex = "Female", Block = "C", RoomNo = "1" });
            patientDetails.Add(new PatientDetails() { Name = "Laconte", ID = 2, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image1.jpg", Sex = "Female", Block = "C", RoomNo = "2" });
            patientDetails.Add(new PatientDetails() { Name = "Alana Barranco", ID = 3, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image6.jpg", Sex = "Female", Block = "C", RoomNo = "3" });
            patientDetails.Add(new PatientDetails() { Name = "Kimbler Welsley", ID = 4, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image3.jpg", Sex = "Male", Block = "C", RoomNo = "4" });
            patientDetails.Add(new PatientDetails() { Name = "Allan Hoefler", ID = 5, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image5.jpg", Sex = "Male", Block = "C", RoomNo = "5" });
            patientDetails.Add(new PatientDetails() { Name = "Clayton Lokey", ID = 6, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image8.jpg", Sex = "Male", Block = "C", RoomNo = "6" });
            patientDetails.Add(new PatientDetails() { Name = "Darryl Saunier", ID = 7, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image10.jpg", Sex = "Male", Block = "C", RoomNo = "7" });
            patientDetails.Add(new PatientDetails() { Name = "Karina Ziolkowski", ID = 8, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image12.jpg", Sex = "Female", Block = "C", RoomNo = "8" });
            patientDetails.Add(new PatientDetails() { Name = "Mascio Lokey", ID = 9, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image14.jpg", Sex = "Female", Block = "C", RoomNo = "9" });
            patientDetails.Add(new PatientDetails() { Name = "Fernando Kirschbaum", ID = 10, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image4.jpg", Sex = "Male", Block = "C", RoomNo = "10" });
            patientDetails.Add(new PatientDetails() { Name = "John Mackerson", ID = 11, ImageName = "ms-appx:///Chart/ShowCase/HospitalDemo/Assets/Image5.jpg", Sex = "Male", Block = "C", RoomNo = "10" });
            Random rand = new Random();
            foreach (PatientDetails patient in patientDetails)
            {
                patient.BloodPressure = rand.Next(80, 190);
                patient.BloodPressure2 = rand.Next(60, 120);
                if (patient.BloodPressure > 160)
                    patient.TileColor = new System.Drawing.SolidBrush(Color.FromArgb(255, 177, 16, 16));
                else
                    patient.TileColor = new SolidBrush(Color.FromArgb(255, 12, 144, 192));
                patient.TileIntreval = new TimeSpan(0, 0, 0, rand.Next(2, 15));
                patient.Saturation = rand.Next(80, 99);
                patient.RespirationRate = rand.Next(16, 20);
                patient.HeartRate = rand.Next(75, 150);
                patient.Temperature = rand.Next(97, 106);
            }
            List<PatientDetails> temp = patientDetails.Where(p => p.BloodPressure > 160).ToList<PatientDetails>();
            return patientDetails;
        }
    }
}

