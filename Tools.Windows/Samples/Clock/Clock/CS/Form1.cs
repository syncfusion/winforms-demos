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

namespace ClockDemo_2008
{
    public partial class Form1 : MetroForm
    {
        TrackBarEx trackBarEx = new TrackBarEx();

        ColorPickerUIAdv picker = new ColorPickerUIAdv();

        public Form1()
        {
            InitializeComponent();

            this.clock1.Text = " Remainder ";

            trackBarEx.Style = TrackBarEx.Theme.Metro;
            
            trackBarEx.Location = new Point(10, 100);
            trackBarEx.Size = new Size(220, 20);

            this.panel5 .Controls.Add(trackBarEx);

            trackBarEx.ValueChanged += new EventHandler(trackBarEx_ValueChanged);


            picker.Size = new Size(this.panel4.Size.Width, this.panel4.Size.Height);
            picker.Location = this.colorUIControl1.Location;
            this.panel4.Controls.Remove(this.colorUIControl1);
            picker.MetroColor = Color.Gray;
            picker.Style = ColorPickerUIAdv.visualstyle.Metro;
            picker.Dock = DockStyle.Fill;
            picker.BackColor = Color.Gray;
            this.panel4.Controls.Add(picker);
            picker.Picked += new ColorPickerUIAdv.ColorPickedEventHandler(picker_Picked);
            
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }


        }
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

        void picker_Picked(object sender, ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            if (this.radioButtonAdv1.Checked)
            {
                this.clock1.MinuteColor = picker.SelectedColor ;
            }
            if (this.radioButtonAdv2.Checked)
            {
                this.clock1.HourHandColor = picker.SelectedColor;
            }
            if (this.radioButtonAdv3.Checked)
            {
                this.clock1.MinuteHandColor = picker.SelectedColor;
            }
            if (this.radioButtonAdv4.Checked)
            {
                this.clock1.SecondHandColor = picker.SelectedColor;
            }
            if (this.radioButtonAdv5.Checked)
            {
                this.clock1.StartGradientBackColor = picker.SelectedColor;
            }
            if (this.radioButtonAdv6.Checked)
            {
                this.clock1.EndGradientBackColor = picker.SelectedColor;
            }
        }

        void trackBarEx_ValueChanged(object sender, EventArgs e)
        {
            if (this.radioButtonAdv7.Checked)
            {
                this.clock1.SecondHandThickness = trackBarEx.Value;
            }
            if (this.radioButtonAdv8.Checked)
            {
                this.clock1.MinuteHandThickness  = trackBarEx.Value;
            }
            if (this.radioButtonAdv9.Checked)
            {
                this.clock1.HourHandThickness    = trackBarEx.Value;
            }
            if (this.radioButtonAdv10.Checked)
            {
                this.clock1.MinuteThickness  = trackBarEx.Value;
            }
        }


        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBoxAdv2_CheckStateChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonAdv10_CheckChanged(object sender, EventArgs e)
        {
            this.trackBarEx.Value = (int)this.clock1.MinuteThickness;
        }

        private void radioButtonAdv9_CheckChanged(object sender, EventArgs e)
        {
            this.trackBarEx.Value = (int)this.clock1.HourHandThickness ;
        }

        private void radioButtonAdv8_CheckChanged(object sender, EventArgs e)
        {
            this.trackBarEx.Value = (int)this.clock1.MinuteHandThickness ;
        }

        private void radioButtonAdv7_CheckChanged(object sender, EventArgs e)
        {
            this.trackBarEx.Value = (int)this.clock1.SecondHandThickness ;
        }

        private void colorUIControl1_Click(object sender, EventArgs e)
        {
   
        }

        private void colorUIControl1_ColorSelected(object sender, EventArgs e)
        {
            if (this.radioButtonAdv1.Checked)
            {
                this.clock1.MinuteColor = this.colorUIControl1.SelectedColor;
            }
            if (this.radioButtonAdv2.Checked)
            {
                this.clock1.HourHandColor = this.colorUIControl1.SelectedColor;
            }
            if (this.radioButtonAdv3.Checked)
            {
                this.clock1.MinuteHandColor = this.colorUIControl1.SelectedColor;
            }
            if (this.radioButtonAdv4.Checked)
            {
                this.clock1.SecondHandColor = this.colorUIControl1.SelectedColor;
            }
            if (this.radioButtonAdv5.Checked)
            {
                this.clock1.StartGradientBackColor = this.colorUIControl1.SelectedColor;
            }
            if (this.radioButtonAdv6.Checked)
            {
                this.clock1.EndGradientBackColor = this.colorUIControl1.SelectedColor;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.clock1.Image = Image.FromFile("../../ClockModelImages/Clock10.png");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.clock1.ShowBorder = false;
            this.clock1.ShowMinute = false;
            this.clock1.Image = Image.FromFile("../../ClockModelImages/Clock1.png");
            this.checkBoxAdv6.Checked = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.clock1.ShowBorder = false;
            this.clock1.ShowMinute = false;
            this.clock1.Image = Image.FromFile("../../ClockModelImages/Clock2.png");
            this.checkBoxAdv6.Checked = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.clock1.ShowBorder = false;
            this.clock1.ShowMinute = false;
            this.clock1.Image = Image.FromFile("../../ClockModelImages/Clock3.png");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.clock1.ShowBorder = false;
            this.clock1.ShowMinute = false;
            this.clock1.Image = Image.FromFile("../../ClockModelImages/Clock4.png");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.clock1.ShowBorder = false;
            this.clock1.ShowMinute = false;
            this.clock1.Image = Image.FromFile("../../ClockModelImages/Clock5.png");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.clock1.ShowBorder = false;
            this.clock1.ShowMinute = false;
            this.clock1.Image = Image.FromFile("../../ClockModelImages/Clock6.png");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.clock1.ShowBorder = false;
            this.clock1.ShowMinute = false;
            this.clock1.Image = Image.FromFile("../../ClockModelImages/Clock7.png");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBoxAdv3_CheckStateChanged(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            if (!this.checkBoxAdv5.Checked)
            {
                this.clock1.Image = null;
                this.checkBoxAdv1.Checked = true;
                this.clock1.Image = null;
                this.clock1.MinuteHandThickness = 1;
                this.clock1.HourHandThickness = 2;
                this.clock1.MinuteHandThickness = 2;
                this.clock1.StartGradientBackColor = ColorTranslator.FromHtml("#FFFFFF");
                this.clock1.EndGradientBackColor = ColorTranslator.FromHtml("#CCD6D9");
                this.clock1.MinuteColor = Color.Gray;
                this.clock1.HourHandColor = Color.Gray;
                this.clock1.MinuteHandColor = Color.Gray;
                this.clock1.SecondHandColor = Color.Gray;
                this.clock1.ShowBorder = true;
                this.clock1.ShowMinute = true;
                this.checkBoxAdv1.Checked = true;
                
                
            }



        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            this.clock1.EnableRemainder = true;
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            int hour = DateTime.Now.Hour;
            int min = DateTime.Now.Minute;
            int sec = DateTime.Now.Second;
            int msec = DateTime.Now.Millisecond;
            this.clock1.Remainder = new System.DateTime(year , month, day, hour, min, sec, msec);
        }

        private void checkBoxAdv1_CheckStateChanged_1(object sender, EventArgs e)
        {
            this.clock1.ShowMinute = this.checkBoxAdv1.Checked;
        }

        private void checkBoxAdv2_CheckStateChanged_1(object sender, EventArgs e)
        {
            this.clock1.ShowHourDesignator = this.checkBoxAdv2.Checked;
        }

        private void checkBoxAdv3_CheckStateChanged_1(object sender, EventArgs e)
        {
            this.clock1.ShowSecondHand = this.checkBoxAdv3.Checked;
        }

        private void checkBoxAdv4_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAdv4.Checked)
            {
                CustomRenderer renderer = new CustomRenderer();
                this.clock1.Renderer = renderer;
            }
            else
            {
                ClockRenderer renderer = new ClockRenderer();
                this.clock1.Renderer = renderer;
            }
          
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.clock1.ShowBorder = false;
            this.clock1.ShowMinute = false;
            this.clock1.Image = Image.FromFile("../../ClockModelImages/Clock8.png");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.clock1.StartGradientBackColor = Color.White; ;
            this.clock1.EndGradientBackColor = Color.White; ;
            this.clock1.Image = Image.FromFile("../../ClockModelImages/Clock9.png");
        }

        private void checkBoxAdv5_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxAdv5.Checked)
            {
                this.clock1.Image = Image.FromFile("../../ClockModelImages/Clock1.png");
                this.clock1.ShowMinute = false;
                this.clock1.ShowBorder = false;
                this.checkBoxAdv1.Checked = true;
                this.checkBoxAdv6.Checked = false;
                this.panel1.BackgroundImage  = null;
            }
            else
            {
                this.clock1.Image = null;
                this.clock1.MinuteHandThickness = 1;
                this.clock1.HourHandThickness = 2;
                this.clock1.MinuteHandThickness = 2;
                this.clock1.StartGradientBackColor  = ColorTranslator.FromHtml("#FFFFFF");
                this.clock1.EndGradientBackColor  = ColorTranslator.FromHtml("#CCD6D9");
                this.clock1.MinuteColor  = Color.Gray;
                this.clock1.HourHandColor = Color.Gray;
                this.clock1.MinuteHandColor  = Color.Gray;
                this.clock1.SecondHandColor  = Color.Gray;
                this.clock1.ShowMinute = true;
                this.clock1.ShowBorder = true;
                this.checkBoxAdv1.Checked = true;
                this.clock1.IsTransparent = false;
            }
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            if (!this.checkBoxAdv5.Checked)
            {
                this.clock1.Image = Image.FromFile("../../ClockModelImages/Clock1.png");
            }
            this.clock1.ShowBorder = false;
            this.clock1.ShowMinute = false;
            this.checkBoxAdv6.Checked = false;
        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            if (!this.checkBoxAdv5.Checked)
            {
                this.clock1.Image = Image.FromFile("../../ClockModelImages/Clock9.png");
            }
            this.clock1.ShowBorder = false;
            this.clock1.ShowMinute = false;
            this.checkBoxAdv6.Checked = false;
            this.clock1.StartGradientBackColor = Color.White;
            this.clock1.EndGradientBackColor = Color.White;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            if (!this.checkBoxAdv5.Checked)
            {
                this.clock1.Image = Image.FromFile("../../ClockModelImages/Clock2.png");
            }
            this.clock1.ShowBorder = false;
            this.clock1.ShowMinute = false;
            this.checkBoxAdv6.Checked = false;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            if (!this.checkBoxAdv5.Checked)
            {
                this.clock1.Image = Image.FromFile("../../ClockModelImages/Clock3.png");
            }
            this.clock1.ShowBorder = false;
            this.clock1.ShowMinute = false;
            this.checkBoxAdv6.Checked = false;
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            if (!this.checkBoxAdv5.Checked)
            {
                this.clock1.Image = Image.FromFile("../../ClockModelImages/Clock4.png");
            }
            this.clock1.ShowBorder = false;
            this.clock1.ShowMinute = false;
            this.checkBoxAdv6.Checked = false;
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            if (!this.checkBoxAdv5.Checked)
            {
                this.clock1.Image = Image.FromFile("../../ClockModelImages/Clock5.png");
            }
            this.clock1.ShowBorder = false;
            this.clock1.ShowMinute = false;
            this.checkBoxAdv6.Checked = false;
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            if (!this.checkBoxAdv5.Checked)
            {
                this.clock1.Image = Image.FromFile("../../ClockModelImages/Clock6.png");
            }
            this.clock1.ShowBorder = false;
            this.clock1.ShowMinute = false;
            this.checkBoxAdv6.Checked = false;
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            if (!this.checkBoxAdv5.Checked)
            {
                this.clock1.Image = Image.FromFile("../../ClockModelImages/Clock7.png");
            }
            this.clock1.ShowBorder = false;
            this.clock1.ShowMinute = false;
            this.checkBoxAdv6.Checked = false;
        }

        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            if (!this.checkBoxAdv5.Checked)
            {
                this.clock1.Image = Image.FromFile("../../ClockModelImages/Clock8.png");
            }
            this.clock1.ShowBorder = false;
            this.clock1.ShowMinute = false;
            this.checkBoxAdv6.Checked = false;
        }

        private void pictureBox1_MouseEnter_1(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            if (!this.checkBoxAdv5.Checked)
            {
                this.clock1.Image = Image.FromFile("../../ClockModelImages/Clock10.png");
            }
            this.clock1.ShowBorder = false;
            this.clock1.ShowMinute = false;
            this.checkBoxAdv6.Checked = false;
        }

        private void label5_Leave(object sender, EventArgs e)
        {

        }

        private void checkBoxAdv6_CheckStateChanged(object sender, EventArgs e)
        {

            this.clock1.IsTransparent = checkBoxAdv6.Checked;

            if (checkBoxAdv6.Checked)
            {
                this.panel1.BackgroundImage = global::ClockDemo_2008.Properties.Resources._3;
            }
            else
            {
                this.panel1.BackgroundImage = null;
            }
        }

        private void buttonAdv1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonAdv1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
    public class CustomRenderer : ClockRenderer
    {


        public override void DrawInterior(Graphics g, float thickness, PointF startPoint, PointF endPoint, Color color, string sender)
        {
            if (sender == "SecondsHand")
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Pen p = new Pen(color, thickness + thickness);
                p.StartCap = LineCap.SquareAnchor;
                p.EndCap = LineCap.ArrowAnchor;
                g.DrawLine(p, startPoint, endPoint);
                p.Dispose();
            }
            else if (sender == "MinutesHand")
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Pen p = new Pen(color, thickness + thickness);
                p.StartCap = LineCap.SquareAnchor;
                p.EndCap = LineCap.ArrowAnchor;
                g.DrawLine(p, startPoint, endPoint);
                p.Dispose();
            }
            else if (sender == "HoursHand")
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Pen p = new Pen(color, thickness + thickness);
                p.StartCap = LineCap.SquareAnchor;
                p.EndCap = LineCap.ArrowAnchor;
                g.DrawLine(p, startPoint, endPoint);
                p.Dispose();
            }
            else
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Pen p = new Pen(color, 5 );
                p.DashStyle = DashStyle.Dot;
                g.DrawLine(p, startPoint, endPoint);
                p.Dispose();
            }

        }

    }

}
