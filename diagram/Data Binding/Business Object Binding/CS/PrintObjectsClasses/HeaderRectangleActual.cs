using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Diagram;
using System.Drawing;


    public class HeaderRectangleActual:Group
    {
        public HeaderRectangleActual()
        {
            Syncfusion.Windows.Forms.Diagram.Rectangle MainRect = new Syncfusion.Windows.Forms.Diagram.Rectangle(0, 0, 200, 150);
            MainRect.FillStyle.Color = Color.White;
            MainRect.LineStyle.LineColor = Color.Black;

            Syncfusion.Windows.Forms.Diagram.Rectangle HeadContent = new Syncfusion.Windows.Forms.Diagram.Rectangle(MainRect.BoundingRectangle.Width/2-50, -10, 100, 20);
            HeadContent.FillStyle.Color = Color.LightYellow;
            Syncfusion.Windows.Forms.Diagram.Label lbl = new Syncfusion.Windows.Forms.Diagram.Label();
            lbl.Text = "Actual";
            lbl.SizeToNode = true;
            lbl.Position = Position.Center;
            lbl.FontStyle.Size = 12;
            lbl.FontStyle.Bold = true;
            HeadContent.Labels.Add(lbl);
            this.AppendChild(MainRect);
            this.AppendChild(HeadContent);      

            Syncfusion.Windows.Forms.Diagram.Ellipse ellipse;
            ellipse  = new Syncfusion.Windows.Forms.Diagram.Ellipse(10, 40, 15, 15);
            ellipse.FillStyle.Color = Color.Green;

            RectangleF rect = new RectangleF(30, 35, 150, 25);
            TextNode txtContent = new TextNode("=OnSchedule", rect);
            txtContent.BackgroundStyle.Color = Color.Transparent;
            txtContent.LineStyle.LineWidth = 0;
            txtContent.FontStyle.Size = 10;                        
            txtContent.ReadOnly = true;
            txtContent.HorizontalAlignment = StringAlignment.Near;
            txtContent.VerticalAlignment = StringAlignment.Center;
            this.AppendChild(txtContent);
            this.AppendChild(ellipse);
         
            ellipse = new Syncfusion.Windows.Forms.Diagram.Ellipse(10, 70, 15, 15);
            ellipse.FillStyle.Color = Color.Yellow;

            rect = new RectangleF(30, 65, 150, 25);
            txtContent = new TextNode("=Behind Schedule", rect);
            txtContent.BackgroundStyle.Color = Color.Transparent;
            txtContent.LineStyle.LineWidth = 0;
            txtContent.FontStyle.Size = 10;
            txtContent.ReadOnly = true;
            txtContent.HorizontalAlignment = StringAlignment.Near;
            txtContent.VerticalAlignment = StringAlignment.Center;
            this.AppendChild(txtContent);
            this.AppendChild(ellipse);

            ellipse = new Syncfusion.Windows.Forms.Diagram.Ellipse(10, 100, 15, 15);
            ellipse.FillStyle.Color = Color.Red;

            rect = new RectangleF(30, 95, 150, 25);
            txtContent = new TextNode("=Critically Behind", rect);
            txtContent.BackgroundStyle.Color = Color.Transparent;
            txtContent.LineStyle.LineWidth = 0;
            txtContent.FontStyle.Size = 10;
            txtContent.ReadOnly = true;
            txtContent.HorizontalAlignment = StringAlignment.Near;
            txtContent.VerticalAlignment = StringAlignment.Center;
            this.AppendChild(txtContent);
            this.AppendChild(ellipse);

            ellipse = new Syncfusion.Windows.Forms.Diagram.Ellipse(10, 130, 15, 15);
            ellipse.FillStyle.Color = Color.Blue;

            rect = new RectangleF(30, 125, 120, 25);
            txtContent = new TextNode("=Complete", rect);
            txtContent.BackgroundStyle.Color = Color.Transparent;
            txtContent.LineStyle.LineWidth = 0;
            txtContent.FontStyle.Size = 10;
            txtContent.ReadOnly = true;
            txtContent.HorizontalAlignment = StringAlignment.Near;
            txtContent.VerticalAlignment = StringAlignment.Center;
            this.AppendChild(txtContent);
            this.AppendChild(ellipse);
            this.EditStyle.AllowSelect = false;                   
        }
    }