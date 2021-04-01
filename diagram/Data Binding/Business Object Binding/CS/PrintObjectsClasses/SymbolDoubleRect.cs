using System;
using System.Collections.Generic;

using System.Text;
using Syncfusion.Windows.Forms.Diagram;
using System.Drawing;

 public class SymbolDoubleRect:Group
    {
        public SymbolDoubleRect()
        {
            Syncfusion.Windows.Forms.Diagram.Rectangle rects;
            rects = new Syncfusion.Windows.Forms.Diagram.Rectangle(15, 0, 10, 10);
            rects.FillStyle.Color = Color.Yellow;
            rects.LineStyle.LineColor = Color.Black;
            this.AppendChild(rects);
            Syncfusion.Windows.Forms.Diagram.Rectangle rects1;
            rects1 = new Syncfusion.Windows.Forms.Diagram.Rectangle(5, 5, 10, 10);
            rects1.FillStyle.Color = Color.Yellow;
            rects1.LineStyle.LineColor = Color.Black;
            this.AppendChild(rects1);
            this.EditStyle.AllowSelect = false;
        }

    }