#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProgressBarAdv_CustomRender
{
    /// <summary>
    /// Represents a class that used for drawing the custom shapes.
    /// </summary>
    public class CustomShapesRenderer : IProgressBarAdvRenderer,IDisposable
    {
        #region Variables
        /// <summary>
        /// Initialize the ProgressBarAdv
        /// </summary>
        private ProgressBarAdv m_ProgressBar;
        /// <summary>
        /// Initialize the ProgressBackColor
        /// </summary>
        private Color m_ProgressBackColor = ColorTranslator.FromHtml("#f7f7f7");

        private string shape = "Radial";

        private string m_Animation = "Left to Right";

        public bool Pause;

        #endregion

        #region Properties

        #region ProgressBarAdv
        /// <summary>
        ///  Gets the ProgressBarAdv
        /// </summary>
        internal ProgressBarAdv ProgressBarAdv
        {
            get
            {
                return m_ProgressBar;
            }
        }
        #endregion

        #region BackGround
        /// <summary>
        /// 
        /// </summary>
        public String BackGround
        {
            get { return shape; }
            set
            {
                shape = value;
                if (value == "PlayPause")
                    m_ProgressBar.MouseClick += ProgressBar_MouseClick;
                m_ProgressBar.Invalidate();
            }
        }
        #endregion

        #region Animation
        /// <summary>
        /// 
        /// </summary>
        public string Animation
        {
            get { return m_Animation; }
            set
            {
                m_Animation = value;
                m_ProgressBar.Invalidate();

            }
        }
        #endregion

        #region ProgressBackColor
        /// <summary>
        /// Specifies the ProgressBackColor
        /// </summary>
        public Color ProgressBackColor
        {
            get
            {
                return m_ProgressBackColor;
            }
            set
            {
                m_ProgressBackColor = value;
            }
        }
        #endregion

        #region Progress Value
        /// <summary>
        /// ProgressBarValue
        /// </summary>
        public float Value
        {
            get
            {
                return this.ProgressBarAdv.Value;
            }
        }
        #endregion

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor of the Renderer class
        /// </summary>
        /// <param name="progressBar">ProgressBarAdv</param>
        public CustomShapesRenderer(ProgressBarAdv progressBar)
        {
            m_ProgressBar = progressBar;
        }
        #endregion

        #region IProgressBarRenderer Members

        #region UpdateRenderer
        /// <summary>
        ///  Update the Renderer.
        /// </summary>
        /// <param name="paintEventArgs">Provides data for the <see cref="ProgressBarAdv"/> Paint event.</param>
        /// <param name="progressRectangle">The <see cref="Rectangle"/> used to draw the progress</param>
        public void UpdateRenderer(PaintEventArgs paintEventArgs, Rectangle progressRectangle)
        {
            DrawBackground(paintEventArgs.Graphics, true);
            DrawProgress(paintEventArgs.Graphics, paintEventArgs.ClipRectangle, progressRectangle);
            DrawBorder(paintEventArgs.Graphics, paintEventArgs.ClipRectangle);
        }
        #endregion

        #region DrawBackground
        /// <summary>
        /// Draws the background of the ProgressBar.
        /// </summary>
        /// <param name="g">The <see cref="Graphics"/> object to draw on.</param>
        /// <param name="segmented">Indicates whether the background is segmented.</param>
        public void DrawBackground(Graphics g, bool segmented)
        {
            using (SolidBrush b = new SolidBrush(this.ProgressBackColor))
            {
               if (this.BackGround == "Rectangle")
                {
                    g.SetClip(new Rectangle(0, 0, m_ProgressBar.Width, m_ProgressBar.Height));
                    g.FillRectangle(b, new Rectangle(0, 0, this.m_ProgressBar.Width, this.m_ProgressBar.Height));
                }
                else if (this.BackGround == "Circle")
                {
                    g.SetClip(new Rectangle(0, 0, m_ProgressBar.Width, m_ProgressBar.Height));
                    g.FillEllipse(b, new Rectangle(0, 0, this.m_ProgressBar.Width, this.m_ProgressBar.Height));
                }
                else if (this.BackGround == "Triangle")
                {
                    g.SetClip(new Rectangle(0, 0, m_ProgressBar.Width, m_ProgressBar.Height));
                    Point point1 = new Point(0, this.m_ProgressBar.Height);
                    Point point2 = new Point(this.m_ProgressBar.Width / 2, 0);
                    Point point3 = new Point(this.m_ProgressBar.Height, this.m_ProgressBar.Width);

                    Point[] curvePoints = { point1, point2, point3 };
                    g.FillPolygon(b, curvePoints);
                }
                else
                {
                    //No Implementation
                }
            }
        }
        #endregion

        #region DrawProcess
        /// <summary>
        /// Draws the foreground of the ProgressBar.
        /// </summary>
        /// <param name="g">The <see cref="Graphics"/> object to draw on.</param>
        /// <param name="ClipRectangle">The <see cref="Rectangle"/> to draw in.</param>
        /// <param name="rc">The <see cref="Rectangle"/> used to draw the progress</param>
        public void DrawProgress(Graphics g, Rectangle clipRectangle, Rectangle rc)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            float width = ((Value / 100) * this.ProgressBarAdv.Width);
            float rtlWidth = this.ProgressBarAdv.Width - ((Value / 100) * this.ProgressBarAdv.Width);

            using (SolidBrush b = new SolidBrush(this.m_ProgressBar.ForeColor))
            {
                if (this.BackGround == "Radial")
                {
                    var outerRect = new Rectangle(5, 5, m_ProgressBar.Width - 10, m_ProgressBar.Height - 10);
                    var centre = m_ProgressBar.Width / 2;
                    var innerPieX = (centre * 25) / 100;

                        using (SolidBrush brush = new SolidBrush(this.ProgressBackColor))
                        {
                            g.FillPie(brush, outerRect, 0, 360);
                        }

                        //To draw the progress
                        g.FillPie(b, outerRect, -90, this.Animation == "Left to Right" ? m_ProgressBar.Value * (3.6f) : m_ProgressBar.Value * (-3.6f));

                        using (SolidBrush brush = new SolidBrush(this.ProgressBackColor))
                        {
                            g.FillEllipse(brush, new Rectangle(outerRect.X + 5, outerRect.Y + 5, m_ProgressBar.Width - (2 * outerRect.X + 10), m_ProgressBar.Height - (2 * outerRect.Y + 10)));
                        }
                        using (SolidBrush brush = new SolidBrush(this.m_ProgressBar.ForeColor))
                        {
                            string text = m_ProgressBar.Value.ToString() + "%";
                            Font font = new Font(m_ProgressBar.Font.FontFamily, m_ProgressBar.Font.Size);
                            g.DrawString(text, font, brush, new PointF(m_ProgressBar.Width / 2f - this.m_ProgressBar.Font.Size,
                                    m_ProgressBar.Height / 2f - this.m_ProgressBar.Font.Size));
                        }
                }               
                else if (this.BackGround == "Disc")
                {
                    var outerRect = new Rectangle(5, 5, m_ProgressBar.Width - 10, m_ProgressBar.Height - 10);
                    var innerRect = new Rectangle(10, 10, m_ProgressBar.Width - 20, m_ProgressBar.Height - 20);
                    using (SolidBrush brush = new SolidBrush(this.ProgressBackColor))
                    {
                        g.FillPie(brush, outerRect, 0, 360);
                    }

                    //To draw the progress
                    g.FillPie(b, innerRect, -90, this.Animation == "Left to Right" ? m_ProgressBar.Value * (3.6f) : m_ProgressBar.Value * (-3.6f));

                }
                else if (this.BackGround == "Segments")
                {
                    var outerRect = new Rectangle(5, 5, m_ProgressBar.Width - 10, m_ProgressBar.Height - 10);
                    g.SetClip(new Rectangle(0, 0, m_ProgressBar.Width, m_ProgressBar.Height));
                    using (SolidBrush brush = new SolidBrush(this.ProgressBackColor))
                    {
                        g.FillPie(brush, outerRect, 0, 360);
                    }

                    //To draw the progress
                    g.FillPie(b, outerRect, -90, this.Animation == "Left to Right" ? m_ProgressBar.Value * (3.6f) : m_ProgressBar.Value * (-3.6f));

                    using (SolidBrush brush = new SolidBrush(this.ProgressBackColor))
                    {
                        g.FillEllipse(brush, new Rectangle(outerRect.X + 5, outerRect.Y + 5, m_ProgressBar.Width - (2 * outerRect.X + 10), m_ProgressBar.Height - (2 * outerRect.Y + 10)));
                        g.FillRectangle(brush, new RectangleF(5, (this.m_ProgressBar.Height / 2) - 2, this.m_ProgressBar.Width - 10, 4));
                        g.FillRectangle(brush, new RectangleF(this.m_ProgressBar.Width / 2 - 2, 5, 4, this.m_ProgressBar.Height - 10));
                    }
                    using (SolidBrush brush = new SolidBrush(this.m_ProgressBar.ForeColor))
                    {
                        string text = m_ProgressBar.Value.ToString() + "%";
                        Font font = new Font(m_ProgressBar.Font.FontFamily, m_ProgressBar.Font.Size);
                        g.DrawString(text, font, brush, new PointF(m_ProgressBar.Width / 2f - this.m_ProgressBar.Font.Size,
                                m_ProgressBar.Height / 2f - this.m_ProgressBar.Font.Size));
                    }
                }
                else if (this.BackGround == "InlineSegments")
                {
                    var outerRect = new Rectangle(5, 5, m_ProgressBar.Width - 10, m_ProgressBar.Height - 10);

                    var innerRectX = (m_ProgressBar.Width / 2 * 30) / 100;
                    var innerRect = new Rectangle(innerRectX, innerRectX, m_ProgressBar.Width - (2 * innerRectX), m_ProgressBar.Height - (2 * innerRectX));

                    var progressRectX = (m_ProgressBar.Width / 2 * 15) / 100;
                    var progressRect = new Rectangle(progressRectX, progressRectX, m_ProgressBar.Width - (2 * progressRectX), m_ProgressBar.Height - (2 * progressRectX));

                    var backGroundRectX = (m_ProgressBar.Width / 2 * 20) / 100;
                    var backGroundRect = new Rectangle(backGroundRectX, backGroundRectX, m_ProgressBar.Width - (2 * backGroundRectX), m_ProgressBar.Height - (2 * backGroundRectX));
                    g.SetClip(new Rectangle(0, 0, m_ProgressBar.Width, m_ProgressBar.Height));
                    using (SolidBrush brush = new SolidBrush(this.ProgressBackColor))
                    {
                        g.FillPie(brush, outerRect, 0, 360);
                    }

                    //To draw the progress
                    g.FillPie(b, progressRect, -90, this.Animation == "Left to Right" ? m_ProgressBar.Value * (3.6f) : m_ProgressBar.Value * (-3.6f));

                    using (SolidBrush brush = new SolidBrush(this.ProgressBackColor))
                    {
                        g.FillEllipse(brush, backGroundRect);
                    }

                    using (SolidBrush brush = new SolidBrush(Color.White))
                    {
                        g.FillEllipse(brush, innerRect);
                        g.FillRectangle(brush, new RectangleF(5, (this.m_ProgressBar.Height / 2) - 2, this.m_ProgressBar.Width - 10, 4));
                        g.FillRectangle(brush, new RectangleF(this.m_ProgressBar.Width / 2 - 2, 5, 4, this.m_ProgressBar.Height - 10));
                    }
                    using (SolidBrush brush = new SolidBrush(this.m_ProgressBar.ForeColor))
                    {
                        string text = m_ProgressBar.Value.ToString() + "%";
                        Font font = new Font(m_ProgressBar.Font.FontFamily, m_ProgressBar.Font.Size);
                        g.DrawString(text, font, brush, new PointF(m_ProgressBar.Width / 2f - this.m_ProgressBar.Font.Size,
                                m_ProgressBar.Height / 2f - this.m_ProgressBar.Font.Size));
                    }
                }
                else if (this.BackGround == "MultipleSegments")
                {
                    var outerRect = new Rectangle(5, 5, m_ProgressBar.Width - 10, m_ProgressBar.Height - 10);
                    var innerRectX = (m_ProgressBar.Width / 2 * 30) / 100;
                    var innerRect = new Rectangle(innerRectX, innerRectX, m_ProgressBar.Width - (2 * innerRectX), m_ProgressBar.Height - (2 * innerRectX));
                    g.SetClip(new Rectangle(0, 0, m_ProgressBar.Width, m_ProgressBar.Height));

                    GraphicsPath path = new GraphicsPath();
                    path.AddEllipse(new Rectangle(outerRect.X - 1, outerRect.Y - 1, outerRect.Width + 2, outerRect.Height + 2));
                    g.SetClip(path);

                    using (SolidBrush brush = new SolidBrush(this.ProgressBackColor))
                    {
                        g.FillPie(brush, outerRect, 0, 360);
                    }

                    //To draw the progress
                    g.FillPie(b, outerRect, -90, this.Animation == "Left to Right" ? m_ProgressBar.Value * (3.6f) : m_ProgressBar.Value * (-3.6f));

                    using (SolidBrush brush = new SolidBrush(this.ProgressBackColor))
                    {
                        var center = outerRect.Width / 2;
                        g.FillEllipse(brush, new Rectangle(outerRect.X + 5, outerRect.Y + 5, m_ProgressBar.Width - (2 * outerRect.X + 10), m_ProgressBar.Height - (2 * outerRect.Y + 10)));
                        g.FillRectangle(brush, new RectangleF(5, (this.m_ProgressBar.Height / 2) - 2, this.m_ProgressBar.Width - 10, 4));
                        g.FillRectangle(brush, new RectangleF(this.m_ProgressBar.Width / 2 - 2, 5, 4, this.m_ProgressBar.Height - 10));
                        g.DrawLine(new Pen(brush, 4f), new Point(outerRect.Top, outerRect.Left), new Point(outerRect.Bottom, outerRect.Right));
                        g.DrawLine(new Pen(brush, 4f), new Point(outerRect.Top, outerRect.Right), new Point(outerRect.Bottom, outerRect.Left));
                    }
                    using (SolidBrush brush = new SolidBrush(this.m_ProgressBar.ForeColor))
                    {
                        string text = m_ProgressBar.Value.ToString() + "%";
                        Font font = new Font(m_ProgressBar.Font.FontFamily, m_ProgressBar.Font.Size);
                        g.DrawString(text, font, brush, new PointF(m_ProgressBar.Width / 2f - this.m_ProgressBar.Font.Size,
                                m_ProgressBar.Height / 2f - this.m_ProgressBar.Font.Size));
                    }
                }
                else if (this.BackGround == "PlayPause")
                {
                    var outerRect = new Rectangle(5, 5, m_ProgressBar.Width - 10, m_ProgressBar.Height - 10);
                    var centre = m_ProgressBar.Width / 2;
                    var innerPieX = (centre * 25) / 100;

                    using (SolidBrush brush = new SolidBrush(this.ProgressBackColor))
                    {
                        g.FillPie(brush, outerRect, 0, 360);
                    }

                    //To draw the progress
                    g.FillPie(b, outerRect, -90, this.Animation == "Left to Right" ? m_ProgressBar.Value * (3.6f) : m_ProgressBar.Value * (-3.6f));

                    using (SolidBrush brush = new SolidBrush(this.ProgressBackColor))
                    {
                        g.FillEllipse(brush, new Rectangle(outerRect.X + 5, outerRect.Y + 5, m_ProgressBar.Width - (2 * outerRect.X + 10), m_ProgressBar.Height - (2 * outerRect.Y + 10)));
                    }
                    using (SolidBrush brush = new SolidBrush(this.m_ProgressBar.ForeColor))
                    {
                        var playPauseRect = new Rectangle(m_ProgressBar.Width / 2 - 8, m_ProgressBar.Height / 2 - 8, 16, 16);

                        if (Pause)
                        {
                            Point point1 = new Point(playPauseRect.X,playPauseRect.Y);
                            Point point2 = new Point(playPauseRect.X + playPauseRect.Width, playPauseRect.Y + playPauseRect.Height / 2);
                            Point point3 = new Point(playPauseRect.X, playPauseRect.Y + playPauseRect.Height);

                            Point[] curvePoints = { point1, point2, point3 };
                            g.FillPolygon(b, curvePoints);
                        }
                        else
                        {
                            g.FillRectangle(b, new Rectangle(playPauseRect.X, playPauseRect.Y, 5, playPauseRect.Height));
                            g.FillRectangle(b, new Rectangle(playPauseRect.Right-5, playPauseRect.Y, 5, playPauseRect.Height));
                        }
                    }
                }
                else
                {
                    if (this.Animation == "Left to Right")
                    {
                        g.SetClip(new Rectangle(0, 0, (int)width, m_ProgressBar.Height));
                        g.FillRectangle(b, new Rectangle(0, 0, this.m_ProgressBar.Width, this.m_ProgressBar.Height));
                    }
                    else
                    {
                        g.SetClip(new Rectangle((int)rtlWidth, 0, this.ProgressBarAdv.Width, m_ProgressBar.Height));
                        g.FillRectangle(b, new Rectangle(0, 0, this.m_ProgressBar.Width, this.m_ProgressBar.Height));
                    }
                }
            }
        }

        private void ProgressBar_MouseClick(object sender, MouseEventArgs e)
        {
            var playPauseRect = new Rectangle(m_ProgressBar.Width / 2 - 30, m_ProgressBar.Height / 2 - 30, 60, 60);

            if (playPauseRect.Contains(e.Location))
            {
                this.Pause = !this.Pause;
                this.m_ProgressBar.Invalidate();
            }
        }

        #endregion

        #region DrawBorder
        /// <summary>
        /// Draws the border of the ProgressBar.
        /// </summary>
        /// <param name="g"><see cref="Graphics"/></param>
        /// <param name="rc">The <see cref="Rectangle"/> of the border.</param>
        public void DrawBorder(Graphics g, Rectangle rc)
        {
            //No implementation.
        }
        #endregion

        #region DrawText
        /// <summary>
        /// Draws the specified text string at the specified location.
        /// </summary>
        /// <param name="g">The <see cref="Graphics"/> object to draw on.</param>
        /// <param name="rect">The <see cref="Rectangle"/> of the ProgressBarAdv</param>
        public void DrawText(Graphics g, Rectangle rect)
        {
            //No implementation.
        }
        

        public void Dispose()
        {
            if (m_ProgressBar != null)
            {
                m_ProgressBar.MouseClick -= ProgressBar_MouseClick;
                m_ProgressBar.Dispose();
                m_ProgressBar = null;
            }
        }
        #endregion

        #endregion
    }
}
