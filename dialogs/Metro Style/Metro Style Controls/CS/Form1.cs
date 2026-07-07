#region Copyright Syncfusion Inc. 2001 - 2014
// Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
using Syncfusion.WinForms.Controls;

namespace MetroStyleControls_2008
{
    public partial class Form1 : MetroForm
    {

        ToolTipAdv tooltip = null;
        TrackBarEx trackBar = new TrackBarEx();
        SfToolTip sfToolTip = new SfToolTip();
        public Form1()
        {
            InitializeComponent();
            tooltip = new ToolTipAdv(this);
            tooltip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            ToolTipItem toolTipItem = new ToolTipItem();
            toolTipItem.Text = "This option will work only in Windows 11 OS";
            Syncfusion.WinForms.Controls.ToolTipInfo toolTipInfo = new Syncfusion.WinForms.Controls.ToolTipInfo();
            toolTipInfo.Items.Add(toolTipItem);
            toolTipInfo.MinWidth = 250;
            sfToolTip.SetToolTipInfo(roundedCornersCheckBox, toolTipInfo);
            
            foreach (CaptionImage image in this.CaptionImages)
            {
                if (image.Name == "CaptionImage6")
                {
                    image.Location = new Point(this.Width - 34, 4);
                }
                else if (image.Name == "CaptionImage7")
                {
                    image.Location = new Point(this.Width - 63, 4);
                }
                else if (image.Name == "CaptionImage8")
                {
                    image.Location = new Point(this.Width - 87, 4);
                }
                if (image.Name == "CaptionImage3")
                {
                    image.Location = new Point(this.Width - 3 * image.Size.Width - 30,40);
                }
                else if (image.Name == "CaptionImage4")
                {
                    image.Location = new Point(this.Width - 2 * image.Size.Width - 20,40);
                }
                else if (image.Name == "CaptionImage5")
                {
                    image.Location = new Point(this.Width - image.Size.Width - 10 ,40);
                }
                image.ImageMouseEnter += new CaptionImage.MouseEnter(image_ImageMouseEnter);
                image.ImageMouseLeave += new CaptionImage.MouseLeave(image_ImageMouseLeave);
                image.ImageMouseMove += new CaptionImage.MouseMove(image_ImageMouseMove);
                image.ImageMouseUp += new CaptionImage.MouseUp(image_ImageMouseUp);
                this.Resize += new EventHandler(Form1_Resize);
            }
            this.HideControlboxHighlights();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            this.trackBarEx1.ValueChanged += new EventHandler(trackBarEx1_ValueChanged);
            trackBar.Location = new Point(180, 210);
            this.trackBar.Size = new Size(150, 100);
            trackBar.Style = TrackBarEx.Theme.Metro;
            this.Controls.Add(trackBar);
            trackBar.ValueChanged += new EventHandler(trackBar_ValueChanged);
            trackBar.Value = 1;
            
            this.radioButtonAdv7.Checked = true;
            this.radioButton2.Checked = true;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.radioButtonAdv2.MetroColor = Color.Black;
            this.radioButtonAdv3.MetroColor = Color.Black;
            this.radioButtonAdv4.MetroColor = Color.Black;
            this.radioButtonAdv5.MetroColor = Color.Black;
            this.radioButtonAdv6.MetroColor = Color.Black;
            this.radioButtonAdv7.MetroColor = Color.Black;
            this.radioButtonAdv8.MetroColor = Color.Black;
            this.checkBoxAdv1.MetroColor = Color.Black;
            this.roundedCornersCheckBox.MetroColor = Color.Black;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowIcon = true;
        }

        void Form1_Resize(object sender, EventArgs e)
        {
            this.tooltip.HidePopup();
        }

        void image_ImageMouseMove(object sender, ImageMouseMoveEventArgs e)
        {
            if ((sender as CaptionImage).Name == "CaptionImage7")
            {
                if (this.WindowState == FormWindowState.Maximized)
                    tooltip.Text = "Restore Down";
                else
                    tooltip.Text = "Maximize";
                Point pt = new Point(e.Location.X, e.Location.Y -35);
                tooltip.ShowPopup(PointToScreen(pt));
            }
            if ((sender as CaptionImage).Name == "CaptionImage6")
            {
                tooltip.Text = "Close";
                Point pt = new Point(e.Location.X, e.Location.Y -35 );
                tooltip.ShowPopup(PointToScreen(pt));
            }
            if ((sender as CaptionImage).Name == "CaptionImage8")
            {
                tooltip.Text = "Minimize";
                Point pt = new Point(e.Location.X, e.Location.Y-35);
                tooltip.ShowPopup(PointToScreen(pt));
            }
        }

        void image_ImageMouseUp(object sender, ImageMouseUpEventArgs e)
        {
            if ((sender as CaptionImage).Name == "CaptionImage8")
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if ((sender as CaptionImage).Name == "CaptionImage7")
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    this.WindowState = FormWindowState.Maximized;
                    (sender as CaptionImage).Image = global::MetroStyleControls_2008.Properties.Resources.restore;
                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                    (sender as CaptionImage).Image = global::MetroStyleControls_2008.Properties.Resources.max;
                }
            }
            else if ((sender as CaptionImage).Name == "CaptionImage6")
            {
                this.Close();
            }
        }

        void image_ImageMouseLeave(object sender, ImageMouseLeaveEventArgs e)
        {
            this.tooltip.HidePopup();
            if ((sender as CaptionImage).Name == "CaptionImage1")
            {
                e.Image = global::MetroStyleControls_2008.Properties.Resources.RBNormal;
            }
            else if ((sender as CaptionImage).Name == "CaptionImage2")
            {
                e.Image = global::MetroStyleControls_2008.Properties.Resources.Snormal;
            }
            else if ((sender as CaptionImage).Name == "CaptionImage3")
            {
                e.Image = global::MetroStyleControls_2008.Properties.Resources.HNormal;
            }
            else if ((sender as CaptionImage).Name == "CaptionImage4")
            {
                e.Image = global::MetroStyleControls_2008.Properties.Resources.StarNormal;
            }
            else if ((sender as CaptionImage).Name == "CaptionImage5")
            {
                e.Image = global::MetroStyleControls_2008.Properties.Resources.SettingsNoraml;
            }
            else if ((sender as CaptionImage).Name == "CaptionImage8")
            {
                e.BackColor = Color.Transparent;
            }
            else if ((sender as CaptionImage).Name == "CaptionImage7")
            {
                e.BackColor = Color.Transparent;
            }
            else if ((sender as CaptionImage).Name == "CaptionImage6")
            {
                e.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            }
        }

        void image_ImageMouseEnter(object sender, ImageMouseEnterEventArgs e)
        {
             if ((sender as CaptionImage).Name == "CaptionImage1")
            {
                e.Image = global::MetroStyleControls_2008.Properties.Resources.RBHover;
            }
            else if ((sender as CaptionImage).Name == "CaptionImage2")
            {
                e.Image = global::MetroStyleControls_2008.Properties.Resources.SHover;
            }
            else if ((sender as CaptionImage).Name == "CaptionImage3")
            {
                e.Image = global::MetroStyleControls_2008.Properties.Resources.HHover;
            }
            else if ((sender as CaptionImage).Name == "CaptionImage4")
            {
                e.Image = global::MetroStyleControls_2008.Properties.Resources.StarHover;
            }
            else if ((sender as CaptionImage).Name == "CaptionImage5")
             {
                 e.Image = global::MetroStyleControls_2008.Properties.Resources.Settingshover;
             }
            else if ((sender as CaptionImage).Name == "CaptionImage8")
            {
                e.BackColor = ColorApply;
            }
            else if ((sender as CaptionImage).Name == "CaptionImage7")
            {
                e.BackColor = ColorApply;
            }
             else if ((sender as CaptionImage).Name == "CaptionImage6")
             {
                 e.BackColor = Color.Red;
             }
        }

        void trackBarEx1_ValueChanged(object sender, EventArgs e)
        {
            this.BorderThickness = trackBarEx1.Value;
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

        void trackBar_ValueChanged(object sender, EventArgs e)
        {
           
        }
        private Color ColorApply = Color.Blue;
        private void label31_Click(object sender, EventArgs e)
        {
            if (this.radioButtonAdv2.Checked)
                this.CaptionBarColor = (sender as Label).BackColor;
            if (this.radioButtonAdv3.Checked)
                this.BorderColor = (sender as Label).BackColor;
            if (this.radioButtonAdv4.Checked)
                ColorApply = (sender as Label).BackColor;
            if (this.radioButtonAdv5.Checked)
                this.CaptionForeColor = (sender as Label).BackColor;

        }

        private void label31_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void label31_MouseEnter(object sender, EventArgs e)
        {
            //(sender as Label).Left -= 1;
            //(sender as Label).Top -= 1;
            //(sender as Label).Width += 4;
            //(sender as Label).Height += 4;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void radioButtonAdv6_CheckChanged(object sender, EventArgs e)
        {
  
                if(this.radioButtonAdv6.Checked)
                this.CaptionAlign = HorizontalAlignment.Left;
                if (this.radioButtonAdv7.Checked)
                    this.CaptionAlign = HorizontalAlignment.Center;
                if (this.radioButtonAdv8.Checked)
                    this.CaptionAlign = HorizontalAlignment.Right;
            
        }

        private void showForm()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            MetroForm form = new MetroForm();
            
            form.DropShadow = this.checkBoxAdv1.Checked;
            if(this.checkBoxAdv1.Checked )
                form.Text = "MetroForm with shadow";
            else
                form.Text = "MetroForm without shadow";
            form.Show();
            form.ShowIcon = false;
            Point point = new Point(this.Left + this.panel3.Left + 45, this.Top + panel3.Top + 188);
            form.Location = point;
            form.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Size size = new Size(this.panel3.Width - 20, this.panel3.Height - 40);

            form.Size = size;
            
        }
        private void panel3_Click(object sender, EventArgs e)
        {
            showForm();

        }

        private void label28_Click(object sender, EventArgs e)
        {
            showForm();
        }

        private void radioButtonAdv1_CheckChanged(object sender, EventArgs e)
        {

        }

        private void label31_MouseLeave(object sender, EventArgs e)
        {
            //(sender as Label).Left += 1;
            //(sender as Label).Top += 1;
            //(sender as Label).Width -= 4;
            //(sender as Label).Height -= 4;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {


        }

        private void Form1_Move(object sender, EventArgs e)
        {
           
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
         //   this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                this.Text = "                               MetroForm";
                this.CaptionAlign = HorizontalAlignment.Left;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked)
            {
                this.Text = "MetroForm";
                this.CaptionAlign = HorizontalAlignment.Center;
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton3.Checked)
            {
                this.Text = "MetroForm                           ";
                this.CaptionAlign = HorizontalAlignment.Right;
            }
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            foreach (CaptionImage image in this.CaptionImages)
            {
                if (image.Name == "CaptionImage7")
                {
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        image.Image = global::MetroStyleControls_2008.Properties.Resources.restore;
                    }
                    else
                    {
                        image.Image = global::MetroStyleControls_2008.Properties.Resources.max;
                    }
                }
            }
            foreach (CaptionImage image in this.CaptionImages)
            {
                if (image.Name == "CaptionImage3")
                {
                    image.Location = new Point(this.Width - 3 * image.Size.Width - 30 , 40);
                }
                else if (image.Name == "CaptionImage4")
                {
                    image.Location = new Point(this.Width - 2 * image.Size.Width - 20 ,40);
                }
                else if (image.Name == "CaptionImage5")
                {
                    image.Location = new Point(this.Width - image.Size.Width - 10,40);
                }
                else if (image.Name == "CaptionImage6")
                {
                    image.Location = new Point(this.Width - 34, 4);
                }
                else if (image.Name == "CaptionImage7")
                {
                    image.Location = new Point(this.Width - 60, 4);
                }
                else if (image.Name == "CaptionImage8")
                {
                    image.Location = new Point(this.Width - 90, 4);
                }
            }
            base.OnSizeChanged(e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.AllowRoundedCorners = this.roundedCornersCheckBox.Checked;
        }
    }
}
