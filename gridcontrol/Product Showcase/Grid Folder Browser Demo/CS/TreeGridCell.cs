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

namespace FolderBrowser
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;
	using System.Runtime.Serialization;

	using Syncfusion.Drawing;
	using Syncfusion.Windows.Forms;
	using Syncfusion.Windows.Forms.Grid;

	//we override the Model to create the create a new cell renderer for our control
	public class TreeCellModel : GridStaticCellModel
	{
		
		protected TreeCellModel(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		public TreeCellModel(GridModel grid)
			: base(grid)
		{
				
		}
	
		//note that this method create our new derived renderer
		public override GridCellRendererBase CreateRenderer(GridControlBase control)
		{
			return new TreeCellRenderer(control, this);
		}

	}

	// handles drawing our indented cell
	public class TreeCellRenderer: GridStaticCellRenderer
	{
		private int _indentSize;
		private int bitmapWidth;
		private int bitmapHeight;
		public static Hashtable nodeList;

		public int IndentSize 
		{
			get{ return _indentSize;}
			set
			{ 
				if(value >= 0)
					_indentSize = value;
				else 
					_indentSize = 0;
			}

		}
		public TreeCellRenderer(GridControlBase grid, GridCellModelBase cellModel)
			: base(grid, cellModel)
		{
			_indentSize = 20;
			bitmapWidth = 20;
			bitmapHeight = 17;
			nodeList = new Hashtable();
			nodeList.Add( this.Grid.Model[1, 3].Text, "Added" );
		}

		protected override void OnDraw(System.Drawing.Graphics g, System.Drawing.Rectangle clientRectangle, int rowIndex, int colIndex, Syncfusion.Windows.Forms.Grid.GridStyleInfo style)
		{
			if (clientRectangle.IsEmpty)
				return;
			
			int imageIndex = style.ImageIndex;
			ImageList imageList = style.ImageList;
			if (imageIndex != -1 && imageList != null && imageIndex < imageList.Images.Count)
			{
				try
				{
                    Rectangle rect = GetCellBoundsCore(rowIndex, colIndex);
                    int X = rect.X + IndentSize * (int)style.Tag;
                    if (this.Grid.Model[rowIndex, 5].CellValue.ToString() == "Directory")
                    {
                        g.DrawImage((Bitmap)imageList.Images[imageIndex], X, rect.Y);
                    }
					//now draw text past the image...
					bool drawDisabled = false;
					string displayText = String.Empty;

					X += imageList.Images[imageIndex].Width + 2;


                    if (this.Grid.Model[rowIndex, 5].CellValue.ToString() == "Directory")
                    {
                        int imageIndex3 = imageIndex + 3;
                        g.DrawImage((Bitmap)imageList.Images[imageIndex3], X, rect.Y);
                        X += imageList.Images[imageIndex3].Width + 2;
                    }
                        if (this.Grid.Model[rowIndex, 5].CellValue.ToString() == "File")
                        {
                            int imageIndex4 = 5;
                            g.DrawImage((Bitmap)imageList.Images[imageIndex4], X, rect.Y);
                            X += imageList.Images[imageIndex4].Width + 2;
                        }

					Rectangle textRectangle = RemoveMargins(clientRectangle, style);
					int shift = X - textRectangle.X;
					textRectangle.X = X;
					textRectangle.Width -= shift;
					if (textRectangle.IsEmpty)
						return;

					try
					{
						displayText = Model.GetFormattedOrActiveTextAt(rowIndex, colIndex, style);
					}
					catch 
					{
						displayText = style.Text;
						//style.ToolTip = ex.Message;
						drawDisabled = true;
					}

					if (style.HasError)
					{
						displayText = style.Error;
						drawDisabled = true;
					}

					if (displayText.Length > 0)
					{
						Font font = style.Font.GdipFont;
						Color textColor = Grid.Model.Properties.BlackWhite ? Color.Black : style.TextColor;
						DrawText(g, displayText, font, textRectangle, style, textColor, drawDisabled);
					}
                    }
				catch{}
			}
		}

		//		protected override void OnClick(int rowIndex, int colIndex, System.Windows.Forms.MouseEventArgs e)
		//		{
		//		//if you call ClickTreeNode here instead of OnMouseDown, 
		//		//then the action is done later after the mouseup...
		//		//	ClickTreeNode(rowIndex, colIndex, e);
		//			base.OnClick(rowIndex, colIndex, e);
		//			return;
		//		}


		private void ClickTreeNode(int rowIndex, int colIndex, System.Windows.Forms.MouseEventArgs e)
		{
			Rectangle rect = GetCellBoundsCore(rowIndex, colIndex);
			int X = rect.X + IndentSize * (int)this.Grid.Model[rowIndex, colIndex].Tag;

			rect.X = X;
			rect.Width = this.bitmapWidth;
			rect.Height = this.bitmapHeight;

			if(rect.Contains(new Point(e.X, e.Y)))
			{
				if(this.Grid.Model[rowIndex, colIndex].ImageIndex == (int) TreeNodeState.Opened)
				{
					this.Grid.Model[rowIndex, colIndex].ImageIndex = (int) TreeNodeState.Closed;
					//OnCollapseRow(rowIndex);
				}
				else if(this.Grid.Model[rowIndex, colIndex].ImageIndex == (int) TreeNodeState.Closed)
				{
					this.Grid.Model[rowIndex, colIndex].ImageIndex = (int) TreeNodeState.Opened;
					if(! nodeList.Contains(this.Grid.Model[rowIndex, 3].Text))
						OnExpandRow(rowIndex);
				}
			}
			
			this.Grid.Refresh();
			this.Grid.Model.ColWidths.ResizeToFit(GridRangeInfo.Table());
		}

		
		public virtual void OnExpandRow(int row)
		{
			int indent = TreeGridForm.externalData[row-1].IndentLevel;
			TreeGridForm.externalData.InsertData(row, this.Grid.Model[row,3].Text, indent);
			nodeList.Add(this.Grid.Model[row,3].Text,"Added");
		}

		
		public virtual void OnCollapseRow(int row)
		{
			Console.WriteLine("OnCollapseRow " + row.ToString() );
		}

		//cheap way to get row col to menuhandler
		private int _rowIndex;
		private int _colIndex;

		protected override void OnMouseDown(int rowIndex, int colIndex, System.Windows.Forms.MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Right)
			{
				_rowIndex = rowIndex;
				_colIndex = colIndex;

			}
			else
			{
				base.OnMouseDown(rowIndex, colIndex, e);
				ClickTreeNode(rowIndex, colIndex, e);
			}
		}

		void HandleIndent(object sender, EventArgs e)
		{
			GridStyleInfo style = this.Grid.Model[_rowIndex, _colIndex];

			//use update to avoid multiple calls to SaveCellInfo..
			style.BeginUpdate();
			style.Tag = (int)style.Tag + 1;
			style.ImageIndex = (int) TreeNodeState.NoChildren;
			style.EndUpdate();
		}

		void HandleMatch(object sender, EventArgs e)
		{
			if(_rowIndex > 1)
			{
				GridStyleInfo style = this.Grid.Model[_rowIndex, _colIndex];

				//use update to avoid multiple calls to SaveCellInfo..
				style.BeginUpdate();
				style.Tag = (int)this.Grid.Model[_rowIndex - 1, _colIndex].Tag;
				style.EndUpdate();
			}
			
		}

		void HandleOutdent(object sender, EventArgs e)
		{
			this.Grid.Model[_rowIndex, _colIndex].Tag = ((int)this.Grid.Model[_rowIndex, _colIndex].Tag > 0) 
				? (int)this.Grid.Model[_rowIndex, _colIndex].Tag - 1 : 0;
				
		}

		protected override int OnHitTest(int rowIndex, int colIndex, MouseEventArgs e, IMouseController controller) 
		{
			if(e.Button != MouseButtons.None )
			{
				//return a cell hit so OnMouseDown will be called later
				return GridHitTestContext.Cell; 
			}
			else 
				return 0;
		}

	}

	
}
