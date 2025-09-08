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
using System.Drawing.Imaging;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Diagram.Controls;
using System.Drawing.Drawing2D;
using Syncfusion.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using Syncfusion.SVG.IO;
using System.Collections;
using System.Xml;
using DemoCommon.Diagram;

namespace ExpanderDemo
{
    public partial class Form1 : MetroForm
    {
#region Members
        protected OrgChartLayoutManager dtLayoutMgr;
#endregion

#region Form initialize
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            diagram1.BeginUpdate();
            diagram1.View.Grid.Visible = false;
            diagram1.View.BackgroundColor = Color.White;
            
            comboDirection.SelectedIndex = 0;
            diagram1.MouseMove += new MouseEventHandler(diagram1_MouseMove);
            diagram1.EventSink.NodeMouseEnter += new Syncfusion.Windows.Forms.Diagram.NodeMouseEventHandler(EventSink_NodeMouseEnter);
            diagram1.Model.RenderingStyle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            diagram1.Model.BoundaryConstraintsEnabled = false;
            for (int i = 0; i <= 11; i++)
            {
                ExpanderNode expander = new ExpanderNode(new RectangleF(0, 0, 90, 60));
                expander.Name = i.ToString();
                diagram1.Model.AppendChild(expander);
            }

            Connect(diagram1.Model.Nodes["0"], diagram1.Model.Nodes["1"]);
            Connect(diagram1.Model.Nodes["0"], diagram1.Model.Nodes["2"]);
            Connect(diagram1.Model.Nodes["2"], diagram1.Model.Nodes["3"]);
            Connect(diagram1.Model.Nodes["2"], diagram1.Model.Nodes["4"]);
            Connect(diagram1.Model.Nodes["2"], diagram1.Model.Nodes["5"]);
            Connect(diagram1.Model.Nodes["5"], diagram1.Model.Nodes["6"]);
            Connect(diagram1.Model.Nodes["5"], diagram1.Model.Nodes["7"]);
            Connect(diagram1.Model.Nodes["1"], diagram1.Model.Nodes["8"]);
            Connect(diagram1.Model.Nodes["1"], diagram1.Model.Nodes["9"]);
            Connect(diagram1.Model.Nodes["1"], diagram1.Model.Nodes["10"]);
            Connect(diagram1.Model.Nodes["1"], diagram1.Model.Nodes["11"]);

            LayoutNodes();
           
            diagram1.EndUpdate();
            comboDirection.SelectedIndexChanged += new EventHandler(comboDirection_SelectedIndexChanged);
            diagram1.Controller.InPlaceEditor.LabelEditingCompleted += InPlaceEditor_LabelEditingCompleted;
        }

        void InPlaceEditor_LabelEditingCompleted(object sender, LabelEditingCompletedEventArgs evtArgs)
        {
            InPlaceEditor label = new InPlaceEditor(diagram1.Controller);
            PathNode node = evtArgs.NodeAffected as PathNode;
            if (node.Labels[0].FontStyle.Size > 24)
            {
                node.Labels[0].FontStyle.Size = 24;
                MessageBox.Show("Please set Font size less than 24 for clear view");
            }
        }

#endregion

#region Private methods
        /// <summary>
        /// Change's the appearance of Diagram
        /// </summary>
        private void DiagramAppearance()
        {
            this.diagram1.MetroScrollBars = true;
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            this.diagram1.View.Grid.GridStyle = GridStyle.Line;
            this.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.diagram1.View.Grid.Color = Color.LightGray;
            this.diagram1.View.Grid.VerticalSpacing = 15;
            this.diagram1.View.Grid.HorizontalSpacing = 15;
            this.diagram1.Model.BackgroundStyle.GradientCenter = 0.5f;
            this.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue;
            this.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue;        
            this.diagram1.Model.BoundaryConstraintsEnabled = false;           
            diagram1.View.BackgroundColor = Color.White;
            this.diagram1.View.SelectionList.Clear();

        }
#endregion

#region Initialize Diagram

        /// <summary>
        /// Apply layout to the Diagram
        /// </summary>
        private void LayoutNodes()
        {
            diagram1.View.SelectionList.Clear();
            OrgChartLayoutManager layout = new OrgChartLayoutManager(diagram1.Model, RotateDirection.TopToBottom, 30, 80);
            layout.LeftMargin = 10;
            layout.TopMargin = 50;
            diagram1.LayoutManager = layout;
            layout.AutoLayout = true;
            //diagram1.LayoutManager.AutoLayout = true;
            diagram1.LayoutManager.UpdateLayout(null);            
        }

        /// <summary>
        /// Connects the two nodes with connector
        /// </summary>
        /// <param name="parent">From Node</param>
        /// <param name="child">To Node</param>
        private void Connect(Node parent, Node child)
        {
            OrgLineConnector link = new OrgLineConnector(PointF.Empty, new PointF(1, 1));
            link.LineStyle.LineWidth = 2;
            link.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
            link.HeadDecorator.FillStyle.Color = Color.Gray;
            link.HeadDecorator.LineStyle.LineColor = Color.LightGray;
            link.HeadDecorator.Size = new SizeF(8, 8);
            link.LineStyle.LineColor = Color.LightGray;
            parent.CentralPort.Connect(link.TailEndPoint);
            child.CentralPort.Connect(link.HeadEndPoint);
            link.EditStyle.AllowSelect = false;
            diagram1.Model.AppendChild(link);
        } 

#endregion
        
#region Event Handlers      
        
        void comboDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrgChartLayoutManager mgr = diagram1.LayoutManager as OrgChartLayoutManager;
            if (mgr != null)
            {
                if (comboDirection.SelectedIndex == 0)
                    mgr.RotateDirection = RotateDirection.TopToBottom;
                if (comboDirection.SelectedIndex == 1)
                    mgr.RotateDirection = RotateDirection.BottomToTop;
                if (comboDirection.SelectedIndex == 2)
                    mgr.RotateDirection = RotateDirection.LeftToRight;
                if (comboDirection.SelectedIndex == 3)
                    mgr.RotateDirection = RotateDirection.RightToLeft;
                mgr.UpdateLayout(null);
            }
        }

        void EventSink_NodeMouseEnter(Syncfusion.Windows.Forms.Diagram.NodeMouseEventArgs evtArgs)
        {
            diagram1.Controller.ActiveTool.ActionCursor = Cursors.Arrow;
        }

        void diagram1_MouseMove(object sender, MouseEventArgs e)
        {
            ExpanderNode node = diagram1.Controller.GetNodeAtPoint(diagram1.Controller.ConvertToModelCoordinates(e.Location)) as ExpanderNode;
            if (node != null)
            {
                node.MouseMove(diagram1.Controller.ConvertToModelCoordinates(e.Location));
            }
        }
        

#endregion
               
    }
}