using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using System.Drawing.Drawing2D;
using Syncfusion.Windows.Forms.Tools;
using System.IO;

namespace ProgressBarAdv_CustomRender
{
    #region MainForm
    public partial class Form1 : MetroForm
    {
        #region Variables
        /// <summary>
        /// Initialize the timer
        /// </summary>
        bool Start = true;
        #endregion

        #region Constructor
        public Form1()
        {
            InitializeComponent();
            this.xpTaskBar1.BackColor = ColorTranslator.FromHtml("#f7f7f7");
            this.xpTaskBar1.BorderColor = ColorTranslator.FromHtml("#e6e6e6");
            this.timer1.Tick += new EventHandler(timer1_Tick);

            //To specify the ProgressBar Style
            this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Custom;
            //Specify the custom renderer.
            this.progressBarAdv1.Renderer = new CustomRender2(this.progressBarAdv1);
            this.progressBarAdv1.ForeColor = ColorTranslator.FromHtml("#26a59a");

            this.progressBarAdv3.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Custom;
            this.progressBarAdv3.Renderer = new CustomRender3(this.progressBarAdv3);
            this.MinimumSize = new Size(1020, 519);
            this.timer1.Interval = 100;
            this.progressBarAdv3.Value = 10;
        }

        #endregion

        #region Events

        /// <summary>
        /// Tick event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void timer1_Tick(object sender, EventArgs e)
        {
            if (Start)
            {
                if (this.progressBarAdv1.Value < 100)
                    this.progressBarAdv1.Value += 3;
                else
                    progressBarAdv1.Value = 0;
            }
            if (Start)
            {
                if (this.progressBarAdv3.Value < 70)
                    this.progressBarAdv3.Value += 1;
                else
                {
                    progressBarAdv3.Value = 10;
                    if ((this.progressBarAdv3.Renderer as CustomRender3).Animation == "Left to Right")
                        (this.progressBarAdv3.Renderer as CustomRender3).Animation = "Right to Left";
                    else
                        (this.progressBarAdv3.Renderer as CustomRender3).Animation = "Left to Right";
                }
            }
        }

        /// <summary>
        /// Start the timer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            Start = true;
        }

        /// <summary>
        /// Stop the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            Start = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxAdv1.SelectedIndex == 0)
            {
                if ((this.progressBarAdv1.Renderer as CustomRender2) != null)
                    (this.progressBarAdv1.Renderer as CustomRender2).BackGround = "Radial";
            }
            else if (this.comboBoxAdv1.SelectedIndex == 1)
            {
                if ((this.progressBarAdv1.Renderer as CustomRender2) != null)
                    (this.progressBarAdv1.Renderer as CustomRender2).BackGround = "Rectangle";
            }
            else if (this.comboBoxAdv1.SelectedIndex == 2)
            {
                if ((this.progressBarAdv1.Renderer as CustomRender2) != null)
                    (this.progressBarAdv1.Renderer as CustomRender2).BackGround = "Circle";
            }
            else
            {
                if ((this.progressBarAdv1.Renderer as CustomRender2) != null)
                    (this.progressBarAdv1.Renderer as CustomRender2).BackGround = "Triangle";
            }
            this.progressBarAdv1.Invalidate();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            this.progressBarAdv1.ForeColor = this.colorPickerButton1.SelectedColor;
            this.colorPickerButton1.MetroColor = this.colorPickerButton1.SelectedColor;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colorPickerButton2_ColorSelected(object sender, EventArgs e)
        {
            if ((this.progressBarAdv1.Renderer as CustomRender2) != null)
                (this.progressBarAdv1.Renderer as CustomRender2).ProgressBackColor = this.colorPickerButton2.SelectedColor;
            this.colorPickerButton2.MetroColor = this.colorPickerButton2.SelectedColor;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxAdv2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxAdv2.SelectedIndex == 0)
            {
                if ((this.progressBarAdv1.Renderer as CustomRender2) != null)
                {
                    (this.progressBarAdv1.Renderer as CustomRender2).BackGround = (this.progressBarAdv1.Renderer as CustomRender2).BackGround;
                    (this.progressBarAdv1.Renderer as CustomRender2).Animation = "Left to Right";
                }

                if ((this.progressBarAdv3.Renderer as CustomRender3) != null)
                {
                    (this.progressBarAdv3.Renderer as CustomRender3).Animation = "Left to Right";
                }
            }
            else if (this.comboBoxAdv2.SelectedIndex == 1)
            {
                if ((this.progressBarAdv1.Renderer as CustomRender2) != null)
                {
                    (this.progressBarAdv1.Renderer as CustomRender2).BackGround = (this.progressBarAdv1.Renderer as CustomRender2).BackGround;
                    (this.progressBarAdv1.Renderer as CustomRender2).Animation = "Right to Left";
                }

                if ((this.progressBarAdv3.Renderer as CustomRender3) != null)
                {
                    (this.progressBarAdv3.Renderer as CustomRender3).Animation = "Right to Left";
                }
            }
            this.progressBarAdv1.Invalidate();
            this.progressBarAdv3.Invalidate();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControlAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.progressBarAdv1.Location = new Point(((this.tabPageAdv1.Width - xpTaskBar1.Width) - this.progressBarAdv1.Width) / 2, (this.tabPageAdv1.Height - this.progressBarAdv1.Height) / 2);
            this.progressBarAdv3.Location = new Point(((this.Width - xpTaskBar1.Width) - this.progressBarAdv3.Width) / 2 - 8, (this.tabPageAdv3.Height - this.progressBarAdv3.Height) / 2);

            if (this.tabControlAdv1.SelectedIndex == 1 || this.tabControlAdv1.SelectedIndex == 2)
                this.xpTaskBarBox1.Visible = false;
            else
                this.xpTaskBarBox1.Visible = true;
        }

        /// <summary>
        /// Occurs when Form size changing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Resize(object sender, EventArgs e)
        {
            this.progressBarAdv1.Location = new Point(((this.tabPageAdv1.Width - xpTaskBar1.Width) - this.progressBarAdv1.Width) / 2, (this.tabPageAdv1.Height - this.progressBarAdv1.Height) / 2);
            this.progressBarAdv3.Location = new Point(((this.Width - xpTaskBar1.Width) - this.progressBarAdv3.Width) / 2 - 8, (this.tabPageAdv3.Height - this.progressBarAdv3.Height) / 2);
        }

        /// <summary>
        /// Form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(new Bitmap(10, 10)))
            {
                if (g.DpiX > 96 && g.DpiX <= 120)
                {
                    this.xpTaskBar1.Size = new Size(300, this.xpTaskBar1.Height);
                    this.label1.Location = new Point(5, 15);
                    this.comboBoxAdv1.Location = new Point(5, this.comboBoxAdv1.Location.Y);
                    this.label2.Location = new Point(5, 110);
                    this.label3.Location = new Point(150, 110);
                    this.colorPickerButton1.Location = new System.Drawing.Point(112, 111);
                    this.colorPickerButton2.Location = new Point(255, 111);
                    this.label4.Location = new System.Drawing.Point(5, 15);
                    this.comboBoxAdv2.Location = new System.Drawing.Point(5, 52);
                    this.buttonAdv1.Location = new System.Drawing.Point(5, 97);
                    this.buttonAdv2.Location = new System.Drawing.Point(152, 97);
                }
            }
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.progressBarAdv1.Location = new Point(((this.tabPageAdv1.Width - xpTaskBar1.Width) - this.progressBarAdv1.Width) / 2, (this.tabPageAdv1.Height - this.progressBarAdv1.Height) / 2);
                this.progressBarAdv3.Location = new Point(((this.Width - xpTaskBar1.Width) - this.progressBarAdv3.Width) / 2, (this.tabPageAdv3.Height) / 2);
            }
        }
        #endregion
    }
    #endregion

    #region Custom Render class 2
    /// <summary>
    /// Custom Renderer class
    /// </summary>
    public class CustomRender2 : IProgressBarAdvRenderer
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
        private string shape = "Radial";

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
        public CustomRender2(ProgressBarAdv progressBar)
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
                if (this.BackGround == "Radial")
                {
                    //No Implementation.
                }
                else if (this.BackGround == "Rectangle")
                {
                    g.SetClip(new Rectangle(0, 0, m_ProgressBar.Width, m_ProgressBar.Height));
                    g.FillRectangle(b, new Rectangle(0, 0, this.m_ProgressBar.Width, this.m_ProgressBar.Height));
                }
                else if (this.BackGround == "Circle")
                {
                    g.SetClip(new Rectangle(0, 0, m_ProgressBar.Width, m_ProgressBar.Height));
                    g.FillEllipse(b, new Rectangle(0, 0, this.m_ProgressBar.Width, this.m_ProgressBar.Height));
                }
                else
                {
                    g.SetClip(new Rectangle(0, 0, m_ProgressBar.Width, m_ProgressBar.Height));
                    Point point1 = new Point(0, this.m_ProgressBar.Height);
                    Point point2 = new Point(this.m_ProgressBar.Width / 2, 0);
                    Point point3 = new Point(this.m_ProgressBar.Height, this.m_ProgressBar.Width);

                    Point[] curvePoints = { point1, point2, point3 };
                    g.FillPolygon(b, curvePoints);
                }
            }
        }
        #endregion

        #region DrawProcess
        bool is125Scaling = false;
        /// <summary>
        /// Draws the foreground of the ProgressBar.
        /// </summary>
        /// <param name="g">The <see cref="Graphics"/> object to draw on.</param>
        /// <param name="ClipRectangle">The <see cref="Rectangle"/> to draw in.</param>
        /// <param name="rc">The <see cref="Rectangle"/> used to draw the progress</param>
        public void DrawProgress(Graphics g, Rectangle clipRectangle, Rectangle rc)
        {
            is125Scaling = g.DpiX > 96 && g.DpiX <= 120;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            float width = ((Value / 100) * this.ProgressBarAdv.Width);
            float rtlWidth = this.ProgressBarAdv.Width - ((Value / 100) * this.ProgressBarAdv.Width);

            using (SolidBrush b = new SolidBrush(this.m_ProgressBar.ForeColor))
            {
                if (this.BackGround == "Radial")
                {
                    if (this.Animation == "Left to Right")
                    {
                        if (is125Scaling)
                        {
                            using (SolidBrush brush = new SolidBrush(this.ProgressBackColor))
                            {
                                g.FillPie(brush, new Rectangle(10, 10, m_ProgressBar.Width - 20, m_ProgressBar.Height - 20), 0, 360);
                            }
                            using (Pen pen = new Pen(ColorTranslator.FromHtml("#e6e6e6"), 3f))
                            {
                                g.DrawEllipse(pen, new Rectangle(m_ProgressBar.Width / 2 - (m_ProgressBar.Font.Height + 74), m_ProgressBar.Height / 2 - (m_ProgressBar.Font.Height + 74),
                                   m_ProgressBar.Font.Height + 180, m_ProgressBar.Font.Height + 180));
                            }

                            //To draw the progress
                            g.FillPie(b, new Rectangle(m_ProgressBar.Width / 2 - (m_ProgressBar.Font.Height + 79), m_ProgressBar.Height / 2 - (m_ProgressBar.Font.Height + 79),
                                   m_ProgressBar.Font.Height + 190, m_ProgressBar.Font.Height + 190), 0, m_ProgressBar.Value * (3.6f));

                            using (SolidBrush brush = new SolidBrush(Color.White))
                            {
                                g.FillEllipse(brush, new Rectangle(m_ProgressBar.Width / 2 - (m_ProgressBar.Font.Height + 72), m_ProgressBar.Height / 2 - (m_ProgressBar.Font.Height + 72),
                                    m_ProgressBar.Font.Height + 176, m_ProgressBar.Font.Height + 176));
                            }
                            using (Pen pen = new Pen(ColorTranslator.FromHtml("#e6e6e6"), 3f))
                            {
                                g.DrawEllipse(pen, new Rectangle(10, 10, m_ProgressBar.Width - 20, m_ProgressBar.Height - 20));
                            }
                            using (SolidBrush brush = new SolidBrush(this.m_ProgressBar.ForeColor))
                            {
                                string text = m_ProgressBar.Value.ToString() + "%";
                                Font font = new Font(m_ProgressBar.Font.FontFamily, 25f);
                                g.DrawString(text, font, brush, new PointF(m_ProgressBar.Width / 2f - this.m_ProgressBar.Font.Height - 10,
                                        m_ProgressBar.Height / 2f - this.m_ProgressBar.Font.Height));
                            }
                        }
                        else
                        {
                            using (SolidBrush brush = new SolidBrush(this.ProgressBackColor))
                            {
                                g.FillPie(brush, new Rectangle(10, 10, m_ProgressBar.Width - 20, m_ProgressBar.Height - 20), 0, 360);
                            }
                            using (Pen pen = new Pen(ColorTranslator.FromHtml("#e6e6e6"), 3f))
                            {
                                g.DrawEllipse(pen, new Rectangle(m_ProgressBar.Width / 2 - (m_ProgressBar.Font.Height + 80), m_ProgressBar.Height / 2 - (m_ProgressBar.Font.Height + 80),
                                   m_ProgressBar.Font.Height + 186, m_ProgressBar.Font.Height + 186));
                            }

                            //To draw the progress
                            g.FillPie(b, new Rectangle(30, 30, m_ProgressBar.Width - 60, m_ProgressBar.Height - 60), 0, m_ProgressBar.Value * (3.6f));

                            using (SolidBrush brush = new SolidBrush(Color.White))
                            {
                                g.FillEllipse(brush, new Rectangle(m_ProgressBar.Width / 2 - (m_ProgressBar.Font.Height + 80),
                                        m_ProgressBar.Height / 2 - (m_ProgressBar.Font.Height + 80), m_ProgressBar.Font.Height + 186, m_ProgressBar.Font.Height + 186));
                            }
                            using (Pen pen = new Pen(ColorTranslator.FromHtml("#e6e6e6"), 3f))
                            {
                                g.DrawEllipse(pen, new Rectangle(10, 10, m_ProgressBar.Width - 20, m_ProgressBar.Height - 20));
                            }
                            using (SolidBrush brush = new SolidBrush(this.m_ProgressBar.ForeColor))
                            {
                                string text = m_ProgressBar.Value.ToString() + "%";
                                Font font = new Font(m_ProgressBar.Font.FontFamily, 25f);
                                g.DrawString(text, font, brush, new PointF(m_ProgressBar.Width / 2f - this.m_ProgressBar.Font.Height,
                                        m_ProgressBar.Height / 2f - this.m_ProgressBar.Font.Height));
                            }
                        }
                    }
                    else
                    {
                        if (is125Scaling)
                        {
                            using (SolidBrush brush = new SolidBrush(this.ProgressBackColor))
                            {
                                g.FillPie(brush, new Rectangle(10, 10, m_ProgressBar.Width - 20, m_ProgressBar.Height - 20), 0, 360);
                            }
                            using (Pen pen = new Pen(ColorTranslator.FromHtml("#e6e6e6"), 3f))
                            {
                                g.DrawEllipse(pen, new Rectangle(m_ProgressBar.Width / 2 - (m_ProgressBar.Font.Height + 74), m_ProgressBar.Height / 2 - (m_ProgressBar.Font.Height + 74),
                                   m_ProgressBar.Font.Height + 180, m_ProgressBar.Font.Height + 180));
                            }

                            //To draw the progress
                            g.FillPie(b, new Rectangle(m_ProgressBar.Width / 2 - (m_ProgressBar.Font.Height + 79), m_ProgressBar.Height / 2 - (m_ProgressBar.Font.Height + 79),
                                   m_ProgressBar.Font.Height + 190, m_ProgressBar.Font.Height + 190), 0, m_ProgressBar.Value * (-3.6f));

                            using (SolidBrush brush = new SolidBrush(Color.White))
                            {
                                g.FillEllipse(brush, new Rectangle(m_ProgressBar.Width / 2 - (m_ProgressBar.Font.Height + 72), m_ProgressBar.Height / 2 - (m_ProgressBar.Font.Height + 72),
                                    m_ProgressBar.Font.Height + 176, m_ProgressBar.Font.Height + 176));
                            }
                            using (Pen pen = new Pen(ColorTranslator.FromHtml("#e6e6e6"), 3f))
                            {
                                g.DrawEllipse(pen, new Rectangle(10, 10, m_ProgressBar.Width - 20, m_ProgressBar.Height - 20));
                            }
                            using (SolidBrush brush = new SolidBrush(this.m_ProgressBar.ForeColor))
                            {
                                string text = m_ProgressBar.Value.ToString() + "%";
                                Font font = new Font(m_ProgressBar.Font.FontFamily, 25f);
                                g.DrawString(text, font, brush, new PointF(m_ProgressBar.Width / 2f - this.m_ProgressBar.Font.Height - 10,
                                        m_ProgressBar.Height / 2f - this.m_ProgressBar.Font.Height));
                            }
                        }
                        else
                        {
                            using (SolidBrush brush = new SolidBrush(this.ProgressBackColor))
                            {
                                g.FillPie(brush, new Rectangle(10, 10, m_ProgressBar.Width - 20, m_ProgressBar.Height - 20), 0, 360);
                            }
                            using (Pen pen = new Pen(ColorTranslator.FromHtml("#e6e6e6"), 3f))
                            {
                                g.DrawEllipse(pen, new Rectangle(m_ProgressBar.Width / 2 - (m_ProgressBar.Font.Height + 80), m_ProgressBar.Height / 2 - (m_ProgressBar.Font.Height + 80),
                                   m_ProgressBar.Font.Height + 186, m_ProgressBar.Font.Height + 186));
                            }

                            //To draw the progress
                            g.FillPie(b, new Rectangle(30, 30, m_ProgressBar.Width - 60, m_ProgressBar.Height - 60), 0, (m_ProgressBar.Value * (-3.6f)));

                            using (SolidBrush brush = new SolidBrush(Color.White))
                            {
                                g.FillEllipse(brush, new Rectangle(m_ProgressBar.Width / 2 - (m_ProgressBar.Font.Height + 80),
                                        m_ProgressBar.Height / 2 - (m_ProgressBar.Font.Height + 80), m_ProgressBar.Font.Height + 186, m_ProgressBar.Font.Height + 186));
                            }
                            using (Pen pen = new Pen(ColorTranslator.FromHtml("#e6e6e6"), 3f))
                            {
                                g.DrawEllipse(pen, new Rectangle(10, 10, m_ProgressBar.Width - 20, m_ProgressBar.Height - 20));
                            }
                            using (SolidBrush brush = new SolidBrush(this.m_ProgressBar.ForeColor))
                            {
                                string text = m_ProgressBar.Value.ToString() + "%";
                                Font font = new Font(m_ProgressBar.Font.FontFamily, 25f);
                                g.DrawString(text, font, brush, new PointF(m_ProgressBar.Width / 2f - this.m_ProgressBar.Font.Height,
                                        m_ProgressBar.Height / 2f - this.m_ProgressBar.Font.Height));
                            }
                        }
                    }
                }
                else if (this.BackGround == "Rectangle")
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

                else if (this.BackGround == "Circle")
                {
                    if (this.Animation == "Left to Right")
                    {
                        g.SetClip(new Rectangle(0, 0, (int)width, m_ProgressBar.Height));

                        g.FillEllipse(b, new Rectangle(0, 0, this.m_ProgressBar.Width, this.m_ProgressBar.Height));
                        using (Pen pen = new Pen(b))
                        {
                            g.DrawEllipse(pen, new Rectangle(0, 0, this.m_ProgressBar.Width, this.m_ProgressBar.Height));
                        }
                    }
                    else
                    {
                        g.SetClip(new Rectangle((int)rtlWidth, 0, this.ProgressBarAdv.Width, m_ProgressBar.Height));
                        g.FillEllipse(b, new Rectangle(0, 0, this.m_ProgressBar.Width, this.m_ProgressBar.Height));
                        using (Pen pen = new Pen(b))
                        {
                            g.DrawEllipse(pen, new Rectangle(0, 0, this.m_ProgressBar.Width, this.m_ProgressBar.Height));
                        }
                    }
                }
                else if (this.BackGround == "Triangle")
                {
                    if (this.Animation == "Left to Right")
                    {
                        g.SetClip(new Rectangle(0, 0, (int)width, m_ProgressBar.Height));
                        Point point1 = new Point(0, this.m_ProgressBar.Height);
                        Point point2 = new Point(this.m_ProgressBar.Width / 2, 0);
                        Point point3 = new Point(this.m_ProgressBar.Height, this.m_ProgressBar.Width);

                        Point[] curvePoints = { point1, point2, point3 };
                        g.FillPolygon(b, curvePoints);
                    }
                    else
                    {
                        g.SetClip(new Rectangle((int)rtlWidth, 0, this.ProgressBarAdv.Width, m_ProgressBar.Height));
                        Point point1 = new Point(0, this.m_ProgressBar.Height);
                        Point point2 = new Point(this.m_ProgressBar.Width / 2, 0);
                        Point point3 = new Point(this.m_ProgressBar.Height, this.m_ProgressBar.Width);

                        Point[] curvePoints = { point1, point2, point3 };
                        g.FillPolygon(b, curvePoints);
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
        #endregion

        #endregion
    }
    #endregion
    
    #region Custom Render class 3
    /// <summary>
    /// Custom Renderer class
    /// </summary>
    public class CustomRender3 : IProgressBarAdvRenderer
    {
        #region Variables
        /// <summary>
        /// Initialize the ProgressBarAdv
        /// </summary>
        private ProgressBarAdv m_ProgressBar;

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
        public CustomRender3(ProgressBarAdv progressBar)
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
            using (Image image = Image.FromFile("../../Image/Background.png"))
            {
                g.DrawImage(image, new Rectangle(0, 0, this.m_ProgressBar.Width, this.m_ProgressBar.Height));
            }
            using (Image image = Image.FromFile("../../Image/Pointer.png"))
            {
                using (Pen pen = new Pen(ColorTranslator.FromHtml("#e8e8e8")))
                {
                    g.DrawRectangle(pen, 50, m_ProgressBar.Height / 3 + 58, m_ProgressBar.Width - 110, image.Height / 2);
                }
                using (SolidBrush brush = new SolidBrush(ColorTranslator.FromHtml("#e8e8e8")))
                {
                    g.FillRectangle(brush, 50, m_ProgressBar.Height / 3 + 58, m_ProgressBar.Width - 110, image.Height / 2);
                }
                g.DrawImage(image, new Rectangle(40, m_ProgressBar.Height / 3 + 50, image.Width, image.Height));
                g.DrawImage(image, new Rectangle(m_ProgressBar.Width - 70, m_ProgressBar.Height / 3 + 50, image.Width, image.Height));
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
            using (Image image = Image.FromFile("../../Image/Flight_Progress-01.png"))
            {
                using (Image pointer = Image.FromFile("../../Image/Pointer.png"))
                {
                    if (this.Animation == "Left to Right")
                    {
                        using (SolidBrush brush = new SolidBrush(ColorTranslator.FromHtml("#35527c")))
                        {
                            g.FillRectangle(brush, rc.X + pointer.Width + 23, m_ProgressBar.Height / 3 + 58, rc.Width, pointer.Height / 2 + 1);
                        }
                        g.DrawImage(image, new Rectangle(rc.Right, (rc.Height / 3 - 2) + 20, 150, 110));
                        g.DrawImage(pointer, new Rectangle(40, m_ProgressBar.Height / 3 + 50, pointer.Width, pointer.Height));
                    }
                    else
                    {
                        ProgressBarAdvDrawEventArgs e = new ProgressBarAdvDrawEventArgs(g, rc);

                        using (SolidBrush brush = new SolidBrush(ColorTranslator.FromHtml("#35527c")))
                        {
                            g.FillRectangle(brush, new Rectangle(m_ProgressBar.Width - 65 - e.Rectangle.Width, m_ProgressBar.Height / 3 + 58, e.Rectangle.Width, pointer.Height / 2 + 1));
                        }
                        using (Image rightImage = Image.FromFile("../../Image/Flight_Progress-02.png"))
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
            using (SolidBrush brush = new SolidBrush(Color.Black))
            {
                g.DrawString("NY", new Font("Segoe UI", 15), brush, 45, m_ProgressBar.Height / 3 + 90);
                g.DrawString("AMS", new Font("Segoe UI", 15), brush, m_ProgressBar.Width - 75, m_ProgressBar.Height / 3 + 90);
            }
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                TimeSpan time = initalTime - TimeSpan.FromHours(initalTime.TotalHours * Value / 70);
                string str = string.Format("{0}", time.Hours) + "h "; // time.ToString(@"hh") + "h ";
                str = str + string.Format("{0}", time.Minutes) + "m"; //str + time.ToString(@"mm") + "m";
                g.DrawString("Travel Time - 6h 5m  /  Rm. Time - " + str, new Font("Segoe UI", 15, FontStyle.Bold, GraphicsUnit.Pixel), brush, m_ProgressBar.Width / 3 - 30, m_ProgressBar.Height / 7);                
            }
        }
        #endregion

        #endregion
    }
    #endregion
}