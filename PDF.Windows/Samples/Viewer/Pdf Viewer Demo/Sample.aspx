<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/samplebrowser.master"
    CodeFile="Sample.aspx.cs" Inherits="ScheduleTemplteSample" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    <title>Essential Pdf Viewer : Pdf Viewer Demo : Syncfusion</title>
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
<h1>Pdf Viewer Demo</h1>
<p>Pdf Viewer is a light weight viewer for viewing PDF files. It has a built-in user friendly toolbar for page navigation, zooming option, opening files and printing them to a selected printer. This sample demonstrates how to start with Pdf Viewer and helps to explore its features.</p>

    <div align="center" >
        <p>
           </p>
        <br />
<asp:Image ID="Image1" runat="server" />
       
    </div>
    
</asp:Content>
