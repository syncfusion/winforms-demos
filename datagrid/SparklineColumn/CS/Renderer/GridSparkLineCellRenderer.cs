#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Interactivity;
using Syncfusion.WinForms.DataGrid.Renderers;
using Syncfusion.WinForms.DataGrid.Styles;
using Syncfusion.WinForms.GridCommon.ScrollAxis;

namespace SparklineColumn
{
    /// <summary>
    /// Represents the class that used for drawing the spark line cell.
    /// </summary>
    public class GridSparklineCellRenderer : GridCellRendererBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GridSparklineCellRenderer"/> class.
        /// </summary>
        /// <param name="sparkline">The sparkline.</param>
        /// <param name="dataGrid">The DataGrid.</param>
        public GridSparklineCellRenderer(Syncfusion.Windows.Forms.Chart.SparkLine sparkline, SfDataGrid dataGrid)
        {
            Sparkline = sparkline;
            DataGrid = dataGrid;
            IsEditable = false;
        }
       
        /// <summary>
        /// Gets or Sets to specifies the datagrid.
        /// </summary>
        protected SfDataGrid DataGrid { get; set; }

        /// <summary>
        /// Gets the Sparkline control used to draw the SparkLine.
        /// </summary>
        protected SparkLine Sparkline { get; set; }

        ///<summary>
        ///Renders the line type Sparkline.
        ///</summary>
        ///<param name="graphics">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        ///<param name="sparkline">The Sparkline.</param>
        public void DrawSparkline(Graphics graphics, Syncfusion.Windows.Forms.Chart.SparkLine sparkline)
        {
            SparkLineSource sparkLineSource = new SparkLineSource();
            int areaMarginX = 3;
            int areaMarginY = 3;
            double firstPointX = 0, firstPointY = 0, secondPointX = 0, secondPointY = 0;
            double areaWidth = sparkline.ControlWidth - areaMarginX * areaMarginX;
            double areaHeight = sparkline.ControlHeight - areaMarginY * areaMarginY;

            var sourceList = (List<object>)sparkLineSource.GetSourceList(sparkline.Source, sparkline);

            if (sourceList.Count == 0)
                return;

            double lineInterval = areaWidth / (sourceList.Count);
            double lineRange = sparkline.HighPoint - sparkline.LowPoint;

            for (int i = 0; i < sourceList.Count; i++)
            {
                double Value = Convert.ToDouble(sourceList[i]) - sparkline.LowPoint;

                secondPointX = firstPointX;
                secondPointY = firstPointY;

                firstPointX = this.Sparkline.Location.X + (lineInterval * i + (lineInterval / 2));
                firstPointY = this.Sparkline.Location.Y + (areaHeight - (areaHeight * (Value / lineRange)));

                if (i > 0)
                    graphics.DrawLine(new Pen(sparkline.LineStyle.LineColor, 1), (float)(areaMarginX + firstPointX), (float)(areaMarginY + firstPointY), (float)(areaMarginX + secondPointX), (float)(areaMarginY + secondPointY));

                if (sparkline.Markers.ShowMarker)
                    graphics.FillEllipse(new SolidBrush(sparkline.Markers.MarkerColor.BackColor), (float)(areaMarginX + firstPointX - 2), (float)(areaMarginY + firstPointY - 2), 5, 5);
                if (Convert.ToDouble(sourceList[i]) == sparkline.StartPoint && sparkline.Markers.ShowStartPoint)
                    graphics.FillEllipse(new SolidBrush(sparkline.Markers.StartPointColor.BackColor), (float)(areaMarginX + firstPointX - 2), (float)(areaMarginY + firstPointY - 2), 5, 5);
                if (Convert.ToDouble(sourceList[i]) == sparkline.EndPoint && sparkline.Markers.ShowEndPoint)
                    graphics.FillEllipse(new SolidBrush(sparkline.Markers.EndPointColor.BackColor), (float)(areaMarginX + firstPointX - 2), (float)(areaMarginY + firstPointY - 2), 5, 5);

                if (sparkline.GetNegativePoint() != null)
                {
                    int count = sparkline.GetNegativePoint().GetUpperBound(0);
                    for (int k = 0; k <= count; k++)
                    {
                        if (Convert.ToDouble(sourceList[i]) == (double)sparkline.GetNegativePoint().GetValue(k) && sparkline.Markers.ShowNegativePoint)
                            graphics.FillEllipse(new SolidBrush(sparkline.Markers.NegativePointColor.BackColor), (float)(areaMarginX + firstPointX - 2), (float)(areaMarginY + firstPointY - 2), 5, 5);
                    }
                }

                if (Convert.ToDouble(sourceList[i]) == sparkline.HighPoint && sparkline.Markers.ShowHighPoint)
                    graphics.FillEllipse(new SolidBrush(sparkline.Markers.HighPointColor.BackColor), (float)(areaMarginX + firstPointX - 2), (float)(areaMarginY + firstPointY - 2), 5, 5);
                if (Convert.ToDouble(sourceList[i]) == sparkline.LowPoint && sparkline.Markers.ShowLowPoint)
                    graphics.FillEllipse(new SolidBrush(sparkline.Markers.LowPointColor.BackColor), (float)(areaMarginX + firstPointX - 2), (float)(areaMarginY + firstPointY - 2), 5, 5);
            }
        }

        ///<summary>
        ///Renders the Column type Sparkline.
        ///</summary>
        ///<param name="paint">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        ///<param name="sparkline">The Sparkline.</param>
        public void DrawSparkColumn(Graphics paint, Syncfusion.Windows.Forms.Chart.SparkLine sparkline)
        {
            int areaMarginX = 3;
            int areaMarginY = 3;
            var isNegative = false;
            int centerY = sparkline.ControlHeight / 2;
            double firstPointX = 0, firstPointY = 0;
            double areaWidth = sparkline.ControlWidth - areaMarginX * areaMarginX;
            double areaHeight = sparkline.ControlHeight - areaMarginY * areaMarginX;
            SparkLineSource sparkLineSource = new SparkLineSource();
            var sourceList = (List<object>)sparkLineSource.GetSourceList(sparkline.Source, sparkline);

            if (sourceList.Count == 0)
                return;

            double lineInterval = areaWidth / (sourceList.Count);
            double lineRange = sparkline.HighPoint - 0;
            int valueY = 0;
            sparkline.NegativeItem = new double[sourceList.Count];

            for (int k = 0; k < sourceList.Count; k++)
            {
                double Value = Convert.ToDouble(sourceList[k]);
                valueY = (int)Math.Abs(Value);
                if (Value < 0)
                    isNegative = true;

                firstPointX = this.Sparkline.Location.X + lineInterval * k + (lineInterval / 2);
                firstPointY = this.Sparkline.Location.Y + (areaHeight * Value / lineRange);
                if (!isNegative)
                {
                    if (Value > 0)
                    {
                        Rectangle rect = new Rectangle(((int)(areaMarginX + firstPointX - lineInterval / 2)), (int)(areaHeight - firstPointY), (int)(lineInterval), (int)Math.Abs(Value));
                        BrushInfo interior = GetInteriorColumn(Value, sparkline, isNegative);
                        rect.Y = rect.Y - (int)Math.Abs(Value);
                        BrushPaint.FillRectangle(paint, rect, interior);
                    }
                }
                else
                {
                    lineRange = sparkline.HighPoint - sparkline.LowPoint;
                    firstPointX = this.Sparkline.Location.X + lineInterval * k + (lineInterval / 2);
                    firstPointY = this.Sparkline.Location.Y + (areaHeight * Value / lineRange);
                    Rectangle rect = new Rectangle((int)(areaMarginX + firstPointX - lineInterval / 2 + sparkline.ColumnStyle.ColumnSpace), (int)(firstPointY + areaMarginY), (int)(lineInterval), (int)Math.Abs(Value));
                    BrushInfo interior = GetInteriorColumn(Value, sparkline, isNegative);
                    BrushPaint.FillRectangle(paint, rect, interior);
                }
            }
        }

        ///<summary>
        ///Renders the Column type Sparkline.
        ///</summary>
        ///<param name="paint">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        ///<param name="sparkline">The spakrline.</param>
        public void DrawSparkWinLossColumn(Graphics paint, Syncfusion.Windows.Forms.Chart.SparkLine sparkline)
        {
            SparkLineSource sparkLineSource = new SparkLineSource();
            int areaMarginX = 3;
            int areaMarginY = 3;
            var sourceList = (List<object>)sparkLineSource.GetSourceList(sparkline.Source, sparkline);

            if (sourceList.Count > 0)
            {
                double areaWidth = sparkline.ControlWidth - areaMarginX * 2;
                double areaHeight = sparkline.ControlHeight - areaMarginY * 2;

                double areaHeightCenter = areaHeight / 2;
                int valueY = 0, pointY = 0;
                double lineInterval = areaWidth / (sourceList.Count);

                for (int i = 0; i < sourceList.Count; i++)
                {
                    double Value = Convert.ToDouble(sourceList[i]);
                    double firstPointX = this.Sparkline.Location.X + lineInterval * i + (lineInterval / 2);
                    double firstPointY = this.Sparkline.Location.Y + (lineInterval / 2);
                    if (Value > 0)
                    {
                        valueY = (int)Math.Abs(Value);
                        Rectangle rect = new Rectangle((int)(areaMarginX + firstPointX - lineInterval / 2 + sparkline.ColumnStyle.ColumnSpace), (int)(firstPointY + lineInterval), (int)(lineInterval - sparkline.ColumnStyle.ColumnSpace * 2), (int)Math.Abs(Value));
                        BrushInfo interior = GetInteriorWinLoss(Value, sparkline);
                        rect.Y = rect.Y - (int)Math.Abs(Value);
                        BrushPaint.FillRectangle(paint, rect, interior);
                        pointY = rect.Y + (int)Math.Abs(Value);
                    }
                    else
                    {
                        Rectangle rect = new Rectangle((int)(areaMarginX + firstPointX - lineInterval / 2 + sparkline.ColumnStyle.ColumnSpace), pointY, (int)(lineInterval - sparkline.ColumnStyle.ColumnSpace * 2), (int)Math.Abs(Value));
                        BrushInfo interior = GetInteriorWinLoss(Value, sparkline);
                        BrushPaint.FillRectangle(paint, rect, interior);
                    }
                }
            }
        }

        /// <summary>
        /// Overridden to draw the spark line of the cell.
        /// </summary>
        /// <param name="graphics">The <see cref="T:System.Drawing.Graphics"/> that used to draw the spark line.</param>
        /// <param name="cellRect">The cell rectangle.</param>
        /// <param name="cellValue">The cell value.</param>
        /// <param name="style">The CellStyleInfo of the cell.</param>
        /// <param name="column">The DataColumnBase of the cell.</param>
        /// <param name="rowColumnIndex">The row and column index of the cell.</param>
        protected override void OnRender(Graphics graphics, Rectangle cellRect, string cellValue, CellStyleInfo style, DataColumnBase column, RowColumnIndex rowColumnIndex)
        {
            using (SolidBrush brush = new SolidBrush(style.BackColor))
                graphics.FillRectangle(brush, cellRect);

            var sparklineColumn = column.GridColumn as GridSparklineColumn;
            this.Sparkline = new Syncfusion.Windows.Forms.Chart.SparkLine();
            var record = this.DataGrid.GetRecordAtRowIndex(rowColumnIndex.RowIndex);

            this.Sparkline.Source = GetSparklineSource(column.GridColumn.MappingName, record);
            this.Sparkline.Type = sparklineColumn.SparklineType;
            this.Sparkline.Markers.ShowEndPoint = true;
            this.Sparkline.Markers.ShowHighPoint = true;
            this.Sparkline.Markers.ShowLowPoint = true;
            this.Sparkline.Markers.ShowMarker = true;
            this.Sparkline.Markers.ShowNegativePoint = true;
            this.Sparkline.Markers.ShowStartPoint = true;
            this.Sparkline.Size = cellRect.Size;
            this.Sparkline.Location = cellRect.Location;

            var smoothingMode = graphics.SmoothingMode;
            var clipBounds = graphics.VisibleClipBounds;
            graphics.SetClip(cellRect);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            if (this.Sparkline.Type == SparkLineType.Line)
                DrawSparkline(graphics, Sparkline);
            else if (this.Sparkline.Type == SparkLineType.Column)
                DrawSparkColumn(graphics, Sparkline);
            else
                DrawSparkWinLossColumn(graphics, Sparkline);

            graphics.SmoothingMode = smoothingMode;
            graphics.SetClip(clipBounds);
        }

        /// <summary>
        /// Occurs when the key is pressed while the cell has focus.
        /// </summary>
        /// <param name="dataColumn">The DataColumnBase of the cell.</param>
        /// <param name="rowColumnIndex">The row and column index of the cell.</param>
        /// <param name="e">The <see cref="T:System.Windows.Forms.KeyEventArgs"/> that contains the event data.</param>
        protected override void OnKeyDown(DataColumnBase dataColumn, RowColumnIndex rowColumnIndex, KeyEventArgs e)
        {
            var selectionController = this.DataGrid.SelectionController as CustomSelectionController;
            switch (e.KeyCode)
            {
                case Keys.Space:
                case Keys.Down:
                case Keys.Up:
                case Keys.Left:
                case Keys.Right:
                case Keys.Enter:
                case Keys.PageDown:
                case Keys.PageUp:
                case Keys.Tab:
                case Keys.Home:
                case Keys.End:
                    selectionController.HandleKeyOperations(e);
                    break;
            }

            base.OnKeyDown(dataColumn, rowColumnIndex, e);
        }

        /// <summary>
        /// Get interior BrushInfo points.
        /// </summary>
        /// <param name="curValue">The current value of the cell.</param>
        /// <param name="sparkline">The sparkline</param>
        /// <param name="isNegative">The value indicating whether the source value is negative or not.</param>
        /// <returns>returns the BrushInfo interior</returns>
        private BrushInfo GetInteriorColumn(double curValue, Syncfusion.Windows.Forms.Chart.SparkLine sparkline, bool isNegative)
        {
            BrushInfo interior = sparkline.ColumnStyle.ColumnColor;

            if (Convert.ToDouble(curValue) == sparkline.StartPoint && sparkline.Markers.ShowStartPoint)
                interior = sparkline.Markers.StartPointColor;
            if (Convert.ToDouble(curValue) == sparkline.EndPoint && sparkline.Markers.ShowEndPoint)
                interior = sparkline.Markers.EndPointColor;

            int count = sparkline.GetNegativePoint().GetUpperBound(0);

            if (isNegative)
            {
                for (int index = 0; index <= count; index++)
                {
                    if (Convert.ToDouble(curValue) == (double)sparkline.GetNegativePoint().GetValue(index) && sparkline.Markers.ShowNegativePoint)
                        interior = sparkline.Markers.NegativePointColor;
                }
            }

            if (Convert.ToDouble(curValue) == sparkline.HighPoint && sparkline.Markers.ShowHighPoint)
                interior = sparkline.Markers.HighPointColor;
            if (Convert.ToDouble(curValue) == sparkline.LowPoint && sparkline.Markers.ShowLowPoint)
                interior = sparkline.Markers.LowPointColor;
            return interior;
        }
       
        /// <summary>
        /// Get interior BrushInfo points.
        /// </summary>
        /// <param name="curValue">The current value oof the cell.</param>
        /// <param name="sparkline">The sparkline</param>
        /// <returns>returns the BrushInfo interior</returns>
        private BrushInfo GetInteriorWinLoss(double curValue, ISparkLine sparkline)
        {
            BrushInfo interior = sparkline.ColumnStyle.ColumnColor;
            sparkline.Markers.ShowNegativePoint = true;
            int count = sparkline.GetNegativePoint().GetUpperBound(0);

            for (int index = 0; index <= count; index++)
            {
                if (Convert.ToDouble(curValue) == (double)sparkline.GetNegativePoint().GetValue(index) && sparkline.Markers.ShowNegativePoint)
                    interior = sparkline.Markers.NegativePointColor;
            }
            if (Convert.ToDouble(curValue) == sparkline.StartPoint && sparkline.Markers.ShowStartPoint)
                interior = sparkline.Markers.StartPointColor;
            if (Convert.ToDouble(curValue) == sparkline.EndPoint && sparkline.Markers.ShowEndPoint)
                interior = sparkline.Markers.EndPointColor;

            if (Convert.ToDouble(curValue) == sparkline.HighPoint && sparkline.Markers.ShowHighPoint)
                interior = sparkline.Markers.HighPointColor;
            if (Convert.ToDouble(curValue) == sparkline.LowPoint && sparkline.Markers.ShowLowPoint)
                interior = sparkline.Markers.LowPointColor;
            return interior;
        }

        /// <summary>
        /// Get data to the sparkline column.
        /// </summary>
        /// <param name="mappingName">The mapping name of the column.</param>
        /// <param name="record">Data of the SparkLine.</param>
        /// <returns>returns collection.</returns>
        private double[] GetSparklineSource(string mappingName, object record)
        {
            var salesCollection = record as System.Data.DataRowView;
            var item = salesCollection.Row.ItemArray[5];
            return item as double[];
        }
    }
}
