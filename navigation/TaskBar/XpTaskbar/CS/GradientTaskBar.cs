#region Copyright Syncfusion Inc. 2001 - 2014
//
//  Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

using Syncfusion.Windows.Forms.Tools;

namespace TaskBar
{
	/// <summary>
	/// Summary description for GradientTaskBar.
	/// </summary>
	public class GradientTaskBar : XPTaskBar
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private Image blendImage;
		private Color gradientStartColor;
		private Color gradientEndColor;

		public GradientTaskBar(System.ComponentModel.IContainer container)
		{
			/// <summary>
			/// Required for Windows.Forms Class Composition Designer support
			/// </summary>
			container.Add(this);
			InitializeComponent();
			
			gradientStartColor = Color.FromArgb(255, 237, 241, 242);
			gradientEndColor = Color.FromArgb(255, 42, 78, 129);
			
			// Activates double buffering
			SetStyle(ControlStyles.UserPaint, true);
			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			SetStyle(ControlStyles.DoubleBuffer, true);
			SetStyle(ControlStyles.ResizeRedraw, true);
		}

		public GradientTaskBar()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			gradientStartColor = Color.FromArgb(255, 237, 241, 242);
			gradientEndColor = Color.FromArgb(255, 42, 78, 129);

			// Activates double buffering
			SetStyle(ControlStyles.UserPaint, true);
			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			SetStyle(ControlStyles.DoubleBuffer, true);
		}
		
		[Browsable(true),
		Category("Appearance"),
		Description("Gradient starting color (used at the left edge)")]		
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public Color GradientStartColor
		{
			get
			{
				return gradientStartColor;
			}
			
			set
			{
				this.gradientStartColor = value;
				Invalidate();
			}
		}

		[Browsable(true),
		Category("Appearance"),
		Description("Gradient ending color")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public Color GradientEndColor
		{
			get
			{
				return gradientEndColor;
			}
			
			set
			{
				this.gradientEndColor = value;
				Invalidate();
			}
		}

		[Browsable(true),
		Category("Appearance"),
		Description("Background image to be blended in at the bottom of the panel")]		
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public Image BlendImage
		{
			get
			{
				return blendImage;
			}
			
			set
			{
				this.blendImage = value;
				Invalidate();
			}
		}

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
		}
		
		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
		
		protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
		{
            Rectangle rc = this.ClientRectangle;
            int gradientWidth = rc.Width;
            LinearGradientBrush linGrBrush = new System.Drawing.Drawing2D.LinearGradientBrush(
                new Point(0, 10),
                new Point(gradientWidth, 10),
                gradientStartColor,
                gradientEndColor);

            float[] positions = { 0.0f, 0.05f, 0.95f, 1.0f };
            float[] factors = { 0.4f, 1.0f, 0.5f, 0.4f };

            //Create a Blend object and assign it to linGrBrush.
            Blend blend = new Blend();
            blend.Factors = factors;
            blend.Positions = positions;
            linGrBrush.Blend = blend;

            // draw the gradient on the left edge
            e.Graphics.FillRectangle(linGrBrush, 0, 0, gradientWidth + 5, rc.Height);

            // draw a filled rectangle rest of the area
            using (Brush brush = new SolidBrush(gradientEndColor))
            {
                e.Graphics.FillRectangle(brush, gradientWidth, 0, rc.Width - gradientWidth, rc.Height);
            }
            linGrBrush.Dispose();


            // get the image from a resource file
            if (blendImage != null)
            {
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cm = new ColorMatrix();
                cm.Matrix00 = 1;
                cm.Matrix11 = 1;
                cm.Matrix22 = 1;
                float transparancy = .14f;
                cm.Matrix33 = transparancy;
                ia.SetColorMatrix(cm);
                int imgWidth = blendImage.Width;
                int imgHeight = blendImage.Height;
                Rectangle destRect = new Rectangle(rc.Width - imgWidth, rc.Height - imgHeight,
                    imgWidth, imgHeight);
                e.Graphics.DrawImage(blendImage, destRect, 0, 0, imgWidth, imgHeight,
                    GraphicsUnit.Pixel, ia);
            }
		}
	}
}
