using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Diagram;
using System.Drawing;

    public class EllipseRectGroup:Group

    {
        public EllipseRectGroup(int number,string header,string content,Color HeaderColor,Color ContentColor,Color HeaderBackColor,Color ContentBackColor)
        {
           
            RectangleF rect = new RectangleF(55, 3, 290, 45);
            TextNode nodeRectHeader = new TextNode(header, rect);
            nodeRectHeader.BackgroundStyle.Color = HeaderBackColor;          
            nodeRectHeader.LineStyle.LineWidth = 0;
            nodeRectHeader.FontStyle.Size = 14;
            nodeRectHeader.FontStyle.Bold = false;
            nodeRectHeader.FontStyle.Italic = true;
            nodeRectHeader.FontColorStyle.Color = HeaderColor;
            nodeRectHeader.ReadOnly = true;
            nodeRectHeader.HorizontalAlignment = StringAlignment.Near;
            nodeRectHeader.VerticalAlignment = StringAlignment.Center;

            rect = new RectangleF(0, 50, 350, 90);
            TextNode nodeRectContent = new TextNode(content, rect);
            nodeRectContent.BackgroundStyle.Color = ContentBackColor;            
            nodeRectContent.LineStyle.LineWidth = 1;
            nodeRectContent.FontStyle.Size = 11;
            nodeRectContent.FontStyle.Bold = false;
            nodeRectContent.FontColorStyle.Color = ContentColor;
            nodeRectContent.ReadOnly = true;

            Syncfusion.Windows.Forms.Diagram.Ellipse numberEllipse = new Syncfusion.Windows.Forms.Diagram.Ellipse(5, 3, 35, 35);
            numberEllipse.FillStyle.Color = Color.White;
            Syncfusion.Windows.Forms.Diagram.Label lble = new Syncfusion.Windows.Forms.Diagram.Label();
            lble.Text = number.ToString();
            lble.SizeToNode = true;
            lble.Position = Position.Center;
            lble.FontStyle.Size = 12;
            lble.FontStyle.Bold = true;
            numberEllipse.Labels.Add(lble);
            Syncfusion.Windows.Forms.Diagram.Rectangle nodeRectBorder = new Syncfusion.Windows.Forms.Diagram.Rectangle(0, 0, 350, 50);
            nodeRectBorder.FillStyle.Color = Color.LightBlue;
            nodeRectBorder.LineStyle.LineWidth = 1;
          
            this.AppendChild(nodeRectBorder);
            this.AppendChild(numberEllipse);
            this.AppendChild(nodeRectHeader);
            this.AppendChild(nodeRectContent);
            this.EditStyle.AllowSelect = false;
        }
    }