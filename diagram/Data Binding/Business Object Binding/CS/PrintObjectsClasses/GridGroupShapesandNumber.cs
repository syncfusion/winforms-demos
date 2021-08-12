using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Diagram;
using System.Drawing;

public class GridGroupShapesandNumber : Group
    {
        public GridGroupShapesandNumber(string header,Color BackColor)
        {
            RectangleF rect = new RectangleF(0, 0, 240, 25);
            TextNode headerRect = new TextNode(header, rect);
            headerRect.BackgroundStyle.Color = BackColor;
            headerRect.LineStyle.LineWidth = 1;
            headerRect.FontStyle.Size = 12;
            headerRect.FontStyle.Bold = true;
            headerRect.ReadOnly = true;
            headerRect.HorizontalAlignment = StringAlignment.Center;
            headerRect.VerticalAlignment = StringAlignment.Center;

            this.AppendChild(headerRect);
            int x = 0;
            for (int i = 0; i < 12; i++)
            {                
                rect = new RectangleF(x, 25, 20, 25);
                TextNode numRect = new TextNode((i + 1).ToString(), rect);
                numRect.BackgroundStyle.Color = BackColor;
                numRect.LineStyle.LineWidth = 1;
                numRect.FontStyle.Size = 11;
                numRect.FontStyle.Bold = false;
                numRect.ReadOnly = true;
                numRect.HorizontalAlignment = StringAlignment.Near;
                numRect.VerticalAlignment = StringAlignment.Center;
                x += 20;
               
                this.AppendChild(numRect);
            }
            this.EditStyle.AllowSelect = false;
           
        }
    }