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
using System.ComponentModel;
using Syncfusion.Windows.Forms.Diagram;

namespace Syncfusion.Windows.Forms.Diagram.DataBinding
{
    /// <summary>
    /// Provides the Enumeration for CollectionChangedType enum.
    /// </summary>
    public enum CollectionChangedType
    {
        /// <summary>
        /// 
        /// </summary>
        Added,
        /// <summary>
        /// 
        /// </summary>
        Modified,
        /// <summary>
        /// 
        /// </summary>
        Removed
    }

    /// <summary>
    /// Provides the Enumeration for CollectionChanging enum.
    /// </summary>
    public enum CollectionChangingType
    {
        /// <summary>
        /// 
        /// </summary>
        Adding,
        /// <summary>
        /// 
        /// </summary>
        Modifying,
        /// <summary>
        /// 
        /// </summary>
        Removing
    }

    /// <summary>
    /// Defines the EventArgs value for NodeRelation
    /// </summary>
    public class NodeRelationEventArgs : EventArgs
    {
        private CollectionChangedType _collectionChangedType;
        /// <summary>
        /// Gets the CollectionChangedType instance.
        /// </summary>
        /// <value>The type of the collection changed.</value>
        public CollectionChangedType CollectionChangedType
        {
            get
            {
                return _collectionChangedType;
            }
        }


        private NodeRelationDescriptor _relation;
        /// <summary>
        /// Gets the name of the relation.
        /// </summary>
        /// <value>The name of the relation.</value>
        public NodeRelationDescriptor Relation
        {
            get
            {
                return _relation;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeRelationEventArgs"/> 
        /// </summary>
        /// <param name="relation">Name of the relation.</param>
        /// <param name="collectionChangedType">Type of the collection changed.</param>
        public NodeRelationEventArgs(NodeRelationDescriptor relation, CollectionChangedType collectionChangedType)
        {
            _relation = relation;
            _collectionChangedType = collectionChangedType;
        }
    }

    /// <summary>
    /// Defines the CancelEventArgs for NodeRelation
    /// </summary>
    public class NodeRelationCancelEventArgs : System.ComponentModel.CancelEventArgs
    {
        private CollectionChangingType _collectionChangedType;
        /// <summary>
        /// Gets the CollectionChangedType instance.
        /// </summary>
        /// <value>The type of the collection changed.</value>
        public CollectionChangingType CollectionChangedType
        {
            get
            {
                return _collectionChangedType;
            }
        }

        private string _relationName;
        /// <summary>
        /// Gets the name of the relation.
        /// </summary>
        /// <value>The name of the relation.</value>
        public string RelationName
        {
            get
            {
                return _relationName;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeRelationCancelEventArgs"/>.
        /// </summary>
        /// <param name="relationName">Name of the relation.</param>
        /// <param name="collectionChangedType">Type of the collection changed.</param>
        public NodeRelationCancelEventArgs(string relationName, CollectionChangingType collectionChangedType)
        {
            _relationName = relationName;
            _collectionChangedType = collectionChangedType;
        }

    }
    /// <summary>
    /// 
    /// </summary>
    public delegate void NodeRelationCollectionChangingEventHandler(object sender, NodeRelationCancelEventArgs args);
    /// <summary>
    /// 
    /// </summary>
    public delegate void NodeRelationCollectionChangedEventHandler(object sender, NodeRelationEventArgs args);

    /// <summary>
    /// Delegate used when the NodeRelation is changing.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    public delegate void NodeRelationChanging(object sender, NodeRelationCancelEventArgs args);

    /// <summary>
    /// Delegate used when the NodeRelation is changed.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    public delegate void NodeRelationChanged(object sender, NodeRelationEventArgs args);

    /// <summary>
    /// Defines all the base implementation for NodeRelationDescriptor.
    /// </summary>
    interface INodeRelationDescriptor
    {
        /// <summary>
        /// Gets or sets a value indicating whether 
        /// </summary>
        /// <value>
        /// 	<c>true</c> if [listen to relation changes]; otherwise, <c>false</c>.
        /// </value>
        bool ListenToRelationChanges
        {
            get;
            set;
        }
     

        /// <summary>
        /// Event raised when a node connection is changed from a childnode to some other child node.
        /// </summary>
        event NodeConnectChangedEventHandler NodeConnectChanged;
     

        /// <summary>
        /// Gets or sets the node relation keys.
        /// </summary>
        /// <value>The node relation keys.</value>
        NodeRelationCollection Relations
        {
            get;
            set;
        }

        /// <summary>
        /// Clears up memory used.
        /// </summary>
        void TearDown();

        /// <summary>
        /// Iterates the node relation of source list set.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        IEnumerable<NodeRelationDescriptor> IterateNodeRelationOfSourceListSetItem(SourceListSetEntry item);

        /// <summary>
        /// Removes the node from connector.
        /// </summary>
        /// <param name="nodeRelation">The node relation.</param>
        /// <param name="nodeObj">The node obj.</param>
        /// <remarks>
        /// If the Connector is removed at both ends it would be automatically removed from the inner collection.
        /// </remarks>
        void RemoveNodeFromConnector(NodeRelationDescriptor nodeRelation, object nodeObj);
    }
}
