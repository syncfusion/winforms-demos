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

namespace CustomRenderer_2008
{
    class CustomRenderer1 : ILinearGaugeRenderer
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
            Pen majorTickPen = new Pen(LinearGauge.MajorTickMarkColor);
            Pen minorTickPen = new Pen(LinearGauge.MinorTickMarkColor);
            Brush brush = new SolidBrush(LinearGauge.ForeColor);
            StringFormat sf = new StringFormat();
            Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            majorTicksDistance = ((LinearGauge.MaximumValue - LinearGauge.MinimumValue) / LinearGauge.MajorDifference);
            majorTicksCount = ((int)(LinearGauge.MaximumValue - LinearGauge.MinimumValue) / (LinearGauge.MajorDifference)) + 1;
            double majortickValue = LinearGauge.MinimumValue;
            float tickPosition = 25f;
            float temp1 = 0;
            float s = (LinearGauge.MaximumValue - LinearGauge.MinimumValue) % LinearGauge.MajorDifference;
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            float minortickValue = 0;
            float tickPositionminor = 0;
            GraphicsPath path = new GraphicsPath();
            int minorcount = LinearGauge.MinorTickCount;
            m_minorTicksPixels = ((this.LinearGauge.Height - 50) / majorTicksDistance);
            int x = this.LinearGauge.Width / 2;
            temp1 = 0;
            for (int L = 1; L <= majorTicksCount; L++)
            {
                Graphics.DrawLine(majorTickPen, x, this.LinearGauge.Height - tickPosition, x - LinearGauge.MajorTicksHeight, this.LinearGauge.Height - tickPosition);
                Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                if (LinearGauge.ShowScaleLabel)
                    Graphics.DrawString(Math.Round(majortickValue, 2).ToString(),
                             LinearGauge.Font, brush, new PointF(x - LinearGauge.MajorTicksHeight - 25, this.LinearGauge.Height - tickPosition), sf);
                if (L == majorTicksCount)
                    minorcount = (LinearGauge.MinorTickCount * (int)Math.Ceiling(s)) / LinearGauge.MajorDifference;
                if (majortickValue < LinearGauge.MaximumValue)
                {
                    for (int S = 1; S <= minorcount; S++)
                    {
                        minortickValue = (m_minorTicksPixels / (LinearGauge.MinorTickCount + 1)) * S;
                        tickPositionminor = this.LinearGauge.Height - (minortickValue + temp1 + 25);
                        Graphics.DrawLine(minorTickPen, x, (float)tickPositionminor, x - LinearGauge.MinorTickHeight, (float)tickPositionminor);
                    }
                    temp1 = m_minorTicksPixels * L;
                }

                majortickValue += LinearGauge.MajorDifference;
                tickPosition += m_minorTicksPixels;
            }
            Graphics.FillRectangle(new SolidBrush(LinearGauge.GaugeBaseColor), this.LinearGauge.Width / 2, startpoint - 1, 1, (((this.majorTicksDistance)) * m_minorTicksPixels) + 2);
            if (this.LinearGauge.MinimumValue > 0)
                Graphics.FillRectangle(new SolidBrush(LinearGauge.ValueIndicatorColor), this.LinearGauge.Width / 2 + 10, startpoint + (majorTicksDistance * m_minorTicksPixels) - (((LinearGauge.Value / LinearGauge.MajorDifference)) * m_minorTicksPixels), 5, (((LinearGauge.Value / LinearGauge.MajorDifference)) * m_minorTicksPixels) + 2);
            else
                Graphics.FillRectangle(new SolidBrush(LinearGauge.ValueIndicatorColor), this.LinearGauge.Width / 2 + 10, startpoint + (majorTicksDistance * m_minorTicksPixels) - ((((Math.Abs(this.LinearGauge.MinimumValue) + LinearGauge.Value) / LinearGauge.MajorDifference)) * m_minorTicksPixels), 5, ((((Math.Abs(this.LinearGauge.MinimumValue) + LinearGauge.Value) / LinearGauge.MajorDifference)) * m_minorTicksPixels) + 2);
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
                    int placement = 10;
                    if (LinearGauge.PointerPlacement == Placement.Near)
                        placement = 2;
                    else if (LinearGauge.PointerPlacement == Placement.Far)
                        placement = 25;
                    else placement = 10;
                    if (ptrRange.StartValue == 0)
                        Graphics.FillRectangle(new SolidBrush(ptrRange.Color), this.LinearGauge.Width / 2 + placement, startpoint + (majorTicksDistance * m_minorTicksPixels) - rangeheight, 8, endvalueRangeHeight);
                    else if (ptrRange.StartValue > 0)
                        Graphics.FillRectangle(new SolidBrush(ptrRange.Color), this.LinearGauge.Width / 2 + placement, startpoint + (majorTicksDistance * m_minorTicksPixels) - rangeheight, 8, (((ptrRange.EndValue - ptrRange.StartValue) / LinearGauge.MajorDifference) * m_minorTicksPixels));
                    else if (ptrRange.StartValue < 0)
                    {
                        Graphics.FillRectangle(new SolidBrush(ptrRange.Color), this.LinearGauge.Width / 2 + placement, startpoint + (majorTicksDistance * m_minorTicksPixels) - rangeheight, 8, (((ptrRange.EndValue - ptrRange.StartValue) / LinearGauge.MajorDifference) * m_minorTicksPixels));
                    }
                }
            }
        }

        public void DrawPointer(System.Drawing.Graphics Graphics)
        {
            Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            GraphicsPath path = new GraphicsPath();
            int a = 0;
            if (this.LinearGauge.MinimumValue < 0)
                a = (int)Math.Ceiling((((Math.Abs(this.LinearGauge.MinimumValue) + LinearGauge.Value) / (float)LinearGauge.MajorDifference) * m_minorTicksPixels));
            else
                a = (int)Math.Ceiling(((LinearGauge.Value / (float)LinearGauge.MajorDifference) * m_minorTicksPixels));
            int y = (this.LinearGauge.Height / 2 + 5 + LinearGauge.MajorTicksHeight) - LinearGauge.MajorTicksHeight;
            a = 10 + (int)Math.Ceiling((majorTicksDistance * m_minorTicksPixels)) - a;
            int placement = 28;
            if (LinearGauge.PointerPlacement == Placement.Near)
                placement = 19;
            else if (LinearGauge.PointerPlacement == Placement.Far)
                placement = 42;
            else placement = 28;
            Rectangle rect = new Rectangle(new Point(this.LinearGauge.Width / 2 + placement, a), new Size(32, 32));
            SizeF sf = Graphics.MeasureString(this.LinearGauge.Value.ToString(), this.LinearGauge.GaugelabelFont);
            PointF point = new PointF(rect.X + rect.Width / 2 - sf.Width / 2, rect.Y + rect.Height / 2 - sf.Height / 2);
            Graphics.FillEllipse(new SolidBrush(LinearGauge.NeedleColor), rect);
            Graphics.DrawEllipse(new Pen(ColorTranslator.FromHtml("#00a0d1")), rect);
            Graphics.DrawLine(new Pen(ColorTranslator.FromHtml("#00a0d1")), rect.X, rect.Y + rect.Height / 2, rect.X - 18, rect.Y + rect.Height / 2);
            Graphics.DrawString(Math.Round(LinearGauge.Value, 2).ToString(), this.LinearGauge.GaugelabelFont, new SolidBrush(ColorTranslator.FromHtml("#024e60")), point);
        }

        public void UpdateRenderer(System.Windows.Forms.PaintEventArgs PaintEventArgs)
        {
            DrawLines(PaintEventArgs.Graphics);
            DrawRanges(PaintEventArgs.Graphics);
            DrawPointer(PaintEventArgs.Graphics);
        }
    }

    class CustomRenderer2 : ILinearGaugeRenderer
    {
        #region Varaibles
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

        #endregion

        #region Properties
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
        #endregion

        #region Constructor
        public CustomRenderer2(LinearGauge linearGauge)
        {
            m_LinearGauge = linearGauge;
            majorTicksDistance = 0;
            m_minorTicksPixels = 0;
            startpoint = 10;
        }
        #endregion

        public void DrawFrame(Graphics g)
        {

        }

        public void DrawLines(Graphics Graphics)
        {
            Pen majorTickPen = new Pen(LinearGauge.MajorTickMarkColor);
            Pen minorTickPen = new Pen(LinearGauge.MinorTickMarkColor);
            Brush brush = new SolidBrush(LinearGauge.ForeColor);
            StringFormat sf = new StringFormat();
            Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            majorTicksDistance = ((LinearGauge.MaximumValue - LinearGauge.MinimumValue) / LinearGauge.MajorDifference);
            majorTicksCount = ((int)(LinearGauge.MaximumValue - LinearGauge.MinimumValue) / (LinearGauge.MajorDifference)) + 1;
            double majortickValue = LinearGauge.MinimumValue;
            float tickPosition = 40f;
            float temp1 = 0;
            float s = (LinearGauge.MaximumValue - LinearGauge.MinimumValue) % LinearGauge.MajorDifference;
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            float minortickValue = 0;
            float tickPositionminor = 0;
            GraphicsPath path = new GraphicsPath();
            int minorcount = LinearGauge.MinorTickCount;
            m_minorTicksPixels = ((this.LinearGauge.Height - 50) / majorTicksDistance);
            int x = this.LinearGauge.Width / 2;
            temp1 = 0;
            for (int L = 1; L <= majorTicksCount; L++)
            {
                Graphics.DrawLine(majorTickPen, x, this.LinearGauge.Height - tickPosition, x - LinearGauge.MajorTicksHeight, this.LinearGauge.Height - tickPosition);
                Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                if (LinearGauge.ShowScaleLabel)
                    Graphics.DrawString(Math.Round(majortickValue, 2).ToString(),
                             LinearGauge.Font, brush, new PointF(x - LinearGauge.MajorTicksHeight - 25, this.LinearGauge.Height - tickPosition), sf);
                if (L == majorTicksCount)
                    minorcount = (LinearGauge.MinorTickCount * (int)Math.Ceiling(s)) / LinearGauge.MajorDifference;
                if (majortickValue < LinearGauge.MaximumValue)
                {
                    for (int S = 1; S <= minorcount; S++)
                    {
                        minortickValue = (m_minorTicksPixels / (LinearGauge.MinorTickCount + 1)) * S;
                        tickPositionminor = this.LinearGauge.Height - (minortickValue + temp1 + 40);
                        Graphics.DrawLine(minorTickPen, x, (float)tickPositionminor, x - LinearGauge.MinorTickHeight, (float)tickPositionminor);
                    }
                    temp1 = m_minorTicksPixels * L;
                }

                majortickValue += LinearGauge.MajorDifference;
                tickPosition += m_minorTicksPixels;
            }
            Graphics.FillRectangle(new SolidBrush(LinearGauge.GaugeBaseColor), this.LinearGauge.Width / 2, startpoint - 1, 1, (((this.majorTicksDistance)) * m_minorTicksPixels) + 2);

            minorTickPen.Dispose();
        }

        public void DrawRanges(Graphics Graphics)
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
                    int placement = 30;
                    if (LinearGauge.PointerPlacement == Placement.Near)
                        placement = 12;
                    else if (LinearGauge.PointerPlacement == Placement.Far)
                        placement = 30;
                    else placement = 20;
                    RectangleF outerRect = new RectangleF(this.LinearGauge.Width / 2 + placement - 8, startpoint - 10 + (majorTicksDistance * m_minorTicksPixels) - rangeheight, 25, endvalueRangeHeight + 13);
                    if (ptrRange.StartValue == 0)
                    {
                        PointF[] points = { new PointF(outerRect.Left, outerRect.Bottom), new PointF(outerRect.Left, outerRect.Top), new PointF(outerRect.Right, outerRect.Top), new PointF(outerRect.Right, outerRect.Bottom) };
                        Graphics.FillRectangle(new SolidBrush(ptrRange.Color), this.LinearGauge.Width / 2 + placement, startpoint + (majorTicksDistance * m_minorTicksPixels) - rangeheight, 8, endvalueRangeHeight + 10);
                        Graphics.DrawArc(new Pen(LinearGauge.GaugeBaseColor, 1), outerRect.Left - 8, outerRect.Bottom - 5, 40F, 40F, 310, 285);
                        Graphics.DrawLines(new Pen(LinearGauge.GaugeBaseColor), points);
                    }
                    else if (ptrRange.StartValue > 0)
                        Graphics.FillRectangle(new SolidBrush(ptrRange.Color), this.LinearGauge.Width / 2 + placement, startpoint + (majorTicksDistance * m_minorTicksPixels) - rangeheight, 8, (((ptrRange.EndValue - ptrRange.StartValue) / LinearGauge.MajorDifference) * m_minorTicksPixels));
                    else if (ptrRange.StartValue < 0)
                    {
                        Graphics.FillRectangle(new SolidBrush(ptrRange.Color), this.LinearGauge.Width / 2 + 0, startpoint + (majorTicksDistance * m_minorTicksPixels) - rangeheight, 8, (((ptrRange.EndValue - ptrRange.StartValue) / LinearGauge.MajorDifference) * m_minorTicksPixels));
                    }
                    if (this.LinearGauge.MinimumValue > 0)
                    {
                        RectangleF innerRect = new RectangleF(this.LinearGauge.Width / 2 + placement-3, startpoint + (majorTicksDistance * m_minorTicksPixels) - (((LinearGauge.Value / LinearGauge.MajorDifference)) * m_minorTicksPixels), 8, (((LinearGauge.Value / LinearGauge.MajorDifference)) * m_minorTicksPixels) + 2);
                        Graphics.FillRectangle(new SolidBrush(LinearGauge.ValueIndicatorColor), this.LinearGauge.Width / 2 + placement, startpoint + (majorTicksDistance * m_minorTicksPixels) - (((LinearGauge.Value / LinearGauge.MajorDifference)) * m_minorTicksPixels), 8, (((LinearGauge.Value / LinearGauge.MajorDifference)) * m_minorTicksPixels) + 2);
                        Graphics.FillEllipse(new SolidBrush(LinearGauge.ValueIndicatorColor), innerRect.Left, innerRect.Bottom, 8F, 8F);
                    }
                    else
                    {
                        RectangleF innerRect = new RectangleF(this.LinearGauge.Width / 2 + placement-1, startpoint + (majorTicksDistance * m_minorTicksPixels) - ((((Math.Abs(this.LinearGauge.MinimumValue) + LinearGauge.Value) / LinearGauge.MajorDifference)) * m_minorTicksPixels), 8, ((((Math.Abs(this.LinearGauge.MinimumValue) + LinearGauge.Value) / LinearGauge.MajorDifference)) * m_minorTicksPixels) + 2);
                        Graphics.FillRectangle(new SolidBrush(LinearGauge.ValueIndicatorColor), this.LinearGauge.Width / 2 + placement, startpoint + (majorTicksDistance * m_minorTicksPixels) - ((((Math.Abs(this.LinearGauge.MinimumValue) + LinearGauge.Value) / LinearGauge.MajorDifference)) * m_minorTicksPixels), 8, ((((Math.Abs(this.LinearGauge.MinimumValue) + LinearGauge.Value) / LinearGauge.MajorDifference)) * m_minorTicksPixels) + 8);
                        Graphics.FillEllipse(new SolidBrush(LinearGauge.ValueIndicatorColor), innerRect.Left - 10, innerRect.Bottom, 30F, 30F);
                    }
                }
            }
        }

        public void DrawPointer(Graphics Graphics)
        {

        }

        public void UpdateRenderer(System.Windows.Forms.PaintEventArgs PaintEventArgs)
        {
            DrawFrame(PaintEventArgs.Graphics);
            DrawLines(PaintEventArgs.Graphics);
            DrawRanges(PaintEventArgs.Graphics);
            DrawPointer(PaintEventArgs.Graphics);
        }
    }

    class CustomRenderer3 : ILinearGaugeRenderer
    {
        #region Varaibles
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

        private int startpoint;
        private int majorTicksCount;

        #endregion

        #region Properties
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
        #endregion

        #region Constructor
        public CustomRenderer3(LinearGauge linearGauge)
        {
            m_LinearGauge = linearGauge;
            majorTicksDistance = 0;
            m_minorTicksPixels = 0;
            startpoint = 25;
            majorTicksCount = 0;
        }
        #endregion

        public void DrawFrame(System.Drawing.Graphics Graphics)
        {
        }

        public void DrawLines(System.Drawing.Graphics Graphics)
        {
            Pen majorTickPen = new Pen(LinearGauge.MajorTickMarkColor, 2);
            Pen minorTickPen = new Pen(LinearGauge.MinorTickMarkColor, 2);
            Brush brush = new SolidBrush(Color.Black);
            StringFormat sf = new StringFormat();
            Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            majorTicksDistance = ((LinearGauge.MaximumValue - LinearGauge.MinimumValue) / LinearGauge.MajorDifference);
            majorTicksCount = ((int)(LinearGauge.MaximumValue - LinearGauge.MinimumValue) / (LinearGauge.MajorDifference)) + 1;
            double majortickValue = LinearGauge.MinimumValue;
            float tickPosition = 25f;
            float temp1 = 0;
            float s = (LinearGauge.MaximumValue - LinearGauge.MinimumValue) % LinearGauge.MajorDifference;
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            float minortickValue = 0;
            float tickPositionminor = 0;
            GraphicsPath path = new GraphicsPath();
            int minorcount = LinearGauge.MinorTickCount;
            m_minorTicksPixels = ((this.LinearGauge.Height - 50) / majorTicksDistance);
            int x = this.LinearGauge.Width / 2;
            temp1 = 0;
            for (int L = 1; L <= majorTicksCount; L++)
            {
                Graphics.DrawLine(majorTickPen, x, this.LinearGauge.Height - tickPosition, x - LinearGauge.MajorTicksHeight, this.LinearGauge.Height - tickPosition);
                if (LinearGauge.ShowScaleLabel)
                    Graphics.DrawString(Math.Round(majortickValue, 2).ToString(),
                             LinearGauge.Font, brush, new PointF(x - LinearGauge.MajorTicksHeight - 25, this.LinearGauge.Height - tickPosition), sf);
                if (L == majorTicksCount)
                    minorcount = (LinearGauge.MinorTickCount * (int)Math.Ceiling(s)) / LinearGauge.MajorDifference;
                if (majortickValue < LinearGauge.MaximumValue)
                {
                    for (int S = 1; S <= minorcount; S++)
                    {
                        minortickValue = (m_minorTicksPixels / (LinearGauge.MinorTickCount + 1)) * S;
                        tickPositionminor = this.LinearGauge.Height - (minortickValue + temp1 + 25);
                        Graphics.DrawLine(minorTickPen, x, (float)tickPositionminor, x - LinearGauge.MinorTickHeight, (float)tickPositionminor);
                    }
                    temp1 = m_minorTicksPixels * L;
                }

                majortickValue += LinearGauge.MajorDifference;
                tickPosition += m_minorTicksPixels;
            }
            Graphics.FillRectangle(new SolidBrush(LinearGauge.GaugeBaseColor), this.LinearGauge.Width / 2, startpoint - 1, 5, (((this.majorTicksDistance)) * m_minorTicksPixels) + 2);
            if (this.LinearGauge.MinimumValue > 0)
                Graphics.FillRectangle(new SolidBrush(LinearGauge.ValueIndicatorColor), this.LinearGauge.Width / 2, startpoint + (majorTicksDistance * m_minorTicksPixels) - (((LinearGauge.Value / LinearGauge.MajorDifference)) * m_minorTicksPixels), 5, (((LinearGauge.Value / LinearGauge.MajorDifference)) * m_minorTicksPixels) + 2);
            else
                Graphics.FillRectangle(new SolidBrush(LinearGauge.ValueIndicatorColor), this.LinearGauge.Width / 2, startpoint + (majorTicksDistance * m_minorTicksPixels) - ((((Math.Abs(this.LinearGauge.MinimumValue) + LinearGauge.Value) / LinearGauge.MajorDifference)) * m_minorTicksPixels), 5, ((((Math.Abs(this.LinearGauge.MinimumValue) + LinearGauge.Value) / LinearGauge.MajorDifference)) * m_minorTicksPixels) + 2);
            //brush.Dispose();
            //minorTickPen.Dispose();
            //Graphics.FillRectangle(new SolidBrush(LinearGauge.GaugeBaseColor), 24, this.LinearGauge.Height / 4, (((this.majorTicksDistance)) * m_minorTicksPixels) + 2, 30);
            Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            brush.Dispose();
            minorTickPen.Dispose();
        }

        public void DrawRanges(System.Drawing.Graphics Graphics)
        {

            Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            GraphicsPath path = new GraphicsPath();
            GraphicsPath path1 = new GraphicsPath();
            path.FillMode = FillMode.Alternate;
            path1.FillMode = FillMode.Alternate;
            foreach (LinearRange ptrRange in this.LinearGauge.Ranges)
            {
                int rvalve = (int)Math.Ceiling(LinearGauge.MaximumValue - ptrRange.EndValue) / LinearGauge.MajorDifference;
                if (ptrRange.EndValue > ptrRange.StartValue && ptrRange.EndValue <= this.LinearGauge.MaximumValue)
                {
                    if (this.LinearGauge.MinimumValue >= 0 && ptrRange.StartValue < 0)
                    {
                        return;
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
                    int placement = 30;
                    if (LinearGauge.PointerPlacement == Placement.Near)
                        placement = 12;
                    else if (LinearGauge.PointerPlacement == Placement.Far)
                        placement = 30;
                    else placement = 20;
                    if (ptrRange.StartValue == 0)
                    {
                        PointF p1, p2, p3, p4;
                        RectangleF rect1 = new RectangleF(this.LinearGauge.Width / 2 + placement, startpoint + (majorTicksDistance * m_minorTicksPixels) - rangeheight - 4, 15, endvalueRangeHeight + 6);//new RectangleF(startpoint + Math.Abs(startValue), this.LinearGauge.Height / 4 - 20, (((ptrRange.EndValue / LinearGauge.MajorDifference)) * m_minorTicksPixels), 15);
                        p1 = new PointF(rect1.Left, rect1.Bottom);
                        p2 = new PointF(rect1.Left, rect1.Top);
                        p3 = new PointF(rect1.Right, rect1.Top);
                        p4 = new PointF(rect1.Left + 4, rect1.Bottom);
                        path.AddPolygon(new PointF[] { p1, p2, p3, p4 });
                        Graphics.FillPath((new SolidBrush(ptrRange.Color)), path);
                    }
                    else if (ptrRange.StartValue == 50)
                    {
                        Graphics.FillRectangle(new SolidBrush(ptrRange.Color), this.LinearGauge.Width / 2 + placement, startpoint + (majorTicksDistance * m_minorTicksPixels) - rangeheight, 15, (((ptrRange.EndValue - ptrRange.StartValue) / LinearGauge.MajorDifference) * m_minorTicksPixels));
                    }
                    else if (ptrRange.StartValue == 70)
                    {
                        PointF p1, p2, p3, p4;
                        RectangleF rect = new RectangleF(this.LinearGauge.Width / 2 + placement, startpoint + (majorTicksDistance * m_minorTicksPixels) - rangeheight, 15, (((ptrRange.EndValue - ptrRange.StartValue) / LinearGauge.MajorDifference) * m_minorTicksPixels)); //new RectangleF(25 + (((startValue / LinearGauge.MajorDifference)) * m_minorTicksPixels), this.LinearGauge.Height / 4 - 20, ((((ptrRange.EndValue - ptrRange.StartValue) / LinearGauge.MajorDifference)) * m_minorTicksPixels), 15);
                        p1 = new PointF(rect.Left, rect.Bottom);
                        p2 = new PointF(rect.Left, rect.Top);
                        p3 = new PointF(rect.Left + 4, rect.Top);
                        p4 = new PointF(rect.Right, rect.Bottom);
                        path1.AddPolygon(new PointF[] { p1, p2, p3, p4 });
                        Graphics.FillPath((new SolidBrush(ptrRange.Color)), path1);
                    }
                }
            }
        }

        public void DrawPointer(System.Drawing.Graphics Graphics)
        {
            //Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //GraphicsPath path = new GraphicsPath();
            //int a = 0;
            //if (this.LinearGauge.MinimumValue < 0)
            //    a = (int)Math.Ceiling((((Math.Abs(this.LinearGauge.MinimumValue) + LinearGauge.Value) / (float)LinearGauge.MajorDifference) * m_minorTicksPixels));
            //else
            //    a = (int)Math.Ceiling(((LinearGauge.Value / (float)LinearGauge.MajorDifference) * m_minorTicksPixels));
            //int y = (this.LinearGauge.Height / 2 + LinearGauge.MajorTicksHeight) - LinearGauge.MajorTicksHeight;
            //Point pt1, pt2, pt3;
            //a = a + 10;
            //pt1 = new Point(8 + a, y + 55);
            //pt2 = new Point(22 + a, y + 55);
            //pt3 = new Point(15 + a, y + 42);
            //path.AddPolygon(new Point[] { pt1, pt2, pt3 });
            //Graphics.FillPath((new SolidBrush(LinearGauge.NeedleColor)), path);
        }

        public void UpdateRenderer(System.Windows.Forms.PaintEventArgs PaintEventArgs)
        {
            DrawFrame(PaintEventArgs.Graphics);
            DrawLines(PaintEventArgs.Graphics);
            //DrawPointer(PaintEventArgs.Graphics);
            DrawRanges(PaintEventArgs.Graphics);
        }
    }

}
