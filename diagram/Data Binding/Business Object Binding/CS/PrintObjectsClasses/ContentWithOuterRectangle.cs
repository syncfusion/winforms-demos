using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Diagram;
using System.Drawing;

public class ContentWithOuterRectangle : Group
    {
        private MeasureUnits units = MeasureUnits.Pixel;
        public ContentWithOuterRectangle(string content,string tip,Color BackColor,Color tipBackColor)
        {
            Syncfusion.Windows.Forms.Diagram.Rectangle ContentEmpty = new Syncfusion.Windows.Forms.Diagram.Rectangle(0, 0, 200, 10,units);
            ContentEmpty.FillStyle.Color = Color.Transparent;
            ContentEmpty.LineStyle.LineWidth = 0;  
            RectangleF rect = new RectangleF(0, 15, 200, 45);
            
            TextNode nodeRectHeader = new TextNode(content, rect);
            nodeRectHeader.EnableCentralPort = false;
            nodeRectHeader.BackgroundStyle.Color = BackColor;
            nodeRectHeader.BackgroundStyle.Color = Color.White;
            nodeRectHeader.LineStyle.LineWidth = 1;
            nodeRectHeader.FontStyle.Size = 10;                    
            nodeRectHeader.ReadOnly = true;
            nodeRectHeader.HorizontalAlignment = StringAlignment.Near;
            nodeRectHeader.VerticalAlignment = StringAlignment.Near;

            Syncfusion.Windows.Forms.Diagram.RoundRect roundrect = new Syncfusion.Windows.Forms.Diagram.RoundRect(ContentEmpty.Size.Width-20,0,40,15, units );
            roundrect.EnableCentralPort = false;
			// Add an outer RoundRectangle.	
			roundrect.FillStyle.ForeColor =  System.Drawing.Color.SkyBlue;
            roundrect.LineStyle.LineColor = Color.FromArgb(253, 188, 140);
            roundrect.FillStyle.Color =tipBackColor;
            roundrect.EnableShading = false;

            Syncfusion.Windows.Forms.Diagram.Label lblr = new Syncfusion.Windows.Forms.Diagram.Label();
            lblr.Text = tip;
            lblr.SizeToNode = true;
            lblr.Position = Position.Center;
            lblr.FontStyle.Size = 14;
            lblr.FontStyle.Bold = true;
            roundrect.Labels.Add(lblr);
            this.EnableCentralPort = true;
            ContentEmpty.EnableCentralPort = true;
            roundrect.EnableCentralPort = true;
            this.AppendChild(ContentEmpty);
            this.AppendChild(nodeRectHeader);            
            this.AppendChild(roundrect);
            this.EditStyle.AllowSelect = false;
        }
    }
