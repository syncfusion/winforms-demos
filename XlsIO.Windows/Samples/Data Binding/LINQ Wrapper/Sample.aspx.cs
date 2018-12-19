using System;
using System.Web.UI;

public partial class ScheduleTemplteSample : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.Master != null)
        {
            samplebrowser master = Page.Master as samplebrowser;
            master.TogglePanelTitle = "LINQ Wrapper Sample";
            Image1.ImageUrl = "~/Data Binding/LINQ Wrapper/Images/sample.png";
        }
    }
}
