<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/samplebrowser.master"
    CodeFile="Sample.aspx.cs" Inherits="ScheduleTemplteSample" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    <title>Essential Pdf Viewer : Silent Printing Demo : Syncfusion</title>
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
<h1>Silent Printing</h1>
<p>The PDF file viewed in Pdf Viewer can be printed either through user interactive Print Dialog box or through silent printing. This sample demonstrates how to enable silent printing.</p>

    <div align="center" >
        <p>
           </p>
        <br />
<asp:Image ID="Image1" runat="server" />
        </div>
    
</asp:Content>
