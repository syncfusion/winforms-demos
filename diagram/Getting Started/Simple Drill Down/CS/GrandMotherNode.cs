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
using System.Windows.Forms;


namespace SimpleDrillDown
{

    #region SymbolForGrandMother
    class GrandMotherSymbolClass : Group 
    {
        public Syncfusion.Windows.Forms.Diagram.Model mod1;
        public Syncfusion.Windows.Forms.Diagram.Model mod2;
        public Syncfusion.Windows.Forms.Diagram.Controls.Diagram dig;
        WomanSymbolClass mysymbolA = new WomanSymbolClass();
        WomanSymbolClass mysymbolB = new WomanSymbolClass();
        ManSymbolClass mysymbolB1 = new ManSymbolClass();
        BitmapNode bmpnode=null;
        ToolTip tooltips = new ToolTip();


        GrandMotherSymbolClass GM;
        WomanSymbolClass GMDaughter = new WomanSymbolClass();
        ManSymbolClass GMSon = new ManSymbolClass();
        GirlSymbolClass mySymbolGirl;
        BoySymbolClass mySymbolBoy;
        private bool m_bExpanded = true;

        public GrandMotherSymbolClass(Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram, Syncfusion.Windows.Forms.Diagram.Model model1, Syncfusion.Windows.Forms.Diagram.Model model2)
        {
#if !NETCORE
            bmpnode = new BitmapNode(new Bitmap(@"..\..\..\..\..\..\common\Images\Diagram\Drill Down images\image2_48.png"));
#else
            bmpnode = new BitmapNode(new Bitmap(@"..\..\..\..\..\..\..\common\Images\Diagram\Drill Down images\image2_48.png"));
#endif
            bmpnode.Name = "Grand Mother";
            bmpnode.PinPoint = new Point(300, 180);
            bmpnode.LineStyle.LineWidth = 0;
            this.AppendChild(bmpnode);	

            this.dig = diagram;

            this.mod1 = model1;
            this.mod2 = model2;
        }
        public GrandMotherSymbolClass(Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram, Syncfusion.Windows.Forms.Diagram.Model model1, Syncfusion.Windows.Forms.Diagram.Model model2, bool Previous)
        {

#if !NETCORE
            bmpnode = new BitmapNode(new Bitmap(@"..\..\..\..\..\..\common\Images\Diagram\Drill Down images\prev.png"));
#else
            bmpnode = new BitmapNode(new Bitmap(@"..\..\..\..\..\..\..\common\Images\Diagram\Drill Down images\prev.png"));
#endif
            bmpnode.Name = "Back";
            bmpnode.LineStyle.LineWidth = 0;
            bmpnode.PinPoint = new Point(300, 180);
            this.AppendChild(bmpnode);

            this.dig = diagram;

            this.mod1 = model1;
            this.mod2 = model2;
        }
        public GrandMotherSymbolClass()
        {
#if !NETCORE
            bmpnode = new BitmapNode(new Bitmap(@"..\..\..\..\..\..\common\Images\Diagram\Drill Down images\image2_48.png"));
#else
            bmpnode = new BitmapNode(new Bitmap(@"..\..\..\..\..\..\..\common\Images\Diagram\Drill Down images\image2_48.png"));
#endif
            bmpnode.Name = "Grand Mother";
            bmpnode.LineStyle.LineWidth = 0; 
            this.AppendChild(bmpnode);
        }

#region ExpandAndCollapse

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            if (this.bmpnode != null && this.bmpnode.Name == "Back")
            {
                tooltips.IsBalloon = true;
                tooltips.SetToolTip(this.dig, "Back");
                tooltips.Active = true;
            }
            else
            {
                tooltips.Active = false;
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            tooltips.Active = false;
        }

        //protected override 
        protected override void OnMouseDoubleClick(EventArgs e)
        {
            // Get node root.
            Syncfusion.Windows.Forms.Diagram.Model diagramModel = this.Root;
            if (diagramModel != null)
            {
                // Begin model update.
                diagramModel.BeginUpdate();

                // If node is expanded collapse its, else expand.
                if (m_bExpanded == false)
                {
                    this.ExpandSubNodes(true);
                }
                else
                {
                    this.CollapseSubNodes(this as IGraphNode);
                }

                diagramModel.EndUpdate();
            }

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

        public void CollapseSubNodes(IGraphNode thisNode)
        {           
            //IGraphNode thisNode = this as IGraphNode;
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
                            CollapseSubNodes(node1 as IGraphNode);

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
            if ( HasChild())
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

#region DrillDown
        // DrillDown is implemented by just changing the diagram models
        protected override void OnMouseClick(EventArgs e)
        {
            try
            {
                int flag = 0;
                // Get node root.
                Syncfusion.Windows.Forms.Diagram.Model diagramModel = this.Root;
                Node node = this as IGraphNode as Node;
                
                    if (node is TextNode)
                        //|| node is MyGroup2 || node is MyGroup3)
                        node.EditStyle.AllowSelect = false;
                    else
                    {
                        if (flag == 0)
                        {
                            this.dig.Controller.SelectAll();
                            this.dig.Controller.Delete();
                            this.mod1.Nodes.Clear();
                            flag = 1;
                        }

                        Syncfusion.Windows.Forms.Diagram.TextNode txtnode1 = new TextNode(" Coevals Diagram ");
                        txtnode1.FontStyle.Size = 16;
                        txtnode1.FontStyle.Family = "Arial";
                        txtnode1.FontStyle.Bold = true;

                        txtnode1.FontColorStyle.Color = Color.MidnightBlue;
                        txtnode1.LineStyle.LineColor = Color.Transparent;
                        txtnode1.SizeToText(new Size(1000, 1000));
                        txtnode1.PinPoint = new PointF(335, 25);
                        this.dig.Model.AppendChild(txtnode1);

                        this.dig.Model.AppendChild(new HomeNode(this.dig, this.mod1, this.mod2));
                      
                        // Grand Mother
                        GM = new GrandMotherSymbolClass();
                        GM.dig = this.dig;
                        GM.mod1 = this.mod1;
                        GM.mod2 = this.mod2;
                    GM.PinPoint = new PointF(305, 145);

                        this.dig.Model.AppendChild(GM);

                        // GrandMothers Daiughter
                        GMDaughter.PinPoint = new PointF(150, 200);
                        this.dig.Model.AppendChild(GMDaughter);

                        // Connection b/w Grandma and her daughter
                        ConnectNodes(GM, GMDaughter);

                        // GrandMothers Son
                        GMSon = new ManSymbolClass();
                        GMSon.PinPoint = new PointF(450, 200);
                        this.dig.Model.AppendChild(GMSon);

                        // Connection b/w Grandma and her Son
                        ConnectNodes(GM, GMSon);



                        // Boy
                        BoySymbolClass mySymbolBoy3 = new BoySymbolClass("Boys", this.dig, this.mod1, this.mod2);
                        mySymbolBoy3.Name = "Boys";
                        mySymbolBoy3.PinPoint = new PointF(450, 290);

                        //ToolTip
                        this.dig.Model.AppendChild(mySymbolBoy3);


                        //mySymbolBoy3 = new MySymbol4Girl();                      

                        // Connection b/w Father and his girl
                        ConnectNodes(GMSon, mySymbolBoy3);

                        // Girl
                        mySymbolGirl = new GirlSymbolClass();
                        mySymbolGirl.PinPoint = new PointF(370, 290);
                        this.dig.Model.AppendChild(mySymbolGirl);

                        // Connection b/w Father and his girl
                        ConnectNodes(GMSon, mySymbolGirl);

                        // Girl
                        mySymbolGirl = new GirlSymbolClass();
                        mySymbolGirl.PinPoint = new PointF(520, 290);
                        this.dig.Model.AppendChild(mySymbolGirl);

                        // Connection b/w Father and his girl
                        ConnectNodes(GMSon, mySymbolGirl);

                        // Mother Childerns
                        // Girl
                        mySymbolGirl = new GirlSymbolClass();
                        mySymbolGirl.PinPoint = new PointF(150, 290);
                        this.dig.Model.AppendChild(mySymbolGirl);

                        // Connection b/w Father and his girl
                        ConnectNodes(GMDaughter, mySymbolGirl);

                        // Girl
                        GirlSymbolClass mySymbolGirl3 = new GirlSymbolClass("Girls", this.dig, this.mod1, this.mod2);
                        mySymbolGirl3.Name = "Girls";
                        mySymbolGirl3.PinPoint = new PointF(220, 290);
                        this.dig.Model.AppendChild(mySymbolGirl3);

                        // Connection b/w Mother and his girl
                        ConnectNodes(GMDaughter, mySymbolGirl3);

                        // Boy
                        mySymbolBoy = new BoySymbolClass();
                        mySymbolBoy.PinPoint = new PointF(280, 290);
                        this.dig.Model.AppendChild(mySymbolBoy);
                        // Connection b/w Mother and his girl
                        ConnectNodes(GMDaughter, mySymbolBoy);

                        // Boy
                        mySymbolBoy = new BoySymbolClass();
                        mySymbolBoy.PinPoint = new PointF(90, 290);
                        this.dig.Model.AppendChild(mySymbolBoy);

                        // Connection b/w Mother and his Boy
                        ConnectNodes(GMDaughter, mySymbolBoy);

                        
                        this.Nodes.Clear();
                        this.dig.View.SelectionList.Clear();

                    }
             
            }
            catch { }
        }



        private  void ConnectNodes(Node parentNode, Node subNode)
        {
            if (parentNode.CentralPort == null || subNode.CentralPort == null)
                return;

            this.dig.Model.BeginUpdate();

            // Create links
            PointF[] pts = new PointF[] { PointF.Empty, new PointF(0, 1) };
            OrthogonalConnector  line = new OrthogonalConnector (pts[0], pts[1]);
            line.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
            line.HeadDecorator.Size = new SizeF(7, 7);
            line.HeadDecorator.LineStyle.LineColor = Color.LightGray;
            line.HeadDecorator.FillStyle.Color = Color.LightGray;
            line.LineStyle.LineColor = Color.LightGray;
            this.dig.Model.AppendChild(line);
            parentNode.CentralPort.TryConnect(line.TailEndPoint);
            subNode.CentralPort.TryConnect(line.HeadEndPoint);
            this.dig.Model.SendToBack(line);
            this.dig.Model.EndUpdate();
        }
#endregion

       

    }
#endregion
}
