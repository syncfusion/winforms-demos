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


namespace Overview
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
            diagram1.BeginUpdate();
            this.overviewControl1.Diagram = this.diagram1;
          
            PopulateNodes();
            DiagramAppearance();

            DirectedTreeLayoutManager dtLayoutManager = new DirectedTreeLayoutManager(this.diagram1.Model, 0, 40, 20, LayoutType.Horizontal, 1);
            dtLayoutManager.VerticalSpacing = 75;
            dtLayoutManager.TopMargin = 30;
            dtLayoutManager.LeftMargin = 10;
            this.diagram1.LayoutManager = dtLayoutManager;
            this.diagram1.LayoutManager.UpdateLayout(null);         

            diagram1.EndUpdate();
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
            this.diagram1.Model.DocumentSize = new PageSize(this.diagram1.View.ClientRectangle.Size.Width-5, diagram1.View.ClientRectangle.Size.Height-5);
            this.diagram1.Model.BoundaryConstraintsEnabled = false;
            this.diagram1.Model.MinimumSize = diagram1.View.ClientRectangle.Size;
            this.diagram1.Model.SizeToContent = true;
            this.diagram1.View.SelectionList.Clear();
        }
        #endregion

        #region Initialize Diagram
        /// <summary>
        /// Populate a nodes
        /// </summary>
        private void PopulateNodes()
        {
            //first level of nodes
            Syncfusion.Windows.Forms.Diagram.Rectangle parentNode = GetRectangle();
            this.diagram1.Model.AppendChild(parentNode);

            for (int i = 1; i <= 5; i++)
            {
                // Create a new instance of rectangle for childnode
                Syncfusion.Windows.Forms.Diagram.Rectangle rect = GetRectangle();
                this.diagram1.Model.AppendChild(rect);
                ConnectNodes(parentNode, rect, Color.SteelBlue);
                for (int j = 1; j <= 2; j++)
                {
                    //Create a new instance of rectangle for childnode1
                    Syncfusion.Windows.Forms.Diagram.Rectangle rect1 = GetRectangle();
                    this.diagram1.Model.AppendChild(rect1);
                    ConnectNodes(rect, rect1, Color.SteelBlue);

                    for (int k = 1; k <= 3; k++)
                    {
                        //Create a new instance of rectangle for childnode2
                        Syncfusion.Windows.Forms.Diagram.Rectangle rect2 = GetRectangle();
                        this.diagram1.Model.AppendChild(rect2);
                        ConnectNodes(rect1, rect2, Color.SteelBlue);

                        if (k == 2)
                        {
                            for (int l = 1; l <= 2; l++)
                            {
                                //Create a new instance of rectangle for childnode3
                                Syncfusion.Windows.Forms.Diagram.Rectangle rect3 = GetRectangle();
                                this.diagram1.Model.AppendChild(rect3);
                                ConnectNodes(rect2, rect3, Color.SteelBlue);
                            }
                        }
                    }
                }

            }
        }

        /// <summary>
        /// New function for create a rectangle
        /// </summary>
        /// <returns></returns>
        private Syncfusion.Windows.Forms.Diagram.Rectangle GetRectangle()
        {
            Syncfusion.Windows.Forms.Diagram.Rectangle rect = new Syncfusion.Windows.Forms.Diagram.Rectangle(0, 0, 40, 40);
            rect.FillStyle.Color = Color.FromArgb(94, 181, 193);
            rect.FillStyle.ForeColor = Color.FromArgb(63, 152, 165);
            rect.FillStyle.Type = FillStyleType.LinearGradient;
            rect.LineStyle.LineColor = Color.SteelBlue;
            //rect.EnableShading = true;
            return rect;
        }
        /// <summary>
        /// connect the nodes.
        /// </summary>
        /// <param name="parentNode">parentNode</param>
        /// <param name="childNode">childNode</param>
        /// <param name="connectionColor">ConnectionColor between parentNode and childNode</param>
        private void ConnectNodes(Node parentNode, Node childNode, Color connectionColor)
        {
            if (parentNode != null && childNode != null)
            {
                OrgLineConnector lConnector = new OrgLineConnector(PointF.Empty, new PointF(0, 1));
                lConnector.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
                lConnector.LineStyle.LineColor = connectionColor;
                lConnector.CentralPort.ConnectionsLimit = 10000;
                lConnector.HeadDecorator.Size = new SizeF(10, 10);
                lConnector.HeadDecorator.FillStyle.Color = Color.FromArgb(140, 180, 210);
                lConnector.HeadDecorator.LineStyle.LineColor = Color.SteelBlue;
                parentNode.CentralPort.TryConnect(lConnector.TailEndPoint);
                childNode.CentralPort.TryConnect(lConnector.HeadEndPoint);
                this.diagram1.Model.AppendChild(lConnector);
                this.diagram1.Model.SendToBack(lConnector);
            }
        }
        #endregion
    }
   
}
