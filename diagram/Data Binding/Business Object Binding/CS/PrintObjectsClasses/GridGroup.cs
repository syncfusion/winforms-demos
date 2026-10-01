using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Diagram;
using System.Drawing;

public class GridGroup : Group
    {
       
        public GridGroup()
        {
            Syncfusion.Windows.Forms.Diagram.Rectangle nodeRectBorder = new Syncfusion.Windows.Forms.Diagram.Rectangle(0, 0, 350, 50);
            nodeRectBorder.FillStyle.Color = Color.LightBlue;
            nodeRectBorder.LineStyle.LineWidth = 1;
            //Row1
            RectangleF rect;
            rect = new RectangleF(0, 0, 70, 20);
            TextNode r1c1 = new TextNode("Rev #", rect);
            r1c1.BackgroundStyle.Color = Color.Gray;
            r1c1.FontColorStyle.Color = Color.White;
            r1c1.LineStyle.LineWidth = 1;
            r1c1.FontStyle.Size = 11;           
            r1c1.ReadOnly = true;
            r1c1.HorizontalAlignment = StringAlignment.Center;

            rect = new RectangleF(70, 0, 120, 20);
            TextNode r1c2 = new TextNode("Revison Date", rect);
            r1c2.BackgroundStyle.Color = Color.Gray;
            r1c2.FontColorStyle.Color = Color.White;
            r1c2.LineStyle.LineWidth = 1;
            r1c2.FontStyle.Size = 11;
            r1c2.ReadOnly = true;
            r1c2.HorizontalAlignment = StringAlignment.Center;
            rect = new RectangleF(190, 0, 150, 20);
            TextNode r1c3 = new TextNode("Reason", rect);
            r1c3.BackgroundStyle.Color = Color.Gray;
            r1c3.FontColorStyle.Color = Color.White;
            r1c3.LineStyle.LineWidth = 1;
            r1c3.FontStyle.Size = 11;
            r1c3.ReadOnly = true;
            r1c3.HorizontalAlignment = StringAlignment.Center;
            rect = new RectangleF(340, 0, 100, 20);
            TextNode r1c4 = new TextNode("Who", rect);
            r1c4.BackgroundStyle.Color = Color.Gray;
            r1c4.FontColorStyle.Color = Color.White;
            r1c4.LineStyle.LineWidth = 1;
            r1c4.FontStyle.Size = 11;
            r1c4.ReadOnly = true;
            r1c4.HorizontalAlignment = StringAlignment.Center;
            //Row2
            rect = new RectangleF(0, 20, 70, 20);
            TextNode r2c1 = new TextNode("", rect);
            r2c1.BackgroundStyle.Color = Color.White;
            r2c1.LineStyle.LineWidth = 1;
            r2c1.FontStyle.Size = 11;
           

            rect = new RectangleF(70, 20, 120, 20);
            TextNode r2c2 = new TextNode("", rect);
            r2c2.BackgroundStyle.Color = Color.White;
            r2c2.LineStyle.LineWidth = 1;
            r2c2.FontStyle.Size = 11;
           

            rect = new RectangleF(190, 20, 150, 20);
            TextNode r2c3 = new TextNode("", rect);
            r2c3.BackgroundStyle.Color = Color.White;
            r2c3.LineStyle.LineWidth = 1;
            r2c3.FontStyle.Size = 11;
            

            rect = new RectangleF(340, 20, 100, 20);
            TextNode r2c4 = new TextNode("", rect);
            r2c4.BackgroundStyle.Color = Color.White;
            r2c4.LineStyle.LineWidth = 1;
            r2c4.FontStyle.Size = 11;
           
            //Row3
            rect = new RectangleF(0, 40, 70, 20);
            TextNode r3c1 = new TextNode("", rect);
            r3c1.BackgroundStyle.Color = Color.White;
            r3c1.LineStyle.LineWidth = 1;
            r3c1.FontStyle.Size = 11;
            

            rect = new RectangleF(70, 40, 120, 20);
            TextNode r3c2 = new TextNode("", rect);
            r3c2.BackgroundStyle.Color = Color.White;
            r3c2.LineStyle.LineWidth = 1;
            r3c2.FontStyle.Size = 11;
         

            rect = new RectangleF(190, 40, 150,20);
            TextNode r3c3 = new TextNode("", rect);
            r3c3.BackgroundStyle.Color = Color.White;
            r3c3.LineStyle.LineWidth = 1;
            r3c3.FontStyle.Size = 11;
          

            rect = new RectangleF(340, 40, 100, 20);
            TextNode r3c4 = new TextNode("", rect);
            r3c4.BackgroundStyle.Color = Color.White;
            r3c4.LineStyle.LineWidth = 1;
            r3c4.FontStyle.Size = 11;
           
            //Row4
            rect = new RectangleF(0, 60, 70, 20);
            TextNode r4c1 = new TextNode("", rect);
            r4c1.BackgroundStyle.Color = Color.White;
            r4c1.LineStyle.LineWidth = 1;
            r4c1.FontStyle.Size = 11;
            

            rect = new RectangleF(70, 60, 120, 20);
            TextNode r4c2 = new TextNode("", rect);
            r4c2.BackgroundStyle.Color = Color.White;
            r4c2.LineStyle.LineWidth = 1;
            r4c2.FontStyle.Size = 11;
           

            rect = new RectangleF(190, 60, 150, 20);
            TextNode r4c3 = new TextNode("", rect);
            r4c3.BackgroundStyle.Color = Color.White;
            r4c3.LineStyle.LineWidth = 1;
            r4c3.FontStyle.Size = 11;
            

            rect = new RectangleF(340, 60, 100, 20);
            TextNode r4c4 = new TextNode("", rect);
            r4c4.BackgroundStyle.Color = Color.White;
            r4c4.LineStyle.LineWidth = 1;
            r4c4.FontStyle.Size = 11;

            this.AppendChild(r1c1); this.AppendChild(r1c2); this.AppendChild(r1c3); this.AppendChild(r1c4);
            this.AppendChild(r2c1); this.AppendChild(r2c2); this.AppendChild(r2c3); this.AppendChild(r2c4);
            this.AppendChild(r3c1); this.AppendChild(r3c2); this.AppendChild(r3c3); this.AppendChild(r3c4);
            this.AppendChild(r4c1); this.AppendChild(r4c2); this.AppendChild(r4c3); this.AppendChild(r4c4);
            this.EditStyle.AllowSelect = false;
            
        }

    }