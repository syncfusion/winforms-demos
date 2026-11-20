#region Copyright Syncfusion Inc. 2001 - 2007
//
//  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
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

namespace Syncfusion.Windows.Forms.Diagram.Samples.DiagramTool
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

			this.AddEventSource("Model", "Syncfusion.Windows.Forms.Diagram.Model");
			this.AddEventSource("View", "Syncfusion.Windows.Forms.Diagram.View");
			this.AddEventSource("Controller", "Syncfusion.Windows.Forms.Diagram.Controller");
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
			if (eventSourceName.Equals(Resources.Strings.ObjectName.Get("Model")))
			{
				return diagram.Model;
			}

			if (eventSourceName.Equals(Resources.Strings.ObjectName.Get("View")))
			{
				return diagram.View;
			}

			if (eventSourceName.Equals(Resources.Strings.ObjectName.Get("Controller")))
			{
				return diagram.Controller;
			}

			return null;
		}

		/// <summary>
		/// Gets a reference to a global item, such as the host-provided application object.
		/// </summary>
		public override object GetGlobalInstance(string globInstanceName)
		{
			if (globInstanceName.Equals(Resources.Strings.ObjectName.Get("Model")))
			{
				return diagram.Model;
			}

			if (globInstanceName.Equals(Resources.Strings.ObjectName.Get("View")))
			{
				return diagram.View;
			}

			if (globInstanceName.Equals(Resources.Strings.ObjectName.Get("Controller")))
			{
				return diagram.Controller;
			}

			return null;
		}

		private Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram = null;
	}

	#endregion // DiagramScriptSite
}
