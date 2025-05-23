#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Gauge;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaugeDemo
{
    public class CustomGaugeRenderer : IRadialGaugeRenderer
    {
        #region Variables
        /// </summary>
        /// Gets the RadialGauge
        /// </summary>
        internal RadialGauge m_RadialGauge;
        private Point m_Center;

        /// <summary>
        /// Used to set bounds for the Font
        /// </summary>
        internal Single fontboundY1, fontboundY2;
        #endregion

        #region Properties
        /// <summary>
        ///  Gets the RadialGauge
        /// </summary>
        internal RadialGauge RadialGauge
        {
            get
            {
                return m_RadialGauge;
            }
        }
        #endregion

        #region Constructor
        Form1 form;
        /// <summary>
        /// Constructor of the Renderer class
        /// </summary>
        /// <param name="radialGauge">Radial Gauge</param>
        public CustomGaugeRenderer(RadialGauge radialGauge)
        {
            m_RadialGauge = radialGauge;
            m_Center = new Point(m_RadialGauge.Width / 2, m_RadialGauge.Width / 2);
        }

        /// <summary>
        /// Retrive ArcThickness of the RadialGauge
        /// </summary>
        /// <returns>returns Thickness of the Arc based on DPI</returns>
        internal float GetArcThickness()
        {
            return DpiAware.LogicalToDeviceUnits(this.RadialGauge.ArcThickness);
        }

        /// <summary>
        /// To get thickness of the outer frame
        /// </summary>
        /// <returns>returns the outer frame thickness based on DPI</returns>
        internal int GetFrameThickness()
        {
            return (int)Math.Ceiling(DpiAware.LogicalToDeviceUnits(this.RadialGauge.FrameThickness));
        }

        internal int GaugeRadius
        {
            get
            {
                int rectRimWidth = (int)Math.Ceiling(this.RadialGauge.Width * 0.865);

                if (RadialGauge.LabelPlacement == LabelPlacement.Inside && RadialGauge.TickPlacement == TickPlacement.Inside)
                {
                    return GetWidth() / 2 - (int)(GetArcThickness() / 2);
                }
                return 0;
            }
        }

        public Rectangle InnerRect { get; private set; }
        public Rectangle BottomRect { get; private set; }

        private int GetWidth()
        {
            return (int)Math.Ceiling(this.RadialGauge.Width * 0.75);
        }
        #endregion

        #region IRadialGaugeRenderer Members
        /// <summary>
        /// Updates the Render
        /// </summary>
        /// <param name="PaintEventArgs">PaintEventArgs which contains event data</param>
        public void UpdateRenderer(PaintEventArgs e)
        {
            this.AdjustFontBounds(e.Graphics, this.RadialGauge.Font);

            //Used to draw the OuterArc
            this.DrawOuterArc(e.Graphics, RadialGauge.StartAngle, RadialGauge.SweepAngle, m_Center, this.GaugeRadius);

            // Draw Label in center of Gauge
            this.DrawGaugeLabel(e.Graphics, m_Center, GaugeRadius);
        }

        /// <summary>
        /// Used to calculate the text bounds 
        /// </summary>
        /// <param name="Graphics">Graphics</param>
        /// <param name="Font">Font </param>
        public void AdjustFontBounds(Graphics Graphics, Font Font)
        {
            //find upper and lower bounds for numeric characters
            Int32 c1;
            Int32 c2;
            Boolean boundFound;
            SolidBrush backBrush = new SolidBrush(Color.White);
            SolidBrush foreBrush = new SolidBrush(Color.Black);
            SizeF boundingBox;

            boundingBox = Graphics.MeasureString("0123456789", Font, -1, StringFormat.GenericTypographic);
            using (Bitmap b = new Bitmap((Int32)(boundingBox.Width), (Int32)(boundingBox.Height)))
            {
                Graphics = Graphics.FromImage(b);
                Graphics.FillRectangle(backBrush, 0.0F, 0.0F, boundingBox.Width, boundingBox.Height);
                Graphics.DrawString("0123456789", Font, foreBrush, 0.0F, 0.0F, StringFormat.GenericTypographic);

                fontboundY1 = 0;
                fontboundY2 = 0;
                c1 = 0;
                boundFound = false;
                while ((c1 < b.Height) && (!boundFound))
                {
                    c2 = 0;
                    while ((c2 < b.Width) && (!boundFound))
                    {
                        if (b.GetPixel(c2, c1) != backBrush.Color)
                        {
                            fontboundY1 = c1;
                            boundFound = true;
                        }
                        c2++;
                    }
                    c1++;
                }

                c1 = b.Height - 1;
                boundFound = false;
                while ((0 < c1) && (!boundFound))
                {
                    c2 = 0;
                    while ((c2 < b.Width) && (!boundFound))
                    {
                        if (b.GetPixel(c2, c1) != backBrush.Color)
                        {
                            fontboundY2 = c1;
                            boundFound = true;
                        }
                        c2++;
                    }
                    c1--;
                }
            }
        }

        /// <summary>
        /// Method used to draw outer arc.
        /// </summary>
        /// <param name="Graphics">Graphics</param>
        /// <param name="GaugeArcStart">Start angle of the Outer arc</param>
        /// <param name="GaugeArcEnd">Sweep angle of the Outer Arc</param>
        /// <param name="Center">Center point for Gauge</param>
        /// <param name="Gaugeradius">Radius of the Outer Arc</param>
        public void DrawOuterArc(Graphics Graphics, Int32 GaugeArcStart, Int32 GaugeArcEnd, Point Center, int GaugeRadius)
        {
            Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            GraphicsPath pth = new GraphicsPath();
            Color c = this.RadialGauge.Parent != null ? this.RadialGauge.Parent.BackColor : Color.Empty;
            Rectangle r = new Rectangle(0, 0, this.RadialGauge.Width, this.RadialGauge.Height);
            System.Drawing.Drawing2D.GraphicsPath basePath = new System.Drawing.Drawing2D.GraphicsPath();

            int x = this.RadialGauge.Width;
            int y = this.RadialGauge.Height;

            int rectWidth = (int)Math.Ceiling(this.RadialGauge.Width * 0.94); // 94 % of the actual radial gauge width            
            int rectRimWidth = (int)(rectWidth - (this.GetFrameThickness() * 2)); /* (int)Math.Ceiling(this.Width * 0.865); */ // 86.5 % of the actual radial gauge width

            //Define rectangles inside which we will draw circles.
            int xOffset = (this.RadialGauge.Width - rectWidth) / 2;
            int yOffset = (this.RadialGauge.Width - rectRimWidth) / 2;
            Rectangle rect; Rectangle rectrim;

            rect = new Rectangle(xOffset, xOffset, rectWidth, rectWidth);
            rectrim = new Rectangle(yOffset, yOffset, rectRimWidth, rectRimWidth);

            if (this.RadialGauge.FrameType == FrameType.HalfCircle)
            {
                PointF Intersection1 = PointF.Empty; PointF Intersection2 = PointF.Empty;
                x = this.RadialGauge.Width;
                y = this.RadialGauge.Width;

                float outerRadius = rectWidth / 2;
                float innerRadius = outerRadius - this.GetFrameThickness();

                rect = Rectangle.Round(new RectangleF(Center.X - outerRadius, Center.Y - outerRadius, outerRadius * 2, outerRadius * 2));
                rectrim = Rectangle.Round(new RectangleF(Center.X - innerRadius, Center.Y - innerRadius, innerRadius * 2, innerRadius * 2));

                PointF Point1 = new PointF(Center.X - outerRadius, this.RadialGauge.Height - this.GetFrameThickness());
                PointF Point2 = new PointF(Center.X - outerRadius + rectWidth + this.GetFrameThickness(), this.RadialGauge.Height - this.GetFrameThickness());

                PointF[] intersectionsPoints = this.FindLineCircleIntersections(
                    Center.X, Center.Y, outerRadius, Point1, Point2);
                Intersection1 = intersectionsPoints[0];
                Intersection2 = intersectionsPoints[1];



                //OUTER
                LinearGradientBrush gb = new LinearGradientBrush(rect, this.RadialGauge.OuterFrameGradientStartColor, this.RadialGauge.OuterFrameGradientEndColor, LinearGradientMode.Vertical);

                pth.AddEllipse(rect);

                PathGradientBrush pgb = new PathGradientBrush(pth);

                pgb.CenterColor = this.RadialGauge.BackgroundGradientStartColor;

                pgb.SurroundColors = new Color[] { this.RadialGauge.BackgroundGradientEndColor };

                pgb.FocusScales = new PointF(0.1f, 0.1f);

                Blend bevelBlend = new Blend();
                bevelBlend.Positions = new float[] { 0.0f, .2f, .4f, .6f, .8f, 1.0f };
                bevelBlend.Factors = new float[] { .2f, .4f, .6f, .6f, 1f, 1f };
                Rectangle lgbRect = rect;
                lgbRect.Inflate(1, 1);
                LinearGradientBrush innerBevelBrush = new LinearGradientBrush(lgbRect,
                                                    this.RadialGauge.InnerFrameGradientStartColor,
                                                    this.RadialGauge.InnerFrameGradientEndColor,
                                                    LinearGradientMode.BackwardDiagonal);

                innerBevelBrush.Blend = bevelBlend;

                if (this.RadialGauge.ShowBackgroundFrame)
                {
                    Graphics.FillEllipse(gb, rect);
                    //Inner background
                    Graphics.FillEllipse(innerBevelBrush, rectrim);
                    rectrim.Inflate(-3, -3);
                    //Center circle
                    this.InnerRect = rectrim;
                    Graphics.FillEllipse(pgb, rectrim);
                    {
                        this.BottomRect = new Rectangle(rectrim.X + (xOffset / 2), this.RadialGauge.Height - xOffset, rect.Width - (2 * ((rectrim.X + (xOffset / 2)) - rect.X)), xOffset);
                    }

                    
                    //Bottom rect
                    Graphics.FillRectangle(gb, this.BottomRect);
                }
            }

            GraphicsPath gp = new GraphicsPath();

            if (GaugeRadius > 0)
            {
                float thickness = GetArcThickness();
                Graphics.DrawArc(new Pen(thickness == 0 ? Color.Transparent : this.RadialGauge.GaugeArcColor, thickness), new Rectangle(Center.X - GaugeRadius, Center.Y - GaugeRadius,
                   2 * GaugeRadius, 2 * GaugeRadius), GaugeArcStart, GaugeArcEnd);
                float rangeSweepAngle = this.RadialGauge.Value * this.RadialGauge.SweepAngle / (this.RadialGauge.MaximumValue - this.RadialGauge.MinimumValue);
                Graphics.DrawArc(new Pen(System.Drawing.ColorTranslator.FromHtml("#0CBDF4"), thickness), new Rectangle(Center.X - GaugeRadius, Center.Y - GaugeRadius,
                   2 * GaugeRadius, 2 * GaugeRadius), RadialGauge.StartAngle, rangeSweepAngle);

                SolidBrush br = new SolidBrush(this.RadialGauge.GaugeLableColor);
                SizeF s;
                Point p;

                Font labelFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Color labelForeColor = Color.Black;

                br = new SolidBrush(labelForeColor);
                s = Graphics.MeasureString("0M", labelFont);
                p = new Point((int)((Center.X - GaugeRadius) - (s.Width / 2)), Center.Y + GaugeRadius / 6);
                Graphics.DrawString("0M", labelFont, br, p);
                s = Graphics.MeasureString("120M", labelFont);
                p = new Point((int)((Center.Y + GaugeRadius) - (s.Width / 2)), Center.Y + GaugeRadius / 6);
                Graphics.DrawString("120M", labelFont, br, p);
              
                br.Dispose();
            }
        }

        internal PointF[] FindLineCircleIntersections(float cx, float cy, float radius,
                    PointF point1, PointF point2)
        {
            float dx, dy, A, B, C, det, t;
            PointF intersection1, intersection2;
            dx = point2.X - point1.X;
            dy = point2.Y - point1.Y;

            A = dx * dx + dy * dy;
            B = 2 * (dx * (point1.X - cx) + dy * (point1.Y - cy));
            C = (point1.X - cx) * (point1.X - cx) + (point1.Y - cy) * (point1.Y - cy) - radius * radius;

            det = B * B - 4 * A * C;

            t = (float)((-B + Math.Sqrt(det)) / (2 * A));
            intersection1 = new PointF(point1.X + t * dx, point1.Y + t * dy);
            t = (float)((-B - Math.Sqrt(det)) / (2 * A));
            intersection2 = new PointF(point1.X + t * dx, point1.Y + t * dy);

            return new PointF[] { intersection1, intersection2 };
        }

        /// <summary>
        /// Method used to draw customization needle.
        /// </summary>
        /// <param name="Graphics">Graphics</param>
        /// <param name="Needle">Needles</param>
        /// <param name="GaugeArcStart">Start angle of the Outer arc</param>
        /// <param name="GaugeArcEnd">Sweep angle of the Outer Arc</param>
        /// <param name="NeedleRadius">Length of the Needle</param>
        /// <param name="NeedleWidth">Width of the Needle</param>
        /// <param name="Center">Center point of the Gauge</param>
        public void DrawMultipleNeedle(Graphics Graphics, Needle Needle, Int32 GaugeArcStart, Int32 GaugeArcEnd, Int32 NeedleRadius, int NeedleWidth, Point Center)
        {
            
        }

        /// <summary>
        /// Method used to draw needle
        /// </summary>
        /// <param name="Graphics">Graphics</param>
        /// <param name="GaugeArcStart">Start angle of the Outer arc</param>
        /// <param name="GaugeArcEnd">Sweep angle of the Outer Arc</param>
        /// <param name="NeedleRadius">Length of the Needle</param>
        /// <param name="NeedleWidth">Width of the Needle</param>
        /// <param name="Center">Center point of the Gauge</param>
        public void DrawNeedle(Graphics Graphics, Int32 GaugeArcStart, Int32 GaugeArcEnd, Int32 NeedleRadius, Int32 NeedleWidth, Point Center)
        {
            
        }

        /// <summary>
        /// Used to draw the label.
        /// </summary>
        /// <param name="Graphics">Graphics</param>
        /// <param name="Center">Center point of the Gauge</param>
        /// <param name="GaugeRadius">Radius of the OuterArc</param>
        public void DrawGaugeLabel(Graphics Graphics, Point Center, int GaugeRadius)
        {
            SolidBrush br = new SolidBrush(this.RadialGauge.GaugeLableColor);
            SizeF s;
            br = new SolidBrush(this.RadialGauge.GaugeLableColor);
            s = Graphics.MeasureString(this.RadialGauge.GaugeLabel, this.RadialGauge.GaugeLableFont);
            Point p;
            p = new Point((int)((Center.X) - (s.Width / 2)), Center.Y + GaugeRadius / 6);
            Graphics.DrawString(this.RadialGauge.GaugeLabel, this.RadialGauge.GaugeLableFont, br, p);

            if (this.RadialGauge.ShowGaugeValue)
            {
                using (Font f = new Font(this.RadialGauge.GaugeValueFont.Name, this.RadialGauge.GaugeValueFont.Size + 4))
                {
                    string additionalstring = "$ " + this.RadialGauge.Value.ToString();
                    br = new SolidBrush(this.RadialGauge.GaugeValueColor);
                    s = Graphics.MeasureString(additionalstring, this.RadialGauge.GaugeValueFont);
                    p = new Point((int)((Center.X) - (s.Width / 2)), (int)(Center.Y - GaugeRadius / 3));

                    Graphics.DrawString(additionalstring, f, br, p);
                }
            }
            br.Dispose();
        }

        /// <summary>
        /// Used to draw the ranges
        /// </summary>
        /// <param name="Graphics">Graphics</param>
        /// <param name="GraphicsPath">Graphics path</param>
        /// <param name="GaugeArcStart">Start angle of the Outer arc</param>
        /// <param name="GaugeArcEnd">Sweep angle of the Outer Arc</param>
        /// <param name="GaugeArcRadius">Radius of the arc</param>
        /// <param name="Center">Center of the Gauge</param>
        public void DrawRanges(Graphics Graphics, GraphicsPath GraphicsPath, Int32 GaugeArcStart, Int32 GaugeArcEnd, Int32 GaugeArcRadius, Point Center)
        {
            

        }

        /// <summary>
        /// Used to draw the tick marks
        /// </summary>
        /// <param name="Graphics">Graphics</param>
        /// <param name="GraphicsPath">Graphics path</param>
        /// <param name="GaugeArcRadius">Start angle of the Outer arc</param>
        /// <param name="GaugeArcEnd">Sweep angle of the Outer Arc</param>
        /// <param name="MajorTickMarkWidth">Width of the TickMark</param>
        /// <param name="Center">Center of the Gauge</param>
        /// <param name="ScaleNumbersRadius">Radius of the scale value arc</param>
        public void DrawTickMarks(Graphics Graphics, GraphicsPath GraphicsPath, Int32 GaugeArcRadius, Int32 GaugeArcStart, Int32 GaugeArcEnd, Int32 MajorTickMarkWidth, Point Center, int ScaleNumbersRadius)
        {
            

        }

        /// <summary>
        /// Draws the GaugeArc with specified radius and color values.
        /// </summary>
        /// <param name="Graphics">Graphics to draw the control.</param>
        /// <param name="Center"> Center of the radial gauge.</param>
        /// <param name="gaugeRadius"> Radius used to draw the GaugeArc.</param>
        /// <param name="StartAngle"> Angle in degrees measured clockwise from the x-axis to the starting point of the arc.</param>
        /// <param name="SweepAngle"> Angle in degrees measured clockwise from the startAngle parameter to the end point of the arc.</param>
        /// <param name="frameThickness">Thickness of the GaugeArc.</param>
        /// <param name="ArcColor">Color used to fill the GaugeArc.</param>
        /// <param name="fillColor">Color used to fill the GaugeArc based on the current value of RadialGauge.</param>
        public void DrawCircle(Graphics Graphics, Point Center, int gaugeRadius, int StartAngle, int SweepAngle, float frameThickness, Color arcColor, Color fillColor)
        {
           
        }


        #endregion
    }
}
