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
using System.Windows.Forms;

namespace ProgressBarAdv_CustomRender
{
    /// <summary>
    ///  Represents a class that used for drawing the custom view in ProgressBar.
    /// </summary>
    public class CustomViewRenderer : IProgressBarAdvRenderer,IDisposable
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

        /// <summary>
        /// 
        /// </summary>
        private string m_Animation = "Left to Right";
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

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor of the Renderer class
        /// </summary>
        /// <param name="progressBar">ProgressBarAdv</param>
        /// 
        public CustomViewRenderer(ProgressBarAdv progressBar)
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
            DrawText(paintEventArgs.Graphics, paintEventArgs.ClipRectangle);
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
#if NETCORE
            Image image1 = Image.FromFile("../../../Image/Background.png");
            Image image2 = Image.FromFile("../../../Image/Pointer.png");
#else
            Image image1 = Image.FromFile("../../Image/Background.png");
            Image image2 = Image.FromFile("../../Image/Pointer.png");
#endif
            using (image1)
            {
                g.FillRectangle(new SolidBrush(this.ProgressBackColor), new Rectangle(0, 0, this.m_ProgressBar.Width, this.m_ProgressBar.Height));
            }
            using (image2)
            {
                using (Pen pen = new Pen(this.ProgressBackColor))
                {
                    g.DrawRectangle(pen, 50, m_ProgressBar.Height / 3 + 58, m_ProgressBar.Width - 110, image2.Height / 2);
                }
                using (SolidBrush brush = new SolidBrush(this.ProgressBackColor))
                {
                    g.FillRectangle(brush, 50, m_ProgressBar.Height / 3 + 58, m_ProgressBar.Width - 110, image2.Height / 2);
                }
                g.DrawImage(image2, new Rectangle(40, m_ProgressBar.Height / 3 + 50, image2.Width, image2.Height));
                g.DrawImage(image2, new Rectangle(m_ProgressBar.Width - 70, m_ProgressBar.Height / 3 + 50, image2.Width, image2.Height));
            }
        }
#endregion

#region DrawProcess
        /// <summary>
        /// Draws the foreground of the ProgressBar.
        /// </summary>
        /// <param name="g">The <see cref="Graphics"/> object to draw on.</param>
        /// <param name="clipRectangle">The <see cref="Rectangle"/> to draw in.</param>
        /// <param name="rc">The <see cref="Rectangle"/> used to draw the progress</param>
        public void DrawProgress(Graphics g, Rectangle clipRectangle, Rectangle rc)
        {
#if NETCORE
            Image image = Image.FromFile("../../../Image/Flight_Progress-01.png");
#else
            Image image = Image.FromFile("../../Image/Flight_Progress-01.png");
#endif
            using (image)
            {
#if NETCORE
                Image pointer = Image.FromFile("../../../Image/Pointer.png");
#else
                Image pointer = Image.FromFile("../../Image/Pointer.png");
#endif
                using (pointer)
                {
                    if (this.Animation == "Left to Right")
                    {
                        using (SolidBrush brush = new SolidBrush(this.m_ProgressBar.ForeColor))
                        {
                            g.FillRectangle(brush, rc.X + pointer.Width + 23, m_ProgressBar.Height / 3 + 58, rc.Width, pointer.Height / 2 + 1);
                        }
                        g.DrawImage(image, new Rectangle(rc.Right, (rc.Height / 3 - 2) + 20, 150, 110));
                        g.DrawImage(pointer, new Rectangle(40, m_ProgressBar.Height / 3 + 50, pointer.Width, pointer.Height));
                    }
                    else
                    {
                        ProgressBarAdvDrawEventArgs e = new ProgressBarAdvDrawEventArgs(g, rc);

                        using (SolidBrush brush = new SolidBrush(this.m_ProgressBar.ForeColor))
                        {
                            g.FillRectangle(brush, new Rectangle(m_ProgressBar.Width - 65 - e.Rectangle.Width, m_ProgressBar.Height / 3 + 58, e.Rectangle.Width, pointer.Height / 2 + 1));
                        }
#if NETCORE
                        Image rightImage = Image.FromFile("../../../Image/Flight_Progress-02.png");
#else
                        Image rightImage = Image.FromFile("../../Image/Flight_Progress-02.png");
#endif
                        using (rightImage)
                        {
                            g.DrawImage(rightImage, new Rectangle(m_ProgressBar.Width - 130 - e.Rectangle.Width - 20, (rc.Height / 3 - 2) + 20, 150, 110));
                        }
                        g.DrawImage(pointer, new Rectangle(m_ProgressBar.Width - 70, m_ProgressBar.Height / 3 + 50, pointer.Width, pointer.Height));
                    }
                }
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
            TimeSpan initalTime = new TimeSpan(7, 0, 0);
            using (SolidBrush brush = new SolidBrush(this.m_ProgressBar.ForeColor))
            {
                g.DrawString("NY", new Font("Segoe UI", 15), brush, 45, m_ProgressBar.Height / 3 + 90);
                g.DrawString("AMS", new Font("Segoe UI", 15), brush, m_ProgressBar.Width - 75, m_ProgressBar.Height / 3 + 90);
            }
            using (SolidBrush brush = new SolidBrush(this.m_ProgressBar.ForeColor))
            {
                TimeSpan time = initalTime - TimeSpan.FromHours(initalTime.TotalHours * Value / 70);
                string str = string.Format("{0}", time.Hours) + "h "; // time.ToString(@"hh") + "h ";
                str = str + string.Format("{0}", time.Minutes) + "m"; //str + time.ToString(@"mm") + "m";
                g.DrawString("Travel Time - 6h 5m  /  Rm. Time - " + str, new Font("Segoe UI", 15, FontStyle.Bold, GraphicsUnit.Pixel), brush, m_ProgressBar.Width / 3 - 30, m_ProgressBar.Height / 7);
            }
        }

        public void Dispose()
        {
            if (m_ProgressBar != null)
            {
                m_ProgressBar.Dispose();
                m_ProgressBar = null;
            }
        }
#endregion

#endregion
    }
}
