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

namespace CarouselDemo_2008
{
    public partial class Form1 : MetroForm
    {
        private bool allowRotate = false;
        public Form1()
        {
            InitializeComponent();
            this.carousel1.TransitionSpeed = 1;
            SetInitializationSettings();

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


        private void SetInitializationSettings()
        {
            this.comboPath.SelectedItem = "Default";
            this.chkRotate.Checked = this.carousel1.RotateAlways;
            this.trkPersp.Value = (int)this.carousel1.Perspective;
            this.trkSpeed.Value = (int)this.carousel1.TransitionSpeed;
            this.chkShadow.Checked = this.carousel1.ShowImageShadow;
            this.chkPreview.Checked = this.carousel1.ShowImagePreview;
            this.chkOrig.Checked = this.carousel1.UseOriginalImageinPreview;
            this.label1.Text = this.carousel1.Perspective.ToString();
            this.label2.Text = this.carousel1.TransitionSpeed.ToString();
        }

        private void trkPersp_ValueChanged(object sender, EventArgs e)
        {
            this.carousel1.Perspective = this.trkPersp.Value;
            this.label1.Text = this.carousel1.Perspective.ToString();
            this.carousel1.Refresh();
            
        }

        private void trkSpeed_ValueChanged(object sender, EventArgs e)
        {
            this.carousel1.TransitionSpeed = this.trkSpeed.Value;
            this.label2.Text = this.carousel1.TransitionSpeed.ToString();
            this.carousel1.Refresh();
        }

        private void chkShadow_CheckedChanged(object sender, EventArgs e)
        {
            this.carousel1.ShowImageShadow = this.chkShadow.Checked;
            this.carousel1.Refresh();
        }

        private void chkPreview_CheckedChanged(object sender, EventArgs e)
        {
            this.carousel1.ShowImagePreview = this.chkPreview.Checked;
            this.carousel1.Refresh();
        }

        private void chkOrig_CheckedChanged(object sender, EventArgs e)
        {
            this.carousel1.UseOriginalImageinPreview = this.chkOrig.Checked;
            this.carousel1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Color.Empty;
            colorDialog1.ShowDialog();
            this.carousel1.HighlightColor = colorDialog1.Color;
            this.carousel1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Color.Empty;
            colorDialog1.ShowDialog();
            this.carousel1.ImageshadeColor = colorDialog1.Color;
            this.carousel1.Refresh();
        }

        private void chkRotate_CheckedChanged(object sender, EventArgs e)
        {
            this.carousel1.RotateAlways = this.chkRotate.Checked;
            this.chknvr.Enabled = !this.chkRotate.Checked;
        }

        private void comboPath_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboPath.SelectedItem.ToString())
            {
                case "Orbital":
                    this.carousel1.CarouselPath = CarouselPath.Orbital;
                    this.carousel1.PadY = 15;
                    break;
                case "Linear":
                    this.carousel1.CarouselPath = CarouselPath.Linear;
                    break;
                case "Oval":
                    this.carousel1.CarouselPath = CarouselPath.Oval;
                    this.carousel1.PadY = 15;
                    break;
                default:
                    this.carousel1.CarouselPath = CarouselPath.Default;
                    this.carousel1.PadY = 0;
                    break;
            }
            this.label1.Text = this.carousel1.Perspective.ToString();
            this.label2.Text = this.carousel1.TransitionSpeed.ToString();
            this.trkSpeed.Value = (int)this.carousel1.TransitionSpeed;
            this.trkPersp.Value = (int)this.carousel1.Perspective;
        }

        private void chknvr_CheckedChanged(object sender, EventArgs e)
        {
            allowRotate = chknvr.Checked;
            chkRotate.Enabled = !chknvr.Checked;
        }

        private void carousel1_OnCarouselItemSelectionChanging(object sender, CarouselItemSelectionChangingArgs e)
        {
            e.Cancel = allowRotate;
        }

        private void carousel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Gray), e.ClipRectangle);
        }
    }
}
