#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.WinForms.Controls;
using System;
using System.Drawing;

namespace ProgressBarAdv_CustomRender
{
    #region MainForm
    public partial class Form1 : SfForm
    {

        #region Constructor
        public Form1()
        {
            InitializeComponent();
            try
            {
                Bitmap bmp = new Bitmap(Image.FromFile(@"../../Icon/sficon.ico"));
                this.Icon = Icon.FromHandle(bmp.GetHicon());
            }
            catch (Exception ex)
            { }

            this.timer1.Tick += new EventHandler(timer1_Tick);

            //To specify the ProgressBar Style
            this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Custom;
            this.progressBarAdv2.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Custom;
            this.progressBarAdv4.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Custom;
            this.progressBarAdv5.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Custom;
            this.progressBarAdv6.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Custom;
            this.progressBarAdv7.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Custom;
            this.progressBarAdv8.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Custom;
            //Specify the custom renderer.
            this.progressBarAdv1.Renderer = new CustomShapesRenderer(this.progressBarAdv1);
            this.progressBarAdv1.ForeColor = ColorTranslator.FromHtml("#26a59a");
            this.progressBarAdv2.Renderer = new CustomShapesRenderer(this.progressBarAdv2);
            this.progressBarAdv2.ForeColor = ColorTranslator.FromHtml("#26a59a");
            this.progressBarAdv4.Renderer = new CustomShapesRenderer(this.progressBarAdv4);
            this.progressBarAdv4.ForeColor = ColorTranslator.FromHtml("#26a59a");
            this.progressBarAdv5.Renderer = new CustomShapesRenderer(this.progressBarAdv5);
            this.progressBarAdv5.ForeColor = ColorTranslator.FromHtml("#26a59a");
            this.progressBarAdv6.Renderer = new CustomShapesRenderer(this.progressBarAdv6);
            this.progressBarAdv6.ForeColor = ColorTranslator.FromHtml("#26a59a");
            this.progressBarAdv7.Renderer = new CustomShapesRenderer(this.progressBarAdv7);
            this.progressBarAdv7.ForeColor = ColorTranslator.FromHtml("#26a59a");
            this.progressBarAdv8.Renderer = new CustomShapesRenderer(this.progressBarAdv8);
            this.progressBarAdv8.ForeColor = ColorTranslator.FromHtml("#26a59a");

            this.progressBarAdv3.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Custom;
            this.progressBarAdv3.Renderer = new CustomViewRenderer(this.progressBarAdv3);
            this.progressBarAdv3.ForeColor = ColorTranslator.FromHtml("#26a59a");
            this.MinimumSize = new Size(1020, 519);
            this.timer1.Interval = 100;
            this.progressBarAdv3.Value = 10;

            if ((this.progressBarAdv1.Renderer as CustomShapesRenderer) != null)
            {
                (this.progressBarAdv1.Renderer as CustomShapesRenderer).BackGround = "Radial";
                this.progressBarAdv1.Invalidate();
            }
            if ((this.progressBarAdv2.Renderer as CustomShapesRenderer) != null)
            {
                (this.progressBarAdv2.Renderer as CustomShapesRenderer).BackGround = "Rectangle";
                this.progressBarAdv2.Invalidate();
            }
            if ((this.progressBarAdv5.Renderer as CustomShapesRenderer) != null)
            {
                (this.progressBarAdv5.Renderer as CustomShapesRenderer).BackGround = "PlayPause";
                this.progressBarAdv5.Invalidate();
            }
            if ((this.progressBarAdv4.Renderer as CustomShapesRenderer) != null)
            {
                (this.progressBarAdv4.Renderer as CustomShapesRenderer).BackGround = "Disc";
                this.progressBarAdv4.Invalidate();
            }
            if ((this.progressBarAdv6.Renderer as CustomShapesRenderer) != null)
            {
                (this.progressBarAdv6.Renderer as CustomShapesRenderer).BackGround = "Segments";
                this.progressBarAdv6.Invalidate();
            }
            if ((this.progressBarAdv7.Renderer as CustomShapesRenderer) != null)
            {
                (this.progressBarAdv7.Renderer as CustomShapesRenderer).BackGround = "InlineSegments";
                this.progressBarAdv7.Invalidate();
            }
            if ((this.progressBarAdv8.Renderer as CustomShapesRenderer) != null)
            {
                (this.progressBarAdv8.Renderer as CustomShapesRenderer).BackGround = "MultipleSegments";
                this.progressBarAdv8.Invalidate();
            }
            this.Load += Form1_Load;
        }

        #endregion

        #region Events
        /// <summary>
        /// Assigning the size as declared in designer form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(1025, 687);
            this.panel1.Size = new System.Drawing.Size(861, 683);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.progressBarAdv1.Size = new System.Drawing.Size(167, 162);
            this.progressBarAdv1.Location = new System.Drawing.Point(108, 60);
            this.progressBarAdv1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBarAdv2.Size = new System.Drawing.Size(243, 22);
            this.progressBarAdv2.Location = new System.Drawing.Point(97, 412);
            this.progressBarAdv2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBarAdv3.Size = new System.Drawing.Size(765, 226);
            this.progressBarAdv3.Location = new System.Drawing.Point(117, 566);
            this.progressBarAdv3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBarAdv4.Size = new System.Drawing.Size(167, 162);
            this.progressBarAdv4.Location = new System.Drawing.Point(423, 60);
            this.progressBarAdv4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBarAdv5.Size = new System.Drawing.Size(167, 162);
            this.progressBarAdv5.Location = new System.Drawing.Point(741, 60);
            this.progressBarAdv5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBarAdv6.Size = new System.Drawing.Size(167, 162);
            this.progressBarAdv6.Location = new System.Drawing.Point(108, 281);
            this.progressBarAdv6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBarAdv7.Size = new System.Drawing.Size(167, 162);
            this.progressBarAdv7.Location = new System.Drawing.Point(423, 281);
            this.progressBarAdv7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBarAdv8.Size = new System.Drawing.Size(167, 162);
            this.progressBarAdv8.Location = new System.Drawing.Point(741, 281);
            this.progressBarAdv8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.Location = new System.Drawing.Point(70, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.Location = new System.Drawing.Point(70, 250);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.Location = new System.Drawing.Point(69, 513);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        }

        /// <summary>
        /// Tick event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void timer1_Tick(object sender, EventArgs e)
        {
            //if (Start)
            {
                if (this.progressBarAdv1.Value < 100)
                    this.progressBarAdv1.Value += 3;
                else
                    progressBarAdv1.Value = 0;

                if (this.progressBarAdv2.Value < 100)
                    this.progressBarAdv2.Value += 3;
                else
                    progressBarAdv2.Value = 0;

                if (this.progressBarAdv4.Value < 100)
                    this.progressBarAdv4.Value += 3;
                else
                    progressBarAdv4.Value = 0;

                //if (this.progressBarAdv5.Value < 100)
                //    this.progressBarAdv5.Value += 3;
                //else
                //    progressBarAdv5.Value = 0;

                if (this.progressBarAdv6.Value < 100)
                    this.progressBarAdv6.Value += 3;
                else
                    progressBarAdv6.Value = 0;

                if (this.progressBarAdv7.Value < 100)
                    this.progressBarAdv7.Value += 3;
                else
                    progressBarAdv7.Value = 0;

                if (this.progressBarAdv8.Value < 100)
                    this.progressBarAdv8.Value += 3;
                else
                    progressBarAdv8.Value = 0;

                if (this.progressBarAdv3.Value < 80)
                    this.progressBarAdv3.Value += 2;
                else
                {
                    progressBarAdv3.Value = 10;
                    if ((this.progressBarAdv3.Renderer as CustomViewRenderer).Animation == "Left to Right")
                        (this.progressBarAdv3.Renderer as CustomViewRenderer).Animation = "Right to Left";
                    else
                        (this.progressBarAdv3.Renderer as CustomViewRenderer).Animation = "Left to Right";
                }
            }

            if (!(progressBarAdv5.Renderer as CustomShapesRenderer).Pause)
            {
                if (this.progressBarAdv5.Value < 100)
                    this.progressBarAdv5.Value += 3;
                else
                    progressBarAdv5.Value = 0;
            }

        }
        #endregion
    }
    #endregion
}