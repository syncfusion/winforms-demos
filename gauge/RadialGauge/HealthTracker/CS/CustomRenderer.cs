#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Syncfusion.Windows.Forms.Gauge;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace GaugeInterctionSample
{
    public partial class CustomRenderer : IRadialGaugeRenderer
    {
        /// </summary>
        /// Gets the RadialGauge
        /// </summary>
        private RadialGauge m_RadialGauge;

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
       
        /// <summary>
        /// Retrive ArcThickness of the RadialGauge
        /// </summary>
        /// <returns>returns Thickness of the Arc based on DPI</returns>
        internal float GetArcThickness()
        {
            return (int)Math.Ceiling(DpiAware.LogicalToDeviceUnits(this.RadialGauge.ArcThickness));
        }

        /// <summary>
        /// To get thickness of the outer frame
        /// </summary>
        /// <returns>returns the outer frame thickness based on DPI</returns>
        private int GetFrameThickness()
        {
           return (int)Math.Ceiling(DpiAware.LogicalToDeviceUnits(this.RadialGauge.FrameThickness));
        }
       
        /// <summary>
        /// Method to calculate the width to draw the Arc
        /// </summary>
        /// <returns>Returns the width</returns>
        private int GetWidth()
        {
            return (int)Math.Ceiling(this.RadialGauge.Width * 0.75);
        }

        private Point m_Center;
        private int GaugeRadius
        {
            get
            {
                return GetWidth() / 2 - (int)(GetArcThickness() / 2);
            }
        }
       
        private Single fontBoundY1;
        private Single fontBoundY2;

        public CustomRenderer(RadialGauge radialGauge1)
        {
            this.m_RadialGauge = radialGauge1;
            m_Center = new Point(this.RadialGauge.Width / 2, this.RadialGauge.Height / 2);
        }

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

                fontBoundY1 = 0;
                fontBoundY2 = 0;
                c1 = 0;
                boundFound = false;
                while ((c1 < b.Height) && (!boundFound))
                {
                    c2 = 0;
                    while ((c2 < b.Width) && (!boundFound))
                    {
                        if (b.GetPixel(c2, c1) != backBrush.Color)
                        {
                            fontBoundY1 = c1;
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
                            fontBoundY2 = c1;
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

            Graphics.DrawArc(new Pen(RadialGauge.GaugeArcColor, GetFrameThickness()), new Rectangle(Center.X - GaugeRadius, Center.Y - GaugeRadius,
                      2 * GaugeRadius, 2 * GaugeRadius), RadialGauge.StartAngle, RadialGauge.SweepAngle);

            float rangeSweepAngle = this.RadialGauge.Value * this.RadialGauge.SweepAngle / (this.RadialGauge.MaximumValue - this.RadialGauge.MinimumValue);
            Graphics.DrawArc(new Pen(RadialGauge.GaugeLableColor, GetFrameThickness()), new Rectangle(Center.X - GaugeRadius, Center.Y - GaugeRadius,
               2 * GaugeRadius, 2 * GaugeRadius), RadialGauge.StartAngle, rangeSweepAngle);
        }

        public void UpdateRenderer(PaintEventArgs e)
        {
            this.AdjustFontBounds(e.Graphics, this.RadialGauge.Font);

            //Used to draw the OuterArc
            this.DrawOuterArc(e.Graphics, RadialGauge.StartAngle, RadialGauge.SweepAngle, m_Center, this.GaugeRadius);

            // Draw Label in center of Gauge
            this.DrawGaugeLabel(e.Graphics, m_Center, GaugeRadius);
        }

        /// <summary>
        /// Used to draw the  label of the gauge
        /// </summary>
        /// <param name="e">paint event arguement</param>
        /// <param name="m_Center">Center point of the gauge</param>
        public void DrawGaugeLabel(Graphics e, Point Center, int GaugeRadius)
        {
            string additionalString = string.Empty;
            SolidBrush br = new SolidBrush(RadialGauge.GaugeLableColor);
            SizeF s = e.MeasureString(RadialGauge.GaugeLabel, RadialGauge.GaugeLableFont);

            if (RadialGauge.GaugeLabel == "Food")
            {
                additionalString = "/3000 Kcal";
                Image newImage = Image.FromFile("1_food.png");
                e.DrawImage(newImage, new Point(Center.X - (newImage.Size.Width / 2) - (int)DpiAware.LogicalToDeviceUnits(15), Center.Y - (newImage.Size.Height / 2) - (int)DpiAware.LogicalToDeviceUnits(15)));

            }
            if (RadialGauge.GaugeLabel == "Floor")
            {
                additionalString = "/100";
                Image newImage = Image.FromFile("1_floor.png");
                e.DrawImage(newImage, new Point(Center.X - (newImage.Size.Width / 2) - (int)DpiAware.LogicalToDeviceUnits(15), Center.Y - (newImage.Size.Height / 2) - (int)DpiAware.LogicalToDeviceUnits(15)));

            }
            if (RadialGauge.GaugeLabel == "Steps")
            {
                additionalString = "/100";
                Image newImage = Image.FromFile("1_steps.png");
                e.DrawImage(newImage, new Point(Center.X - (newImage.Size.Width / 2) - (int)DpiAware.LogicalToDeviceUnits(15), Center.Y - (newImage.Size.Height / 2) - (int)DpiAware.LogicalToDeviceUnits(15)));
            }

            e.DrawString(RadialGauge.GaugeLabel, RadialGauge.GaugeLableFont, br,
                new Point((int)((Center.X) - (s.Width / 2)), (int)(Center.Y + GaugeRadius / 2) + (int)DpiAware.LogicalToDeviceUnits(15)));

            using (Font f = new Font(RadialGauge.GaugeValueFont.Name, RadialGauge.GaugeValueFont.Size + 4))
            {
                additionalString = RadialGauge.Value.ToString() + additionalString;
                s = e.MeasureString(additionalString, f);
                Point p = new Point((int)((Center.X) - (s.Width / 2)), (int)(Center.Y + this.GaugeRadius / 3));
                br = new SolidBrush(this.RadialGauge.GaugeValueColor);
                e.DrawString(additionalString, f, br, p);

            }
            br.Dispose();
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
    }

    public partial class CustomRenderer1 : ILinearGaugeRenderer
    {
        /// </summary>
        /// Gets the Linear gauge
        /// </summary>
        private LinearGauge m_LinearGauge;
        /// <summary>
        /// Gets/Sets the Tick Distance of the Linear gauge.
        /// </summary>
        private float majorTicksDistance;
        /// <summary>
        /// Calculates the Minor Ticks Pixels.
        /// </summary>
        private float m_minorTicksPixels;
        /// <summary>
        /// Start point of the frame
        /// </summary>
        private int startpoint;
        /// <summary>
        /// Counts the Major ticks count for the given range.
        /// </summary>
        private int majorTicksCount;

        /// <summary>
        ///  Gets the Radial gauge
        /// </summary>
        internal LinearGauge LinearGauge
        {
            get
            {
                return m_LinearGauge;
            }
        }
        public CustomRenderer1(LinearGauge linearGauge)
        {
            m_LinearGauge = linearGauge;
            majorTicksDistance = 0;
            m_minorTicksPixels = 0;
            startpoint = 25;

        }
        public void DrawFrame(System.Drawing.Graphics Graphics)
        {
        }

        public void DrawLines(System.Drawing.Graphics Graphics)
        {
            Pen majorTickPen = new Pen(LinearGauge.MajorTickMarkColor, 2);
            Pen minorTickPen = new Pen(LinearGauge.MinorTickMarkColor);
            Brush brush = new SolidBrush(LinearGauge.ForeColor);
            StringFormat sf = new StringFormat();
            Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            majorTicksDistance = ((LinearGauge.MaximumValue - LinearGauge.MinimumValue) / LinearGauge.MajorDifference);
            majorTicksCount = ((int)(LinearGauge.MaximumValue - LinearGauge.MinimumValue) / (LinearGauge.MajorDifference)) + 1;
            double majortickValue = LinearGauge.MinimumValue;
            float tickPosition = 25f;
            float s = (LinearGauge.MaximumValue - LinearGauge.MinimumValue) % LinearGauge.MajorDifference;
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            GraphicsPath path = new GraphicsPath();
            int minorcount = LinearGauge.MinorTickCount;
            m_minorTicksPixels = ((this.LinearGauge.Width - (startpoint * 2)) / majorTicksDistance);
            int y = this.LinearGauge.Height / 2 - LinearGauge.MajorTicksHeight;
            int height = y + LinearGauge.MajorTicksHeight;
            Font strfont = new Font(LinearGauge.GaugelabelFont.FontFamily, LinearGauge.GaugelabelFont.Size + 3, FontStyle.Bold);
            Graphics.DrawString(this.LinearGauge.MinimumValue.ToString(), strfont, new SolidBrush(ColorTranslator.FromHtml("#ff8860")), new PointF(tickPosition, y + 25));
            Graphics.DrawString(this.LinearGauge.MaximumValue.ToString(), strfont, new SolidBrush(ColorTranslator.FromHtml("#ff8860")), new PointF(LinearGauge.Width-70, y + 25));
            Graphics.FillRectangle(new SolidBrush(LinearGauge.GaugeBaseColor), 24, this.LinearGauge.Height / 2, (((this.majorTicksDistance)) * m_minorTicksPixels) + 2, 10);
            brush.Dispose();
            minorTickPen.Dispose();
        }

        public void DrawRanges(System.Drawing.Graphics Graphics)
        {
            Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            foreach (LinearRange ptrRange in this.LinearGauge.Ranges)
            {
                int rvalve = (int)Math.Ceiling(LinearGauge.MaximumValue - ptrRange.EndValue) / LinearGauge.MajorDifference;
                if (ptrRange.EndValue > ptrRange.StartValue && ptrRange.EndValue <= this.LinearGauge.MaximumValue)
                {
                    if (this.LinearGauge.MinimumValue >= 0 && ptrRange.StartValue < 0)
                    {
                        return;
                    }
                    float startValue = (float)ptrRange.StartValue;
                    float endValue = (float)ptrRange.EndValue;
                    if (this.LinearGauge.MinimumValue < 0)
                    {
                        startValue = this.LinearGauge.MinimumValue + Math.Abs(ptrRange.StartValue);
                    }
                    if (this.LinearGauge.MinimumValue < 0 && ptrRange.StartValue > 0)
                    {
                        startValue = Math.Abs(this.LinearGauge.MinimumValue) + Math.Abs(ptrRange.StartValue);
                    }
                    if (this.LinearGauge.MinimumValue < 0 && ptrRange.StartValue == 0)
                    {
                        startValue = Math.Abs(this.LinearGauge.MinimumValue) + Math.Abs(ptrRange.StartValue);
                        startValue = (((startValue / LinearGauge.MajorDifference)) * m_minorTicksPixels);
                    }

                    float rangeheight = (ptrRange.EndValue / LinearGauge.MajorDifference) * m_minorTicksPixels;
                    float endvalueRangeHeight = 0f;
                    if (this.LinearGauge.MinimumValue < 0)
                    {
                        rangeheight = ((Math.Abs(this.LinearGauge.MinimumValue) + ptrRange.EndValue) / LinearGauge.MajorDifference) * m_minorTicksPixels;
                    }
                    endvalueRangeHeight = rangeheight;
                    if (this.LinearGauge.MinimumValue < 0 && ptrRange.StartValue == 0)
                    {
                        endvalueRangeHeight = (((ptrRange.EndValue - ptrRange.StartValue) / LinearGauge.MajorDifference) * m_minorTicksPixels);
                    }
                    //int placement = 10;
                    //if (LinearGauge.PointerPlacement == Placement.Near)
                    //    placement = 2;
                    //else if (LinearGauge.PointerPlacement == Placement.Far)
                    //    placement = 25;
                    //else placement = 10;
                    if (ptrRange.StartValue == 0)
                        Graphics.FillRectangle(new SolidBrush(ptrRange.Color), startpoint + Math.Abs(startValue), this.LinearGauge.Height / 2, (((ptrRange.EndValue / LinearGauge.MajorDifference)) * m_minorTicksPixels), 10);
                    else if (ptrRange.StartValue > 0)
                        Graphics.FillRectangle(new SolidBrush(ptrRange.Color), 25 + (((startValue / LinearGauge.MajorDifference)) * m_minorTicksPixels), this.LinearGauge.Height / 2, ((((ptrRange.EndValue - ptrRange.StartValue) / LinearGauge.MajorDifference)) * m_minorTicksPixels), 5);
                    else if (ptrRange.StartValue < 0)
                    {
                        startValue = this.LinearGauge.MinimumValue - ptrRange.StartValue;
                        Graphics.FillRectangle(new SolidBrush(ptrRange.Color), 25 + (((Math.Abs(startValue) / LinearGauge.MajorDifference)) * m_minorTicksPixels), this.LinearGauge.Height / 2, ((((ptrRange.EndValue - ptrRange.StartValue) / LinearGauge.MajorDifference)) * m_minorTicksPixels), 5);
                    }
                }
            }
        }

        public void DrawPointer(System.Drawing.Graphics Graphics)
        {
            Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            GraphicsPath path = new GraphicsPath();
            int a = 0;
            if (this.LinearGauge.MinimumValue < 0)
                a = (int)Math.Ceiling((((Math.Abs(this.LinearGauge.MinimumValue) + LinearGauge.Value) / (float)LinearGauge.MajorDifference) * m_minorTicksPixels));
            else
                a = (int)Math.Ceiling((Math.Abs(LinearGauge.Value - this.LinearGauge.MinimumValue) / (float)LinearGauge.MajorDifference) * m_minorTicksPixels);
            int y = (this.LinearGauge.Height / 2 + LinearGauge.MajorTicksHeight) - LinearGauge.MajorTicksHeight;
            Point pt1, pt2, pt3, pt4, pt5;
            a = a - 35;

            pt1 = new Point(10 + a, y - 30);
            pt2 = new Point(60 + a, y - 30);
            pt3 = new Point(60 + a, y);
            pt4 = new Point(55 + a, y - 8);
            pt5 = new Point(10 + a, y - 8);
            path.AddPolygon(new Point[] { pt1, pt2, pt3, pt4, pt5 });
            Graphics.FillPath((new SolidBrush(ColorTranslator.FromHtml("#ff8860"))), path);
            RectangleF rct=new RectangleF(a + 12F, y - 30F, 50F, 22F);
            SizeF strng = Graphics.MeasureString(this.LinearGauge.Value.ToString(), this.LinearGauge.GaugelabelFont);
            PointF pt = new PointF(rct.X + rct.Width / 2 - strng.Width / 2, rct.Y + rct.Height / 2 - strng.Height / 2);
            Graphics.DrawString(this.LinearGauge.Value.ToString(), this.LinearGauge.GaugelabelFont, new SolidBrush(Color.White), pt);
        }

        public void UpdateRenderer(System.Windows.Forms.PaintEventArgs PaintEventArgs)
        {
            DrawLines(PaintEventArgs.Graphics);
            DrawRanges(PaintEventArgs.Graphics);
            DrawPointer(PaintEventArgs.Graphics);
        }
    }
}
