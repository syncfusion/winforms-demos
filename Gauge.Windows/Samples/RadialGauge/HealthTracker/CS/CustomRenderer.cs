using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Syncfusion.Windows.Forms.Gauge;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GaugeInterctionSample
{
    public partial class CustomRenderer : IRadialGaugeRenderer
    {
        #region Varaibles
        /// </summary>
        /// Gets the radial gauge
        /// </summary>
        private RadialGauge m_RadialGauge;

        /// <summary>
        /// Used to set bounds for the Font
        /// </summary>
        Single fontBoundY1, fontBoundY2;
        #endregion

        #region Properties
        /// <summary>
        /// Gets the Radial gauge
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
        /// <summary>
        /// Constructor of the Renderer class
        /// </summary>
        /// <param name="radialGauge"></param>
        public CustomRenderer(RadialGauge radialGauge)
        {
            m_RadialGauge = radialGauge;

        }
        #endregion

        /// <summary>
        /// Used to calculate the text bounds 
        /// </summary>
        /// <param name="e">Paintevent arguement</param>
        /// <param name="m_font">Font used in Radial gauge</param>
        public void AdjustFontBounds(Graphics g, Font m_font)
        {
            //find upper and lower bounds for numeric characters
            Int32 c1;
            Int32 c2;
            Boolean boundFound;
            Bitmap b;
            SolidBrush backBrush = new SolidBrush(Color.White);
            SolidBrush foreBrush = new SolidBrush(Color.Black);
            SizeF boundingBox;

            boundingBox = g.MeasureString("0123456789", m_font, -1, StringFormat.GenericTypographic);
            b = new Bitmap((Int32)(boundingBox.Width), (Int32)(boundingBox.Height));
            g = Graphics.FromImage(b);
            g.FillRectangle(backBrush, 0.0F, 0.0F, boundingBox.Width, boundingBox.Height);
            g.DrawString("0123456789", m_font, foreBrush, 0.0F, 0.0F, StringFormat.GenericTypographic);

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

        /// <summary>
        /// Method used to draw outer arc.
        /// </summary>
        /// <param name="e">Paintevent arguement</param>
        /// <param name="m_GaugeArcStart">Arc start position</param>
        /// <param name="m_GaugeArcEnd">Arc end position</param>
        /// <param name="m_Center">Center point for gauge</param>
        public void DrawOuterArc(System.Drawing.Graphics e, int m_GaugeArcStart, int m_GaugeArcEnd, System.Drawing.Point m_Center, int GaugeRadius)
        {
            e.SmoothingMode = SmoothingMode.AntiAlias;
            e.PixelOffsetMode = PixelOffsetMode.HighQuality;
            GraphicsPath pth = new GraphicsPath();
            Color c = this.RadialGauge.Parent != null ? this.RadialGauge.Parent.BackColor : Color.Empty;
            Rectangle r = new Rectangle(0, 0, this.RadialGauge.Width, this.RadialGauge.Height);
            System.Drawing.Drawing2D.GraphicsPath basePath = new System.Drawing.Drawing2D.GraphicsPath();

            int x = this.RadialGauge.Width;
            int y = this.RadialGauge.Height;

            //Define rectangles inside which we will draw circles.

            Rectangle rect = new Rectangle(0 + 10, 0 + 10, (int)x - 20, (int)y - 20);
            Rectangle rectrim = new Rectangle(0 + 23, 0 + 23, (int)x - 46, (int)y - 46);
            Rectangle rectinner = new Rectangle(0 + 40, 0 + 40, (int)x - 80, (int)y - 80);

            if (GaugeRadius > 0)
            {
                e.DrawArc(new Pen(this.RadialGauge.GaugeArcColor, 7), new Rectangle(m_Center.X - GaugeRadius, m_Center.Y - GaugeRadius,
                   2 * GaugeRadius, 2 * GaugeRadius), m_GaugeArcStart, m_GaugeArcEnd );
            }
        }

        /// <summary>
        /// Method used to draw customization needle.
        /// </summary>
        /// <param name="graphics">Graphics</param>
        /// <param name="needle">Needle used in the gauge</param>
        /// <param name="m_gaugeArcStart">Arc start position</param>
        /// <param name="m_gaugeArcEnd">Arc end position</param>
        /// <param name="m_NeedleRadius">Needle radius</param>
        /// <param name="m_NeedleWidth">Needle width</param>
        /// <param name="m_center">Center point of the gauge</param>
        public void DrawMultipleNeedle(System.Drawing.Graphics Graphics, Needle Needle, int GaugeArcStart, int GaugeArcEnd, int NeedleRadius, int NeedleWidth, System.Drawing.Point Center)
        {
        }

        /// <summary>
        /// Method used to draw needle
        /// </summary>
        /// <param name="graphics">Graphics</param>
        /// <param name="m_GaugeArcStart">Arc start position</param>
        /// <param name="m_GaugeArcEnd">Arc end position</param>
        /// <param name="m_NeedleRadius">Needle radius</param>
        /// <param name="m_NeedleWidth">Needle width</param>
        /// <param name="m_Center">Center point of the gauge</param>
        public void DrawNeedle(System.Drawing.Graphics Graphics, int ArcStart, int ArcEnd, int NeedleRadius, int NeedleWidth, System.Drawing.Point Center)
        {
        }

        /// <summary>
        /// Used to draw the  label of the gauge
        /// </summary>
        /// <param name="e">paint event arguement</param>
        /// <param name="m_Center">Center point of the gauge</param>
        public void DrawGaugeLabel(Graphics e, Point Center, int GaugeRadius)
        {
            string additionalString = string.Empty;
            if (RadialGauge.GaugeLabel == "Food")
            {
                additionalString = "/3000 Kcal";
                Image newImage = Image.FromFile("..//..//1_food.png");
                e.DrawImage(newImage, new Point(Center.X - 35, Center.Y - 55));
            }
            if (RadialGauge.GaugeLabel == "Floor")
            {
                additionalString = "/100";
                Image newImage = Image.FromFile("..//..//1_floor.png");
                e.DrawImage(newImage, new Point(Center.X - 35, Center.Y - 55));
            }
            if (RadialGauge.GaugeLabel == "Steps")
            {
                additionalString = "/100";
                Image newImage = Image.FromFile("..//..//1_steps.png");
                e.DrawImage(newImage, new Point(Center.X - 35, Center.Y - 55));
            }
            SolidBrush br = new SolidBrush(this.RadialGauge.GaugeLableColor);
            SizeF s = e.MeasureString(RadialGauge.GaugeLabel, RadialGauge.GaugeLableFont);
            e.DrawString(RadialGauge.GaugeLabel, RadialGauge.GaugeLableFont, br,
                new Point((int)((Center.X) - (s.Width / 2)), (int)(Center.Y + GaugeRadius / 2) + 15));
            using (Font f = new Font(RadialGauge.GaugeValueFont.Name, RadialGauge.GaugeValueFont.Size + 4, FontStyle.Bold))
            {
                s = e.MeasureString(RadialGauge.Value.ToString() + additionalString, RadialGauge.GaugeValueFont);
                Point p = new Point((int)((Center.X) - (s.Width / 2)-15), (int)(Center.Y +GaugeRadius / 5));
                // Create rectangle for region.
                Rectangle excludeRect = new Rectangle(p.X - 3, (p.Y - 4) + 30, 32, 30);

                // Create region for exclusion.
                Region excludeRegion = new Region(excludeRect);

                // Set clipping region to exclude region.
                e.ExcludeClip(excludeRegion);

                // Fill large rectangle to show clipping region.
                br = new SolidBrush(this.RadialGauge.GaugeValueColor);
                e.DrawString(RadialGauge.Value.ToString() + additionalString, f, br, p);

            }
            br.Dispose();
        }

         /// <summary>
        /// Used to draw the ranges for the Gauge
        /// </summary>
        /// <param name="gr">Graphics</param>
        /// <param name="gp">Graphics path</param>
        /// <param name="m_GaugeArcStart">Start poistion of the arc</param>
        /// <param name="m_GaugeArcEnd">End position of the arc</param>
        /// <param name="m_GaugeArcRadius">Radius of the arc</param>
        /// <param name="m_Center">Center of the gauge</param>
        public void DrawRanges(Graphics gr, GraphicsPath gp, Int32 m_GaugeArcStart, Int32 m_GaugeArcEnd, Int32 m_GaugeArcRadius, Point m_Center)
        {
            Single rangeStartAngle;
            Single rangeSweepAngle;

            foreach (Range ptrRange in RadialGauge.Ranges)
            {
                if (ptrRange.EndValue > ptrRange.StartValue)
                {
                    rangeStartAngle = m_GaugeArcStart + (ptrRange.StartValue - RadialGauge.MinimumValue) * m_GaugeArcEnd / (RadialGauge.MaximumValue - RadialGauge.MinimumValue);
                    rangeSweepAngle = (ptrRange.EndValue - ptrRange.StartValue) * m_GaugeArcEnd / (RadialGauge.MaximumValue - RadialGauge.MinimumValue);
                    gr.SmoothingMode = SmoothingMode.AntiAlias;
                    gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    int m_GaugeArcRadius1 = m_GaugeArcRadius + RadialGauge.MajorTickMarkHeight;
                    gr.DrawArc(new Pen(ptrRange.Color, ptrRange.Height), new Rectangle(m_Center.X - m_GaugeArcRadius1, m_Center.Y - m_GaugeArcRadius1, 2 * m_GaugeArcRadius1, 2 * m_GaugeArcRadius1), rangeStartAngle, rangeSweepAngle);
                }
            }
        }

        /// <summary>
        /// Used to draw the tick marks of the gauge
        /// </summary>
        /// <param name="graphics">Graphics</param>
        /// <param name="gp">Graphics Path</param>
        /// <param name="m_GaugeArcRadius">Radius of the arc</param>
        /// <param name="m_GaugeArcStart">Start poistion of the arc</param>
        /// <param name="m_GaugeArcEnd">End position of the arc</param>
        /// <param name="m_MajorTickMarkWidth">Tick mark width</param>
        /// <param name="m_Center">Center of the gauge</param>
        public void DrawTickMarks(Graphics graphics, GraphicsPath gp, Int32 m_GaugeArcRadius, Int32 m_GaugeArcStart, Int32 m_GaugeArcEnd, Int32 m_MajorTickMarkWidth, Point m_Center, int m_ScaleNumbersRadius)
        {
        }

        public void UpdateRenderer(System.Windows.Forms.PaintEventArgs e)
        {
            AdjustFontBounds(e.Graphics, RadialGauge.Font);
            DrawOuterArc(e.Graphics, 135, 270, new Point(140, 140), 120);
            DrawGaugeLabel(e.Graphics, new Point(140, 140), 118);
            DrawRanges(e.Graphics, new System.Drawing.Drawing2D.GraphicsPath(), 135, 270, 120, new Point(140, 140));
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
