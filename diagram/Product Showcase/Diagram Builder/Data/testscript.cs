#region Copyright Syncfusion Inc. 2001 - 2023
//
//  Copyright Syncfusion Inc. 2001 - 2023. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Windows.Forms;
using System.Drawing;
using Syncfusion.Windows.Forms.Diagram;
using Syncfusion.Windows.Forms.Diagram.Controls;

namespace Syncfusion
{
public class Script
{  
  public static void Main()
  {
  MessageBox.Show("Starting CSharp Script", "Essential Suite Scripting", MessageBoxButtons.OK, MessageBoxIcon.Information);
  }
  
  public static void OnScriptStart()
  {
			Syncfusion.Global.DocumentEventSink.NodeCollectionChanged += new CollectionExEventHandler( Script.Model_ChildrenChangeComplete);;
			Syncfusion.Global.DiagramViewerEventSink.NodeCollectionChanged += new CollectionExEventHandler( Script.View_SelectionChanged);
  }
  public static void OnScriptStop()
  {
			Syncfusion.Global.DocumentEventSink.NodeCollectionChanged -= new CollectionExEventHandler( Script.Model_ChildrenChangeComplete);
			Syncfusion.Global.DiagramViewerEventSink.NodeCollectionChanged -= new CollectionExEventHandler( Script.View_SelectionChanged);
		}
		[ EventHandlerPriorityAttribute( true ) ]
		public static void View_SelectionChanged(CollectionExEventArgs evt)
		{
			foreach (Node n in evt.Elements)
			{
				if (n is FilledPath)
				{
					FilledPath shapenode = (n as FilledPath);
					Color fillcolor = shapenode.FillStyle.Color;
					if(fillcolor == Color.Red)
						shapenode.FillStyle.Color = Color.Green;
					else if(fillcolor == Color.Green)
						shapenode.FillStyle.Color = Color.Blue;
					else shapenode.FillStyle.Color = Color.Red;

				}
			}	  
		}

		public static void Model_ChildrenChangeComplete(CollectionExEventArgs evt)
		{
			foreach (Node n in evt.Elements)
			{
				if (n is FilledPath)
				{
					(n as FilledPath).FillStyle.ForeColor = Color.Yellow;
					(n as FilledPath).FillStyle.Color = Color.Green;
					if(evt.ChangeType == Syncfusion.Windows.Forms.Diagram.CollectionExChangeType.Insert)
						MessageBox.Show(String.Concat(n.Name, " node added"), "Essential Suite Scripting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					else if(evt.ChangeType == Syncfusion.Windows.Forms.Diagram.CollectionExChangeType.Remove)
						MessageBox.Show(String.Concat(n.Name, " node Removed"), "Essential Suite Scripting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
  }
}
}
