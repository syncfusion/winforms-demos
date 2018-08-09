using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
         #region Win32

        const int AW_HIDE = 0X10000;
        const int AW_ACTIVATE = 0X20000;
        const int AW_HOR_POSITIVE = 0X1;
        const int AW_HOR_NEGATIVE = 0X2;
        const int AW_SLIDE = 0X40000;
        const int AW_BLEND = 0X80000;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int AnimateWindow
        (IntPtr hwand, int dwTime, int dwFlags);

        #endregion

        #region Variables

        private bool _UseSlideAnimation;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="FadeForm"/> class.
        /// </summary>
        public Form2() : this(false) {
         
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="FadeForm"/> class.
        /// </summary>
        /// <param name="useSlideAnimation">if set to <c>true</c> [use slide animation].</param>
        public Form2(bool useSlideAnimation)
        {
            _UseSlideAnimation = useSlideAnimation;
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.Load"/> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data.</param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            AnimateWindow(this.Handle,1000, AW_ACTIVATE | (_UseSlideAnimation ? AW_HOR_POSITIVE | AW_SLIDE : AW_BLEND));
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.Closing"/> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.ComponentModel.CancelEventArgs"/> that contains the event data.</param>
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            if (e.Cancel == false)
            {
                AnimateWindow(this.Handle, 1000, AW_HIDE | (_UseSlideAnimation ? AW_HOR_NEGATIVE | AW_SLIDE : AW_BLEND));
            }
        }
        Form1 baseForm;
        public Form2(Form1 parentForm)
        {
            InitializeComponent();
            baseForm = parentForm;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
           
            base.OnPaint(e);
            if (e.ClipRectangle.Width == this.Width)
                e.Graphics.DrawRectangle(new Pen(ColorTranslator.FromHtml("#119EDA")), new Rectangle(e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1));
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pBox = sender as PictureBox;
            switch (pBox.Name)
            {
                case "pictureBox1":
                    baseForm.Frame = "1";
                    break;
                case "pictureBox2":
                    baseForm.Frame = "2";
                    break;
                case "pictureBox3":
                    baseForm.Frame = "3";
                    break;
                default:
                    baseForm.Frame = "1";
                    break;
            }
            this.Close();
        }
        #endregion
    }
}
