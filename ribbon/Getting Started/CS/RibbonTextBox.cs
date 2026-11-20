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
