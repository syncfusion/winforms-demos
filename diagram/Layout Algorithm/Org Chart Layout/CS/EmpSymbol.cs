using System;
using System.Collections.Generic;
using System.Web;
using Syncfusion.Windows.Forms.Diagram;
using System.Drawing;
using System.Collections;
using System.Runtime.Serialization;
using System.Drawing.Drawing2D;

/// <summary>
/// Summary description for EmpSymbol
/// </summary>
[Serializable]
[System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Assert, Name = "FullTrust")]
public class EmpSymbol :Group
{
    #region Class members

    /// <summary>
    /// Flag indicated for explanded node state.
    /// </summary>
    private bool m_bExpanded = true;
    private bool m_bIsExpander;
    private int m_iCount = 0;    
    /// <summary>
    /// Create new instance of TextNode
    /// </summary>
    private TextNode txtNode = new TextNode("");
    /// <summary>
    /// Create a enum for BackgroundShape .
    /// </summary>
    public enum BackgroundShape { ellipse, Rectangle }
    /// <summary>
    /// Create a enum for SymbolShape
    /// </summary>
    public enum SymbolShape { PlusMinus, RightDownTriangle }

    private BackgroundShape m_backGrndShp;
    private SymbolShape m_symbolShape;

    NodeCollection CollapsedCollection = new NodeCollection();
    NodeCollection ExpandedCollection = new NodeCollection();
    
    #endregion

    #region Class Initialize methods
    /// <summary>
    /// Initialize a new instance of the class.
    /// </summary>
    /// <param name="fileName"></param>
    public EmpSymbol(string fileName)
    {
        Syncfusion.Windows.Forms.Diagram.Rectangle groupRect = new Syncfusion.Windows.Forms.Diagram.Rectangle(0, 0, 255, 75);
        groupRect.Name = "Rectangle";
        groupRect.FillStyle.Type = FillStyleType.LinearGradient;
        groupRect.FillStyle.ForeColor = Color.White;      
        groupRect.FillStyle.Color = System.Drawing.Color.FromArgb(240, 242, 240);    
        groupRect.LineStyle.LineColor = Color.Black;
        groupRect.LineStyle.LineWidth = 1;
        groupRect.EditStyle.AllowSelect = false;    
        this.AppendChild(groupRect);

        System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(fileName);
        System.Drawing.Image Image = bitmap.GetThumbnailImage(60, 50, null, IntPtr.Zero);
        bitmap = new System.Drawing.Bitmap(Image);

        BitmapNode bitmapNode = new BitmapNode(bitmap);
        bitmapNode.PinPoint = new PointF(bitmapNode.PinPoint.X + 10, bitmapNode.PinPoint.Y+10);
        bitmapNode.LineStyle.LineColor = Color.Transparent;
        bitmapNode.EditStyle.AllowSelect = false;
        this.AppendChild(bitmapNode);       
        
        txtNode.PinPoint = new PointF(bitmapNode.PinPoint.X + 40, bitmapNode.PinPoint.Y-30);
        txtNode.LineStyle.LineColor = Color.Transparent;
        txtNode.FontStyle.Size = 9;
        txtNode.FontStyle.Family = "Arial";
        
        txtNode.SizeToText(new SizeF(130, 100));       
        this.AppendChild(txtNode);
        BackgroundShapeType = BackgroundShape.ellipse;
        SymbolShapeType = SymbolShape.RightDownTriangle;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ExpanderSymbol"/> class.
    /// </summary>
    /// <param name="src">The source node.</param>
    public EmpSymbol(EmpSymbol src)
        : base(src)
    {
        m_bExpanded = src.m_bExpanded;
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="Group"/> class.
    /// </summary>
    /// <param name="info">The serialization Info.</param>
    /// <param name="context">The streaming context.</param>
    /// <summary>
    /// Serialization constructor for symbols.
    /// </summary>
    /// <param name="info">Serialization state information</param>
    /// <param name="context">Streaming context information</param>
    public EmpSymbol(System.Runtime.Serialization.SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
        m_bExpanded = info.GetBoolean("isExpanded");
    }

    protected override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        base.GetObjectData(info, context);
    }
    #endregion

    #region Class properties
    
    /// <summary>
    /// Get EmployeeName of current node.
    /// </summary>
    public string EmployeeName
    {
        get
        {
            return this.txtNode.Text;
        }
        set
        {
            this.txtNode.Text = value;
        }
    }

    /// <summary>
    /// Get BackgroundShape of current node
    /// </summary>
    public BackgroundShape BackgroundShapeType { get { return m_backGrndShp; } set { m_backGrndShp = value; } }

    /// <summary>
    /// Get symbolshape of current node
    /// </summary>
    public SymbolShape SymbolShapeType { get { return m_symbolShape; } set { m_symbolShape = value; } }
    
    /// <summary>
    /// Get nodeCollection of current node
    /// </summary>
    public NodeCollection SubNodes
    {
        get { return GetSubNodes(); }
    }

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
            if (value != m_bIsExpander && OnPropertyChanging(this.FullContainerName, "IsExpander", value))
            {
                m_bIsExpander = value;
                OnPropertyChanged(this.FullContainerName, "IsExpander");
            }
        }
    }
    #endregion    

    #region Class overrides
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
    public void MouseMove(PointF ptLocation)
    {
        PointF pt = this.ConvertToNodeCoordinates(ptLocation);
        RectangleF rect = new RectangleF(3, 3, 18, 18);
        if (rect.Contains(pt))
        {
            this.IsExpander = true;
        }
        else
            this.IsExpander = false;
    }   
    /// <summary>
    /// Clones this instance.
    /// </summary>
    /// <returns></returns>
    public override object Clone()
    {
        return new EmpSymbol(this);
    }
    /// <summary>
    /// Renders the specified graphics.
    /// </summary>
    /// <param name="gfx">Graphics to draw on.</param>
    protected override void Render(Graphics gfx)
    {
        base.Render(gfx);

        // draw helper plus/minus symbol
        DrawPlusMinus(gfx);
    }
    #endregion

    #region Class Public Methods
    /// <summary>
    /// Create new method for expand current node
    /// </summary>
    /// <param name="SelectedNode"></param>
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
                        EmpSymbol cursymbol = outlink.ToNode as EmpSymbol;
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

    /// <summary>
    /// Create a new method for collapse current node
    /// </summary>
    /// <param name="SelectedNode"></param>


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
                        EmpSymbol cursymbol = outlink.ToNode as EmpSymbol;
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

    #region Class helper methods
    /// <summary>
    /// Create a new method for whether current node has children or not.
    /// </summary>
    /// <returns></returns>
    private bool HasChild()
    {
        return this.EdgesLeaving.Count > 0;
    }
    /// <summary>
    /// Create a new method for Drawing in current node.
    /// </summary>
    /// <param name="gfx"></param>
    public void DrawPlusMinus(Graphics gfx)
    {
        if (HasChild())
        {
            int length = 12;
            SizeF szOffset = new SizeF(length, length);

            // horizontal
            PointF[] ptsHorizontal = new PointF[]
					{
						new PointF( szOffset.Width -length/2, szOffset.Height ),
						new PointF( szOffset.Width + length/2, szOffset.Height )
					};

            // vertical
            PointF[] ptsVertical = new PointF[]
					{
						new PointF( szOffset.Width, szOffset.Height-length/2 ),
						new PointF( szOffset.Width, szOffset.Height + length/2 )
					};

            using (Pen penHightlight = new Pen(Color.Gray, 1))
            using (Pen pen = new Pen(Color.Black, 1))
            {
                if (!m_bExpanded)
                {
                    if (SymbolShapeType == SymbolShape.PlusMinus)
                    {
                        gfx.DrawLine(pen, ptsVertical[0], ptsVertical[1]);
                        gfx.DrawLine(penHightlight, ptsVertical[0], ptsVertical[1]);
                    }
                    else if (SymbolShapeType == SymbolShape.RightDownTriangle)
                    {
                       // PointF[] pts = { new PointF(8, 12), new Point(16, 8), new PointF(16, 16) };
                        PointF[] pts = { new PointF(8, 8), new Point(8, 16), new PointF(12, 14), new PointF(16, 12) };
                        
                        gfx.DrawPolygon(pen, pts);
                        gfx.FillPolygon(Brushes.LightGray, pts, FillMode.Winding);
                    }
                }
                else
                {
                    if (SymbolShapeType == SymbolShape.RightDownTriangle)
                    {
                        PointF[] pts = {new PointF (8,8),new PointF(16,8),new PointF(12,16)  };
                        gfx.DrawPolygon(pen, pts);
                        gfx.FillPolygon(Brushes.LightGray, pts, FillMode.Winding);
                    }
                }
                if (SymbolShapeType == SymbolShape.PlusMinus)
                {
                    gfx.DrawLine(pen, ptsHorizontal[0], ptsHorizontal[1]);
                    gfx.DrawLine(penHightlight, ptsHorizontal[0], ptsHorizontal[1]);
                }
                if (BackgroundShapeType == BackgroundShape.ellipse)
                    gfx.DrawEllipse(pen, 3, 3, 18, 18);
                else if (BackgroundShapeType == BackgroundShape.Rectangle)
                    gfx.DrawRectangle(pen, 3, 3, 18, 18);
            }
        }
    }
    /// <summary>
    /// Create a new method to get NodeCollection of current node.
    /// </summary>
    /// <returns></returns>
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

    #endregion
}
