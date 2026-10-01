using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Grid;
using System.Runtime.Serialization;
using System.Drawing;
using Syncfusion.Drawing;

namespace InteractiveCellDemo
{
    public class MultipleButtonGridCell : GridCellButton
    {
        BrushInfo interiorBrush;
        public MultipleButtonGridCell(GridCellRendererBase control)
			: base(control)
		{
			interiorBrush = new BrushInfo(GradientStyle.PathRectangle, Color.NavajoWhite, Color.Beige);
		}

        public BrushInfo Interior
        {
            get
            {
                return this.interiorBrush;
            }
            set
            {
                interiorBrush = value;
            }
        }
      
        public class MultipleButtonCellModel : GridStaticCellModel
        {
            protected MultipleButtonCellModel(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }

            public MultipleButtonCellModel(GridModel grid)
                : base(grid)
            {
                AllowFloating = false;                
                ButtonBarSize = new Size(120,120);                
            }

            public override GridCellRendererBase CreateRenderer(GridControlBase control)
            {
                return new MultipleButtonCellRenderer(control, this);
            }

        }

        public class MultipleButtonCellRenderer : GridStaticCellRenderer
        {
            MultipleButtonGridCell[] mybuttons;

            public MultipleButtonCellRenderer(GridControlBase grid, GridCellModelBase cellModel)
                : base(grid, cellModel)
            {
                mybuttons = new MultipleButtonGridCell[2];
                for (int n = 0; n < 2; n++)
                {
                    mybuttons[n] = new MultipleButtonGridCell(this);
                    AddButton(mybuttons[n]);
                }
                mybuttons[0].Interior = new BrushInfo(GradientStyle.PathEllipse, Color.Blue, Color.White);
                mybuttons[0].Text = "Button1";
                mybuttons[1].Interior = new BrushInfo(GradientStyle.PathEllipse, Color.Blue, Color.White);
                mybuttons[1].Text = "Button2";
            }
        }
    }
}
