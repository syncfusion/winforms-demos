#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
