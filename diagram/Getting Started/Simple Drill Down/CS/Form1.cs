#region Copyright Syncfusion Inc. 2001 - 2012
// Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
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
using System.Drawing.Drawing2D;
using Syncfusion.Windows.Forms;

namespace SimpleDrillDown
{
    public partial class Form1 : MetroForm
    {
        #region Form Initialize
        public Form1()
        {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            // Add a textnode to the home page (Model1)
            this.diagram1.Model = this.model1;
            DiagramAppearance();
            Syncfusion.Windows.Forms.Diagram.TextNode txtnode = new TextNode(" Coevals Diagram ");
            txtnode.FontStyle.Family = "Arial";
            txtnode.FontStyle.Size = 18;
            txtnode.FontStyle.Bold = true;
            txtnode.FontColorStyle.Color = Color.MidnightBlue;
            txtnode.LineStyle.LineColor = Color.Transparent;
            txtnode.SizeToText(new Size(1000, 1000));
            InsertNode(txtnode, new PointF(200, 20));

            Syncfusion.Windows.Forms.Diagram.TextNode txtnode1 = new TextNode("Expand and Collapse concept is featured with this DrillDown.");
            txtnode1.FontStyle.Size = 9;
            txtnode1.FontStyle.Bold = true;
            txtnode1.FontColorStyle.Color = Color.MidnightBlue;
            txtnode1.LineStyle.LineColor = Color.Transparent;
            txtnode1.FontStyle.Family = "Arial";
            txtnode1.FontStyle.Size = 8;
            txtnode1.VerticalAlignment = StringAlignment.Center;
            txtnode1.WrapText = true;
            txtnode1.SizeToText(new Size(100, 100));
            txtnode1.PinPoint = new PointF(540, 95);
            InsertNode(txtnode1, new PointF(540, 95));
           
            // Add a button that gets triggered to present Model2 
            this.diagram1.Model.AppendChild(new GrandMotherSymbolClass(this.diagram1, this.model1, this.model2));
            this.diagram1.Controller.InPlaceEditing = false;
            this.diagram1.View.SelectionList.Clear();

            this.diagram1.EventSink.NodeMouseEnter += new NodeMouseEventHandler(EventSink_NodeMouseEnter);
            this.diagram1.EventSink.NodeMouseLeave += new NodeMouseEventHandler(EventSink_NodeMouseLeave);
        }
        #endregion

        #region Event Handlers

        void EventSink_NodeMouseLeave(NodeMouseEventArgs evtArgs)
        {
            diagram1.Controller.ActiveTool.ActionCursor = Cursors.Arrow;
        }

        void EventSink_NodeMouseEnter(NodeMouseEventArgs evtArgs)
        {
            diagram1.Controller.ActiveTool.ActionCursor = Cursors.Hand;
        }

        #endregion

        #region Private Methods
        /// <summary>
        /// Inserts the node into the diagram at given location
        /// </summary>
        /// <param name="node">Node</param>
        /// <param name="ptLocation">Node's Location</param>
        /// <returns></returns>
        private Node InsertNode(Node node, PointF ptLocation)
        {
            MeasureUnits units = MeasureUnits.Pixel;

            SizeF szPinOffset = ((IUnitIndependent)node).GetPinPointOffset(units);
            ptLocation.X += szPinOffset.Width;
            ptLocation.Y += szPinOffset.Height;
            ((IUnitIndependent)node).SetPinPoint(ptLocation, units);

            this.diagram1.Model.AppendChild(node);
            return node;
        }

        /// <summary>
        /// Changes the appearance of the diagram
        /// </summary>
        private void DiagramAppearance()
        {
            this.diagram1.View.Grid.GridStyle = GridStyle.Line;
            this.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.diagram1.View.Grid.Color = Color.LightGray;
            this.diagram1.View.Grid.VerticalSpacing = 15;
            this.diagram1.View.Grid.HorizontalSpacing = 15;
            this.diagram1.Model.BackgroundStyle.GradientCenter = 0.5f;
            this.diagram1.View.HandleColor = Color.AliceBlue;
            this.diagram1.View.HandleOutlineColor = Color.SkyBlue;
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            this.diagram1.View.SelectionList.Clear();

        }
        #endregion

    }
}