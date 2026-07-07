#region Copyright Syncfusion Inc. 2001 - 2012
// Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using Syncfusion.Windows.Forms.Diagram;
using System.Reflection;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Syncfusion.Windows.Forms.Diagram.DataBinding
{
    /// <summary>
    /// Contains the Node related objects that is used along with the SourceListSet to ide
    /// </summary>
    public sealed class NodeInfo
    {
        private Node _nodeObject;
        /// <summary>
        /// Gets or sets the node object.
        /// </summary>
        /// <value>The node object.</value>
        public Node NodeObject {
            get {
                return _nodeObject;
            }
            set {
                _nodeObject = value;
            }
        }

        private Type _classType;
        /// <summary>
        /// Gets or sets the type of the class.
        /// </summary>
        /// <value>The type of the class.</value>
        public Type ClassType {
            get {
                return _classType;
            }
            set {
                _classType = value;
            }
        }

        private object _objectInstance;
        /// <summary>
        /// Gets or sets the object instance.
        /// </summary>
        /// <value>The object instance.</value>
        public object ObjectInstance {
            get {
                return _objectInstance;
            }
            set {
                _objectInstance = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeInfo"/> [ERROR: invalid expression DeclaringTypeKind].
        /// </summary>
        /// <param name="classType">Type of the class.</param>
        /// <param name="nodeObject">The node object.</param>
        /// <param name="objectInstance">The object instance.</param>
        public NodeInfo( Type classType, Node nodeObject, object objectInstance ) {
            this._classType = classType;
            this._nodeObject = nodeObject;
            this._objectInstance = objectInstance;
        }

    }

    /// <summary>
    /// Contains the instance of IList source and its Identity name.
    /// </summary>
    public class SourceListSetEntry :  ISourceListSetEntry,ICloneable<SourceListSetEntry>
    {
        /// <summary>
        /// Initializes a new instance of the SourceListSetEntry
        /// </summary>
        public SourceListSetEntry() {
            nodeInfoCollection = new List<NodeInfo>( );
        }

        /// <summary>
        /// Initializes a new instance of the SourceListSetEntry
        /// </summary>
        /// <param name="sourceName">Name of the source.</param>
        /// <param name="source">The source.</param>
        public SourceListSetEntry( string sourceName, IList source )
            : this( ) {
            this._sourceName = sourceName;
            this._innerList = source;
        }

        private string _sourceName;
        /// <summary>
        /// Gets or sets the name of the source. It would be the Table name.
        /// </summary>
        /// <value>The name of the source.</value>
        public string SourceName {
            get {
                return _sourceName;
            }
            set {
                _sourceName = value;
            }
        }

        private IList _innerList;
        /// <summary>
        /// Gets or sets the source. Its the IList associated with the source.
        /// </summary>
        /// <value>source value.</value>
        public IList Source {
            get {
                return _innerList;
            }
            set {
                _innerList = value;
            }
        }

        /// <summary>
        /// NodeInfo collection that holds the Node related information related to the IList source present in this instance.
        /// </summary>
        protected internal List<NodeInfo> nodeInfoCollection;

#if Syncfusion3_5

        /// <summary>
        /// Gets the NodeCollection.
        /// </summary>
        public List<NodeInfo> NodeCollection {
            get {
                return nodeInfoCollection;
            }
        }
#endif

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SourceListSetEntry Clone() {
            return new SourceListSetEntry( this.SourceName, this.Source );
        }

    }
}
