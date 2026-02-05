import System.Drawing;
import System.Windows.Forms;
import Syncfusion.Windows.Forms.Diagram;

class Script{ 
  
  static function Main()
  {
    MessageBox.Show("Starting JScript script", "Essential Suite Scripting", MessageBoxButtons.OK, MessageBoxIcon.Information)
  }
  
  static function OnScriptStart()
  {
    DocumentEventSink.add_NodeCollectionChanged(Script.Model_ChildrenChangeComplete)
    DiagramViewerEventSink.add_NodeCollectionChanged(Script.Viewer_SelectionChanged)
  }
  
  static function OnScriptStop()
  {
    DocumentEventSink.remove_NodeCollectionChanged(Script.Model_ChildrenChangeComplete)
    DiagramViewerEventSink.remove_NodeCollectionChanged(Script.Viewer_SelectionChanged)
  }
  
/** @attribute.method Syncfusion.Windows.Forms.Diagram.EventHandlerPriorityAttribute(true) */
  static function Viewer_SelectionChanged(args:CollectionExEventArgs)
  {  
		MessageBox.Show(" node added", "Essential Suite Scripting", 
			MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        for (var n in args.Elements)
        {
			if(n instanceof FilledPath)
			{
				var shapenode:FilledPath = FilledPath(n);
				var colorval:Color = shapenode.FillStyle.Color;      
        var strcolor = colorval.ToString();

        if(strcolor == Color.Red.ToString())
					shapenode.FillStyle.Color = Color.Green;
        else if(strcolor == Color.Green.ToString())
					shapenode.FillStyle.Color = Color.Blue;
        else 
					shapenode.FillStyle.Color = Color.Red;
			}
		}
  }
    
  static function Model_ChildrenChangeComplete(args:CollectionExEventArgs)
  {   
        for (var n in args.Elements)
        {
			if(n instanceof Syncfusion.Windows.Forms.Diagram.FilledPath)
			{
				var shapenode:Syncfusion.Windows.Forms.Diagram.FilledPath = FilledPath(n);
				shapenode.FillStyle.Color = Color.Red;
				shapenode.FillStyle.ForeColor = Color.Red;
			}
	        
			if (n instanceof Syncfusion.Windows.Forms.Diagram.Node)
			{
				var node:Node = Node(n);
        if(args.ChangeType == Syncfusion.Windows.Forms.Diagram.CollectionExChangeType.Insert)
        {
					MessageBox.Show(String.Concat(node.Name, " node added"), "Essential Suite Scripting", 
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else if(args.ChangeType == Syncfusion.Windows.Forms.Diagram.CollectionExChangeType.Remove)
        {
					MessageBox.Show(String.Concat(node.Name, " node Removed"), "Essential Suite Scripting", 
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);     
				}
        }
    }  
  }  
}


