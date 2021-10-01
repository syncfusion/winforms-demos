<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/samplebrowser.master"
    CodeFile="Sample.aspx.cs" Inherits="ScheduleTemplteSample" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    <title>Essential Pdf Viewer : Export as Image Demo : Syncfusion</title>
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
<h1>Export as Image</h1>
<p>Currently viewed PDF file can be exported as raster image. Selected or all pages of the document can be exported. This sample demonstrates how to export the PDF file as raster image.</p>

    <div align="center" >
        <p>
           </p>
        <br />
<asp:Image ID="Image1" runat="server" />
        <syncdemo:PropertyWindow ID="propertyWindow1" runat="server" ClientObjectId="prowin" PropertyWindowVisible="false"></syncdemo:PropertyWindow>
    </div>
    
</asp:Content>
