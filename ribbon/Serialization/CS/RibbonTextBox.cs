#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WF_Word
{
    public class RibbonTextBox
    {

        public Point Location { get; set; }
        public string Text { get; set; }

        public RibbonTextBox()
        {

           

        }

        public void SetRichTextBoxProperties(Point location, string text)
        {
            Location = location;
            Text = text;
        }

    }
}
