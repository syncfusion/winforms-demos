<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/samplebrowser.master"
    CodeFile="Sample.aspx.cs" Inherits="ScheduleTemplteSample" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitlePlaceHolder" runat="server">
    <title>Essential XlsIO (Excel) : Group Shapes : Syncfusion</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PagePlaceholder" runat="server">
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

    <div align="center" >
        <p>
           </p>
        <br />
        <asp:Image ID="Image1" runat="server" />
    </div>
    
</asp:Content>
