using System;
using System.Web.UI;

public partial class ScheduleTemplteSample : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.Master != null)
        {
            samplebrowser master = Page.Master as samplebrowser;
            master.TogglePanelTitle = "Worksheet to HTML Sample";
            Image1.ImageUrl = "~/Sheet Manipulations/Worksheet to HTML/Images/sample.png";
        }
    }
}
