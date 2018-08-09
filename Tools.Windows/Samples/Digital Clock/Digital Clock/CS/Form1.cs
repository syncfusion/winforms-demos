using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication1
{
    #region DigitalClock
    public partial class Form1 : MetroForm
    {
        #region Initialization
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
        Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo1 = new Syncfusion.Windows.Forms.BannerTextInfo();
        public Form1()
        {
            InitializeComponent();
          try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            this.colorPickerButton2.Enabled = !this.checkBox3.Checked;
            this.clock2.CustomTime = DateTime.Now;
            this.bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(this.components);
            bannerTextInfo1.Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode;
            bannerTextInfo1.Text = "Enter the above format";
            bannerTextInfo1.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.textBoxExt1, bannerTextInfo1);
        }
        #endregion
        #region Form Icon
        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
        }
        #endregion
        #region Formats
        private void button3_Click(object sender, EventArgs e)
        {
            this.clock2.ClockFormat = "mm:HH";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.clock2.ClockFormat = "ss";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.clock2.ClockFormat = "HH:ss";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.clock2.ClockFormat = "HH:mm:ss";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                this.clock2.ClockFormat = "HH:mm:ss";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                this.clock2.ClockFormat = "mm:HH";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
                this.clock2.ClockFormat = "ss";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
                this.clock2.ClockFormat = "HH:ss";
        }
        #endregion
        #region ClockTypes
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.CreateGraphics().DpiX > 96)
                this.clock2.Location = new Point(40 + ((this.Width - 927) / 2), 53 + ((this.Height - 565) / 2));
            else
                this.clock2.Location = new Point(34 + ((this.Width - 700) / 2), 53 + ((this.Height - 461) / 2));
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                this.clock2.ClockType = Syncfusion.Windows.Forms.Tools.ClockTypes.Analog;
                this.checkBox2.Checked = false;
                this.checkBox2.Enabled = false;
                this.checkBoxAdv1.Checked = false;
                this.checkBoxAdv1.Enabled = false;
            }
            else
            {
                this.checkBoxAdv1.Checked = true;
                this.checkBox2.Enabled = true;
                this.checkBoxAdv1.Enabled = true;
            }
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
                this.clock2.ClockType = Syncfusion.Windows.Forms.Tools.ClockTypes.Digital;
        }
        #endregion ClockTypes
        #region ClockShapes
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
                this.clock2.ClockShape = Syncfusion.Windows.Forms.Tools.ClockShapes.Rectangle;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton8.Checked)
                this.clock2.ClockShape = Syncfusion.Windows.Forms.Tools.ClockShapes.RoundedRectangle;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
                this.clock2.ClockShape = Syncfusion.Windows.Forms.Tools.ClockShapes.Square;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton10.Checked)
            this.clock2.ClockShape = Syncfusion.Windows.Forms.Tools.ClockShapes.RoundedSquare;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton11.Checked)
                this.clock2.ClockShape = Syncfusion.Windows.Forms.Tools.ClockShapes.Circle;
        }
        #endregion 
        #region Clock style
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = this.checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.clock2.ShowHourDesignator = this.checkBox2.Checked;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked)
                this.clock2.ClockFormat = "HH:mm";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            this.clock2.ShowClockFrame = this.checkBox3.Checked;
            radioButton13.Enabled = this.checkBox3.Checked;
            radioButton14.Enabled = this.checkBox3.Checked;
            radioButton15.Enabled = this.checkBox3.Checked;
            groupBox3.Enabled = !this.checkBox3.Checked;
            this.colorPickerButton2.Enabled = !this.checkBox3.Checked; 
        }
        #endregion
        #region ClockFrames
        DigitalClockRenderer newrender = new DigitalClockRenderer();
        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            this.clock2.DigitalRenderer = newrender;
            if (radioButton13.Checked)
                this.clock2.ClockFrame = Syncfusion.Windows.Forms.Tools.ClockFrames.RectangularFrame;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            this.clock2.DigitalRenderer = newrender;
            if (radioButton14.Checked)
                this.clock2.ClockFrame = Syncfusion.Windows.Forms.Tools.ClockFrames.CircularFrame;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            this.clock2.DigitalRenderer = newrender;
            if (radioButton15.Checked)
                this.clock2.ClockFrame = Syncfusion.Windows.Forms.Tools.ClockFrames.SquareFrame;
        }
        #endregion
        #region Color customization
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.clock2.ShowCustomTimeClock = this.checkBox1.Checked;
        }

        private void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            this.clock2.ForeColor = this.colorPickerButton1.SelectedColor;
        }

        private void colorPickerButton2_ColorSelected(object sender, EventArgs e)
        {
            this.clock2.BorderColor = this.colorPickerButton2.SelectedColor;
        }
        #endregion
        #region Clock Customization
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (!this.clock2.ShowCustomTimeClock)
                this.clock2.ShowCustomTimeClock = true;
            this.clock2.CustomTime =  this.dateTimePicker1.Value;
        }

        DigitalRenderer render = new DigitalRenderer();
        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 fr = new Form2(this);
            fr.FormClosed += new FormClosedEventHandler(fr_FormClosed);
            fr.ShowDialog();
        }

        void fr_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.clock2.SuspendLayout();
            this.clock2.DigitalRenderer = render;
            this.clock2.ResumeLayout();
        }
        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            this.clock2.DisplayDates = this.checkBoxAdv1.Checked;
        }
        private string frame = "1";
        public string Frame
        {
            get
            {
                return frame;
            }
            set
            {
                frame = value;
                DigitalRenderer.keyword = frame;
                switch (frame)
                {
                    case "1":
                        this.clock2.ClockFrame = ClockFrames.RectangularFrame;
                        break;
                    case "2":
                        this.clock2.ClockFrame = ClockFrames.CircularFrame;
                        break;
                    case "3":
                        this.clock2.ClockFrame = ClockFrames.SquareFrame;
                        break;
                    default:
                        this.clock2.ClockFrame = ClockFrames.RectangularFrame;
                        break;
                }
                this.panel2.Refresh();
                this.clock2.Refresh();
            }
        }
        private void radioButtonAdv1_CheckChanged_1(object sender, EventArgs e)
        {
            if (radioButtonAdv1.Checked)
                this.clock2.ClockFormat = "HH";
        }

        private void radioButtonAdv2_CheckChanged(object sender, EventArgs e)
        {
            if (radioButtonAdv2.Checked)
                this.clock2.ClockFormat = "HH:mm:ss";
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            string[] str = textBoxExt1.Text.Split(':');
            this.clock2.ShowCustomTimeClock = this.checkBox1.Checked;
            if (str.Length == 3)
            {
                try
                {
                    this.clock2.CustomTime = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, Convert.ToInt32(str[0].ToString()), Convert.ToInt32(str[1].ToString()), Convert.ToInt32(str[2].ToString()) - 1);
                }
                catch
                {
                    MessageBox.Show("Please ensure the given format");
                }
            }
            else
            {
                MessageBox.Show("Please ensure the given format");
            }
        }

        private void groupBar1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush ( Color.FromArgb(50, ColorTranslator.FromHtml("#119EDA"))), e.ClipRectangle);
        }
        #endregion
    }
    #endregion

    #region CustomRenderer
    public class DigitalRenderer : DigitalClockRenderer
    {
        internal static string keyword = "1";
        public override void DrawDigitalClockFrame(Graphics g, Image newImage, Clock clock)
        {
            Image newbitmap;
            switch (keyword)
            {
                case "1":
                    newbitmap =WindowsFormsApplication1.Properties.Resources._1;
                    break;
                case "2":
                    newbitmap = WindowsFormsApplication1.Properties.Resources._2;
                    break;
                case "3":
                    newbitmap = WindowsFormsApplication1.Properties.Resources._31;
                    break;
                default:
                    newbitmap = WindowsFormsApplication1.Properties.Resources._1;
                    break;
            }
            base.DrawDigitalClockFrame(g, newbitmap, clock);
        }
    }
     #endregion
}
