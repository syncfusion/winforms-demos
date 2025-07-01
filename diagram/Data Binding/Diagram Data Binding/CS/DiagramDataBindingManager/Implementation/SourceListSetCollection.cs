#region Copyright Syncfusion Inc. 2001 - 2012
// Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
using System;
using System.Collections;
using Syncfusion.Windows.Forms.Diagram;
using System.Drawing;
using System.Reflection;
using System.ComponentModel;

namespace Syncfusion.Windows.Forms.Diagram.DataBinding
{
    /// <summary>
    /// Holds the SourceListSet objects in a collection.
    /// </summary>
    public class SourceListSetCollection : IList<SourceListSetEntry>
    {

        #region Private members

        List<SourceListSetEntry> _sourceListSetColl;
        private DiagramDataBindingManager _diagramEngine;

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceListSetCollection"/>
        /// </summary>
        public SourceListSetCollection(DiagramDataBindingManager diagram)
        {
            _diagramEngine = diagram;
            _sourceListSetColl = new List<SourceListSetEntry>();
        }

        #region ResolveNode

        /// <summary>
        /// Resolves all the node present in the SourceListSet.
        /// </summary>
        /// <param name="item">The item.</param>
        internal void ResolveNodes(SourceListSetEntry item)
        {
            if (_sourceListSetColl.Contains(item))
            {
                this._diagramEngine.Diagram.BeginUpdate();

                //Loop thru each object that is present inside the IList of SourceListSet.
                foreach (object itemObj in NodeReflectionStrategy.IterateListSource(item))
                {
                    AddNode(item, itemObj);
                }
                //this._diagramEngine.RefreshLayoutManager( );
                this._diagramEngine.Diagram.EndUpdate();

                if (item.Source is System.ComponentModel.IBindingList)
                {
                    WireBindingList((IBindingList)item.Source);
                }
            }
            else
                throw new ArgumentException("Unknown SourceListSet instance");
        }

        /// <summary>
        /// Processes the node.
        /// </summary>
        /// <param name="sourceListItem">The source list item.</param>
        /// <param name="item">The item.</param>
        /// <remarks>
        /// Pass the ith item of the IList along with the SourceListSet. Use NodeReflectionStrategy.GetItemAt() function for better usage.
        /// </remarks>
        public void AddNode(SourceListSetEntry sourceListItem, object item)
        {
            if (sourceListItem.nodeInfoCollection.Find(delegate(NodeInfo nInfo)
                       {
                           return item.Equals(nInfo.ObjectInstance);
                       }) == null)
            {
                NodeClassInfo nodeClassInfo = NodeReflectionStrategy.GetNodeClassInfo(item);

                Node node = GenerateNode(item, nodeClassInfo);
                if (node != null)
                {
                    //Add the node to the diagram model.
                    AddToDiagramModel((Node)node);
                    //Add to NodeInfoCollection
                    sourceListItem.nodeInfoCollection.Add(new NodeInfo(nodeClassInfo.ClassType, (Node)node, item));
                    if (_diagramEngine.IsNodeAddedEventListening)
                    {
                        //Raise the event. We can customize the look and feel of the nodes in the event listener code.
                        _diagramEngine.RaiseNodeAddedEvent(new NodeAddedEventArgs(sourceListItem.SourceName, (Node)node));
                    }

                    foreach (NodeRelationDescriptor nodeRelation in this._diagramEngine.IterateNodeRelationOfSourceListSetItem(sourceListItem))
                    {
                        //Provide ChildSourceList's objects to iterate and connect.
                        this._diagramEngine.AddConnection(nodeRelation, item);
                    }
                }
            }
        }

        /// <summary>
        /// Removes the node.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="nodeObj">The node obj.</param>
        public void RemoveNode(SourceListSetEntry item, object nodeObj)
        {
            if (item.Source is IBindingList)
                this.UnWireBindingList((IBindingList)item.Source);
            NodeInfo nodeInfo = item.nodeInfoCollection.Find(delegate(NodeInfo nInfo)
            {
                return nodeObj.Equals(nInfo.ObjectInstance);
            });

            if (nodeInfo != null)
            {
                //Remove connection first
                foreach (NodeRelationDescriptor nodeRelation in this._diagramEngine.IterateNodeRelationOfSourceListSetItem(item))
                {
                    this._diagramEngine.RemoveNodeFromConnector(nodeRelation, nodeObj);
                }
                //Remove from inner list
                item.Source.Remove(nodeInfo.ObjectInstance);
                item.nodeInfoCollection.Remove(nodeInfo);
                this._diagramEngine.Diagram.Model.RemoveChild(nodeInfo.NodeObject);
            }
            if (item.Source is IBindingList)
                this.WireBindingList((IBindingList)item.Source);
        }


        /// <summary>
        /// Wires the binding list.
        /// </summary>
        /// <param name="item">The item.</param>
        private void WireBindingList(IBindingList item)
        {
            item.ListChanged += new ListChangedEventHandler(item_ListChanged);
        }

        /// <summary>
        /// Unwire binding list.
        /// </summary>
        /// <param name="item">The item.</param>
        private void UnWireBindingList(IBindingList item)
        {
            item.ListChanged -= new ListChangedEventHandler(item_ListChanged);
        }

        /// <summary>
        /// Gets the parent source list set from item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        private SourceListSetEntry GetSourceListSetFromList(IList item)
        {
            SourceListSetEntry tListSet = null;
            foreach (SourceListSetEntry sourceListSet in this._sourceListSetColl)
            {
                if (sourceListSet.Source.GetHashCode() == item.GetHashCode())
                {
                    tListSet = sourceListSet;
                    break;
                }
            }
            return tListSet;
        }

        void item_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
                SourceListSetEntry sourceListSet = GetSourceListSetFromList((IList)sender);
                if (sourceListSet != null)
                {
                    AddNode(sourceListSet, NodeReflectionStrategy.GetItemAt((IList)sender, e.NewIndex));
                }
            }
            /*
           else if ( e.ListChangedType == ListChangedType.ItemDeleted )
           {
               SourceListSet sourceListSet = GetSourceListSetFromList( ( IList )sender );
               if ( sourceListSet != null )
               {
                   RemoveNode( sourceListSet, NodeReflectionStrategy.GetItemAt( ( IList )sender, e.NewIndex ) );
               }
           }*/
            this._diagramEngine.Diagram.Refresh();
        }

        /// <summary>
        /// Resolves the node based on the Attribute values specified dynamically.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="nodeClassInfo">The node class info.</param>
        /// <returns></returns>
        internal Node GenerateNode(object item, NodeClassInfo nodeClassInfo)
        {
            if (nodeClassInfo != null)
            {
                //Generate Node based on the NodeClassInfo and Append it to the Diagram Model
                NodeTypeAttribute nodeTypeAttr = nodeClassInfo.GetNodeTypeAttribute();
                /*if ( !nodeTypeAttr.IsGroupNode )
                {*/
                object node = GenerateNode(nodeTypeAttr.NodeType, nodeTypeAttr.Dimensions);
                foreach (NodePropInfo pInfo in nodeClassInfo.NodePropertyInfoCollection)
                {
                    NodeAttributeAttribute nAttr = pInfo.GetCustomAttribute();
                    if (nAttr.VisibilityType == VisibleType.Label)
                    {
                        //Add labels to node type. Get the value from the IList item and then add a label.
                        string lblText = item.GetType().GetProperty(pInfo.PropertyName).GetValue(item, null).ToString();
                        if (lblText != "")
                        {
                            AddLabel(node, lblText);
                        }
                    }
                }
                /* }
                 else
                 {
                     ConstructorInfo cInfo = nodeTypeAttr.NodeType.GetConstructor( Type.EmptyTypes  );
                     //Invoke the default constructor
                     node = cInfo.Invoke( new object[0] );
                     if ( nodeTypeAttr.NodeRectangleF.Length == 4 )
                     {
                         ( ( Group )node ).PinPoint = new PointF( nodeTypeAttr.NodeRectangleF[0], nodeTypeAttr.NodeRectangleF[1] );
                         ( ( Group )node ).Size = new SizeF( nodeTypeAttr.NodeRectangleF[2], nodeTypeAttr.NodeRectangleF[3] );
                     }
                     else
                     {
                         ( ( Group )node ).PinPoint = new PointF( 0, 0 );
                         ( ( Group )node ).Size = new SizeF( 100, 100 );
                     }

                     foreach ( NodePropInfo pInfo in nodeClassInfo.NodePropertyInfoCollection )
                     {
                         NodeAttributeAttribute nAttr = pInfo.GetCustomAttribute( );
                         if ( nAttr.VisibilityType == VisibleType.Node )
                         {
                             //add node to the Group collection
                             object childNode = GenerateNode( nAttr.NodeType, nAttr.NodeRectangleF );
                             //add the node to the Group object
                             ( ( Group )node ).AppendChild( ( Node )childNode );
                         }
                     }
                 }*/
                return (Node)node;
            }
            return null;
        }

        private object GenerateNode(Type nodeType, float[] nodeRectangleF)
        {
            object node = null;
            if (nodeType != null)
            {
                ConstructorInfo cInfo = nodeType.GetConstructor(new Type[] { typeof(RectangleF) });

                //Check if the NodeRectangle value is given
                if (nodeRectangleF.Length == 4)
                {
                    node = cInfo.Invoke(new object[] { new RectangleF(nodeRectangleF[0], nodeRectangleF[1], nodeRectangleF[2], nodeRectangleF[3]) });
                }
                else
                {
                    node = cInfo.Invoke(new object[] { new RectangleF(100, 100, 100, 100) });
                }
            }
            return node;
        }

        /// <summary>
        /// Adds the label.
        /// </summary>
        /// <param name="node">The node.</param>
        /// <param name="lblText">The Label text.</param>
        private void AddLabel(object node, string lblText)
        {
            PropertyInfo lblPropInfo = node.GetType().GetProperty("Labels");
            if (lblPropInfo != null)
            {
                //Get the labelCollection object
                object lblCollection = lblPropInfo.GetGetMethod().Invoke(node, null);
                Label lbl = new Label();
                lbl.FontStyle.Family = "Segoe UI";
                lbl.Text = lblText;
                lblCollection.GetType().GetMethod("Add").Invoke(lblCollection, new object[] { lbl });
            }
        }

        /// <summary>
        /// Adds to diagram model.
        /// </summary>
        
        private void AddToDiagramModel(Node nodeInstance)
        {
            this._diagramEngine.Diagram.Model.AppendChild(nodeInstance);


        }

        #endregion

        /// <summary>
        /// Raises when the SourceListSet collection is changing.
        /// </summary>
        public event SourceListSetChanging OnSourceListSetChanging;
        /// <summary>
        /// Raises when the SourceListSet collection is changed.
        /// </summary>
        public event SourceListSetChanged OnSourceListSetChanged;

        /// <summary>
        /// Raises the source list set changing event args.
        /// </summary>
        /// <param name="sourceName">Name of the source.</param>
        /// <param name="collectionChangedType">Type of the collection changed.</param>
        /// <returns></returns>
        private bool RaiseSourceListSetChangingEventArgs(string sourceName, CollectionChangingType collectionChangedType)
        {
            SourceListSetCancelEventArgs cEvtArgs = new SourceListSetCancelEventArgs(sourceName, collectionChangedType);
            if (OnSourceListSetChanging != null)
            {
                OnSourceListSetChanging(this, cEvtArgs);
            }
            return cEvtArgs.Cancel;
        }

        /// <summary>
        /// Raises the source list set changed event args.
        /// </summary>
        /// <param name="source">Name of the source.</param>
        /// <param name="collectionChangedType">Type of the collection changed.</param>
        private void RaiseSourceListSetChangedEventArgs(SourceListSetEntry source, CollectionChangedType collectionChangedType)
        {
            if (OnSourceListSetChanged != null)
            {
                OnSourceListSetChanged(this, new SourceListSetEventArgs(source, collectionChangedType));
            }
        }

        #region IList<SourceListSet> Members

        /// <summary>
        /// Determines the index of a specific item in the <see cref="T:System.Collections.Generic.IList`1"/>.
        /// </summary>
        /// <param name="item">The object to locate in the <see cref="T:System.Collections.Generic.IList`1"/>.</param>
        /// <returns>
        /// The index of <paramref name="item"/> if found in the list; otherwise, -1.
        /// </returns>
        public int IndexOf(SourceListSetEntry item)
        {
            return _sourceListSetColl.IndexOf(item);
        }

        /// <summary>
        /// Inserts an item to the <see cref="T:System.Collections.Generic.IList`1"/> at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index at which <paramref name="item"/> should be inserted.</param>
        /// <param name="item">The object to insert into the <see cref="T:System.Collections.Generic.IList`1"/>.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// 	<paramref name="index"/> is not a valid index in the <see cref="T:System.Collections.Generic.IList`1"/>.</exception>
        /// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.IList`1"/> is read-only.</exception>
        public void Insert(int index, SourceListSetEntry item)
        {
            if (!RaiseSourceListSetChangingEventArgs(item.SourceName, CollectionChangingType.Adding))
            {
                _sourceListSetColl.Insert(index, item);

                RaiseSourceListSetChangedEventArgs(item, CollectionChangedType.Added);
            }
        }

        /// <summary>
        /// Removes the <see cref="T:System.Collections.Generic.IList`1"/> item at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the item to remove.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// 	<paramref name="index"/> is not a valid index in the <see cref="T:System.Collections.Generic.IList`1"/>.</exception>
        /// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.IList`1"/> is read-only.</exception>
        public void RemoveAt(int index)
        {
            if (index > -1 && index < _sourceListSetColl.Count)
            {
                Remove(this[index]);
            }
            else
                throw new ArgumentException("Specified index is not valid");
        }

        /// <summary>
        /// Gets or sets the Diagram.DataBinding.SourceListSetEntry at the specified index.
        /// </summary>
        /// <value></value>
        public SourceListSetEntry this[int index]
        {
            get
            {
                if (index > -1 && index < _sourceListSetColl.Count)
                    return _sourceListSetColl[index];
                return null;
            }
            set
            {
                if (index > -1 && index < this._sourceListSetColl.Count)
                {
                    if (!RaiseSourceListSetChangingEventArgs(_sourceListSetColl[index].SourceName, CollectionChangingType.Modifying))
                    {
                        _sourceListSetColl[index] = value;

                        RaiseSourceListSetChangedEventArgs(_sourceListSetColl[index], CollectionChangedType.Modified);
                    }
                }
                else
                    throw new ArgumentException("Specified index is not valid");
            }
        }

        /// <summary>
        /// Gets or sets the Diagram.DataBinding.SourceListSetEntry with the specified source name.
        /// </summary>
        /// <value></value>
        public SourceListSetEntry this[string sourceName]
        {
            get
            {
                int index = GetIndexOfSourceName(sourceName);
                if (index != -1)
                    return this[index];
                return null;
            }
            set
            {
                int index = GetIndexOfSourceName(sourceName);
                if (index != -1)
                {
                    if (!RaiseSourceListSetChangingEventArgs(sourceName, CollectionChangingType.Modifying))
                    {
                        this[index] = value;

                        RaiseSourceListSetChangedEventArgs(this[index], CollectionChangedType.Modified);
                    }
                }
                else
                    throw new ArgumentException("Specified SourceName doesnot exists");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public SourceListSetEntry this[IList item]
        {
            get
            {
                SourceListSetEntry tListSet = null;
                tListSet = _sourceListSetColl.Find(delegate(SourceListSetEntry source)
                {
                    return source.Source.GetHashCode() == item.GetHashCode();
                });
                return tListSet;
            }
        }

        /// <summary>
        /// Gets the name of the index of source.
        /// </summary>
        /// <param name="sourceName">Name of the source.</param>
        /// <returns></returns>
        private int GetIndexOfSourceName(string sourceName)
        {
            int result = -1;
            for (int i = 0; i < _sourceListSetColl.Count; i++)
            {
                if (this[i].SourceName == sourceName)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        #endregion

        #region ICollection<SourceListSet> Members

        /// <summary>
        /// Adds an item to the <see cref="T:System.Collections.Generic.ICollection`1"/>.
        /// </summary>
        /// <param name="item">The object to add to the <see cref="T:System.Collections.Generic.ICollection`1"/>.</param>
        /// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only.</exception>
        public void Add(SourceListSetEntry item)
        {
            if (!RaiseSourceListSetChangingEventArgs(item.SourceName, CollectionChangingType.Adding))
            {
                this._sourceListSetColl.Add(item);

                ResolveNodes(item);

                RaiseSourceListSetChangedEventArgs(item, CollectionChangedType.Added);
            }
        }

        /// <summary>
        /// Adds the specified source name.
        /// </summary>
        /// <param name="sourceName">Name of the source.</param>
        /// <param name="source">The source.</param>
        public void Add(string sourceName, IList source)
        {
            Add(new SourceListSetEntry(sourceName, source));
        }

        /// <summary>
        /// Removes all items from the <see cref="T:System.Collections.Generic.ICollection`1"/>.
        /// </summary>
        /// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only. </exception>
        public void Clear()
        {
            foreach (SourceListSetEntry listSet in _sourceListSetColl)
                listSet.nodeInfoCollection.Clear();
            //to reset the event if it is set.
            this._diagramEngine.ListenToRelationChanges = false;
            _sourceListSetColl.Clear();
        }

        /// <summary>
        /// Determines whether the <see cref="T:System.Collections.Generic.ICollection`1"/> contains a specific value.
        /// </summary>
        /// <param name="item">The object to locate in the <see cref="T:System.Collections.Generic.ICollection`1"/>.</param>
        /// <returns>
        /// true if <paramref name="item"/> is found in the <see cref="T:System.Collections.Generic.ICollection`1"/>; otherwise, false.
        /// </returns>
        public bool Contains(SourceListSetEntry item)
        {
            return _sourceListSetColl.Contains(item);
        }

        /// <summary>
        /// Copies the elements of the <see cref="T:System.Collections.Generic.ICollection`1"/> to an <see cref="T:System.Array"/>, starting at a particular <see cref="T:System.Array"/> index.
        /// </summary>
        /// <param name="array">The one-dimensional <see cref="T:System.Array"/> that is the destination of the elements copied from <see cref="T:System.Collections.Generic.ICollection`1"/>. The <see cref="T:System.Array"/> must have zero-based indexing.</param>
        /// <param name="arrayIndex">The zero-based index in <paramref name="array"/> at which copying begins.</param>
        /// <exception cref="T:System.ArgumentNullException">
        /// 	<paramref name="array"/> is null.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// 	<paramref name="arrayIndex"/> is less than 0.</exception>
        /// <exception cref="T:System.ArgumentException">
        /// 	<paramref name="array"/> is multidimensional.-or-<paramref name="arrayIndex"/> is equal to or greater than the length of <paramref name="array"/>.-or-The number of elements in the source <see cref="T:System.Collections.Generic.ICollection`1"/> is greater than the available space from <paramref name="arrayIndex"/> to the end of the destination <paramref name="array"/>.-or-Type <paramref name="T"/> cannot be cast automatically to the type of the destination <paramref name="array"/>.</exception>
        public void CopyTo(SourceListSetEntry[] array, int arrayIndex)
        {
            _sourceListSetColl.CopyTo(array, arrayIndex);
        }

        /// <summary>
        /// Gets the number of elements contained in the <see cref="T:System.Collections.Generic.ICollection`1"/>.
        /// </summary>
        /// <value></value>
        /// <returns>The number of elements contained in the <see cref="T:System.Collections.Generic.ICollection`1"/>.</returns>
        public int Count
        {
            get { return _sourceListSetColl.Count; }
        }

        /// <summary>
        /// Gets a value indicating whether the <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only.
        /// </summary>
        /// <value></value>
        /// <returns>true if the <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only; otherwise, false.</returns>
        public bool IsReadOnly
        {
            get { return false; }
        }

        /// <summary>
        /// Removes the first occurrence of a specific object from the <see cref="T:System.Collections.Generic.ICollection`1"/>.
        /// </summary>
        /// <param name="item">The object to remove from the <see cref="T:System.Collections.Generic.ICollection`1"/>.</param>
        /// <returns>
        /// true if <paramref name="item"/> was successfully removed from the <see cref="T:System.Collections.Generic.ICollection`1"/>; otherwise, false. This method also returns false if <paramref name="item"/> is not found in the original <see cref="T:System.Collections.Generic.ICollection`1"/>.
        /// </returns>
        /// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only.</exception>
        public bool Remove(SourceListSetEntry item)
        {
            bool result = false;
            if (!RaiseSourceListSetChangingEventArgs(item.SourceName, CollectionChangingType.Removing))
            {
                this._diagramEngine.Diagram.BeginUpdate();
                //Remove the temproary nodes placed inside SoureListSet too
                foreach (NodeInfo nInfo in item.nodeInfoCollection)
                    RemoveChild(nInfo.NodeObject);
                this._diagramEngine.Diagram.EndUpdate();

                item.nodeInfoCollection.Clear();
                SourceListSetEntry tSourceListSet = item.Clone();//Generating a clone since the item would be removed once it is removed from the collection.
                result = this._sourceListSetColl.Remove(item);

                RaiseSourceListSetChangedEventArgs(tSourceListSet, CollectionChangedType.Removed);
            }
            return result;
        }

        /// <summary>
        /// Removes the child node.
        /// </summary>
        /// <param name="NodeObject">The node object.</param>
        private void RemoveChild(Node NodeObject)
        {
            _diagramEngine.Diagram.Model.RemoveChild(NodeObject);
        }

        /// <summary>
        /// Removes the specified source name.
        /// </summary>
        /// <param name="sourceName">Name of the source.</param>
        /// <returns></returns>
        public bool Remove(string sourceName)
        {
            return Remove(this[sourceName]);
        }

        #endregion

        #region IEnumerable<SourceListSet> Members

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Collections.Generic.IEnumerator`1"/> that can be used to iterate through the collection.
        /// </returns>
        public IEnumerator<SourceListSetEntry> GetEnumerator()
        {
            return _sourceListSetColl.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Collections.IEnumerator"/> object that can be used to iterate through the collection.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return _sourceListSetColl.GetEnumerator();
        }

        #endregion
    }
}