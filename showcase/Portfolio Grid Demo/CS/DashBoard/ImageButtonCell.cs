#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
# region Directives

using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

using Syncfusion.Diagnostics;
using Syncfusion.Windows.Forms.Grid;
#endregion
namespace PortfolioManager
{
    #region CellModel
    public class GridPushButtonImageCellModel : GridPushButtonCellModel
    {
        protected GridPushButtonImageCellModel(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public GridPushButtonImageCellModel(GridModel grid)
            : base(grid)
        {
        }

        public override GridCellRendererBase CreateRenderer(GridControlBase control)
        {
            return new GridPushButtonImageCellRenderer(control, this);
        }

    }
    #endregion
    #region CellRenderer


    public class GridPushButtonImageCellRenderer : GridPushButtonCellRenderer
    {
        private ImageCellButton pushButton;

        public GridPushButtonImageCellRenderer(GridControlBase grid, GridPushButtonImageCellModel cellModel)
            : base(grid, cellModel)
        {
            base.RemoveButton(base.GetButton(0));
            AddButton(pushButton = new ImageCellButton(this));
        }
    }
    #endregion
    #region ImageCellButton
    public class ImageCellButton : GridCellButton
    {
        static GridIconPaint iconPainter;

        static ImageCellButton()
        {
            iconPainter = new GridIconPaint("PortfolioManager.", typeof(ImageCellButton).Assembly);

        }


        public ImageCellButton(GridPushButtonCellRenderer control)
            : base(control)
        {
            
        }


        public override void Draw(Graphics g, int rowIndex, int colIndex, bool bActive, GridStyleInfo style)
        {
            base.Draw(g, rowIndex, colIndex, bActive, style);

            // draw the button
            bool hovering = IsHovering(rowIndex, colIndex);
            bool mouseDown = IsMouseDown(rowIndex, colIndex);
            bool disabled = !style.Clickable;

            ButtonState buttonState = ButtonState.Normal;
            if (disabled)
                buttonState |= ButtonState.Inactive | ButtonState.Flat;

            else if (!hovering && !mouseDown)
                buttonState |= ButtonState.Flat;

            Point ptOffset = Point.Empty;
            if (mouseDown)
            {
                ptOffset = new Point(1, 1);
                buttonState |= ButtonState.Pushed;
            }
           
            DrawButton(g, Bounds, buttonState, style);

            Image img = Image.FromFile(@"..\\..\\Images\delete.png");
            Bitmap bmp = img as Bitmap;
            Rectangle r = iconPainter.PaintIcon(g, Bounds, ptOffset, bmp, Color.Black);

        }
    }
    #endregion
}
