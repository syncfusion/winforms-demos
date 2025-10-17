#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Syncfusion.WinForms.DataGrid.Styles;
using Syncfusion.WinForms.DataGrid.Helpers;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.Core;
using Syncfusion.WinForms.Core.Enums;

namespace RealTimeUpdates
{
    public partial class Form1 : Form
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();
            collection = new StocksDataCollection();
            sfDataGrid.DataSource = collection.Stocks;
            sfDataGrid.DrawCell += SfDataGrid_DrawCell;
        }

        #endregion

        #region Event_Method

        /// <summary>
        /// Sets track bar changed to timer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrequencySlider_Scroll(object sender, EventArgs e)
        {
            double ms = frequencySlider.Value * 2321;
            if (frequencySlider.Value == 100 || frequencySlider.Value == 1000)
                frequencyChanging.Text = "" + frequencySlider.Value + " ms";
            else
                frequencyChanging.Text = "" + frequencySlider.Value + "." + ms + " ms";

            collection.StartTimer(frequencySlider.Value);
            startTimerBtn.Text = "Stop Timer";
        }

        /// <summary>
        /// Used to Start and Stop the timer in button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClick_Click(object sender, EventArgs e)
        {
            if (startTimerBtn.Text == "Start Timer")
            {
                collection.StartTimer(frequencySlider.Value);
                startTimerBtn.Text = "Stop Timer";
            }
            else
            {
                collection.StopTimer();
                startTimerBtn.Text = "Start Timer";
            }
        }

        /// <summary>
        /// Used to customize the cell
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SfDataGrid_DrawCell(object sender, DrawCellEventArgs e)
        {
            if (this.sfDataGrid.CurrentCell != null && this.sfDataGrid.CurrentCell.IsEditing)
                return;

            if (e.Column.MappingName == "Change" && e.DataRow.RowType == RowType.DefaultRow)
            {
                var graphics = e.Graphics;
                var rect = e.Bounds;
                Rectangle rect1 = new Rectangle(rect.X + 20, rect.Y + 6, rect.Width / 6, rect.Height / 2);
                StringFormat format = new StringFormat();

                e.Style.HorizontalAlignment = HorizontalAlignment.Center;
                var drawingObj = new DrawingHelper();
                var value = drawingObj.GetType().GetMethod("ConvertToStringAlignment", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static, Type.DefaultBinder, new Type[] { typeof(HorizontalAlignment) }, new ParameterModifier[] { }).Invoke(drawingObj, new object[] { e.Style.HorizontalAlignment });
                format.Alignment = (StringAlignment)value;

                var value1 = drawingObj.GetType().GetMethod("ConvertToStringAlignment", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static, Type.DefaultBinder, new Type[] { typeof(VerticalAlignment) }, new ParameterModifier[] { }).Invoke(drawingObj, new object[] { e.Style.VerticalAlignment });
                format.LineAlignment = (StringAlignment)value1;

                if ((e.DataRow.RowData as StockData).Change > 0)
                {
                    ShapesPainter.DrawTriangle(graphics, rect1, TriangleDirection.Up, Brushes.Green, new Pen(Color.Green), true);
                    graphics.DrawString(e.DisplayText, e.Style.Font.GetFont(), new SolidBrush(Color.Green), rect.X + 92, rect.Y + 13, format);
                }
                else
                {
                    ShapesPainter.DrawTriangle(graphics, rect1, TriangleDirection.Down, Brushes.Red, new Pen(Color.Red), true);
                    graphics.DrawString(e.DisplayText, e.Style.Font.GetFont(), new SolidBrush(Color.Red), rect.X + 90, rect.Y + 13, format);
                }
                Pen borderPen = new Pen(Brushes.LightGray);
                graphics.DrawLine(borderPen, rect.Right - 1, rect.Top, rect.Right - 1, rect.Bottom);
                graphics.DrawLine(borderPen, rect.Left, rect.Bottom - 1, rect.Right, rect.Bottom - 1);
                e.Handled = true;
            }
        }
        #endregion
    }
}

