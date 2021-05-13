#region Copyright Syncfusion Inc. 2001 - 2011
//
//  Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Runtime.Serialization;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Diagram;

namespace ControlsGalore
{	
	/// <summary>
	/// CustomListSymbol class that exposes a serializable ListBox hosted by its child ControlNode.
	/// </summary>
	[ Serializable() ]
	public class ListBoxControNode
		: ControlNode
	{
		#region Constants
		private const string c_strLIST_BOX_ITEMS = "listboxitems";
		#endregion
		
		#region initialize/finalize methods
		/// <summary>
		/// Default constructor.
		/// </summary>
		public ListBoxControNode()
			: base( new ListBox(), new System.Drawing.Rectangle( 0, 0, 200, 85 ) )
		{
			ListBox lst = this.HostingControl as ListBox;
        	
			lst.IntegralHeight = false;
			string[] itemsarray = new string[] { "ListBox in a ControlNode", "Use PropertyEditor to add/remove items" };
			lst.Items.AddRange( itemsarray );
		}
		/// <summary>
		/// Copy constructor.
		/// </summary>
		/// <param name="src"></param>
		public ListBoxControNode( ListBoxControNode src )
			: base( src )
		{
			ListBox lst = this.HostingControl as ListBox;
			ListBox lstSrc = src.HostingControl as ListBox;
			string[] itemsarray = new string[ lstSrc.Items.Count ];
			lstSrc.Items.CopyTo( itemsarray, 0 );
			lst.Items.AddRange( itemsarray );
		}
		/// <summary>
		/// Serialization constructor for the CustomList class.
		/// </summary>
		/// <param name="info">Serialization state information</param>
		/// <param name="context">Streaming context information</param>
		/// <summary>
		protected ListBoxControNode( SerializationInfo info, StreamingContext context )
			: base( info, context )
		{
			ListBox lst = this.HostingControl as ListBox;
			lst.IntegralHeight = false;

			try
			{
				string[] items = ( string[] ) this.HCP[ c_strLIST_BOX_ITEMS ];
				
				if( items != null )
					lst.Items.AddRange( items );
			}
			catch( SerializationException )
			{}
		}
		#endregion

		#region overrides
		protected override void GetObjectData( SerializationInfo info, StreamingContext context )
		{
			ListBox lst = this.HostingControl as ListBox;
			string[] items = new string[ lst.Items.Count ];
			lst.Items.CopyTo( items, 0 );
			
			if( this.HCP.ContainsKey( c_strLIST_BOX_ITEMS ) )
			{
				this.HCP[ c_strLIST_BOX_ITEMS ] = items;
			}
			else
			{
				this.HCP.Add( c_strLIST_BOX_ITEMS, items );
			}
			
			base.GetObjectData( info, context );
		}

		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>Copy of the object this method is invoked against</returns>
		public override object Clone()
		{
			return new ListBoxControNode( this );
		}
		#endregion
	}

}