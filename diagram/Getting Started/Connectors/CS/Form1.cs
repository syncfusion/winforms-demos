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

namespace ConnectorsDemo
{
    public partial class Form1 : Form
    {
        #region Members

        bool needSave = false;
        public string fileName;

        #endregion

        #region Form Initialization
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

        #region Initialize Diagram

        /// <summary>
        /// Initializes the Diagram data  
        /// </summary>
        private void InitializeDiagram()
        {
            LineConnector line = new LineConnector(new PointF[] { new PointF(320, 135), new PointF(480, 135) });
            line.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
            line.HeadDecorator.Size = new SizeF(10, 10);
            line.LineStyle.LineWidth = 1;            
            AddLabel(line, "DirectedLink", Position.BottomCenter);
            diagram1.Model.AppendChild(line);

            OrthogonalConnector orthogonalLine = new OrthogonalConnector(new PointF(50, 50), new PointF(245, 135));
            orthogonalLine.HeadDecorator.DecoratorShape = DecoratorShape.OpenFancyArrow;
            orthogonalLine.HeadDecorator.Size = new SizeF(10, 10);
            orthogonalLine.TailDecorator.DecoratorShape = DecoratorShape.FilledFancyArrow;
            orthogonalLine.TailDecorator.Size = new SizeF(10, 10);            
            orthogonalLine.LineStyle.LineWidth = 1;
            AddLabel(orthogonalLine, "OrthogonalLink", Position.BottomCenter);
            diagram1.Model.AppendChild(orthogonalLine);

            OrgLineConnector orgLine = new OrgLineConnector(new PointF(245, 200), new PointF(50, 285));
            orgLine.HeadDecorator.DecoratorShape = DecoratorShape.FilledDiamond;
            orgLine.HeadDecorator.Size = new SizeF(10, 10);
            orgLine.TailDecorator.DecoratorShape = DecoratorShape.Diamond;
            orgLine.TailDecorator.Size = new SizeF(10, 10);            
            orgLine.LineStyle.LineWidth = 1;
            AddLabel(orgLine, "OrgLineLink", Position.BottomCenter);
            diagram1.Model.AppendChild(orgLine);

            PolyLineConnector polyLine = new PolyLineConnector(new PointF[] { new PointF(320, 225), new PointF(455, 225), new PointF(320, 265), new PointF(455, 265) });
            polyLine.HeadDecorator.DecoratorShape = DecoratorShape.Circle;
            polyLine.HeadDecorator.Size = new SizeF(10, 10);
            polyLine.TailDecorator.DecoratorShape = DecoratorShape.FilledCircle;
            polyLine.TailDecorator.Size = new SizeF(10, 10);           
            polyLine.LineStyle.LineWidth = 1;
            AddLabel(polyLine, "PolylineLink", Position.BottomCenter);
            diagram1.Model.AppendChild(polyLine);

            SplineNode spline = new SplineNode(new PointF[] { new PointF(100, 400), new PointF(160, 430), new PointF(100, 480) });
            spline.HeadDecorator.DecoratorShape = DecoratorShape.FilledSquare;
            spline.HeadDecorator.Size = new SizeF(10, 10);
            spline.TailDecorator.DecoratorShape = DecoratorShape.Square;
            spline.TailDecorator.Size = new SizeF(10, 10);            
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
        
        private void lineToolStripButton_Click(object sender, EventArgs e)
        {
            SetActiveTool("LineLinkTool");
        }

        private void directLnToolStripButton_Click(object sender, EventArgs e)
        {
            SetActiveTool("DirectedLineLinkTool");
        }

        private void orthoToolStripButton_Click(object sender, EventArgs e)
        {
            SetActiveTool("OrthogonalLinkTool");
        }

        private void polyToolStripButton_Click(object sender, EventArgs e)
        {
            SetActiveTool("PolylineLinkTool");
        }
       
        private void splineToolStripButton_Click(object sender, EventArgs e)
        {
            SetActiveTool("SplineTool");
        }

        private void bezierToolStripButton_Click(object sender, EventArgs e)
        {
            SetActiveTool("BezierTool");
        }

        private void OrgLineTool_Click(object sender, EventArgs e)
        {
            SetActiveTool("OrgLineConnectorTool");
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            string targetURL = @"http://help.syncfusion.com/";
            System.Diagnostics.Process.Start(targetURL);
        }        

        #endregion

        #region Helper Methods
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

        /// <summary>
        /// Adds the Label to the given node.
        /// </summary>
        /// <param name="rect">Node</param>
        /// <param name="labelText">Label's Text</param>
        /// <param name="position">Label's Position</param>
        private static void AddLabel(Syncfusion.Windows.Forms.Diagram.PathNode rect, string labelText, Position position)
        {
            Syncfusion.Windows.Forms.Diagram.Label label = new Syncfusion.Windows.Forms.Diagram.Label(rect, labelText);
            label.Position = position;
            label.UpdatePosition = true;
            label.FontStyle.Family = "verdana";
            label.FontColorStyle.Color = Color.Black;
            label.FontStyle.Size = 9;
            rect.Labels.Add(label);
        }
        
        /// <summary>
        /// Activate the given tool. 
        /// </summary>
        /// <param name="toolName">Tool to be activated</param>
        private void SetActiveTool(string toolName)
        {
            this.diagram1.Controller.ActivateTool(toolName);
        }

        #endregion   

        
    }
}

