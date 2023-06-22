#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
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

namespace CarDashboard
{
    public class FuelGaugeCustomRenderer : IRadialGaugeRenderer
    {
        #region Varaibles
        
        private RadialGauge m_RadialGauge;
      
        Single fontBoundY1, fontBoundY2;
        #endregion

        #region Properties
        internal RadialGauge RadialGauge
        {
            get
            {
                return m_RadialGauge;
            }
        }
        #endregion

        #region Constructor
        public void UpdateRenderer(PaintEventArgs e)
        {
            int centre = this.RadialGauge.Width / 2;
            AdjustFontBounds(e.Graphics, RadialGauge.Font);
            DrawOuterArc(e.Graphics, 230, 80, new Point(centre, centre), (int)DpiAware.LogicalToDeviceUnits(70));
            DrawGaugeLabel(e.Graphics, new Point(centre, centre), (int)DpiAware.LogicalToDeviceUnits(55));
            DrawRanges(e.Graphics, new System.Drawing.Drawing2D.GraphicsPath(), 230, 80, (int)DpiAware.LogicalToDeviceUnits(80), new Point(centre, centre));
            DrawTickMarks(e.Graphics, new System.Drawing.Drawing2D.GraphicsPath(), (int)DpiAware.LogicalToDeviceUnits(70), 230, 80, 3, new Point(centre, centre), (int)DpiAware.LogicalToDeviceUnits(60));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="radialGauge"></param>
        public FuelGaugeCustomRenderer(RadialGauge radialGauge)
        {
            m_RadialGauge = radialGauge;

        }
        #endregion

        #region IRadialGaugeRenderer Members

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
        public void DrawOuterArc(Graphics e, Int32 m_GaugeArcStart, Int32 m_GaugeArcEnd, Point m_Center, int GaugeRadius)
        {
            e.SmoothingMode = SmoothingMode.AntiAlias;
            e.PixelOffsetMode = PixelOffsetMode.HighQuality;
            GraphicsPath pth = new GraphicsPath();
            Color c = this.RadialGauge.Parent != null ? this.RadialGauge.Parent.BackColor : Color.Empty;
            Rectangle r = new Rectangle(0, 0, this.RadialGauge.Width, this.RadialGauge.Height);
            System.Drawing.Drawing2D.GraphicsPath basePath = new System.Drawing.Drawing2D.GraphicsPath();
            if (GaugeRadius > 0)
            {
                e.DrawArc(new Pen(this.RadialGauge.GaugeArcColor, 8), new Rectangle(m_Center.X - GaugeRadius, m_Center.Y - GaugeRadius,
                   2 * GaugeRadius, 2 * GaugeRadius), m_GaugeArcStart, m_GaugeArcEnd);
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
        public void DrawMultipleNeedle(Graphics graphics, Needle needle, Int32 m_gaugeArcStart, Int32 m_gaugeArcEnd, Int32 m_NeedleRadius, int m_NeedleWidth, Point m_center)
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
        public void DrawNeedle(Graphics graphics, Int32 m_GaugeArcStart, Int32 m_GaugeArcEnd, Int32 m_NeedleRadius, Int32 m_NeedleWidth, Point m_Center)
        {

        }

        /// <summary>
        /// Used to draw the  label of the gauge
        /// </summary>
        /// <param name="e">paint event arguement</param>
        /// <param name="m_Center">Center point of the gauge</param>
        public void DrawGaugeLabel(Graphics e, Point m_Center, int GaugeRadius)
        {
            SolidBrush br = new SolidBrush(this.RadialGauge.GaugeLableColor);
            SizeF s = e.MeasureString(RadialGauge.GaugeLabel, RadialGauge.GaugeLableFont);

            e.DrawString(RadialGauge.GaugeLabel, RadialGauge.GaugeLableFont, br,
              new Point((int)((m_Center.X) - (s.Width / 2)), (int)(m_Center.Y + GaugeRadius / 2 - 10)));
            if (RadialGauge.ShowGaugeValue)
            {
                using (Font f = new Font(RadialGauge.GaugeValueFont.Name, RadialGauge.GaugeValueFont.Size + 4))
                {
                    br = new SolidBrush(this.RadialGauge.GaugeValueColor);
                    s = e.MeasureString("000", RadialGauge.GaugeValueFont);
                    Rectangle rect = new Rectangle((new Point((int)((m_Center.X) - (s.Width - 13)), (int)(m_Center.Y - GaugeRadius / 4 + 1))), new Size((int)s.Width + 28, (int)s.Height + 1));
                    e.DrawRectangle(new Pen(ColorTranslator.FromHtml("#3d3939")), new Rectangle((new Point((int)((m_Center.X) - (s.Width - 13)), (int)(m_Center.Y - GaugeRadius / 4 + 1))), new Size((int)s.Width + 28, (int)s.Height + 1)));
                    e.DrawLine(new Pen(Color.Black), rect.Left, rect.Bottom, rect.Right, rect.Bottom);
                    if (RadialGauge.Value == 100)
                    {
                        e.DrawString(RadialGauge.Value.ToString(), f, br,
                  new Point((int)((m_Center.X) - (s.Width / 3 + 9)), (int)(m_Center.Y - GaugeRadius / 4)));
                    }
                    else
                        e.DrawString(RadialGauge.Value.ToString(), f, br,
                       new Point((int)((m_Center.X) - (s.Width / 3 + 3)), (int)(m_Center.Y - GaugeRadius / 4)));
                }
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

            foreach (Syncfusion.Windows.Forms.Gauge.Range ptrRange in RadialGauge.Ranges)
            {
                if (ptrRange.EndValue > ptrRange.StartValue)
                {
                    rangeStartAngle = m_GaugeArcStart + (ptrRange.StartValue - RadialGauge.MinimumValue) * m_GaugeArcEnd / (RadialGauge.MaximumValue - RadialGauge.MinimumValue);
                    rangeSweepAngle = (ptrRange.EndValue - ptrRange.StartValue) * m_GaugeArcEnd / (RadialGauge.MaximumValue - RadialGauge.MinimumValue);

                    gr.SmoothingMode = SmoothingMode.AntiAlias;
                    gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    int m_GaugeArcRadius1 = m_GaugeArcRadius - RadialGauge.MajorTickMarkHeight - ptrRange.Height;
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
            String valueText = "";
            SizeF boundingBox;
            Single countValue = 0;
            int TempGaugeArcRadius = m_GaugeArcRadius;
            TempGaugeArcRadius = m_GaugeArcRadius + 12;
            boundingBox = graphics.MeasureString("E", RadialGauge.Font, -1, StringFormat.GenericTypographic);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            graphics.DrawString("E", RadialGauge.Font, new SolidBrush(this.RadialGauge.ScaleLabelColor), m_Center.X - 75, m_Center.Y - 75, StringFormat.GenericTypographic);
            while (countValue <= (RadialGauge.MaximumValue - RadialGauge.MinimumValue))
            {
                valueText = (RadialGauge.MinimumValue + countValue).ToString();
                graphics.ResetTransform();
                boundingBox = graphics.MeasureString(valueText, RadialGauge.Font, -1, StringFormat.GenericTypographic);

                Int32 linevalue = TempGaugeArcRadius - RadialGauge.MajorTickMarkHeight;
                Int32 lineminervalue = TempGaugeArcRadius - RadialGauge.MinorTickMarkHeight;
                Int32 lineminerintervalue = TempGaugeArcRadius - RadialGauge.MinorInnerLinesHeight;
                gp.Reset();
                gp.AddEllipse(new Rectangle(m_Center.X - TempGaugeArcRadius, m_Center.Y - TempGaugeArcRadius, 2 * TempGaugeArcRadius, 2 * TempGaugeArcRadius));
                gp.Reverse();
                gp.AddEllipse(new Rectangle(m_Center.X - linevalue, m_Center.Y - linevalue, 2 * linevalue, 2 * linevalue));
                gp.Reverse();
                graphics.SetClip(gp);

                graphics.DrawLine(new Pen(this.RadialGauge.MajorTickMarkColor, m_MajorTickMarkWidth),
                               (Single)(m_Center.X),
                               (Single)(m_Center.Y),
                               (Single)(m_Center.X + 2 * lineminervalue * Math.Cos((m_GaugeArcStart + countValue * m_GaugeArcEnd / (RadialGauge.MaximumValue - RadialGauge.MinimumValue)) * Math.PI / 180.0)),
                               (Single)(m_Center.Y + 2 * lineminervalue * Math.Sin((m_GaugeArcStart + countValue * m_GaugeArcEnd / (RadialGauge.MaximumValue - RadialGauge.MinimumValue)) * Math.PI / 180.0)));

                gp.Reset();

                gp.AddEllipse(new Rectangle(m_Center.X - (linevalue + RadialGauge.MinorTickMarkHeight), m_Center.Y - (linevalue + RadialGauge.MinorTickMarkHeight), 2 * (linevalue + RadialGauge.MinorTickMarkHeight), 2 * (linevalue + RadialGauge.MinorTickMarkHeight)));
                gp.Reverse();
                gp.AddEllipse(new Rectangle(m_Center.X - linevalue, m_Center.Y - linevalue, 2 * linevalue, 2 * linevalue));
                gp.Reverse();
                graphics.SetClip(gp);

                graphics.SetClip(RadialGauge.ClientRectangle);

                if (RadialGauge.ShowScaleLabel)
                {
                    if (this.RadialGauge.TextOrientation != TextOrientation.Horizontal)
                    {
                        graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                        graphics.RotateTransform(90.0F + m_GaugeArcStart + countValue * m_GaugeArcEnd / (RadialGauge.MaximumValue - RadialGauge.MinimumValue));
                    }

                    graphics.TranslateTransform((Single)(m_Center.X + m_ScaleNumbersRadius * Math.Cos((m_GaugeArcStart + countValue * m_GaugeArcEnd / (RadialGauge.MaximumValue - RadialGauge.MinimumValue)) * Math.PI / 180.0f)),
                                           (Single)(m_Center.Y + m_ScaleNumbersRadius * Math.Sin((m_GaugeArcStart + countValue * m_GaugeArcEnd / (RadialGauge.MaximumValue - RadialGauge.MinimumValue)) * Math.PI / 180.0f)),
                                           System.Drawing.Drawing2D.MatrixOrder.Append);



                    graphics.DrawString(valueText, RadialGauge.Font, new SolidBrush(this.RadialGauge.ScaleLabelColor), -boundingBox.Width / 2, -fontBoundY1 - (fontBoundY2 - fontBoundY1 + 1) / 2, StringFormat.GenericTypographic);
                }

                countValue += RadialGauge.MajorDifference;
            }
            Image newImage = Image.FromFile("Fuel.png");
            graphics.DrawImage(newImage, new Point(m_Center.X + 52, m_Center.Y - 85));
        }

        public void DrawCircle(Graphics graphics, Point m_Center, int gaugeRadius, int startAngle, int sweepAngle, float arcThickness, Color arcColor, Color fillColor)
        {
            
        }

        #endregion
    }
}
