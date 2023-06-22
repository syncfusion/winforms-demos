#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerPointViewer
{
    public partial class SlideThumbnail : UserControl
    {
        Form1 form;
        private int _thumbnailID;

        public SlideThumbnail(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10, FontStyle.Regular);
            this.label1.ForeColor = Color.Black;
            this.pictureBox1.Size = new Size(170, 100);
            this.Click += SlideThumbnail_Click;
        }

        void SlideThumbnail_Click(object sender, EventArgs e)
        {
            this.Parent.Focus();
        }
        public Image PictureBoxImage
        {
            get
            {
                return pictureBox1.Image;
            }
            set
            {
                pictureBox1.Image = value;
            }
        }

        public string Number
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }

        public int ThumbnailID
        {
            get
            {
                return _thumbnailID;
            }
            set
            {
                _thumbnailID = value;
            }
        }

        public void SlideThumbnail_MouseClick(object sender, MouseEventArgs e)
        {
            form.IsOnLoad = false;
            form.OnMinimized = false;
            form.ClickAction(sender);
        }

        public void pictureBox_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            int position = (sender as PictureBox).Parent.TabIndex;
            if (form.OnMinimized)
            {
                if (position == form.GetLastPaintedPosition())
                {
                    form.HightLightControl(position);
                    form.SetLastPaintedPosition(position);
                }
            }
            else if (position == 0 && form.IsOnLoad)
            {
                form.HightLightControl(position);
                form.SetLastPaintedPosition(position);
            }
            else if (!form.IsOnLoad)
            {
                form.HightLightControl(position);
                form.SetLastPaintedPosition(position);
                form.IsOnLoad = true;
            }

        }
    }
}
