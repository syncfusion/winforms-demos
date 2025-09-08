#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System.ComponentModel;
using System.Drawing;
using Syncfusion.WinForms.Core.Utils;
using System.Drawing.Drawing2D;
using DpiAware = Syncfusion.WinForms.Core.Utils.DpiAware;

namespace GettingStarted
{
    /// <summary>
    /// Rating Control Class in which all the functionalities of the rating control has been defined.
    /// </summary>
    [ToolboxItem(false)]
    public class GridRatingControl : RatingControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GridRatingControl"/> class.
        /// </summary>
        public GridRatingControl()
        {
        }

        /// <summary>
        /// Draws the Circle shape
        /// </summary>
        /// <param name="g">The <see cref="T:System.Drawing.Graphics"/> that used to draw the rating.</param>
        /// <param name="rect">The rectangle of the cell.</param>
        /// <param name="starAreaIndex">Rating item index count.</param>
        public new void DrawCircle(Graphics graphics, Rectangle rectangle, int starAreaIndex)
        {
            base.DrawCircle(graphics, rectangle, starAreaIndex);
        }

        /// <summary>
        /// Draws the Circle shape
        /// </summary>
        /// <param name="g">The <see cref="T:System.Drawing.Graphics"/> that used to draw the rating.</param>
        /// <param name="rect">The rectangle of the cell.</param>
        /// <param name="starAreaIndex">Rating item index count.</param>
        public new void DrawCustomShapes(Graphics graphics, Rectangle rectangle, int starAreaIndex)
        {
            base.DrawCustomShapes(graphics, rectangle, starAreaIndex);
        }

        /// <summary>
        /// Draws the Heart shape
        /// </summary>
        /// <param name="g">The <see cref="T:System.Drawing.Graphics"/> that used to draw the rating.</param>
        /// <param name="rect">The rectangle of the cell.</param>
        /// <param name="starAreaIndex">Rating item index count.</param>
        public new void DrawHeart(Graphics g, Rectangle rect, int starAreaIndex)
        {
            Brush fillBrush = new SolidBrush(ItemBackColor);
            Pen outlinePen = new Pen(ItemBorderColor, ItemBorderWeight);
            Pen mousedownpen = new Pen(ItemBorderColor, ItemBorderWeight);
            fillBrush = new SolidBrush(ItemBackColor);
            Size defaultItemSize = new Size(22, 22);

            GridRatingColumn RatingColumn = new GridRatingColumn();
            GraphicsPath gpfull = new GraphicsPath();
            var controlY = this.Location.Y;
            gpfull.AddLine(rect.X + rect.Width / 2, (controlY) + rect.Height, rect.X, (controlY) + (rect.Height / 2) - 3);
            gpfull.AddArc(rect.X, rect.Y, rect.Width / 2, (rect.Height / 2) - 3, 180, 180);
            gpfull.AddArc(rect.X + (rect.Width / 2), rect.Y, rect.Width / 2, (rect.Height / 2) - 3, 180, 180);
            gpfull.AddLine(rect.X + rect.Width, (controlY) + (rect.Height / 2) - 3, rect.X + rect.Width / 2, (controlY) + rect.Height);
            GraphicsPath gphalf = new GraphicsPath();
            gphalf.AddArc(rect.X, rect.Y, rect.Width / 2, (rect.Height / 2) - 3, 180, 180);
            gphalf.AddLines(new PointF[] { new PointF(rect.X + rect.Width / 2, rect.Height / 2), new PointF(rect.X + rect.Width / 2, rect.Height), new PointF(rect.X, rect.Height / 2) });
            gphalf.AddArc(rect.X, rect.Y, rect.Width / 2, (rect.Height / 2) - 3, 180, 180);
            gphalf.AddArc(rect.X, rect.Y, rect.Width / 2, (rect.Height / 2) - 3, 180, 180);
            g.FillPath(fillBrush, gpfull);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawPath(outlinePen, gpfull);
            fillBrush.Dispose();
            outlinePen.Dispose();
            mousedownpen.Dispose();
        }

        /// <summary>
        /// Draws the shape
        /// </summary>
        /// <param name="g">The <see cref="T:System.Drawing.Graphics"/> that used to draw the rating.</param>
        /// <param name="rect">The rectangle of the cell.</param>
        /// <param name="starAreaIndex">Rating item index count.</param>
        public new void DrawShape(Graphics g, Rectangle rect, int starAreaIndex)
        {
            Brush fillBrush = new SolidBrush(ItemBackColor);
            Pen outlinePen = new Pen(ItemBorderColor, ItemBorderWeight);
            Pen mousedownpen = new Pen(ItemBorderColor, ItemBorderWeight);
            outlinePen = new Pen(ItemBorderColor, ItemBorderWeight);

            if (Value > starAreaIndex)
                fillBrush = new SolidBrush(ItemSelectionColor);
            else
                fillBrush = new SolidBrush(ItemBackColor);
            PointF[] fullselection = GetFullPoints(rect);
            PointF[] p = fullselection;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.FillPolygon(fillBrush, p);
            g.DrawPolygon(outlinePen, fullselection);

            fillBrush.Dispose();
            outlinePen.Dispose();
            mousedownpen.Dispose();
        }

        /// <summary>
        ///  Gets the shapes points for the rating. 
        /// </summary>
        /// <param name="rect">The rectangle.</param>
        /// <returns>Returns points for rating.</returns>
        private PointF[] GetFullPoints(Rectangle rect)
        {
            if (Orientation == Orientationmode.Vertical)
                return null;

            PointF[] p1;
            Size defaultItemSize = new Size(22, 22);
            var controlY = this.Location.Y;

            if (ItemSize == defaultItemSize)
            {
                if (Shape == Shapes.Star)
                {
                    p1 = new PointF[] {
                    new PointF( rect.X,(controlY) + (rect.Height)/2-DpiAware.LogicalToDeviceUnits(1)),
                    new PointF(rect.X+(rect.Width/2)-DpiAware.LogicalToDeviceUnits(3),(controlY) +(rect.Height/2)-DpiAware.LogicalToDeviceUnits(1)),
                    new PointF(rect.X+(rect.Width/2),rect.Y),
                    new PointF((rect.X+(rect.Width/2)+DpiAware.LogicalToDeviceUnits(3)),(controlY) +(rect.Height/2)-DpiAware.LogicalToDeviceUnits(1)),
                    new PointF(rect.X+rect.Width,(controlY) +rect.Height/2-DpiAware.LogicalToDeviceUnits(1)),
                    new PointF(rect.X+(rect.Width/2)+DpiAware.LogicalToDeviceUnits(4),(controlY) +(rect.Height/2)+DpiAware.LogicalToDeviceUnits(3)),
                    new PointF(rect.X+rect.Width-DpiAware.LogicalToDeviceUnits(3),(controlY) + rect.Height),
                    new PointF(rect.X+rect.Width/2,(controlY) +(rect.Height/2)+DpiAware.LogicalToDeviceUnits(6)),
                    new PointF(rect.X+DpiAware.LogicalToDeviceUnits(3),(controlY) +rect.Height),
                    new PointF(rect.X+(rect.Width/2)-DpiAware.LogicalToDeviceUnits(4),(controlY) +(rect.Height/2)+DpiAware.LogicalToDeviceUnits(3)),
                    new PointF(rect.X,(controlY) +(rect.Height)/2-DpiAware.LogicalToDeviceUnits(1))
                };
                }
                else if (Shape == Shapes.Triangle)
                {
                    p1 = new PointF[] {
                    new PointF(rect.X,(controlY) +rect.Height),
                    new PointF(rect.X+(rect.Width/2),rect.Y),
                    new PointF(rect.X+(rect.Width),(controlY) +rect.Height),
                    new PointF(rect.X,(controlY) +rect.Height),
                };
                }
                else if (Shape == Shapes.Kite)
                {
                    p1 = new PointF[] {
                    new PointF(rect.X,(controlY) +(rect.Height)/2-DpiAware.LogicalToDeviceUnits(5)),
                    new PointF(rect.X+rect.Width/2,rect.Y),
                    new PointF(rect.X+rect.Width,(controlY) +(rect.Height)/2-DpiAware.LogicalToDeviceUnits(5)),
                    new PointF(rect.X+(rect.Width/2)-DpiAware.LogicalToDeviceUnits(6),(controlY) +rect.Height),
                    new PointF(rect.X+(rect.Width/2)+DpiAware.LogicalToDeviceUnits(6),(controlY) +rect.Height),
                    new PointF(rect.X,(controlY) +(rect.Height)/2-DpiAware.LogicalToDeviceUnits(5))
                };
                }
                else
                {
                    p1 = new PointF[] {
                    new PointF( rect.X,(controlY) + rect.Height/2),
                    new PointF(rect.X+(rect.Width/2),rect.Y),
                    new PointF(rect.X+rect.Width,(controlY) + rect.Height/2),
                    new PointF(rect.X+rect.Width/2,(controlY) + rect.Height),
                    new PointF(rect.X,(controlY) + rect.Height/2),
                };
                }
            }
            else
            {
                if (Shape == Shapes.Star)
                {
                    p1 = new PointF[] {
                    new PointF( rect.X,(controlY) + (rect.Height)/2-1),
                    new PointF(rect.X+(rect.Width/2)-3,(controlY) + (rect.Height/2)-1),
                    new PointF(rect.X+(rect.Width/2),rect.Y),
                    new PointF((rect.X+(rect.Width/2)+3),(controlY) + (rect.Height/2)-1),
                    new PointF(rect.X+rect.Width,(controlY) + rect.Height/2-1),
                    new PointF(rect.X+(rect.Width/2)+4,(controlY) + (rect.Height/2)+3),
                    new PointF(rect.X+rect.Width-3,(controlY) + rect.Height),
                    new PointF(rect.X+rect.Width/2,(controlY) + (rect.Height/2)+6),
                    new PointF(rect.X+3,(controlY) + rect.Height),
                    new PointF(rect.X+(rect.Width/2)-4,(controlY) + (rect.Height/2)+3),
                    new PointF(rect.X,(controlY) + (rect.Height)/2-1)
                };
                }
                else if (Shape == Shapes.Triangle)
                {
                    p1 = new PointF[] {
                    new PointF(rect.X,(controlY) + rect.Height),
                    new PointF(rect.X+(rect.Width/2),rect.Y),
                    new PointF(rect.X+(rect.Width),(controlY) + rect.Height),
                    new PointF(rect.X,(controlY) + rect.Height),
                };
                }
                else if (Shape == Shapes.Kite)
                {
                    p1 = new PointF[] {
                    new PointF(rect.X,(controlY) + (rect.Height)/2-5),
                    new PointF(rect.X+rect.Width/2,rect.Y),
                    new PointF(rect.X+rect.Width,(controlY) + (rect.Height)/2-5),
                    new PointF(rect.X+(rect.Width/2)-6,(controlY) + rect.Height),
                    new PointF(rect.X+(rect.Width/2)+6,(controlY) + rect.Height),
                    new PointF(rect.X,(controlY) + (rect.Height)/2-5)
                };
                }
                else
                {
                    p1 = new PointF[] {
                    new PointF( rect.X,(controlY) + rect.Height/2),
                    new PointF(rect.X+(rect.Width/2),rect.Y),
                    new PointF(rect.X+rect.Width,(controlY) + rect.Height/2),
                    new PointF(rect.X+rect.Width/2,(controlY) + rect.Height),
                    new PointF(rect.X,(controlY) + rect.Height/2),
                };
                }
            }
            return p1;
        }
    }
}