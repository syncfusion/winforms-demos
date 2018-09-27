<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/samplebrowser.master"
    CodeFile="Sample.aspx.cs" Inherits="ScheduleTemplteSample" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    <title>Essential Pdf Viewer : Custom Toolbar Demo : Syncfusion</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <br />

  

    <script type="text/javascript">
                    Sys.WebForms.PageRequestManager.getInstance().add_beginRequest(BeginRequestHandler);
                    Sys.WebForms.PageRequestManager.getInstance().add_endRequest(EndRequestHandler);
                    function BeginRequestHandler(sender, args)
                    {
                        Popup.ShowPopup();                    
                    }
                    function EndRequestHandler(sender, args)
                    {
                         Popup.HidePopup();     
                    }
    </script>
<h1>Custom Toolbar</h1>
<p>The built-in toolbar of PdfViewerControl can be replaced with a new custom toolbar. This can be achieved using the different events supported by PdfViewerControl and PdfDocumentView.</p>

    <div align="center" >
        <p>
           </p>
        <br />
<asp:Image ID="Image1" runat="server" />
      </div>
    
</asp:Content>
