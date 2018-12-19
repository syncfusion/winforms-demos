#region Copyright Syncfusion Inc. 2001 - 2012
// Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using Syncfusion.Windows.Forms.Diagram.Controls;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace Syncfusion.Windows.Forms.Diagram.DataBinding
{
    /// <summary>
    /// Diagram Engine defines a set of methods and collections that helps bind an IList implemented collection data directly to the Diagram control. 
    /// </summary>
    /// <example> The example shown below contains a "Test' class that defines the Attributes used to bind with the Diagram control.
    /// <code lang="C#">
    /// [NodeType( NodeRectangleF = new float[] { 100, 100, 100, 100 }, NodeType = typeof( Rectangle ) )]
    /// public class Test
    /// {
    ///     public Test( string empName, int id, int managerid ) {
    ///         this.id = id;
    ///         this.empName = empName;
    ///         this.managerId = managerid;
    ///     }
    ///     private string empName;
    ///     [NodeAttribute( VisibilityType = VisibleType.Label )]
    ///     public string EmployeeName {
    ///         get {
    ///             return empName;
    ///         }
    ///         set {
    ///             empName = value;
    ///         }
    ///     }
    ///     private int id;
    ///     public int Id {
    ///         get { return id; }
    ///         set { id = value; }
    ///     }
    ///     private int managerId;
    ///     public int ManagerId {
    ///         get { return managerId; }
    ///         set { managerId = value; }
    ///     }
    /// }
    ///
    /// DiagramDataBindingManager dEngine = new DiagramDataBindingManager( this.diagram1 );
    /// //List of data objects
    /// IList list = new ArrayList( ); //It can any IList implemented List instance
    /// list.Add( new Test( "Mark", 1, 0 ) );
    /// list.Add( new Test( "Spencer", 2, 1 ) );
    /// list.Add( new Test( "Carlos", 3, 1 ) );
    /// list.Add( new Test( "Elliot", 4, 2 ) );
    /// list.Add( new Test( "Benson", 5, 3 ) );
    /// list.Add( new Test( "Margret", 6, 3 ) );
    /// list.Add( new Test( "Rachel", 7, 2 ) );
    /// list.Add( new Test( "Samuel", 8, 1 ) );
    /// //Adding the list collection to SourceListSet
    /// dEngine.SourceListSetKeys.Add( new SourceListSet( "Test", list ) );
    /// </code>
    /// </example>
    public class DiagramDataBindingManager : IDiagramEngine, INodeRelationDescriptor
    {
        private Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram;
        private NodeReflectionStrategy nodeReflectionStrategy;


        /// <summary>
        /// Initializes a new instance of the <see cref="DiagramDataBindingManager"/>
        /// </summary>
        /// <param name="diagram">The diagram.</param>
        public DiagramDataBindingManager(Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram)
        {
            _sourceListSetColl = new SourceListSetCollection(this);
            nodeReflectionStrategy = new NodeReflectionStrategy();
            //Initialize NodeRelationCollection and hook it to listen any new node relations added to the Diagram.
            nodeRelationCollection = new NodeRelationCollection(this);
            nodeRelationCollection.NodeRelationCollectionChanged += new NodeRelationCollectionChangedEventHandler(nodeRelationCollection_NodeRelationCollectionChanged);
            HookUpDiagram(diagram);
        }

        void nodeRelationCollection_NodeRelationCollectionChanged(object sender, NodeRelationEventArgs args)
        {
            if (args.CollectionChangedType == CollectionChangedType.Added)
            {
                this.BeginUpdate();
                ResolveNodeRelations(args.Relation.RelationName);
                this.EndUpdate();
            }
        }

        /// <summary>
        /// Releases unmanaged resources and performs other cleanup operations before the
        /// <see cref="DiagramDataBindingManager"/> is reclaimed by garbage collection.
        /// </summary>
        ~DiagramDataBindingManager()
        {
            nodeReflectionStrategy.TearDown();
            _sourceListSetColl.Clear();
            TearDown();
        }

        #region IDiagramEngine Members
        /// <summary>
        /// Implement this event handler to customize the node before it is added to the Diagram Model.
        /// </summary>
        public event NodeAddedEventHandler NodeAdded;

        internal void RaiseNodeAddedEvent(NodeAddedEventArgs args)
        {
            if (NodeAdded != null)
                NodeAdded(this, args);
        }

        /// <summary>
        /// used for checking across different class instances if the DiagramDataBindingManager is listening to the QueryNodeStyleInfo event.
        /// </summary>
        internal bool IsNodeAddedEventListening
        {
            get
            {
                return NodeAdded == null ? false : true;
            }
        }

        /// <summary>
        /// Raised to customize the Node connectors. Use this event to customize the settings of the connectors that will link the nodes based on the relationships.
        /// </summary>
        /// 
        /// 
        public event NodeConnectEventHandler ProvideNodeConnectorInfo;

        internal bool isNodeConnectStyleListening
        {
            get
            {
                return ProvideNodeConnectorInfo == null ? false : true;
            }
        }

        internal ConnectorBase RaiseNodeConnectStyleInfo(NodeConnectEventArgs args)
        {
            return ProvideNodeConnectorInfo(args);
        }

        /// <summary>
        /// Gets the Diagram model.
        /// </summary>
        /// <value>The Diagram.</value>
        public Syncfusion.Windows.Forms.Diagram.Controls.Diagram Diagram
        {
            get { return diagram; }
        }


        /// <summary>
        /// Returns the LayoutManager associated with the DiagramDataBindingManager.
        /// </summary>
        /// <value></value>
        public Syncfusion.Windows.Forms.Diagram.LayoutManager LayoutManagerDescriptor
        {
            get
            {
                return this.diagram.LayoutManager != null ? this.diagram.LayoutManager : null;
            }
        }

        /// <summary>
        /// Updates / Refreshes the LayoutManager.
        /// </summary>
        public void RefreshLayoutManager()
        {
            if (this.LayoutManagerDescriptor != null && _canUpdateAlways)
            {
                foreach (Node node in this.Diagram.Model.Nodes)
                {
                    if (!this.LayoutManagerDescriptor.Nodes.Contains(node))
                        this.LayoutManagerDescriptor.Nodes.Add(node);
                }
                this.LayoutManagerDescriptor.UpdateLayout(null);
            }
        }

        private SourceListSetCollection _sourceListSetColl;
        /// <summary>
        /// Gets or sets the source list set keys.
        /// </summary>
        /// <value>The source list set keys.</value>
        public SourceListSetCollection SourceListSet
        {
            get
            {
                return _sourceListSetColl;
            }
        }


        /// <summary>
        /// Gets the NodeReflectionStrategy instance. Use this to dynamically load the NodeType attribute marked classes into the DiagramDataBindingManager.
        /// </summary>
        /// <value></value>
        public NodeReflectionStrategy ReflectionStrategy
        {
            get { return nodeReflectionStrategy; }
        }


        /// <summary>
        /// Hooks the diagram with the DiagramDataBindingManager.
        /// </summary>
        /// <param name="diagram">The diagram.</param>
        protected virtual void HookUpDiagram(Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram)
        {
            this.diagram = diagram;
            nodeReflectionStrategy.BuildUp(System.Reflection.Assembly.GetEntryAssembly());
        }

        bool _canUpdateAlways = true;
        /// <summary>
        /// Sets the parameters for holding all the updates.
        /// </summary>
        public void BeginUpdate()
        {
            _canUpdateAlways = false;
        }

        /// <summary>
        /// Resets the parameters and refreshes the updates from the DiagramDataBindingManager to the Diagram control.
        /// </summary>
        public void EndUpdate()
        {
            _canUpdateAlways = true;
            RefreshLayoutManager();
        }


        #endregion

        #region INodeRelationDescriptor Members

        private NodeRelationCollection nodeRelationCollection;
        /// <summary>
        /// Gets or sets the node relation keys.
        /// </summary>
        /// <value>The node relation keys.</value>
        public NodeRelationCollection Relations
        {
            get
            {
                return nodeRelationCollection;
            }
            set
            {
                nodeRelationCollection = value;
            }
        }

        #region NodeConnection change events

        private bool _listenToRelationChanges;
        /// <summary>
        /// Gets or sets a value indicating whether the Engine should listen to changes done on the Node's relation change
        /// </summary>
        /// <value>
        /// 	<c>true</c> if [listen to relation changes]; otherwise, <c>false</c>.
        /// </value>
        public bool ListenToRelationChanges
        {
            get
            {
                return _listenToRelationChanges;
            }
            set
            {
                if (value)
                    WireDiagramConnectionsEvent();
                else
                    UnWireDiagramConnectionsEvent();

                _listenToRelationChanges = value;
            }
        }

        private void WireDiagramConnectionsEvent()
        {
            ((DocumentEventSink)this.Diagram.Model.EventSink).ConnectionsChanged += new CollectionExEventHandler(NodeRelationDescriptor_ConnectionsChanged);
        }

        private void UnWireDiagramConnectionsEvent()
        {
            ((DocumentEventSink)this.Diagram.Model.EventSink).ConnectionsChanged -= new CollectionExEventHandler(NodeRelationDescriptor_ConnectionsChanged);
        }

        bool isConnectionRemoved = false;//this flag checks if the connection is removed first and then inserted. Only in this sequence we can raise the NodeConnectionsChanged event properly
        void NodeRelationDescriptor_ConnectionsChanged(CollectionExEventArgs evtArgs)
        {
            if (evtArgs.Element != null)
            {
                ConnectorBase connector = ((EndPoint)evtArgs.Element).Container as ConnectorBase;

                if (evtArgs.ChangeType == CollectionExChangeType.Remove)
                {
                    isConnectionRemoved = true;
                    /*bool cancel = RaiseNodeConnectChangingEventHandler( new NodeConnectChangingEventArgs( connector.FromNode, connector.ToNode, evtArgs.ChangeType ) );

                    if ( cancel )
                    {
                        evtArgs.Cancel = cancel;
                    }*/
                    //else
                    //{
                    //}
                }
                else if (evtArgs.ChangeType == CollectionExChangeType.Insert && isConnectionRemoved)
                {
                    //Raise the node connected event handler after the connection gets inserted.
                    RaiseNodeConnectChangedEventHandler(new NodeConnectChangedEventArgs(connector.FromNode, connector.ToNode, evtArgs.ChangeType));
                }
            }
        }

        /// <summary>
        /// Event raised when a node connection is changed from a childnode to some other child node.
        /// </summary>
        public event NodeConnectChangedEventHandler NodeConnectChanged;


        /*private bool RaiseNodeConnectChangingEventHandler( NodeConnectChangingEventArgs args ) {
            if ( NodeConnectChanging != null )
            {
                NodeConnectChanging( args );
            }
            return args.Cancel;
        }*/

        private void RaiseNodeConnectChangedEventHandler(NodeConnectChangedEventArgs args)
        {
            if (NodeConnectChanged != null)
            {
                NodeConnectChanged(args);
            }
        }

        #endregion

        /// <summary>
        /// Clears up memory used.
        /// </summary>
        public void TearDown()
        {
            nodeRelationCollection.Clear();
        }

        #region Resolve Node relations

        /// <summary>
        /// Connects the parent node and child node based on the node relation. Iterates all the nodes present in the NodeRelation and connects it.
        /// </summary>
        internal void ResolveNodeRelations(string relationName)
        {
            NodeRelationDescriptor nodeRelation = this.nodeRelationCollection[relationName];
            if (nodeRelation != null)
            {
                //Ensure that the IList is present with the ChildSourceName
                if (this.SourceListSet[nodeRelation.ChildSourceName] != null)
                {
                    Diagram.BeginUpdate();

                    //Iterate thru the ChildSourceList and process the connections
                    foreach (object item in NodeReflectionStrategy.IterateListSource(this.SourceListSet[nodeRelation.ChildSourceName]))
                        AddConnection(nodeRelation, item);

                    Diagram.EndUpdate();
                }
                else
                    throw new ArgumentException("object passed is not an instance of " + this.SourceListSet[nodeRelation.ChildSourceName].SourceName);
            }
        }

        /// <summary>
        /// Processes the connection.
        /// </summary>
        /// <param name="nodeRelation">The node relation.</param>
        /// <param name="listItem">The item present in the IList provided as source.</param>
        internal void AddConnection(NodeRelationDescriptor nodeRelation, object listItem)
        {
            if (CheckItemInCollection(this.SourceListSet[nodeRelation.ChildSourceName], listItem))
            {
                if (nodeRelation.RelationType == RelationType.ParentChild)
                {
                    SourceListSetEntry childSourceList = this.SourceListSet[nodeRelation.ChildSourceName];
                    SourceListSetEntry parentSourceList = this.SourceListSet[nodeRelation.ParentSourceName];
                    ProcessConnection(nodeRelation, childSourceList, parentSourceList, listItem);
                }
                else if (nodeRelation.RelationType == RelationType.SelfRelation)
                {
                    //if the RelationType is a SelfRelation one, it will take the SourceListSet based on the ChildSourceName of the NodeRelation.
                    SourceListSetEntry sourceList = this.SourceListSet[nodeRelation.ChildSourceName];
                    ProcessConnection(nodeRelation, sourceList, sourceList, listItem);
                }
            }
            else
                throw new ArgumentException("object passed is not an instance of " + this.SourceListSet[nodeRelation.ChildSourceName].SourceName);
        }

        private void ProcessConnection(NodeRelationDescriptor nodeRelation, SourceListSetEntry childSourceList, SourceListSetEntry parentSourceList, object item)
        {
            ConnectorBase connector = null;
            Node parentNode = GetParentNodeFromSourceListSet(parentSourceList, item, nodeRelation.ChildID, nodeRelation.ParentID);
            Node childNode = GetChildNodeFromSourceListSet(childSourceList, item);

            if (parentNode != null && childNode != null && !CheckParentAndChildNodeAlreadyConnected(parentNode, childNode))
            {
                if (!isNodeConnectStyleListening)
                {
                    //Connect nodes
                    connector = ConnectNodes(parentNode, childNode);
                }
                else
                {
                    //Raise the event to customize the connectors
                    connector = RaiseQueryNodeConnectorStyleInfoHandler(nodeRelation, parentNode, childNode);
                }
            }
            //Append the Connector to the DiagramModel.
            if (connector != null)
            {
                Diagram.Model.AppendChild(connector);
                Diagram.Model.SendToBack(connector);
                nodeRelation.nodeConnections.Add(connector);
            }
        }

        /// <summary>
        /// Gets the parent node from source list set.
        /// </summary>
        /// <param name="itemList">The item list.</param>
        /// <param name="item">The item.</param>
        /// <param name="childId">The child id.</param>
        /// <param name="parentId">The parent id.</param>
        /// <returns></returns>
        private Node GetParentNodeFromSourceListSet(SourceListSetEntry itemList, object item, string childId, string parentId)
        {
            NodeInfo nodeInfo = null;
#if Syncfusion2_0
            nodeInfo = HelperUtil.Search<NodeInfo, string>(itemList.nodeInfoCollection, item.GetType().GetProperty(parentId).GetValue(item, null).ToString(), delegate(NodeInfo nodeInfo1)
            {
                return nodeInfo1.ClassType.GetProperty(childId).GetValue(nodeInfo1.ObjectInstance, null).ToString();
            });
#elif Syncfusion3_5
            nodeInfo = HelperUtil.Search<NodeInfo, string>( itemList.nodeInfoCollection, item.GetType( ).GetProperty( parentId ).GetValue( item, null ).ToString( ), nodeInfo1 =>
            {
                return nodeInfo1.ClassType.GetProperty( childId ).GetValue( nodeInfo1.ObjectInstance, null ).ToString( );
            } );
#endif
            if (nodeInfo != null)
            {
                return nodeInfo.NodeObject;
            }
            return null;
        }

        /// <summary>
        /// Gets the child node from source list set.
        /// </summary>
        /// <param name="itemList">The item list.</param>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        private Node GetChildNodeFromSourceListSet(SourceListSetEntry itemList, object item)
        {
            NodeInfo nInfo = null;
#if Syncfusion2_0
            nInfo = itemList.nodeInfoCollection.Find(delegate(NodeInfo nodeInfo)
            {
                return nodeInfo.ObjectInstance.Equals(item);
            });
#elif Syncfusion3_5
            nInfo = itemList.nodeInfoCollection.Find( nodeInfo => nodeInfo.ObjectInstance.Equals( item ) );
#endif
            if (nInfo != null)
                return nInfo.NodeObject;
            return null;
        }

        /// <summary>
        /// Raises the query node connector style info handler.
        /// </summary>
        /// <param name="nodeRelation">The node relation.</param>
        /// <param name="parentNode">The parent node.</param>
        /// <param name="childNode">The child node.</param>
        private ConnectorBase RaiseQueryNodeConnectorStyleInfoHandler(NodeRelationDescriptor nodeRelation, Node parentNode, Node childNode)
        {
            //raise the event to customize the connectors.
            return RaiseNodeConnectStyleInfo(new NodeConnectEventArgs(nodeRelation, parentNode, childNode));
        }

        /// <summary>
        /// Connects the nodes.
        /// </summary>
        /// <param name="parentNode">The parent node.</param>
        /// <param name="childNode">The child node.</param>
        /// <returns></returns>
        private ConnectorBase ConnectNodes(Node parentNode, Node childNode)
        {

            //Check if parentNode and childNode is not NULL and then connect it
            if (parentNode != null && childNode != null)
            {
                LineConnector connector = new LineConnector(PointF.Empty, new PointF(0, 1));
                connector.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
                connector.LineStyle.LineColor = Color.Gray;
                connector.HeadDecorator.FillStyle.Color = Color.LightGray;
                //Connect the nodes
                parentNode.CentralPort.TryConnect(connector.TailEndPoint);
                childNode.CentralPort.TryConnect(connector.HeadEndPoint);
                return connector;
            }
            return null;
        }

        private bool CheckParentAndChildNodeAlreadyConnected(Node parentNode, Node childNode)
        {
            bool isAlreadyConnected = false;

            IGraphNode thisNode = parentNode as IGraphNode;

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
                            Node tChildNode = outlink.ToNode as Node;
                            if (tChildNode.Equals(childNode))
                            {
                                isAlreadyConnected = true;
                                break;
                            }
                        }
                    }
                }
            }
            return isAlreadyConnected;
        }

        #endregion

        /// <summary>
        /// Removes the node from connector.
        /// </summary>
        /// <param name="nodeRelation">The node relation.</param>
        /// <param name="nodeObj">The node obj.</param>
        /// <remarks>
        /// If the Connector is removed at both ends it would be automatically removed from the inner collection.
        /// </remarks>
        public void RemoveNodeFromConnector(NodeRelationDescriptor nodeRelation, object nodeObj)
        {
            if (CheckItemInCollection(this.SourceListSet[nodeRelation.ChildSourceName], nodeObj))
            {
                Node childNode = GetChildNodeFromSourceListSet(this.SourceListSet[nodeRelation.ChildSourceName], nodeObj);
                IGraphNode tNode = childNode as IGraphNode;
                if (tNode != null)
                {
                    foreach (ConnectorBase connector in IterateEdges(childNode, tNode.EdgesEntering))
                    {
                        Diagram.Model.RemoveChild(connector);
                        nodeRelation.nodeConnections.Remove(connector);
                    }
                    foreach (ConnectorBase connector in IterateEdges(childNode, tNode.EdgesLeaving))
                    {
                        Diagram.Model.RemoveChild(connector);
                        nodeRelation.nodeConnections.Remove(connector);
                    }
                }
            }
            else
                throw new ArgumentException("object passed is not an instance of " + this.SourceListSet[nodeRelation.ChildSourceName].SourceName);

        }

        private IEnumerable<ConnectorBase> IterateEdges(Node childNode, ICollection edges)
        {
            if (edges != null)
            {
                foreach (IGraphEdge curEdge in edges)
                {
                    // Get from IGraphEdge link.
                    ConnectorBase outlink = curEdge as ConnectorBase;
                    if (outlink != null)
                    {
                        childNode.CentralPort.Disconnect(outlink.HeadEndPoint);
                        yield return outlink;
                    }
                }
            }
        }

        /// <summary>
        /// Iterates the node relation of source list set.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public System.Collections.Generic.IEnumerable<NodeRelationDescriptor> IterateNodeRelationOfSourceListSetItem(SourceListSetEntry item)
        {
            foreach (NodeRelationDescriptor nRelation in this.Relations)
            {
                if (nRelation.ChildSourceName == item.SourceName)
                    yield return nRelation;
            }
        }

        private bool CheckItemInCollection(SourceListSetEntry source, object Obj)
        {
            bool result = false;
            foreach (object o in NodeReflectionStrategy.IterateListSource(source))
            {
                if (o.Equals(Obj))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        #endregion
    }
}
