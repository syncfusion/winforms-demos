#region Copyright Syncfusion Inc. 2001 - 2012
//
//  Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Runtime.Serialization;

using Syncfusion.Scripting;
using Syncfusion.Scripting.Design;
using Syncfusion.Windows.Forms.Diagram;
using Syncfusion.Windows.Forms.Diagram.Controls;

namespace Syncfusion.Windows.Forms.Diagram.Samples.Scripting
{
	#region DiagramScript

	/// <summary>
	/// Implements a customized Script for the Diagram.
	/// </summary>
	[Serializable]
	public class DiagramScript : Syncfusion.Scripting.Script, ISerializable
	{
		/// <summary>
		/// Creates an instance of the DiagramScript class
		/// </summary>
		public DiagramScript()
		{
			this.AddReference(new AssemblyDescriptor("Syncfusion.Shared.Base", String.Empty, String.Empty));
			this.AddReference(new AssemblyDescriptor("Syncfusion.Shared.Windows", String.Empty, String.Empty));
			this.AddReference(new AssemblyDescriptor("Syncfusion.Diagram.Base", String.Empty, String.Empty));
			this.AddReference(new AssemblyDescriptor("Syncfusion.Diagram.Windows", String.Empty, String.Empty));
			this.AddReference(new AssemblyDescriptor("System.Drawing", String.Empty, String.Empty));

			this.AddGlobalInstance("DocumentEventSink", "Syncfusion.Windows.Forms.Diagram.DocumentEventSink");
			this.AddGlobalInstance("DiagramViewerEventSink", "Syncfusion.Windows.Forms.Diagram.DiagramViewerEventSink");
		}

		#region ISerializable implementation

		protected DiagramScript(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			this.GetObjectData(info, context);
		}

		#endregion // ISerializable
	}

	#endregion //DiagramScript


	#region DiagramScriptSite

	/// <summary>
	/// Implements the ScriptSite for a Diagram.
	/// </summary>
	public class DiagramScriptSite : Syncfusion.Scripting.ScriptSite
	{
		/// <summary>
		/// Construct a ScriptSite for the specified diagram.
		/// </summary>
		public DiagramScriptSite(Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram)
		{
			this.diagram = diagram;
		}

		/// <summary>
		/// Gets a reference to an event source previously added to a script engine using
		/// the IVsaCodeItem.AddEventSource method.
		/// </summary>		
		public override object GetEventSourceInstance(string itemName, string eventSourceName)
		{
			if (eventSourceName.Equals("DocumentEventSink"))
			{
				return diagram.Model.EventSink;
			}

			if (eventSourceName.Equals("DiagramViewerEventSink"))
			{
				return diagram.EventSink;
			}

			return null;
		}

		/// <summary>
		/// Gets a reference to a global item, such as the host-provided application object.
		/// </summary>
		public override object GetGlobalInstance(string globInstanceName)
		{
			if (globInstanceName.Equals("DocumentEventSink"))
			{
				return diagram.Model.EventSink;
			}

			if (globInstanceName.Equals("DiagramViewerEventSink"))
			{
				return diagram.EventSink;
			}


			return null;
		}

		private Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram = null;
	}

	#endregion // DiagramScriptSite
}
