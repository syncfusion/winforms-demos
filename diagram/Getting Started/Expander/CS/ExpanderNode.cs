#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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
using System.Drawing.Drawing2D;
using System.Collections;
using System.Windows.Forms;


    public class ExpanderNode:RoundRect
    {
        #region Members        
        private bool m_bIsExpander;
        private bool m_bExpanded = true;
        private Timer m_timer = null;        
        private int m_iCount = 0;        
        NodeCollection CollapsedCollection = new NodeCollection();
        NodeCollection ExpandedCollection = new NodeCollection();
        #endregion

        #region Initialization             
        public ExpanderNode(RectangleF bounds)
            : base(bounds)
        {                     
            this.CurveRadius = 25;
            this.FillStyle.Color = Color.FromArgb(242,242,242);
            this.FillStyle.ForeColor = Color.White;
            this.FillStyle.Type = FillStyleType.LinearGradient;
            this.FillStyle.GradientCenter = 1;
            this.FillStyle.GradientAngle = 90;
            this.EditStyle.AllowSelect = true;
            this.EditStyle.DefaultHandleEditMode = HandleEditMode.None;
        }        
        #endregion

        #region Properties
        public int Count
        {
            get
            {
                return m_iCount;
            }
            set
            {
                if (value != m_iCount && OnPropertyChanging(this.FullContainerName, "Count", value))
                {
                    m_iCount = value;
                    OnPropertyChanged(this.FullContainerName, "Count");
                }
            }
        }
        
        public bool IsExpanded
        {
            get
            {
                return m_bExpanded;
            }
            set
            {
                if (value != m_bExpanded)
                    m_bExpanded = value;
            }
        }

        public bool IsExpander
        {
            get
            {
                return m_bIsExpander;
            }
            set
            {
                if(value != m_bIsExpander && OnPropertyChanging(this.FullContainerName, "IsExpander",value))
                {
                    m_bIsExpander = value;
                    OnPropertyChanged(this.FullContainerName, "IsExpander");
                }
            }
        }
        #endregion

        #region Overrides        
        protected override void OnMouseClick(EventArgs e)
        {
            base.OnMouseClick(e);
            if (m_bIsExpander)
            {                
                Syncfusion.Windows.Forms.Diagram.Model diagramModel = this.Root;

                diagramModel.BeginUpdate();

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
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.IsExpander = false;
        }

        protected override void Render(Graphics gfx)
        {
            base.Render(gfx);
            DrawExpander(gfx);            
        }       

        public void MouseMove(PointF ptLocation)
        {
            PointF pt = this.ConvertToNodeCoordinates(ptLocation);
            RectangleF rect = new RectangleF(this.Size.Width / 2 - 7.5f, this.Size.Height - 20, 15, 15);
            if (rect.Contains(pt))
            {
                this.IsExpander = true;
            }
            else
                this.IsExpander = false;
        }    
        #endregion

        #region Public methods        
        public NodeCollection ExpandSubNodes(bool clickednode)
        {
            NodeCollection expandCollection = new NodeCollection();
            ExpandedCollection = new NodeCollection();
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
                            // Get from link children of current symbol.
                            ExpanderNode cursymbol = outlink.ToNode as ExpanderNode;
                            if (cursymbol != null)
                            {
                                // Check for explanded and explande nodes in child symbol.
                                if (cursymbol.IsExpanded)
                                    cursymbol.ExpandSubNodes(false);

                                // Set current symbol as visible.
                                cursymbol.Visible = true;
                                expandCollection.Add(cursymbol);
                            }

                            // Set connected link as visible too.
                            outlink.Visible = true;
                            expandCollection.Add(outlink);
                        }
                    }
                }
            }
            ExpandedCollection = expandCollection;
            // If this symbol is node under mouse click set node state as 
            // expaned by make plus vertical line visibly.
            if (clickednode && HasChild())
            {
                // Set symbol shapes to indicate an expanded state.
                m_bExpanded = true;                
            }
            return expandCollection;
        }
        
        public NodeCollection CollapseSubNodes(bool clickednode)
        {
            NodeCollection collapsedCollection = new NodeCollection();
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
                            // Get from link current symbol children.
                            ExpanderNode cursymbol = outlink.ToNode as ExpanderNode;
                            if (cursymbol != null)
                            {
                                // Colapse nodes in child symbol.
                                cursymbol.CollapseSubNodes(false);

                                // Set current symbol as invisible.
                                cursymbol.Visible = false;
                            }
                            // Set connected link as invisible too.
                            outlink.Visible = false;             
                            //CollapsedCollection.Add(outlink);
                        }
                    }
                }
            }
            CollapsedCollection = collapsedCollection;
            // If this symbol is node under mouse click set node state as 
            // expaned by make plus vertical line visibly.
            if (clickednode && HasChild())
            {
                // Set symbol shapes to indicate a collapsed state.
                m_bExpanded = false;
                
            }
            return collapsedCollection;
        }    
        
        #endregion

        #region Helper methods        
                
        private NodeCollection GetSubNodes()
        {
            NodeCollection nodes = new NodeCollection();

            foreach (IGraphEdge edge in this.EdgesLeaving)
            {
                Node toNode = edge.ToNode as Node;

                if (toNode != null)
                {
                    nodes.Add(toNode);
                }
            }

            return nodes;
        }

        private bool HasChild()
        {
            return this.EdgesLeaving.Count > 0;
        }

        private void DrawExpander(Graphics gfx)
        {
            if (HasChild())
            {
                GraphicsState state = gfx.Save();
                FillStyle fillStyle = new FillStyle();
                fillStyle.Color = Color.FromArgb(242, 242, 242);
                fillStyle.ForeColor = Color.FromArgb(247, 247, 247);
                fillStyle.Type = FillStyleType.LinearGradient;
                using (Brush brush = fillStyle.CreateBrush(gfx, new RectangleF(this.Size.Width / 2 - 7.5f, this.Size.Height - 20, 15, 15)))
                {
                    gfx.FillEllipse(brush, new RectangleF(this.Size.Width / 2 - 7.5f, this.Size.Height - 20, 15, 15));
                    gfx.DrawEllipse(Pens.Gray, new RectangleF(this.Size.Width / 2 - 7.5f, this.Size.Height - 20, 15, 15));
                }
                Pen pen;
                if (m_bIsExpander)
                {
                    pen = new Pen(Brushes.Black, 1.6f);
                    gfx.DrawEllipse(pen, this.Size.Width / 2 - 7.5f, this.Size.Height - 20, 15, 15);
                }                
                pen = new Pen(Color.DarkRed, 2);
                if (!m_bExpanded)
                {
                    pen.Color = Color.Green;
                    gfx.DrawLine(pen, new PointF(this.Size.Width / 2, this.Size.Height - 15), new PointF(this.Size.Width / 2, this.Size.Height - 9));
                }
                gfx.DrawLine(pen, new PointF(this.Size.Width / 2 - 3, this.Size.Height - 12f), new PointF(this.Size.Width / 2 - 3 + 6, this.Size.Height - 12f));                
                gfx.Restore(state);
            }
        }
        #endregion
    }

