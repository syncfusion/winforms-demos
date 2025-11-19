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

    public class ContentRectangle:Group
    {
        public ContentRectangle(string content,Color ForeColor,Color BackColor,bool bold,int fontsize,bool type)
        {     
            RectangleF rect;
            if (type)
            {
                rect = new RectangleF(0, 0, 180, 45);
            }
            else
                rect = new RectangleF(0, 0, 200, 45);
            TextNode ContentOne = new TextNode(content, rect);
            ContentOne.BackgroundStyle.Color = BackColor;
            ContentOne.BackgroundStyle.Color = Color.White;
            ContentOne.FontColorStyle.Color = ForeColor;
            ContentOne.LineStyle.LineWidth = 1;
            ContentOne.FontStyle.Size = fontsize;
            ContentOne.FontStyle.Bold = bold;
            ContentOne.ReadOnly = true;
            ContentOne.HorizontalAlignment = StringAlignment.Near;
            ContentOne.VerticalAlignment = StringAlignment.Near;
            ContentOne.EnableCentralPort = false;
            this.AppendChild(ContentOne);
            //this.EditStyle.AllowSelect = false;
        }
    }

