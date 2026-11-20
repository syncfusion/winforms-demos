#region Copyright Syncfusion Inc. 2001 - 2012
// Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using Syncfusion.Windows.Forms.Diagram;

namespace Syncfusion.Windows.Forms.Diagram.DataBinding
{
    /// <summary>
    /// Attribute defining the NodeType for the class.
    /// </summary>
    [System.AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, AllowMultiple = true, Inherited = true)]
    public class NodeTypeAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeTypeAttribute"/>.
        /// </summary>
        public NodeTypeAttribute()
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeTypeAttribute"/> class.
        /// </summary>
        public NodeTypeAttribute(System.Drawing.RectangleF nodeRectangle)
        {
        }

        private Type _nodeType;
        /// <summary>
        /// Gets or sets the type of the node.
        /// </summary>
        /// <value>The type of the node.</value>
        public Type NodeType
        {
            get
            {
                return _nodeType;
            }
            set
            {
                if (CheckForBaseTypeAsNode(value))
                {
                    _nodeType = value;
                }
                else if (value == null)
                    throw new ArgumentNullException("NodeType cannot be null");
                //else
                //    throw new ArgumentException("Not a valid NodeType passed");
            }
        }

        private float[] _rectangle;
        /// <summary>
        /// Gets or sets the node rectangle. Specify the x, y, width and height of the Node.
        /// </summary>
        /// <value>The node rectangle.</value>
        public float[] Dimensions
        {
            get
            {
                return _rectangle;
            }
            set
            {
                if (value.Length == 4)
                    _rectangle = value;
                else
                    throw new ArgumentException("Rectangle needs four parameters of value");
            }
        }

        /*private bool _isGroupNode = false;
        internal bool IsGroupNode {
            get {
                return _isGroupNode;
            }
            set {
                _isGroupNode = value;
            }
        }*/


        /// <summary>
        /// Checks for base type as Node.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        protected bool CheckForBaseTypeAsNode(Type value)
        {
            bool result = false;
            if (value != null && value.BaseType != null)
            {
                //turn on flag to identify if the node is of GroupType
                /*if ( value.BaseType == typeof( Group ) )
                    _isGroupNode = true;*/

                //Support for Group nodes is not yet implemented
                if (value.BaseType == typeof(Group))
                {
                    result = false;
                    return result;
                }

                if (value.BaseType == typeof(Node))
                {
                    result = true;
                    return result;
                }
                else
                {
                    result = CheckForBaseTypeAsNode(value.BaseType);
                    return result;
                }
            }
            return result;
        }

    }

    /// <summary>
    /// Defines the NodeAttribute that would enable adding labels / images to the Node dynamically.
    /// </summary>
    [System.AttributeUsage(AttributeTargets.Property, AllowMultiple = true, Inherited = true)]
    public class NodeAttributeAttribute : System.Attribute
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeAttributeAttribute"/> class.
        /// </summary>
        public NodeAttributeAttribute()
        {
        }

        private VisibleType _visibleType = VisibleType.None;
        /// <summary>
        /// Gets or sets the type of the visibility.
        /// </summary>
        /// <value>The type of the visibility.</value>
        public VisibleType VisibilityType
        {
            get
            {
                return _visibleType;
            }
            set
            {
                _visibleType = value;
                /*Implementation for Group nodes
            else if ( value == VisibleType.Node )
            {
                //If VisibleType is Node, then check for its NodeType. It should be of type 'Group'.
                if ( CheckForBaseTypeAsNode( this.NodeType ) && this.IsGroupNode )
                {
                    _visibleType = value;
                }
                else
                    throw new ArgumentException( "Check if NodeType is set as Group first. \n VisibleType.Node can be set only if the NodeType is Group. \n Or Check if NodeType is Null" );
            }*/
            }
        }

    }


    /// <summary>
    ///  Enum for Node's visible type
    /// </summary>
    public enum VisibleType
    {
        /// <summary>
        /// 
        /// </summary>
        Label,
        //Image,
        //Node,
        /// <summary>
        /// 
        /// </summary>
        None
    }
}
