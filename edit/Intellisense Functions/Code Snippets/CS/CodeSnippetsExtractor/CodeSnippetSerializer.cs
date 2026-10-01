
namespace CodeSnippetsExtractor {

    public class CodeSnippetSerializationWriter : System.Xml.Serialization.XmlSerializationWriter, Syncfusion.XmlSerializersCreator.IXmlSerializationWriter {

        protected override void InitCallbacks() {
        }
        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]

        public void WriteDataToXml(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"CodeSnippet", @"");
                return;
            }
            TopLevelElement();
            WriteSerializable(((Syncfusion.Windows.Forms.Edit.Utils.CodeSnippets.CodeSnippet)o), @"CodeSnippet", @"", true);
        }
    }

    public class CodeSnippetSerializationReader : System.Xml.Serialization.XmlSerializationReader, Syncfusion.XmlSerializersCreator.IXmlSerializationReader {

        protected override void InitCallbacks() {
        }
        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]

        public object ReadDataFromXml() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id1_CodeSnippet )) {
                    o = (Syncfusion.Windows.Forms.Edit.Utils.CodeSnippets.CodeSnippet)ReadSerializable(new Syncfusion.Windows.Forms.Edit.Utils.CodeSnippets.CodeSnippet());
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

        System.String id1_CodeSnippet;
        System.String id2_Item;

        protected override void InitIDs() {
            id1_CodeSnippet = Reader.NameTable.Add(@"CodeSnippet");
            id2_Item = Reader.NameTable.Add(@"");
        }
    }
}