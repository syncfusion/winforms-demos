#region Copyright Syncfusion Inc. 2001 - 2012
// Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using Syncfusion.Windows.Forms.Diagram.Controls;
using Syncfusion.Windows.Forms.Diagram;

namespace Syncfusion.Windows.Forms.Diagram.DataBinding
{
    

    /// <summary>
    /// Delegate for customizing the node before it is added to the Diagram Model.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    /// <returns></returns>
    public delegate void NodeAddedEventHandler( object sender, NodeAddedEventArgs args );

    /// <summary>
    /// Defines the interface for Diagram OM
    /// </summary>
    interface IDiagramEngine
    {
        /// <summary>
        /// EventHandler for customizing nodes when they are added to the Diagram Model.
        /// </summary>
        event NodeAddedEventHandler NodeAdded;

        /// <summary>
        /// Gets the Diagram model.
        /// </summary>
        /// <value>The Diagram.</value>
        Syncfusion.Windows.Forms.Diagram.Controls.Diagram Diagram {
            get;
        }

        /// <summary>
        /// Gets the source list set keys.
        /// </summary>
        /// <value>The source list set keys.</value>
        SourceListSetCollection SourceListSet {
            get;
        }

        /// <summary>
        /// Gets the NodeReflectionStrategy instance.
        /// </summary>
        NodeReflectionStrategy ReflectionStrategy {
            get;
        }

        /// <summary>
        /// Returns the LayoutManager associated with the DiagramDataBindingManager.
        /// </summary>
        LayoutManager LayoutManagerDescriptor {
            get;
        }

        /// <summary>
        /// Sets the parameters for holding all the updates.
        /// </summary>
        void BeginUpdate();

        /// <summary>
        /// Resets the parameters and refreshes the updates from the DiagramDataBindingManager to the Diagram control.
        /// </summary>
        void EndUpdate();

    }

    /// <summary>
    /// EventArgs implementation when Node is added to the Diagram Model.
    /// </summary>
    public class NodeAddedEventArgs : EventArgs
    {
        private string _source;
        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <value>The source.</value>
        public string SourceName {
            get {
                return _source;
            }
            set {
                _source = value;
            }
        }

        private Node _node;
        /// <summary>
        /// Gets the node object.
        /// </summary>
        /// <value>The node object.</value>
        public Node NodeObject {
            get {
                return _node;
            }
            set {
                _node = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the NodesCollectionEventArgs 
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="node">The node.</param>
        public NodeAddedEventArgs( string source, Node node ) {
            this._source = source;
            this._node = node;
        }

    }
}
