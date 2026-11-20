#region Copyright Syncfusion Inc. 2001 - 2012
// Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Syncfusion.Windows.Forms.Diagram.DataBinding
{
    /// <summary>
    /// Defines the attributes for Node properties got through reflection.
    /// </summary>
    public class NodePropInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodePropInfo"/> 
        /// </summary>
        public NodePropInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodePropInfo"/>
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="pInfo">The p info.</param>
        public NodePropInfo(string propertyName, PropertyInfo pInfo)
        {
            this._propertyName = propertyName;
            this._propInfo = pInfo;
        }

        private string _propertyName;
        /// <summary>
        /// Gets or sets the name of the property.
        /// </summary>
        /// <value>The name of the property.</value>
        public string PropertyName
        {
            get
            {
                return _propertyName;
            }
            set
            {
                _propertyName = value;
            }
        }

        private PropertyInfo _propInfo;
        /// <summary>
        /// Gets or sets the prop info.
        /// </summary>
        /// <value>The prop info.</value>
        public PropertyInfo PropertyInfo
        {
            get
            {
                return _propInfo;
            }
            set
            {
                _propInfo = value;
            }
        }

        /// <summary>
        /// Gets the custom attributes.
        /// </summary>
        /// <returns></returns>
        public NodeAttributeAttribute GetCustomAttribute()
        {
            return (NodeAttributeAttribute)Attribute.GetCustomAttribute(_propInfo, typeof(NodeAttributeAttribute));
        }
    }

    /// <summary>
    /// Defines the Class info that is got through reflection.
    /// </summary>
    public class NodeClassInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeClassInfo"/> 
        /// </summary>
        public NodeClassInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeClassInfo"/>
        /// </summary>
        /// <param name="className">Name of the class.</param>
        /// <param name="classType">Type of the class.</param>
        /// <param name="nodePropInfoCollection">The node prop info collection.</param>
        public NodeClassInfo(string className, Type classType, List<NodePropInfo> nodePropInfoCollection)
        {
            this._className = className;
            this._classType = classType;
            this._nodePropertyInfoCollection = nodePropInfoCollection;
        }

        private string _className;
        /// <summary>
        /// Gets or sets the name of the class.
        /// </summary>
        /// <value>The name of the class.</value>
        public string ClassName
        {
            get
            {
                return _className;
            }
            set
            {
                _className = value;
            }
        }

        private Type _classType;
        /// <summary>
        /// Gets or sets the typeof value.
        /// </summary>
        public Type ClassType
        {
            get
            {
                return _classType;
            }
            set
            {
                _classType = value;
            }
        }

        private List<NodePropInfo> _nodePropertyInfoCollection;
        /// <summary>
        /// Gets or sets the node property info.
        /// </summary>
        /// <value>The node property info.</value>
        public List<NodePropInfo> NodePropertyInfoCollection
        {
            get
            {
                return _nodePropertyInfoCollection;
            }
            set
            {
                _nodePropertyInfoCollection = value;
            }
        }

        /// <summary>
        /// Gets the node type attribute.
        /// </summary>
        /// <returns></returns>
        public NodeTypeAttribute GetNodeTypeAttribute()
        {
            return (NodeTypeAttribute)Attribute.GetCustomAttribute(_classType, typeof(NodeTypeAttribute));
        }

    }

}
