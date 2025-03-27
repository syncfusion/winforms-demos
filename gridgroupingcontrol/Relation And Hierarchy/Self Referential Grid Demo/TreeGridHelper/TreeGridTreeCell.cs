#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
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

namespace TreeGridHelper
{

	/// <summary>
	/// Defines a cell button element that looks like a + and - button for expanding and collapsing nodes in a tree. 
	/// Used with <see cref="GridDataBoundTreeCellRenderer"/> as it assumes it is in a hierarchical GridDataBoundGrid.
	/// </summary>
	public class GridDataBoundTreeCellButton : GridCellButton
	{
        private TreeGridHelper helper;
		static GridIconPaint iconPainter;
		

		/// <summary>
		/// Initializes a <see cref="GridDataBoundTreeCellButton"/> and associates it with a <see cref="GridCellRendererBase"/>
		/// </summary>
		/// <param name="control">The <see cref="GridCellRendererBase"/> that draws this cell button element.</param>
		public GridDataBoundTreeCellButton(GridCellRendererBase control, TreeGridHelper helper)
			: base(control)
		{
            this.helper = helper;
			iconPainter = new GridIconPaint("TreeGridHelper.", typeof(GridDataBoundTreeCellButton).Assembly);
		}

		
		/// <override/>
		public override void Draw(Graphics g, int rowIndex, int colIndex, bool bActive, GridStyleInfo style)
		{


			// draw the button
			bool isHovering = IsHovering(rowIndex, colIndex);
			bool isMouseDown = IsMouseDown(rowIndex, colIndex);
			
			
			Node n = helper.GetNode(rowIndex);
			if(!n.HasChildren)
				return;

			bool expanded = n.IsExpanded;
			
			bool disabled = !style.Clickable;

			Rectangle rect = Bounds;

			string bitmapName = "";
			if (disabled)
				bitmapName = "SFEXPANDING.BMP";

			else if (!isHovering && !isMouseDown)
			{
				if (!expanded)
					bitmapName = "SFEXPAND.BMP";
				else
					bitmapName = "SFCOLLAPSE.BMP";
			}
			else
			{
				if (!expanded)
					bitmapName = "SFEXPANDING.BMP";
				else
					bitmapName = "SFCOLLAPSING.BMP";
			}
			iconPainter.PaintIcon(g, rect, Point.Empty, bitmapName, Color.Black);
		}
	}

	
	/// <summary>
	/// Implements the data/model part for a expandable row header cell in a <see cref="GridDataBoundGrid"/> that
	/// displays treelines. It is used exclusively with a hierarchical GridDataBoundGrid.
	/// The exandable row header cell will display a '+' for expanded rows and a '-' for collapsed rows similar to a TreeControl.
	/// a pencil when the row is being edited.
	/// </summary>
	/// <remarks>
	/// You typically access cell models through the <see cref="GridModel.CellModels"/>
	/// property of the <see cref="GridModel"/> class.<para/>
	/// A <see cref="GridDataBoundTreeCellModel"/> can serve as model for several <see cref="GridDataBoundTreeCellRenderer"/>
	/// instances if a there are several <see cref="GridControlBase"/> views for a <see cref="GridModel"/>.
	/// <para/>
	/// See <see cref="GridDataBoundTreeCellModel"/> for more detailed information about this cell type.
	/// </remarks>
	[Serializable]
	public class GridDataBoundTreeCellModel: GridTextBoxCellModel
	{
        private TreeGridHelper helper;
		/// <overload>
		/// Initializes a new <see cref="GridDataBoundTreeCellModel"/> object.
		/// </overload>
		/// <summary>
		/// Initializes a new <see cref="GridDataBoundTreeCellModel"/> from a serialization stream.
		/// </summary>
		/// <param name="info">An object that holds all the data needed to serialize or deserialize this instance.</param>
		/// <param name="context">Describes the source and destination of the serialized stream specified by info. </param>
		protected GridDataBoundTreeCellModel(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			
			base.ButtonBarSize = new Size(11, 11);
		}

		/// <summary>
		/// Initializes a new <see cref="GridDataBoundTreeCellModel"/> object 
		/// and stores a reference to the <see cref="GridModel"/> this cell belongs to.
		/// </summary>
		/// <param name="grid">The <see cref="GridModel"/> for this cell model.</param>	
		/// <remarks>
		/// You typically access cell models through the <see cref="GridModel.CellModels"/>
		/// property of the <see cref="GridModel"/> class.
		/// </remarks>
        public GridDataBoundTreeCellModel(GridModel grid, TreeGridHelper helper)
			: base(grid)
		{
            this.helper = helper;
		}

		private GridControlBase grid;
		private GridDataBoundTreeCellRenderer renderer;
		/// <override/>
		public override GridCellRendererBase CreateRenderer(GridControlBase control)
		{
			this.grid = control;
			this.renderer = new GridDataBoundTreeCellRenderer(control, this,  helper);
			return this.renderer;
		}

		/// <override/>
		protected override Size OnQueryPrefferedClientSize(Graphics g, int rowIndex, int colIndex, GridStyleInfo style, GridQueryBounds queryBounds)
		{ 
			Size size = base.OnQueryPrefferedClientSize(g, rowIndex, colIndex, style, queryBounds);
			int indent = 36;
			if(this.grid != null)  
			{
				Node n = helper.GetNode(rowIndex);
				indent = (n.Indent + 1) * this.renderer.offSet + this.renderer.midPt + this.renderer.leftSide + 2;
			}

			return new Size(size.Width + indent, size.Height);
		}


	}
	/// <summary>
	/// Implements the renderer part for a expandable row header cell in a <see cref="GridDataBoundGrid"/>. The
	/// The exandable row header cell will display a '+' for expanded rows and a '-' for collapsed rows with treelines similar to a TreeControl.
	/// a pencil when the row is being edited.
	/// </summary>
	/// <remarks>
	/// Defines the renderer part of a expandable row header cell. A renderer is created for each <see cref="GridCellModelBase"/>
	/// and <see cref="GridControlBase"/>. There can be several renderers
	/// associated with one <see cref="GridDataBoundTreeCellRenderer"/> if several views display the same
	/// <see cref="GridModel"/>.
	/// <para/>
	/// The <see cref="GridDataBoundGrid"/> registers "DataBoundRowExpandCell" as identifier in <see cref="GridStyleInfo.CellType"/>
	/// of a cells <see cref="GridStyleInfo"/>
	/// to associate this cell type with a cell.
	/// <para/>
	/// The following table lists some characteristics about the DataBoundRowExpandCell cell type.
	/// <para/>
	/// <list type="table">
	///     <listheader>
	///         <term>Item</term>
	///         <description>Description</description>
	///     </listheader>
	///     <item>
	///         <term>CellType</term>
	///         <description>DataBoundRowExpandCell</description>
	///     </item>
	///     <item>
	///         <term>Renderer</term>
	///         <description><see cref="GridDataBoundTreeCellRenderer"/></description>
	///     </item>
	///     <item>
	///         <term>Model</term>
	///         <description><see cref="GridDataBoundTreeCellModel"/></description>
	///     </item>
	///     <item>
	///         <term>XP Themes Support</term>
	///         <description>No</description>
	///     </item>
	///     <item>
	///         <term>Interactive</term>
	///         <description>Click Only</description>
	///     </item>
	///     <item>
	///         <term>Floating Support</term>
	///         <description>No</description>
	///     </item>
	///     <item>
	///         <term>Base Type</term>
	///         <description><see cref="GridCellRendererBase"/></description>
	///     </item>
	/// </list>
	/// <para/>
	/// 
	/// The cells behavior and appearance can be customized with the following properties of the <see cref="GridStyleInfo"/> class.
	/// <para/>
	/// <list type="table">
	///     <listheader>
	///         <term>PropertyName</term>
	///         <description>Description</description>
	///     </listheader>
	///     <item>
	///         <term><see cref="GridStyleInfo.BaseStyle"/> (<see cref="System.String"/>)</term>
	///         <description>The base style for this style instance with default values for properties that are not initialized
	/// for this style object. (Default: String.Empty)</description>
	///     </item>
	///     <item>
	///         <term><see cref="GridStyleInfo.Borders"/> (<see cref="GridBordersInfo"/>)</term>
	///         <description>Top, left, bottom and right border settings. To hide grid lines for a certain cell you can
	/// set the <see cref="GridBorder.Style"/> of the specific edge to to be
	/// <see cref="GridBorderStyle.None"/>. By default, the right and bottom borders are initialized to
	/// <see cref="GridBorderStyle.Standard"/> and borders are drawn as specified in the
	/// <see cref="GridModelOptions.DefaultGridBorderStyle"/> property of a <see cref="GridModel"/> instance. (Default: GridBordersInfo.Default)</description>
	///     </item>
	///     <item>
	///         <term><see cref="GridStyleInfo.CellAppearance"/> (<see cref="GridCellAppearance"/>)</term>
	///         <description>When set to <see cref="GridCellAppearance.Flat"/> the header will be drawn with slightly raised edges typical for cell headers. If the grid is XP Themes enabled the headers will be drawn with XP Themes look. If you specify Sunken or Raise the header will be drawn with sunken or raised edges and not XP Themed. (Default: GridCellAppearance.Flat)</description>
	///     </item>
	///     <item>
	///         <term><see cref="GridStyleInfo.CellType"/> (<see cref="System.String"/>)</term>
	///         <description>DataBoundRowExpandCell (Default: TextBox)</description>
	///     </item>
	///     <item>
	///         <term><see cref="GridStyleInfo.Enabled"/> (<see cref="System.Boolean"/>)</term>
	///         <description>Specifies if the cell can be activated as current cell when the user click onto the header. Usually you do not want a header to be activated as current cell unless you want to have editing capabilities like allowing user to rename header text in place. Such renaming functionality needs to be implemented in a derived class. (Default: true)</description>
	///     </item>
	///     <item>
	///         <term><see cref="GridStyleInfo.Error"/> (<see cref="System.String"/>)</term>
	///         <description>Holds error information if a value could not be converted to the <see cref="System.Type"/> specified with <see cref="GridStyleInfo.CellValueType"/>. (Default: String.Empty)</description>
	///     </item>
	///     <item>
	///         <term><see cref="GridStyleInfo.Interior"/> (<see cref="Syncfusion.Drawing.BrushInfo"/>)</term>
	///         <description>Lets you specify a solid backcolor or a gradient or pattern style with both back and fore color for a cells
	///  background. If the grid is XP Themes enabled, this color will be ignored and the header will be drawn with default XP Themes header background. (Default: SystemColors.Window)</description>
	///     </item>
	///     <item>
	///         <term><see cref="GridStyleInfo.TextColor"/> (<see cref="System.Drawing.Color"/>)</term>
	///         <description>Lets you specify the color of the icon. (Default: SystemColors.WindowText)</description>
	///     </item>
	///     <item>
	///         <term><see cref="GridStyleInfo.TextMargins"/> (<see cref="GridMarginsInfo"/>)</term>
	///         <description>When drawing this header cell this specifies the minimum empty area between the text rectangle without borders and the icon. The icon will be centered inside the remaing rectangle. (Default: GridMarginsInfo.Default)</description>
	///     </item>
	/// </list>
	/// <para/>
	/// </remarks>
	public class GridDataBoundTreeCellRenderer : GridTextBoxCellRenderer
	{



		internal int offSet = 12;
		internal int leftSide = 4;
		internal int midPt = 5;
		internal int indentLen = 6;
		internal int centerLine = 4 + 5; //leftside + midPt;

		private Rectangle innerBounds;
		private Color lineColor;
		private TreeGridHelper treeHelper = null;

		/// <summary>
		/// Color used for drawing the treelines.
		/// </summary>
		public Color LineColor
		{
			get{return lineColor;}
			set{lineColor = value;}
		}

		/// <summary>
		/// Initializes a new <see cref="GridCellRendererBase"/> object for the given GridControlBase
		/// and <see cref="GridCellModelBase"/>.
		/// </summary>
		/// <param name="grid">The <see cref="GridControlBase"/> that display this cell renderer.</param>
		/// <param name="cellModel">The <see cref="GridCellModelBase"/> that holds data for this cell renderer that should
		/// be shared among views.</param>
		/// <remarks>References to GridControlBase, 
		/// and GridCellModelBase will be saved.</remarks>
		public GridDataBoundTreeCellRenderer(GridControlBase grid, GridCellModelBase cellModel, TreeGridHelper helper)
			: base(grid, cellModel)
		{
			AddButton(new GridDataBoundTreeCellButton(this, helper));

			lineColor = Color.Black;

            this.treeHelper = helper;
		}

		/// <override/>
		public override void OnPrepareViewStyleInfo(GridPrepareViewStyleInfoEventArgs e)
		{
			e.Style.HorizontalAlignment = GridHorizontalAlignment.Center;
			e.Style.VerticalAlignment = GridVerticalAlignment.Middle;
			object val = this.Grid.Model[e.Style.CellIdentity.RowIndex, 1].CellValue;
			
			e.Style.ShowButtons = GridShowButtons.Show;
			e.Style.Clickable = true;
		}

		/// <override/>
		protected override Rectangle OnLayout(int rowIndex, int colIndex, GridStyleInfo style, Rectangle innerBounds, Rectangle[] buttonsBounds)
		{
			

			buttonsBounds[0] = GridUtil.CenterInRect(innerBounds, new Size(11, 11));
			//return innerBounds;

			
			buttonsBounds[0].X = innerBounds.X + leftSide;
			this.innerBounds = innerBounds;

			if(rowIndex > this.Grid.Model.Rows.HeaderCount)
			{
				
				Node n = this.treeHelper.GetNode(rowIndex);
			
				int leftSideButton = buttonsBounds[0].X + n.Indent * offSet;
				
				buttonsBounds[0].X = this.Grid.IsRightToLeft() 
						? innerBounds.Right - leftSideButton + innerBounds.Left - buttonsBounds[0].Width
						: buttonsBounds[0].X = leftSideButton;
			}
			return innerBounds; //return rect;
		}

		protected override bool OnStartEditing()
		{
			
			if(!this.treeHelper.TreeNodeCellEditable)
				return false; //no editing

			return base.OnStartEditing ();
		}

		/// <override/>
		public override void Draw(System.Drawing.Graphics g, System.Drawing.Rectangle cellRectangle, int rowIndex, int colIndex, Syncfusion.Windows.Forms.Grid.GridStyleInfo style)
		{

			Node n = this.treeHelper.GetNode(rowIndex);
			int indent = (n.Indent + 1) * offSet + this.midPt + this.leftSide + 2;
			
			style.TextMargins.Left = indent;
			style.HorizontalAlignment = GridHorizontalAlignment.Left;
			base.Draw(g, cellRectangle, rowIndex, colIndex, style);

			DrawTreeLines(g, rowIndex, this.GetButton(0).Bounds);
		}

		/// <override/>
		protected override void OnDrawCellButton(GridCellButton button, Graphics g, int rowIndex, int colIndex, bool bActive, Syncfusion.Windows.Forms.Grid.GridStyleInfo style)
		{
			Node n = this.treeHelper.GetNode(rowIndex);
			if(!n.HasChildren)
				return;

			base.OnDrawCellButton(button, g, rowIndex, colIndex, bActive, style);

		}

		private void DrawTreeLines(Graphics g, int rowIndex, Rectangle rect)
		{
			
			if(!this.treeHelper.ShowTreeLines)
				return;

			if(rowIndex > this.Grid.Model.Rows.HeaderCount)
			{
				using(Pen p = new Pen(lineColor, 1))
				{
					Node n = this.treeHelper.GetNode(rowIndex);
					for(int level = 0; level <= n.Indent; ++level)
					{
						int middle = this.innerBounds.Left + centerLine + level * this.offSet;
						if(this.Grid.IsRightToLeft())
						{
							middle = innerBounds.Right - middle + innerBounds.Left - 1;
						}
						
						if( level <	n.Indent
							&& (level < n.Indent || n.Position < n.SiblingList.Count - 1)
							  
							)
						{
							//GridBoundRecordState parentState = state.Parent;
							Node pn = this.treeHelper.GetNode(rowIndex).ParentNode;
							while(pn != null 
								&& pn.Indent > level)
								pn = pn.ParentNode;
							if(pn == null || pn.Position < pn.SiblingList.Count - 1)
								//draw long line on outer levels
								g.DrawLine(p, middle, this.innerBounds.Top, middle, this.innerBounds.Bottom); 
					
						}
						else 
						{
							int xOff = n.HasChildren ?  0 : this.indentLen - 1;
							int yOff = n.HasChildren ?  0 : this.midPt;

							//draw the neck
							if(level > 0 || n.Position > 0)
								g.DrawLine(p, middle, this.innerBounds.Top, middle, rect.Top + yOff); 
							if(n.Position < n.SiblingList.Count - 1) //draw the leg
								g.DrawLine(p, middle, rect.Bottom - 1 - yOff, middle, this.innerBounds.Bottom); 
							//draw left arm
							if(this.Grid.IsRightToLeft())
								g.DrawLine(p, rect.Left - this.indentLen, rect.Top + midPt, rect.Left + xOff, rect.Top + midPt); 
							else
								g.DrawLine(p, rect.Right - 1 - xOff, rect.Top + midPt, rect.Right + this.indentLen, rect.Top + midPt); 
							
							if(n.IsExpanded) //draw left arm bend
							{
								if(this.Grid.IsRightToLeft())
									g.DrawLine(p, rect.Left - this.indentLen - 1, rect.Top + midPt, rect.Left - this.indentLen - 1, this.innerBounds.Bottom); 
								else
									g.DrawLine(p, rect.Right + this.indentLen, rect.Top + midPt, rect.Right + this.indentLen, this.innerBounds.Bottom); 
							}


						}
					}
				}
			}
		}


	}

}
