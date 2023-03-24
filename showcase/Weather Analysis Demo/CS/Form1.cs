#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
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
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Diagnostics;
using WindowsFormsApplication26;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms.Grid;
using System.Collections;
using Syncfusion.Windows.Forms;
using System.IO;
using Syncfusion.Windows.Forms.Chart;
using System.Drawing.Drawing2D;
using Syncfusion.WinForms.Controls;

namespace WeatherAnalysis
{
    public partial class Form1 : SfForm
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        private const int WM_SETREDRAW = 0xB;

        #region [ Touch Declaration ]
        public bool touchscroll = false;
        private Point _ptFirst = new Point();
        private Point _ptSecond = new Point();
        int First = 0;
        int Second = 0;
        private int _iArguments = 0;

        //-----------------------------------------------------------------------
        // Multitouch/Touch glue (from winuser.h file)
        // Since the managed layer between C# and WinAPI functions does not 
        // exist at the moment for multi-touch related functions this part of 
        // code is required to replicate definitions from winuser.h file.
        //-----------------------------------------------------------------------
        // Touch event window message constants [winuser.h]
        private const int WM_GESTURENOTIFY = 0x011A;
        private const int WM_GESTURE = 0x0119;

        private const int GC_ALLGESTURES = 0x00000001;

        // Gesture IDs 
        private const int GID_BEGIN = 1;
        private const int GID_END = 2;
        private const int GID_ZOOM = 3;
        private const int GID_PAN = 4;
        private const int GID_ROTATE = 5;
        private const int GID_TWOFINGERTAP = 6;
        private const int GID_PRESSANDTAP = 7;

        // Gesture flags - GESTUREINFO.dwFlags
        private const int GF_BEGIN = 0x00000001;
        private const int GF_INERTIA = 0x00000002;
        private const int GF_END = 0x00000004;


        // size of GESTURECONFIG structure
        private int _gestureConfigSize;
        // size of GESTUREINFO structure
        private int _gestureInfoSize;

        [StructLayout(LayoutKind.Sequential)]
        private struct GESTURECONFIG
        {
            public int dwID;    // gesture ID
            public int dwWant;  // settings related to gesture ID that are to be
            // turned on
            public int dwBlock; // settings related to gesture ID that are to be
            // turned off
        }
        [StructLayout(LayoutKind.Sequential)]
        private struct POINTS
        {
            public short x;
            public short y;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct GESTUREINFO
        {
            public int cbSize;           // size, in bytes, of this structure
            // (including variable length Args 
            // field)
            public int dwFlags;          // see GF_* flags
            public int dwID;             // gesture ID, see GID_* defines
            public IntPtr hwndTarget;    // handle to window targeted by this 
            // gesture
            [MarshalAs(UnmanagedType.Struct)]
            internal POINTS ptsLocation; // current location of this gesture
            public int dwInstanceID;     // internally used
            public int dwSequenceID;     // internally used
            public Int64 ullArguments;   // arguments for gestures whose 
            // arguments fit in 8 BYTES
            public int cbExtraArgs;      // size, in bytes, of extra arguments, 
            // if any, that accompany this gesture
        }
        // Currently touch/multitouch access is done through unmanaged code
        // We must p/invoke into user32 [winuser.h]
        [DllImport("user32")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetGestureConfig(IntPtr hWnd, int dwReserved, int cIDs, ref GESTURECONFIG pGestureConfig, int cbSize);

        [DllImport("user32")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetGestureInfo(IntPtr hGestureInfo, ref GESTUREINFO pGestureInfo);
        #endregion

        #region ChartGlobals
        Syncfusion.Windows.Forms.Chart.ChartPoint previousPoint = new Syncfusion.Windows.Forms.Chart.ChartPoint();
        Syncfusion.Windows.Forms.Chart.ChartPoint currentPoint = new Syncfusion.Windows.Forms.Chart.ChartPoint();
        TrackBall TrackBallInfo;
        bool ClearTrackBall = false;
        Point closestPoint;
        Rectangle bounds;
        Syncfusion.Windows.Forms.Chart.ChartPoint point;
        #endregion
        RotateLabel newlbl = new RotateLabel();
        public Form1()
        {
            WeatherAnalysisData expense = new WeatherAnalysisData();   
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.DoubleBuffered = true;
            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch
            {
            }
            TrackBallInfo = new TrackBall();
            InitializeChart();
            SetupStructSizes();
            this.DoubleBuffered = true;
            this.Shown += Form1_Shown;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.HorizontalScroll.Visible = true;

            #region [events]

            this.Scroll += new ScrollEventHandler(Form1_Scroll);
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
            this.Load += new EventHandler(Form1_Load);
            this.gridGroupingControl1.TableControlQueryAllowSortColumn += new GridQueryAllowSortColumnEventHandler(gridGroupingControl1_TableControlQueryAllowSortColumn);
            this.MouseWheel+=new MouseEventHandler(Form1_MouseWheel);
            #endregion

            #region [GridGroupingControl]
            this.gridGroupingControl1.DataSource = expense.Data;
            this.gridGroupingControl1.AllowProportionalColumnSizing = true;
            this.gridGroupingControl1.ShowRowHeaders = false;
            this.gridGroupingControl1.TableModel.EnableLegacyStyle = false;

            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordAfterDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.BrowseOnly = true;
            this.gridGroupingControl1.TableDescriptor.AllowEdit = false;

            this.gridGroupingControl1.TableOptions.AllowDragColumns = false;
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.HorizontalAlignment = GridHorizontalAlignment.Center;
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.VerticalAlignment = GridVerticalAlignment.Middle;
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.ShowButtons = GridShowButtons.Hide;
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyHeaderCell.Font.Size = 12;
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Font.Size = 16;

            this.gridGroupingControl1.TableDescriptor.Columns[1].HeaderText = "Weather";
            this.gridGroupingControl1.TableDescriptor.Columns[0].Appearance.AnyRecordFieldCell.Format = "hh:mm tt";
            this.gridGroupingControl1.TableDescriptor.Columns[3].Appearance.AnyRecordFieldCell.Format = "0°C";
            this.gridGroupingControl1.ShowCurrentCellBorderBehavior = GridShowCurrentCellBorder.HideAlways;



            /// Header Customization
            GridMetroColors headercolor = new GridMetroColors();
            headercolor.HeaderBottomBorderWeight = GridBottomBorderWeight.None;
            headercolor.HeaderColor.HoverColor = Color.FromArgb(79, 156, 66);
            headercolor.HeaderColor.NormalColor = Color.FromArgb(79, 156, 66);
            headercolor.HeaderColor.PressedColor = Color.FromArgb(79, 156, 66);
            headercolor.HeaderTextColor.NormalTextColor = Color.White;
            this.gridGroupingControl1.SetMetroStyle(headercolor);

            ///ScrollBar Customization
            this.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro;
            this.gridGroupingControl1.TableControl.MetroColorTable.ScrollerBackground = Color.FromArgb(134, 186, 53);

            /// Label initilization
          
            newlbl.Text = "";
            newlbl.AutoSize = false;
            newlbl.NewText = DateTime.Now.Date.DayOfWeek.ToString();
            newlbl.ForeColor = Color.White;
            newlbl.RotateAngle = -90;
            newlbl.Dock = DockStyle.Fill;
            newlbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Controls.Add(newlbl);

            // Adding Image path
            pb.Image = Image.FromFile(@"Images\\Umberlla_animate.gif");
            pb2.Image = Image.FromFile(@"Images\\Snow_Animation.gif");
            pb1.Image = Image.FromFile(@"Images\\Rain_Animate.gif");
            pb3.Image = Image.FromFile(@"Images\\Sun_Animation.gif");

            #region [label]
            string s = DateTime.Now.Date.Day + ", " + String.Format("{0:MMMM}", DateTime.Now) + " " + DateTime.Now.Date.Year + ", " + DateTime.Now.ToString("HH:mm tt") + ", " + DateTime.Now.Date.DayOfWeek;
            this.label5.Text = s;

            if (this.gridGroupingControl1.TableModel[5, 3].Text.Length > 8)
                this.label8.Text = "   " + this.gridGroupingControl1.TableModel[5, 3].Text;
            else
                this.label8.Text = "    " + this.gridGroupingControl1.TableModel[5, 3].Text;
            this.label7.Text = this.gridGroupingControl1.TableModel[5, 4].Text + "°C";
            this.label2.Text = this.gridGroupingControl1.TableModel[5, 5].Text + " %";
            this.label3.Text = this.gridGroupingControl1.TableModel[5, 6].Text + " %";

            int a = Convert.ToInt32(this.gridGroupingControl1.TableModel[5, 4].Text);
            if (a <= 3)
            {
                this.label8.Text = "Snow";
                this.pictureBox6.Image = Image.FromFile(@"Images\\Snowy.png");
            }
            else if (a < 25)
            {
                this.label8.Text = "Rainy";
                this.pictureBox6.Image = Image.FromFile(@"Images\\Rainy.png");
            }
            else if (a < 15)
            {
                this.label8.Text = "Rainy Storm";
                this.pictureBox6.Image = Image.FromFile(@"Images\\Rainy.png");
            }
            else
            {
                this.label8.Text = "Partly Sunny";
                this.pictureBox6.Image = Image.FromFile(@"Images\\Sun.png");
            }

            #endregion
            #region [panel]
            this.panel7.BackColor = Color.FromArgb(5, 66, 121);
            #endregion
            #endregion

            #region [Grid Grouping events]
            this.gridGroupingControl1.TableModel.QueryColWidth += new GridRowColSizeEventHandler(TableModel_QueryColWidth);
            this.gridGroupingControl1.TableControlResizingRows += new GridTableControlResizingRowsEventHandler(gridGroupingControl1_TableControlResizingRows);
            this.gridGroupingControl1.TableControlResizingColumns += new GridTableControlResizingColumnsEventHandler(gridGroupingControl1_TableControlResizingColumns);
            this.gridGroupingControl1.QueryCellStyleInfo += new GridTableCellStyleInfoEventHandler(gridGroupingControl1_QueryCellStyleInfo);
            #endregion

            //gif customization
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer() { Interval = 50 };
            t.Tick += new EventHandler(t_Tick);
            t.Start();
            this.gridGroupingControl1.TableModel.RowHeights[1] = 40;
            this.gridGroupingControl1.TableModel.ColWidths[4] = 100;

            for (int i = 2; i < this.gridGroupingControl1.TableModel.RowCount; i++)
            {
                this.gridGroupingControl1.TableModel.RowHeights[i] = 75;
            }
            this.gridGroupingControl1.ClientSize = new Size(this.gridGroupingControl1.TableModel.ColWidths.GetTotal(0, this.gridGroupingControl1.TableModel.ColCount), this.gridGroupingControl1.ClientSize.Height);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            TurnOffFormLevelDoubleBuffering();
        }

        void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            Point loc = Screen.GetBounds(this).Location;
            loc.X += 50;
            loc.Y += 10;
            this.label1.Location = loc;

        }

        #region Form Icon
        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
        }
        #endregion


        void gridGroupingControl1_TableControlQueryAllowSortColumn(object sender, GridQueryAllowSortColumnEventArgs e)
        {
            e.AllowSort = false;
        }
        int change_size = 0;
        void Form1_Load(object sender, EventArgs e)
        {
            #region [DPI Changes]
            using (Graphics dpi = this.CreateGraphics())
            {
                if (dpi.DpiX >= 120)
                {
                    Rectangle screenbounds = new Rectangle();
                    screenbounds = Screen.PrimaryScreen.Bounds;
                    if (screenbounds.Height < 1000)
                    {
                        this.label5.Location = new Point(this.label5.Location.X, this.label5.Location.Y - 40);
                        this.label6.Location = new Point(this.label6.Location.X, this.label6.Location.Y - 40);
                        this.pictureBox6.Location = new Point(this.pictureBox6.Location.X, this.pictureBox6.Location.Y - 70);
                        this.label7.Location = new Point(this.label7.Location.X, this.label7.Location.Y - 80);
                        this.label8.Location = new Point(this.label8.Location.X, this.label8.Location.Y - 90);
                        this.tableLayoutPanel1.Location = new Point(this.tableLayoutPanel1.Location.X, this.tableLayoutPanel1.Location.Y - 100);
                        this.tableLayoutPanel1.Size = new Size(this.tableLayoutPanel1.Size.Width - 30, this.tableLayoutPanel1.Size.Height - 20);

                        this.panel7.Location = new Point(this.panel7.Location.X - 300, this.panel7.Location.Y);
                        this.panel7.Size = new Size(this.panel7.Width, this.panel7.Height - (this.panel7.Height / 4));
                        this.panel2.Location = new Point(this.panel2.Location.X - 300, this.panel2.Location.Y);
                        this.panel2.Size = new Size(this.panel2.Width - 300, this.panel2.Height - (this.panel2.Height / 4));

                        this.panel3.Location = new Point(this.panel3.Location.X - 550, this.panel3.Location.Y);
                        this.panel3.Size = new Size(this.panel3.Width - 300, this.panel3.Height - (this.panel3.Height / 4));

                        this.label9.Location = new Point(this.label9.Location.X - 300, this.label9.Location.Y);
                        this.chartControl1.Size = new System.Drawing.Size(this.panel3.Size.Width - 125, this.chartControl1.Size.Height);
                        this.panel1.Size = new Size(this.panel1.Size.Width - 900, this.panel1.Size.Height);

                    }
                    this.pictureBox2.Size = new Size(96, 96);
                    this.pictureBox3.Size = new Size(96, 96);
                    change_size = this.gridGroupingControl1.ClientSize.Width - this.gridGroupingControl1.TableModel.ColWidths.GetTotal(0, this.gridGroupingControl1.TableModel.ColCount);
                    size_changed = true;
                  
                    this.tableLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
                }
            }
            #endregion

            this.label1.Focus();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        bool panelVisible = false;
        void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.ActiveControl != null)
            {
                if (this.CanFocus && (this.ActiveControl.Name == "chartControl1" || this.ActiveControl.Name == "tableControl1"))
                {
                    this.ActiveControl = null;
                }
            }
        }

        #region [Chart region]

        public void InitializeChart()
        {
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

            series.Style.Symbol.Shape = ChartSymbolShape.Circle;
            series1.Style.Symbol.Shape = ChartSymbolShape.Circle;
            series2.Style.Symbol.Shape = ChartSymbolShape.Circle;
            series3.Style.Symbol.Shape = ChartSymbolShape.Circle;

            series.Style.Symbol.Border.Color = Color.White;
            series1.Style.Symbol.Border.Color = Color.White;
            series2.Style.Symbol.Border.Color = Color.White;
            series3.Style.Symbol.Border.Color = Color.White;

            series.Style.Border.Width = 3;
            series1.Style.Border.Width = 3;
            series2.Style.Border.Width = 3;
            series3.Style.Border.Width = 3;

            series.Style.Interior = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#baee6a"));
            series1.Style.Interior = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#18a12b"));
            series2.Style.Interior = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#a3511a"));
            series3.Style.Interior = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#70c0f9"));

            series.Style.Symbol.Color = series.Style.Interior.BackColor;
            series1.Style.Symbol.Color = series1.Style.Interior.BackColor;
            series2.Style.Symbol.Color = series2.Style.Interior.BackColor;
            series3.Style.Symbol.Color = series3.Style.Interior.BackColor;

            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(79, 156, 66));
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Color.White);

            this.chartControl1.Series.Add(series);
            this.chartControl1.Series.Add(series1);
            this.chartControl1.Series.Add(series2);
            this.chartControl1.Series.Add(series3);
            this.chartControl1.ElementsSpacing = 0;
            this.chartControl1.ChartArea.ChartAreaMargins = new ChartMargins(0, 0, 0, 10);

            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Color.Green);

            this.chartControl1.ClientSize = new Size(this.chartControl1.ClientSize.Width + 13, this.chartControl1.ClientSize.Height);

            this.chartControl1.PrimaryXAxis.DrawGrid = false;
            this.chartControl1.PrimaryYAxis.GridLineType.ForeColor = Color.Gray;
            this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = Color.Transparent;
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

            this.chartControl1.ShowLegend = false;
            this.chartControl1.PrimaryXAxis.HidePartialLabels = true;
            this.chartControl1.ChartRegionMouseHover += chartControl1_ChartRegionMouseMove;
            this.chartControl1.Paint += chartControl1_Paint;

        }

        void chartControl1_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics gr = this.panel3.CreateGraphics())
            {
                gr.SmoothingMode = SmoothingMode.HighQuality;
                var text = new string[] { "Temp", "Feels like", "Humidity", "Wind" };
                var axisText = new string[] { "36", "106", "100", "200", "40", "100", "10", "40" };
                var labelSpacing = 10;
                var location = this.chartControl1.Location;
                var circleSize = new Size(60, 60);
                var startPoint = new Syncfusion.Windows.Forms.Chart.ChartPoint(this.chartControl1.PrimaryXAxis.Range.Min, this.chartControl1.PrimaryYAxis.Range.Min + this.chartControl1.PrimaryYAxis.Range.Min);
                var endPoint = new Syncfusion.Windows.Forms.Chart.ChartPoint(this.chartControl1.PrimaryXAxis.Range.Min, this.chartControl1.PrimaryYAxis.Range.Min + this.chartControl1.PrimaryYAxis.Range.Max);
                var dHeight = Math.Abs(this.chartControl1.ChartArea.GetPointByValue(startPoint).Y - this.chartControl1.ChartArea.GetPointByValue(new Syncfusion.Windows.Forms.Chart.ChartPoint(startPoint.X, startPoint.YValues[0] + this.chartControl1.PrimaryYAxis.Range.Interval)).Y) / 2 + circleSize.Height / 2;
                Font textFont = new Font("Arial", 8, FontStyle.Bold);
                int k = 0;
                for (double i = startPoint.YValues[0]; i < endPoint.YValues[0]; i += this.chartControl1.PrimaryYAxis.Range.Interval)
                {
                    var point = this.chartControl1.ChartArea.GetPointByValue(new Syncfusion.Windows.Forms.Chart.ChartPoint(this.chartControl1.PrimaryXAxis.Range.Min, i));
                    var brush = new SolidBrush(this.chartControl1.Series[k].Style.Interior.BackColor);
                    gr.FillEllipse(brush, location.X - circleSize.Width - labelSpacing, point.Y - dHeight, circleSize.Width, circleSize.Height);
                    var textSize = e.Graphics.MeasureString(text[k], Font, new PointF(location.X - circleSize.Width, point.Y - dHeight), StringFormat.GenericDefault);
                    gr.DrawString(text[k], Font, Brushes.White, new PointF(location.X - circleSize.Width / 2 - labelSpacing - (textSize.Width / 2), point.Y - dHeight + circleSize.Height / 2 - textSize.Height / 2), StringFormat.GenericDefault);
                    k++;
                }
            }
            if (ClearTrackBall)
            {
                TrackBallInfo.TrackBallLine.Color = Color.Orange;
                TrackBallInfo.TrackBallLine.Width = 2;
                e.Graphics.DrawLine(TrackBallInfo.TrackBallLine, closestPoint.X, bounds.Top, closestPoint.X, bounds.Bottom);
                DrawTrackBallToolTip(e.Graphics, point);
                ClearTrackBall = false;
            }
        }

        void chartControl1_ChartRegionMouseMove(object sender, ChartRegionMouseEventArgs e)
        {
            bounds = this.chartControl1.ChartArea.RenderBounds;
            if (e.Point.X > bounds.Left && e.Point.X < bounds.Right && e.Point.Y > bounds.Top && e.Point.Y < bounds.Bottom)
            {

                point = FindClosestChartPoint(e.Point);
                closestPoint = this.chartControl1.ChartArea.GetPointByValue(point);
                currentPoint = point;
                if (previousPoint.X != currentPoint.X)
                {
                    ClearTrackBall = true;
                    this.chartControl1.Refresh();
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
                            toolTipText = (series.Points[i].YValues[0] + 10).ToString();
                            DrawToolTip(g, location, toolTipText + (Char)176 + "F", TrackBallInfo.SymbolColor.Color);
                        }
                        else if (series.Name.Equals("HR"))
                        {
                            toolTipText = (series.Points[i].YValues[0]).ToString();
                            DrawToolTip(g, location, toolTipText, TrackBallInfo.SymbolColor.Color);
                        }
                        else if (series.Name.Equals("RR"))
                        {
                            toolTipText = (series.Points[i].YValues[0] + 17).ToString();
                            DrawToolTip(g, location, toolTipText, TrackBallInfo.SymbolColor.Color);
                        }
                        else
                        {
                            toolTipText = (series.Points[i].YValues[0] - 95).ToString();
                            DrawToolTip(g, location, toolTipText, TrackBallInfo.SymbolColor.Color);
                        }
                        DrawAxisLabelToolTip(g, location, series.Points[i].DateX.ToString("hh:mm:ss \n MM/dd"));
                        break;
                    }
        }

        private void DrawAxisLabelToolTip(Graphics g, Point location, string toolTipText)
        {
            SizeF sz = g.MeasureString(toolTipText, TrackBallInfo.ToolTipFont, location, StringFormat.GenericDefault);
            Rectangle rect = new Rectangle((int)(location.X - (sz.Width / 2) - 10), this.chartControl1.ChartArea.RenderBounds.Bottom + 2, (int)sz.Width + 20, (int)sz.Height + 7);
            GraphicsPath gp = new GraphicsPath();
            PointF[] points ={new PointF(rect.X, rect.Y), 
                            new PointF(rect.X+rect.Width/2-5, rect.Y), new PointF(rect.X+rect.Width/2, rect.Y-5),
                            new PointF(rect.X+rect.Width/2+5, rect.Y),
                            new PointF(rect.X+rect.Width, rect.Y), new PointF(rect.X+rect.Width, rect.Y+rect.Height),
                            new PointF(rect.X, rect.Y+rect.Height)};

            g.FillPolygon(Brushes.White, points);
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

        #endregion

        // Image declaration
        PictureBox pb = new PictureBox();
        PictureBox pb2 = new PictureBox();
        PictureBox pb1 = new PictureBox();
        PictureBox pb3 = new PictureBox();

        // gif image customization
        void t_Tick(object sender, EventArgs e)
        {
            if (this.gridGroupingControl1.TableControl.CurrentCell != null)
            {
                this.gridGroupingControl1.TableControl.RefreshRange(GridRangeInfo.Col(2));
            }
        }
        bool size_changed = false;
        #region [events customization]
        void TableModel_QueryColWidth(object sender, GridRowColSizeEventArgs e)
        {
            if (e.Index == 4)
                e.Size = 150;
            if (e.Index == 3)
                e.Size = 200;
            if (e.Index == 2)
                e.Size = 100;
            if (e.Index == 7 && size_changed)
                e.Size += change_size + 12;
        }

        void gridGroupingControl1_TableControlResizingRows(object sender, GridTableControlResizingRowsEventArgs e)
        {
            e.Inner.Cancel = true;
        }

        void gridGroupingControl1_TableControlResizingColumns(object sender, GridTableControlResizingColumnsEventArgs e)
        {
            e.Inner.Cancel = true;
        }

        void gridGroupingControl1_QueryCellStyleInfo(object sender, Syncfusion.Windows.Forms.Grid.Grouping.GridTableCellStyleInfoEventArgs e)
        {
            // Disable Border Line
            e.Style.Borders.Right = GridBorder.Empty;
            e.Style.Borders.Bottom = GridBorder.Empty;

            if (e.Style.CellType == "ColumnHeaderCell")
            {
                e.Style.Enabled = false;
                e.Handled = false;
            }
            // Adding Weather Condition images
            if (e.TableCellIdentity.ColIndex == 2 && e.TableCellIdentity.RowIndex != 1)
            {
                if (e.Style.Text == "Rainy")
                {

                    e.Style.CellType = "Control";
                    e.Style.Control = pb;
                }
                else if (e.Style.Text == "Rainy Storm" || e.Style.Text == "Cloudy")
                {
                    e.Style.CellType = "Control";
                    e.Style.Control = pb2;

                }
                else if (e.Style.Text == "Snow")
                {

                    e.Style.CellType = "Control";
                    e.Style.Control = pb1;
                }
                else
                {
                    e.Style.CellType = "Control";
                    e.Style.Control = pb3;
                }
            }
        }
        #endregion

        bool enableFormLevelDoubleBuffering = true;

        private void TurnOffFormLevelDoubleBuffering()
        {
            enableFormLevelDoubleBuffering = false;
            this.MaximizeBox = false;
        }

        int originalExStyle = -1;

        protected override CreateParams CreateParams
        {
            get
            {
                if (originalExStyle == -1)
                    originalExStyle = base.CreateParams.ExStyle;

                CreateParams cp = base.CreateParams;
                if (enableFormLevelDoubleBuffering)
                    cp.ExStyle |= 0x02000000;   // WS_CLIPCHILDREN
                else
                    cp.ExStyle = originalExStyle;

                return cp;
            }
        }

        #region [ Touch Overrides ]
        [SecurityPermission(SecurityAction.Demand)]
        private void SetupStructSizes()
        {
            // Both GetGestureCommandInfo and GetTouchInputInfo need to be
            // passed the size of the structure they will be filling
            // we get the sizes upfront so they can be used later.
            _gestureConfigSize = Marshal.SizeOf(new GESTURECONFIG());
            _gestureInfoSize = Marshal.SizeOf(new GESTUREINFO());
        }

        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        protected override void WndProc(ref Message m)
        {
            bool handled;
            handled = false;

            switch (m.Msg)
            {
                case WM_GESTURENOTIFY:
                    {
                        // This is the right place to define the list of gestures
                        // that this application will support. By populating 
                        // GESTURECONFIG structure and calling SetGestureConfig 
                        // function. We can choose gestures that we want to 
                        // handle in our application. In this app we decide to 
                        // handle all gestures.
                        GESTURECONFIG gc = new GESTURECONFIG();
                        gc.dwID = 0;                // gesture ID
                        gc.dwWant = GC_ALLGESTURES; // settings related to gesture
                        // ID that are to be turned on
                        gc.dwBlock = 0; // settings related to gesture ID that are
                        // to be     

                        // We must p/invoke into user32 [winuser.h]
                        bool bResult = SetGestureConfig(
                            Handle, // window for which configuration is specified
                            0,      // reserved, must be 0
                            1,      // count of GESTURECONFIG structures
                            ref gc, // array of GESTURECONFIG structures, dwIDs 
                                    // will be processed in the order specified 
                                    // and repeated occurances will overwrite 
                                    // previous ones
                            _gestureConfigSize // sizeof(GESTURECONFIG)
                        );

                        if (!bResult)
                        {
                            throw new Exception("Error in execution of SetGestureConfig");
                        }
                    }
                    handled = true;
                    break;

                case WM_GESTURE:
                    // The gesture processing code is implemented in 
                    // the DecodeGesture method
                    handled = DecodeGesture(ref m);
                    break;

                default:
                    handled = false;
                    break;
            }

            // Filter message back up to parents.
            base.WndProc(ref m);

            if (handled)
            {
                // Acknowledge event if handled.
                try
                {
                    m.Result = new System.IntPtr(1);
                }
                catch (Exception excep)
                {
                    Debug.Print("Could not allocate result ptr");
                    Debug.Print(excep.ToString());
                }
            }
        }
        GridRangeInfo beginRange, endRange;
        Bitmap gridBitmap;
        Point drawingLocation;
        private bool DecodeGesture(ref Message m)
        {
            touchscroll = true;
          
            GESTUREINFO gi;

            try
            {
                gi = new GESTUREINFO();
            }
            catch (Exception excep)
            {
                Debug.Print("Could not allocate resources to decode gesture");
                Debug.Print(excep.ToString());

                return false;
            }

            gi.cbSize = _gestureInfoSize;

            // Load the gesture information.
            // We must p/invoke into user32 [winuser.h]
            if (!GetGestureInfo(m.LParam, ref gi))
            {
                return false;
            }

            switch (gi.dwID)
            {
                case GID_BEGIN:
                case GID_END:
                    break;

                case GID_PAN:
                    switch (gi.dwFlags)
                    {
                        case GF_BEGIN:
                            First = gi.ptsLocation.x;
                            _ptFirst.X = gi.ptsLocation.x;
                            _ptFirst.Y = gi.ptsLocation.y;
                            _ptFirst = PointToClient(_ptFirst);


                            break;
                        default:
                            // We read the second point of this gesture. It is a
                            // middle point between fingers in this new position
                            _ptSecond.X = gi.ptsLocation.x;
                            _ptSecond.Y = gi.ptsLocation.y;
                            _ptSecond = PointToClient(_ptSecond);
                            Second = _ptSecond.X;
                            
                            #region [ Grouping ]
                            drawingLocation = _ptSecond;
                            // We apply move operation of the object
                            if (_ptSecond.X >= this.panel2.Location.X && _ptSecond.Y >= this.panel2.Location.Y && this._ptSecond.X <= (this.panel2.Location.X + this.panel2.Width) && this._ptSecond.Y <= (this.panel2.Location.Y + this.panel2.Height))
                            {
                                beginRange = this.gridGroupingControl1.TableControl.PointToRangeInfo(_ptFirst);
                                if (beginRange.Top != 0 && _ptFirst != _ptSecond)
                                {
                                    if (_ptSecond.Y > _ptFirst.Y)
                                    {
                                        if (beginRange.Bottom > 10)
                                        {
                                            if (beginRange.Bottom - 10 < this.gridGroupingControl1.TableControl.TopRowIndex)
                                            {
                                                this.gridGroupingControl1.TableControl.ScrollCellInView(beginRange.Bottom - 10, beginRange.Left, GridScrollCurrentCellReason.MoveTo);
                                            }
                                            else if (beginRange.Bottom - 10 > this.gridGroupingControl1.TableControl.TopRowIndex)
                                            {
                                                this.gridGroupingControl1.TableControl.ScrollCellInView(this.gridGroupingControl1.TableControl.TopRowIndex, beginRange.Left, GridScrollCurrentCellReason.MoveTo);
                                            }
                                        }
                                        else
                                        {
                                            this.gridGroupingControl1.TableControl.ScrollCellInView(0, 0, GridScrollCurrentCellReason.MoveTo);
                                        }

                                    }
                                    else if (_ptSecond.Y < _ptFirst.Y)
                                    {
                                        if (beginRange.Bottom + 10 < this.gridGroupingControl1.TableModel.RowCount)
                                        {
                                            this.gridGroupingControl1.TableControl.ScrollCellInView(beginRange.Bottom + 10, beginRange.Left, GridScrollCurrentCellReason.MoveTo);
                                        }
                                        else if (beginRange.Bottom + 10 > this.gridGroupingControl1.TableModel.RowCount)
                                        {
                                            this.gridGroupingControl1.TableControl.ScrollCellInView(this.gridGroupingControl1.TableModel.RowCount, beginRange.Left, GridScrollCurrentCellReason.MoveTo);
                                        }
                                    }
                                    else if (_ptSecond.X > _ptFirst.X)
                                    {
                                        if (beginRange.Left - 10 < this.gridGroupingControl1.TableControl.LeftColIndex)
                                        {
                                            this.gridGroupingControl1.TableControl.ScrollCellInView(beginRange.Top, (beginRange.Left - 10 > this.gridGroupingControl1.TableControl.LeftColIndex ? beginRange.Left - 10 : this.gridGroupingControl1.TableControl.LeftColIndex), GridScrollCurrentCellReason.MoveTo);
                                        }
                                    }
                                    else if (_ptSecond.X < _ptFirst.X)
                                    {
                                        if (beginRange.Left + 10 < this.gridGroupingControl1.TableModel.ColCount)
                                        {
                                            this.gridGroupingControl1.TableControl.ScrollCellInView(beginRange.Top, beginRange.Left + 10, GridScrollCurrentCellReason.MoveTo);
                                        }
                                        else if (beginRange.Left + 10 > this.gridGroupingControl1.TableModel.ColCount)
                                        {
                                            this.gridGroupingControl1.TableControl.ScrollCellInView(beginRange.Top, this.gridGroupingControl1.TableModel.ColCount, GridScrollCurrentCellReason.MoveTo);
                                        }
                                        Bitmap bm = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height);
                                        this.gridGroupingControl1.TableControl.DrawToBitmap(bm, this.ClientRectangle);
                                        gridBitmap = bm;
                                        Graphics g = null;
                                        try
                                        {
                                            g = Graphics.FromImage(bm);
                                            g.DrawImage(bm, _ptSecond);
                                        }
                                        finally
                                        {
                                            if (g != null)
                                            {
                                                // g.Dispose();
                                            }
                                        }
                                    }
                                }
                            }
                            #endregion
                            // We have to copy second point into first one to
                            // prepare for the next step of this gesture.
                            _ptFirst = _ptSecond;
                            break;
                    }
                    break;
            }

            return true;
        }

        #endregion

        void Form1_Scroll(object sender, ScrollEventArgs e)
        {
            Point loc = Screen.GetBounds(this).Location;
            loc.X += 50;
            loc.Y += 10;
            this.label1.Location = loc;
        }

    }

    class MyPanel : Panel
    {
        public MyPanel()
        {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }
    }

    class MyTableLayoutPanel : TableLayoutPanel
    {
        public MyTableLayoutPanel()
        {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }
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
            ToolTipFont = new Font("Segoe UI", 9,FontStyle.Bold);
            TextColor = new SolidBrush(Color.Transparent);
            SymbolBorder = new Pen(Color.Transparent);
            SymbolColor = new SolidBrush(Color.Transparent);
            SymbolSize = new Size();
        }
    }
}
