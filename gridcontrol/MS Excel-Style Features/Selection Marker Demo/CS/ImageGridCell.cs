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
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Runtime.Serialization;

using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Grid;

namespace ExcelMarker
{
	public class ImageCellModel : GridStaticCellModel
	{
		//private Image image;
		protected ImageCellModel(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		public ImageCellModel(GridModel grid)
			: base(grid)
		{
				
		}
	
		public override GridCellRendererBase CreateRenderer(GridControlBase control)
		{
			return new ImageCellRenderer(control, this);
		}

	}

	/// <summary>
	///    Summary description for DragButton.
	/// </summary>
	public class ImageCellRenderer: GridStaticCellRenderer
	{
		public ImageCellRenderer(GridControlBase grid, GridCellModelBase cellModel)
			: base(grid, cellModel)
		{
				
		}

		protected override void OnDraw(System.Drawing.Graphics g, System.Drawing.Rectangle clientRectangle, int rowIndex, int colIndex, Syncfusion.Windows.Forms.Grid.GridStyleInfo style)
		{
			if (clientRectangle.IsEmpty)
				return;
			

			if(style.Tag is Bitmap)
			{
				g.DrawImage((Bitmap) style.Tag, clientRectangle);
			}
		}
	}
}
