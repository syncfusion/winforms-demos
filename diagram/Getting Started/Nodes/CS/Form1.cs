#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Diagram;
using System.IO;
using Syncfusion.Windows.Forms.Diagram.Controls;
using Syncfusion.Windows.Forms.Tools;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using Syncfusion.SVG.IO;
using Syncfusion.Windows.Forms;

namespace NodesDemo
{
    public partial class Form1 : Form
    {
        #region From Initialize
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           this.diagram1.BeginUpdate();
           InitializeDiagram();          
           DiagramAppearance();         
           this.diagram1.EndUpdate();
       }

        #endregion

        #region Private Methods
       /// <summary>
       /// Change's the appearance of Diagram
       /// </summary>
        private void DiagramAppearance()
        {
            this.diagram1.Model.LineStyle.LineColor = Color.LightGray;
            this.diagram1.HorizontalRuler.BackgroundColor = Color.White;
            this.diagram1.VerticalRuler.BackgroundColor = Color.White;  
            this.diagram1.View.Grid.GridStyle = GridStyle.Line;
            this.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.diagram1.View.Grid.Color = Color.LightGray;
            this.diagram1.View.Grid.VerticalSpacing = 15;
            this.diagram1.View.Grid.HorizontalSpacing = 15;
            this.diagram1.Model.BackgroundStyle.GradientCenter = 0.5f;
            this.diagram1.View.HandleColor = Color.AliceBlue;
            this.diagram1.View.HandleOutlineColor = Color.SkyBlue;
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            this.diagram1.View.Grid.Visible = false;
            this.diagram1.Model.BoundaryConstraintsEnabled = false;          
            this.diagram1.View.SelectionList.Clear();
        }
       #endregion

        #region Initialize the diagram

        /// <summary>
        /// initializes the Diagram data  
        /// </summary>
        private void InitializeDiagram()
        {
            Syncfusion.Windows.Forms.Diagram.Rectangle rect = new Syncfusion.Windows.Forms.Diagram.Rectangle(100, 25, 120, 75);            
            rect.FillStyle.Color = Color.FromArgb(240, 242, 240);
            rect.FillStyle.ForeColor = Color.White;
            rect.FillStyle.Type = FillStyleType.LinearGradient;
            rect.LineStyle.LineColor = Color.DarkGray;
            AddLabel(rect, "Rectangle", Position.Center);
            diagram1.Model.AppendChild(rect);

            Syncfusion.Windows.Forms.Diagram.RoundRect roundRect = new Syncfusion.Windows.Forms.Diagram.RoundRect(400, 25, 120, 75, MeasureUnits.Pixel);           
            roundRect.FillStyle.Color = Color.FromArgb(240, 242, 240);
            roundRect.FillStyle.ForeColor = Color.White;
            roundRect.LineStyle.LineColor = Color.DarkGray;
            roundRect.FillStyle.Type = FillStyleType.LinearGradient;
            AddLabel(roundRect, "RoundRect1", Position.Center);
            diagram1.Model.AppendChild(roundRect);

            Ellipse ellipse1 = new Ellipse(100, 125, 120, 80);          
            ellipse1.FillStyle.Color = Color.FromArgb(240, 242, 240);
            ellipse1.FillStyle.ForeColor = Color.White;
            ellipse1.LineStyle.LineColor = Color.DarkGray;
            ellipse1.FillStyle.Type = FillStyleType.LinearGradient;
            AddLabel(ellipse1, "Ellipse", Position.Center);
            diagram1.Model.AppendChild(ellipse1);
            
            Polygon poly = new Polygon(new PointF[] { new PointF(160, 235), new PointF(100, 265), new PointF(120, 325), new PointF(200, 325), new PointF(220, 265) });
            poly.FillStyle.Color = Color.FromArgb(240, 242, 240);
            poly.FillStyle.ForeColor = Color.White;
            poly.FillStyle.Type = FillStyleType.LinearGradient;
            poly.LineStyle.LineColor = Color.DarkGray;
            AddLabel(poly, "Polygon", Position.Center);
            diagram1.Model.AppendChild(poly);

            SemiCircle semiCircle = new SemiCircle(400, 125, 120, 75);          
            semiCircle.FillStyle.Color = Color.FromArgb(240, 242, 240);
            semiCircle.FillStyle.ForeColor = Color.White;
            semiCircle.FillStyle.Type = FillStyleType.LinearGradient;
            semiCircle.LineStyle.LineColor = Color.DarkGray;
            AddLabel(semiCircle, "SemiCircle", Position.Center);
            diagram1.Model.AppendChild(semiCircle);

            TextNode textNode = new TextNode("TextNode1", new RectangleF(400,245, 120,50));                      
            textNode.FontStyle.Size = 9;
            textNode.FontStyle.Family = "Segoe UI";
            textNode.HorizontalAlignment = StringAlignment.Center;
            textNode.VerticalAlignment = StringAlignment.Center;            
            textNode.LineStyle.LineColor = Color.DarkGray;
            textNode.FontColorStyle.Color = Color.Black;
            diagram1.Model.AppendChild(textNode);

            RichTextNode richTextNode = new RichTextNode(@"{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fnil\fcharset0 Meiryo UI;}{\f1\fnil\fcharset0 Microsoft Sans Serif;}}
{\colortbl ;\red255\green0\blue0;\red0\green64\blue128;}
\viewkind4\uc1\pard\b\f0\fs17 This is a text symbol\f1  \b0\f0 designed using the \cf1\b\i Essential Diagram\i0  \cf2\ul RichText\ulnone  node\cf0\b0 .\par
\i\f1\fs20\par
}", new RectangleF(400, 320, 120, 100));            
            richTextNode.LineStyle.LineColor = Color.DarkGray;
            diagram1.Model.AppendChild(richTextNode);

#if !NETCORE
            BitmapNode bmpNode = new BitmapNode(@"..\..\..\..\..\..\common\Images\Diagram\OrgChart Layout\image3.png");
#else
            BitmapNode bmpNode = new BitmapNode(@"..\..\..\..\..\..\..\common\Images\Diagram\OrgChart Layout\image3.png");
#endif
            bmpNode.Name = "BitmapNode1";
            bmpNode.PinPoint = new PointF(700, 75);
            bmpNode.Size = new SizeF(120, 100);
            bmpNode.LineStyle.LineWidth = 0;
            diagram1.Model.AppendChild(bmpNode);           

            ClosedCurveNode curve = new ClosedCurveNode(new PointF[] { new PointF(120, 350), new PointF(120, 450), new PointF(220, 400) });           
            curve.FillStyle.Color = Color.FromArgb(240, 242, 240);
            curve.FillStyle.ForeColor = Color.White;
            curve.FillStyle.Type = FillStyleType.LinearGradient;
            curve.LineStyle.LineColor = Color.DarkGray;            
            AddLabel(curve, "ClosedCurve", Position.Center);
            diagram1.Model.AppendChild(curve);
           
            CurveNode curve1 = new CurveNode(new PointF[] { new PointF(120, 100), new PointF(120, 200), new PointF(220, 150) });
            curve1 = new CurveNode(new PointF[] { new PointF(0, 30), new PointF(4.99999952f, 25), new PointF(18.3333321f, 0), new PointF(30, 0), new PointF(41.66666641f, 0), new PointF(58.33333321f, 30), new PointF(70, 30), new PointF(81.66666f, 30), new PointF(95, 4.99999952f), new PointF(100, 0) });                  
            AddLabel(curve1, "CurveNode", Position.Center);
            diagram1.Model.AppendChild(curve1);

            CircularArc circular = new CircularArc(new RectangleF(640, 150, 100, 100), 0, 270);
            circular.FillStyle.Color = Color.FromArgb(240, 242, 240);
            circular.FillStyle.ForeColor = Color.White;
            circular.FillStyle.Type = FillStyleType.LinearGradient;
            circular.LineStyle.LineColor = Color.DarkGray;
            circular.PinPoint = new PointF(700, 200);
            AddLabel(circular, "CircularArc", Position.Center);
            diagram1.Model.AppendChild(circular);

            Line line1 = new Line(new PointF(700, 320), new PointF(700, 430));
            line1.LineStyle.LineColor = Color.DarkGray;
            AddLabel(line1, "line", Position.TopCenter);           
            diagram1.Model.AppendChild(line1);

            PolylineNode polyLine = new PolylineNode(new PointF[] { new PointF(640, 500), new PointF(760, 500), new PointF(640, 540), new PointF(760, 540) });
            polyLine.LineStyle.LineColor = Color.DarkGray;
            polyLine.LineStyle.LineWidth = 1;
            Syncfusion.Windows.Forms.Diagram.Label label = new Syncfusion.Windows.Forms.Diagram.Label(polyLine, "PolyLine Node");
            label.OffsetX = polyLine.BoundingRectangle.Width / 5f;
            label.OffsetY = polyLine.BoundingRectangle.Height + 10;
            label.FontStyle.Family = "Segoe UI";
            label.FontColorStyle.Color = Color.Black;
            label.FontStyle.Size = 9;
            polyLine.Labels.Add(label);
            diagram1.Model.AppendChild(polyLine);

            BezierCurve bezier = new BezierCurve(new PointF[] { new PointF(100, 470), new PointF(160, 470), new PointF(160, 560), new PointF(220, 560) });           
            AddLabel(bezier, "BezierCurve", Position.BottomCenter);
            diagram1.Model.AppendChild(bezier);

            SplineNode spline = new SplineNode(new PointF[] { new PointF(400, 460), new PointF(520, 500), new PointF(400, 520) });
            spline.LineStyle.LineColor = Color.Black;
            spline.LineStyle.LineWidth = 1;            
            AddLabel(spline, "Spline", Position.BottomCenter);
            diagram1.Model.AppendChild(spline);

        }
#endregion

#region Event Handlers

        private void toolStrip1_ItemClicked(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
        {
            ToolStrip tool = sender as ToolStrip;
            foreach (ToolStripButton selecteditem in tool.Items)
            {
                if (selecteditem.BackColor == Color.LightBlue)
                {
                    selecteditem.BackColor = System.Drawing.Color.Transparent;
                }
            }
            e.ClickedItem.BackColor = Color.LightBlue;
        }

        private void rectToolStripButton_Click(object sender, EventArgs e)
        {
            SetActiveTool("RectangleTool");
        }

        private void ellpToolStripButton_Click(object sender, EventArgs e)
        {
            SetActiveTool("EllipseTool");
        }

        private void rrectToolStripButton_Click(object sender, EventArgs e)
        {
            SetActiveTool("RoundRectTool");
        }

        private void polyToolStripButton_Click(object sender, EventArgs e)
        {
            SetActiveTool("PolygonTool");
        }

        private void semiStripButton12_Click(object sender, EventArgs e)
        {
            SetActiveTool("SemiCircleTool");
        }

        private void carcToolStripButton_Click(object sender, EventArgs e)
        {
            CircularArc carc = new CircularArc(new RectangleF(300,300,100,70));
            // set your custom node to the NodeToInsert property
            this.diagram1.Controller.NodeToInsert = carc;
            SetActiveTool("InsertNodeTool");
        }

        private void bmpToolStripButton_Click(object sender, EventArgs e)
        {
            SetActiveTool("BitmapTool");
        }

        private void textToolStripButton_Click(object sender, EventArgs e)
        {
            SetActiveTool("TextTool");
        }

        private void rchtxtToolStripButton_Click(object sender, EventArgs e)
        {
            SetActiveTool("RichTextTool");
        }

        private void lineToolStripButton_Click(object sender, EventArgs e)
        {
            SetActiveTool("LineTool");
        }

        private void polylneToolStripButton_Click(object sender, EventArgs e)
        {
            SetActiveTool("PolyLineTool");
        }

        private void curveToolStripButton_Click(object sender, EventArgs e)
        {
            SetActiveTool("CurveTool");
        }

        private void closdCurvToolStripButton_Click(object sender, EventArgs e)
        {
            SetActiveTool("ClosedCurveTool");
        }

        private void splineToolStripButton_Click(object sender, EventArgs e)
        {
            SetActiveTool("SplineTool");
        }

        private void bezierToolStripButton_Click(object sender, EventArgs e)
        {
            SetActiveTool("BezierTool");
        }
        private void pencilToolStripButton_Click(object sender, EventArgs e)
        {
            SetActiveTool("PencilTool");
        }
        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            string targetURL = @"http://help.syncfusion.com/";
            System.Diagnostics.Process.Start(targetURL);
        }
                
#endregion

#region Helper Methods
        /// <summary>
        /// Adds the label to the given node
        /// </summary>
        /// <param name="rect">Node</param>
        /// <param name="labelText">Label's Text</param>
        /// <param name="position">Label's position</param>
        private static void AddLabel(Syncfusion.Windows.Forms.Diagram.PathNode rect, string labelText, Position position)
        {
            Syncfusion.Windows.Forms.Diagram.Label label = new Syncfusion.Windows.Forms.Diagram.Label(rect, labelText);
            label.Position = position;
            label.UpdatePosition = true;
            label.FontStyle.Family = "Segoe UI";
            label.FontColorStyle.Color = Color.Black;
            label.FontStyle.Size = 9;
            rect.Labels.Add(label);
        }

        private List<string> GetColors()
        {
            //create a generic list of strings
            List<string> colors = new List<string>();
            //get the color names from the Known color enum
            string[] colorNames = Enum.GetNames(typeof(KnownColor));
            //iterate thru each string in the colorNames array
            foreach (string colorName in colorNames)
            {
                //cast the colorName into a KnownColor
                KnownColor knownColor = (KnownColor)Enum.Parse(typeof(KnownColor), colorName);
                //check if the knownColor variable is a System color
                if (knownColor > KnownColor.Transparent)
                {
                    //add it to our list
                    colors.Add(colorName);
                }
            }
            //return the color list
            return colors;
        }

        /// <summary>
        /// Activates the given tool
        /// </summary>
        /// <param name="toolName">Tool to be activated</param>
        private void SetActiveTool(string toolName)
        {
            this.diagram1.Controller.ActivateTool(toolName);
        }

#endregion

       

    }
}

