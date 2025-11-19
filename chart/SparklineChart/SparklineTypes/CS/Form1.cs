#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace SparklineTypes_2008
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            BorderColor = Color.FromArgb(0xFF, 0xCD, 0xCD, 0xCD);
            BorderThickness = 3;
            CaptionBarHeight = 75;
            CaptionBarColor = Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2);
            CaptionFont = new Font("Segoe UI", 22.0f);
            CaptionForeColor = Color.White;
            CaptionAlign = HorizontalAlignment.Left;
            ShowIcon = false;
            CaptionButtonColor = Color.White;
            CaptionButtonHoverColor = Color.White;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.sparkLine1.LineStyle.LineColor = Color.FromArgb(51, 204, 255);
            this.sparkLine1.Source = new double[] { 12, 14, 11, 12, 11, 15, 12, 10, 11, 12, 15, 13, 12, 11, 10, 13, 15, 12, 14, 16, 14, 12, 11 };

            this.sparkLine2.Source = new double[] { 2, 6, -1, 1, 12, 5, -2, 7, -3, 5, 8, 10 };
            this.sparkLine2.Markers.ShowNegativePoint = true;
            this.sparkLine2.Markers.ShowHighPoint = true;
            this.sparkLine2.ColumnStyle.ColumnColor = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(51, 204, 255));
            this.sparkLine2.Markers.HighPointColor = new Syncfusion.Drawing.BrushInfo(Color.Blue);
            this.sparkLine2.Markers.NegativePointColor = new Syncfusion.Drawing.BrushInfo(Color.Red);

            this.sparkLine3.Source = new double[] { 12, 15, -11, 13, 17, 0, -12, 17, 13, -15, 8, 10 };
            this.sparkLine3.Markers.ShowNegativePoint = true;
            this.sparkLine3.ColumnStyle.ColumnColor = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(51, 204, 255));
            this.sparkLine3.Markers.NegativePointColor = new Syncfusion.Drawing.BrushInfo(Color.Red);

            this.label1.AutoSize = false;
            this.label1.Anchor = AnchorStyles.Right;
            this.label1.TextAlign = ContentAlignment.MiddleCenter;

            this.label2.AutoSize = false;
            this.label2.Anchor = AnchorStyles.Right;
            this.label2.TextAlign = ContentAlignment.MiddleCenter;

            this.label3.AutoSize = false;
            this.label3.Anchor = AnchorStyles.Right;
            this.label3.TextAlign = ContentAlignment.MiddleCenter;
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
