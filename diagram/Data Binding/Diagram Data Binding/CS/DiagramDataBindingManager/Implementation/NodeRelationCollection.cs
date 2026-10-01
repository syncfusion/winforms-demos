#region Copyright Syncfusion Inc. 2001 - 2012
// Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
using System.Collections;
using Syncfusion.Windows.Forms.Diagram;
using System;

namespace Syncfusion.Windows.Forms.Diagram.DataBinding
{
    /// <summary>
    /// Defines the RelationType for the NodeRelation.
    /// </summary>
    public enum RelationType
    {
        /// <summary>
        /// 
        /// </summary>
        ParentChild,
        /// <summary>
        /// 
        /// </summary>
        SelfRelation
    }
    /// <summary>
    /// Contains the default properties required for generating Relations between objects.
    /// </summary>
    public sealed class NodeRelationDescriptor : Syncfusion.Windows.Forms.Diagram.DataBinding.ICloneable<NodeRelationDescriptor>
    {
        /// <summary>
        /// Initializes a new instance of the NodeRelation.
        /// </summary>
        public NodeRelationDescriptor()
        {
            this.nodeConnections = new List<ConnectorBase>();
        }

        /// <summary>
        /// Initializes a new instance of the NodeRelation
        /// </summary>
        /// <param name="relationName">Name of the relation.</param>
        /// <param name="childSourceName">Name of the child source.</param>
        /// <param name="childID">The child ID.</param>
        /// <param name="parentSourceName">Name of the parent source.</param>
        /// <param name="parentID">The parent ID.</param>
        public NodeRelationDescriptor(string relationName, string childSourceName, string childID, string parentSourceName, string parentID)
            : this()
        {
            this._relationName = relationName;
            this._parentSourceName = parentSourceName;
            this._parentID = parentID;
            this._childID = childID;
            this._childSourceName = childSourceName;
        }

        /// <summary>
        /// Initializes a new instance of the NodeRelation
        /// </summary>
        /// <param name="relationName">Name of the relation.</param>
        /// <param name="childSourceName">Name of the child source.</param>
        /// <param name="childID">The child ID.</param>
        /// <param name="parentName">Name of the parent.</param>
        /// <param name="parentID">The parent ID.</param>
        /// <param name="relationType">Type of the relation.</param>
        public NodeRelationDescriptor(string relationName, string childSourceName, string childID, string parentName, string parentID, RelationType relationType)
            : this(relationName, childSourceName, childID, parentName, parentID)
        {
            this._relationType = relationType;
        }

        private RelationType _relationType;
        /// <summary>
        /// Gets or sets the type of the relation.
        /// </summary>
        /// <value>The type of the relation.</value>
        public RelationType RelationType
        {
            get
            {
                return _relationType;
            }
            set
            {
                _relationType = value;
            }
        }

        private string _parentSourceName;
        /// <summary>
        /// Gets or sets the name of the parent object collection / table.
        /// </summary>
        /// <value>The name of the parent object collection / table.</value>
        public string ParentSourceName
        {
            get
            {
                return _parentSourceName;
            }
            set
            {
                _parentSourceName = value;
            }
        }

        private string _parentID;
        /// <summary>
        /// Gets or sets the parent ID.
        /// </summary>
        /// <value>The parent ID.</value>
        public string ParentID
        {
            get
            {
                return _parentID;
            }
            set
            {
                _parentID = value;
            }
        }

        private string _childSourceName;
        /// <summary>
        /// Gets or sets the name of the child object collection / table.
        /// </summary>
        /// <value>The name of the child object collection / table.</value>
        public string ChildSourceName
        {
            get
            {
                return _childSourceName;
            }
            set
            {
                _childSourceName = value;
            }
        }

        private string _childID;
        /// <summary>
        /// Gets or sets the child ID.
        /// </summary>
        /// <value>The child ID.</value>
        public string ChildID
        {
            get
            {
                return _childID;
            }
            set
            {
                _childID = value;
            }
        }

        private string _relationName;
        /// <summary>
        /// Gets or sets the name of the relation.
        /// </summary>
        /// <value>The name of the relation.</value>
        public string RelationName
        {
            get
            {
                return _relationName;
            }
            set
            {
                _relationName = value;
            }
        }

        /// <summary>
        /// Contains the connectors collection info that would be required internally.
        /// </summary>
        internal List<ConnectorBase> nodeConnections;
        /// <summary>
        /// 
        /// </summary>
        public NodeRelationDescriptor Clone()
        {
            return new NodeRelationDescriptor(this._relationName, this._childSourceName, this._childID, this._parentSourceName, this._parentID, this._relationType);
        }
    }

    /// <summary>
    /// Contains the List of NodeRelation objects
    /// </summary>
    public class NodeRelationCollection : IList<NodeRelationDescriptor>
    {
        /// <summary>
        /// Event raised when the NodeRelationCollection is changed.
        /// </summary>
        public event NodeRelationCollectionChangedEventHandler NodeRelationCollectionChanged;

        /// <summary>
        /// Event raised when the NodeRelationCollection is changing.
        /// </summary>
        public event NodeRelationCollectionChangingEventHandler NodeRelationCollectionChanging;

        List<NodeRelationDescriptor> nodeRelationColl;
        private DiagramDataBindingManager _diagramEngine;
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeRelationCollection"/>
        /// </summary>
        public NodeRelationCollection(DiagramDataBindingManager DiagramDataBindingManager)
        {
            nodeRelationColl = new List<NodeRelationDescriptor>();
            this._diagramEngine = DiagramDataBindingManager;
        }

        /// <summary>
        /// Raises the node relation collection changing.
        /// </summary>
        /// <param name="relationName">Name of the relation.</param>
        /// <param name="collectionChangedType">Type of the collection changed.</param>
        /// <returns></returns>
        private bool RaiseNodeRelationCollectionChanging(string relationName, CollectionChangingType collectionChangedType)
        {
            NodeRelationCancelEventArgs nrCancelEvtArgs = new NodeRelationCancelEventArgs(relationName, collectionChangedType);
            if (this.NodeRelationCollectionChanging != null)
                NodeRelationCollectionChanging(this, nrCancelEvtArgs);
            return nrCancelEvtArgs.Cancel;
        }


        /// <summary>
        /// Raises the node relation collection changed.
        /// </summary>
        /// <param name="relation">Name of the relation.</param>
        /// <param name="collectionChangedType">Type of the collection changed.</param>
        private void RaiseNodeRelationCollectionChanged(NodeRelationDescriptor relation, CollectionChangedType collectionChangedType)
        {
            if (this.NodeRelationCollectionChanged != null)
                NodeRelationCollectionChanged(this, new NodeRelationEventArgs(relation, collectionChangedType));
        }


        #region IList<NodeRelation> Members

        /// <summary>
        /// Determines the index of a specific item in the <see cref="T:System.Collections.Generic.IList`1"/>.
        /// </summary>
        /// <param name="item">The object to locate in the <see cref="T:System.Collections.Generic.IList`1"/>.</param>
        /// <returns>
        /// The index of <paramref name="item"/> if found in the list; otherwise, -1.
        /// </returns>
        public int IndexOf(NodeRelationDescriptor item)
        {
            return nodeRelationColl.IndexOf(item);
        }

        /// <summary>
        /// Inserts an item to the <see cref="T:System.Collections.Generic.IList`1"/> at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index at which <paramref name="item"/> should be inserted.</param>
        /// <param name="item">The object to insert into the <see cref="T:System.Collections.Generic.IList`1"/>.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// 	<paramref name="index"/> is not a valid index in the <see cref="T:System.Collections.Generic.IList`1"/>.</exception>
        /// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.IList`1"/> is read-only.</exception>
        public void Insert(int index, NodeRelationDescriptor item)
        {

            if (!RaiseNodeRelationCollectionChanging(item.RelationName, CollectionChangingType.Removing))
            {
                nodeRelationColl.Insert(index, item);

                //Raise the CollectionChanged event
                RaiseNodeRelationCollectionChanged(item, CollectionChangedType.Added);
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
            if (index > -1 && index < nodeRelationColl.Count)
            {
                Remove(this[index]);
            }
        }

        /// <summary>
        /// Gets or sets the Syncfusion.Windows.Forms.Diagram.DataBinding.NodeRelationDescriptor at the specified index.
        /// </summary>
        /// <value></value>
        public NodeRelationDescriptor this[int index]
        {
            get
            {
                if (index > -1)
                    return this.nodeRelationColl[index];
                return null;
            }
            set
            {
                if (index > -1 && index < nodeRelationColl.Count)
                {
                    if (!RaiseNodeRelationCollectionChanging(this[index].RelationName, CollectionChangingType.Modifying))
                    {
                        this.nodeRelationColl[index] = value;

                        //Raise the Event when the collection is modified
                        this.RaiseNodeRelationCollectionChanged(this.nodeRelationColl[index], CollectionChangedType.Modified);
                    }
                }
                else
                    throw new System.ArgumentException("Invalid index");
            }
        }


        /// <summary>
        /// Gets or sets the Syncfusion.Windows.Forms.Diagram.DataBinding.NodeRelationDescriptor with the specified relation name.
        /// </summary>
        /// <value></value>
        public NodeRelationDescriptor this[string relationName]
        {
            get
            {
                int index = GetIndexOfNodeRelation(relationName);
                if (index != -1)
                    return this.nodeRelationColl[index];
                return null;
            }
            set
            {
                int index = GetIndexOfNodeRelation(relationName);
                if (index != -1 && index < this.nodeRelationColl.Count)
                {
                    if (!RaiseNodeRelationCollectionChanging(relationName, CollectionChangingType.Modifying))
                    {
                        this.nodeRelationColl[index] = value;

                        //Raise the Event when the collection is modified
                        this.RaiseNodeRelationCollectionChanged(this[relationName], CollectionChangedType.Modified);
                    }
                }
                else
                    throw new System.ArgumentException("Invalid RelationName");
            }
        }

        /// <summary>
        /// Gets the index of node relation.
        /// </summary>
        /// <param name="relationName">Name of the relation.</param>
        /// <returns></returns>
        private int GetIndexOfNodeRelation(string relationName)
        {
            int index = -1;
            for (int i = 0; i < nodeRelationColl.Count; i++)
            {
                NodeRelationDescriptor item = this.nodeRelationColl[i];
                if (item.RelationName == relationName)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        #endregion

        #region ICollection<NodeRelation> Members

        /// <summary>
        /// Adds an item to the <see cref="T:System.Collections.Generic.ICollection`1"/>.
        /// </summary>
        /// <param name="item">The object to add to the <see cref="T:System.Collections.Generic.ICollection`1"/>.</param>
        /// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only.</exception>
        public void Add(NodeRelationDescriptor item)
        {
            if (CheckSourceListSetSourceNameIsPresent(item.ChildSourceName) && CheckSourceListSetSourceNameIsPresent(item.ParentSourceName))
            {
                if (!RaiseNodeRelationCollectionChanging(item.RelationName, CollectionChangingType.Adding))
                {
                    this.nodeRelationColl.Add(item);

                    //Raise the CollectionChanged event
                    RaiseNodeRelationCollectionChanged(item, CollectionChangedType.Added);
                }
            }
            else
                throw new System.ArgumentException("The sourcename specified in ChildSourceName or ParentSourceName is not proper in the NodeRelation - " + item.RelationName);
        }

        /// <summary>
        /// Adds the specified relation name.
        /// </summary>
        /// <param name="relationName">Name of the relation.</param>
        /// <param name="parentName">Name of the parent.</param>
        /// <param name="parentID">The parent ID.</param>
        /// <param name="childName">Name of the child.</param>
        /// <param name="childID">The child ID.</param>
        public void Add(string relationName, string parentName, string parentID, string childName, string childID)
        {
            this.Add(new NodeRelationDescriptor(relationName, childName, childID, parentName, parentID));
        }

        /// <summary>
        /// Removes all items from the <see cref="T:System.Collections.Generic.ICollection`1"/>.
        /// </summary>
        /// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only. </exception>
        public void Clear()
        {
            foreach (NodeRelationDescriptor item in nodeRelationColl)
                item.nodeConnections.Clear();
            nodeRelationColl.Clear();
        }

        /// <summary>
        /// Determines whether the <see cref="T:System.Collections.Generic.ICollection`1"/> contains a specific value.
        /// </summary>
        /// <param name="item">The object to locate in the <see cref="T:System.Collections.Generic.ICollection`1"/>.</param>
        /// <returns>
        /// true if <paramref name="item"/> is found in the <see cref="T:System.Collections.Generic.ICollection`1"/>; otherwise, false.
        /// </returns>
        public bool Contains(NodeRelationDescriptor item)
        {
            return nodeRelationColl.Contains(item);
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
        public void CopyTo(NodeRelationDescriptor[] array, int arrayIndex)
        {
            nodeRelationColl.CopyTo(array, arrayIndex);
        }

        /// <summary>
        /// Gets the number of elements contained in the <see cref="T:System.Collections.Generic.ICollection`1"/>.
        /// </summary>
        /// <value></value>
        /// <returns>The number of elements contained in the <see cref="T:System.Collections.Generic.ICollection`1"/>.</returns>
        public int Count
        {
            get { return nodeRelationColl.Count; }
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
        public bool Remove(NodeRelationDescriptor item)
        {
            bool result = false;

            if (nodeRelationColl.Contains(item) && !RaiseNodeRelationCollectionChanging(item.RelationName, CollectionChangingType.Removing))
            {

                this._diagramEngine.Diagram.BeginUpdate();
                foreach (ConnectorBase connector in item.nodeConnections)
                    this._diagramEngine.Diagram.Model.RemoveChild(connector);
                this._diagramEngine.Diagram.EndUpdate();

                item.nodeConnections.Clear();
                //Clone the NodeRelation object to be passed in the Event.
                NodeRelationDescriptor tNodeRelation = item.Clone();
                result = nodeRelationColl.Remove(item);
                //Raises the CollectionChanged event when the NodeRelation is removed
                this.RaiseNodeRelationCollectionChanged(tNodeRelation, CollectionChangedType.Removed);
            }
            else
                throw new System.ArgumentException("Specified NodeRelation is not present");

            return result;
        }

        /// <summary>
        /// Removes the specified relation name.
        /// </summary>
        /// <param name="relationName">Name of the relation.</param>
        /// <returns></returns>
        public bool Remove(string relationName)
        {
            return Remove(this[relationName]);
        }

        #endregion

        #region IEnumerable<NodeRelation> Members

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Collections.Generic.IEnumerator`1"/> that can be used to iterate through the collection.
        /// </returns>
        public IEnumerator<NodeRelationDescriptor> GetEnumerator()
        {
            return nodeRelationColl.GetEnumerator();
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
            return nodeRelationColl.GetEnumerator();
        }

        #endregion

        private bool CheckSourceListSetSourceNameIsPresent(string childSourceName)
        {
            bool result = false;
            foreach (SourceListSetEntry source in this._diagramEngine.SourceListSet)
            {
                if (source.SourceName == childSourceName)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }


    }
}
