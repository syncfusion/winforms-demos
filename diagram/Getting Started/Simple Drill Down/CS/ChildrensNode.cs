#region Copyright Syncfusion Inc. 2001 - 2012
// Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Diagram;
using System.Drawing;
using System.Collections;
using System.Runtime.Serialization;
using System.Windows.Forms;


namespace SimpleDrillDown
{

    #region SymbolClassForMan
    class ManSymbolClass : Group
    {
        public Syncfusion.Windows.Forms.Diagram.RoundRect rrect = null;
        BitmapNode bmpnode = null;
        public ManSymbolClass()
        {
#if !NETCORE
            bmpnode = new BitmapNode(new Bitmap(@"..\..\..\..\..\..\common\Images\Diagram\Drill Down images\image3_48.png"));
#else
            bmpnode = new BitmapNode(new Bitmap(@"..\..\..\..\..\..\..\common\Images\Diagram\Drill Down images\image3_48.png"));
#endif
            bmpnode.Name = "Father";
            bmpnode.LineStyle.LineWidth = 0;
            bmpnode.PinPoint = new Point(305, 130);
           
            this.AppendChild(bmpnode);
            
        }

        private bool m_bExpanded = true;

#region ExpandAndCollapse
        protected override void OnMouseDoubleClick(EventArgs e)
        {
            // Get node root.
            Syncfusion.Windows.Forms.Diagram.Model diagramModel = this.Root;

            // Begin model update.
            diagramModel.BeginUpdate();

            // If node is expanded collapse its, else expand.
            if (m_bExpanded == false)
            {
                this.ExpandSubNodes(true);
            }
            else
            {
                this.CollapseSubNodes(true);
            }


            diagramModel.EndUpdate();

             
        }
        public void ExpandSubNodes(bool clickednode)
        {
            IGraphNode thisNode = this as IGraphNode;

            if (thisNode != null)
            {
                ICollection edgesLeaving = thisNode.EdgesLeaving;
                if (edgesLeaving != null)
                {
                    foreach (IGraphEdge curEdge in edgesLeaving)
                    {
                        // Get from IGraphEdge link.
                        ConnectorBase outlink = curEdge as ConnectorBase;

                        if (outlink != null)
                        {
                             // Set connected link as visible too.
                            Node node1 = outlink.ToNode as Node;
                            if (node1 != null)
                            {
                                // Set current symbol as invisible.
                                node1.Visible = true;
                            }

                            outlink.Visible = true;
                        }
                    }
                }
            }

            // If this symbol is node under mouse click set node state as 
            // expaned by make plus vertical line visibly.
            if (clickednode && HasChild())
            {
                // Set symbol shapes to indicate an expanded state.
                m_bExpanded = true;
            }
        }

        public void CollapseSubNodes(bool clickednode)
        {
            IGraphNode thisNode = this as IGraphNode;
            if (thisNode != null)
            {
                ICollection edgesLeaving = thisNode.EdgesLeaving;
                if (edgesLeaving != null)
                {
                    // Convert to collection of IGraphEdges type.
                    foreach (IGraphEdge curEdge in edgesLeaving)
                    {
                        // Get from IGraphEdge link.
                        ConnectorBase outlink = curEdge as ConnectorBase;
                        if (outlink != null)
                        {
                            // Set connected link as invisible too.

                            Node node1 = outlink.ToNode as Node;
                            if (node1 != null)
                            {
                                // Set current symbol as invisible.
                                node1.Visible = false;
                            }

                            outlink.Visible = false;
                            
                        }
                    }
                }
            }

            // If this symbol is node under mouse click set node state as 
            // expaned by make plus vertical line visibly.
            if (clickednode && HasChild())
            {
                // Set symbol shapes to indicate a collapsed state.
                m_bExpanded = false;
            }

        }
        private bool HasChild()
		{
			return this.EdgesLeaving.Count > 0;
        }
#endregion
    }
#endregion

#region SymbolClassForWoman
    class WomanSymbolClass : Group
    {
        BitmapNode bmpnode = null;

        private bool m_bExpanded = true;

        public WomanSymbolClass()
        {

#if !NETCORE
            bmpnode = new BitmapNode(new Bitmap(@"..\..\..\..\..\..\common\Images\Diagram\Drill Down images\image7_48.png"));
#else
            bmpnode = new BitmapNode(new Bitmap(@"..\..\..\..\..\..\..\common\Images\Diagram\Drill Down images\image7_48.png"));
#endif
            bmpnode.Name = "Grand Mother";
            bmpnode.LineStyle.LineWidth = 0;
            bmpnode.PinPoint = new Point(305, 130);
           
            this.AppendChild(bmpnode);

        }

#region ExpandAndCollapse
        protected override void OnMouseDoubleClick(EventArgs e)
        {
            
            // Get node root.
            Syncfusion.Windows.Forms.Diagram.Model diagramModel = this.Root;           
            // Begin model update.
            diagramModel.BeginUpdate();

            // If node is expanded collapse its, else expand.
            if (m_bExpanded == false)
            {
                this.ExpandSubNodes(true);
            }
            else
            {
                this.CollapseSubNodes(true);
            }

            diagramModel.EndUpdate();

             
        }
        public void ExpandSubNodes(bool clickednode)
        {
            IGraphNode thisNode = this as IGraphNode;

            if (thisNode != null)
            {
                ICollection edgesLeaving = thisNode.EdgesLeaving;
                if (edgesLeaving != null)
                {
                    foreach (IGraphEdge curEdge in edgesLeaving)
                    {
                        // Get from IGraphEdge link.
                        ConnectorBase outlink = curEdge as ConnectorBase;

                        if (outlink != null)
                        {
                            // Set connected link as visible too.
                            Node node1 = outlink.ToNode as Node;
                            if (node1 != null)
                            {
                                // Set current symbol as invisible.
                                node1.Visible = true;
                            }

                            outlink.Visible = true;
                        }
                    }
                }
            }

            // If this symbol is node under mouse click set node state as 
            // expaned by make plus vertical line visibly.
            if (clickednode && HasChild())
            {
                // Set symbol shapes to indicate an expanded state.
                m_bExpanded = true;
            }
        }

        public void CollapseSubNodes(bool clickednode)
        {
            IGraphNode thisNode = this as IGraphNode;
            if (thisNode != null)
            {
                ICollection edgesLeaving = thisNode.EdgesLeaving;
                if (edgesLeaving != null)
                {
                    // Convert to collection of IGraphEdges type.
                    foreach (IGraphEdge curEdge in edgesLeaving)
                    {
                        // Get from IGraphEdge link.
                        ConnectorBase outlink = curEdge as ConnectorBase;
                        if (outlink != null)
                        {
                            // Set connected link as invisible too.

                            Node node1 = outlink.ToNode as Node;
                            if (node1 != null)
                            {
                                // Set current symbol as invisible.
                                node1.Visible = false;
                            }

                            outlink.Visible = false;

                        }
                    }
                }
            }

            // If this symbol is node under mouse click set node state as 
            // expaned by make plus vertical line visibly.
            if (clickednode && HasChild())
            {
                // Set symbol shapes to indicate a collapsed state.
                m_bExpanded = false;
            }

        }
        private bool HasChild()
        {
            return this.EdgesLeaving.Count > 0;
        }
#endregion
    }
#endregion
    
#region SymbolClassForGirlSymbol
    class GirlSymbolClass : Group
    {
        BitmapNode bmpnode = null;

        public Syncfusion.Windows.Forms.Diagram.Model model1;
        public Syncfusion.Windows.Forms.Diagram.Model model2;
        public Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram1;
        ToolTip tooltips = new ToolTip();
        public GirlSymbolClass()
        {
#if !NETCORE
            bmpnode = new BitmapNode(new Bitmap(@"..\..\..\..\..\..\common\Images\Diagram\Drill Down images\image5_48.png"));
#else
            bmpnode = new BitmapNode(new Bitmap(@"..\..\..\..\..\..\..\common\Images\Diagram\Drill Down images\image5_48.png"));
#endif
            bmpnode.Name = "Girl";
            bmpnode.LineStyle.LineWidth = 0;
            bmpnode.PinPoint = new Point(305, 130);
           
            this.AppendChild(bmpnode);
              
        }

        public GirlSymbolClass(String name, Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram, Syncfusion.Windows.Forms.Diagram.Model model1, Syncfusion.Windows.Forms.Diagram.Model model2)
        {
#if !NETCORE
            bmpnode = new BitmapNode(new Bitmap(@"..\..\..\..\..\..\common\Images\Diagram\Drill Down images\image5_48.png"));
#else
            bmpnode = new BitmapNode(new Bitmap(@"..\..\..\..\..\..\..\common\Images\Diagram\Drill Down images\image5_48.png"));
#endif
            bmpnode.Name = name;
            bmpnode.PinPoint = new Point(305, 130);
            bmpnode.LineStyle.LineWidth = 0;
            this.AppendChild(bmpnode);
            this.diagram1 = diagram;

            this.model1 = model1;
            this.model2 = model2;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            Syncfusion.Windows.Forms.Diagram.Model diagramModel = this.Root;
            Node thisNode = this as IGraphNode as Node;

            if (thisNode.Name.ToString() == "Girls")
            {
                tooltips.IsBalloon = true;
                tooltips.SetToolTip(this.diagram1, "Click Here!");
                tooltips.Active = true;
            }
            else
                tooltips.Active = false;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            tooltips.Active = false;

        }

        protected override void OnMouseClick(EventArgs e)
        {
            // Get node root.
            Syncfusion.Windows.Forms.Diagram.Model diagramModel = this.Root;
            Node thisNode = this as IGraphNode as Node;

            if (thisNode.Name.ToString() == "Girls")
            {
                this.diagram1.Controller.SelectAll();
                this.diagram1.Controller.Delete();
                this.model1.Nodes.Clear();

                Syncfusion.Windows.Forms.Diagram.TextNode txtnode1 = new TextNode(" Coevals Diagram ");
                txtnode1.FontStyle.Size = 20;
                txtnode1.FontStyle.Bold = true;
                txtnode1.FontStyle.Family = "Segoe UI";
                txtnode1.LineStyle.LineColor = Color.Transparent;
                txtnode1.SizeToText(new Size(1000, 1000));
                txtnode1.PinPoint = new PointF(335, 25);
                this.diagram1.Model.AppendChild(txtnode1);

                Syncfusion.Windows.Forms.Diagram.TextNode txtnode2 = new TextNode("Friends!");
                txtnode2.FontStyle.Size = 8;
                txtnode2.FontStyle.Family = "Segoe UI";
                txtnode2.LineStyle.LineColor = Color.Transparent;
                txtnode2.PinPoint = new PointF(280, 150);
                txtnode1.SizeToText(new Size(1000, 1000));
                this.diagram1.Model.AppendChild(txtnode2);

                this.diagram1.Model.AppendChild(new HomeNode(this.diagram1, this.model1, this.model2));
                          
                GirlSymbolClass symbol1 = new GirlSymbolClass();
                symbol1.PinPoint = new PointF(280, 120);
                this.diagram1.Model.AppendChild(symbol1);

                GirlSymbolClass symbol2 = new GirlSymbolClass();
                symbol2.PinPoint = new PointF(380, 180);
                this.diagram1.Model.AppendChild(symbol2);

                GirlSymbolClass symbol3 = new GirlSymbolClass();
                symbol3.PinPoint = new PointF(380, 280);
                this.diagram1.Model.AppendChild(symbol3);

                GirlSymbolClass symbol4 = new GirlSymbolClass();
                symbol4.PinPoint = new PointF(280, 320);
                this.diagram1.Model.AppendChild(symbol4);

                GirlSymbolClass symbol5 = new GirlSymbolClass();
                symbol5.PinPoint = new PointF(180, 280);
                this.diagram1.Model.AppendChild(symbol5);

                GirlSymbolClass symbol6 = new GirlSymbolClass();
                symbol6.PinPoint = new PointF(180, 180);
                this.diagram1.Model.AppendChild(symbol6);

                // Grand Mother
                GrandMotherSymbolClass gm = new GrandMotherSymbolClass(this.diagram1, this.model1, this.model2, true);
                gm.PinPoint = new PointF(65, 30);
                gm.Size = new SizeF(20, 20);
                gm.LineStyle.LineColor = Color.Transparent;
                this.diagram1.Model.AppendChild(gm);

                ConnectNodes(symbol1, symbol2);
                ConnectNodes(symbol2, symbol3);
                ConnectNodes(symbol4, symbol3);
                ConnectNodes(symbol4, symbol5);
                ConnectNodes(symbol5, symbol6);
                ConnectNodes(symbol1, symbol6);
                this.diagram1.View.SelectionList.Clear();
                this.Nodes.Clear();
            }
        }
        private void ConnectNodes(Node parentNode, Node subNode)
        {
            if (parentNode.CentralPort == null || subNode.CentralPort == null)
                return;

            this.diagram1.Model.BeginUpdate();

            // Create links
            PointF[] pts = new PointF[] { PointF.Empty, new PointF(0, 1) };
            OrthogonalConnector line = new OrthogonalConnector(pts[0], pts[1]);
            line.HeadDecorator.FillStyle.Color = Color.Black;
            line.LineStyle.LineColor = Color.LightGray;
            this.diagram1.Model.AppendChild(line);

            parentNode.CentralPort.TryConnect(line.TailEndPoint);
            subNode.CentralPort.TryConnect(line.HeadEndPoint);
            this.diagram1.Model.SendToBack(line);
            this.diagram1.Model.EndUpdate();
        }


    }
#endregion

#region SymbolClassForBoys
    class BoySymbolClass : Group
    {
        BitmapNode bmpnode = null;

        public Syncfusion.Windows.Forms.Diagram.Model mod1;
        public Syncfusion.Windows.Forms.Diagram.Model mod2;
        public Syncfusion.Windows.Forms.Diagram.Controls.Diagram dig;

        ToolTip tooltips = new ToolTip();
        public BoySymbolClass()
        {
#if !NETCORE
            bmpnode = new BitmapNode(new Bitmap(@"..\..\..\..\..\..\common\Images\Diagram\Drill Down images\image6_48.png"));
#else
            bmpnode = new BitmapNode(new Bitmap(@"..\..\..\..\..\..\..\common\Images\Diagram\Drill Down images\image6_48.png"));
#endif
            bmpnode.Name = "Boy";
            bmpnode.LineStyle.LineWidth = 0;
            bmpnode.PinPoint = new Point(305, 130);

            this.AppendChild(bmpnode);
        }

        public BoySymbolClass(String name, Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram, Syncfusion.Windows.Forms.Diagram.Model model1, Syncfusion.Windows.Forms.Diagram.Model model2)
        {
#if !NETCORE
            bmpnode = new BitmapNode(new Bitmap(@"..\..\..\..\..\..\common\Images\Diagram\Drill Down images\image6_48.png"));
#else
            bmpnode = new BitmapNode(new Bitmap(@"..\..\..\..\..\..\..\common\Images\Diagram\Drill Down images\image6_48.png"));
#endif
            bmpnode.Name = name;
            bmpnode.PinPoint = new Point(305, 130);
            bmpnode.LineStyle.LineWidth = 0;
                
          

            this.AppendChild(bmpnode);
            this.dig = diagram;

            this.mod1 = model1;
            this.mod2 = model2;
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            
            Syncfusion.Windows.Forms.Diagram.Model diagramModel = this.Root;
            Node thisNode = this as IGraphNode as Node;

            if (thisNode.Name.ToString() == "Boys")
            {
                tooltips.IsBalloon = true;                
                tooltips.SetToolTip(this.dig, "Click Here!");
                tooltips.Active = true;
            }
            else
                tooltips.Active = false;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            tooltips.Active = false;

        }
        protected override void OnMouseClick(EventArgs e)
        {
            // Get node root.
            Syncfusion.Windows.Forms.Diagram.Model diagramModel = this.Root;
            Node thisNode = this as IGraphNode as Node;

            if (thisNode.Name.ToString() == "Boys")
            {
                this.dig.Controller.SelectAll();
                this.dig.Controller.Delete();
                this.mod1.Nodes.Clear();


                Syncfusion.Windows.Forms.Diagram.TextNode txtnode1 = new TextNode(" Coevals Diagram ");
                txtnode1.FontStyle.Size = 20;
                txtnode1.FontStyle.Bold = true;
                txtnode1.FontStyle.Family = "Segoe UI";
                txtnode1.LineStyle.LineColor = Color.Transparent;
                txtnode1.SizeToText(new Size(1000, 1000));
                txtnode1.PinPoint = new PointF(335, 25);
                this.dig.Model.AppendChild(txtnode1);

                Syncfusion.Windows.Forms.Diagram.TextNode txtnode2 = new TextNode("Friends!");
                txtnode2.FontStyle.Size = 8;
                txtnode2.FontStyle.Family = "Segoe UI";
                txtnode2.LineStyle.LineColor = Color.Transparent;
                txtnode2.PinPoint = new PointF(280, 150);
                txtnode1.SizeToText(new Size(1000, 1000));
                this.dig.Model.AppendChild(txtnode2);

                this.dig.Model.AppendChild(new HomeNode(this.dig, this.mod1, this.mod2));

                BoySymbolClass symbol1 = new BoySymbolClass();
                symbol1.PinPoint = new PointF(280, 120);
                this.dig.Model.AppendChild(symbol1);

                BoySymbolClass symbol2 = new BoySymbolClass();
                symbol2.PinPoint = new PointF(380, 180);
                this.dig.Model.AppendChild(symbol2);

                BoySymbolClass symbol3 = new BoySymbolClass();
                symbol3.PinPoint = new PointF(380, 280);
                this.dig.Model.AppendChild(symbol3);

                BoySymbolClass symbol4 = new BoySymbolClass();
                symbol4.PinPoint = new PointF(280, 320);
                this.dig.Model.AppendChild(symbol4);

                BoySymbolClass symbol5 = new BoySymbolClass();
                symbol5.PinPoint = new PointF(180, 280);
                this.dig.Model.AppendChild(symbol5);

                BoySymbolClass symbol6 = new BoySymbolClass();
                symbol6.PinPoint = new PointF(180, 180);
                this.dig.Model.AppendChild(symbol6);

                // Grand Mother
                GrandMotherSymbolClass gm = new GrandMotherSymbolClass(this.dig, this.mod1, this.mod2,true);
                gm.PinPoint = new PointF(65,30);
                gm.Size = new SizeF(20, 20);
                gm.LineStyle.LineColor = Color.Transparent;
                this.dig.Model.AppendChild(gm);

                                               
                ConnectNodes(symbol1, symbol2);
                ConnectNodes(symbol2, symbol3);
                ConnectNodes(symbol4, symbol3);
                ConnectNodes(symbol4, symbol5);
                ConnectNodes(symbol5, symbol6);
                ConnectNodes(symbol1, symbol6);
                this.dig.View.SelectionList.Clear();
                this.Nodes.Clear();

            }
        }
        private void ConnectNodes(Node parentNode, Node subNode)
        {
            if (parentNode.CentralPort == null || subNode.CentralPort == null)
                return;

            this.dig.Model.BeginUpdate();

            // Create links
            PointF[] pts = new PointF[] { PointF.Empty, new PointF(0, 1) };
            OrthogonalConnector line = new OrthogonalConnector(pts[0], pts[1]);
            line.HeadDecorator.FillStyle.Color = Color.LightGray;
            line.LineStyle.LineColor = Color.LightGray;

            this.dig.Model.AppendChild(line);

            parentNode.CentralPort.TryConnect(line.TailEndPoint);
            subNode.CentralPort.TryConnect(line.HeadEndPoint);
            this.dig.Model.SendToBack(line);
            this.dig.Model.EndUpdate();
        }
    }
#endregion
}
