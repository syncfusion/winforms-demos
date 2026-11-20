using System;
using System.Collections.Generic;

using System.Text;
using Syncfusion.Windows.Forms.Diagram;
using System.Drawing;

    public class HeaderRectanglePlan:Group
    {
        public HeaderRectanglePlan()
        {
            Syncfusion.Windows.Forms.Diagram.Rectangle MainRect = new Syncfusion.Windows.Forms.Diagram.Rectangle(0, 0, 200, 150);
            MainRect.FillStyle.Color = Color.White;
            MainRect.LineStyle.LineColor = Color.Black;

            Syncfusion.Windows.Forms.Diagram.Rectangle HeadContent = new Syncfusion.Windows.Forms.Diagram.Rectangle(MainRect.BoundingRectangle.Width / 2 - 50, -10, 100, 20);
            HeadContent.FillStyle.Color = Color.LightYellow;
            Syncfusion.Windows.Forms.Diagram.Label lbl = new Syncfusion.Windows.Forms.Diagram.Label();
            lbl.Text = "Plan";
            lbl.SizeToNode = true;
            lbl.Position = Position.Center;
            lbl.FontStyle.Size = 12;
            lbl.FontStyle.Bold = true;
            HeadContent.Labels.Add(lbl);
            this.AppendChild(MainRect);
            this.AppendChild(HeadContent);

            Syncfusion.Windows.Forms.Diagram.Rectangle rects;
            rects = new Syncfusion.Windows.Forms.Diagram.Rectangle(15, 30, 10, 10);
            rects.FillStyle.Color = Color.Yellow;
            rects.LineStyle.LineColor = Color.Black;
            this.AppendChild(rects);

            rects = new Syncfusion.Windows.Forms.Diagram.Rectangle(20, 35, 10, 10);
            rects.FillStyle.Color = Color.Yellow;
            rects.LineStyle.LineColor = Color.Black;
            this.AppendChild(rects);

            RectangleF rect = new RectangleF(40, 30, 150, 25);
            TextNode txtContent = new TextNode("-Planning", rect);
            txtContent.BackgroundStyle.Color = Color.Transparent;
            txtContent.LineStyle.LineWidth = 0;
            txtContent.FontStyle.Size = 10;
            txtContent.ReadOnly = true;
            txtContent.HorizontalAlignment = StringAlignment.Near;
            txtContent.VerticalAlignment = StringAlignment.Center;
            this.AppendChild(txtContent);

            PointF[] pts = new PointF[] { new PointF(25, 5), new PointF(5, 5), new PointF(15, 15) };
            Syncfusion.Windows.Forms.Diagram.Polygon triangle = new Syncfusion.Windows.Forms.Diagram.Polygon(pts);
            triangle.PinPoint = new PointF(15+ triangle.BoundingRectangle.Width / 2, 65);
            triangle.FillStyle.Color = Color.White;
            this.AppendChild(triangle);

            rect = new RectangleF(40, 52.5f, 150, 25);
            txtContent = new TextNode("-Activity", rect);
            txtContent.BackgroundStyle.Color = Color.Transparent;
            txtContent.LineStyle.LineWidth = 0;
            txtContent.FontStyle.Size = 10;
            txtContent.ReadOnly = true;
            txtContent.HorizontalAlignment = StringAlignment.Near;
            txtContent.VerticalAlignment = StringAlignment.Center;
            this.AppendChild(txtContent);


            pts = new PointF[] { new PointF(15, 15), new PointF(0, 15), new PointF(5, 5), new PointF(10, 5), new PointF(10, 0), new PointF(15, 0) };
            Syncfusion.Windows.Forms.Diagram.PolylineNode star = new Syncfusion.Windows.Forms.Diagram.PolylineNode(pts);
            star.PinPoint = new PointF(15 + triangle.BoundingRectangle.Width / 2, 88);
            star.LineStyle.LineColor = Color.Black;
            this.AppendChild(star);

            rect = new RectangleF(40, 77.5f, 150, 25);
            txtContent = new TextNode("-StartUp", rect);
            txtContent.BackgroundStyle.Color = Color.Transparent;
            txtContent.LineStyle.LineWidth = 0;
            txtContent.FontStyle.Size = 10;
            txtContent.ReadOnly = true;
            txtContent.HorizontalAlignment = StringAlignment.Near;
            txtContent.VerticalAlignment = StringAlignment.Center;
            this.AppendChild(txtContent);

            Syncfusion.Windows.Forms.Diagram.Ellipse ellipse;
            ellipse = new Syncfusion.Windows.Forms.Diagram.Ellipse(18, 105, 15, 15);
            ellipse.FillStyle.Color = Color.Blue;
            ellipse.LineStyle.LineWidth = 0;
            this.AppendChild(ellipse);

            ellipse = new Syncfusion.Windows.Forms.Diagram.Ellipse(20.5f, 107.5f, 10, 10);
            ellipse.FillStyle.Color = Color.Gray;
            ellipse.LineStyle.LineWidth = 0;
            this.AppendChild(ellipse);

            rect = new RectangleF(40, 100, 150, 25);
            txtContent = new TextNode("-Cost Savings Sort", rect);
            txtContent.BackgroundStyle.Color = Color.Transparent;
            txtContent.LineStyle.LineWidth = 0;
            txtContent.FontStyle.Size = 10;
            txtContent.ReadOnly = true;
            txtContent.HorizontalAlignment = StringAlignment.Near;
            txtContent.VerticalAlignment = StringAlignment.Center;
            this.AppendChild(txtContent);

            pts = new PointF[] { new PointF(0, 5), new PointF(5, 5), new PointF(10, 0), new PointF(15, 5), new PointF(20, 5), new PointF(15, 10), new PointF(20, 15), new PointF(15, 15), new PointF(10, 20), new PointF(5, 15), new PointF(0, 15), new PointF(5, 10), new PointF(0, 5) };
            Syncfusion.Windows.Forms.Diagram.Polygon star1 = new Syncfusion.Windows.Forms.Diagram.Polygon(pts);
            star1.PinPoint = new PointF(17 + star1.BoundingRectangle.Width / 2, 140);
            star1.FillStyle.Color = Color.Gray;
            this.AppendChild(star1);

            rect = new RectangleF(40, 127, 150, 25);
            txtContent = new TextNode("-Evaluate & Close", rect);
            txtContent.BackgroundStyle.Color = Color.Transparent;
            txtContent.LineStyle.LineWidth = 0;
            txtContent.FontStyle.Size = 10;
            txtContent.ReadOnly = true;
            txtContent.HorizontalAlignment = StringAlignment.Near;
            txtContent.VerticalAlignment = StringAlignment.Center;
            this.AppendChild(txtContent);
            this.EditStyle.AllowSelect = false;                       
        }
    }