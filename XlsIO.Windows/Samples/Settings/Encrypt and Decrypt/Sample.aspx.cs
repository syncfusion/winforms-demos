using System;
using System.Web.UI;

public partial class ScheduleTemplteSample : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.Master != null)
        {
            samplebrowser master = Page.Master as samplebrowser;
            master.TogglePanelTitle = "Advanced Encrypt and Decrypt Sample";
            Image1.ImageUrl = "~/Excel 2007/Advanced Encrypt and Decrypt/Images/output.png";
        }
    }
}
