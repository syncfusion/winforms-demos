#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Syncfusion.Windows.Forms.Grid;
using System.Runtime.Serialization;
using System.Drawing;
using Syncfusion.Windows.Forms;
using System.Windows.Forms;
using System.ComponentModel;
using Syncfusion.Drawing;

namespace OutlookDemo_2010
{
    class OutlookCell
    {
        /// <summary>
        /// Implements the data / model part of a column header with sort indicator.
        /// </summary>
        /// <remarks>
        /// You typically access cell models through the <see cref="GridModel.CellModels"/>
        /// property of the <see cref="GridModel"/> class.<para/>
        /// A <see cref="OutlookHeaderCellModel"/> can serve as model for several <see cref="OutlookHeaderCellRenderer"/>
        /// instances if there are several <see cref="GridControlBase"/> views for a <see cref="GridModel"/>.
        /// <para/>
        /// See <see cref="OutlookHeaderCellRenderer"/> for more detailed information about this cell type.
        /// </remarks>
        [Serializable]
        public class OutlookHeaderCellModel : GridOriginalTextBoxCellModel
        {
            /// <overload>
            /// Initializes a new <see cref="OutlookHeaderCellModel"/> object.
            /// </overload>
            /// <summary>
            /// Initializes a new <see cref="OutlookHeaderCellModel"/> object 
            /// and stores a reference to the <see cref="GridModel"/> this cell belongs to.
            /// </summary>
            /// <param name="grid">The <see cref="GridModel"/> for this cell model.</param>    
            /// <remarks>
            /// You typically access cell models through the <see cref="GridModel.CellModels"/>
            /// property of the <see cref="GridModel"/> class.
            /// </remarks>
            public OutlookHeaderCellModel(GridModel grid)
                : base(grid)
            {
            }

            /// <summary>
            /// Initializes a new <see cref="OutlookHeaderCellModel"/> from a serialization stream.
            /// </summary>
            /// <param name="info">An object that holds all the data needed to serialize or deserialize this instance.</param>
            /// <param name="context">Describes the source and destination of the serialized stream specified by info. </param>
            protected OutlookHeaderCellModel(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }

            /// <summary>
            /// This is called from GridStyleInfo.GetFormattedText. 
            /// </summary>
            /// <param name="style">The <see cref="GridStyleInfo"/> object that holds cell information.</param>
            /// <param name="value">The value to format.</param>
            /// <param name="textInfo">textInfo is a hint who is calling, default is GridCellBaseTextInfo.DisplayText.</param>
            /// <returns>The formatted test for the gives value.</returns>
            public override string GetFormattedText(GridStyleInfo style, object value, int textInfo)
            {
                GridStyleInfo styleColumn = Grid.ColStyles[((GridStyleInfoIdentity)style.Identity).ColIndex];
                string desc = styleColumn.Description;
                if (desc.Length > 0)
                    return desc;
                return base.GetFormattedText(style, value, textInfo);
            }

            /// <override/>
            /// <summary>Creates a renderer for this cell model.</summary>
            /// <param name="control">The grid control.</param>
            /// <returns>Cell renderer.</returns>
            public override GridCellRendererBase CreateRenderer(GridControlBase control)
            {
                return new OutlookHeaderCellRenderer(control, this);
            }

            /// <summary>
            /// Calculates the preferred size of the cell based on its contents without margins and any buttons.
            /// </summary>
            /// <param name="g">The <see cref="System.Drawing.Graphics"/> context of the canvas.</param>
            /// <param name="rowIndex">The row index.</param>
            /// <param name="colIndex">The column index.</param>
            /// <param name="style">The <see cref="GridStyleInfo"/> object that holds cell information.</param>
            /// <param name="queryBounds">grsphical bounds</param>
            /// <returns>The optimal size of the cell.</returns>
            /// <override/>
            protected override Size OnQueryPrefferedClientSize(Graphics g, int rowIndex, int colIndex, GridStyleInfo style, GridQueryBounds queryBounds)
            {
                Size size = base.OnQueryPrefferedClientSize(g, rowIndex, colIndex, style, queryBounds);
                size.Width += 12; // for sort triangle
                return size;
            }
        }
        /// <summary>
        /// Implements the CellRenderer for the OutlookHeaderCellRenderer.
        /// </summary>
        public class OutlookHeaderCellRenderer : GridOriginalTextBoxCellRenderer
        {
            private GridCellButton pushButton;
            private GridRangeInfo hoverRange = GridRangeInfo.Empty;
            GridRangeInfo range = null;
            bool mouseDown = false;
            bool inMouseDownRange = false;
            bool drawPressed = false;
            ThemedHeaderDrawing.HeaderState state = ThemedHeaderDrawing.HeaderState.Normal;
            private GridRangeInfo mouseDownRange = GridRangeInfo.Empty;
            static readonly BrushInfo defaultInterior1 = new BrushInfo(GradientStyle.Vertical, Color.FromArgb(203, 199, 184), Color.FromArgb(238, 234, 216));

            private GridControlBase gridBase;
            private Rectangle r1;
            private int sortIconSize = 12;
            Pen pen = new Pen(Color.Red);

            /// <summary>
            /// Initializes a new <see cref="OutlookHeaderCellRenderer"/> object.
            /// </summary>
            /// <param name="grid">Instance of gridcontrolbase.</param>
            /// <param name="cellModel">The cellmodel of this renderer.</param>
            public OutlookHeaderCellRenderer(GridControlBase grid, GridCellModelBase cellModel)
                : base(grid, cellModel)
            {
                this.gridBase = grid;
                AddButton(pushButton = new GridCellButton(this));
            }

            private Dictionary<int, string> firstString = new Dictionary<int, string>();
            public Dictionary<int,string> FirstString
            {
                get
                {
                    return firstString;
                }
                set
                {
                    firstString = value;
                }
            }
            public List<int> unreadMessage = new List<int>();
            /// <summary>
            /// overriden to draw the border style of the cell.
            /// </summary>
            /// <param name="g">graphics associated with the control</param>
            /// <param name="clRect">clientrectangle of the cell</param>
            /// <param name="rowIndex">rowindex of the cell</param>
            /// <param name="colIndex">colindex of the cell</param>
            /// <param name="style">style information of this cell</param>
            protected override void OnDraw(Graphics g, Rectangle clRect, int rowIndex, int colIndex, GridStyleInfo style)
            {
                base.OnDraw(g, clRect, rowIndex, colIndex, style);
            }
            protected override void OnClick(int rowIndex, int colIndex, MouseEventArgs e)
            {
                Rectangle rect = this.Grid.RangeInfoToRectangle(GridRangeInfo.Cell(rowIndex, colIndex));
                rect.Width = 50;
                if (unreadMessage != null)
                {
                    if (unreadMessage.Contains(rowIndex))
                        unreadMessage.Remove(rowIndex);
                }
                if (rect.Contains(e.Location))
                {
                    if (unreadMessage.Contains(rowIndex))
                        unreadMessage.Remove(rowIndex);
                    else
                        unreadMessage.Add(rowIndex);
                }
                clickedRow = rowIndex;
                clickedCol = colIndex;
                base.OnClick(rowIndex, colIndex, e);
                this.Grid.RefreshRange(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex, colIndex));
            }
            int clickedRow, clickedCol = 0;
            protected override void OnMouseMove(int rowIndex, int colIndex, MouseEventArgs e)
            {
                Rectangle range = this.Grid.RangeInfoToRectangle(GridRangeInfo.Cell(rowIndex,colIndex));
                range.Width = 50;
                
                if (range.Contains(e.Location))
                {
                    
                }
                moveRowIndex = rowIndex;
                moveColIndex = colIndex;
                base.OnMouseMove(rowIndex, colIndex, e);
            }


            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutlookForm));
            int moveRowIndex = 0, moveColIndex = 0;

            protected override void OnMouseHoverEnter(int rowIndex, int colIndex)
            {
                moveRowIndex = rowIndex;
                moveColIndex = colIndex;
                base.OnMouseHoverEnter(rowIndex, colIndex);
            }
            protected override void OnMouseHoverLeave(int rowIndex, int colIndex, EventArgs e)
            {
                Rectangle clRect = this.Grid.RangeInfoToRectangle(GridRangeInfo.Cell(rowIndex, colIndex));
                Rectangle closeImage = new Rectangle(clRect.X + clRect.Width - 25, clRect.Y + 22, 21, 21);
                Rectangle flagImage = new Rectangle(clRect.X + clRect.Width - 50, clRect.Y + 2, 21, 21);

                using (Graphics g = this.Grid.CreateGridGraphics())
                {
                    if (moveRowIndex == rowIndex && moveColIndex == colIndex)
                    {
                        g.FillRectangle(Brushes.White, closeImage);
                        g.FillRectangle(Brushes.White, flagImage);
                    }
                    g.Dispose();
                }
                this.Grid.RefreshRange(GridRangeInfo.Cells(rowIndex, colIndex,rowIndex, colIndex));
                base.OnMouseHoverLeave(rowIndex, colIndex, e);
            }
            protected override void OnMouseHover(int rowIndex, int colIndex, MouseEventArgs e)
            {                
                moveRowIndex = rowIndex;
                moveColIndex = colIndex;
                int result = 0;
                GridStyleInfo style = this.Grid.Model[rowIndex, colIndex];
                if (int.TryParse(style.ValueMember, out result))
                {
                    if (!unreadMessage.Contains(rowIndex))
                        unreadMessage.Add(rowIndex);
                }
                SolidBrush secondBrush = new SolidBrush(ColorTranslator.FromHtml("#006FC4"));
                Rectangle clRect = this.Grid.RangeInfoToRectangle(GridRangeInfo.Cell(rowIndex, colIndex));
                Rectangle closeImage = new Rectangle(clRect.X + clRect.Width - 25, clRect.Y + 20, 20, 20);
                Rectangle flagImage = new Rectangle(clRect.X + clRect.Width - 50, clRect.Y + 2, 20, 20);
                Rectangle rect = new Rectangle(clRect.X, clRect.Y, 50, clRect.Height);
                Color clr = Color.FromArgb(230, 242, 250);// ;
                using (Graphics g = this.Grid.CreateGraphics())
                {
                    if (moveRowIndex == rowIndex && moveColIndex == colIndex)
                    {
                        if (this.Grid.Model.ColWidths[colIndex] <= 400)
                        {
                            if (hoveredFlag)
                            {
                                if (clickedRow == rowIndex)
                                    clr = ColorTranslator.FromHtml("#CDE6F7");
                                g.FillRectangle(new SolidBrush(clr), flagImage);
                                hoveredFlag = false;
                            }
                            if (hoveredClose)
                            {
                                if (clickedRow == rowIndex)
                                    clr = ColorTranslator.FromHtml("#CDE6F7");
                                g.FillRectangle(new SolidBrush(clr), closeImage);
                                hoveredClose = false;
                            }
                        }
                        if (closeImage.Contains(e.Location))
                        {
                            if (clickedRow == rowIndex)
                                clr = ColorTranslator.FromHtml("#CDE6F7");
                            g.FillRectangle(new SolidBrush(clr), closeImage);
                            g.DrawImage(global::OutlookDemo_2010.Properties.Resources.Run_rules_now, closeImage);
                            hoveredClose = true;
                        }
                        else
                            g.DrawImage(global::OutlookDemo_2010.Properties.Resources.delete, closeImage);//Change icon here.
                        if (flagImage.Contains(e.Location))
                        {
                            if (clickedRow == rowIndex)
                                clr = ColorTranslator.FromHtml("#CDE6F7");
                            g.FillRectangle(new SolidBrush(clr), flagImage);
                            g.DrawImage(global::OutlookDemo_2010.Properties.Resources.Run_rules_now1, flagImage);
                            hoveredFlag = true;
                        }
                        else
                            g.DrawImage(global::OutlookDemo_2010.Properties.Resources.flag, flagImage);//change icon here.

                    }
                    g.Dispose();
                }
                base.OnMouseHover(rowIndex, colIndex, e);
            }
            bool hoveredFlag, hoveredClose = false;
            /// <summary>
            /// overriden to invalidate the mousedown cellrange
            /// </summary>
            /// <param name="rowIndex">rowIndex of this cell in grid</param>
            /// <param name="colIndex">colIndex of this cell in grid</param>
            /// <param name="e">mouse event data</param>
            protected override void OnMouseDown(int rowIndex, int colIndex, MouseEventArgs e)
            {
                GridRangeInfo range = GridRangeInfo.Cell(rowIndex, colIndex);
                if (!range.IsEmpty)
                {
                    Grid.Model.GetSpannedRangeInfo(range.Top, range.Left, out this.mouseDownRange);
                    GridStyleInfo style = this.Grid.Model[range.Top, range.Left];
                    if (!style.Clickable || this.Grid.CellRenderers[style.CellType] != this)
                    {
                        this.mouseDownRange = GridRangeInfo.Empty;
                    }
                }

                this.mouseDown = !mouseDownRange.IsEmpty;
                this.hoverRange = GridRangeInfo.Empty;
                if (this.mouseDown)
                {
                    this.inMouseDownRange = true;
                    this.Grid.InvalidateRange(this.mouseDownRange);
                }
                base.OnMouseDown(rowIndex, colIndex, e);
            }

            /// <summary>
            /// overriden to invalidate the clicked header cellrange.
            /// </summary>
            /// <param name="rowIndex">rowIndex of this cell in grid</param>
            /// <param name="colIndex">colIndex of this cell in grid</param>
            /// <param name="e">Mouse event data</param>
            protected override void OnMouseUp(int rowIndex, int colIndex, MouseEventArgs e)
            {
                if (this.mouseDown)
                {
                    this.mouseDown = false;
                    this.Grid.InvalidateRange(this.mouseDownRange);
                    this.mouseDownRange = GridRangeInfo.Empty;
                }
                base.OnMouseUp(rowIndex, colIndex, e);
            }

            /// <summary>
            /// overriden to draw the button for this cell.
            /// </summary>
            /// <param name="button">instance of the gridcellbutton to be drawn</param>
            /// <param name="g">graphics associated with this control</param>
            /// <param name="rowIndex">rowIndex of this cell in grid</param>
            /// <param name="colIndex">colIndex of this cell in grid</param>
            /// <param name="bActive">boolean value</param>
            /// <param name="style">style information of this cell</param>
            protected override void OnDrawCellButton(GridCellButton button, Graphics g, int rowIndex, int colIndex, bool bActive, GridStyleInfo style)
            {
                Point ptOffset = new Point(1, 1);
                GridProperties propertyObject = Grid.Model.Properties;

                Rectangle faceRect = button.Bounds;
                faceRect.Inflate(-2, -1);
            }

            
         

            /// <summary>
            /// overriden to preapre the layout appearance of the cell.
            /// </summary>
            /// <param name="rowIndex">rowIndex of this cell in grid</param>
            /// <param name="colIndex">colIndex of this cell in grid</param>
            /// <param name="style">style information of the cell</param>
            /// <param name="innerBounds">inner text rectangle area</param>
            /// <param name="buttonsBounds">button bounds for the associated button in control</param>
            /// <returns></returns>
            protected override Rectangle OnLayout(int rowIndex, int colIndex, GridStyleInfo style, Rectangle innerBounds, Rectangle[] buttonsBounds)
            {
                Rectangle buttonArea;
                int buttonWidth = 18;

                bool isTextRightToLeft = (style.RightToLeft == RightToLeft.Inherit && Grid.IsRightToLeft()) || style.RightToLeft == RightToLeft.Yes;
                //Button area customization...........
                if (!isTextRightToLeft)
                {
                    buttonArea = Rectangle.FromLTRB(innerBounds.Location.X + sortIconSize, innerBounds.Location.Y, innerBounds.Right + buttonWidth + sortIconSize, innerBounds.Bottom);
                }
                else
                {
                    buttonArea = Rectangle.FromLTRB(innerBounds.Location.X, innerBounds.Location.Y, innerBounds.Left + buttonWidth, innerBounds.Bottom);
                }
                buttonsBounds[0] = GridUtil.CenterInRect(buttonArea, new Size(buttonWidth, 20));
                r1 = buttonArea;

                return innerBounds;
            }

            /// <summary>
            /// overriden to raise the pushbutton click.
            /// </summary>
            /// <param name="rowIndex">rowIndex of this cell in grid</param>
            /// <param name="colIndex">colIndex of this cell in grid</param>
            /// <param name="button">clicked button</param>
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
    }
}
