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

 public class SplitContent:Group
    {
        public SplitContent(string content1,string content2,Color BackColor,bool bold,int fontsize,bool IsHeader)
        {             
            RectangleF rect = new RectangleF(0, 0, 115, 50);
            TextNode ContentOne = new TextNode(content1, rect);
            ContentOne.BackgroundStyle.Color = BackColor;
            ContentOne.BackgroundStyle.Color = Color.White;
            ContentOne.LineStyle.LineWidth = 1;
            ContentOne.FontStyle.Size = fontsize;
            ContentOne.FontStyle.Bold = bold;            
            ContentOne.ReadOnly = true;

            rect = new RectangleF(115, 0, 115, 50);
            TextNode ContentTwo = new TextNode(content2, rect);
            ContentTwo.BackgroundStyle.Color = BackColor;
            ContentTwo.BackgroundStyle.Color = Color.White;
            ContentTwo.LineStyle.LineWidth = 1;
            ContentTwo.FontStyle.Size = fontsize;
            ContentTwo.FontStyle.Bold = bold;
            ContentTwo.ReadOnly = true;
            
            this.AppendChild(ContentOne);
            this.AppendChild(ContentTwo); 
            this.EditStyle.AllowSelect = false;
        }
    }