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
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Grid;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace PivotGridLibrary
{
    #region CellModel

    public class PivotButtonCellModel : GridStaticCellModel
    {
        public PivotButtonCellModel(GridModel grid)
			: base(grid)
		{
		}

        public override GridCellRendererBase CreateRenderer(GridControlBase control)
        {
            return new PivotButtonCellRenderer(control, this);
        }
    }
    #endregion

    #region Cell Renderer

    public class PivotButtonCellRenderer : GridStaticCellRenderer
    {
        private GridCellButton pushButton;

        public PivotButtonCellRenderer(GridControlBase grid, GridCellModelBase cellModel)
			: base(grid, cellModel)
        {
           AddButton(pushButton = new GridCellButton(this));
            //AddButton(pushButton = new GridDataBoundTreeCellButton(this));
            this.ForceRefreshOnActivateCell = true;
        }

        protected override Rectangle OnLayout(int rowIndex, int colIndex, GridStyleInfo style, Rectangle innerBounds, Rectangle[] buttonsBounds)
        {
            int buttonWidth = 11;
            int buttonHeight = 10;
            buttonsBounds[0] = GridUtil.CenterInRect(new Rectangle(innerBounds.X, innerBounds.Y, buttonWidth + 5, buttonHeight + 5), new Size(buttonWidth, buttonHeight));
            pushButton.Text = style.Description;
            innerBounds = new Rectangle(innerBounds.X + buttonWidth + 2, innerBounds.Y, innerBounds.Width - buttonWidth, innerBounds.Height);
            return innerBounds;
        }

        /// <override/>
        protected /*internal*/ override void OnOutlineCurrentCell(Graphics g, Rectangle r)
        {
            // do nothing
        }

        /// <override/>
        protected override bool OnQueryShowButtons(int rowIndex, int colIndex, GridStyleInfo style)
        {
            return true;
        }

        protected override void OnDrawCellButton(GridCellButton button, Graphics g, int rowIndex, int colIndex, bool bActive, GridStyleInfo style)
        {

            //directly call the draw to avoid base class and focus rectangle...
            button.Text = "";
            button.Draw(g, rowIndex, colIndex, false, style);

            Rectangle faceRect = button.Bounds;
            faceRect.Inflate(-2, -1);
            string text = style.Description;
            if (text != null && text.Length > 0)
            {
                using (Font font = new Font(style.Font.Facename, (float)7.0))
                {

                    StringFormat format = new StringFormat();
                    format.Alignment = StringAlignment.Center;
                    format.LineAlignment = StringAlignment.Center;
                    format.HotkeyPrefix = style.HotkeyPrefix;
                    format.Trimming = style.Trimming;
                    if (!style.WrapText)
                        format.FormatFlags = StringFormatFlags.NoWrap;

                    Color textColor = Grid.PrintingMode && Grid.Model.Properties.BlackWhite ? Color.Black : style.TextColor;

                    g.DrawString(text, font, new SolidBrush(textColor), faceRect, format);
                }
            }
            //base.OnDrawCellButton(button, g, rowIndex, colIndex, false, style);
        }
        /// <override/>
        protected override void OnButtonClicked(int rowIndex, int colIndex, int button)
        {
            base.OnButtonClicked(rowIndex, colIndex, button);
            OnPushButtonClick(rowIndex, colIndex);
        }

      
        /// <summary>
        /// Raises <see cref="GridControlBase.PushButtonClick"/> event when the user presses the PushButton.
        /// </summary>
        /// <param name="rowIndex">Specifies the row id.</param>
        /// <param name="colIndex">Specifies the column id.</param>
        protected virtual void OnPushButtonClick(int rowIndex, int colIndex)
        {
            Grid.RaisePushButtonClick(rowIndex, colIndex);
        }
    }
    #endregion
}
