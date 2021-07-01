#region Copyright Syncfusion Inc. 2001 - 2012
// Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using Syncfusion.Windows.Forms.Diagram;
using System.ComponentModel;

namespace Syncfusion.Windows.Forms.Diagram.DataBinding
{
    /// <summary>
    /// EventArgs that is used when NodeConnectEvent is raised
    /// </summary>
    public class NodeConnectEventArgs : EventArgs
    {
        private Node _parentNode;
        /// <summary>
        /// Gets or sets the parent node.
        /// </summary>
        /// <value>The parent node.</value>
        public Node ParentNode {
            get {
                return _parentNode;
            }
            set {
                _parentNode = value;
            }
        }

        private Node _childNode;
        /// <summary>
        /// Gets or sets the child node.
        /// </summary>
        /// <value>The child node.</value>
        public Node ChildNode {
            get {
                return _childNode;
            }
            set {
                _childNode = value;
            }
        }

        private NodeRelationDescriptor _nodeRelation;
        /// <summary>
        /// Gets or sets the node relation.
        /// </summary>
        /// <value>The node relation.</value>
        public NodeRelationDescriptor NodeRelation {
            get {
                return _nodeRelation;
            }
            set {
                _nodeRelation = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeConnectEventArgs"/> [ERROR: invalid expression DeclaringTypeKind].
        /// </summary>
        /// <param name="nodeRelation">The node relation.</param>
        /// <param name="parentNode">The parent node.</param>
        /// <param name="childNode">The child node.</param>
        public NodeConnectEventArgs( NodeRelationDescriptor nodeRelation, Node parentNode, Node childNode ) {
            this._nodeRelation = nodeRelation;
            this._parentNode = parentNode;
            this._childNode = childNode;
        }

    }
    /// <summary>
    /// 
    /// </summary>   
    public class NodeConnectChangingEventArgs : CancelEventArgs
    {
        private IGraphNode toNode;
        /// <summary>
        /// Gets to node.
        /// </summary>
        /// <value>To node.</value>
        public IGraphNode ToNode {
            get { return toNode; }
        }

        private IGraphNode fromNode;
        /// <summary>
        /// Gets from node.
        /// </summary>
        /// <value>From node.</value>
        public IGraphNode FromNode {
            get { return fromNode; }
        }

        private CollectionExChangeType _collectionChangedType;
        /// <summary>
        /// Gets the type of the collection changed.
        /// </summary>
        /// <value>The type of the collection changed.</value>
        public CollectionExChangeType CollectionChangedType {
            get {
                return _collectionChangedType;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeConnectChangingEventArgs"/> [ERROR: invalid expression DeclaringTypeKind].
        /// </summary>
        /// <param name="collectionChangedType">Name of the node relation.</param>
        /// <param name="fromNode">From node.</param>
        /// <param name="toNode">To node.</param>
        public NodeConnectChangingEventArgs( IGraphNode fromNode, IGraphNode toNode, CollectionExChangeType collectionChangedType ) {
            this.fromNode = fromNode;
            this.toNode = toNode;
            this._collectionChangedType = collectionChangedType;
        }

    }
    /// <summary>
    /// 
    /// </summary>
    public class NodeConnectChangedEventArgs : EventArgs
    {
        private IGraphNode toNode;

        /// <summary>
        /// Gets or sets to node.
        /// </summary>
        /// <value>To node.</value>
        public IGraphNode ToNode {
            get { return toNode; }
        }

        private IGraphNode fromNode;

        /// <summary>
        /// Gets or sets from node.
        /// </summary>
        /// <value>From node.</value>
        public IGraphNode FromNode {
            get { return fromNode; }
        }

        private CollectionExChangeType _collectionChangedType;
        /// <summary>
        /// Gets the type of the collection changed.
        /// </summary>
        /// <value>The type of the collection changed.</value>
        public CollectionExChangeType CollectionChangedType {
            get {
                return _collectionChangedType;
            }
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeConnectChangedEventArgs"/>
        /// </summary>
        /// <param name="collectionChangedType">Name of the node relation.</param>
        /// <param name="fromNode">From node.</param>
        /// <param name="toNode">To node.</param>
        public NodeConnectChangedEventArgs( IGraphNode fromNode, IGraphNode toNode, CollectionExChangeType collectionChangedType ) {
            this.fromNode = fromNode;
            this.toNode = toNode;
            this._collectionChangedType = collectionChangedType;
        }

    }


    /// <summary>
    /// Delegate to be used when connecting two nodes
    /// </summary>
    /// <param name="args">NodeConnectEventArgs</param>
    public delegate ConnectorBase NodeConnectEventHandler( NodeConnectEventArgs args );

    /// <summary>
    /// Delegate used when connection is changing.
    /// </summary>    
    /// <param name="args"></param>
    public delegate void NodeConnectChangingEventHandler( NodeConnectChangingEventArgs args );

    /// <summary>
    /// Delegate used when the connection is changed.
    /// </summary>    
    /// <param name="args"></param>
    public delegate void NodeConnectChangedEventHandler( NodeConnectChangedEventArgs args );

}
