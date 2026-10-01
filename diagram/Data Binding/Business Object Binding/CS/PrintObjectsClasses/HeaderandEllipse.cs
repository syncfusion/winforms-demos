using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Diagram;
using System.Drawing;
public class HeaderandEllipse : Group
    {
    
        public HeaderandEllipse(int number,string content,Color ContentColor,Color Background,int fontsize)
        {                   
            RectangleF rect = new RectangleF(55, 3, 140, 45);
            TextNode txtContent = new TextNode(content,rect);
            txtContent.BackgroundStyle.Color = Color.LightBlue;           
            txtContent.LineStyle.LineWidth = 0;
            txtContent.FontStyle.Size = fontsize;
            txtContent.FontStyle.Bold = true;
            txtContent.FontStyle.Italic = true;
            txtContent.FontColorStyle.Color = ContentColor;
            txtContent.ReadOnly = true;
            txtContent.HorizontalAlignment = StringAlignment.Near;
            txtContent.VerticalAlignment = StringAlignment.Center;

            Syncfusion.Windows.Forms.Diagram.Ellipse numberEllipse = new Syncfusion.Windows.Forms.Diagram.Ellipse(5, 3, 35, 35);
            numberEllipse.FillStyle.Color = Color.White;
            Syncfusion.Windows.Forms.Diagram.Label lble = new Syncfusion.Windows.Forms.Diagram.Label();
            lble.Text = number.ToString();
            lble.SizeToNode = true;
            lble.Position = Position.Center;
            lble.FontStyle.Size = 12;
            lble.FontStyle.Bold = true;
            numberEllipse.Labels.Add(lble);

            Syncfusion.Windows.Forms.Diagram.Rectangle nodeRectBorder = new Syncfusion.Windows.Forms.Diagram.Rectangle(0, 0, 200, 50);
            nodeRectBorder.FillStyle.Color = Background;
            nodeRectBorder.LineStyle.LineWidth = 1;
            //nodeRectBorder.EnableCentralPort = true;
            //numberEllipse.EnableCentralPort = true;
            //nodeRectHeader.EnableCentralPort = true;
            this.AppendChild(nodeRectBorder);
            this.AppendChild(numberEllipse);
            this.AppendChild(txtContent);
            this.EditStyle.AllowSelect = false;
        }
    }