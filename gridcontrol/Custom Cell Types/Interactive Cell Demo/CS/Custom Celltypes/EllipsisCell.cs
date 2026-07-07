#region Copyright Syncfusion Inc. 2001 - 2006
//
//  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

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

namespace InteractiveCellDemo
{
	/// <summary>
	/// Defines a textbox cell with a ellipsis button.
	/// Typically used with <see cref="EllipsisCellRenderer"/>.
	/// </summary>
	public class EllipsisCellButton : GridCellButton
	{
		static GridIconPaint iconPainter;
		
		static EllipsisCellButton()
		{
            iconPainter = new GridIconPaint("InteractiveCellDemo.", typeof(EllipsisCellButton).Assembly);
		}

		/// <summary>
		/// Initializes a <see cref="EllipsisCellButton"/> and associates it with a <see cref="GridTextBoxCellRenderer"/>
		/// </summary>
		/// <param name="control">The <see cref="GridTextBoxCellRenderer"/> that draws this cell button element.</param>
		public EllipsisCellButton(GridTextBoxCellRenderer control)
			: base(control)
		{
		}

		/// <override/>
		public override void Draw(Graphics g, int rowIndex, int colIndex, bool bActive, GridStyleInfo style)
		{
			TraceUtil.TraceCurrentMethodInfo(rowIndex, colIndex, bActive, style.CellValue);

			base.Draw(g, rowIndex, colIndex, bActive, style);

			// draw the button
			bool hovering = IsHovering(rowIndex, colIndex);
			bool mouseDown = IsMouseDown(rowIndex, colIndex);
			bool disabled = !style.Clickable;

			ButtonState buttonState = ButtonState.Normal;
			if (disabled)
				buttonState |= ButtonState.Inactive|ButtonState.Flat;

			else if (!hovering && !mouseDown)
				buttonState |= ButtonState.Flat;

			Point ptOffset = Point.Empty;
			if (mouseDown)
			{
				ptOffset = new Point(1, 1);
				buttonState |= ButtonState.Pushed;
			}

			DrawButton(g, Bounds, buttonState, style);

            string bitmapName = "Browse.bmp"; // make sure this is included in project and marked as "Embedded Resource"

			// Instead of using GridIconPaint you could simple use Image.Draw here
			// with an existing bitmap. GridIconPaint is convenient because it lets
			// us easily draw over existing background and replace the black color
			// in the bitmap with a different color.
			iconPainter.PaintIcon(g, Bounds, ptOffset, bitmapName, Color.White);
		}
	}


	/// <summary>
	/// Implements the data/model part for a textbox cell with ellipse in a <see cref="GridDataBoundGrid"/>. The
	/// The exandable row header cell will display a '+' for expanded rows and a '-' for collapsed rows similar to a TreeControl.
	/// a pencil when the row is being edited.
	/// </summary>
	[Serializable]
	public class EllipsisCellModel: GridTextBoxCellModel
	{
		/// <overload>
		/// Initializes a new <see cref="EllipsisCellModel"/> object.
		/// </overload>
		/// <summary>
		/// Initializes a new <see cref="EllipsisCellModel"/> from a serialization stream.
		/// </summary>
		/// <param name="info">An object that holds all the data needed to serialize or deserialize this instance.</param>
		/// <param name="context">Describes the source and destination of the serialized stream specified by info. </param>
		protected EllipsisCellModel(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			base.ButtonBarSize = new Size(20, 20);
		}

		/// <summary>
		/// Initializes a new <see cref="EllipsisCellModel"/> object 
		/// and stores a reference to the <see cref="GridModel"/> this cell belongs to.
		/// </summary>
		/// <param name="grid">The <see cref="GridModel"/> for this cell model.</param>	
		/// <remarks>
		/// You typically access cell models through the <see cref="GridModel.CellModels"/>
		/// property of the <see cref="GridModel"/> class.
		/// </remarks>
		public EllipsisCellModel(GridModel grid)
			: base(grid)
		{
		}

		/// <override/>
		public override GridCellRendererBase CreateRenderer(GridControlBase control)
		{
			return new EllipsisCellRenderer(control, this);
		}


		/// <override/>
		protected override Size OnQueryPrefferedClientSize(Graphics g, int rowIndex, int colIndex, GridStyleInfo style, GridQueryBounds GridQueryBounds)
		{ 
			Size size = base.OnQueryPrefferedClientSize(g, rowIndex, colIndex, style, GridQueryBounds);
			return new Size(size.Width + 20, size.Height); // base method already consides ButtonBarSize, but let's add some more pixels here.
		}


	}

	/// <summary>
	/// Implements the renderer part for a textbox cell with ellipsis button
	/// </summary>
	public class EllipsisCellRenderer : GridTextBoxCellRenderer
	{
		/// <summary>
		/// Initializes a new <see cref="GridTextBoxCellRenderer"/> object for the given GridControlBase
		/// and <see cref="GridTextBoxCellModel"/>.
		/// </summary>
		/// <param name="grid">The <see cref="GridControlBase"/> that display this cell renderer.</param>
		/// <param name="cellModel">The <see cref="GridTextBoxCellModel"/> that holds data for this cell renderer that should
		/// be shared among views.</param>
		/// <remarks>References to GridControlBase, 
		/// and GridTextBoxCellModel will be saved.</remarks>
		public EllipsisCellRenderer(GridControlBase grid, GridTextBoxCellModel cellModel)
			: base(grid, cellModel)
		{
			AddButton(new EllipsisCellButton(this));
		}

		/// <override/>
		public override void OnPrepareViewStyleInfo(GridPrepareViewStyleInfoEventArgs e)
		{
			// Here you can adjust settings that override the default settings from the grid
			e.Style.ShowButtons = GridShowButtons.Show;
			e.Style.Clickable = true;
			e.Style.TextAlign = GridTextAlign.Left;
			e.Style.VerticalAlignment = GridVerticalAlignment.Middle;
			e.Style.WrapText = false;
		}

		/// <override/>
		protected override Rectangle OnLayout(int rowIndex, int colIndex, GridStyleInfo style, Rectangle innerBounds, Rectangle[] buttonsBounds)
		{
			TraceUtil.TraceCurrentMethodInfo(rowIndex, colIndex, style, innerBounds, buttonsBounds);

			// Here you specify where the button should be drawn within the cell.
			Rectangle rightArea = Rectangle.FromLTRB(innerBounds.Right-20, innerBounds.Top, innerBounds.Right, innerBounds.Bottom);
			buttonsBounds[0] = GridUtil.CenterInRect(rightArea, new Size(20, 20));

			// Here you return the area where the text should be drawn/edited.
			innerBounds.Width -= 20;
			return innerBounds;
		}

	}

}
