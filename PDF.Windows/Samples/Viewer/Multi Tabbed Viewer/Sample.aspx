<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/samplebrowser.master"
    CodeFile="Sample.aspx.cs" Inherits="ScheduleTemplteSample" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    <title>Essential Pdf Viewer : Multi Tabbed Viewer Demo : Syncfusion</title>
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
<h1>Multi Tabbed Viewer</h1>
<p>You can view more than one PDF file simultaneously using the PdfDocumentView. It can be added as MDI child window associated with a custom toolbar, which helps you to achieve the desired multi-tabbed viewer.</p>

    <div align="center" >
        <p>
           </p>
        <br />
<asp:Image ID="Image1" runat="server" />
         </div>
    
</asp:Content>
