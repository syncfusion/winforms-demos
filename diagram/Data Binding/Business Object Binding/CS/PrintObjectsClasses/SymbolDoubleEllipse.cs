using System;
using System.Collections.Generic;

using System.Text;
using Syncfusion.Windows.Forms.Diagram;
using System.Drawing;

public class SymbolDoubleEllipse : Group
    {
        public SymbolDoubleEllipse()
        {
            Syncfusion.Windows.Forms.Diagram.Ellipse ellipse;
            ellipse = new Syncfusion.Windows.Forms.Diagram.Ellipse(0, 0, 15, 15);
            ellipse.FillStyle.Color = Color.Blue;
            this.AppendChild(ellipse);

            ellipse = new Syncfusion.Windows.Forms.Diagram.Ellipse(3, 3, 10, 10);
            ellipse.FillStyle.Color = Color.LightGray;
            this.AppendChild(ellipse);
            this.EditStyle.AllowSelect = false;
        }
    }
