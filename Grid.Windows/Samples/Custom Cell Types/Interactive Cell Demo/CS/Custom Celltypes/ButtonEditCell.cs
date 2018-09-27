using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.ComponentModel;

using Syncfusion.Diagnostics;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Styles;
using Syncfusion.Drawing;
using Syncfusion.ComponentModel;


namespace InteractiveCellDemo
{
	/// <summary>
	/// Implements the data/model part for a ButtonEdit cell
	/// </summary>
	/// 

	#region CellModel
	[Serializable]
	public class ButtonEditCellModel: GridTextBoxCellModel
	{
		/// <summary>
		/// Represents the method that handles the <see cref="ButtonEditCellModel.GridDrawButtonFace"/> event.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">A <see cref="ButtonEditCell.GridDrawButtonFaceEventArgs"/> that contains the event data.</param>
		public delegate void GridDrawButtonFaceEventHandler(object sender, GridDrawButtonFaceEventArgs e);


		/// <summary>
		/// Occurs before the Grid draws the ButtonEdit face
		/// </summary>
		/// <remarks>
		/// See <see cref="ButtonEditCell.GridDrawButtonFaceEventArgs"/> for more detailed discussion about this event.
		/// </remarks>
		[Description("Occurs just before the Grid draws the button face")]
		public event GridDrawButtonFaceEventHandler GridDrawButtonFace;


		/// <overload>
		/// Initializes a new <see cref="ButtonEditCellModel"/> object.
		/// </overload>
		/// <summary>
		/// Initializes a new <see cref="ButtonEditCellModel"/> from a serialization stream.
		/// </summary>
		/// <param name="info">An object that holds all the data needed to serialize or deserialize this instance.</param>
		/// <param name="context">Describes the source and destination of the serialized stream specified by info. </param>
		protected ButtonEditCellModel(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			base.ButtonBarSize = new Size(20, 20);

			
		}

		/// <summary>
		/// Initializes a new <see cref="ButtonEditCellModel"/> object 
		/// and stores a reference to the <see cref="GridModel"/> this cell belongs to.
		/// </summary>
		/// <param name="grid">The <see cref="GridModel"/> for this cell model.</param>	
		/// <remarks>
		/// You typically access cell models through the <see cref="GridModel.CellModels"/>
		/// property of the <see cref="GridModel"/> class.
		/// </remarks>
		public ButtonEditCellModel(GridModel grid)
			: base(grid)
		{
		}

		/// <override/>
		public override GridCellRendererBase CreateRenderer(GridControlBase control)
		{
			return new ButtonEditCellRenderer(control, this);
		}

		/// <summary>
		/// Raises the <see cref="GridDrawButtonFace"/> event
		/// </summary>
		/// <param name="e"><see cref="GridDrawButtonFaceEventArgs"/> data</param>
		public void RaiseDrawButtonFace(GridDrawButtonFaceEventArgs e)
		{
			if(e == null)
				return;
			if(this.GridDrawButtonFace != null)
			    this.GridDrawButtonFace(this, e);
		}


		// To do

		//		/// <override/>
		//		protected override Size OnQueryPrefferedClientSize(Graphics g, int rowIndex, int colIndex, GridStyleInfo style, GridQueryBounds GridQueryBounds)
		//		{ 
		//			Size size = base.OnQueryPrefferedClientSize(g, rowIndex, colIndex, style, GridQueryBounds);
		//			return new Size(size.Width + 20, size.Height); // base method already consides ButtonBarSize, but let's add some more pixels here.
		//		}
	}

	# endregion

	#region CellRenderer
	/// <summary>
	/// Implements the renderer part for the ButtonEditCellRenderer
	/// </summary>
	/// 
	public class ButtonEditCellRenderer : GridTextBoxCellRenderer
	{
		/// <summary>
		/// Initializes a new <see cref="ButtonEditCellRenderer"/> object for the given GridControlBase
		/// and <see cref="ButtonEditCellModel"/>.
		/// </summary>
		/// <param name="grid">The <see cref="GridControlBase"/> that display this cell renderer.</param>
		/// <param name="cellModel">The <see cref="ButtonEditCellModel"/> that holds data for this cell renderer that should
		/// be shared among views.</param>
		/// <remarks>References to GridControlBase, 
		/// and GridTextBoxCellModel will be saved.</remarks>
		public ButtonEditCellRenderer(GridControlBase grid, GridTextBoxCellModel cellModel)
			: base(grid, cellModel)
		{
			AddButton(new ButtonEditCellButton(this));
		}

		/// <override/>
		protected override Rectangle OnLayout(int rowIndex, int colIndex, GridStyleInfo style, Rectangle innerBounds, Rectangle[] buttonsBounds)
		{

			ButtonEditStyleProperties sp = new ButtonEditStyleProperties(style);	
			bool isRightToLeft = false;
			
			if(this.Grid.RightToLeft == RightToLeft.Inherit && Grid.IsRightToLeft() || style.RightToLeft == RightToLeft.Yes)
				isRightToLeft = true;

			// Here you specify where the button should be drawn within the cell.
			if(sp.ButtonEditInfo.IsLeft ^ isRightToLeft)
			{
				// Draw left
				Rectangle rightArea = Rectangle.FromLTRB(innerBounds.Left, innerBounds.Top, innerBounds.Left + sp.ButtonEditInfo.Width, innerBounds.Bottom);
				buttonsBounds[0] = GridUtil.CenterInRect(rightArea, new Size(sp.ButtonEditInfo.Width, 20));

				// Here you return the area where the text should be drawn/edited.
				innerBounds.Width -= sp.ButtonEditInfo.Width;
				innerBounds.Offset(sp.ButtonEditInfo.Width,0);
			}
			else
			{
				// Draw right
				// Here you specify where the button should be drawn within the cell.
				Rectangle rightArea = Rectangle.FromLTRB(innerBounds.Right-sp.ButtonEditInfo.Width, innerBounds.Top, innerBounds.Right, innerBounds.Bottom);
				buttonsBounds[0] = GridUtil.CenterInRect(rightArea, new Size(sp.ButtonEditInfo.Width, 20));
			
				// Here you return the area where the text should be drawn/edited.
				innerBounds.Width -= sp.ButtonEditInfo.Width;		
			}
			return innerBounds;
		}
	}
	#endregion

	#region CellButton
	/// <summary>
	/// Defines a ButtonEdit CellButton
	/// Typically used with <see cref="ButtonEditCellRenderer"/>.
	/// </summary>
	/// 
	public class ButtonEditCellButton : GridCellButton
	{
		static GridIconPaint iconPainter;
		
		static ButtonEditCellButton()
		{
            iconPainter = new GridIconPaint("InteractiveCellDemo.", typeof(ButtonEditCellButton).Assembly);
		}

		/// <summary>
		/// Initializes a <see cref="ButtonEditCellButton"/> and associates it with a <see cref="ButtonEditCellRenderer"/>
		/// </summary>
		/// <param name="control">The <see cref="ButtonEditCellRenderer"/> that draws this cell button element.</param>
		public ButtonEditCellButton(GridTextBoxCellRenderer control)
			: base(control)
		{
		}

		/// <override/>
		public override void Draw(Graphics g, int rowIndex, int colIndex, bool bActive, GridStyleInfo style)
		{
			bool hovering = IsHovering(rowIndex, colIndex);
			bool mouseDown = IsMouseDown(rowIndex, colIndex);

			ButtonEditStyleProperties sp = new ButtonEditStyleProperties(style);
			bool disabled = !sp.ButtonEditInfo.Enabled;

			ButtonState buttonState = ButtonState.Normal;
			if (disabled)
				buttonState |= ButtonState.Inactive|ButtonState.Flat;

			else if (!hovering && !mouseDown)
				buttonState |= ButtonState.Flat;

			if (mouseDown)
			{
				buttonState |= ButtonState.Pushed;
			}

			// Draw the button
			DrawButton(g, Bounds, buttonState, style);

			// Draw the button face
			DrawButtonFace(g, buttonState, style);

		}

		/// <summary>
		/// Draws the button face
		/// </summary>
		/// <param name="g">The <see cref="System.Drawing.Graphics"/> context of the canvas.</param>
		/// <param name="buttonState">A <see cref="ButtonState"/> that specifies the current state.</param>
		/// <param name="style">The <see cref="GridStyleInfo"/> object that holds cell information.</param>
		protected virtual void DrawButtonFace(Graphics g, ButtonState buttonState, GridStyleInfo style)
		{
			GridDrawButtonFaceEventArgs e = new GridDrawButtonFaceEventArgs(this, g, style, style.CellIdentity.RowIndex, style.CellIdentity.ColIndex);
			  OnDrawButtonFace(e);

			if(!e.Handled)
				this.DrawDefaultButtonFace(g, buttonState, style);
		}

		/// <summary>
		/// Raises the <see cref="ButtonEditCellModel.GridDrawButtonFace"/> event
		/// </summary>
		/// <param name="e">An <see cref="GridDrawButtonFaceEventArgs"/>GridDrawButtonFaceEventArgs that contains event data</param>
	
		protected virtual void OnDrawButtonFace(GridDrawButtonFaceEventArgs e)
		{
			//Raise the event from CellModel
			//TODO - move to Grid instead..
	    	(this.Owner.Model as ButtonEditCellModel).RaiseDrawButtonFace(e);
		}

		/// <summary>
		/// Draws the default button face
		/// </summary>
		/// <param name="g">The <see cref="System.Drawing.Graphics"/> context of the canvas.</param>
		/// <param name="buttonState">A <see cref="ButtonState"/> that specifies the current state.</param>
		/// <param name="style">The <see cref="GridStyleInfo"/> object that holds cell information.</param>
		public void DrawDefaultButtonFace(Graphics g, ButtonState buttonState, GridStyleInfo style)
		{ 
			// Set the button style properties
			ButtonEditStyleProperties sp = new ButtonEditStyleProperties(style);

			//Button bounds
			Rectangle rect = Bounds;
			Rectangle faceRect = Rectangle.FromLTRB(rect.Left+1, rect.Top+1, rect.Right-2, rect.Bottom-2);

			bool disabled = !sp.ButtonEditInfo.Enabled;
			bool drawPressed = (buttonState & ButtonState.Pushed) != 0; 

            //Determine the Offset
			Point ptOffset = Point.Empty;

			if(drawPressed)
			 ptOffset = new Point(1, 1);

			// Draws the image based on ButtonEditInfo.ButtonEditType
            string resourceName;			
			if(sp.ButtonEditInfo.ButtonEditType != ButtonType.None)
			{
				switch(sp.ButtonEditInfo.ButtonEditType)
				{
					case ButtonType.Browse:	
						resourceName = "Browse.bmp";
						break;

					case ButtonType.Check:
						resourceName = "Check.bmp";
						break;

					case ButtonType.Down:
						resourceName = "Down.bmp";
						break;

					case ButtonType.Left:
						resourceName = "Left.bmp";
						break;

					case ButtonType.Leftend:
						resourceName = "Leftend.bmp";
						break;

					case ButtonType.Redo:
						resourceName = "Redo.bmp";
						break;

					case ButtonType.Right:
						resourceName = "Right.bmp";
						break;

					case ButtonType.Rightend:
						resourceName = "Rightend.bmp";
						break;

					case ButtonType.Undo:
						resourceName = "Undo.bmp";
						break;

					case ButtonType.Up:
						resourceName = "Up.bmp";
						break;

					default:
						resourceName = "Browse.bmp";
						break;
				}

				// Draws the image from ButtonEditInfo.Image
				if(sp.ButtonEditInfo.ButtonEditType == ButtonType.Image)
				{
					if(sp.ButtonEditInfo.Image != null)
					{
						if (!drawPressed) 
						{ 
							DrawingUtils.DrawImage(g, sp.ButtonEditInfo.Image as Image,Bounds.X+2, Bounds.Y+2, Bounds.Width-4, Bounds.Height-4);
						}
						else
						{
							DrawingUtils.DrawImage(g, sp.ButtonEditInfo.Image as Image,Bounds.X+1, Bounds.Y+1, Bounds.Width-4, Bounds.Height-4);						
						}
					}
					return;
				}

				string prefix = "ButtonImages.";
				string bitmapName = prefix + resourceName;

					// Instead of using GridIconPaint you could simple use Image.Draw here
					// with an existing bitmap. GridIconPaint is convenient because it lets
					// us easily draw over existing background and replace the black color
					// in the bitmap with a different color.

				iconPainter.PaintIcon(g, Bounds, ptOffset, bitmapName, Color.Black);
				return;
			}


			// Colored button drawing
			Color hilight = SystemColors.ControlLightLight; 
			Color shadow = SystemColors.ControlDarkDark; 
			Color draw = sp.ButtonEditInfo.BackColor;

			Brush br = new SolidBrush(draw); 

			// Colors the button only if the ForceBackColor is set (themes application)
			if(sp.ButtonEditInfo.ForceBackColor)
			{
				if(!disabled)
				{
					if (!drawPressed) 
					{ 
						g.FillRectangle(br, Bounds);
			
						if(buttonState == ButtonState.Flat)
						{
							ControlPaint.DrawBorder(g, Bounds, SystemColors.ControlDark, ButtonBorderStyle.Solid);
						}
						else
						{                	
							GridUtil.Draw3dFrame(g, rect.Left, rect.Top, rect.Right-1, rect.Bottom-1, 1, 
								hilight, shadow);
						}				
					} 
					else 
					{ 		
						g.FillRectangle(br, new Rectangle(Bounds.X+1, Bounds.Y+1, Bounds.Width, Bounds.Height));
			
						GridUtil.Draw3dFrame(g, rect.Left-1, rect.Top-1, rect.Right, rect.Bottom, 1, 
							hilight, shadow);
						br.Dispose(); 
					} 
				}
			}


    		// Draw the button text
			string text = sp.ButtonEditInfo.Text;

			if (text != null && text.Length > 0)
			{
				Font font = style.GdipFont;

				StringFormat format = new StringFormat();
				bool isRightToLeft = false;

				if(this.Grid.RightToLeft == RightToLeft.Inherit && Grid.IsRightToLeft() || style.RightToLeft == RightToLeft.Yes)
    	             isRightToLeft = true;

				if (isRightToLeft)
				{
					format.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
				}

				format.Alignment = StringAlignment.Center;
				format.LineAlignment = StringAlignment.Center;
				format.HotkeyPrefix = style.HotkeyPrefix;
				format.Trimming = style.Trimming;

				if (!style.WrapText)
					format.FormatFlags = StringFormatFlags.NoWrap;

				Color textColor = Grid.PrintingMode && Grid.Model.Properties.BlackWhite ? Color.Black : sp.ButtonEditInfo.TextColor;

				if (disabled)
				{
					DrawText(g, sp.ButtonEditInfo.Text, font, faceRect, style, textColor, true, isRightToLeft);
				}

				else
				{
					if (!drawPressed) 
					{ 
						if(buttonState == ButtonState.Flat)
						{
							DrawText(g, sp.ButtonEditInfo.Text, font, new Rectangle(faceRect.Left, faceRect.Top, faceRect.Width, faceRect.Height), style, textColor, false, isRightToLeft);
						}
						else
						{
							DrawText(g, sp.ButtonEditInfo.Text, font, new Rectangle(faceRect.Left+1, faceRect.Top+1, faceRect.Width, faceRect.Height), style, textColor, false, isRightToLeft);
						}
					}
					else
					{
		    			DrawText(g, sp.ButtonEditInfo.Text, font, faceRect, style, textColor, false, isRightToLeft);					}
					}

				format.Dispose();
			}
		}

		# region Helper methods
		//Draws the button text
		public static void DrawText(Graphics g, string displayText, Font font, Rectangle textRectangle, GridStyleInfo style, Color textColor, bool drawDisabled, bool isRightToLeft)
		{
			ButtonEditStyleProperties sp = new ButtonEditStyleProperties(style);

			Brush br = new SolidBrush(textColor);
			StringFormat format = new StringFormat();
			format.LineAlignment = GridUtil.ConvertToStringAlignment(sp.ButtonEditInfo.VerticalAlignment);
			format.Alignment = GridUtil.ConvertToStringAlignment(sp.ButtonEditInfo.HorizontalAlignment);
			if (isRightToLeft)
			{
				format.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
			}

			format.HotkeyPrefix = style.HotkeyPrefix;
			format.Trimming = style.Trimming;
			format.SetTabStops(0f, new float[]{50});

			// Note: Trimming will only work if style.WrapText = True, FloatCell = false.
			if (!style.WrapText)
				format.FormatFlags |= StringFormatFlags.NoWrap;

			int orientation = style.ReadOnlyFont.Orientation;

			if (orientation != 0)
			{
				float angle = (float) orientation;

				// Let GDI+ do text rotation.
				RotatePaint.DrawRotatedString(g, displayText, font, br, textRectangle, format, angle);
			}
			else
			{
				if (format.Alignment == StringAlignment.Far && GridControlBase.UseGdiPlusRightAlignedTextWorkaround)
				{
					if (g.TextRenderingHint == System.Drawing.Text.TextRenderingHint.SystemDefault)
					{
						int stringWidth = MeasureDisplayStringWidth(g, displayText, font);
						//if (stringWidth < textRectangle.Width)
					{
						stringWidth = Math.Min(stringWidth, textRectangle.Width);
						textRectangle = new Rectangle(textRectangle.Right - stringWidth, textRectangle.Y, stringWidth, textRectangle.Height);
						format.Alignment = StringAlignment.Near;
						format.Trimming = StringTrimming.None;
						format.FormatFlags = StringFormatFlags.NoWrap;
					}
					}
				}

				if (!drawDisabled)
				{
					g.DrawString(displayText, font, br, textRectangle, format);
				}
				else
					ControlPaint.DrawStringDisabled(g, displayText, font, textColor, textRectangle, format);
			}
			br.Dispose();
			format.Dispose();
		}

		static internal int MeasureDisplayStringWidth(Graphics graphics, string text, Font font)
		{
			RectangleF rect = RectangleF.Empty;

			using(StringFormat format = new System.Drawing.StringFormat())
			{
				rect = new System.Drawing.RectangleF(0, 0, 1000, 1000);
				CharacterRange[] ranges  = {new System.Drawing.CharacterRange(0, text.Length)};
				Region[] regions = new System.Drawing.Region[1];
				format.SetMeasurableCharacterRanges(ranges);
				regions = graphics.MeasureCharacterRanges(text, font, rect, format);
				rect = regions[0].GetBounds(graphics);
			}

			return (int)(rect.Right + 1.0f);
		}
		#endregion
	}	

/// <summary>
/// Provides data about <see cref="ButtonEditCellModel.DrawButtonFace"/> event which can be handled
/// </summary>
/// <remarks>
/// GridDrawButtonFaceEventArgs is a custom event argument class used by the
/// <see cref="ButtonEditCellModel.DrawButtonFace"/> event to allow custom drawing of
/// a buttonedit. Set the Handled property true if you have drawn the cell button contents and
/// do not want the grid to proceed with default button drawing.
/// </remarks>
/// <seealso cref="ButtonEditCellModel.GridDrawButtonFaceEventHandler"/>
 
	public sealed class GridDrawButtonFaceEventArgs : SyncfusionHandledEventArgs 
	{
		Graphics graphics;
		GridStyleInfo style;
		int rowIndex;
		int colIndex;
		ButtonEditCellButton button;

		/// <summary>
		/// Initializes new instance of the GridDrawButtonFaceEventArgs class
		/// </summary>
		/// <param name="Button">Reference to <see cref="ButtonEditCellButton"/></param>
		/// <param name="Graphics">Graphics context</param>
		/// <param name="Style">The <see cref="GridStyleInfo"/> object that holds cell information.</param>
		/// <param name="RowIndex">The row index</param>
		/// <param name="ColIndex">The col index</param>
		/// <param name="Handled"></param>
		public GridDrawButtonFaceEventArgs(ButtonEditCellButton Button, Graphics Graphics, GridStyleInfo Style, int RowIndex, int ColIndex) 
		{
			this.graphics = Graphics;
			this.style = Style;
			this.rowIndex = RowIndex;
			this.colIndex = ColIndex;
			this.button = Button;
		}

		/// <summary>
		/// The <see cref="ButtonEditButton"/> that is associated with the cell
		/// </summary>
		/// <remarks>
		/// If you do not set <see cref="GridDrawButtonFaceEventArgs.Handled"/> to True, this buttons's <see cref="ButtonEditCellButton.DrawDefaultButtonFace"/> 
		/// will get called.
		/// </remarks>
		[TraceProperty(true)]	
		public ButtonEditCellButton Button
		{
			get
			{
				return this.button;
			}
		}
	    /// <summary>
	    /// Graphics context
	    /// </summary>
		[TraceProperty(true)]
		public Graphics Graphics
		{
			get
			{
				return this.graphics;
			}
		}
		
		/// <summary>
		/// The style object associated with that cell.
		/// </summary>
		[TraceProperty(true)]
		public GridStyleInfo Style
		{
			get
			{
				return style;
			}

		}
			
		/// <summary>
		/// The row index
		/// </summary>
		[TraceProperty(true)]
		public int RowIndex
		{
			get
			{
				return rowIndex;
			}
		}
			
		/// <summary>
		/// The col index
		/// </summary>
		[TraceProperty(true)]
		public int ColIndex
		{
			get
			{
				return colIndex;
			}
		}
	}
	#endregion
}