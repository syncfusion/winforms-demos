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
using Syncfusion.Windows.Forms.Diagram;
using System.Drawing;
using System.Collections;

namespace Syncfusion.Windows.Forms.Diagram.DataBinding
{
    /// <summary>
    /// Defines the Reflection implementation for retrieving the Node info from the Class attributes. 
    /// </summary>
    /// <remarks>
    /// Loads the Node parameters identified thru reflection. By default, it will look for the Class with NodeType attributes defined. If the classes are defined in some other assembly, call the BuildUp() function to load those into the DiagramDataBindingManager.
    /// </remarks>
    public class NodeReflectionStrategy : ReflectionStrategy<NodeClassInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeReflectionStrategy"/>
        /// </summary>
        public NodeReflectionStrategy()
        {
            _reflectionInfoCollection = new List<NodeClassInfo>();
        }

        #region BuildUp

        /// <summary>
        /// Builds up the Reflection info that would be used for getting the Node attribute's information.
        /// </summary>
        public override void BuildUp(Assembly assembly)
        {
            foreach (Type classType in GetNodeType(assembly))
            {
                List<NodePropInfo> nodePropInfoColl = new List<NodePropInfo>();
                foreach (PropertyInfo pInfo in GetNodeAttributePropertyInfo(classType))
                {
                    nodePropInfoColl.Add(new NodePropInfo(pInfo.Name, pInfo));
                }
                _reflectionInfoCollection.Add(new NodeClassInfo(classType.Name, classType, nodePropInfoColl));
            }
        }

        /// <summary>
        /// Gets the type of the node.
        /// </summary>
        /// <returns></returns>
        private IEnumerable<Type> GetNodeType(Assembly assembly)
        {
            if (assembly != null)
            {
                Type[] types = assembly.GetTypes();
                foreach (Type t in types)
                {
                    if (Attribute.GetCustomAttribute(t, typeof(NodeTypeAttribute)) != null)
                        yield return t;
                }
            }
        }

        /// <summary>
        /// Gets the node attribute property info.
        /// </summary>
        /// <param name="nodeType">Type of the node.</param>
        /// <returns></returns>
        private IEnumerable<PropertyInfo> GetNodeAttributePropertyInfo(Type nodeType)
        {
            foreach (PropertyInfo pInfo in nodeType.GetProperties())
            {
                if (Attribute.GetCustomAttribute(pInfo, typeof(NodeAttributeAttribute)) != null)
                    yield return pInfo;
            }
        }

        #endregion

        /// <summary>
        /// Clears up the memory.
        /// </summary>
        public override void TearDown()
        {
            _reflectionInfoCollection.Clear();
        }

        static List<NodeClassInfo> _reflectionInfoCollection;
        /// <summary>
        /// Gets or sets the reflection info collection.
        /// </summary>
        /// <value>The reflection info collection.</value>
        public static List<NodeClassInfo> ReflectionInfoCollection
        {
            get
            {
                return _reflectionInfoCollection;
            }
        }

        /// <summary>
        /// Gets the node object.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        internal static IEnumerable<object> IterateListSource(SourceListSetEntry item)
        {
            PropertyInfo pInfo = item.Source.GetType().GetProperty("Item");
            int i = 0;
            foreach (object o in item.Source)
            {
                yield return pInfo.GetValue(item.Source, new object[] { i });
                i++;
            }
        }

        /// <summary>
        /// Gets the item at 'i' for the IList object.
        /// </summary>        
        /// <param name="list">The list.</param>
        /// <param name="i">ith location.</param>
        /// <returns></returns>
        public static object GetItemAt(IList list, int i)
        {
            return list.GetType().GetProperty("Item").GetValue(list, new object[] { i });
        }

        /// <summary>
        /// Gets the node class info.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        internal static NodeClassInfo GetNodeClassInfo(object item)
        {
            NodeClassInfo nInfo = null;
#if Syncfusion2_0
            nInfo = _reflectionInfoCollection.Find(delegate(NodeClassInfo nodeClassInfo)
           {
               return nodeClassInfo.ClassType.Name == item.GetType().Name;
           });
#elif Syncfusion3_5
            nInfo = _reflectionInfoCollection.Find( nodeClassInfo => nodeClassInfo.ClassType.Name == item.GetType().Name );
#endif
            return nInfo;
        }
    }
}
