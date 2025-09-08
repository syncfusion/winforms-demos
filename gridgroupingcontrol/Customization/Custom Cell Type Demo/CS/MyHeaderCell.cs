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
using System.Data.OleDb;
using System.IO;
using System.Text;
using System.Diagnostics;
using Syncfusion.Drawing;

using Syncfusion.Grouping;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;

namespace CustomCellTypes
{
	public class MyHeaderCellModel : GridTableColumnHeaderCellModel
	{
		public MyHeaderCellModel ( Syncfusion.Windows.Forms.Grid.GridModel grid )
			: base(grid)
		{
			ButtonBarSize = new Size(10, 10);
		}

		public override Syncfusion.Windows.Forms.Grid.GridCellRendererBase CreateRenderer ( Syncfusion.Windows.Forms.Grid.GridControlBase control ) 
		{
			return new MyHeaderCellRenderer(control, this);
		}
	}

	public class MyHeaderCellRenderer : GridTableColumnHeaderCellRenderer
	{
		public MyHeaderCellRenderer ( Syncfusion.Windows.Forms.Grid.GridControlBase grid , Syncfusion.Windows.Forms.Grid.GridCellModelBase cellModel )
			: base(grid, cellModel)
		{
			this.AddButton(new MyCellButton(this));
		}
        public override void OnPrepareViewStyleInfo(GridPrepareViewStyleInfoEventArgs e)
        {
            e.Style.Enabled = true;
            e.Cancel = true;
        }
	}

	public class MyCellButton : GridCellButton
	{
		public MyCellButton(MyHeaderCellRenderer r)
			: base(r)
		{
		}

		public override void MouseDown(System.Windows.Forms.MouseEventArgs e, Syncfusion.Windows.Forms.Grid.GridCellHitTestInfo ht)
		{
			//Console.WriteLine("MouseDown");
			base.MouseDown(e, ht);
		}

		public override void DrawButton(System.Drawing.Graphics g, System.Drawing.Rectangle rect, System.Windows.Forms.ButtonState buttonState, Syncfusion.Windows.Forms.Grid.GridStyleInfo style)
		{
			ControlPaint.DrawButton(g, rect, buttonState);

			// Icon
			rect.Inflate(-3, -3);
			Syncfusion.Drawing.BrushPaint.FillRectangle(g, rect, new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathEllipse, Color.Black, Color.Wheat));
		}
	}
}
