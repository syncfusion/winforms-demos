
namespace CodeSnippetsExtractor {

    public class CodeSnippetsContainerSerializationWriter : System.Xml.Serialization.XmlSerializationWriter, Syncfusion.XmlSerializersCreator.IXmlSerializationWriter {

        protected override void InitCallbacks() {
        }
        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]

        public void WriteDataToXml(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"CodeSnippetsContainer", @"");
                return;
            }
            TopLevelElement();
            WriteSerializable(((Syncfusion.Windows.Forms.Edit.Utils.CodeSnippets.CodeSnippetsContainer)o), @"CodeSnippetsContainer", @"", true);
        }
    }

    public class CodeSnippetsContainerSerializationReader : System.Xml.Serialization.XmlSerializationReader, Syncfusion.XmlSerializersCreator.IXmlSerializationReader {

        protected override void InitCallbacks() {
        }
        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]

        public object ReadDataFromXml() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id1_CodeSnippetsContainer && (object) Reader.NamespaceURI == (object)id2_Item)) {
                    o = (Syncfusion.Windows.Forms.Edit.Utils.CodeSnippets.CodeSnippetsContainer)ReadSerializable(new Syncfusion.Windows.Forms.Edit.Utils.CodeSnippets.CodeSnippetsContainer());
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null);
            }
            return (object)o;
        }

        System.String id1_CodeSnippetsContainer;
        System.String id2_Item;

        protected override void InitIDs() {
            id1_CodeSnippetsContainer = Reader.NameTable.Add(@"CodeSnippetsContainer");
            id2_Item = Reader.NameTable.Add(@"");
        }
    }
}
