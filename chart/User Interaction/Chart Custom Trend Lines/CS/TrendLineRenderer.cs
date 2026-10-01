using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ClickPointDemo2
{
    class TrendLineRenderer
    {
        ChartControl chart;
        Point mDown = Point.Empty;
        ChartSeries draggingTrendLineSeries = null;

        public TrendLineRenderer(ChartControl chart)
        {
            this.chart = chart;
            this.chart.MouseDown += new MouseEventHandler(chart_MouseDown);
            this.chart.MouseUp += new MouseEventHandler(chart_MouseUp);
            this.chart.MouseMove += new MouseEventHandler(chart_MouseMove);
        }

        private Color lineUpColor = Color.DarkGreen;
        /// <summary>
        /// Specifies the color to draw the trendline in when indicating a upward trend
        /// </summary>
        public Color LineUpColor
        {
            get { return lineUpColor; }
            set { lineUpColor = value; }
        }

        private Color lineDownColor = Color.Blue;
        /// <summary>
        /// Specifies the color to draw the trendline in when indicating a downward trend
        /// </summary>
        public Color LineDownColor
        {
            get { return lineDownColor; }
            set { lineDownColor = value; }
        }


        private int lineWidth = 2;
        /// <summary>
        /// Specifies the minimum width a trend line can be drawn with
        /// </summary>
        public int LineWidth
        {
            get { return lineWidth; }
            set { lineWidth = value; }
        }

        private DashStyle lineStyle;
        public DashStyle LineStyle
        {
            get { return lineStyle; }
            set { lineStyle = value; }
        }

        private ChartSymbolShape lineSymbol;
        public ChartSymbolShape LineSymbol
        {
            get { return lineSymbol; }
            set { lineSymbol = value; }
        }

        private Color lineSymbolColor = Color.Yellow;
        public Color LinesymbolColor
        {
            get { return lineSymbolColor; }
            set { lineSymbolColor = value; }
        }

        private Size lineSymbolSize = new Size(9, 9);
        public Size LineSymbolSize
        {
            get { return lineSymbolSize; }
            set { lineSymbolSize = value; }
        }

        void chart_MouseMove(object sender, MouseEventArgs e)
        {
            this.MouseMove(e.Location);
        }

        void chart_MouseUp(object sender, MouseEventArgs e)
        {
            this.MouseUp(e.Location);
        }

        void chart_MouseDown(object sender, MouseEventArgs e)
        {
            this.MouseDown(e.Location);
        }

        public void MouseDown(Point pt)
        {
            if (this.chart.ChartArea.RenderBounds.Contains(pt))
                this.mDown = pt;
        }

        public void MouseMove(Point pt)
        {
            if (this.mDown != Point.Empty)
            {
                if (this.IsDragging == false)
                    this.StartDragging(pt);
                else
                    this.UpdateDragPoint(pt);
            }
        }

        public void MouseUp(Point pt)
        {
            if (this.IsDragging)
                this.EndDragging(pt);
            else
                this.mDown = Point.Empty;
        }

        #region DraggingCode
        private bool isDragging = false;
        private bool IsDragging
        {
            get { return this.isDragging; }
            set
            {
                if (isDragging != value)
                {
                    this.isDragging = value;
                    if (this.isDragging == false)
                    {
                        this.mDown = Point.Empty;
                        if (this.draggingTrendLineSeries != null)
                        {
                            this.chart.Series.Remove(this.draggingTrendLineSeries);
                            this.draggingTrendLineSeries = null;
                        }
                    }
                    else
                    {
                        if (this.mDown == Point.Empty)
                            throw new Exception("Always set IsDragging to true after setting a valid value on the mDown.");
                    }
                }
            }
        }

        private void StartDragging(Point mousePoint)
        {
            this.IsDragging = true;

            this.draggingTrendLineSeries = this.CreateNewSeries(this.mDown, mousePoint);

            this.UpdateTrendLineColor(this.draggingTrendLineSeries);
        }

        private void UpdateDragPoint(Point pt)
        {
            ChartPoint ptEnd = this.chart.ChartArea.GetValueByPoint(pt);

            this.draggingTrendLineSeries.Points[1].X = ptEnd.X;
            this.draggingTrendLineSeries.Points[1].YValues[0] = ptEnd.YValues[0];

            this.UpdateTrendLineColor(this.draggingTrendLineSeries);
        }

        private void EndDragging(Point pt)
        {
            if (this.IsDragging)
            {
                if (this.chart.ChartArea.RenderBounds.Contains(pt))
                {
                    if (Math.Abs(this.mDown.X - pt.X) > 10 || Math.Abs(this.mDown.Y - pt.Y) > 10)
                    {
                        this.AddTrendLine(this.mDown, pt);

                    }
                }
                this.IsDragging = false;
            }
            Console.WriteLine(this.mDown.ToString() + " ,  " + pt.ToString());
        }

        public ChartSeries CreateNewSeries(Point start, Point end)
        {
            ChartPoint ptStart = this.chart.ChartArea.GetValueByPoint(start);
            ChartPoint ptEnd = this.chart.ChartArea.GetValueByPoint(end);

            ChartSeries tseries = new ChartSeries("Dragging TrendLine", ChartSeriesType.Line);

            tseries.Points.Add(ptStart);
            tseries.Points.Add(ptEnd);

            this.chart.Series.Add(tseries);

            //tseries.LegendItem.Visible = false;

            return tseries;
        }

        public void AddTrendLine(Point start, Point end)
        {
            ChartSeries newSeries = this.CreateNewSeries(start, end);

            this.UpdateTrendLineColor(newSeries);

        }

        public void UpdateTrendLineColor(ChartSeries newSeries)
        {
            ChartPoint ptStart = newSeries.Points[0];
            ChartPoint ptEnd = newSeries.Points[1];
            // Specify the color for the lines
            newSeries.Style.Interior = new Syncfusion.Drawing.BrushInfo(ptStart.YValues[0] < ptEnd.YValues[0] ? this.LineUpColor : this.LineDownColor);
            newSeries.Style.Border.Width = this.LineWidth;
            newSeries.Style.Border.DashStyle = this.lineStyle;
            newSeries.Style.Symbol.Color = this.LinesymbolColor;
            newSeries.Style.Symbol.Shape = this.LineSymbol;
            newSeries.Style.Symbol.Size = this.LineSymbolSize;
            newSeries.Style.ToolTip = "Date  : " + newSeries.Points[0].DateX.ToString() + "\nValue :" + newSeries.Points[0].YValues[0].ToString();
        }
        #endregion
    }
}
