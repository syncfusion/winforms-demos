#Region "Copyright Syncfusion Inc. 2001 - 2007"
'
'  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Diagram

class Script  
  Public Sub Main()
  MessageBox.Show("Starting Script", "Essential Suite Scripting", MessageBoxButtons.OK, MessageBoxIcon.Information)
  End Sub
  
  public shared Sub OnScriptStart()
      AddHandler DocumentEventSink.NodeCollectionChanged, AddressOf Script.Model_ChildrenChangeComplete
      AddHandler DiagramViewerEventSink.NodeCollectionChanged, AddressOf Script.Viewer_SelectionChanged
  End Sub

  public shared Sub OnScriptStop()
      RemoveHandler DocumentEventSink.NodeCollectionChanged, AddressOf Script.Model_ChildrenChangeComplete
      RemoveHandler DiagramViewerEventSink.NodeCollectionChanged, AddressOf Script.Viewer_SelectionChanged
  End Sub
  
  ''' <method name="Model_DoubleClick" eventName="DoubleClick" type="EventHandler"><![CDATA[
  < EventHandlerPriorityAttribute( true ) > Public shared Sub Viewer_SelectionChanged(e As CollectionExEventArgs)
        Dim n as Node
        For Each n in e.Elements
            If TypeOf n Is FilledPath Then
                Dim fillednode As FilledPath = CType(n, FilledPath)
                Dim fillcolor As System.Drawing.Color = fillednode.FillStyle.Color
            Dim colorvalue As String = fillcolor.ToString()
            If colorvalue = Color.Red.ToString() Then
                    fillednode.FillStyle.Color = Color.Green
            ElseIf colorvalue = Color.Green.ToString() Then
                    fillednode.FillStyle.Color = Color.Blue
            Else
                    fillednode.FillStyle.Color = Color.Red
            End If
        End If
        Next
  End Sub
  ''' ]]></method>
  ''' <method name="Model_ChildrenChangeComplete" eventName="ChildrenChangeComplete" type="EventHandler"><![CDATA[
  
  Public shared Sub Model_ChildrenChangeComplete(e As CollectionExEventArgs)
        Dim n as Node
        For Each n in e.Elements
            If TypeOf n Is FilledPath Then
                Dim fillednode As FilledPath = CType(n, FilledPath)
                fillednode.FillStyle.Color = Color.Red
        If e.ChangeType = Syncfusion.Windows.Forms.Diagram.CollectionExChangeType.Insert Then
                    MessageBox.Show(String.Concat(n.Name, " node added"), "Syncfusion Essential Diagram", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf e.ChangeType = Syncfusion.Windows.Forms.Diagram.CollectionExChangeType.Remove Then
                    MessageBox.Show(String.Concat(n.Name, " node Removed"), "Go Syncfusion!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If
            End If
        Next
  End Sub
  ''' ]]></method>
end class
