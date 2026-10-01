#region Copyright Syncfusion Inc. 2001 - 2012
// Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections;
using System.ComponentModel;

namespace Syncfusion.Windows.Forms.Diagram.DataBinding
{
    /// <summary>
    /// Contains the base implementation of SourceListSet objects. These objects represent the business objects that is to be binded with the Diagram instance.
    /// </summary>
    interface ISourceListSetEntry
    {
        /// <summary>
        /// Gets or sets the name of the source.
        /// </summary>
        /// <value>The name of the source.</value>
        string SourceName {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>The source.</value>
        IList Source {
            get;
            set;
        }
    }

    #region EventArgs Impl Classes
    /// <summary>
    /// Defines the EventArgs for SourceListSet
    /// </summary>
    public class SourceListSetEventArgs : EventArgs
    {
        private SourceListSetEntry _source;
        /// <summary>
        /// Gets or sets the name of the source.
        /// </summary>
        /// <value>The name of the source.</value>
        public SourceListSetEntry Source {
            get {
                return _source;
            }
            set {
                _source = value;
            }
        }

        private CollectionChangedType _collectionChangedType;
        /// <summary>
        /// Gets the type of the collection changed.
        /// </summary>
        /// <value>The type of the collection changed.</value>
        public CollectionChangedType CollectionChangedType {
            get {
                return _collectionChangedType;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceListSetEventArgs"/>.
        /// </summary>
        /// <param name="source">Name of the source.</param>
        /// <param name="collectionChangedType">Type of the collection changed.</param>
        public SourceListSetEventArgs( SourceListSetEntry source, CollectionChangedType collectionChangedType ) {
            this._source = source;
            this._collectionChangedType = collectionChangedType;
        }

    }

    /// <summary>
    /// Defines the Cancel Event args for SourceListSet.
    /// </summary>
    public class SourceListSetCancelEventArgs : CancelEventArgs
    {
        private string _sourceName;
        /// <summary>
        /// Gets or sets the name of the source.
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

        private CollectionChangingType _collectionChangedType;
        /// <summary>
        /// Gets the type of the collection changed.
        /// </summary>
        /// <value>The type of the collection changed.</value>
        public CollectionChangingType CollectionChangedType {
            get {
                return _collectionChangedType;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceListSetCancelEventArgs"/>.
        /// </summary>
        /// <param name="sourceName">Name of the source.</param>
        /// <param name="collectionChangedType">Type of the collection changed.</param>
        public SourceListSetCancelEventArgs( string sourceName, CollectionChangingType collectionChangedType ) {
            this._sourceName = sourceName;
            this._collectionChangedType = collectionChangedType;
        }

    }

    #endregion

    #region Delegates
    /// <summary>
    /// Delegate for SourceListSetChanged event.
    /// </summary>
    /// <param name="sender">object</param>
    /// <param name="args"><see cref="SourceListSetEventArgs"/></param>
    public delegate void SourceListSetChanged( object sender, SourceListSetEventArgs args );
    /// <summary>
    /// Delegate for SourceListSetChanging event.
    /// </summary>
    /// <param name="sender">object</param>
    /// <param name="args"><see cref="SourceListSetCancelEventArgs"/></param>
    public delegate void SourceListSetChanging( object sender, SourceListSetCancelEventArgs args );

    #endregion
}
