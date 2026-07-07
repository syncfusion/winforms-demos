#region Copyright Syncfusion Inc. 2001 - 2015
//
//  Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Drawing;

namespace PivotGridLibrary
{
    public class IconDrawingSupport
    {

        static GridIconPaint iconPainter;

        static IconDrawingSupport()
		{
            iconPainter = new GridIconPaint("PivotGridControl.", typeof(IconDrawingSupport).Assembly);
		}

        public static void DrawImage(Graphics g, string imageFileName, Rectangle rect, Point offSet)
        {
            string prefix = "icons."; //folder in project where the bitmaps are located
            string bitmapName = prefix + imageFileName;

            iconPainter.PaintIcon(g, rect, offSet, bitmapName, Color.Black);
        }

        /// <summary>
        /// Bitmap for moving rows.
        /// </summary>
        public static Bitmap RedLeftBitmap
        {
            get
            {
                return iconPainter.GetBitmap("icons.RedLeftArrow.bmp");
            }
        }

        /// <summary>
        /// Bitmap for moving rows.
        /// </summary>
        public static Bitmap RedRightBitmap
        {
            get
            {
                return iconPainter.GetBitmap("icons.RedRightArrow.bmp");
            }
        }

    }

}
