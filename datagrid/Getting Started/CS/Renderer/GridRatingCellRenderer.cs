#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Interactivity;
using Syncfusion.WinForms.DataGrid.Renderers;
using Syncfusion.WinForms.DataGrid.Styles;
using Syncfusion.WinForms.GridCommon.ScrollAxis;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GettingStarted
{
    /// <summary>
    /// Represents the class that used for drawing the rating cell.
    /// </summary>
    public class GridRatingCellRenderer : GridCellRendererBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GridRatingCellRenderer"/> class.
        /// </summary>
        /// <param name="ratingControl">The rating control.</param>
        /// <param name="dataGrid">The DataGrid.</param>
        public GridRatingCellRenderer(GridRatingControl ratingControl, SfDataGrid dataGrid)
        {
            IsEditable = false;
            RatingControl = ratingControl;
            DataGrid = dataGrid;
        }

        /// <summary>
        /// Gets or Sets the rating control functionalities.
        /// </summary>
        protected GridRatingControl RatingControl { get; set; }

        /// <summary>
        /// Gets or Sets to specifies the datagrid.
        /// </summary>
        protected SfDataGrid DataGrid { get; set; }

        /// <summary>
        /// Overridden to draw the rating of the cell.
        /// </summary>
        /// <param name="graphics">The <see cref="T:System.Drawing.Graphics"/> that used to draw the rating.</param>
        /// <param name="cellRect">The cell rectangle.</param>
        /// <param name="cellValue">The cell value.</param>
        /// <param name="style">The CellStyleInfo of the cell.</param>
        /// <param name="column">The DataColumnBase of the cell.</param>
        /// <param name="rowColumnIndex">The row and column index of the cell.</param>
        protected override void OnRender(Graphics graphics, Rectangle cellRect, string cellValue, CellStyleInfo style, DataColumnBase column, RowColumnIndex rowColumnIndex)
        {
            using (SolidBrush brush = new SolidBrush(style.BackColor))
                graphics.FillRectangle(brush, cellRect);

            var RatingColumn = column.GridColumn as GridRatingColumn;
            RatingControl.Orientation = Orientationmode.Horizontal;
            RatingControl.Location = cellRect.Location;
            var Width = RatingControl.Width;
            RatingControl.Orientation = Orientationmode.Horizontal;
            RatingControl.ItemsCount = RatingColumn.ItemCount;
            RatingControl.Size = cellRect.Size;
            RatingControl.Shape = RatingColumn.Shape;
            int value = 0;
            if (int.TryParse(cellValue, out value))
                RatingControl.Value = value;
            RatingControl.ItemSelectionColor = RatingColumn.ItemSelectionColor;
            RatingControl.ItemBackColor = RatingColumn.ItemBackColor;

            var smoothingMode = graphics.SmoothingMode;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            int starHeight, starWidth;
            Rectangle drawArea;
            var clipBounds = graphics.VisibleClipBounds;
            graphics.SetClip(cellRect);
            Rectangle[] m_Itemrectangle = new Rectangle[RatingControl.ItemsCount];

            var padding = 10;
            cellRect.X += padding;
            cellRect.Width -= 2 * padding;
            Width = cellRect.Width;

            starWidth = 16;
            starHeight = 16;

            var startingPosition = (Width - ((RatingControl.ItemsCount * starWidth) + ((RatingControl.ItemsCount - 1) * RatingControl.Spacing))) / 2;
            drawArea = new Rectangle(cellRect.X + startingPosition, cellRect.Y + ((cellRect.Height / 2) - (starHeight / 2)), starWidth, starHeight);

            RatingControl.Location = new Point(drawArea.X, drawArea.Y);

            for (int i = 0; i < RatingControl.ItemsCount; ++i)
            {
                m_Itemrectangle[i].X = drawArea.X - RatingControl.Spacing / 2;
                m_Itemrectangle[i].Y = drawArea.Y;
                m_Itemrectangle[i].Width = drawArea.Width + RatingControl.Spacing / 2;
                m_Itemrectangle[i].Height = drawArea.Height;

                if (RatingControl.Shape == Shapes.Circle)
                    RatingControl.DrawCircle(graphics, drawArea, i);
                else if (RatingControl.Shape == Shapes.Heart)
                    RatingControl.DrawHeart(graphics, drawArea, i);
                else if (RatingControl.Shape == Shapes.CustomImages)
                    RatingControl.DrawCustomShapes(graphics, drawArea, i);
                else
                    RatingControl.DrawShape(graphics, drawArea, i);

                drawArea.X += drawArea.Width + RatingControl.Spacing;
            }

            graphics.SetClip(clipBounds);
            graphics.SmoothingMode = smoothingMode;
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
    }
}
