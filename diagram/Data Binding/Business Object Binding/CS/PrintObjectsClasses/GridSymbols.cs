using System;
using System.Collections.Generic;

using System.Text;
using Syncfusion.Windows.Forms.Diagram;
using System.Drawing;
public class GridSymbols : Group
    {
        public GridSymbols(string[] plan,string[] actual,string tip)
        {            
            int x = 0;          
            for (int i = 0; i < 12; i++)
            {               
                Syncfusion.Windows.Forms.Diagram.Rectangle numRect = new Syncfusion.Windows.Forms.Diagram.Rectangle(x, 0, 20, 25f);
                numRect.FillStyle.Color = Color.White;
                this.AppendChild(numRect);

                switch (plan[i])
                {
                    case "P-0":
                        SymbolDoubleRect symbol = new SymbolDoubleRect();
                        symbol.PinPoint = new PointF(x+symbol.BoundingRectangle.Width/2+2.5f,symbol.BoundingRectangle.Height/2 +2.5f);
                        this.AppendChild(symbol);
                        break;
                    case "P-1":
                        Polygon triangle = getTriangle();
                        triangle.PinPoint = new PointF(x + triangle.BoundingRectangle.Width / 2, triangle.BoundingRectangle.Height / 2 + 5f);
                        this.AppendChild(triangle);
                        break;
                    case "P-2":
                        PolylineNode poly = getPolyLine();
                        poly.PinPoint = new PointF(x + poly.BoundingRectangle.Width / 2, poly.BoundingRectangle.Height / 2 + 2.5f);
                        this.AppendChild(poly);
                        break;
                    case "P-3":
                        SymbolDoubleEllipse dcircle = new SymbolDoubleEllipse();
                        dcircle.PinPoint = new PointF(x + dcircle.BoundingRectangle.Width / 2, dcircle.BoundingRectangle.Height / 2 + 2.5f);
                        this.AppendChild(dcircle);
                        break;
                    case "P-4":
                        Polygon star = getStar();
                        star.PinPoint = new PointF(x + star.BoundingRectangle.Width / 2, star.BoundingRectangle.Height / 2 + 2.5f);
                        this.AppendChild(star);
                        break;

                }              
                x += 20;                                               
            }
        
            x = 0;
            for (int i = 0; i < 12; i++)
            {
                Syncfusion.Windows.Forms.Diagram.Rectangle numRect = new Syncfusion.Windows.Forms.Diagram.Rectangle(x, 25f, 20, 25f);
                numRect.FillStyle.Color = Color.White;
                this.AppendChild(numRect);

                switch (actual[i])
                {
                    case "A-0":
                        Ellipse green = getEllipse(x+3,-45f,Color.Green);
                        this.AppendChild(green);
                        break;
                    case "A-1":
                        Ellipse yellow = getEllipse(x + 3, -45f, Color.Yellow);
                        this.AppendChild(yellow);
                        break;
                    case "A-2":
                        Ellipse red = getEllipse(x + 3, -45f, Color.Red);
                        this.AppendChild(red);
                        break;
                    case "A-3":
                        Ellipse blue = getEllipse(x + 3, -45f, Color.Blue);
                        this.AppendChild(blue);
                        break;
                }             
                x += 20;            
                            
            }
            Syncfusion.Windows.Forms.Diagram.Rectangle HeadContent = new Syncfusion.Windows.Forms.Diagram.Rectangle(100, -4, 100, 8);
            HeadContent.FillStyle.Color = Color.LightYellow;
            Syncfusion.Windows.Forms.Diagram.Label lbl = new Syncfusion.Windows.Forms.Diagram.Label();
            lbl.Text = tip;
            lbl.SizeToNode = true;
            lbl.Position = Position.Center;
            lbl.FontStyle.Size = 10;          
            HeadContent.Labels.Add(lbl);
            this.AppendChild(HeadContent);
            this.EditStyle.AllowSelect = false;
        }
        private Ellipse getEllipse(float x,float y,Color color)
        {
            Syncfusion.Windows.Forms.Diagram.Ellipse Ellipse = new Syncfusion.Windows.Forms.Diagram.Ellipse(x,y+75f,15, 15);
            Ellipse.FillStyle.Color = color;                       
            return Ellipse;
        }
        private Polygon getStar()
        {
            PointF[] pts = new PointF[] { new PointF(0, 5), new PointF(5, 5), new PointF(10, 0), new PointF(15, 5), new PointF(20, 5), new PointF(15, 10), new PointF(20, 15), new PointF(15, 15), new PointF(10, 20), new PointF(5, 15), new PointF(0, 15), new PointF(5, 10), new PointF(0, 5) };
            Syncfusion.Windows.Forms.Diagram.Polygon star = new Syncfusion.Windows.Forms.Diagram.Polygon(pts);         
            star.FillStyle.Color = Color.Gray;
            return star;
        }
        private Polygon getTriangle()
        {
            PointF[] pts = new PointF[] { new PointF(25, 5), new PointF(5, 5), new PointF(15, 15) };
            Syncfusion.Windows.Forms.Diagram.Polygon triangle = new Syncfusion.Windows.Forms.Diagram.Polygon(pts);         
            triangle.FillStyle.Color = Color.White;
            return triangle;
        }
        private PolylineNode getPolyLine()
        {
            PointF[] pts = new PointF[] { new PointF(15, 15), new PointF(0, 15), new PointF(5, 5), new PointF(10, 5), new PointF(10, 0), new PointF(15, 0) };
            Syncfusion.Windows.Forms.Diagram.PolylineNode poly = new Syncfusion.Windows.Forms.Diagram.PolylineNode(pts);            
            poly.LineStyle.LineColor = Color.Black;
            return poly;
        }
        
        
    }